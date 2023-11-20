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
///-- Description:	<Description,Table :[MobileOrderIssueRestrictionProfile],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [MobileOrderIssueRestrictionProfile] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"MobileOrderIssueRestrictionProfile")]
    public class MobileOrderIssueRestrictionProfileEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        
        protected global::System.Nullable<int> n_iMrt_no=null;
        #region mrt_no
        [System.Data.Linq.Mapping.Column(Name="[mrt_no]", Storage="n_iMrt_no")]
        public global::System.Nullable<int> mrt_no{
            get{
                return this.n_iMrt_no;
            }
            set{
                this.n_iMrt_no=value;
            }
        }
        #endregion mrt_no
        
        
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
        private MobileOrderIssueRestrictionProfileInfo n_oTableSet = MobileOrderIssueRestrictionProfileInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string mid="mid";
            public const string cdate="cdate";
            public const string mrt_no="mrt_no";
            public const string cid="cid";
            public const string active="active";
            public const string restriction_id="restriction_id";
            public const string MobileOrderIssueRestrictionProfile_table_name="MobileOrderIssueRestrictionProfile";
            public static string TableName() { return MobileOrderIssueRestrictionProfile_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public MobileOrderIssueRestrictionProfileEntity(){
            Init();
        }
        public MobileOrderIssueRestrictionProfileEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public MobileOrderIssueRestrictionProfileEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid){
            n_oDB=x_oDB;
            this.Load(x_iMid);
            Init();
        }
        
        ~MobileOrderIssueRestrictionProfileEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iMid){
            if (n_oDB==null) { return false; }
            if (x_iMid==null) { return false; }
            string _sQuery = "SELECT   [MobileOrderIssueRestrictionProfile].[active] AS MOBILEORDERISSUERESTRICTIONPROFILE_ACTIVE,[MobileOrderIssueRestrictionProfile].[cdate] AS MOBILEORDERISSUERESTRICTIONPROFILE_CDATE,[MobileOrderIssueRestrictionProfile].[mrt_no] AS MOBILEORDERISSUERESTRICTIONPROFILE_MRT_NO,[MobileOrderIssueRestrictionProfile].[cid] AS MOBILEORDERISSUERESTRICTIONPROFILE_CID,[MobileOrderIssueRestrictionProfile].[mid] AS MOBILEORDERISSUERESTRICTIONPROFILE_MID,[MobileOrderIssueRestrictionProfile].[restriction_id] AS MOBILEORDERISSUERESTRICTIONPROFILE_RESTRICTION_ID  FROM  [MobileOrderIssueRestrictionProfile]  WHERE  [MobileOrderIssueRestrictionProfile].[mid] = \'"+x_iMid.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderIssueRestrictionProfile]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestrictionProfile]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONPROFILE_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["MOBILEORDERISSUERESTRICTIONPROFILE_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONPROFILE_CDATE"])) {n_dCdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERISSUERESTRICTIONPROFILE_CDATE"];}else{n_dCdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONPROFILE_MRT_NO"])) {n_iMrt_no = (global::System.Nullable<int>)_oData["MOBILEORDERISSUERESTRICTIONPROFILE_MRT_NO"];}else{n_iMrt_no=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONPROFILE_CID"])) {n_sCid = (string)_oData["MOBILEORDERISSUERESTRICTIONPROFILE_CID"];}else{n_sCid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONPROFILE_MID"])) {n_iMid = (global::System.Nullable<int>)_oData["MOBILEORDERISSUERESTRICTIONPROFILE_MID"];}else{n_iMid=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONPROFILE_RESTRICTION_ID"])) {n_iRestriction_id = (global::System.Nullable<int>)_oData["MOBILEORDERISSUERESTRICTIONPROFILE_RESTRICTION_ID"];}else{n_iRestriction_id=null;}
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
            if (n_iMrt_no==null && !(n_oTableSet.Fields(Para.mrt_no).IsNullable)) return false;
            if (n_sCid==null && !(n_oTableSet.Fields(Para.cid).IsNullable)) return false;
            if(!x_bInsert){
                if (n_iMid==null && !(n_oTableSet.Fields(Para.mid).IsNullable)) return false;
            }
            if (n_iRestriction_id==null && !(n_oTableSet.Fields(Para.restriction_id).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(MobileOrderIssueRestrictionProfileEntity)) || (x_oObj is MobileOrderIssueRestrictionProfileEntity)) return MobileOrderIssueRestrictionProfileRepository.Instance();
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
        public MobileOrderIssueRestrictionProfileInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(MobileOrderIssueRestrictionProfileInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public global::System.Nullable<int> GetMid(){return this.mid;}
        public global::System.Nullable<DateTime> GetCdate(){return this.cdate;}
        public global::System.Nullable<int> GetMrt_no(){return this.mrt_no;}
        public string GetCid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.cid)) { return string.Empty; }
            return this.cid;
        }
        public global::System.Nullable<bool> GetActive(){return this.active;}
        public global::System.Nullable<int> GetRestriction_id(){return this.restriction_id;}
        
        public bool SetMid(global::System.Nullable<int> value){
            this.mid=value;
            return true;
        }
        public bool SetCdate(global::System.Nullable<DateTime> value){
            this.cdate=value;
            return true;
        }
        public bool SetMrt_no(global::System.Nullable<int> value){
            this.mrt_no=value;
            return true;
        }
        public bool SetCid(string value){
            this.cid=value;
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
        
        public Field GetMidTable(){
            return n_oTableSet.Fields(Para.mid);
        }
        public Field GetCdateTable(){
            return n_oTableSet.Fields(Para.cdate);
        }
        public Field GetMrt_noTable(){
            return n_oTableSet.Fields(Para.mrt_no);
        }
        public Field GetCidTable(){
            return n_oTableSet.Fields(Para.cid);
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
        
        public bool EqualID(MobileOrderIssueRestrictionProfile x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iMid.Equals(x_oObj.mid)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(MobileOrderIssueRestrictionProfile x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_dCdate.Equals(x_oObj.cdate)){ return false; }
            if(!this.n_iMrt_no.Equals(x_oObj.mrt_no)){ return false; }
            if(!this.n_sCid.Equals(x_oObj.cid)){ return false; }
            if(!this.n_iMid.Equals(x_oObj.mid)){ return false; }
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
            string _sQuery = "UPDATE  [MobileOrderIssueRestrictionProfile]  SET  [active]=@active,[cdate]=@cdate,[mrt_no]=@mrt_no,[cid]=@cid,[restriction_id]=@restriction_id  WHERE [MobileOrderIssueRestrictionProfile].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderIssueRestrictionProfile]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestrictionProfile]"); }
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
            if(n_iMrt_no==null){  _oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.Int).Value=n_iMrt_no; }
            if(n_sCid==null){  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=n_sCid; }
            if(n_iMid==null){  _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value=n_iMid; }
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
        /// Summary description for table [MobileOrderIssueRestrictionProfile] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iMid==null) { return false; }
            string _sQuery="DELETE FROM  [MobileOrderIssueRestrictionProfile]  WHERE [MobileOrderIssueRestrictionProfile].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderIssueRestrictionProfile]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestrictionProfile]"); }
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
        /// Summary description for table [MobileOrderIssueRestrictionProfile] Object Base Clone
        /// </summary>
        
        public MobileOrderIssueRestrictionProfile DeepClone()
        {
            MobileOrderIssueRestrictionProfile _oMobileOrderIssueRestrictionProfile_Clone = new MobileOrderIssueRestrictionProfile();
            _oMobileOrderIssueRestrictionProfile_Clone.active = this.n_bActive;
            _oMobileOrderIssueRestrictionProfile_Clone.cdate = this.n_dCdate;
            _oMobileOrderIssueRestrictionProfile_Clone.mrt_no = this.n_iMrt_no;
            _oMobileOrderIssueRestrictionProfile_Clone.cid = this.n_sCid;
            _oMobileOrderIssueRestrictionProfile_Clone.mid = this.n_iMid;
            _oMobileOrderIssueRestrictionProfile_Clone.restriction_id = this.n_iRestriction_id;
            _oMobileOrderIssueRestrictionProfile_Clone.SetFound(this.n_bFound);
            _oMobileOrderIssueRestrictionProfile_Clone.SetDB(this.n_oDB);
            _oMobileOrderIssueRestrictionProfile_Clone.SetRow(this.n_oRow);
            _oMobileOrderIssueRestrictionProfile_Clone.SetTbl(this.n_oTbl);
            _oMobileOrderIssueRestrictionProfile_Clone.SetTableSet(this.n_oTableSet);
            
            return _oMobileOrderIssueRestrictionProfile_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_bActive=null;
            n_dCdate=null;
            n_iMrt_no=null;
            n_sCid=global::System.String.Empty;
            n_iMid=null;
            n_iRestriction_id=null;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = MobileOrderIssueRestrictionProfileInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


