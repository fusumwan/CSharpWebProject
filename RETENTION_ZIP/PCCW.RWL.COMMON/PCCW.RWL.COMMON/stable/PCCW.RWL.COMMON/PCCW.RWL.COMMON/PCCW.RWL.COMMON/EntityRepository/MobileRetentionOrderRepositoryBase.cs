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
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2012-01-12>
///-- Description:	<Description,Table :[MobileRetentionOrder],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileRetentionOrder] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"MobileRetentionOrder")]
    public class MobileRetentionOrderRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static MobileRetentionOrderRepositoryBase instance;
        public static MobileRetentionOrderRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new MobileRetentionOrderRepositoryBase(_oDB);
            }
            return instance;
        }
        public static MobileRetentionOrderRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new MobileRetentionOrderRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<MobileRetentionOrderEntity> MobileRetentionOrders;
        #endregion
        
        #region Constructor
        public MobileRetentionOrderRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~MobileRetentionOrderRepositoryBase() { 
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
        public static MobileRetentionOrder CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new MobileRetentionOrder(_oDB);
        }
        
        public static MobileRetentionOrder CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new MobileRetentionOrder(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [MobileRetentionOrder]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionOrder]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrder]"); }
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
        
        
        public MobileRetentionOrderEntity GetObj(global::System.Nullable<int> x_iOrder_id)
        {
            return GetObj(n_oDB, x_iOrder_id);
        }
        
        
        public static MobileRetentionOrderEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iOrder_id)
        {
            if (x_oDB==null) { return null; }
            MobileRetentionOrder _MobileRetentionOrder = (MobileRetentionOrder)MobileRetentionOrderRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_MobileRetentionOrder.Load(x_iOrder_id)) { return null; }
            return _MobileRetentionOrder;
        }
        
        
        
        public static MobileRetentionOrderEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<MobileRetentionOrderEntity> _oMobileRetentionOrderList = GetListObj(x_oDB,0, "order_id", x_oArrayItemId);
            if(_oMobileRetentionOrderList==null){ return null;}
            return _oMobileRetentionOrderList.Count == 0 ? null : _oMobileRetentionOrderList.ToArray();
        }
        
        public static List<MobileRetentionOrderEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "order_id", x_oArrayItemId);
        }
        
        
        public static MobileRetentionOrderEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileRetentionOrderEntity> _oMobileRetentionOrderList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oMobileRetentionOrderList==null){ return null;}
            return _oMobileRetentionOrderList.Count == 0 ? null : _oMobileRetentionOrderList.ToArray();
        }
        
        
        public static MobileRetentionOrderEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileRetentionOrderEntity> _oMobileRetentionOrderList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oMobileRetentionOrderList==null){ return null;}
            return _oMobileRetentionOrderList.Count == 0 ? null : _oMobileRetentionOrderList.ToArray();
        }
        
        public static List<MobileRetentionOrderEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<MobileRetentionOrderEntity> _oRow = new List<MobileRetentionOrderEntity>();
            string _sQuery = "SELECT  "+_sTop+" [MobileRetentionOrder].[gift_imei] AS MOBILERETENTIONORDER_GIFT_IMEI,[MobileRetentionOrder].[s_premium4] AS MOBILERETENTIONORDER_S_PREMIUM4,[MobileRetentionOrder].[upgrade_existing_customer_type] AS MOBILERETENTIONORDER_UPGRADE_EXISTING_CUSTOMER_TYPE,[MobileRetentionOrder].[gift_desc4] AS MOBILERETENTIONORDER_GIFT_DESC4,[MobileRetentionOrder].[accessory_desc] AS MOBILERETENTIONORDER_ACCESSORY_DESC,[MobileRetentionOrder].[staff_name] AS MOBILERETENTIONORDER_STAFF_NAME,[MobileRetentionOrder].[action_required] AS MOBILERETENTIONORDER_ACTION_REQUIRED,[MobileRetentionOrder].[vas_eff_date] AS MOBILERETENTIONORDER_VAS_EFF_DATE,[MobileRetentionOrder].[monthly_bank_account_bank_code] AS MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_BANK_CODE,[MobileRetentionOrder].[sim_item_number] AS MOBILERETENTIONORDER_SIM_ITEM_NUMBER,[MobileRetentionOrder].[special_handling_dummy_code] AS MOBILERETENTIONORDER_SPECIAL_HANDLING_DUMMY_CODE,[MobileRetentionOrder].[card_no] AS MOBILERETENTIONORDER_CARD_NO,[MobileRetentionOrder].[m_card_exp_year] AS MOBILERETENTIONORDER_M_CARD_EXP_YEAR,[MobileRetentionOrder].[bill_medium_email] AS MOBILERETENTIONORDER_BILL_MEDIUM_EMAIL,[MobileRetentionOrder].[remarks2PY] AS MOBILERETENTIONORDER_REMARKS2PY,[MobileRetentionOrder].[trade_field] AS MOBILERETENTIONORDER_TRADE_FIELD,[MobileRetentionOrder].[ord_place_tel] AS MOBILERETENTIONORDER_ORD_PLACE_TEL,[MobileRetentionOrder].[action_of_rate_plan_effective] AS MOBILERETENTIONORDER_ACTION_OF_RATE_PLAN_EFFECTIVE,[MobileRetentionOrder].[cooling_offer] AS MOBILERETENTIONORDER_COOLING_OFFER,[MobileRetentionOrder].[upgrade_handset_offer_rebate_schedule] AS MOBILERETENTIONORDER_UPGRADE_HANDSET_OFFER_REBATE_SCHEDULE,[MobileRetentionOrder].[change_payment_type] AS MOBILERETENTIONORDER_CHANGE_PAYMENT_TYPE,[MobileRetentionOrder].[date_of_birth] AS MOBILERETENTIONORDER_DATE_OF_BIRTH,[MobileRetentionOrder].[contact_person] AS MOBILERETENTIONORDER_CONTACT_PERSON,[MobileRetentionOrder].[extra_d_charge] AS MOBILERETENTIONORDER_EXTRA_D_CHARGE,[MobileRetentionOrder].[tl_name] AS MOBILERETENTIONORDER_TL_NAME,[MobileRetentionOrder].[fast_start] AS MOBILERETENTIONORDER_FAST_START,[MobileRetentionOrder].[sp_ref_no] AS MOBILERETENTIONORDER_SP_REF_NO,[MobileRetentionOrder].[edate] AS MOBILERETENTIONORDER_EDATE,[MobileRetentionOrder].[exist_cust_plan] AS MOBILERETENTIONORDER_EXIST_CUST_PLAN,[MobileRetentionOrder].[ord_place_rel] AS MOBILERETENTIONORDER_ORD_PLACE_REL,[MobileRetentionOrder].[mrt_no] AS MOBILERETENTIONORDER_MRT_NO,[MobileRetentionOrder].[imei_no] AS MOBILERETENTIONORDER_IMEI_NO,[MobileRetentionOrder].[existing_smart_phone_model] AS MOBILERETENTIONORDER_EXISTING_SMART_PHONE_MODEL,[MobileRetentionOrder].[bank_code] AS MOBILERETENTIONORDER_BANK_CODE,[MobileRetentionOrder].[pos_ref_no] AS MOBILERETENTIONORDER_POS_REF_NO,[MobileRetentionOrder].[bill_cut_date] AS MOBILERETENTIONORDER_BILL_CUT_DATE,[MobileRetentionOrder].[gift_imei3] AS MOBILERETENTIONORDER_GIFT_IMEI3,[MobileRetentionOrder].[exist_plan] AS MOBILERETENTIONORDER_EXIST_PLAN,[MobileRetentionOrder].[waive] AS MOBILERETENTIONORDER_WAIVE,[MobileRetentionOrder].[program] AS MOBILERETENTIONORDER_PROGRAM,[MobileRetentionOrder].[first_month_fee] AS MOBILERETENTIONORDER_FIRST_MONTH_FEE,[MobileRetentionOrder].[r_offer] AS MOBILERETENTIONORDER_R_OFFER,[MobileRetentionOrder].[cid] AS MOBILERETENTIONORDER_CID,[MobileRetentionOrder].[did] AS MOBILERETENTIONORDER_DID,[MobileRetentionOrder].[ftg_tenure] AS MOBILERETENTIONORDER_FTG_TENURE,[MobileRetentionOrder].[con_per] AS MOBILERETENTIONORDER_CON_PER,[MobileRetentionOrder].[gift_code4] AS MOBILERETENTIONORDER_GIFT_CODE4,[MobileRetentionOrder].[easywatch_type] AS MOBILERETENTIONORDER_EASYWATCH_TYPE,[MobileRetentionOrder].[sms_mrt] AS MOBILERETENTIONORDER_SMS_MRT,[MobileRetentionOrder].[monthly_payment_method] AS MOBILERETENTIONORDER_MONTHLY_PAYMENT_METHOD,[MobileRetentionOrder].[remarks2EDF] AS MOBILERETENTIONORDER_REMARKS2EDF,[MobileRetentionOrder].[gift_desc3] AS MOBILERETENTIONORDER_GIFT_DESC3,[MobileRetentionOrder].[gift_imei4] AS MOBILERETENTIONORDER_GIFT_IMEI4,[MobileRetentionOrder].[monthly_bank_account_hkid2] AS MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HKID2,[MobileRetentionOrder].[d_date] AS MOBILERETENTIONORDER_D_DATE,[MobileRetentionOrder].[gift_desc] AS MOBILERETENTIONORDER_GIFT_DESC,[MobileRetentionOrder].[pool] AS MOBILERETENTIONORDER_POOL,[MobileRetentionOrder].[cn_mrt_no] AS MOBILERETENTIONORDER_CN_MRT_NO,[MobileRetentionOrder].[accessory_imei] AS MOBILERETENTIONORDER_ACCESSORY_IMEI,[MobileRetentionOrder].[third_party_credit_card] AS MOBILERETENTIONORDER_THIRD_PARTY_CREDIT_CARD,[MobileRetentionOrder].[special_approval] AS MOBILERETENTIONORDER_SPECIAL_APPROVAL,[MobileRetentionOrder].[upgrade_existing_contract_edate] AS MOBILERETENTIONORDER_UPGRADE_EXISTING_CONTRACT_EDATE,[MobileRetentionOrder].[accessory_code] AS MOBILERETENTIONORDER_ACCESSORY_CODE,[MobileRetentionOrder].[s_premium] AS MOBILERETENTIONORDER_S_PREMIUM,[MobileRetentionOrder].[ref_staff_no] AS MOBILERETENTIONORDER_REF_STAFF_NO,[MobileRetentionOrder].[accessory_price] AS MOBILERETENTIONORDER_ACCESSORY_PRICE,[MobileRetentionOrder].[m_card_exp_month] AS MOBILERETENTIONORDER_M_CARD_EXP_MONTH,[MobileRetentionOrder].[installment_period] AS MOBILERETENTIONORDER_INSTALLMENT_PERIOD,[MobileRetentionOrder].[m_card_type] AS MOBILERETENTIONORDER_M_CARD_TYPE,[MobileRetentionOrder].[easywatch_ord_id] AS MOBILERETENTIONORDER_EASYWATCH_ORD_ID,[MobileRetentionOrder].[normal_rebate] AS MOBILERETENTIONORDER_NORMAL_REBATE,[MobileRetentionOrder].[m_rebate_amount] AS MOBILERETENTIONORDER_M_REBATE_AMOUNT,[MobileRetentionOrder].[m_card_holder2] AS MOBILERETENTIONORDER_M_CARD_HOLDER2,[MobileRetentionOrder].[monthly_bank_account_holder] AS MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HOLDER,[MobileRetentionOrder].[active] AS MOBILERETENTIONORDER_ACTIVE,[MobileRetentionOrder].[s_premium1] AS MOBILERETENTIONORDER_S_PREMIUM1,[MobileRetentionOrder].[card_exp_month] AS MOBILERETENTIONORDER_CARD_EXP_MONTH,[MobileRetentionOrder].[ob_program_id] AS MOBILERETENTIONORDER_OB_PROGRAM_ID,[MobileRetentionOrder].[sku] AS MOBILERETENTIONORDER_SKU,[MobileRetentionOrder].[salesmancode] AS MOBILERETENTIONORDER_SALESMANCODE,[MobileRetentionOrder].[go_wireless_package_code] AS MOBILERETENTIONORDER_GO_WIRELESS_PACKAGE_CODE,[MobileRetentionOrder].[lob] AS MOBILERETENTIONORDER_LOB,[MobileRetentionOrder].[ref_salesmancode] AS MOBILERETENTIONORDER_REF_SALESMANCODE,[MobileRetentionOrder].[third_party_hkid] AS MOBILERETENTIONORDER_THIRD_PARTY_HKID,[MobileRetentionOrder].[upgrade_existing_pccw_customer] AS MOBILERETENTIONORDER_UPGRADE_EXISTING_PCCW_CUSTOMER,[MobileRetentionOrder].[d_address] AS MOBILERETENTIONORDER_D_ADDRESS,[MobileRetentionOrder].[upgrade_registered_mobile_no] AS MOBILERETENTIONORDER_UPGRADE_REGISTERED_MOBILE_NO,[MobileRetentionOrder].[gift_code3] AS MOBILERETENTIONORDER_GIFT_CODE3,[MobileRetentionOrder].[normal_rebate_type] AS MOBILERETENTIONORDER_NORMAL_REBATE_TYPE,[MobileRetentionOrder].[gift_desc2] AS MOBILERETENTIONORDER_GIFT_DESC2,[MobileRetentionOrder].[monthly_bank_account_branch_code] AS MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_BRANCH_CODE,[MobileRetentionOrder].[remarks] AS MOBILERETENTIONORDER_REMARKS,[MobileRetentionOrder].[accept] AS MOBILERETENTIONORDER_ACCEPT,[MobileRetentionOrder].[delivery_exchange] AS MOBILERETENTIONORDER_DELIVERY_EXCHANGE,[MobileRetentionOrder].[gift_code2] AS MOBILERETENTIONORDER_GIFT_CODE2,[MobileRetentionOrder].[prepayment_waive] AS MOBILERETENTIONORDER_PREPAYMENT_WAIVE,[MobileRetentionOrder].[existing_smart_phone_imei] AS MOBILERETENTIONORDER_EXISTING_SMART_PHONE_IMEI,[MobileRetentionOrder].[cust_name] AS MOBILERETENTIONORDER_CUST_NAME,[MobileRetentionOrder].[upgrade_sponsorships_amount] AS MOBILERETENTIONORDER_UPGRADE_SPONSORSHIPS_AMOUNT,[MobileRetentionOrder].[bill_medium_waive] AS MOBILERETENTIONORDER_BILL_MEDIUM_WAIVE,[MobileRetentionOrder].[delivery_exchange_location] AS MOBILERETENTIONORDER_DELIVERY_EXCHANGE_LOCATION,[MobileRetentionOrder].[hs_offer_type_id] AS MOBILERETENTIONORDER_HS_OFFER_TYPE_ID,[MobileRetentionOrder].[extra_rebate_amount] AS MOBILERETENTIONORDER_EXTRA_REBATE_AMOUNT,[MobileRetentionOrder].[rebate] AS MOBILERETENTIONORDER_REBATE,[MobileRetentionOrder].[upgrade_type] AS MOBILERETENTIONORDER_UPGRADE_TYPE,[MobileRetentionOrder].[go_wireless] AS MOBILERETENTIONORDER_GO_WIRELESS,[MobileRetentionOrder].[extra_rebate] AS MOBILERETENTIONORDER_EXTRA_REBATE,[MobileRetentionOrder].[plan_eff] AS MOBILERETENTIONORDER_PLAN_EFF,[MobileRetentionOrder].[card_exp_year] AS MOBILERETENTIONORDER_CARD_EXP_YEAR,[MobileRetentionOrder].[upgrade_existing_contract_sdate] AS MOBILERETENTIONORDER_UPGRADE_EXISTING_CONTRACT_SDATE,[MobileRetentionOrder].[ord_place_hkid] AS MOBILERETENTIONORDER_ORD_PLACE_HKID,[MobileRetentionOrder].[register_address] AS MOBILERETENTIONORDER_REGISTER_ADDRESS,[MobileRetentionOrder].[gender] AS MOBILERETENTIONORDER_GENDER,[MobileRetentionOrder].[lob_ac] AS MOBILERETENTIONORDER_LOB_AC,[MobileRetentionOrder].[sim_mrt_no] AS MOBILERETENTIONORDER_SIM_MRT_NO,[MobileRetentionOrder].[redemption_notice_option] AS MOBILERETENTIONORDER_REDEMPTION_NOTICE_OPTION,[MobileRetentionOrder].[delivery_collection_type] AS MOBILERETENTIONORDER_DELIVERY_COLLECTION_TYPE,[MobileRetentionOrder].[action_date] AS MOBILERETENTIONORDER_ACTION_DATE,[MobileRetentionOrder].[third_party_id_type] AS MOBILERETENTIONORDER_THIRD_PARTY_ID_TYPE,[MobileRetentionOrder].[org_ftg] AS MOBILERETENTIONORDER_ORG_FTG,[MobileRetentionOrder].[upgrade_service_tenure] AS MOBILERETENTIONORDER_UPGRADE_SERVICE_TENURE,[MobileRetentionOrder].[monthly_payment_type] AS MOBILERETENTIONORDER_MONTHLY_PAYMENT_TYPE,[MobileRetentionOrder].[contact_no] AS MOBILERETENTIONORDER_CONTACT_NO,[MobileRetentionOrder].[org_mrt] AS MOBILERETENTIONORDER_ORG_MRT,[MobileRetentionOrder].[sim_item_name] AS MOBILERETENTIONORDER_SIM_ITEM_NAME,[MobileRetentionOrder].[pay_method] AS MOBILERETENTIONORDER_PAY_METHOD,[MobileRetentionOrder].[hs_model] AS MOBILERETENTIONORDER_HS_MODEL,[MobileRetentionOrder].[gift_code] AS MOBILERETENTIONORDER_GIFT_CODE,[MobileRetentionOrder].[monthly_bank_account_hkid] AS MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HKID,[MobileRetentionOrder].[extra_offer] AS MOBILERETENTIONORDER_EXTRA_OFFER,[MobileRetentionOrder].[monthly_bank_account_no] AS MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_NO,[MobileRetentionOrder].[first_month_license_fee] AS MOBILERETENTIONORDER_FIRST_MONTH_LICENSE_FEE,[MobileRetentionOrder].[retrieve_cnt] AS MOBILERETENTIONORDER_RETRIEVE_CNT,[MobileRetentionOrder].[ddate] AS MOBILERETENTIONORDER_DDATE,[MobileRetentionOrder].[s_premium2] AS MOBILERETENTIONORDER_S_PREMIUM2,[MobileRetentionOrder].[monthly_bank_account_id_type] AS MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_ID_TYPE,[MobileRetentionOrder].[card_type] AS MOBILERETENTIONORDER_CARD_TYPE,[MobileRetentionOrder].[next_bill] AS MOBILERETENTIONORDER_NEXT_BILL,[MobileRetentionOrder].[pcd_paid_go_wireless] AS MOBILERETENTIONORDER_PCD_PAID_GO_WIRELESS,[MobileRetentionOrder].[upgrade_rebate_calculation] AS MOBILERETENTIONORDER_UPGRADE_REBATE_CALCULATION,[MobileRetentionOrder].[ext_place_tel] AS MOBILERETENTIONORDER_EXT_PLACE_TEL,[MobileRetentionOrder].[m_3rd_hkid] AS MOBILERETENTIONORDER_M_3RD_HKID,[MobileRetentionOrder].[retention_type] AS MOBILERETENTIONORDER_RETENTION_TYPE,[MobileRetentionOrder].[cooling_date] AS MOBILERETENTIONORDER_COOLING_DATE,[MobileRetentionOrder].[aig_gift] AS MOBILERETENTIONORDER_AIG_GIFT,[MobileRetentionOrder].[cust_staff_no] AS MOBILERETENTIONORDER_CUST_STAFF_NO,[MobileRetentionOrder].[order_id] AS MOBILERETENTIONORDER_ORDER_ID,[MobileRetentionOrder].[family_name] AS MOBILERETENTIONORDER_FAMILY_NAME,[MobileRetentionOrder].[cdate] AS MOBILERETENTIONORDER_CDATE,[MobileRetentionOrder].[status_by_cs_admin] AS MOBILERETENTIONORDER_STATUS_BY_CS_ADMIN,[MobileRetentionOrder].[given_name] AS MOBILERETENTIONORDER_GIVEN_NAME,[MobileRetentionOrder].[vip_case] AS MOBILERETENTIONORDER_VIP_CASE,[MobileRetentionOrder].[org_fee] AS MOBILERETENTIONORDER_ORG_FEE,[MobileRetentionOrder].[s_premium3] AS MOBILERETENTIONORDER_S_PREMIUM3,[MobileRetentionOrder].[log_date] AS MOBILERETENTIONORDER_LOG_DATE,[MobileRetentionOrder].[extn] AS MOBILERETENTIONORDER_EXTN,[MobileRetentionOrder].[d_time] AS MOBILERETENTIONORDER_D_TIME,[MobileRetentionOrder].[bank_name] AS MOBILERETENTIONORDER_BANK_NAME,[MobileRetentionOrder].[delivery_exchange_option] AS MOBILERETENTIONORDER_DELIVERY_EXCHANGE_OPTION,[MobileRetentionOrder].[upgrade_service_account_no] AS MOBILERETENTIONORDER_UPGRADE_SERVICE_ACCOUNT_NO,[MobileRetentionOrder].[old_ord_id] AS MOBILERETENTIONORDER_OLD_ORD_ID,[MobileRetentionOrder].[m_card_no] AS MOBILERETENTIONORDER_M_CARD_NO,[MobileRetentionOrder].[existing_contract_end_date] AS MOBILERETENTIONORDER_EXISTING_CONTRACT_END_DATE,[MobileRetentionOrder].[con_eff_date] AS MOBILERETENTIONORDER_CON_EFF_DATE,[MobileRetentionOrder].[m_3rd_hkid2] AS MOBILERETENTIONORDER_M_3RD_HKID2,[MobileRetentionOrder].[amount] AS MOBILERETENTIONORDER_AMOUNT,[MobileRetentionOrder].[m_3rd_id_type] AS MOBILERETENTIONORDER_M_3RD_ID_TYPE,[MobileRetentionOrder].[id_type] AS MOBILERETENTIONORDER_ID_TYPE,[MobileRetentionOrder].[rate_plan] AS MOBILERETENTIONORDER_RATE_PLAN,[MobileRetentionOrder].[channel] AS MOBILERETENTIONORDER_CHANNEL,[MobileRetentionOrder].[action_eff_date] AS MOBILERETENTIONORDER_ACTION_EFF_DATE,[MobileRetentionOrder].[issue_type] AS MOBILERETENTIONORDER_ISSUE_TYPE,[MobileRetentionOrder].[free_mon] AS MOBILERETENTIONORDER_FREE_MON,[MobileRetentionOrder].[plan_eff_date] AS MOBILERETENTIONORDER_PLAN_EFF_DATE,[MobileRetentionOrder].[teamcode] AS MOBILERETENTIONORDER_TEAMCODE,[MobileRetentionOrder].[bill_medium] AS MOBILERETENTIONORDER_BILL_MEDIUM,[MobileRetentionOrder].[edf_no] AS MOBILERETENTIONORDER_EDF_NO,[MobileRetentionOrder].[ord_place_by] AS MOBILERETENTIONORDER_ORD_PLACE_BY,[MobileRetentionOrder].[cancel_renew] AS MOBILERETENTIONORDER_CANCEL_RENEW,[MobileRetentionOrder].[preferred_languages] AS MOBILERETENTIONORDER_PREFERRED_LANGUAGES,[MobileRetentionOrder].[hkid] AS MOBILERETENTIONORDER_HKID,[MobileRetentionOrder].[card_holder] AS MOBILERETENTIONORDER_CARD_HOLDER,[MobileRetentionOrder].[ac_no] AS MOBILERETENTIONORDER_AC_NO,[MobileRetentionOrder].[bill_cut_num] AS MOBILERETENTIONORDER_BILL_CUT_NUM,[MobileRetentionOrder].[premium] AS MOBILERETENTIONORDER_PREMIUM,[MobileRetentionOrder].[del_remark] AS MOBILERETENTIONORDER_DEL_REMARK,[MobileRetentionOrder].[gift_imei2] AS MOBILERETENTIONORDER_GIFT_IMEI2,[MobileRetentionOrder].[reasons] AS MOBILERETENTIONORDER_REASONS,[MobileRetentionOrder].[language] AS MOBILERETENTIONORDER_LANGUAGE,[MobileRetentionOrder].[rebate_amount] AS MOBILERETENTIONORDER_REBATE_AMOUNT,[MobileRetentionOrder].[ord_place_id_type] AS MOBILERETENTIONORDER_ORD_PLACE_ID_TYPE,[MobileRetentionOrder].[m_3rd_contact_no] AS MOBILERETENTIONORDER_M_3RD_CONTACT_NO,[MobileRetentionOrder].[staff_no] AS MOBILERETENTIONORDER_STAFF_NO,[MobileRetentionOrder].[sp_d_date] AS MOBILERETENTIONORDER_SP_D_DATE,[MobileRetentionOrder].[bundle_name] AS MOBILERETENTIONORDER_BUNDLE_NAME,[MobileRetentionOrder].[accessory_waive] AS MOBILERETENTIONORDER_ACCESSORY_WAIVE,[MobileRetentionOrder].[sim_item_code] AS MOBILERETENTIONORDER_SIM_ITEM_CODE,[MobileRetentionOrder].[cust_type] AS MOBILERETENTIONORDER_CUST_TYPE,[MobileRetentionOrder].[card_ref_no] AS MOBILERETENTIONORDER_CARD_REF_NO  FROM  [MobileRetentionOrder]";
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
                _sQuery += " WHERE [MobileRetentionOrder].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionOrder]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrder]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        MobileRetentionOrder _oMobileRetentionOrder = MobileRetentionOrderRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_IMEI"])) {_oMobileRetentionOrder.gift_imei = (string)_oData["MOBILERETENTIONORDER_GIFT_IMEI"]; }else{_oMobileRetentionOrder.gift_imei=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_S_PREMIUM4"])) {_oMobileRetentionOrder.s_premium4 = (string)_oData["MOBILERETENTIONORDER_S_PREMIUM4"]; }else{_oMobileRetentionOrder.s_premium4=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_DESC4"])) {_oMobileRetentionOrder.gift_desc4 = (string)_oData["MOBILERETENTIONORDER_GIFT_DESC4"]; }else{_oMobileRetentionOrder.gift_desc4=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACCESSORY_DESC"])) {_oMobileRetentionOrder.accessory_desc = (string)_oData["MOBILERETENTIONORDER_ACCESSORY_DESC"]; }else{_oMobileRetentionOrder.accessory_desc=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACTION_REQUIRED"])) {_oMobileRetentionOrder.action_required = (string)_oData["MOBILERETENTIONORDER_ACTION_REQUIRED"]; }else{_oMobileRetentionOrder.action_required=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_VAS_EFF_DATE"])) {_oMobileRetentionOrder.vas_eff_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_VAS_EFF_DATE"]; }else{_oMobileRetentionOrder.vas_eff_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_BANK_CODE"])) {_oMobileRetentionOrder.monthly_bank_account_bank_code = (string)_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_BANK_CODE"]; }else{_oMobileRetentionOrder.monthly_bank_account_bank_code=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SPECIAL_HANDLING_DUMMY_CODE"])) {_oMobileRetentionOrder.special_handling_dummy_code = (string)_oData["MOBILERETENTIONORDER_SPECIAL_HANDLING_DUMMY_CODE"]; }else{_oMobileRetentionOrder.special_handling_dummy_code=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_CARD_EXP_YEAR"])) {_oMobileRetentionOrder.m_card_exp_year = (string)_oData["MOBILERETENTIONORDER_M_CARD_EXP_YEAR"]; }else{_oMobileRetentionOrder.m_card_exp_year=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REMARKS2PY"])) {_oMobileRetentionOrder.remarks2PY = (string)_oData["MOBILERETENTIONORDER_REMARKS2PY"]; }else{_oMobileRetentionOrder.remarks2PY=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_TRADE_FIELD"])) {_oMobileRetentionOrder.trade_field = (string)_oData["MOBILERETENTIONORDER_TRADE_FIELD"]; }else{_oMobileRetentionOrder.trade_field=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORD_PLACE_TEL"])) {_oMobileRetentionOrder.ord_place_tel = (string)_oData["MOBILERETENTIONORDER_ORD_PLACE_TEL"]; }else{_oMobileRetentionOrder.ord_place_tel=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORD_PLACE_ID_TYPE"])) {_oMobileRetentionOrder.ord_place_id_type = (string)_oData["MOBILERETENTIONORDER_ORD_PLACE_ID_TYPE"]; }else{_oMobileRetentionOrder.ord_place_id_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_COOLING_OFFER"])) {_oMobileRetentionOrder.cooling_offer = (string)_oData["MOBILERETENTIONORDER_COOLING_OFFER"]; }else{_oMobileRetentionOrder.cooling_offer=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_HANDSET_OFFER_REBATE_SCHEDULE"])) {_oMobileRetentionOrder.upgrade_handset_offer_rebate_schedule = (string)_oData["MOBILERETENTIONORDER_UPGRADE_HANDSET_OFFER_REBATE_SCHEDULE"]; }else{_oMobileRetentionOrder.upgrade_handset_offer_rebate_schedule=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CHANGE_PAYMENT_TYPE"])) {_oMobileRetentionOrder.change_payment_type = (string)_oData["MOBILERETENTIONORDER_CHANGE_PAYMENT_TYPE"]; }else{_oMobileRetentionOrder.change_payment_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_DATE_OF_BIRTH"])) {_oMobileRetentionOrder.date_of_birth = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_DATE_OF_BIRTH"]; }else{_oMobileRetentionOrder.date_of_birth=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CONTACT_PERSON"])) {_oMobileRetentionOrder.contact_person = (string)_oData["MOBILERETENTIONORDER_CONTACT_PERSON"]; }else{_oMobileRetentionOrder.contact_person=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXTRA_D_CHARGE"])) {_oMobileRetentionOrder.extra_d_charge = (string)_oData["MOBILERETENTIONORDER_EXTRA_D_CHARGE"]; }else{_oMobileRetentionOrder.extra_d_charge=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_TL_NAME"])) {_oMobileRetentionOrder.tl_name = (string)_oData["MOBILERETENTIONORDER_TL_NAME"]; }else{_oMobileRetentionOrder.tl_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_FAST_START"])) {_oMobileRetentionOrder.fast_start = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_FAST_START"]; }else{_oMobileRetentionOrder.fast_start=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SP_REF_NO"])) {_oMobileRetentionOrder.sp_ref_no = (string)_oData["MOBILERETENTIONORDER_SP_REF_NO"]; }else{_oMobileRetentionOrder.sp_ref_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EDATE"])) {_oMobileRetentionOrder.edate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_EDATE"]; }else{_oMobileRetentionOrder.edate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXIST_CUST_PLAN"])) {_oMobileRetentionOrder.exist_cust_plan = (string)_oData["MOBILERETENTIONORDER_EXIST_CUST_PLAN"]; }else{_oMobileRetentionOrder.exist_cust_plan=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORD_PLACE_REL"])) {_oMobileRetentionOrder.ord_place_rel = (string)_oData["MOBILERETENTIONORDER_ORD_PLACE_REL"]; }else{_oMobileRetentionOrder.ord_place_rel=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MRT_NO"])) {_oMobileRetentionOrder.mrt_no = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDER_MRT_NO"]; }else{_oMobileRetentionOrder.mrt_no=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_IMEI_NO"])) {_oMobileRetentionOrder.imei_no = (string)_oData["MOBILERETENTIONORDER_IMEI_NO"]; }else{_oMobileRetentionOrder.imei_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXISTING_SMART_PHONE_MODEL"])) {_oMobileRetentionOrder.existing_smart_phone_model = (string)_oData["MOBILERETENTIONORDER_EXISTING_SMART_PHONE_MODEL"]; }else{_oMobileRetentionOrder.existing_smart_phone_model=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_CODE3"])) {_oMobileRetentionOrder.gift_code3 = (string)_oData["MOBILERETENTIONORDER_GIFT_CODE3"]; }else{_oMobileRetentionOrder.gift_code3=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_BANK_CODE"])) {_oMobileRetentionOrder.bank_code = (string)_oData["MOBILERETENTIONORDER_BANK_CODE"]; }else{_oMobileRetentionOrder.bank_code=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_POS_REF_NO"])) {_oMobileRetentionOrder.pos_ref_no = (string)_oData["MOBILERETENTIONORDER_POS_REF_NO"]; }else{_oMobileRetentionOrder.pos_ref_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_BILL_CUT_DATE"])) {_oMobileRetentionOrder.bill_cut_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_BILL_CUT_DATE"]; }else{_oMobileRetentionOrder.bill_cut_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_IMEI3"])) {_oMobileRetentionOrder.gift_imei3 = (string)_oData["MOBILERETENTIONORDER_GIFT_IMEI3"]; }else{_oMobileRetentionOrder.gift_imei3=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXIST_PLAN"])) {_oMobileRetentionOrder.exist_plan = (string)_oData["MOBILERETENTIONORDER_EXIST_PLAN"]; }else{_oMobileRetentionOrder.exist_plan=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_WAIVE"])) {_oMobileRetentionOrder.waive = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_WAIVE"]; }else{_oMobileRetentionOrder.waive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_PROGRAM"])) {_oMobileRetentionOrder.program = (string)_oData["MOBILERETENTIONORDER_PROGRAM"]; }else{_oMobileRetentionOrder.program=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_FIRST_MONTH_FEE"])) {_oMobileRetentionOrder.first_month_fee = (string)_oData["MOBILERETENTIONORDER_FIRST_MONTH_FEE"]; }else{_oMobileRetentionOrder.first_month_fee=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_R_OFFER"])) {_oMobileRetentionOrder.r_offer = (string)_oData["MOBILERETENTIONORDER_R_OFFER"]; }else{_oMobileRetentionOrder.r_offer=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CID"])) {_oMobileRetentionOrder.cid = (string)_oData["MOBILERETENTIONORDER_CID"]; }else{_oMobileRetentionOrder.cid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_DID"])) {_oMobileRetentionOrder.did = (string)_oData["MOBILERETENTIONORDER_DID"]; }else{_oMobileRetentionOrder.did=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_FTG_TENURE"])) {_oMobileRetentionOrder.ftg_tenure = (string)_oData["MOBILERETENTIONORDER_FTG_TENURE"]; }else{_oMobileRetentionOrder.ftg_tenure=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CON_PER"])) {_oMobileRetentionOrder.con_per = (string)_oData["MOBILERETENTIONORDER_CON_PER"]; }else{_oMobileRetentionOrder.con_per=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_CODE4"])) {_oMobileRetentionOrder.gift_code4 = (string)_oData["MOBILERETENTIONORDER_GIFT_CODE4"]; }else{_oMobileRetentionOrder.gift_code4=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EASYWATCH_TYPE"])) {_oMobileRetentionOrder.easywatch_type = (string)_oData["MOBILERETENTIONORDER_EASYWATCH_TYPE"]; }else{_oMobileRetentionOrder.easywatch_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SMS_MRT"])) {_oMobileRetentionOrder.sms_mrt = (string)_oData["MOBILERETENTIONORDER_SMS_MRT"]; }else{_oMobileRetentionOrder.sms_mrt=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_PAYMENT_METHOD"])) {_oMobileRetentionOrder.monthly_payment_method = (string)_oData["MOBILERETENTIONORDER_MONTHLY_PAYMENT_METHOD"]; }else{_oMobileRetentionOrder.monthly_payment_method=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REMARKS2EDF"])) {_oMobileRetentionOrder.remarks2EDF = (string)_oData["MOBILERETENTIONORDER_REMARKS2EDF"]; }else{_oMobileRetentionOrder.remarks2EDF=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_DESC3"])) {_oMobileRetentionOrder.gift_desc3 = (string)_oData["MOBILERETENTIONORDER_GIFT_DESC3"]; }else{_oMobileRetentionOrder.gift_desc3=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_IMEI4"])) {_oMobileRetentionOrder.gift_imei4 = (string)_oData["MOBILERETENTIONORDER_GIFT_IMEI4"]; }else{_oMobileRetentionOrder.gift_imei4=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_OLD_ORD_ID"])) {_oMobileRetentionOrder.old_ord_id = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDER_OLD_ORD_ID"]; }else{_oMobileRetentionOrder.old_ord_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HKID2"])) {_oMobileRetentionOrder.monthly_bank_account_hkid2 = (string)_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HKID2"]; }else{_oMobileRetentionOrder.monthly_bank_account_hkid2=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_D_DATE"])) {_oMobileRetentionOrder.d_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_D_DATE"]; }else{_oMobileRetentionOrder.d_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_DESC"])) {_oMobileRetentionOrder.gift_desc = (string)_oData["MOBILERETENTIONORDER_GIFT_DESC"]; }else{_oMobileRetentionOrder.gift_desc=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SALESMANCODE"])) {_oMobileRetentionOrder.salesmancode = (string)_oData["MOBILERETENTIONORDER_SALESMANCODE"]; }else{_oMobileRetentionOrder.salesmancode=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_POOL"])) {_oMobileRetentionOrder.pool = (string)_oData["MOBILERETENTIONORDER_POOL"]; }else{_oMobileRetentionOrder.pool=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CN_MRT_NO"])) {_oMobileRetentionOrder.cn_mrt_no = (global::System.Nullable<long>)_oData["MOBILERETENTIONORDER_CN_MRT_NO"]; }else{_oMobileRetentionOrder.cn_mrt_no=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACCESSORY_IMEI"])) {_oMobileRetentionOrder.accessory_imei = (string)_oData["MOBILERETENTIONORDER_ACCESSORY_IMEI"]; }else{_oMobileRetentionOrder.accessory_imei=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_THIRD_PARTY_CREDIT_CARD"])) {_oMobileRetentionOrder.third_party_credit_card = (string)_oData["MOBILERETENTIONORDER_THIRD_PARTY_CREDIT_CARD"]; }else{_oMobileRetentionOrder.third_party_credit_card=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CARD_REF_NO"])) {_oMobileRetentionOrder.card_ref_no = (string)_oData["MOBILERETENTIONORDER_CARD_REF_NO"]; }else{_oMobileRetentionOrder.card_ref_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SPECIAL_APPROVAL"])) {_oMobileRetentionOrder.special_approval = (string)_oData["MOBILERETENTIONORDER_SPECIAL_APPROVAL"]; }else{_oMobileRetentionOrder.special_approval=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_EXISTING_CONTRACT_EDATE"])) {_oMobileRetentionOrder.upgrade_existing_contract_edate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_UPGRADE_EXISTING_CONTRACT_EDATE"]; }else{_oMobileRetentionOrder.upgrade_existing_contract_edate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACCESSORY_CODE"])) {_oMobileRetentionOrder.accessory_code = (string)_oData["MOBILERETENTIONORDER_ACCESSORY_CODE"]; }else{_oMobileRetentionOrder.accessory_code=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_BILL_MEDIUM"])) {_oMobileRetentionOrder.bill_medium = (string)_oData["MOBILERETENTIONORDER_BILL_MEDIUM"]; }else{_oMobileRetentionOrder.bill_medium=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_S_PREMIUM"])) {_oMobileRetentionOrder.s_premium = (string)_oData["MOBILERETENTIONORDER_S_PREMIUM"]; }else{_oMobileRetentionOrder.s_premium=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REF_STAFF_NO"])) {_oMobileRetentionOrder.ref_staff_no = (string)_oData["MOBILERETENTIONORDER_REF_STAFF_NO"]; }else{_oMobileRetentionOrder.ref_staff_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACCESSORY_PRICE"])) {_oMobileRetentionOrder.accessory_price = (string)_oData["MOBILERETENTIONORDER_ACCESSORY_PRICE"]; }else{_oMobileRetentionOrder.accessory_price=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_CARD_EXP_MONTH"])) {_oMobileRetentionOrder.m_card_exp_month = (string)_oData["MOBILERETENTIONORDER_M_CARD_EXP_MONTH"]; }else{_oMobileRetentionOrder.m_card_exp_month=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_INSTALLMENT_PERIOD"])) {_oMobileRetentionOrder.installment_period = (string)_oData["MOBILERETENTIONORDER_INSTALLMENT_PERIOD"]; }else{_oMobileRetentionOrder.installment_period=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_CARD_TYPE"])) {_oMobileRetentionOrder.m_card_type = (string)_oData["MOBILERETENTIONORDER_M_CARD_TYPE"]; }else{_oMobileRetentionOrder.m_card_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EASYWATCH_ORD_ID"])) {_oMobileRetentionOrder.easywatch_ord_id = (string)_oData["MOBILERETENTIONORDER_EASYWATCH_ORD_ID"]; }else{_oMobileRetentionOrder.easywatch_ord_id=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_NORMAL_REBATE"])) {_oMobileRetentionOrder.normal_rebate = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_NORMAL_REBATE"]; }else{_oMobileRetentionOrder.normal_rebate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_REBATE_AMOUNT"])) {_oMobileRetentionOrder.m_rebate_amount = (string)_oData["MOBILERETENTIONORDER_M_REBATE_AMOUNT"]; }else{_oMobileRetentionOrder.m_rebate_amount=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_CARD_HOLDER2"])) {_oMobileRetentionOrder.m_card_holder2 = (string)_oData["MOBILERETENTIONORDER_M_CARD_HOLDER2"]; }else{_oMobileRetentionOrder.m_card_holder2=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_BILL_MEDIUM_EMAIL"])) {_oMobileRetentionOrder.bill_medium_email = (string)_oData["MOBILERETENTIONORDER_BILL_MEDIUM_EMAIL"]; }else{_oMobileRetentionOrder.bill_medium_email=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACTIVE"])) {_oMobileRetentionOrder.active = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_ACTIVE"]; }else{_oMobileRetentionOrder.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_S_PREMIUM1"])) {_oMobileRetentionOrder.s_premium1 = (string)_oData["MOBILERETENTIONORDER_S_PREMIUM1"]; }else{_oMobileRetentionOrder.s_premium1=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CARD_EXP_MONTH"])) {_oMobileRetentionOrder.card_exp_month = (string)_oData["MOBILERETENTIONORDER_CARD_EXP_MONTH"]; }else{_oMobileRetentionOrder.card_exp_month=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_OB_PROGRAM_ID"])) {_oMobileRetentionOrder.ob_program_id = (string)_oData["MOBILERETENTIONORDER_OB_PROGRAM_ID"]; }else{_oMobileRetentionOrder.ob_program_id=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SKU"])) {_oMobileRetentionOrder.sku = (string)_oData["MOBILERETENTIONORDER_SKU"]; }else{_oMobileRetentionOrder.sku=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REF_SALESMANCODE"])) {_oMobileRetentionOrder.ref_salesmancode = (string)_oData["MOBILERETENTIONORDER_REF_SALESMANCODE"]; }else{_oMobileRetentionOrder.ref_salesmancode=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GO_WIRELESS_PACKAGE_CODE"])) {_oMobileRetentionOrder.go_wireless_package_code = (string)_oData["MOBILERETENTIONORDER_GO_WIRELESS_PACKAGE_CODE"]; }else{_oMobileRetentionOrder.go_wireless_package_code=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_THIRD_PARTY_HKID"])) {_oMobileRetentionOrder.third_party_hkid = (string)_oData["MOBILERETENTIONORDER_THIRD_PARTY_HKID"]; }else{_oMobileRetentionOrder.third_party_hkid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_EXISTING_PCCW_CUSTOMER"])) {_oMobileRetentionOrder.upgrade_existing_pccw_customer = (string)_oData["MOBILERETENTIONORDER_UPGRADE_EXISTING_PCCW_CUSTOMER"]; }else{_oMobileRetentionOrder.upgrade_existing_pccw_customer=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_D_ADDRESS"])) {_oMobileRetentionOrder.d_address = (string)_oData["MOBILERETENTIONORDER_D_ADDRESS"]; }else{_oMobileRetentionOrder.d_address=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_REGISTERED_MOBILE_NO"])) {_oMobileRetentionOrder.upgrade_registered_mobile_no = (string)_oData["MOBILERETENTIONORDER_UPGRADE_REGISTERED_MOBILE_NO"]; }else{_oMobileRetentionOrder.upgrade_registered_mobile_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_EXISTING_CUSTOMER_TYPE"])) {_oMobileRetentionOrder.upgrade_existing_customer_type = (string)_oData["MOBILERETENTIONORDER_UPGRADE_EXISTING_CUSTOMER_TYPE"]; }else{_oMobileRetentionOrder.upgrade_existing_customer_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_NORMAL_REBATE_TYPE"])) {_oMobileRetentionOrder.normal_rebate_type = (string)_oData["MOBILERETENTIONORDER_NORMAL_REBATE_TYPE"]; }else{_oMobileRetentionOrder.normal_rebate_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_DESC2"])) {_oMobileRetentionOrder.gift_desc2 = (string)_oData["MOBILERETENTIONORDER_GIFT_DESC2"]; }else{_oMobileRetentionOrder.gift_desc2=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_BRANCH_CODE"])) {_oMobileRetentionOrder.monthly_bank_account_branch_code = (string)_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_BRANCH_CODE"]; }else{_oMobileRetentionOrder.monthly_bank_account_branch_code=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REMARKS"])) {_oMobileRetentionOrder.remarks = (string)_oData["MOBILERETENTIONORDER_REMARKS"]; }else{_oMobileRetentionOrder.remarks=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACCEPT"])) {_oMobileRetentionOrder.accept = (string)_oData["MOBILERETENTIONORDER_ACCEPT"]; }else{_oMobileRetentionOrder.accept=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_DELIVERY_EXCHANGE"])) {_oMobileRetentionOrder.delivery_exchange = (string)_oData["MOBILERETENTIONORDER_DELIVERY_EXCHANGE"]; }else{_oMobileRetentionOrder.delivery_exchange=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_CODE2"])) {_oMobileRetentionOrder.gift_code2 = (string)_oData["MOBILERETENTIONORDER_GIFT_CODE2"]; }else{_oMobileRetentionOrder.gift_code2=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_PREPAYMENT_WAIVE"])) {_oMobileRetentionOrder.prepayment_waive = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_PREPAYMENT_WAIVE"]; }else{_oMobileRetentionOrder.prepayment_waive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXISTING_SMART_PHONE_IMEI"])) {_oMobileRetentionOrder.existing_smart_phone_imei = (string)_oData["MOBILERETENTIONORDER_EXISTING_SMART_PHONE_IMEI"]; }else{_oMobileRetentionOrder.existing_smart_phone_imei=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CUST_NAME"])) {_oMobileRetentionOrder.cust_name = (string)_oData["MOBILERETENTIONORDER_CUST_NAME"]; }else{_oMobileRetentionOrder.cust_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CUST_TYPE"])) {_oMobileRetentionOrder.cust_type = (string)_oData["MOBILERETENTIONORDER_CUST_TYPE"]; }else{_oMobileRetentionOrder.cust_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_SPONSORSHIPS_AMOUNT"])) {_oMobileRetentionOrder.upgrade_sponsorships_amount = (string)_oData["MOBILERETENTIONORDER_UPGRADE_SPONSORSHIPS_AMOUNT"]; }else{_oMobileRetentionOrder.upgrade_sponsorships_amount=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_BILL_MEDIUM_WAIVE"])) {_oMobileRetentionOrder.bill_medium_waive = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_BILL_MEDIUM_WAIVE"]; }else{_oMobileRetentionOrder.bill_medium_waive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_DELIVERY_EXCHANGE_LOCATION"])) {_oMobileRetentionOrder.delivery_exchange_location = (string)_oData["MOBILERETENTIONORDER_DELIVERY_EXCHANGE_LOCATION"]; }else{_oMobileRetentionOrder.delivery_exchange_location=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_HS_OFFER_TYPE_ID"])) {_oMobileRetentionOrder.hs_offer_type_id = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDER_HS_OFFER_TYPE_ID"]; }else{_oMobileRetentionOrder.hs_offer_type_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORG_FEE"])) {_oMobileRetentionOrder.org_fee = (string)_oData["MOBILERETENTIONORDER_ORG_FEE"]; }else{_oMobileRetentionOrder.org_fee=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REBATE"])) {_oMobileRetentionOrder.rebate = (string)_oData["MOBILERETENTIONORDER_REBATE"]; }else{_oMobileRetentionOrder.rebate=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_TYPE"])) {_oMobileRetentionOrder.upgrade_type = (string)_oData["MOBILERETENTIONORDER_UPGRADE_TYPE"]; }else{_oMobileRetentionOrder.upgrade_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GO_WIRELESS"])) {_oMobileRetentionOrder.go_wireless = (string)_oData["MOBILERETENTIONORDER_GO_WIRELESS"]; }else{_oMobileRetentionOrder.go_wireless=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXTRA_REBATE"])) {_oMobileRetentionOrder.extra_rebate = (string)_oData["MOBILERETENTIONORDER_EXTRA_REBATE"]; }else{_oMobileRetentionOrder.extra_rebate=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_PLAN_EFF"])) {_oMobileRetentionOrder.plan_eff = (string)_oData["MOBILERETENTIONORDER_PLAN_EFF"]; }else{_oMobileRetentionOrder.plan_eff=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXTRA_REBATE_AMOUNT"])) {_oMobileRetentionOrder.extra_rebate_amount = (string)_oData["MOBILERETENTIONORDER_EXTRA_REBATE_AMOUNT"]; }else{_oMobileRetentionOrder.extra_rebate_amount=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CARD_EXP_YEAR"])) {_oMobileRetentionOrder.card_exp_year = (string)_oData["MOBILERETENTIONORDER_CARD_EXP_YEAR"]; }else{_oMobileRetentionOrder.card_exp_year=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_EXISTING_CONTRACT_SDATE"])) {_oMobileRetentionOrder.upgrade_existing_contract_sdate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_UPGRADE_EXISTING_CONTRACT_SDATE"]; }else{_oMobileRetentionOrder.upgrade_existing_contract_sdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORD_PLACE_HKID"])) {_oMobileRetentionOrder.ord_place_hkid = (string)_oData["MOBILERETENTIONORDER_ORD_PLACE_HKID"]; }else{_oMobileRetentionOrder.ord_place_hkid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REGISTER_ADDRESS"])) {_oMobileRetentionOrder.register_address = (string)_oData["MOBILERETENTIONORDER_REGISTER_ADDRESS"]; }else{_oMobileRetentionOrder.register_address=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GENDER"])) {_oMobileRetentionOrder.gender = (string)_oData["MOBILERETENTIONORDER_GENDER"]; }else{_oMobileRetentionOrder.gender=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_LOB_AC"])) {_oMobileRetentionOrder.lob_ac = (string)_oData["MOBILERETENTIONORDER_LOB_AC"]; }else{_oMobileRetentionOrder.lob_ac=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SIM_MRT_NO"])) {_oMobileRetentionOrder.sim_mrt_no = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDER_SIM_MRT_NO"]; }else{_oMobileRetentionOrder.sim_mrt_no=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REDEMPTION_NOTICE_OPTION"])) {_oMobileRetentionOrder.redemption_notice_option = (string)_oData["MOBILERETENTIONORDER_REDEMPTION_NOTICE_OPTION"]; }else{_oMobileRetentionOrder.redemption_notice_option=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_DELIVERY_COLLECTION_TYPE"])) {_oMobileRetentionOrder.delivery_collection_type = (string)_oData["MOBILERETENTIONORDER_DELIVERY_COLLECTION_TYPE"]; }else{_oMobileRetentionOrder.delivery_collection_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACTION_DATE"])) {_oMobileRetentionOrder.action_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_ACTION_DATE"]; }else{_oMobileRetentionOrder.action_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_THIRD_PARTY_ID_TYPE"])) {_oMobileRetentionOrder.third_party_id_type = (string)_oData["MOBILERETENTIONORDER_THIRD_PARTY_ID_TYPE"]; }else{_oMobileRetentionOrder.third_party_id_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORG_FTG"])) {_oMobileRetentionOrder.org_ftg = (string)_oData["MOBILERETENTIONORDER_ORG_FTG"]; }else{_oMobileRetentionOrder.org_ftg=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_SERVICE_TENURE"])) {_oMobileRetentionOrder.upgrade_service_tenure = (string)_oData["MOBILERETENTIONORDER_UPGRADE_SERVICE_TENURE"]; }else{_oMobileRetentionOrder.upgrade_service_tenure=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_PAYMENT_TYPE"])) {_oMobileRetentionOrder.monthly_payment_type = (string)_oData["MOBILERETENTIONORDER_MONTHLY_PAYMENT_TYPE"]; }else{_oMobileRetentionOrder.monthly_payment_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CONTACT_NO"])) {_oMobileRetentionOrder.contact_no = (string)_oData["MOBILERETENTIONORDER_CONTACT_NO"]; }else{_oMobileRetentionOrder.contact_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORG_MRT"])) {_oMobileRetentionOrder.org_mrt = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDER_ORG_MRT"]; }else{_oMobileRetentionOrder.org_mrt=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SIM_ITEM_NAME"])) {_oMobileRetentionOrder.sim_item_name = (string)_oData["MOBILERETENTIONORDER_SIM_ITEM_NAME"]; }else{_oMobileRetentionOrder.sim_item_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_PAY_METHOD"])) {_oMobileRetentionOrder.pay_method = (string)_oData["MOBILERETENTIONORDER_PAY_METHOD"]; }else{_oMobileRetentionOrder.pay_method=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_HS_MODEL"])) {_oMobileRetentionOrder.hs_model = (string)_oData["MOBILERETENTIONORDER_HS_MODEL"]; }else{_oMobileRetentionOrder.hs_model=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_CODE"])) {_oMobileRetentionOrder.gift_code = (string)_oData["MOBILERETENTIONORDER_GIFT_CODE"]; }else{_oMobileRetentionOrder.gift_code=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HKID"])) {_oMobileRetentionOrder.monthly_bank_account_hkid = (string)_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HKID"]; }else{_oMobileRetentionOrder.monthly_bank_account_hkid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXTRA_OFFER"])) {_oMobileRetentionOrder.extra_offer = (string)_oData["MOBILERETENTIONORDER_EXTRA_OFFER"]; }else{_oMobileRetentionOrder.extra_offer=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_NO"])) {_oMobileRetentionOrder.monthly_bank_account_no = (string)_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_NO"]; }else{_oMobileRetentionOrder.monthly_bank_account_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_FIRST_MONTH_LICENSE_FEE"])) {_oMobileRetentionOrder.first_month_license_fee = (string)_oData["MOBILERETENTIONORDER_FIRST_MONTH_LICENSE_FEE"]; }else{_oMobileRetentionOrder.first_month_license_fee=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_RETRIEVE_CNT"])) {_oMobileRetentionOrder.retrieve_cnt = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDER_RETRIEVE_CNT"]; }else{_oMobileRetentionOrder.retrieve_cnt=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_DDATE"])) {_oMobileRetentionOrder.ddate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_DDATE"]; }else{_oMobileRetentionOrder.ddate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_S_PREMIUM2"])) {_oMobileRetentionOrder.s_premium2 = (string)_oData["MOBILERETENTIONORDER_S_PREMIUM2"]; }else{_oMobileRetentionOrder.s_premium2=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_ID_TYPE"])) {_oMobileRetentionOrder.monthly_bank_account_id_type = (string)_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_ID_TYPE"]; }else{_oMobileRetentionOrder.monthly_bank_account_id_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CARD_TYPE"])) {_oMobileRetentionOrder.card_type = (string)_oData["MOBILERETENTIONORDER_CARD_TYPE"]; }else{_oMobileRetentionOrder.card_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_NEXT_BILL"])) {_oMobileRetentionOrder.next_bill = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_NEXT_BILL"]; }else{_oMobileRetentionOrder.next_bill=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_PCD_PAID_GO_WIRELESS"])) {_oMobileRetentionOrder.pcd_paid_go_wireless = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_PCD_PAID_GO_WIRELESS"]; }else{_oMobileRetentionOrder.pcd_paid_go_wireless=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_REBATE_CALCULATION"])) {_oMobileRetentionOrder.upgrade_rebate_calculation = (string)_oData["MOBILERETENTIONORDER_UPGRADE_REBATE_CALCULATION"]; }else{_oMobileRetentionOrder.upgrade_rebate_calculation=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXT_PLACE_TEL"])) {_oMobileRetentionOrder.ext_place_tel = (string)_oData["MOBILERETENTIONORDER_EXT_PLACE_TEL"]; }else{_oMobileRetentionOrder.ext_place_tel=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_3RD_HKID"])) {_oMobileRetentionOrder.m_3rd_hkid = (string)_oData["MOBILERETENTIONORDER_M_3RD_HKID"]; }else{_oMobileRetentionOrder.m_3rd_hkid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_RETENTION_TYPE"])) {_oMobileRetentionOrder.retention_type = (string)_oData["MOBILERETENTIONORDER_RETENTION_TYPE"]; }else{_oMobileRetentionOrder.retention_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_COOLING_DATE"])) {_oMobileRetentionOrder.cooling_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_COOLING_DATE"]; }else{_oMobileRetentionOrder.cooling_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_AIG_GIFT"])) {_oMobileRetentionOrder.aig_gift = (string)_oData["MOBILERETENTIONORDER_AIG_GIFT"]; }else{_oMobileRetentionOrder.aig_gift=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CUST_STAFF_NO"])) {_oMobileRetentionOrder.cust_staff_no = (string)_oData["MOBILERETENTIONORDER_CUST_STAFF_NO"]; }else{_oMobileRetentionOrder.cust_staff_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORDER_ID"])) {_oMobileRetentionOrder.order_id = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDER_ORDER_ID"]; }else{_oMobileRetentionOrder.order_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_FAMILY_NAME"])) {_oMobileRetentionOrder.family_name = (string)_oData["MOBILERETENTIONORDER_FAMILY_NAME"]; }else{_oMobileRetentionOrder.family_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CDATE"])) {_oMobileRetentionOrder.cdate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_CDATE"]; }else{_oMobileRetentionOrder.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_STATUS_BY_CS_ADMIN"])) {_oMobileRetentionOrder.status_by_cs_admin = (string)_oData["MOBILERETENTIONORDER_STATUS_BY_CS_ADMIN"]; }else{_oMobileRetentionOrder.status_by_cs_admin=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SIM_ITEM_NUMBER"])) {_oMobileRetentionOrder.sim_item_number = (string)_oData["MOBILERETENTIONORDER_SIM_ITEM_NUMBER"]; }else{_oMobileRetentionOrder.sim_item_number=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_VIP_CASE"])) {_oMobileRetentionOrder.vip_case = (string)_oData["MOBILERETENTIONORDER_VIP_CASE"]; }else{_oMobileRetentionOrder.vip_case=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIVEN_NAME"])) {_oMobileRetentionOrder.given_name = (string)_oData["MOBILERETENTIONORDER_GIVEN_NAME"]; }else{_oMobileRetentionOrder.given_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_LOG_DATE"])) {_oMobileRetentionOrder.log_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_LOG_DATE"]; }else{_oMobileRetentionOrder.log_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXTN"])) {_oMobileRetentionOrder.extn = (string)_oData["MOBILERETENTIONORDER_EXTN"]; }else{_oMobileRetentionOrder.extn=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_D_TIME"])) {_oMobileRetentionOrder.d_time = (string)_oData["MOBILERETENTIONORDER_D_TIME"]; }else{_oMobileRetentionOrder.d_time=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_BANK_NAME"])) {_oMobileRetentionOrder.bank_name = (string)_oData["MOBILERETENTIONORDER_BANK_NAME"]; }else{_oMobileRetentionOrder.bank_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_DELIVERY_EXCHANGE_OPTION"])) {_oMobileRetentionOrder.delivery_exchange_option = (string)_oData["MOBILERETENTIONORDER_DELIVERY_EXCHANGE_OPTION"]; }else{_oMobileRetentionOrder.delivery_exchange_option=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_SERVICE_ACCOUNT_NO"])) {_oMobileRetentionOrder.upgrade_service_account_no = (string)_oData["MOBILERETENTIONORDER_UPGRADE_SERVICE_ACCOUNT_NO"]; }else{_oMobileRetentionOrder.upgrade_service_account_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACTION_OF_RATE_PLAN_EFFECTIVE"])) {_oMobileRetentionOrder.action_of_rate_plan_effective = (string)_oData["MOBILERETENTIONORDER_ACTION_OF_RATE_PLAN_EFFECTIVE"]; }else{_oMobileRetentionOrder.action_of_rate_plan_effective=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_CARD_NO"])) {_oMobileRetentionOrder.m_card_no = (string)_oData["MOBILERETENTIONORDER_M_CARD_NO"]; }else{_oMobileRetentionOrder.m_card_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXISTING_CONTRACT_END_DATE"])) {_oMobileRetentionOrder.existing_contract_end_date = (string)_oData["MOBILERETENTIONORDER_EXISTING_CONTRACT_END_DATE"]; }else{_oMobileRetentionOrder.existing_contract_end_date=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CON_EFF_DATE"])) {_oMobileRetentionOrder.con_eff_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_CON_EFF_DATE"]; }else{_oMobileRetentionOrder.con_eff_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_3RD_HKID2"])) {_oMobileRetentionOrder.m_3rd_hkid2 = (string)_oData["MOBILERETENTIONORDER_M_3RD_HKID2"]; }else{_oMobileRetentionOrder.m_3rd_hkid2=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_AMOUNT"])) {_oMobileRetentionOrder.amount = (string)_oData["MOBILERETENTIONORDER_AMOUNT"]; }else{_oMobileRetentionOrder.amount=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ID_TYPE"])) {_oMobileRetentionOrder.id_type = (string)_oData["MOBILERETENTIONORDER_ID_TYPE"]; }else{_oMobileRetentionOrder.id_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_RATE_PLAN"])) {_oMobileRetentionOrder.rate_plan = (string)_oData["MOBILERETENTIONORDER_RATE_PLAN"]; }else{_oMobileRetentionOrder.rate_plan=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CHANNEL"])) {_oMobileRetentionOrder.channel = (string)_oData["MOBILERETENTIONORDER_CHANNEL"]; }else{_oMobileRetentionOrder.channel=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACTION_EFF_DATE"])) {_oMobileRetentionOrder.action_eff_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_ACTION_EFF_DATE"]; }else{_oMobileRetentionOrder.action_eff_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ISSUE_TYPE"])) {_oMobileRetentionOrder.issue_type = (string)_oData["MOBILERETENTIONORDER_ISSUE_TYPE"]; }else{_oMobileRetentionOrder.issue_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_FREE_MON"])) {_oMobileRetentionOrder.free_mon = (string)_oData["MOBILERETENTIONORDER_FREE_MON"]; }else{_oMobileRetentionOrder.free_mon=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_PLAN_EFF_DATE"])) {_oMobileRetentionOrder.plan_eff_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_PLAN_EFF_DATE"]; }else{_oMobileRetentionOrder.plan_eff_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_DEL_REMARK"])) {_oMobileRetentionOrder.del_remark = (string)_oData["MOBILERETENTIONORDER_DEL_REMARK"]; }else{_oMobileRetentionOrder.del_remark=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_TEAMCODE"])) {_oMobileRetentionOrder.teamcode = (string)_oData["MOBILERETENTIONORDER_TEAMCODE"]; }else{_oMobileRetentionOrder.teamcode=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_STAFF_NAME"])) {_oMobileRetentionOrder.staff_name = (string)_oData["MOBILERETENTIONORDER_STAFF_NAME"]; }else{_oMobileRetentionOrder.staff_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EDF_NO"])) {_oMobileRetentionOrder.edf_no = (string)_oData["MOBILERETENTIONORDER_EDF_NO"]; }else{_oMobileRetentionOrder.edf_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORD_PLACE_BY"])) {_oMobileRetentionOrder.ord_place_by = (string)_oData["MOBILERETENTIONORDER_ORD_PLACE_BY"]; }else{_oMobileRetentionOrder.ord_place_by=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CANCEL_RENEW"])) {_oMobileRetentionOrder.cancel_renew = (string)_oData["MOBILERETENTIONORDER_CANCEL_RENEW"]; }else{_oMobileRetentionOrder.cancel_renew=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_PREFERRED_LANGUAGES"])) {_oMobileRetentionOrder.preferred_languages = (string)_oData["MOBILERETENTIONORDER_PREFERRED_LANGUAGES"]; }else{_oMobileRetentionOrder.preferred_languages=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_HKID"])) {_oMobileRetentionOrder.hkid = (string)_oData["MOBILERETENTIONORDER_HKID"]; }else{_oMobileRetentionOrder.hkid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CARD_NO"])) {_oMobileRetentionOrder.card_no = (string)_oData["MOBILERETENTIONORDER_CARD_NO"]; }else{_oMobileRetentionOrder.card_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_AC_NO"])) {_oMobileRetentionOrder.ac_no = (string)_oData["MOBILERETENTIONORDER_AC_NO"]; }else{_oMobileRetentionOrder.ac_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_BILL_CUT_NUM"])) {_oMobileRetentionOrder.bill_cut_num = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDER_BILL_CUT_NUM"]; }else{_oMobileRetentionOrder.bill_cut_num=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_PREMIUM"])) {_oMobileRetentionOrder.premium = (string)_oData["MOBILERETENTIONORDER_PREMIUM"]; }else{_oMobileRetentionOrder.premium=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_3RD_ID_TYPE"])) {_oMobileRetentionOrder.m_3rd_id_type = (string)_oData["MOBILERETENTIONORDER_M_3RD_ID_TYPE"]; }else{_oMobileRetentionOrder.m_3rd_id_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_IMEI2"])) {_oMobileRetentionOrder.gift_imei2 = (string)_oData["MOBILERETENTIONORDER_GIFT_IMEI2"]; }else{_oMobileRetentionOrder.gift_imei2=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REASONS"])) {_oMobileRetentionOrder.reasons = (string)_oData["MOBILERETENTIONORDER_REASONS"]; }else{_oMobileRetentionOrder.reasons=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_LANGUAGE"])) {_oMobileRetentionOrder.language = (string)_oData["MOBILERETENTIONORDER_LANGUAGE"]; }else{_oMobileRetentionOrder.language=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REBATE_AMOUNT"])) {_oMobileRetentionOrder.rebate_amount = (string)_oData["MOBILERETENTIONORDER_REBATE_AMOUNT"]; }else{_oMobileRetentionOrder.rebate_amount=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_LOB"])) {_oMobileRetentionOrder.lob = (string)_oData["MOBILERETENTIONORDER_LOB"]; }else{_oMobileRetentionOrder.lob=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_3RD_CONTACT_NO"])) {_oMobileRetentionOrder.m_3rd_contact_no = (string)_oData["MOBILERETENTIONORDER_M_3RD_CONTACT_NO"]; }else{_oMobileRetentionOrder.m_3rd_contact_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_STAFF_NO"])) {_oMobileRetentionOrder.staff_no = (string)_oData["MOBILERETENTIONORDER_STAFF_NO"]; }else{_oMobileRetentionOrder.staff_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_S_PREMIUM3"])) {_oMobileRetentionOrder.s_premium3 = (string)_oData["MOBILERETENTIONORDER_S_PREMIUM3"]; }else{_oMobileRetentionOrder.s_premium3=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SP_D_DATE"])) {_oMobileRetentionOrder.sp_d_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_SP_D_DATE"]; }else{_oMobileRetentionOrder.sp_d_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_BUNDLE_NAME"])) {_oMobileRetentionOrder.bundle_name = (string)_oData["MOBILERETENTIONORDER_BUNDLE_NAME"]; }else{_oMobileRetentionOrder.bundle_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACCESSORY_WAIVE"])) {_oMobileRetentionOrder.accessory_waive = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_ACCESSORY_WAIVE"]; }else{_oMobileRetentionOrder.accessory_waive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SIM_ITEM_CODE"])) {_oMobileRetentionOrder.sim_item_code = (string)_oData["MOBILERETENTIONORDER_SIM_ITEM_CODE"]; }else{_oMobileRetentionOrder.sim_item_code=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HOLDER"])) {_oMobileRetentionOrder.monthly_bank_account_holder = (string)_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HOLDER"]; }else{_oMobileRetentionOrder.monthly_bank_account_holder=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CARD_HOLDER"])) {_oMobileRetentionOrder.card_holder = (string)_oData["MOBILERETENTIONORDER_CARD_HOLDER"]; }else{_oMobileRetentionOrder.card_holder=global::System.String.Empty;}
                        _oMobileRetentionOrder.SetDB(x_oDB);
                        _oMobileRetentionOrder.GetFound();
                        _oRow.Add(_oMobileRetentionOrder);
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
        
        
        public static MobileRetentionOrderEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileRetentionOrderEntity> _oMobileRetentionOrderList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileRetentionOrderList==null){ return null;}
            return _oMobileRetentionOrderList.Count == 0 ? null : _oMobileRetentionOrderList.ToArray();
        }
        
        
        public static MobileRetentionOrderEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileRetentionOrderEntity> _oMobileRetentionOrderList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileRetentionOrderList==null){ return null;}
            return _oMobileRetentionOrderList.Count == 0 ? null : _oMobileRetentionOrderList.ToArray();
        }
        
        public static List<MobileRetentionOrderEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<MobileRetentionOrderEntity> _oRow = new List<MobileRetentionOrderEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[MobileRetentionOrder].[gift_imei] AS MOBILERETENTIONORDER_GIFT_IMEI,[MobileRetentionOrder].[s_premium4] AS MOBILERETENTIONORDER_S_PREMIUM4,[MobileRetentionOrder].[upgrade_existing_customer_type] AS MOBILERETENTIONORDER_UPGRADE_EXISTING_CUSTOMER_TYPE,[MobileRetentionOrder].[gift_desc4] AS MOBILERETENTIONORDER_GIFT_DESC4,[MobileRetentionOrder].[accessory_desc] AS MOBILERETENTIONORDER_ACCESSORY_DESC,[MobileRetentionOrder].[staff_name] AS MOBILERETENTIONORDER_STAFF_NAME,[MobileRetentionOrder].[action_required] AS MOBILERETENTIONORDER_ACTION_REQUIRED,[MobileRetentionOrder].[vas_eff_date] AS MOBILERETENTIONORDER_VAS_EFF_DATE,[MobileRetentionOrder].[monthly_bank_account_bank_code] AS MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_BANK_CODE,[MobileRetentionOrder].[sim_item_number] AS MOBILERETENTIONORDER_SIM_ITEM_NUMBER,[MobileRetentionOrder].[special_handling_dummy_code] AS MOBILERETENTIONORDER_SPECIAL_HANDLING_DUMMY_CODE,[MobileRetentionOrder].[card_no] AS MOBILERETENTIONORDER_CARD_NO,[MobileRetentionOrder].[m_card_exp_year] AS MOBILERETENTIONORDER_M_CARD_EXP_YEAR,[MobileRetentionOrder].[bill_medium_email] AS MOBILERETENTIONORDER_BILL_MEDIUM_EMAIL,[MobileRetentionOrder].[remarks2PY] AS MOBILERETENTIONORDER_REMARKS2PY,[MobileRetentionOrder].[trade_field] AS MOBILERETENTIONORDER_TRADE_FIELD,[MobileRetentionOrder].[ord_place_tel] AS MOBILERETENTIONORDER_ORD_PLACE_TEL,[MobileRetentionOrder].[action_of_rate_plan_effective] AS MOBILERETENTIONORDER_ACTION_OF_RATE_PLAN_EFFECTIVE,[MobileRetentionOrder].[cooling_offer] AS MOBILERETENTIONORDER_COOLING_OFFER,[MobileRetentionOrder].[upgrade_handset_offer_rebate_schedule] AS MOBILERETENTIONORDER_UPGRADE_HANDSET_OFFER_REBATE_SCHEDULE,[MobileRetentionOrder].[change_payment_type] AS MOBILERETENTIONORDER_CHANGE_PAYMENT_TYPE,[MobileRetentionOrder].[date_of_birth] AS MOBILERETENTIONORDER_DATE_OF_BIRTH,[MobileRetentionOrder].[contact_person] AS MOBILERETENTIONORDER_CONTACT_PERSON,[MobileRetentionOrder].[extra_d_charge] AS MOBILERETENTIONORDER_EXTRA_D_CHARGE,[MobileRetentionOrder].[tl_name] AS MOBILERETENTIONORDER_TL_NAME,[MobileRetentionOrder].[fast_start] AS MOBILERETENTIONORDER_FAST_START,[MobileRetentionOrder].[sp_ref_no] AS MOBILERETENTIONORDER_SP_REF_NO,[MobileRetentionOrder].[edate] AS MOBILERETENTIONORDER_EDATE,[MobileRetentionOrder].[exist_cust_plan] AS MOBILERETENTIONORDER_EXIST_CUST_PLAN,[MobileRetentionOrder].[ord_place_rel] AS MOBILERETENTIONORDER_ORD_PLACE_REL,[MobileRetentionOrder].[mrt_no] AS MOBILERETENTIONORDER_MRT_NO,[MobileRetentionOrder].[imei_no] AS MOBILERETENTIONORDER_IMEI_NO,[MobileRetentionOrder].[existing_smart_phone_model] AS MOBILERETENTIONORDER_EXISTING_SMART_PHONE_MODEL,[MobileRetentionOrder].[bank_code] AS MOBILERETENTIONORDER_BANK_CODE,[MobileRetentionOrder].[pos_ref_no] AS MOBILERETENTIONORDER_POS_REF_NO,[MobileRetentionOrder].[bill_cut_date] AS MOBILERETENTIONORDER_BILL_CUT_DATE,[MobileRetentionOrder].[gift_imei3] AS MOBILERETENTIONORDER_GIFT_IMEI3,[MobileRetentionOrder].[exist_plan] AS MOBILERETENTIONORDER_EXIST_PLAN,[MobileRetentionOrder].[waive] AS MOBILERETENTIONORDER_WAIVE,[MobileRetentionOrder].[program] AS MOBILERETENTIONORDER_PROGRAM,[MobileRetentionOrder].[first_month_fee] AS MOBILERETENTIONORDER_FIRST_MONTH_FEE,[MobileRetentionOrder].[r_offer] AS MOBILERETENTIONORDER_R_OFFER,[MobileRetentionOrder].[cid] AS MOBILERETENTIONORDER_CID,[MobileRetentionOrder].[did] AS MOBILERETENTIONORDER_DID,[MobileRetentionOrder].[ftg_tenure] AS MOBILERETENTIONORDER_FTG_TENURE,[MobileRetentionOrder].[con_per] AS MOBILERETENTIONORDER_CON_PER,[MobileRetentionOrder].[gift_code4] AS MOBILERETENTIONORDER_GIFT_CODE4,[MobileRetentionOrder].[easywatch_type] AS MOBILERETENTIONORDER_EASYWATCH_TYPE,[MobileRetentionOrder].[sms_mrt] AS MOBILERETENTIONORDER_SMS_MRT,[MobileRetentionOrder].[monthly_payment_method] AS MOBILERETENTIONORDER_MONTHLY_PAYMENT_METHOD,[MobileRetentionOrder].[remarks2EDF] AS MOBILERETENTIONORDER_REMARKS2EDF,[MobileRetentionOrder].[gift_desc3] AS MOBILERETENTIONORDER_GIFT_DESC3,[MobileRetentionOrder].[gift_imei4] AS MOBILERETENTIONORDER_GIFT_IMEI4,[MobileRetentionOrder].[monthly_bank_account_hkid2] AS MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HKID2,[MobileRetentionOrder].[d_date] AS MOBILERETENTIONORDER_D_DATE,[MobileRetentionOrder].[gift_desc] AS MOBILERETENTIONORDER_GIFT_DESC,[MobileRetentionOrder].[pool] AS MOBILERETENTIONORDER_POOL,[MobileRetentionOrder].[cn_mrt_no] AS MOBILERETENTIONORDER_CN_MRT_NO,[MobileRetentionOrder].[accessory_imei] AS MOBILERETENTIONORDER_ACCESSORY_IMEI,[MobileRetentionOrder].[third_party_credit_card] AS MOBILERETENTIONORDER_THIRD_PARTY_CREDIT_CARD,[MobileRetentionOrder].[special_approval] AS MOBILERETENTIONORDER_SPECIAL_APPROVAL,[MobileRetentionOrder].[upgrade_existing_contract_edate] AS MOBILERETENTIONORDER_UPGRADE_EXISTING_CONTRACT_EDATE,[MobileRetentionOrder].[accessory_code] AS MOBILERETENTIONORDER_ACCESSORY_CODE,[MobileRetentionOrder].[s_premium] AS MOBILERETENTIONORDER_S_PREMIUM,[MobileRetentionOrder].[ref_staff_no] AS MOBILERETENTIONORDER_REF_STAFF_NO,[MobileRetentionOrder].[accessory_price] AS MOBILERETENTIONORDER_ACCESSORY_PRICE,[MobileRetentionOrder].[m_card_exp_month] AS MOBILERETENTIONORDER_M_CARD_EXP_MONTH,[MobileRetentionOrder].[installment_period] AS MOBILERETENTIONORDER_INSTALLMENT_PERIOD,[MobileRetentionOrder].[m_card_type] AS MOBILERETENTIONORDER_M_CARD_TYPE,[MobileRetentionOrder].[easywatch_ord_id] AS MOBILERETENTIONORDER_EASYWATCH_ORD_ID,[MobileRetentionOrder].[normal_rebate] AS MOBILERETENTIONORDER_NORMAL_REBATE,[MobileRetentionOrder].[m_rebate_amount] AS MOBILERETENTIONORDER_M_REBATE_AMOUNT,[MobileRetentionOrder].[m_card_holder2] AS MOBILERETENTIONORDER_M_CARD_HOLDER2,[MobileRetentionOrder].[monthly_bank_account_holder] AS MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HOLDER,[MobileRetentionOrder].[active] AS MOBILERETENTIONORDER_ACTIVE,[MobileRetentionOrder].[s_premium1] AS MOBILERETENTIONORDER_S_PREMIUM1,[MobileRetentionOrder].[card_exp_month] AS MOBILERETENTIONORDER_CARD_EXP_MONTH,[MobileRetentionOrder].[ob_program_id] AS MOBILERETENTIONORDER_OB_PROGRAM_ID,[MobileRetentionOrder].[sku] AS MOBILERETENTIONORDER_SKU,[MobileRetentionOrder].[salesmancode] AS MOBILERETENTIONORDER_SALESMANCODE,[MobileRetentionOrder].[go_wireless_package_code] AS MOBILERETENTIONORDER_GO_WIRELESS_PACKAGE_CODE,[MobileRetentionOrder].[lob] AS MOBILERETENTIONORDER_LOB,[MobileRetentionOrder].[ref_salesmancode] AS MOBILERETENTIONORDER_REF_SALESMANCODE,[MobileRetentionOrder].[third_party_hkid] AS MOBILERETENTIONORDER_THIRD_PARTY_HKID,[MobileRetentionOrder].[upgrade_existing_pccw_customer] AS MOBILERETENTIONORDER_UPGRADE_EXISTING_PCCW_CUSTOMER,[MobileRetentionOrder].[d_address] AS MOBILERETENTIONORDER_D_ADDRESS,[MobileRetentionOrder].[upgrade_registered_mobile_no] AS MOBILERETENTIONORDER_UPGRADE_REGISTERED_MOBILE_NO,[MobileRetentionOrder].[gift_code3] AS MOBILERETENTIONORDER_GIFT_CODE3,[MobileRetentionOrder].[normal_rebate_type] AS MOBILERETENTIONORDER_NORMAL_REBATE_TYPE,[MobileRetentionOrder].[gift_desc2] AS MOBILERETENTIONORDER_GIFT_DESC2,[MobileRetentionOrder].[monthly_bank_account_branch_code] AS MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_BRANCH_CODE,[MobileRetentionOrder].[remarks] AS MOBILERETENTIONORDER_REMARKS,[MobileRetentionOrder].[accept] AS MOBILERETENTIONORDER_ACCEPT,[MobileRetentionOrder].[delivery_exchange] AS MOBILERETENTIONORDER_DELIVERY_EXCHANGE,[MobileRetentionOrder].[gift_code2] AS MOBILERETENTIONORDER_GIFT_CODE2,[MobileRetentionOrder].[prepayment_waive] AS MOBILERETENTIONORDER_PREPAYMENT_WAIVE,[MobileRetentionOrder].[existing_smart_phone_imei] AS MOBILERETENTIONORDER_EXISTING_SMART_PHONE_IMEI,[MobileRetentionOrder].[cust_name] AS MOBILERETENTIONORDER_CUST_NAME,[MobileRetentionOrder].[upgrade_sponsorships_amount] AS MOBILERETENTIONORDER_UPGRADE_SPONSORSHIPS_AMOUNT,[MobileRetentionOrder].[bill_medium_waive] AS MOBILERETENTIONORDER_BILL_MEDIUM_WAIVE,[MobileRetentionOrder].[delivery_exchange_location] AS MOBILERETENTIONORDER_DELIVERY_EXCHANGE_LOCATION,[MobileRetentionOrder].[hs_offer_type_id] AS MOBILERETENTIONORDER_HS_OFFER_TYPE_ID,[MobileRetentionOrder].[extra_rebate_amount] AS MOBILERETENTIONORDER_EXTRA_REBATE_AMOUNT,[MobileRetentionOrder].[rebate] AS MOBILERETENTIONORDER_REBATE,[MobileRetentionOrder].[upgrade_type] AS MOBILERETENTIONORDER_UPGRADE_TYPE,[MobileRetentionOrder].[go_wireless] AS MOBILERETENTIONORDER_GO_WIRELESS,[MobileRetentionOrder].[extra_rebate] AS MOBILERETENTIONORDER_EXTRA_REBATE,[MobileRetentionOrder].[plan_eff] AS MOBILERETENTIONORDER_PLAN_EFF,[MobileRetentionOrder].[card_exp_year] AS MOBILERETENTIONORDER_CARD_EXP_YEAR,[MobileRetentionOrder].[upgrade_existing_contract_sdate] AS MOBILERETENTIONORDER_UPGRADE_EXISTING_CONTRACT_SDATE,[MobileRetentionOrder].[ord_place_hkid] AS MOBILERETENTIONORDER_ORD_PLACE_HKID,[MobileRetentionOrder].[register_address] AS MOBILERETENTIONORDER_REGISTER_ADDRESS,[MobileRetentionOrder].[gender] AS MOBILERETENTIONORDER_GENDER,[MobileRetentionOrder].[lob_ac] AS MOBILERETENTIONORDER_LOB_AC,[MobileRetentionOrder].[sim_mrt_no] AS MOBILERETENTIONORDER_SIM_MRT_NO,[MobileRetentionOrder].[redemption_notice_option] AS MOBILERETENTIONORDER_REDEMPTION_NOTICE_OPTION,[MobileRetentionOrder].[delivery_collection_type] AS MOBILERETENTIONORDER_DELIVERY_COLLECTION_TYPE,[MobileRetentionOrder].[action_date] AS MOBILERETENTIONORDER_ACTION_DATE,[MobileRetentionOrder].[third_party_id_type] AS MOBILERETENTIONORDER_THIRD_PARTY_ID_TYPE,[MobileRetentionOrder].[org_ftg] AS MOBILERETENTIONORDER_ORG_FTG,[MobileRetentionOrder].[upgrade_service_tenure] AS MOBILERETENTIONORDER_UPGRADE_SERVICE_TENURE,[MobileRetentionOrder].[monthly_payment_type] AS MOBILERETENTIONORDER_MONTHLY_PAYMENT_TYPE,[MobileRetentionOrder].[contact_no] AS MOBILERETENTIONORDER_CONTACT_NO,[MobileRetentionOrder].[org_mrt] AS MOBILERETENTIONORDER_ORG_MRT,[MobileRetentionOrder].[sim_item_name] AS MOBILERETENTIONORDER_SIM_ITEM_NAME,[MobileRetentionOrder].[pay_method] AS MOBILERETENTIONORDER_PAY_METHOD,[MobileRetentionOrder].[hs_model] AS MOBILERETENTIONORDER_HS_MODEL,[MobileRetentionOrder].[gift_code] AS MOBILERETENTIONORDER_GIFT_CODE,[MobileRetentionOrder].[monthly_bank_account_hkid] AS MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HKID,[MobileRetentionOrder].[extra_offer] AS MOBILERETENTIONORDER_EXTRA_OFFER,[MobileRetentionOrder].[monthly_bank_account_no] AS MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_NO,[MobileRetentionOrder].[first_month_license_fee] AS MOBILERETENTIONORDER_FIRST_MONTH_LICENSE_FEE,[MobileRetentionOrder].[retrieve_cnt] AS MOBILERETENTIONORDER_RETRIEVE_CNT,[MobileRetentionOrder].[ddate] AS MOBILERETENTIONORDER_DDATE,[MobileRetentionOrder].[s_premium2] AS MOBILERETENTIONORDER_S_PREMIUM2,[MobileRetentionOrder].[monthly_bank_account_id_type] AS MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_ID_TYPE,[MobileRetentionOrder].[card_type] AS MOBILERETENTIONORDER_CARD_TYPE,[MobileRetentionOrder].[next_bill] AS MOBILERETENTIONORDER_NEXT_BILL,[MobileRetentionOrder].[pcd_paid_go_wireless] AS MOBILERETENTIONORDER_PCD_PAID_GO_WIRELESS,[MobileRetentionOrder].[upgrade_rebate_calculation] AS MOBILERETENTIONORDER_UPGRADE_REBATE_CALCULATION,[MobileRetentionOrder].[ext_place_tel] AS MOBILERETENTIONORDER_EXT_PLACE_TEL,[MobileRetentionOrder].[m_3rd_hkid] AS MOBILERETENTIONORDER_M_3RD_HKID,[MobileRetentionOrder].[retention_type] AS MOBILERETENTIONORDER_RETENTION_TYPE,[MobileRetentionOrder].[cooling_date] AS MOBILERETENTIONORDER_COOLING_DATE,[MobileRetentionOrder].[aig_gift] AS MOBILERETENTIONORDER_AIG_GIFT,[MobileRetentionOrder].[cust_staff_no] AS MOBILERETENTIONORDER_CUST_STAFF_NO,[MobileRetentionOrder].[order_id] AS MOBILERETENTIONORDER_ORDER_ID,[MobileRetentionOrder].[family_name] AS MOBILERETENTIONORDER_FAMILY_NAME,[MobileRetentionOrder].[cdate] AS MOBILERETENTIONORDER_CDATE,[MobileRetentionOrder].[status_by_cs_admin] AS MOBILERETENTIONORDER_STATUS_BY_CS_ADMIN,[MobileRetentionOrder].[given_name] AS MOBILERETENTIONORDER_GIVEN_NAME,[MobileRetentionOrder].[vip_case] AS MOBILERETENTIONORDER_VIP_CASE,[MobileRetentionOrder].[org_fee] AS MOBILERETENTIONORDER_ORG_FEE,[MobileRetentionOrder].[s_premium3] AS MOBILERETENTIONORDER_S_PREMIUM3,[MobileRetentionOrder].[log_date] AS MOBILERETENTIONORDER_LOG_DATE,[MobileRetentionOrder].[extn] AS MOBILERETENTIONORDER_EXTN,[MobileRetentionOrder].[d_time] AS MOBILERETENTIONORDER_D_TIME,[MobileRetentionOrder].[bank_name] AS MOBILERETENTIONORDER_BANK_NAME,[MobileRetentionOrder].[delivery_exchange_option] AS MOBILERETENTIONORDER_DELIVERY_EXCHANGE_OPTION,[MobileRetentionOrder].[upgrade_service_account_no] AS MOBILERETENTIONORDER_UPGRADE_SERVICE_ACCOUNT_NO,[MobileRetentionOrder].[old_ord_id] AS MOBILERETENTIONORDER_OLD_ORD_ID,[MobileRetentionOrder].[m_card_no] AS MOBILERETENTIONORDER_M_CARD_NO,[MobileRetentionOrder].[existing_contract_end_date] AS MOBILERETENTIONORDER_EXISTING_CONTRACT_END_DATE,[MobileRetentionOrder].[con_eff_date] AS MOBILERETENTIONORDER_CON_EFF_DATE,[MobileRetentionOrder].[m_3rd_hkid2] AS MOBILERETENTIONORDER_M_3RD_HKID2,[MobileRetentionOrder].[amount] AS MOBILERETENTIONORDER_AMOUNT,[MobileRetentionOrder].[m_3rd_id_type] AS MOBILERETENTIONORDER_M_3RD_ID_TYPE,[MobileRetentionOrder].[id_type] AS MOBILERETENTIONORDER_ID_TYPE,[MobileRetentionOrder].[rate_plan] AS MOBILERETENTIONORDER_RATE_PLAN,[MobileRetentionOrder].[channel] AS MOBILERETENTIONORDER_CHANNEL,[MobileRetentionOrder].[action_eff_date] AS MOBILERETENTIONORDER_ACTION_EFF_DATE,[MobileRetentionOrder].[issue_type] AS MOBILERETENTIONORDER_ISSUE_TYPE,[MobileRetentionOrder].[free_mon] AS MOBILERETENTIONORDER_FREE_MON,[MobileRetentionOrder].[plan_eff_date] AS MOBILERETENTIONORDER_PLAN_EFF_DATE,[MobileRetentionOrder].[teamcode] AS MOBILERETENTIONORDER_TEAMCODE,[MobileRetentionOrder].[bill_medium] AS MOBILERETENTIONORDER_BILL_MEDIUM,[MobileRetentionOrder].[edf_no] AS MOBILERETENTIONORDER_EDF_NO,[MobileRetentionOrder].[ord_place_by] AS MOBILERETENTIONORDER_ORD_PLACE_BY,[MobileRetentionOrder].[cancel_renew] AS MOBILERETENTIONORDER_CANCEL_RENEW,[MobileRetentionOrder].[preferred_languages] AS MOBILERETENTIONORDER_PREFERRED_LANGUAGES,[MobileRetentionOrder].[hkid] AS MOBILERETENTIONORDER_HKID,[MobileRetentionOrder].[card_holder] AS MOBILERETENTIONORDER_CARD_HOLDER,[MobileRetentionOrder].[ac_no] AS MOBILERETENTIONORDER_AC_NO,[MobileRetentionOrder].[bill_cut_num] AS MOBILERETENTIONORDER_BILL_CUT_NUM,[MobileRetentionOrder].[premium] AS MOBILERETENTIONORDER_PREMIUM,[MobileRetentionOrder].[del_remark] AS MOBILERETENTIONORDER_DEL_REMARK,[MobileRetentionOrder].[gift_imei2] AS MOBILERETENTIONORDER_GIFT_IMEI2,[MobileRetentionOrder].[reasons] AS MOBILERETENTIONORDER_REASONS,[MobileRetentionOrder].[language] AS MOBILERETENTIONORDER_LANGUAGE,[MobileRetentionOrder].[rebate_amount] AS MOBILERETENTIONORDER_REBATE_AMOUNT,[MobileRetentionOrder].[ord_place_id_type] AS MOBILERETENTIONORDER_ORD_PLACE_ID_TYPE,[MobileRetentionOrder].[m_3rd_contact_no] AS MOBILERETENTIONORDER_M_3RD_CONTACT_NO,[MobileRetentionOrder].[staff_no] AS MOBILERETENTIONORDER_STAFF_NO,[MobileRetentionOrder].[sp_d_date] AS MOBILERETENTIONORDER_SP_D_DATE,[MobileRetentionOrder].[bundle_name] AS MOBILERETENTIONORDER_BUNDLE_NAME,[MobileRetentionOrder].[accessory_waive] AS MOBILERETENTIONORDER_ACCESSORY_WAIVE,[MobileRetentionOrder].[sim_item_code] AS MOBILERETENTIONORDER_SIM_ITEM_CODE,[MobileRetentionOrder].[cust_type] AS MOBILERETENTIONORDER_CUST_TYPE,[MobileRetentionOrder].[card_ref_no] AS MOBILERETENTIONORDER_CARD_REF_NO";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[MobileRetentionOrder]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrder]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = MobileRetentionOrderRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                MobileRetentionOrderEntity _oMobileRetentionOrder = MobileRetentionOrderRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_IMEI"])) {_oMobileRetentionOrder.gift_imei = (string)_oData["MOBILERETENTIONORDER_GIFT_IMEI"]; } else {_oMobileRetentionOrder.gift_imei=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_S_PREMIUM4"])) {_oMobileRetentionOrder.s_premium4 = (string)_oData["MOBILERETENTIONORDER_S_PREMIUM4"]; } else {_oMobileRetentionOrder.s_premium4=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_DESC4"])) {_oMobileRetentionOrder.gift_desc4 = (string)_oData["MOBILERETENTIONORDER_GIFT_DESC4"]; } else {_oMobileRetentionOrder.gift_desc4=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACCESSORY_DESC"])) {_oMobileRetentionOrder.accessory_desc = (string)_oData["MOBILERETENTIONORDER_ACCESSORY_DESC"]; } else {_oMobileRetentionOrder.accessory_desc=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACTION_REQUIRED"])) {_oMobileRetentionOrder.action_required = (string)_oData["MOBILERETENTIONORDER_ACTION_REQUIRED"]; } else {_oMobileRetentionOrder.action_required=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_VAS_EFF_DATE"])) {_oMobileRetentionOrder.vas_eff_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_VAS_EFF_DATE"]; } else {_oMobileRetentionOrder.vas_eff_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_BANK_CODE"])) {_oMobileRetentionOrder.monthly_bank_account_bank_code = (string)_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_BANK_CODE"]; } else {_oMobileRetentionOrder.monthly_bank_account_bank_code=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SPECIAL_HANDLING_DUMMY_CODE"])) {_oMobileRetentionOrder.special_handling_dummy_code = (string)_oData["MOBILERETENTIONORDER_SPECIAL_HANDLING_DUMMY_CODE"]; } else {_oMobileRetentionOrder.special_handling_dummy_code=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_CARD_EXP_YEAR"])) {_oMobileRetentionOrder.m_card_exp_year = (string)_oData["MOBILERETENTIONORDER_M_CARD_EXP_YEAR"]; } else {_oMobileRetentionOrder.m_card_exp_year=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REMARKS2PY"])) {_oMobileRetentionOrder.remarks2PY = (string)_oData["MOBILERETENTIONORDER_REMARKS2PY"]; } else {_oMobileRetentionOrder.remarks2PY=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_TRADE_FIELD"])) {_oMobileRetentionOrder.trade_field = (string)_oData["MOBILERETENTIONORDER_TRADE_FIELD"]; } else {_oMobileRetentionOrder.trade_field=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORD_PLACE_TEL"])) {_oMobileRetentionOrder.ord_place_tel = (string)_oData["MOBILERETENTIONORDER_ORD_PLACE_TEL"]; } else {_oMobileRetentionOrder.ord_place_tel=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORD_PLACE_ID_TYPE"])) {_oMobileRetentionOrder.ord_place_id_type = (string)_oData["MOBILERETENTIONORDER_ORD_PLACE_ID_TYPE"]; } else {_oMobileRetentionOrder.ord_place_id_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_COOLING_OFFER"])) {_oMobileRetentionOrder.cooling_offer = (string)_oData["MOBILERETENTIONORDER_COOLING_OFFER"]; } else {_oMobileRetentionOrder.cooling_offer=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_HANDSET_OFFER_REBATE_SCHEDULE"])) {_oMobileRetentionOrder.upgrade_handset_offer_rebate_schedule = (string)_oData["MOBILERETENTIONORDER_UPGRADE_HANDSET_OFFER_REBATE_SCHEDULE"]; } else {_oMobileRetentionOrder.upgrade_handset_offer_rebate_schedule=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CHANGE_PAYMENT_TYPE"])) {_oMobileRetentionOrder.change_payment_type = (string)_oData["MOBILERETENTIONORDER_CHANGE_PAYMENT_TYPE"]; } else {_oMobileRetentionOrder.change_payment_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_DATE_OF_BIRTH"])) {_oMobileRetentionOrder.date_of_birth = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_DATE_OF_BIRTH"]; } else {_oMobileRetentionOrder.date_of_birth=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CONTACT_PERSON"])) {_oMobileRetentionOrder.contact_person = (string)_oData["MOBILERETENTIONORDER_CONTACT_PERSON"]; } else {_oMobileRetentionOrder.contact_person=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXTRA_D_CHARGE"])) {_oMobileRetentionOrder.extra_d_charge = (string)_oData["MOBILERETENTIONORDER_EXTRA_D_CHARGE"]; } else {_oMobileRetentionOrder.extra_d_charge=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_TL_NAME"])) {_oMobileRetentionOrder.tl_name = (string)_oData["MOBILERETENTIONORDER_TL_NAME"]; } else {_oMobileRetentionOrder.tl_name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_FAST_START"])) {_oMobileRetentionOrder.fast_start = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_FAST_START"]; } else {_oMobileRetentionOrder.fast_start=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SP_REF_NO"])) {_oMobileRetentionOrder.sp_ref_no = (string)_oData["MOBILERETENTIONORDER_SP_REF_NO"]; } else {_oMobileRetentionOrder.sp_ref_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EDATE"])) {_oMobileRetentionOrder.edate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_EDATE"]; } else {_oMobileRetentionOrder.edate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXIST_CUST_PLAN"])) {_oMobileRetentionOrder.exist_cust_plan = (string)_oData["MOBILERETENTIONORDER_EXIST_CUST_PLAN"]; } else {_oMobileRetentionOrder.exist_cust_plan=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORD_PLACE_REL"])) {_oMobileRetentionOrder.ord_place_rel = (string)_oData["MOBILERETENTIONORDER_ORD_PLACE_REL"]; } else {_oMobileRetentionOrder.ord_place_rel=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MRT_NO"])) {_oMobileRetentionOrder.mrt_no = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDER_MRT_NO"]; } else {_oMobileRetentionOrder.mrt_no=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_IMEI_NO"])) {_oMobileRetentionOrder.imei_no = (string)_oData["MOBILERETENTIONORDER_IMEI_NO"]; } else {_oMobileRetentionOrder.imei_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXISTING_SMART_PHONE_MODEL"])) {_oMobileRetentionOrder.existing_smart_phone_model = (string)_oData["MOBILERETENTIONORDER_EXISTING_SMART_PHONE_MODEL"]; } else {_oMobileRetentionOrder.existing_smart_phone_model=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_CODE3"])) {_oMobileRetentionOrder.gift_code3 = (string)_oData["MOBILERETENTIONORDER_GIFT_CODE3"]; } else {_oMobileRetentionOrder.gift_code3=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_BANK_CODE"])) {_oMobileRetentionOrder.bank_code = (string)_oData["MOBILERETENTIONORDER_BANK_CODE"]; } else {_oMobileRetentionOrder.bank_code=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_POS_REF_NO"])) {_oMobileRetentionOrder.pos_ref_no = (string)_oData["MOBILERETENTIONORDER_POS_REF_NO"]; } else {_oMobileRetentionOrder.pos_ref_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_BILL_CUT_DATE"])) {_oMobileRetentionOrder.bill_cut_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_BILL_CUT_DATE"]; } else {_oMobileRetentionOrder.bill_cut_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_IMEI3"])) {_oMobileRetentionOrder.gift_imei3 = (string)_oData["MOBILERETENTIONORDER_GIFT_IMEI3"]; } else {_oMobileRetentionOrder.gift_imei3=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXIST_PLAN"])) {_oMobileRetentionOrder.exist_plan = (string)_oData["MOBILERETENTIONORDER_EXIST_PLAN"]; } else {_oMobileRetentionOrder.exist_plan=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_WAIVE"])) {_oMobileRetentionOrder.waive = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_WAIVE"]; } else {_oMobileRetentionOrder.waive=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_PROGRAM"])) {_oMobileRetentionOrder.program = (string)_oData["MOBILERETENTIONORDER_PROGRAM"]; } else {_oMobileRetentionOrder.program=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_FIRST_MONTH_FEE"])) {_oMobileRetentionOrder.first_month_fee = (string)_oData["MOBILERETENTIONORDER_FIRST_MONTH_FEE"]; } else {_oMobileRetentionOrder.first_month_fee=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_R_OFFER"])) {_oMobileRetentionOrder.r_offer = (string)_oData["MOBILERETENTIONORDER_R_OFFER"]; } else {_oMobileRetentionOrder.r_offer=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CID"])) {_oMobileRetentionOrder.cid = (string)_oData["MOBILERETENTIONORDER_CID"]; } else {_oMobileRetentionOrder.cid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_DID"])) {_oMobileRetentionOrder.did = (string)_oData["MOBILERETENTIONORDER_DID"]; } else {_oMobileRetentionOrder.did=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_FTG_TENURE"])) {_oMobileRetentionOrder.ftg_tenure = (string)_oData["MOBILERETENTIONORDER_FTG_TENURE"]; } else {_oMobileRetentionOrder.ftg_tenure=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CON_PER"])) {_oMobileRetentionOrder.con_per = (string)_oData["MOBILERETENTIONORDER_CON_PER"]; } else {_oMobileRetentionOrder.con_per=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_CODE4"])) {_oMobileRetentionOrder.gift_code4 = (string)_oData["MOBILERETENTIONORDER_GIFT_CODE4"]; } else {_oMobileRetentionOrder.gift_code4=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EASYWATCH_TYPE"])) {_oMobileRetentionOrder.easywatch_type = (string)_oData["MOBILERETENTIONORDER_EASYWATCH_TYPE"]; } else {_oMobileRetentionOrder.easywatch_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SMS_MRT"])) {_oMobileRetentionOrder.sms_mrt = (string)_oData["MOBILERETENTIONORDER_SMS_MRT"]; } else {_oMobileRetentionOrder.sms_mrt=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_PAYMENT_METHOD"])) {_oMobileRetentionOrder.monthly_payment_method = (string)_oData["MOBILERETENTIONORDER_MONTHLY_PAYMENT_METHOD"]; } else {_oMobileRetentionOrder.monthly_payment_method=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REMARKS2EDF"])) {_oMobileRetentionOrder.remarks2EDF = (string)_oData["MOBILERETENTIONORDER_REMARKS2EDF"]; } else {_oMobileRetentionOrder.remarks2EDF=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_DESC3"])) {_oMobileRetentionOrder.gift_desc3 = (string)_oData["MOBILERETENTIONORDER_GIFT_DESC3"]; } else {_oMobileRetentionOrder.gift_desc3=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_IMEI4"])) {_oMobileRetentionOrder.gift_imei4 = (string)_oData["MOBILERETENTIONORDER_GIFT_IMEI4"]; } else {_oMobileRetentionOrder.gift_imei4=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_OLD_ORD_ID"])) {_oMobileRetentionOrder.old_ord_id = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDER_OLD_ORD_ID"]; } else {_oMobileRetentionOrder.old_ord_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HKID2"])) {_oMobileRetentionOrder.monthly_bank_account_hkid2 = (string)_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HKID2"]; } else {_oMobileRetentionOrder.monthly_bank_account_hkid2=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_D_DATE"])) {_oMobileRetentionOrder.d_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_D_DATE"]; } else {_oMobileRetentionOrder.d_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_DESC"])) {_oMobileRetentionOrder.gift_desc = (string)_oData["MOBILERETENTIONORDER_GIFT_DESC"]; } else {_oMobileRetentionOrder.gift_desc=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SALESMANCODE"])) {_oMobileRetentionOrder.salesmancode = (string)_oData["MOBILERETENTIONORDER_SALESMANCODE"]; } else {_oMobileRetentionOrder.salesmancode=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_POOL"])) {_oMobileRetentionOrder.pool = (string)_oData["MOBILERETENTIONORDER_POOL"]; } else {_oMobileRetentionOrder.pool=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CN_MRT_NO"])) {_oMobileRetentionOrder.cn_mrt_no = (global::System.Nullable<long>)_oData["MOBILERETENTIONORDER_CN_MRT_NO"]; } else {_oMobileRetentionOrder.cn_mrt_no=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACCESSORY_IMEI"])) {_oMobileRetentionOrder.accessory_imei = (string)_oData["MOBILERETENTIONORDER_ACCESSORY_IMEI"]; } else {_oMobileRetentionOrder.accessory_imei=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_THIRD_PARTY_CREDIT_CARD"])) {_oMobileRetentionOrder.third_party_credit_card = (string)_oData["MOBILERETENTIONORDER_THIRD_PARTY_CREDIT_CARD"]; } else {_oMobileRetentionOrder.third_party_credit_card=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CARD_REF_NO"])) {_oMobileRetentionOrder.card_ref_no = (string)_oData["MOBILERETENTIONORDER_CARD_REF_NO"]; } else {_oMobileRetentionOrder.card_ref_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SPECIAL_APPROVAL"])) {_oMobileRetentionOrder.special_approval = (string)_oData["MOBILERETENTIONORDER_SPECIAL_APPROVAL"]; } else {_oMobileRetentionOrder.special_approval=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_EXISTING_CONTRACT_EDATE"])) {_oMobileRetentionOrder.upgrade_existing_contract_edate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_UPGRADE_EXISTING_CONTRACT_EDATE"]; } else {_oMobileRetentionOrder.upgrade_existing_contract_edate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACCESSORY_CODE"])) {_oMobileRetentionOrder.accessory_code = (string)_oData["MOBILERETENTIONORDER_ACCESSORY_CODE"]; } else {_oMobileRetentionOrder.accessory_code=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_BILL_MEDIUM"])) {_oMobileRetentionOrder.bill_medium = (string)_oData["MOBILERETENTIONORDER_BILL_MEDIUM"]; } else {_oMobileRetentionOrder.bill_medium=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_S_PREMIUM"])) {_oMobileRetentionOrder.s_premium = (string)_oData["MOBILERETENTIONORDER_S_PREMIUM"]; } else {_oMobileRetentionOrder.s_premium=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REF_STAFF_NO"])) {_oMobileRetentionOrder.ref_staff_no = (string)_oData["MOBILERETENTIONORDER_REF_STAFF_NO"]; } else {_oMobileRetentionOrder.ref_staff_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACCESSORY_PRICE"])) {_oMobileRetentionOrder.accessory_price = (string)_oData["MOBILERETENTIONORDER_ACCESSORY_PRICE"]; } else {_oMobileRetentionOrder.accessory_price=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_CARD_EXP_MONTH"])) {_oMobileRetentionOrder.m_card_exp_month = (string)_oData["MOBILERETENTIONORDER_M_CARD_EXP_MONTH"]; } else {_oMobileRetentionOrder.m_card_exp_month=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_INSTALLMENT_PERIOD"])) {_oMobileRetentionOrder.installment_period = (string)_oData["MOBILERETENTIONORDER_INSTALLMENT_PERIOD"]; } else {_oMobileRetentionOrder.installment_period=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_CARD_TYPE"])) {_oMobileRetentionOrder.m_card_type = (string)_oData["MOBILERETENTIONORDER_M_CARD_TYPE"]; } else {_oMobileRetentionOrder.m_card_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EASYWATCH_ORD_ID"])) {_oMobileRetentionOrder.easywatch_ord_id = (string)_oData["MOBILERETENTIONORDER_EASYWATCH_ORD_ID"]; } else {_oMobileRetentionOrder.easywatch_ord_id=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_NORMAL_REBATE"])) {_oMobileRetentionOrder.normal_rebate = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_NORMAL_REBATE"]; } else {_oMobileRetentionOrder.normal_rebate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_REBATE_AMOUNT"])) {_oMobileRetentionOrder.m_rebate_amount = (string)_oData["MOBILERETENTIONORDER_M_REBATE_AMOUNT"]; } else {_oMobileRetentionOrder.m_rebate_amount=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_CARD_HOLDER2"])) {_oMobileRetentionOrder.m_card_holder2 = (string)_oData["MOBILERETENTIONORDER_M_CARD_HOLDER2"]; } else {_oMobileRetentionOrder.m_card_holder2=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_BILL_MEDIUM_EMAIL"])) {_oMobileRetentionOrder.bill_medium_email = (string)_oData["MOBILERETENTIONORDER_BILL_MEDIUM_EMAIL"]; } else {_oMobileRetentionOrder.bill_medium_email=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACTIVE"])) {_oMobileRetentionOrder.active = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_ACTIVE"]; } else {_oMobileRetentionOrder.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_S_PREMIUM1"])) {_oMobileRetentionOrder.s_premium1 = (string)_oData["MOBILERETENTIONORDER_S_PREMIUM1"]; } else {_oMobileRetentionOrder.s_premium1=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CARD_EXP_MONTH"])) {_oMobileRetentionOrder.card_exp_month = (string)_oData["MOBILERETENTIONORDER_CARD_EXP_MONTH"]; } else {_oMobileRetentionOrder.card_exp_month=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_OB_PROGRAM_ID"])) {_oMobileRetentionOrder.ob_program_id = (string)_oData["MOBILERETENTIONORDER_OB_PROGRAM_ID"]; } else {_oMobileRetentionOrder.ob_program_id=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SKU"])) {_oMobileRetentionOrder.sku = (string)_oData["MOBILERETENTIONORDER_SKU"]; } else {_oMobileRetentionOrder.sku=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REF_SALESMANCODE"])) {_oMobileRetentionOrder.ref_salesmancode = (string)_oData["MOBILERETENTIONORDER_REF_SALESMANCODE"]; } else {_oMobileRetentionOrder.ref_salesmancode=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GO_WIRELESS_PACKAGE_CODE"])) {_oMobileRetentionOrder.go_wireless_package_code = (string)_oData["MOBILERETENTIONORDER_GO_WIRELESS_PACKAGE_CODE"]; } else {_oMobileRetentionOrder.go_wireless_package_code=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_THIRD_PARTY_HKID"])) {_oMobileRetentionOrder.third_party_hkid = (string)_oData["MOBILERETENTIONORDER_THIRD_PARTY_HKID"]; } else {_oMobileRetentionOrder.third_party_hkid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_EXISTING_PCCW_CUSTOMER"])) {_oMobileRetentionOrder.upgrade_existing_pccw_customer = (string)_oData["MOBILERETENTIONORDER_UPGRADE_EXISTING_PCCW_CUSTOMER"]; } else {_oMobileRetentionOrder.upgrade_existing_pccw_customer=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_D_ADDRESS"])) {_oMobileRetentionOrder.d_address = (string)_oData["MOBILERETENTIONORDER_D_ADDRESS"]; } else {_oMobileRetentionOrder.d_address=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_REGISTERED_MOBILE_NO"])) {_oMobileRetentionOrder.upgrade_registered_mobile_no = (string)_oData["MOBILERETENTIONORDER_UPGRADE_REGISTERED_MOBILE_NO"]; } else {_oMobileRetentionOrder.upgrade_registered_mobile_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_EXISTING_CUSTOMER_TYPE"])) {_oMobileRetentionOrder.upgrade_existing_customer_type = (string)_oData["MOBILERETENTIONORDER_UPGRADE_EXISTING_CUSTOMER_TYPE"]; } else {_oMobileRetentionOrder.upgrade_existing_customer_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_NORMAL_REBATE_TYPE"])) {_oMobileRetentionOrder.normal_rebate_type = (string)_oData["MOBILERETENTIONORDER_NORMAL_REBATE_TYPE"]; } else {_oMobileRetentionOrder.normal_rebate_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_DESC2"])) {_oMobileRetentionOrder.gift_desc2 = (string)_oData["MOBILERETENTIONORDER_GIFT_DESC2"]; } else {_oMobileRetentionOrder.gift_desc2=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_BRANCH_CODE"])) {_oMobileRetentionOrder.monthly_bank_account_branch_code = (string)_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_BRANCH_CODE"]; } else {_oMobileRetentionOrder.monthly_bank_account_branch_code=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REMARKS"])) {_oMobileRetentionOrder.remarks = (string)_oData["MOBILERETENTIONORDER_REMARKS"]; } else {_oMobileRetentionOrder.remarks=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACCEPT"])) {_oMobileRetentionOrder.accept = (string)_oData["MOBILERETENTIONORDER_ACCEPT"]; } else {_oMobileRetentionOrder.accept=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_DELIVERY_EXCHANGE"])) {_oMobileRetentionOrder.delivery_exchange = (string)_oData["MOBILERETENTIONORDER_DELIVERY_EXCHANGE"]; } else {_oMobileRetentionOrder.delivery_exchange=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_CODE2"])) {_oMobileRetentionOrder.gift_code2 = (string)_oData["MOBILERETENTIONORDER_GIFT_CODE2"]; } else {_oMobileRetentionOrder.gift_code2=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_PREPAYMENT_WAIVE"])) {_oMobileRetentionOrder.prepayment_waive = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_PREPAYMENT_WAIVE"]; } else {_oMobileRetentionOrder.prepayment_waive=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXISTING_SMART_PHONE_IMEI"])) {_oMobileRetentionOrder.existing_smart_phone_imei = (string)_oData["MOBILERETENTIONORDER_EXISTING_SMART_PHONE_IMEI"]; } else {_oMobileRetentionOrder.existing_smart_phone_imei=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CUST_NAME"])) {_oMobileRetentionOrder.cust_name = (string)_oData["MOBILERETENTIONORDER_CUST_NAME"]; } else {_oMobileRetentionOrder.cust_name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CUST_TYPE"])) {_oMobileRetentionOrder.cust_type = (string)_oData["MOBILERETENTIONORDER_CUST_TYPE"]; } else {_oMobileRetentionOrder.cust_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_SPONSORSHIPS_AMOUNT"])) {_oMobileRetentionOrder.upgrade_sponsorships_amount = (string)_oData["MOBILERETENTIONORDER_UPGRADE_SPONSORSHIPS_AMOUNT"]; } else {_oMobileRetentionOrder.upgrade_sponsorships_amount=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_BILL_MEDIUM_WAIVE"])) {_oMobileRetentionOrder.bill_medium_waive = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_BILL_MEDIUM_WAIVE"]; } else {_oMobileRetentionOrder.bill_medium_waive=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_DELIVERY_EXCHANGE_LOCATION"])) {_oMobileRetentionOrder.delivery_exchange_location = (string)_oData["MOBILERETENTIONORDER_DELIVERY_EXCHANGE_LOCATION"]; } else {_oMobileRetentionOrder.delivery_exchange_location=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_HS_OFFER_TYPE_ID"])) {_oMobileRetentionOrder.hs_offer_type_id = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDER_HS_OFFER_TYPE_ID"]; } else {_oMobileRetentionOrder.hs_offer_type_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORG_FEE"])) {_oMobileRetentionOrder.org_fee = (string)_oData["MOBILERETENTIONORDER_ORG_FEE"]; } else {_oMobileRetentionOrder.org_fee=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REBATE"])) {_oMobileRetentionOrder.rebate = (string)_oData["MOBILERETENTIONORDER_REBATE"]; } else {_oMobileRetentionOrder.rebate=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_TYPE"])) {_oMobileRetentionOrder.upgrade_type = (string)_oData["MOBILERETENTIONORDER_UPGRADE_TYPE"]; } else {_oMobileRetentionOrder.upgrade_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GO_WIRELESS"])) {_oMobileRetentionOrder.go_wireless = (string)_oData["MOBILERETENTIONORDER_GO_WIRELESS"]; } else {_oMobileRetentionOrder.go_wireless=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXTRA_REBATE"])) {_oMobileRetentionOrder.extra_rebate = (string)_oData["MOBILERETENTIONORDER_EXTRA_REBATE"]; } else {_oMobileRetentionOrder.extra_rebate=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_PLAN_EFF"])) {_oMobileRetentionOrder.plan_eff = (string)_oData["MOBILERETENTIONORDER_PLAN_EFF"]; } else {_oMobileRetentionOrder.plan_eff=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXTRA_REBATE_AMOUNT"])) {_oMobileRetentionOrder.extra_rebate_amount = (string)_oData["MOBILERETENTIONORDER_EXTRA_REBATE_AMOUNT"]; } else {_oMobileRetentionOrder.extra_rebate_amount=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CARD_EXP_YEAR"])) {_oMobileRetentionOrder.card_exp_year = (string)_oData["MOBILERETENTIONORDER_CARD_EXP_YEAR"]; } else {_oMobileRetentionOrder.card_exp_year=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_EXISTING_CONTRACT_SDATE"])) {_oMobileRetentionOrder.upgrade_existing_contract_sdate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_UPGRADE_EXISTING_CONTRACT_SDATE"]; } else {_oMobileRetentionOrder.upgrade_existing_contract_sdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORD_PLACE_HKID"])) {_oMobileRetentionOrder.ord_place_hkid = (string)_oData["MOBILERETENTIONORDER_ORD_PLACE_HKID"]; } else {_oMobileRetentionOrder.ord_place_hkid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REGISTER_ADDRESS"])) {_oMobileRetentionOrder.register_address = (string)_oData["MOBILERETENTIONORDER_REGISTER_ADDRESS"]; } else {_oMobileRetentionOrder.register_address=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GENDER"])) {_oMobileRetentionOrder.gender = (string)_oData["MOBILERETENTIONORDER_GENDER"]; } else {_oMobileRetentionOrder.gender=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_LOB_AC"])) {_oMobileRetentionOrder.lob_ac = (string)_oData["MOBILERETENTIONORDER_LOB_AC"]; } else {_oMobileRetentionOrder.lob_ac=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SIM_MRT_NO"])) {_oMobileRetentionOrder.sim_mrt_no = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDER_SIM_MRT_NO"]; } else {_oMobileRetentionOrder.sim_mrt_no=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REDEMPTION_NOTICE_OPTION"])) {_oMobileRetentionOrder.redemption_notice_option = (string)_oData["MOBILERETENTIONORDER_REDEMPTION_NOTICE_OPTION"]; } else {_oMobileRetentionOrder.redemption_notice_option=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_DELIVERY_COLLECTION_TYPE"])) {_oMobileRetentionOrder.delivery_collection_type = (string)_oData["MOBILERETENTIONORDER_DELIVERY_COLLECTION_TYPE"]; } else {_oMobileRetentionOrder.delivery_collection_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACTION_DATE"])) {_oMobileRetentionOrder.action_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_ACTION_DATE"]; } else {_oMobileRetentionOrder.action_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_THIRD_PARTY_ID_TYPE"])) {_oMobileRetentionOrder.third_party_id_type = (string)_oData["MOBILERETENTIONORDER_THIRD_PARTY_ID_TYPE"]; } else {_oMobileRetentionOrder.third_party_id_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORG_FTG"])) {_oMobileRetentionOrder.org_ftg = (string)_oData["MOBILERETENTIONORDER_ORG_FTG"]; } else {_oMobileRetentionOrder.org_ftg=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_SERVICE_TENURE"])) {_oMobileRetentionOrder.upgrade_service_tenure = (string)_oData["MOBILERETENTIONORDER_UPGRADE_SERVICE_TENURE"]; } else {_oMobileRetentionOrder.upgrade_service_tenure=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_PAYMENT_TYPE"])) {_oMobileRetentionOrder.monthly_payment_type = (string)_oData["MOBILERETENTIONORDER_MONTHLY_PAYMENT_TYPE"]; } else {_oMobileRetentionOrder.monthly_payment_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CONTACT_NO"])) {_oMobileRetentionOrder.contact_no = (string)_oData["MOBILERETENTIONORDER_CONTACT_NO"]; } else {_oMobileRetentionOrder.contact_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORG_MRT"])) {_oMobileRetentionOrder.org_mrt = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDER_ORG_MRT"]; } else {_oMobileRetentionOrder.org_mrt=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SIM_ITEM_NAME"])) {_oMobileRetentionOrder.sim_item_name = (string)_oData["MOBILERETENTIONORDER_SIM_ITEM_NAME"]; } else {_oMobileRetentionOrder.sim_item_name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_PAY_METHOD"])) {_oMobileRetentionOrder.pay_method = (string)_oData["MOBILERETENTIONORDER_PAY_METHOD"]; } else {_oMobileRetentionOrder.pay_method=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_HS_MODEL"])) {_oMobileRetentionOrder.hs_model = (string)_oData["MOBILERETENTIONORDER_HS_MODEL"]; } else {_oMobileRetentionOrder.hs_model=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_CODE"])) {_oMobileRetentionOrder.gift_code = (string)_oData["MOBILERETENTIONORDER_GIFT_CODE"]; } else {_oMobileRetentionOrder.gift_code=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HKID"])) {_oMobileRetentionOrder.monthly_bank_account_hkid = (string)_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HKID"]; } else {_oMobileRetentionOrder.monthly_bank_account_hkid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXTRA_OFFER"])) {_oMobileRetentionOrder.extra_offer = (string)_oData["MOBILERETENTIONORDER_EXTRA_OFFER"]; } else {_oMobileRetentionOrder.extra_offer=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_NO"])) {_oMobileRetentionOrder.monthly_bank_account_no = (string)_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_NO"]; } else {_oMobileRetentionOrder.monthly_bank_account_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_FIRST_MONTH_LICENSE_FEE"])) {_oMobileRetentionOrder.first_month_license_fee = (string)_oData["MOBILERETENTIONORDER_FIRST_MONTH_LICENSE_FEE"]; } else {_oMobileRetentionOrder.first_month_license_fee=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_RETRIEVE_CNT"])) {_oMobileRetentionOrder.retrieve_cnt = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDER_RETRIEVE_CNT"]; } else {_oMobileRetentionOrder.retrieve_cnt=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_DDATE"])) {_oMobileRetentionOrder.ddate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_DDATE"]; } else {_oMobileRetentionOrder.ddate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_S_PREMIUM2"])) {_oMobileRetentionOrder.s_premium2 = (string)_oData["MOBILERETENTIONORDER_S_PREMIUM2"]; } else {_oMobileRetentionOrder.s_premium2=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_ID_TYPE"])) {_oMobileRetentionOrder.monthly_bank_account_id_type = (string)_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_ID_TYPE"]; } else {_oMobileRetentionOrder.monthly_bank_account_id_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CARD_TYPE"])) {_oMobileRetentionOrder.card_type = (string)_oData["MOBILERETENTIONORDER_CARD_TYPE"]; } else {_oMobileRetentionOrder.card_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_NEXT_BILL"])) {_oMobileRetentionOrder.next_bill = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_NEXT_BILL"]; } else {_oMobileRetentionOrder.next_bill=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_PCD_PAID_GO_WIRELESS"])) {_oMobileRetentionOrder.pcd_paid_go_wireless = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_PCD_PAID_GO_WIRELESS"]; } else {_oMobileRetentionOrder.pcd_paid_go_wireless=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_REBATE_CALCULATION"])) {_oMobileRetentionOrder.upgrade_rebate_calculation = (string)_oData["MOBILERETENTIONORDER_UPGRADE_REBATE_CALCULATION"]; } else {_oMobileRetentionOrder.upgrade_rebate_calculation=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXT_PLACE_TEL"])) {_oMobileRetentionOrder.ext_place_tel = (string)_oData["MOBILERETENTIONORDER_EXT_PLACE_TEL"]; } else {_oMobileRetentionOrder.ext_place_tel=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_3RD_HKID"])) {_oMobileRetentionOrder.m_3rd_hkid = (string)_oData["MOBILERETENTIONORDER_M_3RD_HKID"]; } else {_oMobileRetentionOrder.m_3rd_hkid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_RETENTION_TYPE"])) {_oMobileRetentionOrder.retention_type = (string)_oData["MOBILERETENTIONORDER_RETENTION_TYPE"]; } else {_oMobileRetentionOrder.retention_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_COOLING_DATE"])) {_oMobileRetentionOrder.cooling_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_COOLING_DATE"]; } else {_oMobileRetentionOrder.cooling_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_AIG_GIFT"])) {_oMobileRetentionOrder.aig_gift = (string)_oData["MOBILERETENTIONORDER_AIG_GIFT"]; } else {_oMobileRetentionOrder.aig_gift=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CUST_STAFF_NO"])) {_oMobileRetentionOrder.cust_staff_no = (string)_oData["MOBILERETENTIONORDER_CUST_STAFF_NO"]; } else {_oMobileRetentionOrder.cust_staff_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORDER_ID"])) {_oMobileRetentionOrder.order_id = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDER_ORDER_ID"]; } else {_oMobileRetentionOrder.order_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_FAMILY_NAME"])) {_oMobileRetentionOrder.family_name = (string)_oData["MOBILERETENTIONORDER_FAMILY_NAME"]; } else {_oMobileRetentionOrder.family_name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CDATE"])) {_oMobileRetentionOrder.cdate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_CDATE"]; } else {_oMobileRetentionOrder.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_STATUS_BY_CS_ADMIN"])) {_oMobileRetentionOrder.status_by_cs_admin = (string)_oData["MOBILERETENTIONORDER_STATUS_BY_CS_ADMIN"]; } else {_oMobileRetentionOrder.status_by_cs_admin=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SIM_ITEM_NUMBER"])) {_oMobileRetentionOrder.sim_item_number = (string)_oData["MOBILERETENTIONORDER_SIM_ITEM_NUMBER"]; } else {_oMobileRetentionOrder.sim_item_number=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_VIP_CASE"])) {_oMobileRetentionOrder.vip_case = (string)_oData["MOBILERETENTIONORDER_VIP_CASE"]; } else {_oMobileRetentionOrder.vip_case=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIVEN_NAME"])) {_oMobileRetentionOrder.given_name = (string)_oData["MOBILERETENTIONORDER_GIVEN_NAME"]; } else {_oMobileRetentionOrder.given_name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_LOG_DATE"])) {_oMobileRetentionOrder.log_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_LOG_DATE"]; } else {_oMobileRetentionOrder.log_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXTN"])) {_oMobileRetentionOrder.extn = (string)_oData["MOBILERETENTIONORDER_EXTN"]; } else {_oMobileRetentionOrder.extn=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_D_TIME"])) {_oMobileRetentionOrder.d_time = (string)_oData["MOBILERETENTIONORDER_D_TIME"]; } else {_oMobileRetentionOrder.d_time=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_BANK_NAME"])) {_oMobileRetentionOrder.bank_name = (string)_oData["MOBILERETENTIONORDER_BANK_NAME"]; } else {_oMobileRetentionOrder.bank_name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_DELIVERY_EXCHANGE_OPTION"])) {_oMobileRetentionOrder.delivery_exchange_option = (string)_oData["MOBILERETENTIONORDER_DELIVERY_EXCHANGE_OPTION"]; } else {_oMobileRetentionOrder.delivery_exchange_option=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_UPGRADE_SERVICE_ACCOUNT_NO"])) {_oMobileRetentionOrder.upgrade_service_account_no = (string)_oData["MOBILERETENTIONORDER_UPGRADE_SERVICE_ACCOUNT_NO"]; } else {_oMobileRetentionOrder.upgrade_service_account_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACTION_OF_RATE_PLAN_EFFECTIVE"])) {_oMobileRetentionOrder.action_of_rate_plan_effective = (string)_oData["MOBILERETENTIONORDER_ACTION_OF_RATE_PLAN_EFFECTIVE"]; } else {_oMobileRetentionOrder.action_of_rate_plan_effective=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_CARD_NO"])) {_oMobileRetentionOrder.m_card_no = (string)_oData["MOBILERETENTIONORDER_M_CARD_NO"]; } else {_oMobileRetentionOrder.m_card_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EXISTING_CONTRACT_END_DATE"])) {_oMobileRetentionOrder.existing_contract_end_date = (string)_oData["MOBILERETENTIONORDER_EXISTING_CONTRACT_END_DATE"]; } else {_oMobileRetentionOrder.existing_contract_end_date=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CON_EFF_DATE"])) {_oMobileRetentionOrder.con_eff_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_CON_EFF_DATE"]; } else {_oMobileRetentionOrder.con_eff_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_3RD_HKID2"])) {_oMobileRetentionOrder.m_3rd_hkid2 = (string)_oData["MOBILERETENTIONORDER_M_3RD_HKID2"]; } else {_oMobileRetentionOrder.m_3rd_hkid2=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_AMOUNT"])) {_oMobileRetentionOrder.amount = (string)_oData["MOBILERETENTIONORDER_AMOUNT"]; } else {_oMobileRetentionOrder.amount=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ID_TYPE"])) {_oMobileRetentionOrder.id_type = (string)_oData["MOBILERETENTIONORDER_ID_TYPE"]; } else {_oMobileRetentionOrder.id_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_RATE_PLAN"])) {_oMobileRetentionOrder.rate_plan = (string)_oData["MOBILERETENTIONORDER_RATE_PLAN"]; } else {_oMobileRetentionOrder.rate_plan=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CHANNEL"])) {_oMobileRetentionOrder.channel = (string)_oData["MOBILERETENTIONORDER_CHANNEL"]; } else {_oMobileRetentionOrder.channel=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACTION_EFF_DATE"])) {_oMobileRetentionOrder.action_eff_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_ACTION_EFF_DATE"]; } else {_oMobileRetentionOrder.action_eff_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ISSUE_TYPE"])) {_oMobileRetentionOrder.issue_type = (string)_oData["MOBILERETENTIONORDER_ISSUE_TYPE"]; } else {_oMobileRetentionOrder.issue_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_FREE_MON"])) {_oMobileRetentionOrder.free_mon = (string)_oData["MOBILERETENTIONORDER_FREE_MON"]; } else {_oMobileRetentionOrder.free_mon=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_PLAN_EFF_DATE"])) {_oMobileRetentionOrder.plan_eff_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_PLAN_EFF_DATE"]; } else {_oMobileRetentionOrder.plan_eff_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_DEL_REMARK"])) {_oMobileRetentionOrder.del_remark = (string)_oData["MOBILERETENTIONORDER_DEL_REMARK"]; } else {_oMobileRetentionOrder.del_remark=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_TEAMCODE"])) {_oMobileRetentionOrder.teamcode = (string)_oData["MOBILERETENTIONORDER_TEAMCODE"]; } else {_oMobileRetentionOrder.teamcode=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_STAFF_NAME"])) {_oMobileRetentionOrder.staff_name = (string)_oData["MOBILERETENTIONORDER_STAFF_NAME"]; } else {_oMobileRetentionOrder.staff_name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_EDF_NO"])) {_oMobileRetentionOrder.edf_no = (string)_oData["MOBILERETENTIONORDER_EDF_NO"]; } else {_oMobileRetentionOrder.edf_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ORD_PLACE_BY"])) {_oMobileRetentionOrder.ord_place_by = (string)_oData["MOBILERETENTIONORDER_ORD_PLACE_BY"]; } else {_oMobileRetentionOrder.ord_place_by=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CANCEL_RENEW"])) {_oMobileRetentionOrder.cancel_renew = (string)_oData["MOBILERETENTIONORDER_CANCEL_RENEW"]; } else {_oMobileRetentionOrder.cancel_renew=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_PREFERRED_LANGUAGES"])) {_oMobileRetentionOrder.preferred_languages = (string)_oData["MOBILERETENTIONORDER_PREFERRED_LANGUAGES"]; } else {_oMobileRetentionOrder.preferred_languages=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_HKID"])) {_oMobileRetentionOrder.hkid = (string)_oData["MOBILERETENTIONORDER_HKID"]; } else {_oMobileRetentionOrder.hkid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CARD_NO"])) {_oMobileRetentionOrder.card_no = (string)_oData["MOBILERETENTIONORDER_CARD_NO"]; } else {_oMobileRetentionOrder.card_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_AC_NO"])) {_oMobileRetentionOrder.ac_no = (string)_oData["MOBILERETENTIONORDER_AC_NO"]; } else {_oMobileRetentionOrder.ac_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_BILL_CUT_NUM"])) {_oMobileRetentionOrder.bill_cut_num = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDER_BILL_CUT_NUM"]; } else {_oMobileRetentionOrder.bill_cut_num=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_PREMIUM"])) {_oMobileRetentionOrder.premium = (string)_oData["MOBILERETENTIONORDER_PREMIUM"]; } else {_oMobileRetentionOrder.premium=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_3RD_ID_TYPE"])) {_oMobileRetentionOrder.m_3rd_id_type = (string)_oData["MOBILERETENTIONORDER_M_3RD_ID_TYPE"]; } else {_oMobileRetentionOrder.m_3rd_id_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_GIFT_IMEI2"])) {_oMobileRetentionOrder.gift_imei2 = (string)_oData["MOBILERETENTIONORDER_GIFT_IMEI2"]; } else {_oMobileRetentionOrder.gift_imei2=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REASONS"])) {_oMobileRetentionOrder.reasons = (string)_oData["MOBILERETENTIONORDER_REASONS"]; } else {_oMobileRetentionOrder.reasons=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_LANGUAGE"])) {_oMobileRetentionOrder.language = (string)_oData["MOBILERETENTIONORDER_LANGUAGE"]; } else {_oMobileRetentionOrder.language=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_REBATE_AMOUNT"])) {_oMobileRetentionOrder.rebate_amount = (string)_oData["MOBILERETENTIONORDER_REBATE_AMOUNT"]; } else {_oMobileRetentionOrder.rebate_amount=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_LOB"])) {_oMobileRetentionOrder.lob = (string)_oData["MOBILERETENTIONORDER_LOB"]; } else {_oMobileRetentionOrder.lob=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_M_3RD_CONTACT_NO"])) {_oMobileRetentionOrder.m_3rd_contact_no = (string)_oData["MOBILERETENTIONORDER_M_3RD_CONTACT_NO"]; } else {_oMobileRetentionOrder.m_3rd_contact_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_STAFF_NO"])) {_oMobileRetentionOrder.staff_no = (string)_oData["MOBILERETENTIONORDER_STAFF_NO"]; } else {_oMobileRetentionOrder.staff_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_S_PREMIUM3"])) {_oMobileRetentionOrder.s_premium3 = (string)_oData["MOBILERETENTIONORDER_S_PREMIUM3"]; } else {_oMobileRetentionOrder.s_premium3=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SP_D_DATE"])) {_oMobileRetentionOrder.sp_d_date = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDER_SP_D_DATE"]; } else {_oMobileRetentionOrder.sp_d_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_BUNDLE_NAME"])) {_oMobileRetentionOrder.bundle_name = (string)_oData["MOBILERETENTIONORDER_BUNDLE_NAME"]; } else {_oMobileRetentionOrder.bundle_name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_ACCESSORY_WAIVE"])) {_oMobileRetentionOrder.accessory_waive = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDER_ACCESSORY_WAIVE"]; } else {_oMobileRetentionOrder.accessory_waive=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_SIM_ITEM_CODE"])) {_oMobileRetentionOrder.sim_item_code = (string)_oData["MOBILERETENTIONORDER_SIM_ITEM_CODE"]; } else {_oMobileRetentionOrder.sim_item_code=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HOLDER"])) {_oMobileRetentionOrder.monthly_bank_account_holder = (string)_oData["MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HOLDER"]; } else {_oMobileRetentionOrder.monthly_bank_account_holder=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDER_CARD_HOLDER"])) {_oMobileRetentionOrder.card_holder = (string)_oData["MOBILERETENTIONORDER_CARD_HOLDER"]; } else {_oMobileRetentionOrder.card_holder=global::System.String.Empty; }
                _oMobileRetentionOrder.SetDB(x_oDB);
                _oMobileRetentionOrder.GetFound();
                _oRow.Add(_oMobileRetentionOrder);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( MobileRetentionOrder.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,MobileRetentionOrder.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(MobileRetentionOrder.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(MobileRetentionOrder.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [MobileRetentionOrder].[gift_imei] AS MOBILERETENTIONORDER_GIFT_IMEI,[MobileRetentionOrder].[s_premium4] AS MOBILERETENTIONORDER_S_PREMIUM4,[MobileRetentionOrder].[upgrade_existing_customer_type] AS MOBILERETENTIONORDER_UPGRADE_EXISTING_CUSTOMER_TYPE,[MobileRetentionOrder].[gift_desc4] AS MOBILERETENTIONORDER_GIFT_DESC4,[MobileRetentionOrder].[accessory_desc] AS MOBILERETENTIONORDER_ACCESSORY_DESC,[MobileRetentionOrder].[staff_name] AS MOBILERETENTIONORDER_STAFF_NAME,[MobileRetentionOrder].[action_required] AS MOBILERETENTIONORDER_ACTION_REQUIRED,[MobileRetentionOrder].[vas_eff_date] AS MOBILERETENTIONORDER_VAS_EFF_DATE,[MobileRetentionOrder].[monthly_bank_account_bank_code] AS MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_BANK_CODE,[MobileRetentionOrder].[sim_item_number] AS MOBILERETENTIONORDER_SIM_ITEM_NUMBER,[MobileRetentionOrder].[special_handling_dummy_code] AS MOBILERETENTIONORDER_SPECIAL_HANDLING_DUMMY_CODE,[MobileRetentionOrder].[card_no] AS MOBILERETENTIONORDER_CARD_NO,[MobileRetentionOrder].[m_card_exp_year] AS MOBILERETENTIONORDER_M_CARD_EXP_YEAR,[MobileRetentionOrder].[bill_medium_email] AS MOBILERETENTIONORDER_BILL_MEDIUM_EMAIL,[MobileRetentionOrder].[remarks2PY] AS MOBILERETENTIONORDER_REMARKS2PY,[MobileRetentionOrder].[trade_field] AS MOBILERETENTIONORDER_TRADE_FIELD,[MobileRetentionOrder].[ord_place_tel] AS MOBILERETENTIONORDER_ORD_PLACE_TEL,[MobileRetentionOrder].[action_of_rate_plan_effective] AS MOBILERETENTIONORDER_ACTION_OF_RATE_PLAN_EFFECTIVE,[MobileRetentionOrder].[cooling_offer] AS MOBILERETENTIONORDER_COOLING_OFFER,[MobileRetentionOrder].[upgrade_handset_offer_rebate_schedule] AS MOBILERETENTIONORDER_UPGRADE_HANDSET_OFFER_REBATE_SCHEDULE,[MobileRetentionOrder].[change_payment_type] AS MOBILERETENTIONORDER_CHANGE_PAYMENT_TYPE,[MobileRetentionOrder].[date_of_birth] AS MOBILERETENTIONORDER_DATE_OF_BIRTH,[MobileRetentionOrder].[contact_person] AS MOBILERETENTIONORDER_CONTACT_PERSON,[MobileRetentionOrder].[extra_d_charge] AS MOBILERETENTIONORDER_EXTRA_D_CHARGE,[MobileRetentionOrder].[tl_name] AS MOBILERETENTIONORDER_TL_NAME,[MobileRetentionOrder].[fast_start] AS MOBILERETENTIONORDER_FAST_START,[MobileRetentionOrder].[sp_ref_no] AS MOBILERETENTIONORDER_SP_REF_NO,[MobileRetentionOrder].[edate] AS MOBILERETENTIONORDER_EDATE,[MobileRetentionOrder].[exist_cust_plan] AS MOBILERETENTIONORDER_EXIST_CUST_PLAN,[MobileRetentionOrder].[ord_place_rel] AS MOBILERETENTIONORDER_ORD_PLACE_REL,[MobileRetentionOrder].[mrt_no] AS MOBILERETENTIONORDER_MRT_NO,[MobileRetentionOrder].[imei_no] AS MOBILERETENTIONORDER_IMEI_NO,[MobileRetentionOrder].[existing_smart_phone_model] AS MOBILERETENTIONORDER_EXISTING_SMART_PHONE_MODEL,[MobileRetentionOrder].[bank_code] AS MOBILERETENTIONORDER_BANK_CODE,[MobileRetentionOrder].[pos_ref_no] AS MOBILERETENTIONORDER_POS_REF_NO,[MobileRetentionOrder].[bill_cut_date] AS MOBILERETENTIONORDER_BILL_CUT_DATE,[MobileRetentionOrder].[gift_imei3] AS MOBILERETENTIONORDER_GIFT_IMEI3,[MobileRetentionOrder].[exist_plan] AS MOBILERETENTIONORDER_EXIST_PLAN,[MobileRetentionOrder].[waive] AS MOBILERETENTIONORDER_WAIVE,[MobileRetentionOrder].[program] AS MOBILERETENTIONORDER_PROGRAM,[MobileRetentionOrder].[first_month_fee] AS MOBILERETENTIONORDER_FIRST_MONTH_FEE,[MobileRetentionOrder].[r_offer] AS MOBILERETENTIONORDER_R_OFFER,[MobileRetentionOrder].[cid] AS MOBILERETENTIONORDER_CID,[MobileRetentionOrder].[did] AS MOBILERETENTIONORDER_DID,[MobileRetentionOrder].[ftg_tenure] AS MOBILERETENTIONORDER_FTG_TENURE,[MobileRetentionOrder].[con_per] AS MOBILERETENTIONORDER_CON_PER,[MobileRetentionOrder].[gift_code4] AS MOBILERETENTIONORDER_GIFT_CODE4,[MobileRetentionOrder].[easywatch_type] AS MOBILERETENTIONORDER_EASYWATCH_TYPE,[MobileRetentionOrder].[sms_mrt] AS MOBILERETENTIONORDER_SMS_MRT,[MobileRetentionOrder].[monthly_payment_method] AS MOBILERETENTIONORDER_MONTHLY_PAYMENT_METHOD,[MobileRetentionOrder].[remarks2EDF] AS MOBILERETENTIONORDER_REMARKS2EDF,[MobileRetentionOrder].[gift_desc3] AS MOBILERETENTIONORDER_GIFT_DESC3,[MobileRetentionOrder].[gift_imei4] AS MOBILERETENTIONORDER_GIFT_IMEI4,[MobileRetentionOrder].[monthly_bank_account_hkid2] AS MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HKID2,[MobileRetentionOrder].[d_date] AS MOBILERETENTIONORDER_D_DATE,[MobileRetentionOrder].[gift_desc] AS MOBILERETENTIONORDER_GIFT_DESC,[MobileRetentionOrder].[pool] AS MOBILERETENTIONORDER_POOL,[MobileRetentionOrder].[cn_mrt_no] AS MOBILERETENTIONORDER_CN_MRT_NO,[MobileRetentionOrder].[accessory_imei] AS MOBILERETENTIONORDER_ACCESSORY_IMEI,[MobileRetentionOrder].[third_party_credit_card] AS MOBILERETENTIONORDER_THIRD_PARTY_CREDIT_CARD,[MobileRetentionOrder].[special_approval] AS MOBILERETENTIONORDER_SPECIAL_APPROVAL,[MobileRetentionOrder].[upgrade_existing_contract_edate] AS MOBILERETENTIONORDER_UPGRADE_EXISTING_CONTRACT_EDATE,[MobileRetentionOrder].[accessory_code] AS MOBILERETENTIONORDER_ACCESSORY_CODE,[MobileRetentionOrder].[s_premium] AS MOBILERETENTIONORDER_S_PREMIUM,[MobileRetentionOrder].[ref_staff_no] AS MOBILERETENTIONORDER_REF_STAFF_NO,[MobileRetentionOrder].[accessory_price] AS MOBILERETENTIONORDER_ACCESSORY_PRICE,[MobileRetentionOrder].[m_card_exp_month] AS MOBILERETENTIONORDER_M_CARD_EXP_MONTH,[MobileRetentionOrder].[installment_period] AS MOBILERETENTIONORDER_INSTALLMENT_PERIOD,[MobileRetentionOrder].[m_card_type] AS MOBILERETENTIONORDER_M_CARD_TYPE,[MobileRetentionOrder].[easywatch_ord_id] AS MOBILERETENTIONORDER_EASYWATCH_ORD_ID,[MobileRetentionOrder].[normal_rebate] AS MOBILERETENTIONORDER_NORMAL_REBATE,[MobileRetentionOrder].[m_rebate_amount] AS MOBILERETENTIONORDER_M_REBATE_AMOUNT,[MobileRetentionOrder].[m_card_holder2] AS MOBILERETENTIONORDER_M_CARD_HOLDER2,[MobileRetentionOrder].[monthly_bank_account_holder] AS MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HOLDER,[MobileRetentionOrder].[active] AS MOBILERETENTIONORDER_ACTIVE,[MobileRetentionOrder].[s_premium1] AS MOBILERETENTIONORDER_S_PREMIUM1,[MobileRetentionOrder].[card_exp_month] AS MOBILERETENTIONORDER_CARD_EXP_MONTH,[MobileRetentionOrder].[ob_program_id] AS MOBILERETENTIONORDER_OB_PROGRAM_ID,[MobileRetentionOrder].[sku] AS MOBILERETENTIONORDER_SKU,[MobileRetentionOrder].[salesmancode] AS MOBILERETENTIONORDER_SALESMANCODE,[MobileRetentionOrder].[go_wireless_package_code] AS MOBILERETENTIONORDER_GO_WIRELESS_PACKAGE_CODE,[MobileRetentionOrder].[lob] AS MOBILERETENTIONORDER_LOB,[MobileRetentionOrder].[ref_salesmancode] AS MOBILERETENTIONORDER_REF_SALESMANCODE,[MobileRetentionOrder].[third_party_hkid] AS MOBILERETENTIONORDER_THIRD_PARTY_HKID,[MobileRetentionOrder].[upgrade_existing_pccw_customer] AS MOBILERETENTIONORDER_UPGRADE_EXISTING_PCCW_CUSTOMER,[MobileRetentionOrder].[d_address] AS MOBILERETENTIONORDER_D_ADDRESS,[MobileRetentionOrder].[upgrade_registered_mobile_no] AS MOBILERETENTIONORDER_UPGRADE_REGISTERED_MOBILE_NO,[MobileRetentionOrder].[gift_code3] AS MOBILERETENTIONORDER_GIFT_CODE3,[MobileRetentionOrder].[normal_rebate_type] AS MOBILERETENTIONORDER_NORMAL_REBATE_TYPE,[MobileRetentionOrder].[gift_desc2] AS MOBILERETENTIONORDER_GIFT_DESC2,[MobileRetentionOrder].[monthly_bank_account_branch_code] AS MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_BRANCH_CODE,[MobileRetentionOrder].[remarks] AS MOBILERETENTIONORDER_REMARKS,[MobileRetentionOrder].[accept] AS MOBILERETENTIONORDER_ACCEPT,[MobileRetentionOrder].[delivery_exchange] AS MOBILERETENTIONORDER_DELIVERY_EXCHANGE,[MobileRetentionOrder].[gift_code2] AS MOBILERETENTIONORDER_GIFT_CODE2,[MobileRetentionOrder].[prepayment_waive] AS MOBILERETENTIONORDER_PREPAYMENT_WAIVE,[MobileRetentionOrder].[existing_smart_phone_imei] AS MOBILERETENTIONORDER_EXISTING_SMART_PHONE_IMEI,[MobileRetentionOrder].[cust_name] AS MOBILERETENTIONORDER_CUST_NAME,[MobileRetentionOrder].[upgrade_sponsorships_amount] AS MOBILERETENTIONORDER_UPGRADE_SPONSORSHIPS_AMOUNT,[MobileRetentionOrder].[bill_medium_waive] AS MOBILERETENTIONORDER_BILL_MEDIUM_WAIVE,[MobileRetentionOrder].[delivery_exchange_location] AS MOBILERETENTIONORDER_DELIVERY_EXCHANGE_LOCATION,[MobileRetentionOrder].[hs_offer_type_id] AS MOBILERETENTIONORDER_HS_OFFER_TYPE_ID,[MobileRetentionOrder].[extra_rebate_amount] AS MOBILERETENTIONORDER_EXTRA_REBATE_AMOUNT,[MobileRetentionOrder].[rebate] AS MOBILERETENTIONORDER_REBATE,[MobileRetentionOrder].[upgrade_type] AS MOBILERETENTIONORDER_UPGRADE_TYPE,[MobileRetentionOrder].[go_wireless] AS MOBILERETENTIONORDER_GO_WIRELESS,[MobileRetentionOrder].[extra_rebate] AS MOBILERETENTIONORDER_EXTRA_REBATE,[MobileRetentionOrder].[plan_eff] AS MOBILERETENTIONORDER_PLAN_EFF,[MobileRetentionOrder].[card_exp_year] AS MOBILERETENTIONORDER_CARD_EXP_YEAR,[MobileRetentionOrder].[upgrade_existing_contract_sdate] AS MOBILERETENTIONORDER_UPGRADE_EXISTING_CONTRACT_SDATE,[MobileRetentionOrder].[ord_place_hkid] AS MOBILERETENTIONORDER_ORD_PLACE_HKID,[MobileRetentionOrder].[register_address] AS MOBILERETENTIONORDER_REGISTER_ADDRESS,[MobileRetentionOrder].[gender] AS MOBILERETENTIONORDER_GENDER,[MobileRetentionOrder].[lob_ac] AS MOBILERETENTIONORDER_LOB_AC,[MobileRetentionOrder].[sim_mrt_no] AS MOBILERETENTIONORDER_SIM_MRT_NO,[MobileRetentionOrder].[redemption_notice_option] AS MOBILERETENTIONORDER_REDEMPTION_NOTICE_OPTION,[MobileRetentionOrder].[delivery_collection_type] AS MOBILERETENTIONORDER_DELIVERY_COLLECTION_TYPE,[MobileRetentionOrder].[action_date] AS MOBILERETENTIONORDER_ACTION_DATE,[MobileRetentionOrder].[third_party_id_type] AS MOBILERETENTIONORDER_THIRD_PARTY_ID_TYPE,[MobileRetentionOrder].[org_ftg] AS MOBILERETENTIONORDER_ORG_FTG,[MobileRetentionOrder].[upgrade_service_tenure] AS MOBILERETENTIONORDER_UPGRADE_SERVICE_TENURE,[MobileRetentionOrder].[monthly_payment_type] AS MOBILERETENTIONORDER_MONTHLY_PAYMENT_TYPE,[MobileRetentionOrder].[contact_no] AS MOBILERETENTIONORDER_CONTACT_NO,[MobileRetentionOrder].[org_mrt] AS MOBILERETENTIONORDER_ORG_MRT,[MobileRetentionOrder].[sim_item_name] AS MOBILERETENTIONORDER_SIM_ITEM_NAME,[MobileRetentionOrder].[pay_method] AS MOBILERETENTIONORDER_PAY_METHOD,[MobileRetentionOrder].[hs_model] AS MOBILERETENTIONORDER_HS_MODEL,[MobileRetentionOrder].[gift_code] AS MOBILERETENTIONORDER_GIFT_CODE,[MobileRetentionOrder].[monthly_bank_account_hkid] AS MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_HKID,[MobileRetentionOrder].[extra_offer] AS MOBILERETENTIONORDER_EXTRA_OFFER,[MobileRetentionOrder].[monthly_bank_account_no] AS MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_NO,[MobileRetentionOrder].[first_month_license_fee] AS MOBILERETENTIONORDER_FIRST_MONTH_LICENSE_FEE,[MobileRetentionOrder].[retrieve_cnt] AS MOBILERETENTIONORDER_RETRIEVE_CNT,[MobileRetentionOrder].[ddate] AS MOBILERETENTIONORDER_DDATE,[MobileRetentionOrder].[s_premium2] AS MOBILERETENTIONORDER_S_PREMIUM2,[MobileRetentionOrder].[monthly_bank_account_id_type] AS MOBILERETENTIONORDER_MONTHLY_BANK_ACCOUNT_ID_TYPE,[MobileRetentionOrder].[card_type] AS MOBILERETENTIONORDER_CARD_TYPE,[MobileRetentionOrder].[next_bill] AS MOBILERETENTIONORDER_NEXT_BILL,[MobileRetentionOrder].[pcd_paid_go_wireless] AS MOBILERETENTIONORDER_PCD_PAID_GO_WIRELESS,[MobileRetentionOrder].[upgrade_rebate_calculation] AS MOBILERETENTIONORDER_UPGRADE_REBATE_CALCULATION,[MobileRetentionOrder].[ext_place_tel] AS MOBILERETENTIONORDER_EXT_PLACE_TEL,[MobileRetentionOrder].[m_3rd_hkid] AS MOBILERETENTIONORDER_M_3RD_HKID,[MobileRetentionOrder].[retention_type] AS MOBILERETENTIONORDER_RETENTION_TYPE,[MobileRetentionOrder].[cooling_date] AS MOBILERETENTIONORDER_COOLING_DATE,[MobileRetentionOrder].[aig_gift] AS MOBILERETENTIONORDER_AIG_GIFT,[MobileRetentionOrder].[cust_staff_no] AS MOBILERETENTIONORDER_CUST_STAFF_NO,[MobileRetentionOrder].[order_id] AS MOBILERETENTIONORDER_ORDER_ID,[MobileRetentionOrder].[family_name] AS MOBILERETENTIONORDER_FAMILY_NAME,[MobileRetentionOrder].[cdate] AS MOBILERETENTIONORDER_CDATE,[MobileRetentionOrder].[status_by_cs_admin] AS MOBILERETENTIONORDER_STATUS_BY_CS_ADMIN,[MobileRetentionOrder].[given_name] AS MOBILERETENTIONORDER_GIVEN_NAME,[MobileRetentionOrder].[vip_case] AS MOBILERETENTIONORDER_VIP_CASE,[MobileRetentionOrder].[org_fee] AS MOBILERETENTIONORDER_ORG_FEE,[MobileRetentionOrder].[s_premium3] AS MOBILERETENTIONORDER_S_PREMIUM3,[MobileRetentionOrder].[log_date] AS MOBILERETENTIONORDER_LOG_DATE,[MobileRetentionOrder].[extn] AS MOBILERETENTIONORDER_EXTN,[MobileRetentionOrder].[d_time] AS MOBILERETENTIONORDER_D_TIME,[MobileRetentionOrder].[bank_name] AS MOBILERETENTIONORDER_BANK_NAME,[MobileRetentionOrder].[delivery_exchange_option] AS MOBILERETENTIONORDER_DELIVERY_EXCHANGE_OPTION,[MobileRetentionOrder].[upgrade_service_account_no] AS MOBILERETENTIONORDER_UPGRADE_SERVICE_ACCOUNT_NO,[MobileRetentionOrder].[old_ord_id] AS MOBILERETENTIONORDER_OLD_ORD_ID,[MobileRetentionOrder].[m_card_no] AS MOBILERETENTIONORDER_M_CARD_NO,[MobileRetentionOrder].[existing_contract_end_date] AS MOBILERETENTIONORDER_EXISTING_CONTRACT_END_DATE,[MobileRetentionOrder].[con_eff_date] AS MOBILERETENTIONORDER_CON_EFF_DATE,[MobileRetentionOrder].[m_3rd_hkid2] AS MOBILERETENTIONORDER_M_3RD_HKID2,[MobileRetentionOrder].[amount] AS MOBILERETENTIONORDER_AMOUNT,[MobileRetentionOrder].[m_3rd_id_type] AS MOBILERETENTIONORDER_M_3RD_ID_TYPE,[MobileRetentionOrder].[id_type] AS MOBILERETENTIONORDER_ID_TYPE,[MobileRetentionOrder].[rate_plan] AS MOBILERETENTIONORDER_RATE_PLAN,[MobileRetentionOrder].[channel] AS MOBILERETENTIONORDER_CHANNEL,[MobileRetentionOrder].[action_eff_date] AS MOBILERETENTIONORDER_ACTION_EFF_DATE,[MobileRetentionOrder].[issue_type] AS MOBILERETENTIONORDER_ISSUE_TYPE,[MobileRetentionOrder].[free_mon] AS MOBILERETENTIONORDER_FREE_MON,[MobileRetentionOrder].[plan_eff_date] AS MOBILERETENTIONORDER_PLAN_EFF_DATE,[MobileRetentionOrder].[teamcode] AS MOBILERETENTIONORDER_TEAMCODE,[MobileRetentionOrder].[bill_medium] AS MOBILERETENTIONORDER_BILL_MEDIUM,[MobileRetentionOrder].[edf_no] AS MOBILERETENTIONORDER_EDF_NO,[MobileRetentionOrder].[ord_place_by] AS MOBILERETENTIONORDER_ORD_PLACE_BY,[MobileRetentionOrder].[cancel_renew] AS MOBILERETENTIONORDER_CANCEL_RENEW,[MobileRetentionOrder].[preferred_languages] AS MOBILERETENTIONORDER_PREFERRED_LANGUAGES,[MobileRetentionOrder].[hkid] AS MOBILERETENTIONORDER_HKID,[MobileRetentionOrder].[card_holder] AS MOBILERETENTIONORDER_CARD_HOLDER,[MobileRetentionOrder].[ac_no] AS MOBILERETENTIONORDER_AC_NO,[MobileRetentionOrder].[bill_cut_num] AS MOBILERETENTIONORDER_BILL_CUT_NUM,[MobileRetentionOrder].[premium] AS MOBILERETENTIONORDER_PREMIUM,[MobileRetentionOrder].[del_remark] AS MOBILERETENTIONORDER_DEL_REMARK,[MobileRetentionOrder].[gift_imei2] AS MOBILERETENTIONORDER_GIFT_IMEI2,[MobileRetentionOrder].[reasons] AS MOBILERETENTIONORDER_REASONS,[MobileRetentionOrder].[language] AS MOBILERETENTIONORDER_LANGUAGE,[MobileRetentionOrder].[rebate_amount] AS MOBILERETENTIONORDER_REBATE_AMOUNT,[MobileRetentionOrder].[ord_place_id_type] AS MOBILERETENTIONORDER_ORD_PLACE_ID_TYPE,[MobileRetentionOrder].[m_3rd_contact_no] AS MOBILERETENTIONORDER_M_3RD_CONTACT_NO,[MobileRetentionOrder].[staff_no] AS MOBILERETENTIONORDER_STAFF_NO,[MobileRetentionOrder].[sp_d_date] AS MOBILERETENTIONORDER_SP_D_DATE,[MobileRetentionOrder].[bundle_name] AS MOBILERETENTIONORDER_BUNDLE_NAME,[MobileRetentionOrder].[accessory_waive] AS MOBILERETENTIONORDER_ACCESSORY_WAIVE,[MobileRetentionOrder].[sim_item_code] AS MOBILERETENTIONORDER_SIM_ITEM_CODE,[MobileRetentionOrder].[cust_type] AS MOBILERETENTIONORDER_CUST_TYPE,[MobileRetentionOrder].[card_ref_no] AS MOBILERETENTIONORDER_CARD_REF_NO  FROM  [MobileRetentionOrder]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[MobileRetentionOrder]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrder]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"MobileRetentionOrder");
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
        
        public bool Insert(string x_sGift_imei,string x_sS_premium4,string x_sGift_desc4,string x_sAccessory_desc,string x_sAction_required,global::System.Nullable<DateTime> x_dVas_eff_date,string x_sMonthly_bank_account_bank_code,string x_sSpecial_handling_dummy_code,string x_sM_card_exp_year,string x_sRemarks2PY,string x_sTrade_field,string x_sOrd_place_tel,string x_sOrd_place_id_type,string x_sCooling_offer,string x_sUpgrade_handset_offer_rebate_schedule,string x_sChange_payment_type,global::System.Nullable<DateTime> x_dDate_of_birth,string x_sContact_person,string x_sExtra_d_charge,string x_sTl_name,global::System.Nullable<bool> x_bFast_start,string x_sSp_ref_no,global::System.Nullable<DateTime> x_dEdate,string x_sExist_cust_plan,string x_sOrd_place_rel,global::System.Nullable<int> x_iMrt_no,string x_sImei_no,string x_sExisting_smart_phone_model,string x_sGift_code3,string x_sBank_code,string x_sPos_ref_no,global::System.Nullable<DateTime> x_dBill_cut_date,string x_sGift_imei3,string x_sExist_plan,global::System.Nullable<bool> x_bWaive,string x_sProgram,string x_sFirst_month_fee,string x_sR_offer,string x_sCid,string x_sDid,string x_sFtg_tenure,string x_sCon_per,string x_sGift_code4,string x_sEasywatch_type,string x_sSms_mrt,string x_sMonthly_payment_method,string x_sRemarks2EDF,string x_sGift_desc3,string x_sGift_imei4,global::System.Nullable<int> x_iOld_ord_id,string x_sMonthly_bank_account_hkid2,global::System.Nullable<DateTime> x_dD_date,string x_sGift_desc,string x_sSalesmancode,string x_sPool,global::System.Nullable<long> x_lCn_mrt_no,string x_sAccessory_imei,string x_sThird_party_credit_card,string x_sCard_ref_no,string x_sSpecial_approval,global::System.Nullable<DateTime> x_dUpgrade_existing_contract_edate,string x_sAccessory_code,string x_sBill_medium,string x_sS_premium,string x_sRef_staff_no,string x_sAccessory_price,string x_sM_card_exp_month,string x_sInstallment_period,string x_sM_card_type,string x_sEasywatch_ord_id,global::System.Nullable<bool> x_bNormal_rebate,string x_sM_rebate_amount,string x_sM_card_holder2,string x_sBill_medium_email,global::System.Nullable<bool> x_bActive,string x_sS_premium1,string x_sCard_exp_month,string x_sOb_program_id,string x_sSku,string x_sRef_salesmancode,string x_sGo_wireless_package_code,string x_sThird_party_hkid,string x_sUpgrade_existing_pccw_customer,string x_sD_address,string x_sUpgrade_registered_mobile_no,string x_sUpgrade_existing_customer_type,string x_sNormal_rebate_type,string x_sGift_desc2,string x_sMonthly_bank_account_branch_code,string x_sRemarks,string x_sAccept,string x_sDelivery_exchange,string x_sGift_code2,global::System.Nullable<bool> x_bPrepayment_waive,string x_sExisting_smart_phone_imei,string x_sCust_name,string x_sCust_type,string x_sUpgrade_sponsorships_amount,global::System.Nullable<bool> x_bBill_medium_waive,string x_sDelivery_exchange_location,global::System.Nullable<int> x_iHs_offer_type_id,string x_sOrg_fee,string x_sRebate,string x_sUpgrade_type,string x_sGo_wireless,string x_sExtra_rebate,string x_sPlan_eff,string x_sExtra_rebate_amount,string x_sCard_exp_year,global::System.Nullable<DateTime> x_dUpgrade_existing_contract_sdate,string x_sOrd_place_hkid,string x_sRegister_address,string x_sGender,string x_sLob_ac,global::System.Nullable<int> x_iSim_mrt_no,string x_sRedemption_notice_option,string x_sDelivery_collection_type,global::System.Nullable<DateTime> x_dAction_date,string x_sThird_party_id_type,string x_sOrg_ftg,string x_sUpgrade_service_tenure,string x_sMonthly_payment_type,string x_sContact_no,global::System.Nullable<int> x_iOrg_mrt,string x_sSim_item_name,string x_sPay_method,string x_sHs_model,string x_sGift_code,string x_sMonthly_bank_account_hkid,string x_sExtra_offer,string x_sMonthly_bank_account_no,string x_sFirst_month_license_fee,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dDdate,string x_sS_premium2,string x_sMonthly_bank_account_id_type,string x_sCard_type,global::System.Nullable<bool> x_bNext_bill,global::System.Nullable<bool> x_bPcd_paid_go_wireless,string x_sUpgrade_rebate_calculation,string x_sExt_place_tel,string x_sM_3rd_hkid,string x_sRetention_type,global::System.Nullable<DateTime> x_dCooling_date,string x_sAig_gift,string x_sCust_staff_no,string x_sFamily_name,global::System.Nullable<DateTime> x_dCdate,string x_sStatus_by_cs_admin,string x_sSim_item_number,string x_sVip_case,string x_sGiven_name,global::System.Nullable<DateTime> x_dLog_date,string x_sExtn,string x_sD_time,string x_sBank_name,string x_sDelivery_exchange_option,string x_sUpgrade_service_account_no,string x_sAction_of_rate_plan_effective,string x_sM_card_no,string x_sExisting_contract_end_date,global::System.Nullable<DateTime> x_dCon_eff_date,string x_sM_3rd_hkid2,string x_sAmount,string x_sId_type,string x_sRate_plan,string x_sChannel,global::System.Nullable<DateTime> x_dAction_eff_date,string x_sIssue_type,string x_sFree_mon,global::System.Nullable<DateTime> x_dPlan_eff_date,string x_sDel_remark,string x_sTeamcode,string x_sStaff_name,string x_sEdf_no,string x_sOrd_place_by,string x_sCancel_renew,string x_sPreferred_languages,string x_sHkid,string x_sCard_no,string x_sAc_no,global::System.Nullable<int> x_iBill_cut_num,string x_sPremium,string x_sM_3rd_id_type,string x_sGift_imei2,string x_sReasons,string x_sLanguage,string x_sRebate_amount,string x_sLob,string x_sM_3rd_contact_no,string x_sStaff_no,string x_sS_premium3,global::System.Nullable<DateTime> x_dSp_d_date,string x_sBundle_name,global::System.Nullable<bool> x_bAccessory_waive,string x_sSim_item_code,string x_sMonthly_bank_account_holder,string x_sCard_holder)
        {
            MobileRetentionOrder _oMobileRetentionOrder=MobileRetentionOrderRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oMobileRetentionOrder.gift_imei=x_sGift_imei;
            _oMobileRetentionOrder.s_premium4=x_sS_premium4;
            _oMobileRetentionOrder.gift_desc4=x_sGift_desc4;
            _oMobileRetentionOrder.accessory_desc=x_sAccessory_desc;
            _oMobileRetentionOrder.action_required=x_sAction_required;
            _oMobileRetentionOrder.vas_eff_date=x_dVas_eff_date;
            _oMobileRetentionOrder.monthly_bank_account_bank_code=x_sMonthly_bank_account_bank_code;
            _oMobileRetentionOrder.special_handling_dummy_code=x_sSpecial_handling_dummy_code;
            _oMobileRetentionOrder.m_card_exp_year=x_sM_card_exp_year;
            _oMobileRetentionOrder.remarks2PY=x_sRemarks2PY;
            _oMobileRetentionOrder.trade_field=x_sTrade_field;
            _oMobileRetentionOrder.ord_place_tel=x_sOrd_place_tel;
            _oMobileRetentionOrder.ord_place_id_type=x_sOrd_place_id_type;
            _oMobileRetentionOrder.cooling_offer=x_sCooling_offer;
            _oMobileRetentionOrder.upgrade_handset_offer_rebate_schedule=x_sUpgrade_handset_offer_rebate_schedule;
            _oMobileRetentionOrder.change_payment_type=x_sChange_payment_type;
            _oMobileRetentionOrder.date_of_birth=x_dDate_of_birth;
            _oMobileRetentionOrder.contact_person=x_sContact_person;
            _oMobileRetentionOrder.extra_d_charge=x_sExtra_d_charge;
            _oMobileRetentionOrder.tl_name=x_sTl_name;
            _oMobileRetentionOrder.fast_start=x_bFast_start;
            _oMobileRetentionOrder.sp_ref_no=x_sSp_ref_no;
            _oMobileRetentionOrder.edate=x_dEdate;
            _oMobileRetentionOrder.exist_cust_plan=x_sExist_cust_plan;
            _oMobileRetentionOrder.ord_place_rel=x_sOrd_place_rel;
            _oMobileRetentionOrder.mrt_no=x_iMrt_no;
            _oMobileRetentionOrder.imei_no=x_sImei_no;
            _oMobileRetentionOrder.existing_smart_phone_model=x_sExisting_smart_phone_model;
            _oMobileRetentionOrder.gift_code3=x_sGift_code3;
            _oMobileRetentionOrder.bank_code=x_sBank_code;
            _oMobileRetentionOrder.pos_ref_no=x_sPos_ref_no;
            _oMobileRetentionOrder.bill_cut_date=x_dBill_cut_date;
            _oMobileRetentionOrder.gift_imei3=x_sGift_imei3;
            _oMobileRetentionOrder.exist_plan=x_sExist_plan;
            _oMobileRetentionOrder.waive=x_bWaive;
            _oMobileRetentionOrder.program=x_sProgram;
            _oMobileRetentionOrder.first_month_fee=x_sFirst_month_fee;
            _oMobileRetentionOrder.r_offer=x_sR_offer;
            _oMobileRetentionOrder.cid=x_sCid;
            _oMobileRetentionOrder.did=x_sDid;
            _oMobileRetentionOrder.ftg_tenure=x_sFtg_tenure;
            _oMobileRetentionOrder.con_per=x_sCon_per;
            _oMobileRetentionOrder.gift_code4=x_sGift_code4;
            _oMobileRetentionOrder.easywatch_type=x_sEasywatch_type;
            _oMobileRetentionOrder.sms_mrt=x_sSms_mrt;
            _oMobileRetentionOrder.monthly_payment_method=x_sMonthly_payment_method;
            _oMobileRetentionOrder.remarks2EDF=x_sRemarks2EDF;
            _oMobileRetentionOrder.gift_desc3=x_sGift_desc3;
            _oMobileRetentionOrder.gift_imei4=x_sGift_imei4;
            _oMobileRetentionOrder.old_ord_id=x_iOld_ord_id;
            _oMobileRetentionOrder.monthly_bank_account_hkid2=x_sMonthly_bank_account_hkid2;
            _oMobileRetentionOrder.d_date=x_dD_date;
            _oMobileRetentionOrder.gift_desc=x_sGift_desc;
            _oMobileRetentionOrder.salesmancode=x_sSalesmancode;
            _oMobileRetentionOrder.pool=x_sPool;
            _oMobileRetentionOrder.cn_mrt_no=x_lCn_mrt_no;
            _oMobileRetentionOrder.accessory_imei=x_sAccessory_imei;
            _oMobileRetentionOrder.third_party_credit_card=x_sThird_party_credit_card;
            _oMobileRetentionOrder.card_ref_no=x_sCard_ref_no;
            _oMobileRetentionOrder.special_approval=x_sSpecial_approval;
            _oMobileRetentionOrder.upgrade_existing_contract_edate=x_dUpgrade_existing_contract_edate;
            _oMobileRetentionOrder.accessory_code=x_sAccessory_code;
            _oMobileRetentionOrder.bill_medium=x_sBill_medium;
            _oMobileRetentionOrder.s_premium=x_sS_premium;
            _oMobileRetentionOrder.ref_staff_no=x_sRef_staff_no;
            _oMobileRetentionOrder.accessory_price=x_sAccessory_price;
            _oMobileRetentionOrder.m_card_exp_month=x_sM_card_exp_month;
            _oMobileRetentionOrder.installment_period=x_sInstallment_period;
            _oMobileRetentionOrder.m_card_type=x_sM_card_type;
            _oMobileRetentionOrder.easywatch_ord_id=x_sEasywatch_ord_id;
            _oMobileRetentionOrder.normal_rebate=x_bNormal_rebate;
            _oMobileRetentionOrder.m_rebate_amount=x_sM_rebate_amount;
            _oMobileRetentionOrder.m_card_holder2=x_sM_card_holder2;
            _oMobileRetentionOrder.bill_medium_email=x_sBill_medium_email;
            _oMobileRetentionOrder.active=x_bActive;
            _oMobileRetentionOrder.s_premium1=x_sS_premium1;
            _oMobileRetentionOrder.card_exp_month=x_sCard_exp_month;
            _oMobileRetentionOrder.ob_program_id=x_sOb_program_id;
            _oMobileRetentionOrder.sku=x_sSku;
            _oMobileRetentionOrder.ref_salesmancode=x_sRef_salesmancode;
            _oMobileRetentionOrder.go_wireless_package_code=x_sGo_wireless_package_code;
            _oMobileRetentionOrder.third_party_hkid=x_sThird_party_hkid;
            _oMobileRetentionOrder.upgrade_existing_pccw_customer=x_sUpgrade_existing_pccw_customer;
            _oMobileRetentionOrder.d_address=x_sD_address;
            _oMobileRetentionOrder.upgrade_registered_mobile_no=x_sUpgrade_registered_mobile_no;
            _oMobileRetentionOrder.upgrade_existing_customer_type=x_sUpgrade_existing_customer_type;
            _oMobileRetentionOrder.normal_rebate_type=x_sNormal_rebate_type;
            _oMobileRetentionOrder.gift_desc2=x_sGift_desc2;
            _oMobileRetentionOrder.monthly_bank_account_branch_code=x_sMonthly_bank_account_branch_code;
            _oMobileRetentionOrder.remarks=x_sRemarks;
            _oMobileRetentionOrder.accept=x_sAccept;
            _oMobileRetentionOrder.delivery_exchange=x_sDelivery_exchange;
            _oMobileRetentionOrder.gift_code2=x_sGift_code2;
            _oMobileRetentionOrder.prepayment_waive=x_bPrepayment_waive;
            _oMobileRetentionOrder.existing_smart_phone_imei=x_sExisting_smart_phone_imei;
            _oMobileRetentionOrder.cust_name=x_sCust_name;
            _oMobileRetentionOrder.cust_type=x_sCust_type;
            _oMobileRetentionOrder.upgrade_sponsorships_amount=x_sUpgrade_sponsorships_amount;
            _oMobileRetentionOrder.bill_medium_waive=x_bBill_medium_waive;
            _oMobileRetentionOrder.delivery_exchange_location=x_sDelivery_exchange_location;
            _oMobileRetentionOrder.hs_offer_type_id=x_iHs_offer_type_id;
            _oMobileRetentionOrder.org_fee=x_sOrg_fee;
            _oMobileRetentionOrder.rebate=x_sRebate;
            _oMobileRetentionOrder.upgrade_type=x_sUpgrade_type;
            _oMobileRetentionOrder.go_wireless=x_sGo_wireless;
            _oMobileRetentionOrder.extra_rebate=x_sExtra_rebate;
            _oMobileRetentionOrder.plan_eff=x_sPlan_eff;
            _oMobileRetentionOrder.extra_rebate_amount=x_sExtra_rebate_amount;
            _oMobileRetentionOrder.card_exp_year=x_sCard_exp_year;
            _oMobileRetentionOrder.upgrade_existing_contract_sdate=x_dUpgrade_existing_contract_sdate;
            _oMobileRetentionOrder.ord_place_hkid=x_sOrd_place_hkid;
            _oMobileRetentionOrder.register_address=x_sRegister_address;
            _oMobileRetentionOrder.gender=x_sGender;
            _oMobileRetentionOrder.lob_ac=x_sLob_ac;
            _oMobileRetentionOrder.sim_mrt_no=x_iSim_mrt_no;
            _oMobileRetentionOrder.redemption_notice_option=x_sRedemption_notice_option;
            _oMobileRetentionOrder.delivery_collection_type=x_sDelivery_collection_type;
            _oMobileRetentionOrder.action_date=x_dAction_date;
            _oMobileRetentionOrder.third_party_id_type=x_sThird_party_id_type;
            _oMobileRetentionOrder.org_ftg=x_sOrg_ftg;
            _oMobileRetentionOrder.upgrade_service_tenure=x_sUpgrade_service_tenure;
            _oMobileRetentionOrder.monthly_payment_type=x_sMonthly_payment_type;
            _oMobileRetentionOrder.contact_no=x_sContact_no;
            _oMobileRetentionOrder.org_mrt=x_iOrg_mrt;
            _oMobileRetentionOrder.sim_item_name=x_sSim_item_name;
            _oMobileRetentionOrder.pay_method=x_sPay_method;
            _oMobileRetentionOrder.hs_model=x_sHs_model;
            _oMobileRetentionOrder.gift_code=x_sGift_code;
            _oMobileRetentionOrder.monthly_bank_account_hkid=x_sMonthly_bank_account_hkid;
            _oMobileRetentionOrder.extra_offer=x_sExtra_offer;
            _oMobileRetentionOrder.monthly_bank_account_no=x_sMonthly_bank_account_no;
            _oMobileRetentionOrder.first_month_license_fee=x_sFirst_month_license_fee;
            _oMobileRetentionOrder.retrieve_cnt=x_iRetrieve_cnt;
            _oMobileRetentionOrder.ddate=x_dDdate;
            _oMobileRetentionOrder.s_premium2=x_sS_premium2;
            _oMobileRetentionOrder.monthly_bank_account_id_type=x_sMonthly_bank_account_id_type;
            _oMobileRetentionOrder.card_type=x_sCard_type;
            _oMobileRetentionOrder.next_bill=x_bNext_bill;
            _oMobileRetentionOrder.pcd_paid_go_wireless=x_bPcd_paid_go_wireless;
            _oMobileRetentionOrder.upgrade_rebate_calculation=x_sUpgrade_rebate_calculation;
            _oMobileRetentionOrder.ext_place_tel=x_sExt_place_tel;
            _oMobileRetentionOrder.m_3rd_hkid=x_sM_3rd_hkid;
            _oMobileRetentionOrder.retention_type=x_sRetention_type;
            _oMobileRetentionOrder.cooling_date=x_dCooling_date;
            _oMobileRetentionOrder.aig_gift=x_sAig_gift;
            _oMobileRetentionOrder.cust_staff_no=x_sCust_staff_no;
            _oMobileRetentionOrder.family_name=x_sFamily_name;
            _oMobileRetentionOrder.cdate=x_dCdate;
            _oMobileRetentionOrder.status_by_cs_admin=x_sStatus_by_cs_admin;
            _oMobileRetentionOrder.sim_item_number=x_sSim_item_number;
            _oMobileRetentionOrder.vip_case=x_sVip_case;
            _oMobileRetentionOrder.given_name=x_sGiven_name;
            _oMobileRetentionOrder.log_date=x_dLog_date;
            _oMobileRetentionOrder.extn=x_sExtn;
            _oMobileRetentionOrder.d_time=x_sD_time;
            _oMobileRetentionOrder.bank_name=x_sBank_name;
            _oMobileRetentionOrder.delivery_exchange_option=x_sDelivery_exchange_option;
            _oMobileRetentionOrder.upgrade_service_account_no=x_sUpgrade_service_account_no;
            _oMobileRetentionOrder.action_of_rate_plan_effective=x_sAction_of_rate_plan_effective;
            _oMobileRetentionOrder.m_card_no=x_sM_card_no;
            _oMobileRetentionOrder.existing_contract_end_date=x_sExisting_contract_end_date;
            _oMobileRetentionOrder.con_eff_date=x_dCon_eff_date;
            _oMobileRetentionOrder.m_3rd_hkid2=x_sM_3rd_hkid2;
            _oMobileRetentionOrder.amount=x_sAmount;
            _oMobileRetentionOrder.id_type=x_sId_type;
            _oMobileRetentionOrder.rate_plan=x_sRate_plan;
            _oMobileRetentionOrder.channel=x_sChannel;
            _oMobileRetentionOrder.action_eff_date=x_dAction_eff_date;
            _oMobileRetentionOrder.issue_type=x_sIssue_type;
            _oMobileRetentionOrder.free_mon=x_sFree_mon;
            _oMobileRetentionOrder.plan_eff_date=x_dPlan_eff_date;
            _oMobileRetentionOrder.del_remark=x_sDel_remark;
            _oMobileRetentionOrder.teamcode=x_sTeamcode;
            _oMobileRetentionOrder.staff_name=x_sStaff_name;
            _oMobileRetentionOrder.edf_no=x_sEdf_no;
            _oMobileRetentionOrder.ord_place_by=x_sOrd_place_by;
            _oMobileRetentionOrder.cancel_renew=x_sCancel_renew;
            _oMobileRetentionOrder.preferred_languages=x_sPreferred_languages;
            _oMobileRetentionOrder.hkid=x_sHkid;
            _oMobileRetentionOrder.card_no=x_sCard_no;
            _oMobileRetentionOrder.ac_no=x_sAc_no;
            _oMobileRetentionOrder.bill_cut_num=x_iBill_cut_num;
            _oMobileRetentionOrder.premium=x_sPremium;
            _oMobileRetentionOrder.m_3rd_id_type=x_sM_3rd_id_type;
            _oMobileRetentionOrder.gift_imei2=x_sGift_imei2;
            _oMobileRetentionOrder.reasons=x_sReasons;
            _oMobileRetentionOrder.language=x_sLanguage;
            _oMobileRetentionOrder.rebate_amount=x_sRebate_amount;
            _oMobileRetentionOrder.lob=x_sLob;
            _oMobileRetentionOrder.m_3rd_contact_no=x_sM_3rd_contact_no;
            _oMobileRetentionOrder.staff_no=x_sStaff_no;
            _oMobileRetentionOrder.s_premium3=x_sS_premium3;
            _oMobileRetentionOrder.sp_d_date=x_dSp_d_date;
            _oMobileRetentionOrder.bundle_name=x_sBundle_name;
            _oMobileRetentionOrder.accessory_waive=x_bAccessory_waive;
            _oMobileRetentionOrder.sim_item_code=x_sSim_item_code;
            _oMobileRetentionOrder.monthly_bank_account_holder=x_sMonthly_bank_account_holder;
            _oMobileRetentionOrder.card_holder=x_sCard_holder;
            return InsertWithOutLastID(n_oDB, _oMobileRetentionOrder);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sGift_imei,string x_sS_premium4,string x_sGift_desc4,string x_sAccessory_desc,string x_sAction_required,global::System.Nullable<DateTime> x_dVas_eff_date,string x_sMonthly_bank_account_bank_code,string x_sSpecial_handling_dummy_code,string x_sM_card_exp_year,string x_sRemarks2PY,string x_sTrade_field,string x_sOrd_place_tel,string x_sOrd_place_id_type,string x_sCooling_offer,string x_sUpgrade_handset_offer_rebate_schedule,string x_sChange_payment_type,global::System.Nullable<DateTime> x_dDate_of_birth,string x_sContact_person,string x_sExtra_d_charge,string x_sTl_name,global::System.Nullable<bool> x_bFast_start,string x_sSp_ref_no,global::System.Nullable<DateTime> x_dEdate,string x_sExist_cust_plan,string x_sOrd_place_rel,global::System.Nullable<int> x_iMrt_no,string x_sImei_no,string x_sExisting_smart_phone_model,string x_sGift_code3,string x_sBank_code,string x_sPos_ref_no,global::System.Nullable<DateTime> x_dBill_cut_date,string x_sGift_imei3,string x_sExist_plan,global::System.Nullable<bool> x_bWaive,string x_sProgram,string x_sFirst_month_fee,string x_sR_offer,string x_sCid,string x_sDid,string x_sFtg_tenure,string x_sCon_per,string x_sGift_code4,string x_sEasywatch_type,string x_sSms_mrt,string x_sMonthly_payment_method,string x_sRemarks2EDF,string x_sGift_desc3,string x_sGift_imei4,global::System.Nullable<int> x_iOld_ord_id,string x_sMonthly_bank_account_hkid2,global::System.Nullable<DateTime> x_dD_date,string x_sGift_desc,string x_sSalesmancode,string x_sPool,global::System.Nullable<long> x_lCn_mrt_no,string x_sAccessory_imei,string x_sThird_party_credit_card,string x_sCard_ref_no,string x_sSpecial_approval,global::System.Nullable<DateTime> x_dUpgrade_existing_contract_edate,string x_sAccessory_code,string x_sBill_medium,string x_sS_premium,string x_sRef_staff_no,string x_sAccessory_price,string x_sM_card_exp_month,string x_sInstallment_period,string x_sM_card_type,string x_sEasywatch_ord_id,global::System.Nullable<bool> x_bNormal_rebate,string x_sM_rebate_amount,string x_sM_card_holder2,string x_sBill_medium_email,global::System.Nullable<bool> x_bActive,string x_sS_premium1,string x_sCard_exp_month,string x_sOb_program_id,string x_sSku,string x_sRef_salesmancode,string x_sGo_wireless_package_code,string x_sThird_party_hkid,string x_sUpgrade_existing_pccw_customer,string x_sD_address,string x_sUpgrade_registered_mobile_no,string x_sUpgrade_existing_customer_type,string x_sNormal_rebate_type,string x_sGift_desc2,string x_sMonthly_bank_account_branch_code,string x_sRemarks,string x_sAccept,string x_sDelivery_exchange,string x_sGift_code2,global::System.Nullable<bool> x_bPrepayment_waive,string x_sExisting_smart_phone_imei,string x_sCust_name,string x_sCust_type,string x_sUpgrade_sponsorships_amount,global::System.Nullable<bool> x_bBill_medium_waive,string x_sDelivery_exchange_location,global::System.Nullable<int> x_iHs_offer_type_id,string x_sOrg_fee,string x_sRebate,string x_sUpgrade_type,string x_sGo_wireless,string x_sExtra_rebate,string x_sPlan_eff,string x_sExtra_rebate_amount,string x_sCard_exp_year,global::System.Nullable<DateTime> x_dUpgrade_existing_contract_sdate,string x_sOrd_place_hkid,string x_sRegister_address,string x_sGender,string x_sLob_ac,global::System.Nullable<int> x_iSim_mrt_no,string x_sRedemption_notice_option,string x_sDelivery_collection_type,global::System.Nullable<DateTime> x_dAction_date,string x_sThird_party_id_type,string x_sOrg_ftg,string x_sUpgrade_service_tenure,string x_sMonthly_payment_type,string x_sContact_no,global::System.Nullable<int> x_iOrg_mrt,string x_sSim_item_name,string x_sPay_method,string x_sHs_model,string x_sGift_code,string x_sMonthly_bank_account_hkid,string x_sExtra_offer,string x_sMonthly_bank_account_no,string x_sFirst_month_license_fee,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dDdate,string x_sS_premium2,string x_sMonthly_bank_account_id_type,string x_sCard_type,global::System.Nullable<bool> x_bNext_bill,global::System.Nullable<bool> x_bPcd_paid_go_wireless,string x_sUpgrade_rebate_calculation,string x_sExt_place_tel,string x_sM_3rd_hkid,string x_sRetention_type,global::System.Nullable<DateTime> x_dCooling_date,string x_sAig_gift,string x_sCust_staff_no,string x_sFamily_name,global::System.Nullable<DateTime> x_dCdate,string x_sStatus_by_cs_admin,string x_sSim_item_number,string x_sVip_case,string x_sGiven_name,global::System.Nullable<DateTime> x_dLog_date,string x_sExtn,string x_sD_time,string x_sBank_name,string x_sDelivery_exchange_option,string x_sUpgrade_service_account_no,string x_sAction_of_rate_plan_effective,string x_sM_card_no,string x_sExisting_contract_end_date,global::System.Nullable<DateTime> x_dCon_eff_date,string x_sM_3rd_hkid2,string x_sAmount,string x_sId_type,string x_sRate_plan,string x_sChannel,global::System.Nullable<DateTime> x_dAction_eff_date,string x_sIssue_type,string x_sFree_mon,global::System.Nullable<DateTime> x_dPlan_eff_date,string x_sDel_remark,string x_sTeamcode,string x_sStaff_name,string x_sEdf_no,string x_sOrd_place_by,string x_sCancel_renew,string x_sPreferred_languages,string x_sHkid,string x_sCard_no,string x_sAc_no,global::System.Nullable<int> x_iBill_cut_num,string x_sPremium,string x_sM_3rd_id_type,string x_sGift_imei2,string x_sReasons,string x_sLanguage,string x_sRebate_amount,string x_sLob,string x_sM_3rd_contact_no,string x_sStaff_no,string x_sS_premium3,global::System.Nullable<DateTime> x_dSp_d_date,string x_sBundle_name,global::System.Nullable<bool> x_bAccessory_waive,string x_sSim_item_code,string x_sMonthly_bank_account_holder,string x_sCard_holder)
        {
            MobileRetentionOrder _oMobileRetentionOrder=MobileRetentionOrderRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileRetentionOrder.gift_imei=x_sGift_imei;
            _oMobileRetentionOrder.s_premium4=x_sS_premium4;
            _oMobileRetentionOrder.gift_desc4=x_sGift_desc4;
            _oMobileRetentionOrder.accessory_desc=x_sAccessory_desc;
            _oMobileRetentionOrder.action_required=x_sAction_required;
            _oMobileRetentionOrder.vas_eff_date=x_dVas_eff_date;
            _oMobileRetentionOrder.monthly_bank_account_bank_code=x_sMonthly_bank_account_bank_code;
            _oMobileRetentionOrder.special_handling_dummy_code=x_sSpecial_handling_dummy_code;
            _oMobileRetentionOrder.m_card_exp_year=x_sM_card_exp_year;
            _oMobileRetentionOrder.remarks2PY=x_sRemarks2PY;
            _oMobileRetentionOrder.trade_field=x_sTrade_field;
            _oMobileRetentionOrder.ord_place_tel=x_sOrd_place_tel;
            _oMobileRetentionOrder.ord_place_id_type=x_sOrd_place_id_type;
            _oMobileRetentionOrder.cooling_offer=x_sCooling_offer;
            _oMobileRetentionOrder.upgrade_handset_offer_rebate_schedule=x_sUpgrade_handset_offer_rebate_schedule;
            _oMobileRetentionOrder.change_payment_type=x_sChange_payment_type;
            _oMobileRetentionOrder.date_of_birth=x_dDate_of_birth;
            _oMobileRetentionOrder.contact_person=x_sContact_person;
            _oMobileRetentionOrder.extra_d_charge=x_sExtra_d_charge;
            _oMobileRetentionOrder.tl_name=x_sTl_name;
            _oMobileRetentionOrder.fast_start=x_bFast_start;
            _oMobileRetentionOrder.sp_ref_no=x_sSp_ref_no;
            _oMobileRetentionOrder.edate=x_dEdate;
            _oMobileRetentionOrder.exist_cust_plan=x_sExist_cust_plan;
            _oMobileRetentionOrder.ord_place_rel=x_sOrd_place_rel;
            _oMobileRetentionOrder.mrt_no=x_iMrt_no;
            _oMobileRetentionOrder.imei_no=x_sImei_no;
            _oMobileRetentionOrder.existing_smart_phone_model=x_sExisting_smart_phone_model;
            _oMobileRetentionOrder.gift_code3=x_sGift_code3;
            _oMobileRetentionOrder.bank_code=x_sBank_code;
            _oMobileRetentionOrder.pos_ref_no=x_sPos_ref_no;
            _oMobileRetentionOrder.bill_cut_date=x_dBill_cut_date;
            _oMobileRetentionOrder.gift_imei3=x_sGift_imei3;
            _oMobileRetentionOrder.exist_plan=x_sExist_plan;
            _oMobileRetentionOrder.waive=x_bWaive;
            _oMobileRetentionOrder.program=x_sProgram;
            _oMobileRetentionOrder.first_month_fee=x_sFirst_month_fee;
            _oMobileRetentionOrder.r_offer=x_sR_offer;
            _oMobileRetentionOrder.cid=x_sCid;
            _oMobileRetentionOrder.did=x_sDid;
            _oMobileRetentionOrder.ftg_tenure=x_sFtg_tenure;
            _oMobileRetentionOrder.con_per=x_sCon_per;
            _oMobileRetentionOrder.gift_code4=x_sGift_code4;
            _oMobileRetentionOrder.easywatch_type=x_sEasywatch_type;
            _oMobileRetentionOrder.sms_mrt=x_sSms_mrt;
            _oMobileRetentionOrder.monthly_payment_method=x_sMonthly_payment_method;
            _oMobileRetentionOrder.remarks2EDF=x_sRemarks2EDF;
            _oMobileRetentionOrder.gift_desc3=x_sGift_desc3;
            _oMobileRetentionOrder.gift_imei4=x_sGift_imei4;
            _oMobileRetentionOrder.old_ord_id=x_iOld_ord_id;
            _oMobileRetentionOrder.monthly_bank_account_hkid2=x_sMonthly_bank_account_hkid2;
            _oMobileRetentionOrder.d_date=x_dD_date;
            _oMobileRetentionOrder.gift_desc=x_sGift_desc;
            _oMobileRetentionOrder.salesmancode=x_sSalesmancode;
            _oMobileRetentionOrder.pool=x_sPool;
            _oMobileRetentionOrder.cn_mrt_no=x_lCn_mrt_no;
            _oMobileRetentionOrder.accessory_imei=x_sAccessory_imei;
            _oMobileRetentionOrder.third_party_credit_card=x_sThird_party_credit_card;
            _oMobileRetentionOrder.card_ref_no=x_sCard_ref_no;
            _oMobileRetentionOrder.special_approval=x_sSpecial_approval;
            _oMobileRetentionOrder.upgrade_existing_contract_edate=x_dUpgrade_existing_contract_edate;
            _oMobileRetentionOrder.accessory_code=x_sAccessory_code;
            _oMobileRetentionOrder.bill_medium=x_sBill_medium;
            _oMobileRetentionOrder.s_premium=x_sS_premium;
            _oMobileRetentionOrder.ref_staff_no=x_sRef_staff_no;
            _oMobileRetentionOrder.accessory_price=x_sAccessory_price;
            _oMobileRetentionOrder.m_card_exp_month=x_sM_card_exp_month;
            _oMobileRetentionOrder.installment_period=x_sInstallment_period;
            _oMobileRetentionOrder.m_card_type=x_sM_card_type;
            _oMobileRetentionOrder.easywatch_ord_id=x_sEasywatch_ord_id;
            _oMobileRetentionOrder.normal_rebate=x_bNormal_rebate;
            _oMobileRetentionOrder.m_rebate_amount=x_sM_rebate_amount;
            _oMobileRetentionOrder.m_card_holder2=x_sM_card_holder2;
            _oMobileRetentionOrder.bill_medium_email=x_sBill_medium_email;
            _oMobileRetentionOrder.active=x_bActive;
            _oMobileRetentionOrder.s_premium1=x_sS_premium1;
            _oMobileRetentionOrder.card_exp_month=x_sCard_exp_month;
            _oMobileRetentionOrder.ob_program_id=x_sOb_program_id;
            _oMobileRetentionOrder.sku=x_sSku;
            _oMobileRetentionOrder.ref_salesmancode=x_sRef_salesmancode;
            _oMobileRetentionOrder.go_wireless_package_code=x_sGo_wireless_package_code;
            _oMobileRetentionOrder.third_party_hkid=x_sThird_party_hkid;
            _oMobileRetentionOrder.upgrade_existing_pccw_customer=x_sUpgrade_existing_pccw_customer;
            _oMobileRetentionOrder.d_address=x_sD_address;
            _oMobileRetentionOrder.upgrade_registered_mobile_no=x_sUpgrade_registered_mobile_no;
            _oMobileRetentionOrder.upgrade_existing_customer_type=x_sUpgrade_existing_customer_type;
            _oMobileRetentionOrder.normal_rebate_type=x_sNormal_rebate_type;
            _oMobileRetentionOrder.gift_desc2=x_sGift_desc2;
            _oMobileRetentionOrder.monthly_bank_account_branch_code=x_sMonthly_bank_account_branch_code;
            _oMobileRetentionOrder.remarks=x_sRemarks;
            _oMobileRetentionOrder.accept=x_sAccept;
            _oMobileRetentionOrder.delivery_exchange=x_sDelivery_exchange;
            _oMobileRetentionOrder.gift_code2=x_sGift_code2;
            _oMobileRetentionOrder.prepayment_waive=x_bPrepayment_waive;
            _oMobileRetentionOrder.existing_smart_phone_imei=x_sExisting_smart_phone_imei;
            _oMobileRetentionOrder.cust_name=x_sCust_name;
            _oMobileRetentionOrder.cust_type=x_sCust_type;
            _oMobileRetentionOrder.upgrade_sponsorships_amount=x_sUpgrade_sponsorships_amount;
            _oMobileRetentionOrder.bill_medium_waive=x_bBill_medium_waive;
            _oMobileRetentionOrder.delivery_exchange_location=x_sDelivery_exchange_location;
            _oMobileRetentionOrder.hs_offer_type_id=x_iHs_offer_type_id;
            _oMobileRetentionOrder.org_fee=x_sOrg_fee;
            _oMobileRetentionOrder.rebate=x_sRebate;
            _oMobileRetentionOrder.upgrade_type=x_sUpgrade_type;
            _oMobileRetentionOrder.go_wireless=x_sGo_wireless;
            _oMobileRetentionOrder.extra_rebate=x_sExtra_rebate;
            _oMobileRetentionOrder.plan_eff=x_sPlan_eff;
            _oMobileRetentionOrder.extra_rebate_amount=x_sExtra_rebate_amount;
            _oMobileRetentionOrder.card_exp_year=x_sCard_exp_year;
            _oMobileRetentionOrder.upgrade_existing_contract_sdate=x_dUpgrade_existing_contract_sdate;
            _oMobileRetentionOrder.ord_place_hkid=x_sOrd_place_hkid;
            _oMobileRetentionOrder.register_address=x_sRegister_address;
            _oMobileRetentionOrder.gender=x_sGender;
            _oMobileRetentionOrder.lob_ac=x_sLob_ac;
            _oMobileRetentionOrder.sim_mrt_no=x_iSim_mrt_no;
            _oMobileRetentionOrder.redemption_notice_option=x_sRedemption_notice_option;
            _oMobileRetentionOrder.delivery_collection_type=x_sDelivery_collection_type;
            _oMobileRetentionOrder.action_date=x_dAction_date;
            _oMobileRetentionOrder.third_party_id_type=x_sThird_party_id_type;
            _oMobileRetentionOrder.org_ftg=x_sOrg_ftg;
            _oMobileRetentionOrder.upgrade_service_tenure=x_sUpgrade_service_tenure;
            _oMobileRetentionOrder.monthly_payment_type=x_sMonthly_payment_type;
            _oMobileRetentionOrder.contact_no=x_sContact_no;
            _oMobileRetentionOrder.org_mrt=x_iOrg_mrt;
            _oMobileRetentionOrder.sim_item_name=x_sSim_item_name;
            _oMobileRetentionOrder.pay_method=x_sPay_method;
            _oMobileRetentionOrder.hs_model=x_sHs_model;
            _oMobileRetentionOrder.gift_code=x_sGift_code;
            _oMobileRetentionOrder.monthly_bank_account_hkid=x_sMonthly_bank_account_hkid;
            _oMobileRetentionOrder.extra_offer=x_sExtra_offer;
            _oMobileRetentionOrder.monthly_bank_account_no=x_sMonthly_bank_account_no;
            _oMobileRetentionOrder.first_month_license_fee=x_sFirst_month_license_fee;
            _oMobileRetentionOrder.retrieve_cnt=x_iRetrieve_cnt;
            _oMobileRetentionOrder.ddate=x_dDdate;
            _oMobileRetentionOrder.s_premium2=x_sS_premium2;
            _oMobileRetentionOrder.monthly_bank_account_id_type=x_sMonthly_bank_account_id_type;
            _oMobileRetentionOrder.card_type=x_sCard_type;
            _oMobileRetentionOrder.next_bill=x_bNext_bill;
            _oMobileRetentionOrder.pcd_paid_go_wireless=x_bPcd_paid_go_wireless;
            _oMobileRetentionOrder.upgrade_rebate_calculation=x_sUpgrade_rebate_calculation;
            _oMobileRetentionOrder.ext_place_tel=x_sExt_place_tel;
            _oMobileRetentionOrder.m_3rd_hkid=x_sM_3rd_hkid;
            _oMobileRetentionOrder.retention_type=x_sRetention_type;
            _oMobileRetentionOrder.cooling_date=x_dCooling_date;
            _oMobileRetentionOrder.aig_gift=x_sAig_gift;
            _oMobileRetentionOrder.cust_staff_no=x_sCust_staff_no;
            _oMobileRetentionOrder.family_name=x_sFamily_name;
            _oMobileRetentionOrder.cdate=x_dCdate;
            _oMobileRetentionOrder.status_by_cs_admin=x_sStatus_by_cs_admin;
            _oMobileRetentionOrder.sim_item_number=x_sSim_item_number;
            _oMobileRetentionOrder.vip_case=x_sVip_case;
            _oMobileRetentionOrder.given_name=x_sGiven_name;
            _oMobileRetentionOrder.log_date=x_dLog_date;
            _oMobileRetentionOrder.extn=x_sExtn;
            _oMobileRetentionOrder.d_time=x_sD_time;
            _oMobileRetentionOrder.bank_name=x_sBank_name;
            _oMobileRetentionOrder.delivery_exchange_option=x_sDelivery_exchange_option;
            _oMobileRetentionOrder.upgrade_service_account_no=x_sUpgrade_service_account_no;
            _oMobileRetentionOrder.action_of_rate_plan_effective=x_sAction_of_rate_plan_effective;
            _oMobileRetentionOrder.m_card_no=x_sM_card_no;
            _oMobileRetentionOrder.existing_contract_end_date=x_sExisting_contract_end_date;
            _oMobileRetentionOrder.con_eff_date=x_dCon_eff_date;
            _oMobileRetentionOrder.m_3rd_hkid2=x_sM_3rd_hkid2;
            _oMobileRetentionOrder.amount=x_sAmount;
            _oMobileRetentionOrder.id_type=x_sId_type;
            _oMobileRetentionOrder.rate_plan=x_sRate_plan;
            _oMobileRetentionOrder.channel=x_sChannel;
            _oMobileRetentionOrder.action_eff_date=x_dAction_eff_date;
            _oMobileRetentionOrder.issue_type=x_sIssue_type;
            _oMobileRetentionOrder.free_mon=x_sFree_mon;
            _oMobileRetentionOrder.plan_eff_date=x_dPlan_eff_date;
            _oMobileRetentionOrder.del_remark=x_sDel_remark;
            _oMobileRetentionOrder.teamcode=x_sTeamcode;
            _oMobileRetentionOrder.staff_name=x_sStaff_name;
            _oMobileRetentionOrder.edf_no=x_sEdf_no;
            _oMobileRetentionOrder.ord_place_by=x_sOrd_place_by;
            _oMobileRetentionOrder.cancel_renew=x_sCancel_renew;
            _oMobileRetentionOrder.preferred_languages=x_sPreferred_languages;
            _oMobileRetentionOrder.hkid=x_sHkid;
            _oMobileRetentionOrder.card_no=x_sCard_no;
            _oMobileRetentionOrder.ac_no=x_sAc_no;
            _oMobileRetentionOrder.bill_cut_num=x_iBill_cut_num;
            _oMobileRetentionOrder.premium=x_sPremium;
            _oMobileRetentionOrder.m_3rd_id_type=x_sM_3rd_id_type;
            _oMobileRetentionOrder.gift_imei2=x_sGift_imei2;
            _oMobileRetentionOrder.reasons=x_sReasons;
            _oMobileRetentionOrder.language=x_sLanguage;
            _oMobileRetentionOrder.rebate_amount=x_sRebate_amount;
            _oMobileRetentionOrder.lob=x_sLob;
            _oMobileRetentionOrder.m_3rd_contact_no=x_sM_3rd_contact_no;
            _oMobileRetentionOrder.staff_no=x_sStaff_no;
            _oMobileRetentionOrder.s_premium3=x_sS_premium3;
            _oMobileRetentionOrder.sp_d_date=x_dSp_d_date;
            _oMobileRetentionOrder.bundle_name=x_sBundle_name;
            _oMobileRetentionOrder.accessory_waive=x_bAccessory_waive;
            _oMobileRetentionOrder.sim_item_code=x_sSim_item_code;
            _oMobileRetentionOrder.monthly_bank_account_holder=x_sMonthly_bank_account_holder;
            _oMobileRetentionOrder.card_holder=x_sCard_holder;
            return InsertWithOutLastID(x_oDB, _oMobileRetentionOrder);
        }
        
        
        public bool Insert(MobileRetentionOrder x_oMobileRetentionOrder)
        {
            return InsertWithOutLastID(n_oDB, x_oMobileRetentionOrder);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is MobileRetentionOrder)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (MobileRetentionOrder)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,MobileRetentionOrder x_oMobileRetentionOrder)
        {
            return InsertWithOutLastID(x_oDB, x_oMobileRetentionOrder);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileRetentionOrder x_oMobileRetentionOrder)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileRetentionOrder]   ([gift_imei],[s_premium4],[upgrade_existing_customer_type],[gift_desc4],[accessory_desc],[staff_name],[action_required],[vas_eff_date],[monthly_bank_account_bank_code],[sim_item_number],[special_handling_dummy_code],[card_no],[m_card_exp_year],[bill_medium_email],[remarks2PY],[trade_field],[ord_place_tel],[action_of_rate_plan_effective],[cooling_offer],[upgrade_handset_offer_rebate_schedule],[change_payment_type],[date_of_birth],[contact_person],[extra_d_charge],[tl_name],[fast_start],[sp_ref_no],[edate],[exist_cust_plan],[ord_place_rel],[mrt_no],[imei_no],[existing_smart_phone_model],[bank_code],[pos_ref_no],[bill_cut_date],[gift_imei3],[exist_plan],[waive],[program],[first_month_fee],[r_offer],[cid],[did],[ftg_tenure],[con_per],[gift_code4],[easywatch_type],[sms_mrt],[monthly_payment_method],[remarks2EDF],[gift_desc3],[gift_imei4],[monthly_bank_account_hkid2],[d_date],[gift_desc],[pool],[cn_mrt_no],[accessory_imei],[third_party_credit_card],[special_approval],[upgrade_existing_contract_edate],[accessory_code],[s_premium],[ref_staff_no],[accessory_price],[m_card_exp_month],[installment_period],[m_card_type],[easywatch_ord_id],[normal_rebate],[m_rebate_amount],[m_card_holder2],[monthly_bank_account_holder],[active],[s_premium1],[card_exp_month],[ob_program_id],[sku],[salesmancode],[go_wireless_package_code],[lob],[ref_salesmancode],[third_party_hkid],[upgrade_existing_pccw_customer],[d_address],[upgrade_registered_mobile_no],[gift_code3],[normal_rebate_type],[gift_desc2],[monthly_bank_account_branch_code],[remarks],[accept],[delivery_exchange],[gift_code2],[prepayment_waive],[existing_smart_phone_imei],[cust_name],[upgrade_sponsorships_amount],[bill_medium_waive],[delivery_exchange_location],[hs_offer_type_id],[extra_rebate_amount],[rebate],[upgrade_type],[go_wireless],[extra_rebate],[plan_eff],[card_exp_year],[upgrade_existing_contract_sdate],[ord_place_hkid],[register_address],[gender],[lob_ac],[sim_mrt_no],[redemption_notice_option],[delivery_collection_type],[action_date],[third_party_id_type],[org_ftg],[upgrade_service_tenure],[monthly_payment_type],[contact_no],[org_mrt],[sim_item_name],[pay_method],[hs_model],[gift_code],[monthly_bank_account_hkid],[extra_offer],[monthly_bank_account_no],[first_month_license_fee],[retrieve_cnt],[ddate],[s_premium2],[monthly_bank_account_id_type],[card_type],[next_bill],[pcd_paid_go_wireless],[upgrade_rebate_calculation],[ext_place_tel],[m_3rd_hkid],[retention_type],[cooling_date],[aig_gift],[cust_staff_no],[family_name],[cdate],[status_by_cs_admin],[given_name],[vip_case],[org_fee],[s_premium3],[log_date],[extn],[d_time],[bank_name],[delivery_exchange_option],[upgrade_service_account_no],[old_ord_id],[m_card_no],[existing_contract_end_date],[con_eff_date],[m_3rd_hkid2],[amount],[m_3rd_id_type],[id_type],[rate_plan],[channel],[action_eff_date],[issue_type],[free_mon],[plan_eff_date],[teamcode],[bill_medium],[edf_no],[ord_place_by],[cancel_renew],[preferred_languages],[hkid],[card_holder],[ac_no],[bill_cut_num],[premium],[del_remark],[gift_imei2],[reasons],[language],[rebate_amount],[ord_place_id_type],[m_3rd_contact_no],[staff_no],[sp_d_date],[bundle_name],[accessory_waive],[sim_item_code],[cust_type],[card_ref_no])  VALUES  (@gift_imei,@s_premium4,@upgrade_existing_customer_type,@gift_desc4,@accessory_desc,@staff_name,@action_required,@vas_eff_date,@monthly_bank_account_bank_code,@sim_item_number,@special_handling_dummy_code,@card_no,@m_card_exp_year,@bill_medium_email,@remarks2PY,@trade_field,@ord_place_tel,@action_of_rate_plan_effective,@cooling_offer,@upgrade_handset_offer_rebate_schedule,@change_payment_type,@date_of_birth,@contact_person,@extra_d_charge,@tl_name,@fast_start,@sp_ref_no,@edate,@exist_cust_plan,@ord_place_rel,@mrt_no,@imei_no,@existing_smart_phone_model,@bank_code,@pos_ref_no,@bill_cut_date,@gift_imei3,@exist_plan,@waive,@program,@first_month_fee,@r_offer,@cid,@did,@ftg_tenure,@con_per,@gift_code4,@easywatch_type,@sms_mrt,@monthly_payment_method,@remarks2EDF,@gift_desc3,@gift_imei4,@monthly_bank_account_hkid2,@d_date,@gift_desc,@pool,@cn_mrt_no,@accessory_imei,@third_party_credit_card,@special_approval,@upgrade_existing_contract_edate,@accessory_code,@s_premium,@ref_staff_no,@accessory_price,@m_card_exp_month,@installment_period,@m_card_type,@easywatch_ord_id,@normal_rebate,@m_rebate_amount,@m_card_holder2,@monthly_bank_account_holder,@active,@s_premium1,@card_exp_month,@ob_program_id,@sku,@salesmancode,@go_wireless_package_code,@lob,@ref_salesmancode,@third_party_hkid,@upgrade_existing_pccw_customer,@d_address,@upgrade_registered_mobile_no,@gift_code3,@normal_rebate_type,@gift_desc2,@monthly_bank_account_branch_code,@remarks,@accept,@delivery_exchange,@gift_code2,@prepayment_waive,@existing_smart_phone_imei,@cust_name,@upgrade_sponsorships_amount,@bill_medium_waive,@delivery_exchange_location,@hs_offer_type_id,@extra_rebate_amount,@rebate,@upgrade_type,@go_wireless,@extra_rebate,@plan_eff,@card_exp_year,@upgrade_existing_contract_sdate,@ord_place_hkid,@register_address,@gender,@lob_ac,@sim_mrt_no,@redemption_notice_option,@delivery_collection_type,@action_date,@third_party_id_type,@org_ftg,@upgrade_service_tenure,@monthly_payment_type,@contact_no,@org_mrt,@sim_item_name,@pay_method,@hs_model,@gift_code,@monthly_bank_account_hkid,@extra_offer,@monthly_bank_account_no,@first_month_license_fee,@retrieve_cnt,@ddate,@s_premium2,@monthly_bank_account_id_type,@card_type,@next_bill,@pcd_paid_go_wireless,@upgrade_rebate_calculation,@ext_place_tel,@m_3rd_hkid,@retention_type,@cooling_date,@aig_gift,@cust_staff_no,@family_name,@cdate,@status_by_cs_admin,@given_name,@vip_case,@org_fee,@s_premium3,@log_date,@extn,@d_time,@bank_name,@delivery_exchange_option,@upgrade_service_account_no,@old_ord_id,@m_card_no,@existing_contract_end_date,@con_eff_date,@m_3rd_hkid2,@amount,@m_3rd_id_type,@id_type,@rate_plan,@channel,@action_eff_date,@issue_type,@free_mon,@plan_eff_date,@teamcode,@bill_medium,@edf_no,@ord_place_by,@cancel_renew,@preferred_languages,@hkid,@card_holder,@ac_no,@bill_cut_num,@premium,@del_remark,@gift_imei2,@reasons,@language,@rebate_amount,@ord_place_id_type,@m_3rd_contact_no,@staff_no,@sp_d_date,@bundle_name,@accessory_waive,@sim_item_code,@cust_type,@card_ref_no)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionOrder]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrder]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oMobileRetentionOrder);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileRetentionOrder x_oMobileRetentionOrder)
        {
            bool _bResult = false;
            if (!x_oMobileRetentionOrder.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileRetentionOrder.gift_imei==null){  x_oCmd.Parameters.Add("@gift_imei", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_imei", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.gift_imei; }
                if(x_oMobileRetentionOrder.s_premium4==null){  x_oCmd.Parameters.Add("@s_premium4", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@s_premium4", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.s_premium4; }
                if(x_oMobileRetentionOrder.upgrade_existing_customer_type==null){  x_oCmd.Parameters.Add("@upgrade_existing_customer_type", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_existing_customer_type", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.upgrade_existing_customer_type; }
                if(x_oMobileRetentionOrder.gift_desc4==null){  x_oCmd.Parameters.Add("@gift_desc4", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_desc4", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.gift_desc4; }
                if(x_oMobileRetentionOrder.accessory_desc==null){  x_oCmd.Parameters.Add("@accessory_desc", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@accessory_desc", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.accessory_desc; }
                if(x_oMobileRetentionOrder.staff_name==null){  x_oCmd.Parameters.Add("@staff_name", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@staff_name", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.staff_name; }
                if(x_oMobileRetentionOrder.action_required==null){  x_oCmd.Parameters.Add("@action_required", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@action_required", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.action_required; }
                if(x_oMobileRetentionOrder.vas_eff_date==null){  x_oCmd.Parameters.Add("@vas_eff_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@vas_eff_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrder.vas_eff_date; }
                if(x_oMobileRetentionOrder.monthly_bank_account_bank_code==null){  x_oCmd.Parameters.Add("@monthly_bank_account_bank_code", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_bank_account_bank_code", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.monthly_bank_account_bank_code; }
                if(x_oMobileRetentionOrder.sim_item_number==null){  x_oCmd.Parameters.Add("@sim_item_number", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sim_item_number", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.sim_item_number; }
                if(x_oMobileRetentionOrder.special_handling_dummy_code==null){  x_oCmd.Parameters.Add("@special_handling_dummy_code", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@special_handling_dummy_code", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.special_handling_dummy_code; }
                if(x_oMobileRetentionOrder.card_no==null){  x_oCmd.Parameters.Add("@card_no", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@card_no", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionOrder.card_no; }
                if(x_oMobileRetentionOrder.m_card_exp_year==null){  x_oCmd.Parameters.Add("@m_card_exp_year", global::System.Data.SqlDbType.NVarChar,4).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_card_exp_year", global::System.Data.SqlDbType.NVarChar,4).Value=x_oMobileRetentionOrder.m_card_exp_year; }
                if(x_oMobileRetentionOrder.bill_medium_email==null){  x_oCmd.Parameters.Add("@bill_medium_email", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bill_medium_email", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.bill_medium_email; }
                if(x_oMobileRetentionOrder.remarks2PY==null){  x_oCmd.Parameters.Add("@remarks2PY", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@remarks2PY", global::System.Data.SqlDbType.Text).Value=x_oMobileRetentionOrder.remarks2PY; }
                if(x_oMobileRetentionOrder.trade_field==null){  x_oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.trade_field; }
                if(x_oMobileRetentionOrder.ord_place_tel==null){  x_oCmd.Parameters.Add("@ord_place_tel", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ord_place_tel", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.ord_place_tel; }
                if(x_oMobileRetentionOrder.action_of_rate_plan_effective==null){  x_oCmd.Parameters.Add("@action_of_rate_plan_effective", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@action_of_rate_plan_effective", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.action_of_rate_plan_effective; }
                if(x_oMobileRetentionOrder.cooling_offer==null){  x_oCmd.Parameters.Add("@cooling_offer", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cooling_offer", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.cooling_offer; }
                if(x_oMobileRetentionOrder.upgrade_handset_offer_rebate_schedule==null){  x_oCmd.Parameters.Add("@upgrade_handset_offer_rebate_schedule", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_handset_offer_rebate_schedule", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.upgrade_handset_offer_rebate_schedule; }
                if(x_oMobileRetentionOrder.change_payment_type==null){  x_oCmd.Parameters.Add("@change_payment_type", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@change_payment_type", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionOrder.change_payment_type; }
                if(x_oMobileRetentionOrder.date_of_birth==null){  x_oCmd.Parameters.Add("@date_of_birth", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@date_of_birth", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrder.date_of_birth; }
                if(x_oMobileRetentionOrder.contact_person==null){  x_oCmd.Parameters.Add("@contact_person", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@contact_person", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.contact_person; }
                if(x_oMobileRetentionOrder.extra_d_charge==null){  x_oCmd.Parameters.Add("@extra_d_charge", global::System.Data.SqlDbType.NVarChar,5).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@extra_d_charge", global::System.Data.SqlDbType.NVarChar,5).Value=x_oMobileRetentionOrder.extra_d_charge; }
                if(x_oMobileRetentionOrder.tl_name==null){  x_oCmd.Parameters.Add("@tl_name", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@tl_name", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.tl_name; }
                if(x_oMobileRetentionOrder.fast_start==null){  x_oCmd.Parameters.Add("@fast_start", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fast_start", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionOrder.fast_start; }
                if(x_oMobileRetentionOrder.sp_ref_no==null){  x_oCmd.Parameters.Add("@sp_ref_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sp_ref_no", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.sp_ref_no; }
                if(x_oMobileRetentionOrder.edate==null){  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrder.edate; }
                if(x_oMobileRetentionOrder.exist_cust_plan==null){  x_oCmd.Parameters.Add("@exist_cust_plan", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@exist_cust_plan", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.exist_cust_plan; }
                if(x_oMobileRetentionOrder.ord_place_rel==null){  x_oCmd.Parameters.Add("@ord_place_rel", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ord_place_rel", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.ord_place_rel; }
                if(x_oMobileRetentionOrder.mrt_no==null){  x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.Int).Value=x_oMobileRetentionOrder.mrt_no; }
                if(x_oMobileRetentionOrder.imei_no==null){  x_oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionOrder.imei_no; }
                if(x_oMobileRetentionOrder.existing_smart_phone_model==null){  x_oCmd.Parameters.Add("@existing_smart_phone_model", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@existing_smart_phone_model", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.existing_smart_phone_model; }
                if(x_oMobileRetentionOrder.bank_code==null){  x_oCmd.Parameters.Add("@bank_code", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bank_code", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionOrder.bank_code; }
                if(x_oMobileRetentionOrder.pos_ref_no==null){  x_oCmd.Parameters.Add("@pos_ref_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@pos_ref_no", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.pos_ref_no; }
                if(x_oMobileRetentionOrder.bill_cut_date==null){  x_oCmd.Parameters.Add("@bill_cut_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@bill_cut_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrder.bill_cut_date; }
                if(x_oMobileRetentionOrder.gift_imei3==null){  x_oCmd.Parameters.Add("@gift_imei3", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_imei3", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.gift_imei3; }
                if(x_oMobileRetentionOrder.exist_plan==null){  x_oCmd.Parameters.Add("@exist_plan", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@exist_plan", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.exist_plan; }
                if(x_oMobileRetentionOrder.waive==null){  x_oCmd.Parameters.Add("@waive", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@waive", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionOrder.waive; }
                if(x_oMobileRetentionOrder.program==null){  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.program; }
                if(x_oMobileRetentionOrder.first_month_fee==null){  x_oCmd.Parameters.Add("@first_month_fee", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@first_month_fee", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.first_month_fee; }
                if(x_oMobileRetentionOrder.r_offer==null){  x_oCmd.Parameters.Add("@r_offer", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@r_offer", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.r_offer; }
                if(x_oMobileRetentionOrder.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.cid; }
                if(x_oMobileRetentionOrder.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.did; }
                if(x_oMobileRetentionOrder.ftg_tenure==null){  x_oCmd.Parameters.Add("@ftg_tenure", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ftg_tenure", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.ftg_tenure; }
                if(x_oMobileRetentionOrder.con_per==null){  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.con_per; }
                if(x_oMobileRetentionOrder.gift_code4==null){  x_oCmd.Parameters.Add("@gift_code4", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_code4", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.gift_code4; }
                if(x_oMobileRetentionOrder.easywatch_type==null){  x_oCmd.Parameters.Add("@easywatch_type", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@easywatch_type", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionOrder.easywatch_type; }
                if(x_oMobileRetentionOrder.sms_mrt==null){  x_oCmd.Parameters.Add("@sms_mrt", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sms_mrt", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.sms_mrt; }
                if(x_oMobileRetentionOrder.monthly_payment_method==null){  x_oCmd.Parameters.Add("@monthly_payment_method", global::System.Data.SqlDbType.NVarChar,40).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_payment_method", global::System.Data.SqlDbType.NVarChar,40).Value=x_oMobileRetentionOrder.monthly_payment_method; }
                if(x_oMobileRetentionOrder.remarks2EDF==null){  x_oCmd.Parameters.Add("@remarks2EDF", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@remarks2EDF", global::System.Data.SqlDbType.Text).Value=x_oMobileRetentionOrder.remarks2EDF; }
                if(x_oMobileRetentionOrder.gift_desc3==null){  x_oCmd.Parameters.Add("@gift_desc3", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_desc3", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.gift_desc3; }
                if(x_oMobileRetentionOrder.gift_imei4==null){  x_oCmd.Parameters.Add("@gift_imei4", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_imei4", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.gift_imei4; }
                if(x_oMobileRetentionOrder.monthly_bank_account_hkid2==null){  x_oCmd.Parameters.Add("@monthly_bank_account_hkid2", global::System.Data.SqlDbType.NVarChar,1).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_bank_account_hkid2", global::System.Data.SqlDbType.NVarChar,1).Value=x_oMobileRetentionOrder.monthly_bank_account_hkid2; }
                if(x_oMobileRetentionOrder.d_date==null){  x_oCmd.Parameters.Add("@d_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@d_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrder.d_date; }
                if(x_oMobileRetentionOrder.gift_desc==null){  x_oCmd.Parameters.Add("@gift_desc", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_desc", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.gift_desc; }
                if(x_oMobileRetentionOrder.pool==null){  x_oCmd.Parameters.Add("@pool", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@pool", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.pool; }
                if(x_oMobileRetentionOrder.cn_mrt_no==null){  x_oCmd.Parameters.Add("@cn_mrt_no", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cn_mrt_no", global::System.Data.SqlDbType.BigInt).Value=x_oMobileRetentionOrder.cn_mrt_no; }
                if(x_oMobileRetentionOrder.accessory_imei==null){  x_oCmd.Parameters.Add("@accessory_imei", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@accessory_imei", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.accessory_imei; }
                if(x_oMobileRetentionOrder.third_party_credit_card==null){  x_oCmd.Parameters.Add("@third_party_credit_card", global::System.Data.SqlDbType.NVarChar,5).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@third_party_credit_card", global::System.Data.SqlDbType.NVarChar,5).Value=x_oMobileRetentionOrder.third_party_credit_card; }
                if(x_oMobileRetentionOrder.special_approval==null){  x_oCmd.Parameters.Add("@special_approval", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@special_approval", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionOrder.special_approval; }
                if(x_oMobileRetentionOrder.upgrade_existing_contract_edate==null){  x_oCmd.Parameters.Add("@upgrade_existing_contract_edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@upgrade_existing_contract_edate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrder.upgrade_existing_contract_edate; }
                if(x_oMobileRetentionOrder.accessory_code==null){  x_oCmd.Parameters.Add("@accessory_code", global::System.Data.SqlDbType.NVarChar,70).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@accessory_code", global::System.Data.SqlDbType.NVarChar,70).Value=x_oMobileRetentionOrder.accessory_code; }
                if(x_oMobileRetentionOrder.s_premium==null){  x_oCmd.Parameters.Add("@s_premium", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@s_premium", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.s_premium; }
                if(x_oMobileRetentionOrder.ref_staff_no==null){  x_oCmd.Parameters.Add("@ref_staff_no", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ref_staff_no", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionOrder.ref_staff_no; }
                if(x_oMobileRetentionOrder.accessory_price==null){  x_oCmd.Parameters.Add("@accessory_price", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@accessory_price", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.accessory_price; }
                if(x_oMobileRetentionOrder.m_card_exp_month==null){  x_oCmd.Parameters.Add("@m_card_exp_month", global::System.Data.SqlDbType.NVarChar,2).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_card_exp_month", global::System.Data.SqlDbType.NVarChar,2).Value=x_oMobileRetentionOrder.m_card_exp_month; }
                if(x_oMobileRetentionOrder.installment_period==null){  x_oCmd.Parameters.Add("@installment_period", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@installment_period", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.installment_period; }
                if(x_oMobileRetentionOrder.m_card_type==null){  x_oCmd.Parameters.Add("@m_card_type", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_card_type", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionOrder.m_card_type; }
                if(x_oMobileRetentionOrder.easywatch_ord_id==null){  x_oCmd.Parameters.Add("@easywatch_ord_id", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@easywatch_ord_id", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.easywatch_ord_id; }
                if(x_oMobileRetentionOrder.normal_rebate==null){  x_oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionOrder.normal_rebate; }
                if(x_oMobileRetentionOrder.m_rebate_amount==null){  x_oCmd.Parameters.Add("@m_rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.m_rebate_amount; }
                if(x_oMobileRetentionOrder.m_card_holder2==null){  x_oCmd.Parameters.Add("@m_card_holder2", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_card_holder2", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.m_card_holder2; }
                if(x_oMobileRetentionOrder.monthly_bank_account_holder==null){  x_oCmd.Parameters.Add("@monthly_bank_account_holder", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_bank_account_holder", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.monthly_bank_account_holder; }
                if(x_oMobileRetentionOrder.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionOrder.active; }
                if(x_oMobileRetentionOrder.s_premium1==null){  x_oCmd.Parameters.Add("@s_premium1", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@s_premium1", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.s_premium1; }
                if(x_oMobileRetentionOrder.card_exp_month==null){  x_oCmd.Parameters.Add("@card_exp_month", global::System.Data.SqlDbType.NVarChar,2).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@card_exp_month", global::System.Data.SqlDbType.NVarChar,2).Value=x_oMobileRetentionOrder.card_exp_month; }
                if(x_oMobileRetentionOrder.ob_program_id==null){  x_oCmd.Parameters.Add("@ob_program_id", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ob_program_id", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionOrder.ob_program_id; }
                if(x_oMobileRetentionOrder.sku==null){  x_oCmd.Parameters.Add("@sku", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sku", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.sku; }
                if(x_oMobileRetentionOrder.salesmancode==null){  x_oCmd.Parameters.Add("@salesmancode", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@salesmancode", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.salesmancode; }
                if(x_oMobileRetentionOrder.go_wireless_package_code==null){  x_oCmd.Parameters.Add("@go_wireless_package_code", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@go_wireless_package_code", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.go_wireless_package_code; }
                if(x_oMobileRetentionOrder.lob==null){  x_oCmd.Parameters.Add("@lob", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@lob", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.lob; }
                if(x_oMobileRetentionOrder.ref_salesmancode==null){  x_oCmd.Parameters.Add("@ref_salesmancode", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ref_salesmancode", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionOrder.ref_salesmancode; }
                if(x_oMobileRetentionOrder.third_party_hkid==null){  x_oCmd.Parameters.Add("@third_party_hkid", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@third_party_hkid", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionOrder.third_party_hkid; }
                if(x_oMobileRetentionOrder.upgrade_existing_pccw_customer==null){  x_oCmd.Parameters.Add("@upgrade_existing_pccw_customer", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_existing_pccw_customer", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.upgrade_existing_pccw_customer; }
                if(x_oMobileRetentionOrder.d_address==null){  x_oCmd.Parameters.Add("@d_address", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_address", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.d_address; }
                if(x_oMobileRetentionOrder.upgrade_registered_mobile_no==null){  x_oCmd.Parameters.Add("@upgrade_registered_mobile_no", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_registered_mobile_no", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.upgrade_registered_mobile_no; }
                if(x_oMobileRetentionOrder.gift_code3==null){  x_oCmd.Parameters.Add("@gift_code3", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_code3", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.gift_code3; }
                if(x_oMobileRetentionOrder.normal_rebate_type==null){  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.normal_rebate_type; }
                if(x_oMobileRetentionOrder.gift_desc2==null){  x_oCmd.Parameters.Add("@gift_desc2", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_desc2", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.gift_desc2; }
                if(x_oMobileRetentionOrder.monthly_bank_account_branch_code==null){  x_oCmd.Parameters.Add("@monthly_bank_account_branch_code", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_bank_account_branch_code", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.monthly_bank_account_branch_code; }
                if(x_oMobileRetentionOrder.remarks==null){  x_oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.Text).Value=x_oMobileRetentionOrder.remarks; }
                if(x_oMobileRetentionOrder.accept==null){  x_oCmd.Parameters.Add("@accept", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@accept", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.accept; }
                if(x_oMobileRetentionOrder.delivery_exchange==null){  x_oCmd.Parameters.Add("@delivery_exchange", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@delivery_exchange", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.delivery_exchange; }
                if(x_oMobileRetentionOrder.gift_code2==null){  x_oCmd.Parameters.Add("@gift_code2", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_code2", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.gift_code2; }
                if(x_oMobileRetentionOrder.prepayment_waive==null){  x_oCmd.Parameters.Add("@prepayment_waive", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@prepayment_waive", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionOrder.prepayment_waive; }
                if(x_oMobileRetentionOrder.existing_smart_phone_imei==null){  x_oCmd.Parameters.Add("@existing_smart_phone_imei", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@existing_smart_phone_imei", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.existing_smart_phone_imei; }
                if(x_oMobileRetentionOrder.cust_name==null){  x_oCmd.Parameters.Add("@cust_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cust_name", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.cust_name; }
                if(x_oMobileRetentionOrder.upgrade_sponsorships_amount==null){  x_oCmd.Parameters.Add("@upgrade_sponsorships_amount", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_sponsorships_amount", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.upgrade_sponsorships_amount; }
                if(x_oMobileRetentionOrder.bill_medium_waive==null){  x_oCmd.Parameters.Add("@bill_medium_waive", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bill_medium_waive", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionOrder.bill_medium_waive; }
                if(x_oMobileRetentionOrder.delivery_exchange_location==null){  x_oCmd.Parameters.Add("@delivery_exchange_location", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@delivery_exchange_location", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.delivery_exchange_location; }
                if(x_oMobileRetentionOrder.hs_offer_type_id==null){  x_oCmd.Parameters.Add("@hs_offer_type_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hs_offer_type_id", global::System.Data.SqlDbType.Int).Value=x_oMobileRetentionOrder.hs_offer_type_id; }
                if(x_oMobileRetentionOrder.extra_rebate_amount==null){  x_oCmd.Parameters.Add("@extra_rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@extra_rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.extra_rebate_amount; }
                if(x_oMobileRetentionOrder.rebate==null){  x_oCmd.Parameters.Add("@rebate", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rebate", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionOrder.rebate; }
                if(x_oMobileRetentionOrder.upgrade_type==null){  x_oCmd.Parameters.Add("@upgrade_type", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_type", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.upgrade_type; }
                if(x_oMobileRetentionOrder.go_wireless==null){  x_oCmd.Parameters.Add("@go_wireless", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@go_wireless", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.go_wireless; }
                if(x_oMobileRetentionOrder.extra_rebate==null){  x_oCmd.Parameters.Add("@extra_rebate", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@extra_rebate", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.extra_rebate; }
                if(x_oMobileRetentionOrder.plan_eff==null){  x_oCmd.Parameters.Add("@plan_eff", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@plan_eff", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionOrder.plan_eff; }
                if(x_oMobileRetentionOrder.card_exp_year==null){  x_oCmd.Parameters.Add("@card_exp_year", global::System.Data.SqlDbType.NVarChar,4).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@card_exp_year", global::System.Data.SqlDbType.NVarChar,4).Value=x_oMobileRetentionOrder.card_exp_year; }
                if(x_oMobileRetentionOrder.upgrade_existing_contract_sdate==null){  x_oCmd.Parameters.Add("@upgrade_existing_contract_sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@upgrade_existing_contract_sdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrder.upgrade_existing_contract_sdate; }
                if(x_oMobileRetentionOrder.ord_place_hkid==null){  x_oCmd.Parameters.Add("@ord_place_hkid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ord_place_hkid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.ord_place_hkid; }
                if(x_oMobileRetentionOrder.register_address==null){  x_oCmd.Parameters.Add("@register_address", global::System.Data.SqlDbType.NVarChar,200).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@register_address", global::System.Data.SqlDbType.NVarChar,200).Value=x_oMobileRetentionOrder.register_address; }
                if(x_oMobileRetentionOrder.gender==null){  x_oCmd.Parameters.Add("@gender", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gender", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.gender; }
                if(x_oMobileRetentionOrder.lob_ac==null){  x_oCmd.Parameters.Add("@lob_ac", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@lob_ac", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionOrder.lob_ac; }
                if(x_oMobileRetentionOrder.sim_mrt_no==null){  x_oCmd.Parameters.Add("@sim_mrt_no", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sim_mrt_no", global::System.Data.SqlDbType.Int).Value=x_oMobileRetentionOrder.sim_mrt_no; }
                if(x_oMobileRetentionOrder.redemption_notice_option==null){  x_oCmd.Parameters.Add("@redemption_notice_option", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@redemption_notice_option", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.redemption_notice_option; }
                if(x_oMobileRetentionOrder.delivery_collection_type==null){  x_oCmd.Parameters.Add("@delivery_collection_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@delivery_collection_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.delivery_collection_type; }
                if(x_oMobileRetentionOrder.action_date==null){  x_oCmd.Parameters.Add("@action_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@action_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrder.action_date; }
                if(x_oMobileRetentionOrder.third_party_id_type==null){  x_oCmd.Parameters.Add("@third_party_id_type", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@third_party_id_type", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionOrder.third_party_id_type; }
                if(x_oMobileRetentionOrder.org_ftg==null){  x_oCmd.Parameters.Add("@org_ftg", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@org_ftg", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.org_ftg; }
                if(x_oMobileRetentionOrder.upgrade_service_tenure==null){  x_oCmd.Parameters.Add("@upgrade_service_tenure", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_service_tenure", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.upgrade_service_tenure; }
                if(x_oMobileRetentionOrder.monthly_payment_type==null){  x_oCmd.Parameters.Add("@monthly_payment_type", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_payment_type", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.monthly_payment_type; }
                if(x_oMobileRetentionOrder.contact_no==null){  x_oCmd.Parameters.Add("@contact_no", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@contact_no", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionOrder.contact_no; }
                if(x_oMobileRetentionOrder.org_mrt==null){  x_oCmd.Parameters.Add("@org_mrt", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@org_mrt", global::System.Data.SqlDbType.Int).Value=x_oMobileRetentionOrder.org_mrt; }
                if(x_oMobileRetentionOrder.sim_item_name==null){  x_oCmd.Parameters.Add("@sim_item_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sim_item_name", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.sim_item_name; }
                if(x_oMobileRetentionOrder.pay_method==null){  x_oCmd.Parameters.Add("@pay_method", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@pay_method", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.pay_method; }
                if(x_oMobileRetentionOrder.hs_model==null){  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.hs_model; }
                if(x_oMobileRetentionOrder.gift_code==null){  x_oCmd.Parameters.Add("@gift_code", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_code", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.gift_code; }
                if(x_oMobileRetentionOrder.monthly_bank_account_hkid==null){  x_oCmd.Parameters.Add("@monthly_bank_account_hkid", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_bank_account_hkid", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionOrder.monthly_bank_account_hkid; }
                if(x_oMobileRetentionOrder.extra_offer==null){  x_oCmd.Parameters.Add("@extra_offer", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@extra_offer", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.extra_offer; }
                if(x_oMobileRetentionOrder.monthly_bank_account_no==null){  x_oCmd.Parameters.Add("@monthly_bank_account_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_bank_account_no", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.monthly_bank_account_no; }
                if(x_oMobileRetentionOrder.first_month_license_fee==null){  x_oCmd.Parameters.Add("@first_month_license_fee", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@first_month_license_fee", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.first_month_license_fee; }
                if(x_oMobileRetentionOrder.retrieve_cnt==null){  x_oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int).Value=x_oMobileRetentionOrder.retrieve_cnt; }
                if(x_oMobileRetentionOrder.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrder.ddate; }
                if(x_oMobileRetentionOrder.s_premium2==null){  x_oCmd.Parameters.Add("@s_premium2", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@s_premium2", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.s_premium2; }
                if(x_oMobileRetentionOrder.monthly_bank_account_id_type==null){  x_oCmd.Parameters.Add("@monthly_bank_account_id_type", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_bank_account_id_type", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.monthly_bank_account_id_type; }
                if(x_oMobileRetentionOrder.card_type==null){  x_oCmd.Parameters.Add("@card_type", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@card_type", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionOrder.card_type; }
                if(x_oMobileRetentionOrder.next_bill==null){  x_oCmd.Parameters.Add("@next_bill", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@next_bill", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionOrder.next_bill; }
                if(x_oMobileRetentionOrder.pcd_paid_go_wireless==null){  x_oCmd.Parameters.Add("@pcd_paid_go_wireless", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@pcd_paid_go_wireless", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionOrder.pcd_paid_go_wireless; }
                if(x_oMobileRetentionOrder.upgrade_rebate_calculation==null){  x_oCmd.Parameters.Add("@upgrade_rebate_calculation", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_rebate_calculation", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.upgrade_rebate_calculation; }
                if(x_oMobileRetentionOrder.ext_place_tel==null){  x_oCmd.Parameters.Add("@ext_place_tel", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ext_place_tel", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.ext_place_tel; }
                if(x_oMobileRetentionOrder.m_3rd_hkid==null){  x_oCmd.Parameters.Add("@m_3rd_hkid", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_3rd_hkid", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionOrder.m_3rd_hkid; }
                if(x_oMobileRetentionOrder.retention_type==null){  x_oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.retention_type; }
                if(x_oMobileRetentionOrder.cooling_date==null){  x_oCmd.Parameters.Add("@cooling_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cooling_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrder.cooling_date; }
                if(x_oMobileRetentionOrder.aig_gift==null){  x_oCmd.Parameters.Add("@aig_gift", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@aig_gift", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.aig_gift; }
                if(x_oMobileRetentionOrder.cust_staff_no==null){  x_oCmd.Parameters.Add("@cust_staff_no", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cust_staff_no", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.cust_staff_no; }
                if(x_oMobileRetentionOrder.family_name==null){  x_oCmd.Parameters.Add("@family_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@family_name", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.family_name; }
                if(x_oMobileRetentionOrder.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrder.cdate; }
                if(x_oMobileRetentionOrder.status_by_cs_admin==null){  x_oCmd.Parameters.Add("@status_by_cs_admin", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@status_by_cs_admin", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.status_by_cs_admin; }
                if(x_oMobileRetentionOrder.given_name==null){  x_oCmd.Parameters.Add("@given_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@given_name", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.given_name; }
                if(x_oMobileRetentionOrder.vip_case==null){  x_oCmd.Parameters.Add("@vip_case", global::System.Data.SqlDbType.NVarChar,200).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@vip_case", global::System.Data.SqlDbType.NVarChar,200).Value=x_oMobileRetentionOrder.vip_case; }
                if(x_oMobileRetentionOrder.org_fee==null){  x_oCmd.Parameters.Add("@org_fee", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@org_fee", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.org_fee; }
                if(x_oMobileRetentionOrder.s_premium3==null){  x_oCmd.Parameters.Add("@s_premium3", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@s_premium3", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.s_premium3; }
                if(x_oMobileRetentionOrder.log_date==null){  x_oCmd.Parameters.Add("@log_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@log_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrder.log_date; }
                if(x_oMobileRetentionOrder.extn==null){  x_oCmd.Parameters.Add("@extn", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@extn", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.extn; }
                if(x_oMobileRetentionOrder.d_time==null){  x_oCmd.Parameters.Add("@d_time", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_time", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.d_time; }
                if(x_oMobileRetentionOrder.bank_name==null){  x_oCmd.Parameters.Add("@bank_name", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bank_name", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.bank_name; }
                if(x_oMobileRetentionOrder.delivery_exchange_option==null){  x_oCmd.Parameters.Add("@delivery_exchange_option", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@delivery_exchange_option", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.delivery_exchange_option; }
                if(x_oMobileRetentionOrder.upgrade_service_account_no==null){  x_oCmd.Parameters.Add("@upgrade_service_account_no", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_service_account_no", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.upgrade_service_account_no; }
                if(x_oMobileRetentionOrder.old_ord_id==null){  x_oCmd.Parameters.Add("@old_ord_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@old_ord_id", global::System.Data.SqlDbType.Int).Value=x_oMobileRetentionOrder.old_ord_id; }
                if(x_oMobileRetentionOrder.m_card_no==null){  x_oCmd.Parameters.Add("@m_card_no", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_card_no", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionOrder.m_card_no; }
                if(x_oMobileRetentionOrder.existing_contract_end_date==null){  x_oCmd.Parameters.Add("@existing_contract_end_date", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@existing_contract_end_date", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionOrder.existing_contract_end_date; }
                if(x_oMobileRetentionOrder.con_eff_date==null){  x_oCmd.Parameters.Add("@con_eff_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@con_eff_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrder.con_eff_date; }
                if(x_oMobileRetentionOrder.m_3rd_hkid2==null){  x_oCmd.Parameters.Add("@m_3rd_hkid2", global::System.Data.SqlDbType.NVarChar,1).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_3rd_hkid2", global::System.Data.SqlDbType.NVarChar,1).Value=x_oMobileRetentionOrder.m_3rd_hkid2; }
                if(x_oMobileRetentionOrder.amount==null){  x_oCmd.Parameters.Add("@amount", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@amount", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.amount; }
                if(x_oMobileRetentionOrder.m_3rd_id_type==null){  x_oCmd.Parameters.Add("@m_3rd_id_type", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_3rd_id_type", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.m_3rd_id_type; }
                if(x_oMobileRetentionOrder.id_type==null){  x_oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.id_type; }
                if(x_oMobileRetentionOrder.rate_plan==null){  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.rate_plan; }
                if(x_oMobileRetentionOrder.channel==null){  x_oCmd.Parameters.Add("@channel", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@channel", global::System.Data.SqlDbType.Char,10).Value=x_oMobileRetentionOrder.channel; }
                if(x_oMobileRetentionOrder.action_eff_date==null){  x_oCmd.Parameters.Add("@action_eff_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@action_eff_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrder.action_eff_date; }
                if(x_oMobileRetentionOrder.issue_type==null){  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.issue_type; }
                if(x_oMobileRetentionOrder.free_mon==null){  x_oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionOrder.free_mon; }
                if(x_oMobileRetentionOrder.plan_eff_date==null){  x_oCmd.Parameters.Add("@plan_eff_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@plan_eff_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrder.plan_eff_date; }
                if(x_oMobileRetentionOrder.teamcode==null){  x_oCmd.Parameters.Add("@teamcode", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@teamcode", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.teamcode; }
                if(x_oMobileRetentionOrder.bill_medium==null){  x_oCmd.Parameters.Add("@bill_medium", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bill_medium", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.bill_medium; }
                if(x_oMobileRetentionOrder.edf_no==null){  x_oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,15).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,15).Value=x_oMobileRetentionOrder.edf_no; }
                if(x_oMobileRetentionOrder.ord_place_by==null){  x_oCmd.Parameters.Add("@ord_place_by", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ord_place_by", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.ord_place_by; }
                if(x_oMobileRetentionOrder.cancel_renew==null){  x_oCmd.Parameters.Add("@cancel_renew", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cancel_renew", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.cancel_renew; }
                if(x_oMobileRetentionOrder.preferred_languages==null){  x_oCmd.Parameters.Add("@preferred_languages", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@preferred_languages", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionOrder.preferred_languages; }
                if(x_oMobileRetentionOrder.hkid==null){  x_oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionOrder.hkid; }
                if(x_oMobileRetentionOrder.card_holder==null){  x_oCmd.Parameters.Add("@card_holder", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@card_holder", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.card_holder; }
                if(x_oMobileRetentionOrder.ac_no==null){  x_oCmd.Parameters.Add("@ac_no", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ac_no", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionOrder.ac_no; }
                if(x_oMobileRetentionOrder.bill_cut_num==null){  x_oCmd.Parameters.Add("@bill_cut_num", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bill_cut_num", global::System.Data.SqlDbType.Int).Value=x_oMobileRetentionOrder.bill_cut_num; }
                if(x_oMobileRetentionOrder.premium==null){  x_oCmd.Parameters.Add("@premium", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@premium", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.premium; }
                if(x_oMobileRetentionOrder.del_remark==null){  x_oCmd.Parameters.Add("@del_remark", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@del_remark", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.del_remark; }
                if(x_oMobileRetentionOrder.gift_imei2==null){  x_oCmd.Parameters.Add("@gift_imei2", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_imei2", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.gift_imei2; }
                if(x_oMobileRetentionOrder.reasons==null){  x_oCmd.Parameters.Add("@reasons", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@reasons", global::System.Data.SqlDbType.Text).Value=x_oMobileRetentionOrder.reasons; }
                if(x_oMobileRetentionOrder.language==null){  x_oCmd.Parameters.Add("@language", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@language", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.language; }
                if(x_oMobileRetentionOrder.rebate_amount==null){  x_oCmd.Parameters.Add("@rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.rebate_amount; }
                if(x_oMobileRetentionOrder.ord_place_id_type==null){  x_oCmd.Parameters.Add("@ord_place_id_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ord_place_id_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.ord_place_id_type; }
                if(x_oMobileRetentionOrder.m_3rd_contact_no==null){  x_oCmd.Parameters.Add("@m_3rd_contact_no", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_3rd_contact_no", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionOrder.m_3rd_contact_no; }
                if(x_oMobileRetentionOrder.staff_no==null){  x_oCmd.Parameters.Add("@staff_no", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@staff_no", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.staff_no; }
                if(x_oMobileRetentionOrder.sp_d_date==null){  x_oCmd.Parameters.Add("@sp_d_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@sp_d_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrder.sp_d_date; }
                if(x_oMobileRetentionOrder.bundle_name==null){  x_oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.bundle_name; }
                if(x_oMobileRetentionOrder.accessory_waive==null){  x_oCmd.Parameters.Add("@accessory_waive", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@accessory_waive", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionOrder.accessory_waive; }
                if(x_oMobileRetentionOrder.sim_item_code==null){  x_oCmd.Parameters.Add("@sim_item_code", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sim_item_code", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.sim_item_code; }
                if(x_oMobileRetentionOrder.cust_type==null){  x_oCmd.Parameters.Add("@cust_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cust_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.cust_type; }
                if(x_oMobileRetentionOrder.card_ref_no==null){  x_oCmd.Parameters.Add("@card_ref_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@card_ref_no", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.card_ref_no; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,string x_sGift_imei,string x_sS_premium4,string x_sGift_desc4,string x_sAccessory_desc,string x_sAction_required,global::System.Nullable<DateTime> x_dVas_eff_date,string x_sMonthly_bank_account_bank_code,string x_sSpecial_handling_dummy_code,string x_sM_card_exp_year,string x_sRemarks2PY,string x_sTrade_field,string x_sOrd_place_tel,string x_sOrd_place_id_type,string x_sCooling_offer,string x_sUpgrade_handset_offer_rebate_schedule,string x_sChange_payment_type,global::System.Nullable<DateTime> x_dDate_of_birth,string x_sContact_person,string x_sExtra_d_charge,string x_sTl_name,global::System.Nullable<bool> x_bFast_start,string x_sSp_ref_no,global::System.Nullable<DateTime> x_dEdate,string x_sExist_cust_plan,string x_sOrd_place_rel,global::System.Nullable<int> x_iMrt_no,string x_sImei_no,string x_sExisting_smart_phone_model,string x_sGift_code3,string x_sBank_code,string x_sPos_ref_no,global::System.Nullable<DateTime> x_dBill_cut_date,string x_sGift_imei3,string x_sExist_plan,global::System.Nullable<bool> x_bWaive,string x_sProgram,string x_sFirst_month_fee,string x_sR_offer,string x_sCid,string x_sDid,string x_sFtg_tenure,string x_sCon_per,string x_sGift_code4,string x_sEasywatch_type,string x_sSms_mrt,string x_sMonthly_payment_method,string x_sRemarks2EDF,string x_sGift_desc3,string x_sGift_imei4,global::System.Nullable<int> x_iOld_ord_id,string x_sMonthly_bank_account_hkid2,global::System.Nullable<DateTime> x_dD_date,string x_sGift_desc,string x_sSalesmancode,string x_sPool,global::System.Nullable<long> x_lCn_mrt_no,string x_sAccessory_imei,string x_sThird_party_credit_card,string x_sCard_ref_no,string x_sSpecial_approval,global::System.Nullable<DateTime> x_dUpgrade_existing_contract_edate,string x_sAccessory_code,string x_sBill_medium,string x_sS_premium,string x_sRef_staff_no,string x_sAccessory_price,string x_sM_card_exp_month,string x_sInstallment_period,string x_sM_card_type,string x_sEasywatch_ord_id,global::System.Nullable<bool> x_bNormal_rebate,string x_sM_rebate_amount,string x_sM_card_holder2,string x_sBill_medium_email,global::System.Nullable<bool> x_bActive,string x_sS_premium1,string x_sCard_exp_month,string x_sOb_program_id,string x_sSku,string x_sRef_salesmancode,string x_sGo_wireless_package_code,string x_sThird_party_hkid,string x_sUpgrade_existing_pccw_customer,string x_sD_address,string x_sUpgrade_registered_mobile_no,string x_sUpgrade_existing_customer_type,string x_sNormal_rebate_type,string x_sGift_desc2,string x_sMonthly_bank_account_branch_code,string x_sRemarks,string x_sAccept,string x_sDelivery_exchange,string x_sGift_code2,global::System.Nullable<bool> x_bPrepayment_waive,string x_sExisting_smart_phone_imei,string x_sCust_name,string x_sCust_type,string x_sUpgrade_sponsorships_amount,global::System.Nullable<bool> x_bBill_medium_waive,string x_sDelivery_exchange_location,global::System.Nullable<int> x_iHs_offer_type_id,string x_sOrg_fee,string x_sRebate,string x_sUpgrade_type,string x_sGo_wireless,string x_sExtra_rebate,string x_sPlan_eff,string x_sExtra_rebate_amount,string x_sCard_exp_year,global::System.Nullable<DateTime> x_dUpgrade_existing_contract_sdate,string x_sOrd_place_hkid,string x_sRegister_address,string x_sGender,string x_sLob_ac,global::System.Nullable<int> x_iSim_mrt_no,string x_sRedemption_notice_option,string x_sDelivery_collection_type,global::System.Nullable<DateTime> x_dAction_date,string x_sThird_party_id_type,string x_sOrg_ftg,string x_sUpgrade_service_tenure,string x_sMonthly_payment_type,string x_sContact_no,global::System.Nullable<int> x_iOrg_mrt,string x_sSim_item_name,string x_sPay_method,string x_sHs_model,string x_sGift_code,string x_sMonthly_bank_account_hkid,string x_sExtra_offer,string x_sMonthly_bank_account_no,string x_sFirst_month_license_fee,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dDdate,string x_sS_premium2,string x_sMonthly_bank_account_id_type,string x_sCard_type,global::System.Nullable<bool> x_bNext_bill,global::System.Nullable<bool> x_bPcd_paid_go_wireless,string x_sUpgrade_rebate_calculation,string x_sExt_place_tel,string x_sM_3rd_hkid,string x_sRetention_type,global::System.Nullable<DateTime> x_dCooling_date,string x_sAig_gift,string x_sCust_staff_no,string x_sFamily_name,global::System.Nullable<DateTime> x_dCdate,string x_sStatus_by_cs_admin,string x_sSim_item_number,string x_sVip_case,string x_sGiven_name,global::System.Nullable<DateTime> x_dLog_date,string x_sExtn,string x_sD_time,string x_sBank_name,string x_sDelivery_exchange_option,string x_sUpgrade_service_account_no,string x_sAction_of_rate_plan_effective,string x_sM_card_no,string x_sExisting_contract_end_date,global::System.Nullable<DateTime> x_dCon_eff_date,string x_sM_3rd_hkid2,string x_sAmount,string x_sId_type,string x_sRate_plan,string x_sChannel,global::System.Nullable<DateTime> x_dAction_eff_date,string x_sIssue_type,string x_sFree_mon,global::System.Nullable<DateTime> x_dPlan_eff_date,string x_sDel_remark,string x_sTeamcode,string x_sStaff_name,string x_sEdf_no,string x_sOrd_place_by,string x_sCancel_renew,string x_sPreferred_languages,string x_sHkid,string x_sCard_no,string x_sAc_no,global::System.Nullable<int> x_iBill_cut_num,string x_sPremium,string x_sM_3rd_id_type,string x_sGift_imei2,string x_sReasons,string x_sLanguage,string x_sRebate_amount,string x_sLob,string x_sM_3rd_contact_no,string x_sStaff_no,string x_sS_premium3,global::System.Nullable<DateTime> x_dSp_d_date,string x_sBundle_name,global::System.Nullable<bool> x_bAccessory_waive,string x_sSim_item_code,string x_sMonthly_bank_account_holder,string x_sCard_holder)
        {
            int _oLastID;
            MobileRetentionOrder _oMobileRetentionOrder=MobileRetentionOrderRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileRetentionOrder.gift_imei=x_sGift_imei;
            _oMobileRetentionOrder.s_premium4=x_sS_premium4;
            _oMobileRetentionOrder.gift_desc4=x_sGift_desc4;
            _oMobileRetentionOrder.accessory_desc=x_sAccessory_desc;
            _oMobileRetentionOrder.action_required=x_sAction_required;
            _oMobileRetentionOrder.vas_eff_date=x_dVas_eff_date;
            _oMobileRetentionOrder.monthly_bank_account_bank_code=x_sMonthly_bank_account_bank_code;
            _oMobileRetentionOrder.special_handling_dummy_code=x_sSpecial_handling_dummy_code;
            _oMobileRetentionOrder.m_card_exp_year=x_sM_card_exp_year;
            _oMobileRetentionOrder.remarks2PY=x_sRemarks2PY;
            _oMobileRetentionOrder.trade_field=x_sTrade_field;
            _oMobileRetentionOrder.ord_place_tel=x_sOrd_place_tel;
            _oMobileRetentionOrder.ord_place_id_type=x_sOrd_place_id_type;
            _oMobileRetentionOrder.cooling_offer=x_sCooling_offer;
            _oMobileRetentionOrder.upgrade_handset_offer_rebate_schedule=x_sUpgrade_handset_offer_rebate_schedule;
            _oMobileRetentionOrder.change_payment_type=x_sChange_payment_type;
            _oMobileRetentionOrder.date_of_birth=x_dDate_of_birth;
            _oMobileRetentionOrder.contact_person=x_sContact_person;
            _oMobileRetentionOrder.extra_d_charge=x_sExtra_d_charge;
            _oMobileRetentionOrder.tl_name=x_sTl_name;
            _oMobileRetentionOrder.fast_start=x_bFast_start;
            _oMobileRetentionOrder.sp_ref_no=x_sSp_ref_no;
            _oMobileRetentionOrder.edate=x_dEdate;
            _oMobileRetentionOrder.exist_cust_plan=x_sExist_cust_plan;
            _oMobileRetentionOrder.ord_place_rel=x_sOrd_place_rel;
            _oMobileRetentionOrder.mrt_no=x_iMrt_no;
            _oMobileRetentionOrder.imei_no=x_sImei_no;
            _oMobileRetentionOrder.existing_smart_phone_model=x_sExisting_smart_phone_model;
            _oMobileRetentionOrder.gift_code3=x_sGift_code3;
            _oMobileRetentionOrder.bank_code=x_sBank_code;
            _oMobileRetentionOrder.pos_ref_no=x_sPos_ref_no;
            _oMobileRetentionOrder.bill_cut_date=x_dBill_cut_date;
            _oMobileRetentionOrder.gift_imei3=x_sGift_imei3;
            _oMobileRetentionOrder.exist_plan=x_sExist_plan;
            _oMobileRetentionOrder.waive=x_bWaive;
            _oMobileRetentionOrder.program=x_sProgram;
            _oMobileRetentionOrder.first_month_fee=x_sFirst_month_fee;
            _oMobileRetentionOrder.r_offer=x_sR_offer;
            _oMobileRetentionOrder.cid=x_sCid;
            _oMobileRetentionOrder.did=x_sDid;
            _oMobileRetentionOrder.ftg_tenure=x_sFtg_tenure;
            _oMobileRetentionOrder.con_per=x_sCon_per;
            _oMobileRetentionOrder.gift_code4=x_sGift_code4;
            _oMobileRetentionOrder.easywatch_type=x_sEasywatch_type;
            _oMobileRetentionOrder.sms_mrt=x_sSms_mrt;
            _oMobileRetentionOrder.monthly_payment_method=x_sMonthly_payment_method;
            _oMobileRetentionOrder.remarks2EDF=x_sRemarks2EDF;
            _oMobileRetentionOrder.gift_desc3=x_sGift_desc3;
            _oMobileRetentionOrder.gift_imei4=x_sGift_imei4;
            _oMobileRetentionOrder.old_ord_id=x_iOld_ord_id;
            _oMobileRetentionOrder.monthly_bank_account_hkid2=x_sMonthly_bank_account_hkid2;
            _oMobileRetentionOrder.d_date=x_dD_date;
            _oMobileRetentionOrder.gift_desc=x_sGift_desc;
            _oMobileRetentionOrder.salesmancode=x_sSalesmancode;
            _oMobileRetentionOrder.pool=x_sPool;
            _oMobileRetentionOrder.cn_mrt_no=x_lCn_mrt_no;
            _oMobileRetentionOrder.accessory_imei=x_sAccessory_imei;
            _oMobileRetentionOrder.third_party_credit_card=x_sThird_party_credit_card;
            _oMobileRetentionOrder.card_ref_no=x_sCard_ref_no;
            _oMobileRetentionOrder.special_approval=x_sSpecial_approval;
            _oMobileRetentionOrder.upgrade_existing_contract_edate=x_dUpgrade_existing_contract_edate;
            _oMobileRetentionOrder.accessory_code=x_sAccessory_code;
            _oMobileRetentionOrder.bill_medium=x_sBill_medium;
            _oMobileRetentionOrder.s_premium=x_sS_premium;
            _oMobileRetentionOrder.ref_staff_no=x_sRef_staff_no;
            _oMobileRetentionOrder.accessory_price=x_sAccessory_price;
            _oMobileRetentionOrder.m_card_exp_month=x_sM_card_exp_month;
            _oMobileRetentionOrder.installment_period=x_sInstallment_period;
            _oMobileRetentionOrder.m_card_type=x_sM_card_type;
            _oMobileRetentionOrder.easywatch_ord_id=x_sEasywatch_ord_id;
            _oMobileRetentionOrder.normal_rebate=x_bNormal_rebate;
            _oMobileRetentionOrder.m_rebate_amount=x_sM_rebate_amount;
            _oMobileRetentionOrder.m_card_holder2=x_sM_card_holder2;
            _oMobileRetentionOrder.bill_medium_email=x_sBill_medium_email;
            _oMobileRetentionOrder.active=x_bActive;
            _oMobileRetentionOrder.s_premium1=x_sS_premium1;
            _oMobileRetentionOrder.card_exp_month=x_sCard_exp_month;
            _oMobileRetentionOrder.ob_program_id=x_sOb_program_id;
            _oMobileRetentionOrder.sku=x_sSku;
            _oMobileRetentionOrder.ref_salesmancode=x_sRef_salesmancode;
            _oMobileRetentionOrder.go_wireless_package_code=x_sGo_wireless_package_code;
            _oMobileRetentionOrder.third_party_hkid=x_sThird_party_hkid;
            _oMobileRetentionOrder.upgrade_existing_pccw_customer=x_sUpgrade_existing_pccw_customer;
            _oMobileRetentionOrder.d_address=x_sD_address;
            _oMobileRetentionOrder.upgrade_registered_mobile_no=x_sUpgrade_registered_mobile_no;
            _oMobileRetentionOrder.upgrade_existing_customer_type=x_sUpgrade_existing_customer_type;
            _oMobileRetentionOrder.normal_rebate_type=x_sNormal_rebate_type;
            _oMobileRetentionOrder.gift_desc2=x_sGift_desc2;
            _oMobileRetentionOrder.monthly_bank_account_branch_code=x_sMonthly_bank_account_branch_code;
            _oMobileRetentionOrder.remarks=x_sRemarks;
            _oMobileRetentionOrder.accept=x_sAccept;
            _oMobileRetentionOrder.delivery_exchange=x_sDelivery_exchange;
            _oMobileRetentionOrder.gift_code2=x_sGift_code2;
            _oMobileRetentionOrder.prepayment_waive=x_bPrepayment_waive;
            _oMobileRetentionOrder.existing_smart_phone_imei=x_sExisting_smart_phone_imei;
            _oMobileRetentionOrder.cust_name=x_sCust_name;
            _oMobileRetentionOrder.cust_type=x_sCust_type;
            _oMobileRetentionOrder.upgrade_sponsorships_amount=x_sUpgrade_sponsorships_amount;
            _oMobileRetentionOrder.bill_medium_waive=x_bBill_medium_waive;
            _oMobileRetentionOrder.delivery_exchange_location=x_sDelivery_exchange_location;
            _oMobileRetentionOrder.hs_offer_type_id=x_iHs_offer_type_id;
            _oMobileRetentionOrder.org_fee=x_sOrg_fee;
            _oMobileRetentionOrder.rebate=x_sRebate;
            _oMobileRetentionOrder.upgrade_type=x_sUpgrade_type;
            _oMobileRetentionOrder.go_wireless=x_sGo_wireless;
            _oMobileRetentionOrder.extra_rebate=x_sExtra_rebate;
            _oMobileRetentionOrder.plan_eff=x_sPlan_eff;
            _oMobileRetentionOrder.extra_rebate_amount=x_sExtra_rebate_amount;
            _oMobileRetentionOrder.card_exp_year=x_sCard_exp_year;
            _oMobileRetentionOrder.upgrade_existing_contract_sdate=x_dUpgrade_existing_contract_sdate;
            _oMobileRetentionOrder.ord_place_hkid=x_sOrd_place_hkid;
            _oMobileRetentionOrder.register_address=x_sRegister_address;
            _oMobileRetentionOrder.gender=x_sGender;
            _oMobileRetentionOrder.lob_ac=x_sLob_ac;
            _oMobileRetentionOrder.sim_mrt_no=x_iSim_mrt_no;
            _oMobileRetentionOrder.redemption_notice_option=x_sRedemption_notice_option;
            _oMobileRetentionOrder.delivery_collection_type=x_sDelivery_collection_type;
            _oMobileRetentionOrder.action_date=x_dAction_date;
            _oMobileRetentionOrder.third_party_id_type=x_sThird_party_id_type;
            _oMobileRetentionOrder.org_ftg=x_sOrg_ftg;
            _oMobileRetentionOrder.upgrade_service_tenure=x_sUpgrade_service_tenure;
            _oMobileRetentionOrder.monthly_payment_type=x_sMonthly_payment_type;
            _oMobileRetentionOrder.contact_no=x_sContact_no;
            _oMobileRetentionOrder.org_mrt=x_iOrg_mrt;
            _oMobileRetentionOrder.sim_item_name=x_sSim_item_name;
            _oMobileRetentionOrder.pay_method=x_sPay_method;
            _oMobileRetentionOrder.hs_model=x_sHs_model;
            _oMobileRetentionOrder.gift_code=x_sGift_code;
            _oMobileRetentionOrder.monthly_bank_account_hkid=x_sMonthly_bank_account_hkid;
            _oMobileRetentionOrder.extra_offer=x_sExtra_offer;
            _oMobileRetentionOrder.monthly_bank_account_no=x_sMonthly_bank_account_no;
            _oMobileRetentionOrder.first_month_license_fee=x_sFirst_month_license_fee;
            _oMobileRetentionOrder.retrieve_cnt=x_iRetrieve_cnt;
            _oMobileRetentionOrder.ddate=x_dDdate;
            _oMobileRetentionOrder.s_premium2=x_sS_premium2;
            _oMobileRetentionOrder.monthly_bank_account_id_type=x_sMonthly_bank_account_id_type;
            _oMobileRetentionOrder.card_type=x_sCard_type;
            _oMobileRetentionOrder.next_bill=x_bNext_bill;
            _oMobileRetentionOrder.pcd_paid_go_wireless=x_bPcd_paid_go_wireless;
            _oMobileRetentionOrder.upgrade_rebate_calculation=x_sUpgrade_rebate_calculation;
            _oMobileRetentionOrder.ext_place_tel=x_sExt_place_tel;
            _oMobileRetentionOrder.m_3rd_hkid=x_sM_3rd_hkid;
            _oMobileRetentionOrder.retention_type=x_sRetention_type;
            _oMobileRetentionOrder.cooling_date=x_dCooling_date;
            _oMobileRetentionOrder.aig_gift=x_sAig_gift;
            _oMobileRetentionOrder.cust_staff_no=x_sCust_staff_no;
            _oMobileRetentionOrder.family_name=x_sFamily_name;
            _oMobileRetentionOrder.cdate=x_dCdate;
            _oMobileRetentionOrder.status_by_cs_admin=x_sStatus_by_cs_admin;
            _oMobileRetentionOrder.sim_item_number=x_sSim_item_number;
            _oMobileRetentionOrder.vip_case=x_sVip_case;
            _oMobileRetentionOrder.given_name=x_sGiven_name;
            _oMobileRetentionOrder.log_date=x_dLog_date;
            _oMobileRetentionOrder.extn=x_sExtn;
            _oMobileRetentionOrder.d_time=x_sD_time;
            _oMobileRetentionOrder.bank_name=x_sBank_name;
            _oMobileRetentionOrder.delivery_exchange_option=x_sDelivery_exchange_option;
            _oMobileRetentionOrder.upgrade_service_account_no=x_sUpgrade_service_account_no;
            _oMobileRetentionOrder.action_of_rate_plan_effective=x_sAction_of_rate_plan_effective;
            _oMobileRetentionOrder.m_card_no=x_sM_card_no;
            _oMobileRetentionOrder.existing_contract_end_date=x_sExisting_contract_end_date;
            _oMobileRetentionOrder.con_eff_date=x_dCon_eff_date;
            _oMobileRetentionOrder.m_3rd_hkid2=x_sM_3rd_hkid2;
            _oMobileRetentionOrder.amount=x_sAmount;
            _oMobileRetentionOrder.id_type=x_sId_type;
            _oMobileRetentionOrder.rate_plan=x_sRate_plan;
            _oMobileRetentionOrder.channel=x_sChannel;
            _oMobileRetentionOrder.action_eff_date=x_dAction_eff_date;
            _oMobileRetentionOrder.issue_type=x_sIssue_type;
            _oMobileRetentionOrder.free_mon=x_sFree_mon;
            _oMobileRetentionOrder.plan_eff_date=x_dPlan_eff_date;
            _oMobileRetentionOrder.del_remark=x_sDel_remark;
            _oMobileRetentionOrder.teamcode=x_sTeamcode;
            _oMobileRetentionOrder.staff_name=x_sStaff_name;
            _oMobileRetentionOrder.edf_no=x_sEdf_no;
            _oMobileRetentionOrder.ord_place_by=x_sOrd_place_by;
            _oMobileRetentionOrder.cancel_renew=x_sCancel_renew;
            _oMobileRetentionOrder.preferred_languages=x_sPreferred_languages;
            _oMobileRetentionOrder.hkid=x_sHkid;
            _oMobileRetentionOrder.card_no=x_sCard_no;
            _oMobileRetentionOrder.ac_no=x_sAc_no;
            _oMobileRetentionOrder.bill_cut_num=x_iBill_cut_num;
            _oMobileRetentionOrder.premium=x_sPremium;
            _oMobileRetentionOrder.m_3rd_id_type=x_sM_3rd_id_type;
            _oMobileRetentionOrder.gift_imei2=x_sGift_imei2;
            _oMobileRetentionOrder.reasons=x_sReasons;
            _oMobileRetentionOrder.language=x_sLanguage;
            _oMobileRetentionOrder.rebate_amount=x_sRebate_amount;
            _oMobileRetentionOrder.lob=x_sLob;
            _oMobileRetentionOrder.m_3rd_contact_no=x_sM_3rd_contact_no;
            _oMobileRetentionOrder.staff_no=x_sStaff_no;
            _oMobileRetentionOrder.s_premium3=x_sS_premium3;
            _oMobileRetentionOrder.sp_d_date=x_dSp_d_date;
            _oMobileRetentionOrder.bundle_name=x_sBundle_name;
            _oMobileRetentionOrder.accessory_waive=x_bAccessory_waive;
            _oMobileRetentionOrder.sim_item_code=x_sSim_item_code;
            _oMobileRetentionOrder.monthly_bank_account_holder=x_sMonthly_bank_account_holder;
            _oMobileRetentionOrder.card_holder=x_sCard_holder;
            if(InsertWithLastID(x_oDB, _oMobileRetentionOrder,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(MobileRetentionOrder x_oMobileRetentionOrder)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oMobileRetentionOrder, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, MobileRetentionOrder x_oMobileRetentionOrder)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oMobileRetentionOrder, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileRetentionOrder)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (MobileRetentionOrder)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,MobileRetentionOrder x_oMobileRetentionOrder, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileRetentionOrder]   ([gift_imei],[s_premium4],[upgrade_existing_customer_type],[gift_desc4],[accessory_desc],[staff_name],[action_required],[vas_eff_date],[monthly_bank_account_bank_code],[sim_item_number],[special_handling_dummy_code],[card_no],[m_card_exp_year],[bill_medium_email],[remarks2PY],[trade_field],[ord_place_tel],[action_of_rate_plan_effective],[cooling_offer],[upgrade_handset_offer_rebate_schedule],[change_payment_type],[date_of_birth],[contact_person],[extra_d_charge],[tl_name],[fast_start],[sp_ref_no],[edate],[exist_cust_plan],[ord_place_rel],[mrt_no],[imei_no],[existing_smart_phone_model],[bank_code],[pos_ref_no],[bill_cut_date],[gift_imei3],[exist_plan],[waive],[program],[first_month_fee],[r_offer],[cid],[did],[ftg_tenure],[con_per],[gift_code4],[easywatch_type],[sms_mrt],[monthly_payment_method],[remarks2EDF],[gift_desc3],[gift_imei4],[monthly_bank_account_hkid2],[d_date],[gift_desc],[pool],[cn_mrt_no],[accessory_imei],[third_party_credit_card],[special_approval],[upgrade_existing_contract_edate],[accessory_code],[s_premium],[ref_staff_no],[accessory_price],[m_card_exp_month],[installment_period],[m_card_type],[easywatch_ord_id],[normal_rebate],[m_rebate_amount],[m_card_holder2],[monthly_bank_account_holder],[active],[s_premium1],[card_exp_month],[ob_program_id],[sku],[salesmancode],[go_wireless_package_code],[lob],[ref_salesmancode],[third_party_hkid],[upgrade_existing_pccw_customer],[d_address],[upgrade_registered_mobile_no],[gift_code3],[normal_rebate_type],[gift_desc2],[monthly_bank_account_branch_code],[remarks],[accept],[delivery_exchange],[gift_code2],[prepayment_waive],[existing_smart_phone_imei],[cust_name],[upgrade_sponsorships_amount],[bill_medium_waive],[delivery_exchange_location],[hs_offer_type_id],[extra_rebate_amount],[rebate],[upgrade_type],[go_wireless],[extra_rebate],[plan_eff],[card_exp_year],[upgrade_existing_contract_sdate],[ord_place_hkid],[register_address],[gender],[lob_ac],[sim_mrt_no],[redemption_notice_option],[delivery_collection_type],[action_date],[third_party_id_type],[org_ftg],[upgrade_service_tenure],[monthly_payment_type],[contact_no],[org_mrt],[sim_item_name],[pay_method],[hs_model],[gift_code],[monthly_bank_account_hkid],[extra_offer],[monthly_bank_account_no],[first_month_license_fee],[retrieve_cnt],[ddate],[s_premium2],[monthly_bank_account_id_type],[card_type],[next_bill],[pcd_paid_go_wireless],[upgrade_rebate_calculation],[ext_place_tel],[m_3rd_hkid],[retention_type],[cooling_date],[aig_gift],[cust_staff_no],[family_name],[cdate],[status_by_cs_admin],[given_name],[vip_case],[org_fee],[s_premium3],[log_date],[extn],[d_time],[bank_name],[delivery_exchange_option],[upgrade_service_account_no],[old_ord_id],[m_card_no],[existing_contract_end_date],[con_eff_date],[m_3rd_hkid2],[amount],[m_3rd_id_type],[id_type],[rate_plan],[channel],[action_eff_date],[issue_type],[free_mon],[plan_eff_date],[teamcode],[bill_medium],[edf_no],[ord_place_by],[cancel_renew],[preferred_languages],[hkid],[card_holder],[ac_no],[bill_cut_num],[premium],[del_remark],[gift_imei2],[reasons],[language],[rebate_amount],[ord_place_id_type],[m_3rd_contact_no],[staff_no],[sp_d_date],[bundle_name],[accessory_waive],[sim_item_code],[cust_type],[card_ref_no])  VALUES  (@gift_imei,@s_premium4,@upgrade_existing_customer_type,@gift_desc4,@accessory_desc,@staff_name,@action_required,@vas_eff_date,@monthly_bank_account_bank_code,@sim_item_number,@special_handling_dummy_code,@card_no,@m_card_exp_year,@bill_medium_email,@remarks2PY,@trade_field,@ord_place_tel,@action_of_rate_plan_effective,@cooling_offer,@upgrade_handset_offer_rebate_schedule,@change_payment_type,@date_of_birth,@contact_person,@extra_d_charge,@tl_name,@fast_start,@sp_ref_no,@edate,@exist_cust_plan,@ord_place_rel,@mrt_no,@imei_no,@existing_smart_phone_model,@bank_code,@pos_ref_no,@bill_cut_date,@gift_imei3,@exist_plan,@waive,@program,@first_month_fee,@r_offer,@cid,@did,@ftg_tenure,@con_per,@gift_code4,@easywatch_type,@sms_mrt,@monthly_payment_method,@remarks2EDF,@gift_desc3,@gift_imei4,@monthly_bank_account_hkid2,@d_date,@gift_desc,@pool,@cn_mrt_no,@accessory_imei,@third_party_credit_card,@special_approval,@upgrade_existing_contract_edate,@accessory_code,@s_premium,@ref_staff_no,@accessory_price,@m_card_exp_month,@installment_period,@m_card_type,@easywatch_ord_id,@normal_rebate,@m_rebate_amount,@m_card_holder2,@monthly_bank_account_holder,@active,@s_premium1,@card_exp_month,@ob_program_id,@sku,@salesmancode,@go_wireless_package_code,@lob,@ref_salesmancode,@third_party_hkid,@upgrade_existing_pccw_customer,@d_address,@upgrade_registered_mobile_no,@gift_code3,@normal_rebate_type,@gift_desc2,@monthly_bank_account_branch_code,@remarks,@accept,@delivery_exchange,@gift_code2,@prepayment_waive,@existing_smart_phone_imei,@cust_name,@upgrade_sponsorships_amount,@bill_medium_waive,@delivery_exchange_location,@hs_offer_type_id,@extra_rebate_amount,@rebate,@upgrade_type,@go_wireless,@extra_rebate,@plan_eff,@card_exp_year,@upgrade_existing_contract_sdate,@ord_place_hkid,@register_address,@gender,@lob_ac,@sim_mrt_no,@redemption_notice_option,@delivery_collection_type,@action_date,@third_party_id_type,@org_ftg,@upgrade_service_tenure,@monthly_payment_type,@contact_no,@org_mrt,@sim_item_name,@pay_method,@hs_model,@gift_code,@monthly_bank_account_hkid,@extra_offer,@monthly_bank_account_no,@first_month_license_fee,@retrieve_cnt,@ddate,@s_premium2,@monthly_bank_account_id_type,@card_type,@next_bill,@pcd_paid_go_wireless,@upgrade_rebate_calculation,@ext_place_tel,@m_3rd_hkid,@retention_type,@cooling_date,@aig_gift,@cust_staff_no,@family_name,@cdate,@status_by_cs_admin,@given_name,@vip_case,@org_fee,@s_premium3,@log_date,@extn,@d_time,@bank_name,@delivery_exchange_option,@upgrade_service_account_no,@old_ord_id,@m_card_no,@existing_contract_end_date,@con_eff_date,@m_3rd_hkid2,@amount,@m_3rd_id_type,@id_type,@rate_plan,@channel,@action_eff_date,@issue_type,@free_mon,@plan_eff_date,@teamcode,@bill_medium,@edf_no,@ord_place_by,@cancel_renew,@preferred_languages,@hkid,@card_holder,@ac_no,@bill_cut_num,@premium,@del_remark,@gift_imei2,@reasons,@language,@rebate_amount,@ord_place_id_type,@m_3rd_contact_no,@staff_no,@sp_d_date,@bundle_name,@accessory_waive,@sim_item_code,@cust_type,@card_ref_no)"+" SELECT  @@IDENTITY AS MobileRetentionOrder_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionOrder]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrder]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oMobileRetentionOrder,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileRetentionOrder x_oMobileRetentionOrder, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oMobileRetentionOrder.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileRetentionOrder.gift_imei==null){  x_oCmd.Parameters.Add("@gift_imei", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_imei", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.gift_imei; }
                if(x_oMobileRetentionOrder.s_premium4==null){  x_oCmd.Parameters.Add("@s_premium4", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@s_premium4", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.s_premium4; }
                if(x_oMobileRetentionOrder.upgrade_existing_customer_type==null){  x_oCmd.Parameters.Add("@upgrade_existing_customer_type", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_existing_customer_type", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.upgrade_existing_customer_type; }
                if(x_oMobileRetentionOrder.gift_desc4==null){  x_oCmd.Parameters.Add("@gift_desc4", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_desc4", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.gift_desc4; }
                if(x_oMobileRetentionOrder.accessory_desc==null){  x_oCmd.Parameters.Add("@accessory_desc", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@accessory_desc", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.accessory_desc; }
                if(x_oMobileRetentionOrder.staff_name==null){  x_oCmd.Parameters.Add("@staff_name", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@staff_name", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.staff_name; }
                if(x_oMobileRetentionOrder.action_required==null){  x_oCmd.Parameters.Add("@action_required", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@action_required", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.action_required; }
                if(x_oMobileRetentionOrder.vas_eff_date==null){  x_oCmd.Parameters.Add("@vas_eff_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@vas_eff_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrder.vas_eff_date; }
                if(x_oMobileRetentionOrder.monthly_bank_account_bank_code==null){  x_oCmd.Parameters.Add("@monthly_bank_account_bank_code", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_bank_account_bank_code", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.monthly_bank_account_bank_code; }
                if(x_oMobileRetentionOrder.sim_item_number==null){  x_oCmd.Parameters.Add("@sim_item_number", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sim_item_number", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.sim_item_number; }
                if(x_oMobileRetentionOrder.special_handling_dummy_code==null){  x_oCmd.Parameters.Add("@special_handling_dummy_code", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@special_handling_dummy_code", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.special_handling_dummy_code; }
                if(x_oMobileRetentionOrder.card_no==null){  x_oCmd.Parameters.Add("@card_no", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@card_no", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionOrder.card_no; }
                if(x_oMobileRetentionOrder.m_card_exp_year==null){  x_oCmd.Parameters.Add("@m_card_exp_year", global::System.Data.SqlDbType.NVarChar,4).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_card_exp_year", global::System.Data.SqlDbType.NVarChar,4).Value=x_oMobileRetentionOrder.m_card_exp_year; }
                if(x_oMobileRetentionOrder.bill_medium_email==null){  x_oCmd.Parameters.Add("@bill_medium_email", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bill_medium_email", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.bill_medium_email; }
                if(x_oMobileRetentionOrder.remarks2PY==null){  x_oCmd.Parameters.Add("@remarks2PY", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@remarks2PY", global::System.Data.SqlDbType.Text).Value=x_oMobileRetentionOrder.remarks2PY; }
                if(x_oMobileRetentionOrder.trade_field==null){  x_oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.trade_field; }
                if(x_oMobileRetentionOrder.ord_place_tel==null){  x_oCmd.Parameters.Add("@ord_place_tel", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ord_place_tel", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.ord_place_tel; }
                if(x_oMobileRetentionOrder.action_of_rate_plan_effective==null){  x_oCmd.Parameters.Add("@action_of_rate_plan_effective", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@action_of_rate_plan_effective", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.action_of_rate_plan_effective; }
                if(x_oMobileRetentionOrder.cooling_offer==null){  x_oCmd.Parameters.Add("@cooling_offer", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cooling_offer", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.cooling_offer; }
                if(x_oMobileRetentionOrder.upgrade_handset_offer_rebate_schedule==null){  x_oCmd.Parameters.Add("@upgrade_handset_offer_rebate_schedule", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_handset_offer_rebate_schedule", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.upgrade_handset_offer_rebate_schedule; }
                if(x_oMobileRetentionOrder.change_payment_type==null){  x_oCmd.Parameters.Add("@change_payment_type", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@change_payment_type", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionOrder.change_payment_type; }
                if(x_oMobileRetentionOrder.date_of_birth==null){  x_oCmd.Parameters.Add("@date_of_birth", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@date_of_birth", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrder.date_of_birth; }
                if(x_oMobileRetentionOrder.contact_person==null){  x_oCmd.Parameters.Add("@contact_person", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@contact_person", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.contact_person; }
                if(x_oMobileRetentionOrder.extra_d_charge==null){  x_oCmd.Parameters.Add("@extra_d_charge", global::System.Data.SqlDbType.NVarChar,5).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@extra_d_charge", global::System.Data.SqlDbType.NVarChar,5).Value=x_oMobileRetentionOrder.extra_d_charge; }
                if(x_oMobileRetentionOrder.tl_name==null){  x_oCmd.Parameters.Add("@tl_name", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@tl_name", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.tl_name; }
                if(x_oMobileRetentionOrder.fast_start==null){  x_oCmd.Parameters.Add("@fast_start", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fast_start", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionOrder.fast_start; }
                if(x_oMobileRetentionOrder.sp_ref_no==null){  x_oCmd.Parameters.Add("@sp_ref_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sp_ref_no", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.sp_ref_no; }
                if(x_oMobileRetentionOrder.edate==null){  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrder.edate; }
                if(x_oMobileRetentionOrder.exist_cust_plan==null){  x_oCmd.Parameters.Add("@exist_cust_plan", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@exist_cust_plan", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.exist_cust_plan; }
                if(x_oMobileRetentionOrder.ord_place_rel==null){  x_oCmd.Parameters.Add("@ord_place_rel", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ord_place_rel", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.ord_place_rel; }
                if(x_oMobileRetentionOrder.mrt_no==null){  x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.Int).Value=x_oMobileRetentionOrder.mrt_no; }
                if(x_oMobileRetentionOrder.imei_no==null){  x_oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionOrder.imei_no; }
                if(x_oMobileRetentionOrder.existing_smart_phone_model==null){  x_oCmd.Parameters.Add("@existing_smart_phone_model", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@existing_smart_phone_model", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.existing_smart_phone_model; }
                if(x_oMobileRetentionOrder.bank_code==null){  x_oCmd.Parameters.Add("@bank_code", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bank_code", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionOrder.bank_code; }
                if(x_oMobileRetentionOrder.pos_ref_no==null){  x_oCmd.Parameters.Add("@pos_ref_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@pos_ref_no", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.pos_ref_no; }
                if(x_oMobileRetentionOrder.bill_cut_date==null){  x_oCmd.Parameters.Add("@bill_cut_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@bill_cut_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrder.bill_cut_date; }
                if(x_oMobileRetentionOrder.gift_imei3==null){  x_oCmd.Parameters.Add("@gift_imei3", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_imei3", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.gift_imei3; }
                if(x_oMobileRetentionOrder.exist_plan==null){  x_oCmd.Parameters.Add("@exist_plan", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@exist_plan", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.exist_plan; }
                if(x_oMobileRetentionOrder.waive==null){  x_oCmd.Parameters.Add("@waive", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@waive", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionOrder.waive; }
                if(x_oMobileRetentionOrder.program==null){  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.program; }
                if(x_oMobileRetentionOrder.first_month_fee==null){  x_oCmd.Parameters.Add("@first_month_fee", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@first_month_fee", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.first_month_fee; }
                if(x_oMobileRetentionOrder.r_offer==null){  x_oCmd.Parameters.Add("@r_offer", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@r_offer", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.r_offer; }
                if(x_oMobileRetentionOrder.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.cid; }
                if(x_oMobileRetentionOrder.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.did; }
                if(x_oMobileRetentionOrder.ftg_tenure==null){  x_oCmd.Parameters.Add("@ftg_tenure", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ftg_tenure", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.ftg_tenure; }
                if(x_oMobileRetentionOrder.con_per==null){  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.con_per; }
                if(x_oMobileRetentionOrder.gift_code4==null){  x_oCmd.Parameters.Add("@gift_code4", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_code4", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.gift_code4; }
                if(x_oMobileRetentionOrder.easywatch_type==null){  x_oCmd.Parameters.Add("@easywatch_type", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@easywatch_type", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionOrder.easywatch_type; }
                if(x_oMobileRetentionOrder.sms_mrt==null){  x_oCmd.Parameters.Add("@sms_mrt", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sms_mrt", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.sms_mrt; }
                if(x_oMobileRetentionOrder.monthly_payment_method==null){  x_oCmd.Parameters.Add("@monthly_payment_method", global::System.Data.SqlDbType.NVarChar,40).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_payment_method", global::System.Data.SqlDbType.NVarChar,40).Value=x_oMobileRetentionOrder.monthly_payment_method; }
                if(x_oMobileRetentionOrder.remarks2EDF==null){  x_oCmd.Parameters.Add("@remarks2EDF", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@remarks2EDF", global::System.Data.SqlDbType.Text).Value=x_oMobileRetentionOrder.remarks2EDF; }
                if(x_oMobileRetentionOrder.gift_desc3==null){  x_oCmd.Parameters.Add("@gift_desc3", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_desc3", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.gift_desc3; }
                if(x_oMobileRetentionOrder.gift_imei4==null){  x_oCmd.Parameters.Add("@gift_imei4", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_imei4", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.gift_imei4; }
                if(x_oMobileRetentionOrder.monthly_bank_account_hkid2==null){  x_oCmd.Parameters.Add("@monthly_bank_account_hkid2", global::System.Data.SqlDbType.NVarChar,1).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_bank_account_hkid2", global::System.Data.SqlDbType.NVarChar,1).Value=x_oMobileRetentionOrder.monthly_bank_account_hkid2; }
                if(x_oMobileRetentionOrder.d_date==null){  x_oCmd.Parameters.Add("@d_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@d_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrder.d_date; }
                if(x_oMobileRetentionOrder.gift_desc==null){  x_oCmd.Parameters.Add("@gift_desc", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_desc", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.gift_desc; }
                if(x_oMobileRetentionOrder.pool==null){  x_oCmd.Parameters.Add("@pool", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@pool", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.pool; }
                if(x_oMobileRetentionOrder.cn_mrt_no==null){  x_oCmd.Parameters.Add("@cn_mrt_no", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cn_mrt_no", global::System.Data.SqlDbType.BigInt).Value=x_oMobileRetentionOrder.cn_mrt_no; }
                if(x_oMobileRetentionOrder.accessory_imei==null){  x_oCmd.Parameters.Add("@accessory_imei", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@accessory_imei", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.accessory_imei; }
                if(x_oMobileRetentionOrder.third_party_credit_card==null){  x_oCmd.Parameters.Add("@third_party_credit_card", global::System.Data.SqlDbType.NVarChar,5).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@third_party_credit_card", global::System.Data.SqlDbType.NVarChar,5).Value=x_oMobileRetentionOrder.third_party_credit_card; }
                if(x_oMobileRetentionOrder.special_approval==null){  x_oCmd.Parameters.Add("@special_approval", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@special_approval", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionOrder.special_approval; }
                if(x_oMobileRetentionOrder.upgrade_existing_contract_edate==null){  x_oCmd.Parameters.Add("@upgrade_existing_contract_edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@upgrade_existing_contract_edate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrder.upgrade_existing_contract_edate; }
                if(x_oMobileRetentionOrder.accessory_code==null){  x_oCmd.Parameters.Add("@accessory_code", global::System.Data.SqlDbType.NVarChar,70).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@accessory_code", global::System.Data.SqlDbType.NVarChar,70).Value=x_oMobileRetentionOrder.accessory_code; }
                if(x_oMobileRetentionOrder.s_premium==null){  x_oCmd.Parameters.Add("@s_premium", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@s_premium", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.s_premium; }
                if(x_oMobileRetentionOrder.ref_staff_no==null){  x_oCmd.Parameters.Add("@ref_staff_no", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ref_staff_no", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionOrder.ref_staff_no; }
                if(x_oMobileRetentionOrder.accessory_price==null){  x_oCmd.Parameters.Add("@accessory_price", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@accessory_price", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.accessory_price; }
                if(x_oMobileRetentionOrder.m_card_exp_month==null){  x_oCmd.Parameters.Add("@m_card_exp_month", global::System.Data.SqlDbType.NVarChar,2).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_card_exp_month", global::System.Data.SqlDbType.NVarChar,2).Value=x_oMobileRetentionOrder.m_card_exp_month; }
                if(x_oMobileRetentionOrder.installment_period==null){  x_oCmd.Parameters.Add("@installment_period", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@installment_period", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.installment_period; }
                if(x_oMobileRetentionOrder.m_card_type==null){  x_oCmd.Parameters.Add("@m_card_type", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_card_type", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionOrder.m_card_type; }
                if(x_oMobileRetentionOrder.easywatch_ord_id==null){  x_oCmd.Parameters.Add("@easywatch_ord_id", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@easywatch_ord_id", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.easywatch_ord_id; }
                if(x_oMobileRetentionOrder.normal_rebate==null){  x_oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionOrder.normal_rebate; }
                if(x_oMobileRetentionOrder.m_rebate_amount==null){  x_oCmd.Parameters.Add("@m_rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.m_rebate_amount; }
                if(x_oMobileRetentionOrder.m_card_holder2==null){  x_oCmd.Parameters.Add("@m_card_holder2", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_card_holder2", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.m_card_holder2; }
                if(x_oMobileRetentionOrder.monthly_bank_account_holder==null){  x_oCmd.Parameters.Add("@monthly_bank_account_holder", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_bank_account_holder", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.monthly_bank_account_holder; }
                if(x_oMobileRetentionOrder.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionOrder.active; }
                if(x_oMobileRetentionOrder.s_premium1==null){  x_oCmd.Parameters.Add("@s_premium1", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@s_premium1", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.s_premium1; }
                if(x_oMobileRetentionOrder.card_exp_month==null){  x_oCmd.Parameters.Add("@card_exp_month", global::System.Data.SqlDbType.NVarChar,2).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@card_exp_month", global::System.Data.SqlDbType.NVarChar,2).Value=x_oMobileRetentionOrder.card_exp_month; }
                if(x_oMobileRetentionOrder.ob_program_id==null){  x_oCmd.Parameters.Add("@ob_program_id", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ob_program_id", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionOrder.ob_program_id; }
                if(x_oMobileRetentionOrder.sku==null){  x_oCmd.Parameters.Add("@sku", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sku", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.sku; }
                if(x_oMobileRetentionOrder.salesmancode==null){  x_oCmd.Parameters.Add("@salesmancode", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@salesmancode", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.salesmancode; }
                if(x_oMobileRetentionOrder.go_wireless_package_code==null){  x_oCmd.Parameters.Add("@go_wireless_package_code", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@go_wireless_package_code", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.go_wireless_package_code; }
                if(x_oMobileRetentionOrder.lob==null){  x_oCmd.Parameters.Add("@lob", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@lob", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.lob; }
                if(x_oMobileRetentionOrder.ref_salesmancode==null){  x_oCmd.Parameters.Add("@ref_salesmancode", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ref_salesmancode", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionOrder.ref_salesmancode; }
                if(x_oMobileRetentionOrder.third_party_hkid==null){  x_oCmd.Parameters.Add("@third_party_hkid", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@third_party_hkid", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionOrder.third_party_hkid; }
                if(x_oMobileRetentionOrder.upgrade_existing_pccw_customer==null){  x_oCmd.Parameters.Add("@upgrade_existing_pccw_customer", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_existing_pccw_customer", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.upgrade_existing_pccw_customer; }
                if(x_oMobileRetentionOrder.d_address==null){  x_oCmd.Parameters.Add("@d_address", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_address", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.d_address; }
                if(x_oMobileRetentionOrder.upgrade_registered_mobile_no==null){  x_oCmd.Parameters.Add("@upgrade_registered_mobile_no", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_registered_mobile_no", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.upgrade_registered_mobile_no; }
                if(x_oMobileRetentionOrder.gift_code3==null){  x_oCmd.Parameters.Add("@gift_code3", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_code3", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.gift_code3; }
                if(x_oMobileRetentionOrder.normal_rebate_type==null){  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.normal_rebate_type; }
                if(x_oMobileRetentionOrder.gift_desc2==null){  x_oCmd.Parameters.Add("@gift_desc2", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_desc2", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.gift_desc2; }
                if(x_oMobileRetentionOrder.monthly_bank_account_branch_code==null){  x_oCmd.Parameters.Add("@monthly_bank_account_branch_code", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_bank_account_branch_code", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.monthly_bank_account_branch_code; }
                if(x_oMobileRetentionOrder.remarks==null){  x_oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.Text).Value=x_oMobileRetentionOrder.remarks; }
                if(x_oMobileRetentionOrder.accept==null){  x_oCmd.Parameters.Add("@accept", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@accept", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.accept; }
                if(x_oMobileRetentionOrder.delivery_exchange==null){  x_oCmd.Parameters.Add("@delivery_exchange", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@delivery_exchange", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.delivery_exchange; }
                if(x_oMobileRetentionOrder.gift_code2==null){  x_oCmd.Parameters.Add("@gift_code2", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_code2", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.gift_code2; }
                if(x_oMobileRetentionOrder.prepayment_waive==null){  x_oCmd.Parameters.Add("@prepayment_waive", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@prepayment_waive", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionOrder.prepayment_waive; }
                if(x_oMobileRetentionOrder.existing_smart_phone_imei==null){  x_oCmd.Parameters.Add("@existing_smart_phone_imei", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@existing_smart_phone_imei", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.existing_smart_phone_imei; }
                if(x_oMobileRetentionOrder.cust_name==null){  x_oCmd.Parameters.Add("@cust_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cust_name", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.cust_name; }
                if(x_oMobileRetentionOrder.upgrade_sponsorships_amount==null){  x_oCmd.Parameters.Add("@upgrade_sponsorships_amount", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_sponsorships_amount", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.upgrade_sponsorships_amount; }
                if(x_oMobileRetentionOrder.bill_medium_waive==null){  x_oCmd.Parameters.Add("@bill_medium_waive", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bill_medium_waive", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionOrder.bill_medium_waive; }
                if(x_oMobileRetentionOrder.delivery_exchange_location==null){  x_oCmd.Parameters.Add("@delivery_exchange_location", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@delivery_exchange_location", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.delivery_exchange_location; }
                if(x_oMobileRetentionOrder.hs_offer_type_id==null){  x_oCmd.Parameters.Add("@hs_offer_type_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hs_offer_type_id", global::System.Data.SqlDbType.Int).Value=x_oMobileRetentionOrder.hs_offer_type_id; }
                if(x_oMobileRetentionOrder.extra_rebate_amount==null){  x_oCmd.Parameters.Add("@extra_rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@extra_rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.extra_rebate_amount; }
                if(x_oMobileRetentionOrder.rebate==null){  x_oCmd.Parameters.Add("@rebate", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rebate", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionOrder.rebate; }
                if(x_oMobileRetentionOrder.upgrade_type==null){  x_oCmd.Parameters.Add("@upgrade_type", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_type", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.upgrade_type; }
                if(x_oMobileRetentionOrder.go_wireless==null){  x_oCmd.Parameters.Add("@go_wireless", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@go_wireless", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.go_wireless; }
                if(x_oMobileRetentionOrder.extra_rebate==null){  x_oCmd.Parameters.Add("@extra_rebate", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@extra_rebate", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.extra_rebate; }
                if(x_oMobileRetentionOrder.plan_eff==null){  x_oCmd.Parameters.Add("@plan_eff", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@plan_eff", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionOrder.plan_eff; }
                if(x_oMobileRetentionOrder.card_exp_year==null){  x_oCmd.Parameters.Add("@card_exp_year", global::System.Data.SqlDbType.NVarChar,4).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@card_exp_year", global::System.Data.SqlDbType.NVarChar,4).Value=x_oMobileRetentionOrder.card_exp_year; }
                if(x_oMobileRetentionOrder.upgrade_existing_contract_sdate==null){  x_oCmd.Parameters.Add("@upgrade_existing_contract_sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@upgrade_existing_contract_sdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrder.upgrade_existing_contract_sdate; }
                if(x_oMobileRetentionOrder.ord_place_hkid==null){  x_oCmd.Parameters.Add("@ord_place_hkid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ord_place_hkid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.ord_place_hkid; }
                if(x_oMobileRetentionOrder.register_address==null){  x_oCmd.Parameters.Add("@register_address", global::System.Data.SqlDbType.NVarChar,200).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@register_address", global::System.Data.SqlDbType.NVarChar,200).Value=x_oMobileRetentionOrder.register_address; }
                if(x_oMobileRetentionOrder.gender==null){  x_oCmd.Parameters.Add("@gender", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gender", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.gender; }
                if(x_oMobileRetentionOrder.lob_ac==null){  x_oCmd.Parameters.Add("@lob_ac", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@lob_ac", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionOrder.lob_ac; }
                if(x_oMobileRetentionOrder.sim_mrt_no==null){  x_oCmd.Parameters.Add("@sim_mrt_no", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sim_mrt_no", global::System.Data.SqlDbType.Int).Value=x_oMobileRetentionOrder.sim_mrt_no; }
                if(x_oMobileRetentionOrder.redemption_notice_option==null){  x_oCmd.Parameters.Add("@redemption_notice_option", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@redemption_notice_option", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.redemption_notice_option; }
                if(x_oMobileRetentionOrder.delivery_collection_type==null){  x_oCmd.Parameters.Add("@delivery_collection_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@delivery_collection_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.delivery_collection_type; }
                if(x_oMobileRetentionOrder.action_date==null){  x_oCmd.Parameters.Add("@action_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@action_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrder.action_date; }
                if(x_oMobileRetentionOrder.third_party_id_type==null){  x_oCmd.Parameters.Add("@third_party_id_type", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@third_party_id_type", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionOrder.third_party_id_type; }
                if(x_oMobileRetentionOrder.org_ftg==null){  x_oCmd.Parameters.Add("@org_ftg", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@org_ftg", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.org_ftg; }
                if(x_oMobileRetentionOrder.upgrade_service_tenure==null){  x_oCmd.Parameters.Add("@upgrade_service_tenure", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_service_tenure", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.upgrade_service_tenure; }
                if(x_oMobileRetentionOrder.monthly_payment_type==null){  x_oCmd.Parameters.Add("@monthly_payment_type", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_payment_type", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.monthly_payment_type; }
                if(x_oMobileRetentionOrder.contact_no==null){  x_oCmd.Parameters.Add("@contact_no", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@contact_no", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionOrder.contact_no; }
                if(x_oMobileRetentionOrder.org_mrt==null){  x_oCmd.Parameters.Add("@org_mrt", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@org_mrt", global::System.Data.SqlDbType.Int).Value=x_oMobileRetentionOrder.org_mrt; }
                if(x_oMobileRetentionOrder.sim_item_name==null){  x_oCmd.Parameters.Add("@sim_item_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sim_item_name", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.sim_item_name; }
                if(x_oMobileRetentionOrder.pay_method==null){  x_oCmd.Parameters.Add("@pay_method", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@pay_method", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.pay_method; }
                if(x_oMobileRetentionOrder.hs_model==null){  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.hs_model; }
                if(x_oMobileRetentionOrder.gift_code==null){  x_oCmd.Parameters.Add("@gift_code", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_code", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.gift_code; }
                if(x_oMobileRetentionOrder.monthly_bank_account_hkid==null){  x_oCmd.Parameters.Add("@monthly_bank_account_hkid", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_bank_account_hkid", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionOrder.monthly_bank_account_hkid; }
                if(x_oMobileRetentionOrder.extra_offer==null){  x_oCmd.Parameters.Add("@extra_offer", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@extra_offer", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.extra_offer; }
                if(x_oMobileRetentionOrder.monthly_bank_account_no==null){  x_oCmd.Parameters.Add("@monthly_bank_account_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_bank_account_no", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.monthly_bank_account_no; }
                if(x_oMobileRetentionOrder.first_month_license_fee==null){  x_oCmd.Parameters.Add("@first_month_license_fee", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@first_month_license_fee", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.first_month_license_fee; }
                if(x_oMobileRetentionOrder.retrieve_cnt==null){  x_oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int).Value=x_oMobileRetentionOrder.retrieve_cnt; }
                if(x_oMobileRetentionOrder.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrder.ddate; }
                if(x_oMobileRetentionOrder.s_premium2==null){  x_oCmd.Parameters.Add("@s_premium2", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@s_premium2", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.s_premium2; }
                if(x_oMobileRetentionOrder.monthly_bank_account_id_type==null){  x_oCmd.Parameters.Add("@monthly_bank_account_id_type", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@monthly_bank_account_id_type", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.monthly_bank_account_id_type; }
                if(x_oMobileRetentionOrder.card_type==null){  x_oCmd.Parameters.Add("@card_type", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@card_type", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionOrder.card_type; }
                if(x_oMobileRetentionOrder.next_bill==null){  x_oCmd.Parameters.Add("@next_bill", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@next_bill", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionOrder.next_bill; }
                if(x_oMobileRetentionOrder.pcd_paid_go_wireless==null){  x_oCmd.Parameters.Add("@pcd_paid_go_wireless", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@pcd_paid_go_wireless", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionOrder.pcd_paid_go_wireless; }
                if(x_oMobileRetentionOrder.upgrade_rebate_calculation==null){  x_oCmd.Parameters.Add("@upgrade_rebate_calculation", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_rebate_calculation", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.upgrade_rebate_calculation; }
                if(x_oMobileRetentionOrder.ext_place_tel==null){  x_oCmd.Parameters.Add("@ext_place_tel", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ext_place_tel", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.ext_place_tel; }
                if(x_oMobileRetentionOrder.m_3rd_hkid==null){  x_oCmd.Parameters.Add("@m_3rd_hkid", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_3rd_hkid", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionOrder.m_3rd_hkid; }
                if(x_oMobileRetentionOrder.retention_type==null){  x_oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.retention_type; }
                if(x_oMobileRetentionOrder.cooling_date==null){  x_oCmd.Parameters.Add("@cooling_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cooling_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrder.cooling_date; }
                if(x_oMobileRetentionOrder.aig_gift==null){  x_oCmd.Parameters.Add("@aig_gift", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@aig_gift", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.aig_gift; }
                if(x_oMobileRetentionOrder.cust_staff_no==null){  x_oCmd.Parameters.Add("@cust_staff_no", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cust_staff_no", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.cust_staff_no; }
                if(x_oMobileRetentionOrder.family_name==null){  x_oCmd.Parameters.Add("@family_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@family_name", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.family_name; }
                if(x_oMobileRetentionOrder.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrder.cdate; }
                if(x_oMobileRetentionOrder.status_by_cs_admin==null){  x_oCmd.Parameters.Add("@status_by_cs_admin", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@status_by_cs_admin", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.status_by_cs_admin; }
                if(x_oMobileRetentionOrder.given_name==null){  x_oCmd.Parameters.Add("@given_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@given_name", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.given_name; }
                if(x_oMobileRetentionOrder.vip_case==null){  x_oCmd.Parameters.Add("@vip_case", global::System.Data.SqlDbType.NVarChar,200).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@vip_case", global::System.Data.SqlDbType.NVarChar,200).Value=x_oMobileRetentionOrder.vip_case; }
                if(x_oMobileRetentionOrder.org_fee==null){  x_oCmd.Parameters.Add("@org_fee", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@org_fee", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.org_fee; }
                if(x_oMobileRetentionOrder.s_premium3==null){  x_oCmd.Parameters.Add("@s_premium3", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@s_premium3", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.s_premium3; }
                if(x_oMobileRetentionOrder.log_date==null){  x_oCmd.Parameters.Add("@log_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@log_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrder.log_date; }
                if(x_oMobileRetentionOrder.extn==null){  x_oCmd.Parameters.Add("@extn", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@extn", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.extn; }
                if(x_oMobileRetentionOrder.d_time==null){  x_oCmd.Parameters.Add("@d_time", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@d_time", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.d_time; }
                if(x_oMobileRetentionOrder.bank_name==null){  x_oCmd.Parameters.Add("@bank_name", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bank_name", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.bank_name; }
                if(x_oMobileRetentionOrder.delivery_exchange_option==null){  x_oCmd.Parameters.Add("@delivery_exchange_option", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@delivery_exchange_option", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.delivery_exchange_option; }
                if(x_oMobileRetentionOrder.upgrade_service_account_no==null){  x_oCmd.Parameters.Add("@upgrade_service_account_no", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@upgrade_service_account_no", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.upgrade_service_account_no; }
                if(x_oMobileRetentionOrder.old_ord_id==null){  x_oCmd.Parameters.Add("@old_ord_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@old_ord_id", global::System.Data.SqlDbType.Int).Value=x_oMobileRetentionOrder.old_ord_id; }
                if(x_oMobileRetentionOrder.m_card_no==null){  x_oCmd.Parameters.Add("@m_card_no", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_card_no", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionOrder.m_card_no; }
                if(x_oMobileRetentionOrder.existing_contract_end_date==null){  x_oCmd.Parameters.Add("@existing_contract_end_date", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@existing_contract_end_date", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionOrder.existing_contract_end_date; }
                if(x_oMobileRetentionOrder.con_eff_date==null){  x_oCmd.Parameters.Add("@con_eff_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@con_eff_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrder.con_eff_date; }
                if(x_oMobileRetentionOrder.m_3rd_hkid2==null){  x_oCmd.Parameters.Add("@m_3rd_hkid2", global::System.Data.SqlDbType.NVarChar,1).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_3rd_hkid2", global::System.Data.SqlDbType.NVarChar,1).Value=x_oMobileRetentionOrder.m_3rd_hkid2; }
                if(x_oMobileRetentionOrder.amount==null){  x_oCmd.Parameters.Add("@amount", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@amount", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.amount; }
                if(x_oMobileRetentionOrder.m_3rd_id_type==null){  x_oCmd.Parameters.Add("@m_3rd_id_type", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_3rd_id_type", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.m_3rd_id_type; }
                if(x_oMobileRetentionOrder.id_type==null){  x_oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.id_type; }
                if(x_oMobileRetentionOrder.rate_plan==null){  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.rate_plan; }
                if(x_oMobileRetentionOrder.channel==null){  x_oCmd.Parameters.Add("@channel", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@channel", global::System.Data.SqlDbType.Char,10).Value=x_oMobileRetentionOrder.channel; }
                if(x_oMobileRetentionOrder.action_eff_date==null){  x_oCmd.Parameters.Add("@action_eff_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@action_eff_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrder.action_eff_date; }
                if(x_oMobileRetentionOrder.issue_type==null){  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.issue_type; }
                if(x_oMobileRetentionOrder.free_mon==null){  x_oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionOrder.free_mon; }
                if(x_oMobileRetentionOrder.plan_eff_date==null){  x_oCmd.Parameters.Add("@plan_eff_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@plan_eff_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrder.plan_eff_date; }
                if(x_oMobileRetentionOrder.teamcode==null){  x_oCmd.Parameters.Add("@teamcode", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@teamcode", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.teamcode; }
                if(x_oMobileRetentionOrder.bill_medium==null){  x_oCmd.Parameters.Add("@bill_medium", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bill_medium", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.bill_medium; }
                if(x_oMobileRetentionOrder.edf_no==null){  x_oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,15).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,15).Value=x_oMobileRetentionOrder.edf_no; }
                if(x_oMobileRetentionOrder.ord_place_by==null){  x_oCmd.Parameters.Add("@ord_place_by", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ord_place_by", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.ord_place_by; }
                if(x_oMobileRetentionOrder.cancel_renew==null){  x_oCmd.Parameters.Add("@cancel_renew", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cancel_renew", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.cancel_renew; }
                if(x_oMobileRetentionOrder.preferred_languages==null){  x_oCmd.Parameters.Add("@preferred_languages", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@preferred_languages", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionOrder.preferred_languages; }
                if(x_oMobileRetentionOrder.hkid==null){  x_oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileRetentionOrder.hkid; }
                if(x_oMobileRetentionOrder.card_holder==null){  x_oCmd.Parameters.Add("@card_holder", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@card_holder", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.card_holder; }
                if(x_oMobileRetentionOrder.ac_no==null){  x_oCmd.Parameters.Add("@ac_no", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ac_no", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionOrder.ac_no; }
                if(x_oMobileRetentionOrder.bill_cut_num==null){  x_oCmd.Parameters.Add("@bill_cut_num", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bill_cut_num", global::System.Data.SqlDbType.Int).Value=x_oMobileRetentionOrder.bill_cut_num; }
                if(x_oMobileRetentionOrder.premium==null){  x_oCmd.Parameters.Add("@premium", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@premium", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.premium; }
                if(x_oMobileRetentionOrder.del_remark==null){  x_oCmd.Parameters.Add("@del_remark", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@del_remark", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.del_remark; }
                if(x_oMobileRetentionOrder.gift_imei2==null){  x_oCmd.Parameters.Add("@gift_imei2", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gift_imei2", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.gift_imei2; }
                if(x_oMobileRetentionOrder.reasons==null){  x_oCmd.Parameters.Add("@reasons", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@reasons", global::System.Data.SqlDbType.Text).Value=x_oMobileRetentionOrder.reasons; }
                if(x_oMobileRetentionOrder.language==null){  x_oCmd.Parameters.Add("@language", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@language", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileRetentionOrder.language; }
                if(x_oMobileRetentionOrder.rebate_amount==null){  x_oCmd.Parameters.Add("@rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.rebate_amount; }
                if(x_oMobileRetentionOrder.ord_place_id_type==null){  x_oCmd.Parameters.Add("@ord_place_id_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ord_place_id_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.ord_place_id_type; }
                if(x_oMobileRetentionOrder.m_3rd_contact_no==null){  x_oCmd.Parameters.Add("@m_3rd_contact_no", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@m_3rd_contact_no", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileRetentionOrder.m_3rd_contact_no; }
                if(x_oMobileRetentionOrder.staff_no==null){  x_oCmd.Parameters.Add("@staff_no", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@staff_no", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileRetentionOrder.staff_no; }
                if(x_oMobileRetentionOrder.sp_d_date==null){  x_oCmd.Parameters.Add("@sp_d_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@sp_d_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrder.sp_d_date; }
                if(x_oMobileRetentionOrder.bundle_name==null){  x_oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.bundle_name; }
                if(x_oMobileRetentionOrder.accessory_waive==null){  x_oCmd.Parameters.Add("@accessory_waive", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@accessory_waive", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionOrder.accessory_waive; }
                if(x_oMobileRetentionOrder.sim_item_code==null){  x_oCmd.Parameters.Add("@sim_item_code", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sim_item_code", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrder.sim_item_code; }
                if(x_oMobileRetentionOrder.cust_type==null){  x_oCmd.Parameters.Add("@cust_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cust_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.cust_type; }
                if(x_oMobileRetentionOrder.card_ref_no==null){  x_oCmd.Parameters.Add("@card_ref_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@card_ref_no", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrder.card_ref_no; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["MobileRetentionOrder_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["MobileRetentionOrder_LASTID"].ToString()) && int.TryParse(_oData["MobileRetentionOrder_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sGift_imei,string x_sS_premium4,string x_sGift_desc4,string x_sAccessory_desc,string x_sAction_required,global::System.Nullable<DateTime> x_dVas_eff_date,string x_sMonthly_bank_account_bank_code,string x_sSpecial_handling_dummy_code,string x_sM_card_exp_year,string x_sRemarks2PY,string x_sTrade_field,string x_sOrd_place_tel,string x_sOrd_place_id_type,string x_sCooling_offer,string x_sUpgrade_handset_offer_rebate_schedule,string x_sChange_payment_type,global::System.Nullable<DateTime> x_dDate_of_birth,string x_sContact_person,string x_sExtra_d_charge,string x_sTl_name,global::System.Nullable<bool> x_bFast_start,string x_sSp_ref_no,global::System.Nullable<DateTime> x_dEdate,string x_sExist_cust_plan,string x_sOrd_place_rel,global::System.Nullable<int> x_iMrt_no,string x_sImei_no,string x_sExisting_smart_phone_model,string x_sGift_code3,string x_sBank_code,string x_sPos_ref_no,global::System.Nullable<DateTime> x_dBill_cut_date,string x_sGift_imei3,string x_sExist_plan,global::System.Nullable<bool> x_bWaive,string x_sProgram,string x_sFirst_month_fee,string x_sR_offer,string x_sCid,string x_sDid,string x_sFtg_tenure,string x_sCon_per,string x_sGift_code4,string x_sEasywatch_type,string x_sSms_mrt,string x_sMonthly_payment_method,string x_sRemarks2EDF,string x_sGift_desc3,string x_sGift_imei4,global::System.Nullable<int> x_iOld_ord_id,string x_sMonthly_bank_account_hkid2,global::System.Nullable<DateTime> x_dD_date,string x_sGift_desc,string x_sSalesmancode,string x_sPool,global::System.Nullable<long> x_lCn_mrt_no,string x_sAccessory_imei,string x_sThird_party_credit_card,string x_sCard_ref_no,string x_sSpecial_approval,global::System.Nullable<DateTime> x_dUpgrade_existing_contract_edate,string x_sAccessory_code,string x_sBill_medium,string x_sS_premium,string x_sRef_staff_no,string x_sAccessory_price,string x_sM_card_exp_month,string x_sInstallment_period,string x_sM_card_type,string x_sEasywatch_ord_id,global::System.Nullable<bool> x_bNormal_rebate,string x_sM_rebate_amount,string x_sM_card_holder2,string x_sBill_medium_email,global::System.Nullable<bool> x_bActive,string x_sS_premium1,string x_sCard_exp_month,string x_sOb_program_id,string x_sSku,string x_sRef_salesmancode,string x_sGo_wireless_package_code,string x_sThird_party_hkid,string x_sUpgrade_existing_pccw_customer,string x_sD_address,string x_sUpgrade_registered_mobile_no,string x_sUpgrade_existing_customer_type,string x_sNormal_rebate_type,string x_sGift_desc2,string x_sMonthly_bank_account_branch_code,string x_sRemarks,string x_sAccept,string x_sDelivery_exchange,string x_sGift_code2,global::System.Nullable<bool> x_bPrepayment_waive,string x_sExisting_smart_phone_imei,string x_sCust_name,string x_sCust_type,string x_sUpgrade_sponsorships_amount,global::System.Nullable<bool> x_bBill_medium_waive,string x_sDelivery_exchange_location,global::System.Nullable<int> x_iHs_offer_type_id,string x_sOrg_fee,string x_sRebate,string x_sUpgrade_type,string x_sGo_wireless,string x_sExtra_rebate,string x_sPlan_eff,string x_sExtra_rebate_amount,string x_sCard_exp_year,global::System.Nullable<DateTime> x_dUpgrade_existing_contract_sdate,string x_sOrd_place_hkid,string x_sRegister_address,string x_sGender,string x_sLob_ac,global::System.Nullable<int> x_iSim_mrt_no,string x_sRedemption_notice_option,string x_sDelivery_collection_type,global::System.Nullable<DateTime> x_dAction_date,string x_sThird_party_id_type,string x_sOrg_ftg,string x_sUpgrade_service_tenure,string x_sMonthly_payment_type,string x_sContact_no,global::System.Nullable<int> x_iOrg_mrt,string x_sSim_item_name,string x_sPay_method,string x_sHs_model,string x_sGift_code,string x_sMonthly_bank_account_hkid,string x_sExtra_offer,string x_sMonthly_bank_account_no,string x_sFirst_month_license_fee,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dDdate,string x_sS_premium2,string x_sMonthly_bank_account_id_type,string x_sCard_type,global::System.Nullable<bool> x_bNext_bill,global::System.Nullable<bool> x_bPcd_paid_go_wireless,string x_sUpgrade_rebate_calculation,string x_sExt_place_tel,string x_sM_3rd_hkid,string x_sRetention_type,global::System.Nullable<DateTime> x_dCooling_date,string x_sAig_gift,string x_sCust_staff_no,string x_sFamily_name,global::System.Nullable<DateTime> x_dCdate,string x_sStatus_by_cs_admin,string x_sSim_item_number,string x_sVip_case,string x_sGiven_name,global::System.Nullable<DateTime> x_dLog_date,string x_sExtn,string x_sD_time,string x_sBank_name,string x_sDelivery_exchange_option,string x_sUpgrade_service_account_no,string x_sAction_of_rate_plan_effective,string x_sM_card_no,string x_sExisting_contract_end_date,global::System.Nullable<DateTime> x_dCon_eff_date,string x_sM_3rd_hkid2,string x_sAmount,string x_sId_type,string x_sRate_plan,string x_sChannel,global::System.Nullable<DateTime> x_dAction_eff_date,string x_sIssue_type,string x_sFree_mon,global::System.Nullable<DateTime> x_dPlan_eff_date,string x_sDel_remark,string x_sTeamcode,string x_sStaff_name,string x_sEdf_no,string x_sOrd_place_by,string x_sCancel_renew,string x_sPreferred_languages,string x_sHkid,string x_sCard_no,string x_sAc_no,global::System.Nullable<int> x_iBill_cut_num,string x_sPremium,string x_sM_3rd_id_type,string x_sGift_imei2,string x_sReasons,string x_sLanguage,string x_sRebate_amount,string x_sLob,string x_sM_3rd_contact_no,string x_sStaff_no,string x_sS_premium3,global::System.Nullable<DateTime> x_dSp_d_date,string x_sBundle_name,global::System.Nullable<bool> x_bAccessory_waive,string x_sSim_item_code,string x_sMonthly_bank_account_holder,string x_sCard_holder)
        {
            int _oLastID;
            MobileRetentionOrder _oMobileRetentionOrder=MobileRetentionOrderRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileRetentionOrder.gift_imei=x_sGift_imei;
            _oMobileRetentionOrder.s_premium4=x_sS_premium4;
            _oMobileRetentionOrder.gift_desc4=x_sGift_desc4;
            _oMobileRetentionOrder.accessory_desc=x_sAccessory_desc;
            _oMobileRetentionOrder.action_required=x_sAction_required;
            _oMobileRetentionOrder.vas_eff_date=x_dVas_eff_date;
            _oMobileRetentionOrder.monthly_bank_account_bank_code=x_sMonthly_bank_account_bank_code;
            _oMobileRetentionOrder.special_handling_dummy_code=x_sSpecial_handling_dummy_code;
            _oMobileRetentionOrder.m_card_exp_year=x_sM_card_exp_year;
            _oMobileRetentionOrder.remarks2PY=x_sRemarks2PY;
            _oMobileRetentionOrder.trade_field=x_sTrade_field;
            _oMobileRetentionOrder.ord_place_tel=x_sOrd_place_tel;
            _oMobileRetentionOrder.ord_place_id_type=x_sOrd_place_id_type;
            _oMobileRetentionOrder.cooling_offer=x_sCooling_offer;
            _oMobileRetentionOrder.upgrade_handset_offer_rebate_schedule=x_sUpgrade_handset_offer_rebate_schedule;
            _oMobileRetentionOrder.change_payment_type=x_sChange_payment_type;
            _oMobileRetentionOrder.date_of_birth=x_dDate_of_birth;
            _oMobileRetentionOrder.contact_person=x_sContact_person;
            _oMobileRetentionOrder.extra_d_charge=x_sExtra_d_charge;
            _oMobileRetentionOrder.tl_name=x_sTl_name;
            _oMobileRetentionOrder.fast_start=x_bFast_start;
            _oMobileRetentionOrder.sp_ref_no=x_sSp_ref_no;
            _oMobileRetentionOrder.edate=x_dEdate;
            _oMobileRetentionOrder.exist_cust_plan=x_sExist_cust_plan;
            _oMobileRetentionOrder.ord_place_rel=x_sOrd_place_rel;
            _oMobileRetentionOrder.mrt_no=x_iMrt_no;
            _oMobileRetentionOrder.imei_no=x_sImei_no;
            _oMobileRetentionOrder.existing_smart_phone_model=x_sExisting_smart_phone_model;
            _oMobileRetentionOrder.gift_code3=x_sGift_code3;
            _oMobileRetentionOrder.bank_code=x_sBank_code;
            _oMobileRetentionOrder.pos_ref_no=x_sPos_ref_no;
            _oMobileRetentionOrder.bill_cut_date=x_dBill_cut_date;
            _oMobileRetentionOrder.gift_imei3=x_sGift_imei3;
            _oMobileRetentionOrder.exist_plan=x_sExist_plan;
            _oMobileRetentionOrder.waive=x_bWaive;
            _oMobileRetentionOrder.program=x_sProgram;
            _oMobileRetentionOrder.first_month_fee=x_sFirst_month_fee;
            _oMobileRetentionOrder.r_offer=x_sR_offer;
            _oMobileRetentionOrder.cid=x_sCid;
            _oMobileRetentionOrder.did=x_sDid;
            _oMobileRetentionOrder.ftg_tenure=x_sFtg_tenure;
            _oMobileRetentionOrder.con_per=x_sCon_per;
            _oMobileRetentionOrder.gift_code4=x_sGift_code4;
            _oMobileRetentionOrder.easywatch_type=x_sEasywatch_type;
            _oMobileRetentionOrder.sms_mrt=x_sSms_mrt;
            _oMobileRetentionOrder.monthly_payment_method=x_sMonthly_payment_method;
            _oMobileRetentionOrder.remarks2EDF=x_sRemarks2EDF;
            _oMobileRetentionOrder.gift_desc3=x_sGift_desc3;
            _oMobileRetentionOrder.gift_imei4=x_sGift_imei4;
            _oMobileRetentionOrder.old_ord_id=x_iOld_ord_id;
            _oMobileRetentionOrder.monthly_bank_account_hkid2=x_sMonthly_bank_account_hkid2;
            _oMobileRetentionOrder.d_date=x_dD_date;
            _oMobileRetentionOrder.gift_desc=x_sGift_desc;
            _oMobileRetentionOrder.salesmancode=x_sSalesmancode;
            _oMobileRetentionOrder.pool=x_sPool;
            _oMobileRetentionOrder.cn_mrt_no=x_lCn_mrt_no;
            _oMobileRetentionOrder.accessory_imei=x_sAccessory_imei;
            _oMobileRetentionOrder.third_party_credit_card=x_sThird_party_credit_card;
            _oMobileRetentionOrder.card_ref_no=x_sCard_ref_no;
            _oMobileRetentionOrder.special_approval=x_sSpecial_approval;
            _oMobileRetentionOrder.upgrade_existing_contract_edate=x_dUpgrade_existing_contract_edate;
            _oMobileRetentionOrder.accessory_code=x_sAccessory_code;
            _oMobileRetentionOrder.bill_medium=x_sBill_medium;
            _oMobileRetentionOrder.s_premium=x_sS_premium;
            _oMobileRetentionOrder.ref_staff_no=x_sRef_staff_no;
            _oMobileRetentionOrder.accessory_price=x_sAccessory_price;
            _oMobileRetentionOrder.m_card_exp_month=x_sM_card_exp_month;
            _oMobileRetentionOrder.installment_period=x_sInstallment_period;
            _oMobileRetentionOrder.m_card_type=x_sM_card_type;
            _oMobileRetentionOrder.easywatch_ord_id=x_sEasywatch_ord_id;
            _oMobileRetentionOrder.normal_rebate=x_bNormal_rebate;
            _oMobileRetentionOrder.m_rebate_amount=x_sM_rebate_amount;
            _oMobileRetentionOrder.m_card_holder2=x_sM_card_holder2;
            _oMobileRetentionOrder.bill_medium_email=x_sBill_medium_email;
            _oMobileRetentionOrder.active=x_bActive;
            _oMobileRetentionOrder.s_premium1=x_sS_premium1;
            _oMobileRetentionOrder.card_exp_month=x_sCard_exp_month;
            _oMobileRetentionOrder.ob_program_id=x_sOb_program_id;
            _oMobileRetentionOrder.sku=x_sSku;
            _oMobileRetentionOrder.ref_salesmancode=x_sRef_salesmancode;
            _oMobileRetentionOrder.go_wireless_package_code=x_sGo_wireless_package_code;
            _oMobileRetentionOrder.third_party_hkid=x_sThird_party_hkid;
            _oMobileRetentionOrder.upgrade_existing_pccw_customer=x_sUpgrade_existing_pccw_customer;
            _oMobileRetentionOrder.d_address=x_sD_address;
            _oMobileRetentionOrder.upgrade_registered_mobile_no=x_sUpgrade_registered_mobile_no;
            _oMobileRetentionOrder.upgrade_existing_customer_type=x_sUpgrade_existing_customer_type;
            _oMobileRetentionOrder.normal_rebate_type=x_sNormal_rebate_type;
            _oMobileRetentionOrder.gift_desc2=x_sGift_desc2;
            _oMobileRetentionOrder.monthly_bank_account_branch_code=x_sMonthly_bank_account_branch_code;
            _oMobileRetentionOrder.remarks=x_sRemarks;
            _oMobileRetentionOrder.accept=x_sAccept;
            _oMobileRetentionOrder.delivery_exchange=x_sDelivery_exchange;
            _oMobileRetentionOrder.gift_code2=x_sGift_code2;
            _oMobileRetentionOrder.prepayment_waive=x_bPrepayment_waive;
            _oMobileRetentionOrder.existing_smart_phone_imei=x_sExisting_smart_phone_imei;
            _oMobileRetentionOrder.cust_name=x_sCust_name;
            _oMobileRetentionOrder.cust_type=x_sCust_type;
            _oMobileRetentionOrder.upgrade_sponsorships_amount=x_sUpgrade_sponsorships_amount;
            _oMobileRetentionOrder.bill_medium_waive=x_bBill_medium_waive;
            _oMobileRetentionOrder.delivery_exchange_location=x_sDelivery_exchange_location;
            _oMobileRetentionOrder.hs_offer_type_id=x_iHs_offer_type_id;
            _oMobileRetentionOrder.org_fee=x_sOrg_fee;
            _oMobileRetentionOrder.rebate=x_sRebate;
            _oMobileRetentionOrder.upgrade_type=x_sUpgrade_type;
            _oMobileRetentionOrder.go_wireless=x_sGo_wireless;
            _oMobileRetentionOrder.extra_rebate=x_sExtra_rebate;
            _oMobileRetentionOrder.plan_eff=x_sPlan_eff;
            _oMobileRetentionOrder.extra_rebate_amount=x_sExtra_rebate_amount;
            _oMobileRetentionOrder.card_exp_year=x_sCard_exp_year;
            _oMobileRetentionOrder.upgrade_existing_contract_sdate=x_dUpgrade_existing_contract_sdate;
            _oMobileRetentionOrder.ord_place_hkid=x_sOrd_place_hkid;
            _oMobileRetentionOrder.register_address=x_sRegister_address;
            _oMobileRetentionOrder.gender=x_sGender;
            _oMobileRetentionOrder.lob_ac=x_sLob_ac;
            _oMobileRetentionOrder.sim_mrt_no=x_iSim_mrt_no;
            _oMobileRetentionOrder.redemption_notice_option=x_sRedemption_notice_option;
            _oMobileRetentionOrder.delivery_collection_type=x_sDelivery_collection_type;
            _oMobileRetentionOrder.action_date=x_dAction_date;
            _oMobileRetentionOrder.third_party_id_type=x_sThird_party_id_type;
            _oMobileRetentionOrder.org_ftg=x_sOrg_ftg;
            _oMobileRetentionOrder.upgrade_service_tenure=x_sUpgrade_service_tenure;
            _oMobileRetentionOrder.monthly_payment_type=x_sMonthly_payment_type;
            _oMobileRetentionOrder.contact_no=x_sContact_no;
            _oMobileRetentionOrder.org_mrt=x_iOrg_mrt;
            _oMobileRetentionOrder.sim_item_name=x_sSim_item_name;
            _oMobileRetentionOrder.pay_method=x_sPay_method;
            _oMobileRetentionOrder.hs_model=x_sHs_model;
            _oMobileRetentionOrder.gift_code=x_sGift_code;
            _oMobileRetentionOrder.monthly_bank_account_hkid=x_sMonthly_bank_account_hkid;
            _oMobileRetentionOrder.extra_offer=x_sExtra_offer;
            _oMobileRetentionOrder.monthly_bank_account_no=x_sMonthly_bank_account_no;
            _oMobileRetentionOrder.first_month_license_fee=x_sFirst_month_license_fee;
            _oMobileRetentionOrder.retrieve_cnt=x_iRetrieve_cnt;
            _oMobileRetentionOrder.ddate=x_dDdate;
            _oMobileRetentionOrder.s_premium2=x_sS_premium2;
            _oMobileRetentionOrder.monthly_bank_account_id_type=x_sMonthly_bank_account_id_type;
            _oMobileRetentionOrder.card_type=x_sCard_type;
            _oMobileRetentionOrder.next_bill=x_bNext_bill;
            _oMobileRetentionOrder.pcd_paid_go_wireless=x_bPcd_paid_go_wireless;
            _oMobileRetentionOrder.upgrade_rebate_calculation=x_sUpgrade_rebate_calculation;
            _oMobileRetentionOrder.ext_place_tel=x_sExt_place_tel;
            _oMobileRetentionOrder.m_3rd_hkid=x_sM_3rd_hkid;
            _oMobileRetentionOrder.retention_type=x_sRetention_type;
            _oMobileRetentionOrder.cooling_date=x_dCooling_date;
            _oMobileRetentionOrder.aig_gift=x_sAig_gift;
            _oMobileRetentionOrder.cust_staff_no=x_sCust_staff_no;
            _oMobileRetentionOrder.family_name=x_sFamily_name;
            _oMobileRetentionOrder.cdate=x_dCdate;
            _oMobileRetentionOrder.status_by_cs_admin=x_sStatus_by_cs_admin;
            _oMobileRetentionOrder.sim_item_number=x_sSim_item_number;
            _oMobileRetentionOrder.vip_case=x_sVip_case;
            _oMobileRetentionOrder.given_name=x_sGiven_name;
            _oMobileRetentionOrder.log_date=x_dLog_date;
            _oMobileRetentionOrder.extn=x_sExtn;
            _oMobileRetentionOrder.d_time=x_sD_time;
            _oMobileRetentionOrder.bank_name=x_sBank_name;
            _oMobileRetentionOrder.delivery_exchange_option=x_sDelivery_exchange_option;
            _oMobileRetentionOrder.upgrade_service_account_no=x_sUpgrade_service_account_no;
            _oMobileRetentionOrder.action_of_rate_plan_effective=x_sAction_of_rate_plan_effective;
            _oMobileRetentionOrder.m_card_no=x_sM_card_no;
            _oMobileRetentionOrder.existing_contract_end_date=x_sExisting_contract_end_date;
            _oMobileRetentionOrder.con_eff_date=x_dCon_eff_date;
            _oMobileRetentionOrder.m_3rd_hkid2=x_sM_3rd_hkid2;
            _oMobileRetentionOrder.amount=x_sAmount;
            _oMobileRetentionOrder.id_type=x_sId_type;
            _oMobileRetentionOrder.rate_plan=x_sRate_plan;
            _oMobileRetentionOrder.channel=x_sChannel;
            _oMobileRetentionOrder.action_eff_date=x_dAction_eff_date;
            _oMobileRetentionOrder.issue_type=x_sIssue_type;
            _oMobileRetentionOrder.free_mon=x_sFree_mon;
            _oMobileRetentionOrder.plan_eff_date=x_dPlan_eff_date;
            _oMobileRetentionOrder.del_remark=x_sDel_remark;
            _oMobileRetentionOrder.teamcode=x_sTeamcode;
            _oMobileRetentionOrder.staff_name=x_sStaff_name;
            _oMobileRetentionOrder.edf_no=x_sEdf_no;
            _oMobileRetentionOrder.ord_place_by=x_sOrd_place_by;
            _oMobileRetentionOrder.cancel_renew=x_sCancel_renew;
            _oMobileRetentionOrder.preferred_languages=x_sPreferred_languages;
            _oMobileRetentionOrder.hkid=x_sHkid;
            _oMobileRetentionOrder.card_no=x_sCard_no;
            _oMobileRetentionOrder.ac_no=x_sAc_no;
            _oMobileRetentionOrder.bill_cut_num=x_iBill_cut_num;
            _oMobileRetentionOrder.premium=x_sPremium;
            _oMobileRetentionOrder.m_3rd_id_type=x_sM_3rd_id_type;
            _oMobileRetentionOrder.gift_imei2=x_sGift_imei2;
            _oMobileRetentionOrder.reasons=x_sReasons;
            _oMobileRetentionOrder.language=x_sLanguage;
            _oMobileRetentionOrder.rebate_amount=x_sRebate_amount;
            _oMobileRetentionOrder.lob=x_sLob;
            _oMobileRetentionOrder.m_3rd_contact_no=x_sM_3rd_contact_no;
            _oMobileRetentionOrder.staff_no=x_sStaff_no;
            _oMobileRetentionOrder.s_premium3=x_sS_premium3;
            _oMobileRetentionOrder.sp_d_date=x_dSp_d_date;
            _oMobileRetentionOrder.bundle_name=x_sBundle_name;
            _oMobileRetentionOrder.accessory_waive=x_bAccessory_waive;
            _oMobileRetentionOrder.sim_item_code=x_sSim_item_code;
            _oMobileRetentionOrder.monthly_bank_account_holder=x_sMonthly_bank_account_holder;
            _oMobileRetentionOrder.card_holder=x_sCard_holder;
            if(InsertWithLastID_SP(x_oDB, _oMobileRetentionOrder,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(MobileRetentionOrder x_oMobileRetentionOrder)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oMobileRetentionOrder, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileRetentionOrder x_oMobileRetentionOrder)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oMobileRetentionOrder, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileRetentionOrder)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (MobileRetentionOrder)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,MobileRetentionOrder x_oMobileRetentionOrder, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "MOBILERETENTIONORDER";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oMobileRetentionOrder,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileRetentionOrder x_oMobileRetentionOrder, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@gift_imei", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.gift_imei==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.gift_imei; }
                _oPar=x_oCmd.Parameters.Add("@s_premium4", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.s_premium4==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.s_premium4; }
                _oPar=x_oCmd.Parameters.Add("@upgrade_existing_customer_type", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.upgrade_existing_customer_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.upgrade_existing_customer_type; }
                _oPar=x_oCmd.Parameters.Add("@gift_desc4", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.gift_desc4==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.gift_desc4; }
                _oPar=x_oCmd.Parameters.Add("@accessory_desc", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.accessory_desc==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.accessory_desc; }
                _oPar=x_oCmd.Parameters.Add("@staff_name", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.staff_name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.staff_name; }
                _oPar=x_oCmd.Parameters.Add("@action_required", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.action_required==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.action_required; }
                _oPar=x_oCmd.Parameters.Add("@vas_eff_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.vas_eff_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionOrder.vas_eff_date; }
                _oPar=x_oCmd.Parameters.Add("@monthly_bank_account_bank_code", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.monthly_bank_account_bank_code==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.monthly_bank_account_bank_code; }
                _oPar=x_oCmd.Parameters.Add("@sim_item_number", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.sim_item_number==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.sim_item_number; }
                _oPar=x_oCmd.Parameters.Add("@special_handling_dummy_code", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.special_handling_dummy_code==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.special_handling_dummy_code; }
                _oPar=x_oCmd.Parameters.Add("@card_no", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.card_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.card_no; }
                _oPar=x_oCmd.Parameters.Add("@m_card_exp_year", global::System.Data.SqlDbType.NVarChar,4);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.m_card_exp_year==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.m_card_exp_year; }
                _oPar=x_oCmd.Parameters.Add("@bill_medium_email", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.bill_medium_email==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.bill_medium_email; }
                _oPar=x_oCmd.Parameters.Add("@remarks2PY", global::System.Data.SqlDbType.Text);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.remarks2PY==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.remarks2PY; }
                _oPar=x_oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.trade_field==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.trade_field; }
                _oPar=x_oCmd.Parameters.Add("@ord_place_tel", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.ord_place_tel==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.ord_place_tel; }
                _oPar=x_oCmd.Parameters.Add("@action_of_rate_plan_effective", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.action_of_rate_plan_effective==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.action_of_rate_plan_effective; }
                _oPar=x_oCmd.Parameters.Add("@cooling_offer", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.cooling_offer==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.cooling_offer; }
                _oPar=x_oCmd.Parameters.Add("@upgrade_handset_offer_rebate_schedule", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.upgrade_handset_offer_rebate_schedule==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.upgrade_handset_offer_rebate_schedule; }
                _oPar=x_oCmd.Parameters.Add("@change_payment_type", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.change_payment_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.change_payment_type; }
                _oPar=x_oCmd.Parameters.Add("@date_of_birth", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.date_of_birth==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionOrder.date_of_birth; }
                _oPar=x_oCmd.Parameters.Add("@contact_person", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.contact_person==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.contact_person; }
                _oPar=x_oCmd.Parameters.Add("@extra_d_charge", global::System.Data.SqlDbType.NVarChar,5);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.extra_d_charge==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.extra_d_charge; }
                _oPar=x_oCmd.Parameters.Add("@tl_name", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.tl_name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.tl_name; }
                _oPar=x_oCmd.Parameters.Add("@fast_start", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.fast_start==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.fast_start; }
                _oPar=x_oCmd.Parameters.Add("@sp_ref_no", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.sp_ref_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.sp_ref_no; }
                _oPar=x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.edate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionOrder.edate; }
                _oPar=x_oCmd.Parameters.Add("@exist_cust_plan", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.exist_cust_plan==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.exist_cust_plan; }
                _oPar=x_oCmd.Parameters.Add("@ord_place_rel", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.ord_place_rel==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.ord_place_rel; }
                _oPar=x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.mrt_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.mrt_no; }
                _oPar=x_oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,30);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.imei_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.imei_no; }
                _oPar=x_oCmd.Parameters.Add("@existing_smart_phone_model", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.existing_smart_phone_model==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.existing_smart_phone_model; }
                _oPar=x_oCmd.Parameters.Add("@bank_code", global::System.Data.SqlDbType.NVarChar,30);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.bank_code==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.bank_code; }
                _oPar=x_oCmd.Parameters.Add("@pos_ref_no", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.pos_ref_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.pos_ref_no; }
                _oPar=x_oCmd.Parameters.Add("@bill_cut_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.bill_cut_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionOrder.bill_cut_date; }
                _oPar=x_oCmd.Parameters.Add("@gift_imei3", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.gift_imei3==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.gift_imei3; }
                _oPar=x_oCmd.Parameters.Add("@exist_plan", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.exist_plan==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.exist_plan; }
                _oPar=x_oCmd.Parameters.Add("@waive", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.waive==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.waive; }
                _oPar=x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.program==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.program; }
                _oPar=x_oCmd.Parameters.Add("@first_month_fee", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.first_month_fee==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.first_month_fee; }
                _oPar=x_oCmd.Parameters.Add("@r_offer", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.r_offer==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.r_offer; }
                _oPar=x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.cid; }
                _oPar=x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.did==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.did; }
                _oPar=x_oCmd.Parameters.Add("@ftg_tenure", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.ftg_tenure==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.ftg_tenure; }
                _oPar=x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.con_per==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.con_per; }
                _oPar=x_oCmd.Parameters.Add("@gift_code4", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.gift_code4==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.gift_code4; }
                _oPar=x_oCmd.Parameters.Add("@easywatch_type", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.easywatch_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.easywatch_type; }
                _oPar=x_oCmd.Parameters.Add("@sms_mrt", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.sms_mrt==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.sms_mrt; }
                _oPar=x_oCmd.Parameters.Add("@monthly_payment_method", global::System.Data.SqlDbType.NVarChar,40);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.monthly_payment_method==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.monthly_payment_method; }
                _oPar=x_oCmd.Parameters.Add("@remarks2EDF", global::System.Data.SqlDbType.Text);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.remarks2EDF==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.remarks2EDF; }
                _oPar=x_oCmd.Parameters.Add("@gift_desc3", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.gift_desc3==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.gift_desc3; }
                _oPar=x_oCmd.Parameters.Add("@gift_imei4", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.gift_imei4==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.gift_imei4; }
                _oPar=x_oCmd.Parameters.Add("@monthly_bank_account_hkid2", global::System.Data.SqlDbType.NVarChar,1);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.monthly_bank_account_hkid2==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.monthly_bank_account_hkid2; }
                _oPar=x_oCmd.Parameters.Add("@d_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.d_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionOrder.d_date; }
                _oPar=x_oCmd.Parameters.Add("@gift_desc", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.gift_desc==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.gift_desc; }
                _oPar=x_oCmd.Parameters.Add("@pool", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.pool==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.pool; }
                _oPar=x_oCmd.Parameters.Add("@cn_mrt_no", global::System.Data.SqlDbType.BigInt);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.cn_mrt_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.cn_mrt_no; }
                _oPar=x_oCmd.Parameters.Add("@accessory_imei", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.accessory_imei==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.accessory_imei; }
                _oPar=x_oCmd.Parameters.Add("@third_party_credit_card", global::System.Data.SqlDbType.NVarChar,5);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.third_party_credit_card==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.third_party_credit_card; }
                _oPar=x_oCmd.Parameters.Add("@special_approval", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.special_approval==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.special_approval; }
                _oPar=x_oCmd.Parameters.Add("@upgrade_existing_contract_edate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.upgrade_existing_contract_edate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionOrder.upgrade_existing_contract_edate; }
                _oPar=x_oCmd.Parameters.Add("@accessory_code", global::System.Data.SqlDbType.NVarChar,70);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.accessory_code==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.accessory_code; }
                _oPar=x_oCmd.Parameters.Add("@s_premium", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.s_premium==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.s_premium; }
                _oPar=x_oCmd.Parameters.Add("@ref_staff_no", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.ref_staff_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.ref_staff_no; }
                _oPar=x_oCmd.Parameters.Add("@accessory_price", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.accessory_price==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.accessory_price; }
                _oPar=x_oCmd.Parameters.Add("@m_card_exp_month", global::System.Data.SqlDbType.NVarChar,2);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.m_card_exp_month==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.m_card_exp_month; }
                _oPar=x_oCmd.Parameters.Add("@installment_period", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.installment_period==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.installment_period; }
                _oPar=x_oCmd.Parameters.Add("@m_card_type", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.m_card_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.m_card_type; }
                _oPar=x_oCmd.Parameters.Add("@easywatch_ord_id", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.easywatch_ord_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.easywatch_ord_id; }
                _oPar=x_oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.normal_rebate==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.normal_rebate; }
                _oPar=x_oCmd.Parameters.Add("@m_rebate_amount", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.m_rebate_amount==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.m_rebate_amount; }
                _oPar=x_oCmd.Parameters.Add("@m_card_holder2", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.m_card_holder2==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.m_card_holder2; }
                _oPar=x_oCmd.Parameters.Add("@monthly_bank_account_holder", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.monthly_bank_account_holder==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.monthly_bank_account_holder; }
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.active; }
                _oPar=x_oCmd.Parameters.Add("@s_premium1", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.s_premium1==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.s_premium1; }
                _oPar=x_oCmd.Parameters.Add("@card_exp_month", global::System.Data.SqlDbType.NVarChar,2);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.card_exp_month==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.card_exp_month; }
                _oPar=x_oCmd.Parameters.Add("@ob_program_id", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.ob_program_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.ob_program_id; }
                _oPar=x_oCmd.Parameters.Add("@sku", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.sku==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.sku; }
                _oPar=x_oCmd.Parameters.Add("@salesmancode", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.salesmancode==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.salesmancode; }
                _oPar=x_oCmd.Parameters.Add("@go_wireless_package_code", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.go_wireless_package_code==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.go_wireless_package_code; }
                _oPar=x_oCmd.Parameters.Add("@lob", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.lob==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.lob; }
                _oPar=x_oCmd.Parameters.Add("@ref_salesmancode", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.ref_salesmancode==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.ref_salesmancode; }
                _oPar=x_oCmd.Parameters.Add("@third_party_hkid", global::System.Data.SqlDbType.NVarChar,30);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.third_party_hkid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.third_party_hkid; }
                _oPar=x_oCmd.Parameters.Add("@upgrade_existing_pccw_customer", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.upgrade_existing_pccw_customer==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.upgrade_existing_pccw_customer; }
                _oPar=x_oCmd.Parameters.Add("@d_address", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.d_address==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.d_address; }
                _oPar=x_oCmd.Parameters.Add("@upgrade_registered_mobile_no", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.upgrade_registered_mobile_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.upgrade_registered_mobile_no; }
                _oPar=x_oCmd.Parameters.Add("@gift_code3", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.gift_code3==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.gift_code3; }
                _oPar=x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.normal_rebate_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.normal_rebate_type; }
                _oPar=x_oCmd.Parameters.Add("@gift_desc2", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.gift_desc2==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.gift_desc2; }
                _oPar=x_oCmd.Parameters.Add("@monthly_bank_account_branch_code", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.monthly_bank_account_branch_code==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.monthly_bank_account_branch_code; }
                _oPar=x_oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.Text);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.remarks==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.remarks; }
                _oPar=x_oCmd.Parameters.Add("@accept", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.accept==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.accept; }
                _oPar=x_oCmd.Parameters.Add("@delivery_exchange", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.delivery_exchange==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.delivery_exchange; }
                _oPar=x_oCmd.Parameters.Add("@gift_code2", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.gift_code2==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.gift_code2; }
                _oPar=x_oCmd.Parameters.Add("@prepayment_waive", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.prepayment_waive==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.prepayment_waive; }
                _oPar=x_oCmd.Parameters.Add("@existing_smart_phone_imei", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.existing_smart_phone_imei==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.existing_smart_phone_imei; }
                _oPar=x_oCmd.Parameters.Add("@cust_name", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.cust_name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.cust_name; }
                _oPar=x_oCmd.Parameters.Add("@upgrade_sponsorships_amount", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.upgrade_sponsorships_amount==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.upgrade_sponsorships_amount; }
                _oPar=x_oCmd.Parameters.Add("@bill_medium_waive", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.bill_medium_waive==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.bill_medium_waive; }
                _oPar=x_oCmd.Parameters.Add("@delivery_exchange_location", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.delivery_exchange_location==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.delivery_exchange_location; }
                _oPar=x_oCmd.Parameters.Add("@hs_offer_type_id", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.hs_offer_type_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.hs_offer_type_id; }
                _oPar=x_oCmd.Parameters.Add("@extra_rebate_amount", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.extra_rebate_amount==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.extra_rebate_amount; }
                _oPar=x_oCmd.Parameters.Add("@rebate", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.rebate==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.rebate; }
                _oPar=x_oCmd.Parameters.Add("@upgrade_type", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.upgrade_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.upgrade_type; }
                _oPar=x_oCmd.Parameters.Add("@go_wireless", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.go_wireless==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.go_wireless; }
                _oPar=x_oCmd.Parameters.Add("@extra_rebate", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.extra_rebate==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.extra_rebate; }
                _oPar=x_oCmd.Parameters.Add("@plan_eff", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.plan_eff==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.plan_eff; }
                _oPar=x_oCmd.Parameters.Add("@card_exp_year", global::System.Data.SqlDbType.NVarChar,4);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.card_exp_year==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.card_exp_year; }
                _oPar=x_oCmd.Parameters.Add("@upgrade_existing_contract_sdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.upgrade_existing_contract_sdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionOrder.upgrade_existing_contract_sdate; }
                _oPar=x_oCmd.Parameters.Add("@ord_place_hkid", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.ord_place_hkid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.ord_place_hkid; }
                _oPar=x_oCmd.Parameters.Add("@register_address", global::System.Data.SqlDbType.NVarChar,200);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.register_address==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.register_address; }
                _oPar=x_oCmd.Parameters.Add("@gender", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.gender==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.gender; }
                _oPar=x_oCmd.Parameters.Add("@lob_ac", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.lob_ac==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.lob_ac; }
                _oPar=x_oCmd.Parameters.Add("@sim_mrt_no", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.sim_mrt_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.sim_mrt_no; }
                _oPar=x_oCmd.Parameters.Add("@redemption_notice_option", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.redemption_notice_option==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.redemption_notice_option; }
                _oPar=x_oCmd.Parameters.Add("@delivery_collection_type", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.delivery_collection_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.delivery_collection_type; }
                _oPar=x_oCmd.Parameters.Add("@action_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.action_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionOrder.action_date; }
                _oPar=x_oCmd.Parameters.Add("@third_party_id_type", global::System.Data.SqlDbType.NVarChar,30);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.third_party_id_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.third_party_id_type; }
                _oPar=x_oCmd.Parameters.Add("@org_ftg", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.org_ftg==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.org_ftg; }
                _oPar=x_oCmd.Parameters.Add("@upgrade_service_tenure", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.upgrade_service_tenure==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.upgrade_service_tenure; }
                _oPar=x_oCmd.Parameters.Add("@monthly_payment_type", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.monthly_payment_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.monthly_payment_type; }
                _oPar=x_oCmd.Parameters.Add("@contact_no", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.contact_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.contact_no; }
                _oPar=x_oCmd.Parameters.Add("@org_mrt", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.org_mrt==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.org_mrt; }
                _oPar=x_oCmd.Parameters.Add("@sim_item_name", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.sim_item_name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.sim_item_name; }
                _oPar=x_oCmd.Parameters.Add("@pay_method", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.pay_method==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.pay_method; }
                _oPar=x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.hs_model==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.hs_model; }
                _oPar=x_oCmd.Parameters.Add("@gift_code", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.gift_code==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.gift_code; }
                _oPar=x_oCmd.Parameters.Add("@monthly_bank_account_hkid", global::System.Data.SqlDbType.NVarChar,30);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.monthly_bank_account_hkid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.monthly_bank_account_hkid; }
                _oPar=x_oCmd.Parameters.Add("@extra_offer", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.extra_offer==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.extra_offer; }
                _oPar=x_oCmd.Parameters.Add("@monthly_bank_account_no", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.monthly_bank_account_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.monthly_bank_account_no; }
                _oPar=x_oCmd.Parameters.Add("@first_month_license_fee", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.first_month_license_fee==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.first_month_license_fee; }
                _oPar=x_oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.retrieve_cnt==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.retrieve_cnt; }
                _oPar=x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.ddate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionOrder.ddate; }
                _oPar=x_oCmd.Parameters.Add("@s_premium2", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.s_premium2==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.s_premium2; }
                _oPar=x_oCmd.Parameters.Add("@monthly_bank_account_id_type", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.monthly_bank_account_id_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.monthly_bank_account_id_type; }
                _oPar=x_oCmd.Parameters.Add("@card_type", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.card_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.card_type; }
                _oPar=x_oCmd.Parameters.Add("@next_bill", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.next_bill==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.next_bill; }
                _oPar=x_oCmd.Parameters.Add("@pcd_paid_go_wireless", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.pcd_paid_go_wireless==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.pcd_paid_go_wireless; }
                _oPar=x_oCmd.Parameters.Add("@upgrade_rebate_calculation", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.upgrade_rebate_calculation==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.upgrade_rebate_calculation; }
                _oPar=x_oCmd.Parameters.Add("@ext_place_tel", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.ext_place_tel==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.ext_place_tel; }
                _oPar=x_oCmd.Parameters.Add("@m_3rd_hkid", global::System.Data.SqlDbType.NVarChar,30);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.m_3rd_hkid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.m_3rd_hkid; }
                _oPar=x_oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.retention_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.retention_type; }
                _oPar=x_oCmd.Parameters.Add("@cooling_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.cooling_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionOrder.cooling_date; }
                _oPar=x_oCmd.Parameters.Add("@aig_gift", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.aig_gift==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.aig_gift; }
                _oPar=x_oCmd.Parameters.Add("@cust_staff_no", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.cust_staff_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.cust_staff_no; }
                _oPar=x_oCmd.Parameters.Add("@family_name", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.family_name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.family_name; }
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionOrder.cdate; }
                _oPar=x_oCmd.Parameters.Add("@status_by_cs_admin", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.status_by_cs_admin==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.status_by_cs_admin; }
                _oPar=x_oCmd.Parameters.Add("@given_name", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.given_name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.given_name; }
                _oPar=x_oCmd.Parameters.Add("@vip_case", global::System.Data.SqlDbType.NVarChar,200);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.vip_case==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.vip_case; }
                _oPar=x_oCmd.Parameters.Add("@org_fee", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.org_fee==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.org_fee; }
                _oPar=x_oCmd.Parameters.Add("@s_premium3", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.s_premium3==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.s_premium3; }
                _oPar=x_oCmd.Parameters.Add("@log_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.log_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionOrder.log_date; }
                _oPar=x_oCmd.Parameters.Add("@extn", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.extn==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.extn; }
                _oPar=x_oCmd.Parameters.Add("@d_time", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.d_time==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.d_time; }
                _oPar=x_oCmd.Parameters.Add("@bank_name", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.bank_name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.bank_name; }
                _oPar=x_oCmd.Parameters.Add("@delivery_exchange_option", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.delivery_exchange_option==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.delivery_exchange_option; }
                _oPar=x_oCmd.Parameters.Add("@upgrade_service_account_no", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.upgrade_service_account_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.upgrade_service_account_no; }
                _oPar=x_oCmd.Parameters.Add("@old_ord_id", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.old_ord_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.old_ord_id; }
                _oPar=x_oCmd.Parameters.Add("@m_card_no", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.m_card_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.m_card_no; }
                _oPar=x_oCmd.Parameters.Add("@existing_contract_end_date", global::System.Data.SqlDbType.NVarChar,30);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.existing_contract_end_date==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.existing_contract_end_date; }
                _oPar=x_oCmd.Parameters.Add("@con_eff_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.con_eff_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionOrder.con_eff_date; }
                _oPar=x_oCmd.Parameters.Add("@m_3rd_hkid2", global::System.Data.SqlDbType.NVarChar,1);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.m_3rd_hkid2==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.m_3rd_hkid2; }
                _oPar=x_oCmd.Parameters.Add("@amount", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.amount==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.amount; }
                _oPar=x_oCmd.Parameters.Add("@m_3rd_id_type", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.m_3rd_id_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.m_3rd_id_type; }
                _oPar=x_oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.id_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.id_type; }
                _oPar=x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.rate_plan==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.rate_plan; }
                _oPar=x_oCmd.Parameters.Add("@channel", global::System.Data.SqlDbType.Char,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.channel==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.channel; }
                _oPar=x_oCmd.Parameters.Add("@action_eff_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.action_eff_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionOrder.action_eff_date; }
                _oPar=x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.issue_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.issue_type; }
                _oPar=x_oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.NVarChar,30);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.free_mon==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.free_mon; }
                _oPar=x_oCmd.Parameters.Add("@plan_eff_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.plan_eff_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionOrder.plan_eff_date; }
                _oPar=x_oCmd.Parameters.Add("@teamcode", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.teamcode==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.teamcode; }
                _oPar=x_oCmd.Parameters.Add("@bill_medium", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.bill_medium==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.bill_medium; }
                _oPar=x_oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,15);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.edf_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.edf_no; }
                _oPar=x_oCmd.Parameters.Add("@ord_place_by", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.ord_place_by==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.ord_place_by; }
                _oPar=x_oCmd.Parameters.Add("@cancel_renew", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.cancel_renew==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.cancel_renew; }
                _oPar=x_oCmd.Parameters.Add("@preferred_languages", global::System.Data.SqlDbType.NVarChar,30);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.preferred_languages==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.preferred_languages; }
                _oPar=x_oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,30);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.hkid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.hkid; }
                _oPar=x_oCmd.Parameters.Add("@card_holder", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.card_holder==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.card_holder; }
                _oPar=x_oCmd.Parameters.Add("@ac_no", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.ac_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.ac_no; }
                _oPar=x_oCmd.Parameters.Add("@bill_cut_num", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.bill_cut_num==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.bill_cut_num; }
                _oPar=x_oCmd.Parameters.Add("@premium", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.premium==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.premium; }
                _oPar=x_oCmd.Parameters.Add("@del_remark", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.del_remark==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.del_remark; }
                _oPar=x_oCmd.Parameters.Add("@gift_imei2", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.gift_imei2==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.gift_imei2; }
                _oPar=x_oCmd.Parameters.Add("@reasons", global::System.Data.SqlDbType.Text);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.reasons==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.reasons; }
                _oPar=x_oCmd.Parameters.Add("@language", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.language==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.language; }
                _oPar=x_oCmd.Parameters.Add("@rebate_amount", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.rebate_amount==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.rebate_amount; }
                _oPar=x_oCmd.Parameters.Add("@ord_place_id_type", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.ord_place_id_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.ord_place_id_type; }
                _oPar=x_oCmd.Parameters.Add("@m_3rd_contact_no", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.m_3rd_contact_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.m_3rd_contact_no; }
                _oPar=x_oCmd.Parameters.Add("@staff_no", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.staff_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.staff_no; }
                _oPar=x_oCmd.Parameters.Add("@sp_d_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.sp_d_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionOrder.sp_d_date; }
                _oPar=x_oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.bundle_name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.bundle_name; }
                _oPar=x_oCmd.Parameters.Add("@accessory_waive", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.accessory_waive==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.accessory_waive; }
                _oPar=x_oCmd.Parameters.Add("@sim_item_code", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.sim_item_code==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.sim_item_code; }
                _oPar=x_oCmd.Parameters.Add("@cust_type", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.cust_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.cust_type; }
                _oPar=x_oCmd.Parameters.Add("@card_ref_no", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrder.card_ref_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrder.card_ref_no; }
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
        
        #region INSERT_MOBILERETENTIONORDER Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2012-01-12>
        ///-- Description:	<Description,MOBILERETENTIONORDER, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_MOBILERETENTIONORDER Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_MOBILERETENTIONORDER', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_MOBILERETENTIONORDER;
        GO
        CREATE PROCEDURE INSERT_MOBILERETENTIONORDER
        	-- Add the parameters for the stored procedure here
        @RETURN_ORDER_ID int output,
        @gift_imei nvarchar(50),
        @s_premium4 nvarchar(100),
        @gift_desc4 nvarchar(250),
        @accessory_desc nvarchar(50),
        @action_required nvarchar(50),
        @vas_eff_date datetime,
        @monthly_bank_account_bank_code nvarchar(50),
        @special_handling_dummy_code nvarchar(100),
        @m_card_exp_year nvarchar(4),
        @remarks2PY text,
        @trade_field nvarchar(50),
        @ord_place_tel nvarchar(10),
        @ord_place_id_type nvarchar(50),
        @cooling_offer nvarchar(50),
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
        @special_approval nvarchar(20),
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
        @ext_place_tel nvarchar(10),
        @m_3rd_hkid nvarchar(30),
        @retention_type nvarchar(50),
        @cooling_date datetime,
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
        @free_mon nvarchar(30),
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
        
        DECLARE @LAST_ID INT
        SET @LAST_ID=(SELECT MAX(order_id) FROM MobileRetentionOrder)
        DBCC checkident('MobileRetentionOrder', reseed, @LAST_ID)  
        
        INSERT INTO  [MobileRetentionOrder]   ([gift_imei],[s_premium4],[upgrade_existing_customer_type],[gift_desc4],[accessory_desc],[staff_name],[action_required],[vas_eff_date],[monthly_bank_account_bank_code],[sim_item_number],[special_handling_dummy_code],[card_no],[m_card_exp_year],[bill_medium_email],[remarks2PY],[trade_field],[ord_place_tel],[action_of_rate_plan_effective],[cooling_offer],[upgrade_handset_offer_rebate_schedule],[change_payment_type],[date_of_birth],[contact_person],[extra_d_charge],[tl_name],[fast_start],[sp_ref_no],[edate],[exist_cust_plan],[ord_place_rel],[mrt_no],[imei_no],[existing_smart_phone_model],[bank_code],[pos_ref_no],[bill_cut_date],[gift_imei3],[exist_plan],[waive],[program],[first_month_fee],[r_offer],[cid],[did],[ftg_tenure],[con_per],[gift_code4],[easywatch_type],[sms_mrt],[monthly_payment_method],[remarks2EDF],[gift_desc3],[gift_imei4],[monthly_bank_account_hkid2],[d_date],[gift_desc],[pool],[cn_mrt_no],[accessory_imei],[third_party_credit_card],[special_approval],[upgrade_existing_contract_edate],[accessory_code],[s_premium],[ref_staff_no],[accessory_price],[m_card_exp_month],[installment_period],[m_card_type],[easywatch_ord_id],[normal_rebate],[m_rebate_amount],[m_card_holder2],[monthly_bank_account_holder],[active],[s_premium1],[card_exp_month],[ob_program_id],[sku],[salesmancode],[go_wireless_package_code],[lob],[ref_salesmancode],[third_party_hkid],[upgrade_existing_pccw_customer],[d_address],[upgrade_registered_mobile_no],[gift_code3],[normal_rebate_type],[gift_desc2],[monthly_bank_account_branch_code],[remarks],[accept],[delivery_exchange],[gift_code2],[prepayment_waive],[existing_smart_phone_imei],[cust_name],[upgrade_sponsorships_amount],[bill_medium_waive],[delivery_exchange_location],[hs_offer_type_id],[extra_rebate_amount],[rebate],[upgrade_type],[go_wireless],[extra_rebate],[plan_eff],[card_exp_year],[upgrade_existing_contract_sdate],[ord_place_hkid],[register_address],[gender],[lob_ac],[sim_mrt_no],[redemption_notice_option],[delivery_collection_type],[action_date],[third_party_id_type],[org_ftg],[upgrade_service_tenure],[monthly_payment_type],[contact_no],[org_mrt],[sim_item_name],[pay_method],[hs_model],[gift_code],[monthly_bank_account_hkid],[extra_offer],[monthly_bank_account_no],[first_month_license_fee],[retrieve_cnt],[ddate],[s_premium2],[monthly_bank_account_id_type],[card_type],[next_bill],[pcd_paid_go_wireless],[upgrade_rebate_calculation],[ext_place_tel],[m_3rd_hkid],[retention_type],[cooling_date],[aig_gift],[cust_staff_no],[family_name],[cdate],[status_by_cs_admin],[given_name],[vip_case],[org_fee],[s_premium3],[log_date],[extn],[d_time],[bank_name],[delivery_exchange_option],[upgrade_service_account_no],[old_ord_id],[m_card_no],[existing_contract_end_date],[con_eff_date],[m_3rd_hkid2],[amount],[m_3rd_id_type],[id_type],[rate_plan],[channel],[action_eff_date],[issue_type],[free_mon],[plan_eff_date],[teamcode],[bill_medium],[edf_no],[ord_place_by],[cancel_renew],[preferred_languages],[hkid],[card_holder],[ac_no],[bill_cut_num],[premium],[del_remark],[gift_imei2],[reasons],[language],[rebate_amount],[ord_place_id_type],[m_3rd_contact_no],[staff_no],[sp_d_date],[bundle_name],[accessory_waive],[sim_item_code],[cust_type],[card_ref_no])  VALUES  (@gift_imei,@s_premium4,@upgrade_existing_customer_type,@gift_desc4,@accessory_desc,@staff_name,@action_required,@vas_eff_date,@monthly_bank_account_bank_code,@sim_item_number,@special_handling_dummy_code,@card_no,@m_card_exp_year,@bill_medium_email,@remarks2PY,@trade_field,@ord_place_tel,@action_of_rate_plan_effective,@cooling_offer,@upgrade_handset_offer_rebate_schedule,@change_payment_type,@date_of_birth,@contact_person,@extra_d_charge,@tl_name,@fast_start,@sp_ref_no,@edate,@exist_cust_plan,@ord_place_rel,@mrt_no,@imei_no,@existing_smart_phone_model,@bank_code,@pos_ref_no,@bill_cut_date,@gift_imei3,@exist_plan,@waive,@program,@first_month_fee,@r_offer,@cid,@did,@ftg_tenure,@con_per,@gift_code4,@easywatch_type,@sms_mrt,@monthly_payment_method,@remarks2EDF,@gift_desc3,@gift_imei4,@monthly_bank_account_hkid2,@d_date,@gift_desc,@pool,@cn_mrt_no,@accessory_imei,@third_party_credit_card,@special_approval,@upgrade_existing_contract_edate,@accessory_code,@s_premium,@ref_staff_no,@accessory_price,@m_card_exp_month,@installment_period,@m_card_type,@easywatch_ord_id,@normal_rebate,@m_rebate_amount,@m_card_holder2,@monthly_bank_account_holder,@active,@s_premium1,@card_exp_month,@ob_program_id,@sku,@salesmancode,@go_wireless_package_code,@lob,@ref_salesmancode,@third_party_hkid,@upgrade_existing_pccw_customer,@d_address,@upgrade_registered_mobile_no,@gift_code3,@normal_rebate_type,@gift_desc2,@monthly_bank_account_branch_code,@remarks,@accept,@delivery_exchange,@gift_code2,@prepayment_waive,@existing_smart_phone_imei,@cust_name,@upgrade_sponsorships_amount,@bill_medium_waive,@delivery_exchange_location,@hs_offer_type_id,@extra_rebate_amount,@rebate,@upgrade_type,@go_wireless,@extra_rebate,@plan_eff,@card_exp_year,@upgrade_existing_contract_sdate,@ord_place_hkid,@register_address,@gender,@lob_ac,@sim_mrt_no,@redemption_notice_option,@delivery_collection_type,@action_date,@third_party_id_type,@org_ftg,@upgrade_service_tenure,@monthly_payment_type,@contact_no,@org_mrt,@sim_item_name,@pay_method,@hs_model,@gift_code,@monthly_bank_account_hkid,@extra_offer,@monthly_bank_account_no,@first_month_license_fee,@retrieve_cnt,@ddate,@s_premium2,@monthly_bank_account_id_type,@card_type,@next_bill,@pcd_paid_go_wireless,@upgrade_rebate_calculation,@ext_place_tel,@m_3rd_hkid,@retention_type,@cooling_date,@aig_gift,@cust_staff_no,@family_name,@cdate,@status_by_cs_admin,@given_name,@vip_case,@org_fee,@s_premium3,@log_date,@extn,@d_time,@bank_name,@delivery_exchange_option,@upgrade_service_account_no,@old_ord_id,@m_card_no,@existing_contract_end_date,@con_eff_date,@m_3rd_hkid2,@amount,@m_3rd_id_type,@id_type,@rate_plan,@channel,@action_eff_date,@issue_type,@free_mon,@plan_eff_date,@teamcode,@bill_medium,@edf_no,@ord_place_by,@cancel_renew,@preferred_languages,@hkid,@card_holder,@ac_no,@bill_cut_num,@premium,@del_remark,@gift_imei2,@reasons,@language,@rebate_amount,@ord_place_id_type,@m_3rd_contact_no,@staff_no,@sp_d_date,@bundle_name,@accessory_waive,@sim_item_code,@cust_type,@card_ref_no)
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
            string _sQuery = "DELETE FROM  [MobileRetentionOrder]  WHERE [MobileRetentionOrder].[order_id]=@order_id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionOrder]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrder]"); }
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
            return MobileRetentionOrderRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileRetentionOrder]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionOrder]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrder]"); }
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
            string _sQuery = "DELETE FROM [MobileRetentionOrder]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionOrder]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrder]"); }
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


