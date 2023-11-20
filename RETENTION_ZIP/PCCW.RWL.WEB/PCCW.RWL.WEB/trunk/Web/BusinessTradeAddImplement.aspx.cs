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
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;


public partial class BusinessTradeAddImplement : NEURON.WEB.UI.BasePage
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
        BusinessTrade _oBusinessTrade = (BusinessTrade)BusinessTradeRepository.CreateEntityInstanceObject();
        _oBusinessTrade.SetProgram(WebFunc.qsProgram.Trim());
        _oBusinessTrade.SetRate_plan(WebFunc.qsRate_plan.Trim());
        _oBusinessTrade.SetCon_per(WebFunc.qsCon_per.Trim());
        _oBusinessTrade.SetHs_model(WebFunc.qsHs_model.Trim());
        _oBusinessTrade.SetHs_model_name(WebFunc.qsHs_model_name.Trim());
        _oBusinessTrade.SetTrade_field(WebFunc.qsTrade_field.Trim());
        _oBusinessTrade.SetBundle_name(WebFunc.qsBundle_name.Trim());
        _oBusinessTrade.SetPlan_fee(WebFunc.qsPlan_fee.Trim());
        _oBusinessTrade.SetNormal_rebate_type(WebFunc.qsNormal_rebate_type);
        _oBusinessTrade.SetRebate(WebFunc.qsRebate.Trim());
        _oBusinessTrade.SetPremium_1(WebFunc.qsPremium.Trim());
        _oBusinessTrade.SetPremium_2(WebFunc.qsPremium_2.Trim());
        _oBusinessTrade.SetFree_mon(WebFunc.qsFree_mon.Trim());
        _oBusinessTrade.SetChannel(WebFunc.qsChannel.Trim());
        _oBusinessTrade.SetSdate(WebFunc.qsSdate);
        _oBusinessTrade.SetEdate(WebFunc.qsEdate);
        _oBusinessTrade.SetPo_date(WebFunc.qsPo_date);
        _oBusinessTrade.SetActive(true);
        _oBusinessTrade.SetCid(RWLFramework.CurrentUser[this.Page].Uid);
        _oBusinessTrade.SetCdate(DateTime.Now);
        _oBusinessTrade.SetRemarks(WebFunc.qsRemarks);
        _oBusinessTrade.SetIssue_type(WebFunc.qsIssue_type);
        using(ISession<MSSQLConnect> _oSession=(new SessionFactory<MSSQLConnect>()).OpenSession())
        using (ITransaction _oTransaction = _oSession.BeginTransaction())
        {
            _oSession.Insert(_oBusinessTrade);
            _oTransaction.Commit();
        }
        program.Text = WebFunc.qsProgram;
        normal_rebate_type.Text = WebFunc.qsNormal_rebate_type;

        rate_plan.Text = WebFunc.qsRate_plan;
        con_per.Text = WebFunc.qsCon_per;
        plan_fee.Text = WebFunc.qsPlan_fee;
        hs_model.Text = WebFunc.qsHs_model;
        hs_model_name.Text = WebFunc.qsHs_model_name;
        premium_1.Text = WebFunc.qsPremium_1;
        premium_2.Text = WebFunc.qsPremium_2;
        rebate.Text = WebFunc.qsRebate;
        free_mon.Text = WebFunc.qsFree_mon;
        trade_field.Text = WebFunc.qsTrade_field;
        bundle_name.Text = WebFunc.qsBundle_name;
        cancel_renew.Text = WebFunc.qsCancel_renew;
        channel.Text = WebFunc.qsChannel;
        remarks.Text = WebFunc.qsRemarks;
        issue_type.Text = WebFunc.qsIssue_type;
        if (WebFunc.qsSdate != null) sdate.Text = Convert.ToDateTime(WebFunc.qsSdate).ToString("MM/dd/yyyy");
        if (WebFunc.qsEdate != null) edate.Text =Convert.ToDateTime(WebFunc.qsEdate).ToString("MM/dd/yyyy");
        if (WebFunc.qsPo_date != null) po_date.Text = Convert.ToDateTime(WebFunc.qsPo_date).ToString("MM/dd/yyy");
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
    protected void submit23_Click(object sender, EventArgs e)
    {

    }
}
