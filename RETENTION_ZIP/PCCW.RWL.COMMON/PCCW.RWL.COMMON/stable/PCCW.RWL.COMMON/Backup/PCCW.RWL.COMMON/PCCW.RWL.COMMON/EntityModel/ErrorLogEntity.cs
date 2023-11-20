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
///-- Create date: <Create Date 2010-07-29>
///-- Description:	<Description,Table :[ErrorLog],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [ErrorLog] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"ErrorLog")]
    public class ErrorLogEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        
        protected string n_sUid=global::System.String.Empty;
        #region uid
        [System.Data.Linq.Mapping.Column(Name="[uid]", Storage="n_sUid")]
        public string uid{
            get{
                return this.n_sUid;
            }
            set{
                this.n_sUid=value;
            }
        }
        #endregion uid
        
        
        protected string n_sIp=global::System.String.Empty;
        #region ip
        [System.Data.Linq.Mapping.Column(Name="[ip]", Storage="n_sIp")]
        public string ip{
            get{
                return this.n_sIp;
            }
            set{
                this.n_sIp=value;
            }
        }
        #endregion ip
        
        
        protected string n_sPage=global::System.String.Empty;
        #region page
        [System.Data.Linq.Mapping.Column(Name="[page]", Storage="n_sPage")]
        public string page{
            get{
                return this.n_sPage;
            }
            set{
                this.n_sPage=value;
            }
        }
        #endregion page
        
        
        protected string n_sStack_trace=global::System.String.Empty;
        #region stack_trace
        [System.Data.Linq.Mapping.Column(Name="[stack_trace]", Storage="n_sStack_trace")]
        public string stack_trace{
            get{
                return this.n_sStack_trace;
            }
            set{
                this.n_sStack_trace=value;
            }
        }
        #endregion stack_trace
        
        
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
        
        
        protected global::System.Nullable<DateTime> n_dLog_date=null;
        #region log_date
        [System.Data.Linq.Mapping.Column(Name="[log_date]", Storage="n_dLog_date")]
        public global::System.Nullable<DateTime> log_date{
            get{
                return this.n_dLog_date;
            }
            set{
                this.n_dLog_date=value;
            }
        }
        #endregion log_date
        
        
        protected string n_sErr_msg=global::System.String.Empty;
        #region err_msg
        [System.Data.Linq.Mapping.Column(Name="[err_msg]", Storage="n_sErr_msg")]
        public string err_msg{
            get{
                return this.n_sErr_msg;
            }
            set{
                this.n_sErr_msg=value;
            }
        }
        #endregion err_msg
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private ErrorLogInfo n_oTableSet = ErrorLogInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string uid="uid";
            public const string id="id";
            public const string ip="ip";
            public const string page="page";
            public const string stack_trace="stack_trace";
            public const string log_date="log_date";
            public const string err_msg="err_msg";
            public const string ErrorLog_table_name="ErrorLog";
            public static string TableName() { return ErrorLog_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public ErrorLogEntity(){
            Init();
        }
        public ErrorLogEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public ErrorLogEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId){
            n_oDB=x_oDB;
            this.Load(x_iId);
            Init();
        }
        
        ~ErrorLogEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iId){
            if (n_oDB==null) { return false; }
            if (x_iId==null) { return false; }
            string _sQuery = "SELECT   [ErrorLog].[uid] AS ERRORLOG_UID,[ErrorLog].[ip] AS ERRORLOG_IP,[ErrorLog].[page] AS ERRORLOG_PAGE,[ErrorLog].[stack_trace] AS ERRORLOG_STACK_TRACE,[ErrorLog].[id] AS ERRORLOG_ID,[ErrorLog].[log_date] AS ERRORLOG_LOG_DATE,[ErrorLog].[err_msg] AS ERRORLOG_ERR_MSG  FROM  [ErrorLog]  WHERE  [ErrorLog].[id] = \'"+x_iId.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ErrorLog]","["+ Configurator.MSSQLTablePrefix + "ErrorLog]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["ERRORLOG_UID"])) {n_sUid = (string)_oData["ERRORLOG_UID"];}else{n_sUid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["ERRORLOG_IP"])) {n_sIp = (string)_oData["ERRORLOG_IP"];}else{n_sIp=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["ERRORLOG_PAGE"])) {n_sPage = (string)_oData["ERRORLOG_PAGE"];}else{n_sPage=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["ERRORLOG_STACK_TRACE"])) {n_sStack_trace = (string)_oData["ERRORLOG_STACK_TRACE"];}else{n_sStack_trace=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["ERRORLOG_ID"])) {n_iId = (global::System.Nullable<int>)_oData["ERRORLOG_ID"];}else{n_iId=null;}
                        if (!global::System.Convert.IsDBNull(_oData["ERRORLOG_LOG_DATE"])) {n_dLog_date = (global::System.Nullable<DateTime>)_oData["ERRORLOG_LOG_DATE"];}else{n_dLog_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["ERRORLOG_ERR_MSG"])) {n_sErr_msg = (string)_oData["ERRORLOG_ERR_MSG"];}else{n_sErr_msg=global::System.String.Empty;}
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
            if (n_sUid==null && !(n_oTableSet.Fields(Para.uid).IsNullable)) return false;
            if (n_sIp==null && !(n_oTableSet.Fields(Para.ip).IsNullable)) return false;
            if (n_sPage==null && !(n_oTableSet.Fields(Para.page).IsNullable)) return false;
            if (n_sStack_trace==null && !(n_oTableSet.Fields(Para.stack_trace).IsNullable)) return false;
            if(!x_bInsert){
                if (n_iId==null && !(n_oTableSet.Fields(Para.id).IsNullable)) return false;
            }
            if (n_dLog_date==null && !(n_oTableSet.Fields(Para.log_date).IsNullable)) return false;
            if (n_sErr_msg==null && !(n_oTableSet.Fields(Para.err_msg).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(ErrorLogEntity)) || (x_oObj is ErrorLogEntity)) return ErrorLogRepository.Instance();
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
        public ErrorLogInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(ErrorLogInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public string GetUid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.uid)) { return string.Empty; }
            return this.uid;
        }
        public global::System.Nullable<int> GetId(){return this.id;}
        public string GetIp(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.ip)) { return string.Empty; }
            return this.ip;
        }
        public string GetPage(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.page)) { return string.Empty; }
            return this.page;
        }
        public string GetStack_trace(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.stack_trace)) { return string.Empty; }
            return this.stack_trace;
        }
        public global::System.Nullable<DateTime> GetLog_date(){return this.log_date;}
        public string GetErr_msg(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.err_msg)) { return string.Empty; }
            return this.err_msg;
        }
        
        public bool SetUid(string value){
            this.uid=value;
            return true;
        }
        public bool SetId(global::System.Nullable<int> value){
            this.id=value;
            return true;
        }
        public bool SetIp(string value){
            this.ip=value;
            return true;
        }
        public bool SetPage(string value){
            this.page=value;
            return true;
        }
        public bool SetStack_trace(string value){
            this.stack_trace=value;
            return true;
        }
        public bool SetLog_date(global::System.Nullable<DateTime> value){
            this.log_date=value;
            return true;
        }
        public bool SetErr_msg(string value){
            this.err_msg=value;
            return true;
        }
        
        public Field GetUidTable(){
            return n_oTableSet.Fields(Para.uid);
        }
        public Field GetIdTable(){
            return n_oTableSet.Fields(Para.id);
        }
        public Field GetIpTable(){
            return n_oTableSet.Fields(Para.ip);
        }
        public Field GetPageTable(){
            return n_oTableSet.Fields(Para.page);
        }
        public Field GetStack_traceTable(){
            return n_oTableSet.Fields(Para.stack_trace);
        }
        public Field GetLog_dateTable(){
            return n_oTableSet.Fields(Para.log_date);
        }
        public Field GetErr_msgTable(){
            return n_oTableSet.Fields(Para.err_msg);
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
        
        public bool EqualID(ErrorLog x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(ErrorLog x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_sUid.Equals(x_oObj.uid)){ return false; }
            if(!this.n_sIp.Equals(x_oObj.ip)){ return false; }
            if(!this.n_sPage.Equals(x_oObj.page)){ return false; }
            if(!this.n_sStack_trace.Equals(x_oObj.stack_trace)){ return false; }
            if(!this.n_iId.Equals(x_oObj.id)){ return false; }
            if(!this.n_dLog_date.Equals(x_oObj.log_date)){ return false; }
            if(!this.n_sErr_msg.Equals(x_oObj.err_msg)){ return false; }
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
            string _sQuery = "UPDATE  [ErrorLog]  SET  [uid]=@uid,[ip]=@ip,[page]=@page,[stack_trace]=@stack_trace,[log_date]=@log_date,[err_msg]=@err_msg  WHERE [ErrorLog].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ErrorLog]","["+ Configurator.MSSQLTablePrefix + "ErrorLog]"); }
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
            if(n_sUid==null){  _oCmd.Parameters.Add("@uid", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@uid", global::System.Data.SqlDbType.NVarChar,250).Value=n_sUid; }
            if(n_sIp==null){  _oCmd.Parameters.Add("@ip", global::System.Data.SqlDbType.VarChar,15).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@ip", global::System.Data.SqlDbType.VarChar,15).Value=n_sIp; }
            if(n_sPage==null){  _oCmd.Parameters.Add("@page", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@page", global::System.Data.SqlDbType.NVarChar,250).Value=n_sPage; }
            if(n_sStack_trace==null){  _oCmd.Parameters.Add("@stack_trace", global::System.Data.SqlDbType.Text,2147483647).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@stack_trace", global::System.Data.SqlDbType.Text,2147483647).Value=n_sStack_trace; }
            if(n_iId==null){  _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value=n_iId; }
            if(n_dLog_date==null){  _oCmd.Parameters.Add("@log_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@log_date", global::System.Data.SqlDbType.DateTime).Value=n_dLog_date; }
            if(n_sErr_msg==null){  _oCmd.Parameters.Add("@err_msg", global::System.Data.SqlDbType.Text,2147483647).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@err_msg", global::System.Data.SqlDbType.Text,2147483647).Value=n_sErr_msg; }
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
        /// Summary description for table [ErrorLog] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iId==null) { return false; }
            string _sQuery="DELETE FROM  [ErrorLog]  WHERE [ErrorLog].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ErrorLog]","["+ Configurator.MSSQLTablePrefix + "ErrorLog]"); }
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
        /// Summary description for table [ErrorLog] Object Base Clone
        /// </summary>
        
        public ErrorLog DeepClone()
        {
            ErrorLog _oErrorLog_Clone = new ErrorLog();
            _oErrorLog_Clone.uid = this.n_sUid;
            _oErrorLog_Clone.ip = this.n_sIp;
            _oErrorLog_Clone.page = this.n_sPage;
            _oErrorLog_Clone.stack_trace = this.n_sStack_trace;
            _oErrorLog_Clone.id = this.n_iId;
            _oErrorLog_Clone.log_date = this.n_dLog_date;
            _oErrorLog_Clone.err_msg = this.n_sErr_msg;
            _oErrorLog_Clone.SetFound(this.n_bFound);
            _oErrorLog_Clone.SetDB(this.n_oDB);
            _oErrorLog_Clone.SetRow(this.n_oRow);
            _oErrorLog_Clone.SetTbl(this.n_oTbl);
            _oErrorLog_Clone.SetTableSet(this.n_oTableSet);
            
            return _oErrorLog_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_sUid=global::System.String.Empty;
            n_sIp=global::System.String.Empty;
            n_sPage=global::System.String.Empty;
            n_sStack_trace=global::System.String.Empty;
            n_iId=null;
            n_dLog_date=null;
            n_sErr_msg=global::System.String.Empty;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = ErrorLogInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


