using System;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
///-- Description:	<Description,Table :[MobileRetentionOrder],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [MobileRetentionOrder] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"MobileRetentionOrder")]
    public class MobileRetentionOrderEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
        public bool n_bStrNullToEmpty = true;
        #region StrNullToEmpty
        public bool StrNullToEmpty
        {
            get
            {
                return this.n_bStrNullToEmpty;
            }
            set
            {
                this.n_bStrNullToEmpty = value;
            }
        }
        #endregion
        
        
        protected string n_sGift_imei=global::System.String.Empty;
        #region gift_imei
        [System.Data.Linq.Mapping.Column(Name="[gift_imei]", Storage="n_sGift_imei")]
        public string gift_imei{
            get{
                return this.n_sGift_imei;
            }
            set{
                this.n_sGift_imei=value;
            }
        }
        #endregion gift_imei
        
        
        protected string n_sS_premium4=global::System.String.Empty;
        #region s_premium4
        [System.Data.Linq.Mapping.Column(Name="[s_premium4]", Storage="n_sS_premium4")]
        public string s_premium4{
            get{
                return this.n_sS_premium4;
            }
            set{
                this.n_sS_premium4=value;
            }
        }
        #endregion s_premium4
        
        
        protected string n_sUpgrade_existing_customer_type=global::System.String.Empty;
        #region upgrade_existing_customer_type
        [System.Data.Linq.Mapping.Column(Name="[upgrade_existing_customer_type]", Storage="n_sUpgrade_existing_customer_type")]
        public string upgrade_existing_customer_type{
            get{
                return this.n_sUpgrade_existing_customer_type;
            }
            set{
                this.n_sUpgrade_existing_customer_type=value;
            }
        }
        #endregion upgrade_existing_customer_type
        
        
        protected string n_sGift_desc4=global::System.String.Empty;
        #region gift_desc4
        [System.Data.Linq.Mapping.Column(Name="[gift_desc4]", Storage="n_sGift_desc4")]
        public string gift_desc4{
            get{
                return this.n_sGift_desc4;
            }
            set{
                this.n_sGift_desc4=value;
            }
        }
        #endregion gift_desc4
        
        
        protected string n_sAccessory_desc=global::System.String.Empty;
        #region accessory_desc
        [System.Data.Linq.Mapping.Column(Name="[accessory_desc]", Storage="n_sAccessory_desc")]
        public string accessory_desc{
            get{
                return this.n_sAccessory_desc;
            }
            set{
                this.n_sAccessory_desc=value;
            }
        }
        #endregion accessory_desc
        
        
        protected string n_sStaff_name=global::System.String.Empty;
        #region staff_name
        [System.Data.Linq.Mapping.Column(Name="[staff_name]", Storage="n_sStaff_name")]
        public string staff_name{
            get{
                return this.n_sStaff_name;
            }
            set{
                this.n_sStaff_name=value;
            }
        }
        #endregion staff_name
        
        
        protected string n_sAction_required=global::System.String.Empty;
        #region action_required
        [System.Data.Linq.Mapping.Column(Name="[action_required]", Storage="n_sAction_required")]
        public string action_required{
            get{
                return this.n_sAction_required;
            }
            set{
                this.n_sAction_required=value;
            }
        }
        #endregion action_required
        
        
        protected global::System.Nullable<DateTime> n_dVas_eff_date=null;
        #region vas_eff_date
        [System.Data.Linq.Mapping.Column(Name="[vas_eff_date]", Storage="n_dVas_eff_date")]
        public global::System.Nullable<DateTime> vas_eff_date{
            get{
                return this.n_dVas_eff_date;
            }
            set{
                this.n_dVas_eff_date=value;
            }
        }
        #endregion vas_eff_date
        
        
        protected string n_sMonthly_bank_account_bank_code=global::System.String.Empty;
        #region monthly_bank_account_bank_code
        [System.Data.Linq.Mapping.Column(Name="[monthly_bank_account_bank_code]", Storage="n_sMonthly_bank_account_bank_code")]
        public string monthly_bank_account_bank_code{
            get{
                return this.n_sMonthly_bank_account_bank_code;
            }
            set{
                this.n_sMonthly_bank_account_bank_code=value;
            }
        }
        #endregion monthly_bank_account_bank_code
        
        
        protected string n_sSim_item_number=global::System.String.Empty;
        #region sim_item_number
        [System.Data.Linq.Mapping.Column(Name="[sim_item_number]", Storage="n_sSim_item_number")]
        public string sim_item_number{
            get{
                return this.n_sSim_item_number;
            }
            set{
                this.n_sSim_item_number=value;
            }
        }
        #endregion sim_item_number
        
        
        protected string n_sSpecial_handling_dummy_code=global::System.String.Empty;
        #region special_handling_dummy_code
        [System.Data.Linq.Mapping.Column(Name="[special_handling_dummy_code]", Storage="n_sSpecial_handling_dummy_code")]
        public string special_handling_dummy_code{
            get{
                return this.n_sSpecial_handling_dummy_code;
            }
            set{
                this.n_sSpecial_handling_dummy_code=value;
            }
        }
        #endregion special_handling_dummy_code
        
        
        protected string n_sCard_no=global::System.String.Empty;
        #region card_no
        [System.Data.Linq.Mapping.Column(Name="[card_no]", Storage="n_sCard_no")]
        public string card_no{
            get{
                return this.n_sCard_no;
            }
            set{
                this.n_sCard_no=value;
            }
        }
        #endregion card_no
        
        
        protected string n_sM_card_exp_year=global::System.String.Empty;
        #region m_card_exp_year
        [System.Data.Linq.Mapping.Column(Name="[m_card_exp_year]", Storage="n_sM_card_exp_year")]
        public string m_card_exp_year{
            get{
                return this.n_sM_card_exp_year;
            }
            set{
                this.n_sM_card_exp_year=value;
            }
        }
        #endregion m_card_exp_year
        
        
        protected string n_sBill_medium_email=global::System.String.Empty;
        #region bill_medium_email
        [System.Data.Linq.Mapping.Column(Name="[bill_medium_email]", Storage="n_sBill_medium_email")]
        public string bill_medium_email{
            get{
                return this.n_sBill_medium_email;
            }
            set{
                this.n_sBill_medium_email=value;
            }
        }
        #endregion bill_medium_email
        
        
        protected string n_sRemarks2PY=global::System.String.Empty;
        #region remarks2PY
        [System.Data.Linq.Mapping.Column(Name="[remarks2PY]", Storage="n_sRemarks2PY")]
        public string remarks2PY{
            get{
                return this.n_sRemarks2PY;
            }
            set{
                this.n_sRemarks2PY=value;
            }
        }
        #endregion remarks2PY
        
        
        protected string n_sTrade_field=global::System.String.Empty;
        #region trade_field
        [System.Data.Linq.Mapping.Column(Name="[trade_field]", Storage="n_sTrade_field")]
        public string trade_field{
            get{
                return this.n_sTrade_field;
            }
            set{
                this.n_sTrade_field=value;
            }
        }
        #endregion trade_field
        
        
        protected string n_sOrd_place_tel=global::System.String.Empty;
        #region ord_place_tel
        [System.Data.Linq.Mapping.Column(Name="[ord_place_tel]", Storage="n_sOrd_place_tel")]
        public string ord_place_tel{
            get{
                return this.n_sOrd_place_tel;
            }
            set{
                this.n_sOrd_place_tel=value;
            }
        }
        #endregion ord_place_tel
        
        
        protected string n_sAction_of_rate_plan_effective=global::System.String.Empty;
        #region action_of_rate_plan_effective
        [System.Data.Linq.Mapping.Column(Name="[action_of_rate_plan_effective]", Storage="n_sAction_of_rate_plan_effective")]
        public string action_of_rate_plan_effective{
            get{
                return this.n_sAction_of_rate_plan_effective;
            }
            set{
                this.n_sAction_of_rate_plan_effective=value;
            }
        }
        #endregion action_of_rate_plan_effective
        
        
        protected string n_sCooling_offer=global::System.String.Empty;
        #region cooling_offer
        [System.Data.Linq.Mapping.Column(Name="[cooling_offer]", Storage="n_sCooling_offer")]
        public string cooling_offer{
            get{
                return this.n_sCooling_offer;
            }
            set{
                this.n_sCooling_offer=value;
            }
        }
        #endregion cooling_offer
        
        
        protected string n_sUpgrade_handset_offer_rebate_schedule=global::System.String.Empty;
        #region upgrade_handset_offer_rebate_schedule
        [System.Data.Linq.Mapping.Column(Name="[upgrade_handset_offer_rebate_schedule]", Storage="n_sUpgrade_handset_offer_rebate_schedule")]
        public string upgrade_handset_offer_rebate_schedule{
            get{
                return this.n_sUpgrade_handset_offer_rebate_schedule;
            }
            set{
                this.n_sUpgrade_handset_offer_rebate_schedule=value;
            }
        }
        #endregion upgrade_handset_offer_rebate_schedule
        
        
        protected string n_sChange_payment_type=global::System.String.Empty;
        #region change_payment_type
        [System.Data.Linq.Mapping.Column(Name="[change_payment_type]", Storage="n_sChange_payment_type")]
        public string change_payment_type{
            get{
                return this.n_sChange_payment_type;
            }
            set{
                this.n_sChange_payment_type=value;
            }
        }
        #endregion change_payment_type
        
        
        protected global::System.Nullable<DateTime> n_dDate_of_birth=null;
        #region date_of_birth
        [System.Data.Linq.Mapping.Column(Name="[date_of_birth]", Storage="n_dDate_of_birth")]
        public global::System.Nullable<DateTime> date_of_birth{
            get{
                return this.n_dDate_of_birth;
            }
            set{
                this.n_dDate_of_birth=value;
            }
        }
        #endregion date_of_birth
        
        
        protected string n_sContact_person=global::System.String.Empty;
        #region contact_person
        [System.Data.Linq.Mapping.Column(Name="[contact_person]", Storage="n_sContact_person")]
        public string contact_person{
            get{
                return this.n_sContact_person;
            }
            set{
                this.n_sContact_person=value;
            }
        }
        #endregion contact_person
        
        
        protected string n_sExtra_d_charge=global::System.String.Empty;
        #region extra_d_charge
        [System.Data.Linq.Mapping.Column(Name="[extra_d_charge]", Storage="n_sExtra_d_charge")]
        public string extra_d_charge{
            get{
                return this.n_sExtra_d_charge;
            }
            set{
                this.n_sExtra_d_charge=value;
            }
        }
        #endregion extra_d_charge
        
        
        protected string n_sTl_name=global::System.String.Empty;
        #region tl_name
        [System.Data.Linq.Mapping.Column(Name="[tl_name]", Storage="n_sTl_name")]
        public string tl_name{
            get{
                return this.n_sTl_name;
            }
            set{
                this.n_sTl_name=value;
            }
        }
        #endregion tl_name
        
        
        protected global::System.Nullable<bool> n_bFast_start=null;
        #region fast_start
        [System.Data.Linq.Mapping.Column(Name="[fast_start]", Storage="n_bFast_start")]
        public global::System.Nullable<bool> fast_start{
            get{
                return this.n_bFast_start;
            }
            set{
                this.n_bFast_start=value;
            }
        }
        #endregion fast_start
        
        
        protected string n_sSp_ref_no=global::System.String.Empty;
        #region sp_ref_no
        [System.Data.Linq.Mapping.Column(Name="[sp_ref_no]", Storage="n_sSp_ref_no")]
        public string sp_ref_no{
            get{
                return this.n_sSp_ref_no;
            }
            set{
                this.n_sSp_ref_no=value;
            }
        }
        #endregion sp_ref_no
        
        
        protected global::System.Nullable<DateTime> n_dEdate=null;
        #region edate
        [System.Data.Linq.Mapping.Column(Name="[edate]", Storage="n_dEdate")]
        public global::System.Nullable<DateTime> edate{
            get{
                return this.n_dEdate;
            }
            set{
                this.n_dEdate=value;
            }
        }
        #endregion edate
        
        
        protected string n_sExist_cust_plan=global::System.String.Empty;
        #region exist_cust_plan
        [System.Data.Linq.Mapping.Column(Name="[exist_cust_plan]", Storage="n_sExist_cust_plan")]
        public string exist_cust_plan{
            get{
                return this.n_sExist_cust_plan;
            }
            set{
                this.n_sExist_cust_plan=value;
            }
        }
        #endregion exist_cust_plan
        
        
        protected string n_sOrd_place_rel=global::System.String.Empty;
        #region ord_place_rel
        [System.Data.Linq.Mapping.Column(Name="[ord_place_rel]", Storage="n_sOrd_place_rel")]
        public string ord_place_rel{
            get{
                return this.n_sOrd_place_rel;
            }
            set{
                this.n_sOrd_place_rel=value;
            }
        }
        #endregion ord_place_rel
        
        
        protected global::System.Nullable<int> n_iMrt_no=null;
        #region mrt_no
        [System.Data.Linq.Mapping.Column(Name="[mrt_no]", Storage="n_iMrt_no")]
        public global::System.Nullable<int> mrt_no{
            get{
                return this.n_iMrt_no;
            }
            set{
                this.n_iMrt_no=value;
            }
        }
        #endregion mrt_no
        
        
        protected string n_sImei_no=global::System.String.Empty;
        #region imei_no
        [System.Data.Linq.Mapping.Column(Name="[imei_no]", Storage="n_sImei_no")]
        public string imei_no{
            get{
                return this.n_sImei_no;
            }
            set{
                this.n_sImei_no=value;
            }
        }
        #endregion imei_no
        
        
        protected string n_sExisting_smart_phone_model=global::System.String.Empty;
        #region existing_smart_phone_model
        [System.Data.Linq.Mapping.Column(Name="[existing_smart_phone_model]", Storage="n_sExisting_smart_phone_model")]
        public string existing_smart_phone_model{
            get{
                return this.n_sExisting_smart_phone_model;
            }
            set{
                this.n_sExisting_smart_phone_model=value;
            }
        }
        #endregion existing_smart_phone_model
        
        
        protected string n_sBank_code=global::System.String.Empty;
        #region bank_code
        [System.Data.Linq.Mapping.Column(Name="[bank_code]", Storage="n_sBank_code")]
        public string bank_code{
            get{
                return this.n_sBank_code;
            }
            set{
                this.n_sBank_code=value;
            }
        }
        #endregion bank_code
        
        
        protected string n_sPos_ref_no=global::System.String.Empty;
        #region pos_ref_no
        [System.Data.Linq.Mapping.Column(Name="[pos_ref_no]", Storage="n_sPos_ref_no")]
        public string pos_ref_no{
            get{
                return this.n_sPos_ref_no;
            }
            set{
                this.n_sPos_ref_no=value;
            }
        }
        #endregion pos_ref_no
        
        
        protected global::System.Nullable<DateTime> n_dBill_cut_date=null;
        #region bill_cut_date
        [System.Data.Linq.Mapping.Column(Name="[bill_cut_date]", Storage="n_dBill_cut_date")]
        public global::System.Nullable<DateTime> bill_cut_date{
            get{
                return this.n_dBill_cut_date;
            }
            set{
                this.n_dBill_cut_date=value;
            }
        }
        #endregion bill_cut_date
        
        
        protected string n_sGift_imei3=global::System.String.Empty;
        #region gift_imei3
        [System.Data.Linq.Mapping.Column(Name="[gift_imei3]", Storage="n_sGift_imei3")]
        public string gift_imei3{
            get{
                return this.n_sGift_imei3;
            }
            set{
                this.n_sGift_imei3=value;
            }
        }
        #endregion gift_imei3
        
        
        protected string n_sExist_plan=global::System.String.Empty;
        #region exist_plan
        [System.Data.Linq.Mapping.Column(Name="[exist_plan]", Storage="n_sExist_plan")]
        public string exist_plan{
            get{
                return this.n_sExist_plan;
            }
            set{
                this.n_sExist_plan=value;
            }
        }
        #endregion exist_plan
        
        
        protected global::System.Nullable<bool> n_bWaive=null;
        #region waive
        [System.Data.Linq.Mapping.Column(Name="[waive]", Storage="n_bWaive")]
        public global::System.Nullable<bool> waive{
            get{
                return this.n_bWaive;
            }
            set{
                this.n_bWaive=value;
            }
        }
        #endregion waive
        
        
        protected string n_sProgram=global::System.String.Empty;
        #region program
        [System.Data.Linq.Mapping.Column(Name="[program]", Storage="n_sProgram")]
        public string program{
            get{
                return this.n_sProgram;
            }
            set{
                this.n_sProgram=value;
            }
        }
        #endregion program
        
        
        protected string n_sFirst_month_fee=global::System.String.Empty;
        #region first_month_fee
        [System.Data.Linq.Mapping.Column(Name="[first_month_fee]", Storage="n_sFirst_month_fee")]
        public string first_month_fee{
            get{
                return this.n_sFirst_month_fee;
            }
            set{
                this.n_sFirst_month_fee=value;
            }
        }
        #endregion first_month_fee
        
        
        protected string n_sR_offer=global::System.String.Empty;
        #region r_offer
        [System.Data.Linq.Mapping.Column(Name="[r_offer]", Storage="n_sR_offer")]
        public string r_offer{
            get{
                return this.n_sR_offer;
            }
            set{
                this.n_sR_offer=value;
            }
        }
        #endregion r_offer
        
        
        protected string n_sCid=global::System.String.Empty;
        #region cid
        [System.Data.Linq.Mapping.Column(Name="[cid]", Storage="n_sCid")]
        public string cid{
            get{
                return this.n_sCid;
            }
            set{
                this.n_sCid=value;
            }
        }
        #endregion cid
        
        
        protected string n_sDid=global::System.String.Empty;
        #region did
        [System.Data.Linq.Mapping.Column(Name="[did]", Storage="n_sDid")]
        public string did{
            get{
                return this.n_sDid;
            }
            set{
                this.n_sDid=value;
            }
        }
        #endregion did
        
        
        protected string n_sFtg_tenure=global::System.String.Empty;
        #region ftg_tenure
        [System.Data.Linq.Mapping.Column(Name="[ftg_tenure]", Storage="n_sFtg_tenure")]
        public string ftg_tenure{
            get{
                return this.n_sFtg_tenure;
            }
            set{
                this.n_sFtg_tenure=value;
            }
        }
        #endregion ftg_tenure
        
        
        protected string n_sCon_per=global::System.String.Empty;
        #region con_per
        [System.Data.Linq.Mapping.Column(Name="[con_per]", Storage="n_sCon_per")]
        public string con_per{
            get{
                return this.n_sCon_per;
            }
            set{
                this.n_sCon_per=value;
            }
        }
        #endregion con_per
        
        
        protected string n_sGift_code4=global::System.String.Empty;
        #region gift_code4
        [System.Data.Linq.Mapping.Column(Name="[gift_code4]", Storage="n_sGift_code4")]
        public string gift_code4{
            get{
                return this.n_sGift_code4;
            }
            set{
                this.n_sGift_code4=value;
            }
        }
        #endregion gift_code4
        
        
        protected string n_sEasywatch_type=global::System.String.Empty;
        #region easywatch_type
        [System.Data.Linq.Mapping.Column(Name="[easywatch_type]", Storage="n_sEasywatch_type")]
        public string easywatch_type{
            get{
                return this.n_sEasywatch_type;
            }
            set{
                this.n_sEasywatch_type=value;
            }
        }
        #endregion easywatch_type
        
        
        protected string n_sSms_mrt=global::System.String.Empty;
        #region sms_mrt
        [System.Data.Linq.Mapping.Column(Name="[sms_mrt]", Storage="n_sSms_mrt")]
        public string sms_mrt{
            get{
                return this.n_sSms_mrt;
            }
            set{
                this.n_sSms_mrt=value;
            }
        }
        #endregion sms_mrt
        
        
        protected string n_sMonthly_payment_method=global::System.String.Empty;
        #region monthly_payment_method
        [System.Data.Linq.Mapping.Column(Name="[monthly_payment_method]", Storage="n_sMonthly_payment_method")]
        public string monthly_payment_method{
            get{
                return this.n_sMonthly_payment_method;
            }
            set{
                this.n_sMonthly_payment_method=value;
            }
        }
        #endregion monthly_payment_method
        
        
        protected string n_sRemarks2EDF=global::System.String.Empty;
        #region remarks2EDF
        [System.Data.Linq.Mapping.Column(Name="[remarks2EDF]", Storage="n_sRemarks2EDF")]
        public string remarks2EDF{
            get{
                return this.n_sRemarks2EDF;
            }
            set{
                this.n_sRemarks2EDF=value;
            }
        }
        #endregion remarks2EDF
        
        
        protected string n_sGift_desc3=global::System.String.Empty;
        #region gift_desc3
        [System.Data.Linq.Mapping.Column(Name="[gift_desc3]", Storage="n_sGift_desc3")]
        public string gift_desc3{
            get{
                return this.n_sGift_desc3;
            }
            set{
                this.n_sGift_desc3=value;
            }
        }
        #endregion gift_desc3
        
        
        protected string n_sGift_imei4=global::System.String.Empty;
        #region gift_imei4
        [System.Data.Linq.Mapping.Column(Name="[gift_imei4]", Storage="n_sGift_imei4")]
        public string gift_imei4{
            get{
                return this.n_sGift_imei4;
            }
            set{
                this.n_sGift_imei4=value;
            }
        }
        #endregion gift_imei4
        
        
        protected string n_sMonthly_bank_account_hkid2=global::System.String.Empty;
        #region monthly_bank_account_hkid2
        [System.Data.Linq.Mapping.Column(Name="[monthly_bank_account_hkid2]", Storage="n_sMonthly_bank_account_hkid2")]
        public string monthly_bank_account_hkid2{
            get{
                return this.n_sMonthly_bank_account_hkid2;
            }
            set{
                this.n_sMonthly_bank_account_hkid2=value;
            }
        }
        #endregion monthly_bank_account_hkid2
        
        
        protected global::System.Nullable<DateTime> n_dD_date=null;
        #region d_date
        [System.Data.Linq.Mapping.Column(Name="[d_date]", Storage="n_dD_date")]
        public global::System.Nullable<DateTime> d_date{
            get{
                return this.n_dD_date;
            }
            set{
                this.n_dD_date=value;
            }
        }
        #endregion d_date
        
        
        protected string n_sGift_desc=global::System.String.Empty;
        #region gift_desc
        [System.Data.Linq.Mapping.Column(Name="[gift_desc]", Storage="n_sGift_desc")]
        public string gift_desc{
            get{
                return this.n_sGift_desc;
            }
            set{
                this.n_sGift_desc=value;
            }
        }
        #endregion gift_desc
        
        
        protected string n_sPool=global::System.String.Empty;
        #region pool
        [System.Data.Linq.Mapping.Column(Name="[pool]", Storage="n_sPool")]
        public string pool{
            get{
                return this.n_sPool;
            }
            set{
                this.n_sPool=value;
            }
        }
        #endregion pool
        
        
        protected global::System.Nullable<long> n_lCn_mrt_no=null;
        #region cn_mrt_no
        [System.Data.Linq.Mapping.Column(Name="[cn_mrt_no]", Storage="n_lCn_mrt_no")]
        public global::System.Nullable<long> cn_mrt_no{
            get{
                return this.n_lCn_mrt_no;
            }
            set{
                this.n_lCn_mrt_no=value;
            }
        }
        #endregion cn_mrt_no
        
        
        protected string n_sAccessory_imei=global::System.String.Empty;
        #region accessory_imei
        [System.Data.Linq.Mapping.Column(Name="[accessory_imei]", Storage="n_sAccessory_imei")]
        public string accessory_imei{
            get{
                return this.n_sAccessory_imei;
            }
            set{
                this.n_sAccessory_imei=value;
            }
        }
        #endregion accessory_imei
        
        
        protected string n_sThird_party_credit_card=global::System.String.Empty;
        #region third_party_credit_card
        [System.Data.Linq.Mapping.Column(Name="[third_party_credit_card]", Storage="n_sThird_party_credit_card")]
        public string third_party_credit_card{
            get{
                return this.n_sThird_party_credit_card;
            }
            set{
                this.n_sThird_party_credit_card=value;
            }
        }
        #endregion third_party_credit_card
        
        
        protected string n_sSpecial_approval=global::System.String.Empty;
        #region special_approval
        [System.Data.Linq.Mapping.Column(Name="[special_approval]", Storage="n_sSpecial_approval")]
        public string special_approval{
            get{
                return this.n_sSpecial_approval;
            }
            set{
                this.n_sSpecial_approval=value;
            }
        }
        #endregion special_approval
        
        
        protected global::System.Nullable<DateTime> n_dUpgrade_existing_contract_edate=null;
        #region upgrade_existing_contract_edate
        [System.Data.Linq.Mapping.Column(Name="[upgrade_existing_contract_edate]", Storage="n_dUpgrade_existing_contract_edate")]
        public global::System.Nullable<DateTime> upgrade_existing_contract_edate{
            get{
                return this.n_dUpgrade_existing_contract_edate;
            }
            set{
                this.n_dUpgrade_existing_contract_edate=value;
            }
        }
        #endregion upgrade_existing_contract_edate
        
        
        protected string n_sAccessory_code=global::System.String.Empty;
        #region accessory_code
        [System.Data.Linq.Mapping.Column(Name="[accessory_code]", Storage="n_sAccessory_code")]
        public string accessory_code{
            get{
                return this.n_sAccessory_code;
            }
            set{
                this.n_sAccessory_code=value;
            }
        }
        #endregion accessory_code
        
        
        protected string n_sS_premium=global::System.String.Empty;
        #region s_premium
        [System.Data.Linq.Mapping.Column(Name="[s_premium]", Storage="n_sS_premium")]
        public string s_premium{
            get{
                return this.n_sS_premium;
            }
            set{
                this.n_sS_premium=value;
            }
        }
        #endregion s_premium
        
        
        protected string n_sRef_staff_no=global::System.String.Empty;
        #region ref_staff_no
        [System.Data.Linq.Mapping.Column(Name="[ref_staff_no]", Storage="n_sRef_staff_no")]
        public string ref_staff_no{
            get{
                return this.n_sRef_staff_no;
            }
            set{
                this.n_sRef_staff_no=value;
            }
        }
        #endregion ref_staff_no
        
        
        protected string n_sAccessory_price=global::System.String.Empty;
        #region accessory_price
        [System.Data.Linq.Mapping.Column(Name="[accessory_price]", Storage="n_sAccessory_price")]
        public string accessory_price{
            get{
                return this.n_sAccessory_price;
            }
            set{
                this.n_sAccessory_price=value;
            }
        }
        #endregion accessory_price
        
        
        protected string n_sM_card_exp_month=global::System.String.Empty;
        #region m_card_exp_month
        [System.Data.Linq.Mapping.Column(Name="[m_card_exp_month]", Storage="n_sM_card_exp_month")]
        public string m_card_exp_month{
            get{
                return this.n_sM_card_exp_month;
            }
            set{
                this.n_sM_card_exp_month=value;
            }
        }
        #endregion m_card_exp_month
        
        
        protected string n_sInstallment_period=global::System.String.Empty;
        #region installment_period
        [System.Data.Linq.Mapping.Column(Name="[installment_period]", Storage="n_sInstallment_period")]
        public string installment_period{
            get{
                return this.n_sInstallment_period;
            }
            set{
                this.n_sInstallment_period=value;
            }
        }
        #endregion installment_period
        
        
        protected string n_sM_card_type=global::System.String.Empty;
        #region m_card_type
        [System.Data.Linq.Mapping.Column(Name="[m_card_type]", Storage="n_sM_card_type")]
        public string m_card_type{
            get{
                return this.n_sM_card_type;
            }
            set{
                this.n_sM_card_type=value;
            }
        }
        #endregion m_card_type
        
        
        protected string n_sEasywatch_ord_id=global::System.String.Empty;
        #region easywatch_ord_id
        [System.Data.Linq.Mapping.Column(Name="[easywatch_ord_id]", Storage="n_sEasywatch_ord_id")]
        public string easywatch_ord_id{
            get{
                return this.n_sEasywatch_ord_id;
            }
            set{
                this.n_sEasywatch_ord_id=value;
            }
        }
        #endregion easywatch_ord_id
        
        
        protected global::System.Nullable<bool> n_bNormal_rebate=null;
        #region normal_rebate
        [System.Data.Linq.Mapping.Column(Name="[normal_rebate]", Storage="n_bNormal_rebate")]
        public global::System.Nullable<bool> normal_rebate{
            get{
                return this.n_bNormal_rebate;
            }
            set{
                this.n_bNormal_rebate=value;
            }
        }
        #endregion normal_rebate
        
        
        protected string n_sM_rebate_amount=global::System.String.Empty;
        #region m_rebate_amount
        [System.Data.Linq.Mapping.Column(Name="[m_rebate_amount]", Storage="n_sM_rebate_amount")]
        public string m_rebate_amount{
            get{
                return this.n_sM_rebate_amount;
            }
            set{
                this.n_sM_rebate_amount=value;
            }
        }
        #endregion m_rebate_amount
        
        
        protected string n_sM_card_holder2=global::System.String.Empty;
        #region m_card_holder2
        [System.Data.Linq.Mapping.Column(Name="[m_card_holder2]", Storage="n_sM_card_holder2")]
        public string m_card_holder2{
            get{
                return this.n_sM_card_holder2;
            }
            set{
                this.n_sM_card_holder2=value;
            }
        }
        #endregion m_card_holder2
        
        
        protected string n_sMonthly_bank_account_holder=global::System.String.Empty;
        #region monthly_bank_account_holder
        [System.Data.Linq.Mapping.Column(Name="[monthly_bank_account_holder]", Storage="n_sMonthly_bank_account_holder")]
        public string monthly_bank_account_holder{
            get{
                return this.n_sMonthly_bank_account_holder;
            }
            set{
                this.n_sMonthly_bank_account_holder=value;
            }
        }
        #endregion monthly_bank_account_holder
        
        
        protected global::System.Nullable<bool> n_bActive=null;
        #region active
        [System.Data.Linq.Mapping.Column(Name="[active]", Storage="n_bActive")]
        public global::System.Nullable<bool> active{
            get{
                return this.n_bActive;
            }
            set{
                this.n_bActive=value;
            }
        }
        #endregion active
        
        
        protected string n_sS_premium1=global::System.String.Empty;
        #region s_premium1
        [System.Data.Linq.Mapping.Column(Name="[s_premium1]", Storage="n_sS_premium1")]
        public string s_premium1{
            get{
                return this.n_sS_premium1;
            }
            set{
                this.n_sS_premium1=value;
            }
        }
        #endregion s_premium1
        
        
        protected string n_sCard_exp_month=global::System.String.Empty;
        #region card_exp_month
        [System.Data.Linq.Mapping.Column(Name="[card_exp_month]", Storage="n_sCard_exp_month")]
        public string card_exp_month{
            get{
                return this.n_sCard_exp_month;
            }
            set{
                this.n_sCard_exp_month=value;
            }
        }
        #endregion card_exp_month
        
        
        protected string n_sOb_program_id=global::System.String.Empty;
        #region ob_program_id
        [System.Data.Linq.Mapping.Column(Name="[ob_program_id]", Storage="n_sOb_program_id")]
        public string ob_program_id{
            get{
                return this.n_sOb_program_id;
            }
            set{
                this.n_sOb_program_id=value;
            }
        }
        #endregion ob_program_id
        
        
        protected string n_sSku=global::System.String.Empty;
        #region sku
        [System.Data.Linq.Mapping.Column(Name="[sku]", Storage="n_sSku")]
        public string sku{
            get{
                return this.n_sSku;
            }
            set{
                this.n_sSku=value;
            }
        }
        #endregion sku
        
        
        protected string n_sSalesmancode=global::System.String.Empty;
        #region salesmancode
        [System.Data.Linq.Mapping.Column(Name="[salesmancode]", Storage="n_sSalesmancode")]
        public string salesmancode{
            get{
                return this.n_sSalesmancode;
            }
            set{
                this.n_sSalesmancode=value;
            }
        }
        #endregion salesmancode
        
        
        protected string n_sGo_wireless_package_code=global::System.String.Empty;
        #region go_wireless_package_code
        [System.Data.Linq.Mapping.Column(Name="[go_wireless_package_code]", Storage="n_sGo_wireless_package_code")]
        public string go_wireless_package_code{
            get{
                return this.n_sGo_wireless_package_code;
            }
            set{
                this.n_sGo_wireless_package_code=value;
            }
        }
        #endregion go_wireless_package_code
        
        
        protected string n_sLob=global::System.String.Empty;
        #region lob
        [System.Data.Linq.Mapping.Column(Name="[lob]", Storage="n_sLob")]
        public string lob{
            get{
                return this.n_sLob;
            }
            set{
                this.n_sLob=value;
            }
        }
        #endregion lob
        
        
        protected string n_sRef_salesmancode=global::System.String.Empty;
        #region ref_salesmancode
        [System.Data.Linq.Mapping.Column(Name="[ref_salesmancode]", Storage="n_sRef_salesmancode")]
        public string ref_salesmancode{
            get{
                return this.n_sRef_salesmancode;
            }
            set{
                this.n_sRef_salesmancode=value;
            }
        }
        #endregion ref_salesmancode
        
        
        protected string n_sThird_party_hkid=global::System.String.Empty;
        #region third_party_hkid
        [System.Data.Linq.Mapping.Column(Name="[third_party_hkid]", Storage="n_sThird_party_hkid")]
        public string third_party_hkid{
            get{
                return this.n_sThird_party_hkid;
            }
            set{
                this.n_sThird_party_hkid=value;
            }
        }
        #endregion third_party_hkid
        
        
        protected string n_sUpgrade_existing_pccw_customer=global::System.String.Empty;
        #region upgrade_existing_pccw_customer
        [System.Data.Linq.Mapping.Column(Name="[upgrade_existing_pccw_customer]", Storage="n_sUpgrade_existing_pccw_customer")]
        public string upgrade_existing_pccw_customer{
            get{
                return this.n_sUpgrade_existing_pccw_customer;
            }
            set{
                this.n_sUpgrade_existing_pccw_customer=value;
            }
        }
        #endregion upgrade_existing_pccw_customer
        
        
        protected string n_sD_address=global::System.String.Empty;
        #region d_address
        [System.Data.Linq.Mapping.Column(Name="[d_address]", Storage="n_sD_address")]
        public string d_address{
            get{
                return this.n_sD_address;
            }
            set{
                this.n_sD_address=value;
            }
        }
        #endregion d_address
        
        
        protected string n_sUpgrade_registered_mobile_no=global::System.String.Empty;
        #region upgrade_registered_mobile_no
        [System.Data.Linq.Mapping.Column(Name="[upgrade_registered_mobile_no]", Storage="n_sUpgrade_registered_mobile_no")]
        public string upgrade_registered_mobile_no{
            get{
                return this.n_sUpgrade_registered_mobile_no;
            }
            set{
                this.n_sUpgrade_registered_mobile_no=value;
            }
        }
        #endregion upgrade_registered_mobile_no
        
        
        protected string n_sGift_code3=global::System.String.Empty;
        #region gift_code3
        [System.Data.Linq.Mapping.Column(Name="[gift_code3]", Storage="n_sGift_code3")]
        public string gift_code3{
            get{
                return this.n_sGift_code3;
            }
            set{
                this.n_sGift_code3=value;
            }
        }
        #endregion gift_code3
        
        
        protected string n_sNormal_rebate_type=global::System.String.Empty;
        #region normal_rebate_type
        [System.Data.Linq.Mapping.Column(Name="[normal_rebate_type]", Storage="n_sNormal_rebate_type")]
        public string normal_rebate_type{
            get{
                return this.n_sNormal_rebate_type;
            }
            set{
                this.n_sNormal_rebate_type=value;
            }
        }
        #endregion normal_rebate_type
        
        
        protected string n_sGift_desc2=global::System.String.Empty;
        #region gift_desc2
        [System.Data.Linq.Mapping.Column(Name="[gift_desc2]", Storage="n_sGift_desc2")]
        public string gift_desc2{
            get{
                return this.n_sGift_desc2;
            }
            set{
                this.n_sGift_desc2=value;
            }
        }
        #endregion gift_desc2
        
        
        protected string n_sMonthly_bank_account_branch_code=global::System.String.Empty;
        #region monthly_bank_account_branch_code
        [System.Data.Linq.Mapping.Column(Name="[monthly_bank_account_branch_code]", Storage="n_sMonthly_bank_account_branch_code")]
        public string monthly_bank_account_branch_code{
            get{
                return this.n_sMonthly_bank_account_branch_code;
            }
            set{
                this.n_sMonthly_bank_account_branch_code=value;
            }
        }
        #endregion monthly_bank_account_branch_code
        
        
        protected string n_sRemarks=global::System.String.Empty;
        #region remarks
        [System.Data.Linq.Mapping.Column(Name="[remarks]", Storage="n_sRemarks")]
        public string remarks{
            get{
                return this.n_sRemarks;
            }
            set{
                this.n_sRemarks=value;
            }
        }
        #endregion remarks
        
        
        protected string n_sAccept=global::System.String.Empty;
        #region accept
        [System.Data.Linq.Mapping.Column(Name="[accept]", Storage="n_sAccept")]
        public string accept{
            get{
                return this.n_sAccept;
            }
            set{
                this.n_sAccept=value;
            }
        }
        #endregion accept
        
        
        protected string n_sDelivery_exchange=global::System.String.Empty;
        #region delivery_exchange
        [System.Data.Linq.Mapping.Column(Name="[delivery_exchange]", Storage="n_sDelivery_exchange")]
        public string delivery_exchange{
            get{
                return this.n_sDelivery_exchange;
            }
            set{
                this.n_sDelivery_exchange=value;
            }
        }
        #endregion delivery_exchange
        
        
        protected string n_sGift_code2=global::System.String.Empty;
        #region gift_code2
        [System.Data.Linq.Mapping.Column(Name="[gift_code2]", Storage="n_sGift_code2")]
        public string gift_code2{
            get{
                return this.n_sGift_code2;
            }
            set{
                this.n_sGift_code2=value;
            }
        }
        #endregion gift_code2
        
        
        protected global::System.Nullable<bool> n_bPrepayment_waive=null;
        #region prepayment_waive
        [System.Data.Linq.Mapping.Column(Name="[prepayment_waive]", Storage="n_bPrepayment_waive")]
        public global::System.Nullable<bool> prepayment_waive{
            get{
                return this.n_bPrepayment_waive;
            }
            set{
                this.n_bPrepayment_waive=value;
            }
        }
        #endregion prepayment_waive
        
        
        protected string n_sExisting_smart_phone_imei=global::System.String.Empty;
        #region existing_smart_phone_imei
        [System.Data.Linq.Mapping.Column(Name="[existing_smart_phone_imei]", Storage="n_sExisting_smart_phone_imei")]
        public string existing_smart_phone_imei{
            get{
                return this.n_sExisting_smart_phone_imei;
            }
            set{
                this.n_sExisting_smart_phone_imei=value;
            }
        }
        #endregion existing_smart_phone_imei
        
        
        protected string n_sCust_name=global::System.String.Empty;
        #region cust_name
        [System.Data.Linq.Mapping.Column(Name="[cust_name]", Storage="n_sCust_name")]
        public string cust_name{
            get{
                return this.n_sCust_name;
            }
            set{
                this.n_sCust_name=value;
            }
        }
        #endregion cust_name
        
        
        protected string n_sUpgrade_sponsorships_amount=global::System.String.Empty;
        #region upgrade_sponsorships_amount
        [System.Data.Linq.Mapping.Column(Name="[upgrade_sponsorships_amount]", Storage="n_sUpgrade_sponsorships_amount")]
        public string upgrade_sponsorships_amount{
            get{
                return this.n_sUpgrade_sponsorships_amount;
            }
            set{
                this.n_sUpgrade_sponsorships_amount=value;
            }
        }
        #endregion upgrade_sponsorships_amount
        
        
        protected global::System.Nullable<bool> n_bBill_medium_waive=null;
        #region bill_medium_waive
        [System.Data.Linq.Mapping.Column(Name="[bill_medium_waive]", Storage="n_bBill_medium_waive")]
        public global::System.Nullable<bool> bill_medium_waive{
            get{
                return this.n_bBill_medium_waive;
            }
            set{
                this.n_bBill_medium_waive=value;
            }
        }
        #endregion bill_medium_waive
        
        
        protected string n_sDelivery_exchange_location=global::System.String.Empty;
        #region delivery_exchange_location
        [System.Data.Linq.Mapping.Column(Name="[delivery_exchange_location]", Storage="n_sDelivery_exchange_location")]
        public string delivery_exchange_location{
            get{
                return this.n_sDelivery_exchange_location;
            }
            set{
                this.n_sDelivery_exchange_location=value;
            }
        }
        #endregion delivery_exchange_location
        
        
        protected global::System.Nullable<int> n_iHs_offer_type_id=null;
        #region hs_offer_type_id
        [System.Data.Linq.Mapping.Column(Name="[hs_offer_type_id]", Storage="n_iHs_offer_type_id")]
        public global::System.Nullable<int> hs_offer_type_id{
            get{
                return this.n_iHs_offer_type_id;
            }
            set{
                this.n_iHs_offer_type_id=value;
            }
        }
        #endregion hs_offer_type_id
        
        
        protected string n_sExtra_rebate_amount=global::System.String.Empty;
        #region extra_rebate_amount
        [System.Data.Linq.Mapping.Column(Name="[extra_rebate_amount]", Storage="n_sExtra_rebate_amount")]
        public string extra_rebate_amount{
            get{
                return this.n_sExtra_rebate_amount;
            }
            set{
                this.n_sExtra_rebate_amount=value;
            }
        }
        #endregion extra_rebate_amount
        
        
        protected string n_sRebate=global::System.String.Empty;
        #region rebate
        [System.Data.Linq.Mapping.Column(Name="[rebate]", Storage="n_sRebate")]
        public string rebate{
            get{
                return this.n_sRebate;
            }
            set{
                this.n_sRebate=value;
            }
        }
        #endregion rebate
        
        
        protected string n_sUpgrade_type=global::System.String.Empty;
        #region upgrade_type
        [System.Data.Linq.Mapping.Column(Name="[upgrade_type]", Storage="n_sUpgrade_type")]
        public string upgrade_type{
            get{
                return this.n_sUpgrade_type;
            }
            set{
                this.n_sUpgrade_type=value;
            }
        }
        #endregion upgrade_type
        
        
        protected string n_sGo_wireless=global::System.String.Empty;
        #region go_wireless
        [System.Data.Linq.Mapping.Column(Name="[go_wireless]", Storage="n_sGo_wireless")]
        public string go_wireless{
            get{
                return this.n_sGo_wireless;
            }
            set{
                this.n_sGo_wireless=value;
            }
        }
        #endregion go_wireless
        
        
        protected string n_sExtra_rebate=global::System.String.Empty;
        #region extra_rebate
        [System.Data.Linq.Mapping.Column(Name="[extra_rebate]", Storage="n_sExtra_rebate")]
        public string extra_rebate{
            get{
                return this.n_sExtra_rebate;
            }
            set{
                this.n_sExtra_rebate=value;
            }
        }
        #endregion extra_rebate
        
        
        protected string n_sPlan_eff=global::System.String.Empty;
        #region plan_eff
        [System.Data.Linq.Mapping.Column(Name="[plan_eff]", Storage="n_sPlan_eff")]
        public string plan_eff{
            get{
                return this.n_sPlan_eff;
            }
            set{
                this.n_sPlan_eff=value;
            }
        }
        #endregion plan_eff
        
        
        protected string n_sCard_exp_year=global::System.String.Empty;
        #region card_exp_year
        [System.Data.Linq.Mapping.Column(Name="[card_exp_year]", Storage="n_sCard_exp_year")]
        public string card_exp_year{
            get{
                return this.n_sCard_exp_year;
            }
            set{
                this.n_sCard_exp_year=value;
            }
        }
        #endregion card_exp_year
        
        
        protected global::System.Nullable<DateTime> n_dUpgrade_existing_contract_sdate=null;
        #region upgrade_existing_contract_sdate
        [System.Data.Linq.Mapping.Column(Name="[upgrade_existing_contract_sdate]", Storage="n_dUpgrade_existing_contract_sdate")]
        public global::System.Nullable<DateTime> upgrade_existing_contract_sdate{
            get{
                return this.n_dUpgrade_existing_contract_sdate;
            }
            set{
                this.n_dUpgrade_existing_contract_sdate=value;
            }
        }
        #endregion upgrade_existing_contract_sdate
        
        
        protected string n_sOrd_place_hkid=global::System.String.Empty;
        #region ord_place_hkid
        [System.Data.Linq.Mapping.Column(Name="[ord_place_hkid]", Storage="n_sOrd_place_hkid")]
        public string ord_place_hkid{
            get{
                return this.n_sOrd_place_hkid;
            }
            set{
                this.n_sOrd_place_hkid=value;
            }
        }
        #endregion ord_place_hkid
        
        
        protected string n_sRegister_address=global::System.String.Empty;
        #region register_address
        [System.Data.Linq.Mapping.Column(Name="[register_address]", Storage="n_sRegister_address")]
        public string register_address{
            get{
                return this.n_sRegister_address;
            }
            set{
                this.n_sRegister_address=value;
            }
        }
        #endregion register_address
        
        
        protected string n_sGender=global::System.String.Empty;
        #region gender
        [System.Data.Linq.Mapping.Column(Name="[gender]", Storage="n_sGender")]
        public string gender{
            get{
                return this.n_sGender;
            }
            set{
                this.n_sGender=value;
            }
        }
        #endregion gender
        
        
        protected string n_sLob_ac=global::System.String.Empty;
        #region lob_ac
        [System.Data.Linq.Mapping.Column(Name="[lob_ac]", Storage="n_sLob_ac")]
        public string lob_ac{
            get{
                return this.n_sLob_ac;
            }
            set{
                this.n_sLob_ac=value;
            }
        }
        #endregion lob_ac
        
        
        protected global::System.Nullable<int> n_iSim_mrt_no=null;
        #region sim_mrt_no
        [System.Data.Linq.Mapping.Column(Name="[sim_mrt_no]", Storage="n_iSim_mrt_no")]
        public global::System.Nullable<int> sim_mrt_no{
            get{
                return this.n_iSim_mrt_no;
            }
            set{
                this.n_iSim_mrt_no=value;
            }
        }
        #endregion sim_mrt_no
        
        
        protected string n_sRedemption_notice_option=global::System.String.Empty;
        #region redemption_notice_option
        [System.Data.Linq.Mapping.Column(Name="[redemption_notice_option]", Storage="n_sRedemption_notice_option")]
        public string redemption_notice_option{
            get{
                return this.n_sRedemption_notice_option;
            }
            set{
                this.n_sRedemption_notice_option=value;
            }
        }
        #endregion redemption_notice_option
        
        
        protected string n_sDelivery_collection_type=global::System.String.Empty;
        #region delivery_collection_type
        [System.Data.Linq.Mapping.Column(Name="[delivery_collection_type]", Storage="n_sDelivery_collection_type")]
        public string delivery_collection_type{
            get{
                return this.n_sDelivery_collection_type;
            }
            set{
                this.n_sDelivery_collection_type=value;
            }
        }
        #endregion delivery_collection_type
        
        
        protected global::System.Nullable<DateTime> n_dAction_date=null;
        #region action_date
        [System.Data.Linq.Mapping.Column(Name="[action_date]", Storage="n_dAction_date")]
        public global::System.Nullable<DateTime> action_date{
            get{
                return this.n_dAction_date;
            }
            set{
                this.n_dAction_date=value;
            }
        }
        #endregion action_date
        
        
        protected string n_sThird_party_id_type=global::System.String.Empty;
        #region third_party_id_type
        [System.Data.Linq.Mapping.Column(Name="[third_party_id_type]", Storage="n_sThird_party_id_type")]
        public string third_party_id_type{
            get{
                return this.n_sThird_party_id_type;
            }
            set{
                this.n_sThird_party_id_type=value;
            }
        }
        #endregion third_party_id_type
        
        
        protected string n_sOrg_ftg=global::System.String.Empty;
        #region org_ftg
        [System.Data.Linq.Mapping.Column(Name="[org_ftg]", Storage="n_sOrg_ftg")]
        public string org_ftg{
            get{
                return this.n_sOrg_ftg;
            }
            set{
                this.n_sOrg_ftg=value;
            }
        }
        #endregion org_ftg
        
        
        protected string n_sUpgrade_service_tenure=global::System.String.Empty;
        #region upgrade_service_tenure
        [System.Data.Linq.Mapping.Column(Name="[upgrade_service_tenure]", Storage="n_sUpgrade_service_tenure")]
        public string upgrade_service_tenure{
            get{
                return this.n_sUpgrade_service_tenure;
            }
            set{
                this.n_sUpgrade_service_tenure=value;
            }
        }
        #endregion upgrade_service_tenure
        
        
        protected string n_sMonthly_payment_type=global::System.String.Empty;
        #region monthly_payment_type
        [System.Data.Linq.Mapping.Column(Name="[monthly_payment_type]", Storage="n_sMonthly_payment_type")]
        public string monthly_payment_type{
            get{
                return this.n_sMonthly_payment_type;
            }
            set{
                this.n_sMonthly_payment_type=value;
            }
        }
        #endregion monthly_payment_type
        
        
        protected string n_sContact_no=global::System.String.Empty;
        #region contact_no
        [System.Data.Linq.Mapping.Column(Name="[contact_no]", Storage="n_sContact_no")]
        public string contact_no{
            get{
                return this.n_sContact_no;
            }
            set{
                this.n_sContact_no=value;
            }
        }
        #endregion contact_no
        
        
        protected global::System.Nullable<int> n_iOrg_mrt=null;
        #region org_mrt
        [System.Data.Linq.Mapping.Column(Name="[org_mrt]", Storage="n_iOrg_mrt")]
        public global::System.Nullable<int> org_mrt{
            get{
                return this.n_iOrg_mrt;
            }
            set{
                this.n_iOrg_mrt=value;
            }
        }
        #endregion org_mrt
        
        
        protected string n_sSim_item_name=global::System.String.Empty;
        #region sim_item_name
        [System.Data.Linq.Mapping.Column(Name="[sim_item_name]", Storage="n_sSim_item_name")]
        public string sim_item_name{
            get{
                return this.n_sSim_item_name;
            }
            set{
                this.n_sSim_item_name=value;
            }
        }
        #endregion sim_item_name
        
        
        protected string n_sPay_method=global::System.String.Empty;
        #region pay_method
        [System.Data.Linq.Mapping.Column(Name="[pay_method]", Storage="n_sPay_method")]
        public string pay_method{
            get{
                return this.n_sPay_method;
            }
            set{
                this.n_sPay_method=value;
            }
        }
        #endregion pay_method
        
        
        protected string n_sHs_model=global::System.String.Empty;
        #region hs_model
        [System.Data.Linq.Mapping.Column(Name="[hs_model]", Storage="n_sHs_model")]
        public string hs_model{
            get{
                return this.n_sHs_model;
            }
            set{
                this.n_sHs_model=value;
            }
        }
        #endregion hs_model
        
        
        protected string n_sGift_code=global::System.String.Empty;
        #region gift_code
        [System.Data.Linq.Mapping.Column(Name="[gift_code]", Storage="n_sGift_code")]
        public string gift_code{
            get{
                return this.n_sGift_code;
            }
            set{
                this.n_sGift_code=value;
            }
        }
        #endregion gift_code
        
        
        protected string n_sMonthly_bank_account_hkid=global::System.String.Empty;
        #region monthly_bank_account_hkid
        [System.Data.Linq.Mapping.Column(Name="[monthly_bank_account_hkid]", Storage="n_sMonthly_bank_account_hkid")]
        public string monthly_bank_account_hkid{
            get{
                return this.n_sMonthly_bank_account_hkid;
            }
            set{
                this.n_sMonthly_bank_account_hkid=value;
            }
        }
        #endregion monthly_bank_account_hkid
        
        
        protected string n_sExtra_offer=global::System.String.Empty;
        #region extra_offer
        [System.Data.Linq.Mapping.Column(Name="[extra_offer]", Storage="n_sExtra_offer")]
        public string extra_offer{
            get{
                return this.n_sExtra_offer;
            }
            set{
                this.n_sExtra_offer=value;
            }
        }
        #endregion extra_offer
        
        
        protected string n_sMonthly_bank_account_no=global::System.String.Empty;
        #region monthly_bank_account_no
        [System.Data.Linq.Mapping.Column(Name="[monthly_bank_account_no]", Storage="n_sMonthly_bank_account_no")]
        public string monthly_bank_account_no{
            get{
                return this.n_sMonthly_bank_account_no;
            }
            set{
                this.n_sMonthly_bank_account_no=value;
            }
        }
        #endregion monthly_bank_account_no
        
        
        protected string n_sFirst_month_license_fee=global::System.String.Empty;
        #region first_month_license_fee
        [System.Data.Linq.Mapping.Column(Name="[first_month_license_fee]", Storage="n_sFirst_month_license_fee")]
        public string first_month_license_fee{
            get{
                return this.n_sFirst_month_license_fee;
            }
            set{
                this.n_sFirst_month_license_fee=value;
            }
        }
        #endregion first_month_license_fee
        
        
        protected global::System.Nullable<int> n_iRetrieve_cnt=null;
        #region retrieve_cnt
        [System.Data.Linq.Mapping.Column(Name="[retrieve_cnt]", Storage="n_iRetrieve_cnt")]
        public global::System.Nullable<int> retrieve_cnt{
            get{
                return this.n_iRetrieve_cnt;
            }
            set{
                this.n_iRetrieve_cnt=value;
            }
        }
        #endregion retrieve_cnt
        
        
        protected global::System.Nullable<DateTime> n_dDdate=null;
        #region ddate
        [System.Data.Linq.Mapping.Column(Name="[ddate]", Storage="n_dDdate")]
        public global::System.Nullable<DateTime> ddate{
            get{
                return this.n_dDdate;
            }
            set{
                this.n_dDdate=value;
            }
        }
        #endregion ddate
        
        
        protected string n_sS_premium2=global::System.String.Empty;
        #region s_premium2
        [System.Data.Linq.Mapping.Column(Name="[s_premium2]", Storage="n_sS_premium2")]
        public string s_premium2{
            get{
                return this.n_sS_premium2;
            }
            set{
                this.n_sS_premium2=value;
            }
        }
        #endregion s_premium2
        
        
        protected string n_sMonthly_bank_account_id_type=global::System.String.Empty;
        #region monthly_bank_account_id_type
        [System.Data.Linq.Mapping.Column(Name="[monthly_bank_account_id_type]", Storage="n_sMonthly_bank_account_id_type")]
        public string monthly_bank_account_id_type{
            get{
                return this.n_sMonthly_bank_account_id_type;
            }
            set{
                this.n_sMonthly_bank_account_id_type=value;
            }
        }
        #endregion monthly_bank_account_id_type
        
        
        protected string n_sCard_type=global::System.String.Empty;
        #region card_type
        [System.Data.Linq.Mapping.Column(Name="[card_type]", Storage="n_sCard_type")]
        public string card_type{
            get{
                return this.n_sCard_type;
            }
            set{
                this.n_sCard_type=value;
            }
        }
        #endregion card_type
        
        
        protected global::System.Nullable<bool> n_bNext_bill=null;
        #region next_bill
        [System.Data.Linq.Mapping.Column(Name="[next_bill]", Storage="n_bNext_bill")]
        public global::System.Nullable<bool> next_bill{
            get{
                return this.n_bNext_bill;
            }
            set{
                this.n_bNext_bill=value;
            }
        }
        #endregion next_bill
        
        
        protected global::System.Nullable<bool> n_bPcd_paid_go_wireless=null;
        #region pcd_paid_go_wireless
        [System.Data.Linq.Mapping.Column(Name="[pcd_paid_go_wireless]", Storage="n_bPcd_paid_go_wireless")]
        public global::System.Nullable<bool> pcd_paid_go_wireless{
            get{
                return this.n_bPcd_paid_go_wireless;
            }
            set{
                this.n_bPcd_paid_go_wireless=value;
            }
        }
        #endregion pcd_paid_go_wireless
        
        
        protected string n_sUpgrade_rebate_calculation=global::System.String.Empty;
        #region upgrade_rebate_calculation
        [System.Data.Linq.Mapping.Column(Name="[upgrade_rebate_calculation]", Storage="n_sUpgrade_rebate_calculation")]
        public string upgrade_rebate_calculation{
            get{
                return this.n_sUpgrade_rebate_calculation;
            }
            set{
                this.n_sUpgrade_rebate_calculation=value;
            }
        }
        #endregion upgrade_rebate_calculation
        
        
        protected string n_sExt_place_tel=global::System.String.Empty;
        #region ext_place_tel
        [System.Data.Linq.Mapping.Column(Name="[ext_place_tel]", Storage="n_sExt_place_tel")]
        public string ext_place_tel{
            get{
                return this.n_sExt_place_tel;
            }
            set{
                this.n_sExt_place_tel=value;
            }
        }
        #endregion ext_place_tel
        
        
        protected string n_sM_3rd_hkid=global::System.String.Empty;
        #region m_3rd_hkid
        [System.Data.Linq.Mapping.Column(Name="[m_3rd_hkid]", Storage="n_sM_3rd_hkid")]
        public string m_3rd_hkid{
            get{
                return this.n_sM_3rd_hkid;
            }
            set{
                this.n_sM_3rd_hkid=value;
            }
        }
        #endregion m_3rd_hkid
        
        
        protected string n_sRetention_type=global::System.String.Empty;
        #region retention_type
        [System.Data.Linq.Mapping.Column(Name="[retention_type]", Storage="n_sRetention_type")]
        public string retention_type{
            get{
                return this.n_sRetention_type;
            }
            set{
                this.n_sRetention_type=value;
            }
        }
        #endregion retention_type
        
        
        protected global::System.Nullable<DateTime> n_dCooling_date=null;
        #region cooling_date
        [System.Data.Linq.Mapping.Column(Name="[cooling_date]", Storage="n_dCooling_date")]
        public global::System.Nullable<DateTime> cooling_date{
            get{
                return this.n_dCooling_date;
            }
            set{
                this.n_dCooling_date=value;
            }
        }
        #endregion cooling_date
        
        
        protected string n_sAig_gift=global::System.String.Empty;
        #region aig_gift
        [System.Data.Linq.Mapping.Column(Name="[aig_gift]", Storage="n_sAig_gift")]
        public string aig_gift{
            get{
                return this.n_sAig_gift;
            }
            set{
                this.n_sAig_gift=value;
            }
        }
        #endregion aig_gift
        
        
        protected string n_sCust_staff_no=global::System.String.Empty;
        #region cust_staff_no
        [System.Data.Linq.Mapping.Column(Name="[cust_staff_no]", Storage="n_sCust_staff_no")]
        public string cust_staff_no{
            get{
                return this.n_sCust_staff_no;
            }
            set{
                this.n_sCust_staff_no=value;
            }
        }
        #endregion cust_staff_no
        
        
        protected global::System.Nullable<int> n_iOrder_id=null;
        #region order_id
        [System.Data.Linq.Mapping.Column(Name="[order_id]", Storage="n_iOrder_id")]
        public global::System.Nullable<int> order_id{
            get{
                return this.n_iOrder_id;
            }
            set{
                this.n_iOrder_id=value;
            }
        }
        #endregion order_id
        
        
        private MobileOrderVas[] n_oMobileOrderVasMobileRetentionOrder=null;
        #region MobileOrderVasMobileRetentionOrder    Foreign Key Table
        public MobileOrderVas[] MobileOrderVasMobileRetentionOrder{
            get{
                if(n_oMobileOrderVasMobileRetentionOrder==null){
                    if (n_iOrder_id == null) { 
                        n_oMobileOrderVasMobileRetentionOrder=new MobileOrderVas[0];
                        return n_oMobileOrderVasMobileRetentionOrder;
                    }
                    List<string> x_oArrayItemId=new List<string>();
                    x_oArrayItemId.Add(((int)this.n_iOrder_id).ToString());
                    n_oMobileOrderVasMobileRetentionOrder=(MobileOrderVas[])MobileOrderVasRepository.GetArrayObj(this.n_oDB,"order_id",x_oArrayItemId);
                    if(n_oMobileOrderVasMobileRetentionOrder==null){
                        n_oMobileOrderVasMobileRetentionOrder = new MobileOrderVas[0];
                    }
                }
                return n_oMobileOrderVasMobileRetentionOrder;
            }
            set{
                if(value==null){
                    n_oMobileOrderVasMobileRetentionOrder=new MobileOrderVas[0];
                    }else{
                    this.n_oMobileOrderVasMobileRetentionOrder=value;
                }
                for(int i=0; i<n_oMobileOrderVasMobileRetentionOrder.Length; i++) {
                    n_oMobileOrderVasMobileRetentionOrder[i].SetOrder_id(this.n_iOrder_id);
                }
            }
        }
        
        private global::System.Data.DataSet n_oMobileOrderVasMobileRetentionOrderDataSet = null;
        #region MobileOrderVasMobileRetentionOrderDataSet    Foreign Table DataSet
        public global::System.Data.DataSet MobileOrderVasMobileRetentionOrderDataSet
        {
            get
            {
                bool _bGetDataSet = false;
                MobileOrderVasBal _oMobileOrderVasBal = new MobileOrderVasBal();
                if (n_oMobileOrderVasMobileRetentionOrderDataSet == null)
                {
                    if (n_iOrder_id == null) { 
                        n_oMobileOrderVasMobileRetentionOrderDataSet = MobileOrderVasBal.ToEmptyDataSet();
                        return n_oMobileOrderVasMobileRetentionOrderDataSet;
                    }
                    _bGetDataSet = true;
                }
                if(n_oMobileOrderVasMobileRetentionOrderDataSet!=null){
                    if (n_oMobileOrderVasMobileRetentionOrderDataSet.Tables.Contains(MobileOrderVas.Para.TableName())){
                        if (n_oMobileOrderVasMobileRetentionOrderDataSet.Tables[MobileOrderVas.Para.TableName()].Rows.Count == 0){ _bGetDataSet = true; }
                    }
                }
                if (_bGetDataSet){
                    n_oMobileOrderVasMobileRetentionOrderDataSet = MobileOrderVasRepository.GetDataSet(n_oDB, "[order_id]="+n_iOrder_id);
                    if (n_oMobileOrderVasMobileRetentionOrderDataSet == null)
                    {
                        n_oMobileOrderVasMobileRetentionOrderDataSet =  MobileOrderVasBal.ToEmptyDataSet();
                    }
                }
                return n_oMobileOrderVasMobileRetentionOrderDataSet;
            }
            set
            {
                n_oMobileOrderVasMobileRetentionOrderDataSet = value;
            }
        }
        
        #endregion MobileOrderVasMobileRetentionOrderDataSet
        #endregion MobileOrderVasMobileRetentionOrder
        
        
        private MobileOrderAddress[] n_oMobileOrderAddressMobileRetentionOrder=null;
        #region MobileOrderAddressMobileRetentionOrder    Foreign Key Table
        public MobileOrderAddress[] MobileOrderAddressMobileRetentionOrder{
            get{
                if(n_oMobileOrderAddressMobileRetentionOrder==null){
                    if (n_iOrder_id == null) { 
                        n_oMobileOrderAddressMobileRetentionOrder=new MobileOrderAddress[0];
                        return n_oMobileOrderAddressMobileRetentionOrder;
                    }
                    List<string> x_oArrayItemId=new List<string>();
                    x_oArrayItemId.Add(((int)this.n_iOrder_id).ToString());
                    n_oMobileOrderAddressMobileRetentionOrder=(MobileOrderAddress[])MobileOrderAddressRepository.GetArrayObj(this.n_oDB,"order_id",x_oArrayItemId);
                    if(n_oMobileOrderAddressMobileRetentionOrder==null){
                        n_oMobileOrderAddressMobileRetentionOrder = new MobileOrderAddress[0];
                    }
                }
                return n_oMobileOrderAddressMobileRetentionOrder;
            }
            set{
                if(value==null){
                    n_oMobileOrderAddressMobileRetentionOrder=new MobileOrderAddress[0];
                    }else{
                    this.n_oMobileOrderAddressMobileRetentionOrder=value;
                }
                for(int i=0; i<n_oMobileOrderAddressMobileRetentionOrder.Length; i++) {
                    n_oMobileOrderAddressMobileRetentionOrder[i].SetOrder_id(this.n_iOrder_id);
                }
            }
        }
        
        private global::System.Data.DataSet n_oMobileOrderAddressMobileRetentionOrderDataSet = null;
        #region MobileOrderAddressMobileRetentionOrderDataSet    Foreign Table DataSet
        public global::System.Data.DataSet MobileOrderAddressMobileRetentionOrderDataSet
        {
            get
            {
                bool _bGetDataSet = false;
                MobileOrderAddressBal _oMobileOrderAddressBal = new MobileOrderAddressBal();
                if (n_oMobileOrderAddressMobileRetentionOrderDataSet == null)
                {
                    if (n_iOrder_id == null) { 
                        n_oMobileOrderAddressMobileRetentionOrderDataSet = MobileOrderAddressBal.ToEmptyDataSet();
                        return n_oMobileOrderAddressMobileRetentionOrderDataSet;
                    }
                    _bGetDataSet = true;
                }
                if(n_oMobileOrderAddressMobileRetentionOrderDataSet!=null){
                    if (n_oMobileOrderAddressMobileRetentionOrderDataSet.Tables.Contains(MobileOrderAddress.Para.TableName())){
                        if (n_oMobileOrderAddressMobileRetentionOrderDataSet.Tables[MobileOrderAddress.Para.TableName()].Rows.Count == 0){ _bGetDataSet = true; }
                    }
                }
                if (_bGetDataSet){
                    n_oMobileOrderAddressMobileRetentionOrderDataSet = MobileOrderAddressRepository.GetDataSet(n_oDB, "[order_id]="+n_iOrder_id);
                    if (n_oMobileOrderAddressMobileRetentionOrderDataSet == null)
                    {
                        n_oMobileOrderAddressMobileRetentionOrderDataSet =  MobileOrderAddressBal.ToEmptyDataSet();
                    }
                }
                return n_oMobileOrderAddressMobileRetentionOrderDataSet;
            }
            set
            {
                n_oMobileOrderAddressMobileRetentionOrderDataSet = value;
            }
        }
        
        #endregion MobileOrderAddressMobileRetentionOrderDataSet
        #endregion MobileOrderAddressMobileRetentionOrder
        
        
        private MobileOrderMNPDetail[] n_oMobileOrderMNPDetailMobileRetentionOrder=null;
        #region MobileOrderMNPDetailMobileRetentionOrder    Foreign Key Table
        public MobileOrderMNPDetail[] MobileOrderMNPDetailMobileRetentionOrder{
            get{
                if(n_oMobileOrderMNPDetailMobileRetentionOrder==null){
                    if (n_iOrder_id == null) { 
                        n_oMobileOrderMNPDetailMobileRetentionOrder=new MobileOrderMNPDetail[0];
                        return n_oMobileOrderMNPDetailMobileRetentionOrder;
                    }
                    List<string> x_oArrayItemId=new List<string>();
                    x_oArrayItemId.Add(((int)this.n_iOrder_id).ToString());
                    n_oMobileOrderMNPDetailMobileRetentionOrder=(MobileOrderMNPDetail[])MobileOrderMNPDetailRepository.GetArrayObj(this.n_oDB,"order_id",x_oArrayItemId);
                    if(n_oMobileOrderMNPDetailMobileRetentionOrder==null){
                        n_oMobileOrderMNPDetailMobileRetentionOrder = new MobileOrderMNPDetail[0];
                    }
                }
                return n_oMobileOrderMNPDetailMobileRetentionOrder;
            }
            set{
                if(value==null){
                    n_oMobileOrderMNPDetailMobileRetentionOrder=new MobileOrderMNPDetail[0];
                    }else{
                    this.n_oMobileOrderMNPDetailMobileRetentionOrder=value;
                }
                for(int i=0; i<n_oMobileOrderMNPDetailMobileRetentionOrder.Length; i++) {
                    n_oMobileOrderMNPDetailMobileRetentionOrder[i].SetOrder_id(this.n_iOrder_id);
                }
            }
        }
        
        private global::System.Data.DataSet n_oMobileOrderMNPDetailMobileRetentionOrderDataSet = null;
        #region MobileOrderMNPDetailMobileRetentionOrderDataSet    Foreign Table DataSet
        public global::System.Data.DataSet MobileOrderMNPDetailMobileRetentionOrderDataSet
        {
            get
            {
                bool _bGetDataSet = false;
                MobileOrderMNPDetailBal _oMobileOrderMNPDetailBal = new MobileOrderMNPDetailBal();
                if (n_oMobileOrderMNPDetailMobileRetentionOrderDataSet == null)
                {
                    if (n_iOrder_id == null) { 
                        n_oMobileOrderMNPDetailMobileRetentionOrderDataSet = MobileOrderMNPDetailBal.ToEmptyDataSet();
                        return n_oMobileOrderMNPDetailMobileRetentionOrderDataSet;
                    }
                    _bGetDataSet = true;
                }
                if(n_oMobileOrderMNPDetailMobileRetentionOrderDataSet!=null){
                    if (n_oMobileOrderMNPDetailMobileRetentionOrderDataSet.Tables.Contains(MobileOrderMNPDetail.Para.TableName())){
                        if (n_oMobileOrderMNPDetailMobileRetentionOrderDataSet.Tables[MobileOrderMNPDetail.Para.TableName()].Rows.Count == 0){ _bGetDataSet = true; }
                    }
                }
                if (_bGetDataSet){
                    n_oMobileOrderMNPDetailMobileRetentionOrderDataSet = MobileOrderMNPDetailRepository.GetDataSet(n_oDB, "[order_id]="+n_iOrder_id);
                    if (n_oMobileOrderMNPDetailMobileRetentionOrderDataSet == null)
                    {
                        n_oMobileOrderMNPDetailMobileRetentionOrderDataSet =  MobileOrderMNPDetailBal.ToEmptyDataSet();
                    }
                }
                return n_oMobileOrderMNPDetailMobileRetentionOrderDataSet;
            }
            set
            {
                n_oMobileOrderMNPDetailMobileRetentionOrderDataSet = value;
            }
        }
        
        #endregion MobileOrderMNPDetailMobileRetentionOrderDataSet
        #endregion MobileOrderMNPDetailMobileRetentionOrder
        
        
        private MobileOrderThreeParty[] n_oMobileOrderThreePartyMobileRetentionOrder=null;
        #region MobileOrderThreePartyMobileRetentionOrder    Foreign Key Table
        public MobileOrderThreeParty[] MobileOrderThreePartyMobileRetentionOrder{
            get{
                if(n_oMobileOrderThreePartyMobileRetentionOrder==null){
                    if (n_iOrder_id == null) { 
                        n_oMobileOrderThreePartyMobileRetentionOrder=new MobileOrderThreeParty[0];
                        return n_oMobileOrderThreePartyMobileRetentionOrder;
                    }
                    List<string> x_oArrayItemId=new List<string>();
                    x_oArrayItemId.Add(((int)this.n_iOrder_id).ToString());
                    n_oMobileOrderThreePartyMobileRetentionOrder=(MobileOrderThreeParty[])MobileOrderThreePartyRepository.GetArrayObj(this.n_oDB,"order_id",x_oArrayItemId);
                    if(n_oMobileOrderThreePartyMobileRetentionOrder==null){
                        n_oMobileOrderThreePartyMobileRetentionOrder = new MobileOrderThreeParty[0];
                    }
                }
                return n_oMobileOrderThreePartyMobileRetentionOrder;
            }
            set{
                if(value==null){
                    n_oMobileOrderThreePartyMobileRetentionOrder=new MobileOrderThreeParty[0];
                    }else{
                    this.n_oMobileOrderThreePartyMobileRetentionOrder=value;
                }
                for(int i=0; i<n_oMobileOrderThreePartyMobileRetentionOrder.Length; i++) {
                    n_oMobileOrderThreePartyMobileRetentionOrder[i].SetOrder_id(this.n_iOrder_id);
                }
            }
        }
        
        private global::System.Data.DataSet n_oMobileOrderThreePartyMobileRetentionOrderDataSet = null;
        #region MobileOrderThreePartyMobileRetentionOrderDataSet    Foreign Table DataSet
        public global::System.Data.DataSet MobileOrderThreePartyMobileRetentionOrderDataSet
        {
            get
            {
                bool _bGetDataSet = false;
                MobileOrderThreePartyBal _oMobileOrderThreePartyBal = new MobileOrderThreePartyBal();
                if (n_oMobileOrderThreePartyMobileRetentionOrderDataSet == null)
                {
                    if (n_iOrder_id == null) { 
                        n_oMobileOrderThreePartyMobileRetentionOrderDataSet = MobileOrderThreePartyBal.ToEmptyDataSet();
                        return n_oMobileOrderThreePartyMobileRetentionOrderDataSet;
                    }
                    _bGetDataSet = true;
                }
                if(n_oMobileOrderThreePartyMobileRetentionOrderDataSet!=null){
                    if (n_oMobileOrderThreePartyMobileRetentionOrderDataSet.Tables.Contains(MobileOrderThreeParty.Para.TableName())){
                        if (n_oMobileOrderThreePartyMobileRetentionOrderDataSet.Tables[MobileOrderThreeParty.Para.TableName()].Rows.Count == 0){ _bGetDataSet = true; }
                    }
                }
                if (_bGetDataSet){
                    n_oMobileOrderThreePartyMobileRetentionOrderDataSet = MobileOrderThreePartyRepository.GetDataSet(n_oDB, "[order_id]="+n_iOrder_id);
                    if (n_oMobileOrderThreePartyMobileRetentionOrderDataSet == null)
                    {
                        n_oMobileOrderThreePartyMobileRetentionOrderDataSet =  MobileOrderThreePartyBal.ToEmptyDataSet();
                    }
                }
                return n_oMobileOrderThreePartyMobileRetentionOrderDataSet;
            }
            set
            {
                n_oMobileOrderThreePartyMobileRetentionOrderDataSet = value;
            }
        }
        
        #endregion MobileOrderThreePartyMobileRetentionOrderDataSet
        #endregion MobileOrderThreePartyMobileRetentionOrder
        
        
        protected string n_sFamily_name=global::System.String.Empty;
        #region family_name
        [System.Data.Linq.Mapping.Column(Name="[family_name]", Storage="n_sFamily_name")]
        public string family_name{
            get{
                return this.n_sFamily_name;
            }
            set{
                this.n_sFamily_name=value;
            }
        }
        #endregion family_name
        
        
        protected global::System.Nullable<DateTime> n_dCdate=null;
        #region cdate
        [System.Data.Linq.Mapping.Column(Name="[cdate]", Storage="n_dCdate")]
        public global::System.Nullable<DateTime> cdate{
            get{
                return this.n_dCdate;
            }
            set{
                this.n_dCdate=value;
            }
        }
        #endregion cdate
        
        
        protected string n_sStatus_by_cs_admin=global::System.String.Empty;
        #region status_by_cs_admin
        [System.Data.Linq.Mapping.Column(Name="[status_by_cs_admin]", Storage="n_sStatus_by_cs_admin")]
        public string status_by_cs_admin{
            get{
                return this.n_sStatus_by_cs_admin;
            }
            set{
                this.n_sStatus_by_cs_admin=value;
            }
        }
        #endregion status_by_cs_admin
        
        
        protected string n_sGiven_name=global::System.String.Empty;
        #region given_name
        [System.Data.Linq.Mapping.Column(Name="[given_name]", Storage="n_sGiven_name")]
        public string given_name{
            get{
                return this.n_sGiven_name;
            }
            set{
                this.n_sGiven_name=value;
            }
        }
        #endregion given_name
        
        
        protected string n_sVip_case=global::System.String.Empty;
        #region vip_case
        [System.Data.Linq.Mapping.Column(Name="[vip_case]", Storage="n_sVip_case")]
        public string vip_case{
            get{
                return this.n_sVip_case;
            }
            set{
                this.n_sVip_case=value;
            }
        }
        #endregion vip_case
        
        
        protected string n_sOrg_fee=global::System.String.Empty;
        #region org_fee
        [System.Data.Linq.Mapping.Column(Name="[org_fee]", Storage="n_sOrg_fee")]
        public string org_fee{
            get{
                return this.n_sOrg_fee;
            }
            set{
                this.n_sOrg_fee=value;
            }
        }
        #endregion org_fee
        
        
        protected string n_sS_premium3=global::System.String.Empty;
        #region s_premium3
        [System.Data.Linq.Mapping.Column(Name="[s_premium3]", Storage="n_sS_premium3")]
        public string s_premium3{
            get{
                return this.n_sS_premium3;
            }
            set{
                this.n_sS_premium3=value;
            }
        }
        #endregion s_premium3
        
        
        protected global::System.Nullable<DateTime> n_dLog_date=null;
        #region log_date
        [System.Data.Linq.Mapping.Column(Name="[log_date]", Storage="n_dLog_date")]
        public global::System.Nullable<DateTime> log_date{
            get{
                return this.n_dLog_date;
            }
            set{
                this.n_dLog_date=value;
            }
        }
        #endregion log_date
        
        
        protected string n_sExtn=global::System.String.Empty;
        #region extn
        [System.Data.Linq.Mapping.Column(Name="[extn]", Storage="n_sExtn")]
        public string extn{
            get{
                return this.n_sExtn;
            }
            set{
                this.n_sExtn=value;
            }
        }
        #endregion extn
        
        
        protected string n_sD_time=global::System.String.Empty;
        #region d_time
        [System.Data.Linq.Mapping.Column(Name="[d_time]", Storage="n_sD_time")]
        public string d_time{
            get{
                return this.n_sD_time;
            }
            set{
                this.n_sD_time=value;
            }
        }
        #endregion d_time
        
        
        protected string n_sBank_name=global::System.String.Empty;
        #region bank_name
        [System.Data.Linq.Mapping.Column(Name="[bank_name]", Storage="n_sBank_name")]
        public string bank_name{
            get{
                return this.n_sBank_name;
            }
            set{
                this.n_sBank_name=value;
            }
        }
        #endregion bank_name
        
        
        protected string n_sDelivery_exchange_option=global::System.String.Empty;
        #region delivery_exchange_option
        [System.Data.Linq.Mapping.Column(Name="[delivery_exchange_option]", Storage="n_sDelivery_exchange_option")]
        public string delivery_exchange_option{
            get{
                return this.n_sDelivery_exchange_option;
            }
            set{
                this.n_sDelivery_exchange_option=value;
            }
        }
        #endregion delivery_exchange_option
        
        
        protected string n_sUpgrade_service_account_no=global::System.String.Empty;
        #region upgrade_service_account_no
        [System.Data.Linq.Mapping.Column(Name="[upgrade_service_account_no]", Storage="n_sUpgrade_service_account_no")]
        public string upgrade_service_account_no{
            get{
                return this.n_sUpgrade_service_account_no;
            }
            set{
                this.n_sUpgrade_service_account_no=value;
            }
        }
        #endregion upgrade_service_account_no
        
        
        protected global::System.Nullable<int> n_iOld_ord_id=null;
        #region old_ord_id
        [System.Data.Linq.Mapping.Column(Name="[old_ord_id]", Storage="n_iOld_ord_id")]
        public global::System.Nullable<int> old_ord_id{
            get{
                return this.n_iOld_ord_id;
            }
            set{
                this.n_iOld_ord_id=value;
            }
        }
        #endregion old_ord_id
        
        
        protected string n_sM_card_no=global::System.String.Empty;
        #region m_card_no
        [System.Data.Linq.Mapping.Column(Name="[m_card_no]", Storage="n_sM_card_no")]
        public string m_card_no{
            get{
                return this.n_sM_card_no;
            }
            set{
                this.n_sM_card_no=value;
            }
        }
        #endregion m_card_no
        
        
        protected string n_sExisting_contract_end_date=global::System.String.Empty;
        #region existing_contract_end_date
        [System.Data.Linq.Mapping.Column(Name="[existing_contract_end_date]", Storage="n_sExisting_contract_end_date")]
        public string existing_contract_end_date{
            get{
                return this.n_sExisting_contract_end_date;
            }
            set{
                this.n_sExisting_contract_end_date=value;
            }
        }
        #endregion existing_contract_end_date
        
        
        protected global::System.Nullable<DateTime> n_dCon_eff_date=null;
        #region con_eff_date
        [System.Data.Linq.Mapping.Column(Name="[con_eff_date]", Storage="n_dCon_eff_date")]
        public global::System.Nullable<DateTime> con_eff_date{
            get{
                return this.n_dCon_eff_date;
            }
            set{
                this.n_dCon_eff_date=value;
            }
        }
        #endregion con_eff_date
        
        
        protected string n_sM_3rd_hkid2=global::System.String.Empty;
        #region m_3rd_hkid2
        [System.Data.Linq.Mapping.Column(Name="[m_3rd_hkid2]", Storage="n_sM_3rd_hkid2")]
        public string m_3rd_hkid2{
            get{
                return this.n_sM_3rd_hkid2;
            }
            set{
                this.n_sM_3rd_hkid2=value;
            }
        }
        #endregion m_3rd_hkid2
        
        
        protected string n_sAmount=global::System.String.Empty;
        #region amount
        [System.Data.Linq.Mapping.Column(Name="[amount]", Storage="n_sAmount")]
        public string amount{
            get{
                return this.n_sAmount;
            }
            set{
                this.n_sAmount=value;
            }
        }
        #endregion amount
        
        
        protected string n_sM_3rd_id_type=global::System.String.Empty;
        #region m_3rd_id_type
        [System.Data.Linq.Mapping.Column(Name="[m_3rd_id_type]", Storage="n_sM_3rd_id_type")]
        public string m_3rd_id_type{
            get{
                return this.n_sM_3rd_id_type;
            }
            set{
                this.n_sM_3rd_id_type=value;
            }
        }
        #endregion m_3rd_id_type
        
        
        protected string n_sId_type=global::System.String.Empty;
        #region id_type
        [System.Data.Linq.Mapping.Column(Name="[id_type]", Storage="n_sId_type")]
        public string id_type{
            get{
                return this.n_sId_type;
            }
            set{
                this.n_sId_type=value;
            }
        }
        #endregion id_type
        
        
        protected string n_sRate_plan=global::System.String.Empty;
        #region rate_plan
        [System.Data.Linq.Mapping.Column(Name="[rate_plan]", Storage="n_sRate_plan")]
        public string rate_plan{
            get{
                return this.n_sRate_plan;
            }
            set{
                this.n_sRate_plan=value;
            }
        }
        #endregion rate_plan
        
        
        protected string n_sChannel=global::System.String.Empty;
        #region channel
        [System.Data.Linq.Mapping.Column(Name="[channel]", Storage="n_sChannel")]
        public string channel{
            get{
                return this.n_sChannel;
            }
            set{
                this.n_sChannel=value;
            }
        }
        #endregion channel
        
        
        protected global::System.Nullable<DateTime> n_dAction_eff_date=null;
        #region action_eff_date
        [System.Data.Linq.Mapping.Column(Name="[action_eff_date]", Storage="n_dAction_eff_date")]
        public global::System.Nullable<DateTime> action_eff_date{
            get{
                return this.n_dAction_eff_date;
            }
            set{
                this.n_dAction_eff_date=value;
            }
        }
        #endregion action_eff_date
        
        
        protected string n_sIssue_type=global::System.String.Empty;
        #region issue_type
        [System.Data.Linq.Mapping.Column(Name="[issue_type]", Storage="n_sIssue_type")]
        public string issue_type{
            get{
                return this.n_sIssue_type;
            }
            set{
                this.n_sIssue_type=value;
            }
        }
        #endregion issue_type
        
        
        protected string n_sFree_mon=global::System.String.Empty;
        #region free_mon
        [System.Data.Linq.Mapping.Column(Name="[free_mon]", Storage="n_sFree_mon")]
        public string free_mon{
            get{
                return this.n_sFree_mon;
            }
            set{
                this.n_sFree_mon=value;
            }
        }
        #endregion free_mon
        
        
        protected global::System.Nullable<DateTime> n_dPlan_eff_date=null;
        #region plan_eff_date
        [System.Data.Linq.Mapping.Column(Name="[plan_eff_date]", Storage="n_dPlan_eff_date")]
        public global::System.Nullable<DateTime> plan_eff_date{
            get{
                return this.n_dPlan_eff_date;
            }
            set{
                this.n_dPlan_eff_date=value;
            }
        }
        #endregion plan_eff_date
        
        
        protected string n_sTeamcode=global::System.String.Empty;
        #region teamcode
        [System.Data.Linq.Mapping.Column(Name="[teamcode]", Storage="n_sTeamcode")]
        public string teamcode{
            get{
                return this.n_sTeamcode;
            }
            set{
                this.n_sTeamcode=value;
            }
        }
        #endregion teamcode
        
        
        protected string n_sBill_medium=global::System.String.Empty;
        #region bill_medium
        [System.Data.Linq.Mapping.Column(Name="[bill_medium]", Storage="n_sBill_medium")]
        public string bill_medium{
            get{
                return this.n_sBill_medium;
            }
            set{
                this.n_sBill_medium=value;
            }
        }
        #endregion bill_medium
        
        
        protected string n_sEdf_no=global::System.String.Empty;
        #region edf_no
        [System.Data.Linq.Mapping.Column(Name="[edf_no]", Storage="n_sEdf_no")]
        public string edf_no{
            get{
                return this.n_sEdf_no;
            }
            set{
                this.n_sEdf_no=value;
            }
        }
        #endregion edf_no
        
        
        protected string n_sOrd_place_by=global::System.String.Empty;
        #region ord_place_by
        [System.Data.Linq.Mapping.Column(Name="[ord_place_by]", Storage="n_sOrd_place_by")]
        public string ord_place_by{
            get{
                return this.n_sOrd_place_by;
            }
            set{
                this.n_sOrd_place_by=value;
            }
        }
        #endregion ord_place_by
        
        
        protected string n_sCancel_renew=global::System.String.Empty;
        #region cancel_renew
        [System.Data.Linq.Mapping.Column(Name="[cancel_renew]", Storage="n_sCancel_renew")]
        public string cancel_renew{
            get{
                return this.n_sCancel_renew;
            }
            set{
                this.n_sCancel_renew=value;
            }
        }
        #endregion cancel_renew
        
        
        protected string n_sPreferred_languages=global::System.String.Empty;
        #region preferred_languages
        [System.Data.Linq.Mapping.Column(Name="[preferred_languages]", Storage="n_sPreferred_languages")]
        public string preferred_languages{
            get{
                return this.n_sPreferred_languages;
            }
            set{
                this.n_sPreferred_languages=value;
            }
        }
        #endregion preferred_languages
        
        
        protected string n_sHkid=global::System.String.Empty;
        #region hkid
        [System.Data.Linq.Mapping.Column(Name="[hkid]", Storage="n_sHkid")]
        public string hkid{
            get{
                return this.n_sHkid;
            }
            set{
                this.n_sHkid=value;
            }
        }
        #endregion hkid
        
        
        protected string n_sCard_holder=global::System.String.Empty;
        #region card_holder
        [System.Data.Linq.Mapping.Column(Name="[card_holder]", Storage="n_sCard_holder")]
        public string card_holder{
            get{
                return this.n_sCard_holder;
            }
            set{
                this.n_sCard_holder=value;
            }
        }
        #endregion card_holder
        
        
        protected string n_sAc_no=global::System.String.Empty;
        #region ac_no
        [System.Data.Linq.Mapping.Column(Name="[ac_no]", Storage="n_sAc_no")]
        public string ac_no{
            get{
                return this.n_sAc_no;
            }
            set{
                this.n_sAc_no=value;
            }
        }
        #endregion ac_no
        
        
        protected global::System.Nullable<int> n_iBill_cut_num=null;
        #region bill_cut_num
        [System.Data.Linq.Mapping.Column(Name="[bill_cut_num]", Storage="n_iBill_cut_num")]
        public global::System.Nullable<int> bill_cut_num{
            get{
                return this.n_iBill_cut_num;
            }
            set{
                this.n_iBill_cut_num=value;
            }
        }
        #endregion bill_cut_num
        
        
        protected string n_sPremium=global::System.String.Empty;
        #region premium
        [System.Data.Linq.Mapping.Column(Name="[premium]", Storage="n_sPremium")]
        public string premium{
            get{
                return this.n_sPremium;
            }
            set{
                this.n_sPremium=value;
            }
        }
        #endregion premium
        
        
        protected string n_sDel_remark=global::System.String.Empty;
        #region del_remark
        [System.Data.Linq.Mapping.Column(Name="[del_remark]", Storage="n_sDel_remark")]
        public string del_remark{
            get{
                return this.n_sDel_remark;
            }
            set{
                this.n_sDel_remark=value;
            }
        }
        #endregion del_remark
        
        
        protected string n_sGift_imei2=global::System.String.Empty;
        #region gift_imei2
        [System.Data.Linq.Mapping.Column(Name="[gift_imei2]", Storage="n_sGift_imei2")]
        public string gift_imei2{
            get{
                return this.n_sGift_imei2;
            }
            set{
                this.n_sGift_imei2=value;
            }
        }
        #endregion gift_imei2
        
        
        protected string n_sReasons=global::System.String.Empty;
        #region reasons
        [System.Data.Linq.Mapping.Column(Name="[reasons]", Storage="n_sReasons")]
        public string reasons{
            get{
                return this.n_sReasons;
            }
            set{
                this.n_sReasons=value;
            }
        }
        #endregion reasons
        
        
        protected string n_sLanguage=global::System.String.Empty;
        #region language
        [System.Data.Linq.Mapping.Column(Name="[language]", Storage="n_sLanguage")]
        public string language{
            get{
                return this.n_sLanguage;
            }
            set{
                this.n_sLanguage=value;
            }
        }
        #endregion language
        
        
        protected string n_sRebate_amount=global::System.String.Empty;
        #region rebate_amount
        [System.Data.Linq.Mapping.Column(Name="[rebate_amount]", Storage="n_sRebate_amount")]
        public string rebate_amount{
            get{
                return this.n_sRebate_amount;
            }
            set{
                this.n_sRebate_amount=value;
            }
        }
        #endregion rebate_amount
        
        
        protected string n_sOrd_place_id_type=global::System.String.Empty;
        #region ord_place_id_type
        [System.Data.Linq.Mapping.Column(Name="[ord_place_id_type]", Storage="n_sOrd_place_id_type")]
        public string ord_place_id_type{
            get{
                return this.n_sOrd_place_id_type;
            }
            set{
                this.n_sOrd_place_id_type=value;
            }
        }
        #endregion ord_place_id_type
        
        
        protected string n_sM_3rd_contact_no=global::System.String.Empty;
        #region m_3rd_contact_no
        [System.Data.Linq.Mapping.Column(Name="[m_3rd_contact_no]", Storage="n_sM_3rd_contact_no")]
        public string m_3rd_contact_no{
            get{
                return this.n_sM_3rd_contact_no;
            }
            set{
                this.n_sM_3rd_contact_no=value;
            }
        }
        #endregion m_3rd_contact_no
        
        
        protected string n_sStaff_no=global::System.String.Empty;
        #region staff_no
        [System.Data.Linq.Mapping.Column(Name="[staff_no]", Storage="n_sStaff_no")]
        public string staff_no{
            get{
                return this.n_sStaff_no;
            }
            set{
                this.n_sStaff_no=value;
            }
        }
        #endregion staff_no
        
        
        protected global::System.Nullable<DateTime> n_dSp_d_date=null;
        #region sp_d_date
        [System.Data.Linq.Mapping.Column(Name="[sp_d_date]", Storage="n_dSp_d_date")]
        public global::System.Nullable<DateTime> sp_d_date{
            get{
                return this.n_dSp_d_date;
            }
            set{
                this.n_dSp_d_date=value;
            }
        }
        #endregion sp_d_date
        
        
        protected string n_sBundle_name=global::System.String.Empty;
        #region bundle_name
        [System.Data.Linq.Mapping.Column(Name="[bundle_name]", Storage="n_sBundle_name")]
        public string bundle_name{
            get{
                return this.n_sBundle_name;
            }
            set{
                this.n_sBundle_name=value;
            }
        }
        #endregion bundle_name
        
        
        protected global::System.Nullable<bool> n_bAccessory_waive=null;
        #region accessory_waive
        [System.Data.Linq.Mapping.Column(Name="[accessory_waive]", Storage="n_bAccessory_waive")]
        public global::System.Nullable<bool> accessory_waive{
            get{
                return this.n_bAccessory_waive;
            }
            set{
                this.n_bAccessory_waive=value;
            }
        }
        #endregion accessory_waive
        
        
        protected string n_sSim_item_code=global::System.String.Empty;
        #region sim_item_code
        [System.Data.Linq.Mapping.Column(Name="[sim_item_code]", Storage="n_sSim_item_code")]
        public string sim_item_code{
            get{
                return this.n_sSim_item_code;
            }
            set{
                this.n_sSim_item_code=value;
            }
        }
        #endregion sim_item_code
        
        
        protected string n_sCust_type=global::System.String.Empty;
        #region cust_type
        [System.Data.Linq.Mapping.Column(Name="[cust_type]", Storage="n_sCust_type")]
        public string cust_type{
            get{
                return this.n_sCust_type;
            }
            set{
                this.n_sCust_type=value;
            }
        }
        #endregion cust_type
        
        
        protected string n_sCard_ref_no=global::System.String.Empty;
        #region card_ref_no
        [System.Data.Linq.Mapping.Column(Name="[card_ref_no]", Storage="n_sCard_ref_no")]
        public string card_ref_no{
            get{
                return this.n_sCard_ref_no;
            }
            set{
                this.n_sCard_ref_no=value;
            }
        }
        #endregion card_ref_no
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private MobileRetentionOrderInfo n_oTableSet = MobileRetentionOrderInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string gift_imei="gift_imei";
            public const string s_premium4="s_premium4";
            public const string gift_desc4="gift_desc4";
            public const string accessory_desc="accessory_desc";
            public const string action_required="action_required";
            public const string vas_eff_date="vas_eff_date";
            public const string monthly_bank_account_bank_code="monthly_bank_account_bank_code";
            public const string special_handling_dummy_code="special_handling_dummy_code";
            public const string m_card_exp_year="m_card_exp_year";
            public const string remarks2PY="remarks2PY";
            public const string trade_field="trade_field";
            public const string ord_place_tel="ord_place_tel";
            public const string ord_place_id_type="ord_place_id_type";
            public const string cooling_offer="cooling_offer";
            public const string upgrade_handset_offer_rebate_schedule="upgrade_handset_offer_rebate_schedule";
            public const string change_payment_type="change_payment_type";
            public const string date_of_birth="date_of_birth";
            public const string contact_person="contact_person";
            public const string extra_d_charge="extra_d_charge";
            public const string tl_name="tl_name";
            public const string fast_start="fast_start";
            public const string sp_ref_no="sp_ref_no";
            public const string edate="edate";
            public const string exist_cust_plan="exist_cust_plan";
            public const string ord_place_rel="ord_place_rel";
            public const string mrt_no="mrt_no";
            public const string imei_no="imei_no";
            public const string existing_smart_phone_model="existing_smart_phone_model";
            public const string gift_code3="gift_code3";
            public const string bank_code="bank_code";
            public const string pos_ref_no="pos_ref_no";
            public const string bill_cut_date="bill_cut_date";
            public const string gift_imei3="gift_imei3";
            public const string exist_plan="exist_plan";
            public const string waive="waive";
            public const string program="program";
            public const string first_month_fee="first_month_fee";
            public const string r_offer="r_offer";
            public const string cid="cid";
            public const string did="did";
            public const string ftg_tenure="ftg_tenure";
            public const string con_per="con_per";
            public const string gift_code4="gift_code4";
            public const string easywatch_type="easywatch_type";
            public const string sms_mrt="sms_mrt";
            public const string monthly_payment_method="monthly_payment_method";
            public const string remarks2EDF="remarks2EDF";
            public const string gift_desc3="gift_desc3";
            public const string gift_imei4="gift_imei4";
            public const string old_ord_id="old_ord_id";
            public const string monthly_bank_account_hkid2="monthly_bank_account_hkid2";
            public const string d_date="d_date";
            public const string gift_desc="gift_desc";
            public const string salesmancode="salesmancode";
            public const string pool="pool";
            public const string cn_mrt_no="cn_mrt_no";
            public const string accessory_imei="accessory_imei";
            public const string third_party_credit_card="third_party_credit_card";
            public const string card_ref_no="card_ref_no";
            public const string special_approval="special_approval";
            public const string upgrade_existing_contract_edate="upgrade_existing_contract_edate";
            public const string accessory_code="accessory_code";
            public const string bill_medium="bill_medium";
            public const string s_premium="s_premium";
            public const string ref_staff_no="ref_staff_no";
            public const string accessory_price="accessory_price";
            public const string m_card_exp_month="m_card_exp_month";
            public const string installment_period="installment_period";
            public const string m_card_type="m_card_type";
            public const string easywatch_ord_id="easywatch_ord_id";
            public const string normal_rebate="normal_rebate";
            public const string m_rebate_amount="m_rebate_amount";
            public const string m_card_holder2="m_card_holder2";
            public const string bill_medium_email="bill_medium_email";
            public const string active="active";
            public const string s_premium1="s_premium1";
            public const string card_exp_month="card_exp_month";
            public const string ob_program_id="ob_program_id";
            public const string sku="sku";
            public const string ref_salesmancode="ref_salesmancode";
            public const string go_wireless_package_code="go_wireless_package_code";
            public const string third_party_hkid="third_party_hkid";
            public const string upgrade_existing_pccw_customer="upgrade_existing_pccw_customer";
            public const string d_address="d_address";
            public const string upgrade_registered_mobile_no="upgrade_registered_mobile_no";
            public const string upgrade_existing_customer_type="upgrade_existing_customer_type";
            public const string normal_rebate_type="normal_rebate_type";
            public const string gift_desc2="gift_desc2";
            public const string monthly_bank_account_branch_code="monthly_bank_account_branch_code";
            public const string remarks="remarks";
            public const string accept="accept";
            public const string delivery_exchange="delivery_exchange";
            public const string gift_code2="gift_code2";
            public const string prepayment_waive="prepayment_waive";
            public const string existing_smart_phone_imei="existing_smart_phone_imei";
            public const string cust_name="cust_name";
            public const string cust_type="cust_type";
            public const string upgrade_sponsorships_amount="upgrade_sponsorships_amount";
            public const string bill_medium_waive="bill_medium_waive";
            public const string delivery_exchange_location="delivery_exchange_location";
            public const string hs_offer_type_id="hs_offer_type_id";
            public const string org_fee="org_fee";
            public const string rebate="rebate";
            public const string upgrade_type="upgrade_type";
            public const string go_wireless="go_wireless";
            public const string extra_rebate="extra_rebate";
            public const string plan_eff="plan_eff";
            public const string extra_rebate_amount="extra_rebate_amount";
            public const string card_exp_year="card_exp_year";
            public const string upgrade_existing_contract_sdate="upgrade_existing_contract_sdate";
            public const string ord_place_hkid="ord_place_hkid";
            public const string register_address="register_address";
            public const string gender="gender";
            public const string lob_ac="lob_ac";
            public const string sim_mrt_no="sim_mrt_no";
            public const string redemption_notice_option="redemption_notice_option";
            public const string delivery_collection_type="delivery_collection_type";
            public const string action_date="action_date";
            public const string third_party_id_type="third_party_id_type";
            public const string org_ftg="org_ftg";
            public const string upgrade_service_tenure="upgrade_service_tenure";
            public const string monthly_payment_type="monthly_payment_type";
            public const string contact_no="contact_no";
            public const string org_mrt="org_mrt";
            public const string sim_item_name="sim_item_name";
            public const string pay_method="pay_method";
            public const string hs_model="hs_model";
            public const string gift_code="gift_code";
            public const string monthly_bank_account_hkid="monthly_bank_account_hkid";
            public const string extra_offer="extra_offer";
            public const string monthly_bank_account_no="monthly_bank_account_no";
            public const string first_month_license_fee="first_month_license_fee";
            public const string retrieve_cnt="retrieve_cnt";
            public const string ddate="ddate";
            public const string s_premium2="s_premium2";
            public const string monthly_bank_account_id_type="monthly_bank_account_id_type";
            public const string card_type="card_type";
            public const string next_bill="next_bill";
            public const string pcd_paid_go_wireless="pcd_paid_go_wireless";
            public const string upgrade_rebate_calculation="upgrade_rebate_calculation";
            public const string ext_place_tel="ext_place_tel";
            public const string m_3rd_hkid="m_3rd_hkid";
            public const string retention_type="retention_type";
            public const string cooling_date="cooling_date";
            public const string aig_gift="aig_gift";
            public const string cust_staff_no="cust_staff_no";
            public const string order_id="order_id";
            public const string family_name="family_name";
            public const string cdate="cdate";
            public const string status_by_cs_admin="status_by_cs_admin";
            public const string sim_item_number="sim_item_number";
            public const string vip_case="vip_case";
            public const string given_name="given_name";
            public const string log_date="log_date";
            public const string extn="extn";
            public const string d_time="d_time";
            public const string bank_name="bank_name";
            public const string delivery_exchange_option="delivery_exchange_option";
            public const string upgrade_service_account_no="upgrade_service_account_no";
            public const string action_of_rate_plan_effective="action_of_rate_plan_effective";
            public const string m_card_no="m_card_no";
            public const string existing_contract_end_date="existing_contract_end_date";
            public const string con_eff_date="con_eff_date";
            public const string m_3rd_hkid2="m_3rd_hkid2";
            public const string amount="amount";
            public const string id_type="id_type";
            public const string rate_plan="rate_plan";
            public const string channel="channel";
            public const string action_eff_date="action_eff_date";
            public const string issue_type="issue_type";
            public const string free_mon="free_mon";
            public const string plan_eff_date="plan_eff_date";
            public const string del_remark="del_remark";
            public const string teamcode="teamcode";
            public const string staff_name="staff_name";
            public const string edf_no="edf_no";
            public const string ord_place_by="ord_place_by";
            public const string cancel_renew="cancel_renew";
            public const string preferred_languages="preferred_languages";
            public const string hkid="hkid";
            public const string card_no="card_no";
            public const string ac_no="ac_no";
            public const string bill_cut_num="bill_cut_num";
            public const string premium="premium";
            public const string m_3rd_id_type="m_3rd_id_type";
            public const string gift_imei2="gift_imei2";
            public const string reasons="reasons";
            public const string language="language";
            public const string rebate_amount="rebate_amount";
            public const string lob="lob";
            public const string m_3rd_contact_no="m_3rd_contact_no";
            public const string staff_no="staff_no";
            public const string s_premium3="s_premium3";
            public const string sp_d_date="sp_d_date";
            public const string bundle_name="bundle_name";
            public const string accessory_waive="accessory_waive";
            public const string sim_item_code="sim_item_code";
            public const string monthly_bank_account_holder="monthly_bank_account_holder";
            public const string card_holder="card_holder";
            public const string MobileRetentionOrder_table_name="MobileRetentionOrder";
            public static string TableName() { return MobileRetentionOrder_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public MobileRetentionOrderEntity(){
            Init();
        }
        public MobileRetentionOrderEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public MobileRetentionOrderEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iOrder_id){
            n_oDB=x_oDB;
            this.Load(x_iOrder_id);
            Init();
        }
        
        ~MobileRetentionOrderEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iOrder_id){
            if (n_oDB==null) { return false; }
            if (x_iOrder_id==null) { return false; }
            string _sQuery = "SELECT   [MobileRetentionOrder].[gift_imei] AS MOBILERETENTIONORDER_GIFT_IMEI,[MobileRetentionOrder].[s_premium4] AS MOBILERETENTIONORDER_S_PREMIUM4,[MobileRetentionOrder].[upgrade_existing_customer_type] AS MOBILERETENTIONORDER_UPGRADE_EXISTING_CUSTOMER_TYPE,[MobileRetentionOrder].[gift_desc4] AS MOBILERETENTIONORDER_GIFT_DESC4,[MobileRetentionOrder].[accessory_desc] AS MOBILERETENTIONORDER_ACCESSORY_DESC,[MobileRetentionOrder].[staff_name] AS MOBILERETENTIONORDER_STAFF_NAME,[MobileRetentionOrder].[action_required] AS MOBILERETENTIONORDER_ACTION_REQUIRED,[MobileRetentionOrder].[vas_eff_date] AS MOBILERETENTIONORDER_VAS_EFF_DATE,[MobileRetentionOrder].[monthly_bank_account_bank_code] AS MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_BANK_CODE,[MobileRetentionOrder].[sim_item_number] AS MOBILERETENTIONORDER_SIM_ITEM_NUMBER,[MobileRetentionOrder].[special_handling_dummy_code] AS MOBILERETENTIONORDER_SPECIAL_HANDLING_DUMMY_CODE,[MobileRetentionOrder].[card_no] AS MOBILERETENTIONORDER_CARD_NO,[MobileRetentionOrder].[m_card_exp_year] AS MOBILERETENTIONORDER_M_CARD_EXP_YEAR,[MobileRetentionOrder].[bill_medium_email] AS MOBILERETENTIONORDER_BILL_MEDIUM_EMAIL,[MobileRetentionOrder].[remarks2PY] AS MOBILERETENTIONORDER_REMARKS2PY,[MobileRetentionOrder].[trade_field] AS MOBILERETENTIONORDER_TRADE_FIELD,[MobileRetentionOrder].[ord_place_tel] AS MOBILERETENTIONORDER_ORD_PLACE_TEL,[MobileRetentionOrder].[action_of_rate_plan_effective] AS MOBILERETENTIONORDER_ACTION_OF_RATE_PLAN_EFFECTIVE,[MobileRetentionOrder].[cooling_offer] AS MOBILERETENTIONORDER_COOLING_OFFER,[MobileRetentionOrder].[upgrade_handset_offer_rebate_schedule] AS MOBILERETENTIONORDER_UPGRADE_HANDSET_OFFER_REBATE_SCHEDULE,[MobileRetentionOrder].[change_payment_type] AS MOBILERETENTIONORDER_CHANGE_PAYMENT_TYPE,[MobileRetentionOrder].[date_of_birth] AS MOBILERETENTIONORDER_DATE_OF_BIRTH,[MobileRetentionOrder].[contact_person] AS MOBILERETENTIONORDER_CONTACT_PERSON,[MobileRetentionOrder].[extra_d_charge] AS MOBILERETENTIONORDER_EXTRA_D_CHARGE,[MobileRetentionOrder].[tl_name] AS MOBILERETENTIONORDER_TL_NAME,[MobileRetentionOrder].[fast_start] AS MOBILERETENTIONORDER_FAST_START,[MobileRetentionOrder].[sp_ref_no] AS MOBILERETENTIONORDER_SP_REF_NO,[MobileRetentionOrder].[edate] AS MOBILERETENTIONORDER_EDATE,[MobileRetentionOrder].[exist_cust_plan] AS MOBILERETENTIONORDER_EXIST_CUST_PLAN,[MobileRetentionOrder].[ord_place_rel] AS MOBILERETENTIONORDER_ORD_PLACE_REL,[MobileRetentionOrder].[mrt_no] AS MOBILERETENTIONORDER_MRT_NO,[MobileRetentionOrder].[imei_no] AS MOBILERETENTIONORDER_IMEI_NO,[MobileRetentionOrder].[existing_smart_phone_model] AS MOBILERETENTIONORDER_EXISTING_SMART_PHONE_MODEL,[MobileRetentionOrder].[bank_code] AS MOBILERETENTIONORDER_BANK_CODE,[MobileRetentionOrder].[pos_ref_no] AS MOBILERETENTIONORDER_POS_REF_NO,[MobileRetentionOrder].[bill_cut_date] AS MOBILERETENTIONORDER_BILL_CUT_DATE,[MobileRetentionOrder].[gift_imei3] AS MOBILERETENTIONORDER_GIFT_IMEI3,[MobileRetentionOrder].[exist_plan] AS MOBILERETENTIONORDER_EXIST_PLAN,[MobileRetentionOrder].[waive] AS MOBILERETENTIONORDER_WAIVE,[MobileRetentionOrder].[program] AS MOBILERETENTIONORDER_PROGRAM,[MobileRetentionOrder].[first_month_fee] AS MOBILERETENTIONORDER_FIRST_MONTH_FEE,[MobileRetentionOrder].[r_offer] AS MOBILERETENTIONORDER_R_OFFER,[MobileRetentionOrder].[cid] AS MOBILERETENTIONORDER_CID,[MobileRetentionOrder].[did] AS MOBILERETENTIONORDER_DID,[MobileRetentionOrder].[ftg_tenure] AS MOBILERETENTIONORDER_FTG_TENURE,[MobileRetentionOrder].[con_per] AS MOBILERETENTIONORDER_CON_PER,[MobileRetentionOrder].[gift_code4] AS MOBILERETENTIONORDER_GIFT_CODE4,[MobileRetentionOrder].[easywatch_type] AS MOBILERETENTIONORDER_EASYWATCH_TYPE,[MobileRetentionOrder].[sms_mrt] AS MOBILERETENTIONORDER_SMS_MRT,[MobileRetentionOrder].[monthly_payment_method] AS MOBILERETENTIONORDER_MONTHLY_PAYMENT_METHOD,[MobileRetentionOrder].[remarks2EDF] AS MOBILERETENTIONORDER_REMARKS2EDF,[MobileRetentionOrder].[gift_desc3] AS MOBILERETENTIONORDER_GIFT_DESC3,[MobileRetentionOrder].[gift_imei4] AS MOBILERETENTIONORDER_GIFT_IMEI4,[MobileRetentionOrder].[monthly_bank_account_hkid2] AS MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HKID2,[MobileRetentionOrder].[d_date] AS MOBILERETENTIONORDER_D_DATE,[MobileRetentionOrder].[gift_desc] AS MOBILERETENTIONORDER_GIFT_DESC,[MobileRetentionOrder].[pool] AS MOBILERETENTIONORDER_POOL,[MobileRetentionOrder].[cn_mrt_no] AS MOBILERETENTIONORDER_CN_MRT_NO,[MobileRetentionOrder].[accessory_imei] AS MOBILERETENTIONORDER_ACCESSORY_IMEI,[MobileRetentionOrder].[third_party_credit_card] AS MOBILERETENTIONORDER_THIRD_PARTY_CREDIT_CARD,[MobileRetentionOrder].[special_approval] AS MOBILERETENTIONORDER_SPECIAL_APPROVAL,[MobileRetentionOrder].[upgrade_existing_contract_edate] AS MOBILERETENTIONORDER_UPGRADE_EXISTING_CONTRACT_EDATE,[MobileRetentionOrder].[accessory_code] AS MOBILERETENTIONORDER_ACCESSORY_CODE,[MobileRetentionOrder].[s_premium] AS MOBILERETENTIONORDER_S_PREMIUM,[MobileRetentionOrder].[ref_staff_no] AS MOBILERETENTIONORDER_REF_STAFF_NO,[MobileRetentionOrder].[accessory_price] AS MOBILERETENTIONORDER_ACCESSORY_PRICE,[MobileRetentionOrder].[m_card_exp_month] AS MOBILERETENTIONORDER_M_CARD_EXP_MONTH,[MobileRetentionOrder].[installment_period] AS MOBILERETENTIONORDER_INSTALLMENT_PERIOD,[MobileRetentionOrder].[m_card_type] AS MOBILERETENTIONORDER_M_CARD_TYPE,[MobileRetentionOrder].[easywatch_ord_id] AS MOBILERETENTIONORDER_EASYWATCH_ORD_ID,[MobileRetentionOrder].[normal_rebate] AS MOBILERETENTIONORDER_NORMAL_REBATE,[MobileRetentionOrder].[m_rebate_amount] AS MOBILERETENTIONORDER_M_REBATE_AMOUNT,[MobileRetentionOrder].[m_card_holder2] AS MOBILERETENTIONORDER_M_CARD_HOLDER2,[MobileRetentionOrder].[monthly_bank_account_holder] AS MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HOLDER,[MobileRetentionOrder].[active] AS MOBILERETENTIONORDER_ACTIVE,[MobileRetentionOrder].[s_premium1] AS MOBILERETENTIONORDER_S_PREMIUM1,[MobileRetentionOrder].[card_exp_month] AS MOBILERETENTIONORDER_CARD_EXP_MONTH,[MobileRetentionOrder].[ob_program_id] AS MOBILERETENTIONORDER_OB_PROGRAM_ID,[MobileRetentionOrder].[sku] AS MOBILERETENTIONORDER_SKU,[MobileRetentionOrder].[salesmancode] AS MOBILERETENTIONORDER_SALESMANCODE,[MobileRetentionOrder].[go_wireless_package_code] AS MOBILERETENTIONORDER_GO_WIRELESS_PACKAGE_CODE,[MobileRetentionOrder].[lob] AS MOBILERETENTIONORDER_LOB,[MobileRetentionOrder].[ref_salesmancode] AS MOBILERETENTIONORDER_REF_SALESMANCODE,[MobileRetentionOrder].[third_party_hkid] AS MOBILERETENTIONORDER_THIRD_PARTY_HKID,[MobileRetentionOrder].[upgrade_existing_pccw_customer] AS MOBILERETENTIONORDER_UPGRADE_EXISTING_PCCW_CUSTOMER,[MobileRetentionOrder].[d_address] AS MOBILERETENTIONORDER_D_ADDRESS,[MobileRetentionOrder].[upgrade_registered_mobile_no] AS MOBILERETENTIONORDER_UPGRADE_REGISTERED_MOBILE_NO,[MobileRetentionOrder].[gift_code3] AS MOBILERETENTIONORDER_GIFT_CODE3,[MobileRetentionOrder].[normal_rebate_type] AS MOBILERETENTIONORDER_NORMAL_REBATE_TYPE,[MobileRetentionOrder].[gift_desc2] AS MOBILERETENTIONORDER_GIFT_DESC2,[MobileRetentionOrder].[monthly_bank_account_branch_code] AS MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_BRANCH_CODE,[MobileRetentionOrder].[remarks] AS MOBILERETENTIONORDER_REMARKS,[MobileRetentionOrder].[accept] AS MOBILERETENTIONORDER_ACCEPT,[MobileRetentionOrder].[delivery_exchange] AS MOBILERETENTIONORDER_DELIVERY_EXCHANGE,[MobileRetentionOrder].[gift_code2] AS MOBILERETENTIONORDER_GIFT_CODE2,[MobileRetentionOrder].[prepayment_waive] AS MOBILERETENTIONORDER_PREPAYMENT_WAIVE,[MobileRetentionOrder].[existing_smart_phone_imei] AS MOBILERETENTIONORDER_EXISTING_SMART_PHONE_IMEI,[MobileRetentionOrder].[cust_name] AS MOBILERETENTIONORDER_CUST_NAME,[MobileRetentionOrder].[upgrade_sponsorships_amount] AS MOBILERETENTIONORDER_UPGRADE_SPONSORSHIPS_AMOUNT,[MobileRetentionOrder].[bill_medium_waive] AS MOBILERETENTIONORDER_BILL_MEDIUM_WAIVE,[MobileRetentionOrder].[delivery_exchange_location] AS MOBILERETENTIONORDER_DELIVERY_EXCHANGE_LOCATION,[MobileRetentionOrder].[hs_offer_type_id] AS MOBILERETENTIONORDER_HS_OFFER_TYPE_ID,[MobileRetentionOrder].[extra_rebate_amount] AS MOBILERETENTIONORDER_EXTRA_REBATE_AMOUNT,[MobileRetentionOrder].[rebate] AS MOBILERETENTIONORDER_REBATE,[MobileRetentionOrder].[upgrade_type] AS MOBILERETENTIONORDER_UPGRADE_TYPE,[MobileRetentionOrder].[go_wireless] AS MOBILERETENTIONORDER_GO_WIRELESS,[MobileRetentionOrder].[extra_rebate] AS MOBILERETENTIONORDER_EXTRA_REBATE,[MobileRetentionOrder].[plan_eff] AS MOBILERETENTIONORDER_PLAN_EFF,[MobileRetentionOrder].[card_exp_year] AS MOBILERETENTIONORDER_CARD_EXP_YEAR,[MobileRetentionOrder].[upgrade_existing_contract_sdate] AS MOBILERETENTIONORDER_UPGRADE_EXISTING_CONTRACT_SDATE,[MobileRetentionOrder].[ord_place_hkid] AS MOBILERETENTIONORDER_ORD_PLACE_HKID,[MobileRetentionOrder].[register_address] AS MOBILERETENTIONORDER_REGISTER_ADDRESS,[MobileRetentionOrder].[gender] AS MOBILERETENTIONORDER_GENDER,[MobileRetentionOrder].[lob_ac] AS MOBILERETENTIONORDER_LOB_AC,[MobileRetentionOrder].[sim_mrt_no] AS MOBILERETENTIONORDER_SIM_MRT_NO,[MobileRetentionOrder].[redemption_notice_option] AS MOBILERETENTIONORDER_REDEMPTION_NOTICE_OPTION,[MobileRetentionOrder].[delivery_collection_type] AS MOBILERETENTIONORDER_DELIVERY_COLLECTION_TYPE,[MobileRetentionOrder].[action_date] AS MOBILERETENTIONORDER_ACTION_DATE,[MobileRetentionOrder].[third_party_id_type] AS MOBILERETENTIONORDER_THIRD_PARTY_ID_TYPE,[MobileRetentionOrder].[org_ftg] AS MOBILERETENTIONORDER_ORG_FTG,[MobileRetentionOrder].[upgrade_service_tenure] AS MOBILERETENTIONORDER_UPGRADE_SERVICE_TENURE,[MobileRetentionOrder].[monthly_payment_type] AS MOBILERETENTIONORDER_MONTHLY_PAYMENT_TYPE,[MobileRetentionOrder].[contact_no] AS MOBILERETENTIONORDER_CONTACT_NO,[MobileRetentionOrder].[org_mrt] AS MOBILERETENTIONORDER_ORG_MRT,[MobileRetentionOrder].[sim_item_name] AS MOBILERETENTIONORDER_SIM_ITEM_NAME,[MobileRetentionOrder].[pay_method] AS MOBILERETENTIONORDER_PAY_METHOD,[MobileRetentionOrder].[hs_model] AS MOBILERETENTIONORDER_HS_MODEL,[MobileRetentionOrder].[gift_code] AS MOBILERETENTIONORDER_GIFT_CODE,[MobileRetentionOrder].[monthly_bank_account_hkid] AS MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HKID,[MobileRetentionOrder].[extra_offer] AS MOBILERETENTIONORDER_EXTRA_OFFER,[MobileRetentionOrder].[monthly_bank_account_no] AS MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_NO,[MobileRetentionOrder].[first_month_license_fee] AS MOBILERETENTIONORDER_FIRST_MONTH_LICENSE_FEE,[MobileRetentionOrder].[retrieve_cnt] AS MOBILERETENTIONORDER_RETRIEVE_CNT,[MobileRetentionOrder].[ddate] AS MOBILERETENTIONORDER_DDATE,[MobileRetentionOrder].[s_premium2] AS MOBILERETENTIONORDER_S_PREMIUM2,[MobileRetentionOrder].[monthly_bank_account_id_type] AS MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_ID_TYPE,[MobileRetentionOrder].[card_type] AS MOBILERETENTIONORDER_CARD_TYPE,[MobileRetentionOrder].[next_bill] AS MOBILERETENTIONORDER_NEXT_BILL,[MobileRetentionOrder].[pcd_paid_go_wireless] AS MOBILERETENTIONORDER_PCD_PAID_GO_WIRELESS,[MobileRetentionOrder].[upgrade_rebate_calculation] AS MOBILERETENTIONORDER_UPGRADE_REBATE_CALCULATION,[MobileRetentionOrder].[ext_place_tel] AS MOBILERETENTIONORDER_EXT_PLACE_TEL,[MobileRetentionOrder].[m_3rd_hkid] AS MOBILERETENTIONORDER_M_3RD_HKID,[MobileRetentionOrder].[retention_type] AS MOBILERETENTIONORDER_RETENTION_TYPE,[MobileRetentionOrder].[cooling_date] AS MOBILERETENTIONORDER_COOLING_DATE,[MobileRetentionOrder].[aig_gift] AS MOBILERETENTIONORDER_AIG_GIFT,[MobileRetentionOrder].[cust_staff_no] AS MOBILERETENTIONORDER_CUST_STAFF_NO,[MobileRetentionOrder].[order_id] AS MOBILERETENTIONORDER_ORDER_ID,[MobileRetentionOrder].[family_name] AS MOBILERETENTIONORDER_FAMILY_NAME,[MobileRetentionOrder].[cdate] AS MOBILERETENTIONORDER_CDATE,[MobileRetentionOrder].[status_by_cs_admin] AS MOBILERETENTIONORDER_STATUS_BY_CS_ADMIN,[MobileRetentionOrder].[given_name] AS MOBILERETENTIONORDER_GIVEN_NAME,[MobileRetentionOrder].[vip_case] AS MOBILERETENTIONORDER_VIP_CASE,[MobileRetentionOrder].[org_fee] AS MOBILERETENTIONORDER_ORG_FEE,[MobileRetentionOrder].[s_premium3] AS MOBILERETENTIONORDER_S_PREMIUM3,[MobileRetentionOrder].[log_date] AS MOBILERETENTIONORDER_LOG_DATE,[MobileRetentionOrder].[extn] AS MOBILERETENTIONORDER_EXTN,[MobileRetentionOrder].[d_time] AS MOBILERETENTIONORDER_D_TIME,[MobileRetentionOrder].[bank_name] AS MOBILERETENTIONORDER_BANK_NAME,[MobileRetentionOrder].[delivery_exchange_option] AS MOBILERETENTIONORDER_DELIVERY_EXCHANGE_OPTION,[MobileRetentionOrder].[upgrade_service_account_no] AS MOBILERETENTIONORDER_UPGRADE_SERVICE_ACCOUNT_NO,[MobileRetentionOrder].[old_ord_id] AS MOBILERETENTIONORDER_OLD_ORD_ID,[MobileRetentionOrder].[m_card_no] AS MOBILERETENTIONORDER_M_CARD_NO,[MobileRetentionOrder].[existing_contract_end_date] AS MOBILERETENTIONORDER_EXISTING_CONTRACT_END_DATE,[MobileRetentionOrder].[con_eff_date] AS MOBILERETENTIONORDER_CON_EFF_DATE,[MobileRetentionOrder].[m_3rd_hkid2] AS MOBILERETENTIONORDER_M_3RD_HKID2,[MobileRetentionOrder].[amount] AS MOBILERETENTIONORDER_AMOUNT,[MobileRetentionOrder].[m_3rd_id_type] AS MOBILERETENTIONORDER_M_3RD_ID_TYPE,[MobileRetentionOrder].[id_type] AS MOBILERETENTIONORDER_ID_TYPE,[MobileRetentionOrder].[rate_plan] AS MOBILERETENTIONORDER_RATE_PLAN,[MobileRetentionOrder].[channel] AS MOBILERETENTIONORDER_CHANNEL,[MobileRetentionOrder].[action_eff_date] AS MOBILERETENTIONORDER_ACTION_EFF_DATE,[MobileRetentionOrder].[issue_type] AS MOBILERETENTIONORDER_ISSUE_TYPE,[MobileRetentionOrder].[free_mon] AS MOBILERETENTIONORDER_FREE_MON,[MobileRetentionOrder].[plan_eff_date] AS MOBILERETENTIONORDER_PLAN_EFF_DATE,[MobileRetentionOrder].[teamcode] AS MOBILERETENTIONORDER_TEAMCODE,[MobileRetentionOrder].[bill_medium] AS MOBILERETENTIONORDER_BILL_MEDIUM,[MobileRetentionOrder].[edf_no] AS MOBILERETENTIONORDER_EDF_NO,[MobileRetentionOrder].[ord_place_by] AS MOBILERETENTIONORDER_ORD_PLACE_BY,[MobileRetentionOrder].[cancel_renew] AS MOBILERETENTIONORDER_CANCEL_RENEW,[MobileRetentionOrder].[preferred_languages] AS MOBILERETENTIONORDER_PREFERRED_LANGUAGES,[MobileRetentionOrder].[hkid] AS MOBILERETENTIONORDER_HKID,[MobileRetentionOrder].[card_holder] AS MOBILERETENTIONORDER_CARD_HOLDER,[MobileRetentionOrder].[ac_no] AS MOBILERETENTIONORDER_AC_NO,[MobileRetentionOrder].[bill_cut_num] AS MOBILERETENTIONORDER_BILL_CUT_NUM,[MobileRetentionOrder].[premium] AS MOBILERETENTIONORDER_PREMIUM,[MobileRetentionOrder].[del_remark] AS MOBILERETENTIONORDER_DEL_REMARK,[MobileRetentionOrder].[gift_imei2] AS MOBILERETENTIONORDER_GIFT_IMEI2,[MobileRetentionOrder].[reasons] AS MOBILERETENTIONORDER_REASONS,[MobileRetentionOrder].[language] AS MOBILERETENTIONORDER_LANGUAGE,[MobileRetentionOrder].[rebate_amount] AS MOBILERETENTIONORDER_REBATE_AMOUNT,[MobileRetentionOrder].[ord_place_id_type] AS MOBILERETENTIONORDER_ORD_PLACE_ID_TYPE,[MobileRetentionOrder].[m_3rd_contact_no] AS MOBILERETENTIONORDER_M_3RD_CONTACT_NO,[MobileRetentionOrder].[staff_no] AS MOBILERETENTIONORDER_STAFF_NO,[MobileRetentionOrder].[sp_d_date] AS MOBILERETENTIONORDER_SP_D_DATE,[MobileRetentionOrder].[bundle_name] AS MOBILERETENTIONORDER_BUNDLE_NAME,[MobileRetentionOrder].[accessory_waive] AS MOBILERETENTIONORDER_ACCESSORY_WAIVE,[MobileRetentionOrder].[sim_item_code] AS MOBILERETENTIONORDER_SIM_ITEM_CODE,[MobileRetentionOrder].[cust_type] AS MOBILERETENTIONORDER_CUST_TYPE,[MobileRetentionOrder].[card_ref_no] AS MOBILERETENTIONORDER_CARD_REF_NO  FROM  [MobileRetentionOrder]  WHERE  [MobileRetentionOrder].[order_id] = \'"+x_iOrder_id.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionOrder]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrder]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = n_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read())
                    {
                        n_bFound = true;
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_IMEI"])) {n_sGift_imei = (string)_oData["MOBILERETENTIONORDER_GIFT_IMEI"];}else{n_sGift_imei=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_S_PREMIUM4"])) {n_sS_premium4 = (string)_oData["MOBILERETENTIONORDER_S_PREMIUM4"];}else{n_sS_premium4=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_EXISTING_CUSTOMER_TYPE"])) {n_sUpgrade_existing_customer_type = (string)_oData["MOBILERETENTIONORDER_UPGRADE_EXISTING_CUSTOMER_TYPE"];}else{n_sUpgrade_existing_customer_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_DESC4"])) {n_sGift_desc4 = (string)_oData["MOBILERETENTIONORDER_GIFT_DESC4"];}else{n_sGift_desc4=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACCESSORY_DESC"])) {n_sAccessory_desc = (string)_oData["MOBILERETENTIONORDER_ACCESSORY_DESC"];}else{n_sAccessory_desc=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_STAFF_NAME"])) {n_sStaff_name = (string)_oData["MOBILERETENTIONORDER_STAFF_NAME"];}else{n_sStaff_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACTION_REQUIRED"])) {n_sAction_required = (string)_oData["MOBILERETENTIONORDER_ACTION_REQUIRED"];}else{n_sAction_required=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_VAS_EFF_DATE"])) {n_dVas_eff_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_VAS_EFF_DATE"];}else{n_dVas_eff_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_BANK_CODE"])) {n_sMonthly_bank_account_bank_code = (string)_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_BANK_CODE"];}else{n_sMonthly_bank_account_bank_code=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SIM_ITEM_NUMBER"])) {n_sSim_item_number = (string)_oData["MOBILERETENTIONORDER_SIM_ITEM_NUMBER"];}else{n_sSim_item_number=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SPECIAL_HANDLING_DUMMY_CODE"])) {n_sSpecial_handling_dummy_code = (string)_oData["MOBILERETENTIONORDER_SPECIAL_HANDLING_DUMMY_CODE"];}else{n_sSpecial_handling_dummy_code=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CARD_NO"])) {n_sCard_no = (string)_oData["MOBILERETENTIONORDER_CARD_NO"];}else{n_sCard_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_CARD_EXP_YEAR"])) {n_sM_card_exp_year = (string)_oData["MOBILERETENTIONORDER_M_CARD_EXP_YEAR"];}else{n_sM_card_exp_year=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_BILL_MEDIUM_EMAIL"])) {n_sBill_medium_email = (string)_oData["MOBILERETENTIONORDER_BILL_MEDIUM_EMAIL"];}else{n_sBill_medium_email=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REMARKS2PY"])) {n_sRemarks2PY = (string)_oData["MOBILERETENTIONORDER_REMARKS2PY"];}else{n_sRemarks2PY=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_TRADE_FIELD"])) {n_sTrade_field = (string)_oData["MOBILERETENTIONORDER_TRADE_FIELD"];}else{n_sTrade_field=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORD_PLACE_TEL"])) {n_sOrd_place_tel = (string)_oData["MOBILERETENTIONORDER_ORD_PLACE_TEL"];}else{n_sOrd_place_tel=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACTION_OF_RATE_PLAN_EFFECTIVE"])) {n_sAction_of_rate_plan_effective = (string)_oData["MOBILERETENTIONORDER_ACTION_OF_RATE_PLAN_EFFECTIVE"];}else{n_sAction_of_rate_plan_effective=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_COOLING_OFFER"])) {n_sCooling_offer = (string)_oData["MOBILERETENTIONORDER_COOLING_OFFER"];}else{n_sCooling_offer=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_HANDSET_OFFER_REBATE_SCHEDULE"])) {n_sUpgrade_handset_offer_rebate_schedule = (string)_oData["MOBILERETENTIONORDER_UPGRADE_HANDSET_OFFER_REBATE_SCHEDULE"];}else{n_sUpgrade_handset_offer_rebate_schedule=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CHANGE_PAYMENT_TYPE"])) {n_sChange_payment_type = (string)_oData["MOBILERETENTIONORDER_CHANGE_PAYMENT_TYPE"];}else{n_sChange_payment_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_DATE_OF_BIRTH"])) {n_dDate_of_birth = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_DATE_OF_BIRTH"];}else{n_dDate_of_birth=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CONTACT_PERSON"])) {n_sContact_person = (string)_oData["MOBILERETENTIONORDER_CONTACT_PERSON"];}else{n_sContact_person=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXTRA_D_CHARGE"])) {n_sExtra_d_charge = (string)_oData["MOBILERETENTIONORDER_EXTRA_D_CHARGE"];}else{n_sExtra_d_charge=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_TL_NAME"])) {n_sTl_name = (string)_oData["MOBILERETENTIONORDER_TL_NAME"];}else{n_sTl_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_FAST_START"])) {n_bFast_start = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_FAST_START"];}else{n_bFast_start=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SP_REF_NO"])) {n_sSp_ref_no = (string)_oData["MOBILERETENTIONORDER_SP_REF_NO"];}else{n_sSp_ref_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EDATE"])) {n_dEdate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_EDATE"];}else{n_dEdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXIST_CUST_PLAN"])) {n_sExist_cust_plan = (string)_oData["MOBILERETENTIONORDER_EXIST_CUST_PLAN"];}else{n_sExist_cust_plan=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORD_PLACE_REL"])) {n_sOrd_place_rel = (string)_oData["MOBILERETENTIONORDER_ORD_PLACE_REL"];}else{n_sOrd_place_rel=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MRT_NO"])) {n_iMrt_no = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDER_MRT_NO"];}else{n_iMrt_no=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_IMEI_NO"])) {n_sImei_no = (string)_oData["MOBILERETENTIONORDER_IMEI_NO"];}else{n_sImei_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXISTING_SMART_PHONE_MODEL"])) {n_sExisting_smart_phone_model = (string)_oData["MOBILERETENTIONORDER_EXISTING_SMART_PHONE_MODEL"];}else{n_sExisting_smart_phone_model=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_BANK_CODE"])) {n_sBank_code = (string)_oData["MOBILERETENTIONORDER_BANK_CODE"];}else{n_sBank_code=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_POS_REF_NO"])) {n_sPos_ref_no = (string)_oData["MOBILERETENTIONORDER_POS_REF_NO"];}else{n_sPos_ref_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_BILL_CUT_DATE"])) {n_dBill_cut_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_BILL_CUT_DATE"];}else{n_dBill_cut_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_IMEI3"])) {n_sGift_imei3 = (string)_oData["MOBILERETENTIONORDER_GIFT_IMEI3"];}else{n_sGift_imei3=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXIST_PLAN"])) {n_sExist_plan = (string)_oData["MOBILERETENTIONORDER_EXIST_PLAN"];}else{n_sExist_plan=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_WAIVE"])) {n_bWaive = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_WAIVE"];}else{n_bWaive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_PROGRAM"])) {n_sProgram = (string)_oData["MOBILERETENTIONORDER_PROGRAM"];}else{n_sProgram=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_FIRST_MONTH_FEE"])) {n_sFirst_month_fee = (string)_oData["MOBILERETENTIONORDER_FIRST_MONTH_FEE"];}else{n_sFirst_month_fee=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_R_OFFER"])) {n_sR_offer = (string)_oData["MOBILERETENTIONORDER_R_OFFER"];}else{n_sR_offer=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CID"])) {n_sCid = (string)_oData["MOBILERETENTIONORDER_CID"];}else{n_sCid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_DID"])) {n_sDid = (string)_oData["MOBILERETENTIONORDER_DID"];}else{n_sDid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_FTG_TENURE"])) {n_sFtg_tenure = (string)_oData["MOBILERETENTIONORDER_FTG_TENURE"];}else{n_sFtg_tenure=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CON_PER"])) {n_sCon_per = (string)_oData["MOBILERETENTIONORDER_CON_PER"];}else{n_sCon_per=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_CODE4"])) {n_sGift_code4 = (string)_oData["MOBILERETENTIONORDER_GIFT_CODE4"];}else{n_sGift_code4=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EASYWATCH_TYPE"])) {n_sEasywatch_type = (string)_oData["MOBILERETENTIONORDER_EASYWATCH_TYPE"];}else{n_sEasywatch_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SMS_MRT"])) {n_sSms_mrt = (string)_oData["MOBILERETENTIONORDER_SMS_MRT"];}else{n_sSms_mrt=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_PAYMENT_METHOD"])) {n_sMonthly_payment_method = (string)_oData["MOBILERETENTIONORDER_MONTHLY_PAYMENT_METHOD"];}else{n_sMonthly_payment_method=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REMARKS2EDF"])) {n_sRemarks2EDF = (string)_oData["MOBILERETENTIONORDER_REMARKS2EDF"];}else{n_sRemarks2EDF=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_DESC3"])) {n_sGift_desc3 = (string)_oData["MOBILERETENTIONORDER_GIFT_DESC3"];}else{n_sGift_desc3=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_IMEI4"])) {n_sGift_imei4 = (string)_oData["MOBILERETENTIONORDER_GIFT_IMEI4"];}else{n_sGift_imei4=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HKID2"])) {n_sMonthly_bank_account_hkid2 = (string)_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HKID2"];}else{n_sMonthly_bank_account_hkid2=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_D_DATE"])) {n_dD_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_D_DATE"];}else{n_dD_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_DESC"])) {n_sGift_desc = (string)_oData["MOBILERETENTIONORDER_GIFT_DESC"];}else{n_sGift_desc=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_POOL"])) {n_sPool = (string)_oData["MOBILERETENTIONORDER_POOL"];}else{n_sPool=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CN_MRT_NO"])) {n_lCn_mrt_no = (global::System.Nullable<long>)_oData["MOBILERETENTIONORDER_CN_MRT_NO"];}else{n_lCn_mrt_no=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACCESSORY_IMEI"])) {n_sAccessory_imei = (string)_oData["MOBILERETENTIONORDER_ACCESSORY_IMEI"];}else{n_sAccessory_imei=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_THIRD_PARTY_CREDIT_CARD"])) {n_sThird_party_credit_card = (string)_oData["MOBILERETENTIONORDER_THIRD_PARTY_CREDIT_CARD"];}else{n_sThird_party_credit_card=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SPECIAL_APPROVAL"])) {n_sSpecial_approval = (string)_oData["MOBILERETENTIONORDER_SPECIAL_APPROVAL"];}else{n_sSpecial_approval=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_EXISTING_CONTRACT_EDATE"])) {n_dUpgrade_existing_contract_edate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_UPGRADE_EXISTING_CONTRACT_EDATE"];}else{n_dUpgrade_existing_contract_edate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACCESSORY_CODE"])) {n_sAccessory_code = (string)_oData["MOBILERETENTIONORDER_ACCESSORY_CODE"];}else{n_sAccessory_code=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_S_PREMIUM"])) {n_sS_premium = (string)_oData["MOBILERETENTIONORDER_S_PREMIUM"];}else{n_sS_premium=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REF_STAFF_NO"])) {n_sRef_staff_no = (string)_oData["MOBILERETENTIONORDER_REF_STAFF_NO"];}else{n_sRef_staff_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACCESSORY_PRICE"])) {n_sAccessory_price = (string)_oData["MOBILERETENTIONORDER_ACCESSORY_PRICE"];}else{n_sAccessory_price=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_CARD_EXP_MONTH"])) {n_sM_card_exp_month = (string)_oData["MOBILERETENTIONORDER_M_CARD_EXP_MONTH"];}else{n_sM_card_exp_month=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_INSTALLMENT_PERIOD"])) {n_sInstallment_period = (string)_oData["MOBILERETENTIONORDER_INSTALLMENT_PERIOD"];}else{n_sInstallment_period=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_CARD_TYPE"])) {n_sM_card_type = (string)_oData["MOBILERETENTIONORDER_M_CARD_TYPE"];}else{n_sM_card_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EASYWATCH_ORD_ID"])) {n_sEasywatch_ord_id = (string)_oData["MOBILERETENTIONORDER_EASYWATCH_ORD_ID"];}else{n_sEasywatch_ord_id=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_NORMAL_REBATE"])) {n_bNormal_rebate = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_NORMAL_REBATE"];}else{n_bNormal_rebate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_REBATE_AMOUNT"])) {n_sM_rebate_amount = (string)_oData["MOBILERETENTIONORDER_M_REBATE_AMOUNT"];}else{n_sM_rebate_amount=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_CARD_HOLDER2"])) {n_sM_card_holder2 = (string)_oData["MOBILERETENTIONORDER_M_CARD_HOLDER2"];}else{n_sM_card_holder2=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HOLDER"])) {n_sMonthly_bank_account_holder = (string)_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HOLDER"];}else{n_sMonthly_bank_account_holder=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_S_PREMIUM1"])) {n_sS_premium1 = (string)_oData["MOBILERETENTIONORDER_S_PREMIUM1"];}else{n_sS_premium1=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CARD_EXP_MONTH"])) {n_sCard_exp_month = (string)_oData["MOBILERETENTIONORDER_CARD_EXP_MONTH"];}else{n_sCard_exp_month=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_OB_PROGRAM_ID"])) {n_sOb_program_id = (string)_oData["MOBILERETENTIONORDER_OB_PROGRAM_ID"];}else{n_sOb_program_id=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SKU"])) {n_sSku = (string)_oData["MOBILERETENTIONORDER_SKU"];}else{n_sSku=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SALESMANCODE"])) {n_sSalesmancode = (string)_oData["MOBILERETENTIONORDER_SALESMANCODE"];}else{n_sSalesmancode=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GO_WIRELESS_PACKAGE_CODE"])) {n_sGo_wireless_package_code = (string)_oData["MOBILERETENTIONORDER_GO_WIRELESS_PACKAGE_CODE"];}else{n_sGo_wireless_package_code=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_LOB"])) {n_sLob = (string)_oData["MOBILERETENTIONORDER_LOB"];}else{n_sLob=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REF_SALESMANCODE"])) {n_sRef_salesmancode = (string)_oData["MOBILERETENTIONORDER_REF_SALESMANCODE"];}else{n_sRef_salesmancode=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_THIRD_PARTY_HKID"])) {n_sThird_party_hkid = (string)_oData["MOBILERETENTIONORDER_THIRD_PARTY_HKID"];}else{n_sThird_party_hkid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_EXISTING_PCCW_CUSTOMER"])) {n_sUpgrade_existing_pccw_customer = (string)_oData["MOBILERETENTIONORDER_UPGRADE_EXISTING_PCCW_CUSTOMER"];}else{n_sUpgrade_existing_pccw_customer=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_D_ADDRESS"])) {n_sD_address = (string)_oData["MOBILERETENTIONORDER_D_ADDRESS"];}else{n_sD_address=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_REGISTERED_MOBILE_NO"])) {n_sUpgrade_registered_mobile_no = (string)_oData["MOBILERETENTIONORDER_UPGRADE_REGISTERED_MOBILE_NO"];}else{n_sUpgrade_registered_mobile_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_CODE3"])) {n_sGift_code3 = (string)_oData["MOBILERETENTIONORDER_GIFT_CODE3"];}else{n_sGift_code3=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_NORMAL_REBATE_TYPE"])) {n_sNormal_rebate_type = (string)_oData["MOBILERETENTIONORDER_NORMAL_REBATE_TYPE"];}else{n_sNormal_rebate_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_DESC2"])) {n_sGift_desc2 = (string)_oData["MOBILERETENTIONORDER_GIFT_DESC2"];}else{n_sGift_desc2=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_BRANCH_CODE"])) {n_sMonthly_bank_account_branch_code = (string)_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_BRANCH_CODE"];}else{n_sMonthly_bank_account_branch_code=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REMARKS"])) {n_sRemarks = (string)_oData["MOBILERETENTIONORDER_REMARKS"];}else{n_sRemarks=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACCEPT"])) {n_sAccept = (string)_oData["MOBILERETENTIONORDER_ACCEPT"];}else{n_sAccept=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_DELIVERY_EXCHANGE"])) {n_sDelivery_exchange = (string)_oData["MOBILERETENTIONORDER_DELIVERY_EXCHANGE"];}else{n_sDelivery_exchange=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_CODE2"])) {n_sGift_code2 = (string)_oData["MOBILERETENTIONORDER_GIFT_CODE2"];}else{n_sGift_code2=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_PREPAYMENT_WAIVE"])) {n_bPrepayment_waive = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_PREPAYMENT_WAIVE"];}else{n_bPrepayment_waive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXISTING_SMART_PHONE_IMEI"])) {n_sExisting_smart_phone_imei = (string)_oData["MOBILERETENTIONORDER_EXISTING_SMART_PHONE_IMEI"];}else{n_sExisting_smart_phone_imei=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CUST_NAME"])) {n_sCust_name = (string)_oData["MOBILERETENTIONORDER_CUST_NAME"];}else{n_sCust_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_SPONSORSHIPS_AMOUNT"])) {n_sUpgrade_sponsorships_amount = (string)_oData["MOBILERETENTIONORDER_UPGRADE_SPONSORSHIPS_AMOUNT"];}else{n_sUpgrade_sponsorships_amount=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_BILL_MEDIUM_WAIVE"])) {n_bBill_medium_waive = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_BILL_MEDIUM_WAIVE"];}else{n_bBill_medium_waive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_DELIVERY_EXCHANGE_LOCATION"])) {n_sDelivery_exchange_location = (string)_oData["MOBILERETENTIONORDER_DELIVERY_EXCHANGE_LOCATION"];}else{n_sDelivery_exchange_location=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_HS_OFFER_TYPE_ID"])) {n_iHs_offer_type_id = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDER_HS_OFFER_TYPE_ID"];}else{n_iHs_offer_type_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXTRA_REBATE_AMOUNT"])) {n_sExtra_rebate_amount = (string)_oData["MOBILERETENTIONORDER_EXTRA_REBATE_AMOUNT"];}else{n_sExtra_rebate_amount=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REBATE"])) {n_sRebate = (string)_oData["MOBILERETENTIONORDER_REBATE"];}else{n_sRebate=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_TYPE"])) {n_sUpgrade_type = (string)_oData["MOBILERETENTIONORDER_UPGRADE_TYPE"];}else{n_sUpgrade_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GO_WIRELESS"])) {n_sGo_wireless = (string)_oData["MOBILERETENTIONORDER_GO_WIRELESS"];}else{n_sGo_wireless=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXTRA_REBATE"])) {n_sExtra_rebate = (string)_oData["MOBILERETENTIONORDER_EXTRA_REBATE"];}else{n_sExtra_rebate=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_PLAN_EFF"])) {n_sPlan_eff = (string)_oData["MOBILERETENTIONORDER_PLAN_EFF"];}else{n_sPlan_eff=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CARD_EXP_YEAR"])) {n_sCard_exp_year = (string)_oData["MOBILERETENTIONORDER_CARD_EXP_YEAR"];}else{n_sCard_exp_year=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_EXISTING_CONTRACT_SDATE"])) {n_dUpgrade_existing_contract_sdate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_UPGRADE_EXISTING_CONTRACT_SDATE"];}else{n_dUpgrade_existing_contract_sdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORD_PLACE_HKID"])) {n_sOrd_place_hkid = (string)_oData["MOBILERETENTIONORDER_ORD_PLACE_HKID"];}else{n_sOrd_place_hkid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REGISTER_ADDRESS"])) {n_sRegister_address = (string)_oData["MOBILERETENTIONORDER_REGISTER_ADDRESS"];}else{n_sRegister_address=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GENDER"])) {n_sGender = (string)_oData["MOBILERETENTIONORDER_GENDER"];}else{n_sGender=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_LOB_AC"])) {n_sLob_ac = (string)_oData["MOBILERETENTIONORDER_LOB_AC"];}else{n_sLob_ac=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SIM_MRT_NO"])) {n_iSim_mrt_no = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDER_SIM_MRT_NO"];}else{n_iSim_mrt_no=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REDEMPTION_NOTICE_OPTION"])) {n_sRedemption_notice_option = (string)_oData["MOBILERETENTIONORDER_REDEMPTION_NOTICE_OPTION"];}else{n_sRedemption_notice_option=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_DELIVERY_COLLECTION_TYPE"])) {n_sDelivery_collection_type = (string)_oData["MOBILERETENTIONORDER_DELIVERY_COLLECTION_TYPE"];}else{n_sDelivery_collection_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACTION_DATE"])) {n_dAction_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_ACTION_DATE"];}else{n_dAction_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_THIRD_PARTY_ID_TYPE"])) {n_sThird_party_id_type = (string)_oData["MOBILERETENTIONORDER_THIRD_PARTY_ID_TYPE"];}else{n_sThird_party_id_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORG_FTG"])) {n_sOrg_ftg = (string)_oData["MOBILERETENTIONORDER_ORG_FTG"];}else{n_sOrg_ftg=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_SERVICE_TENURE"])) {n_sUpgrade_service_tenure = (string)_oData["MOBILERETENTIONORDER_UPGRADE_SERVICE_TENURE"];}else{n_sUpgrade_service_tenure=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_PAYMENT_TYPE"])) {n_sMonthly_payment_type = (string)_oData["MOBILERETENTIONORDER_MONTHLY_PAYMENT_TYPE"];}else{n_sMonthly_payment_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CONTACT_NO"])) {n_sContact_no = (string)_oData["MOBILERETENTIONORDER_CONTACT_NO"];}else{n_sContact_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORG_MRT"])) {n_iOrg_mrt = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDER_ORG_MRT"];}else{n_iOrg_mrt=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SIM_ITEM_NAME"])) {n_sSim_item_name = (string)_oData["MOBILERETENTIONORDER_SIM_ITEM_NAME"];}else{n_sSim_item_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_PAY_METHOD"])) {n_sPay_method = (string)_oData["MOBILERETENTIONORDER_PAY_METHOD"];}else{n_sPay_method=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_HS_MODEL"])) {n_sHs_model = (string)_oData["MOBILERETENTIONORDER_HS_MODEL"];}else{n_sHs_model=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_CODE"])) {n_sGift_code = (string)_oData["MOBILERETENTIONORDER_GIFT_CODE"];}else{n_sGift_code=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HKID"])) {n_sMonthly_bank_account_hkid = (string)_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HKID"];}else{n_sMonthly_bank_account_hkid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXTRA_OFFER"])) {n_sExtra_offer = (string)_oData["MOBILERETENTIONORDER_EXTRA_OFFER"];}else{n_sExtra_offer=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_NO"])) {n_sMonthly_bank_account_no = (string)_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_NO"];}else{n_sMonthly_bank_account_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_FIRST_MONTH_LICENSE_FEE"])) {n_sFirst_month_license_fee = (string)_oData["MOBILERETENTIONORDER_FIRST_MONTH_LICENSE_FEE"];}else{n_sFirst_month_license_fee=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_RETRIEVE_CNT"])) {n_iRetrieve_cnt = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDER_RETRIEVE_CNT"];}else{n_iRetrieve_cnt=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_DDATE"])) {n_dDdate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_DDATE"];}else{n_dDdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_S_PREMIUM2"])) {n_sS_premium2 = (string)_oData["MOBILERETENTIONORDER_S_PREMIUM2"];}else{n_sS_premium2=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_ID_TYPE"])) {n_sMonthly_bank_account_id_type = (string)_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_ID_TYPE"];}else{n_sMonthly_bank_account_id_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CARD_TYPE"])) {n_sCard_type = (string)_oData["MOBILERETENTIONORDER_CARD_TYPE"];}else{n_sCard_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_NEXT_BILL"])) {n_bNext_bill = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_NEXT_BILL"];}else{n_bNext_bill=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_PCD_PAID_GO_WIRELESS"])) {n_bPcd_paid_go_wireless = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_PCD_PAID_GO_WIRELESS"];}else{n_bPcd_paid_go_wireless=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_REBATE_CALCULATION"])) {n_sUpgrade_rebate_calculation = (string)_oData["MOBILERETENTIONORDER_UPGRADE_REBATE_CALCULATION"];}else{n_sUpgrade_rebate_calculation=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXT_PLACE_TEL"])) {n_sExt_place_tel = (string)_oData["MOBILERETENTIONORDER_EXT_PLACE_TEL"];}else{n_sExt_place_tel=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_3RD_HKID"])) {n_sM_3rd_hkid = (string)_oData["MOBILERETENTIONORDER_M_3RD_HKID"];}else{n_sM_3rd_hkid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_RETENTION_TYPE"])) {n_sRetention_type = (string)_oData["MOBILERETENTIONORDER_RETENTION_TYPE"];}else{n_sRetention_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_COOLING_DATE"])) {n_dCooling_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_COOLING_DATE"];}else{n_dCooling_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_AIG_GIFT"])) {n_sAig_gift = (string)_oData["MOBILERETENTIONORDER_AIG_GIFT"];}else{n_sAig_gift=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CUST_STAFF_NO"])) {n_sCust_staff_no = (string)_oData["MOBILERETENTIONORDER_CUST_STAFF_NO"];}else{n_sCust_staff_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORDER_ID"])) {n_iOrder_id = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDER_ORDER_ID"];}else{n_iOrder_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_FAMILY_NAME"])) {n_sFamily_name = (string)_oData["MOBILERETENTIONORDER_FAMILY_NAME"];}else{n_sFamily_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CDATE"])) {n_dCdate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_CDATE"];}else{n_dCdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_STATUS_BY_CS_ADMIN"])) {n_sStatus_by_cs_admin = (string)_oData["MOBILERETENTIONORDER_STATUS_BY_CS_ADMIN"];}else{n_sStatus_by_cs_admin=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIVEN_NAME"])) {n_sGiven_name = (string)_oData["MOBILERETENTIONORDER_GIVEN_NAME"];}else{n_sGiven_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_VIP_CASE"])) {n_sVip_case = (string)_oData["MOBILERETENTIONORDER_VIP_CASE"];}else{n_sVip_case=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORG_FEE"])) {n_sOrg_fee = (string)_oData["MOBILERETENTIONORDER_ORG_FEE"];}else{n_sOrg_fee=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_S_PREMIUM3"])) {n_sS_premium3 = (string)_oData["MOBILERETENTIONORDER_S_PREMIUM3"];}else{n_sS_premium3=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_LOG_DATE"])) {n_dLog_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_LOG_DATE"];}else{n_dLog_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXTN"])) {n_sExtn = (string)_oData["MOBILERETENTIONORDER_EXTN"];}else{n_sExtn=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_D_TIME"])) {n_sD_time = (string)_oData["MOBILERETENTIONORDER_D_TIME"];}else{n_sD_time=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_BANK_NAME"])) {n_sBank_name = (string)_oData["MOBILERETENTIONORDER_BANK_NAME"];}else{n_sBank_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_DELIVERY_EXCHANGE_OPTION"])) {n_sDelivery_exchange_option = (string)_oData["MOBILERETENTIONORDER_DELIVERY_EXCHANGE_OPTION"];}else{n_sDelivery_exchange_option=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_SERVICE_ACCOUNT_NO"])) {n_sUpgrade_service_account_no = (string)_oData["MOBILERETENTIONORDER_UPGRADE_SERVICE_ACCOUNT_NO"];}else{n_sUpgrade_service_account_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_OLD_ORD_ID"])) {n_iOld_ord_id = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDER_OLD_ORD_ID"];}else{n_iOld_ord_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_CARD_NO"])) {n_sM_card_no = (string)_oData["MOBILERETENTIONORDER_M_CARD_NO"];}else{n_sM_card_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXISTING_CONTRACT_END_DATE"])) {n_sExisting_contract_end_date = (string)_oData["MOBILERETENTIONORDER_EXISTING_CONTRACT_END_DATE"];}else{n_sExisting_contract_end_date=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CON_EFF_DATE"])) {n_dCon_eff_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_CON_EFF_DATE"];}else{n_dCon_eff_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_3RD_HKID2"])) {n_sM_3rd_hkid2 = (string)_oData["MOBILERETENTIONORDER_M_3RD_HKID2"];}else{n_sM_3rd_hkid2=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_AMOUNT"])) {n_sAmount = (string)_oData["MOBILERETENTIONORDER_AMOUNT"];}else{n_sAmount=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_3RD_ID_TYPE"])) {n_sM_3rd_id_type = (string)_oData["MOBILERETENTIONORDER_M_3RD_ID_TYPE"];}else{n_sM_3rd_id_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ID_TYPE"])) {n_sId_type = (string)_oData["MOBILERETENTIONORDER_ID_TYPE"];}else{n_sId_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_RATE_PLAN"])) {n_sRate_plan = (string)_oData["MOBILERETENTIONORDER_RATE_PLAN"];}else{n_sRate_plan=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CHANNEL"])) {n_sChannel = (string)_oData["MOBILERETENTIONORDER_CHANNEL"];}else{n_sChannel=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACTION_EFF_DATE"])) {n_dAction_eff_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_ACTION_EFF_DATE"];}else{n_dAction_eff_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ISSUE_TYPE"])) {n_sIssue_type = (string)_oData["MOBILERETENTIONORDER_ISSUE_TYPE"];}else{n_sIssue_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_FREE_MON"])) {n_sFree_mon = (string)_oData["MOBILERETENTIONORDER_FREE_MON"];}else{n_sFree_mon=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_PLAN_EFF_DATE"])) {n_dPlan_eff_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_PLAN_EFF_DATE"];}else{n_dPlan_eff_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_TEAMCODE"])) {n_sTeamcode = (string)_oData["MOBILERETENTIONORDER_TEAMCODE"];}else{n_sTeamcode=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_BILL_MEDIUM"])) {n_sBill_medium = (string)_oData["MOBILERETENTIONORDER_BILL_MEDIUM"];}else{n_sBill_medium=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EDF_NO"])) {n_sEdf_no = (string)_oData["MOBILERETENTIONORDER_EDF_NO"];}else{n_sEdf_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORD_PLACE_BY"])) {n_sOrd_place_by = (string)_oData["MOBILERETENTIONORDER_ORD_PLACE_BY"];}else{n_sOrd_place_by=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CANCEL_RENEW"])) {n_sCancel_renew = (string)_oData["MOBILERETENTIONORDER_CANCEL_RENEW"];}else{n_sCancel_renew=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_PREFERRED_LANGUAGES"])) {n_sPreferred_languages = (string)_oData["MOBILERETENTIONORDER_PREFERRED_LANGUAGES"];}else{n_sPreferred_languages=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_HKID"])) {n_sHkid = (string)_oData["MOBILERETENTIONORDER_HKID"];}else{n_sHkid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CARD_HOLDER"])) {n_sCard_holder = (string)_oData["MOBILERETENTIONORDER_CARD_HOLDER"];}else{n_sCard_holder=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_AC_NO"])) {n_sAc_no = (string)_oData["MOBILERETENTIONORDER_AC_NO"];}else{n_sAc_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_BILL_CUT_NUM"])) {n_iBill_cut_num = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDER_BILL_CUT_NUM"];}else{n_iBill_cut_num=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_PREMIUM"])) {n_sPremium = (string)_oData["MOBILERETENTIONORDER_PREMIUM"];}else{n_sPremium=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_DEL_REMARK"])) {n_sDel_remark = (string)_oData["MOBILERETENTIONORDER_DEL_REMARK"];}else{n_sDel_remark=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_IMEI2"])) {n_sGift_imei2 = (string)_oData["MOBILERETENTIONORDER_GIFT_IMEI2"];}else{n_sGift_imei2=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REASONS"])) {n_sReasons = (string)_oData["MOBILERETENTIONORDER_REASONS"];}else{n_sReasons=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_LANGUAGE"])) {n_sLanguage = (string)_oData["MOBILERETENTIONORDER_LANGUAGE"];}else{n_sLanguage=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REBATE_AMOUNT"])) {n_sRebate_amount = (string)_oData["MOBILERETENTIONORDER_REBATE_AMOUNT"];}else{n_sRebate_amount=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORD_PLACE_ID_TYPE"])) {n_sOrd_place_id_type = (string)_oData["MOBILERETENTIONORDER_ORD_PLACE_ID_TYPE"];}else{n_sOrd_place_id_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_3RD_CONTACT_NO"])) {n_sM_3rd_contact_no = (string)_oData["MOBILERETENTIONORDER_M_3RD_CONTACT_NO"];}else{n_sM_3rd_contact_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_STAFF_NO"])) {n_sStaff_no = (string)_oData["MOBILERETENTIONORDER_STAFF_NO"];}else{n_sStaff_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SP_D_DATE"])) {n_dSp_d_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_SP_D_DATE"];}else{n_dSp_d_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_BUNDLE_NAME"])) {n_sBundle_name = (string)_oData["MOBILERETENTIONORDER_BUNDLE_NAME"];}else{n_sBundle_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACCESSORY_WAIVE"])) {n_bAccessory_waive = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_ACCESSORY_WAIVE"];}else{n_bAccessory_waive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SIM_ITEM_CODE"])) {n_sSim_item_code = (string)_oData["MOBILERETENTIONORDER_SIM_ITEM_CODE"];}else{n_sSim_item_code=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CUST_TYPE"])) {n_sCust_type = (string)_oData["MOBILERETENTIONORDER_CUST_TYPE"];}else{n_sCust_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CARD_REF_NO"])) {n_sCard_ref_no = (string)_oData["MOBILERETENTIONORDER_CARD_REF_NO"];}else{n_sCard_ref_no=global::System.String.Empty;}
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
                return true;
            }
        }
        #endregion
        
        #region Init
        
        /// <summary>
        /// Summary description for Init Class
        /// </summary>
        
        public void Init()
        {
            
        }
        #endregion
        
        #region Vaild
        
        /// <summary>
        /// Summary description for Vaild Checking
        /// </summary>
        
        public bool Vaild(bool x_bInsert)
        {
            if (n_sGift_imei==null && !(n_oTableSet.Fields(Para.gift_imei).IsNullable)) return false;
            if (n_sS_premium4==null && !(n_oTableSet.Fields(Para.s_premium4).IsNullable)) return false;
            if (n_sUpgrade_existing_customer_type==null && !(n_oTableSet.Fields(Para.upgrade_existing_customer_type).IsNullable)) return false;
            if (n_sGift_desc4==null && !(n_oTableSet.Fields(Para.gift_desc4).IsNullable)) return false;
            if (n_sAccessory_desc==null && !(n_oTableSet.Fields(Para.accessory_desc).IsNullable)) return false;
            if (n_sStaff_name==null && !(n_oTableSet.Fields(Para.staff_name).IsNullable)) return false;
            if (n_sAction_required==null && !(n_oTableSet.Fields(Para.action_required).IsNullable)) return false;
            if (n_dVas_eff_date==null && !(n_oTableSet.Fields(Para.vas_eff_date).IsNullable)) return false;
            if (n_sMonthly_bank_account_bank_code==null && !(n_oTableSet.Fields(Para.monthly_bank_account_bank_code).IsNullable)) return false;
            if (n_sSim_item_number==null && !(n_oTableSet.Fields(Para.sim_item_number).IsNullable)) return false;
            if (n_sSpecial_handling_dummy_code==null && !(n_oTableSet.Fields(Para.special_handling_dummy_code).IsNullable)) return false;
            if (n_sCard_no==null && !(n_oTableSet.Fields(Para.card_no).IsNullable)) return false;
            if (n_sM_card_exp_year==null && !(n_oTableSet.Fields(Para.m_card_exp_year).IsNullable)) return false;
            if (n_sBill_medium_email==null && !(n_oTableSet.Fields(Para.bill_medium_email).IsNullable)) return false;
            if (n_sRemarks2PY==null && !(n_oTableSet.Fields(Para.remarks2PY).IsNullable)) return false;
            if (n_sTrade_field==null && !(n_oTableSet.Fields(Para.trade_field).IsNullable)) return false;
            if (n_sOrd_place_tel==null && !(n_oTableSet.Fields(Para.ord_place_tel).IsNullable)) return false;
            if (n_sAction_of_rate_plan_effective==null && !(n_oTableSet.Fields(Para.action_of_rate_plan_effective).IsNullable)) return false;
            if (n_sCooling_offer==null && !(n_oTableSet.Fields(Para.cooling_offer).IsNullable)) return false;
            if (n_sUpgrade_handset_offer_rebate_schedule==null && !(n_oTableSet.Fields(Para.upgrade_handset_offer_rebate_schedule).IsNullable)) return false;
            if (n_sChange_payment_type==null && !(n_oTableSet.Fields(Para.change_payment_type).IsNullable)) return false;
            if (n_dDate_of_birth==null && !(n_oTableSet.Fields(Para.date_of_birth).IsNullable)) return false;
            if (n_sContact_person==null && !(n_oTableSet.Fields(Para.contact_person).IsNullable)) return false;
            if (n_sExtra_d_charge==null && !(n_oTableSet.Fields(Para.extra_d_charge).IsNullable)) return false;
            if (n_sTl_name==null && !(n_oTableSet.Fields(Para.tl_name).IsNullable)) return false;
            if (n_bFast_start==null && !(n_oTableSet.Fields(Para.fast_start).IsNullable)) return false;
            if (n_sSp_ref_no==null && !(n_oTableSet.Fields(Para.sp_ref_no).IsNullable)) return false;
            if (n_dEdate==null && !(n_oTableSet.Fields(Para.edate).IsNullable)) return false;
            if (n_sExist_cust_plan==null && !(n_oTableSet.Fields(Para.exist_cust_plan).IsNullable)) return false;
            if (n_sOrd_place_rel==null && !(n_oTableSet.Fields(Para.ord_place_rel).IsNullable)) return false;
            if (n_iMrt_no==null && !(n_oTableSet.Fields(Para.mrt_no).IsNullable)) return false;
            if (n_sImei_no==null && !(n_oTableSet.Fields(Para.imei_no).IsNullable)) return false;
            if (n_sExisting_smart_phone_model==null && !(n_oTableSet.Fields(Para.existing_smart_phone_model).IsNullable)) return false;
            if (n_sBank_code==null && !(n_oTableSet.Fields(Para.bank_code).IsNullable)) return false;
            if (n_sPos_ref_no==null && !(n_oTableSet.Fields(Para.pos_ref_no).IsNullable)) return false;
            if (n_dBill_cut_date==null && !(n_oTableSet.Fields(Para.bill_cut_date).IsNullable)) return false;
            if (n_sGift_imei3==null && !(n_oTableSet.Fields(Para.gift_imei3).IsNullable)) return false;
            if (n_sExist_plan==null && !(n_oTableSet.Fields(Para.exist_plan).IsNullable)) return false;
            if (n_bWaive==null && !(n_oTableSet.Fields(Para.waive).IsNullable)) return false;
            if (n_sProgram==null && !(n_oTableSet.Fields(Para.program).IsNullable)) return false;
            if (n_sFirst_month_fee==null && !(n_oTableSet.Fields(Para.first_month_fee).IsNullable)) return false;
            if (n_sR_offer==null && !(n_oTableSet.Fields(Para.r_offer).IsNullable)) return false;
            if (n_sCid==null && !(n_oTableSet.Fields(Para.cid).IsNullable)) return false;
            if (n_sDid==null && !(n_oTableSet.Fields(Para.did).IsNullable)) return false;
            if (n_sFtg_tenure==null && !(n_oTableSet.Fields(Para.ftg_tenure).IsNullable)) return false;
            if (n_sCon_per==null && !(n_oTableSet.Fields(Para.con_per).IsNullable)) return false;
            if (n_sGift_code4==null && !(n_oTableSet.Fields(Para.gift_code4).IsNullable)) return false;
            if (n_sEasywatch_type==null && !(n_oTableSet.Fields(Para.easywatch_type).IsNullable)) return false;
            if (n_sSms_mrt==null && !(n_oTableSet.Fields(Para.sms_mrt).IsNullable)) return false;
            if (n_sMonthly_payment_method==null && !(n_oTableSet.Fields(Para.monthly_payment_method).IsNullable)) return false;
            if (n_sRemarks2EDF==null && !(n_oTableSet.Fields(Para.remarks2EDF).IsNullable)) return false;
            if (n_sGift_desc3==null && !(n_oTableSet.Fields(Para.gift_desc3).IsNullable)) return false;
            if (n_sGift_imei4==null && !(n_oTableSet.Fields(Para.gift_imei4).IsNullable)) return false;
            if (n_sMonthly_bank_account_hkid2==null && !(n_oTableSet.Fields(Para.monthly_bank_account_hkid2).IsNullable)) return false;
            if (n_dD_date==null && !(n_oTableSet.Fields(Para.d_date).IsNullable)) return false;
            if (n_sGift_desc==null && !(n_oTableSet.Fields(Para.gift_desc).IsNullable)) return false;
            if (n_sPool==null && !(n_oTableSet.Fields(Para.pool).IsNullable)) return false;
            if (n_lCn_mrt_no==null && !(n_oTableSet.Fields(Para.cn_mrt_no).IsNullable)) return false;
            if (n_sAccessory_imei==null && !(n_oTableSet.Fields(Para.accessory_imei).IsNullable)) return false;
            if (n_sThird_party_credit_card==null && !(n_oTableSet.Fields(Para.third_party_credit_card).IsNullable)) return false;
            if (n_sSpecial_approval==null && !(n_oTableSet.Fields(Para.special_approval).IsNullable)) return false;
            if (n_dUpgrade_existing_contract_edate==null && !(n_oTableSet.Fields(Para.upgrade_existing_contract_edate).IsNullable)) return false;
            if (n_sAccessory_code==null && !(n_oTableSet.Fields(Para.accessory_code).IsNullable)) return false;
            if (n_sS_premium==null && !(n_oTableSet.Fields(Para.s_premium).IsNullable)) return false;
            if (n_sRef_staff_no==null && !(n_oTableSet.Fields(Para.ref_staff_no).IsNullable)) return false;
            if (n_sAccessory_price==null && !(n_oTableSet.Fields(Para.accessory_price).IsNullable)) return false;
            if (n_sM_card_exp_month==null && !(n_oTableSet.Fields(Para.m_card_exp_month).IsNullable)) return false;
            if (n_sInstallment_period==null && !(n_oTableSet.Fields(Para.installment_period).IsNullable)) return false;
            if (n_sM_card_type==null && !(n_oTableSet.Fields(Para.m_card_type).IsNullable)) return false;
            if (n_sEasywatch_ord_id==null && !(n_oTableSet.Fields(Para.easywatch_ord_id).IsNullable)) return false;
            if (n_bNormal_rebate==null && !(n_oTableSet.Fields(Para.normal_rebate).IsNullable)) return false;
            if (n_sM_rebate_amount==null && !(n_oTableSet.Fields(Para.m_rebate_amount).IsNullable)) return false;
            if (n_sM_card_holder2==null && !(n_oTableSet.Fields(Para.m_card_holder2).IsNullable)) return false;
            if (n_sMonthly_bank_account_holder==null && !(n_oTableSet.Fields(Para.monthly_bank_account_holder).IsNullable)) return false;
            if (n_bActive==null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_sS_premium1==null && !(n_oTableSet.Fields(Para.s_premium1).IsNullable)) return false;
            if (n_sCard_exp_month==null && !(n_oTableSet.Fields(Para.card_exp_month).IsNullable)) return false;
            if (n_sOb_program_id==null && !(n_oTableSet.Fields(Para.ob_program_id).IsNullable)) return false;
            if (n_sSku==null && !(n_oTableSet.Fields(Para.sku).IsNullable)) return false;
            if (n_sSalesmancode==null && !(n_oTableSet.Fields(Para.salesmancode).IsNullable)) return false;
            if (n_sGo_wireless_package_code==null && !(n_oTableSet.Fields(Para.go_wireless_package_code).IsNullable)) return false;
            if (n_sLob==null && !(n_oTableSet.Fields(Para.lob).IsNullable)) return false;
            if (n_sRef_salesmancode==null && !(n_oTableSet.Fields(Para.ref_salesmancode).IsNullable)) return false;
            if (n_sThird_party_hkid==null && !(n_oTableSet.Fields(Para.third_party_hkid).IsNullable)) return false;
            if (n_sUpgrade_existing_pccw_customer==null && !(n_oTableSet.Fields(Para.upgrade_existing_pccw_customer).IsNullable)) return false;
            if (n_sD_address==null && !(n_oTableSet.Fields(Para.d_address).IsNullable)) return false;
            if (n_sUpgrade_registered_mobile_no==null && !(n_oTableSet.Fields(Para.upgrade_registered_mobile_no).IsNullable)) return false;
            if (n_sGift_code3==null && !(n_oTableSet.Fields(Para.gift_code3).IsNullable)) return false;
            if (n_sNormal_rebate_type==null && !(n_oTableSet.Fields(Para.normal_rebate_type).IsNullable)) return false;
            if (n_sGift_desc2==null && !(n_oTableSet.Fields(Para.gift_desc2).IsNullable)) return false;
            if (n_sMonthly_bank_account_branch_code==null && !(n_oTableSet.Fields(Para.monthly_bank_account_branch_code).IsNullable)) return false;
            if (n_sRemarks==null && !(n_oTableSet.Fields(Para.remarks).IsNullable)) return false;
            if (n_sAccept==null && !(n_oTableSet.Fields(Para.accept).IsNullable)) return false;
            if (n_sDelivery_exchange==null && !(n_oTableSet.Fields(Para.delivery_exchange).IsNullable)) return false;
            if (n_sGift_code2==null && !(n_oTableSet.Fields(Para.gift_code2).IsNullable)) return false;
            if (n_bPrepayment_waive==null && !(n_oTableSet.Fields(Para.prepayment_waive).IsNullable)) return false;
            if (n_sExisting_smart_phone_imei==null && !(n_oTableSet.Fields(Para.existing_smart_phone_imei).IsNullable)) return false;
            if (n_sCust_name==null && !(n_oTableSet.Fields(Para.cust_name).IsNullable)) return false;
            if (n_sUpgrade_sponsorships_amount==null && !(n_oTableSet.Fields(Para.upgrade_sponsorships_amount).IsNullable)) return false;
            if (n_bBill_medium_waive==null && !(n_oTableSet.Fields(Para.bill_medium_waive).IsNullable)) return false;
            if (n_sDelivery_exchange_location==null && !(n_oTableSet.Fields(Para.delivery_exchange_location).IsNullable)) return false;
            if (n_iHs_offer_type_id==null && !(n_oTableSet.Fields(Para.hs_offer_type_id).IsNullable)) return false;
            if (n_sExtra_rebate_amount==null && !(n_oTableSet.Fields(Para.extra_rebate_amount).IsNullable)) return false;
            if (n_sRebate==null && !(n_oTableSet.Fields(Para.rebate).IsNullable)) return false;
            if (n_sUpgrade_type==null && !(n_oTableSet.Fields(Para.upgrade_type).IsNullable)) return false;
            if (n_sGo_wireless==null && !(n_oTableSet.Fields(Para.go_wireless).IsNullable)) return false;
            if (n_sExtra_rebate==null && !(n_oTableSet.Fields(Para.extra_rebate).IsNullable)) return false;
            if (n_sPlan_eff==null && !(n_oTableSet.Fields(Para.plan_eff).IsNullable)) return false;
            if (n_sCard_exp_year==null && !(n_oTableSet.Fields(Para.card_exp_year).IsNullable)) return false;
            if (n_dUpgrade_existing_contract_sdate==null && !(n_oTableSet.Fields(Para.upgrade_existing_contract_sdate).IsNullable)) return false;
            if (n_sOrd_place_hkid==null && !(n_oTableSet.Fields(Para.ord_place_hkid).IsNullable)) return false;
            if (n_sRegister_address==null && !(n_oTableSet.Fields(Para.register_address).IsNullable)) return false;
            if (n_sGender==null && !(n_oTableSet.Fields(Para.gender).IsNullable)) return false;
            if (n_sLob_ac==null && !(n_oTableSet.Fields(Para.lob_ac).IsNullable)) return false;
            if (n_iSim_mrt_no==null && !(n_oTableSet.Fields(Para.sim_mrt_no).IsNullable)) return false;
            if (n_sRedemption_notice_option==null && !(n_oTableSet.Fields(Para.redemption_notice_option).IsNullable)) return false;
            if (n_sDelivery_collection_type==null && !(n_oTableSet.Fields(Para.delivery_collection_type).IsNullable)) return false;
            if (n_dAction_date==null && !(n_oTableSet.Fields(Para.action_date).IsNullable)) return false;
            if (n_sThird_party_id_type==null && !(n_oTableSet.Fields(Para.third_party_id_type).IsNullable)) return false;
            if (n_sOrg_ftg==null && !(n_oTableSet.Fields(Para.org_ftg).IsNullable)) return false;
            if (n_sUpgrade_service_tenure==null && !(n_oTableSet.Fields(Para.upgrade_service_tenure).IsNullable)) return false;
            if (n_sMonthly_payment_type==null && !(n_oTableSet.Fields(Para.monthly_payment_type).IsNullable)) return false;
            if (n_sContact_no==null && !(n_oTableSet.Fields(Para.contact_no).IsNullable)) return false;
            if (n_iOrg_mrt==null && !(n_oTableSet.Fields(Para.org_mrt).IsNullable)) return false;
            if (n_sSim_item_name==null && !(n_oTableSet.Fields(Para.sim_item_name).IsNullable)) return false;
            if (n_sPay_method==null && !(n_oTableSet.Fields(Para.pay_method).IsNullable)) return false;
            if (n_sHs_model==null && !(n_oTableSet.Fields(Para.hs_model).IsNullable)) return false;
            if (n_sGift_code==null && !(n_oTableSet.Fields(Para.gift_code).IsNullable)) return false;
            if (n_sMonthly_bank_account_hkid==null && !(n_oTableSet.Fields(Para.monthly_bank_account_hkid).IsNullable)) return false;
            if (n_sExtra_offer==null && !(n_oTableSet.Fields(Para.extra_offer).IsNullable)) return false;
            if (n_sMonthly_bank_account_no==null && !(n_oTableSet.Fields(Para.monthly_bank_account_no).IsNullable)) return false;
            if (n_sFirst_month_license_fee==null && !(n_oTableSet.Fields(Para.first_month_license_fee).IsNullable)) return false;
            if (n_iRetrieve_cnt==null && !(n_oTableSet.Fields(Para.retrieve_cnt).IsNullable)) return false;
            if (n_dDdate==null && !(n_oTableSet.Fields(Para.ddate).IsNullable)) return false;
            if (n_sS_premium2==null && !(n_oTableSet.Fields(Para.s_premium2).IsNullable)) return false;
            if (n_sMonthly_bank_account_id_type==null && !(n_oTableSet.Fields(Para.monthly_bank_account_id_type).IsNullable)) return false;
            if (n_sCard_type==null && !(n_oTableSet.Fields(Para.card_type).IsNullable)) return false;
            if (n_bNext_bill==null && !(n_oTableSet.Fields(Para.next_bill).IsNullable)) return false;
            if (n_bPcd_paid_go_wireless==null && !(n_oTableSet.Fields(Para.pcd_paid_go_wireless).IsNullable)) return false;
            if (n_sUpgrade_rebate_calculation==null && !(n_oTableSet.Fields(Para.upgrade_rebate_calculation).IsNullable)) return false;
            if (n_sExt_place_tel==null && !(n_oTableSet.Fields(Para.ext_place_tel).IsNullable)) return false;
            if (n_sM_3rd_hkid==null && !(n_oTableSet.Fields(Para.m_3rd_hkid).IsNullable)) return false;
            if (n_sRetention_type==null && !(n_oTableSet.Fields(Para.retention_type).IsNullable)) return false;
            if (n_dCooling_date==null && !(n_oTableSet.Fields(Para.cooling_date).IsNullable)) return false;
            if (n_sAig_gift==null && !(n_oTableSet.Fields(Para.aig_gift).IsNullable)) return false;
            if (n_sCust_staff_no==null && !(n_oTableSet.Fields(Para.cust_staff_no).IsNullable)) return false;
            if(!x_bInsert){
                if (n_iOrder_id==null && !(n_oTableSet.Fields(Para.order_id).IsNullable)) return false;
            }
            if (n_sFamily_name==null && !(n_oTableSet.Fields(Para.family_name).IsNullable)) return false;
            if (n_dCdate==null && !(n_oTableSet.Fields(Para.cdate).IsNullable)) return false;
            if (n_sStatus_by_cs_admin==null && !(n_oTableSet.Fields(Para.status_by_cs_admin).IsNullable)) return false;
            if (n_sGiven_name==null && !(n_oTableSet.Fields(Para.given_name).IsNullable)) return false;
            if (n_sVip_case==null && !(n_oTableSet.Fields(Para.vip_case).IsNullable)) return false;
            if (n_sOrg_fee==null && !(n_oTableSet.Fields(Para.org_fee).IsNullable)) return false;
            if (n_sS_premium3==null && !(n_oTableSet.Fields(Para.s_premium3).IsNullable)) return false;
            if (n_dLog_date==null && !(n_oTableSet.Fields(Para.log_date).IsNullable)) return false;
            if (n_sExtn==null && !(n_oTableSet.Fields(Para.extn).IsNullable)) return false;
            if (n_sD_time==null && !(n_oTableSet.Fields(Para.d_time).IsNullable)) return false;
            if (n_sBank_name==null && !(n_oTableSet.Fields(Para.bank_name).IsNullable)) return false;
            if (n_sDelivery_exchange_option==null && !(n_oTableSet.Fields(Para.delivery_exchange_option).IsNullable)) return false;
            if (n_sUpgrade_service_account_no==null && !(n_oTableSet.Fields(Para.upgrade_service_account_no).IsNullable)) return false;
            if (n_iOld_ord_id==null && !(n_oTableSet.Fields(Para.old_ord_id).IsNullable)) return false;
            if (n_sM_card_no==null && !(n_oTableSet.Fields(Para.m_card_no).IsNullable)) return false;
            if (n_sExisting_contract_end_date==null && !(n_oTableSet.Fields(Para.existing_contract_end_date).IsNullable)) return false;
            if (n_dCon_eff_date==null && !(n_oTableSet.Fields(Para.con_eff_date).IsNullable)) return false;
            if (n_sM_3rd_hkid2==null && !(n_oTableSet.Fields(Para.m_3rd_hkid2).IsNullable)) return false;
            if (n_sAmount==null && !(n_oTableSet.Fields(Para.amount).IsNullable)) return false;
            if (n_sM_3rd_id_type==null && !(n_oTableSet.Fields(Para.m_3rd_id_type).IsNullable)) return false;
            if (n_sId_type==null && !(n_oTableSet.Fields(Para.id_type).IsNullable)) return false;
            if (n_sRate_plan==null && !(n_oTableSet.Fields(Para.rate_plan).IsNullable)) return false;
            if (n_sChannel==null && !(n_oTableSet.Fields(Para.channel).IsNullable)) return false;
            if (n_dAction_eff_date==null && !(n_oTableSet.Fields(Para.action_eff_date).IsNullable)) return false;
            if (n_sIssue_type==null && !(n_oTableSet.Fields(Para.issue_type).IsNullable)) return false;
            if (n_sFree_mon==null && !(n_oTableSet.Fields(Para.free_mon).IsNullable)) return false;
            if (n_dPlan_eff_date==null && !(n_oTableSet.Fields(Para.plan_eff_date).IsNullable)) return false;
            if (n_sTeamcode==null && !(n_oTableSet.Fields(Para.teamcode).IsNullable)) return false;
            if (n_sBill_medium==null && !(n_oTableSet.Fields(Para.bill_medium).IsNullable)) return false;
            if (n_sEdf_no==null && !(n_oTableSet.Fields(Para.edf_no).IsNullable)) return false;
            if (n_sOrd_place_by==null && !(n_oTableSet.Fields(Para.ord_place_by).IsNullable)) return false;
            if (n_sCancel_renew==null && !(n_oTableSet.Fields(Para.cancel_renew).IsNullable)) return false;
            if (n_sPreferred_languages==null && !(n_oTableSet.Fields(Para.preferred_languages).IsNullable)) return false;
            if (n_sHkid==null && !(n_oTableSet.Fields(Para.hkid).IsNullable)) return false;
            if (n_sCard_holder==null && !(n_oTableSet.Fields(Para.card_holder).IsNullable)) return false;
            if (n_sAc_no==null && !(n_oTableSet.Fields(Para.ac_no).IsNullable)) return false;
            if (n_iBill_cut_num==null && !(n_oTableSet.Fields(Para.bill_cut_num).IsNullable)) return false;
            if (n_sPremium==null && !(n_oTableSet.Fields(Para.premium).IsNullable)) return false;
            if (n_sDel_remark==null && !(n_oTableSet.Fields(Para.del_remark).IsNullable)) return false;
            if (n_sGift_imei2==null && !(n_oTableSet.Fields(Para.gift_imei2).IsNullable)) return false;
            if (n_sReasons==null && !(n_oTableSet.Fields(Para.reasons).IsNullable)) return false;
            if (n_sLanguage==null && !(n_oTableSet.Fields(Para.language).IsNullable)) return false;
            if (n_sRebate_amount==null && !(n_oTableSet.Fields(Para.rebate_amount).IsNullable)) return false;
            if (n_sOrd_place_id_type==null && !(n_oTableSet.Fields(Para.ord_place_id_type).IsNullable)) return false;
            if (n_sM_3rd_contact_no==null && !(n_oTableSet.Fields(Para.m_3rd_contact_no).IsNullable)) return false;
            if (n_sStaff_no==null && !(n_oTableSet.Fields(Para.staff_no).IsNullable)) return false;
            if (n_dSp_d_date==null && !(n_oTableSet.Fields(Para.sp_d_date).IsNullable)) return false;
            if (n_sBundle_name==null && !(n_oTableSet.Fields(Para.bundle_name).IsNullable)) return false;
            if (n_bAccessory_waive==null && !(n_oTableSet.Fields(Para.accessory_waive).IsNullable)) return false;
            if (n_sSim_item_code==null && !(n_oTableSet.Fields(Para.sim_item_code).IsNullable)) return false;
            if (n_sCust_type==null && !(n_oTableSet.Fields(Para.cust_type).IsNullable)) return false;
            if (n_sCard_ref_no==null && !(n_oTableSet.Fields(Para.card_ref_no).IsNullable)) return false;
            return true;
        }
        #endregion
        
        #region Get & Set
        
        /// <summary>
        /// Summary description for Get & Set this all class parameters
        /// </summary>
        
        
        public object GetRepositoryObject(object x_oObj)
        {
            if (x_oObj == null) return null;
            if (x_oObj.GetType().IsSubclassOf(typeof(MobileRetentionOrderEntity)) || (x_oObj is MobileRetentionOrderEntity)) return MobileRetentionOrderRepository.Instance();
            return null;
        }
        
        
        #region GetFound
        public bool GetFound()
        {
            if(!this.n_bFound){ this.n_bFound = Vaild(false); }
            return this.n_bFound;
        }
        #endregion
        
        
        #region SetFound
        public void SetFound(bool value){  n_bFound=value; }
        #endregion SetFound
        
        
        #region GetTbl
        public DataTable GetTbl(){ return n_oTbl; }
        #endregion GetTbl
        
        
        #region SetTbl
        public void SetTbl(DataTable value){  n_oTbl=value; }
        #endregion SetTbl
        
        
        #region GetRow
        public DataRow GetRow(){ return n_oRow; }
        #endregion GetRow
        
        
        #region SetRow
        public void SetRow(DataRow value){  n_oRow=value; }
        #endregion SetRow
        
        
        #region GetDB
        public MSSQLConnect GetDB(){
            return n_oDB;
        }
        #endregion GetDB
        
        #region SetDB
        public void SetDB(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
        }
        #endregion SetDB
        
        
        #region GetTableSet
        public MobileRetentionOrderInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(MobileRetentionOrderInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public string GetGift_imei(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.gift_imei)) { return string.Empty; }
            return this.gift_imei;
        }
        public string GetS_premium4(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.s_premium4)) { return string.Empty; }
            return this.s_premium4;
        }
        public string GetGift_desc4(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.gift_desc4)) { return string.Empty; }
            return this.gift_desc4;
        }
        public string GetAccessory_desc(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.accessory_desc)) { return string.Empty; }
            return this.accessory_desc;
        }
        public string GetAction_required(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.action_required)) { return string.Empty; }
            return this.action_required;
        }
        public global::System.Nullable<DateTime> GetVas_eff_date(){return this.vas_eff_date;}
        public string GetMonthly_bank_account_bank_code(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.monthly_bank_account_bank_code)) { return string.Empty; }
            return this.monthly_bank_account_bank_code;
        }
        public string GetSpecial_handling_dummy_code(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.special_handling_dummy_code)) { return string.Empty; }
            return this.special_handling_dummy_code;
        }
        public string GetM_card_exp_year(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.m_card_exp_year)) { return string.Empty; }
            return this.m_card_exp_year;
        }
        public string GetRemarks2PY(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.remarks2PY)) { return string.Empty; }
            return this.remarks2PY;
        }
        public string GetTrade_field(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.trade_field)) { return string.Empty; }
            return this.trade_field;
        }
        public string GetOrd_place_tel(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.ord_place_tel)) { return string.Empty; }
            return this.ord_place_tel;
        }
        public string GetOrd_place_id_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.ord_place_id_type)) { return string.Empty; }
            return this.ord_place_id_type;
        }
        public string GetCooling_offer(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.cooling_offer)) { return string.Empty; }
            return this.cooling_offer;
        }
        public string GetUpgrade_handset_offer_rebate_schedule(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.upgrade_handset_offer_rebate_schedule)) { return string.Empty; }
            return this.upgrade_handset_offer_rebate_schedule;
        }
        public string GetChange_payment_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.change_payment_type)) { return string.Empty; }
            return this.change_payment_type;
        }
        public global::System.Nullable<DateTime> GetDate_of_birth(){return this.date_of_birth;}
        public string GetContact_person(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.contact_person)) { return string.Empty; }
            return this.contact_person;
        }
        public string GetExtra_d_charge(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.extra_d_charge)) { return string.Empty; }
            return this.extra_d_charge;
        }
        public string GetTl_name(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.tl_name)) { return string.Empty; }
            return this.tl_name;
        }
        public global::System.Nullable<bool> GetFast_start(){return this.fast_start;}
        public string GetSp_ref_no(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.sp_ref_no)) { return string.Empty; }
            return this.sp_ref_no;
        }
        public global::System.Nullable<DateTime> GetEdate(){return this.edate;}
        public string GetExist_cust_plan(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.exist_cust_plan)) { return string.Empty; }
            return this.exist_cust_plan;
        }
        public string GetOrd_place_rel(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.ord_place_rel)) { return string.Empty; }
            return this.ord_place_rel;
        }
        public global::System.Nullable<int> GetMrt_no(){return this.mrt_no;}
        public string GetImei_no(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.imei_no)) { return string.Empty; }
            return this.imei_no;
        }
        public string GetExisting_smart_phone_model(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.existing_smart_phone_model)) { return string.Empty; }
            return this.existing_smart_phone_model;
        }
        public string GetGift_code3(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.gift_code3)) { return string.Empty; }
            return this.gift_code3;
        }
        public string GetBank_code(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.bank_code)) { return string.Empty; }
            return this.bank_code;
        }
        public string GetPos_ref_no(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.pos_ref_no)) { return string.Empty; }
            return this.pos_ref_no;
        }
        public global::System.Nullable<DateTime> GetBill_cut_date(){return this.bill_cut_date;}
        public string GetGift_imei3(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.gift_imei3)) { return string.Empty; }
            return this.gift_imei3;
        }
        public string GetExist_plan(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.exist_plan)) { return string.Empty; }
            return this.exist_plan;
        }
        public global::System.Nullable<bool> GetWaive(){return this.waive;}
        public string GetProgram(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.program)) { return string.Empty; }
            return this.program;
        }
        public string GetFirst_month_fee(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.first_month_fee)) { return string.Empty; }
            return this.first_month_fee;
        }
        public string GetR_offer(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.r_offer)) { return string.Empty; }
            return this.r_offer;
        }
        public string GetCid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.cid)) { return string.Empty; }
            return this.cid;
        }
        public string GetDid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.did)) { return string.Empty; }
            return this.did;
        }
        public string GetFtg_tenure(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.ftg_tenure)) { return string.Empty; }
            return this.ftg_tenure;
        }
        public string GetCon_per(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.con_per)) { return string.Empty; }
            return this.con_per;
        }
        public string GetGift_code4(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.gift_code4)) { return string.Empty; }
            return this.gift_code4;
        }
        public string GetEasywatch_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.easywatch_type)) { return string.Empty; }
            return this.easywatch_type;
        }
        public string GetSms_mrt(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.sms_mrt)) { return string.Empty; }
            return this.sms_mrt;
        }
        public string GetMonthly_payment_method(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.monthly_payment_method)) { return string.Empty; }
            return this.monthly_payment_method;
        }
        public string GetRemarks2EDF(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.remarks2EDF)) { return string.Empty; }
            return this.remarks2EDF;
        }
        public string GetGift_desc3(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.gift_desc3)) { return string.Empty; }
            return this.gift_desc3;
        }
        public string GetGift_imei4(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.gift_imei4)) { return string.Empty; }
            return this.gift_imei4;
        }
        public global::System.Nullable<int> GetOld_ord_id(){return this.old_ord_id;}
        public string GetMonthly_bank_account_hkid2(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.monthly_bank_account_hkid2)) { return string.Empty; }
            return this.monthly_bank_account_hkid2;
        }
        public global::System.Nullable<DateTime> GetD_date(){return this.d_date;}
        public string GetGift_desc(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.gift_desc)) { return string.Empty; }
            return this.gift_desc;
        }
        public string GetSalesmancode(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.salesmancode)) { return string.Empty; }
            return this.salesmancode;
        }
        public string GetPool(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.pool)) { return string.Empty; }
            return this.pool;
        }
        public global::System.Nullable<long> GetCn_mrt_no(){return this.cn_mrt_no;}
        public string GetAccessory_imei(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.accessory_imei)) { return string.Empty; }
            return this.accessory_imei;
        }
        public string GetThird_party_credit_card(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.third_party_credit_card)) { return string.Empty; }
            return this.third_party_credit_card;
        }
        public string GetCard_ref_no(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.card_ref_no)) { return string.Empty; }
            return this.card_ref_no;
        }
        public string GetSpecial_approval(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.special_approval)) { return string.Empty; }
            return this.special_approval;
        }
        public global::System.Nullable<DateTime> GetUpgrade_existing_contract_edate(){return this.upgrade_existing_contract_edate;}
        public string GetAccessory_code(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.accessory_code)) { return string.Empty; }
            return this.accessory_code;
        }
        public string GetBill_medium(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.bill_medium)) { return string.Empty; }
            return this.bill_medium;
        }
        public string GetS_premium(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.s_premium)) { return string.Empty; }
            return this.s_premium;
        }
        public string GetRef_staff_no(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.ref_staff_no)) { return string.Empty; }
            return this.ref_staff_no;
        }
        public string GetAccessory_price(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.accessory_price)) { return string.Empty; }
            return this.accessory_price;
        }
        public string GetM_card_exp_month(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.m_card_exp_month)) { return string.Empty; }
            return this.m_card_exp_month;
        }
        public string GetInstallment_period(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.installment_period)) { return string.Empty; }
            return this.installment_period;
        }
        public string GetM_card_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.m_card_type)) { return string.Empty; }
            return this.m_card_type;
        }
        public string GetEasywatch_ord_id(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.easywatch_ord_id)) { return string.Empty; }
            return this.easywatch_ord_id;
        }
        public global::System.Nullable<bool> GetNormal_rebate(){return this.normal_rebate;}
        public string GetM_rebate_amount(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.m_rebate_amount)) { return string.Empty; }
            return this.m_rebate_amount;
        }
        public string GetM_card_holder2(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.m_card_holder2)) { return string.Empty; }
            return this.m_card_holder2;
        }
        public string GetBill_medium_email(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.bill_medium_email)) { return string.Empty; }
            return this.bill_medium_email;
        }
        public global::System.Nullable<bool> GetActive(){return this.active;}
        public string GetS_premium1(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.s_premium1)) { return string.Empty; }
            return this.s_premium1;
        }
        public string GetCard_exp_month(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.card_exp_month)) { return string.Empty; }
            return this.card_exp_month;
        }
        public string GetOb_program_id(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.ob_program_id)) { return string.Empty; }
            return this.ob_program_id;
        }
        public string GetSku(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.sku)) { return string.Empty; }
            return this.sku;
        }
        public string GetRef_salesmancode(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.ref_salesmancode)) { return string.Empty; }
            return this.ref_salesmancode;
        }
        public string GetGo_wireless_package_code(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.go_wireless_package_code)) { return string.Empty; }
            return this.go_wireless_package_code;
        }
        public string GetThird_party_hkid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.third_party_hkid)) { return string.Empty; }
            return this.third_party_hkid;
        }
        public string GetUpgrade_existing_pccw_customer(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.upgrade_existing_pccw_customer)) { return string.Empty; }
            return this.upgrade_existing_pccw_customer;
        }
        public string GetD_address(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.d_address)) { return string.Empty; }
            return this.d_address;
        }
        public string GetUpgrade_registered_mobile_no(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.upgrade_registered_mobile_no)) { return string.Empty; }
            return this.upgrade_registered_mobile_no;
        }
        public string GetUpgrade_existing_customer_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.upgrade_existing_customer_type)) { return string.Empty; }
            return this.upgrade_existing_customer_type;
        }
        public string GetNormal_rebate_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.normal_rebate_type)) { return string.Empty; }
            return this.normal_rebate_type;
        }
        public string GetGift_desc2(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.gift_desc2)) { return string.Empty; }
            return this.gift_desc2;
        }
        public string GetMonthly_bank_account_branch_code(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.monthly_bank_account_branch_code)) { return string.Empty; }
            return this.monthly_bank_account_branch_code;
        }
        public string GetRemarks(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.remarks)) { return string.Empty; }
            return this.remarks;
        }
        public string GetAccept(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.accept)) { return string.Empty; }
            return this.accept;
        }
        public string GetDelivery_exchange(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.delivery_exchange)) { return string.Empty; }
            return this.delivery_exchange;
        }
        public string GetGift_code2(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.gift_code2)) { return string.Empty; }
            return this.gift_code2;
        }
        public global::System.Nullable<bool> GetPrepayment_waive(){return this.prepayment_waive;}
        public string GetExisting_smart_phone_imei(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.existing_smart_phone_imei)) { return string.Empty; }
            return this.existing_smart_phone_imei;
        }
        public string GetCust_name(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.cust_name)) { return string.Empty; }
            return this.cust_name;
        }
        public string GetCust_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.cust_type)) { return string.Empty; }
            return this.cust_type;
        }
        public string GetUpgrade_sponsorships_amount(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.upgrade_sponsorships_amount)) { return string.Empty; }
            return this.upgrade_sponsorships_amount;
        }
        public global::System.Nullable<bool> GetBill_medium_waive(){return this.bill_medium_waive;}
        public string GetDelivery_exchange_location(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.delivery_exchange_location)) { return string.Empty; }
            return this.delivery_exchange_location;
        }
        public global::System.Nullable<int> GetHs_offer_type_id(){return this.hs_offer_type_id;}
        public string GetOrg_fee(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.org_fee)) { return string.Empty; }
            return this.org_fee;
        }
        public string GetRebate(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.rebate)) { return string.Empty; }
            return this.rebate;
        }
        public string GetUpgrade_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.upgrade_type)) { return string.Empty; }
            return this.upgrade_type;
        }
        public string GetGo_wireless(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.go_wireless)) { return string.Empty; }
            return this.go_wireless;
        }
        public string GetExtra_rebate(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.extra_rebate)) { return string.Empty; }
            return this.extra_rebate;
        }
        public string GetPlan_eff(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.plan_eff)) { return string.Empty; }
            return this.plan_eff;
        }
        public string GetExtra_rebate_amount(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.extra_rebate_amount)) { return string.Empty; }
            return this.extra_rebate_amount;
        }
        public string GetCard_exp_year(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.card_exp_year)) { return string.Empty; }
            return this.card_exp_year;
        }
        public global::System.Nullable<DateTime> GetUpgrade_existing_contract_sdate(){return this.upgrade_existing_contract_sdate;}
        public string GetOrd_place_hkid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.ord_place_hkid)) { return string.Empty; }
            return this.ord_place_hkid;
        }
        public string GetRegister_address(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.register_address)) { return string.Empty; }
            return this.register_address;
        }
        public string GetGender(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.gender)) { return string.Empty; }
            return this.gender;
        }
        public string GetLob_ac(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.lob_ac)) { return string.Empty; }
            return this.lob_ac;
        }
        public global::System.Nullable<int> GetSim_mrt_no(){return this.sim_mrt_no;}
        public string GetRedemption_notice_option(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.redemption_notice_option)) { return string.Empty; }
            return this.redemption_notice_option;
        }
        public string GetDelivery_collection_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.delivery_collection_type)) { return string.Empty; }
            return this.delivery_collection_type;
        }
        public global::System.Nullable<DateTime> GetAction_date(){return this.action_date;}
        public string GetThird_party_id_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.third_party_id_type)) { return string.Empty; }
            return this.third_party_id_type;
        }
        public string GetOrg_ftg(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.org_ftg)) { return string.Empty; }
            return this.org_ftg;
        }
        public string GetUpgrade_service_tenure(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.upgrade_service_tenure)) { return string.Empty; }
            return this.upgrade_service_tenure;
        }
        public string GetMonthly_payment_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.monthly_payment_type)) { return string.Empty; }
            return this.monthly_payment_type;
        }
        public string GetContact_no(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.contact_no)) { return string.Empty; }
            return this.contact_no;
        }
        public global::System.Nullable<int> GetOrg_mrt(){return this.org_mrt;}
        public string GetSim_item_name(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.sim_item_name)) { return string.Empty; }
            return this.sim_item_name;
        }
        public string GetPay_method(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.pay_method)) { return string.Empty; }
            return this.pay_method;
        }
        public string GetHs_model(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.hs_model)) { return string.Empty; }
            return this.hs_model;
        }
        public string GetGift_code(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.gift_code)) { return string.Empty; }
            return this.gift_code;
        }
        public string GetMonthly_bank_account_hkid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.monthly_bank_account_hkid)) { return string.Empty; }
            return this.monthly_bank_account_hkid;
        }
        public string GetExtra_offer(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.extra_offer)) { return string.Empty; }
            return this.extra_offer;
        }
        public string GetMonthly_bank_account_no(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.monthly_bank_account_no)) { return string.Empty; }
            return this.monthly_bank_account_no;
        }
        public string GetFirst_month_license_fee(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.first_month_license_fee)) { return string.Empty; }
            return this.first_month_license_fee;
        }
        public global::System.Nullable<int> GetRetrieve_cnt(){return this.retrieve_cnt;}
        public global::System.Nullable<DateTime> GetDdate(){return this.ddate;}
        public string GetS_premium2(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.s_premium2)) { return string.Empty; }
            return this.s_premium2;
        }
        public string GetMonthly_bank_account_id_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.monthly_bank_account_id_type)) { return string.Empty; }
            return this.monthly_bank_account_id_type;
        }
        public string GetCard_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.card_type)) { return string.Empty; }
            return this.card_type;
        }
        public global::System.Nullable<bool> GetNext_bill(){return this.next_bill;}
        public global::System.Nullable<bool> GetPcd_paid_go_wireless(){return this.pcd_paid_go_wireless;}
        public string GetUpgrade_rebate_calculation(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.upgrade_rebate_calculation)) { return string.Empty; }
            return this.upgrade_rebate_calculation;
        }
        public string GetExt_place_tel(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.ext_place_tel)) { return string.Empty; }
            return this.ext_place_tel;
        }
        public string GetM_3rd_hkid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.m_3rd_hkid)) { return string.Empty; }
            return this.m_3rd_hkid;
        }
        public string GetRetention_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.retention_type)) { return string.Empty; }
            return this.retention_type;
        }
        public global::System.Nullable<DateTime> GetCooling_date(){return this.cooling_date;}
        public string GetAig_gift(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.aig_gift)) { return string.Empty; }
            return this.aig_gift;
        }
        public string GetCust_staff_no(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.cust_staff_no)) { return string.Empty; }
            return this.cust_staff_no;
        }
        public global::System.Nullable<int> GetOrder_id(){return this.order_id;}
        public string GetFamily_name(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.family_name)) { return string.Empty; }
            return this.family_name;
        }
        public global::System.Nullable<DateTime> GetCdate(){return this.cdate;}
        public string GetStatus_by_cs_admin(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.status_by_cs_admin)) { return string.Empty; }
            return this.status_by_cs_admin;
        }
        public string GetSim_item_number(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.sim_item_number)) { return string.Empty; }
            return this.sim_item_number;
        }
        public string GetVip_case(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.vip_case)) { return string.Empty; }
            return this.vip_case;
        }
        public string GetGiven_name(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.given_name)) { return string.Empty; }
            return this.given_name;
        }
        public global::System.Nullable<DateTime> GetLog_date(){return this.log_date;}
        public string GetExtn(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.extn)) { return string.Empty; }
            return this.extn;
        }
        public string GetD_time(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.d_time)) { return string.Empty; }
            return this.d_time;
        }
        public string GetBank_name(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.bank_name)) { return string.Empty; }
            return this.bank_name;
        }
        public string GetDelivery_exchange_option(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.delivery_exchange_option)) { return string.Empty; }
            return this.delivery_exchange_option;
        }
        public string GetUpgrade_service_account_no(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.upgrade_service_account_no)) { return string.Empty; }
            return this.upgrade_service_account_no;
        }
        public string GetAction_of_rate_plan_effective(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.action_of_rate_plan_effective)) { return string.Empty; }
            return this.action_of_rate_plan_effective;
        }
        public string GetM_card_no(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.m_card_no)) { return string.Empty; }
            return this.m_card_no;
        }
        public string GetExisting_contract_end_date(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.existing_contract_end_date)) { return string.Empty; }
            return this.existing_contract_end_date;
        }
        public global::System.Nullable<DateTime> GetCon_eff_date(){return this.con_eff_date;}
        public string GetM_3rd_hkid2(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.m_3rd_hkid2)) { return string.Empty; }
            return this.m_3rd_hkid2;
        }
        public string GetAmount(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.amount)) { return string.Empty; }
            return this.amount;
        }
        public string GetId_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.id_type)) { return string.Empty; }
            return this.id_type;
        }
        public string GetRate_plan(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.rate_plan)) { return string.Empty; }
            return this.rate_plan;
        }
        public string GetChannel(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.channel)) { return string.Empty; }
            return this.channel;
        }
        public global::System.Nullable<DateTime> GetAction_eff_date(){return this.action_eff_date;}
        public string GetIssue_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.issue_type)) { return string.Empty; }
            return this.issue_type;
        }
        public string GetFree_mon(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.free_mon)) { return string.Empty; }
            return this.free_mon;
        }
        public global::System.Nullable<DateTime> GetPlan_eff_date(){return this.plan_eff_date;}
        public string GetDel_remark(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.del_remark)) { return string.Empty; }
            return this.del_remark;
        }
        public string GetTeamcode(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.teamcode)) { return string.Empty; }
            return this.teamcode;
        }
        public string GetStaff_name(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.staff_name)) { return string.Empty; }
            return this.staff_name;
        }
        public string GetEdf_no(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.edf_no)) { return string.Empty; }
            return this.edf_no;
        }
        public string GetOrd_place_by(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.ord_place_by)) { return string.Empty; }
            return this.ord_place_by;
        }
        public string GetCancel_renew(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.cancel_renew)) { return string.Empty; }
            return this.cancel_renew;
        }
        public string GetPreferred_languages(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.preferred_languages)) { return string.Empty; }
            return this.preferred_languages;
        }
        public string GetHkid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.hkid)) { return string.Empty; }
            return this.hkid;
        }
        public string GetCard_no(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.card_no)) { return string.Empty; }
            return this.card_no;
        }
        public string GetAc_no(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.ac_no)) { return string.Empty; }
            return this.ac_no;
        }
        public global::System.Nullable<int> GetBill_cut_num(){return this.bill_cut_num;}
        public string GetPremium(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.premium)) { return string.Empty; }
            return this.premium;
        }
        public string GetM_3rd_id_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.m_3rd_id_type)) { return string.Empty; }
            return this.m_3rd_id_type;
        }
        public string GetGift_imei2(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.gift_imei2)) { return string.Empty; }
            return this.gift_imei2;
        }
        public string GetReasons(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.reasons)) { return string.Empty; }
            return this.reasons;
        }
        public string GetLanguage(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.language)) { return string.Empty; }
            return this.language;
        }
        public string GetRebate_amount(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.rebate_amount)) { return string.Empty; }
            return this.rebate_amount;
        }
        public string GetLob(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.lob)) { return string.Empty; }
            return this.lob;
        }
        public string GetM_3rd_contact_no(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.m_3rd_contact_no)) { return string.Empty; }
            return this.m_3rd_contact_no;
        }
        public string GetStaff_no(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.staff_no)) { return string.Empty; }
            return this.staff_no;
        }
        public string GetS_premium3(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.s_premium3)) { return string.Empty; }
            return this.s_premium3;
        }
        public global::System.Nullable<DateTime> GetSp_d_date(){return this.sp_d_date;}
        public string GetBundle_name(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.bundle_name)) { return string.Empty; }
            return this.bundle_name;
        }
        public global::System.Nullable<bool> GetAccessory_waive(){return this.accessory_waive;}
        public string GetSim_item_code(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.sim_item_code)) { return string.Empty; }
            return this.sim_item_code;
        }
        public string GetMonthly_bank_account_holder(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.monthly_bank_account_holder)) { return string.Empty; }
            return this.monthly_bank_account_holder;
        }
        public string GetCard_holder(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.card_holder)) { return string.Empty; }
            return this.card_holder;
        }
        
        public bool SetGift_imei(string value){
            this.gift_imei=value;
            return true;
        }
        public bool SetS_premium4(string value){
            this.s_premium4=value;
            return true;
        }
        public bool SetGift_desc4(string value){
            this.gift_desc4=value;
            return true;
        }
        public bool SetAccessory_desc(string value){
            this.accessory_desc=value;
            return true;
        }
        public bool SetAction_required(string value){
            this.action_required=value;
            return true;
        }
        public bool SetVas_eff_date(global::System.Nullable<DateTime> value){
            this.vas_eff_date=value;
            return true;
        }
        public bool SetMonthly_bank_account_bank_code(string value){
            this.monthly_bank_account_bank_code=value;
            return true;
        }
        public bool SetSpecial_handling_dummy_code(string value){
            this.special_handling_dummy_code=value;
            return true;
        }
        public bool SetM_card_exp_year(string value){
            this.m_card_exp_year=value;
            return true;
        }
        public bool SetRemarks2PY(string value){
            this.remarks2PY=value;
            return true;
        }
        public bool SetTrade_field(string value){
            this.trade_field=value;
            return true;
        }
        public bool SetOrd_place_tel(string value){
            this.ord_place_tel=value;
            return true;
        }
        public bool SetOrd_place_id_type(string value){
            this.ord_place_id_type=value;
            return true;
        }
        public bool SetCooling_offer(string value){
            this.cooling_offer=value;
            return true;
        }
        public bool SetUpgrade_handset_offer_rebate_schedule(string value){
            this.upgrade_handset_offer_rebate_schedule=value;
            return true;
        }
        public bool SetChange_payment_type(string value){
            this.change_payment_type=value;
            return true;
        }
        public bool SetDate_of_birth(global::System.Nullable<DateTime> value){
            this.date_of_birth=value;
            return true;
        }
        public bool SetContact_person(string value){
            this.contact_person=value;
            return true;
        }
        public bool SetExtra_d_charge(string value){
            this.extra_d_charge=value;
            return true;
        }
        public bool SetTl_name(string value){
            this.tl_name=value;
            return true;
        }
        public bool SetFast_start(global::System.Nullable<bool> value){
            this.fast_start=value;
            return true;
        }
        public bool SetSp_ref_no(string value){
            this.sp_ref_no=value;
            return true;
        }
        public bool SetEdate(global::System.Nullable<DateTime> value){
            this.edate=value;
            return true;
        }
        public bool SetExist_cust_plan(string value){
            this.exist_cust_plan=value;
            return true;
        }
        public bool SetOrd_place_rel(string value){
            this.ord_place_rel=value;
            return true;
        }
        public bool SetMrt_no(global::System.Nullable<int> value){
            this.mrt_no=value;
            return true;
        }
        public bool SetImei_no(string value){
            this.imei_no=value;
            return true;
        }
        public bool SetExisting_smart_phone_model(string value){
            this.existing_smart_phone_model=value;
            return true;
        }
        public bool SetGift_code3(string value){
            this.gift_code3=value;
            return true;
        }
        public bool SetBank_code(string value){
            this.bank_code=value;
            return true;
        }
        public bool SetPos_ref_no(string value){
            this.pos_ref_no=value;
            return true;
        }
        public bool SetBill_cut_date(global::System.Nullable<DateTime> value){
            this.bill_cut_date=value;
            return true;
        }
        public bool SetGift_imei3(string value){
            this.gift_imei3=value;
            return true;
        }
        public bool SetExist_plan(string value){
            this.exist_plan=value;
            return true;
        }
        public bool SetWaive(global::System.Nullable<bool> value){
            this.waive=value;
            return true;
        }
        public bool SetProgram(string value){
            this.program=value;
            return true;
        }
        public bool SetFirst_month_fee(string value){
            this.first_month_fee=value;
            return true;
        }
        public bool SetR_offer(string value){
            this.r_offer=value;
            return true;
        }
        public bool SetCid(string value){
            this.cid=value;
            return true;
        }
        public bool SetDid(string value){
            this.did=value;
            return true;
        }
        public bool SetFtg_tenure(string value){
            this.ftg_tenure=value;
            return true;
        }
        public bool SetCon_per(string value){
            this.con_per=value;
            return true;
        }
        public bool SetGift_code4(string value){
            this.gift_code4=value;
            return true;
        }
        public bool SetEasywatch_type(string value){
            this.easywatch_type=value;
            return true;
        }
        public bool SetSms_mrt(string value){
            this.sms_mrt=value;
            return true;
        }
        public bool SetMonthly_payment_method(string value){
            this.monthly_payment_method=value;
            return true;
        }
        public bool SetRemarks2EDF(string value){
            this.remarks2EDF=value;
            return true;
        }
        public bool SetGift_desc3(string value){
            this.gift_desc3=value;
            return true;
        }
        public bool SetGift_imei4(string value){
            this.gift_imei4=value;
            return true;
        }
        public bool SetOld_ord_id(global::System.Nullable<int> value){
            this.old_ord_id=value;
            return true;
        }
        public bool SetMonthly_bank_account_hkid2(string value){
            this.monthly_bank_account_hkid2=value;
            return true;
        }
        public bool SetD_date(global::System.Nullable<DateTime> value){
            this.d_date=value;
            return true;
        }
        public bool SetGift_desc(string value){
            this.gift_desc=value;
            return true;
        }
        public bool SetSalesmancode(string value){
            this.salesmancode=value;
            return true;
        }
        public bool SetPool(string value){
            this.pool=value;
            return true;
        }
        public bool SetCn_mrt_no(global::System.Nullable<long> value){
            this.cn_mrt_no=value;
            return true;
        }
        public bool SetAccessory_imei(string value){
            this.accessory_imei=value;
            return true;
        }
        public bool SetThird_party_credit_card(string value){
            this.third_party_credit_card=value;
            return true;
        }
        public bool SetCard_ref_no(string value){
            this.card_ref_no=value;
            return true;
        }
        public bool SetSpecial_approval(string value){
            this.special_approval=value;
            return true;
        }
        public bool SetUpgrade_existing_contract_edate(global::System.Nullable<DateTime> value){
            this.upgrade_existing_contract_edate=value;
            return true;
        }
        public bool SetAccessory_code(string value){
            this.accessory_code=value;
            return true;
        }
        public bool SetBill_medium(string value){
            this.bill_medium=value;
            return true;
        }
        public bool SetS_premium(string value){
            this.s_premium=value;
            return true;
        }
        public bool SetRef_staff_no(string value){
            this.ref_staff_no=value;
            return true;
        }
        public bool SetAccessory_price(string value){
            this.accessory_price=value;
            return true;
        }
        public bool SetM_card_exp_month(string value){
            this.m_card_exp_month=value;
            return true;
        }
        public bool SetInstallment_period(string value){
            this.installment_period=value;
            return true;
        }
        public bool SetM_card_type(string value){
            this.m_card_type=value;
            return true;
        }
        public bool SetEasywatch_ord_id(string value){
            this.easywatch_ord_id=value;
            return true;
        }
        public bool SetNormal_rebate(global::System.Nullable<bool> value){
            this.normal_rebate=value;
            return true;
        }
        public bool SetM_rebate_amount(string value){
            this.m_rebate_amount=value;
            return true;
        }
        public bool SetM_card_holder2(string value){
            this.m_card_holder2=value;
            return true;
        }
        public bool SetBill_medium_email(string value){
            this.bill_medium_email=value;
            return true;
        }
        public bool SetActive(global::System.Nullable<bool> value){
            this.active=value;
            return true;
        }
        public bool SetS_premium1(string value){
            this.s_premium1=value;
            return true;
        }
        public bool SetCard_exp_month(string value){
            this.card_exp_month=value;
            return true;
        }
        public bool SetOb_program_id(string value){
            this.ob_program_id=value;
            return true;
        }
        public bool SetSku(string value){
            this.sku=value;
            return true;
        }
        public bool SetRef_salesmancode(string value){
            this.ref_salesmancode=value;
            return true;
        }
        public bool SetGo_wireless_package_code(string value){
            this.go_wireless_package_code=value;
            return true;
        }
        public bool SetThird_party_hkid(string value){
            this.third_party_hkid=value;
            return true;
        }
        public bool SetUpgrade_existing_pccw_customer(string value){
            this.upgrade_existing_pccw_customer=value;
            return true;
        }
        public bool SetD_address(string value){
            this.d_address=value;
            return true;
        }
        public bool SetUpgrade_registered_mobile_no(string value){
            this.upgrade_registered_mobile_no=value;
            return true;
        }
        public bool SetUpgrade_existing_customer_type(string value){
            this.upgrade_existing_customer_type=value;
            return true;
        }
        public bool SetNormal_rebate_type(string value){
            this.normal_rebate_type=value;
            return true;
        }
        public bool SetGift_desc2(string value){
            this.gift_desc2=value;
            return true;
        }
        public bool SetMonthly_bank_account_branch_code(string value){
            this.monthly_bank_account_branch_code=value;
            return true;
        }
        public bool SetRemarks(string value){
            this.remarks=value;
            return true;
        }
        public bool SetAccept(string value){
            this.accept=value;
            return true;
        }
        public bool SetDelivery_exchange(string value){
            this.delivery_exchange=value;
            return true;
        }
        public bool SetGift_code2(string value){
            this.gift_code2=value;
            return true;
        }
        public bool SetPrepayment_waive(global::System.Nullable<bool> value){
            this.prepayment_waive=value;
            return true;
        }
        public bool SetExisting_smart_phone_imei(string value){
            this.existing_smart_phone_imei=value;
            return true;
        }
        public bool SetCust_name(string value){
            this.cust_name=value;
            return true;
        }
        public bool SetCust_type(string value){
            this.cust_type=value;
            return true;
        }
        public bool SetUpgrade_sponsorships_amount(string value){
            this.upgrade_sponsorships_amount=value;
            return true;
        }
        public bool SetBill_medium_waive(global::System.Nullable<bool> value){
            this.bill_medium_waive=value;
            return true;
        }
        public bool SetDelivery_exchange_location(string value){
            this.delivery_exchange_location=value;
            return true;
        }
        public bool SetHs_offer_type_id(global::System.Nullable<int> value){
            this.hs_offer_type_id=value;
            return true;
        }
        public bool SetOrg_fee(string value){
            this.org_fee=value;
            return true;
        }
        public bool SetRebate(string value){
            this.rebate=value;
            return true;
        }
        public bool SetUpgrade_type(string value){
            this.upgrade_type=value;
            return true;
        }
        public bool SetGo_wireless(string value){
            this.go_wireless=value;
            return true;
        }
        public bool SetExtra_rebate(string value){
            this.extra_rebate=value;
            return true;
        }
        public bool SetPlan_eff(string value){
            this.plan_eff=value;
            return true;
        }
        public bool SetExtra_rebate_amount(string value){
            this.extra_rebate_amount=value;
            return true;
        }
        public bool SetCard_exp_year(string value){
            this.card_exp_year=value;
            return true;
        }
        public bool SetUpgrade_existing_contract_sdate(global::System.Nullable<DateTime> value){
            this.upgrade_existing_contract_sdate=value;
            return true;
        }
        public bool SetOrd_place_hkid(string value){
            this.ord_place_hkid=value;
            return true;
        }
        public bool SetRegister_address(string value){
            this.register_address=value;
            return true;
        }
        public bool SetGender(string value){
            this.gender=value;
            return true;
        }
        public bool SetLob_ac(string value){
            this.lob_ac=value;
            return true;
        }
        public bool SetSim_mrt_no(global::System.Nullable<int> value){
            this.sim_mrt_no=value;
            return true;
        }
        public bool SetRedemption_notice_option(string value){
            this.redemption_notice_option=value;
            return true;
        }
        public bool SetDelivery_collection_type(string value){
            this.delivery_collection_type=value;
            return true;
        }
        public bool SetAction_date(global::System.Nullable<DateTime> value){
            this.action_date=value;
            return true;
        }
        public bool SetThird_party_id_type(string value){
            this.third_party_id_type=value;
            return true;
        }
        public bool SetOrg_ftg(string value){
            this.org_ftg=value;
            return true;
        }
        public bool SetUpgrade_service_tenure(string value){
            this.upgrade_service_tenure=value;
            return true;
        }
        public bool SetMonthly_payment_type(string value){
            this.monthly_payment_type=value;
            return true;
        }
        public bool SetContact_no(string value){
            this.contact_no=value;
            return true;
        }
        public bool SetOrg_mrt(global::System.Nullable<int> value){
            this.org_mrt=value;
            return true;
        }
        public bool SetSim_item_name(string value){
            this.sim_item_name=value;
            return true;
        }
        public bool SetPay_method(string value){
            this.pay_method=value;
            return true;
        }
        public bool SetHs_model(string value){
            this.hs_model=value;
            return true;
        }
        public bool SetGift_code(string value){
            this.gift_code=value;
            return true;
        }
        public bool SetMonthly_bank_account_hkid(string value){
            this.monthly_bank_account_hkid=value;
            return true;
        }
        public bool SetExtra_offer(string value){
            this.extra_offer=value;
            return true;
        }
        public bool SetMonthly_bank_account_no(string value){
            this.monthly_bank_account_no=value;
            return true;
        }
        public bool SetFirst_month_license_fee(string value){
            this.first_month_license_fee=value;
            return true;
        }
        public bool SetRetrieve_cnt(global::System.Nullable<int> value){
            this.retrieve_cnt=value;
            return true;
        }
        public bool SetDdate(global::System.Nullable<DateTime> value){
            this.ddate=value;
            return true;
        }
        public bool SetS_premium2(string value){
            this.s_premium2=value;
            return true;
        }
        public bool SetMonthly_bank_account_id_type(string value){
            this.monthly_bank_account_id_type=value;
            return true;
        }
        public bool SetCard_type(string value){
            this.card_type=value;
            return true;
        }
        public bool SetNext_bill(global::System.Nullable<bool> value){
            this.next_bill=value;
            return true;
        }
        public bool SetPcd_paid_go_wireless(global::System.Nullable<bool> value){
            this.pcd_paid_go_wireless=value;
            return true;
        }
        public bool SetUpgrade_rebate_calculation(string value){
            this.upgrade_rebate_calculation=value;
            return true;
        }
        public bool SetExt_place_tel(string value){
            this.ext_place_tel=value;
            return true;
        }
        public bool SetM_3rd_hkid(string value){
            this.m_3rd_hkid=value;
            return true;
        }
        public bool SetRetention_type(string value){
            this.retention_type=value;
            return true;
        }
        public bool SetCooling_date(global::System.Nullable<DateTime> value){
            this.cooling_date=value;
            return true;
        }
        public bool SetAig_gift(string value){
            this.aig_gift=value;
            return true;
        }
        public bool SetCust_staff_no(string value){
            this.cust_staff_no=value;
            return true;
        }
        public bool SetOrder_id(global::System.Nullable<int> value){
            this.order_id=value;
            return true;
        }
        public bool SetFamily_name(string value){
            this.family_name=value;
            return true;
        }
        public bool SetCdate(global::System.Nullable<DateTime> value){
            this.cdate=value;
            return true;
        }
        public bool SetStatus_by_cs_admin(string value){
            this.status_by_cs_admin=value;
            return true;
        }
        public bool SetSim_item_number(string value){
            this.sim_item_number=value;
            return true;
        }
        public bool SetVip_case(string value){
            this.vip_case=value;
            return true;
        }
        public bool SetGiven_name(string value){
            this.given_name=value;
            return true;
        }
        public bool SetLog_date(global::System.Nullable<DateTime> value){
            this.log_date=value;
            return true;
        }
        public bool SetExtn(string value){
            this.extn=value;
            return true;
        }
        public bool SetD_time(string value){
            this.d_time=value;
            return true;
        }
        public bool SetBank_name(string value){
            this.bank_name=value;
            return true;
        }
        public bool SetDelivery_exchange_option(string value){
            this.delivery_exchange_option=value;
            return true;
        }
        public bool SetUpgrade_service_account_no(string value){
            this.upgrade_service_account_no=value;
            return true;
        }
        public bool SetAction_of_rate_plan_effective(string value){
            this.action_of_rate_plan_effective=value;
            return true;
        }
        public bool SetM_card_no(string value){
            this.m_card_no=value;
            return true;
        }
        public bool SetExisting_contract_end_date(string value){
            this.existing_contract_end_date=value;
            return true;
        }
        public bool SetCon_eff_date(global::System.Nullable<DateTime> value){
            this.con_eff_date=value;
            return true;
        }
        public bool SetM_3rd_hkid2(string value){
            this.m_3rd_hkid2=value;
            return true;
        }
        public bool SetAmount(string value){
            this.amount=value;
            return true;
        }
        public bool SetId_type(string value){
            this.id_type=value;
            return true;
        }
        public bool SetRate_plan(string value){
            this.rate_plan=value;
            return true;
        }
        public bool SetChannel(string value){
            this.channel=value;
            return true;
        }
        public bool SetAction_eff_date(global::System.Nullable<DateTime> value){
            this.action_eff_date=value;
            return true;
        }
        public bool SetIssue_type(string value){
            this.issue_type=value;
            return true;
        }
        public bool SetFree_mon(string value){
            this.free_mon=value;
            return true;
        }
        public bool SetPlan_eff_date(global::System.Nullable<DateTime> value){
            this.plan_eff_date=value;
            return true;
        }
        public bool SetDel_remark(string value){
            this.del_remark=value;
            return true;
        }
        public bool SetTeamcode(string value){
            this.teamcode=value;
            return true;
        }
        public bool SetStaff_name(string value){
            this.staff_name=value;
            return true;
        }
        public bool SetEdf_no(string value){
            this.edf_no=value;
            return true;
        }
        public bool SetOrd_place_by(string value){
            this.ord_place_by=value;
            return true;
        }
        public bool SetCancel_renew(string value){
            this.cancel_renew=value;
            return true;
        }
        public bool SetPreferred_languages(string value){
            this.preferred_languages=value;
            return true;
        }
        public bool SetHkid(string value){
            this.hkid=value;
            return true;
        }
        public bool SetCard_no(string value){
            this.card_no=value;
            return true;
        }
        public bool SetAc_no(string value){
            this.ac_no=value;
            return true;
        }
        public bool SetBill_cut_num(global::System.Nullable<int> value){
            this.bill_cut_num=value;
            return true;
        }
        public bool SetPremium(string value){
            this.premium=value;
            return true;
        }
        public bool SetM_3rd_id_type(string value){
            this.m_3rd_id_type=value;
            return true;
        }
        public bool SetGift_imei2(string value){
            this.gift_imei2=value;
            return true;
        }
        public bool SetReasons(string value){
            this.reasons=value;
            return true;
        }
        public bool SetLanguage(string value){
            this.language=value;
            return true;
        }
        public bool SetRebate_amount(string value){
            this.rebate_amount=value;
            return true;
        }
        public bool SetLob(string value){
            this.lob=value;
            return true;
        }
        public bool SetM_3rd_contact_no(string value){
            this.m_3rd_contact_no=value;
            return true;
        }
        public bool SetStaff_no(string value){
            this.staff_no=value;
            return true;
        }
        public bool SetS_premium3(string value){
            this.s_premium3=value;
            return true;
        }
        public bool SetSp_d_date(global::System.Nullable<DateTime> value){
            this.sp_d_date=value;
            return true;
        }
        public bool SetBundle_name(string value){
            this.bundle_name=value;
            return true;
        }
        public bool SetAccessory_waive(global::System.Nullable<bool> value){
            this.accessory_waive=value;
            return true;
        }
        public bool SetSim_item_code(string value){
            this.sim_item_code=value;
            return true;
        }
        public bool SetMonthly_bank_account_holder(string value){
            this.monthly_bank_account_holder=value;
            return true;
        }
        public bool SetCard_holder(string value){
            this.card_holder=value;
            return true;
        }
        
        public Field GetGift_imeiTable(){
            return n_oTableSet.Fields(Para.gift_imei);
        }
        public Field GetS_premium4Table(){
            return n_oTableSet.Fields(Para.s_premium4);
        }
        public Field GetGift_desc4Table(){
            return n_oTableSet.Fields(Para.gift_desc4);
        }
        public Field GetAccessory_descTable(){
            return n_oTableSet.Fields(Para.accessory_desc);
        }
        public Field GetAction_requiredTable(){
            return n_oTableSet.Fields(Para.action_required);
        }
        public Field GetVas_eff_dateTable(){
            return n_oTableSet.Fields(Para.vas_eff_date);
        }
        public Field GetMonthly_bank_account_bank_codeTable(){
            return n_oTableSet.Fields(Para.monthly_bank_account_bank_code);
        }
        public Field GetSpecial_handling_dummy_codeTable(){
            return n_oTableSet.Fields(Para.special_handling_dummy_code);
        }
        public Field GetM_card_exp_yearTable(){
            return n_oTableSet.Fields(Para.m_card_exp_year);
        }
        public Field GetRemarks2PYTable(){
            return n_oTableSet.Fields(Para.remarks2PY);
        }
        public Field GetTrade_fieldTable(){
            return n_oTableSet.Fields(Para.trade_field);
        }
        public Field GetOrd_place_telTable(){
            return n_oTableSet.Fields(Para.ord_place_tel);
        }
        public Field GetOrd_place_id_typeTable(){
            return n_oTableSet.Fields(Para.ord_place_id_type);
        }
        public Field GetCooling_offerTable(){
            return n_oTableSet.Fields(Para.cooling_offer);
        }
        public Field GetUpgrade_handset_offer_rebate_scheduleTable(){
            return n_oTableSet.Fields(Para.upgrade_handset_offer_rebate_schedule);
        }
        public Field GetChange_payment_typeTable(){
            return n_oTableSet.Fields(Para.change_payment_type);
        }
        public Field GetDate_of_birthTable(){
            return n_oTableSet.Fields(Para.date_of_birth);
        }
        public Field GetContact_personTable(){
            return n_oTableSet.Fields(Para.contact_person);
        }
        public Field GetExtra_d_chargeTable(){
            return n_oTableSet.Fields(Para.extra_d_charge);
        }
        public Field GetTl_nameTable(){
            return n_oTableSet.Fields(Para.tl_name);
        }
        public Field GetFast_startTable(){
            return n_oTableSet.Fields(Para.fast_start);
        }
        public Field GetSp_ref_noTable(){
            return n_oTableSet.Fields(Para.sp_ref_no);
        }
        public Field GetEdateTable(){
            return n_oTableSet.Fields(Para.edate);
        }
        public Field GetExist_cust_planTable(){
            return n_oTableSet.Fields(Para.exist_cust_plan);
        }
        public Field GetOrd_place_relTable(){
            return n_oTableSet.Fields(Para.ord_place_rel);
        }
        public Field GetMrt_noTable(){
            return n_oTableSet.Fields(Para.mrt_no);
        }
        public Field GetImei_noTable(){
            return n_oTableSet.Fields(Para.imei_no);
        }
        public Field GetExisting_smart_phone_modelTable(){
            return n_oTableSet.Fields(Para.existing_smart_phone_model);
        }
        public Field GetGift_code3Table(){
            return n_oTableSet.Fields(Para.gift_code3);
        }
        public Field GetBank_codeTable(){
            return n_oTableSet.Fields(Para.bank_code);
        }
        public Field GetPos_ref_noTable(){
            return n_oTableSet.Fields(Para.pos_ref_no);
        }
        public Field GetBill_cut_dateTable(){
            return n_oTableSet.Fields(Para.bill_cut_date);
        }
        public Field GetGift_imei3Table(){
            return n_oTableSet.Fields(Para.gift_imei3);
        }
        public Field GetExist_planTable(){
            return n_oTableSet.Fields(Para.exist_plan);
        }
        public Field GetWaiveTable(){
            return n_oTableSet.Fields(Para.waive);
        }
        public Field GetProgramTable(){
            return n_oTableSet.Fields(Para.program);
        }
        public Field GetFirst_month_feeTable(){
            return n_oTableSet.Fields(Para.first_month_fee);
        }
        public Field GetR_offerTable(){
            return n_oTableSet.Fields(Para.r_offer);
        }
        public Field GetCidTable(){
            return n_oTableSet.Fields(Para.cid);
        }
        public Field GetDidTable(){
            return n_oTableSet.Fields(Para.did);
        }
        public Field GetFtg_tenureTable(){
            return n_oTableSet.Fields(Para.ftg_tenure);
        }
        public Field GetCon_perTable(){
            return n_oTableSet.Fields(Para.con_per);
        }
        public Field GetGift_code4Table(){
            return n_oTableSet.Fields(Para.gift_code4);
        }
        public Field GetEasywatch_typeTable(){
            return n_oTableSet.Fields(Para.easywatch_type);
        }
        public Field GetSms_mrtTable(){
            return n_oTableSet.Fields(Para.sms_mrt);
        }
        public Field GetMonthly_payment_methodTable(){
            return n_oTableSet.Fields(Para.monthly_payment_method);
        }
        public Field GetRemarks2EDFTable(){
            return n_oTableSet.Fields(Para.remarks2EDF);
        }
        public Field GetGift_desc3Table(){
            return n_oTableSet.Fields(Para.gift_desc3);
        }
        public Field GetGift_imei4Table(){
            return n_oTableSet.Fields(Para.gift_imei4);
        }
        public Field GetOld_ord_idTable(){
            return n_oTableSet.Fields(Para.old_ord_id);
        }
        public Field GetMonthly_bank_account_hkid2Table(){
            return n_oTableSet.Fields(Para.monthly_bank_account_hkid2);
        }
        public Field GetD_dateTable(){
            return n_oTableSet.Fields(Para.d_date);
        }
        public Field GetGift_descTable(){
            return n_oTableSet.Fields(Para.gift_desc);
        }
        public Field GetSalesmancodeTable(){
            return n_oTableSet.Fields(Para.salesmancode);
        }
        public Field GetPoolTable(){
            return n_oTableSet.Fields(Para.pool);
        }
        public Field GetCn_mrt_noTable(){
            return n_oTableSet.Fields(Para.cn_mrt_no);
        }
        public Field GetAccessory_imeiTable(){
            return n_oTableSet.Fields(Para.accessory_imei);
        }
        public Field GetThird_party_credit_cardTable(){
            return n_oTableSet.Fields(Para.third_party_credit_card);
        }
        public Field GetCard_ref_noTable(){
            return n_oTableSet.Fields(Para.card_ref_no);
        }
        public Field GetSpecial_approvalTable(){
            return n_oTableSet.Fields(Para.special_approval);
        }
        public Field GetUpgrade_existing_contract_edateTable(){
            return n_oTableSet.Fields(Para.upgrade_existing_contract_edate);
        }
        public Field GetAccessory_codeTable(){
            return n_oTableSet.Fields(Para.accessory_code);
        }
        public Field GetBill_mediumTable(){
            return n_oTableSet.Fields(Para.bill_medium);
        }
        public Field GetS_premiumTable(){
            return n_oTableSet.Fields(Para.s_premium);
        }
        public Field GetRef_staff_noTable(){
            return n_oTableSet.Fields(Para.ref_staff_no);
        }
        public Field GetAccessory_priceTable(){
            return n_oTableSet.Fields(Para.accessory_price);
        }
        public Field GetM_card_exp_monthTable(){
            return n_oTableSet.Fields(Para.m_card_exp_month);
        }
        public Field GetInstallment_periodTable(){
            return n_oTableSet.Fields(Para.installment_period);
        }
        public Field GetM_card_typeTable(){
            return n_oTableSet.Fields(Para.m_card_type);
        }
        public Field GetEasywatch_ord_idTable(){
            return n_oTableSet.Fields(Para.easywatch_ord_id);
        }
        public Field GetNormal_rebateTable(){
            return n_oTableSet.Fields(Para.normal_rebate);
        }
        public Field GetM_rebate_amountTable(){
            return n_oTableSet.Fields(Para.m_rebate_amount);
        }
        public Field GetM_card_holder2Table(){
            return n_oTableSet.Fields(Para.m_card_holder2);
        }
        public Field GetBill_medium_emailTable(){
            return n_oTableSet.Fields(Para.bill_medium_email);
        }
        public Field GetActiveTable(){
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetS_premium1Table(){
            return n_oTableSet.Fields(Para.s_premium1);
        }
        public Field GetCard_exp_monthTable(){
            return n_oTableSet.Fields(Para.card_exp_month);
        }
        public Field GetOb_program_idTable(){
            return n_oTableSet.Fields(Para.ob_program_id);
        }
        public Field GetSkuTable(){
            return n_oTableSet.Fields(Para.sku);
        }
        public Field GetRef_salesmancodeTable(){
            return n_oTableSet.Fields(Para.ref_salesmancode);
        }
        public Field GetGo_wireless_package_codeTable(){
            return n_oTableSet.Fields(Para.go_wireless_package_code);
        }
        public Field GetThird_party_hkidTable(){
            return n_oTableSet.Fields(Para.third_party_hkid);
        }
        public Field GetUpgrade_existing_pccw_customerTable(){
            return n_oTableSet.Fields(Para.upgrade_existing_pccw_customer);
        }
        public Field GetD_addressTable(){
            return n_oTableSet.Fields(Para.d_address);
        }
        public Field GetUpgrade_registered_mobile_noTable(){
            return n_oTableSet.Fields(Para.upgrade_registered_mobile_no);
        }
        public Field GetUpgrade_existing_customer_typeTable(){
            return n_oTableSet.Fields(Para.upgrade_existing_customer_type);
        }
        public Field GetNormal_rebate_typeTable(){
            return n_oTableSet.Fields(Para.normal_rebate_type);
        }
        public Field GetGift_desc2Table(){
            return n_oTableSet.Fields(Para.gift_desc2);
        }
        public Field GetMonthly_bank_account_branch_codeTable(){
            return n_oTableSet.Fields(Para.monthly_bank_account_branch_code);
        }
        public Field GetRemarksTable(){
            return n_oTableSet.Fields(Para.remarks);
        }
        public Field GetAcceptTable(){
            return n_oTableSet.Fields(Para.accept);
        }
        public Field GetDelivery_exchangeTable(){
            return n_oTableSet.Fields(Para.delivery_exchange);
        }
        public Field GetGift_code2Table(){
            return n_oTableSet.Fields(Para.gift_code2);
        }
        public Field GetPrepayment_waiveTable(){
            return n_oTableSet.Fields(Para.prepayment_waive);
        }
        public Field GetExisting_smart_phone_imeiTable(){
            return n_oTableSet.Fields(Para.existing_smart_phone_imei);
        }
        public Field GetCust_nameTable(){
            return n_oTableSet.Fields(Para.cust_name);
        }
        public Field GetCust_typeTable(){
            return n_oTableSet.Fields(Para.cust_type);
        }
        public Field GetUpgrade_sponsorships_amountTable(){
            return n_oTableSet.Fields(Para.upgrade_sponsorships_amount);
        }
        public Field GetBill_medium_waiveTable(){
            return n_oTableSet.Fields(Para.bill_medium_waive);
        }
        public Field GetDelivery_exchange_locationTable(){
            return n_oTableSet.Fields(Para.delivery_exchange_location);
        }
        public Field GetHs_offer_type_idTable(){
            return n_oTableSet.Fields(Para.hs_offer_type_id);
        }
        public Field GetOrg_feeTable(){
            return n_oTableSet.Fields(Para.org_fee);
        }
        public Field GetRebateTable(){
            return n_oTableSet.Fields(Para.rebate);
        }
        public Field GetUpgrade_typeTable(){
            return n_oTableSet.Fields(Para.upgrade_type);
        }
        public Field GetGo_wirelessTable(){
            return n_oTableSet.Fields(Para.go_wireless);
        }
        public Field GetExtra_rebateTable(){
            return n_oTableSet.Fields(Para.extra_rebate);
        }
        public Field GetPlan_effTable(){
            return n_oTableSet.Fields(Para.plan_eff);
        }
        public Field GetExtra_rebate_amountTable(){
            return n_oTableSet.Fields(Para.extra_rebate_amount);
        }
        public Field GetCard_exp_yearTable(){
            return n_oTableSet.Fields(Para.card_exp_year);
        }
        public Field GetUpgrade_existing_contract_sdateTable(){
            return n_oTableSet.Fields(Para.upgrade_existing_contract_sdate);
        }
        public Field GetOrd_place_hkidTable(){
            return n_oTableSet.Fields(Para.ord_place_hkid);
        }
        public Field GetRegister_addressTable(){
            return n_oTableSet.Fields(Para.register_address);
        }
        public Field GetGenderTable(){
            return n_oTableSet.Fields(Para.gender);
        }
        public Field GetLob_acTable(){
            return n_oTableSet.Fields(Para.lob_ac);
        }
        public Field GetSim_mrt_noTable(){
            return n_oTableSet.Fields(Para.sim_mrt_no);
        }
        public Field GetRedemption_notice_optionTable(){
            return n_oTableSet.Fields(Para.redemption_notice_option);
        }
        public Field GetDelivery_collection_typeTable(){
            return n_oTableSet.Fields(Para.delivery_collection_type);
        }
        public Field GetAction_dateTable(){
            return n_oTableSet.Fields(Para.action_date);
        }
        public Field GetThird_party_id_typeTable(){
            return n_oTableSet.Fields(Para.third_party_id_type);
        }
        public Field GetOrg_ftgTable(){
            return n_oTableSet.Fields(Para.org_ftg);
        }
        public Field GetUpgrade_service_tenureTable(){
            return n_oTableSet.Fields(Para.upgrade_service_tenure);
        }
        public Field GetMonthly_payment_typeTable(){
            return n_oTableSet.Fields(Para.monthly_payment_type);
        }
        public Field GetContact_noTable(){
            return n_oTableSet.Fields(Para.contact_no);
        }
        public Field GetOrg_mrtTable(){
            return n_oTableSet.Fields(Para.org_mrt);
        }
        public Field GetSim_item_nameTable(){
            return n_oTableSet.Fields(Para.sim_item_name);
        }
        public Field GetPay_methodTable(){
            return n_oTableSet.Fields(Para.pay_method);
        }
        public Field GetHs_modelTable(){
            return n_oTableSet.Fields(Para.hs_model);
        }
        public Field GetGift_codeTable(){
            return n_oTableSet.Fields(Para.gift_code);
        }
        public Field GetMonthly_bank_account_hkidTable(){
            return n_oTableSet.Fields(Para.monthly_bank_account_hkid);
        }
        public Field GetExtra_offerTable(){
            return n_oTableSet.Fields(Para.extra_offer);
        }
        public Field GetMonthly_bank_account_noTable(){
            return n_oTableSet.Fields(Para.monthly_bank_account_no);
        }
        public Field GetFirst_month_license_feeTable(){
            return n_oTableSet.Fields(Para.first_month_license_fee);
        }
        public Field GetRetrieve_cntTable(){
            return n_oTableSet.Fields(Para.retrieve_cnt);
        }
        public Field GetDdateTable(){
            return n_oTableSet.Fields(Para.ddate);
        }
        public Field GetS_premium2Table(){
            return n_oTableSet.Fields(Para.s_premium2);
        }
        public Field GetMonthly_bank_account_id_typeTable(){
            return n_oTableSet.Fields(Para.monthly_bank_account_id_type);
        }
        public Field GetCard_typeTable(){
            return n_oTableSet.Fields(Para.card_type);
        }
        public Field GetNext_billTable(){
            return n_oTableSet.Fields(Para.next_bill);
        }
        public Field GetPcd_paid_go_wirelessTable(){
            return n_oTableSet.Fields(Para.pcd_paid_go_wireless);
        }
        public Field GetUpgrade_rebate_calculationTable(){
            return n_oTableSet.Fields(Para.upgrade_rebate_calculation);
        }
        public Field GetExt_place_telTable(){
            return n_oTableSet.Fields(Para.ext_place_tel);
        }
        public Field GetM_3rd_hkidTable(){
            return n_oTableSet.Fields(Para.m_3rd_hkid);
        }
        public Field GetRetention_typeTable(){
            return n_oTableSet.Fields(Para.retention_type);
        }
        public Field GetCooling_dateTable(){
            return n_oTableSet.Fields(Para.cooling_date);
        }
        public Field GetAig_giftTable(){
            return n_oTableSet.Fields(Para.aig_gift);
        }
        public Field GetCust_staff_noTable(){
            return n_oTableSet.Fields(Para.cust_staff_no);
        }
        public Field GetOrder_idTable(){
            return n_oTableSet.Fields(Para.order_id);
        }
        public Field GetFamily_nameTable(){
            return n_oTableSet.Fields(Para.family_name);
        }
        public Field GetCdateTable(){
            return n_oTableSet.Fields(Para.cdate);
        }
        public Field GetStatus_by_cs_adminTable(){
            return n_oTableSet.Fields(Para.status_by_cs_admin);
        }
        public Field GetSim_item_numberTable(){
            return n_oTableSet.Fields(Para.sim_item_number);
        }
        public Field GetVip_caseTable(){
            return n_oTableSet.Fields(Para.vip_case);
        }
        public Field GetGiven_nameTable(){
            return n_oTableSet.Fields(Para.given_name);
        }
        public Field GetLog_dateTable(){
            return n_oTableSet.Fields(Para.log_date);
        }
        public Field GetExtnTable(){
            return n_oTableSet.Fields(Para.extn);
        }
        public Field GetD_timeTable(){
            return n_oTableSet.Fields(Para.d_time);
        }
        public Field GetBank_nameTable(){
            return n_oTableSet.Fields(Para.bank_name);
        }
        public Field GetDelivery_exchange_optionTable(){
            return n_oTableSet.Fields(Para.delivery_exchange_option);
        }
        public Field GetUpgrade_service_account_noTable(){
            return n_oTableSet.Fields(Para.upgrade_service_account_no);
        }
        public Field GetAction_of_rate_plan_effectiveTable(){
            return n_oTableSet.Fields(Para.action_of_rate_plan_effective);
        }
        public Field GetM_card_noTable(){
            return n_oTableSet.Fields(Para.m_card_no);
        }
        public Field GetExisting_contract_end_dateTable(){
            return n_oTableSet.Fields(Para.existing_contract_end_date);
        }
        public Field GetCon_eff_dateTable(){
            return n_oTableSet.Fields(Para.con_eff_date);
        }
        public Field GetM_3rd_hkid2Table(){
            return n_oTableSet.Fields(Para.m_3rd_hkid2);
        }
        public Field GetAmountTable(){
            return n_oTableSet.Fields(Para.amount);
        }
        public Field GetId_typeTable(){
            return n_oTableSet.Fields(Para.id_type);
        }
        public Field GetRate_planTable(){
            return n_oTableSet.Fields(Para.rate_plan);
        }
        public Field GetChannelTable(){
            return n_oTableSet.Fields(Para.channel);
        }
        public Field GetAction_eff_dateTable(){
            return n_oTableSet.Fields(Para.action_eff_date);
        }
        public Field GetIssue_typeTable(){
            return n_oTableSet.Fields(Para.issue_type);
        }
        public Field GetFree_monTable(){
            return n_oTableSet.Fields(Para.free_mon);
        }
        public Field GetPlan_eff_dateTable(){
            return n_oTableSet.Fields(Para.plan_eff_date);
        }
        public Field GetDel_remarkTable(){
            return n_oTableSet.Fields(Para.del_remark);
        }
        public Field GetTeamcodeTable(){
            return n_oTableSet.Fields(Para.teamcode);
        }
        public Field GetStaff_nameTable(){
            return n_oTableSet.Fields(Para.staff_name);
        }
        public Field GetEdf_noTable(){
            return n_oTableSet.Fields(Para.edf_no);
        }
        public Field GetOrd_place_byTable(){
            return n_oTableSet.Fields(Para.ord_place_by);
        }
        public Field GetCancel_renewTable(){
            return n_oTableSet.Fields(Para.cancel_renew);
        }
        public Field GetPreferred_languagesTable(){
            return n_oTableSet.Fields(Para.preferred_languages);
        }
        public Field GetHkidTable(){
            return n_oTableSet.Fields(Para.hkid);
        }
        public Field GetCard_noTable(){
            return n_oTableSet.Fields(Para.card_no);
        }
        public Field GetAc_noTable(){
            return n_oTableSet.Fields(Para.ac_no);
        }
        public Field GetBill_cut_numTable(){
            return n_oTableSet.Fields(Para.bill_cut_num);
        }
        public Field GetPremiumTable(){
            return n_oTableSet.Fields(Para.premium);
        }
        public Field GetM_3rd_id_typeTable(){
            return n_oTableSet.Fields(Para.m_3rd_id_type);
        }
        public Field GetGift_imei2Table(){
            return n_oTableSet.Fields(Para.gift_imei2);
        }
        public Field GetReasonsTable(){
            return n_oTableSet.Fields(Para.reasons);
        }
        public Field GetLanguageTable(){
            return n_oTableSet.Fields(Para.language);
        }
        public Field GetRebate_amountTable(){
            return n_oTableSet.Fields(Para.rebate_amount);
        }
        public Field GetLobTable(){
            return n_oTableSet.Fields(Para.lob);
        }
        public Field GetM_3rd_contact_noTable(){
            return n_oTableSet.Fields(Para.m_3rd_contact_no);
        }
        public Field GetStaff_noTable(){
            return n_oTableSet.Fields(Para.staff_no);
        }
        public Field GetS_premium3Table(){
            return n_oTableSet.Fields(Para.s_premium3);
        }
        public Field GetSp_d_dateTable(){
            return n_oTableSet.Fields(Para.sp_d_date);
        }
        public Field GetBundle_nameTable(){
            return n_oTableSet.Fields(Para.bundle_name);
        }
        public Field GetAccessory_waiveTable(){
            return n_oTableSet.Fields(Para.accessory_waive);
        }
        public Field GetSim_item_codeTable(){
            return n_oTableSet.Fields(Para.sim_item_code);
        }
        public Field GetMonthly_bank_account_holderTable(){
            return n_oTableSet.Fields(Para.monthly_bank_account_holder);
        }
        public Field GetCard_holderTable(){
            return n_oTableSet.Fields(Para.card_holder);
        }
        #endregion
        
        #region Addtional Get & Set
        public MobileOrderVas[] GetMobileOrderVasMobileRetentionOrders(){
            return MobileOrderVasMobileRetentionOrder;
        }
        public bool SetMobileOrderVasMobileRetentionOrders(MobileOrderVas[] value) {
            MobileOrderVasMobileRetentionOrder = value;
            return true;
        }
        public global::System.Data.DataSet GetMobileOrderVasMobileRetentionOrderDataSet(){
            return MobileOrderVasMobileRetentionOrderDataSet;
        }
        public bool SetMobileOrderVasMobileRetentionOrderDataSet(global::System.Data.DataSet value) {
            MobileOrderVasMobileRetentionOrderDataSet = value;
            return true;
        }
        
        public MobileOrderAddress[] GetMobileOrderAddressMobileRetentionOrders(){
            return MobileOrderAddressMobileRetentionOrder;
        }
        public bool SetMobileOrderAddressMobileRetentionOrders(MobileOrderAddress[] value) {
            MobileOrderAddressMobileRetentionOrder = value;
            return true;
        }
        public global::System.Data.DataSet GetMobileOrderAddressMobileRetentionOrderDataSet(){
            return MobileOrderAddressMobileRetentionOrderDataSet;
        }
        public bool SetMobileOrderAddressMobileRetentionOrderDataSet(global::System.Data.DataSet value) {
            MobileOrderAddressMobileRetentionOrderDataSet = value;
            return true;
        }
        
        public MobileOrderMNPDetail[] GetMobileOrderMNPDetailMobileRetentionOrders(){
            return MobileOrderMNPDetailMobileRetentionOrder;
        }
        public bool SetMobileOrderMNPDetailMobileRetentionOrders(MobileOrderMNPDetail[] value) {
            MobileOrderMNPDetailMobileRetentionOrder = value;
            return true;
        }
        public global::System.Data.DataSet GetMobileOrderMNPDetailMobileRetentionOrderDataSet(){
            return MobileOrderMNPDetailMobileRetentionOrderDataSet;
        }
        public bool SetMobileOrderMNPDetailMobileRetentionOrderDataSet(global::System.Data.DataSet value) {
            MobileOrderMNPDetailMobileRetentionOrderDataSet = value;
            return true;
        }
        
        public MobileOrderThreeParty[] GetMobileOrderThreePartyMobileRetentionOrders(){
            return MobileOrderThreePartyMobileRetentionOrder;
        }
        public bool SetMobileOrderThreePartyMobileRetentionOrders(MobileOrderThreeParty[] value) {
            MobileOrderThreePartyMobileRetentionOrder = value;
            return true;
        }
        public global::System.Data.DataSet GetMobileOrderThreePartyMobileRetentionOrderDataSet(){
            return MobileOrderThreePartyMobileRetentionOrderDataSet;
        }
        public bool SetMobileOrderThreePartyMobileRetentionOrderDataSet(global::System.Data.DataSet value) {
            MobileOrderThreePartyMobileRetentionOrderDataSet = value;
            return true;
        }
        
        #endregion
        
        #region Add & Del
        
        public MobileOrderVas AddMobileOrderVasMobileRetentionOrders(global::System.Nullable<int> x_oId,bool bSave) {
            for(int i=0; i<n_oMobileOrderVasMobileRetentionOrder.Length; i++){
                if(x_oId == n_oMobileOrderVasMobileRetentionOrder[i].GetId()){ return null; }
            }
            MobileOrderVas _oMobileOrderVasMobileRetentionOrder = new MobileOrderVas(this.n_oDB,x_oId);
            _oMobileOrderVasMobileRetentionOrder.SetOrder_id(this.n_iOrder_id);
            if(bSave){_oMobileOrderVasMobileRetentionOrder.Save();}
            MobileOrderVas[] _oMobileOrderVasMobileRetentionOrder_tmp = new MobileOrderVas[n_oMobileOrderVasMobileRetentionOrder.Length + 1];
            n_oMobileOrderVasMobileRetentionOrder.CopyTo(_oMobileOrderVasMobileRetentionOrder_tmp, 0);
            _oMobileOrderVasMobileRetentionOrder_tmp[n_oMobileOrderVasMobileRetentionOrder.Length] = _oMobileOrderVasMobileRetentionOrder;
            n_oMobileOrderVasMobileRetentionOrder = _oMobileOrderVasMobileRetentionOrder_tmp;
            return _oMobileOrderVasMobileRetentionOrder;
        }
        
        public bool DelMobileOrderVasMobileRetentionOrders(global::System.Nullable<int> x_oId) {
            for(int i=0; i<n_oMobileOrderVasMobileRetentionOrder.Length; i++)
            if(x_oId == n_oMobileOrderVasMobileRetentionOrder[i].GetId()) {
                if(n_oMobileOrderVasMobileRetentionOrder[i].Delete()) {
                    MobileOrderVas[] _oMobileOrderVasMobileRetentionOrder = new MobileOrderVas[n_oMobileOrderVasMobileRetentionOrder.Length - 1];
                    for(int j=0; j<i; j++)
                    _oMobileOrderVasMobileRetentionOrder[j] = n_oMobileOrderVasMobileRetentionOrder[j];
                    for(int j=i+1; j<n_oMobileOrderVasMobileRetentionOrder.Length; j++) {
                        _oMobileOrderVasMobileRetentionOrder[j-1] = n_oMobileOrderVasMobileRetentionOrder[j];
                    }
                    n_oMobileOrderVasMobileRetentionOrder = _oMobileOrderVasMobileRetentionOrder;
                    return true;
                }
                break;
            }
            return false;
        }
        
        public bool DelMobileOrderVasMobileRetentionOrder(MobileOrderVas x_oMobileOrderVasMobileRetentionOrder) {
            if(x_oMobileOrderVasMobileRetentionOrder == null){return false;}
            return DelMobileOrderVasMobileRetentionOrders(x_oMobileOrderVasMobileRetentionOrder.GetId());
        }
        
        public bool DelAllMobileOrderVasMobileRetentionOrder()
        {
            if (n_iOrder_id==null) { return false; }
            string _filter=" [MobileOrderVas].[order_id]='"+n_iOrder_id.ToString()+"'";
            if(MobileOrderVasRepository.DeleteFilter(this.n_oDB,_filter)){
                n_oMobileOrderVasMobileRetentionOrder=null;
            }
            return true;
        }
        
        
        public MobileOrderAddress AddMobileOrderAddressMobileRetentionOrders(global::System.Nullable<int> x_iOrder_id,string x_oAddress_type,bool bSave) {
            for(int i=0; i<n_oMobileOrderAddressMobileRetentionOrder.Length; i++){
                if(x_iOrder_id == n_oMobileOrderAddressMobileRetentionOrder[i].GetOrder_id()){ return null; }
                if(x_oAddress_type == n_oMobileOrderAddressMobileRetentionOrder[i].GetAddress_type()){ return null; }
            }
            MobileOrderAddress _oMobileOrderAddressMobileRetentionOrder = new MobileOrderAddress(this.n_oDB,x_iOrder_id,x_oAddress_type);
            _oMobileOrderAddressMobileRetentionOrder.SetOrder_id(this.n_iOrder_id);
            if(bSave){_oMobileOrderAddressMobileRetentionOrder.Save();}
            MobileOrderAddress[] _oMobileOrderAddressMobileRetentionOrder_tmp = new MobileOrderAddress[n_oMobileOrderAddressMobileRetentionOrder.Length + 1];
            n_oMobileOrderAddressMobileRetentionOrder.CopyTo(_oMobileOrderAddressMobileRetentionOrder_tmp, 0);
            _oMobileOrderAddressMobileRetentionOrder_tmp[n_oMobileOrderAddressMobileRetentionOrder.Length] = _oMobileOrderAddressMobileRetentionOrder;
            n_oMobileOrderAddressMobileRetentionOrder = _oMobileOrderAddressMobileRetentionOrder_tmp;
            return _oMobileOrderAddressMobileRetentionOrder;
        }
        
        public bool DelMobileOrderAddressMobileRetentionOrders(global::System.Nullable<int> x_iOrder_id,string x_oAddress_type) {
            for(int i=0; i<n_oMobileOrderAddressMobileRetentionOrder.Length; i++)
            if(x_oAddress_type == n_oMobileOrderAddressMobileRetentionOrder[i].GetAddress_type()) {
                if(n_oMobileOrderAddressMobileRetentionOrder[i].Delete()) {
                    MobileOrderAddress[] _oMobileOrderAddressMobileRetentionOrder = new MobileOrderAddress[n_oMobileOrderAddressMobileRetentionOrder.Length - 1];
                    for(int j=0; j<i; j++)
                    _oMobileOrderAddressMobileRetentionOrder[j] = n_oMobileOrderAddressMobileRetentionOrder[j];
                    for(int j=i+1; j<n_oMobileOrderAddressMobileRetentionOrder.Length; j++) {
                        _oMobileOrderAddressMobileRetentionOrder[j-1] = n_oMobileOrderAddressMobileRetentionOrder[j];
                    }
                    n_oMobileOrderAddressMobileRetentionOrder = _oMobileOrderAddressMobileRetentionOrder;
                    return true;
                }
                break;
            }
            return false;
        }
        
        public bool DelMobileOrderAddressMobileRetentionOrder(MobileOrderAddress x_oMobileOrderAddressMobileRetentionOrder) {
            if(x_oMobileOrderAddressMobileRetentionOrder == null){return false;}
            return DelMobileOrderAddressMobileRetentionOrders(x_oMobileOrderAddressMobileRetentionOrder.GetOrder_id(),x_oMobileOrderAddressMobileRetentionOrder.GetAddress_type());
        }
        
        public bool DelAllMobileOrderAddressMobileRetentionOrder()
        {
            if (n_iOrder_id==null) { return false; }
            string _filter=" [MobileOrderAddress].[order_id]='"+n_iOrder_id.ToString()+"'";
            if(MobileOrderAddressRepository.DeleteFilter(this.n_oDB,_filter)){
                n_oMobileOrderAddressMobileRetentionOrder=null;
            }
            return true;
        }
        
        
        public MobileOrderAddress AddMobileOrderAddressMobileRetentionOrders(global::System.Nullable<long> x_oAddress_id,bool bSave) {
            for(int i=0; i<n_oMobileOrderAddressMobileRetentionOrder.Length; i++){
                if(x_oAddress_id == n_oMobileOrderAddressMobileRetentionOrder[i].GetAddress_id()){ return null; }
            }
            MobileOrderAddress _oMobileOrderAddressMobileRetentionOrder = new MobileOrderAddress(this.n_oDB,x_oAddress_id);
            _oMobileOrderAddressMobileRetentionOrder.SetOrder_id(this.n_iOrder_id);
            if(bSave){_oMobileOrderAddressMobileRetentionOrder.Save();}
            MobileOrderAddress[] _oMobileOrderAddressMobileRetentionOrder_tmp = new MobileOrderAddress[n_oMobileOrderAddressMobileRetentionOrder.Length + 1];
            n_oMobileOrderAddressMobileRetentionOrder.CopyTo(_oMobileOrderAddressMobileRetentionOrder_tmp, 0);
            _oMobileOrderAddressMobileRetentionOrder_tmp[n_oMobileOrderAddressMobileRetentionOrder.Length] = _oMobileOrderAddressMobileRetentionOrder;
            n_oMobileOrderAddressMobileRetentionOrder = _oMobileOrderAddressMobileRetentionOrder_tmp;
            return _oMobileOrderAddressMobileRetentionOrder;
        }
        
        public bool DelMobileOrderAddressMobileRetentionOrders(global::System.Nullable<long> x_oAddress_id) {
            for(int i=0; i<n_oMobileOrderAddressMobileRetentionOrder.Length; i++)
            if(x_oAddress_id == n_oMobileOrderAddressMobileRetentionOrder[i].GetAddress_id()) {
                if(n_oMobileOrderAddressMobileRetentionOrder[i].Delete()) {
                    MobileOrderAddress[] _oMobileOrderAddressMobileRetentionOrder = new MobileOrderAddress[n_oMobileOrderAddressMobileRetentionOrder.Length - 1];
                    for(int j=0; j<i; j++)
                    _oMobileOrderAddressMobileRetentionOrder[j] = n_oMobileOrderAddressMobileRetentionOrder[j];
                    for(int j=i+1; j<n_oMobileOrderAddressMobileRetentionOrder.Length; j++) {
                        _oMobileOrderAddressMobileRetentionOrder[j-1] = n_oMobileOrderAddressMobileRetentionOrder[j];
                    }
                    n_oMobileOrderAddressMobileRetentionOrder = _oMobileOrderAddressMobileRetentionOrder;
                    return true;
                }
                break;
            }
            return false;
        }
        


        
        
        public MobileOrderMNPDetail AddMobileOrderMNPDetailMobileRetentionOrders(global::System.Nullable<long> x_oMnp_id,bool bSave) {
            for(int i=0; i<n_oMobileOrderMNPDetailMobileRetentionOrder.Length; i++){
                if(x_oMnp_id == n_oMobileOrderMNPDetailMobileRetentionOrder[i].GetMnp_id()){ return null; }
            }
            MobileOrderMNPDetail _oMobileOrderMNPDetailMobileRetentionOrder = new MobileOrderMNPDetail(this.n_oDB,x_oMnp_id);
            _oMobileOrderMNPDetailMobileRetentionOrder.SetOrder_id(this.n_iOrder_id);
            if(bSave){_oMobileOrderMNPDetailMobileRetentionOrder.Save();}
            MobileOrderMNPDetail[] _oMobileOrderMNPDetailMobileRetentionOrder_tmp = new MobileOrderMNPDetail[n_oMobileOrderMNPDetailMobileRetentionOrder.Length + 1];
            n_oMobileOrderMNPDetailMobileRetentionOrder.CopyTo(_oMobileOrderMNPDetailMobileRetentionOrder_tmp, 0);
            _oMobileOrderMNPDetailMobileRetentionOrder_tmp[n_oMobileOrderMNPDetailMobileRetentionOrder.Length] = _oMobileOrderMNPDetailMobileRetentionOrder;
            n_oMobileOrderMNPDetailMobileRetentionOrder = _oMobileOrderMNPDetailMobileRetentionOrder_tmp;
            return _oMobileOrderMNPDetailMobileRetentionOrder;
        }
        
        public bool DelMobileOrderMNPDetailMobileRetentionOrders(global::System.Nullable<long> x_oMnp_id) {
            for(int i=0; i<n_oMobileOrderMNPDetailMobileRetentionOrder.Length; i++)
            if(x_oMnp_id == n_oMobileOrderMNPDetailMobileRetentionOrder[i].GetMnp_id()) {
                if(n_oMobileOrderMNPDetailMobileRetentionOrder[i].Delete()) {
                    MobileOrderMNPDetail[] _oMobileOrderMNPDetailMobileRetentionOrder = new MobileOrderMNPDetail[n_oMobileOrderMNPDetailMobileRetentionOrder.Length - 1];
                    for(int j=0; j<i; j++)
                    _oMobileOrderMNPDetailMobileRetentionOrder[j] = n_oMobileOrderMNPDetailMobileRetentionOrder[j];
                    for(int j=i+1; j<n_oMobileOrderMNPDetailMobileRetentionOrder.Length; j++) {
                        _oMobileOrderMNPDetailMobileRetentionOrder[j-1] = n_oMobileOrderMNPDetailMobileRetentionOrder[j];
                    }
                    n_oMobileOrderMNPDetailMobileRetentionOrder = _oMobileOrderMNPDetailMobileRetentionOrder;
                    return true;
                }
                break;
            }
            return false;
        }
        
        public bool DelMobileOrderMNPDetailMobileRetentionOrder(MobileOrderMNPDetail x_oMobileOrderMNPDetailMobileRetentionOrder) {
            if(x_oMobileOrderMNPDetailMobileRetentionOrder == null){return false;}
            return DelMobileOrderMNPDetailMobileRetentionOrders(x_oMobileOrderMNPDetailMobileRetentionOrder.GetMnp_id());
        }
        
        public bool DelAllMobileOrderMNPDetailMobileRetentionOrder()
        {
            if (n_iOrder_id==null) { return false; }
            string _filter=" [MobileOrderMNPDetail].[order_id]='"+n_iOrder_id.ToString()+"'";
            if(MobileOrderMNPDetailRepository.DeleteFilter(this.n_oDB,_filter)){
                n_oMobileOrderMNPDetailMobileRetentionOrder=null;
            }
            return true;
        }
        
        
        public MobileOrderThreeParty AddMobileOrderThreePartyMobileRetentionOrders(global::System.Nullable<long> x_oTpy_id,bool bSave) {
            for(int i=0; i<n_oMobileOrderThreePartyMobileRetentionOrder.Length; i++){
                if(x_oTpy_id == n_oMobileOrderThreePartyMobileRetentionOrder[i].GetTpy_id()){ return null; }
            }
            MobileOrderThreeParty _oMobileOrderThreePartyMobileRetentionOrder = new MobileOrderThreeParty(this.n_oDB,x_oTpy_id);
            _oMobileOrderThreePartyMobileRetentionOrder.SetOrder_id(this.n_iOrder_id);
            if(bSave){_oMobileOrderThreePartyMobileRetentionOrder.Save();}
            MobileOrderThreeParty[] _oMobileOrderThreePartyMobileRetentionOrder_tmp = new MobileOrderThreeParty[n_oMobileOrderThreePartyMobileRetentionOrder.Length + 1];
            n_oMobileOrderThreePartyMobileRetentionOrder.CopyTo(_oMobileOrderThreePartyMobileRetentionOrder_tmp, 0);
            _oMobileOrderThreePartyMobileRetentionOrder_tmp[n_oMobileOrderThreePartyMobileRetentionOrder.Length] = _oMobileOrderThreePartyMobileRetentionOrder;
            n_oMobileOrderThreePartyMobileRetentionOrder = _oMobileOrderThreePartyMobileRetentionOrder_tmp;
            return _oMobileOrderThreePartyMobileRetentionOrder;
        }
        
        public bool DelMobileOrderThreePartyMobileRetentionOrders(global::System.Nullable<long> x_oTpy_id) {
            for(int i=0; i<n_oMobileOrderThreePartyMobileRetentionOrder.Length; i++)
            if(x_oTpy_id == n_oMobileOrderThreePartyMobileRetentionOrder[i].GetTpy_id()) {
                if(n_oMobileOrderThreePartyMobileRetentionOrder[i].Delete()) {
                    MobileOrderThreeParty[] _oMobileOrderThreePartyMobileRetentionOrder = new MobileOrderThreeParty[n_oMobileOrderThreePartyMobileRetentionOrder.Length - 1];
                    for(int j=0; j<i; j++)
                    _oMobileOrderThreePartyMobileRetentionOrder[j] = n_oMobileOrderThreePartyMobileRetentionOrder[j];
                    for(int j=i+1; j<n_oMobileOrderThreePartyMobileRetentionOrder.Length; j++) {
                        _oMobileOrderThreePartyMobileRetentionOrder[j-1] = n_oMobileOrderThreePartyMobileRetentionOrder[j];
                    }
                    n_oMobileOrderThreePartyMobileRetentionOrder = _oMobileOrderThreePartyMobileRetentionOrder;
                    return true;
                }
                break;
            }
            return false;
        }
        
        public bool DelMobileOrderThreePartyMobileRetentionOrder(MobileOrderThreeParty x_oMobileOrderThreePartyMobileRetentionOrder) {
            if(x_oMobileOrderThreePartyMobileRetentionOrder == null){return false;}
            return DelMobileOrderThreePartyMobileRetentionOrders(x_oMobileOrderThreePartyMobileRetentionOrder.GetTpy_id());
        }
        
        public bool DelAllMobileOrderThreePartyMobileRetentionOrder()
        {
            if (n_iOrder_id==null) { return false; }
            string _filter=" [MobileOrderThreeParty].[order_id]='"+n_iOrder_id.ToString()+"'";
            if(MobileOrderThreePartyRepository.DeleteFilter(this.n_oDB,_filter)){
                n_oMobileOrderThreePartyMobileRetentionOrder=null;
            }
            return true;
        }
        
        #endregion
        
        #region CheckNullable
        
        /// <summary>
        /// Summary description for Nullable Columns
        /// </summary>
        
        public bool CheckNullable(string x_sColumnName)
        {
            if ("".Equals(x_sColumnName)) { return false; }
            return n_oTableSet.Fields(x_sColumnName).IsNullable;
        }
        #endregion
        
        #region Equal
        
        /// <summary>
        /// Summary description for Equal Check
        /// </summary>
        
        public bool EqualID(MobileRetentionOrder x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iOrder_id.Equals(x_oObj.order_id)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(MobileRetentionOrder x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_sGift_imei.Equals(x_oObj.gift_imei)){ return false; }
            if(!this.n_sS_premium4.Equals(x_oObj.s_premium4)){ return false; }
            if(!this.n_sUpgrade_existing_customer_type.Equals(x_oObj.upgrade_existing_customer_type)){ return false; }
            if(!this.n_sGift_desc4.Equals(x_oObj.gift_desc4)){ return false; }
            if(!this.n_sAccessory_desc.Equals(x_oObj.accessory_desc)){ return false; }
            if(!this.n_sStaff_name.Equals(x_oObj.staff_name)){ return false; }
            if(!this.n_sAction_required.Equals(x_oObj.action_required)){ return false; }
            if(!this.n_dVas_eff_date.Equals(x_oObj.vas_eff_date)){ return false; }
            if(!this.n_sMonthly_bank_account_bank_code.Equals(x_oObj.monthly_bank_account_bank_code)){ return false; }
            if(!this.n_sSim_item_number.Equals(x_oObj.sim_item_number)){ return false; }
            if(!this.n_sSpecial_handling_dummy_code.Equals(x_oObj.special_handling_dummy_code)){ return false; }
            if(!this.n_sCard_no.Equals(x_oObj.card_no)){ return false; }
            if(!this.n_sM_card_exp_year.Equals(x_oObj.m_card_exp_year)){ return false; }
            if(!this.n_sBill_medium_email.Equals(x_oObj.bill_medium_email)){ return false; }
            if(!this.n_sRemarks2PY.Equals(x_oObj.remarks2PY)){ return false; }
            if(!this.n_sTrade_field.Equals(x_oObj.trade_field)){ return false; }
            if(!this.n_sOrd_place_tel.Equals(x_oObj.ord_place_tel)){ return false; }
            if(!this.n_sAction_of_rate_plan_effective.Equals(x_oObj.action_of_rate_plan_effective)){ return false; }
            if(!this.n_sCooling_offer.Equals(x_oObj.cooling_offer)){ return false; }
            if(!this.n_sUpgrade_handset_offer_rebate_schedule.Equals(x_oObj.upgrade_handset_offer_rebate_schedule)){ return false; }
            if(!this.n_sChange_payment_type.Equals(x_oObj.change_payment_type)){ return false; }
            if(!this.n_dDate_of_birth.Equals(x_oObj.date_of_birth)){ return false; }
            if(!this.n_sContact_person.Equals(x_oObj.contact_person)){ return false; }
            if(!this.n_sExtra_d_charge.Equals(x_oObj.extra_d_charge)){ return false; }
            if(!this.n_sTl_name.Equals(x_oObj.tl_name)){ return false; }
            if(!this.n_bFast_start.Equals(x_oObj.fast_start)){ return false; }
            if(!this.n_sSp_ref_no.Equals(x_oObj.sp_ref_no)){ return false; }
            if(!this.n_dEdate.Equals(x_oObj.edate)){ return false; }
            if(!this.n_sExist_cust_plan.Equals(x_oObj.exist_cust_plan)){ return false; }
            if(!this.n_sOrd_place_rel.Equals(x_oObj.ord_place_rel)){ return false; }
            if(!this.n_iMrt_no.Equals(x_oObj.mrt_no)){ return false; }
            if(!this.n_sImei_no.Equals(x_oObj.imei_no)){ return false; }
            if(!this.n_sExisting_smart_phone_model.Equals(x_oObj.existing_smart_phone_model)){ return false; }
            if(!this.n_sBank_code.Equals(x_oObj.bank_code)){ return false; }
            if(!this.n_sPos_ref_no.Equals(x_oObj.pos_ref_no)){ return false; }
            if(!this.n_dBill_cut_date.Equals(x_oObj.bill_cut_date)){ return false; }
            if(!this.n_sGift_imei3.Equals(x_oObj.gift_imei3)){ return false; }
            if(!this.n_sExist_plan.Equals(x_oObj.exist_plan)){ return false; }
            if(!this.n_bWaive.Equals(x_oObj.waive)){ return false; }
            if(!this.n_sProgram.Equals(x_oObj.program)){ return false; }
            if(!this.n_sFirst_month_fee.Equals(x_oObj.first_month_fee)){ return false; }
            if(!this.n_sR_offer.Equals(x_oObj.r_offer)){ return false; }
            if(!this.n_sCid.Equals(x_oObj.cid)){ return false; }
            if(!this.n_sDid.Equals(x_oObj.did)){ return false; }
            if(!this.n_sFtg_tenure.Equals(x_oObj.ftg_tenure)){ return false; }
            if(!this.n_sCon_per.Equals(x_oObj.con_per)){ return false; }
            if(!this.n_sGift_code4.Equals(x_oObj.gift_code4)){ return false; }
            if(!this.n_sEasywatch_type.Equals(x_oObj.easywatch_type)){ return false; }
            if(!this.n_sSms_mrt.Equals(x_oObj.sms_mrt)){ return false; }
            if(!this.n_sMonthly_payment_method.Equals(x_oObj.monthly_payment_method)){ return false; }
            if(!this.n_sRemarks2EDF.Equals(x_oObj.remarks2EDF)){ return false; }
            if(!this.n_sGift_desc3.Equals(x_oObj.gift_desc3)){ return false; }
            if(!this.n_sGift_imei4.Equals(x_oObj.gift_imei4)){ return false; }
            if(!this.n_sMonthly_bank_account_hkid2.Equals(x_oObj.monthly_bank_account_hkid2)){ return false; }
            if(!this.n_dD_date.Equals(x_oObj.d_date)){ return false; }
            if(!this.n_sGift_desc.Equals(x_oObj.gift_desc)){ return false; }
            if(!this.n_sPool.Equals(x_oObj.pool)){ return false; }
            if(!this.n_lCn_mrt_no.Equals(x_oObj.cn_mrt_no)){ return false; }
            if(!this.n_sAccessory_imei.Equals(x_oObj.accessory_imei)){ return false; }
            if(!this.n_sThird_party_credit_card.Equals(x_oObj.third_party_credit_card)){ return false; }
            if(!this.n_sSpecial_approval.Equals(x_oObj.special_approval)){ return false; }
            if(!this.n_dUpgrade_existing_contract_edate.Equals(x_oObj.upgrade_existing_contract_edate)){ return false; }
            if(!this.n_sAccessory_code.Equals(x_oObj.accessory_code)){ return false; }
            if(!this.n_sS_premium.Equals(x_oObj.s_premium)){ return false; }
            if(!this.n_sRef_staff_no.Equals(x_oObj.ref_staff_no)){ return false; }
            if(!this.n_sAccessory_price.Equals(x_oObj.accessory_price)){ return false; }
            if(!this.n_sM_card_exp_month.Equals(x_oObj.m_card_exp_month)){ return false; }
            if(!this.n_sInstallment_period.Equals(x_oObj.installment_period)){ return false; }
            if(!this.n_sM_card_type.Equals(x_oObj.m_card_type)){ return false; }
            if(!this.n_sEasywatch_ord_id.Equals(x_oObj.easywatch_ord_id)){ return false; }
            if(!this.n_bNormal_rebate.Equals(x_oObj.normal_rebate)){ return false; }
            if(!this.n_sM_rebate_amount.Equals(x_oObj.m_rebate_amount)){ return false; }
            if(!this.n_sM_card_holder2.Equals(x_oObj.m_card_holder2)){ return false; }
            if(!this.n_sMonthly_bank_account_holder.Equals(x_oObj.monthly_bank_account_holder)){ return false; }
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_sS_premium1.Equals(x_oObj.s_premium1)){ return false; }
            if(!this.n_sCard_exp_month.Equals(x_oObj.card_exp_month)){ return false; }
            if(!this.n_sOb_program_id.Equals(x_oObj.ob_program_id)){ return false; }
            if(!this.n_sSku.Equals(x_oObj.sku)){ return false; }
            if(!this.n_sSalesmancode.Equals(x_oObj.salesmancode)){ return false; }
            if(!this.n_sGo_wireless_package_code.Equals(x_oObj.go_wireless_package_code)){ return false; }
            if(!this.n_sLob.Equals(x_oObj.lob)){ return false; }
            if(!this.n_sRef_salesmancode.Equals(x_oObj.ref_salesmancode)){ return false; }
            if(!this.n_sThird_party_hkid.Equals(x_oObj.third_party_hkid)){ return false; }
            if(!this.n_sUpgrade_existing_pccw_customer.Equals(x_oObj.upgrade_existing_pccw_customer)){ return false; }
            if(!this.n_sD_address.Equals(x_oObj.d_address)){ return false; }
            if(!this.n_sUpgrade_registered_mobile_no.Equals(x_oObj.upgrade_registered_mobile_no)){ return false; }
            if(!this.n_sGift_code3.Equals(x_oObj.gift_code3)){ return false; }
            if(!this.n_sNormal_rebate_type.Equals(x_oObj.normal_rebate_type)){ return false; }
            if(!this.n_sGift_desc2.Equals(x_oObj.gift_desc2)){ return false; }
            if(!this.n_sMonthly_bank_account_branch_code.Equals(x_oObj.monthly_bank_account_branch_code)){ return false; }
            if(!this.n_sRemarks.Equals(x_oObj.remarks)){ return false; }
            if(!this.n_sAccept.Equals(x_oObj.accept)){ return false; }
            if(!this.n_sDelivery_exchange.Equals(x_oObj.delivery_exchange)){ return false; }
            if(!this.n_sGift_code2.Equals(x_oObj.gift_code2)){ return false; }
            if(!this.n_bPrepayment_waive.Equals(x_oObj.prepayment_waive)){ return false; }
            if(!this.n_sExisting_smart_phone_imei.Equals(x_oObj.existing_smart_phone_imei)){ return false; }
            if(!this.n_sCust_name.Equals(x_oObj.cust_name)){ return false; }
            if(!this.n_sUpgrade_sponsorships_amount.Equals(x_oObj.upgrade_sponsorships_amount)){ return false; }
            if(!this.n_bBill_medium_waive.Equals(x_oObj.bill_medium_waive)){ return false; }
            if(!this.n_sDelivery_exchange_location.Equals(x_oObj.delivery_exchange_location)){ return false; }
            if(!this.n_iHs_offer_type_id.Equals(x_oObj.hs_offer_type_id)){ return false; }
            if(!this.n_sExtra_rebate_amount.Equals(x_oObj.extra_rebate_amount)){ return false; }
            if(!this.n_sRebate.Equals(x_oObj.rebate)){ return false; }
            if(!this.n_sUpgrade_type.Equals(x_oObj.upgrade_type)){ return false; }
            if(!this.n_sGo_wireless.Equals(x_oObj.go_wireless)){ return false; }
            if(!this.n_sExtra_rebate.Equals(x_oObj.extra_rebate)){ return false; }
            if(!this.n_sPlan_eff.Equals(x_oObj.plan_eff)){ return false; }
            if(!this.n_sCard_exp_year.Equals(x_oObj.card_exp_year)){ return false; }
            if(!this.n_dUpgrade_existing_contract_sdate.Equals(x_oObj.upgrade_existing_contract_sdate)){ return false; }
            if(!this.n_sOrd_place_hkid.Equals(x_oObj.ord_place_hkid)){ return false; }
            if(!this.n_sRegister_address.Equals(x_oObj.register_address)){ return false; }
            if(!this.n_sGender.Equals(x_oObj.gender)){ return false; }
            if(!this.n_sLob_ac.Equals(x_oObj.lob_ac)){ return false; }
            if(!this.n_iSim_mrt_no.Equals(x_oObj.sim_mrt_no)){ return false; }
            if(!this.n_sRedemption_notice_option.Equals(x_oObj.redemption_notice_option)){ return false; }
            if(!this.n_sDelivery_collection_type.Equals(x_oObj.delivery_collection_type)){ return false; }
            if(!this.n_dAction_date.Equals(x_oObj.action_date)){ return false; }
            if(!this.n_sThird_party_id_type.Equals(x_oObj.third_party_id_type)){ return false; }
            if(!this.n_sOrg_ftg.Equals(x_oObj.org_ftg)){ return false; }
            if(!this.n_sUpgrade_service_tenure.Equals(x_oObj.upgrade_service_tenure)){ return false; }
            if(!this.n_sMonthly_payment_type.Equals(x_oObj.monthly_payment_type)){ return false; }
            if(!this.n_sContact_no.Equals(x_oObj.contact_no)){ return false; }
            if(!this.n_iOrg_mrt.Equals(x_oObj.org_mrt)){ return false; }
            if(!this.n_sSim_item_name.Equals(x_oObj.sim_item_name)){ return false; }
            if(!this.n_sPay_method.Equals(x_oObj.pay_method)){ return false; }
            if(!this.n_sHs_model.Equals(x_oObj.hs_model)){ return false; }
            if(!this.n_sGift_code.Equals(x_oObj.gift_code)){ return false; }
            if(!this.n_sMonthly_bank_account_hkid.Equals(x_oObj.monthly_bank_account_hkid)){ return false; }
            if(!this.n_sExtra_offer.Equals(x_oObj.extra_offer)){ return false; }
            if(!this.n_sMonthly_bank_account_no.Equals(x_oObj.monthly_bank_account_no)){ return false; }
            if(!this.n_sFirst_month_license_fee.Equals(x_oObj.first_month_license_fee)){ return false; }
            if(!this.n_iRetrieve_cnt.Equals(x_oObj.retrieve_cnt)){ return false; }
            if(!this.n_dDdate.Equals(x_oObj.ddate)){ return false; }
            if(!this.n_sS_premium2.Equals(x_oObj.s_premium2)){ return false; }
            if(!this.n_sMonthly_bank_account_id_type.Equals(x_oObj.monthly_bank_account_id_type)){ return false; }
            if(!this.n_sCard_type.Equals(x_oObj.card_type)){ return false; }
            if(!this.n_bNext_bill.Equals(x_oObj.next_bill)){ return false; }
            if(!this.n_bPcd_paid_go_wireless.Equals(x_oObj.pcd_paid_go_wireless)){ return false; }
            if(!this.n_sUpgrade_rebate_calculation.Equals(x_oObj.upgrade_rebate_calculation)){ return false; }
            if(!this.n_sExt_place_tel.Equals(x_oObj.ext_place_tel)){ return false; }
            if(!this.n_sM_3rd_hkid.Equals(x_oObj.m_3rd_hkid)){ return false; }
            if(!this.n_sRetention_type.Equals(x_oObj.retention_type)){ return false; }
            if(!this.n_dCooling_date.Equals(x_oObj.cooling_date)){ return false; }
            if(!this.n_sAig_gift.Equals(x_oObj.aig_gift)){ return false; }
            if(!this.n_sCust_staff_no.Equals(x_oObj.cust_staff_no)){ return false; }
            if(!this.n_iOrder_id.Equals(x_oObj.order_id)){ return false; }
            if(!this.n_sFamily_name.Equals(x_oObj.family_name)){ return false; }
            if(!this.n_dCdate.Equals(x_oObj.cdate)){ return false; }
            if(!this.n_sStatus_by_cs_admin.Equals(x_oObj.status_by_cs_admin)){ return false; }
            if(!this.n_sGiven_name.Equals(x_oObj.given_name)){ return false; }
            if(!this.n_sVip_case.Equals(x_oObj.vip_case)){ return false; }
            if(!this.n_sOrg_fee.Equals(x_oObj.org_fee)){ return false; }
            if(!this.n_sS_premium3.Equals(x_oObj.s_premium3)){ return false; }
            if(!this.n_dLog_date.Equals(x_oObj.log_date)){ return false; }
            if(!this.n_sExtn.Equals(x_oObj.extn)){ return false; }
            if(!this.n_sD_time.Equals(x_oObj.d_time)){ return false; }
            if(!this.n_sBank_name.Equals(x_oObj.bank_name)){ return false; }
            if(!this.n_sDelivery_exchange_option.Equals(x_oObj.delivery_exchange_option)){ return false; }
            if(!this.n_sUpgrade_service_account_no.Equals(x_oObj.upgrade_service_account_no)){ return false; }
            if(!this.n_iOld_ord_id.Equals(x_oObj.old_ord_id)){ return false; }
            if(!this.n_sM_card_no.Equals(x_oObj.m_card_no)){ return false; }
            if(!this.n_sExisting_contract_end_date.Equals(x_oObj.existing_contract_end_date)){ return false; }
            if(!this.n_dCon_eff_date.Equals(x_oObj.con_eff_date)){ return false; }
            if(!this.n_sM_3rd_hkid2.Equals(x_oObj.m_3rd_hkid2)){ return false; }
            if(!this.n_sAmount.Equals(x_oObj.amount)){ return false; }
            if(!this.n_sM_3rd_id_type.Equals(x_oObj.m_3rd_id_type)){ return false; }
            if(!this.n_sId_type.Equals(x_oObj.id_type)){ return false; }
            if(!this.n_sRate_plan.Equals(x_oObj.rate_plan)){ return false; }
            if(!this.n_sChannel.Equals(x_oObj.channel)){ return false; }
            if(!this.n_dAction_eff_date.Equals(x_oObj.action_eff_date)){ return false; }
            if(!this.n_sIssue_type.Equals(x_oObj.issue_type)){ return false; }
            if(!this.n_sFree_mon.Equals(x_oObj.free_mon)){ return false; }
            if(!this.n_dPlan_eff_date.Equals(x_oObj.plan_eff_date)){ return false; }
            if(!this.n_sTeamcode.Equals(x_oObj.teamcode)){ return false; }
            if(!this.n_sBill_medium.Equals(x_oObj.bill_medium)){ return false; }
            if(!this.n_sEdf_no.Equals(x_oObj.edf_no)){ return false; }
            if(!this.n_sOrd_place_by.Equals(x_oObj.ord_place_by)){ return false; }
            if(!this.n_sCancel_renew.Equals(x_oObj.cancel_renew)){ return false; }
            if(!this.n_sPreferred_languages.Equals(x_oObj.preferred_languages)){ return false; }
            if(!this.n_sHkid.Equals(x_oObj.hkid)){ return false; }
            if(!this.n_sCard_holder.Equals(x_oObj.card_holder)){ return false; }
            if(!this.n_sAc_no.Equals(x_oObj.ac_no)){ return false; }
            if(!this.n_iBill_cut_num.Equals(x_oObj.bill_cut_num)){ return false; }
            if(!this.n_sPremium.Equals(x_oObj.premium)){ return false; }
            if(!this.n_sDel_remark.Equals(x_oObj.del_remark)){ return false; }
            if(!this.n_sGift_imei2.Equals(x_oObj.gift_imei2)){ return false; }
            if(!this.n_sReasons.Equals(x_oObj.reasons)){ return false; }
            if(!this.n_sLanguage.Equals(x_oObj.language)){ return false; }
            if(!this.n_sRebate_amount.Equals(x_oObj.rebate_amount)){ return false; }
            if(!this.n_sOrd_place_id_type.Equals(x_oObj.ord_place_id_type)){ return false; }
            if(!this.n_sM_3rd_contact_no.Equals(x_oObj.m_3rd_contact_no)){ return false; }
            if(!this.n_sStaff_no.Equals(x_oObj.staff_no)){ return false; }
            if(!this.n_dSp_d_date.Equals(x_oObj.sp_d_date)){ return false; }
            if(!this.n_sBundle_name.Equals(x_oObj.bundle_name)){ return false; }
            if(!this.n_bAccessory_waive.Equals(x_oObj.accessory_waive)){ return false; }
            if(!this.n_sSim_item_code.Equals(x_oObj.sim_item_code)){ return false; }
            if(!this.n_sCust_type.Equals(x_oObj.cust_type)){ return false; }
            if(!this.n_sCard_ref_no.Equals(x_oObj.card_ref_no)){ return false; }
            return true;
        }
        #endregion
        
        #region Retrieve
        
        /// <summary>
        /// Summary description for Retrieve
        /// </summary>
        
        public bool Retrieve(){
            if (n_oDB==null) { return false; }
            bool _bResult=false;
            if(!n_iOrder_id.Equals(null)){
                _bResult=this.Load(n_iOrder_id);
                if(_bResult){ return _bResult;}
            }
            return _bResult;
        }
        
        #endregion
        
        #region Save
        
        /// <summary>
        /// Summary description for Save
        /// </summary>
        
        public bool Save()
        {
            if(n_oDB==null){ return false;}
            if (n_iOrder_id==null) { return false; }
            if(!Vaild(false)){ return false; }
            string _sQuery = "UPDATE  [MobileRetentionOrder]  SET  [gift_imei]=@gift_imei,[s_premium4]=@s_premium4,[upgrade_existing_customer_type]=@upgrade_existing_customer_type,[gift_desc4]=@gift_desc4,[accessory_desc]=@accessory_desc,[staff_name]=@staff_name,[action_required]=@action_required,[vas_eff_date]=@vas_eff_date,[monthly_bank_account_bank_code]=@monthly_bank_account_bank_code,[sim_item_number]=@sim_item_number,[special_handling_dummy_code]=@special_handling_dummy_code,[card_no]=@card_no,[m_card_exp_year]=@m_card_exp_year,[bill_medium_email]=@bill_medium_email,[remarks2PY]=@remarks2PY,[trade_field]=@trade_field,[ord_place_tel]=@ord_place_tel,[action_of_rate_plan_effective]=@action_of_rate_plan_effective,[cooling_offer]=@cooling_offer,[upgrade_handset_offer_rebate_schedule]=@upgrade_handset_offer_rebate_schedule,[change_payment_type]=@change_payment_type,[date_of_birth]=@date_of_birth,[contact_person]=@contact_person,[extra_d_charge]=@extra_d_charge,[tl_name]=@tl_name,[fast_start]=@fast_start,[sp_ref_no]=@sp_ref_no,[edate]=@edate,[exist_cust_plan]=@exist_cust_plan,[ord_place_rel]=@ord_place_rel,[mrt_no]=@mrt_no,[imei_no]=@imei_no,[existing_smart_phone_model]=@existing_smart_phone_model,[bank_code]=@bank_code,[pos_ref_no]=@pos_ref_no,[bill_cut_date]=@bill_cut_date,[gift_imei3]=@gift_imei3,[exist_plan]=@exist_plan,[waive]=@waive,[program]=@program,[first_month_fee]=@first_month_fee,[r_offer]=@r_offer,[cid]=@cid,[did]=@did,[ftg_tenure]=@ftg_tenure,[con_per]=@con_per,[gift_code4]=@gift_code4,[easywatch_type]=@easywatch_type,[sms_mrt]=@sms_mrt,[monthly_payment_method]=@monthly_payment_method,[remarks2EDF]=@remarks2EDF,[gift_desc3]=@gift_desc3,[gift_imei4]=@gift_imei4,[monthly_bank_account_hkid2]=@monthly_bank_account_hkid2,[d_date]=@d_date,[gift_desc]=@gift_desc,[pool]=@pool,[cn_mrt_no]=@cn_mrt_no,[accessory_imei]=@accessory_imei,[third_party_credit_card]=@third_party_credit_card,[special_approval]=@special_approval,[upgrade_existing_contract_edate]=@upgrade_existing_contract_edate,[accessory_code]=@accessory_code,[s_premium]=@s_premium,[ref_staff_no]=@ref_staff_no,[accessory_price]=@accessory_price,[m_card_exp_month]=@m_card_exp_month,[installment_period]=@installment_period,[m_card_type]=@m_card_type,[easywatch_ord_id]=@easywatch_ord_id,[normal_rebate]=@normal_rebate,[m_rebate_amount]=@m_rebate_amount,[m_card_holder2]=@m_card_holder2,[monthly_bank_account_holder]=@monthly_bank_account_holder,[active]=@active,[s_premium1]=@s_premium1,[card_exp_month]=@card_exp_month,[ob_program_id]=@ob_program_id,[sku]=@sku,[salesmancode]=@salesmancode,[go_wireless_package_code]=@go_wireless_package_code,[lob]=@lob,[ref_salesmancode]=@ref_salesmancode,[third_party_hkid]=@third_party_hkid,[upgrade_existing_pccw_customer]=@upgrade_existing_pccw_customer,[d_address]=@d_address,[upgrade_registered_mobile_no]=@upgrade_registered_mobile_no,[gift_code3]=@gift_code3,[normal_rebate_type]=@normal_rebate_type,[gift_desc2]=@gift_desc2,[monthly_bank_account_branch_code]=@monthly_bank_account_branch_code,[remarks]=@remarks,[accept]=@accept,[delivery_exchange]=@delivery_exchange,[gift_code2]=@gift_code2,[prepayment_waive]=@prepayment_waive,[existing_smart_phone_imei]=@existing_smart_phone_imei,[cust_name]=@cust_name,[upgrade_sponsorships_amount]=@upgrade_sponsorships_amount,[bill_medium_waive]=@bill_medium_waive,[delivery_exchange_location]=@delivery_exchange_location,[hs_offer_type_id]=@hs_offer_type_id,[extra_rebate_amount]=@extra_rebate_amount,[rebate]=@rebate,[upgrade_type]=@upgrade_type,[go_wireless]=@go_wireless,[extra_rebate]=@extra_rebate,[plan_eff]=@plan_eff,[card_exp_year]=@card_exp_year,[upgrade_existing_contract_sdate]=@upgrade_existing_contract_sdate,[ord_place_hkid]=@ord_place_hkid,[register_address]=@register_address,[gender]=@gender,[lob_ac]=@lob_ac,[sim_mrt_no]=@sim_mrt_no,[redemption_notice_option]=@redemption_notice_option,[delivery_collection_type]=@delivery_collection_type,[action_date]=@action_date,[third_party_id_type]=@third_party_id_type,[org_ftg]=@org_ftg,[upgrade_service_tenure]=@upgrade_service_tenure,[monthly_payment_type]=@monthly_payment_type,[contact_no]=@contact_no,[org_mrt]=@org_mrt,[sim_item_name]=@sim_item_name,[pay_method]=@pay_method,[hs_model]=@hs_model,[gift_code]=@gift_code,[monthly_bank_account_hkid]=@monthly_bank_account_hkid,[extra_offer]=@extra_offer,[monthly_bank_account_no]=@monthly_bank_account_no,[first_month_license_fee]=@first_month_license_fee,[retrieve_cnt]=@retrieve_cnt,[ddate]=@ddate,[s_premium2]=@s_premium2,[monthly_bank_account_id_type]=@monthly_bank_account_id_type,[card_type]=@card_type,[next_bill]=@next_bill,[pcd_paid_go_wireless]=@pcd_paid_go_wireless,[upgrade_rebate_calculation]=@upgrade_rebate_calculation,[ext_place_tel]=@ext_place_tel,[m_3rd_hkid]=@m_3rd_hkid,[retention_type]=@retention_type,[cooling_date]=@cooling_date,[aig_gift]=@aig_gift,[cust_staff_no]=@cust_staff_no,[family_name]=@family_name,[cdate]=@cdate,[status_by_cs_admin]=@status_by_cs_admin,[given_name]=@given_name,[vip_case]=@vip_case,[org_fee]=@org_fee,[s_premium3]=@s_premium3,[log_date]=@log_date,[extn]=@extn,[d_time]=@d_time,[bank_name]=@bank_name,[delivery_exchange_option]=@delivery_exchange_option,[upgrade_service_account_no]=@upgrade_service_account_no,[old_ord_id]=@old_ord_id,[m_card_no]=@m_card_no,[existing_contract_end_date]=@existing_contract_end_date,[con_eff_date]=@con_eff_date,[m_3rd_hkid2]=@m_3rd_hkid2,[amount]=@amount,[m_3rd_id_type]=@m_3rd_id_type,[id_type]=@id_type,[rate_plan]=@rate_plan,[channel]=@channel,[action_eff_date]=@action_eff_date,[issue_type]=@issue_type,[free_mon]=@free_mon,[plan_eff_date]=@plan_eff_date,[teamcode]=@teamcode,[bill_medium]=@bill_medium,[edf_no]=@edf_no,[ord_place_by]=@ord_place_by,[cancel_renew]=@cancel_renew,[preferred_languages]=@preferred_languages,[hkid]=@hkid,[card_holder]=@card_holder,[ac_no]=@ac_no,[bill_cut_num]=@bill_cut_num,[premium]=@premium,[del_remark]=@del_remark,[gift_imei2]=@gift_imei2,[reasons]=@reasons,[language]=@language,[rebate_amount]=@rebate_amount,[ord_place_id_type]=@ord_place_id_type,[m_3rd_contact_no]=@m_3rd_contact_no,[staff_no]=@staff_no,[sp_d_date]=@sp_d_date,[bundle_name]=@bundle_name,[accessory_waive]=@accessory_waive,[sim_item_code]=@sim_item_code,[cust_type]=@cust_type,[card_ref_no]=@card_ref_no  WHERE [MobileRetentionOrder].[order_id]=@order_id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionOrder]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrder]"); }
            global::System.Data.SqlClient.SqlConnection _oConn = null;
            global::System.Data.SqlClient.SqlCommand _oCmd = null;
            if (n_oDB.bTransaction)
            {
                n_oDB.ISessionCmd.CommandText = _sQuery;
                n_oDB.ISessionCmd.Parameters.Clear();
                _oCmd = n_oDB.ISessionCmd;
                _oConn = n_oDB.ISessionConn;
            }
            else
            {
                _oConn = n_oDB.GetConnection();
                _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            }
            bool _bResult=false;
            if(n_sGift_imei==null){  _oCmd.Parameters.Add("@gift_imei", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@gift_imei", global::System.Data.SqlDbType.NVarChar,50).Value=n_sGift_imei; }
            if(n_sS_premium4==null){  _oCmd.Parameters.Add("@s_premium4", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@s_premium4", global::System.Data.SqlDbType.NVarChar,100).Value=n_sS_premium4; }
            if(n_sUpgrade_existing_customer_type==null){  _oCmd.Parameters.Add("@upgrade_existing_customer_type", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@upgrade_existing_customer_type", global::System.Data.SqlDbType.NVarChar,250).Value=n_sUpgrade_existing_customer_type; }
            if(n_sGift_desc4==null){  _oCmd.Parameters.Add("@gift_desc4", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@gift_desc4", global::System.Data.SqlDbType.NVarChar,250).Value=n_sGift_desc4; }
            if(n_sAccessory_desc==null){  _oCmd.Parameters.Add("@accessory_desc", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@accessory_desc", global::System.Data.SqlDbType.NVarChar,50).Value=n_sAccessory_desc; }
            if(n_sStaff_name==null){  _oCmd.Parameters.Add("@staff_name", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@staff_name", global::System.Data.SqlDbType.NVarChar,100).Value=n_sStaff_name; }
            if(n_sAction_required==null){  _oCmd.Parameters.Add("@action_required", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@action_required", global::System.Data.SqlDbType.NVarChar,50).Value=n_sAction_required; }
            if(n_dVas_eff_date==null){  _oCmd.Parameters.Add("@vas_eff_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@vas_eff_date", global::System.Data.SqlDbType.DateTime).Value=n_dVas_eff_date; }
            if(n_sMonthly_bank_account_bank_code==null){  _oCmd.Parameters.Add("@monthly_bank_account_bank_code", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@monthly_bank_account_bank_code", global::System.Data.SqlDbType.NVarChar,50).Value=n_sMonthly_bank_account_bank_code; }
            if(n_sSim_item_number==null){  _oCmd.Parameters.Add("@sim_item_number", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@sim_item_number", global::System.Data.SqlDbType.NVarChar,250).Value=n_sSim_item_number; }
            if(n_sSpecial_handling_dummy_code==null){  _oCmd.Parameters.Add("@special_handling_dummy_code", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@special_handling_dummy_code", global::System.Data.SqlDbType.NVarChar,100).Value=n_sSpecial_handling_dummy_code; }
            if(n_sCard_no==null){  _oCmd.Parameters.Add("@card_no", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@card_no", global::System.Data.SqlDbType.NVarChar,20).Value=n_sCard_no; }
            if(n_sM_card_exp_year==null){  _oCmd.Parameters.Add("@m_card_exp_year", global::System.Data.SqlDbType.NVarChar,4).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@m_card_exp_year", global::System.Data.SqlDbType.NVarChar,4).Value=n_sM_card_exp_year; }
            if(n_sBill_medium_email==null){  _oCmd.Parameters.Add("@bill_medium_email", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@bill_medium_email", global::System.Data.SqlDbType.NVarChar,50).Value=n_sBill_medium_email; }
            if(n_sRemarks2PY==null){  _oCmd.Parameters.Add("@remarks2PY", global::System.Data.SqlDbType.Text,2147483647).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@remarks2PY", global::System.Data.SqlDbType.Text,2147483647).Value=n_sRemarks2PY; }
            if(n_sTrade_field==null){  _oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,50).Value=n_sTrade_field; }
            if(n_sOrd_place_tel==null){  _oCmd.Parameters.Add("@ord_place_tel", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@ord_place_tel", global::System.Data.SqlDbType.NVarChar,10).Value=n_sOrd_place_tel; }
            if(n_sAction_of_rate_plan_effective==null){  _oCmd.Parameters.Add("@action_of_rate_plan_effective", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@action_of_rate_plan_effective", global::System.Data.SqlDbType.NVarChar,250).Value=n_sAction_of_rate_plan_effective; }
            if(n_sCooling_offer==null){  _oCmd.Parameters.Add("@cooling_offer", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@cooling_offer", global::System.Data.SqlDbType.NVarChar,50).Value=n_sCooling_offer; }
            if(n_sUpgrade_handset_offer_rebate_schedule==null){  _oCmd.Parameters.Add("@upgrade_handset_offer_rebate_schedule", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@upgrade_handset_offer_rebate_schedule", global::System.Data.SqlDbType.NVarChar,250).Value=n_sUpgrade_handset_offer_rebate_schedule; }
            if(n_sChange_payment_type==null){  _oCmd.Parameters.Add("@change_payment_type", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@change_payment_type", global::System.Data.SqlDbType.NVarChar,20).Value=n_sChange_payment_type; }
            if(n_dDate_of_birth==null){  _oCmd.Parameters.Add("@date_of_birth", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@date_of_birth", global::System.Data.SqlDbType.DateTime).Value=n_dDate_of_birth; }
            if(n_sContact_person==null){  _oCmd.Parameters.Add("@contact_person", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@contact_person", global::System.Data.SqlDbType.NVarChar,100).Value=n_sContact_person; }
            if(n_sExtra_d_charge==null){  _oCmd.Parameters.Add("@extra_d_charge", global::System.Data.SqlDbType.NVarChar,5).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@extra_d_charge", global::System.Data.SqlDbType.NVarChar,5).Value=n_sExtra_d_charge; }
            if(n_sTl_name==null){  _oCmd.Parameters.Add("@tl_name", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@tl_name", global::System.Data.SqlDbType.NVarChar,100).Value=n_sTl_name; }
            if(n_bFast_start==null){  _oCmd.Parameters.Add("@fast_start", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@fast_start", global::System.Data.SqlDbType.Bit).Value=n_bFast_start; }
            if(n_sSp_ref_no==null){  _oCmd.Parameters.Add("@sp_ref_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@sp_ref_no", global::System.Data.SqlDbType.NVarChar,50).Value=n_sSp_ref_no; }
            if(n_dEdate==null){  _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=n_dEdate; }
            if(n_sExist_cust_plan==null){  _oCmd.Parameters.Add("@exist_cust_plan", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@exist_cust_plan", global::System.Data.SqlDbType.NVarChar,50).Value=n_sExist_cust_plan; }
            if(n_sOrd_place_rel==null){  _oCmd.Parameters.Add("@ord_place_rel", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@ord_place_rel", global::System.Data.SqlDbType.NVarChar,50).Value=n_sOrd_place_rel; }
            if(n_iMrt_no==null){  _oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.Int).Value=n_iMrt_no; }
            if(n_sImei_no==null){  _oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,30).Value=n_sImei_no; }
            if(n_sExisting_smart_phone_model==null){  _oCmd.Parameters.Add("@existing_smart_phone_model", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@existing_smart_phone_model", global::System.Data.SqlDbType.NVarChar,250).Value=n_sExisting_smart_phone_model; }
            if(n_sBank_code==null){  _oCmd.Parameters.Add("@bank_code", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@bank_code", global::System.Data.SqlDbType.NVarChar,30).Value=n_sBank_code; }
            if(n_sPos_ref_no==null){  _oCmd.Parameters.Add("@pos_ref_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@pos_ref_no", global::System.Data.SqlDbType.NVarChar,50).Value=n_sPos_ref_no; }
            if(n_dBill_cut_date==null){  _oCmd.Parameters.Add("@bill_cut_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@bill_cut_date", global::System.Data.SqlDbType.DateTime).Value=n_dBill_cut_date; }
            if(n_sGift_imei3==null){  _oCmd.Parameters.Add("@gift_imei3", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@gift_imei3", global::System.Data.SqlDbType.NVarChar,50).Value=n_sGift_imei3; }
            if(n_sExist_plan==null){  _oCmd.Parameters.Add("@exist_plan", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@exist_plan", global::System.Data.SqlDbType.NVarChar,100).Value=n_sExist_plan; }
            if(n_bWaive==null){  _oCmd.Parameters.Add("@waive", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@waive", global::System.Data.SqlDbType.Bit).Value=n_bWaive; }
            if(n_sProgram==null){  _oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value=n_sProgram; }
            if(n_sFirst_month_fee==null){  _oCmd.Parameters.Add("@first_month_fee", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@first_month_fee", global::System.Data.SqlDbType.NVarChar,100).Value=n_sFirst_month_fee; }
            if(n_sR_offer==null){  _oCmd.Parameters.Add("@r_offer", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@r_offer", global::System.Data.SqlDbType.NVarChar,50).Value=n_sR_offer; }
            if(n_sCid==null){  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value=n_sCid; }
            if(n_sDid==null){  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10).Value=n_sDid; }
            if(n_sFtg_tenure==null){  _oCmd.Parameters.Add("@ftg_tenure", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@ftg_tenure", global::System.Data.SqlDbType.NVarChar,100).Value=n_sFtg_tenure; }
            if(n_sCon_per==null){  _oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10).Value=n_sCon_per; }
            if(n_sGift_code4==null){  _oCmd.Parameters.Add("@gift_code4", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@gift_code4", global::System.Data.SqlDbType.NVarChar,50).Value=n_sGift_code4; }
            if(n_sEasywatch_type==null){  _oCmd.Parameters.Add("@easywatch_type", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@easywatch_type", global::System.Data.SqlDbType.NVarChar,20).Value=n_sEasywatch_type; }
            if(n_sSms_mrt==null){  _oCmd.Parameters.Add("@sms_mrt", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@sms_mrt", global::System.Data.SqlDbType.NVarChar,50).Value=n_sSms_mrt; }
            if(n_sMonthly_payment_method==null){  _oCmd.Parameters.Add("@monthly_payment_method", global::System.Data.SqlDbType.NVarChar,40).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@monthly_payment_method", global::System.Data.SqlDbType.NVarChar,40).Value=n_sMonthly_payment_method; }
            if(n_sRemarks2EDF==null){  _oCmd.Parameters.Add("@remarks2EDF", global::System.Data.SqlDbType.Text,2147483647).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@remarks2EDF", global::System.Data.SqlDbType.Text,2147483647).Value=n_sRemarks2EDF; }
            if(n_sGift_desc3==null){  _oCmd.Parameters.Add("@gift_desc3", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@gift_desc3", global::System.Data.SqlDbType.NVarChar,250).Value=n_sGift_desc3; }
            if(n_sGift_imei4==null){  _oCmd.Parameters.Add("@gift_imei4", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@gift_imei4", global::System.Data.SqlDbType.NVarChar,50).Value=n_sGift_imei4; }
            if(n_sMonthly_bank_account_hkid2==null){  _oCmd.Parameters.Add("@monthly_bank_account_hkid2", global::System.Data.SqlDbType.NVarChar,1).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@monthly_bank_account_hkid2", global::System.Data.SqlDbType.NVarChar,1).Value=n_sMonthly_bank_account_hkid2; }
            if(n_dD_date==null){  _oCmd.Parameters.Add("@d_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@d_date", global::System.Data.SqlDbType.DateTime).Value=n_dD_date; }
            if(n_sGift_desc==null){  _oCmd.Parameters.Add("@gift_desc", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@gift_desc", global::System.Data.SqlDbType.NVarChar,250).Value=n_sGift_desc; }
            if(n_sPool==null){  _oCmd.Parameters.Add("@pool", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@pool", global::System.Data.SqlDbType.NVarChar,50).Value=n_sPool; }
            if(n_lCn_mrt_no==null){  _oCmd.Parameters.Add("@cn_mrt_no", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@cn_mrt_no", global::System.Data.SqlDbType.BigInt).Value=n_lCn_mrt_no; }
            if(n_sAccessory_imei==null){  _oCmd.Parameters.Add("@accessory_imei", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@accessory_imei", global::System.Data.SqlDbType.NVarChar,50).Value=n_sAccessory_imei; }
            if(n_sThird_party_credit_card==null){  _oCmd.Parameters.Add("@third_party_credit_card", global::System.Data.SqlDbType.NVarChar,5).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@third_party_credit_card", global::System.Data.SqlDbType.NVarChar,5).Value=n_sThird_party_credit_card; }
            if(n_sSpecial_approval==null){  _oCmd.Parameters.Add("@special_approval", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@special_approval", global::System.Data.SqlDbType.NVarChar,20).Value=n_sSpecial_approval; }
            if(n_dUpgrade_existing_contract_edate==null){  _oCmd.Parameters.Add("@upgrade_existing_contract_edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@upgrade_existing_contract_edate", global::System.Data.SqlDbType.DateTime).Value=n_dUpgrade_existing_contract_edate; }
            if(n_sAccessory_code==null){  _oCmd.Parameters.Add("@accessory_code", global::System.Data.SqlDbType.NVarChar,70).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@accessory_code", global::System.Data.SqlDbType.NVarChar,70).Value=n_sAccessory_code; }
            if(n_sS_premium==null){  _oCmd.Parameters.Add("@s_premium", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@s_premium", global::System.Data.SqlDbType.NVarChar,100).Value=n_sS_premium; }
            if(n_sRef_staff_no==null){  _oCmd.Parameters.Add("@ref_staff_no", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@ref_staff_no", global::System.Data.SqlDbType.NVarChar,20).Value=n_sRef_staff_no; }
            if(n_sAccessory_price==null){  _oCmd.Parameters.Add("@accessory_price", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@accessory_price", global::System.Data.SqlDbType.NVarChar,10).Value=n_sAccessory_price; }
            if(n_sM_card_exp_month==null){  _oCmd.Parameters.Add("@m_card_exp_month", global::System.Data.SqlDbType.NVarChar,2).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@m_card_exp_month", global::System.Data.SqlDbType.NVarChar,2).Value=n_sM_card_exp_month; }
            if(n_sInstallment_period==null){  _oCmd.Parameters.Add("@installment_period", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@installment_period", global::System.Data.SqlDbType.NVarChar,50).Value=n_sInstallment_period; }
            if(n_sM_card_type==null){  _oCmd.Parameters.Add("@m_card_type", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@m_card_type", global::System.Data.SqlDbType.NVarChar,20).Value=n_sM_card_type; }
            if(n_sEasywatch_ord_id==null){  _oCmd.Parameters.Add("@easywatch_ord_id", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@easywatch_ord_id", global::System.Data.SqlDbType.NVarChar,10).Value=n_sEasywatch_ord_id; }
            if(n_bNormal_rebate==null){  _oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit).Value=n_bNormal_rebate; }
            if(n_sM_rebate_amount==null){  _oCmd.Parameters.Add("@m_rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@m_rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value=n_sM_rebate_amount; }
            if(n_sM_card_holder2==null){  _oCmd.Parameters.Add("@m_card_holder2", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@m_card_holder2", global::System.Data.SqlDbType.NVarChar,50).Value=n_sM_card_holder2; }
            if(n_sMonthly_bank_account_holder==null){  _oCmd.Parameters.Add("@monthly_bank_account_holder", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@monthly_bank_account_holder", global::System.Data.SqlDbType.NVarChar,50).Value=n_sMonthly_bank_account_holder; }
            if(n_bActive==null){  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=n_bActive; }
            if(n_sS_premium1==null){  _oCmd.Parameters.Add("@s_premium1", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@s_premium1", global::System.Data.SqlDbType.NVarChar,100).Value=n_sS_premium1; }
            if(n_sCard_exp_month==null){  _oCmd.Parameters.Add("@card_exp_month", global::System.Data.SqlDbType.NVarChar,2).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@card_exp_month", global::System.Data.SqlDbType.NVarChar,2).Value=n_sCard_exp_month; }
            if(n_sOb_program_id==null){  _oCmd.Parameters.Add("@ob_program_id", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@ob_program_id", global::System.Data.SqlDbType.NVarChar,20).Value=n_sOb_program_id; }
            if(n_sSku==null){  _oCmd.Parameters.Add("@sku", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@sku", global::System.Data.SqlDbType.NVarChar,50).Value=n_sSku; }
            if(n_sSalesmancode==null){  _oCmd.Parameters.Add("@salesmancode", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@salesmancode", global::System.Data.SqlDbType.NVarChar,10).Value=n_sSalesmancode; }
            if(n_sGo_wireless_package_code==null){  _oCmd.Parameters.Add("@go_wireless_package_code", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@go_wireless_package_code", global::System.Data.SqlDbType.NVarChar,100).Value=n_sGo_wireless_package_code; }
            if(n_sLob==null){  _oCmd.Parameters.Add("@lob", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@lob", global::System.Data.SqlDbType.NVarChar,50).Value=n_sLob; }
            if(n_sRef_salesmancode==null){  _oCmd.Parameters.Add("@ref_salesmancode", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@ref_salesmancode", global::System.Data.SqlDbType.NVarChar,20).Value=n_sRef_salesmancode; }
            if(n_sThird_party_hkid==null){  _oCmd.Parameters.Add("@third_party_hkid", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@third_party_hkid", global::System.Data.SqlDbType.NVarChar,30).Value=n_sThird_party_hkid; }
            if(n_sUpgrade_existing_pccw_customer==null){  _oCmd.Parameters.Add("@upgrade_existing_pccw_customer", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@upgrade_existing_pccw_customer", global::System.Data.SqlDbType.NVarChar,250).Value=n_sUpgrade_existing_pccw_customer; }
            if(n_sD_address==null){  _oCmd.Parameters.Add("@d_address", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@d_address", global::System.Data.SqlDbType.NVarChar,250).Value=n_sD_address; }
            if(n_sUpgrade_registered_mobile_no==null){  _oCmd.Parameters.Add("@upgrade_registered_mobile_no", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@upgrade_registered_mobile_no", global::System.Data.SqlDbType.NVarChar,100).Value=n_sUpgrade_registered_mobile_no; }
            if(n_sGift_code3==null){  _oCmd.Parameters.Add("@gift_code3", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@gift_code3", global::System.Data.SqlDbType.NVarChar,50).Value=n_sGift_code3; }
            if(n_sNormal_rebate_type==null){  _oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value=n_sNormal_rebate_type; }
            if(n_sGift_desc2==null){  _oCmd.Parameters.Add("@gift_desc2", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@gift_desc2", global::System.Data.SqlDbType.NVarChar,250).Value=n_sGift_desc2; }
            if(n_sMonthly_bank_account_branch_code==null){  _oCmd.Parameters.Add("@monthly_bank_account_branch_code", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@monthly_bank_account_branch_code", global::System.Data.SqlDbType.NVarChar,50).Value=n_sMonthly_bank_account_branch_code; }
            if(n_sRemarks==null){  _oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.Text,2147483647).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.Text,2147483647).Value=n_sRemarks; }
            if(n_sAccept==null){  _oCmd.Parameters.Add("@accept", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@accept", global::System.Data.SqlDbType.NVarChar,50).Value=n_sAccept; }
            if(n_sDelivery_exchange==null){  _oCmd.Parameters.Add("@delivery_exchange", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@delivery_exchange", global::System.Data.SqlDbType.NVarChar,50).Value=n_sDelivery_exchange; }
            if(n_sGift_code2==null){  _oCmd.Parameters.Add("@gift_code2", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@gift_code2", global::System.Data.SqlDbType.NVarChar,50).Value=n_sGift_code2; }
            if(n_bPrepayment_waive==null){  _oCmd.Parameters.Add("@prepayment_waive", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@prepayment_waive", global::System.Data.SqlDbType.Bit).Value=n_bPrepayment_waive; }
            if(n_sExisting_smart_phone_imei==null){  _oCmd.Parameters.Add("@existing_smart_phone_imei", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@existing_smart_phone_imei", global::System.Data.SqlDbType.NVarChar,250).Value=n_sExisting_smart_phone_imei; }
            if(n_sCust_name==null){  _oCmd.Parameters.Add("@cust_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@cust_name", global::System.Data.SqlDbType.NVarChar,250).Value=n_sCust_name; }
            if(n_sUpgrade_sponsorships_amount==null){  _oCmd.Parameters.Add("@upgrade_sponsorships_amount", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@upgrade_sponsorships_amount", global::System.Data.SqlDbType.NVarChar,100).Value=n_sUpgrade_sponsorships_amount; }
            if(n_bBill_medium_waive==null){  _oCmd.Parameters.Add("@bill_medium_waive", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@bill_medium_waive", global::System.Data.SqlDbType.Bit).Value=n_bBill_medium_waive; }
            if(n_sDelivery_exchange_location==null){  _oCmd.Parameters.Add("@delivery_exchange_location", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@delivery_exchange_location", global::System.Data.SqlDbType.NVarChar,50).Value=n_sDelivery_exchange_location; }
            if(n_iHs_offer_type_id==null){  _oCmd.Parameters.Add("@hs_offer_type_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@hs_offer_type_id", global::System.Data.SqlDbType.Int).Value=n_iHs_offer_type_id; }
            if(n_sExtra_rebate_amount==null){  _oCmd.Parameters.Add("@extra_rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@extra_rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value=n_sExtra_rebate_amount; }
            if(n_sRebate==null){  _oCmd.Parameters.Add("@rebate", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@rebate", global::System.Data.SqlDbType.NVarChar,20).Value=n_sRebate; }
            if(n_sUpgrade_type==null){  _oCmd.Parameters.Add("@upgrade_type", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@upgrade_type", global::System.Data.SqlDbType.NVarChar,100).Value=n_sUpgrade_type; }
            if(n_sGo_wireless==null){  _oCmd.Parameters.Add("@go_wireless", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@go_wireless", global::System.Data.SqlDbType.NVarChar,50).Value=n_sGo_wireless; }
            if(n_sExtra_rebate==null){  _oCmd.Parameters.Add("@extra_rebate", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@extra_rebate", global::System.Data.SqlDbType.NVarChar,10).Value=n_sExtra_rebate; }
            if(n_sPlan_eff==null){  _oCmd.Parameters.Add("@plan_eff", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@plan_eff", global::System.Data.SqlDbType.NVarChar,20).Value=n_sPlan_eff; }
            if(n_sCard_exp_year==null){  _oCmd.Parameters.Add("@card_exp_year", global::System.Data.SqlDbType.NVarChar,4).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@card_exp_year", global::System.Data.SqlDbType.NVarChar,4).Value=n_sCard_exp_year; }
            if(n_dUpgrade_existing_contract_sdate==null){  _oCmd.Parameters.Add("@upgrade_existing_contract_sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@upgrade_existing_contract_sdate", global::System.Data.SqlDbType.DateTime).Value=n_dUpgrade_existing_contract_sdate; }
            if(n_sOrd_place_hkid==null){  _oCmd.Parameters.Add("@ord_place_hkid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@ord_place_hkid", global::System.Data.SqlDbType.NVarChar,50).Value=n_sOrd_place_hkid; }
            if(n_sRegister_address==null){  _oCmd.Parameters.Add("@register_address", global::System.Data.SqlDbType.NVarChar,200).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@register_address", global::System.Data.SqlDbType.NVarChar,200).Value=n_sRegister_address; }
            if(n_sGender==null){  _oCmd.Parameters.Add("@gender", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@gender", global::System.Data.SqlDbType.NVarChar,50).Value=n_sGender; }
            if(n_sLob_ac==null){  _oCmd.Parameters.Add("@lob_ac", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@lob_ac", global::System.Data.SqlDbType.NVarChar,20).Value=n_sLob_ac; }
            if(n_iSim_mrt_no==null){  _oCmd.Parameters.Add("@sim_mrt_no", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@sim_mrt_no", global::System.Data.SqlDbType.Int).Value=n_iSim_mrt_no; }
            if(n_sRedemption_notice_option==null){  _oCmd.Parameters.Add("@redemption_notice_option", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@redemption_notice_option", global::System.Data.SqlDbType.NVarChar,100).Value=n_sRedemption_notice_option; }
            if(n_sDelivery_collection_type==null){  _oCmd.Parameters.Add("@delivery_collection_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@delivery_collection_type", global::System.Data.SqlDbType.NVarChar,50).Value=n_sDelivery_collection_type; }
            if(n_dAction_date==null){  _oCmd.Parameters.Add("@action_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@action_date", global::System.Data.SqlDbType.DateTime).Value=n_dAction_date; }
            if(n_sThird_party_id_type==null){  _oCmd.Parameters.Add("@third_party_id_type", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@third_party_id_type", global::System.Data.SqlDbType.NVarChar,30).Value=n_sThird_party_id_type; }
            if(n_sOrg_ftg==null){  _oCmd.Parameters.Add("@org_ftg", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@org_ftg", global::System.Data.SqlDbType.NVarChar,10).Value=n_sOrg_ftg; }
            if(n_sUpgrade_service_tenure==null){  _oCmd.Parameters.Add("@upgrade_service_tenure", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@upgrade_service_tenure", global::System.Data.SqlDbType.NVarChar,100).Value=n_sUpgrade_service_tenure; }
            if(n_sMonthly_payment_type==null){  _oCmd.Parameters.Add("@monthly_payment_type", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@monthly_payment_type", global::System.Data.SqlDbType.NVarChar,250).Value=n_sMonthly_payment_type; }
            if(n_sContact_no==null){  _oCmd.Parameters.Add("@contact_no", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@contact_no", global::System.Data.SqlDbType.NVarChar,20).Value=n_sContact_no; }
            if(n_iOrg_mrt==null){  _oCmd.Parameters.Add("@org_mrt", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@org_mrt", global::System.Data.SqlDbType.Int).Value=n_iOrg_mrt; }
            if(n_sSim_item_name==null){  _oCmd.Parameters.Add("@sim_item_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@sim_item_name", global::System.Data.SqlDbType.NVarChar,250).Value=n_sSim_item_name; }
            if(n_sPay_method==null){  _oCmd.Parameters.Add("@pay_method", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@pay_method", global::System.Data.SqlDbType.NVarChar,50).Value=n_sPay_method; }
            if(n_sHs_model==null){  _oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value=n_sHs_model; }
            if(n_sGift_code==null){  _oCmd.Parameters.Add("@gift_code", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@gift_code", global::System.Data.SqlDbType.NVarChar,50).Value=n_sGift_code; }
            if(n_sMonthly_bank_account_hkid==null){  _oCmd.Parameters.Add("@monthly_bank_account_hkid", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@monthly_bank_account_hkid", global::System.Data.SqlDbType.NVarChar,30).Value=n_sMonthly_bank_account_hkid; }
            if(n_sExtra_offer==null){  _oCmd.Parameters.Add("@extra_offer", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@extra_offer", global::System.Data.SqlDbType.NVarChar,250).Value=n_sExtra_offer; }
            if(n_sMonthly_bank_account_no==null){  _oCmd.Parameters.Add("@monthly_bank_account_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@monthly_bank_account_no", global::System.Data.SqlDbType.NVarChar,50).Value=n_sMonthly_bank_account_no; }
            if(n_sFirst_month_license_fee==null){  _oCmd.Parameters.Add("@first_month_license_fee", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@first_month_license_fee", global::System.Data.SqlDbType.NVarChar,100).Value=n_sFirst_month_license_fee; }
            if(n_iRetrieve_cnt==null){  _oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int).Value=n_iRetrieve_cnt; }
            if(n_dDdate==null){  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=n_dDdate; }
            if(n_sS_premium2==null){  _oCmd.Parameters.Add("@s_premium2", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@s_premium2", global::System.Data.SqlDbType.NVarChar,100).Value=n_sS_premium2; }
            if(n_sMonthly_bank_account_id_type==null){  _oCmd.Parameters.Add("@monthly_bank_account_id_type", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@monthly_bank_account_id_type", global::System.Data.SqlDbType.NVarChar,10).Value=n_sMonthly_bank_account_id_type; }
            if(n_sCard_type==null){  _oCmd.Parameters.Add("@card_type", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@card_type", global::System.Data.SqlDbType.NVarChar,20).Value=n_sCard_type; }
            if(n_bNext_bill==null){  _oCmd.Parameters.Add("@next_bill", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@next_bill", global::System.Data.SqlDbType.Bit).Value=n_bNext_bill; }
            if(n_bPcd_paid_go_wireless==null){  _oCmd.Parameters.Add("@pcd_paid_go_wireless", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@pcd_paid_go_wireless", global::System.Data.SqlDbType.Bit).Value=n_bPcd_paid_go_wireless; }
            if(n_sUpgrade_rebate_calculation==null){  _oCmd.Parameters.Add("@upgrade_rebate_calculation", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@upgrade_rebate_calculation", global::System.Data.SqlDbType.NVarChar,250).Value=n_sUpgrade_rebate_calculation; }
            if(n_sExt_place_tel==null){  _oCmd.Parameters.Add("@ext_place_tel", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@ext_place_tel", global::System.Data.SqlDbType.NVarChar,10).Value=n_sExt_place_tel; }
            if(n_sM_3rd_hkid==null){  _oCmd.Parameters.Add("@m_3rd_hkid", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@m_3rd_hkid", global::System.Data.SqlDbType.NVarChar,30).Value=n_sM_3rd_hkid; }
            if(n_sRetention_type==null){  _oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.NVarChar,50).Value=n_sRetention_type; }
            if(n_dCooling_date==null){  _oCmd.Parameters.Add("@cooling_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@cooling_date", global::System.Data.SqlDbType.DateTime).Value=n_dCooling_date; }
            if(n_sAig_gift==null){  _oCmd.Parameters.Add("@aig_gift", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@aig_gift", global::System.Data.SqlDbType.NVarChar,50).Value=n_sAig_gift; }
            if(n_sCust_staff_no==null){  _oCmd.Parameters.Add("@cust_staff_no", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@cust_staff_no", global::System.Data.SqlDbType.NVarChar,10).Value=n_sCust_staff_no; }
            if(n_iOrder_id==null){  _oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=n_iOrder_id; }
            if(n_sFamily_name==null){  _oCmd.Parameters.Add("@family_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@family_name", global::System.Data.SqlDbType.NVarChar,250).Value=n_sFamily_name; }
            if(n_dCdate==null){  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=n_dCdate; }
            if(n_sStatus_by_cs_admin==null){  _oCmd.Parameters.Add("@status_by_cs_admin", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@status_by_cs_admin", global::System.Data.SqlDbType.NVarChar,100).Value=n_sStatus_by_cs_admin; }
            if(n_sGiven_name==null){  _oCmd.Parameters.Add("@given_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@given_name", global::System.Data.SqlDbType.NVarChar,250).Value=n_sGiven_name; }
            if(n_sVip_case==null){  _oCmd.Parameters.Add("@vip_case", global::System.Data.SqlDbType.NVarChar,200).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@vip_case", global::System.Data.SqlDbType.NVarChar,200).Value=n_sVip_case; }
            if(n_sOrg_fee==null){  _oCmd.Parameters.Add("@org_fee", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@org_fee", global::System.Data.SqlDbType.NVarChar,50).Value=n_sOrg_fee; }
            if(n_sS_premium3==null){  _oCmd.Parameters.Add("@s_premium3", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@s_premium3", global::System.Data.SqlDbType.NVarChar,100).Value=n_sS_premium3; }
            if(n_dLog_date==null){  _oCmd.Parameters.Add("@log_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@log_date", global::System.Data.SqlDbType.DateTime).Value=n_dLog_date; }
            if(n_sExtn==null){  _oCmd.Parameters.Add("@extn", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@extn", global::System.Data.SqlDbType.NVarChar,10).Value=n_sExtn; }
            if(n_sD_time==null){  _oCmd.Parameters.Add("@d_time", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@d_time", global::System.Data.SqlDbType.NVarChar,10).Value=n_sD_time; }
            if(n_sBank_name==null){  _oCmd.Parameters.Add("@bank_name", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@bank_name", global::System.Data.SqlDbType.NVarChar,100).Value=n_sBank_name; }
            if(n_sDelivery_exchange_option==null){  _oCmd.Parameters.Add("@delivery_exchange_option", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@delivery_exchange_option", global::System.Data.SqlDbType.NVarChar,50).Value=n_sDelivery_exchange_option; }
            if(n_sUpgrade_service_account_no==null){  _oCmd.Parameters.Add("@upgrade_service_account_no", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@upgrade_service_account_no", global::System.Data.SqlDbType.NVarChar,250).Value=n_sUpgrade_service_account_no; }
            if(n_iOld_ord_id==null){  _oCmd.Parameters.Add("@old_ord_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@old_ord_id", global::System.Data.SqlDbType.Int).Value=n_iOld_ord_id; }
            if(n_sM_card_no==null){  _oCmd.Parameters.Add("@m_card_no", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@m_card_no", global::System.Data.SqlDbType.NVarChar,20).Value=n_sM_card_no; }
            if(n_sExisting_contract_end_date==null){  _oCmd.Parameters.Add("@existing_contract_end_date", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@existing_contract_end_date", global::System.Data.SqlDbType.NVarChar,30).Value=n_sExisting_contract_end_date; }
            if(n_dCon_eff_date==null){  _oCmd.Parameters.Add("@con_eff_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@con_eff_date", global::System.Data.SqlDbType.DateTime).Value=n_dCon_eff_date; }
            if(n_sM_3rd_hkid2==null){  _oCmd.Parameters.Add("@m_3rd_hkid2", global::System.Data.SqlDbType.NVarChar,1).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@m_3rd_hkid2", global::System.Data.SqlDbType.NVarChar,1).Value=n_sM_3rd_hkid2; }
            if(n_sAmount==null){  _oCmd.Parameters.Add("@amount", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@amount", global::System.Data.SqlDbType.NVarChar,50).Value=n_sAmount; }
            if(n_sM_3rd_id_type==null){  _oCmd.Parameters.Add("@m_3rd_id_type", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@m_3rd_id_type", global::System.Data.SqlDbType.NVarChar,10).Value=n_sM_3rd_id_type; }
            if(n_sId_type==null){  _oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,10).Value=n_sId_type; }
            if(n_sRate_plan==null){  _oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50).Value=n_sRate_plan; }
            if(n_sChannel==null){  _oCmd.Parameters.Add("@channel", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@channel", global::System.Data.SqlDbType.Char,10).Value=n_sChannel; }
            if(n_dAction_eff_date==null){  _oCmd.Parameters.Add("@action_eff_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@action_eff_date", global::System.Data.SqlDbType.DateTime).Value=n_dAction_eff_date; }
            if(n_sIssue_type==null){  _oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value=n_sIssue_type; }
            if(n_sFree_mon==null){  _oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.NVarChar,30).Value=n_sFree_mon; }
            if(n_dPlan_eff_date==null){  _oCmd.Parameters.Add("@plan_eff_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@plan_eff_date", global::System.Data.SqlDbType.DateTime).Value=n_dPlan_eff_date; }
            if(n_sTeamcode==null){  _oCmd.Parameters.Add("@teamcode", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@teamcode", global::System.Data.SqlDbType.NVarChar,10).Value=n_sTeamcode; }
            if(n_sBill_medium==null){  _oCmd.Parameters.Add("@bill_medium", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@bill_medium", global::System.Data.SqlDbType.NVarChar,50).Value=n_sBill_medium; }
            if(n_sEdf_no==null){  _oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,15).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,15).Value=n_sEdf_no; }
            if(n_sOrd_place_by==null){  _oCmd.Parameters.Add("@ord_place_by", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@ord_place_by", global::System.Data.SqlDbType.NVarChar,250).Value=n_sOrd_place_by; }
            if(n_sCancel_renew==null){  _oCmd.Parameters.Add("@cancel_renew", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@cancel_renew", global::System.Data.SqlDbType.NVarChar,10).Value=n_sCancel_renew; }
            if(n_sPreferred_languages==null){  _oCmd.Parameters.Add("@preferred_languages", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@preferred_languages", global::System.Data.SqlDbType.NVarChar,30).Value=n_sPreferred_languages; }
            if(n_sHkid==null){  _oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,30).Value=n_sHkid; }
            if(n_sCard_holder==null){  _oCmd.Parameters.Add("@card_holder", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@card_holder", global::System.Data.SqlDbType.NVarChar,100).Value=n_sCard_holder; }
            if(n_sAc_no==null){  _oCmd.Parameters.Add("@ac_no", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@ac_no", global::System.Data.SqlDbType.NVarChar,20).Value=n_sAc_no; }
            if(n_iBill_cut_num==null){  _oCmd.Parameters.Add("@bill_cut_num", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@bill_cut_num", global::System.Data.SqlDbType.Int).Value=n_iBill_cut_num; }
            if(n_sPremium==null){  _oCmd.Parameters.Add("@premium", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@premium", global::System.Data.SqlDbType.NVarChar,250).Value=n_sPremium; }
            if(n_sDel_remark==null){  _oCmd.Parameters.Add("@del_remark", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@del_remark", global::System.Data.SqlDbType.NVarChar,250).Value=n_sDel_remark; }
            if(n_sGift_imei2==null){  _oCmd.Parameters.Add("@gift_imei2", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@gift_imei2", global::System.Data.SqlDbType.NVarChar,50).Value=n_sGift_imei2; }
            if(n_sReasons==null){  _oCmd.Parameters.Add("@reasons", global::System.Data.SqlDbType.Text,2147483647).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@reasons", global::System.Data.SqlDbType.Text,2147483647).Value=n_sReasons; }
            if(n_sLanguage==null){  _oCmd.Parameters.Add("@language", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@language", global::System.Data.SqlDbType.NVarChar,100).Value=n_sLanguage; }
            if(n_sRebate_amount==null){  _oCmd.Parameters.Add("@rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value=n_sRebate_amount; }
            if(n_sOrd_place_id_type==null){  _oCmd.Parameters.Add("@ord_place_id_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@ord_place_id_type", global::System.Data.SqlDbType.NVarChar,50).Value=n_sOrd_place_id_type; }
            if(n_sM_3rd_contact_no==null){  _oCmd.Parameters.Add("@m_3rd_contact_no", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@m_3rd_contact_no", global::System.Data.SqlDbType.NVarChar,20).Value=n_sM_3rd_contact_no; }
            if(n_sStaff_no==null){  _oCmd.Parameters.Add("@staff_no", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@staff_no", global::System.Data.SqlDbType.NVarChar,10).Value=n_sStaff_no; }
            if(n_dSp_d_date==null){  _oCmd.Parameters.Add("@sp_d_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@sp_d_date", global::System.Data.SqlDbType.DateTime).Value=n_dSp_d_date; }
            if(n_sBundle_name==null){  _oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,50).Value=n_sBundle_name; }
            if(n_bAccessory_waive==null){  _oCmd.Parameters.Add("@accessory_waive", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@accessory_waive", global::System.Data.SqlDbType.Bit).Value=n_bAccessory_waive; }
            if(n_sSim_item_code==null){  _oCmd.Parameters.Add("@sim_item_code", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@sim_item_code", global::System.Data.SqlDbType.NVarChar,250).Value=n_sSim_item_code; }
            if(n_sCust_type==null){  _oCmd.Parameters.Add("@cust_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@cust_type", global::System.Data.SqlDbType.NVarChar,50).Value=n_sCust_type; }
            if(n_sCard_ref_no==null){  _oCmd.Parameters.Add("@card_ref_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@card_ref_no", global::System.Data.SqlDbType.NVarChar,50).Value=n_sCard_ref_no; }
            try
            {
                if (!n_oDB.bTransaction && _oConn.State==ConnectionState.Closed) _oConn.Open();
                _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
            }
            catch {  }
            finally
            {
                if (!n_oDB.bTransaction)
                {
                    _oConn.Close();
                    _oCmd.Dispose();
                    _oConn.Dispose();
                }
            }
            return _bResult;
        }
        #endregion
        
        #region Delete
        
        /// <summary>
        /// Summary description for table [MobileRetentionOrder] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iOrder_id==null) { return false; }
            string _sQuery="DELETE FROM  [MobileRetentionOrder]  WHERE [MobileRetentionOrder].[order_id]=@order_id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionOrder]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrder]"); }
            global::System.Data.SqlClient.SqlConnection _oConn = null;
            global::System.Data.SqlClient.SqlCommand _oCmd = null;
            if (n_oDB.bTransaction)
            {
                n_oDB.ISessionCmd.CommandText = _sQuery;
                n_oDB.ISessionCmd.Parameters.Clear();
                _oCmd = n_oDB.ISessionCmd;
                _oConn = n_oDB.ISessionConn;
            }
            else
            {
                _oConn = n_oDB.GetConnection();
                _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            }
            bool _bResult=false;
            _oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = n_iOrder_id;
            _oCmd.CommandType = CommandType.Text;
            try
            {
                if (!n_oDB.bTransaction && _oConn.State == ConnectionState.Closed)  _oConn.Open();
                _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
            }
            catch {  }
            finally
            {
                if (!n_oDB.bTransaction)
                {
                    _oConn.Close();
                    _oCmd.Dispose();
                    _oConn.Dispose();
                }
            }
            return _bResult;
        }
        #endregion
        
        #region Dispose
        void global::System.IDisposable.Dispose()
        {
            this.Dispose();
        }
        public void Dispose()
        {
        }
        #endregion
        
        #region DeepClone
        
        /// <summary>
        /// Summary description for table [MobileRetentionOrder] Object Base Clone
        /// </summary>
        
        public MobileRetentionOrder DeepClone()
        {
            MobileRetentionOrder _oMobileRetentionOrder_Clone = new MobileRetentionOrder();
            _oMobileRetentionOrder_Clone.gift_imei = this.n_sGift_imei;
            _oMobileRetentionOrder_Clone.s_premium4 = this.n_sS_premium4;
            _oMobileRetentionOrder_Clone.upgrade_existing_customer_type = this.n_sUpgrade_existing_customer_type;
            _oMobileRetentionOrder_Clone.gift_desc4 = this.n_sGift_desc4;
            _oMobileRetentionOrder_Clone.accessory_desc = this.n_sAccessory_desc;
            _oMobileRetentionOrder_Clone.staff_name = this.n_sStaff_name;
            _oMobileRetentionOrder_Clone.action_required = this.n_sAction_required;
            _oMobileRetentionOrder_Clone.vas_eff_date = this.n_dVas_eff_date;
            _oMobileRetentionOrder_Clone.monthly_bank_account_bank_code = this.n_sMonthly_bank_account_bank_code;
            _oMobileRetentionOrder_Clone.sim_item_number = this.n_sSim_item_number;
            _oMobileRetentionOrder_Clone.special_handling_dummy_code = this.n_sSpecial_handling_dummy_code;
            _oMobileRetentionOrder_Clone.card_no = this.n_sCard_no;
            _oMobileRetentionOrder_Clone.m_card_exp_year = this.n_sM_card_exp_year;
            _oMobileRetentionOrder_Clone.bill_medium_email = this.n_sBill_medium_email;
            _oMobileRetentionOrder_Clone.remarks2PY = this.n_sRemarks2PY;
            _oMobileRetentionOrder_Clone.trade_field = this.n_sTrade_field;
            _oMobileRetentionOrder_Clone.ord_place_tel = this.n_sOrd_place_tel;
            _oMobileRetentionOrder_Clone.action_of_rate_plan_effective = this.n_sAction_of_rate_plan_effective;
            _oMobileRetentionOrder_Clone.cooling_offer = this.n_sCooling_offer;
            _oMobileRetentionOrder_Clone.upgrade_handset_offer_rebate_schedule = this.n_sUpgrade_handset_offer_rebate_schedule;
            _oMobileRetentionOrder_Clone.change_payment_type = this.n_sChange_payment_type;
            _oMobileRetentionOrder_Clone.date_of_birth = this.n_dDate_of_birth;
            _oMobileRetentionOrder_Clone.contact_person = this.n_sContact_person;
            _oMobileRetentionOrder_Clone.extra_d_charge = this.n_sExtra_d_charge;
            _oMobileRetentionOrder_Clone.tl_name = this.n_sTl_name;
            _oMobileRetentionOrder_Clone.fast_start = this.n_bFast_start;
            _oMobileRetentionOrder_Clone.sp_ref_no = this.n_sSp_ref_no;
            _oMobileRetentionOrder_Clone.edate = this.n_dEdate;
            _oMobileRetentionOrder_Clone.exist_cust_plan = this.n_sExist_cust_plan;
            _oMobileRetentionOrder_Clone.ord_place_rel = this.n_sOrd_place_rel;
            _oMobileRetentionOrder_Clone.mrt_no = this.n_iMrt_no;
            _oMobileRetentionOrder_Clone.imei_no = this.n_sImei_no;
            _oMobileRetentionOrder_Clone.existing_smart_phone_model = this.n_sExisting_smart_phone_model;
            _oMobileRetentionOrder_Clone.bank_code = this.n_sBank_code;
            _oMobileRetentionOrder_Clone.pos_ref_no = this.n_sPos_ref_no;
            _oMobileRetentionOrder_Clone.bill_cut_date = this.n_dBill_cut_date;
            _oMobileRetentionOrder_Clone.gift_imei3 = this.n_sGift_imei3;
            _oMobileRetentionOrder_Clone.exist_plan = this.n_sExist_plan;
            _oMobileRetentionOrder_Clone.waive = this.n_bWaive;
            _oMobileRetentionOrder_Clone.program = this.n_sProgram;
            _oMobileRetentionOrder_Clone.first_month_fee = this.n_sFirst_month_fee;
            _oMobileRetentionOrder_Clone.r_offer = this.n_sR_offer;
            _oMobileRetentionOrder_Clone.cid = this.n_sCid;
            _oMobileRetentionOrder_Clone.did = this.n_sDid;
            _oMobileRetentionOrder_Clone.ftg_tenure = this.n_sFtg_tenure;
            _oMobileRetentionOrder_Clone.con_per = this.n_sCon_per;
            _oMobileRetentionOrder_Clone.gift_code4 = this.n_sGift_code4;
            _oMobileRetentionOrder_Clone.easywatch_type = this.n_sEasywatch_type;
            _oMobileRetentionOrder_Clone.sms_mrt = this.n_sSms_mrt;
            _oMobileRetentionOrder_Clone.monthly_payment_method = this.n_sMonthly_payment_method;
            _oMobileRetentionOrder_Clone.remarks2EDF = this.n_sRemarks2EDF;
            _oMobileRetentionOrder_Clone.gift_desc3 = this.n_sGift_desc3;
            _oMobileRetentionOrder_Clone.gift_imei4 = this.n_sGift_imei4;
            _oMobileRetentionOrder_Clone.monthly_bank_account_hkid2 = this.n_sMonthly_bank_account_hkid2;
            _oMobileRetentionOrder_Clone.d_date = this.n_dD_date;
            _oMobileRetentionOrder_Clone.gift_desc = this.n_sGift_desc;
            _oMobileRetentionOrder_Clone.pool = this.n_sPool;
            _oMobileRetentionOrder_Clone.cn_mrt_no = this.n_lCn_mrt_no;
            _oMobileRetentionOrder_Clone.accessory_imei = this.n_sAccessory_imei;
            _oMobileRetentionOrder_Clone.third_party_credit_card = this.n_sThird_party_credit_card;
            _oMobileRetentionOrder_Clone.special_approval = this.n_sSpecial_approval;
            _oMobileRetentionOrder_Clone.upgrade_existing_contract_edate = this.n_dUpgrade_existing_contract_edate;
            _oMobileRetentionOrder_Clone.accessory_code = this.n_sAccessory_code;
            _oMobileRetentionOrder_Clone.s_premium = this.n_sS_premium;
            _oMobileRetentionOrder_Clone.ref_staff_no = this.n_sRef_staff_no;
            _oMobileRetentionOrder_Clone.accessory_price = this.n_sAccessory_price;
            _oMobileRetentionOrder_Clone.m_card_exp_month = this.n_sM_card_exp_month;
            _oMobileRetentionOrder_Clone.installment_period = this.n_sInstallment_period;
            _oMobileRetentionOrder_Clone.m_card_type = this.n_sM_card_type;
            _oMobileRetentionOrder_Clone.easywatch_ord_id = this.n_sEasywatch_ord_id;
            _oMobileRetentionOrder_Clone.normal_rebate = this.n_bNormal_rebate;
            _oMobileRetentionOrder_Clone.m_rebate_amount = this.n_sM_rebate_amount;
            _oMobileRetentionOrder_Clone.m_card_holder2 = this.n_sM_card_holder2;
            _oMobileRetentionOrder_Clone.monthly_bank_account_holder = this.n_sMonthly_bank_account_holder;
            _oMobileRetentionOrder_Clone.active = this.n_bActive;
            _oMobileRetentionOrder_Clone.s_premium1 = this.n_sS_premium1;
            _oMobileRetentionOrder_Clone.card_exp_month = this.n_sCard_exp_month;
            _oMobileRetentionOrder_Clone.ob_program_id = this.n_sOb_program_id;
            _oMobileRetentionOrder_Clone.sku = this.n_sSku;
            _oMobileRetentionOrder_Clone.salesmancode = this.n_sSalesmancode;
            _oMobileRetentionOrder_Clone.go_wireless_package_code = this.n_sGo_wireless_package_code;
            _oMobileRetentionOrder_Clone.lob = this.n_sLob;
            _oMobileRetentionOrder_Clone.ref_salesmancode = this.n_sRef_salesmancode;
            _oMobileRetentionOrder_Clone.third_party_hkid = this.n_sThird_party_hkid;
            _oMobileRetentionOrder_Clone.upgrade_existing_pccw_customer = this.n_sUpgrade_existing_pccw_customer;
            _oMobileRetentionOrder_Clone.d_address = this.n_sD_address;
            _oMobileRetentionOrder_Clone.upgrade_registered_mobile_no = this.n_sUpgrade_registered_mobile_no;
            _oMobileRetentionOrder_Clone.gift_code3 = this.n_sGift_code3;
            _oMobileRetentionOrder_Clone.normal_rebate_type = this.n_sNormal_rebate_type;
            _oMobileRetentionOrder_Clone.gift_desc2 = this.n_sGift_desc2;
            _oMobileRetentionOrder_Clone.monthly_bank_account_branch_code = this.n_sMonthly_bank_account_branch_code;
            _oMobileRetentionOrder_Clone.remarks = this.n_sRemarks;
            _oMobileRetentionOrder_Clone.accept = this.n_sAccept;
            _oMobileRetentionOrder_Clone.delivery_exchange = this.n_sDelivery_exchange;
            _oMobileRetentionOrder_Clone.gift_code2 = this.n_sGift_code2;
            _oMobileRetentionOrder_Clone.prepayment_waive = this.n_bPrepayment_waive;
            _oMobileRetentionOrder_Clone.existing_smart_phone_imei = this.n_sExisting_smart_phone_imei;
            _oMobileRetentionOrder_Clone.cust_name = this.n_sCust_name;
            _oMobileRetentionOrder_Clone.upgrade_sponsorships_amount = this.n_sUpgrade_sponsorships_amount;
            _oMobileRetentionOrder_Clone.bill_medium_waive = this.n_bBill_medium_waive;
            _oMobileRetentionOrder_Clone.delivery_exchange_location = this.n_sDelivery_exchange_location;
            _oMobileRetentionOrder_Clone.hs_offer_type_id = this.n_iHs_offer_type_id;
            _oMobileRetentionOrder_Clone.extra_rebate_amount = this.n_sExtra_rebate_amount;
            _oMobileRetentionOrder_Clone.rebate = this.n_sRebate;
            _oMobileRetentionOrder_Clone.upgrade_type = this.n_sUpgrade_type;
            _oMobileRetentionOrder_Clone.go_wireless = this.n_sGo_wireless;
            _oMobileRetentionOrder_Clone.extra_rebate = this.n_sExtra_rebate;
            _oMobileRetentionOrder_Clone.plan_eff = this.n_sPlan_eff;
            _oMobileRetentionOrder_Clone.card_exp_year = this.n_sCard_exp_year;
            _oMobileRetentionOrder_Clone.upgrade_existing_contract_sdate = this.n_dUpgrade_existing_contract_sdate;
            _oMobileRetentionOrder_Clone.ord_place_hkid = this.n_sOrd_place_hkid;
            _oMobileRetentionOrder_Clone.register_address = this.n_sRegister_address;
            _oMobileRetentionOrder_Clone.gender = this.n_sGender;
            _oMobileRetentionOrder_Clone.lob_ac = this.n_sLob_ac;
            _oMobileRetentionOrder_Clone.sim_mrt_no = this.n_iSim_mrt_no;
            _oMobileRetentionOrder_Clone.redemption_notice_option = this.n_sRedemption_notice_option;
            _oMobileRetentionOrder_Clone.delivery_collection_type = this.n_sDelivery_collection_type;
            _oMobileRetentionOrder_Clone.action_date = this.n_dAction_date;
            _oMobileRetentionOrder_Clone.third_party_id_type = this.n_sThird_party_id_type;
            _oMobileRetentionOrder_Clone.org_ftg = this.n_sOrg_ftg;
            _oMobileRetentionOrder_Clone.upgrade_service_tenure = this.n_sUpgrade_service_tenure;
            _oMobileRetentionOrder_Clone.monthly_payment_type = this.n_sMonthly_payment_type;
            _oMobileRetentionOrder_Clone.contact_no = this.n_sContact_no;
            _oMobileRetentionOrder_Clone.org_mrt = this.n_iOrg_mrt;
            _oMobileRetentionOrder_Clone.sim_item_name = this.n_sSim_item_name;
            _oMobileRetentionOrder_Clone.pay_method = this.n_sPay_method;
            _oMobileRetentionOrder_Clone.hs_model = this.n_sHs_model;
            _oMobileRetentionOrder_Clone.gift_code = this.n_sGift_code;
            _oMobileRetentionOrder_Clone.monthly_bank_account_hkid = this.n_sMonthly_bank_account_hkid;
            _oMobileRetentionOrder_Clone.extra_offer = this.n_sExtra_offer;
            _oMobileRetentionOrder_Clone.monthly_bank_account_no = this.n_sMonthly_bank_account_no;
            _oMobileRetentionOrder_Clone.first_month_license_fee = this.n_sFirst_month_license_fee;
            _oMobileRetentionOrder_Clone.retrieve_cnt = this.n_iRetrieve_cnt;
            _oMobileRetentionOrder_Clone.ddate = this.n_dDdate;
            _oMobileRetentionOrder_Clone.s_premium2 = this.n_sS_premium2;
            _oMobileRetentionOrder_Clone.monthly_bank_account_id_type = this.n_sMonthly_bank_account_id_type;
            _oMobileRetentionOrder_Clone.card_type = this.n_sCard_type;
            _oMobileRetentionOrder_Clone.next_bill = this.n_bNext_bill;
            _oMobileRetentionOrder_Clone.pcd_paid_go_wireless = this.n_bPcd_paid_go_wireless;
            _oMobileRetentionOrder_Clone.upgrade_rebate_calculation = this.n_sUpgrade_rebate_calculation;
            _oMobileRetentionOrder_Clone.ext_place_tel = this.n_sExt_place_tel;
            _oMobileRetentionOrder_Clone.m_3rd_hkid = this.n_sM_3rd_hkid;
            _oMobileRetentionOrder_Clone.retention_type = this.n_sRetention_type;
            _oMobileRetentionOrder_Clone.cooling_date = this.n_dCooling_date;
            _oMobileRetentionOrder_Clone.aig_gift = this.n_sAig_gift;
            _oMobileRetentionOrder_Clone.cust_staff_no = this.n_sCust_staff_no;
            _oMobileRetentionOrder_Clone.order_id = this.n_iOrder_id;
            _oMobileRetentionOrder_Clone.family_name = this.n_sFamily_name;
            _oMobileRetentionOrder_Clone.cdate = this.n_dCdate;
            _oMobileRetentionOrder_Clone.status_by_cs_admin = this.n_sStatus_by_cs_admin;
            _oMobileRetentionOrder_Clone.given_name = this.n_sGiven_name;
            _oMobileRetentionOrder_Clone.vip_case = this.n_sVip_case;
            _oMobileRetentionOrder_Clone.org_fee = this.n_sOrg_fee;
            _oMobileRetentionOrder_Clone.s_premium3 = this.n_sS_premium3;
            _oMobileRetentionOrder_Clone.log_date = this.n_dLog_date;
            _oMobileRetentionOrder_Clone.extn = this.n_sExtn;
            _oMobileRetentionOrder_Clone.d_time = this.n_sD_time;
            _oMobileRetentionOrder_Clone.bank_name = this.n_sBank_name;
            _oMobileRetentionOrder_Clone.delivery_exchange_option = this.n_sDelivery_exchange_option;
            _oMobileRetentionOrder_Clone.upgrade_service_account_no = this.n_sUpgrade_service_account_no;
            _oMobileRetentionOrder_Clone.old_ord_id = this.n_iOld_ord_id;
            _oMobileRetentionOrder_Clone.m_card_no = this.n_sM_card_no;
            _oMobileRetentionOrder_Clone.existing_contract_end_date = this.n_sExisting_contract_end_date;
            _oMobileRetentionOrder_Clone.con_eff_date = this.n_dCon_eff_date;
            _oMobileRetentionOrder_Clone.m_3rd_hkid2 = this.n_sM_3rd_hkid2;
            _oMobileRetentionOrder_Clone.amount = this.n_sAmount;
            _oMobileRetentionOrder_Clone.m_3rd_id_type = this.n_sM_3rd_id_type;
            _oMobileRetentionOrder_Clone.id_type = this.n_sId_type;
            _oMobileRetentionOrder_Clone.rate_plan = this.n_sRate_plan;
            _oMobileRetentionOrder_Clone.channel = this.n_sChannel;
            _oMobileRetentionOrder_Clone.action_eff_date = this.n_dAction_eff_date;
            _oMobileRetentionOrder_Clone.issue_type = this.n_sIssue_type;
            _oMobileRetentionOrder_Clone.free_mon = this.n_sFree_mon;
            _oMobileRetentionOrder_Clone.plan_eff_date = this.n_dPlan_eff_date;
            _oMobileRetentionOrder_Clone.teamcode = this.n_sTeamcode;
            _oMobileRetentionOrder_Clone.bill_medium = this.n_sBill_medium;
            _oMobileRetentionOrder_Clone.edf_no = this.n_sEdf_no;
            _oMobileRetentionOrder_Clone.ord_place_by = this.n_sOrd_place_by;
            _oMobileRetentionOrder_Clone.cancel_renew = this.n_sCancel_renew;
            _oMobileRetentionOrder_Clone.preferred_languages = this.n_sPreferred_languages;
            _oMobileRetentionOrder_Clone.hkid = this.n_sHkid;
            _oMobileRetentionOrder_Clone.card_holder = this.n_sCard_holder;
            _oMobileRetentionOrder_Clone.ac_no = this.n_sAc_no;
            _oMobileRetentionOrder_Clone.bill_cut_num = this.n_iBill_cut_num;
            _oMobileRetentionOrder_Clone.premium = this.n_sPremium;
            _oMobileRetentionOrder_Clone.del_remark = this.n_sDel_remark;
            _oMobileRetentionOrder_Clone.gift_imei2 = this.n_sGift_imei2;
            _oMobileRetentionOrder_Clone.reasons = this.n_sReasons;
            _oMobileRetentionOrder_Clone.language = this.n_sLanguage;
            _oMobileRetentionOrder_Clone.rebate_amount = this.n_sRebate_amount;
            _oMobileRetentionOrder_Clone.ord_place_id_type = this.n_sOrd_place_id_type;
            _oMobileRetentionOrder_Clone.m_3rd_contact_no = this.n_sM_3rd_contact_no;
            _oMobileRetentionOrder_Clone.staff_no = this.n_sStaff_no;
            _oMobileRetentionOrder_Clone.sp_d_date = this.n_dSp_d_date;
            _oMobileRetentionOrder_Clone.bundle_name = this.n_sBundle_name;
            _oMobileRetentionOrder_Clone.accessory_waive = this.n_bAccessory_waive;
            _oMobileRetentionOrder_Clone.sim_item_code = this.n_sSim_item_code;
            _oMobileRetentionOrder_Clone.cust_type = this.n_sCust_type;
            _oMobileRetentionOrder_Clone.card_ref_no = this.n_sCard_ref_no;
            _oMobileRetentionOrder_Clone.SetFound(this.n_bFound);
            _oMobileRetentionOrder_Clone.SetDB(this.n_oDB);
            _oMobileRetentionOrder_Clone.SetRow(this.n_oRow);
            _oMobileRetentionOrder_Clone.SetTbl(this.n_oTbl);
            _oMobileRetentionOrder_Clone.SetTableSet(this.n_oTableSet);
            _oMobileRetentionOrder_Clone.MobileOrderVasMobileRetentionOrder = this.MobileOrderVasMobileRetentionOrder;
            for (int i = 0; i < MobileOrderVasMobileRetentionOrder.Length; i++)
                _oMobileRetentionOrder_Clone.MobileOrderVasMobileRetentionOrder[i] = this.MobileOrderVasMobileRetentionOrder[i].DeepClone();
            _oMobileRetentionOrder_Clone.MobileOrderAddressMobileRetentionOrder = this.MobileOrderAddressMobileRetentionOrder;
            for (int i = 0; i < MobileOrderAddressMobileRetentionOrder.Length; i++)
                _oMobileRetentionOrder_Clone.MobileOrderAddressMobileRetentionOrder[i] = this.MobileOrderAddressMobileRetentionOrder[i].DeepClone();
            _oMobileRetentionOrder_Clone.MobileOrderMNPDetailMobileRetentionOrder = this.MobileOrderMNPDetailMobileRetentionOrder;
            for (int i = 0; i < MobileOrderMNPDetailMobileRetentionOrder.Length; i++)
                _oMobileRetentionOrder_Clone.MobileOrderMNPDetailMobileRetentionOrder[i] = this.MobileOrderMNPDetailMobileRetentionOrder[i].DeepClone();
            _oMobileRetentionOrder_Clone.MobileOrderThreePartyMobileRetentionOrder = this.MobileOrderThreePartyMobileRetentionOrder;
            for (int i = 0; i < MobileOrderThreePartyMobileRetentionOrder.Length; i++)
                _oMobileRetentionOrder_Clone.MobileOrderThreePartyMobileRetentionOrder[i] = this.MobileOrderThreePartyMobileRetentionOrder[i].DeepClone();
            
            return _oMobileRetentionOrder_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_sGift_imei=global::System.String.Empty;
            n_sS_premium4=global::System.String.Empty;
            n_sUpgrade_existing_customer_type=global::System.String.Empty;
            n_sGift_desc4=global::System.String.Empty;
            n_sAccessory_desc=global::System.String.Empty;
            n_sStaff_name=global::System.String.Empty;
            n_sAction_required=global::System.String.Empty;
            n_dVas_eff_date=null;
            n_sMonthly_bank_account_bank_code=global::System.String.Empty;
            n_sSim_item_number=global::System.String.Empty;
            n_sSpecial_handling_dummy_code=global::System.String.Empty;
            n_sCard_no=global::System.String.Empty;
            n_sM_card_exp_year=global::System.String.Empty;
            n_sBill_medium_email=global::System.String.Empty;
            n_sRemarks2PY=global::System.String.Empty;
            n_sTrade_field=global::System.String.Empty;
            n_sOrd_place_tel=global::System.String.Empty;
            n_sAction_of_rate_plan_effective=global::System.String.Empty;
            n_sCooling_offer=global::System.String.Empty;
            n_sUpgrade_handset_offer_rebate_schedule=global::System.String.Empty;
            n_sChange_payment_type=global::System.String.Empty;
            n_dDate_of_birth=null;
            n_sContact_person=global::System.String.Empty;
            n_sExtra_d_charge=global::System.String.Empty;
            n_sTl_name=global::System.String.Empty;
            n_bFast_start=null;
            n_sSp_ref_no=global::System.String.Empty;
            n_dEdate=null;
            n_sExist_cust_plan=global::System.String.Empty;
            n_sOrd_place_rel=global::System.String.Empty;
            n_iMrt_no=null;
            n_sImei_no=global::System.String.Empty;
            n_sExisting_smart_phone_model=global::System.String.Empty;
            n_sBank_code=global::System.String.Empty;
            n_sPos_ref_no=global::System.String.Empty;
            n_dBill_cut_date=null;
            n_sGift_imei3=global::System.String.Empty;
            n_sExist_plan=global::System.String.Empty;
            n_bWaive=null;
            n_sProgram=global::System.String.Empty;
            n_sFirst_month_fee=global::System.String.Empty;
            n_sR_offer=global::System.String.Empty;
            n_sCid=global::System.String.Empty;
            n_sDid=global::System.String.Empty;
            n_sFtg_tenure=global::System.String.Empty;
            n_sCon_per=global::System.String.Empty;
            n_sGift_code4=global::System.String.Empty;
            n_sEasywatch_type=global::System.String.Empty;
            n_sSms_mrt=global::System.String.Empty;
            n_sMonthly_payment_method=global::System.String.Empty;
            n_sRemarks2EDF=global::System.String.Empty;
            n_sGift_desc3=global::System.String.Empty;
            n_sGift_imei4=global::System.String.Empty;
            n_sMonthly_bank_account_hkid2=global::System.String.Empty;
            n_dD_date=null;
            n_sGift_desc=global::System.String.Empty;
            n_sPool=global::System.String.Empty;
            n_lCn_mrt_no=null;
            n_sAccessory_imei=global::System.String.Empty;
            n_sThird_party_credit_card=global::System.String.Empty;
            n_sSpecial_approval=global::System.String.Empty;
            n_dUpgrade_existing_contract_edate=null;
            n_sAccessory_code=global::System.String.Empty;
            n_sS_premium=global::System.String.Empty;
            n_sRef_staff_no=global::System.String.Empty;
            n_sAccessory_price=global::System.String.Empty;
            n_sM_card_exp_month=global::System.String.Empty;
            n_sInstallment_period=global::System.String.Empty;
            n_sM_card_type=global::System.String.Empty;
            n_sEasywatch_ord_id=global::System.String.Empty;
            n_bNormal_rebate=null;
            n_sM_rebate_amount=global::System.String.Empty;
            n_sM_card_holder2=global::System.String.Empty;
            n_sMonthly_bank_account_holder=global::System.String.Empty;
            n_bActive=null;
            n_sS_premium1=global::System.String.Empty;
            n_sCard_exp_month=global::System.String.Empty;
            n_sOb_program_id=global::System.String.Empty;
            n_sSku=global::System.String.Empty;
            n_sSalesmancode=global::System.String.Empty;
            n_sGo_wireless_package_code=global::System.String.Empty;
            n_sLob=global::System.String.Empty;
            n_sRef_salesmancode=global::System.String.Empty;
            n_sThird_party_hkid=global::System.String.Empty;
            n_sUpgrade_existing_pccw_customer=global::System.String.Empty;
            n_sD_address=global::System.String.Empty;
            n_sUpgrade_registered_mobile_no=global::System.String.Empty;
            n_sGift_code3=global::System.String.Empty;
            n_sNormal_rebate_type=global::System.String.Empty;
            n_sGift_desc2=global::System.String.Empty;
            n_sMonthly_bank_account_branch_code=global::System.String.Empty;
            n_sRemarks=global::System.String.Empty;
            n_sAccept=global::System.String.Empty;
            n_sDelivery_exchange=global::System.String.Empty;
            n_sGift_code2=global::System.String.Empty;
            n_bPrepayment_waive=null;
            n_sExisting_smart_phone_imei=global::System.String.Empty;
            n_sCust_name=global::System.String.Empty;
            n_sUpgrade_sponsorships_amount=global::System.String.Empty;
            n_bBill_medium_waive=null;
            n_sDelivery_exchange_location=global::System.String.Empty;
            n_iHs_offer_type_id=null;
            n_sExtra_rebate_amount=global::System.String.Empty;
            n_sRebate=global::System.String.Empty;
            n_sUpgrade_type=global::System.String.Empty;
            n_sGo_wireless=global::System.String.Empty;
            n_sExtra_rebate=global::System.String.Empty;
            n_sPlan_eff=global::System.String.Empty;
            n_sCard_exp_year=global::System.String.Empty;
            n_dUpgrade_existing_contract_sdate=null;
            n_sOrd_place_hkid=global::System.String.Empty;
            n_sRegister_address=global::System.String.Empty;
            n_sGender=global::System.String.Empty;
            n_sLob_ac=global::System.String.Empty;
            n_iSim_mrt_no=null;
            n_sRedemption_notice_option=global::System.String.Empty;
            n_sDelivery_collection_type=global::System.String.Empty;
            n_dAction_date=null;
            n_sThird_party_id_type=global::System.String.Empty;
            n_sOrg_ftg=global::System.String.Empty;
            n_sUpgrade_service_tenure=global::System.String.Empty;
            n_sMonthly_payment_type=global::System.String.Empty;
            n_sContact_no=global::System.String.Empty;
            n_iOrg_mrt=null;
            n_sSim_item_name=global::System.String.Empty;
            n_sPay_method=global::System.String.Empty;
            n_sHs_model=global::System.String.Empty;
            n_sGift_code=global::System.String.Empty;
            n_sMonthly_bank_account_hkid=global::System.String.Empty;
            n_sExtra_offer=global::System.String.Empty;
            n_sMonthly_bank_account_no=global::System.String.Empty;
            n_sFirst_month_license_fee=global::System.String.Empty;
            n_iRetrieve_cnt=null;
            n_dDdate=null;
            n_sS_premium2=global::System.String.Empty;
            n_sMonthly_bank_account_id_type=global::System.String.Empty;
            n_sCard_type=global::System.String.Empty;
            n_bNext_bill=null;
            n_bPcd_paid_go_wireless=null;
            n_sUpgrade_rebate_calculation=global::System.String.Empty;
            n_sExt_place_tel=global::System.String.Empty;
            n_sM_3rd_hkid=global::System.String.Empty;
            n_sRetention_type=global::System.String.Empty;
            n_dCooling_date=null;
            n_sAig_gift=global::System.String.Empty;
            n_sCust_staff_no=global::System.String.Empty;
            n_iOrder_id=null;
            n_sFamily_name=global::System.String.Empty;
            n_dCdate=null;
            n_sStatus_by_cs_admin=global::System.String.Empty;
            n_sGiven_name=global::System.String.Empty;
            n_sVip_case=global::System.String.Empty;
            n_sOrg_fee=global::System.String.Empty;
            n_sS_premium3=global::System.String.Empty;
            n_dLog_date=null;
            n_sExtn=global::System.String.Empty;
            n_sD_time=global::System.String.Empty;
            n_sBank_name=global::System.String.Empty;
            n_sDelivery_exchange_option=global::System.String.Empty;
            n_sUpgrade_service_account_no=global::System.String.Empty;
            n_iOld_ord_id=null;
            n_sM_card_no=global::System.String.Empty;
            n_sExisting_contract_end_date=global::System.String.Empty;
            n_dCon_eff_date=null;
            n_sM_3rd_hkid2=global::System.String.Empty;
            n_sAmount=global::System.String.Empty;
            n_sM_3rd_id_type=global::System.String.Empty;
            n_sId_type=global::System.String.Empty;
            n_sRate_plan=global::System.String.Empty;
            n_sChannel=global::System.String.Empty;
            n_dAction_eff_date=null;
            n_sIssue_type=global::System.String.Empty;
            n_sFree_mon=global::System.String.Empty;
            n_dPlan_eff_date=null;
            n_sTeamcode=global::System.String.Empty;
            n_sBill_medium=global::System.String.Empty;
            n_sEdf_no=global::System.String.Empty;
            n_sOrd_place_by=global::System.String.Empty;
            n_sCancel_renew=global::System.String.Empty;
            n_sPreferred_languages=global::System.String.Empty;
            n_sHkid=global::System.String.Empty;
            n_sCard_holder=global::System.String.Empty;
            n_sAc_no=global::System.String.Empty;
            n_iBill_cut_num=null;
            n_sPremium=global::System.String.Empty;
            n_sDel_remark=global::System.String.Empty;
            n_sGift_imei2=global::System.String.Empty;
            n_sReasons=global::System.String.Empty;
            n_sLanguage=global::System.String.Empty;
            n_sRebate_amount=global::System.String.Empty;
            n_sOrd_place_id_type=global::System.String.Empty;
            n_sM_3rd_contact_no=global::System.String.Empty;
            n_sStaff_no=global::System.String.Empty;
            n_dSp_d_date=null;
            n_sBundle_name=global::System.String.Empty;
            n_bAccessory_waive=null;
            n_sSim_item_code=global::System.String.Empty;
            n_sCust_type=global::System.String.Empty;
            n_sCard_ref_no=global::System.String.Empty;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = MobileRetentionOrderInfoDLL.CreateInfoInstanceObject();
            n_oMobileOrderVasMobileRetentionOrder=null;
            n_oMobileOrderAddressMobileRetentionOrder=null;
            n_oMobileOrderMNPDetailMobileRetentionOrder=null;
            n_oMobileOrderThreePartyMobileRetentionOrder=null;
        }
        #endregion
    }
}


