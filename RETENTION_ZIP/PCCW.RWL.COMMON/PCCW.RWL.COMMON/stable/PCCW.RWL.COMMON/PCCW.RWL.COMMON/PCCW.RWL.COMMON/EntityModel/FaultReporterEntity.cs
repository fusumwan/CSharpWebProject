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
///-- Create date: <Create Date 2010-07-29>
///-- Description:	<Description,Table :[FaultReporter],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [FaultReporter] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"FaultReporter")]
    public class FaultReporterEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        
        protected string n_sEmail=global::System.String.Empty;
        #region email
        [System.Data.Linq.Mapping.Column(Name="[email]", Storage="n_sEmail")]
        public string email{
            get{
                return this.n_sEmail;
            }
            set{
                this.n_sEmail=value;
            }
        }
        #endregion email
        
        
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
        private FaultReporterInfo n_oTableSet = FaultReporterInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string id="id";
            public const string name="name";
            public const string cdate="cdate";
            public const string cid="cid";
            public const string email="email";
            public const string active="active";
            public const string edate="edate";
            public const string FaultReporter_table_name="FaultReporter";
            public static string TableName() { return FaultReporter_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public FaultReporterEntity(){
            Init();
        }
        public FaultReporterEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public FaultReporterEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId){
            n_oDB=x_oDB;
            this.Load(x_iId);
            Init();
        }
        
        ~FaultReporterEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iId){
            if (n_oDB==null) { return false; }
            if (x_iId==null) { return false; }
            string _sQuery = "SELECT   [FaultReporter].[active] AS FAULTREPORTER_ACTIVE,[FaultReporter].[name] AS FAULTREPORTER_NAME,[FaultReporter].[cdate] AS FAULTREPORTER_CDATE,[FaultReporter].[cid] AS FAULTREPORTER_CID,[FaultReporter].[email] AS FAULTREPORTER_EMAIL,[FaultReporter].[id] AS FAULTREPORTER_ID,[FaultReporter].[edate] AS FAULTREPORTER_EDATE  FROM  [FaultReporter]  WHERE  [FaultReporter].[id] = \'"+x_iId.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[FaultReporter]","["+ Configurator.MSSQLTablePrefix + "FaultReporter]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["FAULTREPORTER_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["FAULTREPORTER_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["FAULTREPORTER_NAME"])) {n_sName = (string)_oData["FAULTREPORTER_NAME"];}else{n_sName=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["FAULTREPORTER_CDATE"])) {n_dCdate = (global::System.Nullable<DateTime>)_oData["FAULTREPORTER_CDATE"];}else{n_dCdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["FAULTREPORTER_CID"])) {n_sCid = (string)_oData["FAULTREPORTER_CID"];}else{n_sCid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["FAULTREPORTER_EMAIL"])) {n_sEmail = (string)_oData["FAULTREPORTER_EMAIL"];}else{n_sEmail=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["FAULTREPORTER_ID"])) {n_iId = (global::System.Nullable<int>)_oData["FAULTREPORTER_ID"];}else{n_iId=null;}
                        if (!global::System.Convert.IsDBNull(_oData["FAULTREPORTER_EDATE"])) {n_dEdate = (global::System.Nullable<DateTime>)_oData["FAULTREPORTER_EDATE"];}else{n_dEdate=null;}
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
            if (n_sName==null && !(n_oTableSet.Fields(Para.name).IsNullable)) return false;
            if (n_dCdate==null && !(n_oTableSet.Fields(Para.cdate).IsNullable)) return false;
            if (n_sCid==null && !(n_oTableSet.Fields(Para.cid).IsNullable)) return false;
            if (n_sEmail==null && !(n_oTableSet.Fields(Para.email).IsNullable)) return false;
            if (n_iId==null && !(n_oTableSet.Fields(Para.id).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(FaultReporterEntity)) || (x_oObj is FaultReporterEntity)) return FaultReporterRepository.Instance();
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
        public FaultReporterInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(FaultReporterInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public global::System.Nullable<int> GetId(){return this.id;}
        public string GetName(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.name)) { return string.Empty; }
            return this.name;
        }
        public global::System.Nullable<DateTime> GetCdate(){return this.cdate;}
        public string GetCid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.cid)) { return string.Empty; }
            return this.cid;
        }
        public string GetEmail(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.email)) { return string.Empty; }
            return this.email;
        }
        public global::System.Nullable<bool> GetActive(){return this.active;}
        public global::System.Nullable<DateTime> GetEdate(){return this.edate;}
        
        public bool SetId(global::System.Nullable<int> value){
            this.id=value;
            return true;
        }
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
        public bool SetEmail(string value){
            this.email=value;
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
        
        public Field GetIdTable(){
            return n_oTableSet.Fields(Para.id);
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
        public Field GetEmailTable(){
            return n_oTableSet.Fields(Para.email);
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
        
        public bool EqualID(FaultReporter x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(FaultReporter x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_sName.Equals(x_oObj.name)){ return false; }
            if(!this.n_dCdate.Equals(x_oObj.cdate)){ return false; }
            if(!this.n_sCid.Equals(x_oObj.cid)){ return false; }
            if(!this.n_sEmail.Equals(x_oObj.email)){ return false; }
            if(!this.n_iId.Equals(x_oObj.id)){ return false; }
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
            string _sQuery = "UPDATE  [FaultReporter]  SET  [active]=@active,[name]=@name,[cdate]=@cdate,[cid]=@cid,[email]=@email,[id]=@id,[edate]=@edate  WHERE [FaultReporter].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[FaultReporter]","["+ Configurator.MSSQLTablePrefix + "FaultReporter]"); }
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
            if(n_sName==null){  _oCmd.Parameters.Add("@name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@name", global::System.Data.SqlDbType.NVarChar,250).Value=n_sName; }
            if(n_dCdate==null){  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=n_dCdate; }
            if(n_sCid==null){  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=n_sCid; }
            if(n_sEmail==null){  _oCmd.Parameters.Add("@email", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@email", global::System.Data.SqlDbType.NVarChar,250).Value=n_sEmail; }
            if(n_iId==null){  _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value=n_iId; }
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
        /// Summary description for table [FaultReporter] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iId==null) { return false; }
            string _sQuery="DELETE FROM  [FaultReporter]  WHERE [FaultReporter].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[FaultReporter]","["+ Configurator.MSSQLTablePrefix + "FaultReporter]"); }
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
        /// Summary description for table [FaultReporter] Object Base Clone
        /// </summary>
        
        public FaultReporter DeepClone()
        {
            FaultReporter _oFaultReporter_Clone = new FaultReporter();
            _oFaultReporter_Clone.active = this.n_bActive;
            _oFaultReporter_Clone.name = this.n_sName;
            _oFaultReporter_Clone.cdate = this.n_dCdate;
            _oFaultReporter_Clone.cid = this.n_sCid;
            _oFaultReporter_Clone.email = this.n_sEmail;
            _oFaultReporter_Clone.id = this.n_iId;
            _oFaultReporter_Clone.edate = this.n_dEdate;
            _oFaultReporter_Clone.SetFound(this.n_bFound);
            _oFaultReporter_Clone.SetDB(this.n_oDB);
            _oFaultReporter_Clone.SetRow(this.n_oRow);
            _oFaultReporter_Clone.SetTbl(this.n_oTbl);
            _oFaultReporter_Clone.SetTableSet(this.n_oTableSet);
            
            return _oFaultReporter_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_bActive=null;
            n_sName=global::System.String.Empty;
            n_dCdate=null;
            n_sCid=global::System.String.Empty;
            n_sEmail=global::System.String.Empty;
            n_iId=null;
            n_dEdate=null;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = FaultReporterInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


