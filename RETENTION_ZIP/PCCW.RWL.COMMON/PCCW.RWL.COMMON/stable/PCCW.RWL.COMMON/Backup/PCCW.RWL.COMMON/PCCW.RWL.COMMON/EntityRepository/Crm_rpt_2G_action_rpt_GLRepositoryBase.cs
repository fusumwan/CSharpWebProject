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
///-- Create date: <Create Date 2009-07-13>
///-- Description:	<Description,Table :[crm_rpt_2G_action_rpt_GL],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [crm_rpt_2G_action_rpt_GL] Insert / list / delete manager layer
    /// </summary>
    
    [System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"crm_rpt_2G_action_rpt_GL")]
    public class Crm_rpt_2G_action_rpt_GLRepositoryBase: System.Data.Linq.DataContext, IEntityRepository, IDisposable{
        
        #region Instance
        private static Crm_rpt_2G_action_rpt_GLRepositoryBase instance;
        public static Crm_rpt_2G_action_rpt_GLRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.CRM + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new Crm_rpt_2G_action_rpt_GLRepositoryBase(_oDB);
            }
            return instance;
        }
        public static Crm_rpt_2G_action_rpt_GLRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new Crm_rpt_2G_action_rpt_GLRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<Crm_rpt_2G_action_rpt_GLEntity> Crm_rpt_2G_action_rpt_GLs;
        #endregion
        
        #region Constructor
        public Crm_rpt_2G_action_rpt_GLRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~Crm_rpt_2G_action_rpt_GLRepositoryBase() { 
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (disposing)
            {
            }
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [crm_rpt_2G_action_rpt_GL]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[crm_rpt_2G_action_rpt_GL]","["+ Configurator.MSSQLTablePrefix + "crm_rpt_2G_action_rpt_GL]"); }
            using(SqlConnection _oConn=x_oDB.GetConnection()){
                SqlCommand _oCmd = new SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                int _iTotalCount = 0;
                try
                {
                    SqlDataReader _oData = _oCmd.ExecuteReader();
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
        
        #region Get
        
        /// <summary>
        /// Summary description for management get record from table
        /// </summary>
        
        
        public Crm_rpt_2G_action_rpt_GLEntity GetObj(System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }
        
        
        public static Crm_rpt_2G_action_rpt_GLEntity GetObj(MSSQLConnect x_oDB,System.Nullable<int> x_iId)
        {
            if (x_oDB==null) { return null; }
            Crm_rpt_2G_action_rpt_GL _Crm_rpt_2G_action_rpt_GL = new Crm_rpt_2G_action_rpt_GL(x_oDB);
            if (!_Crm_rpt_2G_action_rpt_GL.Load(x_iId)) { return null; }
            return _Crm_rpt_2G_action_rpt_GL;
        }
        
        
        
        public static Crm_rpt_2G_action_rpt_GLEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            return GetArrayObj(x_oDB,"id",x_oArrayItemId);
        }
        
        
        public static Crm_rpt_2G_action_rpt_GLEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            List<Crm_rpt_2G_action_rpt_GL> _oRow = new List<Crm_rpt_2G_action_rpt_GL>();
            string _sQuery = "SELECT [crm_rpt_2G_action_rpt_GL].[telemarketing_suppress_flag] AS CRM_RPT_2G_ACTION_RPT_GL_TELEMARKETING_SUPPRESS_FLAG,[crm_rpt_2G_action_rpt_GL].[end_date] AS CRM_RPT_2G_ACTION_RPT_GL_END_DATE,[crm_rpt_2G_action_rpt_GL].[ddate] AS CRM_RPT_2G_ACTION_RPT_GL_DDATE,[crm_rpt_2G_action_rpt_GL].[airtime_hs_model] AS CRM_RPT_2G_ACTION_RPT_GL_AIRTIME_HS_MODEL,[crm_rpt_2G_action_rpt_GL].[tradefield] AS CRM_RPT_2G_ACTION_RPT_GL_TRADEFIELD,[crm_rpt_2G_action_rpt_GL].[calllist_name] AS CRM_RPT_2G_ACTION_RPT_GL_CALLLIST_NAME,[crm_rpt_2G_action_rpt_GL].[field1] AS CRM_RPT_2G_ACTION_RPT_GL_FIELD1,[crm_rpt_2G_action_rpt_GL].[remarks] AS CRM_RPT_2G_ACTION_RPT_GL_REMARKS,[crm_rpt_2G_action_rpt_GL].[bill_cycle] AS CRM_RPT_2G_ACTION_RPT_GL_BILL_CYCLE,[crm_rpt_2G_action_rpt_GL].[addr_2] AS CRM_RPT_2G_ACTION_RPT_GL_ADDR_2,[crm_rpt_2G_action_rpt_GL].[id_number] AS CRM_RPT_2G_ACTION_RPT_GL_ID_NUMBER,[crm_rpt_2G_action_rpt_GL].[attention_name_formartted] AS CRM_RPT_2G_ACTION_RPT_GL_ATTENTION_NAME_FORMARTTED,[crm_rpt_2G_action_rpt_GL].[customer_name_formartted] AS CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_NAME_FORMARTTED,[crm_rpt_2G_action_rpt_GL].[mnp_rebate_end_date] AS CRM_RPT_2G_ACTION_RPT_GL_MNP_REBATE_END_DATE,[crm_rpt_2G_action_rpt_GL].[field3] AS CRM_RPT_2G_ACTION_RPT_GL_FIELD3,[crm_rpt_2G_action_rpt_GL].[addr_4] AS CRM_RPT_2G_ACTION_RPT_GL_ADDR_4,[crm_rpt_2G_action_rpt_GL].[program] AS CRM_RPT_2G_ACTION_RPT_GL_PROGRAM,[crm_rpt_2G_action_rpt_GL].[prop_plan] AS CRM_RPT_2G_ACTION_RPT_GL_PROP_PLAN,[crm_rpt_2G_action_rpt_GL].[expired_month] AS CRM_RPT_2G_ACTION_RPT_GL_EXPIRED_MONTH,[crm_rpt_2G_action_rpt_GL].[customer_group] AS CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_GROUP,[crm_rpt_2G_action_rpt_GL].[join_date] AS CRM_RPT_2G_ACTION_RPT_GL_JOIN_DATE,[crm_rpt_2G_action_rpt_GL].[idd_flg] AS CRM_RPT_2G_ACTION_RPT_GL_IDD_FLG,[crm_rpt_2G_action_rpt_GL].[active] AS CRM_RPT_2G_ACTION_RPT_GL_ACTIVE,[crm_rpt_2G_action_rpt_GL].[period] AS CRM_RPT_2G_ACTION_RPT_GL_PERIOD,[crm_rpt_2G_action_rpt_GL].[field2] AS CRM_RPT_2G_ACTION_RPT_GL_FIELD2,[crm_rpt_2G_action_rpt_GL].[start_date] AS CRM_RPT_2G_ACTION_RPT_GL_START_DATE,[crm_rpt_2G_action_rpt_GL].[plan_fee] AS CRM_RPT_2G_ACTION_RPT_GL_PLAN_FEE,[crm_rpt_2G_action_rpt_GL].[rate_plan] AS CRM_RPT_2G_ACTION_RPT_GL_RATE_PLAN,[crm_rpt_2G_action_rpt_GL].[segment] AS CRM_RPT_2G_ACTION_RPT_GL_SEGMENT,[crm_rpt_2G_action_rpt_GL].[cdate] AS CRM_RPT_2G_ACTION_RPT_GL_CDATE,[crm_rpt_2G_action_rpt_GL].[program_id] AS CRM_RPT_2G_ACTION_RPT_GL_PROGRAM_ID,[crm_rpt_2G_action_rpt_GL].[password] AS CRM_RPT_2G_ACTION_RPT_GL_PASSWORD,[crm_rpt_2G_action_rpt_GL].[payment_method] AS CRM_RPT_2G_ACTION_RPT_GL_PAYMENT_METHOD,[crm_rpt_2G_action_rpt_GL].[contract_id] AS CRM_RPT_2G_ACTION_RPT_GL_CONTRACT_ID,[crm_rpt_2G_action_rpt_GL].[customer_code] AS CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_CODE,[crm_rpt_2G_action_rpt_GL].[mobile_no] AS CRM_RPT_2G_ACTION_RPT_GL_MOBILE_NO,[crm_rpt_2G_action_rpt_GL].[als_flg] AS CRM_RPT_2G_ACTION_RPT_GL_ALS_FLG,[crm_rpt_2G_action_rpt_GL].[vas_desc] AS CRM_RPT_2G_ACTION_RPT_GL_VAS_DESC,[crm_rpt_2G_action_rpt_GL].[addr_3] AS CRM_RPT_2G_ACTION_RPT_GL_ADDR_3,[crm_rpt_2G_action_rpt_GL].[subscriber_tier] AS CRM_RPT_2G_ACTION_RPT_GL_SUBSCRIBER_TIER,[crm_rpt_2G_action_rpt_GL].[customer_id] AS CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_ID,[crm_rpt_2G_action_rpt_GL].[handset_rebate_end_date] AS CRM_RPT_2G_ACTION_RPT_GL_HANDSET_REBATE_END_DATE,[crm_rpt_2G_action_rpt_GL].[plan_free_inter_min] AS CRM_RPT_2G_ACTION_RPT_GL_PLAN_FREE_INTER_MIN,[crm_rpt_2G_action_rpt_GL].[cid] AS CRM_RPT_2G_ACTION_RPT_GL_CID,[crm_rpt_2G_action_rpt_GL].[did] AS CRM_RPT_2G_ACTION_RPT_GL_DID,[crm_rpt_2G_action_rpt_GL].[id] AS CRM_RPT_2G_ACTION_RPT_GL_ID,[crm_rpt_2G_action_rpt_GL].[plan_free_intra_min] AS CRM_RPT_2G_ACTION_RPT_GL_PLAN_FREE_INTRA_MIN,[crm_rpt_2G_action_rpt_GL].[original_telemarketing_suppress_flag] AS CRM_RPT_2G_ACTION_RPT_GL_ORIGINAL_TELEMARKETING_SUPPRESS_FLAG,[crm_rpt_2G_action_rpt_GL].[contact_number] AS CRM_RPT_2G_ACTION_RPT_GL_CONTACT_NUMBER,[crm_rpt_2G_action_rpt_GL].[addr_1] AS CRM_RPT_2G_ACTION_RPT_GL_ADDR_1,[crm_rpt_2G_action_rpt_GL].[max_contract_end_date] AS CRM_RPT_2G_ACTION_RPT_GL_MAX_CONTRACT_END_DATE,[crm_rpt_2G_action_rpt_GL].[id1] AS CRM_RPT_2G_ACTION_RPT_GL_ID1,[crm_rpt_2G_action_rpt_GL].[autopay] AS CRM_RPT_2G_ACTION_RPT_GL_AUTOPAY  FROM  [crm_rpt_2G_action_rpt_GL]";
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
                _sQuery += " WHERE [crm_rpt_2G_action_rpt_GL].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[crm_rpt_2G_action_rpt_GL]","["+ Configurator.MSSQLTablePrefix + "crm_rpt_2G_action_rpt_GL]"); }
            using(SqlConnection _oConn = x_oDB.GetConnection()){
                SqlCommand _oCmd = new SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        Crm_rpt_2G_action_rpt_GL _oCrm_rpt_2G_action_rpt_GL = new Crm_rpt_2G_action_rpt_GL();
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ALS_FLG"])) {_oCrm_rpt_2G_action_rpt_GL.als_flg = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_ALS_FLG"]; }else{_oCrm_rpt_2G_action_rpt_GL.als_flg=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_END_DATE"])) {_oCrm_rpt_2G_action_rpt_GL.end_date = (System.Nullable<DateTime>)_oData["CRM_RPT_2G_ACTION_RPT_GL_END_DATE"]; }else{_oCrm_rpt_2G_action_rpt_GL.end_date=null;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_REMARKS"])) {_oCrm_rpt_2G_action_rpt_GL.remarks = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_REMARKS"]; }else{_oCrm_rpt_2G_action_rpt_GL.remarks=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_AIRTIME_HS_MODEL"])) {_oCrm_rpt_2G_action_rpt_GL.airtime_hs_model = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_AIRTIME_HS_MODEL"]; }else{_oCrm_rpt_2G_action_rpt_GL.airtime_hs_model=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_START_DATE"])) {_oCrm_rpt_2G_action_rpt_GL.start_date = (System.Nullable<DateTime>)_oData["CRM_RPT_2G_ACTION_RPT_GL_START_DATE"]; }else{_oCrm_rpt_2G_action_rpt_GL.start_date=null;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CALLLIST_NAME"])) {_oCrm_rpt_2G_action_rpt_GL.calllist_name = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_CALLLIST_NAME"]; }else{_oCrm_rpt_2G_action_rpt_GL.calllist_name=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_JOIN_DATE"])) {_oCrm_rpt_2G_action_rpt_GL.join_date = (System.Nullable<DateTime>)_oData["CRM_RPT_2G_ACTION_RPT_GL_JOIN_DATE"]; }else{_oCrm_rpt_2G_action_rpt_GL.join_date=null;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_FIELD1"])) {_oCrm_rpt_2G_action_rpt_GL.field1 = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_FIELD1"]; }else{_oCrm_rpt_2G_action_rpt_GL.field1=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_BILL_CYCLE"])) {_oCrm_rpt_2G_action_rpt_GL.bill_cycle = (System.Nullable<int>)_oData["CRM_RPT_2G_ACTION_RPT_GL_BILL_CYCLE"]; }else{_oCrm_rpt_2G_action_rpt_GL.bill_cycle=null;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ADDR_3"])) {_oCrm_rpt_2G_action_rpt_GL.addr_3 = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_ADDR_3"]; }else{_oCrm_rpt_2G_action_rpt_GL.addr_3=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ADDR_2"])) {_oCrm_rpt_2G_action_rpt_GL.addr_2 = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_ADDR_2"]; }else{_oCrm_rpt_2G_action_rpt_GL.addr_2=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ID_NUMBER"])) {_oCrm_rpt_2G_action_rpt_GL.id_number = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_ID_NUMBER"]; }else{_oCrm_rpt_2G_action_rpt_GL.id_number=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ATTENTION_NAME_FORMARTTED"])) {_oCrm_rpt_2G_action_rpt_GL.attention_name_formartted = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_ATTENTION_NAME_FORMARTTED"]; }else{_oCrm_rpt_2G_action_rpt_GL.attention_name_formartted=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_NAME_FORMARTTED"])) {_oCrm_rpt_2G_action_rpt_GL.customer_name_formartted = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_NAME_FORMARTTED"]; }else{_oCrm_rpt_2G_action_rpt_GL.customer_name_formartted=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_AUTOPAY"])) {_oCrm_rpt_2G_action_rpt_GL.autopay = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_AUTOPAY"]; }else{_oCrm_rpt_2G_action_rpt_GL.autopay=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_FIELD3"])) {_oCrm_rpt_2G_action_rpt_GL.field3 = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_FIELD3"]; }else{_oCrm_rpt_2G_action_rpt_GL.field3=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ADDR_4"])) {_oCrm_rpt_2G_action_rpt_GL.addr_4 = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_ADDR_4"]; }else{_oCrm_rpt_2G_action_rpt_GL.addr_4=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PROGRAM"])) {_oCrm_rpt_2G_action_rpt_GL.program = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_PROGRAM"]; }else{_oCrm_rpt_2G_action_rpt_GL.program=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PROP_PLAN"])) {_oCrm_rpt_2G_action_rpt_GL.prop_plan = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_PROP_PLAN"]; }else{_oCrm_rpt_2G_action_rpt_GL.prop_plan=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_GROUP"])) {_oCrm_rpt_2G_action_rpt_GL.customer_group = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_GROUP"]; }else{_oCrm_rpt_2G_action_rpt_GL.customer_group=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_CODE"])) {_oCrm_rpt_2G_action_rpt_GL.customer_code = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_CODE"]; }else{_oCrm_rpt_2G_action_rpt_GL.customer_code=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_TELEMARKETING_SUPPRESS_FLAG"])) {_oCrm_rpt_2G_action_rpt_GL.telemarketing_suppress_flag = (System.Nullable<bool>)_oData["CRM_RPT_2G_ACTION_RPT_GL_TELEMARKETING_SUPPRESS_FLAG"]; }else{_oCrm_rpt_2G_action_rpt_GL.telemarketing_suppress_flag=null;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_IDD_FLG"])) {_oCrm_rpt_2G_action_rpt_GL.idd_flg = (System.Nullable<bool>)_oData["CRM_RPT_2G_ACTION_RPT_GL_IDD_FLG"]; }else{_oCrm_rpt_2G_action_rpt_GL.idd_flg=null;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ACTIVE"])) {_oCrm_rpt_2G_action_rpt_GL.active = (System.Nullable<bool>)_oData["CRM_RPT_2G_ACTION_RPT_GL_ACTIVE"]; }else{_oCrm_rpt_2G_action_rpt_GL.active=null;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_DDATE"])) {_oCrm_rpt_2G_action_rpt_GL.ddate = (System.Nullable<DateTime>)_oData["CRM_RPT_2G_ACTION_RPT_GL_DDATE"]; }else{_oCrm_rpt_2G_action_rpt_GL.ddate=null;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ID"])) {_oCrm_rpt_2G_action_rpt_GL.id = (System.Nullable<int>)_oData["CRM_RPT_2G_ACTION_RPT_GL_ID"]; }else{_oCrm_rpt_2G_action_rpt_GL.id=null;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PLAN_FEE"])) {_oCrm_rpt_2G_action_rpt_GL.plan_fee = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_PLAN_FEE"]; }else{_oCrm_rpt_2G_action_rpt_GL.plan_fee=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_RATE_PLAN"])) {_oCrm_rpt_2G_action_rpt_GL.rate_plan = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_RATE_PLAN"]; }else{_oCrm_rpt_2G_action_rpt_GL.rate_plan=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_SEGMENT"])) {_oCrm_rpt_2G_action_rpt_GL.segment = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_SEGMENT"]; }else{_oCrm_rpt_2G_action_rpt_GL.segment=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ID1"])) {_oCrm_rpt_2G_action_rpt_GL.id1 = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_ID1"]; }else{_oCrm_rpt_2G_action_rpt_GL.id1=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PASSWORD"])) {_oCrm_rpt_2G_action_rpt_GL.password = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_PASSWORD"]; }else{_oCrm_rpt_2G_action_rpt_GL.password=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PAYMENT_METHOD"])) {_oCrm_rpt_2G_action_rpt_GL.payment_method = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_PAYMENT_METHOD"]; }else{_oCrm_rpt_2G_action_rpt_GL.payment_method=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CONTRACT_ID"])) {_oCrm_rpt_2G_action_rpt_GL.contract_id = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_CONTRACT_ID"]; }else{_oCrm_rpt_2G_action_rpt_GL.contract_id=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_FIELD2"])) {_oCrm_rpt_2G_action_rpt_GL.field2 = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_FIELD2"]; }else{_oCrm_rpt_2G_action_rpt_GL.field2=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_MOBILE_NO"])) {_oCrm_rpt_2G_action_rpt_GL.mobile_no = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_MOBILE_NO"]; }else{_oCrm_rpt_2G_action_rpt_GL.mobile_no=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PERIOD"])) {_oCrm_rpt_2G_action_rpt_GL.period = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_PERIOD"]; }else{_oCrm_rpt_2G_action_rpt_GL.period=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_VAS_DESC"])) {_oCrm_rpt_2G_action_rpt_GL.vas_desc = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_VAS_DESC"]; }else{_oCrm_rpt_2G_action_rpt_GL.vas_desc=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CDATE"])) {_oCrm_rpt_2G_action_rpt_GL.cdate = (System.Nullable<DateTime>)_oData["CRM_RPT_2G_ACTION_RPT_GL_CDATE"]; }else{_oCrm_rpt_2G_action_rpt_GL.cdate=null;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_SUBSCRIBER_TIER"])) {_oCrm_rpt_2G_action_rpt_GL.subscriber_tier = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_SUBSCRIBER_TIER"]; }else{_oCrm_rpt_2G_action_rpt_GL.subscriber_tier=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_ID"])) {_oCrm_rpt_2G_action_rpt_GL.customer_id = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_ID"]; }else{_oCrm_rpt_2G_action_rpt_GL.customer_id=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_HANDSET_REBATE_END_DATE"])) {_oCrm_rpt_2G_action_rpt_GL.handset_rebate_end_date = (System.Nullable<DateTime>)_oData["CRM_RPT_2G_ACTION_RPT_GL_HANDSET_REBATE_END_DATE"]; }else{_oCrm_rpt_2G_action_rpt_GL.handset_rebate_end_date=null;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PLAN_FREE_INTER_MIN"])) {_oCrm_rpt_2G_action_rpt_GL.plan_free_inter_min = (System.Nullable<int>)_oData["CRM_RPT_2G_ACTION_RPT_GL_PLAN_FREE_INTER_MIN"]; }else{_oCrm_rpt_2G_action_rpt_GL.plan_free_inter_min=null;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CID"])) {_oCrm_rpt_2G_action_rpt_GL.cid = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_CID"]; }else{_oCrm_rpt_2G_action_rpt_GL.cid=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_DID"])) {_oCrm_rpt_2G_action_rpt_GL.did = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_DID"]; }else{_oCrm_rpt_2G_action_rpt_GL.did=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_EXPIRED_MONTH"])) {_oCrm_rpt_2G_action_rpt_GL.expired_month = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_EXPIRED_MONTH"]; }else{_oCrm_rpt_2G_action_rpt_GL.expired_month=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PLAN_FREE_INTRA_MIN"])) {_oCrm_rpt_2G_action_rpt_GL.plan_free_intra_min = (System.Nullable<int>)_oData["CRM_RPT_2G_ACTION_RPT_GL_PLAN_FREE_INTRA_MIN"]; }else{_oCrm_rpt_2G_action_rpt_GL.plan_free_intra_min=null;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ORIGINAL_TELEMARKETING_SUPPRESS_FLAG"])) {_oCrm_rpt_2G_action_rpt_GL.original_telemarketing_suppress_flag = (System.Nullable<bool>)_oData["CRM_RPT_2G_ACTION_RPT_GL_ORIGINAL_TELEMARKETING_SUPPRESS_FLAG"]; }else{_oCrm_rpt_2G_action_rpt_GL.original_telemarketing_suppress_flag=null;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CONTACT_NUMBER"])) {_oCrm_rpt_2G_action_rpt_GL.contact_number = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_CONTACT_NUMBER"]; }else{_oCrm_rpt_2G_action_rpt_GL.contact_number=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_TRADEFIELD"])) {_oCrm_rpt_2G_action_rpt_GL.tradefield = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_TRADEFIELD"]; }else{_oCrm_rpt_2G_action_rpt_GL.tradefield=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ADDR_1"])) {_oCrm_rpt_2G_action_rpt_GL.addr_1 = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_ADDR_1"]; }else{_oCrm_rpt_2G_action_rpt_GL.addr_1=string.Empty;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_MAX_CONTRACT_END_DATE"])) {_oCrm_rpt_2G_action_rpt_GL.max_contract_end_date = (System.Nullable<DateTime>)_oData["CRM_RPT_2G_ACTION_RPT_GL_MAX_CONTRACT_END_DATE"]; }else{_oCrm_rpt_2G_action_rpt_GL.max_contract_end_date=null;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_MNP_REBATE_END_DATE"])) {_oCrm_rpt_2G_action_rpt_GL.mnp_rebate_end_date = (System.Nullable<DateTime>)_oData["CRM_RPT_2G_ACTION_RPT_GL_MNP_REBATE_END_DATE"]; }else{_oCrm_rpt_2G_action_rpt_GL.mnp_rebate_end_date=null;}
                        if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PROGRAM_ID"])) {_oCrm_rpt_2G_action_rpt_GL.program_id = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_PROGRAM_ID"]; }else{_oCrm_rpt_2G_action_rpt_GL.program_id=string.Empty;}
                        _oCrm_rpt_2G_action_rpt_GL.SetDB(x_oDB);
                        _oCrm_rpt_2G_action_rpt_GL.GetFound();
                        _oRow.Add(_oCrm_rpt_2G_action_rpt_GL);
                    }
                    _oData.Close();
                    _oData.Dispose();
                }
                catch (Exception exp) { string _sError = exp.ToString(); }
                finally
                {
                    _oConn.Close();
                    _oCmd.Dispose();
                    _oConn.Dispose();
                }
                return _oRow.Count == 0 ? null : _oRow.ToArray();
            }
        }
        
        public static Crm_rpt_2G_action_rpt_GLEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<Crm_rpt_2G_action_rpt_GL> _oRow = new List<Crm_rpt_2G_action_rpt_GL>();
            string _sFields="[crm_rpt_2G_action_rpt_GL].[telemarketing_suppress_flag] AS CRM_RPT_2G_ACTION_RPT_GL_TELEMARKETING_SUPPRESS_FLAG,[crm_rpt_2G_action_rpt_GL].[end_date] AS CRM_RPT_2G_ACTION_RPT_GL_END_DATE,[crm_rpt_2G_action_rpt_GL].[ddate] AS CRM_RPT_2G_ACTION_RPT_GL_DDATE,[crm_rpt_2G_action_rpt_GL].[airtime_hs_model] AS CRM_RPT_2G_ACTION_RPT_GL_AIRTIME_HS_MODEL,[crm_rpt_2G_action_rpt_GL].[tradefield] AS CRM_RPT_2G_ACTION_RPT_GL_TRADEFIELD,[crm_rpt_2G_action_rpt_GL].[calllist_name] AS CRM_RPT_2G_ACTION_RPT_GL_CALLLIST_NAME,[crm_rpt_2G_action_rpt_GL].[field1] AS CRM_RPT_2G_ACTION_RPT_GL_FIELD1,[crm_rpt_2G_action_rpt_GL].[remarks] AS CRM_RPT_2G_ACTION_RPT_GL_REMARKS,[crm_rpt_2G_action_rpt_GL].[bill_cycle] AS CRM_RPT_2G_ACTION_RPT_GL_BILL_CYCLE,[crm_rpt_2G_action_rpt_GL].[addr_2] AS CRM_RPT_2G_ACTION_RPT_GL_ADDR_2,[crm_rpt_2G_action_rpt_GL].[id_number] AS CRM_RPT_2G_ACTION_RPT_GL_ID_NUMBER,[crm_rpt_2G_action_rpt_GL].[attention_name_formartted] AS CRM_RPT_2G_ACTION_RPT_GL_ATTENTION_NAME_FORMARTTED,[crm_rpt_2G_action_rpt_GL].[customer_name_formartted] AS CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_NAME_FORMARTTED,[crm_rpt_2G_action_rpt_GL].[mnp_rebate_end_date] AS CRM_RPT_2G_ACTION_RPT_GL_MNP_REBATE_END_DATE,[crm_rpt_2G_action_rpt_GL].[field3] AS CRM_RPT_2G_ACTION_RPT_GL_FIELD3,[crm_rpt_2G_action_rpt_GL].[addr_4] AS CRM_RPT_2G_ACTION_RPT_GL_ADDR_4,[crm_rpt_2G_action_rpt_GL].[program] AS CRM_RPT_2G_ACTION_RPT_GL_PROGRAM,[crm_rpt_2G_action_rpt_GL].[prop_plan] AS CRM_RPT_2G_ACTION_RPT_GL_PROP_PLAN,[crm_rpt_2G_action_rpt_GL].[expired_month] AS CRM_RPT_2G_ACTION_RPT_GL_EXPIRED_MONTH,[crm_rpt_2G_action_rpt_GL].[customer_group] AS CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_GROUP,[crm_rpt_2G_action_rpt_GL].[join_date] AS CRM_RPT_2G_ACTION_RPT_GL_JOIN_DATE,[crm_rpt_2G_action_rpt_GL].[idd_flg] AS CRM_RPT_2G_ACTION_RPT_GL_IDD_FLG,[crm_rpt_2G_action_rpt_GL].[active] AS CRM_RPT_2G_ACTION_RPT_GL_ACTIVE,[crm_rpt_2G_action_rpt_GL].[period] AS CRM_RPT_2G_ACTION_RPT_GL_PERIOD,[crm_rpt_2G_action_rpt_GL].[field2] AS CRM_RPT_2G_ACTION_RPT_GL_FIELD2,[crm_rpt_2G_action_rpt_GL].[start_date] AS CRM_RPT_2G_ACTION_RPT_GL_START_DATE,[crm_rpt_2G_action_rpt_GL].[plan_fee] AS CRM_RPT_2G_ACTION_RPT_GL_PLAN_FEE,[crm_rpt_2G_action_rpt_GL].[rate_plan] AS CRM_RPT_2G_ACTION_RPT_GL_RATE_PLAN,[crm_rpt_2G_action_rpt_GL].[segment] AS CRM_RPT_2G_ACTION_RPT_GL_SEGMENT,[crm_rpt_2G_action_rpt_GL].[cdate] AS CRM_RPT_2G_ACTION_RPT_GL_CDATE,[crm_rpt_2G_action_rpt_GL].[program_id] AS CRM_RPT_2G_ACTION_RPT_GL_PROGRAM_ID,[crm_rpt_2G_action_rpt_GL].[password] AS CRM_RPT_2G_ACTION_RPT_GL_PASSWORD,[crm_rpt_2G_action_rpt_GL].[payment_method] AS CRM_RPT_2G_ACTION_RPT_GL_PAYMENT_METHOD,[crm_rpt_2G_action_rpt_GL].[contract_id] AS CRM_RPT_2G_ACTION_RPT_GL_CONTRACT_ID,[crm_rpt_2G_action_rpt_GL].[customer_code] AS CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_CODE,[crm_rpt_2G_action_rpt_GL].[mobile_no] AS CRM_RPT_2G_ACTION_RPT_GL_MOBILE_NO,[crm_rpt_2G_action_rpt_GL].[als_flg] AS CRM_RPT_2G_ACTION_RPT_GL_ALS_FLG,[crm_rpt_2G_action_rpt_GL].[vas_desc] AS CRM_RPT_2G_ACTION_RPT_GL_VAS_DESC,[crm_rpt_2G_action_rpt_GL].[addr_3] AS CRM_RPT_2G_ACTION_RPT_GL_ADDR_3,[crm_rpt_2G_action_rpt_GL].[subscriber_tier] AS CRM_RPT_2G_ACTION_RPT_GL_SUBSCRIBER_TIER,[crm_rpt_2G_action_rpt_GL].[customer_id] AS CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_ID,[crm_rpt_2G_action_rpt_GL].[handset_rebate_end_date] AS CRM_RPT_2G_ACTION_RPT_GL_HANDSET_REBATE_END_DATE,[crm_rpt_2G_action_rpt_GL].[plan_free_inter_min] AS CRM_RPT_2G_ACTION_RPT_GL_PLAN_FREE_INTER_MIN,[crm_rpt_2G_action_rpt_GL].[cid] AS CRM_RPT_2G_ACTION_RPT_GL_CID,[crm_rpt_2G_action_rpt_GL].[did] AS CRM_RPT_2G_ACTION_RPT_GL_DID,[crm_rpt_2G_action_rpt_GL].[id] AS CRM_RPT_2G_ACTION_RPT_GL_ID,[crm_rpt_2G_action_rpt_GL].[plan_free_intra_min] AS CRM_RPT_2G_ACTION_RPT_GL_PLAN_FREE_INTRA_MIN,[crm_rpt_2G_action_rpt_GL].[original_telemarketing_suppress_flag] AS CRM_RPT_2G_ACTION_RPT_GL_ORIGINAL_TELEMARKETING_SUPPRESS_FLAG,[crm_rpt_2G_action_rpt_GL].[contact_number] AS CRM_RPT_2G_ACTION_RPT_GL_CONTACT_NUMBER,[crm_rpt_2G_action_rpt_GL].[addr_1] AS CRM_RPT_2G_ACTION_RPT_GL_ADDR_1,[crm_rpt_2G_action_rpt_GL].[max_contract_end_date] AS CRM_RPT_2G_ACTION_RPT_GL_MAX_CONTRACT_END_DATE,[crm_rpt_2G_action_rpt_GL].[id1] AS CRM_RPT_2G_ACTION_RPT_GL_ID1,[crm_rpt_2G_action_rpt_GL].[autopay] AS CRM_RPT_2G_ACTION_RPT_GL_AUTOPAY";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[crm_rpt_2G_action_rpt_GL]","["+ Configurator.MSSQLTablePrefix + "crm_rpt_2G_action_rpt_GL]"); }
            SqlDataReader _oData = Crm_rpt_2G_action_rpt_GLRepositoryBase.GetSearch(x_oDB, _sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                Crm_rpt_2G_action_rpt_GL _oCrm_rpt_2G_action_rpt_GL = new Crm_rpt_2G_action_rpt_GL();
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ALS_FLG"])) {_oCrm_rpt_2G_action_rpt_GL.als_flg = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_ALS_FLG"]; } else {_oCrm_rpt_2G_action_rpt_GL.als_flg=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_END_DATE"])) {_oCrm_rpt_2G_action_rpt_GL.end_date = (System.Nullable<DateTime>)_oData["CRM_RPT_2G_ACTION_RPT_GL_END_DATE"]; } else {_oCrm_rpt_2G_action_rpt_GL.end_date=null; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_REMARKS"])) {_oCrm_rpt_2G_action_rpt_GL.remarks = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_REMARKS"]; } else {_oCrm_rpt_2G_action_rpt_GL.remarks=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_AIRTIME_HS_MODEL"])) {_oCrm_rpt_2G_action_rpt_GL.airtime_hs_model = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_AIRTIME_HS_MODEL"]; } else {_oCrm_rpt_2G_action_rpt_GL.airtime_hs_model=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_START_DATE"])) {_oCrm_rpt_2G_action_rpt_GL.start_date = (System.Nullable<DateTime>)_oData["CRM_RPT_2G_ACTION_RPT_GL_START_DATE"]; } else {_oCrm_rpt_2G_action_rpt_GL.start_date=null; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CALLLIST_NAME"])) {_oCrm_rpt_2G_action_rpt_GL.calllist_name = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_CALLLIST_NAME"]; } else {_oCrm_rpt_2G_action_rpt_GL.calllist_name=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_JOIN_DATE"])) {_oCrm_rpt_2G_action_rpt_GL.join_date = (System.Nullable<DateTime>)_oData["CRM_RPT_2G_ACTION_RPT_GL_JOIN_DATE"]; } else {_oCrm_rpt_2G_action_rpt_GL.join_date=null; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_FIELD1"])) {_oCrm_rpt_2G_action_rpt_GL.field1 = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_FIELD1"]; } else {_oCrm_rpt_2G_action_rpt_GL.field1=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_BILL_CYCLE"])) {_oCrm_rpt_2G_action_rpt_GL.bill_cycle = (System.Nullable<int>)_oData["CRM_RPT_2G_ACTION_RPT_GL_BILL_CYCLE"]; } else {_oCrm_rpt_2G_action_rpt_GL.bill_cycle=null; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ADDR_3"])) {_oCrm_rpt_2G_action_rpt_GL.addr_3 = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_ADDR_3"]; } else {_oCrm_rpt_2G_action_rpt_GL.addr_3=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ADDR_2"])) {_oCrm_rpt_2G_action_rpt_GL.addr_2 = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_ADDR_2"]; } else {_oCrm_rpt_2G_action_rpt_GL.addr_2=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ID_NUMBER"])) {_oCrm_rpt_2G_action_rpt_GL.id_number = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_ID_NUMBER"]; } else {_oCrm_rpt_2G_action_rpt_GL.id_number=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ATTENTION_NAME_FORMARTTED"])) {_oCrm_rpt_2G_action_rpt_GL.attention_name_formartted = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_ATTENTION_NAME_FORMARTTED"]; } else {_oCrm_rpt_2G_action_rpt_GL.attention_name_formartted=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_NAME_FORMARTTED"])) {_oCrm_rpt_2G_action_rpt_GL.customer_name_formartted = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_NAME_FORMARTTED"]; } else {_oCrm_rpt_2G_action_rpt_GL.customer_name_formartted=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_AUTOPAY"])) {_oCrm_rpt_2G_action_rpt_GL.autopay = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_AUTOPAY"]; } else {_oCrm_rpt_2G_action_rpt_GL.autopay=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_FIELD3"])) {_oCrm_rpt_2G_action_rpt_GL.field3 = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_FIELD3"]; } else {_oCrm_rpt_2G_action_rpt_GL.field3=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ADDR_4"])) {_oCrm_rpt_2G_action_rpt_GL.addr_4 = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_ADDR_4"]; } else {_oCrm_rpt_2G_action_rpt_GL.addr_4=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PROGRAM"])) {_oCrm_rpt_2G_action_rpt_GL.program = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_PROGRAM"]; } else {_oCrm_rpt_2G_action_rpt_GL.program=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PROP_PLAN"])) {_oCrm_rpt_2G_action_rpt_GL.prop_plan = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_PROP_PLAN"]; } else {_oCrm_rpt_2G_action_rpt_GL.prop_plan=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_GROUP"])) {_oCrm_rpt_2G_action_rpt_GL.customer_group = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_GROUP"]; } else {_oCrm_rpt_2G_action_rpt_GL.customer_group=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_CODE"])) {_oCrm_rpt_2G_action_rpt_GL.customer_code = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_CODE"]; } else {_oCrm_rpt_2G_action_rpt_GL.customer_code=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_TELEMARKETING_SUPPRESS_FLAG"])) {_oCrm_rpt_2G_action_rpt_GL.telemarketing_suppress_flag = (System.Nullable<bool>)_oData["CRM_RPT_2G_ACTION_RPT_GL_TELEMARKETING_SUPPRESS_FLAG"]; } else {_oCrm_rpt_2G_action_rpt_GL.telemarketing_suppress_flag=null; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_IDD_FLG"])) {_oCrm_rpt_2G_action_rpt_GL.idd_flg = (System.Nullable<bool>)_oData["CRM_RPT_2G_ACTION_RPT_GL_IDD_FLG"]; } else {_oCrm_rpt_2G_action_rpt_GL.idd_flg=null; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ACTIVE"])) {_oCrm_rpt_2G_action_rpt_GL.active = (System.Nullable<bool>)_oData["CRM_RPT_2G_ACTION_RPT_GL_ACTIVE"]; } else {_oCrm_rpt_2G_action_rpt_GL.active=null; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_DDATE"])) {_oCrm_rpt_2G_action_rpt_GL.ddate = (System.Nullable<DateTime>)_oData["CRM_RPT_2G_ACTION_RPT_GL_DDATE"]; } else {_oCrm_rpt_2G_action_rpt_GL.ddate=null; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ID"])) {_oCrm_rpt_2G_action_rpt_GL.id = (System.Nullable<int>)_oData["CRM_RPT_2G_ACTION_RPT_GL_ID"]; } else {_oCrm_rpt_2G_action_rpt_GL.id=null; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PLAN_FEE"])) {_oCrm_rpt_2G_action_rpt_GL.plan_fee = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_PLAN_FEE"]; } else {_oCrm_rpt_2G_action_rpt_GL.plan_fee=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_RATE_PLAN"])) {_oCrm_rpt_2G_action_rpt_GL.rate_plan = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_RATE_PLAN"]; } else {_oCrm_rpt_2G_action_rpt_GL.rate_plan=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_SEGMENT"])) {_oCrm_rpt_2G_action_rpt_GL.segment = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_SEGMENT"]; } else {_oCrm_rpt_2G_action_rpt_GL.segment=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ID1"])) {_oCrm_rpt_2G_action_rpt_GL.id1 = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_ID1"]; } else {_oCrm_rpt_2G_action_rpt_GL.id1=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PASSWORD"])) {_oCrm_rpt_2G_action_rpt_GL.password = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_PASSWORD"]; } else {_oCrm_rpt_2G_action_rpt_GL.password=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PAYMENT_METHOD"])) {_oCrm_rpt_2G_action_rpt_GL.payment_method = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_PAYMENT_METHOD"]; } else {_oCrm_rpt_2G_action_rpt_GL.payment_method=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CONTRACT_ID"])) {_oCrm_rpt_2G_action_rpt_GL.contract_id = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_CONTRACT_ID"]; } else {_oCrm_rpt_2G_action_rpt_GL.contract_id=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_FIELD2"])) {_oCrm_rpt_2G_action_rpt_GL.field2 = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_FIELD2"]; } else {_oCrm_rpt_2G_action_rpt_GL.field2=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_MOBILE_NO"])) {_oCrm_rpt_2G_action_rpt_GL.mobile_no = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_MOBILE_NO"]; } else {_oCrm_rpt_2G_action_rpt_GL.mobile_no=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PERIOD"])) {_oCrm_rpt_2G_action_rpt_GL.period = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_PERIOD"]; } else {_oCrm_rpt_2G_action_rpt_GL.period=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_VAS_DESC"])) {_oCrm_rpt_2G_action_rpt_GL.vas_desc = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_VAS_DESC"]; } else {_oCrm_rpt_2G_action_rpt_GL.vas_desc=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CDATE"])) {_oCrm_rpt_2G_action_rpt_GL.cdate = (System.Nullable<DateTime>)_oData["CRM_RPT_2G_ACTION_RPT_GL_CDATE"]; } else {_oCrm_rpt_2G_action_rpt_GL.cdate=null; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_SUBSCRIBER_TIER"])) {_oCrm_rpt_2G_action_rpt_GL.subscriber_tier = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_SUBSCRIBER_TIER"]; } else {_oCrm_rpt_2G_action_rpt_GL.subscriber_tier=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_ID"])) {_oCrm_rpt_2G_action_rpt_GL.customer_id = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_ID"]; } else {_oCrm_rpt_2G_action_rpt_GL.customer_id=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_HANDSET_REBATE_END_DATE"])) {_oCrm_rpt_2G_action_rpt_GL.handset_rebate_end_date = (System.Nullable<DateTime>)_oData["CRM_RPT_2G_ACTION_RPT_GL_HANDSET_REBATE_END_DATE"]; } else {_oCrm_rpt_2G_action_rpt_GL.handset_rebate_end_date=null; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PLAN_FREE_INTER_MIN"])) {_oCrm_rpt_2G_action_rpt_GL.plan_free_inter_min = (System.Nullable<int>)_oData["CRM_RPT_2G_ACTION_RPT_GL_PLAN_FREE_INTER_MIN"]; } else {_oCrm_rpt_2G_action_rpt_GL.plan_free_inter_min=null; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CID"])) {_oCrm_rpt_2G_action_rpt_GL.cid = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_CID"]; } else {_oCrm_rpt_2G_action_rpt_GL.cid=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_DID"])) {_oCrm_rpt_2G_action_rpt_GL.did = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_DID"]; } else {_oCrm_rpt_2G_action_rpt_GL.did=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_EXPIRED_MONTH"])) {_oCrm_rpt_2G_action_rpt_GL.expired_month = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_EXPIRED_MONTH"]; } else {_oCrm_rpt_2G_action_rpt_GL.expired_month=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PLAN_FREE_INTRA_MIN"])) {_oCrm_rpt_2G_action_rpt_GL.plan_free_intra_min = (System.Nullable<int>)_oData["CRM_RPT_2G_ACTION_RPT_GL_PLAN_FREE_INTRA_MIN"]; } else {_oCrm_rpt_2G_action_rpt_GL.plan_free_intra_min=null; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ORIGINAL_TELEMARKETING_SUPPRESS_FLAG"])) {_oCrm_rpt_2G_action_rpt_GL.original_telemarketing_suppress_flag = (System.Nullable<bool>)_oData["CRM_RPT_2G_ACTION_RPT_GL_ORIGINAL_TELEMARKETING_SUPPRESS_FLAG"]; } else {_oCrm_rpt_2G_action_rpt_GL.original_telemarketing_suppress_flag=null; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CONTACT_NUMBER"])) {_oCrm_rpt_2G_action_rpt_GL.contact_number = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_CONTACT_NUMBER"]; } else {_oCrm_rpt_2G_action_rpt_GL.contact_number=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_TRADEFIELD"])) {_oCrm_rpt_2G_action_rpt_GL.tradefield = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_TRADEFIELD"]; } else {_oCrm_rpt_2G_action_rpt_GL.tradefield=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ADDR_1"])) {_oCrm_rpt_2G_action_rpt_GL.addr_1 = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_ADDR_1"]; } else {_oCrm_rpt_2G_action_rpt_GL.addr_1=string.Empty; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_MAX_CONTRACT_END_DATE"])) {_oCrm_rpt_2G_action_rpt_GL.max_contract_end_date = (System.Nullable<DateTime>)_oData["CRM_RPT_2G_ACTION_RPT_GL_MAX_CONTRACT_END_DATE"]; } else {_oCrm_rpt_2G_action_rpt_GL.max_contract_end_date=null; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_MNP_REBATE_END_DATE"])) {_oCrm_rpt_2G_action_rpt_GL.mnp_rebate_end_date = (System.Nullable<DateTime>)_oData["CRM_RPT_2G_ACTION_RPT_GL_MNP_REBATE_END_DATE"]; } else {_oCrm_rpt_2G_action_rpt_GL.mnp_rebate_end_date=null; }
                if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PROGRAM_ID"])) {_oCrm_rpt_2G_action_rpt_GL.program_id = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_PROGRAM_ID"]; } else {_oCrm_rpt_2G_action_rpt_GL.program_id=string.Empty; }
                _oCrm_rpt_2G_action_rpt_GL.SetDB(x_oDB);
                _oCrm_rpt_2G_action_rpt_GL.GetFound();
                _oRow.Add(_oCrm_rpt_2G_action_rpt_GL);
            }
            _oData.Close();
            _oData.Dispose();
            return _oRow.Count == 0 ? null : _oRow.ToArray();
        }
        #endregion
        
        #region List
        /// <summary>
        /// Summary description for get table from records with DataSet
        /// </summary>
        
        public DataSet GetDataSet()
        {
            return GetDataSet(n_oDB,"");
        }
        
        
        public DataSet GetDataSet(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return GetDataSet(n_oDB,x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public static DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            DataSet _oDset = x_oDB.GetDataSet( Crm_rpt_2G_action_rpt_GL.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,Crm_rpt_2G_action_rpt_GL.Para.TableName());
            return _oDset;
        }
        
        
        public static SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(Crm_rpt_2G_action_rpt_GL.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(Crm_rpt_2G_action_rpt_GL.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT [crm_rpt_2G_action_rpt_GL].[telemarketing_suppress_flag] AS CRM_RPT_2G_ACTION_RPT_GL_TELEMARKETING_SUPPRESS_FLAG,[crm_rpt_2G_action_rpt_GL].[end_date] AS CRM_RPT_2G_ACTION_RPT_GL_END_DATE,[crm_rpt_2G_action_rpt_GL].[ddate] AS CRM_RPT_2G_ACTION_RPT_GL_DDATE,[crm_rpt_2G_action_rpt_GL].[airtime_hs_model] AS CRM_RPT_2G_ACTION_RPT_GL_AIRTIME_HS_MODEL,[crm_rpt_2G_action_rpt_GL].[tradefield] AS CRM_RPT_2G_ACTION_RPT_GL_TRADEFIELD,[crm_rpt_2G_action_rpt_GL].[calllist_name] AS CRM_RPT_2G_ACTION_RPT_GL_CALLLIST_NAME,[crm_rpt_2G_action_rpt_GL].[field1] AS CRM_RPT_2G_ACTION_RPT_GL_FIELD1,[crm_rpt_2G_action_rpt_GL].[remarks] AS CRM_RPT_2G_ACTION_RPT_GL_REMARKS,[crm_rpt_2G_action_rpt_GL].[bill_cycle] AS CRM_RPT_2G_ACTION_RPT_GL_BILL_CYCLE,[crm_rpt_2G_action_rpt_GL].[addr_2] AS CRM_RPT_2G_ACTION_RPT_GL_ADDR_2,[crm_rpt_2G_action_rpt_GL].[id_number] AS CRM_RPT_2G_ACTION_RPT_GL_ID_NUMBER,[crm_rpt_2G_action_rpt_GL].[attention_name_formartted] AS CRM_RPT_2G_ACTION_RPT_GL_ATTENTION_NAME_FORMARTTED,[crm_rpt_2G_action_rpt_GL].[customer_name_formartted] AS CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_NAME_FORMARTTED,[crm_rpt_2G_action_rpt_GL].[mnp_rebate_end_date] AS CRM_RPT_2G_ACTION_RPT_GL_MNP_REBATE_END_DATE,[crm_rpt_2G_action_rpt_GL].[field3] AS CRM_RPT_2G_ACTION_RPT_GL_FIELD3,[crm_rpt_2G_action_rpt_GL].[addr_4] AS CRM_RPT_2G_ACTION_RPT_GL_ADDR_4,[crm_rpt_2G_action_rpt_GL].[program] AS CRM_RPT_2G_ACTION_RPT_GL_PROGRAM,[crm_rpt_2G_action_rpt_GL].[prop_plan] AS CRM_RPT_2G_ACTION_RPT_GL_PROP_PLAN,[crm_rpt_2G_action_rpt_GL].[expired_month] AS CRM_RPT_2G_ACTION_RPT_GL_EXPIRED_MONTH,[crm_rpt_2G_action_rpt_GL].[customer_group] AS CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_GROUP,[crm_rpt_2G_action_rpt_GL].[join_date] AS CRM_RPT_2G_ACTION_RPT_GL_JOIN_DATE,[crm_rpt_2G_action_rpt_GL].[idd_flg] AS CRM_RPT_2G_ACTION_RPT_GL_IDD_FLG,[crm_rpt_2G_action_rpt_GL].[active] AS CRM_RPT_2G_ACTION_RPT_GL_ACTIVE,[crm_rpt_2G_action_rpt_GL].[period] AS CRM_RPT_2G_ACTION_RPT_GL_PERIOD,[crm_rpt_2G_action_rpt_GL].[field2] AS CRM_RPT_2G_ACTION_RPT_GL_FIELD2,[crm_rpt_2G_action_rpt_GL].[start_date] AS CRM_RPT_2G_ACTION_RPT_GL_START_DATE,[crm_rpt_2G_action_rpt_GL].[plan_fee] AS CRM_RPT_2G_ACTION_RPT_GL_PLAN_FEE,[crm_rpt_2G_action_rpt_GL].[rate_plan] AS CRM_RPT_2G_ACTION_RPT_GL_RATE_PLAN,[crm_rpt_2G_action_rpt_GL].[segment] AS CRM_RPT_2G_ACTION_RPT_GL_SEGMENT,[crm_rpt_2G_action_rpt_GL].[cdate] AS CRM_RPT_2G_ACTION_RPT_GL_CDATE,[crm_rpt_2G_action_rpt_GL].[program_id] AS CRM_RPT_2G_ACTION_RPT_GL_PROGRAM_ID,[crm_rpt_2G_action_rpt_GL].[password] AS CRM_RPT_2G_ACTION_RPT_GL_PASSWORD,[crm_rpt_2G_action_rpt_GL].[payment_method] AS CRM_RPT_2G_ACTION_RPT_GL_PAYMENT_METHOD,[crm_rpt_2G_action_rpt_GL].[contract_id] AS CRM_RPT_2G_ACTION_RPT_GL_CONTRACT_ID,[crm_rpt_2G_action_rpt_GL].[customer_code] AS CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_CODE,[crm_rpt_2G_action_rpt_GL].[mobile_no] AS CRM_RPT_2G_ACTION_RPT_GL_MOBILE_NO,[crm_rpt_2G_action_rpt_GL].[als_flg] AS CRM_RPT_2G_ACTION_RPT_GL_ALS_FLG,[crm_rpt_2G_action_rpt_GL].[vas_desc] AS CRM_RPT_2G_ACTION_RPT_GL_VAS_DESC,[crm_rpt_2G_action_rpt_GL].[addr_3] AS CRM_RPT_2G_ACTION_RPT_GL_ADDR_3,[crm_rpt_2G_action_rpt_GL].[subscriber_tier] AS CRM_RPT_2G_ACTION_RPT_GL_SUBSCRIBER_TIER,[crm_rpt_2G_action_rpt_GL].[customer_id] AS CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_ID,[crm_rpt_2G_action_rpt_GL].[handset_rebate_end_date] AS CRM_RPT_2G_ACTION_RPT_GL_HANDSET_REBATE_END_DATE,[crm_rpt_2G_action_rpt_GL].[plan_free_inter_min] AS CRM_RPT_2G_ACTION_RPT_GL_PLAN_FREE_INTER_MIN,[crm_rpt_2G_action_rpt_GL].[cid] AS CRM_RPT_2G_ACTION_RPT_GL_CID,[crm_rpt_2G_action_rpt_GL].[did] AS CRM_RPT_2G_ACTION_RPT_GL_DID,[crm_rpt_2G_action_rpt_GL].[id] AS CRM_RPT_2G_ACTION_RPT_GL_ID,[crm_rpt_2G_action_rpt_GL].[plan_free_intra_min] AS CRM_RPT_2G_ACTION_RPT_GL_PLAN_FREE_INTRA_MIN,[crm_rpt_2G_action_rpt_GL].[original_telemarketing_suppress_flag] AS CRM_RPT_2G_ACTION_RPT_GL_ORIGINAL_TELEMARKETING_SUPPRESS_FLAG,[crm_rpt_2G_action_rpt_GL].[contact_number] AS CRM_RPT_2G_ACTION_RPT_GL_CONTACT_NUMBER,[crm_rpt_2G_action_rpt_GL].[addr_1] AS CRM_RPT_2G_ACTION_RPT_GL_ADDR_1,[crm_rpt_2G_action_rpt_GL].[max_contract_end_date] AS CRM_RPT_2G_ACTION_RPT_GL_MAX_CONTRACT_END_DATE,[crm_rpt_2G_action_rpt_GL].[id1] AS CRM_RPT_2G_ACTION_RPT_GL_ID1,[crm_rpt_2G_action_rpt_GL].[autopay] AS CRM_RPT_2G_ACTION_RPT_GL_AUTOPAY  FROM  [crm_rpt_2G_action_rpt_GL]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[crm_rpt_2G_action_rpt_GL]","["+ Configurator.MSSQLTablePrefix + "crm_rpt_2G_action_rpt_GL]"); }
            using(SqlConnection _oConn = x_oDB.GetConnection()){
                SqlDataAdapter _oAdp = new SqlDataAdapter();
                DataSet _oDset = new DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"crm_rpt_2G_action_rpt_GL");
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
        
        public bool Insert(string x_sAls_flg,System.Nullable<DateTime> x_dEnd_date,string x_sRemarks,string x_sAirtime_hs_model,System.Nullable<DateTime> x_dStart_date,string x_sCalllist_name,System.Nullable<DateTime> x_dJoin_date,string x_sField1,System.Nullable<int> x_iBill_cycle,string x_sAddr_3,string x_sAddr_2,string x_sId_number,string x_sAttention_name_formartted,string x_sCustomer_name_formartted,string x_sAutopay,string x_sField3,string x_sAddr_4,string x_sProgram,string x_sProp_plan,string x_sCustomer_group,string x_sCustomer_code,System.Nullable<bool> x_bTelemarketing_suppress_flag,System.Nullable<bool> x_bIdd_flg,System.Nullable<bool> x_bActive,System.Nullable<DateTime> x_dDdate,string x_sPlan_fee,string x_sRate_plan,string x_sSegment,string x_sId1,string x_sPassword,string x_sPayment_method,string x_sContract_id,string x_sField2,string x_sMobile_no,string x_sPeriod,string x_sVas_desc,System.Nullable<DateTime> x_dCdate,string x_sSubscriber_tier,string x_sCustomer_id,System.Nullable<DateTime> x_dHandset_rebate_end_date,System.Nullable<int> x_iPlan_free_inter_min,string x_sCid,string x_sDid,string x_sExpired_month,System.Nullable<int> x_iPlan_free_intra_min,System.Nullable<bool> x_bOriginal_telemarketing_suppress_flag,string x_sContact_number,string x_sTradefield,string x_sAddr_1,System.Nullable<DateTime> x_dMax_contract_end_date,System.Nullable<DateTime> x_dMnp_rebate_end_date,string x_sProgram_id)
        {
            Crm_rpt_2G_action_rpt_GL _oCrm_rpt_2G_action_rpt_GL=new Crm_rpt_2G_action_rpt_GL();
            _oCrm_rpt_2G_action_rpt_GL.als_flg=x_sAls_flg;
            _oCrm_rpt_2G_action_rpt_GL.end_date=x_dEnd_date;
            _oCrm_rpt_2G_action_rpt_GL.remarks=x_sRemarks;
            _oCrm_rpt_2G_action_rpt_GL.airtime_hs_model=x_sAirtime_hs_model;
            _oCrm_rpt_2G_action_rpt_GL.start_date=x_dStart_date;
            _oCrm_rpt_2G_action_rpt_GL.calllist_name=x_sCalllist_name;
            _oCrm_rpt_2G_action_rpt_GL.join_date=x_dJoin_date;
            _oCrm_rpt_2G_action_rpt_GL.field1=x_sField1;
            _oCrm_rpt_2G_action_rpt_GL.bill_cycle=x_iBill_cycle;
            _oCrm_rpt_2G_action_rpt_GL.addr_3=x_sAddr_3;
            _oCrm_rpt_2G_action_rpt_GL.addr_2=x_sAddr_2;
            _oCrm_rpt_2G_action_rpt_GL.id_number=x_sId_number;
            _oCrm_rpt_2G_action_rpt_GL.attention_name_formartted=x_sAttention_name_formartted;
            _oCrm_rpt_2G_action_rpt_GL.customer_name_formartted=x_sCustomer_name_formartted;
            _oCrm_rpt_2G_action_rpt_GL.autopay=x_sAutopay;
            _oCrm_rpt_2G_action_rpt_GL.field3=x_sField3;
            _oCrm_rpt_2G_action_rpt_GL.addr_4=x_sAddr_4;
            _oCrm_rpt_2G_action_rpt_GL.program=x_sProgram;
            _oCrm_rpt_2G_action_rpt_GL.prop_plan=x_sProp_plan;
            _oCrm_rpt_2G_action_rpt_GL.customer_group=x_sCustomer_group;
            _oCrm_rpt_2G_action_rpt_GL.customer_code=x_sCustomer_code;
            _oCrm_rpt_2G_action_rpt_GL.telemarketing_suppress_flag=x_bTelemarketing_suppress_flag;
            _oCrm_rpt_2G_action_rpt_GL.idd_flg=x_bIdd_flg;
            _oCrm_rpt_2G_action_rpt_GL.active=x_bActive;
            _oCrm_rpt_2G_action_rpt_GL.ddate=x_dDdate;
            _oCrm_rpt_2G_action_rpt_GL.plan_fee=x_sPlan_fee;
            _oCrm_rpt_2G_action_rpt_GL.rate_plan=x_sRate_plan;
            _oCrm_rpt_2G_action_rpt_GL.segment=x_sSegment;
            _oCrm_rpt_2G_action_rpt_GL.id1=x_sId1;
            _oCrm_rpt_2G_action_rpt_GL.password=x_sPassword;
            _oCrm_rpt_2G_action_rpt_GL.payment_method=x_sPayment_method;
            _oCrm_rpt_2G_action_rpt_GL.contract_id=x_sContract_id;
            _oCrm_rpt_2G_action_rpt_GL.field2=x_sField2;
            _oCrm_rpt_2G_action_rpt_GL.mobile_no=x_sMobile_no;
            _oCrm_rpt_2G_action_rpt_GL.period=x_sPeriod;
            _oCrm_rpt_2G_action_rpt_GL.vas_desc=x_sVas_desc;
            _oCrm_rpt_2G_action_rpt_GL.cdate=x_dCdate;
            _oCrm_rpt_2G_action_rpt_GL.subscriber_tier=x_sSubscriber_tier;
            _oCrm_rpt_2G_action_rpt_GL.customer_id=x_sCustomer_id;
            _oCrm_rpt_2G_action_rpt_GL.handset_rebate_end_date=x_dHandset_rebate_end_date;
            _oCrm_rpt_2G_action_rpt_GL.plan_free_inter_min=x_iPlan_free_inter_min;
            _oCrm_rpt_2G_action_rpt_GL.cid=x_sCid;
            _oCrm_rpt_2G_action_rpt_GL.did=x_sDid;
            _oCrm_rpt_2G_action_rpt_GL.expired_month=x_sExpired_month;
            _oCrm_rpt_2G_action_rpt_GL.plan_free_intra_min=x_iPlan_free_intra_min;
            _oCrm_rpt_2G_action_rpt_GL.original_telemarketing_suppress_flag=x_bOriginal_telemarketing_suppress_flag;
            _oCrm_rpt_2G_action_rpt_GL.contact_number=x_sContact_number;
            _oCrm_rpt_2G_action_rpt_GL.tradefield=x_sTradefield;
            _oCrm_rpt_2G_action_rpt_GL.addr_1=x_sAddr_1;
            _oCrm_rpt_2G_action_rpt_GL.max_contract_end_date=x_dMax_contract_end_date;
            _oCrm_rpt_2G_action_rpt_GL.mnp_rebate_end_date=x_dMnp_rebate_end_date;
            _oCrm_rpt_2G_action_rpt_GL.program_id=x_sProgram_id;
            return InsertWithOutLastID(n_oDB, _oCrm_rpt_2G_action_rpt_GL);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sAls_flg,System.Nullable<DateTime> x_dEnd_date,string x_sRemarks,string x_sAirtime_hs_model,System.Nullable<DateTime> x_dStart_date,string x_sCalllist_name,System.Nullable<DateTime> x_dJoin_date,string x_sField1,System.Nullable<int> x_iBill_cycle,string x_sAddr_3,string x_sAddr_2,string x_sId_number,string x_sAttention_name_formartted,string x_sCustomer_name_formartted,string x_sAutopay,string x_sField3,string x_sAddr_4,string x_sProgram,string x_sProp_plan,string x_sCustomer_group,string x_sCustomer_code,System.Nullable<bool> x_bTelemarketing_suppress_flag,System.Nullable<bool> x_bIdd_flg,System.Nullable<bool> x_bActive,System.Nullable<DateTime> x_dDdate,string x_sPlan_fee,string x_sRate_plan,string x_sSegment,string x_sId1,string x_sPassword,string x_sPayment_method,string x_sContract_id,string x_sField2,string x_sMobile_no,string x_sPeriod,string x_sVas_desc,System.Nullable<DateTime> x_dCdate,string x_sSubscriber_tier,string x_sCustomer_id,System.Nullable<DateTime> x_dHandset_rebate_end_date,System.Nullable<int> x_iPlan_free_inter_min,string x_sCid,string x_sDid,string x_sExpired_month,System.Nullable<int> x_iPlan_free_intra_min,System.Nullable<bool> x_bOriginal_telemarketing_suppress_flag,string x_sContact_number,string x_sTradefield,string x_sAddr_1,System.Nullable<DateTime> x_dMax_contract_end_date,System.Nullable<DateTime> x_dMnp_rebate_end_date,string x_sProgram_id)
        {
            Crm_rpt_2G_action_rpt_GL _oCrm_rpt_2G_action_rpt_GL=new Crm_rpt_2G_action_rpt_GL();
            _oCrm_rpt_2G_action_rpt_GL.als_flg=x_sAls_flg;
            _oCrm_rpt_2G_action_rpt_GL.end_date=x_dEnd_date;
            _oCrm_rpt_2G_action_rpt_GL.remarks=x_sRemarks;
            _oCrm_rpt_2G_action_rpt_GL.airtime_hs_model=x_sAirtime_hs_model;
            _oCrm_rpt_2G_action_rpt_GL.start_date=x_dStart_date;
            _oCrm_rpt_2G_action_rpt_GL.calllist_name=x_sCalllist_name;
            _oCrm_rpt_2G_action_rpt_GL.join_date=x_dJoin_date;
            _oCrm_rpt_2G_action_rpt_GL.field1=x_sField1;
            _oCrm_rpt_2G_action_rpt_GL.bill_cycle=x_iBill_cycle;
            _oCrm_rpt_2G_action_rpt_GL.addr_3=x_sAddr_3;
            _oCrm_rpt_2G_action_rpt_GL.addr_2=x_sAddr_2;
            _oCrm_rpt_2G_action_rpt_GL.id_number=x_sId_number;
            _oCrm_rpt_2G_action_rpt_GL.attention_name_formartted=x_sAttention_name_formartted;
            _oCrm_rpt_2G_action_rpt_GL.customer_name_formartted=x_sCustomer_name_formartted;
            _oCrm_rpt_2G_action_rpt_GL.autopay=x_sAutopay;
            _oCrm_rpt_2G_action_rpt_GL.field3=x_sField3;
            _oCrm_rpt_2G_action_rpt_GL.addr_4=x_sAddr_4;
            _oCrm_rpt_2G_action_rpt_GL.program=x_sProgram;
            _oCrm_rpt_2G_action_rpt_GL.prop_plan=x_sProp_plan;
            _oCrm_rpt_2G_action_rpt_GL.customer_group=x_sCustomer_group;
            _oCrm_rpt_2G_action_rpt_GL.customer_code=x_sCustomer_code;
            _oCrm_rpt_2G_action_rpt_GL.telemarketing_suppress_flag=x_bTelemarketing_suppress_flag;
            _oCrm_rpt_2G_action_rpt_GL.idd_flg=x_bIdd_flg;
            _oCrm_rpt_2G_action_rpt_GL.active=x_bActive;
            _oCrm_rpt_2G_action_rpt_GL.ddate=x_dDdate;
            _oCrm_rpt_2G_action_rpt_GL.plan_fee=x_sPlan_fee;
            _oCrm_rpt_2G_action_rpt_GL.rate_plan=x_sRate_plan;
            _oCrm_rpt_2G_action_rpt_GL.segment=x_sSegment;
            _oCrm_rpt_2G_action_rpt_GL.id1=x_sId1;
            _oCrm_rpt_2G_action_rpt_GL.password=x_sPassword;
            _oCrm_rpt_2G_action_rpt_GL.payment_method=x_sPayment_method;
            _oCrm_rpt_2G_action_rpt_GL.contract_id=x_sContract_id;
            _oCrm_rpt_2G_action_rpt_GL.field2=x_sField2;
            _oCrm_rpt_2G_action_rpt_GL.mobile_no=x_sMobile_no;
            _oCrm_rpt_2G_action_rpt_GL.period=x_sPeriod;
            _oCrm_rpt_2G_action_rpt_GL.vas_desc=x_sVas_desc;
            _oCrm_rpt_2G_action_rpt_GL.cdate=x_dCdate;
            _oCrm_rpt_2G_action_rpt_GL.subscriber_tier=x_sSubscriber_tier;
            _oCrm_rpt_2G_action_rpt_GL.customer_id=x_sCustomer_id;
            _oCrm_rpt_2G_action_rpt_GL.handset_rebate_end_date=x_dHandset_rebate_end_date;
            _oCrm_rpt_2G_action_rpt_GL.plan_free_inter_min=x_iPlan_free_inter_min;
            _oCrm_rpt_2G_action_rpt_GL.cid=x_sCid;
            _oCrm_rpt_2G_action_rpt_GL.did=x_sDid;
            _oCrm_rpt_2G_action_rpt_GL.expired_month=x_sExpired_month;
            _oCrm_rpt_2G_action_rpt_GL.plan_free_intra_min=x_iPlan_free_intra_min;
            _oCrm_rpt_2G_action_rpt_GL.original_telemarketing_suppress_flag=x_bOriginal_telemarketing_suppress_flag;
            _oCrm_rpt_2G_action_rpt_GL.contact_number=x_sContact_number;
            _oCrm_rpt_2G_action_rpt_GL.tradefield=x_sTradefield;
            _oCrm_rpt_2G_action_rpt_GL.addr_1=x_sAddr_1;
            _oCrm_rpt_2G_action_rpt_GL.max_contract_end_date=x_dMax_contract_end_date;
            _oCrm_rpt_2G_action_rpt_GL.mnp_rebate_end_date=x_dMnp_rebate_end_date;
            _oCrm_rpt_2G_action_rpt_GL.program_id=x_sProgram_id;
            return InsertWithOutLastID(x_oDB, _oCrm_rpt_2G_action_rpt_GL);
        }
        
        
        public bool Insert(Crm_rpt_2G_action_rpt_GL x_oCrm_rpt_2G_action_rpt_GL)
        {
            return InsertWithOutLastID(n_oDB, x_oCrm_rpt_2G_action_rpt_GL);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is Crm_rpt_2G_action_rpt_GL)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (Crm_rpt_2G_action_rpt_GL)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,Crm_rpt_2G_action_rpt_GL x_oCrm_rpt_2G_action_rpt_GL)
        {
            return InsertWithOutLastID(x_oDB, x_oCrm_rpt_2G_action_rpt_GL);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,Crm_rpt_2G_action_rpt_GL x_oCrm_rpt_2G_action_rpt_GL)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [crm_rpt_2G_action_rpt_GL]   ([telemarketing_suppress_flag],[end_date],[ddate],[airtime_hs_model],[tradefield],[calllist_name],[field1],[remarks],[bill_cycle],[addr_2],[id_number],[attention_name_formartted],[customer_name_formartted],[mnp_rebate_end_date],[field3],[addr_4],[program],[prop_plan],[expired_month],[customer_group],[join_date],[idd_flg],[active],[period],[field2],[start_date],[plan_fee],[rate_plan],[segment],[cdate],[program_id],[password],[payment_method],[contract_id],[customer_code],[mobile_no],[als_flg],[vas_desc],[addr_3],[subscriber_tier],[customer_id],[handset_rebate_end_date],[plan_free_inter_min],[cid],[did],[plan_free_intra_min],[original_telemarketing_suppress_flag],[contact_number],[addr_1],[max_contract_end_date],[id1],[autopay])  VALUES  (@telemarketing_suppress_flag,@end_date,@ddate,@airtime_hs_model,@tradefield,@calllist_name,@field1,@remarks,@bill_cycle,@addr_2,@id_number,@attention_name_formartted,@customer_name_formartted,@mnp_rebate_end_date,@field3,@addr_4,@program,@prop_plan,@expired_month,@customer_group,@join_date,@idd_flg,@active,@period,@field2,@start_date,@plan_fee,@rate_plan,@segment,@cdate,@program_id,@password,@payment_method,@contract_id,@customer_code,@mobile_no,@als_flg,@vas_desc,@addr_3,@subscriber_tier,@customer_id,@handset_rebate_end_date,@plan_free_inter_min,@cid,@did,@plan_free_intra_min,@original_telemarketing_suppress_flag,@contact_number,@addr_1,@max_contract_end_date,@id1,@autopay)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[crm_rpt_2G_action_rpt_GL]","["+ Configurator.MSSQLTablePrefix + "crm_rpt_2G_action_rpt_GL]"); }
            SqlConnection _oConn = null;
            SqlCommand _oCmd = null;
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
                _oCmd = new SqlCommand(_sQuery, _oConn);
            }
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oCrm_rpt_2G_action_rpt_GL);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,SqlConnection x_oConn, SqlCommand x_oCmd,Crm_rpt_2G_action_rpt_GL x_oCrm_rpt_2G_action_rpt_GL)
        {
            bool _bResult = false;
            if (!x_oCrm_rpt_2G_action_rpt_GL.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oCrm_rpt_2G_action_rpt_GL.telemarketing_suppress_flag==null){  x_oCmd.Parameters.Add("@telemarketing_suppress_flag", SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@telemarketing_suppress_flag", SqlDbType.Bit).Value=x_oCrm_rpt_2G_action_rpt_GL.telemarketing_suppress_flag; }
                if(x_oCrm_rpt_2G_action_rpt_GL.end_date==null){  x_oCmd.Parameters.Add("@end_date", SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@end_date", SqlDbType.DateTime).Value=x_oCrm_rpt_2G_action_rpt_GL.end_date; }
                if(x_oCrm_rpt_2G_action_rpt_GL.ddate==null){  x_oCmd.Parameters.Add("@ddate", SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", SqlDbType.DateTime).Value=x_oCrm_rpt_2G_action_rpt_GL.ddate; }
                if(x_oCrm_rpt_2G_action_rpt_GL.airtime_hs_model==null){  x_oCmd.Parameters.Add("@airtime_hs_model", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@airtime_hs_model", SqlDbType.VarChar,50).Value=x_oCrm_rpt_2G_action_rpt_GL.airtime_hs_model; }
                if(x_oCrm_rpt_2G_action_rpt_GL.tradefield==null){  x_oCmd.Parameters.Add("@tradefield", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@tradefield", SqlDbType.VarChar,50).Value=x_oCrm_rpt_2G_action_rpt_GL.tradefield; }
                if(x_oCrm_rpt_2G_action_rpt_GL.calllist_name==null){  x_oCmd.Parameters.Add("@calllist_name", SqlDbType.VarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@calllist_name", SqlDbType.VarChar,250).Value=x_oCrm_rpt_2G_action_rpt_GL.calllist_name; }
                if(x_oCrm_rpt_2G_action_rpt_GL.field1==null){  x_oCmd.Parameters.Add("@field1", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@field1", SqlDbType.VarChar,50).Value=x_oCrm_rpt_2G_action_rpt_GL.field1; }
                if(x_oCrm_rpt_2G_action_rpt_GL.remarks==null){  x_oCmd.Parameters.Add("@remarks", SqlDbType.VarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@remarks", SqlDbType.VarChar,100).Value=x_oCrm_rpt_2G_action_rpt_GL.remarks; }
                if(x_oCrm_rpt_2G_action_rpt_GL.bill_cycle==null){  x_oCmd.Parameters.Add("@bill_cycle", SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bill_cycle", SqlDbType.Int).Value=x_oCrm_rpt_2G_action_rpt_GL.bill_cycle; }
                if(x_oCrm_rpt_2G_action_rpt_GL.addr_2==null){  x_oCmd.Parameters.Add("@addr_2", SqlDbType.VarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@addr_2", SqlDbType.VarChar,100).Value=x_oCrm_rpt_2G_action_rpt_GL.addr_2; }
                if(x_oCrm_rpt_2G_action_rpt_GL.id_number==null){  x_oCmd.Parameters.Add("@id_number", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@id_number", SqlDbType.VarChar,50).Value=x_oCrm_rpt_2G_action_rpt_GL.id_number; }
                if(x_oCrm_rpt_2G_action_rpt_GL.attention_name_formartted==null){  x_oCmd.Parameters.Add("@attention_name_formartted", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@attention_name_formartted", SqlDbType.VarChar,50).Value=x_oCrm_rpt_2G_action_rpt_GL.attention_name_formartted; }
                if(x_oCrm_rpt_2G_action_rpt_GL.customer_name_formartted==null){  x_oCmd.Parameters.Add("@customer_name_formartted", SqlDbType.VarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@customer_name_formartted", SqlDbType.VarChar,100).Value=x_oCrm_rpt_2G_action_rpt_GL.customer_name_formartted; }
                if(x_oCrm_rpt_2G_action_rpt_GL.mnp_rebate_end_date==null){  x_oCmd.Parameters.Add("@mnp_rebate_end_date", SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@mnp_rebate_end_date", SqlDbType.DateTime).Value=x_oCrm_rpt_2G_action_rpt_GL.mnp_rebate_end_date; }
                if(x_oCrm_rpt_2G_action_rpt_GL.field3==null){  x_oCmd.Parameters.Add("@field3", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@field3", SqlDbType.VarChar,50).Value=x_oCrm_rpt_2G_action_rpt_GL.field3; }
                if(x_oCrm_rpt_2G_action_rpt_GL.addr_4==null){  x_oCmd.Parameters.Add("@addr_4", SqlDbType.VarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@addr_4", SqlDbType.VarChar,100).Value=x_oCrm_rpt_2G_action_rpt_GL.addr_4; }
                if(x_oCrm_rpt_2G_action_rpt_GL.program==null){  x_oCmd.Parameters.Add("@program", SqlDbType.VarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@program", SqlDbType.VarChar,250).Value=x_oCrm_rpt_2G_action_rpt_GL.program; }
                if(x_oCrm_rpt_2G_action_rpt_GL.prop_plan==null){  x_oCmd.Parameters.Add("@prop_plan", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@prop_plan", SqlDbType.VarChar,50).Value=x_oCrm_rpt_2G_action_rpt_GL.prop_plan; }
                if(x_oCrm_rpt_2G_action_rpt_GL.expired_month==null){  x_oCmd.Parameters.Add("@expired_month", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@expired_month", SqlDbType.VarChar,50).Value=x_oCrm_rpt_2G_action_rpt_GL.expired_month; }
                if(x_oCrm_rpt_2G_action_rpt_GL.customer_group==null){  x_oCmd.Parameters.Add("@customer_group", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@customer_group", SqlDbType.VarChar,50).Value=x_oCrm_rpt_2G_action_rpt_GL.customer_group; }
                if(x_oCrm_rpt_2G_action_rpt_GL.join_date==null){  x_oCmd.Parameters.Add("@join_date", SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@join_date", SqlDbType.DateTime).Value=x_oCrm_rpt_2G_action_rpt_GL.join_date; }
                if(x_oCrm_rpt_2G_action_rpt_GL.idd_flg==null){  x_oCmd.Parameters.Add("@idd_flg", SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@idd_flg", SqlDbType.Bit).Value=x_oCrm_rpt_2G_action_rpt_GL.idd_flg; }
                if(x_oCrm_rpt_2G_action_rpt_GL.active==null){  x_oCmd.Parameters.Add("@active", SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", SqlDbType.Bit).Value=x_oCrm_rpt_2G_action_rpt_GL.active; }
                if(x_oCrm_rpt_2G_action_rpt_GL.period==null){  x_oCmd.Parameters.Add("@period", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@period", SqlDbType.VarChar,50).Value=x_oCrm_rpt_2G_action_rpt_GL.period; }
                if(x_oCrm_rpt_2G_action_rpt_GL.field2==null){  x_oCmd.Parameters.Add("@field2", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@field2", SqlDbType.VarChar,50).Value=x_oCrm_rpt_2G_action_rpt_GL.field2; }
                if(x_oCrm_rpt_2G_action_rpt_GL.start_date==null){  x_oCmd.Parameters.Add("@start_date", SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@start_date", SqlDbType.DateTime).Value=x_oCrm_rpt_2G_action_rpt_GL.start_date; }
                if(x_oCrm_rpt_2G_action_rpt_GL.plan_fee==null){  x_oCmd.Parameters.Add("@plan_fee", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@plan_fee", SqlDbType.VarChar,50).Value=x_oCrm_rpt_2G_action_rpt_GL.plan_fee; }
                if(x_oCrm_rpt_2G_action_rpt_GL.rate_plan==null){  x_oCmd.Parameters.Add("@rate_plan", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rate_plan", SqlDbType.VarChar,50).Value=x_oCrm_rpt_2G_action_rpt_GL.rate_plan; }
                if(x_oCrm_rpt_2G_action_rpt_GL.segment==null){  x_oCmd.Parameters.Add("@segment", SqlDbType.VarChar,15).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@segment", SqlDbType.VarChar,15).Value=x_oCrm_rpt_2G_action_rpt_GL.segment; }
                if(x_oCrm_rpt_2G_action_rpt_GL.cdate==null){  x_oCmd.Parameters.Add("@cdate", SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", SqlDbType.DateTime).Value=x_oCrm_rpt_2G_action_rpt_GL.cdate; }
                if(x_oCrm_rpt_2G_action_rpt_GL.program_id==null){  x_oCmd.Parameters.Add("@program_id", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@program_id", SqlDbType.VarChar,50).Value=x_oCrm_rpt_2G_action_rpt_GL.program_id; }
                if(x_oCrm_rpt_2G_action_rpt_GL.password==null){  x_oCmd.Parameters.Add("@password", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@password", SqlDbType.VarChar,50).Value=x_oCrm_rpt_2G_action_rpt_GL.password; }
                if(x_oCrm_rpt_2G_action_rpt_GL.payment_method==null){  x_oCmd.Parameters.Add("@payment_method", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@payment_method", SqlDbType.VarChar,50).Value=x_oCrm_rpt_2G_action_rpt_GL.payment_method; }
                if(x_oCrm_rpt_2G_action_rpt_GL.contract_id==null){  x_oCmd.Parameters.Add("@contract_id", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@contract_id", SqlDbType.VarChar,50).Value=x_oCrm_rpt_2G_action_rpt_GL.contract_id; }
                if(x_oCrm_rpt_2G_action_rpt_GL.customer_code==null){  x_oCmd.Parameters.Add("@customer_code", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@customer_code", SqlDbType.VarChar,50).Value=x_oCrm_rpt_2G_action_rpt_GL.customer_code; }
                if(x_oCrm_rpt_2G_action_rpt_GL.mobile_no==null){  x_oCmd.Parameters.Add("@mobile_no", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@mobile_no", SqlDbType.VarChar,50).Value=x_oCrm_rpt_2G_action_rpt_GL.mobile_no; }
                if(x_oCrm_rpt_2G_action_rpt_GL.als_flg==null){  x_oCmd.Parameters.Add("@als_flg", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@als_flg", SqlDbType.VarChar,50).Value=x_oCrm_rpt_2G_action_rpt_GL.als_flg; }
                if(x_oCrm_rpt_2G_action_rpt_GL.vas_desc==null){  x_oCmd.Parameters.Add("@vas_desc", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@vas_desc", SqlDbType.VarChar,50).Value=x_oCrm_rpt_2G_action_rpt_GL.vas_desc; }
                if(x_oCrm_rpt_2G_action_rpt_GL.addr_3==null){  x_oCmd.Parameters.Add("@addr_3", SqlDbType.VarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@addr_3", SqlDbType.VarChar,100).Value=x_oCrm_rpt_2G_action_rpt_GL.addr_3; }
                if(x_oCrm_rpt_2G_action_rpt_GL.subscriber_tier==null){  x_oCmd.Parameters.Add("@subscriber_tier", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@subscriber_tier", SqlDbType.VarChar,50).Value=x_oCrm_rpt_2G_action_rpt_GL.subscriber_tier; }
                if(x_oCrm_rpt_2G_action_rpt_GL.customer_id==null){  x_oCmd.Parameters.Add("@customer_id", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@customer_id", SqlDbType.VarChar,50).Value=x_oCrm_rpt_2G_action_rpt_GL.customer_id; }
                if(x_oCrm_rpt_2G_action_rpt_GL.handset_rebate_end_date==null){  x_oCmd.Parameters.Add("@handset_rebate_end_date", SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@handset_rebate_end_date", SqlDbType.DateTime).Value=x_oCrm_rpt_2G_action_rpt_GL.handset_rebate_end_date; }
                if(x_oCrm_rpt_2G_action_rpt_GL.plan_free_inter_min==null){  x_oCmd.Parameters.Add("@plan_free_inter_min", SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@plan_free_inter_min", SqlDbType.Int).Value=x_oCrm_rpt_2G_action_rpt_GL.plan_free_inter_min; }
                if(x_oCrm_rpt_2G_action_rpt_GL.cid==null){  x_oCmd.Parameters.Add("@cid", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", SqlDbType.VarChar,50).Value=x_oCrm_rpt_2G_action_rpt_GL.cid; }
                if(x_oCrm_rpt_2G_action_rpt_GL.did==null){  x_oCmd.Parameters.Add("@did", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", SqlDbType.VarChar,50).Value=x_oCrm_rpt_2G_action_rpt_GL.did; }
                if(x_oCrm_rpt_2G_action_rpt_GL.id==null){  x_oCmd.Parameters.Add("@id", SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@id", SqlDbType.Int).Value=x_oCrm_rpt_2G_action_rpt_GL.id; }
                if(x_oCrm_rpt_2G_action_rpt_GL.plan_free_intra_min==null){  x_oCmd.Parameters.Add("@plan_free_intra_min", SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@plan_free_intra_min", SqlDbType.Int).Value=x_oCrm_rpt_2G_action_rpt_GL.plan_free_intra_min; }
                if(x_oCrm_rpt_2G_action_rpt_GL.original_telemarketing_suppress_flag==null){  x_oCmd.Parameters.Add("@original_telemarketing_suppress_flag", SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@original_telemarketing_suppress_flag", SqlDbType.Bit).Value=x_oCrm_rpt_2G_action_rpt_GL.original_telemarketing_suppress_flag; }
                if(x_oCrm_rpt_2G_action_rpt_GL.contact_number==null){  x_oCmd.Parameters.Add("@contact_number", SqlDbType.VarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@contact_number", SqlDbType.VarChar,20).Value=x_oCrm_rpt_2G_action_rpt_GL.contact_number; }
                if(x_oCrm_rpt_2G_action_rpt_GL.addr_1==null){  x_oCmd.Parameters.Add("@addr_1", SqlDbType.VarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@addr_1", SqlDbType.VarChar,100).Value=x_oCrm_rpt_2G_action_rpt_GL.addr_1; }
                if(x_oCrm_rpt_2G_action_rpt_GL.max_contract_end_date==null){  x_oCmd.Parameters.Add("@max_contract_end_date", SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@max_contract_end_date", SqlDbType.DateTime).Value=x_oCrm_rpt_2G_action_rpt_GL.max_contract_end_date; }
                if(x_oCrm_rpt_2G_action_rpt_GL.id1==null){  x_oCmd.Parameters.Add("@id1", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@id1", SqlDbType.VarChar,50).Value=x_oCrm_rpt_2G_action_rpt_GL.id1; }
                if(x_oCrm_rpt_2G_action_rpt_GL.autopay==null){  x_oCmd.Parameters.Add("@autopay", SqlDbType.VarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@autopay", SqlDbType.VarChar,50).Value=x_oCrm_rpt_2G_action_rpt_GL.autopay; }
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
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sAls_flg,System.Nullable<DateTime> x_dEnd_date,string x_sRemarks,string x_sAirtime_hs_model,System.Nullable<DateTime> x_dStart_date,string x_sCalllist_name,System.Nullable<DateTime> x_dJoin_date,string x_sField1,System.Nullable<int> x_iBill_cycle,string x_sAddr_3,string x_sAddr_2,string x_sId_number,string x_sAttention_name_formartted,string x_sCustomer_name_formartted,string x_sAutopay,string x_sField3,string x_sAddr_4,string x_sProgram,string x_sProp_plan,string x_sCustomer_group,string x_sCustomer_code,System.Nullable<bool> x_bTelemarketing_suppress_flag,System.Nullable<bool> x_bIdd_flg,System.Nullable<bool> x_bActive,System.Nullable<DateTime> x_dDdate,string x_sPlan_fee,string x_sRate_plan,string x_sSegment,string x_sId1,string x_sPassword,string x_sPayment_method,string x_sContract_id,string x_sField2,string x_sMobile_no,string x_sPeriod,string x_sVas_desc,System.Nullable<DateTime> x_dCdate,string x_sSubscriber_tier,string x_sCustomer_id,System.Nullable<DateTime> x_dHandset_rebate_end_date,System.Nullable<int> x_iPlan_free_inter_min,string x_sCid,string x_sDid,string x_sExpired_month,System.Nullable<int> x_iPlan_free_intra_min,System.Nullable<bool> x_bOriginal_telemarketing_suppress_flag,string x_sContact_number,string x_sTradefield,string x_sAddr_1,System.Nullable<DateTime> x_dMax_contract_end_date,System.Nullable<DateTime> x_dMnp_rebate_end_date,string x_sProgram_id)
        {
            int _oLastID;
            Crm_rpt_2G_action_rpt_GL _oCrm_rpt_2G_action_rpt_GL=new Crm_rpt_2G_action_rpt_GL();
            _oCrm_rpt_2G_action_rpt_GL.als_flg=x_sAls_flg;
            _oCrm_rpt_2G_action_rpt_GL.end_date=x_dEnd_date;
            _oCrm_rpt_2G_action_rpt_GL.remarks=x_sRemarks;
            _oCrm_rpt_2G_action_rpt_GL.airtime_hs_model=x_sAirtime_hs_model;
            _oCrm_rpt_2G_action_rpt_GL.start_date=x_dStart_date;
            _oCrm_rpt_2G_action_rpt_GL.calllist_name=x_sCalllist_name;
            _oCrm_rpt_2G_action_rpt_GL.join_date=x_dJoin_date;
            _oCrm_rpt_2G_action_rpt_GL.field1=x_sField1;
            _oCrm_rpt_2G_action_rpt_GL.bill_cycle=x_iBill_cycle;
            _oCrm_rpt_2G_action_rpt_GL.addr_3=x_sAddr_3;
            _oCrm_rpt_2G_action_rpt_GL.addr_2=x_sAddr_2;
            _oCrm_rpt_2G_action_rpt_GL.id_number=x_sId_number;
            _oCrm_rpt_2G_action_rpt_GL.attention_name_formartted=x_sAttention_name_formartted;
            _oCrm_rpt_2G_action_rpt_GL.customer_name_formartted=x_sCustomer_name_formartted;
            _oCrm_rpt_2G_action_rpt_GL.autopay=x_sAutopay;
            _oCrm_rpt_2G_action_rpt_GL.field3=x_sField3;
            _oCrm_rpt_2G_action_rpt_GL.addr_4=x_sAddr_4;
            _oCrm_rpt_2G_action_rpt_GL.program=x_sProgram;
            _oCrm_rpt_2G_action_rpt_GL.prop_plan=x_sProp_plan;
            _oCrm_rpt_2G_action_rpt_GL.customer_group=x_sCustomer_group;
            _oCrm_rpt_2G_action_rpt_GL.customer_code=x_sCustomer_code;
            _oCrm_rpt_2G_action_rpt_GL.telemarketing_suppress_flag=x_bTelemarketing_suppress_flag;
            _oCrm_rpt_2G_action_rpt_GL.idd_flg=x_bIdd_flg;
            _oCrm_rpt_2G_action_rpt_GL.active=x_bActive;
            _oCrm_rpt_2G_action_rpt_GL.ddate=x_dDdate;
            _oCrm_rpt_2G_action_rpt_GL.plan_fee=x_sPlan_fee;
            _oCrm_rpt_2G_action_rpt_GL.rate_plan=x_sRate_plan;
            _oCrm_rpt_2G_action_rpt_GL.segment=x_sSegment;
            _oCrm_rpt_2G_action_rpt_GL.id1=x_sId1;
            _oCrm_rpt_2G_action_rpt_GL.password=x_sPassword;
            _oCrm_rpt_2G_action_rpt_GL.payment_method=x_sPayment_method;
            _oCrm_rpt_2G_action_rpt_GL.contract_id=x_sContract_id;
            _oCrm_rpt_2G_action_rpt_GL.field2=x_sField2;
            _oCrm_rpt_2G_action_rpt_GL.mobile_no=x_sMobile_no;
            _oCrm_rpt_2G_action_rpt_GL.period=x_sPeriod;
            _oCrm_rpt_2G_action_rpt_GL.vas_desc=x_sVas_desc;
            _oCrm_rpt_2G_action_rpt_GL.cdate=x_dCdate;
            _oCrm_rpt_2G_action_rpt_GL.subscriber_tier=x_sSubscriber_tier;
            _oCrm_rpt_2G_action_rpt_GL.customer_id=x_sCustomer_id;
            _oCrm_rpt_2G_action_rpt_GL.handset_rebate_end_date=x_dHandset_rebate_end_date;
            _oCrm_rpt_2G_action_rpt_GL.plan_free_inter_min=x_iPlan_free_inter_min;
            _oCrm_rpt_2G_action_rpt_GL.cid=x_sCid;
            _oCrm_rpt_2G_action_rpt_GL.did=x_sDid;
            _oCrm_rpt_2G_action_rpt_GL.expired_month=x_sExpired_month;
            _oCrm_rpt_2G_action_rpt_GL.plan_free_intra_min=x_iPlan_free_intra_min;
            _oCrm_rpt_2G_action_rpt_GL.original_telemarketing_suppress_flag=x_bOriginal_telemarketing_suppress_flag;
            _oCrm_rpt_2G_action_rpt_GL.contact_number=x_sContact_number;
            _oCrm_rpt_2G_action_rpt_GL.tradefield=x_sTradefield;
            _oCrm_rpt_2G_action_rpt_GL.addr_1=x_sAddr_1;
            _oCrm_rpt_2G_action_rpt_GL.max_contract_end_date=x_dMax_contract_end_date;
            _oCrm_rpt_2G_action_rpt_GL.mnp_rebate_end_date=x_dMnp_rebate_end_date;
            _oCrm_rpt_2G_action_rpt_GL.program_id=x_sProgram_id;
            if(InsertWithLastID_SP(x_oDB, _oCrm_rpt_2G_action_rpt_GL,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(Crm_rpt_2G_action_rpt_GL x_oCrm_rpt_2G_action_rpt_GL)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oCrm_rpt_2G_action_rpt_GL, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, Crm_rpt_2G_action_rpt_GL x_oCrm_rpt_2G_action_rpt_GL)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oCrm_rpt_2G_action_rpt_GL, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is Crm_rpt_2G_action_rpt_GL)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (Crm_rpt_2G_action_rpt_GL)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,Crm_rpt_2G_action_rpt_GL x_oCrm_rpt_2G_action_rpt_GL, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "CRM_RPT_2G_ACTION_RPT_GL";
            SqlConnection _oConn = null;
            SqlCommand _oCmd = null;
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
                _oCmd = new SqlCommand(_sQuery, _oConn);
            }
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oCrm_rpt_2G_action_rpt_GL,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,SqlConnection x_oConn, SqlCommand x_oCmd,Crm_rpt_2G_action_rpt_GL x_oCrm_rpt_2G_action_rpt_GL, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@telemarketing_suppress_flag", SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.telemarketing_suppress_flag==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.telemarketing_suppress_flag; }
                _oPar=x_oCmd.Parameters.Add("@end_date", SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.end_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.end_date; }
                _oPar=x_oCmd.Parameters.Add("@ddate", SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.ddate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.ddate; }
                _oPar=x_oCmd.Parameters.Add("@airtime_hs_model", SqlDbType.VarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.airtime_hs_model==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.airtime_hs_model; }
                _oPar=x_oCmd.Parameters.Add("@tradefield", SqlDbType.VarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.tradefield==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.tradefield; }
                _oPar=x_oCmd.Parameters.Add("@calllist_name", SqlDbType.VarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.calllist_name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.calllist_name; }
                _oPar=x_oCmd.Parameters.Add("@field1", SqlDbType.VarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.field1==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.field1; }
                _oPar=x_oCmd.Parameters.Add("@remarks", SqlDbType.VarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.remarks==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.remarks; }
                _oPar=x_oCmd.Parameters.Add("@bill_cycle", SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.bill_cycle==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.bill_cycle; }
                _oPar=x_oCmd.Parameters.Add("@addr_2", SqlDbType.VarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.addr_2==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.addr_2; }
                _oPar=x_oCmd.Parameters.Add("@id_number", SqlDbType.VarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.id_number==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.id_number; }
                _oPar=x_oCmd.Parameters.Add("@attention_name_formartted", SqlDbType.VarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.attention_name_formartted==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.attention_name_formartted; }
                _oPar=x_oCmd.Parameters.Add("@customer_name_formartted", SqlDbType.VarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.customer_name_formartted==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.customer_name_formartted; }
                _oPar=x_oCmd.Parameters.Add("@mnp_rebate_end_date", SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.mnp_rebate_end_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.mnp_rebate_end_date; }
                _oPar=x_oCmd.Parameters.Add("@field3", SqlDbType.VarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.field3==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.field3; }
                _oPar=x_oCmd.Parameters.Add("@addr_4", SqlDbType.VarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.addr_4==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.addr_4; }
                _oPar=x_oCmd.Parameters.Add("@program", SqlDbType.VarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.program==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.program; }
                _oPar=x_oCmd.Parameters.Add("@prop_plan", SqlDbType.VarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.prop_plan==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.prop_plan; }
                _oPar=x_oCmd.Parameters.Add("@expired_month", SqlDbType.VarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.expired_month==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.expired_month; }
                _oPar=x_oCmd.Parameters.Add("@customer_group", SqlDbType.VarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.customer_group==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.customer_group; }
                _oPar=x_oCmd.Parameters.Add("@join_date", SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.join_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.join_date; }
                _oPar=x_oCmd.Parameters.Add("@idd_flg", SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.idd_flg==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.idd_flg; }
                _oPar=x_oCmd.Parameters.Add("@active", SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.active; }
                _oPar=x_oCmd.Parameters.Add("@period", SqlDbType.VarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.period==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.period; }
                _oPar=x_oCmd.Parameters.Add("@field2", SqlDbType.VarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.field2==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.field2; }
                _oPar=x_oCmd.Parameters.Add("@start_date", SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.start_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.start_date; }
                _oPar=x_oCmd.Parameters.Add("@plan_fee", SqlDbType.VarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.plan_fee==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.plan_fee; }
                _oPar=x_oCmd.Parameters.Add("@rate_plan", SqlDbType.VarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.rate_plan==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.rate_plan; }
                _oPar=x_oCmd.Parameters.Add("@segment", SqlDbType.VarChar,15);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.segment==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.segment; }
                _oPar=x_oCmd.Parameters.Add("@cdate", SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.cdate; }
                _oPar=x_oCmd.Parameters.Add("@program_id", SqlDbType.VarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.program_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.program_id; }
                _oPar=x_oCmd.Parameters.Add("@password", SqlDbType.VarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.password==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.password; }
                _oPar=x_oCmd.Parameters.Add("@payment_method", SqlDbType.VarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.payment_method==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.payment_method; }
                _oPar=x_oCmd.Parameters.Add("@contract_id", SqlDbType.VarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.contract_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.contract_id; }
                _oPar=x_oCmd.Parameters.Add("@customer_code", SqlDbType.VarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.customer_code==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.customer_code; }
                _oPar=x_oCmd.Parameters.Add("@mobile_no", SqlDbType.VarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.mobile_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.mobile_no; }
                _oPar=x_oCmd.Parameters.Add("@als_flg", SqlDbType.VarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.als_flg==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.als_flg; }
                _oPar=x_oCmd.Parameters.Add("@vas_desc", SqlDbType.VarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.vas_desc==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.vas_desc; }
                _oPar=x_oCmd.Parameters.Add("@addr_3", SqlDbType.VarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.addr_3==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.addr_3; }
                _oPar=x_oCmd.Parameters.Add("@subscriber_tier", SqlDbType.VarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.subscriber_tier==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.subscriber_tier; }
                _oPar=x_oCmd.Parameters.Add("@customer_id", SqlDbType.VarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.customer_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.customer_id; }
                _oPar=x_oCmd.Parameters.Add("@handset_rebate_end_date", SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.handset_rebate_end_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.handset_rebate_end_date; }
                _oPar=x_oCmd.Parameters.Add("@plan_free_inter_min", SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.plan_free_inter_min==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.plan_free_inter_min; }
                _oPar=x_oCmd.Parameters.Add("@cid", SqlDbType.VarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.cid; }
                _oPar=x_oCmd.Parameters.Add("@did", SqlDbType.VarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.did==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.did; }
                _oPar=x_oCmd.Parameters.Add("@id", SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.id; }
                _oPar=x_oCmd.Parameters.Add("@plan_free_intra_min", SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.plan_free_intra_min==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.plan_free_intra_min; }
                _oPar=x_oCmd.Parameters.Add("@original_telemarketing_suppress_flag", SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.original_telemarketing_suppress_flag==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.original_telemarketing_suppress_flag; }
                _oPar=x_oCmd.Parameters.Add("@contact_number", SqlDbType.VarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.contact_number==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.contact_number; }
                _oPar=x_oCmd.Parameters.Add("@addr_1", SqlDbType.VarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.addr_1==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.addr_1; }
                _oPar=x_oCmd.Parameters.Add("@max_contract_end_date", SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.max_contract_end_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.max_contract_end_date; }
                _oPar=x_oCmd.Parameters.Add("@id1", SqlDbType.VarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.id1==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.id1; }
                _oPar=x_oCmd.Parameters.Add("@autopay", SqlDbType.VarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCrm_rpt_2G_action_rpt_GL.autopay==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCrm_rpt_2G_action_rpt_GL.autopay; }
                _oPar=x_oCmd.Parameters.Add("@RETURN_ID", SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Output;
                x_oCmd.CommandType = CommandType.StoredProcedure;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                _bResult = Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
                x_oLAST_ID = Int32.Parse(x_oCmd.Parameters["@RETURN_ID"].Value.ToString());
            }
            catch (Exception exp) { string _sError = exp.ToString(); }
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
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            return -1;
        }
        
        #region INSERT_CRM_RPT_2G_ACTION_RPT_GL Store Procedures
        ///-- =============================================
        ///-- Author:		<Author,Philip SW>
        ///-- Create date: <Create Date 2009-07-13>
        ///-- Description:	<Description,CRM_RPT_2G_ACTION_RPT_GL, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_CRM_RPT_2G_ACTION_RPT_GL Store Procedures
        /// </summary>
        /*
        USE CRM
        GO
        IF OBJECT_ID ( 'INSERT_CRM_RPT_2G_ACTION_RPT_GL', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_CRM_RPT_2G_ACTION_RPT_GL;
        GO
        CREATE PROCEDURE INSERT_CRM_RPT_2G_ACTION_RPT_GL
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @als_flg varchar(50),
        @end_date datetime,
        @remarks varchar(100),
        @airtime_hs_model varchar(50),
        @start_date datetime,
        @calllist_name varchar(250),
        @join_date datetime,
        @field1 varchar(50),
        @bill_cycle int,
        @addr_3 varchar(100),
        @addr_2 varchar(100),
        @id_number varchar(50),
        @attention_name_formartted varchar(50),
        @customer_name_formartted varchar(100),
        @autopay varchar(50),
        @field3 varchar(50),
        @addr_4 varchar(100),
        @program varchar(250),
        @prop_plan varchar(50),
        @customer_group varchar(50),
        @customer_code varchar(50),
        @telemarketing_suppress_flag bit,
        @idd_flg bit,
        @active bit,
        @ddate datetime,
        @plan_fee varchar(50),
        @rate_plan varchar(50),
        @segment varchar(15),
        @id1 varchar(50),
        @password varchar(50),
        @payment_method varchar(50),
        @contract_id varchar(50),
        @field2 varchar(50),
        @mobile_no varchar(50),
        @period varchar(50),
        @vas_desc varchar(50),
        @cdate datetime,
        @subscriber_tier varchar(50),
        @customer_id varchar(50),
        @handset_rebate_end_date datetime,
        @plan_free_inter_min int,
        @cid varchar(50),
        @did varchar(50),
        @expired_month varchar(50),
        @plan_free_intra_min int,
        @original_telemarketing_suppress_flag bit,
        @contact_number varchar(20),
        @tradefield varchar(50),
        @addr_1 varchar(100),
        @max_contract_end_date datetime,
        @mnp_rebate_end_date datetime,
        @program_id varchar(50)
        AS
        
        INSERT INTO  [crm_rpt_2G_action_rpt_GL]   ([telemarketing_suppress_flag],[end_date],[ddate],[airtime_hs_model],[tradefield],[calllist_name],[field1],[remarks],[bill_cycle],[addr_2],[id_number],[attention_name_formartted],[customer_name_formartted],[mnp_rebate_end_date],[field3],[addr_4],[program],[prop_plan],[expired_month],[customer_group],[join_date],[idd_flg],[active],[period],[field2],[start_date],[plan_fee],[rate_plan],[segment],[cdate],[program_id],[password],[payment_method],[contract_id],[customer_code],[mobile_no],[als_flg],[vas_desc],[addr_3],[subscriber_tier],[customer_id],[handset_rebate_end_date],[plan_free_inter_min],[cid],[did],[plan_free_intra_min],[original_telemarketing_suppress_flag],[contact_number],[addr_1],[max_contract_end_date],[id1],[autopay])  VALUES  (@telemarketing_suppress_flag,@end_date,@ddate,@airtime_hs_model,@tradefield,@calllist_name,@field1,@remarks,@bill_cycle,@addr_2,@id_number,@attention_name_formartted,@customer_name_formartted,@mnp_rebate_end_date,@field3,@addr_4,@program,@prop_plan,@expired_month,@customer_group,@join_date,@idd_flg,@active,@period,@field2,@start_date,@plan_fee,@rate_plan,@segment,@cdate,@program_id,@password,@payment_method,@contract_id,@customer_code,@mobile_no,@als_flg,@vas_desc,@addr_3,@subscriber_tier,@customer_id,@handset_rebate_end_date,@plan_free_inter_min,@cid,@did,@plan_free_intra_min,@original_telemarketing_suppress_flag,@contact_number,@addr_1,@max_contract_end_date,@id1,@autopay)
        IF @@IDENTITY IS NOT NULL
        BEGIN
        SELECT @RETURN_ID=@@IDENTITY
        RETURN @RETURN_ID
        END
        ELSE
        BEGIN
        SET @RETURN_ID=-1
        RETURN @RETURN_ID
        END
        
        GO
        */
        #endregion
        
        #endregion
        
        #region Delete
        /// <summary>
        /// Summary description for management table deleting
        /// </summary>
        
        public bool Delete(System.Nullable<int> x_iId)
        {
            return DeleteProc(n_oDB, x_iId);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,System.Nullable<int> x_iId)
        {
            return DeleteProc(x_oDB, x_iId);
        }
        
        
        private static bool DeleteProc(MSSQLConnect x_oDB, System.Nullable<int> x_iId)
        {
            if (x_iId==null) { return false; }
            string _sQuery = "DELETE FROM  [crm_rpt_2G_action_rpt_GL]  WHERE [crm_rpt_2G_action_rpt_GL].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[crm_rpt_2G_action_rpt_GL]","["+ Configurator.MSSQLTablePrefix + "crm_rpt_2G_action_rpt_GL]"); }
            using(SqlConnection _oConn = x_oDB.GetConnection()){
                SqlCommand _oCmd = new SqlCommand(_sQuery, _oConn);
                bool _bResult=false;
                _oCmd.Parameters.Add("@id", SqlDbType.Int).Value = x_iId;
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
            return Crm_rpt_2G_action_rpt_GLRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [crm_rpt_2G_action_rpt_GL]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[crm_rpt_2G_action_rpt_GL]","["+ Configurator.MSSQLTablePrefix + "crm_rpt_2G_action_rpt_GL]"); }
            using(SqlConnection _oConn = x_oDB.GetConnection()){
                SqlCommand _oCmd = new SqlCommand(_sQuery, _oConn);
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
            string _sQuery = "DELETE FROM [crm_rpt_2G_action_rpt_GL]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[crm_rpt_2G_action_rpt_GL]","["+ Configurator.MSSQLTablePrefix + "crm_rpt_2G_action_rpt_GL]"); }
            using(SqlConnection _oConn = x_oDB.GetConnection()){
                SqlCommand _oCmd = new SqlCommand(_sQuery, _oConn);
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


