using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
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
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;


public partial class BusinessTradeViewImplement : NEURON.WEB.UI.BasePage
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
        edate.Text = Func.RQ(Request["edate"]);
        if(!IsPostBack) RwlTradeBind();
    }

    protected void RwlTradeBind()
    {
        if (Session["tradesql"] == null || Session["tradesql"]==string.Empty)
        {
            StringBuilder _oQuery = new StringBuilder();
            //_oQuery.Append("SELECT premium_1,premium_2,po_date,remarks,sdate,edate,channel,cancel_renew,bundle_name,trade_field,hs_model_name,hs_model,free_mon,rebate,mid,program,normal_rebate_type,rate_plan,plan_fee,con_per from ");
            _oQuery.Append("SELECT mid,issue_type,  program, normal_rebate_type, rate_plan, con_per, rebate, free_mon, hs_model, hs_model_name, premium_1, premium_2, trade_field, bundle_name, plan_fee, channel, sdate, edate, cid, cdate,cancel_renew,po_date,remarks from ");
            _oQuery.Append(Configurator.MSSQLTablePrefix + "BusinessTrade with (nolock) where active=1 ");
            if (!"".Equals(WebFunc.qsProgram.Trim()))
                _oQuery.Append(" AND program='" + WebFunc.qsProgram.Trim() + "' ");
            else if (!"".Equals(WebFunc.RequestQuery("program").Trim()))
                _oQuery.Append(" AND program='" + WebFunc.RequestQuery("program").Trim() + "' ");


            if (!"".Equals(WebFunc.qsNormal_rebate_type.Trim()))
                _oQuery.Append(" AND normal_rebate_type='" + WebFunc.qsNormal_rebate_type.Trim() + "' ");
            else if (!"".Equals(WebFunc.RequestQuery("normal_rebate_type").Trim()))
                _oQuery.Append(" AND normal_rebate_type='" + WebFunc.RequestQuery("normal_rebate_type").Trim() + "' ");

            if (!"".Equals(WebFunc.qsRate_plan.Trim()))
                _oQuery.Append(" AND rate_plan='" + WebFunc.qsRate_plan.Trim() + "' ");
            else if (!"".Equals(WebFunc.RequestQuery("rate_plan").Trim()))
                _oQuery.Append(" AND rate_plan='" + WebFunc.RequestQuery("rate_plan").Trim() + "' ");

            if (!"".Equals(WebFunc.qsCon_per.Trim()))
                _oQuery.Append(" AND con_per='" + WebFunc.qsCon_per.Trim() + "' ");
            else if (!"".Equals(WebFunc.RequestQuery("con_per").Trim()))
                _oQuery.Append(" AND con_per='" + WebFunc.RequestQuery("con_per").Trim() + "' ");

            if (!"".Equals(WebFunc.qsRebate.Trim()))
                _oQuery.Append(" AND rebate='" + WebFunc.qsRebate.Trim() + "' ");

            if (!"".Equals(WebFunc.qsFree_mon.Trim()))
                _oQuery.Append(" AND free_mon='" + WebFunc.qsFree_mon.Trim() + "' ");

            if (!"".Equals(WebFunc.qsPremium_1.Trim()))
                _oQuery.Append(" AND premium_1='" + WebFunc.qsPremium_1.Trim() + "' ");

            if (!"".Equals(WebFunc.qsPremium_2.Trim()))
                _oQuery.Append(" AND premium_2='" + WebFunc.qsPremium_2.Trim() + "' ");

            if (!"".Equals(WebFunc.qsTrade_field.Trim()))
                _oQuery.Append(" AND trade_field='" + WebFunc.qsTrade_field.Trim() + "' ");
            else if (!"".Equals(WebFunc.RequestQuery("trade_field").Trim()))
                _oQuery.Append(" AND trade_field='" + WebFunc.RequestQuery("trade_field").Trim() + "' ");

            if (!"".Equals(WebFunc.qsBundle_name.Trim()))
                _oQuery.Append(" AND bundle_name='" + WebFunc.qsBundle_name.Trim() + "' ");


            if (!"".Equals(WebFunc.qsIssue_type.Trim()))
                _oQuery.Append(" AND issue_type='" + WebFunc.qsIssue_type.Trim() + "' ");
            else if (!"".Equals(WebFunc.RequestQuery("issue_type").Trim()))
                _oQuery.Append(" AND issue_type='" + WebFunc.RequestQuery("issue_type").Trim() + "' ");
            if (!"".Equals(WebFunc.qsHs_model.Trim()))
            {
                if ("Y".Equals(WebFunc.qsHs_model.Trim()))
                    _oQuery.Append(" AND hs_model='Y' ");
                else if ("P".Equals(WebFunc.qsHs_model.Trim()))
                    _oQuery.Append(" AND hs_model='P' ");
                else if ("A".Equals(WebFunc.qsHs_model.Trim()))
                    _oQuery.Append(" AND hs_model='A' ");
                else if ("N".Equals(WebFunc.qsHs_model.Trim()))
                    _oQuery.Append(" AND hs_model='N' ");
            }
            else
            {

                if ("Y".Equals(WebFunc.RequestQuery("hs_model").Trim()))
                    _oQuery.Append(" AND hs_model='Y' ");
                else if ("P".Equals(WebFunc.RequestQuery("hs_model").Trim()))
                    _oQuery.Append(" AND hs_model='P' ");
                else if ("A".Equals(WebFunc.RequestQuery("hs_model").Trim()))
                    _oQuery.Append(" AND hs_model='A' ");
                else if ("N".Equals(WebFunc.RequestQuery("hs_model").Trim()))
                    _oQuery.Append(" AND hs_model='N' ");
            }

            Session["tradesql"] = _oQuery.ToString();
        }

        string _sFilter = string.Empty;
        if (!"".Equals(Session["tradesql"].ToString()))
        {
            _sFilter = Session["tradesql"].ToString();
         
        }

        if (Request["sort"] != null && Request["order"] != null && Session["tradesql"] != null)
        {
            if (!"".Equals(Session["tradesql"].ToString()))
            {
                _sFilter = Session["tradesql"].ToString() + " order by " + Func.RQ(Request["sort"]).ToString() + " " + Func.RQ(Request["order"]).ToString();
            }
        }
        if (!"".Equals(_sFilter))
        {
            Session["BusinessTradeViewSql"] = _sFilter;
            rwl_trade_rp.DataSource = GetDB().GetSearch(_sFilter);
            rwl_trade_rp.DataBind();
        }
    }
    protected void rwl_trade_rp_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (!e.Item.ItemIndex.Equals(-1))
        {
            CheckBox _oTrade_del = (CheckBox)e.Item.FindControl("trade_del");
            if (RWLFramework.CurrentUser[this.Page].Lv.Equals("65535"))
                _oTrade_del.Visible = true;
            else
                _oTrade_del.Visible = false;

            int _oOrderID = e.Item.ItemIndex + 1;
            Literal _oTradeid = (Literal)e.Item.FindControl("tradeid");
            _oTradeid.Text = _oOrderID.ToString();
        }
    }

    protected void TakeAction(bool x_bDelete)
    {
        string _sDelList = string.Empty;
        foreach (RepeaterItem _oRepeaterItem in rwl_trade_rp.Items)
        {
            CheckBox _oTrade_del = (CheckBox)_oRepeaterItem.FindControl("trade_del");
            if (_oTrade_del != null)
            {
                if (Func.IsParseInt(_oTrade_del.Attributes["value"]) && _oTrade_del.Checked)
                {
                    if (!"".Equals(_sDelList)) _sDelList += ",";
                    _sDelList += _oTrade_del.Attributes["value"].ToString().Trim();
                }
            }
        }

        if (!"".Equals(_sDelList)){
            if (x_bDelete)
            {
                StringBuilder _sQuery = new StringBuilder();
                _sQuery.Append("INSERT INTO " + Configurator.MSSQLTablePrefix + "BusinessTradeExperience(rec_no, program,issue_type, normal_rebate_type, rate_plan, con_per, rebate, free_mon, hs_model, hs_model_name, premium_1,premium_2, trade_field, bundle_name, plan_fee, cancel_renew, ob_early, channel, sdate, edate, active, extra_offer, cid, cdate,po_date,remarks ) ");
                _sQuery.Append(" SELECT mid, program,issue_type,  normal_rebate_type, rate_plan, con_per, rebate, free_mon, hs_model, hs_model_name, premium_1,premium_2, trade_field, bundle_name, plan_fee, cancel_renew, ob_early, channel, sdate, edate, active, extra_offer, '" + RWLFramework.CurrentUser[this.Page].Uid + "',getdate(),po_date,remarks from " + Configurator.MSSQLTablePrefix + "BusinessTrade ");
                _sQuery.Append(" WHERE mid in (" + _sDelList + ")");
                if (GetDB().ExplicitNonQuery(_sQuery.ToString()))
                {
                    if (BusinessTradeBal.SaveActive(GetDB(), false, RWLFramework.CurrentUser[this.Page].Uid, "mid in (" + _sDelList + ")"))
                        RunJavascriptFunc("alert('Delete Record Success!');");
                    else
                        RunJavascriptFunc("alert('Delete Record Fail!');");
                }
                else
                    RunJavascriptFunc("alert('Delete Record Fail!');");
            }
            else if (Func.IsParseDateTime(edate.Text))
            {
                DateTime _dEdate = Func.ConvertDatetime(edate.Text);
                if (BusinessTradeBal.SaveEndDate(GetDB(), _dEdate, RWLFramework.CurrentUser[this.Page].Uid, "mid in (" + _sDelList + ")"))
                    RunJavascriptFunc("alert('Update Record Success!');");
                else
                    RunJavascriptFunc("alert('Update Record Fail!');");
            }
        }
    }

    #region Run Javascript Function
    public void RunJavascriptFunc(string x_sFunc)
    {
        string _sFunc = ((x_sFunc.IndexOf(';') > 0) ? x_sFunc : x_sFunc + ";");
        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sFunc + (new Random()).Next(1, 1000).ToString()+Guid.NewGuid().ToString(), string.Format("<script>{0}</script>", _sFunc), false);
    }
    #endregion

    protected void TradeDelActionButton_Click(object sender, EventArgs e)
    {
        TakeAction(true);
        RwlTradeBind();
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

    protected void TakeUpdateAction_Click(object sender, EventArgs e)
    {
        TakeAction(false);
        RwlTradeBind();
    }
}
