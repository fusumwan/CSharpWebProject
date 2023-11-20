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
using System.Data.SqlClient;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;


public partial class ProgramIDManagement : NEURON.WEB.UI.BasePage
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
        if (!IsPostBack) { InitFrame(); }
    }


    public void InitFrame()
    {
        if (WebFunc.qsProgram_id != null)
        {
            RetentionProgramKeyRepository _oRetentionProgramKeyRepository = new RetentionProgramKeyRepository(GetDB());
            IQueryable<RetentionProgramKeyEntity> _sRetentionProgramKeyList = from sRetentionProgramKeyList in _oRetentionProgramKeyRepository.RetentionProgramKeys
                                                                  where sRetentionProgramKeyList.program_id == WebFunc.qsProgram_id
                                                                  select sRetentionProgramKeyList;
            if (_sRetentionProgramKeyList.Count<RetentionProgramKeyEntity>() > 0)
            {

                RetentionProgramKeyEntity _oRetentionProgramKey = _sRetentionProgramKeyList.First<RetentionProgramKeyEntity>();
                program_id.Text = _oRetentionProgramKey.GetProgram_id().ToString().Trim();
                call_list_type.Text = _oRetentionProgramKey.GetCall_list_type().Trim();
                program_name.Text = _oRetentionProgramKey.GetProgram_name().Trim();
                center.Text = _oRetentionProgramKey.GetCenter().Trim();
                expiry_month.Text = _oRetentionProgramKey.GetExpiry_month().Trim();
                type.Text = _oRetentionProgramKey.GetType().Trim();
                remarks.Text = _oRetentionProgramKey.GetRemarks().Trim();
                if (_oRetentionProgramKey.GetUpload_date() != null) upload_date.Text = _oRetentionProgramKey.GetUpload_date().ToString().Trim();//"MM/dd/yyyy"
                if (_oRetentionProgramKey.GetSdate() != null) sdate.Text = _oRetentionProgramKey.GetSdate().ToString().Trim();
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