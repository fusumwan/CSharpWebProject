using System;
using System.Collections;
using System.Collections.ObjectModel;
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
using System.Text;
using System.Xml.Linq;
using System.Data.Sql;
using System.Data.SqlClient;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using log4net;
using System.Reflection;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;


public partial class AdminViewHistoryImplement : NEURON.WEB.UI.BasePage
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

    protected void InitFrame()
    {
        if (WebFunc.qsOrder_id != null)
            admin_view_rp1.DataSource = MobileOrderReportBal.GetSearch(GetDB(), " * ", "order_id='" + ((int)WebFunc.qsOrder_id).ToString() + "' and active=1 ", null, "cdate desc");
        
        admin_view_rp1.DataBind();

        if (WebFunc.qsOrder_id != null)
            admin_view_rp2.DataSource = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT * FROM " + Configurator.MSSQLTablePrefix + "MobileOrderReportHistory with(nolock) WHERE order_id='" + ((int)WebFunc.qsOrder_id).ToString() + "' AND active=1 order by ddate desc");
        
        admin_view_rp2.DataBind();
    }

    protected void admin_view_rp1_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (!(-1).Equals(e.Item.ItemIndex))
        {
            Literal _oReport_type = (Literal)e.Item.FindControl("report_type");
            if (_oReport_type.Text.Trim() == "rwl_suspend")
                _oReport_type.Text = "Suspension";
            else if (_oReport_type.Text.Trim()== "rwl_fast")
                _oReport_type.Text = "Early Start";
            else if (_oReport_type.Text.Trim()== "rwl")
                _oReport_type.Text = "New Order";
            else if (_oReport_type.Text.Trim() == "rwl_mod")
                _oReport_type.Text = "Modification";
            else if (_oReport_type.Text.Trim()== "rwl_NDS")
                _oReport_type.Text = "New NDS Order";
            else if (_oReport_type.Text.Trim()== "rwl_wo_hs")
                _oReport_type.Text = "New non-HS Order";
            else if (_oReport_type.Text.Trim()== "rwl_del")
                _oReport_type.Text = "Cancellation";
            else if (_oReport_type.Text.Trim() == "rwl_vas")
                _oReport_type.Text = "Change VAS";
            else if (_oReport_type.Text.Trim()== "rwl_opt_out")
                _oReport_type.Text = "Opt Out Order";
            else if (_oReport_type.Text.Trim()== "rwl_w_hs")
                _oReport_type.Text = "New HS Order";
        }
    }

    protected void admin_view_rp2_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (!(-1).Equals(e.Item.ItemIndex))
        {
            Literal _oReport_type = (Literal)e.Item.FindControl("report_type");
            if (_oReport_type.Text.Trim() == "rwl_suspend")
                _oReport_type.Text = "Suspension";
            else if (_oReport_type.Text.Trim() == "rwl_fast")
                _oReport_type.Text = "Early Start";
            else if (_oReport_type.Text.Trim() == "rwl")
                _oReport_type.Text = "New Order";
            else if (_oReport_type.Text.Trim() == "rwl_mod")
                _oReport_type.Text = "Modification";
            else if (_oReport_type.Text.Trim() == "rwl_NDS")
                _oReport_type.Text = "New NDS Order";
            else if (_oReport_type.Text.Trim() == "rwl_wo_hs")
                _oReport_type.Text = "New non-HS Order";
            else if (_oReport_type.Text.Trim() == "rwl_del")
                _oReport_type.Text = "Cancellation";
            else if (_oReport_type.Text.Trim() == "rwl_vas")
                _oReport_type.Text = "Change VAS";
            else if (_oReport_type.Text.Trim() == "rwl_opt_out")
                _oReport_type.Text = "Opt Out Order";
            else if (_oReport_type.Text.Trim() == "rwl_w_hs")
                _oReport_type.Text = "New HS Order";
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
        _oDB.SetConnStr(Configurator.DBName.ORADNS + ((!"".Equals(Configurator.IsUat())) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion
}
