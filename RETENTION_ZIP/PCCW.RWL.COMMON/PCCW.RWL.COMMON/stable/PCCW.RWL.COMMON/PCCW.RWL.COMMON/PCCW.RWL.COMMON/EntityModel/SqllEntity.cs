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
///-- Create date: <Create Date 2010-09-17>
///-- Description:	<Description,Table :[sqll],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [sqll] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"sqll")]
    public class SqllEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        
        protected string n_sTxt=global::System.String.Empty;
        #region txt
        [System.Data.Linq.Mapping.Column(Name="[txt]", Storage="n_sTxt")]
        public string txt{
            get{
                return this.n_sTxt;
            }
            set{
                this.n_sTxt=value;
            }
        }
        #endregion txt
        
        
        protected string n_sIp=global::System.String.Empty;
        #region ip
        [System.Data.Linq.Mapping.Column(Name="[ip]", Storage="n_sIp")]
        public string ip{
            get{
                return this.n_sIp;
            }
            set{
                this.n_sIp=value;
            }
        }
        #endregion ip
        
        
        protected global::System.Nullable<int> n_iIdx=null;
        #region idx
        [System.Data.Linq.Mapping.Column(Name="[idx]", Storage="n_iIdx")]
        public global::System.Nullable<int> idx{
            get{
                return this.n_iIdx;
            }
            set{
                this.n_iIdx=value;
            }
        }
        #endregion idx
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private SqllInfo n_oTableSet = SqllInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string cdate="cdate";
            public const string txt="txt";
            public const string ip="ip";
            public const string idx="idx";
            public const string Sqll_table_name="sqll";
            public static string TableName() { return Sqll_table_name; }
        }
        #endregion Parameter String
        #region Constructor
        
        public SqllEntity(){
            Init();
        }
        public SqllEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public SqllEntity(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sTxt,string x_sIp,global::System.Nullable<int> x_iIdx){
            n_oDB=x_oDB;
            this.Load(x_dCdate,x_sTxt,x_sIp,x_iIdx);
            Init();
        }
        
        ~SqllEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<DateTime> x_dCdate,string x_sTxt,string x_sIp,global::System.Nullable<int> x_iIdx){
            if (n_oDB == null) { return false; }
            if (x_dCdate==null) { return false; }
            if (x_sTxt==null) { return false; }
            if (x_sIp==null) { return false; }
            if (x_iIdx==null) { return false; }
            string _sQuery = "SELECT   [sqll].[cdate] AS SQLL_CDATE,[sqll].[txt] AS SQLL_TXT,[sqll].[ip] AS SQLL_IP,[sqll].[idx] AS SQLL_IDX  FROM  [sqll]  WHERE  [sqll].[cdate] = \'"+x_dCdate.ToString()+"\'  AND  [sqll].[txt] = \'"+x_sTxt.ToString()+"\'  AND  [sqll].[ip] = \'"+x_sIp.ToString()+"\'  AND  [sqll].[idx] = \'"+x_iIdx.ToString()+"\'";
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
                        if (!global::System.Convert.IsDBNull(_oData["SQLL_CDATE"])) {n_dCdate = (global::System.Nullable<DateTime>)_oData["SQLL_CDATE"];}else{ n_dCdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["SQLL_TXT"])) {n_sTxt = (string)_oData["SQLL_TXT"];}else{ n_sTxt=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["SQLL_IP"])) {n_sIp = (string)_oData["SQLL_IP"];}else{ n_sIp=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["SQLL_IDX"])) {n_iIdx = (global::System.Nullable<int>)_oData["SQLL_IDX"];}else{ n_iIdx=null;}
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
            if (n_dCdate==null && !(n_oTableSet.Fields(Para.cdate).IsNullable)) return false;
            if (n_sTxt==null && !(n_oTableSet.Fields(Para.txt).IsNullable)) return false;
            if (n_sIp==null && !(n_oTableSet.Fields(Para.ip).IsNullable)) return false;
            if(!x_bInsert){
                if (n_iIdx==null && !(n_oTableSet.Fields(Para.idx).IsNullable)) return false;
            }
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
            if (x_oObj.GetType().IsSubclassOf(typeof(SqllEntity)) || (x_oObj is SqllEntity)) return SqllRepository.Instance();
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
        public SqllInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(SqllInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public global::System.Nullable<DateTime> GetCdate(){return this.cdate;}
        public string GetTxt(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.txt)) { return string.Empty; }
            return this.txt;
        }
        public string GetIp(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.ip)) { return string.Empty; }
            return this.ip;
        }
        public global::System.Nullable<int> GetIdx(){return this.idx;}
        
        public bool SetCdate(global::System.Nullable<DateTime> value){
            this.cdate=value;
            return true;
        }
        public bool SetTxt(string value){
            this.txt=value;
            return true;
        }
        public bool SetIp(string value){
            this.ip=value;
            return true;
        }
        public bool SetIdx(global::System.Nullable<int> value){
            this.idx=value;
            return true;
        }
        
        public Field GetCdateTable(){
            return n_oTableSet.Fields(Para.cdate);
        }
        public Field GetTxtTable(){
            return n_oTableSet.Fields(Para.txt);
        }
        public Field GetIpTable(){
            return n_oTableSet.Fields(Para.ip);
        }
        public Field GetIdxTable(){
            return n_oTableSet.Fields(Para.idx);
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
            string _sQuery = "UPDATE  [sqll]  SET  [cdate]=@cdate,[txt]=@txt,[ip]=@ip ";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[sqll]","["+ Configurator.MSSQLTablePrefix + "sqll]"); }
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
            if(n_dCdate==null){  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=n_dCdate; }
            if(n_sTxt==null){  _oCmd.Parameters.Add("@txt", global::System.Data.SqlDbType.Text,2147483647).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@txt", global::System.Data.SqlDbType.Text,2147483647).Value=n_sTxt; }
            if(n_sIp==null){  _oCmd.Parameters.Add("@ip", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@ip", global::System.Data.SqlDbType.NVarChar,50).Value=n_sIp; }
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
        public bool Delete()
        {
            return false;
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
        /// Summary description for table [sqll] Object Base Clone
        /// </summary>
        
        public Sqll DeepClone()
        {
            Sqll _oSqll_Clone = new Sqll();
            _oSqll_Clone.cdate = this.n_dCdate;
            _oSqll_Clone.txt = this.n_sTxt;
            _oSqll_Clone.ip = this.n_sIp;
            _oSqll_Clone.idx = this.n_iIdx;
            _oSqll_Clone.SetFound(this.n_bFound);
            _oSqll_Clone.SetDB(this.n_oDB);
            _oSqll_Clone.SetRow(this.n_oRow);
            _oSqll_Clone.SetTbl(this.n_oTbl);
            _oSqll_Clone.SetTableSet(this.n_oTableSet);
            
            return _oSqll_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_dCdate=null;
            n_sTxt=global::System.String.Empty;
            n_sIp=global::System.String.Empty;
            n_iIdx=null;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = SqllInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


