using System;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml.Linq;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Xml;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2012-01-12>
///-- Description:	<Description,Table :[MobileRetentionPreviousOrder],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class MobileRetentionPreviousOrderDalDAO{
        
        #region RS
        public class MobileRetentionPreviousOrderRS
        {
            public bool n_bGift_imei = false;
            public bool n_bS_premium4 = false;
            public bool n_bGift_desc4 = false;
            public bool n_bAccessory_desc = false;
            public bool n_bAction_required = false;
            public bool n_bRegistered_address_his_id = false;
            public bool n_bVas_eff_date = false;
            public bool n_bMonthly_bank_account_bank_code = false;
            public bool n_bSpecial_handling_dummy_code = false;
            public bool n_bM_card_exp_year = false;
            public bool n_bRemarks2PY = false;
            public bool n_bTrade_field = false;
            public bool n_bOrd_place_tel = false;
            public bool n_bOrd_place_id_type = false;
            public bool n_bCooling_offer = false;
            public bool n_bRec_no = false;
            public bool n_bUpgrade_handset_offer_rebate_schedule = false;
            public bool n_bChange_payment_type = false;
            public bool n_bDate_of_birth = false;
            public bool n_bContact_person = false;
            public bool n_bExtra_d_charge = false;
            public bool n_bTl_name = false;
            public bool n_bFast_start = false;
            public bool n_bSp_ref_no = false;
            public bool n_bEdate = false;
            public bool n_bExist_cust_plan = false;
            public bool n_bOrd_place_rel = false;
            public bool n_bMrt_no = false;
            public bool n_bImei_no = false;
            public bool n_bExisting_smart_phone_model = false;
            public bool n_bGift_code3 = false;
            public bool n_bBank_code = false;
            public bool n_bPos_ref_no = false;
            public bool n_bBill_cut_date = false;
            public bool n_bGift_imei3 = false;
            public bool n_bExist_plan = false;
            public bool n_bWaive = false;
            public bool n_bProgram = false;
            public bool n_bFirst_month_fee = false;
            public bool n_bR_offer = false;
            public bool n_bCid = false;
            public bool n_bDid = false;
            public bool n_bFtg_tenure = false;
            public bool n_bCon_per = false;
            public bool n_bGift_code4 = false;
            public bool n_bEasywatch_type = false;
            public bool n_bSms_mrt = false;
            public bool n_bTpy_his_id = false;
            public bool n_bMonthly_payment_method = false;
            public bool n_bRemarks2EDF = false;
            public bool n_bGift_desc3 = false;
            public bool n_bGift_imei4 = false;
            public bool n_bOld_ord_id = false;
            public bool n_bMonthly_bank_account_hkid2 = false;
            public bool n_bD_date = false;
            public bool n_bGift_desc = false;
            public bool n_bSalesmancode = false;
            public bool n_bPool = false;
            public bool n_bCn_mrt_no = false;
            public bool n_bAccessory_imei = false;
            public bool n_bThird_party_credit_card = false;
            public bool n_bCard_ref_no = false;
            public bool n_bCooling_date = false;
            public bool n_bSpecial_approval = false;
            public bool n_bUpgrade_existing_contract_edate = false;
            public bool n_bAccessory_code = false;
            public bool n_bBill_medium = false;
            public bool n_bS_premium = false;
            public bool n_bRef_staff_no = false;
            public bool n_bAccessory_price = false;
            public bool n_bM_card_exp_month = false;
            public bool n_bInstallment_period = false;
            public bool n_bM_card_type = false;
            public bool n_bEasywatch_ord_id = false;
            public bool n_bNormal_rebate = false;
            public bool n_bM_rebate_amount = false;
            public bool n_bM_card_holder2 = false;
            public bool n_bBill_medium_email = false;
            public bool n_bActive = false;
            public bool n_bS_premium1 = false;
            public bool n_bCard_exp_month = false;
            public bool n_bOb_program_id = false;
            public bool n_bSku = false;
            public bool n_bRef_salesmancode = false;
            public bool n_bGo_wireless_package_code = false;
            public bool n_bThird_party_hkid = false;
            public bool n_bUpgrade_existing_pccw_customer = false;
            public bool n_bD_address = false;
            public bool n_bUpgrade_registered_mobile_no = false;
            public bool n_bUpgrade_existing_customer_type = false;
            public bool n_bNormal_rebate_type = false;
            public bool n_bGift_desc2 = false;
            public bool n_bMonthly_bank_account_branch_code = false;
            public bool n_bRemarks = false;
            public bool n_bAccept = false;
            public bool n_bDelivery_exchange = false;
            public bool n_bGift_code2 = false;
            public bool n_bPrepayment_waive = false;
            public bool n_bExisting_smart_phone_imei = false;
            public bool n_bMnp_his_id = false;
            public bool n_bCust_name = false;
            public bool n_bCust_type = false;
            public bool n_bUpgrade_sponsorships_amount = false;
            public bool n_bBill_medium_waive = false;
            public bool n_bDelivery_exchange_location = false;
            public bool n_bHs_offer_type_id = false;
            public bool n_bOrg_fee = false;
            public bool n_bRebate = false;
            public bool n_bUpgrade_type = false;
            public bool n_bGo_wireless = false;
            public bool n_bExtra_rebate = false;
            public bool n_bPlan_eff = false;
            public bool n_bExtra_rebate_amount = false;
            public bool n_bCard_exp_year = false;
            public bool n_bUpgrade_existing_contract_sdate = false;
            public bool n_bOrd_place_hkid = false;
            public bool n_bRegister_address = false;
            public bool n_bGender = false;
            public bool n_bLob_ac = false;
            public bool n_bSim_mrt_no = false;
            public bool n_bRedemption_notice_option = false;
            public bool n_bDelivery_collection_type = false;
            public bool n_bAction_date = false;
            public bool n_bThird_party_id_type = false;
            public bool n_bOrg_ftg = false;
            public bool n_bUpgrade_service_tenure = false;
            public bool n_bMonthly_payment_type = false;
            public bool n_bContact_no = false;
            public bool n_bOrg_mrt = false;
            public bool n_bSim_item_name = false;
            public bool n_bPay_method = false;
            public bool n_bHs_model = false;
            public bool n_bGift_code = false;
            public bool n_bMonthly_bank_account_hkid = false;
            public bool n_bExtra_offer = false;
            public bool n_bMonthly_bank_account_no = false;
            public bool n_bFirst_month_license_fee = false;
            public bool n_bRetrieve_cnt = false;
            public bool n_bDdate = false;
            public bool n_bS_premium2 = false;
            public bool n_bMonthly_bank_account_id_type = false;
            public bool n_bCard_type = false;
            public bool n_bNext_bill = false;
            public bool n_bPcd_paid_go_wireless = false;
            public bool n_bUpgrade_rebate_calculation = false;
            public bool n_bExt_place_tel = false;
            public bool n_bM_3rd_hkid = false;
            public bool n_bRetention_type = false;
            public bool n_bBill_address_his_id = false;
            public bool n_bAig_gift = false;
            public bool n_bCust_staff_no = false;
            public bool n_bOrder_id = false;
            public bool n_bFamily_name = false;
            public bool n_bCdate = false;
            public bool n_bStatus_by_cs_admin = false;
            public bool n_bSim_item_number = false;
            public bool n_bVip_case = false;
            public bool n_bGiven_name = false;
            public bool n_bLog_date = false;
            public bool n_bExtn = false;
            public bool n_bD_time = false;
            public bool n_bBank_name = false;
            public bool n_bDelivery_exchange_option = false;
            public bool n_bUpgrade_service_account_no = false;
            public bool n_bAction_of_rate_plan_effective = false;
            public bool n_bM_card_no = false;
            public bool n_bExisting_contract_end_date = false;
            public bool n_bCon_eff_date = false;
            public bool n_bM_3rd_hkid2 = false;
            public bool n_bAmount = false;
            public bool n_bId_type = false;
            public bool n_bRate_plan = false;
            public bool n_bChannel = false;
            public bool n_bAction_eff_date = false;
            public bool n_bIssue_type = false;
            public bool n_bFree_mon = false;
            public bool n_bPlan_eff_date = false;
            public bool n_bDel_remark = false;
            public bool n_bTeamcode = false;
            public bool n_bStaff_name = false;
            public bool n_bEdf_no = false;
            public bool n_bOrd_place_by = false;
            public bool n_bCancel_renew = false;
            public bool n_bPreferred_languages = false;
            public bool n_bHkid = false;
            public bool n_bCard_no = false;
            public bool n_bAc_no = false;
            public bool n_bBill_cut_num = false;
            public bool n_bPremium = false;
            public bool n_bM_3rd_id_type = false;
            public bool n_bGift_imei2 = false;
            public bool n_bReasons = false;
            public bool n_bLanguage = false;
            public bool n_bRebate_amount = false;
            public bool n_bLob = false;
            public bool n_bM_3rd_contact_no = false;
            public bool n_bStaff_no = false;
            public bool n_bS_premium3 = false;
            public bool n_bSp_d_date = false;
            public bool n_bBundle_name = false;
            public bool n_bAccessory_waive = false;
            public bool n_bSim_item_code = false;
            public bool n_bMonthly_bank_account_holder = false;
            public bool n_bCard_holder = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bGift_imei  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.gift_imei.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bGift_imei=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.gift_imei);
                }
                if (this.n_bS_premium4  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.s_premium4.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bS_premium4=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.s_premium4);
                }
                if (this.n_bGift_desc4  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.gift_desc4.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bGift_desc4=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.gift_desc4);
                }
                if (this.n_bAccessory_desc  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.accessory_desc.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bAccessory_desc=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.accessory_desc);
                }
                if (this.n_bAction_required  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.action_required.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bAction_required=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.action_required);
                }
                if (this.n_bRegistered_address_his_id  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.registered_address_his_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRegistered_address_his_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.registered_address_his_id);
                }
                if (this.n_bVas_eff_date  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.vas_eff_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bVas_eff_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.vas_eff_date);
                }
                if (this.n_bMonthly_bank_account_bank_code  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.monthly_bank_account_bank_code.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMonthly_bank_account_bank_code=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.monthly_bank_account_bank_code);
                }
                if (this.n_bSpecial_handling_dummy_code  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.special_handling_dummy_code.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSpecial_handling_dummy_code=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.special_handling_dummy_code);
                }
                if (this.n_bM_card_exp_year  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.m_card_exp_year.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bM_card_exp_year=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.m_card_exp_year);
                }
                if (this.n_bRemarks2PY  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.remarks2PY.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRemarks2PY=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.remarks2PY);
                }
                if (this.n_bTrade_field  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.trade_field.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bTrade_field=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.trade_field);
                }
                if (this.n_bOrd_place_tel  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.ord_place_tel.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOrd_place_tel=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.ord_place_tel);
                }
                if (this.n_bOrd_place_id_type  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.ord_place_id_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOrd_place_id_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.ord_place_id_type);
                }
                if (this.n_bCooling_offer  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.cooling_offer.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCooling_offer=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.cooling_offer);
                }
                if (this.n_bRec_no  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.rec_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRec_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.rec_no);
                }
                if (this.n_bUpgrade_handset_offer_rebate_schedule  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.upgrade_handset_offer_rebate_schedule.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bUpgrade_handset_offer_rebate_schedule=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.upgrade_handset_offer_rebate_schedule);
                }
                if (this.n_bChange_payment_type  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.change_payment_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bChange_payment_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.change_payment_type);
                }
                if (this.n_bDate_of_birth  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.date_of_birth.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDate_of_birth=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.date_of_birth);
                }
                if (this.n_bContact_person  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.contact_person.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bContact_person=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.contact_person);
                }
                if (this.n_bExtra_d_charge  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.extra_d_charge.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bExtra_d_charge=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.extra_d_charge);
                }
                if (this.n_bTl_name  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.tl_name.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bTl_name=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.tl_name);
                }
                if (this.n_bFast_start  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.fast_start.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFast_start=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.fast_start);
                }
                if (this.n_bSp_ref_no  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.sp_ref_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSp_ref_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.sp_ref_no);
                }
                if (this.n_bEdate  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.edate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.edate);
                }
                if (this.n_bExist_cust_plan  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.exist_cust_plan.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bExist_cust_plan=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.exist_cust_plan);
                }
                if (this.n_bOrd_place_rel  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.ord_place_rel.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOrd_place_rel=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.ord_place_rel);
                }
                if (this.n_bMrt_no  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.mrt_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMrt_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.mrt_no);
                }
                if (this.n_bImei_no  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.imei_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bImei_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.imei_no);
                }
                if (this.n_bExisting_smart_phone_model  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.existing_smart_phone_model.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bExisting_smart_phone_model=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.existing_smart_phone_model);
                }
                if (this.n_bGift_code3  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.gift_code3.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bGift_code3=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.gift_code3);
                }
                if (this.n_bBank_code  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.bank_code.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bBank_code=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.bank_code);
                }
                if (this.n_bPos_ref_no  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.pos_ref_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPos_ref_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.pos_ref_no);
                }
                if (this.n_bBill_cut_date  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.bill_cut_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bBill_cut_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.bill_cut_date);
                }
                if (this.n_bGift_imei3  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.gift_imei3.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bGift_imei3=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.gift_imei3);
                }
                if (this.n_bExist_plan  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.exist_plan.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bExist_plan=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.exist_plan);
                }
                if (this.n_bWaive  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.waive.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bWaive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.waive);
                }
                if (this.n_bProgram  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.program.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bProgram=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.program);
                }
                if (this.n_bFirst_month_fee  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.first_month_fee.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFirst_month_fee=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.first_month_fee);
                }
                if (this.n_bR_offer  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.r_offer.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bR_offer=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.r_offer);
                }
                if (this.n_bCid  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.cid);
                }
                if (this.n_bDid  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.did.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.did);
                }
                if (this.n_bFtg_tenure  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.ftg_tenure.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFtg_tenure=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.ftg_tenure);
                }
                if (this.n_bCon_per  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.con_per.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCon_per=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.con_per);
                }
                if (this.n_bGift_code4  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.gift_code4.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bGift_code4=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.gift_code4);
                }
                if (this.n_bEasywatch_type  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.easywatch_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEasywatch_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.easywatch_type);
                }
                if (this.n_bSms_mrt  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.sms_mrt.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSms_mrt=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.sms_mrt);
                }
                if (this.n_bTpy_his_id  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.tpy_his_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bTpy_his_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.tpy_his_id);
                }
                if (this.n_bMonthly_payment_method  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.monthly_payment_method.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMonthly_payment_method=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.monthly_payment_method);
                }
                if (this.n_bRemarks2EDF  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.remarks2EDF.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRemarks2EDF=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.remarks2EDF);
                }
                if (this.n_bGift_desc3  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.gift_desc3.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bGift_desc3=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.gift_desc3);
                }
                if (this.n_bGift_imei4  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.gift_imei4.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bGift_imei4=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.gift_imei4);
                }
                if (this.n_bOld_ord_id  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.old_ord_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOld_ord_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.old_ord_id);
                }
                if (this.n_bMonthly_bank_account_hkid2  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.monthly_bank_account_hkid2.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMonthly_bank_account_hkid2=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.monthly_bank_account_hkid2);
                }
                if (this.n_bD_date  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.d_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bD_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.d_date);
                }
                if (this.n_bGift_desc  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.gift_desc.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bGift_desc=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.gift_desc);
                }
                if (this.n_bSalesmancode  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.salesmancode.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSalesmancode=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.salesmancode);
                }
                if (this.n_bPool  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.pool.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPool=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.pool);
                }
                if (this.n_bCn_mrt_no  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.cn_mrt_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCn_mrt_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.cn_mrt_no);
                }
                if (this.n_bAccessory_imei  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.accessory_imei.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bAccessory_imei=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.accessory_imei);
                }
                if (this.n_bThird_party_credit_card  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.third_party_credit_card.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bThird_party_credit_card=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.third_party_credit_card);
                }
                if (this.n_bCard_ref_no  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.card_ref_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCard_ref_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.card_ref_no);
                }
                if (this.n_bCooling_date  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.cooling_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCooling_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.cooling_date);
                }
                if (this.n_bSpecial_approval  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.special_approval.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSpecial_approval=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.special_approval);
                }
                if (this.n_bUpgrade_existing_contract_edate  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.upgrade_existing_contract_edate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bUpgrade_existing_contract_edate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.upgrade_existing_contract_edate);
                }
                if (this.n_bAccessory_code  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.accessory_code.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bAccessory_code=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.accessory_code);
                }
                if (this.n_bBill_medium  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.bill_medium.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bBill_medium=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.bill_medium);
                }
                if (this.n_bS_premium  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.s_premium.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bS_premium=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.s_premium);
                }
                if (this.n_bRef_staff_no  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.ref_staff_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRef_staff_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.ref_staff_no);
                }
                if (this.n_bAccessory_price  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.accessory_price.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bAccessory_price=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.accessory_price);
                }
                if (this.n_bM_card_exp_month  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.m_card_exp_month.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bM_card_exp_month=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.m_card_exp_month);
                }
                if (this.n_bInstallment_period  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.installment_period.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bInstallment_period=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.installment_period);
                }
                if (this.n_bM_card_type  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.m_card_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bM_card_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.m_card_type);
                }
                if (this.n_bEasywatch_ord_id  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.easywatch_ord_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEasywatch_ord_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.easywatch_ord_id);
                }
                if (this.n_bNormal_rebate  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.normal_rebate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bNormal_rebate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.normal_rebate);
                }
                if (this.n_bM_rebate_amount  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.m_rebate_amount.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bM_rebate_amount=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.m_rebate_amount);
                }
                if (this.n_bM_card_holder2  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.m_card_holder2.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bM_card_holder2=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.m_card_holder2);
                }
                if (this.n_bBill_medium_email  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.bill_medium_email.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bBill_medium_email=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.bill_medium_email);
                }
                if (this.n_bActive  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.active);
                }
                if (this.n_bS_premium1  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.s_premium1.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bS_premium1=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.s_premium1);
                }
                if (this.n_bCard_exp_month  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.card_exp_month.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCard_exp_month=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.card_exp_month);
                }
                if (this.n_bOb_program_id  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.ob_program_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOb_program_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.ob_program_id);
                }
                if (this.n_bSku  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.sku.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSku=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.sku);
                }
                if (this.n_bRef_salesmancode  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.ref_salesmancode.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRef_salesmancode=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.ref_salesmancode);
                }
                if (this.n_bGo_wireless_package_code  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.go_wireless_package_code.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bGo_wireless_package_code=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.go_wireless_package_code);
                }
                if (this.n_bThird_party_hkid  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.third_party_hkid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bThird_party_hkid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.third_party_hkid);
                }
                if (this.n_bUpgrade_existing_pccw_customer  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.upgrade_existing_pccw_customer.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bUpgrade_existing_pccw_customer=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.upgrade_existing_pccw_customer);
                }
                if (this.n_bD_address  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.d_address.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bD_address=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.d_address);
                }
                if (this.n_bUpgrade_registered_mobile_no  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.upgrade_registered_mobile_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bUpgrade_registered_mobile_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.upgrade_registered_mobile_no);
                }
                if (this.n_bUpgrade_existing_customer_type  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.upgrade_existing_customer_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bUpgrade_existing_customer_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.upgrade_existing_customer_type);
                }
                if (this.n_bNormal_rebate_type  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.normal_rebate_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bNormal_rebate_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.normal_rebate_type);
                }
                if (this.n_bGift_desc2  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.gift_desc2.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bGift_desc2=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.gift_desc2);
                }
                if (this.n_bMonthly_bank_account_branch_code  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.monthly_bank_account_branch_code.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMonthly_bank_account_branch_code=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.monthly_bank_account_branch_code);
                }
                if (this.n_bRemarks  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.remarks.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRemarks=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.remarks);
                }
                if (this.n_bAccept  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.accept.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bAccept=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.accept);
                }
                if (this.n_bDelivery_exchange  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.delivery_exchange.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDelivery_exchange=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.delivery_exchange);
                }
                if (this.n_bGift_code2  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.gift_code2.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bGift_code2=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.gift_code2);
                }
                if (this.n_bPrepayment_waive  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.prepayment_waive.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPrepayment_waive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.prepayment_waive);
                }
                if (this.n_bExisting_smart_phone_imei  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.existing_smart_phone_imei.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bExisting_smart_phone_imei=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.existing_smart_phone_imei);
                }
                if (this.n_bMnp_his_id  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.mnp_his_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMnp_his_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.mnp_his_id);
                }
                if (this.n_bCust_name  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.cust_name.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCust_name=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.cust_name);
                }
                if (this.n_bCust_type  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.cust_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCust_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.cust_type);
                }
                if (this.n_bUpgrade_sponsorships_amount  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.upgrade_sponsorships_amount.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bUpgrade_sponsorships_amount=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.upgrade_sponsorships_amount);
                }
                if (this.n_bBill_medium_waive  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.bill_medium_waive.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bBill_medium_waive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.bill_medium_waive);
                }
                if (this.n_bDelivery_exchange_location  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.delivery_exchange_location.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDelivery_exchange_location=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.delivery_exchange_location);
                }
                if (this.n_bHs_offer_type_id  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.hs_offer_type_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bHs_offer_type_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.hs_offer_type_id);
                }
                if (this.n_bOrg_fee  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.org_fee.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOrg_fee=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.org_fee);
                }
                if (this.n_bRebate  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.rebate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRebate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.rebate);
                }
                if (this.n_bUpgrade_type  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.upgrade_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bUpgrade_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.upgrade_type);
                }
                if (this.n_bGo_wireless  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.go_wireless.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bGo_wireless=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.go_wireless);
                }
                if (this.n_bExtra_rebate  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.extra_rebate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bExtra_rebate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.extra_rebate);
                }
                if (this.n_bPlan_eff  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.plan_eff.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPlan_eff=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.plan_eff);
                }
                if (this.n_bExtra_rebate_amount  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.extra_rebate_amount.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bExtra_rebate_amount=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.extra_rebate_amount);
                }
                if (this.n_bCard_exp_year  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.card_exp_year.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCard_exp_year=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.card_exp_year);
                }
                if (this.n_bUpgrade_existing_contract_sdate  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.upgrade_existing_contract_sdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bUpgrade_existing_contract_sdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.upgrade_existing_contract_sdate);
                }
                if (this.n_bOrd_place_hkid  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.ord_place_hkid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOrd_place_hkid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.ord_place_hkid);
                }
                if (this.n_bRegister_address  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.register_address.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRegister_address=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.register_address);
                }
                if (this.n_bGender  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.gender.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bGender=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.gender);
                }
                if (this.n_bLob_ac  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.lob_ac.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bLob_ac=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.lob_ac);
                }
                if (this.n_bSim_mrt_no  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.sim_mrt_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSim_mrt_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.sim_mrt_no);
                }
                if (this.n_bRedemption_notice_option  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.redemption_notice_option.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRedemption_notice_option=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.redemption_notice_option);
                }
                if (this.n_bDelivery_collection_type  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.delivery_collection_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDelivery_collection_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.delivery_collection_type);
                }
                if (this.n_bAction_date  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.action_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bAction_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.action_date);
                }
                if (this.n_bThird_party_id_type  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.third_party_id_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bThird_party_id_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.third_party_id_type);
                }
                if (this.n_bOrg_ftg  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.org_ftg.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOrg_ftg=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.org_ftg);
                }
                if (this.n_bUpgrade_service_tenure  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.upgrade_service_tenure.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bUpgrade_service_tenure=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.upgrade_service_tenure);
                }
                if (this.n_bMonthly_payment_type  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.monthly_payment_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMonthly_payment_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.monthly_payment_type);
                }
                if (this.n_bContact_no  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.contact_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bContact_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.contact_no);
                }
                if (this.n_bOrg_mrt  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.org_mrt.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOrg_mrt=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.org_mrt);
                }
                if (this.n_bSim_item_name  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.sim_item_name.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSim_item_name=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.sim_item_name);
                }
                if (this.n_bPay_method  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.pay_method.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPay_method=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.pay_method);
                }
                if (this.n_bHs_model  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.hs_model.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bHs_model=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.hs_model);
                }
                if (this.n_bGift_code  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.gift_code.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bGift_code=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.gift_code);
                }
                if (this.n_bMonthly_bank_account_hkid  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.monthly_bank_account_hkid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMonthly_bank_account_hkid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.monthly_bank_account_hkid);
                }
                if (this.n_bExtra_offer  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.extra_offer.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bExtra_offer=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.extra_offer);
                }
                if (this.n_bMonthly_bank_account_no  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.monthly_bank_account_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMonthly_bank_account_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.monthly_bank_account_no);
                }
                if (this.n_bFirst_month_license_fee  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.first_month_license_fee.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFirst_month_license_fee=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.first_month_license_fee);
                }
                if (this.n_bRetrieve_cnt  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.retrieve_cnt.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRetrieve_cnt=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.retrieve_cnt);
                }
                if (this.n_bDdate  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.ddate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.ddate);
                }
                if (this.n_bS_premium2  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.s_premium2.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bS_premium2=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.s_premium2);
                }
                if (this.n_bMonthly_bank_account_id_type  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.monthly_bank_account_id_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMonthly_bank_account_id_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.monthly_bank_account_id_type);
                }
                if (this.n_bCard_type  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.card_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCard_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.card_type);
                }
                if (this.n_bNext_bill  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.next_bill.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bNext_bill=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.next_bill);
                }
                if (this.n_bPcd_paid_go_wireless  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.pcd_paid_go_wireless.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPcd_paid_go_wireless=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.pcd_paid_go_wireless);
                }
                if (this.n_bUpgrade_rebate_calculation  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.upgrade_rebate_calculation.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bUpgrade_rebate_calculation=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.upgrade_rebate_calculation);
                }
                if (this.n_bExt_place_tel  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.ext_place_tel.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bExt_place_tel=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.ext_place_tel);
                }
                if (this.n_bM_3rd_hkid  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.m_3rd_hkid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bM_3rd_hkid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.m_3rd_hkid);
                }
                if (this.n_bRetention_type  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.retention_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRetention_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.retention_type);
                }
                if (this.n_bBill_address_his_id  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.bill_address_his_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bBill_address_his_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.bill_address_his_id);
                }
                if (this.n_bAig_gift  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.aig_gift.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bAig_gift=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.aig_gift);
                }
                if (this.n_bCust_staff_no  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.cust_staff_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCust_staff_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.cust_staff_no);
                }
                if (this.n_bOrder_id  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.order_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOrder_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.order_id);
                }
                if (this.n_bFamily_name  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.family_name.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFamily_name=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.family_name);
                }
                if (this.n_bCdate  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.cdate);
                }
                if (this.n_bStatus_by_cs_admin  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.status_by_cs_admin.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bStatus_by_cs_admin=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.status_by_cs_admin);
                }
                if (this.n_bSim_item_number  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.sim_item_number.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSim_item_number=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.sim_item_number);
                }
                if (this.n_bVip_case  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.vip_case.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bVip_case=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.vip_case);
                }
                if (this.n_bGiven_name  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.given_name.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bGiven_name=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.given_name);
                }
                if (this.n_bLog_date  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.log_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bLog_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.log_date);
                }
                if (this.n_bExtn  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.extn.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bExtn=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.extn);
                }
                if (this.n_bD_time  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.d_time.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bD_time=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.d_time);
                }
                if (this.n_bBank_name  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.bank_name.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bBank_name=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.bank_name);
                }
                if (this.n_bDelivery_exchange_option  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.delivery_exchange_option.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDelivery_exchange_option=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.delivery_exchange_option);
                }
                if (this.n_bUpgrade_service_account_no  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.upgrade_service_account_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bUpgrade_service_account_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.upgrade_service_account_no);
                }
                if (this.n_bAction_of_rate_plan_effective  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.action_of_rate_plan_effective.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bAction_of_rate_plan_effective=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.action_of_rate_plan_effective);
                }
                if (this.n_bM_card_no  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.m_card_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bM_card_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.m_card_no);
                }
                if (this.n_bExisting_contract_end_date  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.existing_contract_end_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bExisting_contract_end_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.existing_contract_end_date);
                }
                if (this.n_bCon_eff_date  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.con_eff_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCon_eff_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.con_eff_date);
                }
                if (this.n_bM_3rd_hkid2  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.m_3rd_hkid2.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bM_3rd_hkid2=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.m_3rd_hkid2);
                }
                if (this.n_bAmount  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.amount.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bAmount=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.amount);
                }
                if (this.n_bId_type  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.id_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.id_type);
                }
                if (this.n_bRate_plan  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.rate_plan.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRate_plan=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.rate_plan);
                }
                if (this.n_bChannel  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.channel.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bChannel=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.channel);
                }
                if (this.n_bAction_eff_date  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.action_eff_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bAction_eff_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.action_eff_date);
                }
                if (this.n_bIssue_type  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.issue_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bIssue_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.issue_type);
                }
                if (this.n_bFree_mon  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.free_mon.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFree_mon=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.free_mon);
                }
                if (this.n_bPlan_eff_date  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.plan_eff_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPlan_eff_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.plan_eff_date);
                }
                if (this.n_bDel_remark  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.del_remark.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDel_remark=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.del_remark);
                }
                if (this.n_bTeamcode  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.teamcode.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bTeamcode=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.teamcode);
                }
                if (this.n_bStaff_name  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.staff_name.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bStaff_name=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.staff_name);
                }
                if (this.n_bEdf_no  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.edf_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEdf_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.edf_no);
                }
                if (this.n_bOrd_place_by  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.ord_place_by.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOrd_place_by=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.ord_place_by);
                }
                if (this.n_bCancel_renew  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.cancel_renew.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCancel_renew=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.cancel_renew);
                }
                if (this.n_bPreferred_languages  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.preferred_languages.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPreferred_languages=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.preferred_languages);
                }
                if (this.n_bHkid  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.hkid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bHkid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.hkid);
                }
                if (this.n_bCard_no  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.card_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCard_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.card_no);
                }
                if (this.n_bAc_no  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.ac_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bAc_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.ac_no);
                }
                if (this.n_bBill_cut_num  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.bill_cut_num.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bBill_cut_num=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.bill_cut_num);
                }
                if (this.n_bPremium  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.premium.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPremium=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.premium);
                }
                if (this.n_bM_3rd_id_type  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.m_3rd_id_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bM_3rd_id_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.m_3rd_id_type);
                }
                if (this.n_bGift_imei2  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.gift_imei2.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bGift_imei2=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.gift_imei2);
                }
                if (this.n_bReasons  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.reasons.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bReasons=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.reasons);
                }
                if (this.n_bLanguage  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.language.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bLanguage=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.language);
                }
                if (this.n_bRebate_amount  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.rebate_amount.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRebate_amount=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.rebate_amount);
                }
                if (this.n_bLob  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.lob.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bLob=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.lob);
                }
                if (this.n_bM_3rd_contact_no  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.m_3rd_contact_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bM_3rd_contact_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.m_3rd_contact_no);
                }
                if (this.n_bStaff_no  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.staff_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bStaff_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.staff_no);
                }
                if (this.n_bS_premium3  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.s_premium3.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bS_premium3=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.s_premium3);
                }
                if (this.n_bSp_d_date  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.sp_d_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSp_d_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.sp_d_date);
                }
                if (this.n_bBundle_name  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.bundle_name.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bBundle_name=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.bundle_name);
                }
                if (this.n_bAccessory_waive  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.accessory_waive.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bAccessory_waive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.accessory_waive);
                }
                if (this.n_bSim_item_code  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.sim_item_code.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSim_item_code=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.sim_item_code);
                }
                if (this.n_bMonthly_bank_account_holder  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.monthly_bank_account_holder.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMonthly_bank_account_holder=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.monthly_bank_account_holder);
                }
                if (this.n_bCard_holder  || x_bSetShowALL || (MobileRetentionPreviousOrder.Para.card_holder.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCard_holder=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionPreviousOrder.Para.card_holder);
                }
                return _oFR.ToString();
            }
            
            public string FieldsToReturn()
            {
                return this.FieldsToReturn(string.Empty,false);
            }
            
        }
        #endregion
        #region Constructor
        
        public MobileRetentionPreviousOrderDalDAO(){
        }
        ~MobileRetentionPreviousOrderDalDAO(){
            this.Release();
        }
        #endregion
        
        #region Search Engine
        public static global::System.Data.SqlClient.SqlDataReader DrSearch(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, string x_sFieldsToReturn,string x_sSortByField,bool x_bAscDirection)
        {
            SearchUtils _oSearchUtils = new SearchUtils();
            _oSearchUtils.SetSearchItems(x_oSearchItems);
            _oSearchUtils.SetRowFilter(x_sRowFilter);
            _oSearchUtils.SetStart(x_lStart);
            _oSearchUtils.SetLimit(x_lLimit);
            _oSearchUtils.SetFieldsToReturn(x_sFieldsToReturn);
            _oSearchUtils.SetOrderByField(x_sSortByField);
            _oSearchUtils.SetAscDirection(x_bAscDirection);
            _oSearchUtils.SetTable(MobileRetentionPreviousOrder.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<MobileRetentionPreviousOrderEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, MobileRetentionPreviousOrderRS x_oFieldsToReturn,MobileRetentionPreviousOrderRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<MobileRetentionPreviousOrderEntity> _oMobileRetentionPreviousOrderList = new List<MobileRetentionPreviousOrderEntity>();
                
                while (_oDATA.Read())
                {
                    MobileRetentionPreviousOrder _oMobileRetentionPreviousOrder = new MobileRetentionPreviousOrder();
                    if ((true).Equals(x_oFieldsToReturn.n_bGift_imei))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.gift_imei])) { _oMobileRetentionPreviousOrder.SetGift_imei((string)_oDATA[MobileRetentionPreviousOrder.Para.gift_imei]); } else { _oMobileRetentionPreviousOrder.SetGift_imei(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bS_premium4))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.s_premium4])) { _oMobileRetentionPreviousOrder.SetS_premium4((string)_oDATA[MobileRetentionPreviousOrder.Para.s_premium4]); } else { _oMobileRetentionPreviousOrder.SetS_premium4(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bGift_desc4))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.gift_desc4])) { _oMobileRetentionPreviousOrder.SetGift_desc4((string)_oDATA[MobileRetentionPreviousOrder.Para.gift_desc4]); } else { _oMobileRetentionPreviousOrder.SetGift_desc4(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bAccessory_desc))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.accessory_desc])) { _oMobileRetentionPreviousOrder.SetAccessory_desc((string)_oDATA[MobileRetentionPreviousOrder.Para.accessory_desc]); } else { _oMobileRetentionPreviousOrder.SetAccessory_desc(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bAction_required))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.action_required])) { _oMobileRetentionPreviousOrder.SetAction_required((string)_oDATA[MobileRetentionPreviousOrder.Para.action_required]); } else { _oMobileRetentionPreviousOrder.SetAction_required(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRegistered_address_his_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.registered_address_his_id])) { _oMobileRetentionPreviousOrder.SetRegistered_address_his_id((global::System.Nullable<long>)_oDATA[MobileRetentionPreviousOrder.Para.registered_address_his_id]); } else { _oMobileRetentionPreviousOrder.SetRegistered_address_his_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bVas_eff_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.vas_eff_date])) { _oMobileRetentionPreviousOrder.SetVas_eff_date((global::System.Nullable<DateTime>)_oDATA[MobileRetentionPreviousOrder.Para.vas_eff_date]); } else { _oMobileRetentionPreviousOrder.SetVas_eff_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMonthly_bank_account_bank_code))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.monthly_bank_account_bank_code])) { _oMobileRetentionPreviousOrder.SetMonthly_bank_account_bank_code((string)_oDATA[MobileRetentionPreviousOrder.Para.monthly_bank_account_bank_code]); } else { _oMobileRetentionPreviousOrder.SetMonthly_bank_account_bank_code(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSpecial_handling_dummy_code))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.special_handling_dummy_code])) { _oMobileRetentionPreviousOrder.SetSpecial_handling_dummy_code((string)_oDATA[MobileRetentionPreviousOrder.Para.special_handling_dummy_code]); } else { _oMobileRetentionPreviousOrder.SetSpecial_handling_dummy_code(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bM_card_exp_year))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.m_card_exp_year])) { _oMobileRetentionPreviousOrder.SetM_card_exp_year((string)_oDATA[MobileRetentionPreviousOrder.Para.m_card_exp_year]); } else { _oMobileRetentionPreviousOrder.SetM_card_exp_year(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRemarks2PY))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.remarks2PY])) { _oMobileRetentionPreviousOrder.SetRemarks2PY((string)_oDATA[MobileRetentionPreviousOrder.Para.remarks2PY]); } else { _oMobileRetentionPreviousOrder.SetRemarks2PY(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bTrade_field))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.trade_field])) { _oMobileRetentionPreviousOrder.SetTrade_field((string)_oDATA[MobileRetentionPreviousOrder.Para.trade_field]); } else { _oMobileRetentionPreviousOrder.SetTrade_field(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOrd_place_tel))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.ord_place_tel])) { _oMobileRetentionPreviousOrder.SetOrd_place_tel((string)_oDATA[MobileRetentionPreviousOrder.Para.ord_place_tel]); } else { _oMobileRetentionPreviousOrder.SetOrd_place_tel(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOrd_place_id_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.ord_place_id_type])) { _oMobileRetentionPreviousOrder.SetOrd_place_id_type((string)_oDATA[MobileRetentionPreviousOrder.Para.ord_place_id_type]); } else { _oMobileRetentionPreviousOrder.SetOrd_place_id_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCooling_offer))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.cooling_offer])) { _oMobileRetentionPreviousOrder.SetCooling_offer((string)_oDATA[MobileRetentionPreviousOrder.Para.cooling_offer]); } else { _oMobileRetentionPreviousOrder.SetCooling_offer(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRec_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.rec_no])) { _oMobileRetentionPreviousOrder.SetRec_no((global::System.Nullable<int>)_oDATA[MobileRetentionPreviousOrder.Para.rec_no]); } else { _oMobileRetentionPreviousOrder.SetRec_no(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bUpgrade_handset_offer_rebate_schedule))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.upgrade_handset_offer_rebate_schedule])) { _oMobileRetentionPreviousOrder.SetUpgrade_handset_offer_rebate_schedule((string)_oDATA[MobileRetentionPreviousOrder.Para.upgrade_handset_offer_rebate_schedule]); } else { _oMobileRetentionPreviousOrder.SetUpgrade_handset_offer_rebate_schedule(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bChange_payment_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.change_payment_type])) { _oMobileRetentionPreviousOrder.SetChange_payment_type((string)_oDATA[MobileRetentionPreviousOrder.Para.change_payment_type]); } else { _oMobileRetentionPreviousOrder.SetChange_payment_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDate_of_birth))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.date_of_birth])) { _oMobileRetentionPreviousOrder.SetDate_of_birth((global::System.Nullable<DateTime>)_oDATA[MobileRetentionPreviousOrder.Para.date_of_birth]); } else { _oMobileRetentionPreviousOrder.SetDate_of_birth(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bContact_person))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.contact_person])) { _oMobileRetentionPreviousOrder.SetContact_person((string)_oDATA[MobileRetentionPreviousOrder.Para.contact_person]); } else { _oMobileRetentionPreviousOrder.SetContact_person(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bExtra_d_charge))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.extra_d_charge])) { _oMobileRetentionPreviousOrder.SetExtra_d_charge((string)_oDATA[MobileRetentionPreviousOrder.Para.extra_d_charge]); } else { _oMobileRetentionPreviousOrder.SetExtra_d_charge(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bTl_name))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.tl_name])) { _oMobileRetentionPreviousOrder.SetTl_name((string)_oDATA[MobileRetentionPreviousOrder.Para.tl_name]); } else { _oMobileRetentionPreviousOrder.SetTl_name(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFast_start))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.fast_start])) { _oMobileRetentionPreviousOrder.SetFast_start((global::System.Nullable<bool>)_oDATA[MobileRetentionPreviousOrder.Para.fast_start]); } else { _oMobileRetentionPreviousOrder.SetFast_start(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSp_ref_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.sp_ref_no])) { _oMobileRetentionPreviousOrder.SetSp_ref_no((string)_oDATA[MobileRetentionPreviousOrder.Para.sp_ref_no]); } else { _oMobileRetentionPreviousOrder.SetSp_ref_no(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.edate])) { _oMobileRetentionPreviousOrder.SetEdate((global::System.Nullable<DateTime>)_oDATA[MobileRetentionPreviousOrder.Para.edate]); } else { _oMobileRetentionPreviousOrder.SetEdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bExist_cust_plan))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.exist_cust_plan])) { _oMobileRetentionPreviousOrder.SetExist_cust_plan((string)_oDATA[MobileRetentionPreviousOrder.Para.exist_cust_plan]); } else { _oMobileRetentionPreviousOrder.SetExist_cust_plan(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOrd_place_rel))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.ord_place_rel])) { _oMobileRetentionPreviousOrder.SetOrd_place_rel((string)_oDATA[MobileRetentionPreviousOrder.Para.ord_place_rel]); } else { _oMobileRetentionPreviousOrder.SetOrd_place_rel(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMrt_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.mrt_no])) { _oMobileRetentionPreviousOrder.SetMrt_no((global::System.Nullable<int>)_oDATA[MobileRetentionPreviousOrder.Para.mrt_no]); } else { _oMobileRetentionPreviousOrder.SetMrt_no(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bImei_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.imei_no])) { _oMobileRetentionPreviousOrder.SetImei_no((string)_oDATA[MobileRetentionPreviousOrder.Para.imei_no]); } else { _oMobileRetentionPreviousOrder.SetImei_no(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bExisting_smart_phone_model))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.existing_smart_phone_model])) { _oMobileRetentionPreviousOrder.SetExisting_smart_phone_model((string)_oDATA[MobileRetentionPreviousOrder.Para.existing_smart_phone_model]); } else { _oMobileRetentionPreviousOrder.SetExisting_smart_phone_model(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bGift_code3))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.gift_code3])) { _oMobileRetentionPreviousOrder.SetGift_code3((string)_oDATA[MobileRetentionPreviousOrder.Para.gift_code3]); } else { _oMobileRetentionPreviousOrder.SetGift_code3(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bBank_code))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.bank_code])) { _oMobileRetentionPreviousOrder.SetBank_code((string)_oDATA[MobileRetentionPreviousOrder.Para.bank_code]); } else { _oMobileRetentionPreviousOrder.SetBank_code(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPos_ref_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.pos_ref_no])) { _oMobileRetentionPreviousOrder.SetPos_ref_no((string)_oDATA[MobileRetentionPreviousOrder.Para.pos_ref_no]); } else { _oMobileRetentionPreviousOrder.SetPos_ref_no(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bBill_cut_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.bill_cut_date])) { _oMobileRetentionPreviousOrder.SetBill_cut_date((global::System.Nullable<DateTime>)_oDATA[MobileRetentionPreviousOrder.Para.bill_cut_date]); } else { _oMobileRetentionPreviousOrder.SetBill_cut_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bGift_imei3))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.gift_imei3])) { _oMobileRetentionPreviousOrder.SetGift_imei3((string)_oDATA[MobileRetentionPreviousOrder.Para.gift_imei3]); } else { _oMobileRetentionPreviousOrder.SetGift_imei3(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bExist_plan))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.exist_plan])) { _oMobileRetentionPreviousOrder.SetExist_plan((string)_oDATA[MobileRetentionPreviousOrder.Para.exist_plan]); } else { _oMobileRetentionPreviousOrder.SetExist_plan(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bWaive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.waive])) { _oMobileRetentionPreviousOrder.SetWaive((global::System.Nullable<bool>)_oDATA[MobileRetentionPreviousOrder.Para.waive]); } else { _oMobileRetentionPreviousOrder.SetWaive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bProgram))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.program])) { _oMobileRetentionPreviousOrder.SetProgram((string)_oDATA[MobileRetentionPreviousOrder.Para.program]); } else { _oMobileRetentionPreviousOrder.SetProgram(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFirst_month_fee))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.first_month_fee])) { _oMobileRetentionPreviousOrder.SetFirst_month_fee((string)_oDATA[MobileRetentionPreviousOrder.Para.first_month_fee]); } else { _oMobileRetentionPreviousOrder.SetFirst_month_fee(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bR_offer))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.r_offer])) { _oMobileRetentionPreviousOrder.SetR_offer((string)_oDATA[MobileRetentionPreviousOrder.Para.r_offer]); } else { _oMobileRetentionPreviousOrder.SetR_offer(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.cid])) { _oMobileRetentionPreviousOrder.SetCid((string)_oDATA[MobileRetentionPreviousOrder.Para.cid]); } else { _oMobileRetentionPreviousOrder.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.did])) { _oMobileRetentionPreviousOrder.SetDid((string)_oDATA[MobileRetentionPreviousOrder.Para.did]); } else { _oMobileRetentionPreviousOrder.SetDid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFtg_tenure))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.ftg_tenure])) { _oMobileRetentionPreviousOrder.SetFtg_tenure((string)_oDATA[MobileRetentionPreviousOrder.Para.ftg_tenure]); } else { _oMobileRetentionPreviousOrder.SetFtg_tenure(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCon_per))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.con_per])) { _oMobileRetentionPreviousOrder.SetCon_per((string)_oDATA[MobileRetentionPreviousOrder.Para.con_per]); } else { _oMobileRetentionPreviousOrder.SetCon_per(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bGift_code4))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.gift_code4])) { _oMobileRetentionPreviousOrder.SetGift_code4((string)_oDATA[MobileRetentionPreviousOrder.Para.gift_code4]); } else { _oMobileRetentionPreviousOrder.SetGift_code4(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEasywatch_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.easywatch_type])) { _oMobileRetentionPreviousOrder.SetEasywatch_type((string)_oDATA[MobileRetentionPreviousOrder.Para.easywatch_type]); } else { _oMobileRetentionPreviousOrder.SetEasywatch_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSms_mrt))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.sms_mrt])) { _oMobileRetentionPreviousOrder.SetSms_mrt((string)_oDATA[MobileRetentionPreviousOrder.Para.sms_mrt]); } else { _oMobileRetentionPreviousOrder.SetSms_mrt(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bTpy_his_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.tpy_his_id])) { _oMobileRetentionPreviousOrder.SetTpy_his_id((global::System.Nullable<long>)_oDATA[MobileRetentionPreviousOrder.Para.tpy_his_id]); } else { _oMobileRetentionPreviousOrder.SetTpy_his_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMonthly_payment_method))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.monthly_payment_method])) { _oMobileRetentionPreviousOrder.SetMonthly_payment_method((string)_oDATA[MobileRetentionPreviousOrder.Para.monthly_payment_method]); } else { _oMobileRetentionPreviousOrder.SetMonthly_payment_method(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRemarks2EDF))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.remarks2EDF])) { _oMobileRetentionPreviousOrder.SetRemarks2EDF((string)_oDATA[MobileRetentionPreviousOrder.Para.remarks2EDF]); } else { _oMobileRetentionPreviousOrder.SetRemarks2EDF(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bGift_desc3))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.gift_desc3])) { _oMobileRetentionPreviousOrder.SetGift_desc3((string)_oDATA[MobileRetentionPreviousOrder.Para.gift_desc3]); } else { _oMobileRetentionPreviousOrder.SetGift_desc3(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bGift_imei4))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.gift_imei4])) { _oMobileRetentionPreviousOrder.SetGift_imei4((string)_oDATA[MobileRetentionPreviousOrder.Para.gift_imei4]); } else { _oMobileRetentionPreviousOrder.SetGift_imei4(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOld_ord_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.old_ord_id])) { _oMobileRetentionPreviousOrder.SetOld_ord_id((global::System.Nullable<int>)_oDATA[MobileRetentionPreviousOrder.Para.old_ord_id]); } else { _oMobileRetentionPreviousOrder.SetOld_ord_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMonthly_bank_account_hkid2))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.monthly_bank_account_hkid2])) { _oMobileRetentionPreviousOrder.SetMonthly_bank_account_hkid2((string)_oDATA[MobileRetentionPreviousOrder.Para.monthly_bank_account_hkid2]); } else { _oMobileRetentionPreviousOrder.SetMonthly_bank_account_hkid2(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bD_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.d_date])) { _oMobileRetentionPreviousOrder.SetD_date((global::System.Nullable<DateTime>)_oDATA[MobileRetentionPreviousOrder.Para.d_date]); } else { _oMobileRetentionPreviousOrder.SetD_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bGift_desc))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.gift_desc])) { _oMobileRetentionPreviousOrder.SetGift_desc((string)_oDATA[MobileRetentionPreviousOrder.Para.gift_desc]); } else { _oMobileRetentionPreviousOrder.SetGift_desc(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSalesmancode))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.salesmancode])) { _oMobileRetentionPreviousOrder.SetSalesmancode((string)_oDATA[MobileRetentionPreviousOrder.Para.salesmancode]); } else { _oMobileRetentionPreviousOrder.SetSalesmancode(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPool))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.pool])) { _oMobileRetentionPreviousOrder.SetPool((string)_oDATA[MobileRetentionPreviousOrder.Para.pool]); } else { _oMobileRetentionPreviousOrder.SetPool(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCn_mrt_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.cn_mrt_no])) { _oMobileRetentionPreviousOrder.SetCn_mrt_no((global::System.Nullable<long>)_oDATA[MobileRetentionPreviousOrder.Para.cn_mrt_no]); } else { _oMobileRetentionPreviousOrder.SetCn_mrt_no(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bAccessory_imei))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.accessory_imei])) { _oMobileRetentionPreviousOrder.SetAccessory_imei((string)_oDATA[MobileRetentionPreviousOrder.Para.accessory_imei]); } else { _oMobileRetentionPreviousOrder.SetAccessory_imei(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bThird_party_credit_card))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.third_party_credit_card])) { _oMobileRetentionPreviousOrder.SetThird_party_credit_card((string)_oDATA[MobileRetentionPreviousOrder.Para.third_party_credit_card]); } else { _oMobileRetentionPreviousOrder.SetThird_party_credit_card(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCard_ref_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.card_ref_no])) { _oMobileRetentionPreviousOrder.SetCard_ref_no((string)_oDATA[MobileRetentionPreviousOrder.Para.card_ref_no]); } else { _oMobileRetentionPreviousOrder.SetCard_ref_no(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCooling_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.cooling_date])) { _oMobileRetentionPreviousOrder.SetCooling_date((global::System.Nullable<DateTime>)_oDATA[MobileRetentionPreviousOrder.Para.cooling_date]); } else { _oMobileRetentionPreviousOrder.SetCooling_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSpecial_approval))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.special_approval])) { _oMobileRetentionPreviousOrder.SetSpecial_approval((string)_oDATA[MobileRetentionPreviousOrder.Para.special_approval]); } else { _oMobileRetentionPreviousOrder.SetSpecial_approval(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bUpgrade_existing_contract_edate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.upgrade_existing_contract_edate])) { _oMobileRetentionPreviousOrder.SetUpgrade_existing_contract_edate((global::System.Nullable<DateTime>)_oDATA[MobileRetentionPreviousOrder.Para.upgrade_existing_contract_edate]); } else { _oMobileRetentionPreviousOrder.SetUpgrade_existing_contract_edate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bAccessory_code))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.accessory_code])) { _oMobileRetentionPreviousOrder.SetAccessory_code((string)_oDATA[MobileRetentionPreviousOrder.Para.accessory_code]); } else { _oMobileRetentionPreviousOrder.SetAccessory_code(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bBill_medium))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.bill_medium])) { _oMobileRetentionPreviousOrder.SetBill_medium((string)_oDATA[MobileRetentionPreviousOrder.Para.bill_medium]); } else { _oMobileRetentionPreviousOrder.SetBill_medium(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bS_premium))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.s_premium])) { _oMobileRetentionPreviousOrder.SetS_premium((string)_oDATA[MobileRetentionPreviousOrder.Para.s_premium]); } else { _oMobileRetentionPreviousOrder.SetS_premium(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRef_staff_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.ref_staff_no])) { _oMobileRetentionPreviousOrder.SetRef_staff_no((string)_oDATA[MobileRetentionPreviousOrder.Para.ref_staff_no]); } else { _oMobileRetentionPreviousOrder.SetRef_staff_no(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bAccessory_price))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.accessory_price])) { _oMobileRetentionPreviousOrder.SetAccessory_price((string)_oDATA[MobileRetentionPreviousOrder.Para.accessory_price]); } else { _oMobileRetentionPreviousOrder.SetAccessory_price(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bM_card_exp_month))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.m_card_exp_month])) { _oMobileRetentionPreviousOrder.SetM_card_exp_month((string)_oDATA[MobileRetentionPreviousOrder.Para.m_card_exp_month]); } else { _oMobileRetentionPreviousOrder.SetM_card_exp_month(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bInstallment_period))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.installment_period])) { _oMobileRetentionPreviousOrder.SetInstallment_period((string)_oDATA[MobileRetentionPreviousOrder.Para.installment_period]); } else { _oMobileRetentionPreviousOrder.SetInstallment_period(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bM_card_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.m_card_type])) { _oMobileRetentionPreviousOrder.SetM_card_type((string)_oDATA[MobileRetentionPreviousOrder.Para.m_card_type]); } else { _oMobileRetentionPreviousOrder.SetM_card_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEasywatch_ord_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.easywatch_ord_id])) { _oMobileRetentionPreviousOrder.SetEasywatch_ord_id((string)_oDATA[MobileRetentionPreviousOrder.Para.easywatch_ord_id]); } else { _oMobileRetentionPreviousOrder.SetEasywatch_ord_id(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bNormal_rebate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.normal_rebate])) { _oMobileRetentionPreviousOrder.SetNormal_rebate((global::System.Nullable<bool>)_oDATA[MobileRetentionPreviousOrder.Para.normal_rebate]); } else { _oMobileRetentionPreviousOrder.SetNormal_rebate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bM_rebate_amount))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.m_rebate_amount])) { _oMobileRetentionPreviousOrder.SetM_rebate_amount((string)_oDATA[MobileRetentionPreviousOrder.Para.m_rebate_amount]); } else { _oMobileRetentionPreviousOrder.SetM_rebate_amount(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bM_card_holder2))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.m_card_holder2])) { _oMobileRetentionPreviousOrder.SetM_card_holder2((string)_oDATA[MobileRetentionPreviousOrder.Para.m_card_holder2]); } else { _oMobileRetentionPreviousOrder.SetM_card_holder2(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bBill_medium_email))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.bill_medium_email])) { _oMobileRetentionPreviousOrder.SetBill_medium_email((string)_oDATA[MobileRetentionPreviousOrder.Para.bill_medium_email]); } else { _oMobileRetentionPreviousOrder.SetBill_medium_email(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.active])) { _oMobileRetentionPreviousOrder.SetActive((global::System.Nullable<bool>)_oDATA[MobileRetentionPreviousOrder.Para.active]); } else { _oMobileRetentionPreviousOrder.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bS_premium1))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.s_premium1])) { _oMobileRetentionPreviousOrder.SetS_premium1((string)_oDATA[MobileRetentionPreviousOrder.Para.s_premium1]); } else { _oMobileRetentionPreviousOrder.SetS_premium1(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCard_exp_month))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.card_exp_month])) { _oMobileRetentionPreviousOrder.SetCard_exp_month((string)_oDATA[MobileRetentionPreviousOrder.Para.card_exp_month]); } else { _oMobileRetentionPreviousOrder.SetCard_exp_month(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOb_program_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.ob_program_id])) { _oMobileRetentionPreviousOrder.SetOb_program_id((string)_oDATA[MobileRetentionPreviousOrder.Para.ob_program_id]); } else { _oMobileRetentionPreviousOrder.SetOb_program_id(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSku))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.sku])) { _oMobileRetentionPreviousOrder.SetSku((string)_oDATA[MobileRetentionPreviousOrder.Para.sku]); } else { _oMobileRetentionPreviousOrder.SetSku(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRef_salesmancode))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.ref_salesmancode])) { _oMobileRetentionPreviousOrder.SetRef_salesmancode((string)_oDATA[MobileRetentionPreviousOrder.Para.ref_salesmancode]); } else { _oMobileRetentionPreviousOrder.SetRef_salesmancode(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bGo_wireless_package_code))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.go_wireless_package_code])) { _oMobileRetentionPreviousOrder.SetGo_wireless_package_code((string)_oDATA[MobileRetentionPreviousOrder.Para.go_wireless_package_code]); } else { _oMobileRetentionPreviousOrder.SetGo_wireless_package_code(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bThird_party_hkid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.third_party_hkid])) { _oMobileRetentionPreviousOrder.SetThird_party_hkid((string)_oDATA[MobileRetentionPreviousOrder.Para.third_party_hkid]); } else { _oMobileRetentionPreviousOrder.SetThird_party_hkid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bUpgrade_existing_pccw_customer))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.upgrade_existing_pccw_customer])) { _oMobileRetentionPreviousOrder.SetUpgrade_existing_pccw_customer((string)_oDATA[MobileRetentionPreviousOrder.Para.upgrade_existing_pccw_customer]); } else { _oMobileRetentionPreviousOrder.SetUpgrade_existing_pccw_customer(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bD_address))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.d_address])) { _oMobileRetentionPreviousOrder.SetD_address((string)_oDATA[MobileRetentionPreviousOrder.Para.d_address]); } else { _oMobileRetentionPreviousOrder.SetD_address(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bUpgrade_registered_mobile_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.upgrade_registered_mobile_no])) { _oMobileRetentionPreviousOrder.SetUpgrade_registered_mobile_no((string)_oDATA[MobileRetentionPreviousOrder.Para.upgrade_registered_mobile_no]); } else { _oMobileRetentionPreviousOrder.SetUpgrade_registered_mobile_no(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bUpgrade_existing_customer_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.upgrade_existing_customer_type])) { _oMobileRetentionPreviousOrder.SetUpgrade_existing_customer_type((string)_oDATA[MobileRetentionPreviousOrder.Para.upgrade_existing_customer_type]); } else { _oMobileRetentionPreviousOrder.SetUpgrade_existing_customer_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bNormal_rebate_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.normal_rebate_type])) { _oMobileRetentionPreviousOrder.SetNormal_rebate_type((string)_oDATA[MobileRetentionPreviousOrder.Para.normal_rebate_type]); } else { _oMobileRetentionPreviousOrder.SetNormal_rebate_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bGift_desc2))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.gift_desc2])) { _oMobileRetentionPreviousOrder.SetGift_desc2((string)_oDATA[MobileRetentionPreviousOrder.Para.gift_desc2]); } else { _oMobileRetentionPreviousOrder.SetGift_desc2(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMonthly_bank_account_branch_code))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.monthly_bank_account_branch_code])) { _oMobileRetentionPreviousOrder.SetMonthly_bank_account_branch_code((string)_oDATA[MobileRetentionPreviousOrder.Para.monthly_bank_account_branch_code]); } else { _oMobileRetentionPreviousOrder.SetMonthly_bank_account_branch_code(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRemarks))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.remarks])) { _oMobileRetentionPreviousOrder.SetRemarks((string)_oDATA[MobileRetentionPreviousOrder.Para.remarks]); } else { _oMobileRetentionPreviousOrder.SetRemarks(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bAccept))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.accept])) { _oMobileRetentionPreviousOrder.SetAccept((string)_oDATA[MobileRetentionPreviousOrder.Para.accept]); } else { _oMobileRetentionPreviousOrder.SetAccept(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDelivery_exchange))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.delivery_exchange])) { _oMobileRetentionPreviousOrder.SetDelivery_exchange((string)_oDATA[MobileRetentionPreviousOrder.Para.delivery_exchange]); } else { _oMobileRetentionPreviousOrder.SetDelivery_exchange(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bGift_code2))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.gift_code2])) { _oMobileRetentionPreviousOrder.SetGift_code2((string)_oDATA[MobileRetentionPreviousOrder.Para.gift_code2]); } else { _oMobileRetentionPreviousOrder.SetGift_code2(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPrepayment_waive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.prepayment_waive])) { _oMobileRetentionPreviousOrder.SetPrepayment_waive((global::System.Nullable<bool>)_oDATA[MobileRetentionPreviousOrder.Para.prepayment_waive]); } else { _oMobileRetentionPreviousOrder.SetPrepayment_waive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bExisting_smart_phone_imei))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.existing_smart_phone_imei])) { _oMobileRetentionPreviousOrder.SetExisting_smart_phone_imei((string)_oDATA[MobileRetentionPreviousOrder.Para.existing_smart_phone_imei]); } else { _oMobileRetentionPreviousOrder.SetExisting_smart_phone_imei(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMnp_his_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.mnp_his_id])) { _oMobileRetentionPreviousOrder.SetMnp_his_id((global::System.Nullable<long>)_oDATA[MobileRetentionPreviousOrder.Para.mnp_his_id]); } else { _oMobileRetentionPreviousOrder.SetMnp_his_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCust_name))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.cust_name])) { _oMobileRetentionPreviousOrder.SetCust_name((string)_oDATA[MobileRetentionPreviousOrder.Para.cust_name]); } else { _oMobileRetentionPreviousOrder.SetCust_name(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCust_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.cust_type])) { _oMobileRetentionPreviousOrder.SetCust_type((string)_oDATA[MobileRetentionPreviousOrder.Para.cust_type]); } else { _oMobileRetentionPreviousOrder.SetCust_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bUpgrade_sponsorships_amount))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.upgrade_sponsorships_amount])) { _oMobileRetentionPreviousOrder.SetUpgrade_sponsorships_amount((string)_oDATA[MobileRetentionPreviousOrder.Para.upgrade_sponsorships_amount]); } else { _oMobileRetentionPreviousOrder.SetUpgrade_sponsorships_amount(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bBill_medium_waive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.bill_medium_waive])) { _oMobileRetentionPreviousOrder.SetBill_medium_waive((global::System.Nullable<bool>)_oDATA[MobileRetentionPreviousOrder.Para.bill_medium_waive]); } else { _oMobileRetentionPreviousOrder.SetBill_medium_waive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDelivery_exchange_location))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.delivery_exchange_location])) { _oMobileRetentionPreviousOrder.SetDelivery_exchange_location((string)_oDATA[MobileRetentionPreviousOrder.Para.delivery_exchange_location]); } else { _oMobileRetentionPreviousOrder.SetDelivery_exchange_location(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bHs_offer_type_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.hs_offer_type_id])) { _oMobileRetentionPreviousOrder.SetHs_offer_type_id((global::System.Nullable<int>)_oDATA[MobileRetentionPreviousOrder.Para.hs_offer_type_id]); } else { _oMobileRetentionPreviousOrder.SetHs_offer_type_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOrg_fee))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.org_fee])) { _oMobileRetentionPreviousOrder.SetOrg_fee((string)_oDATA[MobileRetentionPreviousOrder.Para.org_fee]); } else { _oMobileRetentionPreviousOrder.SetOrg_fee(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRebate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.rebate])) { _oMobileRetentionPreviousOrder.SetRebate((string)_oDATA[MobileRetentionPreviousOrder.Para.rebate]); } else { _oMobileRetentionPreviousOrder.SetRebate(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bUpgrade_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.upgrade_type])) { _oMobileRetentionPreviousOrder.SetUpgrade_type((string)_oDATA[MobileRetentionPreviousOrder.Para.upgrade_type]); } else { _oMobileRetentionPreviousOrder.SetUpgrade_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bGo_wireless))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.go_wireless])) { _oMobileRetentionPreviousOrder.SetGo_wireless((string)_oDATA[MobileRetentionPreviousOrder.Para.go_wireless]); } else { _oMobileRetentionPreviousOrder.SetGo_wireless(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bExtra_rebate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.extra_rebate])) { _oMobileRetentionPreviousOrder.SetExtra_rebate((string)_oDATA[MobileRetentionPreviousOrder.Para.extra_rebate]); } else { _oMobileRetentionPreviousOrder.SetExtra_rebate(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPlan_eff))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.plan_eff])) { _oMobileRetentionPreviousOrder.SetPlan_eff((string)_oDATA[MobileRetentionPreviousOrder.Para.plan_eff]); } else { _oMobileRetentionPreviousOrder.SetPlan_eff(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bExtra_rebate_amount))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.extra_rebate_amount])) { _oMobileRetentionPreviousOrder.SetExtra_rebate_amount((string)_oDATA[MobileRetentionPreviousOrder.Para.extra_rebate_amount]); } else { _oMobileRetentionPreviousOrder.SetExtra_rebate_amount(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCard_exp_year))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.card_exp_year])) { _oMobileRetentionPreviousOrder.SetCard_exp_year((string)_oDATA[MobileRetentionPreviousOrder.Para.card_exp_year]); } else { _oMobileRetentionPreviousOrder.SetCard_exp_year(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bUpgrade_existing_contract_sdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.upgrade_existing_contract_sdate])) { _oMobileRetentionPreviousOrder.SetUpgrade_existing_contract_sdate((global::System.Nullable<DateTime>)_oDATA[MobileRetentionPreviousOrder.Para.upgrade_existing_contract_sdate]); } else { _oMobileRetentionPreviousOrder.SetUpgrade_existing_contract_sdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOrd_place_hkid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.ord_place_hkid])) { _oMobileRetentionPreviousOrder.SetOrd_place_hkid((string)_oDATA[MobileRetentionPreviousOrder.Para.ord_place_hkid]); } else { _oMobileRetentionPreviousOrder.SetOrd_place_hkid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRegister_address))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.register_address])) { _oMobileRetentionPreviousOrder.SetRegister_address((string)_oDATA[MobileRetentionPreviousOrder.Para.register_address]); } else { _oMobileRetentionPreviousOrder.SetRegister_address(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bGender))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.gender])) { _oMobileRetentionPreviousOrder.SetGender((string)_oDATA[MobileRetentionPreviousOrder.Para.gender]); } else { _oMobileRetentionPreviousOrder.SetGender(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bLob_ac))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.lob_ac])) { _oMobileRetentionPreviousOrder.SetLob_ac((string)_oDATA[MobileRetentionPreviousOrder.Para.lob_ac]); } else { _oMobileRetentionPreviousOrder.SetLob_ac(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSim_mrt_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.sim_mrt_no])) { _oMobileRetentionPreviousOrder.SetSim_mrt_no((global::System.Nullable<int>)_oDATA[MobileRetentionPreviousOrder.Para.sim_mrt_no]); } else { _oMobileRetentionPreviousOrder.SetSim_mrt_no(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRedemption_notice_option))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.redemption_notice_option])) { _oMobileRetentionPreviousOrder.SetRedemption_notice_option((string)_oDATA[MobileRetentionPreviousOrder.Para.redemption_notice_option]); } else { _oMobileRetentionPreviousOrder.SetRedemption_notice_option(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDelivery_collection_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.delivery_collection_type])) { _oMobileRetentionPreviousOrder.SetDelivery_collection_type((string)_oDATA[MobileRetentionPreviousOrder.Para.delivery_collection_type]); } else { _oMobileRetentionPreviousOrder.SetDelivery_collection_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bAction_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.action_date])) { _oMobileRetentionPreviousOrder.SetAction_date((global::System.Nullable<DateTime>)_oDATA[MobileRetentionPreviousOrder.Para.action_date]); } else { _oMobileRetentionPreviousOrder.SetAction_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bThird_party_id_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.third_party_id_type])) { _oMobileRetentionPreviousOrder.SetThird_party_id_type((string)_oDATA[MobileRetentionPreviousOrder.Para.third_party_id_type]); } else { _oMobileRetentionPreviousOrder.SetThird_party_id_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOrg_ftg))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.org_ftg])) { _oMobileRetentionPreviousOrder.SetOrg_ftg((string)_oDATA[MobileRetentionPreviousOrder.Para.org_ftg]); } else { _oMobileRetentionPreviousOrder.SetOrg_ftg(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bUpgrade_service_tenure))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.upgrade_service_tenure])) { _oMobileRetentionPreviousOrder.SetUpgrade_service_tenure((string)_oDATA[MobileRetentionPreviousOrder.Para.upgrade_service_tenure]); } else { _oMobileRetentionPreviousOrder.SetUpgrade_service_tenure(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMonthly_payment_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.monthly_payment_type])) { _oMobileRetentionPreviousOrder.SetMonthly_payment_type((string)_oDATA[MobileRetentionPreviousOrder.Para.monthly_payment_type]); } else { _oMobileRetentionPreviousOrder.SetMonthly_payment_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bContact_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.contact_no])) { _oMobileRetentionPreviousOrder.SetContact_no((string)_oDATA[MobileRetentionPreviousOrder.Para.contact_no]); } else { _oMobileRetentionPreviousOrder.SetContact_no(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOrg_mrt))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.org_mrt])) { _oMobileRetentionPreviousOrder.SetOrg_mrt((global::System.Nullable<int>)_oDATA[MobileRetentionPreviousOrder.Para.org_mrt]); } else { _oMobileRetentionPreviousOrder.SetOrg_mrt(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSim_item_name))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.sim_item_name])) { _oMobileRetentionPreviousOrder.SetSim_item_name((string)_oDATA[MobileRetentionPreviousOrder.Para.sim_item_name]); } else { _oMobileRetentionPreviousOrder.SetSim_item_name(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPay_method))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.pay_method])) { _oMobileRetentionPreviousOrder.SetPay_method((string)_oDATA[MobileRetentionPreviousOrder.Para.pay_method]); } else { _oMobileRetentionPreviousOrder.SetPay_method(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bHs_model))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.hs_model])) { _oMobileRetentionPreviousOrder.SetHs_model((string)_oDATA[MobileRetentionPreviousOrder.Para.hs_model]); } else { _oMobileRetentionPreviousOrder.SetHs_model(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bGift_code))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.gift_code])) { _oMobileRetentionPreviousOrder.SetGift_code((string)_oDATA[MobileRetentionPreviousOrder.Para.gift_code]); } else { _oMobileRetentionPreviousOrder.SetGift_code(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMonthly_bank_account_hkid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.monthly_bank_account_hkid])) { _oMobileRetentionPreviousOrder.SetMonthly_bank_account_hkid((string)_oDATA[MobileRetentionPreviousOrder.Para.monthly_bank_account_hkid]); } else { _oMobileRetentionPreviousOrder.SetMonthly_bank_account_hkid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bExtra_offer))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.extra_offer])) { _oMobileRetentionPreviousOrder.SetExtra_offer((string)_oDATA[MobileRetentionPreviousOrder.Para.extra_offer]); } else { _oMobileRetentionPreviousOrder.SetExtra_offer(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMonthly_bank_account_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.monthly_bank_account_no])) { _oMobileRetentionPreviousOrder.SetMonthly_bank_account_no((string)_oDATA[MobileRetentionPreviousOrder.Para.monthly_bank_account_no]); } else { _oMobileRetentionPreviousOrder.SetMonthly_bank_account_no(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFirst_month_license_fee))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.first_month_license_fee])) { _oMobileRetentionPreviousOrder.SetFirst_month_license_fee((string)_oDATA[MobileRetentionPreviousOrder.Para.first_month_license_fee]); } else { _oMobileRetentionPreviousOrder.SetFirst_month_license_fee(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRetrieve_cnt))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.retrieve_cnt])) { _oMobileRetentionPreviousOrder.SetRetrieve_cnt((global::System.Nullable<int>)_oDATA[MobileRetentionPreviousOrder.Para.retrieve_cnt]); } else { _oMobileRetentionPreviousOrder.SetRetrieve_cnt(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.ddate])) { _oMobileRetentionPreviousOrder.SetDdate((global::System.Nullable<DateTime>)_oDATA[MobileRetentionPreviousOrder.Para.ddate]); } else { _oMobileRetentionPreviousOrder.SetDdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bS_premium2))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.s_premium2])) { _oMobileRetentionPreviousOrder.SetS_premium2((string)_oDATA[MobileRetentionPreviousOrder.Para.s_premium2]); } else { _oMobileRetentionPreviousOrder.SetS_premium2(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMonthly_bank_account_id_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.monthly_bank_account_id_type])) { _oMobileRetentionPreviousOrder.SetMonthly_bank_account_id_type((string)_oDATA[MobileRetentionPreviousOrder.Para.monthly_bank_account_id_type]); } else { _oMobileRetentionPreviousOrder.SetMonthly_bank_account_id_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCard_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.card_type])) { _oMobileRetentionPreviousOrder.SetCard_type((string)_oDATA[MobileRetentionPreviousOrder.Para.card_type]); } else { _oMobileRetentionPreviousOrder.SetCard_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bNext_bill))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.next_bill])) { _oMobileRetentionPreviousOrder.SetNext_bill((global::System.Nullable<bool>)_oDATA[MobileRetentionPreviousOrder.Para.next_bill]); } else { _oMobileRetentionPreviousOrder.SetNext_bill(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPcd_paid_go_wireless))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.pcd_paid_go_wireless])) { _oMobileRetentionPreviousOrder.SetPcd_paid_go_wireless((global::System.Nullable<bool>)_oDATA[MobileRetentionPreviousOrder.Para.pcd_paid_go_wireless]); } else { _oMobileRetentionPreviousOrder.SetPcd_paid_go_wireless(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bUpgrade_rebate_calculation))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.upgrade_rebate_calculation])) { _oMobileRetentionPreviousOrder.SetUpgrade_rebate_calculation((string)_oDATA[MobileRetentionPreviousOrder.Para.upgrade_rebate_calculation]); } else { _oMobileRetentionPreviousOrder.SetUpgrade_rebate_calculation(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bExt_place_tel))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.ext_place_tel])) { _oMobileRetentionPreviousOrder.SetExt_place_tel((string)_oDATA[MobileRetentionPreviousOrder.Para.ext_place_tel]); } else { _oMobileRetentionPreviousOrder.SetExt_place_tel(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bM_3rd_hkid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.m_3rd_hkid])) { _oMobileRetentionPreviousOrder.SetM_3rd_hkid((string)_oDATA[MobileRetentionPreviousOrder.Para.m_3rd_hkid]); } else { _oMobileRetentionPreviousOrder.SetM_3rd_hkid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRetention_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.retention_type])) { _oMobileRetentionPreviousOrder.SetRetention_type((string)_oDATA[MobileRetentionPreviousOrder.Para.retention_type]); } else { _oMobileRetentionPreviousOrder.SetRetention_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bBill_address_his_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.bill_address_his_id])) { _oMobileRetentionPreviousOrder.SetBill_address_his_id((global::System.Nullable<long>)_oDATA[MobileRetentionPreviousOrder.Para.bill_address_his_id]); } else { _oMobileRetentionPreviousOrder.SetBill_address_his_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bAig_gift))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.aig_gift])) { _oMobileRetentionPreviousOrder.SetAig_gift((string)_oDATA[MobileRetentionPreviousOrder.Para.aig_gift]); } else { _oMobileRetentionPreviousOrder.SetAig_gift(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCust_staff_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.cust_staff_no])) { _oMobileRetentionPreviousOrder.SetCust_staff_no((string)_oDATA[MobileRetentionPreviousOrder.Para.cust_staff_no]); } else { _oMobileRetentionPreviousOrder.SetCust_staff_no(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOrder_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.order_id])) { _oMobileRetentionPreviousOrder.SetOrder_id((global::System.Nullable<int>)_oDATA[MobileRetentionPreviousOrder.Para.order_id]); } else { _oMobileRetentionPreviousOrder.SetOrder_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFamily_name))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.family_name])) { _oMobileRetentionPreviousOrder.SetFamily_name((string)_oDATA[MobileRetentionPreviousOrder.Para.family_name]); } else { _oMobileRetentionPreviousOrder.SetFamily_name(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.cdate])) { _oMobileRetentionPreviousOrder.SetCdate((global::System.Nullable<DateTime>)_oDATA[MobileRetentionPreviousOrder.Para.cdate]); } else { _oMobileRetentionPreviousOrder.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bStatus_by_cs_admin))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.status_by_cs_admin])) { _oMobileRetentionPreviousOrder.SetStatus_by_cs_admin((string)_oDATA[MobileRetentionPreviousOrder.Para.status_by_cs_admin]); } else { _oMobileRetentionPreviousOrder.SetStatus_by_cs_admin(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSim_item_number))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.sim_item_number])) { _oMobileRetentionPreviousOrder.SetSim_item_number((string)_oDATA[MobileRetentionPreviousOrder.Para.sim_item_number]); } else { _oMobileRetentionPreviousOrder.SetSim_item_number(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bVip_case))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.vip_case])) { _oMobileRetentionPreviousOrder.SetVip_case((string)_oDATA[MobileRetentionPreviousOrder.Para.vip_case]); } else { _oMobileRetentionPreviousOrder.SetVip_case(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bGiven_name))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.given_name])) { _oMobileRetentionPreviousOrder.SetGiven_name((string)_oDATA[MobileRetentionPreviousOrder.Para.given_name]); } else { _oMobileRetentionPreviousOrder.SetGiven_name(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bLog_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.log_date])) { _oMobileRetentionPreviousOrder.SetLog_date((global::System.Nullable<DateTime>)_oDATA[MobileRetentionPreviousOrder.Para.log_date]); } else { _oMobileRetentionPreviousOrder.SetLog_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bExtn))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.extn])) { _oMobileRetentionPreviousOrder.SetExtn((string)_oDATA[MobileRetentionPreviousOrder.Para.extn]); } else { _oMobileRetentionPreviousOrder.SetExtn(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bD_time))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.d_time])) { _oMobileRetentionPreviousOrder.SetD_time((string)_oDATA[MobileRetentionPreviousOrder.Para.d_time]); } else { _oMobileRetentionPreviousOrder.SetD_time(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bBank_name))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.bank_name])) { _oMobileRetentionPreviousOrder.SetBank_name((string)_oDATA[MobileRetentionPreviousOrder.Para.bank_name]); } else { _oMobileRetentionPreviousOrder.SetBank_name(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDelivery_exchange_option))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.delivery_exchange_option])) { _oMobileRetentionPreviousOrder.SetDelivery_exchange_option((string)_oDATA[MobileRetentionPreviousOrder.Para.delivery_exchange_option]); } else { _oMobileRetentionPreviousOrder.SetDelivery_exchange_option(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bUpgrade_service_account_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.upgrade_service_account_no])) { _oMobileRetentionPreviousOrder.SetUpgrade_service_account_no((string)_oDATA[MobileRetentionPreviousOrder.Para.upgrade_service_account_no]); } else { _oMobileRetentionPreviousOrder.SetUpgrade_service_account_no(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bAction_of_rate_plan_effective))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.action_of_rate_plan_effective])) { _oMobileRetentionPreviousOrder.SetAction_of_rate_plan_effective((string)_oDATA[MobileRetentionPreviousOrder.Para.action_of_rate_plan_effective]); } else { _oMobileRetentionPreviousOrder.SetAction_of_rate_plan_effective(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bM_card_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.m_card_no])) { _oMobileRetentionPreviousOrder.SetM_card_no((string)_oDATA[MobileRetentionPreviousOrder.Para.m_card_no]); } else { _oMobileRetentionPreviousOrder.SetM_card_no(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bExisting_contract_end_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.existing_contract_end_date])) { _oMobileRetentionPreviousOrder.SetExisting_contract_end_date((string)_oDATA[MobileRetentionPreviousOrder.Para.existing_contract_end_date]); } else { _oMobileRetentionPreviousOrder.SetExisting_contract_end_date(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCon_eff_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.con_eff_date])) { _oMobileRetentionPreviousOrder.SetCon_eff_date((global::System.Nullable<DateTime>)_oDATA[MobileRetentionPreviousOrder.Para.con_eff_date]); } else { _oMobileRetentionPreviousOrder.SetCon_eff_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bM_3rd_hkid2))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.m_3rd_hkid2])) { _oMobileRetentionPreviousOrder.SetM_3rd_hkid2((string)_oDATA[MobileRetentionPreviousOrder.Para.m_3rd_hkid2]); } else { _oMobileRetentionPreviousOrder.SetM_3rd_hkid2(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bAmount))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.amount])) { _oMobileRetentionPreviousOrder.SetAmount((string)_oDATA[MobileRetentionPreviousOrder.Para.amount]); } else { _oMobileRetentionPreviousOrder.SetAmount(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bId_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.id_type])) { _oMobileRetentionPreviousOrder.SetId_type((string)_oDATA[MobileRetentionPreviousOrder.Para.id_type]); } else { _oMobileRetentionPreviousOrder.SetId_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRate_plan))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.rate_plan])) { _oMobileRetentionPreviousOrder.SetRate_plan((string)_oDATA[MobileRetentionPreviousOrder.Para.rate_plan]); } else { _oMobileRetentionPreviousOrder.SetRate_plan(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bChannel))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.channel])) { _oMobileRetentionPreviousOrder.SetChannel((string)_oDATA[MobileRetentionPreviousOrder.Para.channel]); } else { _oMobileRetentionPreviousOrder.SetChannel(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bAction_eff_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.action_eff_date])) { _oMobileRetentionPreviousOrder.SetAction_eff_date((global::System.Nullable<DateTime>)_oDATA[MobileRetentionPreviousOrder.Para.action_eff_date]); } else { _oMobileRetentionPreviousOrder.SetAction_eff_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bIssue_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.issue_type])) { _oMobileRetentionPreviousOrder.SetIssue_type((string)_oDATA[MobileRetentionPreviousOrder.Para.issue_type]); } else { _oMobileRetentionPreviousOrder.SetIssue_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFree_mon))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.free_mon])) { _oMobileRetentionPreviousOrder.SetFree_mon((string)_oDATA[MobileRetentionPreviousOrder.Para.free_mon]); } else { _oMobileRetentionPreviousOrder.SetFree_mon(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPlan_eff_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.plan_eff_date])) { _oMobileRetentionPreviousOrder.SetPlan_eff_date((global::System.Nullable<DateTime>)_oDATA[MobileRetentionPreviousOrder.Para.plan_eff_date]); } else { _oMobileRetentionPreviousOrder.SetPlan_eff_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDel_remark))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.del_remark])) { _oMobileRetentionPreviousOrder.SetDel_remark((string)_oDATA[MobileRetentionPreviousOrder.Para.del_remark]); } else { _oMobileRetentionPreviousOrder.SetDel_remark(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bTeamcode))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.teamcode])) { _oMobileRetentionPreviousOrder.SetTeamcode((string)_oDATA[MobileRetentionPreviousOrder.Para.teamcode]); } else { _oMobileRetentionPreviousOrder.SetTeamcode(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bStaff_name))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.staff_name])) { _oMobileRetentionPreviousOrder.SetStaff_name((string)_oDATA[MobileRetentionPreviousOrder.Para.staff_name]); } else { _oMobileRetentionPreviousOrder.SetStaff_name(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEdf_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.edf_no])) { _oMobileRetentionPreviousOrder.SetEdf_no((string)_oDATA[MobileRetentionPreviousOrder.Para.edf_no]); } else { _oMobileRetentionPreviousOrder.SetEdf_no(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOrd_place_by))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.ord_place_by])) { _oMobileRetentionPreviousOrder.SetOrd_place_by((string)_oDATA[MobileRetentionPreviousOrder.Para.ord_place_by]); } else { _oMobileRetentionPreviousOrder.SetOrd_place_by(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCancel_renew))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.cancel_renew])) { _oMobileRetentionPreviousOrder.SetCancel_renew((string)_oDATA[MobileRetentionPreviousOrder.Para.cancel_renew]); } else { _oMobileRetentionPreviousOrder.SetCancel_renew(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPreferred_languages))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.preferred_languages])) { _oMobileRetentionPreviousOrder.SetPreferred_languages((string)_oDATA[MobileRetentionPreviousOrder.Para.preferred_languages]); } else { _oMobileRetentionPreviousOrder.SetPreferred_languages(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bHkid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.hkid])) { _oMobileRetentionPreviousOrder.SetHkid((string)_oDATA[MobileRetentionPreviousOrder.Para.hkid]); } else { _oMobileRetentionPreviousOrder.SetHkid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCard_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.card_no])) { _oMobileRetentionPreviousOrder.SetCard_no((string)_oDATA[MobileRetentionPreviousOrder.Para.card_no]); } else { _oMobileRetentionPreviousOrder.SetCard_no(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bAc_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.ac_no])) { _oMobileRetentionPreviousOrder.SetAc_no((string)_oDATA[MobileRetentionPreviousOrder.Para.ac_no]); } else { _oMobileRetentionPreviousOrder.SetAc_no(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bBill_cut_num))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.bill_cut_num])) { _oMobileRetentionPreviousOrder.SetBill_cut_num((global::System.Nullable<int>)_oDATA[MobileRetentionPreviousOrder.Para.bill_cut_num]); } else { _oMobileRetentionPreviousOrder.SetBill_cut_num(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPremium))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.premium])) { _oMobileRetentionPreviousOrder.SetPremium((string)_oDATA[MobileRetentionPreviousOrder.Para.premium]); } else { _oMobileRetentionPreviousOrder.SetPremium(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bM_3rd_id_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.m_3rd_id_type])) { _oMobileRetentionPreviousOrder.SetM_3rd_id_type((string)_oDATA[MobileRetentionPreviousOrder.Para.m_3rd_id_type]); } else { _oMobileRetentionPreviousOrder.SetM_3rd_id_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bGift_imei2))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.gift_imei2])) { _oMobileRetentionPreviousOrder.SetGift_imei2((string)_oDATA[MobileRetentionPreviousOrder.Para.gift_imei2]); } else { _oMobileRetentionPreviousOrder.SetGift_imei2(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bReasons))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.reasons])) { _oMobileRetentionPreviousOrder.SetReasons((string)_oDATA[MobileRetentionPreviousOrder.Para.reasons]); } else { _oMobileRetentionPreviousOrder.SetReasons(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bLanguage))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.language])) { _oMobileRetentionPreviousOrder.SetLanguage((string)_oDATA[MobileRetentionPreviousOrder.Para.language]); } else { _oMobileRetentionPreviousOrder.SetLanguage(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRebate_amount))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.rebate_amount])) { _oMobileRetentionPreviousOrder.SetRebate_amount((string)_oDATA[MobileRetentionPreviousOrder.Para.rebate_amount]); } else { _oMobileRetentionPreviousOrder.SetRebate_amount(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bLob))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.lob])) { _oMobileRetentionPreviousOrder.SetLob((string)_oDATA[MobileRetentionPreviousOrder.Para.lob]); } else { _oMobileRetentionPreviousOrder.SetLob(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bM_3rd_contact_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.m_3rd_contact_no])) { _oMobileRetentionPreviousOrder.SetM_3rd_contact_no((string)_oDATA[MobileRetentionPreviousOrder.Para.m_3rd_contact_no]); } else { _oMobileRetentionPreviousOrder.SetM_3rd_contact_no(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bStaff_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.staff_no])) { _oMobileRetentionPreviousOrder.SetStaff_no((string)_oDATA[MobileRetentionPreviousOrder.Para.staff_no]); } else { _oMobileRetentionPreviousOrder.SetStaff_no(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bS_premium3))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.s_premium3])) { _oMobileRetentionPreviousOrder.SetS_premium3((string)_oDATA[MobileRetentionPreviousOrder.Para.s_premium3]); } else { _oMobileRetentionPreviousOrder.SetS_premium3(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSp_d_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.sp_d_date])) { _oMobileRetentionPreviousOrder.SetSp_d_date((global::System.Nullable<DateTime>)_oDATA[MobileRetentionPreviousOrder.Para.sp_d_date]); } else { _oMobileRetentionPreviousOrder.SetSp_d_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bBundle_name))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.bundle_name])) { _oMobileRetentionPreviousOrder.SetBundle_name((string)_oDATA[MobileRetentionPreviousOrder.Para.bundle_name]); } else { _oMobileRetentionPreviousOrder.SetBundle_name(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bAccessory_waive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.accessory_waive])) { _oMobileRetentionPreviousOrder.SetAccessory_waive((global::System.Nullable<bool>)_oDATA[MobileRetentionPreviousOrder.Para.accessory_waive]); } else { _oMobileRetentionPreviousOrder.SetAccessory_waive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSim_item_code))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.sim_item_code])) { _oMobileRetentionPreviousOrder.SetSim_item_code((string)_oDATA[MobileRetentionPreviousOrder.Para.sim_item_code]); } else { _oMobileRetentionPreviousOrder.SetSim_item_code(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMonthly_bank_account_holder))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.monthly_bank_account_holder])) { _oMobileRetentionPreviousOrder.SetMonthly_bank_account_holder((string)_oDATA[MobileRetentionPreviousOrder.Para.monthly_bank_account_holder]); } else { _oMobileRetentionPreviousOrder.SetMonthly_bank_account_holder(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCard_holder))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionPreviousOrder.Para.card_holder])) { _oMobileRetentionPreviousOrder.SetCard_holder((string)_oDATA[MobileRetentionPreviousOrder.Para.card_holder]); } else { _oMobileRetentionPreviousOrder.SetCard_holder(global::System.String.Empty); }
                    }
                    _oMobileRetentionPreviousOrderList.Add(_oMobileRetentionPreviousOrder);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oMobileRetentionPreviousOrderList;
            }
            return new List<MobileRetentionPreviousOrderEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<MobileRetentionPreviousOrderEntity> OrderBy(string x_sSort, IQueryable<MobileRetentionPreviousOrderEntity> x_oMobileRetentionPreviousOrderBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case MobileRetentionPreviousOrder.Para.gift_imei:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.gift_imei).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.gift_imei).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.s_premium4:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.s_premium4).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.s_premium4).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.gift_desc4:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.gift_desc4).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.gift_desc4).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.accessory_desc:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.accessory_desc).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.accessory_desc).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.action_required:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.action_required).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.action_required).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.registered_address_his_id:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.registered_address_his_id).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.registered_address_his_id).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.vas_eff_date:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.vas_eff_date).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.vas_eff_date).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.monthly_bank_account_bank_code:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.monthly_bank_account_bank_code).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.monthly_bank_account_bank_code).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.special_handling_dummy_code:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.special_handling_dummy_code).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.special_handling_dummy_code).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.m_card_exp_year:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.m_card_exp_year).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.m_card_exp_year).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.remarks2PY:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.remarks2PY).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.remarks2PY).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.trade_field:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.trade_field).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.trade_field).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.ord_place_tel:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.ord_place_tel).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.ord_place_tel).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.ord_place_id_type:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.ord_place_id_type).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.ord_place_id_type).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.cooling_offer:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.cooling_offer).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.cooling_offer).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.rec_no:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.rec_no).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.rec_no).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.upgrade_handset_offer_rebate_schedule:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.upgrade_handset_offer_rebate_schedule).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.upgrade_handset_offer_rebate_schedule).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.change_payment_type:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.change_payment_type).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.change_payment_type).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.date_of_birth:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.date_of_birth).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.date_of_birth).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.contact_person:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.contact_person).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.contact_person).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.extra_d_charge:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.extra_d_charge).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.extra_d_charge).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.tl_name:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.tl_name).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.tl_name).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.fast_start:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.fast_start).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.fast_start).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.sp_ref_no:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.sp_ref_no).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.sp_ref_no).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.edate:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.edate).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.edate).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.exist_cust_plan:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.exist_cust_plan).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.exist_cust_plan).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.ord_place_rel:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.ord_place_rel).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.ord_place_rel).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.mrt_no:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.mrt_no).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.mrt_no).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.imei_no:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.imei_no).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.imei_no).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.existing_smart_phone_model:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.existing_smart_phone_model).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.existing_smart_phone_model).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.gift_code3:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.gift_code3).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.gift_code3).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.bank_code:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.bank_code).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.bank_code).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.pos_ref_no:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.pos_ref_no).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.pos_ref_no).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.bill_cut_date:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.bill_cut_date).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.bill_cut_date).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.gift_imei3:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.gift_imei3).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.gift_imei3).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.exist_plan:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.exist_plan).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.exist_plan).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.waive:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.waive).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.waive).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.program:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.program).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.program).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.first_month_fee:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.first_month_fee).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.first_month_fee).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.r_offer:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.r_offer).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.r_offer).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.cid:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.cid).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.cid).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.did:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.did).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.did).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.ftg_tenure:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.ftg_tenure).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.ftg_tenure).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.con_per:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.con_per).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.con_per).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.gift_code4:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.gift_code4).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.gift_code4).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.easywatch_type:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.easywatch_type).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.easywatch_type).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.sms_mrt:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.sms_mrt).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.sms_mrt).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.tpy_his_id:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.tpy_his_id).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.tpy_his_id).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.monthly_payment_method:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.monthly_payment_method).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.monthly_payment_method).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.remarks2EDF:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.remarks2EDF).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.remarks2EDF).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.gift_desc3:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.gift_desc3).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.gift_desc3).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.gift_imei4:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.gift_imei4).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.gift_imei4).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.old_ord_id:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.old_ord_id).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.old_ord_id).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.monthly_bank_account_hkid2:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.monthly_bank_account_hkid2).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.monthly_bank_account_hkid2).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.d_date:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.d_date).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.d_date).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.gift_desc:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.gift_desc).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.gift_desc).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.salesmancode:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.salesmancode).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.salesmancode).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.pool:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.pool).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.pool).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.cn_mrt_no:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.cn_mrt_no).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.cn_mrt_no).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.accessory_imei:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.accessory_imei).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.accessory_imei).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.third_party_credit_card:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.third_party_credit_card).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.third_party_credit_card).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.card_ref_no:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.card_ref_no).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.card_ref_no).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.cooling_date:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.cooling_date).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.cooling_date).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.special_approval:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.special_approval).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.special_approval).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.upgrade_existing_contract_edate:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.upgrade_existing_contract_edate).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.upgrade_existing_contract_edate).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.accessory_code:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.accessory_code).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.accessory_code).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.bill_medium:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.bill_medium).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.bill_medium).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.s_premium:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.s_premium).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.s_premium).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.ref_staff_no:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.ref_staff_no).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.ref_staff_no).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.accessory_price:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.accessory_price).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.accessory_price).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.m_card_exp_month:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.m_card_exp_month).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.m_card_exp_month).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.installment_period:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.installment_period).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.installment_period).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.m_card_type:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.m_card_type).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.m_card_type).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.easywatch_ord_id:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.easywatch_ord_id).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.easywatch_ord_id).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.normal_rebate:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.normal_rebate).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.normal_rebate).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.m_rebate_amount:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.m_rebate_amount).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.m_rebate_amount).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.m_card_holder2:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.m_card_holder2).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.m_card_holder2).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.bill_medium_email:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.bill_medium_email).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.bill_medium_email).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.active:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.s_premium1:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.s_premium1).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.s_premium1).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.card_exp_month:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.card_exp_month).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.card_exp_month).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.ob_program_id:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.ob_program_id).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.ob_program_id).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.sku:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.sku).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.sku).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.ref_salesmancode:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.ref_salesmancode).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.ref_salesmancode).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.go_wireless_package_code:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.go_wireless_package_code).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.go_wireless_package_code).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.third_party_hkid:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.third_party_hkid).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.third_party_hkid).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.upgrade_existing_pccw_customer:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.upgrade_existing_pccw_customer).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.upgrade_existing_pccw_customer).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.d_address:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.d_address).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.d_address).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.upgrade_registered_mobile_no:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.upgrade_registered_mobile_no).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.upgrade_registered_mobile_no).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.upgrade_existing_customer_type:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.upgrade_existing_customer_type).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.upgrade_existing_customer_type).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.normal_rebate_type:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.normal_rebate_type).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.normal_rebate_type).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.gift_desc2:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.gift_desc2).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.gift_desc2).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.monthly_bank_account_branch_code:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.monthly_bank_account_branch_code).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.monthly_bank_account_branch_code).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.remarks:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.remarks).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.remarks).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.accept:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.accept).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.accept).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.delivery_exchange:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.delivery_exchange).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.delivery_exchange).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.gift_code2:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.gift_code2).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.gift_code2).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.prepayment_waive:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.prepayment_waive).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.prepayment_waive).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.existing_smart_phone_imei:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.existing_smart_phone_imei).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.existing_smart_phone_imei).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.mnp_his_id:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.mnp_his_id).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.mnp_his_id).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.cust_name:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.cust_name).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.cust_name).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.cust_type:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.cust_type).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.cust_type).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.upgrade_sponsorships_amount:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.upgrade_sponsorships_amount).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.upgrade_sponsorships_amount).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.bill_medium_waive:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.bill_medium_waive).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.bill_medium_waive).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.delivery_exchange_location:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.delivery_exchange_location).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.delivery_exchange_location).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.hs_offer_type_id:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.hs_offer_type_id).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.hs_offer_type_id).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.org_fee:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.org_fee).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.org_fee).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.rebate:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.rebate).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.rebate).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.upgrade_type:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.upgrade_type).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.upgrade_type).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.go_wireless:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.go_wireless).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.go_wireless).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.extra_rebate:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.extra_rebate).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.extra_rebate).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.plan_eff:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.plan_eff).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.plan_eff).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.extra_rebate_amount:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.extra_rebate_amount).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.extra_rebate_amount).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.card_exp_year:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.card_exp_year).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.card_exp_year).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.upgrade_existing_contract_sdate:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.upgrade_existing_contract_sdate).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.upgrade_existing_contract_sdate).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.ord_place_hkid:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.ord_place_hkid).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.ord_place_hkid).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.register_address:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.register_address).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.register_address).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.gender:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.gender).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.gender).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.lob_ac:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.lob_ac).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.lob_ac).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.sim_mrt_no:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.sim_mrt_no).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.sim_mrt_no).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.redemption_notice_option:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.redemption_notice_option).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.redemption_notice_option).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.delivery_collection_type:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.delivery_collection_type).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.delivery_collection_type).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.action_date:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.action_date).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.action_date).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.third_party_id_type:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.third_party_id_type).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.third_party_id_type).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.org_ftg:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.org_ftg).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.org_ftg).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.upgrade_service_tenure:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.upgrade_service_tenure).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.upgrade_service_tenure).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.monthly_payment_type:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.monthly_payment_type).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.monthly_payment_type).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.contact_no:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.contact_no).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.contact_no).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.org_mrt:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.org_mrt).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.org_mrt).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.sim_item_name:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.sim_item_name).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.sim_item_name).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.pay_method:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.pay_method).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.pay_method).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.hs_model:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.hs_model).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.hs_model).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.gift_code:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.gift_code).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.gift_code).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.monthly_bank_account_hkid:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.monthly_bank_account_hkid).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.monthly_bank_account_hkid).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.extra_offer:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.extra_offer).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.extra_offer).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.monthly_bank_account_no:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.monthly_bank_account_no).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.monthly_bank_account_no).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.first_month_license_fee:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.first_month_license_fee).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.first_month_license_fee).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.retrieve_cnt:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.retrieve_cnt).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.retrieve_cnt).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.ddate:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.ddate).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.ddate).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.s_premium2:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.s_premium2).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.s_premium2).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.monthly_bank_account_id_type:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.monthly_bank_account_id_type).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.monthly_bank_account_id_type).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.card_type:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.card_type).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.card_type).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.next_bill:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.next_bill).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.next_bill).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.pcd_paid_go_wireless:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.pcd_paid_go_wireless).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.pcd_paid_go_wireless).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.upgrade_rebate_calculation:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.upgrade_rebate_calculation).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.upgrade_rebate_calculation).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.ext_place_tel:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.ext_place_tel).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.ext_place_tel).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.m_3rd_hkid:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.m_3rd_hkid).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.m_3rd_hkid).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.retention_type:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.retention_type).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.retention_type).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.bill_address_his_id:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.bill_address_his_id).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.bill_address_his_id).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.aig_gift:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.aig_gift).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.aig_gift).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.cust_staff_no:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.cust_staff_no).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.cust_staff_no).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.order_id:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.order_id).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.order_id).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.family_name:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.family_name).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.family_name).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.cdate:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.status_by_cs_admin:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.status_by_cs_admin).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.status_by_cs_admin).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.sim_item_number:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.sim_item_number).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.sim_item_number).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.vip_case:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.vip_case).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.vip_case).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.given_name:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.given_name).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.given_name).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.log_date:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.log_date).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.log_date).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.extn:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.extn).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.extn).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.d_time:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.d_time).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.d_time).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.bank_name:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.bank_name).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.bank_name).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.delivery_exchange_option:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.delivery_exchange_option).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.delivery_exchange_option).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.upgrade_service_account_no:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.upgrade_service_account_no).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.upgrade_service_account_no).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.action_of_rate_plan_effective:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.action_of_rate_plan_effective).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.action_of_rate_plan_effective).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.m_card_no:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.m_card_no).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.m_card_no).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.existing_contract_end_date:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.existing_contract_end_date).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.existing_contract_end_date).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.con_eff_date:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.con_eff_date).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.con_eff_date).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.m_3rd_hkid2:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.m_3rd_hkid2).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.m_3rd_hkid2).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.amount:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.amount).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.amount).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.id_type:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.id_type).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.id_type).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.rate_plan:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.rate_plan).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.rate_plan).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.channel:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.channel).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.channel).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.action_eff_date:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.action_eff_date).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.action_eff_date).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.issue_type:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.issue_type).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.issue_type).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.free_mon:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.free_mon).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.free_mon).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.plan_eff_date:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.plan_eff_date).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.plan_eff_date).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.del_remark:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.del_remark).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.del_remark).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.teamcode:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.teamcode).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.teamcode).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.staff_name:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.staff_name).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.staff_name).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.edf_no:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.edf_no).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.edf_no).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.ord_place_by:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.ord_place_by).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.ord_place_by).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.cancel_renew:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.cancel_renew).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.cancel_renew).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.preferred_languages:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.preferred_languages).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.preferred_languages).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.hkid:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.hkid).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.hkid).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.card_no:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.card_no).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.card_no).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.ac_no:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.ac_no).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.ac_no).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.bill_cut_num:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.bill_cut_num).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.bill_cut_num).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.premium:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.premium).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.premium).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.m_3rd_id_type:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.m_3rd_id_type).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.m_3rd_id_type).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.gift_imei2:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.gift_imei2).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.gift_imei2).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.reasons:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.reasons).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.reasons).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.language:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.language).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.language).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.rebate_amount:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.rebate_amount).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.rebate_amount).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.lob:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.lob).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.lob).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.m_3rd_contact_no:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.m_3rd_contact_no).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.m_3rd_contact_no).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.staff_no:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.staff_no).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.staff_no).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.s_premium3:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.s_premium3).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.s_premium3).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.sp_d_date:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.sp_d_date).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.sp_d_date).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.bundle_name:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.bundle_name).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.bundle_name).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.accessory_waive:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.accessory_waive).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.accessory_waive).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.sim_item_code:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.sim_item_code).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.sim_item_code).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.monthly_bank_account_holder:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.monthly_bank_account_holder).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.monthly_bank_account_holder).Select(c => c);
                break;
                case MobileRetentionPreviousOrder.Para.card_holder:
                if(x_bAsc)
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderBy(c => c.card_holder).Select(c => c);
                else
                    x_oMobileRetentionPreviousOrderBaseList = x_oMobileRetentionPreviousOrderBaseList.OrderByDescending(c => c.card_holder).Select(c => c);
                break;
            }
            return x_oMobileRetentionPreviousOrderBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<MobileRetentionPreviousOrderEntity> FindAll()
        {
            MobileRetentionPreviousOrderEntity[] _oMobileRetentionPreviousOrdersArr=  MobileRetentionPreviousOrderRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oMobileRetentionPreviousOrdersArr != null)
            {
                IList<MobileRetentionPreviousOrderEntity> _oMobileRetentionPreviousOrdersList = (IList<MobileRetentionPreviousOrderEntity>)_oMobileRetentionPreviousOrdersArr;
                return _oMobileRetentionPreviousOrdersList;
            }
            return new List<MobileRetentionPreviousOrderEntity>();
        }
        
        public static IList<MobileRetentionPreviousOrderEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<MobileRetentionPreviousOrderEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<MobileRetentionPreviousOrderEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<MobileRetentionPreviousOrderEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            MobileRetentionPreviousOrderRS x_oShowField = new MobileRetentionPreviousOrderRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            MobileRetentionPreviousOrderRS x_oSortField=new MobileRetentionPreviousOrderRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(MobileRetentionPreviousOrder.Para.order_id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(MobileRetentionPreviousOrder.Para.order_id, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            MobileRetentionPreviousOrderRepositoryBase _oMobileRetentionPreviousOrderRepositoryBase = new MobileRetentionPreviousOrderRepositoryBase(GetDB());
            return _oMobileRetentionPreviousOrderRepositoryBase.GetCount();
        }
        #endregion
        
        #region GetDB
        public static MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return _oDB;
        }
        #endregion
        #region
        public void Release(){}
        #endregion
    }
}


