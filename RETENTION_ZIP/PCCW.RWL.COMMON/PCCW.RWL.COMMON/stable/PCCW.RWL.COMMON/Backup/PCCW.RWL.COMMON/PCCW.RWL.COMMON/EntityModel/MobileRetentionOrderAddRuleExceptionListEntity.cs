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
///-- Create date: <Create Date 2011-02-02>
///-- Description:	<Description,Table :[MobileRetentionOrderAddRuleExceptionList],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [MobileRetentionOrderAddRuleExceptionList] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"MobileRetentionOrderAddRuleExceptionList")]
    public class MobileRetentionOrderAddRuleExceptionListEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        
        protected string n_sFilename=global::System.String.Empty;
        #region filename
        [System.Data.Linq.Mapping.Column(Name="[filename]", Storage="n_sFilename")]
        public string filename{
            get{
                return this.n_sFilename;
            }
            set{
                this.n_sFilename=value;
            }
        }
        #endregion filename
        
        
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
        private MobileRetentionOrderAddRuleExceptionListInfo n_oTableSet = MobileRetentionOrderAddRuleExceptionListInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string id="id";
            public const string cdate="cdate";
            public const string cid="cid";
            public const string mrt_no="mrt_no";
            public const string active="active";
            public const string filename="filename";
            public const string used="used";
            public const string order_id="order_id";
            public const string ddate="ddate";
            public const string did="did";
            public const string MobileRetentionOrderAddRuleExceptionList_table_name="MobileRetentionOrderAddRuleExceptionList";
            public static string TableName() { return MobileRetentionOrderAddRuleExceptionList_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public MobileRetentionOrderAddRuleExceptionListEntity(){
            Init();
        }
        public MobileRetentionOrderAddRuleExceptionListEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public MobileRetentionOrderAddRuleExceptionListEntity(MSSQLConnect x_oDB,string x_sMrt_no,string x_sFilename){
            n_oDB=x_oDB;
            this.Load(x_sMrt_no,x_sFilename);
            Init();
        }
        
        public MobileRetentionOrderAddRuleExceptionListEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId){
            n_oDB=x_oDB;
            this.Load(x_iId);
            Init();
        }
        
        ~MobileRetentionOrderAddRuleExceptionListEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(string x_sMrt_no,string x_sFilename){
            if (n_oDB==null) { return false; }
            if (x_sMrt_no==null) { return false; }
            if (x_sFilename==null) { return false; }
            string _sQuery = "SELECT   [MobileRetentionOrderAddRuleExceptionList].[id] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ID,[MobileRetentionOrderAddRuleExceptionList].[cdate] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_CDATE,[MobileRetentionOrderAddRuleExceptionList].[cid] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_CID,[MobileRetentionOrderAddRuleExceptionList].[filename] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_FILENAME,[MobileRetentionOrderAddRuleExceptionList].[active] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ACTIVE,[MobileRetentionOrderAddRuleExceptionList].[mrt_no] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_MRT_NO,[MobileRetentionOrderAddRuleExceptionList].[used] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_USED,[MobileRetentionOrderAddRuleExceptionList].[order_id] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ORDER_ID,[MobileRetentionOrderAddRuleExceptionList].[ddate] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_DDATE,[MobileRetentionOrderAddRuleExceptionList].[did] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_DID  FROM  [MobileRetentionOrderAddRuleExceptionList]  WHERE  [MobileRetentionOrderAddRuleExceptionList].[mrt_no] = \'"+x_sMrt_no.ToString()+"\'  AND  [MobileRetentionOrderAddRuleExceptionList].[filename] = \'"+x_sFilename.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionOrderAddRuleExceptionList]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrderAddRuleExceptionList]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ID"])) {n_iId = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ID"];}else{n_iId=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_CDATE"])) {n_dCdate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_CDATE"];}else{n_dCdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_CID"])) {n_sCid = (string)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_CID"];}else{n_sCid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_FILENAME"])) {n_sFilename = (string)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_FILENAME"];}else{n_sFilename=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_MRT_NO"])) {n_sMrt_no = (string)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_MRT_NO"];}else{n_sMrt_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_USED"])) {n_bUsed = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_USED"];}else{n_bUsed=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ORDER_ID"])) {n_iOrder_id = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ORDER_ID"];}else{n_iOrder_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_DDATE"])) {n_dDdate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_DDATE"];}else{n_dDdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_DID"])) {n_sDid = (string)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_DID"];}else{n_sDid=global::System.String.Empty;}
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
            string _sQuery = "SELECT   [MobileRetentionOrderAddRuleExceptionList].[id] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ID,[MobileRetentionOrderAddRuleExceptionList].[cdate] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_CDATE,[MobileRetentionOrderAddRuleExceptionList].[cid] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_CID,[MobileRetentionOrderAddRuleExceptionList].[filename] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_FILENAME,[MobileRetentionOrderAddRuleExceptionList].[active] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ACTIVE,[MobileRetentionOrderAddRuleExceptionList].[mrt_no] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_MRT_NO,[MobileRetentionOrderAddRuleExceptionList].[used] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_USED,[MobileRetentionOrderAddRuleExceptionList].[order_id] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ORDER_ID,[MobileRetentionOrderAddRuleExceptionList].[ddate] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_DDATE,[MobileRetentionOrderAddRuleExceptionList].[did] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_DID  FROM  [MobileRetentionOrderAddRuleExceptionList]  WHERE  [MobileRetentionOrderAddRuleExceptionList].[id] = \'"+x_iId.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionOrderAddRuleExceptionList]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrderAddRuleExceptionList]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ID"])) {n_iId = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ID"];}else{n_iId=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_CDATE"])) {n_dCdate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_CDATE"];}else{n_dCdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_CID"])) {n_sCid = (string)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_CID"];}else{n_sCid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_FILENAME"])) {n_sFilename = (string)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_FILENAME"];}else{n_sFilename=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_MRT_NO"])) {n_sMrt_no = (string)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_MRT_NO"];}else{n_sMrt_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_USED"])) {n_bUsed = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_USED"];}else{n_bUsed=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ORDER_ID"])) {n_iOrder_id = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ORDER_ID"];}else{n_iOrder_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_DDATE"])) {n_dDdate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_DDATE"];}else{n_dDdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_DID"])) {n_sDid = (string)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_DID"];}else{n_sDid=global::System.String.Empty;}
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
            if (n_sFilename==null && !(n_oTableSet.Fields(Para.filename).IsNullable)) return false;
            if (n_bActive==null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_sMrt_no==null && !(n_oTableSet.Fields(Para.mrt_no).IsNullable)) return false;
            if (n_bUsed==null && !(n_oTableSet.Fields(Para.used).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(MobileRetentionOrderAddRuleExceptionListEntity)) || (x_oObj is MobileRetentionOrderAddRuleExceptionListEntity)) return MobileRetentionOrderAddRuleExceptionListRepository.Instance();
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
        public MobileRetentionOrderAddRuleExceptionListInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(MobileRetentionOrderAddRuleExceptionListInfo value){ n_oTableSet=value; }
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
        public global::System.Nullable<bool> GetActive(){return this.active;}
        public string GetFilename(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.filename)) { return string.Empty; }
            return this.filename;
        }
        public global::System.Nullable<bool> GetUsed(){return this.used;}
        public global::System.Nullable<int> GetOrder_id(){return this.order_id;}
        public global::System.Nullable<DateTime> GetDdate(){return this.ddate;}
        public string GetDid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.did)) { return string.Empty; }
            return this.did;
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
        public bool SetActive(global::System.Nullable<bool> value){
            this.active=value;
            return true;
        }
        public bool SetFilename(string value){
            this.filename=value;
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
        public bool SetDdate(global::System.Nullable<DateTime> value){
            this.ddate=value;
            return true;
        }
        public bool SetDid(string value){
            this.did=value;
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
        public Field GetActiveTable(){
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetFilenameTable(){
            return n_oTableSet.Fields(Para.filename);
        }
        public Field GetUsedTable(){
            return n_oTableSet.Fields(Para.used);
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
        
        public bool EqualID(MobileRetentionOrderAddRuleExceptionList x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(MobileRetentionOrderAddRuleExceptionList x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_iId.Equals(x_oObj.id)){ return false; }
            if(!this.n_dCdate.Equals(x_oObj.cdate)){ return false; }
            if(!this.n_sCid.Equals(x_oObj.cid)){ return false; }
            if(!this.n_sFilename.Equals(x_oObj.filename)){ return false; }
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_sMrt_no.Equals(x_oObj.mrt_no)){ return false; }
            if(!this.n_bUsed.Equals(x_oObj.used)){ return false; }
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
            if(!n_sMrt_no.Equals(global::System.String.Empty) && !n_sFilename.Equals(global::System.String.Empty)){
                _bResult=this.Load(n_sMrt_no,n_sFilename);
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
            string _sQuery = "UPDATE  [MobileRetentionOrderAddRuleExceptionList]  SET  [cdate]=@cdate,[cid]=@cid,[filename]=@filename,[active]=@active,[mrt_no]=@mrt_no,[used]=@used,[order_id]=@order_id,[ddate]=@ddate,[did]=@did  WHERE [MobileRetentionOrderAddRuleExceptionList].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionOrderAddRuleExceptionList]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrderAddRuleExceptionList]"); }
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
            if(n_sFilename==null){  _oCmd.Parameters.Add("@filename", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@filename", global::System.Data.SqlDbType.NVarChar,250).Value=n_sFilename; }
            if(n_bActive==null){  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=n_bActive; }
            if(n_sMrt_no==null){  _oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.NVarChar,50).Value=n_sMrt_no; }
            if(n_bUsed==null){  _oCmd.Parameters.Add("@used", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@used", global::System.Data.SqlDbType.Bit).Value=n_bUsed; }
            if(n_iOrder_id==null){  _oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=n_iOrder_id; }
            if(n_dDdate==null){  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=n_dDdate; }
            if(n_sDid==null){  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value=n_sDid; }
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
        /// Summary description for table [MobileRetentionOrderAddRuleExceptionList] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iId==null) { return false; }
            string _sQuery="DELETE FROM  [MobileRetentionOrderAddRuleExceptionList]  WHERE [MobileRetentionOrderAddRuleExceptionList].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionOrderAddRuleExceptionList]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrderAddRuleExceptionList]"); }
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
        /// Summary description for table [MobileRetentionOrderAddRuleExceptionList] Object Base Clone
        /// </summary>
        
        public MobileRetentionOrderAddRuleExceptionList DeepClone()
        {
            MobileRetentionOrderAddRuleExceptionList _oMobileRetentionOrderAddRuleExceptionList_Clone = new MobileRetentionOrderAddRuleExceptionList();
            _oMobileRetentionOrderAddRuleExceptionList_Clone.id = this.n_iId;
            _oMobileRetentionOrderAddRuleExceptionList_Clone.cdate = this.n_dCdate;
            _oMobileRetentionOrderAddRuleExceptionList_Clone.cid = this.n_sCid;
            _oMobileRetentionOrderAddRuleExceptionList_Clone.filename = this.n_sFilename;
            _oMobileRetentionOrderAddRuleExceptionList_Clone.active = this.n_bActive;
            _oMobileRetentionOrderAddRuleExceptionList_Clone.mrt_no = this.n_sMrt_no;
            _oMobileRetentionOrderAddRuleExceptionList_Clone.used = this.n_bUsed;
            _oMobileRetentionOrderAddRuleExceptionList_Clone.order_id = this.n_iOrder_id;
            _oMobileRetentionOrderAddRuleExceptionList_Clone.ddate = this.n_dDdate;
            _oMobileRetentionOrderAddRuleExceptionList_Clone.did = this.n_sDid;
            _oMobileRetentionOrderAddRuleExceptionList_Clone.SetFound(this.n_bFound);
            _oMobileRetentionOrderAddRuleExceptionList_Clone.SetDB(this.n_oDB);
            _oMobileRetentionOrderAddRuleExceptionList_Clone.SetRow(this.n_oRow);
            _oMobileRetentionOrderAddRuleExceptionList_Clone.SetTbl(this.n_oTbl);
            _oMobileRetentionOrderAddRuleExceptionList_Clone.SetTableSet(this.n_oTableSet);
            
            return _oMobileRetentionOrderAddRuleExceptionList_Clone;
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
            n_sFilename=global::System.String.Empty;
            n_bActive=null;
            n_sMrt_no=global::System.String.Empty;
            n_bUsed=null;
            n_iOrder_id=null;
            n_dDdate=null;
            n_sDid=global::System.String.Empty;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = MobileRetentionOrderAddRuleExceptionListInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


