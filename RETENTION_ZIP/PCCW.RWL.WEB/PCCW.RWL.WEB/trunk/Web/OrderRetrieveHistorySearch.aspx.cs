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
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;



public partial class Web_OrderRetrieveHistorySearch : NEURON.WEB.UI.BasePage
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
        //if (!IsPostBack) 
        InitFrame();
    }

    protected void InitFrame()
    {
        StringBuilder _oWhereSql = new StringBuilder();
        _oWhereSql.Append("");

        // order_id (WebFunc.qsOrder_idName)
        if (Func.RB(WebFunc.qsOrder_id) && (Func.RB(WebFunc.qsOrder_id2) && !WebFunc.qsOrder_id2.Equals(string.Empty)))
            _oWhereSql.Append(" and order_id>='" + Func.IDSubtract100000(WebFunc.qsOrder_id).ToString() + "'");
        else if (Func.RB(WebFunc.qsOrder_id))
            _oWhereSql.Append(" and order_id='" + Func.IDSubtract100000(WebFunc.qsOrder_id).ToString() + "'");

        if (Func.RB(WebFunc.qsOrder_id2))
            _oWhereSql.Append(" and order_id<='" + Func.IDSubtract100000(Convert.ToInt32(WebFunc.qsOrder_id2)).ToString() + "'");

        // email_date
        if (Func.RB(WebFunc.qsEmail_date))
            _oWhereSql.Append(" and email_date>='" + ((DateTime)WebFunc.qsEmail_date).ToString("yyyyMMdd") + " 00:00'");
        if (Func.RB(WebFunc.qsEmail_date2))
            _oWhereSql.Append(" and email_date<='" + ((DateTime)WebFunc.qsEmail_date2).ToString("yyyyMMdd") + " 23:59'");

        // report_type (WebFunc.qsReport_typeName)
        if (Func.RB(WebFunc.qsReport_type))
            _oWhereSql.Append(" and report_type='" + WebFunc.qsReport_type.ToString() + "'");
        else
            _oWhereSql.Append(" and report_type<>'rwl_cust'");


        // order_status (WebFunc.qsOrder_statusName)
        if (Func.RB(WebFunc.qsOrder_status))
        {
            if ("no_follow".Equals(WebFunc.qsOrder_status))
                _oWhereSql.Append(" and (order_status='' or order_status is null)");
            else if ("no_follow_t4".Equals(WebFunc.qsOrder_status))
                _oWhereSql.Append(" and (order_status='' or order_status is null) and DATEDIFF(d,email_date,getdate())>4 ");
            else
                _oWhereSql.Append(" and order_status='" + WebFunc.qsOrder_status.ToString() + "'");
        }

        // retrieve_sn (WebFunc.qsRetrieve_snName)
        if (Func.RB(WebFunc.qsRetrieve_sn))
            _oWhereSql.Append(" and retrieve_sn='" + WebFunc.qsRetrieve_sn.ToString() + "'");

        // retrieve_date
        if (Func.RB(WebFunc.qsRetrieve_date))
            _oWhereSql.Append(" and retrieve_date>='" + ((DateTime)WebFunc.qsRetrieve_date).ToString("yyyyMMdd") + " 00:00'");
        if (Func.RB(WebFunc.qsRetrieve_date2))
            _oWhereSql.Append(" and retrieve_date<='" + ((DateTime)WebFunc.qsRetrieve_date2).ToString("yyyyMMdd") + " 23:59'");

        // reactive_sn (WebFunc.qsReactive_snName)

        if (Func.RB(WebFunc.qsRetrieve_sn))
            _oWhereSql.Append(" and retrieve_sn='" + WebFunc.qsRetrieve_sn.ToString() + "'");

        // reactive_date 
        if (Func.RB(WebFunc.qsReactive_date))
            _oWhereSql.Append(" and reactive_date>='" + ((DateTime)WebFunc.qsReactive_date).ToString("yyyyMMdd") + " 00:00'");
        if (Func.RB(WebFunc.qsReactive_date2))
            _oWhereSql.Append(" and reactive_date<='" + ((DateTime)WebFunc.qsReactive_date2).ToString("yyyyMMdd") + " 23:59'");


        if (_oWhereSql.ToString() != null || _oWhereSql.ToString() !="")
            //order_retrieve_history_rp.DataSource = MobileOrderReportBal.GetSearch(GetDB(), " * ", _oWhereSql.ToString(), null, "cdate desc");
            order_retrieve_history_rp.DataSource = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT * FROM " + Configurator.MSSQLTablePrefix + "MobileOrderReportHistory with(nolock) WHERE active=1 " + _oWhereSql.ToString() + " order by mid desc");

        order_retrieve_history_rp.DataBind();
    }

    protected void order_retrieve_history_rp_ItemDataBound(object sender, RepeaterItemEventArgs e)
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
