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
///-- Create date: <Create Date 2011-09-15>
///-- Description:	<Description,Table :[CallListUploadProfile],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [CallListUploadProfile] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"CallListUploadProfile")]
    public class CallListUploadProfileEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        
        protected global::System.Nullable<long> n_lCall_list_program_id=null;
        #region call_list_program_id
        [System.Data.Linq.Mapping.Column(Name="[call_list_program_id]", Storage="n_lCall_list_program_id")]
        public global::System.Nullable<long> call_list_program_id{
            get{
                return this.n_lCall_list_program_id;
            }
            set{
                this.n_lCall_list_program_id=value;
            }
        }
        #endregion call_list_program_id
        
        
        protected global::System.Nullable<long> n_lId=null;
        #region id
        [System.Data.Linq.Mapping.Column(Name="[id]", Storage="n_lId")]
        public global::System.Nullable<long> id{
            get{
                return this.n_lId;
            }
            set{
                this.n_lId=value;
            }
        }
        #endregion id
        
        
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
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private CallListUploadProfileInfo n_oTableSet = CallListUploadProfileInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string sdate="sdate";
            public const string id="id";
            public const string call_list_program_id="call_list_program_id";
            public const string issue_type="issue_type";
            public const string active="active";
            public const string edate="edate";
            public const string CallListUploadProfile_table_name="CallListUploadProfile";
            public static string TableName() { return CallListUploadProfile_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public CallListUploadProfileEntity(){
            Init();
        }
        public CallListUploadProfileEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public CallListUploadProfileEntity(MSSQLConnect x_oDB,global::System.Nullable<long> x_lId){
            n_oDB=x_oDB;
            this.Load(x_lId);
            Init();
        }
        
        ~CallListUploadProfileEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<long> x_lId){
            if (n_oDB==null) { return false; }
            if (x_lId==null) { return false; }
            string _sQuery = "SELECT   [CallListUploadProfile].[sdate] AS CALLLISTUPLOADPROFILE_SDATE,[CallListUploadProfile].[active] AS CALLLISTUPLOADPROFILE_ACTIVE,[CallListUploadProfile].[issue_type] AS CALLLISTUPLOADPROFILE_ISSUE_TYPE,[CallListUploadProfile].[call_list_program_id] AS CALLLISTUPLOADPROFILE_CALL_LIST_PROGRAM_ID,[CallListUploadProfile].[id] AS CALLLISTUPLOADPROFILE_ID,[CallListUploadProfile].[edate] AS CALLLISTUPLOADPROFILE_EDATE  FROM  [CallListUploadProfile]  WHERE  [CallListUploadProfile].[id] = \'"+x_lId.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[CallListUploadProfile]","["+ Configurator.MSSQLTablePrefix + "CallListUploadProfile]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADPROFILE_SDATE"])) {n_dSdate = (global::System.Nullable<DateTime>)_oData["CALLLISTUPLOADPROFILE_SDATE"];}else{n_dSdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADPROFILE_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["CALLLISTUPLOADPROFILE_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADPROFILE_ISSUE_TYPE"])) {n_sIssue_type = (string)_oData["CALLLISTUPLOADPROFILE_ISSUE_TYPE"];}else{n_sIssue_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADPROFILE_CALL_LIST_PROGRAM_ID"])) {n_lCall_list_program_id = (global::System.Nullable<long>)_oData["CALLLISTUPLOADPROFILE_CALL_LIST_PROGRAM_ID"];}else{n_lCall_list_program_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADPROFILE_ID"])) {n_lId = (global::System.Nullable<long>)_oData["CALLLISTUPLOADPROFILE_ID"];}else{n_lId=null;}
                        if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADPROFILE_EDATE"])) {n_dEdate = (global::System.Nullable<DateTime>)_oData["CALLLISTUPLOADPROFILE_EDATE"];}else{n_dEdate=null;}
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
            if (n_dSdate==null && !(n_oTableSet.Fields(Para.sdate).IsNullable)) return false;
            if (n_bActive==null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_sIssue_type==null && !(n_oTableSet.Fields(Para.issue_type).IsNullable)) return false;
            if (n_lCall_list_program_id==null && !(n_oTableSet.Fields(Para.call_list_program_id).IsNullable)) return false;
            if(!x_bInsert){
                if (n_lId==null && !(n_oTableSet.Fields(Para.id).IsNullable)) return false;
            }
            if (n_dEdate==null && !(n_oTableSet.Fields(Para.edate).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(CallListUploadProfileEntity)) || (x_oObj is CallListUploadProfileEntity)) return CallListUploadProfileRepository.Instance();
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
        public CallListUploadProfileInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(CallListUploadProfileInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public global::System.Nullable<DateTime> GetSdate(){return this.sdate;}
        public global::System.Nullable<long> GetId(){return this.id;}
        public global::System.Nullable<long> GetCall_list_program_id(){return this.call_list_program_id;}
        public string GetIssue_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.issue_type)) { return string.Empty; }
            return this.issue_type;
        }
        public global::System.Nullable<bool> GetActive(){return this.active;}
        public global::System.Nullable<DateTime> GetEdate(){return this.edate;}
        
        public bool SetSdate(global::System.Nullable<DateTime> value){
            this.sdate=value;
            return true;
        }
        public bool SetId(global::System.Nullable<long> value){
            this.id=value;
            return true;
        }
        public bool SetCall_list_program_id(global::System.Nullable<long> value){
            this.call_list_program_id=value;
            return true;
        }
        public bool SetIssue_type(string value){
            this.issue_type=value;
            return true;
        }
        public bool SetActive(global::System.Nullable<bool> value){
            this.active=value;
            return true;
        }
        public bool SetEdate(global::System.Nullable<DateTime> value){
            this.edate=value;
            return true;
        }
        
        public Field GetSdateTable(){
            return n_oTableSet.Fields(Para.sdate);
        }
        public Field GetIdTable(){
            return n_oTableSet.Fields(Para.id);
        }
        public Field GetCall_list_program_idTable(){
            return n_oTableSet.Fields(Para.call_list_program_id);
        }
        public Field GetIssue_typeTable(){
            return n_oTableSet.Fields(Para.issue_type);
        }
        public Field GetActiveTable(){
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetEdateTable(){
            return n_oTableSet.Fields(Para.edate);
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
        
        public bool EqualID(CallListUploadProfile x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_lId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(CallListUploadProfile x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_dSdate.Equals(x_oObj.sdate)){ return false; }
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_sIssue_type.Equals(x_oObj.issue_type)){ return false; }
            if(!this.n_lCall_list_program_id.Equals(x_oObj.call_list_program_id)){ return false; }
            if(!this.n_lId.Equals(x_oObj.id)){ return false; }
            if(!this.n_dEdate.Equals(x_oObj.edate)){ return false; }
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
            if(!n_lId.Equals(null)){
                _bResult=this.Load(n_lId);
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
            if (n_lId==null) { return false; }
            if(!Vaild(false)){ return false; }
            string _sQuery = "UPDATE  [CallListUploadProfile]  SET  [sdate]=@sdate,[active]=@active,[issue_type]=@issue_type,[call_list_program_id]=@call_list_program_id,[edate]=@edate  WHERE [CallListUploadProfile].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[CallListUploadProfile]","["+ Configurator.MSSQLTablePrefix + "CallListUploadProfile]"); }
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
            if(n_dSdate==null){  _oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value=n_dSdate; }
            if(n_bActive==null){  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=n_bActive; }
            if(n_sIssue_type==null){  _oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value=n_sIssue_type; }
            if(n_lCall_list_program_id==null){  _oCmd.Parameters.Add("@call_list_program_id", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@call_list_program_id", global::System.Data.SqlDbType.BigInt).Value=n_lCall_list_program_id; }
            if(n_lId==null){  _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.BigInt).Value=n_lId; }
            if(n_dEdate==null){  _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=n_dEdate; }
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
        /// Summary description for table [CallListUploadProfile] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_lId==null) { return false; }
            string _sQuery="DELETE FROM  [CallListUploadProfile]  WHERE [CallListUploadProfile].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[CallListUploadProfile]","["+ Configurator.MSSQLTablePrefix + "CallListUploadProfile]"); }
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
            _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.BigInt).Value = n_lId;
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
        /// Summary description for table [CallListUploadProfile] Object Base Clone
        /// </summary>
        
        public CallListUploadProfile DeepClone()
        {
            CallListUploadProfile _oCallListUploadProfile_Clone = new CallListUploadProfile();
            _oCallListUploadProfile_Clone.sdate = this.n_dSdate;
            _oCallListUploadProfile_Clone.active = this.n_bActive;
            _oCallListUploadProfile_Clone.issue_type = this.n_sIssue_type;
            _oCallListUploadProfile_Clone.call_list_program_id = this.n_lCall_list_program_id;
            _oCallListUploadProfile_Clone.id = this.n_lId;
            _oCallListUploadProfile_Clone.edate = this.n_dEdate;
            _oCallListUploadProfile_Clone.SetFound(this.n_bFound);
            _oCallListUploadProfile_Clone.SetDB(this.n_oDB);
            _oCallListUploadProfile_Clone.SetRow(this.n_oRow);
            _oCallListUploadProfile_Clone.SetTbl(this.n_oTbl);
            _oCallListUploadProfile_Clone.SetTableSet(this.n_oTableSet);
            
            return _oCallListUploadProfile_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_dSdate=null;
            n_bActive=null;
            n_sIssue_type=global::System.String.Empty;
            n_lCall_list_program_id=null;
            n_lId=null;
            n_dEdate=null;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = CallListUploadProfileInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


