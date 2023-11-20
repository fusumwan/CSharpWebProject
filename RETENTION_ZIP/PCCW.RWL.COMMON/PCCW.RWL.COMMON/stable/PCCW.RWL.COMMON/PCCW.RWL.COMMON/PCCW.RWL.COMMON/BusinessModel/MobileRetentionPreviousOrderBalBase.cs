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
///-- Description:	<Description,Table :[MobileRetentionPreviousOrder],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileRetentionPreviousOrder] Business layer
    /// </summary>
    
    public abstract class MobileRetentionPreviousOrderBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public MobileRetentionPreviousOrderBalBase(){
        }
        ~MobileRetentionPreviousOrderBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(MobileRetentionPreviousOrder x_oMobileRetentionPreviousOrder)
        {
            return GetDataSet(x_oMobileRetentionPreviousOrder,null,MobileRetentionPreviousOrderInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileRetentionPreviousOrder x_oMobileRetentionPreviousOrder,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oMobileRetentionPreviousOrder,x_oMergeDSet,MobileRetentionPreviousOrderInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileRetentionPreviousOrder x_oMobileRetentionPreviousOrder,MobileRetentionPreviousOrderInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileRetentionPreviousOrder,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileRetentionPreviousOrder x_oMobileRetentionPreviousOrder,global::System.Data.DataSet x_oMergeDSet,MobileRetentionPreviousOrderInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileRetentionPreviousOrder,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(MobileRetentionPreviousOrder x_oMobileRetentionPreviousOrder,global::System.Data.DataSet x_oMergeDSet,MobileRetentionPreviousOrderInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileRetentionPreviousOrderInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(MobileRetentionPreviousOrder.Para.TableName());
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_imei).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.gift_imei); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium4).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.s_premium4); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_desc4).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.gift_desc4); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_desc).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.accessory_desc); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.action_required).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.action_required); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.registered_address_his_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.registered_address_his_id); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.vas_eff_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.vas_eff_date); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_bank_code).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.monthly_bank_account_bank_code); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.special_handling_dummy_code).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.special_handling_dummy_code); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_exp_year).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.m_card_exp_year); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.remarks2PY).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.remarks2PY); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.trade_field).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.trade_field); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_tel).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.ord_place_tel); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_id_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.ord_place_id_type); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cooling_offer).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.cooling_offer); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.rec_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.rec_no); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_handset_offer_rebate_schedule).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.upgrade_handset_offer_rebate_schedule); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.change_payment_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.change_payment_type); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.date_of_birth).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.date_of_birth); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.contact_person).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.contact_person); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extra_d_charge).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.extra_d_charge); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.tl_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.tl_name); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.fast_start).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.fast_start); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sp_ref_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.sp_ref_no); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.edate); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.exist_cust_plan).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.exist_cust_plan); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_rel).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.ord_place_rel); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.mrt_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.mrt_no); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.imei_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.imei_no); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.existing_smart_phone_model).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.existing_smart_phone_model); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_code3).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.gift_code3); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bank_code).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.bank_code); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.pos_ref_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.pos_ref_no); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_cut_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.bill_cut_date); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_imei3).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.gift_imei3); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.exist_plan).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.exist_plan); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.waive).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.waive); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.program).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.program); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.first_month_fee).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.first_month_fee); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.r_offer).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.r_offer); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.cid); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.did); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ftg_tenure).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.ftg_tenure); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.con_per).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.con_per); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_code4).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.gift_code4); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.easywatch_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.easywatch_type); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sms_mrt).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.sms_mrt); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.tpy_his_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.tpy_his_id); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_payment_method).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.monthly_payment_method); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.remarks2EDF).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.remarks2EDF); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_desc3).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.gift_desc3); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_imei4).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.gift_imei4); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.old_ord_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.old_ord_id); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_hkid2).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.monthly_bank_account_hkid2); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.d_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.d_date); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_desc).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.gift_desc); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.salesmancode).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.salesmancode); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.pool).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.pool); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cn_mrt_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.cn_mrt_no); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_imei).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.accessory_imei); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.third_party_credit_card).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.third_party_credit_card); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_ref_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.card_ref_no); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cooling_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.cooling_date); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.special_approval).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.special_approval); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_existing_contract_edate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.upgrade_existing_contract_edate); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_code).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.accessory_code); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_medium).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.bill_medium); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.s_premium); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ref_staff_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.ref_staff_no); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_price).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.accessory_price); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_exp_month).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.m_card_exp_month); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.installment_period).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.installment_period); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.m_card_type); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.easywatch_ord_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.easywatch_ord_id); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.normal_rebate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.normal_rebate); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_rebate_amount).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.m_rebate_amount); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_holder2).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.m_card_holder2); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_medium_email).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.bill_medium_email); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.active); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium1).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.s_premium1); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_exp_month).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.card_exp_month); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ob_program_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.ob_program_id); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sku).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.sku); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ref_salesmancode).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.ref_salesmancode); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.go_wireless_package_code).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.go_wireless_package_code); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.third_party_hkid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.third_party_hkid); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_existing_pccw_customer).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.upgrade_existing_pccw_customer); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.d_address).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.d_address); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_registered_mobile_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.upgrade_registered_mobile_no); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_existing_customer_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.upgrade_existing_customer_type); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.normal_rebate_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.normal_rebate_type); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_desc2).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.gift_desc2); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_branch_code).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.monthly_bank_account_branch_code); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.remarks).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.remarks); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accept).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.accept); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.delivery_exchange).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.delivery_exchange); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_code2).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.gift_code2); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.prepayment_waive).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.prepayment_waive); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.existing_smart_phone_imei).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.existing_smart_phone_imei); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.mnp_his_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.mnp_his_id); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cust_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.cust_name); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cust_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.cust_type); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_sponsorships_amount).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.upgrade_sponsorships_amount); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_medium_waive).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.bill_medium_waive); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.delivery_exchange_location).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.delivery_exchange_location); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.hs_offer_type_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.hs_offer_type_id); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.org_fee).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.org_fee); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.rebate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.rebate); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.upgrade_type); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.go_wireless).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.go_wireless); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extra_rebate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.extra_rebate); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.plan_eff).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.plan_eff); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extra_rebate_amount).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.extra_rebate_amount); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_exp_year).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.card_exp_year); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_existing_contract_sdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.upgrade_existing_contract_sdate); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_hkid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.ord_place_hkid); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.register_address).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.register_address); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gender).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.gender); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.lob_ac).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.lob_ac); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sim_mrt_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.sim_mrt_no); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.redemption_notice_option).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.redemption_notice_option); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.delivery_collection_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.delivery_collection_type); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.action_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.action_date); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.third_party_id_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.third_party_id_type); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.org_ftg).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.org_ftg); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_service_tenure).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.upgrade_service_tenure); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_payment_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.monthly_payment_type); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.contact_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.contact_no); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.org_mrt).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.org_mrt); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sim_item_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.sim_item_name); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.pay_method).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.pay_method); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.hs_model).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.hs_model); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_code).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.gift_code); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_hkid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.monthly_bank_account_hkid); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extra_offer).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.extra_offer); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.monthly_bank_account_no); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.first_month_license_fee).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.first_month_license_fee); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.retrieve_cnt).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.retrieve_cnt); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.ddate); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium2).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.s_premium2); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_id_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.monthly_bank_account_id_type); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.card_type); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.next_bill).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.next_bill); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.pcd_paid_go_wireless).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.pcd_paid_go_wireless); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_rebate_calculation).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.upgrade_rebate_calculation); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ext_place_tel).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.ext_place_tel); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_3rd_hkid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.m_3rd_hkid); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.retention_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.retention_type); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_address_his_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.bill_address_his_id); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.aig_gift).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.aig_gift); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cust_staff_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.cust_staff_no); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.order_id); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.family_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.family_name); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.cdate); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.status_by_cs_admin).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.status_by_cs_admin); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sim_item_number).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.sim_item_number); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.vip_case).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.vip_case); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.given_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.given_name); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.log_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.log_date); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extn).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.extn); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.d_time).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.d_time); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bank_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.bank_name); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.delivery_exchange_option).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.delivery_exchange_option); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_service_account_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.upgrade_service_account_no); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.action_of_rate_plan_effective).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.action_of_rate_plan_effective); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.m_card_no); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.existing_contract_end_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.existing_contract_end_date); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.con_eff_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.con_eff_date); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_3rd_hkid2).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.m_3rd_hkid2); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.amount).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.amount); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.id_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.id_type); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.rate_plan).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.rate_plan); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.channel).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.channel); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.action_eff_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.action_eff_date); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.issue_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.issue_type); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.free_mon).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.free_mon); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.plan_eff_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.plan_eff_date); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.del_remark).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.del_remark); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.teamcode).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.teamcode); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.staff_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.staff_name); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.edf_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.edf_no); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_by).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.ord_place_by); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cancel_renew).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.cancel_renew); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.preferred_languages).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.preferred_languages); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.hkid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.hkid); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.card_no); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ac_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.ac_no); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_cut_num).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.bill_cut_num); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.premium).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.premium); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_3rd_id_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.m_3rd_id_type); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_imei2).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.gift_imei2); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.reasons).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.reasons); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.language).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.language); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.rebate_amount).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.rebate_amount); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.lob).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.lob); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_3rd_contact_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.m_3rd_contact_no); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.staff_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.staff_no); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium3).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.s_premium3); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sp_d_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.sp_d_date); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bundle_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.bundle_name); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_waive).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.accessory_waive); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sim_item_code).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.sim_item_code); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_holder).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.monthly_bank_account_holder); }
            if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_holder).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Columns.Add(MobileRetentionPreviousOrder.Para.card_holder); }
            if (x_oMobileRetentionPreviousOrder != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_imei).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.gift_imei] = x_oMobileRetentionPreviousOrder.GetGift_imei(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium4).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.s_premium4] = x_oMobileRetentionPreviousOrder.GetS_premium4(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_desc4).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.gift_desc4] = x_oMobileRetentionPreviousOrder.GetGift_desc4(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_desc).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.accessory_desc] = x_oMobileRetentionPreviousOrder.GetAccessory_desc(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.action_required).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.action_required] = x_oMobileRetentionPreviousOrder.GetAction_required(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.registered_address_his_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.registered_address_his_id] = x_oMobileRetentionPreviousOrder.GetRegistered_address_his_id(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.vas_eff_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.vas_eff_date] = x_oMobileRetentionPreviousOrder.GetVas_eff_date(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_bank_code).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.monthly_bank_account_bank_code] = x_oMobileRetentionPreviousOrder.GetMonthly_bank_account_bank_code(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.special_handling_dummy_code).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.special_handling_dummy_code] = x_oMobileRetentionPreviousOrder.GetSpecial_handling_dummy_code(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_exp_year).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.m_card_exp_year] = x_oMobileRetentionPreviousOrder.GetM_card_exp_year(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.remarks2PY).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.remarks2PY] = x_oMobileRetentionPreviousOrder.GetRemarks2PY(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.trade_field).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.trade_field] = x_oMobileRetentionPreviousOrder.GetTrade_field(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_tel).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.ord_place_tel] = x_oMobileRetentionPreviousOrder.GetOrd_place_tel(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_id_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.ord_place_id_type] = x_oMobileRetentionPreviousOrder.GetOrd_place_id_type(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cooling_offer).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.cooling_offer] = x_oMobileRetentionPreviousOrder.GetCooling_offer(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.rec_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.rec_no] = x_oMobileRetentionPreviousOrder.GetRec_no(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_handset_offer_rebate_schedule).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.upgrade_handset_offer_rebate_schedule] = x_oMobileRetentionPreviousOrder.GetUpgrade_handset_offer_rebate_schedule(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.change_payment_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.change_payment_type] = x_oMobileRetentionPreviousOrder.GetChange_payment_type(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.date_of_birth).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.date_of_birth] = x_oMobileRetentionPreviousOrder.GetDate_of_birth(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.contact_person).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.contact_person] = x_oMobileRetentionPreviousOrder.GetContact_person(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extra_d_charge).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.extra_d_charge] = x_oMobileRetentionPreviousOrder.GetExtra_d_charge(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.tl_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.tl_name] = x_oMobileRetentionPreviousOrder.GetTl_name(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.fast_start).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.fast_start] = x_oMobileRetentionPreviousOrder.GetFast_start(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sp_ref_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.sp_ref_no] = x_oMobileRetentionPreviousOrder.GetSp_ref_no(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.edate] = x_oMobileRetentionPreviousOrder.GetEdate(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.exist_cust_plan).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.exist_cust_plan] = x_oMobileRetentionPreviousOrder.GetExist_cust_plan(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_rel).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.ord_place_rel] = x_oMobileRetentionPreviousOrder.GetOrd_place_rel(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.mrt_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.mrt_no] = x_oMobileRetentionPreviousOrder.GetMrt_no(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.imei_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.imei_no] = x_oMobileRetentionPreviousOrder.GetImei_no(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.existing_smart_phone_model).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.existing_smart_phone_model] = x_oMobileRetentionPreviousOrder.GetExisting_smart_phone_model(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_code3).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.gift_code3] = x_oMobileRetentionPreviousOrder.GetGift_code3(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bank_code).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.bank_code] = x_oMobileRetentionPreviousOrder.GetBank_code(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.pos_ref_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.pos_ref_no] = x_oMobileRetentionPreviousOrder.GetPos_ref_no(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_cut_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.bill_cut_date] = x_oMobileRetentionPreviousOrder.GetBill_cut_date(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_imei3).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.gift_imei3] = x_oMobileRetentionPreviousOrder.GetGift_imei3(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.exist_plan).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.exist_plan] = x_oMobileRetentionPreviousOrder.GetExist_plan(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.waive).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.waive] = x_oMobileRetentionPreviousOrder.GetWaive(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.program).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.program] = x_oMobileRetentionPreviousOrder.GetProgram(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.first_month_fee).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.first_month_fee] = x_oMobileRetentionPreviousOrder.GetFirst_month_fee(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.r_offer).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.r_offer] = x_oMobileRetentionPreviousOrder.GetR_offer(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.cid] = x_oMobileRetentionPreviousOrder.GetCid(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.did] = x_oMobileRetentionPreviousOrder.GetDid(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ftg_tenure).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.ftg_tenure] = x_oMobileRetentionPreviousOrder.GetFtg_tenure(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.con_per).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.con_per] = x_oMobileRetentionPreviousOrder.GetCon_per(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_code4).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.gift_code4] = x_oMobileRetentionPreviousOrder.GetGift_code4(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.easywatch_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.easywatch_type] = x_oMobileRetentionPreviousOrder.GetEasywatch_type(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sms_mrt).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.sms_mrt] = x_oMobileRetentionPreviousOrder.GetSms_mrt(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.tpy_his_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.tpy_his_id] = x_oMobileRetentionPreviousOrder.GetTpy_his_id(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_payment_method).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.monthly_payment_method] = x_oMobileRetentionPreviousOrder.GetMonthly_payment_method(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.remarks2EDF).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.remarks2EDF] = x_oMobileRetentionPreviousOrder.GetRemarks2EDF(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_desc3).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.gift_desc3] = x_oMobileRetentionPreviousOrder.GetGift_desc3(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_imei4).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.gift_imei4] = x_oMobileRetentionPreviousOrder.GetGift_imei4(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.old_ord_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.old_ord_id] = x_oMobileRetentionPreviousOrder.GetOld_ord_id(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_hkid2).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.monthly_bank_account_hkid2] = x_oMobileRetentionPreviousOrder.GetMonthly_bank_account_hkid2(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.d_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.d_date] = x_oMobileRetentionPreviousOrder.GetD_date(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_desc).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.gift_desc] = x_oMobileRetentionPreviousOrder.GetGift_desc(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.salesmancode).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.salesmancode] = x_oMobileRetentionPreviousOrder.GetSalesmancode(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.pool).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.pool] = x_oMobileRetentionPreviousOrder.GetPool(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cn_mrt_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.cn_mrt_no] = x_oMobileRetentionPreviousOrder.GetCn_mrt_no(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_imei).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.accessory_imei] = x_oMobileRetentionPreviousOrder.GetAccessory_imei(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.third_party_credit_card).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.third_party_credit_card] = x_oMobileRetentionPreviousOrder.GetThird_party_credit_card(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_ref_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.card_ref_no] = x_oMobileRetentionPreviousOrder.GetCard_ref_no(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cooling_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.cooling_date] = x_oMobileRetentionPreviousOrder.GetCooling_date(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.special_approval).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.special_approval] = x_oMobileRetentionPreviousOrder.GetSpecial_approval(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_existing_contract_edate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.upgrade_existing_contract_edate] = x_oMobileRetentionPreviousOrder.GetUpgrade_existing_contract_edate(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_code).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.accessory_code] = x_oMobileRetentionPreviousOrder.GetAccessory_code(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_medium).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.bill_medium] = x_oMobileRetentionPreviousOrder.GetBill_medium(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.s_premium] = x_oMobileRetentionPreviousOrder.GetS_premium(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ref_staff_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.ref_staff_no] = x_oMobileRetentionPreviousOrder.GetRef_staff_no(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_price).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.accessory_price] = x_oMobileRetentionPreviousOrder.GetAccessory_price(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_exp_month).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.m_card_exp_month] = x_oMobileRetentionPreviousOrder.GetM_card_exp_month(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.installment_period).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.installment_period] = x_oMobileRetentionPreviousOrder.GetInstallment_period(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.m_card_type] = x_oMobileRetentionPreviousOrder.GetM_card_type(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.easywatch_ord_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.easywatch_ord_id] = x_oMobileRetentionPreviousOrder.GetEasywatch_ord_id(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.normal_rebate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.normal_rebate] = x_oMobileRetentionPreviousOrder.GetNormal_rebate(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_rebate_amount).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.m_rebate_amount] = x_oMobileRetentionPreviousOrder.GetM_rebate_amount(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_holder2).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.m_card_holder2] = x_oMobileRetentionPreviousOrder.GetM_card_holder2(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_medium_email).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.bill_medium_email] = x_oMobileRetentionPreviousOrder.GetBill_medium_email(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.active] = x_oMobileRetentionPreviousOrder.GetActive(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium1).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.s_premium1] = x_oMobileRetentionPreviousOrder.GetS_premium1(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_exp_month).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.card_exp_month] = x_oMobileRetentionPreviousOrder.GetCard_exp_month(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ob_program_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.ob_program_id] = x_oMobileRetentionPreviousOrder.GetOb_program_id(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sku).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.sku] = x_oMobileRetentionPreviousOrder.GetSku(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ref_salesmancode).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.ref_salesmancode] = x_oMobileRetentionPreviousOrder.GetRef_salesmancode(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.go_wireless_package_code).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.go_wireless_package_code] = x_oMobileRetentionPreviousOrder.GetGo_wireless_package_code(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.third_party_hkid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.third_party_hkid] = x_oMobileRetentionPreviousOrder.GetThird_party_hkid(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_existing_pccw_customer).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.upgrade_existing_pccw_customer] = x_oMobileRetentionPreviousOrder.GetUpgrade_existing_pccw_customer(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.d_address).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.d_address] = x_oMobileRetentionPreviousOrder.GetD_address(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_registered_mobile_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.upgrade_registered_mobile_no] = x_oMobileRetentionPreviousOrder.GetUpgrade_registered_mobile_no(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_existing_customer_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.upgrade_existing_customer_type] = x_oMobileRetentionPreviousOrder.GetUpgrade_existing_customer_type(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.normal_rebate_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.normal_rebate_type] = x_oMobileRetentionPreviousOrder.GetNormal_rebate_type(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_desc2).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.gift_desc2] = x_oMobileRetentionPreviousOrder.GetGift_desc2(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_branch_code).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.monthly_bank_account_branch_code] = x_oMobileRetentionPreviousOrder.GetMonthly_bank_account_branch_code(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.remarks).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.remarks] = x_oMobileRetentionPreviousOrder.GetRemarks(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accept).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.accept] = x_oMobileRetentionPreviousOrder.GetAccept(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.delivery_exchange).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.delivery_exchange] = x_oMobileRetentionPreviousOrder.GetDelivery_exchange(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_code2).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.gift_code2] = x_oMobileRetentionPreviousOrder.GetGift_code2(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.prepayment_waive).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.prepayment_waive] = x_oMobileRetentionPreviousOrder.GetPrepayment_waive(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.existing_smart_phone_imei).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.existing_smart_phone_imei] = x_oMobileRetentionPreviousOrder.GetExisting_smart_phone_imei(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.mnp_his_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.mnp_his_id] = x_oMobileRetentionPreviousOrder.GetMnp_his_id(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cust_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.cust_name] = x_oMobileRetentionPreviousOrder.GetCust_name(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cust_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.cust_type] = x_oMobileRetentionPreviousOrder.GetCust_type(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_sponsorships_amount).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.upgrade_sponsorships_amount] = x_oMobileRetentionPreviousOrder.GetUpgrade_sponsorships_amount(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_medium_waive).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.bill_medium_waive] = x_oMobileRetentionPreviousOrder.GetBill_medium_waive(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.delivery_exchange_location).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.delivery_exchange_location] = x_oMobileRetentionPreviousOrder.GetDelivery_exchange_location(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.hs_offer_type_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.hs_offer_type_id] = x_oMobileRetentionPreviousOrder.GetHs_offer_type_id(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.org_fee).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.org_fee] = x_oMobileRetentionPreviousOrder.GetOrg_fee(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.rebate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.rebate] = x_oMobileRetentionPreviousOrder.GetRebate(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.upgrade_type] = x_oMobileRetentionPreviousOrder.GetUpgrade_type(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.go_wireless).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.go_wireless] = x_oMobileRetentionPreviousOrder.GetGo_wireless(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extra_rebate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.extra_rebate] = x_oMobileRetentionPreviousOrder.GetExtra_rebate(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.plan_eff).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.plan_eff] = x_oMobileRetentionPreviousOrder.GetPlan_eff(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extra_rebate_amount).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.extra_rebate_amount] = x_oMobileRetentionPreviousOrder.GetExtra_rebate_amount(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_exp_year).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.card_exp_year] = x_oMobileRetentionPreviousOrder.GetCard_exp_year(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_existing_contract_sdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.upgrade_existing_contract_sdate] = x_oMobileRetentionPreviousOrder.GetUpgrade_existing_contract_sdate(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_hkid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.ord_place_hkid] = x_oMobileRetentionPreviousOrder.GetOrd_place_hkid(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.register_address).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.register_address] = x_oMobileRetentionPreviousOrder.GetRegister_address(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gender).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.gender] = x_oMobileRetentionPreviousOrder.GetGender(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.lob_ac).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.lob_ac] = x_oMobileRetentionPreviousOrder.GetLob_ac(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sim_mrt_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.sim_mrt_no] = x_oMobileRetentionPreviousOrder.GetSim_mrt_no(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.redemption_notice_option).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.redemption_notice_option] = x_oMobileRetentionPreviousOrder.GetRedemption_notice_option(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.delivery_collection_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.delivery_collection_type] = x_oMobileRetentionPreviousOrder.GetDelivery_collection_type(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.action_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.action_date] = x_oMobileRetentionPreviousOrder.GetAction_date(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.third_party_id_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.third_party_id_type] = x_oMobileRetentionPreviousOrder.GetThird_party_id_type(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.org_ftg).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.org_ftg] = x_oMobileRetentionPreviousOrder.GetOrg_ftg(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_service_tenure).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.upgrade_service_tenure] = x_oMobileRetentionPreviousOrder.GetUpgrade_service_tenure(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_payment_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.monthly_payment_type] = x_oMobileRetentionPreviousOrder.GetMonthly_payment_type(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.contact_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.contact_no] = x_oMobileRetentionPreviousOrder.GetContact_no(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.org_mrt).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.org_mrt] = x_oMobileRetentionPreviousOrder.GetOrg_mrt(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sim_item_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.sim_item_name] = x_oMobileRetentionPreviousOrder.GetSim_item_name(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.pay_method).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.pay_method] = x_oMobileRetentionPreviousOrder.GetPay_method(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.hs_model).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.hs_model] = x_oMobileRetentionPreviousOrder.GetHs_model(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_code).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.gift_code] = x_oMobileRetentionPreviousOrder.GetGift_code(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_hkid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.monthly_bank_account_hkid] = x_oMobileRetentionPreviousOrder.GetMonthly_bank_account_hkid(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extra_offer).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.extra_offer] = x_oMobileRetentionPreviousOrder.GetExtra_offer(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.monthly_bank_account_no] = x_oMobileRetentionPreviousOrder.GetMonthly_bank_account_no(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.first_month_license_fee).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.first_month_license_fee] = x_oMobileRetentionPreviousOrder.GetFirst_month_license_fee(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.retrieve_cnt).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.retrieve_cnt] = x_oMobileRetentionPreviousOrder.GetRetrieve_cnt(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.ddate] = x_oMobileRetentionPreviousOrder.GetDdate(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium2).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.s_premium2] = x_oMobileRetentionPreviousOrder.GetS_premium2(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_id_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.monthly_bank_account_id_type] = x_oMobileRetentionPreviousOrder.GetMonthly_bank_account_id_type(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.card_type] = x_oMobileRetentionPreviousOrder.GetCard_type(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.next_bill).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.next_bill] = x_oMobileRetentionPreviousOrder.GetNext_bill(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.pcd_paid_go_wireless).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.pcd_paid_go_wireless] = x_oMobileRetentionPreviousOrder.GetPcd_paid_go_wireless(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_rebate_calculation).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.upgrade_rebate_calculation] = x_oMobileRetentionPreviousOrder.GetUpgrade_rebate_calculation(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ext_place_tel).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.ext_place_tel] = x_oMobileRetentionPreviousOrder.GetExt_place_tel(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_3rd_hkid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.m_3rd_hkid] = x_oMobileRetentionPreviousOrder.GetM_3rd_hkid(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.retention_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.retention_type] = x_oMobileRetentionPreviousOrder.GetRetention_type(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_address_his_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.bill_address_his_id] = x_oMobileRetentionPreviousOrder.GetBill_address_his_id(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.aig_gift).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.aig_gift] = x_oMobileRetentionPreviousOrder.GetAig_gift(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cust_staff_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.cust_staff_no] = x_oMobileRetentionPreviousOrder.GetCust_staff_no(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.order_id] = x_oMobileRetentionPreviousOrder.GetOrder_id(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.family_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.family_name] = x_oMobileRetentionPreviousOrder.GetFamily_name(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.cdate] = x_oMobileRetentionPreviousOrder.GetCdate(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.status_by_cs_admin).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.status_by_cs_admin] = x_oMobileRetentionPreviousOrder.GetStatus_by_cs_admin(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sim_item_number).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.sim_item_number] = x_oMobileRetentionPreviousOrder.GetSim_item_number(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.vip_case).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.vip_case] = x_oMobileRetentionPreviousOrder.GetVip_case(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.given_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.given_name] = x_oMobileRetentionPreviousOrder.GetGiven_name(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.log_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.log_date] = x_oMobileRetentionPreviousOrder.GetLog_date(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extn).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.extn] = x_oMobileRetentionPreviousOrder.GetExtn(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.d_time).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.d_time] = x_oMobileRetentionPreviousOrder.GetD_time(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bank_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.bank_name] = x_oMobileRetentionPreviousOrder.GetBank_name(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.delivery_exchange_option).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.delivery_exchange_option] = x_oMobileRetentionPreviousOrder.GetDelivery_exchange_option(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_service_account_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.upgrade_service_account_no] = x_oMobileRetentionPreviousOrder.GetUpgrade_service_account_no(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.action_of_rate_plan_effective).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.action_of_rate_plan_effective] = x_oMobileRetentionPreviousOrder.GetAction_of_rate_plan_effective(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.m_card_no] = x_oMobileRetentionPreviousOrder.GetM_card_no(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.existing_contract_end_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.existing_contract_end_date] = x_oMobileRetentionPreviousOrder.GetExisting_contract_end_date(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.con_eff_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.con_eff_date] = x_oMobileRetentionPreviousOrder.GetCon_eff_date(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_3rd_hkid2).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.m_3rd_hkid2] = x_oMobileRetentionPreviousOrder.GetM_3rd_hkid2(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.amount).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.amount] = x_oMobileRetentionPreviousOrder.GetAmount(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.id_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.id_type] = x_oMobileRetentionPreviousOrder.GetId_type(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.rate_plan).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.rate_plan] = x_oMobileRetentionPreviousOrder.GetRate_plan(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.channel).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.channel] = x_oMobileRetentionPreviousOrder.GetChannel(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.action_eff_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.action_eff_date] = x_oMobileRetentionPreviousOrder.GetAction_eff_date(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.issue_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.issue_type] = x_oMobileRetentionPreviousOrder.GetIssue_type(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.free_mon).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.free_mon] = x_oMobileRetentionPreviousOrder.GetFree_mon(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.plan_eff_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.plan_eff_date] = x_oMobileRetentionPreviousOrder.GetPlan_eff_date(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.del_remark).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.del_remark] = x_oMobileRetentionPreviousOrder.GetDel_remark(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.teamcode).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.teamcode] = x_oMobileRetentionPreviousOrder.GetTeamcode(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.staff_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.staff_name] = x_oMobileRetentionPreviousOrder.GetStaff_name(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.edf_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.edf_no] = x_oMobileRetentionPreviousOrder.GetEdf_no(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_by).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.ord_place_by] = x_oMobileRetentionPreviousOrder.GetOrd_place_by(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cancel_renew).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.cancel_renew] = x_oMobileRetentionPreviousOrder.GetCancel_renew(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.preferred_languages).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.preferred_languages] = x_oMobileRetentionPreviousOrder.GetPreferred_languages(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.hkid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.hkid] = x_oMobileRetentionPreviousOrder.GetHkid(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.card_no] = x_oMobileRetentionPreviousOrder.GetCard_no(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ac_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.ac_no] = x_oMobileRetentionPreviousOrder.GetAc_no(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_cut_num).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.bill_cut_num] = x_oMobileRetentionPreviousOrder.GetBill_cut_num(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.premium).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.premium] = x_oMobileRetentionPreviousOrder.GetPremium(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_3rd_id_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.m_3rd_id_type] = x_oMobileRetentionPreviousOrder.GetM_3rd_id_type(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_imei2).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.gift_imei2] = x_oMobileRetentionPreviousOrder.GetGift_imei2(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.reasons).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.reasons] = x_oMobileRetentionPreviousOrder.GetReasons(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.language).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.language] = x_oMobileRetentionPreviousOrder.GetLanguage(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.rebate_amount).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.rebate_amount] = x_oMobileRetentionPreviousOrder.GetRebate_amount(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.lob).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.lob] = x_oMobileRetentionPreviousOrder.GetLob(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_3rd_contact_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.m_3rd_contact_no] = x_oMobileRetentionPreviousOrder.GetM_3rd_contact_no(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.staff_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.staff_no] = x_oMobileRetentionPreviousOrder.GetStaff_no(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium3).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.s_premium3] = x_oMobileRetentionPreviousOrder.GetS_premium3(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sp_d_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.sp_d_date] = x_oMobileRetentionPreviousOrder.GetSp_d_date(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bundle_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.bundle_name] = x_oMobileRetentionPreviousOrder.GetBundle_name(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_waive).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.accessory_waive] = x_oMobileRetentionPreviousOrder.GetAccessory_waive(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sim_item_code).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.sim_item_code] = x_oMobileRetentionPreviousOrder.GetSim_item_code(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_holder).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.monthly_bank_account_holder] = x_oMobileRetentionPreviousOrder.GetMonthly_bank_account_holder(); }
                if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_holder).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionPreviousOrder.Para.card_holder] = x_oMobileRetentionPreviousOrder.GetCard_holder(); }
                _oDSet.Tables[MobileRetentionPreviousOrder.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(MobileRetentionPreviousOrderInfo x_oTableSet)
        {
            return MobileRetentionPreviousOrderBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return MobileRetentionPreviousOrderBal.ToEmptyDataSetProcess(MobileRetentionPreviousOrderInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(MobileRetentionPreviousOrderInfo x_oTableSet)
        {
            return MobileRetentionPreviousOrderBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(MobileRetentionPreviousOrder x_oMobileRetentionPreviousOrder, MobileRetentionPreviousOrderInfo x_oTableSet)
        {
            return MobileRetentionPreviousOrderBal.GetDataSet(null, null, x_oTableSet).Tables[MobileRetentionPreviousOrder.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(MobileRetentionPreviousOrder x_oMobileRetentionPreviousOrder)
        {
            return MobileRetentionPreviousOrderBal.GetDataSet(x_oMobileRetentionPreviousOrder, null, MobileRetentionPreviousOrderInfoDLL.CreateInfoInstanceObject()).Tables[MobileRetentionPreviousOrder.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iOrder_id)
        {
            return Row(x_oTable, x_oDB,x_iOrder_id,MobileRetentionPreviousOrderInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iOrder_id, MobileRetentionPreviousOrderInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iOrder_id, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iOrder_id,MobileRetentionPreviousOrderInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileRetentionPreviousOrderInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [MobileRetentionPreviousOrder].[gift_imei] AS MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI,[MobileRetentionPreviousOrder].[s_premium4] AS MOBILERETENTIONPREVIOUSORDER_S_PREMIUM4,[MobileRetentionPreviousOrder].[upgrade_existing_customer_type] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_CUSTOMER_TYPE,[MobileRetentionPreviousOrder].[gift_desc4] AS MOBILERETENTIONPREVIOUSORDER_GIFT_DESC4,[MobileRetentionPreviousOrder].[accessory_desc] AS MOBILERETENTIONPREVIOUSORDER_ACCESSORY_DESC,[MobileRetentionPreviousOrder].[staff_name] AS MOBILERETENTIONPREVIOUSORDER_STAFF_NAME,[MobileRetentionPreviousOrder].[action_required] AS MOBILERETENTIONPREVIOUSORDER_ACTION_REQUIRED,[MobileRetentionPreviousOrder].[registered_address_his_id] AS MOBILERETENTIONPREVIOUSORDER_REGISTERED_ADDRESS_HIS_ID,[MobileRetentionPreviousOrder].[vas_eff_date] AS MOBILERETENTIONPREVIOUSORDER_VAS_EFF_DATE,[MobileRetentionPreviousOrder].[monthly_bank_account_bank_code] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_BANK_CODE,[MobileRetentionPreviousOrder].[sim_item_number] AS MOBILERETENTIONPREVIOUSORDER_SIM_ITEM_NUMBER,[MobileRetentionPreviousOrder].[special_handling_dummy_code] AS MOBILERETENTIONPREVIOUSORDER_SPECIAL_HANDLING_DUMMY_CODE,[MobileRetentionPreviousOrder].[card_no] AS MOBILERETENTIONPREVIOUSORDER_CARD_NO,[MobileRetentionPreviousOrder].[m_card_exp_year] AS MOBILERETENTIONPREVIOUSORDER_M_CARD_EXP_YEAR,[MobileRetentionPreviousOrder].[bill_medium_email] AS MOBILERETENTIONPREVIOUSORDER_BILL_MEDIUM_EMAIL,[MobileRetentionPreviousOrder].[remarks2PY] AS MOBILERETENTIONPREVIOUSORDER_REMARKS2PY,[MobileRetentionPreviousOrder].[trade_field] AS MOBILERETENTIONPREVIOUSORDER_TRADE_FIELD,[MobileRetentionPreviousOrder].[ord_place_tel] AS MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_TEL,[MobileRetentionPreviousOrder].[action_of_rate_plan_effective] AS MOBILERETENTIONPREVIOUSORDER_ACTION_OF_RATE_PLAN_EFFECTIVE,[MobileRetentionPreviousOrder].[cooling_offer] AS MOBILERETENTIONPREVIOUSORDER_COOLING_OFFER,[MobileRetentionPreviousOrder].[rec_no] AS MOBILERETENTIONPREVIOUSORDER_REC_NO,[MobileRetentionPreviousOrder].[upgrade_handset_offer_rebate_schedule] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_HANDSET_OFFER_REBATE_SCHEDULE,[MobileRetentionPreviousOrder].[change_payment_type] AS MOBILERETENTIONPREVIOUSORDER_CHANGE_PAYMENT_TYPE,[MobileRetentionPreviousOrder].[date_of_birth] AS MOBILERETENTIONPREVIOUSORDER_DATE_OF_BIRTH,[MobileRetentionPreviousOrder].[contact_person] AS MOBILERETENTIONPREVIOUSORDER_CONTACT_PERSON,[MobileRetentionPreviousOrder].[extra_d_charge] AS MOBILERETENTIONPREVIOUSORDER_EXTRA_D_CHARGE,[MobileRetentionPreviousOrder].[tl_name] AS MOBILERETENTIONPREVIOUSORDER_TL_NAME,[MobileRetentionPreviousOrder].[fast_start] AS MOBILERETENTIONPREVIOUSORDER_FAST_START,[MobileRetentionPreviousOrder].[issue_type] AS MOBILERETENTIONPREVIOUSORDER_ISSUE_TYPE,[MobileRetentionPreviousOrder].[sp_ref_no] AS MOBILERETENTIONPREVIOUSORDER_SP_REF_NO,[MobileRetentionPreviousOrder].[edate] AS MOBILERETENTIONPREVIOUSORDER_EDATE,[MobileRetentionPreviousOrder].[exist_cust_plan] AS MOBILERETENTIONPREVIOUSORDER_EXIST_CUST_PLAN,[MobileRetentionPreviousOrder].[ord_place_rel] AS MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_REL,[MobileRetentionPreviousOrder].[mrt_no] AS MOBILERETENTIONPREVIOUSORDER_MRT_NO,[MobileRetentionPreviousOrder].[imei_no] AS MOBILERETENTIONPREVIOUSORDER_IMEI_NO,[MobileRetentionPreviousOrder].[existing_smart_phone_model] AS MOBILERETENTIONPREVIOUSORDER_EXISTING_SMART_PHONE_MODEL,[MobileRetentionPreviousOrder].[bank_code] AS MOBILERETENTIONPREVIOUSORDER_BANK_CODE,[MobileRetentionPreviousOrder].[pos_ref_no] AS MOBILERETENTIONPREVIOUSORDER_POS_REF_NO,[MobileRetentionPreviousOrder].[bill_cut_date] AS MOBILERETENTIONPREVIOUSORDER_BILL_CUT_DATE,[MobileRetentionPreviousOrder].[gift_imei3] AS MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI3,[MobileRetentionPreviousOrder].[exist_plan] AS MOBILERETENTIONPREVIOUSORDER_EXIST_PLAN,[MobileRetentionPreviousOrder].[waive] AS MOBILERETENTIONPREVIOUSORDER_WAIVE,[MobileRetentionPreviousOrder].[program] AS MOBILERETENTIONPREVIOUSORDER_PROGRAM,[MobileRetentionPreviousOrder].[first_month_fee] AS MOBILERETENTIONPREVIOUSORDER_FIRST_MONTH_FEE,[MobileRetentionPreviousOrder].[r_offer] AS MOBILERETENTIONPREVIOUSORDER_R_OFFER,[MobileRetentionPreviousOrder].[cid] AS MOBILERETENTIONPREVIOUSORDER_CID,[MobileRetentionPreviousOrder].[did] AS MOBILERETENTIONPREVIOUSORDER_DID,[MobileRetentionPreviousOrder].[ftg_tenure] AS MOBILERETENTIONPREVIOUSORDER_FTG_TENURE,[MobileRetentionPreviousOrder].[con_per] AS MOBILERETENTIONPREVIOUSORDER_CON_PER,[MobileRetentionPreviousOrder].[gift_code4] AS MOBILERETENTIONPREVIOUSORDER_GIFT_CODE4,[MobileRetentionPreviousOrder].[easywatch_type] AS MOBILERETENTIONPREVIOUSORDER_EASYWATCH_TYPE,[MobileRetentionPreviousOrder].[sms_mrt] AS MOBILERETENTIONPREVIOUSORDER_SMS_MRT,[MobileRetentionPreviousOrder].[tpy_his_id] AS MOBILERETENTIONPREVIOUSORDER_TPY_HIS_ID,[MobileRetentionPreviousOrder].[monthly_payment_method] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_PAYMENT_METHOD,[MobileRetentionPreviousOrder].[remarks2EDF] AS MOBILERETENTIONPREVIOUSORDER_REMARKS2EDF,[MobileRetentionPreviousOrder].[gift_desc3] AS MOBILERETENTIONPREVIOUSORDER_GIFT_DESC3,[MobileRetentionPreviousOrder].[gift_imei4] AS MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI4,[MobileRetentionPreviousOrder].[monthly_bank_account_hkid2] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_HKID2,[MobileRetentionPreviousOrder].[d_date] AS MOBILERETENTIONPREVIOUSORDER_D_DATE,[MobileRetentionPreviousOrder].[gift_desc] AS MOBILERETENTIONPREVIOUSORDER_GIFT_DESC,[MobileRetentionPreviousOrder].[pool] AS MOBILERETENTIONPREVIOUSORDER_POOL,[MobileRetentionPreviousOrder].[cn_mrt_no] AS MOBILERETENTIONPREVIOUSORDER_CN_MRT_NO,[MobileRetentionPreviousOrder].[accessory_imei] AS MOBILERETENTIONPREVIOUSORDER_ACCESSORY_IMEI,[MobileRetentionPreviousOrder].[third_party_credit_card] AS MOBILERETENTIONPREVIOUSORDER_THIRD_PARTY_CREDIT_CARD,[MobileRetentionPreviousOrder].[special_approval] AS MOBILERETENTIONPREVIOUSORDER_SPECIAL_APPROVAL,[MobileRetentionPreviousOrder].[upgrade_existing_contract_edate] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_CONTRACT_EDATE,[MobileRetentionPreviousOrder].[accessory_code] AS MOBILERETENTIONPREVIOUSORDER_ACCESSORY_CODE,[MobileRetentionPreviousOrder].[s_premium] AS MOBILERETENTIONPREVIOUSORDER_S_PREMIUM,[MobileRetentionPreviousOrder].[ref_staff_no] AS MOBILERETENTIONPREVIOUSORDER_REF_STAFF_NO,[MobileRetentionPreviousOrder].[accessory_price] AS MOBILERETENTIONPREVIOUSORDER_ACCESSORY_PRICE,[MobileRetentionPreviousOrder].[m_card_exp_month] AS MOBILERETENTIONPREVIOUSORDER_M_CARD_EXP_MONTH,[MobileRetentionPreviousOrder].[installment_period] AS MOBILERETENTIONPREVIOUSORDER_INSTALLMENT_PERIOD,[MobileRetentionPreviousOrder].[m_card_type] AS MOBILERETENTIONPREVIOUSORDER_M_CARD_TYPE,[MobileRetentionPreviousOrder].[easywatch_ord_id] AS MOBILERETENTIONPREVIOUSORDER_EASYWATCH_ORD_ID,[MobileRetentionPreviousOrder].[normal_rebate] AS MOBILERETENTIONPREVIOUSORDER_NORMAL_REBATE,[MobileRetentionPreviousOrder].[m_rebate_amount] AS MOBILERETENTIONPREVIOUSORDER_M_REBATE_AMOUNT,[MobileRetentionPreviousOrder].[m_card_holder2] AS MOBILERETENTIONPREVIOUSORDER_M_CARD_HOLDER2,[MobileRetentionPreviousOrder].[monthly_bank_account_holder] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_HOLDER,[MobileRetentionPreviousOrder].[active] AS MOBILERETENTIONPREVIOUSORDER_ACTIVE,[MobileRetentionPreviousOrder].[s_premium1] AS MOBILERETENTIONPREVIOUSORDER_S_PREMIUM1,[MobileRetentionPreviousOrder].[card_exp_month] AS MOBILERETENTIONPREVIOUSORDER_CARD_EXP_MONTH,[MobileRetentionPreviousOrder].[ob_program_id] AS MOBILERETENTIONPREVIOUSORDER_OB_PROGRAM_ID,[MobileRetentionPreviousOrder].[sku] AS MOBILERETENTIONPREVIOUSORDER_SKU,[MobileRetentionPreviousOrder].[salesmancode] AS MOBILERETENTIONPREVIOUSORDER_SALESMANCODE,[MobileRetentionPreviousOrder].[go_wireless_package_code] AS MOBILERETENTIONPREVIOUSORDER_GO_WIRELESS_PACKAGE_CODE,[MobileRetentionPreviousOrder].[lob] AS MOBILERETENTIONPREVIOUSORDER_LOB,[MobileRetentionPreviousOrder].[ref_salesmancode] AS MOBILERETENTIONPREVIOUSORDER_REF_SALESMANCODE,[MobileRetentionPreviousOrder].[third_party_hkid] AS MOBILERETENTIONPREVIOUSORDER_THIRD_PARTY_HKID,[MobileRetentionPreviousOrder].[upgrade_existing_pccw_customer] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_PCCW_CUSTOMER,[MobileRetentionPreviousOrder].[d_address] AS MOBILERETENTIONPREVIOUSORDER_D_ADDRESS,[MobileRetentionPreviousOrder].[upgrade_registered_mobile_no] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_REGISTERED_MOBILE_NO,[MobileRetentionPreviousOrder].[gift_code3] AS MOBILERETENTIONPREVIOUSORDER_GIFT_CODE3,[MobileRetentionPreviousOrder].[normal_rebate_type] AS MOBILERETENTIONPREVIOUSORDER_NORMAL_REBATE_TYPE,[MobileRetentionPreviousOrder].[gift_desc2] AS MOBILERETENTIONPREVIOUSORDER_GIFT_DESC2,[MobileRetentionPreviousOrder].[monthly_bank_account_branch_code] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_BRANCH_CODE,[MobileRetentionPreviousOrder].[remarks] AS MOBILERETENTIONPREVIOUSORDER_REMARKS,[MobileRetentionPreviousOrder].[accept] AS MOBILERETENTIONPREVIOUSORDER_ACCEPT,[MobileRetentionPreviousOrder].[delivery_exchange] AS MOBILERETENTIONPREVIOUSORDER_DELIVERY_EXCHANGE,[MobileRetentionPreviousOrder].[gift_code2] AS MOBILERETENTIONPREVIOUSORDER_GIFT_CODE2,[MobileRetentionPreviousOrder].[prepayment_waive] AS MOBILERETENTIONPREVIOUSORDER_PREPAYMENT_WAIVE,[MobileRetentionPreviousOrder].[existing_smart_phone_imei] AS MOBILERETENTIONPREVIOUSORDER_EXISTING_SMART_PHONE_IMEI,[MobileRetentionPreviousOrder].[mnp_his_id] AS MOBILERETENTIONPREVIOUSORDER_MNP_HIS_ID,[MobileRetentionPreviousOrder].[cust_name] AS MOBILERETENTIONPREVIOUSORDER_CUST_NAME,[MobileRetentionPreviousOrder].[upgrade_sponsorships_amount] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_SPONSORSHIPS_AMOUNT,[MobileRetentionPreviousOrder].[bill_medium_waive] AS MOBILERETENTIONPREVIOUSORDER_BILL_MEDIUM_WAIVE,[MobileRetentionPreviousOrder].[delivery_exchange_location] AS MOBILERETENTIONPREVIOUSORDER_DELIVERY_EXCHANGE_LOCATION,[MobileRetentionPreviousOrder].[hs_offer_type_id] AS MOBILERETENTIONPREVIOUSORDER_HS_OFFER_TYPE_ID,[MobileRetentionPreviousOrder].[org_fee] AS MOBILERETENTIONPREVIOUSORDER_ORG_FEE,[MobileRetentionPreviousOrder].[rebate] AS MOBILERETENTIONPREVIOUSORDER_REBATE,[MobileRetentionPreviousOrder].[upgrade_type] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_TYPE,[MobileRetentionPreviousOrder].[go_wireless] AS MOBILERETENTIONPREVIOUSORDER_GO_WIRELESS,[MobileRetentionPreviousOrder].[extra_rebate] AS MOBILERETENTIONPREVIOUSORDER_EXTRA_REBATE,[MobileRetentionPreviousOrder].[plan_eff] AS MOBILERETENTIONPREVIOUSORDER_PLAN_EFF,[MobileRetentionPreviousOrder].[extra_rebate_amount] AS MOBILERETENTIONPREVIOUSORDER_EXTRA_REBATE_AMOUNT,[MobileRetentionPreviousOrder].[card_exp_year] AS MOBILERETENTIONPREVIOUSORDER_CARD_EXP_YEAR,[MobileRetentionPreviousOrder].[upgrade_existing_contract_sdate] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_CONTRACT_SDATE,[MobileRetentionPreviousOrder].[ord_place_hkid] AS MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_HKID,[MobileRetentionPreviousOrder].[register_address] AS MOBILERETENTIONPREVIOUSORDER_REGISTER_ADDRESS,[MobileRetentionPreviousOrder].[gender] AS MOBILERETENTIONPREVIOUSORDER_GENDER,[MobileRetentionPreviousOrder].[lob_ac] AS MOBILERETENTIONPREVIOUSORDER_LOB_AC,[MobileRetentionPreviousOrder].[sim_mrt_no] AS MOBILERETENTIONPREVIOUSORDER_SIM_MRT_NO,[MobileRetentionPreviousOrder].[redemption_notice_option] AS MOBILERETENTIONPREVIOUSORDER_REDEMPTION_NOTICE_OPTION,[MobileRetentionPreviousOrder].[delivery_collection_type] AS MOBILERETENTIONPREVIOUSORDER_DELIVERY_COLLECTION_TYPE,[MobileRetentionPreviousOrder].[action_date] AS MOBILERETENTIONPREVIOUSORDER_ACTION_DATE,[MobileRetentionPreviousOrder].[third_party_id_type] AS MOBILERETENTIONPREVIOUSORDER_THIRD_PARTY_ID_TYPE,[MobileRetentionPreviousOrder].[org_ftg] AS MOBILERETENTIONPREVIOUSORDER_ORG_FTG,[MobileRetentionPreviousOrder].[upgrade_service_tenure] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_SERVICE_TENURE,[MobileRetentionPreviousOrder].[monthly_payment_type] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_PAYMENT_TYPE,[MobileRetentionPreviousOrder].[contact_no] AS MOBILERETENTIONPREVIOUSORDER_CONTACT_NO,[MobileRetentionPreviousOrder].[org_mrt] AS MOBILERETENTIONPREVIOUSORDER_ORG_MRT,[MobileRetentionPreviousOrder].[sim_item_name] AS MOBILERETENTIONPREVIOUSORDER_SIM_ITEM_NAME,[MobileRetentionPreviousOrder].[pay_method] AS MOBILERETENTIONPREVIOUSORDER_PAY_METHOD,[MobileRetentionPreviousOrder].[hs_model] AS MOBILERETENTIONPREVIOUSORDER_HS_MODEL,[MobileRetentionPreviousOrder].[gift_code] AS MOBILERETENTIONPREVIOUSORDER_GIFT_CODE,[MobileRetentionPreviousOrder].[monthly_bank_account_hkid] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_HKID,[MobileRetentionPreviousOrder].[extra_offer] AS MOBILERETENTIONPREVIOUSORDER_EXTRA_OFFER,[MobileRetentionPreviousOrder].[monthly_bank_account_no] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_NO,[MobileRetentionPreviousOrder].[first_month_license_fee] AS MOBILERETENTIONPREVIOUSORDER_FIRST_MONTH_LICENSE_FEE,[MobileRetentionPreviousOrder].[retrieve_cnt] AS MOBILERETENTIONPREVIOUSORDER_RETRIEVE_CNT,[MobileRetentionPreviousOrder].[ddate] AS MOBILERETENTIONPREVIOUSORDER_DDATE,[MobileRetentionPreviousOrder].[s_premium2] AS MOBILERETENTIONPREVIOUSORDER_S_PREMIUM2,[MobileRetentionPreviousOrder].[monthly_bank_account_id_type] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_ID_TYPE,[MobileRetentionPreviousOrder].[card_type] AS MOBILERETENTIONPREVIOUSORDER_CARD_TYPE,[MobileRetentionPreviousOrder].[next_bill] AS MOBILERETENTIONPREVIOUSORDER_NEXT_BILL,[MobileRetentionPreviousOrder].[pcd_paid_go_wireless] AS MOBILERETENTIONPREVIOUSORDER_PCD_PAID_GO_WIRELESS,[MobileRetentionPreviousOrder].[upgrade_rebate_calculation] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_REBATE_CALCULATION,[MobileRetentionPreviousOrder].[ext_place_tel] AS MOBILERETENTIONPREVIOUSORDER_EXT_PLACE_TEL,[MobileRetentionPreviousOrder].[m_3rd_hkid] AS MOBILERETENTIONPREVIOUSORDER_M_3RD_HKID,[MobileRetentionPreviousOrder].[retention_type] AS MOBILERETENTIONPREVIOUSORDER_RETENTION_TYPE,[MobileRetentionPreviousOrder].[bill_address_his_id] AS MOBILERETENTIONPREVIOUSORDER_BILL_ADDRESS_HIS_ID,[MobileRetentionPreviousOrder].[aig_gift] AS MOBILERETENTIONPREVIOUSORDER_AIG_GIFT,[MobileRetentionPreviousOrder].[cust_staff_no] AS MOBILERETENTIONPREVIOUSORDER_CUST_STAFF_NO,[MobileRetentionPreviousOrder].[order_id] AS MOBILERETENTIONPREVIOUSORDER_ORDER_ID,[MobileRetentionPreviousOrder].[family_name] AS MOBILERETENTIONPREVIOUSORDER_FAMILY_NAME,[MobileRetentionPreviousOrder].[cdate] AS MOBILERETENTIONPREVIOUSORDER_CDATE,[MobileRetentionPreviousOrder].[status_by_cs_admin] AS MOBILERETENTIONPREVIOUSORDER_STATUS_BY_CS_ADMIN,[MobileRetentionPreviousOrder].[given_name] AS MOBILERETENTIONPREVIOUSORDER_GIVEN_NAME,[MobileRetentionPreviousOrder].[vip_case] AS MOBILERETENTIONPREVIOUSORDER_VIP_CASE,[MobileRetentionPreviousOrder].[s_premium3] AS MOBILERETENTIONPREVIOUSORDER_S_PREMIUM3,[MobileRetentionPreviousOrder].[log_date] AS MOBILERETENTIONPREVIOUSORDER_LOG_DATE,[MobileRetentionPreviousOrder].[extn] AS MOBILERETENTIONPREVIOUSORDER_EXTN,[MobileRetentionPreviousOrder].[d_time] AS MOBILERETENTIONPREVIOUSORDER_D_TIME,[MobileRetentionPreviousOrder].[bank_name] AS MOBILERETENTIONPREVIOUSORDER_BANK_NAME,[MobileRetentionPreviousOrder].[delivery_exchange_option] AS MOBILERETENTIONPREVIOUSORDER_DELIVERY_EXCHANGE_OPTION,[MobileRetentionPreviousOrder].[upgrade_service_account_no] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_SERVICE_ACCOUNT_NO,[MobileRetentionPreviousOrder].[old_ord_id] AS MOBILERETENTIONPREVIOUSORDER_OLD_ORD_ID,[MobileRetentionPreviousOrder].[m_card_no] AS MOBILERETENTIONPREVIOUSORDER_M_CARD_NO,[MobileRetentionPreviousOrder].[existing_contract_end_date] AS MOBILERETENTIONPREVIOUSORDER_EXISTING_CONTRACT_END_DATE,[MobileRetentionPreviousOrder].[con_eff_date] AS MOBILERETENTIONPREVIOUSORDER_CON_EFF_DATE,[MobileRetentionPreviousOrder].[m_3rd_hkid2] AS MOBILERETENTIONPREVIOUSORDER_M_3RD_HKID2,[MobileRetentionPreviousOrder].[amount] AS MOBILERETENTIONPREVIOUSORDER_AMOUNT,[MobileRetentionPreviousOrder].[m_3rd_id_type] AS MOBILERETENTIONPREVIOUSORDER_M_3RD_ID_TYPE,[MobileRetentionPreviousOrder].[id_type] AS MOBILERETENTIONPREVIOUSORDER_ID_TYPE,[MobileRetentionPreviousOrder].[rate_plan] AS MOBILERETENTIONPREVIOUSORDER_RATE_PLAN,[MobileRetentionPreviousOrder].[channel] AS MOBILERETENTIONPREVIOUSORDER_CHANNEL,[MobileRetentionPreviousOrder].[action_eff_date] AS MOBILERETENTIONPREVIOUSORDER_ACTION_EFF_DATE,[MobileRetentionPreviousOrder].[cooling_date] AS MOBILERETENTIONPREVIOUSORDER_COOLING_DATE,[MobileRetentionPreviousOrder].[free_mon] AS MOBILERETENTIONPREVIOUSORDER_FREE_MON,[MobileRetentionPreviousOrder].[plan_eff_date] AS MOBILERETENTIONPREVIOUSORDER_PLAN_EFF_DATE,[MobileRetentionPreviousOrder].[teamcode] AS MOBILERETENTIONPREVIOUSORDER_TEAMCODE,[MobileRetentionPreviousOrder].[bill_medium] AS MOBILERETENTIONPREVIOUSORDER_BILL_MEDIUM,[MobileRetentionPreviousOrder].[edf_no] AS MOBILERETENTIONPREVIOUSORDER_EDF_NO,[MobileRetentionPreviousOrder].[ord_place_by] AS MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_BY,[MobileRetentionPreviousOrder].[cancel_renew] AS MOBILERETENTIONPREVIOUSORDER_CANCEL_RENEW,[MobileRetentionPreviousOrder].[preferred_languages] AS MOBILERETENTIONPREVIOUSORDER_PREFERRED_LANGUAGES,[MobileRetentionPreviousOrder].[hkid] AS MOBILERETENTIONPREVIOUSORDER_HKID,[MobileRetentionPreviousOrder].[card_holder] AS MOBILERETENTIONPREVIOUSORDER_CARD_HOLDER,[MobileRetentionPreviousOrder].[ac_no] AS MOBILERETENTIONPREVIOUSORDER_AC_NO,[MobileRetentionPreviousOrder].[bill_cut_num] AS MOBILERETENTIONPREVIOUSORDER_BILL_CUT_NUM,[MobileRetentionPreviousOrder].[premium] AS MOBILERETENTIONPREVIOUSORDER_PREMIUM,[MobileRetentionPreviousOrder].[del_remark] AS MOBILERETENTIONPREVIOUSORDER_DEL_REMARK,[MobileRetentionPreviousOrder].[gift_imei2] AS MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI2,[MobileRetentionPreviousOrder].[reasons] AS MOBILERETENTIONPREVIOUSORDER_REASONS,[MobileRetentionPreviousOrder].[language] AS MOBILERETENTIONPREVIOUSORDER_LANGUAGE,[MobileRetentionPreviousOrder].[rebate_amount] AS MOBILERETENTIONPREVIOUSORDER_REBATE_AMOUNT,[MobileRetentionPreviousOrder].[ord_place_id_type] AS MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_ID_TYPE,[MobileRetentionPreviousOrder].[m_3rd_contact_no] AS MOBILERETENTIONPREVIOUSORDER_M_3RD_CONTACT_NO,[MobileRetentionPreviousOrder].[staff_no] AS MOBILERETENTIONPREVIOUSORDER_STAFF_NO,[MobileRetentionPreviousOrder].[sp_d_date] AS MOBILERETENTIONPREVIOUSORDER_SP_D_DATE,[MobileRetentionPreviousOrder].[bundle_name] AS MOBILERETENTIONPREVIOUSORDER_BUNDLE_NAME,[MobileRetentionPreviousOrder].[accessory_waive] AS MOBILERETENTIONPREVIOUSORDER_ACCESSORY_WAIVE,[MobileRetentionPreviousOrder].[sim_item_code] AS MOBILERETENTIONPREVIOUSORDER_SIM_ITEM_CODE,[MobileRetentionPreviousOrder].[cust_type] AS MOBILERETENTIONPREVIOUSORDER_CUST_TYPE,[MobileRetentionPreviousOrder].[card_ref_no] AS MOBILERETENTIONPREVIOUSORDER_CARD_REF_NO  FROM  [MobileRetentionPreviousOrder]  WHERE  [MobileRetentionPreviousOrder].[order_id] = \'"+x_iOrder_id.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionPreviousOrder]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionPreviousOrder]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_imei).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_imei).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_imei).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_imei).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium4).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_S_PREMIUM4"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium4).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium4).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_S_PREMIUM4"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium4).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_existing_customer_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_CUSTOMER_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_existing_customer_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_existing_customer_type).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_CUSTOMER_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_existing_customer_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_desc4).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_DESC4"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_desc4).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_desc4).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_DESC4"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_desc4).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_desc).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ACCESSORY_DESC"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_desc).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_desc).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ACCESSORY_DESC"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_desc).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.staff_name).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_STAFF_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.staff_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.staff_name).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_STAFF_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.staff_name).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.action_required).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ACTION_REQUIRED"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.action_required).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.action_required).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ACTION_REQUIRED"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.action_required).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.registered_address_his_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REGISTERED_ADDRESS_HIS_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.registered_address_his_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.registered_address_his_id).AliasName].ToString()] = (global::System.Nullable<long>)_oData["MOBILERETENTIONPREVIOUSORDER_REGISTERED_ADDRESS_HIS_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.registered_address_his_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.vas_eff_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_VAS_EFF_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.vas_eff_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.vas_eff_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_VAS_EFF_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.vas_eff_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_bank_code).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_BANK_CODE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_bank_code).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_bank_code).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_BANK_CODE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_bank_code).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sim_item_number).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_SIM_ITEM_NUMBER"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sim_item_number).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sim_item_number).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_SIM_ITEM_NUMBER"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sim_item_number).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.special_handling_dummy_code).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_SPECIAL_HANDLING_DUMMY_CODE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.special_handling_dummy_code).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.special_handling_dummy_code).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_SPECIAL_HANDLING_DUMMY_CODE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.special_handling_dummy_code).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CARD_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_no).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CARD_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_exp_year).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_M_CARD_EXP_YEAR"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_exp_year).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_exp_year).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_M_CARD_EXP_YEAR"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_exp_year).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_medium_email).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_BILL_MEDIUM_EMAIL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_medium_email).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_medium_email).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_BILL_MEDIUM_EMAIL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_medium_email).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.remarks2PY).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REMARKS2PY"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.remarks2PY).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.remarks2PY).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_REMARKS2PY"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.remarks2PY).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.trade_field).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_TRADE_FIELD"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.trade_field).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.trade_field).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_TRADE_FIELD"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.trade_field).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_tel).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_TEL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_tel).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_tel).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_TEL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_tel).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.action_of_rate_plan_effective).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ACTION_OF_RATE_PLAN_EFFECTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.action_of_rate_plan_effective).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.action_of_rate_plan_effective).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ACTION_OF_RATE_PLAN_EFFECTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.action_of_rate_plan_effective).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cooling_offer).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_COOLING_OFFER"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cooling_offer).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cooling_offer).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_COOLING_OFFER"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cooling_offer).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.rec_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REC_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.rec_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.rec_no).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILERETENTIONPREVIOUSORDER_REC_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.rec_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_handset_offer_rebate_schedule).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_HANDSET_OFFER_REBATE_SCHEDULE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_handset_offer_rebate_schedule).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_handset_offer_rebate_schedule).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_HANDSET_OFFER_REBATE_SCHEDULE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_handset_offer_rebate_schedule).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.change_payment_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CHANGE_PAYMENT_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.change_payment_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.change_payment_type).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CHANGE_PAYMENT_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.change_payment_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.date_of_birth).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_DATE_OF_BIRTH"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.date_of_birth).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.date_of_birth).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_DATE_OF_BIRTH"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.date_of_birth).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.contact_person).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CONTACT_PERSON"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.contact_person).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.contact_person).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CONTACT_PERSON"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.contact_person).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extra_d_charge).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EXTRA_D_CHARGE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extra_d_charge).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extra_d_charge).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EXTRA_D_CHARGE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extra_d_charge).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.tl_name).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_TL_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.tl_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.tl_name).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_TL_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.tl_name).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.fast_start).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_FAST_START"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.fast_start).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.fast_start).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILERETENTIONPREVIOUSORDER_FAST_START"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.fast_start).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.issue_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ISSUE_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.issue_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.issue_type).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ISSUE_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.issue_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sp_ref_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_SP_REF_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sp_ref_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sp_ref_no).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_SP_REF_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sp_ref_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.edate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.edate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.edate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_EDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.edate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.exist_cust_plan).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EXIST_CUST_PLAN"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.exist_cust_plan).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.exist_cust_plan).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EXIST_CUST_PLAN"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.exist_cust_plan).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_rel).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_REL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_rel).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_rel).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_REL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_rel).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.mrt_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_MRT_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.mrt_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.mrt_no).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILERETENTIONPREVIOUSORDER_MRT_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.mrt_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.imei_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_IMEI_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.imei_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.imei_no).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_IMEI_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.imei_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.existing_smart_phone_model).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EXISTING_SMART_PHONE_MODEL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.existing_smart_phone_model).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.existing_smart_phone_model).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EXISTING_SMART_PHONE_MODEL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.existing_smart_phone_model).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bank_code).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_BANK_CODE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bank_code).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bank_code).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_BANK_CODE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bank_code).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.pos_ref_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_POS_REF_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.pos_ref_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.pos_ref_no).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_POS_REF_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.pos_ref_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_cut_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_BILL_CUT_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_cut_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_cut_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_BILL_CUT_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_cut_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_imei3).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI3"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_imei3).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_imei3).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI3"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_imei3).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.exist_plan).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EXIST_PLAN"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.exist_plan).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.exist_plan).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EXIST_PLAN"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.exist_plan).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.waive).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_WAIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.waive).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.waive).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILERETENTIONPREVIOUSORDER_WAIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.waive).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.program).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_PROGRAM"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.program).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.program).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_PROGRAM"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.program).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.first_month_fee).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_FIRST_MONTH_FEE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.first_month_fee).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.first_month_fee).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_FIRST_MONTH_FEE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.first_month_fee).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.r_offer).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_R_OFFER"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.r_offer).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.r_offer).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_R_OFFER"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.r_offer).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cid).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.did).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.did).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.did).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ftg_tenure).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_FTG_TENURE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ftg_tenure).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ftg_tenure).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_FTG_TENURE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ftg_tenure).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.con_per).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CON_PER"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.con_per).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.con_per).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CON_PER"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.con_per).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_code4).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_CODE4"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_code4).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_code4).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_CODE4"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_code4).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.easywatch_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EASYWATCH_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.easywatch_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.easywatch_type).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EASYWATCH_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.easywatch_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sms_mrt).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_SMS_MRT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sms_mrt).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sms_mrt).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_SMS_MRT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sms_mrt).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.tpy_his_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_TPY_HIS_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.tpy_his_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.tpy_his_id).AliasName].ToString()] = (global::System.Nullable<long>)_oData["MOBILERETENTIONPREVIOUSORDER_TPY_HIS_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.tpy_his_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_payment_method).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_PAYMENT_METHOD"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_payment_method).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_payment_method).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_PAYMENT_METHOD"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_payment_method).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.remarks2EDF).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REMARKS2EDF"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.remarks2EDF).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.remarks2EDF).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_REMARKS2EDF"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.remarks2EDF).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_desc3).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_DESC3"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_desc3).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_desc3).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_DESC3"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_desc3).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_imei4).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI4"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_imei4).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_imei4).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI4"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_imei4).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_hkid2).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_HKID2"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_hkid2).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_hkid2).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_HKID2"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_hkid2).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.d_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_D_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.d_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.d_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_D_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.d_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_desc).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_DESC"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_desc).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_desc).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_DESC"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_desc).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.pool).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_POOL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.pool).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.pool).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_POOL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.pool).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cn_mrt_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CN_MRT_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cn_mrt_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cn_mrt_no).AliasName].ToString()] = (global::System.Nullable<long>)_oData["MOBILERETENTIONPREVIOUSORDER_CN_MRT_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cn_mrt_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_imei).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ACCESSORY_IMEI"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_imei).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_imei).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ACCESSORY_IMEI"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_imei).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.third_party_credit_card).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_THIRD_PARTY_CREDIT_CARD"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.third_party_credit_card).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.third_party_credit_card).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_THIRD_PARTY_CREDIT_CARD"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.third_party_credit_card).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.special_approval).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_SPECIAL_APPROVAL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.special_approval).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.special_approval).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_SPECIAL_APPROVAL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.special_approval).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_existing_contract_edate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_CONTRACT_EDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_existing_contract_edate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_existing_contract_edate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_CONTRACT_EDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_existing_contract_edate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_code).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ACCESSORY_CODE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_code).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_code).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ACCESSORY_CODE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_code).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_S_PREMIUM"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_S_PREMIUM"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ref_staff_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REF_STAFF_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ref_staff_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ref_staff_no).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_REF_STAFF_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ref_staff_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_price).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ACCESSORY_PRICE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_price).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_price).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ACCESSORY_PRICE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_price).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_exp_month).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_M_CARD_EXP_MONTH"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_exp_month).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_exp_month).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_M_CARD_EXP_MONTH"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_exp_month).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.installment_period).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_INSTALLMENT_PERIOD"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.installment_period).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.installment_period).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_INSTALLMENT_PERIOD"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.installment_period).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_M_CARD_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_type).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_M_CARD_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.easywatch_ord_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EASYWATCH_ORD_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.easywatch_ord_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.easywatch_ord_id).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EASYWATCH_ORD_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.easywatch_ord_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.normal_rebate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_NORMAL_REBATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.normal_rebate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.normal_rebate).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILERETENTIONPREVIOUSORDER_NORMAL_REBATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.normal_rebate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_rebate_amount).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_M_REBATE_AMOUNT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_rebate_amount).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_rebate_amount).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_M_REBATE_AMOUNT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_rebate_amount).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_holder2).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_M_CARD_HOLDER2"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_holder2).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_holder2).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_M_CARD_HOLDER2"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_holder2).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_holder).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_HOLDER"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_holder).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_holder).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_HOLDER"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_holder).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILERETENTIONPREVIOUSORDER_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium1).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_S_PREMIUM1"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium1).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium1).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_S_PREMIUM1"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium1).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_exp_month).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CARD_EXP_MONTH"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_exp_month).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_exp_month).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CARD_EXP_MONTH"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_exp_month).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ob_program_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_OB_PROGRAM_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ob_program_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ob_program_id).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_OB_PROGRAM_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ob_program_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sku).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_SKU"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sku).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sku).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_SKU"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sku).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.salesmancode).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_SALESMANCODE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.salesmancode).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.salesmancode).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_SALESMANCODE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.salesmancode).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.go_wireless_package_code).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GO_WIRELESS_PACKAGE_CODE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.go_wireless_package_code).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.go_wireless_package_code).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GO_WIRELESS_PACKAGE_CODE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.go_wireless_package_code).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.lob).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_LOB"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.lob).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.lob).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_LOB"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.lob).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ref_salesmancode).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REF_SALESMANCODE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ref_salesmancode).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ref_salesmancode).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_REF_SALESMANCODE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ref_salesmancode).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.third_party_hkid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_THIRD_PARTY_HKID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.third_party_hkid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.third_party_hkid).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_THIRD_PARTY_HKID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.third_party_hkid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_existing_pccw_customer).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_PCCW_CUSTOMER"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_existing_pccw_customer).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_existing_pccw_customer).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_PCCW_CUSTOMER"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_existing_pccw_customer).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.d_address).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_D_ADDRESS"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.d_address).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.d_address).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_D_ADDRESS"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.d_address).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_registered_mobile_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_REGISTERED_MOBILE_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_registered_mobile_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_registered_mobile_no).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_REGISTERED_MOBILE_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_registered_mobile_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_code3).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_CODE3"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_code3).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_code3).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_CODE3"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_code3).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.normal_rebate_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_NORMAL_REBATE_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.normal_rebate_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.normal_rebate_type).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_NORMAL_REBATE_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.normal_rebate_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_desc2).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_DESC2"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_desc2).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_desc2).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_DESC2"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_desc2).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_branch_code).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_BRANCH_CODE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_branch_code).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_branch_code).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_BRANCH_CODE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_branch_code).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.remarks).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REMARKS"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.remarks).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.remarks).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_REMARKS"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.remarks).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accept).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ACCEPT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accept).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accept).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ACCEPT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accept).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.delivery_exchange).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_DELIVERY_EXCHANGE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.delivery_exchange).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.delivery_exchange).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_DELIVERY_EXCHANGE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.delivery_exchange).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_code2).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_CODE2"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_code2).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_code2).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_CODE2"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_code2).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.prepayment_waive).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_PREPAYMENT_WAIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.prepayment_waive).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.prepayment_waive).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILERETENTIONPREVIOUSORDER_PREPAYMENT_WAIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.prepayment_waive).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.existing_smart_phone_imei).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EXISTING_SMART_PHONE_IMEI"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.existing_smart_phone_imei).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.existing_smart_phone_imei).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EXISTING_SMART_PHONE_IMEI"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.existing_smart_phone_imei).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.mnp_his_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_MNP_HIS_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.mnp_his_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.mnp_his_id).AliasName].ToString()] = (global::System.Nullable<long>)_oData["MOBILERETENTIONPREVIOUSORDER_MNP_HIS_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.mnp_his_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cust_name).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CUST_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cust_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cust_name).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CUST_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cust_name).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_sponsorships_amount).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_SPONSORSHIPS_AMOUNT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_sponsorships_amount).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_sponsorships_amount).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_SPONSORSHIPS_AMOUNT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_sponsorships_amount).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_medium_waive).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_BILL_MEDIUM_WAIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_medium_waive).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_medium_waive).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILERETENTIONPREVIOUSORDER_BILL_MEDIUM_WAIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_medium_waive).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.delivery_exchange_location).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_DELIVERY_EXCHANGE_LOCATION"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.delivery_exchange_location).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.delivery_exchange_location).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_DELIVERY_EXCHANGE_LOCATION"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.delivery_exchange_location).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.hs_offer_type_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_HS_OFFER_TYPE_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.hs_offer_type_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.hs_offer_type_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILERETENTIONPREVIOUSORDER_HS_OFFER_TYPE_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.hs_offer_type_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.org_fee).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ORG_FEE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.org_fee).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.org_fee).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ORG_FEE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.org_fee).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.rebate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REBATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.rebate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.rebate).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_REBATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.rebate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_type).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.go_wireless).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GO_WIRELESS"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.go_wireless).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.go_wireless).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GO_WIRELESS"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.go_wireless).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extra_rebate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EXTRA_REBATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extra_rebate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extra_rebate).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EXTRA_REBATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extra_rebate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.plan_eff).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_PLAN_EFF"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.plan_eff).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.plan_eff).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_PLAN_EFF"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.plan_eff).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extra_rebate_amount).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EXTRA_REBATE_AMOUNT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extra_rebate_amount).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extra_rebate_amount).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EXTRA_REBATE_AMOUNT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extra_rebate_amount).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_exp_year).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CARD_EXP_YEAR"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_exp_year).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_exp_year).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CARD_EXP_YEAR"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_exp_year).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_existing_contract_sdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_CONTRACT_SDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_existing_contract_sdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_existing_contract_sdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_CONTRACT_SDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_existing_contract_sdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_hkid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_HKID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_hkid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_hkid).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_HKID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_hkid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.register_address).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REGISTER_ADDRESS"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.register_address).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.register_address).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_REGISTER_ADDRESS"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.register_address).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gender).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GENDER"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gender).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gender).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GENDER"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gender).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.lob_ac).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_LOB_AC"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.lob_ac).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.lob_ac).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_LOB_AC"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.lob_ac).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sim_mrt_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_SIM_MRT_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sim_mrt_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sim_mrt_no).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILERETENTIONPREVIOUSORDER_SIM_MRT_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sim_mrt_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.redemption_notice_option).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REDEMPTION_NOTICE_OPTION"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.redemption_notice_option).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.redemption_notice_option).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_REDEMPTION_NOTICE_OPTION"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.redemption_notice_option).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.delivery_collection_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_DELIVERY_COLLECTION_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.delivery_collection_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.delivery_collection_type).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_DELIVERY_COLLECTION_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.delivery_collection_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.action_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ACTION_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.action_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.action_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_ACTION_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.action_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.third_party_id_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_THIRD_PARTY_ID_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.third_party_id_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.third_party_id_type).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_THIRD_PARTY_ID_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.third_party_id_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.org_ftg).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ORG_FTG"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.org_ftg).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.org_ftg).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ORG_FTG"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.org_ftg).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_service_tenure).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_SERVICE_TENURE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_service_tenure).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_service_tenure).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_SERVICE_TENURE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_service_tenure).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_payment_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_PAYMENT_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_payment_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_payment_type).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_PAYMENT_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_payment_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.contact_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CONTACT_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.contact_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.contact_no).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CONTACT_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.contact_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.org_mrt).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ORG_MRT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.org_mrt).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.org_mrt).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILERETENTIONPREVIOUSORDER_ORG_MRT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.org_mrt).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sim_item_name).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_SIM_ITEM_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sim_item_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sim_item_name).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_SIM_ITEM_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sim_item_name).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.pay_method).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_PAY_METHOD"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.pay_method).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.pay_method).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_PAY_METHOD"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.pay_method).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.hs_model).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_HS_MODEL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.hs_model).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.hs_model).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_HS_MODEL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.hs_model).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_code).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_CODE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_code).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_code).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_CODE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_code).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_hkid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_HKID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_hkid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_hkid).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_HKID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_hkid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extra_offer).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EXTRA_OFFER"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extra_offer).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extra_offer).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EXTRA_OFFER"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extra_offer).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_no).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.first_month_license_fee).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_FIRST_MONTH_LICENSE_FEE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.first_month_license_fee).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.first_month_license_fee).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_FIRST_MONTH_LICENSE_FEE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.first_month_license_fee).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.retrieve_cnt).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_RETRIEVE_CNT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.retrieve_cnt).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.retrieve_cnt).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILERETENTIONPREVIOUSORDER_RETRIEVE_CNT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.retrieve_cnt).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ddate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ddate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium2).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_S_PREMIUM2"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium2).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium2).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_S_PREMIUM2"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium2).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_id_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_ID_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_id_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_id_type).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_ID_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_id_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CARD_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_type).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CARD_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.next_bill).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_NEXT_BILL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.next_bill).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.next_bill).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILERETENTIONPREVIOUSORDER_NEXT_BILL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.next_bill).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.pcd_paid_go_wireless).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_PCD_PAID_GO_WIRELESS"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.pcd_paid_go_wireless).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.pcd_paid_go_wireless).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILERETENTIONPREVIOUSORDER_PCD_PAID_GO_WIRELESS"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.pcd_paid_go_wireless).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_rebate_calculation).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_REBATE_CALCULATION"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_rebate_calculation).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_rebate_calculation).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_REBATE_CALCULATION"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_rebate_calculation).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ext_place_tel).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EXT_PLACE_TEL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ext_place_tel).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ext_place_tel).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EXT_PLACE_TEL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ext_place_tel).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_3rd_hkid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_M_3RD_HKID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_3rd_hkid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_3rd_hkid).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_M_3RD_HKID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_3rd_hkid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.retention_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_RETENTION_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.retention_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.retention_type).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_RETENTION_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.retention_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_address_his_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_BILL_ADDRESS_HIS_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_address_his_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_address_his_id).AliasName].ToString()] = (global::System.Nullable<long>)_oData["MOBILERETENTIONPREVIOUSORDER_BILL_ADDRESS_HIS_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_address_his_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.aig_gift).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_AIG_GIFT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.aig_gift).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.aig_gift).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_AIG_GIFT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.aig_gift).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cust_staff_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CUST_STAFF_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cust_staff_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cust_staff_no).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CUST_STAFF_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cust_staff_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.order_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ORDER_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.order_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.order_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILERETENTIONPREVIOUSORDER_ORDER_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.order_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.family_name).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_FAMILY_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.family_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.family_name).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_FAMILY_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.family_name).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.status_by_cs_admin).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_STATUS_BY_CS_ADMIN"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.status_by_cs_admin).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.status_by_cs_admin).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_STATUS_BY_CS_ADMIN"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.status_by_cs_admin).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.given_name).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIVEN_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.given_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.given_name).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIVEN_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.given_name).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.vip_case).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_VIP_CASE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.vip_case).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.vip_case).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_VIP_CASE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.vip_case).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium3).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_S_PREMIUM3"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium3).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium3).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_S_PREMIUM3"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium3).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.log_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_LOG_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.log_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.log_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_LOG_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.log_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extn).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EXTN"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extn).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extn).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EXTN"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extn).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.d_time).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_D_TIME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.d_time).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.d_time).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_D_TIME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.d_time).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bank_name).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_BANK_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bank_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bank_name).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_BANK_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bank_name).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.delivery_exchange_option).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_DELIVERY_EXCHANGE_OPTION"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.delivery_exchange_option).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.delivery_exchange_option).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_DELIVERY_EXCHANGE_OPTION"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.delivery_exchange_option).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_service_account_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_SERVICE_ACCOUNT_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_service_account_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_service_account_no).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_SERVICE_ACCOUNT_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_service_account_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.old_ord_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_OLD_ORD_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.old_ord_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.old_ord_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILERETENTIONPREVIOUSORDER_OLD_ORD_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.old_ord_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_M_CARD_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_no).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_M_CARD_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.existing_contract_end_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EXISTING_CONTRACT_END_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.existing_contract_end_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.existing_contract_end_date).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EXISTING_CONTRACT_END_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.existing_contract_end_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.con_eff_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CON_EFF_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.con_eff_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.con_eff_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_CON_EFF_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.con_eff_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_3rd_hkid2).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_M_3RD_HKID2"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_3rd_hkid2).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_3rd_hkid2).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_M_3RD_HKID2"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_3rd_hkid2).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.amount).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_AMOUNT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.amount).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.amount).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_AMOUNT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.amount).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_3rd_id_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_M_3RD_ID_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_3rd_id_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_3rd_id_type).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_M_3RD_ID_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_3rd_id_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.id_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ID_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.id_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.id_type).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ID_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.id_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.rate_plan).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_RATE_PLAN"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.rate_plan).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.rate_plan).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_RATE_PLAN"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.rate_plan).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.channel).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CHANNEL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.channel).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.channel).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CHANNEL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.channel).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.action_eff_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ACTION_EFF_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.action_eff_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.action_eff_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_ACTION_EFF_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.action_eff_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cooling_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_COOLING_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cooling_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cooling_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_COOLING_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cooling_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.free_mon).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_FREE_MON"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.free_mon).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.free_mon).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_FREE_MON"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.free_mon).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.plan_eff_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_PLAN_EFF_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.plan_eff_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.plan_eff_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_PLAN_EFF_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.plan_eff_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.teamcode).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_TEAMCODE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.teamcode).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.teamcode).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_TEAMCODE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.teamcode).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_medium).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_BILL_MEDIUM"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_medium).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_medium).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_BILL_MEDIUM"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_medium).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.edf_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EDF_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.edf_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.edf_no).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EDF_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.edf_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_by).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_BY"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_by).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_by).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_BY"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_by).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cancel_renew).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CANCEL_RENEW"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cancel_renew).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cancel_renew).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CANCEL_RENEW"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cancel_renew).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.preferred_languages).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_PREFERRED_LANGUAGES"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.preferred_languages).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.preferred_languages).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_PREFERRED_LANGUAGES"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.preferred_languages).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.hkid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_HKID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.hkid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.hkid).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_HKID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.hkid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_holder).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CARD_HOLDER"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_holder).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_holder).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CARD_HOLDER"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_holder).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ac_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_AC_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ac_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ac_no).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_AC_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ac_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_cut_num).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_BILL_CUT_NUM"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_cut_num).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_cut_num).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILERETENTIONPREVIOUSORDER_BILL_CUT_NUM"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_cut_num).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.premium).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_PREMIUM"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.premium).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.premium).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_PREMIUM"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.premium).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.del_remark).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_DEL_REMARK"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.del_remark).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.del_remark).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_DEL_REMARK"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.del_remark).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_imei2).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI2"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_imei2).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_imei2).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI2"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_imei2).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.reasons).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REASONS"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.reasons).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.reasons).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_REASONS"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.reasons).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.language).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_LANGUAGE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.language).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.language).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_LANGUAGE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.language).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.rebate_amount).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REBATE_AMOUNT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.rebate_amount).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.rebate_amount).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_REBATE_AMOUNT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.rebate_amount).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_id_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_ID_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_id_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_id_type).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_ID_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_id_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_3rd_contact_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_M_3RD_CONTACT_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_3rd_contact_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_3rd_contact_no).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_M_3RD_CONTACT_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_3rd_contact_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.staff_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_STAFF_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.staff_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.staff_no).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_STAFF_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.staff_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sp_d_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_SP_D_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sp_d_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sp_d_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_SP_D_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sp_d_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bundle_name).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_BUNDLE_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bundle_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bundle_name).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_BUNDLE_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bundle_name).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_waive).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ACCESSORY_WAIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_waive).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_waive).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILERETENTIONPREVIOUSORDER_ACCESSORY_WAIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_waive).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sim_item_code).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_SIM_ITEM_CODE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sim_item_code).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sim_item_code).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_SIM_ITEM_CODE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sim_item_code).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cust_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CUST_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cust_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cust_type).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CUST_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cust_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_ref_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CARD_REF_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_ref_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_ref_no).AliasName].ToString()] = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CARD_REF_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_ref_no).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,MobileRetentionPreviousOrder x_oMobileRetentionPreviousOrderRow)
        {
            return SetByDataSetRowProc(x_iROW, MobileRetentionPreviousOrder.Para.TableName(), x_oDataSet,x_oMobileRetentionPreviousOrderRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileRetentionPreviousOrder x_oMobileRetentionPreviousOrderRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oMobileRetentionPreviousOrderRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileRetentionPreviousOrder x_oMobileRetentionPreviousOrderRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                MobileRetentionPreviousOrderInfo _oTableSet=MobileRetentionPreviousOrderInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_imei).AliasName))
                    x_oMobileRetentionPreviousOrderRow.gift_imei = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_imei).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium4).AliasName))
                    x_oMobileRetentionPreviousOrderRow.s_premium4 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium4).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_desc4).AliasName))
                    x_oMobileRetentionPreviousOrderRow.gift_desc4 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_desc4).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_desc).AliasName))
                    x_oMobileRetentionPreviousOrderRow.accessory_desc = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_desc).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.action_required).AliasName))
                    x_oMobileRetentionPreviousOrderRow.action_required = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.action_required).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.registered_address_his_id).AliasName))
                    x_oMobileRetentionPreviousOrderRow.registered_address_his_id = (global::System.Nullable<long>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.registered_address_his_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.vas_eff_date).AliasName))
                    x_oMobileRetentionPreviousOrderRow.vas_eff_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.vas_eff_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_bank_code).AliasName))
                    x_oMobileRetentionPreviousOrderRow.monthly_bank_account_bank_code = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_bank_code).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.special_handling_dummy_code).AliasName))
                    x_oMobileRetentionPreviousOrderRow.special_handling_dummy_code = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.special_handling_dummy_code).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_exp_year).AliasName))
                    x_oMobileRetentionPreviousOrderRow.m_card_exp_year = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_exp_year).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.remarks2PY).AliasName))
                    x_oMobileRetentionPreviousOrderRow.remarks2PY = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.remarks2PY).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.trade_field).AliasName))
                    x_oMobileRetentionPreviousOrderRow.trade_field = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.trade_field).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_tel).AliasName))
                    x_oMobileRetentionPreviousOrderRow.ord_place_tel = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_tel).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_id_type).AliasName))
                    x_oMobileRetentionPreviousOrderRow.ord_place_id_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_id_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cooling_offer).AliasName))
                    x_oMobileRetentionPreviousOrderRow.cooling_offer = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cooling_offer).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.rec_no).AliasName))
                    x_oMobileRetentionPreviousOrderRow.rec_no = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.rec_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_handset_offer_rebate_schedule).AliasName))
                    x_oMobileRetentionPreviousOrderRow.upgrade_handset_offer_rebate_schedule = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_handset_offer_rebate_schedule).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.change_payment_type).AliasName))
                    x_oMobileRetentionPreviousOrderRow.change_payment_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.change_payment_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.date_of_birth).AliasName))
                    x_oMobileRetentionPreviousOrderRow.date_of_birth = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.date_of_birth).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.contact_person).AliasName))
                    x_oMobileRetentionPreviousOrderRow.contact_person = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.contact_person).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extra_d_charge).AliasName))
                    x_oMobileRetentionPreviousOrderRow.extra_d_charge = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extra_d_charge).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.tl_name).AliasName))
                    x_oMobileRetentionPreviousOrderRow.tl_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.tl_name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.fast_start).AliasName))
                    x_oMobileRetentionPreviousOrderRow.fast_start = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.fast_start).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sp_ref_no).AliasName))
                    x_oMobileRetentionPreviousOrderRow.sp_ref_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sp_ref_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.edate).AliasName))
                    x_oMobileRetentionPreviousOrderRow.edate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.edate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.exist_cust_plan).AliasName))
                    x_oMobileRetentionPreviousOrderRow.exist_cust_plan = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.exist_cust_plan).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_rel).AliasName))
                    x_oMobileRetentionPreviousOrderRow.ord_place_rel = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_rel).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.mrt_no).AliasName))
                    x_oMobileRetentionPreviousOrderRow.mrt_no = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.mrt_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.imei_no).AliasName))
                    x_oMobileRetentionPreviousOrderRow.imei_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.imei_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.existing_smart_phone_model).AliasName))
                    x_oMobileRetentionPreviousOrderRow.existing_smart_phone_model = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.existing_smart_phone_model).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_code3).AliasName))
                    x_oMobileRetentionPreviousOrderRow.gift_code3 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_code3).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bank_code).AliasName))
                    x_oMobileRetentionPreviousOrderRow.bank_code = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bank_code).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.pos_ref_no).AliasName))
                    x_oMobileRetentionPreviousOrderRow.pos_ref_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.pos_ref_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_cut_date).AliasName))
                    x_oMobileRetentionPreviousOrderRow.bill_cut_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_cut_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_imei3).AliasName))
                    x_oMobileRetentionPreviousOrderRow.gift_imei3 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_imei3).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.exist_plan).AliasName))
                    x_oMobileRetentionPreviousOrderRow.exist_plan = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.exist_plan).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.waive).AliasName))
                    x_oMobileRetentionPreviousOrderRow.waive = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.waive).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.program).AliasName))
                    x_oMobileRetentionPreviousOrderRow.program = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.program).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.first_month_fee).AliasName))
                    x_oMobileRetentionPreviousOrderRow.first_month_fee = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.first_month_fee).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.r_offer).AliasName))
                    x_oMobileRetentionPreviousOrderRow.r_offer = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.r_offer).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cid).AliasName))
                    x_oMobileRetentionPreviousOrderRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.did).AliasName))
                    x_oMobileRetentionPreviousOrderRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.did).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ftg_tenure).AliasName))
                    x_oMobileRetentionPreviousOrderRow.ftg_tenure = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ftg_tenure).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.con_per).AliasName))
                    x_oMobileRetentionPreviousOrderRow.con_per = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.con_per).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_code4).AliasName))
                    x_oMobileRetentionPreviousOrderRow.gift_code4 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_code4).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.easywatch_type).AliasName))
                    x_oMobileRetentionPreviousOrderRow.easywatch_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.easywatch_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sms_mrt).AliasName))
                    x_oMobileRetentionPreviousOrderRow.sms_mrt = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sms_mrt).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.tpy_his_id).AliasName))
                    x_oMobileRetentionPreviousOrderRow.tpy_his_id = (global::System.Nullable<long>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.tpy_his_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_payment_method).AliasName))
                    x_oMobileRetentionPreviousOrderRow.monthly_payment_method = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_payment_method).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.remarks2EDF).AliasName))
                    x_oMobileRetentionPreviousOrderRow.remarks2EDF = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.remarks2EDF).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_desc3).AliasName))
                    x_oMobileRetentionPreviousOrderRow.gift_desc3 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_desc3).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_imei4).AliasName))
                    x_oMobileRetentionPreviousOrderRow.gift_imei4 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_imei4).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.old_ord_id).AliasName))
                    x_oMobileRetentionPreviousOrderRow.old_ord_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.old_ord_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_hkid2).AliasName))
                    x_oMobileRetentionPreviousOrderRow.monthly_bank_account_hkid2 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_hkid2).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.d_date).AliasName))
                    x_oMobileRetentionPreviousOrderRow.d_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.d_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_desc).AliasName))
                    x_oMobileRetentionPreviousOrderRow.gift_desc = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_desc).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.salesmancode).AliasName))
                    x_oMobileRetentionPreviousOrderRow.salesmancode = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.salesmancode).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.pool).AliasName))
                    x_oMobileRetentionPreviousOrderRow.pool = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.pool).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cn_mrt_no).AliasName))
                    x_oMobileRetentionPreviousOrderRow.cn_mrt_no = (global::System.Nullable<long>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cn_mrt_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_imei).AliasName))
                    x_oMobileRetentionPreviousOrderRow.accessory_imei = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_imei).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.third_party_credit_card).AliasName))
                    x_oMobileRetentionPreviousOrderRow.third_party_credit_card = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.third_party_credit_card).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_ref_no).AliasName))
                    x_oMobileRetentionPreviousOrderRow.card_ref_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_ref_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cooling_date).AliasName))
                    x_oMobileRetentionPreviousOrderRow.cooling_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cooling_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.special_approval).AliasName))
                    x_oMobileRetentionPreviousOrderRow.special_approval = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.special_approval).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_existing_contract_edate).AliasName))
                    x_oMobileRetentionPreviousOrderRow.upgrade_existing_contract_edate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_existing_contract_edate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_code).AliasName))
                    x_oMobileRetentionPreviousOrderRow.accessory_code = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_code).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_medium).AliasName))
                    x_oMobileRetentionPreviousOrderRow.bill_medium = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_medium).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium).AliasName))
                    x_oMobileRetentionPreviousOrderRow.s_premium = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ref_staff_no).AliasName))
                    x_oMobileRetentionPreviousOrderRow.ref_staff_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ref_staff_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_price).AliasName))
                    x_oMobileRetentionPreviousOrderRow.accessory_price = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_price).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_exp_month).AliasName))
                    x_oMobileRetentionPreviousOrderRow.m_card_exp_month = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_exp_month).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.installment_period).AliasName))
                    x_oMobileRetentionPreviousOrderRow.installment_period = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.installment_period).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_type).AliasName))
                    x_oMobileRetentionPreviousOrderRow.m_card_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.easywatch_ord_id).AliasName))
                    x_oMobileRetentionPreviousOrderRow.easywatch_ord_id = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.easywatch_ord_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.normal_rebate).AliasName))
                    x_oMobileRetentionPreviousOrderRow.normal_rebate = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.normal_rebate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_rebate_amount).AliasName))
                    x_oMobileRetentionPreviousOrderRow.m_rebate_amount = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_rebate_amount).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_holder2).AliasName))
                    x_oMobileRetentionPreviousOrderRow.m_card_holder2 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_holder2).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_medium_email).AliasName))
                    x_oMobileRetentionPreviousOrderRow.bill_medium_email = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_medium_email).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.active).AliasName))
                    x_oMobileRetentionPreviousOrderRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium1).AliasName))
                    x_oMobileRetentionPreviousOrderRow.s_premium1 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium1).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_exp_month).AliasName))
                    x_oMobileRetentionPreviousOrderRow.card_exp_month = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_exp_month).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ob_program_id).AliasName))
                    x_oMobileRetentionPreviousOrderRow.ob_program_id = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ob_program_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sku).AliasName))
                    x_oMobileRetentionPreviousOrderRow.sku = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sku).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ref_salesmancode).AliasName))
                    x_oMobileRetentionPreviousOrderRow.ref_salesmancode = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ref_salesmancode).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.go_wireless_package_code).AliasName))
                    x_oMobileRetentionPreviousOrderRow.go_wireless_package_code = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.go_wireless_package_code).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.third_party_hkid).AliasName))
                    x_oMobileRetentionPreviousOrderRow.third_party_hkid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.third_party_hkid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_existing_pccw_customer).AliasName))
                    x_oMobileRetentionPreviousOrderRow.upgrade_existing_pccw_customer = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_existing_pccw_customer).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.d_address).AliasName))
                    x_oMobileRetentionPreviousOrderRow.d_address = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.d_address).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_registered_mobile_no).AliasName))
                    x_oMobileRetentionPreviousOrderRow.upgrade_registered_mobile_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_registered_mobile_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_existing_customer_type).AliasName))
                    x_oMobileRetentionPreviousOrderRow.upgrade_existing_customer_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_existing_customer_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.normal_rebate_type).AliasName))
                    x_oMobileRetentionPreviousOrderRow.normal_rebate_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.normal_rebate_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_desc2).AliasName))
                    x_oMobileRetentionPreviousOrderRow.gift_desc2 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_desc2).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_branch_code).AliasName))
                    x_oMobileRetentionPreviousOrderRow.monthly_bank_account_branch_code = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_branch_code).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.remarks).AliasName))
                    x_oMobileRetentionPreviousOrderRow.remarks = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.remarks).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accept).AliasName))
                    x_oMobileRetentionPreviousOrderRow.accept = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accept).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.delivery_exchange).AliasName))
                    x_oMobileRetentionPreviousOrderRow.delivery_exchange = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.delivery_exchange).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_code2).AliasName))
                    x_oMobileRetentionPreviousOrderRow.gift_code2 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_code2).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.prepayment_waive).AliasName))
                    x_oMobileRetentionPreviousOrderRow.prepayment_waive = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.prepayment_waive).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.existing_smart_phone_imei).AliasName))
                    x_oMobileRetentionPreviousOrderRow.existing_smart_phone_imei = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.existing_smart_phone_imei).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.mnp_his_id).AliasName))
                    x_oMobileRetentionPreviousOrderRow.mnp_his_id = (global::System.Nullable<long>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.mnp_his_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cust_name).AliasName))
                    x_oMobileRetentionPreviousOrderRow.cust_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cust_name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cust_type).AliasName))
                    x_oMobileRetentionPreviousOrderRow.cust_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cust_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_sponsorships_amount).AliasName))
                    x_oMobileRetentionPreviousOrderRow.upgrade_sponsorships_amount = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_sponsorships_amount).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_medium_waive).AliasName))
                    x_oMobileRetentionPreviousOrderRow.bill_medium_waive = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_medium_waive).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.delivery_exchange_location).AliasName))
                    x_oMobileRetentionPreviousOrderRow.delivery_exchange_location = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.delivery_exchange_location).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.hs_offer_type_id).AliasName))
                    x_oMobileRetentionPreviousOrderRow.hs_offer_type_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.hs_offer_type_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.org_fee).AliasName))
                    x_oMobileRetentionPreviousOrderRow.org_fee = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.org_fee).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.rebate).AliasName))
                    x_oMobileRetentionPreviousOrderRow.rebate = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.rebate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_type).AliasName))
                    x_oMobileRetentionPreviousOrderRow.upgrade_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.go_wireless).AliasName))
                    x_oMobileRetentionPreviousOrderRow.go_wireless = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.go_wireless).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extra_rebate).AliasName))
                    x_oMobileRetentionPreviousOrderRow.extra_rebate = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extra_rebate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.plan_eff).AliasName))
                    x_oMobileRetentionPreviousOrderRow.plan_eff = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.plan_eff).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extra_rebate_amount).AliasName))
                    x_oMobileRetentionPreviousOrderRow.extra_rebate_amount = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extra_rebate_amount).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_exp_year).AliasName))
                    x_oMobileRetentionPreviousOrderRow.card_exp_year = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_exp_year).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_existing_contract_sdate).AliasName))
                    x_oMobileRetentionPreviousOrderRow.upgrade_existing_contract_sdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_existing_contract_sdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_hkid).AliasName))
                    x_oMobileRetentionPreviousOrderRow.ord_place_hkid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_hkid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.register_address).AliasName))
                    x_oMobileRetentionPreviousOrderRow.register_address = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.register_address).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gender).AliasName))
                    x_oMobileRetentionPreviousOrderRow.gender = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gender).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.lob_ac).AliasName))
                    x_oMobileRetentionPreviousOrderRow.lob_ac = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.lob_ac).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sim_mrt_no).AliasName))
                    x_oMobileRetentionPreviousOrderRow.sim_mrt_no = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sim_mrt_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.redemption_notice_option).AliasName))
                    x_oMobileRetentionPreviousOrderRow.redemption_notice_option = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.redemption_notice_option).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.delivery_collection_type).AliasName))
                    x_oMobileRetentionPreviousOrderRow.delivery_collection_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.delivery_collection_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.action_date).AliasName))
                    x_oMobileRetentionPreviousOrderRow.action_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.action_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.third_party_id_type).AliasName))
                    x_oMobileRetentionPreviousOrderRow.third_party_id_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.third_party_id_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.org_ftg).AliasName))
                    x_oMobileRetentionPreviousOrderRow.org_ftg = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.org_ftg).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_service_tenure).AliasName))
                    x_oMobileRetentionPreviousOrderRow.upgrade_service_tenure = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_service_tenure).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_payment_type).AliasName))
                    x_oMobileRetentionPreviousOrderRow.monthly_payment_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_payment_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.contact_no).AliasName))
                    x_oMobileRetentionPreviousOrderRow.contact_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.contact_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.org_mrt).AliasName))
                    x_oMobileRetentionPreviousOrderRow.org_mrt = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.org_mrt).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sim_item_name).AliasName))
                    x_oMobileRetentionPreviousOrderRow.sim_item_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sim_item_name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.pay_method).AliasName))
                    x_oMobileRetentionPreviousOrderRow.pay_method = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.pay_method).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.hs_model).AliasName))
                    x_oMobileRetentionPreviousOrderRow.hs_model = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.hs_model).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_code).AliasName))
                    x_oMobileRetentionPreviousOrderRow.gift_code = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_code).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_hkid).AliasName))
                    x_oMobileRetentionPreviousOrderRow.monthly_bank_account_hkid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_hkid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extra_offer).AliasName))
                    x_oMobileRetentionPreviousOrderRow.extra_offer = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extra_offer).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_no).AliasName))
                    x_oMobileRetentionPreviousOrderRow.monthly_bank_account_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.first_month_license_fee).AliasName))
                    x_oMobileRetentionPreviousOrderRow.first_month_license_fee = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.first_month_license_fee).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.retrieve_cnt).AliasName))
                    x_oMobileRetentionPreviousOrderRow.retrieve_cnt = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.retrieve_cnt).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ddate).AliasName))
                    x_oMobileRetentionPreviousOrderRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ddate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium2).AliasName))
                    x_oMobileRetentionPreviousOrderRow.s_premium2 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium2).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_id_type).AliasName))
                    x_oMobileRetentionPreviousOrderRow.monthly_bank_account_id_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_id_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_type).AliasName))
                    x_oMobileRetentionPreviousOrderRow.card_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.next_bill).AliasName))
                    x_oMobileRetentionPreviousOrderRow.next_bill = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.next_bill).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.pcd_paid_go_wireless).AliasName))
                    x_oMobileRetentionPreviousOrderRow.pcd_paid_go_wireless = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.pcd_paid_go_wireless).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_rebate_calculation).AliasName))
                    x_oMobileRetentionPreviousOrderRow.upgrade_rebate_calculation = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_rebate_calculation).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ext_place_tel).AliasName))
                    x_oMobileRetentionPreviousOrderRow.ext_place_tel = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ext_place_tel).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_3rd_hkid).AliasName))
                    x_oMobileRetentionPreviousOrderRow.m_3rd_hkid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_3rd_hkid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.retention_type).AliasName))
                    x_oMobileRetentionPreviousOrderRow.retention_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.retention_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_address_his_id).AliasName))
                    x_oMobileRetentionPreviousOrderRow.bill_address_his_id = (global::System.Nullable<long>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_address_his_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.aig_gift).AliasName))
                    x_oMobileRetentionPreviousOrderRow.aig_gift = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.aig_gift).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cust_staff_no).AliasName))
                    x_oMobileRetentionPreviousOrderRow.cust_staff_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cust_staff_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.order_id).AliasName))
                    x_oMobileRetentionPreviousOrderRow.order_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.order_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.family_name).AliasName))
                    x_oMobileRetentionPreviousOrderRow.family_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.family_name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cdate).AliasName))
                    x_oMobileRetentionPreviousOrderRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.status_by_cs_admin).AliasName))
                    x_oMobileRetentionPreviousOrderRow.status_by_cs_admin = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.status_by_cs_admin).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sim_item_number).AliasName))
                    x_oMobileRetentionPreviousOrderRow.sim_item_number = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sim_item_number).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.vip_case).AliasName))
                    x_oMobileRetentionPreviousOrderRow.vip_case = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.vip_case).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.given_name).AliasName))
                    x_oMobileRetentionPreviousOrderRow.given_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.given_name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.log_date).AliasName))
                    x_oMobileRetentionPreviousOrderRow.log_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.log_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extn).AliasName))
                    x_oMobileRetentionPreviousOrderRow.extn = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.extn).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.d_time).AliasName))
                    x_oMobileRetentionPreviousOrderRow.d_time = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.d_time).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bank_name).AliasName))
                    x_oMobileRetentionPreviousOrderRow.bank_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bank_name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.delivery_exchange_option).AliasName))
                    x_oMobileRetentionPreviousOrderRow.delivery_exchange_option = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.delivery_exchange_option).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_service_account_no).AliasName))
                    x_oMobileRetentionPreviousOrderRow.upgrade_service_account_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.upgrade_service_account_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.action_of_rate_plan_effective).AliasName))
                    x_oMobileRetentionPreviousOrderRow.action_of_rate_plan_effective = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.action_of_rate_plan_effective).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_no).AliasName))
                    x_oMobileRetentionPreviousOrderRow.m_card_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_card_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.existing_contract_end_date).AliasName))
                    x_oMobileRetentionPreviousOrderRow.existing_contract_end_date = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.existing_contract_end_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.con_eff_date).AliasName))
                    x_oMobileRetentionPreviousOrderRow.con_eff_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.con_eff_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_3rd_hkid2).AliasName))
                    x_oMobileRetentionPreviousOrderRow.m_3rd_hkid2 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_3rd_hkid2).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.amount).AliasName))
                    x_oMobileRetentionPreviousOrderRow.amount = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.amount).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.id_type).AliasName))
                    x_oMobileRetentionPreviousOrderRow.id_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.id_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.rate_plan).AliasName))
                    x_oMobileRetentionPreviousOrderRow.rate_plan = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.rate_plan).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.channel).AliasName))
                    x_oMobileRetentionPreviousOrderRow.channel = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.channel).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.action_eff_date).AliasName))
                    x_oMobileRetentionPreviousOrderRow.action_eff_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.action_eff_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.issue_type).AliasName))
                    x_oMobileRetentionPreviousOrderRow.issue_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.issue_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.free_mon).AliasName))
                    x_oMobileRetentionPreviousOrderRow.free_mon = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.free_mon).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.plan_eff_date).AliasName))
                    x_oMobileRetentionPreviousOrderRow.plan_eff_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.plan_eff_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.del_remark).AliasName))
                    x_oMobileRetentionPreviousOrderRow.del_remark = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.del_remark).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.teamcode).AliasName))
                    x_oMobileRetentionPreviousOrderRow.teamcode = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.teamcode).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.staff_name).AliasName))
                    x_oMobileRetentionPreviousOrderRow.staff_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.staff_name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.edf_no).AliasName))
                    x_oMobileRetentionPreviousOrderRow.edf_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.edf_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_by).AliasName))
                    x_oMobileRetentionPreviousOrderRow.ord_place_by = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ord_place_by).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cancel_renew).AliasName))
                    x_oMobileRetentionPreviousOrderRow.cancel_renew = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.cancel_renew).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.preferred_languages).AliasName))
                    x_oMobileRetentionPreviousOrderRow.preferred_languages = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.preferred_languages).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.hkid).AliasName))
                    x_oMobileRetentionPreviousOrderRow.hkid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.hkid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_no).AliasName))
                    x_oMobileRetentionPreviousOrderRow.card_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ac_no).AliasName))
                    x_oMobileRetentionPreviousOrderRow.ac_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.ac_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_cut_num).AliasName))
                    x_oMobileRetentionPreviousOrderRow.bill_cut_num = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bill_cut_num).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.premium).AliasName))
                    x_oMobileRetentionPreviousOrderRow.premium = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.premium).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_3rd_id_type).AliasName))
                    x_oMobileRetentionPreviousOrderRow.m_3rd_id_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_3rd_id_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_imei2).AliasName))
                    x_oMobileRetentionPreviousOrderRow.gift_imei2 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.gift_imei2).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.reasons).AliasName))
                    x_oMobileRetentionPreviousOrderRow.reasons = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.reasons).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.language).AliasName))
                    x_oMobileRetentionPreviousOrderRow.language = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.language).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.rebate_amount).AliasName))
                    x_oMobileRetentionPreviousOrderRow.rebate_amount = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.rebate_amount).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.lob).AliasName))
                    x_oMobileRetentionPreviousOrderRow.lob = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.lob).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_3rd_contact_no).AliasName))
                    x_oMobileRetentionPreviousOrderRow.m_3rd_contact_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.m_3rd_contact_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.staff_no).AliasName))
                    x_oMobileRetentionPreviousOrderRow.staff_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.staff_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium3).AliasName))
                    x_oMobileRetentionPreviousOrderRow.s_premium3 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.s_premium3).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sp_d_date).AliasName))
                    x_oMobileRetentionPreviousOrderRow.sp_d_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sp_d_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bundle_name).AliasName))
                    x_oMobileRetentionPreviousOrderRow.bundle_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.bundle_name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_waive).AliasName))
                    x_oMobileRetentionPreviousOrderRow.accessory_waive = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.accessory_waive).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sim_item_code).AliasName))
                    x_oMobileRetentionPreviousOrderRow.sim_item_code = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.sim_item_code).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_holder).AliasName))
                    x_oMobileRetentionPreviousOrderRow.monthly_bank_account_holder = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.monthly_bank_account_holder).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_holder).AliasName))
                    x_oMobileRetentionPreviousOrderRow.card_holder = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionPreviousOrder.Para.card_holder).AliasName];
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
            return MobileRetentionPreviousOrderRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static MobileRetentionPreviousOrderEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return MobileRetentionPreviousOrderRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static MobileRetentionPreviousOrderEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return MobileRetentionPreviousOrderRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileRetentionPreviousOrderRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileRetentionPreviousOrderRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return MobileRetentionPreviousOrderRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sGift_imei,string x_sS_premium4,string x_sGift_desc4,string x_sAccessory_desc,string x_sAction_required,global::System.Nullable<long> x_lRegistered_address_his_id,global::System.Nullable<DateTime> x_dVas_eff_date,string x_sMonthly_bank_account_bank_code,string x_sSpecial_handling_dummy_code,string x_sM_card_exp_year,string x_sRemarks2PY,string x_sTrade_field,string x_sOrd_place_tel,string x_sOrd_place_id_type,string x_sCooling_offer,global::System.Nullable<int> x_iRec_no,string x_sUpgrade_handset_offer_rebate_schedule,string x_sChange_payment_type,global::System.Nullable<DateTime> x_dDate_of_birth,string x_sContact_person,string x_sExtra_d_charge,string x_sTl_name,global::System.Nullable<bool> x_bFast_start,string x_sSp_ref_no,global::System.Nullable<DateTime> x_dEdate,string x_sExist_cust_plan,string x_sOrd_place_rel,global::System.Nullable<int> x_iMrt_no,string x_sImei_no,string x_sExisting_smart_phone_model,string x_sGift_code3,string x_sBank_code,string x_sPos_ref_no,global::System.Nullable<DateTime> x_dBill_cut_date,string x_sGift_imei3,string x_sExist_plan,global::System.Nullable<bool> x_bWaive,string x_sProgram,string x_sFirst_month_fee,string x_sR_offer,string x_sCid,string x_sDid,string x_sFtg_tenure,string x_sCon_per,string x_sGift_code4,string x_sEasywatch_type,string x_sSms_mrt,global::System.Nullable<long> x_lTpy_his_id,string x_sMonthly_payment_method,string x_sRemarks2EDF,string x_sGift_desc3,string x_sGift_imei4,global::System.Nullable<int> x_iOld_ord_id,string x_sMonthly_bank_account_hkid2,global::System.Nullable<DateTime> x_dD_date,string x_sGift_desc,string x_sSalesmancode,string x_sPool,global::System.Nullable<long> x_lCn_mrt_no,string x_sAccessory_imei,string x_sThird_party_credit_card,string x_sCard_ref_no,global::System.Nullable<DateTime> x_dCooling_date,string x_sSpecial_approval,global::System.Nullable<DateTime> x_dUpgrade_existing_contract_edate,string x_sAccessory_code,string x_sBill_medium,string x_sS_premium,string x_sRef_staff_no,string x_sAccessory_price,string x_sM_card_exp_month,string x_sInstallment_period,string x_sM_card_type,string x_sEasywatch_ord_id,global::System.Nullable<bool> x_bNormal_rebate,string x_sM_rebate_amount,string x_sM_card_holder2,string x_sBill_medium_email,global::System.Nullable<bool> x_bActive,string x_sS_premium1,string x_sCard_exp_month,string x_sOb_program_id,string x_sSku,string x_sRef_salesmancode,string x_sGo_wireless_package_code,string x_sThird_party_hkid,string x_sUpgrade_existing_pccw_customer,string x_sD_address,string x_sUpgrade_registered_mobile_no,string x_sUpgrade_existing_customer_type,string x_sNormal_rebate_type,string x_sGift_desc2,string x_sMonthly_bank_account_branch_code,string x_sRemarks,string x_sAccept,string x_sDelivery_exchange,string x_sGift_code2,global::System.Nullable<bool> x_bPrepayment_waive,string x_sExisting_smart_phone_imei,global::System.Nullable<long> x_lMnp_his_id,string x_sCust_name,string x_sCust_type,string x_sUpgrade_sponsorships_amount,global::System.Nullable<bool> x_bBill_medium_waive,string x_sDelivery_exchange_location,global::System.Nullable<int> x_iHs_offer_type_id,string x_sOrg_fee,string x_sRebate,string x_sUpgrade_type,string x_sGo_wireless,string x_sExtra_rebate,string x_sPlan_eff,string x_sExtra_rebate_amount,string x_sCard_exp_year,global::System.Nullable<DateTime> x_dUpgrade_existing_contract_sdate,string x_sOrd_place_hkid,string x_sRegister_address,string x_sGender,string x_sLob_ac,global::System.Nullable<int> x_iSim_mrt_no,string x_sRedemption_notice_option,string x_sDelivery_collection_type,global::System.Nullable<DateTime> x_dAction_date,string x_sThird_party_id_type,string x_sOrg_ftg,string x_sUpgrade_service_tenure,string x_sMonthly_payment_type,string x_sContact_no,global::System.Nullable<int> x_iOrg_mrt,string x_sSim_item_name,string x_sPay_method,string x_sHs_model,string x_sGift_code,string x_sMonthly_bank_account_hkid,string x_sExtra_offer,string x_sMonthly_bank_account_no,string x_sFirst_month_license_fee,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dDdate,string x_sS_premium2,string x_sMonthly_bank_account_id_type,string x_sCard_type,global::System.Nullable<bool> x_bNext_bill,global::System.Nullable<bool> x_bPcd_paid_go_wireless,string x_sUpgrade_rebate_calculation,string x_sExt_place_tel,string x_sM_3rd_hkid,string x_sRetention_type,global::System.Nullable<long> x_lBill_address_his_id,string x_sAig_gift,string x_sCust_staff_no,string x_sFamily_name,global::System.Nullable<DateTime> x_dCdate,string x_sStatus_by_cs_admin,string x_sSim_item_number,string x_sVip_case,string x_sGiven_name,global::System.Nullable<DateTime> x_dLog_date,string x_sExtn,string x_sD_time,string x_sBank_name,string x_sDelivery_exchange_option,string x_sUpgrade_service_account_no,string x_sAction_of_rate_plan_effective,string x_sM_card_no,string x_sExisting_contract_end_date,global::System.Nullable<DateTime> x_dCon_eff_date,string x_sM_3rd_hkid2,string x_sAmount,string x_sId_type,string x_sRate_plan,string x_sChannel,global::System.Nullable<DateTime> x_dAction_eff_date,string x_sIssue_type,string x_sFree_mon,global::System.Nullable<DateTime> x_dPlan_eff_date,string x_sDel_remark,string x_sTeamcode,string x_sStaff_name,string x_sEdf_no,string x_sOrd_place_by,string x_sCancel_renew,string x_sPreferred_languages,string x_sHkid,string x_sCard_no,string x_sAc_no,global::System.Nullable<int> x_iBill_cut_num,string x_sPremium,string x_sM_3rd_id_type,string x_sGift_imei2,string x_sReasons,string x_sLanguage,string x_sRebate_amount,string x_sLob,string x_sM_3rd_contact_no,string x_sStaff_no,string x_sS_premium3,global::System.Nullable<DateTime> x_dSp_d_date,string x_sBundle_name,global::System.Nullable<bool> x_bAccessory_waive,string x_sSim_item_code,string x_sMonthly_bank_account_holder,string x_sCard_holder)
        {
            return MobileRetentionPreviousOrderRepository.Insert(x_oDB, x_sGift_imei,x_sS_premium4,x_sGift_desc4,x_sAccessory_desc,x_sAction_required,x_lRegistered_address_his_id,x_dVas_eff_date,x_sMonthly_bank_account_bank_code,x_sSpecial_handling_dummy_code,x_sM_card_exp_year,x_sRemarks2PY,x_sTrade_field,x_sOrd_place_tel,x_sOrd_place_id_type,x_sCooling_offer,x_iRec_no,x_sUpgrade_handset_offer_rebate_schedule,x_sChange_payment_type,x_dDate_of_birth,x_sContact_person,x_sExtra_d_charge,x_sTl_name,x_bFast_start,x_sSp_ref_no,x_dEdate,x_sExist_cust_plan,x_sOrd_place_rel,x_iMrt_no,x_sImei_no,x_sExisting_smart_phone_model,x_sGift_code3,x_sBank_code,x_sPos_ref_no,x_dBill_cut_date,x_sGift_imei3,x_sExist_plan,x_bWaive,x_sProgram,x_sFirst_month_fee,x_sR_offer,x_sCid,x_sDid,x_sFtg_tenure,x_sCon_per,x_sGift_code4,x_sEasywatch_type,x_sSms_mrt,x_lTpy_his_id,x_sMonthly_payment_method,x_sRemarks2EDF,x_sGift_desc3,x_sGift_imei4,x_iOld_ord_id,x_sMonthly_bank_account_hkid2,x_dD_date,x_sGift_desc,x_sSalesmancode,x_sPool,x_lCn_mrt_no,x_sAccessory_imei,x_sThird_party_credit_card,x_sCard_ref_no,x_dCooling_date,x_sSpecial_approval,x_dUpgrade_existing_contract_edate,x_sAccessory_code,x_sBill_medium,x_sS_premium,x_sRef_staff_no,x_sAccessory_price,x_sM_card_exp_month,x_sInstallment_period,x_sM_card_type,x_sEasywatch_ord_id,x_bNormal_rebate,x_sM_rebate_amount,x_sM_card_holder2,x_sBill_medium_email,x_bActive,x_sS_premium1,x_sCard_exp_month,x_sOb_program_id,x_sSku,x_sRef_salesmancode,x_sGo_wireless_package_code,x_sThird_party_hkid,x_sUpgrade_existing_pccw_customer,x_sD_address,x_sUpgrade_registered_mobile_no,x_sUpgrade_existing_customer_type,x_sNormal_rebate_type,x_sGift_desc2,x_sMonthly_bank_account_branch_code,x_sRemarks,x_sAccept,x_sDelivery_exchange,x_sGift_code2,x_bPrepayment_waive,x_sExisting_smart_phone_imei,x_lMnp_his_id,x_sCust_name,x_sCust_type,x_sUpgrade_sponsorships_amount,x_bBill_medium_waive,x_sDelivery_exchange_location,x_iHs_offer_type_id,x_sOrg_fee,x_sRebate,x_sUpgrade_type,x_sGo_wireless,x_sExtra_rebate,x_sPlan_eff,x_sExtra_rebate_amount,x_sCard_exp_year,x_dUpgrade_existing_contract_sdate,x_sOrd_place_hkid,x_sRegister_address,x_sGender,x_sLob_ac,x_iSim_mrt_no,x_sRedemption_notice_option,x_sDelivery_collection_type,x_dAction_date,x_sThird_party_id_type,x_sOrg_ftg,x_sUpgrade_service_tenure,x_sMonthly_payment_type,x_sContact_no,x_iOrg_mrt,x_sSim_item_name,x_sPay_method,x_sHs_model,x_sGift_code,x_sMonthly_bank_account_hkid,x_sExtra_offer,x_sMonthly_bank_account_no,x_sFirst_month_license_fee,x_iRetrieve_cnt,x_dDdate,x_sS_premium2,x_sMonthly_bank_account_id_type,x_sCard_type,x_bNext_bill,x_bPcd_paid_go_wireless,x_sUpgrade_rebate_calculation,x_sExt_place_tel,x_sM_3rd_hkid,x_sRetention_type,x_lBill_address_his_id,x_sAig_gift,x_sCust_staff_no,x_sFamily_name,x_dCdate,x_sStatus_by_cs_admin,x_sSim_item_number,x_sVip_case,x_sGiven_name,x_dLog_date,x_sExtn,x_sD_time,x_sBank_name,x_sDelivery_exchange_option,x_sUpgrade_service_account_no,x_sAction_of_rate_plan_effective,x_sM_card_no,x_sExisting_contract_end_date,x_dCon_eff_date,x_sM_3rd_hkid2,x_sAmount,x_sId_type,x_sRate_plan,x_sChannel,x_dAction_eff_date,x_sIssue_type,x_sFree_mon,x_dPlan_eff_date,x_sDel_remark,x_sTeamcode,x_sStaff_name,x_sEdf_no,x_sOrd_place_by,x_sCancel_renew,x_sPreferred_languages,x_sHkid,x_sCard_no,x_sAc_no,x_iBill_cut_num,x_sPremium,x_sM_3rd_id_type,x_sGift_imei2,x_sReasons,x_sLanguage,x_sRebate_amount,x_sLob,x_sM_3rd_contact_no,x_sStaff_no,x_sS_premium3,x_dSp_d_date,x_sBundle_name,x_bAccessory_waive,x_sSim_item_code,x_sMonthly_bank_account_holder,x_sCard_holder);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileRetentionPreviousOrder x_oMobileRetentionPreviousOrder)
        {
            return MobileRetentionPreviousOrderRepository.InsertWithOutLastID(x_oDB,x_oMobileRetentionPreviousOrder);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sGift_imei,string x_sS_premium4,string x_sGift_desc4,string x_sAccessory_desc,string x_sAction_required,global::System.Nullable<long> x_lRegistered_address_his_id,global::System.Nullable<DateTime> x_dVas_eff_date,string x_sMonthly_bank_account_bank_code,string x_sSpecial_handling_dummy_code,string x_sM_card_exp_year,string x_sRemarks2PY,string x_sTrade_field,string x_sOrd_place_tel,string x_sOrd_place_id_type,string x_sCooling_offer,global::System.Nullable<int> x_iRec_no,string x_sUpgrade_handset_offer_rebate_schedule,string x_sChange_payment_type,global::System.Nullable<DateTime> x_dDate_of_birth,string x_sContact_person,string x_sExtra_d_charge,string x_sTl_name,global::System.Nullable<bool> x_bFast_start,string x_sSp_ref_no,global::System.Nullable<DateTime> x_dEdate,string x_sExist_cust_plan,string x_sOrd_place_rel,global::System.Nullable<int> x_iMrt_no,string x_sImei_no,string x_sExisting_smart_phone_model,string x_sGift_code3,string x_sBank_code,string x_sPos_ref_no,global::System.Nullable<DateTime> x_dBill_cut_date,string x_sGift_imei3,string x_sExist_plan,global::System.Nullable<bool> x_bWaive,string x_sProgram,string x_sFirst_month_fee,string x_sR_offer,string x_sCid,string x_sDid,string x_sFtg_tenure,string x_sCon_per,string x_sGift_code4,string x_sEasywatch_type,string x_sSms_mrt,global::System.Nullable<long> x_lTpy_his_id,string x_sMonthly_payment_method,string x_sRemarks2EDF,string x_sGift_desc3,string x_sGift_imei4,global::System.Nullable<int> x_iOld_ord_id,string x_sMonthly_bank_account_hkid2,global::System.Nullable<DateTime> x_dD_date,string x_sGift_desc,string x_sSalesmancode,string x_sPool,global::System.Nullable<long> x_lCn_mrt_no,string x_sAccessory_imei,string x_sThird_party_credit_card,string x_sCard_ref_no,global::System.Nullable<DateTime> x_dCooling_date,string x_sSpecial_approval,global::System.Nullable<DateTime> x_dUpgrade_existing_contract_edate,string x_sAccessory_code,string x_sBill_medium,string x_sS_premium,string x_sRef_staff_no,string x_sAccessory_price,string x_sM_card_exp_month,string x_sInstallment_period,string x_sM_card_type,string x_sEasywatch_ord_id,global::System.Nullable<bool> x_bNormal_rebate,string x_sM_rebate_amount,string x_sM_card_holder2,string x_sBill_medium_email,global::System.Nullable<bool> x_bActive,string x_sS_premium1,string x_sCard_exp_month,string x_sOb_program_id,string x_sSku,string x_sRef_salesmancode,string x_sGo_wireless_package_code,string x_sThird_party_hkid,string x_sUpgrade_existing_pccw_customer,string x_sD_address,string x_sUpgrade_registered_mobile_no,string x_sUpgrade_existing_customer_type,string x_sNormal_rebate_type,string x_sGift_desc2,string x_sMonthly_bank_account_branch_code,string x_sRemarks,string x_sAccept,string x_sDelivery_exchange,string x_sGift_code2,global::System.Nullable<bool> x_bPrepayment_waive,string x_sExisting_smart_phone_imei,global::System.Nullable<long> x_lMnp_his_id,string x_sCust_name,string x_sCust_type,string x_sUpgrade_sponsorships_amount,global::System.Nullable<bool> x_bBill_medium_waive,string x_sDelivery_exchange_location,global::System.Nullable<int> x_iHs_offer_type_id,string x_sOrg_fee,string x_sRebate,string x_sUpgrade_type,string x_sGo_wireless,string x_sExtra_rebate,string x_sPlan_eff,string x_sExtra_rebate_amount,string x_sCard_exp_year,global::System.Nullable<DateTime> x_dUpgrade_existing_contract_sdate,string x_sOrd_place_hkid,string x_sRegister_address,string x_sGender,string x_sLob_ac,global::System.Nullable<int> x_iSim_mrt_no,string x_sRedemption_notice_option,string x_sDelivery_collection_type,global::System.Nullable<DateTime> x_dAction_date,string x_sThird_party_id_type,string x_sOrg_ftg,string x_sUpgrade_service_tenure,string x_sMonthly_payment_type,string x_sContact_no,global::System.Nullable<int> x_iOrg_mrt,string x_sSim_item_name,string x_sPay_method,string x_sHs_model,string x_sGift_code,string x_sMonthly_bank_account_hkid,string x_sExtra_offer,string x_sMonthly_bank_account_no,string x_sFirst_month_license_fee,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dDdate,string x_sS_premium2,string x_sMonthly_bank_account_id_type,string x_sCard_type,global::System.Nullable<bool> x_bNext_bill,global::System.Nullable<bool> x_bPcd_paid_go_wireless,string x_sUpgrade_rebate_calculation,string x_sExt_place_tel,string x_sM_3rd_hkid,string x_sRetention_type,global::System.Nullable<long> x_lBill_address_his_id,string x_sAig_gift,string x_sCust_staff_no,string x_sFamily_name,global::System.Nullable<DateTime> x_dCdate,string x_sStatus_by_cs_admin,string x_sSim_item_number,string x_sVip_case,string x_sGiven_name,global::System.Nullable<DateTime> x_dLog_date,string x_sExtn,string x_sD_time,string x_sBank_name,string x_sDelivery_exchange_option,string x_sUpgrade_service_account_no,string x_sAction_of_rate_plan_effective,string x_sM_card_no,string x_sExisting_contract_end_date,global::System.Nullable<DateTime> x_dCon_eff_date,string x_sM_3rd_hkid2,string x_sAmount,string x_sId_type,string x_sRate_plan,string x_sChannel,global::System.Nullable<DateTime> x_dAction_eff_date,string x_sIssue_type,string x_sFree_mon,global::System.Nullable<DateTime> x_dPlan_eff_date,string x_sDel_remark,string x_sTeamcode,string x_sStaff_name,string x_sEdf_no,string x_sOrd_place_by,string x_sCancel_renew,string x_sPreferred_languages,string x_sHkid,string x_sCard_no,string x_sAc_no,global::System.Nullable<int> x_iBill_cut_num,string x_sPremium,string x_sM_3rd_id_type,string x_sGift_imei2,string x_sReasons,string x_sLanguage,string x_sRebate_amount,string x_sLob,string x_sM_3rd_contact_no,string x_sStaff_no,string x_sS_premium3,global::System.Nullable<DateTime> x_dSp_d_date,string x_sBundle_name,global::System.Nullable<bool> x_bAccessory_waive,string x_sSim_item_code,string x_sMonthly_bank_account_holder,string x_sCard_holder)
        {
            return MobileRetentionPreviousOrderRepository.InsertReturnLastID_SP(x_oDB,x_sGift_imei,x_sS_premium4,x_sGift_desc4,x_sAccessory_desc,x_sAction_required,x_lRegistered_address_his_id,x_dVas_eff_date,x_sMonthly_bank_account_bank_code,x_sSpecial_handling_dummy_code,x_sM_card_exp_year,x_sRemarks2PY,x_sTrade_field,x_sOrd_place_tel,x_sOrd_place_id_type,x_sCooling_offer,x_iRec_no,x_sUpgrade_handset_offer_rebate_schedule,x_sChange_payment_type,x_dDate_of_birth,x_sContact_person,x_sExtra_d_charge,x_sTl_name,x_bFast_start,x_sSp_ref_no,x_dEdate,x_sExist_cust_plan,x_sOrd_place_rel,x_iMrt_no,x_sImei_no,x_sExisting_smart_phone_model,x_sGift_code3,x_sBank_code,x_sPos_ref_no,x_dBill_cut_date,x_sGift_imei3,x_sExist_plan,x_bWaive,x_sProgram,x_sFirst_month_fee,x_sR_offer,x_sCid,x_sDid,x_sFtg_tenure,x_sCon_per,x_sGift_code4,x_sEasywatch_type,x_sSms_mrt,x_lTpy_his_id,x_sMonthly_payment_method,x_sRemarks2EDF,x_sGift_desc3,x_sGift_imei4,x_iOld_ord_id,x_sMonthly_bank_account_hkid2,x_dD_date,x_sGift_desc,x_sSalesmancode,x_sPool,x_lCn_mrt_no,x_sAccessory_imei,x_sThird_party_credit_card,x_sCard_ref_no,x_dCooling_date,x_sSpecial_approval,x_dUpgrade_existing_contract_edate,x_sAccessory_code,x_sBill_medium,x_sS_premium,x_sRef_staff_no,x_sAccessory_price,x_sM_card_exp_month,x_sInstallment_period,x_sM_card_type,x_sEasywatch_ord_id,x_bNormal_rebate,x_sM_rebate_amount,x_sM_card_holder2,x_sBill_medium_email,x_bActive,x_sS_premium1,x_sCard_exp_month,x_sOb_program_id,x_sSku,x_sRef_salesmancode,x_sGo_wireless_package_code,x_sThird_party_hkid,x_sUpgrade_existing_pccw_customer,x_sD_address,x_sUpgrade_registered_mobile_no,x_sUpgrade_existing_customer_type,x_sNormal_rebate_type,x_sGift_desc2,x_sMonthly_bank_account_branch_code,x_sRemarks,x_sAccept,x_sDelivery_exchange,x_sGift_code2,x_bPrepayment_waive,x_sExisting_smart_phone_imei,x_lMnp_his_id,x_sCust_name,x_sCust_type,x_sUpgrade_sponsorships_amount,x_bBill_medium_waive,x_sDelivery_exchange_location,x_iHs_offer_type_id,x_sOrg_fee,x_sRebate,x_sUpgrade_type,x_sGo_wireless,x_sExtra_rebate,x_sPlan_eff,x_sExtra_rebate_amount,x_sCard_exp_year,x_dUpgrade_existing_contract_sdate,x_sOrd_place_hkid,x_sRegister_address,x_sGender,x_sLob_ac,x_iSim_mrt_no,x_sRedemption_notice_option,x_sDelivery_collection_type,x_dAction_date,x_sThird_party_id_type,x_sOrg_ftg,x_sUpgrade_service_tenure,x_sMonthly_payment_type,x_sContact_no,x_iOrg_mrt,x_sSim_item_name,x_sPay_method,x_sHs_model,x_sGift_code,x_sMonthly_bank_account_hkid,x_sExtra_offer,x_sMonthly_bank_account_no,x_sFirst_month_license_fee,x_iRetrieve_cnt,x_dDdate,x_sS_premium2,x_sMonthly_bank_account_id_type,x_sCard_type,x_bNext_bill,x_bPcd_paid_go_wireless,x_sUpgrade_rebate_calculation,x_sExt_place_tel,x_sM_3rd_hkid,x_sRetention_type,x_lBill_address_his_id,x_sAig_gift,x_sCust_staff_no,x_sFamily_name,x_dCdate,x_sStatus_by_cs_admin,x_sSim_item_number,x_sVip_case,x_sGiven_name,x_dLog_date,x_sExtn,x_sD_time,x_sBank_name,x_sDelivery_exchange_option,x_sUpgrade_service_account_no,x_sAction_of_rate_plan_effective,x_sM_card_no,x_sExisting_contract_end_date,x_dCon_eff_date,x_sM_3rd_hkid2,x_sAmount,x_sId_type,x_sRate_plan,x_sChannel,x_dAction_eff_date,x_sIssue_type,x_sFree_mon,x_dPlan_eff_date,x_sDel_remark,x_sTeamcode,x_sStaff_name,x_sEdf_no,x_sOrd_place_by,x_sCancel_renew,x_sPreferred_languages,x_sHkid,x_sCard_no,x_sAc_no,x_iBill_cut_num,x_sPremium,x_sM_3rd_id_type,x_sGift_imei2,x_sReasons,x_sLanguage,x_sRebate_amount,x_sLob,x_sM_3rd_contact_no,x_sStaff_no,x_sS_premium3,x_dSp_d_date,x_sBundle_name,x_bAccessory_waive,x_sSim_item_code,x_sMonthly_bank_account_holder,x_sCard_holder);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileRetentionPreviousOrder x_oMobileRetentionPreviousOrder)
        {
            return MobileRetentionPreviousOrderRepository.InsertReturnLastID_SP(x_oDB,x_oMobileRetentionPreviousOrder);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return MobileRetentionPreviousOrderRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return MobileRetentionPreviousOrderRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iOrder_id)
        {
            return MobileRetentionPreviousOrderRepository.Delete(x_oDB, x_iOrder_id);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(MobileRetentionPreviousOrder x_oMobileRetentionPreviousOrderRow){
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


