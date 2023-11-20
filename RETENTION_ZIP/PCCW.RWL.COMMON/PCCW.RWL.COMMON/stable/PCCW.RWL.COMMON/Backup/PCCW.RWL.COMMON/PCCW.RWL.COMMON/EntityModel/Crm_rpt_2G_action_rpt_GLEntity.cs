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
///-- Create date: <Create Date 2009-07-13>
///-- Description:	<Description,Table :[crm_rpt_2G_action_rpt_GL],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [crm_rpt_2G_action_rpt_GL] Object Base layer
    /// </summary>
    
    [System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"crm_rpt_2G_action_rpt_GL")]
    public class Crm_rpt_2G_action_rpt_GLEntity: IDisposable ,IEntity<MSSQLConnect>{
        
        
        protected System.Nullable<bool> n_bTelemarketing_suppress_flag=null;
        #region telemarketing_suppress_flag
        [System.Data.Linq.Mapping.Column(Name="[telemarketing_suppress_flag]", Storage="n_bTelemarketing_suppress_flag")]
        public System.Nullable<bool> telemarketing_suppress_flag{
            get{
                return this.n_bTelemarketing_suppress_flag;
            }
            set{
                this.n_bTelemarketing_suppress_flag=value;
            }
        }
        #endregion telemarketing_suppress_flag
        
        
        protected System.Nullable<DateTime> n_dEnd_date=null;
        #region end_date
        [System.Data.Linq.Mapping.Column(Name="[end_date]", Storage="n_dEnd_date")]
        public System.Nullable<DateTime> end_date{
            get{
                return this.n_dEnd_date;
            }
            set{
                this.n_dEnd_date=value;
            }
        }
        #endregion end_date
        
        
        protected System.Nullable<DateTime> n_dDdate=null;
        #region ddate
        [System.Data.Linq.Mapping.Column(Name="[ddate]", Storage="n_dDdate")]
        public System.Nullable<DateTime> ddate{
            get{
                return this.n_dDdate;
            }
            set{
                this.n_dDdate=value;
            }
        }
        #endregion ddate
        
        
        protected string n_sAirtime_hs_model=string.Empty;
        #region airtime_hs_model
        [System.Data.Linq.Mapping.Column(Name="[airtime_hs_model]", Storage="n_sAirtime_hs_model")]
        public string airtime_hs_model{
            get{
                return this.n_sAirtime_hs_model;
            }
            set{
                this.n_sAirtime_hs_model=value;
            }
        }
        #endregion airtime_hs_model
        
        
        protected string n_sTradefield=string.Empty;
        #region tradefield
        [System.Data.Linq.Mapping.Column(Name="[tradefield]", Storage="n_sTradefield")]
        public string tradefield{
            get{
                return this.n_sTradefield;
            }
            set{
                this.n_sTradefield=value;
            }
        }
        #endregion tradefield
        
        
        protected string n_sCalllist_name=string.Empty;
        #region calllist_name
        [System.Data.Linq.Mapping.Column(Name="[calllist_name]", Storage="n_sCalllist_name")]
        public string calllist_name{
            get{
                return this.n_sCalllist_name;
            }
            set{
                this.n_sCalllist_name=value;
            }
        }
        #endregion calllist_name
        
        
        protected string n_sField1=string.Empty;
        #region field1
        [System.Data.Linq.Mapping.Column(Name="[field1]", Storage="n_sField1")]
        public string field1{
            get{
                return this.n_sField1;
            }
            set{
                this.n_sField1=value;
            }
        }
        #endregion field1
        
        
        protected string n_sRemarks=string.Empty;
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
        
        
        protected System.Nullable<int> n_iBill_cycle=null;
        #region bill_cycle
        [System.Data.Linq.Mapping.Column(Name="[bill_cycle]", Storage="n_iBill_cycle")]
        public System.Nullable<int> bill_cycle{
            get{
                return this.n_iBill_cycle;
            }
            set{
                this.n_iBill_cycle=value;
            }
        }
        #endregion bill_cycle
        
        
        protected string n_sAddr_2=string.Empty;
        #region addr_2
        [System.Data.Linq.Mapping.Column(Name="[addr_2]", Storage="n_sAddr_2")]
        public string addr_2{
            get{
                return this.n_sAddr_2;
            }
            set{
                this.n_sAddr_2=value;
            }
        }
        #endregion addr_2
        
        
        protected string n_sId_number=string.Empty;
        #region id_number
        [System.Data.Linq.Mapping.Column(Name="[id_number]", Storage="n_sId_number")]
        public string id_number{
            get{
                return this.n_sId_number;
            }
            set{
                this.n_sId_number=value;
            }
        }
        #endregion id_number
        
        
        protected string n_sAttention_name_formartted=string.Empty;
        #region attention_name_formartted
        [System.Data.Linq.Mapping.Column(Name="[attention_name_formartted]", Storage="n_sAttention_name_formartted")]
        public string attention_name_formartted{
            get{
                return this.n_sAttention_name_formartted;
            }
            set{
                this.n_sAttention_name_formartted=value;
            }
        }
        #endregion attention_name_formartted
        
        
        protected string n_sCustomer_name_formartted=string.Empty;
        #region customer_name_formartted
        [System.Data.Linq.Mapping.Column(Name="[customer_name_formartted]", Storage="n_sCustomer_name_formartted")]
        public string customer_name_formartted{
            get{
                return this.n_sCustomer_name_formartted;
            }
            set{
                this.n_sCustomer_name_formartted=value;
            }
        }
        #endregion customer_name_formartted
        
        
        protected System.Nullable<DateTime> n_dMnp_rebate_end_date=null;
        #region mnp_rebate_end_date
        [System.Data.Linq.Mapping.Column(Name="[mnp_rebate_end_date]", Storage="n_dMnp_rebate_end_date")]
        public System.Nullable<DateTime> mnp_rebate_end_date{
            get{
                return this.n_dMnp_rebate_end_date;
            }
            set{
                this.n_dMnp_rebate_end_date=value;
            }
        }
        #endregion mnp_rebate_end_date
        
        
        protected string n_sField3=string.Empty;
        #region field3
        [System.Data.Linq.Mapping.Column(Name="[field3]", Storage="n_sField3")]
        public string field3{
            get{
                return this.n_sField3;
            }
            set{
                this.n_sField3=value;
            }
        }
        #endregion field3
        
        
        protected string n_sAddr_4=string.Empty;
        #region addr_4
        [System.Data.Linq.Mapping.Column(Name="[addr_4]", Storage="n_sAddr_4")]
        public string addr_4{
            get{
                return this.n_sAddr_4;
            }
            set{
                this.n_sAddr_4=value;
            }
        }
        #endregion addr_4
        
        
        protected string n_sProgram=string.Empty;
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
        
        
        protected string n_sProp_plan=string.Empty;
        #region prop_plan
        [System.Data.Linq.Mapping.Column(Name="[prop_plan]", Storage="n_sProp_plan")]
        public string prop_plan{
            get{
                return this.n_sProp_plan;
            }
            set{
                this.n_sProp_plan=value;
            }
        }
        #endregion prop_plan
        
        
        protected string n_sExpired_month=string.Empty;
        #region expired_month
        [System.Data.Linq.Mapping.Column(Name="[expired_month]", Storage="n_sExpired_month")]
        public string expired_month{
            get{
                return this.n_sExpired_month;
            }
            set{
                this.n_sExpired_month=value;
            }
        }
        #endregion expired_month
        
        
        protected string n_sCustomer_group=string.Empty;
        #region customer_group
        [System.Data.Linq.Mapping.Column(Name="[customer_group]", Storage="n_sCustomer_group")]
        public string customer_group{
            get{
                return this.n_sCustomer_group;
            }
            set{
                this.n_sCustomer_group=value;
            }
        }
        #endregion customer_group
        
        
        protected System.Nullable<DateTime> n_dJoin_date=null;
        #region join_date
        [System.Data.Linq.Mapping.Column(Name="[join_date]", Storage="n_dJoin_date")]
        public System.Nullable<DateTime> join_date{
            get{
                return this.n_dJoin_date;
            }
            set{
                this.n_dJoin_date=value;
            }
        }
        #endregion join_date
        
        
        protected System.Nullable<bool> n_bIdd_flg=null;
        #region idd_flg
        [System.Data.Linq.Mapping.Column(Name="[idd_flg]", Storage="n_bIdd_flg")]
        public System.Nullable<bool> idd_flg{
            get{
                return this.n_bIdd_flg;
            }
            set{
                this.n_bIdd_flg=value;
            }
        }
        #endregion idd_flg
        
        
        protected System.Nullable<bool> n_bActive=null;
        #region active
        [System.Data.Linq.Mapping.Column(Name="[active]", Storage="n_bActive")]
        public System.Nullable<bool> active{
            get{
                return this.n_bActive;
            }
            set{
                this.n_bActive=value;
            }
        }
        #endregion active
        
        
        protected string n_sPeriod=string.Empty;
        #region period
        [System.Data.Linq.Mapping.Column(Name="[period]", Storage="n_sPeriod")]
        public string period{
            get{
                return this.n_sPeriod;
            }
            set{
                this.n_sPeriod=value;
            }
        }
        #endregion period
        
        
        protected string n_sField2=string.Empty;
        #region field2
        [System.Data.Linq.Mapping.Column(Name="[field2]", Storage="n_sField2")]
        public string field2{
            get{
                return this.n_sField2;
            }
            set{
                this.n_sField2=value;
            }
        }
        #endregion field2
        
        
        protected System.Nullable<DateTime> n_dStart_date=null;
        #region start_date
        [System.Data.Linq.Mapping.Column(Name="[start_date]", Storage="n_dStart_date")]
        public System.Nullable<DateTime> start_date{
            get{
                return this.n_dStart_date;
            }
            set{
                this.n_dStart_date=value;
            }
        }
        #endregion start_date
        
        
        protected string n_sPlan_fee=string.Empty;
        #region plan_fee
        [System.Data.Linq.Mapping.Column(Name="[plan_fee]", Storage="n_sPlan_fee")]
        public string plan_fee{
            get{
                return this.n_sPlan_fee;
            }
            set{
                this.n_sPlan_fee=value;
            }
        }
        #endregion plan_fee
        
        
        protected string n_sRate_plan=string.Empty;
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
        
        
        protected string n_sSegment=string.Empty;
        #region segment
        [System.Data.Linq.Mapping.Column(Name="[segment]", Storage="n_sSegment")]
        public string segment{
            get{
                return this.n_sSegment;
            }
            set{
                this.n_sSegment=value;
            }
        }
        #endregion segment
        
        
        protected System.Nullable<DateTime> n_dCdate=null;
        #region cdate
        [System.Data.Linq.Mapping.Column(Name="[cdate]", Storage="n_dCdate")]
        public System.Nullable<DateTime> cdate{
            get{
                return this.n_dCdate;
            }
            set{
                this.n_dCdate=value;
            }
        }
        #endregion cdate
        
        
        protected string n_sProgram_id=string.Empty;
        #region program_id
        [System.Data.Linq.Mapping.Column(Name="[program_id]", Storage="n_sProgram_id")]
        public string program_id{
            get{
                return this.n_sProgram_id;
            }
            set{
                this.n_sProgram_id=value;
            }
        }
        #endregion program_id
        
        
        protected string n_sPassword=string.Empty;
        #region password
        [System.Data.Linq.Mapping.Column(Name="[password]", Storage="n_sPassword")]
        public string password{
            get{
                return this.n_sPassword;
            }
            set{
                this.n_sPassword=value;
            }
        }
        #endregion password
        
        
        protected string n_sPayment_method=string.Empty;
        #region payment_method
        [System.Data.Linq.Mapping.Column(Name="[payment_method]", Storage="n_sPayment_method")]
        public string payment_method{
            get{
                return this.n_sPayment_method;
            }
            set{
                this.n_sPayment_method=value;
            }
        }
        #endregion payment_method
        
        
        protected string n_sContract_id=string.Empty;
        #region contract_id
        [System.Data.Linq.Mapping.Column(Name="[contract_id]", Storage="n_sContract_id")]
        public string contract_id{
            get{
                return this.n_sContract_id;
            }
            set{
                this.n_sContract_id=value;
            }
        }
        #endregion contract_id
        
        
        protected string n_sCustomer_code=string.Empty;
        #region customer_code
        [System.Data.Linq.Mapping.Column(Name="[customer_code]", Storage="n_sCustomer_code")]
        public string customer_code{
            get{
                return this.n_sCustomer_code;
            }
            set{
                this.n_sCustomer_code=value;
            }
        }
        #endregion customer_code
        
        
        protected string n_sMobile_no=string.Empty;
        #region mobile_no
        [System.Data.Linq.Mapping.Column(Name="[mobile_no]", Storage="n_sMobile_no")]
        public string mobile_no{
            get{
                return this.n_sMobile_no;
            }
            set{
                this.n_sMobile_no=value;
            }
        }
        #endregion mobile_no
        
        
        protected string n_sAls_flg=string.Empty;
        #region als_flg
        [System.Data.Linq.Mapping.Column(Name="[als_flg]", Storage="n_sAls_flg")]
        public string als_flg{
            get{
                return this.n_sAls_flg;
            }
            set{
                this.n_sAls_flg=value;
            }
        }
        #endregion als_flg
        
        
        protected string n_sVas_desc=string.Empty;
        #region vas_desc
        [System.Data.Linq.Mapping.Column(Name="[vas_desc]", Storage="n_sVas_desc")]
        public string vas_desc{
            get{
                return this.n_sVas_desc;
            }
            set{
                this.n_sVas_desc=value;
            }
        }
        #endregion vas_desc
        
        
        protected string n_sAddr_3=string.Empty;
        #region addr_3
        [System.Data.Linq.Mapping.Column(Name="[addr_3]", Storage="n_sAddr_3")]
        public string addr_3{
            get{
                return this.n_sAddr_3;
            }
            set{
                this.n_sAddr_3=value;
            }
        }
        #endregion addr_3
        
        
        protected string n_sSubscriber_tier=string.Empty;
        #region subscriber_tier
        [System.Data.Linq.Mapping.Column(Name="[subscriber_tier]", Storage="n_sSubscriber_tier")]
        public string subscriber_tier{
            get{
                return this.n_sSubscriber_tier;
            }
            set{
                this.n_sSubscriber_tier=value;
            }
        }
        #endregion subscriber_tier
        
        
        protected string n_sCustomer_id=string.Empty;
        #region customer_id
        [System.Data.Linq.Mapping.Column(Name="[customer_id]", Storage="n_sCustomer_id")]
        public string customer_id{
            get{
                return this.n_sCustomer_id;
            }
            set{
                this.n_sCustomer_id=value;
            }
        }
        #endregion customer_id
        
        
        protected System.Nullable<DateTime> n_dHandset_rebate_end_date=null;
        #region handset_rebate_end_date
        [System.Data.Linq.Mapping.Column(Name="[handset_rebate_end_date]", Storage="n_dHandset_rebate_end_date")]
        public System.Nullable<DateTime> handset_rebate_end_date{
            get{
                return this.n_dHandset_rebate_end_date;
            }
            set{
                this.n_dHandset_rebate_end_date=value;
            }
        }
        #endregion handset_rebate_end_date
        
        
        protected System.Nullable<int> n_iPlan_free_inter_min=null;
        #region plan_free_inter_min
        [System.Data.Linq.Mapping.Column(Name="[plan_free_inter_min]", Storage="n_iPlan_free_inter_min")]
        public System.Nullable<int> plan_free_inter_min{
            get{
                return this.n_iPlan_free_inter_min;
            }
            set{
                this.n_iPlan_free_inter_min=value;
            }
        }
        #endregion plan_free_inter_min
        
        
        protected string n_sCid=string.Empty;
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
        
        
        protected string n_sDid=string.Empty;
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
        
        
        protected System.Nullable<int> n_iId=null;
        #region id
        [System.Data.Linq.Mapping.Column(Name="[id]", Storage="n_iId")]
        public System.Nullable<int> id{
            get{
                return this.n_iId;
            }
            set{
                this.n_iId=value;
            }
        }
        #endregion id
        
        
        protected System.Nullable<int> n_iPlan_free_intra_min=null;
        #region plan_free_intra_min
        [System.Data.Linq.Mapping.Column(Name="[plan_free_intra_min]", Storage="n_iPlan_free_intra_min")]
        public System.Nullable<int> plan_free_intra_min{
            get{
                return this.n_iPlan_free_intra_min;
            }
            set{
                this.n_iPlan_free_intra_min=value;
            }
        }
        #endregion plan_free_intra_min
        
        
        protected System.Nullable<bool> n_bOriginal_telemarketing_suppress_flag=null;
        #region original_telemarketing_suppress_flag
        [System.Data.Linq.Mapping.Column(Name="[original_telemarketing_suppress_flag]", Storage="n_bOriginal_telemarketing_suppress_flag")]
        public System.Nullable<bool> original_telemarketing_suppress_flag{
            get{
                return this.n_bOriginal_telemarketing_suppress_flag;
            }
            set{
                this.n_bOriginal_telemarketing_suppress_flag=value;
            }
        }
        #endregion original_telemarketing_suppress_flag
        
        
        protected string n_sContact_number=string.Empty;
        #region contact_number
        [System.Data.Linq.Mapping.Column(Name="[contact_number]", Storage="n_sContact_number")]
        public string contact_number{
            get{
                return this.n_sContact_number;
            }
            set{
                this.n_sContact_number=value;
            }
        }
        #endregion contact_number
        
        
        protected string n_sAddr_1=string.Empty;
        #region addr_1
        [System.Data.Linq.Mapping.Column(Name="[addr_1]", Storage="n_sAddr_1")]
        public string addr_1{
            get{
                return this.n_sAddr_1;
            }
            set{
                this.n_sAddr_1=value;
            }
        }
        #endregion addr_1
        
        
        protected System.Nullable<DateTime> n_dMax_contract_end_date=null;
        #region max_contract_end_date
        [System.Data.Linq.Mapping.Column(Name="[max_contract_end_date]", Storage="n_dMax_contract_end_date")]
        public System.Nullable<DateTime> max_contract_end_date{
            get{
                return this.n_dMax_contract_end_date;
            }
            set{
                this.n_dMax_contract_end_date=value;
            }
        }
        #endregion max_contract_end_date
        
        
        protected string n_sId1=string.Empty;
        #region id1
        [System.Data.Linq.Mapping.Column(Name="[id1]", Storage="n_sId1")]
        public string id1{
            get{
                return this.n_sId1;
            }
            set{
                this.n_sId1=value;
            }
        }
        #endregion id1
        
        
        protected string n_sAutopay=string.Empty;
        #region autopay
        [System.Data.Linq.Mapping.Column(Name="[autopay]", Storage="n_sAutopay")]
        public string autopay{
            get{
                return this.n_sAutopay;
            }
            set{
                this.n_sAutopay=value;
            }
        }
        #endregion autopay
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private Crm_rpt_2G_action_rpt_GLInfo n_oTableSet = new Crm_rpt_2G_action_rpt_GLInfo();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string als_flg="als_flg";
            public const string end_date="end_date";
            public const string remarks="remarks";
            public const string airtime_hs_model="airtime_hs_model";
            public const string start_date="start_date";
            public const string calllist_name="calllist_name";
            public const string join_date="join_date";
            public const string field1="field1";
            public const string bill_cycle="bill_cycle";
            public const string addr_3="addr_3";
            public const string addr_2="addr_2";
            public const string id_number="id_number";
            public const string attention_name_formartted="attention_name_formartted";
            public const string customer_name_formartted="customer_name_formartted";
            public const string autopay="autopay";
            public const string field3="field3";
            public const string addr_4="addr_4";
            public const string program="program";
            public const string prop_plan="prop_plan";
            public const string customer_group="customer_group";
            public const string customer_code="customer_code";
            public const string telemarketing_suppress_flag="telemarketing_suppress_flag";
            public const string idd_flg="idd_flg";
            public const string active="active";
            public const string ddate="ddate";
            public const string id="id";
            public const string plan_fee="plan_fee";
            public const string rate_plan="rate_plan";
            public const string segment="segment";
            public const string id1="id1";
            public const string password="password";
            public const string payment_method="payment_method";
            public const string contract_id="contract_id";
            public const string field2="field2";
            public const string mobile_no="mobile_no";
            public const string period="period";
            public const string vas_desc="vas_desc";
            public const string cdate="cdate";
            public const string subscriber_tier="subscriber_tier";
            public const string customer_id="customer_id";
            public const string handset_rebate_end_date="handset_rebate_end_date";
            public const string plan_free_inter_min="plan_free_inter_min";
            public const string cid="cid";
            public const string did="did";
            public const string expired_month="expired_month";
            public const string plan_free_intra_min="plan_free_intra_min";
            public const string original_telemarketing_suppress_flag="original_telemarketing_suppress_flag";
            public const string contact_number="contact_number";
            public const string tradefield="tradefield";
            public const string addr_1="addr_1";
            public const string max_contract_end_date="max_contract_end_date";
            public const string mnp_rebate_end_date="mnp_rebate_end_date";
            public const string program_id="program_id";
            public const string Crm_rpt_2G_action_rpt_GL_table_name = Configurator.MSSQLTablePrefix + "crm_rpt_2G_action_rpt_GL";
            public static string TableName() { return Crm_rpt_2G_action_rpt_GL_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public Crm_rpt_2G_action_rpt_GLEntity(){
            Init();
        }
        public Crm_rpt_2G_action_rpt_GLEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public Crm_rpt_2G_action_rpt_GLEntity(MSSQLConnect x_oDB,System.Nullable<int> x_iId){
            n_oDB=x_oDB;
            this.Load(x_iId);
            Init();
        }
        
        ~Crm_rpt_2G_action_rpt_GLEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(System.Nullable<int> x_iId){
            if (n_oDB==null) { return false; }
            if (x_iId==null) { return false; }
            string _sQuery = "SELECT [crm_rpt_2G_action_rpt_GL].[telemarketing_suppress_flag] AS CRM_RPT_2G_ACTION_RPT_GL_TELEMARKETING_SUPPRESS_FLAG,[crm_rpt_2G_action_rpt_GL].[end_date] AS CRM_RPT_2G_ACTION_RPT_GL_END_DATE,[crm_rpt_2G_action_rpt_GL].[ddate] AS CRM_RPT_2G_ACTION_RPT_GL_DDATE,[crm_rpt_2G_action_rpt_GL].[airtime_hs_model] AS CRM_RPT_2G_ACTION_RPT_GL_AIRTIME_HS_MODEL,[crm_rpt_2G_action_rpt_GL].[tradefield] AS CRM_RPT_2G_ACTION_RPT_GL_TRADEFIELD,[crm_rpt_2G_action_rpt_GL].[calllist_name] AS CRM_RPT_2G_ACTION_RPT_GL_CALLLIST_NAME,[crm_rpt_2G_action_rpt_GL].[field1] AS CRM_RPT_2G_ACTION_RPT_GL_FIELD1,[crm_rpt_2G_action_rpt_GL].[remarks] AS CRM_RPT_2G_ACTION_RPT_GL_REMARKS,[crm_rpt_2G_action_rpt_GL].[bill_cycle] AS CRM_RPT_2G_ACTION_RPT_GL_BILL_CYCLE,[crm_rpt_2G_action_rpt_GL].[addr_2] AS CRM_RPT_2G_ACTION_RPT_GL_ADDR_2,[crm_rpt_2G_action_rpt_GL].[id_number] AS CRM_RPT_2G_ACTION_RPT_GL_ID_NUMBER,[crm_rpt_2G_action_rpt_GL].[attention_name_formartted] AS CRM_RPT_2G_ACTION_RPT_GL_ATTENTION_NAME_FORMARTTED,[crm_rpt_2G_action_rpt_GL].[customer_name_formartted] AS CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_NAME_FORMARTTED,[crm_rpt_2G_action_rpt_GL].[mnp_rebate_end_date] AS CRM_RPT_2G_ACTION_RPT_GL_MNP_REBATE_END_DATE,[crm_rpt_2G_action_rpt_GL].[field3] AS CRM_RPT_2G_ACTION_RPT_GL_FIELD3,[crm_rpt_2G_action_rpt_GL].[addr_4] AS CRM_RPT_2G_ACTION_RPT_GL_ADDR_4,[crm_rpt_2G_action_rpt_GL].[program] AS CRM_RPT_2G_ACTION_RPT_GL_PROGRAM,[crm_rpt_2G_action_rpt_GL].[prop_plan] AS CRM_RPT_2G_ACTION_RPT_GL_PROP_PLAN,[crm_rpt_2G_action_rpt_GL].[expired_month] AS CRM_RPT_2G_ACTION_RPT_GL_EXPIRED_MONTH,[crm_rpt_2G_action_rpt_GL].[customer_group] AS CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_GROUP,[crm_rpt_2G_action_rpt_GL].[join_date] AS CRM_RPT_2G_ACTION_RPT_GL_JOIN_DATE,[crm_rpt_2G_action_rpt_GL].[idd_flg] AS CRM_RPT_2G_ACTION_RPT_GL_IDD_FLG,[crm_rpt_2G_action_rpt_GL].[active] AS CRM_RPT_2G_ACTION_RPT_GL_ACTIVE,[crm_rpt_2G_action_rpt_GL].[period] AS CRM_RPT_2G_ACTION_RPT_GL_PERIOD,[crm_rpt_2G_action_rpt_GL].[field2] AS CRM_RPT_2G_ACTION_RPT_GL_FIELD2,[crm_rpt_2G_action_rpt_GL].[start_date] AS CRM_RPT_2G_ACTION_RPT_GL_START_DATE,[crm_rpt_2G_action_rpt_GL].[plan_fee] AS CRM_RPT_2G_ACTION_RPT_GL_PLAN_FEE,[crm_rpt_2G_action_rpt_GL].[rate_plan] AS CRM_RPT_2G_ACTION_RPT_GL_RATE_PLAN,[crm_rpt_2G_action_rpt_GL].[segment] AS CRM_RPT_2G_ACTION_RPT_GL_SEGMENT,[crm_rpt_2G_action_rpt_GL].[cdate] AS CRM_RPT_2G_ACTION_RPT_GL_CDATE,[crm_rpt_2G_action_rpt_GL].[program_id] AS CRM_RPT_2G_ACTION_RPT_GL_PROGRAM_ID,[crm_rpt_2G_action_rpt_GL].[password] AS CRM_RPT_2G_ACTION_RPT_GL_PASSWORD,[crm_rpt_2G_action_rpt_GL].[payment_method] AS CRM_RPT_2G_ACTION_RPT_GL_PAYMENT_METHOD,[crm_rpt_2G_action_rpt_GL].[contract_id] AS CRM_RPT_2G_ACTION_RPT_GL_CONTRACT_ID,[crm_rpt_2G_action_rpt_GL].[customer_code] AS CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_CODE,[crm_rpt_2G_action_rpt_GL].[mobile_no] AS CRM_RPT_2G_ACTION_RPT_GL_MOBILE_NO,[crm_rpt_2G_action_rpt_GL].[als_flg] AS CRM_RPT_2G_ACTION_RPT_GL_ALS_FLG,[crm_rpt_2G_action_rpt_GL].[vas_desc] AS CRM_RPT_2G_ACTION_RPT_GL_VAS_DESC,[crm_rpt_2G_action_rpt_GL].[addr_3] AS CRM_RPT_2G_ACTION_RPT_GL_ADDR_3,[crm_rpt_2G_action_rpt_GL].[subscriber_tier] AS CRM_RPT_2G_ACTION_RPT_GL_SUBSCRIBER_TIER,[crm_rpt_2G_action_rpt_GL].[customer_id] AS CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_ID,[crm_rpt_2G_action_rpt_GL].[handset_rebate_end_date] AS CRM_RPT_2G_ACTION_RPT_GL_HANDSET_REBATE_END_DATE,[crm_rpt_2G_action_rpt_GL].[plan_free_inter_min] AS CRM_RPT_2G_ACTION_RPT_GL_PLAN_FREE_INTER_MIN,[crm_rpt_2G_action_rpt_GL].[cid] AS CRM_RPT_2G_ACTION_RPT_GL_CID,[crm_rpt_2G_action_rpt_GL].[did] AS CRM_RPT_2G_ACTION_RPT_GL_DID,[crm_rpt_2G_action_rpt_GL].[id] AS CRM_RPT_2G_ACTION_RPT_GL_ID,[crm_rpt_2G_action_rpt_GL].[plan_free_intra_min] AS CRM_RPT_2G_ACTION_RPT_GL_PLAN_FREE_INTRA_MIN,[crm_rpt_2G_action_rpt_GL].[original_telemarketing_suppress_flag] AS CRM_RPT_2G_ACTION_RPT_GL_ORIGINAL_TELEMARKETING_SUPPRESS_FLAG,[crm_rpt_2G_action_rpt_GL].[contact_number] AS CRM_RPT_2G_ACTION_RPT_GL_CONTACT_NUMBER,[crm_rpt_2G_action_rpt_GL].[addr_1] AS CRM_RPT_2G_ACTION_RPT_GL_ADDR_1,[crm_rpt_2G_action_rpt_GL].[max_contract_end_date] AS CRM_RPT_2G_ACTION_RPT_GL_MAX_CONTRACT_END_DATE,[crm_rpt_2G_action_rpt_GL].[id1] AS CRM_RPT_2G_ACTION_RPT_GL_ID1,[crm_rpt_2G_action_rpt_GL].[autopay] AS CRM_RPT_2G_ACTION_RPT_GL_AUTOPAY  FROM  [crm_rpt_2G_action_rpt_GL]  WHERE  [crm_rpt_2G_action_rpt_GL].[id] = \'"+x_iId.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[crm_rpt_2G_action_rpt_GL]","["+ Configurator.MSSQLTablePrefix + "crm_rpt_2G_action_rpt_GL]"); }
            using(SqlConnection _oConn = n_oDB.GetConnection()){
                SqlCommand _oCmd = new SqlCommand(_sQuery, _oConn);
                SqlDataReader _oData;
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read())
                    {
                        n_bFound = true;
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_TELEMARKETING_SUPPRESS_FLAG"])) {n_bTelemarketing_suppress_flag = (System.Nullable<bool>)_oData["CRM_RPT_2G_ACTION_RPT_GL_TELEMARKETING_SUPPRESS_FLAG"];}else{n_bTelemarketing_suppress_flag=null;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_END_DATE"])) {n_dEnd_date = (System.Nullable<DateTime>)_oData["CRM_RPT_2G_ACTION_RPT_GL_END_DATE"];}else{n_dEnd_date=null;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_DDATE"])) {n_dDdate = (System.Nullable<DateTime>)_oData["CRM_RPT_2G_ACTION_RPT_GL_DDATE"];}else{n_dDdate=null;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_AIRTIME_HS_MODEL"])) {n_sAirtime_hs_model = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_AIRTIME_HS_MODEL"];}else{n_sAirtime_hs_model=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_TRADEFIELD"])) {n_sTradefield = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_TRADEFIELD"];}else{n_sTradefield=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CALLLIST_NAME"])) {n_sCalllist_name = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_CALLLIST_NAME"];}else{n_sCalllist_name=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_FIELD1"])) {n_sField1 = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_FIELD1"];}else{n_sField1=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_REMARKS"])) {n_sRemarks = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_REMARKS"];}else{n_sRemarks=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_BILL_CYCLE"])) {n_iBill_cycle = (System.Nullable<int>)_oData["CRM_RPT_2G_ACTION_RPT_GL_BILL_CYCLE"];}else{n_iBill_cycle=null;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ADDR_2"])) {n_sAddr_2 = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_ADDR_2"];}else{n_sAddr_2=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ID_NUMBER"])) {n_sId_number = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_ID_NUMBER"];}else{n_sId_number=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ATTENTION_NAME_FORMARTTED"])) {n_sAttention_name_formartted = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_ATTENTION_NAME_FORMARTTED"];}else{n_sAttention_name_formartted=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_NAME_FORMARTTED"])) {n_sCustomer_name_formartted = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_NAME_FORMARTTED"];}else{n_sCustomer_name_formartted=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_MNP_REBATE_END_DATE"])) {n_dMnp_rebate_end_date = (System.Nullable<DateTime>)_oData["CRM_RPT_2G_ACTION_RPT_GL_MNP_REBATE_END_DATE"];}else{n_dMnp_rebate_end_date=null;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_FIELD3"])) {n_sField3 = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_FIELD3"];}else{n_sField3=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ADDR_4"])) {n_sAddr_4 = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_ADDR_4"];}else{n_sAddr_4=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PROGRAM"])) {n_sProgram = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_PROGRAM"];}else{n_sProgram=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PROP_PLAN"])) {n_sProp_plan = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_PROP_PLAN"];}else{n_sProp_plan=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_EXPIRED_MONTH"])) {n_sExpired_month = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_EXPIRED_MONTH"];}else{n_sExpired_month=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_GROUP"])) {n_sCustomer_group = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_GROUP"];}else{n_sCustomer_group=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_JOIN_DATE"])) {n_dJoin_date = (System.Nullable<DateTime>)_oData["CRM_RPT_2G_ACTION_RPT_GL_JOIN_DATE"];}else{n_dJoin_date=null;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_IDD_FLG"])) {n_bIdd_flg = (System.Nullable<bool>)_oData["CRM_RPT_2G_ACTION_RPT_GL_IDD_FLG"];}else{n_bIdd_flg=null;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ACTIVE"])) {n_bActive = (System.Nullable<bool>)_oData["CRM_RPT_2G_ACTION_RPT_GL_ACTIVE"];}else{n_bActive=null;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PERIOD"])) {n_sPeriod = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_PERIOD"];}else{n_sPeriod=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_FIELD2"])) {n_sField2 = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_FIELD2"];}else{n_sField2=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_START_DATE"])) {n_dStart_date = (System.Nullable<DateTime>)_oData["CRM_RPT_2G_ACTION_RPT_GL_START_DATE"];}else{n_dStart_date=null;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PLAN_FEE"])) {n_sPlan_fee = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_PLAN_FEE"];}else{n_sPlan_fee=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_RATE_PLAN"])) {n_sRate_plan = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_RATE_PLAN"];}else{n_sRate_plan=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_SEGMENT"])) {n_sSegment = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_SEGMENT"];}else{n_sSegment=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CDATE"])) {n_dCdate = (System.Nullable<DateTime>)_oData["CRM_RPT_2G_ACTION_RPT_GL_CDATE"];}else{n_dCdate=null;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PROGRAM_ID"])) {n_sProgram_id = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_PROGRAM_ID"];}else{n_sProgram_id=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PASSWORD"])) {n_sPassword = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_PASSWORD"];}else{n_sPassword=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PAYMENT_METHOD"])) {n_sPayment_method = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_PAYMENT_METHOD"];}else{n_sPayment_method=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CONTRACT_ID"])) {n_sContract_id = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_CONTRACT_ID"];}else{n_sContract_id=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_CODE"])) {n_sCustomer_code = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_CODE"];}else{n_sCustomer_code=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_MOBILE_NO"])) {n_sMobile_no = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_MOBILE_NO"];}else{n_sMobile_no=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ALS_FLG"])) {n_sAls_flg = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_ALS_FLG"];}else{n_sAls_flg=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_VAS_DESC"])) {n_sVas_desc = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_VAS_DESC"];}else{n_sVas_desc=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ADDR_3"])) {n_sAddr_3 = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_ADDR_3"];}else{n_sAddr_3=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_SUBSCRIBER_TIER"])) {n_sSubscriber_tier = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_SUBSCRIBER_TIER"];}else{n_sSubscriber_tier=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_ID"])) {n_sCustomer_id = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_ID"];}else{n_sCustomer_id=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_HANDSET_REBATE_END_DATE"])) {n_dHandset_rebate_end_date = (System.Nullable<DateTime>)_oData["CRM_RPT_2G_ACTION_RPT_GL_HANDSET_REBATE_END_DATE"];}else{n_dHandset_rebate_end_date=null;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PLAN_FREE_INTER_MIN"])) {n_iPlan_free_inter_min = (System.Nullable<int>)_oData["CRM_RPT_2G_ACTION_RPT_GL_PLAN_FREE_INTER_MIN"];}else{n_iPlan_free_inter_min=null;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CID"])) {n_sCid = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_CID"];}else{n_sCid=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_DID"])) {n_sDid = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_DID"];}else{n_sDid=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ID"])) {n_iId = (System.Nullable<int>)_oData["CRM_RPT_2G_ACTION_RPT_GL_ID"];}else{n_iId=null;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PLAN_FREE_INTRA_MIN"])) {n_iPlan_free_intra_min = (System.Nullable<int>)_oData["CRM_RPT_2G_ACTION_RPT_GL_PLAN_FREE_INTRA_MIN"];}else{n_iPlan_free_intra_min=null;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ORIGINAL_TELEMARKETING_SUPPRESS_FLAG"])) {n_bOriginal_telemarketing_suppress_flag = (System.Nullable<bool>)_oData["CRM_RPT_2G_ACTION_RPT_GL_ORIGINAL_TELEMARKETING_SUPPRESS_FLAG"];}else{n_bOriginal_telemarketing_suppress_flag=null;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CONTACT_NUMBER"])) {n_sContact_number = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_CONTACT_NUMBER"];}else{n_sContact_number=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ADDR_1"])) {n_sAddr_1 = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_ADDR_1"];}else{n_sAddr_1=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_MAX_CONTRACT_END_DATE"])) {n_dMax_contract_end_date = (System.Nullable<DateTime>)_oData["CRM_RPT_2G_ACTION_RPT_GL_MAX_CONTRACT_END_DATE"];}else{n_dMax_contract_end_date=null;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ID1"])) {n_sId1 = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_ID1"];}else{n_sId1=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_AUTOPAY"])) {n_sAutopay = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_AUTOPAY"];}else{n_sAutopay=string.Empty;}
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
            if (n_bTelemarketing_suppress_flag==null && !(n_oTableSet.Fields(Para.telemarketing_suppress_flag).IsNullable)) return false;
            if (n_dEnd_date==null && !(n_oTableSet.Fields(Para.end_date).IsNullable)) return false;
            if (n_dDdate==null && !(n_oTableSet.Fields(Para.ddate).IsNullable)) return false;
            if (n_sAirtime_hs_model==null && !(n_oTableSet.Fields(Para.airtime_hs_model).IsNullable)) return false;
            if (n_sTradefield==null && !(n_oTableSet.Fields(Para.tradefield).IsNullable)) return false;
            if (n_sCalllist_name==null && !(n_oTableSet.Fields(Para.calllist_name).IsNullable)) return false;
            if (n_sField1==null && !(n_oTableSet.Fields(Para.field1).IsNullable)) return false;
            if (n_sRemarks==null && !(n_oTableSet.Fields(Para.remarks).IsNullable)) return false;
            if (n_iBill_cycle==null && !(n_oTableSet.Fields(Para.bill_cycle).IsNullable)) return false;
            if (n_sAddr_2==null && !(n_oTableSet.Fields(Para.addr_2).IsNullable)) return false;
            if (n_sId_number==null && !(n_oTableSet.Fields(Para.id_number).IsNullable)) return false;
            if (n_sAttention_name_formartted==null && !(n_oTableSet.Fields(Para.attention_name_formartted).IsNullable)) return false;
            if (n_sCustomer_name_formartted==null && !(n_oTableSet.Fields(Para.customer_name_formartted).IsNullable)) return false;
            if (n_dMnp_rebate_end_date==null && !(n_oTableSet.Fields(Para.mnp_rebate_end_date).IsNullable)) return false;
            if (n_sField3==null && !(n_oTableSet.Fields(Para.field3).IsNullable)) return false;
            if (n_sAddr_4==null && !(n_oTableSet.Fields(Para.addr_4).IsNullable)) return false;
            if (n_sProgram==null && !(n_oTableSet.Fields(Para.program).IsNullable)) return false;
            if (n_sProp_plan==null && !(n_oTableSet.Fields(Para.prop_plan).IsNullable)) return false;
            if (n_sExpired_month==null && !(n_oTableSet.Fields(Para.expired_month).IsNullable)) return false;
            if (n_sCustomer_group==null && !(n_oTableSet.Fields(Para.customer_group).IsNullable)) return false;
            if (n_dJoin_date==null && !(n_oTableSet.Fields(Para.join_date).IsNullable)) return false;
            if (n_bIdd_flg==null && !(n_oTableSet.Fields(Para.idd_flg).IsNullable)) return false;
            if (n_bActive==null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_sPeriod==null && !(n_oTableSet.Fields(Para.period).IsNullable)) return false;
            if (n_sField2==null && !(n_oTableSet.Fields(Para.field2).IsNullable)) return false;
            if (n_dStart_date==null && !(n_oTableSet.Fields(Para.start_date).IsNullable)) return false;
            if (n_sPlan_fee==null && !(n_oTableSet.Fields(Para.plan_fee).IsNullable)) return false;
            if (n_sRate_plan==null && !(n_oTableSet.Fields(Para.rate_plan).IsNullable)) return false;
            if (n_sSegment==null && !(n_oTableSet.Fields(Para.segment).IsNullable)) return false;
            if (n_dCdate==null && !(n_oTableSet.Fields(Para.cdate).IsNullable)) return false;
            if (n_sProgram_id==null && !(n_oTableSet.Fields(Para.program_id).IsNullable)) return false;
            if (n_sPassword==null && !(n_oTableSet.Fields(Para.password).IsNullable)) return false;
            if (n_sPayment_method==null && !(n_oTableSet.Fields(Para.payment_method).IsNullable)) return false;
            if (n_sContract_id==null && !(n_oTableSet.Fields(Para.contract_id).IsNullable)) return false;
            if (n_sCustomer_code==null && !(n_oTableSet.Fields(Para.customer_code).IsNullable)) return false;
            if (n_sMobile_no==null && !(n_oTableSet.Fields(Para.mobile_no).IsNullable)) return false;
            if (n_sAls_flg==null && !(n_oTableSet.Fields(Para.als_flg).IsNullable)) return false;
            if (n_sVas_desc==null && !(n_oTableSet.Fields(Para.vas_desc).IsNullable)) return false;
            if (n_sAddr_3==null && !(n_oTableSet.Fields(Para.addr_3).IsNullable)) return false;
            if (n_sSubscriber_tier==null && !(n_oTableSet.Fields(Para.subscriber_tier).IsNullable)) return false;
            if (n_sCustomer_id==null && !(n_oTableSet.Fields(Para.customer_id).IsNullable)) return false;
            if (n_dHandset_rebate_end_date==null && !(n_oTableSet.Fields(Para.handset_rebate_end_date).IsNullable)) return false;
            if (n_iPlan_free_inter_min==null && !(n_oTableSet.Fields(Para.plan_free_inter_min).IsNullable)) return false;
            if (n_sCid==null && !(n_oTableSet.Fields(Para.cid).IsNullable)) return false;
            if (n_sDid==null && !(n_oTableSet.Fields(Para.did).IsNullable)) return false;
            if(!x_bInsert){
                if (n_iId==null && !(n_oTableSet.Fields(Para.id).IsNullable)) return false;
            }
            if (n_iPlan_free_intra_min==null && !(n_oTableSet.Fields(Para.plan_free_intra_min).IsNullable)) return false;
            if (n_bOriginal_telemarketing_suppress_flag==null && !(n_oTableSet.Fields(Para.original_telemarketing_suppress_flag).IsNullable)) return false;
            if (n_sContact_number==null && !(n_oTableSet.Fields(Para.contact_number).IsNullable)) return false;
            if (n_sAddr_1==null && !(n_oTableSet.Fields(Para.addr_1).IsNullable)) return false;
            if (n_dMax_contract_end_date==null && !(n_oTableSet.Fields(Para.max_contract_end_date).IsNullable)) return false;
            if (n_sId1==null && !(n_oTableSet.Fields(Para.id1).IsNullable)) return false;
            if (n_sAutopay==null && !(n_oTableSet.Fields(Para.autopay).IsNullable)) return false;
            return true;
        }
        #endregion
        
        #region Get & Set
        
        /// <summary>
        /// Summary description for Get & Set this all class parameters
        /// </summary>
        
        
        public object GetRepositoryObject(object x_oObj)
        {
            if (x_oObj is Crm_rpt_2G_action_rpt_GL) return Crm_rpt_2G_action_rpt_GLRepository.Instance();
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
        public Crm_rpt_2G_action_rpt_GLInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(Crm_rpt_2G_action_rpt_GLInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public string GetAls_flg(){return this.als_flg;}
        public System.Nullable<DateTime> GetEnd_date(){return this.end_date;}
        public string GetRemarks(){return this.remarks;}
        public string GetAirtime_hs_model(){return this.airtime_hs_model;}
        public System.Nullable<DateTime> GetStart_date(){return this.start_date;}
        public string GetCalllist_name(){return this.calllist_name;}
        public System.Nullable<DateTime> GetJoin_date(){return this.join_date;}
        public string GetField1(){return this.field1;}
        public System.Nullable<int> GetBill_cycle(){return this.bill_cycle;}
        public string GetAddr_3(){return this.addr_3;}
        public string GetAddr_2(){return this.addr_2;}
        public string GetId_number(){return this.id_number;}
        public string GetAttention_name_formartted(){return this.attention_name_formartted;}
        public string GetCustomer_name_formartted(){return this.customer_name_formartted;}
        public string GetAutopay(){return this.autopay;}
        public string GetField3(){return this.field3;}
        public string GetAddr_4(){return this.addr_4;}
        public string GetProgram(){return this.program;}
        public string GetProp_plan(){return this.prop_plan;}
        public string GetCustomer_group(){return this.customer_group;}
        public string GetCustomer_code(){return this.customer_code;}
        public System.Nullable<bool> GetTelemarketing_suppress_flag(){return this.telemarketing_suppress_flag;}
        public System.Nullable<bool> GetIdd_flg(){return this.idd_flg;}
        public System.Nullable<bool> GetActive(){return this.active;}
        public System.Nullable<DateTime> GetDdate(){return this.ddate;}
        public System.Nullable<int> GetId(){return this.id;}
        public string GetPlan_fee(){return this.plan_fee;}
        public string GetRate_plan(){return this.rate_plan;}
        public string GetSegment(){return this.segment;}
        public string GetId1(){return this.id1;}
        public string GetPassword(){return this.password;}
        public string GetPayment_method(){return this.payment_method;}
        public string GetContract_id(){return this.contract_id;}
        public string GetField2(){return this.field2;}
        public string GetMobile_no(){return this.mobile_no;}
        public string GetPeriod(){return this.period;}
        public string GetVas_desc(){return this.vas_desc;}
        public System.Nullable<DateTime> GetCdate(){return this.cdate;}
        public string GetSubscriber_tier(){return this.subscriber_tier;}
        public string GetCustomer_id(){return this.customer_id;}
        public System.Nullable<DateTime> GetHandset_rebate_end_date(){return this.handset_rebate_end_date;}
        public System.Nullable<int> GetPlan_free_inter_min(){return this.plan_free_inter_min;}
        public string GetCid(){return this.cid;}
        public string GetDid(){return this.did;}
        public string GetExpired_month(){return this.expired_month;}
        public System.Nullable<int> GetPlan_free_intra_min(){return this.plan_free_intra_min;}
        public System.Nullable<bool> GetOriginal_telemarketing_suppress_flag(){return this.original_telemarketing_suppress_flag;}
        public string GetContact_number(){return this.contact_number;}
        public string GetTradefield(){return this.tradefield;}
        public string GetAddr_1(){return this.addr_1;}
        public System.Nullable<DateTime> GetMax_contract_end_date(){return this.max_contract_end_date;}
        public System.Nullable<DateTime> GetMnp_rebate_end_date(){return this.mnp_rebate_end_date;}
        public string GetProgram_id(){return this.program_id;}
        
        public bool SetAls_flg(string value){
            this.als_flg=value;
            return true;
        }
        public bool SetEnd_date(System.Nullable<DateTime> value){
            this.end_date=value;
            return true;
        }
        public bool SetRemarks(string value){
            this.remarks=value;
            return true;
        }
        public bool SetAirtime_hs_model(string value){
            this.airtime_hs_model=value;
            return true;
        }
        public bool SetStart_date(System.Nullable<DateTime> value){
            this.start_date=value;
            return true;
        }
        public bool SetCalllist_name(string value){
            this.calllist_name=value;
            return true;
        }
        public bool SetJoin_date(System.Nullable<DateTime> value){
            this.join_date=value;
            return true;
        }
        public bool SetField1(string value){
            this.field1=value;
            return true;
        }
        public bool SetBill_cycle(System.Nullable<int> value){
            this.bill_cycle=value;
            return true;
        }
        public bool SetAddr_3(string value){
            this.addr_3=value;
            return true;
        }
        public bool SetAddr_2(string value){
            this.addr_2=value;
            return true;
        }
        public bool SetId_number(string value){
            this.id_number=value;
            return true;
        }
        public bool SetAttention_name_formartted(string value){
            this.attention_name_formartted=value;
            return true;
        }
        public bool SetCustomer_name_formartted(string value){
            this.customer_name_formartted=value;
            return true;
        }
        public bool SetAutopay(string value){
            this.autopay=value;
            return true;
        }
        public bool SetField3(string value){
            this.field3=value;
            return true;
        }
        public bool SetAddr_4(string value){
            this.addr_4=value;
            return true;
        }
        public bool SetProgram(string value){
            this.program=value;
            return true;
        }
        public bool SetProp_plan(string value){
            this.prop_plan=value;
            return true;
        }
        public bool SetCustomer_group(string value){
            this.customer_group=value;
            return true;
        }
        public bool SetCustomer_code(string value){
            this.customer_code=value;
            return true;
        }
        public bool SetTelemarketing_suppress_flag(System.Nullable<bool> value){
            this.telemarketing_suppress_flag=value;
            return true;
        }
        public bool SetIdd_flg(System.Nullable<bool> value){
            this.idd_flg=value;
            return true;
        }
        public bool SetActive(System.Nullable<bool> value){
            this.active=value;
            return true;
        }
        public bool SetDdate(System.Nullable<DateTime> value){
            this.ddate=value;
            return true;
        }
        public bool SetId(System.Nullable<int> value){
            this.id=value;
            return true;
        }
        public bool SetPlan_fee(string value){
            this.plan_fee=value;
            return true;
        }
        public bool SetRate_plan(string value){
            this.rate_plan=value;
            return true;
        }
        public bool SetSegment(string value){
            this.segment=value;
            return true;
        }
        public bool SetId1(string value){
            this.id1=value;
            return true;
        }
        public bool SetPassword(string value){
            this.password=value;
            return true;
        }
        public bool SetPayment_method(string value){
            this.payment_method=value;
            return true;
        }
        public bool SetContract_id(string value){
            this.contract_id=value;
            return true;
        }
        public bool SetField2(string value){
            this.field2=value;
            return true;
        }
        public bool SetMobile_no(string value){
            this.mobile_no=value;
            return true;
        }
        public bool SetPeriod(string value){
            this.period=value;
            return true;
        }
        public bool SetVas_desc(string value){
            this.vas_desc=value;
            return true;
        }
        public bool SetCdate(System.Nullable<DateTime> value){
            this.cdate=value;
            return true;
        }
        public bool SetSubscriber_tier(string value){
            this.subscriber_tier=value;
            return true;
        }
        public bool SetCustomer_id(string value){
            this.customer_id=value;
            return true;
        }
        public bool SetHandset_rebate_end_date(System.Nullable<DateTime> value){
            this.handset_rebate_end_date=value;
            return true;
        }
        public bool SetPlan_free_inter_min(System.Nullable<int> value){
            this.plan_free_inter_min=value;
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
        public bool SetExpired_month(string value){
            this.expired_month=value;
            return true;
        }
        public bool SetPlan_free_intra_min(System.Nullable<int> value){
            this.plan_free_intra_min=value;
            return true;
        }
        public bool SetOriginal_telemarketing_suppress_flag(System.Nullable<bool> value){
            this.original_telemarketing_suppress_flag=value;
            return true;
        }
        public bool SetContact_number(string value){
            this.contact_number=value;
            return true;
        }
        public bool SetTradefield(string value){
            this.tradefield=value;
            return true;
        }
        public bool SetAddr_1(string value){
            this.addr_1=value;
            return true;
        }
        public bool SetMax_contract_end_date(System.Nullable<DateTime> value){
            this.max_contract_end_date=value;
            return true;
        }
        public bool SetMnp_rebate_end_date(System.Nullable<DateTime> value){
            this.mnp_rebate_end_date=value;
            return true;
        }
        public bool SetProgram_id(string value){
            this.program_id=value;
            return true;
        }
        
        public Field GetAls_flgTable(){
            return n_oTableSet.Fields(Para.als_flg);
        }
        public Field GetEnd_dateTable(){
            return n_oTableSet.Fields(Para.end_date);
        }
        public Field GetRemarksTable(){
            return n_oTableSet.Fields(Para.remarks);
        }
        public Field GetAirtime_hs_modelTable(){
            return n_oTableSet.Fields(Para.airtime_hs_model);
        }
        public Field GetStart_dateTable(){
            return n_oTableSet.Fields(Para.start_date);
        }
        public Field GetCalllist_nameTable(){
            return n_oTableSet.Fields(Para.calllist_name);
        }
        public Field GetJoin_dateTable(){
            return n_oTableSet.Fields(Para.join_date);
        }
        public Field GetField1Table(){
            return n_oTableSet.Fields(Para.field1);
        }
        public Field GetBill_cycleTable(){
            return n_oTableSet.Fields(Para.bill_cycle);
        }
        public Field GetAddr_3Table(){
            return n_oTableSet.Fields(Para.addr_3);
        }
        public Field GetAddr_2Table(){
            return n_oTableSet.Fields(Para.addr_2);
        }
        public Field GetId_numberTable(){
            return n_oTableSet.Fields(Para.id_number);
        }
        public Field GetAttention_name_formarttedTable(){
            return n_oTableSet.Fields(Para.attention_name_formartted);
        }
        public Field GetCustomer_name_formarttedTable(){
            return n_oTableSet.Fields(Para.customer_name_formartted);
        }
        public Field GetAutopayTable(){
            return n_oTableSet.Fields(Para.autopay);
        }
        public Field GetField3Table(){
            return n_oTableSet.Fields(Para.field3);
        }
        public Field GetAddr_4Table(){
            return n_oTableSet.Fields(Para.addr_4);
        }
        public Field GetProgramTable(){
            return n_oTableSet.Fields(Para.program);
        }
        public Field GetProp_planTable(){
            return n_oTableSet.Fields(Para.prop_plan);
        }
        public Field GetCustomer_groupTable(){
            return n_oTableSet.Fields(Para.customer_group);
        }
        public Field GetCustomer_codeTable(){
            return n_oTableSet.Fields(Para.customer_code);
        }
        public Field GetTelemarketing_suppress_flagTable(){
            return n_oTableSet.Fields(Para.telemarketing_suppress_flag);
        }
        public Field GetIdd_flgTable(){
            return n_oTableSet.Fields(Para.idd_flg);
        }
        public Field GetActiveTable(){
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetDdateTable(){
            return n_oTableSet.Fields(Para.ddate);
        }
        public Field GetIdTable(){
            return n_oTableSet.Fields(Para.id);
        }
        public Field GetPlan_feeTable(){
            return n_oTableSet.Fields(Para.plan_fee);
        }
        public Field GetRate_planTable(){
            return n_oTableSet.Fields(Para.rate_plan);
        }
        public Field GetSegmentTable(){
            return n_oTableSet.Fields(Para.segment);
        }
        public Field GetId1Table(){
            return n_oTableSet.Fields(Para.id1);
        }
        public Field GetPasswordTable(){
            return n_oTableSet.Fields(Para.password);
        }
        public Field GetPayment_methodTable(){
            return n_oTableSet.Fields(Para.payment_method);
        }
        public Field GetContract_idTable(){
            return n_oTableSet.Fields(Para.contract_id);
        }
        public Field GetField2Table(){
            return n_oTableSet.Fields(Para.field2);
        }
        public Field GetMobile_noTable(){
            return n_oTableSet.Fields(Para.mobile_no);
        }
        public Field GetPeriodTable(){
            return n_oTableSet.Fields(Para.period);
        }
        public Field GetVas_descTable(){
            return n_oTableSet.Fields(Para.vas_desc);
        }
        public Field GetCdateTable(){
            return n_oTableSet.Fields(Para.cdate);
        }
        public Field GetSubscriber_tierTable(){
            return n_oTableSet.Fields(Para.subscriber_tier);
        }
        public Field GetCustomer_idTable(){
            return n_oTableSet.Fields(Para.customer_id);
        }
        public Field GetHandset_rebate_end_dateTable(){
            return n_oTableSet.Fields(Para.handset_rebate_end_date);
        }
        public Field GetPlan_free_inter_minTable(){
            return n_oTableSet.Fields(Para.plan_free_inter_min);
        }
        public Field GetCidTable(){
            return n_oTableSet.Fields(Para.cid);
        }
        public Field GetDidTable(){
            return n_oTableSet.Fields(Para.did);
        }
        public Field GetExpired_monthTable(){
            return n_oTableSet.Fields(Para.expired_month);
        }
        public Field GetPlan_free_intra_minTable(){
            return n_oTableSet.Fields(Para.plan_free_intra_min);
        }
        public Field GetOriginal_telemarketing_suppress_flagTable(){
            return n_oTableSet.Fields(Para.original_telemarketing_suppress_flag);
        }
        public Field GetContact_numberTable(){
            return n_oTableSet.Fields(Para.contact_number);
        }
        public Field GetTradefieldTable(){
            return n_oTableSet.Fields(Para.tradefield);
        }
        public Field GetAddr_1Table(){
            return n_oTableSet.Fields(Para.addr_1);
        }
        public Field GetMax_contract_end_dateTable(){
            return n_oTableSet.Fields(Para.max_contract_end_date);
        }
        public Field GetMnp_rebate_end_dateTable(){
            return n_oTableSet.Fields(Para.mnp_rebate_end_date);
        }
        public Field GetProgram_idTable(){
            return n_oTableSet.Fields(Para.program_id);
        }
        #endregion
        
        #region Addtional Get & Set
        #endregion
        
        #region Add & Del
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
        
        public bool EqualID(Crm_rpt_2G_action_rpt_GL x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(Crm_rpt_2G_action_rpt_GL x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_bTelemarketing_suppress_flag.Equals(x_oObj.telemarketing_suppress_flag)){ return false; }
            if(!this.n_dEnd_date.Equals(x_oObj.end_date)){ return false; }
            if(!this.n_dDdate.Equals(x_oObj.ddate)){ return false; }
            if(!this.n_sAirtime_hs_model.Equals(x_oObj.airtime_hs_model)){ return false; }
            if(!this.n_sTradefield.Equals(x_oObj.tradefield)){ return false; }
            if(!this.n_sCalllist_name.Equals(x_oObj.calllist_name)){ return false; }
            if(!this.n_sField1.Equals(x_oObj.field1)){ return false; }
            if(!this.n_sRemarks.Equals(x_oObj.remarks)){ return false; }
            if(!this.n_iBill_cycle.Equals(x_oObj.bill_cycle)){ return false; }
            if(!this.n_sAddr_2.Equals(x_oObj.addr_2)){ return false; }
            if(!this.n_sId_number.Equals(x_oObj.id_number)){ return false; }
            if(!this.n_sAttention_name_formartted.Equals(x_oObj.attention_name_formartted)){ return false; }
            if(!this.n_sCustomer_name_formartted.Equals(x_oObj.customer_name_formartted)){ return false; }
            if(!this.n_dMnp_rebate_end_date.Equals(x_oObj.mnp_rebate_end_date)){ return false; }
            if(!this.n_sField3.Equals(x_oObj.field3)){ return false; }
            if(!this.n_sAddr_4.Equals(x_oObj.addr_4)){ return false; }
            if(!this.n_sProgram.Equals(x_oObj.program)){ return false; }
            if(!this.n_sProp_plan.Equals(x_oObj.prop_plan)){ return false; }
            if(!this.n_sExpired_month.Equals(x_oObj.expired_month)){ return false; }
            if(!this.n_sCustomer_group.Equals(x_oObj.customer_group)){ return false; }
            if(!this.n_dJoin_date.Equals(x_oObj.join_date)){ return false; }
            if(!this.n_bIdd_flg.Equals(x_oObj.idd_flg)){ return false; }
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_sPeriod.Equals(x_oObj.period)){ return false; }
            if(!this.n_sField2.Equals(x_oObj.field2)){ return false; }
            if(!this.n_dStart_date.Equals(x_oObj.start_date)){ return false; }
            if(!this.n_sPlan_fee.Equals(x_oObj.plan_fee)){ return false; }
            if(!this.n_sRate_plan.Equals(x_oObj.rate_plan)){ return false; }
            if(!this.n_sSegment.Equals(x_oObj.segment)){ return false; }
            if(!this.n_dCdate.Equals(x_oObj.cdate)){ return false; }
            if(!this.n_sProgram_id.Equals(x_oObj.program_id)){ return false; }
            if(!this.n_sPassword.Equals(x_oObj.password)){ return false; }
            if(!this.n_sPayment_method.Equals(x_oObj.payment_method)){ return false; }
            if(!this.n_sContract_id.Equals(x_oObj.contract_id)){ return false; }
            if(!this.n_sCustomer_code.Equals(x_oObj.customer_code)){ return false; }
            if(!this.n_sMobile_no.Equals(x_oObj.mobile_no)){ return false; }
            if(!this.n_sAls_flg.Equals(x_oObj.als_flg)){ return false; }
            if(!this.n_sVas_desc.Equals(x_oObj.vas_desc)){ return false; }
            if(!this.n_sAddr_3.Equals(x_oObj.addr_3)){ return false; }
            if(!this.n_sSubscriber_tier.Equals(x_oObj.subscriber_tier)){ return false; }
            if(!this.n_sCustomer_id.Equals(x_oObj.customer_id)){ return false; }
            if(!this.n_dHandset_rebate_end_date.Equals(x_oObj.handset_rebate_end_date)){ return false; }
            if(!this.n_iPlan_free_inter_min.Equals(x_oObj.plan_free_inter_min)){ return false; }
            if(!this.n_sCid.Equals(x_oObj.cid)){ return false; }
            if(!this.n_sDid.Equals(x_oObj.did)){ return false; }
            if(!this.n_iId.Equals(x_oObj.id)){ return false; }
            if(!this.n_iPlan_free_intra_min.Equals(x_oObj.plan_free_intra_min)){ return false; }
            if(!this.n_bOriginal_telemarketing_suppress_flag.Equals(x_oObj.original_telemarketing_suppress_flag)){ return false; }
            if(!this.n_sContact_number.Equals(x_oObj.contact_number)){ return false; }
            if(!this.n_sAddr_1.Equals(x_oObj.addr_1)){ return false; }
            if(!this.n_dMax_contract_end_date.Equals(x_oObj.max_contract_end_date)){ return false; }
            if(!this.n_sId1.Equals(x_oObj.id1)){ return false; }
            if(!this.n_sAutopay.Equals(x_oObj.autopay)){ return false; }
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
            if(!n_iId.Equals(null)){
                _bResult=this.Load(n_iId);
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
            if (n_iId==null) { return false; }
            if(!Vaild(false)){ return false; }
            string _sQuery = "UPDATE  [crm_rpt_2G_action_rpt_GL]  SET  [telemarketing_suppress_flag]=@telemarketing_suppress_flag,[end_date]=@end_date,[ddate]=@ddate,[airtime_hs_model]=@airtime_hs_model,[tradefield]=@tradefield,[calllist_name]=@calllist_name,[field1]=@field1,[remarks]=@remarks,[bill_cycle]=@bill_cycle,[addr_2]=@addr_2,[id_number]=@id_number,[attention_name_formartted]=@attention_name_formartted,[customer_name_formartted]=@customer_name_formartted,[mnp_rebate_end_date]=@mnp_rebate_end_date,[field3]=@field3,[addr_4]=@addr_4,[program]=@program,[prop_plan]=@prop_plan,[expired_month]=@expired_month,[customer_group]=@customer_group,[join_date]=@join_date,[idd_flg]=@idd_flg,[active]=@active,[period]=@period,[field2]=@field2,[start_date]=@start_date,[plan_fee]=@plan_fee,[rate_plan]=@rate_plan,[segment]=@segment,[cdate]=@cdate,[program_id]=@program_id,[password]=@password,[payment_method]=@payment_method,[contract_id]=@contract_id,[customer_code]=@customer_code,[mobile_no]=@mobile_no,[als_flg]=@als_flg,[vas_desc]=@vas_desc,[addr_3]=@addr_3,[subscriber_tier]=@subscriber_tier,[customer_id]=@customer_id,[handset_rebate_end_date]=@handset_rebate_end_date,[plan_free_inter_min]=@plan_free_inter_min,[cid]=@cid,[did]=@did,[plan_free_intra_min]=@plan_free_intra_min,[original_telemarketing_suppress_flag]=@original_telemarketing_suppress_flag,[contact_number]=@contact_number,[addr_1]=@addr_1,[max_contract_end_date]=@max_contract_end_date,[id1]=@id1,[autopay]=@autopay  WHERE [crm_rpt_2G_action_rpt_GL].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[crm_rpt_2G_action_rpt_GL]","["+ Configurator.MSSQLTablePrefix + "crm_rpt_2G_action_rpt_GL]"); }
            SqlConnection _oConn = null;
            SqlCommand _oCmd = null;
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
                _oCmd = new SqlCommand(_sQuery, _oConn);
            }
            bool _bResult=false;
            if(n_bTelemarketing_suppress_flag==null){  _oCmd.Parameters.Add("@telemarketing_suppress_flag", SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@telemarketing_suppress_flag", SqlDbType.Bit).Value=n_bTelemarketing_suppress_flag; }
            if(n_dEnd_date==null){  _oCmd.Parameters.Add("@end_date", SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@end_date", SqlDbType.DateTime).Value=n_dEnd_date; }
            if(n_dDdate==null){  _oCmd.Parameters.Add("@ddate", SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@ddate", SqlDbType.DateTime).Value=n_dDdate; }
            if(n_sAirtime_hs_model==null){  _oCmd.Parameters.Add("@airtime_hs_model", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@airtime_hs_model", SqlDbType.VarChar,50).Value=n_sAirtime_hs_model; }
            if(n_sTradefield==null){  _oCmd.Parameters.Add("@tradefield", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@tradefield", SqlDbType.VarChar,50).Value=n_sTradefield; }
            if(n_sCalllist_name==null){  _oCmd.Parameters.Add("@calllist_name", SqlDbType.VarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@calllist_name", SqlDbType.VarChar,250).Value=n_sCalllist_name; }
            if(n_sField1==null){  _oCmd.Parameters.Add("@field1", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@field1", SqlDbType.VarChar,50).Value=n_sField1; }
            if(n_sRemarks==null){  _oCmd.Parameters.Add("@remarks", SqlDbType.VarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@remarks", SqlDbType.VarChar,100).Value=n_sRemarks; }
            if(n_iBill_cycle==null){  _oCmd.Parameters.Add("@bill_cycle", SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@bill_cycle", SqlDbType.Int).Value=n_iBill_cycle; }
            if(n_sAddr_2==null){  _oCmd.Parameters.Add("@addr_2", SqlDbType.VarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@addr_2", SqlDbType.VarChar,100).Value=n_sAddr_2; }
            if(n_sId_number==null){  _oCmd.Parameters.Add("@id_number", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@id_number", SqlDbType.VarChar,50).Value=n_sId_number; }
            if(n_sAttention_name_formartted==null){  _oCmd.Parameters.Add("@attention_name_formartted", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@attention_name_formartted", SqlDbType.VarChar,50).Value=n_sAttention_name_formartted; }
            if(n_sCustomer_name_formartted==null){  _oCmd.Parameters.Add("@customer_name_formartted", SqlDbType.VarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@customer_name_formartted", SqlDbType.VarChar,100).Value=n_sCustomer_name_formartted; }
            if(n_dMnp_rebate_end_date==null){  _oCmd.Parameters.Add("@mnp_rebate_end_date", SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@mnp_rebate_end_date", SqlDbType.DateTime).Value=n_dMnp_rebate_end_date; }
            if(n_sField3==null){  _oCmd.Parameters.Add("@field3", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@field3", SqlDbType.VarChar,50).Value=n_sField3; }
            if(n_sAddr_4==null){  _oCmd.Parameters.Add("@addr_4", SqlDbType.VarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@addr_4", SqlDbType.VarChar,100).Value=n_sAddr_4; }
            if(n_sProgram==null){  _oCmd.Parameters.Add("@program", SqlDbType.VarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@program", SqlDbType.VarChar,250).Value=n_sProgram; }
            if(n_sProp_plan==null){  _oCmd.Parameters.Add("@prop_plan", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@prop_plan", SqlDbType.VarChar,50).Value=n_sProp_plan; }
            if(n_sExpired_month==null){  _oCmd.Parameters.Add("@expired_month", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@expired_month", SqlDbType.VarChar,50).Value=n_sExpired_month; }
            if(n_sCustomer_group==null){  _oCmd.Parameters.Add("@customer_group", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@customer_group", SqlDbType.VarChar,50).Value=n_sCustomer_group; }
            if(n_dJoin_date==null){  _oCmd.Parameters.Add("@join_date", SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@join_date", SqlDbType.DateTime).Value=n_dJoin_date; }
            if(n_bIdd_flg==null){  _oCmd.Parameters.Add("@idd_flg", SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@idd_flg", SqlDbType.Bit).Value=n_bIdd_flg; }
            if(n_bActive==null){  _oCmd.Parameters.Add("@active", SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@active", SqlDbType.Bit).Value=n_bActive; }
            if(n_sPeriod==null){  _oCmd.Parameters.Add("@period", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@period", SqlDbType.VarChar,50).Value=n_sPeriod; }
            if(n_sField2==null){  _oCmd.Parameters.Add("@field2", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@field2", SqlDbType.VarChar,50).Value=n_sField2; }
            if(n_dStart_date==null){  _oCmd.Parameters.Add("@start_date", SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@start_date", SqlDbType.DateTime).Value=n_dStart_date; }
            if(n_sPlan_fee==null){  _oCmd.Parameters.Add("@plan_fee", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@plan_fee", SqlDbType.VarChar,50).Value=n_sPlan_fee; }
            if(n_sRate_plan==null){  _oCmd.Parameters.Add("@rate_plan", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@rate_plan", SqlDbType.VarChar,50).Value=n_sRate_plan; }
            if(n_sSegment==null){  _oCmd.Parameters.Add("@segment", SqlDbType.VarChar,15).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@segment", SqlDbType.VarChar,15).Value=n_sSegment; }
            if(n_dCdate==null){  _oCmd.Parameters.Add("@cdate", SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@cdate", SqlDbType.DateTime).Value=n_dCdate; }
            if(n_sProgram_id==null){  _oCmd.Parameters.Add("@program_id", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@program_id", SqlDbType.VarChar,50).Value=n_sProgram_id; }
            if(n_sPassword==null){  _oCmd.Parameters.Add("@password", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@password", SqlDbType.VarChar,50).Value=n_sPassword; }
            if(n_sPayment_method==null){  _oCmd.Parameters.Add("@payment_method", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@payment_method", SqlDbType.VarChar,50).Value=n_sPayment_method; }
            if(n_sContract_id==null){  _oCmd.Parameters.Add("@contract_id", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@contract_id", SqlDbType.VarChar,50).Value=n_sContract_id; }
            if(n_sCustomer_code==null){  _oCmd.Parameters.Add("@customer_code", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@customer_code", SqlDbType.VarChar,50).Value=n_sCustomer_code; }
            if(n_sMobile_no==null){  _oCmd.Parameters.Add("@mobile_no", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@mobile_no", SqlDbType.VarChar,50).Value=n_sMobile_no; }
            if(n_sAls_flg==null){  _oCmd.Parameters.Add("@als_flg", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@als_flg", SqlDbType.VarChar,50).Value=n_sAls_flg; }
            if(n_sVas_desc==null){  _oCmd.Parameters.Add("@vas_desc", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@vas_desc", SqlDbType.VarChar,50).Value=n_sVas_desc; }
            if(n_sAddr_3==null){  _oCmd.Parameters.Add("@addr_3", SqlDbType.VarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@addr_3", SqlDbType.VarChar,100).Value=n_sAddr_3; }
            if(n_sSubscriber_tier==null){  _oCmd.Parameters.Add("@subscriber_tier", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@subscriber_tier", SqlDbType.VarChar,50).Value=n_sSubscriber_tier; }
            if(n_sCustomer_id==null){  _oCmd.Parameters.Add("@customer_id", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@customer_id", SqlDbType.VarChar,50).Value=n_sCustomer_id; }
            if(n_dHandset_rebate_end_date==null){  _oCmd.Parameters.Add("@handset_rebate_end_date", SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@handset_rebate_end_date", SqlDbType.DateTime).Value=n_dHandset_rebate_end_date; }
            if(n_iPlan_free_inter_min==null){  _oCmd.Parameters.Add("@plan_free_inter_min", SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@plan_free_inter_min", SqlDbType.Int).Value=n_iPlan_free_inter_min; }
            if(n_sCid==null){  _oCmd.Parameters.Add("@cid", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@cid", SqlDbType.VarChar,50).Value=n_sCid; }
            if(n_sDid==null){  _oCmd.Parameters.Add("@did", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@did", SqlDbType.VarChar,50).Value=n_sDid; }
            if(n_iId==null){  _oCmd.Parameters.Add("@id", SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@id", SqlDbType.Int).Value=n_iId; }
            if(n_iPlan_free_intra_min==null){  _oCmd.Parameters.Add("@plan_free_intra_min", SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@plan_free_intra_min", SqlDbType.Int).Value=n_iPlan_free_intra_min; }
            if(n_bOriginal_telemarketing_suppress_flag==null){  _oCmd.Parameters.Add("@original_telemarketing_suppress_flag", SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@original_telemarketing_suppress_flag", SqlDbType.Bit).Value=n_bOriginal_telemarketing_suppress_flag; }
            if(n_sContact_number==null){  _oCmd.Parameters.Add("@contact_number", SqlDbType.VarChar,20).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@contact_number", SqlDbType.VarChar,20).Value=n_sContact_number; }
            if(n_sAddr_1==null){  _oCmd.Parameters.Add("@addr_1", SqlDbType.VarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@addr_1", SqlDbType.VarChar,100).Value=n_sAddr_1; }
            if(n_dMax_contract_end_date==null){  _oCmd.Parameters.Add("@max_contract_end_date", SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@max_contract_end_date", SqlDbType.DateTime).Value=n_dMax_contract_end_date; }
            if(n_sId1==null){  _oCmd.Parameters.Add("@id1", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@id1", SqlDbType.VarChar,50).Value=n_sId1; }
            if(n_sAutopay==null){  _oCmd.Parameters.Add("@autopay", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@autopay", SqlDbType.VarChar,50).Value=n_sAutopay; }
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
        /// Summary description for table [crm_rpt_2G_action_rpt_GL] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iId==null) { return false; }
            string _sQuery="DELETE FROM  [crm_rpt_2G_action_rpt_GL]  WHERE [crm_rpt_2G_action_rpt_GL].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[crm_rpt_2G_action_rpt_GL]","["+ Configurator.MSSQLTablePrefix + "crm_rpt_2G_action_rpt_GL]"); }
            SqlConnection _oConn = null;
            SqlCommand _oCmd = null;
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
                _oCmd = new SqlCommand(_sQuery, _oConn);
            }
            bool _bResult=false;
            _oCmd.Parameters.Add("@id", SqlDbType.Int).Value = n_iId;
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
        
        #region Clone
        
        /// <summary>
        /// Summary description for table [crm_rpt_2G_action_rpt_GL] Object Base Clone
        /// </summary>
        
        public Crm_rpt_2G_action_rpt_GL Clone()
        {
            Crm_rpt_2G_action_rpt_GL _oCrm_rpt_2G_action_rpt_GL_Clone = new Crm_rpt_2G_action_rpt_GL();
            _oCrm_rpt_2G_action_rpt_GL_Clone.telemarketing_suppress_flag = this.n_bTelemarketing_suppress_flag;
            _oCrm_rpt_2G_action_rpt_GL_Clone.end_date = this.n_dEnd_date;
            _oCrm_rpt_2G_action_rpt_GL_Clone.ddate = this.n_dDdate;
            _oCrm_rpt_2G_action_rpt_GL_Clone.airtime_hs_model = this.n_sAirtime_hs_model;
            _oCrm_rpt_2G_action_rpt_GL_Clone.tradefield = this.n_sTradefield;
            _oCrm_rpt_2G_action_rpt_GL_Clone.calllist_name = this.n_sCalllist_name;
            _oCrm_rpt_2G_action_rpt_GL_Clone.field1 = this.n_sField1;
            _oCrm_rpt_2G_action_rpt_GL_Clone.remarks = this.n_sRemarks;
            _oCrm_rpt_2G_action_rpt_GL_Clone.bill_cycle = this.n_iBill_cycle;
            _oCrm_rpt_2G_action_rpt_GL_Clone.addr_2 = this.n_sAddr_2;
            _oCrm_rpt_2G_action_rpt_GL_Clone.id_number = this.n_sId_number;
            _oCrm_rpt_2G_action_rpt_GL_Clone.attention_name_formartted = this.n_sAttention_name_formartted;
            _oCrm_rpt_2G_action_rpt_GL_Clone.customer_name_formartted = this.n_sCustomer_name_formartted;
            _oCrm_rpt_2G_action_rpt_GL_Clone.mnp_rebate_end_date = this.n_dMnp_rebate_end_date;
            _oCrm_rpt_2G_action_rpt_GL_Clone.field3 = this.n_sField3;
            _oCrm_rpt_2G_action_rpt_GL_Clone.addr_4 = this.n_sAddr_4;
            _oCrm_rpt_2G_action_rpt_GL_Clone.program = this.n_sProgram;
            _oCrm_rpt_2G_action_rpt_GL_Clone.prop_plan = this.n_sProp_plan;
            _oCrm_rpt_2G_action_rpt_GL_Clone.expired_month = this.n_sExpired_month;
            _oCrm_rpt_2G_action_rpt_GL_Clone.customer_group = this.n_sCustomer_group;
            _oCrm_rpt_2G_action_rpt_GL_Clone.join_date = this.n_dJoin_date;
            _oCrm_rpt_2G_action_rpt_GL_Clone.idd_flg = this.n_bIdd_flg;
            _oCrm_rpt_2G_action_rpt_GL_Clone.active = this.n_bActive;
            _oCrm_rpt_2G_action_rpt_GL_Clone.period = this.n_sPeriod;
            _oCrm_rpt_2G_action_rpt_GL_Clone.field2 = this.n_sField2;
            _oCrm_rpt_2G_action_rpt_GL_Clone.start_date = this.n_dStart_date;
            _oCrm_rpt_2G_action_rpt_GL_Clone.plan_fee = this.n_sPlan_fee;
            _oCrm_rpt_2G_action_rpt_GL_Clone.rate_plan = this.n_sRate_plan;
            _oCrm_rpt_2G_action_rpt_GL_Clone.segment = this.n_sSegment;
            _oCrm_rpt_2G_action_rpt_GL_Clone.cdate = this.n_dCdate;
            _oCrm_rpt_2G_action_rpt_GL_Clone.program_id = this.n_sProgram_id;
            _oCrm_rpt_2G_action_rpt_GL_Clone.password = this.n_sPassword;
            _oCrm_rpt_2G_action_rpt_GL_Clone.payment_method = this.n_sPayment_method;
            _oCrm_rpt_2G_action_rpt_GL_Clone.contract_id = this.n_sContract_id;
            _oCrm_rpt_2G_action_rpt_GL_Clone.customer_code = this.n_sCustomer_code;
            _oCrm_rpt_2G_action_rpt_GL_Clone.mobile_no = this.n_sMobile_no;
            _oCrm_rpt_2G_action_rpt_GL_Clone.als_flg = this.n_sAls_flg;
            _oCrm_rpt_2G_action_rpt_GL_Clone.vas_desc = this.n_sVas_desc;
            _oCrm_rpt_2G_action_rpt_GL_Clone.addr_3 = this.n_sAddr_3;
            _oCrm_rpt_2G_action_rpt_GL_Clone.subscriber_tier = this.n_sSubscriber_tier;
            _oCrm_rpt_2G_action_rpt_GL_Clone.customer_id = this.n_sCustomer_id;
            _oCrm_rpt_2G_action_rpt_GL_Clone.handset_rebate_end_date = this.n_dHandset_rebate_end_date;
            _oCrm_rpt_2G_action_rpt_GL_Clone.plan_free_inter_min = this.n_iPlan_free_inter_min;
            _oCrm_rpt_2G_action_rpt_GL_Clone.cid = this.n_sCid;
            _oCrm_rpt_2G_action_rpt_GL_Clone.did = this.n_sDid;
            _oCrm_rpt_2G_action_rpt_GL_Clone.id = this.n_iId;
            _oCrm_rpt_2G_action_rpt_GL_Clone.plan_free_intra_min = this.n_iPlan_free_intra_min;
            _oCrm_rpt_2G_action_rpt_GL_Clone.original_telemarketing_suppress_flag = this.n_bOriginal_telemarketing_suppress_flag;
            _oCrm_rpt_2G_action_rpt_GL_Clone.contact_number = this.n_sContact_number;
            _oCrm_rpt_2G_action_rpt_GL_Clone.addr_1 = this.n_sAddr_1;
            _oCrm_rpt_2G_action_rpt_GL_Clone.max_contract_end_date = this.n_dMax_contract_end_date;
            _oCrm_rpt_2G_action_rpt_GL_Clone.id1 = this.n_sId1;
            _oCrm_rpt_2G_action_rpt_GL_Clone.autopay = this.n_sAutopay;
            _oCrm_rpt_2G_action_rpt_GL_Clone.SetFound(this.n_bFound);
            _oCrm_rpt_2G_action_rpt_GL_Clone.SetDB(this.n_oDB);
            _oCrm_rpt_2G_action_rpt_GL_Clone.SetRow(this.n_oRow);
            _oCrm_rpt_2G_action_rpt_GL_Clone.SetTbl(this.n_oTbl);
            _oCrm_rpt_2G_action_rpt_GL_Clone.SetTableSet(this.n_oTableSet);
            
            return _oCrm_rpt_2G_action_rpt_GL_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_bTelemarketing_suppress_flag=null;
            n_dEnd_date=null;
            n_dDdate=null;
            n_sAirtime_hs_model=string.Empty;
            n_sTradefield=string.Empty;
            n_sCalllist_name=string.Empty;
            n_sField1=string.Empty;
            n_sRemarks=string.Empty;
            n_iBill_cycle=null;
            n_sAddr_2=string.Empty;
            n_sId_number=string.Empty;
            n_sAttention_name_formartted=string.Empty;
            n_sCustomer_name_formartted=string.Empty;
            n_dMnp_rebate_end_date=null;
            n_sField3=string.Empty;
            n_sAddr_4=string.Empty;
            n_sProgram=string.Empty;
            n_sProp_plan=string.Empty;
            n_sExpired_month=string.Empty;
            n_sCustomer_group=string.Empty;
            n_dJoin_date=null;
            n_bIdd_flg=null;
            n_bActive=null;
            n_sPeriod=string.Empty;
            n_sField2=string.Empty;
            n_dStart_date=null;
            n_sPlan_fee=string.Empty;
            n_sRate_plan=string.Empty;
            n_sSegment=string.Empty;
            n_dCdate=null;
            n_sProgram_id=string.Empty;
            n_sPassword=string.Empty;
            n_sPayment_method=string.Empty;
            n_sContract_id=string.Empty;
            n_sCustomer_code=string.Empty;
            n_sMobile_no=string.Empty;
            n_sAls_flg=string.Empty;
            n_sVas_desc=string.Empty;
            n_sAddr_3=string.Empty;
            n_sSubscriber_tier=string.Empty;
            n_sCustomer_id=string.Empty;
            n_dHandset_rebate_end_date=null;
            n_iPlan_free_inter_min=null;
            n_sCid=string.Empty;
            n_sDid=string.Empty;
            n_iId=null;
            n_iPlan_free_intra_min=null;
            n_bOriginal_telemarketing_suppress_flag=null;
            n_sContact_number=string.Empty;
            n_sAddr_1=string.Empty;
            n_dMax_contract_end_date=null;
            n_sId1=string.Empty;
            n_sAutopay=string.Empty;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = new Crm_rpt_2G_action_rpt_GLInfo();
        }
        #endregion
    }
}


