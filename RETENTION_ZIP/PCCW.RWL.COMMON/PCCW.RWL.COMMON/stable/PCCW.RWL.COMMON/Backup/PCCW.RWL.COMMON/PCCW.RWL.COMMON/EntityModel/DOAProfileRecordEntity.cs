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
///-- Description:	<Description,Table :[DOAProfileRecord],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [DOAProfileRecord] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"DOAProfileRecord")]
    public class DOAProfileRecordEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
        
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
        
        
        protected string n_sOrder_remark=global::System.String.Empty;
        #region order_remark
        [System.Data.Linq.Mapping.Column(Name="[order_remark]", Storage="n_sOrder_remark")]
        public string order_remark{
            get{
                return this.n_sOrder_remark;
            }
            set{
                this.n_sOrder_remark=value;
            }
        }
        #endregion order_remark
        
        
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
        
        
        protected global::System.Nullable<bool> n_bUsed=null;
        #region used
        [System.Data.Linq.Mapping.Column(Name="[used]", Storage="n_bUsed")]
        public global::System.Nullable<bool> used{
            get{
                return this.n_bUsed;
            }
            set{
                this.n_bUsed=value;
            }
        }
        #endregion used
        
        
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
        
        
        protected string n_sOrder_dn_remark=global::System.String.Empty;
        #region order_dn_remark
        [System.Data.Linq.Mapping.Column(Name="[order_dn_remark]", Storage="n_sOrder_dn_remark")]
        public string order_dn_remark{
            get{
                return this.n_sOrder_dn_remark;
            }
            set{
                this.n_sOrder_dn_remark=value;
            }
        }
        #endregion order_dn_remark
        
        
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
        
        
        protected string n_sImei_no=global::System.String.Empty;
        #region imei_no
        [System.Data.Linq.Mapping.Column(Name="[imei_no]", Storage="n_sImei_no")]
        public string imei_no{
            get{
                return this.n_sImei_no;
            }
            set{
                this.n_sImei_no=value;
            }
        }
        #endregion imei_no
        
        
        protected string n_sImei_stock_remark=global::System.String.Empty;
        #region imei_stock_remark
        [System.Data.Linq.Mapping.Column(Name="[imei_stock_remark]", Storage="n_sImei_stock_remark")]
        public string imei_stock_remark{
            get{
                return this.n_sImei_stock_remark;
            }
            set{
                this.n_sImei_stock_remark=value;
            }
        }
        #endregion imei_stock_remark
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private DOAProfileRecordInfo n_oTableSet = DOAProfileRecordInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string id="id";
            public const string cdate="cdate";
            public const string cid="cid";
            public const string did="did";
            public const string status="status";
            public const string active="active";
            public const string imei_stock_remark="imei_stock_remark";
            public const string edate="edate";
            public const string edf_no="edf_no";
            public const string used="used";
            public const string order_id="order_id";
            public const string order_dn_remark="order_dn_remark";
            public const string ddate="ddate";
            public const string imei_no="imei_no";
            public const string order_remark="order_remark";
            public const string DOAProfileRecord_table_name="DOAProfileRecord";
            public static string TableName() { return DOAProfileRecord_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public DOAProfileRecordEntity(){
            Init();
        }
        public DOAProfileRecordEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public DOAProfileRecordEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId){
            n_oDB=x_oDB;
            this.Load(x_iId);
            Init();
        }
        
        ~DOAProfileRecordEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iId){
            if (n_oDB==null) { return false; }
            if (x_iId==null) { return false; }
            string _sQuery = "SELECT   [DOAProfileRecord].[id] AS DOAPROFILERECORD_ID,[DOAProfileRecord].[cdate] AS DOAPROFILERECORD_CDATE,[DOAProfileRecord].[cid] AS DOAPROFILERECORD_CID,[DOAProfileRecord].[did] AS DOAPROFILERECORD_DID,[DOAProfileRecord].[status] AS DOAPROFILERECORD_STATUS,[DOAProfileRecord].[active] AS DOAPROFILERECORD_ACTIVE,[DOAProfileRecord].[order_remark] AS DOAPROFILERECORD_ORDER_REMARK,[DOAProfileRecord].[edate] AS DOAPROFILERECORD_EDATE,[DOAProfileRecord].[edf_no] AS DOAPROFILERECORD_EDF_NO,[DOAProfileRecord].[used] AS DOAPROFILERECORD_USED,[DOAProfileRecord].[order_id] AS DOAPROFILERECORD_ORDER_ID,[DOAProfileRecord].[order_dn_remark] AS DOAPROFILERECORD_ORDER_DN_REMARK,[DOAProfileRecord].[ddate] AS DOAPROFILERECORD_DDATE,[DOAProfileRecord].[imei_no] AS DOAPROFILERECORD_IMEI_NO,[DOAProfileRecord].[imei_stock_remark] AS DOAPROFILERECORD_IMEI_STOCK_REMARK  FROM  [DOAProfileRecord]  WHERE  [DOAProfileRecord].[id] = \'"+x_iId.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DOAProfileRecord]","["+ Configurator.MSSQLTablePrefix + "DOAProfileRecord]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_ID"])) {n_iId = (global::System.Nullable<int>)_oData["DOAPROFILERECORD_ID"];}else{n_iId=null;}
                        if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_CDATE"])) {n_dCdate = (global::System.Nullable<DateTime>)_oData["DOAPROFILERECORD_CDATE"];}else{n_dCdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_CID"])) {n_sCid = (string)_oData["DOAPROFILERECORD_CID"];}else{n_sCid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_DID"])) {n_sDid = (string)_oData["DOAPROFILERECORD_DID"];}else{n_sDid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_STATUS"])) {n_sStatus = (string)_oData["DOAPROFILERECORD_STATUS"];}else{n_sStatus=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["DOAPROFILERECORD_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_ORDER_REMARK"])) {n_sOrder_remark = (string)_oData["DOAPROFILERECORD_ORDER_REMARK"];}else{n_sOrder_remark=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_EDATE"])) {n_dEdate = (global::System.Nullable<DateTime>)_oData["DOAPROFILERECORD_EDATE"];}else{n_dEdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_EDF_NO"])) {n_sEdf_no = (string)_oData["DOAPROFILERECORD_EDF_NO"];}else{n_sEdf_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_USED"])) {n_bUsed = (global::System.Nullable<bool>)_oData["DOAPROFILERECORD_USED"];}else{n_bUsed=null;}
                        if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_ORDER_ID"])) {n_iOrder_id = (global::System.Nullable<int>)_oData["DOAPROFILERECORD_ORDER_ID"];}else{n_iOrder_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_ORDER_DN_REMARK"])) {n_sOrder_dn_remark = (string)_oData["DOAPROFILERECORD_ORDER_DN_REMARK"];}else{n_sOrder_dn_remark=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_DDATE"])) {n_dDdate = (global::System.Nullable<DateTime>)_oData["DOAPROFILERECORD_DDATE"];}else{n_dDdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_IMEI_NO"])) {n_sImei_no = (string)_oData["DOAPROFILERECORD_IMEI_NO"];}else{n_sImei_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_IMEI_STOCK_REMARK"])) {n_sImei_stock_remark = (string)_oData["DOAPROFILERECORD_IMEI_STOCK_REMARK"];}else{n_sImei_stock_remark=global::System.String.Empty;}
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
            if (n_bActive==null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_sOrder_remark==null && !(n_oTableSet.Fields(Para.order_remark).IsNullable)) return false;
            if (n_dEdate==null && !(n_oTableSet.Fields(Para.edate).IsNullable)) return false;
            if (n_sEdf_no==null && !(n_oTableSet.Fields(Para.edf_no).IsNullable)) return false;
            if (n_bUsed==null && !(n_oTableSet.Fields(Para.used).IsNullable)) return false;
            if (n_iOrder_id==null && !(n_oTableSet.Fields(Para.order_id).IsNullable)) return false;
            if (n_sOrder_dn_remark==null && !(n_oTableSet.Fields(Para.order_dn_remark).IsNullable)) return false;
            if (n_dDdate==null && !(n_oTableSet.Fields(Para.ddate).IsNullable)) return false;
            if (n_sImei_no==null && !(n_oTableSet.Fields(Para.imei_no).IsNullable)) return false;
            if (n_sImei_stock_remark==null && !(n_oTableSet.Fields(Para.imei_stock_remark).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(DOAProfileRecordEntity)) || (x_oObj is DOAProfileRecordEntity)) return DOAProfileRecordRepository.Instance();
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
        public DOAProfileRecordInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(DOAProfileRecordInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public global::System.Nullable<int> GetId(){return this.id;}
        public global::System.Nullable<DateTime> GetCdate(){return this.cdate;}
        public string GetCid(){return this.cid;}
        public string GetDid(){return this.did;}
        public string GetStatus(){return this.status;}
        public global::System.Nullable<bool> GetActive(){return this.active;}
        public string GetImei_stock_remark(){return this.imei_stock_remark;}
        public global::System.Nullable<DateTime> GetEdate(){return this.edate;}
        public string GetEdf_no(){return this.edf_no;}
        public global::System.Nullable<bool> GetUsed(){return this.used;}
        public global::System.Nullable<int> GetOrder_id(){return this.order_id;}
        public string GetOrder_dn_remark(){return this.order_dn_remark;}
        public global::System.Nullable<DateTime> GetDdate(){return this.ddate;}
        public string GetImei_no(){return this.imei_no;}
        public string GetOrder_remark(){return this.order_remark;}
        
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
        public bool SetActive(global::System.Nullable<bool> value){
            this.active=value;
            return true;
        }
        public bool SetImei_stock_remark(string value){
            this.imei_stock_remark=value;
            return true;
        }
        public bool SetEdate(global::System.Nullable<DateTime> value){
            this.edate=value;
            return true;
        }
        public bool SetEdf_no(string value){
            this.edf_no=value;
            return true;
        }
        public bool SetUsed(global::System.Nullable<bool> value){
            this.used=value;
            return true;
        }
        public bool SetOrder_id(global::System.Nullable<int> value){
            this.order_id=value;
            return true;
        }
        public bool SetOrder_dn_remark(string value){
            this.order_dn_remark=value;
            return true;
        }
        public bool SetDdate(global::System.Nullable<DateTime> value){
            this.ddate=value;
            return true;
        }
        public bool SetImei_no(string value){
            this.imei_no=value;
            return true;
        }
        public bool SetOrder_remark(string value){
            this.order_remark=value;
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
        public Field GetActiveTable(){
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetImei_stock_remarkTable(){
            return n_oTableSet.Fields(Para.imei_stock_remark);
        }
        public Field GetEdateTable(){
            return n_oTableSet.Fields(Para.edate);
        }
        public Field GetEdf_noTable(){
            return n_oTableSet.Fields(Para.edf_no);
        }
        public Field GetUsedTable(){
            return n_oTableSet.Fields(Para.used);
        }
        public Field GetOrder_idTable(){
            return n_oTableSet.Fields(Para.order_id);
        }
        public Field GetOrder_dn_remarkTable(){
            return n_oTableSet.Fields(Para.order_dn_remark);
        }
        public Field GetDdateTable(){
            return n_oTableSet.Fields(Para.ddate);
        }
        public Field GetImei_noTable(){
            return n_oTableSet.Fields(Para.imei_no);
        }
        public Field GetOrder_remarkTable(){
            return n_oTableSet.Fields(Para.order_remark);
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
        
        public bool EqualID(DOAProfileRecord x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(DOAProfileRecord x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_iId.Equals(x_oObj.id)){ return false; }
            if(!this.n_dCdate.Equals(x_oObj.cdate)){ return false; }
            if(!this.n_sCid.Equals(x_oObj.cid)){ return false; }
            if(!this.n_sDid.Equals(x_oObj.did)){ return false; }
            if(!this.n_sStatus.Equals(x_oObj.status)){ return false; }
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_sOrder_remark.Equals(x_oObj.order_remark)){ return false; }
            if(!this.n_dEdate.Equals(x_oObj.edate)){ return false; }
            if(!this.n_sEdf_no.Equals(x_oObj.edf_no)){ return false; }
            if(!this.n_bUsed.Equals(x_oObj.used)){ return false; }
            if(!this.n_iOrder_id.Equals(x_oObj.order_id)){ return false; }
            if(!this.n_sOrder_dn_remark.Equals(x_oObj.order_dn_remark)){ return false; }
            if(!this.n_dDdate.Equals(x_oObj.ddate)){ return false; }
            if(!this.n_sImei_no.Equals(x_oObj.imei_no)){ return false; }
            if(!this.n_sImei_stock_remark.Equals(x_oObj.imei_stock_remark)){ return false; }
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
            string _sQuery = "UPDATE  [DOAProfileRecord]  SET  [cdate]=@cdate,[cid]=@cid,[did]=@did,[status]=@status,[active]=@active,[order_remark]=@order_remark,[edate]=@edate,[edf_no]=@edf_no,[used]=@used,[order_id]=@order_id,[order_dn_remark]=@order_dn_remark,[ddate]=@ddate,[imei_no]=@imei_no,[imei_stock_remark]=@imei_stock_remark  WHERE [DOAProfileRecord].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DOAProfileRecord]","["+ Configurator.MSSQLTablePrefix + "DOAProfileRecord]"); }
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
            if(n_bActive==null){  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=n_bActive; }
            if(n_sOrder_remark==null){  _oCmd.Parameters.Add("@order_remark", global::System.Data.SqlDbType.Text,2147483647).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@order_remark", global::System.Data.SqlDbType.Text,2147483647).Value=n_sOrder_remark; }
            if(n_dEdate==null){  _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=n_dEdate; }
            if(n_sEdf_no==null){  _oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,50).Value=n_sEdf_no; }
            if(n_bUsed==null){  _oCmd.Parameters.Add("@used", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@used", global::System.Data.SqlDbType.Bit).Value=n_bUsed; }
            if(n_iOrder_id==null){  _oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=n_iOrder_id; }
            if(n_sOrder_dn_remark==null){  _oCmd.Parameters.Add("@order_dn_remark", global::System.Data.SqlDbType.Text,2147483647).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@order_dn_remark", global::System.Data.SqlDbType.Text,2147483647).Value=n_sOrder_dn_remark; }
            if(n_dDdate==null){  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=n_dDdate; }
            if(n_sImei_no==null){  _oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,50).Value=n_sImei_no; }
            if(n_sImei_stock_remark==null){  _oCmd.Parameters.Add("@imei_stock_remark", global::System.Data.SqlDbType.Text,2147483647).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@imei_stock_remark", global::System.Data.SqlDbType.Text,2147483647).Value=n_sImei_stock_remark; }
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
        /// Summary description for table [DOAProfileRecord] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iId==null) { return false; }
            string _sQuery="DELETE FROM  [DOAProfileRecord]  WHERE [DOAProfileRecord].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DOAProfileRecord]","["+ Configurator.MSSQLTablePrefix + "DOAProfileRecord]"); }
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
        /// Summary description for table [DOAProfileRecord] Object Base Clone
        /// </summary>
        
        public DOAProfileRecord DeepClone()
        {
            DOAProfileRecord _oDOAProfileRecord_Clone = new DOAProfileRecord();
            _oDOAProfileRecord_Clone.id = this.n_iId;
            _oDOAProfileRecord_Clone.cdate = this.n_dCdate;
            _oDOAProfileRecord_Clone.cid = this.n_sCid;
            _oDOAProfileRecord_Clone.did = this.n_sDid;
            _oDOAProfileRecord_Clone.status = this.n_sStatus;
            _oDOAProfileRecord_Clone.active = this.n_bActive;
            _oDOAProfileRecord_Clone.order_remark = this.n_sOrder_remark;
            _oDOAProfileRecord_Clone.edate = this.n_dEdate;
            _oDOAProfileRecord_Clone.edf_no = this.n_sEdf_no;
            _oDOAProfileRecord_Clone.used = this.n_bUsed;
            _oDOAProfileRecord_Clone.order_id = this.n_iOrder_id;
            _oDOAProfileRecord_Clone.order_dn_remark = this.n_sOrder_dn_remark;
            _oDOAProfileRecord_Clone.ddate = this.n_dDdate;
            _oDOAProfileRecord_Clone.imei_no = this.n_sImei_no;
            _oDOAProfileRecord_Clone.imei_stock_remark = this.n_sImei_stock_remark;
            _oDOAProfileRecord_Clone.SetFound(this.n_bFound);
            _oDOAProfileRecord_Clone.SetDB(this.n_oDB);
            _oDOAProfileRecord_Clone.SetRow(this.n_oRow);
            _oDOAProfileRecord_Clone.SetTbl(this.n_oTbl);
            _oDOAProfileRecord_Clone.SetTableSet(this.n_oTableSet);
            
            return _oDOAProfileRecord_Clone;
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
            n_bActive=null;
            n_sOrder_remark=global::System.String.Empty;
            n_dEdate=null;
            n_sEdf_no=global::System.String.Empty;
            n_bUsed=null;
            n_iOrder_id=null;
            n_sOrder_dn_remark=global::System.String.Empty;
            n_dDdate=null;
            n_sImei_no=global::System.String.Empty;
            n_sImei_stock_remark=global::System.String.Empty;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = DOAProfileRecordInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


