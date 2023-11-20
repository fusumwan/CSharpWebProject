using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.Sql;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;


public partial class ReportAllFoCSA : DnaExpress.Web.UI.Page
{

    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion
    Hashtable n_oGprs_vas_desc = new Hashtable();
    Hashtable n_oSms_vas_desc = new Hashtable();
    protected void Page_Load(object sender, EventArgs e)
    {
        this.HeaderScripts.Text = string.Format(
        @"<script type=""text/javascript"" src=""{0}/Resources/Scripts/jquery-1.3.2.min.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/global.js""></script>
        <!--[if lte IE 6]><script defer type=""text/javascript"" src=""{0}/Resources/Scripts/pngfix.js""></script><![endif]-->
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/norefresh.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/script.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/jquery-ui-1.8.2.custom.min.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/jquery.alerts.js""></script>
        <link rel=""stylesheet"" href=""{0}/Resources/Styles/jquery.alerts.css"" type=""text/css"" />"
       , Request.ApplicationPath);

        WebFunc.PrivilegeCheck(this.Page);
        if (!IsPostBack) InitFrame();
        WebFunc.ExportExcel(this.Page, "RetentionOrderExcelResult.xls");
    }

    #region InitFrame
    protected void InitFrame()
    {
        SqlDataReader _oReader =BusinessVasDescriptionRepository.GetSearch(GetDB(),"vas_desc,fee","vas='gprs_vas'",null,"id desc");
        if (_oReader.Read()){
            if (!Func.IsDBNullOrEmpty(_oReader[BusinessVasDescription.Para.fee]))
                n_oGprs_vas_desc.Add(_oReader[BusinessVasDescription.Para.fee].ToString(), _oReader[BusinessVasDescription.Para.vas_desc].ToString());
        }
        if (_oReader != null) _oReader.Close(); _oReader.Dispose();
        _oReader = BusinessVasDescriptionRepository.GetSearch(GetDB(),"vas_desc,fee","vas='sms_vas'",null,"id");
        if(_oReader.Read()){
            if (!Func.IsDBNullOrEmpty(_oReader[BusinessVasDescription.Para.fee]))
                n_oSms_vas_desc.Add(_oReader[BusinessVasDescription.Para.fee].ToString(), _oReader[BusinessVasDescription.Para.vas_desc].ToString());
        }

        string _sQuery="select a.*, b.mid , b.email_date, b.report_type, b.fallout_remark, b.fallout_reply, b.order_status, b.fallout_main_category , b.fallout_reason, b.retrieve_sn, b.retrieve_date, b.cid as admin_sn, b.cdate as admin_date, b.did as mod_id, b.ddate as mod_date, c.vas_value as min_vas from "+Configurator.MSSQLTablePrefix+"MobileRetentionOrder a with (nolock) LEFT JOIN "+Configurator.MSSQLTablePrefix+"MobileOrderReport b with (nolock) ON a.order_id=b.order_id LEFT JOIN "+Configurator.MSSQLTablePrefix+"MobileOrderVas c ON a.order_id=c.order_id WHERE b.active=1 and c.vas_field='min_vas' ";
        _sQuery=_sQuery + " and b.order_status like 'FALLOUT%' ";
        _sQuery += " order by a.order_id";
        fo_csa_rp.DataSource = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
        fo_csa_rp.DataBind();
    }
    #endregion

    protected void fo_csa_rp_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (!(-1).Equals(e.Item.ItemIndex))
        {
            int orderDI = e.Item.ItemIndex + 1;
            Literal _oFo_csa = (Literal)e.Item.FindControl("fo_csa_id");
            Literal _oAccept =(Literal)e.Item.FindControl("accept");
            //Literal _oGprs_vas = (Literal)e.Item.FindControl("gprs_vas");
            //Literal _oSms_vas = (Literal)e.Item.FindControl("sms_vas");
            //Literal _oLicense_waiver = (Literal)e.Item.FindControl("license_waiver");
            Literal _oWaive = (Literal)e.Item.FindControl("waive");
            _oFo_csa.Text = orderDI.ToString();
            if ("Y".Equals(_oAccept.Text))
                _oAccept.Text = "Accept Autoroll ";
            else if ("reject".Equals(_oAccept.Text))
                _oAccept.Text = "Reject Autoroll (change to FTG) ";
            else if ("no_comment".Equals(_oAccept.Text))
                _oAccept.Text = "No Comment ";
            /*
            string _sGrps_vas_tmp = string.Empty;
            if (!"".Equals(_oGprs_vas.Text))
            {
                string[] _sGprs_vas = _oGprs_vas.Text.Split((",")[0]);
                _sGrps_vas_tmp = _sGprs_vas[0].ToString().Trim();
                if (_sGprs_vas.Length > 1){
                    if (!"".Equals(_sGprs_vas[1].ToString().Trim())){
                        if(n_oGprs_vas_desc.Contains(_sGprs_vas[1].ToString().Trim()))
                            _sGrps_vas_tmp += n_oGprs_vas_desc[_sGprs_vas[1].ToString().Trim()].ToString();
                    }
                }
            }
            _oGprs_vas.Text = _sGrps_vas_tmp;

            string _sSms_vas_tmp = string.Empty;
            if (!"".Equals(_oSms_vas.Text))
            {
                string[] _sSms_vas = _oSms_vas.Text.Split((",")[0]);
                _sSms_vas_tmp = _sSms_vas[0].ToString().Trim();
                if (_sSms_vas.Length > 1)
                {
                    if (!"".Equals(_sSms_vas[1].ToString().Trim()))
                    {
                        if(n_oSms_vas_desc.Contains(_sSms_vas[1].ToString().Trim()))
                            _sSms_vas_tmp += n_oSms_vas_desc[_sSms_vas[1].ToString().Trim()].ToString();
                    }
                }
            }
            _oSms_vas.Text = _sSms_vas_tmp;
            if(!"".Equals(_oLicense_waiver.Text))
                _oLicense_waiver.Text = _oLicense_waiver.Text.Substring(0, 1).ToString();

            */
            if (Func.IsParseBool(_oWaive.Text.ToString().Trim()))
            {
                if (Convert.ToBoolean(_oWaive.Text.ToString().Trim()))
                    _oWaive.Text = "Y";
                else
                    _oWaive.Text = "N";
            }

        }
    }

    #region GetDB
    protected MSSQLConnect GetDB()
    {
        MSSQLConnect _oDB = new MSSQLConnect();
        _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
        _oDB.bWithNoLock = true;
        return _oDB;
    }
    #endregion

    #region Get Oracle DB
    protected ODBCConnect GetORDB()
    {
        ODBCConnect _oDB = new ODBCConnect();
        _oDB.SetConnStr(Configurator.DBName.ORADNS+((Configurator.IsUat()) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion
}
