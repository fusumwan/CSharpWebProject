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
///-- Create date: <Create Date 2011-03-08>
///-- Description:	<Description,Table :[MobileOrderMNPDetail],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [MobileOrderMNPDetail] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"MobileOrderMNPDetail")]
    public class MobileOrderMNPDetailEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        
        protected string n_sService_activation_time=global::System.String.Empty;
        #region service_activation_time
        [System.Data.Linq.Mapping.Column(Name="[service_activation_time]", Storage="n_sService_activation_time")]
        public string service_activation_time{
            get{
                return this.n_sService_activation_time;
            }
            set{
                this.n_sService_activation_time=value;
            }
        }
        #endregion service_activation_time
        
        
        protected string n_sTicker_number=global::System.String.Empty;
        #region ticker_number
        [System.Data.Linq.Mapping.Column(Name="[ticker_number]", Storage="n_sTicker_number")]
        public string ticker_number{
            get{
                return this.n_sTicker_number;
            }
            set{
                this.n_sTicker_number=value;
            }
        }
        #endregion ticker_number
        
        
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
        
        
        protected global::System.Nullable<long> n_lTransfer_idd_roaming_deposit=null;
        #region transfer_idd_roaming_deposit
        [System.Data.Linq.Mapping.Column(Name="[transfer_idd_roaming_deposit]", Storage="n_lTransfer_idd_roaming_deposit")]
        public global::System.Nullable<long> transfer_idd_roaming_deposit{
            get{
                return this.n_lTransfer_idd_roaming_deposit;
            }
            set{
                this.n_lTransfer_idd_roaming_deposit=value;
            }
        }
        #endregion transfer_idd_roaming_deposit
        
        
        protected global::System.Nullable<long> n_lTransfer_idd_deposit=null;
        #region transfer_idd_deposit
        [System.Data.Linq.Mapping.Column(Name="[transfer_idd_deposit]", Storage="n_lTransfer_idd_deposit")]
        public global::System.Nullable<long> transfer_idd_deposit{
            get{
                return this.n_lTransfer_idd_deposit;
            }
            set{
                this.n_lTransfer_idd_deposit=value;
            }
        }
        #endregion transfer_idd_deposit
        
        
        protected global::System.Nullable<DateTime> n_dService_activation_date=null;
        #region service_activation_date
        [System.Data.Linq.Mapping.Column(Name="[service_activation_date]", Storage="n_dService_activation_date")]
        public global::System.Nullable<DateTime> service_activation_date{
            get{
                return this.n_dService_activation_date;
            }
            set{
                this.n_dService_activation_date=value;
            }
        }
        #endregion service_activation_date
        
        
        protected global::System.Nullable<long> n_lMnp_id=null;
        #region mnp_id
        [System.Data.Linq.Mapping.Column(Name="[mnp_id]", Storage="n_lMnp_id")]
        public global::System.Nullable<long> mnp_id{
            get{
                return this.n_lMnp_id;
            }
            set{
                this.n_lMnp_id=value;
            }
        }
        #endregion mnp_id
        
        
        protected global::System.Nullable<long> n_lTransfer_others_deposit=null;
        #region transfer_others_deposit
        [System.Data.Linq.Mapping.Column(Name="[transfer_others_deposit]", Storage="n_lTransfer_others_deposit")]
        public global::System.Nullable<long> transfer_others_deposit{
            get{
                return this.n_lTransfer_others_deposit;
            }
            set{
                this.n_lTransfer_others_deposit=value;
            }
        }
        #endregion transfer_others_deposit
        
        
        protected string n_sRegistered_name=global::System.String.Empty;
        #region registered_name
        [System.Data.Linq.Mapping.Column(Name="[registered_name]", Storage="n_sRegistered_name")]
        public string registered_name{
            get{
                return this.n_sRegistered_name;
            }
            set{
                this.n_sRegistered_name=value;
            }
        }
        #endregion registered_name
        
        
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
        
        
        protected global::System.Nullable<bool> n_bTransfer_to_3g=null;
        #region transfer_to_3g
        [System.Data.Linq.Mapping.Column(Name="[transfer_to_3g]", Storage="n_bTransfer_to_3g")]
        public global::System.Nullable<bool> transfer_to_3g{
            get{
                return this.n_bTransfer_to_3g;
            }
            set{
                this.n_bTransfer_to_3g=value;
            }
        }
        #endregion transfer_to_3g
        
        
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
        
        
        private MobileRetentionOrder n_oMobileRetentionOrderMobileOrderMNPDetail=null;
        #region MobileRetentionOrderMobileOrderMNPDetail    Primary Key Table
        public MobileRetentionOrder MobileRetentionOrderMobileOrderMNPDetail{
            get{
                if(n_oMobileRetentionOrderMobileOrderMNPDetail==null){
                    if (n_iOrder_id == null) { 
                        n_oMobileRetentionOrderMobileOrderMNPDetail=new MobileRetentionOrder();
                        return n_oMobileRetentionOrderMobileOrderMNPDetail;
                    }
                    n_oMobileRetentionOrderMobileOrderMNPDetail = (MobileRetentionOrder)MobileRetentionOrderRepository.GetObj(this.n_oDB, this.n_iOrder_id);
                    if(n_oMobileRetentionOrderMobileOrderMNPDetail==null){
                        n_oMobileRetentionOrderMobileOrderMNPDetail=new MobileRetentionOrder(this.n_oDB);
                        n_oMobileRetentionOrderMobileOrderMNPDetail.SetOrder_id(this.n_iOrder_id);
                    }
                }
                else if(n_oMobileRetentionOrderMobileOrderMNPDetail.order_id!=this.n_iOrder_id)
                {
                    n_oMobileRetentionOrderMobileOrderMNPDetail = (MobileRetentionOrder)MobileRetentionOrderRepository.GetObj(this.n_oDB, this.n_iOrder_id);
                    if (n_oMobileRetentionOrderMobileOrderMNPDetail == null)
                    {
                        n_oMobileRetentionOrderMobileOrderMNPDetail=new MobileRetentionOrder(this.n_oDB);
                        n_oMobileRetentionOrderMobileOrderMNPDetail.SetOrder_id(this.n_iOrder_id);
                    }
                }
                return n_oMobileRetentionOrderMobileOrderMNPDetail;
            }
            set{
                if (value == null)
                {
                    n_oMobileRetentionOrderMobileOrderMNPDetail = new MobileRetentionOrder(this.n_oDB);
                }
                else
                {
                    this.n_oMobileRetentionOrderMobileOrderMNPDetail = value;
                }
                n_oMobileRetentionOrderMobileOrderMNPDetail.SetOrder_id(this.n_iOrder_id);
            }
        }
        
        private global::System.Data.DataSet n_oMobileRetentionOrderMobileOrderMNPDetailDataSet = null;
        #region MobileRetentionOrderMobileOrderMNPDetailDataSet    Primary Key Table DataSet
        public global::System.Data.DataSet MobileRetentionOrderMobileOrderMNPDetailDataSet
        {
            get
            {
                MobileRetentionOrderBal _oMobileRetentionOrderBal = new MobileRetentionOrderBal();
                bool _bGetDataSet = false;
                if (n_oMobileRetentionOrderMobileOrderMNPDetailDataSet == null)
                {
                    if (n_iOrder_id == null) { 
                        n_oMobileRetentionOrderMobileOrderMNPDetailDataSet= MobileRetentionOrderBal.ToEmptyDataSet();
                        return n_oMobileRetentionOrderMobileOrderMNPDetailDataSet;
                    }
                    _bGetDataSet = true;
                }
                if(n_oMobileRetentionOrderMobileOrderMNPDetailDataSet!=null){
                    if (n_oMobileRetentionOrderMobileOrderMNPDetailDataSet.Tables.Contains(MobileRetentionOrder.Para.TableName())){
                        if (n_oMobileRetentionOrderMobileOrderMNPDetailDataSet.Tables[MobileRetentionOrder.Para.TableName()].Rows.Count == 0){ _bGetDataSet = true; }
                    }
                }
                if (_bGetDataSet){
                    n_oMobileRetentionOrderMobileOrderMNPDetailDataSet = MobileRetentionOrderRepository.GetDataSet(n_oDB, "order_id="+n_iOrder_id);
                    if (n_oMobileRetentionOrderMobileOrderMNPDetailDataSet == null)
                    {
                        n_oMobileRetentionOrderMobileOrderMNPDetailDataSet = MobileRetentionOrderBal.ToEmptyDataSet();
                    }
                }
                return n_oMobileRetentionOrderMobileOrderMNPDetailDataSet;
            }
            set
            {
                n_oMobileRetentionOrderMobileOrderMNPDetailDataSet = value;
            }
        }
        
        #endregion MobileRetentionOrderMobileOrderMNPDetailDataSet
        #endregion MobileRetentionOrderMobileOrderMNPDetail
        
        
        protected global::System.Nullable<long> n_lTransfer_no_add_proof_deposit=null;
        #region transfer_no_add_proof_deposit
        [System.Data.Linq.Mapping.Column(Name="[transfer_no_add_proof_deposit]", Storage="n_lTransfer_no_add_proof_deposit")]
        public global::System.Nullable<long> transfer_no_add_proof_deposit{
            get{
                return this.n_lTransfer_no_add_proof_deposit;
            }
            set{
                this.n_lTransfer_no_add_proof_deposit=value;
            }
        }
        #endregion transfer_no_add_proof_deposit
        
        
        protected string n_sCompany_name=global::System.String.Empty;
        #region company_name
        [System.Data.Linq.Mapping.Column(Name="[company_name]", Storage="n_sCompany_name")]
        public string company_name{
            get{
                return this.n_sCompany_name;
            }
            set{
                this.n_sCompany_name=value;
            }
        }
        #endregion company_name
        
        
        protected global::System.Nullable<long> n_lTransfer_no_hk_id_holder_deposit=null;
        #region transfer_no_hk_id_holder_deposit
        [System.Data.Linq.Mapping.Column(Name="[transfer_no_hk_id_holder_deposit]", Storage="n_lTransfer_no_hk_id_holder_deposit")]
        public global::System.Nullable<long> transfer_no_hk_id_holder_deposit{
            get{
                return this.n_lTransfer_no_hk_id_holder_deposit;
            }
            set{
                this.n_lTransfer_no_hk_id_holder_deposit=value;
            }
        }
        #endregion transfer_no_hk_id_holder_deposit
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private MobileOrderMNPDetailInfo n_oTableSet = MobileOrderMNPDetailInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string service_activation_time="service_activation_time";
            public const string ticker_number="ticker_number";
            public const string id_type="id_type";
            public const string transfer_idd_roaming_deposit="transfer_idd_roaming_deposit";
            public const string company_name="company_name";
            public const string service_activation_date="service_activation_date";
            public const string mnp_id="mnp_id";
            public const string transfer_others_deposit="transfer_others_deposit";
            public const string hkid="hkid";
            public const string transfer_to_3g="transfer_to_3g";
            public const string transfer_idd_deposit="transfer_idd_deposit";
            public const string transfer_no_add_proof_deposit="transfer_no_add_proof_deposit";
            public const string order_id="order_id";
            public const string registered_name="registered_name";
            public const string transfer_no_hk_id_holder_deposit="transfer_no_hk_id_holder_deposit";
            public const string MobileOrderMNPDetail_table_name="MobileOrderMNPDetail";
            public static string TableName() { return MobileOrderMNPDetail_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public MobileOrderMNPDetailEntity(){
            Init();
        }
        public MobileOrderMNPDetailEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public MobileOrderMNPDetailEntity(MSSQLConnect x_oDB,global::System.Nullable<long> x_lMnp_id){
            n_oDB=x_oDB;
            this.Load(x_lMnp_id);
            Init();
        }
        
        ~MobileOrderMNPDetailEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<long> x_lMnp_id){
            if (n_oDB==null) { return false; }
            if (x_lMnp_id==null) { return false; }
            string _sQuery = "SELECT   [MobileOrderMNPDetail].[service_activation_time] AS MOBILEORDERMNPDETAIL_SERVICE_ACTIVATION_TIME,[MobileOrderMNPDetail].[ticker_number] AS MOBILEORDERMNPDETAIL_TICKER_NUMBER,[MobileOrderMNPDetail].[id_type] AS MOBILEORDERMNPDETAIL_ID_TYPE,[MobileOrderMNPDetail].[transfer_idd_roaming_deposit] AS MOBILEORDERMNPDETAIL_TRANSFER_IDD_ROAMING_DEPOSIT,[MobileOrderMNPDetail].[transfer_idd_deposit] AS MOBILEORDERMNPDETAIL_TRANSFER_IDD_DEPOSIT,[MobileOrderMNPDetail].[service_activation_date] AS MOBILEORDERMNPDETAIL_SERVICE_ACTIVATION_DATE,[MobileOrderMNPDetail].[mnp_id] AS MOBILEORDERMNPDETAIL_MNP_ID,[MobileOrderMNPDetail].[transfer_others_deposit] AS MOBILEORDERMNPDETAIL_TRANSFER_OTHERS_DEPOSIT,[MobileOrderMNPDetail].[registered_name] AS MOBILEORDERMNPDETAIL_REGISTERED_NAME,[MobileOrderMNPDetail].[hkid] AS MOBILEORDERMNPDETAIL_HKID,[MobileOrderMNPDetail].[transfer_to_3g] AS MOBILEORDERMNPDETAIL_TRANSFER_TO_3G,[MobileOrderMNPDetail].[order_id] AS MOBILEORDERMNPDETAIL_ORDER_ID,[MobileOrderMNPDetail].[transfer_no_add_proof_deposit] AS MOBILEORDERMNPDETAIL_TRANSFER_NO_ADD_PROOF_DEPOSIT,[MobileOrderMNPDetail].[company_name] AS MOBILEORDERMNPDETAIL_COMPANY_NAME,[MobileOrderMNPDetail].[transfer_no_hk_id_holder_deposit] AS MOBILEORDERMNPDETAIL_TRANSFER_NO_HK_ID_HOLDER_DEPOSIT  FROM  [MobileOrderMNPDetail]  WHERE  [MobileOrderMNPDetail].[mnp_id] = \'"+x_lMnp_id.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMNPDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMNPDetail]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_SERVICE_ACTIVATION_TIME"])) {n_sService_activation_time = (string)_oData["MOBILEORDERMNPDETAIL_SERVICE_ACTIVATION_TIME"];}else{n_sService_activation_time=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_TICKER_NUMBER"])) {n_sTicker_number = (string)_oData["MOBILEORDERMNPDETAIL_TICKER_NUMBER"];}else{n_sTicker_number=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_ID_TYPE"])) {n_sId_type = (string)_oData["MOBILEORDERMNPDETAIL_ID_TYPE"];}else{n_sId_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_TRANSFER_IDD_ROAMING_DEPOSIT"])) {n_lTransfer_idd_roaming_deposit = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAIL_TRANSFER_IDD_ROAMING_DEPOSIT"];}else{n_lTransfer_idd_roaming_deposit=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_TRANSFER_IDD_DEPOSIT"])) {n_lTransfer_idd_deposit = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAIL_TRANSFER_IDD_DEPOSIT"];}else{n_lTransfer_idd_deposit=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_SERVICE_ACTIVATION_DATE"])) {n_dService_activation_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERMNPDETAIL_SERVICE_ACTIVATION_DATE"];}else{n_dService_activation_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_MNP_ID"])) {n_lMnp_id = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAIL_MNP_ID"];}else{n_lMnp_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_TRANSFER_OTHERS_DEPOSIT"])) {n_lTransfer_others_deposit = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAIL_TRANSFER_OTHERS_DEPOSIT"];}else{n_lTransfer_others_deposit=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_REGISTERED_NAME"])) {n_sRegistered_name = (string)_oData["MOBILEORDERMNPDETAIL_REGISTERED_NAME"];}else{n_sRegistered_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_HKID"])) {n_sHkid = (string)_oData["MOBILEORDERMNPDETAIL_HKID"];}else{n_sHkid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_TRANSFER_TO_3G"])) {n_bTransfer_to_3g = (global::System.Nullable<bool>)_oData["MOBILEORDERMNPDETAIL_TRANSFER_TO_3G"];}else{n_bTransfer_to_3g=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_ORDER_ID"])) {n_iOrder_id = (global::System.Nullable<int>)_oData["MOBILEORDERMNPDETAIL_ORDER_ID"];}else{n_iOrder_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_TRANSFER_NO_ADD_PROOF_DEPOSIT"])) {n_lTransfer_no_add_proof_deposit = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAIL_TRANSFER_NO_ADD_PROOF_DEPOSIT"];}else{n_lTransfer_no_add_proof_deposit=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_COMPANY_NAME"])) {n_sCompany_name = (string)_oData["MOBILEORDERMNPDETAIL_COMPANY_NAME"];}else{n_sCompany_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_TRANSFER_NO_HK_ID_HOLDER_DEPOSIT"])) {n_lTransfer_no_hk_id_holder_deposit = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAIL_TRANSFER_NO_HK_ID_HOLDER_DEPOSIT"];}else{n_lTransfer_no_hk_id_holder_deposit=null;}
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
            if (n_sService_activation_time==null && !(n_oTableSet.Fields(Para.service_activation_time).IsNullable)) return false;
            if (n_sTicker_number==null && !(n_oTableSet.Fields(Para.ticker_number).IsNullable)) return false;
            if (n_sId_type==null && !(n_oTableSet.Fields(Para.id_type).IsNullable)) return false;
            if (n_lTransfer_idd_roaming_deposit==null && !(n_oTableSet.Fields(Para.transfer_idd_roaming_deposit).IsNullable)) return false;
            if (n_lTransfer_idd_deposit==null && !(n_oTableSet.Fields(Para.transfer_idd_deposit).IsNullable)) return false;
            if (n_dService_activation_date==null && !(n_oTableSet.Fields(Para.service_activation_date).IsNullable)) return false;
            if(!x_bInsert){
                if (n_lMnp_id==null && !(n_oTableSet.Fields(Para.mnp_id).IsNullable)) return false;
            }
            if (n_lTransfer_others_deposit==null && !(n_oTableSet.Fields(Para.transfer_others_deposit).IsNullable)) return false;
            if (n_sRegistered_name==null && !(n_oTableSet.Fields(Para.registered_name).IsNullable)) return false;
            if (n_sHkid==null && !(n_oTableSet.Fields(Para.hkid).IsNullable)) return false;
            if (n_bTransfer_to_3g==null && !(n_oTableSet.Fields(Para.transfer_to_3g).IsNullable)) return false;
            if (n_iOrder_id==null && !(n_oTableSet.Fields(Para.order_id).IsNullable)) return false;
            if (n_lTransfer_no_add_proof_deposit==null && !(n_oTableSet.Fields(Para.transfer_no_add_proof_deposit).IsNullable)) return false;
            if (n_sCompany_name==null && !(n_oTableSet.Fields(Para.company_name).IsNullable)) return false;
            if (n_lTransfer_no_hk_id_holder_deposit==null && !(n_oTableSet.Fields(Para.transfer_no_hk_id_holder_deposit).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(MobileOrderMNPDetailEntity)) || (x_oObj is MobileOrderMNPDetailEntity)) return MobileOrderMNPDetailRepository.Instance();
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
        public MobileOrderMNPDetailInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(MobileOrderMNPDetailInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public string GetService_activation_time(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.service_activation_time)) { return string.Empty; }
            return this.service_activation_time;
        }
        public string GetTicker_number(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.ticker_number)) { return string.Empty; }
            return this.ticker_number;
        }
        public string GetId_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.id_type)) { return string.Empty; }
            return this.id_type;
        }
        public global::System.Nullable<long> GetTransfer_idd_roaming_deposit(){return this.transfer_idd_roaming_deposit;}
        public string GetCompany_name(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.company_name)) { return string.Empty; }
            return this.company_name;
        }
        public global::System.Nullable<DateTime> GetService_activation_date(){return this.service_activation_date;}
        public global::System.Nullable<long> GetMnp_id(){return this.mnp_id;}
        public global::System.Nullable<long> GetTransfer_others_deposit(){return this.transfer_others_deposit;}
        public string GetHkid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.hkid)) { return string.Empty; }
            return this.hkid;
        }
        public global::System.Nullable<bool> GetTransfer_to_3g(){return this.transfer_to_3g;}
        public global::System.Nullable<long> GetTransfer_idd_deposit(){return this.transfer_idd_deposit;}
        public global::System.Nullable<long> GetTransfer_no_add_proof_deposit(){return this.transfer_no_add_proof_deposit;}
        public global::System.Nullable<int> GetOrder_id(){return this.order_id;}
        public string GetRegistered_name(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.registered_name)) { return string.Empty; }
            return this.registered_name;
        }
        public global::System.Nullable<long> GetTransfer_no_hk_id_holder_deposit(){return this.transfer_no_hk_id_holder_deposit;}
        
        public bool SetService_activation_time(string value){
            this.service_activation_time=value;
            return true;
        }
        public bool SetTicker_number(string value){
            this.ticker_number=value;
            return true;
        }
        public bool SetId_type(string value){
            this.id_type=value;
            return true;
        }
        public bool SetTransfer_idd_roaming_deposit(global::System.Nullable<long> value){
            this.transfer_idd_roaming_deposit=value;
            return true;
        }
        public bool SetCompany_name(string value){
            this.company_name=value;
            return true;
        }
        public bool SetService_activation_date(global::System.Nullable<DateTime> value){
            this.service_activation_date=value;
            return true;
        }
        public bool SetMnp_id(global::System.Nullable<long> value){
            this.mnp_id=value;
            return true;
        }
        public bool SetTransfer_others_deposit(global::System.Nullable<long> value){
            this.transfer_others_deposit=value;
            return true;
        }
        public bool SetHkid(string value){
            this.hkid=value;
            return true;
        }
        public bool SetTransfer_to_3g(global::System.Nullable<bool> value){
            this.transfer_to_3g=value;
            return true;
        }
        public bool SetTransfer_idd_deposit(global::System.Nullable<long> value){
            this.transfer_idd_deposit=value;
            return true;
        }
        public bool SetTransfer_no_add_proof_deposit(global::System.Nullable<long> value){
            this.transfer_no_add_proof_deposit=value;
            return true;
        }
        public bool SetOrder_id(global::System.Nullable<int> value){
            this.order_id=value;
            return true;
        }
        public bool SetRegistered_name(string value){
            this.registered_name=value;
            return true;
        }
        public bool SetTransfer_no_hk_id_holder_deposit(global::System.Nullable<long> value){
            this.transfer_no_hk_id_holder_deposit=value;
            return true;
        }
        
        public Field GetService_activation_timeTable(){
            return n_oTableSet.Fields(Para.service_activation_time);
        }
        public Field GetTicker_numberTable(){
            return n_oTableSet.Fields(Para.ticker_number);
        }
        public Field GetId_typeTable(){
            return n_oTableSet.Fields(Para.id_type);
        }
        public Field GetTransfer_idd_roaming_depositTable(){
            return n_oTableSet.Fields(Para.transfer_idd_roaming_deposit);
        }
        public Field GetCompany_nameTable(){
            return n_oTableSet.Fields(Para.company_name);
        }
        public Field GetService_activation_dateTable(){
            return n_oTableSet.Fields(Para.service_activation_date);
        }
        public Field GetMnp_idTable(){
            return n_oTableSet.Fields(Para.mnp_id);
        }
        public Field GetTransfer_others_depositTable(){
            return n_oTableSet.Fields(Para.transfer_others_deposit);
        }
        public Field GetHkidTable(){
            return n_oTableSet.Fields(Para.hkid);
        }
        public Field GetTransfer_to_3gTable(){
            return n_oTableSet.Fields(Para.transfer_to_3g);
        }
        public Field GetTransfer_idd_depositTable(){
            return n_oTableSet.Fields(Para.transfer_idd_deposit);
        }
        public Field GetTransfer_no_add_proof_depositTable(){
            return n_oTableSet.Fields(Para.transfer_no_add_proof_deposit);
        }
        public Field GetOrder_idTable(){
            return n_oTableSet.Fields(Para.order_id);
        }
        public Field GetRegistered_nameTable(){
            return n_oTableSet.Fields(Para.registered_name);
        }
        public Field GetTransfer_no_hk_id_holder_depositTable(){
            return n_oTableSet.Fields(Para.transfer_no_hk_id_holder_deposit);
        }
        #endregion
        
        #region Addtional Get & Set
        public MobileRetentionOrder GetMobileRetentionOrderMobileOrderMNPDetail() {
            return MobileRetentionOrderMobileOrderMNPDetail;
        }
        
        public bool SetMobileRetentionOrderMobileOrderMNPDetail(MobileRetentionOrder value) {
            MobileRetentionOrderMobileOrderMNPDetail = value;
            return true;
        }
        
        public global::System.Data.DataSet GetMobileRetentionOrderMobileOrderMNPDetailDataSet(){
            return MobileRetentionOrderMobileOrderMNPDetailDataSet;
        }
        
        public bool SetMobileRetentionOrderMobileOrderMNPDetailDataSet(global::System.Data.DataSet value) {
            MobileRetentionOrderMobileOrderMNPDetailDataSet = value;
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
        
        public bool EqualID(MobileOrderMNPDetail x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_lMnp_id.Equals(x_oObj.mnp_id)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(MobileOrderMNPDetail x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_sService_activation_time.Equals(x_oObj.service_activation_time)){ return false; }
            if(!this.n_sTicker_number.Equals(x_oObj.ticker_number)){ return false; }
            if(!this.n_sId_type.Equals(x_oObj.id_type)){ return false; }
            if(!this.n_lTransfer_idd_roaming_deposit.Equals(x_oObj.transfer_idd_roaming_deposit)){ return false; }
            if(!this.n_lTransfer_idd_deposit.Equals(x_oObj.transfer_idd_deposit)){ return false; }
            if(!this.n_dService_activation_date.Equals(x_oObj.service_activation_date)){ return false; }
            if(!this.n_lMnp_id.Equals(x_oObj.mnp_id)){ return false; }
            if(!this.n_lTransfer_others_deposit.Equals(x_oObj.transfer_others_deposit)){ return false; }
            if(!this.n_sRegistered_name.Equals(x_oObj.registered_name)){ return false; }
            if(!this.n_sHkid.Equals(x_oObj.hkid)){ return false; }
            if(!this.n_bTransfer_to_3g.Equals(x_oObj.transfer_to_3g)){ return false; }
            if(!this.n_iOrder_id.Equals(x_oObj.order_id)){ return false; }
            if(!this.n_lTransfer_no_add_proof_deposit.Equals(x_oObj.transfer_no_add_proof_deposit)){ return false; }
            if(!this.n_sCompany_name.Equals(x_oObj.company_name)){ return false; }
            if(!this.n_lTransfer_no_hk_id_holder_deposit.Equals(x_oObj.transfer_no_hk_id_holder_deposit)){ return false; }
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
            if(!n_lMnp_id.Equals(null)){
                _bResult=this.Load(n_lMnp_id);
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
            if (n_lMnp_id==null) { return false; }
            if(!Vaild(false)){ return false; }
            string _sQuery = "UPDATE  [MobileOrderMNPDetail]  SET  [service_activation_time]=@service_activation_time,[ticker_number]=@ticker_number,[id_type]=@id_type,[transfer_idd_roaming_deposit]=@transfer_idd_roaming_deposit,[transfer_idd_deposit]=@transfer_idd_deposit,[service_activation_date]=@service_activation_date,[transfer_others_deposit]=@transfer_others_deposit,[registered_name]=@registered_name,[hkid]=@hkid,[transfer_to_3g]=@transfer_to_3g,[order_id]=@order_id,[transfer_no_add_proof_deposit]=@transfer_no_add_proof_deposit,[company_name]=@company_name,[transfer_no_hk_id_holder_deposit]=@transfer_no_hk_id_holder_deposit  WHERE [MobileOrderMNPDetail].[mnp_id]=@mnp_id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMNPDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMNPDetail]"); }
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
            if(n_sService_activation_time==null){  _oCmd.Parameters.Add("@service_activation_time", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@service_activation_time", global::System.Data.SqlDbType.NVarChar,50).Value=n_sService_activation_time; }
            if(n_sTicker_number==null){  _oCmd.Parameters.Add("@ticker_number", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@ticker_number", global::System.Data.SqlDbType.NVarChar,50).Value=n_sTicker_number; }
            if(n_sId_type==null){  _oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,10).Value=n_sId_type; }
            if(n_lTransfer_idd_roaming_deposit==null){  _oCmd.Parameters.Add("@transfer_idd_roaming_deposit", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@transfer_idd_roaming_deposit", global::System.Data.SqlDbType.BigInt).Value=n_lTransfer_idd_roaming_deposit; }
            if(n_lTransfer_idd_deposit==null){  _oCmd.Parameters.Add("@transfer_idd_deposit", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@transfer_idd_deposit", global::System.Data.SqlDbType.BigInt).Value=n_lTransfer_idd_deposit; }
            if(n_dService_activation_date==null){  _oCmd.Parameters.Add("@service_activation_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@service_activation_date", global::System.Data.SqlDbType.DateTime).Value=n_dService_activation_date; }
            if(n_lMnp_id==null){  _oCmd.Parameters.Add("@mnp_id", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@mnp_id", global::System.Data.SqlDbType.BigInt).Value=n_lMnp_id; }
            if(n_lTransfer_others_deposit==null){  _oCmd.Parameters.Add("@transfer_others_deposit", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@transfer_others_deposit", global::System.Data.SqlDbType.BigInt).Value=n_lTransfer_others_deposit; }
            if(n_sRegistered_name==null){  _oCmd.Parameters.Add("@registered_name", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@registered_name", global::System.Data.SqlDbType.NVarChar,50).Value=n_sRegistered_name; }
            if(n_sHkid==null){  _oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,50).Value=n_sHkid; }
            if(n_bTransfer_to_3g==null){  _oCmd.Parameters.Add("@transfer_to_3g", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@transfer_to_3g", global::System.Data.SqlDbType.Bit).Value=n_bTransfer_to_3g; }
            if(n_iOrder_id==null){  _oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=n_iOrder_id; }
            if(n_lTransfer_no_add_proof_deposit==null){  _oCmd.Parameters.Add("@transfer_no_add_proof_deposit", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@transfer_no_add_proof_deposit", global::System.Data.SqlDbType.BigInt).Value=n_lTransfer_no_add_proof_deposit; }
            if(n_sCompany_name==null){  _oCmd.Parameters.Add("@company_name", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@company_name", global::System.Data.SqlDbType.NVarChar,50).Value=n_sCompany_name; }
            if(n_lTransfer_no_hk_id_holder_deposit==null){  _oCmd.Parameters.Add("@transfer_no_hk_id_holder_deposit", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@transfer_no_hk_id_holder_deposit", global::System.Data.SqlDbType.BigInt).Value=n_lTransfer_no_hk_id_holder_deposit; }
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
        /// Summary description for table [MobileOrderMNPDetail] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_lMnp_id==null) { return false; }
            string _sQuery="DELETE FROM  [MobileOrderMNPDetail]  WHERE [MobileOrderMNPDetail].[mnp_id]=@mnp_id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMNPDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMNPDetail]"); }
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
            _oCmd.Parameters.Add("@mnp_id", global::System.Data.SqlDbType.BigInt).Value = n_lMnp_id;
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
        /// Summary description for table [MobileOrderMNPDetail] Object Base Clone
        /// </summary>
        
        public MobileOrderMNPDetail DeepClone()
        {
            MobileOrderMNPDetail _oMobileOrderMNPDetail_Clone = new MobileOrderMNPDetail();
            _oMobileOrderMNPDetail_Clone.service_activation_time = this.n_sService_activation_time;
            _oMobileOrderMNPDetail_Clone.ticker_number = this.n_sTicker_number;
            _oMobileOrderMNPDetail_Clone.id_type = this.n_sId_type;
            _oMobileOrderMNPDetail_Clone.transfer_idd_roaming_deposit = this.n_lTransfer_idd_roaming_deposit;
            _oMobileOrderMNPDetail_Clone.transfer_idd_deposit = this.n_lTransfer_idd_deposit;
            _oMobileOrderMNPDetail_Clone.service_activation_date = this.n_dService_activation_date;
            _oMobileOrderMNPDetail_Clone.mnp_id = this.n_lMnp_id;
            _oMobileOrderMNPDetail_Clone.transfer_others_deposit = this.n_lTransfer_others_deposit;
            _oMobileOrderMNPDetail_Clone.registered_name = this.n_sRegistered_name;
            _oMobileOrderMNPDetail_Clone.hkid = this.n_sHkid;
            _oMobileOrderMNPDetail_Clone.transfer_to_3g = this.n_bTransfer_to_3g;
            _oMobileOrderMNPDetail_Clone.order_id = this.n_iOrder_id;
            _oMobileOrderMNPDetail_Clone.transfer_no_add_proof_deposit = this.n_lTransfer_no_add_proof_deposit;
            _oMobileOrderMNPDetail_Clone.company_name = this.n_sCompany_name;
            _oMobileOrderMNPDetail_Clone.transfer_no_hk_id_holder_deposit = this.n_lTransfer_no_hk_id_holder_deposit;
            _oMobileOrderMNPDetail_Clone.SetFound(this.n_bFound);
            _oMobileOrderMNPDetail_Clone.SetDB(this.n_oDB);
            _oMobileOrderMNPDetail_Clone.SetRow(this.n_oRow);
            _oMobileOrderMNPDetail_Clone.SetTbl(this.n_oTbl);
            _oMobileOrderMNPDetail_Clone.SetTableSet(this.n_oTableSet);
            MobileRetentionOrderMobileOrderMNPDetail=null;
            _oMobileOrderMNPDetail_Clone.MobileRetentionOrderMobileOrderMNPDetail = this.MobileRetentionOrderMobileOrderMNPDetail.DeepClone();
            
            return _oMobileOrderMNPDetail_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_sService_activation_time=global::System.String.Empty;
            n_sTicker_number=global::System.String.Empty;
            n_sId_type=global::System.String.Empty;
            n_lTransfer_idd_roaming_deposit=null;
            n_lTransfer_idd_deposit=null;
            n_dService_activation_date=null;
            n_lMnp_id=null;
            n_lTransfer_others_deposit=null;
            n_sRegistered_name=global::System.String.Empty;
            n_sHkid=global::System.String.Empty;
            n_bTransfer_to_3g=null;
            n_iOrder_id=null;
            n_lTransfer_no_add_proof_deposit=null;
            n_sCompany_name=global::System.String.Empty;
            n_lTransfer_no_hk_id_holder_deposit=null;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = MobileOrderMNPDetailInfoDLL.CreateInfoInstanceObject();
            n_oMobileRetentionOrderMobileOrderMNPDetail=null;
        }
        #endregion
    }
}


