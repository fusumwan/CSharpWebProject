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
///-- Create date: <Create Date 2011-03-08>
///-- Description:	<Description,Table :[MobileOrderThreePartyRevision],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [MobileOrderThreePartyRevision] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"MobileOrderThreePartyRevision")]
    public class MobileOrderThreePartyRevisionEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        
        protected global::System.Nullable<long> n_lTpy_id=null;
        #region tpy_id
        [System.Data.Linq.Mapping.Column(Name="[tpy_id]", Storage="n_lTpy_id")]
        public global::System.Nullable<long> tpy_id{
            get{
                return this.n_lTpy_id;
            }
            set{
                this.n_lTpy_id=value;
            }
        }
        #endregion tpy_id
        
        
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
        
        
        protected string n_sArthurization_person=global::System.String.Empty;
        #region arthurization_person
        [System.Data.Linq.Mapping.Column(Name="[arthurization_person]", Storage="n_sArthurization_person")]
        public string arthurization_person{
            get{
                return this.n_sArthurization_person;
            }
            set{
                this.n_sArthurization_person=value;
            }
        }
        #endregion arthurization_person
        
        
        protected string n_sId_type=global::System.String.Empty;
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
        
        
        protected string n_sContact_no=global::System.String.Empty;
        #region contact_no
        [System.Data.Linq.Mapping.Column(Name="[contact_no]", Storage="n_sContact_no")]
        public string contact_no{
            get{
                return this.n_sContact_no;
            }
            set{
                this.n_sContact_no=value;
            }
        }
        #endregion contact_no
        
        
        protected string n_sPlural=global::System.String.Empty;
        #region plural
        [System.Data.Linq.Mapping.Column(Name="[plural]", Storage="n_sPlural")]
        public string plural{
            get{
                return this.n_sPlural;
            }
            set{
                this.n_sPlural=value;
            }
        }
        #endregion plural
        
        
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
        
        
        protected global::System.Nullable<long> n_lMid=null;
        #region mid
        [System.Data.Linq.Mapping.Column(Name="[mid]", Storage="n_lMid")]
        public global::System.Nullable<long> mid{
            get{
                return this.n_lMid;
            }
            set{
                this.n_lMid=value;
            }
        }
        #endregion mid
        
        
        protected global::System.Nullable<bool> n_bThree_party=null;
        #region three_party
        [System.Data.Linq.Mapping.Column(Name="[three_party]", Storage="n_bThree_party")]
        public global::System.Nullable<bool> three_party{
            get{
                return this.n_bThree_party;
            }
            set{
                this.n_bThree_party=value;
            }
        }
        #endregion three_party
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private MobileOrderThreePartyRevisionInfo n_oTableSet = MobileOrderThreePartyRevisionInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string tpy_id="tpy_id";
            public const string arthurization_person="arthurization_person";
            public const string contact_no="contact_no";
            public const string type="type";
            public const string id_type="id_type";
            public const string plural="plural";
            public const string hkid="hkid";
            public const string order_id="order_id";
            public const string mid="mid";
            public const string three_party="three_party";
            public const string MobileOrderThreePartyRevision_table_name="MobileOrderThreePartyRevision";
            public static string TableName() { return MobileOrderThreePartyRevision_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public MobileOrderThreePartyRevisionEntity(){
            Init();
        }
        public MobileOrderThreePartyRevisionEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public MobileOrderThreePartyRevisionEntity(MSSQLConnect x_oDB,global::System.Nullable<long> x_lMid){
            n_oDB=x_oDB;
            this.Load(x_lMid);
            Init();
        }
        
        ~MobileOrderThreePartyRevisionEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<long> x_lMid){
            if (n_oDB==null) { return false; }
            if (x_lMid==null) { return false; }
            string _sQuery = "SELECT   [MobileOrderThreePartyRevision].[tpy_id] AS MOBILEORDERTHREEPARTYREVISION_TPY_ID,[MobileOrderThreePartyRevision].[hkid] AS MOBILEORDERTHREEPARTYREVISION_HKID,[MobileOrderThreePartyRevision].[arthurization_person] AS MOBILEORDERTHREEPARTYREVISION_ARTHURIZATION_PERSON,[MobileOrderThreePartyRevision].[id_type] AS MOBILEORDERTHREEPARTYREVISION_ID_TYPE,[MobileOrderThreePartyRevision].[type] AS MOBILEORDERTHREEPARTYREVISION_TYPE,[MobileOrderThreePartyRevision].[contact_no] AS MOBILEORDERTHREEPARTYREVISION_CONTACT_NO,[MobileOrderThreePartyRevision].[plural] AS MOBILEORDERTHREEPARTYREVISION_PLURAL,[MobileOrderThreePartyRevision].[order_id] AS MOBILEORDERTHREEPARTYREVISION_ORDER_ID,[MobileOrderThreePartyRevision].[mid] AS MOBILEORDERTHREEPARTYREVISION_MID,[MobileOrderThreePartyRevision].[three_party] AS MOBILEORDERTHREEPARTYREVISION_THREE_PARTY  FROM  [MobileOrderThreePartyRevision]  WHERE  [MobileOrderThreePartyRevision].[mid] = \'"+x_lMid.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderThreePartyRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderThreePartyRevision]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_TPY_ID"])) {n_lTpy_id = (global::System.Nullable<long>)_oData["MOBILEORDERTHREEPARTYREVISION_TPY_ID"];}else{n_lTpy_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_HKID"])) {n_sHkid = (string)_oData["MOBILEORDERTHREEPARTYREVISION_HKID"];}else{n_sHkid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_ARTHURIZATION_PERSON"])) {n_sArthurization_person = (string)_oData["MOBILEORDERTHREEPARTYREVISION_ARTHURIZATION_PERSON"];}else{n_sArthurization_person=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_ID_TYPE"])) {n_sId_type = (string)_oData["MOBILEORDERTHREEPARTYREVISION_ID_TYPE"];}else{n_sId_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_TYPE"])) {n_sType = (string)_oData["MOBILEORDERTHREEPARTYREVISION_TYPE"];}else{n_sType=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_CONTACT_NO"])) {n_sContact_no = (string)_oData["MOBILEORDERTHREEPARTYREVISION_CONTACT_NO"];}else{n_sContact_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_PLURAL"])) {n_sPlural = (string)_oData["MOBILEORDERTHREEPARTYREVISION_PLURAL"];}else{n_sPlural=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_ORDER_ID"])) {n_iOrder_id = (global::System.Nullable<int>)_oData["MOBILEORDERTHREEPARTYREVISION_ORDER_ID"];}else{n_iOrder_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_MID"])) {n_lMid = (global::System.Nullable<long>)_oData["MOBILEORDERTHREEPARTYREVISION_MID"];}else{n_lMid=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_THREE_PARTY"])) {n_bThree_party = (global::System.Nullable<bool>)_oData["MOBILEORDERTHREEPARTYREVISION_THREE_PARTY"];}else{n_bThree_party=null;}
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
            if (n_lTpy_id==null && !(n_oTableSet.Fields(Para.tpy_id).IsNullable)) return false;
            if (n_sHkid==null && !(n_oTableSet.Fields(Para.hkid).IsNullable)) return false;
            if (n_sArthurization_person==null && !(n_oTableSet.Fields(Para.arthurization_person).IsNullable)) return false;
            if (n_sId_type==null && !(n_oTableSet.Fields(Para.id_type).IsNullable)) return false;
            if (n_sType==null && !(n_oTableSet.Fields(Para.type).IsNullable)) return false;
            if (n_sContact_no==null && !(n_oTableSet.Fields(Para.contact_no).IsNullable)) return false;
            if (n_sPlural==null && !(n_oTableSet.Fields(Para.plural).IsNullable)) return false;
            if (n_iOrder_id==null && !(n_oTableSet.Fields(Para.order_id).IsNullable)) return false;
            if(!x_bInsert){
                if (n_lMid==null && !(n_oTableSet.Fields(Para.mid).IsNullable)) return false;
            }
            if (n_bThree_party==null && !(n_oTableSet.Fields(Para.three_party).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(MobileOrderThreePartyRevisionEntity)) || (x_oObj is MobileOrderThreePartyRevisionEntity)) return MobileOrderThreePartyRevisionRepository.Instance();
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
        public MobileOrderThreePartyRevisionInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(MobileOrderThreePartyRevisionInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public global::System.Nullable<long> GetTpy_id(){return this.tpy_id;}
        public string GetArthurization_person(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.arthurization_person)) { return string.Empty; }
            return this.arthurization_person;
        }
        public string GetContact_no(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.contact_no)) { return string.Empty; }
            return this.contact_no;
        }
        public string GetType(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.type)) { return string.Empty; }
            return this.type;
        }
        public string GetId_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.id_type)) { return string.Empty; }
            return this.id_type;
        }
        public string GetPlural(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.plural)) { return string.Empty; }
            return this.plural;
        }
        public string GetHkid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.hkid)) { return string.Empty; }
            return this.hkid;
        }
        public global::System.Nullable<int> GetOrder_id(){return this.order_id;}
        public global::System.Nullable<long> GetMid(){return this.mid;}
        public global::System.Nullable<bool> GetThree_party(){return this.three_party;}
        
        public bool SetTpy_id(global::System.Nullable<long> value){
            this.tpy_id=value;
            return true;
        }
        public bool SetArthurization_person(string value){
            this.arthurization_person=value;
            return true;
        }
        public bool SetContact_no(string value){
            this.contact_no=value;
            return true;
        }
        public bool SetType(string value){
            this.type=value;
            return true;
        }
        public bool SetId_type(string value){
            this.id_type=value;
            return true;
        }
        public bool SetPlural(string value){
            this.plural=value;
            return true;
        }
        public bool SetHkid(string value){
            this.hkid=value;
            return true;
        }
        public bool SetOrder_id(global::System.Nullable<int> value){
            this.order_id=value;
            return true;
        }
        public bool SetMid(global::System.Nullable<long> value){
            this.mid=value;
            return true;
        }
        public bool SetThree_party(global::System.Nullable<bool> value){
            this.three_party=value;
            return true;
        }
        
        public Field GetTpy_idTable(){
            return n_oTableSet.Fields(Para.tpy_id);
        }
        public Field GetArthurization_personTable(){
            return n_oTableSet.Fields(Para.arthurization_person);
        }
        public Field GetContact_noTable(){
            return n_oTableSet.Fields(Para.contact_no);
        }
        public Field GetTypeTable(){
            return n_oTableSet.Fields(Para.type);
        }
        public Field GetId_typeTable(){
            return n_oTableSet.Fields(Para.id_type);
        }
        public Field GetPluralTable(){
            return n_oTableSet.Fields(Para.plural);
        }
        public Field GetHkidTable(){
            return n_oTableSet.Fields(Para.hkid);
        }
        public Field GetOrder_idTable(){
            return n_oTableSet.Fields(Para.order_id);
        }
        public Field GetMidTable(){
            return n_oTableSet.Fields(Para.mid);
        }
        public Field GetThree_partyTable(){
            return n_oTableSet.Fields(Para.three_party);
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
        
        public bool EqualID(MobileOrderThreePartyRevision x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_lMid.Equals(x_oObj.mid)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(MobileOrderThreePartyRevision x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_lTpy_id.Equals(x_oObj.tpy_id)){ return false; }
            if(!this.n_sHkid.Equals(x_oObj.hkid)){ return false; }
            if(!this.n_sArthurization_person.Equals(x_oObj.arthurization_person)){ return false; }
            if(!this.n_sId_type.Equals(x_oObj.id_type)){ return false; }
            if(!this.n_sType.Equals(x_oObj.type)){ return false; }
            if(!this.n_sContact_no.Equals(x_oObj.contact_no)){ return false; }
            if(!this.n_sPlural.Equals(x_oObj.plural)){ return false; }
            if(!this.n_iOrder_id.Equals(x_oObj.order_id)){ return false; }
            if(!this.n_lMid.Equals(x_oObj.mid)){ return false; }
            if(!this.n_bThree_party.Equals(x_oObj.three_party)){ return false; }
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
            if(!n_lMid.Equals(null)){
                _bResult=this.Load(n_lMid);
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
            if (n_lMid==null) { return false; }
            if(!Vaild(false)){ return false; }
            string _sQuery = "UPDATE  [MobileOrderThreePartyRevision]  SET  [tpy_id]=@tpy_id,[hkid]=@hkid,[arthurization_person]=@arthurization_person,[id_type]=@id_type,[type]=@type,[contact_no]=@contact_no,[plural]=@plural,[order_id]=@order_id,[three_party]=@three_party  WHERE [MobileOrderThreePartyRevision].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderThreePartyRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderThreePartyRevision]"); }
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
            if(n_lTpy_id==null){  _oCmd.Parameters.Add("@tpy_id", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@tpy_id", global::System.Data.SqlDbType.BigInt).Value=n_lTpy_id; }
            if(n_sHkid==null){  _oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,30).Value=n_sHkid; }
            if(n_sArthurization_person==null){  _oCmd.Parameters.Add("@arthurization_person", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@arthurization_person", global::System.Data.SqlDbType.NVarChar,250).Value=n_sArthurization_person; }
            if(n_sId_type==null){  _oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,10).Value=n_sId_type; }
            if(n_sType==null){  _oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar,50).Value=n_sType; }
            if(n_sContact_no==null){  _oCmd.Parameters.Add("@contact_no", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@contact_no", global::System.Data.SqlDbType.NVarChar,20).Value=n_sContact_no; }
            if(n_sPlural==null){  _oCmd.Parameters.Add("@plural", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@plural", global::System.Data.SqlDbType.NVarChar,20).Value=n_sPlural; }
            if(n_iOrder_id==null){  _oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=n_iOrder_id; }
            if(n_lMid==null){  _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.BigInt).Value=n_lMid; }
            if(n_bThree_party==null){  _oCmd.Parameters.Add("@three_party", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@three_party", global::System.Data.SqlDbType.Bit).Value=n_bThree_party; }
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
        /// Summary description for table [MobileOrderThreePartyRevision] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_lMid==null) { return false; }
            string _sQuery="DELETE FROM  [MobileOrderThreePartyRevision]  WHERE [MobileOrderThreePartyRevision].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderThreePartyRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderThreePartyRevision]"); }
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
            _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.BigInt).Value = n_lMid;
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
        /// Summary description for table [MobileOrderThreePartyRevision] Object Base Clone
        /// </summary>
        
        public MobileOrderThreePartyRevision DeepClone()
        {
            MobileOrderThreePartyRevision _oMobileOrderThreePartyRevision_Clone = new MobileOrderThreePartyRevision();
            _oMobileOrderThreePartyRevision_Clone.tpy_id = this.n_lTpy_id;
            _oMobileOrderThreePartyRevision_Clone.hkid = this.n_sHkid;
            _oMobileOrderThreePartyRevision_Clone.arthurization_person = this.n_sArthurization_person;
            _oMobileOrderThreePartyRevision_Clone.id_type = this.n_sId_type;
            _oMobileOrderThreePartyRevision_Clone.type = this.n_sType;
            _oMobileOrderThreePartyRevision_Clone.contact_no = this.n_sContact_no;
            _oMobileOrderThreePartyRevision_Clone.plural = this.n_sPlural;
            _oMobileOrderThreePartyRevision_Clone.order_id = this.n_iOrder_id;
            _oMobileOrderThreePartyRevision_Clone.mid = this.n_lMid;
            _oMobileOrderThreePartyRevision_Clone.three_party = this.n_bThree_party;
            _oMobileOrderThreePartyRevision_Clone.SetFound(this.n_bFound);
            _oMobileOrderThreePartyRevision_Clone.SetDB(this.n_oDB);
            _oMobileOrderThreePartyRevision_Clone.SetRow(this.n_oRow);
            _oMobileOrderThreePartyRevision_Clone.SetTbl(this.n_oTbl);
            _oMobileOrderThreePartyRevision_Clone.SetTableSet(this.n_oTableSet);
            
            return _oMobileOrderThreePartyRevision_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_lTpy_id=null;
            n_sHkid=global::System.String.Empty;
            n_sArthurization_person=global::System.String.Empty;
            n_sId_type=global::System.String.Empty;
            n_sType=global::System.String.Empty;
            n_sContact_no=global::System.String.Empty;
            n_sPlural=global::System.String.Empty;
            n_iOrder_id=null;
            n_lMid=null;
            n_bThree_party=null;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = MobileOrderThreePartyRevisionInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


