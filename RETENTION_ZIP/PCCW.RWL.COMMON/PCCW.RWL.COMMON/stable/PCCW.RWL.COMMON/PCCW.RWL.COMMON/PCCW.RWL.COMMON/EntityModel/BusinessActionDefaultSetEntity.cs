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
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2011-07-14>
///-- Description:	<Description,Table :[BusinessActionDefaultSet],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [BusinessActionDefaultSet] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"BusinessActionDefaultSet")]
    public class BusinessActionDefaultSetEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        
        protected global::System.Nullable<bool> n_bDisplay2=null;
        #region display2
        [System.Data.Linq.Mapping.Column(Name="[display2]", Storage="n_bDisplay2")]
        public global::System.Nullable<bool> display2{
            get{
                return this.n_bDisplay2;
            }
            set{
                this.n_bDisplay2=value;
            }
        }
        #endregion display2
        
        
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
        
        
        protected global::System.Nullable<bool> n_bDisplay1=null;
        #region display1
        [System.Data.Linq.Mapping.Column(Name="[display1]", Storage="n_bDisplay1")]
        public global::System.Nullable<bool> display1{
            get{
                return this.n_bDisplay1;
            }
            set{
                this.n_bDisplay1=value;
            }
        }
        #endregion display1
        
        
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
        
        
        protected string n_sBusiness_action_value_2=global::System.String.Empty;
        #region business_action_value_2
        [System.Data.Linq.Mapping.Column(Name="[business_action_value_2]", Storage="n_sBusiness_action_value_2")]
        public string business_action_value_2{
            get{
                return this.n_sBusiness_action_value_2;
            }
            set{
                this.n_sBusiness_action_value_2=value;
            }
        }
        #endregion business_action_value_2
        
        
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
        
        
        protected global::System.Nullable<bool> n_bEnabled2=null;
        #region enabled2
        [System.Data.Linq.Mapping.Column(Name="[enabled2]", Storage="n_bEnabled2")]
        public global::System.Nullable<bool> enabled2{
            get{
                return this.n_bEnabled2;
            }
            set{
                this.n_bEnabled2=value;
            }
        }
        #endregion enabled2
        
        
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
        
        
        protected string n_sBusiness_action_2=global::System.String.Empty;
        #region business_action_2
        [System.Data.Linq.Mapping.Column(Name="[business_action_2]", Storage="n_sBusiness_action_2")]
        public string business_action_2{
            get{
                return this.n_sBusiness_action_2;
            }
            set{
                this.n_sBusiness_action_2=value;
            }
        }
        #endregion business_action_2
        
        
        protected string n_sBusiness_action_1=global::System.String.Empty;
        #region business_action_1
        [System.Data.Linq.Mapping.Column(Name="[business_action_1]", Storage="n_sBusiness_action_1")]
        public string business_action_1{
            get{
                return this.n_sBusiness_action_1;
            }
            set{
                this.n_sBusiness_action_1=value;
            }
        }
        #endregion business_action_1
        
        
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
        
        
        protected string n_sBusiness_action_value_1=global::System.String.Empty;
        #region business_action_value_1
        [System.Data.Linq.Mapping.Column(Name="[business_action_value_1]", Storage="n_sBusiness_action_value_1")]
        public string business_action_value_1{
            get{
                return this.n_sBusiness_action_value_1;
            }
            set{
                this.n_sBusiness_action_value_1=value;
            }
        }
        #endregion business_action_value_1
        
        
        protected global::System.Nullable<bool> n_bEnabled1=null;
        #region enabled1
        [System.Data.Linq.Mapping.Column(Name="[enabled1]", Storage="n_bEnabled1")]
        public global::System.Nullable<bool> enabled1{
            get{
                return this.n_bEnabled1;
            }
            set{
                this.n_bEnabled1=value;
            }
        }
        #endregion enabled1
        
        
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
        private BusinessActionDefaultSetInfo n_oTableSet = BusinessActionDefaultSetInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string lob="lob";
            public const string s_premium2="s_premium2";
            public const string display2="display2";
            public const string mid="mid";
            public const string display1="display1";
            public const string cdate="cdate";
            public const string bundle_name="bundle_name";
            public const string business_action_value_1="business_action_value_1";
            public const string trade_field="trade_field";
            public const string s_premium="s_premium";
            public const string program="program";
            public const string edate="edate";
            public const string rebate="rebate";
            public const string con_per="con_per";
            public const string normal_rebate_type="normal_rebate_type";
            public const string premium="premium";
            public const string business_action_value_2="business_action_value_2";
            public const string enabled2="enabled2";
            public const string cid="cid";
            public const string business_action_2="business_action_2";
            public const string business_action_1="business_action_1";
            public const string rate_plan="rate_plan";
            public const string free_mon="free_mon";
            public const string enabled1="enabled1";
            public const string hs_model="hs_model";
            public const string active="active";
            public const string issue_type="issue_type";
            public const string BusinessActionDefaultSet_table_name="BusinessActionDefaultSet";
            public static string TableName() { return BusinessActionDefaultSet_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public BusinessActionDefaultSetEntity(){
            Init();
        }
        public BusinessActionDefaultSetEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public BusinessActionDefaultSetEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid){
            n_oDB=x_oDB;
            this.Load(x_iMid);
            Init();
        }
        
        ~BusinessActionDefaultSetEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iMid){
            if (n_oDB==null) { return false; }
            if (x_iMid==null) { return false; }
            string _sQuery = "SELECT   [BusinessActionDefaultSet].[lob] AS BUSINESSACTIONDEFAULTSET_LOB,[BusinessActionDefaultSet].[display2] AS BUSINESSACTIONDEFAULTSET_DISPLAY2,[BusinessActionDefaultSet].[mid] AS BUSINESSACTIONDEFAULTSET_MID,[BusinessActionDefaultSet].[display1] AS BUSINESSACTIONDEFAULTSET_DISPLAY1,[BusinessActionDefaultSet].[cdate] AS BUSINESSACTIONDEFAULTSET_CDATE,[BusinessActionDefaultSet].[bundle_name] AS BUSINESSACTIONDEFAULTSET_BUNDLE_NAME,[BusinessActionDefaultSet].[trade_field] AS BUSINESSACTIONDEFAULTSET_TRADE_FIELD,[BusinessActionDefaultSet].[s_premium] AS BUSINESSACTIONDEFAULTSET_S_PREMIUM,[BusinessActionDefaultSet].[program] AS BUSINESSACTIONDEFAULTSET_PROGRAM,[BusinessActionDefaultSet].[edate] AS BUSINESSACTIONDEFAULTSET_EDATE,[BusinessActionDefaultSet].[rebate] AS BUSINESSACTIONDEFAULTSET_REBATE,[BusinessActionDefaultSet].[active] AS BUSINESSACTIONDEFAULTSET_ACTIVE,[BusinessActionDefaultSet].[business_action_value_2] AS BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_VALUE_2,[BusinessActionDefaultSet].[con_per] AS BUSINESSACTIONDEFAULTSET_CON_PER,[BusinessActionDefaultSet].[normal_rebate_type] AS BUSINESSACTIONDEFAULTSET_NORMAL_REBATE_TYPE,[BusinessActionDefaultSet].[premium] AS BUSINESSACTIONDEFAULTSET_PREMIUM,[BusinessActionDefaultSet].[free_mon] AS BUSINESSACTIONDEFAULTSET_FREE_MON,[BusinessActionDefaultSet].[enabled2] AS BUSINESSACTIONDEFAULTSET_ENABLED2,[BusinessActionDefaultSet].[cid] AS BUSINESSACTIONDEFAULTSET_CID,[BusinessActionDefaultSet].[business_action_2] AS BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_2,[BusinessActionDefaultSet].[business_action_1] AS BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_1,[BusinessActionDefaultSet].[rate_plan] AS BUSINESSACTIONDEFAULTSET_RATE_PLAN,[BusinessActionDefaultSet].[business_action_value_1] AS BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_VALUE_1,[BusinessActionDefaultSet].[enabled1] AS BUSINESSACTIONDEFAULTSET_ENABLED1,[BusinessActionDefaultSet].[hs_model] AS BUSINESSACTIONDEFAULTSET_HS_MODEL,[BusinessActionDefaultSet].[s_premium2] AS BUSINESSACTIONDEFAULTSET_S_PREMIUM2,[BusinessActionDefaultSet].[issue_type] AS BUSINESSACTIONDEFAULTSET_ISSUE_TYPE  FROM  [BusinessActionDefaultSet]  WHERE  [BusinessActionDefaultSet].[mid] = \'"+x_iMid.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessActionDefaultSet]","["+ Configurator.MSSQLTablePrefix + "BusinessActionDefaultSet]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_LOB"])) {n_sLob = (string)_oData["BUSINESSACTIONDEFAULTSET_LOB"];}else{n_sLob=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_DISPLAY2"])) {n_bDisplay2 = (global::System.Nullable<bool>)_oData["BUSINESSACTIONDEFAULTSET_DISPLAY2"];}else{n_bDisplay2=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_MID"])) {n_iMid = (global::System.Nullable<int>)_oData["BUSINESSACTIONDEFAULTSET_MID"];}else{n_iMid=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_DISPLAY1"])) {n_bDisplay1 = (global::System.Nullable<bool>)_oData["BUSINESSACTIONDEFAULTSET_DISPLAY1"];}else{n_bDisplay1=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_CDATE"])) {n_dCdate = (global::System.Nullable<DateTime>)_oData["BUSINESSACTIONDEFAULTSET_CDATE"];}else{n_dCdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_BUNDLE_NAME"])) {n_sBundle_name = (string)_oData["BUSINESSACTIONDEFAULTSET_BUNDLE_NAME"];}else{n_sBundle_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_TRADE_FIELD"])) {n_sTrade_field = (string)_oData["BUSINESSACTIONDEFAULTSET_TRADE_FIELD"];}else{n_sTrade_field=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_S_PREMIUM"])) {n_sS_premium = (string)_oData["BUSINESSACTIONDEFAULTSET_S_PREMIUM"];}else{n_sS_premium=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_PROGRAM"])) {n_sProgram = (string)_oData["BUSINESSACTIONDEFAULTSET_PROGRAM"];}else{n_sProgram=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_EDATE"])) {n_dEdate = (global::System.Nullable<DateTime>)_oData["BUSINESSACTIONDEFAULTSET_EDATE"];}else{n_dEdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_REBATE"])) {n_sRebate = (string)_oData["BUSINESSACTIONDEFAULTSET_REBATE"];}else{n_sRebate=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["BUSINESSACTIONDEFAULTSET_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_VALUE_2"])) {n_sBusiness_action_value_2 = (string)_oData["BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_VALUE_2"];}else{n_sBusiness_action_value_2=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_CON_PER"])) {n_sCon_per = (string)_oData["BUSINESSACTIONDEFAULTSET_CON_PER"];}else{n_sCon_per=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_NORMAL_REBATE_TYPE"])) {n_sNormal_rebate_type = (string)_oData["BUSINESSACTIONDEFAULTSET_NORMAL_REBATE_TYPE"];}else{n_sNormal_rebate_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_PREMIUM"])) {n_sPremium = (string)_oData["BUSINESSACTIONDEFAULTSET_PREMIUM"];}else{n_sPremium=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_FREE_MON"])) {n_sFree_mon = (string)_oData["BUSINESSACTIONDEFAULTSET_FREE_MON"];}else{n_sFree_mon=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_ENABLED2"])) {n_bEnabled2 = (global::System.Nullable<bool>)_oData["BUSINESSACTIONDEFAULTSET_ENABLED2"];}else{n_bEnabled2=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_CID"])) {n_sCid = (string)_oData["BUSINESSACTIONDEFAULTSET_CID"];}else{n_sCid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_2"])) {n_sBusiness_action_2 = (string)_oData["BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_2"];}else{n_sBusiness_action_2=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_1"])) {n_sBusiness_action_1 = (string)_oData["BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_1"];}else{n_sBusiness_action_1=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_RATE_PLAN"])) {n_sRate_plan = (string)_oData["BUSINESSACTIONDEFAULTSET_RATE_PLAN"];}else{n_sRate_plan=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_VALUE_1"])) {n_sBusiness_action_value_1 = (string)_oData["BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_VALUE_1"];}else{n_sBusiness_action_value_1=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_ENABLED1"])) {n_bEnabled1 = (global::System.Nullable<bool>)_oData["BUSINESSACTIONDEFAULTSET_ENABLED1"];}else{n_bEnabled1=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_HS_MODEL"])) {n_sHs_model = (string)_oData["BUSINESSACTIONDEFAULTSET_HS_MODEL"];}else{n_sHs_model=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_S_PREMIUM2"])) {n_sS_premium2 = (string)_oData["BUSINESSACTIONDEFAULTSET_S_PREMIUM2"];}else{n_sS_premium2=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_ISSUE_TYPE"])) {n_sIssue_type = (string)_oData["BUSINESSACTIONDEFAULTSET_ISSUE_TYPE"];}else{n_sIssue_type=global::System.String.Empty;}
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
            if (n_sLob==null && !(n_oTableSet.Fields(Para.lob).IsNullable)) return false;
            if (n_bDisplay2==null && !(n_oTableSet.Fields(Para.display2).IsNullable)) return false;
            if(!x_bInsert){
                if (n_iMid==null && !(n_oTableSet.Fields(Para.mid).IsNullable)) return false;
            }
            if (n_bDisplay1==null && !(n_oTableSet.Fields(Para.display1).IsNullable)) return false;
            if (n_dCdate==null && !(n_oTableSet.Fields(Para.cdate).IsNullable)) return false;
            if (n_sBundle_name==null && !(n_oTableSet.Fields(Para.bundle_name).IsNullable)) return false;
            if (n_sTrade_field==null && !(n_oTableSet.Fields(Para.trade_field).IsNullable)) return false;
            if (n_sS_premium==null && !(n_oTableSet.Fields(Para.s_premium).IsNullable)) return false;
            if (n_sProgram==null && !(n_oTableSet.Fields(Para.program).IsNullable)) return false;
            if (n_dEdate==null && !(n_oTableSet.Fields(Para.edate).IsNullable)) return false;
            if (n_sRebate==null && !(n_oTableSet.Fields(Para.rebate).IsNullable)) return false;
            if (n_bActive==null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_sBusiness_action_value_2==null && !(n_oTableSet.Fields(Para.business_action_value_2).IsNullable)) return false;
            if (n_sCon_per==null && !(n_oTableSet.Fields(Para.con_per).IsNullable)) return false;
            if (n_sNormal_rebate_type==null && !(n_oTableSet.Fields(Para.normal_rebate_type).IsNullable)) return false;
            if (n_sPremium==null && !(n_oTableSet.Fields(Para.premium).IsNullable)) return false;
            if (n_sFree_mon==null && !(n_oTableSet.Fields(Para.free_mon).IsNullable)) return false;
            if (n_bEnabled2==null && !(n_oTableSet.Fields(Para.enabled2).IsNullable)) return false;
            if (n_sCid==null && !(n_oTableSet.Fields(Para.cid).IsNullable)) return false;
            if (n_sBusiness_action_2==null && !(n_oTableSet.Fields(Para.business_action_2).IsNullable)) return false;
            if (n_sBusiness_action_1==null && !(n_oTableSet.Fields(Para.business_action_1).IsNullable)) return false;
            if (n_sRate_plan==null && !(n_oTableSet.Fields(Para.rate_plan).IsNullable)) return false;
            if (n_sBusiness_action_value_1==null && !(n_oTableSet.Fields(Para.business_action_value_1).IsNullable)) return false;
            if (n_bEnabled1==null && !(n_oTableSet.Fields(Para.enabled1).IsNullable)) return false;
            if (n_sHs_model==null && !(n_oTableSet.Fields(Para.hs_model).IsNullable)) return false;
            if (n_sS_premium2==null && !(n_oTableSet.Fields(Para.s_premium2).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(BusinessActionDefaultSetEntity)) || (x_oObj is BusinessActionDefaultSetEntity)) return BusinessActionDefaultSetRepository.Instance();
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
        public BusinessActionDefaultSetInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(BusinessActionDefaultSetInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public string GetLob(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.lob)) { return string.Empty; }
            return this.lob;
        }
        public string GetS_premium2(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.s_premium2)) { return string.Empty; }
            return this.s_premium2;
        }
        public global::System.Nullable<bool> GetDisplay2(){return this.display2;}
        public global::System.Nullable<int> GetMid(){return this.mid;}
        public global::System.Nullable<bool> GetDisplay1(){return this.display1;}
        public global::System.Nullable<DateTime> GetCdate(){return this.cdate;}
        public string GetBundle_name(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.bundle_name)) { return string.Empty; }
            return this.bundle_name;
        }
        public string GetBusiness_action_value_1(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.business_action_value_1)) { return string.Empty; }
            return this.business_action_value_1;
        }
        public string GetTrade_field(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.trade_field)) { return string.Empty; }
            return this.trade_field;
        }
        public string GetS_premium(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.s_premium)) { return string.Empty; }
            return this.s_premium;
        }
        public string GetProgram(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.program)) { return string.Empty; }
            return this.program;
        }
        public global::System.Nullable<DateTime> GetEdate(){return this.edate;}
        public string GetRebate(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.rebate)) { return string.Empty; }
            return this.rebate;
        }
        public string GetCon_per(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.con_per)) { return string.Empty; }
            return this.con_per;
        }
        public string GetNormal_rebate_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.normal_rebate_type)) { return string.Empty; }
            return this.normal_rebate_type;
        }
        public string GetPremium(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.premium)) { return string.Empty; }
            return this.premium;
        }
        public string GetBusiness_action_value_2(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.business_action_value_2)) { return string.Empty; }
            return this.business_action_value_2;
        }
        public global::System.Nullable<bool> GetEnabled2(){return this.enabled2;}
        public string GetCid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.cid)) { return string.Empty; }
            return this.cid;
        }
        public string GetBusiness_action_2(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.business_action_2)) { return string.Empty; }
            return this.business_action_2;
        }
        public string GetBusiness_action_1(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.business_action_1)) { return string.Empty; }
            return this.business_action_1;
        }
        public string GetRate_plan(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.rate_plan)) { return string.Empty; }
            return this.rate_plan;
        }
        public string GetFree_mon(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.free_mon)) { return string.Empty; }
            return this.free_mon;
        }
        public global::System.Nullable<bool> GetEnabled1(){return this.enabled1;}
        public string GetHs_model(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.hs_model)) { return string.Empty; }
            return this.hs_model;
        }
        public global::System.Nullable<bool> GetActive(){return this.active;}
        public string GetIssue_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.issue_type)) { return string.Empty; }
            return this.issue_type;
        }
        
        public bool SetLob(string value){
            this.lob=value;
            return true;
        }
        public bool SetS_premium2(string value){
            this.s_premium2=value;
            return true;
        }
        public bool SetDisplay2(global::System.Nullable<bool> value){
            this.display2=value;
            return true;
        }
        public bool SetMid(global::System.Nullable<int> value){
            this.mid=value;
            return true;
        }
        public bool SetDisplay1(global::System.Nullable<bool> value){
            this.display1=value;
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
        public bool SetBusiness_action_value_1(string value){
            this.business_action_value_1=value;
            return true;
        }
        public bool SetTrade_field(string value){
            this.trade_field=value;
            return true;
        }
        public bool SetS_premium(string value){
            this.s_premium=value;
            return true;
        }
        public bool SetProgram(string value){
            this.program=value;
            return true;
        }
        public bool SetEdate(global::System.Nullable<DateTime> value){
            this.edate=value;
            return true;
        }
        public bool SetRebate(string value){
            this.rebate=value;
            return true;
        }
        public bool SetCon_per(string value){
            this.con_per=value;
            return true;
        }
        public bool SetNormal_rebate_type(string value){
            this.normal_rebate_type=value;
            return true;
        }
        public bool SetPremium(string value){
            this.premium=value;
            return true;
        }
        public bool SetBusiness_action_value_2(string value){
            this.business_action_value_2=value;
            return true;
        }
        public bool SetEnabled2(global::System.Nullable<bool> value){
            this.enabled2=value;
            return true;
        }
        public bool SetCid(string value){
            this.cid=value;
            return true;
        }
        public bool SetBusiness_action_2(string value){
            this.business_action_2=value;
            return true;
        }
        public bool SetBusiness_action_1(string value){
            this.business_action_1=value;
            return true;
        }
        public bool SetRate_plan(string value){
            this.rate_plan=value;
            return true;
        }
        public bool SetFree_mon(string value){
            this.free_mon=value;
            return true;
        }
        public bool SetEnabled1(global::System.Nullable<bool> value){
            this.enabled1=value;
            return true;
        }
        public bool SetHs_model(string value){
            this.hs_model=value;
            return true;
        }
        public bool SetActive(global::System.Nullable<bool> value){
            this.active=value;
            return true;
        }
        public bool SetIssue_type(string value){
            this.issue_type=value;
            return true;
        }
        
        public Field GetLobTable(){
            return n_oTableSet.Fields(Para.lob);
        }
        public Field GetS_premium2Table(){
            return n_oTableSet.Fields(Para.s_premium2);
        }
        public Field GetDisplay2Table(){
            return n_oTableSet.Fields(Para.display2);
        }
        public Field GetMidTable(){
            return n_oTableSet.Fields(Para.mid);
        }
        public Field GetDisplay1Table(){
            return n_oTableSet.Fields(Para.display1);
        }
        public Field GetCdateTable(){
            return n_oTableSet.Fields(Para.cdate);
        }
        public Field GetBundle_nameTable(){
            return n_oTableSet.Fields(Para.bundle_name);
        }
        public Field GetBusiness_action_value_1Table(){
            return n_oTableSet.Fields(Para.business_action_value_1);
        }
        public Field GetTrade_fieldTable(){
            return n_oTableSet.Fields(Para.trade_field);
        }
        public Field GetS_premiumTable(){
            return n_oTableSet.Fields(Para.s_premium);
        }
        public Field GetProgramTable(){
            return n_oTableSet.Fields(Para.program);
        }
        public Field GetEdateTable(){
            return n_oTableSet.Fields(Para.edate);
        }
        public Field GetRebateTable(){
            return n_oTableSet.Fields(Para.rebate);
        }
        public Field GetCon_perTable(){
            return n_oTableSet.Fields(Para.con_per);
        }
        public Field GetNormal_rebate_typeTable(){
            return n_oTableSet.Fields(Para.normal_rebate_type);
        }
        public Field GetPremiumTable(){
            return n_oTableSet.Fields(Para.premium);
        }
        public Field GetBusiness_action_value_2Table(){
            return n_oTableSet.Fields(Para.business_action_value_2);
        }
        public Field GetEnabled2Table(){
            return n_oTableSet.Fields(Para.enabled2);
        }
        public Field GetCidTable(){
            return n_oTableSet.Fields(Para.cid);
        }
        public Field GetBusiness_action_2Table(){
            return n_oTableSet.Fields(Para.business_action_2);
        }
        public Field GetBusiness_action_1Table(){
            return n_oTableSet.Fields(Para.business_action_1);
        }
        public Field GetRate_planTable(){
            return n_oTableSet.Fields(Para.rate_plan);
        }
        public Field GetFree_monTable(){
            return n_oTableSet.Fields(Para.free_mon);
        }
        public Field GetEnabled1Table(){
            return n_oTableSet.Fields(Para.enabled1);
        }
        public Field GetHs_modelTable(){
            return n_oTableSet.Fields(Para.hs_model);
        }
        public Field GetActiveTable(){
            return n_oTableSet.Fields(Para.active);
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
        
        public bool EqualID(BusinessActionDefaultSet x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iMid.Equals(x_oObj.mid)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(BusinessActionDefaultSet x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_sLob.Equals(x_oObj.lob)){ return false; }
            if(!this.n_bDisplay2.Equals(x_oObj.display2)){ return false; }
            if(!this.n_iMid.Equals(x_oObj.mid)){ return false; }
            if(!this.n_bDisplay1.Equals(x_oObj.display1)){ return false; }
            if(!this.n_dCdate.Equals(x_oObj.cdate)){ return false; }
            if(!this.n_sBundle_name.Equals(x_oObj.bundle_name)){ return false; }
            if(!this.n_sTrade_field.Equals(x_oObj.trade_field)){ return false; }
            if(!this.n_sS_premium.Equals(x_oObj.s_premium)){ return false; }
            if(!this.n_sProgram.Equals(x_oObj.program)){ return false; }
            if(!this.n_dEdate.Equals(x_oObj.edate)){ return false; }
            if(!this.n_sRebate.Equals(x_oObj.rebate)){ return false; }
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_sBusiness_action_value_2.Equals(x_oObj.business_action_value_2)){ return false; }
            if(!this.n_sCon_per.Equals(x_oObj.con_per)){ return false; }
            if(!this.n_sNormal_rebate_type.Equals(x_oObj.normal_rebate_type)){ return false; }
            if(!this.n_sPremium.Equals(x_oObj.premium)){ return false; }
            if(!this.n_sFree_mon.Equals(x_oObj.free_mon)){ return false; }
            if(!this.n_bEnabled2.Equals(x_oObj.enabled2)){ return false; }
            if(!this.n_sCid.Equals(x_oObj.cid)){ return false; }
            if(!this.n_sBusiness_action_2.Equals(x_oObj.business_action_2)){ return false; }
            if(!this.n_sBusiness_action_1.Equals(x_oObj.business_action_1)){ return false; }
            if(!this.n_sRate_plan.Equals(x_oObj.rate_plan)){ return false; }
            if(!this.n_sBusiness_action_value_1.Equals(x_oObj.business_action_value_1)){ return false; }
            if(!this.n_bEnabled1.Equals(x_oObj.enabled1)){ return false; }
            if(!this.n_sHs_model.Equals(x_oObj.hs_model)){ return false; }
            if(!this.n_sS_premium2.Equals(x_oObj.s_premium2)){ return false; }
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
            string _sQuery = "UPDATE  [BusinessActionDefaultSet]  SET  [lob]=@lob,[display2]=@display2,[display1]=@display1,[cdate]=@cdate,[bundle_name]=@bundle_name,[trade_field]=@trade_field,[s_premium]=@s_premium,[program]=@program,[edate]=@edate,[rebate]=@rebate,[active]=@active,[business_action_value_2]=@business_action_value_2,[con_per]=@con_per,[normal_rebate_type]=@normal_rebate_type,[premium]=@premium,[free_mon]=@free_mon,[enabled2]=@enabled2,[cid]=@cid,[business_action_2]=@business_action_2,[business_action_1]=@business_action_1,[rate_plan]=@rate_plan,[business_action_value_1]=@business_action_value_1,[enabled1]=@enabled1,[hs_model]=@hs_model,[s_premium2]=@s_premium2,[issue_type]=@issue_type  WHERE [BusinessActionDefaultSet].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessActionDefaultSet]","["+ Configurator.MSSQLTablePrefix + "BusinessActionDefaultSet]"); }
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
            if(n_sLob==null){  _oCmd.Parameters.Add("@lob", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@lob", global::System.Data.SqlDbType.NVarChar,50).Value=n_sLob; }
            if(n_bDisplay2==null){  _oCmd.Parameters.Add("@display2", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@display2", global::System.Data.SqlDbType.Bit).Value=n_bDisplay2; }
            if(n_iMid==null){  _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value=n_iMid; }
            if(n_bDisplay1==null){  _oCmd.Parameters.Add("@display1", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@display1", global::System.Data.SqlDbType.Bit).Value=n_bDisplay1; }
            if(n_dCdate==null){  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=n_dCdate; }
            if(n_sBundle_name==null){  _oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,50).Value=n_sBundle_name; }
            if(n_sTrade_field==null){  _oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,50).Value=n_sTrade_field; }
            if(n_sS_premium==null){  _oCmd.Parameters.Add("@s_premium", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@s_premium", global::System.Data.SqlDbType.NVarChar,100).Value=n_sS_premium; }
            if(n_sProgram==null){  _oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,250).Value=n_sProgram; }
            if(n_dEdate==null){  _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=n_dEdate; }
            if(n_sRebate==null){  _oCmd.Parameters.Add("@rebate", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@rebate", global::System.Data.SqlDbType.NVarChar,20).Value=n_sRebate; }
            if(n_bActive==null){  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=n_bActive; }
            if(n_sBusiness_action_value_2==null){  _oCmd.Parameters.Add("@business_action_value_2", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@business_action_value_2", global::System.Data.SqlDbType.NVarChar,250).Value=n_sBusiness_action_value_2; }
            if(n_sCon_per==null){  _oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,50).Value=n_sCon_per; }
            if(n_sNormal_rebate_type==null){  _oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value=n_sNormal_rebate_type; }
            if(n_sPremium==null){  _oCmd.Parameters.Add("@premium", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@premium", global::System.Data.SqlDbType.NVarChar,250).Value=n_sPremium; }
            if(n_sFree_mon==null){  _oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.NVarChar,30).Value=n_sFree_mon; }
            if(n_bEnabled2==null){  _oCmd.Parameters.Add("@enabled2", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@enabled2", global::System.Data.SqlDbType.Bit).Value=n_bEnabled2; }
            if(n_sCid==null){  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=n_sCid; }
            if(n_sBusiness_action_2==null){  _oCmd.Parameters.Add("@business_action_2", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@business_action_2", global::System.Data.SqlDbType.NVarChar,250).Value=n_sBusiness_action_2; }
            if(n_sBusiness_action_1==null){  _oCmd.Parameters.Add("@business_action_1", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@business_action_1", global::System.Data.SqlDbType.NVarChar,250).Value=n_sBusiness_action_1; }
            if(n_sRate_plan==null){  _oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,250).Value=n_sRate_plan; }
            if(n_sBusiness_action_value_1==null){  _oCmd.Parameters.Add("@business_action_value_1", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@business_action_value_1", global::System.Data.SqlDbType.NVarChar,250).Value=n_sBusiness_action_value_1; }
            if(n_bEnabled1==null){  _oCmd.Parameters.Add("@enabled1", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@enabled1", global::System.Data.SqlDbType.Bit).Value=n_bEnabled1; }
            if(n_sHs_model==null){  _oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value=n_sHs_model; }
            if(n_sS_premium2==null){  _oCmd.Parameters.Add("@s_premium2", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@s_premium2", global::System.Data.SqlDbType.NVarChar,100).Value=n_sS_premium2; }
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
        /// Summary description for table [BusinessActionDefaultSet] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iMid==null) { return false; }
            string _sQuery="DELETE FROM  [BusinessActionDefaultSet]  WHERE [BusinessActionDefaultSet].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessActionDefaultSet]","["+ Configurator.MSSQLTablePrefix + "BusinessActionDefaultSet]"); }
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
        /// Summary description for table [BusinessActionDefaultSet] Object Base Clone
        /// </summary>
        
        public BusinessActionDefaultSet DeepClone()
        {
            BusinessActionDefaultSet _oBusinessActionDefaultSet_Clone = new BusinessActionDefaultSet();
            _oBusinessActionDefaultSet_Clone.lob = this.n_sLob;
            _oBusinessActionDefaultSet_Clone.display2 = this.n_bDisplay2;
            _oBusinessActionDefaultSet_Clone.mid = this.n_iMid;
            _oBusinessActionDefaultSet_Clone.display1 = this.n_bDisplay1;
            _oBusinessActionDefaultSet_Clone.cdate = this.n_dCdate;
            _oBusinessActionDefaultSet_Clone.bundle_name = this.n_sBundle_name;
            _oBusinessActionDefaultSet_Clone.trade_field = this.n_sTrade_field;
            _oBusinessActionDefaultSet_Clone.s_premium = this.n_sS_premium;
            _oBusinessActionDefaultSet_Clone.program = this.n_sProgram;
            _oBusinessActionDefaultSet_Clone.edate = this.n_dEdate;
            _oBusinessActionDefaultSet_Clone.rebate = this.n_sRebate;
            _oBusinessActionDefaultSet_Clone.active = this.n_bActive;
            _oBusinessActionDefaultSet_Clone.business_action_value_2 = this.n_sBusiness_action_value_2;
            _oBusinessActionDefaultSet_Clone.con_per = this.n_sCon_per;
            _oBusinessActionDefaultSet_Clone.normal_rebate_type = this.n_sNormal_rebate_type;
            _oBusinessActionDefaultSet_Clone.premium = this.n_sPremium;
            _oBusinessActionDefaultSet_Clone.free_mon = this.n_sFree_mon;
            _oBusinessActionDefaultSet_Clone.enabled2 = this.n_bEnabled2;
            _oBusinessActionDefaultSet_Clone.cid = this.n_sCid;
            _oBusinessActionDefaultSet_Clone.business_action_2 = this.n_sBusiness_action_2;
            _oBusinessActionDefaultSet_Clone.business_action_1 = this.n_sBusiness_action_1;
            _oBusinessActionDefaultSet_Clone.rate_plan = this.n_sRate_plan;
            _oBusinessActionDefaultSet_Clone.business_action_value_1 = this.n_sBusiness_action_value_1;
            _oBusinessActionDefaultSet_Clone.enabled1 = this.n_bEnabled1;
            _oBusinessActionDefaultSet_Clone.hs_model = this.n_sHs_model;
            _oBusinessActionDefaultSet_Clone.s_premium2 = this.n_sS_premium2;
            _oBusinessActionDefaultSet_Clone.issue_type = this.n_sIssue_type;
            _oBusinessActionDefaultSet_Clone.SetFound(this.n_bFound);
            _oBusinessActionDefaultSet_Clone.SetDB(this.n_oDB);
            _oBusinessActionDefaultSet_Clone.SetRow(this.n_oRow);
            _oBusinessActionDefaultSet_Clone.SetTbl(this.n_oTbl);
            _oBusinessActionDefaultSet_Clone.SetTableSet(this.n_oTableSet);
            
            return _oBusinessActionDefaultSet_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_sLob=global::System.String.Empty;
            n_bDisplay2=null;
            n_iMid=null;
            n_bDisplay1=null;
            n_dCdate=null;
            n_sBundle_name=global::System.String.Empty;
            n_sTrade_field=global::System.String.Empty;
            n_sS_premium=global::System.String.Empty;
            n_sProgram=global::System.String.Empty;
            n_dEdate=null;
            n_sRebate=global::System.String.Empty;
            n_bActive=null;
            n_sBusiness_action_value_2=global::System.String.Empty;
            n_sCon_per=global::System.String.Empty;
            n_sNormal_rebate_type=global::System.String.Empty;
            n_sPremium=global::System.String.Empty;
            n_sFree_mon=global::System.String.Empty;
            n_bEnabled2=null;
            n_sCid=global::System.String.Empty;
            n_sBusiness_action_2=global::System.String.Empty;
            n_sBusiness_action_1=global::System.String.Empty;
            n_sRate_plan=global::System.String.Empty;
            n_sBusiness_action_value_1=global::System.String.Empty;
            n_bEnabled1=null;
            n_sHs_model=global::System.String.Empty;
            n_sS_premium2=global::System.String.Empty;
            n_sIssue_type=global::System.String.Empty;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = BusinessActionDefaultSetInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


