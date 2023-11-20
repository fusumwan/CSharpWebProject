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
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;


public partial class RecordOrderViewRow : System.Web.UI.UserControl
{
    Nullable<int> n_iOrder_id = -1;
    MobileRetentionOrderRepositoryBase n_oMobileRetentionOrderRepositoryBase = null;
    MSSQLConnect n_oDB = new MSSQLConnect();
    EDFStatusProfile _oEDFStatusProfile = new EDFStatusProfile();
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    #region Set Order id
    public void SetOrderid(int x_iOrder)
    {
        n_iOrder_id = x_iOrder;
    }
    #endregion

    protected string GetBillMedium(string x_sMedium)
    {
        string _sResult = string.Empty;
        switch (x_sMedium)
        {
            case "0":
                _sResult = "SMS bill $0";
                break;
            case "1":
                _sResult = "Email bill $0";
                break;
            case "2":
                _sResult = "Paper bill $10";
                break;
            case "3":
                _sResult = "SMS bill $0 + Email bill $0";
                break;
        }
        return _sResult;
    }

    protected string GetRegion(string x_sRegion){
        string _sResult = string.Empty;
        switch (x_sRegion)
        {
            case "0":
                _sResult = "HK";
                break;
            case "1":
                _sResult = "KLN";
                break;
            case "2":
                _sResult = "NT";
                break;
            case "3":
                _sResult = "LT";
                break;
        }
        return _sResult;
    }

    #region LoadOrder
    public void LoadOrder()
    {
        if (n_iOrder_id != -1)
        {
            if (n_iOrder_id == null) throw new InvalidOperationException("n_iOrder_id");
            n_oMobileRetentionOrderRepositoryBase = new MobileRetentionOrderRepositoryBase(GetDB());
            webid.Text = Func.IDAdd100000(n_iOrder_id).ToString();
            IQueryable<MobileRetentionOrderEntity> _sMobileRetentionOrderList = (from sMobileRetentionOrderList in n_oMobileRetentionOrderRepositoryBase.MobileRetentionOrders where sMobileRetentionOrderList.order_id == n_iOrder_id select sMobileRetentionOrderList).Take(1);

            if (_sMobileRetentionOrderList.Count<MobileRetentionOrderEntity>() > 0)
            {
                MobileRetentionOrderEntity _oMobileRetentionOrderEntity = _sMobileRetentionOrderList.First<MobileRetentionOrderEntity>();
                old_ord_id.Text = Func.IDAdd100000(_oMobileRetentionOrderEntity.GetOld_ord_id()).ToString();
                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetEdf_no()))
                    edf_no.Text = _oMobileRetentionOrderEntity.GetEdf_no().ToString();

                if (_oMobileRetentionOrderEntity.GetLog_date() != null)
                    log_date.Text = ((DateTime)_oMobileRetentionOrderEntity.GetLog_date()).ToString("dd/MM/yyyy HH:mm");

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetLanguage()))
                    language.Text = _oMobileRetentionOrderEntity.GetLanguage();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetCust_type()))
                    cust_type.Text = _oMobileRetentionOrderEntity.GetCust_type().ToString();

                if (!string.IsNullOrEmpty(MobileRetentionOrder.GetCustomerName(_oMobileRetentionOrderEntity)))
                    cust_name.Text = MobileRetentionOrder.GetCustomerName(_oMobileRetentionOrderEntity).ToString();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetGender()))
                    gender.Text = _oMobileRetentionOrderEntity.GetGender().ToString();

                if (_oMobileRetentionOrderEntity.GetDate_of_birth() != null)
                    date_of_birth.Text = ((DateTime)_oMobileRetentionOrderEntity.GetDate_of_birth()).ToString("dd/MM/yyyy");


                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetAc_no()))
                    ac_no.Text = _oMobileRetentionOrderEntity.GetAc_no().ToString();

                if (_oMobileRetentionOrderEntity.GetMrt_no() != null)
                    mrt_no.Text = _oMobileRetentionOrderEntity.GetMrt_no().ToString();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetHkid()))
                {
                    if (_oMobileRetentionOrderEntity.GetHkid().Length >= 4)
                        hkid.Text = _oMobileRetentionOrderEntity.GetHkid().Substring(0, 4) + "****";
                }



                MobileOrderAddress _oRegisteredAddress = new MobileOrderAddress(SYSConn<MSSQLConnect>.Connect(), _oMobileRetentionOrderEntity.GetOrder_id(), "REGISTERED_ADDRESS");
                if (_oRegisteredAddress != null)
                {
                    registered_address.Text =
                        _oRegisteredAddress.d_type + " "
                        + _oRegisteredAddress.d_room + " "
                        + _oRegisteredAddress.d_floor + " "
                        + _oRegisteredAddress.d_blk + " "
                        + _oRegisteredAddress.d_build + " "
                        + _oRegisteredAddress.d_street + " "
                        + _oRegisteredAddress.d_district + " " + GetRegion(_oRegisteredAddress.d_region);
                }


                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetBill_medium()))
                    bill_medium.Text = GetBillMedium(_oMobileRetentionOrderEntity.GetBill_medium());

                if (_oMobileRetentionOrderEntity.GetBill_medium_waive() == true)
                    bill_medium_waive.Text = "TRUE";
                else
                    bill_medium_waive.Text = "FALSE";

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetBill_medium_email()))
                    bill_medium_email.Text = _oMobileRetentionOrderEntity.GetBill_medium_email();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetSms_mrt()))
                    sms_mrt.Text = _oMobileRetentionOrderEntity.GetSms_mrt();

                MobileOrderAddress _oBillingAddress = new MobileOrderAddress(SYSConn<MSSQLConnect>.Connect(), _oMobileRetentionOrderEntity.GetOrder_id(), "BILLING_ADDRESS");
                if (_oBillingAddress != null)
                {
                    billing_address.Text =
                        _oBillingAddress.d_type + " "
                        + _oBillingAddress.d_room + " "
                        + _oBillingAddress.d_floor + " "
                        + _oBillingAddress.d_blk + " "
                        + _oBillingAddress.d_build + " "
                        + _oBillingAddress.d_street + " "
                        + _oBillingAddress.d_district + " " + GetRegion(_oBillingAddress.d_region);
                }

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetVip_case()))
                    vip_case.Text = _oMobileRetentionOrderEntity.GetVip_case();

                if (_oMobileRetentionOrderEntity.GetWaive() != null)
                    waive.Text = ((true).Equals((bool)_oMobileRetentionOrderEntity.GetWaive())) ? "Y" : "N";

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetExist_cust_plan()))
                    exist_cust_plan.Text = _oMobileRetentionOrderEntity.GetExist_cust_plan() + (("ftg".Equals(_oMobileRetentionOrderEntity.GetOrg_ftg())) ? "FTG" : string.Empty);

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetOrg_fee()))
                    org_fee.Text = _oMobileRetentionOrderEntity.GetOrg_fee();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetAction_required()))
                    action_required.Text = _oMobileRetentionOrderEntity.GetAction_required();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetOb_program_id()))
                    ob_program_id.Text = _oMobileRetentionOrderEntity.GetOb_program_id();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetExisting_contract_end_date()))
                    existing_contract_end_date.Text = _oMobileRetentionOrderEntity.GetExisting_contract_end_date();

                if (_oMobileRetentionOrderEntity.GetAction_eff_date() != null)
                {
                    DateTime _oAction_eff_date = Convert.ToDateTime(_oMobileRetentionOrderEntity.GetAction_eff_date());
                    action_eff_date.Text = ((DateTime)_oAction_eff_date).ToString("dd/MM/yyyy");
                }
                //else
                //  throw new ArgumentNullException("action_eff_date");

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetExist_plan()))
                    exist_plan.Text = _oMobileRetentionOrderEntity.GetExist_plan();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetReasons()))
                    reasons.Text = _oMobileRetentionOrderEntity.GetReasons();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetAction_required()))
                {
                    if ("suspend".Equals(_oMobileRetentionOrderEntity.GetAction_required().Trim().ToLower()))
                        RunJavascriptFunc("ShowSuspend(false)");
                    else
                        RunJavascriptFunc("ShowSuspend(true)");
                }



                MobileOrderMNPDetailEntity[] _oMobileOrderMNPDetailArr = MobileOrderMNPDetailRepository.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), 0, "order_id='" + ((int)_oMobileRetentionOrderEntity.GetOrder_id()).ToString() + "'", null, null);
                if (_oMobileOrderMNPDetailArr != null)
                {
                    if (_oMobileOrderMNPDetailArr.Length > 0)
                    {
                        MobileOrderMNPDetail _oMobileOrderMNPDetail = (MobileOrderMNPDetail)_oMobileOrderMNPDetailArr[0];
                        company_name.Text = _oMobileOrderMNPDetail.company_name;
                        registered_name.Text = _oMobileOrderMNPDetail.registered_name;


                        if (!string.IsNullOrEmpty(_oMobileOrderMNPDetail.GetHkid()))
                        {
                            if (_oMobileOrderMNPDetail.GetHkid().Length > 4)
                            {
                                mnp_hkid.Text = _oMobileOrderMNPDetail.GetHkid().Substring(0, 4) + "****";
                            }
                        }

                        if (_oMobileOrderMNPDetail.GetTransfer_to_3g() == true)
                            transfer_to_3g.Text = "TRUE";
                        else
                            transfer_to_3g.Text = "FALSE";
                        if (_oMobileOrderMNPDetail.GetTransfer_idd_deposit() != null)
                            transfer_idd_deposit.Text = ((long)_oMobileOrderMNPDetail.GetTransfer_idd_deposit()).ToString();
                        if (_oMobileOrderMNPDetail.GetTransfer_idd_roaming_deposit() != null)
                            transfer_idd_roaming_deposit.Text = ((long)_oMobileOrderMNPDetail.GetTransfer_idd_roaming_deposit()).ToString();
                        if (_oMobileOrderMNPDetail.GetTransfer_no_add_proof_deposit() != null)
                            transfer_no_add_proof_deposit.Text = ((long)_oMobileOrderMNPDetail.GetTransfer_no_add_proof_deposit()).ToString();
                        if (_oMobileOrderMNPDetail.GetTransfer_no_hk_id_holder_deposit() != null)
                            transfer_no_hk_id_holder_deposit.Text = ((long)_oMobileOrderMNPDetail.GetTransfer_no_hk_id_holder_deposit()).ToString();
                        if (_oMobileOrderMNPDetail.GetTransfer_others_deposit() != null)
                            transfer_others_deposit.Text = ((long)_oMobileOrderMNPDetail.GetTransfer_others_deposit()).ToString();
                        if (_oMobileOrderMNPDetail.GetService_activation_date() != null)
                        {
                            service_activation_date.Text = ((DateTime)_oMobileOrderMNPDetail.GetService_activation_date()).ToString("dd/MM/yyyy");
                        }
                        if (!string.IsNullOrEmpty(_oMobileOrderMNPDetail.GetService_activation_time()))
                            service_activation_time.Text = _oMobileOrderMNPDetail.GetService_activation_time();
                        if (!string.IsNullOrEmpty(_oMobileOrderMNPDetail.GetTicker_number()))
                            ticker_number.Text = _oMobileOrderMNPDetail.GetTicker_number();
                    }
                }

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetProgram()))
                    program.Text = _oMobileRetentionOrderEntity.GetProgram();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetRate_plan()))
                    rate_plan.Text = _oMobileRetentionOrderEntity.GetRate_plan();


                normal_rebate_type.Text = _oMobileRetentionOrderEntity.GetNormal_rebate_type();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetAccept()))
                {
                    if ("Y".Equals(_oMobileRetentionOrderEntity.GetAccept()))
                        accept.Text = "Accept Autoroll";
                    else if ("reject".Equals(_oMobileRetentionOrderEntity.GetAccept()))
                        accept.Text = "Reject Autoroll (change to FTG)";
                    else if ("no_comment".Equals(_oMobileRetentionOrderEntity.GetAccept()))
                        accept.Text = "No Comment";
                }

                if (_oMobileRetentionOrderEntity.GetPcd_paid_go_wireless() == true)
                    pcd_paid_go_wireless.Text = "YES";
                else
                    pcd_paid_go_wireless.Text = "NO";

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetLob()))
                    lob.Text = _oMobileRetentionOrderEntity.GetLob();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetLob_ac()))
                    lob_ac.Text = _oMobileRetentionOrderEntity.GetLob_ac();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetGo_wireless_package_code()))
                    go_wireless_package_code.Text = _oMobileRetentionOrderEntity.GetGo_wireless_package_code();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetCon_per()))
                    con_per.Text = _oMobileRetentionOrderEntity.GetCon_per();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetRebate()))
                    rebate.Text = _oMobileRetentionOrderEntity.GetRebate();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetSim_item_name()))
                    sim_item_name.Text = "Name: " + _oMobileRetentionOrderEntity.GetSim_item_name();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetSim_item_code()))
                    sim_item_code.Text = "Code: " + _oMobileRetentionOrderEntity.GetSim_item_code();

                string _sSim_Number = MobileRetentionOrderBal.GetSim_Number(_oMobileRetentionOrderEntity.GetEdf_no());
                if (!string.IsNullOrEmpty(_sSim_Number))
                    sim_item_number.Text = "Number: " + _sSim_Number;

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetHs_model()))
                    hs_model.Text = _oMobileRetentionOrderEntity.GetHs_model();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetSku()))
                    sku.Text = _oMobileRetentionOrderEntity.GetSku();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetImei_no()))
                    imei_no.Text = _oMobileRetentionOrderEntity.GetImei_no();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetPremium()))
                    premium.Text = _oMobileRetentionOrderEntity.GetPremium();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetS_premium()))
                    s_premium.Text = _oMobileRetentionOrderEntity.GetS_premium();

                if (_oMobileRetentionOrderEntity.GetSp_d_date() != null)
                {
                    if (Func.IsParseDateTime(((DateTime)_oMobileRetentionOrderEntity.GetSp_d_date()).ToString()))
                        sp_d_date.Text = Convert.ToDateTime(_oMobileRetentionOrderEntity.GetSp_d_date()).ToString("dd/MM/yyyy");
                }

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetSp_ref_no()))
                    sp_ref_no.Text = _oMobileRetentionOrderEntity.GetSp_ref_no();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetPos_ref_no()))
                    pos_ref_no.Text = _oMobileRetentionOrderEntity.GetPos_ref_no();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetS_premium1()))
                    s_premium1.Text = _oMobileRetentionOrderEntity.GetS_premium1();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetS_premium2()))
                    s_premium2.Text = _oMobileRetentionOrderEntity.GetS_premium2();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetS_premium3()))
                    s_premium3.Text = _oMobileRetentionOrderEntity.GetS_premium3();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetS_premium4()))
                    s_premium4.Text = _oMobileRetentionOrderEntity.GetS_premium4();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetRedemption_notice_option()))
                    redemption_notice_option.Text = _oMobileRetentionOrderEntity.GetRedemption_notice_option();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetTrade_field()))
                    trade_field.Text = _oMobileRetentionOrderEntity.GetTrade_field();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetBundle_name()))
                    bundle_name.Text = _oMobileRetentionOrderEntity.GetBundle_name();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetM_rebate_amount()))
                    m_rebate_amount.Text = _oMobileRetentionOrderEntity.GetM_rebate_amount();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetRebate_amount()))
                    rebate_amount.Text = _oMobileRetentionOrderEntity.GetRebate_amount();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetR_offer()))
                    r_offer.Text = _oMobileRetentionOrderEntity.GetR_offer();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetExtra_rebate_amount()))
                    extra_rebate_amount.Text = _oMobileRetentionOrderEntity.GetExtra_rebate_amount();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetExtra_rebate()))
                    extra_rebate.Text = _oMobileRetentionOrderEntity.GetExtra_rebate();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetFree_mon()))
                    free_mon.Text = _oMobileRetentionOrderEntity.GetFree_mon();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetCancel_renew()))
                    cancel_renew.Text = _oMobileRetentionOrderEntity.GetCancel_renew();

                //gowireless

                //preferred_languages

                //registeraddress

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetGift_code()))
                    gift_code.Text = _oMobileRetentionOrderEntity.GetGift_code();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetGift_imei()))
                    gift_imei.Text = _oMobileRetentionOrderEntity.GetGift_imei();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetGift_desc()))
                    gift_desc.Text = _oMobileRetentionOrderEntity.GetGift_desc();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetGift_code2()))
                    gift_code2.Text = _oMobileRetentionOrderEntity.GetGift_code2();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetGift_imei2()))
                    gift_imei2.Text = _oMobileRetentionOrderEntity.GetGift_imei2();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetGift_desc2()))
                    gift_desc2.Text = _oMobileRetentionOrderEntity.GetGift_desc2();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetGift_code3()))
                    gift_code3.Text = _oMobileRetentionOrderEntity.GetGift_code3();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetGift_imei3()))
                    gift_imei3.Text = _oMobileRetentionOrderEntity.GetGift_imei3();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetGift_desc3()))
                    gift_desc3.Text = _oMobileRetentionOrderEntity.GetGift_desc3();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetGift_code4()))
                    gift_code4.Text = _oMobileRetentionOrderEntity.GetGift_code4();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetGift_imei4()))
                    gift_imei4.Text = _oMobileRetentionOrderEntity.GetGift_imei4();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetGift_desc4()))
                    gift_desc4.Text = _oMobileRetentionOrderEntity.GetGift_desc4();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetAccessory_code()))
                    accessory_code.Text = _oMobileRetentionOrderEntity.GetAccessory_code();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetAccessory_price()))
                    accessory_price.Text = _oMobileRetentionOrderEntity.GetAccessory_price();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetAccessory_imei()))
                    accessory_imei.Text = _oMobileRetentionOrderEntity.GetAccessory_imei();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetAig_gift()))
                    aig_gift.Text = _oMobileRetentionOrderEntity.GetAig_gift();


                CreateVasInfo();
                if (_oMobileRetentionOrderEntity.GetFast_start() != null)
                {
                    if (Convert.ToBoolean(_oMobileRetentionOrderEntity.GetFast_start()))
                        fast_start.Text = "TRUE";
                    else
                        fast_start.Text = "FALSE";
                }
                // else
                // new ArgumentNullException("fast_start");

                if (_oMobileRetentionOrderEntity.GetVas_eff_date() != null)
                {
                    vas_eff_date.Text = Convert.ToDateTime(_oMobileRetentionOrderEntity.GetVas_eff_date()).ToString("dd/MM/yyyy");
                }
                // else
                // throw new ArgumentNullException("vas_eff_date");


                bool _bNextBill = false;
                if (_oMobileRetentionOrderEntity.GetNext_bill() != null)
                {
                    if (Convert.ToBoolean(_oMobileRetentionOrderEntity.GetNext_bill()))
                    {
                        next_bill.Text = (Convert.ToBoolean(_oMobileRetentionOrderEntity.GetNext_bill())) ? "YES" : "NO";
                        if (Convert.ToBoolean(_oMobileRetentionOrderEntity.GetNext_bill()))
                        {
                            _bNextBill = true;
                        }
                    }
                }

                if (!_bNextBill && _oMobileRetentionOrderEntity.GetCon_eff_date() != null)
                {
                    con_eff_date.Text = Convert.ToDateTime(_oMobileRetentionOrderEntity.GetCon_eff_date()).ToString("dd/MM/yyyy");
                }
                else if (_bNextBill && _oMobileRetentionOrderEntity.GetBill_cut_date() != null)
                {
                    con_eff_date.Text = Convert.ToDateTime(_oMobileRetentionOrderEntity.GetBill_cut_date()).ToString("dd/MM/yyyy");
                }
                else if (_bNextBill)
                {
                    con_eff_date.Text = "Next Bill Cut Date";
                }

                // else
                //   throw new ArgumentNullException("con_eff_date");

                //plan_eff.Text = _oMobileRetentionOrderEntity.GetPlan_eff();

                if (_oMobileRetentionOrderEntity.GetPlan_eff_date() != null)
                {
                    plan_eff_date.Text = Convert.ToDateTime(_oMobileRetentionOrderEntity.GetPlan_eff_date()).ToString("dd/MM/yyyy");
                }

                if (_oMobileRetentionOrderEntity.GetBill_cut_date() != null)
                {
                    DateTime _dBill_cut_date = Convert.ToDateTime(_oMobileRetentionOrderEntity.GetBill_cut_date());
                    if (_dBill_cut_date != null)
                    {
                        bill_cut_date.Text = _dBill_cut_date.ToString("dd/MM/yyyy");
                        /*if (plan_eff.Text.Equals("Next Bill Date"))
                        {
                            plan_eff.Text = _dBill_cut_date.AddDays(1).ToString("dd/MM/yyyy");
                        }*/
                    }
                }
                // else
                //  throw new ArgumentNullException("plan_eff_date");

                if (_oMobileRetentionOrderEntity.GetPrepayment_waive() == true)
                    prepayment.Text = "TRUE";
                else
                    prepayment.Text = "FALSE";

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetMonthly_payment_type()))
                {
                    monthly_payment_type.Text = _oMobileRetentionOrderEntity.GetMonthly_payment_type();
                }

                /*
                if ("change_payment_method".Equals(_oMobileRetentionOrderEntity.GetMonthly_payment_method()))
                    monthly_payment_method.Text = "Change Payment Method ";
                else
                    monthly_payment_method.Text = "Keep Existing Payment Method";
               
                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetChange_payment_type()))
                    change_payment_type.Text = _oMobileRetentionOrderEntity.GetChange_payment_type();
                 */
                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetM_card_type()))
                    m_card_type.Text = _oMobileRetentionOrderEntity.GetM_card_type();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetM_card_no()))
                    m_card_no.Text = _oMobileRetentionOrderEntity.GetM_card_no();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetM_card_holder2()))
                    m_card_holder2.Text = _oMobileRetentionOrderEntity.GetM_card_holder2();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetM_card_exp_month()))
                    m_card_exp_month.Text = _oMobileRetentionOrderEntity.GetM_card_exp_month();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetM_card_exp_year()))
                    m_card_exp_year.Text = _oMobileRetentionOrderEntity.GetM_card_exp_year();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetOrd_place_by()))
                    ord_place_by.Text = _oMobileRetentionOrderEntity.GetOrd_place_by();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetOrd_place_rel()))
                    ord_place_rel.Text = _oMobileRetentionOrderEntity.GetOrd_place_rel();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetOrd_place_id_type()))
                    ord_place_id_type.Text = _oMobileRetentionOrderEntity.GetOrd_place_id_type();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetOrd_place_hkid()))
                {
                    if (_oMobileRetentionOrderEntity.GetOrd_place_hkid().Length > 4)
                    {
                        ord_place_hkid.Text = _oMobileRetentionOrderEntity.GetOrd_place_hkid().Substring(0, 4) + "****";
                    }
                }

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetOrd_place_tel()))
                    ord_place_tel.Text = _oMobileRetentionOrderEntity.GetOrd_place_tel();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetD_address()))
                    d_address.Text = _oMobileRetentionOrderEntity.GetD_address();

                if (_oMobileRetentionOrderEntity.GetD_date() != null)
                    d_date.Text = Convert.ToDateTime(_oMobileRetentionOrderEntity.GetD_date()).ToString("dd/MM/yyyy");

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetD_time()))
                    d_time.Text = _oMobileRetentionOrderEntity.GetD_time();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetExtra_d_charge()))
                    extra_d_charge.Text = _oMobileRetentionOrderEntity.GetExtra_d_charge();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetContact_person()))
                    contact_person.Text = _oMobileRetentionOrderEntity.GetContact_person();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetContact_no()))
                    contact_no.Text = _oMobileRetentionOrderEntity.GetContact_no();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetExt_place_tel()))
                    ext_place_tel.Text = _oMobileRetentionOrderEntity.GetExt_place_tel();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetPay_method()))
                    pay_method.Text = _oMobileRetentionOrderEntity.GetPay_method();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetCard_type()))
                    card_type.Text = _oMobileRetentionOrderEntity.GetCard_type();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetCard_no()))
                {
                    if (_oMobileRetentionOrderEntity.GetCard_no().Length >= 4)
                        card_no.Text = _oMobileRetentionOrderEntity.GetCard_no().Substring(0, 4) + "************";
                    else
                        card_no.Text = _oMobileRetentionOrderEntity.GetCard_no();
                }

                MobileOrderThreePartyEntity[] _oMobileOrderThreePartyArr = MobileOrderThreePartyRepository.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), 0, "order_id='" + ((int)_oMobileRetentionOrderEntity.GetOrder_id()).ToString() + "'", null, null);
                if (_oMobileOrderThreePartyArr != null)
                {
                    if (_oMobileOrderThreePartyArr.Length > 0)
                    {
                        MobileOrderThreeParty _oMobileOrderThreeParty = (MobileOrderThreeParty)_oMobileOrderThreePartyArr[0];
                        if (_oMobileOrderThreeParty.GetThree_party() == true)
                            three_party.Text = "TRUE";
                        else
                            three_party.Text = "FALSE";

                        arthurization_person.Text = _oMobileOrderThreeParty.GetArthurization_person();

                        if (!string.IsNullOrEmpty(_oMobileOrderThreeParty.GetHkid()))
                        {
                            if (_oMobileOrderThreeParty.GetHkid().Length > 4)
                            {
                                tpy_hkid.Text = _oMobileOrderThreeParty.GetHkid().Substring(0, 4) + "****";
                            }
                        }
                        tpy_contact_no.Text = _oMobileOrderThreeParty.GetContact_no();
                    }
                }


                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetCard_holder()))
                    card_holder.Text = _oMobileRetentionOrderEntity.GetCard_holder();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetCard_exp_month()))
                    card_exp_month.Text = _oMobileRetentionOrderEntity.GetCard_exp_month();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetCard_exp_year()))
                    card_exp_year.Text = _oMobileRetentionOrderEntity.GetCard_exp_year();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetBank_name()))
                    bank_name.Text = _oMobileRetentionOrderEntity.GetBank_name();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetBank_code()))
                    bank_code.Text = _oMobileRetentionOrderEntity.GetBank_code();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetAmount()))
                    amount.Text = _oMobileRetentionOrderEntity.GetAmount();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetRemarks()))
                    remarks.Text = _oMobileRetentionOrderEntity.GetRemarks();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetRemarks2EDF()))
                    remarks2EDF.Text = _oMobileRetentionOrderEntity.GetRemarks2EDF();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetRemarks2PY()))
                    remarks2PY.Text = _oMobileRetentionOrderEntity.GetRemarks2PY();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetStaff_no()))
                    staff_no.Text = _oMobileRetentionOrderEntity.GetStaff_no();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetStaff_name()))
                    staff_name.Text = _oMobileRetentionOrderEntity.GetStaff_name();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetTeamcode()))
                    teamcode.Text = _oMobileRetentionOrderEntity.GetTeamcode();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetTl_name()))
                    tl_name.Text = _oMobileRetentionOrderEntity.GetTl_name();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetSalesmancode()))
                    salesmancode.Text = _oMobileRetentionOrderEntity.GetSalesmancode();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetChannel()))
                    channel.Text = _oMobileRetentionOrderEntity.GetChannel();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetExtn()))
                    extn.Text = _oMobileRetentionOrderEntity.GetExtn();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetRef_staff_no()))
                    ref_staff_no.Text = _oMobileRetentionOrderEntity.GetRef_staff_no();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetRef_salesmancode()))
                    ref_salesmancode.Text = _oMobileRetentionOrderEntity.GetRef_salesmancode();



                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetGo_wireless()))
                    go_wireless.Text = _oMobileRetentionOrderEntity.GetGo_wireless();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetPreferred_languages()))
                    preferred_languages.Text = _oMobileRetentionOrderEntity.GetPreferred_languages();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetRegister_address()))
                    register_address.Text = _oMobileRetentionOrderEntity.GetRegister_address();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetThird_party_credit_card()))
                    third_party_credit_card.Text = _oMobileRetentionOrderEntity.GetThird_party_credit_card();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetThird_party_hkid()))
                    third_party_hkid.Text = _oMobileRetentionOrderEntity.GetThird_party_hkid();


                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetThird_party_id_type()))
                    third_party_id_type.Text = _oMobileRetentionOrderEntity.GetThird_party_id_type();

                if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetCooling_offer()))
                    cooling_offer.Text = _oMobileRetentionOrderEntity.GetCooling_offer();

                if (_oMobileRetentionOrderEntity.GetCooling_date() != null)
                    cooling_date.Text = Convert.ToDateTime(_oMobileRetentionOrderEntity.GetCooling_date()).ToString("dd/MM/yyyy");

                monthly_bank_account_bank_code.Text = _oMobileRetentionOrderEntity.GetMonthly_bank_account_bank_code();
                monthly_bank_account_branch_code.Text = _oMobileRetentionOrderEntity.GetMonthly_bank_account_branch_code();

                if (_oMobileRetentionOrderEntity.GetMonthly_bank_account_hkid().Length >= 4)
                    monthly_bank_account_hkid.Text = _oMobileRetentionOrderEntity.GetMonthly_bank_account_hkid().Substring(0, 4) + "****";

                monthly_bank_account_holder.Text = _oMobileRetentionOrderEntity.GetMonthly_bank_account_holder();
                monthly_bank_account_id_type.Text = _oMobileRetentionOrderEntity.GetMonthly_bank_account_id_type();
                monthly_bank_account_no.Text = _oMobileRetentionOrderEntity.GetMonthly_bank_account_no();

                m_3rd_contact_no.Text = _oMobileRetentionOrderEntity.GetM_3rd_contact_no();
                if (_oMobileRetentionOrderEntity.GetM_3rd_hkid().Length >= 4)
                    m_3rd_hkid.Text = _oMobileRetentionOrderEntity.GetM_3rd_hkid().Substring(0, 4) + "****";
                m_3rd_id_type.Text = _oMobileRetentionOrderEntity.GetM_3rd_id_type();


                delivery_collection_type.Text = _oMobileRetentionOrderEntity.GetDelivery_collection_type();
                delivery_exchange.Text = _oMobileRetentionOrderEntity.GetDelivery_exchange();
                delivery_exchange_option.Text = _oMobileRetentionOrderEntity.GetDelivery_exchange_option();
                delivery_exchange_location.Text = _oMobileRetentionOrderEntity.GetDelivery_exchange_location();


                upgrade_type.Text = _oMobileRetentionOrderEntity.GetUpgrade_type();
                if (_oMobileRetentionOrderEntity.GetUpgrade_existing_contract_sdate() != null)
                    upgrade_existing_contract_sdate.Text = ((DateTime)_oMobileRetentionOrderEntity.GetUpgrade_existing_contract_sdate()).ToString("dd/MM/yyyy");
                if (_oMobileRetentionOrderEntity.GetUpgrade_existing_contract_edate() != null)
                    upgrade_existing_contract_edate.Text = ((DateTime)_oMobileRetentionOrderEntity.GetUpgrade_existing_contract_edate()).ToString("dd/MM/yyyy");

                upgrade_existing_customer_type.Text = _oMobileRetentionOrderEntity.GetUpgrade_existing_customer_type();
                upgrade_handset_offer_rebate_schedule.Text = _oMobileRetentionOrderEntity.GetUpgrade_handset_offer_rebate_schedule();
                upgrade_sponsorships_amount.Text = _oMobileRetentionOrderEntity.GetUpgrade_sponsorships_amount();
                upgrade_existing_pccw_customer.Text = _oMobileRetentionOrderEntity.GetUpgrade_existing_pccw_customer();
                ftg_tenure.Text = _oMobileRetentionOrderEntity.GetFtg_tenure();
                upgrade_service_account_no.Text = _oMobileRetentionOrderEntity.GetUpgrade_service_account_no();
                upgrade_registered_mobile_no.Text = _oMobileRetentionOrderEntity.GetUpgrade_registered_mobile_no();
                upgrade_service_tenure.Text = _oMobileRetentionOrderEntity.GetUpgrade_service_tenure();
                action_of_rate_plan_effective.Text = _oMobileRetentionOrderEntity.GetAction_of_rate_plan_effective();
                existing_smart_phone_model.Text = _oMobileRetentionOrderEntity.GetExisting_smart_phone_model();
                existing_smart_phone_imei.Text = _oMobileRetentionOrderEntity.GetExisting_smart_phone_imei();

                card_ref_no.Text = _oMobileRetentionOrderEntity.GetCard_ref_no();
                pool.Text = _oMobileRetentionOrderEntity.GetPool();
                if (_oMobileRetentionOrderEntity.GetCn_mrt_no() != null)
                    cn_mrt_no.Text = ((long)_oMobileRetentionOrderEntity.GetCn_mrt_no()).ToString();

                special_handling_dummy_code.Text = _oMobileRetentionOrderEntity.GetSpecial_handling_dummy_code();
                

            }
        }
    }
    #endregion

    #region CreateVasInfo
    public void CreateVasInfo()
    {
        if (n_iOrder_id != -1)
        {
            MobileRetentionOrder _oMobileRetentionOrder = (MobileRetentionOrder)MobileRetentionOrderRepository.CreateEntityInstanceObject();
            _oMobileRetentionOrder.SetOrder_id(n_iOrder_id);
            if (_oMobileRetentionOrder.Retrieve())
            {
                if (_oMobileRetentionOrder.GetOrder_id() != null)
                {
                    MobileOrderVasEntity[] _oMobileOrderVasList = MobileOrderVasRepository.GetArrayObj(GetDB(), "order_id='" + ((int)n_iOrder_id).ToString() + "'", null, null);
                    if (_oMobileOrderVasList != null)
                    {
                        for (int i = 0; i < _oMobileOrderVasList.Length; i++)
                        {
                            if (_oMobileOrderVasList[i].GetActive() != null)
                            {
                                //if ((bool)_oMobileOrderVasList[i].GetActive())
                                {
                                    BusinessVas _oBusinessVas = new BusinessVas(GetDB(), _oMobileOrderVasList[i].GetVas_id());
                                    GiftVasCreate_Holder.Controls.Add(new LiteralControl("<tr class=\"strow\">"));
                                    GiftVasCreate_Holder.Controls.Add(new LiteralControl("<td height=\"28\"  ><span style=\"font-size:10pt\">" + ((_oBusinessVas.GetVas_name() != null) ? _oBusinessVas.GetVas_name() : string.Empty) + " " + Func.LatinToBig5(((_oBusinessVas.GetVas_chi_name() != null) ? _oBusinessVas.GetVas_chi_name().Trim() : string.Empty))));
                                    GiftVasCreate_Holder.Controls.Add(new LiteralControl("</td>"));
                                    GiftVasCreate_Holder.Controls.Add(new LiteralControl("<td height=\"28\"  colspan=\"3\"><span  > "));
                                    string _sVas_value = (_oMobileOrderVasList[i].GetVas_value() != null) ? _oMobileOrderVasList[i].GetVas_value() : string.Empty;
                                    string _sVas_desc = (new BusinessVasDescription(GetDB(), _oMobileOrderVasList[i].GetMulti_id())).GetVas_desc();
                                    GiftVasCreate_Holder.Controls.Add(new LiteralControl(_sVas_value + " " + _sVas_desc));
                                    GiftVasCreate_Holder.Controls.Add(new LiteralControl("</span</td>"));
                                    GiftVasCreate_Holder.Controls.Add(new LiteralControl("</tr>"));
                                }
                            }
                        }
                    }
                }
            }
        }
        GiftVasCreate_Holder.Visible = true;
    }
    #endregion

    #region Run Javascript Function
    public void RunJavascriptFunc(string x_sFunc)
    {
        string _sFunc = ((x_sFunc.IndexOf(';') > 0) ? x_sFunc : x_sFunc + ";");
        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sFunc + (new Random()).Next(1, 1000).ToString()+Guid.NewGuid().ToString(), string.Format("<script>{0}</script>", _sFunc), false);
    }
    #endregion

    #region Get DB
    protected MSSQLConnect GetDB()
    {
        n_oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
        n_oDB.bWithNoLock = true;
        return n_oDB;
    }
    #endregion
}
