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
///-- Create date: <Create Date 2010-10-29>
///-- Description:	<Description,Table :[MobileOrderReportType],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [MobileOrderReportType] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"MobileOrderReportType")]
    public class MobileOrderReportTypeEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        
        protected string n_sReport_name=global::System.String.Empty;
        #region report_name
        [System.Data.Linq.Mapping.Column(Name="[report_name]", Storage="n_sReport_name")]
        public string report_name{
            get{
                return this.n_sReport_name;
            }
            set{
                this.n_sReport_name=value;
            }
        }
        #endregion report_name
        
        
        protected global::System.Nullable<Guid> n_gId=null;
        #region id
        [System.Data.Linq.Mapping.Column(Name="[id]", Storage="n_gId")]
        public global::System.Nullable<Guid> id{
            get{
                return this.n_gId;
            }
            set{
                this.n_gId=value;
            }
        }
        #endregion id
        
        
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
        
        
        protected string n_sReport_type=global::System.String.Empty;
        #region report_type
        [System.Data.Linq.Mapping.Column(Name="[report_type]", Storage="n_sReport_type")]
        public string report_type{
            get{
                return this.n_sReport_type;
            }
            set{
                this.n_sReport_type=value;
            }
        }
        #endregion report_type
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private MobileOrderReportTypeInfo n_oTableSet = MobileOrderReportTypeInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string active="active";
            public const string cdate="cdate";
            public const string cid="cid";
            public const string did="did";
            public const string report_name="report_name";
            public const string id="id";
            public const string ddate="ddate";
            public const string mid="mid";
            public const string report_type="report_type";
            public const string MobileOrderReportType_table_name="MobileOrderReportType";
            public static string TableName() { return MobileOrderReportType_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public MobileOrderReportTypeEntity(){
            Init();
        }
        public MobileOrderReportTypeEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public MobileOrderReportTypeEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid){
            n_oDB=x_oDB;
            this.Load(x_iMid);
            Init();
        }
        
        ~MobileOrderReportTypeEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iMid){
            if (n_oDB==null) { return false; }
            if (x_iMid==null) { return false; }
            string _sQuery = "SELECT   [MobileOrderReportType].[active] AS MOBILEORDERREPORTTYPE_ACTIVE,[MobileOrderReportType].[cdate] AS MOBILEORDERREPORTTYPE_CDATE,[MobileOrderReportType].[cid] AS MOBILEORDERREPORTTYPE_CID,[MobileOrderReportType].[did] AS MOBILEORDERREPORTTYPE_DID,[MobileOrderReportType].[report_name] AS MOBILEORDERREPORTTYPE_REPORT_NAME,[MobileOrderReportType].[id] AS MOBILEORDERREPORTTYPE_ID,[MobileOrderReportType].[ddate] AS MOBILEORDERREPORTTYPE_DDATE,[MobileOrderReportType].[mid] AS MOBILEORDERREPORTTYPE_MID,[MobileOrderReportType].[report_type] AS MOBILEORDERREPORTTYPE_REPORT_TYPE  FROM  [MobileOrderReportType]  WHERE  [MobileOrderReportType].[mid] = \'"+x_iMid.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportType]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportType]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTTYPE_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_CDATE"])) {n_dCdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTTYPE_CDATE"];}else{n_dCdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_CID"])) {n_sCid = (string)_oData["MOBILEORDERREPORTTYPE_CID"];}else{n_sCid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_DID"])) {n_sDid = (string)_oData["MOBILEORDERREPORTTYPE_DID"];}else{n_sDid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_REPORT_NAME"])) {n_sReport_name = (string)_oData["MOBILEORDERREPORTTYPE_REPORT_NAME"];}else{n_sReport_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_ID"])) {n_gId = (global::System.Nullable<Guid>)_oData["MOBILEORDERREPORTTYPE_ID"];}else{n_gId=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_DDATE"])) {n_dDdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTTYPE_DDATE"];}else{n_dDdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_MID"])) {n_iMid = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTTYPE_MID"];}else{n_iMid=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_REPORT_TYPE"])) {n_sReport_type = (string)_oData["MOBILEORDERREPORTTYPE_REPORT_TYPE"];}else{n_sReport_type=global::System.String.Empty;}
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
            if (n_sDid==null && !(n_oTableSet.Fields(Para.did).IsNullable)) return false;
            if (n_sReport_name==null && !(n_oTableSet.Fields(Para.report_name).IsNullable)) return false;
            if (n_gId==null && !(n_oTableSet.Fields(Para.id).IsNullable)) return false;
            if (n_dDdate==null && !(n_oTableSet.Fields(Para.ddate).IsNullable)) return false;
            if(!x_bInsert){
                if (n_iMid==null && !(n_oTableSet.Fields(Para.mid).IsNullable)) return false;
            }
            if (n_sReport_type==null && !(n_oTableSet.Fields(Para.report_type).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(MobileOrderReportTypeEntity)) || (x_oObj is MobileOrderReportTypeEntity)) return MobileOrderReportTypeRepository.Instance();
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
        public MobileOrderReportTypeInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(MobileOrderReportTypeInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public global::System.Nullable<bool> GetActive(){return this.active;}
        public global::System.Nullable<DateTime> GetCdate(){return this.cdate;}
        public string GetCid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.cid)) { return string.Empty; }
            return this.cid;
        }
        public string GetDid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.did)) { return string.Empty; }
            return this.did;
        }
        public string GetReport_name(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.report_name)) { return string.Empty; }
            return this.report_name;
        }
        public global::System.Nullable<Guid> GetId(){return this.id;}
        public global::System.Nullable<DateTime> GetDdate(){return this.ddate;}
        public global::System.Nullable<int> GetMid(){return this.mid;}
        public string GetReport_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.report_type)) { return string.Empty; }
            return this.report_type;
        }
        
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
        public bool SetDid(string value){
            this.did=value;
            return true;
        }
        public bool SetReport_name(string value){
            this.report_name=value;
            return true;
        }
        public bool SetId(global::System.Nullable<Guid> value){
            this.id=value;
            return true;
        }
        public bool SetDdate(global::System.Nullable<DateTime> value){
            this.ddate=value;
            return true;
        }
        public bool SetMid(global::System.Nullable<int> value){
            this.mid=value;
            return true;
        }
        public bool SetReport_type(string value){
            this.report_type=value;
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
        public Field GetDidTable(){
            return n_oTableSet.Fields(Para.did);
        }
        public Field GetReport_nameTable(){
            return n_oTableSet.Fields(Para.report_name);
        }
        public Field GetIdTable(){
            return n_oTableSet.Fields(Para.id);
        }
        public Field GetDdateTable(){
            return n_oTableSet.Fields(Para.ddate);
        }
        public Field GetMidTable(){
            return n_oTableSet.Fields(Para.mid);
        }
        public Field GetReport_typeTable(){
            return n_oTableSet.Fields(Para.report_type);
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
        
        public bool EqualID(MobileOrderReportType x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iMid.Equals(x_oObj.mid)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(MobileOrderReportType x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_dCdate.Equals(x_oObj.cdate)){ return false; }
            if(!this.n_sCid.Equals(x_oObj.cid)){ return false; }
            if(!this.n_sDid.Equals(x_oObj.did)){ return false; }
            if(!this.n_sReport_name.Equals(x_oObj.report_name)){ return false; }
            if(!this.n_gId.Equals(x_oObj.id)){ return false; }
            if(!this.n_dDdate.Equals(x_oObj.ddate)){ return false; }
            if(!this.n_iMid.Equals(x_oObj.mid)){ return false; }
            if(!this.n_sReport_type.Equals(x_oObj.report_type)){ return false; }
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
            string _sQuery = "UPDATE  [MobileOrderReportType]  SET  [active]=@active,[cdate]=@cdate,[cid]=@cid,[did]=@did,[report_name]=@report_name,[id]=@id,[ddate]=@ddate,[report_type]=@report_type  WHERE [MobileOrderReportType].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportType]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportType]"); }
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
            if(n_sCid==null){  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value=n_sCid; }
            if(n_sDid==null){  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10).Value=n_sDid; }
            if(n_sReport_name==null){  _oCmd.Parameters.Add("@report_name", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@report_name", global::System.Data.SqlDbType.NVarChar,50).Value=n_sReport_name; }
            if(n_gId==null){  _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.UniqueIdentifier).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.UniqueIdentifier).Value=n_gId; }
            if(n_dDdate==null){  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=n_dDdate; }
            if(n_iMid==null){  _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value=n_iMid; }
            if(n_sReport_type==null){  _oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.NVarChar,20).Value=n_sReport_type; }
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
        /// Summary description for table [MobileOrderReportType] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iMid==null) { return false; }
            string _sQuery="DELETE FROM  [MobileOrderReportType]  WHERE [MobileOrderReportType].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportType]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportType]"); }
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
        /// Summary description for table [MobileOrderReportType] Object Base Clone
        /// </summary>
        
        public MobileOrderReportType DeepClone()
        {
            MobileOrderReportType _oMobileOrderReportType_Clone = new MobileOrderReportType();
            _oMobileOrderReportType_Clone.active = this.n_bActive;
            _oMobileOrderReportType_Clone.cdate = this.n_dCdate;
            _oMobileOrderReportType_Clone.cid = this.n_sCid;
            _oMobileOrderReportType_Clone.did = this.n_sDid;
            _oMobileOrderReportType_Clone.report_name = this.n_sReport_name;
            _oMobileOrderReportType_Clone.id = this.n_gId;
            _oMobileOrderReportType_Clone.ddate = this.n_dDdate;
            _oMobileOrderReportType_Clone.mid = this.n_iMid;
            _oMobileOrderReportType_Clone.report_type = this.n_sReport_type;
            _oMobileOrderReportType_Clone.SetFound(this.n_bFound);
            _oMobileOrderReportType_Clone.SetDB(this.n_oDB);
            _oMobileOrderReportType_Clone.SetRow(this.n_oRow);
            _oMobileOrderReportType_Clone.SetTbl(this.n_oTbl);
            _oMobileOrderReportType_Clone.SetTableSet(this.n_oTableSet);
            
            return _oMobileOrderReportType_Clone;
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
            n_sDid=global::System.String.Empty;
            n_sReport_name=global::System.String.Empty;
            n_gId=null;
            n_dDdate=null;
            n_iMid=null;
            n_sReport_type=global::System.String.Empty;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = MobileOrderReportTypeInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


