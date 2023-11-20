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
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Xml;

using NEURON.ENTITY.FRAMEWORK;

using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-03-08>
///-- Description:	<Description,Table :[crm_cust_num],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [crm_cust_num] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = "crm_cust_num")]
    public class Crm_cust_numBase{
        
        
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
        
        
        protected string n_sCid=string.Empty;
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
        
        
        protected string n_sDid=string.Empty;
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
        
        
        protected string n_sCust_num=string.Empty;
        #region cust_num
        [System.Data.Linq.Mapping.Column(Name="[cust_num]", Storage="n_sCust_num")]
        public string cust_num{
            get{
                return this.n_sCust_num;
            }
            set{
                this.n_sCust_num=value;
            }
        }
        #endregion cust_num
        
        
        protected global::System.Nullable<int> n_iCust_id=null;
        #region cust_id
        [System.Data.Linq.Mapping.Column(Name="[cust_id]", Storage="n_iCust_id")]
        public global::System.Nullable<int> cust_id{
            get{
                return this.n_iCust_id;
            }
            set{
                this.n_iCust_id=value;
            }
        }
        #endregion cust_id
        
        
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
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private global::System.Data.DataTable n_oTbl = null;
        private global::System.Data.DataRow n_oRow = null;
        private Crm_cust_numInfo n_oTableSet = new Crm_cust_numInfo();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string active="active";
            public const string cdate="cdate";
            public const string cid="cid";
            public const string did="did";
            public const string cust_num="cust_num";
            public const string cust_id="cust_id";
            public const string order_id="order_id";
            public const string ddate="ddate";
            public const string Crm_cust_num_table_name = Configurator.MSSQLTablePrefix + "crm_cust_num";
            public static string TableName() { return Crm_cust_num_table_name; }
        }
        #endregion Parameter String
        #region Constructor
        
        public Crm_cust_numBase(){
            Init();
        }
        public Crm_cust_numBase(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public Crm_cust_numBase(MSSQLConnect x_oDB,System.Nullable<bool> x_bActive,System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sCust_num,System.Nullable<int> x_iCust_id,System.Nullable<int> x_iOrder_id,System.Nullable<DateTime> x_dDdate){
            n_oDB=x_oDB;
            this.Load(x_bActive,x_dCdate,x_sCid,x_sDid,x_sCust_num,x_iCust_id,x_iOrder_id,x_dDdate);
            Init();
        }
        
        ~Crm_cust_numBase(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<bool> x_bActive,System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sCust_num,System.Nullable<int> x_iCust_id,System.Nullable<int> x_iOrder_id,System.Nullable<DateTime> x_dDdate){
            if (n_oDB == null) { return false; }
            if (x_bActive==null) { return false; }
            if (x_dCdate==null) { return false; }
            if (string.IsNullOrEmpty(x_sCid)) { return false; }
            if (string.IsNullOrEmpty(x_sDid)) { return false; }
            if (string.IsNullOrEmpty(x_sCust_num)) { return false; }
            if (x_iCust_id==null) { return false; }
            if (x_iOrder_id==null) { return false; }
            if (x_dDdate==null) { return false; }
            string _sQuery = "SELECT [crm_cust_num].[active] AS CRM_CUST_NUM_ACTIVE,[crm_cust_num].[cdate] AS CRM_CUST_NUM_CDATE,[crm_cust_num].[cid] AS CRM_CUST_NUM_CID,[crm_cust_num].[did] AS CRM_CUST_NUM_DID,[crm_cust_num].[cust_num] AS CRM_CUST_NUM_CUST_NUM,[crm_cust_num].[cust_id] AS CRM_CUST_NUM_CUST_ID,[crm_cust_num].[order_id] AS CRM_CUST_NUM_ORDER_ID,[crm_cust_num].[ddate] AS CRM_CUST_NUM_DDATE  FROM  [crm_cust_num]  WHERE  [crm_cust_num].[active] = \'"+x_bActive.ToString()+"\'  AND  [crm_cust_num].[cdate] = \'"+x_dCdate.ToString()+"\'  AND  [crm_cust_num].[cid] = \'"+x_sCid.ToString()+"\'  AND  [crm_cust_num].[did] = \'"+x_sDid.ToString()+"\'  AND  [crm_cust_num].[cust_num] = \'"+x_sCust_num.ToString()+"\'  AND  [crm_cust_num].[cust_id] = \'"+x_iCust_id.ToString()+"\'  AND  [crm_cust_num].[order_id] = \'"+x_iOrder_id.ToString()+"\'  AND  [crm_cust_num].[ddate] = \'"+x_dDdate.ToString()+"\'";
            global::System.Data.SqlClient.SqlConnection _oConn = n_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            global::System.Data.SqlClient.SqlDataReader _oData;
            try
            {
                _oConn.Open();
                _oData = _oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    n_bFound = true;
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUST_NUM_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["CRM_CUST_NUM_ACTIVE"];}else{ n_bActive=null;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUST_NUM_CDATE"])) {n_dCdate = (global::System.Nullable<DateTime>)_oData["CRM_CUST_NUM_CDATE"];}else{ n_dCdate=null;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUST_NUM_CID"])) {n_sCid = (string)_oData["CRM_CUST_NUM_CID"];}else{ n_sCid=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUST_NUM_DID"])) {n_sDid = (string)_oData["CRM_CUST_NUM_DID"];}else{ n_sDid=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUST_NUM_CUST_NUM"])) {n_sCust_num = (string)_oData["CRM_CUST_NUM_CUST_NUM"];}else{ n_sCust_num=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUST_NUM_CUST_ID"])) {n_iCust_id = (global::System.Nullable<int>)_oData["CRM_CUST_NUM_CUST_ID"];}else{ n_iCust_id=null;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUST_NUM_ORDER_ID"])) {n_iOrder_id = (global::System.Nullable<int>)_oData["CRM_CUST_NUM_ORDER_ID"];}else{ n_iOrder_id=null;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUST_NUM_DDATE"])) {n_dDdate = (global::System.Nullable<DateTime>)_oData["CRM_CUST_NUM_DDATE"];}else{ n_dDdate=null;}
                }
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
            if (string.IsNullOrEmpty(n_sCid) && !(n_oTableSet.Fields(Para.cid).IsNullable)) return false;
            if (string.IsNullOrEmpty(n_sDid) && !(n_oTableSet.Fields(Para.did).IsNullable)) return false;
            if (string.IsNullOrEmpty(n_sCust_num) && !(n_oTableSet.Fields(Para.cust_num).IsNullable)) return false;
            if (n_iCust_id==null && !(n_oTableSet.Fields(Para.cust_id).IsNullable)) return false;
            if(!x_bInsert){
                if (n_iOrder_id==null && !(n_oTableSet.Fields(Para.order_id).IsNullable)) return false;
            }
            if (n_dDdate==null && !(n_oTableSet.Fields(Para.ddate).IsNullable)) return false;
            return true;
        }
        #endregion
        
        #region Get & Set
        
        /// <summary>
        /// Summary description for Get & Set this all class parameters
        /// </summary>
        public object GetManagerObject(object x_oObj)
        {
            if (x_oObj is Crm_cust_num) return Crm_cust_numManager.Instance();
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
        public global::System.Data.DataTable GetTbl(){ return n_oTbl; }
        #endregion GetTbl
        
        
        #region SetTbl
        public void SetTbl(DataTable value){  n_oTbl=value; }
        #endregion SetTbl
        
        
        #region GetRow
        public global::System.Data.DataRow GetRow(){ return n_oRow; }
        #endregion GetRow
        
        
        #region SetRow
        public void SetRow(global::System.Data.DataRow value){  n_oRow=value; }
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
        public Crm_cust_numInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(Crm_cust_numInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public global::System.Nullable<bool> GetActive(){return this.active;}
        public global::System.Nullable<DateTime> GetCdate(){return this.cdate;}
        public string GetCid(){return this.cid;}
        public string GetDid(){return this.did;}
        public string GetCust_num(){return this.cust_num;}
        public global::System.Nullable<int> GetCust_id(){return this.cust_id;}
        public global::System.Nullable<int> GetOrder_id(){return this.order_id;}
        public global::System.Nullable<DateTime> GetDdate(){return this.ddate;}
        
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
        public bool SetCust_num(string value){
            this.cust_num=value;
            return true;
        }
        public bool SetCust_id(global::System.Nullable<int> value){
            this.cust_id=value;
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
        public Field GetCust_numTable(){
            return n_oTableSet.Fields(Para.cust_num);
        }
        public Field GetCust_idTable(){
            return n_oTableSet.Fields(Para.cust_id);
        }
        public Field GetOrder_idTable(){
            return n_oTableSet.Fields(Para.order_id);
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
        
        #region Retrieve
        
        /// <summary>
        /// Summary description for Retrieve
        /// </summary>
        
        #endregion
        
        #region Save
        
        /// <summary>
        /// Summary description for Save
        /// </summary>
        
        public bool Save()
        {
            if(n_oDB==null){ return false;}
            if(!Vaild(false)){ return false; }
            string _sQuery = "UPDATE  [crm_cust_num]  SET  [active]=@active,[cdate]=@cdate,[cid]=@cid,[did]=@did,[cust_num]=@cust_num,[cust_id]=@cust_id,[ddate]=@ddate ";
           
            global::System.Data.SqlClient.SqlConnection _oConn = n_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            bool _bResult=false;
            if(n_bActive==null){  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=n_bActive; }
            if(n_dCdate==null){  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=n_dCdate; }
            if(string.IsNullOrEmpty(n_sCid)){  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.VarChar,50).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.VarChar,50).Value=n_sCid; }
            if(string.IsNullOrEmpty(n_sDid)){  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.VarChar,50).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.VarChar,50).Value=n_sDid; }
            if(string.IsNullOrEmpty(n_sCust_num)){  _oCmd.Parameters.Add("@cust_num", global::System.Data.SqlDbType.VarChar,10).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@cust_num", global::System.Data.SqlDbType.VarChar,10).Value=n_sCust_num; }
            if(n_iCust_id==null){  _oCmd.Parameters.Add("@cust_id", global::System.Data.SqlDbType.Int).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@cust_id", global::System.Data.SqlDbType.Int).Value=n_iCust_id; }
            if(n_dDdate==null){  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=n_dDdate; }
            
            try
            {
                _oConn.Open();
                _bResult = global::System.Convert.ToBoolean(_oCmd.ExecuteNonQuery());
            }
            catch {  }
            finally
            {
                _oConn.Close();
                _oCmd.Dispose();
                _oConn.Dispose();
            }
            return _bResult;
        }
        #endregion
        
        #region DeepClone
        
        /// <summary>
        /// Summary description for table [crm_cust_num] Object Base Clone
        /// </summary>
        
        public Crm_cust_num DeepClone()
        {
            Crm_cust_num _oCrm_cust_num_Clone = new Crm_cust_num();
            _oCrm_cust_num_Clone.active = this.n_bActive;
            _oCrm_cust_num_Clone.cdate = this.n_dCdate;
            _oCrm_cust_num_Clone.cid = this.n_sCid;
            _oCrm_cust_num_Clone.did = this.n_sDid;
            _oCrm_cust_num_Clone.cust_num = this.n_sCust_num;
            _oCrm_cust_num_Clone.cust_id = this.n_iCust_id;
            _oCrm_cust_num_Clone.order_id = this.n_iOrder_id;
            _oCrm_cust_num_Clone.ddate = this.n_dDdate;
            _oCrm_cust_num_Clone.SetFound(this.n_bFound);
            _oCrm_cust_num_Clone.SetDB(this.n_oDB);
            _oCrm_cust_num_Clone.SetRow(this.n_oRow);
            _oCrm_cust_num_Clone.SetTbl(this.n_oTbl);
            _oCrm_cust_num_Clone.SetTableSet(this.n_oTableSet);
            
            return _oCrm_cust_num_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_bActive=null;
            n_dCdate=null;
            n_sCid=string.Empty;
            n_sDid=string.Empty;
            n_sCust_num=string.Empty;
            n_iCust_id=null;
            n_iOrder_id=null;
            n_dDdate=null;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = new Crm_cust_numInfo();
        }
        #endregion
    }
}


