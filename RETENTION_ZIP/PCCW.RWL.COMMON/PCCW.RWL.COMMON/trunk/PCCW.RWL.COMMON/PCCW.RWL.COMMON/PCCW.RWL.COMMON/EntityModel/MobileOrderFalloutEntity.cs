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
///-- Create date: <Create Date 2010-04-20>
///-- Description:	<Description,Table :[MobileOrderFallout],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [MobileOrderFallout] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"MobileOrderFallout")]
    public class MobileOrderFalloutEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
        
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
        
        
        protected string n_sFollow_by=global::System.String.Empty;
        #region follow_by
        [System.Data.Linq.Mapping.Column(Name="[follow_by]", Storage="n_sFollow_by")]
        public string follow_by{
            get{
                return this.n_sFollow_by;
            }
            set{
                this.n_sFollow_by=value;
            }
        }
        #endregion follow_by
        
        
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
        
        
        protected string n_sFo_reason=global::System.String.Empty;
        #region fo_reason
        [System.Data.Linq.Mapping.Column(Name="[fo_reason]", Storage="n_sFo_reason")]
        public string fo_reason{
            get{
                return this.n_sFo_reason;
            }
            set{
                this.n_sFo_reason=value;
            }
        }
        #endregion fo_reason
        
        
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
        private MobileOrderFalloutInfo n_oTableSet = MobileOrderFalloutInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string active="active";
            public const string cdate="cdate";
            public const string cid="cid";
            public const string did="did";
            public const string ddate="ddate";
            public const string fo_reason="fo_reason";
            public const string mid="mid";
            public const string follow_by="follow_by";
            public const string MobileOrderFallout_table_name="MobileOrderFallout";
            public static string TableName() { return MobileOrderFallout_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public MobileOrderFalloutEntity(){
            Init();
        }
        public MobileOrderFalloutEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public MobileOrderFalloutEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid){
            n_oDB=x_oDB;
            this.Load(x_iMid);
            Init();
        }
        
        ~MobileOrderFalloutEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iMid){
            if (n_oDB==null) { return false; }
            if (x_iMid==null) { return false; }
            string _sQuery = "SELECT   [MobileOrderFallout].[did] AS MOBILEORDERFALLOUT_DID,[MobileOrderFallout].[cdate] AS MOBILEORDERFALLOUT_CDATE,[MobileOrderFallout].[cid] AS MOBILEORDERFALLOUT_CID,[MobileOrderFallout].[follow_by] AS MOBILEORDERFALLOUT_FOLLOW_BY,[MobileOrderFallout].[active] AS MOBILEORDERFALLOUT_ACTIVE,[MobileOrderFallout].[ddate] AS MOBILEORDERFALLOUT_DDATE,[MobileOrderFallout].[fo_reason] AS MOBILEORDERFALLOUT_FO_REASON,[MobileOrderFallout].[mid] AS MOBILEORDERFALLOUT_MID  FROM  [MobileOrderFallout]  WHERE  [MobileOrderFallout].[mid] = \'"+x_iMid.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderFallout]","["+ Configurator.MSSQLTablePrefix + "MobileOrderFallout]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERFALLOUT_DID"])) {n_sDid = (string)_oData["MOBILEORDERFALLOUT_DID"];}else{n_sDid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERFALLOUT_CDATE"])) {n_dCdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERFALLOUT_CDATE"];}else{n_dCdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERFALLOUT_CID"])) {n_sCid = (string)_oData["MOBILEORDERFALLOUT_CID"];}else{n_sCid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERFALLOUT_FOLLOW_BY"])) {n_sFollow_by = (string)_oData["MOBILEORDERFALLOUT_FOLLOW_BY"];}else{n_sFollow_by=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERFALLOUT_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["MOBILEORDERFALLOUT_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERFALLOUT_DDATE"])) {n_dDdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERFALLOUT_DDATE"];}else{n_dDdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERFALLOUT_FO_REASON"])) {n_sFo_reason = (string)_oData["MOBILEORDERFALLOUT_FO_REASON"];}else{n_sFo_reason=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERFALLOUT_MID"])) {n_iMid = (global::System.Nullable<int>)_oData["MOBILEORDERFALLOUT_MID"];}else{n_iMid=null;}
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
            if (n_sDid==null && !(n_oTableSet.Fields(Para.did).IsNullable)) return false;
            if (n_dCdate==null && !(n_oTableSet.Fields(Para.cdate).IsNullable)) return false;
            if (n_sCid==null && !(n_oTableSet.Fields(Para.cid).IsNullable)) return false;
            if (n_sFollow_by==null && !(n_oTableSet.Fields(Para.follow_by).IsNullable)) return false;
            if (n_bActive==null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_dDdate==null && !(n_oTableSet.Fields(Para.ddate).IsNullable)) return false;
            if (n_sFo_reason==null && !(n_oTableSet.Fields(Para.fo_reason).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(MobileOrderFalloutEntity)) || (x_oObj is MobileOrderFalloutEntity)) return MobileOrderFalloutRepository.Instance();
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
        public MobileOrderFalloutInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(MobileOrderFalloutInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public global::System.Nullable<bool> GetActive(){return this.active;}
        public global::System.Nullable<DateTime> GetCdate(){return this.cdate;}
        public string GetCid(){return this.cid;}
        public string GetDid(){return this.did;}
        public global::System.Nullable<DateTime> GetDdate(){return this.ddate;}
        public string GetFo_reason(){return this.fo_reason;}
        public global::System.Nullable<int> GetMid(){return this.mid;}
        public string GetFollow_by(){return this.follow_by;}
        
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
        public bool SetDdate(global::System.Nullable<DateTime> value){
            this.ddate=value;
            return true;
        }
        public bool SetFo_reason(string value){
            this.fo_reason=value;
            return true;
        }
        public bool SetMid(global::System.Nullable<int> value){
            this.mid=value;
            return true;
        }
        public bool SetFollow_by(string value){
            this.follow_by=value;
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
        public Field GetDdateTable(){
            return n_oTableSet.Fields(Para.ddate);
        }
        public Field GetFo_reasonTable(){
            return n_oTableSet.Fields(Para.fo_reason);
        }
        public Field GetMidTable(){
            return n_oTableSet.Fields(Para.mid);
        }
        public Field GetFollow_byTable(){
            return n_oTableSet.Fields(Para.follow_by);
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
        
        public bool EqualID(MobileOrderFallout x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iMid.Equals(x_oObj.mid)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(MobileOrderFallout x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_sDid.Equals(x_oObj.did)){ return false; }
            if(!this.n_dCdate.Equals(x_oObj.cdate)){ return false; }
            if(!this.n_sCid.Equals(x_oObj.cid)){ return false; }
            if(!this.n_sFollow_by.Equals(x_oObj.follow_by)){ return false; }
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_dDdate.Equals(x_oObj.ddate)){ return false; }
            if(!this.n_sFo_reason.Equals(x_oObj.fo_reason)){ return false; }
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
            string _sQuery = "UPDATE  [MobileOrderFallout]  SET  [did]=@did,[cdate]=@cdate,[cid]=@cid,[follow_by]=@follow_by,[active]=@active,[ddate]=@ddate,[fo_reason]=@fo_reason  WHERE [MobileOrderFallout].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderFallout]","["+ Configurator.MSSQLTablePrefix + "MobileOrderFallout]"); }
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
            if(n_sDid==null){  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value=n_sDid; }
            if(n_dCdate==null){  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=n_dCdate; }
            if(n_sCid==null){  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value=n_sCid; }
            if(n_sFollow_by==null){  _oCmd.Parameters.Add("@follow_by", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@follow_by", global::System.Data.SqlDbType.NVarChar,50).Value=n_sFollow_by; }
            if(n_bActive==null){  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=n_bActive; }
            if(n_dDdate==null){  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=n_dDdate; }
            if(n_sFo_reason==null){  _oCmd.Parameters.Add("@fo_reason", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@fo_reason", global::System.Data.SqlDbType.NVarChar,250).Value=n_sFo_reason; }
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
        /// Summary description for table [MobileOrderFallout] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iMid==null) { return false; }
            string _sQuery="DELETE FROM  [MobileOrderFallout]  WHERE [MobileOrderFallout].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderFallout]","["+ Configurator.MSSQLTablePrefix + "MobileOrderFallout]"); }
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
        /// Summary description for table [MobileOrderFallout] Object Base Clone
        /// </summary>
        
        public MobileOrderFallout DeepClone()
        {
            MobileOrderFallout _oMobileOrderFallout_Clone = new MobileOrderFallout();
            _oMobileOrderFallout_Clone.did = this.n_sDid;
            _oMobileOrderFallout_Clone.cdate = this.n_dCdate;
            _oMobileOrderFallout_Clone.cid = this.n_sCid;
            _oMobileOrderFallout_Clone.follow_by = this.n_sFollow_by;
            _oMobileOrderFallout_Clone.active = this.n_bActive;
            _oMobileOrderFallout_Clone.ddate = this.n_dDdate;
            _oMobileOrderFallout_Clone.fo_reason = this.n_sFo_reason;
            _oMobileOrderFallout_Clone.mid = this.n_iMid;
            _oMobileOrderFallout_Clone.SetFound(this.n_bFound);
            _oMobileOrderFallout_Clone.SetDB(this.n_oDB);
            _oMobileOrderFallout_Clone.SetRow(this.n_oRow);
            _oMobileOrderFallout_Clone.SetTbl(this.n_oTbl);
            _oMobileOrderFallout_Clone.SetTableSet(this.n_oTableSet);
            
            return _oMobileOrderFallout_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_sDid=global::System.String.Empty;
            n_dCdate=null;
            n_sCid=global::System.String.Empty;
            n_sFollow_by=global::System.String.Empty;
            n_bActive=null;
            n_dDdate=null;
            n_sFo_reason=global::System.String.Empty;
            n_iMid=null;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = MobileOrderFalloutInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


