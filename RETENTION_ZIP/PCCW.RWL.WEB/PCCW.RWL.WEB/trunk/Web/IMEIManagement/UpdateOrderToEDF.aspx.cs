using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Text;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using NEURON.WEB.UI.HTMLCONTROL.JSCONTROL;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;


public partial class Web_IMEIManagement_UpdateOrderToEDF : NEURON.WEB.UI.BasePage
{

    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion
    #region SessionUid
    string n_sSessionUid
    {
        get
        {
            if (Session["uid"] != null)
            {
                return Session["uid"].ToString();
            }
            else
                return string.Empty;
        }
    }
    #endregion

    #region SessionLv
    string n_sSessionLv
    {
        get
        {
            if (Session["lv"] != null)
            {
                return Session["lv"].ToString();
            }
            else
                return string.Empty;
        }
    }
    #endregion

    #region SessionArprog
    string n_sSessionArprog
    {
        get
        {
            if (Session["arprog"] != null)
            {
                return Session["arprog"].ToString();
            }
            else
                return string.Empty;
        }
    }
    #endregion

    #region SessionChannel
    string n_sSessionChannel
    {
        get
        {
            if (Session["channel"] != null)
            {
                return Session["channel"].ToString();
            }
            else
                return string.Empty;
        }
    }
    #endregion
    EDFStatusProfile _oEDFStatusProfile = new EDFStatusProfile();

    StringBuilder RegisterJSScript = new StringBuilder();
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

        if (!IsPostBack){ InitFrame(); }
        AddWebLogScriptManager.RegisterAsyncPostBackControl(update_chk);
    }

    public void InitFrame()
    {
        
    }


    #region PageLoadComplete
    protected void Page_LoadComplete(object sender, EventArgs e)
    {
        RegisterJavaScript(string.Empty, RegisterJSScript.ToString(), true);
    }
    #endregion

    #region Run Javascript Function
    public string RunJavascriptFunc(string x_sFunc, bool x_bIncludeScript, bool x_bRunRegister)
    {
        string _sFunc = ((x_sFunc.IndexOf(';') > 0) ? x_sFunc : x_sFunc + ";");
        if (x_bIncludeScript) _sFunc = "<script>" + _sFunc + "</script>";
        if (x_bRunRegister)
            ScriptManager.RegisterStartupScript(this, this.GetType(), x_sFunc + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), _sFunc, false);
        else
            RegisterJSScript.AppendLine(_sFunc);
        return _sFunc;
    }


    public string RunJavascriptFunc(string x_sFunc)
    {
        return RunJavascriptFunc(x_sFunc, false, false);
    }
    #endregion

    #region RegisterJavaScript
    protected void RegisterJavaScript(string x_sID, string x_sScript, bool x_bIncludeScript)
    {
        if (x_bIncludeScript) x_sScript = "<script>" + x_sScript + "</script>";
        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), x_sScript, false);
    }
    #endregion
    protected void update_chk_Click(object sender, EventArgs e)
    {
        string _sEDF_no = edf_no.Value;
        if (!string.IsNullOrEmpty(_sEDF_no))
        {
            edf_no.Value = _sEDF_no.Trim();
            _sEDF_no = _sEDF_no.Trim();
            MobileRetentionOrderRepositoryBase _oMobileRetentionOrderRepositoryBase = new MobileRetentionOrderRepositoryBase(SYSConn<MSSQLConnect>.Connect());
            IQueryable<MobileRetentionOrderEntity> _oMobileRetentionOrderList = (from sMobileRetentionOrderList in _oMobileRetentionOrderRepositoryBase.MobileRetentionOrders where sMobileRetentionOrderList.edf_no == _sEDF_no select sMobileRetentionOrderList).Take(1);
            if (_oMobileRetentionOrderList != null)
            {
                if (_oMobileRetentionOrderList.Count<MobileRetentionOrderEntity>() > 0)
                {
                    MobileRetentionOrderEntity _oMobileRetentionOrderEntity = _oMobileRetentionOrderList.First<MobileRetentionOrderEntity>();
                    if (_oMobileRetentionOrderEntity.GetFound())
                    {
                        if (_oMobileRetentionOrderEntity.GetOrder_id() != null && RWLFramework.CurrentUser[this.Page].Uid != string.Empty)
                        {
                            if (_oEDFStatusProfile.UpdateEDF((int)_oMobileRetentionOrderEntity.GetOrder_id(), RWLFramework.CurrentUser[this.Page].Uid, Request.ServerVariables["REMOTE_ADDR"].ToString()))
                                RunJavascriptFunc("alert('Success : Reference No:" + _sEDF_no + " Order Updated!');");
                            else
                                RunJavascriptFunc("alert('Error : Order Id:" + ((int)_oMobileRetentionOrderEntity.GetOrder_id()).ToString() + "' failure to update the EDF record);");
                        }
                        else
                        {
                            if (_oMobileRetentionOrderEntity.GetOrder_id() == null)
                                RunJavascriptFunc("alert('Error : Order ID is null value');");
                            else if (string.IsNullOrEmpty(RWLFramework.CurrentUser[this.Page].Uid))
                                RunJavascriptFunc("alert('Error : Uid is null value');");
                            else
                                RunJavascriptFunc("alert('Error : Order Id:" + ((int)_oMobileRetentionOrderEntity.GetOrder_id()).ToString() + "' failure to update the EDF record);");
                        }
                    }
                    else 
                        RunJavascriptFunc("alert('Error : Cannot find reference number :" + _sEDF_no + "');");
                }
            }
        }
        else
        {
            RunJavascriptFunc("alert('Error : Please kindly enter the reference number!');");
        }
    }
}
