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
///-- Create date: <Create Date 2011-09-22>
///-- Description:	<Description,Table :[ProgramRebateMapping],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [ProgramRebateMapping] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"ProgramRebateMapping")]
    public class ProgramRebateMappingEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        
        protected string n_sProgram=global::System.String.Empty;
        #region program
        [System.Data.Linq.Mapping.Column(Name="[program]", Storage="n_sProgram")]
        public string program{
            get{
                return this.n_sProgram;
            }
            set{
                this.n_sProgram=value;
            }
        }
        #endregion program
        
        
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
        
        
        protected global::System.Nullable<bool> n_bUse_rebate_mapping=null;
        #region use_rebate_mapping
        [System.Data.Linq.Mapping.Column(Name="[use_rebate_mapping]", Storage="n_bUse_rebate_mapping")]
        public global::System.Nullable<bool> use_rebate_mapping{
            get{
                return this.n_bUse_rebate_mapping;
            }
            set{
                this.n_bUse_rebate_mapping=value;
            }
        }
        #endregion use_rebate_mapping
        
        
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
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private ProgramRebateMappingInfo n_oTableSet = ProgramRebateMappingInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string id="id";
            public const string cdate="cdate";
            public const string active="active";
            public const string edate="edate";
            public const string program="program";
            public const string issue_type="issue_type";
            public const string use_rebate_mapping="use_rebate_mapping";
            public const string sdate="sdate";
            public const string ProgramRebateMapping_table_name="ProgramRebateMapping";
            public static string TableName() { return ProgramRebateMapping_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public ProgramRebateMappingEntity(){
            Init();
        }
        public ProgramRebateMappingEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public ProgramRebateMappingEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId){
            n_oDB=x_oDB;
            this.Load(x_iId);
            Init();
        }
        
        ~ProgramRebateMappingEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iId){
            if (n_oDB==null) { return false; }
            if (x_iId==null) { return false; }
            string _sQuery = "SELECT   [ProgramRebateMapping].[id] AS PROGRAMREBATEMAPPING_ID,[ProgramRebateMapping].[cdate] AS PROGRAMREBATEMAPPING_CDATE,[ProgramRebateMapping].[active] AS PROGRAMREBATEMAPPING_ACTIVE,[ProgramRebateMapping].[edate] AS PROGRAMREBATEMAPPING_EDATE,[ProgramRebateMapping].[program] AS PROGRAMREBATEMAPPING_PROGRAM,[ProgramRebateMapping].[issue_type] AS PROGRAMREBATEMAPPING_ISSUE_TYPE,[ProgramRebateMapping].[use_rebate_mapping] AS PROGRAMREBATEMAPPING_USE_REBATE_MAPPING,[ProgramRebateMapping].[sdate] AS PROGRAMREBATEMAPPING_SDATE  FROM  [ProgramRebateMapping]  WHERE  [ProgramRebateMapping].[id] = \'"+x_iId.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProgramRebateMapping]","["+ Configurator.MSSQLTablePrefix + "ProgramRebateMapping]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["PROGRAMREBATEMAPPING_ID"])) {n_iId = (global::System.Nullable<int>)_oData["PROGRAMREBATEMAPPING_ID"];}else{n_iId=null;}
                        if (!global::System.Convert.IsDBNull(_oData["PROGRAMREBATEMAPPING_CDATE"])) {n_dCdate = (global::System.Nullable<DateTime>)_oData["PROGRAMREBATEMAPPING_CDATE"];}else{n_dCdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["PROGRAMREBATEMAPPING_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["PROGRAMREBATEMAPPING_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["PROGRAMREBATEMAPPING_EDATE"])) {n_dEdate = (global::System.Nullable<DateTime>)_oData["PROGRAMREBATEMAPPING_EDATE"];}else{n_dEdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["PROGRAMREBATEMAPPING_PROGRAM"])) {n_sProgram = (string)_oData["PROGRAMREBATEMAPPING_PROGRAM"];}else{n_sProgram=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["PROGRAMREBATEMAPPING_ISSUE_TYPE"])) {n_sIssue_type = (string)_oData["PROGRAMREBATEMAPPING_ISSUE_TYPE"];}else{n_sIssue_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["PROGRAMREBATEMAPPING_USE_REBATE_MAPPING"])) {n_bUse_rebate_mapping = (global::System.Nullable<bool>)_oData["PROGRAMREBATEMAPPING_USE_REBATE_MAPPING"];}else{n_bUse_rebate_mapping=null;}
                        if (!global::System.Convert.IsDBNull(_oData["PROGRAMREBATEMAPPING_SDATE"])) {n_dSdate = (global::System.Nullable<DateTime>)_oData["PROGRAMREBATEMAPPING_SDATE"];}else{n_dSdate=null;}
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
            if (n_dEdate==null && !(n_oTableSet.Fields(Para.edate).IsNullable)) return false;
            if (n_sProgram==null && !(n_oTableSet.Fields(Para.program).IsNullable)) return false;
            if (n_sIssue_type==null && !(n_oTableSet.Fields(Para.issue_type).IsNullable)) return false;
            if (n_bUse_rebate_mapping==null && !(n_oTableSet.Fields(Para.use_rebate_mapping).IsNullable)) return false;
            if (n_dSdate==null && !(n_oTableSet.Fields(Para.sdate).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(ProgramRebateMappingEntity)) || (x_oObj is ProgramRebateMappingEntity)) return ProgramRebateMappingRepository.Instance();
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
        public ProgramRebateMappingInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(ProgramRebateMappingInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public global::System.Nullable<int> GetId(){return this.id;}
        public global::System.Nullable<DateTime> GetCdate(){return this.cdate;}
        public global::System.Nullable<bool> GetActive(){return this.active;}
        public global::System.Nullable<DateTime> GetEdate(){return this.edate;}
        public string GetProgram(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.program)) { return string.Empty; }
            return this.program;
        }
        public string GetIssue_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.issue_type)) { return string.Empty; }
            return this.issue_type;
        }
        public global::System.Nullable<bool> GetUse_rebate_mapping(){return this.use_rebate_mapping;}
        public global::System.Nullable<DateTime> GetSdate(){return this.sdate;}
        
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
        public bool SetEdate(global::System.Nullable<DateTime> value){
            this.edate=value;
            return true;
        }
        public bool SetProgram(string value){
            this.program=value;
            return true;
        }
        public bool SetIssue_type(string value){
            this.issue_type=value;
            return true;
        }
        public bool SetUse_rebate_mapping(global::System.Nullable<bool> value){
            this.use_rebate_mapping=value;
            return true;
        }
        public bool SetSdate(global::System.Nullable<DateTime> value){
            this.sdate=value;
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
        public Field GetEdateTable(){
            return n_oTableSet.Fields(Para.edate);
        }
        public Field GetProgramTable(){
            return n_oTableSet.Fields(Para.program);
        }
        public Field GetIssue_typeTable(){
            return n_oTableSet.Fields(Para.issue_type);
        }
        public Field GetUse_rebate_mappingTable(){
            return n_oTableSet.Fields(Para.use_rebate_mapping);
        }
        public Field GetSdateTable(){
            return n_oTableSet.Fields(Para.sdate);
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
        
        public bool EqualID(ProgramRebateMapping x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(ProgramRebateMapping x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_iId.Equals(x_oObj.id)){ return false; }
            if(!this.n_dCdate.Equals(x_oObj.cdate)){ return false; }
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_dEdate.Equals(x_oObj.edate)){ return false; }
            if(!this.n_sProgram.Equals(x_oObj.program)){ return false; }
            if(!this.n_sIssue_type.Equals(x_oObj.issue_type)){ return false; }
            if(!this.n_bUse_rebate_mapping.Equals(x_oObj.use_rebate_mapping)){ return false; }
            if(!this.n_dSdate.Equals(x_oObj.sdate)){ return false; }
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
            string _sQuery = "UPDATE  [ProgramRebateMapping]  SET  [cdate]=@cdate,[active]=@active,[edate]=@edate,[program]=@program,[issue_type]=@issue_type,[use_rebate_mapping]=@use_rebate_mapping,[sdate]=@sdate  WHERE [ProgramRebateMapping].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProgramRebateMapping]","["+ Configurator.MSSQLTablePrefix + "ProgramRebateMapping]"); }
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
            if(n_dEdate==null){  _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=n_dEdate; }
            if(n_sProgram==null){  _oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value=n_sProgram; }
            if(n_sIssue_type==null){  _oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value=n_sIssue_type; }
            if(n_bUse_rebate_mapping==null){  _oCmd.Parameters.Add("@use_rebate_mapping", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@use_rebate_mapping", global::System.Data.SqlDbType.Bit).Value=n_bUse_rebate_mapping; }
            if(n_dSdate==null){  _oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value=n_dSdate; }
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
        /// Summary description for table [ProgramRebateMapping] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iId==null) { return false; }
            string _sQuery="DELETE FROM  [ProgramRebateMapping]  WHERE [ProgramRebateMapping].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProgramRebateMapping]","["+ Configurator.MSSQLTablePrefix + "ProgramRebateMapping]"); }
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
        /// Summary description for table [ProgramRebateMapping] Object Base Clone
        /// </summary>
        
        public ProgramRebateMapping DeepClone()
        {
            ProgramRebateMapping _oProgramRebateMapping_Clone = new ProgramRebateMapping();
            _oProgramRebateMapping_Clone.id = this.n_iId;
            _oProgramRebateMapping_Clone.cdate = this.n_dCdate;
            _oProgramRebateMapping_Clone.active = this.n_bActive;
            _oProgramRebateMapping_Clone.edate = this.n_dEdate;
            _oProgramRebateMapping_Clone.program = this.n_sProgram;
            _oProgramRebateMapping_Clone.issue_type = this.n_sIssue_type;
            _oProgramRebateMapping_Clone.use_rebate_mapping = this.n_bUse_rebate_mapping;
            _oProgramRebateMapping_Clone.sdate = this.n_dSdate;
            _oProgramRebateMapping_Clone.SetFound(this.n_bFound);
            _oProgramRebateMapping_Clone.SetDB(this.n_oDB);
            _oProgramRebateMapping_Clone.SetRow(this.n_oRow);
            _oProgramRebateMapping_Clone.SetTbl(this.n_oTbl);
            _oProgramRebateMapping_Clone.SetTableSet(this.n_oTableSet);
            
            return _oProgramRebateMapping_Clone;
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
            n_dEdate=null;
            n_sProgram=global::System.String.Empty;
            n_sIssue_type=global::System.String.Empty;
            n_bUse_rebate_mapping=null;
            n_dSdate=null;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = ProgramRebateMappingInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


