using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.Xml;
using System.Data.Odbc;
using System.Linq;
using System.Web.UI;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using NEURON.WEB.UI.HTMLCONTROL.JSCONTROL;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
public partial class AssignMobileIMEI : NEURON.WEB.UI.BasePage
{
    string n_sUid = string.Empty;
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion
    List<string> n_oInsertIPhoneRecordID = new List<string>();
    EDFStatusProfile _oEDFStatusProfile = new EDFStatusProfile();

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
	   
        RWLFramework.DataBaseConfigSetting();
        n_sUid = RWLFramework.CurrentUser[this.Page].Uid;

        if (n_sUid == string.Empty)
            n_sUid = "AUTOASSIGNID";
        

         
        if (!IsPostBack)
        {
            NeuronJSLibrary.Text = JSScriptLibrary.JSScriptCommon;
        }
    }

    #region PageLoadComplete
    protected void Page_LoadComplete(object sender, EventArgs e)
    {

        SetHtmlControlStyle("global-loading", HtmlTextWriterStyle.Display, "none", true);

    }
    #endregion


    #region Set HtmlControl Style By Javascript
    public string SetHtmlControlStyle(string x_sID, HtmlTextWriterStyle x_oStyle, string x_sValue, bool x_bStr)
    {
        Random ran = new Random();
        string _sScript = string.Empty;
        if (x_bStr)
            _sScript = string.Format("if(ChkID('{0}')){1}GetID('{2}').style.{3}='{4}';{5}", x_sID, "{", x_sID, x_oStyle.ToString().ToLower(), x_sValue, "}");
        else
            _sScript = string.Format("if(ChkID('{0}')){1}GetID('{2}').style.{3}={4};{5}", x_sID, "{", x_sID, x_oStyle.ToString().ToLower(), x_sValue, "}");

        _sScript = "<script>" + _sScript + "</script>";

        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), _sScript, false);

        return _sScript;
    }
    #endregion


    public bool UpdateImei(int x_iRecord_ID, string x_sIMEI, string x_sSKU)
    {
        AssignIMEIControl _oAssignIMEIControl = new AssignIMEIControl();
        if (string.IsNullOrEmpty(x_sIMEI)) return false;
        if (string.IsNullOrEmpty(x_sSKU)) return false;
        string _sQuery = "SELECT * FROM IMEI_STOCK WHERE DUMMY4='" + x_iRecord_ID + "' AND kit_code='" + x_sSKU + "' AND (STATUS='AO' or STATUS='AWAIT') ";
        OdbcDataReader _oChkDr = SYSConn<ODBCConnect>.Connect().GetSearch(_sQuery);
        if (!_oChkDr.Read())
        {
            Response.Write("<script>alert('Update Fail!');</script>");
            _oChkDr.Close();
            _oChkDr.Dispose();
            return false;
        }
        _oChkDr.Close();
        _oChkDr.Dispose();

        _sQuery = "SELECT * FROM IMEI_STOCK WHERE DUMMY4='" + x_iRecord_ID + "' AND kit_code='" + x_sSKU + "' AND (IMEI is  null or IMEI=' ') ";
        _oChkDr = SYSConn<ODBCConnect>.Connect().GetSearch(_sQuery);
        if (!_oChkDr.Read())
        {
            Response.Write("<script>alert('Update Fail!');</script>");
            _oChkDr.Close();
            _oChkDr.Dispose();
            return false;
        }
        _oChkDr.Close();
        _oChkDr.Dispose();

        StringBuilder _oUpdateStockQuery = new StringBuilder();
        _oUpdateStockQuery.Append("UPDATE IMEI_STOCK SET IMEI='" + x_sIMEI + "', STATUS='STOCK' WHERE (STATUS='AO' OR STATUS='AWAIT') AND DUMMY4='" + x_iRecord_ID + "' AND kit_code='" + x_sSKU + "' AND (IMEI is  null or IMEI=' ') AND ROWNUM<=1");
       bool  _bUpdateStockQuery=SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oUpdateStockQuery.ToString());
       bool _bUploadStockOrder=  _oAssignIMEIControl.UploadStockOrder(x_iRecord_ID, n_sUid, x_sIMEI, x_sSKU);

        if(!_bUpdateStockQuery || !_bUploadStockOrder)
            Response.Write("<script>alert('Update Fail!');</script>");

       if (_bUploadStockOrder)
       {
           MobileManualAssignedHistory _oMobileManualAssignedHistory = new MobileManualAssignedHistory(SYSConn<MSSQLConnect>.Connect());
           _oMobileManualAssignedHistory.SetOrder_id(x_iRecord_ID - 100000);
           _oMobileManualAssignedHistory.SetImei_no(x_sIMEI);
           _oMobileManualAssignedHistory.SetSku(x_sSKU);
           _oMobileManualAssignedHistory.SetCid(RWLFramework.CurrentUser[this.Page].Uid);
           _oMobileManualAssignedHistory.SetCdate(DateTime.Now);
           if (MobileManualAssignedHistoryBal.InsertWithOutLastID(SYSConn<MSSQLConnect>.Connect(), _oMobileManualAssignedHistory))
           {

               MobileRetentionOrderBal.BackUpOrder(x_iRecord_ID - 100000, RWLFramework.CurrentUser[this].Uid);
           }
           MobileManualAssignedHistoryGW.DataBind();
           Response.Write("<script>alert('Update Success!');</script>");
       }
        return true;
    }



    protected bool CheckIMEINoInDB(string x_sIMEI)
    {
        if (string.IsNullOrEmpty(x_sIMEI)) return false;
        x_sIMEI = x_sIMEI.Trim();
        OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT imei FROM sunday_Form  WHERE referenceNo is not null AND referenceNo<>'' AND imei='" + x_sIMEI + "' AND rownum<=1");
        if (_oDr.Read())
        {
            if (!Func.FR(_oDr["imei"]).Trim().Equals(string.Empty))
            {
                _oDr.Close();
                _oDr.Dispose();
                return true;
            }
        }
        _oDr.Close();
        _oDr.Dispose();
        return false;
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
    protected void AssignBut_Click(object sender, EventArgs e)
    {
        int _iRecordID;
        if (int.TryParse(RecordID.Text, out _iRecordID))
        {
            if (UpdateImei(_iRecordID, IMEI.Text.ToString(), SKU.Text.ToString()))
            {
                
            }
        }
    }
}
