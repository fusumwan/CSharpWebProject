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
///-- Create date: <Create Date 2011-07-14>
///-- Description:	<Description,Table :[BundleMapping],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [BundleMapping] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"BundleMapping")]
    public class BundleMappingEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        
        protected global::System.Nullable<int> n_iRetention_rebate=null;
        #region retention_rebate
        [System.Data.Linq.Mapping.Column(Name="[retention_rebate]", Storage="n_iRetention_rebate")]
        public global::System.Nullable<int> retention_rebate{
            get{
                return this.n_iRetention_rebate;
            }
            set{
                this.n_iRetention_rebate=value;
            }
        }
        #endregion retention_rebate
        
        
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
        
        
        protected global::System.Nullable<int> n_iId=null;
        #region id
        [System.Data.Linq.Mapping.Column(Name="[id]", Storage="n_iId")]
        public global::System.Nullable<int> id{
            get{
                return this.n_iId;
            }
            set{
                this.n_iId=value;
            }
        }
        #endregion id
        
        
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
        
        
        protected global::System.Nullable<int> n_iNormal_rebate=null;
        #region normal_rebate
        [System.Data.Linq.Mapping.Column(Name="[normal_rebate]", Storage="n_iNormal_rebate")]
        public global::System.Nullable<int> normal_rebate{
            get{
                return this.n_iNormal_rebate;
            }
            set{
                this.n_iNormal_rebate=value;
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
        
        
        protected string n_sVas_field=global::System.String.Empty;
        #region vas_field
        [System.Data.Linq.Mapping.Column(Name="[vas_field]", Storage="n_sVas_field")]
        public string vas_field{
            get{
                return this.n_sVas_field;
            }
            set{
                this.n_sVas_field=value;
            }
        }
        #endregion vas_field
        
        
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
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private BundleMappingInfo n_oTableSet = BundleMappingInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string program="program";
            public const string cdate="cdate";
            public const string bundle_name="bundle_name";
            public const string cid="cid";
            public const string did="did";
            public const string retention_rebate="retention_rebate";
            public const string edate="edate";
            public const string active="active";
            public const string normal_rebate="normal_rebate";
            public const string ddate="ddate";
            public const string normal_rebate_type="normal_rebate_type";
            public const string id="id";
            public const string sdate="sdate";
            public const string rate_plan="rate_plan";
            public const string vas_field="vas_field";
            public const string hs_model="hs_model";
            public const string issue_type="issue_type";
            public const string BundleMapping_table_name="BundleMapping";
            public static string TableName() { return BundleMapping_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public BundleMappingEntity(){
            Init();
        }
        public BundleMappingEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public BundleMappingEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId){
            n_oDB=x_oDB;
            this.Load(x_iId);
            Init();
        }
        
        ~BundleMappingEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iId){
            if (n_oDB==null) { return false; }
            if (x_iId==null) { return false; }
            string _sQuery = "SELECT   [BundleMapping].[program] AS BUNDLEMAPPING_PROGRAM,[BundleMapping].[cdate] AS BUNDLEMAPPING_CDATE,[BundleMapping].[bundle_name] AS BUNDLEMAPPING_BUNDLE_NAME,[BundleMapping].[cid] AS BUNDLEMAPPING_CID,[BundleMapping].[did] AS BUNDLEMAPPING_DID,[BundleMapping].[retention_rebate] AS BUNDLEMAPPING_RETENTION_REBATE,[BundleMapping].[edate] AS BUNDLEMAPPING_EDATE,[BundleMapping].[active] AS BUNDLEMAPPING_ACTIVE,[BundleMapping].[issue_type] AS BUNDLEMAPPING_ISSUE_TYPE,[BundleMapping].[ddate] AS BUNDLEMAPPING_DDATE,[BundleMapping].[normal_rebate_type] AS BUNDLEMAPPING_NORMAL_REBATE_TYPE,[BundleMapping].[id] AS BUNDLEMAPPING_ID,[BundleMapping].[rate_plan] AS BUNDLEMAPPING_RATE_PLAN,[BundleMapping].[normal_rebate] AS BUNDLEMAPPING_NORMAL_REBATE,[BundleMapping].[hs_model] AS BUNDLEMAPPING_HS_MODEL,[BundleMapping].[vas_field] AS BUNDLEMAPPING_VAS_FIELD,[BundleMapping].[sdate] AS BUNDLEMAPPING_SDATE  FROM  [BundleMapping]  WHERE  [BundleMapping].[id] = \'"+x_iId.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BundleMapping]","["+ Configurator.MSSQLTablePrefix + "BundleMapping]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_PROGRAM"])) {n_sProgram = (string)_oData["BUNDLEMAPPING_PROGRAM"];}else{n_sProgram=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_CDATE"])) {n_dCdate = (global::System.Nullable<DateTime>)_oData["BUNDLEMAPPING_CDATE"];}else{n_dCdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_BUNDLE_NAME"])) {n_sBundle_name = (string)_oData["BUNDLEMAPPING_BUNDLE_NAME"];}else{n_sBundle_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_CID"])) {n_sCid = (string)_oData["BUNDLEMAPPING_CID"];}else{n_sCid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_DID"])) {n_sDid = (string)_oData["BUNDLEMAPPING_DID"];}else{n_sDid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_RETENTION_REBATE"])) {n_iRetention_rebate = (global::System.Nullable<int>)_oData["BUNDLEMAPPING_RETENTION_REBATE"];}else{n_iRetention_rebate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_EDATE"])) {n_dEdate = (global::System.Nullable<DateTime>)_oData["BUNDLEMAPPING_EDATE"];}else{n_dEdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["BUNDLEMAPPING_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_ISSUE_TYPE"])) {n_sIssue_type = (string)_oData["BUNDLEMAPPING_ISSUE_TYPE"];}else{n_sIssue_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_DDATE"])) {n_dDdate = (global::System.Nullable<DateTime>)_oData["BUNDLEMAPPING_DDATE"];}else{n_dDdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_NORMAL_REBATE_TYPE"])) {n_sNormal_rebate_type = (string)_oData["BUNDLEMAPPING_NORMAL_REBATE_TYPE"];}else{n_sNormal_rebate_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_ID"])) {n_iId = (global::System.Nullable<int>)_oData["BUNDLEMAPPING_ID"];}else{n_iId=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_RATE_PLAN"])) {n_sRate_plan = (string)_oData["BUNDLEMAPPING_RATE_PLAN"];}else{n_sRate_plan=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_NORMAL_REBATE"])) {n_iNormal_rebate = (global::System.Nullable<int>)_oData["BUNDLEMAPPING_NORMAL_REBATE"];}else{n_iNormal_rebate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_HS_MODEL"])) {n_sHs_model = (string)_oData["BUNDLEMAPPING_HS_MODEL"];}else{n_sHs_model=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_VAS_FIELD"])) {n_sVas_field = (string)_oData["BUNDLEMAPPING_VAS_FIELD"];}else{n_sVas_field=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_SDATE"])) {n_dSdate = (global::System.Nullable<DateTime>)_oData["BUNDLEMAPPING_SDATE"];}else{n_dSdate=null;}
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
            if (n_sProgram==null && !(n_oTableSet.Fields(Para.program).IsNullable)) return false;
            if (n_dCdate==null && !(n_oTableSet.Fields(Para.cdate).IsNullable)) return false;
            if (n_sBundle_name==null && !(n_oTableSet.Fields(Para.bundle_name).IsNullable)) return false;
            if (n_sCid==null && !(n_oTableSet.Fields(Para.cid).IsNullable)) return false;
            if (n_sDid==null && !(n_oTableSet.Fields(Para.did).IsNullable)) return false;
            if (n_iRetention_rebate==null && !(n_oTableSet.Fields(Para.retention_rebate).IsNullable)) return false;
            if (n_dEdate==null && !(n_oTableSet.Fields(Para.edate).IsNullable)) return false;
            if (n_bActive==null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_sIssue_type==null && !(n_oTableSet.Fields(Para.issue_type).IsNullable)) return false;
            if (n_dDdate==null && !(n_oTableSet.Fields(Para.ddate).IsNullable)) return false;
            if (n_sNormal_rebate_type==null && !(n_oTableSet.Fields(Para.normal_rebate_type).IsNullable)) return false;
            if(!x_bInsert){
                if (n_iId==null && !(n_oTableSet.Fields(Para.id).IsNullable)) return false;
            }
            if (n_sRate_plan==null && !(n_oTableSet.Fields(Para.rate_plan).IsNullable)) return false;
            if (n_iNormal_rebate==null && !(n_oTableSet.Fields(Para.normal_rebate).IsNullable)) return false;
            if (n_sHs_model==null && !(n_oTableSet.Fields(Para.hs_model).IsNullable)) return false;
            if (n_sVas_field==null && !(n_oTableSet.Fields(Para.vas_field).IsNullable)) return false;
            if (n_dSdate==null && !(n_oTableSet.Fields(Para.sdate).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(BundleMappingEntity)) || (x_oObj is BundleMappingEntity)) return BundleMappingRepository.Instance();
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
        public BundleMappingInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(BundleMappingInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public string GetProgram(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.program)) { return string.Empty; }
            return this.program;
        }
        public global::System.Nullable<DateTime> GetCdate(){return this.cdate;}
        public string GetBundle_name(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.bundle_name)) { return string.Empty; }
            return this.bundle_name;
        }
        public string GetCid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.cid)) { return string.Empty; }
            return this.cid;
        }
        public string GetDid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.did)) { return string.Empty; }
            return this.did;
        }
        public global::System.Nullable<int> GetRetention_rebate(){return this.retention_rebate;}
        public global::System.Nullable<DateTime> GetEdate(){return this.edate;}
        public global::System.Nullable<bool> GetActive(){return this.active;}
        public global::System.Nullable<int> GetNormal_rebate(){return this.normal_rebate;}
        public global::System.Nullable<DateTime> GetDdate(){return this.ddate;}
        public string GetNormal_rebate_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.normal_rebate_type)) { return string.Empty; }
            return this.normal_rebate_type;
        }
        public global::System.Nullable<int> GetId(){return this.id;}
        public global::System.Nullable<DateTime> GetSdate(){return this.sdate;}
        public string GetRate_plan(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.rate_plan)) { return string.Empty; }
            return this.rate_plan;
        }
        public string GetVas_field(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.vas_field)) { return string.Empty; }
            return this.vas_field;
        }
        public string GetHs_model(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.hs_model)) { return string.Empty; }
            return this.hs_model;
        }
        public string GetIssue_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.issue_type)) { return string.Empty; }
            return this.issue_type;
        }
        
        public bool SetProgram(string value){
            this.program=value;
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
        public bool SetCid(string value){
            this.cid=value;
            return true;
        }
        public bool SetDid(string value){
            this.did=value;
            return true;
        }
        public bool SetRetention_rebate(global::System.Nullable<int> value){
            this.retention_rebate=value;
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
        public bool SetNormal_rebate(global::System.Nullable<int> value){
            this.normal_rebate=value;
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
        public bool SetId(global::System.Nullable<int> value){
            this.id=value;
            return true;
        }
        public bool SetSdate(global::System.Nullable<DateTime> value){
            this.sdate=value;
            return true;
        }
        public bool SetRate_plan(string value){
            this.rate_plan=value;
            return true;
        }
        public bool SetVas_field(string value){
            this.vas_field=value;
            return true;
        }
        public bool SetHs_model(string value){
            this.hs_model=value;
            return true;
        }
        public bool SetIssue_type(string value){
            this.issue_type=value;
            return true;
        }
        
        public Field GetProgramTable(){
            return n_oTableSet.Fields(Para.program);
        }
        public Field GetCdateTable(){
            return n_oTableSet.Fields(Para.cdate);
        }
        public Field GetBundle_nameTable(){
            return n_oTableSet.Fields(Para.bundle_name);
        }
        public Field GetCidTable(){
            return n_oTableSet.Fields(Para.cid);
        }
        public Field GetDidTable(){
            return n_oTableSet.Fields(Para.did);
        }
        public Field GetRetention_rebateTable(){
            return n_oTableSet.Fields(Para.retention_rebate);
        }
        public Field GetEdateTable(){
            return n_oTableSet.Fields(Para.edate);
        }
        public Field GetActiveTable(){
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetNormal_rebateTable(){
            return n_oTableSet.Fields(Para.normal_rebate);
        }
        public Field GetDdateTable(){
            return n_oTableSet.Fields(Para.ddate);
        }
        public Field GetNormal_rebate_typeTable(){
            return n_oTableSet.Fields(Para.normal_rebate_type);
        }
        public Field GetIdTable(){
            return n_oTableSet.Fields(Para.id);
        }
        public Field GetSdateTable(){
            return n_oTableSet.Fields(Para.sdate);
        }
        public Field GetRate_planTable(){
            return n_oTableSet.Fields(Para.rate_plan);
        }
        public Field GetVas_fieldTable(){
            return n_oTableSet.Fields(Para.vas_field);
        }
        public Field GetHs_modelTable(){
            return n_oTableSet.Fields(Para.hs_model);
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
        
        public bool EqualID(BundleMapping x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(BundleMapping x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_sProgram.Equals(x_oObj.program)){ return false; }
            if(!this.n_dCdate.Equals(x_oObj.cdate)){ return false; }
            if(!this.n_sBundle_name.Equals(x_oObj.bundle_name)){ return false; }
            if(!this.n_sCid.Equals(x_oObj.cid)){ return false; }
            if(!this.n_sDid.Equals(x_oObj.did)){ return false; }
            if(!this.n_iRetention_rebate.Equals(x_oObj.retention_rebate)){ return false; }
            if(!this.n_dEdate.Equals(x_oObj.edate)){ return false; }
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_sIssue_type.Equals(x_oObj.issue_type)){ return false; }
            if(!this.n_dDdate.Equals(x_oObj.ddate)){ return false; }
            if(!this.n_sNormal_rebate_type.Equals(x_oObj.normal_rebate_type)){ return false; }
            if(!this.n_iId.Equals(x_oObj.id)){ return false; }
            if(!this.n_sRate_plan.Equals(x_oObj.rate_plan)){ return false; }
            if(!this.n_iNormal_rebate.Equals(x_oObj.normal_rebate)){ return false; }
            if(!this.n_sHs_model.Equals(x_oObj.hs_model)){ return false; }
            if(!this.n_sVas_field.Equals(x_oObj.vas_field)){ return false; }
            if(!this.n_dSdate.Equals(x_oObj.sdate)){ return false; }
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
            string _sQuery = "UPDATE  [BundleMapping]  SET  [program]=@program,[cdate]=@cdate,[bundle_name]=@bundle_name,[cid]=@cid,[did]=@did,[retention_rebate]=@retention_rebate,[edate]=@edate,[active]=@active,[issue_type]=@issue_type,[ddate]=@ddate,[normal_rebate_type]=@normal_rebate_type,[rate_plan]=@rate_plan,[normal_rebate]=@normal_rebate,[hs_model]=@hs_model,[vas_field]=@vas_field,[sdate]=@sdate  WHERE [BundleMapping].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BundleMapping]","["+ Configurator.MSSQLTablePrefix + "BundleMapping]"); }
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
            if(n_sProgram==null){  _oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value=n_sProgram; }
            if(n_dCdate==null){  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=n_dCdate; }
            if(n_sBundle_name==null){  _oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,70).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,70).Value=n_sBundle_name; }
            if(n_sCid==null){  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,20).Value=n_sCid; }
            if(n_sDid==null){  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,20).Value=n_sDid; }
            if(n_iRetention_rebate==null){  _oCmd.Parameters.Add("@retention_rebate", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@retention_rebate", global::System.Data.SqlDbType.Int).Value=n_iRetention_rebate; }
            if(n_dEdate==null){  _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=n_dEdate; }
            if(n_bActive==null){  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=n_bActive; }
            if(n_sIssue_type==null){  _oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value=n_sIssue_type; }
            if(n_dDdate==null){  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=n_dDdate; }
            if(n_sNormal_rebate_type==null){  _oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value=n_sNormal_rebate_type; }
            if(n_iId==null){  _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value=n_iId; }
            if(n_sRate_plan==null){  _oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,40).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,40).Value=n_sRate_plan; }
            if(n_iNormal_rebate==null){  _oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Int).Value=n_iNormal_rebate; }
            if(n_sHs_model==null){  _oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value=n_sHs_model; }
            if(n_sVas_field==null){  _oCmd.Parameters.Add("@vas_field", global::System.Data.SqlDbType.NVarChar,40).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@vas_field", global::System.Data.SqlDbType.NVarChar,40).Value=n_sVas_field; }
            if(n_dSdate==null){  _oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value=n_dSdate; }
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
        /// Summary description for table [BundleMapping] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iId==null) { return false; }
            string _sQuery="DELETE FROM  [BundleMapping]  WHERE [BundleMapping].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BundleMapping]","["+ Configurator.MSSQLTablePrefix + "BundleMapping]"); }
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
            _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = n_iId;
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
        /// Summary description for table [BundleMapping] Object Base Clone
        /// </summary>
        
        public BundleMapping DeepClone()
        {
            BundleMapping _oBundleMapping_Clone = new BundleMapping();
            _oBundleMapping_Clone.program = this.n_sProgram;
            _oBundleMapping_Clone.cdate = this.n_dCdate;
            _oBundleMapping_Clone.bundle_name = this.n_sBundle_name;
            _oBundleMapping_Clone.cid = this.n_sCid;
            _oBundleMapping_Clone.did = this.n_sDid;
            _oBundleMapping_Clone.retention_rebate = this.n_iRetention_rebate;
            _oBundleMapping_Clone.edate = this.n_dEdate;
            _oBundleMapping_Clone.active = this.n_bActive;
            _oBundleMapping_Clone.issue_type = this.n_sIssue_type;
            _oBundleMapping_Clone.ddate = this.n_dDdate;
            _oBundleMapping_Clone.normal_rebate_type = this.n_sNormal_rebate_type;
            _oBundleMapping_Clone.id = this.n_iId;
            _oBundleMapping_Clone.rate_plan = this.n_sRate_plan;
            _oBundleMapping_Clone.normal_rebate = this.n_iNormal_rebate;
            _oBundleMapping_Clone.hs_model = this.n_sHs_model;
            _oBundleMapping_Clone.vas_field = this.n_sVas_field;
            _oBundleMapping_Clone.sdate = this.n_dSdate;
            _oBundleMapping_Clone.SetFound(this.n_bFound);
            _oBundleMapping_Clone.SetDB(this.n_oDB);
            _oBundleMapping_Clone.SetRow(this.n_oRow);
            _oBundleMapping_Clone.SetTbl(this.n_oTbl);
            _oBundleMapping_Clone.SetTableSet(this.n_oTableSet);
            
            return _oBundleMapping_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_sProgram=global::System.String.Empty;
            n_dCdate=null;
            n_sBundle_name=global::System.String.Empty;
            n_sCid=global::System.String.Empty;
            n_sDid=global::System.String.Empty;
            n_iRetention_rebate=null;
            n_dEdate=null;
            n_bActive=null;
            n_sIssue_type=global::System.String.Empty;
            n_dDdate=null;
            n_sNormal_rebate_type=global::System.String.Empty;
            n_iId=null;
            n_sRate_plan=global::System.String.Empty;
            n_iNormal_rebate=null;
            n_sHs_model=global::System.String.Empty;
            n_sVas_field=global::System.String.Empty;
            n_dSdate=null;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = BundleMappingInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


