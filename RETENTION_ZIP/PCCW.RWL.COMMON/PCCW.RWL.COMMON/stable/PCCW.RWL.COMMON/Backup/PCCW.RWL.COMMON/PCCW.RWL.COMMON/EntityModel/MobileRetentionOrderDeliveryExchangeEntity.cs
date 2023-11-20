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
///-- Create date: <Create Date 2011-02-16>
///-- Description:	<Description,Table :[MobileRetentionOrderDeliveryExchange],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [MobileRetentionOrderDeliveryExchange] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"MobileRetentionOrderDeliveryExchange")]
    public class MobileRetentionOrderDeliveryExchangeEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private MobileRetentionOrderDeliveryExchangeInfo n_oTableSet = MobileRetentionOrderDeliveryExchangeInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string rate_plan="rate_plan";
            public const string cdate="cdate";
            public const string cid="cid";
            public const string did="did";
            public const string con_per="con_per";
            public const string id="id";
            public const string active="active";
            public const string hs_model="hs_model";
            public const string program="program";
            public const string normal_rebate_type="normal_rebate_type";
            public const string ddate="ddate";
            public const string MobileRetentionOrderDeliveryExchange_table_name="MobileRetentionOrderDeliveryExchange";
            public static string TableName() { return MobileRetentionOrderDeliveryExchange_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public MobileRetentionOrderDeliveryExchangeEntity(){
            Init();
        }
        public MobileRetentionOrderDeliveryExchangeEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public MobileRetentionOrderDeliveryExchangeEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId){
            n_oDB=x_oDB;
            this.Load(x_iId);
            Init();
        }
        
        ~MobileRetentionOrderDeliveryExchangeEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iId){
            if (n_oDB==null) { return false; }
            if (x_iId==null) { return false; }
            string _sQuery = "SELECT   [MobileRetentionOrderDeliveryExchange].[id] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_ID,[MobileRetentionOrderDeliveryExchange].[cdate] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_CDATE,[MobileRetentionOrderDeliveryExchange].[cid] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_CID,[MobileRetentionOrderDeliveryExchange].[did] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_DID,[MobileRetentionOrderDeliveryExchange].[active] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_ACTIVE,[MobileRetentionOrderDeliveryExchange].[rate_plan] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_RATE_PLAN,[MobileRetentionOrderDeliveryExchange].[program] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_PROGRAM,[MobileRetentionOrderDeliveryExchange].[hs_model] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_HS_MODEL,[MobileRetentionOrderDeliveryExchange].[normal_rebate_type] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_NORMAL_REBATE_TYPE,[MobileRetentionOrderDeliveryExchange].[ddate] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_DDATE,[MobileRetentionOrderDeliveryExchange].[con_per] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_CON_PER  FROM  [MobileRetentionOrderDeliveryExchange]  WHERE  [MobileRetentionOrderDeliveryExchange].[id] = \'"+x_iId.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionOrderDeliveryExchange]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrderDeliveryExchange]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_ID"])) {n_iId = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_ID"];}else{n_iId=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_CDATE"])) {n_dCdate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_CDATE"];}else{n_dCdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_CID"])) {n_sCid = (string)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_CID"];}else{n_sCid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_DID"])) {n_sDid = (string)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_DID"];}else{n_sDid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_RATE_PLAN"])) {n_sRate_plan = (string)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_RATE_PLAN"];}else{n_sRate_plan=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_PROGRAM"])) {n_sProgram = (string)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_PROGRAM"];}else{n_sProgram=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_HS_MODEL"])) {n_sHs_model = (string)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_HS_MODEL"];}else{n_sHs_model=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_NORMAL_REBATE_TYPE"])) {n_sNormal_rebate_type = (string)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_NORMAL_REBATE_TYPE"];}else{n_sNormal_rebate_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_DDATE"])) {n_dDdate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_DDATE"];}else{n_dDdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_CON_PER"])) {n_sCon_per = (string)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_CON_PER"];}else{n_sCon_per=global::System.String.Empty;}
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
                if (n_iId==null && !(n_oTableSet.Fields(Para.id).IsNullable)) return false;
            }
            if (n_dCdate==null && !(n_oTableSet.Fields(Para.cdate).IsNullable)) return false;
            if (n_sCid==null && !(n_oTableSet.Fields(Para.cid).IsNullable)) return false;
            if (n_sDid==null && !(n_oTableSet.Fields(Para.did).IsNullable)) return false;
            if (n_bActive==null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_sRate_plan==null && !(n_oTableSet.Fields(Para.rate_plan).IsNullable)) return false;
            if (n_sProgram==null && !(n_oTableSet.Fields(Para.program).IsNullable)) return false;
            if (n_sHs_model==null && !(n_oTableSet.Fields(Para.hs_model).IsNullable)) return false;
            if (n_sNormal_rebate_type==null && !(n_oTableSet.Fields(Para.normal_rebate_type).IsNullable)) return false;
            if (n_dDdate==null && !(n_oTableSet.Fields(Para.ddate).IsNullable)) return false;
            if (n_sCon_per==null && !(n_oTableSet.Fields(Para.con_per).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(MobileRetentionOrderDeliveryExchangeEntity)) || (x_oObj is MobileRetentionOrderDeliveryExchangeEntity)) return MobileRetentionOrderDeliveryExchangeRepository.Instance();
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
        public MobileRetentionOrderDeliveryExchangeInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(MobileRetentionOrderDeliveryExchangeInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public string GetRate_plan(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.rate_plan)) { return string.Empty; }
            return this.rate_plan;
        }
        public global::System.Nullable<DateTime> GetCdate(){return this.cdate;}
        public string GetCid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.cid)) { return string.Empty; }
            return this.cid;
        }
        public string GetDid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.did)) { return string.Empty; }
            return this.did;
        }
        public string GetCon_per(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.con_per)) { return string.Empty; }
            return this.con_per;
        }
        public global::System.Nullable<int> GetId(){return this.id;}
        public global::System.Nullable<bool> GetActive(){return this.active;}
        public string GetHs_model(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.hs_model)) { return string.Empty; }
            return this.hs_model;
        }
        public string GetProgram(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.program)) { return string.Empty; }
            return this.program;
        }
        public string GetNormal_rebate_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.normal_rebate_type)) { return string.Empty; }
            return this.normal_rebate_type;
        }
        public global::System.Nullable<DateTime> GetDdate(){return this.ddate;}
        
        public bool SetRate_plan(string value){
            this.rate_plan=value;
            return true;
        }
        public bool SetCdate(global::System.Nullable<DateTime> value){
            this.cdate=value;
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
        public bool SetCon_per(string value){
            this.con_per=value;
            return true;
        }
        public bool SetId(global::System.Nullable<int> value){
            this.id=value;
            return true;
        }
        public bool SetActive(global::System.Nullable<bool> value){
            this.active=value;
            return true;
        }
        public bool SetHs_model(string value){
            this.hs_model=value;
            return true;
        }
        public bool SetProgram(string value){
            this.program=value;
            return true;
        }
        public bool SetNormal_rebate_type(string value){
            this.normal_rebate_type=value;
            return true;
        }
        public bool SetDdate(global::System.Nullable<DateTime> value){
            this.ddate=value;
            return true;
        }
        
        public Field GetRate_planTable(){
            return n_oTableSet.Fields(Para.rate_plan);
        }
        public Field GetCdateTable(){
            return n_oTableSet.Fields(Para.cdate);
        }
        public Field GetCidTable(){
            return n_oTableSet.Fields(Para.cid);
        }
        public Field GetDidTable(){
            return n_oTableSet.Fields(Para.did);
        }
        public Field GetCon_perTable(){
            return n_oTableSet.Fields(Para.con_per);
        }
        public Field GetIdTable(){
            return n_oTableSet.Fields(Para.id);
        }
        public Field GetActiveTable(){
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetHs_modelTable(){
            return n_oTableSet.Fields(Para.hs_model);
        }
        public Field GetProgramTable(){
            return n_oTableSet.Fields(Para.program);
        }
        public Field GetNormal_rebate_typeTable(){
            return n_oTableSet.Fields(Para.normal_rebate_type);
        }
        public Field GetDdateTable(){
            return n_oTableSet.Fields(Para.ddate);
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
        
        public bool EqualID(MobileRetentionOrderDeliveryExchange x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(MobileRetentionOrderDeliveryExchange x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_iId.Equals(x_oObj.id)){ return false; }
            if(!this.n_dCdate.Equals(x_oObj.cdate)){ return false; }
            if(!this.n_sCid.Equals(x_oObj.cid)){ return false; }
            if(!this.n_sDid.Equals(x_oObj.did)){ return false; }
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_sRate_plan.Equals(x_oObj.rate_plan)){ return false; }
            if(!this.n_sProgram.Equals(x_oObj.program)){ return false; }
            if(!this.n_sHs_model.Equals(x_oObj.hs_model)){ return false; }
            if(!this.n_sNormal_rebate_type.Equals(x_oObj.normal_rebate_type)){ return false; }
            if(!this.n_dDdate.Equals(x_oObj.ddate)){ return false; }
            if(!this.n_sCon_per.Equals(x_oObj.con_per)){ return false; }
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
            string _sQuery = "UPDATE  [MobileRetentionOrderDeliveryExchange]  SET  [cdate]=@cdate,[cid]=@cid,[did]=@did,[active]=@active,[rate_plan]=@rate_plan,[program]=@program,[hs_model]=@hs_model,[normal_rebate_type]=@normal_rebate_type,[ddate]=@ddate,[con_per]=@con_per  WHERE [MobileRetentionOrderDeliveryExchange].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionOrderDeliveryExchange]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrderDeliveryExchange]"); }
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
            if(n_iId==null){  _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value=n_iId; }
            if(n_dCdate==null){  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=n_dCdate; }
            if(n_sCid==null){  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=n_sCid; }
            if(n_sDid==null){  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value=n_sDid; }
            if(n_bActive==null){  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=n_bActive; }
            if(n_sRate_plan==null){  _oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50).Value=n_sRate_plan; }
            if(n_sProgram==null){  _oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value=n_sProgram; }
            if(n_sHs_model==null){  _oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value=n_sHs_model; }
            if(n_sNormal_rebate_type==null){  _oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,50).Value=n_sNormal_rebate_type; }
            if(n_dDdate==null){  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=n_dDdate; }
            if(n_sCon_per==null){  _oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,50).Value=n_sCon_per; }
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
        /// Summary description for table [MobileRetentionOrderDeliveryExchange] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iId==null) { return false; }
            string _sQuery="DELETE FROM  [MobileRetentionOrderDeliveryExchange]  WHERE [MobileRetentionOrderDeliveryExchange].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionOrderDeliveryExchange]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrderDeliveryExchange]"); }
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
        /// Summary description for table [MobileRetentionOrderDeliveryExchange] Object Base Clone
        /// </summary>
        
        public MobileRetentionOrderDeliveryExchange DeepClone()
        {
            MobileRetentionOrderDeliveryExchange _oMobileRetentionOrderDeliveryExchange_Clone = new MobileRetentionOrderDeliveryExchange();
            _oMobileRetentionOrderDeliveryExchange_Clone.id = this.n_iId;
            _oMobileRetentionOrderDeliveryExchange_Clone.cdate = this.n_dCdate;
            _oMobileRetentionOrderDeliveryExchange_Clone.cid = this.n_sCid;
            _oMobileRetentionOrderDeliveryExchange_Clone.did = this.n_sDid;
            _oMobileRetentionOrderDeliveryExchange_Clone.active = this.n_bActive;
            _oMobileRetentionOrderDeliveryExchange_Clone.rate_plan = this.n_sRate_plan;
            _oMobileRetentionOrderDeliveryExchange_Clone.program = this.n_sProgram;
            _oMobileRetentionOrderDeliveryExchange_Clone.hs_model = this.n_sHs_model;
            _oMobileRetentionOrderDeliveryExchange_Clone.normal_rebate_type = this.n_sNormal_rebate_type;
            _oMobileRetentionOrderDeliveryExchange_Clone.ddate = this.n_dDdate;
            _oMobileRetentionOrderDeliveryExchange_Clone.con_per = this.n_sCon_per;
            _oMobileRetentionOrderDeliveryExchange_Clone.SetFound(this.n_bFound);
            _oMobileRetentionOrderDeliveryExchange_Clone.SetDB(this.n_oDB);
            _oMobileRetentionOrderDeliveryExchange_Clone.SetRow(this.n_oRow);
            _oMobileRetentionOrderDeliveryExchange_Clone.SetTbl(this.n_oTbl);
            _oMobileRetentionOrderDeliveryExchange_Clone.SetTableSet(this.n_oTableSet);
            
            return _oMobileRetentionOrderDeliveryExchange_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_iId=null;
            n_dCdate=null;
            n_sCid=global::System.String.Empty;
            n_sDid=global::System.String.Empty;
            n_bActive=null;
            n_sRate_plan=global::System.String.Empty;
            n_sProgram=global::System.String.Empty;
            n_sHs_model=global::System.String.Empty;
            n_sNormal_rebate_type=global::System.String.Empty;
            n_dDdate=null;
            n_sCon_per=global::System.String.Empty;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = MobileRetentionOrderDeliveryExchangeInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


