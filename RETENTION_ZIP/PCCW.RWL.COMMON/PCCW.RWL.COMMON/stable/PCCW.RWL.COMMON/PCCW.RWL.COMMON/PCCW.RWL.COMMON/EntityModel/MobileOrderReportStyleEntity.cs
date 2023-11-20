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
///-- Description:	<Description,Table :[MobileOrderReportStyle],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [MobileOrderReportStyle] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"MobileOrderReportStyle")]
    public class MobileOrderReportStyleEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        
        protected global::System.Nullable<int> n_iReport_id=null;
        #region report_id
        [System.Data.Linq.Mapping.Column(Name="[report_id]", Storage="n_iReport_id")]
        public global::System.Nullable<int> report_id{
            get{
                return this.n_iReport_id;
            }
            set{
                this.n_iReport_id=value;
            }
        }
        #endregion report_id
        
        
        protected global::System.Nullable<bool> n_bVas_show=null;
        #region vas_show
        [System.Data.Linq.Mapping.Column(Name="[vas_show]", Storage="n_bVas_show")]
        public global::System.Nullable<bool> vas_show{
            get{
                return this.n_bVas_show;
            }
            set{
                this.n_bVas_show=value;
            }
        }
        #endregion vas_show
        
        
        protected string n_sFormat=global::System.String.Empty;
        #region format
        [System.Data.Linq.Mapping.Column(Name="[format]", Storage="n_sFormat")]
        public string format{
            get{
                return this.n_sFormat;
            }
            set{
                this.n_sFormat=value;
            }
        }
        #endregion format
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private MobileOrderReportStyleInfo n_oTableSet = MobileOrderReportStyleInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string id="id";
            public const string cdate="cdate";
            public const string cid="cid";
            public const string active="active";
            public const string status="status";
            public const string type="type";
            public const string report_id="report_id";
            public const string format="format";
            public const string vas_show="vas_show";
            public const string MobileOrderReportStyle_table_name="MobileOrderReportStyle";
            public static string TableName() { return MobileOrderReportStyle_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public MobileOrderReportStyleEntity(){
            Init();
        }
        public MobileOrderReportStyleEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public MobileOrderReportStyleEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId){
            n_oDB=x_oDB;
            this.Load(x_iId);
            Init();
        }
        
        ~MobileOrderReportStyleEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iId){
            if (n_oDB==null) { return false; }
            if (x_iId==null) { return false; }
            string _sQuery = "SELECT   [MobileOrderReportStyle].[id] AS MOBILEORDERREPORTSTYLE_ID,[MobileOrderReportStyle].[cdate] AS MOBILEORDERREPORTSTYLE_CDATE,[MobileOrderReportStyle].[cid] AS MOBILEORDERREPORTSTYLE_CID,[MobileOrderReportStyle].[active] AS MOBILEORDERREPORTSTYLE_ACTIVE,[MobileOrderReportStyle].[status] AS MOBILEORDERREPORTSTYLE_STATUS,[MobileOrderReportStyle].[type] AS MOBILEORDERREPORTSTYLE_TYPE,[MobileOrderReportStyle].[report_id] AS MOBILEORDERREPORTSTYLE_REPORT_ID,[MobileOrderReportStyle].[vas_show] AS MOBILEORDERREPORTSTYLE_VAS_SHOW,[MobileOrderReportStyle].[format] AS MOBILEORDERREPORTSTYLE_FORMAT  FROM  [MobileOrderReportStyle]  WHERE  [MobileOrderReportStyle].[id] = \'"+x_iId.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportStyle]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportStyle]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_ID"])) {n_iId = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTSTYLE_ID"];}else{n_iId=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_CDATE"])) {n_dCdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTSTYLE_CDATE"];}else{n_dCdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_CID"])) {n_sCid = (string)_oData["MOBILEORDERREPORTSTYLE_CID"];}else{n_sCid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTSTYLE_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_STATUS"])) {n_sStatus = (string)_oData["MOBILEORDERREPORTSTYLE_STATUS"];}else{n_sStatus=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_TYPE"])) {n_sType = (string)_oData["MOBILEORDERREPORTSTYLE_TYPE"];}else{n_sType=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_REPORT_ID"])) {n_iReport_id = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTSTYLE_REPORT_ID"];}else{n_iReport_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_VAS_SHOW"])) {n_bVas_show = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTSTYLE_VAS_SHOW"];}else{n_bVas_show=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_FORMAT"])) {n_sFormat = (string)_oData["MOBILEORDERREPORTSTYLE_FORMAT"];}else{n_sFormat=global::System.String.Empty;}
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
            if (n_bActive==null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_sStatus==null && !(n_oTableSet.Fields(Para.status).IsNullable)) return false;
            if (n_sType==null && !(n_oTableSet.Fields(Para.type).IsNullable)) return false;
            if (n_iReport_id==null && !(n_oTableSet.Fields(Para.report_id).IsNullable)) return false;
            if (n_bVas_show==null && !(n_oTableSet.Fields(Para.vas_show).IsNullable)) return false;
            if (n_sFormat==null && !(n_oTableSet.Fields(Para.format).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(MobileOrderReportStyleEntity)) || (x_oObj is MobileOrderReportStyleEntity)) return MobileOrderReportStyleRepository.Instance();
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
        public MobileOrderReportStyleInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(MobileOrderReportStyleInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public global::System.Nullable<int> GetId(){return this.id;}
        public global::System.Nullable<DateTime> GetCdate(){return this.cdate;}
        public string GetCid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.cid)) { return string.Empty; }
            return this.cid;
        }
        public global::System.Nullable<bool> GetActive(){return this.active;}
        public string GetStatus(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.status)) { return string.Empty; }
            return this.status;
        }
        public string GetType(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.type)) { return string.Empty; }
            return this.type;
        }
        public global::System.Nullable<int> GetReport_id(){return this.report_id;}
        public string GetFormat(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.format)) { return string.Empty; }
            return this.format;
        }
        public global::System.Nullable<bool> GetVas_show(){return this.vas_show;}
        
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
        public bool SetActive(global::System.Nullable<bool> value){
            this.active=value;
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
        public bool SetReport_id(global::System.Nullable<int> value){
            this.report_id=value;
            return true;
        }
        public bool SetFormat(string value){
            this.format=value;
            return true;
        }
        public bool SetVas_show(global::System.Nullable<bool> value){
            this.vas_show=value;
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
        public Field GetActiveTable(){
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetStatusTable(){
            return n_oTableSet.Fields(Para.status);
        }
        public Field GetTypeTable(){
            return n_oTableSet.Fields(Para.type);
        }
        public Field GetReport_idTable(){
            return n_oTableSet.Fields(Para.report_id);
        }
        public Field GetFormatTable(){
            return n_oTableSet.Fields(Para.format);
        }
        public Field GetVas_showTable(){
            return n_oTableSet.Fields(Para.vas_show);
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
        
        public bool EqualID(MobileOrderReportStyle x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(MobileOrderReportStyle x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_iId.Equals(x_oObj.id)){ return false; }
            if(!this.n_dCdate.Equals(x_oObj.cdate)){ return false; }
            if(!this.n_sCid.Equals(x_oObj.cid)){ return false; }
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_sStatus.Equals(x_oObj.status)){ return false; }
            if(!this.n_sType.Equals(x_oObj.type)){ return false; }
            if(!this.n_iReport_id.Equals(x_oObj.report_id)){ return false; }
            if(!this.n_bVas_show.Equals(x_oObj.vas_show)){ return false; }
            if(!this.n_sFormat.Equals(x_oObj.format)){ return false; }
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
            string _sQuery = "UPDATE  [MobileOrderReportStyle]  SET  [cdate]=@cdate,[cid]=@cid,[active]=@active,[status]=@status,[type]=@type,[report_id]=@report_id,[vas_show]=@vas_show,[format]=@format  WHERE [MobileOrderReportStyle].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportStyle]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportStyle]"); }
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
            if(n_sCid==null){  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NChar,10).Value=n_sCid; }
            if(n_bActive==null){  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=n_bActive; }
            if(n_sStatus==null){  _oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NChar,50).Value=n_sStatus; }
            if(n_sType==null){  _oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NChar,20).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NChar,20).Value=n_sType; }
            if(n_iReport_id==null){  _oCmd.Parameters.Add("@report_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@report_id", global::System.Data.SqlDbType.Int).Value=n_iReport_id; }
            if(n_bVas_show==null){  _oCmd.Parameters.Add("@vas_show", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@vas_show", global::System.Data.SqlDbType.Bit).Value=n_bVas_show; }
            if(n_sFormat==null){  _oCmd.Parameters.Add("@format", global::System.Data.SqlDbType.NChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@format", global::System.Data.SqlDbType.NChar,10).Value=n_sFormat; }
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
        /// Summary description for table [MobileOrderReportStyle] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iId==null) { return false; }
            string _sQuery="DELETE FROM  [MobileOrderReportStyle]  WHERE [MobileOrderReportStyle].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportStyle]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportStyle]"); }
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
        /// Summary description for table [MobileOrderReportStyle] Object Base Clone
        /// </summary>
        
        public MobileOrderReportStyle DeepClone()
        {
            MobileOrderReportStyle _oMobileOrderReportStyle_Clone = new MobileOrderReportStyle();
            _oMobileOrderReportStyle_Clone.id = this.n_iId;
            _oMobileOrderReportStyle_Clone.cdate = this.n_dCdate;
            _oMobileOrderReportStyle_Clone.cid = this.n_sCid;
            _oMobileOrderReportStyle_Clone.active = this.n_bActive;
            _oMobileOrderReportStyle_Clone.status = this.n_sStatus;
            _oMobileOrderReportStyle_Clone.type = this.n_sType;
            _oMobileOrderReportStyle_Clone.report_id = this.n_iReport_id;
            _oMobileOrderReportStyle_Clone.vas_show = this.n_bVas_show;
            _oMobileOrderReportStyle_Clone.format = this.n_sFormat;
            _oMobileOrderReportStyle_Clone.SetFound(this.n_bFound);
            _oMobileOrderReportStyle_Clone.SetDB(this.n_oDB);
            _oMobileOrderReportStyle_Clone.SetRow(this.n_oRow);
            _oMobileOrderReportStyle_Clone.SetTbl(this.n_oTbl);
            _oMobileOrderReportStyle_Clone.SetTableSet(this.n_oTableSet);
            
            return _oMobileOrderReportStyle_Clone;
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
            n_bActive=null;
            n_sStatus=global::System.String.Empty;
            n_sType=global::System.String.Empty;
            n_iReport_id=null;
            n_bVas_show=null;
            n_sFormat=global::System.String.Empty;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = MobileOrderReportStyleInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


