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
///-- Create date: <Create Date 2010-12-17>
///-- Description:	<Description,Table :[MobileOrderIssueRestriction],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [MobileOrderIssueRestriction] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"MobileOrderIssueRestriction")]
    public class MobileOrderIssueRestrictionEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        
        protected string n_sName=global::System.String.Empty;
        #region name
        [System.Data.Linq.Mapping.Column(Name="[name]", Storage="n_sName")]
        public string name{
            get{
                return this.n_sName;
            }
            set{
                this.n_sName=value;
            }
        }
        #endregion name
        
        
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
        
        
        protected string n_sType=global::System.String.Empty;
        #region type
        [System.Data.Linq.Mapping.Column(Name="[type]", Storage="n_sType")]
        public string type{
            get{
                return this.n_sType;
            }
            set{
                this.n_sType=value;
            }
        }
        #endregion type
        
        
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
        
        
        protected global::System.Nullable<int> n_iRestriction_id=null;
        #region restriction_id
        [System.Data.Linq.Mapping.Column(Name="[restriction_id]", Storage="n_iRestriction_id")]
        public global::System.Nullable<int> restriction_id{
            get{
                return this.n_iRestriction_id;
            }
            set{
                this.n_iRestriction_id=value;
            }
        }
        #endregion restriction_id
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private MobileOrderIssueRestrictionInfo n_oTableSet = MobileOrderIssueRestrictionInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string name="name";
            public const string cdate="cdate";
            public const string cid="cid";
            public const string type="type";
            public const string active="active";
            public const string restriction_id="restriction_id";
            public const string MobileOrderIssueRestriction_table_name="MobileOrderIssueRestriction";
            public static string TableName() { return MobileOrderIssueRestriction_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public MobileOrderIssueRestrictionEntity(){
            Init();
        }
        public MobileOrderIssueRestrictionEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public MobileOrderIssueRestrictionEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iRestriction_id){
            n_oDB=x_oDB;
            this.Load(x_iRestriction_id);
            Init();
        }
        
        ~MobileOrderIssueRestrictionEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iRestriction_id){
            if (n_oDB==null) { return false; }
            if (x_iRestriction_id==null) { return false; }
            string _sQuery = "SELECT   [MobileOrderIssueRestriction].[name] AS MOBILEORDERISSUERESTRICTION_NAME,[MobileOrderIssueRestriction].[cdate] AS MOBILEORDERISSUERESTRICTION_CDATE,[MobileOrderIssueRestriction].[cid] AS MOBILEORDERISSUERESTRICTION_CID,[MobileOrderIssueRestriction].[type] AS MOBILEORDERISSUERESTRICTION_TYPE,[MobileOrderIssueRestriction].[active] AS MOBILEORDERISSUERESTRICTION_ACTIVE,[MobileOrderIssueRestriction].[restriction_id] AS MOBILEORDERISSUERESTRICTION_RESTRICTION_ID  FROM  [MobileOrderIssueRestriction]  WHERE  [MobileOrderIssueRestriction].[restriction_id] = \'"+x_iRestriction_id.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderIssueRestriction]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestriction]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTION_NAME"])) {n_sName = (string)_oData["MOBILEORDERISSUERESTRICTION_NAME"];}else{n_sName=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTION_CDATE"])) {n_dCdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERISSUERESTRICTION_CDATE"];}else{n_dCdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTION_CID"])) {n_sCid = (string)_oData["MOBILEORDERISSUERESTRICTION_CID"];}else{n_sCid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTION_TYPE"])) {n_sType = (string)_oData["MOBILEORDERISSUERESTRICTION_TYPE"];}else{n_sType=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTION_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["MOBILEORDERISSUERESTRICTION_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTION_RESTRICTION_ID"])) {n_iRestriction_id = (global::System.Nullable<int>)_oData["MOBILEORDERISSUERESTRICTION_RESTRICTION_ID"];}else{n_iRestriction_id=null;}
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
            if (n_sName==null && !(n_oTableSet.Fields(Para.name).IsNullable)) return false;
            if (n_dCdate==null && !(n_oTableSet.Fields(Para.cdate).IsNullable)) return false;
            if (n_sCid==null && !(n_oTableSet.Fields(Para.cid).IsNullable)) return false;
            if (n_sType==null && !(n_oTableSet.Fields(Para.type).IsNullable)) return false;
            if (n_bActive==null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if(!x_bInsert){
                if (n_iRestriction_id==null && !(n_oTableSet.Fields(Para.restriction_id).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(MobileOrderIssueRestrictionEntity)) || (x_oObj is MobileOrderIssueRestrictionEntity)) return MobileOrderIssueRestrictionRepository.Instance();
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
        public MobileOrderIssueRestrictionInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(MobileOrderIssueRestrictionInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public string GetName(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.name)) { return string.Empty; }
            return this.name;
        }
        public global::System.Nullable<DateTime> GetCdate(){return this.cdate;}
        public string GetCid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.cid)) { return string.Empty; }
            return this.cid;
        }
        public string GetType(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.type)) { return string.Empty; }
            return this.type;
        }
        public global::System.Nullable<bool> GetActive(){return this.active;}
        public global::System.Nullable<int> GetRestriction_id(){return this.restriction_id;}
        
        public bool SetName(string value){
            this.name=value;
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
        public bool SetType(string value){
            this.type=value;
            return true;
        }
        public bool SetActive(global::System.Nullable<bool> value){
            this.active=value;
            return true;
        }
        public bool SetRestriction_id(global::System.Nullable<int> value){
            this.restriction_id=value;
            return true;
        }
        
        public Field GetNameTable(){
            return n_oTableSet.Fields(Para.name);
        }
        public Field GetCdateTable(){
            return n_oTableSet.Fields(Para.cdate);
        }
        public Field GetCidTable(){
            return n_oTableSet.Fields(Para.cid);
        }
        public Field GetTypeTable(){
            return n_oTableSet.Fields(Para.type);
        }
        public Field GetActiveTable(){
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetRestriction_idTable(){
            return n_oTableSet.Fields(Para.restriction_id);
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
        
        public bool EqualID(MobileOrderIssueRestriction x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iRestriction_id.Equals(x_oObj.restriction_id)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(MobileOrderIssueRestriction x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_sName.Equals(x_oObj.name)){ return false; }
            if(!this.n_dCdate.Equals(x_oObj.cdate)){ return false; }
            if(!this.n_sCid.Equals(x_oObj.cid)){ return false; }
            if(!this.n_sType.Equals(x_oObj.type)){ return false; }
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_iRestriction_id.Equals(x_oObj.restriction_id)){ return false; }
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
            if(!n_iRestriction_id.Equals(null)){
                _bResult=this.Load(n_iRestriction_id);
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
            if (n_iRestriction_id==null) { return false; }
            if(!Vaild(false)){ return false; }
            string _sQuery = "UPDATE  [MobileOrderIssueRestriction]  SET  [name]=@name,[cdate]=@cdate,[cid]=@cid,[type]=@type,[active]=@active  WHERE [MobileOrderIssueRestriction].[restriction_id]=@restriction_id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderIssueRestriction]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestriction]"); }
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
            if(n_sName==null){  _oCmd.Parameters.Add("@name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@name", global::System.Data.SqlDbType.NVarChar,250).Value=n_sName; }
            if(n_dCdate==null){  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=n_dCdate; }
            if(n_sCid==null){  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=n_sCid; }
            if(n_sType==null){  _oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar,50).Value=n_sType; }
            if(n_bActive==null){  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=n_bActive; }
            if(n_iRestriction_id==null){  _oCmd.Parameters.Add("@restriction_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@restriction_id", global::System.Data.SqlDbType.Int).Value=n_iRestriction_id; }
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
        /// Summary description for table [MobileOrderIssueRestriction] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iRestriction_id==null) { return false; }
            string _sQuery="DELETE FROM  [MobileOrderIssueRestriction]  WHERE [MobileOrderIssueRestriction].[restriction_id]=@restriction_id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderIssueRestriction]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestriction]"); }
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
            _oCmd.Parameters.Add("@restriction_id", global::System.Data.SqlDbType.Int).Value = n_iRestriction_id;
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
        /// Summary description for table [MobileOrderIssueRestriction] Object Base Clone
        /// </summary>
        
        public MobileOrderIssueRestriction DeepClone()
        {
            MobileOrderIssueRestriction _oMobileOrderIssueRestriction_Clone = new MobileOrderIssueRestriction();
            _oMobileOrderIssueRestriction_Clone.name = this.n_sName;
            _oMobileOrderIssueRestriction_Clone.cdate = this.n_dCdate;
            _oMobileOrderIssueRestriction_Clone.cid = this.n_sCid;
            _oMobileOrderIssueRestriction_Clone.type = this.n_sType;
            _oMobileOrderIssueRestriction_Clone.active = this.n_bActive;
            _oMobileOrderIssueRestriction_Clone.restriction_id = this.n_iRestriction_id;
            _oMobileOrderIssueRestriction_Clone.SetFound(this.n_bFound);
            _oMobileOrderIssueRestriction_Clone.SetDB(this.n_oDB);
            _oMobileOrderIssueRestriction_Clone.SetRow(this.n_oRow);
            _oMobileOrderIssueRestriction_Clone.SetTbl(this.n_oTbl);
            _oMobileOrderIssueRestriction_Clone.SetTableSet(this.n_oTableSet);
            
            return _oMobileOrderIssueRestriction_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_sName=global::System.String.Empty;
            n_dCdate=null;
            n_sCid=global::System.String.Empty;
            n_sType=global::System.String.Empty;
            n_bActive=null;
            n_iRestriction_id=null;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = MobileOrderIssueRestrictionInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


