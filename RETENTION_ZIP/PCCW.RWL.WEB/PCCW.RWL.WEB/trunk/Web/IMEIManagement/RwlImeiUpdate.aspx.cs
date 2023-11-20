using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using log4net;
using System.Reflection;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

public partial class Web_IMEIManagement_RwlImeiUpdate : System.Web.UI.Page
{
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
        MobileRetentionOrderObj.ConnectionString = SYSConn<MSSQLConn>.Connect().ConnectionStr;
        //WebFunc.PrivilegeCheck(this.Page);
        if (!IsPostBack)
        {
            InitFrame();
        }
    }

    public void InitFrame()
    {

    }

    public void SubmitBut_OnClick(object sender, EventArgs e)
    {
        string _sEdf_no = edf_no.Text;
        string _sImei_no = imei_no.Text;
        MobileRetentionOrderEntity[] _oMobileRetentionOrderArr = MobileRetentionOrderBal.GetArrayObj(SYSConn<MSSQLConnect>.Connect(),
            "edf_no='" + edf_no.Text + "'", null, null);
        if (_oMobileRetentionOrderArr != null)
        {
            if (_oMobileRetentionOrderArr.Length > 0)
            {
                if (MobileRetentionOrderBal.BackUpOrder((int)_oMobileRetentionOrderArr[0].order_id, RWLFramework.CurrentUser[this.Page].Uid))
                {
                    _oMobileRetentionOrderArr[0].SetImei_no(_sImei_no);
                    if (_oMobileRetentionOrderArr[0].Save())
                    {
                        RegisterJavaScript("jAlert('Update Sucess,'System Message');");
                        MobileRetentionOrderGv.DataBind();
                    }
                    else
                        RegisterJavaScript("jAlert('ERROR : Update Fail!','System Message');");
                }
                else
                {
                    RegisterJavaScript("jAlert('ERROR : Update Fail!','System Message');");
                }
            }
        }
    }

    #region RegisterJavaScript
    protected void RegisterJavaScript(string x_sScript)
    {
        RegisterJavaScript(string.Empty, x_sScript, true);
    }
    protected void RegisterJavaScript(string x_sID, string x_sScript, bool x_bIncludeScript)
    {
        if (x_bIncludeScript) x_sScript = "<script>" + x_sScript + "</script>";
        ScriptManager.RegisterStartupScript(this.Page, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), x_sScript, false);
    }
    #endregion

    protected void MobileRetentionOrderObj_Init(object sender, EventArgs e)
    {
        MobileRetentionOrderObj.ConnectionString = SYSConn<MSSQLConn>.Connect().ConnectionStr;
    }
}
