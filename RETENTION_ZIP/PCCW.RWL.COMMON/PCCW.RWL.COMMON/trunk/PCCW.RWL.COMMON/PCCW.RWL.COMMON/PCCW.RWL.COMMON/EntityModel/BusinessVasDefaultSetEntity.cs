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
///-- Create date: <Create Date 2011-07-15>
///-- Description:	<Description,Table :[BusinessVasDefaultSet],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [BusinessVasDefaultSet] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"BusinessVasDefaultSet")]
    public class BusinessVasDefaultSetEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        
        protected string n_sValue2=global::System.String.Empty;
        #region value2
        [System.Data.Linq.Mapping.Column(Name="[value2]", Storage="n_sValue2")]
        public string value2{
            get{
                return this.n_sValue2;
            }
            set{
                this.n_sValue2=value;
            }
        }
        #endregion value2
        
        
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
        
        
        protected string n_sValue1=global::System.String.Empty;
        #region value1
        [System.Data.Linq.Mapping.Column(Name="[value1]", Storage="n_sValue1")]
        public string value1{
            get{
                return this.n_sValue1;
            }
            set{
                this.n_sValue1=value;
            }
        }
        #endregion value1
        
        
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
        
        
        protected string n_sVas2=global::System.String.Empty;
        #region vas2
        [System.Data.Linq.Mapping.Column(Name="[vas2]", Storage="n_sVas2")]
        public string vas2{
            get{
                return this.n_sVas2;
            }
            set{
                this.n_sVas2=value;
            }
        }
        #endregion vas2
        
        
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
        
        
        protected string n_sVas1=global::System.String.Empty;
        #region vas1
        [System.Data.Linq.Mapping.Column(Name="[vas1]", Storage="n_sVas1")]
        public string vas1{
            get{
                return this.n_sVas1;
            }
            set{
                this.n_sVas1=value;
            }
        }
        #endregion vas1
        
        
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
        private BusinessVasDefaultSetInfo n_oTableSet = BusinessVasDefaultSetInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string display2="display2";
            public const string mid="mid";
            public const string cdate="cdate";
            public const string bundle_name="bundle_name";
            public const string value2="value2";
            public const string cid="cid";
            public const string value1="value1";
            public const string program="program";
            public const string edate="edate";
            public const string active="active";
            public const string trade_field="trade_field";
            public const string con_per="con_per";
            public const string display1="display1";
            public const string enabled2="enabled2";
            public const string vas2="vas2";
            public const string rate_plan="rate_plan";
            public const string enabled1="enabled1";
            public const string hs_model="hs_model";
            public const string vas1="vas1";
            public const string issue_type="issue_type";
            public const string BusinessVasDefaultSet_table_name="BusinessVasDefaultSet";
            public static string TableName() { return BusinessVasDefaultSet_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public BusinessVasDefaultSetEntity(){
            Init();
        }
        public BusinessVasDefaultSetEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public BusinessVasDefaultSetEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid){
            n_oDB=x_oDB;
            this.Load(x_iMid);
            Init();
        }
        
        ~BusinessVasDefaultSetEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iMid){
            if (n_oDB==null) { return false; }
            if (x_iMid==null) { return false; }
            string _sQuery = "SELECT   [BusinessVasDefaultSet].[display2] AS BUSINESSVASDEFAULTSET_DISPLAY2,[BusinessVasDefaultSet].[mid] AS BUSINESSVASDEFAULTSET_MID,[BusinessVasDefaultSet].[cdate] AS BUSINESSVASDEFAULTSET_CDATE,[BusinessVasDefaultSet].[cid] AS BUSINESSVASDEFAULTSET_CID,[BusinessVasDefaultSet].[bundle_name] AS BUSINESSVASDEFAULTSET_BUNDLE_NAME,[BusinessVasDefaultSet].[value2] AS BUSINESSVASDEFAULTSET_VALUE2,[BusinessVasDefaultSet].[trade_field] AS BUSINESSVASDEFAULTSET_TRADE_FIELD,[BusinessVasDefaultSet].[value1] AS BUSINESSVASDEFAULTSET_VALUE1,[BusinessVasDefaultSet].[program] AS BUSINESSVASDEFAULTSET_PROGRAM,[BusinessVasDefaultSet].[edate] AS BUSINESSVASDEFAULTSET_EDATE,[BusinessVasDefaultSet].[active] AS BUSINESSVASDEFAULTSET_ACTIVE,[BusinessVasDefaultSet].[con_per] AS BUSINESSVASDEFAULTSET_CON_PER,[BusinessVasDefaultSet].[display1] AS BUSINESSVASDEFAULTSET_DISPLAY1,[BusinessVasDefaultSet].[enabled2] AS BUSINESSVASDEFAULTSET_ENABLED2,[BusinessVasDefaultSet].[vas2] AS BUSINESSVASDEFAULTSET_VAS2,[BusinessVasDefaultSet].[rate_plan] AS BUSINESSVASDEFAULTSET_RATE_PLAN,[BusinessVasDefaultSet].[enabled1] AS BUSINESSVASDEFAULTSET_ENABLED1,[BusinessVasDefaultSet].[hs_model] AS BUSINESSVASDEFAULTSET_HS_MODEL,[BusinessVasDefaultSet].[vas1] AS BUSINESSVASDEFAULTSET_VAS1,[BusinessVasDefaultSet].[issue_type] AS BUSINESSVASDEFAULTSET_ISSUE_TYPE  FROM  [BusinessVasDefaultSet]  WHERE  [BusinessVasDefaultSet].[mid] = \'"+x_iMid.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVasDefaultSet]","["+ Configurator.MSSQLTablePrefix + "BusinessVasDefaultSet]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_DISPLAY2"])) {n_bDisplay2 = (global::System.Nullable<bool>)_oData["BUSINESSVASDEFAULTSET_DISPLAY2"];}else{n_bDisplay2=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_MID"])) {n_iMid = (global::System.Nullable<int>)_oData["BUSINESSVASDEFAULTSET_MID"];}else{n_iMid=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_CDATE"])) {n_dCdate = (global::System.Nullable<DateTime>)_oData["BUSINESSVASDEFAULTSET_CDATE"];}else{n_dCdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_CID"])) {n_sCid = (string)_oData["BUSINESSVASDEFAULTSET_CID"];}else{n_sCid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_BUNDLE_NAME"])) {n_sBundle_name = (string)_oData["BUSINESSVASDEFAULTSET_BUNDLE_NAME"];}else{n_sBundle_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_VALUE2"])) {n_sValue2 = (string)_oData["BUSINESSVASDEFAULTSET_VALUE2"];}else{n_sValue2=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_TRADE_FIELD"])) {n_sTrade_field = (string)_oData["BUSINESSVASDEFAULTSET_TRADE_FIELD"];}else{n_sTrade_field=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_VALUE1"])) {n_sValue1 = (string)_oData["BUSINESSVASDEFAULTSET_VALUE1"];}else{n_sValue1=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_PROGRAM"])) {n_sProgram = (string)_oData["BUSINESSVASDEFAULTSET_PROGRAM"];}else{n_sProgram=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_EDATE"])) {n_dEdate = (global::System.Nullable<DateTime>)_oData["BUSINESSVASDEFAULTSET_EDATE"];}else{n_dEdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["BUSINESSVASDEFAULTSET_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_CON_PER"])) {n_sCon_per = (string)_oData["BUSINESSVASDEFAULTSET_CON_PER"];}else{n_sCon_per=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_DISPLAY1"])) {n_bDisplay1 = (global::System.Nullable<bool>)_oData["BUSINESSVASDEFAULTSET_DISPLAY1"];}else{n_bDisplay1=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_ENABLED2"])) {n_bEnabled2 = (global::System.Nullable<bool>)_oData["BUSINESSVASDEFAULTSET_ENABLED2"];}else{n_bEnabled2=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_VAS2"])) {n_sVas2 = (string)_oData["BUSINESSVASDEFAULTSET_VAS2"];}else{n_sVas2=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_RATE_PLAN"])) {n_sRate_plan = (string)_oData["BUSINESSVASDEFAULTSET_RATE_PLAN"];}else{n_sRate_plan=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_ENABLED1"])) {n_bEnabled1 = (global::System.Nullable<bool>)_oData["BUSINESSVASDEFAULTSET_ENABLED1"];}else{n_bEnabled1=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_HS_MODEL"])) {n_sHs_model = (string)_oData["BUSINESSVASDEFAULTSET_HS_MODEL"];}else{n_sHs_model=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_VAS1"])) {n_sVas1 = (string)_oData["BUSINESSVASDEFAULTSET_VAS1"];}else{n_sVas1=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_ISSUE_TYPE"])) {n_sIssue_type = (string)_oData["BUSINESSVASDEFAULTSET_ISSUE_TYPE"];}else{n_sIssue_type=global::System.String.Empty;}
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
            if (n_bDisplay2==null && !(n_oTableSet.Fields(Para.display2).IsNullable)) return false;
            if(!x_bInsert){
                if (n_iMid==null && !(n_oTableSet.Fields(Para.mid).IsNullable)) return false;
            }
            if (n_dCdate==null && !(n_oTableSet.Fields(Para.cdate).IsNullable)) return false;
            if (n_sCid==null && !(n_oTableSet.Fields(Para.cid).IsNullable)) return false;
            if (n_sBundle_name==null && !(n_oTableSet.Fields(Para.bundle_name).IsNullable)) return false;
            if (n_sValue2==null && !(n_oTableSet.Fields(Para.value2).IsNullable)) return false;
            if (n_sTrade_field==null && !(n_oTableSet.Fields(Para.trade_field).IsNullable)) return false;
            if (n_sValue1==null && !(n_oTableSet.Fields(Para.value1).IsNullable)) return false;
            if (n_sProgram==null && !(n_oTableSet.Fields(Para.program).IsNullable)) return false;
            if (n_dEdate==null && !(n_oTableSet.Fields(Para.edate).IsNullable)) return false;
            if (n_bActive==null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_sCon_per==null && !(n_oTableSet.Fields(Para.con_per).IsNullable)) return false;
            if (n_bDisplay1==null && !(n_oTableSet.Fields(Para.display1).IsNullable)) return false;
            if (n_bEnabled2==null && !(n_oTableSet.Fields(Para.enabled2).IsNullable)) return false;
            if (n_sVas2==null && !(n_oTableSet.Fields(Para.vas2).IsNullable)) return false;
            if (n_sRate_plan==null && !(n_oTableSet.Fields(Para.rate_plan).IsNullable)) return false;
            if (n_bEnabled1==null && !(n_oTableSet.Fields(Para.enabled1).IsNullable)) return false;
            if (n_sHs_model==null && !(n_oTableSet.Fields(Para.hs_model).IsNullable)) return false;
            if (n_sVas1==null && !(n_oTableSet.Fields(Para.vas1).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(BusinessVasDefaultSetEntity)) || (x_oObj is BusinessVasDefaultSetEntity)) return BusinessVasDefaultSetRepository.Instance();
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
        public BusinessVasDefaultSetInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(BusinessVasDefaultSetInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public global::System.Nullable<bool> GetDisplay2(){return this.display2;}
        public global::System.Nullable<int> GetMid(){return this.mid;}
        public global::System.Nullable<DateTime> GetCdate(){return this.cdate;}
        public string GetBundle_name(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.bundle_name)) { return string.Empty; }
            return this.bundle_name;
        }
        public string GetValue2(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.value2)) { return string.Empty; }
            return this.value2;
        }
        public string GetCid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.cid)) { return string.Empty; }
            return this.cid;
        }
        public string GetValue1(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.value1)) { return string.Empty; }
            return this.value1;
        }
        public string GetProgram(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.program)) { return string.Empty; }
            return this.program;
        }
        public global::System.Nullable<DateTime> GetEdate(){return this.edate;}
        public global::System.Nullable<bool> GetActive(){return this.active;}
        public string GetTrade_field(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.trade_field)) { return string.Empty; }
            return this.trade_field;
        }
        public string GetCon_per(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.con_per)) { return string.Empty; }
            return this.con_per;
        }
        public global::System.Nullable<bool> GetDisplay1(){return this.display1;}
        public global::System.Nullable<bool> GetEnabled2(){return this.enabled2;}
        public string GetVas2(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.vas2)) { return string.Empty; }
            return this.vas2;
        }
        public string GetRate_plan(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.rate_plan)) { return string.Empty; }
            return this.rate_plan;
        }
        public global::System.Nullable<bool> GetEnabled1(){return this.enabled1;}
        public string GetHs_model(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.hs_model)) { return string.Empty; }
            return this.hs_model;
        }
        public string GetVas1(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.vas1)) { return string.Empty; }
            return this.vas1;
        }
        public string GetIssue_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.issue_type)) { return string.Empty; }
            return this.issue_type;
        }
        
        public bool SetDisplay2(global::System.Nullable<bool> value){
            this.display2=value;
            return true;
        }
        public bool SetMid(global::System.Nullable<int> value){
            this.mid=value;
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
        public bool SetValue2(string value){
            this.value2=value;
            return true;
        }
        public bool SetCid(string value){
            this.cid=value;
            return true;
        }
        public bool SetValue1(string value){
            this.value1=value;
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
        public bool SetActive(global::System.Nullable<bool> value){
            this.active=value;
            return true;
        }
        public bool SetTrade_field(string value){
            this.trade_field=value;
            return true;
        }
        public bool SetCon_per(string value){
            this.con_per=value;
            return true;
        }
        public bool SetDisplay1(global::System.Nullable<bool> value){
            this.display1=value;
            return true;
        }
        public bool SetEnabled2(global::System.Nullable<bool> value){
            this.enabled2=value;
            return true;
        }
        public bool SetVas2(string value){
            this.vas2=value;
            return true;
        }
        public bool SetRate_plan(string value){
            this.rate_plan=value;
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
        public bool SetVas1(string value){
            this.vas1=value;
            return true;
        }
        public bool SetIssue_type(string value){
            this.issue_type=value;
            return true;
        }
        
        public Field GetDisplay2Table(){
            return n_oTableSet.Fields(Para.display2);
        }
        public Field GetMidTable(){
            return n_oTableSet.Fields(Para.mid);
        }
        public Field GetCdateTable(){
            return n_oTableSet.Fields(Para.cdate);
        }
        public Field GetBundle_nameTable(){
            return n_oTableSet.Fields(Para.bundle_name);
        }
        public Field GetValue2Table(){
            return n_oTableSet.Fields(Para.value2);
        }
        public Field GetCidTable(){
            return n_oTableSet.Fields(Para.cid);
        }
        public Field GetValue1Table(){
            return n_oTableSet.Fields(Para.value1);
        }
        public Field GetProgramTable(){
            return n_oTableSet.Fields(Para.program);
        }
        public Field GetEdateTable(){
            return n_oTableSet.Fields(Para.edate);
        }
        public Field GetActiveTable(){
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetTrade_fieldTable(){
            return n_oTableSet.Fields(Para.trade_field);
        }
        public Field GetCon_perTable(){
            return n_oTableSet.Fields(Para.con_per);
        }
        public Field GetDisplay1Table(){
            return n_oTableSet.Fields(Para.display1);
        }
        public Field GetEnabled2Table(){
            return n_oTableSet.Fields(Para.enabled2);
        }
        public Field GetVas2Table(){
            return n_oTableSet.Fields(Para.vas2);
        }
        public Field GetRate_planTable(){
            return n_oTableSet.Fields(Para.rate_plan);
        }
        public Field GetEnabled1Table(){
            return n_oTableSet.Fields(Para.enabled1);
        }
        public Field GetHs_modelTable(){
            return n_oTableSet.Fields(Para.hs_model);
        }
        public Field GetVas1Table(){
            return n_oTableSet.Fields(Para.vas1);
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
        
        public bool EqualID(BusinessVasDefaultSet x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iMid.Equals(x_oObj.mid)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(BusinessVasDefaultSet x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_bDisplay2.Equals(x_oObj.display2)){ return false; }
            if(!this.n_iMid.Equals(x_oObj.mid)){ return false; }
            if(!this.n_dCdate.Equals(x_oObj.cdate)){ return false; }
            if(!this.n_sCid.Equals(x_oObj.cid)){ return false; }
            if(!this.n_sBundle_name.Equals(x_oObj.bundle_name)){ return false; }
            if(!this.n_sValue2.Equals(x_oObj.value2)){ return false; }
            if(!this.n_sTrade_field.Equals(x_oObj.trade_field)){ return false; }
            if(!this.n_sValue1.Equals(x_oObj.value1)){ return false; }
            if(!this.n_sProgram.Equals(x_oObj.program)){ return false; }
            if(!this.n_dEdate.Equals(x_oObj.edate)){ return false; }
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_sCon_per.Equals(x_oObj.con_per)){ return false; }
            if(!this.n_bDisplay1.Equals(x_oObj.display1)){ return false; }
            if(!this.n_bEnabled2.Equals(x_oObj.enabled2)){ return false; }
            if(!this.n_sVas2.Equals(x_oObj.vas2)){ return false; }
            if(!this.n_sRate_plan.Equals(x_oObj.rate_plan)){ return false; }
            if(!this.n_bEnabled1.Equals(x_oObj.enabled1)){ return false; }
            if(!this.n_sHs_model.Equals(x_oObj.hs_model)){ return false; }
            if(!this.n_sVas1.Equals(x_oObj.vas1)){ return false; }
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
            string _sQuery = "UPDATE  [BusinessVasDefaultSet]  SET  [display2]=@display2,[cdate]=@cdate,[cid]=@cid,[bundle_name]=@bundle_name,[value2]=@value2,[trade_field]=@trade_field,[value1]=@value1,[program]=@program,[edate]=@edate,[active]=@active,[con_per]=@con_per,[display1]=@display1,[enabled2]=@enabled2,[vas2]=@vas2,[rate_plan]=@rate_plan,[enabled1]=@enabled1,[hs_model]=@hs_model,[vas1]=@vas1,[issue_type]=@issue_type  WHERE [BusinessVasDefaultSet].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVasDefaultSet]","["+ Configurator.MSSQLTablePrefix + "BusinessVasDefaultSet]"); }
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
            if(n_bDisplay2==null){  _oCmd.Parameters.Add("@display2", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@display2", global::System.Data.SqlDbType.Bit).Value=n_bDisplay2; }
            if(n_iMid==null){  _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value=n_iMid; }
            if(n_dCdate==null){  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=n_dCdate; }
            if(n_sCid==null){  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=n_sCid; }
            if(n_sBundle_name==null){  _oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,250).Value=n_sBundle_name; }
            if(n_sValue2==null){  _oCmd.Parameters.Add("@value2", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@value2", global::System.Data.SqlDbType.NVarChar,250).Value=n_sValue2; }
            if(n_sTrade_field==null){  _oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,250).Value=n_sTrade_field; }
            if(n_sValue1==null){  _oCmd.Parameters.Add("@value1", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@value1", global::System.Data.SqlDbType.NVarChar,250).Value=n_sValue1; }
            if(n_sProgram==null){  _oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,250).Value=n_sProgram; }
            if(n_dEdate==null){  _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=n_dEdate; }
            if(n_bActive==null){  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=n_bActive; }
            if(n_sCon_per==null){  _oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,250).Value=n_sCon_per; }
            if(n_bDisplay1==null){  _oCmd.Parameters.Add("@display1", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@display1", global::System.Data.SqlDbType.Bit).Value=n_bDisplay1; }
            if(n_bEnabled2==null){  _oCmd.Parameters.Add("@enabled2", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@enabled2", global::System.Data.SqlDbType.Bit).Value=n_bEnabled2; }
            if(n_sVas2==null){  _oCmd.Parameters.Add("@vas2", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@vas2", global::System.Data.SqlDbType.NVarChar,250).Value=n_sVas2; }
            if(n_sRate_plan==null){  _oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,250).Value=n_sRate_plan; }
            if(n_bEnabled1==null){  _oCmd.Parameters.Add("@enabled1", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@enabled1", global::System.Data.SqlDbType.Bit).Value=n_bEnabled1; }
            if(n_sHs_model==null){  _oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value=n_sHs_model; }
            if(n_sVas1==null){  _oCmd.Parameters.Add("@vas1", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@vas1", global::System.Data.SqlDbType.NVarChar,250).Value=n_sVas1; }
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
        /// Summary description for table [BusinessVasDefaultSet] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iMid==null) { return false; }
            string _sQuery="DELETE FROM  [BusinessVasDefaultSet]  WHERE [BusinessVasDefaultSet].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVasDefaultSet]","["+ Configurator.MSSQLTablePrefix + "BusinessVasDefaultSet]"); }
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
        /// Summary description for table [BusinessVasDefaultSet] Object Base Clone
        /// </summary>
        
        public BusinessVasDefaultSet DeepClone()
        {
            BusinessVasDefaultSet _oBusinessVasDefaultSet_Clone = new BusinessVasDefaultSet();
            _oBusinessVasDefaultSet_Clone.display2 = this.n_bDisplay2;
            _oBusinessVasDefaultSet_Clone.mid = this.n_iMid;
            _oBusinessVasDefaultSet_Clone.cdate = this.n_dCdate;
            _oBusinessVasDefaultSet_Clone.cid = this.n_sCid;
            _oBusinessVasDefaultSet_Clone.bundle_name = this.n_sBundle_name;
            _oBusinessVasDefaultSet_Clone.value2 = this.n_sValue2;
            _oBusinessVasDefaultSet_Clone.trade_field = this.n_sTrade_field;
            _oBusinessVasDefaultSet_Clone.value1 = this.n_sValue1;
            _oBusinessVasDefaultSet_Clone.program = this.n_sProgram;
            _oBusinessVasDefaultSet_Clone.edate = this.n_dEdate;
            _oBusinessVasDefaultSet_Clone.active = this.n_bActive;
            _oBusinessVasDefaultSet_Clone.con_per = this.n_sCon_per;
            _oBusinessVasDefaultSet_Clone.display1 = this.n_bDisplay1;
            _oBusinessVasDefaultSet_Clone.enabled2 = this.n_bEnabled2;
            _oBusinessVasDefaultSet_Clone.vas2 = this.n_sVas2;
            _oBusinessVasDefaultSet_Clone.rate_plan = this.n_sRate_plan;
            _oBusinessVasDefaultSet_Clone.enabled1 = this.n_bEnabled1;
            _oBusinessVasDefaultSet_Clone.hs_model = this.n_sHs_model;
            _oBusinessVasDefaultSet_Clone.vas1 = this.n_sVas1;
            _oBusinessVasDefaultSet_Clone.issue_type = this.n_sIssue_type;
            _oBusinessVasDefaultSet_Clone.SetFound(this.n_bFound);
            _oBusinessVasDefaultSet_Clone.SetDB(this.n_oDB);
            _oBusinessVasDefaultSet_Clone.SetRow(this.n_oRow);
            _oBusinessVasDefaultSet_Clone.SetTbl(this.n_oTbl);
            _oBusinessVasDefaultSet_Clone.SetTableSet(this.n_oTableSet);
            
            return _oBusinessVasDefaultSet_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_bDisplay2=null;
            n_iMid=null;
            n_dCdate=null;
            n_sCid=global::System.String.Empty;
            n_sBundle_name=global::System.String.Empty;
            n_sValue2=global::System.String.Empty;
            n_sTrade_field=global::System.String.Empty;
            n_sValue1=global::System.String.Empty;
            n_sProgram=global::System.String.Empty;
            n_dEdate=null;
            n_bActive=null;
            n_sCon_per=global::System.String.Empty;
            n_bDisplay1=null;
            n_bEnabled2=null;
            n_sVas2=global::System.String.Empty;
            n_sRate_plan=global::System.String.Empty;
            n_bEnabled1=null;
            n_sHs_model=global::System.String.Empty;
            n_sVas1=global::System.String.Empty;
            n_sIssue_type=global::System.String.Empty;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = BusinessVasDefaultSetInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


