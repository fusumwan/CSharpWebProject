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
///-- Description:	<Description,Table :[MobileOrderAddress],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [MobileOrderAddress] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"MobileOrderAddress")]
    public class MobileOrderAddressEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        
        protected string n_sD_build=global::System.String.Empty;
        #region d_build
        [System.Data.Linq.Mapping.Column(Name="[d_build]", Storage="n_sD_build")]
        public string d_build{
            get{
                return this.n_sD_build;
            }
            set{
                this.n_sD_build=value;
            }
        }
        #endregion d_build
        
        
        protected string n_sD_street=global::System.String.Empty;
        #region d_street
        [System.Data.Linq.Mapping.Column(Name="[d_street]", Storage="n_sD_street")]
        public string d_street{
            get{
                return this.n_sD_street;
            }
            set{
                this.n_sD_street=value;
            }
        }
        #endregion d_street
        
        
        protected string n_sD_district=global::System.String.Empty;
        #region d_district
        [System.Data.Linq.Mapping.Column(Name="[d_district]", Storage="n_sD_district")]
        public string d_district{
            get{
                return this.n_sD_district;
            }
            set{
                this.n_sD_district=value;
            }
        }
        #endregion d_district
        
        
        protected string n_sD_region=global::System.String.Empty;
        #region d_region
        [System.Data.Linq.Mapping.Column(Name="[d_region]", Storage="n_sD_region")]
        public string d_region{
            get{
                return this.n_sD_region;
            }
            set{
                this.n_sD_region=value;
            }
        }
        #endregion d_region
        
        
        protected string n_sD_floor=global::System.String.Empty;
        #region d_floor
        [System.Data.Linq.Mapping.Column(Name="[d_floor]", Storage="n_sD_floor")]
        public string d_floor{
            get{
                return this.n_sD_floor;
            }
            set{
                this.n_sD_floor=value;
            }
        }
        #endregion d_floor
        
        
        protected string n_sD_room=global::System.String.Empty;
        #region d_room
        [System.Data.Linq.Mapping.Column(Name="[d_room]", Storage="n_sD_room")]
        public string d_room{
            get{
                return this.n_sD_room;
            }
            set{
                this.n_sD_room=value;
            }
        }
        #endregion d_room
        
        
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
        
        
        private MobileRetentionOrder n_oMobileRetentionOrderMobileOrderAddress=null;
        #region MobileRetentionOrderMobileOrderAddress    Primary Key Table
        public MobileRetentionOrder MobileRetentionOrderMobileOrderAddress{
            get{
                if(n_oMobileRetentionOrderMobileOrderAddress==null){
                    if (n_iOrder_id == null) { 
                        n_oMobileRetentionOrderMobileOrderAddress=new MobileRetentionOrder();
                        return n_oMobileRetentionOrderMobileOrderAddress;
                    }
                    n_oMobileRetentionOrderMobileOrderAddress = (MobileRetentionOrder)MobileRetentionOrderRepository.GetObj(this.n_oDB, this.n_iOrder_id);
                    if(n_oMobileRetentionOrderMobileOrderAddress==null){
                        n_oMobileRetentionOrderMobileOrderAddress=new MobileRetentionOrder(this.n_oDB);
                        n_oMobileRetentionOrderMobileOrderAddress.SetOrder_id(this.n_iOrder_id);
                    }
                }
                else if(n_oMobileRetentionOrderMobileOrderAddress.order_id!=this.n_iOrder_id)
                {
                    n_oMobileRetentionOrderMobileOrderAddress = (MobileRetentionOrder)MobileRetentionOrderRepository.GetObj(this.n_oDB, this.n_iOrder_id);
                    if (n_oMobileRetentionOrderMobileOrderAddress == null)
                    {
                        n_oMobileRetentionOrderMobileOrderAddress=new MobileRetentionOrder(this.n_oDB);
                        n_oMobileRetentionOrderMobileOrderAddress.SetOrder_id(this.n_iOrder_id);
                    }
                }
                return n_oMobileRetentionOrderMobileOrderAddress;
            }
            set{
                if (value == null)
                {
                    n_oMobileRetentionOrderMobileOrderAddress = new MobileRetentionOrder(this.n_oDB);
                }
                else
                {
                    this.n_oMobileRetentionOrderMobileOrderAddress = value;
                }
                n_oMobileRetentionOrderMobileOrderAddress.SetOrder_id(this.n_iOrder_id);
            }
        }
        
        private global::System.Data.DataSet n_oMobileRetentionOrderMobileOrderAddressDataSet = null;
        #region MobileRetentionOrderMobileOrderAddressDataSet    Primary Key Table DataSet
        public global::System.Data.DataSet MobileRetentionOrderMobileOrderAddressDataSet
        {
            get
            {
                MobileRetentionOrderBal _oMobileRetentionOrderBal = new MobileRetentionOrderBal();
                bool _bGetDataSet = false;
                if (n_oMobileRetentionOrderMobileOrderAddressDataSet == null)
                {
                    if (n_iOrder_id == null) { 
                        n_oMobileRetentionOrderMobileOrderAddressDataSet= MobileRetentionOrderBal.ToEmptyDataSet();
                        return n_oMobileRetentionOrderMobileOrderAddressDataSet;
                    }
                    _bGetDataSet = true;
                }
                if(n_oMobileRetentionOrderMobileOrderAddressDataSet!=null){
                    if (n_oMobileRetentionOrderMobileOrderAddressDataSet.Tables.Contains(MobileRetentionOrder.Para.TableName())){
                        if (n_oMobileRetentionOrderMobileOrderAddressDataSet.Tables[MobileRetentionOrder.Para.TableName()].Rows.Count == 0){ _bGetDataSet = true; }
                    }
                }
                if (_bGetDataSet){
                    n_oMobileRetentionOrderMobileOrderAddressDataSet = MobileRetentionOrderRepository.GetDataSet(n_oDB, "order_id="+n_iOrder_id);
                    if (n_oMobileRetentionOrderMobileOrderAddressDataSet == null)
                    {
                        n_oMobileRetentionOrderMobileOrderAddressDataSet = MobileRetentionOrderBal.ToEmptyDataSet();
                    }
                }
                return n_oMobileRetentionOrderMobileOrderAddressDataSet;
            }
            set
            {
                n_oMobileRetentionOrderMobileOrderAddressDataSet = value;
            }
        }
        
        #endregion MobileRetentionOrderMobileOrderAddressDataSet
        #endregion MobileRetentionOrderMobileOrderAddress
        
        
        protected string n_sAddress_type=global::System.String.Empty;
        #region address_type
        [System.Data.Linq.Mapping.Column(Name="[address_type]", Storage="n_sAddress_type")]
        public string address_type{
            get{
                return this.n_sAddress_type;
            }
            set{
                this.n_sAddress_type=value;
            }
        }
        #endregion address_type
        
        
        protected string n_sD_type=global::System.String.Empty;
        #region d_type
        [System.Data.Linq.Mapping.Column(Name="[d_type]", Storage="n_sD_type")]
        public string d_type{
            get{
                return this.n_sD_type;
            }
            set{
                this.n_sD_type=value;
            }
        }
        #endregion d_type
        
        
        protected global::System.Nullable<long> n_lAddress_id=null;
        #region address_id
        [System.Data.Linq.Mapping.Column(Name="[address_id]", Storage="n_lAddress_id")]
        public global::System.Nullable<long> address_id{
            get{
                return this.n_lAddress_id;
            }
            set{
                this.n_lAddress_id=value;
            }
        }
        #endregion address_id
        
        
        protected string n_sD_blk=global::System.String.Empty;
        #region d_blk
        [System.Data.Linq.Mapping.Column(Name="[d_blk]", Storage="n_sD_blk")]
        public string d_blk{
            get{
                return this.n_sD_blk;
            }
            set{
                this.n_sD_blk=value;
            }
        }
        #endregion d_blk
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private MobileOrderAddressInfo n_oTableSet = MobileOrderAddressInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string d_street="d_street";
            public const string address_id="address_id";
            public const string d_region="d_region";
            public const string d_floor="d_floor";
            public const string d_build="d_build";
            public const string d_room="d_room";
            public const string order_id="order_id";
            public const string address_type="address_type";
            public const string d_type="d_type";
            public const string d_district="d_district";
            public const string d_blk="d_blk";
            public const string MobileOrderAddress_table_name="MobileOrderAddress";
            public static string TableName() { return MobileOrderAddress_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public MobileOrderAddressEntity(){
            Init();
        }
        public MobileOrderAddressEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public MobileOrderAddressEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iOrder_id,string x_sAddress_type){
            n_oDB=x_oDB;
            this.Load(x_iOrder_id,x_sAddress_type);
            Init();
        }
        
        public MobileOrderAddressEntity(MSSQLConnect x_oDB,global::System.Nullable<long> x_lAddress_id){
            n_oDB=x_oDB;
            this.Load(x_lAddress_id);
            Init();
        }
        
        ~MobileOrderAddressEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iOrder_id,string x_sAddress_type){
            if (n_oDB==null) { return false; }
            if (x_iOrder_id==null) { return false; }
            if (x_sAddress_type==null) { return false; }
            string _sQuery = "SELECT   [MobileOrderAddress].[d_build] AS MOBILEORDERADDRESS_D_BUILD,[MobileOrderAddress].[d_street] AS MOBILEORDERADDRESS_D_STREET,[MobileOrderAddress].[d_district] AS MOBILEORDERADDRESS_D_DISTRICT,[MobileOrderAddress].[d_region] AS MOBILEORDERADDRESS_D_REGION,[MobileOrderAddress].[d_floor] AS MOBILEORDERADDRESS_D_FLOOR,[MobileOrderAddress].[d_room] AS MOBILEORDERADDRESS_D_ROOM,[MobileOrderAddress].[order_id] AS MOBILEORDERADDRESS_ORDER_ID,[MobileOrderAddress].[address_type] AS MOBILEORDERADDRESS_ADDRESS_TYPE,[MobileOrderAddress].[d_type] AS MOBILEORDERADDRESS_D_TYPE,[MobileOrderAddress].[address_id] AS MOBILEORDERADDRESS_ADDRESS_ID,[MobileOrderAddress].[d_blk] AS MOBILEORDERADDRESS_D_BLK  FROM  [MobileOrderAddress]  WHERE  [MobileOrderAddress].[order_id] = \'"+x_iOrder_id.ToString()+"\'  AND  [MobileOrderAddress].[address_type] = \'"+x_sAddress_type.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderAddress]","["+ Configurator.MSSQLTablePrefix + "MobileOrderAddress]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_BUILD"])) {n_sD_build = (string)_oData["MOBILEORDERADDRESS_D_BUILD"];}else{n_sD_build=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_STREET"])) {n_sD_street = (string)_oData["MOBILEORDERADDRESS_D_STREET"];}else{n_sD_street=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_DISTRICT"])) {n_sD_district = (string)_oData["MOBILEORDERADDRESS_D_DISTRICT"];}else{n_sD_district=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_REGION"])) {n_sD_region = (string)_oData["MOBILEORDERADDRESS_D_REGION"];}else{n_sD_region=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_FLOOR"])) {n_sD_floor = (string)_oData["MOBILEORDERADDRESS_D_FLOOR"];}else{n_sD_floor=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_ROOM"])) {n_sD_room = (string)_oData["MOBILEORDERADDRESS_D_ROOM"];}else{n_sD_room=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_ORDER_ID"])) {n_iOrder_id = (global::System.Nullable<int>)_oData["MOBILEORDERADDRESS_ORDER_ID"];}else{n_iOrder_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_ADDRESS_TYPE"])) {n_sAddress_type = (string)_oData["MOBILEORDERADDRESS_ADDRESS_TYPE"];}else{n_sAddress_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_TYPE"])) {n_sD_type = (string)_oData["MOBILEORDERADDRESS_D_TYPE"];}else{n_sD_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_ADDRESS_ID"])) {n_lAddress_id = (global::System.Nullable<long>)_oData["MOBILEORDERADDRESS_ADDRESS_ID"];}else{n_lAddress_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_BLK"])) {n_sD_blk = (string)_oData["MOBILEORDERADDRESS_D_BLK"];}else{n_sD_blk=global::System.String.Empty;}
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
        
        public bool Load(global::System.Nullable<long> x_lAddress_id){
            if (n_oDB==null) { return false; }
            if (x_lAddress_id==null) { return false; }
            string _sQuery = "SELECT   [MobileOrderAddress].[d_build] AS MOBILEORDERADDRESS_D_BUILD,[MobileOrderAddress].[d_street] AS MOBILEORDERADDRESS_D_STREET,[MobileOrderAddress].[d_district] AS MOBILEORDERADDRESS_D_DISTRICT,[MobileOrderAddress].[d_region] AS MOBILEORDERADDRESS_D_REGION,[MobileOrderAddress].[d_floor] AS MOBILEORDERADDRESS_D_FLOOR,[MobileOrderAddress].[d_room] AS MOBILEORDERADDRESS_D_ROOM,[MobileOrderAddress].[order_id] AS MOBILEORDERADDRESS_ORDER_ID,[MobileOrderAddress].[address_type] AS MOBILEORDERADDRESS_ADDRESS_TYPE,[MobileOrderAddress].[d_type] AS MOBILEORDERADDRESS_D_TYPE,[MobileOrderAddress].[address_id] AS MOBILEORDERADDRESS_ADDRESS_ID,[MobileOrderAddress].[d_blk] AS MOBILEORDERADDRESS_D_BLK  FROM  [MobileOrderAddress]  WHERE  [MobileOrderAddress].[address_id] = \'"+x_lAddress_id.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderAddress]","["+ Configurator.MSSQLTablePrefix + "MobileOrderAddress]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_BUILD"])) {n_sD_build = (string)_oData["MOBILEORDERADDRESS_D_BUILD"];}else{n_sD_build=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_STREET"])) {n_sD_street = (string)_oData["MOBILEORDERADDRESS_D_STREET"];}else{n_sD_street=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_DISTRICT"])) {n_sD_district = (string)_oData["MOBILEORDERADDRESS_D_DISTRICT"];}else{n_sD_district=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_REGION"])) {n_sD_region = (string)_oData["MOBILEORDERADDRESS_D_REGION"];}else{n_sD_region=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_FLOOR"])) {n_sD_floor = (string)_oData["MOBILEORDERADDRESS_D_FLOOR"];}else{n_sD_floor=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_ROOM"])) {n_sD_room = (string)_oData["MOBILEORDERADDRESS_D_ROOM"];}else{n_sD_room=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_ORDER_ID"])) {n_iOrder_id = (global::System.Nullable<int>)_oData["MOBILEORDERADDRESS_ORDER_ID"];}else{n_iOrder_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_ADDRESS_TYPE"])) {n_sAddress_type = (string)_oData["MOBILEORDERADDRESS_ADDRESS_TYPE"];}else{n_sAddress_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_TYPE"])) {n_sD_type = (string)_oData["MOBILEORDERADDRESS_D_TYPE"];}else{n_sD_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_ADDRESS_ID"])) {n_lAddress_id = (global::System.Nullable<long>)_oData["MOBILEORDERADDRESS_ADDRESS_ID"];}else{n_lAddress_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_BLK"])) {n_sD_blk = (string)_oData["MOBILEORDERADDRESS_D_BLK"];}else{n_sD_blk=global::System.String.Empty;}
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
            if (n_sD_build==null && !(n_oTableSet.Fields(Para.d_build).IsNullable)) return false;
            if (n_sD_street==null && !(n_oTableSet.Fields(Para.d_street).IsNullable)) return false;
            if (n_sD_district==null && !(n_oTableSet.Fields(Para.d_district).IsNullable)) return false;
            if (n_sD_region==null && !(n_oTableSet.Fields(Para.d_region).IsNullable)) return false;
            if (n_sD_floor==null && !(n_oTableSet.Fields(Para.d_floor).IsNullable)) return false;
            if (n_sD_room==null && !(n_oTableSet.Fields(Para.d_room).IsNullable)) return false;
            if (n_iOrder_id==null && !(n_oTableSet.Fields(Para.order_id).IsNullable)) return false;
            if (n_sAddress_type==null && !(n_oTableSet.Fields(Para.address_type).IsNullable)) return false;
            if (n_sD_type==null && !(n_oTableSet.Fields(Para.d_type).IsNullable)) return false;
            if(!x_bInsert){
                if (n_lAddress_id==null && !(n_oTableSet.Fields(Para.address_id).IsNullable)) return false;
            }
            if (n_sD_blk==null && !(n_oTableSet.Fields(Para.d_blk).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(MobileOrderAddressEntity)) || (x_oObj is MobileOrderAddressEntity)) return MobileOrderAddressRepository.Instance();
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
        public MobileOrderAddressInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(MobileOrderAddressInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public string GetD_street(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.d_street)) { return string.Empty; }
            return this.d_street;
        }
        public global::System.Nullable<long> GetAddress_id(){return this.address_id;}
        public string GetD_region(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.d_region)) { return string.Empty; }
            return this.d_region;
        }
        public string GetD_floor(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.d_floor)) { return string.Empty; }
            return this.d_floor;
        }
        public string GetD_build(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.d_build)) { return string.Empty; }
            return this.d_build;
        }
        public string GetD_room(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.d_room)) { return string.Empty; }
            return this.d_room;
        }
        public global::System.Nullable<int> GetOrder_id(){return this.order_id;}
        public string GetAddress_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.address_type)) { return string.Empty; }
            return this.address_type;
        }
        public string GetD_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.d_type)) { return string.Empty; }
            return this.d_type;
        }
        public string GetD_district(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.d_district)) { return string.Empty; }
            return this.d_district;
        }
        public string GetD_blk(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.d_blk)) { return string.Empty; }
            return this.d_blk;
        }
        
        public bool SetD_street(string value){
            this.d_street=value;
            return true;
        }
        public bool SetAddress_id(global::System.Nullable<long> value){
            this.address_id=value;
            return true;
        }
        public bool SetD_region(string value){
            this.d_region=value;
            return true;
        }
        public bool SetD_floor(string value){
            this.d_floor=value;
            return true;
        }
        public bool SetD_build(string value){
            this.d_build=value;
            return true;
        }
        public bool SetD_room(string value){
            this.d_room=value;
            return true;
        }
        public bool SetOrder_id(global::System.Nullable<int> value){
            this.order_id=value;
            return true;
        }
        public bool SetAddress_type(string value){
            this.address_type=value;
            return true;
        }
        public bool SetD_type(string value){
            this.d_type=value;
            return true;
        }
        public bool SetD_district(string value){
            this.d_district=value;
            return true;
        }
        public bool SetD_blk(string value){
            this.d_blk=value;
            return true;
        }
        
        public Field GetD_streetTable(){
            return n_oTableSet.Fields(Para.d_street);
        }
        public Field GetAddress_idTable(){
            return n_oTableSet.Fields(Para.address_id);
        }
        public Field GetD_regionTable(){
            return n_oTableSet.Fields(Para.d_region);
        }
        public Field GetD_floorTable(){
            return n_oTableSet.Fields(Para.d_floor);
        }
        public Field GetD_buildTable(){
            return n_oTableSet.Fields(Para.d_build);
        }
        public Field GetD_roomTable(){
            return n_oTableSet.Fields(Para.d_room);
        }
        public Field GetOrder_idTable(){
            return n_oTableSet.Fields(Para.order_id);
        }
        public Field GetAddress_typeTable(){
            return n_oTableSet.Fields(Para.address_type);
        }
        public Field GetD_typeTable(){
            return n_oTableSet.Fields(Para.d_type);
        }
        public Field GetD_districtTable(){
            return n_oTableSet.Fields(Para.d_district);
        }
        public Field GetD_blkTable(){
            return n_oTableSet.Fields(Para.d_blk);
        }
        #endregion
        
        #region Addtional Get & Set
        public MobileRetentionOrder GetMobileRetentionOrderMobileOrderAddress() {
            return MobileRetentionOrderMobileOrderAddress;
        }
        
        public bool SetMobileRetentionOrderMobileOrderAddress(MobileRetentionOrder value) {
            MobileRetentionOrderMobileOrderAddress = value;
            return true;
        }
        
        public global::System.Data.DataSet GetMobileRetentionOrderMobileOrderAddressDataSet(){
            return MobileRetentionOrderMobileOrderAddressDataSet;
        }
        
        public bool SetMobileRetentionOrderMobileOrderAddressDataSet(global::System.Data.DataSet value) {
            MobileRetentionOrderMobileOrderAddressDataSet = value;
            return true;
        }
        
        
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
        
        public bool EqualID(MobileOrderAddress x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_lAddress_id.Equals(x_oObj.address_id)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(MobileOrderAddress x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_sD_build.Equals(x_oObj.d_build)){ return false; }
            if(!this.n_sD_street.Equals(x_oObj.d_street)){ return false; }
            if(!this.n_sD_district.Equals(x_oObj.d_district)){ return false; }
            if(!this.n_sD_region.Equals(x_oObj.d_region)){ return false; }
            if(!this.n_sD_floor.Equals(x_oObj.d_floor)){ return false; }
            if(!this.n_sD_room.Equals(x_oObj.d_room)){ return false; }
            if(!this.n_iOrder_id.Equals(x_oObj.order_id)){ return false; }
            if(!this.n_sAddress_type.Equals(x_oObj.address_type)){ return false; }
            if(!this.n_sD_type.Equals(x_oObj.d_type)){ return false; }
            if(!this.n_lAddress_id.Equals(x_oObj.address_id)){ return false; }
            if(!this.n_sD_blk.Equals(x_oObj.d_blk)){ return false; }
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
            if(!n_iOrder_id.Equals(null) && !n_sAddress_type.Equals(global::System.String.Empty)){
                _bResult=this.Load(n_iOrder_id,n_sAddress_type);
                if(_bResult){ return _bResult;}
            }
            if(!n_lAddress_id.Equals(null)){
                _bResult=this.Load(n_lAddress_id);
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
            if (n_lAddress_id==null) { return false; }
            if(!Vaild(false)){ return false; }
            string _sQuery = "UPDATE  [MobileOrderAddress]  SET  [d_build]=@d_build,[d_street]=@d_street,[d_district]=@d_district,[d_region]=@d_region,[d_floor]=@d_floor,[d_room]=@d_room,[order_id]=@order_id,[address_type]=@address_type,[d_type]=@d_type,[d_blk]=@d_blk  WHERE [MobileOrderAddress].[address_id]=@address_id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderAddress]","["+ Configurator.MSSQLTablePrefix + "MobileOrderAddress]"); }
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
            if(n_sD_build==null){  _oCmd.Parameters.Add("@d_build", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@d_build", global::System.Data.SqlDbType.NVarChar,250).Value=n_sD_build; }
            if(n_sD_street==null){  _oCmd.Parameters.Add("@d_street", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@d_street", global::System.Data.SqlDbType.NVarChar,250).Value=n_sD_street; }
            if(n_sD_district==null){  _oCmd.Parameters.Add("@d_district", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@d_district", global::System.Data.SqlDbType.NVarChar,250).Value=n_sD_district; }
            if(n_sD_region==null){  _oCmd.Parameters.Add("@d_region", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@d_region", global::System.Data.SqlDbType.NVarChar,50).Value=n_sD_region; }
            if(n_sD_floor==null){  _oCmd.Parameters.Add("@d_floor", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@d_floor", global::System.Data.SqlDbType.NVarChar,50).Value=n_sD_floor; }
            if(n_sD_room==null){  _oCmd.Parameters.Add("@d_room", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@d_room", global::System.Data.SqlDbType.NVarChar,50).Value=n_sD_room; }
            if(n_iOrder_id==null){  _oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=n_iOrder_id; }
            if(n_sAddress_type==null){  _oCmd.Parameters.Add("@address_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@address_type", global::System.Data.SqlDbType.NVarChar,50).Value=n_sAddress_type; }
            if(n_sD_type==null){  _oCmd.Parameters.Add("@d_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@d_type", global::System.Data.SqlDbType.NVarChar,50).Value=n_sD_type; }
            if(n_lAddress_id==null){  _oCmd.Parameters.Add("@address_id", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@address_id", global::System.Data.SqlDbType.BigInt).Value=n_lAddress_id; }
            if(n_sD_blk==null){  _oCmd.Parameters.Add("@d_blk", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@d_blk", global::System.Data.SqlDbType.NVarChar,50).Value=n_sD_blk; }
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
        /// Summary description for table [MobileOrderAddress] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_lAddress_id==null) { return false; }
            string _sQuery="DELETE FROM  [MobileOrderAddress]  WHERE [MobileOrderAddress].[address_id]=@address_id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderAddress]","["+ Configurator.MSSQLTablePrefix + "MobileOrderAddress]"); }
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
            _oCmd.Parameters.Add("@address_id", global::System.Data.SqlDbType.BigInt).Value = n_lAddress_id;
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
        /// Summary description for table [MobileOrderAddress] Object Base Clone
        /// </summary>
        
        public MobileOrderAddress DeepClone()
        {
            MobileOrderAddress _oMobileOrderAddress_Clone = new MobileOrderAddress();
            _oMobileOrderAddress_Clone.d_build = this.n_sD_build;
            _oMobileOrderAddress_Clone.d_street = this.n_sD_street;
            _oMobileOrderAddress_Clone.d_district = this.n_sD_district;
            _oMobileOrderAddress_Clone.d_region = this.n_sD_region;
            _oMobileOrderAddress_Clone.d_floor = this.n_sD_floor;
            _oMobileOrderAddress_Clone.d_room = this.n_sD_room;
            _oMobileOrderAddress_Clone.order_id = this.n_iOrder_id;
            _oMobileOrderAddress_Clone.address_type = this.n_sAddress_type;
            _oMobileOrderAddress_Clone.d_type = this.n_sD_type;
            _oMobileOrderAddress_Clone.address_id = this.n_lAddress_id;
            _oMobileOrderAddress_Clone.d_blk = this.n_sD_blk;
            _oMobileOrderAddress_Clone.SetFound(this.n_bFound);
            _oMobileOrderAddress_Clone.SetDB(this.n_oDB);
            _oMobileOrderAddress_Clone.SetRow(this.n_oRow);
            _oMobileOrderAddress_Clone.SetTbl(this.n_oTbl);
            _oMobileOrderAddress_Clone.SetTableSet(this.n_oTableSet);
            MobileRetentionOrderMobileOrderAddress=null;
            _oMobileOrderAddress_Clone.MobileRetentionOrderMobileOrderAddress = this.MobileRetentionOrderMobileOrderAddress.DeepClone();
            
            return _oMobileOrderAddress_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_sD_build=global::System.String.Empty;
            n_sD_street=global::System.String.Empty;
            n_sD_district=global::System.String.Empty;
            n_sD_region=global::System.String.Empty;
            n_sD_floor=global::System.String.Empty;
            n_sD_room=global::System.String.Empty;
            n_iOrder_id=null;
            n_sAddress_type=global::System.String.Empty;
            n_sD_type=global::System.String.Empty;
            n_lAddress_id=null;
            n_sD_blk=global::System.String.Empty;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = MobileOrderAddressInfoDLL.CreateInfoInstanceObject();
            n_oMobileRetentionOrderMobileOrderAddress=null;
        }
        #endregion
    }
}


