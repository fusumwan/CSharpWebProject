﻿using System;
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
using log4net;
using System.Reflection;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

public partial class HandSetUpload : NEURON.WEB.UI.BasePage
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
        if(!IsPostBack) InitFrame();
    }

    protected void InitFrame()
    {
        uploadto.SelectedValue = (Configurator.IsUat() ? "true" : "false");
    }

    #region GetDB
    protected MSSQLConnect GetDB()
    {
        MSSQLConnect _oDB = new MSSQLConnect();
        //_oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
        _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + (bool.Parse(uploadto.SelectedValue) ? "2" : string.Empty));
        _oDB.bWithNoLock = true;
        return _oDB;
    }
    #endregion

    #region Get Oracle DB
    protected ODBCConnect GetORDB()
    {
        ODBCConnect _oDB = new ODBCConnect();
        _oDB.SetConnStr(Configurator.DBName.ORADNS + (bool.Parse(uploadto.SelectedValue) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion
    protected void Submit_Click(object sender, EventArgs e)
    {
        Boolean _bFileOK = false;
        String _sPath = Server.MapPath("~/Web/upload/");
        string _sFilePath = string.Empty;
        if (ExcelUpload.PostedFile != null)
        {
            if (ExcelUpload.HasFile)
            {
                _sFilePath += _sPath + ExcelUpload.FileName;
                String _sFileExtension = System.IO.Path.GetExtension(ExcelUpload.FileName).ToLower();
                String[] allowedExtensions = { ".xls" };

                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (_sFileExtension == allowedExtensions[i])
                    {
                        _bFileOK = true;
                    }
                }
            }

            if (ExcelUpload.PostedFile.ContentLength > 10240000)
            {
                _bFileOK = false;
            }
            if (_bFileOK)
            {
                try
                {
                    string _sExcelVersion = excelversion.SelectedValue;
                    string _sIsUat = uploadto.SelectedValue;
                    string _sServerFilePath = "~/Web/upload/" + ExcelUpload.FileName;
                    if (WebFunc.CheckFileExists(this.Page, _sServerFilePath)) { WebFunc.DeleteFile(this.Page, _sServerFilePath); }
                    ExcelUpload.PostedFile.SaveAs(_sFilePath);
                    if (WebFunc.CheckFileExists(this.Page, _sServerFilePath))
                        Response.Redirect("HandSetUploadAction.aspx?FileName=" + ExcelUpload.FileName + "&excelversion=" + _sExcelVersion + "&uat=" + _sIsUat);
                }
                catch (Exception exp)
                {
                    string _sError = string.Format("<script>ALERT('ERROR : Cannot upload this excel file : \n {0} ');</script>", exp.ToString());
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "ERROR" + exp.ToString(), _sError, false);
                }
            }
            else
            {
                string _sError = "<script>ALERT('ERROR : Excel file size cannot larger than 10M! ');</script>";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ERROR 10M", _sError, false);
            }
        }
    }
}
