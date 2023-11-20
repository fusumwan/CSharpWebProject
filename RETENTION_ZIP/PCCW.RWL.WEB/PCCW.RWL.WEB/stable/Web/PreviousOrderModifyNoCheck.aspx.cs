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
using System.Xml.Linq;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Text;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using log4net;
using System.Reflection;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using NEURON.WEB.UI.HTMLCONTROL.JSCONTROL;
using NEURON.ENTITY.FRAMEWORK.STOCK;
public partial class PreviousOrderModifyNoCheck : NEURON.WEB.UI.BasePage
{
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion

    #region Parameter

    string n_sISSUE_TYPE
    {
        get
        {
            if (Request["ISSUE_TYPE"] != null)
            {
                return Request["ISSUE_TYPE"].ToString();
            }
            else
                return string.Empty;
        }
    }


    MSSQLConnect n_oDB = new MSSQLConnect();
    Staffinfo_new n_oStaffinfo_new = new Staffinfo_new();
    Hashtable n_oPlanFeeDrplist = new Hashtable();
    VasViewerController n_oVasViewerController = new VasViewerController();
    Dictionary<string, bool> n_oVasShowList = new Dictionary<string, bool>();
    StringBuilder RegisterJSScript = new StringBuilder();
    MobileRetentionOrder x_oMobileRetentionOrder = null;
    bool _bVasAutoDefaultSet = false;
    int _iDeli_flag = 1;
    int _iCon_flag = 1;
    #endregion

    #region Page Load
    protected void Page_Load(object sender, EventArgs e)
    {
        CheckOrderLock();
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
        RWLFramework.InitModel();
        RegisterAsyncPostBackControl();
        //GiftVasReLoadSelected();
        //GiftVasCreate();
        if (!IsPostBack)
        {
            NeuronJSLibrary.Text = JSScriptLibrary.JSScriptCommon;
            GiftHtmlVasCreate();
            BindData();
            RegisterJSScript.AppendLine("HideAllTable();");
            RegisterJSScript.AppendLine("ShowTable('TBL1','Tab1');");
            GiftDisabled();
            if (VasAutoSetScript.Instance().VasSetScript.ContainsKey(issue_type.Value) && !
                issue_type.Value.Equals(string.Empty))
            {
                VasSetScript.Text = VasAutoSetScript.Instance().VasSetScript[issue_type.Value].ToString();
            }
            if (Request["re_confirm"] != null)
                re_confirm.Value = Request["re_confirm"].ToString().ToUpper().Trim();

        }
        //ImeiInputPermitted();

        Ajax.Utility.RegisterTypeForAjax(typeof(PreviousOrderModifyNoCheck));
        JSCeksOnClickInit();
    }
	public void JSCeksOnClickInit()
    {
        if (this.Page.Request.Url.ToString().IndexOf("136.139.31.224") > 0)
        {
            if (Configurator.IsUat())
                but_card_no.Attributes["onclick"] = "CallCeks('card_no','3','ELOG','" + RWLFramework.CurrentUser[this].Uid.ToString() + "')";
            else
                but_card_no.Attributes["onclick"] = "CallCeks('card_no','5','ELOG','" + RWLFramework.CurrentUser[this].Uid.ToString() + "')";

            if (Configurator.IsUat())
                but_m_card_no.Attributes["onclick"] = "CallCeks('m_card_no','3','ELOG','" + RWLFramework.CurrentUser[this].Uid.ToString() + "')";
            else
                but_m_card_no.Attributes["onclick"] = "CallCeks('m_card_no','5','ELOG','" + RWLFramework.CurrentUser[this].Uid.ToString() + "')";
        }
        else if (this.Page.Request.Url.ToString().IndexOf("ccms.pccw.com") > 0)
        {
            if (Configurator.IsUat())
                but_card_no.Attributes["onclick"] = "CallCeks('card_no','6','ELOG','" + RWLFramework.CurrentUser[this].Uid.ToString() + "')";
            else
                but_card_no.Attributes["onclick"] = "CallCeks('card_no','8','ELOG','" + RWLFramework.CurrentUser[this].Uid.ToString() + "')";

            if (Configurator.IsUat())
                but_m_card_no.Attributes["onclick"] = "CallCeks('m_card_no','6','ELOG','" + RWLFramework.CurrentUser[this].Uid.ToString() + "')";
            else
                but_m_card_no.Attributes["onclick"] = "CallCeks('m_card_no','8','ELOG','" + RWLFramework.CurrentUser[this].Uid.ToString() + "')";
        }
    }


    #endregion

    protected void RegisteredBillingAddress3rdPartyFormView(string x_sIssue_type)
    {
        if (x_sIssue_type == "UPGRADE" || x_sIssue_type == "WIN")
        {
            RegisterJSScript.AppendLine("UserControlVisible('monthly_3rd_party_credit_card_info_show',true);");
        }
        else
        {
            RegisterJSScript.AppendLine("UserControlVisible('monthly_3rd_party_credit_card_info_show',false);");
        }

        if (x_sIssue_type == "WIN" || x_sIssue_type == "MOBILE_LITE" || x_sIssue_type == "UPGRADE")
        {
            RegisterJSScript.AppendLine("UserControlVisible('BillingAddressControl',false);");
            RegisterJSScript.AppendLine("UserControlVisible('same_register_address_show',false);");
            RegisterJSScript.AppendLine("UserControlVisible('monthly_bank_account_show',true);");
            RegisterJSScript.AppendLine("UserControlVisible('monthly_bank_account_holder_show',true);");
            

            RegisteredAddressControl.Enabled = true;
            BillingAddressControl.Enabled = true;
            MobileOrderMNPDetailControl.Enabled = true;

        }
        else
        {

            date_of_birth_show.Style[HtmlTextWriterStyle.Display] = "none";
            RegisteredAddressControl.Enabled = false;
            BillingAddressControl.Enabled = false;
            
            MobileOrderThreePartyControl.Enable = false;
            CopyRegisterAddToDeliveryAdd.Enabled = false;
            RegisterJSScript.AppendLine("UserControlVisible('RegisteredAddressControl',false);");
            //RegisterJSScript.AppendLine("UserControlVisible('bill_medium_email_show',false);");
            RegisterJSScript.AppendLine("UserControlVisible('bill_medium_show',false);");
            RegisterJSScript.AppendLine("UserControlVisible('BillingAddressControl',false);");
            RegisterJSScript.AppendLine("UserControlVisible('same_register_address_show',false);");
            
            RegisterJSScript.AppendLine("UserControlVisible('prepayment_show',false);");
            RegisterJSScript.AppendLine("UserControlVisible('MobileOrderThreePartyControl',false);");
            RegisterJSScript.AppendLine("UserControlVisible('monthly_bank_account_show',false);");
            RegisterJSScript.AppendLine("UserControlVisible('monthly_bank_account_holder_show',false);"); 
        }
        if (x_sIssue_type == "WIN" || x_sIssue_type == "MOBILE_LITE")
        {
            MobileOrderThreePartyControl.Enable = true;
        }
        else
        {
            MobileOrderMNPDetailControl.Enabled = false;
            RegisterJSScript.AppendLine("UserControlVisible('MobileOrderMNPDetailControl',false);");
        }
        if (x_sIssue_type == "MOBILE_LITE")
            DropListSelectedValue(ref MobileOrderMNPDetailControl.Company_name, "PCCW 2G");
        /*
        if (x_sIssue_type == "WIN")
            DropListSelectedValue(ref MobileOrderMNPDetailControl.Company_name, "PCCW 2G (PREPAID)");
         */
    }


    public void CheckOrderLock()
    {
        MobileOrderLockControl.Instance().RemoveExpiryLock();
        if (Request["mrt"] != null && !IsPostBack)
        {
            if (!Request["mrt"].ToString().Trim().Equals(string.Empty))
            {
                mrt_no.Value = Request["mrt"].ToString();

                if (MobileOrderLockControl.Instance().IsOrderLock(mrt_no.Value, CurrentLockStatus.ISSUE_ORDER, RWLFramework.CurrentUser[this.Page].Uid))
                {
                    MobileOrderLock _oMobileOrderLock = MobileOrderLockControl.Instance().FindByMobileNumber(mrt_no.Value);
                    if (_oMobileOrderLock != null)
                    {
                        string _sMsg = string.Format("Now user id: {0} is modifying the mobile number({1}) order in an other Retention Web Log session.", _oMobileOrderLock.Owner, mrt_no.Value);
                        //Response.Redirect("MobileOrderLockMessage.aspx?OrderLockMsg=" + _sMsg);
                    }
                }
                else
                {
                    MobileOrderLockControl.Instance().AddNewOrderLock(mrt_no.Value,
                        CurrentLockStatus.ISSUE_ORDER, false, string.Empty, string.Empty,
                        RWLFramework.CurrentUser[this.Page].Uid, string.Empty, WebFunc.PageName);
                }
            }
        }
        Session["ModifyOrder"] = "ModifyOrder";
    }
    #region Page UnLoad
    protected void Page_UnLoad(object sender, EventArgs e)
    {
        RegisterJSScript.AppendLine("PlanListNoLoad()");
        RegisterJSScript.AppendLine("TradeFListNoLoad()");
        RegisterJSScript.AppendLine("TradeRListNoLoad()");
        RegisterJSScript.AppendLine("TradeHsListNoLoad()");
        RegisterJSScript.AppendLine("TradePmuListNoLoad()");
        RegisterJSScript.AppendLine("PlanFeeNoLoad()");
        RegisterJSScript.AppendLine("ConListNoLoad()");
        RegisterJSScript.AppendLine("HsListNoLoad()");
        RegisterJSScript.AppendLine("OrgFeeListNoLoad()");
    }
    #endregion

    #region PageLoadComplete
    protected void Page_LoadComplete(object sender, EventArgs e)
    {
        PreLoadAutoVasSet();
        PageLoadCompleteUpdateLogic();
        SetHtmlControlStyle("global-loading", HtmlTextWriterStyle.Display, "none", true);
        RegisterJavaScript(string.Empty, RegisterJSScript.ToString(), true);
    }

    protected void PageLoadCompleteUpdateLogic()
    {
        RegisterJSScript.AppendLine("PageLoadCompleteUpdateLogic();");
    }

    protected void PreLoadAutoVasSet()
    {


        if (IsPostBack && _bVasAutoDefaultSet)
        {
            _bVasAutoDefaultSet = false;
            RegisterJSScript.AppendLine("VasAutoDefaultSet()");
        }

    }
    #endregion

    #region ImeiInputPermitted
    protected void ImeiInputPermitted()
    {
        if (RWLFramework.CurrentUser[this.Page].Lv.Equals("65535"))
        {
            gift_imei.Attributes.Remove("readonly");
            gift_imei2.Attributes.Remove("readonly");
            gift_imei3.Attributes.Remove("readonly");
            gift_imei4.Attributes.Remove("readonly");
            accessory_imei.Attributes.Remove("readonly");
        }
    }
    #endregion

    #region Submit GW Click
    protected void submit_gw_Click(object sender, EventArgs e)
    {
        MrtGoWireless();
    }
    #endregion

    #region Show Go Wire Less
    public void ShowGoWireLess()
    {

        if (n_sISSUE_TYPE == "GO_WIRELESS")
        {

            SetHtmlControlStyle("org_mrt_show", HtmlTextWriterStyle.Display, "inline", true);
            SetHtmlControlStyle("load_go_wireless", HtmlTextWriterStyle.Display, "none", true);
            GWRelTrShow(true);
        }
        else
        {
            SetHtmlControlStyle("org_mrt_show", HtmlTextWriterStyle.Display, "none", true);
            SetHtmlControlStyle("load_go_wireless", HtmlTextWriterStyle.Display, "none", true);
            GWRelTrShow(false);
        }
    }
    #endregion

    #region GW Show
    public void GWRelTrShow(bool x_bValue)
    {
        string _sValue = (x_bValue) ? "inline" : "none";
        string _sValue2 = (!x_bValue) ? "inline" : "none";
        preferred_languages.Enabled = !x_bValue;
        //SetHtmlControlStyle("waiving_show", HtmlTextWriterStyle.Display, _sValue2, true);
        //SetHtmlControlStyle("existing_customer_type_show", HtmlTextWriterStyle.Display, _sValue2, true);
        //SetHtmlControlStyle("original_tariff_fee_show", HtmlTextWriterStyle.Display, _sValue2, true);

        //SetHtmlControlStyle("existing_contract_end_month_show", HtmlTextWriterStyle.Display, _sValue2, true);
        //SetHtmlControlStyle("action_required_show", HtmlTextWriterStyle.Display, _sValue2, true);
        //SetHtmlControlStyle("suspend_date_show", HtmlTextWriterStyle.Display, _sValue2, true);
        //SetHtmlControlStyle("suspend_reasons_show", HtmlTextWriterStyle.Display, _sValue2, true);
        SetHtmlControlStyle("org_mrt_show", HtmlTextWriterStyle.Display, _sValue, true);
        if (x_bValue)
        {
            program.Items.Clear();
            program.Items.Add("GO WIRELESS");
            program.SelectedIndex = 0;
            c_tier_sel_top();
            ProgramRelChanged();
            ajaxvas();

            if (rate_plan.Items.Count > 0)
                rate_plan.SelectedIndex = 1;

            rate_plan_changed();
        }
        SetHtmlControlStyle("special_approval_show", HtmlTextWriterStyle.Display, _sValue2, true);
        SetHtmlControlStyle("autoroll_show", HtmlTextWriterStyle.Display, _sValue2, true);
        SetHtmlControlStyle("rebate_show", HtmlTextWriterStyle.Display, _sValue2, true);
        SetHtmlControlStyle("free_monthly_fee_show", HtmlTextWriterStyle.Display, _sValue2, true);

        SetHtmlControlStyle("lob_type_show", HtmlTextWriterStyle.Display, _sValue2, true);
        SetHtmlControlStyle("lob_account_no_show", HtmlTextWriterStyle.Display, _sValue2, true);
        SetHtmlControlStyle("go_wireless_package_code_show", HtmlTextWriterStyle.Display, _sValue2, true);

        SetHtmlControlStyle("hs_model_show", HtmlTextWriterStyle.Display, _sValue2, true);
        SetHtmlControlStyle("sku_item_code_show", HtmlTextWriterStyle.Display, _sValue2, true);
        SetHtmlControlStyle("premium_show", HtmlTextWriterStyle.Display, _sValue2, true);
        SetHtmlControlStyle("special_premium_show", HtmlTextWriterStyle.Display, _sValue2, true);

        SetHtmlControlStyle("special_premium_delivery_date_show", HtmlTextWriterStyle.Display, _sValue2, true);
        SetHtmlControlStyle("special_premium_quota_reference_no_show", HtmlTextWriterStyle.Display, _sValue2, true);
        SetHtmlControlStyle("pos_reference_no_show", HtmlTextWriterStyle.Display, _sValue2, true);
        SetHtmlControlStyle("special_premium_2_show", HtmlTextWriterStyle.Display, _sValue2, true);

        SetHtmlControlStyle("monthly_rebate_amount_show", HtmlTextWriterStyle.Display, _sValue2, true);
        SetHtmlControlStyle("hs_rebate_amount_show", HtmlTextWriterStyle.Display, _sValue2, true);
        SetHtmlControlStyle("retention_offer_show", HtmlTextWriterStyle.Display, _sValue2, true);
        SetHtmlControlStyle("exta_rebate_amount_show", HtmlTextWriterStyle.Display, _sValue2, true);
        SetHtmlControlStyle("extra_rebate_show", HtmlTextWriterStyle.Display, _sValue2, true);

        SetHtmlControlStyle("cancel_auto_renewal_show", HtmlTextWriterStyle.Display, _sValue2, true);

        //show or hide go wireless
        SetHtmlControlStyle("go_wireless_show", HtmlTextWriterStyle.Display, _sValue, true);
        SetHtmlControlStyle("register_address_show", HtmlTextWriterStyle.Display, _sValue2, true);
        SetHtmlControlStyle("contract_effective_date_show", HtmlTextWriterStyle.Display, _sValue2, true);

        SetHtmlControlStyle("bill_cut_show", HtmlTextWriterStyle.Display, _sValue2, true);
        SetHtmlControlStyle("cooling_offer_show", HtmlTextWriterStyle.Display, _sValue2, true);
        SetHtmlControlStyle("monthly_payment_method_show", HtmlTextWriterStyle.Display, _sValue2, true);
        SetHtmlControlStyle("monthly_payment_type_show", HtmlTextWriterStyle.Display, _sValue2, true);
        SetHtmlControlStyle("credit_card_type_show", HtmlTextWriterStyle.Display, _sValue2, true);
        SetHtmlControlStyle("credit_card_holder_name_show", HtmlTextWriterStyle.Display, _sValue2, true);

    }
    #endregion

    #region Chk org MRT of GO WIRELESS
    public void MrtGoWireless()
    {
        if (org_mrt.Value != string.Empty)
        {
            SetHtmlControlStyle("load_go_wireless", HtmlTextWriterStyle.Display, "inline", true);
            submit_gw.Enabled = false;

            org_mrt.Attributes["readonly"] = "true";
            ODBMrtGwChk _oMrtGw = new ODBMrtGwChk(org_mrt.Value);
            if (_oMrtGw.bCheck())
            {
                Hashtable _oArrD = _oMrtGw.GetChkList();
                if (_oArrD.Contains("cust_name"))
                {
                    cust_name.Value = _oArrD["cust_name"].ToString();
                    given_name.Value = _oArrD["cust_name"].ToString();
                }
                if (_oArrD.Contains("ac_no")) ac_no.Value = _oArrD["ac_no"].ToString();
                if (_oArrD.Contains("id_type")) id_type.Value = _oArrD["id_type"].ToString();
                if (_oArrD.Contains("HKID1")) hkid.Value = _oArrD["HKID1"].ToString();
                if (_oArrD.Contains("HKID2")) hkid2.Value = _oArrD["HKID2"].ToString();
                if (_oArrD.Contains("exist_cust_plan"))
                {
                    if (ItemsValueContains(exist_cust_plan.Items, new ListItem(_oArrD["exist_cust_plan"].ToString(), _oArrD["exist_cust_plan"].ToString())))
                    {
                        exist_cust_plan.SelectedValue = _oArrD["exist_cust_plan"].ToString();
                    }

                }
                if (_oArrD.Contains("ob_program_id"))
                {
                    if (ItemsValueContains(exist_cust_plan.Items, new ListItem(_oArrD["ob_program_id"].ToString(), _oArrD["ob_program_id"].ToString())))
                    {
                        exist_cust_plan.SelectedValue = _oArrD["ob_program_id"].ToString();
                    }
                }
                if (_oArrD.Contains("org_fee"))
                {
                    if (!ItemsValueContains(org_fee.Items, new ListItem(_oArrD["org_fee"].ToString(), _oArrD["org_fee"].ToString())))
                    {
                        org_fee.Items.Add(new ListItem(_oArrD["org_fee"].ToString(), _oArrD["org_fee"].ToString()));
                    }
                }
            }
            else
            {
                RegisterJSScript.AppendLine("alert(\"This MRT is valid\");");
                org_mrt.Value = string.Empty;
                RegisterJSScript.AppendLine("delivery_style(\"no\");");
                submit_gw.Enabled = true;
                org_mrt.Attributes["readonly"] = "false";
                org_mrt.Attributes.Remove("readonly");
            }
        }
        RegisterJSScript.AppendLine("NoLoadChkGW()");
    }
    #endregion

    #region CheckPlanFeeShow
    public void CheckPlanFeeShow()
    {
        if (rate_plan.SelectedValue == "3GHSDPA0098B" || rate_plan.SelectedValue == "3GHSDPA0488A" || rate_plan.SelectedValue == "3GHSDPA0488A-(UPSELL)" || rate_plan.SelectedValue == "3GHSDPA0498A")
        {
            show_plan_fee.Visible = true;
            RegisterJSScript.AppendLine("ShowPlanFee();");
        }
        else
        {
            show_plan_fee.Visible = false;
            RegisterJSScript.AppendLine("HidePlanFee();");
        }

        if (issue_type.Value.Trim().ToUpper().Equals("GO_WIRELESS"))
            RegisterJSScript.AppendLine("ShowPlanFee()");
        else if (program.SelectedValue.ToUpper().Equals("GO WIRELESS"))
            RegisterJSScript.AppendLine("ShowPlanFee()");
    }
    #endregion

    #region TierAllItemEnable
    public void TierAllItemEnable(bool x_bEnable)
    {
        program.Enabled = x_bEnable;
        normal_rebate_type.Enabled = x_bEnable;
        channel.Disabled = !x_bEnable;
        rate_plan.Enabled = x_bEnable;
        plan_fee.Enabled = x_bEnable;
        con_per.Enabled = x_bEnable;
        premium.Enabled = x_bEnable;
        trade_field.Enabled = x_bEnable;
        bundle_name.Enabled = x_bEnable;
        rebate.Enabled = x_bEnable;
        free_mon.Enabled = x_bEnable;
        s_premium.Enabled = x_bEnable;
        hs_model.Enabled = x_bEnable;
        r_offer4.Enabled = x_bEnable;
        rebate_amount4.Enabled = x_bEnable;
        amount.Disabled = !x_bEnable;
        extra_rebate4.Enabled = x_bEnable;
        extra_rebate_amount4.Enabled = x_bEnable;
    }
    #endregion

    #region ProgramListBindData
    protected void ProgramListBindData()
    {
        if (x_oMobileRetentionOrder != null)
        {
            string _sMobileLevelDesc = string.Empty;
            MobileRetentionOrder _oMobileRetentionOrder = x_oMobileRetentionOrder;
            if (_oMobileRetentionOrder.Retrieve())
            {
                if (_oMobileRetentionOrder.GetMrt_no() != null)
                {
                    mrt_no.Value = ((int)_oMobileRetentionOrder.GetMrt_no()).ToString();
                    IQueryable<BusinessTradeEntity> _oRwlTradeBaseList = FromRegisterControler.Get_ProgramList(mrt_no.Value.ToString(), ref _sMobileLevelDesc,issue_type.Value);
                    program.Items.Clear();
                    program.Items.Add(new ListItem(string.Empty, string.Empty));
                    if (_oRwlTradeBaseList.Count<BusinessTradeEntity>() > 0)
                    {
                        List<string> _oPrograms = _oRwlTradeBaseList.Select(c => c.program).Distinct().ToList();
                        for (int i = 0; i < _oPrograms.Count; i++)
                        {
                            if (issue_type.Value == "MOBILE_LITE")
                            {
                                if ("MOBILE LITE (SIM ONLY)".Equals(_oPrograms[i].ToString()) ||
                                    "MOBILE LITE (HS OFFER)".Equals(_oPrograms[i].ToString()))
                                {
                                    program.Items.Add(new ListItem(_oPrograms[i].ToString(), _oPrograms[i].ToString()));
                                }
                            }
                            else
                            {
                                program.Items.Add(new ListItem(_oPrograms[i].ToString(), _oPrograms[i].ToString()));
                            }
                        }
                    }
                }
            }
        }
    }
    #endregion

    #region SimCardNameBindData
    protected void SimCardNameBindData()
    {
        global::System.Text.StringBuilder _sQuery = new global::System.Text.StringBuilder();
        _sQuery.Append("SELECT hs_model, item_code FROM ");
        _sQuery.Append(Configurator.MSSQLTablePrefix + "ProductItemCode with (nolock)");
        _sQuery.Append(" WHERE active=1 AND type='SIM'");
        _sQuery.Append(" AND (hs_model is not null and hs_model <>'')");
        _sQuery.Append(" AND (edate is null or edate >getdate()-1)");
        _sQuery.Append(" AND sdate<=getdate() ");
        _sQuery.Append(" ORDER BY hs_model ASC");

        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery.ToString());
        sim_item_name1.Items.Clear();
        sim_item_name1.Items.Add(new ListItem(string.Empty, string.Empty));
        while (_oDr.Read())
        {
            
            sim_item_name1.Items.Add(new ListItem(_oDr["hs_model"].ToString(), _oDr["item_code"].ToString()));
        }

        _oDr.Close();
        _oDr.Dispose();
    }
    #endregion

    #region SuspendReasonBindData
    protected void SuspendReasonBindData()
    {
        IQueryable<SuspendEventDetailEntity> _oRwlSuspendList = FromRegisterControler.Get_SuspendReasons();
        reasons.Items.Clear();
        reasons.Items.Add(new ListItem(string.Empty, string.Empty));
        if (_oRwlSuspendList.Count<SuspendEventDetailEntity>() > 0)
        {
            List<string> _oReasons = _oRwlSuspendList.Select(c => c.reasons).Distinct().ToList();
            for (int i = 0; i < _oReasons.Count; i++)
            {
                reasons.Items.Add(new ListItem(_oReasons[i].ToString(), _oReasons[i].ToString()));
            }
        }
    }
    #endregion

    #region ExistingCustomerTypeBindData
    protected void ExistingCustomerTypeBindData()
    {
        IQueryable<TariffFeeScheduleEntity> _oRwlTariffFeeList = FromRegisterControler.Get_ExistCustomerType();
        exist_cust_plan.Items.Clear();
        exist_cust_plan.Items.Add(new ListItem(string.Empty, string.Empty));
        if (_oRwlTariffFeeList.Count<TariffFeeScheduleEntity>() > 0)
        {
            List<string> _oPrograms = _oRwlTariffFeeList.Select(r => r.program).Distinct().ToList();
            for (int i = 0; i < _oPrograms.Count; i++)
            {
                exist_cust_plan.Items.Add(new ListItem(_oPrograms[i].ToString().ToUpper(), _oPrograms[i].ToString().ToUpper()));
            }
        }
    }

    protected void exist_cust_plan_changed()
    {
        //Checked
        if ((0).Equals(exist_cust_plan.Items.Count)) return;
        IQueryable<TariffFeeScheduleEntity> _oRwlTariffFeeList = FromRegisterControler.Get_OrgFeeList(exist_cust_plan.SelectedValue);
        org_fee.Items.Clear();
        org_fee.Items.Add(new ListItem(string.Empty, string.Empty));
        if (_oRwlTariffFeeList.Count<TariffFeeScheduleEntity>() > 0)
        {
            List<string> _oFees = _oRwlTariffFeeList.Select(r => r.fee).Distinct().ToList();
            for (int i = 0; i < _oFees.Count; i++)
            {
                org_fee.Items.Add(new ListItem(_oFees[i].ToString(), _oFees[i].ToString()));
            }
        }
        RegisterJSScript.AppendLine("OrgFeeListNoLoad()");
    }
    protected void exist_cust_plan_SelectedIndexChanged(object sender, EventArgs e)
    {
        exist_cust_plan_changed();
    }
    #endregion

    #region Con Per Selected Changed
    protected void con_per_changed()
    {
        //Checked
        string _sProgram = ((program.Items.Count > 0) ? program.SelectedValue.ToString() : string.Empty);
        string _sCon_per = ((con_per.Items.Count > 0) ? con_per.SelectedValue.ToString() : string.Empty);
        string _sRate_plan = ((rate_plan.Items.Count > 0) ? rate_plan.SelectedValue.ToString() : string.Empty);
        string _sChannel = channel.Value;
        string _sPlan_fee = ((plan_fee.Items.Count > 0) ? plan_fee.SelectedValue.ToString() : string.Empty);
        string _sPlan_fee_rs = RWLFramework.Control<RebateProfileControler>().Get_PlanFee(_sRate_plan);
        string _sRebate = ((rebate.Items.Count > 0) ? rebate.SelectedValue.ToString() : string.Empty);
        string _sPremium = ((premium.Items.Count > 0) ? premium.SelectedValue.ToString() : string.Empty);
        string _sHs_model = ((hs_model.Items.Count > 0) ? hs_model.SelectedValue.ToString() : string.Empty);
        string _sFree_mon = ((free_mon.Items.Count > 0) ? free_mon.SelectedValue.ToString() : string.Empty);
        string _sNormal_rebate_type = normal_rebate_type.SelectedValue;

        if (n_sISSUE_TYPE != "GO_WIRELESS")
        {
            _sPlan_fee = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar("SELECT top 1 plan_fee FROM RetentionPlan WITH (NOLOCK) WHERE plan_code='" + _sRate_plan + "'  AND active=1");
            DropListSelectedValue(ref plan_fee, _sPlan_fee);
        }
        if ("".Equals(_sProgram) && !(new RebateGroup()).GetProgramTable().GetIsNullable()) return;
        List<string> _oHandSetList = RWLFramework.Control<HandSetEnvironment>().Get_DrpHandSetList(_sProgram, _sCon_per, _sRate_plan, _sPlan_fee, _sNormal_rebate_type, _sChannel,issue_type.Value);

        c_rebate_amount();
        c_r_offer();
        c_hs_model();
        c_premium();
        c_trade_field();
        c_bundle_name();
        c_rebate();
        c_free_mon();
        c_s_premium();

        sku.Value = "";
        hs_model.Enabled = true;
        free_mon.Enabled = true;
        rebate.Enabled = true;
        premium.Enabled = true;

        for (int i = 0; i < _oHandSetList.Count; i++)
        {
            if (!(_oHandSetList[i].ToString() == "ASUS EEE PC 900-W009X 12GB/XP/PEARL WHITE/CHI" && channel.Value == "OB" && con_per.SelectedValue == "24"))
            {
                hs_model.Items.Add(new ListItem(_oHandSetList[i].ToString().ToUpper(), _oHandSetList[i].ToString().ToUpper()));
            }
        }

        List<string> _oPremiumList = RWLFramework.Control<HandSetEnvironment>().Get_DrpPremiumList(_sProgram, _sCon_per, _sRate_plan, _sPlan_fee, _sNormal_rebate_type, _sChannel,issue_type.Value);

        for (int i = 0; i < _oPremiumList.Count; i++)
        {
            premium.Items.Add(new ListItem(_oPremiumList[i].ToString().ToUpper(), _oPremiumList[i].ToString().ToUpper()));
        }
        bool _bDisabledHandSet = false;
        bool _bDisabledPremium = false;
        List<string> _oTradeFieldList = FromRegisterControler.Get_TradeFieldList(_sProgram, _sCon_per, _sPlan_fee_rs, _sRate_plan, _sRebate, _sNormal_rebate_type, _sChannel, _sHs_model, _sPremium, _sFree_mon,ref _bDisabledHandSet,ref _bDisabledPremium,issue_type.Value);

        for (int i = 0; i < _oTradeFieldList.Count; i++)
        {
            trade_field.Items.Add(new ListItem(_oTradeFieldList[i].ToString().ToUpper(), _oTradeFieldList[i].ToString().ToUpper()));
        }
        if (trade_field.Items.Count > 1) trade_field.SelectedIndex = 1;

        List<string> _oBundleNameList = FromRegisterControler.Get_BundleNameList(_sProgram, _sCon_per, _sPlan_fee_rs, _sRate_plan, _sRebate, _sNormal_rebate_type, _sChannel, _sHs_model, _sPremium, _sFree_mon,ref _bDisabledHandSet,ref _bDisabledPremium,issue_type.Value);

        for (int i = 0; i < _oBundleNameList.Count; i++)
        {
            bundle_name.Items.Add(new ListItem(_oBundleNameList[i].ToString().ToUpper(), _oBundleNameList[i].ToString().ToUpper()));

        }
        if (bundle_name.Items.Count > 1) bundle_name.SelectedIndex = 1;

        List<string> _oRebateList = RWLFramework.Control<HandSetEnvironment>().Get_DrpRebateList(_sProgram, _sCon_per, _sRate_plan, _sPlan_fee, _sNormal_rebate_type, _sChannel,issue_type.Value);

        for (int i = 0; i < _oRebateList.Count; i++)
        {
            rebate.Items.Add(new ListItem(_oRebateList[i].ToString().ToUpper(), _oRebateList[i].ToString().ToUpper()));
        }

        List<string> _oFreeList = RWLFramework.Control<HandSetEnvironment>().Get_DrpFeeMonList(_sProgram, _sCon_per, _sRate_plan, _sPlan_fee, _sNormal_rebate_type, _sChannel,issue_type.Value);

        for (int i = 0; i < _oFreeList.Count; i++)
        {
            free_mon.Items.Add(new ListItem(_oFreeList[i].ToString().ToUpper(), _oFreeList[i].ToString().ToUpper()));
        }

        List<string> _oSPremium = RWLFramework.Control<HandSetEnvironment>().Get_SPremiumList(_sCon_per, _sRate_plan);

        for (int i = 0; i < _oSPremium.Count; i++)
        {
            s_premium.Items.Add(new ListItem(_oSPremium[i].ToString().ToUpper(), _oSPremium[i].ToString().ToUpper()));
        }

        ajaxvas();

        if (program.SelectedValue != "GO WIRELESS")
        {
            ListItem _oListItem = gift_desc1.Items.FindByValue("PCCW 3G 64K USIM (V1.0)");
            if (_oListItem != null)
            {
                gift_desc1.Items.Remove(_oListItem);
            }
        }

        if (gift_desc21.SelectedValue == "PCCW 3G 64K USIM (V1.0)")
        {
            ListItem _oListItem = gift_desc21.Items.FindByValue("PCCW 3G 64K USIM (V1.0)");
            if (_oListItem != null)
                gift_desc21.Items.Remove(_oListItem);
        }

        if (accessory_desc1.SelectedValue == "AUTO NETWORK SELECTOR (ANS) – E180")
        {
            ListItem _oListItem = accessory_desc1.Items.FindByValue("AUTO NETWORK SELECTOR (ANS) – E180");
            if (_oListItem != null)
                accessory_desc1.Items.Remove(_oListItem);
        }

        if (rate_plan.SelectedValue == "3GHSDPA0328A-(NB)RET" || rate_plan.SelectedValue == "3GHSDPA0328A-(NB)MOB" || rate_plan.SelectedValue == "3GHSDPA0328A-(NB)NET" || rate_plan.SelectedValue == "3GHSDPA0358A-(NB)")
        {
            if (accessory_desc1.Items.FindByValue("LENOVO S10-2 (6 CELL/BLACK COLOR/EN XP HOME)") == null)
                accessory_desc1.Items.Add(new ListItem("LENOVO S10-2 (6 CELL/BLACK COLOR/EN XP HOME)", "LENOVO S10-2 (6 CELL/BLACK COLOR/EN XP HOME)"));

            if (accessory_desc1.Items.FindByValue("LENOVO S10-2 (6 CELL/BLACK COLOR/TC XP HOME)") == null)
                accessory_desc1.Items.Add(new ListItem("LENOVO S10-2 (6 CELL/BLACK COLOR/TC XP HOME)", "LENOVO S10-2 (6 CELL/BLACK COLOR/TC XP HOME)"));
        }
        else
        {
            ListItem _oListItem1 = accessory_desc1.Items.FindByValue("LENOVO S10-2 (6 CELL/BLACK COLOR/EN XP HOME)");
            if (_oListItem1 != null)
                accessory_desc1.Items.Remove(_oListItem1);

            ListItem _oListItem2 = accessory_desc1.Items.FindByValue("LENOVO S10-2 (6 CELL/BLACK COLOR/TC XP HOME)");
            if (_oListItem2 != null)
                accessory_desc1.Items.Remove(_oListItem2);
        }

        if (rate_plan.SelectedValue == "3GHSDPA0328A-(NB)MOB" || rate_plan.SelectedValue == "3GHSDPA0328A-(NB)NET" || rate_plan.SelectedValue == "3GHSDPA0358A-(NB)")
        {
            if (accessory_desc1.Items.FindByValue("SAMSUNG NP-N135 (6 CELL/WHITE COLOR/XP HOME)") == null)
                accessory_desc1.Items.Add(new ListItem("SAMSUNG NP-N135 (6 CELL/WHITE COLOR/XP HOME)", "SAMSUNG NP-N135 (6 CELL/WHITE COLOR/XP HOME)"));
        }
        else
        {
            ListItem _oListItem1 = accessory_desc1.Items.FindByValue("SAMSUNG NP-N135 (6 CELL/WHITE COLOR/XP HOME)");
            if (_oListItem1 != null)
                accessory_desc1.Items.Remove(_oListItem1);
        }
        //hs_model.Enabled = !_bDisabledHandSet;
        //premium.Enabled = !_bDisabledPremium;
    }

    protected void con_per_selected_change()
    {
        c_tier_sel_top();
        con_per_changed();
        RegisterJSScript.AppendLine("HsListNoLoad()");
        PreLoadAutoVasSet();
    }

    protected void con_per_SelectedIndexChanged(object sender, EventArgs e)
    {
        con_per_selected_change();
        _bVasAutoDefaultSet = true;
    }
    #endregion

    #region Rate Plan Selected Changed
    protected void rate_plan_changed()
    {
        //Checked
        string _sProgram = ((program.Items.Count > 0) ? program.SelectedValue.ToString() : string.Empty);
        string _sRatePlan = ((rate_plan.Items.Count > 0) ? rate_plan.SelectedValue.ToString() : string.Empty);

        string _sChannel = channel.Value;
        
        string _sNormal_rebate_type = normal_rebate_type.SelectedValue;
        List<string> _oConPerList = RWLFramework.Control<BusinessContractPeriodControler>().Get_DrpConPerList(_sProgram, _sRatePlan, _sNormal_rebate_type, _sChannel,issue_type.Value);
        if ("".Equals(_sProgram) && !(new BusinessTrade()).GetProgramTable().GetIsNullable()) return;

        c_rebate_amount();
        c_r_offer();
        c_trade_field();
        c_bundle_name();
        c_hs_model();
        c_premium();
        c_con_per();
        c_rebate();
        c_free_mon();
        c_s_premium();
        c_s_approval();
        //c_plan_fee();
        //c_plan_fee_sel_top();

        if (!"".Equals(rate_plan.SelectedValue))
        {
            if ("3GMREFER0098A".Equals(rate_plan.SelectedValue) || "3GFTRIAL0098A".Equals(rate_plan.SelectedValue) || "3GFTRIAL0198A".Equals(rate_plan.SelectedValue) || "3GFTRIAL0298A".Equals(rate_plan.SelectedValue))
            {
                SetHtmlControlStyle("accept_0", HtmlTextWriterStyle.BackgroundColor, "#FFFFbb", true);
                SetHtmlControlStyle("accept_1", HtmlTextWriterStyle.BackgroundColor, "#FFFFbb", true);
                SetHtmlControlAtt("accept_0", HtmlTextWriterAttribute.Disabled, "false", false);
                SetHtmlControlAtt("accept_1", HtmlTextWriterAttribute.Disabled, "false", false);

                SetHtmlControlStyle("cancel_renew_0", HtmlTextWriterStyle.BackgroundColor, "#DDDDDD", true);
                SetHtmlControlStyle("cancel_renew_1", HtmlTextWriterStyle.BackgroundColor, "#DDDDDD", true);
                SetHtmlControlAtt("cancel_renew_0", HtmlTextWriterAttribute.Disabled, "true", false);
                SetHtmlControlAtt("cancel_renew_1", HtmlTextWriterAttribute.Disabled, "true", false);

                SetHtmlControlAtt("cancel_renew_0", HtmlTextWriterAttribute.Checked, "false", false);
                SetHtmlControlAtt("cancel_renew_1", HtmlTextWriterAttribute.Checked, "false", false);

            }
            else
            {
                SetHtmlControlStyle("accept_0", HtmlTextWriterStyle.BackgroundColor, "#DDDDDD", true);
                SetHtmlControlStyle("accept_1", HtmlTextWriterStyle.BackgroundColor, "#DDDDDD", true);
                SetHtmlControlAtt("accept_0", HtmlTextWriterAttribute.Disabled, "true", false);
                SetHtmlControlAtt("accept_1", HtmlTextWriterAttribute.Disabled, "true", false);

                SetHtmlControlStyle("cancel_renew_0", HtmlTextWriterStyle.BackgroundColor, "#FFFFbb", true);
                SetHtmlControlStyle("cancel_renew_1", HtmlTextWriterStyle.BackgroundColor, "#FFFFbb", true);
                SetHtmlControlAtt("cancel_renew_0", HtmlTextWriterAttribute.Disabled, "false", false);
                SetHtmlControlAtt("cancel_renew_1", HtmlTextWriterAttribute.Disabled, "false", false);
            }
        }


        for (int i = 0; i < _oConPerList.Count; i++)
        {
            con_per.Items.Add(new ListItem(_oConPerList[i].ToString().ToUpper(), _oConPerList[i].ToString().ToUpper()));
        }
        if (con_per.Items.Count > 0) con_per.SelectedIndex = 0;

        IQueryable<BusinessTradeEntity> _oRatePlanList = RWLFramework.Control<BusinessContractPeriodControler>().Get_DrpTradePlanFeeList(_sRatePlan,issue_type.Value);
        if (_oRatePlanList.Count<BusinessTradeEntity>() > 0)
        {
            List<string> _oPlanFees = _oRatePlanList.Select(r => r.plan_fee).Distinct().ToList();
            for (int i = 0; i < _oPlanFees.Count; i++)
            {
                if (_oPlanFees[i] != null)
                {
                    if (!plan_fee_contain_value(_oPlanFees[i].ToString().Trim(), true))
                    {
                        if (_oPlanFees[i] != null) plan_fee.Items.Add(new ListItem(_oPlanFees[i].ToString().Trim(), _oPlanFees[i].ToString().Trim()));
                        plan_fee_contain_value(_oPlanFees[i].ToString().Trim(), true);
                    }
                }
            }
            if (program.SelectedValue.ToUpper().Equals("GO WIRELESS"))
            {
                if (plan_fee.Items.Count > 0) plan_fee.SelectedIndex = 0;
            }
        }
        ajaxvas();
    }


    protected bool plan_fee_contain_value(string x_sObj, bool x_bSelected)
    {
        if (plan_fee.Items.Count > 0) { plan_fee.SelectedIndex = 0; }
        for (int i = 0; i < plan_fee.Items.Count; i++)
        {
            if (plan_fee.Items[i].Value.Trim() == x_sObj.Trim())
            {
                if (x_bSelected) plan_fee.SelectedIndex = i;
                return true;
            }
        }
        return false;
    }


    protected void rate_plan_SelectedIndexChanged(object sender, EventArgs e)
    {
        c_tier_sel_top();
        rate_plan_changed();
        RegisterJSScript.AppendLine("ConListNoLoad()");
        PreLoadAutoVasSet();
        _bVasAutoDefaultSet = true;
    }
    #endregion

    #region plan_fee Selected Chanaged
    protected void plan_fee_changed()
    {

        RegisterJSScript.AppendLine("PlanFeeNoLoad()");
    }
    protected void plan_fee_SelectedIndexChanged(object sender, EventArgs e)
    {
        plan_fee_changed();
        
    }
    #endregion

    #region Premium Selected Index Changed
    protected void premium_chanaged()
    {
        //Checked
        string _sProgram = ((program.Items.Count > 0) ? program.SelectedValue.ToString() : string.Empty);
        string _sCon_per = ((con_per.Items.Count > 0) ? con_per.SelectedValue.ToString() : string.Empty);
        string _sRate_plan = ((rate_plan.Items.Count > 0) ? rate_plan.SelectedValue.ToString() : string.Empty);
        string _sChannel = channel.Value;
        string _sPlan_fee = ((plan_fee.Items.Count > 0) ? plan_fee.SelectedValue.ToString() : string.Empty);
        string _sPlan_fee_rs = RWLFramework.Control<RebateProfileControler>().Get_PlanFee(_sRate_plan);
        string _sRebate = ((rebate.Items.Count > 0) ? rebate.SelectedValue.ToString() : string.Empty);
        string _sPremium = ((premium.Items.Count > 0) ? premium.SelectedValue.ToString() : string.Empty);
        string _sHs_model = ((hs_model.Items.Count > 0) ? hs_model.SelectedValue.ToString() : string.Empty);
        string _sFree_mon = ((free_mon.Items.Count > 0) ? free_mon.SelectedValue.ToString() : string.Empty);
        string _sNormal_rebate_type = normal_rebate_type.SelectedValue;


        if ("".Equals(_sProgram) && !(new BusinessTrade()).GetProgramTable().GetIsNullable()) return;

        bool _bDisabledHandSet = false;
        bool _bDisabledPremium = false;
        List<string> _oTradeFieldList = FromRegisterControler.Get_TradeFieldList(_sProgram, _sCon_per, _sPlan_fee_rs, _sRate_plan, _sRebate, _sNormal_rebate_type, _sChannel, _sHs_model, _sPremium, _sFree_mon,ref _bDisabledHandSet,ref _bDisabledPremium,issue_type.Value);


        if ("".Equals(hs_model.SelectedValue))
        {
            c_trade_field();
            c_bundle_name();
        }
        for (int i = 0; i < _oTradeFieldList.Count; i++)
        {
            trade_field.Items.Add(new ListItem(_oTradeFieldList[i].ToString().ToUpper(), _oTradeFieldList[i].ToString().ToUpper()));
        }



        List<string> _oBundleNameList = FromRegisterControler.Get_BundleNameList(_sProgram, _sCon_per, _sPlan_fee_rs, _sRate_plan, _sRebate, _sNormal_rebate_type, _sChannel, _sHs_model, _sPremium, _sFree_mon,ref _bDisabledHandSet,ref _bDisabledPremium,issue_type.Value);

        for (int i = 0; i < _oBundleNameList.Count; i++)
        {
            bundle_name.Items.Add(new ListItem(_oBundleNameList[i].ToString().ToUpper(), _oBundleNameList[i].ToString().ToUpper()));
        }

        if (_oTradeFieldList.Count > 0)
        {
            trade_field.SelectedValue = _oTradeFieldList[0].ToString().ToUpper();
        }
        if (_oBundleNameList.Count > 0)
        {
            bundle_name.SelectedValue = _oBundleNameList[0].ToString().ToUpper();
        }
        //hs_model.Enabled = !_bDisabledHandSet;
        //premium.Enabled = !_bDisabledPremium;
    }

    protected void premium_SelectedIndexChanged(object sender, EventArgs e)
    {
        c_tier_sel_top();
        premium_chanaged();
        RegisterJSScript.AppendLine("TradePmuListNoLoad()");
        PreLoadAutoVasSet();
    }
    #endregion

    #region Hs model Selected Index Changed
    
    protected void hs_model_changed()
    {
        //Checked
        string _sProgram = ((program.Items.Count > 0) ? program.SelectedValue.ToString() : string.Empty);
        string _sCon_per = ((con_per.Items.Count > 0) ? con_per.SelectedValue.ToString() : string.Empty);
        string _sRate_plan = ((rate_plan.Items.Count > 0) ? rate_plan.SelectedValue.ToString() : string.Empty);
        string _sChannel = channel.Value;
        string _sPlan_fee = ((plan_fee.Items.Count > 0) ? plan_fee.SelectedValue.ToString() : string.Empty);
        string _sPlan_fee_rs = RWLFramework.Control<RebateProfileControler>().Get_PlanFee(_sRate_plan);
        string _sRebate = ((rebate.Items.Count > 0) ? rebate.SelectedValue.ToString() : string.Empty);
        string _sPremium = ((premium.Items.Count > 0) ? premium.SelectedValue.ToString() : string.Empty);
        string _sHs_model = ((hs_model.Items.Count > 0) ? hs_model.SelectedValue.ToString() : string.Empty);
        string _sFree_mon = ((free_mon.Items.Count > 0) ? free_mon.SelectedValue.ToString() : string.Empty);
        string _sNormal_rebate_type = normal_rebate_type.SelectedValue;
        string _sHs_offer_type_id = ((hs_offer_type_id.Items.Count > 0) ? hs_offer_type_id.SelectedValue.ToString() : string.Empty);
        bool _bUseRebate = FromRegisterControler.UseProgramRebateMapping(program.SelectedValue, issue_type.Value);
        if ("".Equals(_sProgram) && !(new BusinessTrade()).GetProgramTable().GetIsNullable()) return;
        bool _bDisabledHandSet = false;
        bool _bDisabledPremium = false;
        List<string> _oTradeFieldList = FromRegisterControler.Get_TradeFieldList(_sProgram, _sCon_per, _sPlan_fee_rs, _sRate_plan, _sRebate, _sNormal_rebate_type, _sChannel, _sHs_model, _sPremium, _sFree_mon,ref _bDisabledHandSet,ref _bDisabledPremium,issue_type.Value);

        sku.Value = "";
        amount.Value = "0";
        c_trade_field();
        c_bundle_name();
        if (_bUseRebate)
        {
            c_rebate_amount();
            c_r_offer();
            c_extra_rebate();
            c_extra_rebate_amount();
        }
        for (int i = 0; i < _oTradeFieldList.Count; i++)
        {
            trade_field.Items.Add(new ListItem(_oTradeFieldList[i].ToString().ToUpper(), _oTradeFieldList[i].ToString().ToUpper()));
        }
        if (trade_field.Items.Count > 1) trade_field.SelectedIndex = 1;

        List<string> _oBundleNameList = FromRegisterControler.Get_BundleNameList(_sProgram, _sCon_per, _sPlan_fee_rs, _sRate_plan, _sRebate, _sNormal_rebate_type, _sChannel, _sHs_model, _sPremium, _sFree_mon,ref _bDisabledHandSet,ref _bDisabledPremium,issue_type.Value);

        for (int i = 0; i < _oBundleNameList.Count; i++)
        {
            bundle_name.Items.Add(new ListItem(_oBundleNameList[i].ToString().ToUpper(), _oBundleNameList[i].ToString().ToUpper()));
        }
        if (bundle_name.Items.Count > 1) bundle_name.SelectedIndex = 1;
        if (_bUseRebate)
        {
            Hashtable _oAllOfferList = RWLFramework.Control<TradingSystemHandSetProvider>().Get_AllOfferList(_sProgram.Trim(), _sCon_per.Trim(), _sPlan_fee_rs.Trim(), _sRate_plan.Trim(), _sNormal_rebate_type.Trim(), _sChannel.Trim(), _sHs_model.Trim(), _sHs_offer_type_id, issue_type.Value);
            if (_oAllOfferList.ContainsKey("offer_type_id"))
            {
                List<string> _oOfferTypeList = (List<string>)_oAllOfferList["offer_type_id"];
                if (_oOfferTypeList.Count > 0)
                {
                    hs_offer_type_id.SelectedValue = _oOfferTypeList[0].ToString();
                }
            }

            if (_oAllOfferList.ContainsKey("r_offer"))
            {
                List<string> _oR_offer4List = (List<string>)_oAllOfferList["r_offer"];
                for (int i = 0; i < _oR_offer4List.Count; i++)
                {
                    r_offer4.Items.Add(new ListItem(_oR_offer4List[i].ToString().ToUpper(), _oR_offer4List[i].ToString().ToUpper()));
                }

                if (_oR_offer4List.Count > 0)
                {
                    r_offer4.SelectedIndex = 1;
                    r_offer.Value = r_offer4.Items[1].Value.ToString();
                }
                else
                    r_offer.Value = string.Empty;
            }
            if (_oAllOfferList.ContainsKey("rebate_amount"))
            {
                List<string> _oRebate_amount4List = (List<string>)_oAllOfferList["rebate_amount"];
                for (int i = 0; i < _oRebate_amount4List.Count; i++)
                {
                    rebate_amount4.Items.Add(new ListItem(_oRebate_amount4List[i].ToString().ToUpper(), _oRebate_amount4List[i].ToString().ToUpper()));
                }

                if (_oRebate_amount4List.Count > 0)
                {
                    rebate_amount4.SelectedIndex = 1;
                    rebate_amount.Value = rebate_amount4.Items[1].Value.ToString().ToUpper();
                }
                else
                    rebate_amount.Value = string.Empty;
            }
            if (_oAllOfferList.ContainsKey("extra_rebate"))
            {
                List<string> _oExtra_rebateList = (List<string>)_oAllOfferList["extra_rebate"];
                for (int i = 0; i < _oExtra_rebateList.Count; i++)
                {
                    extra_rebate4.Items.Add(new ListItem(_oExtra_rebateList[i].ToString().ToUpper(), _oExtra_rebateList[i].ToString().ToUpper()));
                }

                if (_oExtra_rebateList.Count > 0)
                {
                    extra_rebate4.SelectedIndex = 1;
                    extra_rebate.Value = extra_rebate4.Items[1].Value;
                }
                else
                    extra_rebate.Value = string.Empty;
            }
            if (_oAllOfferList.ContainsKey("extra_rebate_amount"))
            {
                List<string> _oExtra_rebate_amountList = (List<string>)_oAllOfferList["extra_rebate_amount"];
                for (int i = 0; i < _oExtra_rebate_amountList.Count; i++)
                {
                    extra_rebate_amount4.Items.Add(new ListItem(_oExtra_rebate_amountList[i].ToString().ToUpper(), _oExtra_rebate_amountList[i].ToString().ToUpper()));
                }

                if (_oExtra_rebate_amountList.Count > 0)
                {
                    extra_rebate_amount4.SelectedIndex = 1;
                    extra_rebate_amount.Value = extra_rebate_amount4.Items[1].ToString().ToUpper();
                }
                else
                    extra_rebate_amount.Value = string.Empty;
            }

            if (_oAllOfferList.ContainsKey("amount"))
            {
                List<string> _oAmountList = (List<string>)_oAllOfferList["amount"];
                if (_oAmountList.Count > 0)
                {
                    amount.Value = _oAmountList[0].ToString();
                }
                else
                    amount.Value = "0";
            }
        }
        RegisterJSScript.AppendLine("add_amount()");
        sku.Value = RWLFramework.Control<TradingSystemHandSetProvider>().Get_ItemCode(_sHs_model);
        if ("2004191".Equals(gift_code.Value) || "2004191".Equals(gift_code2.Value) || "2004191".Equals(gift_code3.Value) || "2004191".Equals(gift_code4.Value) && !"2401971".Equals(sku.Value) &&
            !"2401981".Equals(sku.Value) && "2402441".Equals(sku.Value) && "2402451".Equals(sku.Value))
        {
            RegisterJSScript.AppendLine("alert('Select HS E65! or Release PQI 2GB Pen Drive Free Gift')");
        }

        if ("2420551".Equals(sku.Value))
        {
            extra_d_charge.Value = "120";
            if (rate_plan.SelectedValue == "3GRETENT0298A" && program.SelectedValue == "Mass Retention")
            {
                RegisterJSScript.AppendLine(" alert(\"Rate Plan 是 3GRETMRE0298A才可選擇SAMSUNG 32 INCH LCD TV \")");
                sku.Value = "";
                amount.Value = "0";
                hs_model.SelectedValue = "";

                c_trade_field();
                c_bundle_name();
                c_rebate_amount();
                c_r_offer();
                c_extra_rebate();
                c_extra_rebate_amount();
            }
        }
        delivery_exchange_location.Value = FromRegisterControler.GetProductionItemLocation(issue_type.Value, program.SelectedValue, sku.Value).Trim();
        SetHtmlControlValue("delivery_exchange_location", delivery_exchange_location.Value, true);
        RegisterJSScript.AppendLine("add_amount()");
        RegisterJSScript.AppendLine("ChkFreeGiftStatus()");
        ch_delivery();
        ajaxvas();
        RegisterJSScript.AppendLine("click_nextbillcutdate(document.getElementById('hs_model').value);");

    }
    protected void hs_model_selected_change()
    {
        c_tier_sel_top();
        hs_model_changed();
        update_panel_sku.Update();
        RegisterJSScript.AppendLine("TradeHsListNoLoad()");
        RegisterJSScript.AppendLine("ChkROffer();");
        PreLoadAutoVasSet();
    }
    protected void hs_model_SelectedIndexChanged(object sender, EventArgs e)
    {
        hs_model_selected_change();
        _bVasAutoDefaultSet = true;
    }
    #endregion

    #region HandSet Offer Type
    protected void hs_offer_type_id_change()
    {
        string _sProgram = ((program.Items.Count > 0) ? program.SelectedValue.ToString() : string.Empty);
        string _sCon_per = ((con_per.Items.Count > 0) ? con_per.SelectedValue.ToString() : string.Empty);
        string _sRate_plan = ((rate_plan.Items.Count > 0) ? rate_plan.SelectedValue.ToString() : string.Empty);
        string _sHs_model = ((hs_model.Items.Count > 0) ? hs_model.SelectedValue.ToString() : string.Empty);
        string _sChannel = channel.Value;
        string _sRebate = ((rebate.Items.Count > 0) ? rebate.SelectedValue.ToString() : string.Empty);

        string _sNormal_rebate_type = normal_rebate_type.SelectedValue;
        string _sPlan_fee_rs = RWLFramework.Control<TradingSystemHandSetProvider>().Get_PlanFee(_sRate_plan);
        string _sFree_mon = ((free_mon.Items.Count > 0) ? free_mon.SelectedValue.ToString() : string.Empty);
        string _sHs_offer_type_id = ((hs_offer_type_id.Items.Count > 0) ? hs_offer_type_id.SelectedValue.ToString() : string.Empty);
        bool _bUseRebate = FromRegisterControler.UseProgramRebateMapping(program.SelectedValue, issue_type.Value);
        
        amount.Value = "0";

        if (_bUseRebate)
        {
            c_rebate_amount();
            c_r_offer();
            c_extra_rebate();
            c_extra_rebate_amount();

            Hashtable _oAllOfferList = RWLFramework.Control<TradingSystemHandSetProvider>().Get_AllOfferList(_sProgram.Trim(), _sCon_per.Trim(), _sPlan_fee_rs.Trim(), _sRate_plan.Trim(), _sNormal_rebate_type.Trim(), _sChannel.Trim(), _sHs_model.Trim(), _sHs_offer_type_id, issue_type.Value);
            if (_oAllOfferList.ContainsKey("offer_type_id"))
            {
                List<string> _oOfferTypeList = (List<string>)_oAllOfferList["offer_type_id"];
                if (_oOfferTypeList.Count > 0)
                {
                    hs_offer_type_id.SelectedValue = _oOfferTypeList[0].ToString();
                }
            }

            if (_oAllOfferList.ContainsKey("r_offer"))
            {
                List<string> _oR_offer4List = (List<string>)_oAllOfferList["r_offer"];
                for (int i = 0; i < _oR_offer4List.Count; i++)
                {
                    r_offer4.Items.Add(new ListItem(_oR_offer4List[i].ToString().ToUpper(), _oR_offer4List[i].ToString().ToUpper()));
                }

                if (_oR_offer4List.Count > 0)
                {
                    r_offer4.SelectedIndex = 1;
                    r_offer.Value = r_offer4.Items[1].Value.ToString();
                }
                else
                    r_offer.Value = string.Empty;
            }
            if (_oAllOfferList.ContainsKey("rebate_amount"))
            {
                List<string> _oRebate_amount4List = (List<string>)_oAllOfferList["rebate_amount"];
                for (int i = 0; i < _oRebate_amount4List.Count; i++)
                {
                    rebate_amount4.Items.Add(new ListItem(_oRebate_amount4List[i].ToString().ToUpper(), _oRebate_amount4List[i].ToString().ToUpper()));
                }

                if (_oRebate_amount4List.Count > 0)
                {
                    rebate_amount4.SelectedIndex = 1;
                    rebate_amount.Value = rebate_amount4.Items[1].Value.ToString().ToUpper();
                }
                else
                    rebate_amount.Value = string.Empty;
            }
            if (_oAllOfferList.ContainsKey("extra_rebate"))
            {
                List<string> _oExtra_rebateList = (List<string>)_oAllOfferList["extra_rebate"];
                for (int i = 0; i < _oExtra_rebateList.Count; i++)
                {
                    extra_rebate4.Items.Add(new ListItem(_oExtra_rebateList[i].ToString().ToUpper(), _oExtra_rebateList[i].ToString().ToUpper()));
                }

                if (_oExtra_rebateList.Count > 0)
                {
                    extra_rebate4.SelectedIndex = 1;
                    extra_rebate.Value = extra_rebate4.Items[1].Value;
                }
                else
                    extra_rebate.Value = string.Empty;
            }
            if (_oAllOfferList.ContainsKey("extra_rebate_amount"))
            {
                List<string> _oExtra_rebate_amountList = (List<string>)_oAllOfferList["extra_rebate_amount"];
                for (int i = 0; i < _oExtra_rebate_amountList.Count; i++)
                {
                    extra_rebate_amount4.Items.Add(new ListItem(_oExtra_rebate_amountList[i].ToString().ToUpper(), _oExtra_rebate_amountList[i].ToString().ToUpper()));
                }

                if (_oExtra_rebate_amountList.Count > 0)
                {
                    extra_rebate_amount4.SelectedIndex = 1;
                    extra_rebate_amount.Value = extra_rebate_amount4.Items[1].ToString().ToUpper();
                }
                else
                    extra_rebate_amount.Value = string.Empty;
            }

            if (_oAllOfferList.ContainsKey("amount"))
            {
                List<string> _oAmountList = (List<string>)_oAllOfferList["amount"];
                if (_oAmountList.Count > 0)
                {
                    amount.Value = _oAmountList[0].ToString();
                }
                else
                    amount.Value = "0";
            }
        }
        SetHtmlControlValue("amount", amount.Value, true);
        RegisterJSScript.AppendLine("add_amount()");
    }
    #endregion
    protected void hs_offer_type_id_SelectedIndexChanged(object sender, EventArgs e)
    {
        hs_offer_type_id_change();
    }

    #region Pay Method Selected Index Changed
    protected void PayMethodDataBind()
    {
        string _sProgram = ((program.Items.Count > 0) ? program.SelectedValue.ToString() : string.Empty);
        string _sIssue_type = issue_type.Value;
        pay_method.Items.Clear();
        pay_method.Items.Add(new ListItem(string.Empty, string.Empty));
        List<string> _oList = FromRegisterControler.GetPaymentMethodList(_sProgram, "PREPAYMENT", _sIssue_type);
        for (int i = 0; i < _oList.Count; i++)
        {
            pay_method.Items.Add(new ListItem(_oList[i], _oList[i]));
        }
        update_panel_delivery.Update();
    }

    protected void pay_method_changed()
    {
        //Checked
        dis_card();
        string _sProgram = ((program.Items.Count > 0) ? program.SelectedValue.ToString() : string.Empty);
        string _sCon_per = ((con_per.Items.Count > 0) ? con_per.SelectedValue.ToString() : string.Empty);
        string _sRate_plan = ((rate_plan.Items.Count > 0) ? rate_plan.SelectedValue.ToString() : string.Empty);
        string _sHs_model = ((hs_model.Items.Count > 0) ? hs_model.SelectedValue.ToString() : string.Empty);
        string _sPay_method = pay_method.SelectedValue;
        string _sChannel = channel.Value;
        
        string _sNormal_rebate_type = normal_rebate_type.SelectedValue;
        string _sPlan_fee_rs = RWLFramework.Control<PaymentOfferProfile>().Get_PlanFee(_sRate_plan);
        string _sHs_offer_type_id = ((hs_offer_type_id.Items.Count > 0) ? hs_offer_type_id.SelectedValue.ToString() : string.Empty);
        bool _bUseRebate = FromRegisterControler.UseProgramRebateMapping(program.SelectedValue, issue_type.Value);

        if ("".Equals(_sProgram) && !(new RebateGroup()).GetProgramTable().GetIsNullable()) return;
        if (_bUseRebate)
        {
            c_rebate_amount();
            c_r_offer();
            c_extra_rebate();
            c_extra_rebate_amount();
            amount.Value = "0";

            if (_sPay_method == "CREDIT CARD INSTALLMENT" || _sPay_method == "CREDIT CARD")
                _sPay_method = "CREDIT CARD";
            else
                _sPay_method = "CASH";

            Hashtable _oAllOfferList = RWLFramework.Control<PaymentOfferProfile>().Get_AllOfferList(_sProgram, _sCon_per, _sPlan_fee_rs, _sNormal_rebate_type, _sHs_model, _sPay_method, _sHs_offer_type_id);
            if (_oAllOfferList.ContainsKey("offer_type_id"))
            {
                List<string> _oOfferTypeList = (List<string>)_oAllOfferList["offer_type_id"];
                if (_oOfferTypeList.Count > 0)
                {
                    hs_offer_type_id.SelectedValue = _oOfferTypeList[0].ToString();
                }
            }

            if (_oAllOfferList.ContainsKey("r_offer"))
            {
                List<string> _oR_offerList = (List<string>)_oAllOfferList["r_offer"];
                for (int i = 0; i < _oR_offerList.Count; i++)
                {
                    r_offer4.Items.Add(new ListItem(_oR_offerList[i].ToString().ToUpper(), _oR_offerList[i].ToString().ToUpper()));
                }
                if (_oR_offerList.Count > 0)
                {
                    r_offer4.SelectedIndex = 1;
                    r_offer.Value = r_offer4.Items[1].Value.ToString();
                }
            }

            if (_oAllOfferList.ContainsKey("rebate_amount"))
            {
                List<string> _oRebate_amountList = (List<string>)_oAllOfferList["rebate_amount"];
                for (int i = 0; i < _oRebate_amountList.Count; i++)
                {
                    rebate_amount4.Items.Add(new ListItem(_oRebate_amountList[i].ToString().ToUpper(), _oRebate_amountList[i].ToString().ToUpper()));
                }
                if (_oRebate_amountList.Count > 0)
                {
                    rebate_amount4.SelectedIndex = 1;
                    rebate_amount.Value = rebate_amount4.Items[1].Value.ToString();
                }
            }

            if (_oAllOfferList.ContainsKey("extra_rebate"))
            {
                List<string> _oExtra_rebateList = (List<string>)_oAllOfferList["extra_rebate"];
                for (int i = 0; i < _oExtra_rebateList.Count; i++)
                {
                    extra_rebate4.Items.Add(new ListItem(_oExtra_rebateList[i].ToString().ToUpper(), _oExtra_rebateList[i].ToString().ToUpper()));
                }
                if (_oExtra_rebateList.Count > 0)
                {
                    extra_rebate4.SelectedIndex = 1;
                    extra_rebate.Value = extra_rebate4.Items[1].Value.ToString();
                }
            }

            if (_oAllOfferList.ContainsKey("extra_rebate_amount"))
            {
                List<string> _oExtra_rebate_amountList = (List<string>)_oAllOfferList["extra_rebate_amount"];
                for (int i = 0; i < _oExtra_rebate_amountList.Count; i++)
                {
                    extra_rebate_amount4.Items.Add(new ListItem(_oExtra_rebate_amountList[i].ToString().ToUpper(), _oExtra_rebate_amountList[i].ToString().ToUpper()));
                }
                if (_oExtra_rebate_amountList.Count > 0)
                {
                    extra_rebate_amount4.SelectedIndex = 1;
                    extra_rebate_amount.Value = extra_rebate_amount4.Items[1].ToString();
                }
            }
            if (_oAllOfferList.ContainsKey("amount"))
            {
                List<string> _oAmountList = (List<string>)_oAllOfferList["amount"];
                if (_oAmountList.Count > 0)
                {
                    amount.Value = _oAmountList[0].ToString();
                }
            }
            RegisterJSScript.AppendLine("add_amount()");
        }

        rebate_amount_update_panel.Update();
        r_offer4_update_panel.Update();
        extra_rebate_amount4_update_panel.Update();

        if (MobileOrderThreePartyControl.Three_party.Checked)
        {
            RegisterJSScript.AppendLine("UserControlVisible('contact_person_show',false)");
            RegisterJSScript.AppendLine("UserControlVisible('contact_no_show',false)");
            RegisterJSScript.AppendLine("ReceiveSIMBy3rdPartyDetailShowChk(true)");
        }
        else
        {
            RegisterJSScript.AppendLine("UserControlVisible('contact_person_show',true)");
            RegisterJSScript.AppendLine("UserControlVisible('contact_no_show',true)");
        }
    }
    protected void pay_method_SelectedIndexChanged(object sender, EventArgs e)
    {
        c_tier_sel_top();
        pay_method_changed();
    }
    #endregion

    #region Rebate Selected Changed
    protected void rebate_changed()
    {
        string _sProgram = ((program.Items.Count > 0) ? program.SelectedValue.ToString() : string.Empty);
        string _sCon_per = ((con_per.Items.Count > 0) ? con_per.SelectedValue.ToString() : string.Empty);
        string _sRate_plan = ((rate_plan.Items.Count > 0) ? rate_plan.SelectedValue.ToString() : string.Empty);
        string _sChannel = channel.Value;
        string _sPlan_fee = ((plan_fee.Items.Count > 0) ? plan_fee.SelectedValue.ToString() : string.Empty);
        string _sPlan_fee_rs = RWLFramework.Control<RebateProfileControler>().Get_PlanFee(_sRate_plan);
        string _sRebate = ((rebate.Items.Count > 0) ? rebate.SelectedValue.ToString() : string.Empty);
        string _sPremium = ((premium.Items.Count > 0) ? premium.SelectedValue.ToString() : string.Empty);
        string _sHs_model = ((hs_model.Items.Count > 0) ? hs_model.SelectedValue.ToString() : string.Empty);
        string _sFree_mon = ((free_mon.Items.Count > 0) ? free_mon.SelectedValue.ToString() : string.Empty);
        string _sNormal_rebate_type = normal_rebate_type.SelectedValue;



        if ("".Equals(_sProgram) && !(new BusinessTrade()).GetProgramTable().GetIsNullable()) return;
        if (!"".Equals(rebate.SelectedValue))
        {
            free_mon.Enabled = false;
            free_mon.SelectedValue = string.Empty;
        }
        else
        {
            free_mon.Enabled = true;
            free_mon.Attributes.Remove(HtmlTextWriterAttribute.Disabled.ToString().ToLower());
            free_mon.SelectedValue = string.Empty;
        }

        c_trade_field();
        c_bundle_name();
        c_premium();

        if ("".Equals(_sProgram) && !(new RebateGroup()).GetProgramTable().GetIsNullable()) return;
        List<string> _oHandSetList = RWLFramework.Control<HandSetEnvironment>().Get_DrpHandSetList(_sProgram, _sCon_per, _sRate_plan, _sPlan_fee, _sNormal_rebate_type, _sChannel,issue_type.Value);


        for (int i = 0; i < _oHandSetList.Count; i++)
        {
            hs_model.Items.Add(new ListItem(_oHandSetList[i].ToString().ToUpper(), _oHandSetList[i].ToString().ToUpper()));
        }
        bool _bDisabledHandSet = false;
        bool _bDisabledPremium = false;
        List<string> _oTradeFieldList = FromRegisterControler.Get_TradeFieldList(_sProgram, _sCon_per, _sPlan_fee_rs, _sRate_plan, _sRebate, _sNormal_rebate_type, _sChannel, _sHs_model, _sPremium, _sFree_mon,ref _bDisabledHandSet,ref _bDisabledPremium,issue_type.Value);

        for (int i = 0; i < _oTradeFieldList.Count; i++){
            trade_field.Items.Add(new ListItem(_oTradeFieldList[i].ToString().ToUpper(), _oTradeFieldList[i].ToString().ToUpper()));
        }

        if (trade_field.Items.Count > 1) trade_field.SelectedIndex = 1;


        List<string> _oBundleNameList = FromRegisterControler.Get_BundleNameList(_sProgram, _sCon_per, _sPlan_fee_rs, _sRate_plan, _sRebate, _sNormal_rebate_type, _sChannel, _sHs_model, _sPremium, _sFree_mon,ref _bDisabledHandSet,ref _bDisabledPremium,issue_type.Value);


        for (int i = 0; i < _oBundleNameList.Count; i++){
            bundle_name.Items.Add(new ListItem(_oBundleNameList[i].ToString().ToUpper(), _oBundleNameList[i].ToString().ToUpper()));
        }
        if (bundle_name.Items.Count > 1) bundle_name.SelectedIndex = 1;
        List<string> _oPremiumList = RWLFramework.Control<RebateProfileControler>().Get_DrpPremiumList(_sProgram, _sCon_per, _sPlan_fee_rs, _sRebate, _sNormal_rebate_type, _sChannel,issue_type.Value);

        for (int i = 0; i < _oPremiumList.Count; i++){
            premium.Items.Add(new ListItem(_oPremiumList[i].ToString().ToUpper(), _oPremiumList[i].ToString().ToUpper()));
        }
        ajaxvas();
        //hs_model.Enabled = !_bDisabledHandSet;
        //premium.Enabled = !_bDisabledPremium;
    }
    protected void rebate_SelectedIndexChanged(object sender, EventArgs e)
    {
        c_tier_sel_top();
        rebate_changed();
        RegisterJSScript.AppendLine("TradeRListNoLoad()");
    }
    #endregion

    #region Free Month Selected Changed
    protected void free_mon_changed()
    {

        string _sProgram = ((program.Items.Count > 0) ? program.SelectedValue.ToString() : string.Empty);
        string _sCon_per = ((con_per.Items.Count > 0) ? con_per.SelectedValue.ToString() : string.Empty);
        string _sRate_plan = ((rate_plan.Items.Count > 0) ? rate_plan.SelectedValue.ToString() : string.Empty);
        string _sChannel = channel.Value;
        string _sPlan_fee = ((plan_fee.Items.Count > 0) ? plan_fee.SelectedValue.ToString() : string.Empty);
        string _sPlan_fee_rs = RWLFramework.Control<RebateProfileControler>().Get_PlanFee(_sRate_plan);
        string _sRebate = ((rebate.Items.Count > 0) ? rebate.SelectedValue.ToString() : string.Empty);
        string _sPremium = ((premium.Items.Count > 0) ? premium.SelectedValue.ToString() : string.Empty);
        string _sHs_model = ((hs_model.Items.Count > 0) ? hs_model.SelectedValue.ToString() : string.Empty);
        string _sFree_mon = ((free_mon.Items.Count > 0) ? free_mon.SelectedValue.ToString() : string.Empty);
        string _sNormal_rebate_type = normal_rebate_type.SelectedValue;



    
        if ("".Equals(_sProgram) && !(new BusinessTrade()).GetProgramTable().GetIsNullable()) return;

        if (!"".Equals(free_mon.SelectedValue))
        {
            rebate.Enabled = false;
            rebate.SelectedValue = string.Empty;
        }
        else
        {
            rebate.Enabled = true;
            rebate.Attributes.Remove(HtmlTextWriterAttribute.Disabled.ToString().ToLower());
            rebate.SelectedValue = string.Empty;
        }
        if ("".Equals(hs_model.SelectedValue))
        {
            c_trade_field();
            c_bundle_name();
            c_premium();
        }

        if ("".Equals(_sProgram) && !(new RebateGroup()).GetProgramTable().GetIsNullable()) return;
        List<string> _oHandSetList = RWLFramework.Control<HandSetEnvironment>().Get_DrpHandSetList(_sProgram, _sCon_per, _sRate_plan, _sPlan_fee, _sNormal_rebate_type, _sChannel,issue_type.Value);


        for (int i = 0; i < _oHandSetList.Count; i++)
        {
            hs_model.Items.Add(new ListItem(_oHandSetList[i].ToString().ToUpper(), _oHandSetList[i].ToString().ToUpper()));
        }

        bool _bDisabledHandSet = false;
        bool _bDisabledPremium = false;
        List<string> _oTradeFieldList = FromRegisterControler.Get_TradeFieldList(_sProgram, _sCon_per, _sPlan_fee_rs, _sRate_plan, _sRebate, _sNormal_rebate_type, _sChannel, _sHs_model, _sPremium, _sFree_mon, ref _bDisabledHandSet, ref _bDisabledPremium);

        if (_oTradeFieldList.Count > 0) { c_trade_field(); }
        for (int i = 0; i < _oTradeFieldList.Count; i++)
        {
            trade_field.Items.Add(new ListItem(_oTradeFieldList[i].ToString().ToUpper(), _oTradeFieldList[i].ToString().ToUpper()));

        }
        if (trade_field.Items.Count > 1) trade_field.SelectedIndex = 1;
        if (_oTradeFieldList.Count == 0) { trade_field.Items.Clear(); }

        List<string> _oBundleNameList = FromRegisterControler.Get_BundleNameList(_sProgram, _sCon_per, _sPlan_fee_rs, _sRate_plan, _sRebate, _sNormal_rebate_type, _sChannel, _sHs_model, _sPremium, _sFree_mon,ref _bDisabledHandSet,ref _bDisabledPremium,issue_type.Value);
        if (_oBundleNameList.Count > 0) { c_bundle_name(); }
        for (int i = 0; i < _oBundleNameList.Count; i++)
        {
            bundle_name.Items.Add(new ListItem(_oBundleNameList[i].ToString().ToUpper(), _oBundleNameList[i].ToString().ToUpper()));
        }
        if (bundle_name.Items.Count > 1) bundle_name.SelectedIndex = 1;
        if (_oBundleNameList.Count == 0) { bundle_name.Items.Clear(); }
        List<string> _oPremiumList = RWLFramework.Control<FreeBusinessRelationControler>().Get_DrpPremiumList(_sProgram, _sCon_per, _sPlan_fee_rs, _sRate_plan, _sNormal_rebate_type, _sFree_mon, _sChannel,issue_type.Value);
        if (_oPremiumList.Count > 0) { c_premium(); }
        for (int i = 0; i < _oPremiumList.Count; i++)
        {
            premium.Items.Add(new ListItem(_oPremiumList[i].ToString().ToUpper(), _oPremiumList[i].ToString().ToUpper()));
        }
        if (_oPremiumList.Count == 0) { premium.Items.Clear(); }
        ajaxvas();
        //hs_model.Enabled = !_bDisabledHandSet;
        //premium.Enabled = !_bDisabledPremium;
    }

    protected void free_mon_SelectedIndexChanged(object sender, EventArgs e)
    {
        c_tier_sel_top();
        free_mon_changed();
        RegisterJSScript.AppendLine("TradeFListNoLoad()");
        PreLoadAutoVasSet();
    }
    #endregion

    #region SIM Item Name Selected Changd
    protected void sim_item_name1_changed()
    {
        string _sSim_item_name = ((sim_item_name1.Items.Count > 0) ? sim_item_name1.SelectedValue.ToString() : string.Empty);
        string _sSim_no = get_first_avaliable_sim_item_number(_sSim_item_name);
        //sim_item_number.Text = (_sSim_no == "" ? "AO" : _sSim_no);
        sim_item_number.Text = _sSim_no;
        ch_delivery();
        /*
        if (hs_model.SelectedValue != string.Empty || sim_item_name1.SelectedValue != string.Empty)
            RegisterJSScript.AppendLine("delivery_style(\"yes\");");
        else
            RegisterJSScript.AppendLine("delivery_style(\"no\");");
        */
        if (sim_item_name1.SelectedValue == string.Empty)
            sim_item_number.Text = string.Empty;
    }
    protected static string get_first_avaliable_sim_item_number(string x_sSim_item_code)
    {
        string _sSim_no = string.Empty;
        if (x_sSim_item_code != string.Empty)
        {
            SIMControl _oSIMControl = new SIMControl();
            _oSIMControl.SetDummy1("SIM CARD CC RET");
            _oSIMControl.SetReserve(x_sSim_item_code);

            _sSim_no = _oSIMControl.getAnotherAvaliableSIM();
        }
        return _sSim_no;
    }

    protected void sim_item_name1_selectedIndexChanged(object sender, EventArgs e)
    {
        sim_item_name1_changed();
        ajaxvas();
        //update_panel_sim_item.Update();
        update_panel_sim_item.Update();

        //update_panel_rebate_amount.Update();
    }

    protected static string[,] check_sim_number_avaliable(string[,] x_sArrSim_item_name, string x_sSim_no)
    {
        StringBuilder _oSearch = new StringBuilder();
        _oSearch.AppendLine("select reserve, count(sim_no) numberOfSim from sunday_sim_no where ");
        _oSearch.AppendLine("reserve in (");
        for (int i = 0; i < x_sArrSim_item_name.Length; i = i + 2)
        {
            if (i != 0) _oSearch.AppendLine(",");
            _oSearch.AppendLine("'" + x_sArrSim_item_name[i / 2, 0] + "'");
        }
        _oSearch.AppendLine(") and ");
        if (x_sSim_no != string.Empty)
        {
            _oSearch.AppendLine("sim_no='" + x_sSim_no + "' and ");
        }
        _oSearch.AppendLine("dummy1='SIM CARD CC RET' and ");
        _oSearch.AppendLine("(referenceno='' or referenceno is null) and  ");
        _oSearch.AppendLine("(assign_date='' or assign_date is null) ");
        _oSearch.AppendLine("group by reserve");

        ODBCConnect _oDB = new ODBCConnect();
        //_oDB.SetConnStr(Configurator.DBName.ORADNS);
        _oDB.SetConnStr(Configurator.DBName.ORADNS + ((Configurator.IsUat()) ? "2" : string.Empty));
        //OdbcDataReader _oDr = GetSimORDB().GetSearch(_oSearch.ToString());
        OdbcDataReader _oDr = _oDB.GetSearch(_oSearch.ToString());

        if (_oDr != null)
        {
            if (_oDr.Read())
            {
                for (int j = 0; j < x_sArrSim_item_name.Length; j = j + 2)
                {
                    if (x_sArrSim_item_name[j / 2, 0] == Func.FR(_oDr["reserve"]).Trim())
                    {
                        x_sArrSim_item_name[j / 2, 1] = Func.FR(_oDr["numberOfSim"]).Trim();
                    }
                }
            }
        }
        _oDr.Close();
        _oDr.Dispose();
        return x_sArrSim_item_name;
    }

    [Ajax.AjaxMethod(Ajax.HttpSessionStateRequirement.Read)]
    public static string check_sim_number_for_js(string x_sSim_item_name, string x_sSim_item_code, string x_sSim_item_number, string x_sRecord_id)
    {
        string _sResult = "0";

        string[,] _sArrSim_item_code;
        _sArrSim_item_code = new string[1, 2];
        _sArrSim_item_code[0, 0] = x_sSim_item_code;
        _sArrSim_item_code[0, 1] = "0";

        _sArrSim_item_code = check_sim_number_avaliable(_sArrSim_item_code, x_sSim_item_number);

        if (_sArrSim_item_code[0, 1] == "1")
        {
            _sResult = "1";
        }
        else
        {
            string _sNew_imei = get_first_avaliable_sim_item_number(x_sSim_item_code);
            _sResult = (_sNew_imei == string.Empty ? "0" : _sNew_imei);
        }
        return _sResult;
    }

    protected void check_sim_number_clicked()
    {
        string _sSim_item_name = ((sim_item_name1.Items.Count > 0) ? sim_item_name1.SelectedValue.ToString() : string.Empty);
        int i = 0;
        if (sim_item_name1.Items.Count > 0)
        {
            string[,] _sArrSim_item_name;
            if (_sSim_item_name != string.Empty)
            {
                _sArrSim_item_name = new string[1, 2];
                _sArrSim_item_name[0, 0] = _sSim_item_name;
                _sArrSim_item_name[0, 1] = "0";
                i = 1;
            }
            else
            {
                _sArrSim_item_name = new string[sim_item_name1.Items.Count, 2];
                for (i = 0; i < sim_item_name1.Items.Count; i++)
                {
                    _sArrSim_item_name[i, 0] = sim_item_name1.Items[i].Value.ToString();
                    _sArrSim_item_name[i, 1] = "0";
                }
            }

            _sArrSim_item_name = check_sim_number_avaliable(_sArrSim_item_name, "");
            StringBuilder _oAlertMsg = new StringBuilder();
            _oAlertMsg.Append("alert('");
            for (int j = (i == 1 ? 0 : 1); j < i; j++)
            {
                _oAlertMsg.Append("Number of item " + _sArrSim_item_name[j, 0] + " avaliable is " + _sArrSim_item_name[j, 1] + ". \\n");
            }
            _oAlertMsg.Append("');");
            RegisterJSScript.AppendLine(_oAlertMsg.ToString());
            ajaxvas();
        }
    }


    protected void check_sim_number_click(object sender, EventArgs e)
    {
        check_sim_number_clicked();
        //update_panel_sim_item.Update();
        update_panel_sim_item.Update();
    }
    #endregion

    #region Month Payment Method Change
    protected void MonthPaymentMethodChange(string x_sProgram, string x_sIssue_type)
    {
        MonthPaymentMethodChange(x_sProgram, x_sIssue_type, true);
    }
    protected void MonthPaymentMethodChange(string x_sProgram, string x_sIssue_type, bool x_bRemove)
    {
        if (x_sProgram == null)
            throw new BusinessObjectNotFoundException("Error : MonthPaymentMethodChange : x_sProgram cannot set null");
        if (x_sIssue_type == null)
            throw new BusinessObjectNotFoundException("Error : MonthPaymentMethodChange : x_sIssue_type cannot set null");

        MonthlyPaymentTypeDataBind();
        if (!IsPostBack)
        {
            if ("MOBILE LITE (SIM ONLY)".Equals(x_sProgram) || "MOBILE LITE (HS OFFER)".Equals(x_sProgram))
            {
                RegisterJSScript.AppendLine("MonthlyPaymentTypeChangeSetValueRemove('CHANGE TO CREDIT CARD'," + ((x_bRemove) ? "true" : "false") + ");");
            }
            else
            {
                SetHtmlControlAtt("monthly_payment_method_0", HtmlTextWriterAttribute.Disabled, "false", false);
                monthly_payment_method_0.Disabled = false;
            }
            if ("MOBILE_LITE".CompareTo(x_sIssue_type.Trim().ToUpper()) == 0)
            {
                //RegisterJSScript.AppendLine("UserControlVisible('change_payment_type_show',true);");
                RegisterJSScript.AppendLine("UserControlVisible('monthly_bank_account_show',true);");
                RegisterJSScript.AppendLine("UserControlVisible('monthly_bank_account_holder_show',true);");
            }
            if (x_sIssue_type == "UPGRADE" || x_sIssue_type == "WIN")
            {
                RegisterJSScript.AppendLine("UserControlVisible('monthly_3rd_party_credit_card_info_show',true);");
            }
            else
            {
                RegisterJSScript.AppendLine("UserControlVisible('monthly_3rd_party_credit_card_info_show',false);");
            }
        }
        RegisterJSScript.AppendLine("MonthlyPaymentTypeChangeRemove(" + ((x_bRemove) ? "true" : "false") + ");");
    }
    #endregion

    public void SimShow()
    {
        if (issue_type.Value == "MOBILE_LITE" || issue_type.Value == "3G_RETENTION" || issue_type.Value == "2G_RETENTION")
        {
            SetHtmlControlStyle("sim_show", HtmlTextWriterStyle.Display, "inline", true);
        }
        else if (issue_type.Value == "WIN")
        {
            SetHtmlControlStyle("sim_show", HtmlTextWriterStyle.Display, "inline", true);
        }
        else if (issue_type.Value == "UPGRADE")
        {

            if (!"IPHONE REBATE PLAN".Equals(program.SelectedValue) &&
            !"STAFF (IPHONE REBATE)".Equals(program.SelectedValue) &&
            !"IPAD SIM ONLY OFFER".Equals(program.SelectedValue) &&
            !"MOBILE LITE (SIM ONLY)".Equals(program.SelectedValue) &&
            !"MOBILE LITE (HS OFFER)".Equals(program.SelectedValue) &&
            !"STAFF (IPHONE CON SER)".Equals(program.SelectedValue) &&
            !"IPHONE CONCIERGE SERVICE".Equals(program.SelectedValue) &&
            !"MOBILEONE T3 RETENTION".Equals(program.SelectedValue) &&
            !"MOBILEONE T2 RETENTION".Equals(program.SelectedValue) &&
            issue_type.Value != "UPGRADE")
            {
                SetHtmlControlStyle("sim_show", HtmlTextWriterStyle.Display, "none", true);
                SetSelectHtmlControlSelectedIndex("sim_item_name1", 0);
                sim_item_name.Value = "";
                SetHtmlControlValue("sim_item_number", "", true);
                SetHtmlControlValue("sim_item_code", "", true);
            }
            else
            {
                SetHtmlControlStyle("sim_show", HtmlTextWriterStyle.Display, "inline", true);
            }
        }
    }


    #region Program Selected Changed
    public void ProgramRelChanged()
    {
        
        string _sNormal_rebate_type = normal_rebate_type.SelectedValue;
        List<string> _oRate_Plan_List = RWLFramework.Control<BusinessRatePlanManagement>().Get_RatePlanList(program.SelectedValue.ToString().ToUpper(), _sNormal_rebate_type.ToString().ToUpper(), channel.Value.ToString().ToUpper(),issue_type.Value);
        if (!"STAFF OFFER".Equals(program.SelectedValue) &&
                  !"STAFF REFERRAL".Equals(program.SelectedValue) &&
                  !"STAFF OFFER (CONCIERGE SERVICE) ".Equals(program.SelectedValue) &&
                  !"STAFF (IPAD CON SER)".Equals(program.SelectedValue) &&
                  !"STAFF (IPHONE CON SER)".Equals(program.SelectedValue) &&
                  !"STAFF (IPHONE REBATE)".Equals(program.SelectedValue) &&
                  !"STAFF (QUALITY LOB)".Equals(program.SelectedValue) &&
                  !"STAFF (SMARTPHONE HS)".Equals(program.SelectedValue) &&
                  !"STAFF (SMARTPHONE REBATE)".Equals(program.SelectedValue) &&
                  !"STAFF (WEB & TALK +)".Equals(program.SelectedValue) &&
                  !"STAFF (CONCIERGE SERVICE)".Equals(program.SelectedValue) &&
                  !"STAFF (IPHONE REBATE)".Equals(program.SelectedValue) &&
                  !"STAFF (MASS)".Equals(program.SelectedValue) &&
                  !"STAFF (SMARTPHONE HS)".Equals(program.SelectedValue) &&
                  !"STAFF (SMARTPHONE REBATE)".Equals(program.SelectedValue) &&
                  !"STAFF (SPEC PROMOTION)".Equals(program.SelectedValue) &&
                  !"STAFF (SPEC PROMOTION)".Equals(program.SelectedValue) &&
                  !"STAFF (SPECIAL 2ND HS)".Equals(program.SelectedValue) &&
                  !"STAFF (SPECIAL 2ND IPHONE)".Equals(program.SelectedValue) &&
                  !"STAFF (WEB & TALK)".Equals(program.SelectedValue) &&
                  !"QUALITY LOB OFFER (IPAD)".Equals(program.SelectedValue))
        {
            SetHtmlControlStyle("cust_staff_no_show", HtmlTextWriterStyle.Display, "none", true);
            cust_staff_no.Disabled = true;
            cust_staff_no.Value = string.Empty;
        }
        else
        {
            SetHtmlControlStyle("cust_staff_no_show", HtmlTextWriterStyle.Display, "inline", true);
            cust_staff_no.Disabled = false;
            cust_staff_no.Value = string.Empty;
        }
        /*
        if (issue_type.Value == "3G_RETENTION" || issue_type.Value == "2G_RETENTION")
        {
            if ("STAFF (IPAD CON SER)".Equals(program.SelectedValue) ||
                "STAFF (IPHONE CON SER)".Equals(program.SelectedValue) ||
                "STAFF (IPHONE REBATE)".Equals(program.SelectedValue) ||
                "QUALITY LOB OFFER (IPAD)".Equals(program.SelectedValue) ||
                "IPHONE CONCIERGE SERVICE".Equals(program.SelectedValue) || 
                "MOBILEONE T2 RETENTION".Equals(program.SelectedValue) || 
                "MOBILEONE T3 RETENTION".Equals(program.SelectedValue) || 
                "MOBILE LITE (HS OFFER)".Equals(program.SelectedValue) || 
                "MOBILE LITE (SIM ONLY)".Equals(program.SelectedValue) || 
                "GO TAB PLAN".Equals(program.SelectedValue) || 
                "SIM ONLY DATA PLAN".Equals(program.SelectedValue)
                )
            {
                SetHtmlControlStyle("sim_show", HtmlTextWriterStyle.Display, "inline", true);
            }
            else
            {
                SetHtmlControlStyle("sim_show", HtmlTextWriterStyle.Display, "none", true);
                SetSelectHtmlControlSelectedIndex("sim_item_name1", 0);
                sim_item_name.Value = "";
                SetHtmlControlValue("sim_item_number", "", true);
                SetHtmlControlValue("sim_item_code", "", true);
            }
        }
        */

        SimShow();

        if (!"EASYWATCH BUNDLE".Equals(program.SelectedValue))
        {
            SetHtmlControlStyle("easywatch_type_show", HtmlTextWriterStyle.Display, "none", true);
            easywatch_ord_id.Disabled = true;
            easywatch_ord_id.Value = string.Empty;
            easywatch_type.Enabled = true;
            easywatch_type.SelectedIndex = -1;
            easywatch_type.Enabled = false;
        }
        else
        {
            SetHtmlControlStyle("easywatch_type_show", HtmlTextWriterStyle.Display, "inline", true);
            easywatch_ord_id.Disabled = false;
            easywatch_ord_id.Value = string.Empty;
            easywatch_type.Enabled = true;
            easywatch_type.SelectedIndex = -1;
        }

        MonthPaymentMethodChange(program.SelectedValue, issue_type.Value,true);
        sku.Value = string.Empty;
        ch_easy_id();
        c_rebate_amount();
        c_r_offer();
        c_trade_field();
        c_bundle_name();
        c_hs_model();
        c_premium();
        c_con_per();
        c_rebate();
        c_free_mon();
        c_s_premium();
        c_rate_plan();
        //c_plan_fee();
        //c_plan_fee_sel_top();
        for (int i = 0; i < _oRate_Plan_List.Count; i++)
        {
            rate_plan.Items.Add(new ListItem(_oRate_Plan_List[i].ToString().ToUpper().ToUpper(), _oRate_Plan_List[i].ToString().ToUpper()));
        }
        if (rate_plan.Items.Count > 0) { rate_plan.SelectedIndex = 0; }
        ch_delivery();

        delivery_exchange_location.Value = FromRegisterControler.GetProductionItemLocation(issue_type.Value, program.SelectedValue, sku.Value).Trim();
        SetHtmlControlValue("delivery_exchange_location", delivery_exchange_location.Value, true);
    }



    protected void program_SelectedIndexChanged(object sender, EventArgs e)
    {
        plan_fee.SelectedIndex = -1;
        c_tier_sel_top();
        ProgramRelChanged();
        update_panel_sku.Update();

        
        ajaxvas();
        RegisterJSScript.AppendLine("PlanListNoLoad()");
        RegisterJSScript.AppendLine("ShowPCDGoWirelessTooChk()");


        //for add modify and  modify with no check and modify page
        if (program.SelectedValue == "GO WIRELESS")
            SetHtmlControlStyle("go_wireless_show", HtmlTextWriterStyle.Display, "inline", true);
        else
            SetHtmlControlStyle("go_wireless_show", HtmlTextWriterStyle.Display, "none", true);

        PreLoadAutoVasSet();
        MonthlyPaymentTypeDataBind();
        PayMethodDataBind();
        _bVasAutoDefaultSet = true;
    }
    #endregion

    protected void normal_rebate_type_SelectedIndexChanged(object sender, EventArgs e)
    {
        normal_rebate_type_selected_change();
    }

    protected void normal_rebate_type_selected_change()
    {
        plan_fee.SelectedIndex = -1;
        c_tier_sel_top();
        ProgramRelChanged();
        en_lob();
        ajaxvas();
        RegisterJSScript.AppendLine("PlanListNoLoad()");
    }

    #region Easywatch Selected index changed
    protected void easywatch_type_SelectedIndexChanged(object sender, EventArgs e)
    {
        ch_easy_id();
    }
    #endregion

    #region BaseInit
    protected void BaseInit()
    {
        x_oMobileRetentionOrder = (MobileRetentionOrder)MobileRetentionOrderRepository.CreateEntityInstanceObject();
        x_oMobileRetentionOrder.SetOrder_id(Convert.ToInt32(Func.IDSubtract100000(WebFunc.qsOrder_id)));
        if (!x_oMobileRetentionOrder.Retrieve()) return;
        if (!x_oMobileRetentionOrder.GetFound() || x_oMobileRetentionOrder.GetOrder_id() == null)
            throw new BusinessObjectNotFoundException("Cannot find the record!");
        delivery_exchange_location.Attributes["readonly"] = "readonly";
        issue_type.Value = n_sISSUE_TYPE;

        SetHtmlControlStyle("ac_no_show", HtmlTextWriterStyle.Display, "none", true);
        SetHtmlControlStyle("existing_customer_type_show", HtmlTextWriterStyle.Display, "none", true);
        SetHtmlControlStyle("original_tariff_fee_show", HtmlTextWriterStyle.Display, "none", true);
        SetHtmlControlStyle("existing_contract_end_month_show", HtmlTextWriterStyle.Display, "none", true);

        load_hl();
        ch_g_code();
        ch_g_type();
        ch_a_code();
        vaild_date(x_oMobileRetentionOrder.GetIssue_type());
        vaild_amount();

        n_oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
        n_oStaffinfo_new = new Staffinfo_new(n_oDB);
        if (Request["mrt"] != null) mrt_no.Value = Request["mrt"].ToString();
        log_date.Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        log_date.Attributes["readonly"] = "true";
        if (WebFunc.qsOrder_id != null)
        {
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT top 1 order_status,fallout_reason,cdate FROM " + Configurator.MSSQLTablePrefix + "MobileOrderReport with (nolock)  WHERE active=1 AND order_id='" + Func.IDSubtract100000(WebFunc.qsOrder_id).Trim() + "' ORDER BY cdate desc, email_date desc");
            if (_oDr.Read())
            {
                if ("FALLOUT".Equals(_oDr[MobileOrderReport.Para.order_status].ToString().Trim()))
                {
                    FalloutReply.Visible = true;
                    fo_reply.Visible = true;
                }
                else
                {
                    FalloutReply.Visible = false;
                    fo_reply.Visible = false;
                }
            }
            else
            {
                FalloutReply.Visible = false;
                fo_reply.Visible = false;
            }
            _oDr.Close();
            _oDr.Dispose();
        }
        if (RWLFramework.CurrentUser[this.Page].Lv.ToString() == "10" || RWLFramework.CurrentUser[this.Page].Lv.ToString() == "30" || RWLFramework.CurrentUser[this.Page].Lv.ToString() == "65535")
        {
            //vip_case.ReadOnly = true;
        }


        
        staff_no.Value = RWLFramework.CurrentUser[this.Page].Uid;

        if (
            RWLFramework.CurrentUser[this.Page].Lv.ToString() == "10" ||
            RWLFramework.CurrentUser[this.Page].Lv.ToString() == "65535"
            )
        {
            staff_no.Attributes["readonly"] = "false";
            staff_no.Attributes.Remove("readonly");
        }
        else
        {
            staff_no.Attributes["readonly"] = "true";
        }

        if (ChkChangeStaffInfo())
            ch_cust_button.Style[HtmlTextWriterStyle.Display] = "inline";
        else
            ch_cust_button.Style[HtmlTextWriterStyle.Display] = "none";

        family_name.Disabled = false;
        given_name.Disabled = false;

        con_eff_date.Value = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy");


        if (issue_type.Value == "2G_RETENTION")
            remarks2edf_show.Style[HtmlTextWriterStyle.Display] = "none";
        else
            remarks2edf_show.Style[HtmlTextWriterStyle.Display] = "inline";
    }


    protected bool ChkChangeStaffInfo()
    {
        if (RWLFramework.CurrentUser[this.Page].Uid.Equals("1020874") ||
            RWLFramework.CurrentUser[this.Page].Uid.Equals("A3150498") ||
            RWLFramework.CurrentUser[this.Page].Uid.Equals("1038371") ||
            RWLFramework.CurrentUser[this.Page].Uid.Equals("1147214") ||
            RWLFramework.CurrentUser[this.Page].Uid.Equals("1161892") ||
            RWLFramework.CurrentUser[this.Page].Uid.Equals("1022243") ||
            RWLFramework.CurrentUser[this.Page].Uid.Equals("A3150515") ||
            RWLFramework.CurrentUser[this.Page].Uid.Equals("A8350006"))
        {
            return true;
        }
        return false;
    }
    #endregion

    #region GiftDescListBindData
    protected void GiftDescListBindData()
    {
        SqlDataReader _oReader = FromRegisterControler.Get_GiftDescList_DataReader();
        gift_desc41.Items.Clear();
        gift_desc41.Items.Add(new ListItem(string.Empty, string.Empty));
        gift_desc31.Items.Clear();
        gift_desc31.Items.Add(new ListItem(string.Empty, string.Empty));
        gift_desc21.Items.Clear();
        gift_desc21.Items.Add(new ListItem(string.Empty, string.Empty));
        gift_desc1.Items.Clear();
        gift_desc1.Items.Add(new ListItem(string.Empty, string.Empty));
        if (_oReader != null)
        {
            while (_oReader.Read())
            {
                if (n_sISSUE_TYPE == "GO_WIRELESS" || !_oReader["gift_desc"].ToString().Equals("PCCW 3G 64K USIM (V1.0)"))
                {
                    gift_desc41.Items.Add(new ListItem(_oReader["gift_desc"].ToString(), _oReader["gift_desc"].ToString()));
                    gift_desc31.Items.Add(new ListItem(_oReader["gift_desc"].ToString(), _oReader["gift_desc"].ToString()));
                    gift_desc21.Items.Add(new ListItem(_oReader["gift_desc"].ToString(), _oReader["gift_desc"].ToString()));
                    gift_desc1.Items.Add(new ListItem(_oReader["gift_desc"].ToString(), _oReader["gift_desc"].ToString()));
                }
            }
        }
        if (_oReader != null) { _oReader.Close(); _oReader.Dispose(); }

    }
    #endregion

    #region AccessoryDescListBindData
    protected void AccessoryDescListBindData()
    {
        SqlDataReader _oReader = FromRegisterControler.Get_AccessoryDescList_DataReader();
        accessory_desc1.Items.Clear();
        accessory_desc1.Items.Add(new ListItem(string.Empty, string.Empty));
        if (_oReader != null)
        {
            while (_oReader.Read())
            {
                if (n_sISSUE_TYPE == "GO_WIRELESS" || !_oReader["accessory_desc"].ToString().Equals("AUTO NETWORK SELECTOR (ANS) - E180"))
                {
                    accessory_desc1.Items.Add(new ListItem(_oReader["accessory_desc"].ToString(), _oReader["accessory_desc"].ToString()));
                }
            }
        }
        if (_oReader != null) { _oReader.Close(); _oReader.Dispose(); }
    }
    #endregion

    #region BankNameListBindData
    public void BankNameListBindData()
    {
        SqlDataReader _oReader = FromRegisterControler.Get_BankNameList_DataReader(true);
        bank_name.Items.Clear();
        bank_name.Items.Add(new ListItem(string.Empty, string.Empty));
        if (_oReader != null)
        {
            while (_oReader.Read())
            {
                bank_name.Items.Add(new ListItem(_oReader[BankCode.Para.bank_name].ToString().ToUpper(), _oReader[BankCode.Para.bank_name].ToString().ToUpper()));
            }
        }
        if (_oReader != null) { _oReader.Close(); _oReader.Dispose(); }
    }
    #endregion

    #region DistrictList
    public void DistrictListBindData()
    {
        //SqlDataReader _oReader = FromRegisterControler.Get_District_DataReader();

        //mod hidden
        /*
        d_district.Items.Clear();
        d_district.Items.Add(new ListItem(string.Empty, string.Empty));
        if (_oReader != null)
        {
            while (_oReader.Read())
            {
                d_district.Items.Add(new ListItem(_oReader["location"].ToString().ToUpper(), _oReader["location"].ToString().ToUpper()));
            }
        }
        */

        //if (_oReader != null) { _oReader.Close(); _oReader.Dispose(); }
    }
    #endregion

    #region SPremium1BindData
    public void SPremium1BindData()
    {
        List<string> _oHsmodelList = RWLFramework.Control<HandSetEnvironment>().Get_SPremiumTypeHs();
        s_premium1.Items.Clear();
        s_premium1.Items.Add(new ListItem(string.Empty, string.Empty));
        for (int i = 0; i < _oHsmodelList.Count; i++)
        {
            s_premium1.Items.Add(new ListItem(_oHsmodelList[i].ToString().ToUpper(), _oHsmodelList[i].ToString().ToUpper()));
        }
    }
    #endregion

    #region SPremium2BindData
    public void SPremium2BindData()
    {
        List<string> _oHsmodelList = RWLFramework.Control<HandSetEnvironment>().Get_SPremiumTypeHs();
        s_premium2.Items.Clear();
        s_premium2.Items.Add(new ListItem(string.Empty, string.Empty));
        for (int i = 0; i < _oHsmodelList.Count; i++)
        {
            s_premium2.Items.Add(new ListItem(_oHsmodelList[i].ToString().ToUpper(), _oHsmodelList[i].ToString().ToUpper()));
        }
    }
    #endregion

    #region SPremium3BindData
    public void SPremium3BindData()
    {
        List<string> _oHsmodelList = RWLFramework.Control<HandSetEnvironment>().Get_SPremiumTypeHs();
        s_premium3.Items.Clear();
        s_premium3.Items.Add(new ListItem(string.Empty, string.Empty));
        for (int i = 0; i < _oHsmodelList.Count; i++)
        {
            s_premium3.Items.Add(new ListItem(_oHsmodelList[i].ToString().ToUpper(), _oHsmodelList[i].ToString().ToUpper()));
        }
    }
    #endregion

    #region SPremium4BindData
    public void SPremium4BindData()
    {
        List<string> _oHsmodelList = RWLFramework.Control<HandSetEnvironment>().Get_SPremiumTypeHs();
        s_premium4.Items.Clear();
        s_premium4.Items.Add(new ListItem(string.Empty, string.Empty));
        for (int i = 0; i < _oHsmodelList.Count; i++)
        {
            s_premium4.Items.Add(new ListItem(_oHsmodelList[i].ToString().ToUpper(), _oHsmodelList[i].ToString().ToUpper()));
        }
    }
    #endregion

   


    #region BindData
    protected void BindData()
    {
        BaseInit();
        IssueTypeRetrieve();
        ExistingCustomerTypeBindData();
        SuspendReasonBindData();
        ProgramListBindData();
        NormalRebateTypeBindData(false);
        SimCardNameBindData();
        GiftDescListBindData();
        AccessoryDescListBindData();
        BankNameListBindData();
        SPremium1BindData();
        SPremium2BindData();
        SPremium3BindData();
        SPremium4BindData();
        HandSetOfferTypeDataBind();
        MonthlyPaymentTypeDataBind();
        PayMethodDataBind();
        CNMobileNumberDataBind();
        UpgradeOrderInit();
        WinOrderInit();
        RetrieveRecord();
        BankCodeArrScriptInit();
        
    }
    #endregion

    protected void UpgradeOrderInit()
    {
        upgrade_existing_contract_sdate.Attributes["readonly"] = "readonly";
        upgrade_existing_contract_edate.Attributes["readonly"] = "readonly";
    }
    protected void WinOrderInit()
    {
        upgrade_existing_contract_sdate.Attributes["readonly"] = "readonly";
        upgrade_existing_contract_edate.Attributes["readonly"] = "readonly";
    }
    protected void CNMobileNumberDataBind()
    {
        MobileNumberProfileRepository _oMobileNumberProfileRepository = new MobileNumberProfileRepository(SYSConn<MSSQLConnect>.Connect());
        List<MobileNumberProfileEntity> _oMobileNumberProfileArr = MobileNumberProfileRepository.GetListObj(SYSConn<MSSQLConnect>.Connect(), -1, "active=1 AND status='AVALIABLE' AND pool='" + pool.SelectedValue + "'", null, "mrt_no");
        cn_mrt_no_list.Items.Clear();
        for (int i = 0; i < _oMobileNumberProfileArr.Count; i++)
        {
            if (_oMobileNumberProfileArr[i].mrt_no != null)
            {
                string _sMrt_no = ((long)_oMobileNumberProfileArr[i].mrt_no).ToString();
                cn_mrt_no_list.Items.Add(new ListItem(_sMrt_no, _sMrt_no));
            }
        }
        cn_mrt_no.Value = string.Empty;
    }
    protected void MonthlyPaymentTypeDataBind()
    {
        string _sProgram = ((program.Items.Count > 0) ? program.SelectedValue.ToString() : string.Empty);
        string _sIssue_type = issue_type.Value;
        monthly_payment_type.Items.Clear();
        List<string> _oMonthlyPaymentList = FromRegisterControler.GetPaymentMethodList(_sProgram, "MONTHLY PAYMENT", _sIssue_type);
        for (int i = 0; i < _oMonthlyPaymentList.Count; i++)
        {
            monthly_payment_type.Items.Add(new ListItem(_oMonthlyPaymentList[i], _oMonthlyPaymentList[i]));
        }
        update_panel_monthly_payment_method.Update();
        update_panel_change_payment_type.Update();
        update_panel_m_card_type.Update();
        update_panel_m_card_no.Update();
        update_panel_m_card_exp.Update();
        update_panel_m_card_holder2.Update();
    }

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

    #region Issue Type Retrieve
    protected void IssueTypeRetrieve()
    {
        if (x_oMobileRetentionOrder != null)
        {
            if (x_oMobileRetentionOrder.GetFound() == true && x_oMobileRetentionOrder.GetOrder_id() != null)
            {
                issue_type.Value = x_oMobileRetentionOrder.GetIssue_type();
                if (VasAutoSetScript.Instance().VasSetScript.ContainsKey(issue_type.Value) && !
                issue_type.Value.Equals(string.Empty))
                {
                    VasSetScript.Text = VasAutoSetScript.Instance().VasSetScript[issue_type.Value].ToString();
                }
            }
        }
    }
    #endregion

    #region HandSetOfferTypeDataBind
    protected void HandSetOfferTypeDataBind()
    {
        HandSetOfferTypeEntity[] _oHandSetOfferTypeArr = HandSetOfferTypeRepository.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), "active=1", null, "id asc");
        if (_oHandSetOfferTypeArr != null)
        {
            hs_offer_type_id.Items.Clear();
            for (int i = 0; i < _oHandSetOfferTypeArr.Length; i++)
            {
                if (_oHandSetOfferTypeArr[i].id != null)
                {
                    hs_offer_type_id.Items.Add(new ListItem(_oHandSetOfferTypeArr[i].name, ((int)_oHandSetOfferTypeArr[i].id).ToString()));
                }
            }
            hs_offer_type_id.SelectedValue = "DEFAULT";
        }
    }
    #endregion

    #region BankCodeArrScriptInit
    public void BankCodeArrScriptInit()
    {
        StringBuilder _oBankArrScript = new StringBuilder();
        _oBankArrScript.AppendLine("<script language=\"javascript\">");
        _oBankArrScript.AppendLine("var BankArr = new Array();");
        Dictionary<string, int> _oBankNameList = new Dictionary<string, int>();

        string _sQuery = "SELECT BANK_NAME,INSTALLMENT_PERIOD,BANK_CODE FROM BANKCODE WHERE ACTIVE=1 ORDER BY BANK_NAME DESC";
        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
        while (_oDr.Read())
        {
            if (_oBankNameList.ContainsKey(Func.FR(_oDr["BANK_NAME"])))
            {
                _oBankArrScript.AppendLine("BankArr['" + Func.FR(_oDr["BANK_NAME"]) + "'][" + _oBankNameList[Func.FR(_oDr["BANK_NAME"])].ToString() + "]=new Array();");
                _oBankArrScript.AppendLine("BankArr['" + Func.FR(_oDr["BANK_NAME"]) + "'][" + _oBankNameList[Func.FR(_oDr["BANK_NAME"])].ToString() + "][0]='" + Func.FR(_oDr["INSTALLMENT_PERIOD"]) + "';");
                _oBankArrScript.AppendLine("BankArr['" + Func.FR(_oDr["BANK_NAME"]) + "'][" + _oBankNameList[Func.FR(_oDr["BANK_NAME"])].ToString() + "][1]='" + Func.FR(_oDr["BANK_CODE"]) + "';");
                _oBankNameList[Func.FR(_oDr["BANK_NAME"])] += 1;
            }
            else
            {
                _oBankNameList.Add(Func.FR(_oDr["BANK_NAME"]), 0);
                _oBankArrScript.AppendLine("BankArr['" + Func.FR(_oDr["BANK_NAME"]) + "']=new Array();");
                _oBankArrScript.AppendLine("BankArr['" + Func.FR(_oDr["BANK_NAME"]) + "'][" + _oBankNameList[Func.FR(_oDr["BANK_NAME"])].ToString() + "]=new Array();");
                _oBankArrScript.AppendLine("BankArr['" + Func.FR(_oDr["BANK_NAME"]) + "'][" + _oBankNameList[Func.FR(_oDr["BANK_NAME"])].ToString() + "][0]='" + Func.FR(_oDr["INSTALLMENT_PERIOD"]) + "';");
                _oBankArrScript.AppendLine("BankArr['" + Func.FR(_oDr["BANK_NAME"]) + "'][" + _oBankNameList[Func.FR(_oDr["BANK_NAME"])].ToString() + "][1]='" + Func.FR(_oDr["BANK_CODE"]) + "';");
                _oBankNameList[Func.FR(_oDr["BANK_NAME"])] += 1;
            }
        }
        _oDr.Close();
        _oDr.Dispose();

        _oBankArrScript.AppendLine("function ChangeBankName(Obj) {");
        _oBankArrScript.AppendLine("var InstallmentPeriodObj = document.getElementById('installment_period');");
        _oBankArrScript.AppendLine("var BankCodeObj = document.getElementById('bank_code');");
        _oBankArrScript.AppendLine(" if (BankArr != undefined) {");
        _oBankArrScript.AppendLine("InstallmentPeriodObj.options.length = 0;");
        _oBankArrScript.AppendLine("InstallmentPeriodObj.options[InstallmentPeriodObj.options.length] = new Option(\"\", \"\");");
        _oBankArrScript.AppendLine("var BankNameArr = new Array();");
        _oBankArrScript.AppendLine("BankNameArr = BankArr[Obj.value];");
        _oBankArrScript.AppendLine("for (index in BankNameArr) {");
        _oBankArrScript.AppendLine("InstallmentPeriodObj.options[InstallmentPeriodObj.options.length] = new Option(BankNameArr[index][0], BankNameArr[index][1]);");
        _oBankArrScript.AppendLine("}");
        _oBankArrScript.AppendLine("BankCodeObj.value = \"\";");
        _oBankArrScript.AppendLine("}");
        _oBankArrScript.AppendLine("}");
        _oBankArrScript.AppendLine("function ChangeInstallmentPeriod(Obj)");
        _oBankArrScript.AppendLine("{");
        _oBankArrScript.AppendLine("var BankCodeObj = document.getElementById('bank_code');");
        _oBankArrScript.AppendLine("if (BankCodeObj != undefined) {");
        _oBankArrScript.AppendLine(" BankCodeObj.value = Obj.value;");
        _oBankArrScript.AppendLine("}");
        _oBankArrScript.AppendLine("}");
        _oBankArrScript.AppendLine("</script>");
        BankCodeArrScript.Text = _oBankArrScript.ToString();
    }
    #endregion

    #region Gift Vas
    public void c_vas()
    {
        IDSQuery _oReader1 = IDSQuery.CreateDsCriteria(VasCreateHolderControl.Instance().GetDs(), BusinessVas.Para.TableName())
            .Add(DsExpression.Eq(BusinessVas.Para.active, 1));
        if (_oReader1 == null) { return; }
        while (_oReader1.Read())
        {
            //HtmlVas
            SetHtmlControlAtt(_oReader1[BusinessVas.Para.vas_field].ToString().Trim(), HtmlTextWriterAttribute.Disabled, "true", false);

            //HtmlVas
            SetHtmlControlStyle(_oReader1[BusinessVas.Para.vas_field].ToString().Trim() + "2", HtmlTextWriterStyle.Display, "none", true);

            if (!n_oVasShowList.ContainsKey(_oReader1[BusinessVas.Para.vas_field].ToString().Trim()))
                n_oVasShowList.Add(_oReader1[BusinessVas.Para.vas_field].ToString().Trim(), false);
            else
                n_oVasShowList[_oReader1[BusinessVas.Para.vas_field].ToString().Trim()] = false;
        }
        if (_oReader1 != null) { _oReader1.Close(); }
        IDSQuery _oReader2 = IDSQuery.CreateDsCriteria(VasCreateHolderControl.Instance().GetDs(), BusinessVas.Para.TableName())
            .Add(DsExpression.Eq(BusinessVas.Para.multi, 1))
            .Add(DsExpression.Eq(BusinessVas.Para.active, 1));

        if (_oReader2 == null) { return; }
        while (_oReader2.Read())
        {
            //HtmlVas
            SetHtmlControlAtt(_oReader2[BusinessVas.Para.vas_field].ToString().Trim() + "1", HtmlTextWriterAttribute.Disabled, "true", false);

        }
        if (_oReader2 != null) { _oReader2.Close(); }
    }
    public void GiftVasReLoadSelected()
    {
        if (!IsPostBack)
            this.ViewState["VasPlaceUI"] = new VasViewerController();
        else
        {
            n_oVasViewerController = (VasViewerController)this.ViewState["VasPlaceUI"];
            ajaxvas();
        }
    }
    public void ObModifyCreate()
    {
        if (!IsPostBack)
        {
            if (RWLFramework.CurrentUser[this.Page].Channel == "OB" || RWLFramework.CurrentUser[this.Page].Lv == "65535")
            {
                MobileRetentionOrder _oMobileRetentionOrder = (MobileRetentionOrder)MobileRetentionOrderRepository.CreateEntityInstanceObject();
                _oMobileRetentionOrder.SetOrder_id(Convert.ToInt32(Func.IDSubtract100000(WebFunc.qsOrder_id)));
                if (!_oMobileRetentionOrder.Retrieve()) return;
                ob_program_id_show.Visible = true;
                Response.Write("<input type=\"button\" name=\"prog_id_btn\" value=\"Check\"   onclick=\"check_program_id()\"  style=\"font-size:12pt\"/> ");
                Response.Write("<input type=\"text\" id=\"ob_program_id\" name=\"ob_program_id\" value=\"" + _oMobileRetentionOrder.ob_program_id + "\" onblur=\"chg_upper(this);\"/>");
            }
            else
            {
                ob_program_id_show.Visible = false;
                Response.Write("<input name=\"ob_program_id\" type=\"hidden\" id=\"ob_program_id\" size=\"5\" maxlength=\"4\" style=\"font-size:7pt\" onBlur=\"chg_upper(this);\"/>");
            }
        }
    }
    public void GiftHtmlVasCreate()
    {
        VasCreateHolderControl _oVasCreateHolderControl = VasCreateHolderControl.Instance();

        _oVasCreateHolderControl.Td1_height = "28";
        _oVasCreateHolderControl.Td1_class = "row2";
        _oVasCreateHolderControl.Td1_width = "28%";

        _oVasCreateHolderControl.Span1_class = "explaintitle";
        _oVasCreateHolderControl.Span1_FontSize = "7pt";

        _oVasCreateHolderControl.Td2_height = "28";
        _oVasCreateHolderControl.Td2_class = "row1";
        _oVasCreateHolderControl.Td2_colspan = "3";
        _oVasCreateHolderControl.Span2_class = "gensmall";
        _oVasCreateHolderControl.Span2_FontSize = "7pt";

        _oVasCreateHolderControl.Drp1_FontSize = "7pt";
        _oVasCreateHolderControl.Drp2_FontSize = "7pt";

        GiftHtmlVasCreate_Literal.Text = _oVasCreateHolderControl.ReBuildHtmlVasControl(true, _iDeli_flag, _iCon_flag);
    }
    #endregion

    protected void s_premium_SelectedIndexChanged(object sender, EventArgs e)
    {
        c_tier_sel_top();
    }

    protected void s_premium1_SelectedIndexChanged(object sender, EventArgs e)
    {
        RegisterJSScript.AppendLine("SPremium1NoLoad();");
    }

    protected void s_premium2_SelectedIndexChanged(object sender, EventArgs e)
    {
        //RegisterJSScript.AppendLine("ch_mobileOne_premium2();");
        RegisterJSScript.AppendLine("SPremium2NoLoad();");
        //RegisterJSScript.AppendLine("chk_hs_sp2();");
    }

    protected void s_premium3_SelectedIndexChanged(object sender, EventArgs e)
    {
        RegisterJSScript.AppendLine("SPremium3NoLoad();");
    }

    protected void s_premium4_SelectedIndexChanged(object sender, EventArgs e)
    {
        RegisterJSScript.AppendLine("SPremium4NoLoad();");
    }

    protected void trade_field_SelectedIndexChanged(object sender, EventArgs e)
    {
        c_tier_sel_top();
        PreLoadAutoVasSet();
        _bVasAutoDefaultSet = true;
    }
    protected void bundle_name_SelectedIndexChanged(object sender, EventArgs e)
    {
        c_tier_sel_top();
        PreLoadAutoVasSet();
        _bVasAutoDefaultSet = true;
    }
    protected void rebate_amount4_SelectedIndexChanged(object sender, EventArgs e)
    {
        c_tier_sel_top();
    }
    protected void r_offer4_SelectedIndexChanged(object sender, EventArgs e)
    {
        c_tier_sel_top();
    }
    protected void extra_rebate_amount4_SelectedIndexChanged(object sender, EventArgs e)
    {
        c_tier_sel_top();
    }
    protected void extra_rebate4_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void gift_desc1_SelectedIndexChanged(object sender, EventArgs e)
    {
        update_panel_gift_desc1.Update();
        update_panel_gift_code.Update();
        update_panel_gift_imei.Update();
    }
    protected void gift_desc21_SelectedIndexChanged(object sender, EventArgs e)
    {
        update_panel_gift_desc21.Update();
        update_panel_gift_code2.Update();
        update_panel_gift_imei2.Update();
    }
    protected void gift_desc31_SelectedIndexChanged(object sender, EventArgs e)
    {
        update_panel_gift_desc31.Update();
        update_panel_gift_code3.Update();
        update_panel_gift_imei3.Update();
    }
    protected void gift_desc41_SelectedIndexChanged(object sender, EventArgs e)
    {
        update_panel_gift_desc41.Update();
        update_panel_gift_code4.Update();
        update_panel_gift_imei4.Update();
    }
    protected void accessory_desc1_SelectedIndexChanged(object sender, EventArgs e)
    {
        AccessoryChange();
    }

    protected void accessory_waive_CheckedChanged(object sender, EventArgs e)
    {
        AccessoryChange();
    }

    protected void AccessoryChange()
    {
        if (accessory_desc1.SelectedValue != null)
        {
            string _sValue = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar("SELECT top 1 accessory_price from Accessory where accessory_desc='" + accessory_desc1.SelectedValue.ToString() + "'");
            if (accessory_waive.Checked == false)
            {
                accessory_price.Value = _sValue;
                SetHtmlControlValue("accessory_price", _sValue, true);
            }
            else
            {
                accessory_price.Value = "0";
                SetHtmlControlValue("accessory_price", "0", true);
            }
        }
        update_panel_accessory_desc1.Update();
        update_panel_accessory_code.Update();
        update_panel_change_payment_type.Update();
    }
    protected void aig_gift_SelectedIndexChanged(object sender, EventArgs e)
    {

    }


    protected void d_district_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void d_time_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void bank_code_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void action_required_CheckedChanged(object sender, EventArgs e)
    {
        action_required2.Checked = false;
        RegisterJSScript.AppendLine("en_action()");
        RegisterJSScript.AppendLine("c_all()");
        if (action_required.Checked)
        {

        }
    }
    protected void action_required2_CheckedChanged(object sender, EventArgs e)
    {
        action_required.Checked = false;
        RegisterJSScript.AppendLine("en_action_opt()");
        RegisterJSScript.AppendLine("c_all_opt()");
        if (action_required.Checked)
        {

        }
    }
    protected void go_wireless_SelectedIndexChanged(object sender, EventArgs e)
    {
        ISimMrtControlEntityRepository _oSimMrtControl = new SimMrtControl();
        _oSimMrtControl.SetUid(RWLFramework.CurrentUser[this.Page].Uid);
        if (go_wireless.SelectedValue != "NO" && go_wireless.SelectedValue != "")
        {
            string _sResult = _oSimMrtControl.GetSimMrt();
            if (!_sResult.Equals("NO MRT"))
            {
                SetHtmlControlValue("sim_mrt", _sResult.ToString(), true);
                preferred_languages.Enabled = true;
                register_address.Disabled = false;
                RegisterJSScript.AppendLine("delivery_style(\"yes\");");
                ch_delivery();
            }
            else
            {
                RegisterJSScript.AppendLine("alert('NO MRT');");
                if (go_wireless.Items.Contains(new ListItem("NO")))
                    go_wireless.SelectedValue = "NO";
                RegisterJSScript.AppendLine("delivery_style(\"no\");");
            }
        }
        else
        {
            _oSimMrtControl.SetDelete("YES");
            _oSimMrtControl.SetMrt(sim_mrt.Value);
            _oSimMrtControl.SetOrder_id(Convert.ToInt32(Func.IDSubtract100000(WebFunc.qsOrder_id)));
            _oSimMrtControl.GetSimMrt();
            preferred_languages.Enabled = false;
            register_address.Value = string.Empty;
            register_address.Disabled = true;
            SetHtmlControlStyle("release_sim_mrt", HtmlTextWriterStyle.Display, "none", true);
            RegisterJSScript.AppendLine("delivery_style(\"no\");");
        }
        RegisterJSScript.AppendLine("NoLoadGetSimMrt();");
    }

    #region  Enable/Disable some fields of OPT OUT
    protected void ch_easy_id()
    {
        if ((1).Equals(easywatch_type.SelectedIndex))
        {
            easywatch_ord_id.Disabled = false;
            easywatch_ord_id.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFbb";
            easywatch_ord_id.Focus();

            family_name.Attributes["readonly"] = "true";
            given_name.Attributes["readonly"] = "true";

            id_type1.Value = id_type.Value;
            id_type.Disabled = true;
            id_type1.Disabled = false;
            id_type1.Attributes.Remove("disabled");
            //id_type.Style[HtmlTextWriterStyle.Display] = "none";
            //id_type1.Style[HtmlTextWriterStyle.Display] = "inline";
            hkid.Attributes["readonly"] = "true";
            if ("HKID".Equals(id_type.Value))
                hkid2.Attributes["readonly"] = "true";

            family_name.Value = string.Empty;
            given_name.Value = string.Empty;

            id_type1.Value = string.Empty;
            hkid.Value = string.Empty;
            hkid2.Value = string.Empty;
            
        }
        else
        {
            easywatch_ord_id.Disabled = true;
            easywatch_ord_id.Value = string.Empty;
            easywatch_ord_id.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";

            family_name.Attributes["readonly"] = "false";
            family_name.Attributes.Remove("readonly");

            given_name.Attributes["readonly"] = "false";
            given_name.Attributes.Remove("readonly");

            id_type.Disabled = false;
            id_type.Attributes.Remove("disabled");
            id_type1.Disabled = true;
            //id_type.Style[HtmlTextWriterStyle.Display] = "inline";
            //id_type1.Style[HtmlTextWriterStyle.Display] = "none";
            hkid.Attributes["readonly"] = "false";
            hkid.Attributes.Remove("readonly");
            if ("HKID".Equals(id_type.Value))
            {
                hkid2.Attributes["readonly"] = "false";
                hkid2.Attributes.Remove("readonly");
            }
        }
    }
    #endregion

    #region Clear Polled Down
    protected void c_org_fee()
    {
        org_fee.Items.Clear();
        org_fee.Items.Add(new ListItem(string.Empty, string.Empty));
    }
    protected void c_tier()
    {

    }
    protected void c_con_per()
    {
        con_per.Items.Clear();
        con_per.Items.Add(new ListItem(string.Empty, string.Empty));
    }
    protected void c_extra_rebate()
    {
        extra_rebate.Value = string.Empty;
        extra_rebate4.Items.Clear();
        extra_rebate4.Items.Add(new ListItem(string.Empty, string.Empty));
    }
    protected void c_extra_rebate_amount()
    {
        extra_rebate_amount.Value = string.Empty;
        extra_rebate_amount4.Items.Clear();
        extra_rebate_amount4.Items.Add(new ListItem(string.Empty, string.Empty));
    }
    protected void c_rebate_amount()
    {
        rebate_amount.Value = string.Empty;
        rebate_amount4.Items.Clear();
        rebate_amount4.Items.Add(new ListItem(string.Empty, string.Empty));
    }
    protected void c_r_offer()
    {
        r_offer.Value = string.Empty;
        r_offer4.Items.Clear();
        r_offer4.Items.Add(new ListItem(string.Empty, string.Empty));
    }
    protected void c_plan_fee()
    {
        plan_fee.Items.Clear();
        plan_fee.Items.Add(new ListItem(string.Empty, string.Empty));
    }
    protected void c_trade_field()
    {
        trade_field.Items.Clear();
        trade_field.Items.Add(new ListItem(string.Empty, string.Empty));
    }
    protected void c_bundle_name()
    {
        bundle_name.Items.Clear();
        bundle_name.Items.Add(new ListItem(string.Empty, string.Empty));
    }
    protected void c_hs_model()
    {
        sku.Value = string.Empty;
        hs_model.Items.Clear();
        hs_model.Items.Add(new ListItem(string.Empty, string.Empty));
    }
    protected void c_premium()
    {
        premium.Items.Clear();
        premium.Items.Add(new ListItem(string.Empty, string.Empty));
    }
    protected void c_rate_plan()
    {
        rate_plan.Items.Clear();
        rate_plan.Items.Add(new ListItem(string.Empty, string.Empty));
    }
    protected void c_rebate()
    {
        rebate.Items.Clear();
        rebate.Items.Add(new ListItem(string.Empty, string.Empty));
    }
    protected void c_s_premium()
    {
        s_premium.Items.Clear();
        s_premium.Items.Add(new ListItem(string.Empty, string.Empty));
    }

    protected void c_SpecialPremium1()
    {
        s_premium1.Items.Clear();
        s_premium1.Items.Add(new ListItem(string.Empty, string.Empty));
    }

    protected void c_SpecialPremium2()
    {
        s_premium2.Items.Clear();
        s_premium2.Items.Add(new ListItem(string.Empty, string.Empty));
    }

    protected void c_SpecialPremium3()
    {
        s_premium3.Items.Clear();
        s_premium3.Items.Add(new ListItem(string.Empty, string.Empty));
    }

    protected void c_SpecialPremium4()
    {
        s_premium4.Items.Clear();
        s_premium4.Items.Add(new ListItem(string.Empty, string.Empty));
    }

    protected void c_free_mon()
    {
        free_mon.Items.Clear();
        free_mon.Items.Add(new ListItem(string.Empty, string.Empty));
    }
    #endregion

    #region ch_delivery
    public void ch_delivery()
    {
        if ("".Equals(hs_model.SelectedValue) &&
            (issue_type.Value != "UPGRADE" && issue_type.Value != "WIN") &&
            "".Equals(sim_item_name1.SelectedValue)
            && (go_wireless.SelectedValue == "" || go_wireless.SelectedValue == "NO"))
        {
            bool _bGiftFlag = false;
            if (gift_code.Value != string.Empty && gift_imei.Value != string.Empty && gift_desc.Value != string.Empty)
                _bGiftFlag = true;
            else
                _bGiftFlag = false;

            bool _bGiftFlag2 = false;
            if (gift_code2.Value != string.Empty && gift_imei2.Value != string.Empty && gift_desc2.Value != string.Empty)
                _bGiftFlag2 = true;
            else
                _bGiftFlag2 = false;

            bool _bGiftFlag3 = false;
            if (gift_code3.Value != string.Empty && gift_imei3.Value != string.Empty && gift_desc3.Value != string.Empty)
                _bGiftFlag3 = true;
            else
                _bGiftFlag3 = false;

            bool _bGiftFlag4 = false;
            if (gift_code4.Value != string.Empty && gift_imei4.Value != string.Empty && gift_desc4.Value != string.Empty)
                _bGiftFlag4 = true;
            else
                _bGiftFlag4 = false;

            bool _bAccessoryFlag4 = false;
            if (accessory_code.Value != string.Empty && accessory_imei.Value != string.Empty && accessory_desc.Value != string.Empty)
                _bAccessoryFlag4 = true;
            else
                _bAccessoryFlag4 = false;

            if (!_bGiftFlag)
            {
                gift_desc1.Enabled = false;
                gift_desc1.SelectedValue = "";
            }
            if (!_bGiftFlag2)
            {
                gift_desc21.Enabled = false;
                gift_desc21.SelectedValue = "";
            }
            if (!_bGiftFlag2)
            {
                gift_desc31.Enabled = false;
                gift_desc31.SelectedValue = "";
            }

            if (!_bGiftFlag4)
            {
                gift_desc41.Enabled = false;
                gift_desc41.SelectedValue = "";
            }

            if (!_bAccessoryFlag4)
            {
                accessory_desc1.Enabled = false;
                accessory_desc1.SelectedValue = "";
            }

            d_address.Attributes["disabled"] = "false";

            /*
            d_type.Enabled = false;
            d_room.Disabled = true;
            d_floor.Disabled = true;
            d_blk.Disabled = true;

            d_build.Disabled = true;
            d_street.Disabled = true;
            d_district.Enabled = false;

            d_region_0.Disabled = true;
            d_region_1.Disabled = true;
            d_region_2.Disabled = true;
            */
            //d_date_Day_ID.Disabled=true;
            //d_date_Month.Disabled=true;
            //d_date_Year_ID.Disabled=true;
            d_date.Enabled = false;
            d_time.Enabled = false;
            extra_d_charge.Disabled = true;
            MobileOrderThreePartyControl.Enabled = false;
            MobileOrderThreePartyControl.Reset();
            contact_person.Disabled = true;
            contact_no.Disabled = true;
            ext_place_tel.Disabled = true;
            pay_method.Enabled = false;
            remarks2EDF.Disabled = true;
            SetHtmlControlAtt("remarks2EDF", HtmlTextWriterAttribute.Disabled, "true", false);
            /*
            d_type.SelectedValue = string.Empty;
            d_room.Value = string.Empty;
            d_floor.Value = string.Empty;
            d_blk.Value = string.Empty;
            d_build.Value = string.Empty;
            d_street.Value = string.Empty;
            d_district.SelectedValue = string.Empty;
            d_region_0.Checked = false;
            d_region_1.Checked = false;
            d_region_2.Checked = false;
            */
            d_time.SelectedValue = string.Empty;
            extra_d_charge.Value = string.Empty;
            contact_person.Value = string.Empty;
            contact_no.Value = string.Empty;
            ext_place_tel.Value = string.Empty;
            pay_method.SelectedValue = string.Empty;
            remarks2EDF.Value = string.Empty;
            d_date.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            /*
            d_type.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            d_room.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            d_floor.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            d_blk.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            d_build.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            d_district.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            d_street.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            d_region_0.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            d_region_1.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            d_region_2.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            d_district.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            */
            d_time.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            extra_d_charge.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            contact_person.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            d_time.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            extra_d_charge.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            contact_person.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            contact_no.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            ext_place_tel.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            pay_method.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            amount.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            remarks2EDF.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            dis_card();

            premium.Enabled = true;
            free_mon.Enabled = true;
            rebate.Enabled = true;
        }
        else
        {


            if (gift_desc1.SelectedValue == string.Empty) { gift_desc1.Enabled = true; }
            if (gift_desc21.SelectedValue == string.Empty) { gift_desc21.Enabled = true; }
            if (gift_desc31.SelectedValue == string.Empty) { gift_desc31.Enabled = true; }
            if (gift_desc41.SelectedValue == string.Empty) { gift_desc41.Enabled = true; }
            if (accessory_desc1.SelectedValue == string.Empty) { accessory_desc1.Enabled = true; }

            d_address.Attributes.Remove("disabled");

            /*
            d_type.Enabled = true;
            d_room.Disabled = false;
            d_floor.Disabled = false;
            d_blk.Disabled = false;

            d_build.Disabled = false;
            d_street.Disabled = false;
            d_district.Enabled = true;

            d_region_0.Disabled = false;
            d_region_1.Disabled = false;
            d_region_2.Disabled = false;
            */
            //d_date_Day_ID.Disabled=false;
            //d_date_Month.Disabled=false;
            //d_date_Year_ID.Disabled=false;
            d_date.Enabled = true;
            d_time.Enabled = true;
            extra_d_charge.Disabled = false;
            MobileOrderThreePartyControl.Enabled = true;
            contact_person.Disabled = false;
            contact_no.Disabled = false;
            ext_place_tel.Disabled = false;
            pay_method.Enabled = true;
            remarks2EDF.Disabled = false;
            SetHtmlControlAtt("remarks2EDF", HtmlTextWriterAttribute.Disabled, "false", false);
            /*
            d_type.SelectedValue = string.Empty;
            d_room.Value = string.Empty;
            d_floor.Value = string.Empty;
            d_blk.Value = string.Empty;
            d_build.Value = string.Empty;
            d_street.Value = string.Empty;
            d_district.SelectedValue = string.Empty;
            d_region_0.Checked = false;
            d_region_1.Checked = false;
            d_region_2.Checked = false;
            */
            /*
            d_time.SelectedValue = string.Empty;
            extra_d_charge.Value = string.Empty;
            contact_person.Value = string.Empty;
            contact_no.Value = string.Empty;
            ext_place_tel.Value = string.Empty;
            pay_method.SelectedValue = string.Empty;
            remarks2EDF.Value = string.Empty;
            */
            r_offer4.Enabled = false;
            rebate_amount4.Enabled = false;
            d_date.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            /*
            d_type.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            d_room.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            d_floor.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            d_blk.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            d_build.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            d_street.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            d_district.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            d_region_0.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            d_region_1.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            d_region_2.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            d_district.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            */
            d_time.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            extra_d_charge.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            contact_person.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            d_time.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            extra_d_charge.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            contact_person.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            contact_no.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            ext_place_tel.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            pay_method.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            amount.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            remarks2EDF.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            dis_card();
            

            if ("".Equals(premium.SelectedValue))
            {
                hs_model.Enabled = true;
                rebate_amount.Disabled = false;
                rebate_amount1.Disabled = false;
                rebate_amount2.Disabled = false;
                rebate_amount3.Disabled = false;
                extra_rebate_amount.Disabled = false;
                extra_rebate_amount1.Disabled = false;
                extra_rebate_amount2.Disabled = false;
                extra_rebate_amount3.Disabled = false;
                r_offer.Disabled = false;
                r_offer1.Disabled = false;
                r_offer2.Disabled = false;
            }
            else if (premium.SelectedValue != "WELLCOME COUPON $800" && premium.SelectedValue != "WELLCOME COUPON $200" && premium.SelectedValue != "WELLCOME COUPON $400")
            {
                hs_model.SelectedValue = string.Empty;
                sku.Value = string.Empty;
                rebate_amount.Value = string.Empty;
                rebate_amount4.SelectedValue = string.Empty;
                r_offer.Value = string.Empty;
                r_offer4.SelectedValue = string.Empty;
                hs_model.Enabled = false;
                rebate_amount.Disabled = true;
                rebate_amount1.Disabled = true;
                rebate_amount2.Disabled = true;
                rebate_amount3.Disabled = true;
                rebate_amount4.Enabled = true;
                extra_rebate_amount.Disabled = true;
                extra_rebate_amount1.Disabled = true;
                extra_rebate_amount2.Disabled = true;
                extra_rebate_amount3.Disabled = true;
                r_offer.Disabled = true;
                r_offer1.Disabled = true;
                r_offer2.Disabled = true;
                r_offer4.Enabled = true;
            }
        }
    }
    #endregion

    #region dis card
    public void dis_card()
    {
        if ("CASH".Equals(pay_method.SelectedValue) || "".Equals(pay_method.SelectedValue))
        {
            card_type.Enabled = false;
            card_no.Enabled = false;
            SetHtmlControlAtt("but_card_no", HtmlTextWriterAttribute.Disabled, "true", false);
            card_holder.Disabled = true;
            card_exp_month.Enabled = false;
            card_exp_year.Enabled = false;
            bank_name.Enabled = false;

            card_type.SelectedValue = "";
            card_no.Text = string.Empty;

            card_holder.Value = "";
            card_exp_month.SelectedValue = "";
            card_exp_year.SelectedValue = "";
            bank_name.SelectedValue = "";

            card_type.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            card_no.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            card_holder.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            card_exp_month.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            card_exp_year.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            bank_name.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
        }
        else
        {
            card_type.Enabled = true;
            card_no.Enabled = true;
            SetHtmlControlAtt("but_card_no", HtmlTextWriterAttribute.Disabled, "false", false);
            card_holder.Disabled = false;
            card_exp_month.Enabled = true;
            card_exp_year.Enabled = true;


            card_type.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFbb";
            card_no.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFbb";
            card_holder.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFbb";
            card_exp_month.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFbb";
            card_exp_year.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFbb";


            if (pay_method.SelectedValue == "CREDIT CARD INSTALLMENT")
            {
                bank_name.Enabled = true;
                bank_name.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFbb";
            }
            else
            {
                bank_name.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
                bank_name.Enabled = false;
            }
        }
    }

    #endregion

    #region ChangeVasVal
    protected bool ChangeVasVal(int x_iNumDrp, string x_sID, bool? x_bDisplay, bool? x_bEnabled, string x_sSelectValue)
    {
        if (string.IsNullOrEmpty(x_sID)) return false;

        //HtmlVas
        if (x_bDisplay != null)
        {
            if (((bool)x_bDisplay))
                SetHtmlControlStyle(x_sID, HtmlTextWriterStyle.Display, "inline", true);
            else
                SetHtmlControlStyle(x_sID, HtmlTextWriterStyle.Display, "none", true);
        }

        if (x_bEnabled != null)
        {
            if (((bool)x_bEnabled))
                SetHtmlControlAtt(x_sID, HtmlTextWriterAttribute.Disabled, "false", false);
            else
                SetHtmlControlAtt(x_sID, HtmlTextWriterAttribute.Disabled, "true", false);
        }

        if (x_sSelectValue != null)
            SetHtmlControlValue(x_sID, x_sSelectValue, true);
        return true;
    }
    #endregion
    
    #region c_s_approval
    protected void c_s_approval()
    {
        if ("OB".Equals(channel.Value))
        {
            special_approval.Enabled = true;
        }
        else
        {
            special_approval.Enabled = false;
            special_approval.SelectedIndex = 1;
        }
    }
    #endregion

    #region Plan_Fee
    public void c_plan_fee_sel_top()
    {
        if (plan_fee.Items.Count > 0) plan_fee.SelectedIndex = 0;
    }
    #endregion

    #region Tier
    public void c_tier_sel_top()
    {



    }
    #endregion

    #region en_lob
    public void en_lob()
    {
        if ((normal_rebate_type.SelectedValue == "LOYAL RETENTION+") && program.SelectedValue != "GO WIRELESS TOO(UPSELL)")
        {
            lob.Enabled = true;
            lob.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFbb";
            lob_ac.Disabled = false;
            lob_ac.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFbb";
            go_wireless_package_code.Disabled = true;
            go_wireless_package_code.Value = string.Empty;
            go_wireless_package_code.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
        }
        else if ((normal_rebate_type.SelectedValue != "LOYAL RETENTION+") && program.SelectedValue == "GO WIRELESS TOO(UPSELL)")
        {
            lob.Enabled = true;
            lob.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFbb";
            lob_ac.Disabled = false;
            lob_ac.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFbb";
            go_wireless_package_code.Disabled = false;
            go_wireless_package_code.Value = string.Empty;
            go_wireless_package_code.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFbb";
        }
        else
        {
            lob.Enabled = false;
            lob.SelectedValue = string.Empty;
            lob.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            lob_ac.Disabled = true;
            lob_ac.Value = string.Empty;
            lob_ac.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            go_wireless_package_code.Disabled = true;
            go_wireless_package_code.Value = string.Empty;
            go_wireless_package_code.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
        }
    }
    #endregion

    #region vaild_amount
    public void vaild_amount()
    {
        JavascriptHolder _oJavascriptHolder = new JavascriptHolder(this.Page);
        _oJavascriptHolder.AppendLine("<script>");
        _oJavascriptHolder.AppendLine("function vaild_amount()");
        _oJavascriptHolder.AppendLine("{");
        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT min_amount,bank_code FROM " + Configurator.MSSQLTablePrefix + "BankCode with (nolock) where active=1");
        while (_oDr.Read())
        {
            _oJavascriptHolder.AppendLine("if (document.getElementById(\"form1\").bank_code.value==\"" + _oDr["bank_code"].ToString() + "\" &&  parseInt(document.getElementById(\"form1\").amount.value)<parseInt(\"" + _oDr["min_amount"].ToString() + "\")){");
            _oJavascriptHolder.AppendLine("	alert (\"Amount should be higher than " + _oDr["min_amount"].ToString() + " !\");");
            _oJavascriptHolder.AppendLine("	return false;");
            _oJavascriptHolder.AppendLine("}");
        }

        _oJavascriptHolder.AppendLine("return true;");
        _oJavascriptHolder.AppendLine("}");
        _oJavascriptHolder.AppendLine("</script>");
        if (_oDr != null) { _oDr.Close(); _oDr.Dispose(); }

        vaild_amount_holder.Text = _oJavascriptHolder.ToScript();
    }
    #endregion

    #region vaild_date
    public void vaild_date(string x_sIssue_type)
    {
        JavascriptHolder _oJavascriptHolder = new JavascriptHolder(this.Page);
        _oJavascriptHolder.AppendLine("<script>");
        _oJavascriptHolder.AppendLine("function vaild_date()");
        _oJavascriptHolder.AppendLine("{");
        _oJavascriptHolder.AppendLine("var IssueTypeObj = GetJID('issue_type');");
        _oJavascriptHolder.AppendLine("	var temp = new Array();");
        _oJavascriptHolder.AppendLine("	temp = GetJID(\"con_eff_date\").value.split(\"/\");");
        _oJavascriptHolder.AppendLine("	var new_con_date = new Date();");
        _oJavascriptHolder.AppendLine("	new_con_date=Date.parse(temp[1]+\"/\"+temp[0]+\"/\"+temp[2]);");
        _oJavascriptHolder.AppendLine("	");
        _oJavascriptHolder.AppendLine("	var temp = new Array()");
        _oJavascriptHolder.AppendLine("	temp = GetJID(\"d_date\").value.split(\"/\");");
        _oJavascriptHolder.AppendLine("	var new_d_date = new Date();");
        _oJavascriptHolder.AppendLine("	new_d_date=Date.parse(temp[1]+\"/\"+temp[0]+\"/\"+temp[2]);");
        _oJavascriptHolder.AppendLine("	var chk_d_date = new Date();");
        _oJavascriptHolder.AppendLine("	chk_d_date.setFullYear(temp[2],temp[1]-1,temp[0]);");
        _oJavascriptHolder.AppendLine("	var today = new Date();");
        _oJavascriptHolder.AppendLine("	new_today=Date.parse(today.getMonth()+1+\"/\"+today.getDate()+\"/\"+today.getYear())");
        _oJavascriptHolder.AppendLine("	var h=today.getHours();");
        _oJavascriptHolder.AppendLine("	var mm=today.getMinutes();");
        _oJavascriptHolder.AppendLine("	");
        _oJavascriptHolder.AppendLine("	if (chk_d_date.getDay()==0 && IssueTypeObj.value!=\"UPGRADE\" && IssueTypeObj.value!=\"WIN\"){");
        _oJavascriptHolder.AppendLine("		alert (\"不能選擇星期日送貨!\");");
        _oJavascriptHolder.AppendLine("		return false;");
        _oJavascriptHolder.AppendLine("	}");
        _oJavascriptHolder.AppendLine("	var temp = new Array()");
        _oJavascriptHolder.AppendLine("	temp = document.getElementById(\"form1\").d_date.value.split(\"/\")");
        _oJavascriptHolder.AppendLine("	d_date = temp[2]+'.' + temp[1] + '.' + temp[0];");
        _oJavascriptHolder.AppendLine("	");

        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect("CSSDB").GetSearch("SELECT CONVERT(varchar,p_date,102) p_date from [CSSDB].[dbo]." + ((Configurator.IsUat()) ? "uat_" : string.Empty) + "pccwmsns_holiday with (nolock) where active=1 and p_date>=getdate() ");
        while (_oDr.Read())
        {
            if (!Convert.IsDBNull(_oDr["p_date"]))
            {
                _oJavascriptHolder.AppendLine("if (d_date==\"" + _oDr["p_date"].ToString() + "\" ){");
                _oJavascriptHolder.AppendLine("	alert (\"不能選擇在公眾假期送貨!\");");
                _oJavascriptHolder.AppendLine("	return false;");
                _oJavascriptHolder.AppendLine("}");
            }
        }
        if (_oDr != null) { _oDr.Close(); _oDr.Dispose(); }


        _oJavascriptHolder.AppendLine("	if (CheckDeliveryDateTime()==false){");
        _oJavascriptHolder.AppendLine("		return false;");
        _oJavascriptHolder.AppendLine("	}");



        _oJavascriptHolder.AppendLine("	return true;	");
        _oJavascriptHolder.AppendLine("}");
        _oJavascriptHolder.AppendLine("</script>");

        vaild_date_holder.Text = _oJavascriptHolder.ToScript();
    }
    #endregion

    #region ch_g_code
    public void ch_g_code()
    {
        JavascriptHolder _oJavascriptHolder = new JavascriptHolder(this.Page);
        _oJavascriptHolder.AppendLine("<script>");
        _oJavascriptHolder.AppendLine("function ch_g_code(tobj,cobj){");
        _oJavascriptHolder.AppendLine("	if (tobj.value!=\"\"){");

        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch("select distinct gift_code,gift_desc from " + Configurator.MSSQLTablePrefix + "GiftBasket with (nolock) where active=1");
        while (_oDr.Read())
        {
            _oJavascriptHolder.AppendLine("			if (tobj.value==\"" + Func.FR(_oDr["gift_desc"]) + "\" )");
            _oJavascriptHolder.AppendLine("				cobj.value=\"" + Func.FR(_oDr["gift_code"]) + "\";");
        }
        _oDr.Close();
        _oDr.Dispose();
        _oDr = null;
        _oJavascriptHolder.AppendLine("	");
        _oJavascriptHolder.AppendLine("		var today = new Date();");
        _oJavascriptHolder.AppendLine("		new_today=Date.parse(today.getMonth()+1+\"/\"+today.getDate()+\"/\"+today.getYear());");
        _oJavascriptHolder.AppendLine("		");
        _oJavascriptHolder.AppendLine("		var ch_date = new Date();");
        _oJavascriptHolder.AppendLine("		ch_date=Date.parse(\"1/18/2008\");");
        _oJavascriptHolder.AppendLine("		if (cobj.value==\"2004191\" && ((new_today-ch_date)/86400000)>0){");
        _oJavascriptHolder.AppendLine("			alert (\"Must issue on / before Jan 18\");");
        _oJavascriptHolder.AppendLine("			cobj.value=\"\";");
        _oJavascriptHolder.AppendLine("			tobj.value=\"\";");
        _oJavascriptHolder.AppendLine("		}");
        _oJavascriptHolder.AppendLine("		");
        _oJavascriptHolder.AppendLine("		if (cobj.value==\"2004191\" && document.getElementById(\"form1\").sku.value!=\"2401971\" && document.getElementById(\"form1\").sku.value!=\"2401981\" && document.getElementById(\"form1\").sku.value!=\"2402441\" && document.getElementById(\"form1\").sku.value!=\"2402451\" ){");
        _oJavascriptHolder.AppendLine("			alert(\"Must select HS E65!\");");
        _oJavascriptHolder.AppendLine("			cobj.value=\"\";");
        _oJavascriptHolder.AppendLine("			tobj.value=\"\";");
        _oJavascriptHolder.AppendLine("		}");
        _oJavascriptHolder.AppendLine("	}	");
        _oJavascriptHolder.AppendLine("	else");
        _oJavascriptHolder.AppendLine("		cobj.value=\"\";");
        _oJavascriptHolder.AppendLine("}");
        _oJavascriptHolder.AppendLine("</script>");

        ch_g_code_holder.Text = _oJavascriptHolder.ToScript();
    }
    #endregion

    #region ch_g_type
    public void ch_g_type()
    {
        JavascriptHolder _oJavascriptHolder = new JavascriptHolder(this.Page);
        _oJavascriptHolder.AppendLine("<script>");
        _oJavascriptHolder.AppendLine("function ch_g_type(tobj,tval){");
        _oJavascriptHolder.AppendLine("	var gift_gp=\"\";");
        _oJavascriptHolder.AppendLine("	var gift_gp2=\"\";");
        _oJavascriptHolder.AppendLine("	var gift_gp3=\"\";");
        _oJavascriptHolder.AppendLine("	var gift_gp4=\"\";");
        _oJavascriptHolder.AppendLine("	var gift_dup=\"\";");

        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch("select distinct gift_code,gift_gp from " + Configurator.MSSQLTablePrefix + "GiftBasket with (nolock) where active=1 ");
        while (_oDr.Read())
        {
            _oJavascriptHolder.AppendLine("		if (document.getElementById(\"form1\").gift_code.value==\"" + Func.FR(_oDr["gift_code"]) + "\" )");
            _oJavascriptHolder.AppendLine("			gift_gp=\"" + Func.FR(_oDr["gift_gp"]) + "\";");
            _oJavascriptHolder.AppendLine("		if (document.getElementById(\"form1\").gift_code2.value==\"" + Func.FR(_oDr["gift_code"]) + "\" )");
            _oJavascriptHolder.AppendLine("			gift_gp2=\"" + Func.FR(_oDr["gift_gp"]) + "\";");
            _oJavascriptHolder.AppendLine("		if (document.getElementById(\"form1\").gift_code3.value==\"" + Func.FR(_oDr["gift_code"]) + "\" )");
            _oJavascriptHolder.AppendLine("			gift_gp3=\"" + Func.FR(_oDr["gift_gp"]) + "\";");
            _oJavascriptHolder.AppendLine("		if (document.getElementById(\"form1\").gift_code4.value==\"" + Func.FR(_oDr["gift_code"]) + "\" )");
            _oJavascriptHolder.AppendLine("			gift_gp4=\"" + Func.FR(_oDr["gift_gp"]) + "\";");
        }
        _oDr.Close();
        _oDr.Dispose();
        _oDr = null;
        _oJavascriptHolder.AppendLine("	");
        _oJavascriptHolder.AppendLine("if ((((tobj.value!=\"\" && document.getElementById(\"form1\").gift_code.value!=\"\" && tobj.value==document.getElementById(\"form1\").gift_code.value) || (gift_gp!=\"\" && gift_gp2!=\"\" && gift_gp==gift_gp2) || (gift_gp!=\"\" && gift_gp3!=\"\" && gift_gp==gift_gp3) || (gift_gp!=\"\" && gift_gp4!=\"\" && gift_gp==gift_gp4)) && tval!=\"1\") || (((tobj.value!=\"\" && document.getElementById(\"form1\").gift_code2.value!=\"\" && tobj.value==document.getElementById(\"form1\").gift_code2.value) || (gift_gp2!=\"\" && gift_gp!=\"\" && gift_gp2==gift_gp) || (gift_gp2!=\"\" && gift_gp3!=\"\" && gift_gp2==gift_gp3) || (gift_gp2!=\"\" && gift_gp4!=\"\" && gift_gp2==gift_gp4)) && tval!=\"2\") || (((tobj.value!=\"\" && document.getElementById(\"form1\").gift_code3.value!=\"\" && tobj.value==document.getElementById(\"form1\").gift_code3.value) || (gift_gp3!=\"\" && gift_gp!=\"\" && gift_gp3==gift_gp) || (gift_gp3!=\"\" && gift_gp2!=\"\" && gift_gp3==gift_gp2) || (gift_gp3!=\"\" && gift_gp4!=\"\" && gift_gp3==gift_gp4)) && tval!=\"3\") || (((tobj.value!=\"\" && document.getElementById(\"form1\").gift_code4.value!=\"\" && tobj.value==document.getElementById(\"form1\").gift_code4.value) || (gift_gp4!=\"\" && gift_gp!=\"\" && gift_gp4==gift_gp) || (gift_gp4!=\"\" && gift_gp2!=\"\" && gift_gp4==gift_gp2) || (gift_gp4!=\"\" && gift_gp3!=\"\" && gift_gp4==gift_gp3)) && tval!=\"4\"))");
        _oJavascriptHolder.AppendLine("		gift_dup=tval");
        _oJavascriptHolder.AppendLine("	");
        _oJavascriptHolder.AppendLine("	if (gift_dup==\"1\"){");
        _oJavascriptHolder.AppendLine("	    var flag=true;");
        _oJavascriptHolder.AppendLine("		if(document.getElementById(\"form1\").gift_desc1.options[document.getElementById(\"form1\").gift_desc1.selectedIndex].value==\"SAMSUNG-HANDSOME-MOVIE EXCHANGE COUPON\"){");
        _oJavascriptHolder.AppendLine("		    flag=false;");
        _oJavascriptHolder.AppendLine("		}");
        _oJavascriptHolder.AppendLine("	    if(flag){");
        _oJavascriptHolder.AppendLine("			alert (\"不能同時兩份相同型號的禮品!!\");");
        _oJavascriptHolder.AppendLine("			document.getElementById(\"form1\").gift_desc.value=\"\";");
        _oJavascriptHolder.AppendLine("			document.getElementById(\"form1\").gift_code.value=\"\";");
        _oJavascriptHolder.AppendLine("			if(document.getElementById(\"form1\").gift_desc1.options.length>0){");
        _oJavascriptHolder.AppendLine("			document.getElementById(\"form1\").gift_desc1.options[0].selected = true");
        _oJavascriptHolder.AppendLine("			}");
        _oJavascriptHolder.AppendLine("		}");
        _oJavascriptHolder.AppendLine("	}");
        _oJavascriptHolder.AppendLine("	else if (gift_dup==\"2\"){");
        _oJavascriptHolder.AppendLine("	    var flag=true;");
        _oJavascriptHolder.AppendLine("		if(document.getElementById(\"form1\").gift_desc21.options[document.getElementById(\"form1\").gift_desc21.selectedIndex].value==\"SAMSUNG-HANDSOME-MOVIE EXCHANGE COUPON\"){");
        _oJavascriptHolder.AppendLine("		    flag=false;");
        _oJavascriptHolder.AppendLine("		}");
        _oJavascriptHolder.AppendLine("		");
        _oJavascriptHolder.AppendLine("		if(flag){");
        _oJavascriptHolder.AppendLine("			alert (\"不能同時兩份相同型號的禮品!!\");");
        _oJavascriptHolder.AppendLine("			document.getElementById(\"form1\").gift_desc2.value=\"\";");
        _oJavascriptHolder.AppendLine("			document.getElementById(\"form1\").gift_code2.value=\"\";");
        _oJavascriptHolder.AppendLine("			if(document.getElementById(\"form1\").gift_desc21.options.length>0){");
        _oJavascriptHolder.AppendLine("			document.getElementById(\"form1\").gift_desc21.options[0].selected = true");
        _oJavascriptHolder.AppendLine("			}");
        _oJavascriptHolder.AppendLine("		}");
        _oJavascriptHolder.AppendLine("	}");
        _oJavascriptHolder.AppendLine("	else if (gift_dup==\"3\"){");
        _oJavascriptHolder.AppendLine("	    var flag=true;");
        _oJavascriptHolder.AppendLine("		if(document.getElementById(\"form1\").gift_desc31.options[document.getElementById(\"form1\").gift_desc31.selectedIndex].value==\"SAMSUNG-HANDSOME-MOVIE EXCHANGE COUPON\"){");
        _oJavascriptHolder.AppendLine("		    flag=false;");
        _oJavascriptHolder.AppendLine("		}");
        _oJavascriptHolder.AppendLine("		if(flag){");
        _oJavascriptHolder.AppendLine("			alert (\"不能同時兩份相同型號的禮品!!\");");
        _oJavascriptHolder.AppendLine("			document.getElementById(\"form1\").gift_desc3.value=\"\";");
        _oJavascriptHolder.AppendLine("			document.getElementById(\"form1\").gift_code3.value=\"\";");
        _oJavascriptHolder.AppendLine("			if(document.getElementById(\"form1\").gift_desc31.options.length>0){");
        _oJavascriptHolder.AppendLine("			document.getElementById(\"form1\").gift_desc31.options[0].selected = true");
        _oJavascriptHolder.AppendLine("			}");
        _oJavascriptHolder.AppendLine("		}");
        _oJavascriptHolder.AppendLine("	}");
        _oJavascriptHolder.AppendLine("	else if (gift_dup==\"4\"){");
        _oJavascriptHolder.AppendLine("	    var flag=true;");
        _oJavascriptHolder.AppendLine("		if(document.getElementById(\"form1\").gift_desc41.options[document.getElementById(\"form1\").gift_desc41.selectedIndex].value==\"SAMSUNG-HANDSOME-MOVIE EXCHANGE COUPON\"){");
        _oJavascriptHolder.AppendLine("		    flag=false;");
        _oJavascriptHolder.AppendLine("		}");
        _oJavascriptHolder.AppendLine("		if(flag){");
        _oJavascriptHolder.AppendLine("			alert (\"不能同時兩份相同型號的禮品!!\");");
        _oJavascriptHolder.AppendLine("			document.getElementById(\"form1\").gift_desc4.value=\"\";");
        _oJavascriptHolder.AppendLine("			document.getElementById(\"form1\").gift_code4.value=\"\";");
        _oJavascriptHolder.AppendLine("			if(document.getElementById(\"form1\").gift_desc41.options.length>0){");
        _oJavascriptHolder.AppendLine("			document.getElementById(\"form1\").gift_desc41.options[0].selected = true");
        _oJavascriptHolder.AppendLine("			}");
        _oJavascriptHolder.AppendLine("		}");
        _oJavascriptHolder.AppendLine("	}");


        _oJavascriptHolder.AppendLine("}");
        _oJavascriptHolder.AppendLine("</script>");

        ch_g_type_holder.Text = _oJavascriptHolder.ToScript();
    }
    #endregion

    #region ch_a_code
    public void ch_a_code()
    {
        JavascriptHolder _oJavascriptHolder = new JavascriptHolder(this.Page);
        _oJavascriptHolder.AppendLine("<script>");
        _oJavascriptHolder.AppendLine("function ch_a_code(tobj){");
        _oJavascriptHolder.AppendLine("if (tobj.value!=\"\"){");
        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch("select distinct accessory_code,accessory_desc,accessory_price from " + Configurator.MSSQLTablePrefix + "Accessory with (nolock) where active=1");
        while (_oDr.Read())
        {
            _oJavascriptHolder.AppendLine("			if (tobj.value==\"" + Func.FR(_oDr["accessory_desc"]) + "\" ){");
            _oJavascriptHolder.AppendLine("				document.getElementById(\"form1\").accessory_code.value=\"" + Func.FR(_oDr["accessory_code"]) + "\";");
            _oJavascriptHolder.AppendLine("				document.getElementById(\"form1\").accessory_price.value=\"" + Func.FR(_oDr["accessory_price"]) + "\";");
            _oJavascriptHolder.AppendLine("			}");
        }
        _oDr.Close();
        _oDr.Dispose();
        _oDr = null;
        _oJavascriptHolder.AppendLine("	}");
        _oJavascriptHolder.AppendLine("	else{");
        _oJavascriptHolder.AppendLine("		document.getElementById(\"form1\").accessory_code.value=\"\";");
        _oJavascriptHolder.AppendLine("		document.getElementById(\"form1\").accessory_price.value=\"0\";");
        _oJavascriptHolder.AppendLine("	}");
        _oJavascriptHolder.AppendLine("add_amount();");

        //For Lenovo
        _oJavascriptHolder.AppendLine("var AccessoryDescDrpObj= document.getElementById(\"accessory_desc1\");");
        _oJavascriptHolder.AppendLine("var RatePlanObj = document.getElementById(\"rate_plan\");");
        _oJavascriptHolder.AppendLine("var AccessoryPriceObj = document.getElementById(\"accessory_price\");");
        _oJavascriptHolder.AppendLine("if(AccessoryDescDrpObj!=undefined && RatePlanObj!=undefined){");
        _oJavascriptHolder.AppendLine("var AccessoryDescValue = AccessoryDescDrpObj.options[AccessoryDescDrpObj.selectedIndex].value;");
        _oJavascriptHolder.AppendLine("var RatePlanValue = RatePlanObj.options[RatePlanObj.selectedIndex].value;");
        _oJavascriptHolder.AppendLine("if ((AccessoryDescValue == \"LENOVO S10-2 (6 CELL/BLACK COLOR/EN XP HOME)\" || AccessoryDescValue == \"LENOVO S10-2 (6 CELL/BLACK COLOR/TC XP HOME)\") && (RatePlanValue== \"3GHSDPA0328A-(NB)MOB\" || RatePlanValue== \"3GHSDPA0328A-(NB)NET\"  || RatePlanValue == \"3GHSDPA0358A-(NB)\")) {");
        _oJavascriptHolder.AppendLine("AccessoryPriceObj.value=2499;");
        _oJavascriptHolder.AppendLine("}	");
        _oJavascriptHolder.AppendLine("if ((AccessoryDescValue == \"LENOVO S10-2 (6 CELL/BLACK COLOR/EN XP HOME)\" || AccessoryDescValue== \"LENOVO S10-2 (6 CELL/BLACK COLOR/TC XP HOME)\") && RatePlanValue== \"3GHSDPA0328A-(NB)RET\") {");
        _oJavascriptHolder.AppendLine("AccessoryPriceObj.value=2000;");
        _oJavascriptHolder.AppendLine("}");
        _oJavascriptHolder.AppendLine("}");

        //_oJavascriptHolder.AppendLine("		document.getElementById(\"form1\").total_amount.value=parseFloat(document.getElementById(\"form1\").accessory_price.value)+parseFloat(document.getElementById(\"form1\").amount.value);");
        _oJavascriptHolder.AppendLine("}");
        _oJavascriptHolder.AppendLine("</script>");

        ch_a_code_holder.Text = _oJavascriptHolder.ToScript();
    }
    #endregion

    #region wr
    public void wr(string x_sObj)
    {
        Response.Write(x_sObj);
        Response.Write("\n");
    }
    #endregion

    #region AjaxVas
    public void ajaxvas()
    {
        int _iTotalShow = 0;

        string _sNormal_rebate_type = normal_rebate_type.SelectedValue;
        string _sBundleName = bundle_name.SelectedValue;
        string _sRate_plan = ((rate_plan.Items.Count > 0) ? rate_plan.SelectedValue.ToString() : string.Empty);
        string _sProgram = ((program.Items.Count > 0) ? program.SelectedValue.ToString() : string.Empty);
        string _sHs_model = ((hs_model.Items.Count > 0) ? hs_model.SelectedValue.ToString() : string.Empty);
        List<string> _sVas_name = new List<string>();
        c_vas();

        Hashtable _oBundle = RWLFramework.Control<BundleMappingPropertyControler>().Get_VasfieldList(_sNormal_rebate_type, _sProgram, _sBundleName, _sRate_plan, _sHs_model, issue_type.Value.ToString());
        IDictionaryEnumerator _oItem = _oBundle.GetEnumerator();
        while (_oItem.MoveNext())
        {

            //HtmlVas
            SetHtmlControlAtt(_oItem.Key.ToString().Trim(), HtmlTextWriterAttribute.Disabled, "false", false);

            //HtmlVas
            SetHtmlControlAtt(_oItem.Key.ToString().Trim() + "1", HtmlTextWriterAttribute.Disabled, "false", false);

            if (!"".Equals(_oItem.Key.ToString()))
            {
                _iTotalShow += 1;
                SetHtmlControlStyle(_oItem.Key.ToString().Trim() + "2", HtmlTextWriterStyle.Display, "inline", true);
            }

            if (n_oVasShowList.ContainsKey(_oItem.Key.ToString().Trim()))
                n_oVasShowList[_oItem.Key.ToString().Trim()] = true;
        }

        foreach (KeyValuePair<string, bool> _oVasItem in n_oVasShowList)
        {
            string _sVas_field = _oVasItem.Key.ToString().Trim();
            if (n_oVasShowList.ContainsKey(_sVas_field))
            {
                if (n_oVasShowList[_sVas_field] == false)
                {
                    SetSelectHtmlControlSelectedIndex(_sVas_field, 0);
                }
            }
        }

        if (program.SelectedValue == string.Empty)
            giftheight.Height = "0";
        else
            giftheight.Height = (_iTotalShow * 35.2).ToString();
    }
    #endregion

    #region Set HtmlControl Style By Javascript
    public string SetHtmlControlStyle(string x_sID, HtmlTextWriterStyle x_oStyle, string x_sValue, bool x_bStr, bool x_bIncludeScript, bool x_bRunRegister)
    {
        Random ran = new Random();
        string _sScript = string.Empty;
        if (x_bStr)
            _sScript = string.Format("if(ChkID('{0}')){1}GetID('{2}').style.{3}='{4}';{5}", x_sID, "{", x_sID, x_oStyle.ToString().ToLower(), x_sValue, "}");
        else
            _sScript = string.Format("if(ChkID('{0}')){1}GetID('{2}').style.{3}={4};{5}", x_sID, "{", x_sID, x_oStyle.ToString().ToLower(), x_sValue, "}");

        if (x_bIncludeScript) _sScript = "<script>" + _sScript + "</script>";
        if (x_bRunRegister)
            ScriptManager.RegisterStartupScript(this, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), _sScript, false);
        else
            RegisterJSScript.AppendLine(_sScript);
        return _sScript;
    }

    public string SetHtmlControlStyle(string x_sID, HtmlTextWriterStyle x_oStyle, string x_sValue, bool x_bStr)
    {
        return SetHtmlControlStyle(x_sID, x_oStyle, x_sValue, x_bStr, false, false);
    }
    #endregion

    #region Set HtmlContorl Attributes By Javascript

    public string SetHtmlControlAtt(string x_sID, HtmlTextWriterAttribute x_oAtt, string x_sValue, bool x_bStr, bool x_bIncludeScript, bool x_bRunRegister)
    {
        string _sScript = string.Empty;
        if (x_oAtt == HtmlTextWriterAttribute.Class)
            _sScript = string.Format("if(ChkID('{0}')){1}GetID('{2}').className='{3}';{4}", x_sID, "{", x_sID, x_sValue, "}");
        else
        {
            if (x_bStr)
                _sScript = string.Format("if(ChkID('{0}')){1}GetID('{2}').{3}='{4}';{5}", x_sID, "{", x_sID, x_oAtt.ToString().ToLower(), x_sValue, "}");
            else
                _sScript = string.Format("if(ChkID('{0}')){1}GetID('{2}').{3}={4};{5}", x_sID, "{", x_sID, x_oAtt.ToString().ToLower(), x_sValue, "}");
        }

        if (x_bIncludeScript) _sScript = "<script>" + _sScript + "</script>";
        if (x_bRunRegister)
            ScriptManager.RegisterStartupScript(this, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), _sScript, false);
        else
            RegisterJSScript.AppendLine(_sScript);

        return _sScript;
    }

    public string SetHtmlControlAtt(string x_sID, HtmlTextWriterAttribute x_oAtt, string x_sValue, bool x_bStr)
    {
        return SetHtmlControlAtt(x_sID, x_oAtt, x_sValue, x_bStr, false, false);
    }
    #endregion

    #region Set HtmlContorl Value By Javascript
    public string SetHtmlControlValue(string x_sID, string x_sValue, bool x_bStr, bool x_bIncludeScript, bool x_bRunRegister)
    {
        string _sScript = string.Empty;
        if (x_bStr)
            _sScript = string.Format("if(ChkID('{0}')){1}GetID('{2}').value='{3}';{4}", x_sID, "{", x_sID, x_sValue, "}");
        else
            _sScript = string.Format("if(ChkID('{0}')){1}GetID('{2}').value={3};{4}", x_sID, "{", x_sID, x_sValue, "}");

        if (x_bIncludeScript) _sScript = "<script>" + _sScript + "</script>";
        if (x_bRunRegister)
            ScriptManager.RegisterStartupScript(this, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), _sScript, false);
        else
            RegisterJSScript.AppendLine(_sScript);

        return _sScript;
    }

    public string SetSelectHtmlControlSelectedIndex(string x_sID, int x_iSel)
    {
        return SetSelectHtmlControlSelectedIndex(x_sID, x_iSel, false);
    }

    public string SetSelectHtmlControlSelectedIndex(string x_sID, int x_iSel, bool x_bRunRegister)
    {
        string _sScript = string.Empty;
        _sScript = string.Format("if(ChkID('{0}'))GetID('{1}').selectedIndex={2};", x_sID, x_sID, x_iSel.ToString());

        if (x_bRunRegister)
            ScriptManager.RegisterStartupScript(this, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), _sScript, false);
        else
            RegisterJSScript.AppendLine(_sScript);

        return _sScript;
    }

    public string SetHtmlControlValue(string x_sID, string x_sValue, bool x_bStr)
    {
        return SetHtmlControlValue(x_sID, x_sValue, x_bStr, false, false);
    }
    #endregion

    #region Run Javascript Function
    public string RunJavascriptFunc(string x_sFunc, bool x_bIncludeScript, bool x_bRunRegister)
    {
        string _sFunc = ((x_sFunc.IndexOf(';') > 0) ? x_sFunc : x_sFunc + ";");
        if (x_bIncludeScript) _sFunc = "<script>" + _sFunc + "</script>";
        if (x_bRunRegister)
            ScriptManager.RegisterStartupScript(this, this.GetType(), x_sFunc + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), _sFunc, false);
        else
            RegisterJSScript.AppendLine(_sFunc);
        return _sFunc;
    }


    public string RunJavascriptFunc(string x_sFunc)
    {
        return RunJavascriptFunc(x_sFunc, false, false);
    }
    #endregion

    #region RegisterJavaScript
    protected void RegisterJavaScript(string x_sID, string x_sScript, bool x_bIncludeScript)
    {
        if (x_bIncludeScript) x_sScript = "<script>" + x_sScript + "</script>";
        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), x_sScript, false);
    }
    #endregion

    #region RegisterAsyncPostBackControl
    public void RegisterAsyncPostBackControl()
    {
        AddWebLogScriptManager.RegisterAsyncPostBackControl(action_required);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(action_required2);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(program);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(normal_rebate_type);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(rate_plan);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(plan_fee);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(con_per);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(rebate);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(free_mon);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(hs_model);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(premium);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(s_premium);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(s_premium1);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(s_premium2);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(s_premium3);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(s_premium4);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(trade_field);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(bundle_name);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(rebate_amount4);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(r_offer4);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(extra_rebate_amount4);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(extra_rebate4);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(gift_desc1);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(gift_desc21);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(gift_desc31);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(gift_desc41);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(accessory_desc1);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(accessory_waive);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(aig_gift);

        AddWebLogScriptManager.RegisterAsyncPostBackControl(d_time);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(pay_method);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(bank_code);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(exist_cust_plan);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(easywatch_type);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(hs_offer_type_id);

        AddWebLogScriptManager.RegisterAsyncPostBackControl(sim_item_name1);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(CopyRegisterAddToDeliveryAdd);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(pool);
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

    protected MSSQLConnect GetCRMDB()
    {
        MSSQLConnect _oDB = new MSSQLConnect();
        _oDB.SetConnStr(Configurator.DBName.CRM + ((Configurator.IsUat()) ? "2" : string.Empty));
        _oDB.bWithNoLock = true;
        return _oDB;
    }
    #endregion

    #region Get Oracle DB
    protected ODBCConnect GetORDB()
    {
        ODBCConnect _oDB = new ODBCConnect();
        _oDB.SetConnStr(Configurator.DBName.ORADNS);
        return _oDB;
    }
    #endregion

    #region Get Oracle DB For Sim Card
    protected ODBCConnect GetSimORDB()
    {
        ODBCConnect _oDB = new ODBCConnect();
        _oDB.SetConnStr(Configurator.DBName.ORADNS + ((Configurator.IsUat()) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion

    #region ItemsValueContains To Upper
    public bool ItemsValueContains(ListItemCollection x_oItemList, ListItem x_oItem)
    {
        if (x_oItemList == null) return false;
        if (x_oItemList.Count == 0) return false;
        if (x_oItem == null) return false;
        for (int i = 0; i < x_oItemList.Count; i++)
        {
            if (x_oItemList[i].Value.ToString().ToUpper().Trim() == x_oItem.Value.ToString().Trim().ToUpper())
                return true;
        }
        return false;
    }
    #endregion

    #region DropListSelectedValue
    public void DropListSelectedValue(ref DropDownList x_oDrp, string x_sValue)
    {
        DropListSelectedValue(ref x_oDrp, x_sValue, true);
    }
    public void DropListSelectedValue(ref DropDownList x_oDrp, string x_sValue, bool x_bMustSelect)
    {
        bool _bFlag = false;
        for (int i = 0; i < x_oDrp.Items.Count; i++)
        {
            if (x_oDrp.Items[i].Value.ToUpper().Trim() == x_sValue.ToUpper().Trim())
            {
                x_oDrp.SelectedIndex = i;
                x_oDrp.SelectedValue = x_sValue;
                _bFlag = true;
            }
        }

        if (x_bMustSelect && !_bFlag && !x_sValue.Trim().Equals(string.Empty))
        {
            x_oDrp.Items.Add(new ListItem(x_sValue, x_sValue));
            x_oDrp.SelectedValue = x_sValue;
        }
    }
    #endregion

    #region RadioListSelectedValue
    public void RadioListSelectedValue(ref RadioButtonList x_oDrp, string x_sText,string x_sValue)
    {
        RadioListSelectedValue(ref x_oDrp,x_sText, x_sValue, true);
    }
    public void RadioListSelectedValue(ref RadioButtonList x_oDrp, string x_sText, string x_sValue, bool x_bMustSelect)
    {
        bool _bFlag = false;
        for (int i = 0; i < x_oDrp.Items.Count; i++)
        {
            if (x_oDrp.Items[i].Value.ToUpper().Trim() == x_sValue.ToUpper().Trim())
            {
                x_oDrp.SelectedIndex = i;
                x_oDrp.SelectedValue = x_sValue;
                _bFlag = true;
            }
        }

        if (x_bMustSelect && !_bFlag && !x_sValue.Trim().Equals(string.Empty) && !x_sText.Equals(string.Empty))
        {
            x_oDrp.Items.Add(new ListItem(x_sText, x_sValue));
            x_oDrp.SelectedValue = x_sValue;
        }
    }
    #endregion

    #region HtmlDropSelectedValue
    public void HtmlDropSelectedValue(ref HtmlSelect x_oDrp, string x_sValue)
    {
        for (int i = 0; i < x_oDrp.Items.Count; i++)
        {
            if (x_oDrp.Items[i].Value.ToUpper().Trim() == x_sValue.ToUpper().Trim())
            {
                x_oDrp.SelectedIndex = i;
            }

        }
    }
    #endregion

    #region FlagInit
    public void FlagInit(MobileRetentionOrder x_oMobileRetentionOrder)
    {

        #region flag
        if (_iCon_flag == 0 && _iDeli_flag == 0)
        {
            program_flag.Text = x_oMobileRetentionOrder.GetProgram();
            normal_rebate_type_flag.Text = x_oMobileRetentionOrder.GetNormal_rebate_type();

            rate_plan_flag.Text = x_oMobileRetentionOrder.GetRate_plan();
            con_per_flag.Text = x_oMobileRetentionOrder.GetCon_per();
            rebate_flag.Text = x_oMobileRetentionOrder.GetRebate();
            free_mon_flag.Text = x_oMobileRetentionOrder.GetFree_mon();
            hs_model_flag.Text = x_oMobileRetentionOrder.GetHs_model();

            program_flag.Visible = true;
            normal_rebate_type_flag.Visible = true;
            rate_plan_flag.Visible = true;
            con_per_flag.Visible = true;
            rebate_flag.Visible = true;
            free_mon_flag.Visible = true;
            hs_model_flag.Visible = true;

        }
        else
        {
            program_flag.Visible = false;
            normal_rebate_type_flag.Visible = false;
            rate_plan_flag.Visible = false;
            con_per_flag.Visible = false;
            rebate_flag.Visible = false;
            free_mon_flag.Visible = false;
            hs_model_flag.Visible = false;
        }

        if (_iCon_flag == 0)
        {
            trade_field_flag.Text = x_oMobileRetentionOrder.GetTrade_field();
            bundle_name_flag.Text = x_oMobileRetentionOrder.GetBundle_name();
            if (x_oMobileRetentionOrder.GetCon_eff_date() != null)
                con_eff_date_flag.Text = ((DateTime)x_oMobileRetentionOrder.GetCon_eff_date()).ToString("dd/MM/yyyy");
            if (x_oMobileRetentionOrder.GetNext_bill() != null)
            {
                if ((bool)x_oMobileRetentionOrder.GetNext_bill())
                    SetHtmlControlStyle("next_bill_label", HtmlTextWriterStyle.Display, "inline", true);
                else
                    SetHtmlControlStyle("next_bill_label", HtmlTextWriterStyle.Display, "none", true);
            }
            else
                SetHtmlControlStyle("next_bill_label", HtmlTextWriterStyle.Display, "inline", true);

            plan_eff_flag.Text = x_oMobileRetentionOrder.GetPlan_eff();

            trade_field_flag.Visible = true;
            bundle_name_flag.Visible = true;
            con_eff_date_flag.Visible = true;
            plan_eff_flag.Visible = true;
        }
        else
        {
            trade_field_flag.Visible = false;
            bundle_name_flag.Visible = false;
            con_eff_date_flag.Visible = false;
            plan_eff_flag.Visible = false;
        }


        if (_iDeli_flag == 0)
        {
            hs_model_flag.Text = x_oMobileRetentionOrder.GetHs_model();
            premium_flag.Text = x_oMobileRetentionOrder.GetPremium();
            d_address_flag.Text = x_oMobileRetentionOrder.GetD_address();
            d_date_flag.Text = ((DateTime)x_oMobileRetentionOrder.GetD_date()).ToString("dd/MM/yyyy");
            d_time_flag.Text = x_oMobileRetentionOrder.GetD_time();
            extra_d_charge_flag.Text = x_oMobileRetentionOrder.GetExtra_d_charge();
            contact_person_flag.Text = x_oMobileRetentionOrder.GetContact_person();
            contact_no_flag.Text = x_oMobileRetentionOrder.GetContact_no();
            pay_method_flag.Text = x_oMobileRetentionOrder.GetPay_method();
            card_type_flag.Text = x_oMobileRetentionOrder.GetCard_type();
            card_holder_flag.Text = x_oMobileRetentionOrder.GetCard_holder();
            card_exp_month_flag.Text = x_oMobileRetentionOrder.GetCard_exp_month();
            card_exp_year_flag.Text = x_oMobileRetentionOrder.GetCard_exp_year();
            bank_code_flag.Text = x_oMobileRetentionOrder.GetBank_code();

            sim_item_name_flag.Text = x_oMobileRetentionOrder.GetSim_item_name();
            sim_item_code_flag.Text = x_oMobileRetentionOrder.GetSim_item_code();
            sim_item_number_flag.Text = MobileRetentionOrderBal.GetSim_Number(x_oMobileRetentionOrder);
        }
        else
        {
            hs_model_flag.Visible = false;
            premium_flag.Visible = false;
            d_address_flag.Visible = false;
            d_date_flag.Visible = false;
            d_time_flag.Visible = false;
            extra_d_charge_flag.Visible = false;
            contact_person_flag.Visible = false;
            contact_no_flag.Visible = false;
            pay_method_flag.Visible = false;
            card_type_flag.Visible = false;
            card_holder_flag.Visible = false;
            card_exp_month_flag.Visible = false;
            card_exp_year_flag.Visible = false;
            bank_code_flag.Visible = false;

            sim_item_name_flag.Visible = false;
            sim_item_code_flag.Visible = false;
            sim_item_number_flag.Visible = false;
        }
        #endregion


    }
    #endregion

    #region InitGoWireLessControl
    protected void InitGoWireLessControl(MobileRetentionOrder x_oMobileRetentionOrder)
    {
        org_go_wireless.Value = x_oMobileRetentionOrder.GetGo_wireless();
        if (x_oMobileRetentionOrder.GetSim_mrt_no() == null || _iDeli_flag == 0)
            go_wireless.Enabled = false;

        if (x_oMobileRetentionOrder.GetSim_mrt_no() == null || _iDeli_flag == 0)
            release_sim_mrt.Visible = false;

        if (x_oMobileRetentionOrder.GetSim_mrt_no() != null || Func.IsInt(x_oMobileRetentionOrder.GetSim_mrt_no()))
            sim_mrt.Value = Convert.ToInt32(x_oMobileRetentionOrder.GetSim_mrt_no()).ToString();

        if (string.IsNullOrEmpty(x_oMobileRetentionOrder.GetPreferred_languages()))
            preferred_languages.Enabled = false;
        else
        {
            preferred_languages.Enabled = true;
            try
            {
                preferred_languages.SelectedValue = x_oMobileRetentionOrder.GetPreferred_languages().ToUpper();
            }
            catch
            {
                RegisterJSScript.AppendLine("alert('preferred_languages SelectedValue ERROR!');");
            }
        }


        if (n_sISSUE_TYPE == "GO_WIRELESS")
            register_address.Value = x_oMobileRetentionOrder.GetRegister_address();
        else
            register_address.Disabled = true;

    }
    #endregion

    #region RetrieveRecord
    public void RetrieveRecord()
    {
        MobileRetentionOrder _oMobileRetentionOrder = x_oMobileRetentionOrder;
        if (!_oMobileRetentionOrder.Retrieve()) return;
        FlagInit(_oMobileRetentionOrder);
        issue_type.Value = _oMobileRetentionOrder.GetIssue_type();
        SetHtmlControlValue("issue_type", _oMobileRetentionOrder.GetIssue_type(), true);
        RegisteredBillingAddress3rdPartyFormView(issue_type.Value);
        
        string _sPlan_fee = ((plan_fee.Items.Count > 0) ? plan_fee.SelectedValue.ToString() : string.Empty);
        
        string _sNormal_rebate_type = normal_rebate_type.SelectedValue;
        _sPlan_fee = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar("SELECT top 1 plan_fee FROM RetentionPlan WITH (NOLOCK) WHERE plan_code='" + _oMobileRetentionOrder.GetRate_plan() + "'  AND active=1");
        iphone_concierge_order.Value = FromRegisterControler.IsIPhoneConciergeHandSet(_oMobileRetentionOrder.GetSku()) == true ? "1" : "";

        //edf_status
        if (RWLFramework.CurrentUser[this.Page].Lv.ToString() == "65535")
        {
            edf_status.Attributes[HtmlTextWriterAttribute.Onclick.ToString()] = "window.open('EDFmanagement.aspx?edf_no=" + _oMobileRetentionOrder.GetEdf_no() + "','_blank','toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=yes, copyhistory=no, width=500, height=620');";
            edf_status.Visible = true;
        }
        else
            edf_status.Visible = false;



        //log_date
        if (_oMobileRetentionOrder.GetLog_date() != null) log_date.Value = ((DateTime)_oMobileRetentionOrder.GetLog_date()).ToString("dd/MM/yyyy HH:mm");

        //language
        if (!string.IsNullOrEmpty(_oMobileRetentionOrder.GetLanguage())) language.Value = _oMobileRetentionOrder.GetLanguage();

        //cust_type
        HtmlDropSelectedValue(ref cust_type, _oMobileRetentionOrder.GetCust_type());
        if (_oMobileRetentionOrder.GetMrt_no() != null)
        {
            string _sMobileLevelDesc = string.Empty;
            IQueryable<BusinessTradeEntity> _oRwlTradeBaseList = FromRegisterControler.Get_ProgramList(((int)_oMobileRetentionOrder.GetMrt_no()).ToString(), ref _sMobileLevelDesc);
            if (!string.IsNullOrEmpty(_sMobileLevelDesc))
            {
                cust_type.Items.Add(new ListItem(_sMobileLevelDesc.Trim(), _sMobileLevelDesc.Trim()));
                if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetCust_type()))
                {
                    cust_type.Value = _sMobileLevelDesc.Trim();
                }
            }
        }

        //family_name
        family_name.Value = _oMobileRetentionOrder.GetFamily_name();

        //given_name
        given_name.Value = _oMobileRetentionOrder.GetGiven_name();

        if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetGiven_name().Trim()) &&
            string.IsNullOrEmpty(_oMobileRetentionOrder.GetFamily_name().Trim()))
        {
            given_name.Value = _oMobileRetentionOrder.GetCust_name().Trim();
        }

        //cust_name
        cust_name.Value = _oMobileRetentionOrder.GetCust_name();

        //gender
        gender.Value = _oMobileRetentionOrder.GetGender();

        //date_of_birth
        if (_oMobileRetentionOrder.GetDate_of_birth() != null) date_of_birth.Text = ((DateTime)_oMobileRetentionOrder.GetDate_of_birth()).ToString("dd/MM/yyyy");


        //ac_no
        ac_no.Value = _oMobileRetentionOrder.GetAc_no();

        //mrt_no
        mrt_no.Value = _oMobileRetentionOrder.GetMrt_no().ToString();

        //exist_cust_plan
        DropListSelectedValue(ref exist_cust_plan, _oMobileRetentionOrder.GetExist_cust_plan());
        exist_cust_plan_changed();

        //org_fee
        DropListSelectedValue(ref org_fee, _oMobileRetentionOrder.GetOrg_fee());

        //id_type
        HtmlDropSelectedValue(ref id_type, _oMobileRetentionOrder.GetId_type());
        if (_oMobileRetentionOrder.GetProgram() != null)
        {
            //if ("EASYWATCH BUNDLE".Equals(_oMobileRetentionOrder.GetProgram().Trim().ToUpper()))
                //id_type.Visible = false;
        }
        id_type1.Value = _oMobileRetentionOrder.GetId_type();
        //if (_oMobileRetentionOrder.GetProgram() != "EASYWATCH BUNDLE")
            //id_type1.Visible = false;


        //hkid
        hkid.Value = (_oMobileRetentionOrder.GetHkid().Length >= 8) ? _oMobileRetentionOrder.GetHkid().Substring(0, _oMobileRetentionOrder.GetHkid().Length - 1) : _oMobileRetentionOrder.GetHkid();
        if (_oMobileRetentionOrder.GetProgram() == "EASYWATCH BUNDLE")
        {
            hkid.Disabled = true;
        }
        //hkid2
        hkid2.Value = (_oMobileRetentionOrder.GetHkid().Length >= 8) ? _oMobileRetentionOrder.GetHkid().Substring(_oMobileRetentionOrder.GetHkid().Length - 1) : string.Empty;
		//hidden hkid for check iphne concierge service
        hidden_hkid.Value = _oMobileRetentionOrder.GetHkid();

        //vip_case
        vip_case.Text = _oMobileRetentionOrder.GetVip_case().Trim();
        if (RWLFramework.CurrentUser[this.Page].Lv.ToString() == "10" || RWLFramework.CurrentUser[this.Page].Lv.ToString() == "30" || RWLFramework.CurrentUser[this.Page].Lv.ToString() == "65535")
        {
            //vip_case.ReadOnly = true;
        }

        //special_handling_dummy_code
        special_handling_dummy_code.Text = _oMobileRetentionOrder.GetSpecial_handling_dummy_code().Trim();
        //sms_mrt
        sms_mrt.Value = _oMobileRetentionOrder.GetSms_mrt();

        //waive
        if (_oMobileRetentionOrder.GetWaive() != null)
        {
            if ((bool)_oMobileRetentionOrder.GetWaive())
                waive.SelectedIndex = 0;
            else
                waive.SelectedIndex = 1;
        }


        //org_ftg
        if (_oMobileRetentionOrder.GetOrg_ftg() == "ftg")
            org_ftg.Checked = true;
        else
            org_ftg.Checked = false;

        if (!string.IsNullOrEmpty(_oMobileRetentionOrder.GetExisting_contract_end_date()))
        {
            if (_oMobileRetentionOrder.GetExisting_contract_end_date().IndexOf("/") > 0)
            {
                string[] existing_contract = _oMobileRetentionOrder.GetExisting_contract_end_date().Split(("/")[0]);
                if (existing_contract.Length > 1)
                    HtmlDropSelectedValue(ref existing_contract_end_month, existing_contract[0]);
                if (existing_contract.Length > 1)
                    HtmlDropSelectedValue(ref existing_contract_end_year, existing_contract[1]);
            }
        }

        //action_required
        if (_oMobileRetentionOrder.GetAction_required() == "suspend")
        {
            action_required.Checked = true;
            SetHtmlControlAtt("action_required", HtmlTextWriterAttribute.Checked, "true", false);
            RegisterJSScript.AppendLine("en_action()");
            RegisterJSScript.AppendLine("c_all()");
        }
        else
            action_required.Checked = false;

        //action_required2
        if (_oMobileRetentionOrder.GetAction_required() == "opt_out")
        {
            action_required2.Checked = true;
            SetHtmlControlAtt("action_required2", HtmlTextWriterAttribute.Checked, "true", false);
            RegisterJSScript.AppendLine("en_action()");
            RegisterJSScript.AppendLine("c_all()");
        }
        else
            action_required2.Checked = false;

        //action_eff_date
        if (_oMobileRetentionOrder.GetAction_eff_date() != null)
            SetHtmlControlValue("action_eff_date", ((DateTime)_oMobileRetentionOrder.GetAction_eff_date()).ToString("dd/MM/yyyy"), true);

        //exist_plan
        if (!string.IsNullOrEmpty(_oMobileRetentionOrder.GetExist_plan()))
        {
            exist_plan.Text = _oMobileRetentionOrder.GetExist_plan();
        }

        //reasons
        for (int i = 0; i < reasons.Items.Count; i++)
        {
            if (_oMobileRetentionOrder.GetReasons().Trim().ToLower().IndexOf(reasons.Items[i].ToString().Trim().ToLower()) >= 0 &&
                _oMobileRetentionOrder.GetReasons().Trim().ToLower() == reasons.Items[i].ToString().Trim().ToLower())
                reasons.Items[i].Selected = true;
            else
                reasons.Items[i].Selected = false;
        }

        //program
        DropListSelectedValue(ref program, _oMobileRetentionOrder.GetProgram());

        //for add modify and  modify with no check and modify page
        if (program.SelectedValue == "GO WIRELESS")
            SetHtmlControlStyle("go_wireless_show", HtmlTextWriterStyle.Display, "inline", true);
        else
            SetHtmlControlStyle("go_wireless_show", HtmlTextWriterStyle.Display, "none", true);


        if (_iCon_flag == 0 && _iDeli_flag == 0)
        {
            SetHtmlControlStyle("program", HtmlTextWriterStyle.Display, "none", true);
        }
        else
        {
            SetHtmlControlStyle("program", HtmlTextWriterStyle.Display, "inline", true);
        }

        //cust_staff_no
        cust_staff_no.Value = _oMobileRetentionOrder.GetCust_staff_no();
        //hidden_cust_staff_no for id checking for staff offer
        hidden_cust_staff_no.Value = _oMobileRetentionOrder.GetCust_staff_no();
        if (!string.IsNullOrEmpty(hidden_cust_staff_no.Value))
        {
            string _sStaffNoCust = hidden_cust_staff_no.Value.ToUpper().Trim("A"[0]).Trim("B"[0]).Trim("C"[0]).Trim("E"[0]).Trim("F"[0]).Trim("G"[0]).Trim("H"[0]).Trim("I"[0]).Trim("J"[0]).Trim("K"[0]).Trim("L"[0]).Trim("M"[0]).Trim("N"[0]).Trim("O"[0]).Trim("P"[0]).Trim("Q"[0]).Trim("R"[0]).Trim("S"[0]).Trim("T"[0]).Trim("U"[0]).Trim("V"[0]).Trim("W"[0]).Trim("X"[0]).Trim("Y"[0]).Trim("Z"[0]);
            int _iCustStaffNo;
            if (int.TryParse(_sStaffNoCust, out _iCustStaffNo))
            {
                SetHtmlControlStyle("check_cust_no_result", HtmlTextWriterStyle.Display, "inline", true);
                if ((_iCustStaffNo >= 0000703 && _iCustStaffNo <= 1164813) || (_iCustStaffNo >= 8030041 && _iCustStaffNo <= 8177230) || (_iCustStaffNo >= 9014200 && _iCustStaffNo <= 9280470))
                {
                    SetHtmlControlStyle("check_cust_no_result_over", HtmlTextWriterStyle.Display, "inline", true);
                    SetHtmlControlStyle("check_cust_no_result_below", HtmlTextWriterStyle.Display, "none", true);
                }
                else
                {
                    SetHtmlControlStyle("check_cust_no_result_over", HtmlTextWriterStyle.Display, "none", true);
                    SetHtmlControlStyle("check_cust_no_result_below", HtmlTextWriterStyle.Display, "inline", true);
                }
            }
        }
        //tr_easywatch
        if (_oMobileRetentionOrder.GetProgram() != "EASYWATCH BUNDLE")
            SetHtmlControlStyle("easywatch_type_show", HtmlTextWriterStyle.Display, "none", true);
        else
            SetHtmlControlStyle("easywatch_type_show", HtmlTextWriterStyle.Display, "inline", true);

        for (int i = 0; i < easywatch_type.Items.Count; i++)
        {
            if (_oMobileRetentionOrder.GetEasywatch_type() == easywatch_type.Items[i].Value)
                easywatch_type.Items[i].Selected = true;
        }

        //easywatch_ord_id
        easywatch_ord_id.Value = _oMobileRetentionOrder.GetEasywatch_ord_id();

        //check_easy_id
        if (_oMobileRetentionOrder.GetEasywatch_type() == "EASYWATCH BUNDLE")
            check_easy_id.Value = "true";
        else
            check_easy_id.Value = "false";


        //staff_off_sn
        if (!"STAFF OFFER".Equals(program.SelectedValue) &&
         !"STAFF REFERRAL".Equals(program.SelectedValue) &&
         !"STAFF OFFER (CONCIERGE SERVICE) ".Equals(program.SelectedValue) &&
         !"STAFF (IPAD CON SER)".Equals(program.SelectedValue) &&
         !"STAFF (IPHONE CON SER)".Equals(program.SelectedValue) &&
         !"STAFF (IPHONE REBATE)".Equals(program.SelectedValue) &&
         !"STAFF (QUALITY LOB)".Equals(program.SelectedValue) &&
         !"STAFF (SMARTPHONE HS)".Equals(program.SelectedValue) &&
         !"STAFF (SMARTPHONE REBATE)".Equals(program.SelectedValue) &&
         !"STAFF (WEB & TALK +)".Equals(program.SelectedValue) &&
         !"STAFF (CONCIERGE SERVICE)".Equals(program.SelectedValue) &&
         !"STAFF (IPHONE REBATE)".Equals(program.SelectedValue) &&
         !"STAFF (MASS)".Equals(program.SelectedValue) && 
         !"STAFF (SMARTPHONE HS)".Equals(program.SelectedValue) &&
         !"STAFF (SMARTPHONE REBATE)".Equals(program.SelectedValue) &&
         !"STAFF (SPEC PROMOTION)".Equals(program.SelectedValue) &&
         !"STAFF (SPEC PROMOTION)".Equals(program.SelectedValue) &&
         !"STAFF (SPECIAL 2ND HS)".Equals(program.SelectedValue) &&
         !"STAFF (SPECIAL 2ND IPHONE)".Equals(program.SelectedValue) &&
         !"STAFF (WEB & TALK)".Equals(program.SelectedValue)) 
            SetHtmlControlStyle("cust_staff_no_show", HtmlTextWriterStyle.Display, "none", true);
        else
            SetHtmlControlStyle("cust_staff_no_show", HtmlTextWriterStyle.Display, "inline", true);

        //normal_rebate_type
        DropListSelectedValue(ref normal_rebate_type, _oMobileRetentionOrder.GetNormal_rebate_type());

        if (_iCon_flag == 0 && _iDeli_flag == 0)
            SetHtmlControlStyle("normal_rebate_type", HtmlTextWriterStyle.Display, "none", true);
        else
            SetHtmlControlStyle("normal_rebate_type", HtmlTextWriterStyle.Display, "inline", true);

        //rate_plan
        c_rate_plan();
        rate_plan.Items.Add(new ListItem(_oMobileRetentionOrder.GetRate_plan(), _oMobileRetentionOrder.GetRate_plan()));
        DropListSelectedValue(ref rate_plan, _oMobileRetentionOrder.GetRate_plan());
        if (_iCon_flag == 0 && _iDeli_flag == 0)
            SetHtmlControlStyle("rate_plan", HtmlTextWriterStyle.Display, "none", true);
        else
            SetHtmlControlStyle("rate_plan", HtmlTextWriterStyle.Display, "inline", true);

        //show_plan_fee
        if (_oMobileRetentionOrder.GetRate_plan() != "3GHSDPA0488A")
            SetHtmlControlStyle("show_plan_fee", HtmlTextWriterStyle.Display, "none", true);
        else
            SetHtmlControlStyle("show_plan_fee", HtmlTextWriterStyle.Display, "inline", true);


        //plan_fee
        string _sPlanFee = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar("SELECT plan_fee FROM " + Configurator.MSSQLTablePrefix + "RetentionPlan WITH (NOLOCK) WHERE active=1 AND plan_code='" + _oMobileRetentionOrder.GetRate_plan().Trim() + "'");


        c_plan_fee();
        plan_fee.Items.Add(new ListItem(_sPlanFee, _sPlanFee));
        DropListSelectedValue(ref plan_fee, _sPlanFee);


        //special_approval
        if (_oMobileRetentionOrder.GetSpecial_approval() == "Y")
            special_approval.Items[0].Selected = true;
        else
            special_approval.Items[1].Selected = true;

        //accept
        if (_oMobileRetentionOrder.GetAccept() == "no_comment")
            accept_1.Checked = true;
        else
            accept_0.Checked = false;

        if (_oMobileRetentionOrder.GetAccept().Trim() == "Y")
            accept_0.Checked = true;
        else
            accept_1.Checked = true;

        if (_oMobileRetentionOrder.GetRate_plan() != "3GFTRIAL0098A" && _oMobileRetentionOrder.GetRate_plan() != "3GFTRIAL0198A" && _oMobileRetentionOrder.GetRate_plan() != "3GFTRIAL0298A")
        {
            accept_0.Disabled = true;
            accept_1.Disabled = true;
        }
        else
        {
            accept_0.Disabled = false;
            accept_1.Disabled = false;
        }

        //con_per
        c_con_per();
        con_per.Items.Add(new ListItem(_oMobileRetentionOrder.GetCon_per(), _oMobileRetentionOrder.GetCon_per()));
        DropListSelectedValue(ref con_per, _oMobileRetentionOrder.GetCon_per());

        if (_iCon_flag == 0 && _iDeli_flag == 0 && !_oMobileRetentionOrder.GetHs_model().Equals("PCCW-SONY ERI K530i THUNDER BK (256MB CARD)") && !_oMobileRetentionOrder.GetHs_model().Equals("PCCW-SONY ERI K530i WARM SL (256MB CARD)"))
        {
            SetHtmlControlStyle("con_per", HtmlTextWriterStyle.Display, "none", true);
        }
        else
        {
            SetHtmlControlStyle("con_per", HtmlTextWriterStyle.Display, "inline", true);
        }

        //c_rebate
        c_rebate();
        rebate.Items.Add(new ListItem(_oMobileRetentionOrder.GetRebate(), _oMobileRetentionOrder.GetRebate()));
        DropListSelectedValue(ref rebate, _oMobileRetentionOrder.GetRebate());

        if (_iCon_flag == 0 && _iDeli_flag == 0)
        {
            SetHtmlControlStyle("rebate", HtmlTextWriterStyle.Display, "none", true);
        }
        else
        {
            SetHtmlControlStyle("rebate", HtmlTextWriterStyle.Display, "inline", true);
        }

        //free_mon
        c_free_mon();
        free_mon.Items.Add(new ListItem(_oMobileRetentionOrder.GetFree_mon(), _oMobileRetentionOrder.GetFree_mon()));
        DropListSelectedValue(ref free_mon, _oMobileRetentionOrder.GetFree_mon());

        if (_iCon_flag == 0 && _iDeli_flag == 0)
        {
            SetHtmlControlStyle("free_mon", HtmlTextWriterStyle.Display, "none", true);
        }
        else
        {
            SetHtmlControlStyle("free_mon", HtmlTextWriterStyle.Display, "inline", true);
        }

        //lob
        if (_oMobileRetentionOrder.GetNormal_rebate() != null)
        {
            if ((bool)_oMobileRetentionOrder.GetNormal_rebate())
            {
                lob.CssClass = "disablerow";
                lob.Enabled = false;
            }
            else
                lob.CssClass = "highlightrow";
        }
        else
            lob.CssClass = "highlightrow";

        DropListSelectedValue(ref lob, _oMobileRetentionOrder.GetLob());


        //lob_ac
        if (_oMobileRetentionOrder.GetNormal_rebate() != null)
        {
            if ((bool)_oMobileRetentionOrder.GetNormal_rebate())
            {
                RegisterJSScript.AppendLine("document.getElementById('form1').lob_ac.className='disablerow';");
                //SetHtmlControlAtt("lob_ac", HtmlTextWriterAttribute.Class, "disablerow", true);
                SetHtmlControlAtt("lob_ac", HtmlTextWriterAttribute.Disabled, "true", false);
            }
            else
            {
                RegisterJSScript.AppendLine("document.getElementById('form1').lob_ac.className='highlightrow';");
                //SetHtmlControlAtt("lob_ac", HtmlTextWriterAttribute.Class, "highlightrow", true);
            }
        }
        else
        {
            RegisterJSScript.AppendLine("document.getElementById('form1').lob_ac.className='highlightrow';");
            //SetHtmlControlAtt("lob_ac", HtmlTextWriterAttribute.Class, "highlightrow", true);
        }
        lob_ac.Value = _oMobileRetentionOrder.GetLob_ac();

        //pcd_paid_go_wireless
        if (_oMobileRetentionOrder.GetPcd_paid_go_wireless() != null)
            pcd_paid_go_wireless.Checked = (bool)_oMobileRetentionOrder.GetPcd_paid_go_wireless();
        else
            pcd_paid_go_wireless.Checked = false;

        //go_wireless_package_code
        if (!string.IsNullOrEmpty(_oMobileRetentionOrder.GetGo_wireless_package_code()))
            go_wireless_package_code.Value = _oMobileRetentionOrder.GetGo_wireless_package_code();

        //sim_item_name, sim_item_code, sim_item_number
        if (issue_type.Value == "MOBILE_LITE" || issue_type.Value == "3G_RETENTION" || issue_type.Value == "2G_RETENTION")
        {
            SetHtmlControlStyle("sim_show", HtmlTextWriterStyle.Display, "none", true);
        }
        else
        {
            SetHtmlControlStyle("sim_show", HtmlTextWriterStyle.Display, "inline", true);

            sim_item_name1.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            sim_item_number.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            sim_item_code.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
        }

        sim_item_name.Value = _oMobileRetentionOrder.GetSim_item_name();
        sim_item_name1.SelectedValue = _oMobileRetentionOrder.GetSim_item_code();
        sim_item_code.Text = _oMobileRetentionOrder.GetSim_item_code();
        sim_item_number.Text = MobileRetentionOrderBal.GetSim_Number(_oMobileRetentionOrder);

        //hs_model
        c_hs_model();

        List<string> _oHandSetList = RWLFramework.Control<HandSetEnvironment>().Get_DrpHandSetList(_oMobileRetentionOrder.GetProgram(), _oMobileRetentionOrder.GetCon_per(), _oMobileRetentionOrder.GetRate_plan(), _sPlan_fee, _oMobileRetentionOrder.GetNormal_rebate_type(), _oMobileRetentionOrder.GetChannel());
        for (int i = 0; i < _oHandSetList.Count; i++)
        {
            if (!(_oHandSetList[i].ToString() == "ASUS EEE PC 900-W009X 12GB/XP/PEARL WHITE/CHI" && _oMobileRetentionOrder.GetChannel() == "OB" && _oMobileRetentionOrder.GetCon_per()== "24"))
            {
                hs_model.Items.Add(new ListItem(_oHandSetList[i].ToString().ToUpper(), _oHandSetList[i].ToString().ToUpper()));
            }
        }

        DropListSelectedValue(ref hs_model, _oMobileRetentionOrder.GetHs_model());

        if (!_oMobileRetentionOrder.GetPremium().Equals(string.Empty) && !_oMobileRetentionOrder.GetPremium().Equals("WELLCOME COUPON $800"))
        {

            hs_model.Enabled = false;
        }
        else
        {
            hs_model.Enabled = true;

        }

        if (_iDeli_flag == 0)
        {
            SetHtmlControlStyle("hs_model", HtmlTextWriterStyle.Display, "none", true);
        }
        else
        {
            SetHtmlControlStyle("hs_model", HtmlTextWriterStyle.Display, "inline", true);
        }

        HandSetEnvironment _oHandSetEnvironment = new HandSetEnvironment();

        //premium
        c_premium();
        List<string> _oPremiumList = _oHandSetEnvironment.Get_DrpPremiumList(_oMobileRetentionOrder.GetCon_per(), _oMobileRetentionOrder.GetRate_plan(), ((_oMobileRetentionOrder.GetNormal_rebate() != null) ? (bool)_oMobileRetentionOrder.GetNormal_rebate() : false), _oMobileRetentionOrder.GetProgram());
        for (int i = 0; i < _oPremiumList.Count; i++)
            premium.Items.Add(new ListItem(_oPremiumList[i].ToString(), _oPremiumList[i].ToString()));

        DropListSelectedValue(ref premium, _oMobileRetentionOrder.GetPremium());

        if (_iDeli_flag == 0)
        {
            SetHtmlControlStyle("premium", HtmlTextWriterStyle.Display, "none", true);
        }
        else
        {
            SetHtmlControlStyle("premium", HtmlTextWriterStyle.Display, "inline", true);
        }

        //sku
        sku.Value = _oMobileRetentionOrder.GetSku();

        //imei_no
        imei_no.Value = _oMobileRetentionOrder.GetImei_no();
        imei_no.Attributes["readonly"] = "true";

        //Spremium
        c_s_premium();
        List<string> _oSpecialPremiumList = _oHandSetEnvironment.GetSPremiumList(_oMobileRetentionOrder.GetCon_per(), _oMobileRetentionOrder.GetRate_plan());
        for (int i = 0; i < _oSpecialPremiumList.Count; i++)
            s_premium.Items.Add(new ListItem(_oSpecialPremiumList[i].ToString(), _oSpecialPremiumList[i].ToString()));

        DropListSelectedValue(ref s_premium, _oMobileRetentionOrder.GetS_premium());

        //sp_d_date
        if (_oMobileRetentionOrder.GetSp_d_date() != null)
            if (Func.IsParseDateTime(((DateTime)_oMobileRetentionOrder.GetSp_d_date()).ToString())) SetHtmlControlValue("sp_d_date", ((DateTime)_oMobileRetentionOrder.GetSp_d_date()).ToString("dd/MM/yyyy"), true);

        //sp_ref_no
        SetHtmlControlValue("sp_ref_no", _oMobileRetentionOrder.GetSp_ref_no(), true);
        //pos_ref_no
        SetHtmlControlValue("pos_ref_no", _oMobileRetentionOrder.GetPos_ref_no(), true);


        //s_premium1
        c_SpecialPremium1();
        s_premium1.Items.Add(new ListItem(_oMobileRetentionOrder.GetS_premium1(), _oMobileRetentionOrder.GetS_premium1()));
        List<string> _oSpecialPremium1List = _oHandSetEnvironment.Get_SPremiumTypeHs();
        for (int i = 0; i < _oSpecialPremium1List.Count; i++)
            s_premium1.Items.Add(new ListItem(_oSpecialPremium1List[i].ToString(), _oSpecialPremium1List[i].ToString()));
        DropListSelectedValue(ref s_premium1, _oMobileRetentionOrder.GetS_premium1());

        //s_premium2
        c_SpecialPremium2();
        s_premium2.Items.Add(new ListItem(_oMobileRetentionOrder.GetS_premium2(), _oMobileRetentionOrder.GetS_premium2()));
        List<string> _oSpecialPremium2List = _oHandSetEnvironment.Get_SPremiumTypeHs();
        for (int i = 0; i < _oSpecialPremium2List.Count; i++)
            s_premium2.Items.Add(new ListItem(_oSpecialPremium2List[i].ToString(), _oSpecialPremium2List[i].ToString()));
        DropListSelectedValue(ref s_premium2, _oMobileRetentionOrder.GetS_premium2());

        //s_premium3
        c_SpecialPremium3();
        s_premium3.Items.Add(new ListItem(_oMobileRetentionOrder.GetS_premium3(), _oMobileRetentionOrder.GetS_premium3()));
        List<string> _oSpecialPremium3List = _oHandSetEnvironment.Get_SPremiumTypeHs();
        for (int i = 0; i < _oSpecialPremium3List.Count; i++)
            s_premium3.Items.Add(new ListItem(_oSpecialPremium3List[i].ToString(), _oSpecialPremium3List[i].ToString()));
        DropListSelectedValue(ref s_premium3, _oMobileRetentionOrder.GetS_premium3());


        //s_premium4
        c_SpecialPremium4();
        s_premium4.Items.Add(new ListItem(_oMobileRetentionOrder.GetS_premium4(), _oMobileRetentionOrder.GetS_premium4()));
        List<string> _oSpecialPremium4List = _oHandSetEnvironment.Get_SPremiumTypeHs();
        for (int i = 0; i < _oSpecialPremium4List.Count; i++)
            s_premium4.Items.Add(new ListItem(_oSpecialPremium4List[i].ToString(), _oSpecialPremium4List[i].ToString()));
        DropListSelectedValue(ref s_premium4, _oMobileRetentionOrder.GetS_premium4());

        DropListSelectedValue(ref s_premium2, _oMobileRetentionOrder.GetS_premium2());

        //redemption_notice_option
        SetHtmlControlValue("redemption_notice_option", _oMobileRetentionOrder.GetRedemption_notice_option(), true);
        RegisterJSScript.AppendLine("PresetSPreimum2PreviousValue('" + _oMobileRetentionOrder.GetS_premium2() + "')");
        if (!string.IsNullOrEmpty(_oMobileRetentionOrder.GetRedemption_notice_option()))
        {
            SetHtmlControlAtt("redemption_notice_option", HtmlTextWriterAttribute.Disabled, "false", false);
        }
        //trade_field
        c_trade_field();
        trade_field.Items.Add(new ListItem(_oMobileRetentionOrder.GetTrade_field(), _oMobileRetentionOrder.GetTrade_field()));
        DropListSelectedValue(ref trade_field, _oMobileRetentionOrder.GetTrade_field());

        if (_iCon_flag == 0)
        {
            SetHtmlControlStyle("trade_field", HtmlTextWriterStyle.Display, "none", true);
        }
        else
        {
            SetHtmlControlStyle("trade_field", HtmlTextWriterStyle.Display, "inline", true);
        }

        //old_trade_field
        old_trade_field.Value = _oMobileRetentionOrder.GetTrade_field();

        //bundle_name
        c_bundle_name();
        bundle_name.Items.Add(new ListItem(_oMobileRetentionOrder.GetBundle_name(), _oMobileRetentionOrder.GetBundle_name()));
        DropListSelectedValue(ref bundle_name, _oMobileRetentionOrder.GetBundle_name());

        if (_iCon_flag == 0)
        {
            SetHtmlControlStyle("bundle_name", HtmlTextWriterStyle.Display, "none", true);
        }
        else
        {
            SetHtmlControlStyle("bundle_name", HtmlTextWriterStyle.Display, "inline", true);
        }


        //old_bundle_name
        old_bundle_name.Value = _oMobileRetentionOrder.GetBundle_name();

        //hs_offer_type_id
        if (_oMobileRetentionOrder.GetHs_offer_type_id() != null)
            old_hs_offer_type_id.Value = ((int)_oMobileRetentionOrder.GetHs_offer_type_id()).ToString();

        if (_oMobileRetentionOrder.GetHs_offer_type_id() != null)
            DropListSelectedValue(ref hs_offer_type_id, ((int)_oMobileRetentionOrder.GetHs_offer_type_id()).ToString());

        //m_rebate_amount
        SetHtmlControlValue("m_rebate_amount", _oMobileRetentionOrder.GetM_rebate_amount(), true);

        //rebate_amount
        SetHtmlControlValue("rebate_amount", _oMobileRetentionOrder.GetRebate_amount(), true);

        //r_offer
        SetHtmlControlValue("r_offer", _oMobileRetentionOrder.GetR_offer(), true);

        //extra_rebate_amount
        SetHtmlControlValue("extra_rebate_amount", _oMobileRetentionOrder.GetExtra_rebate_amount(), true);

        //extra_rebate
        SetHtmlControlValue("extra_rebate", _oMobileRetentionOrder.GetExtra_rebate(), true);

        //cancel_renew
        if (_oMobileRetentionOrder.GetCancel_renew() == "Y")
            cancel_renew_0.Checked = true;
        else
            cancel_renew_1.Checked = true;

        ///////////////////////

        //gift_Desc
        gift_desc.Value = _oMobileRetentionOrder.GetGift_desc();



        gift_desc1.Items.Clear();
        gift_desc1.Items.Add(new ListItem(string.Empty, string.Empty));
        gift_desc21.Items.Clear();
        gift_desc21.Items.Add(new ListItem(string.Empty, string.Empty));
        gift_desc31.Items.Clear();
        gift_desc31.Items.Add(new ListItem(string.Empty, string.Empty));
        gift_desc41.Items.Clear();
        gift_desc41.Items.Add(new ListItem(string.Empty, string.Empty));

        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT distinct gift_desc FROM " + Configurator.MSSQLTablePrefix + "GiftBasket with (nolock) WHERE active=1 AND (edate is null or edate >getdate()-1) AND sdate<=getdate() ");
        while (_oDr.Read())
        {
            gift_desc1.Items.Add(new ListItem(_oDr[GiftBasket.Para.gift_desc].ToString(), _oDr[GiftBasket.Para.gift_desc].ToString()));
            gift_desc21.Items.Add(new ListItem(_oDr[GiftBasket.Para.gift_desc].ToString(), _oDr[GiftBasket.Para.gift_desc].ToString()));
            gift_desc31.Items.Add(new ListItem(_oDr[GiftBasket.Para.gift_desc].ToString(), _oDr[GiftBasket.Para.gift_desc].ToString()));
            gift_desc41.Items.Add(new ListItem(_oDr[GiftBasket.Para.gift_desc].ToString(), _oDr[GiftBasket.Para.gift_desc].ToString()));
        }
        _oDr.Close();
        _oDr.Dispose();

        //gift_desc1
        DropListSelectedValue(ref gift_desc1, _oMobileRetentionOrder.GetGift_desc());

        //gift_desc1
        if (_oMobileRetentionOrder.GetGift_code() != string.Empty || _oMobileRetentionOrder.GetHs_model().Equals(string.Empty) || _iDeli_flag == 0)
        {
            SetHtmlControlAtt("gift_desc1", HtmlTextWriterAttribute.Disabled, "true", false);
            SetHtmlControlAtt("gift_imei", HtmlTextWriterAttribute.Disabled, "true", false);
            gift_desc1.Enabled = false;
        }
        else
        {
            SetHtmlControlAtt("gift_desc1", HtmlTextWriterAttribute.Disabled, "false", false);
            SetHtmlControlAtt("gift_imei", HtmlTextWriterAttribute.Disabled, "false", false);
            gift_desc1.Enabled = false;
        }

        //gift_code
        gift_code.Value = _oMobileRetentionOrder.GetGift_code();

        //r_gift_imei
        if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetGift_code()) || _iDeli_flag == 0)
        {
            SetHtmlControlStyle("r_gift_imei", HtmlTextWriterStyle.Display, "none", true);
            r_gift_imei.Style[HtmlTextWriterStyle.Display] = "none";
            r_gift_imei.Disabled = true;
        }
        else
        {
            SetHtmlControlStyle("r_gift_imei", HtmlTextWriterStyle.Display, "inline", true);
            r_gift_imei.Style[HtmlTextWriterStyle.Display] = "inline";
            r_gift_imei.Disabled = false;
        }

        //get_gift_imei
        get_gift_imei.Attributes[HtmlTextWriterAttribute.Onclick.ToString()] = "check_gift(document.getElementById(\"form1\").gift_code.value,'gift_imei','gift_desc1','" + ((int)_oMobileRetentionOrder.GetOrder_id()).ToString() + "');";
        //SetHtmlControlAtt("get_gift_imei", HtmlTextWriterAttribute.Onclick, "check_gift(document.getElementById(\"form1\").gift_code.value,'gift_imei','gift_desc1','"+((int)_oMobileRetentionOrder.order_id).ToString()+"');", true);

        if (!string.IsNullOrEmpty(_oMobileRetentionOrder.GetGift_code()) || _iDeli_flag == 0)
        {
            SetHtmlControlStyle("get_gift_imei", HtmlTextWriterStyle.Display, "none", true);
            get_gift_imei.Style[HtmlTextWriterStyle.Display] = "none";
            get_gift_imei.Disabled = true;
        }
        else
        {
            SetHtmlControlStyle("get_gift_imei", HtmlTextWriterStyle.Display, "inline", true);
            get_gift_imei.Style[HtmlTextWriterStyle.Display] = "inline";
            get_gift_imei.Disabled = false;
        }

        gift_imei.Value = _oMobileRetentionOrder.GetGift_imei();
        ////////////////////



        ////////////////////

        //gift_desc2
        gift_desc2.Value = _oMobileRetentionOrder.GetGift_desc2();

        //gift_desc21
        DropListSelectedValue(ref gift_desc21, _oMobileRetentionOrder.GetGift_desc2());

        if (!string.IsNullOrEmpty(_oMobileRetentionOrder.GetGift_desc2()) || string.IsNullOrEmpty(_oMobileRetentionOrder.GetHs_model()) || _iDeli_flag == 0)
        {
            SetHtmlControlAtt("gift_desc21", HtmlTextWriterAttribute.Disabled, "true", false);
            SetHtmlControlAtt("gift_imei2", HtmlTextWriterAttribute.Disabled, "true", false);
            
            gift_desc21.Enabled = false;
        }
        else
        {
            SetHtmlControlAtt("gift_desc21", HtmlTextWriterAttribute.Disabled, "false", false);
            SetHtmlControlAtt("gift_imei2", HtmlTextWriterAttribute.Disabled, "false", false);
            gift_desc21.Enabled = true;
        }

        //gift_code2
        gift_code2.Value = _oMobileRetentionOrder.GetGift_code2();

        //r_gift_imei2
        if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetGift_code2()) || _iDeli_flag == 0)
        {
            SetHtmlControlStyle("r_gift_imei2", HtmlTextWriterStyle.Display, "none", true);
            r_gift_imei2.Style[HtmlTextWriterStyle.Display] = "none";
            r_gift_imei2.Disabled = true;
        }
        else
        {
            SetHtmlControlStyle("r_gift_imei2", HtmlTextWriterStyle.Display, "inline", true);
            r_gift_imei2.Style[HtmlTextWriterStyle.Display] = "inline";
            r_gift_imei2.Disabled = false;
        }

        //get_gift_imei2
        get_gift_imei2.Attributes[HtmlTextWriterAttribute.Onclick.ToString()] = "check_gift(document.getElementById(\"form1\").gift_code2.value,'gift_imei2','gift_desc21','" + ((int)_oMobileRetentionOrder.GetOrder_id()).ToString() + "');";
        //SetHtmlControlAtt("get_gift_imei2", HtmlTextWriterAttribute.Onclick, "check_gift(document.getElementById(\"form1\").gift_code2.value,'gift_imei2','gift_desc21','" + ((int)_oMobileRetentionOrder.GetOrder_id()).ToString() + "');", true);

        if (!string.IsNullOrEmpty(_oMobileRetentionOrder.GetGift_code2()) || _iDeli_flag == 0)
        {
            SetHtmlControlStyle("get_gift_imei2", HtmlTextWriterStyle.Display, "none", true);
            get_gift_imei2.Style[HtmlTextWriterStyle.Display] = "none";
            get_gift_imei2.Disabled = true;
        }
        else
        {
            SetHtmlControlStyle("get_gift_imei2", HtmlTextWriterStyle.Display, "inline", true);
            get_gift_imei2.Style[HtmlTextWriterStyle.Display] = "inline";
            get_gift_imei2.Disabled = false;
        }

        gift_imei2.Value = _oMobileRetentionOrder.GetGift_imei2();

        ////////////////////////////////////////////////////
        //gift_desc3
        gift_desc3.Value = _oMobileRetentionOrder.GetGift_desc3();

        DropListSelectedValue(ref gift_desc31, _oMobileRetentionOrder.GetGift_desc3());

        if (!string.IsNullOrEmpty(_oMobileRetentionOrder.GetGift_code3()) || string.IsNullOrEmpty(_oMobileRetentionOrder.GetHs_model()) || _iDeli_flag == 0)
        {
            SetHtmlControlAtt("gift_desc31", HtmlTextWriterAttribute.Disabled, "true", false);
            SetHtmlControlAtt("gift_imei3", HtmlTextWriterAttribute.Disabled, "true", false);
            
            gift_desc31.Enabled = false;
        }
        else
        {
            SetHtmlControlAtt("gift_desc31", HtmlTextWriterAttribute.Disabled, "false", false);
            SetHtmlControlAtt("gift_imei3", HtmlTextWriterAttribute.Disabled, "false", false);

            gift_desc31.Enabled = true;
        }

        //gift_code3
        gift_code3.Value = _oMobileRetentionOrder.GetGift_code3();
        if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetGift_code3()) || _iDeli_flag == 0)
        {
            SetHtmlControlStyle("r_gift_imei3", HtmlTextWriterStyle.Display, "none", true);
            r_gift_imei3.Style[HtmlTextWriterStyle.Display] = "none";
            r_gift_imei3.Disabled = true;
        }
        else
        {
            SetHtmlControlStyle("r_gift_imei3", HtmlTextWriterStyle.Display, "inline", true);
            r_gift_imei3.Style[HtmlTextWriterStyle.Display] = "inline";
            r_gift_imei3.Disabled = false;
        }


        //get_gift_imei3
        get_gift_imei3.Attributes[HtmlTextWriterAttribute.Onclick.ToString()] = "check_gift(document.getElementById(\"form1\").gift_code3.value,'gift_imei3','gift_desc31','" + ((int)_oMobileRetentionOrder.GetOrder_id()).ToString() + "');";
        //SetHtmlControlAtt("get_gift_imei3", HtmlTextWriterAttribute.Onclick, "check_gift(document.getElementById(\"form1\").gift_code3.value,'gift_imei3','gift_desc31','" + ((int)_oMobileRetentionOrder.GetOrder_id()).ToString() + "');", true);

        if (!string.IsNullOrEmpty(_oMobileRetentionOrder.GetGift_code3()) || _iDeli_flag == 0)
        {
            SetHtmlControlStyle("get_gift_imei3", HtmlTextWriterStyle.Display, "none", true);
            get_gift_imei3.Style[HtmlTextWriterStyle.Display] = "none";
            get_gift_imei3.Disabled = true;
        }
        else
        {
            SetHtmlControlStyle("get_gift_imei3", HtmlTextWriterStyle.Display, "inline", true);
            get_gift_imei3.Style[HtmlTextWriterStyle.Display] = "inline";
            get_gift_imei3.Disabled = false;
        }

        gift_imei3.Value = _oMobileRetentionOrder.GetGift_imei3();

        /////////////////////////////////


        //gift_desc4
        gift_desc4.Value = _oMobileRetentionOrder.GetGift_desc4();

        DropListSelectedValue(ref gift_desc41, _oMobileRetentionOrder.GetGift_desc4());

        if (!string.IsNullOrEmpty(_oMobileRetentionOrder.GetGift_code4()) || string.IsNullOrEmpty(_oMobileRetentionOrder.GetHs_model()) || _iDeli_flag == 0)
        {
            SetHtmlControlAtt("gift_desc41", HtmlTextWriterAttribute.Disabled, "true", false);
            SetHtmlControlAtt("gift_imei4", HtmlTextWriterAttribute.Disabled, "true", false);
            
            gift_desc41.Enabled = false;
        }
        else
        {
            SetHtmlControlAtt("gift_desc41", HtmlTextWriterAttribute.Disabled, "false", false);
            SetHtmlControlAtt("gift_imei4", HtmlTextWriterAttribute.Disabled, "false", false);
            gift_desc41.Enabled = true;
        }

        ///gift_code4
        gift_code4.Value = _oMobileRetentionOrder.GetGift_code4();

        if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetGift_code4()) || _iDeli_flag == 0)
        {
            SetHtmlControlStyle("r_gift_imei4", HtmlTextWriterStyle.Display, "none", true);
            r_gift_imei4.Style[HtmlTextWriterStyle.Display] = "none";
            r_gift_imei4.Disabled = true;
        }
        else
        {
            SetHtmlControlStyle("r_gift_imei4", HtmlTextWriterStyle.Display, "inline", true);
            r_gift_imei4.Style[HtmlTextWriterStyle.Display] = "inline";
            r_gift_imei4.Disabled = false;
        }


        //get_gift_imei4
        get_gift_imei4.Attributes[HtmlTextWriterAttribute.Onclick.ToString()] = "check_gift(document.getElementById(\"form1\").gift_code4.value,'gift_imei4','gift_desc41','" + ((int)_oMobileRetentionOrder.GetOrder_id()).ToString() + "');";
        //SetHtmlControlAtt("get_gift_imei4", HtmlTextWriterAttribute.Onclick, "check_gift(document.getElementById(\"form1\").gift_code4.value,'gift_imei4','gift_desc41','" + ((int)_oMobileRetentionOrder.GetOrder_id()).ToString() + "');", true);
        if (!string.IsNullOrEmpty(_oMobileRetentionOrder.GetGift_code4()) || _iDeli_flag == 0)
        {
            SetHtmlControlStyle("get_gift_imei4", HtmlTextWriterStyle.Display, "none", true);
            get_gift_imei4.Style[HtmlTextWriterStyle.Display] = "none";
            get_gift_imei4.Disabled = true;
        }
        else
        {
            SetHtmlControlStyle("get_gift_imei4", HtmlTextWriterStyle.Display, "inline", true);
            get_gift_imei4.Style[HtmlTextWriterStyle.Display] = "inline";
            get_gift_imei4.Disabled = false;
        }

        //gift_imei4
        gift_imei4.Value = _oMobileRetentionOrder.GetGift_imei4();

        /////////////////////////////
        //accessory_desc
        accessory_desc.Value = _oMobileRetentionOrder.GetAccessory_desc();

        //accessory_desc1
        if (!string.IsNullOrEmpty(_oMobileRetentionOrder.GetAccessory_code()) || string.IsNullOrEmpty(_oMobileRetentionOrder.GetHs_model()) || _iDeli_flag == 0)
        {
            SetHtmlControlAtt("accessory_desc1", HtmlTextWriterAttribute.Disabled, "true", false);
            accessory_desc1.Enabled = false;
        }
        else
        {
            SetHtmlControlAtt("accessory_desc1", HtmlTextWriterAttribute.Disabled, "false", false);
            accessory_desc1.Enabled = true;
        }


        _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch("select distinct accessory_desc from " + Configurator.MSSQLTablePrefix + "Accessory with (nolock) where active=1 and (edate is null or edate >getdate()-1) and sdate<=getdate() ");
        while (_oDr.Read())
        {
            accessory_desc1.Items.Add(new ListItem(_oDr["accessory_desc"].ToString(), _oDr["accessory_desc"].ToString()));

        }
        _oDr.Close();
        _oDr.Dispose();
        DropListSelectedValue(ref accessory_desc1, _oMobileRetentionOrder.GetAccessory_desc());



        //accessory_code
        accessory_code.Value = _oMobileRetentionOrder.GetAccessory_code();


        if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetAccessory_imei()) || _iDeli_flag == 0)
        {
            SetHtmlControlStyle("r_accessory_imei", HtmlTextWriterStyle.Display, "none", true);
            r_accessory_imei.Style[HtmlTextWriterStyle.Display]="none";
            r_accessory_imei.Disabled = true;
        }
        else
        {
            SetHtmlControlStyle("r_accessory_imei", HtmlTextWriterStyle.Display, "inline", true);
            r_accessory_imei.Style[HtmlTextWriterStyle.Display] = "inline";
            r_accessory_imei.Disabled = false;
        }


        //get_accessory_imei
        get_accessory_imei.Attributes[HtmlTextWriterAttribute.Onclick.ToString()] = "check_gift(document.getElementById('form1').accessory_code.value,'accessory_imei','accessory_desc1','" + ((int)_oMobileRetentionOrder.GetOrder_id()).ToString() + "');";

        //SetHtmlControlAtt("get_accessory_imei", HtmlTextWriterAttribute.Onclick, "check_gift(document.getElementById(\"form1\").gift_code4.value,'gift_imei4','gift_desc41','" + ((int)_oMobileRetentionOrder.GetOrder_id()).ToString() + "');", true);
        if (!string.IsNullOrEmpty(_oMobileRetentionOrder.GetGift_code4()))
            get_accessory_imei.Visible = false;
        else
            get_accessory_imei.Visible = true;

        if (!string.IsNullOrEmpty(_oMobileRetentionOrder.GetAccessory_imei()) || _iDeli_flag == 0)
        {
            SetHtmlControlStyle("get_accessory_imei", HtmlTextWriterStyle.Display, "none", true);
            get_accessory_imei.Style["get_accessory_imei"] = "none";
        }
        else
        {
            SetHtmlControlStyle("get_accessory_imei", HtmlTextWriterStyle.Display, "inline", true);
            get_accessory_imei.Style["get_accessory_imei"] = "inline";
        }

        //accessory_imei
        accessory_imei.Value = _oMobileRetentionOrder.GetAccessory_imei();
        //accessory_price
        accessory_price.Value = _oMobileRetentionOrder.GetAccessory_price();


        //aig_gift
        DropListSelectedValue(ref aig_gift, _oMobileRetentionOrder.GetAig_gift());

        
        ReloadDBVasSelected((int)_oMobileRetentionOrder.GetOrder_id());

        //vas_eff_date
        if (_oMobileRetentionOrder.GetVas_eff_date() != null)
        {
            if (Func.IsDateTime(_oMobileRetentionOrder.GetVas_eff_date()))
                vas_eff_date.Text = ((DateTime)_oMobileRetentionOrder.GetVas_eff_date()).ToString("dd/MM/yyyy");
        }

        //con_eff_date
        if (_oMobileRetentionOrder.GetCon_eff_date() != null)
        {
            if (Func.IsDateTime(_oMobileRetentionOrder.GetCon_eff_date()))
                con_eff_date.Value = ((DateTime)_oMobileRetentionOrder.GetCon_eff_date()).ToString("dd/MM/yyyy");
        }

        if (_iCon_flag == 0)
        {
            SetHtmlControlStyle("con_eff_date", HtmlTextWriterStyle.Display, "none", true);
        }
        else
        {
            SetHtmlControlStyle("con_eff_date", HtmlTextWriterStyle.Display, "inline", true);
        }

        //plan_eff_date
        if (_oMobileRetentionOrder.GetPlan_eff_date() != null)
        {
            //SetHtmlControlValue("plan_eff_date", ((DateTime)_oMobileRetentionOrder.GetPlan_eff_date()).ToString("dd/MM/yyyy"), true);
            plan_eff_date.Value = ((DateTime)_oMobileRetentionOrder.GetPlan_eff_date()).ToString("dd/MM/yyyy");
        }

        if (_oMobileRetentionOrder.GetPlan_eff() == "Next Bill Date")
        {
            /*
            SetHtmlControlAtt("plan_eff_date", HtmlTextWriterAttribute.Class, "disablerow", true);
            if (_oMobileRetentionOrder.GetPlan_eff_date() != null) SetHtmlControlAtt("plan_eff_date", HtmlTextWriterAttribute.Disabled, "true", false);
            */
            plan_eff_date.Attributes["class"] = "disablerow";
            if (_oMobileRetentionOrder.GetPlan_eff_date() != null) plan_eff_date.Disabled = true;
        }

        //bill_cut_date
        if (_oMobileRetentionOrder.GetBill_cut_date() != null)
            SetHtmlControlValue("bill_cut_date", ((DateTime)_oMobileRetentionOrder.GetBill_cut_date()).ToString("dd/MM/yyyy"), true);

        //bill_cut_num
        if (_oMobileRetentionOrder.GetBill_cut_num() != null)
        {
            HtmlDropSelectedValue(ref bill_cut_num, ((int)_oMobileRetentionOrder.GetBill_cut_num()).ToString());
            if (_oMobileRetentionOrder.GetBill_cut_date() == null)
                RegisterJSScript.AppendLine("AutoSetBillCutDate()");
        }

        if (_iCon_flag == 0)
        {
            SetHtmlControlStyle("plan_eff_date", HtmlTextWriterStyle.Display, "none", true);
        }
        else
        {
            SetHtmlControlStyle("plan_eff_date", HtmlTextWriterStyle.Display, "inline", true);
        }

        //plan_eff
        if (_oMobileRetentionOrder.GetPlan_eff().Trim() == "Next Bill Date")
            plan_eff.SelectedValue = "NBD";
        else
            plan_eff.SelectedValue = "OTHER";

        if (_iCon_flag == 0)
        {
            SetHtmlControlStyle("plan_eff", HtmlTextWriterStyle.Display, "none", true);
        }
        else
        {
            SetHtmlControlStyle("plan_eff", HtmlTextWriterStyle.Display, "inline", true);
        }

        //cooling_offer
        if (_oMobileRetentionOrder.GetCooling_offer() == "YES")
        {
            cooling_offer.Checked = true;
            RegisterJSScript.AppendLine("click_cooling()");
        }
        else
            cooling_offer.Checked = false;

        //cooling_date
        if (_oMobileRetentionOrder.GetCooling_date() != null)
            cooling_date.Value = Convert.ToDateTime(_oMobileRetentionOrder.GetCooling_date()).ToString("dd/MM/yyyy");

        //monthly_payment_type
        MonthPaymentMethodChange(program.SelectedValue, issue_type.Value, false);
        DropListSelectedValue(ref monthly_payment_type, _oMobileRetentionOrder.GetMonthly_payment_type());
        SetHtmlControlValue("monthly_payment_type", _oMobileRetentionOrder.GetMonthly_payment_type(), true);
        RegisterJSScript.Append("MonthlyPaymentTypeChange();");

        

        //m_card_type
        HtmlDropSelectedValue(ref m_card_type, _oMobileRetentionOrder.GetM_card_type());

        //m_card_no
        m_card_no.Text = _oMobileRetentionOrder.GetM_card_no().ToString();


        //change_payment_type
        if (_oMobileRetentionOrder.GetChange_payment_type().Trim().Equals("COD"))
        {
            change_payment_type_0.Checked = true;
            change_payment_type_1.Checked = false;
            change_payment_type_2.Checked = false;
            SetHtmlControlAtt("change_payment_type_0", HtmlTextWriterAttribute.Checked, "true", false);
            RegisterJSScript.AppendLine("ChangePaymentType('COD',true);");
            m_card_no.Enabled = false;
            m_card_no.CssClass = "m_card_no disablerow";
        }
        else if (_oMobileRetentionOrder.GetChange_payment_type().Trim().Equals("CREDIT CARD"))
        {
            change_payment_type_0.Checked = false;
            change_payment_type_1.Checked = true;
            change_payment_type_2.Checked = false;
            SetHtmlControlAtt("change_payment_type_1", HtmlTextWriterAttribute.Checked, "true", false);
            RegisterJSScript.AppendLine("ChangePaymentType('CREDIT CARD',false);");
            m_card_no.Enabled = true;
            m_card_no.CssClass = "m_card_no";
        }
        else if (_oMobileRetentionOrder.GetChange_payment_type().Trim().Equals("BANK ACCOUNT"))
        {
            change_payment_type_0.Checked = false;
            change_payment_type_1.Checked = false;
            change_payment_type_2.Checked = true;
            RegisterJSScript.AppendLine("ChangePaymentType('BANK ACCOUNT',false);");
            m_card_no.Enabled = false;
            m_card_no.CssClass = "m_card_no disablerow";
        }


        //m_card_holder2
        m_card_holder2.Value = _oMobileRetentionOrder.GetM_card_holder2();


        //m_card_exp_month
        HtmlDropSelectedValue(ref m_card_exp_month, _oMobileRetentionOrder.GetM_card_exp_month());

        //m_card_exp_year
        HtmlDropSelectedValue(ref m_card_exp_year, _oMobileRetentionOrder.GetM_card_exp_year());


        //ord_place_by
        ord_place_by.Value = _oMobileRetentionOrder.GetOrd_place_by();

        //ord_place_rel
        HtmlDropSelectedValue(ref ord_place_rel, _oMobileRetentionOrder.GetOrd_place_rel().Trim());

        //ord_place_id_type
        HtmlDropSelectedValue(ref ord_place_id_type, _oMobileRetentionOrder.GetOrd_place_id_type().Trim());


        //bank_code
        bank_code.Value = _oMobileRetentionOrder.GetBank_code();
        if (!string.IsNullOrEmpty(_oMobileRetentionOrder.GetBank_code()))
        {
            string _sInstallment_period = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar("SELECT Installment_period FROM " + Configurator.MSSQLTablePrefix + "BankCode WITH (NOLOCK) WHERE bank_code='" +_oMobileRetentionOrder.GetBank_code() + "' ");
            if (_sInstallment_period != string.Empty)
            {
                installment_period.Items.Add(new ListItem(_sInstallment_period, _sInstallment_period));
                installment_period.SelectedIndex = 0;
            }
        }
        //bank_name
        DropListSelectedValue(ref bank_name, _oMobileRetentionOrder.GetBank_name());
        if (!(_oMobileRetentionOrder.GetPay_method().Equals("CREDIT CARD") || _oMobileRetentionOrder.GetPay_method().Equals("CREDIT CARD INSTALLMENT")))
        {
            SetHtmlControlAtt("bank_name", HtmlTextWriterAttribute.Class, "disablerow", true);
            SetHtmlControlAtt("installment_period", HtmlTextWriterAttribute.Class, "disablerow", true);
            SetHtmlControlAtt("bank_code", HtmlTextWriterAttribute.Class, "disablerow", true);
            bank_name.Enabled = false;
        }
        else
        {
            SetHtmlControlAtt("bank_name", HtmlTextWriterAttribute.Class, "highlightrow", true);
            SetHtmlControlAtt("installment_period", HtmlTextWriterAttribute.Class, "highlightrow", true);
            SetHtmlControlAtt("bank_code", HtmlTextWriterAttribute.Class, "highlightrow", true);
        }

        if (_iDeli_flag == 0)
        {
            SetHtmlControlStyle("bank_name", HtmlTextWriterStyle.Display, "none", true);
            SetHtmlControlStyle("installment_period", HtmlTextWriterStyle.Display, "none", true);
            SetHtmlControlStyle("bank_code", HtmlTextWriterStyle.Display, "none", true);
        }
        else
        {
            SetHtmlControlStyle("bank_name", HtmlTextWriterStyle.Display, "inline", true);
            SetHtmlControlStyle("installment_period", HtmlTextWriterStyle.Display, "inline", true);
            SetHtmlControlStyle("bank_code", HtmlTextWriterStyle.Display, "inline", true);
        }

        RegisterJSScript.AppendLine("add_amount()");

        //ord_place_tel
        ord_place_tel.Value = _oMobileRetentionOrder.GetOrd_place_tel();

        //d_address
        d_address.Value = _oMobileRetentionOrder.GetD_address();
        if (_oMobileRetentionOrder.GetHs_model().Equals(string.Empty) && _oMobileRetentionOrder.GetSim_item_name().Trim() == string.Empty && _oMobileRetentionOrder.GetSim_item_name().Trim() == string.Empty && (_oMobileRetentionOrder.GetGo_wireless().Trim() == "NO" || _oMobileRetentionOrder.GetGo_wireless().Trim() == string.Empty))
        {
            SetHtmlControlAtt("d_address", HtmlTextWriterAttribute.Class, "disablerow", true);
            //SetHtmlControlAtt("d_address", HtmlTextWriterAttribute.Disabled, "true", false);
            d_address.Disabled = true;
        }
        else
        {
            SetHtmlControlAtt("d_address", HtmlTextWriterAttribute.Class, "highlightrow", true);
            d_address.Disabled = false;
        }

        if (_iDeli_flag == 0)
        {
            SetHtmlControlStyle("d_address", HtmlTextWriterStyle.Display, "none", true);
        }
        else
        {
            SetHtmlControlStyle("d_address", HtmlTextWriterStyle.Display, "inline", true);
        }


        //contact_person
        contact_person.Value = _oMobileRetentionOrder.GetContact_person();

        //contact_no
        contact_no.Value = _oMobileRetentionOrder.GetContact_no().ToString();

        //ord_place_hkid
        if (_oMobileRetentionOrder.GetOrd_place_id_type().Trim().Equals("HKID"))
            ord_place_hkid.Value = Func.Left(_oMobileRetentionOrder.GetOrd_place_hkid(), _oMobileRetentionOrder.GetOrd_place_hkid().Length - 1);
        else
            ord_place_hkid.Value = _oMobileRetentionOrder.GetOrd_place_hkid();

        //ord_place_hkid2
        if (_oMobileRetentionOrder.GetOrd_place_id_type().Trim().Equals("HKID"))
            ord_place_hkid2.Value = Func.Right(_oMobileRetentionOrder.GetOrd_place_hkid(), 1);
        else
            ord_place_hkid2.Disabled = true;


        //d_date
        if (_oMobileRetentionOrder.GetD_date() != null)
        {
            if (Func.IsDateTime(_oMobileRetentionOrder.GetD_date()))
            {
                d_date.Text = ((DateTime)_oMobileRetentionOrder.GetD_date()).ToString("dd/MM/yyyy");
            }
        }

        if (_oMobileRetentionOrder.GetHs_model().Trim() == string.Empty && _oMobileRetentionOrder.GetSim_item_name().Trim() == string.Empty && _oMobileRetentionOrder.GetSim_item_name().Trim() == string.Empty && _oMobileRetentionOrder.GetSim_item_name().Trim() == string.Empty && (_oMobileRetentionOrder.GetGo_wireless().Trim() == "NO" || _oMobileRetentionOrder.GetGo_wireless().Trim() == string.Empty))
        {
            SetHtmlControlAtt("d_date", HtmlTextWriterAttribute.Class, "disablerow", true);
            //SetHtmlControlAtt("d_date", HtmlTextWriterAttribute.Disabled, "true", false);
            d_date.Enabled = false;
        }
        else
        {
            SetHtmlControlAtt("d_date", HtmlTextWriterAttribute.Class, "highlightrow", true);
            d_date.Enabled = true;
        }

        if (_iDeli_flag == 0)
        {
            SetHtmlControlStyle("d_date", HtmlTextWriterStyle.Display, "none", true);
        }
        else
        {
            SetHtmlControlStyle("d_date", HtmlTextWriterStyle.Display, "inline", true);
        }


        d_time.Items.Clear();
        d_time.Items.Add(new ListItem(string.Empty, string.Empty));

        



        //d_time
        d_time.Items.Clear();
        d_time.Items.Add(new ListItem(string.Empty, string.Empty));
        d_time.Items.Add(new ListItem("10-13", "10-13"));
        d_time.Items.Add(new ListItem("11-13", "11-13"));
        d_time.Items.Add(new ListItem("14-16", "14-16"));
        d_time.Items.Add(new ListItem("16-18", "16-18"));
        d_time.Items.Add(new ListItem("14-18", "14-18"));
        d_time.Items.Add(new ListItem("16-20", "16-20"));
        d_time.Items.Add(new ListItem("18-20", "18-20"));
        d_time.Items.Add(new ListItem("20-22", "20-22"));

        DropListSelectedValue(ref d_time, _oMobileRetentionOrder.GetD_time());
        if (_oMobileRetentionOrder.GetHs_model().Trim() == string.Empty && _oMobileRetentionOrder.GetSim_item_name().Trim() == string.Empty && (_oMobileRetentionOrder.GetGo_wireless().Trim() == "NO" || _oMobileRetentionOrder.GetGo_wireless().Trim() == string.Empty))
        {
            SetHtmlControlAtt("d_time", HtmlTextWriterAttribute.Class, "disablerow", true);
            //SetHtmlControlAtt("d_time", HtmlTextWriterAttribute.Disabled, "true", false);
            d_time.Enabled = false;
        }
        else
        {
            SetHtmlControlAtt("d_time", HtmlTextWriterAttribute.Class, "highlightrow", true);
            d_time.Enabled = true;
        }

        if (_iDeli_flag == 0)
        {
            SetHtmlControlStyle("d_time", HtmlTextWriterStyle.Display, "none", true);
        }
        else
        {
            SetHtmlControlStyle("d_time", HtmlTextWriterStyle.Display, "inline", true);
        }


        //extra_d_charge
        extra_d_charge.Value = _oMobileRetentionOrder.GetExtra_d_charge();
        if (_oMobileRetentionOrder.GetHs_model().Trim() == string.Empty && (_oMobileRetentionOrder.GetGo_wireless().Trim() == "NO" || _oMobileRetentionOrder.GetGo_wireless().Trim() == string.Empty))
        {
            SetHtmlControlAtt("extra_d_charge", HtmlTextWriterAttribute.Class, "disablerow", true);
            //SetHtmlControlAtt("contact_person", HtmlTextWriterAttribute.Disabled, "true", false);
            contact_person.Disabled = true;
        }
        else
        {
            SetHtmlControlAtt("extra_d_charge", HtmlTextWriterAttribute.Class, "highlightrow", true);
        }


        if (_iDeli_flag == 0)
        {
            SetHtmlControlStyle("extra_d_charge", HtmlTextWriterStyle.Display, "none", true);
        }
        else
        {
            SetHtmlControlStyle("extra_d_charge", HtmlTextWriterStyle.Display, "inline", true);
        }

        //contact_person
        contact_person.Value = _oMobileRetentionOrder.GetContact_person();
        if (_oMobileRetentionOrder.GetHs_model().Trim() == string.Empty && (_oMobileRetentionOrder.GetGo_wireless().Trim() == "NO" || _oMobileRetentionOrder.GetGo_wireless().Trim() == string.Empty))
        {
            SetHtmlControlAtt("contact_person", HtmlTextWriterAttribute.Class, "disablerow", true);
            //SetHtmlControlAtt("contact_person", HtmlTextWriterAttribute.Disabled, "true", false);
            contact_person.Disabled = true;
        }
        else
        {
            SetHtmlControlAtt("contact_person", HtmlTextWriterAttribute.Class, "highlightrow", true);
        }

        if (_iDeli_flag == 0)
        {
            SetHtmlControlStyle("contact_person", HtmlTextWriterStyle.Display, "none", true);
        }
        else
        {
            SetHtmlControlStyle("contact_person", HtmlTextWriterStyle.Display, "inline", true);
        }

        //contact_no
        contact_no.Value = (_oMobileRetentionOrder.GetContact_no() == null) ? string.Empty : (_oMobileRetentionOrder.GetContact_no()).ToString();

        //contact_no
        if (_oMobileRetentionOrder.GetHs_model().Trim() == string.Empty && _oMobileRetentionOrder.GetSim_item_name().Trim() == string.Empty && (_oMobileRetentionOrder.GetGo_wireless().Trim() == "NO" || _oMobileRetentionOrder.GetGo_wireless().Trim() == string.Empty))
        {
            SetHtmlControlAtt("contact_no", HtmlTextWriterAttribute.Class, "disablerow", true);
            //SetHtmlControlAtt("contact_no", HtmlTextWriterAttribute.Disabled, "true", false);
            contact_no.Disabled = true;
        }
        else
        {
            SetHtmlControlAtt("contact_no", HtmlTextWriterAttribute.Class, "highlightrow", true);
        }

        if (_iDeli_flag == 0)
        {
            SetHtmlControlStyle("contact_no", HtmlTextWriterStyle.Display, "none", true);
        }
        else
        {
            SetHtmlControlStyle("contact_no", HtmlTextWriterStyle.Display, "inline", true);
        }


        //ext_place_tel
        ext_place_tel.Value = _oMobileRetentionOrder.GetExt_place_tel();
        if (_oMobileRetentionOrder.GetHs_model().Trim() == string.Empty && _oMobileRetentionOrder.GetSim_item_name().Trim() == string.Empty && (_oMobileRetentionOrder.GetGo_wireless().Trim() == "NO" || _oMobileRetentionOrder.GetGo_wireless().Trim() == string.Empty))
        {
            SetHtmlControlAtt("ext_place_tel", HtmlTextWriterAttribute.Class, "disablerow", true);
            //SetHtmlControlAtt("ext_place_tel", HtmlTextWriterAttribute.Disabled, "true", false);
            ext_place_tel.Disabled = true;
        }
        else
        {
            SetHtmlControlAtt("ext_place_tel", HtmlTextWriterAttribute.Class, "highlightrow", true);
        }

        if (_iDeli_flag == 0)
        {
            SetHtmlControlStyle("ext_place_tel", HtmlTextWriterStyle.Display, "none", true);
        }
        else
        {
            SetHtmlControlStyle("ext_place_tel", HtmlTextWriterStyle.Display, "inline", true);
        }

        //pay_method
        DropListSelectedValue(ref pay_method, _oMobileRetentionOrder.GetPay_method());
        //paymethod
        if (_oMobileRetentionOrder.GetHs_model().Trim() == string.Empty && _oMobileRetentionOrder.GetSim_item_name().Trim() == string.Empty && (_oMobileRetentionOrder.GetGo_wireless().Trim() == "NO" || _oMobileRetentionOrder.GetGo_wireless().Trim() == string.Empty))
        {
            SetHtmlControlAtt("pay_method", HtmlTextWriterAttribute.Class, "disablerow", true);
            //SetHtmlControlAtt("pay_method", HtmlTextWriterAttribute.Disabled, "true", false);
            pay_method.Enabled = false;
        }
        else
        {
            SetHtmlControlAtt("pay_method", HtmlTextWriterAttribute.Class, "highlightrow", true);
        }

        if (_iDeli_flag == 0)
        {
            SetHtmlControlStyle("pay_method", HtmlTextWriterStyle.Display, "none", true);
        }
        else
        {
            SetHtmlControlStyle("pay_method", HtmlTextWriterStyle.Display, "inline", true);
        }



        //card_type
        DropListSelectedValue(ref card_type, _oMobileRetentionOrder.GetCard_type());
        if (!(_oMobileRetentionOrder.GetPay_method().Equals("CREDIT CARD") || _oMobileRetentionOrder.GetPay_method().Equals("CREDIT CARD INSTALLMENT")))
        {
            SetHtmlControlAtt("card_type", HtmlTextWriterAttribute.Class, "disablerow", true);
            //SetHtmlControlAtt("card_type", HtmlTextWriterAttribute.Disabled, "true", false);
            card_type.Enabled = false;
        }
        else
        {
            SetHtmlControlAtt("card_type", HtmlTextWriterAttribute.Class, "highlightrow", true);
        }

        if (_iDeli_flag == 0)
        {
            SetHtmlControlStyle("card_type", HtmlTextWriterStyle.Display, "none", true);
        }
        else
        {
            SetHtmlControlStyle("card_type", HtmlTextWriterStyle.Display, "inline", true);
        }


        //card_no
        card_no.Text = _oMobileRetentionOrder.GetCard_no();

        if (!(_oMobileRetentionOrder.GetPay_method().Equals("CREDIT CARD") || _oMobileRetentionOrder.GetPay_method().Equals("CREDIT CARD INSTALLMENT")))
        {
            SetHtmlControlAtt("card_no", HtmlTextWriterAttribute.Class, "disablerow", true);
            SetHtmlControlAtt("card_no", HtmlTextWriterAttribute.Disabled, "true", false);
        }
        else
        {
            SetHtmlControlAtt("card_no", HtmlTextWriterAttribute.Class, "highlightrow", true);
        }

        if (_iDeli_flag == 0)
        {
            SetHtmlControlStyle("card_no", HtmlTextWriterStyle.Display, "none", true);
        }
        else
        {
            SetHtmlControlStyle("card_no", HtmlTextWriterStyle.Display, "inline", true);
        }


        //card_holder
        card_holder.Value = _oMobileRetentionOrder.GetCard_holder();
        if (!(_oMobileRetentionOrder.GetPay_method().Equals("CREDIT CARD") || _oMobileRetentionOrder.GetPay_method().Equals("CREDIT CARD INSTALLMENT")))
        {
            SetHtmlControlAtt("card_holder", HtmlTextWriterAttribute.Class, "disablerow", true);
            //SetHtmlControlAtt("card_holder", HtmlTextWriterAttribute.Disabled, "true", false);
            card_holder.Disabled = true;
        }
        else
        {
            RegisterJSScript.AppendLine("document.all.card_holder.className='highlightrow';");
            SetHtmlControlAtt("card_holder", HtmlTextWriterAttribute.Class, "highlightrow", true);
        }

        if (_iDeli_flag == 0)
        {
            SetHtmlControlStyle("card_holder", HtmlTextWriterStyle.Display, "none", true);
        }
        else
        {
            SetHtmlControlStyle("card_holder", HtmlTextWriterStyle.Display, "inline", true);
        }

        //card_exp_month
        DropListSelectedValue(ref card_exp_month, _oMobileRetentionOrder.GetCard_exp_month());
        if (!(_oMobileRetentionOrder.GetPay_method().Equals("CREDIT CARD") || _oMobileRetentionOrder.GetPay_method().Equals("CREDIT CARD INSTALLMENT")))
        {
            SetHtmlControlAtt("card_exp_month", HtmlTextWriterAttribute.Class, "disablerow", true);
            //SetHtmlControlAtt("card_exp_month", HtmlTextWriterAttribute.Disabled, "true", false);
            card_exp_month.Enabled = false;
        }
        else
        {
            SetHtmlControlAtt("card_exp_month", HtmlTextWriterAttribute.Class, "highlightrow", true);
        }

        if (_iDeli_flag == 0)
        {
            SetHtmlControlStyle("card_exp_month", HtmlTextWriterStyle.Display, "none", true);
        }
        else
        {
            SetHtmlControlStyle("card_exp_month", HtmlTextWriterStyle.Display, "inline", true);
        }


        //card_exp_year
        DropListSelectedValue(ref card_exp_year, _oMobileRetentionOrder.GetCard_exp_year());
        if (!(_oMobileRetentionOrder.GetPay_method().Equals("CREDIT CARD") || _oMobileRetentionOrder.GetPay_method().Equals("CREDIT CARD INSTALLMENT")))
        {
            SetHtmlControlAtt("card_exp_year", HtmlTextWriterAttribute.Class, "disablerow", true);
            //SetHtmlControlAtt("card_exp_year", HtmlTextWriterAttribute.Disabled, "true", false);
            card_exp_year.Enabled = false;
        }
        else
        {
            SetHtmlControlAtt("card_exp_year", HtmlTextWriterAttribute.Class, "highlightrow", true);
        }

        if (_iDeli_flag == 0)
        {
            SetHtmlControlStyle("card_exp_year", HtmlTextWriterStyle.Display, "none", true);
        }
        else
        {
            SetHtmlControlStyle("card_exp_year", HtmlTextWriterStyle.Display, "inline", true);
        }



        //amount
        amount.Value = _oMobileRetentionOrder.GetAmount();

        //accessory_price
        if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetAccessory_price()))
            accessory_price.Value = "0";
        else
            accessory_price.Value = _oMobileRetentionOrder.GetAccessory_price();

        int _iaccessory_price = 0;
        int _iAmount = 0;
        if (!string.IsNullOrEmpty(_oMobileRetentionOrder.GetAccessory_price().Trim()) && Func.IsParseInt(_oMobileRetentionOrder.GetAccessory_price().Trim()))
            _iaccessory_price += Convert.ToInt32(_oMobileRetentionOrder.GetAccessory_price().Trim());
        if (!string.IsNullOrEmpty(_oMobileRetentionOrder.GetAmount().Trim()) && Func.IsParseInt(_oMobileRetentionOrder.GetAmount().Trim()))
            _iAmount += Convert.ToInt32(_oMobileRetentionOrder.GetAmount().Trim());

        //total_amount
        total_amount.Value = (_iaccessory_price + _iAmount).ToString();

        //remarks
        remarks.Value = _oMobileRetentionOrder.GetRemarks();

        //remarks2EDF
        remarks2EDF.Value = _oMobileRetentionOrder.GetRemarks2EDF();
        if (_oMobileRetentionOrder.GetHs_model().Trim() == string.Empty && _oMobileRetentionOrder.GetSim_item_name().Trim() == string.Empty  && (_oMobileRetentionOrder.GetGo_wireless().Trim() == "NO" || _oMobileRetentionOrder.GetGo_wireless().Trim() == string.Empty))
        {
            SetHtmlControlAtt("remarks2EDF", HtmlTextWriterAttribute.Class, "disablerow", true);
            //SetHtmlControlAtt("remarks2EDF", HtmlTextWriterAttribute.Disabled, "true", false);
            remarks2EDF.Disabled = true;
        }
        else
        {
            SetHtmlControlAtt("remarks2EDF", HtmlTextWriterAttribute.Class, "highlightrow", true);
        }

        if (_iDeli_flag == 0)
            remarks2EDF.Visible = false;
        else
            remarks2EDF.Visible = true;


        //remarks2PY
        remarks2PY.Value = _oMobileRetentionOrder.GetRemarks2PY();

        //staff_no
        staff_no.Value = _oMobileRetentionOrder.GetStaff_no();

        //ref_staff_no
        ref_staff_no.Value = _oMobileRetentionOrder.GetRef_staff_no();

        //staff_name
        staff_name.Value = _oMobileRetentionOrder.GetStaff_name();

        //ref_salesmancode
        ref_salesmancode.Value = _oMobileRetentionOrder.GetRef_salesmancode();

        //teamcode
        teamcode.Value = _oMobileRetentionOrder.GetTeamcode();

        //tl_name
        tl_name.Value = _oMobileRetentionOrder.GetTl_name();

        //channel
        channel.Value = _oMobileRetentionOrder.GetChannel();

        //salesmancode
        salesmancode.Value = _oMobileRetentionOrder.GetSalesmancode();

        //extn
        extn.Value = _oMobileRetentionOrder.GetExtn();

        //ob_program_id
        SetHtmlControlValue("ob_program_id", _oMobileRetentionOrder.GetOb_program_id(), true);


        //next_bill
        if (_oMobileRetentionOrder.GetNext_bill() != null)
            next_bill.Checked = (bool)_oMobileRetentionOrder.GetNext_bill();

        if (_iCon_flag == 0)
        {
            SetHtmlControlStyle("next_bill", HtmlTextWriterStyle.Display, "none", true);
        }
        else
        {
            SetHtmlControlStyle("next_bill", HtmlTextWriterStyle.Display, "inline", true);
        }


        MobileOrderAddress _oRegisteredAddress = new MobileOrderAddress(SYSConn<MSSQLConnect>.Connect(), _oMobileRetentionOrder.GetOrder_id(), "REGISTERED_ADDRESS");
        if (_oRegisteredAddress != null && _oRegisteredAddress.GetFound())
        {

            DropListSelectedValue(ref RegisteredAddressControl.D_type, _oRegisteredAddress.GetD_type());
            RegisteredAddressControl.D_room.Text = _oRegisteredAddress.d_room;
            RegisteredAddressControl.D_floor.Text = _oRegisteredAddress.d_floor;
            RegisteredAddressControl.D_blk.Text = _oRegisteredAddress.d_blk;
            RegisteredAddressControl.D_build.Text = _oRegisteredAddress.d_build;
            RegisteredAddressControl.D_street.Text = _oRegisteredAddress.d_street;
            RadioListSelectedValue(ref RegisteredAddressControl.D_region, _oRegisteredAddress.GetD_region(), _oRegisteredAddress.GetD_region());
            RegisteredAddressControl.DRegionHidden.Value = _oRegisteredAddress.GetD_region();
            RegisteredAddressControl.ReloadDDistrict();
            if (!string.IsNullOrEmpty(_oRegisteredAddress.GetD_district()))
                DropListSelectedValue(ref RegisteredAddressControl.D_district, _oRegisteredAddress.GetD_district());
                
        }


        HtmlDropSelectedValue(ref bill_medium, _oMobileRetentionOrder.GetBill_medium());
        RegisterJSScript.AppendLine("BillMediumChange('" + _oMobileRetentionOrder.GetBill_medium() + "',false);");
        
        //bill_medium_waive
        bill_medium_waive.Checked = (_oMobileRetentionOrder.GetBill_medium_waive() == true) ? true : false;
        bill_medium_email.Value = _oMobileRetentionOrder.GetBill_medium_email();

        //Only for MobileLite
        if (_oMobileRetentionOrder.GetIssue_type().Equals("MOBILE_LITE"))
        {
            if (!bill_medium_waive.Checked)
            {
                RegisterJSScript.AppendLine("UserControlVisible('BillingAddressControl',false);");
                RegisterJSScript.AppendLine("UserControlVisible('same_register_address_show',false);");
                RegisterJSScript.AppendLine("$(\".bill_medium_waive\").attr(\"checked\", false);");
            }
        }


        MobileOrderAddress _oBillingAddress = new MobileOrderAddress(SYSConn<MSSQLConnect>.Connect(), _oMobileRetentionOrder.GetOrder_id(), "BILLING_ADDRESS");
        if (_oBillingAddress != null)
        {
            if (_oBillingAddress.GetFound())
            {
                DropListSelectedValue(ref BillingAddressControl.D_type, _oBillingAddress.GetD_type());
                BillingAddressControl.D_room.Text = _oBillingAddress.d_room;
                BillingAddressControl.D_floor.Text = _oBillingAddress.d_floor;
                BillingAddressControl.D_blk.Text = _oBillingAddress.d_blk;
                BillingAddressControl.D_build.Text = _oBillingAddress.d_build;
                BillingAddressControl.D_street.Text = _oBillingAddress.d_street;

                RadioListSelectedValue(ref BillingAddressControl.D_region, "HK", _oBillingAddress.GetD_region());
                RadioListSelectedValue(ref BillingAddressControl.D_region, "KLN", _oBillingAddress.GetD_region());
                RadioListSelectedValue(ref BillingAddressControl.D_region, "NT", _oBillingAddress.GetD_region());
                RadioListSelectedValue(ref BillingAddressControl.D_region, "LT", _oBillingAddress.GetD_region());

                BillingAddressControl.DRegionHidden.Value = _oRegisteredAddress.GetD_region();
                BillingAddressControl.ReloadDDistrict();
                if (!string.IsNullOrEmpty(_oBillingAddress.GetD_district()))
                    DropListSelectedValue(ref BillingAddressControl.D_district, _oBillingAddress.GetD_district());
            }
        }


        MobileOrderMNPDetailEntity[] _oMobileOrderMNPDetailArr = MobileOrderMNPDetailRepository.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), 0, "order_id='" + ((int)_oMobileRetentionOrder.GetOrder_id()).ToString() + "'", null, null);
        if (_oMobileOrderMNPDetailArr != null)
        {
            if (_oMobileOrderMNPDetailArr.Length > 0)
            {
                MobileOrderMNPDetail _oMobileOrderMNPDetail = (MobileOrderMNPDetail)_oMobileOrderMNPDetailArr[0];
                if (_oMobileOrderMNPDetail != null)
                {
                    if (_oMobileOrderMNPDetail.GetFound())
                    {

                        MobileOrderMNPDetailControl.MobileOrderMNPDetailData = _oMobileOrderMNPDetail;

                        DropListSelectedValue(ref MobileOrderMNPDetailControl.Company_name, _oMobileOrderMNPDetail.company_name);

                        DropListSelectedValue(ref MobileOrderMNPDetailControl.Id_type, _oMobileOrderMNPDetail.id_type);
                        MobileOrderMNPDetailControl.registered_name.Text = _oMobileOrderMNPDetail.GetRegistered_name();
                        if (_oMobileOrderMNPDetail.GetService_activation_date() != null)
                            MobileOrderMNPDetailControl.Service_activation_date.Text = ((DateTime)_oMobileOrderMNPDetail.GetService_activation_date()).ToString("dd/MM/yyyy");
                        DropListSelectedValue(ref MobileOrderMNPDetailControl.Service_activation_time, _oMobileOrderMNPDetail.service_activation_time);
                        MobileOrderMNPDetailControl.Ticker_number.Text = _oMobileOrderMNPDetail.GetTicker_number();

                        if (_oMobileOrderMNPDetail.GetTransfer_idd_deposit() != null)
                            MobileOrderMNPDetailControl.Transfer_idd_deposit.Text = ((long)_oMobileOrderMNPDetail.GetTransfer_idd_deposit()).ToString();

                        if (_oMobileOrderMNPDetail.GetTransfer_idd_roaming_deposit() != null)
                            MobileOrderMNPDetailControl.Transfer_idd_roaming_deposit.Text = ((long)_oMobileOrderMNPDetail.GetTransfer_idd_roaming_deposit()).ToString();

                        if (_oMobileOrderMNPDetail.GetTransfer_no_hk_id_holder_deposit() != null)
                            MobileOrderMNPDetailControl.Transfer_no_hk_id_holder_deposit.Text = ((long)_oMobileOrderMNPDetail.GetTransfer_no_hk_id_holder_deposit()).ToString();

                        if (_oMobileOrderMNPDetail.GetTransfer_no_add_proof_deposit() != null)
                            MobileOrderMNPDetailControl.Transfer_no_add_proof_deposit.Text = ((long)_oMobileOrderMNPDetail.GetTransfer_no_add_proof_deposit()).ToString();

                        if (_oMobileOrderMNPDetail.GetTransfer_others_deposit() != null)
                            MobileOrderMNPDetailControl.Transfer_others_deposit.Text = ((long)_oMobileOrderMNPDetail.GetTransfer_others_deposit()).ToString();

                        if (_oMobileOrderMNPDetail.GetTransfer_to_3g() != null)
                            MobileOrderMNPDetailControl.Transfer_to_3g.Checked = (_oMobileOrderMNPDetail.GetTransfer_to_3g() == true) ? true : false;

                        if (MobileOrderMNPDetailControl.Transfer_to_3g.Checked)
                        {
                            RegisterJSScript.AppendLine("TransferTo3GShow(true)");
                        }

                        if (_oMobileOrderMNPDetail.GetId_type() == "HKID")
                        {
                            //hkid
                            MobileOrderMNPDetailControl.hkid.Text = (_oMobileOrderMNPDetail.GetHkid().Length >= 8) ? _oMobileOrderMNPDetail.GetHkid().Substring(0, _oMobileOrderMNPDetail.GetHkid().Length - 1) : _oMobileOrderMNPDetail.GetHkid();
                            //hkid2
                            MobileOrderMNPDetailControl.hkid2.Text = (_oMobileOrderMNPDetail.GetHkid().Length >= 8) ? _oMobileOrderMNPDetail.GetHkid().Substring(_oMobileOrderMNPDetail.GetHkid().Length - 1) : string.Empty;
                        }
                        else
                        {
                            MobileOrderMNPDetailControl.hkid.Text = _oMobileOrderMNPDetail.GetHkid();
                        }
                    }
                }
            }
        }

        if (_oMobileRetentionOrder.GetPrepayment_waive() != null)
            prepayment_waive.Checked = (_oMobileRetentionOrder.GetPrepayment_waive() == true) ? true : false;


        MobileOrderThreePartyEntity[] _oMobileOrderThreePartyArr = MobileOrderThreePartyRepository.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), 0, "order_id='" + ((int)_oMobileRetentionOrder.GetOrder_id()).ToString() + "'", null, null);
        if (_oMobileOrderThreePartyArr != null)
        {
            if (_oMobileOrderThreePartyArr.Length > 0)
            {
                MobileOrderThreeParty _oMobileOrderThreeParty = (MobileOrderThreeParty)_oMobileOrderThreePartyArr[0];
                if (_oMobileOrderThreeParty.GetFound())
                {

                    MobileOrderThreePartyControl.Three_party.Checked = (_oMobileOrderThreeParty.GetThree_party() == true) ? true : false;
                    if (MobileOrderThreePartyControl.Three_party.Checked)
                    {
                        RegisterJSScript.AppendLine("ReceiveSIMBy3rdPartyDetailShowChk(true);");
                    }
                    DropListSelectedValue(ref MobileOrderThreePartyControl.Id_type, _oMobileOrderThreeParty.GetId_type());

                    DropListSelectedValue(ref MobileOrderThreePartyControl.Plural, _oMobileOrderThreeParty.GetPlural());
                    MobileOrderThreePartyControl.Arthurization_person.Text = _oMobileOrderThreeParty.GetArthurization_person();

                    if (_oMobileOrderThreeParty.GetId_type() == "HKID")
                    {
                        //hkid
                        MobileOrderThreePartyControl.hkid.Text = (_oMobileOrderThreeParty.GetHkid().Length >= 8) ? _oMobileOrderThreeParty.GetHkid().Substring(0, _oMobileOrderThreeParty.GetHkid().Length - 1) : _oMobileOrderThreeParty.GetHkid();
                        //hkid2
                        MobileOrderThreePartyControl.hkid2.Text = (_oMobileOrderThreeParty.GetHkid().Length >= 8) ? _oMobileOrderThreeParty.GetHkid().Substring(_oMobileOrderThreeParty.GetHkid().Length - 1) : string.Empty;
                    }
                    else
                    {
                        MobileOrderThreePartyControl.hkid.Text = _oMobileOrderThreeParty.GetHkid();
                    }
                    MobileOrderThreePartyControl.contact_no.Text = _oMobileOrderThreeParty.GetContact_no();
                }
            }
        }
        //third_party_credit_card
        if (_oMobileRetentionOrder.GetThird_party_credit_card().Equals("YES"))
        {
            third_party_credit_card_0.Checked = true;
            third_party_credit_card_1.Checked = false;
        }
        else
        {
            third_party_credit_card_0.Checked = false;
            third_party_credit_card_1.Checked = true;
        }
        RegisterJSScript.AppendLine("third_party()");

        //third_party_id_type
        HtmlDropSelectedValue(ref third_party_id_type, _oMobileRetentionOrder.GetThird_party_id_type());

        if (_oMobileRetentionOrder.GetThird_party_id_type() == "HKID")
        {
            //third_party_hkid
            third_party_hkid.Value = (_oMobileRetentionOrder.GetThird_party_hkid().Length >= 8) ? _oMobileRetentionOrder.GetThird_party_hkid().Substring(0, _oMobileRetentionOrder.GetThird_party_hkid().Length - 1) : _oMobileRetentionOrder.GetThird_party_hkid();
            //third_party_hkid2
            third_party_hkid2.Value = (_oMobileRetentionOrder.GetThird_party_hkid().Length >= 8) ? _oMobileRetentionOrder.GetThird_party_hkid().Substring(_oMobileRetentionOrder.GetThird_party_hkid().Length - 1) : string.Empty;

        }
        else
        {
            third_party_hkid.Value = _oMobileRetentionOrder.GetThird_party_hkid();
        }

        //monthly_bank_account_bank_code
        monthly_bank_account_bank_code.Value = _oMobileRetentionOrder.GetMonthly_bank_account_bank_code();
        //monthly_bank_account_branch_code
        monthly_bank_account_branch_code.Value = _oMobileRetentionOrder.GetMonthly_bank_account_branch_code();
        //monthly_bank_account_no
        monthly_bank_account_no.Value = _oMobileRetentionOrder.GetMonthly_bank_account_no();
        //monthly_bank_account_holder
        monthly_bank_account_holder.Value = _oMobileRetentionOrder.GetMonthly_bank_account_holder();
        //monthly_bank_account_id_type
        monthly_bank_account_id_type.Value = _oMobileRetentionOrder.GetMonthly_bank_account_id_type();
        //monthly_bank_account_hkid
        monthly_bank_account_hkid.Value = _oMobileRetentionOrder.GetMonthly_bank_account_hkid();
        //monthly_bank_account_hkid2
        monthly_bank_account_hkid2.Value = _oMobileRetentionOrder.GetMonthly_bank_account_hkid2();
        //delivery_collection_type
        HtmlDropSelectedValue(ref delivery_collection_type, _oMobileRetentionOrder.GetDelivery_collection_type());
        //delivery_exchange
        HtmlDropSelectedValue(ref delivery_exchange, _oMobileRetentionOrder.GetDelivery_exchange());
        //delivery_exchange_option
        HtmlDropSelectedValue(ref delivery_exchange_option, _oMobileRetentionOrder.GetDelivery_exchange_option());
        //delivery_exchange_location
        delivery_exchange_location.Value = _oMobileRetentionOrder.GetDelivery_exchange_location();

        //upgrade_type
        upgrade_type.Text = _oMobileRetentionOrder.GetUpgrade_type();
        //upgrade_sponsorships_amount
        upgrade_sponsorships_amount.Text = _oMobileRetentionOrder.GetUpgrade_sponsorships_amount();
        //upgrade_existing_contract_sdate
        if (_oMobileRetentionOrder.GetUpgrade_existing_contract_sdate() != null)
        {
            upgrade_existing_contract_sdate.Text = ((DateTime)_oMobileRetentionOrder.GetUpgrade_existing_contract_sdate()).ToString("dd/MM/yyyy");
        }
        //upgrade_existing_contract_edate
        if (_oMobileRetentionOrder.GetUpgrade_existing_contract_edate() != null)
        {
            upgrade_existing_contract_edate.Text = ((DateTime)_oMobileRetentionOrder.GetUpgrade_existing_contract_edate()).ToString("dd/MM/yyyy");
        }
        //upgrade_existing_customer_type
        DropListSelectedValue(ref upgrade_existing_customer_type, _oMobileRetentionOrder.GetUpgrade_existing_customer_type());
        //upgrade_handset_offer_rebate_schedule
        DropListSelectedValue(ref upgrade_handset_offer_rebate_schedule, _oMobileRetentionOrder.GetUpgrade_handset_offer_rebate_schedule());
        SetHtmlControlValue("upgrade_handset_offer_rebate_schedule", _oMobileRetentionOrder.GetUpgrade_handset_offer_rebate_schedule(), true);

        //upgrade_existing_pccw_customer
        upgrade_existing_pccw_customer.Text = _oMobileRetentionOrder.GetUpgrade_existing_pccw_customer();

        //upgrade_service_account_no
        upgrade_service_account_no.Value = _oMobileRetentionOrder.GetUpgrade_service_account_no();

        //upgrade_registered_mobile_no
        upgrade_registered_mobile_no.Value = _oMobileRetentionOrder.GetUpgrade_registered_mobile_no();

        //upgrade_service_tenure
        DropListSelectedValue(ref upgrade_service_tenure, _oMobileRetentionOrder.GetUpgrade_service_tenure());

        //action_of_rate_plan_effective
        action_of_rate_plan_effective.Text = _oMobileRetentionOrder.GetAction_of_rate_plan_effective();

        //existing_smart_phone_model
        DropListSelectedValue(ref existing_smart_phone_model, _oMobileRetentionOrder.GetExisting_smart_phone_model());

        //existing_smart_phone_imei
        existing_smart_phone_imei.Value = _oMobileRetentionOrder.GetExisting_smart_phone_imei();

        //upgrade_rebate_calculation
        upgrade_rebate_calculation.Value = _oMobileRetentionOrder.GetUpgrade_rebate_calculation();

        //m_3rd_id_type
        HtmlDropSelectedValue(ref m_3rd_id_type, _oMobileRetentionOrder.GetM_3rd_id_type());

        //m_3rd_hkid
        m_3rd_hkid.Value = _oMobileRetentionOrder.GetM_3rd_hkid();

        //m_3rd_hkid2
        m_3rd_hkid2.Value = _oMobileRetentionOrder.GetM_3rd_hkid2();

        //m_3rd_contact_no
        m_3rd_contact_no.Value = _oMobileRetentionOrder.GetM_3rd_contact_no();

        //cn_mrt_no
        if (_oMobileRetentionOrder.GetCn_mrt_no() != null)
        {
            cn_mrt_no.Value = ((long)_oMobileRetentionOrder.GetCn_mrt_no()).ToString();
        }
        //pool
        DropListSelectedValue(ref pool, _oMobileRetentionOrder.GetPool());
        //card_ref_no
        card_ref_no.Value = _oMobileRetentionOrder.GetCard_ref_no();
        //ftg_tenure
        DropListSelectedValue(ref ftg_tenure, _oMobileRetentionOrder.GetFtg_tenure());


        //first_month_fee
        first_month_fee.Value = _oMobileRetentionOrder.GetFirst_month_fee();

        //first_month_license_fee
        first_month_license_fee.Value = _oMobileRetentionOrder.GetFirst_month_license_fee();

        //accessory_waive
        if (_oMobileRetentionOrder.GetAccessory_waive() != null)
            accessory_waive.Checked = (bool)_oMobileRetentionOrder.GetAccessory_waive();

        RegisterJSScript.AppendLine("ChkCNMrtNoUsed();");
        ajaxvas();
        InitGoWireLessControl(_oMobileRetentionOrder);
        ch_delivery();

        SimShow();

    }
    #endregion

    #region ReloadDBVasSelected
    public void ReloadDBVasSelected(int x_iOrder_id)
    {
        if (x_iOrder_id != -1)
        {
            MobileOrderVasEntity[] _oMobileOrderVasList = MobileOrderVasRepository.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), "order_id='" + x_iOrder_id.ToString() + "'", null, null);
            if (_oMobileOrderVasList != null)
            {
                for (int i = 0; i < _oMobileOrderVasList.Length; i++)
                {
                    if (_oMobileOrderVasList[i].GetActive() == true)
                    {
                        BusinessVas _oBusinessVas = new BusinessVas(SYSConn<MSSQLConnect>.Connect(), _oMobileOrderVasList[i].GetVas_id());

                        if (!string.IsNullOrEmpty(_oBusinessVas.GetVas_field()))
                        {
                            if (!string.IsNullOrEmpty(_oMobileOrderVasList[i].GetVas_value()) && _oMobileOrderVasList[i].GetVas_id() != null)
                            {
                                string _sQuery2 = "SELECT vas_value FROM " + Configurator.MSSQLTablePrefix + "BusinessVas with (nolock) WHERE active=1 AND vas_field='" + _oBusinessVas.GetVas_field().Trim() + "' order by vas_value";
                                SqlDataReader _oReader2 = n_oDB.GetSearch(_sQuery2);
                                if (_oReader2 != null)
                                {
                                    while (_oReader2.Read())
                                    {
                                        if (Func.FR(_oReader2[BusinessVas.Para.vas_value]).ToString().ToUpper().Trim() == _oMobileOrderVasList[i].GetVas_value().ToString().ToUpper().Trim())
                                        {
                                            SetHtmlControlValue(_oBusinessVas.GetVas_field(), Func.FR(_oReader2[BusinessVas.Para.vas_value]).ToString().ToUpper().Trim(), true);
                                            break;
                                        }
                                    }
                                }
                                _oReader2.Close();
                                _oReader2.Dispose();
                            }

                            if (!string.IsNullOrEmpty(_oMobileOrderVasList[i].GetFee()) && _oMobileOrderVasList[i].GetMulti_id() != null)
                            {
                                string _sQuery3 = "SELECT distinct vas_desc,fee FROM " + Configurator.MSSQLTablePrefix + "BusinessVasDescription with (nolock) WHERE active=1 AND vas='" + _oBusinessVas.GetVas_field().Trim() + "'";
                                SqlDataReader _oReader3 = n_oDB.GetSearch(_sQuery3);
                                if (_oReader3 != null)
                                {
                                    while (_oReader3.Read())
                                    {
                                        if (Func.FR(_oReader3[BusinessVasDescription.Para.fee]).ToString().Trim().ToUpper() == _oMobileOrderVasList[i].GetFee().Trim().ToUpper())
                                        {
                                            SetHtmlControlValue(_oBusinessVas.GetVas_field() + "1", Func.FR(_oReader3[BusinessVasDescription.Para.fee]).ToString().ToUpper().Trim(), true);
                                            break;
                                        }
                                    }
                                }
                                _oReader3.Close();
                                _oReader3.Dispose();
                            }
                        }
                    }
                }
            }
        }
    }
    #endregion

    public void load_hl()
    {
        JavascriptHolder _oJavascriptHolder = new JavascriptHolder(this.Page);
        MobileRetentionOrder _oMobileRetentionOrder = (MobileRetentionOrder)MobileRetentionOrderRepository.CreateEntityInstanceObject();
        _oMobileRetentionOrder.SetOrder_id(Convert.ToInt32(Func.IDSubtract100000(WebFunc.qsOrder_id)));
        if (!_oMobileRetentionOrder.Retrieve()) return;
        _oJavascriptHolder.AppendLine("<script>");
        _oJavascriptHolder.AppendLine("function load_hl(){");
        if (_oMobileRetentionOrder.GetNext_bill() == true)
        {
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"next_bill\")!=undefined)  document.getElementById(\"form1\").next_bill.value = \"1\";");
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"con_eff_date\")!=undefined)  document.getElementById(\"form1\").con_eff_date.disabled = true;");
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"con_eff_date\")!=undefined)  document.getElementById(\"form1\").con_eff_date.className=\"disablerow\";");
            _oJavascriptHolder.AppendLine("temp_con_eff_date = \"\";");
        }
        else
        {
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"next_bill\")!=undefined)  document.getElementById(\"form1\").next_bill.value = \"\";");
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"con_eff_date\")!=undefined)  temp_con_eff_date = document.getElementById(\"form1\").con_eff_date.value;");
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"con_eff_date\")!=undefined)  document.getElementById(\"form1\").con_eff_date.disabled = false;");
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"con_eff_date\")!=undefined)  document.getElementById(\"form1\").con_eff_date.className=\"highlightrow\";");
        }

        if (_oMobileRetentionOrder.GetPlan_eff().Equals("Next Bill Date") || _oMobileRetentionOrder.GetNext_bill() == true)
        {
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"plan_eff_0\")!=undefined)  document.getElementById(\"form1\").plan_eff_0.checked = true;");
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"plan_eff_date\")!=undefined)  	document.getElementById(\"form1\").plan_eff_date.disabled = true");
            //_oJavascriptHolder.AppendLine("if(document.getElementById(\"plan_eff_date\")!=undefined)  document.getElementById(\"form1\").plan_eff_date.value = \"\"");
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"plan_eff_date\")!=undefined)  	document.getElementById(\"form1\").plan_eff_date.style.background=\"#DDDDDD\";");
        }
        else
        {
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"plan_eff_1\")!=undefined)  document.getElementById(\"form1\").plan_eff_1.checked = true;");
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"plan_eff_date\")!=undefined)  document.getElementById(\"form1\").plan_eff_date.disabled = false");
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"plan_eff_date\")!=undefined)  	document.getElementById(\"form1\").plan_eff_date.style.background=\"#FFFFFF\";");

        }

        if (!_oMobileRetentionOrder.GetHs_model().Equals(string.Empty))
        {
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"div_next_bill\")!=undefined)  document.getElementById(\"div_next_bill\").style.visibility = \"hidden\";");
        }
        if (_oMobileRetentionOrder.GetProgram().Equals("NETVIGATOR EVERYWHERE"))
        {
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"pcd_paid_go_wireless_show\")!=undefined)  document.getElementById(\"pcd_paid_go_wireless_show\").style.display = 'inline';");
        }
        else
        {
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"pcd_paid_go_wireless_show\")!=undefined)  document.getElementById(\"pcd_paid_go_wireless_show\").style.display = 'none';");
        }
        if (_oMobileRetentionOrder.GetChannel().Trim() != "IB")
        {
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"fast_start\")!=undefined)  document.getElementById(\"form1\").fast_start.disabled = true;");
        }
        int _iPlan_fee;
        RetentionPlanEntity[] _oRetentionPlanArr = RetentionPlanBal.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), "active=1 AND plan_code='" + _oMobileRetentionOrder.GetRate_plan() + "'", null, null);
        if (_oRetentionPlanArr != null)
        {
            if (_oRetentionPlanArr.Length >= 1)
            {
                if (_oRetentionPlanArr[0].plan_fee != null)
                {
                    string _sPlan_fee = ((double)_oRetentionPlanArr[0].plan_fee).ToString();
                    if (int.TryParse(_sPlan_fee, out _iPlan_fee))
                    {
                        if (_iPlan_fee < 198)
                        {
                            _oJavascriptHolder.AppendLine("if(document.getElementById(\"now_hd_vas\")!=undefined)  document.getElementById(\"form1\").now_hd_vas.disabled = true");
                        }
                    }
                }
            }
        }

        _oJavascriptHolder.AppendLine("if(document.getElementById(\"now_vas\")!=undefined && document.getElementById(\"now_hd_vas\")!=undefined){");
        _oJavascriptHolder.AppendLine("var now_vas=document.getElementById(\"now_vas\");");
        _oJavascriptHolder.AppendLine("var now_hd_vas=document.getElementById(\"now_hd_vas\");");
        _oJavascriptHolder.AppendLine("");
        _oJavascriptHolder.AppendLine("if(now_vas.value==\"YES\" || now_vas.value==\"50%\"){");
        _oJavascriptHolder.AppendLine("now_hd_vas.disabled = true");
        _oJavascriptHolder.AppendLine("}");
        _oJavascriptHolder.AppendLine("");
        _oJavascriptHolder.AppendLine("if(now_hd_vas.value==\"YES\"){");
        _oJavascriptHolder.AppendLine("now_vas.disabled = true");
        _oJavascriptHolder.AppendLine("}");
        _oJavascriptHolder.AppendLine("}");

        /*
        if (_oMobileRetentionOrder.GetHs_model().Equals("PCCW LG KP275 BLACK") && _oMobileRetentionOrder.GetAmount().Trim().Equals("0"))
        {
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"s_premium2\")!=undefined) document.getElementById(\"form1\").s_premium2.disabled = true;");
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"s_premium2\")!=undefined) document.getElementById(\"form1\").s_premium2.value = \"\";");
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"s_premium2\")!=undefined) document.getElementById(\"form1\").s_premium2.style.background=\"#DDDDDD\";");
            _oJavascriptHolder.AppendLine("alert(\"請注意: 若現有3G客戶已享用LG KP275 $0 upfront 手機優惠，不能同時享用Family Pack 優惠\");");

        }
        else
        {
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"s_premium2\")!=undefined) document.getElementById(\"form1\").s_premium2.disabled = false");
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"s_premium2\")!=undefined) document.getElementById(\"form1\").s_premium2.style.background=\"#FFFFbb\";");
        }
        */

        if (_oMobileRetentionOrder.GetNormal_rebate_type().Equals("RETENTION+") || _oMobileRetentionOrder.GetProgram().Equals("GO WIRELESS TOO(UPSELL)"))
        {
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"lob\")!=undefined) document.getElementById(\"form1\").lob.disabled = false");
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"lob\")!=undefined) 		document.getElementById(\"form1\").lob.style.background=\"#FFFFbb\";");
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"lob_ac\")!=undefined) 		document.getElementById(\"form1\").lob_ac.disabled = false");
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"lob_ac\")!=undefined) 		document.getElementById(\"form1\").lob_ac.style.background=\"#FFFFbb\";");
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"go_wireless_package_code\")!=undefined) 		document.getElementById(\"form1\").go_wireless_package_code.disabled = false");
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"go_wireless_package_code\")!=undefined) 		document.getElementById(\"form1\").go_wireless_package_code.style.background=\"#FFFFbb\";");
        }
        else
        {
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"lob\")!=undefined) document.getElementById(\"form1\").lob.disabled = true");
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"lob\")!=undefined) 		document.getElementById(\"form1\").lob.style.background=\"#DDDDDD\";");
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"lob_ac\")!=undefined) 		document.getElementById(\"form1\").lob_ac.disabled = true");
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"lob_ac\")!=undefined) 		document.getElementById(\"form1\").lob_ac.style.background=\"#DDDDDD\";");
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"go_wireless_package_code\")!=undefined) 		document.getElementById(\"form1\").go_wireless_package_code.disabled = true");
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"go_wireless_package_code\")!=undefined) 		document.getElementById(\"form1\").go_wireless_package_code.style.background=\"#DDDDDD\";");
        }

        if (_oMobileRetentionOrder.GetPcd_paid_go_wireless() == true)
        {
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"lob\")!=undefined) document.getElementById(\"form1\").lob.disabled = false;");
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"lob\")!=undefined) 		document.getElementById(\"form1\").lob.style.background=\"#FFFFbb\";");
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"lob_ac\")!=undefined) 		document.getElementById(\"form1\").lob_ac.disabled = false;");
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"lob_ac\")!=undefined) 		document.getElementById(\"form1\").lob_ac.style.background=\"#FFFFbb\";");
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"go_wireless_package_code\")!=undefined) 		document.getElementById(\"form1\").go_wireless_package_code.disabled = false;");
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"go_wireless_package_code\")!=undefined) 		document.getElementById(\"form1\").go_wireless_package_code.style.background=\"#FFFFbb\";");
        }
        else
        {
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"lob\")!=undefined) document.getElementById(\"form1\").lob.disabled = true;");
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"lob\")!=undefined) 		document.getElementById(\"form1\").lob.style.background=\"#DDDDDD\";");
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"lob_ac\")!=undefined) 		document.getElementById(\"form1\").lob_ac.disabled = true;");
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"lob_ac\")!=undefined) 		document.getElementById(\"form1\").lob_ac.style.background=\"#DDDDDD\";");
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"go_wireless_package_code\")!=undefined) 		document.getElementById(\"form1\").go_wireless_package_code.disabled = true;");
            _oJavascriptHolder.AppendLine("if(document.getElementById(\"go_wireless_package_code\")!=undefined) 		document.getElementById(\"form1\").go_wireless_package_code.style.background=\"#DDDDDD\";");
        }

        _oJavascriptHolder.AppendLine("}");
        _oJavascriptHolder.AppendLine("</script>");

        load_hl_holder.Text = _oJavascriptHolder.ToScript();
    }



    public void GiftDisabled()
    {
        //gift_desc1
        if (gift_code.Value != string.Empty || hs_model.SelectedValue.Equals(string.Empty) || _iDeli_flag == 0)
        {
            SetHtmlControlAtt("gift_desc1", HtmlTextWriterAttribute.Disabled, "true", false);
            SetHtmlControlAtt("gift_imei", HtmlTextWriterAttribute.Disabled, "true", false);

            gift_desc1.Enabled = false;
        }
        else
        {
            SetHtmlControlAtt("gift_desc1", HtmlTextWriterAttribute.Disabled, "false", false);
            SetHtmlControlAtt("gift_imei", HtmlTextWriterAttribute.Disabled, "false", false);
            gift_desc1.Enabled = true;
        }


        if (!string.IsNullOrEmpty(gift_code2.Value) || string.IsNullOrEmpty(hs_model.SelectedValue) || _iDeli_flag == 0)
        {
            SetHtmlControlAtt("gift_desc21", HtmlTextWriterAttribute.Disabled, "true", false);
            SetHtmlControlAtt("gift_imei2", HtmlTextWriterAttribute.Disabled, "true", false);
            gift_desc21.Enabled = false;
        }
        else
        {
            SetHtmlControlAtt("gift_desc21", HtmlTextWriterAttribute.Disabled, "false", false);
            SetHtmlControlAtt("gift_imei2", HtmlTextWriterAttribute.Disabled, "true", false);
            gift_desc21.Enabled = true;
        }

        if (!string.IsNullOrEmpty(gift_code3.Value) || string.IsNullOrEmpty(hs_model.SelectedValue) || _iDeli_flag == 0)
        {
            SetHtmlControlAtt("gift_desc31", HtmlTextWriterAttribute.Disabled, "true", false);
            SetHtmlControlAtt("gift_imei3", HtmlTextWriterAttribute.Disabled, "true", false);
            gift_desc31.Enabled = false;
        }
        else
        {
            SetHtmlControlAtt("gift_desc31", HtmlTextWriterAttribute.Disabled, "false", false);
            SetHtmlControlAtt("gift_imei3", HtmlTextWriterAttribute.Disabled, "false", false);
            gift_desc31.Enabled = true;
        }



        /////////////////////////////////


        //gift_desc4


        if (!string.IsNullOrEmpty(gift_code4.Value) || string.IsNullOrEmpty(hs_model.SelectedValue) || _iDeli_flag == 0)
        {
            SetHtmlControlAtt("gift_desc41", HtmlTextWriterAttribute.Disabled, "true", false);
            SetHtmlControlAtt("gift_imei4", HtmlTextWriterAttribute.Disabled, "true", false);
            gift_desc41.Enabled = false;
        }
        else
        {
            SetHtmlControlAtt("gift_desc41", HtmlTextWriterAttribute.Disabled, "false", false);
            SetHtmlControlAtt("gift_imei4", HtmlTextWriterAttribute.Disabled, "false", false);
            gift_desc41.Enabled = true;
        }
    }

    protected void CopyRegisteredAddToDeliveryAdd()
    {
        if (RegisteredAddressControl != null && RegisteredAddressControl.Enabled == true)
        {
            string _sD_address = string.Empty;
            MobileOrderAddress _oMobileOrderAddress = new MobileOrderAddress();
            _oMobileOrderAddress.SetD_type(RegisteredAddressControl.D_type.SelectedValue.ToString());
            _oMobileOrderAddress.SetD_room(RegisteredAddressControl.D_room.Text);
            _oMobileOrderAddress.SetD_floor(RegisteredAddressControl.D_floor.Text);
            _oMobileOrderAddress.SetD_blk(RegisteredAddressControl.D_blk.Text);
            _oMobileOrderAddress.SetD_build(RegisteredAddressControl.D_build.Text);
            _oMobileOrderAddress.SetD_street(RegisteredAddressControl.D_street.Text);
            _oMobileOrderAddress.SetD_district(RegisteredAddressControl.D_district.SelectedValue.ToString());
            _oMobileOrderAddress.SetD_region(RegisteredAddressControl.D_region.SelectedValue.ToString());
            _oMobileOrderAddress.SetFound(true);
            _sD_address = MobileOrderAddressBal.GetAddress(_oMobileOrderAddress);

            d_address.Value = _sD_address;
        }
    }


    protected void CopyRegisterAddToDeliveryAdd_Click(object sender, EventArgs e)
    {
        CopyRegisteredAddToDeliveryAdd();
    }
    protected void pool_SelectedIndexChanged(object sender, EventArgs e)
    {
        CNMobileNumberDataBind();
    }
}


