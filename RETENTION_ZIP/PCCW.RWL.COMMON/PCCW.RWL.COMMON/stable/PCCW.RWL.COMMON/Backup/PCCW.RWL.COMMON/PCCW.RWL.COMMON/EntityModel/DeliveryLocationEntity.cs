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
///-- Create date: <Create Date 2011-10-31>
///-- Description:	<Description,Table :[DeliveryLocation],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [DeliveryLocation] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"DeliveryLocation")]
    public class DeliveryLocationEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        
        protected string n_sLocation=global::System.String.Empty;
        #region location
        [System.Data.Linq.Mapping.Column(Name="[location]", Storage="n_sLocation")]
        public string location{
            get{
                return this.n_sLocation;
            }
            set{
                this.n_sLocation=value;
            }
        }
        #endregion location
        
        
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
        
        
        protected string n_sArea=global::System.String.Empty;
        #region area
        [System.Data.Linq.Mapping.Column(Name="[area]", Storage="n_sArea")]
        public string area{
            get{
                return this.n_sArea;
            }
            set{
                this.n_sArea=value;
            }
        }
        #endregion area
        
        
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
        private DeliveryLocationInfo n_oTableSet = DeliveryLocationInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string id="id";
            public const string cdate="cdate";
            public const string cid="cid";
            public const string location="location";
            public const string fee="fee";
            public const string area="area";
            public const string active="active";
            public const string DeliveryLocation_table_name="DeliveryLocation";
            public static string TableName() { return DeliveryLocation_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public DeliveryLocationEntity(){
            Init();
        }
        public DeliveryLocationEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public DeliveryLocationEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId){
            n_oDB=x_oDB;
            this.Load(x_iId);
            Init();
        }
        
        ~DeliveryLocationEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iId){
            if (n_oDB==null) { return false; }
            if (x_iId==null) { return false; }
            string _sQuery = "SELECT   [DeliveryLocation].[active] AS DELIVERYLOCATION_ACTIVE,[DeliveryLocation].[cdate] AS DELIVERYLOCATION_CDATE,[DeliveryLocation].[cid] AS DELIVERYLOCATION_CID,[DeliveryLocation].[location] AS DELIVERYLOCATION_LOCATION,[DeliveryLocation].[fee] AS DELIVERYLOCATION_FEE,[DeliveryLocation].[area] AS DELIVERYLOCATION_AREA,[DeliveryLocation].[id] AS DELIVERYLOCATION_ID  FROM  [DeliveryLocation]  WHERE  [DeliveryLocation].[id] = \'"+x_iId.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DeliveryLocation]","["+ Configurator.MSSQLTablePrefix + "DeliveryLocation]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYLOCATION_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["DELIVERYLOCATION_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYLOCATION_CDATE"])) {n_dCdate = (global::System.Nullable<DateTime>)_oData["DELIVERYLOCATION_CDATE"];}else{n_dCdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYLOCATION_CID"])) {n_sCid = (string)_oData["DELIVERYLOCATION_CID"];}else{n_sCid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYLOCATION_LOCATION"])) {n_sLocation = (string)_oData["DELIVERYLOCATION_LOCATION"];}else{n_sLocation=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYLOCATION_FEE"])) {n_sFee = (string)_oData["DELIVERYLOCATION_FEE"];}else{n_sFee=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYLOCATION_AREA"])) {n_sArea = (string)_oData["DELIVERYLOCATION_AREA"];}else{n_sArea=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYLOCATION_ID"])) {n_iId = (global::System.Nullable<int>)_oData["DELIVERYLOCATION_ID"];}else{n_iId=null;}
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
            if (n_bActive==null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_dCdate==null && !(n_oTableSet.Fields(Para.cdate).IsNullable)) return false;
            if (n_sCid==null && !(n_oTableSet.Fields(Para.cid).IsNullable)) return false;
            if (n_sLocation==null && !(n_oTableSet.Fields(Para.location).IsNullable)) return false;
            if (n_sFee==null && !(n_oTableSet.Fields(Para.fee).IsNullable)) return false;
            if (n_sArea==null && !(n_oTableSet.Fields(Para.area).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(DeliveryLocationEntity)) || (x_oObj is DeliveryLocationEntity)) return DeliveryLocationRepository.Instance();
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
        public DeliveryLocationInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(DeliveryLocationInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public global::System.Nullable<int> GetId(){return this.id;}
        public global::System.Nullable<DateTime> GetCdate(){return this.cdate;}
        public string GetCid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.cid)) { return string.Empty; }
            return this.cid;
        }
        public string GetLocation(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.location)) { return string.Empty; }
            return this.location;
        }
        public string GetFee(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.fee)) { return string.Empty; }
            return this.fee;
        }
        public string GetArea(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.area)) { return string.Empty; }
            return this.area;
        }
        public global::System.Nullable<bool> GetActive(){return this.active;}
        
        public bool SetId(global::System.Nullable<int> value){
            this.id=value;
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
        public bool SetLocation(string value){
            this.location=value;
            return true;
        }
        public bool SetFee(string value){
            this.fee=value;
            return true;
        }
        public bool SetArea(string value){
            this.area=value;
            return true;
        }
        public bool SetActive(global::System.Nullable<bool> value){
            this.active=value;
            return true;
        }
        
        public Field GetIdTable(){
            return n_oTableSet.Fields(Para.id);
        }
        public Field GetCdateTable(){
            return n_oTableSet.Fields(Para.cdate);
        }
        public Field GetCidTable(){
            return n_oTableSet.Fields(Para.cid);
        }
        public Field GetLocationTable(){
            return n_oTableSet.Fields(Para.location);
        }
        public Field GetFeeTable(){
            return n_oTableSet.Fields(Para.fee);
        }
        public Field GetAreaTable(){
            return n_oTableSet.Fields(Para.area);
        }
        public Field GetActiveTable(){
            return n_oTableSet.Fields(Para.active);
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
        
        public bool EqualID(DeliveryLocation x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(DeliveryLocation x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_dCdate.Equals(x_oObj.cdate)){ return false; }
            if(!this.n_sCid.Equals(x_oObj.cid)){ return false; }
            if(!this.n_sLocation.Equals(x_oObj.location)){ return false; }
            if(!this.n_sFee.Equals(x_oObj.fee)){ return false; }
            if(!this.n_sArea.Equals(x_oObj.area)){ return false; }
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
            string _sQuery = "UPDATE  [DeliveryLocation]  SET  [active]=@active,[cdate]=@cdate,[cid]=@cid,[location]=@location,[fee]=@fee,[area]=@area  WHERE [DeliveryLocation].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DeliveryLocation]","["+ Configurator.MSSQLTablePrefix + "DeliveryLocation]"); }
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
            if(n_bActive==null){  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=n_bActive; }
            if(n_dCdate==null){  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=n_dCdate; }
            if(n_sCid==null){  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=n_sCid; }
            if(n_sLocation==null){  _oCmd.Parameters.Add("@location", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@location", global::System.Data.SqlDbType.NVarChar,100).Value=n_sLocation; }
            if(n_sFee==null){  _oCmd.Parameters.Add("@fee", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@fee", global::System.Data.SqlDbType.NVarChar,50).Value=n_sFee; }
            if(n_sArea==null){  _oCmd.Parameters.Add("@area", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@area", global::System.Data.SqlDbType.NVarChar,100).Value=n_sArea; }
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
        /// Summary description for table [DeliveryLocation] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iId==null) { return false; }
            string _sQuery="DELETE FROM  [DeliveryLocation]  WHERE [DeliveryLocation].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DeliveryLocation]","["+ Configurator.MSSQLTablePrefix + "DeliveryLocation]"); }
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
        /// Summary description for table [DeliveryLocation] Object Base Clone
        /// </summary>
        
        public DeliveryLocation DeepClone()
        {
            DeliveryLocation _oDeliveryLocation_Clone = new DeliveryLocation();
            _oDeliveryLocation_Clone.active = this.n_bActive;
            _oDeliveryLocation_Clone.cdate = this.n_dCdate;
            _oDeliveryLocation_Clone.cid = this.n_sCid;
            _oDeliveryLocation_Clone.location = this.n_sLocation;
            _oDeliveryLocation_Clone.fee = this.n_sFee;
            _oDeliveryLocation_Clone.area = this.n_sArea;
            _oDeliveryLocation_Clone.id = this.n_iId;
            _oDeliveryLocation_Clone.SetFound(this.n_bFound);
            _oDeliveryLocation_Clone.SetDB(this.n_oDB);
            _oDeliveryLocation_Clone.SetRow(this.n_oRow);
            _oDeliveryLocation_Clone.SetTbl(this.n_oTbl);
            _oDeliveryLocation_Clone.SetTableSet(this.n_oTableSet);
            
            return _oDeliveryLocation_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_bActive=null;
            n_dCdate=null;
            n_sCid=global::System.String.Empty;
            n_sLocation=global::System.String.Empty;
            n_sFee=global::System.String.Empty;
            n_sArea=global::System.String.Empty;
            n_iId=null;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = DeliveryLocationInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


