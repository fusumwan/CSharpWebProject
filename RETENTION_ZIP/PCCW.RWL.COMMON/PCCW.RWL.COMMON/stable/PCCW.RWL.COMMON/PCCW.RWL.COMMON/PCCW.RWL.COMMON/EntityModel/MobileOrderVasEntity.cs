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
///-- Create date: <Create Date 2011-03-08>
///-- Description:	<Description,Table :[MobileOrderVas],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [MobileOrderVas] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"MobileOrderVas")]
    public class MobileOrderVasEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        
        protected global::System.Nullable<int> n_iMulti_id=null;
        #region multi_id
        [System.Data.Linq.Mapping.Column(Name="[multi_id]", Storage="n_iMulti_id")]
        public global::System.Nullable<int> multi_id{
            get{
                return this.n_iMulti_id;
            }
            set{
                this.n_iMulti_id=value;
            }
        }
        #endregion multi_id
        
        
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
        
        
        protected global::System.Nullable<int> n_iVas_id=null;
        #region vas_id
        [System.Data.Linq.Mapping.Column(Name="[vas_id]", Storage="n_iVas_id")]
        public global::System.Nullable<int> vas_id{
            get{
                return this.n_iVas_id;
            }
            set{
                this.n_iVas_id=value;
            }
        }
        #endregion vas_id
        
        
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
        
        
        private MobileRetentionOrder n_oMobileRetentionOrderMobileOrderVas=null;
        #region MobileRetentionOrderMobileOrderVas    Primary Key Table
        public MobileRetentionOrder MobileRetentionOrderMobileOrderVas{
            get{
                if(n_oMobileRetentionOrderMobileOrderVas==null){
                    if (n_iOrder_id == null) { 
                        n_oMobileRetentionOrderMobileOrderVas=new MobileRetentionOrder();
                        return n_oMobileRetentionOrderMobileOrderVas;
                    }
                    n_oMobileRetentionOrderMobileOrderVas = (MobileRetentionOrder)MobileRetentionOrderRepository.GetObj(this.n_oDB, this.n_iOrder_id);
                    if(n_oMobileRetentionOrderMobileOrderVas==null){
                        n_oMobileRetentionOrderMobileOrderVas=new MobileRetentionOrder(this.n_oDB);
                        n_oMobileRetentionOrderMobileOrderVas.SetOrder_id(this.n_iOrder_id);
                    }
                }
                else if(n_oMobileRetentionOrderMobileOrderVas.order_id!=this.n_iOrder_id)
                {
                    n_oMobileRetentionOrderMobileOrderVas = (MobileRetentionOrder)MobileRetentionOrderRepository.GetObj(this.n_oDB, this.n_iOrder_id);
                    if (n_oMobileRetentionOrderMobileOrderVas == null)
                    {
                        n_oMobileRetentionOrderMobileOrderVas=new MobileRetentionOrder(this.n_oDB);
                        n_oMobileRetentionOrderMobileOrderVas.SetOrder_id(this.n_iOrder_id);
                    }
                }
                return n_oMobileRetentionOrderMobileOrderVas;
            }
            set{
                if (value == null)
                {
                    n_oMobileRetentionOrderMobileOrderVas = new MobileRetentionOrder(this.n_oDB);
                }
                else
                {
                    this.n_oMobileRetentionOrderMobileOrderVas = value;
                }
                n_oMobileRetentionOrderMobileOrderVas.SetOrder_id(this.n_iOrder_id);
            }
        }
        
        private global::System.Data.DataSet n_oMobileRetentionOrderMobileOrderVasDataSet = null;
        #region MobileRetentionOrderMobileOrderVasDataSet    Primary Key Table DataSet
        public global::System.Data.DataSet MobileRetentionOrderMobileOrderVasDataSet
        {
            get
            {
                MobileRetentionOrderBal _oMobileRetentionOrderBal = new MobileRetentionOrderBal();
                bool _bGetDataSet = false;
                if (n_oMobileRetentionOrderMobileOrderVasDataSet == null)
                {
                    if (n_iOrder_id == null) { 
                        n_oMobileRetentionOrderMobileOrderVasDataSet= MobileRetentionOrderBal.ToEmptyDataSet();
                        return n_oMobileRetentionOrderMobileOrderVasDataSet;
                    }
                    _bGetDataSet = true;
                }
                if(n_oMobileRetentionOrderMobileOrderVasDataSet!=null){
                    if (n_oMobileRetentionOrderMobileOrderVasDataSet.Tables.Contains(MobileRetentionOrder.Para.TableName())){
                        if (n_oMobileRetentionOrderMobileOrderVasDataSet.Tables[MobileRetentionOrder.Para.TableName()].Rows.Count == 0){ _bGetDataSet = true; }
                    }
                }
                if (_bGetDataSet){
                    n_oMobileRetentionOrderMobileOrderVasDataSet = MobileRetentionOrderRepository.GetDataSet(n_oDB, "order_id="+n_iOrder_id);
                    if (n_oMobileRetentionOrderMobileOrderVasDataSet == null)
                    {
                        n_oMobileRetentionOrderMobileOrderVasDataSet = MobileRetentionOrderBal.ToEmptyDataSet();
                    }
                }
                return n_oMobileRetentionOrderMobileOrderVasDataSet;
            }
            set
            {
                n_oMobileRetentionOrderMobileOrderVasDataSet = value;
            }
        }
        
        #endregion MobileRetentionOrderMobileOrderVasDataSet
        #endregion MobileRetentionOrderMobileOrderVas
        
        
        protected string n_sFee=global::System.String.Empty;
        #region fee
        [System.Data.Linq.Mapping.Column(Name="[fee]", Storage="n_sFee")]
        public string fee{
            get{
                return this.n_sFee;
            }
            set{
                this.n_sFee=value;
            }
        }
        #endregion fee
        
        
        protected string n_sVas_value=global::System.String.Empty;
        #region vas_value
        [System.Data.Linq.Mapping.Column(Name="[vas_value]", Storage="n_sVas_value")]
        public string vas_value{
            get{
                return this.n_sVas_value;
            }
            set{
                this.n_sVas_value=value;
            }
        }
        #endregion vas_value
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private MobileOrderVasInfo n_oTableSet = MobileOrderVasInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string id="id";
            public const string cdate="cdate";
            public const string active="active";
            public const string vas_field="vas_field";
            public const string vas_id="vas_id";
            public const string order_id="order_id";
            public const string fee="fee";
            public const string vas_value="vas_value";
            public const string multi_id="multi_id";
            public const string MobileOrderVas_table_name="MobileOrderVas";
            public static string TableName() { return MobileOrderVas_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public MobileOrderVasEntity(){
            Init();
        }
        public MobileOrderVasEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public MobileOrderVasEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId){
            n_oDB=x_oDB;
            this.Load(x_iId);
            Init();
        }
        
        ~MobileOrderVasEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iId){
            if (n_oDB==null) { return false; }
            if (x_iId==null) { return false; }
            string _sQuery = "SELECT   [MobileOrderVas].[id] AS MOBILEORDERVAS_ID,[MobileOrderVas].[cdate] AS MOBILEORDERVAS_CDATE,[MobileOrderVas].[active] AS MOBILEORDERVAS_ACTIVE,[MobileOrderVas].[multi_id] AS MOBILEORDERVAS_MULTI_ID,[MobileOrderVas].[vas_field] AS MOBILEORDERVAS_VAS_FIELD,[MobileOrderVas].[vas_id] AS MOBILEORDERVAS_VAS_ID,[MobileOrderVas].[order_id] AS MOBILEORDERVAS_ORDER_ID,[MobileOrderVas].[fee] AS MOBILEORDERVAS_FEE,[MobileOrderVas].[vas_value] AS MOBILEORDERVAS_VAS_VALUE  FROM  [MobileOrderVas]  WHERE  [MobileOrderVas].[id] = \'"+x_iId.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderVas]","["+ Configurator.MSSQLTablePrefix + "MobileOrderVas]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVAS_ID"])) {n_iId = (global::System.Nullable<int>)_oData["MOBILEORDERVAS_ID"];}else{n_iId=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVAS_CDATE"])) {n_dCdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERVAS_CDATE"];}else{n_dCdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVAS_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["MOBILEORDERVAS_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVAS_MULTI_ID"])) {n_iMulti_id = (global::System.Nullable<int>)_oData["MOBILEORDERVAS_MULTI_ID"];}else{n_iMulti_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVAS_VAS_FIELD"])) {n_sVas_field = (string)_oData["MOBILEORDERVAS_VAS_FIELD"];}else{n_sVas_field=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVAS_VAS_ID"])) {n_iVas_id = (global::System.Nullable<int>)_oData["MOBILEORDERVAS_VAS_ID"];}else{n_iVas_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVAS_ORDER_ID"])) {n_iOrder_id = (global::System.Nullable<int>)_oData["MOBILEORDERVAS_ORDER_ID"];}else{n_iOrder_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVAS_FEE"])) {n_sFee = (string)_oData["MOBILEORDERVAS_FEE"];}else{n_sFee=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVAS_VAS_VALUE"])) {n_sVas_value = (string)_oData["MOBILEORDERVAS_VAS_VALUE"];}else{n_sVas_value=global::System.String.Empty;}
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
            if (n_bActive==null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_iMulti_id==null && !(n_oTableSet.Fields(Para.multi_id).IsNullable)) return false;
            if (n_sVas_field==null && !(n_oTableSet.Fields(Para.vas_field).IsNullable)) return false;
            if (n_iVas_id==null && !(n_oTableSet.Fields(Para.vas_id).IsNullable)) return false;
            if (n_iOrder_id==null && !(n_oTableSet.Fields(Para.order_id).IsNullable)) return false;
            if (n_sFee==null && !(n_oTableSet.Fields(Para.fee).IsNullable)) return false;
            if (n_sVas_value==null && !(n_oTableSet.Fields(Para.vas_value).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(MobileOrderVasEntity)) || (x_oObj is MobileOrderVasEntity)) return MobileOrderVasRepository.Instance();
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
        public MobileOrderVasInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(MobileOrderVasInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public global::System.Nullable<int> GetId(){return this.id;}
        public global::System.Nullable<DateTime> GetCdate(){return this.cdate;}
        public global::System.Nullable<bool> GetActive(){return this.active;}
        public string GetVas_field(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.vas_field)) { return string.Empty; }
            return this.vas_field;
        }
        public global::System.Nullable<int> GetVas_id(){return this.vas_id;}
        public global::System.Nullable<int> GetOrder_id(){return this.order_id;}
        public string GetFee(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.fee)) { return string.Empty; }
            return this.fee;
        }
        public string GetVas_value(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.vas_value)) { return string.Empty; }
            return this.vas_value;
        }
        public global::System.Nullable<int> GetMulti_id(){return this.multi_id;}
        
        public bool SetId(global::System.Nullable<int> value){
            this.id=value;
            return true;
        }
        public bool SetCdate(global::System.Nullable<DateTime> value){
            this.cdate=value;
            return true;
        }
        public bool SetActive(global::System.Nullable<bool> value){
            this.active=value;
            return true;
        }
        public bool SetVas_field(string value){
            this.vas_field=value;
            return true;
        }
        public bool SetVas_id(global::System.Nullable<int> value){
            this.vas_id=value;
            return true;
        }
        public bool SetOrder_id(global::System.Nullable<int> value){
            this.order_id=value;
            return true;
        }
        public bool SetFee(string value){
            this.fee=value;
            return true;
        }
        public bool SetVas_value(string value){
            this.vas_value=value;
            return true;
        }
        public bool SetMulti_id(global::System.Nullable<int> value){
            this.multi_id=value;
            return true;
        }
        
        public Field GetIdTable(){
            return n_oTableSet.Fields(Para.id);
        }
        public Field GetCdateTable(){
            return n_oTableSet.Fields(Para.cdate);
        }
        public Field GetActiveTable(){
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetVas_fieldTable(){
            return n_oTableSet.Fields(Para.vas_field);
        }
        public Field GetVas_idTable(){
            return n_oTableSet.Fields(Para.vas_id);
        }
        public Field GetOrder_idTable(){
            return n_oTableSet.Fields(Para.order_id);
        }
        public Field GetFeeTable(){
            return n_oTableSet.Fields(Para.fee);
        }
        public Field GetVas_valueTable(){
            return n_oTableSet.Fields(Para.vas_value);
        }
        public Field GetMulti_idTable(){
            return n_oTableSet.Fields(Para.multi_id);
        }
        #endregion
        
        #region Addtional Get & Set
        public MobileRetentionOrder GetMobileRetentionOrderMobileOrderVas() {
            return MobileRetentionOrderMobileOrderVas;
        }
        
        public bool SetMobileRetentionOrderMobileOrderVas(MobileRetentionOrder value) {
            MobileRetentionOrderMobileOrderVas = value;
            return true;
        }
        
        public global::System.Data.DataSet GetMobileRetentionOrderMobileOrderVasDataSet(){
            return MobileRetentionOrderMobileOrderVasDataSet;
        }
        
        public bool SetMobileRetentionOrderMobileOrderVasDataSet(global::System.Data.DataSet value) {
            MobileRetentionOrderMobileOrderVasDataSet = value;
            return true;
        }
        
        
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
        
        public bool EqualID(MobileOrderVas x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(MobileOrderVas x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_iId.Equals(x_oObj.id)){ return false; }
            if(!this.n_dCdate.Equals(x_oObj.cdate)){ return false; }
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_iMulti_id.Equals(x_oObj.multi_id)){ return false; }
            if(!this.n_sVas_field.Equals(x_oObj.vas_field)){ return false; }
            if(!this.n_iVas_id.Equals(x_oObj.vas_id)){ return false; }
            if(!this.n_iOrder_id.Equals(x_oObj.order_id)){ return false; }
            if(!this.n_sFee.Equals(x_oObj.fee)){ return false; }
            if(!this.n_sVas_value.Equals(x_oObj.vas_value)){ return false; }
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
            string _sQuery = "UPDATE  [MobileOrderVas]  SET  [cdate]=@cdate,[active]=@active,[multi_id]=@multi_id,[vas_field]=@vas_field,[vas_id]=@vas_id,[order_id]=@order_id,[fee]=@fee,[vas_value]=@vas_value  WHERE [MobileOrderVas].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderVas]","["+ Configurator.MSSQLTablePrefix + "MobileOrderVas]"); }
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
            if(n_bActive==null){  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=n_bActive; }
            if(n_iMulti_id==null){  _oCmd.Parameters.Add("@multi_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@multi_id", global::System.Data.SqlDbType.Int).Value=n_iMulti_id; }
            if(n_sVas_field==null){  _oCmd.Parameters.Add("@vas_field", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@vas_field", global::System.Data.SqlDbType.NVarChar,100).Value=n_sVas_field; }
            if(n_iVas_id==null){  _oCmd.Parameters.Add("@vas_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@vas_id", global::System.Data.SqlDbType.Int).Value=n_iVas_id; }
            if(n_iOrder_id==null){  _oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=n_iOrder_id; }
            if(n_sFee==null){  _oCmd.Parameters.Add("@fee", global::System.Data.SqlDbType.NVarChar,200).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@fee", global::System.Data.SqlDbType.NVarChar,200).Value=n_sFee; }
            if(n_sVas_value==null){  _oCmd.Parameters.Add("@vas_value", global::System.Data.SqlDbType.NVarChar,200).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@vas_value", global::System.Data.SqlDbType.NVarChar,200).Value=n_sVas_value; }
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
        /// Summary description for table [MobileOrderVas] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iId==null) { return false; }
            string _sQuery="DELETE FROM  [MobileOrderVas]  WHERE [MobileOrderVas].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderVas]","["+ Configurator.MSSQLTablePrefix + "MobileOrderVas]"); }
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
        /// Summary description for table [MobileOrderVas] Object Base Clone
        /// </summary>
        
        public MobileOrderVas DeepClone()
        {
            MobileOrderVas _oMobileOrderVas_Clone = new MobileOrderVas();
            _oMobileOrderVas_Clone.id = this.n_iId;
            _oMobileOrderVas_Clone.cdate = this.n_dCdate;
            _oMobileOrderVas_Clone.active = this.n_bActive;
            _oMobileOrderVas_Clone.multi_id = this.n_iMulti_id;
            _oMobileOrderVas_Clone.vas_field = this.n_sVas_field;
            _oMobileOrderVas_Clone.vas_id = this.n_iVas_id;
            _oMobileOrderVas_Clone.order_id = this.n_iOrder_id;
            _oMobileOrderVas_Clone.fee = this.n_sFee;
            _oMobileOrderVas_Clone.vas_value = this.n_sVas_value;
            _oMobileOrderVas_Clone.SetFound(this.n_bFound);
            _oMobileOrderVas_Clone.SetDB(this.n_oDB);
            _oMobileOrderVas_Clone.SetRow(this.n_oRow);
            _oMobileOrderVas_Clone.SetTbl(this.n_oTbl);
            _oMobileOrderVas_Clone.SetTableSet(this.n_oTableSet);
            MobileRetentionOrderMobileOrderVas=null;
            _oMobileOrderVas_Clone.MobileRetentionOrderMobileOrderVas = this.MobileRetentionOrderMobileOrderVas.DeepClone();
            
            return _oMobileOrderVas_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_iId=null;
            n_dCdate=null;
            n_bActive=null;
            n_iMulti_id=null;
            n_sVas_field=global::System.String.Empty;
            n_iVas_id=null;
            n_iOrder_id=null;
            n_sFee=global::System.String.Empty;
            n_sVas_value=global::System.String.Empty;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = MobileOrderVasInfoDLL.CreateInfoInstanceObject();
            n_oMobileRetentionOrderMobileOrderVas=null;
        }
        #endregion
    }
}


