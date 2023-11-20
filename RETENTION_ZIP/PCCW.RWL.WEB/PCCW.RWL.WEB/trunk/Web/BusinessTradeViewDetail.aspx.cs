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
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Odbc;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using log4net;
using System.Reflection;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

public partial class BusinessTradeViewDetail : NEURON.WEB.UI.BasePage
{
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion
    BusinessTrade n_oBusinessTrade = null;
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
        modify.PostBackUrl = String.Format("BusinessTradeModify.aspx?mid={0}", WebFunc.qsMid);
        duplicate.PostBackUrl = String.Format("BusinessTradeDuplicate.aspx?mid={0}", WebFunc.qsMid);
        if (!IsPostBack) InitFrame();
        if(!IsPostBack) TradeViewDataBind();
    }

    #region TradeViewDataBind
    protected void TradeViewDataBind()
    {
        if (!"".Equals(Func.RQ(WebFunc.qsMid)))
        {
            n_oBusinessTrade = (BusinessTrade)BusinessTradeRepository.CreateEntityInstanceObject();
            n_oBusinessTrade.SetMid(WebFunc.qsMid);
            n_oBusinessTrade.Retrieve();
            program.Text = n_oBusinessTrade.GetProgram();
            rate_plan.Text = n_oBusinessTrade.GetRate_plan();
            con_per.Text = n_oBusinessTrade.GetCon_per();
            plan_free.Text = n_oBusinessTrade.GetPlan_fee();
            hs_model.Text = n_oBusinessTrade.GetHs_model();
            hs_model_name.Text = n_oBusinessTrade.GetHs_model_name();
            premium_1.Text = n_oBusinessTrade.GetPremium_1();
            premium_2.Text = n_oBusinessTrade.GetPremium_2();
            trade_field.Text = n_oBusinessTrade.GetTrade_field();
            bundle_name.Text = n_oBusinessTrade.GetBundle_name();
            rebate.Text = n_oBusinessTrade.GetRebate();
            issue_type.Text = n_oBusinessTrade.GetIssue_type();
            if (n_oBusinessTrade.GetCancel_renew() != null) cancel_renew.Text = ((bool)n_oBusinessTrade.GetCancel_renew()).ToString();
            free_mon.Text = n_oBusinessTrade.GetFree_mon();

            normal_rebate_type.Text = n_oBusinessTrade.GetNormal_rebate_type();


            channel.Text = n_oBusinessTrade.GetChannel();
            remarks.Text = n_oBusinessTrade.GetRemarks();
            if (n_oBusinessTrade.GetSdate() != null) sdate.Text = ((DateTime)n_oBusinessTrade.GetSdate()).ToString("MM/dd/yyyy");
            if (n_oBusinessTrade.GetEdate() != null) edate.Text = ((DateTime)n_oBusinessTrade.GetEdate()).ToString("MM/dd/yyyy");
            if (n_oBusinessTrade.GetPo_date() != null) po_date.Text = ((DateTime)n_oBusinessTrade.GetPo_date()).ToString("MM/dd/yyyy");
            active.Text = ((n_oBusinessTrade.GetActive()!=false)?"true":"false");
        }
    }
    #endregion

    protected void InitFrame()
    {
        if ("65535".Equals(RWLFramework.CurrentUser[this.Page].Lv) || "20".Equals(RWLFramework.CurrentUser[this.Page].Lv))
            duplicate.Visible = true;
        else
            duplicate.Visible = false;
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
