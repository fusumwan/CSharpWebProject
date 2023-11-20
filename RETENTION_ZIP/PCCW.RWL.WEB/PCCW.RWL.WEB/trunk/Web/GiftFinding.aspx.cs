using System;
using System.Collections;
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
using System.Globalization;
using System.Data.Odbc;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using log4net;
using System.Reflection;

using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;


public partial class GiftFinding : NEURON.WEB.UI.BasePage
{
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion
    string[] n_sDateTimeList = { "dd/mm/yyyy hh24:mi:ss" };
    string[] n_sDateTimeList2 = { "yyyymmdd'" };
    string n_sToday = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
    string n_sToday1 = DateTime.Now.ToString("yyyyMMdd");
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

    public void InitFrame()
    {

        OdbcDataReader _oDr=GiftControl.Instance().IMEINormalWithSku(Func.RQ(Request["sku"]).ToString());
        if (_oDr == null) return;
        if (_oDr.Read())
        {
            GiftControl _oGiftControl = GiftControl.Instance();
            _oGiftControl.SetOrd_id(Func.RQ(Request["ord_id"]));
            _oGiftControl.SetDummy1(Func.FR(_oDr["Dummy1"]));
            _oGiftControl.SetDummy2(Func.FR(_oDr["Dummy2"]));
            _oGiftControl.SetCreate_Date(Func.FR(_oDr["Create_Date"]));
            _oGiftControl.SetKit_Code(Func.FR(_oDr["Kit_Code"]));
            _oGiftControl.SetIMEI(Func.FR(_oDr["Model"]));
            _oGiftControl.SetStatus(Func.FR(_oDr["Status"]));
            _oGiftControl.SetReferenceNo(Func.FR(_oDr["ReferenceNo"]));
            _oGiftControl.SetDummy4(Func.FR(_oDr["DUMMY4"]));
            _oGiftControl.SetToday(n_sToday);
            _oGiftControl.SetToday1(n_sToday1);
            _oGiftControl.SetIMEI(Func.FR(_oDr["IMEI"]));
            _oGiftControl.SetSku(Func.RQ(WebFunc.qsSku));
            _oGiftControl.SetUid(RWLFramework.CurrentUser[this.Page].Uid);
            _oGiftControl.RecordGift();

            if (Func.FR(_oDr["check_imei"]) == "accessory_imei")
            {
                AccessoryIMEIControl _oAccessoryIMEIControl = AccessoryIMEIControl.Instance();
                _oAccessoryIMEIControl.SetEdf_no(_oGiftControl.GetEdf_no());
                _oAccessoryIMEIControl.SetToday(_oGiftControl.GetToday());
                _oAccessoryIMEIControl.SetUid(_oGiftControl.GetUid());
                _oAccessoryIMEIControl.SetSku(_oGiftControl.GetSku());
                _oAccessoryIMEIControl.SetIMEI(_oGiftControl.GetIMEI());
                _oAccessoryIMEIControl.RecordAccessoryIMEI();
            }
            else
            {
                GiftIMEIControl _oGiftIMEIControl = GiftIMEIControl.Instance();
                _oGiftIMEIControl.SetEdf_no(_oGiftControl.GetEdf_no());
                _oGiftIMEIControl.SetToday(_oGiftControl.GetToday());
                _oGiftIMEIControl.SetUid(_oGiftControl.GetUid());
                _oGiftIMEIControl.SetSku(_oGiftControl.GetSku());
                _oGiftIMEIControl.SetIMEI(Func.FR(_oDr["IMEI"]).Trim());
                _oGiftIMEIControl.RecordGiftIMEI(Func.FR(_oDr["check_imei"]));
            }
            

            wr("<script>window.opener.document.form1."+Func.RQ(Request["check_imei"])+".value=\""+Func.FR(_oDr["IMEI"])+"\";</script>");
            wr("<script>window.opener.document.form1.get_" + Func.RQ(Request["check_imei"]) + ".disabled=true;</script>");
            wr("<script>window.opener.document.form1.get_" + Func.RQ(Request["check_imei"]) + ".style.display=\"none\"</script>");
            wr("<script>window.opener.document.form1." + Func.RQ(Request["gift"]) + ".disabled=true;</script>");
            wr("<script>window.opener.document.form1.r_" + Func.RQ(Request["check_imei"]) + ".disabled=false;</script>");
            wr("<script>window.opener.document.form1.r_" + Func.RQ(Request["check_imei"]) + ".style.display=\"inline\"</script>");
        }
        else
        {
            wr("<script>window.opener.document.form1." + Func.RQ(Request["check_imei"]) + ".value=\"\";</script>");
            wr("<script>window.opener.document.form1.get_" + Func.RQ(Request["check_imei"]) + ".disabled=false;</script>");
            wr("<script>window.opener.document.form1.get_" + Func.RQ(Request["check_imei"]) + ".style.display=\"inline\"</script>");
            wr("<script>window.opener.document.form1." + Func.RQ(Request["gift"]) + ".disabled=false;</script>");
            wr("<script>window.opener.document.form1.r_" + Func.RQ(Request["check_imei"]) + ".disabled=true;</script>");
            wr("<script>window.opener.document.form1.r_" + Func.RQ(Request["check_imei"]) + ".style.display=\"none\"</script>");
            wr("<script>alert(\"NO STOCK\")</script>");
        }
        _oDr.Close();
        _oDr.Dispose();
    }


    public void wr(string x_sObj)
    {
        if (!string.IsNullOrEmpty(x_sObj)) { Response.Write(x_sObj); }
    }

    public string GetRdf(){
        OdbcDataReader _oDr2 = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT FTS_CPE5_Serial.NextVal AS seq, to_char(sysdate, 'yymon') AS cdate FROM dual");
        string _sRefNo = string.Empty;
        if (_oDr2 != null)
        {
            if (_oDr2.Read())
            {
                _sRefNo = _oDr2["seq"].ToString() + "/A/" + _oDr2["cdate"].ToString();
            }
        }
        _oDr2.Close();
        _oDr2.Dispose();
        

        return _sRefNo;
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
        _oDB.SetConnStr(Configurator.DBName.ORADNS + ((!"".Equals(Configurator.IsUat())) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion
}
