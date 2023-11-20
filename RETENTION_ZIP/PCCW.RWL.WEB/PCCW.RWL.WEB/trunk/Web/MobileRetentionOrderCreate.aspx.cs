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
using System.Globalization;
using System.Text;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using NEURON.WEB.UI.HTMLCONTROL.JSCONTROL;
using log4net;
using System.Reflection;
using NEURON.ENTITY.FRAMEWORK.STOCK;

public partial class MobileRetentionOrderCreate : NEURON.WEB.UI.BasePage
{
    #region SessionUid
    string n_sSessionUid
    {
        get
        {
            if (Session["uid"] != null)
            {
                return Session["uid"].ToString();
            }
            else
                return string.Empty;
        }
    }
    #endregion

    #region SessionLv
    string n_sSessionLv
    {
        get
        {
            if (Session["lv"] != null)
            {
                return Session["lv"].ToString();
            }
            else
                return string.Empty;
        }
    }
    #endregion

    #region SessionArprog
    string n_sSessionArprog
    {
        get
        {
            if (Session["arprog"] != null)
            {
                return Session["arprog"].ToString();
            }
            else
                return string.Empty;
        }
    }
    #endregion

    #region SessionChannel
    string n_sSessionChannel
    {
        get
        {
            if (Session["channel"] != null)
            {
                return Session["channel"].ToString();
            }
            else
                return string.Empty;
        }
    }
    #endregion

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
    VasViewerController n_oVasViewerController = new VasViewerController();
    List<TierSelectionItem> n_oTierSelectionItem = new List<TierSelectionItem>();
    bool n_bLockTierTop = false;
    bool n_bIsAutoSelection = false;
    Dictionary<string, bool> n_oVasShowList = new Dictionary<string, bool>();
    StringBuilder RegisterJSScript = new StringBuilder();
    bool _bVasAutoDefaultSet = false;
    #endregion

    #region Page Load
    protected void Page_Load(object sender, EventArgs e)
    {

        CheckOrderLock();
        if (ViewState["autoselection"] != null) { n_bIsAutoSelection = (bool)ViewState["autoselection"]; }
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

        //WebFunc.PrivilegeCheck(this.Page);
        RWLFramework.InitModel();
        if (n_bIsAutoSelection)
            n_oTierSelectionItem = AutoSelectionBusinessTradeHelper.GetTierSelectionList(RWLFramework.CurrentUser[this.Page].Uid.ToString());
        else
            n_oTierSelectionItem = new List<TierSelectionItem>();
        
        RegisterAsyncPostBackControl();
        
        if (!IsPostBack)
        {
            InitJSControl();
            GiftHtmlVasCreate();
            BindData();
            AllPageInScreen.Value = Func.RQ(Request["AllPageInScreen"]).Trim().ToString();
            string _sAutoSelection = Func.RQ(Request["AutoSelection"]).Trim().ToString();
            n_bIsAutoSelection = (_sAutoSelection.Equals("on") || _sAutoSelection.Equals("1")) ? true : false;
            ViewState["autoselection"] = n_bIsAutoSelection;
            if (!"".Equals(mrt_no.Value) && n_bIsAutoSelection)
            {
                if (bInCallList(mrt_no.Value))
                {

                }
            }
            if (AllPageInScreen.Value.Equals("on") || AllPageInScreen.Value.Equals("1"))
            {
                menutable.Style[HtmlTextWriterStyle.Display] = "none";
                RegisterJSScript.AppendLine("ShowTable('TBL1', 'Tab1');");
                RegisterJSScript.AppendLine("ShowTable('TBL2', 'Tab2');");
                RegisterJSScript.AppendLine("ShowTable('TBL3', 'Tab3');");
                RegisterJSScript.AppendLine("ShowTable('TBL4', 'Tab4');");
                RegisterJSScript.AppendLine("ShowTable('TBL5', 'Tab5');");
            }
            else
            {
                RegisterJSScript.AppendLine("HideAllTable();");
                RegisterJSScript.AppendLine("ShowTable('TBL1','Tab1');");
            }
            RegisteredBillingAddress3rdPartyFormView(issue_type.Value);
            if (VasAutoSetScript.Instance().VasSetScript.ContainsKey(issue_type.Value) && !
                issue_type.Value.Equals(string.Empty))
            {
                VasSetScript.Text = VasAutoSetScript.Instance().VasSetScript[issue_type.Value].ToString();
            }
        }

        CheckPlanFeeShow();
        ImeiInputPermitted();
        
        RegisterJSScript.AppendLine("DRegionHiddenAutoSave()");
        Ajax.Utility.RegisterTypeForAjax(typeof(MobileRetentionOrderCreate));
        JSCeksOnClickInit();
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
        RegisterJSScript.AppendLine("TierNoLoad()");
    }
    #endregion

    protected void RegisteredBillingAddress3rdPartyFormView(string x_sIssue_type)
    {
        if (x_sIssue_type == "UPGRADE" || x_sIssue_type=="WIN")
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
            MobileOrderThreePartyControl.Enable = true;
        }
        else
        {
            date_of_birth_show.Style[HtmlTextWriterStyle.Display] = "none";
            RegisteredAddressControl.Enabled = false;
            BillingAddressControl.Enabled = false;
            MobileOrderMNPDetailControl.Enabled = false;
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
                        string _sMsg = string.Format("Now user id: {0} is issuing the mobile number({1}) order in an other Retention Web Log session.", _oMobileOrderLock.Owner, mrt_no.Value);
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
        Session["IssueOrder"] = "IssueOrder";
    }
    
    

    #region InitJSControl
    protected void InitJSControl()
    {
        NeuronJSLibrary.Text = JSScriptLibrary.JSScriptCommon;
        JSController _oJSController = new JSController();
        _oJSController.exist_cust_plan = new JS_SELECT("exist_cust_plan", "SELECT");
        _oJSController.org_fee = new JS_SELECT("org_fee", "SELECT");
        ViewState["JSController"] = _oJSController;
    }
    #endregion

    #region PostProcess
    protected void PostProcess_Click(object sender, EventArgs e)
    {
        switch (PostBackState.Value)
        {
            case "exist_cust_plan_SelectedIndexChanged":
                exist_cust_plan_changed();
                break;
        }
        PostBackState.Value = string.Empty;
        PostHideValue.Value = string.Empty;
        
    }
    #endregion

    #region AllUpdatePanelUpdate
    protected void AllUpdatePanelUpdate()
    {
        CustomerDetailUpdatePanelUpdate();
        OfferUpdatePanelUpdate();
        DeliveryUpdatePanelUpdate();
        RemarksUpdatePanelUpdate();
    }

    public void CustomerDetailUpdatePanelUpdate()
    {
        JSController _oJSController = (JSController)ViewState["JSController"];
        update_panel_cust_name.Update();
        update_panel_id_type.Update();
        RegisterJSScript.AppendLine(_oJSController.ToScript(true, false));
        update_panel_action_required.Update();
        ViewState["JSController"] = _oJSController;
    }

    public void OfferUpdatePanelUpdate()
    {
        update_panel_accept.Update();
        update_panel_accessory_code.Update();
        update_panel_accessory_desc1.Update();
        update_panel_accessory_imei.Update();
        update_panel_aig_gift.Update();
        update_panel_bill_cut_date.Update();
        update_panel_bill_cut_num.Update();
        update_panel_trade_field.Update();
        update_panel_bundle_name.Update();
        update_panel_cancel_renew.Update();
        update_panel_con_eff_date.Update();
        update_panel_con_per.Update();
        update_panel_go_wireless_package_code.Update();
        update_panel_cust_staff_no.Update();
        update_panel_easywatch_type.Update();
        update_panel_extra_rebate.Update();
        update_panel_extra_rebate_amount4.Update();
        update_panel_extra_rebate4.Update();
        update_panel_free_mon.Update();
        update_panel_gift_code.Update();
        update_panel_gift_code2.Update();
        update_panel_gift_code3.Update();
        update_panel_gift_code4.Update();
        update_panel_gift_desc1.Update();
        update_panel_gift_desc21.Update();
        update_panel_gift_desc31.Update();
        update_panel_gift_desc41.Update();
        update_panel_gift_imei.Update();
        update_panel_gift_imei2.Update();
        update_panel_gift_imei3.Update();
        update_panel_gift_imei4.Update();
        update_panel_hs_model.Update();

        update_panel_lob.Update();
        update_panel_lob_ac.Update();
        update_panel_m_card_exp.Update();
        update_panel_m_card_holder2.Update();
        update_panel_m_card_no.Update();
        update_panel_m_card_type.Update();
        update_panel_monthly_payment_method.Update();
        update_panel_normal_rebate_list.Update();
        update_panel_ord_place_by.Update();
        update_panel_ord_place_id_type.Update();
        update_panel_ord_place_rel.Update();
        update_panel_ord_place_tel.Update();

        update_panel_org_mrt.Update();
        update_panel_plan_eff_date.Update();
        update_panel_plan_fee.Update();
        update_panel_premium.Update();
        update_panel_program.Update();
        update_panel_r_offer4.Update();
        update_panel_rate_plan.Update();
        update_panel_rebate_amount.Update();
        update_panel_s_premium.Update();
        update_panel_s_premium1.Update();
        update_panel_s_premium2.Update();
        update_panel_special_approval.Update();

        update_panel_sku.Update();

    }

    public void DeliveryUpdatePanelUpdate()
    {
        update_panel_delivery.Update();
    }

    public void RemarksUpdatePanelUpdate()
    {
        update_panel_no_opt_out.Update();
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
            update_panel_gift_imei.Update();
            update_panel_gift_imei2.Update();
            update_panel_gift_imei3.Update();
            update_panel_gift_imei4.Update();
            update_panel_accessory_imei.Update();
        }
    }
    #endregion



    #region Submit Gw Click
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
        preferred_languages.Enabled = x_bValue;
        //SetHtmlControlStyle("waiving_show", HtmlTextWriterStyle.Display, _sValue2, true);
        //SetHtmlControlStyle("existing_customer_type_show", HtmlTextWriterStyle.Display, _sValue2, true);
        //SetHtmlControlStyle("original_tariff_fee_show", HtmlTextWriterStyle.Display, _sValue2, true);
        SetHtmlControlStyle("ob_program_id_show", HtmlTextWriterStyle.Display, _sValue2, true);
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
            program_selected_change();
            ajaxvas();

            if (rate_plan.Items.Count > 0)
                rate_plan.SelectedIndex = 1;

            rate_plan_selected_change();
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
        SetHtmlControlStyle("register_address_show", HtmlTextWriterStyle.Display, _sValue, true);

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
        JSController _oJSController = (JSController)ViewState["JSController"];
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

                if (_oArrD.Contains("given_name"))
                {
                    given_name.Value = _oArrD["given_name"].ToString();
                    _oJSController.given_name.Value = _oArrD["given_name"].ToString();
                }

                if (_oArrD.Contains("ac_no"))
                {
                    ac_no.Value = _oArrD["ac_no"].ToString();
                    _oJSController.ac_no.Value = _oArrD["ac_no"].ToString();
                }
                if (_oArrD.Contains("id_type"))
                {
                    id_type.Value = _oArrD["id_type"].ToString();
                    _oJSController.id_type.Value = _oArrD["id_type"].ToString();
                }
                if (_oArrD.Contains("HKID1"))
                {
                    hkid.Value = _oArrD["HKID1"].ToString();
                    _oJSController.hkid.Value = _oArrD["HKID1"].ToString();
                }
                if (_oArrD.Contains("HKID2"))
                {
                    hkid2.Value = _oArrD["HKID2"].ToString();
                    _oJSController.hkid2.Value = _oArrD["HKID2"].ToString();
                }
                if (_oArrD.Contains("exist_cust_plan"))
                {
                    if (exist_cust_plan.Items.Contains(new ListItem(_oArrD["exist_cust_plan"].ToString(), _oArrD["exist_cust_plan"].ToString())))
                    {
                        exist_cust_plan.Value = _oArrD["exist_cust_plan"].ToString();
                        _oJSController.exist_cust_plan.Value = _oArrD["exist_cust_plan"].ToString();
                    }
                }
                if (_oArrD.Contains("ob_program_id"))
                {
                    SetHtmlControlValue("ob_program_id", _oArrD["ob_program_id"].ToString(), true);
                }
                if (_oArrD.Contains("org_fee"))
                {
                    if (org_fee.Items.Contains(new ListItem(_oArrD["org_fee"].ToString(), _oArrD["org_fee"].ToString())))
                    {
                        org_fee.Value = _oArrD["org_fee"].ToString();
                        _oJSController.exist_cust_plan.Value = _oArrD["org_fee"].ToString();
                    }
                }
            }
            else
            {
                RegisterJSScript.AppendLine("alert(\"This MRT is invalid\");");
                org_mrt.Value = string.Empty;
                RegisterJSScript.AppendLine("delivery_style(\"no\");");
                submit_gw.Enabled = true;
                org_mrt.Attributes["readonly"] = "false";
                org_mrt.Attributes.Remove("readonly");
            }
        }
        RegisterJSScript.AppendLine("NoLoadChkGW()");
        update_panel_org_mrt.Update();
        CustomerDetailUpdatePanelUpdate();
        RegisterJSScript.AppendLine(_oJSController.ToScript(true, false));
        ViewState["JSController"] = _oJSController;
    }
    #endregion

    #region CheckPlanFeeShow
    public void CheckPlanFeeShow()
    {
        bool _bShow = false;
        bool _bAutoSelected = false;
        string _sGW = Func.RQ(Request["GW"]).ToString();

        if (ViewState["AutoSelected"] != null)
            _bAutoSelected = (bool)ViewState["AutoSelected"];


        if (rate_plan.SelectedValue == "3GHSDPA0098B" || rate_plan.SelectedValue == "3GHSDPA0488A" || rate_plan.SelectedValue == "3GHSDPA0488A-(UPSELL)" || rate_plan.SelectedValue == "3GHSDPA0498A")
        {
            _bShow = true;
        }
        else
        {
            _bShow = false;
        }

        if ((_bShow || _bAutoSelected) && n_bIsAutoSelection)
        {
            RegisterJSScript.AppendLine("ShowPlanFee();");
            RegisterJSScript.AppendLine("ShowTier();");
        }
        else
        {
            RegisterJSScript.AppendLine("HidePlanFee();");
            RegisterJSScript.AppendLine("HiddenTier()");
        }

        if (issue_type.Value.Trim().ToUpper().Equals("GO_WIRELESS"))
            RegisterJSScript.AppendLine("ShowPlanFee()");
        else if (program.SelectedValue.ToUpper().Equals("GO WIRELESS"))
            RegisterJSScript.AppendLine("ShowPlanFee()");
    }
    #endregion

    #region is it in call list
    protected bool bInCallList(string x_sMrt_no)
    {
        x_sMrt_no = x_sMrt_no.Trim();
        if (x_sMrt_no.Equals(string.Empty)) { return false; }

        string _sQuery = "[CRM_SP_GET_CUSTINFO_by_MRT]";
        MSSQLConnect DB = GetDB();
        SqlConnection _oConn = DB.GetConnection();
        SqlCommand _oCmd = new SqlCommand(_sQuery, _oConn);
        _oCmd.Parameters.Clear();
        bool _bResult = false;
        global::System.Data.SqlClient.SqlParameter _oPar;
        try
        {
            _oPar = _oCmd.Parameters.Add("@mrt", global::System.Data.SqlDbType.NVarChar, 8);
            _oPar.Direction = global::System.Data.ParameterDirection.Input;
            _oPar.Value = x_sMrt_no;
            _oCmd.CommandType = CommandType.StoredProcedure;
            _oConn.Open();
            SqlDataReader _oDr = _oCmd.ExecuteReader();
            if (_oDr.Read())
            {
                
                given_name.Value = Func.FR(_oDr["cust_name"]).ToString();
                string _sHkid = Func.FR(_oDr["hkid"]).ToString();
                if (_sHkid.Length > 7)
                {
                    hkid.Value = _sHkid.Substring(0, 7);
                    hkid2.Value = _sHkid.Substring(7, 1);
                }
                d_build.Value = Func.FR(_oDr["cust_address"]).ToString();
                _bResult = true;
            }
            _oDr.Close();

        }
        catch (Exception exp) { string _sError = exp.ToString(); }
        finally
        {
            _oConn.Close();
            _oCmd.Dispose();
            _oConn.Dispose();
        }
        return _bResult;
        /*

        Crm_rpt_2G_action_rpt_GLRepository _oCrm_rpt_2G_action_rpt_GLRepository = new Crm_rpt_2G_action_rpt_GLRepository(GetCRMDB());
        IQueryable<Crm_rpt_2G_action_rpt_GLEntity> _oCrm_rpt_List = (from sItemList in _oCrm_rpt_2G_action_rpt_GLRepository.Crm_rpt_2G_action_rpt_GLs
                                                                     where
                                                                     sItemList.mobile_no == x_sMrt_no
                                                                     select sItemList).Take<Crm_rpt_2G_action_rpt_GLEntity>(1);
        if (_oCrm_rpt_List.Count<Crm_rpt_2G_action_rpt_GLEntity>() > 0)
        {

            given_name.Value = _oCrm_rpt_List.First<Crm_rpt_2G_action_rpt_GLEntity>().customer_name_formartted;
            return true;
        }
        else
            return false;
        */

    }
    #endregion

    #region Plan Fee Selected
    protected void PlanFeeSelected(int x_sSel)
    {
        if (plan_fee.Items.Count == 0) return;
        if (x_sSel > (plan_fee.Items.Count - 1)) return;
        if (n_bIsAutoSelection)
        {
            c_tier();
            plan_fee.SelectedIndex = x_sSel;
            if (ViewState["PlanFeeDrpList"] != null)
            {
                Hashtable _oPlanFeeDrpList = (Hashtable)ViewState["PlanFeeDrpList"];
                if (_oPlanFeeDrpList.Contains(plan_fee.SelectedValue.ToString().Trim()))
                {
                    List<string> _sItemPlanFeeTier = (List<string>)_oPlanFeeDrpList[plan_fee.SelectedValue.ToString().Trim()];

                }
            }
        }
    }
    #endregion





    #region ProgramListBindData
    protected void ProgramListBindData()
    {
        string _sMobileLevelDesc = string.Empty;
        IQueryable<BusinessTradeEntity> _oRwlTradeBaseList = FromRegisterControler.Get_ProgramList(mrt_no.Value.ToString(), ref _sMobileLevelDesc,issue_type.Value);
        program.Items.Clear();
        program.Items.Add(new ListItem(string.Empty, string.Empty));
        if (_oRwlTradeBaseList.Count<BusinessTradeEntity>() > 0)
        {
            List<string> _oPrograms = _oRwlTradeBaseList.Select(c => c.program).Distinct().ToList();
            for (int i = 0; i < _oPrograms.Count; i++)
            {
                if (n_sISSUE_TYPE == "MOBILE_LITE")
                {
                    if (_oPrograms[i].ToString() == "MOBILE LITE (SIM ONLY)" || _oPrograms[i].ToString() == "MOBILE LITE (HS OFFER)")
                    {
                        program.Items.Add(new ListItem(_oPrograms[i].ToString(), _oPrograms[i].ToString()));
                    }
                }
                else if (n_sISSUE_TYPE != "GO_WIRELESS" && n_sISSUE_TYPE != "MOBILE_LITE" && 
                    _oPrograms[i].ToString() != "GO WIRELESS" && 
                    (_oPrograms[i].ToString() != "MOBILE LITE (SIM ONLY)" && _oPrograms[i].ToString() != "MOBILE LITE (HS OFFER)")
                    )
                {
                    program.Items.Add(new ListItem(_oPrograms[i].ToString(), _oPrograms[i].ToString()));
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
        JSController _oJSController = (JSController)ViewState["JSController"];
        IQueryable<TariffFeeScheduleEntity> _oRwlTariffFeeList = FromRegisterControler.Get_ExistCustomerType();
        _oJSController.exist_cust_plan.Items.Clear();
        _oJSController.exist_cust_plan.Items.Add(new JS_LISTITEM(string.Empty, string.Empty));
        if (_oRwlTariffFeeList.Count<TariffFeeScheduleEntity>() > 0)
        {
            List<string> _oPrograms = _oRwlTariffFeeList.Select(r => r.program).Distinct().ToList();
            for (int i = 0; i < _oPrograms.Count; i++)
            {
                _oJSController.exist_cust_plan.Items.Add(new JS_LISTITEM(_oPrograms[i].ToString().ToUpper(), _oPrograms[i].ToString().ToUpper()));
            }
        }
        RegisterJSScript.AppendLine(_oJSController.ToScript(true, false));
        ViewState["JSController"] = _oJSController;
    }

    protected void exist_cust_plan_changed()
    {
        //Checked
        JSController _oJSController = (JSController)ViewState["JSController"];
        if ((0).Equals(_oJSController.exist_cust_plan.Items.Count)) return;
        _oJSController.exist_cust_plan.Value = PostHideValue.Value;
        IQueryable<TariffFeeScheduleEntity> _oRwlTariffFeeList = FromRegisterControler.Get_OrgFeeList(_oJSController.exist_cust_plan.Value);
        _oJSController.org_fee.Items.Clear();
        _oJSController.org_fee.Items.Add(new JS_LISTITEM(string.Empty, string.Empty));
        if (_oRwlTariffFeeList.Count<TariffFeeScheduleEntity>() > 0)
        {
            List<string> _oFees = _oRwlTariffFeeList.Select(r => r.fee).Distinct().ToList();
            for (int i = 0; i < _oFees.Count; i++)
            {
                _oJSController.org_fee.Items.Add(new JS_LISTITEM(_oFees[i].ToString(), _oFees[i].ToString()));
            }
        }

            RegisterJSScript.AppendLine(_oJSController.ToScript(true, false));
        RegisterJSScript.AppendLine("OrgFeeListNoLoad();");

        ViewState["JSController"] = _oJSController;
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
            _sPlan_fee = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar("SELECT top 1 plan_fee FROM RetentionPlan WITH (NOLOCK) WHERE plan_code='" + _sRate_plan + "' AND active=1");
            plan_fee.SelectedValue = _sPlan_fee.Trim();
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
        update_panel_rebate_amount.Update();
        update_panel_r_offer4.Update();
        update_panel_hs_model.Update();
        update_panel_premium.Update();
        update_panel_bundle_name.Update();
        update_panel_rebate.Update();
        update_panel_free_mon.Update();
        update_panel_s_premium.Update();
        update_panel_sku.Update();
        update_panel_premium.Update();
        update_panel_trade_field.Update();
        update_panel_bundle_name.Update();
        update_panel_rebate.Update();
        update_panel_gift_desc1.Update();
        update_panel_gift_desc21.Update();
        update_panel_accessory_desc1.Update();
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

        CheckPlanFeeShow();
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

    protected void rate_plan_selected_change()
    {
        c_tier_sel_top();
        rate_plan_changed();
        RegisterJSScript.AppendLine("ConListNoLoad()");
        update_panel_rebate_amount.Update();
        update_panel_r_offer4.Update();
        update_panel_hs_model.Update();
        update_panel_premium.Update();
        update_panel_trade_field.Update();
        update_panel_bundle_name.Update();
        update_panel_rebate.Update();
        update_panel_free_mon.Update();
        update_panel_s_premium.Update();
        update_panel_special_approval.Update();
        update_panel_trade_field.Update();
        update_panel_con_per.Update();
        update_panel_plan_fee.Update();

    }

    protected void rate_plan_SelectedIndexChanged(object sender, EventArgs e)
    {
        rate_plan_selected_change();
        PreLoadAutoVasSet();
        _bVasAutoDefaultSet = true;
    }
    #endregion

    #region plan_fee Selected Chanaged
    protected void plan_fee_changed()
    {
        if (plan_fee.Items.Count > 0)
        {
            PlanFeeSelected(plan_fee.SelectedIndex);

        }
        if (n_bIsAutoSelection)
        {

        }
        RegisterJSScript.AppendLine("PlanFeeNoLoad()");
        OfferUpdatePanelUpdate();
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
        update_panel_trade_field.Update();
        update_panel_bundle_name.Update();

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
        


        delivery_exchange_location.Value = FromRegisterControler.GetProductionItemLocation(issue_type.Value, program.SelectedValue, sku.Value).Trim();
        SetHtmlControlValue("delivery_exchange_location", delivery_exchange_location.Value, true);
        RegisterJSScript.AppendLine("add_amount()");
        RegisterJSScript.AppendLine("ChkFreeGiftStatus()");
        ch_delivery();
        RegisterJSScript.AppendLine("ChkFreeGiftStatus()");
        ajaxvas();
        RegisterJSScript.AppendLine("click_nextbillcutdate(document.getElementById('hs_model').value);");

    }

    protected void hs_model_selected_change()
    {
        c_tier_sel_top();
        hs_model_changed();
        RegisterJSScript.AppendLine("TradeHsListNoLoad()");
        //RegisterJSScript.AppendLine("chk_hs_sp2();");
        update_panel_sku.Update();
        update_panel_trade_field.Update();
        update_panel_bundle_name.Update();
        update_panel_rebate_amount.Update();
        update_panel_hs_offer_type_id.Update();
        update_panel_r_offer4.Update();
        update_panel_extra_rebate.Update();
        update_panel_extra_rebate4.Update();
        update_panel_extra_rebate_amount4.Update();
        update_panel_s_premium1.Update();
        update_panel_s_premium2.Update();
        update_panel_hs_model.Update();

        SetHtmlControlValue("amount", amount.Value, true);
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
        update_panel_sku.Update();
        update_panel_trade_field.Update();
        update_panel_bundle_name.Update();
        update_panel_rebate_amount.Update();
        update_panel_hs_offer_type_id.Update();
        update_panel_r_offer4.Update();
        update_panel_extra_rebate.Update();
        update_panel_extra_rebate4.Update();
        update_panel_extra_rebate_amount4.Update();
        update_panel_s_premium1.Update();
        update_panel_s_premium2.Update();
        update_panel_hs_model.Update();
 
        
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
            
        }
        RegisterJSScript.AppendLine("add_amount()");
        

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
        update_panel_rebate_amount.Update();
        update_panel_r_offer4.Update();
        update_panel_extra_rebate.Update();
        update_panel_extra_rebate_amount4.Update();

        SetHtmlControlValue("amount", amount.Value.ToString(), true);
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

        
        c_hs_model();
        c_trade_field();
        c_bundle_name();
        c_premium();

        if ("".Equals(_sProgram) && !(new RebateGroup()).GetProgramTable().GetIsNullable()) return;
        List<string> _oHandSetList = RWLFramework.Control<HandSetEnvironment>().Get_DrpHandSetList(_sProgram, _sCon_per, _sRate_plan, _sPlan_fee, _sNormal_rebate_type, _sChannel,issue_type.Value);


        for (int i = 0; i < _oHandSetList.Count; i++)
        {
            hs_model.Items.Add(new ListItem(_oHandSetList[i].ToString().ToUpper(), _oHandSetList[i].ToString().ToUpper()));
        }


        for (int i = 0; i < _oHandSetList.Count; i++)
        {
            hs_model.Items.Add(new ListItem(_oHandSetList[i].ToString().ToUpper(), _oHandSetList[i].ToString().ToUpper()));
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
        List<string> _oPremiumList = RWLFramework.Control<RebateProfileControler>().Get_DrpPremiumList(_sProgram, _sCon_per, _sPlan_fee_rs, _sRebate, _sNormal_rebate_type, _sChannel,issue_type.Value);

        for (int i = 0; i < _oPremiumList.Count; i++)
        {
            premium.Items.Add(new ListItem(_oPremiumList[i].ToString().ToUpper(), _oPremiumList[i].ToString().ToUpper()));
        }

        ajaxvas();
        //hs_model.Enabled = !_bDisabledHandSet;
        //premium.Enabled = !_bDisabledPremium;
    }

    protected void rebate_selected_change()
    {
        c_tier_sel_top();
        rebate_changed();
        RegisterJSScript.AppendLine("TradeRListNoLoad()");
        update_panel_free_mon.Update();
        update_panel_trade_field.Update();
        update_panel_bundle_name.Update();
        update_panel_premium.Update();

    }

    protected void rebate_SelectedIndexChanged(object sender, EventArgs e)
    {
        rebate_selected_change();
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
        List<string> _oTradeFieldList = FromRegisterControler.Get_TradeFieldList(_sProgram, _sCon_per, _sPlan_fee_rs, _sRate_plan, _sRebate, _sNormal_rebate_type, _sChannel, _sHs_model, _sPremium, _sFree_mon,ref _bDisabledHandSet,ref _bDisabledPremium,issue_type.Value);
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
        update_panel_rebate.Update();
        update_panel_trade_field.Update();
        update_panel_bundle_name.Update();
        update_panel_premium.Update();
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
        update_panel_sim_item.Update();
        //ch_delivery();
        update_panel_rebate_amount.Update();

    }

    protected static string[,] check_sim_number_avaliable(string[,] x_sArrSim_item_name, string x_sSim_no)
{
        StringBuilder _oSearch = new StringBuilder();
        _oSearch.AppendLine("select reserve, count(sim_no) numberOfSim from sunday_sim_no where ");
        _oSearch.AppendLine("reserve in (");    
        for (int i=0; i<x_sArrSim_item_name.Length; i=i+2)
        {
            if (i != 0) _oSearch.AppendLine(",");
            _oSearch.AppendLine("'" + x_sArrSim_item_name[i/2,0]+ "'");
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
    public static string check_sim_number_for_js(string x_sSim_item_name, string x_sSim_item_code, string x_sSim_item_number)
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
        }else{
            string _sNew_imei = get_first_avaliable_sim_item_number(x_sSim_item_code);
            _sResult = (_sNew_imei == string.Empty ? "0" : _sNew_imei);
        }
        return _sResult;
    }

    protected void check_sim_number_clicked()
    {
        string _sSim_item_name = ((sim_item_name1.Items.Count > 0) ? sim_item_name1.SelectedValue.ToString() : string.Empty);
        int i =0;
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
                    _sArrSim_item_name[i, 0] = sim_item_name1.Items[i].Value.ToString() ;
                    _sArrSim_item_name[i, 1] = "0";
                }
            }

            _sArrSim_item_name = check_sim_number_avaliable(_sArrSim_item_name, "");
            StringBuilder _oAlertMsg = new StringBuilder();
            _oAlertMsg.Append("alert('");
            for (int j =(i==1?0:1); j < i; j++)
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

        if (x_sIssue_type == "UPGRADE" || x_sIssue_type=="WIN")
        {
            RegisterJSScript.AppendLine("UserControlVisible('monthly_3rd_party_credit_card_info_show',true);");
        }
        else
        {
            RegisterJSScript.AppendLine("UserControlVisible('monthly_3rd_party_credit_card_info_show',false);");
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
            easywatch_type.Enabled = false;
            easywatch_type.SelectedIndex = -1;
        }
        else
        {
            SetHtmlControlStyle("easywatch_type_show", HtmlTextWriterStyle.Display, "inline", true);
            easywatch_ord_id.Disabled = false;
            easywatch_ord_id.Value = string.Empty;
            easywatch_type.Enabled = true;
            easywatch_type.SelectedIndex = -1;
        }

        MonthPaymentMethodChange(program.SelectedValue, issue_type.Value);
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

        for (int i = 0; i < _oRate_Plan_List.Count; i++)
        {
            rate_plan.Items.Add(new ListItem(_oRate_Plan_List[i].ToString().ToUpper().ToUpper(), _oRate_Plan_List[i].ToString().ToUpper()));
        }
        if (rate_plan.Items.Count > 0) { rate_plan.SelectedIndex = 0; }
        ch_delivery();

        delivery_exchange_location.Value = FromRegisterControler.GetProductionItemLocation(issue_type.Value, program.SelectedValue, sku.Value).Trim();
        SetHtmlControlValue("delivery_exchange_location", delivery_exchange_location.Value, true);

    }



    protected void program_selected_change()
    {
        plan_fee.SelectedIndex = -1;
        c_tier_sel_top();
        ProgramRelChanged();
        update_panel_sku.Update();
 
        ajaxvas();
        RegisterJSScript.AppendLine("PlanListNoLoad()");
        RegisterJSScript.AppendLine("ShowPCDGoWirelessTooChk()");
        update_panel_cust_staff_no.Update();
        update_panel_easywatch_type.Update();
        update_panel_rebate_amount.Update();
        update_panel_r_offer4.Update();
        update_panel_trade_field.Update();
        update_panel_bundle_name.Update();
        update_panel_hs_model.Update();
        update_panel_premium.Update();
        update_panel_con_per.Update();
        update_panel_rebate.Update();
        update_panel_free_mon.Update();
        update_panel_s_premium.Update();
        update_panel_rate_plan.Update();
        update_panel_s_premium1.Update();
        update_panel_s_premium2.Update();


        PreLoadAutoVasSet();

    }

    protected void program_SelectedIndexChanged(object sender, EventArgs e)
    {
        program_selected_change();
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
        update_panel_cust_staff_no.Update();
        update_panel_easywatch_type.Update();
        update_panel_rebate_amount.Update();
        update_panel_r_offer4.Update();
        update_panel_trade_field.Update();
        update_panel_bundle_name.Update();
        update_panel_hs_model.Update();
        update_panel_premium.Update();
        update_panel_con_per.Update();
        update_panel_rebate.Update();
        update_panel_free_mon.Update();
        update_panel_s_premium.Update();
        update_panel_rate_plan.Update();
        update_panel_s_premium1.Update();
        update_panel_s_premium2.Update();
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
        ch_g_code();
        ch_g_type();
        ch_a_code();
        if (n_sISSUE_TYPE == "MOBILE_LITE")
            vaild_date("MOBILE_LITE");
        else
            vaild_date("");


        SetHtmlControlStyle("ac_no_show", HtmlTextWriterStyle.Display, "none",true);
        SetHtmlControlStyle("existing_customer_type_show", HtmlTextWriterStyle.Display, "none", true);
        SetHtmlControlStyle("original_tariff_fee_show", HtmlTextWriterStyle.Display, "none", true);
        SetHtmlControlStyle("existing_contract_end_month_show", HtmlTextWriterStyle.Display, "none", true);


        vaild_amount();
        delivery_exchange_location.Attributes["readonly"] = "readonly";
        issue_type.Value = n_sISSUE_TYPE;

        n_oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
        n_oStaffinfo_new = new Staffinfo_new(n_oDB);
        if (Request["mrt"] != null)
        {
            mrt_no.Value = Request["mrt"].ToString();
            sms_mrt.Value = Request["mrt"].ToString();
        }
        else
            Response.Redirect("MobileRetentionOrderAddView.aspx");

        log_date.Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        log_date.Attributes["readonly"] = "true";
        if (RWLFramework.CurrentUser[this.Page].Lv.ToString() == "10" || RWLFramework.CurrentUser[this.Page].Lv.ToString() == "30" || RWLFramework.CurrentUser[this.Page].Lv.ToString() == "65535")
        {
            //vip_case.ReadOnly = true;
        }
        //Sale info should be selected from saleinfo

        string _sSalemancode = string.Empty;
        string _sStaff_name = string.Empty;
        string _sTeamcode = string.Empty;
        string _sChannel = string.Empty;
        string _sTl_name = string.Empty;
        string _sExtn = string.Empty;

        OdbcDataReader _oDr = GetORDB().GetSearch("select extn,salename,salecode from saleinfo where saleid1 = '" + RWLFramework.CurrentUser[this.Page].Uid + "'");
        if (_oDr != null)
        {
            if (_oDr.Read())
            {
                _sExtn = Func.FR(_oDr["extn"]).Trim().Replace(" ",string.Empty);
                _sSalemancode = Func.FR(_oDr["salecode"]).Trim();
                _sStaff_name = Func.FR(_oDr["salename"]).Trim();
            }
        }
        _oDr.Close();
        _oDr.Dispose();

        Staffinfo_new _oStaffinfo_new = RWLFramework.Control<FromRegisterControler>().Get_StaffInfoEntity(RWLFramework.CurrentUser[this.Page].Uid);
        if (_sSalemancode.Trim() == string.Empty) _sSalemancode = _oStaffinfo_new.GetSalesman_code();
        if (_sStaff_name.Trim() == string.Empty) _sStaff_name = _oStaffinfo_new.GetStaff_name();
        _sTeamcode = _oStaffinfo_new.GetTeamcode();
        _sTl_name = RWLFramework.Control<FromRegisterControler>().Get_TeamLeader_By_TeamCode(_sTeamcode);
        _sChannel = RWLFramework.Control<FromRegisterControler>().Get_Channel_By_TeamCode(_sTeamcode);

        salesmancode.Value = _sSalemancode;
        staff_name.Value = _sStaff_name;
        teamcode.Value = _sTeamcode;
        extn.Value = _sExtn;
        channel.Value = _sChannel;
        tl_name.Value = _sTl_name;


        staff_no.Value = RWLFramework.CurrentUser[this.Page].Uid.ToString();

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


        if (
           RWLFramework.CurrentUser[this.Page].Lv.ToString() == "10" ||
           RWLFramework.CurrentUser[this.Page].Lv.ToString() == "65535" ||
            ChkIssueChangeStaffInfo()
           )
            ch_cust_button.Style[HtmlTextWriterStyle.Display] = "inline";
        else
            ch_cust_button.Style[HtmlTextWriterStyle.Display] = "none";
        
        family_name.Disabled = false;
        given_name.Disabled = false;

        con_eff_date.Value = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy");
        ch_delivery();
        //d_region_hidden
        MonthPaymentMethodChange(string.Empty, issue_type.Value);

        if(issue_type.Value=="2G_RETENTION")
            remarks2edf_show.Style[HtmlTextWriterStyle.Display] = "none";
        else
            remarks2edf_show.Style[HtmlTextWriterStyle.Display] = "inline";

    }
    #endregion

    protected bool ChkIssueChangeStaffInfo()
    {
        if (RWLFramework.CurrentUser[this.Page].Uid.Equals("1020874") || 
            RWLFramework.CurrentUser[this.Page].Uid.Equals("A3150498") || 
            RWLFramework.CurrentUser[this.Page].Uid.Equals("1038371") || 
            RWLFramework.CurrentUser[this.Page].Uid.Equals("1147214") || 
            RWLFramework.CurrentUser[this.Page].Uid.Equals("1161892") || 
            RWLFramework.CurrentUser[this.Page].Uid.Equals("1022243") || 
            RWLFramework.CurrentUser[this.Page].Uid.Equals("A3150515") || 
            RWLFramework.CurrentUser[this.Page].Uid.Equals("A8350006") || 
            RWLFramework.CurrentUser[this.Page].Uid.Equals("80441694") || 
            RWLFramework.CurrentUser[this.Page].Uid.Equals("1268507") || 
            RWLFramework.CurrentUser[this.Page].Uid.Equals("A2180025") || 
            RWLFramework.CurrentUser[this.Page].Uid.Equals("A4180011") || 
            RWLFramework.CurrentUser[this.Page].Uid.Equals("A8180055") || 
            RWLFramework.CurrentUser[this.Page].Uid.Equals("A9180015 ") 
            )
        {
            return true;
        }
        return false;
    }

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
                bank_name.Items.Add(new ListItem(_oReader["bank_name"].ToString().ToUpper(), _oReader["bank_name"].ToString().ToUpper()));
            }
        }
        if (_oReader != null) { _oReader.Close(); _oReader.Dispose(); }
    }
    #endregion

    #region DistrictList
    public void DistrictListBindData()
    {
        SqlDataReader _oReader = FromRegisterControler.Get_District_DataReader();
        d_district.Items.Clear();
        d_district.Items.Add(new ListItem(string.Empty, string.Empty));
        if (_oReader != null)
        {
            while (_oReader.Read())
            {
                d_district.Items.Add(new ListItem(_oReader["location"].ToString().ToUpper(), _oReader["location"].ToString().ToUpper()));
            }
        }
        if (_oReader != null) { _oReader.Close(); _oReader.Dispose(); }
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
        ShowGoWireLess();
        HandSetOfferTypeDataBind();
        BankCodeArrScriptInit();
        MonthlyPaymentTypeDataBind();
        PayMethodDataBind();
        CNMobileNumberDataBind();
        UpgradeOrderInit();
        WinOrderInit();
        OfferAutomation();
    }
    #endregion

    protected void OfferAutomation()
    {
        string _sTrade_field_id = Func.RQ(Request["auto_trade_field_id"]);
        if (!string.IsNullOrEmpty(_sTrade_field_id))
        {
            StringBuilder _oQuery=new StringBuilder();
            _oQuery.Append("SELECT * FROM BusinessTrade WHERE mid="+_sTrade_field_id+" ");
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
            if (_oDr.Read())
            {
                string _sProgram = Func.FR(_oDr[BusinessTrade.Para.program]);
                string _sRetention = Func.FR(_oDr[BusinessTrade.Para.normal_rebate_type]);
                string _sRate_plan = Func.FR(_oDr[BusinessTrade.Para.trade_field]);
                string _sCon_per = Func.FR(_oDr[BusinessTrade.Para.con_per]);
                string _sPlan_fee = Func.FR(_oDr[BusinessTrade.Para.plan_fee]);
                string _sRebate = Func.FR(_oDr[BusinessTrade.Para.rebate]);
                string _sHs_model = Func.FR(_oDr[BusinessTrade.Para.hs_model_name]);
                string _sPremium_1 = Func.FR(_oDr[BusinessTrade.Para.premium_1]);
                string _sPremium_2 = Func.FR(_oDr[BusinessTrade.Para.premium_2]);
                string _sTrade_field = Func.FR(_oDr[BusinessTrade.Para.trade_field]);
                string _sBundle_name = Func.FR(_oDr[BusinessTrade.Para.bundle_name]);

                DropListSelectedValue(ref program, _sProgram);
                program_selected_change();
                DropListSelectedValue(ref normal_rebate_type, _sRetention);
                normal_rebate_type_selected_change();
                DropListSelectedValue(ref rate_plan, _sRate_plan);
                rate_plan_selected_change();
                DropListSelectedValue(ref con_per, _sCon_per);
                con_per_selected_change();
                DropListSelectedValue(ref plan_fee, _sPlan_fee);
                plan_fee_changed();
                DropListSelectedValue(ref rebate, _sRebate);
                rebate_selected_change();
                DropListSelectedValue(ref hs_model, _sHs_model);
                hs_model_selected_change();
                DropListSelectedValue(ref s_premium1, _sPremium_1);
                DropListSelectedValue(ref s_premium2, _sPremium_2);
                DropListSelectedValue(ref trade_field, _sTrade_field);
                DropListSelectedValue(ref bundle_name, _sBundle_name);
                PreLoadAutoVasSet();
            }
            _oDr.Close();
            _oDr.Dispose();
        }
    }

    protected void UpgradeOrderInit()
    {
        upgrade_existing_contract_sdate.Attributes["readonly"] = "readonly";
        upgrade_existing_contract_edate.Attributes["readonly"] = "readonly";
        issue_type.Value = n_sISSUE_TYPE;
        SetHtmlControlValue("issue_type", n_sISSUE_TYPE, true);
    }

    protected void WinOrderInit()
    {
        upgrade_existing_contract_sdate.Attributes["readonly"] = "readonly";
        upgrade_existing_contract_edate.Attributes["readonly"] = "readonly";
        issue_type.Value = n_sISSUE_TYPE;
        SetHtmlControlValue("issue_type", n_sISSUE_TYPE, true);
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
            .Add(DsExpression.Eq(BusinessVas.Para.active, 1))
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
    public void ObCreate()
    {
        if (!IsPostBack)
        {
            if (RWLFramework.CurrentUser[this.Page].Channel == "OB" || RWLFramework.CurrentUser[this.Page].Lv == "65535")
            {
                ob_program_id_show.Visible = true;
                Response.Write("<input type=\"button\" class=\"buttonlink-washed\" name=\"prog_id_btn\" value=\"Check\" onclick=\"check_program_id()\"  style=\"font-size:8pt\"/> ");
                Response.Write("<input name=\"ob_program_id\" type=\"text\" id=\"ob_program_id\" size=\"5\"  class=\"highlightrow\" maxlength=\"4\" style=\"font-size:12pt\"  value=\"\" onBlur=\"chg_upper(this);\"/>");
            }
            else
            {
                ob_program_id_show.Visible = false;
                Response.Write("<input name=\"ob_program_id\" type=\"hidden\" id=\"ob_program_id\" size=\"5\" maxlength=\"4\" style=\"font-size:8pt\" onBlur=\"chg_upper(this);\"/>");
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
        _oVasCreateHolderControl.Span1_FontSize = "12pt";

        _oVasCreateHolderControl.Td2_height = "28";
        _oVasCreateHolderControl.Td2_class = "row1";
        _oVasCreateHolderControl.Td2_colspan = "3";
        _oVasCreateHolderControl.Span2_class = "gensmall";
        _oVasCreateHolderControl.Span2_FontSize = "12pt";

        _oVasCreateHolderControl.Drp1_FontSize = "12pt";
        _oVasCreateHolderControl.Drp2_FontSize = "12pt";

        GiftHtmlVasCreate_Literal.Text = _oVasCreateHolderControl.ReBuildHtmlVasControl(false, 0, 0);

    }
  
    #endregion



    protected void s_premium_SelectedIndexChanged(object sender, EventArgs e)
    {
        c_tier_sel_top();
        RegisterJSScript.AppendLine("SPremiumNoLoad();");

    }
    protected void s_premium1_SelectedIndexChanged(object sender, EventArgs e)
    {
        RegisterJSScript.AppendLine("SPremium1NoLoad();");
    }

    protected void s_premium2_SelectedIndexChanged(object sender, EventArgs e)
    {

        //RegisterJSScript.AppendLine("ch_mobileOne_premium2();");
        RegisterJSScript.AppendLine("SPremium2NoLoad();");
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

    protected void d_district_change()
    {
        RWLFramework.Control<DeliveryTimeTrackable>().InitDeliveryTime(string.Empty, string.Empty, d_district.SelectedValue);
        d_time.Items.Clear();
        d_time.Items.Add(new ListItem(string.Empty, string.Empty));
        extra_d_charge.Value = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar("SELECT TOP 1 fee from DeliveryLocation WHERE location='" + d_district.SelectedValue.Replace("'","''") + "' ");
        List<string> _oTimeList = DeliveryTimeTrackable.GetDeliveryTimeList(d_district.SelectedValue.Replace("'", "''"));
        for (int i = 0; i < _oTimeList.Count; i++)
            d_time.Items.Add(new ListItem(_oTimeList[i].ToString(), _oTimeList[i].ToString()));

        if (extra_d_charge.Value == string.Empty) extra_d_charge.Value = "0";
        RegisterJSScript.AppendLine("NoLoadDDistrictTime()");
        DeliveryUpdatePanelUpdate();
    }

    protected void d_district_SelectedIndexChanged(object sender, EventArgs e)
    {
        d_district_change();
    }

    protected void d_region_change()
    {
        if (d_region.SelectedIndex != -1)
        {
            d_district.Items.Clear();
            d_district.Items.Add(new ListItem(string.Empty, string.Empty));
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT location FROM DeliveryLocation WHERE area='" + d_region.SelectedValue + "' ");
            while (_oDr.Read())
            {
                d_district.Items.Add(new ListItem(Func.FR(_oDr["location"]), Func.FR(_oDr["location"])));
            }
            _oDr.Close();
            _oDr.Dispose();
        }
        RegisterJSScript.AppendLine("DistrictNoLoad()");
        DeliveryUpdatePanelUpdate();
    }

    protected void d_region_SelectedIndexChanged(object sender, EventArgs e)
    {
        d_region_change();
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
        if (action_required.Checked) { c_tier_sel_top(); }
        update_panel_action_required.Update();

    }
    protected void action_required2_CheckedChanged(object sender, EventArgs e)
    {
        action_required.Checked = false;
        RegisterJSScript.AppendLine("en_action_opt()");
        RegisterJSScript.AppendLine("c_all_opt()");
        if (action_required.Checked) { c_tier_sel_top(); }
        update_panel_action_required.Update();

    }

    protected void go_wireless_SelectedIndexChanged(object sender, EventArgs e)
    {
        RegisterJSScript.AppendLine("wireless();");
        ISimMrtControlEntityRepository _oSimMrtControl = new SimMrtControl();
        _oSimMrtControl.SetUid(RWLFramework.CurrentUser[this.Page].Uid);
        if (go_wireless.SelectedValue != "NO" && go_wireless.SelectedValue != "")
        {
            string _sResult = _oSimMrtControl.GetSimMrt();
            if (!_sResult.Equals("NO MRT"))
            {
                //sim_mrt.Value = _sResult;
                //mrt_no.Value = _sResult;
                SetHtmlControlValue("sim_mrt", _sResult.ToString(), true);
                SetHtmlControlValue("mrt_no", _sResult.ToString(), true);
                RegisterJSScript.AppendLine("delivery_style(\"yes\");");
                //show_third_party.Visible = true;
                SetHtmlControlStyle("show_third_party", HtmlTextWriterStyle.Display, "inline", true);
                ch_delivery();
            }
            else
            {
                RegisterJSScript.AppendLine("alert('NO MRT');");
                if (go_wireless.Items.Contains(new ListItem("NO")))
                    go_wireless.SelectedValue = "NO";
                RegisterJSScript.AppendLine("delivery_style(\"no\");");
                //show_third_party.Visible = false;
                SetHtmlControlStyle("show_third_party", HtmlTextWriterStyle.Display, "none", true);
            }
        }
        else
        {
            _oSimMrtControl.SetDelete("YES");
            _oSimMrtControl.SetMrt(sim_mrt.Value);
            string _sResult = _oSimMrtControl.GetSimMrt();
            SetHtmlControlValue("sim_mrt", string.Empty, true);
            SetHtmlControlValue("mrt_no", string.Empty, true);

            RegisterJSScript.AppendLine("delivery_style(\"no\");");
            //show_third_party.Visible = false;
            SetHtmlControlStyle("show_third_party", HtmlTextWriterStyle.Display, "none", true);
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

            given_name.Attributes["readonly"] = "true";
            family_name.Attributes["readonly"] = "true";

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
        update_panel_easywatch_type.Update();
        update_panel_cust_name.Update();
        update_panel_id_type.Update();



    }
    #endregion

    #region Clear Polled Down
    protected void c_org_fee()
    {
        JSController _oJSController = (JSController)ViewState["JSController"];
        _oJSController.org_fee.Items.Clear();
        _oJSController.org_fee.Items.Add(new JS_LISTITEM(string.Empty, string.Empty));
        RegisterJSScript.AppendLine(_oJSController.ToScript(true, false));
        ViewState["JSController"] = _oJSController;
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
    protected void c_hs_offer_type_id()
    {
        hs_offer_type_id.Items.Clear();
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
    protected void c_free_mon()
    {
        free_mon.Items.Clear();
        free_mon.Items.Add(new ListItem(string.Empty, string.Empty));
    }
    #endregion


    #region ch_delivery
    public void ch_delivery()
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

        if ("".Equals(hs_model.SelectedValue) &&
            (issue_type.Value != "UPGRADE" && issue_type.Value != "WIN") &&
            "".Equals(sim_item_name1.SelectedValue)
            && (go_wireless.SelectedValue == "" || go_wireless.SelectedValue == "NO"))
        {
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
            
            d_type.Enabled = false;
            d_room.Disabled = true;
            d_floor.Disabled = true;
            d_blk.Disabled = true;

            d_build.Disabled = true;
            d_street.Disabled = true;
            d_district.Enabled = false;
            d_region.Enabled = false;

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

            d_type.SelectedValue = string.Empty;
            d_room.Value = string.Empty;
            d_floor.Value = string.Empty;
            d_blk.Value = string.Empty;
            d_build.Value = string.Empty;
            d_street.Value = string.Empty;
            d_district.SelectedValue = string.Empty;

            d_region.SelectedIndex = -1;

            d_time.SelectedValue = string.Empty;
            extra_d_charge.Value = string.Empty;
            contact_person.Value = string.Empty;
            contact_no.Value = string.Empty;
            ext_place_tel.Value = string.Empty;
            pay_method.SelectedValue = string.Empty;
            remarks2EDF.Value = string.Empty;
            d_date.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            d_type.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            d_room.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            d_floor.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            d_blk.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            d_build.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            d_district.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            d_street.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";

            d_region.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            //d_region_0.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            //d_region_1.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            //d_region_2.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            //d_region_3.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";

            d_district.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
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
            remarks2EDF.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            dis_card();

            premium.Enabled = true;
            free_mon.Enabled = true;
            rebate.Enabled = true;
        }
        else
        {
            if (!_bGiftFlag) { gift_desc1.Enabled = true; }
            if (!_bGiftFlag2) { gift_desc21.Enabled = true; }
            if (!_bGiftFlag3) { gift_desc31.Enabled = true; }
            if (!_bGiftFlag4) { gift_desc41.Enabled = true; }
            if (!_bAccessoryFlag4) { accessory_desc1.Enabled = true; }

            d_type.Enabled = true;
            d_room.Disabled = false;
            d_floor.Disabled = false;
            d_blk.Disabled = false;

            d_build.Disabled = false;
            d_street.Disabled = false;
            d_district.Enabled = true;
            d_region.Enabled = true;

            d_date.Enabled = true;
            d_time.Enabled = true;
            extra_d_charge.Disabled = false;
            contact_person.Disabled = false;
            contact_no.Disabled = false;
            MobileOrderThreePartyControl.Enabled = true;
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
            d_region.SelectedIndex = -1;

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
            d_type.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            d_room.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            d_floor.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            d_blk.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            d_build.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            d_street.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            d_district.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            d_region.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            
            //d_region_0.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            //d_region_1.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            //d_region_2.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
            //d_region_3.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
             
            d_district.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFF";
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
                rebate_amount4.Enabled = false;
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
        DeliveryUpdatePanelUpdate();
        update_panel_sku.Update();
        update_panel_hs_model.Update();
        update_panel_rebate_amount.Update();
        update_panel_r_offer4.Update();
        update_panel_rebate.Update();
        update_panel_premium.Update();
        update_panel_free_mon.Update();
        update_panel_rebate.Update();
        update_panel_extra_rebate_amount4.Update();
        update_panel_gift_desc1.Update();
        update_panel_gift_desc21.Update();
        update_panel_gift_desc31.Update();
        update_panel_gift_desc41.Update();
        update_panel_accessory_desc1.Update();
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
            /*
            card_no1.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            card_no2.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            card_no3.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            card_no4.Style[HtmlTextWriterStyle.BackgroundColor] = "#DDDDDD";
            */
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
            card_no.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFFbb";
            /*
            card_no1.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFbb";
            card_no2.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFbb";
            card_no3.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFbb";
            card_no4.Style[HtmlTextWriterStyle.BackgroundColor] = "#FFFFbb";
             */
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
        DeliveryUpdatePanelUpdate();
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
        update_panel_lob.Update();
        update_panel_lob_ac.Update();
        update_panel_go_wireless_package_code.Update();

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

        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT distinct gift_code,gift_desc FROM " + Configurator.MSSQLTablePrefix + "GiftBasket WITH (nolock) WHERE active=1");
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

        _oJavascriptHolder.AppendLine("if (AccessoryDescDrpObj.value == \"SAMSUNG NP-N135 (6 CELL/WHITE COLOR/XP HOME)\" && (RatePlanObj.value == \"3GHSDPA0328A-(NB)MOB\" || RatePlanObj.value == \"3GHSDPA0328A-(NB)NET\"  || RatePlanObj.value == \"3GHSDPA0358A-(NB)\")) {");
        _oJavascriptHolder.AppendLine("AccessoryPriceObj.value=2499");
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
        _sScript = string.Format("if(ChkID('{0}'))GetID('{1}').selectedIndex={2};", x_sID, x_sID,x_iSel.ToString());

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
       // AddWebLogScriptManager.RegisterAsyncPostBackControl(action_required);
       // AddWebLogScriptManager.RegisterAsyncPostBackControl(action_required2);

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
        AddWebLogScriptManager.RegisterAsyncPostBackControl(d_district);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(d_time);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(pay_method);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(bank_code);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(easywatch_type);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(d_region);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(submit_gw);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(go_wireless);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(hs_offer_type_id);
        AddWebLogScriptManager.RegisterAsyncPostBackControl(PostProcess);
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

    #region RadioButtonSelectedValue
    public void RadioListSelectedValue(ref RadioButtonList x_oRab, string x_sValue)
    {
        bool _bFlag = false;
        for (int i = 0; i < x_oRab.Items.Count; i++)
        {
            if (x_oRab.Items[i].Value.ToUpper().Trim() == x_sValue.ToUpper().Trim())
            {
                x_oRab.SelectedIndex = i;
                x_oRab.SelectedValue = x_sValue;
                _bFlag = true;
            }
        }

        if (!_bFlag && !x_sValue.Trim().Equals(string.Empty))
        {
            x_oRab.Items.Add(new ListItem(x_sValue, x_sValue));
            x_oRab.SelectedValue = x_sValue;
        }
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

    protected void CopyRegisteredAddToDeliveryAdd()
    {
        if (RegisteredAddressControl != null && RegisteredAddressControl.Enabled == true)
        {
            d_type.Items.Clear();
            for (int i = 0; i < RegisteredAddressControl.D_type.Items.Count; i++)
                d_type.Items.Add(RegisteredAddressControl.D_type.Items[i]);

            DropListSelectedValue(ref d_type, RegisteredAddressControl.D_type.SelectedValue);

            d_room.Value = RegisteredAddressControl.D_room.Text;
            d_floor.Value = RegisteredAddressControl.D_floor.Text;
            d_blk.Value = RegisteredAddressControl.D_blk.Text;
            d_build.Value = RegisteredAddressControl.D_build.Text;
            d_street.Value = RegisteredAddressControl.D_street.Text;

            d_district.Items.Clear();
            for (int i = 0; i < RegisteredAddressControl.D_district.Items.Count; i++)
                d_district.Items.Add(RegisteredAddressControl.D_district.Items[i]);

            DropListSelectedValue(ref d_district, RegisteredAddressControl.D_district.SelectedValue);

            d_region.Items.Clear();
            for (int i = 0; i < RegisteredAddressControl.D_region.Items.Count; i++)
                d_region.Items.Add(RegisteredAddressControl.D_region.Items[i]);

            if (RegisteredAddressControl.D_region.SelectedValue != "")
                RadioListSelectedValue(ref d_region, RegisteredAddressControl.D_region.SelectedValue);

            d_region_hidden.Value = d_region.SelectedValue;
            d_district_change();
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
