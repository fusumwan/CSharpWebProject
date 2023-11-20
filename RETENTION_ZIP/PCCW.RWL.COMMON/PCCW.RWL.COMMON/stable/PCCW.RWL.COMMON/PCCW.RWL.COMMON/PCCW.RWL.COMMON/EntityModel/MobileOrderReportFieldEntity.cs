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
///-- Description:	<Description,Table :[MobileOrderReportField],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [MobileOrderReportField] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"MobileOrderReportField")]
    public class MobileOrderReportFieldEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        
        protected string n_sField_title=global::System.String.Empty;
        #region field_title
        [System.Data.Linq.Mapping.Column(Name="[field_title]", Storage="n_sField_title")]
        public string field_title{
            get{
                return this.n_sField_title;
            }
            set{
                this.n_sField_title=value;
            }
        }
        #endregion field_title
        
        
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
        
        
        protected global::System.Nullable<int> n_iField_content_order=null;
        #region field_content_order
        [System.Data.Linq.Mapping.Column(Name="[field_content_order]", Storage="n_iField_content_order")]
        public global::System.Nullable<int> field_content_order{
            get{
                return this.n_iField_content_order;
            }
            set{
                this.n_iField_content_order=value;
            }
        }
        #endregion field_content_order
        
        
        protected string n_sField_content=global::System.String.Empty;
        #region field_content
        [System.Data.Linq.Mapping.Column(Name="[field_content]", Storage="n_sField_content")]
        public string field_content{
            get{
                return this.n_sField_content;
            }
            set{
                this.n_sField_content=value;
            }
        }
        #endregion field_content
        
        
        protected string n_sField_content_name=global::System.String.Empty;
        #region field_content_name
        [System.Data.Linq.Mapping.Column(Name="[field_content_name]", Storage="n_sField_content_name")]
        public string field_content_name{
            get{
                return this.n_sField_content_name;
            }
            set{
                this.n_sField_content_name=value;
            }
        }
        #endregion field_content_name
        
        
        protected global::System.Nullable<int> n_iField_order=null;
        #region field_order
        [System.Data.Linq.Mapping.Column(Name="[field_order]", Storage="n_iField_order")]
        public global::System.Nullable<int> field_order{
            get{
                return this.n_iField_order;
            }
            set{
                this.n_iField_order=value;
            }
        }
        #endregion field_order
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private MobileOrderReportFieldInfo n_oTableSet = MobileOrderReportFieldInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string id="id";
            public const string cdate="cdate";
            public const string cid="cid";
            public const string field_title="field_title";
            public const string active="active";
            public const string report_id="report_id";
            public const string field_content_order="field_content_order";
            public const string field_content="field_content";
            public const string field_content_name="field_content_name";
            public const string field_order="field_order";
            public const string MobileOrderReportField_table_name="MobileOrderReportField";
            public static string TableName() { return MobileOrderReportField_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public MobileOrderReportFieldEntity(){
            Init();
        }
        public MobileOrderReportFieldEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public MobileOrderReportFieldEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId){
            n_oDB=x_oDB;
            this.Load(x_iId);
            Init();
        }
        
        ~MobileOrderReportFieldEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iId){
            if (n_oDB==null) { return false; }
            if (x_iId==null) { return false; }
            string _sQuery = "SELECT   [MobileOrderReportField].[id] AS MOBILEORDERREPORTFIELD_ID,[MobileOrderReportField].[cdate] AS MOBILEORDERREPORTFIELD_CDATE,[MobileOrderReportField].[cid] AS MOBILEORDERREPORTFIELD_CID,[MobileOrderReportField].[field_title] AS MOBILEORDERREPORTFIELD_FIELD_TITLE,[MobileOrderReportField].[active] AS MOBILEORDERREPORTFIELD_ACTIVE,[MobileOrderReportField].[report_id] AS MOBILEORDERREPORTFIELD_REPORT_ID,[MobileOrderReportField].[field_content_order] AS MOBILEORDERREPORTFIELD_FIELD_CONTENT_ORDER,[MobileOrderReportField].[field_content] AS MOBILEORDERREPORTFIELD_FIELD_CONTENT,[MobileOrderReportField].[field_content_name] AS MOBILEORDERREPORTFIELD_FIELD_CONTENT_NAME,[MobileOrderReportField].[field_order] AS MOBILEORDERREPORTFIELD_FIELD_ORDER  FROM  [MobileOrderReportField]  WHERE  [MobileOrderReportField].[id] = \'"+x_iId.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportField]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportField]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_ID"])) {n_iId = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTFIELD_ID"];}else{n_iId=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_CDATE"])) {n_dCdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTFIELD_CDATE"];}else{n_dCdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_CID"])) {n_sCid = (string)_oData["MOBILEORDERREPORTFIELD_CID"];}else{n_sCid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_FIELD_TITLE"])) {n_sField_title = (string)_oData["MOBILEORDERREPORTFIELD_FIELD_TITLE"];}else{n_sField_title=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTFIELD_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_REPORT_ID"])) {n_iReport_id = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTFIELD_REPORT_ID"];}else{n_iReport_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_FIELD_CONTENT_ORDER"])) {n_iField_content_order = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTFIELD_FIELD_CONTENT_ORDER"];}else{n_iField_content_order=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_FIELD_CONTENT"])) {n_sField_content = (string)_oData["MOBILEORDERREPORTFIELD_FIELD_CONTENT"];}else{n_sField_content=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_FIELD_CONTENT_NAME"])) {n_sField_content_name = (string)_oData["MOBILEORDERREPORTFIELD_FIELD_CONTENT_NAME"];}else{n_sField_content_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_FIELD_ORDER"])) {n_iField_order = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTFIELD_FIELD_ORDER"];}else{n_iField_order=null;}
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
            if (n_sField_title==null && !(n_oTableSet.Fields(Para.field_title).IsNullable)) return false;
            if (n_bActive==null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_iReport_id==null && !(n_oTableSet.Fields(Para.report_id).IsNullable)) return false;
            if (n_iField_content_order==null && !(n_oTableSet.Fields(Para.field_content_order).IsNullable)) return false;
            if (n_sField_content==null && !(n_oTableSet.Fields(Para.field_content).IsNullable)) return false;
            if (n_sField_content_name==null && !(n_oTableSet.Fields(Para.field_content_name).IsNullable)) return false;
            if (n_iField_order==null && !(n_oTableSet.Fields(Para.field_order).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(MobileOrderReportFieldEntity)) || (x_oObj is MobileOrderReportFieldEntity)) return MobileOrderReportFieldRepository.Instance();
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
        public MobileOrderReportFieldInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(MobileOrderReportFieldInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public global::System.Nullable<int> GetId(){return this.id;}
        public global::System.Nullable<DateTime> GetCdate(){return this.cdate;}
        public string GetCid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.cid)) { return string.Empty; }
            return this.cid;
        }
        public string GetField_title(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.field_title)) { return string.Empty; }
            return this.field_title;
        }
        public global::System.Nullable<bool> GetActive(){return this.active;}
        public global::System.Nullable<int> GetReport_id(){return this.report_id;}
        public global::System.Nullable<int> GetField_content_order(){return this.field_content_order;}
        public string GetField_content(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.field_content)) { return string.Empty; }
            return this.field_content;
        }
        public string GetField_content_name(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.field_content_name)) { return string.Empty; }
            return this.field_content_name;
        }
        public global::System.Nullable<int> GetField_order(){return this.field_order;}
        
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
        public bool SetField_title(string value){
            this.field_title=value;
            return true;
        }
        public bool SetActive(global::System.Nullable<bool> value){
            this.active=value;
            return true;
        }
        public bool SetReport_id(global::System.Nullable<int> value){
            this.report_id=value;
            return true;
        }
        public bool SetField_content_order(global::System.Nullable<int> value){
            this.field_content_order=value;
            return true;
        }
        public bool SetField_content(string value){
            this.field_content=value;
            return true;
        }
        public bool SetField_content_name(string value){
            this.field_content_name=value;
            return true;
        }
        public bool SetField_order(global::System.Nullable<int> value){
            this.field_order=value;
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
        public Field GetField_titleTable(){
            return n_oTableSet.Fields(Para.field_title);
        }
        public Field GetActiveTable(){
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetReport_idTable(){
            return n_oTableSet.Fields(Para.report_id);
        }
        public Field GetField_content_orderTable(){
            return n_oTableSet.Fields(Para.field_content_order);
        }
        public Field GetField_contentTable(){
            return n_oTableSet.Fields(Para.field_content);
        }
        public Field GetField_content_nameTable(){
            return n_oTableSet.Fields(Para.field_content_name);
        }
        public Field GetField_orderTable(){
            return n_oTableSet.Fields(Para.field_order);
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
        
        public bool EqualID(MobileOrderReportField x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(MobileOrderReportField x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_iId.Equals(x_oObj.id)){ return false; }
            if(!this.n_dCdate.Equals(x_oObj.cdate)){ return false; }
            if(!this.n_sCid.Equals(x_oObj.cid)){ return false; }
            if(!this.n_sField_title.Equals(x_oObj.field_title)){ return false; }
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_iReport_id.Equals(x_oObj.report_id)){ return false; }
            if(!this.n_iField_content_order.Equals(x_oObj.field_content_order)){ return false; }
            if(!this.n_sField_content.Equals(x_oObj.field_content)){ return false; }
            if(!this.n_sField_content_name.Equals(x_oObj.field_content_name)){ return false; }
            if(!this.n_iField_order.Equals(x_oObj.field_order)){ return false; }
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
            string _sQuery = "UPDATE  [MobileOrderReportField]  SET  [cdate]=@cdate,[cid]=@cid,[field_title]=@field_title,[active]=@active,[report_id]=@report_id,[field_content_order]=@field_content_order,[field_content]=@field_content,[field_content_name]=@field_content_name,[field_order]=@field_order  WHERE [MobileOrderReportField].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportField]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportField]"); }
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
            if(n_sField_title==null){  _oCmd.Parameters.Add("@field_title", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@field_title", global::System.Data.SqlDbType.NVarChar,100).Value=n_sField_title; }
            if(n_bActive==null){  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=n_bActive; }
            if(n_iReport_id==null){  _oCmd.Parameters.Add("@report_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@report_id", global::System.Data.SqlDbType.Int).Value=n_iReport_id; }
            if(n_iField_content_order==null){  _oCmd.Parameters.Add("@field_content_order", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@field_content_order", global::System.Data.SqlDbType.Int).Value=n_iField_content_order; }
            if(n_sField_content==null){  _oCmd.Parameters.Add("@field_content", global::System.Data.SqlDbType.NText,1073741823).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@field_content", global::System.Data.SqlDbType.NText,1073741823).Value=n_sField_content; }
            if(n_sField_content_name==null){  _oCmd.Parameters.Add("@field_content_name", global::System.Data.SqlDbType.NChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@field_content_name", global::System.Data.SqlDbType.NChar,100).Value=n_sField_content_name; }
            if(n_iField_order==null){  _oCmd.Parameters.Add("@field_order", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@field_order", global::System.Data.SqlDbType.Int).Value=n_iField_order; }
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
        /// Summary description for table [MobileOrderReportField] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iId==null) { return false; }
            string _sQuery="DELETE FROM  [MobileOrderReportField]  WHERE [MobileOrderReportField].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportField]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportField]"); }
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
        /// Summary description for table [MobileOrderReportField] Object Base Clone
        /// </summary>
        
        public MobileOrderReportField DeepClone()
        {
            MobileOrderReportField _oMobileOrderReportField_Clone = new MobileOrderReportField();
            _oMobileOrderReportField_Clone.id = this.n_iId;
            _oMobileOrderReportField_Clone.cdate = this.n_dCdate;
            _oMobileOrderReportField_Clone.cid = this.n_sCid;
            _oMobileOrderReportField_Clone.field_title = this.n_sField_title;
            _oMobileOrderReportField_Clone.active = this.n_bActive;
            _oMobileOrderReportField_Clone.report_id = this.n_iReport_id;
            _oMobileOrderReportField_Clone.field_content_order = this.n_iField_content_order;
            _oMobileOrderReportField_Clone.field_content = this.n_sField_content;
            _oMobileOrderReportField_Clone.field_content_name = this.n_sField_content_name;
            _oMobileOrderReportField_Clone.field_order = this.n_iField_order;
            _oMobileOrderReportField_Clone.SetFound(this.n_bFound);
            _oMobileOrderReportField_Clone.SetDB(this.n_oDB);
            _oMobileOrderReportField_Clone.SetRow(this.n_oRow);
            _oMobileOrderReportField_Clone.SetTbl(this.n_oTbl);
            _oMobileOrderReportField_Clone.SetTableSet(this.n_oTableSet);
            
            return _oMobileOrderReportField_Clone;
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
            n_sField_title=global::System.String.Empty;
            n_bActive=null;
            n_iReport_id=null;
            n_iField_content_order=null;
            n_sField_content=global::System.String.Empty;
            n_sField_content_name=global::System.String.Empty;
            n_iField_order=null;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = MobileOrderReportFieldInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


