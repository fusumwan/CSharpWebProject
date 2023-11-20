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
///-- Description:	<Description,Table :[OfferAutomation],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [OfferAutomation] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"OfferAutomation")]
    public class OfferAutomationEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        
        protected string n_sOffer_name=global::System.String.Empty;
        #region offer_name
        [System.Data.Linq.Mapping.Column(Name="[offer_name]", Storage="n_sOffer_name")]
        public string offer_name{
            get{
                return this.n_sOffer_name;
            }
            set{
                this.n_sOffer_name=value;
            }
        }
        #endregion offer_name
        
        
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
        
        
        protected global::System.Nullable<int> n_iTrade_field_id=null;
        #region trade_field_id
        [System.Data.Linq.Mapping.Column(Name="[trade_field_id]", Storage="n_iTrade_field_id")]
        public global::System.Nullable<int> trade_field_id{
            get{
                return this.n_iTrade_field_id;
            }
            set{
                this.n_iTrade_field_id=value;
            }
        }
        #endregion trade_field_id
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private OfferAutomationInfo n_oTableSet = OfferAutomationInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string id="id";
            public const string offer_name="offer_name";
            public const string call_list_program_id="call_list_program_id";
            public const string active="active";
            public const string trade_field_id="trade_field_id";
            public const string OfferAutomation_table_name="OfferAutomation";
            public static string TableName() { return OfferAutomation_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public OfferAutomationEntity(){
            Init();
        }
        public OfferAutomationEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public OfferAutomationEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId){
            n_oDB=x_oDB;
            this.Load(x_iId);
            Init();
        }
        
        ~OfferAutomationEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iId){
            if (n_oDB==null) { return false; }
            if (x_iId==null) { return false; }
            string _sQuery = "SELECT   [OfferAutomation].[active] AS OFFERAUTOMATION_ACTIVE,[OfferAutomation].[offer_name] AS OFFERAUTOMATION_OFFER_NAME,[OfferAutomation].[call_list_program_id] AS OFFERAUTOMATION_CALL_LIST_PROGRAM_ID,[OfferAutomation].[id] AS OFFERAUTOMATION_ID,[OfferAutomation].[trade_field_id] AS OFFERAUTOMATION_TRADE_FIELD_ID  FROM  [OfferAutomation]  WHERE  [OfferAutomation].[id] = \'"+x_iId.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[OfferAutomation]","["+ Configurator.MSSQLTablePrefix + "OfferAutomation]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["OFFERAUTOMATION_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["OFFERAUTOMATION_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["OFFERAUTOMATION_OFFER_NAME"])) {n_sOffer_name = (string)_oData["OFFERAUTOMATION_OFFER_NAME"];}else{n_sOffer_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["OFFERAUTOMATION_CALL_LIST_PROGRAM_ID"])) {n_lCall_list_program_id = (global::System.Nullable<long>)_oData["OFFERAUTOMATION_CALL_LIST_PROGRAM_ID"];}else{n_lCall_list_program_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["OFFERAUTOMATION_ID"])) {n_iId = (global::System.Nullable<int>)_oData["OFFERAUTOMATION_ID"];}else{n_iId=null;}
                        if (!global::System.Convert.IsDBNull(_oData["OFFERAUTOMATION_TRADE_FIELD_ID"])) {n_iTrade_field_id = (global::System.Nullable<int>)_oData["OFFERAUTOMATION_TRADE_FIELD_ID"];}else{n_iTrade_field_id=null;}
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
            if (n_sOffer_name==null && !(n_oTableSet.Fields(Para.offer_name).IsNullable)) return false;
            if (n_lCall_list_program_id==null && !(n_oTableSet.Fields(Para.call_list_program_id).IsNullable)) return false;
            if(!x_bInsert){
                if (n_iId==null && !(n_oTableSet.Fields(Para.id).IsNullable)) return false;
            }
            if (n_iTrade_field_id==null && !(n_oTableSet.Fields(Para.trade_field_id).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(OfferAutomationEntity)) || (x_oObj is OfferAutomationEntity)) return OfferAutomationRepository.Instance();
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
        public OfferAutomationInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(OfferAutomationInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public global::System.Nullable<int> GetId(){return this.id;}
        public string GetOffer_name(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.offer_name)) { return string.Empty; }
            return this.offer_name;
        }
        public global::System.Nullable<long> GetCall_list_program_id(){return this.call_list_program_id;}
        public global::System.Nullable<bool> GetActive(){return this.active;}
        public global::System.Nullable<int> GetTrade_field_id(){return this.trade_field_id;}
        
        public bool SetId(global::System.Nullable<int> value){
            this.id=value;
            return true;
        }
        public bool SetOffer_name(string value){
            this.offer_name=value;
            return true;
        }
        public bool SetCall_list_program_id(global::System.Nullable<long> value){
            this.call_list_program_id=value;
            return true;
        }
        public bool SetActive(global::System.Nullable<bool> value){
            this.active=value;
            return true;
        }
        public bool SetTrade_field_id(global::System.Nullable<int> value){
            this.trade_field_id=value;
            return true;
        }
        
        public Field GetIdTable(){
            return n_oTableSet.Fields(Para.id);
        }
        public Field GetOffer_nameTable(){
            return n_oTableSet.Fields(Para.offer_name);
        }
        public Field GetCall_list_program_idTable(){
            return n_oTableSet.Fields(Para.call_list_program_id);
        }
        public Field GetActiveTable(){
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetTrade_field_idTable(){
            return n_oTableSet.Fields(Para.trade_field_id);
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
        
        public bool EqualID(OfferAutomation x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(OfferAutomation x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_sOffer_name.Equals(x_oObj.offer_name)){ return false; }
            if(!this.n_lCall_list_program_id.Equals(x_oObj.call_list_program_id)){ return false; }
            if(!this.n_iId.Equals(x_oObj.id)){ return false; }
            if(!this.n_iTrade_field_id.Equals(x_oObj.trade_field_id)){ return false; }
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
            string _sQuery = "UPDATE  [OfferAutomation]  SET  [active]=@active,[offer_name]=@offer_name,[call_list_program_id]=@call_list_program_id,[trade_field_id]=@trade_field_id  WHERE [OfferAutomation].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[OfferAutomation]","["+ Configurator.MSSQLTablePrefix + "OfferAutomation]"); }
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
            if(n_sOffer_name==null){  _oCmd.Parameters.Add("@offer_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@offer_name", global::System.Data.SqlDbType.NVarChar,250).Value=n_sOffer_name; }
            if(n_lCall_list_program_id==null){  _oCmd.Parameters.Add("@call_list_program_id", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@call_list_program_id", global::System.Data.SqlDbType.BigInt).Value=n_lCall_list_program_id; }
            if(n_iId==null){  _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value=n_iId; }
            if(n_iTrade_field_id==null){  _oCmd.Parameters.Add("@trade_field_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@trade_field_id", global::System.Data.SqlDbType.Int).Value=n_iTrade_field_id; }
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
        /// Summary description for table [OfferAutomation] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iId==null) { return false; }
            string _sQuery="DELETE FROM  [OfferAutomation]  WHERE [OfferAutomation].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[OfferAutomation]","["+ Configurator.MSSQLTablePrefix + "OfferAutomation]"); }
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
        /// Summary description for table [OfferAutomation] Object Base Clone
        /// </summary>
        
        public OfferAutomation DeepClone()
        {
            OfferAutomation _oOfferAutomation_Clone = new OfferAutomation();
            _oOfferAutomation_Clone.active = this.n_bActive;
            _oOfferAutomation_Clone.offer_name = this.n_sOffer_name;
            _oOfferAutomation_Clone.call_list_program_id = this.n_lCall_list_program_id;
            _oOfferAutomation_Clone.id = this.n_iId;
            _oOfferAutomation_Clone.trade_field_id = this.n_iTrade_field_id;
            _oOfferAutomation_Clone.SetFound(this.n_bFound);
            _oOfferAutomation_Clone.SetDB(this.n_oDB);
            _oOfferAutomation_Clone.SetRow(this.n_oRow);
            _oOfferAutomation_Clone.SetTbl(this.n_oTbl);
            _oOfferAutomation_Clone.SetTableSet(this.n_oTableSet);
            
            return _oOfferAutomation_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_bActive=null;
            n_sOffer_name=global::System.String.Empty;
            n_lCall_list_program_id=null;
            n_iId=null;
            n_iTrade_field_id=null;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = OfferAutomationInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


