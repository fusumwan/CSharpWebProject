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
///-- Create date: <Create Date 2011-09-15>
///-- Description:	<Description,Table :[CallListUploadMrtNo],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [CallListUploadMrtNo] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"CallListUploadMrtNo")]
    public class CallListUploadMrtNoEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        
        protected global::System.Nullable<long> n_lCall_list_program_id=null;
        #region call_list_program_id
        [System.Data.Linq.Mapping.Column(Name="[call_list_program_id]", Storage="n_lCall_list_program_id")]
        public global::System.Nullable<long> call_list_program_id{
            get{
                return this.n_lCall_list_program_id;
            }
            set{
                this.n_lCall_list_program_id=value;
            }
        }
        #endregion call_list_program_id
        
        
        protected global::System.Nullable<long> n_lId=null;
        #region id
        [System.Data.Linq.Mapping.Column(Name="[id]", Storage="n_lId")]
        public global::System.Nullable<long> id{
            get{
                return this.n_lId;
            }
            set{
                this.n_lId=value;
            }
        }
        #endregion id
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private CallListUploadMrtNoInfo n_oTableSet = CallListUploadMrtNoInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string cdate="cdate";
            public const string mrt_no="mrt_no";
            public const string call_list_program_id="call_list_program_id";
            public const string id="id";
            public const string CallListUploadMrtNo_table_name="CallListUploadMrtNo";
            public static string TableName() { return CallListUploadMrtNo_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public CallListUploadMrtNoEntity(){
            Init();
        }
        public CallListUploadMrtNoEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public CallListUploadMrtNoEntity(MSSQLConnect x_oDB,global::System.Nullable<long> x_lId){
            n_oDB=x_oDB;
            this.Load(x_lId);
            Init();
        }
        
        ~CallListUploadMrtNoEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<long> x_lId){
            if (n_oDB==null) { return false; }
            if (x_lId==null) { return false; }
            string _sQuery = "SELECT   [CallListUploadMrtNo].[cdate] AS CALLLISTUPLOADMRTNO_CDATE,[CallListUploadMrtNo].[mrt_no] AS CALLLISTUPLOADMRTNO_MRT_NO,[CallListUploadMrtNo].[call_list_program_id] AS CALLLISTUPLOADMRTNO_CALL_LIST_PROGRAM_ID,[CallListUploadMrtNo].[id] AS CALLLISTUPLOADMRTNO_ID  FROM  [CallListUploadMrtNo]  WHERE  [CallListUploadMrtNo].[id] = \'"+x_lId.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[CallListUploadMrtNo]","["+ Configurator.MSSQLTablePrefix + "CallListUploadMrtNo]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADMRTNO_CDATE"])) {n_dCdate = (global::System.Nullable<DateTime>)_oData["CALLLISTUPLOADMRTNO_CDATE"];}else{n_dCdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADMRTNO_MRT_NO"])) {n_sMrt_no = (string)_oData["CALLLISTUPLOADMRTNO_MRT_NO"];}else{n_sMrt_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADMRTNO_CALL_LIST_PROGRAM_ID"])) {n_lCall_list_program_id = (global::System.Nullable<long>)_oData["CALLLISTUPLOADMRTNO_CALL_LIST_PROGRAM_ID"];}else{n_lCall_list_program_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADMRTNO_ID"])) {n_lId = (global::System.Nullable<long>)_oData["CALLLISTUPLOADMRTNO_ID"];}else{n_lId=null;}
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
            if (n_sMrt_no==null && !(n_oTableSet.Fields(Para.mrt_no).IsNullable)) return false;
            if (n_lCall_list_program_id==null && !(n_oTableSet.Fields(Para.call_list_program_id).IsNullable)) return false;
            if(!x_bInsert){
                if (n_lId==null && !(n_oTableSet.Fields(Para.id).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(CallListUploadMrtNoEntity)) || (x_oObj is CallListUploadMrtNoEntity)) return CallListUploadMrtNoRepository.Instance();
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
        public CallListUploadMrtNoInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(CallListUploadMrtNoInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public global::System.Nullable<DateTime> GetCdate(){return this.cdate;}
        public string GetMrt_no(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.mrt_no)) { return string.Empty; }
            return this.mrt_no;
        }
        public global::System.Nullable<long> GetCall_list_program_id(){return this.call_list_program_id;}
        public global::System.Nullable<long> GetId(){return this.id;}
        
        public bool SetCdate(global::System.Nullable<DateTime> value){
            this.cdate=value;
            return true;
        }
        public bool SetMrt_no(string value){
            this.mrt_no=value;
            return true;
        }
        public bool SetCall_list_program_id(global::System.Nullable<long> value){
            this.call_list_program_id=value;
            return true;
        }
        public bool SetId(global::System.Nullable<long> value){
            this.id=value;
            return true;
        }
        
        public Field GetCdateTable(){
            return n_oTableSet.Fields(Para.cdate);
        }
        public Field GetMrt_noTable(){
            return n_oTableSet.Fields(Para.mrt_no);
        }
        public Field GetCall_list_program_idTable(){
            return n_oTableSet.Fields(Para.call_list_program_id);
        }
        public Field GetIdTable(){
            return n_oTableSet.Fields(Para.id);
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
        
        public bool EqualID(CallListUploadMrtNo x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_lId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(CallListUploadMrtNo x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_dCdate.Equals(x_oObj.cdate)){ return false; }
            if(!this.n_sMrt_no.Equals(x_oObj.mrt_no)){ return false; }
            if(!this.n_lCall_list_program_id.Equals(x_oObj.call_list_program_id)){ return false; }
            if(!this.n_lId.Equals(x_oObj.id)){ return false; }
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
            if(!n_lId.Equals(null)){
                _bResult=this.Load(n_lId);
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
            if (n_lId==null) { return false; }
            if(!Vaild(false)){ return false; }
            string _sQuery = "UPDATE  [CallListUploadMrtNo]  SET  [cdate]=@cdate,[mrt_no]=@mrt_no,[call_list_program_id]=@call_list_program_id  WHERE [CallListUploadMrtNo].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[CallListUploadMrtNo]","["+ Configurator.MSSQLTablePrefix + "CallListUploadMrtNo]"); }
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
            if(n_sMrt_no==null){  _oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.NVarChar,50).Value=n_sMrt_no; }
            if(n_lCall_list_program_id==null){  _oCmd.Parameters.Add("@call_list_program_id", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@call_list_program_id", global::System.Data.SqlDbType.BigInt).Value=n_lCall_list_program_id; }
            if(n_lId==null){  _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.BigInt).Value=n_lId; }
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
        /// Summary description for table [CallListUploadMrtNo] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_lId==null) { return false; }
            string _sQuery="DELETE FROM  [CallListUploadMrtNo]  WHERE [CallListUploadMrtNo].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[CallListUploadMrtNo]","["+ Configurator.MSSQLTablePrefix + "CallListUploadMrtNo]"); }
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
            _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.BigInt).Value = n_lId;
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
        /// Summary description for table [CallListUploadMrtNo] Object Base Clone
        /// </summary>
        
        public CallListUploadMrtNo DeepClone()
        {
            CallListUploadMrtNo _oCallListUploadMrtNo_Clone = new CallListUploadMrtNo();
            _oCallListUploadMrtNo_Clone.cdate = this.n_dCdate;
            _oCallListUploadMrtNo_Clone.mrt_no = this.n_sMrt_no;
            _oCallListUploadMrtNo_Clone.call_list_program_id = this.n_lCall_list_program_id;
            _oCallListUploadMrtNo_Clone.id = this.n_lId;
            _oCallListUploadMrtNo_Clone.SetFound(this.n_bFound);
            _oCallListUploadMrtNo_Clone.SetDB(this.n_oDB);
            _oCallListUploadMrtNo_Clone.SetRow(this.n_oRow);
            _oCallListUploadMrtNo_Clone.SetTbl(this.n_oTbl);
            _oCallListUploadMrtNo_Clone.SetTableSet(this.n_oTableSet);
            
            return _oCallListUploadMrtNo_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_dCdate=null;
            n_sMrt_no=global::System.String.Empty;
            n_lCall_list_program_id=null;
            n_lId=null;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = CallListUploadMrtNoInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


