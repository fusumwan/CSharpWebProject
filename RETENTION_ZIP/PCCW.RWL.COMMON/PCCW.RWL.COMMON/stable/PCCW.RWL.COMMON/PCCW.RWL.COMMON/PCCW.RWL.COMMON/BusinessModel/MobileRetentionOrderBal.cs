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
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Xml;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-02-03>
///-- Description:	<Description,Table :[MobileRetentionOrder],Business layer>
///-- =============================================

namespace PCCW.RWL.CORE{

    /// <summary>
    /// Summary description for table [MobileRetentionOrder] Business layer
    /// </summary>
    
    public class MobileRetentionOrderBals:Collection<MobileRetentionOrder>{}
    public class MobileRetentionOrderBal: MobileRetentionOrderBalBase{
        
        #region Constructor
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public MobileRetentionOrderBal() : base(){
        }
        ~MobileRetentionOrderBal(){
            base.Release();
        }
        #endregion

        #region Set IMEI
        public static bool SetIMEI(string x_sIMEI, string x_sOrder_id)
        {
            if (x_sOrder_id.Equals(string.Empty)) return false;
            if (x_sIMEI.Equals(string.Empty)) return false;
            string _sQuery10 = "UPDATE " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder SET ";
            _sQuery10 += " imei_no='" + x_sIMEI + "' ";
            _sQuery10 += " where order_id='" + x_sOrder_id + "'";
            return GetDB().ExplicitNonQuery(_sQuery10);
        }
        #endregion

        #region Release IMEI
        public static bool IMEIRelease(string x_sOrder_id)
        {
            if (x_sOrder_id.Equals(string.Empty)) return false;
            string _sQuery9 = "UPDATE " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder SET ";
            _sQuery9 += " imei_no=null ";
            _sQuery9 += " where order_id='" + x_sOrder_id + "'";
            return GetDB().ExplicitNonQuery(_sQuery9);
        }
        #endregion

        #region Hsmodel List
        public static global::System.Collections.Generic.List<string> DrpHsmodelList()
        {
            global::System.Collections.Generic.List<string> _oHsmodelList = new global::System.Collections.Generic.List<string>();
            global::System.Data.SqlClient.SqlDataReader _oReader = MobileRetentionOrderBal.GetSearch(GetDB(), MobileRetentionOrder.Para.hs_model, "active=1 and hs_model<>'' group by hs_model order by hs_model", null, null);
           while(_oReader.Read()){
               _oHsmodelList.Add(_oReader[MobileRetentionOrder.Para.hs_model].ToString());
            }
           if (_oReader != null) _oReader.Close(); _oReader.Dispose();
            return _oHsmodelList;
        }
        #endregion

        #region Premium List
        public static global::System.Collections.Generic.List<string> DrpPremiumList()
        {
            global::System.Collections.Generic.List<string> _oHsmodelList = new global::System.Collections.Generic.List<string>();
            global::System.Data.SqlClient.SqlDataReader _oReader = MobileRetentionOrderBal.GetSearch(GetDB(), MobileRetentionOrder.Para.premium, "active=1 and premium<>'' group by premium order by premium", null, null);
            while (_oReader.Read()){
                _oHsmodelList.Add(_oReader[MobileRetentionOrder.Para.premium].ToString());
            }
            if (_oReader != null) _oReader.Close(); _oReader.Dispose();
            return _oHsmodelList;
        }
        #endregion

        #region Salemancode List
        public static global::System.Collections.Generic.List<string> DrpSalemancodeList()
        {
            global::System.Collections.Generic.List<string> _oSalemancodeList = new global::System.Collections.Generic.List<string>();
            global::System.Data.SqlClient.SqlDataReader _oReader = MobileRetentionOrderBal.GetSearch(GetDB(), MobileRetentionOrder.Para.salesmancode, "active=1 and salesmancode<>'' group by salesmancode order by salesmancode", null, null);
            while (_oReader.Read()){
                _oSalemancodeList.Add(_oReader[MobileRetentionOrder.Para.salesmancode].ToString());
            }
            if (_oReader != null) _oReader.Close(); _oReader.Dispose();
            return _oSalemancodeList;
        }
        #endregion

        #region GetSim_Number
        public static string GetSim_Number(MobileRetentionOrder x_oMobileRetentionOrder)
        {
            if (string.IsNullOrEmpty(x_oMobileRetentionOrder.GetEdf_no())) { return string.Empty; }
            return MobileRetentionOrderBal.GetSim_Number(x_oMobileRetentionOrder.GetEdf_no());
        }

        public static string GetSim_Number(string x_sEdf_no)
        {
            if (string.IsNullOrEmpty(x_sEdf_no)) { return string.Empty; }
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append(" SELECT sim_card_no FROM sunday_form ");
            _oQuery.Append(" WHERE referenceno='" + x_sEdf_no + "'  AND created_by='CC RET' AND rownum<=1");
            string _sSim_no = SYSConn<ODBCConnect>.Connect().GetExecuteScalar(_oQuery.ToString());
            if (string.IsNullOrEmpty(_sSim_no)) { return string.Empty; }
            return _sSim_no;
        }
        #endregion

        protected static MobileOrderAddressRevision SetByMobileOrderAddressRecord(MobileOrderAddressEntity x_oMobileOrderAddressEntity)
        {
            MobileOrderAddressRevision _oMobileOrderAddressRevision = new MobileOrderAddressRevision(SYSConn<MSSQLConnect>.Connect());
            _oMobileOrderAddressRevision.address_type = x_oMobileOrderAddressEntity.address_type;
            _oMobileOrderAddressRevision.d_blk = x_oMobileOrderAddressEntity.d_blk;
            _oMobileOrderAddressRevision.d_build = x_oMobileOrderAddressEntity.d_build;
            _oMobileOrderAddressRevision.d_district = x_oMobileOrderAddressEntity.d_district;
            _oMobileOrderAddressRevision.d_floor = x_oMobileOrderAddressEntity.d_floor;
            _oMobileOrderAddressRevision.d_region = x_oMobileOrderAddressEntity.d_region;
            _oMobileOrderAddressRevision.d_room = x_oMobileOrderAddressEntity.d_room;
            _oMobileOrderAddressRevision.d_street = x_oMobileOrderAddressEntity.d_street;
            _oMobileOrderAddressRevision.d_type = x_oMobileOrderAddressEntity.d_type;
            _oMobileOrderAddressRevision.address_id = x_oMobileOrderAddressEntity.address_id;
            _oMobileOrderAddressRevision.order_id = x_oMobileOrderAddressEntity.order_id;

            return _oMobileOrderAddressRevision;
        }

        protected static string GetSetIMEI(MobileRetentionOrder x_oMobileRetentionOrder)
        {

            if (x_oMobileRetentionOrder.GetImei_no() == string.Empty &&
                    x_oMobileRetentionOrder.GetSku() != string.Empty &&
                    x_oMobileRetentionOrder.GetEdf_no() != string.Empty)
            {
                return "AWAIT";
            }
            else if (x_oMobileRetentionOrder.GetImei_no() == string.Empty &&
                    x_oMobileRetentionOrder.GetSku() != string.Empty)
            {
                return  "AO";
            }
            else
            {
                return x_oMobileRetentionOrder.imei_no;
            }
        }

        

        #region BackUp Order
        public static bool BackUpOrder(int x_iBackup_Order_id, string x_sUid)
        {
            using (ISession<MSSQLConnect> _oSession = (new SessionFactory<MSSQLConnect>()).OpenSession())
            using (ITransaction _oTransaction = _oSession.BeginTransaction())
            {
                bool _bRegisterAddress = false;
                bool _bBillingAddress = false;
                bool _bMobileOrderMNPDetail = false;
                bool _bMobileOrderThreeParty = false;
                bool _bOrderHistory = false;
                bool _bBusinessVasHistory = false;
                MobileOrderAddressRevision _oRegisteredAddressRevision = new MobileOrderAddressRevision(SYSConn<MSSQLConnect>.Connect());
                MobileOrderAddressEntity[] _oRegisteredAddressArr = MobileOrderAddressRepository.GetArrayObj(SYSConn<MSSQLConnect>.Connect(),1, "address_type='REGISTERED_ADDRESS' and order_id='"+x_iBackup_Order_id.ToString()+"'", null, null);
                if (_oRegisteredAddressArr != null)
                {
                    if (_oRegisteredAddressArr.Length > 0)
                    {
                        _oRegisteredAddressRevision=SetByMobileOrderAddressRecord(_oRegisteredAddressArr[0]);
                        int _iMid = _oSession.InsertReturnID(_oRegisteredAddressRevision, true);
                        if (_iMid > 0)
                        {
                            _bRegisterAddress = true;
                            _oRegisteredAddressRevision.mid = _iMid;
                        }
                    }
                }
                MobileOrderAddressRevision _oBillingAddressRevision = new MobileOrderAddressRevision(SYSConn<MSSQLConnect>.Connect());
                MobileOrderAddressEntity[] _oBillingAddressArr = MobileOrderAddressRepository.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), 1, "address_type='BILLING_ADDRESS' and order_id='" + x_iBackup_Order_id.ToString() + "'", null, null);
                if (_oBillingAddressArr != null)
                {
                    if (_oBillingAddressArr.Length > 0)
                    {

                        _oBillingAddressRevision = SetByMobileOrderAddressRecord(_oBillingAddressArr[0]);
                        int _iMid = _oSession.InsertReturnID(_oBillingAddressRevision, true);
                        if (_iMid > 0)
                        {
                            _bBillingAddress = true;
                            _oBillingAddressRevision.mid = _iMid;
                        }
                    }
                }

                MobileOrderMNPDetailRevision _oMobileOrderMNPDetailRevision = new MobileOrderMNPDetailRevision(SYSConn<MSSQLConnect>.Connect());
                MobileOrderMNPDetailEntity[] _oMobileOrderMNPDetailArr = MobileOrderMNPDetailRepository.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), 1, "order_id='" + x_iBackup_Order_id + "'", null, null);
                if (_oMobileOrderMNPDetailArr != null)
                {
                    if (_oMobileOrderMNPDetailArr.Length > 0)
                    {
                        _oMobileOrderMNPDetailRevision.company_name = _oMobileOrderMNPDetailArr[0].company_name;
                        _oMobileOrderMNPDetailRevision.hkid = _oMobileOrderMNPDetailArr[0].hkid;
                        _oMobileOrderMNPDetailRevision.mnp_id = _oMobileOrderMNPDetailArr[0].mnp_id;
                        _oMobileOrderMNPDetailRevision.order_id = _oMobileOrderMNPDetailArr[0].order_id;
                        _oMobileOrderMNPDetailRevision.registered_name = _oMobileOrderMNPDetailArr[0].registered_name;
                        _oMobileOrderMNPDetailRevision.service_activation_date = _oMobileOrderMNPDetailArr[0].service_activation_date;
                        _oMobileOrderMNPDetailRevision.service_activation_time = _oMobileOrderMNPDetailArr[0].service_activation_time;
                        _oMobileOrderMNPDetailRevision.ticker_number = _oMobileOrderMNPDetailArr[0].ticker_number;
                        _oMobileOrderMNPDetailRevision.transfer_idd_deposit = _oMobileOrderMNPDetailArr[0].transfer_idd_deposit;
                        _oMobileOrderMNPDetailRevision.transfer_idd_roaming_deposit = _oMobileOrderMNPDetailArr[0].transfer_idd_roaming_deposit;
                        _oMobileOrderMNPDetailRevision.transfer_no_add_proof_deposit = _oMobileOrderMNPDetailArr[0].transfer_no_add_proof_deposit;
                        _oMobileOrderMNPDetailRevision.transfer_no_hk_id_holder_deposit = _oMobileOrderMNPDetailArr[0].transfer_no_hk_id_holder_deposit;
                        _oMobileOrderMNPDetailRevision.transfer_others_deposit = _oMobileOrderMNPDetailArr[0].transfer_others_deposit;
                        _oMobileOrderMNPDetailRevision.transfer_to_3g = _oMobileOrderMNPDetailArr[0].transfer_to_3g;
                        int _iMid = _oSession.InsertReturnID(_oMobileOrderMNPDetailRevision, true);
                        if (_iMid > 0)
                        {
                            _bMobileOrderMNPDetail = true;
                            _oMobileOrderMNPDetailRevision.mid = _iMid;
                        }

                    }
                }
                MobileOrderThreePartyRevision _oMobileOrderThreePartyRevision = new MobileOrderThreePartyRevision(SYSConn<MSSQLConnect>.Connect());
                MobileOrderThreePartyEntity[] _oMobileOrderThreePartyArr = MobileOrderThreePartyRepository.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), 1, "order_id='" + x_iBackup_Order_id + "'", null, null);
                if (_oMobileOrderThreePartyArr != null)
                {
                    if (_oMobileOrderThreePartyArr.Length > 0)
                    {
                        _oMobileOrderThreePartyRevision.arthurization_person = _oMobileOrderThreePartyArr[0].arthurization_person;
                        _oMobileOrderThreePartyRevision.contact_no = _oMobileOrderThreePartyArr[0].contact_no;
                        _oMobileOrderThreePartyRevision.hkid = _oMobileOrderThreePartyArr[0].hkid;
                        _oMobileOrderThreePartyRevision.order_id = _oMobileOrderThreePartyArr[0].order_id;
                        _oMobileOrderThreePartyRevision.plural = _oMobileOrderThreePartyArr[0].plural;
                        _oMobileOrderThreePartyRevision.three_party = _oMobileOrderThreePartyArr[0].three_party;
                        _oMobileOrderThreePartyRevision.tpy_id = _oMobileOrderThreePartyArr[0].tpy_id;
                        _oMobileOrderThreePartyRevision.type = _oMobileOrderThreePartyArr[0].type;
                        int _iMid = _oSession.InsertReturnID(_oMobileOrderThreePartyRevision, true);
                        if (_iMid > 0)
                        {
                            _bMobileOrderThreeParty = true;
                            _oMobileOrderThreePartyRevision.mid = _iMid;
                        }
                    }
                }
                MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect(), x_iBackup_Order_id);
                MobileRetentionPreviousOrder _oMobileRetentionPreviousOrder = new MobileRetentionPreviousOrder(SYSConn<MSSQLConnect>.Connect());
                
                _oMobileRetentionPreviousOrder.ac_no = _oMobileRetentionOrder.ac_no;
                _oMobileRetentionPreviousOrder.accept = _oMobileRetentionOrder.accept;
                _oMobileRetentionPreviousOrder.accessory_code = _oMobileRetentionOrder.accessory_code;
                _oMobileRetentionPreviousOrder.accessory_desc = _oMobileRetentionOrder.accessory_desc;
                _oMobileRetentionPreviousOrder.accessory_imei = _oMobileRetentionOrder.accessory_imei;
                _oMobileRetentionPreviousOrder.accessory_price = _oMobileRetentionOrder.accessory_price;
                _oMobileRetentionPreviousOrder.action_date = _oMobileRetentionOrder.action_date;
                _oMobileRetentionPreviousOrder.action_eff_date = _oMobileRetentionOrder.action_eff_date;
                _oMobileRetentionPreviousOrder.action_required = _oMobileRetentionOrder.action_required;
                _oMobileRetentionPreviousOrder.active = _oMobileRetentionOrder.active;
                _oMobileRetentionPreviousOrder.aig_gift = _oMobileRetentionOrder.aig_gift;
                _oMobileRetentionPreviousOrder.amount = _oMobileRetentionOrder.amount;
                _oMobileRetentionPreviousOrder.bank_code = _oMobileRetentionOrder.bank_code;
                _oMobileRetentionPreviousOrder.bank_name = _oMobileRetentionOrder.bank_name;
                _oMobileRetentionPreviousOrder.bill_address_his_id = _oBillingAddressRevision.GetMid();
                _oMobileRetentionPreviousOrder.bill_cut_date = _oMobileRetentionOrder.bill_cut_date;
                _oMobileRetentionPreviousOrder.bill_cut_num = _oMobileRetentionOrder.bill_cut_num;
                _oMobileRetentionPreviousOrder.bill_medium = _oMobileRetentionOrder.bill_medium;
                _oMobileRetentionPreviousOrder.bill_medium_email = _oMobileRetentionOrder.bill_medium_email;
                _oMobileRetentionPreviousOrder.bill_medium_waive = _oMobileRetentionOrder.bill_medium_waive;
                _oMobileRetentionPreviousOrder.bundle_name = _oMobileRetentionOrder.bundle_name;
                _oMobileRetentionPreviousOrder.cancel_renew = _oMobileRetentionOrder.cancel_renew;
                _oMobileRetentionPreviousOrder.card_exp_month = _oMobileRetentionOrder.card_exp_month;
                _oMobileRetentionPreviousOrder.card_exp_year = _oMobileRetentionOrder.card_exp_year;
                _oMobileRetentionPreviousOrder.card_holder = _oMobileRetentionOrder.card_holder;
                _oMobileRetentionPreviousOrder.card_no = _oMobileRetentionOrder.card_no;
                _oMobileRetentionPreviousOrder.card_type = _oMobileRetentionOrder.card_type;
                _oMobileRetentionPreviousOrder.cdate = _oMobileRetentionOrder.cdate;
                _oMobileRetentionPreviousOrder.channel = _oMobileRetentionOrder.channel;
                _oMobileRetentionPreviousOrder.cid = _oMobileRetentionOrder.cid;
                _oMobileRetentionPreviousOrder.con_eff_date = _oMobileRetentionOrder.con_eff_date;
                _oMobileRetentionPreviousOrder.con_per = _oMobileRetentionOrder.con_per;
                _oMobileRetentionPreviousOrder.contact_no = _oMobileRetentionOrder.contact_no;
                _oMobileRetentionPreviousOrder.contact_person = _oMobileRetentionOrder.contact_person;
                _oMobileRetentionPreviousOrder.cooling_date = _oMobileRetentionOrder.cooling_date;
                _oMobileRetentionPreviousOrder.cooling_offer = _oMobileRetentionOrder.cooling_offer;
                _oMobileRetentionPreviousOrder.cust_name = _oMobileRetentionOrder.cust_name;
                _oMobileRetentionPreviousOrder.cust_staff_no = _oMobileRetentionOrder.cust_staff_no;
                _oMobileRetentionPreviousOrder.cust_type = _oMobileRetentionOrder.cust_type;
                _oMobileRetentionPreviousOrder.d_address = _oMobileRetentionOrder.d_address;
                _oMobileRetentionPreviousOrder.d_date = _oMobileRetentionOrder.d_date;
                _oMobileRetentionPreviousOrder.d_time = _oMobileRetentionOrder.d_time;
                _oMobileRetentionPreviousOrder.ddate = DateTime.Now;
                _oMobileRetentionPreviousOrder.del_remark = _oMobileRetentionOrder.del_remark;
                _oMobileRetentionPreviousOrder.did = x_sUid;
                _oMobileRetentionPreviousOrder.easywatch_ord_id = _oMobileRetentionOrder.easywatch_ord_id;
                _oMobileRetentionPreviousOrder.easywatch_type = _oMobileRetentionOrder.easywatch_type;
                _oMobileRetentionPreviousOrder.edate = _oMobileRetentionOrder.edate;
                _oMobileRetentionPreviousOrder.edf_no = _oMobileRetentionOrder.edf_no;
                _oMobileRetentionPreviousOrder.exist_cust_plan = _oMobileRetentionOrder.exist_cust_plan;
                _oMobileRetentionPreviousOrder.exist_plan = _oMobileRetentionOrder.exist_plan;
                _oMobileRetentionPreviousOrder.existing_contract_end_date = _oMobileRetentionOrder.existing_contract_end_date;
                _oMobileRetentionPreviousOrder.ext_place_tel = _oMobileRetentionOrder.ext_place_tel;
                _oMobileRetentionPreviousOrder.extn = _oMobileRetentionOrder.extn;
                _oMobileRetentionPreviousOrder.extra_d_charge = _oMobileRetentionOrder.extra_d_charge;
                _oMobileRetentionPreviousOrder.extra_offer = _oMobileRetentionOrder.extra_offer;
                _oMobileRetentionPreviousOrder.extra_rebate = _oMobileRetentionOrder.extra_rebate;
                _oMobileRetentionPreviousOrder.extra_rebate_amount = _oMobileRetentionOrder.extra_rebate_amount;
                _oMobileRetentionPreviousOrder.fast_start = _oMobileRetentionOrder.fast_start;
                _oMobileRetentionPreviousOrder.free_mon = _oMobileRetentionOrder.free_mon;
                _oMobileRetentionPreviousOrder.gift_code = _oMobileRetentionOrder.gift_code;
                _oMobileRetentionPreviousOrder.gift_code2 = _oMobileRetentionOrder.gift_code2;
                _oMobileRetentionPreviousOrder.gift_code3 = _oMobileRetentionOrder.gift_code3;
                _oMobileRetentionPreviousOrder.gift_code4 = _oMobileRetentionOrder.gift_code4;
                _oMobileRetentionPreviousOrder.gift_desc = _oMobileRetentionOrder.gift_desc;
                _oMobileRetentionPreviousOrder.gift_desc2 = _oMobileRetentionOrder.gift_desc2;
                _oMobileRetentionPreviousOrder.gift_desc3 = _oMobileRetentionOrder.gift_desc3;
                _oMobileRetentionPreviousOrder.gift_desc4 = _oMobileRetentionOrder.gift_desc4;
                _oMobileRetentionPreviousOrder.gift_imei = _oMobileRetentionOrder.gift_imei;
                _oMobileRetentionPreviousOrder.gift_imei2 = _oMobileRetentionOrder.gift_imei2;
                _oMobileRetentionPreviousOrder.gift_imei3 = _oMobileRetentionOrder.gift_imei3;
                _oMobileRetentionPreviousOrder.gift_imei4 = _oMobileRetentionOrder.gift_imei4;
                _oMobileRetentionPreviousOrder.go_wireless = _oMobileRetentionOrder.go_wireless;
                _oMobileRetentionPreviousOrder.go_wireless_package_code = _oMobileRetentionOrder.go_wireless_package_code;
                _oMobileRetentionPreviousOrder.hkid = _oMobileRetentionOrder.hkid;
                _oMobileRetentionPreviousOrder.hs_model = _oMobileRetentionOrder.hs_model;
                _oMobileRetentionPreviousOrder.hs_offer_type_id = _oMobileRetentionOrder.hs_offer_type_id;
                _oMobileRetentionPreviousOrder.id_type = _oMobileRetentionOrder.id_type;
                _oMobileRetentionPreviousOrder.imei_no = GetSetIMEI(_oMobileRetentionOrder);
                _oMobileRetentionPreviousOrder.installment_period = _oMobileRetentionOrder.installment_period;
                _oMobileRetentionPreviousOrder.language = _oMobileRetentionOrder.language;
                _oMobileRetentionPreviousOrder.lob = _oMobileRetentionOrder.lob;
                _oMobileRetentionPreviousOrder.lob_ac = _oMobileRetentionOrder.lob_ac;
                _oMobileRetentionPreviousOrder.log_date = _oMobileRetentionOrder.log_date;
                _oMobileRetentionPreviousOrder.m_card_exp_month = _oMobileRetentionOrder.m_card_exp_month;
                _oMobileRetentionPreviousOrder.m_card_exp_year = _oMobileRetentionOrder.m_card_exp_year;
                _oMobileRetentionPreviousOrder.m_card_holder2 = _oMobileRetentionOrder.m_card_holder2;
                _oMobileRetentionPreviousOrder.m_card_no = _oMobileRetentionOrder.m_card_no;
                _oMobileRetentionPreviousOrder.m_card_type = _oMobileRetentionOrder.m_card_type;
                _oMobileRetentionPreviousOrder.m_rebate_amount = _oMobileRetentionOrder.m_rebate_amount;
                _oMobileRetentionPreviousOrder.mnp_his_id = _oMobileOrderMNPDetailRevision.GetMid();
                _oMobileRetentionPreviousOrder.monthly_payment_method = _oMobileRetentionOrder.monthly_payment_method;
                _oMobileRetentionPreviousOrder.mrt_no = _oMobileRetentionOrder.mrt_no;
                _oMobileRetentionPreviousOrder.next_bill = _oMobileRetentionOrder.next_bill;
                _oMobileRetentionPreviousOrder.normal_rebate = _oMobileRetentionOrder.normal_rebate;
                _oMobileRetentionPreviousOrder.ob_program_id = _oMobileRetentionOrder.ob_program_id;
                _oMobileRetentionPreviousOrder.old_ord_id = _oMobileRetentionOrder.old_ord_id;
                _oMobileRetentionPreviousOrder.ord_place_by = _oMobileRetentionOrder.ord_place_by;
                _oMobileRetentionPreviousOrder.ord_place_hkid = _oMobileRetentionOrder.ord_place_hkid;
                _oMobileRetentionPreviousOrder.ord_place_id_type = _oMobileRetentionOrder.ord_place_id_type;
                _oMobileRetentionPreviousOrder.ord_place_rel = _oMobileRetentionOrder.ord_place_rel;
                _oMobileRetentionPreviousOrder.order_id = _oMobileRetentionOrder.order_id;
                _oMobileRetentionPreviousOrder.org_fee = _oMobileRetentionOrder.org_fee;
                _oMobileRetentionPreviousOrder.org_ftg = _oMobileRetentionOrder.org_ftg;
                _oMobileRetentionPreviousOrder.org_mrt = _oMobileRetentionOrder.org_mrt;
                _oMobileRetentionPreviousOrder.pay_method = _oMobileRetentionOrder.pay_method;
                _oMobileRetentionPreviousOrder.pcd_paid_go_wireless = _oMobileRetentionOrder.pcd_paid_go_wireless;
                _oMobileRetentionPreviousOrder.plan_eff = _oMobileRetentionOrder.plan_eff;
                _oMobileRetentionPreviousOrder.plan_eff_date = _oMobileRetentionOrder.plan_eff_date;
                _oMobileRetentionPreviousOrder.pos_ref_no = _oMobileRetentionOrder.pos_ref_no;
                _oMobileRetentionPreviousOrder.preferred_languages = _oMobileRetentionOrder.preferred_languages;
                _oMobileRetentionPreviousOrder.premium = _oMobileRetentionOrder.premium;
                _oMobileRetentionPreviousOrder.prepayment_waive = _oMobileRetentionOrder.prepayment_waive;
                _oMobileRetentionPreviousOrder.program = _oMobileRetentionOrder.program;
                _oMobileRetentionPreviousOrder.r_offer = _oMobileRetentionOrder.r_offer;
                _oMobileRetentionPreviousOrder.rate_plan = _oMobileRetentionOrder.rate_plan;
                _oMobileRetentionPreviousOrder.reasons = _oMobileRetentionOrder.reasons;
                _oMobileRetentionPreviousOrder.rebate = _oMobileRetentionOrder.rebate;
                _oMobileRetentionPreviousOrder.rebate_amount = _oMobileRetentionOrder.rebate_amount;
                _oMobileRetentionPreviousOrder.rec_no = _oMobileRetentionOrder.order_id;
                _oMobileRetentionPreviousOrder.ref_salesmancode = _oMobileRetentionOrder.ref_salesmancode;
                _oMobileRetentionPreviousOrder.ref_staff_no = _oMobileRetentionOrder.ref_staff_no;
                _oMobileRetentionPreviousOrder.register_address = _oMobileRetentionOrder.register_address;
                _oMobileRetentionPreviousOrder.registered_address_his_id = _oRegisteredAddressRevision.mid;
                _oMobileRetentionPreviousOrder.remarks = _oMobileRetentionOrder.remarks;
                _oMobileRetentionPreviousOrder.remarks2EDF = _oMobileRetentionOrder.remarks2EDF;
                _oMobileRetentionPreviousOrder.remarks2PY = _oMobileRetentionOrder.remarks2PY;
                _oMobileRetentionPreviousOrder.normal_rebate_type = _oMobileRetentionOrder.normal_rebate_type;
                _oMobileRetentionPreviousOrder.retrieve_cnt = _oMobileRetentionOrder.retrieve_cnt;
                _oMobileRetentionPreviousOrder.s_premium = _oMobileRetentionOrder.s_premium;
                _oMobileRetentionPreviousOrder.s_premium2 = _oMobileRetentionOrder.s_premium2;
                _oMobileRetentionPreviousOrder.salesmancode = _oMobileRetentionOrder.salesmancode;
                _oMobileRetentionPreviousOrder.sim_item_code = _oMobileRetentionOrder.sim_item_code;
                _oMobileRetentionPreviousOrder.sim_item_name = _oMobileRetentionOrder.sim_item_name;
                _oMobileRetentionPreviousOrder.sim_item_number = _oMobileRetentionOrder.sim_item_number;
                _oMobileRetentionPreviousOrder.sim_mrt_no = _oMobileRetentionOrder.sim_mrt_no;
                _oMobileRetentionPreviousOrder.sku = _oMobileRetentionOrder.sku;
                _oMobileRetentionPreviousOrder.sp_d_date = _oMobileRetentionOrder.sp_d_date;
                _oMobileRetentionPreviousOrder.sp_ref_no = _oMobileRetentionOrder.sp_ref_no;
                _oMobileRetentionPreviousOrder.special_approval = _oMobileRetentionOrder.special_approval;
                _oMobileRetentionPreviousOrder.staff_name = _oMobileRetentionOrder.staff_name;
                _oMobileRetentionPreviousOrder.staff_no = _oMobileRetentionOrder.staff_no;
                _oMobileRetentionPreviousOrder.status_by_cs_admin = _oMobileRetentionOrder.status_by_cs_admin;
                _oMobileRetentionPreviousOrder.teamcode = _oMobileRetentionOrder.teamcode;
                _oMobileRetentionPreviousOrder.third_party_credit_card = _oMobileRetentionOrder.third_party_credit_card;
                _oMobileRetentionPreviousOrder.third_party_hkid = _oMobileRetentionOrder.third_party_hkid;
                _oMobileRetentionPreviousOrder.third_party_id_type = _oMobileRetentionOrder.third_party_id_type;
                _oMobileRetentionPreviousOrder.tpy_his_id = _oMobileOrderThreePartyRevision.mid;
                _oMobileRetentionPreviousOrder.tl_name = _oMobileRetentionOrder.tl_name;
                _oMobileRetentionPreviousOrder.trade_field = _oMobileRetentionOrder.trade_field;
                _oMobileRetentionPreviousOrder.vas_eff_date = _oMobileRetentionOrder.vas_eff_date;
                _oMobileRetentionPreviousOrder.vip_case = _oMobileRetentionOrder.vip_case;
                _oMobileRetentionPreviousOrder.waive = _oMobileRetentionOrder.waive;
                _oMobileRetentionPreviousOrder.issue_type = _oMobileRetentionOrder.issue_type;
                _oMobileRetentionPreviousOrder.sms_mrt = _oMobileRetentionOrder.sms_mrt;
                _oMobileRetentionPreviousOrder.ord_place_tel = _oMobileRetentionOrder.ord_place_tel;
                _oMobileRetentionPreviousOrder.change_payment_type = _oMobileRetentionOrder.change_payment_type;
                _oMobileRetentionPreviousOrder.gender = _oMobileRetentionOrder.gender;
                _oMobileRetentionPreviousOrder.date_of_birth = _oMobileRetentionOrder.date_of_birth;


                _oMobileRetentionPreviousOrder.monthly_bank_account_bank_code=_oMobileRetentionOrder.monthly_bank_account_bank_code;
                _oMobileRetentionPreviousOrder.monthly_bank_account_branch_code=_oMobileRetentionOrder.monthly_bank_account_branch_code;
                _oMobileRetentionPreviousOrder.monthly_bank_account_no=_oMobileRetentionOrder.monthly_bank_account_no;
                _oMobileRetentionPreviousOrder.monthly_bank_account_holder=_oMobileRetentionOrder.monthly_bank_account_holder;
                _oMobileRetentionPreviousOrder.monthly_bank_account_id_type=_oMobileRetentionOrder.monthly_bank_account_id_type;
                _oMobileRetentionPreviousOrder.monthly_bank_account_hkid=_oMobileRetentionOrder.monthly_bank_account_hkid;
                _oMobileRetentionPreviousOrder.monthly_bank_account_hkid2 = _oMobileRetentionOrder.monthly_bank_account_hkid2;


                _oMobileRetentionPreviousOrder.delivery_collection_type = _oMobileRetentionOrder.delivery_collection_type;
                _oMobileRetentionPreviousOrder.delivery_exchange = _oMobileRetentionOrder.delivery_exchange;
                _oMobileRetentionPreviousOrder.delivery_exchange_location = _oMobileRetentionOrder.delivery_exchange_location;
                _oMobileRetentionPreviousOrder.delivery_exchange_option = _oMobileRetentionOrder.delivery_exchange_option;

                _oMobileRetentionPreviousOrder.redemption_notice_option = _oMobileRetentionOrder.redemption_notice_option;
                _oMobileRetentionPreviousOrder.s_premium1 = _oMobileRetentionOrder.s_premium1;
                _oMobileRetentionPreviousOrder.family_name = _oMobileRetentionOrder.family_name;
                _oMobileRetentionPreviousOrder.given_name = _oMobileRetentionOrder.given_name;
                _oMobileRetentionPreviousOrder.monthly_payment_type = _oMobileRetentionOrder.monthly_payment_type;

                _oMobileRetentionPreviousOrder.upgrade_existing_contract_edate = _oMobileRetentionOrder.upgrade_existing_contract_edate;
                _oMobileRetentionPreviousOrder.upgrade_existing_contract_sdate = _oMobileRetentionOrder.upgrade_existing_contract_sdate;
                _oMobileRetentionPreviousOrder.upgrade_existing_customer_type = _oMobileRetentionOrder.upgrade_existing_customer_type;
                _oMobileRetentionPreviousOrder.upgrade_handset_offer_rebate_schedule = _oMobileRetentionOrder.upgrade_handset_offer_rebate_schedule;
                _oMobileRetentionPreviousOrder.upgrade_sponsorships_amount = _oMobileRetentionOrder.upgrade_sponsorships_amount;
                _oMobileRetentionPreviousOrder.upgrade_type = _oMobileRetentionOrder.upgrade_type;


                _oMobileRetentionPreviousOrder.upgrade_existing_pccw_customer = _oMobileRetentionOrder.upgrade_existing_pccw_customer;
                _oMobileRetentionPreviousOrder.upgrade_service_account_no = _oMobileRetentionOrder.upgrade_service_account_no;
                _oMobileRetentionPreviousOrder.upgrade_registered_mobile_no = _oMobileRetentionOrder.upgrade_registered_mobile_no;
                _oMobileRetentionPreviousOrder.upgrade_service_tenure = _oMobileRetentionOrder.upgrade_service_tenure;
                _oMobileRetentionPreviousOrder.action_of_rate_plan_effective = _oMobileRetentionOrder.action_of_rate_plan_effective;
                _oMobileRetentionPreviousOrder.existing_smart_phone_model = _oMobileRetentionOrder.existing_smart_phone_model;
                _oMobileRetentionPreviousOrder.existing_smart_phone_imei = _oMobileRetentionOrder.existing_smart_phone_imei;

                _oMobileRetentionPreviousOrder.m_3rd_contact_no = _oMobileRetentionOrder.m_3rd_contact_no;
                _oMobileRetentionPreviousOrder.m_3rd_hkid = _oMobileRetentionOrder.m_3rd_hkid;
                _oMobileRetentionPreviousOrder.m_3rd_hkid2 = _oMobileRetentionOrder.m_3rd_hkid2;
                _oMobileRetentionPreviousOrder.m_3rd_id_type = _oMobileRetentionOrder.m_3rd_id_type;

                _oMobileRetentionPreviousOrder.cn_mrt_no = _oMobileRetentionOrder.cn_mrt_no;
                _oMobileRetentionPreviousOrder.pool = _oMobileRetentionOrder.pool;
                _oMobileRetentionPreviousOrder.card_ref_no = _oMobileRetentionOrder.card_ref_no;
                _oMobileRetentionPreviousOrder.s_premium3 = _oMobileRetentionOrder.s_premium3;
                _oMobileRetentionPreviousOrder.s_premium4 = _oMobileRetentionOrder.s_premium4;
                _oMobileRetentionPreviousOrder.ftg_tenure = _oMobileRetentionOrder.ftg_tenure;
                _oMobileRetentionPreviousOrder.first_month_fee = _oMobileRetentionOrder.first_month_fee;
                _oMobileRetentionPreviousOrder.first_month_license_fee = _oMobileRetentionOrder.first_month_license_fee;
                _oMobileRetentionPreviousOrder.special_handling_dummy_code = _oMobileRetentionOrder.special_handling_dummy_code;
                _oMobileRetentionPreviousOrder.accessory_waive = _oMobileRetentionOrder.accessory_waive;


                int _iHisOrderId = -1;
                _iHisOrderId = _oSession.InsertReturnID(_oMobileRetentionPreviousOrder, true);
                if (_iHisOrderId > 0)
                    _bOrderHistory = true;
                if (_bOrderHistory)
                {
                    MobileOrderVasEntity[] _oMobileOrderVasArr = MobileOrderVasRepository.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), "order_id='" + x_iBackup_Order_id.ToString() + "'", null, null);
                    if (_oMobileOrderVasArr != null)
                    {
                        for (int i = 0; i < _oMobileOrderVasArr.Length; i++)
                        {
                            _bBusinessVasHistory = true;
                            MobileOrderVasRevision _oMobileOrderVasRevision = MobileOrderVasRevisionRepository.CreateEntityInstanceObject(SYSConn<MSSQLConnect>.Connect());
                            _oMobileOrderVasRevision.active = _oMobileOrderVasArr[i].active;
                            _oMobileOrderVasRevision.cdate = _oMobileOrderVasArr[i].cdate;
                            _oMobileOrderVasRevision.fee = _oMobileOrderVasArr[i].fee;
                            _oMobileOrderVasRevision.his_order_id = _iHisOrderId;
                            _oMobileOrderVasRevision.multi_id = _oMobileOrderVasArr[i].multi_id;
                            _oMobileOrderVasRevision.order_id = _oMobileOrderVasArr[i].order_id;
                            _oMobileOrderVasRevision.vas_field = _oMobileOrderVasArr[i].vas_field;
                            _oMobileOrderVasRevision.vas_id = _oMobileOrderVasArr[i].vas_id;
                            _oMobileOrderVasRevision.vas_value = _oMobileOrderVasArr[i].vas_value;

                            int _iMid= _oSession.InsertReturnID(_oMobileOrderVasRevision,true);
                            if (_iMid<0)
                            {
                                _bBusinessVasHistory = false;
                                break;
                            }
                        }
                    }
                    else
                    {
                        _bBusinessVasHistory = true;
                    }
                }
                string issue_type = _oMobileRetentionOrder.GetIssue_type();
                if (String.Compare(issue_type, "MOBILE LITE") == 0)
                {
                    if ((_bRegisterAddress && _bMobileOrderMNPDetail && _bMobileOrderThreeParty && _bOrderHistory && _bBusinessVasHistory) || _bBillingAddress)
                    {
                        _oTransaction.Commit();
                    }
                    else
                    {
                        _oTransaction.Rollback();
                    }
                }
                else
                {
                    if (_bOrderHistory)
                    {
                        _oTransaction.Commit();
                    }
                    else
                    {
                        _oTransaction.Rollback();
                    }
                }
            }

        
            return true;
        }
        #endregion

        #region Set Vas
        public static void SetVas(ref MobileRetentionOrder x_oMobileRetentionOrder, string x_sVas, string x_sValue,string x_sValue2, bool x_bMult)
        {
            if (x_sValue.Trim() == string.Empty)
            {
                DeleteVas(ref x_oMobileRetentionOrder, x_sVas);
                return;
            }

            if (x_oMobileRetentionOrder == null) return;
            if (x_oMobileRetentionOrder.GetOrder_id() == null) return;

            bool _bHasRecord = false;
            SqlDataReader _oHasDr = GetDB().GetSearch("SELECT  * FROM MobileOrderVas WHERE order_id = '" + ((int)x_oMobileRetentionOrder.GetOrder_id()).ToString() + "' AND vas_field='" + x_sVas + "'");
            if (_oHasDr.Read())
                _bHasRecord = true;
            _oHasDr.Close();
            _oHasDr.Dispose();

            if (!_bHasRecord)
            {
                string _sVas_id = GetDB().GetExecuteScalar("SELECT id FROM " + Configurator.MSSQLTablePrefix + "BusinessVas WHERE vas_field='" + x_sVas + "' AND vas_value='" + x_sValue + "'");
                string _sMulti_id = GetDB().GetExecuteScalar("SELECT id FROM " + Configurator.MSSQLTablePrefix + "BusinessVasDescription WHERE vas='" + x_sVas + "' AND fee='" + x_sValue2 + "'");
                if (_sVas_id == string.Empty) return;
                MobileOrderVas _oMobileOrderVas = (MobileOrderVas)MobileOrderVasRepository.CreateEntityInstanceObject();
                _oMobileOrderVas.SetDB(GetDB());
                _oMobileOrderVas.SetOrder_id(x_oMobileRetentionOrder.order_id);
                _oMobileOrderVas.SetVas_field(x_sVas);
                _oMobileOrderVas.SetVas_value((x_sValue.Equals(string.Empty)) ? null : x_sValue);
                _oMobileOrderVas.SetFee((x_sValue2.Equals(string.Empty)) ? null : x_sValue2);

                int _iVas_id;
                if (int.TryParse(_sVas_id, out _iVas_id))
                    _oMobileOrderVas.SetVas_id(_iVas_id);
                else
                    _oMobileOrderVas.SetVas_id(null);

                int _iMulti_id;
                if (int.TryParse(_sMulti_id, out _iMulti_id))
                    _oMobileOrderVas.SetMulti_id(_iMulti_id);
                else
                    _oMobileOrderVas.SetMulti_id(null);

                _oMobileOrderVas.SetCdate(x_oMobileRetentionOrder.GetCdate());
                _oMobileOrderVas.SetActive(true);
                MobileOrderVasBal.InsertReturnLastID_SP(GetDB(), _oMobileOrderVas);
            }
        }
        #endregion

        #region Delete Vas
        public static void DeleteVas(ref MobileRetentionOrder x_oMobileRetentionOrder, string x_sVas)
        {
            try
            {
                if (x_oMobileRetentionOrder == null) return;
                if (x_oMobileRetentionOrder.GetOrder_id() == null) return;
                if (string.IsNullOrEmpty(x_sVas)) return;
                GetDB().ExplicitNonQuery("DELETE FROM " + Configurator.MSSQLTablePrefix + "MobileOrderVas WHERE order_id='" + ((int)x_oMobileRetentionOrder.GetOrder_id()).ToString() + "' AND vas_field='" + x_sVas + "'");
            }
            catch{

            }
        }
        #endregion

        #region Save Vas
        public static void SaveVas(ref MobileRetentionOrder x_oMobileRetentionOrder, string x_sVas, string x_sValue, string x_sValue2, bool x_bMult)
        {
            if (x_sValue.Trim() == string.Empty)
            {
                DeleteVas(ref x_oMobileRetentionOrder, x_sVas);
                return;
            }
            
            if (x_oMobileRetentionOrder == null) return;
            if (x_oMobileRetentionOrder.GetOrder_id() == null) return;

            string _sVas_id = GetDB().GetExecuteScalar("SELECT id FROM " + Configurator.MSSQLTablePrefix + "BusinessVas WHERE vas_field='" + x_sVas + "' AND vas_value='" + x_sValue.Trim() + "'");
            string _sMulti_id = GetDB().GetExecuteScalar("SELECT id FROM " + Configurator.MSSQLTablePrefix + "BusinessVasDescription WHERE vas='" + x_sVas + "' AND fee='" + x_sValue2.Trim() + "'");

            if (_sVas_id == string.Empty) return;
            bool _bFlag = true;
            string _sId = GetDB().GetExecuteScalar("SELECT a.id FROM " + Configurator.MSSQLTablePrefix + "MobileOrderVas a RIGHT JOIN " + Configurator.MSSQLTablePrefix + "BusinessVas b on a.vas_field=b.vas_field AND a.vas_field=b.vas_field AND a.vas_id=b.id WHERE a.order_id='" + ((int)x_oMobileRetentionOrder.GetOrder_id()).ToString() + "' AND a.vas_field='" + x_sVas.Trim() + "'");
            if (_sId != string.Empty)
            {
                int _iId;
                if (int.TryParse(_sId.Trim(), out _iId))
                {
                    _bFlag = false;
                    MobileOrderVas _oMobileOrderVas = new MobileOrderVas(GetDB(), _iId);
                    _oMobileOrderVas.SetOrder_id(x_oMobileRetentionOrder.order_id);
                    _oMobileOrderVas.SetVas_value((x_sValue.Equals(string.Empty)) ? null : x_sValue);
                    _oMobileOrderVas.SetFee((x_sValue2.Equals(string.Empty)) ? null : x_sValue2);

                    int _iVas_id;
                    if (int.TryParse(_sVas_id, out _iVas_id))
                        _oMobileOrderVas.SetVas_id(_iVas_id);
                    else
                        _oMobileOrderVas.SetVas_id(null);

                    int _iMulti_id;
                    if (int.TryParse(_sMulti_id, out _iMulti_id))
                        _oMobileOrderVas.SetMulti_id(_iMulti_id);
                    else
                        _oMobileOrderVas.SetMulti_id(null);

                    _oMobileOrderVas.SetCdate(x_oMobileRetentionOrder.GetCdate());

                    using (ISession<MSSQLConnect> _oSession = (new SessionFactory<MSSQLConnect>()).OpenSession())
                    using (ITransaction _oTransaction = _oSession.BeginTransaction())
                    {
                        _oSession.Update(_oMobileOrderVas);
                        _oTransaction.Commit();
                    }
                }
            }

            if (_bFlag)
            {
                MobileOrderVas _oMobileOrderVas = (MobileOrderVas)MobileOrderVasRepository.CreateEntityInstanceObject();
                _oMobileOrderVas.SetOrder_id(x_oMobileRetentionOrder.order_id);
                _oMobileOrderVas.SetVas_field(x_sVas);
                _oMobileOrderVas.SetVas_value((x_sValue.Equals(string.Empty)) ? null : x_sValue);
                _oMobileOrderVas.SetFee((x_sValue2.Equals(string.Empty)) ? null : x_sValue2);

                int _iVas_id;
                if (int.TryParse(_sVas_id, out _iVas_id))
                    _oMobileOrderVas.SetVas_id(_iVas_id);
                else
                    _oMobileOrderVas.SetVas_id(null);

                int _iMulti_id;
                if (int.TryParse(_sMulti_id, out _iMulti_id))
                    _oMobileOrderVas.SetMulti_id(_iMulti_id);
                else
                    _oMobileOrderVas.SetMulti_id(null);

                _oMobileOrderVas.SetCdate(x_oMobileRetentionOrder.GetCdate());
                _oMobileOrderVas.SetActive(true);
                MobileOrderVasBal.InsertReturnLastID_SP(GetDB(), _oMobileOrderVas);
            }
        }
        #endregion

        #region GetDB
        public static MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.bWithNoLock = true;
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return _oDB;
        }
        #endregion

        #region Get Oracle DB
        protected static ODBCConnect GetORDB()
        {
            ODBCConnect _oDB = new ODBCConnect();
            _oDB.SetConnStr(Configurator.DBName.ORADNS + ((Configurator.IsUat()) ? "2" : string.Empty));
            return _oDB;
        }
        #endregion
    }
}


