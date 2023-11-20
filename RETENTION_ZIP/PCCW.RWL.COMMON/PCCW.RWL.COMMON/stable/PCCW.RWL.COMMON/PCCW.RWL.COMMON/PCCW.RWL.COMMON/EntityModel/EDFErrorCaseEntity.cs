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
///-- Create date: <Create Date 2010-05-31>
///-- Description:	<Description,Table :[EDFErrorCase],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [EDFErrorCase] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"EDFErrorCase")]
    public class EDFErrorCaseEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        
        protected string n_sMrt_no=global::System.String.Empty;
        #region mrt_no
        [System.Data.Linq.Mapping.Column(Name="[mrt_no]", Storage="n_sMrt_no")]
        public string mrt_no{
            get{
                return this.n_sMrt_no;
            }
            set{
                this.n_sMrt_no=value;
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
        
        
        protected string n_sRemark=global::System.String.Empty;
        #region remark
        [System.Data.Linq.Mapping.Column(Name="[remark]", Storage="n_sRemark")]
        public string remark{
            get{
                return this.n_sRemark;
            }
            set{
                this.n_sRemark=value;
            }
        }
        #endregion remark
        
        
        protected string n_sImei_status=global::System.String.Empty;
        #region imei_status
        [System.Data.Linq.Mapping.Column(Name="[imei_status]", Storage="n_sImei_status")]
        public string imei_status{
            get{
                return this.n_sImei_status;
            }
            set{
                this.n_sImei_status=value;
            }
        }
        #endregion imei_status
        
        
        protected string n_sImei_remark=global::System.String.Empty;
        #region imei_remark
        [System.Data.Linq.Mapping.Column(Name="[imei_remark]", Storage="n_sImei_remark")]
        public string imei_remark{
            get{
                return this.n_sImei_remark;
            }
            set{
                this.n_sImei_remark=value;
            }
        }
        #endregion imei_remark
        
        
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
        
        
        protected string n_sError_msg=global::System.String.Empty;
        #region error_msg
        [System.Data.Linq.Mapping.Column(Name="[error_msg]", Storage="n_sError_msg")]
        public string error_msg{
            get{
                return this.n_sError_msg;
            }
            set{
                this.n_sError_msg=value;
            }
        }
        #endregion error_msg
        
        
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
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private EDFErrorCaseInfo n_oTableSet = EDFErrorCaseInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string id="id";
            public const string cdate="cdate";
            public const string cid="cid";
            public const string mrt_no="mrt_no";
            public const string status="status";
            public const string active="active";
            public const string remark="remark";
            public const string imei_status="imei_status";
            public const string imei_no="imei_no";
            public const string imei_remark="imei_remark";
            public const string edf_no="edf_no";
            public const string order_id="order_id";
            public const string did="did";
            public const string ddate="ddate";
            public const string error_msg="error_msg";
            public const string EDFErrorCase_table_name="EDFErrorCase";
            public static string TableName() { return EDFErrorCase_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public EDFErrorCaseEntity(){
            Init();
        }
        public EDFErrorCaseEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public EDFErrorCaseEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId){
            n_oDB=x_oDB;
            this.Load(x_iId);
            Init();
        }
        
        ~EDFErrorCaseEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iId){
            if (n_oDB==null) { return false; }
            if (x_iId==null) { return false; }
            string _sQuery = "SELECT   [EDFErrorCase].[id] AS EDFERRORCASE_ID,[EDFErrorCase].[cdate] AS EDFERRORCASE_CDATE,[EDFErrorCase].[cid] AS EDFERRORCASE_CID,[EDFErrorCase].[mrt_no] AS EDFERRORCASE_MRT_NO,[EDFErrorCase].[status] AS EDFERRORCASE_STATUS,[EDFErrorCase].[active] AS EDFERRORCASE_ACTIVE,[EDFErrorCase].[remark] AS EDFERRORCASE_REMARK,[EDFErrorCase].[imei_status] AS EDFERRORCASE_IMEI_STATUS,[EDFErrorCase].[imei_remark] AS EDFERRORCASE_IMEI_REMARK,[EDFErrorCase].[edf_no] AS EDFERRORCASE_EDF_NO,[EDFErrorCase].[order_id] AS EDFERRORCASE_ORDER_ID,[EDFErrorCase].[error_msg] AS EDFERRORCASE_ERROR_MSG,[EDFErrorCase].[did] AS EDFERRORCASE_DID,[EDFErrorCase].[ddate] AS EDFERRORCASE_DDATE,[EDFErrorCase].[imei_no] AS EDFERRORCASE_IMEI_NO  FROM  [EDFErrorCase]  WHERE  [EDFErrorCase].[id] = \'"+x_iId.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[EDFErrorCase]","["+ Configurator.MSSQLTablePrefix + "EDFErrorCase]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_ID"])) {n_iId = (global::System.Nullable<int>)_oData["EDFERRORCASE_ID"];}else{n_iId=null;}
                        if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_CDATE"])) {n_dCdate = (global::System.Nullable<DateTime>)_oData["EDFERRORCASE_CDATE"];}else{n_dCdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_CID"])) {n_sCid = (string)_oData["EDFERRORCASE_CID"];}else{n_sCid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_MRT_NO"])) {n_sMrt_no = (string)_oData["EDFERRORCASE_MRT_NO"];}else{n_sMrt_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_STATUS"])) {n_sStatus = (string)_oData["EDFERRORCASE_STATUS"];}else{n_sStatus=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["EDFERRORCASE_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_REMARK"])) {n_sRemark = (string)_oData["EDFERRORCASE_REMARK"];}else{n_sRemark=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_IMEI_STATUS"])) {n_sImei_status = (string)_oData["EDFERRORCASE_IMEI_STATUS"];}else{n_sImei_status=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_IMEI_REMARK"])) {n_sImei_remark = (string)_oData["EDFERRORCASE_IMEI_REMARK"];}else{n_sImei_remark=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_EDF_NO"])) {n_sEdf_no = (string)_oData["EDFERRORCASE_EDF_NO"];}else{n_sEdf_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_ORDER_ID"])) {n_iOrder_id = (global::System.Nullable<int>)_oData["EDFERRORCASE_ORDER_ID"];}else{n_iOrder_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_ERROR_MSG"])) {n_sError_msg = (string)_oData["EDFERRORCASE_ERROR_MSG"];}else{n_sError_msg=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_DID"])) {n_sDid = (string)_oData["EDFERRORCASE_DID"];}else{n_sDid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_DDATE"])) {n_dDdate = (global::System.Nullable<DateTime>)_oData["EDFERRORCASE_DDATE"];}else{n_dDdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_IMEI_NO"])) {n_sImei_no = (string)_oData["EDFERRORCASE_IMEI_NO"];}else{n_sImei_no=global::System.String.Empty;}
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
            if (n_sMrt_no==null && !(n_oTableSet.Fields(Para.mrt_no).IsNullable)) return false;
            if (n_sStatus==null && !(n_oTableSet.Fields(Para.status).IsNullable)) return false;
            if (n_bActive==null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_sRemark==null && !(n_oTableSet.Fields(Para.remark).IsNullable)) return false;
            if (n_sImei_status==null && !(n_oTableSet.Fields(Para.imei_status).IsNullable)) return false;
            if (n_sImei_remark==null && !(n_oTableSet.Fields(Para.imei_remark).IsNullable)) return false;
            if (n_sEdf_no==null && !(n_oTableSet.Fields(Para.edf_no).IsNullable)) return false;
            if (n_iOrder_id==null && !(n_oTableSet.Fields(Para.order_id).IsNullable)) return false;
            if (n_sError_msg==null && !(n_oTableSet.Fields(Para.error_msg).IsNullable)) return false;
            if (n_sDid==null && !(n_oTableSet.Fields(Para.did).IsNullable)) return false;
            if (n_dDdate==null && !(n_oTableSet.Fields(Para.ddate).IsNullable)) return false;
            if (n_sImei_no==null && !(n_oTableSet.Fields(Para.imei_no).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(EDFErrorCaseEntity)) || (x_oObj is EDFErrorCaseEntity)) return EDFErrorCaseRepository.Instance();
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
        public EDFErrorCaseInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(EDFErrorCaseInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public global::System.Nullable<int> GetId(){return this.id;}
        public global::System.Nullable<DateTime> GetCdate(){return this.cdate;}
        public string GetCid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.cid)) { return string.Empty; }
            return this.cid;
        }
        public string GetMrt_no(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.mrt_no)) { return string.Empty; }
            return this.mrt_no;
        }
        public string GetStatus(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.status)) { return string.Empty; }
            return this.status;
        }
        public global::System.Nullable<bool> GetActive(){return this.active;}
        public string GetRemark(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.remark)) { return string.Empty; }
            return this.remark;
        }
        public string GetImei_status(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.imei_status)) { return string.Empty; }
            return this.imei_status;
        }
        public string GetImei_no(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.imei_no)) { return string.Empty; }
            return this.imei_no;
        }
        public string GetImei_remark(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.imei_remark)) { return string.Empty; }
            return this.imei_remark;
        }
        public string GetEdf_no(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.edf_no)) { return string.Empty; }
            return this.edf_no;
        }
        public global::System.Nullable<int> GetOrder_id(){return this.order_id;}
        public string GetDid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.did)) { return string.Empty; }
            return this.did;
        }
        public global::System.Nullable<DateTime> GetDdate(){return this.ddate;}
        public string GetError_msg(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.error_msg)) { return string.Empty; }
            return this.error_msg;
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
        public bool SetMrt_no(string value){
            this.mrt_no=value;
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
        public bool SetRemark(string value){
            this.remark=value;
            return true;
        }
        public bool SetImei_status(string value){
            this.imei_status=value;
            return true;
        }
        public bool SetImei_no(string value){
            this.imei_no=value;
            return true;
        }
        public bool SetImei_remark(string value){
            this.imei_remark=value;
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
        public bool SetDid(string value){
            this.did=value;
            return true;
        }
        public bool SetDdate(global::System.Nullable<DateTime> value){
            this.ddate=value;
            return true;
        }
        public bool SetError_msg(string value){
            this.error_msg=value;
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
        public Field GetMrt_noTable(){
            return n_oTableSet.Fields(Para.mrt_no);
        }
        public Field GetStatusTable(){
            return n_oTableSet.Fields(Para.status);
        }
        public Field GetActiveTable(){
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetRemarkTable(){
            return n_oTableSet.Fields(Para.remark);
        }
        public Field GetImei_statusTable(){
            return n_oTableSet.Fields(Para.imei_status);
        }
        public Field GetImei_noTable(){
            return n_oTableSet.Fields(Para.imei_no);
        }
        public Field GetImei_remarkTable(){
            return n_oTableSet.Fields(Para.imei_remark);
        }
        public Field GetEdf_noTable(){
            return n_oTableSet.Fields(Para.edf_no);
        }
        public Field GetOrder_idTable(){
            return n_oTableSet.Fields(Para.order_id);
        }
        public Field GetDidTable(){
            return n_oTableSet.Fields(Para.did);
        }
        public Field GetDdateTable(){
            return n_oTableSet.Fields(Para.ddate);
        }
        public Field GetError_msgTable(){
            return n_oTableSet.Fields(Para.error_msg);
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
        
        public bool EqualID(EDFErrorCase x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(EDFErrorCase x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_iId.Equals(x_oObj.id)){ return false; }
            if(!this.n_dCdate.Equals(x_oObj.cdate)){ return false; }
            if(!this.n_sCid.Equals(x_oObj.cid)){ return false; }
            if(!this.n_sMrt_no.Equals(x_oObj.mrt_no)){ return false; }
            if(!this.n_sStatus.Equals(x_oObj.status)){ return false; }
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_sRemark.Equals(x_oObj.remark)){ return false; }
            if(!this.n_sImei_status.Equals(x_oObj.imei_status)){ return false; }
            if(!this.n_sImei_remark.Equals(x_oObj.imei_remark)){ return false; }
            if(!this.n_sEdf_no.Equals(x_oObj.edf_no)){ return false; }
            if(!this.n_iOrder_id.Equals(x_oObj.order_id)){ return false; }
            if(!this.n_sError_msg.Equals(x_oObj.error_msg)){ return false; }
            if(!this.n_sDid.Equals(x_oObj.did)){ return false; }
            if(!this.n_dDdate.Equals(x_oObj.ddate)){ return false; }
            if(!this.n_sImei_no.Equals(x_oObj.imei_no)){ return false; }
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
            string _sQuery = "UPDATE  [EDFErrorCase]  SET  [cdate]=@cdate,[cid]=@cid,[mrt_no]=@mrt_no,[status]=@status,[active]=@active,[remark]=@remark,[imei_status]=@imei_status,[imei_remark]=@imei_remark,[edf_no]=@edf_no,[order_id]=@order_id,[error_msg]=@error_msg,[did]=@did,[ddate]=@ddate,[imei_no]=@imei_no  WHERE [EDFErrorCase].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[EDFErrorCase]","["+ Configurator.MSSQLTablePrefix + "EDFErrorCase]"); }
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
            if(n_sMrt_no==null){  _oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.NVarChar,50).Value=n_sMrt_no; }
            if(n_sStatus==null){  _oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NVarChar,50).Value=n_sStatus; }
            if(n_bActive==null){  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=n_bActive; }
            if(n_sRemark==null){  _oCmd.Parameters.Add("@remark", global::System.Data.SqlDbType.Text,2147483647).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@remark", global::System.Data.SqlDbType.Text,2147483647).Value=n_sRemark; }
            if(n_sImei_status==null){  _oCmd.Parameters.Add("@imei_status", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@imei_status", global::System.Data.SqlDbType.NVarChar,50).Value=n_sImei_status; }
            if(n_sImei_remark==null){  _oCmd.Parameters.Add("@imei_remark", global::System.Data.SqlDbType.Text,2147483647).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@imei_remark", global::System.Data.SqlDbType.Text,2147483647).Value=n_sImei_remark; }
            if(n_sEdf_no==null){  _oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,50).Value=n_sEdf_no; }
            if(n_iOrder_id==null){  _oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=n_iOrder_id; }
            if(n_sError_msg==null){  _oCmd.Parameters.Add("@error_msg", global::System.Data.SqlDbType.Text,2147483647).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@error_msg", global::System.Data.SqlDbType.Text,2147483647).Value=n_sError_msg; }
            if(n_sDid==null){  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value=n_sDid; }
            if(n_dDdate==null){  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=n_dDdate; }
            if(n_sImei_no==null){  _oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,50).Value=n_sImei_no; }
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
        /// Summary description for table [EDFErrorCase] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iId==null) { return false; }
            string _sQuery="DELETE FROM  [EDFErrorCase]  WHERE [EDFErrorCase].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[EDFErrorCase]","["+ Configurator.MSSQLTablePrefix + "EDFErrorCase]"); }
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
        /// Summary description for table [EDFErrorCase] Object Base Clone
        /// </summary>
        
        public EDFErrorCase DeepClone()
        {
            EDFErrorCase _oEDFErrorCase_Clone = new EDFErrorCase();
            _oEDFErrorCase_Clone.id = this.n_iId;
            _oEDFErrorCase_Clone.cdate = this.n_dCdate;
            _oEDFErrorCase_Clone.cid = this.n_sCid;
            _oEDFErrorCase_Clone.mrt_no = this.n_sMrt_no;
            _oEDFErrorCase_Clone.status = this.n_sStatus;
            _oEDFErrorCase_Clone.active = this.n_bActive;
            _oEDFErrorCase_Clone.remark = this.n_sRemark;
            _oEDFErrorCase_Clone.imei_status = this.n_sImei_status;
            _oEDFErrorCase_Clone.imei_remark = this.n_sImei_remark;
            _oEDFErrorCase_Clone.edf_no = this.n_sEdf_no;
            _oEDFErrorCase_Clone.order_id = this.n_iOrder_id;
            _oEDFErrorCase_Clone.error_msg = this.n_sError_msg;
            _oEDFErrorCase_Clone.did = this.n_sDid;
            _oEDFErrorCase_Clone.ddate = this.n_dDdate;
            _oEDFErrorCase_Clone.imei_no = this.n_sImei_no;
            _oEDFErrorCase_Clone.SetFound(this.n_bFound);
            _oEDFErrorCase_Clone.SetDB(this.n_oDB);
            _oEDFErrorCase_Clone.SetRow(this.n_oRow);
            _oEDFErrorCase_Clone.SetTbl(this.n_oTbl);
            _oEDFErrorCase_Clone.SetTableSet(this.n_oTableSet);
            
            return _oEDFErrorCase_Clone;
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
            n_sMrt_no=global::System.String.Empty;
            n_sStatus=global::System.String.Empty;
            n_bActive=null;
            n_sRemark=global::System.String.Empty;
            n_sImei_status=global::System.String.Empty;
            n_sImei_remark=global::System.String.Empty;
            n_sEdf_no=global::System.String.Empty;
            n_iOrder_id=null;
            n_sError_msg=global::System.String.Empty;
            n_sDid=global::System.String.Empty;
            n_dDdate=null;
            n_sImei_no=global::System.String.Empty;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = EDFErrorCaseInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


