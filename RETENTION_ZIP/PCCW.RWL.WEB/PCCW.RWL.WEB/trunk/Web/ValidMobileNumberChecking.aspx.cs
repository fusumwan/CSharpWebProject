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


public partial class ValidMobileNumberChecking : NEURON.WEB.UI.BasePage
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
        if (!IsPostBack) InitFrame();
    }

    public void InitFrame()
    {
        bool _bMrt_exist = false;
        bool _bMrt_empty = false;
        
        if ((Func.RQ(Request["mrt_no"])).Trim().Equals(string.Empty))
            _bMrt_empty = true;
        else
            _bMrt_empty = false;

        string _sFilter = "active=1 and con_eff_date is not null and con_per is not null and dateadd(month, convert(float,con_per) -3,con_eff_date)>=getdate() and active=1 and mrt_no='" + Request["mrt_no"].ToString().Trim() + "'";

        if (!"".Equals(Func.RQ(Request["order_id"]).ToString()))
        {
            _sFilter = _sFilter + " AND order_id<>'" + Func.RQ(Request["order_id"]).ToString() + "'";
        }

        SqlDataReader _oReader = MobileRetentionOrderBal.GetSearch(SYSConn<MSSQLConnect>.Connect(), "con_eff_date,con_per,dateadd(month, convert(float,con_per) -3,con_eff_date)", _sFilter, null, null);
        if (_oReader != null)
        {
            if (_oReader.Read())
                _bMrt_exist = true;
            if (_oReader != null) _oReader.Close(); _oReader.Dispose();
        }

        if (_bMrt_empty)
        {
            Response.Write("<script>alert(\"Enter MRT 1st\")</script>");
            Response.Write("<script>window.opener.document.form1.mrt_no.select()</script>");
            Response.Write("<script>window.opener.document.form1.check_mrt_no.value=\"false\";</script>");
        }
        else if (_bMrt_exist)
        {

            Response.Write("<script>alert(\"MRT already Issued!\")</script>");
            Response.Write("<script>window.opener.document.form1.mrt_no.select()</script>");
            Response.Write("<script>window.opener.document.form1.check_mrt_no.value=\"false\";</script>");
        }
        else
        {
            Response.Write("<script>alert(\"PASS\")</script>");
            Response.Write("<script>window.opener.document.form1.mrt_no.value=\"true\"</script>");
            Response.Write("<script>window.opener.document.form1.check_mrt_no.readOnly=true;</script>");
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
