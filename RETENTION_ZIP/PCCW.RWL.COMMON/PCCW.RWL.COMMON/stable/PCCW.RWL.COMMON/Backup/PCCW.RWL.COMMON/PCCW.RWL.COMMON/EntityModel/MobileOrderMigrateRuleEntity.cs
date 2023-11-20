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
///-- Create date: <Create Date 2010-08-20>
///-- Description:	<Description,Table :[MobileOrderMigrateRule],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [MobileOrderMigrateRule] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"MobileOrderMigrateRule")]
    public class MobileOrderMigrateRuleEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        
        protected string n_sType=global::System.String.Empty;
        #region type
        [System.Data.Linq.Mapping.Column(Name="[type]", Storage="n_sType")]
        public string type{
            get{
                return this.n_sType;
            }
            set{
                this.n_sType=value;
            }
        }
        #endregion type
        
        
        protected global::System.Nullable<bool> n_bChk=null;
        #region chk
        [System.Data.Linq.Mapping.Column(Name="[chk]", Storage="n_bChk")]
        public global::System.Nullable<bool> chk{
            get{
                return this.n_bChk;
            }
            set{
                this.n_bChk=value;
            }
        }
        #endregion chk
        
        
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
        
        
        protected string n_sSku=global::System.String.Empty;
        #region sku
        [System.Data.Linq.Mapping.Column(Name="[sku]", Storage="n_sSku")]
        public string sku{
            get{
                return this.n_sSku;
            }
            set{
                this.n_sSku=value;
            }
        }
        #endregion sku
        
        
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
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private MobileOrderMigrateRuleInfo n_oTableSet = MobileOrderMigrateRuleInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string id="id";
            public const string cdate="cdate";
            public const string cid="cid";
            public const string did="did";
            public const string status="status";
            public const string type="type";
            public const string chk="chk";
            public const string active="active";
            public const string name="name";
            public const string sku="sku";
            public const string ddate="ddate";
            public const string MobileOrderMigrateRule_table_name="MobileOrderMigrateRule";
            public static string TableName() { return MobileOrderMigrateRule_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public MobileOrderMigrateRuleEntity(){
            Init();
        }
        public MobileOrderMigrateRuleEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public MobileOrderMigrateRuleEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId){
            n_oDB=x_oDB;
            this.Load(x_iId);
            Init();
        }
        
        ~MobileOrderMigrateRuleEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iId){
            if (n_oDB==null) { return false; }
            if (x_iId==null) { return false; }
            string _sQuery = "SELECT   [MobileOrderMigrateRule].[id] AS MOBILEORDERMIGRATERULE_ID,[MobileOrderMigrateRule].[cdate] AS MOBILEORDERMIGRATERULE_CDATE,[MobileOrderMigrateRule].[cid] AS MOBILEORDERMIGRATERULE_CID,[MobileOrderMigrateRule].[did] AS MOBILEORDERMIGRATERULE_DID,[MobileOrderMigrateRule].[status] AS MOBILEORDERMIGRATERULE_STATUS,[MobileOrderMigrateRule].[type] AS MOBILEORDERMIGRATERULE_TYPE,[MobileOrderMigrateRule].[chk] AS MOBILEORDERMIGRATERULE_CHK,[MobileOrderMigrateRule].[active] AS MOBILEORDERMIGRATERULE_ACTIVE,[MobileOrderMigrateRule].[name] AS MOBILEORDERMIGRATERULE_NAME,[MobileOrderMigrateRule].[sku] AS MOBILEORDERMIGRATERULE_SKU,[MobileOrderMigrateRule].[ddate] AS MOBILEORDERMIGRATERULE_DDATE  FROM  [MobileOrderMigrateRule]  WHERE  [MobileOrderMigrateRule].[id] = \'"+x_iId.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMigrateRule]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMigrateRule]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_ID"])) {n_iId = (global::System.Nullable<int>)_oData["MOBILEORDERMIGRATERULE_ID"];}else{n_iId=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_CDATE"])) {n_dCdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERMIGRATERULE_CDATE"];}else{n_dCdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_CID"])) {n_sCid = (string)_oData["MOBILEORDERMIGRATERULE_CID"];}else{n_sCid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_DID"])) {n_sDid = (string)_oData["MOBILEORDERMIGRATERULE_DID"];}else{n_sDid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_STATUS"])) {n_sStatus = (string)_oData["MOBILEORDERMIGRATERULE_STATUS"];}else{n_sStatus=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_TYPE"])) {n_sType = (string)_oData["MOBILEORDERMIGRATERULE_TYPE"];}else{n_sType=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_CHK"])) {n_bChk = (global::System.Nullable<bool>)_oData["MOBILEORDERMIGRATERULE_CHK"];}else{n_bChk=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["MOBILEORDERMIGRATERULE_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_NAME"])) {n_sName = (string)_oData["MOBILEORDERMIGRATERULE_NAME"];}else{n_sName=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_SKU"])) {n_sSku = (string)_oData["MOBILEORDERMIGRATERULE_SKU"];}else{n_sSku=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_DDATE"])) {n_dDdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERMIGRATERULE_DDATE"];}else{n_dDdate=null;}
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
            if (n_sCid==null && !(n_oTableSet.Fields(Para.cid).IsNullable)) return false;
            if (n_sDid==null && !(n_oTableSet.Fields(Para.did).IsNullable)) return false;
            if (n_sStatus==null && !(n_oTableSet.Fields(Para.status).IsNullable)) return false;
            if (n_sType==null && !(n_oTableSet.Fields(Para.type).IsNullable)) return false;
            if (n_bChk==null && !(n_oTableSet.Fields(Para.chk).IsNullable)) return false;
            if (n_bActive==null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_sName==null && !(n_oTableSet.Fields(Para.name).IsNullable)) return false;
            if (n_sSku==null && !(n_oTableSet.Fields(Para.sku).IsNullable)) return false;
            if (n_dDdate==null && !(n_oTableSet.Fields(Para.ddate).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(MobileOrderMigrateRuleEntity)) || (x_oObj is MobileOrderMigrateRuleEntity)) return MobileOrderMigrateRuleRepository.Instance();
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
        public MobileOrderMigrateRuleInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(MobileOrderMigrateRuleInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public global::System.Nullable<int> GetId(){return this.id;}
        public global::System.Nullable<DateTime> GetCdate(){return this.cdate;}
        public string GetCid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.cid)) { return string.Empty; }
            return this.cid;
        }
        public string GetDid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.did)) { return string.Empty; }
            return this.did;
        }
        public string GetStatus(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.status)) { return string.Empty; }
            return this.status;
        }
        public string GetType(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.type)) { return string.Empty; }
            return this.type;
        }
        public global::System.Nullable<bool> GetChk(){return this.chk;}
        public global::System.Nullable<bool> GetActive(){return this.active;}
        public string GetName(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.name)) { return string.Empty; }
            return this.name;
        }
        public string GetSku(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.sku)) { return string.Empty; }
            return this.sku;
        }
        public global::System.Nullable<DateTime> GetDdate(){return this.ddate;}
        
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
        public bool SetDid(string value){
            this.did=value;
            return true;
        }
        public bool SetStatus(string value){
            this.status=value;
            return true;
        }
        public bool SetType(string value){
            this.type=value;
            return true;
        }
        public bool SetChk(global::System.Nullable<bool> value){
            this.chk=value;
            return true;
        }
        public bool SetActive(global::System.Nullable<bool> value){
            this.active=value;
            return true;
        }
        public bool SetName(string value){
            this.name=value;
            return true;
        }
        public bool SetSku(string value){
            this.sku=value;
            return true;
        }
        public bool SetDdate(global::System.Nullable<DateTime> value){
            this.ddate=value;
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
        public Field GetDidTable(){
            return n_oTableSet.Fields(Para.did);
        }
        public Field GetStatusTable(){
            return n_oTableSet.Fields(Para.status);
        }
        public Field GetTypeTable(){
            return n_oTableSet.Fields(Para.type);
        }
        public Field GetChkTable(){
            return n_oTableSet.Fields(Para.chk);
        }
        public Field GetActiveTable(){
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetNameTable(){
            return n_oTableSet.Fields(Para.name);
        }
        public Field GetSkuTable(){
            return n_oTableSet.Fields(Para.sku);
        }
        public Field GetDdateTable(){
            return n_oTableSet.Fields(Para.ddate);
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
        
        public bool EqualID(MobileOrderMigrateRule x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(MobileOrderMigrateRule x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_iId.Equals(x_oObj.id)){ return false; }
            if(!this.n_dCdate.Equals(x_oObj.cdate)){ return false; }
            if(!this.n_sCid.Equals(x_oObj.cid)){ return false; }
            if(!this.n_sDid.Equals(x_oObj.did)){ return false; }
            if(!this.n_sStatus.Equals(x_oObj.status)){ return false; }
            if(!this.n_sType.Equals(x_oObj.type)){ return false; }
            if(!this.n_bChk.Equals(x_oObj.chk)){ return false; }
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_sName.Equals(x_oObj.name)){ return false; }
            if(!this.n_sSku.Equals(x_oObj.sku)){ return false; }
            if(!this.n_dDdate.Equals(x_oObj.ddate)){ return false; }
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
            string _sQuery = "UPDATE  [MobileOrderMigrateRule]  SET  [cdate]=@cdate,[cid]=@cid,[did]=@did,[status]=@status,[type]=@type,[chk]=@chk,[active]=@active,[name]=@name,[sku]=@sku,[ddate]=@ddate  WHERE [MobileOrderMigrateRule].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMigrateRule]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMigrateRule]"); }
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
            if(n_sCid==null){  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=n_sCid; }
            if(n_sDid==null){  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value=n_sDid; }
            if(n_sStatus==null){  _oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NVarChar,50).Value=n_sStatus; }
            if(n_sType==null){  _oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar,50).Value=n_sType; }
            if(n_bChk==null){  _oCmd.Parameters.Add("@chk", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@chk", global::System.Data.SqlDbType.Bit).Value=n_bChk; }
            if(n_bActive==null){  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=n_bActive; }
            if(n_sName==null){  _oCmd.Parameters.Add("@name", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@name", global::System.Data.SqlDbType.NVarChar,50).Value=n_sName; }
            if(n_sSku==null){  _oCmd.Parameters.Add("@sku", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@sku", global::System.Data.SqlDbType.NVarChar,50).Value=n_sSku; }
            if(n_dDdate==null){  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=n_dDdate; }
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
        /// Summary description for table [MobileOrderMigrateRule] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iId==null) { return false; }
            string _sQuery="DELETE FROM  [MobileOrderMigrateRule]  WHERE [MobileOrderMigrateRule].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMigrateRule]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMigrateRule]"); }
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
        /// Summary description for table [MobileOrderMigrateRule] Object Base Clone
        /// </summary>
        
        public MobileOrderMigrateRule DeepClone()
        {
            MobileOrderMigrateRule _oMobileOrderMigrateRule_Clone = new MobileOrderMigrateRule();
            _oMobileOrderMigrateRule_Clone.id = this.n_iId;
            _oMobileOrderMigrateRule_Clone.cdate = this.n_dCdate;
            _oMobileOrderMigrateRule_Clone.cid = this.n_sCid;
            _oMobileOrderMigrateRule_Clone.did = this.n_sDid;
            _oMobileOrderMigrateRule_Clone.status = this.n_sStatus;
            _oMobileOrderMigrateRule_Clone.type = this.n_sType;
            _oMobileOrderMigrateRule_Clone.chk = this.n_bChk;
            _oMobileOrderMigrateRule_Clone.active = this.n_bActive;
            _oMobileOrderMigrateRule_Clone.name = this.n_sName;
            _oMobileOrderMigrateRule_Clone.sku = this.n_sSku;
            _oMobileOrderMigrateRule_Clone.ddate = this.n_dDdate;
            _oMobileOrderMigrateRule_Clone.SetFound(this.n_bFound);
            _oMobileOrderMigrateRule_Clone.SetDB(this.n_oDB);
            _oMobileOrderMigrateRule_Clone.SetRow(this.n_oRow);
            _oMobileOrderMigrateRule_Clone.SetTbl(this.n_oTbl);
            _oMobileOrderMigrateRule_Clone.SetTableSet(this.n_oTableSet);
            
            return _oMobileOrderMigrateRule_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_iId=null;
            n_dCdate=null;
            n_sCid=global::System.String.Empty;
            n_sDid=global::System.String.Empty;
            n_sStatus=global::System.String.Empty;
            n_sType=global::System.String.Empty;
            n_bChk=null;
            n_bActive=null;
            n_sName=global::System.String.Empty;
            n_sSku=global::System.String.Empty;
            n_dDdate=null;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = MobileOrderMigrateRuleInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


