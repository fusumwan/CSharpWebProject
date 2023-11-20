using System;
using System.Collections;
using System.Collections.ObjectModel;
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
using System.Text;
using System.Xml.Linq;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Globalization;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;

public partial class Web_RetrieveGoWirelessAction : NEURON.WEB.UI.BasePage
{
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion

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
    }

    #region InitFrame
    protected void InitFrame()
    {
        VasControl _oVasControl = VasControl.Instance();
        _oVasControl.ReLoadDataToMemory();
        
        string _sOrderIDList = string.Empty;
        DataSet _oGoWirelessOrderDS = SYSConn<MSSQLConnect>.Connect().GetDS("SELECT a.vas_eff_date as vas_eff_date,a.order_id+100000 as Record_id, a.order_id order_id FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder a, " + Configurator.MSSQLTablePrefix + "MobileOrderReport b  WHERE ( a.go_wireless<>'NO' or   a.go_wireless<>'' or   a.go_wireless is not null ) AND  a.active=1  AND b.active=1 AND a.edf_no is not null  and  b.gw_retrieve_sn is null AND a.order_id=b.order_id AND b.report_type='rwl_go_wireless' ");
        DataSet _oGoWirelessEDFDS = SYSConn<ODBCConnect>.Connect().GetDS("SELECT  actual_del_date,agree_no,CANCELLED FROM SUNDAY_Form WHERE  (actual_del_date is not null or actual_del_date<>' ') AND CANCELLED='N' ");

        IDSQuery _oGoWirelessOrderDR = IDSQuery.CreateDsCriteria(_oGoWirelessOrderDS, string.Empty);
        while (_oGoWirelessOrderDR.Read())
        {
            string _sRecord_id = _oGoWirelessOrderDR["Record_id"].ToString();
            string _sQrder_id = _oGoWirelessOrderDR[MobileRetentionOrder.Para.order_id].ToString();
            string vas_eff_date = _oGoWirelessOrderDR["vas_eff_date"].ToString();
            int _iOrder_id;
            if (int.TryParse(_sQrder_id, out _iOrder_id))
            {
                IDSQuery _oGoWirelessEDFDR = IDSQuery.CreateDsCriteria(_oGoWirelessEDFDS, string.Empty)
                    .Add(DsExpression.Eq("agree_no", _sRecord_id));
                while (_oGoWirelessEDFDR.Read())
                {

                    string _sActual_del_date = ((DateTime)_oGoWirelessEDFDR["actual_del_date",false]).ToString("dd-MMM-yyyy");
                    DateTime _dNewDate;
                    if (DateTime.TryParseExact(_sActual_del_date, "dd-MMM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dNewDate))
                    {
                        _dNewDate = _dNewDate.AddDays(3);
                        if (!_sOrderIDList.Equals(string.Empty)) { _sOrderIDList += ","; }
                        _sOrderIDList += _sQrder_id;
                        MobileRetentionOrder _oMobileRetentionOrder = MobileRetentionOrderRepositoryBase.CreateEntityInstanceObject();
                        _oMobileRetentionOrder.SetOrder_id(_iOrder_id);
                        if (_oMobileRetentionOrder.Retrieve())
                            _oMobileRetentionOrder.SetCon_eff_date(_dNewDate);
                        
                        _oMobileRetentionOrder.Save();
                    }
                }
            }
        }

        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("SELECT a.*, b.mid, b.email_date, b.report_type, b.fallout_remark, b.fallout_reply, b.order_status, b.fallout_main_category , b.fallout_reason, b.retrieve_sn, b.retrieve_date, b.cid as admin_sn, b.cdate as admin_date FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder a with (nolock), " + Configurator.MSSQLTablePrefix + "MobileOrderReport b with (nolock) WHERE a.order_id=b.order_id AND b.active=1 AND a.active=1 AND b.gw_retrieve_sn is null ");
        if (!_sOrderIDList.Equals(string.Empty))
            _oQuery.Append(" and a.order_id in (" + _sOrderIDList + ") ");
        else
            _oQuery.Append(" and 1=0 ");

        if (Func.RB(WebFunc.qsEmail_date))
            _oQuery.Append(" and b.email_date>='" + ((DateTime)WebFunc.qsEmail_date).ToString("yyyyMMdd") + " 00:00'");

        if (Func.RB(WebFunc.qsEmail_date2))
            _oQuery.Append(" and b.email_date<='" + ((DateTime)WebFunc.qsEmail_date2).ToString("yyyyMMdd") + " 23:59'");

        if (Func.RB(WebFunc.qsLog_date))
            _oQuery.Append(" and a.log_date>='" + ((DateTime)WebFunc.qsLog_date).ToString("yyyyMMdd") + " 00:00'");

        if (Func.RB(WebFunc.qsLog_date2))
            _oQuery.Append(" and a.log_date<='" + ((DateTime)WebFunc.qsLog_date2).ToString("yyyyMMdd") + " 23:59'");

        /* Added on 16DEC2010 by Ben
 * Normal Search: by D_date, Plan_eff_date
 * Special PY Rule: D_date+1 if D_date is earlier, Plan_eff_date+3 if Plan_eff_date is earlier */

        _oQuery.Append(PYReportFunc.appendDDate_PlanEffDateToReportSQL((DateTime?)WebFunc.qsD_date, (DateTime?)WebFunc.qsD_date2, (DateTime?)WebFunc.qsPlan_eff_date, (DateTime?)WebFunc.qsPlan_eff_date2, (HttpContext.Current.Request["D_datePlan_eff_dateRule"] != null)));

        /* End */

        /* Added on 31DEC2010 by Ben
* For rwl_w_hs : amount>0 or amount=0 */

        string _sHandset_amount = (HttpContext.Current.Request["handset_amount"] == null ? "" : HttpContext.Current.Request["handset_amount"]);
        _oQuery.Append(PYReportFunc.appendHSAmountSQL(_sHandset_amount));

        /* End */

        if (Func.RB(WebFunc.qsMrt_no))
            _oQuery.Append(" and a.mrt_no='" + WebFunc.qsMrt_no.ToString() + "'");

        /*
        if (Func.RB(WebFunc.qsReport_type))
            _oQuery.Append(" and b.report_type='" + WebFunc.qsReport_type.ToString() + "'");
        else
            _oQuery.Append(" and b.report_type<>'rwl_cust'");
        */

        if (!WebFunc.qsGo_wireless.Equals("ALL")){
            if (WebFunc.qsGo_wireless.Equals("YES"))
                _oQuery.Append(" AND (a.go_wireless is not null AND a.go_wireless <>'NO' AND  a.go_wireless <>'') ");
            else if (WebFunc.qsGo_wireless.Equals("NO"))
                _oQuery.Append(" AND (a.go_wireless is null or a.go_wireless ='NO' or a.go_wireless='') ");
        }


        if (Func.RB(WebFunc.qsFallout_main_category))
            _oQuery.Append(" AND b.fallout_main_category='" + WebFunc.qsFallout_main_category.ToString() + "' ");

        if (Func.RB(WebFunc.qsFallout_reason))
            _oQuery.Append(" AND b.fallout_reason='" + WebFunc.qsFallout_reason.ToString() + "' ");


        /*
        if (Func.RB(WebFunc.qsOrder_status))
        {
            if ("no_follow".Equals(WebFunc.qsOrder_status))
                _oQuery.Append(" and (b.order_status='' or b.order_status is null)");
            else if ("no_follow_t4".Equals(WebFunc.qsOrder_status))
                _oQuery.Append(" and (b.order_status='' or b.order_status is null) and DATEDIFF(d,b.email_date,getdate())>4 ");
            else
                _oQuery.Append(" and b.order_status='" + WebFunc.qsOrder_status.ToString() + "'");
        }
        */
        _oQuery.Append(" and a.program<>'MOBILE LITE (SIM ONLY)' and a.program<>'MOBILE LITE (HS OFFER)'");
        _oQuery.Append(" ORDER BY a.order_id");
        SqlDataReader _oDr = GetDB().GetSearch(_oQuery.ToString());
        admin_view_rp.DataSource = _oDr;
        admin_view_rp.DataBind();
        record_cnt.Value = admin_view_rp.Items.Count.ToString();
        if (_oDr != null) _oDr.Close();
    }
    #endregion
    protected void admin_view_rp_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (!e.Item.ItemIndex.Equals(-1))
        {
            int _iOrderID = e.Item.ItemIndex + 1;
            Literal _oViewid = (Literal)e.Item.FindControl("viewid");
            _oViewid.Text = _iOrderID.ToString();

        }
    }

    public string GetVasValue(object x_oVas, object x_oOrder_id)
    {
        if (x_oOrder_id == null) return string.Empty;
        if (x_oVas == null) return string.Empty;
        string x_sVas = x_oVas.ToString();
        int x_iOrder_id;
        if (int.TryParse(x_oOrder_id.ToString(), out x_iOrder_id))
            return VasControl.GetVasValue(x_iOrder_id, x_sVas);
        
        return string.Empty;
    }

    public string NextBill(object x_oValue)
    {
        bool _bValue;
        if (x_oValue == null) return string.Empty;
        if (bool.TryParse(x_oValue.ToString(), out _bValue)){
            if (_bValue) return "Next Bill Cut Date";
        }
        return string.Empty;
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
        _oDB.SetConnStr(Configurator.DBName.ORADNS + ((Configurator.IsUat()) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion
}
