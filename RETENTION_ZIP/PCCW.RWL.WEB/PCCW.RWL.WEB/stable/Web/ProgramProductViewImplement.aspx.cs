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
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Odbc;
using System.Globalization;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;


public partial class ProgramProductViewImplement : NEURON.WEB.UI.BasePage
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

    public void InitFrame()
    {
        string _sToday = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("select * from " + Configurator.MSSQLTablePrefix + "RetentionProgramKey WHERE active=1 ");
        if (WebFunc.qsCdate != null)
            _oQuery.Append(" and cdate>='" + Convert.ToDateTime(WebFunc.qsCdate).ToString("dd/MM/yyyy") + " 00:00'");

        if (WebFunc.qsCdate2 != null)
            _oQuery.Append(" and cdate<='" + Convert.ToDateTime(WebFunc.qsCdate2).ToString("dd/MM/yyyy") + " 23:59'");

        if (!WebFunc.qsGo_wireless.Equals("ALL"))
        {
            if (WebFunc.qsGo_wireless.Equals("YES"))
                _oQuery.Append(" AND (a.go_wireless is not null AND a.go_wireless <>'NO' AND  a.go_wireless <>'') ");
            else if (WebFunc.qsGo_wireless.Equals("NO"))
                _oQuery.Append(" AND (a.go_wireless is null or a.go_wireless ='NO' or a.go_wireless='') ");
        }

        _oQuery.Append(" order by program_id");
        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
        record_count.Text = _oDr.FieldCount.ToString();
        admin_view_rp.DataSource = _oDr;
        admin_view_rp.DataBind();
        _oDr.Close();
        _oDr.Dispose();
    }

    #region Get Sql DB
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
