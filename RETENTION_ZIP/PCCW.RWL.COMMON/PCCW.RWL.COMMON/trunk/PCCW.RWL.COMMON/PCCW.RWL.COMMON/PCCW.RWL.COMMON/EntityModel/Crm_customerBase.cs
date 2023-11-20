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
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-03-08>
///-- Description:	<Description,Table :[crm_customer],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [crm_customer] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = "crm_customer")]
    public class Crm_customerBase{
        
        
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
        
        
        protected string n_sCust_type=string.Empty;
        #region cust_type
        [System.Data.Linq.Mapping.Column(Name="[cust_type]", Storage="n_sCust_type")]
        public string cust_type{
            get{
                return this.n_sCust_type;
            }
            set{
                this.n_sCust_type=value;
            }
        }
        #endregion cust_type
        
        
        protected string n_sCust_title=string.Empty;
        #region cust_title
        [System.Data.Linq.Mapping.Column(Name="[cust_title]", Storage="n_sCust_title")]
        public string cust_title{
            get{
                return this.n_sCust_title;
            }
            set{
                this.n_sCust_title=value;
            }
        }
        #endregion cust_title
        
        
        protected string n_sCon_email=string.Empty;
        #region con_email
        [System.Data.Linq.Mapping.Column(Name="[con_email]", Storage="n_sCon_email")]
        public string con_email{
            get{
                return this.n_sCon_email;
            }
            set{
                this.n_sCon_email=value;
            }
        }
        #endregion con_email
        
        
        protected string n_sId_type=string.Empty;
        #region id_type
        [System.Data.Linq.Mapping.Column(Name="[id_type]", Storage="n_sId_type")]
        public string id_type{
            get{
                return this.n_sId_type;
            }
            set{
                this.n_sId_type=value;
            }
        }
        #endregion id_type
        
        
        protected string n_sCust_name=string.Empty;
        #region cust_name
        [System.Data.Linq.Mapping.Column(Name="[cust_name]", Storage="n_sCust_name")]
        public string cust_name{
            get{
                return this.n_sCust_name;
            }
            set{
                this.n_sCust_name=value;
            }
        }
        #endregion cust_name
        
        
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
        
        
        protected string n_sTel_night=string.Empty;
        #region tel_night
        [System.Data.Linq.Mapping.Column(Name="[tel_night]", Storage="n_sTel_night")]
        public string tel_night{
            get{
                return this.n_sTel_night;
            }
            set{
                this.n_sTel_night=value;
            }
        }
        #endregion tel_night
        
        
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
        
        
        protected string n_sTel_day=string.Empty;
        #region tel_day
        [System.Data.Linq.Mapping.Column(Name="[tel_day]", Storage="n_sTel_day")]
        public string tel_day{
            get{
                return this.n_sTel_day;
            }
            set{
                this.n_sTel_day=value;
            }
        }
        #endregion tel_day
        
        
        protected string n_sFr_cl=string.Empty;
        #region fr_cl
        [System.Data.Linq.Mapping.Column(Name="[fr_cl]", Storage="n_sFr_cl")]
        public string fr_cl{
            get{
                return this.n_sFr_cl;
            }
            set{
                this.n_sFr_cl=value;
            }
        }
        #endregion fr_cl
        
        
        protected string n_sHkid_br=string.Empty;
        #region hkid_br
        [System.Data.Linq.Mapping.Column(Name="[hkid_br]", Storage="n_sHkid_br")]
        public string hkid_br{
            get{
                return this.n_sHkid_br;
            }
            set{
                this.n_sHkid_br=value;
            }
        }
        #endregion hkid_br
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private global::System.Data.DataTable n_oTbl = null;
        private global::System.Data.DataRow n_oRow = null;
        private Crm_customerInfo n_oTableSet = new Crm_customerInfo();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string active="active";
            public const string cdate="cdate";
            public const string cid="cid";
            public const string did="did";
            public const string cust_type="cust_type";
            public const string cust_title="cust_title";
            public const string id_type="id_type";
            public const string con_email="con_email";
            public const string cust_id="cust_id";
            public const string cust_name="cust_name";
            public const string ddate="ddate";
            public const string tel_night="tel_night";
            public const string tel_day="tel_day";
            public const string fr_cl="fr_cl";
            public const string hkid_br="hkid_br";
            public const string Crm_customer_table_name = Configurator.MSSQLTablePrefix + "crm_customer";
            public static string TableName() { return Crm_customer_table_name; }
        }
        #endregion Parameter String
        #region Constructor
        
        public Crm_customerBase(){
            Init();
        }
        public Crm_customerBase(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public Crm_customerBase(MSSQLConnect x_oDB,System.Nullable<bool> x_bActive,System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sCust_type,string x_sCust_title,string x_sId_type,string x_sCon_email,System.Nullable<int> x_iCust_id,string x_sCust_name,System.Nullable<DateTime> x_dDdate,string x_sTel_night,string x_sTel_day,string x_sFr_cl,string x_sHkid_br){
            n_oDB=x_oDB;
            this.Load(x_bActive,x_dCdate,x_sCid,x_sDid,x_sCust_type,x_sCust_title,x_sId_type,x_sCon_email,x_iCust_id,x_sCust_name,x_dDdate,x_sTel_night,x_sTel_day,x_sFr_cl,x_sHkid_br);
            Init();
        }
        
        ~Crm_customerBase(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<bool> x_bActive,System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sCust_type,string x_sCust_title,string x_sId_type,string x_sCon_email,System.Nullable<int> x_iCust_id,string x_sCust_name,System.Nullable<DateTime> x_dDdate,string x_sTel_night,string x_sTel_day,string x_sFr_cl,string x_sHkid_br){
            if (n_oDB == null) { return false; }
            if (x_bActive==null) { return false; }
            if (x_dCdate==null) { return false; }
            if (string.IsNullOrEmpty(x_sCid)) { return false; }
            if (string.IsNullOrEmpty(x_sDid)) { return false; }
            if (string.IsNullOrEmpty(x_sCust_type)) { return false; }
            if (string.IsNullOrEmpty(x_sCust_title)) { return false; }
            if (string.IsNullOrEmpty(x_sId_type)) { return false; }
            if (string.IsNullOrEmpty(x_sCon_email)) { return false; }
            if (x_iCust_id==null) { return false; }
            if (string.IsNullOrEmpty(x_sCust_name)) { return false; }
            if (x_dDdate==null) { return false; }
            if (string.IsNullOrEmpty(x_sTel_night)) { return false; }
            if (string.IsNullOrEmpty(x_sTel_day)) { return false; }
            if (string.IsNullOrEmpty(x_sFr_cl)) { return false; }
            if (string.IsNullOrEmpty(x_sHkid_br)) { return false; }
            string _sQuery = "SELECT [crm_customer].[active] AS CRM_CUSTOMER_ACTIVE,[crm_customer].[cdate] AS CRM_CUSTOMER_CDATE,[crm_customer].[cid] AS CRM_CUSTOMER_CID,[crm_customer].[did] AS CRM_CUSTOMER_DID,[crm_customer].[cust_type] AS CRM_CUSTOMER_CUST_TYPE,[crm_customer].[cust_title] AS CRM_CUSTOMER_CUST_TITLE,[crm_customer].[con_email] AS CRM_CUSTOMER_CON_EMAIL,[crm_customer].[id_type] AS CRM_CUSTOMER_ID_TYPE,[crm_customer].[cust_name] AS CRM_CUSTOMER_CUST_NAME,[crm_customer].[cust_id] AS CRM_CUSTOMER_CUST_ID,[crm_customer].[tel_night] AS CRM_CUSTOMER_TEL_NIGHT,[crm_customer].[ddate] AS CRM_CUSTOMER_DDATE,[crm_customer].[tel_day] AS CRM_CUSTOMER_TEL_DAY,[crm_customer].[fr_cl] AS CRM_CUSTOMER_FR_CL,[crm_customer].[hkid_br] AS CRM_CUSTOMER_HKID_BR  FROM  [crm_customer]  WHERE  [crm_customer].[active] = \'"+x_bActive.ToString()+"\'  AND  [crm_customer].[cdate] = \'"+x_dCdate.ToString()+"\'  AND  [crm_customer].[cid] = \'"+x_sCid.ToString()+"\'  AND  [crm_customer].[did] = \'"+x_sDid.ToString()+"\'  AND  [crm_customer].[cust_type] = \'"+x_sCust_type.ToString()+"\'  AND  [crm_customer].[cust_title] = \'"+x_sCust_title.ToString()+"\'  AND  [crm_customer].[id_type] = \'"+x_sId_type.ToString()+"\'  AND  [crm_customer].[con_email] = \'"+x_sCon_email.ToString()+"\'  AND  [crm_customer].[cust_id] = \'"+x_iCust_id.ToString()+"\'  AND  [crm_customer].[cust_name] = \'"+x_sCust_name.ToString()+"\'  AND  [crm_customer].[ddate] = \'"+x_dDdate.ToString()+"\'  AND  [crm_customer].[tel_night] = \'"+x_sTel_night.ToString()+"\'  AND  [crm_customer].[tel_day] = \'"+x_sTel_day.ToString()+"\'  AND  [crm_customer].[fr_cl] = \'"+x_sFr_cl.ToString()+"\'  AND  [crm_customer].[hkid_br] = \'"+x_sHkid_br.ToString()+"\'";
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
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["CRM_CUSTOMER_ACTIVE"];}else{ n_bActive=null;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_CDATE"])) {n_dCdate = (global::System.Nullable<DateTime>)_oData["CRM_CUSTOMER_CDATE"];}else{ n_dCdate=null;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_CID"])) {n_sCid = (string)_oData["CRM_CUSTOMER_CID"];}else{ n_sCid=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_DID"])) {n_sDid = (string)_oData["CRM_CUSTOMER_DID"];}else{ n_sDid=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_CUST_TYPE"])) {n_sCust_type = (string)_oData["CRM_CUSTOMER_CUST_TYPE"];}else{ n_sCust_type=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_CUST_TITLE"])) {n_sCust_title = (string)_oData["CRM_CUSTOMER_CUST_TITLE"];}else{ n_sCust_title=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_CON_EMAIL"])) {n_sCon_email = (string)_oData["CRM_CUSTOMER_CON_EMAIL"];}else{ n_sCon_email=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_ID_TYPE"])) {n_sId_type = (string)_oData["CRM_CUSTOMER_ID_TYPE"];}else{ n_sId_type=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_CUST_NAME"])) {n_sCust_name = (string)_oData["CRM_CUSTOMER_CUST_NAME"];}else{ n_sCust_name=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_CUST_ID"])) {n_iCust_id = (global::System.Nullable<int>)_oData["CRM_CUSTOMER_CUST_ID"];}else{ n_iCust_id=null;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_TEL_NIGHT"])) {n_sTel_night = (string)_oData["CRM_CUSTOMER_TEL_NIGHT"];}else{ n_sTel_night=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_DDATE"])) {n_dDdate = (global::System.Nullable<DateTime>)_oData["CRM_CUSTOMER_DDATE"];}else{ n_dDdate=null;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_TEL_DAY"])) {n_sTel_day = (string)_oData["CRM_CUSTOMER_TEL_DAY"];}else{ n_sTel_day=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_FR_CL"])) {n_sFr_cl = (string)_oData["CRM_CUSTOMER_FR_CL"];}else{ n_sFr_cl=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_HKID_BR"])) {n_sHkid_br = (string)_oData["CRM_CUSTOMER_HKID_BR"];}else{ n_sHkid_br=string.Empty;}
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
            if (string.IsNullOrEmpty(n_sCust_type) && !(n_oTableSet.Fields(Para.cust_type).IsNullable)) return false;
            if (string.IsNullOrEmpty(n_sCust_title) && !(n_oTableSet.Fields(Para.cust_title).IsNullable)) return false;
            if (string.IsNullOrEmpty(n_sCon_email) && !(n_oTableSet.Fields(Para.con_email).IsNullable)) return false;
            if (string.IsNullOrEmpty(n_sId_type) && !(n_oTableSet.Fields(Para.id_type).IsNullable)) return false;
            if (string.IsNullOrEmpty(n_sCust_name) && !(n_oTableSet.Fields(Para.cust_name).IsNullable)) return false;
            if(!x_bInsert){
                if (n_iCust_id==null && !(n_oTableSet.Fields(Para.cust_id).IsNullable)) return false;
            }
            if (string.IsNullOrEmpty(n_sTel_night) && !(n_oTableSet.Fields(Para.tel_night).IsNullable)) return false;
            if (n_dDdate==null && !(n_oTableSet.Fields(Para.ddate).IsNullable)) return false;
            if (string.IsNullOrEmpty(n_sTel_day) && !(n_oTableSet.Fields(Para.tel_day).IsNullable)) return false;
            if (string.IsNullOrEmpty(n_sFr_cl) && !(n_oTableSet.Fields(Para.fr_cl).IsNullable)) return false;
            if (string.IsNullOrEmpty(n_sHkid_br) && !(n_oTableSet.Fields(Para.hkid_br).IsNullable)) return false;
            return true;
        }
        #endregion
        
        #region Get & Set
        
        /// <summary>
        /// Summary description for Get & Set this all class parameters
        /// </summary>
        public object GetManagerObject(object x_oObj)
        {
            if (x_oObj is Crm_customer) return Crm_customerManager.Instance();
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
        public Crm_customerInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(Crm_customerInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public global::System.Nullable<bool> GetActive(){return this.active;}
        public global::System.Nullable<DateTime> GetCdate(){return this.cdate;}
        public string GetCid(){return this.cid;}
        public string GetDid(){return this.did;}
        public string GetCust_type(){return this.cust_type;}
        public string GetCust_title(){return this.cust_title;}
        public string GetId_type(){return this.id_type;}
        public string GetCon_email(){return this.con_email;}
        public global::System.Nullable<int> GetCust_id(){return this.cust_id;}
        public string GetCust_name(){return this.cust_name;}
        public global::System.Nullable<DateTime> GetDdate(){return this.ddate;}
        public string GetTel_night(){return this.tel_night;}
        public string GetTel_day(){return this.tel_day;}
        public string GetFr_cl(){return this.fr_cl;}
        public string GetHkid_br(){return this.hkid_br;}
        
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
        public bool SetCust_type(string value){
            this.cust_type=value;
            return true;
        }
        public bool SetCust_title(string value){
            this.cust_title=value;
            return true;
        }
        public bool SetId_type(string value){
            this.id_type=value;
            return true;
        }
        public bool SetCon_email(string value){
            this.con_email=value;
            return true;
        }
        public bool SetCust_id(global::System.Nullable<int> value){
            this.cust_id=value;
            return true;
        }
        public bool SetCust_name(string value){
            this.cust_name=value;
            return true;
        }
        public bool SetDdate(global::System.Nullable<DateTime> value){
            this.ddate=value;
            return true;
        }
        public bool SetTel_night(string value){
            this.tel_night=value;
            return true;
        }
        public bool SetTel_day(string value){
            this.tel_day=value;
            return true;
        }
        public bool SetFr_cl(string value){
            this.fr_cl=value;
            return true;
        }
        public bool SetHkid_br(string value){
            this.hkid_br=value;
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
        public Field GetCust_typeTable(){
            return n_oTableSet.Fields(Para.cust_type);
        }
        public Field GetCust_titleTable(){
            return n_oTableSet.Fields(Para.cust_title);
        }
        public Field GetId_typeTable(){
            return n_oTableSet.Fields(Para.id_type);
        }
        public Field GetCon_emailTable(){
            return n_oTableSet.Fields(Para.con_email);
        }
        public Field GetCust_idTable(){
            return n_oTableSet.Fields(Para.cust_id);
        }
        public Field GetCust_nameTable(){
            return n_oTableSet.Fields(Para.cust_name);
        }
        public Field GetDdateTable(){
            return n_oTableSet.Fields(Para.ddate);
        }
        public Field GetTel_nightTable(){
            return n_oTableSet.Fields(Para.tel_night);
        }
        public Field GetTel_dayTable(){
            return n_oTableSet.Fields(Para.tel_day);
        }
        public Field GetFr_clTable(){
            return n_oTableSet.Fields(Para.fr_cl);
        }
        public Field GetHkid_brTable(){
            return n_oTableSet.Fields(Para.hkid_br);
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
            string _sQuery = "UPDATE  [crm_customer]  SET  [active]=@active,[cdate]=@cdate,[cid]=@cid,[did]=@did,[cust_type]=@cust_type,[cust_title]=@cust_title,[con_email]=@con_email,[id_type]=@id_type,[cust_name]=@cust_name,[tel_night]=@tel_night,[ddate]=@ddate,[tel_day]=@tel_day,[fr_cl]=@fr_cl,[hkid_br]=@hkid_br ";
           
            global::System.Data.SqlClient.SqlConnection _oConn = n_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            bool _bResult=false;
            if(n_bActive==null){  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=n_bActive; }
            if(n_dCdate==null){  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=n_dCdate; }
            if(string.IsNullOrEmpty(n_sCid)){  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.VarChar,15).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.VarChar,15).Value=n_sCid; }
            if(string.IsNullOrEmpty(n_sDid)){  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.VarChar,15).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.VarChar,15).Value=n_sDid; }
            if(string.IsNullOrEmpty(n_sCust_type)){  _oCmd.Parameters.Add("@cust_type", global::System.Data.SqlDbType.Char,1).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@cust_type", global::System.Data.SqlDbType.Char,1).Value=n_sCust_type; }
            if(string.IsNullOrEmpty(n_sCust_title)){  _oCmd.Parameters.Add("@cust_title", global::System.Data.SqlDbType.VarChar,4).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@cust_title", global::System.Data.SqlDbType.VarChar,4).Value=n_sCust_title; }
            if(string.IsNullOrEmpty(n_sCon_email)){  _oCmd.Parameters.Add("@con_email", global::System.Data.SqlDbType.VarChar,50).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@con_email", global::System.Data.SqlDbType.VarChar,50).Value=n_sCon_email; }
            if(string.IsNullOrEmpty(n_sId_type)){  _oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.VarChar,4).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.VarChar,4).Value=n_sId_type; }
            if(string.IsNullOrEmpty(n_sCust_name)){  _oCmd.Parameters.Add("@cust_name", global::System.Data.SqlDbType.VarChar,100).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@cust_name", global::System.Data.SqlDbType.VarChar,100).Value=n_sCust_name; }
            if(string.IsNullOrEmpty(n_sTel_night)){  _oCmd.Parameters.Add("@tel_night", global::System.Data.SqlDbType.VarChar,15).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@tel_night", global::System.Data.SqlDbType.VarChar,15).Value=n_sTel_night; }
            if(n_dDdate==null){  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=n_dDdate; }
            if(string.IsNullOrEmpty(n_sTel_day)){  _oCmd.Parameters.Add("@tel_day", global::System.Data.SqlDbType.VarChar,15).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@tel_day", global::System.Data.SqlDbType.VarChar,15).Value=n_sTel_day; }
            if(string.IsNullOrEmpty(n_sFr_cl)){  _oCmd.Parameters.Add("@fr_cl", global::System.Data.SqlDbType.VarChar,50).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@fr_cl", global::System.Data.SqlDbType.VarChar,50).Value=n_sFr_cl; }
            if(string.IsNullOrEmpty(n_sHkid_br)){  _oCmd.Parameters.Add("@hkid_br", global::System.Data.SqlDbType.VarChar,30).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@hkid_br", global::System.Data.SqlDbType.VarChar,30).Value=n_sHkid_br; }
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
        /// Summary description for table [crm_customer] Object Base Clone
        /// </summary>
        
        public Crm_customer DeepClone()
        {
            Crm_customer _oCrm_customer_Clone = new Crm_customer();
            _oCrm_customer_Clone.active = this.n_bActive;
            _oCrm_customer_Clone.cdate = this.n_dCdate;
            _oCrm_customer_Clone.cid = this.n_sCid;
            _oCrm_customer_Clone.did = this.n_sDid;
            _oCrm_customer_Clone.cust_type = this.n_sCust_type;
            _oCrm_customer_Clone.cust_title = this.n_sCust_title;
            _oCrm_customer_Clone.con_email = this.n_sCon_email;
            _oCrm_customer_Clone.id_type = this.n_sId_type;
            _oCrm_customer_Clone.cust_name = this.n_sCust_name;
            _oCrm_customer_Clone.cust_id = this.n_iCust_id;
            _oCrm_customer_Clone.tel_night = this.n_sTel_night;
            _oCrm_customer_Clone.ddate = this.n_dDdate;
            _oCrm_customer_Clone.tel_day = this.n_sTel_day;
            _oCrm_customer_Clone.fr_cl = this.n_sFr_cl;
            _oCrm_customer_Clone.hkid_br = this.n_sHkid_br;
            _oCrm_customer_Clone.SetFound(this.n_bFound);
            _oCrm_customer_Clone.SetDB(this.n_oDB);
            _oCrm_customer_Clone.SetRow(this.n_oRow);
            _oCrm_customer_Clone.SetTbl(this.n_oTbl);
            _oCrm_customer_Clone.SetTableSet(this.n_oTableSet);
            
            return _oCrm_customer_Clone;
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
            n_sCust_type=string.Empty;
            n_sCust_title=string.Empty;
            n_sCon_email=string.Empty;
            n_sId_type=string.Empty;
            n_sCust_name=string.Empty;
            n_iCust_id=null;
            n_sTel_night=string.Empty;
            n_dDdate=null;
            n_sTel_day=string.Empty;
            n_sFr_cl=string.Empty;
            n_sHkid_br=string.Empty;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = new Crm_customerInfo();
        }
        #endregion
    }
}


