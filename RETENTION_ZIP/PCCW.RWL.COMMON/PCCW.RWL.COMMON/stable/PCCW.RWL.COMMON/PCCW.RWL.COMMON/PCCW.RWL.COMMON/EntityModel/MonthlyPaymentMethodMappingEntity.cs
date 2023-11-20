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
///-- Create date: <Create Date 2011-11-09>
///-- Description:	<Description,Table :[MonthlyPaymentMethodMapping],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [MonthlyPaymentMethodMapping] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"MonthlyPaymentMethodMapping")]
    public class MonthlyPaymentMethodMappingEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        
        protected global::System.Nullable<bool> n_bCash_group=null;
        #region cash_group
        [System.Data.Linq.Mapping.Column(Name="[cash_group]", Storage="n_bCash_group")]
        public global::System.Nullable<bool> cash_group{
            get{
                return this.n_bCash_group;
            }
            set{
                this.n_bCash_group=value;
            }
        }
        #endregion cash_group
        
        
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
        
        
        protected global::System.Nullable<bool> n_bCredit_card_group=null;
        #region credit_card_group
        [System.Data.Linq.Mapping.Column(Name="[credit_card_group]", Storage="n_bCredit_card_group")]
        public global::System.Nullable<bool> credit_card_group{
            get{
                return this.n_bCredit_card_group;
            }
            set{
                this.n_bCredit_card_group=value;
            }
        }
        #endregion credit_card_group
        
        
        protected string n_sPayment_type=global::System.String.Empty;
        #region payment_type
        [System.Data.Linq.Mapping.Column(Name="[payment_type]", Storage="n_sPayment_type")]
        public string payment_type{
            get{
                return this.n_sPayment_type;
            }
            set{
                this.n_sPayment_type=value;
            }
        }
        #endregion payment_type
        
        
        protected string n_sProgram=global::System.String.Empty;
        #region program
        [System.Data.Linq.Mapping.Column(Name="[program]", Storage="n_sProgram")]
        public string program{
            get{
                return this.n_sProgram;
            }
            set{
                this.n_sProgram=value;
            }
        }
        #endregion program
        
        
        protected string n_sIssue_type=global::System.String.Empty;
        #region issue_type
        [System.Data.Linq.Mapping.Column(Name="[issue_type]", Storage="n_sIssue_type")]
        public string issue_type{
            get{
                return this.n_sIssue_type;
            }
            set{
                this.n_sIssue_type=value;
            }
        }
        #endregion issue_type
        
        
        protected global::System.Nullable<bool> n_bBank_account_group=null;
        #region bank_account_group
        [System.Data.Linq.Mapping.Column(Name="[bank_account_group]", Storage="n_bBank_account_group")]
        public global::System.Nullable<bool> bank_account_group{
            get{
                return this.n_bBank_account_group;
            }
            set{
                this.n_bBank_account_group=value;
            }
        }
        #endregion bank_account_group
        
        
        protected global::System.Nullable<bool> n_bThird_party_credit_card=null;
        #region third_party_credit_card
        [System.Data.Linq.Mapping.Column(Name="[third_party_credit_card]", Storage="n_bThird_party_credit_card")]
        public global::System.Nullable<bool> third_party_credit_card{
            get{
                return this.n_bThird_party_credit_card;
            }
            set{
                this.n_bThird_party_credit_card=value;
            }
        }
        #endregion third_party_credit_card
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private MonthlyPaymentMethodMappingInfo n_oTableSet = MonthlyPaymentMethodMappingInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string cash_group="cash_group";
            public const string id="id";
            public const string active="active";
            public const string credit_card_group="credit_card_group";
            public const string payment_type="payment_type";
            public const string program="program";
            public const string issue_type="issue_type";
            public const string third_party_credit_card="third_party_credit_card";
            public const string bank_account_group="bank_account_group";
            public const string MonthlyPaymentMethodMapping_table_name="MonthlyPaymentMethodMapping";
            public static string TableName() { return MonthlyPaymentMethodMapping_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public MonthlyPaymentMethodMappingEntity(){
            Init();
        }
        public MonthlyPaymentMethodMappingEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public MonthlyPaymentMethodMappingEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId){
            n_oDB=x_oDB;
            this.Load(x_iId);
            Init();
        }
        
        ~MonthlyPaymentMethodMappingEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iId){
            if (n_oDB==null) { return false; }
            if (x_iId==null) { return false; }
            string _sQuery = "SELECT   [MonthlyPaymentMethodMapping].[cash_group] AS MONTHLYPAYMENTMETHODMAPPING_CASH_GROUP,[MonthlyPaymentMethodMapping].[id] AS MONTHLYPAYMENTMETHODMAPPING_ID,[MonthlyPaymentMethodMapping].[active] AS MONTHLYPAYMENTMETHODMAPPING_ACTIVE,[MonthlyPaymentMethodMapping].[credit_card_group] AS MONTHLYPAYMENTMETHODMAPPING_CREDIT_CARD_GROUP,[MonthlyPaymentMethodMapping].[payment_type] AS MONTHLYPAYMENTMETHODMAPPING_PAYMENT_TYPE,[MonthlyPaymentMethodMapping].[program] AS MONTHLYPAYMENTMETHODMAPPING_PROGRAM,[MonthlyPaymentMethodMapping].[issue_type] AS MONTHLYPAYMENTMETHODMAPPING_ISSUE_TYPE,[MonthlyPaymentMethodMapping].[bank_account_group] AS MONTHLYPAYMENTMETHODMAPPING_BANK_ACCOUNT_GROUP,[MonthlyPaymentMethodMapping].[third_party_credit_card] AS MONTHLYPAYMENTMETHODMAPPING_THIRD_PARTY_CREDIT_CARD  FROM  [MonthlyPaymentMethodMapping]  WHERE  [MonthlyPaymentMethodMapping].[id] = \'"+x_iId.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MonthlyPaymentMethodMapping]","["+ Configurator.MSSQLTablePrefix + "MonthlyPaymentMethodMapping]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_CASH_GROUP"])) {n_bCash_group = (global::System.Nullable<bool>)_oData["MONTHLYPAYMENTMETHODMAPPING_CASH_GROUP"];}else{n_bCash_group=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_ID"])) {n_iId = (global::System.Nullable<int>)_oData["MONTHLYPAYMENTMETHODMAPPING_ID"];}else{n_iId=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["MONTHLYPAYMENTMETHODMAPPING_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_CREDIT_CARD_GROUP"])) {n_bCredit_card_group = (global::System.Nullable<bool>)_oData["MONTHLYPAYMENTMETHODMAPPING_CREDIT_CARD_GROUP"];}else{n_bCredit_card_group=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_PAYMENT_TYPE"])) {n_sPayment_type = (string)_oData["MONTHLYPAYMENTMETHODMAPPING_PAYMENT_TYPE"];}else{n_sPayment_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_PROGRAM"])) {n_sProgram = (string)_oData["MONTHLYPAYMENTMETHODMAPPING_PROGRAM"];}else{n_sProgram=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_ISSUE_TYPE"])) {n_sIssue_type = (string)_oData["MONTHLYPAYMENTMETHODMAPPING_ISSUE_TYPE"];}else{n_sIssue_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_BANK_ACCOUNT_GROUP"])) {n_bBank_account_group = (global::System.Nullable<bool>)_oData["MONTHLYPAYMENTMETHODMAPPING_BANK_ACCOUNT_GROUP"];}else{n_bBank_account_group=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_THIRD_PARTY_CREDIT_CARD"])) {n_bThird_party_credit_card = (global::System.Nullable<bool>)_oData["MONTHLYPAYMENTMETHODMAPPING_THIRD_PARTY_CREDIT_CARD"];}else{n_bThird_party_credit_card=null;}
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
            if (n_bCash_group==null && !(n_oTableSet.Fields(Para.cash_group).IsNullable)) return false;
            if(!x_bInsert){
                if (n_iId==null && !(n_oTableSet.Fields(Para.id).IsNullable)) return false;
            }
            if (n_bActive==null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_bCredit_card_group==null && !(n_oTableSet.Fields(Para.credit_card_group).IsNullable)) return false;
            if (n_sPayment_type==null && !(n_oTableSet.Fields(Para.payment_type).IsNullable)) return false;
            if (n_sProgram==null && !(n_oTableSet.Fields(Para.program).IsNullable)) return false;
            if (n_sIssue_type==null && !(n_oTableSet.Fields(Para.issue_type).IsNullable)) return false;
            if (n_bBank_account_group==null && !(n_oTableSet.Fields(Para.bank_account_group).IsNullable)) return false;
            if (n_bThird_party_credit_card==null && !(n_oTableSet.Fields(Para.third_party_credit_card).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(MonthlyPaymentMethodMappingEntity)) || (x_oObj is MonthlyPaymentMethodMappingEntity)) return MonthlyPaymentMethodMappingRepository.Instance();
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
        public MonthlyPaymentMethodMappingInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(MonthlyPaymentMethodMappingInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public global::System.Nullable<bool> GetCash_group(){return this.cash_group;}
        public global::System.Nullable<int> GetId(){return this.id;}
        public global::System.Nullable<bool> GetActive(){return this.active;}
        public global::System.Nullable<bool> GetCredit_card_group(){return this.credit_card_group;}
        public string GetPayment_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.payment_type)) { return string.Empty; }
            return this.payment_type;
        }
        public string GetProgram(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.program)) { return string.Empty; }
            return this.program;
        }
        public string GetIssue_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.issue_type)) { return string.Empty; }
            return this.issue_type;
        }
        public global::System.Nullable<bool> GetThird_party_credit_card(){return this.third_party_credit_card;}
        public global::System.Nullable<bool> GetBank_account_group(){return this.bank_account_group;}
        
        public bool SetCash_group(global::System.Nullable<bool> value){
            this.cash_group=value;
            return true;
        }
        public bool SetId(global::System.Nullable<int> value){
            this.id=value;
            return true;
        }
        public bool SetActive(global::System.Nullable<bool> value){
            this.active=value;
            return true;
        }
        public bool SetCredit_card_group(global::System.Nullable<bool> value){
            this.credit_card_group=value;
            return true;
        }
        public bool SetPayment_type(string value){
            this.payment_type=value;
            return true;
        }
        public bool SetProgram(string value){
            this.program=value;
            return true;
        }
        public bool SetIssue_type(string value){
            this.issue_type=value;
            return true;
        }
        public bool SetThird_party_credit_card(global::System.Nullable<bool> value){
            this.third_party_credit_card=value;
            return true;
        }
        public bool SetBank_account_group(global::System.Nullable<bool> value){
            this.bank_account_group=value;
            return true;
        }
        
        public Field GetCash_groupTable(){
            return n_oTableSet.Fields(Para.cash_group);
        }
        public Field GetIdTable(){
            return n_oTableSet.Fields(Para.id);
        }
        public Field GetActiveTable(){
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetCredit_card_groupTable(){
            return n_oTableSet.Fields(Para.credit_card_group);
        }
        public Field GetPayment_typeTable(){
            return n_oTableSet.Fields(Para.payment_type);
        }
        public Field GetProgramTable(){
            return n_oTableSet.Fields(Para.program);
        }
        public Field GetIssue_typeTable(){
            return n_oTableSet.Fields(Para.issue_type);
        }
        public Field GetThird_party_credit_cardTable(){
            return n_oTableSet.Fields(Para.third_party_credit_card);
        }
        public Field GetBank_account_groupTable(){
            return n_oTableSet.Fields(Para.bank_account_group);
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
        
        public bool EqualID(MonthlyPaymentMethodMapping x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(MonthlyPaymentMethodMapping x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_bCash_group.Equals(x_oObj.cash_group)){ return false; }
            if(!this.n_iId.Equals(x_oObj.id)){ return false; }
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_bCredit_card_group.Equals(x_oObj.credit_card_group)){ return false; }
            if(!this.n_sPayment_type.Equals(x_oObj.payment_type)){ return false; }
            if(!this.n_sProgram.Equals(x_oObj.program)){ return false; }
            if(!this.n_sIssue_type.Equals(x_oObj.issue_type)){ return false; }
            if(!this.n_bBank_account_group.Equals(x_oObj.bank_account_group)){ return false; }
            if(!this.n_bThird_party_credit_card.Equals(x_oObj.third_party_credit_card)){ return false; }
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
            string _sQuery = "UPDATE  [MonthlyPaymentMethodMapping]  SET  [cash_group]=@cash_group,[active]=@active,[credit_card_group]=@credit_card_group,[payment_type]=@payment_type,[program]=@program,[issue_type]=@issue_type,[bank_account_group]=@bank_account_group,[third_party_credit_card]=@third_party_credit_card  WHERE [MonthlyPaymentMethodMapping].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MonthlyPaymentMethodMapping]","["+ Configurator.MSSQLTablePrefix + "MonthlyPaymentMethodMapping]"); }
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
            if(n_bCash_group==null){  _oCmd.Parameters.Add("@cash_group", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@cash_group", global::System.Data.SqlDbType.Bit).Value=n_bCash_group; }
            if(n_iId==null){  _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value=n_iId; }
            if(n_bActive==null){  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=n_bActive; }
            if(n_bCredit_card_group==null){  _oCmd.Parameters.Add("@credit_card_group", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@credit_card_group", global::System.Data.SqlDbType.Bit).Value=n_bCredit_card_group; }
            if(n_sPayment_type==null){  _oCmd.Parameters.Add("@payment_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@payment_type", global::System.Data.SqlDbType.NVarChar,50).Value=n_sPayment_type; }
            if(n_sProgram==null){  _oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value=n_sProgram; }
            if(n_sIssue_type==null){  _oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value=n_sIssue_type; }
            if(n_bBank_account_group==null){  _oCmd.Parameters.Add("@bank_account_group", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@bank_account_group", global::System.Data.SqlDbType.Bit).Value=n_bBank_account_group; }
            if(n_bThird_party_credit_card==null){  _oCmd.Parameters.Add("@third_party_credit_card", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@third_party_credit_card", global::System.Data.SqlDbType.Bit).Value=n_bThird_party_credit_card; }
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
        /// Summary description for table [MonthlyPaymentMethodMapping] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iId==null) { return false; }
            string _sQuery="DELETE FROM  [MonthlyPaymentMethodMapping]  WHERE [MonthlyPaymentMethodMapping].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MonthlyPaymentMethodMapping]","["+ Configurator.MSSQLTablePrefix + "MonthlyPaymentMethodMapping]"); }
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
        /// Summary description for table [MonthlyPaymentMethodMapping] Object Base Clone
        /// </summary>
        
        public MonthlyPaymentMethodMapping DeepClone()
        {
            MonthlyPaymentMethodMapping _oMonthlyPaymentMethodMapping_Clone = new MonthlyPaymentMethodMapping();
            _oMonthlyPaymentMethodMapping_Clone.cash_group = this.n_bCash_group;
            _oMonthlyPaymentMethodMapping_Clone.id = this.n_iId;
            _oMonthlyPaymentMethodMapping_Clone.active = this.n_bActive;
            _oMonthlyPaymentMethodMapping_Clone.credit_card_group = this.n_bCredit_card_group;
            _oMonthlyPaymentMethodMapping_Clone.payment_type = this.n_sPayment_type;
            _oMonthlyPaymentMethodMapping_Clone.program = this.n_sProgram;
            _oMonthlyPaymentMethodMapping_Clone.issue_type = this.n_sIssue_type;
            _oMonthlyPaymentMethodMapping_Clone.bank_account_group = this.n_bBank_account_group;
            _oMonthlyPaymentMethodMapping_Clone.third_party_credit_card = this.n_bThird_party_credit_card;
            _oMonthlyPaymentMethodMapping_Clone.SetFound(this.n_bFound);
            _oMonthlyPaymentMethodMapping_Clone.SetDB(this.n_oDB);
            _oMonthlyPaymentMethodMapping_Clone.SetRow(this.n_oRow);
            _oMonthlyPaymentMethodMapping_Clone.SetTbl(this.n_oTbl);
            _oMonthlyPaymentMethodMapping_Clone.SetTableSet(this.n_oTableSet);
            
            return _oMonthlyPaymentMethodMapping_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_bCash_group=null;
            n_iId=null;
            n_bActive=null;
            n_bCredit_card_group=null;
            n_sPayment_type=global::System.String.Empty;
            n_sProgram=global::System.String.Empty;
            n_sIssue_type=global::System.String.Empty;
            n_bBank_account_group=null;
            n_bThird_party_credit_card=null;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = MonthlyPaymentMethodMappingInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


