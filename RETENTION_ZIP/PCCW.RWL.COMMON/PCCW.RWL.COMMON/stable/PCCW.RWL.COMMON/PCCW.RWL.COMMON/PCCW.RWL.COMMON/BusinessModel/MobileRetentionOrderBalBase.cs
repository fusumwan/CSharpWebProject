using System;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2012-01-12>
///-- Description:	<Description,Table :[MobileRetentionOrder],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileRetentionOrder] Business layer
    /// </summary>
    
    public abstract class MobileRetentionOrderBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public MobileRetentionOrderBalBase(){
        }
        ~MobileRetentionOrderBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(MobileRetentionOrder x_oMobileRetentionOrder)
        {
            return GetDataSet(x_oMobileRetentionOrder,null,MobileRetentionOrderInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileRetentionOrder x_oMobileRetentionOrder,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oMobileRetentionOrder,x_oMergeDSet,MobileRetentionOrderInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileRetentionOrder x_oMobileRetentionOrder,MobileRetentionOrderInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileRetentionOrder,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileRetentionOrder x_oMobileRetentionOrder,global::System.Data.DataSet x_oMergeDSet,MobileRetentionOrderInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileRetentionOrder,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(MobileRetentionOrder x_oMobileRetentionOrder,global::System.Data.DataSet x_oMergeDSet,MobileRetentionOrderInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileRetentionOrderInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(MobileRetentionOrder.Para.TableName());
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_imei).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.gift_imei); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.s_premium4).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.s_premium4); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_desc4).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.gift_desc4); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.accessory_desc).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.accessory_desc); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.action_required).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.action_required); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.vas_eff_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.vas_eff_date); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_bank_code).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.monthly_bank_account_bank_code); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.special_handling_dummy_code).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.special_handling_dummy_code); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.m_card_exp_year).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.m_card_exp_year); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.remarks2PY).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.remarks2PY); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.trade_field).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.trade_field); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_tel).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.ord_place_tel); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_id_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.ord_place_id_type); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.cooling_offer).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.cooling_offer); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_handset_offer_rebate_schedule).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.upgrade_handset_offer_rebate_schedule); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.change_payment_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.change_payment_type); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.date_of_birth).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.date_of_birth); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.contact_person).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.contact_person); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.extra_d_charge).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.extra_d_charge); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.tl_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.tl_name); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.fast_start).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.fast_start); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.sp_ref_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.sp_ref_no); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.edate); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.exist_cust_plan).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.exist_cust_plan); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_rel).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.ord_place_rel); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.mrt_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.mrt_no); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.imei_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.imei_no); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.existing_smart_phone_model).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.existing_smart_phone_model); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_code3).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.gift_code3); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.bank_code).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.bank_code); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.pos_ref_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.pos_ref_no); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.bill_cut_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.bill_cut_date); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_imei3).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.gift_imei3); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.exist_plan).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.exist_plan); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.waive).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.waive); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.program).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.program); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.first_month_fee).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.first_month_fee); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.r_offer).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.r_offer); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.cid); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.did); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.ftg_tenure).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.ftg_tenure); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.con_per).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.con_per); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_code4).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.gift_code4); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.easywatch_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.easywatch_type); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.sms_mrt).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.sms_mrt); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_payment_method).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.monthly_payment_method); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.remarks2EDF).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.remarks2EDF); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_desc3).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.gift_desc3); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_imei4).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.gift_imei4); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.old_ord_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.old_ord_id); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_hkid2).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.monthly_bank_account_hkid2); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.d_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.d_date); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_desc).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.gift_desc); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.salesmancode).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.salesmancode); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.pool).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.pool); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.cn_mrt_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.cn_mrt_no); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.accessory_imei).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.accessory_imei); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.third_party_credit_card).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.third_party_credit_card); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.card_ref_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.card_ref_no); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.special_approval).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.special_approval); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_existing_contract_edate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.upgrade_existing_contract_edate); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.accessory_code).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.accessory_code); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.bill_medium).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.bill_medium); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.s_premium).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.s_premium); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.ref_staff_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.ref_staff_no); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.accessory_price).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.accessory_price); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.m_card_exp_month).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.m_card_exp_month); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.installment_period).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.installment_period); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.m_card_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.m_card_type); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.easywatch_ord_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.easywatch_ord_id); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.normal_rebate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.normal_rebate); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.m_rebate_amount).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.m_rebate_amount); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.m_card_holder2).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.m_card_holder2); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.bill_medium_email).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.bill_medium_email); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.active); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.s_premium1).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.s_premium1); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.card_exp_month).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.card_exp_month); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.ob_program_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.ob_program_id); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.sku).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.sku); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.ref_salesmancode).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.ref_salesmancode); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.go_wireless_package_code).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.go_wireless_package_code); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.third_party_hkid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.third_party_hkid); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_existing_pccw_customer).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.upgrade_existing_pccw_customer); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.d_address).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.d_address); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_registered_mobile_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.upgrade_registered_mobile_no); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_existing_customer_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.upgrade_existing_customer_type); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.normal_rebate_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.normal_rebate_type); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_desc2).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.gift_desc2); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_branch_code).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.monthly_bank_account_branch_code); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.remarks).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.remarks); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.accept).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.accept); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.delivery_exchange).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.delivery_exchange); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_code2).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.gift_code2); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.prepayment_waive).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.prepayment_waive); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.existing_smart_phone_imei).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.existing_smart_phone_imei); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.cust_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.cust_name); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.cust_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.cust_type); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_sponsorships_amount).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.upgrade_sponsorships_amount); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.bill_medium_waive).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.bill_medium_waive); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.delivery_exchange_location).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.delivery_exchange_location); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.hs_offer_type_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.hs_offer_type_id); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.org_fee).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.org_fee); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.rebate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.rebate); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.upgrade_type); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.go_wireless).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.go_wireless); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.extra_rebate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.extra_rebate); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.plan_eff).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.plan_eff); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.extra_rebate_amount).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.extra_rebate_amount); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.card_exp_year).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.card_exp_year); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_existing_contract_sdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.upgrade_existing_contract_sdate); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_hkid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.ord_place_hkid); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.register_address).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.register_address); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.gender).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.gender); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.lob_ac).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.lob_ac); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.sim_mrt_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.sim_mrt_no); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.redemption_notice_option).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.redemption_notice_option); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.delivery_collection_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.delivery_collection_type); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.action_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.action_date); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.third_party_id_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.third_party_id_type); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.org_ftg).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.org_ftg); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_service_tenure).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.upgrade_service_tenure); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_payment_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.monthly_payment_type); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.contact_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.contact_no); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.org_mrt).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.org_mrt); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.sim_item_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.sim_item_name); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.pay_method).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.pay_method); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.hs_model).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.hs_model); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_code).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.gift_code); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_hkid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.monthly_bank_account_hkid); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.extra_offer).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.extra_offer); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.monthly_bank_account_no); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.first_month_license_fee).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.first_month_license_fee); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.retrieve_cnt).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.retrieve_cnt); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.ddate); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.s_premium2).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.s_premium2); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_id_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.monthly_bank_account_id_type); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.card_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.card_type); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.next_bill).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.next_bill); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.pcd_paid_go_wireless).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.pcd_paid_go_wireless); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_rebate_calculation).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.upgrade_rebate_calculation); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.ext_place_tel).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.ext_place_tel); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.m_3rd_hkid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.m_3rd_hkid); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.retention_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.retention_type); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.cooling_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.cooling_date); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.aig_gift).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.aig_gift); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.cust_staff_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.cust_staff_no); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.order_id); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.family_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.family_name); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.cdate); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.status_by_cs_admin).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.status_by_cs_admin); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.sim_item_number).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.sim_item_number); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.vip_case).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.vip_case); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.given_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.given_name); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.log_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.log_date); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.extn).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.extn); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.d_time).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.d_time); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.bank_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.bank_name); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.delivery_exchange_option).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.delivery_exchange_option); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_service_account_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.upgrade_service_account_no); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.action_of_rate_plan_effective).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.action_of_rate_plan_effective); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.m_card_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.m_card_no); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.existing_contract_end_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.existing_contract_end_date); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.con_eff_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.con_eff_date); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.m_3rd_hkid2).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.m_3rd_hkid2); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.amount).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.amount); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.id_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.id_type); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.rate_plan).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.rate_plan); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.channel).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.channel); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.action_eff_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.action_eff_date); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.issue_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.issue_type); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.free_mon).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.free_mon); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.plan_eff_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.plan_eff_date); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.del_remark).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.del_remark); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.teamcode).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.teamcode); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.staff_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.staff_name); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.edf_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.edf_no); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_by).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.ord_place_by); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.cancel_renew).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.cancel_renew); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.preferred_languages).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.preferred_languages); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.hkid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.hkid); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.card_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.card_no); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.ac_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.ac_no); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.bill_cut_num).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.bill_cut_num); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.premium).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.premium); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.m_3rd_id_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.m_3rd_id_type); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_imei2).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.gift_imei2); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.reasons).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.reasons); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.language).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.language); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.rebate_amount).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.rebate_amount); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.lob).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.lob); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.m_3rd_contact_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.m_3rd_contact_no); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.staff_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.staff_no); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.s_premium3).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.s_premium3); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.sp_d_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.sp_d_date); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.bundle_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.bundle_name); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.accessory_waive).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.accessory_waive); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.sim_item_code).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.sim_item_code); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_holder).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.monthly_bank_account_holder); }
            if (x_oTableSet.Fields(MobileRetentionOrder.Para.card_holder).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Columns.Add(MobileRetentionOrder.Para.card_holder); }
            if (x_oMobileRetentionOrder != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[MobileRetentionOrder.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_imei).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.gift_imei] = x_oMobileRetentionOrder.GetGift_imei(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.s_premium4).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.s_premium4] = x_oMobileRetentionOrder.GetS_premium4(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_desc4).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.gift_desc4] = x_oMobileRetentionOrder.GetGift_desc4(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.accessory_desc).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.accessory_desc] = x_oMobileRetentionOrder.GetAccessory_desc(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.action_required).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.action_required] = x_oMobileRetentionOrder.GetAction_required(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.vas_eff_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.vas_eff_date] = x_oMobileRetentionOrder.GetVas_eff_date(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_bank_code).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.monthly_bank_account_bank_code] = x_oMobileRetentionOrder.GetMonthly_bank_account_bank_code(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.special_handling_dummy_code).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.special_handling_dummy_code] = x_oMobileRetentionOrder.GetSpecial_handling_dummy_code(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.m_card_exp_year).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.m_card_exp_year] = x_oMobileRetentionOrder.GetM_card_exp_year(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.remarks2PY).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.remarks2PY] = x_oMobileRetentionOrder.GetRemarks2PY(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.trade_field).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.trade_field] = x_oMobileRetentionOrder.GetTrade_field(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_tel).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.ord_place_tel] = x_oMobileRetentionOrder.GetOrd_place_tel(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_id_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.ord_place_id_type] = x_oMobileRetentionOrder.GetOrd_place_id_type(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.cooling_offer).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.cooling_offer] = x_oMobileRetentionOrder.GetCooling_offer(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_handset_offer_rebate_schedule).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.upgrade_handset_offer_rebate_schedule] = x_oMobileRetentionOrder.GetUpgrade_handset_offer_rebate_schedule(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.change_payment_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.change_payment_type] = x_oMobileRetentionOrder.GetChange_payment_type(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.date_of_birth).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.date_of_birth] = x_oMobileRetentionOrder.GetDate_of_birth(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.contact_person).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.contact_person] = x_oMobileRetentionOrder.GetContact_person(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.extra_d_charge).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.extra_d_charge] = x_oMobileRetentionOrder.GetExtra_d_charge(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.tl_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.tl_name] = x_oMobileRetentionOrder.GetTl_name(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.fast_start).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.fast_start] = x_oMobileRetentionOrder.GetFast_start(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.sp_ref_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.sp_ref_no] = x_oMobileRetentionOrder.GetSp_ref_no(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.edate] = x_oMobileRetentionOrder.GetEdate(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.exist_cust_plan).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.exist_cust_plan] = x_oMobileRetentionOrder.GetExist_cust_plan(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_rel).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.ord_place_rel] = x_oMobileRetentionOrder.GetOrd_place_rel(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.mrt_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.mrt_no] = x_oMobileRetentionOrder.GetMrt_no(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.imei_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.imei_no] = x_oMobileRetentionOrder.GetImei_no(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.existing_smart_phone_model).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.existing_smart_phone_model] = x_oMobileRetentionOrder.GetExisting_smart_phone_model(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_code3).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.gift_code3] = x_oMobileRetentionOrder.GetGift_code3(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.bank_code).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.bank_code] = x_oMobileRetentionOrder.GetBank_code(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.pos_ref_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.pos_ref_no] = x_oMobileRetentionOrder.GetPos_ref_no(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.bill_cut_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.bill_cut_date] = x_oMobileRetentionOrder.GetBill_cut_date(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_imei3).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.gift_imei3] = x_oMobileRetentionOrder.GetGift_imei3(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.exist_plan).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.exist_plan] = x_oMobileRetentionOrder.GetExist_plan(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.waive).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.waive] = x_oMobileRetentionOrder.GetWaive(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.program).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.program] = x_oMobileRetentionOrder.GetProgram(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.first_month_fee).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.first_month_fee] = x_oMobileRetentionOrder.GetFirst_month_fee(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.r_offer).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.r_offer] = x_oMobileRetentionOrder.GetR_offer(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.cid] = x_oMobileRetentionOrder.GetCid(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.did] = x_oMobileRetentionOrder.GetDid(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.ftg_tenure).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.ftg_tenure] = x_oMobileRetentionOrder.GetFtg_tenure(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.con_per).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.con_per] = x_oMobileRetentionOrder.GetCon_per(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_code4).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.gift_code4] = x_oMobileRetentionOrder.GetGift_code4(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.easywatch_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.easywatch_type] = x_oMobileRetentionOrder.GetEasywatch_type(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.sms_mrt).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.sms_mrt] = x_oMobileRetentionOrder.GetSms_mrt(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_payment_method).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.monthly_payment_method] = x_oMobileRetentionOrder.GetMonthly_payment_method(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.remarks2EDF).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.remarks2EDF] = x_oMobileRetentionOrder.GetRemarks2EDF(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_desc3).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.gift_desc3] = x_oMobileRetentionOrder.GetGift_desc3(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_imei4).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.gift_imei4] = x_oMobileRetentionOrder.GetGift_imei4(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.old_ord_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.old_ord_id] = x_oMobileRetentionOrder.GetOld_ord_id(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_hkid2).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.monthly_bank_account_hkid2] = x_oMobileRetentionOrder.GetMonthly_bank_account_hkid2(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.d_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.d_date] = x_oMobileRetentionOrder.GetD_date(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_desc).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.gift_desc] = x_oMobileRetentionOrder.GetGift_desc(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.salesmancode).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.salesmancode] = x_oMobileRetentionOrder.GetSalesmancode(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.pool).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.pool] = x_oMobileRetentionOrder.GetPool(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.cn_mrt_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.cn_mrt_no] = x_oMobileRetentionOrder.GetCn_mrt_no(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.accessory_imei).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.accessory_imei] = x_oMobileRetentionOrder.GetAccessory_imei(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.third_party_credit_card).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.third_party_credit_card] = x_oMobileRetentionOrder.GetThird_party_credit_card(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.card_ref_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.card_ref_no] = x_oMobileRetentionOrder.GetCard_ref_no(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.special_approval).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.special_approval] = x_oMobileRetentionOrder.GetSpecial_approval(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_existing_contract_edate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.upgrade_existing_contract_edate] = x_oMobileRetentionOrder.GetUpgrade_existing_contract_edate(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.accessory_code).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.accessory_code] = x_oMobileRetentionOrder.GetAccessory_code(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.bill_medium).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.bill_medium] = x_oMobileRetentionOrder.GetBill_medium(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.s_premium).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.s_premium] = x_oMobileRetentionOrder.GetS_premium(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.ref_staff_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.ref_staff_no] = x_oMobileRetentionOrder.GetRef_staff_no(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.accessory_price).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.accessory_price] = x_oMobileRetentionOrder.GetAccessory_price(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.m_card_exp_month).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.m_card_exp_month] = x_oMobileRetentionOrder.GetM_card_exp_month(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.installment_period).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.installment_period] = x_oMobileRetentionOrder.GetInstallment_period(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.m_card_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.m_card_type] = x_oMobileRetentionOrder.GetM_card_type(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.easywatch_ord_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.easywatch_ord_id] = x_oMobileRetentionOrder.GetEasywatch_ord_id(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.normal_rebate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.normal_rebate] = x_oMobileRetentionOrder.GetNormal_rebate(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.m_rebate_amount).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.m_rebate_amount] = x_oMobileRetentionOrder.GetM_rebate_amount(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.m_card_holder2).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.m_card_holder2] = x_oMobileRetentionOrder.GetM_card_holder2(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.bill_medium_email).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.bill_medium_email] = x_oMobileRetentionOrder.GetBill_medium_email(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.active] = x_oMobileRetentionOrder.GetActive(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.s_premium1).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.s_premium1] = x_oMobileRetentionOrder.GetS_premium1(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.card_exp_month).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.card_exp_month] = x_oMobileRetentionOrder.GetCard_exp_month(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.ob_program_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.ob_program_id] = x_oMobileRetentionOrder.GetOb_program_id(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.sku).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.sku] = x_oMobileRetentionOrder.GetSku(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.ref_salesmancode).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.ref_salesmancode] = x_oMobileRetentionOrder.GetRef_salesmancode(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.go_wireless_package_code).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.go_wireless_package_code] = x_oMobileRetentionOrder.GetGo_wireless_package_code(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.third_party_hkid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.third_party_hkid] = x_oMobileRetentionOrder.GetThird_party_hkid(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_existing_pccw_customer).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.upgrade_existing_pccw_customer] = x_oMobileRetentionOrder.GetUpgrade_existing_pccw_customer(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.d_address).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.d_address] = x_oMobileRetentionOrder.GetD_address(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_registered_mobile_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.upgrade_registered_mobile_no] = x_oMobileRetentionOrder.GetUpgrade_registered_mobile_no(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_existing_customer_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.upgrade_existing_customer_type] = x_oMobileRetentionOrder.GetUpgrade_existing_customer_type(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.normal_rebate_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.normal_rebate_type] = x_oMobileRetentionOrder.GetNormal_rebate_type(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_desc2).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.gift_desc2] = x_oMobileRetentionOrder.GetGift_desc2(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_branch_code).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.monthly_bank_account_branch_code] = x_oMobileRetentionOrder.GetMonthly_bank_account_branch_code(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.remarks).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.remarks] = x_oMobileRetentionOrder.GetRemarks(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.accept).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.accept] = x_oMobileRetentionOrder.GetAccept(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.delivery_exchange).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.delivery_exchange] = x_oMobileRetentionOrder.GetDelivery_exchange(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_code2).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.gift_code2] = x_oMobileRetentionOrder.GetGift_code2(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.prepayment_waive).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.prepayment_waive] = x_oMobileRetentionOrder.GetPrepayment_waive(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.existing_smart_phone_imei).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.existing_smart_phone_imei] = x_oMobileRetentionOrder.GetExisting_smart_phone_imei(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.cust_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.cust_name] = x_oMobileRetentionOrder.GetCust_name(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.cust_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.cust_type] = x_oMobileRetentionOrder.GetCust_type(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_sponsorships_amount).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.upgrade_sponsorships_amount] = x_oMobileRetentionOrder.GetUpgrade_sponsorships_amount(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.bill_medium_waive).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.bill_medium_waive] = x_oMobileRetentionOrder.GetBill_medium_waive(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.delivery_exchange_location).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.delivery_exchange_location] = x_oMobileRetentionOrder.GetDelivery_exchange_location(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.hs_offer_type_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.hs_offer_type_id] = x_oMobileRetentionOrder.GetHs_offer_type_id(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.org_fee).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.org_fee] = x_oMobileRetentionOrder.GetOrg_fee(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.rebate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.rebate] = x_oMobileRetentionOrder.GetRebate(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.upgrade_type] = x_oMobileRetentionOrder.GetUpgrade_type(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.go_wireless).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.go_wireless] = x_oMobileRetentionOrder.GetGo_wireless(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.extra_rebate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.extra_rebate] = x_oMobileRetentionOrder.GetExtra_rebate(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.plan_eff).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.plan_eff] = x_oMobileRetentionOrder.GetPlan_eff(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.extra_rebate_amount).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.extra_rebate_amount] = x_oMobileRetentionOrder.GetExtra_rebate_amount(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.card_exp_year).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.card_exp_year] = x_oMobileRetentionOrder.GetCard_exp_year(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_existing_contract_sdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.upgrade_existing_contract_sdate] = x_oMobileRetentionOrder.GetUpgrade_existing_contract_sdate(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_hkid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.ord_place_hkid] = x_oMobileRetentionOrder.GetOrd_place_hkid(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.register_address).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.register_address] = x_oMobileRetentionOrder.GetRegister_address(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.gender).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.gender] = x_oMobileRetentionOrder.GetGender(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.lob_ac).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.lob_ac] = x_oMobileRetentionOrder.GetLob_ac(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.sim_mrt_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.sim_mrt_no] = x_oMobileRetentionOrder.GetSim_mrt_no(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.redemption_notice_option).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.redemption_notice_option] = x_oMobileRetentionOrder.GetRedemption_notice_option(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.delivery_collection_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.delivery_collection_type] = x_oMobileRetentionOrder.GetDelivery_collection_type(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.action_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.action_date] = x_oMobileRetentionOrder.GetAction_date(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.third_party_id_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.third_party_id_type] = x_oMobileRetentionOrder.GetThird_party_id_type(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.org_ftg).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.org_ftg] = x_oMobileRetentionOrder.GetOrg_ftg(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_service_tenure).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.upgrade_service_tenure] = x_oMobileRetentionOrder.GetUpgrade_service_tenure(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_payment_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.monthly_payment_type] = x_oMobileRetentionOrder.GetMonthly_payment_type(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.contact_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.contact_no] = x_oMobileRetentionOrder.GetContact_no(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.org_mrt).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.org_mrt] = x_oMobileRetentionOrder.GetOrg_mrt(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.sim_item_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.sim_item_name] = x_oMobileRetentionOrder.GetSim_item_name(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.pay_method).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.pay_method] = x_oMobileRetentionOrder.GetPay_method(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.hs_model).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.hs_model] = x_oMobileRetentionOrder.GetHs_model(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_code).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.gift_code] = x_oMobileRetentionOrder.GetGift_code(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_hkid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.monthly_bank_account_hkid] = x_oMobileRetentionOrder.GetMonthly_bank_account_hkid(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.extra_offer).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.extra_offer] = x_oMobileRetentionOrder.GetExtra_offer(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.monthly_bank_account_no] = x_oMobileRetentionOrder.GetMonthly_bank_account_no(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.first_month_license_fee).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.first_month_license_fee] = x_oMobileRetentionOrder.GetFirst_month_license_fee(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.retrieve_cnt).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.retrieve_cnt] = x_oMobileRetentionOrder.GetRetrieve_cnt(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.ddate] = x_oMobileRetentionOrder.GetDdate(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.s_premium2).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.s_premium2] = x_oMobileRetentionOrder.GetS_premium2(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_id_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.monthly_bank_account_id_type] = x_oMobileRetentionOrder.GetMonthly_bank_account_id_type(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.card_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.card_type] = x_oMobileRetentionOrder.GetCard_type(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.next_bill).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.next_bill] = x_oMobileRetentionOrder.GetNext_bill(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.pcd_paid_go_wireless).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.pcd_paid_go_wireless] = x_oMobileRetentionOrder.GetPcd_paid_go_wireless(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_rebate_calculation).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.upgrade_rebate_calculation] = x_oMobileRetentionOrder.GetUpgrade_rebate_calculation(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.ext_place_tel).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.ext_place_tel] = x_oMobileRetentionOrder.GetExt_place_tel(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.m_3rd_hkid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.m_3rd_hkid] = x_oMobileRetentionOrder.GetM_3rd_hkid(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.retention_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.retention_type] = x_oMobileRetentionOrder.GetRetention_type(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.cooling_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.cooling_date] = x_oMobileRetentionOrder.GetCooling_date(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.aig_gift).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.aig_gift] = x_oMobileRetentionOrder.GetAig_gift(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.cust_staff_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.cust_staff_no] = x_oMobileRetentionOrder.GetCust_staff_no(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.order_id] = x_oMobileRetentionOrder.GetOrder_id(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.family_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.family_name] = x_oMobileRetentionOrder.GetFamily_name(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.cdate] = x_oMobileRetentionOrder.GetCdate(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.status_by_cs_admin).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.status_by_cs_admin] = x_oMobileRetentionOrder.GetStatus_by_cs_admin(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.sim_item_number).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.sim_item_number] = x_oMobileRetentionOrder.GetSim_item_number(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.vip_case).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.vip_case] = x_oMobileRetentionOrder.GetVip_case(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.given_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.given_name] = x_oMobileRetentionOrder.GetGiven_name(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.log_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.log_date] = x_oMobileRetentionOrder.GetLog_date(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.extn).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.extn] = x_oMobileRetentionOrder.GetExtn(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.d_time).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.d_time] = x_oMobileRetentionOrder.GetD_time(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.bank_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.bank_name] = x_oMobileRetentionOrder.GetBank_name(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.delivery_exchange_option).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.delivery_exchange_option] = x_oMobileRetentionOrder.GetDelivery_exchange_option(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_service_account_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.upgrade_service_account_no] = x_oMobileRetentionOrder.GetUpgrade_service_account_no(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.action_of_rate_plan_effective).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.action_of_rate_plan_effective] = x_oMobileRetentionOrder.GetAction_of_rate_plan_effective(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.m_card_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.m_card_no] = x_oMobileRetentionOrder.GetM_card_no(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.existing_contract_end_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.existing_contract_end_date] = x_oMobileRetentionOrder.GetExisting_contract_end_date(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.con_eff_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.con_eff_date] = x_oMobileRetentionOrder.GetCon_eff_date(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.m_3rd_hkid2).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.m_3rd_hkid2] = x_oMobileRetentionOrder.GetM_3rd_hkid2(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.amount).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.amount] = x_oMobileRetentionOrder.GetAmount(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.id_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.id_type] = x_oMobileRetentionOrder.GetId_type(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.rate_plan).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.rate_plan] = x_oMobileRetentionOrder.GetRate_plan(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.channel).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.channel] = x_oMobileRetentionOrder.GetChannel(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.action_eff_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.action_eff_date] = x_oMobileRetentionOrder.GetAction_eff_date(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.issue_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.issue_type] = x_oMobileRetentionOrder.GetIssue_type(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.free_mon).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.free_mon] = x_oMobileRetentionOrder.GetFree_mon(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.plan_eff_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.plan_eff_date] = x_oMobileRetentionOrder.GetPlan_eff_date(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.del_remark).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.del_remark] = x_oMobileRetentionOrder.GetDel_remark(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.teamcode).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.teamcode] = x_oMobileRetentionOrder.GetTeamcode(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.staff_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.staff_name] = x_oMobileRetentionOrder.GetStaff_name(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.edf_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.edf_no] = x_oMobileRetentionOrder.GetEdf_no(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_by).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.ord_place_by] = x_oMobileRetentionOrder.GetOrd_place_by(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.cancel_renew).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.cancel_renew] = x_oMobileRetentionOrder.GetCancel_renew(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.preferred_languages).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.preferred_languages] = x_oMobileRetentionOrder.GetPreferred_languages(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.hkid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.hkid] = x_oMobileRetentionOrder.GetHkid(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.card_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.card_no] = x_oMobileRetentionOrder.GetCard_no(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.ac_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.ac_no] = x_oMobileRetentionOrder.GetAc_no(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.bill_cut_num).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.bill_cut_num] = x_oMobileRetentionOrder.GetBill_cut_num(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.premium).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.premium] = x_oMobileRetentionOrder.GetPremium(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.m_3rd_id_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.m_3rd_id_type] = x_oMobileRetentionOrder.GetM_3rd_id_type(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_imei2).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.gift_imei2] = x_oMobileRetentionOrder.GetGift_imei2(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.reasons).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.reasons] = x_oMobileRetentionOrder.GetReasons(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.language).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.language] = x_oMobileRetentionOrder.GetLanguage(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.rebate_amount).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.rebate_amount] = x_oMobileRetentionOrder.GetRebate_amount(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.lob).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.lob] = x_oMobileRetentionOrder.GetLob(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.m_3rd_contact_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.m_3rd_contact_no] = x_oMobileRetentionOrder.GetM_3rd_contact_no(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.staff_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.staff_no] = x_oMobileRetentionOrder.GetStaff_no(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.s_premium3).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.s_premium3] = x_oMobileRetentionOrder.GetS_premium3(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.sp_d_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.sp_d_date] = x_oMobileRetentionOrder.GetSp_d_date(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.bundle_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.bundle_name] = x_oMobileRetentionOrder.GetBundle_name(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.accessory_waive).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.accessory_waive] = x_oMobileRetentionOrder.GetAccessory_waive(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.sim_item_code).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.sim_item_code] = x_oMobileRetentionOrder.GetSim_item_code(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_holder).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.monthly_bank_account_holder] = x_oMobileRetentionOrder.GetMonthly_bank_account_holder(); }
                if (x_oTableSet.Fields(MobileRetentionOrder.Para.card_holder).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrder.Para.card_holder] = x_oMobileRetentionOrder.GetCard_holder(); }
                _oDSet.Tables[MobileRetentionOrder.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(MobileRetentionOrderInfo x_oTableSet)
        {
            return MobileRetentionOrderBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return MobileRetentionOrderBal.ToEmptyDataSetProcess(MobileRetentionOrderInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(MobileRetentionOrderInfo x_oTableSet)
        {
            return MobileRetentionOrderBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(MobileRetentionOrder x_oMobileRetentionOrder, MobileRetentionOrderInfo x_oTableSet)
        {
            return MobileRetentionOrderBal.GetDataSet(null, null, x_oTableSet).Tables[MobileRetentionOrder.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(MobileRetentionOrder x_oMobileRetentionOrder)
        {
            return MobileRetentionOrderBal.GetDataSet(x_oMobileRetentionOrder, null, MobileRetentionOrderInfoDLL.CreateInfoInstanceObject()).Tables[MobileRetentionOrder.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iOrder_id)
        {
            return Row(x_oTable, x_oDB,x_iOrder_id,MobileRetentionOrderInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iOrder_id, MobileRetentionOrderInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iOrder_id, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iOrder_id,MobileRetentionOrderInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileRetentionOrderInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [MobileRetentionOrder].[gift_imei] AS MOBILERETENTIONORDER_GIFT_IMEI,[MobileRetentionOrder].[s_premium4] AS MOBILERETENTIONORDER_S_PREMIUM4,[MobileRetentionOrder].[upgrade_existing_customer_type] AS MOBILERETENTIONORDER_UPGRADE_EXISTING_CUSTOMER_TYPE,[MobileRetentionOrder].[gift_desc4] AS MOBILERETENTIONORDER_GIFT_DESC4,[MobileRetentionOrder].[accessory_desc] AS MOBILERETENTIONORDER_ACCESSORY_DESC,[MobileRetentionOrder].[staff_name] AS MOBILERETENTIONORDER_STAFF_NAME,[MobileRetentionOrder].[action_required] AS MOBILERETENTIONORDER_ACTION_REQUIRED,[MobileRetentionOrder].[vas_eff_date] AS MOBILERETENTIONORDER_VAS_EFF_DATE,[MobileRetentionOrder].[monthly_bank_account_bank_code] AS MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_BANK_CODE,[MobileRetentionOrder].[sim_item_number] AS MOBILERETENTIONORDER_SIM_ITEM_NUMBER,[MobileRetentionOrder].[special_handling_dummy_code] AS MOBILERETENTIONORDER_SPECIAL_HANDLING_DUMMY_CODE,[MobileRetentionOrder].[card_no] AS MOBILERETENTIONORDER_CARD_NO,[MobileRetentionOrder].[m_card_exp_year] AS MOBILERETENTIONORDER_M_CARD_EXP_YEAR,[MobileRetentionOrder].[bill_medium_email] AS MOBILERETENTIONORDER_BILL_MEDIUM_EMAIL,[MobileRetentionOrder].[remarks2PY] AS MOBILERETENTIONORDER_REMARKS2PY,[MobileRetentionOrder].[trade_field] AS MOBILERETENTIONORDER_TRADE_FIELD,[MobileRetentionOrder].[ord_place_tel] AS MOBILERETENTIONORDER_ORD_PLACE_TEL,[MobileRetentionOrder].[action_of_rate_plan_effective] AS MOBILERETENTIONORDER_ACTION_OF_RATE_PLAN_EFFECTIVE,[MobileRetentionOrder].[cooling_offer] AS MOBILERETENTIONORDER_COOLING_OFFER,[MobileRetentionOrder].[upgrade_handset_offer_rebate_schedule] AS MOBILERETENTIONORDER_UPGRADE_HANDSET_OFFER_REBATE_SCHEDULE,[MobileRetentionOrder].[change_payment_type] AS MOBILERETENTIONORDER_CHANGE_PAYMENT_TYPE,[MobileRetentionOrder].[date_of_birth] AS MOBILERETENTIONORDER_DATE_OF_BIRTH,[MobileRetentionOrder].[contact_person] AS MOBILERETENTIONORDER_CONTACT_PERSON,[MobileRetentionOrder].[extra_d_charge] AS MOBILERETENTIONORDER_EXTRA_D_CHARGE,[MobileRetentionOrder].[tl_name] AS MOBILERETENTIONORDER_TL_NAME,[MobileRetentionOrder].[fast_start] AS MOBILERETENTIONORDER_FAST_START,[MobileRetentionOrder].[sp_ref_no] AS MOBILERETENTIONORDER_SP_REF_NO,[MobileRetentionOrder].[edate] AS MOBILERETENTIONORDER_EDATE,[MobileRetentionOrder].[exist_cust_plan] AS MOBILERETENTIONORDER_EXIST_CUST_PLAN,[MobileRetentionOrder].[ord_place_rel] AS MOBILERETENTIONORDER_ORD_PLACE_REL,[MobileRetentionOrder].[mrt_no] AS MOBILERETENTIONORDER_MRT_NO,[MobileRetentionOrder].[imei_no] AS MOBILERETENTIONORDER_IMEI_NO,[MobileRetentionOrder].[existing_smart_phone_model] AS MOBILERETENTIONORDER_EXISTING_SMART_PHONE_MODEL,[MobileRetentionOrder].[bank_code] AS MOBILERETENTIONORDER_BANK_CODE,[MobileRetentionOrder].[pos_ref_no] AS MOBILERETENTIONORDER_POS_REF_NO,[MobileRetentionOrder].[bill_cut_date] AS MOBILERETENTIONORDER_BILL_CUT_DATE,[MobileRetentionOrder].[gift_imei3] AS MOBILERETENTIONORDER_GIFT_IMEI3,[MobileRetentionOrder].[exist_plan] AS MOBILERETENTIONORDER_EXIST_PLAN,[MobileRetentionOrder].[waive] AS MOBILERETENTIONORDER_WAIVE,[MobileRetentionOrder].[program] AS MOBILERETENTIONORDER_PROGRAM,[MobileRetentionOrder].[first_month_fee] AS MOBILERETENTIONORDER_FIRST_MONTH_FEE,[MobileRetentionOrder].[r_offer] AS MOBILERETENTIONORDER_R_OFFER,[MobileRetentionOrder].[cid] AS MOBILERETENTIONORDER_CID,[MobileRetentionOrder].[did] AS MOBILERETENTIONORDER_DID,[MobileRetentionOrder].[ftg_tenure] AS MOBILERETENTIONORDER_FTG_TENURE,[MobileRetentionOrder].[con_per] AS MOBILERETENTIONORDER_CON_PER,[MobileRetentionOrder].[gift_code4] AS MOBILERETENTIONORDER_GIFT_CODE4,[MobileRetentionOrder].[easywatch_type] AS MOBILERETENTIONORDER_EASYWATCH_TYPE,[MobileRetentionOrder].[sms_mrt] AS MOBILERETENTIONORDER_SMS_MRT,[MobileRetentionOrder].[monthly_payment_method] AS MOBILERETENTIONORDER_MONTHLY_PAYMENT_METHOD,[MobileRetentionOrder].[remarks2EDF] AS MOBILERETENTIONORDER_REMARKS2EDF,[MobileRetentionOrder].[gift_desc3] AS MOBILERETENTIONORDER_GIFT_DESC3,[MobileRetentionOrder].[gift_imei4] AS MOBILERETENTIONORDER_GIFT_IMEI4,[MobileRetentionOrder].[monthly_bank_account_hkid2] AS MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HKID2,[MobileRetentionOrder].[d_date] AS MOBILERETENTIONORDER_D_DATE,[MobileRetentionOrder].[gift_desc] AS MOBILERETENTIONORDER_GIFT_DESC,[MobileRetentionOrder].[pool] AS MOBILERETENTIONORDER_POOL,[MobileRetentionOrder].[cn_mrt_no] AS MOBILERETENTIONORDER_CN_MRT_NO,[MobileRetentionOrder].[accessory_imei] AS MOBILERETENTIONORDER_ACCESSORY_IMEI,[MobileRetentionOrder].[third_party_credit_card] AS MOBILERETENTIONORDER_THIRD_PARTY_CREDIT_CARD,[MobileRetentionOrder].[special_approval] AS MOBILERETENTIONORDER_SPECIAL_APPROVAL,[MobileRetentionOrder].[upgrade_existing_contract_edate] AS MOBILERETENTIONORDER_UPGRADE_EXISTING_CONTRACT_EDATE,[MobileRetentionOrder].[accessory_code] AS MOBILERETENTIONORDER_ACCESSORY_CODE,[MobileRetentionOrder].[s_premium] AS MOBILERETENTIONORDER_S_PREMIUM,[MobileRetentionOrder].[ref_staff_no] AS MOBILERETENTIONORDER_REF_STAFF_NO,[MobileRetentionOrder].[accessory_price] AS MOBILERETENTIONORDER_ACCESSORY_PRICE,[MobileRetentionOrder].[m_card_exp_month] AS MOBILERETENTIONORDER_M_CARD_EXP_MONTH,[MobileRetentionOrder].[installment_period] AS MOBILERETENTIONORDER_INSTALLMENT_PERIOD,[MobileRetentionOrder].[m_card_type] AS MOBILERETENTIONORDER_M_CARD_TYPE,[MobileRetentionOrder].[easywatch_ord_id] AS MOBILERETENTIONORDER_EASYWATCH_ORD_ID,[MobileRetentionOrder].[normal_rebate] AS MOBILERETENTIONORDER_NORMAL_REBATE,[MobileRetentionOrder].[m_rebate_amount] AS MOBILERETENTIONORDER_M_REBATE_AMOUNT,[MobileRetentionOrder].[m_card_holder2] AS MOBILERETENTIONORDER_M_CARD_HOLDER2,[MobileRetentionOrder].[monthly_bank_account_holder] AS MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HOLDER,[MobileRetentionOrder].[active] AS MOBILERETENTIONORDER_ACTIVE,[MobileRetentionOrder].[s_premium1] AS MOBILERETENTIONORDER_S_PREMIUM1,[MobileRetentionOrder].[card_exp_month] AS MOBILERETENTIONORDER_CARD_EXP_MONTH,[MobileRetentionOrder].[ob_program_id] AS MOBILERETENTIONORDER_OB_PROGRAM_ID,[MobileRetentionOrder].[sku] AS MOBILERETENTIONORDER_SKU,[MobileRetentionOrder].[salesmancode] AS MOBILERETENTIONORDER_SALESMANCODE,[MobileRetentionOrder].[go_wireless_package_code] AS MOBILERETENTIONORDER_GO_WIRELESS_PACKAGE_CODE,[MobileRetentionOrder].[lob] AS MOBILERETENTIONORDER_LOB,[MobileRetentionOrder].[ref_salesmancode] AS MOBILERETENTIONORDER_REF_SALESMANCODE,[MobileRetentionOrder].[third_party_hkid] AS MOBILERETENTIONORDER_THIRD_PARTY_HKID,[MobileRetentionOrder].[upgrade_existing_pccw_customer] AS MOBILERETENTIONORDER_UPGRADE_EXISTING_PCCW_CUSTOMER,[MobileRetentionOrder].[d_address] AS MOBILERETENTIONORDER_D_ADDRESS,[MobileRetentionOrder].[upgrade_registered_mobile_no] AS MOBILERETENTIONORDER_UPGRADE_REGISTERED_MOBILE_NO,[MobileRetentionOrder].[gift_code3] AS MOBILERETENTIONORDER_GIFT_CODE3,[MobileRetentionOrder].[normal_rebate_type] AS MOBILERETENTIONORDER_NORMAL_REBATE_TYPE,[MobileRetentionOrder].[gift_desc2] AS MOBILERETENTIONORDER_GIFT_DESC2,[MobileRetentionOrder].[monthly_bank_account_branch_code] AS MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_BRANCH_CODE,[MobileRetentionOrder].[remarks] AS MOBILERETENTIONORDER_REMARKS,[MobileRetentionOrder].[accept] AS MOBILERETENTIONORDER_ACCEPT,[MobileRetentionOrder].[delivery_exchange] AS MOBILERETENTIONORDER_DELIVERY_EXCHANGE,[MobileRetentionOrder].[gift_code2] AS MOBILERETENTIONORDER_GIFT_CODE2,[MobileRetentionOrder].[prepayment_waive] AS MOBILERETENTIONORDER_PREPAYMENT_WAIVE,[MobileRetentionOrder].[existing_smart_phone_imei] AS MOBILERETENTIONORDER_EXISTING_SMART_PHONE_IMEI,[MobileRetentionOrder].[cust_name] AS MOBILERETENTIONORDER_CUST_NAME,[MobileRetentionOrder].[upgrade_sponsorships_amount] AS MOBILERETENTIONORDER_UPGRADE_SPONSORSHIPS_AMOUNT,[MobileRetentionOrder].[bill_medium_waive] AS MOBILERETENTIONORDER_BILL_MEDIUM_WAIVE,[MobileRetentionOrder].[delivery_exchange_location] AS MOBILERETENTIONORDER_DELIVERY_EXCHANGE_LOCATION,[MobileRetentionOrder].[hs_offer_type_id] AS MOBILERETENTIONORDER_HS_OFFER_TYPE_ID,[MobileRetentionOrder].[extra_rebate_amount] AS MOBILERETENTIONORDER_EXTRA_REBATE_AMOUNT,[MobileRetentionOrder].[rebate] AS MOBILERETENTIONORDER_REBATE,[MobileRetentionOrder].[upgrade_type] AS MOBILERETENTIONORDER_UPGRADE_TYPE,[MobileRetentionOrder].[go_wireless] AS MOBILERETENTIONORDER_GO_WIRELESS,[MobileRetentionOrder].[extra_rebate] AS MOBILERETENTIONORDER_EXTRA_REBATE,[MobileRetentionOrder].[plan_eff] AS MOBILERETENTIONORDER_PLAN_EFF,[MobileRetentionOrder].[card_exp_year] AS MOBILERETENTIONORDER_CARD_EXP_YEAR,[MobileRetentionOrder].[upgrade_existing_contract_sdate] AS MOBILERETENTIONORDER_UPGRADE_EXISTING_CONTRACT_SDATE,[MobileRetentionOrder].[ord_place_hkid] AS MOBILERETENTIONORDER_ORD_PLACE_HKID,[MobileRetentionOrder].[register_address] AS MOBILERETENTIONORDER_REGISTER_ADDRESS,[MobileRetentionOrder].[gender] AS MOBILERETENTIONORDER_GENDER,[MobileRetentionOrder].[lob_ac] AS MOBILERETENTIONORDER_LOB_AC,[MobileRetentionOrder].[sim_mrt_no] AS MOBILERETENTIONORDER_SIM_MRT_NO,[MobileRetentionOrder].[redemption_notice_option] AS MOBILERETENTIONORDER_REDEMPTION_NOTICE_OPTION,[MobileRetentionOrder].[delivery_collection_type] AS MOBILERETENTIONORDER_DELIVERY_COLLECTION_TYPE,[MobileRetentionOrder].[action_date] AS MOBILERETENTIONORDER_ACTION_DATE,[MobileRetentionOrder].[third_party_id_type] AS MOBILERETENTIONORDER_THIRD_PARTY_ID_TYPE,[MobileRetentionOrder].[org_ftg] AS MOBILERETENTIONORDER_ORG_FTG,[MobileRetentionOrder].[upgrade_service_tenure] AS MOBILERETENTIONORDER_UPGRADE_SERVICE_TENURE,[MobileRetentionOrder].[monthly_payment_type] AS MOBILERETENTIONORDER_MONTHLY_PAYMENT_TYPE,[MobileRetentionOrder].[contact_no] AS MOBILERETENTIONORDER_CONTACT_NO,[MobileRetentionOrder].[org_mrt] AS MOBILERETENTIONORDER_ORG_MRT,[MobileRetentionOrder].[sim_item_name] AS MOBILERETENTIONORDER_SIM_ITEM_NAME,[MobileRetentionOrder].[pay_method] AS MOBILERETENTIONORDER_PAY_METHOD,[MobileRetentionOrder].[hs_model] AS MOBILERETENTIONORDER_HS_MODEL,[MobileRetentionOrder].[gift_code] AS MOBILERETENTIONORDER_GIFT_CODE,[MobileRetentionOrder].[monthly_bank_account_hkid] AS MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HKID,[MobileRetentionOrder].[extra_offer] AS MOBILERETENTIONORDER_EXTRA_OFFER,[MobileRetentionOrder].[monthly_bank_account_no] AS MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_NO,[MobileRetentionOrder].[first_month_license_fee] AS MOBILERETENTIONORDER_FIRST_MONTH_LICENSE_FEE,[MobileRetentionOrder].[retrieve_cnt] AS MOBILERETENTIONORDER_RETRIEVE_CNT,[MobileRetentionOrder].[ddate] AS MOBILERETENTIONORDER_DDATE,[MobileRetentionOrder].[s_premium2] AS MOBILERETENTIONORDER_S_PREMIUM2,[MobileRetentionOrder].[monthly_bank_account_id_type] AS MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_ID_TYPE,[MobileRetentionOrder].[card_type] AS MOBILERETENTIONORDER_CARD_TYPE,[MobileRetentionOrder].[next_bill] AS MOBILERETENTIONORDER_NEXT_BILL,[MobileRetentionOrder].[pcd_paid_go_wireless] AS MOBILERETENTIONORDER_PCD_PAID_GO_WIRELESS,[MobileRetentionOrder].[upgrade_rebate_calculation] AS MOBILERETENTIONORDER_UPGRADE_REBATE_CALCULATION,[MobileRetentionOrder].[ext_place_tel] AS MOBILERETENTIONORDER_EXT_PLACE_TEL,[MobileRetentionOrder].[m_3rd_hkid] AS MOBILERETENTIONORDER_M_3RD_HKID,[MobileRetentionOrder].[retention_type] AS MOBILERETENTIONORDER_RETENTION_TYPE,[MobileRetentionOrder].[cooling_date] AS MOBILERETENTIONORDER_COOLING_DATE,[MobileRetentionOrder].[aig_gift] AS MOBILERETENTIONORDER_AIG_GIFT,[MobileRetentionOrder].[cust_staff_no] AS MOBILERETENTIONORDER_CUST_STAFF_NO,[MobileRetentionOrder].[order_id] AS MOBILERETENTIONORDER_ORDER_ID,[MobileRetentionOrder].[family_name] AS MOBILERETENTIONORDER_FAMILY_NAME,[MobileRetentionOrder].[cdate] AS MOBILERETENTIONORDER_CDATE,[MobileRetentionOrder].[status_by_cs_admin] AS MOBILERETENTIONORDER_STATUS_BY_CS_ADMIN,[MobileRetentionOrder].[given_name] AS MOBILERETENTIONORDER_GIVEN_NAME,[MobileRetentionOrder].[vip_case] AS MOBILERETENTIONORDER_VIP_CASE,[MobileRetentionOrder].[org_fee] AS MOBILERETENTIONORDER_ORG_FEE,[MobileRetentionOrder].[s_premium3] AS MOBILERETENTIONORDER_S_PREMIUM3,[MobileRetentionOrder].[log_date] AS MOBILERETENTIONORDER_LOG_DATE,[MobileRetentionOrder].[extn] AS MOBILERETENTIONORDER_EXTN,[MobileRetentionOrder].[d_time] AS MOBILERETENTIONORDER_D_TIME,[MobileRetentionOrder].[bank_name] AS MOBILERETENTIONORDER_BANK_NAME,[MobileRetentionOrder].[delivery_exchange_option] AS MOBILERETENTIONORDER_DELIVERY_EXCHANGE_OPTION,[MobileRetentionOrder].[upgrade_service_account_no] AS MOBILERETENTIONORDER_UPGRADE_SERVICE_ACCOUNT_NO,[MobileRetentionOrder].[old_ord_id] AS MOBILERETENTIONORDER_OLD_ORD_ID,[MobileRetentionOrder].[m_card_no] AS MOBILERETENTIONORDER_M_CARD_NO,[MobileRetentionOrder].[existing_contract_end_date] AS MOBILERETENTIONORDER_EXISTING_CONTRACT_END_DATE,[MobileRetentionOrder].[con_eff_date] AS MOBILERETENTIONORDER_CON_EFF_DATE,[MobileRetentionOrder].[m_3rd_hkid2] AS MOBILERETENTIONORDER_M_3RD_HKID2,[MobileRetentionOrder].[amount] AS MOBILERETENTIONORDER_AMOUNT,[MobileRetentionOrder].[m_3rd_id_type] AS MOBILERETENTIONORDER_M_3RD_ID_TYPE,[MobileRetentionOrder].[id_type] AS MOBILERETENTIONORDER_ID_TYPE,[MobileRetentionOrder].[rate_plan] AS MOBILERETENTIONORDER_RATE_PLAN,[MobileRetentionOrder].[channel] AS MOBILERETENTIONORDER_CHANNEL,[MobileRetentionOrder].[action_eff_date] AS MOBILERETENTIONORDER_ACTION_EFF_DATE,[MobileRetentionOrder].[issue_type] AS MOBILERETENTIONORDER_ISSUE_TYPE,[MobileRetentionOrder].[free_mon] AS MOBILERETENTIONORDER_FREE_MON,[MobileRetentionOrder].[plan_eff_date] AS MOBILERETENTIONORDER_PLAN_EFF_DATE,[MobileRetentionOrder].[teamcode] AS MOBILERETENTIONORDER_TEAMCODE,[MobileRetentionOrder].[bill_medium] AS MOBILERETENTIONORDER_BILL_MEDIUM,[MobileRetentionOrder].[edf_no] AS MOBILERETENTIONORDER_EDF_NO,[MobileRetentionOrder].[ord_place_by] AS MOBILERETENTIONORDER_ORD_PLACE_BY,[MobileRetentionOrder].[cancel_renew] AS MOBILERETENTIONORDER_CANCEL_RENEW,[MobileRetentionOrder].[preferred_languages] AS MOBILERETENTIONORDER_PREFERRED_LANGUAGES,[MobileRetentionOrder].[hkid] AS MOBILERETENTIONORDER_HKID,[MobileRetentionOrder].[card_holder] AS MOBILERETENTIONORDER_CARD_HOLDER,[MobileRetentionOrder].[ac_no] AS MOBILERETENTIONORDER_AC_NO,[MobileRetentionOrder].[bill_cut_num] AS MOBILERETENTIONORDER_BILL_CUT_NUM,[MobileRetentionOrder].[premium] AS MOBILERETENTIONORDER_PREMIUM,[MobileRetentionOrder].[del_remark] AS MOBILERETENTIONORDER_DEL_REMARK,[MobileRetentionOrder].[gift_imei2] AS MOBILERETENTIONORDER_GIFT_IMEI2,[MobileRetentionOrder].[reasons] AS MOBILERETENTIONORDER_REASONS,[MobileRetentionOrder].[language] AS MOBILERETENTIONORDER_LANGUAGE,[MobileRetentionOrder].[rebate_amount] AS MOBILERETENTIONORDER_REBATE_AMOUNT,[MobileRetentionOrder].[ord_place_id_type] AS MOBILERETENTIONORDER_ORD_PLACE_ID_TYPE,[MobileRetentionOrder].[m_3rd_contact_no] AS MOBILERETENTIONORDER_M_3RD_CONTACT_NO,[MobileRetentionOrder].[staff_no] AS MOBILERETENTIONORDER_STAFF_NO,[MobileRetentionOrder].[sp_d_date] AS MOBILERETENTIONORDER_SP_D_DATE,[MobileRetentionOrder].[bundle_name] AS MOBILERETENTIONORDER_BUNDLE_NAME,[MobileRetentionOrder].[accessory_waive] AS MOBILERETENTIONORDER_ACCESSORY_WAIVE,[MobileRetentionOrder].[sim_item_code] AS MOBILERETENTIONORDER_SIM_ITEM_CODE,[MobileRetentionOrder].[cust_type] AS MOBILERETENTIONORDER_CUST_TYPE,[MobileRetentionOrder].[card_ref_no] AS MOBILERETENTIONORDER_CARD_REF_NO  FROM  [MobileRetentionOrder]  WHERE  [MobileRetentionOrder].[order_id] = \'"+x_iOrder_id.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionOrder]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrder]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_imei).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_IMEI"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.gift_imei).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.gift_imei).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_GIFT_IMEI"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.gift_imei).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.s_premium4).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_S_PREMIUM4"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.s_premium4).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.s_premium4).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_S_PREMIUM4"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.s_premium4).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_existing_customer_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_EXISTING_CUSTOMER_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_existing_customer_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_existing_customer_type).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_UPGRADE_EXISTING_CUSTOMER_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_existing_customer_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_desc4).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_DESC4"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.gift_desc4).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.gift_desc4).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_GIFT_DESC4"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.gift_desc4).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.accessory_desc).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACCESSORY_DESC"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.accessory_desc).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.accessory_desc).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_ACCESSORY_DESC"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.accessory_desc).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.staff_name).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_STAFF_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.staff_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.staff_name).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_STAFF_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.staff_name).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.action_required).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACTION_REQUIRED"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.action_required).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.action_required).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_ACTION_REQUIRED"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.action_required).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.vas_eff_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_VAS_EFF_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.vas_eff_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.vas_eff_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_VAS_EFF_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.vas_eff_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_bank_code).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_BANK_CODE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_bank_code).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_bank_code).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_BANK_CODE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_bank_code).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.sim_item_number).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SIM_ITEM_NUMBER"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.sim_item_number).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.sim_item_number).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_SIM_ITEM_NUMBER"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.sim_item_number).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.special_handling_dummy_code).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SPECIAL_HANDLING_DUMMY_CODE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.special_handling_dummy_code).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.special_handling_dummy_code).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_SPECIAL_HANDLING_DUMMY_CODE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.special_handling_dummy_code).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.card_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CARD_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.card_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.card_no).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_CARD_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.card_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.m_card_exp_year).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_CARD_EXP_YEAR"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.m_card_exp_year).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.m_card_exp_year).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_M_CARD_EXP_YEAR"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.m_card_exp_year).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.bill_medium_email).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_BILL_MEDIUM_EMAIL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.bill_medium_email).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.bill_medium_email).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_BILL_MEDIUM_EMAIL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.bill_medium_email).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.remarks2PY).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REMARKS2PY"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.remarks2PY).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.remarks2PY).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_REMARKS2PY"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.remarks2PY).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.trade_field).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_TRADE_FIELD"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.trade_field).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.trade_field).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_TRADE_FIELD"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.trade_field).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_tel).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORD_PLACE_TEL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_tel).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_tel).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_ORD_PLACE_TEL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_tel).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.action_of_rate_plan_effective).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACTION_OF_RATE_PLAN_EFFECTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.action_of_rate_plan_effective).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.action_of_rate_plan_effective).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_ACTION_OF_RATE_PLAN_EFFECTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.action_of_rate_plan_effective).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.cooling_offer).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_COOLING_OFFER"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.cooling_offer).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.cooling_offer).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_COOLING_OFFER"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.cooling_offer).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_handset_offer_rebate_schedule).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_HANDSET_OFFER_REBATE_SCHEDULE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_handset_offer_rebate_schedule).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_handset_offer_rebate_schedule).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_UPGRADE_HANDSET_OFFER_REBATE_SCHEDULE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_handset_offer_rebate_schedule).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.change_payment_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CHANGE_PAYMENT_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.change_payment_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.change_payment_type).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_CHANGE_PAYMENT_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.change_payment_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.date_of_birth).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_DATE_OF_BIRTH"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.date_of_birth).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.date_of_birth).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_DATE_OF_BIRTH"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.date_of_birth).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.contact_person).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CONTACT_PERSON"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.contact_person).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.contact_person).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_CONTACT_PERSON"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.contact_person).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.extra_d_charge).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXTRA_D_CHARGE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.extra_d_charge).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.extra_d_charge).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_EXTRA_D_CHARGE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.extra_d_charge).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.tl_name).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_TL_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.tl_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.tl_name).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_TL_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.tl_name).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.fast_start).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_FAST_START"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.fast_start).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.fast_start).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_FAST_START"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.fast_start).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.sp_ref_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SP_REF_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.sp_ref_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.sp_ref_no).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_SP_REF_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.sp_ref_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.edate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.edate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.edate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_EDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.edate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.exist_cust_plan).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXIST_CUST_PLAN"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.exist_cust_plan).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.exist_cust_plan).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_EXIST_CUST_PLAN"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.exist_cust_plan).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_rel).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORD_PLACE_REL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_rel).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_rel).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_ORD_PLACE_REL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_rel).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.mrt_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MRT_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.mrt_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.mrt_no).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDER_MRT_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.mrt_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.imei_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_IMEI_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.imei_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.imei_no).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_IMEI_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.imei_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.existing_smart_phone_model).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXISTING_SMART_PHONE_MODEL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.existing_smart_phone_model).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.existing_smart_phone_model).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_EXISTING_SMART_PHONE_MODEL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.existing_smart_phone_model).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.bank_code).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_BANK_CODE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.bank_code).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.bank_code).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_BANK_CODE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.bank_code).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.pos_ref_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_POS_REF_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.pos_ref_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.pos_ref_no).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_POS_REF_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.pos_ref_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.bill_cut_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_BILL_CUT_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.bill_cut_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.bill_cut_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_BILL_CUT_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.bill_cut_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_imei3).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_IMEI3"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.gift_imei3).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.gift_imei3).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_GIFT_IMEI3"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.gift_imei3).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.exist_plan).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXIST_PLAN"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.exist_plan).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.exist_plan).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_EXIST_PLAN"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.exist_plan).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.waive).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_WAIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.waive).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.waive).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_WAIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.waive).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.program).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_PROGRAM"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.program).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.program).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_PROGRAM"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.program).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.first_month_fee).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_FIRST_MONTH_FEE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.first_month_fee).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.first_month_fee).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_FIRST_MONTH_FEE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.first_month_fee).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.r_offer).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_R_OFFER"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.r_offer).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.r_offer).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_R_OFFER"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.r_offer).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.cid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.cid).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.cid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.did).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.did).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.did).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.ftg_tenure).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_FTG_TENURE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.ftg_tenure).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.ftg_tenure).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_FTG_TENURE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.ftg_tenure).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.con_per).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CON_PER"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.con_per).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.con_per).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_CON_PER"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.con_per).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_code4).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_CODE4"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.gift_code4).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.gift_code4).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_GIFT_CODE4"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.gift_code4).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.easywatch_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EASYWATCH_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.easywatch_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.easywatch_type).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_EASYWATCH_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.easywatch_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.sms_mrt).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SMS_MRT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.sms_mrt).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.sms_mrt).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_SMS_MRT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.sms_mrt).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_payment_method).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_PAYMENT_METHOD"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_payment_method).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_payment_method).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_MONTHLY_PAYMENT_METHOD"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_payment_method).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.remarks2EDF).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REMARKS2EDF"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.remarks2EDF).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.remarks2EDF).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_REMARKS2EDF"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.remarks2EDF).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_desc3).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_DESC3"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.gift_desc3).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.gift_desc3).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_GIFT_DESC3"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.gift_desc3).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_imei4).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_IMEI4"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.gift_imei4).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.gift_imei4).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_GIFT_IMEI4"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.gift_imei4).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_hkid2).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HKID2"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_hkid2).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_hkid2).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HKID2"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_hkid2).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.d_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_D_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.d_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.d_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_D_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.d_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_desc).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_DESC"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.gift_desc).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.gift_desc).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_GIFT_DESC"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.gift_desc).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.pool).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_POOL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.pool).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.pool).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_POOL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.pool).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.cn_mrt_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CN_MRT_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.cn_mrt_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.cn_mrt_no).AliasName].ToString()] = (global::System.Nullable<long>)_oData["MOBILERETENTIONORDER_CN_MRT_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.cn_mrt_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.accessory_imei).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACCESSORY_IMEI"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.accessory_imei).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.accessory_imei).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_ACCESSORY_IMEI"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.accessory_imei).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.third_party_credit_card).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_THIRD_PARTY_CREDIT_CARD"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.third_party_credit_card).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.third_party_credit_card).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_THIRD_PARTY_CREDIT_CARD"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.third_party_credit_card).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.special_approval).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SPECIAL_APPROVAL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.special_approval).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.special_approval).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_SPECIAL_APPROVAL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.special_approval).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_existing_contract_edate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_EXISTING_CONTRACT_EDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_existing_contract_edate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_existing_contract_edate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_UPGRADE_EXISTING_CONTRACT_EDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_existing_contract_edate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.accessory_code).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACCESSORY_CODE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.accessory_code).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.accessory_code).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_ACCESSORY_CODE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.accessory_code).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.s_premium).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_S_PREMIUM"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.s_premium).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.s_premium).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_S_PREMIUM"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.s_premium).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.ref_staff_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REF_STAFF_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.ref_staff_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.ref_staff_no).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_REF_STAFF_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.ref_staff_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.accessory_price).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACCESSORY_PRICE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.accessory_price).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.accessory_price).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_ACCESSORY_PRICE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.accessory_price).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.m_card_exp_month).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_CARD_EXP_MONTH"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.m_card_exp_month).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.m_card_exp_month).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_M_CARD_EXP_MONTH"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.m_card_exp_month).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.installment_period).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_INSTALLMENT_PERIOD"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.installment_period).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.installment_period).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_INSTALLMENT_PERIOD"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.installment_period).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.m_card_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_CARD_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.m_card_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.m_card_type).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_M_CARD_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.m_card_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.easywatch_ord_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EASYWATCH_ORD_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.easywatch_ord_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.easywatch_ord_id).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_EASYWATCH_ORD_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.easywatch_ord_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.normal_rebate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_NORMAL_REBATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.normal_rebate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.normal_rebate).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_NORMAL_REBATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.normal_rebate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.m_rebate_amount).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_REBATE_AMOUNT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.m_rebate_amount).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.m_rebate_amount).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_M_REBATE_AMOUNT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.m_rebate_amount).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.m_card_holder2).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_CARD_HOLDER2"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.m_card_holder2).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.m_card_holder2).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_M_CARD_HOLDER2"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.m_card_holder2).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_holder).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HOLDER"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_holder).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_holder).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HOLDER"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_holder).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.s_premium1).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_S_PREMIUM1"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.s_premium1).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.s_premium1).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_S_PREMIUM1"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.s_premium1).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.card_exp_month).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CARD_EXP_MONTH"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.card_exp_month).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.card_exp_month).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_CARD_EXP_MONTH"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.card_exp_month).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.ob_program_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_OB_PROGRAM_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.ob_program_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.ob_program_id).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_OB_PROGRAM_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.ob_program_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.sku).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SKU"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.sku).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.sku).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_SKU"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.sku).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.salesmancode).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SALESMANCODE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.salesmancode).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.salesmancode).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_SALESMANCODE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.salesmancode).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.go_wireless_package_code).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GO_WIRELESS_PACKAGE_CODE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.go_wireless_package_code).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.go_wireless_package_code).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_GO_WIRELESS_PACKAGE_CODE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.go_wireless_package_code).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.lob).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_LOB"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.lob).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.lob).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_LOB"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.lob).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.ref_salesmancode).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REF_SALESMANCODE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.ref_salesmancode).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.ref_salesmancode).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_REF_SALESMANCODE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.ref_salesmancode).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.third_party_hkid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_THIRD_PARTY_HKID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.third_party_hkid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.third_party_hkid).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_THIRD_PARTY_HKID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.third_party_hkid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_existing_pccw_customer).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_EXISTING_PCCW_CUSTOMER"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_existing_pccw_customer).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_existing_pccw_customer).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_UPGRADE_EXISTING_PCCW_CUSTOMER"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_existing_pccw_customer).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.d_address).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_D_ADDRESS"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.d_address).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.d_address).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_D_ADDRESS"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.d_address).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_registered_mobile_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_REGISTERED_MOBILE_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_registered_mobile_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_registered_mobile_no).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_UPGRADE_REGISTERED_MOBILE_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_registered_mobile_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_code3).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_CODE3"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.gift_code3).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.gift_code3).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_GIFT_CODE3"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.gift_code3).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.normal_rebate_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_NORMAL_REBATE_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.normal_rebate_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.normal_rebate_type).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_NORMAL_REBATE_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.normal_rebate_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_desc2).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_DESC2"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.gift_desc2).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.gift_desc2).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_GIFT_DESC2"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.gift_desc2).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_branch_code).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_BRANCH_CODE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_branch_code).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_branch_code).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_BRANCH_CODE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_branch_code).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.remarks).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REMARKS"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.remarks).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.remarks).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_REMARKS"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.remarks).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.accept).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACCEPT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.accept).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.accept).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_ACCEPT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.accept).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.delivery_exchange).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_DELIVERY_EXCHANGE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.delivery_exchange).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.delivery_exchange).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_DELIVERY_EXCHANGE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.delivery_exchange).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_code2).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_CODE2"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.gift_code2).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.gift_code2).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_GIFT_CODE2"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.gift_code2).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.prepayment_waive).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_PREPAYMENT_WAIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.prepayment_waive).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.prepayment_waive).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_PREPAYMENT_WAIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.prepayment_waive).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.existing_smart_phone_imei).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXISTING_SMART_PHONE_IMEI"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.existing_smart_phone_imei).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.existing_smart_phone_imei).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_EXISTING_SMART_PHONE_IMEI"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.existing_smart_phone_imei).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.cust_name).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CUST_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.cust_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.cust_name).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_CUST_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.cust_name).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_sponsorships_amount).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_SPONSORSHIPS_AMOUNT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_sponsorships_amount).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_sponsorships_amount).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_UPGRADE_SPONSORSHIPS_AMOUNT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_sponsorships_amount).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.bill_medium_waive).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_BILL_MEDIUM_WAIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.bill_medium_waive).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.bill_medium_waive).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_BILL_MEDIUM_WAIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.bill_medium_waive).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.delivery_exchange_location).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_DELIVERY_EXCHANGE_LOCATION"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.delivery_exchange_location).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.delivery_exchange_location).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_DELIVERY_EXCHANGE_LOCATION"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.delivery_exchange_location).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.hs_offer_type_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_HS_OFFER_TYPE_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.hs_offer_type_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.hs_offer_type_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDER_HS_OFFER_TYPE_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.hs_offer_type_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.extra_rebate_amount).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXTRA_REBATE_AMOUNT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.extra_rebate_amount).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.extra_rebate_amount).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_EXTRA_REBATE_AMOUNT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.extra_rebate_amount).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.rebate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REBATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.rebate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.rebate).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_REBATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.rebate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_type).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_UPGRADE_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.go_wireless).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GO_WIRELESS"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.go_wireless).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.go_wireless).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_GO_WIRELESS"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.go_wireless).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.extra_rebate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXTRA_REBATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.extra_rebate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.extra_rebate).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_EXTRA_REBATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.extra_rebate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.plan_eff).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_PLAN_EFF"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.plan_eff).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.plan_eff).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_PLAN_EFF"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.plan_eff).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.card_exp_year).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CARD_EXP_YEAR"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.card_exp_year).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.card_exp_year).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_CARD_EXP_YEAR"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.card_exp_year).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_existing_contract_sdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_EXISTING_CONTRACT_SDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_existing_contract_sdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_existing_contract_sdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_UPGRADE_EXISTING_CONTRACT_SDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_existing_contract_sdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_hkid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORD_PLACE_HKID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_hkid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_hkid).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_ORD_PLACE_HKID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_hkid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.register_address).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REGISTER_ADDRESS"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.register_address).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.register_address).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_REGISTER_ADDRESS"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.register_address).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.gender).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GENDER"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.gender).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.gender).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_GENDER"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.gender).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.lob_ac).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_LOB_AC"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.lob_ac).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.lob_ac).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_LOB_AC"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.lob_ac).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.sim_mrt_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SIM_MRT_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.sim_mrt_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.sim_mrt_no).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDER_SIM_MRT_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.sim_mrt_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.redemption_notice_option).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REDEMPTION_NOTICE_OPTION"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.redemption_notice_option).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.redemption_notice_option).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_REDEMPTION_NOTICE_OPTION"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.redemption_notice_option).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.delivery_collection_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_DELIVERY_COLLECTION_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.delivery_collection_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.delivery_collection_type).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_DELIVERY_COLLECTION_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.delivery_collection_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.action_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACTION_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.action_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.action_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_ACTION_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.action_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.third_party_id_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_THIRD_PARTY_ID_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.third_party_id_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.third_party_id_type).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_THIRD_PARTY_ID_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.third_party_id_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.org_ftg).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORG_FTG"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.org_ftg).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.org_ftg).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_ORG_FTG"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.org_ftg).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_service_tenure).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_SERVICE_TENURE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_service_tenure).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_service_tenure).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_UPGRADE_SERVICE_TENURE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_service_tenure).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_payment_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_PAYMENT_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_payment_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_payment_type).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_MONTHLY_PAYMENT_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_payment_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.contact_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CONTACT_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.contact_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.contact_no).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_CONTACT_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.contact_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.org_mrt).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORG_MRT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.org_mrt).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.org_mrt).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDER_ORG_MRT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.org_mrt).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.sim_item_name).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SIM_ITEM_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.sim_item_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.sim_item_name).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_SIM_ITEM_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.sim_item_name).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.pay_method).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_PAY_METHOD"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.pay_method).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.pay_method).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_PAY_METHOD"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.pay_method).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.hs_model).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_HS_MODEL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.hs_model).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.hs_model).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_HS_MODEL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.hs_model).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_code).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_CODE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.gift_code).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.gift_code).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_GIFT_CODE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.gift_code).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_hkid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HKID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_hkid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_hkid).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HKID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_hkid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.extra_offer).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXTRA_OFFER"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.extra_offer).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.extra_offer).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_EXTRA_OFFER"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.extra_offer).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_no).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.first_month_license_fee).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_FIRST_MONTH_LICENSE_FEE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.first_month_license_fee).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.first_month_license_fee).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_FIRST_MONTH_LICENSE_FEE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.first_month_license_fee).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.retrieve_cnt).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_RETRIEVE_CNT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.retrieve_cnt).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.retrieve_cnt).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDER_RETRIEVE_CNT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.retrieve_cnt).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.ddate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.ddate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.s_premium2).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_S_PREMIUM2"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.s_premium2).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.s_premium2).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_S_PREMIUM2"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.s_premium2).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_id_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_ID_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_id_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_id_type).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_ID_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_id_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.card_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CARD_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.card_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.card_type).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_CARD_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.card_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.next_bill).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_NEXT_BILL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.next_bill).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.next_bill).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_NEXT_BILL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.next_bill).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.pcd_paid_go_wireless).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_PCD_PAID_GO_WIRELESS"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.pcd_paid_go_wireless).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.pcd_paid_go_wireless).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_PCD_PAID_GO_WIRELESS"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.pcd_paid_go_wireless).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_rebate_calculation).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_REBATE_CALCULATION"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_rebate_calculation).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_rebate_calculation).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_UPGRADE_REBATE_CALCULATION"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_rebate_calculation).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.ext_place_tel).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXT_PLACE_TEL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.ext_place_tel).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.ext_place_tel).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_EXT_PLACE_TEL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.ext_place_tel).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.m_3rd_hkid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_3RD_HKID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.m_3rd_hkid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.m_3rd_hkid).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_M_3RD_HKID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.m_3rd_hkid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.retention_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_RETENTION_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.retention_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.retention_type).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_RETENTION_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.retention_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.cooling_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_COOLING_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.cooling_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.cooling_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_COOLING_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.cooling_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.aig_gift).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_AIG_GIFT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.aig_gift).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.aig_gift).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_AIG_GIFT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.aig_gift).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.cust_staff_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CUST_STAFF_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.cust_staff_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.cust_staff_no).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_CUST_STAFF_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.cust_staff_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.order_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORDER_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.order_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.order_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDER_ORDER_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.order_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.family_name).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_FAMILY_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.family_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.family_name).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_FAMILY_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.family_name).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.status_by_cs_admin).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_STATUS_BY_CS_ADMIN"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.status_by_cs_admin).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.status_by_cs_admin).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_STATUS_BY_CS_ADMIN"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.status_by_cs_admin).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.given_name).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIVEN_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.given_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.given_name).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_GIVEN_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.given_name).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.vip_case).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_VIP_CASE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.vip_case).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.vip_case).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_VIP_CASE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.vip_case).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.org_fee).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORG_FEE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.org_fee).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.org_fee).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_ORG_FEE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.org_fee).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.s_premium3).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_S_PREMIUM3"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.s_premium3).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.s_premium3).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_S_PREMIUM3"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.s_premium3).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.log_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_LOG_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.log_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.log_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_LOG_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.log_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.extn).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXTN"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.extn).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.extn).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_EXTN"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.extn).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.d_time).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_D_TIME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.d_time).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.d_time).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_D_TIME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.d_time).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.bank_name).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_BANK_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.bank_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.bank_name).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_BANK_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.bank_name).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.delivery_exchange_option).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_DELIVERY_EXCHANGE_OPTION"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.delivery_exchange_option).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.delivery_exchange_option).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_DELIVERY_EXCHANGE_OPTION"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.delivery_exchange_option).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_service_account_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_SERVICE_ACCOUNT_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_service_account_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_service_account_no).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_UPGRADE_SERVICE_ACCOUNT_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_service_account_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.old_ord_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_OLD_ORD_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.old_ord_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.old_ord_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDER_OLD_ORD_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.old_ord_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.m_card_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_CARD_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.m_card_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.m_card_no).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_M_CARD_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.m_card_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.existing_contract_end_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXISTING_CONTRACT_END_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.existing_contract_end_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.existing_contract_end_date).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_EXISTING_CONTRACT_END_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.existing_contract_end_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.con_eff_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CON_EFF_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.con_eff_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.con_eff_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_CON_EFF_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.con_eff_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.m_3rd_hkid2).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_3RD_HKID2"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.m_3rd_hkid2).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.m_3rd_hkid2).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_M_3RD_HKID2"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.m_3rd_hkid2).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.amount).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_AMOUNT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.amount).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.amount).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_AMOUNT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.amount).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.m_3rd_id_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_3RD_ID_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.m_3rd_id_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.m_3rd_id_type).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_M_3RD_ID_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.m_3rd_id_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.id_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ID_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.id_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.id_type).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_ID_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.id_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.rate_plan).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_RATE_PLAN"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.rate_plan).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.rate_plan).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_RATE_PLAN"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.rate_plan).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.channel).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CHANNEL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.channel).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.channel).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_CHANNEL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.channel).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.action_eff_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACTION_EFF_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.action_eff_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.action_eff_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_ACTION_EFF_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.action_eff_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.issue_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ISSUE_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.issue_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.issue_type).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_ISSUE_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.issue_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.free_mon).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_FREE_MON"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.free_mon).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.free_mon).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_FREE_MON"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.free_mon).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.plan_eff_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_PLAN_EFF_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.plan_eff_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.plan_eff_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_PLAN_EFF_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.plan_eff_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.teamcode).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_TEAMCODE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.teamcode).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.teamcode).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_TEAMCODE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.teamcode).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.bill_medium).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_BILL_MEDIUM"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.bill_medium).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.bill_medium).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_BILL_MEDIUM"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.bill_medium).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.edf_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EDF_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.edf_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.edf_no).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_EDF_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.edf_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_by).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORD_PLACE_BY"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_by).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_by).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_ORD_PLACE_BY"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_by).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.cancel_renew).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CANCEL_RENEW"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.cancel_renew).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.cancel_renew).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_CANCEL_RENEW"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.cancel_renew).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.preferred_languages).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_PREFERRED_LANGUAGES"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.preferred_languages).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.preferred_languages).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_PREFERRED_LANGUAGES"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.preferred_languages).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.hkid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_HKID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.hkid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.hkid).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_HKID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.hkid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.card_holder).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CARD_HOLDER"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.card_holder).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.card_holder).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_CARD_HOLDER"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.card_holder).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.ac_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_AC_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.ac_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.ac_no).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_AC_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.ac_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.bill_cut_num).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_BILL_CUT_NUM"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.bill_cut_num).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.bill_cut_num).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDER_BILL_CUT_NUM"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.bill_cut_num).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.premium).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_PREMIUM"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.premium).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.premium).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_PREMIUM"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.premium).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.del_remark).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_DEL_REMARK"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.del_remark).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.del_remark).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_DEL_REMARK"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.del_remark).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.gift_imei2).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_IMEI2"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.gift_imei2).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.gift_imei2).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_GIFT_IMEI2"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.gift_imei2).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.reasons).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REASONS"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.reasons).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.reasons).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_REASONS"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.reasons).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.language).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_LANGUAGE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.language).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.language).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_LANGUAGE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.language).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.rebate_amount).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REBATE_AMOUNT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.rebate_amount).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.rebate_amount).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_REBATE_AMOUNT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.rebate_amount).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_id_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORD_PLACE_ID_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_id_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_id_type).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_ORD_PLACE_ID_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_id_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.m_3rd_contact_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_3RD_CONTACT_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.m_3rd_contact_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.m_3rd_contact_no).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_M_3RD_CONTACT_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.m_3rd_contact_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.staff_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_STAFF_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.staff_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.staff_no).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_STAFF_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.staff_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.sp_d_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SP_D_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.sp_d_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.sp_d_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_SP_D_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.sp_d_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.bundle_name).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_BUNDLE_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.bundle_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.bundle_name).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_BUNDLE_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.bundle_name).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.accessory_waive).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACCESSORY_WAIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.accessory_waive).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.accessory_waive).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_ACCESSORY_WAIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.accessory_waive).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.sim_item_code).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SIM_ITEM_CODE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.sim_item_code).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.sim_item_code).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_SIM_ITEM_CODE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.sim_item_code).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.cust_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CUST_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.cust_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.cust_type).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_CUST_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.cust_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrder.Para.card_ref_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CARD_REF_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrder.Para.card_ref_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.card_ref_no).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDER_CARD_REF_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrder.Para.card_ref_no).AliasName].ToString()] =string.Empty;
                        }
                    }
                    _oData.Close();
                    _oData.Dispose();
                }
                catch {  }
                finally
                {
                    _oConn.Close();
                    _oCmd.Dispose();
                    _oConn.Dispose();
                }
                return _oRw;
            }
        }
        #endregion
        
        
        #region SetDataSetRow
        
        
        // ******************************
        // *  Handler for Convert To DataSet Row
        // ******************************
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,MobileRetentionOrder x_oMobileRetentionOrderRow)
        {
            return SetByDataSetRowProc(x_iROW, MobileRetentionOrder.Para.TableName(), x_oDataSet,x_oMobileRetentionOrderRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileRetentionOrder x_oMobileRetentionOrderRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oMobileRetentionOrderRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileRetentionOrder x_oMobileRetentionOrderRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                MobileRetentionOrderInfo _oTableSet=MobileRetentionOrderInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.gift_imei).AliasName))
                    x_oMobileRetentionOrderRow.gift_imei = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.gift_imei).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.s_premium4).AliasName))
                    x_oMobileRetentionOrderRow.s_premium4 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.s_premium4).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.gift_desc4).AliasName))
                    x_oMobileRetentionOrderRow.gift_desc4 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.gift_desc4).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.accessory_desc).AliasName))
                    x_oMobileRetentionOrderRow.accessory_desc = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.accessory_desc).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.action_required).AliasName))
                    x_oMobileRetentionOrderRow.action_required = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.action_required).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.vas_eff_date).AliasName))
                    x_oMobileRetentionOrderRow.vas_eff_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.vas_eff_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_bank_code).AliasName))
                    x_oMobileRetentionOrderRow.monthly_bank_account_bank_code = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_bank_code).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.special_handling_dummy_code).AliasName))
                    x_oMobileRetentionOrderRow.special_handling_dummy_code = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.special_handling_dummy_code).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.m_card_exp_year).AliasName))
                    x_oMobileRetentionOrderRow.m_card_exp_year = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.m_card_exp_year).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.remarks2PY).AliasName))
                    x_oMobileRetentionOrderRow.remarks2PY = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.remarks2PY).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.trade_field).AliasName))
                    x_oMobileRetentionOrderRow.trade_field = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.trade_field).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_tel).AliasName))
                    x_oMobileRetentionOrderRow.ord_place_tel = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_tel).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_id_type).AliasName))
                    x_oMobileRetentionOrderRow.ord_place_id_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_id_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.cooling_offer).AliasName))
                    x_oMobileRetentionOrderRow.cooling_offer = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.cooling_offer).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_handset_offer_rebate_schedule).AliasName))
                    x_oMobileRetentionOrderRow.upgrade_handset_offer_rebate_schedule = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_handset_offer_rebate_schedule).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.change_payment_type).AliasName))
                    x_oMobileRetentionOrderRow.change_payment_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.change_payment_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.date_of_birth).AliasName))
                    x_oMobileRetentionOrderRow.date_of_birth = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.date_of_birth).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.contact_person).AliasName))
                    x_oMobileRetentionOrderRow.contact_person = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.contact_person).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.extra_d_charge).AliasName))
                    x_oMobileRetentionOrderRow.extra_d_charge = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.extra_d_charge).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.tl_name).AliasName))
                    x_oMobileRetentionOrderRow.tl_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.tl_name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.fast_start).AliasName))
                    x_oMobileRetentionOrderRow.fast_start = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.fast_start).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.sp_ref_no).AliasName))
                    x_oMobileRetentionOrderRow.sp_ref_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.sp_ref_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.edate).AliasName))
                    x_oMobileRetentionOrderRow.edate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.edate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.exist_cust_plan).AliasName))
                    x_oMobileRetentionOrderRow.exist_cust_plan = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.exist_cust_plan).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_rel).AliasName))
                    x_oMobileRetentionOrderRow.ord_place_rel = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_rel).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.mrt_no).AliasName))
                    x_oMobileRetentionOrderRow.mrt_no = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.mrt_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.imei_no).AliasName))
                    x_oMobileRetentionOrderRow.imei_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.imei_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.existing_smart_phone_model).AliasName))
                    x_oMobileRetentionOrderRow.existing_smart_phone_model = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.existing_smart_phone_model).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.gift_code3).AliasName))
                    x_oMobileRetentionOrderRow.gift_code3 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.gift_code3).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.bank_code).AliasName))
                    x_oMobileRetentionOrderRow.bank_code = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.bank_code).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.pos_ref_no).AliasName))
                    x_oMobileRetentionOrderRow.pos_ref_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.pos_ref_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.bill_cut_date).AliasName))
                    x_oMobileRetentionOrderRow.bill_cut_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.bill_cut_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.gift_imei3).AliasName))
                    x_oMobileRetentionOrderRow.gift_imei3 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.gift_imei3).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.exist_plan).AliasName))
                    x_oMobileRetentionOrderRow.exist_plan = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.exist_plan).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.waive).AliasName))
                    x_oMobileRetentionOrderRow.waive = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.waive).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.program).AliasName))
                    x_oMobileRetentionOrderRow.program = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.program).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.first_month_fee).AliasName))
                    x_oMobileRetentionOrderRow.first_month_fee = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.first_month_fee).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.r_offer).AliasName))
                    x_oMobileRetentionOrderRow.r_offer = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.r_offer).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.cid).AliasName))
                    x_oMobileRetentionOrderRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.did).AliasName))
                    x_oMobileRetentionOrderRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.did).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.ftg_tenure).AliasName))
                    x_oMobileRetentionOrderRow.ftg_tenure = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.ftg_tenure).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.con_per).AliasName))
                    x_oMobileRetentionOrderRow.con_per = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.con_per).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.gift_code4).AliasName))
                    x_oMobileRetentionOrderRow.gift_code4 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.gift_code4).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.easywatch_type).AliasName))
                    x_oMobileRetentionOrderRow.easywatch_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.easywatch_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.sms_mrt).AliasName))
                    x_oMobileRetentionOrderRow.sms_mrt = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.sms_mrt).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.monthly_payment_method).AliasName))
                    x_oMobileRetentionOrderRow.monthly_payment_method = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.monthly_payment_method).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.remarks2EDF).AliasName))
                    x_oMobileRetentionOrderRow.remarks2EDF = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.remarks2EDF).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.gift_desc3).AliasName))
                    x_oMobileRetentionOrderRow.gift_desc3 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.gift_desc3).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.gift_imei4).AliasName))
                    x_oMobileRetentionOrderRow.gift_imei4 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.gift_imei4).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.old_ord_id).AliasName))
                    x_oMobileRetentionOrderRow.old_ord_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.old_ord_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_hkid2).AliasName))
                    x_oMobileRetentionOrderRow.monthly_bank_account_hkid2 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_hkid2).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.d_date).AliasName))
                    x_oMobileRetentionOrderRow.d_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.d_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.gift_desc).AliasName))
                    x_oMobileRetentionOrderRow.gift_desc = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.gift_desc).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.salesmancode).AliasName))
                    x_oMobileRetentionOrderRow.salesmancode = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.salesmancode).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.pool).AliasName))
                    x_oMobileRetentionOrderRow.pool = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.pool).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.cn_mrt_no).AliasName))
                    x_oMobileRetentionOrderRow.cn_mrt_no = (global::System.Nullable<long>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.cn_mrt_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.accessory_imei).AliasName))
                    x_oMobileRetentionOrderRow.accessory_imei = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.accessory_imei).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.third_party_credit_card).AliasName))
                    x_oMobileRetentionOrderRow.third_party_credit_card = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.third_party_credit_card).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.card_ref_no).AliasName))
                    x_oMobileRetentionOrderRow.card_ref_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.card_ref_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.special_approval).AliasName))
                    x_oMobileRetentionOrderRow.special_approval = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.special_approval).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_existing_contract_edate).AliasName))
                    x_oMobileRetentionOrderRow.upgrade_existing_contract_edate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_existing_contract_edate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.accessory_code).AliasName))
                    x_oMobileRetentionOrderRow.accessory_code = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.accessory_code).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.bill_medium).AliasName))
                    x_oMobileRetentionOrderRow.bill_medium = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.bill_medium).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.s_premium).AliasName))
                    x_oMobileRetentionOrderRow.s_premium = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.s_premium).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.ref_staff_no).AliasName))
                    x_oMobileRetentionOrderRow.ref_staff_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.ref_staff_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.accessory_price).AliasName))
                    x_oMobileRetentionOrderRow.accessory_price = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.accessory_price).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.m_card_exp_month).AliasName))
                    x_oMobileRetentionOrderRow.m_card_exp_month = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.m_card_exp_month).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.installment_period).AliasName))
                    x_oMobileRetentionOrderRow.installment_period = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.installment_period).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.m_card_type).AliasName))
                    x_oMobileRetentionOrderRow.m_card_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.m_card_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.easywatch_ord_id).AliasName))
                    x_oMobileRetentionOrderRow.easywatch_ord_id = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.easywatch_ord_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.normal_rebate).AliasName))
                    x_oMobileRetentionOrderRow.normal_rebate = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.normal_rebate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.m_rebate_amount).AliasName))
                    x_oMobileRetentionOrderRow.m_rebate_amount = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.m_rebate_amount).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.m_card_holder2).AliasName))
                    x_oMobileRetentionOrderRow.m_card_holder2 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.m_card_holder2).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.bill_medium_email).AliasName))
                    x_oMobileRetentionOrderRow.bill_medium_email = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.bill_medium_email).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.active).AliasName))
                    x_oMobileRetentionOrderRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.s_premium1).AliasName))
                    x_oMobileRetentionOrderRow.s_premium1 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.s_premium1).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.card_exp_month).AliasName))
                    x_oMobileRetentionOrderRow.card_exp_month = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.card_exp_month).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.ob_program_id).AliasName))
                    x_oMobileRetentionOrderRow.ob_program_id = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.ob_program_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.sku).AliasName))
                    x_oMobileRetentionOrderRow.sku = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.sku).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.ref_salesmancode).AliasName))
                    x_oMobileRetentionOrderRow.ref_salesmancode = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.ref_salesmancode).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.go_wireless_package_code).AliasName))
                    x_oMobileRetentionOrderRow.go_wireless_package_code = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.go_wireless_package_code).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.third_party_hkid).AliasName))
                    x_oMobileRetentionOrderRow.third_party_hkid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.third_party_hkid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_existing_pccw_customer).AliasName))
                    x_oMobileRetentionOrderRow.upgrade_existing_pccw_customer = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_existing_pccw_customer).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.d_address).AliasName))
                    x_oMobileRetentionOrderRow.d_address = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.d_address).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_registered_mobile_no).AliasName))
                    x_oMobileRetentionOrderRow.upgrade_registered_mobile_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_registered_mobile_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_existing_customer_type).AliasName))
                    x_oMobileRetentionOrderRow.upgrade_existing_customer_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_existing_customer_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.normal_rebate_type).AliasName))
                    x_oMobileRetentionOrderRow.normal_rebate_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.normal_rebate_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.gift_desc2).AliasName))
                    x_oMobileRetentionOrderRow.gift_desc2 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.gift_desc2).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_branch_code).AliasName))
                    x_oMobileRetentionOrderRow.monthly_bank_account_branch_code = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_branch_code).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.remarks).AliasName))
                    x_oMobileRetentionOrderRow.remarks = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.remarks).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.accept).AliasName))
                    x_oMobileRetentionOrderRow.accept = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.accept).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.delivery_exchange).AliasName))
                    x_oMobileRetentionOrderRow.delivery_exchange = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.delivery_exchange).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.gift_code2).AliasName))
                    x_oMobileRetentionOrderRow.gift_code2 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.gift_code2).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.prepayment_waive).AliasName))
                    x_oMobileRetentionOrderRow.prepayment_waive = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.prepayment_waive).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.existing_smart_phone_imei).AliasName))
                    x_oMobileRetentionOrderRow.existing_smart_phone_imei = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.existing_smart_phone_imei).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.cust_name).AliasName))
                    x_oMobileRetentionOrderRow.cust_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.cust_name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.cust_type).AliasName))
                    x_oMobileRetentionOrderRow.cust_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.cust_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_sponsorships_amount).AliasName))
                    x_oMobileRetentionOrderRow.upgrade_sponsorships_amount = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_sponsorships_amount).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.bill_medium_waive).AliasName))
                    x_oMobileRetentionOrderRow.bill_medium_waive = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.bill_medium_waive).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.delivery_exchange_location).AliasName))
                    x_oMobileRetentionOrderRow.delivery_exchange_location = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.delivery_exchange_location).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.hs_offer_type_id).AliasName))
                    x_oMobileRetentionOrderRow.hs_offer_type_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.hs_offer_type_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.org_fee).AliasName))
                    x_oMobileRetentionOrderRow.org_fee = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.org_fee).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.rebate).AliasName))
                    x_oMobileRetentionOrderRow.rebate = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.rebate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_type).AliasName))
                    x_oMobileRetentionOrderRow.upgrade_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.go_wireless).AliasName))
                    x_oMobileRetentionOrderRow.go_wireless = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.go_wireless).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.extra_rebate).AliasName))
                    x_oMobileRetentionOrderRow.extra_rebate = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.extra_rebate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.plan_eff).AliasName))
                    x_oMobileRetentionOrderRow.plan_eff = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.plan_eff).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.extra_rebate_amount).AliasName))
                    x_oMobileRetentionOrderRow.extra_rebate_amount = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.extra_rebate_amount).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.card_exp_year).AliasName))
                    x_oMobileRetentionOrderRow.card_exp_year = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.card_exp_year).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_existing_contract_sdate).AliasName))
                    x_oMobileRetentionOrderRow.upgrade_existing_contract_sdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_existing_contract_sdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_hkid).AliasName))
                    x_oMobileRetentionOrderRow.ord_place_hkid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_hkid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.register_address).AliasName))
                    x_oMobileRetentionOrderRow.register_address = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.register_address).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.gender).AliasName))
                    x_oMobileRetentionOrderRow.gender = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.gender).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.lob_ac).AliasName))
                    x_oMobileRetentionOrderRow.lob_ac = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.lob_ac).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.sim_mrt_no).AliasName))
                    x_oMobileRetentionOrderRow.sim_mrt_no = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.sim_mrt_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.redemption_notice_option).AliasName))
                    x_oMobileRetentionOrderRow.redemption_notice_option = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.redemption_notice_option).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.delivery_collection_type).AliasName))
                    x_oMobileRetentionOrderRow.delivery_collection_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.delivery_collection_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.action_date).AliasName))
                    x_oMobileRetentionOrderRow.action_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.action_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.third_party_id_type).AliasName))
                    x_oMobileRetentionOrderRow.third_party_id_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.third_party_id_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.org_ftg).AliasName))
                    x_oMobileRetentionOrderRow.org_ftg = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.org_ftg).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_service_tenure).AliasName))
                    x_oMobileRetentionOrderRow.upgrade_service_tenure = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_service_tenure).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.monthly_payment_type).AliasName))
                    x_oMobileRetentionOrderRow.monthly_payment_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.monthly_payment_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.contact_no).AliasName))
                    x_oMobileRetentionOrderRow.contact_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.contact_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.org_mrt).AliasName))
                    x_oMobileRetentionOrderRow.org_mrt = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.org_mrt).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.sim_item_name).AliasName))
                    x_oMobileRetentionOrderRow.sim_item_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.sim_item_name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.pay_method).AliasName))
                    x_oMobileRetentionOrderRow.pay_method = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.pay_method).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.hs_model).AliasName))
                    x_oMobileRetentionOrderRow.hs_model = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.hs_model).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.gift_code).AliasName))
                    x_oMobileRetentionOrderRow.gift_code = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.gift_code).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_hkid).AliasName))
                    x_oMobileRetentionOrderRow.monthly_bank_account_hkid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_hkid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.extra_offer).AliasName))
                    x_oMobileRetentionOrderRow.extra_offer = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.extra_offer).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_no).AliasName))
                    x_oMobileRetentionOrderRow.monthly_bank_account_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.first_month_license_fee).AliasName))
                    x_oMobileRetentionOrderRow.first_month_license_fee = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.first_month_license_fee).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.retrieve_cnt).AliasName))
                    x_oMobileRetentionOrderRow.retrieve_cnt = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.retrieve_cnt).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.ddate).AliasName))
                    x_oMobileRetentionOrderRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.ddate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.s_premium2).AliasName))
                    x_oMobileRetentionOrderRow.s_premium2 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.s_premium2).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_id_type).AliasName))
                    x_oMobileRetentionOrderRow.monthly_bank_account_id_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_id_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.card_type).AliasName))
                    x_oMobileRetentionOrderRow.card_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.card_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.next_bill).AliasName))
                    x_oMobileRetentionOrderRow.next_bill = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.next_bill).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.pcd_paid_go_wireless).AliasName))
                    x_oMobileRetentionOrderRow.pcd_paid_go_wireless = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.pcd_paid_go_wireless).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_rebate_calculation).AliasName))
                    x_oMobileRetentionOrderRow.upgrade_rebate_calculation = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_rebate_calculation).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.ext_place_tel).AliasName))
                    x_oMobileRetentionOrderRow.ext_place_tel = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.ext_place_tel).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.m_3rd_hkid).AliasName))
                    x_oMobileRetentionOrderRow.m_3rd_hkid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.m_3rd_hkid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.retention_type).AliasName))
                    x_oMobileRetentionOrderRow.retention_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.retention_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.cooling_date).AliasName))
                    x_oMobileRetentionOrderRow.cooling_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.cooling_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.aig_gift).AliasName))
                    x_oMobileRetentionOrderRow.aig_gift = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.aig_gift).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.cust_staff_no).AliasName))
                    x_oMobileRetentionOrderRow.cust_staff_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.cust_staff_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.order_id).AliasName))
                    x_oMobileRetentionOrderRow.order_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.order_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.family_name).AliasName))
                    x_oMobileRetentionOrderRow.family_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.family_name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.cdate).AliasName))
                    x_oMobileRetentionOrderRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.status_by_cs_admin).AliasName))
                    x_oMobileRetentionOrderRow.status_by_cs_admin = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.status_by_cs_admin).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.sim_item_number).AliasName))
                    x_oMobileRetentionOrderRow.sim_item_number = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.sim_item_number).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.vip_case).AliasName))
                    x_oMobileRetentionOrderRow.vip_case = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.vip_case).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.given_name).AliasName))
                    x_oMobileRetentionOrderRow.given_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.given_name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.log_date).AliasName))
                    x_oMobileRetentionOrderRow.log_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.log_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.extn).AliasName))
                    x_oMobileRetentionOrderRow.extn = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.extn).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.d_time).AliasName))
                    x_oMobileRetentionOrderRow.d_time = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.d_time).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.bank_name).AliasName))
                    x_oMobileRetentionOrderRow.bank_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.bank_name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.delivery_exchange_option).AliasName))
                    x_oMobileRetentionOrderRow.delivery_exchange_option = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.delivery_exchange_option).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_service_account_no).AliasName))
                    x_oMobileRetentionOrderRow.upgrade_service_account_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.upgrade_service_account_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.action_of_rate_plan_effective).AliasName))
                    x_oMobileRetentionOrderRow.action_of_rate_plan_effective = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.action_of_rate_plan_effective).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.m_card_no).AliasName))
                    x_oMobileRetentionOrderRow.m_card_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.m_card_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.existing_contract_end_date).AliasName))
                    x_oMobileRetentionOrderRow.existing_contract_end_date = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.existing_contract_end_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.con_eff_date).AliasName))
                    x_oMobileRetentionOrderRow.con_eff_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.con_eff_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.m_3rd_hkid2).AliasName))
                    x_oMobileRetentionOrderRow.m_3rd_hkid2 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.m_3rd_hkid2).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.amount).AliasName))
                    x_oMobileRetentionOrderRow.amount = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.amount).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.id_type).AliasName))
                    x_oMobileRetentionOrderRow.id_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.id_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.rate_plan).AliasName))
                    x_oMobileRetentionOrderRow.rate_plan = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.rate_plan).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.channel).AliasName))
                    x_oMobileRetentionOrderRow.channel = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.channel).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.action_eff_date).AliasName))
                    x_oMobileRetentionOrderRow.action_eff_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.action_eff_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.issue_type).AliasName))
                    x_oMobileRetentionOrderRow.issue_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.issue_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.free_mon).AliasName))
                    x_oMobileRetentionOrderRow.free_mon = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.free_mon).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.plan_eff_date).AliasName))
                    x_oMobileRetentionOrderRow.plan_eff_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.plan_eff_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.del_remark).AliasName))
                    x_oMobileRetentionOrderRow.del_remark = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.del_remark).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.teamcode).AliasName))
                    x_oMobileRetentionOrderRow.teamcode = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.teamcode).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.staff_name).AliasName))
                    x_oMobileRetentionOrderRow.staff_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.staff_name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.edf_no).AliasName))
                    x_oMobileRetentionOrderRow.edf_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.edf_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_by).AliasName))
                    x_oMobileRetentionOrderRow.ord_place_by = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.ord_place_by).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.cancel_renew).AliasName))
                    x_oMobileRetentionOrderRow.cancel_renew = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.cancel_renew).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.preferred_languages).AliasName))
                    x_oMobileRetentionOrderRow.preferred_languages = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.preferred_languages).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.hkid).AliasName))
                    x_oMobileRetentionOrderRow.hkid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.hkid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.card_no).AliasName))
                    x_oMobileRetentionOrderRow.card_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.card_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.ac_no).AliasName))
                    x_oMobileRetentionOrderRow.ac_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.ac_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.bill_cut_num).AliasName))
                    x_oMobileRetentionOrderRow.bill_cut_num = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.bill_cut_num).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.premium).AliasName))
                    x_oMobileRetentionOrderRow.premium = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.premium).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.m_3rd_id_type).AliasName))
                    x_oMobileRetentionOrderRow.m_3rd_id_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.m_3rd_id_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.gift_imei2).AliasName))
                    x_oMobileRetentionOrderRow.gift_imei2 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.gift_imei2).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.reasons).AliasName))
                    x_oMobileRetentionOrderRow.reasons = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.reasons).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.language).AliasName))
                    x_oMobileRetentionOrderRow.language = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.language).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.rebate_amount).AliasName))
                    x_oMobileRetentionOrderRow.rebate_amount = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.rebate_amount).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.lob).AliasName))
                    x_oMobileRetentionOrderRow.lob = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.lob).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.m_3rd_contact_no).AliasName))
                    x_oMobileRetentionOrderRow.m_3rd_contact_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.m_3rd_contact_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.staff_no).AliasName))
                    x_oMobileRetentionOrderRow.staff_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.staff_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.s_premium3).AliasName))
                    x_oMobileRetentionOrderRow.s_premium3 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.s_premium3).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.sp_d_date).AliasName))
                    x_oMobileRetentionOrderRow.sp_d_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.sp_d_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.bundle_name).AliasName))
                    x_oMobileRetentionOrderRow.bundle_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.bundle_name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.accessory_waive).AliasName))
                    x_oMobileRetentionOrderRow.accessory_waive = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.accessory_waive).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.sim_item_code).AliasName))
                    x_oMobileRetentionOrderRow.sim_item_code = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.sim_item_code).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_holder).AliasName))
                    x_oMobileRetentionOrderRow.monthly_bank_account_holder = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.monthly_bank_account_holder).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrder.Para.card_holder).AliasName))
                    x_oMobileRetentionOrderRow.card_holder = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrder.Para.card_holder).AliasName];
                return true;
            }
            return false;
        }
        
        #endregion SetByDataSet
        
        
        #region Count
        
        // ******************************
        // *  Handler for Data Counting
        // ******************************
        
        public static int GetCount(MSSQLConnect x_oDB){
            return MobileRetentionOrderRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static MobileRetentionOrderEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return MobileRetentionOrderRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static MobileRetentionOrderEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return MobileRetentionOrderRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileRetentionOrderRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileRetentionOrderRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return MobileRetentionOrderRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sGift_imei,string x_sS_premium4,string x_sGift_desc4,string x_sAccessory_desc,string x_sAction_required,global::System.Nullable<DateTime> x_dVas_eff_date,string x_sMonthly_bank_account_bank_code,string x_sSpecial_handling_dummy_code,string x_sM_card_exp_year,string x_sRemarks2PY,string x_sTrade_field,string x_sOrd_place_tel,string x_sOrd_place_id_type,string x_sCooling_offer,string x_sUpgrade_handset_offer_rebate_schedule,string x_sChange_payment_type,global::System.Nullable<DateTime> x_dDate_of_birth,string x_sContact_person,string x_sExtra_d_charge,string x_sTl_name,global::System.Nullable<bool> x_bFast_start,string x_sSp_ref_no,global::System.Nullable<DateTime> x_dEdate,string x_sExist_cust_plan,string x_sOrd_place_rel,global::System.Nullable<int> x_iMrt_no,string x_sImei_no,string x_sExisting_smart_phone_model,string x_sGift_code3,string x_sBank_code,string x_sPos_ref_no,global::System.Nullable<DateTime> x_dBill_cut_date,string x_sGift_imei3,string x_sExist_plan,global::System.Nullable<bool> x_bWaive,string x_sProgram,string x_sFirst_month_fee,string x_sR_offer,string x_sCid,string x_sDid,string x_sFtg_tenure,string x_sCon_per,string x_sGift_code4,string x_sEasywatch_type,string x_sSms_mrt,string x_sMonthly_payment_method,string x_sRemarks2EDF,string x_sGift_desc3,string x_sGift_imei4,global::System.Nullable<int> x_iOld_ord_id,string x_sMonthly_bank_account_hkid2,global::System.Nullable<DateTime> x_dD_date,string x_sGift_desc,string x_sSalesmancode,string x_sPool,global::System.Nullable<long> x_lCn_mrt_no,string x_sAccessory_imei,string x_sThird_party_credit_card,string x_sCard_ref_no,string x_sSpecial_approval,global::System.Nullable<DateTime> x_dUpgrade_existing_contract_edate,string x_sAccessory_code,string x_sBill_medium,string x_sS_premium,string x_sRef_staff_no,string x_sAccessory_price,string x_sM_card_exp_month,string x_sInstallment_period,string x_sM_card_type,string x_sEasywatch_ord_id,global::System.Nullable<bool> x_bNormal_rebate,string x_sM_rebate_amount,string x_sM_card_holder2,string x_sBill_medium_email,global::System.Nullable<bool> x_bActive,string x_sS_premium1,string x_sCard_exp_month,string x_sOb_program_id,string x_sSku,string x_sRef_salesmancode,string x_sGo_wireless_package_code,string x_sThird_party_hkid,string x_sUpgrade_existing_pccw_customer,string x_sD_address,string x_sUpgrade_registered_mobile_no,string x_sUpgrade_existing_customer_type,string x_sNormal_rebate_type,string x_sGift_desc2,string x_sMonthly_bank_account_branch_code,string x_sRemarks,string x_sAccept,string x_sDelivery_exchange,string x_sGift_code2,global::System.Nullable<bool> x_bPrepayment_waive,string x_sExisting_smart_phone_imei,string x_sCust_name,string x_sCust_type,string x_sUpgrade_sponsorships_amount,global::System.Nullable<bool> x_bBill_medium_waive,string x_sDelivery_exchange_location,global::System.Nullable<int> x_iHs_offer_type_id,string x_sOrg_fee,string x_sRebate,string x_sUpgrade_type,string x_sGo_wireless,string x_sExtra_rebate,string x_sPlan_eff,string x_sExtra_rebate_amount,string x_sCard_exp_year,global::System.Nullable<DateTime> x_dUpgrade_existing_contract_sdate,string x_sOrd_place_hkid,string x_sRegister_address,string x_sGender,string x_sLob_ac,global::System.Nullable<int> x_iSim_mrt_no,string x_sRedemption_notice_option,string x_sDelivery_collection_type,global::System.Nullable<DateTime> x_dAction_date,string x_sThird_party_id_type,string x_sOrg_ftg,string x_sUpgrade_service_tenure,string x_sMonthly_payment_type,string x_sContact_no,global::System.Nullable<int> x_iOrg_mrt,string x_sSim_item_name,string x_sPay_method,string x_sHs_model,string x_sGift_code,string x_sMonthly_bank_account_hkid,string x_sExtra_offer,string x_sMonthly_bank_account_no,string x_sFirst_month_license_fee,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dDdate,string x_sS_premium2,string x_sMonthly_bank_account_id_type,string x_sCard_type,global::System.Nullable<bool> x_bNext_bill,global::System.Nullable<bool> x_bPcd_paid_go_wireless,string x_sUpgrade_rebate_calculation,string x_sExt_place_tel,string x_sM_3rd_hkid,string x_sRetention_type,global::System.Nullable<DateTime> x_dCooling_date,string x_sAig_gift,string x_sCust_staff_no,string x_sFamily_name,global::System.Nullable<DateTime> x_dCdate,string x_sStatus_by_cs_admin,string x_sSim_item_number,string x_sVip_case,string x_sGiven_name,global::System.Nullable<DateTime> x_dLog_date,string x_sExtn,string x_sD_time,string x_sBank_name,string x_sDelivery_exchange_option,string x_sUpgrade_service_account_no,string x_sAction_of_rate_plan_effective,string x_sM_card_no,string x_sExisting_contract_end_date,global::System.Nullable<DateTime> x_dCon_eff_date,string x_sM_3rd_hkid2,string x_sAmount,string x_sId_type,string x_sRate_plan,string x_sChannel,global::System.Nullable<DateTime> x_dAction_eff_date,string x_sIssue_type,string x_sFree_mon,global::System.Nullable<DateTime> x_dPlan_eff_date,string x_sDel_remark,string x_sTeamcode,string x_sStaff_name,string x_sEdf_no,string x_sOrd_place_by,string x_sCancel_renew,string x_sPreferred_languages,string x_sHkid,string x_sCard_no,string x_sAc_no,global::System.Nullable<int> x_iBill_cut_num,string x_sPremium,string x_sM_3rd_id_type,string x_sGift_imei2,string x_sReasons,string x_sLanguage,string x_sRebate_amount,string x_sLob,string x_sM_3rd_contact_no,string x_sStaff_no,string x_sS_premium3,global::System.Nullable<DateTime> x_dSp_d_date,string x_sBundle_name,global::System.Nullable<bool> x_bAccessory_waive,string x_sSim_item_code,string x_sMonthly_bank_account_holder,string x_sCard_holder)
        {
            return MobileRetentionOrderRepository.Insert(x_oDB, x_sGift_imei,x_sS_premium4,x_sGift_desc4,x_sAccessory_desc,x_sAction_required,x_dVas_eff_date,x_sMonthly_bank_account_bank_code,x_sSpecial_handling_dummy_code,x_sM_card_exp_year,x_sRemarks2PY,x_sTrade_field,x_sOrd_place_tel,x_sOrd_place_id_type,x_sCooling_offer,x_sUpgrade_handset_offer_rebate_schedule,x_sChange_payment_type,x_dDate_of_birth,x_sContact_person,x_sExtra_d_charge,x_sTl_name,x_bFast_start,x_sSp_ref_no,x_dEdate,x_sExist_cust_plan,x_sOrd_place_rel,x_iMrt_no,x_sImei_no,x_sExisting_smart_phone_model,x_sGift_code3,x_sBank_code,x_sPos_ref_no,x_dBill_cut_date,x_sGift_imei3,x_sExist_plan,x_bWaive,x_sProgram,x_sFirst_month_fee,x_sR_offer,x_sCid,x_sDid,x_sFtg_tenure,x_sCon_per,x_sGift_code4,x_sEasywatch_type,x_sSms_mrt,x_sMonthly_payment_method,x_sRemarks2EDF,x_sGift_desc3,x_sGift_imei4,x_iOld_ord_id,x_sMonthly_bank_account_hkid2,x_dD_date,x_sGift_desc,x_sSalesmancode,x_sPool,x_lCn_mrt_no,x_sAccessory_imei,x_sThird_party_credit_card,x_sCard_ref_no,x_sSpecial_approval,x_dUpgrade_existing_contract_edate,x_sAccessory_code,x_sBill_medium,x_sS_premium,x_sRef_staff_no,x_sAccessory_price,x_sM_card_exp_month,x_sInstallment_period,x_sM_card_type,x_sEasywatch_ord_id,x_bNormal_rebate,x_sM_rebate_amount,x_sM_card_holder2,x_sBill_medium_email,x_bActive,x_sS_premium1,x_sCard_exp_month,x_sOb_program_id,x_sSku,x_sRef_salesmancode,x_sGo_wireless_package_code,x_sThird_party_hkid,x_sUpgrade_existing_pccw_customer,x_sD_address,x_sUpgrade_registered_mobile_no,x_sUpgrade_existing_customer_type,x_sNormal_rebate_type,x_sGift_desc2,x_sMonthly_bank_account_branch_code,x_sRemarks,x_sAccept,x_sDelivery_exchange,x_sGift_code2,x_bPrepayment_waive,x_sExisting_smart_phone_imei,x_sCust_name,x_sCust_type,x_sUpgrade_sponsorships_amount,x_bBill_medium_waive,x_sDelivery_exchange_location,x_iHs_offer_type_id,x_sOrg_fee,x_sRebate,x_sUpgrade_type,x_sGo_wireless,x_sExtra_rebate,x_sPlan_eff,x_sExtra_rebate_amount,x_sCard_exp_year,x_dUpgrade_existing_contract_sdate,x_sOrd_place_hkid,x_sRegister_address,x_sGender,x_sLob_ac,x_iSim_mrt_no,x_sRedemption_notice_option,x_sDelivery_collection_type,x_dAction_date,x_sThird_party_id_type,x_sOrg_ftg,x_sUpgrade_service_tenure,x_sMonthly_payment_type,x_sContact_no,x_iOrg_mrt,x_sSim_item_name,x_sPay_method,x_sHs_model,x_sGift_code,x_sMonthly_bank_account_hkid,x_sExtra_offer,x_sMonthly_bank_account_no,x_sFirst_month_license_fee,x_iRetrieve_cnt,x_dDdate,x_sS_premium2,x_sMonthly_bank_account_id_type,x_sCard_type,x_bNext_bill,x_bPcd_paid_go_wireless,x_sUpgrade_rebate_calculation,x_sExt_place_tel,x_sM_3rd_hkid,x_sRetention_type,x_dCooling_date,x_sAig_gift,x_sCust_staff_no,x_sFamily_name,x_dCdate,x_sStatus_by_cs_admin,x_sSim_item_number,x_sVip_case,x_sGiven_name,x_dLog_date,x_sExtn,x_sD_time,x_sBank_name,x_sDelivery_exchange_option,x_sUpgrade_service_account_no,x_sAction_of_rate_plan_effective,x_sM_card_no,x_sExisting_contract_end_date,x_dCon_eff_date,x_sM_3rd_hkid2,x_sAmount,x_sId_type,x_sRate_plan,x_sChannel,x_dAction_eff_date,x_sIssue_type,x_sFree_mon,x_dPlan_eff_date,x_sDel_remark,x_sTeamcode,x_sStaff_name,x_sEdf_no,x_sOrd_place_by,x_sCancel_renew,x_sPreferred_languages,x_sHkid,x_sCard_no,x_sAc_no,x_iBill_cut_num,x_sPremium,x_sM_3rd_id_type,x_sGift_imei2,x_sReasons,x_sLanguage,x_sRebate_amount,x_sLob,x_sM_3rd_contact_no,x_sStaff_no,x_sS_premium3,x_dSp_d_date,x_sBundle_name,x_bAccessory_waive,x_sSim_item_code,x_sMonthly_bank_account_holder,x_sCard_holder);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileRetentionOrder x_oMobileRetentionOrder)
        {
            return MobileRetentionOrderRepository.InsertWithOutLastID(x_oDB,x_oMobileRetentionOrder);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sGift_imei,string x_sS_premium4,string x_sGift_desc4,string x_sAccessory_desc,string x_sAction_required,global::System.Nullable<DateTime> x_dVas_eff_date,string x_sMonthly_bank_account_bank_code,string x_sSpecial_handling_dummy_code,string x_sM_card_exp_year,string x_sRemarks2PY,string x_sTrade_field,string x_sOrd_place_tel,string x_sOrd_place_id_type,string x_sCooling_offer,string x_sUpgrade_handset_offer_rebate_schedule,string x_sChange_payment_type,global::System.Nullable<DateTime> x_dDate_of_birth,string x_sContact_person,string x_sExtra_d_charge,string x_sTl_name,global::System.Nullable<bool> x_bFast_start,string x_sSp_ref_no,global::System.Nullable<DateTime> x_dEdate,string x_sExist_cust_plan,string x_sOrd_place_rel,global::System.Nullable<int> x_iMrt_no,string x_sImei_no,string x_sExisting_smart_phone_model,string x_sGift_code3,string x_sBank_code,string x_sPos_ref_no,global::System.Nullable<DateTime> x_dBill_cut_date,string x_sGift_imei3,string x_sExist_plan,global::System.Nullable<bool> x_bWaive,string x_sProgram,string x_sFirst_month_fee,string x_sR_offer,string x_sCid,string x_sDid,string x_sFtg_tenure,string x_sCon_per,string x_sGift_code4,string x_sEasywatch_type,string x_sSms_mrt,string x_sMonthly_payment_method,string x_sRemarks2EDF,string x_sGift_desc3,string x_sGift_imei4,global::System.Nullable<int> x_iOld_ord_id,string x_sMonthly_bank_account_hkid2,global::System.Nullable<DateTime> x_dD_date,string x_sGift_desc,string x_sSalesmancode,string x_sPool,global::System.Nullable<long> x_lCn_mrt_no,string x_sAccessory_imei,string x_sThird_party_credit_card,string x_sCard_ref_no,string x_sSpecial_approval,global::System.Nullable<DateTime> x_dUpgrade_existing_contract_edate,string x_sAccessory_code,string x_sBill_medium,string x_sS_premium,string x_sRef_staff_no,string x_sAccessory_price,string x_sM_card_exp_month,string x_sInstallment_period,string x_sM_card_type,string x_sEasywatch_ord_id,global::System.Nullable<bool> x_bNormal_rebate,string x_sM_rebate_amount,string x_sM_card_holder2,string x_sBill_medium_email,global::System.Nullable<bool> x_bActive,string x_sS_premium1,string x_sCard_exp_month,string x_sOb_program_id,string x_sSku,string x_sRef_salesmancode,string x_sGo_wireless_package_code,string x_sThird_party_hkid,string x_sUpgrade_existing_pccw_customer,string x_sD_address,string x_sUpgrade_registered_mobile_no,string x_sUpgrade_existing_customer_type,string x_sNormal_rebate_type,string x_sGift_desc2,string x_sMonthly_bank_account_branch_code,string x_sRemarks,string x_sAccept,string x_sDelivery_exchange,string x_sGift_code2,global::System.Nullable<bool> x_bPrepayment_waive,string x_sExisting_smart_phone_imei,string x_sCust_name,string x_sCust_type,string x_sUpgrade_sponsorships_amount,global::System.Nullable<bool> x_bBill_medium_waive,string x_sDelivery_exchange_location,global::System.Nullable<int> x_iHs_offer_type_id,string x_sOrg_fee,string x_sRebate,string x_sUpgrade_type,string x_sGo_wireless,string x_sExtra_rebate,string x_sPlan_eff,string x_sExtra_rebate_amount,string x_sCard_exp_year,global::System.Nullable<DateTime> x_dUpgrade_existing_contract_sdate,string x_sOrd_place_hkid,string x_sRegister_address,string x_sGender,string x_sLob_ac,global::System.Nullable<int> x_iSim_mrt_no,string x_sRedemption_notice_option,string x_sDelivery_collection_type,global::System.Nullable<DateTime> x_dAction_date,string x_sThird_party_id_type,string x_sOrg_ftg,string x_sUpgrade_service_tenure,string x_sMonthly_payment_type,string x_sContact_no,global::System.Nullable<int> x_iOrg_mrt,string x_sSim_item_name,string x_sPay_method,string x_sHs_model,string x_sGift_code,string x_sMonthly_bank_account_hkid,string x_sExtra_offer,string x_sMonthly_bank_account_no,string x_sFirst_month_license_fee,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dDdate,string x_sS_premium2,string x_sMonthly_bank_account_id_type,string x_sCard_type,global::System.Nullable<bool> x_bNext_bill,global::System.Nullable<bool> x_bPcd_paid_go_wireless,string x_sUpgrade_rebate_calculation,string x_sExt_place_tel,string x_sM_3rd_hkid,string x_sRetention_type,global::System.Nullable<DateTime> x_dCooling_date,string x_sAig_gift,string x_sCust_staff_no,string x_sFamily_name,global::System.Nullable<DateTime> x_dCdate,string x_sStatus_by_cs_admin,string x_sSim_item_number,string x_sVip_case,string x_sGiven_name,global::System.Nullable<DateTime> x_dLog_date,string x_sExtn,string x_sD_time,string x_sBank_name,string x_sDelivery_exchange_option,string x_sUpgrade_service_account_no,string x_sAction_of_rate_plan_effective,string x_sM_card_no,string x_sExisting_contract_end_date,global::System.Nullable<DateTime> x_dCon_eff_date,string x_sM_3rd_hkid2,string x_sAmount,string x_sId_type,string x_sRate_plan,string x_sChannel,global::System.Nullable<DateTime> x_dAction_eff_date,string x_sIssue_type,string x_sFree_mon,global::System.Nullable<DateTime> x_dPlan_eff_date,string x_sDel_remark,string x_sTeamcode,string x_sStaff_name,string x_sEdf_no,string x_sOrd_place_by,string x_sCancel_renew,string x_sPreferred_languages,string x_sHkid,string x_sCard_no,string x_sAc_no,global::System.Nullable<int> x_iBill_cut_num,string x_sPremium,string x_sM_3rd_id_type,string x_sGift_imei2,string x_sReasons,string x_sLanguage,string x_sRebate_amount,string x_sLob,string x_sM_3rd_contact_no,string x_sStaff_no,string x_sS_premium3,global::System.Nullable<DateTime> x_dSp_d_date,string x_sBundle_name,global::System.Nullable<bool> x_bAccessory_waive,string x_sSim_item_code,string x_sMonthly_bank_account_holder,string x_sCard_holder)
        {
            return MobileRetentionOrderRepository.InsertReturnLastID_SP(x_oDB,x_sGift_imei,x_sS_premium4,x_sGift_desc4,x_sAccessory_desc,x_sAction_required,x_dVas_eff_date,x_sMonthly_bank_account_bank_code,x_sSpecial_handling_dummy_code,x_sM_card_exp_year,x_sRemarks2PY,x_sTrade_field,x_sOrd_place_tel,x_sOrd_place_id_type,x_sCooling_offer,x_sUpgrade_handset_offer_rebate_schedule,x_sChange_payment_type,x_dDate_of_birth,x_sContact_person,x_sExtra_d_charge,x_sTl_name,x_bFast_start,x_sSp_ref_no,x_dEdate,x_sExist_cust_plan,x_sOrd_place_rel,x_iMrt_no,x_sImei_no,x_sExisting_smart_phone_model,x_sGift_code3,x_sBank_code,x_sPos_ref_no,x_dBill_cut_date,x_sGift_imei3,x_sExist_plan,x_bWaive,x_sProgram,x_sFirst_month_fee,x_sR_offer,x_sCid,x_sDid,x_sFtg_tenure,x_sCon_per,x_sGift_code4,x_sEasywatch_type,x_sSms_mrt,x_sMonthly_payment_method,x_sRemarks2EDF,x_sGift_desc3,x_sGift_imei4,x_iOld_ord_id,x_sMonthly_bank_account_hkid2,x_dD_date,x_sGift_desc,x_sSalesmancode,x_sPool,x_lCn_mrt_no,x_sAccessory_imei,x_sThird_party_credit_card,x_sCard_ref_no,x_sSpecial_approval,x_dUpgrade_existing_contract_edate,x_sAccessory_code,x_sBill_medium,x_sS_premium,x_sRef_staff_no,x_sAccessory_price,x_sM_card_exp_month,x_sInstallment_period,x_sM_card_type,x_sEasywatch_ord_id,x_bNormal_rebate,x_sM_rebate_amount,x_sM_card_holder2,x_sBill_medium_email,x_bActive,x_sS_premium1,x_sCard_exp_month,x_sOb_program_id,x_sSku,x_sRef_salesmancode,x_sGo_wireless_package_code,x_sThird_party_hkid,x_sUpgrade_existing_pccw_customer,x_sD_address,x_sUpgrade_registered_mobile_no,x_sUpgrade_existing_customer_type,x_sNormal_rebate_type,x_sGift_desc2,x_sMonthly_bank_account_branch_code,x_sRemarks,x_sAccept,x_sDelivery_exchange,x_sGift_code2,x_bPrepayment_waive,x_sExisting_smart_phone_imei,x_sCust_name,x_sCust_type,x_sUpgrade_sponsorships_amount,x_bBill_medium_waive,x_sDelivery_exchange_location,x_iHs_offer_type_id,x_sOrg_fee,x_sRebate,x_sUpgrade_type,x_sGo_wireless,x_sExtra_rebate,x_sPlan_eff,x_sExtra_rebate_amount,x_sCard_exp_year,x_dUpgrade_existing_contract_sdate,x_sOrd_place_hkid,x_sRegister_address,x_sGender,x_sLob_ac,x_iSim_mrt_no,x_sRedemption_notice_option,x_sDelivery_collection_type,x_dAction_date,x_sThird_party_id_type,x_sOrg_ftg,x_sUpgrade_service_tenure,x_sMonthly_payment_type,x_sContact_no,x_iOrg_mrt,x_sSim_item_name,x_sPay_method,x_sHs_model,x_sGift_code,x_sMonthly_bank_account_hkid,x_sExtra_offer,x_sMonthly_bank_account_no,x_sFirst_month_license_fee,x_iRetrieve_cnt,x_dDdate,x_sS_premium2,x_sMonthly_bank_account_id_type,x_sCard_type,x_bNext_bill,x_bPcd_paid_go_wireless,x_sUpgrade_rebate_calculation,x_sExt_place_tel,x_sM_3rd_hkid,x_sRetention_type,x_dCooling_date,x_sAig_gift,x_sCust_staff_no,x_sFamily_name,x_dCdate,x_sStatus_by_cs_admin,x_sSim_item_number,x_sVip_case,x_sGiven_name,x_dLog_date,x_sExtn,x_sD_time,x_sBank_name,x_sDelivery_exchange_option,x_sUpgrade_service_account_no,x_sAction_of_rate_plan_effective,x_sM_card_no,x_sExisting_contract_end_date,x_dCon_eff_date,x_sM_3rd_hkid2,x_sAmount,x_sId_type,x_sRate_plan,x_sChannel,x_dAction_eff_date,x_sIssue_type,x_sFree_mon,x_dPlan_eff_date,x_sDel_remark,x_sTeamcode,x_sStaff_name,x_sEdf_no,x_sOrd_place_by,x_sCancel_renew,x_sPreferred_languages,x_sHkid,x_sCard_no,x_sAc_no,x_iBill_cut_num,x_sPremium,x_sM_3rd_id_type,x_sGift_imei2,x_sReasons,x_sLanguage,x_sRebate_amount,x_sLob,x_sM_3rd_contact_no,x_sStaff_no,x_sS_premium3,x_dSp_d_date,x_sBundle_name,x_bAccessory_waive,x_sSim_item_code,x_sMonthly_bank_account_holder,x_sCard_holder);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileRetentionOrder x_oMobileRetentionOrder)
        {
            return MobileRetentionOrderRepository.InsertReturnLastID_SP(x_oDB,x_oMobileRetentionOrder);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return MobileRetentionOrderRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return MobileRetentionOrderRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iOrder_id)
        {
            return MobileRetentionOrderRepository.Delete(x_oDB, x_iOrder_id);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(MobileRetentionOrder x_oMobileRetentionOrderRow){
            String sFile = String.Empty;
        }
        
        #endregion
        
        #region Release
        
        // ******************************
        // *  Handler for Release Memory
        // ******************************
        
        public void Release(){}
        #endregion
    }
}


