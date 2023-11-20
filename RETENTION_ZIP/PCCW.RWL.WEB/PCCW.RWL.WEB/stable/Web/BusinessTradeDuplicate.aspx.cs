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
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;
using NEURON.ENTITY.FRAMEWORK.STOCK;


public partial class BusinessTradeDuplicate : NEURON.WEB.UI.BasePage
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
        ProgramDataBind();
        NormalRebateTypeBindData(true);
        RatePlanDataBind();
        ConPerDataBind();
        PlanFeeBind();
        RebateDataBind();
        FreeMonDataBind();
        HsmodelDataBind();
        TradeFieldDataBind();
        BundleNameDataBind();
        PremiumDataBind();
        IssueTypeBind();
        if (!"".Equals(WebFunc.qsMid))
        {
            n_oBusinessTrade = (BusinessTrade)BusinessTradeRepository.CreateEntityInstanceObject();
            n_oBusinessTrade.SetMid(WebFunc.qsMid);
            n_oBusinessTrade.Retrieve();
            program.Value = n_oBusinessTrade.GetProgram();
            WebFunc.DrpDownListSetSelectedValue(ref normal_rebate_type, n_oBusinessTrade.GetNormal_rebate_type().Trim().ToUpper());
            rate_plan.Value = n_oBusinessTrade.GetRate_plan();
            con_per.Value = n_oBusinessTrade.GetCon_per();
            plan_fee.Value = n_oBusinessTrade.GetPlan_fee();
            rebate.Value = n_oBusinessTrade.GetRebate();
            free_mon.Value = n_oBusinessTrade.GetFree_mon();
            trade_field.Value = n_oBusinessTrade.GetTrade_field();
            con_per.Value = n_oBusinessTrade.GetCon_per();
            plan_fee.Value = n_oBusinessTrade.GetPlan_fee();
            rebate.Value = n_oBusinessTrade.GetRebate();
            free_mon.Value = n_oBusinessTrade.GetFree_mon();
            hs_model_name.SelectedValue = n_oBusinessTrade.GetHs_model_name();
            if (!"P".Equals(n_oBusinessTrade.GetHs_model()))
                premium_1.Enabled = false;

            hs_model.SelectedValue = n_oBusinessTrade.GetHs_model();

            switch (n_oBusinessTrade.GetHs_model())
            {
                case "Y":
                    hs_model_name.Enabled = true;
                    premium_1.Enabled = false;
                    break;
                case "P":
                    hs_model_name.Enabled = false;
                    premium_1.Enabled = true;
                    break;
                case "A":
                    hs_model_name.Enabled = true;
                    premium_1.Enabled = true;
                    break;
                default:
                    hs_model_name.Enabled = false;
                    premium_1.Enabled = false;
                    break;
            }


            if (premium_1.Items.FindByValue(n_oBusinessTrade.GetPremium_1()) != null)
                premium_1.SelectedValue = n_oBusinessTrade.GetPremium_1();
            if (premium_21.Items.FindByValue(n_oBusinessTrade.GetPremium_2()) != null)
                premium_21.SelectedValue = n_oBusinessTrade.GetPremium_2();

            bundle_name.Value = n_oBusinessTrade.GetBundle_name();
            if (n_oBusinessTrade.GetCancel_renew() != null)
            {
                if ((bool)n_oBusinessTrade.GetCancel_renew())
                    cancel_renew.SelectedValue = "Y";
                else
                    cancel_renew.SelectedValue = "NIL";
            }
            else
                cancel_renew.SelectedValue = "NIL";

            channel.SelectedValue = n_oBusinessTrade.GetChannel().ToUpper();
            remarks.Text = n_oBusinessTrade.GetRemarks();
            if (n_oBusinessTrade.GetSdate() != null) sdate.Text = ((DateTime)n_oBusinessTrade.GetSdate()).ToString("MM/dd/yyyy");
            if (n_oBusinessTrade.GetEdate() != null) edate.Text = ((DateTime)n_oBusinessTrade.GetEdate()).ToString("MM/dd/yyyy");
            if (n_oBusinessTrade.GetPo_date() != null) po_date.Text = ((DateTime)n_oBusinessTrade.GetPo_date()).ToString("MM/dd/yyyy");
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


    public void IssueTypeBind()
    {
        ObjectArr _oItemList = BusinessTradeBal.GetIssueTypeList(false);
        for (int i = 0; i < _oItemList.Count; i++)
        {
            issue_type1.Items.Add(new ListItem(_oItemList[i].ToString(), _oItemList[i].ToString()));
        }
    }

    #region ProgramDataBind
    protected void ProgramDataBind()
    {
        List<string> _oProgramList = BusinessTradeBal.DrpProgramList();
        program1.Items.Clear();
        program1.Items.Add(new ListItem(string.Empty, string.Empty));
        for (int i = 0; i < _oProgramList.Count; i++)
        {
            program1.Items.Add(new ListItem(_oProgramList[i].ToString(), _oProgramList[i].ToString()));
        }
    }
    #endregion



    #region NormalRebateTypeBindData
    protected void NormalRebateTypeBindData(bool x_bIncludeAll)
    {
        if (normal_rebate_type != null)
        {
            normal_rebate_type.Items.Clear();
            ObjectArr _oNormalRebateType = FromRegisterControler.GetNormalRebateTypeList(x_bIncludeAll);
            for (int i = 0; i < _oNormalRebateType.Count; i++)
            {
                object _sKey = _oNormalRebateType.KeyFind(i);
                object _sValue = _oNormalRebateType.ValueFind(i);
                normal_rebate_type.Items.Add(new ListItem(_sKey.ToString(), _sValue.ToString()));
                if (x_bIncludeAll)
                {
                    if (_sKey.Equals("ALL"))
                        normal_rebate_type.SelectedValue = "";
                }
                else
                    normal_rebate_type.SelectedValue = "RETENTION";
            }
        }
    }
    #endregion

    #region RatePlan
    protected void RatePlanDataBind()
    {
        List<string> _oRatePlanList = BusinessTradeBal.DrpRatePlanList();
        rate_plan1.Items.Clear();
        rate_plan1.Items.Add(new ListItem(string.Empty, string.Empty));
        for (int i = 0; i < _oRatePlanList.Count; i++)
        {
            rate_plan1.Items.Add(new ListItem(_oRatePlanList[i].ToString(), _oRatePlanList[i].ToString()));
        }
    }
    #endregion

    #region Contract Period
    protected void ConPerDataBind()
    {
        List<string> _oConPerList = BusinessTradeBal.DrpCon_perList();
        con_per1.Items.Clear();
        con_per1.Items.Add(new ListItem(string.Empty, string.Empty));
        for (int i = 0; i < _oConPerList.Count; i++)
        {
            con_per1.Items.Add(new ListItem(_oConPerList[i].ToString(), _oConPerList[i].ToString()));
        }
    }
    #endregion

    #region Plan Fee
    protected void PlanFeeBind()
    {
        List<string> _oPlanFeeList = BusinessTradeBal.DrpPlanFeeList();
        plan_fee1.Items.Clear();
        plan_fee1.Items.Add(new ListItem(string.Empty, string.Empty));
        for (int i = 0; i < _oPlanFeeList.Count; i++)
        {
            plan_fee1.Items.Add(new ListItem(_oPlanFeeList[i].ToString(), _oPlanFeeList[i].ToString()));
        }
    }
    #endregion

    #region RebateDataBind
    protected void RebateDataBind()
    {
        List<string> _oRebateList = BusinessTradeBal.DrpRebateList();
        rebate1.Items.Clear();
        rebate1.Items.Add(new ListItem(string.Empty, string.Empty));
        for (int i = 0; i < _oRebateList.Count; i++)
        {
            rebate1.Items.Add(new ListItem(_oRebateList[i].ToString(), _oRebateList[i].ToString()));
        }
    }
    #endregion

    #region FreeMonDataBind
    protected void FreeMonDataBind()
    {
        List<string> _oFreeMonList = BusinessTradeBal.DrpFreeMonList();
        free_mon1.Items.Clear();
        free_mon1.Items.Add(new ListItem(string.Empty, string.Empty));
        for (int i = 0; i < _oFreeMonList.Count; i++)
        {
            free_mon1.Items.Add(new ListItem(_oFreeMonList[i].ToString(), _oFreeMonList[i].ToString()));
        }
    }
    #endregion

    #region HsmodelDataBind
    protected void HsmodelDataBind()
    {
        List<string> _oHsmodelList = BusinessTradeBal.DrpHsModelList();
        hs_model_name.Items.Clear();
        hs_model_name.Items.Add(new ListItem(string.Empty, string.Empty));
        for (int i = 0; i < _oHsmodelList.Count; i++)
        {
            hs_model_name.Items.Add(new ListItem(_oHsmodelList[i].ToString(), _oHsmodelList[i].ToString()));
        }
    }
    #endregion

    #region TradeFieldDataBind
    protected void TradeFieldDataBind()
    {
        List<string> _oTradeFieldList = BusinessTradeBal.DrpTradeFieldList();
        trade_field1.Items.Clear();
        trade_field1.Items.Add(new ListItem(string.Empty, string.Empty));
        for (int i = 0; i < _oTradeFieldList.Count; i++)
        {
            trade_field1.Items.Add(new ListItem(_oTradeFieldList[i].ToString(), _oTradeFieldList[i].ToString()));
        }
    }
    #endregion

    #region BundleName
    protected void BundleNameDataBind()
    {
        List<string> _oBundleNameList = BusinessTradeBal.DrpBundleNameList();
        bundle_name1.Items.Clear();
        bundle_name1.Items.Add(new ListItem(string.Empty, string.Empty));
        for (int i = 0; i < _oBundleNameList.Count; i++)
        {
            bundle_name1.Items.Add(new ListItem(_oBundleNameList[i].ToString(), _oBundleNameList[i].ToString()));
        }
    }
    #endregion

    #region Premium List
    protected void PremiumDataBind()
    {
        List<string> _oPremiumList = BusinessTradeBal.DrpPremiumHsList();
        premium_1.Items.Clear();
        premium_1.Items.Add(new ListItem(string.Empty, string.Empty));
        for (int i = 0; i < _oPremiumList.Count; i++)
        {
            premium_1.Items.Add(new ListItem(_oPremiumList[i].ToString(), _oPremiumList[i].ToString()));
        }
    }
    #endregion
}
