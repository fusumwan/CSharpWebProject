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


public partial class SpecialPremiumReactiveImplement : NEURON.WEB.UI.BasePage
{
    MSSQLConnect n_oDB = null;
    private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
    string[] _sDateTimeList = { "M/dd/yyyy", "MM/d/yyyy", "M/d/yyyy", "M/dd/yyyy hh:mm:ss", "MM/d/yyyy hh:mm:ss", "M/d/yyyy hh:mm:ss" };
    DataSet n_oConPerList = new DataSet();
    DataSet n_oRatePlanList = new DataSet();
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
        if (!IsPostBack)
        {
            BindData();
        }
    }

    public void BindData()
    {
        if (n_oDB == null) { (n_oDB = SYSConn<MSSQLConnect>.Connect()).SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty)); }
        n_oConPerList = n_oDB.GetDS("select distinct con_per from " + Configurator.MSSQLTablePrefix + "BusinessTrade with (nolock) where active=1 ");
        n_oRatePlanList = n_oDB.GetDS("select distinct rate_plan from " + Configurator.MSSQLTablePrefix + "BusinessTrade with (nolock) where active=1 ");
        RWL_s_premium_RP.DataSource = n_oDB.GetDS("SELECT mid,rate_plan,con_per,s_premium FROM " + Configurator.MSSQLTablePrefix + "SpecialPremium WHERE rate_plan in (select distinct rate_plan from " + Configurator.MSSQLTablePrefix + "BusinessTrade with (nolock) where active=1) and con_per in (select distinct con_per from " + Configurator.MSSQLTablePrefix + "BusinessTrade with (nolock) where active=1)  and  active=0 order by mid");
        RWL_s_premium_RP.DataBind();
    }




    protected void RWL_s_premium_RP_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (n_oDB == null) { (n_oDB = SYSConn<MSSQLConnect>.Connect()).SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty)); }
        if ("Reactive".Equals(e.CommandName))
        {
            Label _txtmid = (Label)e.Item.FindControl("txtmid");
            int _iSPremium_id = Convert.ToInt32(_txtmid.Text);
            DropDownList _drps_premium_RATE_PLAN = (DropDownList)e.Item.FindControl("drps_premium_RATE_PLAN");
            DropDownList _drps_premium_CON_PER = (DropDownList)e.Item.FindControl("drps_premium_CON_PER");
            Literal _txtSpecialPremium = (Literal)e.Item.FindControl("txtSpecialPremium");
            SpecialPremium _oSpecialPremium = new SpecialPremium(n_oDB, _iSPremium_id);
            if (_drps_premium_RATE_PLAN.SelectedValue != string.Empty) { _oSpecialPremium.SetS_premium(_drps_premium_RATE_PLAN.SelectedValue); }
            if (_drps_premium_CON_PER.SelectedValue != string.Empty) { _oSpecialPremium.SetCon_per(_drps_premium_CON_PER.SelectedValue); }
            _oSpecialPremium.SetS_premium(_txtSpecialPremium.Text);
            if (RWLFramework.CurrentUser[this.Page].Uid != null) _oSpecialPremium.SetCid(RWLFramework.CurrentUser[this.Page].Uid.ToString());
            _oSpecialPremium.SetCdate(DateTime.Now);
            _oSpecialPremium.SetActive(true);
            if (_oSpecialPremium.Save())
                BindData();
            else
                WebFunc.RegisterScriptEX(this.Page, "Re-active Error!");
        }

    }
    protected void RWL_s_premium_RP_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (!e.Item.ItemIndex.Equals(-1))
        {
            if (n_oRatePlanList.Tables.Count > 0)
            {
                DropDownList _drps_premium_RATE_PLAN = (DropDownList)e.Item.FindControl("drps_premium_RATE_PLAN");
                Label _txts_premium_RATE_PLAN = (Label)e.Item.FindControl("txts_premium_RATE_PLAN");
                _drps_premium_RATE_PLAN.Items.Clear();
                _drps_premium_RATE_PLAN.Items.Add(new ListItem(string.Empty, string.Empty));
                _drps_premium_RATE_PLAN.SelectedIndex = 0;
                for (int i = 0; i < n_oRatePlanList.Tables[0].Rows.Count; i++)
                {
                    _drps_premium_RATE_PLAN.Items.Add(new ListItem(n_oRatePlanList.Tables[0].Rows[i][0].ToString(), n_oRatePlanList.Tables[0].Rows[i][0].ToString()));
                    if (_txts_premium_RATE_PLAN.Text.ToUpper().Trim() == n_oRatePlanList.Tables[0].Rows[i][0].ToString().ToUpper().Trim())
                        _drps_premium_RATE_PLAN.SelectedValue = n_oRatePlanList.Tables[0].Rows[i][0].ToString();
                }
            }

            if (n_oConPerList.Tables.Count > 0)
            {
                DropDownList _drps_premium_CON_PER = (DropDownList)e.Item.FindControl("drps_premium_CON_PER");
                Label _txts_premium_CON_PER = (Label)e.Item.FindControl("txts_premium_CON_PER");
                _drps_premium_CON_PER.Items.Clear();
                _drps_premium_CON_PER.Items.Add(new ListItem(string.Empty, string.Empty));
                _drps_premium_CON_PER.SelectedIndex = 0;
                for (int i = 0; i < n_oConPerList.Tables[0].Rows.Count; i++)
                {
                    _drps_premium_CON_PER.Items.Add(new ListItem(n_oConPerList.Tables[0].Rows[i][0].ToString(), n_oConPerList.Tables[0].Rows[i][0].ToString()));
                    if (_txts_premium_CON_PER.Text.ToUpper().Trim() == n_oConPerList.Tables[0].Rows[i][0].ToString().ToUpper().Trim())
                        _drps_premium_CON_PER.SelectedValue = n_oConPerList.Tables[0].Rows[i][0].ToString();
                }
            }
            int orderID = e.Item.ItemIndex + 1;
            Label _oSPremiumNum = (Label)e.Item.FindControl("SPremiumNum");
            _oSPremiumNum.Text = orderID.ToString();
        }
    }
}