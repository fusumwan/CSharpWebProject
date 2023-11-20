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
///-- Create date: <Create Date 2010-12-10>
///-- Description:	<Description,Table :[MobileOrderSyncSearch],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [MobileOrderSyncSearch] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"MobileOrderSyncSearch")]
    public class MobileOrderSyncSearchEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private MobileOrderSyncSearchInfo n_oTableSet = MobileOrderSyncSearchInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string active="active";
            public const string sku="sku";
            public const string program="program";
            public const string sim_item_name="sim_item_name";
            public const string d_date="d_date";
            public const string edf_no="edf_no";
            public const string order_id="order_id";
            public const string sim_item_code="sim_item_code";
            public const string imei_no="imei_no";
            public const string MobileOrderSyncSearch_table_name="MobileOrderSyncSearch";
            public static string TableName() { return MobileOrderSyncSearch_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public MobileOrderSyncSearchEntity(){
            Init();
        }
        public MobileOrderSyncSearchEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public MobileOrderSyncSearchEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iOrder_id){
            n_oDB=x_oDB;
            this.Load(x_iOrder_id);
            Init();
        }
        
        ~MobileOrderSyncSearchEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iOrder_id){
            if (n_oDB==null) { return false; }
            if (x_iOrder_id==null) { return false; }
            string _sQuery = "SELECT   [MobileOrderSyncSearch].[edf_no] AS MOBILEORDERSYNCSEARCH_EDF_NO,[MobileOrderSyncSearch].[active] AS MOBILEORDERSYNCSEARCH_ACTIVE,[MobileOrderSyncSearch].[sku] AS MOBILEORDERSYNCSEARCH_SKU,[MobileOrderSyncSearch].[sim_item_name] AS MOBILEORDERSYNCSEARCH_SIM_ITEM_NAME,[MobileOrderSyncSearch].[d_date] AS MOBILEORDERSYNCSEARCH_D_DATE,[MobileOrderSyncSearch].[program] AS MOBILEORDERSYNCSEARCH_PROGRAM,[MobileOrderSyncSearch].[order_id] AS MOBILEORDERSYNCSEARCH_ORDER_ID,[MobileOrderSyncSearch].[sim_item_code] AS MOBILEORDERSYNCSEARCH_SIM_ITEM_CODE,[MobileOrderSyncSearch].[imei_no] AS MOBILEORDERSYNCSEARCH_IMEI_NO  FROM  [MobileOrderSyncSearch]  WHERE  [MobileOrderSyncSearch].[order_id] = \'"+x_iOrder_id.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderSyncSearch]","["+ Configurator.MSSQLTablePrefix + "MobileOrderSyncSearch]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_EDF_NO"])) {n_sEdf_no = (string)_oData["MOBILEORDERSYNCSEARCH_EDF_NO"];}else{n_sEdf_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["MOBILEORDERSYNCSEARCH_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_SKU"])) {n_sSku = (string)_oData["MOBILEORDERSYNCSEARCH_SKU"];}else{n_sSku=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_SIM_ITEM_NAME"])) {n_sSim_item_name = (string)_oData["MOBILEORDERSYNCSEARCH_SIM_ITEM_NAME"];}else{n_sSim_item_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_D_DATE"])) {n_dD_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERSYNCSEARCH_D_DATE"];}else{n_dD_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_PROGRAM"])) {n_sProgram = (string)_oData["MOBILEORDERSYNCSEARCH_PROGRAM"];}else{n_sProgram=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_ORDER_ID"])) {n_iOrder_id = (global::System.Nullable<int>)_oData["MOBILEORDERSYNCSEARCH_ORDER_ID"];}else{n_iOrder_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_SIM_ITEM_CODE"])) {n_sSim_item_code = (string)_oData["MOBILEORDERSYNCSEARCH_SIM_ITEM_CODE"];}else{n_sSim_item_code=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_IMEI_NO"])) {n_sImei_no = (string)_oData["MOBILEORDERSYNCSEARCH_IMEI_NO"];}else{n_sImei_no=global::System.String.Empty;}
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
            if (n_sEdf_no==null && !(n_oTableSet.Fields(Para.edf_no).IsNullable)) return false;
            if (n_bActive==null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_sSku==null && !(n_oTableSet.Fields(Para.sku).IsNullable)) return false;
            if (n_sSim_item_name==null && !(n_oTableSet.Fields(Para.sim_item_name).IsNullable)) return false;
            if (n_dD_date==null && !(n_oTableSet.Fields(Para.d_date).IsNullable)) return false;
            if (n_sProgram==null && !(n_oTableSet.Fields(Para.program).IsNullable)) return false;
            if(!x_bInsert){
                if (n_iOrder_id==null && !(n_oTableSet.Fields(Para.order_id).IsNullable)) return false;
            }
            if (n_sSim_item_code==null && !(n_oTableSet.Fields(Para.sim_item_code).IsNullable)) return false;
            if (n_sImei_no==null && !(n_oTableSet.Fields(Para.imei_no).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(MobileOrderSyncSearchEntity)) || (x_oObj is MobileOrderSyncSearchEntity)) return MobileOrderSyncSearchRepository.Instance();
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
        public MobileOrderSyncSearchInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(MobileOrderSyncSearchInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public global::System.Nullable<bool> GetActive(){return this.active;}
        public string GetSku(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.sku)) { return string.Empty; }
            return this.sku;
        }
        public string GetProgram(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.program)) { return string.Empty; }
            return this.program;
        }
        public string GetSim_item_name(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.sim_item_name)) { return string.Empty; }
            return this.sim_item_name;
        }
        public global::System.Nullable<DateTime> GetD_date(){return this.d_date;}
        public string GetEdf_no(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.edf_no)) { return string.Empty; }
            return this.edf_no;
        }
        public global::System.Nullable<int> GetOrder_id(){return this.order_id;}
        public string GetSim_item_code(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.sim_item_code)) { return string.Empty; }
            return this.sim_item_code;
        }
        public string GetImei_no(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.imei_no)) { return string.Empty; }
            return this.imei_no;
        }
        
        public bool SetActive(global::System.Nullable<bool> value){
            this.active=value;
            return true;
        }
        public bool SetSku(string value){
            this.sku=value;
            return true;
        }
        public bool SetProgram(string value){
            this.program=value;
            return true;
        }
        public bool SetSim_item_name(string value){
            this.sim_item_name=value;
            return true;
        }
        public bool SetD_date(global::System.Nullable<DateTime> value){
            this.d_date=value;
            return true;
        }
        public bool SetEdf_no(string value){
            this.edf_no=value;
            return true;
        }
        public bool SetOrder_id(global::System.Nullable<int> value){
            this.order_id=value;
            return true;
        }
        public bool SetSim_item_code(string value){
            this.sim_item_code=value;
            return true;
        }
        public bool SetImei_no(string value){
            this.imei_no=value;
            return true;
        }
        
        public Field GetActiveTable(){
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetSkuTable(){
            return n_oTableSet.Fields(Para.sku);
        }
        public Field GetProgramTable(){
            return n_oTableSet.Fields(Para.program);
        }
        public Field GetSim_item_nameTable(){
            return n_oTableSet.Fields(Para.sim_item_name);
        }
        public Field GetD_dateTable(){
            return n_oTableSet.Fields(Para.d_date);
        }
        public Field GetEdf_noTable(){
            return n_oTableSet.Fields(Para.edf_no);
        }
        public Field GetOrder_idTable(){
            return n_oTableSet.Fields(Para.order_id);
        }
        public Field GetSim_item_codeTable(){
            return n_oTableSet.Fields(Para.sim_item_code);
        }
        public Field GetImei_noTable(){
            return n_oTableSet.Fields(Para.imei_no);
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
        
        public bool EqualID(MobileOrderSyncSearch x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iOrder_id.Equals(x_oObj.order_id)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(MobileOrderSyncSearch x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_sEdf_no.Equals(x_oObj.edf_no)){ return false; }
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_sSku.Equals(x_oObj.sku)){ return false; }
            if(!this.n_sSim_item_name.Equals(x_oObj.sim_item_name)){ return false; }
            if(!this.n_dD_date.Equals(x_oObj.d_date)){ return false; }
            if(!this.n_sProgram.Equals(x_oObj.program)){ return false; }
            if(!this.n_iOrder_id.Equals(x_oObj.order_id)){ return false; }
            if(!this.n_sSim_item_code.Equals(x_oObj.sim_item_code)){ return false; }
            if(!this.n_sImei_no.Equals(x_oObj.imei_no)){ return false; }
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
            string _sQuery = "UPDATE  [MobileOrderSyncSearch]  SET  [edf_no]=@edf_no,[active]=@active,[sku]=@sku,[sim_item_name]=@sim_item_name,[d_date]=@d_date,[program]=@program,[sim_item_code]=@sim_item_code,[imei_no]=@imei_no  WHERE [MobileOrderSyncSearch].[order_id]=@order_id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderSyncSearch]","["+ Configurator.MSSQLTablePrefix + "MobileOrderSyncSearch]"); }
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
            if(n_sEdf_no==null){  _oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,15).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,15).Value=n_sEdf_no; }
            if(n_bActive==null){  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=n_bActive; }
            if(n_sSku==null){  _oCmd.Parameters.Add("@sku", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@sku", global::System.Data.SqlDbType.NVarChar,50).Value=n_sSku; }
            if(n_sSim_item_name==null){  _oCmd.Parameters.Add("@sim_item_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@sim_item_name", global::System.Data.SqlDbType.NVarChar,250).Value=n_sSim_item_name; }
            if(n_dD_date==null){  _oCmd.Parameters.Add("@d_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@d_date", global::System.Data.SqlDbType.DateTime).Value=n_dD_date; }
            if(n_sProgram==null){  _oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value=n_sProgram; }
            if(n_iOrder_id==null){  _oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=n_iOrder_id; }
            if(n_sSim_item_code==null){  _oCmd.Parameters.Add("@sim_item_code", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@sim_item_code", global::System.Data.SqlDbType.NVarChar,250).Value=n_sSim_item_code; }
            if(n_sImei_no==null){  _oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,30).Value=n_sImei_no; }
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
        /// Summary description for table [MobileOrderSyncSearch] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iOrder_id==null) { return false; }
            string _sQuery="DELETE FROM  [MobileOrderSyncSearch]  WHERE [MobileOrderSyncSearch].[order_id]=@order_id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderSyncSearch]","["+ Configurator.MSSQLTablePrefix + "MobileOrderSyncSearch]"); }
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
        /// Summary description for table [MobileOrderSyncSearch] Object Base Clone
        /// </summary>
        
        public MobileOrderSyncSearch DeepClone()
        {
            MobileOrderSyncSearch _oMobileOrderSyncSearch_Clone = new MobileOrderSyncSearch();
            _oMobileOrderSyncSearch_Clone.edf_no = this.n_sEdf_no;
            _oMobileOrderSyncSearch_Clone.active = this.n_bActive;
            _oMobileOrderSyncSearch_Clone.sku = this.n_sSku;
            _oMobileOrderSyncSearch_Clone.sim_item_name = this.n_sSim_item_name;
            _oMobileOrderSyncSearch_Clone.d_date = this.n_dD_date;
            _oMobileOrderSyncSearch_Clone.program = this.n_sProgram;
            _oMobileOrderSyncSearch_Clone.order_id = this.n_iOrder_id;
            _oMobileOrderSyncSearch_Clone.sim_item_code = this.n_sSim_item_code;
            _oMobileOrderSyncSearch_Clone.imei_no = this.n_sImei_no;
            _oMobileOrderSyncSearch_Clone.SetFound(this.n_bFound);
            _oMobileOrderSyncSearch_Clone.SetDB(this.n_oDB);
            _oMobileOrderSyncSearch_Clone.SetRow(this.n_oRow);
            _oMobileOrderSyncSearch_Clone.SetTbl(this.n_oTbl);
            _oMobileOrderSyncSearch_Clone.SetTableSet(this.n_oTableSet);
            
            return _oMobileOrderSyncSearch_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_sEdf_no=global::System.String.Empty;
            n_bActive=null;
            n_sSku=global::System.String.Empty;
            n_sSim_item_name=global::System.String.Empty;
            n_dD_date=null;
            n_sProgram=global::System.String.Empty;
            n_iOrder_id=null;
            n_sSim_item_code=global::System.String.Empty;
            n_sImei_no=global::System.String.Empty;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = MobileOrderSyncSearchInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


