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
///-- Create date: <Create Date 2011-10-04>
///-- Description:	<Description,Table :[RetentionPlanUsage],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [RetentionPlanUsage] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"RetentionPlanUsage")]
    public class RetentionPlanUsageEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        
        protected string n_sRate_plan=global::System.String.Empty;
        #region rate_plan
        [System.Data.Linq.Mapping.Column(Name="[rate_plan]", Storage="n_sRate_plan")]
        public string rate_plan{
            get{
                return this.n_sRate_plan;
            }
            set{
                this.n_sRate_plan=value;
            }
        }
        #endregion rate_plan
        
        
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
        
        
        protected string n_sRate_plan_vas_value=global::System.String.Empty;
        #region rate_plan_vas_value
        [System.Data.Linq.Mapping.Column(Name="[rate_plan_vas_value]", Storage="n_sRate_plan_vas_value")]
        public string rate_plan_vas_value{
            get{
                return this.n_sRate_plan_vas_value;
            }
            set{
                this.n_sRate_plan_vas_value=value;
            }
        }
        #endregion rate_plan_vas_value
        
        
        protected string n_sRate_plan_vas=global::System.String.Empty;
        #region rate_plan_vas
        [System.Data.Linq.Mapping.Column(Name="[rate_plan_vas]", Storage="n_sRate_plan_vas")]
        public string rate_plan_vas{
            get{
                return this.n_sRate_plan_vas;
            }
            set{
                this.n_sRate_plan_vas=value;
            }
        }
        #endregion rate_plan_vas
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private RetentionPlanUsageInfo n_oTableSet = RetentionPlanUsageInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string id="id";
            public const string cdate="cdate";
            public const string cid="cid";
            public const string rate_plan="rate_plan";
            public const string active="active";
            public const string rate_plan_vas_value="rate_plan_vas_value";
            public const string rate_plan_vas="rate_plan_vas";
            public const string RetentionPlanUsage_table_name="RetentionPlanUsage";
            public static string TableName() { return RetentionPlanUsage_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public RetentionPlanUsageEntity(){
            Init();
        }
        public RetentionPlanUsageEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public RetentionPlanUsageEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId){
            n_oDB=x_oDB;
            this.Load(x_iId);
            Init();
        }
        
        ~RetentionPlanUsageEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iId){
            if (n_oDB==null) { return false; }
            if (x_iId==null) { return false; }
            string _sQuery = "SELECT   [RetentionPlanUsage].[active] AS RETENTIONPLANUSAGE_ACTIVE,[RetentionPlanUsage].[cdate] AS RETENTIONPLANUSAGE_CDATE,[RetentionPlanUsage].[cid] AS RETENTIONPLANUSAGE_CID,[RetentionPlanUsage].[rate_plan] AS RETENTIONPLANUSAGE_RATE_PLAN,[RetentionPlanUsage].[id] AS RETENTIONPLANUSAGE_ID,[RetentionPlanUsage].[rate_plan_vas_value] AS RETENTIONPLANUSAGE_RATE_PLAN_VAS_VALUE,[RetentionPlanUsage].[rate_plan_vas] AS RETENTIONPLANUSAGE_RATE_PLAN_VAS  FROM  [RetentionPlanUsage]  WHERE  [RetentionPlanUsage].[id] = \'"+x_iId.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RetentionPlanUsage]","["+ Configurator.MSSQLTablePrefix + "RetentionPlanUsage]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLANUSAGE_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["RETENTIONPLANUSAGE_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLANUSAGE_CDATE"])) {n_dCdate = (global::System.Nullable<DateTime>)_oData["RETENTIONPLANUSAGE_CDATE"];}else{n_dCdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLANUSAGE_CID"])) {n_sCid = (string)_oData["RETENTIONPLANUSAGE_CID"];}else{n_sCid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLANUSAGE_RATE_PLAN"])) {n_sRate_plan = (string)_oData["RETENTIONPLANUSAGE_RATE_PLAN"];}else{n_sRate_plan=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLANUSAGE_ID"])) {n_iId = (global::System.Nullable<int>)_oData["RETENTIONPLANUSAGE_ID"];}else{n_iId=null;}
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLANUSAGE_RATE_PLAN_VAS_VALUE"])) {n_sRate_plan_vas_value = (string)_oData["RETENTIONPLANUSAGE_RATE_PLAN_VAS_VALUE"];}else{n_sRate_plan_vas_value=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLANUSAGE_RATE_PLAN_VAS"])) {n_sRate_plan_vas = (string)_oData["RETENTIONPLANUSAGE_RATE_PLAN_VAS"];}else{n_sRate_plan_vas=global::System.String.Empty;}
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
            if (n_sRate_plan==null && !(n_oTableSet.Fields(Para.rate_plan).IsNullable)) return false;
            if(!x_bInsert){
                if (n_iId==null && !(n_oTableSet.Fields(Para.id).IsNullable)) return false;
            }
            if (n_sRate_plan_vas_value==null && !(n_oTableSet.Fields(Para.rate_plan_vas_value).IsNullable)) return false;
            if (n_sRate_plan_vas==null && !(n_oTableSet.Fields(Para.rate_plan_vas).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(RetentionPlanUsageEntity)) || (x_oObj is RetentionPlanUsageEntity)) return RetentionPlanUsageRepository.Instance();
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
        public RetentionPlanUsageInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(RetentionPlanUsageInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public global::System.Nullable<int> GetId(){return this.id;}
        public global::System.Nullable<DateTime> GetCdate(){return this.cdate;}
        public string GetCid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.cid)) { return string.Empty; }
            return this.cid;
        }
        public string GetRate_plan(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.rate_plan)) { return string.Empty; }
            return this.rate_plan;
        }
        public global::System.Nullable<bool> GetActive(){return this.active;}
        public string GetRate_plan_vas_value(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.rate_plan_vas_value)) { return string.Empty; }
            return this.rate_plan_vas_value;
        }
        public string GetRate_plan_vas(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.rate_plan_vas)) { return string.Empty; }
            return this.rate_plan_vas;
        }
        
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
        public bool SetRate_plan(string value){
            this.rate_plan=value;
            return true;
        }
        public bool SetActive(global::System.Nullable<bool> value){
            this.active=value;
            return true;
        }
        public bool SetRate_plan_vas_value(string value){
            this.rate_plan_vas_value=value;
            return true;
        }
        public bool SetRate_plan_vas(string value){
            this.rate_plan_vas=value;
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
        public Field GetRate_planTable(){
            return n_oTableSet.Fields(Para.rate_plan);
        }
        public Field GetActiveTable(){
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetRate_plan_vas_valueTable(){
            return n_oTableSet.Fields(Para.rate_plan_vas_value);
        }
        public Field GetRate_plan_vasTable(){
            return n_oTableSet.Fields(Para.rate_plan_vas);
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
        
        public bool EqualID(RetentionPlanUsage x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(RetentionPlanUsage x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_dCdate.Equals(x_oObj.cdate)){ return false; }
            if(!this.n_sCid.Equals(x_oObj.cid)){ return false; }
            if(!this.n_sRate_plan.Equals(x_oObj.rate_plan)){ return false; }
            if(!this.n_iId.Equals(x_oObj.id)){ return false; }
            if(!this.n_sRate_plan_vas_value.Equals(x_oObj.rate_plan_vas_value)){ return false; }
            if(!this.n_sRate_plan_vas.Equals(x_oObj.rate_plan_vas)){ return false; }
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
            string _sQuery = "UPDATE  [RetentionPlanUsage]  SET  [active]=@active,[cdate]=@cdate,[cid]=@cid,[rate_plan]=@rate_plan,[rate_plan_vas_value]=@rate_plan_vas_value,[rate_plan_vas]=@rate_plan_vas  WHERE [RetentionPlanUsage].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RetentionPlanUsage]","["+ Configurator.MSSQLTablePrefix + "RetentionPlanUsage]"); }
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
            if(n_sRate_plan==null){  _oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50).Value=n_sRate_plan; }
            if(n_iId==null){  _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value=n_iId; }
            if(n_sRate_plan_vas_value==null){  _oCmd.Parameters.Add("@rate_plan_vas_value", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@rate_plan_vas_value", global::System.Data.SqlDbType.NVarChar,250).Value=n_sRate_plan_vas_value; }
            if(n_sRate_plan_vas==null){  _oCmd.Parameters.Add("@rate_plan_vas", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@rate_plan_vas", global::System.Data.SqlDbType.NVarChar,250).Value=n_sRate_plan_vas; }
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
        /// Summary description for table [RetentionPlanUsage] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iId==null) { return false; }
            string _sQuery="DELETE FROM  [RetentionPlanUsage]  WHERE [RetentionPlanUsage].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RetentionPlanUsage]","["+ Configurator.MSSQLTablePrefix + "RetentionPlanUsage]"); }
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
        /// Summary description for table [RetentionPlanUsage] Object Base Clone
        /// </summary>
        
        public RetentionPlanUsage DeepClone()
        {
            RetentionPlanUsage _oRetentionPlanUsage_Clone = new RetentionPlanUsage();
            _oRetentionPlanUsage_Clone.active = this.n_bActive;
            _oRetentionPlanUsage_Clone.cdate = this.n_dCdate;
            _oRetentionPlanUsage_Clone.cid = this.n_sCid;
            _oRetentionPlanUsage_Clone.rate_plan = this.n_sRate_plan;
            _oRetentionPlanUsage_Clone.id = this.n_iId;
            _oRetentionPlanUsage_Clone.rate_plan_vas_value = this.n_sRate_plan_vas_value;
            _oRetentionPlanUsage_Clone.rate_plan_vas = this.n_sRate_plan_vas;
            _oRetentionPlanUsage_Clone.SetFound(this.n_bFound);
            _oRetentionPlanUsage_Clone.SetDB(this.n_oDB);
            _oRetentionPlanUsage_Clone.SetRow(this.n_oRow);
            _oRetentionPlanUsage_Clone.SetTbl(this.n_oTbl);
            _oRetentionPlanUsage_Clone.SetTableSet(this.n_oTableSet);
            
            return _oRetentionPlanUsage_Clone;
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
            n_sRate_plan=global::System.String.Empty;
            n_iId=null;
            n_sRate_plan_vas_value=global::System.String.Empty;
            n_sRate_plan_vas=global::System.String.Empty;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = RetentionPlanUsageInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


