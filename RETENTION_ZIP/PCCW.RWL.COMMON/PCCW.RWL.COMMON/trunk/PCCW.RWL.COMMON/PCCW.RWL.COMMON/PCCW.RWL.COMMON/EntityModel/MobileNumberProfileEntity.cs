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
///-- Create date: <Create Date 2011-09-01>
///-- Description:	<Description,Table :[MobileNumberProfile],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [MobileNumberProfile] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"MobileNumberProfile")]
    public class MobileNumberProfileEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        
        protected string n_sPool=global::System.String.Empty;
        #region pool
        [System.Data.Linq.Mapping.Column(Name="[pool]", Storage="n_sPool")]
        public string pool{
            get{
                return this.n_sPool;
            }
            set{
                this.n_sPool=value;
            }
        }
        #endregion pool
        
        
        protected global::System.Nullable<long> n_lMrt_no=null;
        #region mrt_no
        [System.Data.Linq.Mapping.Column(Name="[mrt_no]", Storage="n_lMrt_no")]
        public global::System.Nullable<long> mrt_no{
            get{
                return this.n_lMrt_no;
            }
            set{
                this.n_lMrt_no=value;
            }
        }
        #endregion mrt_no
        
        
        protected string n_sStatus=global::System.String.Empty;
        #region status
        [System.Data.Linq.Mapping.Column(Name="[status]", Storage="n_sStatus")]
        public string status{
            get{
                return this.n_sStatus;
            }
            set{
                this.n_sStatus=value;
            }
        }
        #endregion status
        
        
        protected string n_sMrt_group=global::System.String.Empty;
        #region mrt_group
        [System.Data.Linq.Mapping.Column(Name="[mrt_group]", Storage="n_sMrt_group")]
        public string mrt_group{
            get{
                return this.n_sMrt_group;
            }
            set{
                this.n_sMrt_group=value;
            }
        }
        #endregion mrt_group
        
        
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
        
        
        protected string n_sEdf_no=global::System.String.Empty;
        #region edf_no
        [System.Data.Linq.Mapping.Column(Name="[edf_no]", Storage="n_sEdf_no")]
        public string edf_no{
            get{
                return this.n_sEdf_no;
            }
            set{
                this.n_sEdf_no=value;
            }
        }
        #endregion edf_no
        
        
        protected global::System.Nullable<int> n_iOrder_id=null;
        #region order_id
        [System.Data.Linq.Mapping.Column(Name="[order_id]", Storage="n_iOrder_id")]
        public global::System.Nullable<int> order_id{
            get{
                return this.n_iOrder_id;
            }
            set{
                this.n_iOrder_id=value;
            }
        }
        #endregion order_id
        
        
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
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private MobileNumberProfileInfo n_oTableSet = MobileNumberProfileInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string pool="pool";
            public const string id="id";
            public const string cdate="cdate";
            public const string cid="cid";
            public const string mrt_no="mrt_no";
            public const string status="status";
            public const string mrt_group="mrt_group";
            public const string active="active";
            public const string edf_no="edf_no";
            public const string order_id="order_id";
            public const string ddate="ddate";
            public const string did="did";
            public const string MobileNumberProfile_table_name="MobileNumberProfile";
            public static string TableName() { return MobileNumberProfile_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public MobileNumberProfileEntity(){
            Init();
        }
        public MobileNumberProfileEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public MobileNumberProfileEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId){
            n_oDB=x_oDB;
            this.Load(x_iId);
            Init();
        }
        
        ~MobileNumberProfileEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iId){
            if (n_oDB==null) { return false; }
            if (x_iId==null) { return false; }
            string _sQuery = "SELECT   [MobileNumberProfile].[cid] AS MOBILENUMBERPROFILE_CID,[MobileNumberProfile].[id] AS MOBILENUMBERPROFILE_ID,[MobileNumberProfile].[cdate] AS MOBILENUMBERPROFILE_CDATE,[MobileNumberProfile].[pool] AS MOBILENUMBERPROFILE_POOL,[MobileNumberProfile].[mrt_no] AS MOBILENUMBERPROFILE_MRT_NO,[MobileNumberProfile].[status] AS MOBILENUMBERPROFILE_STATUS,[MobileNumberProfile].[mrt_group] AS MOBILENUMBERPROFILE_MRT_GROUP,[MobileNumberProfile].[active] AS MOBILENUMBERPROFILE_ACTIVE,[MobileNumberProfile].[edf_no] AS MOBILENUMBERPROFILE_EDF_NO,[MobileNumberProfile].[order_id] AS MOBILENUMBERPROFILE_ORDER_ID,[MobileNumberProfile].[ddate] AS MOBILENUMBERPROFILE_DDATE,[MobileNumberProfile].[did] AS MOBILENUMBERPROFILE_DID  FROM  [MobileNumberProfile]  WHERE  [MobileNumberProfile].[id] = \'"+x_iId.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileNumberProfile]","["+ Configurator.MSSQLTablePrefix + "MobileNumberProfile]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_CID"])) {n_sCid = (string)_oData["MOBILENUMBERPROFILE_CID"];}else{n_sCid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_ID"])) {n_iId = (global::System.Nullable<int>)_oData["MOBILENUMBERPROFILE_ID"];}else{n_iId=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_CDATE"])) {n_dCdate = (global::System.Nullable<DateTime>)_oData["MOBILENUMBERPROFILE_CDATE"];}else{n_dCdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_POOL"])) {n_sPool = (string)_oData["MOBILENUMBERPROFILE_POOL"];}else{n_sPool=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_MRT_NO"])) {n_lMrt_no = (global::System.Nullable<long>)_oData["MOBILENUMBERPROFILE_MRT_NO"];}else{n_lMrt_no=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_STATUS"])) {n_sStatus = (string)_oData["MOBILENUMBERPROFILE_STATUS"];}else{n_sStatus=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_MRT_GROUP"])) {n_sMrt_group = (string)_oData["MOBILENUMBERPROFILE_MRT_GROUP"];}else{n_sMrt_group=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["MOBILENUMBERPROFILE_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_EDF_NO"])) {n_sEdf_no = (string)_oData["MOBILENUMBERPROFILE_EDF_NO"];}else{n_sEdf_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_ORDER_ID"])) {n_iOrder_id = (global::System.Nullable<int>)_oData["MOBILENUMBERPROFILE_ORDER_ID"];}else{n_iOrder_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_DDATE"])) {n_dDdate = (global::System.Nullable<DateTime>)_oData["MOBILENUMBERPROFILE_DDATE"];}else{n_dDdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_DID"])) {n_sDid = (string)_oData["MOBILENUMBERPROFILE_DID"];}else{n_sDid=global::System.String.Empty;}
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
            if (n_sCid==null && !(n_oTableSet.Fields(Para.cid).IsNullable)) return false;
            if(!x_bInsert){
                if (n_iId==null && !(n_oTableSet.Fields(Para.id).IsNullable)) return false;
            }
            if (n_dCdate==null && !(n_oTableSet.Fields(Para.cdate).IsNullable)) return false;
            if (n_sPool==null && !(n_oTableSet.Fields(Para.pool).IsNullable)) return false;
            if (n_lMrt_no==null && !(n_oTableSet.Fields(Para.mrt_no).IsNullable)) return false;
            if (n_sStatus==null && !(n_oTableSet.Fields(Para.status).IsNullable)) return false;
            if (n_sMrt_group==null && !(n_oTableSet.Fields(Para.mrt_group).IsNullable)) return false;
            if (n_bActive==null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_sEdf_no==null && !(n_oTableSet.Fields(Para.edf_no).IsNullable)) return false;
            if (n_iOrder_id==null && !(n_oTableSet.Fields(Para.order_id).IsNullable)) return false;
            if (n_dDdate==null && !(n_oTableSet.Fields(Para.ddate).IsNullable)) return false;
            if (n_sDid==null && !(n_oTableSet.Fields(Para.did).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(MobileNumberProfileEntity)) || (x_oObj is MobileNumberProfileEntity)) return MobileNumberProfileRepository.Instance();
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
        public MobileNumberProfileInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(MobileNumberProfileInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public string GetPool(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.pool)) { return string.Empty; }
            return this.pool;
        }
        public global::System.Nullable<int> GetId(){return this.id;}
        public global::System.Nullable<DateTime> GetCdate(){return this.cdate;}
        public string GetCid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.cid)) { return string.Empty; }
            return this.cid;
        }
        public global::System.Nullable<long> GetMrt_no(){return this.mrt_no;}
        public string GetStatus(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.status)) { return string.Empty; }
            return this.status;
        }
        public string GetMrt_group(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.mrt_group)) { return string.Empty; }
            return this.mrt_group;
        }
        public global::System.Nullable<bool> GetActive(){return this.active;}
        public string GetEdf_no(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.edf_no)) { return string.Empty; }
            return this.edf_no;
        }
        public global::System.Nullable<int> GetOrder_id(){return this.order_id;}
        public global::System.Nullable<DateTime> GetDdate(){return this.ddate;}
        public string GetDid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.did)) { return string.Empty; }
            return this.did;
        }
        
        public bool SetPool(string value){
            this.pool=value;
            return true;
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
        public bool SetMrt_no(global::System.Nullable<long> value){
            this.mrt_no=value;
            return true;
        }
        public bool SetStatus(string value){
            this.status=value;
            return true;
        }
        public bool SetMrt_group(string value){
            this.mrt_group=value;
            return true;
        }
        public bool SetActive(global::System.Nullable<bool> value){
            this.active=value;
            return true;
        }
        public bool SetEdf_no(string value){
            this.edf_no=value;
            return true;
        }
        public bool SetOrder_id(global::System.Nullable<int> value){
            this.order_id=value;
            return true;
        }
        public bool SetDdate(global::System.Nullable<DateTime> value){
            this.ddate=value;
            return true;
        }
        public bool SetDid(string value){
            this.did=value;
            return true;
        }
        
        public Field GetPoolTable(){
            return n_oTableSet.Fields(Para.pool);
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
        public Field GetMrt_noTable(){
            return n_oTableSet.Fields(Para.mrt_no);
        }
        public Field GetStatusTable(){
            return n_oTableSet.Fields(Para.status);
        }
        public Field GetMrt_groupTable(){
            return n_oTableSet.Fields(Para.mrt_group);
        }
        public Field GetActiveTable(){
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetEdf_noTable(){
            return n_oTableSet.Fields(Para.edf_no);
        }
        public Field GetOrder_idTable(){
            return n_oTableSet.Fields(Para.order_id);
        }
        public Field GetDdateTable(){
            return n_oTableSet.Fields(Para.ddate);
        }
        public Field GetDidTable(){
            return n_oTableSet.Fields(Para.did);
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
        
        public bool EqualID(MobileNumberProfile x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(MobileNumberProfile x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_sCid.Equals(x_oObj.cid)){ return false; }
            if(!this.n_iId.Equals(x_oObj.id)){ return false; }
            if(!this.n_dCdate.Equals(x_oObj.cdate)){ return false; }
            if(!this.n_sPool.Equals(x_oObj.pool)){ return false; }
            if(!this.n_lMrt_no.Equals(x_oObj.mrt_no)){ return false; }
            if(!this.n_sStatus.Equals(x_oObj.status)){ return false; }
            if(!this.n_sMrt_group.Equals(x_oObj.mrt_group)){ return false; }
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_sEdf_no.Equals(x_oObj.edf_no)){ return false; }
            if(!this.n_iOrder_id.Equals(x_oObj.order_id)){ return false; }
            if(!this.n_dDdate.Equals(x_oObj.ddate)){ return false; }
            if(!this.n_sDid.Equals(x_oObj.did)){ return false; }
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
            string _sQuery = "UPDATE  [MobileNumberProfile]  SET  [cid]=@cid,[cdate]=@cdate,[pool]=@pool,[mrt_no]=@mrt_no,[status]=@status,[mrt_group]=@mrt_group,[active]=@active,[edf_no]=@edf_no,[order_id]=@order_id,[ddate]=@ddate,[did]=@did  WHERE [MobileNumberProfile].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileNumberProfile]","["+ Configurator.MSSQLTablePrefix + "MobileNumberProfile]"); }
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
            if(n_sCid==null){  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value=n_sCid; }
            if(n_iId==null){  _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value=n_iId; }
            if(n_dCdate==null){  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=n_dCdate; }
            if(n_sPool==null){  _oCmd.Parameters.Add("@pool", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@pool", global::System.Data.SqlDbType.NVarChar,50).Value=n_sPool; }
            if(n_lMrt_no==null){  _oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.BigInt).Value=n_lMrt_no; }
            if(n_sStatus==null){  _oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NVarChar,50).Value=n_sStatus; }
            if(n_sMrt_group==null){  _oCmd.Parameters.Add("@mrt_group", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@mrt_group", global::System.Data.SqlDbType.NVarChar,50).Value=n_sMrt_group; }
            if(n_bActive==null){  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=n_bActive; }
            if(n_sEdf_no==null){  _oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,15).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,15).Value=n_sEdf_no; }
            if(n_iOrder_id==null){  _oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=n_iOrder_id; }
            if(n_dDdate==null){  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=n_dDdate; }
            if(n_sDid==null){  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10).Value=n_sDid; }
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
        /// Summary description for table [MobileNumberProfile] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iId==null) { return false; }
            string _sQuery="DELETE FROM  [MobileNumberProfile]  WHERE [MobileNumberProfile].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileNumberProfile]","["+ Configurator.MSSQLTablePrefix + "MobileNumberProfile]"); }
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
        /// Summary description for table [MobileNumberProfile] Object Base Clone
        /// </summary>
        
        public MobileNumberProfile DeepClone()
        {
            MobileNumberProfile _oMobileNumberProfile_Clone = new MobileNumberProfile();
            _oMobileNumberProfile_Clone.cid = this.n_sCid;
            _oMobileNumberProfile_Clone.id = this.n_iId;
            _oMobileNumberProfile_Clone.cdate = this.n_dCdate;
            _oMobileNumberProfile_Clone.pool = this.n_sPool;
            _oMobileNumberProfile_Clone.mrt_no = this.n_lMrt_no;
            _oMobileNumberProfile_Clone.status = this.n_sStatus;
            _oMobileNumberProfile_Clone.mrt_group = this.n_sMrt_group;
            _oMobileNumberProfile_Clone.active = this.n_bActive;
            _oMobileNumberProfile_Clone.edf_no = this.n_sEdf_no;
            _oMobileNumberProfile_Clone.order_id = this.n_iOrder_id;
            _oMobileNumberProfile_Clone.ddate = this.n_dDdate;
            _oMobileNumberProfile_Clone.did = this.n_sDid;
            _oMobileNumberProfile_Clone.SetFound(this.n_bFound);
            _oMobileNumberProfile_Clone.SetDB(this.n_oDB);
            _oMobileNumberProfile_Clone.SetRow(this.n_oRow);
            _oMobileNumberProfile_Clone.SetTbl(this.n_oTbl);
            _oMobileNumberProfile_Clone.SetTableSet(this.n_oTableSet);
            
            return _oMobileNumberProfile_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_sCid=global::System.String.Empty;
            n_iId=null;
            n_dCdate=null;
            n_sPool=global::System.String.Empty;
            n_lMrt_no=null;
            n_sStatus=global::System.String.Empty;
            n_sMrt_group=global::System.String.Empty;
            n_bActive=null;
            n_sEdf_no=global::System.String.Empty;
            n_iOrder_id=null;
            n_dDdate=null;
            n_sDid=global::System.String.Empty;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = MobileNumberProfileInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


