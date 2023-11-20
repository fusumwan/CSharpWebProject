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
///-- Create date: <Create Date 2010-10-29>
///-- Description:	<Description,Table :[MobileOrderReportRetrieveDetail],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [MobileOrderReportRetrieveDetail] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"MobileOrderReportRetrieveDetail")]
    public class MobileOrderReportRetrieveDetailEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        
        protected global::System.Nullable<Guid> n_gGuid_id=null;
        #region guid_id
        [System.Data.Linq.Mapping.Column(Name="[guid_id]", Storage="n_gGuid_id")]
        public global::System.Nullable<Guid> guid_id{
            get{
                return this.n_gGuid_id;
            }
            set{
                this.n_gGuid_id=value;
            }
        }
        #endregion guid_id
        
        
        protected string n_sRetrieve_group=global::System.String.Empty;
        #region retrieve_group
        [System.Data.Linq.Mapping.Column(Name="[retrieve_group]", Storage="n_sRetrieve_group")]
        public string retrieve_group{
            get{
                return this.n_sRetrieve_group;
            }
            set{
                this.n_sRetrieve_group=value;
            }
        }
        #endregion retrieve_group
        
        
        protected global::System.Nullable<DateTime> n_dRetrieve_date=null;
        #region retrieve_date
        [System.Data.Linq.Mapping.Column(Name="[retrieve_date]", Storage="n_dRetrieve_date")]
        public global::System.Nullable<DateTime> retrieve_date{
            get{
                return this.n_dRetrieve_date;
            }
            set{
                this.n_dRetrieve_date=value;
            }
        }
        #endregion retrieve_date
        
        
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
        
        
        protected string n_sRetrieve_sn=global::System.String.Empty;
        #region retrieve_sn
        [System.Data.Linq.Mapping.Column(Name="[retrieve_sn]", Storage="n_sRetrieve_sn")]
        public string retrieve_sn{
            get{
                return this.n_sRetrieve_sn;
            }
            set{
                this.n_sRetrieve_sn=value;
            }
        }
        #endregion retrieve_sn
        
        
        protected string n_sReport_type=global::System.String.Empty;
        #region report_type
        [System.Data.Linq.Mapping.Column(Name="[report_type]", Storage="n_sReport_type")]
        public string report_type{
            get{
                return this.n_sReport_type;
            }
            set{
                this.n_sReport_type=value;
            }
        }
        #endregion report_type
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private MobileOrderReportRetrieveDetailInfo n_oTableSet = MobileOrderReportRetrieveDetailInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string id="id";
            public const string did="did";
            public const string active="active";
            public const string guid_id="guid_id";
            public const string retrieve_group="retrieve_group";
            public const string retrieve_date="retrieve_date";
            public const string ddate="ddate";
            public const string retrieve_sn="retrieve_sn";
            public const string report_type="report_type";
            public const string MobileOrderReportRetrieveDetail_table_name="MobileOrderReportRetrieveDetail";
            public static string TableName() { return MobileOrderReportRetrieveDetail_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public MobileOrderReportRetrieveDetailEntity(){
            Init();
        }
        public MobileOrderReportRetrieveDetailEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public MobileOrderReportRetrieveDetailEntity(MSSQLConnect x_oDB,global::System.Nullable<Guid> x_gGuid_id,global::System.Nullable<bool> x_bActive){
            n_oDB=x_oDB;
            this.Load(x_gGuid_id,x_bActive);
            Init();
        }
        
        public MobileOrderReportRetrieveDetailEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId){
            n_oDB=x_oDB;
            this.Load(x_iId);
            Init();
        }
        
        ~MobileOrderReportRetrieveDetailEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<Guid> x_gGuid_id,global::System.Nullable<bool> x_bActive){
            if (n_oDB==null) { return false; }
            if (x_gGuid_id==null) { return false; }
            if (x_bActive==null) { return false; }
            string _sQuery = "SELECT   [MobileOrderReportRetrieveDetail].[id] AS MOBILEORDERREPORTRETRIEVEDETAIL_ID,[MobileOrderReportRetrieveDetail].[active] AS MOBILEORDERREPORTRETRIEVEDETAIL_ACTIVE,[MobileOrderReportRetrieveDetail].[did] AS MOBILEORDERREPORTRETRIEVEDETAIL_DID,[MobileOrderReportRetrieveDetail].[guid_id] AS MOBILEORDERREPORTRETRIEVEDETAIL_GUID_ID,[MobileOrderReportRetrieveDetail].[retrieve_group] AS MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_GROUP,[MobileOrderReportRetrieveDetail].[retrieve_date] AS MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_DATE,[MobileOrderReportRetrieveDetail].[ddate] AS MOBILEORDERREPORTRETRIEVEDETAIL_DDATE,[MobileOrderReportRetrieveDetail].[retrieve_sn] AS MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_SN,[MobileOrderReportRetrieveDetail].[report_type] AS MOBILEORDERREPORTRETRIEVEDETAIL_REPORT_TYPE  FROM  [MobileOrderReportRetrieveDetail]  WHERE  [MobileOrderReportRetrieveDetail].[guid_id] = \'"+x_gGuid_id.ToString()+"\'  AND  [MobileOrderReportRetrieveDetail].[active] = \'"+x_bActive.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportRetrieveDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportRetrieveDetail]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_ID"])) {n_iId = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_ID"];}else{n_iId=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_DID"])) {n_sDid = (string)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_DID"];}else{n_sDid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_GUID_ID"])) {n_gGuid_id = (global::System.Nullable<Guid>)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_GUID_ID"];}else{n_gGuid_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_GROUP"])) {n_sRetrieve_group = (string)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_GROUP"];}else{n_sRetrieve_group=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_DATE"])) {n_dRetrieve_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_DATE"];}else{n_dRetrieve_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_DDATE"])) {n_dDdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_DDATE"];}else{n_dDdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_SN"])) {n_sRetrieve_sn = (string)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_SN"];}else{n_sRetrieve_sn=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_REPORT_TYPE"])) {n_sReport_type = (string)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_REPORT_TYPE"];}else{n_sReport_type=global::System.String.Empty;}
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
        
        public bool Load(global::System.Nullable<int> x_iId){
            if (n_oDB==null) { return false; }
            if (x_iId==null) { return false; }
            string _sQuery = "SELECT   [MobileOrderReportRetrieveDetail].[id] AS MOBILEORDERREPORTRETRIEVEDETAIL_ID,[MobileOrderReportRetrieveDetail].[active] AS MOBILEORDERREPORTRETRIEVEDETAIL_ACTIVE,[MobileOrderReportRetrieveDetail].[did] AS MOBILEORDERREPORTRETRIEVEDETAIL_DID,[MobileOrderReportRetrieveDetail].[guid_id] AS MOBILEORDERREPORTRETRIEVEDETAIL_GUID_ID,[MobileOrderReportRetrieveDetail].[retrieve_group] AS MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_GROUP,[MobileOrderReportRetrieveDetail].[retrieve_date] AS MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_DATE,[MobileOrderReportRetrieveDetail].[ddate] AS MOBILEORDERREPORTRETRIEVEDETAIL_DDATE,[MobileOrderReportRetrieveDetail].[retrieve_sn] AS MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_SN,[MobileOrderReportRetrieveDetail].[report_type] AS MOBILEORDERREPORTRETRIEVEDETAIL_REPORT_TYPE  FROM  [MobileOrderReportRetrieveDetail]  WHERE  [MobileOrderReportRetrieveDetail].[id] = \'"+x_iId.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportRetrieveDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportRetrieveDetail]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_ID"])) {n_iId = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_ID"];}else{n_iId=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_DID"])) {n_sDid = (string)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_DID"];}else{n_sDid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_GUID_ID"])) {n_gGuid_id = (global::System.Nullable<Guid>)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_GUID_ID"];}else{n_gGuid_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_GROUP"])) {n_sRetrieve_group = (string)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_GROUP"];}else{n_sRetrieve_group=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_DATE"])) {n_dRetrieve_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_DATE"];}else{n_dRetrieve_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_DDATE"])) {n_dDdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_DDATE"];}else{n_dDdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_SN"])) {n_sRetrieve_sn = (string)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_SN"];}else{n_sRetrieve_sn=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_REPORT_TYPE"])) {n_sReport_type = (string)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_REPORT_TYPE"];}else{n_sReport_type=global::System.String.Empty;}
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
            if (n_bActive==null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_sDid==null && !(n_oTableSet.Fields(Para.did).IsNullable)) return false;
            if (n_gGuid_id==null && !(n_oTableSet.Fields(Para.guid_id).IsNullable)) return false;
            if (n_sRetrieve_group==null && !(n_oTableSet.Fields(Para.retrieve_group).IsNullable)) return false;
            if (n_dRetrieve_date==null && !(n_oTableSet.Fields(Para.retrieve_date).IsNullable)) return false;
            if (n_dDdate==null && !(n_oTableSet.Fields(Para.ddate).IsNullable)) return false;
            if (n_sRetrieve_sn==null && !(n_oTableSet.Fields(Para.retrieve_sn).IsNullable)) return false;
            if (n_sReport_type==null && !(n_oTableSet.Fields(Para.report_type).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(MobileOrderReportRetrieveDetailEntity)) || (x_oObj is MobileOrderReportRetrieveDetailEntity)) return MobileOrderReportRetrieveDetailRepository.Instance();
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
        public MobileOrderReportRetrieveDetailInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(MobileOrderReportRetrieveDetailInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public global::System.Nullable<int> GetId(){return this.id;}
        public string GetDid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.did)) { return string.Empty; }
            return this.did;
        }
        public global::System.Nullable<bool> GetActive(){return this.active;}
        public global::System.Nullable<Guid> GetGuid_id(){return this.guid_id;}
        public string GetRetrieve_group(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.retrieve_group)) { return string.Empty; }
            return this.retrieve_group;
        }
        public global::System.Nullable<DateTime> GetRetrieve_date(){return this.retrieve_date;}
        public global::System.Nullable<DateTime> GetDdate(){return this.ddate;}
        public string GetRetrieve_sn(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.retrieve_sn)) { return string.Empty; }
            return this.retrieve_sn;
        }
        public string GetReport_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.report_type)) { return string.Empty; }
            return this.report_type;
        }
        
        public bool SetId(global::System.Nullable<int> value){
            this.id=value;
            return true;
        }
        public bool SetDid(string value){
            this.did=value;
            return true;
        }
        public bool SetActive(global::System.Nullable<bool> value){
            this.active=value;
            return true;
        }
        public bool SetGuid_id(global::System.Nullable<Guid> value){
            this.guid_id=value;
            return true;
        }
        public bool SetRetrieve_group(string value){
            this.retrieve_group=value;
            return true;
        }
        public bool SetRetrieve_date(global::System.Nullable<DateTime> value){
            this.retrieve_date=value;
            return true;
        }
        public bool SetDdate(global::System.Nullable<DateTime> value){
            this.ddate=value;
            return true;
        }
        public bool SetRetrieve_sn(string value){
            this.retrieve_sn=value;
            return true;
        }
        public bool SetReport_type(string value){
            this.report_type=value;
            return true;
        }
        
        public Field GetIdTable(){
            return n_oTableSet.Fields(Para.id);
        }
        public Field GetDidTable(){
            return n_oTableSet.Fields(Para.did);
        }
        public Field GetActiveTable(){
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetGuid_idTable(){
            return n_oTableSet.Fields(Para.guid_id);
        }
        public Field GetRetrieve_groupTable(){
            return n_oTableSet.Fields(Para.retrieve_group);
        }
        public Field GetRetrieve_dateTable(){
            return n_oTableSet.Fields(Para.retrieve_date);
        }
        public Field GetDdateTable(){
            return n_oTableSet.Fields(Para.ddate);
        }
        public Field GetRetrieve_snTable(){
            return n_oTableSet.Fields(Para.retrieve_sn);
        }
        public Field GetReport_typeTable(){
            return n_oTableSet.Fields(Para.report_type);
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
        
        public bool EqualID(MobileOrderReportRetrieveDetail x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(MobileOrderReportRetrieveDetail x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_iId.Equals(x_oObj.id)){ return false; }
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_sDid.Equals(x_oObj.did)){ return false; }
            if(!this.n_gGuid_id.Equals(x_oObj.guid_id)){ return false; }
            if(!this.n_sRetrieve_group.Equals(x_oObj.retrieve_group)){ return false; }
            if(!this.n_dRetrieve_date.Equals(x_oObj.retrieve_date)){ return false; }
            if(!this.n_dDdate.Equals(x_oObj.ddate)){ return false; }
            if(!this.n_sRetrieve_sn.Equals(x_oObj.retrieve_sn)){ return false; }
            if(!this.n_sReport_type.Equals(x_oObj.report_type)){ return false; }
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
            if(!n_gGuid_id.Equals(null) && !n_bActive.Equals(null)){
                _bResult=this.Load(n_gGuid_id,n_bActive);
                if(_bResult){ return _bResult;}
            }
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
            string _sQuery = "UPDATE  [MobileOrderReportRetrieveDetail]  SET  [active]=@active,[did]=@did,[guid_id]=@guid_id,[retrieve_group]=@retrieve_group,[retrieve_date]=@retrieve_date,[ddate]=@ddate,[retrieve_sn]=@retrieve_sn,[report_type]=@report_type  WHERE [MobileOrderReportRetrieveDetail].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportRetrieveDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportRetrieveDetail]"); }
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
            if(n_bActive==null){  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=n_bActive; }
            if(n_sDid==null){  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.VarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.VarChar,10).Value=n_sDid; }
            if(n_gGuid_id==null){  _oCmd.Parameters.Add("@guid_id", global::System.Data.SqlDbType.UniqueIdentifier).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@guid_id", global::System.Data.SqlDbType.UniqueIdentifier).Value=n_gGuid_id; }
            if(n_sRetrieve_group==null){  _oCmd.Parameters.Add("@retrieve_group", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@retrieve_group", global::System.Data.SqlDbType.NVarChar,50).Value=n_sRetrieve_group; }
            if(n_dRetrieve_date==null){  _oCmd.Parameters.Add("@retrieve_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@retrieve_date", global::System.Data.SqlDbType.DateTime).Value=n_dRetrieve_date; }
            if(n_dDdate==null){  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=n_dDdate; }
            if(n_sRetrieve_sn==null){  _oCmd.Parameters.Add("@retrieve_sn", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@retrieve_sn", global::System.Data.SqlDbType.Char,10).Value=n_sRetrieve_sn; }
            if(n_sReport_type==null){  _oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.Char,20).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.Char,20).Value=n_sReport_type; }
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
        /// Summary description for table [MobileOrderReportRetrieveDetail] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iId==null) { return false; }
            string _sQuery="DELETE FROM  [MobileOrderReportRetrieveDetail]  WHERE [MobileOrderReportRetrieveDetail].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportRetrieveDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportRetrieveDetail]"); }
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
        /// Summary description for table [MobileOrderReportRetrieveDetail] Object Base Clone
        /// </summary>
        
        public MobileOrderReportRetrieveDetail DeepClone()
        {
            MobileOrderReportRetrieveDetail _oMobileOrderReportRetrieveDetail_Clone = new MobileOrderReportRetrieveDetail();
            _oMobileOrderReportRetrieveDetail_Clone.id = this.n_iId;
            _oMobileOrderReportRetrieveDetail_Clone.active = this.n_bActive;
            _oMobileOrderReportRetrieveDetail_Clone.did = this.n_sDid;
            _oMobileOrderReportRetrieveDetail_Clone.guid_id = this.n_gGuid_id;
            _oMobileOrderReportRetrieveDetail_Clone.retrieve_group = this.n_sRetrieve_group;
            _oMobileOrderReportRetrieveDetail_Clone.retrieve_date = this.n_dRetrieve_date;
            _oMobileOrderReportRetrieveDetail_Clone.ddate = this.n_dDdate;
            _oMobileOrderReportRetrieveDetail_Clone.retrieve_sn = this.n_sRetrieve_sn;
            _oMobileOrderReportRetrieveDetail_Clone.report_type = this.n_sReport_type;
            _oMobileOrderReportRetrieveDetail_Clone.SetFound(this.n_bFound);
            _oMobileOrderReportRetrieveDetail_Clone.SetDB(this.n_oDB);
            _oMobileOrderReportRetrieveDetail_Clone.SetRow(this.n_oRow);
            _oMobileOrderReportRetrieveDetail_Clone.SetTbl(this.n_oTbl);
            _oMobileOrderReportRetrieveDetail_Clone.SetTableSet(this.n_oTableSet);
            
            return _oMobileOrderReportRetrieveDetail_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_iId=null;
            n_bActive=null;
            n_sDid=global::System.String.Empty;
            n_gGuid_id=null;
            n_sRetrieve_group=global::System.String.Empty;
            n_dRetrieve_date=null;
            n_dDdate=null;
            n_sRetrieve_sn=global::System.String.Empty;
            n_sReport_type=global::System.String.Empty;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = MobileOrderReportRetrieveDetailInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


