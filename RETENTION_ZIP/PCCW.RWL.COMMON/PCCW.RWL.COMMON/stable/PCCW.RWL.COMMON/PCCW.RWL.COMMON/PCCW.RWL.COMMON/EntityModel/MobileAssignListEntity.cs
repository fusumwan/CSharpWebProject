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
///-- Create date: <Create Date 2010-11-05>
///-- Description:	<Description,Table :[MobileAssignList],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [MobileAssignList] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"MobileAssignList")]
    public class MobileAssignListEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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

        protected global::System.Nullable<int> n_iRecord_id= null;
        #region record_id
        public global::System.Nullable<int> record_id
        {
            get
            {
                return this.n_iRecord_id;
            }
            set
            {
                this.n_iRecord_id = value;
            }
        }
        #endregion record_id

        protected string n_sStatus= global::System.String.Empty;
        #region status
        [System.Data.Linq.Mapping.Column(Name = "[status]", Storage = "n_sStatus")]
        public string status
        {
            get
            {
                return this.n_sStatus;
            }
            set
            {
                this.n_sStatus = value;
            }
        }
        #endregion status

        
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
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private MobileAssignListInfo n_oTableSet = MobileAssignListInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string sku="sku";
            public const string order_id="order_id";
            public const string hs_model="hs_model";
            public const string edf_no="edf_no";
            public const string imei_no="imei_no";
            public const string active="active";
            public const string d_date="d_date";
            public const string MobileAssignList_table_name="MobileAssignList";
            public static string TableName() { return MobileAssignList_table_name; }
        }
        #endregion Parameter String
        #region Constructor
        
        public MobileAssignListEntity(){
            Init();
        }
        public MobileAssignListEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public MobileAssignListEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iOrder_id){
            n_oDB=x_oDB;
            this.Load(x_iOrder_id);
            Init();
        }
        
        ~MobileAssignListEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iOrder_id){
            if (n_oDB == null) { return false; }
            if (x_iOrder_id==null) { return false; }
            string _sQuery = "SELECT record_id AS MOBILERETENTIONORDER_RECORD_ID,order_id AS MOBILERETENTIONORDER_ORDER_ID,date_diff AS MOBILERETENTIONORDER_DATE_DIFF,status AS MOBILERETENTIONORDER_STATUS,hs_model AS MOBILERETENTIONORDER_HS_MODEL,sku AS MOBILERETENTIONORDER_SKU,imei_no AS MOBILERETENTIONORDER_IMEI_NO,edf_no AS MOBILERETENTIONORDER_EDF_NO,active AS MOBILERETENTIONORDER_ACTIVE FROM MobileAssignList WHERE order_id='" + x_iOrder_id.ToString() + "' ";
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
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SKU"])) {n_sSku = (string)_oData["MOBILERETENTIONORDER_SKU"];}else{ n_sSku=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORDER_ID"])) {n_iOrder_id = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDER_ORDER_ID"];}else{ n_iOrder_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_HS_MODEL"])) {n_sHs_model = (string)_oData["MOBILERETENTIONORDER_HS_MODEL"];}else{ n_sHs_model=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EDF_NO"])) {n_sEdf_no = (string)_oData["MOBILERETENTIONORDER_EDF_NO"];}else{ n_sEdf_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_IMEI_NO"])) {n_sImei_no = (string)_oData["MOBILERETENTIONORDER_IMEI_NO"];}else{ n_sImei_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_ACTIVE"];}else{ n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_D_DATE"])) {n_dD_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_D_DATE"];}else{ n_dD_date=null;}
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
            if (n_sHs_model==null && !(n_oTableSet.Fields(Para.hs_model).IsNullable)) return false;
            if (n_sEdf_no==null && !(n_oTableSet.Fields(Para.edf_no).IsNullable)) return false;
            if (n_sImei_no==null && !(n_oTableSet.Fields(Para.imei_no).IsNullable)) return false;
            if (n_bActive==null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_dD_date==null && !(n_oTableSet.Fields(Para.d_date).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(MobileAssignListEntity)) || (x_oObj is MobileAssignListEntity)) return MobileAssignListRepository.Instance();
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
        public MobileAssignListInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(MobileAssignListInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public string GetSku(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.sku)) { return string.Empty; }
            return this.sku;
        }
        public global::System.Nullable<int> GetOrder_id(){return this.order_id;}
        public string GetHs_model(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.hs_model)) { return string.Empty; }
            return this.hs_model;
        }
        public string GetEdf_no(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.edf_no)) { return string.Empty; }
            return this.edf_no;
        }
        public string GetImei_no(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.imei_no)) { return string.Empty; }
            return this.imei_no;
        }
        public global::System.Nullable<bool> GetActive(){return this.active;}
        public global::System.Nullable<DateTime> GetD_date(){return this.d_date;}
        
        public bool SetSku(string value){
            this.sku=value;
            return true;
        }
        public bool SetOrder_id(global::System.Nullable<int> value){
            this.order_id=value;
            return true;
        }
        public bool SetHs_model(string value){
            this.hs_model=value;
            return true;
        }
        public bool SetEdf_no(string value){
            this.edf_no=value;
            return true;
        }
        public bool SetImei_no(string value){
            this.imei_no=value;
            return true;
        }
        public bool SetActive(global::System.Nullable<bool> value){
            this.active=value;
            return true;
        }
        public bool SetD_date(global::System.Nullable<DateTime> value){
            this.d_date=value;
            return true;
        }
        public bool SetRecord_id(global::System.Nullable<int> value)
        {
            this.record_id = value;
            return true;
        }
        public bool SetStatus(string value)
        {
            this.status = value;
            return true;
        }
        public Field GetSkuTable(){
            return n_oTableSet.Fields(Para.sku);
        }
        public Field GetOrder_idTable(){
            return n_oTableSet.Fields(Para.order_id);
        }
        public Field GetHs_modelTable(){
            return n_oTableSet.Fields(Para.hs_model);
        }
        public Field GetEdf_noTable(){
            return n_oTableSet.Fields(Para.edf_no);
        }
        public Field GetImei_noTable(){
            return n_oTableSet.Fields(Para.imei_no);
        }
        public Field GetActiveTable(){
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetD_dateTable(){
            return n_oTableSet.Fields(Para.d_date);
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
        
        #region Retrieve
        
        /// <summary>
        /// Summary description for Retrieve
        /// </summary>
        
        #endregion

        #region 
        public bool Save()
        {

            return false;
        }
        #endregion

        #region Delete
        public bool Delete()
        {
            return false;
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
        /// Summary description for table [MobileAssignList] Object Base Clone
        /// </summary>
        
        public MobileAssignList DeepClone()
        {
            MobileAssignList _oMobileAssignList_Clone = new MobileAssignList();
            _oMobileAssignList_Clone.sku = this.n_sSku;
            _oMobileAssignList_Clone.order_id = this.n_iOrder_id;
            _oMobileAssignList_Clone.hs_model = this.n_sHs_model;
            _oMobileAssignList_Clone.edf_no = this.n_sEdf_no;
            _oMobileAssignList_Clone.imei_no = this.n_sImei_no;
            _oMobileAssignList_Clone.active = this.n_bActive;
            _oMobileAssignList_Clone.d_date = this.n_dD_date;
            _oMobileAssignList_Clone.SetFound(this.n_bFound);
            _oMobileAssignList_Clone.SetDB(this.n_oDB);
            _oMobileAssignList_Clone.SetRow(this.n_oRow);
            _oMobileAssignList_Clone.SetTbl(this.n_oTbl);
            _oMobileAssignList_Clone.SetTableSet(this.n_oTableSet);
            _oMobileAssignList_Clone.SetRecord_id(this.n_iRecord_id);
            _oMobileAssignList_Clone.SetStatus(this.n_sStatus);
            return _oMobileAssignList_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_sSku=global::System.String.Empty;
            n_iOrder_id=null;
            n_sHs_model=global::System.String.Empty;
            n_sEdf_no=global::System.String.Empty;
            n_sImei_no=global::System.String.Empty;
            n_bActive=null;
            n_dD_date=null;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_sStatus = string.Empty;
            n_iRecord_id = null;
            n_oTableSet = MobileAssignListInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


