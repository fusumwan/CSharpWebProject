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
///-- Create date: <Create Date 2010-04-19>
///-- Description:	<Description,Table :[SpecialCustomer],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [SpecialCustomer] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"SpecialCustomer")]
    public class SpecialCustomerEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
        
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
        
        
        protected string n_sCondition1=global::System.String.Empty;
        #region condition1
        [System.Data.Linq.Mapping.Column(Name="[condition1]", Storage="n_sCondition1")]
        public string condition1{
            get{
                return this.n_sCondition1;
            }
            set{
                this.n_sCondition1=value;
            }
        }
        #endregion condition1
        
        
        protected string n_sCondition4=global::System.String.Empty;
        #region condition4
        [System.Data.Linq.Mapping.Column(Name="[condition4]", Storage="n_sCondition4")]
        public string condition4{
            get{
                return this.n_sCondition4;
            }
            set{
                this.n_sCondition4=value;
            }
        }
        #endregion condition4
        
        
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
        
        
        protected string n_sCondition3=global::System.String.Empty;
        #region condition3
        [System.Data.Linq.Mapping.Column(Name="[condition3]", Storage="n_sCondition3")]
        public string condition3{
            get{
                return this.n_sCondition3;
            }
            set{
                this.n_sCondition3=value;
            }
        }
        #endregion condition3
        
        
        protected string n_sCondition5=global::System.String.Empty;
        #region condition5
        [System.Data.Linq.Mapping.Column(Name="[condition5]", Storage="n_sCondition5")]
        public string condition5{
            get{
                return this.n_sCondition5;
            }
            set{
                this.n_sCondition5=value;
            }
        }
        #endregion condition5
        
        
        protected string n_sHkid=global::System.String.Empty;
        #region hkid
        [System.Data.Linq.Mapping.Column(Name="[hkid]", Storage="n_sHkid")]
        public string hkid{
            get{
                return this.n_sHkid;
            }
            set{
                this.n_sHkid=value;
            }
        }
        #endregion hkid
        
        
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
        
        
        protected global::System.Nullable<int> n_iCount=null;
        #region count
        [System.Data.Linq.Mapping.Column(Name="[count]", Storage="n_iCount")]
        public global::System.Nullable<int> count{
            get{
                return this.n_iCount;
            }
            set{
                this.n_iCount=value;
            }
        }
        #endregion count
        
        
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
        
        
        protected string n_sCondition2=global::System.String.Empty;
        #region condition2
        [System.Data.Linq.Mapping.Column(Name="[condition2]", Storage="n_sCondition2")]
        public string condition2{
            get{
                return this.n_sCondition2;
            }
            set{
                this.n_sCondition2=value;
            }
        }
        #endregion condition2
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private SpecialCustomerInfo n_oTableSet = SpecialCustomerInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string id="id";
            public const string cdate="cdate";
            public const string cid="cid";
            public const string condition4="condition4";
            public const string status="status";
            public const string active="active";
            public const string condition3="condition3";
            public const string condition5="condition5";
            public const string hkid="hkid";
            public const string condition1="condition1";
            public const string ddate="ddate";
            public const string count="count";
            public const string did="did";
            public const string condition2="condition2";
            public const string SpecialCustomer_table_name="SpecialCustomer";
            public static string TableName() { return SpecialCustomer_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public SpecialCustomerEntity(){
            Init();
        }
        public SpecialCustomerEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public SpecialCustomerEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId){
            n_oDB=x_oDB;
            this.Load(x_iId);
            Init();
        }
        
        ~SpecialCustomerEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iId){
            if (n_oDB==null) { return false; }
            if (x_iId==null) { return false; }
            string _sQuery = "SELECT   [SpecialCustomer].[cid] AS SPECIALCUSTOMER_CID,[SpecialCustomer].[id] AS SPECIALCUSTOMER_ID,[SpecialCustomer].[cdate] AS SPECIALCUSTOMER_CDATE,[SpecialCustomer].[condition1] AS SPECIALCUSTOMER_CONDITION1,[SpecialCustomer].[condition4] AS SPECIALCUSTOMER_CONDITION4,[SpecialCustomer].[status] AS SPECIALCUSTOMER_STATUS,[SpecialCustomer].[active] AS SPECIALCUSTOMER_ACTIVE,[SpecialCustomer].[condition3] AS SPECIALCUSTOMER_CONDITION3,[SpecialCustomer].[condition5] AS SPECIALCUSTOMER_CONDITION5,[SpecialCustomer].[hkid] AS SPECIALCUSTOMER_HKID,[SpecialCustomer].[ddate] AS SPECIALCUSTOMER_DDATE,[SpecialCustomer].[count] AS SPECIALCUSTOMER_COUNT,[SpecialCustomer].[did] AS SPECIALCUSTOMER_DID,[SpecialCustomer].[condition2] AS SPECIALCUSTOMER_CONDITION2  FROM  [SpecialCustomer]  WHERE  [SpecialCustomer].[id] = \'"+x_iId.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[SpecialCustomer]","["+ Configurator.MSSQLTablePrefix + "SpecialCustomer]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_CID"])) {n_sCid = (string)_oData["SPECIALCUSTOMER_CID"];}else{n_sCid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_ID"])) {n_iId = (global::System.Nullable<int>)_oData["SPECIALCUSTOMER_ID"];}else{n_iId=null;}
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_CDATE"])) {n_dCdate = (global::System.Nullable<DateTime>)_oData["SPECIALCUSTOMER_CDATE"];}else{n_dCdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_CONDITION1"])) {n_sCondition1 = (string)_oData["SPECIALCUSTOMER_CONDITION1"];}else{n_sCondition1=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_CONDITION4"])) {n_sCondition4 = (string)_oData["SPECIALCUSTOMER_CONDITION4"];}else{n_sCondition4=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_STATUS"])) {n_sStatus = (string)_oData["SPECIALCUSTOMER_STATUS"];}else{n_sStatus=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["SPECIALCUSTOMER_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_CONDITION3"])) {n_sCondition3 = (string)_oData["SPECIALCUSTOMER_CONDITION3"];}else{n_sCondition3=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_CONDITION5"])) {n_sCondition5 = (string)_oData["SPECIALCUSTOMER_CONDITION5"];}else{n_sCondition5=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_HKID"])) {n_sHkid = (string)_oData["SPECIALCUSTOMER_HKID"];}else{n_sHkid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_DDATE"])) {n_dDdate = (global::System.Nullable<DateTime>)_oData["SPECIALCUSTOMER_DDATE"];}else{n_dDdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_COUNT"])) {n_iCount = (global::System.Nullable<int>)_oData["SPECIALCUSTOMER_COUNT"];}else{n_iCount=null;}
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_DID"])) {n_sDid = (string)_oData["SPECIALCUSTOMER_DID"];}else{n_sDid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_CONDITION2"])) {n_sCondition2 = (string)_oData["SPECIALCUSTOMER_CONDITION2"];}else{n_sCondition2=global::System.String.Empty;}
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
            if (n_sCondition1==null && !(n_oTableSet.Fields(Para.condition1).IsNullable)) return false;
            if (n_sCondition4==null && !(n_oTableSet.Fields(Para.condition4).IsNullable)) return false;
            if (n_sStatus==null && !(n_oTableSet.Fields(Para.status).IsNullable)) return false;
            if (n_bActive==null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_sCondition3==null && !(n_oTableSet.Fields(Para.condition3).IsNullable)) return false;
            if (n_sCondition5==null && !(n_oTableSet.Fields(Para.condition5).IsNullable)) return false;
            if (n_sHkid==null && !(n_oTableSet.Fields(Para.hkid).IsNullable)) return false;
            if (n_dDdate==null && !(n_oTableSet.Fields(Para.ddate).IsNullable)) return false;
            if (n_iCount==null && !(n_oTableSet.Fields(Para.count).IsNullable)) return false;
            if (n_sDid==null && !(n_oTableSet.Fields(Para.did).IsNullable)) return false;
            if (n_sCondition2==null && !(n_oTableSet.Fields(Para.condition2).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(SpecialCustomerEntity)) || (x_oObj is SpecialCustomerEntity)) return SpecialCustomerRepository.Instance();
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
        public SpecialCustomerInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(SpecialCustomerInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public global::System.Nullable<int> GetId(){return this.id;}
        public global::System.Nullable<DateTime> GetCdate(){return this.cdate;}
        public string GetCid(){return this.cid;}
        public string GetCondition4(){return this.condition4;}
        public string GetStatus(){return this.status;}
        public global::System.Nullable<bool> GetActive(){return this.active;}
        public string GetCondition3(){return this.condition3;}
        public string GetCondition5(){return this.condition5;}
        public string GetHkid(){return this.hkid;}
        public string GetCondition1(){return this.condition1;}
        public global::System.Nullable<DateTime> GetDdate(){return this.ddate;}
        public global::System.Nullable<int> GetCount(){return this.count;}
        public string GetDid(){return this.did;}
        public string GetCondition2(){return this.condition2;}
        
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
        public bool SetCondition4(string value){
            this.condition4=value;
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
        public bool SetCondition3(string value){
            this.condition3=value;
            return true;
        }
        public bool SetCondition5(string value){
            this.condition5=value;
            return true;
        }
        public bool SetHkid(string value){
            this.hkid=value;
            return true;
        }
        public bool SetCondition1(string value){
            this.condition1=value;
            return true;
        }
        public bool SetDdate(global::System.Nullable<DateTime> value){
            this.ddate=value;
            return true;
        }
        public bool SetCount(global::System.Nullable<int> value){
            this.count=value;
            return true;
        }
        public bool SetDid(string value){
            this.did=value;
            return true;
        }
        public bool SetCondition2(string value){
            this.condition2=value;
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
        public Field GetCondition4Table(){
            return n_oTableSet.Fields(Para.condition4);
        }
        public Field GetStatusTable(){
            return n_oTableSet.Fields(Para.status);
        }
        public Field GetActiveTable(){
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetCondition3Table(){
            return n_oTableSet.Fields(Para.condition3);
        }
        public Field GetCondition5Table(){
            return n_oTableSet.Fields(Para.condition5);
        }
        public Field GetHkidTable(){
            return n_oTableSet.Fields(Para.hkid);
        }
        public Field GetCondition1Table(){
            return n_oTableSet.Fields(Para.condition1);
        }
        public Field GetDdateTable(){
            return n_oTableSet.Fields(Para.ddate);
        }
        public Field GetCountTable(){
            return n_oTableSet.Fields(Para.count);
        }
        public Field GetDidTable(){
            return n_oTableSet.Fields(Para.did);
        }
        public Field GetCondition2Table(){
            return n_oTableSet.Fields(Para.condition2);
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
        
        public bool EqualID(SpecialCustomer x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(SpecialCustomer x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_sCid.Equals(x_oObj.cid)){ return false; }
            if(!this.n_iId.Equals(x_oObj.id)){ return false; }
            if(!this.n_dCdate.Equals(x_oObj.cdate)){ return false; }
            if(!this.n_sCondition1.Equals(x_oObj.condition1)){ return false; }
            if(!this.n_sCondition4.Equals(x_oObj.condition4)){ return false; }
            if(!this.n_sStatus.Equals(x_oObj.status)){ return false; }
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_sCondition3.Equals(x_oObj.condition3)){ return false; }
            if(!this.n_sCondition5.Equals(x_oObj.condition5)){ return false; }
            if(!this.n_sHkid.Equals(x_oObj.hkid)){ return false; }
            if(!this.n_dDdate.Equals(x_oObj.ddate)){ return false; }
            if(!this.n_iCount.Equals(x_oObj.count)){ return false; }
            if(!this.n_sDid.Equals(x_oObj.did)){ return false; }
            if(!this.n_sCondition2.Equals(x_oObj.condition2)){ return false; }
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
            string _sQuery = "UPDATE  [SpecialCustomer]  SET  [cid]=@cid,[cdate]=@cdate,[condition1]=@condition1,[condition4]=@condition4,[status]=@status,[active]=@active,[condition3]=@condition3,[condition5]=@condition5,[hkid]=@hkid,[ddate]=@ddate,[count]=@count,[did]=@did,[condition2]=@condition2  WHERE [SpecialCustomer].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[SpecialCustomer]","["+ Configurator.MSSQLTablePrefix + "SpecialCustomer]"); }
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
            if(n_sCid==null){  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=n_sCid; }
            if(n_iId==null){  _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value=n_iId; }
            if(n_dCdate==null){  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=n_dCdate; }
            if(n_sCondition1==null){  _oCmd.Parameters.Add("@condition1", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@condition1", global::System.Data.SqlDbType.NVarChar,50).Value=n_sCondition1; }
            if(n_sCondition4==null){  _oCmd.Parameters.Add("@condition4", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@condition4", global::System.Data.SqlDbType.NVarChar,50).Value=n_sCondition4; }
            if(n_sStatus==null){  _oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NVarChar,50).Value=n_sStatus; }
            if(n_bActive==null){  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=n_bActive; }
            if(n_sCondition3==null){  _oCmd.Parameters.Add("@condition3", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@condition3", global::System.Data.SqlDbType.NVarChar,50).Value=n_sCondition3; }
            if(n_sCondition5==null){  _oCmd.Parameters.Add("@condition5", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@condition5", global::System.Data.SqlDbType.NVarChar,50).Value=n_sCondition5; }
            if(n_sHkid==null){  _oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,50).Value=n_sHkid; }
            if(n_dDdate==null){  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=n_dDdate; }
            if(n_iCount==null){  _oCmd.Parameters.Add("@count", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@count", global::System.Data.SqlDbType.Int).Value=n_iCount; }
            if(n_sDid==null){  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value=n_sDid; }
            if(n_sCondition2==null){  _oCmd.Parameters.Add("@condition2", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@condition2", global::System.Data.SqlDbType.NVarChar,50).Value=n_sCondition2; }
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
        /// Summary description for table [SpecialCustomer] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iId==null) { return false; }
            string _sQuery="DELETE FROM  [SpecialCustomer]  WHERE [SpecialCustomer].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[SpecialCustomer]","["+ Configurator.MSSQLTablePrefix + "SpecialCustomer]"); }
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
        /// Summary description for table [SpecialCustomer] Object Base Clone
        /// </summary>
        
        public SpecialCustomer DeepClone()
        {
            SpecialCustomer _oSpecialCustomer_Clone = new SpecialCustomer();
            _oSpecialCustomer_Clone.cid = this.n_sCid;
            _oSpecialCustomer_Clone.id = this.n_iId;
            _oSpecialCustomer_Clone.cdate = this.n_dCdate;
            _oSpecialCustomer_Clone.condition1 = this.n_sCondition1;
            _oSpecialCustomer_Clone.condition4 = this.n_sCondition4;
            _oSpecialCustomer_Clone.status = this.n_sStatus;
            _oSpecialCustomer_Clone.active = this.n_bActive;
            _oSpecialCustomer_Clone.condition3 = this.n_sCondition3;
            _oSpecialCustomer_Clone.condition5 = this.n_sCondition5;
            _oSpecialCustomer_Clone.hkid = this.n_sHkid;
            _oSpecialCustomer_Clone.ddate = this.n_dDdate;
            _oSpecialCustomer_Clone.count = this.n_iCount;
            _oSpecialCustomer_Clone.did = this.n_sDid;
            _oSpecialCustomer_Clone.condition2 = this.n_sCondition2;
            _oSpecialCustomer_Clone.SetFound(this.n_bFound);
            _oSpecialCustomer_Clone.SetDB(this.n_oDB);
            _oSpecialCustomer_Clone.SetRow(this.n_oRow);
            _oSpecialCustomer_Clone.SetTbl(this.n_oTbl);
            _oSpecialCustomer_Clone.SetTableSet(this.n_oTableSet);
            
            return _oSpecialCustomer_Clone;
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
            n_sCondition1=global::System.String.Empty;
            n_sCondition4=global::System.String.Empty;
            n_sStatus=global::System.String.Empty;
            n_bActive=null;
            n_sCondition3=global::System.String.Empty;
            n_sCondition5=global::System.String.Empty;
            n_sHkid=global::System.String.Empty;
            n_dDdate=null;
            n_iCount=null;
            n_sDid=global::System.String.Empty;
            n_sCondition2=global::System.String.Empty;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = SpecialCustomerInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


