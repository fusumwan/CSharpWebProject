using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Text;

using log4net;
using System.Reflection;

using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using NEURON.WEB.UI;

public partial class VasViewImplement : NEURON.WEB.UI.BasePage
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

    #region GetDB
    public static MSSQLConnect GetDB()
    {
        MSSQLConnect _oDB = new MSSQLConnect();
        _oDB.bWithNoLock = true;
        _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion


    protected void ExportExcel_Click(object sender, EventArgs e)
    {
        vas_rp.ExportExcel("Excel.xls");
    }

    protected void VasViewObjectDataSource_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        
    }
    protected void VasViewObjectDataSource_Init(object sender, EventArgs e)
    {
        VasViewObjectDataSource.SelectParameters.Clear();
        VasViewObjectDataSource.SelectParameters.Add("x_sNormal_rebate_type", TypeCode.String, WebFunc.qsNormal_rebate_type);
        VasViewObjectDataSource.SelectParameters.Add("x_sProgram", TypeCode.String, WebFunc.qsProgram);
        VasViewObjectDataSource.SelectParameters.Add("x_sRate_plan", TypeCode.String, WebFunc.qsRate_plan);
        VasViewObjectDataSource.SelectParameters.Add("x_sVas_field", TypeCode.String, WebFunc.qsVas_field);
        VasViewObjectDataSource.SelectParameters.Add("x_sBundle_name", TypeCode.String, WebFunc.qsBundle_name);
        VasViewObjectDataSource.SelectParameters.Add("x_sHs_model", TypeCode.String, WebFunc.qsHs_model);
        VasViewObjectDataSource.SelectParameters.Add("x_sIssue_type", TypeCode.String, WebFunc.qsIssue_type);
    }
}
