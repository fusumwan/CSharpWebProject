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
///-- Create date: <Create Date 2011-07-13>
///-- Description:	<Description,Table :[BusinessTrade],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [BusinessTrade] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"BusinessTrade")]
    public class BusinessTradeEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        
        protected global::System.Nullable<int> n_iMid=null;
        #region mid
        [System.Data.Linq.Mapping.Column(Name="[mid]", Storage="n_iMid")]
        public global::System.Nullable<int> mid{
            get{
                return this.n_iMid;
            }
            set{
                this.n_iMid=value;
            }
        }
        #endregion mid
        
        
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
        
        
        protected string n_sHs_model_name=global::System.String.Empty;
        #region hs_model_name
        [System.Data.Linq.Mapping.Column(Name="[hs_model_name]", Storage="n_sHs_model_name")]
        public string hs_model_name{
            get{
                return this.n_sHs_model_name;
            }
            set{
                this.n_sHs_model_name=value;
            }
        }
        #endregion hs_model_name
        
        
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
        
        
        protected string n_sPremium_1=global::System.String.Empty;
        #region premium_1
        [System.Data.Linq.Mapping.Column(Name="[premium_1]", Storage="n_sPremium_1")]
        public string premium_1{
            get{
                return this.n_sPremium_1;
            }
            set{
                this.n_sPremium_1=value;
            }
        }
        #endregion premium_1
        
        
        protected global::System.Nullable<DateTime> n_dSdate=null;
        #region sdate
        [System.Data.Linq.Mapping.Column(Name="[sdate]", Storage="n_dSdate")]
        public global::System.Nullable<DateTime> sdate{
            get{
                return this.n_dSdate;
            }
            set{
                this.n_dSdate=value;
            }
        }
        #endregion sdate
        
        
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
        
        
        protected string n_sPremium_2=global::System.String.Empty;
        #region premium_2
        [System.Data.Linq.Mapping.Column(Name="[premium_2]", Storage="n_sPremium_2")]
        public string premium_2{
            get{
                return this.n_sPremium_2;
            }
            set{
                this.n_sPremium_2=value;
            }
        }
        #endregion premium_2
        
        
        protected global::System.Nullable<DateTime> n_dPo_date=null;
        #region po_date
        [System.Data.Linq.Mapping.Column(Name="[po_date]", Storage="n_dPo_date")]
        public global::System.Nullable<DateTime> po_date{
            get{
                return this.n_dPo_date;
            }
            set{
                this.n_dPo_date=value;
            }
        }
        #endregion po_date
        
        
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
        
        
        protected string n_sOb_early=global::System.String.Empty;
        #region ob_early
        [System.Data.Linq.Mapping.Column(Name="[ob_early]", Storage="n_sOb_early")]
        public string ob_early{
            get{
                return this.n_sOb_early;
            }
            set{
                this.n_sOb_early=value;
            }
        }
        #endregion ob_early
        
        
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
        
        
        protected global::System.Nullable<bool> n_bCancel_renew=null;
        #region cancel_renew
        [System.Data.Linq.Mapping.Column(Name="[cancel_renew]", Storage="n_bCancel_renew")]
        public global::System.Nullable<bool> cancel_renew{
            get{
                return this.n_bCancel_renew;
            }
            set{
                this.n_bCancel_renew=value;
            }
        }
        #endregion cancel_renew
        
        
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
        
        
        protected string n_sPlan_fee=global::System.String.Empty;
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
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private BusinessTradeInfo n_oTableSet = BusinessTradeInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string mid="mid";
            public const string channel="channel";
            public const string cdate="cdate";
            public const string bundle_name="bundle_name";
            public const string hs_model_name="hs_model_name";
            public const string trade_field="trade_field";
            public const string did="did";
            public const string premium_1="premium_1";
            public const string sdate="sdate";
            public const string rebate="rebate";
            public const string premium_2="premium_2";
            public const string retention_type="retention_type";
            public const string extra_offer="extra_offer";
            public const string edate="edate";
            public const string program="program";
            public const string con_per="con_per";
            public const string rate_plan="rate_plan";
            public const string ddate="ddate";
            public const string normal_rebate_type="normal_rebate_type";
            public const string active="active";
            public const string free_mon="free_mon";
            public const string cid="cid";
            public const string cancel_renew="cancel_renew";
            public const string ob_early="ob_early";
            public const string normal_rebate="normal_rebate";
            public const string hs_model="hs_model";
            public const string plan_fee="plan_fee";
            public const string po_date="po_date";
            public const string remarks="remarks";
            public const string issue_type="issue_type";
            public const string BusinessTrade_table_name="BusinessTrade";
            public static string TableName() { return BusinessTrade_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public BusinessTradeEntity(){
            Init();
        }
        public BusinessTradeEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public BusinessTradeEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid){
            n_oDB=x_oDB;
            this.Load(x_iMid);
            Init();
        }
        
        ~BusinessTradeEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iMid){
            if (n_oDB==null) { return false; }
            if (x_iMid==null) { return false; }
            string _sQuery = "SELECT   [BusinessTrade].[mid] AS BUSINESSTRADE_MID,[BusinessTrade].[channel] AS BUSINESSTRADE_CHANNEL,[BusinessTrade].[cdate] AS BUSINESSTRADE_CDATE,[BusinessTrade].[bundle_name] AS BUSINESSTRADE_BUNDLE_NAME,[BusinessTrade].[hs_model_name] AS BUSINESSTRADE_HS_MODEL_NAME,[BusinessTrade].[trade_field] AS BUSINESSTRADE_TRADE_FIELD,[BusinessTrade].[did] AS BUSINESSTRADE_DID,[BusinessTrade].[premium_1] AS BUSINESSTRADE_PREMIUM_1,[BusinessTrade].[sdate] AS BUSINESSTRADE_SDATE,[BusinessTrade].[rebate] AS BUSINESSTRADE_REBATE,[BusinessTrade].[premium_2] AS BUSINESSTRADE_PREMIUM_2,[BusinessTrade].[po_date] AS BUSINESSTRADE_PO_DATE,[BusinessTrade].[retention_type] AS BUSINESSTRADE_RETENTION_TYPE,[BusinessTrade].[extra_offer] AS BUSINESSTRADE_EXTRA_OFFER,[BusinessTrade].[edate] AS BUSINESSTRADE_EDATE,[BusinessTrade].[program] AS BUSINESSTRADE_PROGRAM,[BusinessTrade].[ob_early] AS BUSINESSTRADE_OB_EARLY,[BusinessTrade].[con_per] AS BUSINESSTRADE_CON_PER,[BusinessTrade].[ddate] AS BUSINESSTRADE_DDATE,[BusinessTrade].[normal_rebate_type] AS BUSINESSTRADE_NORMAL_REBATE_TYPE,[BusinessTrade].[active] AS BUSINESSTRADE_ACTIVE,[BusinessTrade].[free_mon] AS BUSINESSTRADE_FREE_MON,[BusinessTrade].[cid] AS BUSINESSTRADE_CID,[BusinessTrade].[cancel_renew] AS BUSINESSTRADE_CANCEL_RENEW,[BusinessTrade].[rate_plan] AS BUSINESSTRADE_RATE_PLAN,[BusinessTrade].[normal_rebate] AS BUSINESSTRADE_NORMAL_REBATE,[BusinessTrade].[hs_model] AS BUSINESSTRADE_HS_MODEL,[BusinessTrade].[plan_fee] AS BUSINESSTRADE_PLAN_FEE,[BusinessTrade].[remarks] AS BUSINESSTRADE_REMARKS,[BusinessTrade].[issue_type] AS BUSINESSTRADE_ISSUE_TYPE  FROM  [BusinessTrade]  WHERE  [BusinessTrade].[mid] = \'"+x_iMid.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessTrade]","["+ Configurator.MSSQLTablePrefix + "BusinessTrade]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_MID"])) {n_iMid = (global::System.Nullable<int>)_oData["BUSINESSTRADE_MID"];}else{n_iMid=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_CHANNEL"])) {n_sChannel = (string)_oData["BUSINESSTRADE_CHANNEL"];}else{n_sChannel=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_CDATE"])) {n_dCdate = (global::System.Nullable<DateTime>)_oData["BUSINESSTRADE_CDATE"];}else{n_dCdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_BUNDLE_NAME"])) {n_sBundle_name = (string)_oData["BUSINESSTRADE_BUNDLE_NAME"];}else{n_sBundle_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_HS_MODEL_NAME"])) {n_sHs_model_name = (string)_oData["BUSINESSTRADE_HS_MODEL_NAME"];}else{n_sHs_model_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_TRADE_FIELD"])) {n_sTrade_field = (string)_oData["BUSINESSTRADE_TRADE_FIELD"];}else{n_sTrade_field=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_DID"])) {n_sDid = (string)_oData["BUSINESSTRADE_DID"];}else{n_sDid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_PREMIUM_1"])) {n_sPremium_1 = (string)_oData["BUSINESSTRADE_PREMIUM_1"];}else{n_sPremium_1=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_SDATE"])) {n_dSdate = (global::System.Nullable<DateTime>)_oData["BUSINESSTRADE_SDATE"];}else{n_dSdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_REBATE"])) {n_sRebate = (string)_oData["BUSINESSTRADE_REBATE"];}else{n_sRebate=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_PREMIUM_2"])) {n_sPremium_2 = (string)_oData["BUSINESSTRADE_PREMIUM_2"];}else{n_sPremium_2=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_PO_DATE"])) {n_dPo_date = (global::System.Nullable<DateTime>)_oData["BUSINESSTRADE_PO_DATE"];}else{n_dPo_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_RETENTION_TYPE"])) {n_sRetention_type = (string)_oData["BUSINESSTRADE_RETENTION_TYPE"];}else{n_sRetention_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_EXTRA_OFFER"])) {n_sExtra_offer = (string)_oData["BUSINESSTRADE_EXTRA_OFFER"];}else{n_sExtra_offer=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_EDATE"])) {n_dEdate = (global::System.Nullable<DateTime>)_oData["BUSINESSTRADE_EDATE"];}else{n_dEdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_PROGRAM"])) {n_sProgram = (string)_oData["BUSINESSTRADE_PROGRAM"];}else{n_sProgram=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_OB_EARLY"])) {n_sOb_early = (string)_oData["BUSINESSTRADE_OB_EARLY"];}else{n_sOb_early=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_CON_PER"])) {n_sCon_per = (string)_oData["BUSINESSTRADE_CON_PER"];}else{n_sCon_per=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_DDATE"])) {n_dDdate = (global::System.Nullable<DateTime>)_oData["BUSINESSTRADE_DDATE"];}else{n_dDdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_NORMAL_REBATE_TYPE"])) {n_sNormal_rebate_type = (string)_oData["BUSINESSTRADE_NORMAL_REBATE_TYPE"];}else{n_sNormal_rebate_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["BUSINESSTRADE_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_FREE_MON"])) {n_sFree_mon = (string)_oData["BUSINESSTRADE_FREE_MON"];}else{n_sFree_mon=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_CID"])) {n_sCid = (string)_oData["BUSINESSTRADE_CID"];}else{n_sCid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_CANCEL_RENEW"])) {n_bCancel_renew = (global::System.Nullable<bool>)_oData["BUSINESSTRADE_CANCEL_RENEW"];}else{n_bCancel_renew=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_RATE_PLAN"])) {n_sRate_plan = (string)_oData["BUSINESSTRADE_RATE_PLAN"];}else{n_sRate_plan=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_NORMAL_REBATE"])) {n_bNormal_rebate = (global::System.Nullable<bool>)_oData["BUSINESSTRADE_NORMAL_REBATE"];}else{n_bNormal_rebate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_HS_MODEL"])) {n_sHs_model = (string)_oData["BUSINESSTRADE_HS_MODEL"];}else{n_sHs_model=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_PLAN_FEE"])) {n_sPlan_fee = (string)_oData["BUSINESSTRADE_PLAN_FEE"];}else{n_sPlan_fee=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_REMARKS"])) {n_sRemarks = (string)_oData["BUSINESSTRADE_REMARKS"];}else{n_sRemarks=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_ISSUE_TYPE"])) {n_sIssue_type = (string)_oData["BUSINESSTRADE_ISSUE_TYPE"];}else{n_sIssue_type=global::System.String.Empty;}
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
            if(!x_bInsert){
                if (n_iMid==null && !(n_oTableSet.Fields(Para.mid).IsNullable)) return false;
            }
            if (n_sChannel==null && !(n_oTableSet.Fields(Para.channel).IsNullable)) return false;
            if (n_dCdate==null && !(n_oTableSet.Fields(Para.cdate).IsNullable)) return false;
            if (n_sBundle_name==null && !(n_oTableSet.Fields(Para.bundle_name).IsNullable)) return false;
            if (n_sHs_model_name==null && !(n_oTableSet.Fields(Para.hs_model_name).IsNullable)) return false;
            if (n_sTrade_field==null && !(n_oTableSet.Fields(Para.trade_field).IsNullable)) return false;
            if (n_sDid==null && !(n_oTableSet.Fields(Para.did).IsNullable)) return false;
            if (n_sPremium_1==null && !(n_oTableSet.Fields(Para.premium_1).IsNullable)) return false;
            if (n_dSdate==null && !(n_oTableSet.Fields(Para.sdate).IsNullable)) return false;
            if (n_sRebate==null && !(n_oTableSet.Fields(Para.rebate).IsNullable)) return false;
            if (n_sPremium_2==null && !(n_oTableSet.Fields(Para.premium_2).IsNullable)) return false;
            if (n_dPo_date==null && !(n_oTableSet.Fields(Para.po_date).IsNullable)) return false;
            if (n_sRetention_type==null && !(n_oTableSet.Fields(Para.retention_type).IsNullable)) return false;
            if (n_sExtra_offer==null && !(n_oTableSet.Fields(Para.extra_offer).IsNullable)) return false;
            if (n_dEdate==null && !(n_oTableSet.Fields(Para.edate).IsNullable)) return false;
            if (n_sProgram==null && !(n_oTableSet.Fields(Para.program).IsNullable)) return false;
            if (n_sOb_early==null && !(n_oTableSet.Fields(Para.ob_early).IsNullable)) return false;
            if (n_sCon_per==null && !(n_oTableSet.Fields(Para.con_per).IsNullable)) return false;
            if (n_dDdate==null && !(n_oTableSet.Fields(Para.ddate).IsNullable)) return false;
            if (n_sNormal_rebate_type==null && !(n_oTableSet.Fields(Para.normal_rebate_type).IsNullable)) return false;
            if (n_bActive==null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_sFree_mon==null && !(n_oTableSet.Fields(Para.free_mon).IsNullable)) return false;
            if (n_sCid==null && !(n_oTableSet.Fields(Para.cid).IsNullable)) return false;
            if (n_bCancel_renew==null && !(n_oTableSet.Fields(Para.cancel_renew).IsNullable)) return false;
            if (n_sRate_plan==null && !(n_oTableSet.Fields(Para.rate_plan).IsNullable)) return false;
            if (n_bNormal_rebate==null && !(n_oTableSet.Fields(Para.normal_rebate).IsNullable)) return false;
            if (n_sHs_model==null && !(n_oTableSet.Fields(Para.hs_model).IsNullable)) return false;
            if (n_sPlan_fee==null && !(n_oTableSet.Fields(Para.plan_fee).IsNullable)) return false;
            if (n_sRemarks==null && !(n_oTableSet.Fields(Para.remarks).IsNullable)) return false;
            if (n_sIssue_type==null && !(n_oTableSet.Fields(Para.issue_type).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(BusinessTradeEntity)) || (x_oObj is BusinessTradeEntity)) return BusinessTradeRepository.Instance();
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
        public BusinessTradeInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(BusinessTradeInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public global::System.Nullable<int> GetMid(){return this.mid;}
        public string GetChannel(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.channel)) { return string.Empty; }
            return this.channel;
        }
        public global::System.Nullable<DateTime> GetCdate(){return this.cdate;}
        public string GetBundle_name(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.bundle_name)) { return string.Empty; }
            return this.bundle_name;
        }
        public string GetHs_model_name(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.hs_model_name)) { return string.Empty; }
            return this.hs_model_name;
        }
        public string GetTrade_field(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.trade_field)) { return string.Empty; }
            return this.trade_field;
        }
        public string GetDid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.did)) { return string.Empty; }
            return this.did;
        }
        public string GetPremium_1(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.premium_1)) { return string.Empty; }
            return this.premium_1;
        }
        public global::System.Nullable<DateTime> GetSdate(){return this.sdate;}
        public string GetRebate(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.rebate)) { return string.Empty; }
            return this.rebate;
        }
        public string GetPremium_2(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.premium_2)) { return string.Empty; }
            return this.premium_2;
        }
        public string GetRetention_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.retention_type)) { return string.Empty; }
            return this.retention_type;
        }
        public string GetExtra_offer(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.extra_offer)) { return string.Empty; }
            return this.extra_offer;
        }
        public global::System.Nullable<DateTime> GetEdate(){return this.edate;}
        public string GetProgram(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.program)) { return string.Empty; }
            return this.program;
        }
        public string GetCon_per(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.con_per)) { return string.Empty; }
            return this.con_per;
        }
        public string GetRate_plan(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.rate_plan)) { return string.Empty; }
            return this.rate_plan;
        }
        public global::System.Nullable<DateTime> GetDdate(){return this.ddate;}
        public string GetNormal_rebate_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.normal_rebate_type)) { return string.Empty; }
            return this.normal_rebate_type;
        }
        public global::System.Nullable<bool> GetActive(){return this.active;}
        public string GetFree_mon(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.free_mon)) { return string.Empty; }
            return this.free_mon;
        }
        public string GetCid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.cid)) { return string.Empty; }
            return this.cid;
        }
        public global::System.Nullable<bool> GetCancel_renew(){return this.cancel_renew;}
        public string GetOb_early(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.ob_early)) { return string.Empty; }
            return this.ob_early;
        }
        public global::System.Nullable<bool> GetNormal_rebate(){return this.normal_rebate;}
        public string GetHs_model(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.hs_model)) { return string.Empty; }
            return this.hs_model;
        }
        public string GetPlan_fee(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.plan_fee)) { return string.Empty; }
            return this.plan_fee;
        }
        public global::System.Nullable<DateTime> GetPo_date(){return this.po_date;}
        public string GetRemarks(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.remarks)) { return string.Empty; }
            return this.remarks;
        }
        public string GetIssue_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.issue_type)) { return string.Empty; }
            return this.issue_type;
        }
        
        public bool SetMid(global::System.Nullable<int> value){
            this.mid=value;
            return true;
        }
        public bool SetChannel(string value){
            this.channel=value;
            return true;
        }
        public bool SetCdate(global::System.Nullable<DateTime> value){
            this.cdate=value;
            return true;
        }
        public bool SetBundle_name(string value){
            this.bundle_name=value;
            return true;
        }
        public bool SetHs_model_name(string value){
            this.hs_model_name=value;
            return true;
        }
        public bool SetTrade_field(string value){
            this.trade_field=value;
            return true;
        }
        public bool SetDid(string value){
            this.did=value;
            return true;
        }
        public bool SetPremium_1(string value){
            this.premium_1=value;
            return true;
        }
        public bool SetSdate(global::System.Nullable<DateTime> value){
            this.sdate=value;
            return true;
        }
        public bool SetRebate(string value){
            this.rebate=value;
            return true;
        }
        public bool SetPremium_2(string value){
            this.premium_2=value;
            return true;
        }
        public bool SetRetention_type(string value){
            this.retention_type=value;
            return true;
        }
        public bool SetExtra_offer(string value){
            this.extra_offer=value;
            return true;
        }
        public bool SetEdate(global::System.Nullable<DateTime> value){
            this.edate=value;
            return true;
        }
        public bool SetProgram(string value){
            this.program=value;
            return true;
        }
        public bool SetCon_per(string value){
            this.con_per=value;
            return true;
        }
        public bool SetRate_plan(string value){
            this.rate_plan=value;
            return true;
        }
        public bool SetDdate(global::System.Nullable<DateTime> value){
            this.ddate=value;
            return true;
        }
        public bool SetNormal_rebate_type(string value){
            this.normal_rebate_type=value;
            return true;
        }
        public bool SetActive(global::System.Nullable<bool> value){
            this.active=value;
            return true;
        }
        public bool SetFree_mon(string value){
            this.free_mon=value;
            return true;
        }
        public bool SetCid(string value){
            this.cid=value;
            return true;
        }
        public bool SetCancel_renew(global::System.Nullable<bool> value){
            this.cancel_renew=value;
            return true;
        }
        public bool SetOb_early(string value){
            this.ob_early=value;
            return true;
        }
        public bool SetNormal_rebate(global::System.Nullable<bool> value){
            this.normal_rebate=value;
            return true;
        }
        public bool SetHs_model(string value){
            this.hs_model=value;
            return true;
        }
        public bool SetPlan_fee(string value){
            this.plan_fee=value;
            return true;
        }
        public bool SetPo_date(global::System.Nullable<DateTime> value){
            this.po_date=value;
            return true;
        }
        public bool SetRemarks(string value){
            this.remarks=value;
            return true;
        }
        public bool SetIssue_type(string value){
            this.issue_type=value;
            return true;
        }
        
        public Field GetMidTable(){
            return n_oTableSet.Fields(Para.mid);
        }
        public Field GetChannelTable(){
            return n_oTableSet.Fields(Para.channel);
        }
        public Field GetCdateTable(){
            return n_oTableSet.Fields(Para.cdate);
        }
        public Field GetBundle_nameTable(){
            return n_oTableSet.Fields(Para.bundle_name);
        }
        public Field GetHs_model_nameTable(){
            return n_oTableSet.Fields(Para.hs_model_name);
        }
        public Field GetTrade_fieldTable(){
            return n_oTableSet.Fields(Para.trade_field);
        }
        public Field GetDidTable(){
            return n_oTableSet.Fields(Para.did);
        }
        public Field GetPremium_1Table(){
            return n_oTableSet.Fields(Para.premium_1);
        }
        public Field GetSdateTable(){
            return n_oTableSet.Fields(Para.sdate);
        }
        public Field GetRebateTable(){
            return n_oTableSet.Fields(Para.rebate);
        }
        public Field GetPremium_2Table(){
            return n_oTableSet.Fields(Para.premium_2);
        }
        public Field GetRetention_typeTable(){
            return n_oTableSet.Fields(Para.retention_type);
        }
        public Field GetExtra_offerTable(){
            return n_oTableSet.Fields(Para.extra_offer);
        }
        public Field GetEdateTable(){
            return n_oTableSet.Fields(Para.edate);
        }
        public Field GetProgramTable(){
            return n_oTableSet.Fields(Para.program);
        }
        public Field GetCon_perTable(){
            return n_oTableSet.Fields(Para.con_per);
        }
        public Field GetRate_planTable(){
            return n_oTableSet.Fields(Para.rate_plan);
        }
        public Field GetDdateTable(){
            return n_oTableSet.Fields(Para.ddate);
        }
        public Field GetNormal_rebate_typeTable(){
            return n_oTableSet.Fields(Para.normal_rebate_type);
        }
        public Field GetActiveTable(){
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetFree_monTable(){
            return n_oTableSet.Fields(Para.free_mon);
        }
        public Field GetCidTable(){
            return n_oTableSet.Fields(Para.cid);
        }
        public Field GetCancel_renewTable(){
            return n_oTableSet.Fields(Para.cancel_renew);
        }
        public Field GetOb_earlyTable(){
            return n_oTableSet.Fields(Para.ob_early);
        }
        public Field GetNormal_rebateTable(){
            return n_oTableSet.Fields(Para.normal_rebate);
        }
        public Field GetHs_modelTable(){
            return n_oTableSet.Fields(Para.hs_model);
        }
        public Field GetPlan_feeTable(){
            return n_oTableSet.Fields(Para.plan_fee);
        }
        public Field GetPo_dateTable(){
            return n_oTableSet.Fields(Para.po_date);
        }
        public Field GetRemarksTable(){
            return n_oTableSet.Fields(Para.remarks);
        }
        public Field GetIssue_typeTable(){
            return n_oTableSet.Fields(Para.issue_type);
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
        
        public bool EqualID(BusinessTrade x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iMid.Equals(x_oObj.mid)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(BusinessTrade x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_iMid.Equals(x_oObj.mid)){ return false; }
            if(!this.n_sChannel.Equals(x_oObj.channel)){ return false; }
            if(!this.n_dCdate.Equals(x_oObj.cdate)){ return false; }
            if(!this.n_sBundle_name.Equals(x_oObj.bundle_name)){ return false; }
            if(!this.n_sHs_model_name.Equals(x_oObj.hs_model_name)){ return false; }
            if(!this.n_sTrade_field.Equals(x_oObj.trade_field)){ return false; }
            if(!this.n_sDid.Equals(x_oObj.did)){ return false; }
            if(!this.n_sPremium_1.Equals(x_oObj.premium_1)){ return false; }
            if(!this.n_dSdate.Equals(x_oObj.sdate)){ return false; }
            if(!this.n_sRebate.Equals(x_oObj.rebate)){ return false; }
            if(!this.n_sPremium_2.Equals(x_oObj.premium_2)){ return false; }
            if(!this.n_dPo_date.Equals(x_oObj.po_date)){ return false; }
            if(!this.n_sRetention_type.Equals(x_oObj.retention_type)){ return false; }
            if(!this.n_sExtra_offer.Equals(x_oObj.extra_offer)){ return false; }
            if(!this.n_dEdate.Equals(x_oObj.edate)){ return false; }
            if(!this.n_sProgram.Equals(x_oObj.program)){ return false; }
            if(!this.n_sOb_early.Equals(x_oObj.ob_early)){ return false; }
            if(!this.n_sCon_per.Equals(x_oObj.con_per)){ return false; }
            if(!this.n_dDdate.Equals(x_oObj.ddate)){ return false; }
            if(!this.n_sNormal_rebate_type.Equals(x_oObj.normal_rebate_type)){ return false; }
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_sFree_mon.Equals(x_oObj.free_mon)){ return false; }
            if(!this.n_sCid.Equals(x_oObj.cid)){ return false; }
            if(!this.n_bCancel_renew.Equals(x_oObj.cancel_renew)){ return false; }
            if(!this.n_sRate_plan.Equals(x_oObj.rate_plan)){ return false; }
            if(!this.n_bNormal_rebate.Equals(x_oObj.normal_rebate)){ return false; }
            if(!this.n_sHs_model.Equals(x_oObj.hs_model)){ return false; }
            if(!this.n_sPlan_fee.Equals(x_oObj.plan_fee)){ return false; }
            if(!this.n_sRemarks.Equals(x_oObj.remarks)){ return false; }
            if(!this.n_sIssue_type.Equals(x_oObj.issue_type)){ return false; }
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
            if(!n_iMid.Equals(null)){
                _bResult=this.Load(n_iMid);
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
            if (n_iMid==null) { return false; }
            if(!Vaild(false)){ return false; }
            string _sQuery = "UPDATE  [BusinessTrade]  SET  [channel]=@channel,[cdate]=@cdate,[bundle_name]=@bundle_name,[hs_model_name]=@hs_model_name,[trade_field]=@trade_field,[did]=@did,[premium_1]=@premium_1,[sdate]=@sdate,[rebate]=@rebate,[premium_2]=@premium_2,[po_date]=@po_date,[retention_type]=@retention_type,[extra_offer]=@extra_offer,[edate]=@edate,[program]=@program,[ob_early]=@ob_early,[con_per]=@con_per,[ddate]=@ddate,[normal_rebate_type]=@normal_rebate_type,[active]=@active,[free_mon]=@free_mon,[cid]=@cid,[cancel_renew]=@cancel_renew,[rate_plan]=@rate_plan,[normal_rebate]=@normal_rebate,[hs_model]=@hs_model,[plan_fee]=@plan_fee,[remarks]=@remarks,[issue_type]=@issue_type  WHERE [BusinessTrade].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessTrade]","["+ Configurator.MSSQLTablePrefix + "BusinessTrade]"); }
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
            if(n_iMid==null){  _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value=n_iMid; }
            if(n_sChannel==null){  _oCmd.Parameters.Add("@channel", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@channel", global::System.Data.SqlDbType.Char,10).Value=n_sChannel; }
            if(n_dCdate==null){  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=n_dCdate; }
            if(n_sBundle_name==null){  _oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,50).Value=n_sBundle_name; }
            if(n_sHs_model_name==null){  _oCmd.Parameters.Add("@hs_model_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@hs_model_name", global::System.Data.SqlDbType.NVarChar,250).Value=n_sHs_model_name; }
            if(n_sTrade_field==null){  _oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,50).Value=n_sTrade_field; }
            if(n_sDid==null){  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10).Value=n_sDid; }
            if(n_sPremium_1==null){  _oCmd.Parameters.Add("@premium_1", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@premium_1", global::System.Data.SqlDbType.NVarChar,250).Value=n_sPremium_1; }
            if(n_dSdate==null){  _oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value=n_dSdate; }
            if(n_sRebate==null){  _oCmd.Parameters.Add("@rebate", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@rebate", global::System.Data.SqlDbType.NVarChar,10).Value=n_sRebate; }
            if(n_sPremium_2==null){  _oCmd.Parameters.Add("@premium_2", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@premium_2", global::System.Data.SqlDbType.NVarChar,250).Value=n_sPremium_2; }
            if(n_dPo_date==null){  _oCmd.Parameters.Add("@po_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@po_date", global::System.Data.SqlDbType.DateTime).Value=n_dPo_date; }
            if(n_sRetention_type==null){  _oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.NVarChar,50).Value=n_sRetention_type; }
            if(n_sExtra_offer==null){  _oCmd.Parameters.Add("@extra_offer", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@extra_offer", global::System.Data.SqlDbType.NVarChar,250).Value=n_sExtra_offer; }
            if(n_dEdate==null){  _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=n_dEdate; }
            if(n_sProgram==null){  _oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value=n_sProgram; }
            if(n_sOb_early==null){  _oCmd.Parameters.Add("@ob_early", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@ob_early", global::System.Data.SqlDbType.Char,10).Value=n_sOb_early; }
            if(n_sCon_per==null){  _oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10).Value=n_sCon_per; }
            if(n_dDdate==null){  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=n_dDdate; }
            if(n_sNormal_rebate_type==null){  _oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value=n_sNormal_rebate_type; }
            if(n_bActive==null){  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=n_bActive; }
            if(n_sFree_mon==null){  _oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.NVarChar,50).Value=n_sFree_mon; }
            if(n_sCid==null){  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value=n_sCid; }
            if(n_bCancel_renew==null){  _oCmd.Parameters.Add("@cancel_renew", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@cancel_renew", global::System.Data.SqlDbType.Bit).Value=n_bCancel_renew; }
            if(n_sRate_plan==null){  _oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50).Value=n_sRate_plan; }
            if(n_bNormal_rebate==null){  _oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit).Value=n_bNormal_rebate; }
            if(n_sHs_model==null){  _oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value=n_sHs_model; }
            if(n_sPlan_fee==null){  _oCmd.Parameters.Add("@plan_fee", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@plan_fee", global::System.Data.SqlDbType.NVarChar,10).Value=n_sPlan_fee; }
            if(n_sRemarks==null){  _oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.Text,2147483647).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.Text,2147483647).Value=n_sRemarks; }
            if(n_sIssue_type==null){  _oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value=n_sIssue_type; }
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
        /// Summary description for table [BusinessTrade] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iMid==null) { return false; }
            string _sQuery="DELETE FROM  [BusinessTrade]  WHERE [BusinessTrade].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessTrade]","["+ Configurator.MSSQLTablePrefix + "BusinessTrade]"); }
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
            _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value = n_iMid;
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
        /// Summary description for table [BusinessTrade] Object Base Clone
        /// </summary>
        
        public BusinessTrade DeepClone()
        {
            BusinessTrade _oBusinessTrade_Clone = new BusinessTrade();
            _oBusinessTrade_Clone.mid = this.n_iMid;
            _oBusinessTrade_Clone.channel = this.n_sChannel;
            _oBusinessTrade_Clone.cdate = this.n_dCdate;
            _oBusinessTrade_Clone.bundle_name = this.n_sBundle_name;
            _oBusinessTrade_Clone.hs_model_name = this.n_sHs_model_name;
            _oBusinessTrade_Clone.trade_field = this.n_sTrade_field;
            _oBusinessTrade_Clone.did = this.n_sDid;
            _oBusinessTrade_Clone.premium_1 = this.n_sPremium_1;
            _oBusinessTrade_Clone.sdate = this.n_dSdate;
            _oBusinessTrade_Clone.rebate = this.n_sRebate;
            _oBusinessTrade_Clone.premium_2 = this.n_sPremium_2;
            _oBusinessTrade_Clone.po_date = this.n_dPo_date;
            _oBusinessTrade_Clone.retention_type = this.n_sRetention_type;
            _oBusinessTrade_Clone.extra_offer = this.n_sExtra_offer;
            _oBusinessTrade_Clone.edate = this.n_dEdate;
            _oBusinessTrade_Clone.program = this.n_sProgram;
            _oBusinessTrade_Clone.ob_early = this.n_sOb_early;
            _oBusinessTrade_Clone.con_per = this.n_sCon_per;
            _oBusinessTrade_Clone.ddate = this.n_dDdate;
            _oBusinessTrade_Clone.normal_rebate_type = this.n_sNormal_rebate_type;
            _oBusinessTrade_Clone.active = this.n_bActive;
            _oBusinessTrade_Clone.free_mon = this.n_sFree_mon;
            _oBusinessTrade_Clone.cid = this.n_sCid;
            _oBusinessTrade_Clone.cancel_renew = this.n_bCancel_renew;
            _oBusinessTrade_Clone.rate_plan = this.n_sRate_plan;
            _oBusinessTrade_Clone.normal_rebate = this.n_bNormal_rebate;
            _oBusinessTrade_Clone.hs_model = this.n_sHs_model;
            _oBusinessTrade_Clone.plan_fee = this.n_sPlan_fee;
            _oBusinessTrade_Clone.remarks = this.n_sRemarks;
            _oBusinessTrade_Clone.issue_type = this.n_sIssue_type;
            _oBusinessTrade_Clone.SetFound(this.n_bFound);
            _oBusinessTrade_Clone.SetDB(this.n_oDB);
            _oBusinessTrade_Clone.SetRow(this.n_oRow);
            _oBusinessTrade_Clone.SetTbl(this.n_oTbl);
            _oBusinessTrade_Clone.SetTableSet(this.n_oTableSet);
            
            return _oBusinessTrade_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_iMid=null;
            n_sChannel=global::System.String.Empty;
            n_dCdate=null;
            n_sBundle_name=global::System.String.Empty;
            n_sHs_model_name=global::System.String.Empty;
            n_sTrade_field=global::System.String.Empty;
            n_sDid=global::System.String.Empty;
            n_sPremium_1=global::System.String.Empty;
            n_dSdate=null;
            n_sRebate=global::System.String.Empty;
            n_sPremium_2=global::System.String.Empty;
            n_dPo_date=null;
            n_sRetention_type=global::System.String.Empty;
            n_sExtra_offer=global::System.String.Empty;
            n_dEdate=null;
            n_sProgram=global::System.String.Empty;
            n_sOb_early=global::System.String.Empty;
            n_sCon_per=global::System.String.Empty;
            n_dDdate=null;
            n_sNormal_rebate_type=global::System.String.Empty;
            n_bActive=null;
            n_sFree_mon=global::System.String.Empty;
            n_sCid=global::System.String.Empty;
            n_bCancel_renew=null;
            n_sRate_plan=global::System.String.Empty;
            n_bNormal_rebate=null;
            n_sHs_model=global::System.String.Empty;
            n_sPlan_fee=global::System.String.Empty;
            n_sRemarks=global::System.String.Empty;
            n_sIssue_type=global::System.String.Empty;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = BusinessTradeInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


