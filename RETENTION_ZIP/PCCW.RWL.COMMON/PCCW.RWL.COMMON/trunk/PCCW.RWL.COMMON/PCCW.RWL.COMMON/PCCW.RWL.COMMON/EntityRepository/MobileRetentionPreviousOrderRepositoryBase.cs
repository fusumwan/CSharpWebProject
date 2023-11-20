using System;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
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
///-- Create date: <Create Date 2012-01-12>
///-- Description:	<Description,Table :[MobileRetentionPreviousOrder],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileRetentionPreviousOrder] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"MobileRetentionPreviousOrder")]
    public class MobileRetentionPreviousOrderRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static MobileRetentionPreviousOrderRepositoryBase instance;
        public static MobileRetentionPreviousOrderRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new MobileRetentionPreviousOrderRepositoryBase(_oDB);
            }
            return instance;
        }
        public static MobileRetentionPreviousOrderRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new MobileRetentionPreviousOrderRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<MobileRetentionPreviousOrderEntity> MobileRetentionPreviousOrders;
        #endregion
        
        #region Constructor
        public MobileRetentionPreviousOrderRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~MobileRetentionPreviousOrderRepositoryBase() { 
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (disposing)
            {
            }
        }
        #endregion
        #region Create Instance Object
        /// <summary>
        /// Summary description for Create Instance Object
        /// </summary>
        public static MobileRetentionPreviousOrder CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new MobileRetentionPreviousOrder(_oDB);
        }
        
        public static MobileRetentionPreviousOrder CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new MobileRetentionPreviousOrder(x_oDB);
        }
        #endregion
        
        #region Count
        
        /// <summary>
        /// Summary description for Counting
        /// </summary>
        
        public int GetCount()
        {
            return GetCount(n_oDB);
        }
        public static int GetCount(MSSQLConnect x_oDB)
        {
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [MobileRetentionPreviousOrder]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionPreviousOrder]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionPreviousOrder]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn=x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                int _iTotalCount = 0;
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    if (_oData.Read())
                    {
                        _iTotalCount = (int)_oData["TotalCount"];
                    }
                    _oData.Close();
                    _oData.Dispose();
                }
                catch{}
                finally
                {
                    _oConn.Close();
                    _oCmd.Dispose();
                    _oConn.Dispose();
                }
                return _iTotalCount;
            }
        }
        #endregion
        
        #region Get Array & List
        
        /// <summary>
        /// Summary description for management get record from table
        /// </summary>
        
        
        public MobileRetentionPreviousOrderEntity GetObj(global::System.Nullable<int> x_iOrder_id)
        {
            return GetObj(n_oDB, x_iOrder_id);
        }
        
        
        public static MobileRetentionPreviousOrderEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iOrder_id)
        {
            if (x_oDB==null) { return null; }
            MobileRetentionPreviousOrder _MobileRetentionPreviousOrder = (MobileRetentionPreviousOrder)MobileRetentionPreviousOrderRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_MobileRetentionPreviousOrder.Load(x_iOrder_id)) { return null; }
            return _MobileRetentionPreviousOrder;
        }
        
        
        
        public static MobileRetentionPreviousOrderEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<MobileRetentionPreviousOrderEntity> _oMobileRetentionPreviousOrderList = GetListObj(x_oDB,0, "order_id", x_oArrayItemId);
            if(_oMobileRetentionPreviousOrderList==null){ return null;}
            return _oMobileRetentionPreviousOrderList.Count == 0 ? null : _oMobileRetentionPreviousOrderList.ToArray();
        }
        
        public static List<MobileRetentionPreviousOrderEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "order_id", x_oArrayItemId);
        }
        
        
        public static MobileRetentionPreviousOrderEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileRetentionPreviousOrderEntity> _oMobileRetentionPreviousOrderList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oMobileRetentionPreviousOrderList==null){ return null;}
            return _oMobileRetentionPreviousOrderList.Count == 0 ? null : _oMobileRetentionPreviousOrderList.ToArray();
        }
        
        
        public static MobileRetentionPreviousOrderEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileRetentionPreviousOrderEntity> _oMobileRetentionPreviousOrderList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oMobileRetentionPreviousOrderList==null){ return null;}
            return _oMobileRetentionPreviousOrderList.Count == 0 ? null : _oMobileRetentionPreviousOrderList.ToArray();
        }
        
        public static List<MobileRetentionPreviousOrderEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<MobileRetentionPreviousOrderEntity> _oRow = new List<MobileRetentionPreviousOrderEntity>();
            string _sQuery = "SELECT  "+_sTop+" [MobileRetentionPreviousOrder].[gift_imei] AS MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI,[MobileRetentionPreviousOrder].[s_premium4] AS MOBILERETENTIONPREVIOUSORDER_S_PREMIUM4,[MobileRetentionPreviousOrder].[upgrade_existing_customer_type] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_CUSTOMER_TYPE,[MobileRetentionPreviousOrder].[gift_desc4] AS MOBILERETENTIONPREVIOUSORDER_GIFT_DESC4,[MobileRetentionPreviousOrder].[accessory_desc] AS MOBILERETENTIONPREVIOUSORDER_ACCESSORY_DESC,[MobileRetentionPreviousOrder].[staff_name] AS MOBILERETENTIONPREVIOUSORDER_STAFF_NAME,[MobileRetentionPreviousOrder].[action_required] AS MOBILERETENTIONPREVIOUSORDER_ACTION_REQUIRED,[MobileRetentionPreviousOrder].[registered_address_his_id] AS MOBILERETENTIONPREVIOUSORDER_REGISTERED_ADDRESS_HIS_ID,[MobileRetentionPreviousOrder].[vas_eff_date] AS MOBILERETENTIONPREVIOUSORDER_VAS_EFF_DATE,[MobileRetentionPreviousOrder].[monthly_bank_account_bank_code] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_BANK_CODE,[MobileRetentionPreviousOrder].[sim_item_number] AS MOBILERETENTIONPREVIOUSORDER_SIM_ITEM_NUMBER,[MobileRetentionPreviousOrder].[special_handling_dummy_code] AS MOBILERETENTIONPREVIOUSORDER_SPECIAL_HANDLING_DUMMY_CODE,[MobileRetentionPreviousOrder].[card_no] AS MOBILERETENTIONPREVIOUSORDER_CARD_NO,[MobileRetentionPreviousOrder].[m_card_exp_year] AS MOBILERETENTIONPREVIOUSORDER_M_CARD_EXP_YEAR,[MobileRetentionPreviousOrder].[bill_medium_email] AS MOBILERETENTIONPREVIOUSORDER_BILL_MEDIUM_EMAIL,[MobileRetentionPreviousOrder].[remarks2PY] AS MOBILERETENTIONPREVIOUSORDER_REMARKS2PY,[MobileRetentionPreviousOrder].[trade_field] AS MOBILERETENTIONPREVIOUSORDER_TRADE_FIELD,[MobileRetentionPreviousOrder].[ord_place_tel] AS MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_TEL,[MobileRetentionPreviousOrder].[action_of_rate_plan_effective] AS MOBILERETENTIONPREVIOUSORDER_ACTION_OF_RATE_PLAN_EFFECTIVE,[MobileRetentionPreviousOrder].[cooling_offer] AS MOBILERETENTIONPREVIOUSORDER_COOLING_OFFER,[MobileRetentionPreviousOrder].[rec_no] AS MOBILERETENTIONPREVIOUSORDER_REC_NO,[MobileRetentionPreviousOrder].[upgrade_handset_offer_rebate_schedule] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_HANDSET_OFFER_REBATE_SCHEDULE,[MobileRetentionPreviousOrder].[change_payment_type] AS MOBILERETENTIONPREVIOUSORDER_CHANGE_PAYMENT_TYPE,[MobileRetentionPreviousOrder].[date_of_birth] AS MOBILERETENTIONPREVIOUSORDER_DATE_OF_BIRTH,[MobileRetentionPreviousOrder].[contact_person] AS MOBILERETENTIONPREVIOUSORDER_CONTACT_PERSON,[MobileRetentionPreviousOrder].[extra_d_charge] AS MOBILERETENTIONPREVIOUSORDER_EXTRA_D_CHARGE,[MobileRetentionPreviousOrder].[tl_name] AS MOBILERETENTIONPREVIOUSORDER_TL_NAME,[MobileRetentionPreviousOrder].[fast_start] AS MOBILERETENTIONPREVIOUSORDER_FAST_START,[MobileRetentionPreviousOrder].[issue_type] AS MOBILERETENTIONPREVIOUSORDER_ISSUE_TYPE,[MobileRetentionPreviousOrder].[sp_ref_no] AS MOBILERETENTIONPREVIOUSORDER_SP_REF_NO,[MobileRetentionPreviousOrder].[edate] AS MOBILERETENTIONPREVIOUSORDER_EDATE,[MobileRetentionPreviousOrder].[exist_cust_plan] AS MOBILERETENTIONPREVIOUSORDER_EXIST_CUST_PLAN,[MobileRetentionPreviousOrder].[ord_place_rel] AS MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_REL,[MobileRetentionPreviousOrder].[mrt_no] AS MOBILERETENTIONPREVIOUSORDER_MRT_NO,[MobileRetentionPreviousOrder].[imei_no] AS MOBILERETENTIONPREVIOUSORDER_IMEI_NO,[MobileRetentionPreviousOrder].[existing_smart_phone_model] AS MOBILERETENTIONPREVIOUSORDER_EXISTING_SMART_PHONE_MODEL,[MobileRetentionPreviousOrder].[bank_code] AS MOBILERETENTIONPREVIOUSORDER_BANK_CODE,[MobileRetentionPreviousOrder].[pos_ref_no] AS MOBILERETENTIONPREVIOUSORDER_POS_REF_NO,[MobileRetentionPreviousOrder].[bill_cut_date] AS MOBILERETENTIONPREVIOUSORDER_BILL_CUT_DATE,[MobileRetentionPreviousOrder].[gift_imei3] AS MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI3,[MobileRetentionPreviousOrder].[exist_plan] AS MOBILERETENTIONPREVIOUSORDER_EXIST_PLAN,[MobileRetentionPreviousOrder].[waive] AS MOBILERETENTIONPREVIOUSORDER_WAIVE,[MobileRetentionPreviousOrder].[program] AS MOBILERETENTIONPREVIOUSORDER_PROGRAM,[MobileRetentionPreviousOrder].[first_month_fee] AS MOBILERETENTIONPREVIOUSORDER_FIRST_MONTH_FEE,[MobileRetentionPreviousOrder].[r_offer] AS MOBILERETENTIONPREVIOUSORDER_R_OFFER,[MobileRetentionPreviousOrder].[cid] AS MOBILERETENTIONPREVIOUSORDER_CID,[MobileRetentionPreviousOrder].[did] AS MOBILERETENTIONPREVIOUSORDER_DID,[MobileRetentionPreviousOrder].[ftg_tenure] AS MOBILERETENTIONPREVIOUSORDER_FTG_TENURE,[MobileRetentionPreviousOrder].[con_per] AS MOBILERETENTIONPREVIOUSORDER_CON_PER,[MobileRetentionPreviousOrder].[gift_code4] AS MOBILERETENTIONPREVIOUSORDER_GIFT_CODE4,[MobileRetentionPreviousOrder].[easywatch_type] AS MOBILERETENTIONPREVIOUSORDER_EASYWATCH_TYPE,[MobileRetentionPreviousOrder].[sms_mrt] AS MOBILERETENTIONPREVIOUSORDER_SMS_MRT,[MobileRetentionPreviousOrder].[tpy_his_id] AS MOBILERETENTIONPREVIOUSORDER_TPY_HIS_ID,[MobileRetentionPreviousOrder].[monthly_payment_method] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_PAYMENT_METHOD,[MobileRetentionPreviousOrder].[remarks2EDF] AS MOBILERETENTIONPREVIOUSORDER_REMARKS2EDF,[MobileRetentionPreviousOrder].[gift_desc3] AS MOBILERETENTIONPREVIOUSORDER_GIFT_DESC3,[MobileRetentionPreviousOrder].[gift_imei4] AS MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI4,[MobileRetentionPreviousOrder].[monthly_bank_account_hkid2] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_HKID2,[MobileRetentionPreviousOrder].[d_date] AS MOBILERETENTIONPREVIOUSORDER_D_DATE,[MobileRetentionPreviousOrder].[gift_desc] AS MOBILERETENTIONPREVIOUSORDER_GIFT_DESC,[MobileRetentionPreviousOrder].[pool] AS MOBILERETENTIONPREVIOUSORDER_POOL,[MobileRetentionPreviousOrder].[cn_mrt_no] AS MOBILERETENTIONPREVIOUSORDER_CN_MRT_NO,[MobileRetentionPreviousOrder].[accessory_imei] AS MOBILERETENTIONPREVIOUSORDER_ACCESSORY_IMEI,[MobileRetentionPreviousOrder].[third_party_credit_card] AS MOBILERETENTIONPREVIOUSORDER_THIRD_PARTY_CREDIT_CARD,[MobileRetentionPreviousOrder].[special_approval] AS MOBILERETENTIONPREVIOUSORDER_SPECIAL_APPROVAL,[MobileRetentionPreviousOrder].[upgrade_existing_contract_edate] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_CONTRACT_EDATE,[MobileRetentionPreviousOrder].[accessory_code] AS MOBILERETENTIONPREVIOUSORDER_ACCESSORY_CODE,[MobileRetentionPreviousOrder].[s_premium] AS MOBILERETENTIONPREVIOUSORDER_S_PREMIUM,[MobileRetentionPreviousOrder].[ref_staff_no] AS MOBILERETENTIONPREVIOUSORDER_REF_STAFF_NO,[MobileRetentionPreviousOrder].[accessory_price] AS MOBILERETENTIONPREVIOUSORDER_ACCESSORY_PRICE,[MobileRetentionPreviousOrder].[m_card_exp_month] AS MOBILERETENTIONPREVIOUSORDER_M_CARD_EXP_MONTH,[MobileRetentionPreviousOrder].[installment_period] AS MOBILERETENTIONPREVIOUSORDER_INSTALLMENT_PERIOD,[MobileRetentionPreviousOrder].[m_card_type] AS MOBILERETENTIONPREVIOUSORDER_M_CARD_TYPE,[MobileRetentionPreviousOrder].[easywatch_ord_id] AS MOBILERETENTIONPREVIOUSORDER_EASYWATCH_ORD_ID,[MobileRetentionPreviousOrder].[normal_rebate] AS MOBILERETENTIONPREVIOUSORDER_NORMAL_REBATE,[MobileRetentionPreviousOrder].[m_rebate_amount] AS MOBILERETENTIONPREVIOUSORDER_M_REBATE_AMOUNT,[MobileRetentionPreviousOrder].[m_card_holder2] AS MOBILERETENTIONPREVIOUSORDER_M_CARD_HOLDER2,[MobileRetentionPreviousOrder].[monthly_bank_account_holder] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_HOLDER,[MobileRetentionPreviousOrder].[active] AS MOBILERETENTIONPREVIOUSORDER_ACTIVE,[MobileRetentionPreviousOrder].[s_premium1] AS MOBILERETENTIONPREVIOUSORDER_S_PREMIUM1,[MobileRetentionPreviousOrder].[card_exp_month] AS MOBILERETENTIONPREVIOUSORDER_CARD_EXP_MONTH,[MobileRetentionPreviousOrder].[ob_program_id] AS MOBILERETENTIONPREVIOUSORDER_OB_PROGRAM_ID,[MobileRetentionPreviousOrder].[sku] AS MOBILERETENTIONPREVIOUSORDER_SKU,[MobileRetentionPreviousOrder].[salesmancode] AS MOBILERETENTIONPREVIOUSORDER_SALESMANCODE,[MobileRetentionPreviousOrder].[go_wireless_package_code] AS MOBILERETENTIONPREVIOUSORDER_GO_WIRELESS_PACKAGE_CODE,[MobileRetentionPreviousOrder].[lob] AS MOBILERETENTIONPREVIOUSORDER_LOB,[MobileRetentionPreviousOrder].[ref_salesmancode] AS MOBILERETENTIONPREVIOUSORDER_REF_SALESMANCODE,[MobileRetentionPreviousOrder].[third_party_hkid] AS MOBILERETENTIONPREVIOUSORDER_THIRD_PARTY_HKID,[MobileRetentionPreviousOrder].[upgrade_existing_pccw_customer] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_PCCW_CUSTOMER,[MobileRetentionPreviousOrder].[d_address] AS MOBILERETENTIONPREVIOUSORDER_D_ADDRESS,[MobileRetentionPreviousOrder].[upgrade_registered_mobile_no] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_REGISTERED_MOBILE_NO,[MobileRetentionPreviousOrder].[gift_code3] AS MOBILERETENTIONPREVIOUSORDER_GIFT_CODE3,[MobileRetentionPreviousOrder].[normal_rebate_type] AS MOBILERETENTIONPREVIOUSORDER_NORMAL_REBATE_TYPE,[MobileRetentionPreviousOrder].[gift_desc2] AS MOBILERETENTIONPREVIOUSORDER_GIFT_DESC2,[MobileRetentionPreviousOrder].[monthly_bank_account_branch_code] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_BRANCH_CODE,[MobileRetentionPreviousOrder].[remarks] AS MOBILERETENTIONPREVIOUSORDER_REMARKS,[MobileRetentionPreviousOrder].[accept] AS MOBILERETENTIONPREVIOUSORDER_ACCEPT,[MobileRetentionPreviousOrder].[delivery_exchange] AS MOBILERETENTIONPREVIOUSORDER_DELIVERY_EXCHANGE,[MobileRetentionPreviousOrder].[gift_code2] AS MOBILERETENTIONPREVIOUSORDER_GIFT_CODE2,[MobileRetentionPreviousOrder].[prepayment_waive] AS MOBILERETENTIONPREVIOUSORDER_PREPAYMENT_WAIVE,[MobileRetentionPreviousOrder].[existing_smart_phone_imei] AS MOBILERETENTIONPREVIOUSORDER_EXISTING_SMART_PHONE_IMEI,[MobileRetentionPreviousOrder].[mnp_his_id] AS MOBILERETENTIONPREVIOUSORDER_MNP_HIS_ID,[MobileRetentionPreviousOrder].[cust_name] AS MOBILERETENTIONPREVIOUSORDER_CUST_NAME,[MobileRetentionPreviousOrder].[upgrade_sponsorships_amount] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_SPONSORSHIPS_AMOUNT,[MobileRetentionPreviousOrder].[bill_medium_waive] AS MOBILERETENTIONPREVIOUSORDER_BILL_MEDIUM_WAIVE,[MobileRetentionPreviousOrder].[delivery_exchange_location] AS MOBILERETENTIONPREVIOUSORDER_DELIVERY_EXCHANGE_LOCATION,[MobileRetentionPreviousOrder].[hs_offer_type_id] AS MOBILERETENTIONPREVIOUSORDER_HS_OFFER_TYPE_ID,[MobileRetentionPreviousOrder].[org_fee] AS MOBILERETENTIONPREVIOUSORDER_ORG_FEE,[MobileRetentionPreviousOrder].[rebate] AS MOBILERETENTIONPREVIOUSORDER_REBATE,[MobileRetentionPreviousOrder].[upgrade_type] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_TYPE,[MobileRetentionPreviousOrder].[go_wireless] AS MOBILERETENTIONPREVIOUSORDER_GO_WIRELESS,[MobileRetentionPreviousOrder].[extra_rebate] AS MOBILERETENTIONPREVIOUSORDER_EXTRA_REBATE,[MobileRetentionPreviousOrder].[plan_eff] AS MOBILERETENTIONPREVIOUSORDER_PLAN_EFF,[MobileRetentionPreviousOrder].[extra_rebate_amount] AS MOBILERETENTIONPREVIOUSORDER_EXTRA_REBATE_AMOUNT,[MobileRetentionPreviousOrder].[card_exp_year] AS MOBILERETENTIONPREVIOUSORDER_CARD_EXP_YEAR,[MobileRetentionPreviousOrder].[upgrade_existing_contract_sdate] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_CONTRACT_SDATE,[MobileRetentionPreviousOrder].[ord_place_hkid] AS MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_HKID,[MobileRetentionPreviousOrder].[register_address] AS MOBILERETENTIONPREVIOUSORDER_REGISTER_ADDRESS,[MobileRetentionPreviousOrder].[gender] AS MOBILERETENTIONPREVIOUSORDER_GENDER,[MobileRetentionPreviousOrder].[lob_ac] AS MOBILERETENTIONPREVIOUSORDER_LOB_AC,[MobileRetentionPreviousOrder].[sim_mrt_no] AS MOBILERETENTIONPREVIOUSORDER_SIM_MRT_NO,[MobileRetentionPreviousOrder].[redemption_notice_option] AS MOBILERETENTIONPREVIOUSORDER_REDEMPTION_NOTICE_OPTION,[MobileRetentionPreviousOrder].[delivery_collection_type] AS MOBILERETENTIONPREVIOUSORDER_DELIVERY_COLLECTION_TYPE,[MobileRetentionPreviousOrder].[action_date] AS MOBILERETENTIONPREVIOUSORDER_ACTION_DATE,[MobileRetentionPreviousOrder].[third_party_id_type] AS MOBILERETENTIONPREVIOUSORDER_THIRD_PARTY_ID_TYPE,[MobileRetentionPreviousOrder].[org_ftg] AS MOBILERETENTIONPREVIOUSORDER_ORG_FTG,[MobileRetentionPreviousOrder].[upgrade_service_tenure] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_SERVICE_TENURE,[MobileRetentionPreviousOrder].[monthly_payment_type] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_PAYMENT_TYPE,[MobileRetentionPreviousOrder].[contact_no] AS MOBILERETENTIONPREVIOUSORDER_CONTACT_NO,[MobileRetentionPreviousOrder].[org_mrt] AS MOBILERETENTIONPREVIOUSORDER_ORG_MRT,[MobileRetentionPreviousOrder].[sim_item_name] AS MOBILERETENTIONPREVIOUSORDER_SIM_ITEM_NAME,[MobileRetentionPreviousOrder].[pay_method] AS MOBILERETENTIONPREVIOUSORDER_PAY_METHOD,[MobileRetentionPreviousOrder].[hs_model] AS MOBILERETENTIONPREVIOUSORDER_HS_MODEL,[MobileRetentionPreviousOrder].[gift_code] AS MOBILERETENTIONPREVIOUSORDER_GIFT_CODE,[MobileRetentionPreviousOrder].[monthly_bank_account_hkid] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_HKID,[MobileRetentionPreviousOrder].[extra_offer] AS MOBILERETENTIONPREVIOUSORDER_EXTRA_OFFER,[MobileRetentionPreviousOrder].[monthly_bank_account_no] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_NO,[MobileRetentionPreviousOrder].[first_month_license_fee] AS MOBILERETENTIONPREVIOUSORDER_FIRST_MONTH_LICENSE_FEE,[MobileRetentionPreviousOrder].[retrieve_cnt] AS MOBILERETENTIONPREVIOUSORDER_RETRIEVE_CNT,[MobileRetentionPreviousOrder].[ddate] AS MOBILERETENTIONPREVIOUSORDER_DDATE,[MobileRetentionPreviousOrder].[s_premium2] AS MOBILERETENTIONPREVIOUSORDER_S_PREMIUM2,[MobileRetentionPreviousOrder].[monthly_bank_account_id_type] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_ID_TYPE,[MobileRetentionPreviousOrder].[card_type] AS MOBILERETENTIONPREVIOUSORDER_CARD_TYPE,[MobileRetentionPreviousOrder].[next_bill] AS MOBILERETENTIONPREVIOUSORDER_NEXT_BILL,[MobileRetentionPreviousOrder].[pcd_paid_go_wireless] AS MOBILERETENTIONPREVIOUSORDER_PCD_PAID_GO_WIRELESS,[MobileRetentionPreviousOrder].[upgrade_rebate_calculation] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_REBATE_CALCULATION,[MobileRetentionPreviousOrder].[ext_place_tel] AS MOBILERETENTIONPREVIOUSORDER_EXT_PLACE_TEL,[MobileRetentionPreviousOrder].[m_3rd_hkid] AS MOBILERETENTIONPREVIOUSORDER_M_3RD_HKID,[MobileRetentionPreviousOrder].[retention_type] AS MOBILERETENTIONPREVIOUSORDER_RETENTION_TYPE,[MobileRetentionPreviousOrder].[bill_address_his_id] AS MOBILERETENTIONPREVIOUSORDER_BILL_ADDRESS_HIS_ID,[MobileRetentionPreviousOrder].[aig_gift] AS MOBILERETENTIONPREVIOUSORDER_AIG_GIFT,[MobileRetentionPreviousOrder].[cust_staff_no] AS MOBILERETENTIONPREVIOUSORDER_CUST_STAFF_NO,[MobileRetentionPreviousOrder].[order_id] AS MOBILERETENTIONPREVIOUSORDER_ORDER_ID,[MobileRetentionPreviousOrder].[family_name] AS MOBILERETENTIONPREVIOUSORDER_FAMILY_NAME,[MobileRetentionPreviousOrder].[cdate] AS MOBILERETENTIONPREVIOUSORDER_CDATE,[MobileRetentionPreviousOrder].[status_by_cs_admin] AS MOBILERETENTIONPREVIOUSORDER_STATUS_BY_CS_ADMIN,[MobileRetentionPreviousOrder].[given_name] AS MOBILERETENTIONPREVIOUSORDER_GIVEN_NAME,[MobileRetentionPreviousOrder].[vip_case] AS MOBILERETENTIONPREVIOUSORDER_VIP_CASE,[MobileRetentionPreviousOrder].[s_premium3] AS MOBILERETENTIONPREVIOUSORDER_S_PREMIUM3,[MobileRetentionPreviousOrder].[log_date] AS MOBILERETENTIONPREVIOUSORDER_LOG_DATE,[MobileRetentionPreviousOrder].[extn] AS MOBILERETENTIONPREVIOUSORDER_EXTN,[MobileRetentionPreviousOrder].[d_time] AS MOBILERETENTIONPREVIOUSORDER_D_TIME,[MobileRetentionPreviousOrder].[bank_name] AS MOBILERETENTIONPREVIOUSORDER_BANK_NAME,[MobileRetentionPreviousOrder].[delivery_exchange_option] AS MOBILERETENTIONPREVIOUSORDER_DELIVERY_EXCHANGE_OPTION,[MobileRetentionPreviousOrder].[upgrade_service_account_no] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_SERVICE_ACCOUNT_NO,[MobileRetentionPreviousOrder].[old_ord_id] AS MOBILERETENTIONPREVIOUSORDER_OLD_ORD_ID,[MobileRetentionPreviousOrder].[m_card_no] AS MOBILERETENTIONPREVIOUSORDER_M_CARD_NO,[MobileRetentionPreviousOrder].[existing_contract_end_date] AS MOBILERETENTIONPREVIOUSORDER_EXISTING_CONTRACT_END_DATE,[MobileRetentionPreviousOrder].[con_eff_date] AS MOBILERETENTIONPREVIOUSORDER_CON_EFF_DATE,[MobileRetentionPreviousOrder].[m_3rd_hkid2] AS MOBILERETENTIONPREVIOUSORDER_M_3RD_HKID2,[MobileRetentionPreviousOrder].[amount] AS MOBILERETENTIONPREVIOUSORDER_AMOUNT,[MobileRetentionPreviousOrder].[m_3rd_id_type] AS MOBILERETENTIONPREVIOUSORDER_M_3RD_ID_TYPE,[MobileRetentionPreviousOrder].[id_type] AS MOBILERETENTIONPREVIOUSORDER_ID_TYPE,[MobileRetentionPreviousOrder].[rate_plan] AS MOBILERETENTIONPREVIOUSORDER_RATE_PLAN,[MobileRetentionPreviousOrder].[channel] AS MOBILERETENTIONPREVIOUSORDER_CHANNEL,[MobileRetentionPreviousOrder].[action_eff_date] AS MOBILERETENTIONPREVIOUSORDER_ACTION_EFF_DATE,[MobileRetentionPreviousOrder].[cooling_date] AS MOBILERETENTIONPREVIOUSORDER_COOLING_DATE,[MobileRetentionPreviousOrder].[free_mon] AS MOBILERETENTIONPREVIOUSORDER_FREE_MON,[MobileRetentionPreviousOrder].[plan_eff_date] AS MOBILERETENTIONPREVIOUSORDER_PLAN_EFF_DATE,[MobileRetentionPreviousOrder].[teamcode] AS MOBILERETENTIONPREVIOUSORDER_TEAMCODE,[MobileRetentionPreviousOrder].[bill_medium] AS MOBILERETENTIONPREVIOUSORDER_BILL_MEDIUM,[MobileRetentionPreviousOrder].[edf_no] AS MOBILERETENTIONPREVIOUSORDER_EDF_NO,[MobileRetentionPreviousOrder].[ord_place_by] AS MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_BY,[MobileRetentionPreviousOrder].[cancel_renew] AS MOBILERETENTIONPREVIOUSORDER_CANCEL_RENEW,[MobileRetentionPreviousOrder].[preferred_languages] AS MOBILERETENTIONPREVIOUSORDER_PREFERRED_LANGUAGES,[MobileRetentionPreviousOrder].[hkid] AS MOBILERETENTIONPREVIOUSORDER_HKID,[MobileRetentionPreviousOrder].[card_holder] AS MOBILERETENTIONPREVIOUSORDER_CARD_HOLDER,[MobileRetentionPreviousOrder].[ac_no] AS MOBILERETENTIONPREVIOUSORDER_AC_NO,[MobileRetentionPreviousOrder].[bill_cut_num] AS MOBILERETENTIONPREVIOUSORDER_BILL_CUT_NUM,[MobileRetentionPreviousOrder].[premium] AS MOBILERETENTIONPREVIOUSORDER_PREMIUM,[MobileRetentionPreviousOrder].[del_remark] AS MOBILERETENTIONPREVIOUSORDER_DEL_REMARK,[MobileRetentionPreviousOrder].[gift_imei2] AS MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI2,[MobileRetentionPreviousOrder].[reasons] AS MOBILERETENTIONPREVIOUSORDER_REASONS,[MobileRetentionPreviousOrder].[language] AS MOBILERETENTIONPREVIOUSORDER_LANGUAGE,[MobileRetentionPreviousOrder].[rebate_amount] AS MOBILERETENTIONPREVIOUSORDER_REBATE_AMOUNT,[MobileRetentionPreviousOrder].[ord_place_id_type] AS MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_ID_TYPE,[MobileRetentionPreviousOrder].[m_3rd_contact_no] AS MOBILERETENTIONPREVIOUSORDER_M_3RD_CONTACT_NO,[MobileRetentionPreviousOrder].[staff_no] AS MOBILERETENTIONPREVIOUSORDER_STAFF_NO,[MobileRetentionPreviousOrder].[sp_d_date] AS MOBILERETENTIONPREVIOUSORDER_SP_D_DATE,[MobileRetentionPreviousOrder].[bundle_name] AS MOBILERETENTIONPREVIOUSORDER_BUNDLE_NAME,[MobileRetentionPreviousOrder].[accessory_waive] AS MOBILERETENTIONPREVIOUSORDER_ACCESSORY_WAIVE,[MobileRetentionPreviousOrder].[sim_item_code] AS MOBILERETENTIONPREVIOUSORDER_SIM_ITEM_CODE,[MobileRetentionPreviousOrder].[cust_type] AS MOBILERETENTIONPREVIOUSORDER_CUST_TYPE,[MobileRetentionPreviousOrder].[card_ref_no] AS MOBILERETENTIONPREVIOUSORDER_CARD_REF_NO  FROM  [MobileRetentionPreviousOrder]";
            if (x_oArrayItemId==null)
            {
                string _oList = "(";
                for (int i = 0; i < x_oArrayItemId.Count; i++)
                {
                    if (i < (x_oArrayItemId.Count - 1))
                    {
                        _oList += "'" + x_oArrayItemId[i].ToString() + "',";
                    }
                    else
                    {
                        _oList += "'" + x_oArrayItemId[i].ToString() + "'";
                    }
                }
                _oList += ")";
                _sQuery += " WHERE [MobileRetentionPreviousOrder].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionPreviousOrder]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionPreviousOrder]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        MobileRetentionPreviousOrder _oMobileRetentionPreviousOrder = MobileRetentionPreviousOrderRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI"])) {_oMobileRetentionPreviousOrder.gift_imei = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI"]; }else{_oMobileRetentionPreviousOrder.gift_imei=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_S_PREMIUM4"])) {_oMobileRetentionPreviousOrder.s_premium4 = (string)_oData["MOBILERETENTIONPREVIOUSORDER_S_PREMIUM4"]; }else{_oMobileRetentionPreviousOrder.s_premium4=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_DESC4"])) {_oMobileRetentionPreviousOrder.gift_desc4 = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_DESC4"]; }else{_oMobileRetentionPreviousOrder.gift_desc4=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ACCESSORY_DESC"])) {_oMobileRetentionPreviousOrder.accessory_desc = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ACCESSORY_DESC"]; }else{_oMobileRetentionPreviousOrder.accessory_desc=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ACTION_REQUIRED"])) {_oMobileRetentionPreviousOrder.action_required = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ACTION_REQUIRED"]; }else{_oMobileRetentionPreviousOrder.action_required=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REGISTERED_ADDRESS_HIS_ID"])) {_oMobileRetentionPreviousOrder.registered_address_his_id = (global::System.Nullable<long>)_oData["MOBILERETENTIONPREVIOUSORDER_REGISTERED_ADDRESS_HIS_ID"]; }else{_oMobileRetentionPreviousOrder.registered_address_his_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_VAS_EFF_DATE"])) {_oMobileRetentionPreviousOrder.vas_eff_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_VAS_EFF_DATE"]; }else{_oMobileRetentionPreviousOrder.vas_eff_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_BANK_CODE"])) {_oMobileRetentionPreviousOrder.monthly_bank_account_bank_code = (string)_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_BANK_CODE"]; }else{_oMobileRetentionPreviousOrder.monthly_bank_account_bank_code=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_SPECIAL_HANDLING_DUMMY_CODE"])) {_oMobileRetentionPreviousOrder.special_handling_dummy_code = (string)_oData["MOBILERETENTIONPREVIOUSORDER_SPECIAL_HANDLING_DUMMY_CODE"]; }else{_oMobileRetentionPreviousOrder.special_handling_dummy_code=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_M_CARD_EXP_YEAR"])) {_oMobileRetentionPreviousOrder.m_card_exp_year = (string)_oData["MOBILERETENTIONPREVIOUSORDER_M_CARD_EXP_YEAR"]; }else{_oMobileRetentionPreviousOrder.m_card_exp_year=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REMARKS2PY"])) {_oMobileRetentionPreviousOrder.remarks2PY = (string)_oData["MOBILERETENTIONPREVIOUSORDER_REMARKS2PY"]; }else{_oMobileRetentionPreviousOrder.remarks2PY=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_TRADE_FIELD"])) {_oMobileRetentionPreviousOrder.trade_field = (string)_oData["MOBILERETENTIONPREVIOUSORDER_TRADE_FIELD"]; }else{_oMobileRetentionPreviousOrder.trade_field=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_TEL"])) {_oMobileRetentionPreviousOrder.ord_place_tel = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_TEL"]; }else{_oMobileRetentionPreviousOrder.ord_place_tel=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_ID_TYPE"])) {_oMobileRetentionPreviousOrder.ord_place_id_type = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_ID_TYPE"]; }else{_oMobileRetentionPreviousOrder.ord_place_id_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_COOLING_OFFER"])) {_oMobileRetentionPreviousOrder.cooling_offer = (string)_oData["MOBILERETENTIONPREVIOUSORDER_COOLING_OFFER"]; }else{_oMobileRetentionPreviousOrder.cooling_offer=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REC_NO"])) {_oMobileRetentionPreviousOrder.rec_no = (global::System.Nullable<int>)_oData["MOBILERETENTIONPREVIOUSORDER_REC_NO"]; }else{_oMobileRetentionPreviousOrder.rec_no=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_HANDSET_OFFER_REBATE_SCHEDULE"])) {_oMobileRetentionPreviousOrder.upgrade_handset_offer_rebate_schedule = (string)_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_HANDSET_OFFER_REBATE_SCHEDULE"]; }else{_oMobileRetentionPreviousOrder.upgrade_handset_offer_rebate_schedule=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CHANGE_PAYMENT_TYPE"])) {_oMobileRetentionPreviousOrder.change_payment_type = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CHANGE_PAYMENT_TYPE"]; }else{_oMobileRetentionPreviousOrder.change_payment_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_DATE_OF_BIRTH"])) {_oMobileRetentionPreviousOrder.date_of_birth = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_DATE_OF_BIRTH"]; }else{_oMobileRetentionPreviousOrder.date_of_birth=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CONTACT_PERSON"])) {_oMobileRetentionPreviousOrder.contact_person = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CONTACT_PERSON"]; }else{_oMobileRetentionPreviousOrder.contact_person=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EXTRA_D_CHARGE"])) {_oMobileRetentionPreviousOrder.extra_d_charge = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EXTRA_D_CHARGE"]; }else{_oMobileRetentionPreviousOrder.extra_d_charge=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_TL_NAME"])) {_oMobileRetentionPreviousOrder.tl_name = (string)_oData["MOBILERETENTIONPREVIOUSORDER_TL_NAME"]; }else{_oMobileRetentionPreviousOrder.tl_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_FAST_START"])) {_oMobileRetentionPreviousOrder.fast_start = (global::System.Nullable<bool>)_oData["MOBILERETENTIONPREVIOUSORDER_FAST_START"]; }else{_oMobileRetentionPreviousOrder.fast_start=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_SP_REF_NO"])) {_oMobileRetentionPreviousOrder.sp_ref_no = (string)_oData["MOBILERETENTIONPREVIOUSORDER_SP_REF_NO"]; }else{_oMobileRetentionPreviousOrder.sp_ref_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EDATE"])) {_oMobileRetentionPreviousOrder.edate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_EDATE"]; }else{_oMobileRetentionPreviousOrder.edate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EXIST_CUST_PLAN"])) {_oMobileRetentionPreviousOrder.exist_cust_plan = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EXIST_CUST_PLAN"]; }else{_oMobileRetentionPreviousOrder.exist_cust_plan=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_REL"])) {_oMobileRetentionPreviousOrder.ord_place_rel = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_REL"]; }else{_oMobileRetentionPreviousOrder.ord_place_rel=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_MRT_NO"])) {_oMobileRetentionPreviousOrder.mrt_no = (global::System.Nullable<int>)_oData["MOBILERETENTIONPREVIOUSORDER_MRT_NO"]; }else{_oMobileRetentionPreviousOrder.mrt_no=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_IMEI_NO"])) {_oMobileRetentionPreviousOrder.imei_no = (string)_oData["MOBILERETENTIONPREVIOUSORDER_IMEI_NO"]; }else{_oMobileRetentionPreviousOrder.imei_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EXISTING_SMART_PHONE_MODEL"])) {_oMobileRetentionPreviousOrder.existing_smart_phone_model = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EXISTING_SMART_PHONE_MODEL"]; }else{_oMobileRetentionPreviousOrder.existing_smart_phone_model=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_CODE3"])) {_oMobileRetentionPreviousOrder.gift_code3 = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_CODE3"]; }else{_oMobileRetentionPreviousOrder.gift_code3=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_BANK_CODE"])) {_oMobileRetentionPreviousOrder.bank_code = (string)_oData["MOBILERETENTIONPREVIOUSORDER_BANK_CODE"]; }else{_oMobileRetentionPreviousOrder.bank_code=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_POS_REF_NO"])) {_oMobileRetentionPreviousOrder.pos_ref_no = (string)_oData["MOBILERETENTIONPREVIOUSORDER_POS_REF_NO"]; }else{_oMobileRetentionPreviousOrder.pos_ref_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_BILL_CUT_DATE"])) {_oMobileRetentionPreviousOrder.bill_cut_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_BILL_CUT_DATE"]; }else{_oMobileRetentionPreviousOrder.bill_cut_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI3"])) {_oMobileRetentionPreviousOrder.gift_imei3 = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI3"]; }else{_oMobileRetentionPreviousOrder.gift_imei3=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EXIST_PLAN"])) {_oMobileRetentionPreviousOrder.exist_plan = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EXIST_PLAN"]; }else{_oMobileRetentionPreviousOrder.exist_plan=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_WAIVE"])) {_oMobileRetentionPreviousOrder.waive = (global::System.Nullable<bool>)_oData["MOBILERETENTIONPREVIOUSORDER_WAIVE"]; }else{_oMobileRetentionPreviousOrder.waive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_PROGRAM"])) {_oMobileRetentionPreviousOrder.program = (string)_oData["MOBILERETENTIONPREVIOUSORDER_PROGRAM"]; }else{_oMobileRetentionPreviousOrder.program=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_FIRST_MONTH_FEE"])) {_oMobileRetentionPreviousOrder.first_month_fee = (string)_oData["MOBILERETENTIONPREVIOUSORDER_FIRST_MONTH_FEE"]; }else{_oMobileRetentionPreviousOrder.first_month_fee=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_R_OFFER"])) {_oMobileRetentionPreviousOrder.r_offer = (string)_oData["MOBILERETENTIONPREVIOUSORDER_R_OFFER"]; }else{_oMobileRetentionPreviousOrder.r_offer=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CID"])) {_oMobileRetentionPreviousOrder.cid = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CID"]; }else{_oMobileRetentionPreviousOrder.cid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_DID"])) {_oMobileRetentionPreviousOrder.did = (string)_oData["MOBILERETENTIONPREVIOUSORDER_DID"]; }else{_oMobileRetentionPreviousOrder.did=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_FTG_TENURE"])) {_oMobileRetentionPreviousOrder.ftg_tenure = (string)_oData["MOBILERETENTIONPREVIOUSORDER_FTG_TENURE"]; }else{_oMobileRetentionPreviousOrder.ftg_tenure=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CON_PER"])) {_oMobileRetentionPreviousOrder.con_per = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CON_PER"]; }else{_oMobileRetentionPreviousOrder.con_per=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_CODE4"])) {_oMobileRetentionPreviousOrder.gift_code4 = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_CODE4"]; }else{_oMobileRetentionPreviousOrder.gift_code4=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EASYWATCH_TYPE"])) {_oMobileRetentionPreviousOrder.easywatch_type = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EASYWATCH_TYPE"]; }else{_oMobileRetentionPreviousOrder.easywatch_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_SMS_MRT"])) {_oMobileRetentionPreviousOrder.sms_mrt = (string)_oData["MOBILERETENTIONPREVIOUSORDER_SMS_MRT"]; }else{_oMobileRetentionPreviousOrder.sms_mrt=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_TPY_HIS_ID"])) {_oMobileRetentionPreviousOrder.tpy_his_id = (global::System.Nullable<long>)_oData["MOBILERETENTIONPREVIOUSORDER_TPY_HIS_ID"]; }else{_oMobileRetentionPreviousOrder.tpy_his_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_PAYMENT_METHOD"])) {_oMobileRetentionPreviousOrder.monthly_payment_method = (string)_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_PAYMENT_METHOD"]; }else{_oMobileRetentionPreviousOrder.monthly_payment_method=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REMARKS2EDF"])) {_oMobileRetentionPreviousOrder.remarks2EDF = (string)_oData["MOBILERETENTIONPREVIOUSORDER_REMARKS2EDF"]; }else{_oMobileRetentionPreviousOrder.remarks2EDF=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_DESC3"])) {_oMobileRetentionPreviousOrder.gift_desc3 = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_DESC3"]; }else{_oMobileRetentionPreviousOrder.gift_desc3=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI4"])) {_oMobileRetentionPreviousOrder.gift_imei4 = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI4"]; }else{_oMobileRetentionPreviousOrder.gift_imei4=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_OLD_ORD_ID"])) {_oMobileRetentionPreviousOrder.old_ord_id = (global::System.Nullable<int>)_oData["MOBILERETENTIONPREVIOUSORDER_OLD_ORD_ID"]; }else{_oMobileRetentionPreviousOrder.old_ord_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_HKID2"])) {_oMobileRetentionPreviousOrder.monthly_bank_account_hkid2 = (string)_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_HKID2"]; }else{_oMobileRetentionPreviousOrder.monthly_bank_account_hkid2=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_D_DATE"])) {_oMobileRetentionPreviousOrder.d_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_D_DATE"]; }else{_oMobileRetentionPreviousOrder.d_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_DESC"])) {_oMobileRetentionPreviousOrder.gift_desc = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_DESC"]; }else{_oMobileRetentionPreviousOrder.gift_desc=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_SALESMANCODE"])) {_oMobileRetentionPreviousOrder.salesmancode = (string)_oData["MOBILERETENTIONPREVIOUSORDER_SALESMANCODE"]; }else{_oMobileRetentionPreviousOrder.salesmancode=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_POOL"])) {_oMobileRetentionPreviousOrder.pool = (string)_oData["MOBILERETENTIONPREVIOUSORDER_POOL"]; }else{_oMobileRetentionPreviousOrder.pool=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CN_MRT_NO"])) {_oMobileRetentionPreviousOrder.cn_mrt_no = (global::System.Nullable<long>)_oData["MOBILERETENTIONPREVIOUSORDER_CN_MRT_NO"]; }else{_oMobileRetentionPreviousOrder.cn_mrt_no=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ACCESSORY_IMEI"])) {_oMobileRetentionPreviousOrder.accessory_imei = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ACCESSORY_IMEI"]; }else{_oMobileRetentionPreviousOrder.accessory_imei=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_THIRD_PARTY_CREDIT_CARD"])) {_oMobileRetentionPreviousOrder.third_party_credit_card = (string)_oData["MOBILERETENTIONPREVIOUSORDER_THIRD_PARTY_CREDIT_CARD"]; }else{_oMobileRetentionPreviousOrder.third_party_credit_card=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CARD_REF_NO"])) {_oMobileRetentionPreviousOrder.card_ref_no = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CARD_REF_NO"]; }else{_oMobileRetentionPreviousOrder.card_ref_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_COOLING_DATE"])) {_oMobileRetentionPreviousOrder.cooling_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_COOLING_DATE"]; }else{_oMobileRetentionPreviousOrder.cooling_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_SPECIAL_APPROVAL"])) {_oMobileRetentionPreviousOrder.special_approval = (string)_oData["MOBILERETENTIONPREVIOUSORDER_SPECIAL_APPROVAL"]; }else{_oMobileRetentionPreviousOrder.special_approval=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_CONTRACT_EDATE"])) {_oMobileRetentionPreviousOrder.upgrade_existing_contract_edate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_CONTRACT_EDATE"]; }else{_oMobileRetentionPreviousOrder.upgrade_existing_contract_edate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ACCESSORY_CODE"])) {_oMobileRetentionPreviousOrder.accessory_code = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ACCESSORY_CODE"]; }else{_oMobileRetentionPreviousOrder.accessory_code=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_BILL_MEDIUM"])) {_oMobileRetentionPreviousOrder.bill_medium = (string)_oData["MOBILERETENTIONPREVIOUSORDER_BILL_MEDIUM"]; }else{_oMobileRetentionPreviousOrder.bill_medium=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_S_PREMIUM"])) {_oMobileRetentionPreviousOrder.s_premium = (string)_oData["MOBILERETENTIONPREVIOUSORDER_S_PREMIUM"]; }else{_oMobileRetentionPreviousOrder.s_premium=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REF_STAFF_NO"])) {_oMobileRetentionPreviousOrder.ref_staff_no = (string)_oData["MOBILERETENTIONPREVIOUSORDER_REF_STAFF_NO"]; }else{_oMobileRetentionPreviousOrder.ref_staff_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ACCESSORY_PRICE"])) {_oMobileRetentionPreviousOrder.accessory_price = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ACCESSORY_PRICE"]; }else{_oMobileRetentionPreviousOrder.accessory_price=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_M_CARD_EXP_MONTH"])) {_oMobileRetentionPreviousOrder.m_card_exp_month = (string)_oData["MOBILERETENTIONPREVIOUSORDER_M_CARD_EXP_MONTH"]; }else{_oMobileRetentionPreviousOrder.m_card_exp_month=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_INSTALLMENT_PERIOD"])) {_oMobileRetentionPreviousOrder.installment_period = (string)_oData["MOBILERETENTIONPREVIOUSORDER_INSTALLMENT_PERIOD"]; }else{_oMobileRetentionPreviousOrder.installment_period=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_M_CARD_TYPE"])) {_oMobileRetentionPreviousOrder.m_card_type = (string)_oData["MOBILERETENTIONPREVIOUSORDER_M_CARD_TYPE"]; }else{_oMobileRetentionPreviousOrder.m_card_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EASYWATCH_ORD_ID"])) {_oMobileRetentionPreviousOrder.easywatch_ord_id = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EASYWATCH_ORD_ID"]; }else{_oMobileRetentionPreviousOrder.easywatch_ord_id=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_NORMAL_REBATE"])) {_oMobileRetentionPreviousOrder.normal_rebate = (global::System.Nullable<bool>)_oData["MOBILERETENTIONPREVIOUSORDER_NORMAL_REBATE"]; }else{_oMobileRetentionPreviousOrder.normal_rebate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_M_REBATE_AMOUNT"])) {_oMobileRetentionPreviousOrder.m_rebate_amount = (string)_oData["MOBILERETENTIONPREVIOUSORDER_M_REBATE_AMOUNT"]; }else{_oMobileRetentionPreviousOrder.m_rebate_amount=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_M_CARD_HOLDER2"])) {_oMobileRetentionPreviousOrder.m_card_holder2 = (string)_oData["MOBILERETENTIONPREVIOUSORDER_M_CARD_HOLDER2"]; }else{_oMobileRetentionPreviousOrder.m_card_holder2=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_BILL_MEDIUM_EMAIL"])) {_oMobileRetentionPreviousOrder.bill_medium_email = (string)_oData["MOBILERETENTIONPREVIOUSORDER_BILL_MEDIUM_EMAIL"]; }else{_oMobileRetentionPreviousOrder.bill_medium_email=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ACTIVE"])) {_oMobileRetentionPreviousOrder.active = (global::System.Nullable<bool>)_oData["MOBILERETENTIONPREVIOUSORDER_ACTIVE"]; }else{_oMobileRetentionPreviousOrder.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_S_PREMIUM1"])) {_oMobileRetentionPreviousOrder.s_premium1 = (string)_oData["MOBILERETENTIONPREVIOUSORDER_S_PREMIUM1"]; }else{_oMobileRetentionPreviousOrder.s_premium1=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CARD_EXP_MONTH"])) {_oMobileRetentionPreviousOrder.card_exp_month = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CARD_EXP_MONTH"]; }else{_oMobileRetentionPreviousOrder.card_exp_month=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_OB_PROGRAM_ID"])) {_oMobileRetentionPreviousOrder.ob_program_id = (string)_oData["MOBILERETENTIONPREVIOUSORDER_OB_PROGRAM_ID"]; }else{_oMobileRetentionPreviousOrder.ob_program_id=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_SKU"])) {_oMobileRetentionPreviousOrder.sku = (string)_oData["MOBILERETENTIONPREVIOUSORDER_SKU"]; }else{_oMobileRetentionPreviousOrder.sku=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REF_SALESMANCODE"])) {_oMobileRetentionPreviousOrder.ref_salesmancode = (string)_oData["MOBILERETENTIONPREVIOUSORDER_REF_SALESMANCODE"]; }else{_oMobileRetentionPreviousOrder.ref_salesmancode=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GO_WIRELESS_PACKAGE_CODE"])) {_oMobileRetentionPreviousOrder.go_wireless_package_code = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GO_WIRELESS_PACKAGE_CODE"]; }else{_oMobileRetentionPreviousOrder.go_wireless_package_code=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_THIRD_PARTY_HKID"])) {_oMobileRetentionPreviousOrder.third_party_hkid = (string)_oData["MOBILERETENTIONPREVIOUSORDER_THIRD_PARTY_HKID"]; }else{_oMobileRetentionPreviousOrder.third_party_hkid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_PCCW_CUSTOMER"])) {_oMobileRetentionPreviousOrder.upgrade_existing_pccw_customer = (string)_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_PCCW_CUSTOMER"]; }else{_oMobileRetentionPreviousOrder.upgrade_existing_pccw_customer=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_D_ADDRESS"])) {_oMobileRetentionPreviousOrder.d_address = (string)_oData["MOBILERETENTIONPREVIOUSORDER_D_ADDRESS"]; }else{_oMobileRetentionPreviousOrder.d_address=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_REGISTERED_MOBILE_NO"])) {_oMobileRetentionPreviousOrder.upgrade_registered_mobile_no = (string)_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_REGISTERED_MOBILE_NO"]; }else{_oMobileRetentionPreviousOrder.upgrade_registered_mobile_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_CUSTOMER_TYPE"])) {_oMobileRetentionPreviousOrder.upgrade_existing_customer_type = (string)_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_CUSTOMER_TYPE"]; }else{_oMobileRetentionPreviousOrder.upgrade_existing_customer_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_NORMAL_REBATE_TYPE"])) {_oMobileRetentionPreviousOrder.normal_rebate_type = (string)_oData["MOBILERETENTIONPREVIOUSORDER_NORMAL_REBATE_TYPE"]; }else{_oMobileRetentionPreviousOrder.normal_rebate_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_DESC2"])) {_oMobileRetentionPreviousOrder.gift_desc2 = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_DESC2"]; }else{_oMobileRetentionPreviousOrder.gift_desc2=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_BRANCH_CODE"])) {_oMobileRetentionPreviousOrder.monthly_bank_account_branch_code = (string)_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_BRANCH_CODE"]; }else{_oMobileRetentionPreviousOrder.monthly_bank_account_branch_code=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REMARKS"])) {_oMobileRetentionPreviousOrder.remarks = (string)_oData["MOBILERETENTIONPREVIOUSORDER_REMARKS"]; }else{_oMobileRetentionPreviousOrder.remarks=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ACCEPT"])) {_oMobileRetentionPreviousOrder.accept = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ACCEPT"]; }else{_oMobileRetentionPreviousOrder.accept=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_DELIVERY_EXCHANGE"])) {_oMobileRetentionPreviousOrder.delivery_exchange = (string)_oData["MOBILERETENTIONPREVIOUSORDER_DELIVERY_EXCHANGE"]; }else{_oMobileRetentionPreviousOrder.delivery_exchange=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_CODE2"])) {_oMobileRetentionPreviousOrder.gift_code2 = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_CODE2"]; }else{_oMobileRetentionPreviousOrder.gift_code2=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_PREPAYMENT_WAIVE"])) {_oMobileRetentionPreviousOrder.prepayment_waive = (global::System.Nullable<bool>)_oData["MOBILERETENTIONPREVIOUSORDER_PREPAYMENT_WAIVE"]; }else{_oMobileRetentionPreviousOrder.prepayment_waive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EXISTING_SMART_PHONE_IMEI"])) {_oMobileRetentionPreviousOrder.existing_smart_phone_imei = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EXISTING_SMART_PHONE_IMEI"]; }else{_oMobileRetentionPreviousOrder.existing_smart_phone_imei=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_MNP_HIS_ID"])) {_oMobileRetentionPreviousOrder.mnp_his_id = (global::System.Nullable<long>)_oData["MOBILERETENTIONPREVIOUSORDER_MNP_HIS_ID"]; }else{_oMobileRetentionPreviousOrder.mnp_his_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CUST_NAME"])) {_oMobileRetentionPreviousOrder.cust_name = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CUST_NAME"]; }else{_oMobileRetentionPreviousOrder.cust_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CUST_TYPE"])) {_oMobileRetentionPreviousOrder.cust_type = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CUST_TYPE"]; }else{_oMobileRetentionPreviousOrder.cust_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_SPONSORSHIPS_AMOUNT"])) {_oMobileRetentionPreviousOrder.upgrade_sponsorships_amount = (string)_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_SPONSORSHIPS_AMOUNT"]; }else{_oMobileRetentionPreviousOrder.upgrade_sponsorships_amount=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_BILL_MEDIUM_WAIVE"])) {_oMobileRetentionPreviousOrder.bill_medium_waive = (global::System.Nullable<bool>)_oData["MOBILERETENTIONPREVIOUSORDER_BILL_MEDIUM_WAIVE"]; }else{_oMobileRetentionPreviousOrder.bill_medium_waive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_DELIVERY_EXCHANGE_LOCATION"])) {_oMobileRetentionPreviousOrder.delivery_exchange_location = (string)_oData["MOBILERETENTIONPREVIOUSORDER_DELIVERY_EXCHANGE_LOCATION"]; }else{_oMobileRetentionPreviousOrder.delivery_exchange_location=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_HS_OFFER_TYPE_ID"])) {_oMobileRetentionPreviousOrder.hs_offer_type_id = (global::System.Nullable<int>)_oData["MOBILERETENTIONPREVIOUSORDER_HS_OFFER_TYPE_ID"]; }else{_oMobileRetentionPreviousOrder.hs_offer_type_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ORG_FEE"])) {_oMobileRetentionPreviousOrder.org_fee = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ORG_FEE"]; }else{_oMobileRetentionPreviousOrder.org_fee=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REBATE"])) {_oMobileRetentionPreviousOrder.rebate = (string)_oData["MOBILERETENTIONPREVIOUSORDER_REBATE"]; }else{_oMobileRetentionPreviousOrder.rebate=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_TYPE"])) {_oMobileRetentionPreviousOrder.upgrade_type = (string)_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_TYPE"]; }else{_oMobileRetentionPreviousOrder.upgrade_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GO_WIRELESS"])) {_oMobileRetentionPreviousOrder.go_wireless = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GO_WIRELESS"]; }else{_oMobileRetentionPreviousOrder.go_wireless=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EXTRA_REBATE"])) {_oMobileRetentionPreviousOrder.extra_rebate = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EXTRA_REBATE"]; }else{_oMobileRetentionPreviousOrder.extra_rebate=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_PLAN_EFF"])) {_oMobileRetentionPreviousOrder.plan_eff = (string)_oData["MOBILERETENTIONPREVIOUSORDER_PLAN_EFF"]; }else{_oMobileRetentionPreviousOrder.plan_eff=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EXTRA_REBATE_AMOUNT"])) {_oMobileRetentionPreviousOrder.extra_rebate_amount = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EXTRA_REBATE_AMOUNT"]; }else{_oMobileRetentionPreviousOrder.extra_rebate_amount=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CARD_EXP_YEAR"])) {_oMobileRetentionPreviousOrder.card_exp_year = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CARD_EXP_YEAR"]; }else{_oMobileRetentionPreviousOrder.card_exp_year=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_CONTRACT_SDATE"])) {_oMobileRetentionPreviousOrder.upgrade_existing_contract_sdate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_CONTRACT_SDATE"]; }else{_oMobileRetentionPreviousOrder.upgrade_existing_contract_sdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_HKID"])) {_oMobileRetentionPreviousOrder.ord_place_hkid = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_HKID"]; }else{_oMobileRetentionPreviousOrder.ord_place_hkid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REGISTER_ADDRESS"])) {_oMobileRetentionPreviousOrder.register_address = (string)_oData["MOBILERETENTIONPREVIOUSORDER_REGISTER_ADDRESS"]; }else{_oMobileRetentionPreviousOrder.register_address=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GENDER"])) {_oMobileRetentionPreviousOrder.gender = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GENDER"]; }else{_oMobileRetentionPreviousOrder.gender=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_LOB_AC"])) {_oMobileRetentionPreviousOrder.lob_ac = (string)_oData["MOBILERETENTIONPREVIOUSORDER_LOB_AC"]; }else{_oMobileRetentionPreviousOrder.lob_ac=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_SIM_MRT_NO"])) {_oMobileRetentionPreviousOrder.sim_mrt_no = (global::System.Nullable<int>)_oData["MOBILERETENTIONPREVIOUSORDER_SIM_MRT_NO"]; }else{_oMobileRetentionPreviousOrder.sim_mrt_no=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REDEMPTION_NOTICE_OPTION"])) {_oMobileRetentionPreviousOrder.redemption_notice_option = (string)_oData["MOBILERETENTIONPREVIOUSORDER_REDEMPTION_NOTICE_OPTION"]; }else{_oMobileRetentionPreviousOrder.redemption_notice_option=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_DELIVERY_COLLECTION_TYPE"])) {_oMobileRetentionPreviousOrder.delivery_collection_type = (string)_oData["MOBILERETENTIONPREVIOUSORDER_DELIVERY_COLLECTION_TYPE"]; }else{_oMobileRetentionPreviousOrder.delivery_collection_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ACTION_DATE"])) {_oMobileRetentionPreviousOrder.action_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_ACTION_DATE"]; }else{_oMobileRetentionPreviousOrder.action_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_THIRD_PARTY_ID_TYPE"])) {_oMobileRetentionPreviousOrder.third_party_id_type = (string)_oData["MOBILERETENTIONPREVIOUSORDER_THIRD_PARTY_ID_TYPE"]; }else{_oMobileRetentionPreviousOrder.third_party_id_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ORG_FTG"])) {_oMobileRetentionPreviousOrder.org_ftg = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ORG_FTG"]; }else{_oMobileRetentionPreviousOrder.org_ftg=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_SERVICE_TENURE"])) {_oMobileRetentionPreviousOrder.upgrade_service_tenure = (string)_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_SERVICE_TENURE"]; }else{_oMobileRetentionPreviousOrder.upgrade_service_tenure=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_PAYMENT_TYPE"])) {_oMobileRetentionPreviousOrder.monthly_payment_type = (string)_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_PAYMENT_TYPE"]; }else{_oMobileRetentionPreviousOrder.monthly_payment_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CONTACT_NO"])) {_oMobileRetentionPreviousOrder.contact_no = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CONTACT_NO"]; }else{_oMobileRetentionPreviousOrder.contact_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ORG_MRT"])) {_oMobileRetentionPreviousOrder.org_mrt = (global::System.Nullable<int>)_oData["MOBILERETENTIONPREVIOUSORDER_ORG_MRT"]; }else{_oMobileRetentionPreviousOrder.org_mrt=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_SIM_ITEM_NAME"])) {_oMobileRetentionPreviousOrder.sim_item_name = (string)_oData["MOBILERETENTIONPREVIOUSORDER_SIM_ITEM_NAME"]; }else{_oMobileRetentionPreviousOrder.sim_item_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_PAY_METHOD"])) {_oMobileRetentionPreviousOrder.pay_method = (string)_oData["MOBILERETENTIONPREVIOUSORDER_PAY_METHOD"]; }else{_oMobileRetentionPreviousOrder.pay_method=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_HS_MODEL"])) {_oMobileRetentionPreviousOrder.hs_model = (string)_oData["MOBILERETENTIONPREVIOUSORDER_HS_MODEL"]; }else{_oMobileRetentionPreviousOrder.hs_model=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_CODE"])) {_oMobileRetentionPreviousOrder.gift_code = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_CODE"]; }else{_oMobileRetentionPreviousOrder.gift_code=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_HKID"])) {_oMobileRetentionPreviousOrder.monthly_bank_account_hkid = (string)_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_HKID"]; }else{_oMobileRetentionPreviousOrder.monthly_bank_account_hkid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EXTRA_OFFER"])) {_oMobileRetentionPreviousOrder.extra_offer = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EXTRA_OFFER"]; }else{_oMobileRetentionPreviousOrder.extra_offer=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_NO"])) {_oMobileRetentionPreviousOrder.monthly_bank_account_no = (string)_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_NO"]; }else{_oMobileRetentionPreviousOrder.monthly_bank_account_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_FIRST_MONTH_LICENSE_FEE"])) {_oMobileRetentionPreviousOrder.first_month_license_fee = (string)_oData["MOBILERETENTIONPREVIOUSORDER_FIRST_MONTH_LICENSE_FEE"]; }else{_oMobileRetentionPreviousOrder.first_month_license_fee=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_RETRIEVE_CNT"])) {_oMobileRetentionPreviousOrder.retrieve_cnt = (global::System.Nullable<int>)_oData["MOBILERETENTIONPREVIOUSORDER_RETRIEVE_CNT"]; }else{_oMobileRetentionPreviousOrder.retrieve_cnt=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_DDATE"])) {_oMobileRetentionPreviousOrder.ddate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_DDATE"]; }else{_oMobileRetentionPreviousOrder.ddate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_S_PREMIUM2"])) {_oMobileRetentionPreviousOrder.s_premium2 = (string)_oData["MOBILERETENTIONPREVIOUSORDER_S_PREMIUM2"]; }else{_oMobileRetentionPreviousOrder.s_premium2=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_ID_TYPE"])) {_oMobileRetentionPreviousOrder.monthly_bank_account_id_type = (string)_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_ID_TYPE"]; }else{_oMobileRetentionPreviousOrder.monthly_bank_account_id_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CARD_TYPE"])) {_oMobileRetentionPreviousOrder.card_type = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CARD_TYPE"]; }else{_oMobileRetentionPreviousOrder.card_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_NEXT_BILL"])) {_oMobileRetentionPreviousOrder.next_bill = (global::System.Nullable<bool>)_oData["MOBILERETENTIONPREVIOUSORDER_NEXT_BILL"]; }else{_oMobileRetentionPreviousOrder.next_bill=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_PCD_PAID_GO_WIRELESS"])) {_oMobileRetentionPreviousOrder.pcd_paid_go_wireless = (global::System.Nullable<bool>)_oData["MOBILERETENTIONPREVIOUSORDER_PCD_PAID_GO_WIRELESS"]; }else{_oMobileRetentionPreviousOrder.pcd_paid_go_wireless=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_REBATE_CALCULATION"])) {_oMobileRetentionPreviousOrder.upgrade_rebate_calculation = (string)_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_REBATE_CALCULATION"]; }else{_oMobileRetentionPreviousOrder.upgrade_rebate_calculation=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EXT_PLACE_TEL"])) {_oMobileRetentionPreviousOrder.ext_place_tel = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EXT_PLACE_TEL"]; }else{_oMobileRetentionPreviousOrder.ext_place_tel=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_M_3RD_HKID"])) {_oMobileRetentionPreviousOrder.m_3rd_hkid = (string)_oData["MOBILERETENTIONPREVIOUSORDER_M_3RD_HKID"]; }else{_oMobileRetentionPreviousOrder.m_3rd_hkid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_RETENTION_TYPE"])) {_oMobileRetentionPreviousOrder.retention_type = (string)_oData["MOBILERETENTIONPREVIOUSORDER_RETENTION_TYPE"]; }else{_oMobileRetentionPreviousOrder.retention_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_BILL_ADDRESS_HIS_ID"])) {_oMobileRetentionPreviousOrder.bill_address_his_id = (global::System.Nullable<long>)_oData["MOBILERETENTIONPREVIOUSORDER_BILL_ADDRESS_HIS_ID"]; }else{_oMobileRetentionPreviousOrder.bill_address_his_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_AIG_GIFT"])) {_oMobileRetentionPreviousOrder.aig_gift = (string)_oData["MOBILERETENTIONPREVIOUSORDER_AIG_GIFT"]; }else{_oMobileRetentionPreviousOrder.aig_gift=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CUST_STAFF_NO"])) {_oMobileRetentionPreviousOrder.cust_staff_no = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CUST_STAFF_NO"]; }else{_oMobileRetentionPreviousOrder.cust_staff_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ORDER_ID"])) {_oMobileRetentionPreviousOrder.order_id = (global::System.Nullable<int>)_oData["MOBILERETENTIONPREVIOUSORDER_ORDER_ID"]; }else{_oMobileRetentionPreviousOrder.order_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_FAMILY_NAME"])) {_oMobileRetentionPreviousOrder.family_name = (string)_oData["MOBILERETENTIONPREVIOUSORDER_FAMILY_NAME"]; }else{_oMobileRetentionPreviousOrder.family_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CDATE"])) {_oMobileRetentionPreviousOrder.cdate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_CDATE"]; }else{_oMobileRetentionPreviousOrder.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_STATUS_BY_CS_ADMIN"])) {_oMobileRetentionPreviousOrder.status_by_cs_admin = (string)_oData["MOBILERETENTIONPREVIOUSORDER_STATUS_BY_CS_ADMIN"]; }else{_oMobileRetentionPreviousOrder.status_by_cs_admin=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_SIM_ITEM_NUMBER"])) {_oMobileRetentionPreviousOrder.sim_item_number = (string)_oData["MOBILERETENTIONPREVIOUSORDER_SIM_ITEM_NUMBER"]; }else{_oMobileRetentionPreviousOrder.sim_item_number=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_VIP_CASE"])) {_oMobileRetentionPreviousOrder.vip_case = (string)_oData["MOBILERETENTIONPREVIOUSORDER_VIP_CASE"]; }else{_oMobileRetentionPreviousOrder.vip_case=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIVEN_NAME"])) {_oMobileRetentionPreviousOrder.given_name = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIVEN_NAME"]; }else{_oMobileRetentionPreviousOrder.given_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_LOG_DATE"])) {_oMobileRetentionPreviousOrder.log_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_LOG_DATE"]; }else{_oMobileRetentionPreviousOrder.log_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EXTN"])) {_oMobileRetentionPreviousOrder.extn = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EXTN"]; }else{_oMobileRetentionPreviousOrder.extn=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_D_TIME"])) {_oMobileRetentionPreviousOrder.d_time = (string)_oData["MOBILERETENTIONPREVIOUSORDER_D_TIME"]; }else{_oMobileRetentionPreviousOrder.d_time=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_BANK_NAME"])) {_oMobileRetentionPreviousOrder.bank_name = (string)_oData["MOBILERETENTIONPREVIOUSORDER_BANK_NAME"]; }else{_oMobileRetentionPreviousOrder.bank_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_DELIVERY_EXCHANGE_OPTION"])) {_oMobileRetentionPreviousOrder.delivery_exchange_option = (string)_oData["MOBILERETENTIONPREVIOUSORDER_DELIVERY_EXCHANGE_OPTION"]; }else{_oMobileRetentionPreviousOrder.delivery_exchange_option=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_SERVICE_ACCOUNT_NO"])) {_oMobileRetentionPreviousOrder.upgrade_service_account_no = (string)_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_SERVICE_ACCOUNT_NO"]; }else{_oMobileRetentionPreviousOrder.upgrade_service_account_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ACTION_OF_RATE_PLAN_EFFECTIVE"])) {_oMobileRetentionPreviousOrder.action_of_rate_plan_effective = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ACTION_OF_RATE_PLAN_EFFECTIVE"]; }else{_oMobileRetentionPreviousOrder.action_of_rate_plan_effective=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_M_CARD_NO"])) {_oMobileRetentionPreviousOrder.m_card_no = (string)_oData["MOBILERETENTIONPREVIOUSORDER_M_CARD_NO"]; }else{_oMobileRetentionPreviousOrder.m_card_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EXISTING_CONTRACT_END_DATE"])) {_oMobileRetentionPreviousOrder.existing_contract_end_date = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EXISTING_CONTRACT_END_DATE"]; }else{_oMobileRetentionPreviousOrder.existing_contract_end_date=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CON_EFF_DATE"])) {_oMobileRetentionPreviousOrder.con_eff_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_CON_EFF_DATE"]; }else{_oMobileRetentionPreviousOrder.con_eff_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_M_3RD_HKID2"])) {_oMobileRetentionPreviousOrder.m_3rd_hkid2 = (string)_oData["MOBILERETENTIONPREVIOUSORDER_M_3RD_HKID2"]; }else{_oMobileRetentionPreviousOrder.m_3rd_hkid2=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_AMOUNT"])) {_oMobileRetentionPreviousOrder.amount = (string)_oData["MOBILERETENTIONPREVIOUSORDER_AMOUNT"]; }else{_oMobileRetentionPreviousOrder.amount=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ID_TYPE"])) {_oMobileRetentionPreviousOrder.id_type = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ID_TYPE"]; }else{_oMobileRetentionPreviousOrder.id_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_RATE_PLAN"])) {_oMobileRetentionPreviousOrder.rate_plan = (string)_oData["MOBILERETENTIONPREVIOUSORDER_RATE_PLAN"]; }else{_oMobileRetentionPreviousOrder.rate_plan=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CHANNEL"])) {_oMobileRetentionPreviousOrder.channel = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CHANNEL"]; }else{_oMobileRetentionPreviousOrder.channel=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ACTION_EFF_DATE"])) {_oMobileRetentionPreviousOrder.action_eff_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_ACTION_EFF_DATE"]; }else{_oMobileRetentionPreviousOrder.action_eff_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ISSUE_TYPE"])) {_oMobileRetentionPreviousOrder.issue_type = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ISSUE_TYPE"]; }else{_oMobileRetentionPreviousOrder.issue_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_FREE_MON"])) {_oMobileRetentionPreviousOrder.free_mon = (string)_oData["MOBILERETENTIONPREVIOUSORDER_FREE_MON"]; }else{_oMobileRetentionPreviousOrder.free_mon=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_PLAN_EFF_DATE"])) {_oMobileRetentionPreviousOrder.plan_eff_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_PLAN_EFF_DATE"]; }else{_oMobileRetentionPreviousOrder.plan_eff_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_DEL_REMARK"])) {_oMobileRetentionPreviousOrder.del_remark = (string)_oData["MOBILERETENTIONPREVIOUSORDER_DEL_REMARK"]; }else{_oMobileRetentionPreviousOrder.del_remark=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_TEAMCODE"])) {_oMobileRetentionPreviousOrder.teamcode = (string)_oData["MOBILERETENTIONPREVIOUSORDER_TEAMCODE"]; }else{_oMobileRetentionPreviousOrder.teamcode=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_STAFF_NAME"])) {_oMobileRetentionPreviousOrder.staff_name = (string)_oData["MOBILERETENTIONPREVIOUSORDER_STAFF_NAME"]; }else{_oMobileRetentionPreviousOrder.staff_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EDF_NO"])) {_oMobileRetentionPreviousOrder.edf_no = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EDF_NO"]; }else{_oMobileRetentionPreviousOrder.edf_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_BY"])) {_oMobileRetentionPreviousOrder.ord_place_by = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_BY"]; }else{_oMobileRetentionPreviousOrder.ord_place_by=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CANCEL_RENEW"])) {_oMobileRetentionPreviousOrder.cancel_renew = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CANCEL_RENEW"]; }else{_oMobileRetentionPreviousOrder.cancel_renew=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_PREFERRED_LANGUAGES"])) {_oMobileRetentionPreviousOrder.preferred_languages = (string)_oData["MOBILERETENTIONPREVIOUSORDER_PREFERRED_LANGUAGES"]; }else{_oMobileRetentionPreviousOrder.preferred_languages=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_HKID"])) {_oMobileRetentionPreviousOrder.hkid = (string)_oData["MOBILERETENTIONPREVIOUSORDER_HKID"]; }else{_oMobileRetentionPreviousOrder.hkid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CARD_NO"])) {_oMobileRetentionPreviousOrder.card_no = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CARD_NO"]; }else{_oMobileRetentionPreviousOrder.card_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_AC_NO"])) {_oMobileRetentionPreviousOrder.ac_no = (string)_oData["MOBILERETENTIONPREVIOUSORDER_AC_NO"]; }else{_oMobileRetentionPreviousOrder.ac_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_BILL_CUT_NUM"])) {_oMobileRetentionPreviousOrder.bill_cut_num = (global::System.Nullable<int>)_oData["MOBILERETENTIONPREVIOUSORDER_BILL_CUT_NUM"]; }else{_oMobileRetentionPreviousOrder.bill_cut_num=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_PREMIUM"])) {_oMobileRetentionPreviousOrder.premium = (string)_oData["MOBILERETENTIONPREVIOUSORDER_PREMIUM"]; }else{_oMobileRetentionPreviousOrder.premium=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_M_3RD_ID_TYPE"])) {_oMobileRetentionPreviousOrder.m_3rd_id_type = (string)_oData["MOBILERETENTIONPREVIOUSORDER_M_3RD_ID_TYPE"]; }else{_oMobileRetentionPreviousOrder.m_3rd_id_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI2"])) {_oMobileRetentionPreviousOrder.gift_imei2 = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI2"]; }else{_oMobileRetentionPreviousOrder.gift_imei2=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REASONS"])) {_oMobileRetentionPreviousOrder.reasons = (string)_oData["MOBILERETENTIONPREVIOUSORDER_REASONS"]; }else{_oMobileRetentionPreviousOrder.reasons=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_LANGUAGE"])) {_oMobileRetentionPreviousOrder.language = (string)_oData["MOBILERETENTIONPREVIOUSORDER_LANGUAGE"]; }else{_oMobileRetentionPreviousOrder.language=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REBATE_AMOUNT"])) {_oMobileRetentionPreviousOrder.rebate_amount = (string)_oData["MOBILERETENTIONPREVIOUSORDER_REBATE_AMOUNT"]; }else{_oMobileRetentionPreviousOrder.rebate_amount=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_LOB"])) {_oMobileRetentionPreviousOrder.lob = (string)_oData["MOBILERETENTIONPREVIOUSORDER_LOB"]; }else{_oMobileRetentionPreviousOrder.lob=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_M_3RD_CONTACT_NO"])) {_oMobileRetentionPreviousOrder.m_3rd_contact_no = (string)_oData["MOBILERETENTIONPREVIOUSORDER_M_3RD_CONTACT_NO"]; }else{_oMobileRetentionPreviousOrder.m_3rd_contact_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_STAFF_NO"])) {_oMobileRetentionPreviousOrder.staff_no = (string)_oData["MOBILERETENTIONPREVIOUSORDER_STAFF_NO"]; }else{_oMobileRetentionPreviousOrder.staff_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_S_PREMIUM3"])) {_oMobileRetentionPreviousOrder.s_premium3 = (string)_oData["MOBILERETENTIONPREVIOUSORDER_S_PREMIUM3"]; }else{_oMobileRetentionPreviousOrder.s_premium3=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_SP_D_DATE"])) {_oMobileRetentionPreviousOrder.sp_d_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_SP_D_DATE"]; }else{_oMobileRetentionPreviousOrder.sp_d_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_BUNDLE_NAME"])) {_oMobileRetentionPreviousOrder.bundle_name = (string)_oData["MOBILERETENTIONPREVIOUSORDER_BUNDLE_NAME"]; }else{_oMobileRetentionPreviousOrder.bundle_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ACCESSORY_WAIVE"])) {_oMobileRetentionPreviousOrder.accessory_waive = (global::System.Nullable<bool>)_oData["MOBILERETENTIONPREVIOUSORDER_ACCESSORY_WAIVE"]; }else{_oMobileRetentionPreviousOrder.accessory_waive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_SIM_ITEM_CODE"])) {_oMobileRetentionPreviousOrder.sim_item_code = (string)_oData["MOBILERETENTIONPREVIOUSORDER_SIM_ITEM_CODE"]; }else{_oMobileRetentionPreviousOrder.sim_item_code=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_HOLDER"])) {_oMobileRetentionPreviousOrder.monthly_bank_account_holder = (string)_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_HOLDER"]; }else{_oMobileRetentionPreviousOrder.monthly_bank_account_holder=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CARD_HOLDER"])) {_oMobileRetentionPreviousOrder.card_holder = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CARD_HOLDER"]; }else{_oMobileRetentionPreviousOrder.card_holder=global::System.String.Empty;}
                        _oMobileRetentionPreviousOrder.SetDB(x_oDB);
                        _oMobileRetentionPreviousOrder.GetFound();
                        _oRow.Add(_oMobileRetentionPreviousOrder);
                    }
                    _oData.Close();
                    _oData.Dispose();
                }
                catch { }
                finally
                {
                    _oConn.Close();
                    _oCmd.Dispose();
                    _oConn.Dispose();
                }
                return _oRow;
            }
        }
        
        
        public static MobileRetentionPreviousOrderEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileRetentionPreviousOrderEntity> _oMobileRetentionPreviousOrderList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileRetentionPreviousOrderList==null){ return null;}
            return _oMobileRetentionPreviousOrderList.Count == 0 ? null : _oMobileRetentionPreviousOrderList.ToArray();
        }
        
        
        public static MobileRetentionPreviousOrderEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileRetentionPreviousOrderEntity> _oMobileRetentionPreviousOrderList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileRetentionPreviousOrderList==null){ return null;}
            return _oMobileRetentionPreviousOrderList.Count == 0 ? null : _oMobileRetentionPreviousOrderList.ToArray();
        }
        
        public static List<MobileRetentionPreviousOrderEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<MobileRetentionPreviousOrderEntity> _oRow = new List<MobileRetentionPreviousOrderEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[MobileRetentionPreviousOrder].[gift_imei] AS MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI,[MobileRetentionPreviousOrder].[s_premium4] AS MOBILERETENTIONPREVIOUSORDER_S_PREMIUM4,[MobileRetentionPreviousOrder].[upgrade_existing_customer_type] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_CUSTOMER_TYPE,[MobileRetentionPreviousOrder].[gift_desc4] AS MOBILERETENTIONPREVIOUSORDER_GIFT_DESC4,[MobileRetentionPreviousOrder].[accessory_desc] AS MOBILERETENTIONPREVIOUSORDER_ACCESSORY_DESC,[MobileRetentionPreviousOrder].[staff_name] AS MOBILERETENTIONPREVIOUSORDER_STAFF_NAME,[MobileRetentionPreviousOrder].[action_required] AS MOBILERETENTIONPREVIOUSORDER_ACTION_REQUIRED,[MobileRetentionPreviousOrder].[registered_address_his_id] AS MOBILERETENTIONPREVIOUSORDER_REGISTERED_ADDRESS_HIS_ID,[MobileRetentionPreviousOrder].[vas_eff_date] AS MOBILERETENTIONPREVIOUSORDER_VAS_EFF_DATE,[MobileRetentionPreviousOrder].[monthly_bank_account_bank_code] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_BANK_CODE,[MobileRetentionPreviousOrder].[sim_item_number] AS MOBILERETENTIONPREVIOUSORDER_SIM_ITEM_NUMBER,[MobileRetentionPreviousOrder].[special_handling_dummy_code] AS MOBILERETENTIONPREVIOUSORDER_SPECIAL_HANDLING_DUMMY_CODE,[MobileRetentionPreviousOrder].[card_no] AS MOBILERETENTIONPREVIOUSORDER_CARD_NO,[MobileRetentionPreviousOrder].[m_card_exp_year] AS MOBILERETENTIONPREVIOUSORDER_M_CARD_EXP_YEAR,[MobileRetentionPreviousOrder].[bill_medium_email] AS MOBILERETENTIONPREVIOUSORDER_BILL_MEDIUM_EMAIL,[MobileRetentionPreviousOrder].[remarks2PY] AS MOBILERETENTIONPREVIOUSORDER_REMARKS2PY,[MobileRetentionPreviousOrder].[trade_field] AS MOBILERETENTIONPREVIOUSORDER_TRADE_FIELD,[MobileRetentionPreviousOrder].[ord_place_tel] AS MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_TEL,[MobileRetentionPreviousOrder].[action_of_rate_plan_effective] AS MOBILERETENTIONPREVIOUSORDER_ACTION_OF_RATE_PLAN_EFFECTIVE,[MobileRetentionPreviousOrder].[cooling_offer] AS MOBILERETENTIONPREVIOUSORDER_COOLING_OFFER,[MobileRetentionPreviousOrder].[rec_no] AS MOBILERETENTIONPREVIOUSORDER_REC_NO,[MobileRetentionPreviousOrder].[upgrade_handset_offer_rebate_schedule] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_HANDSET_OFFER_REBATE_SCHEDULE,[MobileRetentionPreviousOrder].[change_payment_type] AS MOBILERETENTIONPREVIOUSORDER_CHANGE_PAYMENT_TYPE,[MobileRetentionPreviousOrder].[date_of_birth] AS MOBILERETENTIONPREVIOUSORDER_DATE_OF_BIRTH,[MobileRetentionPreviousOrder].[contact_person] AS MOBILERETENTIONPREVIOUSORDER_CONTACT_PERSON,[MobileRetentionPreviousOrder].[extra_d_charge] AS MOBILERETENTIONPREVIOUSORDER_EXTRA_D_CHARGE,[MobileRetentionPreviousOrder].[tl_name] AS MOBILERETENTIONPREVIOUSORDER_TL_NAME,[MobileRetentionPreviousOrder].[fast_start] AS MOBILERETENTIONPREVIOUSORDER_FAST_START,[MobileRetentionPreviousOrder].[issue_type] AS MOBILERETENTIONPREVIOUSORDER_ISSUE_TYPE,[MobileRetentionPreviousOrder].[sp_ref_no] AS MOBILERETENTIONPREVIOUSORDER_SP_REF_NO,[MobileRetentionPreviousOrder].[edate] AS MOBILERETENTIONPREVIOUSORDER_EDATE,[MobileRetentionPreviousOrder].[exist_cust_plan] AS MOBILERETENTIONPREVIOUSORDER_EXIST_CUST_PLAN,[MobileRetentionPreviousOrder].[ord_place_rel] AS MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_REL,[MobileRetentionPreviousOrder].[mrt_no] AS MOBILERETENTIONPREVIOUSORDER_MRT_NO,[MobileRetentionPreviousOrder].[imei_no] AS MOBILERETENTIONPREVIOUSORDER_IMEI_NO,[MobileRetentionPreviousOrder].[existing_smart_phone_model] AS MOBILERETENTIONPREVIOUSORDER_EXISTING_SMART_PHONE_MODEL,[MobileRetentionPreviousOrder].[bank_code] AS MOBILERETENTIONPREVIOUSORDER_BANK_CODE,[MobileRetentionPreviousOrder].[pos_ref_no] AS MOBILERETENTIONPREVIOUSORDER_POS_REF_NO,[MobileRetentionPreviousOrder].[bill_cut_date] AS MOBILERETENTIONPREVIOUSORDER_BILL_CUT_DATE,[MobileRetentionPreviousOrder].[gift_imei3] AS MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI3,[MobileRetentionPreviousOrder].[exist_plan] AS MOBILERETENTIONPREVIOUSORDER_EXIST_PLAN,[MobileRetentionPreviousOrder].[waive] AS MOBILERETENTIONPREVIOUSORDER_WAIVE,[MobileRetentionPreviousOrder].[program] AS MOBILERETENTIONPREVIOUSORDER_PROGRAM,[MobileRetentionPreviousOrder].[first_month_fee] AS MOBILERETENTIONPREVIOUSORDER_FIRST_MONTH_FEE,[MobileRetentionPreviousOrder].[r_offer] AS MOBILERETENTIONPREVIOUSORDER_R_OFFER,[MobileRetentionPreviousOrder].[cid] AS MOBILERETENTIONPREVIOUSORDER_CID,[MobileRetentionPreviousOrder].[did] AS MOBILERETENTIONPREVIOUSORDER_DID,[MobileRetentionPreviousOrder].[ftg_tenure] AS MOBILERETENTIONPREVIOUSORDER_FTG_TENURE,[MobileRetentionPreviousOrder].[con_per] AS MOBILERETENTIONPREVIOUSORDER_CON_PER,[MobileRetentionPreviousOrder].[gift_code4] AS MOBILERETENTIONPREVIOUSORDER_GIFT_CODE4,[MobileRetentionPreviousOrder].[easywatch_type] AS MOBILERETENTIONPREVIOUSORDER_EASYWATCH_TYPE,[MobileRetentionPreviousOrder].[sms_mrt] AS MOBILERETENTIONPREVIOUSORDER_SMS_MRT,[MobileRetentionPreviousOrder].[tpy_his_id] AS MOBILERETENTIONPREVIOUSORDER_TPY_HIS_ID,[MobileRetentionPreviousOrder].[monthly_payment_method] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_PAYMENT_METHOD,[MobileRetentionPreviousOrder].[remarks2EDF] AS MOBILERETENTIONPREVIOUSORDER_REMARKS2EDF,[MobileRetentionPreviousOrder].[gift_desc3] AS MOBILERETENTIONPREVIOUSORDER_GIFT_DESC3,[MobileRetentionPreviousOrder].[gift_imei4] AS MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI4,[MobileRetentionPreviousOrder].[monthly_bank_account_hkid2] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_HKID2,[MobileRetentionPreviousOrder].[d_date] AS MOBILERETENTIONPREVIOUSORDER_D_DATE,[MobileRetentionPreviousOrder].[gift_desc] AS MOBILERETENTIONPREVIOUSORDER_GIFT_DESC,[MobileRetentionPreviousOrder].[pool] AS MOBILERETENTIONPREVIOUSORDER_POOL,[MobileRetentionPreviousOrder].[cn_mrt_no] AS MOBILERETENTIONPREVIOUSORDER_CN_MRT_NO,[MobileRetentionPreviousOrder].[accessory_imei] AS MOBILERETENTIONPREVIOUSORDER_ACCESSORY_IMEI,[MobileRetentionPreviousOrder].[third_party_credit_card] AS MOBILERETENTIONPREVIOUSORDER_THIRD_PARTY_CREDIT_CARD,[MobileRetentionPreviousOrder].[special_approval] AS MOBILERETENTIONPREVIOUSORDER_SPECIAL_APPROVAL,[MobileRetentionPreviousOrder].[upgrade_existing_contract_edate] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_CONTRACT_EDATE,[MobileRetentionPreviousOrder].[accessory_code] AS MOBILERETENTIONPREVIOUSORDER_ACCESSORY_CODE,[MobileRetentionPreviousOrder].[s_premium] AS MOBILERETENTIONPREVIOUSORDER_S_PREMIUM,[MobileRetentionPreviousOrder].[ref_staff_no] AS MOBILERETENTIONPREVIOUSORDER_REF_STAFF_NO,[MobileRetentionPreviousOrder].[accessory_price] AS MOBILERETENTIONPREVIOUSORDER_ACCESSORY_PRICE,[MobileRetentionPreviousOrder].[m_card_exp_month] AS MOBILERETENTIONPREVIOUSORDER_M_CARD_EXP_MONTH,[MobileRetentionPreviousOrder].[installment_period] AS MOBILERETENTIONPREVIOUSORDER_INSTALLMENT_PERIOD,[MobileRetentionPreviousOrder].[m_card_type] AS MOBILERETENTIONPREVIOUSORDER_M_CARD_TYPE,[MobileRetentionPreviousOrder].[easywatch_ord_id] AS MOBILERETENTIONPREVIOUSORDER_EASYWATCH_ORD_ID,[MobileRetentionPreviousOrder].[normal_rebate] AS MOBILERETENTIONPREVIOUSORDER_NORMAL_REBATE,[MobileRetentionPreviousOrder].[m_rebate_amount] AS MOBILERETENTIONPREVIOUSORDER_M_REBATE_AMOUNT,[MobileRetentionPreviousOrder].[m_card_holder2] AS MOBILERETENTIONPREVIOUSORDER_M_CARD_HOLDER2,[MobileRetentionPreviousOrder].[monthly_bank_account_holder] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_HOLDER,[MobileRetentionPreviousOrder].[active] AS MOBILERETENTIONPREVIOUSORDER_ACTIVE,[MobileRetentionPreviousOrder].[s_premium1] AS MOBILERETENTIONPREVIOUSORDER_S_PREMIUM1,[MobileRetentionPreviousOrder].[card_exp_month] AS MOBILERETENTIONPREVIOUSORDER_CARD_EXP_MONTH,[MobileRetentionPreviousOrder].[ob_program_id] AS MOBILERETENTIONPREVIOUSORDER_OB_PROGRAM_ID,[MobileRetentionPreviousOrder].[sku] AS MOBILERETENTIONPREVIOUSORDER_SKU,[MobileRetentionPreviousOrder].[salesmancode] AS MOBILERETENTIONPREVIOUSORDER_SALESMANCODE,[MobileRetentionPreviousOrder].[go_wireless_package_code] AS MOBILERETENTIONPREVIOUSORDER_GO_WIRELESS_PACKAGE_CODE,[MobileRetentionPreviousOrder].[lob] AS MOBILERETENTIONPREVIOUSORDER_LOB,[MobileRetentionPreviousOrder].[ref_salesmancode] AS MOBILERETENTIONPREVIOUSORDER_REF_SALESMANCODE,[MobileRetentionPreviousOrder].[third_party_hkid] AS MOBILERETENTIONPREVIOUSORDER_THIRD_PARTY_HKID,[MobileRetentionPreviousOrder].[upgrade_existing_pccw_customer] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_PCCW_CUSTOMER,[MobileRetentionPreviousOrder].[d_address] AS MOBILERETENTIONPREVIOUSORDER_D_ADDRESS,[MobileRetentionPreviousOrder].[upgrade_registered_mobile_no] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_REGISTERED_MOBILE_NO,[MobileRetentionPreviousOrder].[gift_code3] AS MOBILERETENTIONPREVIOUSORDER_GIFT_CODE3,[MobileRetentionPreviousOrder].[normal_rebate_type] AS MOBILERETENTIONPREVIOUSORDER_NORMAL_REBATE_TYPE,[MobileRetentionPreviousOrder].[gift_desc2] AS MOBILERETENTIONPREVIOUSORDER_GIFT_DESC2,[MobileRetentionPreviousOrder].[monthly_bank_account_branch_code] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_BRANCH_CODE,[MobileRetentionPreviousOrder].[remarks] AS MOBILERETENTIONPREVIOUSORDER_REMARKS,[MobileRetentionPreviousOrder].[accept] AS MOBILERETENTIONPREVIOUSORDER_ACCEPT,[MobileRetentionPreviousOrder].[delivery_exchange] AS MOBILERETENTIONPREVIOUSORDER_DELIVERY_EXCHANGE,[MobileRetentionPreviousOrder].[gift_code2] AS MOBILERETENTIONPREVIOUSORDER_GIFT_CODE2,[MobileRetentionPreviousOrder].[prepayment_waive] AS MOBILERETENTIONPREVIOUSORDER_PREPAYMENT_WAIVE,[MobileRetentionPreviousOrder].[existing_smart_phone_imei] AS MOBILERETENTIONPREVIOUSORDER_EXISTING_SMART_PHONE_IMEI,[MobileRetentionPreviousOrder].[mnp_his_id] AS MOBILERETENTIONPREVIOUSORDER_MNP_HIS_ID,[MobileRetentionPreviousOrder].[cust_name] AS MOBILERETENTIONPREVIOUSORDER_CUST_NAME,[MobileRetentionPreviousOrder].[upgrade_sponsorships_amount] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_SPONSORSHIPS_AMOUNT,[MobileRetentionPreviousOrder].[bill_medium_waive] AS MOBILERETENTIONPREVIOUSORDER_BILL_MEDIUM_WAIVE,[MobileRetentionPreviousOrder].[delivery_exchange_location] AS MOBILERETENTIONPREVIOUSORDER_DELIVERY_EXCHANGE_LOCATION,[MobileRetentionPreviousOrder].[hs_offer_type_id] AS MOBILERETENTIONPREVIOUSORDER_HS_OFFER_TYPE_ID,[MobileRetentionPreviousOrder].[org_fee] AS MOBILERETENTIONPREVIOUSORDER_ORG_FEE,[MobileRetentionPreviousOrder].[rebate] AS MOBILERETENTIONPREVIOUSORDER_REBATE,[MobileRetentionPreviousOrder].[upgrade_type] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_TYPE,[MobileRetentionPreviousOrder].[go_wireless] AS MOBILERETENTIONPREVIOUSORDER_GO_WIRELESS,[MobileRetentionPreviousOrder].[extra_rebate] AS MOBILERETENTIONPREVIOUSORDER_EXTRA_REBATE,[MobileRetentionPreviousOrder].[plan_eff] AS MOBILERETENTIONPREVIOUSORDER_PLAN_EFF,[MobileRetentionPreviousOrder].[extra_rebate_amount] AS MOBILERETENTIONPREVIOUSORDER_EXTRA_REBATE_AMOUNT,[MobileRetentionPreviousOrder].[card_exp_year] AS MOBILERETENTIONPREVIOUSORDER_CARD_EXP_YEAR,[MobileRetentionPreviousOrder].[upgrade_existing_contract_sdate] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_CONTRACT_SDATE,[MobileRetentionPreviousOrder].[ord_place_hkid] AS MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_HKID,[MobileRetentionPreviousOrder].[register_address] AS MOBILERETENTIONPREVIOUSORDER_REGISTER_ADDRESS,[MobileRetentionPreviousOrder].[gender] AS MOBILERETENTIONPREVIOUSORDER_GENDER,[MobileRetentionPreviousOrder].[lob_ac] AS MOBILERETENTIONPREVIOUSORDER_LOB_AC,[MobileRetentionPreviousOrder].[sim_mrt_no] AS MOBILERETENTIONPREVIOUSORDER_SIM_MRT_NO,[MobileRetentionPreviousOrder].[redemption_notice_option] AS MOBILERETENTIONPREVIOUSORDER_REDEMPTION_NOTICE_OPTION,[MobileRetentionPreviousOrder].[delivery_collection_type] AS MOBILERETENTIONPREVIOUSORDER_DELIVERY_COLLECTION_TYPE,[MobileRetentionPreviousOrder].[action_date] AS MOBILERETENTIONPREVIOUSORDER_ACTION_DATE,[MobileRetentionPreviousOrder].[third_party_id_type] AS MOBILERETENTIONPREVIOUSORDER_THIRD_PARTY_ID_TYPE,[MobileRetentionPreviousOrder].[org_ftg] AS MOBILERETENTIONPREVIOUSORDER_ORG_FTG,[MobileRetentionPreviousOrder].[upgrade_service_tenure] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_SERVICE_TENURE,[MobileRetentionPreviousOrder].[monthly_payment_type] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_PAYMENT_TYPE,[MobileRetentionPreviousOrder].[contact_no] AS MOBILERETENTIONPREVIOUSORDER_CONTACT_NO,[MobileRetentionPreviousOrder].[org_mrt] AS MOBILERETENTIONPREVIOUSORDER_ORG_MRT,[MobileRetentionPreviousOrder].[sim_item_name] AS MOBILERETENTIONPREVIOUSORDER_SIM_ITEM_NAME,[MobileRetentionPreviousOrder].[pay_method] AS MOBILERETENTIONPREVIOUSORDER_PAY_METHOD,[MobileRetentionPreviousOrder].[hs_model] AS MOBILERETENTIONPREVIOUSORDER_HS_MODEL,[MobileRetentionPreviousOrder].[gift_code] AS MOBILERETENTIONPREVIOUSORDER_GIFT_CODE,[MobileRetentionPreviousOrder].[monthly_bank_account_hkid] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_HKID,[MobileRetentionPreviousOrder].[extra_offer] AS MOBILERETENTIONPREVIOUSORDER_EXTRA_OFFER,[MobileRetentionPreviousOrder].[monthly_bank_account_no] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_NO,[MobileRetentionPreviousOrder].[first_month_license_fee] AS MOBILERETENTIONPREVIOUSORDER_FIRST_MONTH_LICENSE_FEE,[MobileRetentionPreviousOrder].[retrieve_cnt] AS MOBILERETENTIONPREVIOUSORDER_RETRIEVE_CNT,[MobileRetentionPreviousOrder].[ddate] AS MOBILERETENTIONPREVIOUSORDER_DDATE,[MobileRetentionPreviousOrder].[s_premium2] AS MOBILERETENTIONPREVIOUSORDER_S_PREMIUM2,[MobileRetentionPreviousOrder].[monthly_bank_account_id_type] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_ID_TYPE,[MobileRetentionPreviousOrder].[card_type] AS MOBILERETENTIONPREVIOUSORDER_CARD_TYPE,[MobileRetentionPreviousOrder].[next_bill] AS MOBILERETENTIONPREVIOUSORDER_NEXT_BILL,[MobileRetentionPreviousOrder].[pcd_paid_go_wireless] AS MOBILERETENTIONPREVIOUSORDER_PCD_PAID_GO_WIRELESS,[MobileRetentionPreviousOrder].[upgrade_rebate_calculation] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_REBATE_CALCULATION,[MobileRetentionPreviousOrder].[ext_place_tel] AS MOBILERETENTIONPREVIOUSORDER_EXT_PLACE_TEL,[MobileRetentionPreviousOrder].[m_3rd_hkid] AS MOBILERETENTIONPREVIOUSORDER_M_3RD_HKID,[MobileRetentionPreviousOrder].[retention_type] AS MOBILERETENTIONPREVIOUSORDER_RETENTION_TYPE,[MobileRetentionPreviousOrder].[bill_address_his_id] AS MOBILERETENTIONPREVIOUSORDER_BILL_ADDRESS_HIS_ID,[MobileRetentionPreviousOrder].[aig_gift] AS MOBILERETENTIONPREVIOUSORDER_AIG_GIFT,[MobileRetentionPreviousOrder].[cust_staff_no] AS MOBILERETENTIONPREVIOUSORDER_CUST_STAFF_NO,[MobileRetentionPreviousOrder].[order_id] AS MOBILERETENTIONPREVIOUSORDER_ORDER_ID,[MobileRetentionPreviousOrder].[family_name] AS MOBILERETENTIONPREVIOUSORDER_FAMILY_NAME,[MobileRetentionPreviousOrder].[cdate] AS MOBILERETENTIONPREVIOUSORDER_CDATE,[MobileRetentionPreviousOrder].[status_by_cs_admin] AS MOBILERETENTIONPREVIOUSORDER_STATUS_BY_CS_ADMIN,[MobileRetentionPreviousOrder].[given_name] AS MOBILERETENTIONPREVIOUSORDER_GIVEN_NAME,[MobileRetentionPreviousOrder].[vip_case] AS MOBILERETENTIONPREVIOUSORDER_VIP_CASE,[MobileRetentionPreviousOrder].[s_premium3] AS MOBILERETENTIONPREVIOUSORDER_S_PREMIUM3,[MobileRetentionPreviousOrder].[log_date] AS MOBILERETENTIONPREVIOUSORDER_LOG_DATE,[MobileRetentionPreviousOrder].[extn] AS MOBILERETENTIONPREVIOUSORDER_EXTN,[MobileRetentionPreviousOrder].[d_time] AS MOBILERETENTIONPREVIOUSORDER_D_TIME,[MobileRetentionPreviousOrder].[bank_name] AS MOBILERETENTIONPREVIOUSORDER_BANK_NAME,[MobileRetentionPreviousOrder].[delivery_exchange_option] AS MOBILERETENTIONPREVIOUSORDER_DELIVERY_EXCHANGE_OPTION,[MobileRetentionPreviousOrder].[upgrade_service_account_no] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_SERVICE_ACCOUNT_NO,[MobileRetentionPreviousOrder].[old_ord_id] AS MOBILERETENTIONPREVIOUSORDER_OLD_ORD_ID,[MobileRetentionPreviousOrder].[m_card_no] AS MOBILERETENTIONPREVIOUSORDER_M_CARD_NO,[MobileRetentionPreviousOrder].[existing_contract_end_date] AS MOBILERETENTIONPREVIOUSORDER_EXISTING_CONTRACT_END_DATE,[MobileRetentionPreviousOrder].[con_eff_date] AS MOBILERETENTIONPREVIOUSORDER_CON_EFF_DATE,[MobileRetentionPreviousOrder].[m_3rd_hkid2] AS MOBILERETENTIONPREVIOUSORDER_M_3RD_HKID2,[MobileRetentionPreviousOrder].[amount] AS MOBILERETENTIONPREVIOUSORDER_AMOUNT,[MobileRetentionPreviousOrder].[m_3rd_id_type] AS MOBILERETENTIONPREVIOUSORDER_M_3RD_ID_TYPE,[MobileRetentionPreviousOrder].[id_type] AS MOBILERETENTIONPREVIOUSORDER_ID_TYPE,[MobileRetentionPreviousOrder].[rate_plan] AS MOBILERETENTIONPREVIOUSORDER_RATE_PLAN,[MobileRetentionPreviousOrder].[channel] AS MOBILERETENTIONPREVIOUSORDER_CHANNEL,[MobileRetentionPreviousOrder].[action_eff_date] AS MOBILERETENTIONPREVIOUSORDER_ACTION_EFF_DATE,[MobileRetentionPreviousOrder].[cooling_date] AS MOBILERETENTIONPREVIOUSORDER_COOLING_DATE,[MobileRetentionPreviousOrder].[free_mon] AS MOBILERETENTIONPREVIOUSORDER_FREE_MON,[MobileRetentionPreviousOrder].[plan_eff_date] AS MOBILERETENTIONPREVIOUSORDER_PLAN_EFF_DATE,[MobileRetentionPreviousOrder].[teamcode] AS MOBILERETENTIONPREVIOUSORDER_TEAMCODE,[MobileRetentionPreviousOrder].[bill_medium] AS MOBILERETENTIONPREVIOUSORDER_BILL_MEDIUM,[MobileRetentionPreviousOrder].[edf_no] AS MOBILERETENTIONPREVIOUSORDER_EDF_NO,[MobileRetentionPreviousOrder].[ord_place_by] AS MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_BY,[MobileRetentionPreviousOrder].[cancel_renew] AS MOBILERETENTIONPREVIOUSORDER_CANCEL_RENEW,[MobileRetentionPreviousOrder].[preferred_languages] AS MOBILERETENTIONPREVIOUSORDER_PREFERRED_LANGUAGES,[MobileRetentionPreviousOrder].[hkid] AS MOBILERETENTIONPREVIOUSORDER_HKID,[MobileRetentionPreviousOrder].[card_holder] AS MOBILERETENTIONPREVIOUSORDER_CARD_HOLDER,[MobileRetentionPreviousOrder].[ac_no] AS MOBILERETENTIONPREVIOUSORDER_AC_NO,[MobileRetentionPreviousOrder].[bill_cut_num] AS MOBILERETENTIONPREVIOUSORDER_BILL_CUT_NUM,[MobileRetentionPreviousOrder].[premium] AS MOBILERETENTIONPREVIOUSORDER_PREMIUM,[MobileRetentionPreviousOrder].[del_remark] AS MOBILERETENTIONPREVIOUSORDER_DEL_REMARK,[MobileRetentionPreviousOrder].[gift_imei2] AS MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI2,[MobileRetentionPreviousOrder].[reasons] AS MOBILERETENTIONPREVIOUSORDER_REASONS,[MobileRetentionPreviousOrder].[language] AS MOBILERETENTIONPREVIOUSORDER_LANGUAGE,[MobileRetentionPreviousOrder].[rebate_amount] AS MOBILERETENTIONPREVIOUSORDER_REBATE_AMOUNT,[MobileRetentionPreviousOrder].[ord_place_id_type] AS MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_ID_TYPE,[MobileRetentionPreviousOrder].[m_3rd_contact_no] AS MOBILERETENTIONPREVIOUSORDER_M_3RD_CONTACT_NO,[MobileRetentionPreviousOrder].[staff_no] AS MOBILERETENTIONPREVIOUSORDER_STAFF_NO,[MobileRetentionPreviousOrder].[sp_d_date] AS MOBILERETENTIONPREVIOUSORDER_SP_D_DATE,[MobileRetentionPreviousOrder].[bundle_name] AS MOBILERETENTIONPREVIOUSORDER_BUNDLE_NAME,[MobileRetentionPreviousOrder].[accessory_waive] AS MOBILERETENTIONPREVIOUSORDER_ACCESSORY_WAIVE,[MobileRetentionPreviousOrder].[sim_item_code] AS MOBILERETENTIONPREVIOUSORDER_SIM_ITEM_CODE,[MobileRetentionPreviousOrder].[cust_type] AS MOBILERETENTIONPREVIOUSORDER_CUST_TYPE,[MobileRetentionPreviousOrder].[card_ref_no] AS MOBILERETENTIONPREVIOUSORDER_CARD_REF_NO";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[MobileRetentionPreviousOrder]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionPreviousOrder]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = MobileRetentionPreviousOrderRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                MobileRetentionPreviousOrderEntity _oMobileRetentionPreviousOrder = MobileRetentionPreviousOrderRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI"])) {_oMobileRetentionPreviousOrder.gift_imei = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI"]; } else {_oMobileRetentionPreviousOrder.gift_imei=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_S_PREMIUM4"])) {_oMobileRetentionPreviousOrder.s_premium4 = (string)_oData["MOBILERETENTIONPREVIOUSORDER_S_PREMIUM4"]; } else {_oMobileRetentionPreviousOrder.s_premium4=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_DESC4"])) {_oMobileRetentionPreviousOrder.gift_desc4 = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_DESC4"]; } else {_oMobileRetentionPreviousOrder.gift_desc4=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ACCESSORY_DESC"])) {_oMobileRetentionPreviousOrder.accessory_desc = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ACCESSORY_DESC"]; } else {_oMobileRetentionPreviousOrder.accessory_desc=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ACTION_REQUIRED"])) {_oMobileRetentionPreviousOrder.action_required = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ACTION_REQUIRED"]; } else {_oMobileRetentionPreviousOrder.action_required=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REGISTERED_ADDRESS_HIS_ID"])) {_oMobileRetentionPreviousOrder.registered_address_his_id = (global::System.Nullable<long>)_oData["MOBILERETENTIONPREVIOUSORDER_REGISTERED_ADDRESS_HIS_ID"]; } else {_oMobileRetentionPreviousOrder.registered_address_his_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_VAS_EFF_DATE"])) {_oMobileRetentionPreviousOrder.vas_eff_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_VAS_EFF_DATE"]; } else {_oMobileRetentionPreviousOrder.vas_eff_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_BANK_CODE"])) {_oMobileRetentionPreviousOrder.monthly_bank_account_bank_code = (string)_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_BANK_CODE"]; } else {_oMobileRetentionPreviousOrder.monthly_bank_account_bank_code=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_SPECIAL_HANDLING_DUMMY_CODE"])) {_oMobileRetentionPreviousOrder.special_handling_dummy_code = (string)_oData["MOBILERETENTIONPREVIOUSORDER_SPECIAL_HANDLING_DUMMY_CODE"]; } else {_oMobileRetentionPreviousOrder.special_handling_dummy_code=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_M_CARD_EXP_YEAR"])) {_oMobileRetentionPreviousOrder.m_card_exp_year = (string)_oData["MOBILERETENTIONPREVIOUSORDER_M_CARD_EXP_YEAR"]; } else {_oMobileRetentionPreviousOrder.m_card_exp_year=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REMARKS2PY"])) {_oMobileRetentionPreviousOrder.remarks2PY = (string)_oData["MOBILERETENTIONPREVIOUSORDER_REMARKS2PY"]; } else {_oMobileRetentionPreviousOrder.remarks2PY=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_TRADE_FIELD"])) {_oMobileRetentionPreviousOrder.trade_field = (string)_oData["MOBILERETENTIONPREVIOUSORDER_TRADE_FIELD"]; } else {_oMobileRetentionPreviousOrder.trade_field=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_TEL"])) {_oMobileRetentionPreviousOrder.ord_place_tel = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_TEL"]; } else {_oMobileRetentionPreviousOrder.ord_place_tel=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_ID_TYPE"])) {_oMobileRetentionPreviousOrder.ord_place_id_type = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_ID_TYPE"]; } else {_oMobileRetentionPreviousOrder.ord_place_id_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_COOLING_OFFER"])) {_oMobileRetentionPreviousOrder.cooling_offer = (string)_oData["MOBILERETENTIONPREVIOUSORDER_COOLING_OFFER"]; } else {_oMobileRetentionPreviousOrder.cooling_offer=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REC_NO"])) {_oMobileRetentionPreviousOrder.rec_no = (global::System.Nullable<int>)_oData["MOBILERETENTIONPREVIOUSORDER_REC_NO"]; } else {_oMobileRetentionPreviousOrder.rec_no=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_HANDSET_OFFER_REBATE_SCHEDULE"])) {_oMobileRetentionPreviousOrder.upgrade_handset_offer_rebate_schedule = (string)_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_HANDSET_OFFER_REBATE_SCHEDULE"]; } else {_oMobileRetentionPreviousOrder.upgrade_handset_offer_rebate_schedule=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CHANGE_PAYMENT_TYPE"])) {_oMobileRetentionPreviousOrder.change_payment_type = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CHANGE_PAYMENT_TYPE"]; } else {_oMobileRetentionPreviousOrder.change_payment_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_DATE_OF_BIRTH"])) {_oMobileRetentionPreviousOrder.date_of_birth = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_DATE_OF_BIRTH"]; } else {_oMobileRetentionPreviousOrder.date_of_birth=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CONTACT_PERSON"])) {_oMobileRetentionPreviousOrder.contact_person = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CONTACT_PERSON"]; } else {_oMobileRetentionPreviousOrder.contact_person=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EXTRA_D_CHARGE"])) {_oMobileRetentionPreviousOrder.extra_d_charge = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EXTRA_D_CHARGE"]; } else {_oMobileRetentionPreviousOrder.extra_d_charge=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_TL_NAME"])) {_oMobileRetentionPreviousOrder.tl_name = (string)_oData["MOBILERETENTIONPREVIOUSORDER_TL_NAME"]; } else {_oMobileRetentionPreviousOrder.tl_name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_FAST_START"])) {_oMobileRetentionPreviousOrder.fast_start = (global::System.Nullable<bool>)_oData["MOBILERETENTIONPREVIOUSORDER_FAST_START"]; } else {_oMobileRetentionPreviousOrder.fast_start=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_SP_REF_NO"])) {_oMobileRetentionPreviousOrder.sp_ref_no = (string)_oData["MOBILERETENTIONPREVIOUSORDER_SP_REF_NO"]; } else {_oMobileRetentionPreviousOrder.sp_ref_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EDATE"])) {_oMobileRetentionPreviousOrder.edate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_EDATE"]; } else {_oMobileRetentionPreviousOrder.edate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EXIST_CUST_PLAN"])) {_oMobileRetentionPreviousOrder.exist_cust_plan = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EXIST_CUST_PLAN"]; } else {_oMobileRetentionPreviousOrder.exist_cust_plan=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_REL"])) {_oMobileRetentionPreviousOrder.ord_place_rel = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_REL"]; } else {_oMobileRetentionPreviousOrder.ord_place_rel=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_MRT_NO"])) {_oMobileRetentionPreviousOrder.mrt_no = (global::System.Nullable<int>)_oData["MOBILERETENTIONPREVIOUSORDER_MRT_NO"]; } else {_oMobileRetentionPreviousOrder.mrt_no=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_IMEI_NO"])) {_oMobileRetentionPreviousOrder.imei_no = (string)_oData["MOBILERETENTIONPREVIOUSORDER_IMEI_NO"]; } else {_oMobileRetentionPreviousOrder.imei_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EXISTING_SMART_PHONE_MODEL"])) {_oMobileRetentionPreviousOrder.existing_smart_phone_model = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EXISTING_SMART_PHONE_MODEL"]; } else {_oMobileRetentionPreviousOrder.existing_smart_phone_model=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_CODE3"])) {_oMobileRetentionPreviousOrder.gift_code3 = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_CODE3"]; } else {_oMobileRetentionPreviousOrder.gift_code3=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_BANK_CODE"])) {_oMobileRetentionPreviousOrder.bank_code = (string)_oData["MOBILERETENTIONPREVIOUSORDER_BANK_CODE"]; } else {_oMobileRetentionPreviousOrder.bank_code=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_POS_REF_NO"])) {_oMobileRetentionPreviousOrder.pos_ref_no = (string)_oData["MOBILERETENTIONPREVIOUSORDER_POS_REF_NO"]; } else {_oMobileRetentionPreviousOrder.pos_ref_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_BILL_CUT_DATE"])) {_oMobileRetentionPreviousOrder.bill_cut_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_BILL_CUT_DATE"]; } else {_oMobileRetentionPreviousOrder.bill_cut_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI3"])) {_oMobileRetentionPreviousOrder.gift_imei3 = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI3"]; } else {_oMobileRetentionPreviousOrder.gift_imei3=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EXIST_PLAN"])) {_oMobileRetentionPreviousOrder.exist_plan = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EXIST_PLAN"]; } else {_oMobileRetentionPreviousOrder.exist_plan=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_WAIVE"])) {_oMobileRetentionPreviousOrder.waive = (global::System.Nullable<bool>)_oData["MOBILERETENTIONPREVIOUSORDER_WAIVE"]; } else {_oMobileRetentionPreviousOrder.waive=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_PROGRAM"])) {_oMobileRetentionPreviousOrder.program = (string)_oData["MOBILERETENTIONPREVIOUSORDER_PROGRAM"]; } else {_oMobileRetentionPreviousOrder.program=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_FIRST_MONTH_FEE"])) {_oMobileRetentionPreviousOrder.first_month_fee = (string)_oData["MOBILERETENTIONPREVIOUSORDER_FIRST_MONTH_FEE"]; } else {_oMobileRetentionPreviousOrder.first_month_fee=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_R_OFFER"])) {_oMobileRetentionPreviousOrder.r_offer = (string)_oData["MOBILERETENTIONPREVIOUSORDER_R_OFFER"]; } else {_oMobileRetentionPreviousOrder.r_offer=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CID"])) {_oMobileRetentionPreviousOrder.cid = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CID"]; } else {_oMobileRetentionPreviousOrder.cid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_DID"])) {_oMobileRetentionPreviousOrder.did = (string)_oData["MOBILERETENTIONPREVIOUSORDER_DID"]; } else {_oMobileRetentionPreviousOrder.did=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_FTG_TENURE"])) {_oMobileRetentionPreviousOrder.ftg_tenure = (string)_oData["MOBILERETENTIONPREVIOUSORDER_FTG_TENURE"]; } else {_oMobileRetentionPreviousOrder.ftg_tenure=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CON_PER"])) {_oMobileRetentionPreviousOrder.con_per = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CON_PER"]; } else {_oMobileRetentionPreviousOrder.con_per=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_CODE4"])) {_oMobileRetentionPreviousOrder.gift_code4 = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_CODE4"]; } else {_oMobileRetentionPreviousOrder.gift_code4=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EASYWATCH_TYPE"])) {_oMobileRetentionPreviousOrder.easywatch_type = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EASYWATCH_TYPE"]; } else {_oMobileRetentionPreviousOrder.easywatch_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_SMS_MRT"])) {_oMobileRetentionPreviousOrder.sms_mrt = (string)_oData["MOBILERETENTIONPREVIOUSORDER_SMS_MRT"]; } else {_oMobileRetentionPreviousOrder.sms_mrt=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_TPY_HIS_ID"])) {_oMobileRetentionPreviousOrder.tpy_his_id = (global::System.Nullable<long>)_oData["MOBILERETENTIONPREVIOUSORDER_TPY_HIS_ID"]; } else {_oMobileRetentionPreviousOrder.tpy_his_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_PAYMENT_METHOD"])) {_oMobileRetentionPreviousOrder.monthly_payment_method = (string)_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_PAYMENT_METHOD"]; } else {_oMobileRetentionPreviousOrder.monthly_payment_method=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REMARKS2EDF"])) {_oMobileRetentionPreviousOrder.remarks2EDF = (string)_oData["MOBILERETENTIONPREVIOUSORDER_REMARKS2EDF"]; } else {_oMobileRetentionPreviousOrder.remarks2EDF=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_DESC3"])) {_oMobileRetentionPreviousOrder.gift_desc3 = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_DESC3"]; } else {_oMobileRetentionPreviousOrder.gift_desc3=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI4"])) {_oMobileRetentionPreviousOrder.gift_imei4 = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI4"]; } else {_oMobileRetentionPreviousOrder.gift_imei4=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_OLD_ORD_ID"])) {_oMobileRetentionPreviousOrder.old_ord_id = (global::System.Nullable<int>)_oData["MOBILERETENTIONPREVIOUSORDER_OLD_ORD_ID"]; } else {_oMobileRetentionPreviousOrder.old_ord_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_HKID2"])) {_oMobileRetentionPreviousOrder.monthly_bank_account_hkid2 = (string)_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_HKID2"]; } else {_oMobileRetentionPreviousOrder.monthly_bank_account_hkid2=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_D_DATE"])) {_oMobileRetentionPreviousOrder.d_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_D_DATE"]; } else {_oMobileRetentionPreviousOrder.d_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_DESC"])) {_oMobileRetentionPreviousOrder.gift_desc = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_DESC"]; } else {_oMobileRetentionPreviousOrder.gift_desc=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_SALESMANCODE"])) {_oMobileRetentionPreviousOrder.salesmancode = (string)_oData["MOBILERETENTIONPREVIOUSORDER_SALESMANCODE"]; } else {_oMobileRetentionPreviousOrder.salesmancode=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_POOL"])) {_oMobileRetentionPreviousOrder.pool = (string)_oData["MOBILERETENTIONPREVIOUSORDER_POOL"]; } else {_oMobileRetentionPreviousOrder.pool=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CN_MRT_NO"])) {_oMobileRetentionPreviousOrder.cn_mrt_no = (global::System.Nullable<long>)_oData["MOBILERETENTIONPREVIOUSORDER_CN_MRT_NO"]; } else {_oMobileRetentionPreviousOrder.cn_mrt_no=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ACCESSORY_IMEI"])) {_oMobileRetentionPreviousOrder.accessory_imei = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ACCESSORY_IMEI"]; } else {_oMobileRetentionPreviousOrder.accessory_imei=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_THIRD_PARTY_CREDIT_CARD"])) {_oMobileRetentionPreviousOrder.third_party_credit_card = (string)_oData["MOBILERETENTIONPREVIOUSORDER_THIRD_PARTY_CREDIT_CARD"]; } else {_oMobileRetentionPreviousOrder.third_party_credit_card=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CARD_REF_NO"])) {_oMobileRetentionPreviousOrder.card_ref_no = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CARD_REF_NO"]; } else {_oMobileRetentionPreviousOrder.card_ref_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_COOLING_DATE"])) {_oMobileRetentionPreviousOrder.cooling_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_COOLING_DATE"]; } else {_oMobileRetentionPreviousOrder.cooling_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_SPECIAL_APPROVAL"])) {_oMobileRetentionPreviousOrder.special_approval = (string)_oData["MOBILERETENTIONPREVIOUSORDER_SPECIAL_APPROVAL"]; } else {_oMobileRetentionPreviousOrder.special_approval=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_CONTRACT_EDATE"])) {_oMobileRetentionPreviousOrder.upgrade_existing_contract_edate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_CONTRACT_EDATE"]; } else {_oMobileRetentionPreviousOrder.upgrade_existing_contract_edate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ACCESSORY_CODE"])) {_oMobileRetentionPreviousOrder.accessory_code = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ACCESSORY_CODE"]; } else {_oMobileRetentionPreviousOrder.accessory_code=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_BILL_MEDIUM"])) {_oMobileRetentionPreviousOrder.bill_medium = (string)_oData["MOBILERETENTIONPREVIOUSORDER_BILL_MEDIUM"]; } else {_oMobileRetentionPreviousOrder.bill_medium=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_S_PREMIUM"])) {_oMobileRetentionPreviousOrder.s_premium = (string)_oData["MOBILERETENTIONPREVIOUSORDER_S_PREMIUM"]; } else {_oMobileRetentionPreviousOrder.s_premium=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REF_STAFF_NO"])) {_oMobileRetentionPreviousOrder.ref_staff_no = (string)_oData["MOBILERETENTIONPREVIOUSORDER_REF_STAFF_NO"]; } else {_oMobileRetentionPreviousOrder.ref_staff_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ACCESSORY_PRICE"])) {_oMobileRetentionPreviousOrder.accessory_price = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ACCESSORY_PRICE"]; } else {_oMobileRetentionPreviousOrder.accessory_price=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_M_CARD_EXP_MONTH"])) {_oMobileRetentionPreviousOrder.m_card_exp_month = (string)_oData["MOBILERETENTIONPREVIOUSORDER_M_CARD_EXP_MONTH"]; } else {_oMobileRetentionPreviousOrder.m_card_exp_month=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_INSTALLMENT_PERIOD"])) {_oMobileRetentionPreviousOrder.installment_period = (string)_oData["MOBILERETENTIONPREVIOUSORDER_INSTALLMENT_PERIOD"]; } else {_oMobileRetentionPreviousOrder.installment_period=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_M_CARD_TYPE"])) {_oMobileRetentionPreviousOrder.m_card_type = (string)_oData["MOBILERETENTIONPREVIOUSORDER_M_CARD_TYPE"]; } else {_oMobileRetentionPreviousOrder.m_card_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EASYWATCH_ORD_ID"])) {_oMobileRetentionPreviousOrder.easywatch_ord_id = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EASYWATCH_ORD_ID"]; } else {_oMobileRetentionPreviousOrder.easywatch_ord_id=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_NORMAL_REBATE"])) {_oMobileRetentionPreviousOrder.normal_rebate = (global::System.Nullable<bool>)_oData["MOBILERETENTIONPREVIOUSORDER_NORMAL_REBATE"]; } else {_oMobileRetentionPreviousOrder.normal_rebate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_M_REBATE_AMOUNT"])) {_oMobileRetentionPreviousOrder.m_rebate_amount = (string)_oData["MOBILERETENTIONPREVIOUSORDER_M_REBATE_AMOUNT"]; } else {_oMobileRetentionPreviousOrder.m_rebate_amount=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_M_CARD_HOLDER2"])) {_oMobileRetentionPreviousOrder.m_card_holder2 = (string)_oData["MOBILERETENTIONPREVIOUSORDER_M_CARD_HOLDER2"]; } else {_oMobileRetentionPreviousOrder.m_card_holder2=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_BILL_MEDIUM_EMAIL"])) {_oMobileRetentionPreviousOrder.bill_medium_email = (string)_oData["MOBILERETENTIONPREVIOUSORDER_BILL_MEDIUM_EMAIL"]; } else {_oMobileRetentionPreviousOrder.bill_medium_email=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ACTIVE"])) {_oMobileRetentionPreviousOrder.active = (global::System.Nullable<bool>)_oData["MOBILERETENTIONPREVIOUSORDER_ACTIVE"]; } else {_oMobileRetentionPreviousOrder.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_S_PREMIUM1"])) {_oMobileRetentionPreviousOrder.s_premium1 = (string)_oData["MOBILERETENTIONPREVIOUSORDER_S_PREMIUM1"]; } else {_oMobileRetentionPreviousOrder.s_premium1=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CARD_EXP_MONTH"])) {_oMobileRetentionPreviousOrder.card_exp_month = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CARD_EXP_MONTH"]; } else {_oMobileRetentionPreviousOrder.card_exp_month=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_OB_PROGRAM_ID"])) {_oMobileRetentionPreviousOrder.ob_program_id = (string)_oData["MOBILERETENTIONPREVIOUSORDER_OB_PROGRAM_ID"]; } else {_oMobileRetentionPreviousOrder.ob_program_id=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_SKU"])) {_oMobileRetentionPreviousOrder.sku = (string)_oData["MOBILERETENTIONPREVIOUSORDER_SKU"]; } else {_oMobileRetentionPreviousOrder.sku=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REF_SALESMANCODE"])) {_oMobileRetentionPreviousOrder.ref_salesmancode = (string)_oData["MOBILERETENTIONPREVIOUSORDER_REF_SALESMANCODE"]; } else {_oMobileRetentionPreviousOrder.ref_salesmancode=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GO_WIRELESS_PACKAGE_CODE"])) {_oMobileRetentionPreviousOrder.go_wireless_package_code = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GO_WIRELESS_PACKAGE_CODE"]; } else {_oMobileRetentionPreviousOrder.go_wireless_package_code=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_THIRD_PARTY_HKID"])) {_oMobileRetentionPreviousOrder.third_party_hkid = (string)_oData["MOBILERETENTIONPREVIOUSORDER_THIRD_PARTY_HKID"]; } else {_oMobileRetentionPreviousOrder.third_party_hkid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_PCCW_CUSTOMER"])) {_oMobileRetentionPreviousOrder.upgrade_existing_pccw_customer = (string)_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_PCCW_CUSTOMER"]; } else {_oMobileRetentionPreviousOrder.upgrade_existing_pccw_customer=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_D_ADDRESS"])) {_oMobileRetentionPreviousOrder.d_address = (string)_oData["MOBILERETENTIONPREVIOUSORDER_D_ADDRESS"]; } else {_oMobileRetentionPreviousOrder.d_address=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_REGISTERED_MOBILE_NO"])) {_oMobileRetentionPreviousOrder.upgrade_registered_mobile_no = (string)_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_REGISTERED_MOBILE_NO"]; } else {_oMobileRetentionPreviousOrder.upgrade_registered_mobile_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_CUSTOMER_TYPE"])) {_oMobileRetentionPreviousOrder.upgrade_existing_customer_type = (string)_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_CUSTOMER_TYPE"]; } else {_oMobileRetentionPreviousOrder.upgrade_existing_customer_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_NORMAL_REBATE_TYPE"])) {_oMobileRetentionPreviousOrder.normal_rebate_type = (string)_oData["MOBILERETENTIONPREVIOUSORDER_NORMAL_REBATE_TYPE"]; } else {_oMobileRetentionPreviousOrder.normal_rebate_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_DESC2"])) {_oMobileRetentionPreviousOrder.gift_desc2 = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_DESC2"]; } else {_oMobileRetentionPreviousOrder.gift_desc2=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_BRANCH_CODE"])) {_oMobileRetentionPreviousOrder.monthly_bank_account_branch_code = (string)_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_BRANCH_CODE"]; } else {_oMobileRetentionPreviousOrder.monthly_bank_account_branch_code=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REMARKS"])) {_oMobileRetentionPreviousOrder.remarks = (string)_oData["MOBILERETENTIONPREVIOUSORDER_REMARKS"]; } else {_oMobileRetentionPreviousOrder.remarks=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ACCEPT"])) {_oMobileRetentionPreviousOrder.accept = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ACCEPT"]; } else {_oMobileRetentionPreviousOrder.accept=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_DELIVERY_EXCHANGE"])) {_oMobileRetentionPreviousOrder.delivery_exchange = (string)_oData["MOBILERETENTIONPREVIOUSORDER_DELIVERY_EXCHANGE"]; } else {_oMobileRetentionPreviousOrder.delivery_exchange=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_CODE2"])) {_oMobileRetentionPreviousOrder.gift_code2 = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_CODE2"]; } else {_oMobileRetentionPreviousOrder.gift_code2=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_PREPAYMENT_WAIVE"])) {_oMobileRetentionPreviousOrder.prepayment_waive = (global::System.Nullable<bool>)_oData["MOBILERETENTIONPREVIOUSORDER_PREPAYMENT_WAIVE"]; } else {_oMobileRetentionPreviousOrder.prepayment_waive=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EXISTING_SMART_PHONE_IMEI"])) {_oMobileRetentionPreviousOrder.existing_smart_phone_imei = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EXISTING_SMART_PHONE_IMEI"]; } else {_oMobileRetentionPreviousOrder.existing_smart_phone_imei=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_MNP_HIS_ID"])) {_oMobileRetentionPreviousOrder.mnp_his_id = (global::System.Nullable<long>)_oData["MOBILERETENTIONPREVIOUSORDER_MNP_HIS_ID"]; } else {_oMobileRetentionPreviousOrder.mnp_his_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CUST_NAME"])) {_oMobileRetentionPreviousOrder.cust_name = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CUST_NAME"]; } else {_oMobileRetentionPreviousOrder.cust_name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CUST_TYPE"])) {_oMobileRetentionPreviousOrder.cust_type = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CUST_TYPE"]; } else {_oMobileRetentionPreviousOrder.cust_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_SPONSORSHIPS_AMOUNT"])) {_oMobileRetentionPreviousOrder.upgrade_sponsorships_amount = (string)_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_SPONSORSHIPS_AMOUNT"]; } else {_oMobileRetentionPreviousOrder.upgrade_sponsorships_amount=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_BILL_MEDIUM_WAIVE"])) {_oMobileRetentionPreviousOrder.bill_medium_waive = (global::System.Nullable<bool>)_oData["MOBILERETENTIONPREVIOUSORDER_BILL_MEDIUM_WAIVE"]; } else {_oMobileRetentionPreviousOrder.bill_medium_waive=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_DELIVERY_EXCHANGE_LOCATION"])) {_oMobileRetentionPreviousOrder.delivery_exchange_location = (string)_oData["MOBILERETENTIONPREVIOUSORDER_DELIVERY_EXCHANGE_LOCATION"]; } else {_oMobileRetentionPreviousOrder.delivery_exchange_location=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_HS_OFFER_TYPE_ID"])) {_oMobileRetentionPreviousOrder.hs_offer_type_id = (global::System.Nullable<int>)_oData["MOBILERETENTIONPREVIOUSORDER_HS_OFFER_TYPE_ID"]; } else {_oMobileRetentionPreviousOrder.hs_offer_type_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ORG_FEE"])) {_oMobileRetentionPreviousOrder.org_fee = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ORG_FEE"]; } else {_oMobileRetentionPreviousOrder.org_fee=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REBATE"])) {_oMobileRetentionPreviousOrder.rebate = (string)_oData["MOBILERETENTIONPREVIOUSORDER_REBATE"]; } else {_oMobileRetentionPreviousOrder.rebate=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_TYPE"])) {_oMobileRetentionPreviousOrder.upgrade_type = (string)_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_TYPE"]; } else {_oMobileRetentionPreviousOrder.upgrade_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GO_WIRELESS"])) {_oMobileRetentionPreviousOrder.go_wireless = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GO_WIRELESS"]; } else {_oMobileRetentionPreviousOrder.go_wireless=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EXTRA_REBATE"])) {_oMobileRetentionPreviousOrder.extra_rebate = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EXTRA_REBATE"]; } else {_oMobileRetentionPreviousOrder.extra_rebate=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_PLAN_EFF"])) {_oMobileRetentionPreviousOrder.plan_eff = (string)_oData["MOBILERETENTIONPREVIOUSORDER_PLAN_EFF"]; } else {_oMobileRetentionPreviousOrder.plan_eff=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EXTRA_REBATE_AMOUNT"])) {_oMobileRetentionPreviousOrder.extra_rebate_amount = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EXTRA_REBATE_AMOUNT"]; } else {_oMobileRetentionPreviousOrder.extra_rebate_amount=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CARD_EXP_YEAR"])) {_oMobileRetentionPreviousOrder.card_exp_year = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CARD_EXP_YEAR"]; } else {_oMobileRetentionPreviousOrder.card_exp_year=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_CONTRACT_SDATE"])) {_oMobileRetentionPreviousOrder.upgrade_existing_contract_sdate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_CONTRACT_SDATE"]; } else {_oMobileRetentionPreviousOrder.upgrade_existing_contract_sdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_HKID"])) {_oMobileRetentionPreviousOrder.ord_place_hkid = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_HKID"]; } else {_oMobileRetentionPreviousOrder.ord_place_hkid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REGISTER_ADDRESS"])) {_oMobileRetentionPreviousOrder.register_address = (string)_oData["MOBILERETENTIONPREVIOUSORDER_REGISTER_ADDRESS"]; } else {_oMobileRetentionPreviousOrder.register_address=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GENDER"])) {_oMobileRetentionPreviousOrder.gender = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GENDER"]; } else {_oMobileRetentionPreviousOrder.gender=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_LOB_AC"])) {_oMobileRetentionPreviousOrder.lob_ac = (string)_oData["MOBILERETENTIONPREVIOUSORDER_LOB_AC"]; } else {_oMobileRetentionPreviousOrder.lob_ac=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_SIM_MRT_NO"])) {_oMobileRetentionPreviousOrder.sim_mrt_no = (global::System.Nullable<int>)_oData["MOBILERETENTIONPREVIOUSORDER_SIM_MRT_NO"]; } else {_oMobileRetentionPreviousOrder.sim_mrt_no=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REDEMPTION_NOTICE_OPTION"])) {_oMobileRetentionPreviousOrder.redemption_notice_option = (string)_oData["MOBILERETENTIONPREVIOUSORDER_REDEMPTION_NOTICE_OPTION"]; } else {_oMobileRetentionPreviousOrder.redemption_notice_option=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_DELIVERY_COLLECTION_TYPE"])) {_oMobileRetentionPreviousOrder.delivery_collection_type = (string)_oData["MOBILERETENTIONPREVIOUSORDER_DELIVERY_COLLECTION_TYPE"]; } else {_oMobileRetentionPreviousOrder.delivery_collection_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ACTION_DATE"])) {_oMobileRetentionPreviousOrder.action_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_ACTION_DATE"]; } else {_oMobileRetentionPreviousOrder.action_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_THIRD_PARTY_ID_TYPE"])) {_oMobileRetentionPreviousOrder.third_party_id_type = (string)_oData["MOBILERETENTIONPREVIOUSORDER_THIRD_PARTY_ID_TYPE"]; } else {_oMobileRetentionPreviousOrder.third_party_id_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ORG_FTG"])) {_oMobileRetentionPreviousOrder.org_ftg = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ORG_FTG"]; } else {_oMobileRetentionPreviousOrder.org_ftg=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_SERVICE_TENURE"])) {_oMobileRetentionPreviousOrder.upgrade_service_tenure = (string)_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_SERVICE_TENURE"]; } else {_oMobileRetentionPreviousOrder.upgrade_service_tenure=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_PAYMENT_TYPE"])) {_oMobileRetentionPreviousOrder.monthly_payment_type = (string)_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_PAYMENT_TYPE"]; } else {_oMobileRetentionPreviousOrder.monthly_payment_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CONTACT_NO"])) {_oMobileRetentionPreviousOrder.contact_no = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CONTACT_NO"]; } else {_oMobileRetentionPreviousOrder.contact_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ORG_MRT"])) {_oMobileRetentionPreviousOrder.org_mrt = (global::System.Nullable<int>)_oData["MOBILERETENTIONPREVIOUSORDER_ORG_MRT"]; } else {_oMobileRetentionPreviousOrder.org_mrt=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_SIM_ITEM_NAME"])) {_oMobileRetentionPreviousOrder.sim_item_name = (string)_oData["MOBILERETENTIONPREVIOUSORDER_SIM_ITEM_NAME"]; } else {_oMobileRetentionPreviousOrder.sim_item_name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_PAY_METHOD"])) {_oMobileRetentionPreviousOrder.pay_method = (string)_oData["MOBILERETENTIONPREVIOUSORDER_PAY_METHOD"]; } else {_oMobileRetentionPreviousOrder.pay_method=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_HS_MODEL"])) {_oMobileRetentionPreviousOrder.hs_model = (string)_oData["MOBILERETENTIONPREVIOUSORDER_HS_MODEL"]; } else {_oMobileRetentionPreviousOrder.hs_model=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_CODE"])) {_oMobileRetentionPreviousOrder.gift_code = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_CODE"]; } else {_oMobileRetentionPreviousOrder.gift_code=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_HKID"])) {_oMobileRetentionPreviousOrder.monthly_bank_account_hkid = (string)_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_HKID"]; } else {_oMobileRetentionPreviousOrder.monthly_bank_account_hkid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EXTRA_OFFER"])) {_oMobileRetentionPreviousOrder.extra_offer = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EXTRA_OFFER"]; } else {_oMobileRetentionPreviousOrder.extra_offer=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_NO"])) {_oMobileRetentionPreviousOrder.monthly_bank_account_no = (string)_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_NO"]; } else {_oMobileRetentionPreviousOrder.monthly_bank_account_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_FIRST_MONTH_LICENSE_FEE"])) {_oMobileRetentionPreviousOrder.first_month_license_fee = (string)_oData["MOBILERETENTIONPREVIOUSORDER_FIRST_MONTH_LICENSE_FEE"]; } else {_oMobileRetentionPreviousOrder.first_month_license_fee=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_RETRIEVE_CNT"])) {_oMobileRetentionPreviousOrder.retrieve_cnt = (global::System.Nullable<int>)_oData["MOBILERETENTIONPREVIOUSORDER_RETRIEVE_CNT"]; } else {_oMobileRetentionPreviousOrder.retrieve_cnt=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_DDATE"])) {_oMobileRetentionPreviousOrder.ddate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_DDATE"]; } else {_oMobileRetentionPreviousOrder.ddate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_S_PREMIUM2"])) {_oMobileRetentionPreviousOrder.s_premium2 = (string)_oData["MOBILERETENTIONPREVIOUSORDER_S_PREMIUM2"]; } else {_oMobileRetentionPreviousOrder.s_premium2=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_ID_TYPE"])) {_oMobileRetentionPreviousOrder.monthly_bank_account_id_type = (string)_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_ID_TYPE"]; } else {_oMobileRetentionPreviousOrder.monthly_bank_account_id_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CARD_TYPE"])) {_oMobileRetentionPreviousOrder.card_type = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CARD_TYPE"]; } else {_oMobileRetentionPreviousOrder.card_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_NEXT_BILL"])) {_oMobileRetentionPreviousOrder.next_bill = (global::System.Nullable<bool>)_oData["MOBILERETENTIONPREVIOUSORDER_NEXT_BILL"]; } else {_oMobileRetentionPreviousOrder.next_bill=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_PCD_PAID_GO_WIRELESS"])) {_oMobileRetentionPreviousOrder.pcd_paid_go_wireless = (global::System.Nullable<bool>)_oData["MOBILERETENTIONPREVIOUSORDER_PCD_PAID_GO_WIRELESS"]; } else {_oMobileRetentionPreviousOrder.pcd_paid_go_wireless=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_REBATE_CALCULATION"])) {_oMobileRetentionPreviousOrder.upgrade_rebate_calculation = (string)_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_REBATE_CALCULATION"]; } else {_oMobileRetentionPreviousOrder.upgrade_rebate_calculation=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EXT_PLACE_TEL"])) {_oMobileRetentionPreviousOrder.ext_place_tel = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EXT_PLACE_TEL"]; } else {_oMobileRetentionPreviousOrder.ext_place_tel=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_M_3RD_HKID"])) {_oMobileRetentionPreviousOrder.m_3rd_hkid = (string)_oData["MOBILERETENTIONPREVIOUSORDER_M_3RD_HKID"]; } else {_oMobileRetentionPreviousOrder.m_3rd_hkid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_RETENTION_TYPE"])) {_oMobileRetentionPreviousOrder.retention_type = (string)_oData["MOBILERETENTIONPREVIOUSORDER_RETENTION_TYPE"]; } else {_oMobileRetentionPreviousOrder.retention_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_BILL_ADDRESS_HIS_ID"])) {_oMobileRetentionPreviousOrder.bill_address_his_id = (global::System.Nullable<long>)_oData["MOBILERETENTIONPREVIOUSORDER_BILL_ADDRESS_HIS_ID"]; } else {_oMobileRetentionPreviousOrder.bill_address_his_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_AIG_GIFT"])) {_oMobileRetentionPreviousOrder.aig_gift = (string)_oData["MOBILERETENTIONPREVIOUSORDER_AIG_GIFT"]; } else {_oMobileRetentionPreviousOrder.aig_gift=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CUST_STAFF_NO"])) {_oMobileRetentionPreviousOrder.cust_staff_no = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CUST_STAFF_NO"]; } else {_oMobileRetentionPreviousOrder.cust_staff_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ORDER_ID"])) {_oMobileRetentionPreviousOrder.order_id = (global::System.Nullable<int>)_oData["MOBILERETENTIONPREVIOUSORDER_ORDER_ID"]; } else {_oMobileRetentionPreviousOrder.order_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_FAMILY_NAME"])) {_oMobileRetentionPreviousOrder.family_name = (string)_oData["MOBILERETENTIONPREVIOUSORDER_FAMILY_NAME"]; } else {_oMobileRetentionPreviousOrder.family_name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CDATE"])) {_oMobileRetentionPreviousOrder.cdate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_CDATE"]; } else {_oMobileRetentionPreviousOrder.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_STATUS_BY_CS_ADMIN"])) {_oMobileRetentionPreviousOrder.status_by_cs_admin = (string)_oData["MOBILERETENTIONPREVIOUSORDER_STATUS_BY_CS_ADMIN"]; } else {_oMobileRetentionPreviousOrder.status_by_cs_admin=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_SIM_ITEM_NUMBER"])) {_oMobileRetentionPreviousOrder.sim_item_number = (string)_oData["MOBILERETENTIONPREVIOUSORDER_SIM_ITEM_NUMBER"]; } else {_oMobileRetentionPreviousOrder.sim_item_number=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_VIP_CASE"])) {_oMobileRetentionPreviousOrder.vip_case = (string)_oData["MOBILERETENTIONPREVIOUSORDER_VIP_CASE"]; } else {_oMobileRetentionPreviousOrder.vip_case=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIVEN_NAME"])) {_oMobileRetentionPreviousOrder.given_name = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIVEN_NAME"]; } else {_oMobileRetentionPreviousOrder.given_name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_LOG_DATE"])) {_oMobileRetentionPreviousOrder.log_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_LOG_DATE"]; } else {_oMobileRetentionPreviousOrder.log_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EXTN"])) {_oMobileRetentionPreviousOrder.extn = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EXTN"]; } else {_oMobileRetentionPreviousOrder.extn=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_D_TIME"])) {_oMobileRetentionPreviousOrder.d_time = (string)_oData["MOBILERETENTIONPREVIOUSORDER_D_TIME"]; } else {_oMobileRetentionPreviousOrder.d_time=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_BANK_NAME"])) {_oMobileRetentionPreviousOrder.bank_name = (string)_oData["MOBILERETENTIONPREVIOUSORDER_BANK_NAME"]; } else {_oMobileRetentionPreviousOrder.bank_name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_DELIVERY_EXCHANGE_OPTION"])) {_oMobileRetentionPreviousOrder.delivery_exchange_option = (string)_oData["MOBILERETENTIONPREVIOUSORDER_DELIVERY_EXCHANGE_OPTION"]; } else {_oMobileRetentionPreviousOrder.delivery_exchange_option=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_SERVICE_ACCOUNT_NO"])) {_oMobileRetentionPreviousOrder.upgrade_service_account_no = (string)_oData["MOBILERETENTIONPREVIOUSORDER_UPGRADE_SERVICE_ACCOUNT_NO"]; } else {_oMobileRetentionPreviousOrder.upgrade_service_account_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ACTION_OF_RATE_PLAN_EFFECTIVE"])) {_oMobileRetentionPreviousOrder.action_of_rate_plan_effective = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ACTION_OF_RATE_PLAN_EFFECTIVE"]; } else {_oMobileRetentionPreviousOrder.action_of_rate_plan_effective=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_M_CARD_NO"])) {_oMobileRetentionPreviousOrder.m_card_no = (string)_oData["MOBILERETENTIONPREVIOUSORDER_M_CARD_NO"]; } else {_oMobileRetentionPreviousOrder.m_card_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EXISTING_CONTRACT_END_DATE"])) {_oMobileRetentionPreviousOrder.existing_contract_end_date = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EXISTING_CONTRACT_END_DATE"]; } else {_oMobileRetentionPreviousOrder.existing_contract_end_date=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CON_EFF_DATE"])) {_oMobileRetentionPreviousOrder.con_eff_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_CON_EFF_DATE"]; } else {_oMobileRetentionPreviousOrder.con_eff_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_M_3RD_HKID2"])) {_oMobileRetentionPreviousOrder.m_3rd_hkid2 = (string)_oData["MOBILERETENTIONPREVIOUSORDER_M_3RD_HKID2"]; } else {_oMobileRetentionPreviousOrder.m_3rd_hkid2=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_AMOUNT"])) {_oMobileRetentionPreviousOrder.amount = (string)_oData["MOBILERETENTIONPREVIOUSORDER_AMOUNT"]; } else {_oMobileRetentionPreviousOrder.amount=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ID_TYPE"])) {_oMobileRetentionPreviousOrder.id_type = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ID_TYPE"]; } else {_oMobileRetentionPreviousOrder.id_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_RATE_PLAN"])) {_oMobileRetentionPreviousOrder.rate_plan = (string)_oData["MOBILERETENTIONPREVIOUSORDER_RATE_PLAN"]; } else {_oMobileRetentionPreviousOrder.rate_plan=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CHANNEL"])) {_oMobileRetentionPreviousOrder.channel = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CHANNEL"]; } else {_oMobileRetentionPreviousOrder.channel=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ACTION_EFF_DATE"])) {_oMobileRetentionPreviousOrder.action_eff_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_ACTION_EFF_DATE"]; } else {_oMobileRetentionPreviousOrder.action_eff_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ISSUE_TYPE"])) {_oMobileRetentionPreviousOrder.issue_type = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ISSUE_TYPE"]; } else {_oMobileRetentionPreviousOrder.issue_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_FREE_MON"])) {_oMobileRetentionPreviousOrder.free_mon = (string)_oData["MOBILERETENTIONPREVIOUSORDER_FREE_MON"]; } else {_oMobileRetentionPreviousOrder.free_mon=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_PLAN_EFF_DATE"])) {_oMobileRetentionPreviousOrder.plan_eff_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_PLAN_EFF_DATE"]; } else {_oMobileRetentionPreviousOrder.plan_eff_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_DEL_REMARK"])) {_oMobileRetentionPreviousOrder.del_remark = (string)_oData["MOBILERETENTIONPREVIOUSORDER_DEL_REMARK"]; } else {_oMobileRetentionPreviousOrder.del_remark=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_TEAMCODE"])) {_oMobileRetentionPreviousOrder.teamcode = (string)_oData["MOBILERETENTIONPREVIOUSORDER_TEAMCODE"]; } else {_oMobileRetentionPreviousOrder.teamcode=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_STAFF_NAME"])) {_oMobileRetentionPreviousOrder.staff_name = (string)_oData["MOBILERETENTIONPREVIOUSORDER_STAFF_NAME"]; } else {_oMobileRetentionPreviousOrder.staff_name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_EDF_NO"])) {_oMobileRetentionPreviousOrder.edf_no = (string)_oData["MOBILERETENTIONPREVIOUSORDER_EDF_NO"]; } else {_oMobileRetentionPreviousOrder.edf_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_BY"])) {_oMobileRetentionPreviousOrder.ord_place_by = (string)_oData["MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_BY"]; } else {_oMobileRetentionPreviousOrder.ord_place_by=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CANCEL_RENEW"])) {_oMobileRetentionPreviousOrder.cancel_renew = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CANCEL_RENEW"]; } else {_oMobileRetentionPreviousOrder.cancel_renew=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_PREFERRED_LANGUAGES"])) {_oMobileRetentionPreviousOrder.preferred_languages = (string)_oData["MOBILERETENTIONPREVIOUSORDER_PREFERRED_LANGUAGES"]; } else {_oMobileRetentionPreviousOrder.preferred_languages=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_HKID"])) {_oMobileRetentionPreviousOrder.hkid = (string)_oData["MOBILERETENTIONPREVIOUSORDER_HKID"]; } else {_oMobileRetentionPreviousOrder.hkid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CARD_NO"])) {_oMobileRetentionPreviousOrder.card_no = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CARD_NO"]; } else {_oMobileRetentionPreviousOrder.card_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_AC_NO"])) {_oMobileRetentionPreviousOrder.ac_no = (string)_oData["MOBILERETENTIONPREVIOUSORDER_AC_NO"]; } else {_oMobileRetentionPreviousOrder.ac_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_BILL_CUT_NUM"])) {_oMobileRetentionPreviousOrder.bill_cut_num = (global::System.Nullable<int>)_oData["MOBILERETENTIONPREVIOUSORDER_BILL_CUT_NUM"]; } else {_oMobileRetentionPreviousOrder.bill_cut_num=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_PREMIUM"])) {_oMobileRetentionPreviousOrder.premium = (string)_oData["MOBILERETENTIONPREVIOUSORDER_PREMIUM"]; } else {_oMobileRetentionPreviousOrder.premium=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_M_3RD_ID_TYPE"])) {_oMobileRetentionPreviousOrder.m_3rd_id_type = (string)_oData["MOBILERETENTIONPREVIOUSORDER_M_3RD_ID_TYPE"]; } else {_oMobileRetentionPreviousOrder.m_3rd_id_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI2"])) {_oMobileRetentionPreviousOrder.gift_imei2 = (string)_oData["MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI2"]; } else {_oMobileRetentionPreviousOrder.gift_imei2=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REASONS"])) {_oMobileRetentionPreviousOrder.reasons = (string)_oData["MOBILERETENTIONPREVIOUSORDER_REASONS"]; } else {_oMobileRetentionPreviousOrder.reasons=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_LANGUAGE"])) {_oMobileRetentionPreviousOrder.language = (string)_oData["MOBILERETENTIONPREVIOUSORDER_LANGUAGE"]; } else {_oMobileRetentionPreviousOrder.language=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_REBATE_AMOUNT"])) {_oMobileRetentionPreviousOrder.rebate_amount = (string)_oData["MOBILERETENTIONPREVIOUSORDER_REBATE_AMOUNT"]; } else {_oMobileRetentionPreviousOrder.rebate_amount=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_LOB"])) {_oMobileRetentionPreviousOrder.lob = (string)_oData["MOBILERETENTIONPREVIOUSORDER_LOB"]; } else {_oMobileRetentionPreviousOrder.lob=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_M_3RD_CONTACT_NO"])) {_oMobileRetentionPreviousOrder.m_3rd_contact_no = (string)_oData["MOBILERETENTIONPREVIOUSORDER_M_3RD_CONTACT_NO"]; } else {_oMobileRetentionPreviousOrder.m_3rd_contact_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_STAFF_NO"])) {_oMobileRetentionPreviousOrder.staff_no = (string)_oData["MOBILERETENTIONPREVIOUSORDER_STAFF_NO"]; } else {_oMobileRetentionPreviousOrder.staff_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_S_PREMIUM3"])) {_oMobileRetentionPreviousOrder.s_premium3 = (string)_oData["MOBILERETENTIONPREVIOUSORDER_S_PREMIUM3"]; } else {_oMobileRetentionPreviousOrder.s_premium3=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_SP_D_DATE"])) {_oMobileRetentionPreviousOrder.sp_d_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONPREVIOUSORDER_SP_D_DATE"]; } else {_oMobileRetentionPreviousOrder.sp_d_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_BUNDLE_NAME"])) {_oMobileRetentionPreviousOrder.bundle_name = (string)_oData["MOBILERETENTIONPREVIOUSORDER_BUNDLE_NAME"]; } else {_oMobileRetentionPreviousOrder.bundle_name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_ACCESSORY_WAIVE"])) {_oMobileRetentionPreviousOrder.accessory_waive = (global::System.Nullable<bool>)_oData["MOBILERETENTIONPREVIOUSORDER_ACCESSORY_WAIVE"]; } else {_oMobileRetentionPreviousOrder.accessory_waive=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_SIM_ITEM_CODE"])) {_oMobileRetentionPreviousOrder.sim_item_code = (string)_oData["MOBILERETENTIONPREVIOUSORDER_SIM_ITEM_CODE"]; } else {_oMobileRetentionPreviousOrder.sim_item_code=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_HOLDER"])) {_oMobileRetentionPreviousOrder.monthly_bank_account_holder = (string)_oData["MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_HOLDER"]; } else {_oMobileRetentionPreviousOrder.monthly_bank_account_holder=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONPREVIOUSORDER_CARD_HOLDER"])) {_oMobileRetentionPreviousOrder.card_holder = (string)_oData["MOBILERETENTIONPREVIOUSORDER_CARD_HOLDER"]; } else {_oMobileRetentionPreviousOrder.card_holder=global::System.String.Empty; }
                _oMobileRetentionPreviousOrder.SetDB(x_oDB);
                _oMobileRetentionPreviousOrder.GetFound();
                _oRow.Add(_oMobileRetentionPreviousOrder);
            }
            _oData.Close();
            _oData.Dispose();
            return _oRow;
        }
        #endregion
        
        #region DataSet
        /// <summary>
        /// Summary description for get table from records with DataSet
        /// </summary>
        
        public global::System.Data.DataSet GetDataSet()
        {
            return GetDataSet(n_oDB,"");
        }
        
        
        public global::System.Data.DataSet GetDataSet(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return GetDataSet(n_oDB,x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( MobileRetentionPreviousOrder.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,MobileRetentionPreviousOrder.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(MobileRetentionPreviousOrder.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(MobileRetentionPreviousOrder.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [MobileRetentionPreviousOrder].[gift_imei] AS MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI,[MobileRetentionPreviousOrder].[s_premium4] AS MOBILERETENTIONPREVIOUSORDER_S_PREMIUM4,[MobileRetentionPreviousOrder].[upgrade_existing_customer_type] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_CUSTOMER_TYPE,[MobileRetentionPreviousOrder].[gift_desc4] AS MOBILERETENTIONPREVIOUSORDER_GIFT_DESC4,[MobileRetentionPreviousOrder].[accessory_desc] AS MOBILERETENTIONPREVIOUSORDER_ACCESSORY_DESC,[MobileRetentionPreviousOrder].[staff_name] AS MOBILERETENTIONPREVIOUSORDER_STAFF_NAME,[MobileRetentionPreviousOrder].[action_required] AS MOBILERETENTIONPREVIOUSORDER_ACTION_REQUIRED,[MobileRetentionPreviousOrder].[registered_address_his_id] AS MOBILERETENTIONPREVIOUSORDER_REGISTERED_ADDRESS_HIS_ID,[MobileRetentionPreviousOrder].[vas_eff_date] AS MOBILERETENTIONPREVIOUSORDER_VAS_EFF_DATE,[MobileRetentionPreviousOrder].[monthly_bank_account_bank_code] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_BANK_CODE,[MobileRetentionPreviousOrder].[sim_item_number] AS MOBILERETENTIONPREVIOUSORDER_SIM_ITEM_NUMBER,[MobileRetentionPreviousOrder].[special_handling_dummy_code] AS MOBILERETENTIONPREVIOUSORDER_SPECIAL_HANDLING_DUMMY_CODE,[MobileRetentionPreviousOrder].[card_no] AS MOBILERETENTIONPREVIOUSORDER_CARD_NO,[MobileRetentionPreviousOrder].[m_card_exp_year] AS MOBILERETENTIONPREVIOUSORDER_M_CARD_EXP_YEAR,[MobileRetentionPreviousOrder].[bill_medium_email] AS MOBILERETENTIONPREVIOUSORDER_BILL_MEDIUM_EMAIL,[MobileRetentionPreviousOrder].[remarks2PY] AS MOBILERETENTIONPREVIOUSORDER_REMARKS2PY,[MobileRetentionPreviousOrder].[trade_field] AS MOBILERETENTIONPREVIOUSORDER_TRADE_FIELD,[MobileRetentionPreviousOrder].[ord_place_tel] AS MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_TEL,[MobileRetentionPreviousOrder].[action_of_rate_plan_effective] AS MOBILERETENTIONPREVIOUSORDER_ACTION_OF_RATE_PLAN_EFFECTIVE,[MobileRetentionPreviousOrder].[cooling_offer] AS MOBILERETENTIONPREVIOUSORDER_COOLING_OFFER,[MobileRetentionPreviousOrder].[rec_no] AS MOBILERETENTIONPREVIOUSORDER_REC_NO,[MobileRetentionPreviousOrder].[upgrade_handset_offer_rebate_schedule] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_HANDSET_OFFER_REBATE_SCHEDULE,[MobileRetentionPreviousOrder].[change_payment_type] AS MOBILERETENTIONPREVIOUSORDER_CHANGE_PAYMENT_TYPE,[MobileRetentionPreviousOrder].[date_of_birth] AS MOBILERETENTIONPREVIOUSORDER_DATE_OF_BIRTH,[MobileRetentionPreviousOrder].[contact_person] AS MOBILERETENTIONPREVIOUSORDER_CONTACT_PERSON,[MobileRetentionPreviousOrder].[extra_d_charge] AS MOBILERETENTIONPREVIOUSORDER_EXTRA_D_CHARGE,[MobileRetentionPreviousOrder].[tl_name] AS MOBILERETENTIONPREVIOUSORDER_TL_NAME,[MobileRetentionPreviousOrder].[fast_start] AS MOBILERETENTIONPREVIOUSORDER_FAST_START,[MobileRetentionPreviousOrder].[issue_type] AS MOBILERETENTIONPREVIOUSORDER_ISSUE_TYPE,[MobileRetentionPreviousOrder].[sp_ref_no] AS MOBILERETENTIONPREVIOUSORDER_SP_REF_NO,[MobileRetentionPreviousOrder].[edate] AS MOBILERETENTIONPREVIOUSORDER_EDATE,[MobileRetentionPreviousOrder].[exist_cust_plan] AS MOBILERETENTIONPREVIOUSORDER_EXIST_CUST_PLAN,[MobileRetentionPreviousOrder].[ord_place_rel] AS MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_REL,[MobileRetentionPreviousOrder].[mrt_no] AS MOBILERETENTIONPREVIOUSORDER_MRT_NO,[MobileRetentionPreviousOrder].[imei_no] AS MOBILERETENTIONPREVIOUSORDER_IMEI_NO,[MobileRetentionPreviousOrder].[existing_smart_phone_model] AS MOBILERETENTIONPREVIOUSORDER_EXISTING_SMART_PHONE_MODEL,[MobileRetentionPreviousOrder].[bank_code] AS MOBILERETENTIONPREVIOUSORDER_BANK_CODE,[MobileRetentionPreviousOrder].[pos_ref_no] AS MOBILERETENTIONPREVIOUSORDER_POS_REF_NO,[MobileRetentionPreviousOrder].[bill_cut_date] AS MOBILERETENTIONPREVIOUSORDER_BILL_CUT_DATE,[MobileRetentionPreviousOrder].[gift_imei3] AS MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI3,[MobileRetentionPreviousOrder].[exist_plan] AS MOBILERETENTIONPREVIOUSORDER_EXIST_PLAN,[MobileRetentionPreviousOrder].[waive] AS MOBILERETENTIONPREVIOUSORDER_WAIVE,[MobileRetentionPreviousOrder].[program] AS MOBILERETENTIONPREVIOUSORDER_PROGRAM,[MobileRetentionPreviousOrder].[first_month_fee] AS MOBILERETENTIONPREVIOUSORDER_FIRST_MONTH_FEE,[MobileRetentionPreviousOrder].[r_offer] AS MOBILERETENTIONPREVIOUSORDER_R_OFFER,[MobileRetentionPreviousOrder].[cid] AS MOBILERETENTIONPREVIOUSORDER_CID,[MobileRetentionPreviousOrder].[did] AS MOBILERETENTIONPREVIOUSORDER_DID,[MobileRetentionPreviousOrder].[ftg_tenure] AS MOBILERETENTIONPREVIOUSORDER_FTG_TENURE,[MobileRetentionPreviousOrder].[con_per] AS MOBILERETENTIONPREVIOUSORDER_CON_PER,[MobileRetentionPreviousOrder].[gift_code4] AS MOBILERETENTIONPREVIOUSORDER_GIFT_CODE4,[MobileRetentionPreviousOrder].[easywatch_type] AS MOBILERETENTIONPREVIOUSORDER_EASYWATCH_TYPE,[MobileRetentionPreviousOrder].[sms_mrt] AS MOBILERETENTIONPREVIOUSORDER_SMS_MRT,[MobileRetentionPreviousOrder].[tpy_his_id] AS MOBILERETENTIONPREVIOUSORDER_TPY_HIS_ID,[MobileRetentionPreviousOrder].[monthly_payment_method] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_PAYMENT_METHOD,[MobileRetentionPreviousOrder].[remarks2EDF] AS MOBILERETENTIONPREVIOUSORDER_REMARKS2EDF,[MobileRetentionPreviousOrder].[gift_desc3] AS MOBILERETENTIONPREVIOUSORDER_GIFT_DESC3,[MobileRetentionPreviousOrder].[gift_imei4] AS MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI4,[MobileRetentionPreviousOrder].[monthly_bank_account_hkid2] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_HKID2,[MobileRetentionPreviousOrder].[d_date] AS MOBILERETENTIONPREVIOUSORDER_D_DATE,[MobileRetentionPreviousOrder].[gift_desc] AS MOBILERETENTIONPREVIOUSORDER_GIFT_DESC,[MobileRetentionPreviousOrder].[pool] AS MOBILERETENTIONPREVIOUSORDER_POOL,[MobileRetentionPreviousOrder].[cn_mrt_no] AS MOBILERETENTIONPREVIOUSORDER_CN_MRT_NO,[MobileRetentionPreviousOrder].[accessory_imei] AS MOBILERETENTIONPREVIOUSORDER_ACCESSORY_IMEI,[MobileRetentionPreviousOrder].[third_party_credit_card] AS MOBILERETENTIONPREVIOUSORDER_THIRD_PARTY_CREDIT_CARD,[MobileRetentionPreviousOrder].[special_approval] AS MOBILERETENTIONPREVIOUSORDER_SPECIAL_APPROVAL,[MobileRetentionPreviousOrder].[upgrade_existing_contract_edate] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_CONTRACT_EDATE,[MobileRetentionPreviousOrder].[accessory_code] AS MOBILERETENTIONPREVIOUSORDER_ACCESSORY_CODE,[MobileRetentionPreviousOrder].[s_premium] AS MOBILERETENTIONPREVIOUSORDER_S_PREMIUM,[MobileRetentionPreviousOrder].[ref_staff_no] AS MOBILERETENTIONPREVIOUSORDER_REF_STAFF_NO,[MobileRetentionPreviousOrder].[accessory_price] AS MOBILERETENTIONPREVIOUSORDER_ACCESSORY_PRICE,[MobileRetentionPreviousOrder].[m_card_exp_month] AS MOBILERETENTIONPREVIOUSORDER_M_CARD_EXP_MONTH,[MobileRetentionPreviousOrder].[installment_period] AS MOBILERETENTIONPREVIOUSORDER_INSTALLMENT_PERIOD,[MobileRetentionPreviousOrder].[m_card_type] AS MOBILERETENTIONPREVIOUSORDER_M_CARD_TYPE,[MobileRetentionPreviousOrder].[easywatch_ord_id] AS MOBILERETENTIONPREVIOUSORDER_EASYWATCH_ORD_ID,[MobileRetentionPreviousOrder].[normal_rebate] AS MOBILERETENTIONPREVIOUSORDER_NORMAL_REBATE,[MobileRetentionPreviousOrder].[m_rebate_amount] AS MOBILERETENTIONPREVIOUSORDER_M_REBATE_AMOUNT,[MobileRetentionPreviousOrder].[m_card_holder2] AS MOBILERETENTIONPREVIOUSORDER_M_CARD_HOLDER2,[MobileRetentionPreviousOrder].[monthly_bank_account_holder] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_HOLDER,[MobileRetentionPreviousOrder].[active] AS MOBILERETENTIONPREVIOUSORDER_ACTIVE,[MobileRetentionPreviousOrder].[s_premium1] AS MOBILERETENTIONPREVIOUSORDER_S_PREMIUM1,[MobileRetentionPreviousOrder].[card_exp_month] AS MOBILERETENTIONPREVIOUSORDER_CARD_EXP_MONTH,[MobileRetentionPreviousOrder].[ob_program_id] AS MOBILERETENTIONPREVIOUSORDER_OB_PROGRAM_ID,[MobileRetentionPreviousOrder].[sku] AS MOBILERETENTIONPREVIOUSORDER_SKU,[MobileRetentionPreviousOrder].[salesmancode] AS MOBILERETENTIONPREVIOUSORDER_SALESMANCODE,[MobileRetentionPreviousOrder].[go_wireless_package_code] AS MOBILERETENTIONPREVIOUSORDER_GO_WIRELESS_PACKAGE_CODE,[MobileRetentionPreviousOrder].[lob] AS MOBILERETENTIONPREVIOUSORDER_LOB,[MobileRetentionPreviousOrder].[ref_salesmancode] AS MOBILERETENTIONPREVIOUSORDER_REF_SALESMANCODE,[MobileRetentionPreviousOrder].[third_party_hkid] AS MOBILERETENTIONPREVIOUSORDER_THIRD_PARTY_HKID,[MobileRetentionPreviousOrder].[upgrade_existing_pccw_customer] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_PCCW_CUSTOMER,[MobileRetentionPreviousOrder].[d_address] AS MOBILERETENTIONPREVIOUSORDER_D_ADDRESS,[MobileRetentionPreviousOrder].[upgrade_registered_mobile_no] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_REGISTERED_MOBILE_NO,[MobileRetentionPreviousOrder].[gift_code3] AS MOBILERETENTIONPREVIOUSORDER_GIFT_CODE3,[MobileRetentionPreviousOrder].[normal_rebate_type] AS MOBILERETENTIONPREVIOUSORDER_NORMAL_REBATE_TYPE,[MobileRetentionPreviousOrder].[gift_desc2] AS MOBILERETENTIONPREVIOUSORDER_GIFT_DESC2,[MobileRetentionPreviousOrder].[monthly_bank_account_branch_code] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_BRANCH_CODE,[MobileRetentionPreviousOrder].[remarks] AS MOBILERETENTIONPREVIOUSORDER_REMARKS,[MobileRetentionPreviousOrder].[accept] AS MOBILERETENTIONPREVIOUSORDER_ACCEPT,[MobileRetentionPreviousOrder].[delivery_exchange] AS MOBILERETENTIONPREVIOUSORDER_DELIVERY_EXCHANGE,[MobileRetentionPreviousOrder].[gift_code2] AS MOBILERETENTIONPREVIOUSORDER_GIFT_CODE2,[MobileRetentionPreviousOrder].[prepayment_waive] AS MOBILERETENTIONPREVIOUSORDER_PREPAYMENT_WAIVE,[MobileRetentionPreviousOrder].[existing_smart_phone_imei] AS MOBILERETENTIONPREVIOUSORDER_EXISTING_SMART_PHONE_IMEI,[MobileRetentionPreviousOrder].[mnp_his_id] AS MOBILERETENTIONPREVIOUSORDER_MNP_HIS_ID,[MobileRetentionPreviousOrder].[cust_name] AS MOBILERETENTIONPREVIOUSORDER_CUST_NAME,[MobileRetentionPreviousOrder].[upgrade_sponsorships_amount] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_SPONSORSHIPS_AMOUNT,[MobileRetentionPreviousOrder].[bill_medium_waive] AS MOBILERETENTIONPREVIOUSORDER_BILL_MEDIUM_WAIVE,[MobileRetentionPreviousOrder].[delivery_exchange_location] AS MOBILERETENTIONPREVIOUSORDER_DELIVERY_EXCHANGE_LOCATION,[MobileRetentionPreviousOrder].[hs_offer_type_id] AS MOBILERETENTIONPREVIOUSORDER_HS_OFFER_TYPE_ID,[MobileRetentionPreviousOrder].[org_fee] AS MOBILERETENTIONPREVIOUSORDER_ORG_FEE,[MobileRetentionPreviousOrder].[rebate] AS MOBILERETENTIONPREVIOUSORDER_REBATE,[MobileRetentionPreviousOrder].[upgrade_type] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_TYPE,[MobileRetentionPreviousOrder].[go_wireless] AS MOBILERETENTIONPREVIOUSORDER_GO_WIRELESS,[MobileRetentionPreviousOrder].[extra_rebate] AS MOBILERETENTIONPREVIOUSORDER_EXTRA_REBATE,[MobileRetentionPreviousOrder].[plan_eff] AS MOBILERETENTIONPREVIOUSORDER_PLAN_EFF,[MobileRetentionPreviousOrder].[extra_rebate_amount] AS MOBILERETENTIONPREVIOUSORDER_EXTRA_REBATE_AMOUNT,[MobileRetentionPreviousOrder].[card_exp_year] AS MOBILERETENTIONPREVIOUSORDER_CARD_EXP_YEAR,[MobileRetentionPreviousOrder].[upgrade_existing_contract_sdate] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_EXISTING_CONTRACT_SDATE,[MobileRetentionPreviousOrder].[ord_place_hkid] AS MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_HKID,[MobileRetentionPreviousOrder].[register_address] AS MOBILERETENTIONPREVIOUSORDER_REGISTER_ADDRESS,[MobileRetentionPreviousOrder].[gender] AS MOBILERETENTIONPREVIOUSORDER_GENDER,[MobileRetentionPreviousOrder].[lob_ac] AS MOBILERETENTIONPREVIOUSORDER_LOB_AC,[MobileRetentionPreviousOrder].[sim_mrt_no] AS MOBILERETENTIONPREVIOUSORDER_SIM_MRT_NO,[MobileRetentionPreviousOrder].[redemption_notice_option] AS MOBILERETENTIONPREVIOUSORDER_REDEMPTION_NOTICE_OPTION,[MobileRetentionPreviousOrder].[delivery_collection_type] AS MOBILERETENTIONPREVIOUSORDER_DELIVERY_COLLECTION_TYPE,[MobileRetentionPreviousOrder].[action_date] AS MOBILERETENTIONPREVIOUSORDER_ACTION_DATE,[MobileRetentionPreviousOrder].[third_party_id_type] AS MOBILERETENTIONPREVIOUSORDER_THIRD_PARTY_ID_TYPE,[MobileRetentionPreviousOrder].[org_ftg] AS MOBILERETENTIONPREVIOUSORDER_ORG_FTG,[MobileRetentionPreviousOrder].[upgrade_service_tenure] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_SERVICE_TENURE,[MobileRetentionPreviousOrder].[monthly_payment_type] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_PAYMENT_TYPE,[MobileRetentionPreviousOrder].[contact_no] AS MOBILERETENTIONPREVIOUSORDER_CONTACT_NO,[MobileRetentionPreviousOrder].[org_mrt] AS MOBILERETENTIONPREVIOUSORDER_ORG_MRT,[MobileRetentionPreviousOrder].[sim_item_name] AS MOBILERETENTIONPREVIOUSORDER_SIM_ITEM_NAME,[MobileRetentionPreviousOrder].[pay_method] AS MOBILERETENTIONPREVIOUSORDER_PAY_METHOD,[MobileRetentionPreviousOrder].[hs_model] AS MOBILERETENTIONPREVIOUSORDER_HS_MODEL,[MobileRetentionPreviousOrder].[gift_code] AS MOBILERETENTIONPREVIOUSORDER_GIFT_CODE,[MobileRetentionPreviousOrder].[monthly_bank_account_hkid] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_HKID,[MobileRetentionPreviousOrder].[extra_offer] AS MOBILERETENTIONPREVIOUSORDER_EXTRA_OFFER,[MobileRetentionPreviousOrder].[monthly_bank_account_no] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_NO,[MobileRetentionPreviousOrder].[first_month_license_fee] AS MOBILERETENTIONPREVIOUSORDER_FIRST_MONTH_LICENSE_FEE,[MobileRetentionPreviousOrder].[retrieve_cnt] AS MOBILERETENTIONPREVIOUSORDER_RETRIEVE_CNT,[MobileRetentionPreviousOrder].[ddate] AS MOBILERETENTIONPREVIOUSORDER_DDATE,[MobileRetentionPreviousOrder].[s_premium2] AS MOBILERETENTIONPREVIOUSORDER_S_PREMIUM2,[MobileRetentionPreviousOrder].[monthly_bank_account_id_type] AS MOBILERETENTIONPREVIOUSORDER_MONTHLY_BANK_ACCOUNT_ID_TYPE,[MobileRetentionPreviousOrder].[card_type] AS MOBILERETENTIONPREVIOUSORDER_CARD_TYPE,[MobileRetentionPreviousOrder].[next_bill] AS MOBILERETENTIONPREVIOUSORDER_NEXT_BILL,[MobileRetentionPreviousOrder].[pcd_paid_go_wireless] AS MOBILERETENTIONPREVIOUSORDER_PCD_PAID_GO_WIRELESS,[MobileRetentionPreviousOrder].[upgrade_rebate_calculation] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_REBATE_CALCULATION,[MobileRetentionPreviousOrder].[ext_place_tel] AS MOBILERETENTIONPREVIOUSORDER_EXT_PLACE_TEL,[MobileRetentionPreviousOrder].[m_3rd_hkid] AS MOBILERETENTIONPREVIOUSORDER_M_3RD_HKID,[MobileRetentionPreviousOrder].[retention_type] AS MOBILERETENTIONPREVIOUSORDER_RETENTION_TYPE,[MobileRetentionPreviousOrder].[bill_address_his_id] AS MOBILERETENTIONPREVIOUSORDER_BILL_ADDRESS_HIS_ID,[MobileRetentionPreviousOrder].[aig_gift] AS MOBILERETENTIONPREVIOUSORDER_AIG_GIFT,[MobileRetentionPreviousOrder].[cust_staff_no] AS MOBILERETENTIONPREVIOUSORDER_CUST_STAFF_NO,[MobileRetentionPreviousOrder].[order_id] AS MOBILERETENTIONPREVIOUSORDER_ORDER_ID,[MobileRetentionPreviousOrder].[family_name] AS MOBILERETENTIONPREVIOUSORDER_FAMILY_NAME,[MobileRetentionPreviousOrder].[cdate] AS MOBILERETENTIONPREVIOUSORDER_CDATE,[MobileRetentionPreviousOrder].[status_by_cs_admin] AS MOBILERETENTIONPREVIOUSORDER_STATUS_BY_CS_ADMIN,[MobileRetentionPreviousOrder].[given_name] AS MOBILERETENTIONPREVIOUSORDER_GIVEN_NAME,[MobileRetentionPreviousOrder].[vip_case] AS MOBILERETENTIONPREVIOUSORDER_VIP_CASE,[MobileRetentionPreviousOrder].[s_premium3] AS MOBILERETENTIONPREVIOUSORDER_S_PREMIUM3,[MobileRetentionPreviousOrder].[log_date] AS MOBILERETENTIONPREVIOUSORDER_LOG_DATE,[MobileRetentionPreviousOrder].[extn] AS MOBILERETENTIONPREVIOUSORDER_EXTN,[MobileRetentionPreviousOrder].[d_time] AS MOBILERETENTIONPREVIOUSORDER_D_TIME,[MobileRetentionPreviousOrder].[bank_name] AS MOBILERETENTIONPREVIOUSORDER_BANK_NAME,[MobileRetentionPreviousOrder].[delivery_exchange_option] AS MOBILERETENTIONPREVIOUSORDER_DELIVERY_EXCHANGE_OPTION,[MobileRetentionPreviousOrder].[upgrade_service_account_no] AS MOBILERETENTIONPREVIOUSORDER_UPGRADE_SERVICE_ACCOUNT_NO,[MobileRetentionPreviousOrder].[old_ord_id] AS MOBILERETENTIONPREVIOUSORDER_OLD_ORD_ID,[MobileRetentionPreviousOrder].[m_card_no] AS MOBILERETENTIONPREVIOUSORDER_M_CARD_NO,[MobileRetentionPreviousOrder].[existing_contract_end_date] AS MOBILERETENTIONPREVIOUSORDER_EXISTING_CONTRACT_END_DATE,[MobileRetentionPreviousOrder].[con_eff_date] AS MOBILERETENTIONPREVIOUSORDER_CON_EFF_DATE,[MobileRetentionPreviousOrder].[m_3rd_hkid2] AS MOBILERETENTIONPREVIOUSORDER_M_3RD_HKID2,[MobileRetentionPreviousOrder].[amount] AS MOBILERETENTIONPREVIOUSORDER_AMOUNT,[MobileRetentionPreviousOrder].[m_3rd_id_type] AS MOBILERETENTIONPREVIOUSORDER_M_3RD_ID_TYPE,[MobileRetentionPreviousOrder].[id_type] AS MOBILERETENTIONPREVIOUSORDER_ID_TYPE,[MobileRetentionPreviousOrder].[rate_plan] AS MOBILERETENTIONPREVIOUSORDER_RATE_PLAN,[MobileRetentionPreviousOrder].[channel] AS MOBILERETENTIONPREVIOUSORDER_CHANNEL,[MobileRetentionPreviousOrder].[action_eff_date] AS MOBILERETENTIONPREVIOUSORDER_ACTION_EFF_DATE,[MobileRetentionPreviousOrder].[cooling_date] AS MOBILERETENTIONPREVIOUSORDER_COOLING_DATE,[MobileRetentionPreviousOrder].[free_mon] AS MOBILERETENTIONPREVIOUSORDER_FREE_MON,[MobileRetentionPreviousOrder].[plan_eff_date] AS MOBILERETENTIONPREVIOUSORDER_PLAN_EFF_DATE,[MobileRetentionPreviousOrder].[teamcode] AS MOBILERETENTIONPREVIOUSORDER_TEAMCODE,[MobileRetentionPreviousOrder].[bill_medium] AS MOBILERETENTIONPREVIOUSORDER_BILL_MEDIUM,[MobileRetentionPreviousOrder].[edf_no] AS MOBILERETENTIONPREVIOUSORDER_EDF_NO,[MobileRetentionPreviousOrder].[ord_place_by] AS MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_BY,[MobileRetentionPreviousOrder].[cancel_renew] AS MOBILERETENTIONPREVIOUSORDER_CANCEL_RENEW,[MobileRetentionPreviousOrder].[preferred_languages] AS MOBILERETENTIONPREVIOUSORDER_PREFERRED_LANGUAGES,[MobileRetentionPreviousOrder].[hkid] AS MOBILERETENTIONPREVIOUSORDER_HKID,[MobileRetentionPreviousOrder].[card_holder] AS MOBILERETENTIONPREVIOUSORDER_CARD_HOLDER,[MobileRetentionPreviousOrder].[ac_no] AS MOBILERETENTIONPREVIOUSORDER_AC_NO,[MobileRetentionPreviousOrder].[bill_cut_num] AS MOBILERETENTIONPREVIOUSORDER_BILL_CUT_NUM,[MobileRetentionPreviousOrder].[premium] AS MOBILERETENTIONPREVIOUSORDER_PREMIUM,[MobileRetentionPreviousOrder].[del_remark] AS MOBILERETENTIONPREVIOUSORDER_DEL_REMARK,[MobileRetentionPreviousOrder].[gift_imei2] AS MOBILERETENTIONPREVIOUSORDER_GIFT_IMEI2,[MobileRetentionPreviousOrder].[reasons] AS MOBILERETENTIONPREVIOUSORDER_REASONS,[MobileRetentionPreviousOrder].[language] AS MOBILERETENTIONPREVIOUSORDER_LANGUAGE,[MobileRetentionPreviousOrder].[rebate_amount] AS MOBILERETENTIONPREVIOUSORDER_REBATE_AMOUNT,[MobileRetentionPreviousOrder].[ord_place_id_type] AS MOBILERETENTIONPREVIOUSORDER_ORD_PLACE_ID_TYPE,[MobileRetentionPreviousOrder].[m_3rd_contact_no] AS MOBILERETENTIONPREVIOUSORDER_M_3RD_CONTACT_NO,[MobileRetentionPreviousOrder].[staff_no] AS MOBILERETENTIONPREVIOUSORDER_STAFF_NO,[MobileRetentionPreviousOrder].[sp_d_date] AS MOBILERETENTIONPREVIOUSORDER_SP_D_DATE,[MobileRetentionPreviousOrder].[bundle_name] AS MOBILERETENTIONPREVIOUSORDER_BUNDLE_NAME,[MobileRetentionPreviousOrder].[accessory_waive] AS MOBILERETENTIONPREVIOUSORDER_ACCESSORY_WAIVE,[MobileRetentionPreviousOrder].[sim_item_code] AS MOBILERETENTIONPREVIOUSORDER_SIM_ITEM_CODE,[MobileRetentionPreviousOrder].[cust_type] AS MOBILERETENTIONPREVIOUSORDER_CUST_TYPE,[MobileRetentionPreviousOrder].[card_ref_no] AS MOBILERETENTIONPREVIOUSORDER_CARD_REF_NO  FROM  [MobileRetentionPreviousOrder]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[MobileRetentionPreviousOrder]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionPreviousOrder]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"MobileRetentionPreviousOrder");
                }
                catch {  }
                finally
                {
                    _oConn.Close();
                    _oAdp.Dispose();
                    _oConn.Dispose();
                }
                return _oDset;
            }
        }
        #endregion
        #region Insert
        
        
        /// <summary>
        /// Summary description for management Insert
        /// </summary>
        
        public bool Insert(string x_sGift_imei,string x_sS_premium4,string x_sGift_desc4,string x_sAccessory_desc,string x_sAction_required,global::System.Nullable<long> x_lRegistered_address_his_id,global::System.Nullable<DateTime> x_dVas_eff_date,string x_sMonthly_bank_account_bank_code,string x_sSpecial_handling_dummy_code,string x_sM_card_exp_year,string x_sRemarks2PY,string x_sTrade_field,string x_sOrd_place_tel,string x_sOrd_place_id_type,string x_sCooling_offer,global::System.Nullable<int> x_iRec_no,string x_sUpgrade_handset_offer_rebate_schedule,string x_sChange_payment_type,global::System.Nullable<DateTime> x_dDate_of_birth,string x_sContact_person,string x_sExtra_d_charge,string x_sTl_name,global::System.Nullable<bool> x_bFast_start,string x_sSp_ref_no,global::System.Nullable<DateTime> x_dEdate,string x_sExist_cust_plan,string x_sOrd_place_rel,global::System.Nullable<int> x_iMrt_no,string x_sImei_no,string x_sExisting_smart_phone_model,string x_sGift_code3,string x_sBank_code,string x_sPos_ref_no,global::System.Nullable<DateTime> x_dBill_cut_date,string x_sGift_imei3,string x_sExist_plan,global::System.Nullable<bool> x_bWaive,string x_sProgram,string x_sFirst_month_fee,string x_sR_offer,string x_sCid,string x_sDid,string x_sFtg_tenure,string x_sCon_per,string x_sGift_code4,string x_sEasywatch_type,string x_sSms_mrt,global::System.Nullable<long> x_lTpy_his_id,string x_sMonthly_payment_method,string x_sRemarks2EDF,string x_sGift_desc3,string x_sGift_imei4,global::System.Nullable<int> x_iOld_ord_id,string x_sMonthly_bank_account_hkid2,global::System.Nullable<DateTime> x_dD_date,string x_sGift_desc,string x_sSalesmancode,string x_sPool,global::System.Nullable<long> x_lCn_mrt_no,string x_sAccessory_imei,string x_sThird_party_credit_card,string x_sCard_ref_no,global::System.Nullable<DateTime> x_dCooling_date,string x_sSpecial_approval,global::System.Nullable<DateTime> x_dUpgrade_existing_contract_edate,string x_sAccessory_code,string x_sBill_medium,string x_sS_premium,string x_sRef_staff_no,string x_sAccessory_price,string x_sM_card_exp_month,string x_sInstallment_period,string x_sM_card_type,string x_sEasywatch_ord_id,global::System.Nullable<bool> x_bNormal_rebate,string x_sM_rebate_amount,string x_sM_card_holder2,string x_sBill_medium_email,global::System.Nullable<bool> x_bActive,string x_sS_premium1,string x_sCard_exp_month,string x_sOb_program_id,string x_sSku,string x_sRef_salesmancode,string x_sGo_wireless_package_code,string x_sThird_party_hkid,string x_sUpgrade_existing_pccw_customer,string x_sD_address,string x_sUpgrade_registered_mobile_no,string x_sUpgrade_existing_customer_type,string x_sNormal_rebate_type,string x_sGift_desc2,string x_sMonthly_bank_account_branch_code,string x_sRemarks,string x_sAccept,string x_sDelivery_exchange,string x_sGift_code2,global::System.Nullable<bool> x_bPrepayment_waive,string x_sExisting_smart_phone_imei,global::System.Nullable<long> x_lMnp_his_id,string x_sCust_name,string x_sCust_type,string x_sUpgrade_sponsorships_amount,global::System.Nullable<bool> x_bBill_medium_waive,string x_sDelivery_exchange_location,global::System.Nullable<int> x_iHs_offer_type_id,string x_sOrg_fee,string x_sRebate,string x_sUpgrade_type,string x_sGo_wireless,string x_sExtra_rebate,string x_sPlan_eff,string x_sExtra_rebate_amount,string x_sCard_exp_year,global::System.Nullable<DateTime> x_dUpgrade_existing_contract_sdate,string x_sOrd_place_hkid,string x_sRegister_address,string x_sGender,string x_sLob_ac,global::System.Nullable<int> x_iSim_mrt_no,string x_sRedemption_notice_option,string x_sDelivery_collection_type,global::System.Nullable<DateTime> x_dAction_date,string x_sThird_party_id_type,string x_sOrg_ftg,string x_sUpgrade_service_tenure,string x_sMonthly_payment_type,string x_sContact_no,global::System.Nullable<int> x_iOrg_mrt,string x_sSim_item_name,string x_sPay_method,string x_sHs_model,string x_sGift_code,string x_sMonthly_bank_account_hkid,string x_sExtra_offer,string x_sMonthly_bank_account_no,string x_sFirst_month_license_fee,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dDdate,string x_sS_premium2,string x_sMonthly_bank_account_id_type,string x_sCard_type,global::System.Nullable<bool> x_bNext_bill,global::System.Nullable<bool> x_bPcd_paid_go_wireless,string x_sUpgrade_rebate_calculation,string x_sExt_place_tel,string x_sM_3rd_hkid,string x_sRetention_type,global::System.Nullable<long> x_lBill_address_his_id,string x_sAig_gift,string x_sCust_staff_no,string x_sFamily_name,global::System.Nullable<DateTime> x_dCdate,string x_sStatus_by_cs_admin,string x_sSim_item_number,string x_sVip_case,string x_sGiven_name,global::System.Nullable<DateTime> x_dLog_date,string x_sExtn,string x_sD_time,string x_sBank_name,string x_sDelivery_exchange_option,string x_sUpgrade_service_account_no,string x_sAction_of_rate_plan_effective,string x_sM_card_no,string x_sExisting_contract_end_date,global::System.Nullable<DateTime> x_dCon_eff_date,string x_sM_3rd_hkid2,string x_sAmount,string x_sId_type,string x_sRate_plan,string x_sChannel,global::System.Nullable<DateTime> x_dAction_eff_date,string x_sIssue_type,string x_sFree_mon,global::System.Nullable<DateTime> x_dPlan_eff_date,string x_sDel_remark,string x_sTeamcode,string x_sStaff_name,string x_sEdf_no,string x_sOrd_place_by,string x_sCancel_renew,string x_sPreferred_languages,string x_sHkid,string x_sCard_no,string x_sAc_no,global::System.Nullable<int> x_iBill_cut_num,string x_sPremium,string x_sM_3rd_id_type,string x_sGift_imei2,string x_sReasons,string x_sLanguage,string x_sRebate_amount,string x_sLob,string x_sM_3rd_contact_no,string x_sStaff_no,string x_sS_premium3,global::System.Nullable<DateTime> x_dSp_d_date,string x_sBundle_name,global::System.Nullable<bool> x_bAccessory_waive,string x_sSim_item_code,string x_sMonthly_bank_account_holder,string x_sCard_holder)
        {
            MobileRetentionPreviousOrder _oMobileRetentionPreviousOrder=MobileRetentionPreviousOrderRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oMobileRetentionPreviousOrder.gift_imei=x_sGift_imei;
            _oMobileRetentionPreviousOrder.s_premium4=x_sS_premium4;
            _oMobileRetentionPreviousOrder.gift_desc4=x_sGift_desc4;
            _oMobileRetentionPreviousOrder.accessory_desc=x_sAccessory_desc;
            _oMobileRetentionPreviousOrder.action_required=x_sAction_required;
            _oMobileRetentionPreviousOrder.registered_address_his_id=x_lRegistered_address_his_id;
            _oMobileRetentionPreviousOrder.vas_eff_date=x_dVas_eff_date;
            _oMobileRetentionPreviousOrder.monthly_bank_account_bank_code=x_sMonthly_bank_account_bank_code;
            _oMobileRetentionPreviousOrder.special_handling_dummy_code=x_sSpecial_handling_dummy_code;
            _oMobileRetentionPreviousOrder.m_card_exp_year=x_sM_card_exp_year;
            _oMobileRetentionPreviousOrder.remarks2PY=x_sRemarks2PY;
            _oMobileRetentionPreviousOrder.trade_field=x_sTrade_field;
            _oMobileRetentionPreviousOrder.ord_place_tel=x_sOrd_place_tel;
            _oMobileRetentionPreviousOrder.ord_place_id_type=x_sOrd_place_id_type;
            _oMobileRetentionPreviousOrder.cooling_offer=x_sCooling_offer;
            _oMobileRetentionPreviousOrder.rec_no=x_iRec_no;
            _oMobileRetentionPreviousOrder.upgrade_handset_offer_rebate_schedule=x_sUpgrade_handset_offer_rebate_schedule;
            _oMobileRetentionPreviousOrder.change_payment_type=x_sChange_payment_type;
            _oMobileRetentionPreviousOrder.date_of_birth=x_dDate_of_birth;
            _oMobileRetentionPreviousOrder.contact_person=x_sContact_person;
            _oMobileRetentionPreviousOrder.extra_d_charge=x_sExtra_d_charge;
            _oMobileRetentionPreviousOrder.tl_name=x_sTl_name;
            _oMobileRetentionPreviousOrder.fast_start=x_bFast_start;
            _oMobileRetentionPreviousOrder.sp_ref_no=x_sSp_ref_no;
            _oMobileRetentionPreviousOrder.edate=x_dEdate;
            _oMobileRetentionPreviousOrder.exist_cust_plan=x_sExist_cust_plan;
            _oMobileRetentionPreviousOrder.ord_place_rel=x_sOrd_place_rel;
            _oMobileRetentionPreviousOrder.mrt_no=x_iMrt_no;
            _oMobileRetentionPreviousOrder.imei_no=x_sImei_no;
            _oMobileRetentionPreviousOrder.existing_smart_phone_model=x_sExisting_smart_phone_model;
            _oMobileRetentionPreviousOrder.gift_code3=x_sGift_code3;
            _oMobileRetentionPreviousOrder.bank_code=x_sBank_code;
            _oMobileRetentionPreviousOrder.pos_ref_no=x_sPos_ref_no;
            _oMobileRetentionPreviousOrder.bill_cut_date=x_dBill_cut_date;
            _oMobileRetentionPreviousOrder.gift_imei3=x_sGift_imei3;
            _oMobileRetentionPreviousOrder.exist_plan=x_sExist_plan;
            _oMobileRetentionPreviousOrder.waive=x_bWaive;
            _oMobileRetentionPreviousOrder.program=x_sProgram;
            _oMobileRetentionPreviousOrder.first_month_fee=x_sFirst_month_fee;
            _oMobileRetentionPreviousOrder.r_offer=x_sR_offer;
            _oMobileRetentionPreviousOrder.cid=x_sCid;
            _oMobileRetentionPreviousOrder.did=x_sDid;
            _oMobileRetentionPreviousOrder.ftg_tenure=x_sFtg_tenure;
            _oMobileRetentionPreviousOrder.con_per=x_sCon_per;
            _oMobileRetentionPreviousOrder.gift_code4=x_sGift_code4;
            _oMobileRetentionPreviousOrder.easywatch_type=x_sEasywatch_type;
            _oMobileRetentionPreviousOrder.sms_mrt=x_sSms_mrt;
            _oMobileRetentionPreviousOrder.tpy_his_id=x_lTpy_his_id;
            _oMobileRetentionPreviousOrder.monthly_payment_method=x_sMonthly_payment_method;
            _oMobileRetentionPreviousOrder.remarks2EDF=x_sRemarks2EDF;
            _oMobileRetentionPreviousOrder.gift_desc3=x_sGift_desc3;
            _oMobileRetentionPreviousOrder.gift_imei4=x_sGift_imei4;
            _oMobileRetentionPreviousOrder.old_ord_id=x_iOld_ord_id;
            _oMobileRetentionPreviousOrder.monthly_bank_account_hkid2=x_sMonthly_bank_account_hkid2;
            _oMobileRetentionPreviousOrder.d_date=x_dD_date;
            _oMobileRetentionPreviousOrder.gift_desc=x_sGift_desc;
            _oMobileRetentionPreviousOrder.salesmancode=x_sSalesmancode;
            _oMobileRetentionPreviousOrder.pool=x_sPool;
            _oMobileRetentionPreviousOrder.cn_mrt_no=x_lCn_mrt_no;
            _oMobileRetentionPreviousOrder.accessory_imei=x_sAccessory_imei;
            _oMobileRetentionPreviousOrder.third_party_credit_card=x_sThird_party_credit_card;
            _oMobileRetentionPreviousOrder.card_ref_no=x_sCard_ref_no;
            _oMobileRetentionPreviousOrder.cooling_date=x_dCooling_date;
            _oMobileRetentionPreviousOrder.special_approval=x_sSpecial_approval;
            _oMobileRetentionPreviousOrder.upgrade_existing_contract_edate=x_dUpgrade_existing_contract_edate;
            _oMobileRetentionPreviousOrder.accessory_code=x_sAccessory_code;
            _oMobileRetentionPreviousOrder.bill_medium=x_sBill_medium;
            _oMobileRetentionPreviousOrder.s_premium=x_sS_premium;
            _oMobileRetentionPreviousOrder.ref_staff_no=x_sRef_staff_no;
            _oMobileRetentionPreviousOrder.accessory_price=x_sAccessory_price;
            _oMobileRetentionPreviousOrder.m_card_exp_month=x_sM_card_exp_month;
            _oMobileRetentionPreviousOrder.installment_period=x_sInstallment_period;
            _oMobileRetentionPreviousOrder.m_card_type=x_sM_card_type;
            _oMobileRetentionPreviousOrder.easywatch_ord_id=x_sEasywatch_ord_id;
            _oMobileRetentionPreviousOrder.normal_rebate=x_bNormal_rebate;
            _oMobileRetentionPreviousOrder.m_rebate_amount=x_sM_rebate_amount;
            _oMobileRetentionPreviousOrder.m_card_holder2=x_sM_card_holder2;
            _oMobileRetentionPreviousOrder.bill_medium_email=x_sBill_medium_email;
            _oMobileRetentionPreviousOrder.active=x_bActive;
            _oMobileRetentionPreviousOrder.s_premium1=x_sS_premium1;
            _oMobileRetentionPreviousOrder.card_exp_month=x_sCard_exp_month;
            _oMobileRetentionPreviousOrder.ob_program_id=x_sOb_program_id;
            _oMobileRetentionPreviousOrder.sku=x_sSku;
            _oMobileRetentionPreviousOrder.ref_salesmancode=x_sRef_salesmancode;
            _oMobileRetentionPreviousOrder.go_wireless_package_code=x_sGo_wireless_package_code;
            _oMobileRetentionPreviousOrder.third_party_hkid=x_sThird_party_hkid;
            _oMobileRetentionPreviousOrder.upgrade_existing_pccw_customer=x_sUpgrade_existing_pccw_customer;
            _oMobileRetentionPreviousOrder.d_address=x_sD_address;
            _oMobileRetentionPreviousOrder.upgrade_registered_mobile_no=x_sUpgrade_registered_mobile_no;
            _oMobileRetentionPreviousOrder.upgrade_existing_customer_type=x_sUpgrade_existing_customer_type;
            _oMobileRetentionPreviousOrder.normal_rebate_type=x_sNormal_rebate_type;
            _oMobileRetentionPreviousOrder.gift_desc2=x_sGift_desc2;
            _oMobileRetentionPreviousOrder.monthly_bank_account_branch_code=x_sMonthly_bank_account_branch_code;
            _oMobileRetentionPreviousOrder.remarks=x_sRemarks;
            _oMobileRetentionPreviousOrder.accept=x_sAccept;
            _oMobileRetentionPreviousOrder.delivery_exchange=x_sDelivery_exchange;
            _oMobileRetentionPreviousOrder.gift_code2=x_sGift_code2;
            _oMobileRetentionPreviousOrder.prepayment_waive=x_bPrepayment_waive;
            _oMobileRetentionPreviousOrder.existing_smart_phone_imei=x_sExisting_smart_phone_imei;
            _oMobileRetentionPreviousOrder.mnp_his_id=x_lMnp_his_id;
            _oMobileRetentionPreviousOrder.cust_name=x_sCust_name;
            _oMobileRetentionPreviousOrder.cust_type=x_sCust_type;
            _oMobileRetentionPreviousOrder.upgrade_sponsorships_amount=x_sUpgrade_sponsorships_amount;
            _oMobileRetentionPreviousOrder.bill_medium_waive=x_bBill_medium_waive;
            _oMobileRetentionPreviousOrder.delivery_exchange_location=x_sDelivery_exchange_location;
            _oMobileRetentionPreviousOrder.hs_offer_type_id=x_iHs_offer_type_id;
            _oMobileRetentionPreviousOrder.org_fee=x_sOrg_fee;
            _oMobileRetentionPreviousOrder.rebate=x_sRebate;
            _oMobileRetentionPreviousOrder.upgrade_type=x_sUpgrade_type;
            _oMobileRetentionPreviousOrder.go_wireless=x_sGo_wireless;
            _oMobileRetentionPreviousOrder.extra_rebate=x_sExtra_rebate;
            _oMobileRetentionPreviousOrder.plan_eff=x_sPlan_eff;
            _oMobileRetentionPreviousOrder.extra_rebate_amount=x_sExtra_rebate_amount;
            _oMobileRetentionPreviousOrder.card_exp_year=x_sCard_exp_year;
            _oMobileRetentionPreviousOrder.upgrade_existing_contract_sdate=x_dUpgrade_existing_contract_sdate;
            _oMobileRetentionPreviousOrder.ord_place_hkid=x_sOrd_place_hkid;
            _oMobileRetentionPreviousOrder.register_address=x_sRegister_address;
            _oMobileRetentionPreviousOrder.gender=x_sGender;
            _oMobileRetentionPreviousOrder.lob_ac=x_sLob_ac;
            _oMobileRetentionPreviousOrder.sim_mrt_no=x_iSim_mrt_no;
            _oMobileRetentionPreviousOrder.redemption_notice_option=x_sRedemption_notice_option;
            _oMobileRetentionPreviousOrder.delivery_collection_type=x_sDelivery_collection_type;
            _oMobileRetentionPreviousOrder.action_date=x_dAction_date;
            _oMobileRetentionPreviousOrder.third_party_id_type=x_sThird_party_id_type;
            _oMobileRetentionPreviousOrder.org_ftg=x_sOrg_ftg;
            _oMobileRetentionPreviousOrder.upgrade_service_tenure=x_sUpgrade_service_tenure;
            _oMobileRetentionPreviousOrder.monthly_payment_type=x_sMonthly_payment_type;
            _oMobileRetentionPreviousOrder.contact_no=x_sContact_no;
            _oMobileRetentionPreviousOrder.org_mrt=x_iOrg_mrt;
            _oMobileRetentionPreviousOrder.sim_item_name=x_sSim_item_name;
            _oMobileRetentionPreviousOrder.pay_method=x_sPay_method;
            _oMobileRetentionPreviousOrder.hs_model=x_sHs_model;
            _oMobileRetentionPreviousOrder.gift_code=x_sGift_code;
            _oMobileRetentionPreviousOrder.monthly_bank_account_hkid=x_sMonthly_bank_account_hkid;
            _oMobileRetentionPreviousOrder.extra_offer=x_sExtra_offer;
            _oMobileRetentionPreviousOrder.monthly_bank_account_no=x_sMonthly_bank_account_no;
            _oMobileRetentionPreviousOrder.first_month_license_fee=x_sFirst_month_license_fee;
            _oMobileRetentionPreviousOrder.retrieve_cnt=x_iRetrieve_cnt;
            _oMobileRetentionPreviousOrder.ddate=x_dDdate;
            _oMobileRetentionPreviousOrder.s_premium2=x_sS_premium2;
            _oMobileRetentionPreviousOrder.monthly_bank_account_id_type=x_sMonthly_bank_account_id_type;
            _oMobileRetentionPreviousOrder.card_type=x_sCard_type;
            _oMobileRetentionPreviousOrder.next_bill=x_bNext_bill;
            _oMobileRetentionPreviousOrder.pcd_paid_go_wireless=x_bPcd_paid_go_wireless;
            _oMobileRetentionPreviousOrder.upgrade_rebate_calculation=x_sUpgrade_rebate_calculation;
            _oMobileRetentionPreviousOrder.ext_place_tel=x_sExt_place_tel;
            _oMobileRetentionPreviousOrder.m_3rd_hkid=x_sM_3rd_hkid;
            _oMobileRetentionPreviousOrder.retention_type=x_sRetention_type;
            _oMobileRetentionPreviousOrder.bill_address_his_id=x_lBill_address_his_id;
            _oMobileRetentionPreviousOrder.aig_gift=x_sAig_gift;
            _oMobileRetentionPreviousOrder.cust_staff_no=x_sCust_staff_no;
            _oMobileRetentionPreviousOrder.family_name=x_sFamily_name;
            _oMobileRetentionPreviousOrder.cdate=x_dCdate;
            _oMobileRetentionPreviousOrder.status_by_cs_admin=x_sStatus_by_cs_admin;
            _oMobileRetentionPreviousOrder.sim_item_number=x_sSim_item_number;
            _oMobileRetentionPreviousOrder.vip_case=x_sVip_case;
            _oMobileRetentionPreviousOrder.given_name=x_sGiven_name;
            _oMobileRetentionPreviousOrder.log_date=x_dLog_date;
            _oMobileRetentionPreviousOrder.extn=x_sExtn;
            _oMobileRetentionPreviousOrder.d_time=x_sD_time;
            _oMobileRetentionPreviousOrder.bank_name=x_sBank_name;
            _oMobileRetentionPreviousOrder.delivery_exchange_option=x_sDelivery_exchange_option;
            _oMobileRetentionPreviousOrder.upgrade_service_account_no=x_sUpgrade_service_account_no;
            _oMobileRetentionPreviousOrder.action_of_rate_plan_effective=x_sAction_of_rate_plan_effective;
            _oMobileRetentionPreviousOrder.m_card_no=x_sM_card_no;
            _oMobileRetentionPreviousOrder.existing_contract_end_date=x_sExisting_contract_end_date;
            _oMobileRetentionPreviousOrder.con_eff_date=x_dCon_eff_date;
            _oMobileRetentionPreviousOrder.m_3rd_hkid2=x_sM_3rd_hkid2;
            _oMobileRetentionPreviousOrder.amount=x_sAmount;
            _oMobileRetentionPreviousOrder.id_type=x_sId_type;
            _oMobileRetentionPreviousOrder.rate_plan=x_sRate_plan;
            _oMobileRetentionPreviousOrder.channel=x_sChannel;
            _oMobileRetentionPreviousOrder.action_eff_date=x_dAction_eff_date;
            _oMobileRetentionPreviousOrder.issue_type=x_sIssue_type;
            _oMobileRetentionPreviousOrder.free_mon=x_sFree_mon;
            _oMobileRetentionPreviousOrder.plan_eff_date=x_dPlan_eff_date;
            _oMobileRetentionPreviousOrder.del_remark=x_sDel_remark;
            _oMobileRetentionPreviousOrder.teamcode=x_sTeamcode;
            _oMobileRetentionPreviousOrder.staff_name=x_sStaff_name;
            _oMobileRetentionPreviousOrder.edf_no=x_sEdf_no;
            _oMobileRetentionPreviousOrder.ord_place_by=x_sOrd_place_by;
            _oMobileRetentionPreviousOrder.cancel_renew=x_sCancel_renew;
            _oMobileRetentionPreviousOrder.preferred_languages=x_sPreferred_languages;
            _oMobileRetentionPreviousOrder.hkid=x_sHkid;
            _oMobileRetentionPreviousOrder.card_no=x_sCard_no;
            _oMobileRetentionPreviousOrder.ac_no=x_sAc_no;
            _oMobileRetentionPreviousOrder.bill_cut_num=x_iBill_cut_num;
            _oMobileRetentionPreviousOrder.premium=x_sPremium;
            _oMobileRetentionPreviousOrder.m_3rd_id_type=x_sM_3rd_id_type;
            _oMobileRetentionPreviousOrder.gift_imei2=x_sGift_imei2;
            _oMobileRetentionPreviousOrder.reasons=x_sReasons;
            _oMobileRetentionPreviousOrder.language=x_sLanguage;
            _oMobileRetentionPreviousOrder.rebate_amount=x_sRebate_amount;
            _oMobileRetentionPreviousOrder.lob=x_sLob;
            _oMobileRetentionPreviousOrder.m_3rd_contact_no=x_sM_3rd_contact_no;
            _oMobileRetentionPreviousOrder.staff_no=x_sStaff_no;
            _oMobileRetentionPreviousOrder.s_premium3=x_sS_premium3;
            _oMobileRetentionPreviousOrder.sp_d_date=x_dSp_d_date;
            _oMobileRetentionPreviousOrder.bundle_name=x_sBundle_name;
            _oMobileRetentionPreviousOrder.accessory_waive=x_bAccessory_waive;
            _oMobileRetentionPreviousOrder.sim_item_code=x_sSim_item_code;
            _oMobileRetentionPreviousOrder.monthly_bank_account_holder=x_sMonthly_bank_account_holder;
            _oMobileRetentionPreviousOrder.card_holder=x_sCard_holder;
            return InsertWithOutLastID(n_oDB, _oMobileRetentionPreviousOrder);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sGift_imei,string x_sS_premium4,string x_sGift_desc4,string x_sAccessory_desc,string x_sAction_required,global::System.Nullable<long> x_lRegistered_address_his_id,global::System.Nullable<DateTime> x_dVas_eff_date,string x_sMonthly_bank_account_bank_code,string x_sSpecial_handling_dummy_code,string x_sM_card_exp_year,string x_sRemarks2PY,string x_sTrade_field,string x_sOrd_place_tel,string x_sOrd_place_id_type,string x_sCooling_offer,global::System.Nullable<int> x_iRec_no,string x_sUpgrade_handset_offer_rebate_schedule,string x_sChange_payment_type,global::System.Nullable<DateTime> x_dDate_of_birth,string x_sContact_person,string x_sExtra_d_charge,string x_sTl_name,global::System.Nullable<bool> x_bFast_start,string x_sSp_ref_no,global::System.Nullable<DateTime> x_dEdate,string x_sExist_cust_plan,string x_sOrd_place_rel,global::System.Nullable<int> x_iMrt_no,string x_sImei_no,string x_sExisting_smart_phone_model,string x_sGift_code3,string x_sBank_code,string x_sPos_ref_no,global::System.Nullable<DateTime> x_dBill_cut_date,string x_sGift_imei3,string x_sExist_plan,global::System.Nullable<bool> x_bWaive,string x_sProgram,string x_sFirst_month_fee,string x_sR_offer,string x_sCid,string x_sDid,string x_sFtg_tenure,string x_sCon_per,string x_sGift_code4,string x_sEasywatch_type,string x_sSms_mrt,global::System.Nullable<long> x_lTpy_his_id,string x_sMonthly_payment_method,string x_sRemarks2EDF,string x_sGift_desc3,string x_sGift_imei4,global::System.Nullable<int> x_iOld_ord_id,string x_sMonthly_bank_account_hkid2,global::System.Nullable<DateTime> x_dD_date,string x_sGift_desc,string x_sSalesmancode,string x_sPool,global::System.Nullable<long> x_lCn_mrt_no,string x_sAccessory_imei,string x_sThird_party_credit_card,string x_sCard_ref_no,global::System.Nullable<DateTime> x_dCooling_date,string x_sSpecial_approval,global::System.Nullable<DateTime> x_dUpgrade_existing_contract_edate,string x_sAccessory_code,string x_sBill_medium,string x_sS_premium,string x_sRef_staff_no,string x_sAccessory_price,string x_sM_card_exp_month,string x_sInstallment_period,string x_sM_card_type,string x_sEasywatch_ord_id,global::System.Nullable<bool> x_bNormal_rebate,string x_sM_rebate_amount,string x_sM_card_holder2,string x_sBill_medium_email,global::System.Nullable<bool> x_bActive,string x_sS_premium1,string x_sCard_exp_month,string x_sOb_program_id,string x_sSku,string x_sRef_salesmancode,string x_sGo_wireless_package_code,string x_sThird_party_hkid,string x_sUpgrade_existing_pccw_customer,string x_sD_address,string x_sUpgrade_registered_mobile_no,string x_sUpgrade_existing_customer_type,string x_sNormal_rebate_type,string x_sGift_desc2,string x_sMonthly_bank_account_branch_code,string x_sRemarks,string x_sAccept,string x_sDelivery_exchange,string x_sGift_code2,global::System.Nullable<bool> x_bPrepayment_waive,string x_sExisting_smart_phone_imei,global::System.Nullable<long> x_lMnp_his_id,string x_sCust_name,string x_sCust_type,string x_sUpgrade_sponsorships_amount,global::System.Nullable<bool> x_bBill_medium_waive,string x_sDelivery_exchange_location,global::System.Nullable<int> x_iHs_offer_type_id,string x_sOrg_fee,string x_sRebate,string x_sUpgrade_type,string x_sGo_wireless,string x_sExtra_rebate,string x_sPlan_eff,string x_sExtra_rebate_amount,string x_sCard_exp_year,global::System.Nullable<DateTime> x_dUpgrade_existing_contract_sdate,string x_sOrd_place_hkid,string x_sRegister_address,string x_sGender,string x_sLob_ac,global::System.Nullable<int> x_iSim_mrt_no,string x_sRedemption_notice_option,string x_sDelivery_collection_type,global::System.Nullable<DateTime> x_dAction_date,string x_sThird_party_id_type,string x_sOrg_ftg,string x_sUpgrade_service_tenure,string x_sMonthly_payment_type,string x_sContact_no,global::System.Nullable<int> x_iOrg_mrt,string x_sSim_item_name,string x_sPay_method,string x_sHs_model,string x_sGift_code,string x_sMonthly_bank_account_hkid,string x_sExtra_offer,string x_sMonthly_bank_account_no,string x_sFirst_month_license_fee,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dDdate,string x_sS_premium2,string x_sMonthly_bank_account_id_type,string x_sCard_type,global::System.Nullable<bool> x_bNext_bill,global::System.Nullable<bool> x_bPcd_paid_go_wireless,string x_sUpgrade_rebate_calculation,string x_sExt_place_tel,string x_sM_3rd_hkid,string x_sRetention_type,global::System.Nullable<long> x_lBill_address_his_id,string x_sAig_gift,string x_sCust_staff_no,string x_sFamily_name,global::System.Nullable<DateTime> x_dCdate,string x_sStatus_by_cs_admin,string x_sSim_item_number,string x_sVip_case,string x_sGiven_name,global::System.Nullable<DateTime> x_dLog_date,string x_sExtn,string x_sD_time,string x_sBank_name,string x_sDelivery_exchange_option,string x_sUpgrade_service_account_no,string x_sAction_of_rate_plan_effective,string x_sM_card_no,string x_sExisting_contract_end_date,global::System.Nullable<DateTime> x_dCon_eff_date,string x_sM_3rd_hkid2,string x_sAmount,string x_sId_type,string x_sRate_plan,string x_sChannel,global::System.Nullable<DateTime> x_dAction_eff_date,string x_sIssue_type,string x_sFree_mon,global::System.Nullable<DateTime> x_dPlan_eff_date,string x_sDel_remark,string x_sTeamcode,string x_sStaff_name,string x_sEdf_no,string x_sOrd_place_by,string x_sCancel_renew,string x_sPreferred_languages,string x_sHkid,string x_sCard_no,string x_sAc_no,global::System.Nullable<int> x_iBill_cut_num,string x_sPremium,string x_sM_3rd_id_type,string x_sGift_imei2,string x_sReasons,string x_sLanguage,string x_sRebate_amount,string x_sLob,string x_sM_3rd_contact_no,string x_sStaff_no,string x_sS_premium3,global::System.Nullable<DateTime> x_dSp_d_date,string x_sBundle_name,global::System.Nullable<bool> x_bAccessory_waive,string x_sSim_item_code,string x_sMonthly_bank_account_holder,string x_sCard_holder)
        {
            MobileRetentionPreviousOrder _oMobileRetentionPreviousOrder=MobileRetentionPreviousOrderRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileRetentionPreviousOrder.gift_imei=x_sGift_imei;
            _oMobileRetentionPreviousOrder.s_premium4=x_sS_premium4;
            _oMobileRetentionPreviousOrder.gift_desc4=x_sGift_desc4;
            _oMobileRetentionPreviousOrder.accessory_desc=x_sAccessory_desc;
            _oMobileRetentionPreviousOrder.action_required=x_sAction_required;
            _oMobileRetentionPreviousOrder.registered_address_his_id=x_lRegistered_address_his_id;
            _oMobileRetentionPreviousOrder.vas_eff_date=x_dVas_eff_date;
            _oMobileRetentionPreviousOrder.monthly_bank_account_bank_code=x_sMonthly_bank_account_bank_code;
            _oMobileRetentionPreviousOrder.special_handling_dummy_code=x_sSpecial_handling_dummy_code;
            _oMobileRetentionPreviousOrder.m_card_exp_year=x_sM_card_exp_year;
            _oMobileRetentionPreviousOrder.remarks2PY=x_sRemarks2PY;
            _oMobileRetentionPreviousOrder.trade_field=x_sTrade_field;
            _oMobileRetentionPreviousOrder.ord_place_tel=x_sOrd_place_tel;
            _oMobileRetentionPreviousOrder.ord_place_id_type=x_sOrd_place_id_type;
            _oMobileRetentionPreviousOrder.cooling_offer=x_sCooling_offer;
            _oMobileRetentionPreviousOrder.rec_no=x_iRec_no;
            _oMobileRetentionPreviousOrder.upgrade_handset_offer_rebate_schedule=x_sUpgrade_handset_offer_rebate_schedule;
            _oMobileRetentionPreviousOrder.change_payment_type=x_sChange_payment_type;
            _oMobileRetentionPreviousOrder.date_of_birth=x_dDate_of_birth;
            _oMobileRetentionPreviousOrder.contact_person=x_sContact_person;
            _oMobileRetentionPreviousOrder.extra_d_charge=x_sExtra_d_charge;
            _oMobileRetentionPreviousOrder.tl_name=x_sTl_name;
            _oMobileRetentionPreviousOrder.fast_start=x_bFast_start;
            _oMobileRetentionPreviousOrder.sp_ref_no=x_sSp_ref_no;
            _oMobileRetentionPreviousOrder.edate=x_dEdate;
            _oMobileRetentionPreviousOrder.exist_cust_plan=x_sExist_cust_plan;
            _oMobileRetentionPreviousOrder.ord_place_rel=x_sOrd_place_rel;
            _oMobileRetentionPreviousOrder.mrt_no=x_iMrt_no;
            _oMobileRetentionPreviousOrder.imei_no=x_sImei_no;
            _oMobileRetentionPreviousOrder.existing_smart_phone_model=x_sExisting_smart_phone_model;
            _oMobileRetentionPreviousOrder.gift_code3=x_sGift_code3;
            _oMobileRetentionPreviousOrder.bank_code=x_sBank_code;
            _oMobileRetentionPreviousOrder.pos_ref_no=x_sPos_ref_no;
            _oMobileRetentionPreviousOrder.bill_cut_date=x_dBill_cut_date;
            _oMobileRetentionPreviousOrder.gift_imei3=x_sGift_imei3;
            _oMobileRetentionPreviousOrder.exist_plan=x_sExist_plan;
            _oMobileRetentionPreviousOrder.waive=x_bWaive;
            _oMobileRetentionPreviousOrder.program=x_sProgram;
            _oMobileRetentionPreviousOrder.first_month_fee=x_sFirst_month_fee;
            _oMobileRetentionPreviousOrder.r_offer=x_sR_offer;
            _oMobileRetentionPreviousOrder.cid=x_sCid;
            _oMobileRetentionPreviousOrder.did=x_sDid;
            _oMobileRetentionPreviousOrder.ftg_tenure=x_sFtg_tenure;
            _oMobileRetentionPreviousOrder.con_per=x_sCon_per;
            _oMobileRetentionPreviousOrder.gift_code4=x_sGift_code4;
            _oMobileRetentionPreviousOrder.easywatch_type=x_sEasywatch_type;
            _oMobileRetentionPreviousOrder.sms_mrt=x_sSms_mrt;
            _oMobileRetentionPreviousOrder.tpy_his_id=x_lTpy_his_id;
            _oMobileRetentionPreviousOrder.monthly_payment_method=x_sMonthly_payment_method;
            _oMobileRetentionPreviousOrder.remarks2EDF=x_sRemarks2EDF;
            _oMobileRetentionPreviousOrder.gift_desc3=x_sGift_desc3;
            _oMobileRetentionPreviousOrder.gift_imei4=x_sGift_imei4;
            _oMobileRetentionPreviousOrder.old_ord_id=x_iOld_ord_id;
            _oMobileRetentionPreviousOrder.monthly_bank_account_hkid2=x_sMonthly_bank_account_hkid2;
            _oMobileRetentionPreviousOrder.d_date=x_dD_date;
            _oMobileRetentionPreviousOrder.gift_desc=x_sGift_desc;
            _oMobileRetentionPreviousOrder.salesmancode=x_sSalesmancode;
            _oMobileRetentionPreviousOrder.pool=x_sPool;
            _oMobileRetentionPreviousOrder.cn_mrt_no=x_lCn_mrt_no;
            _oMobileRetentionPreviousOrder.accessory_imei=x_sAccessory_imei;
            _oMobileRetentionPreviousOrder.third_party_credit_card=x_sThird_party_credit_card;
            _oMobileRetentionPreviousOrder.card_ref_no=x_sCard_ref_no;
            _oMobileRetentionPreviousOrder.cooling_date=x_dCooling_date;
            _oMobileRetentionPreviousOrder.special_approval=x_sSpecial_approval;
            _oMobileRetentionPreviousOrder.upgrade_existing_contract_edate=x_dUpgrade_existing_contract_edate;
            _oMobileRetentionPreviousOrder.accessory_code=x_sAccessory_code;
            _oMobileRetentionPreviousOrder.bill_medium=x_sBill_medium;
            _oMobileRetentionPreviousOrder.s_premium=x_sS_premium;
            _oMobileRetentionPreviousOrder.ref_staff_no=x_sRef_staff_no;
            _oMobileRetentionPreviousOrder.accessory_price=x_sAccessory_price;
            _oMobileRetentionPreviousOrder.m_card_exp_month=x_sM_card_exp_month;
            _oMobileRetentionPreviousOrder.installment_period=x_sInstallment_period;
            _oMobileRetentionPreviousOrder.m_card_type=x_sM_card_type;
            _oMobileRetentionPreviousOrder.easywatch_ord_id=x_sEasywatch_ord_id;
            _oMobileRetentionPreviousOrder.normal_rebate=x_bNormal_rebate;
            _oMobileRetentionPreviousOrder.m_rebate_amount=x_sM_rebate_amount;
            _oMobileRetentionPreviousOrder.m_card_holder2=x_sM_card_holder2;
            _oMobileRetentionPreviousOrder.bill_medium_email=x_sBill_medium_email;
            _oMobileRetentionPreviousOrder.active=x_bActive;
            _oMobileRetentionPreviousOrder.s_premium1=x_sS_premium1;
            _oMobileRetentionPreviousOrder.card_exp_month=x_sCard_exp_month;
            _oMobileRetentionPreviousOrder.ob_program_id=x_sOb_program_id;
            _oMobileRetentionPreviousOrder.sku=x_sSku;
            _oMobileRetentionPreviousOrder.ref_salesmancode=x_sRef_salesmancode;
            _oMobileRetentionPreviousOrder.go_wireless_package_code=x_sGo_wireless_package_code;
            _oMobileRetentionPreviousOrder.third_party_hkid=x_sThird_party_hkid;
            _oMobileRetentionPreviousOrder.upgrade_existing_pccw_customer=x_sUpgrade_existing_pccw_customer;
            _oMobileRetentionPreviousOrder.d_address=x_sD_address;
            _oMobileRetentionPreviousOrder.upgrade_registered_mobile_no=x_sUpgrade_registered_mobile_no;
            _oMobileRetentionPreviousOrder.upgrade_existing_customer_type=x_sUpgrade_existing_customer_type;
            _oMobileRetentionPreviousOrder.normal_rebate_type=x_sNormal_rebate_type;
            _oMobileRetentionPreviousOrder.gift_desc2=x_sGift_desc2;
            _oMobileRetentionPreviousOrder.monthly_bank_account_branch_code=x_sMonthly_bank_account_branch_code;
            _oMobileRetentionPreviousOrder.remarks=x_sRemarks;
            _oMobileRetentionPreviousOrder.accept=x_sAccept;
            _oMobileRetentionPreviousOrder.delivery_exchange=x_sDelivery_exchange;
            _oMobileRetentionPreviousOrder.gift_code2=x_sGift_code2;
            _oMobileRetentionPreviousOrder.prepayment_waive=x_bPrepayment_waive;
            _oMobileRetentionPreviousOrder.existing_smart_phone_imei=x_sExisting_smart_phone_imei;
            _oMobileRetentionPreviousOrder.mnp_his_id=x_lMnp_his_id;
            _oMobileRetentionPreviousOrder.cust_name=x_sCust_name;
            _oMobileRetentionPreviousOrder.cust_type=x_sCust_type;
            _oMobileRetentionPreviousOrder.upgrade_sponsorships_amount=x_sUpgrade_sponsorships_amount;
            _oMobileRetentionPreviousOrder.bill_medium_waive=x_bBill_medium_waive;
            _oMobileRetentionPreviousOrder.delivery_exchange_location=x_sDelivery_exchange_location;
            _oMobileRetentionPreviousOrder.hs_offer_type_id=x_iHs_offer_type_id;
            _oMobileRetentionPreviousOrder.org_fee=x_sOrg_fee;
            _oMobileRetentionPreviousOrder.rebate=x_sRebate;
            _oMobileRetentionPreviousOrder.upgrade_type=x_sUpgrade_type;
            _oMobileRetentionPreviousOrder.go_wireless=x_sGo_wireless;
            _oMobileRetentionPreviousOrder.extra_rebate=x_sExtra_rebate;
            _oMobileRetentionPreviousOrder.plan_eff=x_sPlan_eff;
            _oMobileRetentionPreviousOrder.extra_rebate_amount=x_sExtra_rebate_amount;
            _oMobileRetentionPreviousOrder.card_exp_year=x_sCard_exp_year;
            _oMobileRetentionPreviousOrder.upgrade_existing_contract_sdate=x_dUpgrade_existing_contract_sdate;
            _oMobileRetentionPreviousOrder.ord_place_hkid=x_sOrd_place_hkid;
            _oMobileRetentionPreviousOrder.register_address=x_sRegister_address;
            _oMobileRetentionPreviousOrder.gender=x_sGender;
            _oMobileRetentionPreviousOrder.lob_ac=x_sLob_ac;
            _oMobileRetentionPreviousOrder.sim_mrt_no=x_iSim_mrt_no;
            _oMobileRetentionPreviousOrder.redemption_notice_option=x_sRedemption_notice_option;
            _oMobileRetentionPreviousOrder.delivery_collection_type=x_sDelivery_collection_type;
            _oMobileRetentionPreviousOrder.action_date=x_dAction_date;
            _oMobileRetentionPreviousOrder.third_party_id_type=x_sThird_party_id_type;
            _oMobileRetentionPreviousOrder.org_ftg=x_sOrg_ftg;
            _oMobileRetentionPreviousOrder.upgrade_service_tenure=x_sUpgrade_service_tenure;
            _oMobileRetentionPreviousOrder.monthly_payment_type=x_sMonthly_payment_type;
            _oMobileRetentionPreviousOrder.contact_no=x_sContact_no;
            _oMobileRetentionPreviousOrder.org_mrt=x_iOrg_mrt;
            _oMobileRetentionPreviousOrder.sim_item_name=x_sSim_item_name;
            _oMobileRetentionPreviousOrder.pay_method=x_sPay_method;
            _oMobileRetentionPreviousOrder.hs_model=x_sHs_model;
            _oMobileRetentionPreviousOrder.gift_code=x_sGift_code;
            _oMobileRetentionPreviousOrder.monthly_bank_account_hkid=x_sMonthly_bank_account_hkid;
            _oMobileRetentionPreviousOrder.extra_offer=x_sExtra_offer;
            _oMobileRetentionPreviousOrder.monthly_bank_account_no=x_sMonthly_bank_account_no;
            _oMobileRetentionPreviousOrder.first_month_license_fee=x_sFirst_month_license_fee;
            _oMobileRetentionPreviousOrder.retrieve_cnt=x_iRetrieve_cnt;
            _oMobileRetentionPreviousOrder.ddate=x_dDdate;
            _oMobileRetentionPreviousOrder.s_premium2=x_sS_premium2;
            _oMobileRetentionPreviousOrder.monthly_bank_account_id_type=x_sMonthly_bank_account_id_type;
            _oMobileRetentionPreviousOrder.card_type=x_sCard_type;
            _oMobileRetentionPreviousOrder.next_bill=x_bNext_bill;
            _oMobileRetentionPreviousOrder.pcd_paid_go_wireless=x_bPcd_paid_go_wireless;
            _oMobileRetentionPreviousOrder.upgrade_rebate_calculation=x_sUpgrade_rebate_calculation;
            _oMobileRetentionPreviousOrder.ext_place_tel=x_sExt_place_tel;
            _oMobileRetentionPreviousOrder.m_3rd_hkid=x_sM_3rd_hkid;
            _oMobileRetentionPreviousOrder.retention_type=x_sRetention_type;
            _oMobileRetentionPreviousOrder.bill_address_his_id=x_lBill_address_his_id;
            _oMobileRetentionPreviousOrder.aig_gift=x_sAig_gift;
            _oMobileRetentionPreviousOrder.cust_staff_no=x_sCust_staff_no;
            _oMobileRetentionPreviousOrder.family_name=x_sFamily_name;
            _oMobileRetentionPreviousOrder.cdate=x_dCdate;
            _oMobileRetentionPreviousOrder.status_by_cs_admin=x_sStatus_by_cs_admin;
            _oMobileRetentionPreviousOrder.sim_item_number=x_sSim_item_number;
            _oMobileRetentionPreviousOrder.vip_case=x_sVip_case;
            _oMobileRetentionPreviousOrder.given_name=x_sGiven_name;
            _oMobileRetentionPreviousOrder.log_date=x_dLog_date;
            _oMobileRetentionPreviousOrder.extn=x_sExtn;
            _oMobileRetentionPreviousOrder.d_time=x_sD_time;
            _oMobileRetentionPreviousOrder.bank_name=x_sBank_name;
            _oMobileRetentionPreviousOrder.delivery_exchange_option=x_sDelivery_exchange_option;
            _oMobileRetentionPreviousOrder.upgrade_service_account_no=x_sUpgrade_service_account_no;
            _oMobileRetentionPreviousOrder.action_of_rate_plan_effective=x_sAction_of_rate_plan_effective;
            _oMobileRetentionPreviousOrder.m_card_no=x_sM_card_no;
            _oMobileRetentionPreviousOrder.existing_contract_end_date=x_sExisting_contract_end_date;
            _oMobileRetentionPreviousOrder.con_eff_date=x_dCon_eff_date;
            _oMobileRetentionPreviousOrder.m_3rd_hkid2=x_sM_3rd_hkid2;
            _oMobileRetentionPreviousOrder.amount=x_sAmount;
            _oMobileRetentionPreviousOrder.id_type=x_sId_type;
            _oMobileRetentionPreviousOrder.rate_plan=x_sRate_plan;
            _oMobileRetentionPreviousOrder.channel=x_sChannel;
            _oMobileRetentionPreviousOrder.action_eff_date=x_dAction_eff_date;
            _oMobileRetentionPreviousOrder.issue_type=x_sIssue_type;
            _oMobileRetentionPreviousOrder.free_mon=x_sFree_mon;
            _oMobileRetentionPreviousOrder.plan_eff_date=x_dPlan_eff_date;
            _oMobileRetentionPreviousOrder.del_remark=x_sDel_remark;
            _oMobileRetentionPreviousOrder.teamcode=x_sTeamcode;
            _oMobileRetentionPreviousOrder.staff_name=x_sStaff_name;
            _oMobileRetentionPreviousOrder.edf_no=x_sEdf_no;
            _oMobileRetentionPreviousOrder.ord_place_by=x_sOrd_place_by;
            _oMobileRetentionPreviousOrder.cancel_renew=x_sCancel_renew;
            _oMobileRetentionPreviousOrder.preferred_languages=x_sPreferred_languages;
            _oMobileRetentionPreviousOrder.hkid=x_sHkid;
            _oMobileRetentionPreviousOrder.card_no=x_sCard_no;
            _oMobileRetentionPreviousOrder.ac_no=x_sAc_no;
            _oMobileRetentionPreviousOrder.bill_cut_num=x_iBill_cut_num;
            _oMobileRetentionPreviousOrder.premium=x_sPremium;
            _oMobileRetentionPreviousOrder.m_3rd_id_type=x_sM_3rd_id_type;
            _oMobileRetentionPreviousOrder.gift_imei2=x_sGift_imei2;
            _oMobileRetentionPreviousOrder.reasons=x_sReasons;
            _oMobileRetentionPreviousOrder.language=x_sLanguage;
            _oMobileRetentionPreviousOrder.rebate_amount=x_sRebate_amount;
            _oMobileRetentionPreviousOrder.lob=x_sLob;
            _oMobileRetentionPreviousOrder.m_3rd_contact_no=x_sM_3rd_contact_no;
            _oMobileRetentionPreviousOrder.staff_no=x_sStaff_no;
            _oMobileRetentionPreviousOrder.s_premium3=x_sS_premium3;
            _oMobileRetentionPreviousOrder.sp_d_date=x_dSp_d_date;
            _oMobileRetentionPreviousOrder.bundle_name=x_sBundle_name;
            _oMobileRetentionPreviousOrder.accessory_waive=x_bAccessory_waive;
            _oMobileRetentionPreviousOrder.sim_item_code=x_sSim_item_code;
            _oMobileRetentionPreviousOrder.monthly_bank_account_holder=x_sMonthly_bank_account_holder;
            _oMobileRetentionPreviousOrder.card_holder=x_sCard_holder;
            return InsertWithOutLastID(x_oDB, _oMobileRetentionPreviousOrder);
        }
        
        
        public bool Insert(MobileRetentionPreviousOrder x_oMobileRetentionPreviousOrder)
        {
            return InsertWithOutLastID(n_oDB, x_oMobileRetentionPreviousOrder);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is MobileRetentionPreviousOrder)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (MobileRetentionPreviousOrder)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,MobileRetentionPreviousOrder x_oMobileRetentionPreviousOrder)
        {
            return InsertWithOutLastID(x_oDB, x_oMobileRetentionPreviousOrder);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileRetentionPreviousOrder x_oMobileRetentionPreviousOrder)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileRetentionPreviousOrder]   ([gift_imei],[s_premium4],[upgrade_existing_customer_type],[gift_desc4],[accessory_desc],[staff_name],[action_required],[registered_address_his_id],[vas_eff_date],[monthly_bank_account_bank_code],[sim_item_number],[special_handling_dummy_code],[card_no],[m_card_exp_year],[bill_medium_email],[remarks2PY],[trade_field],[ord_place_tel],[action_of_rate_plan_effective],[cooling_offer],[rec_no],[upgrade_handset_offer_rebate_schedule],[change_payment_type],[date_of_birth],[contact_person],[extra_d_charge],[tl_name],[fast_start],[issue_type],[sp_ref_no],[edate],[exist_cust_plan],[ord_place_rel],[mrt_no],[imei_no],[existing_smart_phone_model],[bank_code],[pos_ref_no],[bill_cut_date],[gift_imei3],[exist_plan],[waive],[program],[first_month_fee],[r_offer],[cid],[did],[ftg_tenure],[con_per],[gift_code4],[easywatch_type],[sms_mrt],[tpy_his_id],[monthly_payment_method],[remarks2EDF],[gift_desc3],[gift_imei4],[monthly_bank_account_hkid2],[d_date],[gift_desc],[pool],[cn_mrt_no],[accessory_imei],[third_party_credit_card],[special_approval],[upgrade_existing_contract_edate],[accessory_code],[s_premium],[ref_staff_no],[accessory_price],[m_card_exp_month],[installment_period],[m_card_type],[easywatch_ord_id],[normal_rebate],[m_rebate_amount],[m_card_holder2],[monthly_bank_account_holder],[active],[s_premium1],[card_exp_month],[ob_program_id],[sku],[salesmancode],[go_wireless_package_code],[lob],[ref_salesmancode],[third_party_hkid],[upgrade_existing_pccw_customer],[d_address],[upgrade_registered_mobile_no],[gift_code3],[normal_rebate_type],[gift_desc2],[monthly_bank_account_branch_code],[remarks],[accept],[delivery_exchange],[gift_code2],[prepayment_waive],[existing_smart_phone_imei],[mnp_his_id],[cust_name],[upgrade_sponsorships_amount],[bill_medium_waive],[delivery_exchange_location],[hs_offer_type_id],[org_fee],[rebate],[upgrade_type],[go_wireless],[extra_rebate],[plan_eff],[extra_rebate_amount],[card_exp_year],[upgrade_existing_contract_sdate],[ord_place_hkid],[register_address],[gender],[lob_ac],[sim_mrt_no],[redemption_notice_option],[delivery_collection_type],[action_date],[third_party_id_type],[org_ftg],[upgrade_service_tenure],[monthly_payment_type],[contact_no],[org_mrt],[sim_item_name],[pay_method],[hs_model],[gift_code],[monthly_bank_account_hkid],[extra_offer],[monthly_bank_account_no],[first_month_license_fee],[retrieve_cnt],[ddate],[s_premium2],[monthly_bank_account_id_type],[card_type],[next_bill],[pcd_paid_go_wireless],[upgrade_rebate_calculation],[ext_place_tel],[m_3rd_hkid],[retention_type],[bill_address_his_id],[aig_gift],[cust_staff_no],[family_name],[cdate],[status_by_cs_admin],[given_name],[vip_case],[s_premium3],[log_date],[extn],[d_time],[bank_name],[delivery_exchange_option],[upgrade_service_account_no],[old_ord_id],[m_card_no],[existing_contract_end_date],[con_eff_date],[m_3rd_hkid2],[amount],[m_3rd_id_type],[id_type],[rate_plan],[channel],[action_eff_date],[cooling_date],[free_mon],[plan_eff_date],[teamcode],[bill_medium],[edf_no],[ord_place_by],[cancel_renew],[preferred_languages],[hkid],[card_holder],[ac_no],[bill_cut_num],[premium],[del_remark],[gift_imei2],[reasons],[language],[rebate_amount],[ord_place_id_type],[m_3rd_contact_no],[staff_no],[sp_d_date],[bundle_name],[accessory_waive],[sim_item_code],[cust_type],[card_ref_no])  VALUES  (@gift_imei,@s_premium4,@upgrade_existing_customer_type,@gift_desc4,@accessory_desc,@staff_name,@action_required,@registered_address_his_id,@vas_eff_date,@monthly_bank_account_bank_code,@sim_item_number,@special_handling_dummy_code,@card_no,@m_card_exp_year,@bill_medium_email,@remarks2PY,@trade_field,@ord_place_tel,@action_of_rate_plan_effective,@cooling_offer,@rec_no,@upgrade_handset_offer_rebate_schedule,@change_payment_type,@date_of_birth,@contact_person,@extra_d_charge,@tl_name,@fast_start,@issue_type,@sp_ref_no,@edate,@exist_cust_plan,@ord_place_rel,@mrt_no,@imei_no,@existing_smart_phone_model,@bank_code,@pos_ref_no,@bill_cut_date,@gift_imei3,@exist_plan,@waive,@program,@first_month_fee,@r_offer,@cid,@did,@ftg_tenure,@con_per,@gift_code4,@easywatch_type,@sms_mrt,@tpy_his_id,@monthly_payment_method,@remarks2EDF,@gift_desc3,@gift_imei4,@monthly_bank_account_hkid2,@d_date,@gift_desc,@pool,@cn_mrt_no,@accessory_imei,@third_party_credit_card,@special_approval,@upgrade_existing_contract_edate,@accessory_code,@s_premium,@ref_staff_no,@accessory_price,@m_card_exp_month,@installment_period,@m_card_type,@easywatch_ord_id,@normal_rebate,@m_rebate_amount,@m_card_holder2,@monthly_bank_account_holder,@active,@s_premium1,@card_exp_month,@ob_program_id,@sku,@salesmancode,@go_wireless_package_code,@lob,@ref_salesmancode,@third_party_hkid,@upgrade_existing_pccw_customer,@d_address,@upgrade_registered_mobile_no,@gift_code3,@normal_rebate_type,@gift_desc2,@monthly_bank_account_branch_code,@remarks,@accept,@delivery_exchange,@gift_code2,@prepayment_waive,@existing_smart_phone_imei,@mnp_his_id,@cust_name,@upgrade_sponsorships_amount,@bill_medium_waive,@delivery_exchange_location,@hs_offer_type_id,@org_fee,@rebate,@upgrade_type,@go_wireless,@extra_rebate,@plan_eff,@extra_rebate_amount,@card_exp_year,@upgrade_existing_contract_sdate,@ord_place_hkid,@register_address,@gender,@lob_ac,@sim_mrt_no,@redemption_notice_option,@delivery_collection_type,@action_date,@third_party_id_type,@org_ftg,@upgrade_service_tenure,@monthly_payment_type,@contact_no,@org_mrt,@sim_item_name,@pay_method,@hs_model,@gift_code,@monthly_bank_account_hkid,@extra_offer,@monthly_bank_account_no,@first_month_license_fee,@retrieve_cnt,@ddate,@s_premium2,@monthly_bank_account_id_type,@card_type,@next_bill,@pcd_paid_go_wireless,@upgrade_rebate_calculation,@ext_place_tel,@m_3rd_hkid,@retention_type,@bill_address_his_id,@aig_gift,@cust_staff_no,@family_name,@cdate,@status_by_cs_admin,@given_name,@vip_case,@s_premium3,@log_date,@extn,@d_time,@bank_name,@delivery_exchange_option,@upgrade_service_account_no,@old_ord_id,@m_card_no,@existing_contract_end_date,@con_eff_date,@m_3rd_hkid2,@amount,@m_3rd_id_type,@id_type,@rate_plan,@channel,@action_eff_date,@cooling_date,@free_mon,@plan_eff_date,@teamcode,@bill_medium,@edf_no,@ord_place_by,@cancel_renew,@preferred_languages,@hkid,@card_holder,@ac_no,@bill_cut_num,@premium,@del_remark,@gift_imei2,@reasons,@language,@rebate_amount,@ord_place_id_type,@m_3rd_contact_no,@staff_no,@sp_d_date,@bundle_name,@accessory_waive,@sim_item_code,@cust_type,@card_ref_no)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionPreviousOrder]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionPreviousOrder]"); }
            global::System.Data.SqlClient.SqlConnection _oConn = null;
            global::System.Data.SqlClient.SqlCommand _oCmd = null;
            if (x_oDB.bTransaction)
            {
                x_oDB.ISessionCmd.CommandText = _sQuery;
                x_oDB.ISessionCmd.Parameters.Clear();
                _oCmd = x_oDB.ISessionCmd;
                _oConn = x_oDB.ISessionConn;
            }
            else
            {
                _oConn =x_oDB.GetConnection();
                _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            }
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oMobileRetentionPreviousOrder);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileRetentionPreviousOrder x_oMobileRetentionPreviousOrder)
        {
            bool _bResult = false;
            if (!x_oMobileRetentionPreviousOrder.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileRetentionPreviousOrder.gift_imei==null){  x_oCmd.Parameters.Add("@gift_imei", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_imei", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.gift_imei; }
                if(x_oMobileRetentionPreviousOrder.s_premium4==null){  x_oCmd.Parameters.Add("@s_premium4", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@s_premium4", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.s_premium4; }
                if(x_oMobileRetentionPreviousOrder.upgrade_existing_customer_type==null){  x_oCmd.Parameters.Add("@upgrade_existing_customer_type", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_existing_customer_type", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.upgrade_existing_customer_type; }
                if(x_oMobileRetentionPreviousOrder.gift_desc4==null){  x_oCmd.Parameters.Add("@gift_desc4", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_desc4", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.gift_desc4; }
                if(x_oMobileRetentionPreviousOrder.accessory_desc==null){  x_oCmd.Parameters.Add("@accessory_desc", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@accessory_desc", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.accessory_desc; }
                if(x_oMobileRetentionPreviousOrder.staff_name==null){  x_oCmd.Parameters.Add("@staff_name", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@staff_name", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.staff_name; }
                if(x_oMobileRetentionPreviousOrder.action_required==null){  x_oCmd.Parameters.Add("@action_required", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@action_required", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.action_required; }
                if(x_oMobileRetentionPreviousOrder.registered_address_his_id==null){  x_oCmd.Parameters.Add("@registered_address_his_id", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@registered_address_his_id", global::System.Data.SqlDbType.BigInt).Value=x_oMobileRetentionPreviousOrder.registered_address_his_id; }
                if(x_oMobileRetentionPreviousOrder.vas_eff_date==null){  x_oCmd.Parameters.Add("@vas_eff_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@vas_eff_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionPreviousOrder.vas_eff_date; }
                if(x_oMobileRetentionPreviousOrder.monthly_bank_account_bank_code==null){  x_oCmd.Parameters.Add("@monthly_bank_account_bank_code", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_bank_account_bank_code", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.monthly_bank_account_bank_code; }
                if(x_oMobileRetentionPreviousOrder.sim_item_number==null){  x_oCmd.Parameters.Add("@sim_item_number", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sim_item_number", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.sim_item_number; }
                if(x_oMobileRetentionPreviousOrder.special_handling_dummy_code==null){  x_oCmd.Parameters.Add("@special_handling_dummy_code", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@special_handling_dummy_code", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.special_handling_dummy_code; }
                if(x_oMobileRetentionPreviousOrder.card_no==null){  x_oCmd.Parameters.Add("@card_no", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@card_no", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionPreviousOrder.card_no; }
                if(x_oMobileRetentionPreviousOrder.m_card_exp_year==null){  x_oCmd.Parameters.Add("@m_card_exp_year", global::System.Data.SqlDbType.NVarChar,4).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_card_exp_year", global::System.Data.SqlDbType.NVarChar,4).Value=x_oMobileRetentionPreviousOrder.m_card_exp_year; }
                if(x_oMobileRetentionPreviousOrder.bill_medium_email==null){  x_oCmd.Parameters.Add("@bill_medium_email", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bill_medium_email", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.bill_medium_email; }
                if(x_oMobileRetentionPreviousOrder.remarks2PY==null){  x_oCmd.Parameters.Add("@remarks2PY", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@remarks2PY", global::System.Data.SqlDbType.Text).Value=x_oMobileRetentionPreviousOrder.remarks2PY; }
                if(x_oMobileRetentionPreviousOrder.trade_field==null){  x_oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.trade_field; }
                if(x_oMobileRetentionPreviousOrder.ord_place_tel==null){  x_oCmd.Parameters.Add("@ord_place_tel", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ord_place_tel", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.ord_place_tel; }
                if(x_oMobileRetentionPreviousOrder.action_of_rate_plan_effective==null){  x_oCmd.Parameters.Add("@action_of_rate_plan_effective", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@action_of_rate_plan_effective", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.action_of_rate_plan_effective; }
                if(x_oMobileRetentionPreviousOrder.cooling_offer==null){  x_oCmd.Parameters.Add("@cooling_offer", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cooling_offer", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.cooling_offer; }
                if(x_oMobileRetentionPreviousOrder.rec_no==null){  x_oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int).Value=x_oMobileRetentionPreviousOrder.rec_no; }
                if(x_oMobileRetentionPreviousOrder.upgrade_handset_offer_rebate_schedule==null){  x_oCmd.Parameters.Add("@upgrade_handset_offer_rebate_schedule", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_handset_offer_rebate_schedule", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.upgrade_handset_offer_rebate_schedule; }
                if(x_oMobileRetentionPreviousOrder.change_payment_type==null){  x_oCmd.Parameters.Add("@change_payment_type", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@change_payment_type", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionPreviousOrder.change_payment_type; }
                if(x_oMobileRetentionPreviousOrder.date_of_birth==null){  x_oCmd.Parameters.Add("@date_of_birth", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@date_of_birth", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionPreviousOrder.date_of_birth; }
                if(x_oMobileRetentionPreviousOrder.contact_person==null){  x_oCmd.Parameters.Add("@contact_person", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@contact_person", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.contact_person; }
                if(x_oMobileRetentionPreviousOrder.extra_d_charge==null){  x_oCmd.Parameters.Add("@extra_d_charge", global::System.Data.SqlDbType.NVarChar,5).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@extra_d_charge", global::System.Data.SqlDbType.NVarChar,5).Value=x_oMobileRetentionPreviousOrder.extra_d_charge; }
                if(x_oMobileRetentionPreviousOrder.tl_name==null){  x_oCmd.Parameters.Add("@tl_name", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@tl_name", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.tl_name; }
                if(x_oMobileRetentionPreviousOrder.fast_start==null){  x_oCmd.Parameters.Add("@fast_start", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fast_start", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionPreviousOrder.fast_start; }
                if(x_oMobileRetentionPreviousOrder.issue_type==null){  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.issue_type; }
                if(x_oMobileRetentionPreviousOrder.sp_ref_no==null){  x_oCmd.Parameters.Add("@sp_ref_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sp_ref_no", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.sp_ref_no; }
                if(x_oMobileRetentionPreviousOrder.edate==null){  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionPreviousOrder.edate; }
                if(x_oMobileRetentionPreviousOrder.exist_cust_plan==null){  x_oCmd.Parameters.Add("@exist_cust_plan", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@exist_cust_plan", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.exist_cust_plan; }
                if(x_oMobileRetentionPreviousOrder.ord_place_rel==null){  x_oCmd.Parameters.Add("@ord_place_rel", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ord_place_rel", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.ord_place_rel; }
                if(x_oMobileRetentionPreviousOrder.mrt_no==null){  x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.Int).Value=x_oMobileRetentionPreviousOrder.mrt_no; }
                if(x_oMobileRetentionPreviousOrder.imei_no==null){  x_oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionPreviousOrder.imei_no; }
                if(x_oMobileRetentionPreviousOrder.existing_smart_phone_model==null){  x_oCmd.Parameters.Add("@existing_smart_phone_model", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@existing_smart_phone_model", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.existing_smart_phone_model; }
                if(x_oMobileRetentionPreviousOrder.bank_code==null){  x_oCmd.Parameters.Add("@bank_code", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bank_code", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionPreviousOrder.bank_code; }
                if(x_oMobileRetentionPreviousOrder.pos_ref_no==null){  x_oCmd.Parameters.Add("@pos_ref_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@pos_ref_no", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.pos_ref_no; }
                if(x_oMobileRetentionPreviousOrder.bill_cut_date==null){  x_oCmd.Parameters.Add("@bill_cut_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@bill_cut_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionPreviousOrder.bill_cut_date; }
                if(x_oMobileRetentionPreviousOrder.gift_imei3==null){  x_oCmd.Parameters.Add("@gift_imei3", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_imei3", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.gift_imei3; }
                if(x_oMobileRetentionPreviousOrder.exist_plan==null){  x_oCmd.Parameters.Add("@exist_plan", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@exist_plan", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.exist_plan; }
                if(x_oMobileRetentionPreviousOrder.waive==null){  x_oCmd.Parameters.Add("@waive", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@waive", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionPreviousOrder.waive; }
                if(x_oMobileRetentionPreviousOrder.program==null){  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.program; }
                if(x_oMobileRetentionPreviousOrder.first_month_fee==null){  x_oCmd.Parameters.Add("@first_month_fee", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@first_month_fee", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.first_month_fee; }
                if(x_oMobileRetentionPreviousOrder.r_offer==null){  x_oCmd.Parameters.Add("@r_offer", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@r_offer", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.r_offer; }
                if(x_oMobileRetentionPreviousOrder.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.cid; }
                if(x_oMobileRetentionPreviousOrder.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.did; }
                if(x_oMobileRetentionPreviousOrder.ftg_tenure==null){  x_oCmd.Parameters.Add("@ftg_tenure", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ftg_tenure", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.ftg_tenure; }
                if(x_oMobileRetentionPreviousOrder.con_per==null){  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.con_per; }
                if(x_oMobileRetentionPreviousOrder.gift_code4==null){  x_oCmd.Parameters.Add("@gift_code4", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_code4", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.gift_code4; }
                if(x_oMobileRetentionPreviousOrder.easywatch_type==null){  x_oCmd.Parameters.Add("@easywatch_type", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@easywatch_type", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionPreviousOrder.easywatch_type; }
                if(x_oMobileRetentionPreviousOrder.sms_mrt==null){  x_oCmd.Parameters.Add("@sms_mrt", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sms_mrt", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.sms_mrt; }
                if(x_oMobileRetentionPreviousOrder.tpy_his_id==null){  x_oCmd.Parameters.Add("@tpy_his_id", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@tpy_his_id", global::System.Data.SqlDbType.BigInt).Value=x_oMobileRetentionPreviousOrder.tpy_his_id; }
                if(x_oMobileRetentionPreviousOrder.monthly_payment_method==null){  x_oCmd.Parameters.Add("@monthly_payment_method", global::System.Data.SqlDbType.NVarChar,40).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_payment_method", global::System.Data.SqlDbType.NVarChar,40).Value=x_oMobileRetentionPreviousOrder.monthly_payment_method; }
                if(x_oMobileRetentionPreviousOrder.remarks2EDF==null){  x_oCmd.Parameters.Add("@remarks2EDF", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@remarks2EDF", global::System.Data.SqlDbType.Text).Value=x_oMobileRetentionPreviousOrder.remarks2EDF; }
                if(x_oMobileRetentionPreviousOrder.gift_desc3==null){  x_oCmd.Parameters.Add("@gift_desc3", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_desc3", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.gift_desc3; }
                if(x_oMobileRetentionPreviousOrder.gift_imei4==null){  x_oCmd.Parameters.Add("@gift_imei4", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_imei4", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.gift_imei4; }
                if(x_oMobileRetentionPreviousOrder.monthly_bank_account_hkid2==null){  x_oCmd.Parameters.Add("@monthly_bank_account_hkid2", global::System.Data.SqlDbType.NVarChar,1).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_bank_account_hkid2", global::System.Data.SqlDbType.NVarChar,1).Value=x_oMobileRetentionPreviousOrder.monthly_bank_account_hkid2; }
                if(x_oMobileRetentionPreviousOrder.d_date==null){  x_oCmd.Parameters.Add("@d_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@d_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionPreviousOrder.d_date; }
                if(x_oMobileRetentionPreviousOrder.gift_desc==null){  x_oCmd.Parameters.Add("@gift_desc", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_desc", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.gift_desc; }
                if(x_oMobileRetentionPreviousOrder.pool==null){  x_oCmd.Parameters.Add("@pool", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@pool", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.pool; }
                if(x_oMobileRetentionPreviousOrder.cn_mrt_no==null){  x_oCmd.Parameters.Add("@cn_mrt_no", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cn_mrt_no", global::System.Data.SqlDbType.BigInt).Value=x_oMobileRetentionPreviousOrder.cn_mrt_no; }
                if(x_oMobileRetentionPreviousOrder.accessory_imei==null){  x_oCmd.Parameters.Add("@accessory_imei", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@accessory_imei", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.accessory_imei; }
                if(x_oMobileRetentionPreviousOrder.third_party_credit_card==null){  x_oCmd.Parameters.Add("@third_party_credit_card", global::System.Data.SqlDbType.NVarChar,5).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@third_party_credit_card", global::System.Data.SqlDbType.NVarChar,5).Value=x_oMobileRetentionPreviousOrder.third_party_credit_card; }
                if(x_oMobileRetentionPreviousOrder.special_approval==null){  x_oCmd.Parameters.Add("@special_approval", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@special_approval", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.special_approval; }
                if(x_oMobileRetentionPreviousOrder.upgrade_existing_contract_edate==null){  x_oCmd.Parameters.Add("@upgrade_existing_contract_edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@upgrade_existing_contract_edate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionPreviousOrder.upgrade_existing_contract_edate; }
                if(x_oMobileRetentionPreviousOrder.accessory_code==null){  x_oCmd.Parameters.Add("@accessory_code", global::System.Data.SqlDbType.NVarChar,70).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@accessory_code", global::System.Data.SqlDbType.NVarChar,70).Value=x_oMobileRetentionPreviousOrder.accessory_code; }
                if(x_oMobileRetentionPreviousOrder.s_premium==null){  x_oCmd.Parameters.Add("@s_premium", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@s_premium", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.s_premium; }
                if(x_oMobileRetentionPreviousOrder.ref_staff_no==null){  x_oCmd.Parameters.Add("@ref_staff_no", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ref_staff_no", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionPreviousOrder.ref_staff_no; }
                if(x_oMobileRetentionPreviousOrder.accessory_price==null){  x_oCmd.Parameters.Add("@accessory_price", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@accessory_price", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.accessory_price; }
                if(x_oMobileRetentionPreviousOrder.m_card_exp_month==null){  x_oCmd.Parameters.Add("@m_card_exp_month", global::System.Data.SqlDbType.NVarChar,2).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_card_exp_month", global::System.Data.SqlDbType.NVarChar,2).Value=x_oMobileRetentionPreviousOrder.m_card_exp_month; }
                if(x_oMobileRetentionPreviousOrder.installment_period==null){  x_oCmd.Parameters.Add("@installment_period", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@installment_period", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.installment_period; }
                if(x_oMobileRetentionPreviousOrder.m_card_type==null){  x_oCmd.Parameters.Add("@m_card_type", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_card_type", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionPreviousOrder.m_card_type; }
                if(x_oMobileRetentionPreviousOrder.easywatch_ord_id==null){  x_oCmd.Parameters.Add("@easywatch_ord_id", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@easywatch_ord_id", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.easywatch_ord_id; }
                if(x_oMobileRetentionPreviousOrder.normal_rebate==null){  x_oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionPreviousOrder.normal_rebate; }
                if(x_oMobileRetentionPreviousOrder.m_rebate_amount==null){  x_oCmd.Parameters.Add("@m_rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.m_rebate_amount; }
                if(x_oMobileRetentionPreviousOrder.m_card_holder2==null){  x_oCmd.Parameters.Add("@m_card_holder2", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_card_holder2", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.m_card_holder2; }
                if(x_oMobileRetentionPreviousOrder.monthly_bank_account_holder==null){  x_oCmd.Parameters.Add("@monthly_bank_account_holder", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_bank_account_holder", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.monthly_bank_account_holder; }
                if(x_oMobileRetentionPreviousOrder.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionPreviousOrder.active; }
                if(x_oMobileRetentionPreviousOrder.s_premium1==null){  x_oCmd.Parameters.Add("@s_premium1", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@s_premium1", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.s_premium1; }
                if(x_oMobileRetentionPreviousOrder.card_exp_month==null){  x_oCmd.Parameters.Add("@card_exp_month", global::System.Data.SqlDbType.NVarChar,2).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@card_exp_month", global::System.Data.SqlDbType.NVarChar,2).Value=x_oMobileRetentionPreviousOrder.card_exp_month; }
                if(x_oMobileRetentionPreviousOrder.ob_program_id==null){  x_oCmd.Parameters.Add("@ob_program_id", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ob_program_id", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionPreviousOrder.ob_program_id; }
                if(x_oMobileRetentionPreviousOrder.sku==null){  x_oCmd.Parameters.Add("@sku", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sku", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.sku; }
                if(x_oMobileRetentionPreviousOrder.salesmancode==null){  x_oCmd.Parameters.Add("@salesmancode", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@salesmancode", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.salesmancode; }
                if(x_oMobileRetentionPreviousOrder.go_wireless_package_code==null){  x_oCmd.Parameters.Add("@go_wireless_package_code", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@go_wireless_package_code", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.go_wireless_package_code; }
                if(x_oMobileRetentionPreviousOrder.lob==null){  x_oCmd.Parameters.Add("@lob", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@lob", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.lob; }
                if(x_oMobileRetentionPreviousOrder.ref_salesmancode==null){  x_oCmd.Parameters.Add("@ref_salesmancode", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ref_salesmancode", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionPreviousOrder.ref_salesmancode; }
                if(x_oMobileRetentionPreviousOrder.third_party_hkid==null){  x_oCmd.Parameters.Add("@third_party_hkid", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@third_party_hkid", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionPreviousOrder.third_party_hkid; }
                if(x_oMobileRetentionPreviousOrder.upgrade_existing_pccw_customer==null){  x_oCmd.Parameters.Add("@upgrade_existing_pccw_customer", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_existing_pccw_customer", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.upgrade_existing_pccw_customer; }
                if(x_oMobileRetentionPreviousOrder.d_address==null){  x_oCmd.Parameters.Add("@d_address", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_address", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.d_address; }
                if(x_oMobileRetentionPreviousOrder.upgrade_registered_mobile_no==null){  x_oCmd.Parameters.Add("@upgrade_registered_mobile_no", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_registered_mobile_no", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.upgrade_registered_mobile_no; }
                if(x_oMobileRetentionPreviousOrder.gift_code3==null){  x_oCmd.Parameters.Add("@gift_code3", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_code3", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.gift_code3; }
                if(x_oMobileRetentionPreviousOrder.normal_rebate_type==null){  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.normal_rebate_type; }
                if(x_oMobileRetentionPreviousOrder.gift_desc2==null){  x_oCmd.Parameters.Add("@gift_desc2", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_desc2", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.gift_desc2; }
                if(x_oMobileRetentionPreviousOrder.monthly_bank_account_branch_code==null){  x_oCmd.Parameters.Add("@monthly_bank_account_branch_code", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_bank_account_branch_code", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.monthly_bank_account_branch_code; }
                if(x_oMobileRetentionPreviousOrder.remarks==null){  x_oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.Text).Value=x_oMobileRetentionPreviousOrder.remarks; }
                if(x_oMobileRetentionPreviousOrder.accept==null){  x_oCmd.Parameters.Add("@accept", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@accept", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.accept; }
                if(x_oMobileRetentionPreviousOrder.delivery_exchange==null){  x_oCmd.Parameters.Add("@delivery_exchange", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@delivery_exchange", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.delivery_exchange; }
                if(x_oMobileRetentionPreviousOrder.gift_code2==null){  x_oCmd.Parameters.Add("@gift_code2", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_code2", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.gift_code2; }
                if(x_oMobileRetentionPreviousOrder.prepayment_waive==null){  x_oCmd.Parameters.Add("@prepayment_waive", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@prepayment_waive", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionPreviousOrder.prepayment_waive; }
                if(x_oMobileRetentionPreviousOrder.existing_smart_phone_imei==null){  x_oCmd.Parameters.Add("@existing_smart_phone_imei", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@existing_smart_phone_imei", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.existing_smart_phone_imei; }
                if(x_oMobileRetentionPreviousOrder.mnp_his_id==null){  x_oCmd.Parameters.Add("@mnp_his_id", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@mnp_his_id", global::System.Data.SqlDbType.BigInt).Value=x_oMobileRetentionPreviousOrder.mnp_his_id; }
                if(x_oMobileRetentionPreviousOrder.cust_name==null){  x_oCmd.Parameters.Add("@cust_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cust_name", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.cust_name; }
                if(x_oMobileRetentionPreviousOrder.upgrade_sponsorships_amount==null){  x_oCmd.Parameters.Add("@upgrade_sponsorships_amount", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_sponsorships_amount", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.upgrade_sponsorships_amount; }
                if(x_oMobileRetentionPreviousOrder.bill_medium_waive==null){  x_oCmd.Parameters.Add("@bill_medium_waive", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bill_medium_waive", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionPreviousOrder.bill_medium_waive; }
                if(x_oMobileRetentionPreviousOrder.delivery_exchange_location==null){  x_oCmd.Parameters.Add("@delivery_exchange_location", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@delivery_exchange_location", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.delivery_exchange_location; }
                if(x_oMobileRetentionPreviousOrder.hs_offer_type_id==null){  x_oCmd.Parameters.Add("@hs_offer_type_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hs_offer_type_id", global::System.Data.SqlDbType.Int).Value=x_oMobileRetentionPreviousOrder.hs_offer_type_id; }
                if(x_oMobileRetentionPreviousOrder.org_fee==null){  x_oCmd.Parameters.Add("@org_fee", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@org_fee", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.org_fee; }
                if(x_oMobileRetentionPreviousOrder.rebate==null){  x_oCmd.Parameters.Add("@rebate", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rebate", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionPreviousOrder.rebate; }
                if(x_oMobileRetentionPreviousOrder.upgrade_type==null){  x_oCmd.Parameters.Add("@upgrade_type", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_type", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.upgrade_type; }
                if(x_oMobileRetentionPreviousOrder.go_wireless==null){  x_oCmd.Parameters.Add("@go_wireless", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@go_wireless", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.go_wireless; }
                if(x_oMobileRetentionPreviousOrder.extra_rebate==null){  x_oCmd.Parameters.Add("@extra_rebate", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@extra_rebate", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.extra_rebate; }
                if(x_oMobileRetentionPreviousOrder.plan_eff==null){  x_oCmd.Parameters.Add("@plan_eff", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@plan_eff", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionPreviousOrder.plan_eff; }
                if(x_oMobileRetentionPreviousOrder.extra_rebate_amount==null){  x_oCmd.Parameters.Add("@extra_rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@extra_rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.extra_rebate_amount; }
                if(x_oMobileRetentionPreviousOrder.card_exp_year==null){  x_oCmd.Parameters.Add("@card_exp_year", global::System.Data.SqlDbType.NVarChar,4).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@card_exp_year", global::System.Data.SqlDbType.NVarChar,4).Value=x_oMobileRetentionPreviousOrder.card_exp_year; }
                if(x_oMobileRetentionPreviousOrder.upgrade_existing_contract_sdate==null){  x_oCmd.Parameters.Add("@upgrade_existing_contract_sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@upgrade_existing_contract_sdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionPreviousOrder.upgrade_existing_contract_sdate; }
                if(x_oMobileRetentionPreviousOrder.ord_place_hkid==null){  x_oCmd.Parameters.Add("@ord_place_hkid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ord_place_hkid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.ord_place_hkid; }
                if(x_oMobileRetentionPreviousOrder.register_address==null){  x_oCmd.Parameters.Add("@register_address", global::System.Data.SqlDbType.NVarChar,200).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@register_address", global::System.Data.SqlDbType.NVarChar,200).Value=x_oMobileRetentionPreviousOrder.register_address; }
                if(x_oMobileRetentionPreviousOrder.gender==null){  x_oCmd.Parameters.Add("@gender", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gender", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.gender; }
                if(x_oMobileRetentionPreviousOrder.lob_ac==null){  x_oCmd.Parameters.Add("@lob_ac", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@lob_ac", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionPreviousOrder.lob_ac; }
                if(x_oMobileRetentionPreviousOrder.sim_mrt_no==null){  x_oCmd.Parameters.Add("@sim_mrt_no", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sim_mrt_no", global::System.Data.SqlDbType.Int).Value=x_oMobileRetentionPreviousOrder.sim_mrt_no; }
                if(x_oMobileRetentionPreviousOrder.redemption_notice_option==null){  x_oCmd.Parameters.Add("@redemption_notice_option", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@redemption_notice_option", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.redemption_notice_option; }
                if(x_oMobileRetentionPreviousOrder.delivery_collection_type==null){  x_oCmd.Parameters.Add("@delivery_collection_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@delivery_collection_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.delivery_collection_type; }
                if(x_oMobileRetentionPreviousOrder.action_date==null){  x_oCmd.Parameters.Add("@action_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@action_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionPreviousOrder.action_date; }
                if(x_oMobileRetentionPreviousOrder.third_party_id_type==null){  x_oCmd.Parameters.Add("@third_party_id_type", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@third_party_id_type", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionPreviousOrder.third_party_id_type; }
                if(x_oMobileRetentionPreviousOrder.org_ftg==null){  x_oCmd.Parameters.Add("@org_ftg", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@org_ftg", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.org_ftg; }
                if(x_oMobileRetentionPreviousOrder.upgrade_service_tenure==null){  x_oCmd.Parameters.Add("@upgrade_service_tenure", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_service_tenure", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.upgrade_service_tenure; }
                if(x_oMobileRetentionPreviousOrder.monthly_payment_type==null){  x_oCmd.Parameters.Add("@monthly_payment_type", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_payment_type", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.monthly_payment_type; }
                if(x_oMobileRetentionPreviousOrder.contact_no==null){  x_oCmd.Parameters.Add("@contact_no", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@contact_no", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionPreviousOrder.contact_no; }
                if(x_oMobileRetentionPreviousOrder.org_mrt==null){  x_oCmd.Parameters.Add("@org_mrt", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@org_mrt", global::System.Data.SqlDbType.Int).Value=x_oMobileRetentionPreviousOrder.org_mrt; }
                if(x_oMobileRetentionPreviousOrder.sim_item_name==null){  x_oCmd.Parameters.Add("@sim_item_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sim_item_name", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.sim_item_name; }
                if(x_oMobileRetentionPreviousOrder.pay_method==null){  x_oCmd.Parameters.Add("@pay_method", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@pay_method", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.pay_method; }
                if(x_oMobileRetentionPreviousOrder.hs_model==null){  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.hs_model; }
                if(x_oMobileRetentionPreviousOrder.gift_code==null){  x_oCmd.Parameters.Add("@gift_code", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_code", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.gift_code; }
                if(x_oMobileRetentionPreviousOrder.monthly_bank_account_hkid==null){  x_oCmd.Parameters.Add("@monthly_bank_account_hkid", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_bank_account_hkid", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionPreviousOrder.monthly_bank_account_hkid; }
                if(x_oMobileRetentionPreviousOrder.extra_offer==null){  x_oCmd.Parameters.Add("@extra_offer", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@extra_offer", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.extra_offer; }
                if(x_oMobileRetentionPreviousOrder.monthly_bank_account_no==null){  x_oCmd.Parameters.Add("@monthly_bank_account_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_bank_account_no", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.monthly_bank_account_no; }
                if(x_oMobileRetentionPreviousOrder.first_month_license_fee==null){  x_oCmd.Parameters.Add("@first_month_license_fee", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@first_month_license_fee", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.first_month_license_fee; }
                if(x_oMobileRetentionPreviousOrder.retrieve_cnt==null){  x_oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int).Value=x_oMobileRetentionPreviousOrder.retrieve_cnt; }
                if(x_oMobileRetentionPreviousOrder.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionPreviousOrder.ddate; }
                if(x_oMobileRetentionPreviousOrder.s_premium2==null){  x_oCmd.Parameters.Add("@s_premium2", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@s_premium2", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.s_premium2; }
                if(x_oMobileRetentionPreviousOrder.monthly_bank_account_id_type==null){  x_oCmd.Parameters.Add("@monthly_bank_account_id_type", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_bank_account_id_type", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.monthly_bank_account_id_type; }
                if(x_oMobileRetentionPreviousOrder.card_type==null){  x_oCmd.Parameters.Add("@card_type", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@card_type", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionPreviousOrder.card_type; }
                if(x_oMobileRetentionPreviousOrder.next_bill==null){  x_oCmd.Parameters.Add("@next_bill", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@next_bill", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionPreviousOrder.next_bill; }
                if(x_oMobileRetentionPreviousOrder.pcd_paid_go_wireless==null){  x_oCmd.Parameters.Add("@pcd_paid_go_wireless", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@pcd_paid_go_wireless", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionPreviousOrder.pcd_paid_go_wireless; }
                if(x_oMobileRetentionPreviousOrder.upgrade_rebate_calculation==null){  x_oCmd.Parameters.Add("@upgrade_rebate_calculation", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_rebate_calculation", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.upgrade_rebate_calculation; }
                if(x_oMobileRetentionPreviousOrder.ext_place_tel==null){  x_oCmd.Parameters.Add("@ext_place_tel", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ext_place_tel", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionPreviousOrder.ext_place_tel; }
                if(x_oMobileRetentionPreviousOrder.m_3rd_hkid==null){  x_oCmd.Parameters.Add("@m_3rd_hkid", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_3rd_hkid", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionPreviousOrder.m_3rd_hkid; }
                if(x_oMobileRetentionPreviousOrder.retention_type==null){  x_oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.Char,10).Value=x_oMobileRetentionPreviousOrder.retention_type; }
                if(x_oMobileRetentionPreviousOrder.bill_address_his_id==null){  x_oCmd.Parameters.Add("@bill_address_his_id", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bill_address_his_id", global::System.Data.SqlDbType.BigInt).Value=x_oMobileRetentionPreviousOrder.bill_address_his_id; }
                if(x_oMobileRetentionPreviousOrder.aig_gift==null){  x_oCmd.Parameters.Add("@aig_gift", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@aig_gift", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.aig_gift; }
                if(x_oMobileRetentionPreviousOrder.cust_staff_no==null){  x_oCmd.Parameters.Add("@cust_staff_no", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cust_staff_no", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.cust_staff_no; }
                if(x_oMobileRetentionPreviousOrder.family_name==null){  x_oCmd.Parameters.Add("@family_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@family_name", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.family_name; }
                if(x_oMobileRetentionPreviousOrder.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionPreviousOrder.cdate; }
                if(x_oMobileRetentionPreviousOrder.status_by_cs_admin==null){  x_oCmd.Parameters.Add("@status_by_cs_admin", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@status_by_cs_admin", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.status_by_cs_admin; }
                if(x_oMobileRetentionPreviousOrder.given_name==null){  x_oCmd.Parameters.Add("@given_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@given_name", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.given_name; }
                if(x_oMobileRetentionPreviousOrder.vip_case==null){  x_oCmd.Parameters.Add("@vip_case", global::System.Data.SqlDbType.NVarChar,200).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@vip_case", global::System.Data.SqlDbType.NVarChar,200).Value=x_oMobileRetentionPreviousOrder.vip_case; }
                if(x_oMobileRetentionPreviousOrder.s_premium3==null){  x_oCmd.Parameters.Add("@s_premium3", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@s_premium3", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.s_premium3; }
                if(x_oMobileRetentionPreviousOrder.log_date==null){  x_oCmd.Parameters.Add("@log_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@log_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionPreviousOrder.log_date; }
                if(x_oMobileRetentionPreviousOrder.extn==null){  x_oCmd.Parameters.Add("@extn", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@extn", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.extn; }
                if(x_oMobileRetentionPreviousOrder.d_time==null){  x_oCmd.Parameters.Add("@d_time", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_time", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.d_time; }
                if(x_oMobileRetentionPreviousOrder.bank_name==null){  x_oCmd.Parameters.Add("@bank_name", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bank_name", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.bank_name; }
                if(x_oMobileRetentionPreviousOrder.delivery_exchange_option==null){  x_oCmd.Parameters.Add("@delivery_exchange_option", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@delivery_exchange_option", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.delivery_exchange_option; }
                if(x_oMobileRetentionPreviousOrder.upgrade_service_account_no==null){  x_oCmd.Parameters.Add("@upgrade_service_account_no", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_service_account_no", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.upgrade_service_account_no; }
                if(x_oMobileRetentionPreviousOrder.old_ord_id==null){  x_oCmd.Parameters.Add("@old_ord_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@old_ord_id", global::System.Data.SqlDbType.Int).Value=x_oMobileRetentionPreviousOrder.old_ord_id; }
                if(x_oMobileRetentionPreviousOrder.m_card_no==null){  x_oCmd.Parameters.Add("@m_card_no", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_card_no", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionPreviousOrder.m_card_no; }
                if(x_oMobileRetentionPreviousOrder.existing_contract_end_date==null){  x_oCmd.Parameters.Add("@existing_contract_end_date", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@existing_contract_end_date", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionPreviousOrder.existing_contract_end_date; }
                if(x_oMobileRetentionPreviousOrder.con_eff_date==null){  x_oCmd.Parameters.Add("@con_eff_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@con_eff_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionPreviousOrder.con_eff_date; }
                if(x_oMobileRetentionPreviousOrder.m_3rd_hkid2==null){  x_oCmd.Parameters.Add("@m_3rd_hkid2", global::System.Data.SqlDbType.NVarChar,1).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_3rd_hkid2", global::System.Data.SqlDbType.NVarChar,1).Value=x_oMobileRetentionPreviousOrder.m_3rd_hkid2; }
                if(x_oMobileRetentionPreviousOrder.amount==null){  x_oCmd.Parameters.Add("@amount", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@amount", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.amount; }
                if(x_oMobileRetentionPreviousOrder.m_3rd_id_type==null){  x_oCmd.Parameters.Add("@m_3rd_id_type", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_3rd_id_type", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.m_3rd_id_type; }
                if(x_oMobileRetentionPreviousOrder.id_type==null){  x_oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.id_type; }
                if(x_oMobileRetentionPreviousOrder.rate_plan==null){  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.rate_plan; }
                if(x_oMobileRetentionPreviousOrder.channel==null){  x_oCmd.Parameters.Add("@channel", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@channel", global::System.Data.SqlDbType.Char,10).Value=x_oMobileRetentionPreviousOrder.channel; }
                if(x_oMobileRetentionPreviousOrder.action_eff_date==null){  x_oCmd.Parameters.Add("@action_eff_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@action_eff_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionPreviousOrder.action_eff_date; }
                if(x_oMobileRetentionPreviousOrder.cooling_date==null){  x_oCmd.Parameters.Add("@cooling_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cooling_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionPreviousOrder.cooling_date; }
                if(x_oMobileRetentionPreviousOrder.free_mon==null){  x_oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.free_mon; }
                if(x_oMobileRetentionPreviousOrder.plan_eff_date==null){  x_oCmd.Parameters.Add("@plan_eff_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@plan_eff_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionPreviousOrder.plan_eff_date; }
                if(x_oMobileRetentionPreviousOrder.teamcode==null){  x_oCmd.Parameters.Add("@teamcode", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@teamcode", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.teamcode; }
                if(x_oMobileRetentionPreviousOrder.bill_medium==null){  x_oCmd.Parameters.Add("@bill_medium", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bill_medium", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.bill_medium; }
                if(x_oMobileRetentionPreviousOrder.edf_no==null){  x_oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,15).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,15).Value=x_oMobileRetentionPreviousOrder.edf_no; }
                if(x_oMobileRetentionPreviousOrder.ord_place_by==null){  x_oCmd.Parameters.Add("@ord_place_by", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ord_place_by", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.ord_place_by; }
                if(x_oMobileRetentionPreviousOrder.cancel_renew==null){  x_oCmd.Parameters.Add("@cancel_renew", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cancel_renew", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.cancel_renew; }
                if(x_oMobileRetentionPreviousOrder.preferred_languages==null){  x_oCmd.Parameters.Add("@preferred_languages", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@preferred_languages", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionPreviousOrder.preferred_languages; }
                if(x_oMobileRetentionPreviousOrder.hkid==null){  x_oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionPreviousOrder.hkid; }
                if(x_oMobileRetentionPreviousOrder.card_holder==null){  x_oCmd.Parameters.Add("@card_holder", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@card_holder", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.card_holder; }
                if(x_oMobileRetentionPreviousOrder.ac_no==null){  x_oCmd.Parameters.Add("@ac_no", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ac_no", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionPreviousOrder.ac_no; }
                if(x_oMobileRetentionPreviousOrder.bill_cut_num==null){  x_oCmd.Parameters.Add("@bill_cut_num", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bill_cut_num", global::System.Data.SqlDbType.Int).Value=x_oMobileRetentionPreviousOrder.bill_cut_num; }
                if(x_oMobileRetentionPreviousOrder.premium==null){  x_oCmd.Parameters.Add("@premium", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@premium", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.premium; }
                if(x_oMobileRetentionPreviousOrder.del_remark==null){  x_oCmd.Parameters.Add("@del_remark", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@del_remark", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.del_remark; }
                if(x_oMobileRetentionPreviousOrder.gift_imei2==null){  x_oCmd.Parameters.Add("@gift_imei2", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_imei2", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.gift_imei2; }
                if(x_oMobileRetentionPreviousOrder.reasons==null){  x_oCmd.Parameters.Add("@reasons", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@reasons", global::System.Data.SqlDbType.Text).Value=x_oMobileRetentionPreviousOrder.reasons; }
                if(x_oMobileRetentionPreviousOrder.language==null){  x_oCmd.Parameters.Add("@language", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@language", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.language; }
                if(x_oMobileRetentionPreviousOrder.rebate_amount==null){  x_oCmd.Parameters.Add("@rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.rebate_amount; }
                if(x_oMobileRetentionPreviousOrder.ord_place_id_type==null){  x_oCmd.Parameters.Add("@ord_place_id_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ord_place_id_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.ord_place_id_type; }
                if(x_oMobileRetentionPreviousOrder.m_3rd_contact_no==null){  x_oCmd.Parameters.Add("@m_3rd_contact_no", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_3rd_contact_no", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionPreviousOrder.m_3rd_contact_no; }
                if(x_oMobileRetentionPreviousOrder.staff_no==null){  x_oCmd.Parameters.Add("@staff_no", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@staff_no", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.staff_no; }
                if(x_oMobileRetentionPreviousOrder.sp_d_date==null){  x_oCmd.Parameters.Add("@sp_d_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@sp_d_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionPreviousOrder.sp_d_date; }
                if(x_oMobileRetentionPreviousOrder.bundle_name==null){  x_oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.bundle_name; }
                if(x_oMobileRetentionPreviousOrder.accessory_waive==null){  x_oCmd.Parameters.Add("@accessory_waive", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@accessory_waive", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionPreviousOrder.accessory_waive; }
                if(x_oMobileRetentionPreviousOrder.sim_item_code==null){  x_oCmd.Parameters.Add("@sim_item_code", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sim_item_code", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.sim_item_code; }
                if(x_oMobileRetentionPreviousOrder.cust_type==null){  x_oCmd.Parameters.Add("@cust_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cust_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.cust_type; }
                if(x_oMobileRetentionPreviousOrder.card_ref_no==null){  x_oCmd.Parameters.Add("@card_ref_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@card_ref_no", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.card_ref_no; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                _bResult = Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
            }
            catch {  }
            finally
            {
                if (!x_oDB.bTransaction)
                {
                    x_oConn.Close();
                    x_oCmd.Dispose();
                    x_oConn.Dispose();
                }
            }
            return _bResult;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,string x_sGift_imei,string x_sS_premium4,string x_sGift_desc4,string x_sAccessory_desc,string x_sAction_required,global::System.Nullable<long> x_lRegistered_address_his_id,global::System.Nullable<DateTime> x_dVas_eff_date,string x_sMonthly_bank_account_bank_code,string x_sSpecial_handling_dummy_code,string x_sM_card_exp_year,string x_sRemarks2PY,string x_sTrade_field,string x_sOrd_place_tel,string x_sOrd_place_id_type,string x_sCooling_offer,global::System.Nullable<int> x_iRec_no,string x_sUpgrade_handset_offer_rebate_schedule,string x_sChange_payment_type,global::System.Nullable<DateTime> x_dDate_of_birth,string x_sContact_person,string x_sExtra_d_charge,string x_sTl_name,global::System.Nullable<bool> x_bFast_start,string x_sSp_ref_no,global::System.Nullable<DateTime> x_dEdate,string x_sExist_cust_plan,string x_sOrd_place_rel,global::System.Nullable<int> x_iMrt_no,string x_sImei_no,string x_sExisting_smart_phone_model,string x_sGift_code3,string x_sBank_code,string x_sPos_ref_no,global::System.Nullable<DateTime> x_dBill_cut_date,string x_sGift_imei3,string x_sExist_plan,global::System.Nullable<bool> x_bWaive,string x_sProgram,string x_sFirst_month_fee,string x_sR_offer,string x_sCid,string x_sDid,string x_sFtg_tenure,string x_sCon_per,string x_sGift_code4,string x_sEasywatch_type,string x_sSms_mrt,global::System.Nullable<long> x_lTpy_his_id,string x_sMonthly_payment_method,string x_sRemarks2EDF,string x_sGift_desc3,string x_sGift_imei4,global::System.Nullable<int> x_iOld_ord_id,string x_sMonthly_bank_account_hkid2,global::System.Nullable<DateTime> x_dD_date,string x_sGift_desc,string x_sSalesmancode,string x_sPool,global::System.Nullable<long> x_lCn_mrt_no,string x_sAccessory_imei,string x_sThird_party_credit_card,string x_sCard_ref_no,global::System.Nullable<DateTime> x_dCooling_date,string x_sSpecial_approval,global::System.Nullable<DateTime> x_dUpgrade_existing_contract_edate,string x_sAccessory_code,string x_sBill_medium,string x_sS_premium,string x_sRef_staff_no,string x_sAccessory_price,string x_sM_card_exp_month,string x_sInstallment_period,string x_sM_card_type,string x_sEasywatch_ord_id,global::System.Nullable<bool> x_bNormal_rebate,string x_sM_rebate_amount,string x_sM_card_holder2,string x_sBill_medium_email,global::System.Nullable<bool> x_bActive,string x_sS_premium1,string x_sCard_exp_month,string x_sOb_program_id,string x_sSku,string x_sRef_salesmancode,string x_sGo_wireless_package_code,string x_sThird_party_hkid,string x_sUpgrade_existing_pccw_customer,string x_sD_address,string x_sUpgrade_registered_mobile_no,string x_sUpgrade_existing_customer_type,string x_sNormal_rebate_type,string x_sGift_desc2,string x_sMonthly_bank_account_branch_code,string x_sRemarks,string x_sAccept,string x_sDelivery_exchange,string x_sGift_code2,global::System.Nullable<bool> x_bPrepayment_waive,string x_sExisting_smart_phone_imei,global::System.Nullable<long> x_lMnp_his_id,string x_sCust_name,string x_sCust_type,string x_sUpgrade_sponsorships_amount,global::System.Nullable<bool> x_bBill_medium_waive,string x_sDelivery_exchange_location,global::System.Nullable<int> x_iHs_offer_type_id,string x_sOrg_fee,string x_sRebate,string x_sUpgrade_type,string x_sGo_wireless,string x_sExtra_rebate,string x_sPlan_eff,string x_sExtra_rebate_amount,string x_sCard_exp_year,global::System.Nullable<DateTime> x_dUpgrade_existing_contract_sdate,string x_sOrd_place_hkid,string x_sRegister_address,string x_sGender,string x_sLob_ac,global::System.Nullable<int> x_iSim_mrt_no,string x_sRedemption_notice_option,string x_sDelivery_collection_type,global::System.Nullable<DateTime> x_dAction_date,string x_sThird_party_id_type,string x_sOrg_ftg,string x_sUpgrade_service_tenure,string x_sMonthly_payment_type,string x_sContact_no,global::System.Nullable<int> x_iOrg_mrt,string x_sSim_item_name,string x_sPay_method,string x_sHs_model,string x_sGift_code,string x_sMonthly_bank_account_hkid,string x_sExtra_offer,string x_sMonthly_bank_account_no,string x_sFirst_month_license_fee,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dDdate,string x_sS_premium2,string x_sMonthly_bank_account_id_type,string x_sCard_type,global::System.Nullable<bool> x_bNext_bill,global::System.Nullable<bool> x_bPcd_paid_go_wireless,string x_sUpgrade_rebate_calculation,string x_sExt_place_tel,string x_sM_3rd_hkid,string x_sRetention_type,global::System.Nullable<long> x_lBill_address_his_id,string x_sAig_gift,string x_sCust_staff_no,string x_sFamily_name,global::System.Nullable<DateTime> x_dCdate,string x_sStatus_by_cs_admin,string x_sSim_item_number,string x_sVip_case,string x_sGiven_name,global::System.Nullable<DateTime> x_dLog_date,string x_sExtn,string x_sD_time,string x_sBank_name,string x_sDelivery_exchange_option,string x_sUpgrade_service_account_no,string x_sAction_of_rate_plan_effective,string x_sM_card_no,string x_sExisting_contract_end_date,global::System.Nullable<DateTime> x_dCon_eff_date,string x_sM_3rd_hkid2,string x_sAmount,string x_sId_type,string x_sRate_plan,string x_sChannel,global::System.Nullable<DateTime> x_dAction_eff_date,string x_sIssue_type,string x_sFree_mon,global::System.Nullable<DateTime> x_dPlan_eff_date,string x_sDel_remark,string x_sTeamcode,string x_sStaff_name,string x_sEdf_no,string x_sOrd_place_by,string x_sCancel_renew,string x_sPreferred_languages,string x_sHkid,string x_sCard_no,string x_sAc_no,global::System.Nullable<int> x_iBill_cut_num,string x_sPremium,string x_sM_3rd_id_type,string x_sGift_imei2,string x_sReasons,string x_sLanguage,string x_sRebate_amount,string x_sLob,string x_sM_3rd_contact_no,string x_sStaff_no,string x_sS_premium3,global::System.Nullable<DateTime> x_dSp_d_date,string x_sBundle_name,global::System.Nullable<bool> x_bAccessory_waive,string x_sSim_item_code,string x_sMonthly_bank_account_holder,string x_sCard_holder)
        {
            int _oLastID;
            MobileRetentionPreviousOrder _oMobileRetentionPreviousOrder=MobileRetentionPreviousOrderRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileRetentionPreviousOrder.gift_imei=x_sGift_imei;
            _oMobileRetentionPreviousOrder.s_premium4=x_sS_premium4;
            _oMobileRetentionPreviousOrder.gift_desc4=x_sGift_desc4;
            _oMobileRetentionPreviousOrder.accessory_desc=x_sAccessory_desc;
            _oMobileRetentionPreviousOrder.action_required=x_sAction_required;
            _oMobileRetentionPreviousOrder.registered_address_his_id=x_lRegistered_address_his_id;
            _oMobileRetentionPreviousOrder.vas_eff_date=x_dVas_eff_date;
            _oMobileRetentionPreviousOrder.monthly_bank_account_bank_code=x_sMonthly_bank_account_bank_code;
            _oMobileRetentionPreviousOrder.special_handling_dummy_code=x_sSpecial_handling_dummy_code;
            _oMobileRetentionPreviousOrder.m_card_exp_year=x_sM_card_exp_year;
            _oMobileRetentionPreviousOrder.remarks2PY=x_sRemarks2PY;
            _oMobileRetentionPreviousOrder.trade_field=x_sTrade_field;
            _oMobileRetentionPreviousOrder.ord_place_tel=x_sOrd_place_tel;
            _oMobileRetentionPreviousOrder.ord_place_id_type=x_sOrd_place_id_type;
            _oMobileRetentionPreviousOrder.cooling_offer=x_sCooling_offer;
            _oMobileRetentionPreviousOrder.rec_no=x_iRec_no;
            _oMobileRetentionPreviousOrder.upgrade_handset_offer_rebate_schedule=x_sUpgrade_handset_offer_rebate_schedule;
            _oMobileRetentionPreviousOrder.change_payment_type=x_sChange_payment_type;
            _oMobileRetentionPreviousOrder.date_of_birth=x_dDate_of_birth;
            _oMobileRetentionPreviousOrder.contact_person=x_sContact_person;
            _oMobileRetentionPreviousOrder.extra_d_charge=x_sExtra_d_charge;
            _oMobileRetentionPreviousOrder.tl_name=x_sTl_name;
            _oMobileRetentionPreviousOrder.fast_start=x_bFast_start;
            _oMobileRetentionPreviousOrder.sp_ref_no=x_sSp_ref_no;
            _oMobileRetentionPreviousOrder.edate=x_dEdate;
            _oMobileRetentionPreviousOrder.exist_cust_plan=x_sExist_cust_plan;
            _oMobileRetentionPreviousOrder.ord_place_rel=x_sOrd_place_rel;
            _oMobileRetentionPreviousOrder.mrt_no=x_iMrt_no;
            _oMobileRetentionPreviousOrder.imei_no=x_sImei_no;
            _oMobileRetentionPreviousOrder.existing_smart_phone_model=x_sExisting_smart_phone_model;
            _oMobileRetentionPreviousOrder.gift_code3=x_sGift_code3;
            _oMobileRetentionPreviousOrder.bank_code=x_sBank_code;
            _oMobileRetentionPreviousOrder.pos_ref_no=x_sPos_ref_no;
            _oMobileRetentionPreviousOrder.bill_cut_date=x_dBill_cut_date;
            _oMobileRetentionPreviousOrder.gift_imei3=x_sGift_imei3;
            _oMobileRetentionPreviousOrder.exist_plan=x_sExist_plan;
            _oMobileRetentionPreviousOrder.waive=x_bWaive;
            _oMobileRetentionPreviousOrder.program=x_sProgram;
            _oMobileRetentionPreviousOrder.first_month_fee=x_sFirst_month_fee;
            _oMobileRetentionPreviousOrder.r_offer=x_sR_offer;
            _oMobileRetentionPreviousOrder.cid=x_sCid;
            _oMobileRetentionPreviousOrder.did=x_sDid;
            _oMobileRetentionPreviousOrder.ftg_tenure=x_sFtg_tenure;
            _oMobileRetentionPreviousOrder.con_per=x_sCon_per;
            _oMobileRetentionPreviousOrder.gift_code4=x_sGift_code4;
            _oMobileRetentionPreviousOrder.easywatch_type=x_sEasywatch_type;
            _oMobileRetentionPreviousOrder.sms_mrt=x_sSms_mrt;
            _oMobileRetentionPreviousOrder.tpy_his_id=x_lTpy_his_id;
            _oMobileRetentionPreviousOrder.monthly_payment_method=x_sMonthly_payment_method;
            _oMobileRetentionPreviousOrder.remarks2EDF=x_sRemarks2EDF;
            _oMobileRetentionPreviousOrder.gift_desc3=x_sGift_desc3;
            _oMobileRetentionPreviousOrder.gift_imei4=x_sGift_imei4;
            _oMobileRetentionPreviousOrder.old_ord_id=x_iOld_ord_id;
            _oMobileRetentionPreviousOrder.monthly_bank_account_hkid2=x_sMonthly_bank_account_hkid2;
            _oMobileRetentionPreviousOrder.d_date=x_dD_date;
            _oMobileRetentionPreviousOrder.gift_desc=x_sGift_desc;
            _oMobileRetentionPreviousOrder.salesmancode=x_sSalesmancode;
            _oMobileRetentionPreviousOrder.pool=x_sPool;
            _oMobileRetentionPreviousOrder.cn_mrt_no=x_lCn_mrt_no;
            _oMobileRetentionPreviousOrder.accessory_imei=x_sAccessory_imei;
            _oMobileRetentionPreviousOrder.third_party_credit_card=x_sThird_party_credit_card;
            _oMobileRetentionPreviousOrder.card_ref_no=x_sCard_ref_no;
            _oMobileRetentionPreviousOrder.cooling_date=x_dCooling_date;
            _oMobileRetentionPreviousOrder.special_approval=x_sSpecial_approval;
            _oMobileRetentionPreviousOrder.upgrade_existing_contract_edate=x_dUpgrade_existing_contract_edate;
            _oMobileRetentionPreviousOrder.accessory_code=x_sAccessory_code;
            _oMobileRetentionPreviousOrder.bill_medium=x_sBill_medium;
            _oMobileRetentionPreviousOrder.s_premium=x_sS_premium;
            _oMobileRetentionPreviousOrder.ref_staff_no=x_sRef_staff_no;
            _oMobileRetentionPreviousOrder.accessory_price=x_sAccessory_price;
            _oMobileRetentionPreviousOrder.m_card_exp_month=x_sM_card_exp_month;
            _oMobileRetentionPreviousOrder.installment_period=x_sInstallment_period;
            _oMobileRetentionPreviousOrder.m_card_type=x_sM_card_type;
            _oMobileRetentionPreviousOrder.easywatch_ord_id=x_sEasywatch_ord_id;
            _oMobileRetentionPreviousOrder.normal_rebate=x_bNormal_rebate;
            _oMobileRetentionPreviousOrder.m_rebate_amount=x_sM_rebate_amount;
            _oMobileRetentionPreviousOrder.m_card_holder2=x_sM_card_holder2;
            _oMobileRetentionPreviousOrder.bill_medium_email=x_sBill_medium_email;
            _oMobileRetentionPreviousOrder.active=x_bActive;
            _oMobileRetentionPreviousOrder.s_premium1=x_sS_premium1;
            _oMobileRetentionPreviousOrder.card_exp_month=x_sCard_exp_month;
            _oMobileRetentionPreviousOrder.ob_program_id=x_sOb_program_id;
            _oMobileRetentionPreviousOrder.sku=x_sSku;
            _oMobileRetentionPreviousOrder.ref_salesmancode=x_sRef_salesmancode;
            _oMobileRetentionPreviousOrder.go_wireless_package_code=x_sGo_wireless_package_code;
            _oMobileRetentionPreviousOrder.third_party_hkid=x_sThird_party_hkid;
            _oMobileRetentionPreviousOrder.upgrade_existing_pccw_customer=x_sUpgrade_existing_pccw_customer;
            _oMobileRetentionPreviousOrder.d_address=x_sD_address;
            _oMobileRetentionPreviousOrder.upgrade_registered_mobile_no=x_sUpgrade_registered_mobile_no;
            _oMobileRetentionPreviousOrder.upgrade_existing_customer_type=x_sUpgrade_existing_customer_type;
            _oMobileRetentionPreviousOrder.normal_rebate_type=x_sNormal_rebate_type;
            _oMobileRetentionPreviousOrder.gift_desc2=x_sGift_desc2;
            _oMobileRetentionPreviousOrder.monthly_bank_account_branch_code=x_sMonthly_bank_account_branch_code;
            _oMobileRetentionPreviousOrder.remarks=x_sRemarks;
            _oMobileRetentionPreviousOrder.accept=x_sAccept;
            _oMobileRetentionPreviousOrder.delivery_exchange=x_sDelivery_exchange;
            _oMobileRetentionPreviousOrder.gift_code2=x_sGift_code2;
            _oMobileRetentionPreviousOrder.prepayment_waive=x_bPrepayment_waive;
            _oMobileRetentionPreviousOrder.existing_smart_phone_imei=x_sExisting_smart_phone_imei;
            _oMobileRetentionPreviousOrder.mnp_his_id=x_lMnp_his_id;
            _oMobileRetentionPreviousOrder.cust_name=x_sCust_name;
            _oMobileRetentionPreviousOrder.cust_type=x_sCust_type;
            _oMobileRetentionPreviousOrder.upgrade_sponsorships_amount=x_sUpgrade_sponsorships_amount;
            _oMobileRetentionPreviousOrder.bill_medium_waive=x_bBill_medium_waive;
            _oMobileRetentionPreviousOrder.delivery_exchange_location=x_sDelivery_exchange_location;
            _oMobileRetentionPreviousOrder.hs_offer_type_id=x_iHs_offer_type_id;
            _oMobileRetentionPreviousOrder.org_fee=x_sOrg_fee;
            _oMobileRetentionPreviousOrder.rebate=x_sRebate;
            _oMobileRetentionPreviousOrder.upgrade_type=x_sUpgrade_type;
            _oMobileRetentionPreviousOrder.go_wireless=x_sGo_wireless;
            _oMobileRetentionPreviousOrder.extra_rebate=x_sExtra_rebate;
            _oMobileRetentionPreviousOrder.plan_eff=x_sPlan_eff;
            _oMobileRetentionPreviousOrder.extra_rebate_amount=x_sExtra_rebate_amount;
            _oMobileRetentionPreviousOrder.card_exp_year=x_sCard_exp_year;
            _oMobileRetentionPreviousOrder.upgrade_existing_contract_sdate=x_dUpgrade_existing_contract_sdate;
            _oMobileRetentionPreviousOrder.ord_place_hkid=x_sOrd_place_hkid;
            _oMobileRetentionPreviousOrder.register_address=x_sRegister_address;
            _oMobileRetentionPreviousOrder.gender=x_sGender;
            _oMobileRetentionPreviousOrder.lob_ac=x_sLob_ac;
            _oMobileRetentionPreviousOrder.sim_mrt_no=x_iSim_mrt_no;
            _oMobileRetentionPreviousOrder.redemption_notice_option=x_sRedemption_notice_option;
            _oMobileRetentionPreviousOrder.delivery_collection_type=x_sDelivery_collection_type;
            _oMobileRetentionPreviousOrder.action_date=x_dAction_date;
            _oMobileRetentionPreviousOrder.third_party_id_type=x_sThird_party_id_type;
            _oMobileRetentionPreviousOrder.org_ftg=x_sOrg_ftg;
            _oMobileRetentionPreviousOrder.upgrade_service_tenure=x_sUpgrade_service_tenure;
            _oMobileRetentionPreviousOrder.monthly_payment_type=x_sMonthly_payment_type;
            _oMobileRetentionPreviousOrder.contact_no=x_sContact_no;
            _oMobileRetentionPreviousOrder.org_mrt=x_iOrg_mrt;
            _oMobileRetentionPreviousOrder.sim_item_name=x_sSim_item_name;
            _oMobileRetentionPreviousOrder.pay_method=x_sPay_method;
            _oMobileRetentionPreviousOrder.hs_model=x_sHs_model;
            _oMobileRetentionPreviousOrder.gift_code=x_sGift_code;
            _oMobileRetentionPreviousOrder.monthly_bank_account_hkid=x_sMonthly_bank_account_hkid;
            _oMobileRetentionPreviousOrder.extra_offer=x_sExtra_offer;
            _oMobileRetentionPreviousOrder.monthly_bank_account_no=x_sMonthly_bank_account_no;
            _oMobileRetentionPreviousOrder.first_month_license_fee=x_sFirst_month_license_fee;
            _oMobileRetentionPreviousOrder.retrieve_cnt=x_iRetrieve_cnt;
            _oMobileRetentionPreviousOrder.ddate=x_dDdate;
            _oMobileRetentionPreviousOrder.s_premium2=x_sS_premium2;
            _oMobileRetentionPreviousOrder.monthly_bank_account_id_type=x_sMonthly_bank_account_id_type;
            _oMobileRetentionPreviousOrder.card_type=x_sCard_type;
            _oMobileRetentionPreviousOrder.next_bill=x_bNext_bill;
            _oMobileRetentionPreviousOrder.pcd_paid_go_wireless=x_bPcd_paid_go_wireless;
            _oMobileRetentionPreviousOrder.upgrade_rebate_calculation=x_sUpgrade_rebate_calculation;
            _oMobileRetentionPreviousOrder.ext_place_tel=x_sExt_place_tel;
            _oMobileRetentionPreviousOrder.m_3rd_hkid=x_sM_3rd_hkid;
            _oMobileRetentionPreviousOrder.retention_type=x_sRetention_type;
            _oMobileRetentionPreviousOrder.bill_address_his_id=x_lBill_address_his_id;
            _oMobileRetentionPreviousOrder.aig_gift=x_sAig_gift;
            _oMobileRetentionPreviousOrder.cust_staff_no=x_sCust_staff_no;
            _oMobileRetentionPreviousOrder.family_name=x_sFamily_name;
            _oMobileRetentionPreviousOrder.cdate=x_dCdate;
            _oMobileRetentionPreviousOrder.status_by_cs_admin=x_sStatus_by_cs_admin;
            _oMobileRetentionPreviousOrder.sim_item_number=x_sSim_item_number;
            _oMobileRetentionPreviousOrder.vip_case=x_sVip_case;
            _oMobileRetentionPreviousOrder.given_name=x_sGiven_name;
            _oMobileRetentionPreviousOrder.log_date=x_dLog_date;
            _oMobileRetentionPreviousOrder.extn=x_sExtn;
            _oMobileRetentionPreviousOrder.d_time=x_sD_time;
            _oMobileRetentionPreviousOrder.bank_name=x_sBank_name;
            _oMobileRetentionPreviousOrder.delivery_exchange_option=x_sDelivery_exchange_option;
            _oMobileRetentionPreviousOrder.upgrade_service_account_no=x_sUpgrade_service_account_no;
            _oMobileRetentionPreviousOrder.action_of_rate_plan_effective=x_sAction_of_rate_plan_effective;
            _oMobileRetentionPreviousOrder.m_card_no=x_sM_card_no;
            _oMobileRetentionPreviousOrder.existing_contract_end_date=x_sExisting_contract_end_date;
            _oMobileRetentionPreviousOrder.con_eff_date=x_dCon_eff_date;
            _oMobileRetentionPreviousOrder.m_3rd_hkid2=x_sM_3rd_hkid2;
            _oMobileRetentionPreviousOrder.amount=x_sAmount;
            _oMobileRetentionPreviousOrder.id_type=x_sId_type;
            _oMobileRetentionPreviousOrder.rate_plan=x_sRate_plan;
            _oMobileRetentionPreviousOrder.channel=x_sChannel;
            _oMobileRetentionPreviousOrder.action_eff_date=x_dAction_eff_date;
            _oMobileRetentionPreviousOrder.issue_type=x_sIssue_type;
            _oMobileRetentionPreviousOrder.free_mon=x_sFree_mon;
            _oMobileRetentionPreviousOrder.plan_eff_date=x_dPlan_eff_date;
            _oMobileRetentionPreviousOrder.del_remark=x_sDel_remark;
            _oMobileRetentionPreviousOrder.teamcode=x_sTeamcode;
            _oMobileRetentionPreviousOrder.staff_name=x_sStaff_name;
            _oMobileRetentionPreviousOrder.edf_no=x_sEdf_no;
            _oMobileRetentionPreviousOrder.ord_place_by=x_sOrd_place_by;
            _oMobileRetentionPreviousOrder.cancel_renew=x_sCancel_renew;
            _oMobileRetentionPreviousOrder.preferred_languages=x_sPreferred_languages;
            _oMobileRetentionPreviousOrder.hkid=x_sHkid;
            _oMobileRetentionPreviousOrder.card_no=x_sCard_no;
            _oMobileRetentionPreviousOrder.ac_no=x_sAc_no;
            _oMobileRetentionPreviousOrder.bill_cut_num=x_iBill_cut_num;
            _oMobileRetentionPreviousOrder.premium=x_sPremium;
            _oMobileRetentionPreviousOrder.m_3rd_id_type=x_sM_3rd_id_type;
            _oMobileRetentionPreviousOrder.gift_imei2=x_sGift_imei2;
            _oMobileRetentionPreviousOrder.reasons=x_sReasons;
            _oMobileRetentionPreviousOrder.language=x_sLanguage;
            _oMobileRetentionPreviousOrder.rebate_amount=x_sRebate_amount;
            _oMobileRetentionPreviousOrder.lob=x_sLob;
            _oMobileRetentionPreviousOrder.m_3rd_contact_no=x_sM_3rd_contact_no;
            _oMobileRetentionPreviousOrder.staff_no=x_sStaff_no;
            _oMobileRetentionPreviousOrder.s_premium3=x_sS_premium3;
            _oMobileRetentionPreviousOrder.sp_d_date=x_dSp_d_date;
            _oMobileRetentionPreviousOrder.bundle_name=x_sBundle_name;
            _oMobileRetentionPreviousOrder.accessory_waive=x_bAccessory_waive;
            _oMobileRetentionPreviousOrder.sim_item_code=x_sSim_item_code;
            _oMobileRetentionPreviousOrder.monthly_bank_account_holder=x_sMonthly_bank_account_holder;
            _oMobileRetentionPreviousOrder.card_holder=x_sCard_holder;
            if(InsertWithLastID(x_oDB, _oMobileRetentionPreviousOrder,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(MobileRetentionPreviousOrder x_oMobileRetentionPreviousOrder)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oMobileRetentionPreviousOrder, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, MobileRetentionPreviousOrder x_oMobileRetentionPreviousOrder)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oMobileRetentionPreviousOrder, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileRetentionPreviousOrder)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (MobileRetentionPreviousOrder)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,MobileRetentionPreviousOrder x_oMobileRetentionPreviousOrder, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileRetentionPreviousOrder]   ([gift_imei],[s_premium4],[upgrade_existing_customer_type],[gift_desc4],[accessory_desc],[staff_name],[action_required],[registered_address_his_id],[vas_eff_date],[monthly_bank_account_bank_code],[sim_item_number],[special_handling_dummy_code],[card_no],[m_card_exp_year],[bill_medium_email],[remarks2PY],[trade_field],[ord_place_tel],[action_of_rate_plan_effective],[cooling_offer],[rec_no],[upgrade_handset_offer_rebate_schedule],[change_payment_type],[date_of_birth],[contact_person],[extra_d_charge],[tl_name],[fast_start],[issue_type],[sp_ref_no],[edate],[exist_cust_plan],[ord_place_rel],[mrt_no],[imei_no],[existing_smart_phone_model],[bank_code],[pos_ref_no],[bill_cut_date],[gift_imei3],[exist_plan],[waive],[program],[first_month_fee],[r_offer],[cid],[did],[ftg_tenure],[con_per],[gift_code4],[easywatch_type],[sms_mrt],[tpy_his_id],[monthly_payment_method],[remarks2EDF],[gift_desc3],[gift_imei4],[monthly_bank_account_hkid2],[d_date],[gift_desc],[pool],[cn_mrt_no],[accessory_imei],[third_party_credit_card],[special_approval],[upgrade_existing_contract_edate],[accessory_code],[s_premium],[ref_staff_no],[accessory_price],[m_card_exp_month],[installment_period],[m_card_type],[easywatch_ord_id],[normal_rebate],[m_rebate_amount],[m_card_holder2],[monthly_bank_account_holder],[active],[s_premium1],[card_exp_month],[ob_program_id],[sku],[salesmancode],[go_wireless_package_code],[lob],[ref_salesmancode],[third_party_hkid],[upgrade_existing_pccw_customer],[d_address],[upgrade_registered_mobile_no],[gift_code3],[normal_rebate_type],[gift_desc2],[monthly_bank_account_branch_code],[remarks],[accept],[delivery_exchange],[gift_code2],[prepayment_waive],[existing_smart_phone_imei],[mnp_his_id],[cust_name],[upgrade_sponsorships_amount],[bill_medium_waive],[delivery_exchange_location],[hs_offer_type_id],[org_fee],[rebate],[upgrade_type],[go_wireless],[extra_rebate],[plan_eff],[extra_rebate_amount],[card_exp_year],[upgrade_existing_contract_sdate],[ord_place_hkid],[register_address],[gender],[lob_ac],[sim_mrt_no],[redemption_notice_option],[delivery_collection_type],[action_date],[third_party_id_type],[org_ftg],[upgrade_service_tenure],[monthly_payment_type],[contact_no],[org_mrt],[sim_item_name],[pay_method],[hs_model],[gift_code],[monthly_bank_account_hkid],[extra_offer],[monthly_bank_account_no],[first_month_license_fee],[retrieve_cnt],[ddate],[s_premium2],[monthly_bank_account_id_type],[card_type],[next_bill],[pcd_paid_go_wireless],[upgrade_rebate_calculation],[ext_place_tel],[m_3rd_hkid],[retention_type],[bill_address_his_id],[aig_gift],[cust_staff_no],[family_name],[cdate],[status_by_cs_admin],[given_name],[vip_case],[s_premium3],[log_date],[extn],[d_time],[bank_name],[delivery_exchange_option],[upgrade_service_account_no],[old_ord_id],[m_card_no],[existing_contract_end_date],[con_eff_date],[m_3rd_hkid2],[amount],[m_3rd_id_type],[id_type],[rate_plan],[channel],[action_eff_date],[cooling_date],[free_mon],[plan_eff_date],[teamcode],[bill_medium],[edf_no],[ord_place_by],[cancel_renew],[preferred_languages],[hkid],[card_holder],[ac_no],[bill_cut_num],[premium],[del_remark],[gift_imei2],[reasons],[language],[rebate_amount],[ord_place_id_type],[m_3rd_contact_no],[staff_no],[sp_d_date],[bundle_name],[accessory_waive],[sim_item_code],[cust_type],[card_ref_no])  VALUES  (@gift_imei,@s_premium4,@upgrade_existing_customer_type,@gift_desc4,@accessory_desc,@staff_name,@action_required,@registered_address_his_id,@vas_eff_date,@monthly_bank_account_bank_code,@sim_item_number,@special_handling_dummy_code,@card_no,@m_card_exp_year,@bill_medium_email,@remarks2PY,@trade_field,@ord_place_tel,@action_of_rate_plan_effective,@cooling_offer,@rec_no,@upgrade_handset_offer_rebate_schedule,@change_payment_type,@date_of_birth,@contact_person,@extra_d_charge,@tl_name,@fast_start,@issue_type,@sp_ref_no,@edate,@exist_cust_plan,@ord_place_rel,@mrt_no,@imei_no,@existing_smart_phone_model,@bank_code,@pos_ref_no,@bill_cut_date,@gift_imei3,@exist_plan,@waive,@program,@first_month_fee,@r_offer,@cid,@did,@ftg_tenure,@con_per,@gift_code4,@easywatch_type,@sms_mrt,@tpy_his_id,@monthly_payment_method,@remarks2EDF,@gift_desc3,@gift_imei4,@monthly_bank_account_hkid2,@d_date,@gift_desc,@pool,@cn_mrt_no,@accessory_imei,@third_party_credit_card,@special_approval,@upgrade_existing_contract_edate,@accessory_code,@s_premium,@ref_staff_no,@accessory_price,@m_card_exp_month,@installment_period,@m_card_type,@easywatch_ord_id,@normal_rebate,@m_rebate_amount,@m_card_holder2,@monthly_bank_account_holder,@active,@s_premium1,@card_exp_month,@ob_program_id,@sku,@salesmancode,@go_wireless_package_code,@lob,@ref_salesmancode,@third_party_hkid,@upgrade_existing_pccw_customer,@d_address,@upgrade_registered_mobile_no,@gift_code3,@normal_rebate_type,@gift_desc2,@monthly_bank_account_branch_code,@remarks,@accept,@delivery_exchange,@gift_code2,@prepayment_waive,@existing_smart_phone_imei,@mnp_his_id,@cust_name,@upgrade_sponsorships_amount,@bill_medium_waive,@delivery_exchange_location,@hs_offer_type_id,@org_fee,@rebate,@upgrade_type,@go_wireless,@extra_rebate,@plan_eff,@extra_rebate_amount,@card_exp_year,@upgrade_existing_contract_sdate,@ord_place_hkid,@register_address,@gender,@lob_ac,@sim_mrt_no,@redemption_notice_option,@delivery_collection_type,@action_date,@third_party_id_type,@org_ftg,@upgrade_service_tenure,@monthly_payment_type,@contact_no,@org_mrt,@sim_item_name,@pay_method,@hs_model,@gift_code,@monthly_bank_account_hkid,@extra_offer,@monthly_bank_account_no,@first_month_license_fee,@retrieve_cnt,@ddate,@s_premium2,@monthly_bank_account_id_type,@card_type,@next_bill,@pcd_paid_go_wireless,@upgrade_rebate_calculation,@ext_place_tel,@m_3rd_hkid,@retention_type,@bill_address_his_id,@aig_gift,@cust_staff_no,@family_name,@cdate,@status_by_cs_admin,@given_name,@vip_case,@s_premium3,@log_date,@extn,@d_time,@bank_name,@delivery_exchange_option,@upgrade_service_account_no,@old_ord_id,@m_card_no,@existing_contract_end_date,@con_eff_date,@m_3rd_hkid2,@amount,@m_3rd_id_type,@id_type,@rate_plan,@channel,@action_eff_date,@cooling_date,@free_mon,@plan_eff_date,@teamcode,@bill_medium,@edf_no,@ord_place_by,@cancel_renew,@preferred_languages,@hkid,@card_holder,@ac_no,@bill_cut_num,@premium,@del_remark,@gift_imei2,@reasons,@language,@rebate_amount,@ord_place_id_type,@m_3rd_contact_no,@staff_no,@sp_d_date,@bundle_name,@accessory_waive,@sim_item_code,@cust_type,@card_ref_no)"+" SELECT  @@IDENTITY AS MobileRetentionPreviousOrder_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionPreviousOrder]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionPreviousOrder]"); }
            global::System.Data.SqlClient.SqlConnection _oConn = null;
            global::System.Data.SqlClient.SqlCommand _oCmd = null;
            if (x_oDB.bTransaction)
            {
                x_oDB.ISessionCmd.CommandText = _sQuery;
                x_oDB.ISessionCmd.Parameters.Clear();
                _oCmd = x_oDB.ISessionCmd;
                _oConn = x_oDB.ISessionConn;
            }
            else
            {
                _oConn = x_oDB.GetConnection();
                _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            }
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oMobileRetentionPreviousOrder,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileRetentionPreviousOrder x_oMobileRetentionPreviousOrder, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oMobileRetentionPreviousOrder.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileRetentionPreviousOrder.gift_imei==null){  x_oCmd.Parameters.Add("@gift_imei", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_imei", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.gift_imei; }
                if(x_oMobileRetentionPreviousOrder.s_premium4==null){  x_oCmd.Parameters.Add("@s_premium4", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@s_premium4", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.s_premium4; }
                if(x_oMobileRetentionPreviousOrder.upgrade_existing_customer_type==null){  x_oCmd.Parameters.Add("@upgrade_existing_customer_type", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_existing_customer_type", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.upgrade_existing_customer_type; }
                if(x_oMobileRetentionPreviousOrder.gift_desc4==null){  x_oCmd.Parameters.Add("@gift_desc4", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_desc4", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.gift_desc4; }
                if(x_oMobileRetentionPreviousOrder.accessory_desc==null){  x_oCmd.Parameters.Add("@accessory_desc", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@accessory_desc", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.accessory_desc; }
                if(x_oMobileRetentionPreviousOrder.staff_name==null){  x_oCmd.Parameters.Add("@staff_name", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@staff_name", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.staff_name; }
                if(x_oMobileRetentionPreviousOrder.action_required==null){  x_oCmd.Parameters.Add("@action_required", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@action_required", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.action_required; }
                if(x_oMobileRetentionPreviousOrder.registered_address_his_id==null){  x_oCmd.Parameters.Add("@registered_address_his_id", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@registered_address_his_id", global::System.Data.SqlDbType.BigInt).Value=x_oMobileRetentionPreviousOrder.registered_address_his_id; }
                if(x_oMobileRetentionPreviousOrder.vas_eff_date==null){  x_oCmd.Parameters.Add("@vas_eff_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@vas_eff_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionPreviousOrder.vas_eff_date; }
                if(x_oMobileRetentionPreviousOrder.monthly_bank_account_bank_code==null){  x_oCmd.Parameters.Add("@monthly_bank_account_bank_code", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_bank_account_bank_code", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.monthly_bank_account_bank_code; }
                if(x_oMobileRetentionPreviousOrder.sim_item_number==null){  x_oCmd.Parameters.Add("@sim_item_number", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sim_item_number", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.sim_item_number; }
                if(x_oMobileRetentionPreviousOrder.special_handling_dummy_code==null){  x_oCmd.Parameters.Add("@special_handling_dummy_code", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@special_handling_dummy_code", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.special_handling_dummy_code; }
                if(x_oMobileRetentionPreviousOrder.card_no==null){  x_oCmd.Parameters.Add("@card_no", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@card_no", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionPreviousOrder.card_no; }
                if(x_oMobileRetentionPreviousOrder.m_card_exp_year==null){  x_oCmd.Parameters.Add("@m_card_exp_year", global::System.Data.SqlDbType.NVarChar,4).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_card_exp_year", global::System.Data.SqlDbType.NVarChar,4).Value=x_oMobileRetentionPreviousOrder.m_card_exp_year; }
                if(x_oMobileRetentionPreviousOrder.bill_medium_email==null){  x_oCmd.Parameters.Add("@bill_medium_email", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bill_medium_email", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.bill_medium_email; }
                if(x_oMobileRetentionPreviousOrder.remarks2PY==null){  x_oCmd.Parameters.Add("@remarks2PY", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@remarks2PY", global::System.Data.SqlDbType.Text).Value=x_oMobileRetentionPreviousOrder.remarks2PY; }
                if(x_oMobileRetentionPreviousOrder.trade_field==null){  x_oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.trade_field; }
                if(x_oMobileRetentionPreviousOrder.ord_place_tel==null){  x_oCmd.Parameters.Add("@ord_place_tel", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ord_place_tel", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.ord_place_tel; }
                if(x_oMobileRetentionPreviousOrder.action_of_rate_plan_effective==null){  x_oCmd.Parameters.Add("@action_of_rate_plan_effective", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@action_of_rate_plan_effective", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.action_of_rate_plan_effective; }
                if(x_oMobileRetentionPreviousOrder.cooling_offer==null){  x_oCmd.Parameters.Add("@cooling_offer", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cooling_offer", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.cooling_offer; }
                if(x_oMobileRetentionPreviousOrder.rec_no==null){  x_oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int).Value=x_oMobileRetentionPreviousOrder.rec_no; }
                if(x_oMobileRetentionPreviousOrder.upgrade_handset_offer_rebate_schedule==null){  x_oCmd.Parameters.Add("@upgrade_handset_offer_rebate_schedule", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_handset_offer_rebate_schedule", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.upgrade_handset_offer_rebate_schedule; }
                if(x_oMobileRetentionPreviousOrder.change_payment_type==null){  x_oCmd.Parameters.Add("@change_payment_type", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@change_payment_type", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionPreviousOrder.change_payment_type; }
                if(x_oMobileRetentionPreviousOrder.date_of_birth==null){  x_oCmd.Parameters.Add("@date_of_birth", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@date_of_birth", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionPreviousOrder.date_of_birth; }
                if(x_oMobileRetentionPreviousOrder.contact_person==null){  x_oCmd.Parameters.Add("@contact_person", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@contact_person", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.contact_person; }
                if(x_oMobileRetentionPreviousOrder.extra_d_charge==null){  x_oCmd.Parameters.Add("@extra_d_charge", global::System.Data.SqlDbType.NVarChar,5).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@extra_d_charge", global::System.Data.SqlDbType.NVarChar,5).Value=x_oMobileRetentionPreviousOrder.extra_d_charge; }
                if(x_oMobileRetentionPreviousOrder.tl_name==null){  x_oCmd.Parameters.Add("@tl_name", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@tl_name", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.tl_name; }
                if(x_oMobileRetentionPreviousOrder.fast_start==null){  x_oCmd.Parameters.Add("@fast_start", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fast_start", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionPreviousOrder.fast_start; }
                if(x_oMobileRetentionPreviousOrder.issue_type==null){  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.issue_type; }
                if(x_oMobileRetentionPreviousOrder.sp_ref_no==null){  x_oCmd.Parameters.Add("@sp_ref_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sp_ref_no", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.sp_ref_no; }
                if(x_oMobileRetentionPreviousOrder.edate==null){  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionPreviousOrder.edate; }
                if(x_oMobileRetentionPreviousOrder.exist_cust_plan==null){  x_oCmd.Parameters.Add("@exist_cust_plan", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@exist_cust_plan", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.exist_cust_plan; }
                if(x_oMobileRetentionPreviousOrder.ord_place_rel==null){  x_oCmd.Parameters.Add("@ord_place_rel", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ord_place_rel", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.ord_place_rel; }
                if(x_oMobileRetentionPreviousOrder.mrt_no==null){  x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.Int).Value=x_oMobileRetentionPreviousOrder.mrt_no; }
                if(x_oMobileRetentionPreviousOrder.imei_no==null){  x_oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionPreviousOrder.imei_no; }
                if(x_oMobileRetentionPreviousOrder.existing_smart_phone_model==null){  x_oCmd.Parameters.Add("@existing_smart_phone_model", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@existing_smart_phone_model", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.existing_smart_phone_model; }
                if(x_oMobileRetentionPreviousOrder.bank_code==null){  x_oCmd.Parameters.Add("@bank_code", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bank_code", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionPreviousOrder.bank_code; }
                if(x_oMobileRetentionPreviousOrder.pos_ref_no==null){  x_oCmd.Parameters.Add("@pos_ref_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@pos_ref_no", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.pos_ref_no; }
                if(x_oMobileRetentionPreviousOrder.bill_cut_date==null){  x_oCmd.Parameters.Add("@bill_cut_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@bill_cut_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionPreviousOrder.bill_cut_date; }
                if(x_oMobileRetentionPreviousOrder.gift_imei3==null){  x_oCmd.Parameters.Add("@gift_imei3", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_imei3", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.gift_imei3; }
                if(x_oMobileRetentionPreviousOrder.exist_plan==null){  x_oCmd.Parameters.Add("@exist_plan", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@exist_plan", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.exist_plan; }
                if(x_oMobileRetentionPreviousOrder.waive==null){  x_oCmd.Parameters.Add("@waive", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@waive", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionPreviousOrder.waive; }
                if(x_oMobileRetentionPreviousOrder.program==null){  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.program; }
                if(x_oMobileRetentionPreviousOrder.first_month_fee==null){  x_oCmd.Parameters.Add("@first_month_fee", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@first_month_fee", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.first_month_fee; }
                if(x_oMobileRetentionPreviousOrder.r_offer==null){  x_oCmd.Parameters.Add("@r_offer", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@r_offer", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.r_offer; }
                if(x_oMobileRetentionPreviousOrder.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.cid; }
                if(x_oMobileRetentionPreviousOrder.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.did; }
                if(x_oMobileRetentionPreviousOrder.ftg_tenure==null){  x_oCmd.Parameters.Add("@ftg_tenure", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ftg_tenure", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.ftg_tenure; }
                if(x_oMobileRetentionPreviousOrder.con_per==null){  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.con_per; }
                if(x_oMobileRetentionPreviousOrder.gift_code4==null){  x_oCmd.Parameters.Add("@gift_code4", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_code4", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.gift_code4; }
                if(x_oMobileRetentionPreviousOrder.easywatch_type==null){  x_oCmd.Parameters.Add("@easywatch_type", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@easywatch_type", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionPreviousOrder.easywatch_type; }
                if(x_oMobileRetentionPreviousOrder.sms_mrt==null){  x_oCmd.Parameters.Add("@sms_mrt", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sms_mrt", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.sms_mrt; }
                if(x_oMobileRetentionPreviousOrder.tpy_his_id==null){  x_oCmd.Parameters.Add("@tpy_his_id", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@tpy_his_id", global::System.Data.SqlDbType.BigInt).Value=x_oMobileRetentionPreviousOrder.tpy_his_id; }
                if(x_oMobileRetentionPreviousOrder.monthly_payment_method==null){  x_oCmd.Parameters.Add("@monthly_payment_method", global::System.Data.SqlDbType.NVarChar,40).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_payment_method", global::System.Data.SqlDbType.NVarChar,40).Value=x_oMobileRetentionPreviousOrder.monthly_payment_method; }
                if(x_oMobileRetentionPreviousOrder.remarks2EDF==null){  x_oCmd.Parameters.Add("@remarks2EDF", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@remarks2EDF", global::System.Data.SqlDbType.Text).Value=x_oMobileRetentionPreviousOrder.remarks2EDF; }
                if(x_oMobileRetentionPreviousOrder.gift_desc3==null){  x_oCmd.Parameters.Add("@gift_desc3", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_desc3", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.gift_desc3; }
                if(x_oMobileRetentionPreviousOrder.gift_imei4==null){  x_oCmd.Parameters.Add("@gift_imei4", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_imei4", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.gift_imei4; }
                if(x_oMobileRetentionPreviousOrder.monthly_bank_account_hkid2==null){  x_oCmd.Parameters.Add("@monthly_bank_account_hkid2", global::System.Data.SqlDbType.NVarChar,1).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_bank_account_hkid2", global::System.Data.SqlDbType.NVarChar,1).Value=x_oMobileRetentionPreviousOrder.monthly_bank_account_hkid2; }
                if(x_oMobileRetentionPreviousOrder.d_date==null){  x_oCmd.Parameters.Add("@d_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@d_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionPreviousOrder.d_date; }
                if(x_oMobileRetentionPreviousOrder.gift_desc==null){  x_oCmd.Parameters.Add("@gift_desc", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_desc", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.gift_desc; }
                if(x_oMobileRetentionPreviousOrder.pool==null){  x_oCmd.Parameters.Add("@pool", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@pool", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.pool; }
                if(x_oMobileRetentionPreviousOrder.cn_mrt_no==null){  x_oCmd.Parameters.Add("@cn_mrt_no", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cn_mrt_no", global::System.Data.SqlDbType.BigInt).Value=x_oMobileRetentionPreviousOrder.cn_mrt_no; }
                if(x_oMobileRetentionPreviousOrder.accessory_imei==null){  x_oCmd.Parameters.Add("@accessory_imei", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@accessory_imei", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.accessory_imei; }
                if(x_oMobileRetentionPreviousOrder.third_party_credit_card==null){  x_oCmd.Parameters.Add("@third_party_credit_card", global::System.Data.SqlDbType.NVarChar,5).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@third_party_credit_card", global::System.Data.SqlDbType.NVarChar,5).Value=x_oMobileRetentionPreviousOrder.third_party_credit_card; }
                if(x_oMobileRetentionPreviousOrder.special_approval==null){  x_oCmd.Parameters.Add("@special_approval", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@special_approval", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.special_approval; }
                if(x_oMobileRetentionPreviousOrder.upgrade_existing_contract_edate==null){  x_oCmd.Parameters.Add("@upgrade_existing_contract_edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@upgrade_existing_contract_edate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionPreviousOrder.upgrade_existing_contract_edate; }
                if(x_oMobileRetentionPreviousOrder.accessory_code==null){  x_oCmd.Parameters.Add("@accessory_code", global::System.Data.SqlDbType.NVarChar,70).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@accessory_code", global::System.Data.SqlDbType.NVarChar,70).Value=x_oMobileRetentionPreviousOrder.accessory_code; }
                if(x_oMobileRetentionPreviousOrder.s_premium==null){  x_oCmd.Parameters.Add("@s_premium", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@s_premium", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.s_premium; }
                if(x_oMobileRetentionPreviousOrder.ref_staff_no==null){  x_oCmd.Parameters.Add("@ref_staff_no", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ref_staff_no", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionPreviousOrder.ref_staff_no; }
                if(x_oMobileRetentionPreviousOrder.accessory_price==null){  x_oCmd.Parameters.Add("@accessory_price", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@accessory_price", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.accessory_price; }
                if(x_oMobileRetentionPreviousOrder.m_card_exp_month==null){  x_oCmd.Parameters.Add("@m_card_exp_month", global::System.Data.SqlDbType.NVarChar,2).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_card_exp_month", global::System.Data.SqlDbType.NVarChar,2).Value=x_oMobileRetentionPreviousOrder.m_card_exp_month; }
                if(x_oMobileRetentionPreviousOrder.installment_period==null){  x_oCmd.Parameters.Add("@installment_period", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@installment_period", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.installment_period; }
                if(x_oMobileRetentionPreviousOrder.m_card_type==null){  x_oCmd.Parameters.Add("@m_card_type", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_card_type", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionPreviousOrder.m_card_type; }
                if(x_oMobileRetentionPreviousOrder.easywatch_ord_id==null){  x_oCmd.Parameters.Add("@easywatch_ord_id", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@easywatch_ord_id", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.easywatch_ord_id; }
                if(x_oMobileRetentionPreviousOrder.normal_rebate==null){  x_oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionPreviousOrder.normal_rebate; }
                if(x_oMobileRetentionPreviousOrder.m_rebate_amount==null){  x_oCmd.Parameters.Add("@m_rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.m_rebate_amount; }
                if(x_oMobileRetentionPreviousOrder.m_card_holder2==null){  x_oCmd.Parameters.Add("@m_card_holder2", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_card_holder2", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.m_card_holder2; }
                if(x_oMobileRetentionPreviousOrder.monthly_bank_account_holder==null){  x_oCmd.Parameters.Add("@monthly_bank_account_holder", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_bank_account_holder", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.monthly_bank_account_holder; }
                if(x_oMobileRetentionPreviousOrder.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionPreviousOrder.active; }
                if(x_oMobileRetentionPreviousOrder.s_premium1==null){  x_oCmd.Parameters.Add("@s_premium1", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@s_premium1", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.s_premium1; }
                if(x_oMobileRetentionPreviousOrder.card_exp_month==null){  x_oCmd.Parameters.Add("@card_exp_month", global::System.Data.SqlDbType.NVarChar,2).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@card_exp_month", global::System.Data.SqlDbType.NVarChar,2).Value=x_oMobileRetentionPreviousOrder.card_exp_month; }
                if(x_oMobileRetentionPreviousOrder.ob_program_id==null){  x_oCmd.Parameters.Add("@ob_program_id", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ob_program_id", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionPreviousOrder.ob_program_id; }
                if(x_oMobileRetentionPreviousOrder.sku==null){  x_oCmd.Parameters.Add("@sku", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sku", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.sku; }
                if(x_oMobileRetentionPreviousOrder.salesmancode==null){  x_oCmd.Parameters.Add("@salesmancode", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@salesmancode", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.salesmancode; }
                if(x_oMobileRetentionPreviousOrder.go_wireless_package_code==null){  x_oCmd.Parameters.Add("@go_wireless_package_code", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@go_wireless_package_code", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.go_wireless_package_code; }
                if(x_oMobileRetentionPreviousOrder.lob==null){  x_oCmd.Parameters.Add("@lob", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@lob", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.lob; }
                if(x_oMobileRetentionPreviousOrder.ref_salesmancode==null){  x_oCmd.Parameters.Add("@ref_salesmancode", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ref_salesmancode", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionPreviousOrder.ref_salesmancode; }
                if(x_oMobileRetentionPreviousOrder.third_party_hkid==null){  x_oCmd.Parameters.Add("@third_party_hkid", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@third_party_hkid", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionPreviousOrder.third_party_hkid; }
                if(x_oMobileRetentionPreviousOrder.upgrade_existing_pccw_customer==null){  x_oCmd.Parameters.Add("@upgrade_existing_pccw_customer", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_existing_pccw_customer", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.upgrade_existing_pccw_customer; }
                if(x_oMobileRetentionPreviousOrder.d_address==null){  x_oCmd.Parameters.Add("@d_address", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_address", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.d_address; }
                if(x_oMobileRetentionPreviousOrder.upgrade_registered_mobile_no==null){  x_oCmd.Parameters.Add("@upgrade_registered_mobile_no", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_registered_mobile_no", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.upgrade_registered_mobile_no; }
                if(x_oMobileRetentionPreviousOrder.gift_code3==null){  x_oCmd.Parameters.Add("@gift_code3", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_code3", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.gift_code3; }
                if(x_oMobileRetentionPreviousOrder.normal_rebate_type==null){  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.normal_rebate_type; }
                if(x_oMobileRetentionPreviousOrder.gift_desc2==null){  x_oCmd.Parameters.Add("@gift_desc2", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_desc2", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.gift_desc2; }
                if(x_oMobileRetentionPreviousOrder.monthly_bank_account_branch_code==null){  x_oCmd.Parameters.Add("@monthly_bank_account_branch_code", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_bank_account_branch_code", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.monthly_bank_account_branch_code; }
                if(x_oMobileRetentionPreviousOrder.remarks==null){  x_oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.Text).Value=x_oMobileRetentionPreviousOrder.remarks; }
                if(x_oMobileRetentionPreviousOrder.accept==null){  x_oCmd.Parameters.Add("@accept", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@accept", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.accept; }
                if(x_oMobileRetentionPreviousOrder.delivery_exchange==null){  x_oCmd.Parameters.Add("@delivery_exchange", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@delivery_exchange", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.delivery_exchange; }
                if(x_oMobileRetentionPreviousOrder.gift_code2==null){  x_oCmd.Parameters.Add("@gift_code2", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_code2", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.gift_code2; }
                if(x_oMobileRetentionPreviousOrder.prepayment_waive==null){  x_oCmd.Parameters.Add("@prepayment_waive", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@prepayment_waive", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionPreviousOrder.prepayment_waive; }
                if(x_oMobileRetentionPreviousOrder.existing_smart_phone_imei==null){  x_oCmd.Parameters.Add("@existing_smart_phone_imei", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@existing_smart_phone_imei", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.existing_smart_phone_imei; }
                if(x_oMobileRetentionPreviousOrder.mnp_his_id==null){  x_oCmd.Parameters.Add("@mnp_his_id", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@mnp_his_id", global::System.Data.SqlDbType.BigInt).Value=x_oMobileRetentionPreviousOrder.mnp_his_id; }
                if(x_oMobileRetentionPreviousOrder.cust_name==null){  x_oCmd.Parameters.Add("@cust_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cust_name", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.cust_name; }
                if(x_oMobileRetentionPreviousOrder.upgrade_sponsorships_amount==null){  x_oCmd.Parameters.Add("@upgrade_sponsorships_amount", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_sponsorships_amount", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.upgrade_sponsorships_amount; }
                if(x_oMobileRetentionPreviousOrder.bill_medium_waive==null){  x_oCmd.Parameters.Add("@bill_medium_waive", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bill_medium_waive", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionPreviousOrder.bill_medium_waive; }
                if(x_oMobileRetentionPreviousOrder.delivery_exchange_location==null){  x_oCmd.Parameters.Add("@delivery_exchange_location", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@delivery_exchange_location", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.delivery_exchange_location; }
                if(x_oMobileRetentionPreviousOrder.hs_offer_type_id==null){  x_oCmd.Parameters.Add("@hs_offer_type_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hs_offer_type_id", global::System.Data.SqlDbType.Int).Value=x_oMobileRetentionPreviousOrder.hs_offer_type_id; }
                if(x_oMobileRetentionPreviousOrder.org_fee==null){  x_oCmd.Parameters.Add("@org_fee", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@org_fee", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.org_fee; }
                if(x_oMobileRetentionPreviousOrder.rebate==null){  x_oCmd.Parameters.Add("@rebate", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rebate", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionPreviousOrder.rebate; }
                if(x_oMobileRetentionPreviousOrder.upgrade_type==null){  x_oCmd.Parameters.Add("@upgrade_type", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_type", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.upgrade_type; }
                if(x_oMobileRetentionPreviousOrder.go_wireless==null){  x_oCmd.Parameters.Add("@go_wireless", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@go_wireless", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.go_wireless; }
                if(x_oMobileRetentionPreviousOrder.extra_rebate==null){  x_oCmd.Parameters.Add("@extra_rebate", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@extra_rebate", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.extra_rebate; }
                if(x_oMobileRetentionPreviousOrder.plan_eff==null){  x_oCmd.Parameters.Add("@plan_eff", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@plan_eff", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionPreviousOrder.plan_eff; }
                if(x_oMobileRetentionPreviousOrder.extra_rebate_amount==null){  x_oCmd.Parameters.Add("@extra_rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@extra_rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.extra_rebate_amount; }
                if(x_oMobileRetentionPreviousOrder.card_exp_year==null){  x_oCmd.Parameters.Add("@card_exp_year", global::System.Data.SqlDbType.NVarChar,4).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@card_exp_year", global::System.Data.SqlDbType.NVarChar,4).Value=x_oMobileRetentionPreviousOrder.card_exp_year; }
                if(x_oMobileRetentionPreviousOrder.upgrade_existing_contract_sdate==null){  x_oCmd.Parameters.Add("@upgrade_existing_contract_sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@upgrade_existing_contract_sdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionPreviousOrder.upgrade_existing_contract_sdate; }
                if(x_oMobileRetentionPreviousOrder.ord_place_hkid==null){  x_oCmd.Parameters.Add("@ord_place_hkid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ord_place_hkid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.ord_place_hkid; }
                if(x_oMobileRetentionPreviousOrder.register_address==null){  x_oCmd.Parameters.Add("@register_address", global::System.Data.SqlDbType.NVarChar,200).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@register_address", global::System.Data.SqlDbType.NVarChar,200).Value=x_oMobileRetentionPreviousOrder.register_address; }
                if(x_oMobileRetentionPreviousOrder.gender==null){  x_oCmd.Parameters.Add("@gender", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gender", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.gender; }
                if(x_oMobileRetentionPreviousOrder.lob_ac==null){  x_oCmd.Parameters.Add("@lob_ac", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@lob_ac", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionPreviousOrder.lob_ac; }
                if(x_oMobileRetentionPreviousOrder.sim_mrt_no==null){  x_oCmd.Parameters.Add("@sim_mrt_no", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sim_mrt_no", global::System.Data.SqlDbType.Int).Value=x_oMobileRetentionPreviousOrder.sim_mrt_no; }
                if(x_oMobileRetentionPreviousOrder.redemption_notice_option==null){  x_oCmd.Parameters.Add("@redemption_notice_option", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@redemption_notice_option", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.redemption_notice_option; }
                if(x_oMobileRetentionPreviousOrder.delivery_collection_type==null){  x_oCmd.Parameters.Add("@delivery_collection_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@delivery_collection_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.delivery_collection_type; }
                if(x_oMobileRetentionPreviousOrder.action_date==null){  x_oCmd.Parameters.Add("@action_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@action_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionPreviousOrder.action_date; }
                if(x_oMobileRetentionPreviousOrder.third_party_id_type==null){  x_oCmd.Parameters.Add("@third_party_id_type", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@third_party_id_type", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionPreviousOrder.third_party_id_type; }
                if(x_oMobileRetentionPreviousOrder.org_ftg==null){  x_oCmd.Parameters.Add("@org_ftg", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@org_ftg", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.org_ftg; }
                if(x_oMobileRetentionPreviousOrder.upgrade_service_tenure==null){  x_oCmd.Parameters.Add("@upgrade_service_tenure", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_service_tenure", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.upgrade_service_tenure; }
                if(x_oMobileRetentionPreviousOrder.monthly_payment_type==null){  x_oCmd.Parameters.Add("@monthly_payment_type", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_payment_type", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.monthly_payment_type; }
                if(x_oMobileRetentionPreviousOrder.contact_no==null){  x_oCmd.Parameters.Add("@contact_no", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@contact_no", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionPreviousOrder.contact_no; }
                if(x_oMobileRetentionPreviousOrder.org_mrt==null){  x_oCmd.Parameters.Add("@org_mrt", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@org_mrt", global::System.Data.SqlDbType.Int).Value=x_oMobileRetentionPreviousOrder.org_mrt; }
                if(x_oMobileRetentionPreviousOrder.sim_item_name==null){  x_oCmd.Parameters.Add("@sim_item_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sim_item_name", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.sim_item_name; }
                if(x_oMobileRetentionPreviousOrder.pay_method==null){  x_oCmd.Parameters.Add("@pay_method", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@pay_method", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.pay_method; }
                if(x_oMobileRetentionPreviousOrder.hs_model==null){  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.hs_model; }
                if(x_oMobileRetentionPreviousOrder.gift_code==null){  x_oCmd.Parameters.Add("@gift_code", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_code", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.gift_code; }
                if(x_oMobileRetentionPreviousOrder.monthly_bank_account_hkid==null){  x_oCmd.Parameters.Add("@monthly_bank_account_hkid", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_bank_account_hkid", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionPreviousOrder.monthly_bank_account_hkid; }
                if(x_oMobileRetentionPreviousOrder.extra_offer==null){  x_oCmd.Parameters.Add("@extra_offer", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@extra_offer", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.extra_offer; }
                if(x_oMobileRetentionPreviousOrder.monthly_bank_account_no==null){  x_oCmd.Parameters.Add("@monthly_bank_account_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_bank_account_no", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.monthly_bank_account_no; }
                if(x_oMobileRetentionPreviousOrder.first_month_license_fee==null){  x_oCmd.Parameters.Add("@first_month_license_fee", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@first_month_license_fee", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.first_month_license_fee; }
                if(x_oMobileRetentionPreviousOrder.retrieve_cnt==null){  x_oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int).Value=x_oMobileRetentionPreviousOrder.retrieve_cnt; }
                if(x_oMobileRetentionPreviousOrder.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionPreviousOrder.ddate; }
                if(x_oMobileRetentionPreviousOrder.s_premium2==null){  x_oCmd.Parameters.Add("@s_premium2", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@s_premium2", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.s_premium2; }
                if(x_oMobileRetentionPreviousOrder.monthly_bank_account_id_type==null){  x_oCmd.Parameters.Add("@monthly_bank_account_id_type", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_bank_account_id_type", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.monthly_bank_account_id_type; }
                if(x_oMobileRetentionPreviousOrder.card_type==null){  x_oCmd.Parameters.Add("@card_type", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@card_type", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionPreviousOrder.card_type; }
                if(x_oMobileRetentionPreviousOrder.next_bill==null){  x_oCmd.Parameters.Add("@next_bill", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@next_bill", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionPreviousOrder.next_bill; }
                if(x_oMobileRetentionPreviousOrder.pcd_paid_go_wireless==null){  x_oCmd.Parameters.Add("@pcd_paid_go_wireless", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@pcd_paid_go_wireless", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionPreviousOrder.pcd_paid_go_wireless; }
                if(x_oMobileRetentionPreviousOrder.upgrade_rebate_calculation==null){  x_oCmd.Parameters.Add("@upgrade_rebate_calculation", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_rebate_calculation", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.upgrade_rebate_calculation; }
                if(x_oMobileRetentionPreviousOrder.ext_place_tel==null){  x_oCmd.Parameters.Add("@ext_place_tel", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ext_place_tel", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionPreviousOrder.ext_place_tel; }
                if(x_oMobileRetentionPreviousOrder.m_3rd_hkid==null){  x_oCmd.Parameters.Add("@m_3rd_hkid", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_3rd_hkid", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionPreviousOrder.m_3rd_hkid; }
                if(x_oMobileRetentionPreviousOrder.retention_type==null){  x_oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.Char,10).Value=x_oMobileRetentionPreviousOrder.retention_type; }
                if(x_oMobileRetentionPreviousOrder.bill_address_his_id==null){  x_oCmd.Parameters.Add("@bill_address_his_id", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bill_address_his_id", global::System.Data.SqlDbType.BigInt).Value=x_oMobileRetentionPreviousOrder.bill_address_his_id; }
                if(x_oMobileRetentionPreviousOrder.aig_gift==null){  x_oCmd.Parameters.Add("@aig_gift", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@aig_gift", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.aig_gift; }
                if(x_oMobileRetentionPreviousOrder.cust_staff_no==null){  x_oCmd.Parameters.Add("@cust_staff_no", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cust_staff_no", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.cust_staff_no; }
                if(x_oMobileRetentionPreviousOrder.family_name==null){  x_oCmd.Parameters.Add("@family_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@family_name", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.family_name; }
                if(x_oMobileRetentionPreviousOrder.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionPreviousOrder.cdate; }
                if(x_oMobileRetentionPreviousOrder.status_by_cs_admin==null){  x_oCmd.Parameters.Add("@status_by_cs_admin", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@status_by_cs_admin", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.status_by_cs_admin; }
                if(x_oMobileRetentionPreviousOrder.given_name==null){  x_oCmd.Parameters.Add("@given_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@given_name", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.given_name; }
                if(x_oMobileRetentionPreviousOrder.vip_case==null){  x_oCmd.Parameters.Add("@vip_case", global::System.Data.SqlDbType.NVarChar,200).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@vip_case", global::System.Data.SqlDbType.NVarChar,200).Value=x_oMobileRetentionPreviousOrder.vip_case; }
                if(x_oMobileRetentionPreviousOrder.s_premium3==null){  x_oCmd.Parameters.Add("@s_premium3", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@s_premium3", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.s_premium3; }
                if(x_oMobileRetentionPreviousOrder.log_date==null){  x_oCmd.Parameters.Add("@log_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@log_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionPreviousOrder.log_date; }
                if(x_oMobileRetentionPreviousOrder.extn==null){  x_oCmd.Parameters.Add("@extn", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@extn", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.extn; }
                if(x_oMobileRetentionPreviousOrder.d_time==null){  x_oCmd.Parameters.Add("@d_time", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_time", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.d_time; }
                if(x_oMobileRetentionPreviousOrder.bank_name==null){  x_oCmd.Parameters.Add("@bank_name", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bank_name", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.bank_name; }
                if(x_oMobileRetentionPreviousOrder.delivery_exchange_option==null){  x_oCmd.Parameters.Add("@delivery_exchange_option", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@delivery_exchange_option", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.delivery_exchange_option; }
                if(x_oMobileRetentionPreviousOrder.upgrade_service_account_no==null){  x_oCmd.Parameters.Add("@upgrade_service_account_no", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_service_account_no", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.upgrade_service_account_no; }
                if(x_oMobileRetentionPreviousOrder.old_ord_id==null){  x_oCmd.Parameters.Add("@old_ord_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@old_ord_id", global::System.Data.SqlDbType.Int).Value=x_oMobileRetentionPreviousOrder.old_ord_id; }
                if(x_oMobileRetentionPreviousOrder.m_card_no==null){  x_oCmd.Parameters.Add("@m_card_no", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_card_no", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionPreviousOrder.m_card_no; }
                if(x_oMobileRetentionPreviousOrder.existing_contract_end_date==null){  x_oCmd.Parameters.Add("@existing_contract_end_date", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@existing_contract_end_date", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionPreviousOrder.existing_contract_end_date; }
                if(x_oMobileRetentionPreviousOrder.con_eff_date==null){  x_oCmd.Parameters.Add("@con_eff_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@con_eff_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionPreviousOrder.con_eff_date; }
                if(x_oMobileRetentionPreviousOrder.m_3rd_hkid2==null){  x_oCmd.Parameters.Add("@m_3rd_hkid2", global::System.Data.SqlDbType.NVarChar,1).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_3rd_hkid2", global::System.Data.SqlDbType.NVarChar,1).Value=x_oMobileRetentionPreviousOrder.m_3rd_hkid2; }
                if(x_oMobileRetentionPreviousOrder.amount==null){  x_oCmd.Parameters.Add("@amount", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@amount", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.amount; }
                if(x_oMobileRetentionPreviousOrder.m_3rd_id_type==null){  x_oCmd.Parameters.Add("@m_3rd_id_type", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_3rd_id_type", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.m_3rd_id_type; }
                if(x_oMobileRetentionPreviousOrder.id_type==null){  x_oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.id_type; }
                if(x_oMobileRetentionPreviousOrder.rate_plan==null){  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.rate_plan; }
                if(x_oMobileRetentionPreviousOrder.channel==null){  x_oCmd.Parameters.Add("@channel", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@channel", global::System.Data.SqlDbType.Char,10).Value=x_oMobileRetentionPreviousOrder.channel; }
                if(x_oMobileRetentionPreviousOrder.action_eff_date==null){  x_oCmd.Parameters.Add("@action_eff_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@action_eff_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionPreviousOrder.action_eff_date; }
                if(x_oMobileRetentionPreviousOrder.cooling_date==null){  x_oCmd.Parameters.Add("@cooling_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cooling_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionPreviousOrder.cooling_date; }
                if(x_oMobileRetentionPreviousOrder.free_mon==null){  x_oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.free_mon; }
                if(x_oMobileRetentionPreviousOrder.plan_eff_date==null){  x_oCmd.Parameters.Add("@plan_eff_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@plan_eff_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionPreviousOrder.plan_eff_date; }
                if(x_oMobileRetentionPreviousOrder.teamcode==null){  x_oCmd.Parameters.Add("@teamcode", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@teamcode", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.teamcode; }
                if(x_oMobileRetentionPreviousOrder.bill_medium==null){  x_oCmd.Parameters.Add("@bill_medium", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bill_medium", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.bill_medium; }
                if(x_oMobileRetentionPreviousOrder.edf_no==null){  x_oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,15).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,15).Value=x_oMobileRetentionPreviousOrder.edf_no; }
                if(x_oMobileRetentionPreviousOrder.ord_place_by==null){  x_oCmd.Parameters.Add("@ord_place_by", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ord_place_by", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.ord_place_by; }
                if(x_oMobileRetentionPreviousOrder.cancel_renew==null){  x_oCmd.Parameters.Add("@cancel_renew", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cancel_renew", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.cancel_renew; }
                if(x_oMobileRetentionPreviousOrder.preferred_languages==null){  x_oCmd.Parameters.Add("@preferred_languages", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@preferred_languages", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionPreviousOrder.preferred_languages; }
                if(x_oMobileRetentionPreviousOrder.hkid==null){  x_oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionPreviousOrder.hkid; }
                if(x_oMobileRetentionPreviousOrder.card_holder==null){  x_oCmd.Parameters.Add("@card_holder", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@card_holder", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.card_holder; }
                if(x_oMobileRetentionPreviousOrder.ac_no==null){  x_oCmd.Parameters.Add("@ac_no", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ac_no", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionPreviousOrder.ac_no; }
                if(x_oMobileRetentionPreviousOrder.bill_cut_num==null){  x_oCmd.Parameters.Add("@bill_cut_num", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bill_cut_num", global::System.Data.SqlDbType.Int).Value=x_oMobileRetentionPreviousOrder.bill_cut_num; }
                if(x_oMobileRetentionPreviousOrder.premium==null){  x_oCmd.Parameters.Add("@premium", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@premium", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.premium; }
                if(x_oMobileRetentionPreviousOrder.del_remark==null){  x_oCmd.Parameters.Add("@del_remark", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@del_remark", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.del_remark; }
                if(x_oMobileRetentionPreviousOrder.gift_imei2==null){  x_oCmd.Parameters.Add("@gift_imei2", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_imei2", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.gift_imei2; }
                if(x_oMobileRetentionPreviousOrder.reasons==null){  x_oCmd.Parameters.Add("@reasons", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@reasons", global::System.Data.SqlDbType.Text).Value=x_oMobileRetentionPreviousOrder.reasons; }
                if(x_oMobileRetentionPreviousOrder.language==null){  x_oCmd.Parameters.Add("@language", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@language", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionPreviousOrder.language; }
                if(x_oMobileRetentionPreviousOrder.rebate_amount==null){  x_oCmd.Parameters.Add("@rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.rebate_amount; }
                if(x_oMobileRetentionPreviousOrder.ord_place_id_type==null){  x_oCmd.Parameters.Add("@ord_place_id_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ord_place_id_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.ord_place_id_type; }
                if(x_oMobileRetentionPreviousOrder.m_3rd_contact_no==null){  x_oCmd.Parameters.Add("@m_3rd_contact_no", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_3rd_contact_no", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionPreviousOrder.m_3rd_contact_no; }
                if(x_oMobileRetentionPreviousOrder.staff_no==null){  x_oCmd.Parameters.Add("@staff_no", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@staff_no", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionPreviousOrder.staff_no; }
                if(x_oMobileRetentionPreviousOrder.sp_d_date==null){  x_oCmd.Parameters.Add("@sp_d_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@sp_d_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionPreviousOrder.sp_d_date; }
                if(x_oMobileRetentionPreviousOrder.bundle_name==null){  x_oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.bundle_name; }
                if(x_oMobileRetentionPreviousOrder.accessory_waive==null){  x_oCmd.Parameters.Add("@accessory_waive", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@accessory_waive", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionPreviousOrder.accessory_waive; }
                if(x_oMobileRetentionPreviousOrder.sim_item_code==null){  x_oCmd.Parameters.Add("@sim_item_code", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sim_item_code", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionPreviousOrder.sim_item_code; }
                if(x_oMobileRetentionPreviousOrder.cust_type==null){  x_oCmd.Parameters.Add("@cust_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cust_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.cust_type; }
                if(x_oMobileRetentionPreviousOrder.card_ref_no==null){  x_oCmd.Parameters.Add("@card_ref_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@card_ref_no", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionPreviousOrder.card_ref_no; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["MobileRetentionPreviousOrder_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["MobileRetentionPreviousOrder_LASTID"].ToString()) && int.TryParse(_oData["MobileRetentionPreviousOrder_LASTID"].ToString(),out x_iLAST_ID)){
                            _bResult=true;
                        }
                        else
                        {
                            x_iLAST_ID = -1;
                        }
                    }
                }
                _oData.Close();
                _oData.Dispose();
            }
            catch {  }
            finally
            {
                if (!x_oDB.bTransaction)
                {
                    x_oConn.Close();
                    x_oCmd.Dispose();
                    x_oConn.Dispose();
                }
            }
            return _bResult;
        }
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sGift_imei,string x_sS_premium4,string x_sGift_desc4,string x_sAccessory_desc,string x_sAction_required,global::System.Nullable<long> x_lRegistered_address_his_id,global::System.Nullable<DateTime> x_dVas_eff_date,string x_sMonthly_bank_account_bank_code,string x_sSpecial_handling_dummy_code,string x_sM_card_exp_year,string x_sRemarks2PY,string x_sTrade_field,string x_sOrd_place_tel,string x_sOrd_place_id_type,string x_sCooling_offer,global::System.Nullable<int> x_iRec_no,string x_sUpgrade_handset_offer_rebate_schedule,string x_sChange_payment_type,global::System.Nullable<DateTime> x_dDate_of_birth,string x_sContact_person,string x_sExtra_d_charge,string x_sTl_name,global::System.Nullable<bool> x_bFast_start,string x_sSp_ref_no,global::System.Nullable<DateTime> x_dEdate,string x_sExist_cust_plan,string x_sOrd_place_rel,global::System.Nullable<int> x_iMrt_no,string x_sImei_no,string x_sExisting_smart_phone_model,string x_sGift_code3,string x_sBank_code,string x_sPos_ref_no,global::System.Nullable<DateTime> x_dBill_cut_date,string x_sGift_imei3,string x_sExist_plan,global::System.Nullable<bool> x_bWaive,string x_sProgram,string x_sFirst_month_fee,string x_sR_offer,string x_sCid,string x_sDid,string x_sFtg_tenure,string x_sCon_per,string x_sGift_code4,string x_sEasywatch_type,string x_sSms_mrt,global::System.Nullable<long> x_lTpy_his_id,string x_sMonthly_payment_method,string x_sRemarks2EDF,string x_sGift_desc3,string x_sGift_imei4,global::System.Nullable<int> x_iOld_ord_id,string x_sMonthly_bank_account_hkid2,global::System.Nullable<DateTime> x_dD_date,string x_sGift_desc,string x_sSalesmancode,string x_sPool,global::System.Nullable<long> x_lCn_mrt_no,string x_sAccessory_imei,string x_sThird_party_credit_card,string x_sCard_ref_no,global::System.Nullable<DateTime> x_dCooling_date,string x_sSpecial_approval,global::System.Nullable<DateTime> x_dUpgrade_existing_contract_edate,string x_sAccessory_code,string x_sBill_medium,string x_sS_premium,string x_sRef_staff_no,string x_sAccessory_price,string x_sM_card_exp_month,string x_sInstallment_period,string x_sM_card_type,string x_sEasywatch_ord_id,global::System.Nullable<bool> x_bNormal_rebate,string x_sM_rebate_amount,string x_sM_card_holder2,string x_sBill_medium_email,global::System.Nullable<bool> x_bActive,string x_sS_premium1,string x_sCard_exp_month,string x_sOb_program_id,string x_sSku,string x_sRef_salesmancode,string x_sGo_wireless_package_code,string x_sThird_party_hkid,string x_sUpgrade_existing_pccw_customer,string x_sD_address,string x_sUpgrade_registered_mobile_no,string x_sUpgrade_existing_customer_type,string x_sNormal_rebate_type,string x_sGift_desc2,string x_sMonthly_bank_account_branch_code,string x_sRemarks,string x_sAccept,string x_sDelivery_exchange,string x_sGift_code2,global::System.Nullable<bool> x_bPrepayment_waive,string x_sExisting_smart_phone_imei,global::System.Nullable<long> x_lMnp_his_id,string x_sCust_name,string x_sCust_type,string x_sUpgrade_sponsorships_amount,global::System.Nullable<bool> x_bBill_medium_waive,string x_sDelivery_exchange_location,global::System.Nullable<int> x_iHs_offer_type_id,string x_sOrg_fee,string x_sRebate,string x_sUpgrade_type,string x_sGo_wireless,string x_sExtra_rebate,string x_sPlan_eff,string x_sExtra_rebate_amount,string x_sCard_exp_year,global::System.Nullable<DateTime> x_dUpgrade_existing_contract_sdate,string x_sOrd_place_hkid,string x_sRegister_address,string x_sGender,string x_sLob_ac,global::System.Nullable<int> x_iSim_mrt_no,string x_sRedemption_notice_option,string x_sDelivery_collection_type,global::System.Nullable<DateTime> x_dAction_date,string x_sThird_party_id_type,string x_sOrg_ftg,string x_sUpgrade_service_tenure,string x_sMonthly_payment_type,string x_sContact_no,global::System.Nullable<int> x_iOrg_mrt,string x_sSim_item_name,string x_sPay_method,string x_sHs_model,string x_sGift_code,string x_sMonthly_bank_account_hkid,string x_sExtra_offer,string x_sMonthly_bank_account_no,string x_sFirst_month_license_fee,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dDdate,string x_sS_premium2,string x_sMonthly_bank_account_id_type,string x_sCard_type,global::System.Nullable<bool> x_bNext_bill,global::System.Nullable<bool> x_bPcd_paid_go_wireless,string x_sUpgrade_rebate_calculation,string x_sExt_place_tel,string x_sM_3rd_hkid,string x_sRetention_type,global::System.Nullable<long> x_lBill_address_his_id,string x_sAig_gift,string x_sCust_staff_no,string x_sFamily_name,global::System.Nullable<DateTime> x_dCdate,string x_sStatus_by_cs_admin,string x_sSim_item_number,string x_sVip_case,string x_sGiven_name,global::System.Nullable<DateTime> x_dLog_date,string x_sExtn,string x_sD_time,string x_sBank_name,string x_sDelivery_exchange_option,string x_sUpgrade_service_account_no,string x_sAction_of_rate_plan_effective,string x_sM_card_no,string x_sExisting_contract_end_date,global::System.Nullable<DateTime> x_dCon_eff_date,string x_sM_3rd_hkid2,string x_sAmount,string x_sId_type,string x_sRate_plan,string x_sChannel,global::System.Nullable<DateTime> x_dAction_eff_date,string x_sIssue_type,string x_sFree_mon,global::System.Nullable<DateTime> x_dPlan_eff_date,string x_sDel_remark,string x_sTeamcode,string x_sStaff_name,string x_sEdf_no,string x_sOrd_place_by,string x_sCancel_renew,string x_sPreferred_languages,string x_sHkid,string x_sCard_no,string x_sAc_no,global::System.Nullable<int> x_iBill_cut_num,string x_sPremium,string x_sM_3rd_id_type,string x_sGift_imei2,string x_sReasons,string x_sLanguage,string x_sRebate_amount,string x_sLob,string x_sM_3rd_contact_no,string x_sStaff_no,string x_sS_premium3,global::System.Nullable<DateTime> x_dSp_d_date,string x_sBundle_name,global::System.Nullable<bool> x_bAccessory_waive,string x_sSim_item_code,string x_sMonthly_bank_account_holder,string x_sCard_holder)
        {
            int _oLastID;
            MobileRetentionPreviousOrder _oMobileRetentionPreviousOrder=MobileRetentionPreviousOrderRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileRetentionPreviousOrder.gift_imei=x_sGift_imei;
            _oMobileRetentionPreviousOrder.s_premium4=x_sS_premium4;
            _oMobileRetentionPreviousOrder.gift_desc4=x_sGift_desc4;
            _oMobileRetentionPreviousOrder.accessory_desc=x_sAccessory_desc;
            _oMobileRetentionPreviousOrder.action_required=x_sAction_required;
            _oMobileRetentionPreviousOrder.registered_address_his_id=x_lRegistered_address_his_id;
            _oMobileRetentionPreviousOrder.vas_eff_date=x_dVas_eff_date;
            _oMobileRetentionPreviousOrder.monthly_bank_account_bank_code=x_sMonthly_bank_account_bank_code;
            _oMobileRetentionPreviousOrder.special_handling_dummy_code=x_sSpecial_handling_dummy_code;
            _oMobileRetentionPreviousOrder.m_card_exp_year=x_sM_card_exp_year;
            _oMobileRetentionPreviousOrder.remarks2PY=x_sRemarks2PY;
            _oMobileRetentionPreviousOrder.trade_field=x_sTrade_field;
            _oMobileRetentionPreviousOrder.ord_place_tel=x_sOrd_place_tel;
            _oMobileRetentionPreviousOrder.ord_place_id_type=x_sOrd_place_id_type;
            _oMobileRetentionPreviousOrder.cooling_offer=x_sCooling_offer;
            _oMobileRetentionPreviousOrder.rec_no=x_iRec_no;
            _oMobileRetentionPreviousOrder.upgrade_handset_offer_rebate_schedule=x_sUpgrade_handset_offer_rebate_schedule;
            _oMobileRetentionPreviousOrder.change_payment_type=x_sChange_payment_type;
            _oMobileRetentionPreviousOrder.date_of_birth=x_dDate_of_birth;
            _oMobileRetentionPreviousOrder.contact_person=x_sContact_person;
            _oMobileRetentionPreviousOrder.extra_d_charge=x_sExtra_d_charge;
            _oMobileRetentionPreviousOrder.tl_name=x_sTl_name;
            _oMobileRetentionPreviousOrder.fast_start=x_bFast_start;
            _oMobileRetentionPreviousOrder.sp_ref_no=x_sSp_ref_no;
            _oMobileRetentionPreviousOrder.edate=x_dEdate;
            _oMobileRetentionPreviousOrder.exist_cust_plan=x_sExist_cust_plan;
            _oMobileRetentionPreviousOrder.ord_place_rel=x_sOrd_place_rel;
            _oMobileRetentionPreviousOrder.mrt_no=x_iMrt_no;
            _oMobileRetentionPreviousOrder.imei_no=x_sImei_no;
            _oMobileRetentionPreviousOrder.existing_smart_phone_model=x_sExisting_smart_phone_model;
            _oMobileRetentionPreviousOrder.gift_code3=x_sGift_code3;
            _oMobileRetentionPreviousOrder.bank_code=x_sBank_code;
            _oMobileRetentionPreviousOrder.pos_ref_no=x_sPos_ref_no;
            _oMobileRetentionPreviousOrder.bill_cut_date=x_dBill_cut_date;
            _oMobileRetentionPreviousOrder.gift_imei3=x_sGift_imei3;
            _oMobileRetentionPreviousOrder.exist_plan=x_sExist_plan;
            _oMobileRetentionPreviousOrder.waive=x_bWaive;
            _oMobileRetentionPreviousOrder.program=x_sProgram;
            _oMobileRetentionPreviousOrder.first_month_fee=x_sFirst_month_fee;
            _oMobileRetentionPreviousOrder.r_offer=x_sR_offer;
            _oMobileRetentionPreviousOrder.cid=x_sCid;
            _oMobileRetentionPreviousOrder.did=x_sDid;
            _oMobileRetentionPreviousOrder.ftg_tenure=x_sFtg_tenure;
            _oMobileRetentionPreviousOrder.con_per=x_sCon_per;
            _oMobileRetentionPreviousOrder.gift_code4=x_sGift_code4;
            _oMobileRetentionPreviousOrder.easywatch_type=x_sEasywatch_type;
            _oMobileRetentionPreviousOrder.sms_mrt=x_sSms_mrt;
            _oMobileRetentionPreviousOrder.tpy_his_id=x_lTpy_his_id;
            _oMobileRetentionPreviousOrder.monthly_payment_method=x_sMonthly_payment_method;
            _oMobileRetentionPreviousOrder.remarks2EDF=x_sRemarks2EDF;
            _oMobileRetentionPreviousOrder.gift_desc3=x_sGift_desc3;
            _oMobileRetentionPreviousOrder.gift_imei4=x_sGift_imei4;
            _oMobileRetentionPreviousOrder.old_ord_id=x_iOld_ord_id;
            _oMobileRetentionPreviousOrder.monthly_bank_account_hkid2=x_sMonthly_bank_account_hkid2;
            _oMobileRetentionPreviousOrder.d_date=x_dD_date;
            _oMobileRetentionPreviousOrder.gift_desc=x_sGift_desc;
            _oMobileRetentionPreviousOrder.salesmancode=x_sSalesmancode;
            _oMobileRetentionPreviousOrder.pool=x_sPool;
            _oMobileRetentionPreviousOrder.cn_mrt_no=x_lCn_mrt_no;
            _oMobileRetentionPreviousOrder.accessory_imei=x_sAccessory_imei;
            _oMobileRetentionPreviousOrder.third_party_credit_card=x_sThird_party_credit_card;
            _oMobileRetentionPreviousOrder.card_ref_no=x_sCard_ref_no;
            _oMobileRetentionPreviousOrder.cooling_date=x_dCooling_date;
            _oMobileRetentionPreviousOrder.special_approval=x_sSpecial_approval;
            _oMobileRetentionPreviousOrder.upgrade_existing_contract_edate=x_dUpgrade_existing_contract_edate;
            _oMobileRetentionPreviousOrder.accessory_code=x_sAccessory_code;
            _oMobileRetentionPreviousOrder.bill_medium=x_sBill_medium;
            _oMobileRetentionPreviousOrder.s_premium=x_sS_premium;
            _oMobileRetentionPreviousOrder.ref_staff_no=x_sRef_staff_no;
            _oMobileRetentionPreviousOrder.accessory_price=x_sAccessory_price;
            _oMobileRetentionPreviousOrder.m_card_exp_month=x_sM_card_exp_month;
            _oMobileRetentionPreviousOrder.installment_period=x_sInstallment_period;
            _oMobileRetentionPreviousOrder.m_card_type=x_sM_card_type;
            _oMobileRetentionPreviousOrder.easywatch_ord_id=x_sEasywatch_ord_id;
            _oMobileRetentionPreviousOrder.normal_rebate=x_bNormal_rebate;
            _oMobileRetentionPreviousOrder.m_rebate_amount=x_sM_rebate_amount;
            _oMobileRetentionPreviousOrder.m_card_holder2=x_sM_card_holder2;
            _oMobileRetentionPreviousOrder.bill_medium_email=x_sBill_medium_email;
            _oMobileRetentionPreviousOrder.active=x_bActive;
            _oMobileRetentionPreviousOrder.s_premium1=x_sS_premium1;
            _oMobileRetentionPreviousOrder.card_exp_month=x_sCard_exp_month;
            _oMobileRetentionPreviousOrder.ob_program_id=x_sOb_program_id;
            _oMobileRetentionPreviousOrder.sku=x_sSku;
            _oMobileRetentionPreviousOrder.ref_salesmancode=x_sRef_salesmancode;
            _oMobileRetentionPreviousOrder.go_wireless_package_code=x_sGo_wireless_package_code;
            _oMobileRetentionPreviousOrder.third_party_hkid=x_sThird_party_hkid;
            _oMobileRetentionPreviousOrder.upgrade_existing_pccw_customer=x_sUpgrade_existing_pccw_customer;
            _oMobileRetentionPreviousOrder.d_address=x_sD_address;
            _oMobileRetentionPreviousOrder.upgrade_registered_mobile_no=x_sUpgrade_registered_mobile_no;
            _oMobileRetentionPreviousOrder.upgrade_existing_customer_type=x_sUpgrade_existing_customer_type;
            _oMobileRetentionPreviousOrder.normal_rebate_type=x_sNormal_rebate_type;
            _oMobileRetentionPreviousOrder.gift_desc2=x_sGift_desc2;
            _oMobileRetentionPreviousOrder.monthly_bank_account_branch_code=x_sMonthly_bank_account_branch_code;
            _oMobileRetentionPreviousOrder.remarks=x_sRemarks;
            _oMobileRetentionPreviousOrder.accept=x_sAccept;
            _oMobileRetentionPreviousOrder.delivery_exchange=x_sDelivery_exchange;
            _oMobileRetentionPreviousOrder.gift_code2=x_sGift_code2;
            _oMobileRetentionPreviousOrder.prepayment_waive=x_bPrepayment_waive;
            _oMobileRetentionPreviousOrder.existing_smart_phone_imei=x_sExisting_smart_phone_imei;
            _oMobileRetentionPreviousOrder.mnp_his_id=x_lMnp_his_id;
            _oMobileRetentionPreviousOrder.cust_name=x_sCust_name;
            _oMobileRetentionPreviousOrder.cust_type=x_sCust_type;
            _oMobileRetentionPreviousOrder.upgrade_sponsorships_amount=x_sUpgrade_sponsorships_amount;
            _oMobileRetentionPreviousOrder.bill_medium_waive=x_bBill_medium_waive;
            _oMobileRetentionPreviousOrder.delivery_exchange_location=x_sDelivery_exchange_location;
            _oMobileRetentionPreviousOrder.hs_offer_type_id=x_iHs_offer_type_id;
            _oMobileRetentionPreviousOrder.org_fee=x_sOrg_fee;
            _oMobileRetentionPreviousOrder.rebate=x_sRebate;
            _oMobileRetentionPreviousOrder.upgrade_type=x_sUpgrade_type;
            _oMobileRetentionPreviousOrder.go_wireless=x_sGo_wireless;
            _oMobileRetentionPreviousOrder.extra_rebate=x_sExtra_rebate;
            _oMobileRetentionPreviousOrder.plan_eff=x_sPlan_eff;
            _oMobileRetentionPreviousOrder.extra_rebate_amount=x_sExtra_rebate_amount;
            _oMobileRetentionPreviousOrder.card_exp_year=x_sCard_exp_year;
            _oMobileRetentionPreviousOrder.upgrade_existing_contract_sdate=x_dUpgrade_existing_contract_sdate;
            _oMobileRetentionPreviousOrder.ord_place_hkid=x_sOrd_place_hkid;
            _oMobileRetentionPreviousOrder.register_address=x_sRegister_address;
            _oMobileRetentionPreviousOrder.gender=x_sGender;
            _oMobileRetentionPreviousOrder.lob_ac=x_sLob_ac;
            _oMobileRetentionPreviousOrder.sim_mrt_no=x_iSim_mrt_no;
            _oMobileRetentionPreviousOrder.redemption_notice_option=x_sRedemption_notice_option;
            _oMobileRetentionPreviousOrder.delivery_collection_type=x_sDelivery_collection_type;
            _oMobileRetentionPreviousOrder.action_date=x_dAction_date;
            _oMobileRetentionPreviousOrder.third_party_id_type=x_sThird_party_id_type;
            _oMobileRetentionPreviousOrder.org_ftg=x_sOrg_ftg;
            _oMobileRetentionPreviousOrder.upgrade_service_tenure=x_sUpgrade_service_tenure;
            _oMobileRetentionPreviousOrder.monthly_payment_type=x_sMonthly_payment_type;
            _oMobileRetentionPreviousOrder.contact_no=x_sContact_no;
            _oMobileRetentionPreviousOrder.org_mrt=x_iOrg_mrt;
            _oMobileRetentionPreviousOrder.sim_item_name=x_sSim_item_name;
            _oMobileRetentionPreviousOrder.pay_method=x_sPay_method;
            _oMobileRetentionPreviousOrder.hs_model=x_sHs_model;
            _oMobileRetentionPreviousOrder.gift_code=x_sGift_code;
            _oMobileRetentionPreviousOrder.monthly_bank_account_hkid=x_sMonthly_bank_account_hkid;
            _oMobileRetentionPreviousOrder.extra_offer=x_sExtra_offer;
            _oMobileRetentionPreviousOrder.monthly_bank_account_no=x_sMonthly_bank_account_no;
            _oMobileRetentionPreviousOrder.first_month_license_fee=x_sFirst_month_license_fee;
            _oMobileRetentionPreviousOrder.retrieve_cnt=x_iRetrieve_cnt;
            _oMobileRetentionPreviousOrder.ddate=x_dDdate;
            _oMobileRetentionPreviousOrder.s_premium2=x_sS_premium2;
            _oMobileRetentionPreviousOrder.monthly_bank_account_id_type=x_sMonthly_bank_account_id_type;
            _oMobileRetentionPreviousOrder.card_type=x_sCard_type;
            _oMobileRetentionPreviousOrder.next_bill=x_bNext_bill;
            _oMobileRetentionPreviousOrder.pcd_paid_go_wireless=x_bPcd_paid_go_wireless;
            _oMobileRetentionPreviousOrder.upgrade_rebate_calculation=x_sUpgrade_rebate_calculation;
            _oMobileRetentionPreviousOrder.ext_place_tel=x_sExt_place_tel;
            _oMobileRetentionPreviousOrder.m_3rd_hkid=x_sM_3rd_hkid;
            _oMobileRetentionPreviousOrder.retention_type=x_sRetention_type;
            _oMobileRetentionPreviousOrder.bill_address_his_id=x_lBill_address_his_id;
            _oMobileRetentionPreviousOrder.aig_gift=x_sAig_gift;
            _oMobileRetentionPreviousOrder.cust_staff_no=x_sCust_staff_no;
            _oMobileRetentionPreviousOrder.family_name=x_sFamily_name;
            _oMobileRetentionPreviousOrder.cdate=x_dCdate;
            _oMobileRetentionPreviousOrder.status_by_cs_admin=x_sStatus_by_cs_admin;
            _oMobileRetentionPreviousOrder.sim_item_number=x_sSim_item_number;
            _oMobileRetentionPreviousOrder.vip_case=x_sVip_case;
            _oMobileRetentionPreviousOrder.given_name=x_sGiven_name;
            _oMobileRetentionPreviousOrder.log_date=x_dLog_date;
            _oMobileRetentionPreviousOrder.extn=x_sExtn;
            _oMobileRetentionPreviousOrder.d_time=x_sD_time;
            _oMobileRetentionPreviousOrder.bank_name=x_sBank_name;
            _oMobileRetentionPreviousOrder.delivery_exchange_option=x_sDelivery_exchange_option;
            _oMobileRetentionPreviousOrder.upgrade_service_account_no=x_sUpgrade_service_account_no;
            _oMobileRetentionPreviousOrder.action_of_rate_plan_effective=x_sAction_of_rate_plan_effective;
            _oMobileRetentionPreviousOrder.m_card_no=x_sM_card_no;
            _oMobileRetentionPreviousOrder.existing_contract_end_date=x_sExisting_contract_end_date;
            _oMobileRetentionPreviousOrder.con_eff_date=x_dCon_eff_date;
            _oMobileRetentionPreviousOrder.m_3rd_hkid2=x_sM_3rd_hkid2;
            _oMobileRetentionPreviousOrder.amount=x_sAmount;
            _oMobileRetentionPreviousOrder.id_type=x_sId_type;
            _oMobileRetentionPreviousOrder.rate_plan=x_sRate_plan;
            _oMobileRetentionPreviousOrder.channel=x_sChannel;
            _oMobileRetentionPreviousOrder.action_eff_date=x_dAction_eff_date;
            _oMobileRetentionPreviousOrder.issue_type=x_sIssue_type;
            _oMobileRetentionPreviousOrder.free_mon=x_sFree_mon;
            _oMobileRetentionPreviousOrder.plan_eff_date=x_dPlan_eff_date;
            _oMobileRetentionPreviousOrder.del_remark=x_sDel_remark;
            _oMobileRetentionPreviousOrder.teamcode=x_sTeamcode;
            _oMobileRetentionPreviousOrder.staff_name=x_sStaff_name;
            _oMobileRetentionPreviousOrder.edf_no=x_sEdf_no;
            _oMobileRetentionPreviousOrder.ord_place_by=x_sOrd_place_by;
            _oMobileRetentionPreviousOrder.cancel_renew=x_sCancel_renew;
            _oMobileRetentionPreviousOrder.preferred_languages=x_sPreferred_languages;
            _oMobileRetentionPreviousOrder.hkid=x_sHkid;
            _oMobileRetentionPreviousOrder.card_no=x_sCard_no;
            _oMobileRetentionPreviousOrder.ac_no=x_sAc_no;
            _oMobileRetentionPreviousOrder.bill_cut_num=x_iBill_cut_num;
            _oMobileRetentionPreviousOrder.premium=x_sPremium;
            _oMobileRetentionPreviousOrder.m_3rd_id_type=x_sM_3rd_id_type;
            _oMobileRetentionPreviousOrder.gift_imei2=x_sGift_imei2;
            _oMobileRetentionPreviousOrder.reasons=x_sReasons;
            _oMobileRetentionPreviousOrder.language=x_sLanguage;
            _oMobileRetentionPreviousOrder.rebate_amount=x_sRebate_amount;
            _oMobileRetentionPreviousOrder.lob=x_sLob;
            _oMobileRetentionPreviousOrder.m_3rd_contact_no=x_sM_3rd_contact_no;
            _oMobileRetentionPreviousOrder.staff_no=x_sStaff_no;
            _oMobileRetentionPreviousOrder.s_premium3=x_sS_premium3;
            _oMobileRetentionPreviousOrder.sp_d_date=x_dSp_d_date;
            _oMobileRetentionPreviousOrder.bundle_name=x_sBundle_name;
            _oMobileRetentionPreviousOrder.accessory_waive=x_bAccessory_waive;
            _oMobileRetentionPreviousOrder.sim_item_code=x_sSim_item_code;
            _oMobileRetentionPreviousOrder.monthly_bank_account_holder=x_sMonthly_bank_account_holder;
            _oMobileRetentionPreviousOrder.card_holder=x_sCard_holder;
            if(InsertWithLastID_SP(x_oDB, _oMobileRetentionPreviousOrder,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(MobileRetentionPreviousOrder x_oMobileRetentionPreviousOrder)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oMobileRetentionPreviousOrder, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileRetentionPreviousOrder x_oMobileRetentionPreviousOrder)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oMobileRetentionPreviousOrder, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileRetentionPreviousOrder)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (MobileRetentionPreviousOrder)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,MobileRetentionPreviousOrder x_oMobileRetentionPreviousOrder, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "MOBILERETENTIONPREVIOUSORDER";
            global::System.Data.SqlClient.SqlConnection _oConn = null;
            global::System.Data.SqlClient.SqlCommand _oCmd = null;
            if (x_oDB.bTransaction)
            {
                x_oDB.ISessionCmd.CommandText = _sQuery;
                x_oDB.ISessionCmd.Parameters.Clear();
                _oCmd = x_oDB.ISessionCmd;
                _oConn = x_oDB.ISessionConn;
            }
            else
            {
                _oConn = x_oDB.GetConnection();
                _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            }
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oMobileRetentionPreviousOrder,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileRetentionPreviousOrder x_oMobileRetentionPreviousOrder, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@gift_imei", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.gift_imei==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.gift_imei; }
                _oPar=x_oCmd.Parameters.Add("@s_premium4", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.s_premium4==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.s_premium4; }
                _oPar=x_oCmd.Parameters.Add("@upgrade_existing_customer_type", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.upgrade_existing_customer_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.upgrade_existing_customer_type; }
                _oPar=x_oCmd.Parameters.Add("@gift_desc4", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.gift_desc4==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.gift_desc4; }
                _oPar=x_oCmd.Parameters.Add("@accessory_desc", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.accessory_desc==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.accessory_desc; }
                _oPar=x_oCmd.Parameters.Add("@staff_name", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.staff_name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.staff_name; }
                _oPar=x_oCmd.Parameters.Add("@action_required", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.action_required==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.action_required; }
                _oPar=x_oCmd.Parameters.Add("@registered_address_his_id", global::System.Data.SqlDbType.BigInt);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.registered_address_his_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.registered_address_his_id; }
                _oPar=x_oCmd.Parameters.Add("@vas_eff_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.vas_eff_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.vas_eff_date; }
                _oPar=x_oCmd.Parameters.Add("@monthly_bank_account_bank_code", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.monthly_bank_account_bank_code==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.monthly_bank_account_bank_code; }
                _oPar=x_oCmd.Parameters.Add("@sim_item_number", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.sim_item_number==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.sim_item_number; }
                _oPar=x_oCmd.Parameters.Add("@special_handling_dummy_code", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.special_handling_dummy_code==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.special_handling_dummy_code; }
                _oPar=x_oCmd.Parameters.Add("@card_no", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.card_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.card_no; }
                _oPar=x_oCmd.Parameters.Add("@m_card_exp_year", global::System.Data.SqlDbType.NVarChar,4);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.m_card_exp_year==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.m_card_exp_year; }
                _oPar=x_oCmd.Parameters.Add("@bill_medium_email", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.bill_medium_email==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.bill_medium_email; }
                _oPar=x_oCmd.Parameters.Add("@remarks2PY", global::System.Data.SqlDbType.Text);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.remarks2PY==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.remarks2PY; }
                _oPar=x_oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.trade_field==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.trade_field; }
                _oPar=x_oCmd.Parameters.Add("@ord_place_tel", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.ord_place_tel==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.ord_place_tel; }
                _oPar=x_oCmd.Parameters.Add("@action_of_rate_plan_effective", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.action_of_rate_plan_effective==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.action_of_rate_plan_effective; }
                _oPar=x_oCmd.Parameters.Add("@cooling_offer", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.cooling_offer==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.cooling_offer; }
                _oPar=x_oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.rec_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.rec_no; }
                _oPar=x_oCmd.Parameters.Add("@upgrade_handset_offer_rebate_schedule", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.upgrade_handset_offer_rebate_schedule==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.upgrade_handset_offer_rebate_schedule; }
                _oPar=x_oCmd.Parameters.Add("@change_payment_type", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.change_payment_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.change_payment_type; }
                _oPar=x_oCmd.Parameters.Add("@date_of_birth", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.date_of_birth==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.date_of_birth; }
                _oPar=x_oCmd.Parameters.Add("@contact_person", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.contact_person==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.contact_person; }
                _oPar=x_oCmd.Parameters.Add("@extra_d_charge", global::System.Data.SqlDbType.NVarChar,5);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.extra_d_charge==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.extra_d_charge; }
                _oPar=x_oCmd.Parameters.Add("@tl_name", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.tl_name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.tl_name; }
                _oPar=x_oCmd.Parameters.Add("@fast_start", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.fast_start==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.fast_start; }
                _oPar=x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.issue_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.issue_type; }
                _oPar=x_oCmd.Parameters.Add("@sp_ref_no", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.sp_ref_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.sp_ref_no; }
                _oPar=x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.edate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.edate; }
                _oPar=x_oCmd.Parameters.Add("@exist_cust_plan", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.exist_cust_plan==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.exist_cust_plan; }
                _oPar=x_oCmd.Parameters.Add("@ord_place_rel", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.ord_place_rel==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.ord_place_rel; }
                _oPar=x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.mrt_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.mrt_no; }
                _oPar=x_oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,30);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.imei_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.imei_no; }
                _oPar=x_oCmd.Parameters.Add("@existing_smart_phone_model", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.existing_smart_phone_model==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.existing_smart_phone_model; }
                _oPar=x_oCmd.Parameters.Add("@bank_code", global::System.Data.SqlDbType.NVarChar,30);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.bank_code==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.bank_code; }
                _oPar=x_oCmd.Parameters.Add("@pos_ref_no", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.pos_ref_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.pos_ref_no; }
                _oPar=x_oCmd.Parameters.Add("@bill_cut_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.bill_cut_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.bill_cut_date; }
                _oPar=x_oCmd.Parameters.Add("@gift_imei3", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.gift_imei3==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.gift_imei3; }
                _oPar=x_oCmd.Parameters.Add("@exist_plan", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.exist_plan==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.exist_plan; }
                _oPar=x_oCmd.Parameters.Add("@waive", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.waive==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.waive; }
                _oPar=x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.program==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.program; }
                _oPar=x_oCmd.Parameters.Add("@first_month_fee", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.first_month_fee==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.first_month_fee; }
                _oPar=x_oCmd.Parameters.Add("@r_offer", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.r_offer==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.r_offer; }
                _oPar=x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.cid; }
                _oPar=x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.did==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.did; }
                _oPar=x_oCmd.Parameters.Add("@ftg_tenure", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.ftg_tenure==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.ftg_tenure; }
                _oPar=x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.con_per==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.con_per; }
                _oPar=x_oCmd.Parameters.Add("@gift_code4", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.gift_code4==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.gift_code4; }
                _oPar=x_oCmd.Parameters.Add("@easywatch_type", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.easywatch_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.easywatch_type; }
                _oPar=x_oCmd.Parameters.Add("@sms_mrt", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.sms_mrt==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.sms_mrt; }
                _oPar=x_oCmd.Parameters.Add("@tpy_his_id", global::System.Data.SqlDbType.BigInt);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.tpy_his_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.tpy_his_id; }
                _oPar=x_oCmd.Parameters.Add("@monthly_payment_method", global::System.Data.SqlDbType.NVarChar,40);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.monthly_payment_method==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.monthly_payment_method; }
                _oPar=x_oCmd.Parameters.Add("@remarks2EDF", global::System.Data.SqlDbType.Text);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.remarks2EDF==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.remarks2EDF; }
                _oPar=x_oCmd.Parameters.Add("@gift_desc3", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.gift_desc3==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.gift_desc3; }
                _oPar=x_oCmd.Parameters.Add("@gift_imei4", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.gift_imei4==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.gift_imei4; }
                _oPar=x_oCmd.Parameters.Add("@monthly_bank_account_hkid2", global::System.Data.SqlDbType.NVarChar,1);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.monthly_bank_account_hkid2==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.monthly_bank_account_hkid2; }
                _oPar=x_oCmd.Parameters.Add("@d_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.d_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.d_date; }
                _oPar=x_oCmd.Parameters.Add("@gift_desc", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.gift_desc==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.gift_desc; }
                _oPar=x_oCmd.Parameters.Add("@pool", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.pool==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.pool; }
                _oPar=x_oCmd.Parameters.Add("@cn_mrt_no", global::System.Data.SqlDbType.BigInt);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.cn_mrt_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.cn_mrt_no; }
                _oPar=x_oCmd.Parameters.Add("@accessory_imei", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.accessory_imei==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.accessory_imei; }
                _oPar=x_oCmd.Parameters.Add("@third_party_credit_card", global::System.Data.SqlDbType.NVarChar,5);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.third_party_credit_card==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.third_party_credit_card; }
                _oPar=x_oCmd.Parameters.Add("@special_approval", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.special_approval==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.special_approval; }
                _oPar=x_oCmd.Parameters.Add("@upgrade_existing_contract_edate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.upgrade_existing_contract_edate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.upgrade_existing_contract_edate; }
                _oPar=x_oCmd.Parameters.Add("@accessory_code", global::System.Data.SqlDbType.NVarChar,70);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.accessory_code==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.accessory_code; }
                _oPar=x_oCmd.Parameters.Add("@s_premium", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.s_premium==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.s_premium; }
                _oPar=x_oCmd.Parameters.Add("@ref_staff_no", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.ref_staff_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.ref_staff_no; }
                _oPar=x_oCmd.Parameters.Add("@accessory_price", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.accessory_price==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.accessory_price; }
                _oPar=x_oCmd.Parameters.Add("@m_card_exp_month", global::System.Data.SqlDbType.NVarChar,2);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.m_card_exp_month==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.m_card_exp_month; }
                _oPar=x_oCmd.Parameters.Add("@installment_period", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.installment_period==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.installment_period; }
                _oPar=x_oCmd.Parameters.Add("@m_card_type", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.m_card_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.m_card_type; }
                _oPar=x_oCmd.Parameters.Add("@easywatch_ord_id", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.easywatch_ord_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.easywatch_ord_id; }
                _oPar=x_oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.normal_rebate==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.normal_rebate; }
                _oPar=x_oCmd.Parameters.Add("@m_rebate_amount", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.m_rebate_amount==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.m_rebate_amount; }
                _oPar=x_oCmd.Parameters.Add("@m_card_holder2", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.m_card_holder2==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.m_card_holder2; }
                _oPar=x_oCmd.Parameters.Add("@monthly_bank_account_holder", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.monthly_bank_account_holder==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.monthly_bank_account_holder; }
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.active; }
                _oPar=x_oCmd.Parameters.Add("@s_premium1", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.s_premium1==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.s_premium1; }
                _oPar=x_oCmd.Parameters.Add("@card_exp_month", global::System.Data.SqlDbType.NVarChar,2);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.card_exp_month==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.card_exp_month; }
                _oPar=x_oCmd.Parameters.Add("@ob_program_id", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.ob_program_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.ob_program_id; }
                _oPar=x_oCmd.Parameters.Add("@sku", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.sku==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.sku; }
                _oPar=x_oCmd.Parameters.Add("@salesmancode", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.salesmancode==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.salesmancode; }
                _oPar=x_oCmd.Parameters.Add("@go_wireless_package_code", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.go_wireless_package_code==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.go_wireless_package_code; }
                _oPar=x_oCmd.Parameters.Add("@lob", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.lob==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.lob; }
                _oPar=x_oCmd.Parameters.Add("@ref_salesmancode", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.ref_salesmancode==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.ref_salesmancode; }
                _oPar=x_oCmd.Parameters.Add("@third_party_hkid", global::System.Data.SqlDbType.NVarChar,30);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.third_party_hkid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.third_party_hkid; }
                _oPar=x_oCmd.Parameters.Add("@upgrade_existing_pccw_customer", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.upgrade_existing_pccw_customer==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.upgrade_existing_pccw_customer; }
                _oPar=x_oCmd.Parameters.Add("@d_address", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.d_address==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.d_address; }
                _oPar=x_oCmd.Parameters.Add("@upgrade_registered_mobile_no", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.upgrade_registered_mobile_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.upgrade_registered_mobile_no; }
                _oPar=x_oCmd.Parameters.Add("@gift_code3", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.gift_code3==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.gift_code3; }
                _oPar=x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.normal_rebate_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.normal_rebate_type; }
                _oPar=x_oCmd.Parameters.Add("@gift_desc2", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.gift_desc2==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.gift_desc2; }
                _oPar=x_oCmd.Parameters.Add("@monthly_bank_account_branch_code", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.monthly_bank_account_branch_code==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.monthly_bank_account_branch_code; }
                _oPar=x_oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.Text);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.remarks==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.remarks; }
                _oPar=x_oCmd.Parameters.Add("@accept", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.accept==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.accept; }
                _oPar=x_oCmd.Parameters.Add("@delivery_exchange", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.delivery_exchange==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.delivery_exchange; }
                _oPar=x_oCmd.Parameters.Add("@gift_code2", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.gift_code2==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.gift_code2; }
                _oPar=x_oCmd.Parameters.Add("@prepayment_waive", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.prepayment_waive==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.prepayment_waive; }
                _oPar=x_oCmd.Parameters.Add("@existing_smart_phone_imei", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.existing_smart_phone_imei==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.existing_smart_phone_imei; }
                _oPar=x_oCmd.Parameters.Add("@mnp_his_id", global::System.Data.SqlDbType.BigInt);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.mnp_his_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.mnp_his_id; }
                _oPar=x_oCmd.Parameters.Add("@cust_name", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.cust_name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.cust_name; }
                _oPar=x_oCmd.Parameters.Add("@upgrade_sponsorships_amount", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.upgrade_sponsorships_amount==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.upgrade_sponsorships_amount; }
                _oPar=x_oCmd.Parameters.Add("@bill_medium_waive", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.bill_medium_waive==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.bill_medium_waive; }
                _oPar=x_oCmd.Parameters.Add("@delivery_exchange_location", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.delivery_exchange_location==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.delivery_exchange_location; }
                _oPar=x_oCmd.Parameters.Add("@hs_offer_type_id", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.hs_offer_type_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.hs_offer_type_id; }
                _oPar=x_oCmd.Parameters.Add("@org_fee", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.org_fee==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.org_fee; }
                _oPar=x_oCmd.Parameters.Add("@rebate", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.rebate==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.rebate; }
                _oPar=x_oCmd.Parameters.Add("@upgrade_type", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.upgrade_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.upgrade_type; }
                _oPar=x_oCmd.Parameters.Add("@go_wireless", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.go_wireless==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.go_wireless; }
                _oPar=x_oCmd.Parameters.Add("@extra_rebate", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.extra_rebate==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.extra_rebate; }
                _oPar=x_oCmd.Parameters.Add("@plan_eff", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.plan_eff==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.plan_eff; }
                _oPar=x_oCmd.Parameters.Add("@extra_rebate_amount", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.extra_rebate_amount==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.extra_rebate_amount; }
                _oPar=x_oCmd.Parameters.Add("@card_exp_year", global::System.Data.SqlDbType.NVarChar,4);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.card_exp_year==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.card_exp_year; }
                _oPar=x_oCmd.Parameters.Add("@upgrade_existing_contract_sdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.upgrade_existing_contract_sdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.upgrade_existing_contract_sdate; }
                _oPar=x_oCmd.Parameters.Add("@ord_place_hkid", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.ord_place_hkid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.ord_place_hkid; }
                _oPar=x_oCmd.Parameters.Add("@register_address", global::System.Data.SqlDbType.NVarChar,200);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.register_address==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.register_address; }
                _oPar=x_oCmd.Parameters.Add("@gender", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.gender==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.gender; }
                _oPar=x_oCmd.Parameters.Add("@lob_ac", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.lob_ac==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.lob_ac; }
                _oPar=x_oCmd.Parameters.Add("@sim_mrt_no", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.sim_mrt_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.sim_mrt_no; }
                _oPar=x_oCmd.Parameters.Add("@redemption_notice_option", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.redemption_notice_option==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.redemption_notice_option; }
                _oPar=x_oCmd.Parameters.Add("@delivery_collection_type", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.delivery_collection_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.delivery_collection_type; }
                _oPar=x_oCmd.Parameters.Add("@action_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.action_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.action_date; }
                _oPar=x_oCmd.Parameters.Add("@third_party_id_type", global::System.Data.SqlDbType.NVarChar,30);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.third_party_id_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.third_party_id_type; }
                _oPar=x_oCmd.Parameters.Add("@org_ftg", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.org_ftg==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.org_ftg; }
                _oPar=x_oCmd.Parameters.Add("@upgrade_service_tenure", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.upgrade_service_tenure==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.upgrade_service_tenure; }
                _oPar=x_oCmd.Parameters.Add("@monthly_payment_type", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.monthly_payment_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.monthly_payment_type; }
                _oPar=x_oCmd.Parameters.Add("@contact_no", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.contact_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.contact_no; }
                _oPar=x_oCmd.Parameters.Add("@org_mrt", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.org_mrt==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.org_mrt; }
                _oPar=x_oCmd.Parameters.Add("@sim_item_name", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.sim_item_name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.sim_item_name; }
                _oPar=x_oCmd.Parameters.Add("@pay_method", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.pay_method==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.pay_method; }
                _oPar=x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.hs_model==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.hs_model; }
                _oPar=x_oCmd.Parameters.Add("@gift_code", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.gift_code==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.gift_code; }
                _oPar=x_oCmd.Parameters.Add("@monthly_bank_account_hkid", global::System.Data.SqlDbType.NVarChar,30);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.monthly_bank_account_hkid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.monthly_bank_account_hkid; }
                _oPar=x_oCmd.Parameters.Add("@extra_offer", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.extra_offer==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.extra_offer; }
                _oPar=x_oCmd.Parameters.Add("@monthly_bank_account_no", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.monthly_bank_account_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.monthly_bank_account_no; }
                _oPar=x_oCmd.Parameters.Add("@first_month_license_fee", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.first_month_license_fee==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.first_month_license_fee; }
                _oPar=x_oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.retrieve_cnt==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.retrieve_cnt; }
                _oPar=x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.ddate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.ddate; }
                _oPar=x_oCmd.Parameters.Add("@s_premium2", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.s_premium2==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.s_premium2; }
                _oPar=x_oCmd.Parameters.Add("@monthly_bank_account_id_type", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.monthly_bank_account_id_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.monthly_bank_account_id_type; }
                _oPar=x_oCmd.Parameters.Add("@card_type", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.card_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.card_type; }
                _oPar=x_oCmd.Parameters.Add("@next_bill", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.next_bill==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.next_bill; }
                _oPar=x_oCmd.Parameters.Add("@pcd_paid_go_wireless", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.pcd_paid_go_wireless==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.pcd_paid_go_wireless; }
                _oPar=x_oCmd.Parameters.Add("@upgrade_rebate_calculation", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.upgrade_rebate_calculation==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.upgrade_rebate_calculation; }
                _oPar=x_oCmd.Parameters.Add("@ext_place_tel", global::System.Data.SqlDbType.NVarChar,30);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.ext_place_tel==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.ext_place_tel; }
                _oPar=x_oCmd.Parameters.Add("@m_3rd_hkid", global::System.Data.SqlDbType.NVarChar,30);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.m_3rd_hkid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.m_3rd_hkid; }
                _oPar=x_oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.Char,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.retention_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.retention_type; }
                _oPar=x_oCmd.Parameters.Add("@bill_address_his_id", global::System.Data.SqlDbType.BigInt);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.bill_address_his_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.bill_address_his_id; }
                _oPar=x_oCmd.Parameters.Add("@aig_gift", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.aig_gift==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.aig_gift; }
                _oPar=x_oCmd.Parameters.Add("@cust_staff_no", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.cust_staff_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.cust_staff_no; }
                _oPar=x_oCmd.Parameters.Add("@family_name", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.family_name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.family_name; }
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.cdate; }
                _oPar=x_oCmd.Parameters.Add("@status_by_cs_admin", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.status_by_cs_admin==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.status_by_cs_admin; }
                _oPar=x_oCmd.Parameters.Add("@given_name", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.given_name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.given_name; }
                _oPar=x_oCmd.Parameters.Add("@vip_case", global::System.Data.SqlDbType.NVarChar,200);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.vip_case==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.vip_case; }
                _oPar=x_oCmd.Parameters.Add("@s_premium3", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.s_premium3==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.s_premium3; }
                _oPar=x_oCmd.Parameters.Add("@log_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.log_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.log_date; }
                _oPar=x_oCmd.Parameters.Add("@extn", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.extn==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.extn; }
                _oPar=x_oCmd.Parameters.Add("@d_time", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.d_time==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.d_time; }
                _oPar=x_oCmd.Parameters.Add("@bank_name", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.bank_name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.bank_name; }
                _oPar=x_oCmd.Parameters.Add("@delivery_exchange_option", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.delivery_exchange_option==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.delivery_exchange_option; }
                _oPar=x_oCmd.Parameters.Add("@upgrade_service_account_no", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.upgrade_service_account_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.upgrade_service_account_no; }
                _oPar=x_oCmd.Parameters.Add("@old_ord_id", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.old_ord_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.old_ord_id; }
                _oPar=x_oCmd.Parameters.Add("@m_card_no", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.m_card_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.m_card_no; }
                _oPar=x_oCmd.Parameters.Add("@existing_contract_end_date", global::System.Data.SqlDbType.NVarChar,30);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.existing_contract_end_date==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.existing_contract_end_date; }
                _oPar=x_oCmd.Parameters.Add("@con_eff_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.con_eff_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.con_eff_date; }
                _oPar=x_oCmd.Parameters.Add("@m_3rd_hkid2", global::System.Data.SqlDbType.NVarChar,1);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.m_3rd_hkid2==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.m_3rd_hkid2; }
                _oPar=x_oCmd.Parameters.Add("@amount", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.amount==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.amount; }
                _oPar=x_oCmd.Parameters.Add("@m_3rd_id_type", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.m_3rd_id_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.m_3rd_id_type; }
                _oPar=x_oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.id_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.id_type; }
                _oPar=x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.rate_plan==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.rate_plan; }
                _oPar=x_oCmd.Parameters.Add("@channel", global::System.Data.SqlDbType.Char,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.channel==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.channel; }
                _oPar=x_oCmd.Parameters.Add("@action_eff_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.action_eff_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.action_eff_date; }
                _oPar=x_oCmd.Parameters.Add("@cooling_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.cooling_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.cooling_date; }
                _oPar=x_oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.free_mon==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.free_mon; }
                _oPar=x_oCmd.Parameters.Add("@plan_eff_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.plan_eff_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.plan_eff_date; }
                _oPar=x_oCmd.Parameters.Add("@teamcode", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.teamcode==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.teamcode; }
                _oPar=x_oCmd.Parameters.Add("@bill_medium", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.bill_medium==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.bill_medium; }
                _oPar=x_oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,15);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.edf_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.edf_no; }
                _oPar=x_oCmd.Parameters.Add("@ord_place_by", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.ord_place_by==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.ord_place_by; }
                _oPar=x_oCmd.Parameters.Add("@cancel_renew", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.cancel_renew==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.cancel_renew; }
                _oPar=x_oCmd.Parameters.Add("@preferred_languages", global::System.Data.SqlDbType.NVarChar,30);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.preferred_languages==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.preferred_languages; }
                _oPar=x_oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,30);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.hkid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.hkid; }
                _oPar=x_oCmd.Parameters.Add("@card_holder", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.card_holder==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.card_holder; }
                _oPar=x_oCmd.Parameters.Add("@ac_no", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.ac_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.ac_no; }
                _oPar=x_oCmd.Parameters.Add("@bill_cut_num", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.bill_cut_num==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.bill_cut_num; }
                _oPar=x_oCmd.Parameters.Add("@premium", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.premium==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.premium; }
                _oPar=x_oCmd.Parameters.Add("@del_remark", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.del_remark==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.del_remark; }
                _oPar=x_oCmd.Parameters.Add("@gift_imei2", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.gift_imei2==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.gift_imei2; }
                _oPar=x_oCmd.Parameters.Add("@reasons", global::System.Data.SqlDbType.Text);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.reasons==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.reasons; }
                _oPar=x_oCmd.Parameters.Add("@language", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.language==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.language; }
                _oPar=x_oCmd.Parameters.Add("@rebate_amount", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.rebate_amount==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.rebate_amount; }
                _oPar=x_oCmd.Parameters.Add("@ord_place_id_type", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.ord_place_id_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.ord_place_id_type; }
                _oPar=x_oCmd.Parameters.Add("@m_3rd_contact_no", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.m_3rd_contact_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.m_3rd_contact_no; }
                _oPar=x_oCmd.Parameters.Add("@staff_no", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.staff_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.staff_no; }
                _oPar=x_oCmd.Parameters.Add("@sp_d_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.sp_d_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.sp_d_date; }
                _oPar=x_oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.bundle_name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.bundle_name; }
                _oPar=x_oCmd.Parameters.Add("@accessory_waive", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.accessory_waive==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.accessory_waive; }
                _oPar=x_oCmd.Parameters.Add("@sim_item_code", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.sim_item_code==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.sim_item_code; }
                _oPar=x_oCmd.Parameters.Add("@cust_type", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.cust_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.cust_type; }
                _oPar=x_oCmd.Parameters.Add("@card_ref_no", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionPreviousOrder.card_ref_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionPreviousOrder.card_ref_no; }
                _oPar=x_oCmd.Parameters.Add("@RETURN_ORDER_ID", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Output;
                x_oCmd.CommandType = CommandType.StoredProcedure;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                _bResult = Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
                x_oLAST_ID = Int32.Parse(x_oCmd.Parameters["@RETURN_ORDER_ID"].Value.ToString());
            }
            catch { }
            finally
            {
                if (!x_oDB.bTransaction)
                {
                    x_oConn.Close();
                    x_oCmd.Dispose();
                    x_oConn.Dispose();
                }
            }
            return _bResult;
        }
        
        #region INSERT_MOBILERETENTIONPREVIOUSORDER Store Procedures
        ///-- =============================================
        ///-- Author:		<Author,Philip SW>
        ///-- Create date: <Create Date 2012-01-12>
        ///-- Description:	<Description,MOBILERETENTIONPREVIOUSORDER, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_MOBILERETENTIONPREVIOUSORDER Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_MOBILERETENTIONPREVIOUSORDER', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_MOBILERETENTIONPREVIOUSORDER;
        GO
        CREATE PROCEDURE INSERT_MOBILERETENTIONPREVIOUSORDER
        	-- Add the parameters for the stored procedure here
        @RETURN_ORDER_ID int output,
        @gift_imei nvarchar(50),
        @s_premium4 nvarchar(100),
        @gift_desc4 nvarchar(250),
        @accessory_desc nvarchar(50),
        @action_required nvarchar(50),
        @registered_address_his_id bigint,
        @vas_eff_date datetime,
        @monthly_bank_account_bank_code nvarchar(50),
        @special_handling_dummy_code nvarchar(100),
        @m_card_exp_year nvarchar(4),
        @remarks2PY text,
        @trade_field nvarchar(50),
        @ord_place_tel nvarchar(10),
        @ord_place_id_type nvarchar(50),
        @cooling_offer nvarchar(50),
        @rec_no int,
        @upgrade_handset_offer_rebate_schedule nvarchar(250),
        @change_payment_type nvarchar(20),
        @date_of_birth datetime,
        @contact_person nvarchar(100),
        @extra_d_charge nvarchar(5),
        @tl_name nvarchar(100),
        @fast_start bit,
        @sp_ref_no nvarchar(50),
        @edate datetime,
        @exist_cust_plan nvarchar(50),
        @ord_place_rel nvarchar(50),
        @mrt_no int,
        @imei_no nvarchar(30),
        @existing_smart_phone_model nvarchar(250),
        @gift_code3 nvarchar(50),
        @bank_code nvarchar(30),
        @pos_ref_no nvarchar(50),
        @bill_cut_date datetime,
        @gift_imei3 nvarchar(50),
        @exist_plan nvarchar(100),
        @waive bit,
        @program nvarchar(50),
        @first_month_fee nvarchar(100),
        @r_offer nvarchar(50),
        @cid nvarchar(10),
        @did nvarchar(10),
        @ftg_tenure nvarchar(100),
        @con_per nvarchar(10),
        @gift_code4 nvarchar(50),
        @easywatch_type nvarchar(20),
        @sms_mrt nvarchar(50),
        @tpy_his_id bigint,
        @monthly_payment_method nvarchar(40),
        @remarks2EDF text,
        @gift_desc3 nvarchar(250),
        @gift_imei4 nvarchar(50),
        @old_ord_id int,
        @monthly_bank_account_hkid2 nvarchar(1),
        @d_date datetime,
        @gift_desc nvarchar(250),
        @salesmancode nvarchar(10),
        @pool nvarchar(50),
        @cn_mrt_no bigint,
        @accessory_imei nvarchar(50),
        @third_party_credit_card nvarchar(5),
        @card_ref_no nvarchar(50),
        @cooling_date datetime,
        @special_approval nvarchar(50),
        @upgrade_existing_contract_edate datetime,
        @accessory_code nvarchar(70),
        @bill_medium nvarchar(50),
        @s_premium nvarchar(100),
        @ref_staff_no nvarchar(20),
        @accessory_price nvarchar(10),
        @m_card_exp_month nvarchar(2),
        @installment_period nvarchar(50),
        @m_card_type nvarchar(20),
        @easywatch_ord_id nvarchar(10),
        @normal_rebate bit,
        @m_rebate_amount nvarchar(50),
        @m_card_holder2 nvarchar(50),
        @bill_medium_email nvarchar(50),
        @active bit,
        @s_premium1 nvarchar(100),
        @card_exp_month nvarchar(2),
        @ob_program_id nvarchar(20),
        @sku nvarchar(50),
        @ref_salesmancode nvarchar(20),
        @go_wireless_package_code nvarchar(100),
        @third_party_hkid nvarchar(30),
        @upgrade_existing_pccw_customer nvarchar(250),
        @d_address nvarchar(250),
        @upgrade_registered_mobile_no nvarchar(100),
        @upgrade_existing_customer_type nvarchar(250),
        @normal_rebate_type nvarchar(100),
        @gift_desc2 nvarchar(250),
        @monthly_bank_account_branch_code nvarchar(50),
        @remarks text,
        @accept nvarchar(50),
        @delivery_exchange nvarchar(50),
        @gift_code2 nvarchar(50),
        @prepayment_waive bit,
        @existing_smart_phone_imei nvarchar(250),
        @mnp_his_id bigint,
        @cust_name nvarchar(250),
        @cust_type nvarchar(50),
        @upgrade_sponsorships_amount nvarchar(100),
        @bill_medium_waive bit,
        @delivery_exchange_location nvarchar(50),
        @hs_offer_type_id int,
        @org_fee nvarchar(50),
        @rebate nvarchar(20),
        @upgrade_type nvarchar(100),
        @go_wireless nvarchar(50),
        @extra_rebate nvarchar(10),
        @plan_eff nvarchar(20),
        @extra_rebate_amount nvarchar(50),
        @card_exp_year nvarchar(4),
        @upgrade_existing_contract_sdate datetime,
        @ord_place_hkid nvarchar(50),
        @register_address nvarchar(200),
        @gender nvarchar(50),
        @lob_ac nvarchar(20),
        @sim_mrt_no int,
        @redemption_notice_option nvarchar(100),
        @delivery_collection_type nvarchar(50),
        @action_date datetime,
        @third_party_id_type nvarchar(30),
        @org_ftg nvarchar(10),
        @upgrade_service_tenure nvarchar(100),
        @monthly_payment_type nvarchar(250),
        @contact_no nvarchar(20),
        @org_mrt int,
        @sim_item_name nvarchar(250),
        @pay_method nvarchar(50),
        @hs_model nvarchar(250),
        @gift_code nvarchar(50),
        @monthly_bank_account_hkid nvarchar(30),
        @extra_offer nvarchar(250),
        @monthly_bank_account_no nvarchar(50),
        @first_month_license_fee nvarchar(100),
        @retrieve_cnt int,
        @ddate datetime,
        @s_premium2 nvarchar(100),
        @monthly_bank_account_id_type nvarchar(10),
        @card_type nvarchar(20),
        @next_bill bit,
        @pcd_paid_go_wireless bit,
        @upgrade_rebate_calculation nvarchar(250),
        @ext_place_tel nvarchar(30),
        @m_3rd_hkid nvarchar(30),
        @retention_type char(10),
        @bill_address_his_id bigint,
        @aig_gift nvarchar(50),
        @cust_staff_no nvarchar(10),
        @family_name nvarchar(250),
        @cdate datetime,
        @status_by_cs_admin nvarchar(100),
        @sim_item_number nvarchar(250),
        @vip_case nvarchar(200),
        @given_name nvarchar(250),
        @log_date datetime,
        @extn nvarchar(10),
        @d_time nvarchar(10),
        @bank_name nvarchar(100),
        @delivery_exchange_option nvarchar(50),
        @upgrade_service_account_no nvarchar(250),
        @action_of_rate_plan_effective nvarchar(250),
        @m_card_no nvarchar(20),
        @existing_contract_end_date nvarchar(30),
        @con_eff_date datetime,
        @m_3rd_hkid2 nvarchar(1),
        @amount nvarchar(50),
        @id_type nvarchar(10),
        @rate_plan nvarchar(50),
        @channel char(10),
        @action_eff_date datetime,
        @issue_type nvarchar(50),
        @free_mon nvarchar(10),
        @plan_eff_date datetime,
        @del_remark nvarchar(250),
        @teamcode nvarchar(10),
        @staff_name nvarchar(100),
        @edf_no nvarchar(15),
        @ord_place_by nvarchar(250),
        @cancel_renew nvarchar(10),
        @preferred_languages nvarchar(30),
        @hkid nvarchar(30),
        @card_no nvarchar(20),
        @ac_no nvarchar(20),
        @bill_cut_num int,
        @premium nvarchar(250),
        @m_3rd_id_type nvarchar(10),
        @gift_imei2 nvarchar(50),
        @reasons text,
        @language nvarchar(100),
        @rebate_amount nvarchar(50),
        @lob nvarchar(50),
        @m_3rd_contact_no nvarchar(20),
        @staff_no nvarchar(10),
        @s_premium3 nvarchar(100),
        @sp_d_date datetime,
        @bundle_name nvarchar(50),
        @accessory_waive bit,
        @sim_item_code nvarchar(250),
        @monthly_bank_account_holder nvarchar(50),
        @card_holder nvarchar(100)
        AS
		
        

        
        INSERT INTO  [MobileRetentionPreviousOrder]   ([gift_imei],[s_premium4],[upgrade_existing_customer_type],[gift_desc4],[accessory_desc],[staff_name],[action_required],[registered_address_his_id],[vas_eff_date],[monthly_bank_account_bank_code],[sim_item_number],[special_handling_dummy_code],[card_no],[m_card_exp_year],[bill_medium_email],[remarks2PY],[trade_field],[ord_place_tel],[action_of_rate_plan_effective],[cooling_offer],[rec_no],[upgrade_handset_offer_rebate_schedule],[change_payment_type],[date_of_birth],[contact_person],[extra_d_charge],[tl_name],[fast_start],[issue_type],[sp_ref_no],[edate],[exist_cust_plan],[ord_place_rel],[mrt_no],[imei_no],[existing_smart_phone_model],[bank_code],[pos_ref_no],[bill_cut_date],[gift_imei3],[exist_plan],[waive],[program],[first_month_fee],[r_offer],[cid],[did],[ftg_tenure],[con_per],[gift_code4],[easywatch_type],[sms_mrt],[tpy_his_id],[monthly_payment_method],[remarks2EDF],[gift_desc3],[gift_imei4],[monthly_bank_account_hkid2],[d_date],[gift_desc],[pool],[cn_mrt_no],[accessory_imei],[third_party_credit_card],[special_approval],[upgrade_existing_contract_edate],[accessory_code],[s_premium],[ref_staff_no],[accessory_price],[m_card_exp_month],[installment_period],[m_card_type],[easywatch_ord_id],[normal_rebate],[m_rebate_amount],[m_card_holder2],[monthly_bank_account_holder],[active],[s_premium1],[card_exp_month],[ob_program_id],[sku],[salesmancode],[go_wireless_package_code],[lob],[ref_salesmancode],[third_party_hkid],[upgrade_existing_pccw_customer],[d_address],[upgrade_registered_mobile_no],[gift_code3],[normal_rebate_type],[gift_desc2],[monthly_bank_account_branch_code],[remarks],[accept],[delivery_exchange],[gift_code2],[prepayment_waive],[existing_smart_phone_imei],[mnp_his_id],[cust_name],[upgrade_sponsorships_amount],[bill_medium_waive],[delivery_exchange_location],[hs_offer_type_id],[org_fee],[rebate],[upgrade_type],[go_wireless],[extra_rebate],[plan_eff],[extra_rebate_amount],[card_exp_year],[upgrade_existing_contract_sdate],[ord_place_hkid],[register_address],[gender],[lob_ac],[sim_mrt_no],[redemption_notice_option],[delivery_collection_type],[action_date],[third_party_id_type],[org_ftg],[upgrade_service_tenure],[monthly_payment_type],[contact_no],[org_mrt],[sim_item_name],[pay_method],[hs_model],[gift_code],[monthly_bank_account_hkid],[extra_offer],[monthly_bank_account_no],[first_month_license_fee],[retrieve_cnt],[ddate],[s_premium2],[monthly_bank_account_id_type],[card_type],[next_bill],[pcd_paid_go_wireless],[upgrade_rebate_calculation],[ext_place_tel],[m_3rd_hkid],[retention_type],[bill_address_his_id],[aig_gift],[cust_staff_no],[family_name],[cdate],[status_by_cs_admin],[given_name],[vip_case],[s_premium3],[log_date],[extn],[d_time],[bank_name],[delivery_exchange_option],[upgrade_service_account_no],[old_ord_id],[m_card_no],[existing_contract_end_date],[con_eff_date],[m_3rd_hkid2],[amount],[m_3rd_id_type],[id_type],[rate_plan],[channel],[action_eff_date],[cooling_date],[free_mon],[plan_eff_date],[teamcode],[bill_medium],[edf_no],[ord_place_by],[cancel_renew],[preferred_languages],[hkid],[card_holder],[ac_no],[bill_cut_num],[premium],[del_remark],[gift_imei2],[reasons],[language],[rebate_amount],[ord_place_id_type],[m_3rd_contact_no],[staff_no],[sp_d_date],[bundle_name],[accessory_waive],[sim_item_code],[cust_type],[card_ref_no])  VALUES  (@gift_imei,@s_premium4,@upgrade_existing_customer_type,@gift_desc4,@accessory_desc,@staff_name,@action_required,@registered_address_his_id,@vas_eff_date,@monthly_bank_account_bank_code,@sim_item_number,@special_handling_dummy_code,@card_no,@m_card_exp_year,@bill_medium_email,@remarks2PY,@trade_field,@ord_place_tel,@action_of_rate_plan_effective,@cooling_offer,@rec_no,@upgrade_handset_offer_rebate_schedule,@change_payment_type,@date_of_birth,@contact_person,@extra_d_charge,@tl_name,@fast_start,@issue_type,@sp_ref_no,@edate,@exist_cust_plan,@ord_place_rel,@mrt_no,@imei_no,@existing_smart_phone_model,@bank_code,@pos_ref_no,@bill_cut_date,@gift_imei3,@exist_plan,@waive,@program,@first_month_fee,@r_offer,@cid,@did,@ftg_tenure,@con_per,@gift_code4,@easywatch_type,@sms_mrt,@tpy_his_id,@monthly_payment_method,@remarks2EDF,@gift_desc3,@gift_imei4,@monthly_bank_account_hkid2,@d_date,@gift_desc,@pool,@cn_mrt_no,@accessory_imei,@third_party_credit_card,@special_approval,@upgrade_existing_contract_edate,@accessory_code,@s_premium,@ref_staff_no,@accessory_price,@m_card_exp_month,@installment_period,@m_card_type,@easywatch_ord_id,@normal_rebate,@m_rebate_amount,@m_card_holder2,@monthly_bank_account_holder,@active,@s_premium1,@card_exp_month,@ob_program_id,@sku,@salesmancode,@go_wireless_package_code,@lob,@ref_salesmancode,@third_party_hkid,@upgrade_existing_pccw_customer,@d_address,@upgrade_registered_mobile_no,@gift_code3,@normal_rebate_type,@gift_desc2,@monthly_bank_account_branch_code,@remarks,@accept,@delivery_exchange,@gift_code2,@prepayment_waive,@existing_smart_phone_imei,@mnp_his_id,@cust_name,@upgrade_sponsorships_amount,@bill_medium_waive,@delivery_exchange_location,@hs_offer_type_id,@org_fee,@rebate,@upgrade_type,@go_wireless,@extra_rebate,@plan_eff,@extra_rebate_amount,@card_exp_year,@upgrade_existing_contract_sdate,@ord_place_hkid,@register_address,@gender,@lob_ac,@sim_mrt_no,@redemption_notice_option,@delivery_collection_type,@action_date,@third_party_id_type,@org_ftg,@upgrade_service_tenure,@monthly_payment_type,@contact_no,@org_mrt,@sim_item_name,@pay_method,@hs_model,@gift_code,@monthly_bank_account_hkid,@extra_offer,@monthly_bank_account_no,@first_month_license_fee,@retrieve_cnt,@ddate,@s_premium2,@monthly_bank_account_id_type,@card_type,@next_bill,@pcd_paid_go_wireless,@upgrade_rebate_calculation,@ext_place_tel,@m_3rd_hkid,@retention_type,@bill_address_his_id,@aig_gift,@cust_staff_no,@family_name,@cdate,@status_by_cs_admin,@given_name,@vip_case,@s_premium3,@log_date,@extn,@d_time,@bank_name,@delivery_exchange_option,@upgrade_service_account_no,@old_ord_id,@m_card_no,@existing_contract_end_date,@con_eff_date,@m_3rd_hkid2,@amount,@m_3rd_id_type,@id_type,@rate_plan,@channel,@action_eff_date,@cooling_date,@free_mon,@plan_eff_date,@teamcode,@bill_medium,@edf_no,@ord_place_by,@cancel_renew,@preferred_languages,@hkid,@card_holder,@ac_no,@bill_cut_num,@premium,@del_remark,@gift_imei2,@reasons,@language,@rebate_amount,@ord_place_id_type,@m_3rd_contact_no,@staff_no,@sp_d_date,@bundle_name,@accessory_waive,@sim_item_code,@cust_type,@card_ref_no)
        IF @@IDENTITY IS NOT NULL
        BEGIN
        SELECT @RETURN_ORDER_ID=@@IDENTITY
        RETURN @RETURN_ORDER_ID
        END
        ELSE
        BEGIN
        SET @RETURN_ORDER_ID=-1
        RETURN @RETURN_ORDER_ID
        END
        
        GO
        */
        #endregion
        
        #endregion
        
        #region Delete
        /// <summary>
        /// Summary description for management table deleting
        /// </summary>
        
        public bool Delete(global::System.Nullable<int> x_iOrder_id)
        {
            return DeleteProc(n_oDB, x_iOrder_id);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iOrder_id)
        {
            return DeleteProc(x_oDB, x_iOrder_id);
        }
        
        
        private static bool DeleteProc(MSSQLConnect x_oDB, global::System.Nullable<int> x_iOrder_id)
        {
            if (x_iOrder_id==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileRetentionPreviousOrder]  WHERE [MobileRetentionPreviousOrder].[order_id]=@order_id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionPreviousOrder]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionPreviousOrder]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult=false;
                _oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = x_iOrder_id;
                _oCmd.CommandType = CommandType.Text;
                try
                {
                    _oConn.Open();
                    _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
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
        }
        
        
        public bool DeleteAll()
        {
            if (n_oDB==null) { return false; }
            return MobileRetentionPreviousOrderRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileRetentionPreviousOrder]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionPreviousOrder]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionPreviousOrder]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oCmd.CommandType = CommandType.Text;
                bool _bResult = false;
                try
                {
                    _oConn.Open();
                    _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
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
        }
        
        
        public bool DeleteFilter(string x_sFilter)
        {
            return DeleteFilter(n_oDB,x_sFilter);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return false; }
            if (!"".Equals(x_sFilter)){x_sFilter=" WHERE "+x_sFilter;}
            string _sQuery = "DELETE FROM [MobileRetentionPreviousOrder]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionPreviousOrder]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionPreviousOrder]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult = false;
                _oCmd.CommandType = CommandType.Text;
                try
                {
                    _oConn.Open();
                    _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
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
        }
        #endregion
        
        void global::System.IDisposable.Dispose()
        {
            this.Dispose();
        }
        public void Dispose()
        {
        }
        
    }
}


