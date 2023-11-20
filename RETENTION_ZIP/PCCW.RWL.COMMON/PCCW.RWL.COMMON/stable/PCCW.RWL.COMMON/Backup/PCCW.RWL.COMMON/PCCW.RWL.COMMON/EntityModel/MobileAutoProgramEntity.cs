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
///-- Create date: <Create Date 2010-06-11>
///-- Description:	<Description,Table :[MobileAutoProgram],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [MobileAutoProgram] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"MobileAutoProgram")]
    public class MobileAutoProgramEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        
        protected global::System.Nullable<DateTime> n_dRdate=null;
        #region rdate
        [System.Data.Linq.Mapping.Column(Name="[rdate]", Storage="n_dRdate")]
        public global::System.Nullable<DateTime> rdate{
            get{
                return this.n_dRdate;
            }
            set{
                this.n_dRdate=value;
            }
        }
        #endregion rdate
        
        
        protected string n_sAuto_name=global::System.String.Empty;
        #region auto_name
        [System.Data.Linq.Mapping.Column(Name="[auto_name]", Storage="n_sAuto_name")]
        public string auto_name{
            get{
                return this.n_sAuto_name;
            }
            set{
                this.n_sAuto_name=value;
            }
        }
        #endregion auto_name
        
        
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
        
        
        protected global::System.Nullable<Guid> n_gGuid=null;
        #region guid
        [System.Data.Linq.Mapping.Column(Name="[guid]", Storage="n_gGuid")]
        public global::System.Nullable<Guid> guid{
            get{
                return this.n_gGuid;
            }
            set{
                this.n_gGuid=value;
            }
        }
        #endregion guid
        
        
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
        private MobileAutoProgramInfo n_oTableSet = MobileAutoProgramInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string rdate="rdate";
            public const string auto_name="auto_name";
            public const string id="id";
            public const string guid="guid";
            public const string active="active";
            public const string MobileAutoProgram_table_name="MobileAutoProgram";
            public static string TableName() { return MobileAutoProgram_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public MobileAutoProgramEntity(){
            Init();
        }
        public MobileAutoProgramEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public MobileAutoProgramEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId){
            n_oDB=x_oDB;
            this.Load(x_iId);
            Init();
        }
        
        ~MobileAutoProgramEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iId){
            if (n_oDB==null) { return false; }
            if (x_iId==null) { return false; }
            string _sQuery = "SELECT   [MobileAutoProgram].[rdate] AS MOBILEAUTOPROGRAM_RDATE,[MobileAutoProgram].[auto_name] AS MOBILEAUTOPROGRAM_AUTO_NAME,[MobileAutoProgram].[active] AS MOBILEAUTOPROGRAM_ACTIVE,[MobileAutoProgram].[guid] AS MOBILEAUTOPROGRAM_GUID,[MobileAutoProgram].[id] AS MOBILEAUTOPROGRAM_ID  FROM  [MobileAutoProgram]  WHERE  [MobileAutoProgram].[id] = \'"+x_iId.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileAutoProgram]","["+ Configurator.MSSQLTablePrefix + "MobileAutoProgram]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEAUTOPROGRAM_RDATE"])) {n_dRdate = (global::System.Nullable<DateTime>)_oData["MOBILEAUTOPROGRAM_RDATE"];}else{n_dRdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEAUTOPROGRAM_AUTO_NAME"])) {n_sAuto_name = (string)_oData["MOBILEAUTOPROGRAM_AUTO_NAME"];}else{n_sAuto_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEAUTOPROGRAM_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["MOBILEAUTOPROGRAM_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEAUTOPROGRAM_GUID"])) {n_gGuid = (global::System.Nullable<Guid>)_oData["MOBILEAUTOPROGRAM_GUID"];}else{n_gGuid=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEAUTOPROGRAM_ID"])) {n_iId = (global::System.Nullable<int>)_oData["MOBILEAUTOPROGRAM_ID"];}else{n_iId=null;}
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
            if (n_dRdate==null && !(n_oTableSet.Fields(Para.rdate).IsNullable)) return false;
            if (n_sAuto_name==null && !(n_oTableSet.Fields(Para.auto_name).IsNullable)) return false;
            if (n_bActive==null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_gGuid==null && !(n_oTableSet.Fields(Para.guid).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(MobileAutoProgramEntity)) || (x_oObj is MobileAutoProgramEntity)) return MobileAutoProgramRepository.Instance();
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
        public MobileAutoProgramInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(MobileAutoProgramInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public global::System.Nullable<DateTime> GetRdate(){return this.rdate;}
        public string GetAuto_name(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.auto_name)) { return string.Empty; }
            return this.auto_name;
        }
        public global::System.Nullable<int> GetId(){return this.id;}
        public global::System.Nullable<Guid> GetGuid(){return this.guid;}
        public global::System.Nullable<bool> GetActive(){return this.active;}
        
        public bool SetRdate(global::System.Nullable<DateTime> value){
            this.rdate=value;
            return true;
        }
        public bool SetAuto_name(string value){
            this.auto_name=value;
            return true;
        }
        public bool SetId(global::System.Nullable<int> value){
            this.id=value;
            return true;
        }
        public bool SetGuid(global::System.Nullable<Guid> value){
            this.guid=value;
            return true;
        }
        public bool SetActive(global::System.Nullable<bool> value){
            this.active=value;
            return true;
        }
        
        public Field GetRdateTable(){
            return n_oTableSet.Fields(Para.rdate);
        }
        public Field GetAuto_nameTable(){
            return n_oTableSet.Fields(Para.auto_name);
        }
        public Field GetIdTable(){
            return n_oTableSet.Fields(Para.id);
        }
        public Field GetGuidTable(){
            return n_oTableSet.Fields(Para.guid);
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
        
        public bool EqualID(MobileAutoProgram x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(MobileAutoProgram x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_dRdate.Equals(x_oObj.rdate)){ return false; }
            if(!this.n_sAuto_name.Equals(x_oObj.auto_name)){ return false; }
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_gGuid.Equals(x_oObj.guid)){ return false; }
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
            string _sQuery = "UPDATE  [MobileAutoProgram]  SET  [rdate]=@rdate,[auto_name]=@auto_name,[active]=@active,[guid]=@guid  WHERE [MobileAutoProgram].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileAutoProgram]","["+ Configurator.MSSQLTablePrefix + "MobileAutoProgram]"); }
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
            if(n_dRdate==null){  _oCmd.Parameters.Add("@rdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@rdate", global::System.Data.SqlDbType.DateTime).Value=n_dRdate; }
            if(n_sAuto_name==null){  _oCmd.Parameters.Add("@auto_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@auto_name", global::System.Data.SqlDbType.NVarChar,250).Value=n_sAuto_name; }
            if(n_bActive==null){  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=n_bActive; }
            if(n_gGuid==null){  _oCmd.Parameters.Add("@guid", global::System.Data.SqlDbType.UniqueIdentifier).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@guid", global::System.Data.SqlDbType.UniqueIdentifier).Value=n_gGuid; }
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
        /// Summary description for table [MobileAutoProgram] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iId==null) { return false; }
            string _sQuery="DELETE FROM  [MobileAutoProgram]  WHERE [MobileAutoProgram].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileAutoProgram]","["+ Configurator.MSSQLTablePrefix + "MobileAutoProgram]"); }
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
        /// Summary description for table [MobileAutoProgram] Object Base Clone
        /// </summary>
        
        public MobileAutoProgram DeepClone()
        {
            MobileAutoProgram _oMobileAutoProgram_Clone = new MobileAutoProgram();
            _oMobileAutoProgram_Clone.rdate = this.n_dRdate;
            _oMobileAutoProgram_Clone.auto_name = this.n_sAuto_name;
            _oMobileAutoProgram_Clone.active = this.n_bActive;
            _oMobileAutoProgram_Clone.guid = this.n_gGuid;
            _oMobileAutoProgram_Clone.id = this.n_iId;
            _oMobileAutoProgram_Clone.SetFound(this.n_bFound);
            _oMobileAutoProgram_Clone.SetDB(this.n_oDB);
            _oMobileAutoProgram_Clone.SetRow(this.n_oRow);
            _oMobileAutoProgram_Clone.SetTbl(this.n_oTbl);
            _oMobileAutoProgram_Clone.SetTableSet(this.n_oTableSet);
            
            return _oMobileAutoProgram_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_dRdate=null;
            n_sAuto_name=global::System.String.Empty;
            n_bActive=null;
            n_gGuid=null;
            n_iId=null;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = MobileAutoProgramInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


