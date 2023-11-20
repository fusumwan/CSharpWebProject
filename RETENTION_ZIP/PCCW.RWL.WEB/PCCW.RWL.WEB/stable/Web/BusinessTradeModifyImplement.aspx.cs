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
using System.Text;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using log4net;
using System.Reflection;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

public partial class BusinessTradeModifyImplement : System.Web.UI.Page
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
        
        if (!IsPostBack) InitFrame();

    }

    #region InitFrame
    public void InitFrame()
    {
        if (WebFunc.qsMid != null)
        {
            StringBuilder _sQuery = new StringBuilder();
            _sQuery.Append("INSERT INTO " + Configurator.MSSQLTablePrefix + "BusinessTradeExperience(rec_no, program, rate_plan, con_per, rebate, free_mon, hs_model, hs_model_name, premium_1,premium_2, trade_field, bundle_name, plan_fee, cancel_renew, ob_early, channel, sdate, edate, active, extra_offer, cid, cdate,normal_rebate_type,issue_type ) ");
            _sQuery.Append(" SELECT mid, program, rate_plan, con_per, rebate, free_mon, hs_model, hs_model_name, premium_1,premium_2, trade_field, bundle_name, plan_fee, cancel_renew, ob_early, channel, sdate, edate, active, extra_offer, '" + RWLFramework.CurrentUser[this.Page].Uid + "',getdate(),normal_rebate_type,issue_type from " + Configurator.MSSQLTablePrefix + "BusinessTrade ");
            _sQuery.Append(" WHERE mid='" + WebFunc.qsMid.ToString() + "'");
            GetDB().ExplicitNonQuery(_sQuery.ToString());
            n_oBusinessTrade = (BusinessTrade)BusinessTradeRepository.CreateEntityInstanceObject();
            n_oBusinessTrade.SetMid(WebFunc.qsMid);
            n_oBusinessTrade.Retrieve();
            n_oBusinessTrade.SetProgram(WebFunc.qsProgram.Trim());
            n_oBusinessTrade.SetRate_plan(WebFunc.qsRate_plan.Trim());
            n_oBusinessTrade.SetCon_per(WebFunc.qsCon_per.Trim());
            n_oBusinessTrade.SetHs_model(WebFunc.qsHs_model.Trim());
            n_oBusinessTrade.SetHs_model_name(WebFunc.qsHs_model_name.Trim());
            n_oBusinessTrade.SetTrade_field(WebFunc.qsTrade_field.Trim());
            n_oBusinessTrade.SetBundle_name(WebFunc.qsBundle_name.Trim());
            n_oBusinessTrade.SetPremium_1(WebFunc.qsPremium_1.Trim());
            n_oBusinessTrade.SetPremium_2(WebFunc.qsPremium_2.Trim());
            n_oBusinessTrade.SetPlan_fee(WebFunc.qsPlan_fee.Trim());
            n_oBusinessTrade.SetFree_mon(WebFunc.qsFree_mon.Trim());
            n_oBusinessTrade.SetChannel(WebFunc.qsChannel.Trim());
            n_oBusinessTrade.SetRebate(WebFunc.qsRebate.Trim());
            n_oBusinessTrade.SetNormal_rebate_type(WebFunc.qsNormal_rebate_type);
            if ("Y".Equals(WebFunc.qsCancel_renew))
                n_oBusinessTrade.SetCancel_renew(true);
            else
                n_oBusinessTrade.SetCancel_renew(false);

            string _sNormal_Rebate = Func.RQ(Request["normal_rebate"]).Trim();

 

            n_oBusinessTrade.SetSdate(WebFunc.qsSdate);
            n_oBusinessTrade.SetEdate(WebFunc.qsEdate);
            n_oBusinessTrade.SetPo_date(WebFunc.qsPo_date);
            n_oBusinessTrade.SetCid(RWLFramework.CurrentUser[this.Page].Uid);
            n_oBusinessTrade.SetCdate(DateTime.Now);
            n_oBusinessTrade.SetIssue_type(WebFunc.qsIssue_type.Trim());
            n_oBusinessTrade.SetRemarks(WebFunc.qsRemarks.Trim());
            n_oBusinessTrade.SetRebate(WebFunc.qsRebate.Trim());
            if (n_oBusinessTrade.Save())
            {
                program.Text = n_oBusinessTrade.GetProgram().Trim();
                rate_plan.Text = n_oBusinessTrade.GetRate_plan().Trim();
                con_per.Text = n_oBusinessTrade.GetCon_per().Trim();
                plan_free.Text = n_oBusinessTrade.GetPlan_fee().Trim();
                hs_model.Text = n_oBusinessTrade.GetHs_model().Trim();
                hs_model_name.Text = n_oBusinessTrade.GetHs_model_name().Trim();
                premium_1.Text = n_oBusinessTrade.GetPremium_1().Trim();
                premium_2.Text = n_oBusinessTrade.GetPremium_2().Trim();
                trade_field.Text = n_oBusinessTrade.GetTrade_field().Trim();
                bundle_name.Text = n_oBusinessTrade.GetBundle_name().Trim();
                rebate.Text = n_oBusinessTrade.GetRebate().Trim();
                if (n_oBusinessTrade.GetCancel_renew() != null) cancel_renew.Text = ((bool)n_oBusinessTrade.GetCancel_renew()).ToString().Trim();
                free_mon.Text = n_oBusinessTrade.GetFree_mon().Trim();
                normal_rebate_type.Text = n_oBusinessTrade.GetNormal_rebate_type();
                issue_type.Text = n_oBusinessTrade.GetIssue_type();
                channel.Text = n_oBusinessTrade.GetChannel().Trim();
                if (n_oBusinessTrade.GetSdate() != null) sdate.Text = ((DateTime)n_oBusinessTrade.GetSdate()).ToString("MM/dd/yyyy");
                if (n_oBusinessTrade.GetEdate() != null) edate.Text = ((DateTime)n_oBusinessTrade.GetEdate()).ToString("MM/dd/yyyy");
                if (n_oBusinessTrade.GetPo_date() != null) po_date.Text = ((DateTime)n_oBusinessTrade.GetPo_date()).ToString("MM/dd/yyyy");
            }
            else
                Response.Write("<script> alert('Modify Error!'); </script>");
        }
    }
    #endregion

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
