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
///-- Create date: <Create Date 2010-12-17>
///-- Description:	<Description,Table :[MobileOrderIssueRestrictionColumn],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [MobileOrderIssueRestrictionColumn] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"MobileOrderIssueRestrictionColumn")]
    public class MobileOrderIssueRestrictionColumnEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        
        protected string n_sAction_type=global::System.String.Empty;
        #region action_type
        [System.Data.Linq.Mapping.Column(Name="[action_type]", Storage="n_sAction_type")]
        public string action_type{
            get{
                return this.n_sAction_type;
            }
            set{
                this.n_sAction_type=value;
            }
        }
        #endregion action_type
        
        
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
        
        
        protected string n_sRestriction_column=global::System.String.Empty;
        #region restriction_column
        [System.Data.Linq.Mapping.Column(Name="[restriction_column]", Storage="n_sRestriction_column")]
        public string restriction_column{
            get{
                return this.n_sRestriction_column;
            }
            set{
                this.n_sRestriction_column=value;
            }
        }
        #endregion restriction_column
        
        
        protected string n_sRestriction_value=global::System.String.Empty;
        #region restriction_value
        [System.Data.Linq.Mapping.Column(Name="[restriction_value]", Storage="n_sRestriction_value")]
        public string restriction_value{
            get{
                return this.n_sRestriction_value;
            }
            set{
                this.n_sRestriction_value=value;
            }
        }
        #endregion restriction_value
        
        
        protected string n_sRestriction_table=global::System.String.Empty;
        #region restriction_table
        [System.Data.Linq.Mapping.Column(Name="[restriction_table]", Storage="n_sRestriction_table")]
        public string restriction_table{
            get{
                return this.n_sRestriction_table;
            }
            set{
                this.n_sRestriction_table=value;
            }
        }
        #endregion restriction_table
        
        
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
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private MobileOrderIssueRestrictionColumnInfo n_oTableSet = MobileOrderIssueRestrictionColumnInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string active="active";
            public const string cdate="cdate";
            public const string cid="cid";
            public const string restriction_id="restriction_id";
            public const string restriction_column="restriction_column";
            public const string restriction_value="restriction_value";
            public const string restriction_table="restriction_table";
            public const string action_type="action_type";
            public const string mid="mid";
            public const string MobileOrderIssueRestrictionColumn_table_name="MobileOrderIssueRestrictionColumn";
            public static string TableName() { return MobileOrderIssueRestrictionColumn_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public MobileOrderIssueRestrictionColumnEntity(){
            Init();
        }
        public MobileOrderIssueRestrictionColumnEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public MobileOrderIssueRestrictionColumnEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid){
            n_oDB=x_oDB;
            this.Load(x_iMid);
            Init();
        }
        
        ~MobileOrderIssueRestrictionColumnEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iMid){
            if (n_oDB==null) { return false; }
            if (x_iMid==null) { return false; }
            string _sQuery = "SELECT   [MobileOrderIssueRestrictionColumn].[action_type] AS MOBILEORDERISSUERESTRICTIONCOLUMN_ACTION_TYPE,[MobileOrderIssueRestrictionColumn].[cdate] AS MOBILEORDERISSUERESTRICTIONCOLUMN_CDATE,[MobileOrderIssueRestrictionColumn].[cid] AS MOBILEORDERISSUERESTRICTIONCOLUMN_CID,[MobileOrderIssueRestrictionColumn].[active] AS MOBILEORDERISSUERESTRICTIONCOLUMN_ACTIVE,[MobileOrderIssueRestrictionColumn].[restriction_id] AS MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_ID,[MobileOrderIssueRestrictionColumn].[restriction_column] AS MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_COLUMN,[MobileOrderIssueRestrictionColumn].[restriction_value] AS MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_VALUE,[MobileOrderIssueRestrictionColumn].[restriction_table] AS MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_TABLE,[MobileOrderIssueRestrictionColumn].[mid] AS MOBILEORDERISSUERESTRICTIONCOLUMN_MID  FROM  [MobileOrderIssueRestrictionColumn]  WHERE  [MobileOrderIssueRestrictionColumn].[mid] = \'"+x_iMid.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderIssueRestrictionColumn]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestrictionColumn]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_ACTION_TYPE"])) {n_sAction_type = (string)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_ACTION_TYPE"];}else{n_sAction_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_CDATE"])) {n_dCdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_CDATE"];}else{n_dCdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_CID"])) {n_sCid = (string)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_CID"];}else{n_sCid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_ID"])) {n_iRestriction_id = (global::System.Nullable<int>)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_ID"];}else{n_iRestriction_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_COLUMN"])) {n_sRestriction_column = (string)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_COLUMN"];}else{n_sRestriction_column=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_VALUE"])) {n_sRestriction_value = (string)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_VALUE"];}else{n_sRestriction_value=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_TABLE"])) {n_sRestriction_table = (string)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_TABLE"];}else{n_sRestriction_table=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_MID"])) {n_iMid = (global::System.Nullable<int>)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_MID"];}else{n_iMid=null;}
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
            if (n_sAction_type==null && !(n_oTableSet.Fields(Para.action_type).IsNullable)) return false;
            if (n_dCdate==null && !(n_oTableSet.Fields(Para.cdate).IsNullable)) return false;
            if (n_sCid==null && !(n_oTableSet.Fields(Para.cid).IsNullable)) return false;
            if (n_bActive==null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_iRestriction_id==null && !(n_oTableSet.Fields(Para.restriction_id).IsNullable)) return false;
            if (n_sRestriction_column==null && !(n_oTableSet.Fields(Para.restriction_column).IsNullable)) return false;
            if (n_sRestriction_value==null && !(n_oTableSet.Fields(Para.restriction_value).IsNullable)) return false;
            if (n_sRestriction_table==null && !(n_oTableSet.Fields(Para.restriction_table).IsNullable)) return false;
            if(!x_bInsert){
                if (n_iMid==null && !(n_oTableSet.Fields(Para.mid).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(MobileOrderIssueRestrictionColumnEntity)) || (x_oObj is MobileOrderIssueRestrictionColumnEntity)) return MobileOrderIssueRestrictionColumnRepository.Instance();
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
        public MobileOrderIssueRestrictionColumnInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(MobileOrderIssueRestrictionColumnInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public global::System.Nullable<bool> GetActive(){return this.active;}
        public global::System.Nullable<DateTime> GetCdate(){return this.cdate;}
        public string GetCid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.cid)) { return string.Empty; }
            return this.cid;
        }
        public global::System.Nullable<int> GetRestriction_id(){return this.restriction_id;}
        public string GetRestriction_column(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.restriction_column)) { return string.Empty; }
            return this.restriction_column;
        }
        public string GetRestriction_value(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.restriction_value)) { return string.Empty; }
            return this.restriction_value;
        }
        public string GetRestriction_table(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.restriction_table)) { return string.Empty; }
            return this.restriction_table;
        }
        public string GetAction_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.action_type)) { return string.Empty; }
            return this.action_type;
        }
        public global::System.Nullable<int> GetMid(){return this.mid;}
        
        public bool SetActive(global::System.Nullable<bool> value){
            this.active=value;
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
        public bool SetRestriction_id(global::System.Nullable<int> value){
            this.restriction_id=value;
            return true;
        }
        public bool SetRestriction_column(string value){
            this.restriction_column=value;
            return true;
        }
        public bool SetRestriction_value(string value){
            this.restriction_value=value;
            return true;
        }
        public bool SetRestriction_table(string value){
            this.restriction_table=value;
            return true;
        }
        public bool SetAction_type(string value){
            this.action_type=value;
            return true;
        }
        public bool SetMid(global::System.Nullable<int> value){
            this.mid=value;
            return true;
        }
        
        public Field GetActiveTable(){
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetCdateTable(){
            return n_oTableSet.Fields(Para.cdate);
        }
        public Field GetCidTable(){
            return n_oTableSet.Fields(Para.cid);
        }
        public Field GetRestriction_idTable(){
            return n_oTableSet.Fields(Para.restriction_id);
        }
        public Field GetRestriction_columnTable(){
            return n_oTableSet.Fields(Para.restriction_column);
        }
        public Field GetRestriction_valueTable(){
            return n_oTableSet.Fields(Para.restriction_value);
        }
        public Field GetRestriction_tableTable(){
            return n_oTableSet.Fields(Para.restriction_table);
        }
        public Field GetAction_typeTable(){
            return n_oTableSet.Fields(Para.action_type);
        }
        public Field GetMidTable(){
            return n_oTableSet.Fields(Para.mid);
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
        
        public bool EqualID(MobileOrderIssueRestrictionColumn x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iMid.Equals(x_oObj.mid)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(MobileOrderIssueRestrictionColumn x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_sAction_type.Equals(x_oObj.action_type)){ return false; }
            if(!this.n_dCdate.Equals(x_oObj.cdate)){ return false; }
            if(!this.n_sCid.Equals(x_oObj.cid)){ return false; }
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_iRestriction_id.Equals(x_oObj.restriction_id)){ return false; }
            if(!this.n_sRestriction_column.Equals(x_oObj.restriction_column)){ return false; }
            if(!this.n_sRestriction_value.Equals(x_oObj.restriction_value)){ return false; }
            if(!this.n_sRestriction_table.Equals(x_oObj.restriction_table)){ return false; }
            if(!this.n_iMid.Equals(x_oObj.mid)){ return false; }
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
            string _sQuery = "UPDATE  [MobileOrderIssueRestrictionColumn]  SET  [action_type]=@action_type,[cdate]=@cdate,[cid]=@cid,[active]=@active,[restriction_id]=@restriction_id,[restriction_column]=@restriction_column,[restriction_value]=@restriction_value,[restriction_table]=@restriction_table  WHERE [MobileOrderIssueRestrictionColumn].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderIssueRestrictionColumn]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestrictionColumn]"); }
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
            if(n_sAction_type==null){  _oCmd.Parameters.Add("@action_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@action_type", global::System.Data.SqlDbType.NVarChar,50).Value=n_sAction_type; }
            if(n_dCdate==null){  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=n_dCdate; }
            if(n_sCid==null){  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=n_sCid; }
            if(n_bActive==null){  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=n_bActive; }
            if(n_iRestriction_id==null){  _oCmd.Parameters.Add("@restriction_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@restriction_id", global::System.Data.SqlDbType.Int).Value=n_iRestriction_id; }
            if(n_sRestriction_column==null){  _oCmd.Parameters.Add("@restriction_column", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@restriction_column", global::System.Data.SqlDbType.NVarChar,250).Value=n_sRestriction_column; }
            if(n_sRestriction_value==null){  _oCmd.Parameters.Add("@restriction_value", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@restriction_value", global::System.Data.SqlDbType.NVarChar,250).Value=n_sRestriction_value; }
            if(n_sRestriction_table==null){  _oCmd.Parameters.Add("@restriction_table", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@restriction_table", global::System.Data.SqlDbType.NVarChar,250).Value=n_sRestriction_table; }
            if(n_iMid==null){  _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value=n_iMid; }
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
        /// Summary description for table [MobileOrderIssueRestrictionColumn] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iMid==null) { return false; }
            string _sQuery="DELETE FROM  [MobileOrderIssueRestrictionColumn]  WHERE [MobileOrderIssueRestrictionColumn].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderIssueRestrictionColumn]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestrictionColumn]"); }
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
        /// Summary description for table [MobileOrderIssueRestrictionColumn] Object Base Clone
        /// </summary>
        
        public MobileOrderIssueRestrictionColumn DeepClone()
        {
            MobileOrderIssueRestrictionColumn _oMobileOrderIssueRestrictionColumn_Clone = new MobileOrderIssueRestrictionColumn();
            _oMobileOrderIssueRestrictionColumn_Clone.action_type = this.n_sAction_type;
            _oMobileOrderIssueRestrictionColumn_Clone.cdate = this.n_dCdate;
            _oMobileOrderIssueRestrictionColumn_Clone.cid = this.n_sCid;
            _oMobileOrderIssueRestrictionColumn_Clone.active = this.n_bActive;
            _oMobileOrderIssueRestrictionColumn_Clone.restriction_id = this.n_iRestriction_id;
            _oMobileOrderIssueRestrictionColumn_Clone.restriction_column = this.n_sRestriction_column;
            _oMobileOrderIssueRestrictionColumn_Clone.restriction_value = this.n_sRestriction_value;
            _oMobileOrderIssueRestrictionColumn_Clone.restriction_table = this.n_sRestriction_table;
            _oMobileOrderIssueRestrictionColumn_Clone.mid = this.n_iMid;
            _oMobileOrderIssueRestrictionColumn_Clone.SetFound(this.n_bFound);
            _oMobileOrderIssueRestrictionColumn_Clone.SetDB(this.n_oDB);
            _oMobileOrderIssueRestrictionColumn_Clone.SetRow(this.n_oRow);
            _oMobileOrderIssueRestrictionColumn_Clone.SetTbl(this.n_oTbl);
            _oMobileOrderIssueRestrictionColumn_Clone.SetTableSet(this.n_oTableSet);
            
            return _oMobileOrderIssueRestrictionColumn_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_sAction_type=global::System.String.Empty;
            n_dCdate=null;
            n_sCid=global::System.String.Empty;
            n_bActive=null;
            n_iRestriction_id=null;
            n_sRestriction_column=global::System.String.Empty;
            n_sRestriction_value=global::System.String.Empty;
            n_sRestriction_table=global::System.String.Empty;
            n_iMid=null;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = MobileOrderIssueRestrictionColumnInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


