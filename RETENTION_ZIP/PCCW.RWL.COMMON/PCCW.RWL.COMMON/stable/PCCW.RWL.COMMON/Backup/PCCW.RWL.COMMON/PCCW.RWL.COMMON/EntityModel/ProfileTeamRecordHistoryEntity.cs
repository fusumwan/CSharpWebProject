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
///-- Create date: <Create Date 2011-01-14>
///-- Description:	<Description,Table :[ProfileTeamRecordHistory],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [ProfileTeamRecordHistory] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"ProfileTeamRecordHistory")]
    public class ProfileTeamRecordHistoryEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        
        protected string n_sAction_type=global::System.String.Empty;
        #region action_type
        [System.Data.Linq.Mapping.Column(Name="[action_type]", Storage="n_sAction_type")]
        public string action_type{
            get{
                return this.n_sAction_type;
            }
            set{
                this.n_sAction_type=value;
            }
        }
        #endregion action_type
        
        
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
        
        
        protected string n_sSalesman_code=global::System.String.Empty;
        #region salesman_code
        [System.Data.Linq.Mapping.Column(Name="[salesman_code]", Storage="n_sSalesman_code")]
        public string salesman_code{
            get{
                return this.n_sSalesman_code;
            }
            set{
                this.n_sSalesman_code=value;
            }
        }
        #endregion salesman_code
        
        
        protected global::System.Nullable<long> n_lHis_id=null;
        #region his_id
        [System.Data.Linq.Mapping.Column(Name="[his_id]", Storage="n_lHis_id")]
        public global::System.Nullable<long> his_id{
            get{
                return this.n_lHis_id;
            }
            set{
                this.n_lHis_id=value;
            }
        }
        #endregion his_id
        
        
        protected string n_sStaff_no=global::System.String.Empty;
        #region staff_no
        [System.Data.Linq.Mapping.Column(Name="[staff_no]", Storage="n_sStaff_no")]
        public string staff_no{
            get{
                return this.n_sStaff_no;
            }
            set{
                this.n_sStaff_no=value;
            }
        }
        #endregion staff_no
        
        
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
        
        
        protected global::System.Nullable<int> n_iRec_no=null;
        #region rec_no
        [System.Data.Linq.Mapping.Column(Name="[rec_no]", Storage="n_iRec_no")]
        public global::System.Nullable<int> rec_no{
            get{
                return this.n_iRec_no;
            }
            set{
                this.n_iRec_no=value;
            }
        }
        #endregion rec_no
        
        
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
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private ProfileTeamRecordHistoryInfo n_oTableSet = ProfileTeamRecordHistoryInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string active="active";
            public const string cdate="cdate";
            public const string cid="cid";
            public const string did="did";
            public const string action_type="action_type";
            public const string edate="edate";
            public const string rec_no="rec_no";
            public const string salesman_code="salesman_code";
            public const string his_id="his_id";
            public const string staff_no="staff_no";
            public const string ddate="ddate";
            public const string sdate="sdate";
            public const string remark="remark";
            public const string ProfileTeamRecordHistory_table_name="ProfileTeamRecordHistory";
            public static string TableName() { return ProfileTeamRecordHistory_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public ProfileTeamRecordHistoryEntity(){
            Init();
        }
        public ProfileTeamRecordHistoryEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public ProfileTeamRecordHistoryEntity(MSSQLConnect x_oDB,global::System.Nullable<long> x_lHis_id){
            n_oDB=x_oDB;
            this.Load(x_lHis_id);
            Init();
        }
        
        ~ProfileTeamRecordHistoryEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<long> x_lHis_id){
            if (n_oDB==null) { return false; }
            if (x_lHis_id==null) { return false; }
            string _sQuery = "SELECT   [ProfileTeamRecordHistory].[active] AS PROFILETEAMRECORDHISTORY_ACTIVE,[ProfileTeamRecordHistory].[cdate] AS PROFILETEAMRECORDHISTORY_CDATE,[ProfileTeamRecordHistory].[cid] AS PROFILETEAMRECORDHISTORY_CID,[ProfileTeamRecordHistory].[did] AS PROFILETEAMRECORDHISTORY_DID,[ProfileTeamRecordHistory].[sdate] AS PROFILETEAMRECORDHISTORY_SDATE,[ProfileTeamRecordHistory].[action_type] AS PROFILETEAMRECORDHISTORY_ACTION_TYPE,[ProfileTeamRecordHistory].[edate] AS PROFILETEAMRECORDHISTORY_EDATE,[ProfileTeamRecordHistory].[salesman_code] AS PROFILETEAMRECORDHISTORY_SALESMAN_CODE,[ProfileTeamRecordHistory].[his_id] AS PROFILETEAMRECORDHISTORY_HIS_ID,[ProfileTeamRecordHistory].[staff_no] AS PROFILETEAMRECORDHISTORY_STAFF_NO,[ProfileTeamRecordHistory].[ddate] AS PROFILETEAMRECORDHISTORY_DDATE,[ProfileTeamRecordHistory].[rec_no] AS PROFILETEAMRECORDHISTORY_REC_NO,[ProfileTeamRecordHistory].[remark] AS PROFILETEAMRECORDHISTORY_REMARK  FROM  [ProfileTeamRecordHistory]  WHERE  [ProfileTeamRecordHistory].[his_id] = \'"+x_lHis_id.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProfileTeamRecordHistory]","["+ Configurator.MSSQLTablePrefix + "ProfileTeamRecordHistory]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["PROFILETEAMRECORDHISTORY_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_CDATE"])) {n_dCdate = (global::System.Nullable<DateTime>)_oData["PROFILETEAMRECORDHISTORY_CDATE"];}else{n_dCdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_CID"])) {n_sCid = (string)_oData["PROFILETEAMRECORDHISTORY_CID"];}else{n_sCid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_DID"])) {n_sDid = (string)_oData["PROFILETEAMRECORDHISTORY_DID"];}else{n_sDid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_SDATE"])) {n_dSdate = (global::System.Nullable<DateTime>)_oData["PROFILETEAMRECORDHISTORY_SDATE"];}else{n_dSdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_ACTION_TYPE"])) {n_sAction_type = (string)_oData["PROFILETEAMRECORDHISTORY_ACTION_TYPE"];}else{n_sAction_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_EDATE"])) {n_dEdate = (global::System.Nullable<DateTime>)_oData["PROFILETEAMRECORDHISTORY_EDATE"];}else{n_dEdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_SALESMAN_CODE"])) {n_sSalesman_code = (string)_oData["PROFILETEAMRECORDHISTORY_SALESMAN_CODE"];}else{n_sSalesman_code=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_HIS_ID"])) {n_lHis_id = (global::System.Nullable<long>)_oData["PROFILETEAMRECORDHISTORY_HIS_ID"];}else{n_lHis_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_STAFF_NO"])) {n_sStaff_no = (string)_oData["PROFILETEAMRECORDHISTORY_STAFF_NO"];}else{n_sStaff_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_DDATE"])) {n_dDdate = (global::System.Nullable<DateTime>)_oData["PROFILETEAMRECORDHISTORY_DDATE"];}else{n_dDdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_REC_NO"])) {n_iRec_no = (global::System.Nullable<int>)_oData["PROFILETEAMRECORDHISTORY_REC_NO"];}else{n_iRec_no=null;}
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_REMARK"])) {n_sRemark = (string)_oData["PROFILETEAMRECORDHISTORY_REMARK"];}else{n_sRemark=global::System.String.Empty;}
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
            if (n_sDid==null && !(n_oTableSet.Fields(Para.did).IsNullable)) return false;
            if (n_dSdate==null && !(n_oTableSet.Fields(Para.sdate).IsNullable)) return false;
            if (n_sAction_type==null && !(n_oTableSet.Fields(Para.action_type).IsNullable)) return false;
            if (n_dEdate==null && !(n_oTableSet.Fields(Para.edate).IsNullable)) return false;
            if (n_sSalesman_code==null && !(n_oTableSet.Fields(Para.salesman_code).IsNullable)) return false;
            if(!x_bInsert){
                if (n_lHis_id==null && !(n_oTableSet.Fields(Para.his_id).IsNullable)) return false;
            }
            if (n_sStaff_no==null && !(n_oTableSet.Fields(Para.staff_no).IsNullable)) return false;
            if (n_dDdate==null && !(n_oTableSet.Fields(Para.ddate).IsNullable)) return false;
            if (n_iRec_no==null && !(n_oTableSet.Fields(Para.rec_no).IsNullable)) return false;
            if (n_sRemark==null && !(n_oTableSet.Fields(Para.remark).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(ProfileTeamRecordHistoryEntity)) || (x_oObj is ProfileTeamRecordHistoryEntity)) return ProfileTeamRecordHistoryRepository.Instance();
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
        public ProfileTeamRecordHistoryInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(ProfileTeamRecordHistoryInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public global::System.Nullable<bool> GetActive(){return this.active;}
        public global::System.Nullable<DateTime> GetCdate(){return this.cdate;}
        public string GetCid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.cid)) { return string.Empty; }
            return this.cid;
        }
        public string GetDid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.did)) { return string.Empty; }
            return this.did;
        }
        public string GetAction_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.action_type)) { return string.Empty; }
            return this.action_type;
        }
        public global::System.Nullable<DateTime> GetEdate(){return this.edate;}
        public global::System.Nullable<int> GetRec_no(){return this.rec_no;}
        public string GetSalesman_code(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.salesman_code)) { return string.Empty; }
            return this.salesman_code;
        }
        public global::System.Nullable<long> GetHis_id(){return this.his_id;}
        public string GetStaff_no(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.staff_no)) { return string.Empty; }
            return this.staff_no;
        }
        public global::System.Nullable<DateTime> GetDdate(){return this.ddate;}
        public global::System.Nullable<DateTime> GetSdate(){return this.sdate;}
        public string GetRemark(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.remark)) { return string.Empty; }
            return this.remark;
        }
        
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
        public bool SetAction_type(string value){
            this.action_type=value;
            return true;
        }
        public bool SetEdate(global::System.Nullable<DateTime> value){
            this.edate=value;
            return true;
        }
        public bool SetRec_no(global::System.Nullable<int> value){
            this.rec_no=value;
            return true;
        }
        public bool SetSalesman_code(string value){
            this.salesman_code=value;
            return true;
        }
        public bool SetHis_id(global::System.Nullable<long> value){
            this.his_id=value;
            return true;
        }
        public bool SetStaff_no(string value){
            this.staff_no=value;
            return true;
        }
        public bool SetDdate(global::System.Nullable<DateTime> value){
            this.ddate=value;
            return true;
        }
        public bool SetSdate(global::System.Nullable<DateTime> value){
            this.sdate=value;
            return true;
        }
        public bool SetRemark(string value){
            this.remark=value;
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
        public Field GetAction_typeTable(){
            return n_oTableSet.Fields(Para.action_type);
        }
        public Field GetEdateTable(){
            return n_oTableSet.Fields(Para.edate);
        }
        public Field GetRec_noTable(){
            return n_oTableSet.Fields(Para.rec_no);
        }
        public Field GetSalesman_codeTable(){
            return n_oTableSet.Fields(Para.salesman_code);
        }
        public Field GetHis_idTable(){
            return n_oTableSet.Fields(Para.his_id);
        }
        public Field GetStaff_noTable(){
            return n_oTableSet.Fields(Para.staff_no);
        }
        public Field GetDdateTable(){
            return n_oTableSet.Fields(Para.ddate);
        }
        public Field GetSdateTable(){
            return n_oTableSet.Fields(Para.sdate);
        }
        public Field GetRemarkTable(){
            return n_oTableSet.Fields(Para.remark);
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
        
        public bool EqualID(ProfileTeamRecordHistory x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_lHis_id.Equals(x_oObj.his_id)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(ProfileTeamRecordHistory x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_dCdate.Equals(x_oObj.cdate)){ return false; }
            if(!this.n_sCid.Equals(x_oObj.cid)){ return false; }
            if(!this.n_sDid.Equals(x_oObj.did)){ return false; }
            if(!this.n_dSdate.Equals(x_oObj.sdate)){ return false; }
            if(!this.n_sAction_type.Equals(x_oObj.action_type)){ return false; }
            if(!this.n_dEdate.Equals(x_oObj.edate)){ return false; }
            if(!this.n_sSalesman_code.Equals(x_oObj.salesman_code)){ return false; }
            if(!this.n_lHis_id.Equals(x_oObj.his_id)){ return false; }
            if(!this.n_sStaff_no.Equals(x_oObj.staff_no)){ return false; }
            if(!this.n_dDdate.Equals(x_oObj.ddate)){ return false; }
            if(!this.n_iRec_no.Equals(x_oObj.rec_no)){ return false; }
            if(!this.n_sRemark.Equals(x_oObj.remark)){ return false; }
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
            if(!n_lHis_id.Equals(null)){
                _bResult=this.Load(n_lHis_id);
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
            if (n_lHis_id==null) { return false; }
            if(!Vaild(false)){ return false; }
            string _sQuery = "UPDATE  [ProfileTeamRecordHistory]  SET  [active]=@active,[cdate]=@cdate,[cid]=@cid,[did]=@did,[sdate]=@sdate,[action_type]=@action_type,[edate]=@edate,[salesman_code]=@salesman_code,[staff_no]=@staff_no,[ddate]=@ddate,[rec_no]=@rec_no,[remark]=@remark  WHERE [ProfileTeamRecordHistory].[his_id]=@his_id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProfileTeamRecordHistory]","["+ Configurator.MSSQLTablePrefix + "ProfileTeamRecordHistory]"); }
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
            if(n_sDid==null){  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value=n_sDid; }
            if(n_dSdate==null){  _oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value=n_dSdate; }
            if(n_sAction_type==null){  _oCmd.Parameters.Add("@action_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@action_type", global::System.Data.SqlDbType.NVarChar,50).Value=n_sAction_type; }
            if(n_dEdate==null){  _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=n_dEdate; }
            if(n_sSalesman_code==null){  _oCmd.Parameters.Add("@salesman_code", global::System.Data.SqlDbType.NVarChar,4).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@salesman_code", global::System.Data.SqlDbType.NVarChar,4).Value=n_sSalesman_code; }
            if(n_lHis_id==null){  _oCmd.Parameters.Add("@his_id", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@his_id", global::System.Data.SqlDbType.BigInt).Value=n_lHis_id; }
            if(n_sStaff_no==null){  _oCmd.Parameters.Add("@staff_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@staff_no", global::System.Data.SqlDbType.NVarChar,50).Value=n_sStaff_no; }
            if(n_dDdate==null){  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=n_dDdate; }
            if(n_iRec_no==null){  _oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int).Value=n_iRec_no; }
            if(n_sRemark==null){  _oCmd.Parameters.Add("@remark", global::System.Data.SqlDbType.Text,2147483647).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@remark", global::System.Data.SqlDbType.Text,2147483647).Value=n_sRemark; }
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
        /// Summary description for table [ProfileTeamRecordHistory] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_lHis_id==null) { return false; }
            string _sQuery="DELETE FROM  [ProfileTeamRecordHistory]  WHERE [ProfileTeamRecordHistory].[his_id]=@his_id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProfileTeamRecordHistory]","["+ Configurator.MSSQLTablePrefix + "ProfileTeamRecordHistory]"); }
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
            _oCmd.Parameters.Add("@his_id", global::System.Data.SqlDbType.BigInt).Value = n_lHis_id;
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
        /// Summary description for table [ProfileTeamRecordHistory] Object Base Clone
        /// </summary>
        
        public ProfileTeamRecordHistory DeepClone()
        {
            ProfileTeamRecordHistory _oProfileTeamRecordHistory_Clone = new ProfileTeamRecordHistory();
            _oProfileTeamRecordHistory_Clone.active = this.n_bActive;
            _oProfileTeamRecordHistory_Clone.cdate = this.n_dCdate;
            _oProfileTeamRecordHistory_Clone.cid = this.n_sCid;
            _oProfileTeamRecordHistory_Clone.did = this.n_sDid;
            _oProfileTeamRecordHistory_Clone.sdate = this.n_dSdate;
            _oProfileTeamRecordHistory_Clone.action_type = this.n_sAction_type;
            _oProfileTeamRecordHistory_Clone.edate = this.n_dEdate;
            _oProfileTeamRecordHistory_Clone.salesman_code = this.n_sSalesman_code;
            _oProfileTeamRecordHistory_Clone.his_id = this.n_lHis_id;
            _oProfileTeamRecordHistory_Clone.staff_no = this.n_sStaff_no;
            _oProfileTeamRecordHistory_Clone.ddate = this.n_dDdate;
            _oProfileTeamRecordHistory_Clone.rec_no = this.n_iRec_no;
            _oProfileTeamRecordHistory_Clone.remark = this.n_sRemark;
            _oProfileTeamRecordHistory_Clone.SetFound(this.n_bFound);
            _oProfileTeamRecordHistory_Clone.SetDB(this.n_oDB);
            _oProfileTeamRecordHistory_Clone.SetRow(this.n_oRow);
            _oProfileTeamRecordHistory_Clone.SetTbl(this.n_oTbl);
            _oProfileTeamRecordHistory_Clone.SetTableSet(this.n_oTableSet);
            
            return _oProfileTeamRecordHistory_Clone;
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
            n_sDid=global::System.String.Empty;
            n_dSdate=null;
            n_sAction_type=global::System.String.Empty;
            n_dEdate=null;
            n_sSalesman_code=global::System.String.Empty;
            n_lHis_id=null;
            n_sStaff_no=global::System.String.Empty;
            n_dDdate=null;
            n_iRec_no=null;
            n_sRemark=global::System.String.Empty;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = ProfileTeamRecordHistoryInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


