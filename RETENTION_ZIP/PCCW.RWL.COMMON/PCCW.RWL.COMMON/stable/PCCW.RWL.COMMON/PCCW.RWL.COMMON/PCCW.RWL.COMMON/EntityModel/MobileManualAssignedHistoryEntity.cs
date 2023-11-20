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
///-- Create date: <Create Date 2010-06-09>
///-- Description:	<Description,Table :[MobileManualAssignedHistory],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [MobileManualAssignedHistory] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"MobileManualAssignedHistory")]
    public class MobileManualAssignedHistoryEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private MobileManualAssignedHistoryInfo n_oTableSet = MobileManualAssignedHistoryInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string sku="sku";
            public const string order_id="order_id";
            public const string cdate="cdate";
            public const string cid="cid";
            public const string imei_no="imei_no";
            public const string id="id";
            public const string MobileManualAssignedHistory_table_name="MobileManualAssignedHistory";
            public static string TableName() { return MobileManualAssignedHistory_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public MobileManualAssignedHistoryEntity(){
            Init();
        }
        public MobileManualAssignedHistoryEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public MobileManualAssignedHistoryEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId){
            n_oDB=x_oDB;
            this.Load(x_iId);
            Init();
        }
        
        ~MobileManualAssignedHistoryEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iId){
            if (n_oDB==null) { return false; }
            if (x_iId==null) { return false; }
            string _sQuery = "SELECT   [MobileManualAssignedHistory].[sku] AS MOBILEMANUALASSIGNEDHISTORY_SKU,[MobileManualAssignedHistory].[order_id] AS MOBILEMANUALASSIGNEDHISTORY_ORDER_ID,[MobileManualAssignedHistory].[cdate] AS MOBILEMANUALASSIGNEDHISTORY_CDATE,[MobileManualAssignedHistory].[cid] AS MOBILEMANUALASSIGNEDHISTORY_CID,[MobileManualAssignedHistory].[imei_no] AS MOBILEMANUALASSIGNEDHISTORY_IMEI_NO,[MobileManualAssignedHistory].[id] AS MOBILEMANUALASSIGNEDHISTORY_ID  FROM  [MobileManualAssignedHistory]  WHERE  [MobileManualAssignedHistory].[id] = \'"+x_iId.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileManualAssignedHistory]","["+ Configurator.MSSQLTablePrefix + "MobileManualAssignedHistory]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEMANUALASSIGNEDHISTORY_SKU"])) {n_sSku = (string)_oData["MOBILEMANUALASSIGNEDHISTORY_SKU"];}else{n_sSku=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEMANUALASSIGNEDHISTORY_ORDER_ID"])) {n_iOrder_id = (global::System.Nullable<int>)_oData["MOBILEMANUALASSIGNEDHISTORY_ORDER_ID"];}else{n_iOrder_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEMANUALASSIGNEDHISTORY_CDATE"])) {n_dCdate = (global::System.Nullable<DateTime>)_oData["MOBILEMANUALASSIGNEDHISTORY_CDATE"];}else{n_dCdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEMANUALASSIGNEDHISTORY_CID"])) {n_sCid = (string)_oData["MOBILEMANUALASSIGNEDHISTORY_CID"];}else{n_sCid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEMANUALASSIGNEDHISTORY_IMEI_NO"])) {n_sImei_no = (string)_oData["MOBILEMANUALASSIGNEDHISTORY_IMEI_NO"];}else{n_sImei_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEMANUALASSIGNEDHISTORY_ID"])) {n_iId = (global::System.Nullable<int>)_oData["MOBILEMANUALASSIGNEDHISTORY_ID"];}else{n_iId=null;}
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
            if (n_sSku==null && !(n_oTableSet.Fields(Para.sku).IsNullable)) return false;
            if (n_iOrder_id==null && !(n_oTableSet.Fields(Para.order_id).IsNullable)) return false;
            if (n_dCdate==null && !(n_oTableSet.Fields(Para.cdate).IsNullable)) return false;
            if (n_sCid==null && !(n_oTableSet.Fields(Para.cid).IsNullable)) return false;
            if (n_sImei_no==null && !(n_oTableSet.Fields(Para.imei_no).IsNullable)) return false;
            if(!x_bInsert){
                if (n_iId==null && !(n_oTableSet.Fields(Para.id).IsNullable)) return false;
            }
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
            if (x_oObj.GetType().IsSubclassOf(typeof(MobileManualAssignedHistoryEntity)) || (x_oObj is MobileManualAssignedHistoryEntity)) return MobileManualAssignedHistoryRepository.Instance();
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
        public MobileManualAssignedHistoryInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(MobileManualAssignedHistoryInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public string GetSku(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.sku)) { return string.Empty; }
            return this.sku;
        }
        public global::System.Nullable<int> GetOrder_id(){return this.order_id;}
        public global::System.Nullable<DateTime> GetCdate(){return this.cdate;}
        public string GetCid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.cid)) { return string.Empty; }
            return this.cid;
        }
        public string GetImei_no(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.imei_no)) { return string.Empty; }
            return this.imei_no;
        }
        public global::System.Nullable<int> GetId(){return this.id;}
        
        public bool SetSku(string value){
            this.sku=value;
            return true;
        }
        public bool SetOrder_id(global::System.Nullable<int> value){
            this.order_id=value;
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
        public bool SetImei_no(string value){
            this.imei_no=value;
            return true;
        }
        public bool SetId(global::System.Nullable<int> value){
            this.id=value;
            return true;
        }
        
        public Field GetSkuTable(){
            return n_oTableSet.Fields(Para.sku);
        }
        public Field GetOrder_idTable(){
            return n_oTableSet.Fields(Para.order_id);
        }
        public Field GetCdateTable(){
            return n_oTableSet.Fields(Para.cdate);
        }
        public Field GetCidTable(){
            return n_oTableSet.Fields(Para.cid);
        }
        public Field GetImei_noTable(){
            return n_oTableSet.Fields(Para.imei_no);
        }
        public Field GetIdTable(){
            return n_oTableSet.Fields(Para.id);
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
        
        public bool EqualID(MobileManualAssignedHistory x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(MobileManualAssignedHistory x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_sSku.Equals(x_oObj.sku)){ return false; }
            if(!this.n_iOrder_id.Equals(x_oObj.order_id)){ return false; }
            if(!this.n_dCdate.Equals(x_oObj.cdate)){ return false; }
            if(!this.n_sCid.Equals(x_oObj.cid)){ return false; }
            if(!this.n_sImei_no.Equals(x_oObj.imei_no)){ return false; }
            if(!this.n_iId.Equals(x_oObj.id)){ return false; }
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
            string _sQuery = "UPDATE  [MobileManualAssignedHistory]  SET  [sku]=@sku,[order_id]=@order_id,[cdate]=@cdate,[cid]=@cid,[imei_no]=@imei_no  WHERE [MobileManualAssignedHistory].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileManualAssignedHistory]","["+ Configurator.MSSQLTablePrefix + "MobileManualAssignedHistory]"); }
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
            if(n_sSku==null){  _oCmd.Parameters.Add("@sku", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@sku", global::System.Data.SqlDbType.NVarChar,100).Value=n_sSku; }
            if(n_iOrder_id==null){  _oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=n_iOrder_id; }
            if(n_dCdate==null){  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=n_dCdate; }
            if(n_sCid==null){  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=n_sCid; }
            if(n_sImei_no==null){  _oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,250).Value=n_sImei_no; }
            if(n_iId==null){  _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value=n_iId; }
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
        /// Summary description for table [MobileManualAssignedHistory] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iId==null) { return false; }
            string _sQuery="DELETE FROM  [MobileManualAssignedHistory]  WHERE [MobileManualAssignedHistory].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileManualAssignedHistory]","["+ Configurator.MSSQLTablePrefix + "MobileManualAssignedHistory]"); }
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
        /// Summary description for table [MobileManualAssignedHistory] Object Base Clone
        /// </summary>
        
        public MobileManualAssignedHistory DeepClone()
        {
            MobileManualAssignedHistory _oMobileManualAssignedHistory_Clone = new MobileManualAssignedHistory();
            _oMobileManualAssignedHistory_Clone.sku = this.n_sSku;
            _oMobileManualAssignedHistory_Clone.order_id = this.n_iOrder_id;
            _oMobileManualAssignedHistory_Clone.cdate = this.n_dCdate;
            _oMobileManualAssignedHistory_Clone.cid = this.n_sCid;
            _oMobileManualAssignedHistory_Clone.imei_no = this.n_sImei_no;
            _oMobileManualAssignedHistory_Clone.id = this.n_iId;
            _oMobileManualAssignedHistory_Clone.SetFound(this.n_bFound);
            _oMobileManualAssignedHistory_Clone.SetDB(this.n_oDB);
            _oMobileManualAssignedHistory_Clone.SetRow(this.n_oRow);
            _oMobileManualAssignedHistory_Clone.SetTbl(this.n_oTbl);
            _oMobileManualAssignedHistory_Clone.SetTableSet(this.n_oTableSet);
            
            return _oMobileManualAssignedHistory_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_sSku=global::System.String.Empty;
            n_iOrder_id=null;
            n_dCdate=null;
            n_sCid=global::System.String.Empty;
            n_sImei_no=global::System.String.Empty;
            n_iId=null;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = MobileManualAssignedHistoryInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


