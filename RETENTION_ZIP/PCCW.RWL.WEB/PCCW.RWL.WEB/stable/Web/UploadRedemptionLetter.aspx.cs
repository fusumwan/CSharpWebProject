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


public partial class UploadRedemptionLetter : NEURON.WEB.UI.BasePage
{
    private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
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

    }

    protected void upload_but_Click(object sender, EventArgs e)
    {
        Boolean _bFileOK = false;
        Session["upfile"] =string.Empty;
        String _sPath = Server.MapPath("~/letter/");
        if (string.IsNullOrEmpty(RWLFramework.CurrentUser[this.Page].Uid))
        {
            RunJavascriptFunc("alert('User ID error!');");
            return;
        }


        if (FileUpload1.HasFile)
        {
            String _sFileExtension =System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
            String[] _sAllowedExtensions = { ".xls", ".XLS"};
            for (int i = 0; i < _sAllowedExtensions.Length; i++)
            {
                if (_sFileExtension == _sAllowedExtensions[i]) { _bFileOK = true; }
            }
        }

        if (FileUpload1.PostedFile.ContentLength > 10485760) { 
            _bFileOK = false;
            //This file size is larger than 10M
            RunJavascriptFunc("alert('This file size is larger than 10M!');");
        }
        if (_bFileOK)
        {
            try
            {
                string _sSaveFileName = RWLFramework.CurrentUser[this.Page].Uid.ToString() + DateTime.Now.ToString("yyyyMMdd") + FileUpload1.FileName;
                FileUpload1.PostedFile.SaveAs(_sPath + _sSaveFileName);
                //upload success
                //RunJavascriptFunc("alert('Upload success!');");
                Session["upfile"] = _sSaveFileName;
                Response.Redirect("UploadRedemptionLetterImplement.aspx");
            }
            catch
            {
                //cannot upload this file
                RunJavascriptFunc("alert('Cannot upload this file!');");
            }
        }

    }

    #region Run Javascript Function
    public void RunJavascriptFunc(string x_sFunc)
    {
        string _sFunc = ((x_sFunc.IndexOf(';') > 0) ? x_sFunc : x_sFunc + ";");
        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sFunc + (new Random()).Next(1, 1000).ToString()+Guid.NewGuid().ToString(), string.Format("<script>{0}</script>", _sFunc), false);
    }
    #endregion


}
