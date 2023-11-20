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
///-- Create date: <Create Date 2011-07-13>
///-- Description:	<Description,Table :[BusinessTrade],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [BusinessTrade] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"BusinessTrade")]
    public class BusinessTradeRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static BusinessTradeRepositoryBase instance;
        public static BusinessTradeRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new BusinessTradeRepositoryBase(_oDB);
            }
            return instance;
        }
        public static BusinessTradeRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new BusinessTradeRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<BusinessTradeEntity> BusinessTrades;
        #endregion
        
        #region Constructor
        public BusinessTradeRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~BusinessTradeRepositoryBase() { 
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
        public static BusinessTrade CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new BusinessTrade(_oDB);
        }
        
        public static BusinessTrade CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new BusinessTrade(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [BusinessTrade]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessTrade]","["+ Configurator.MSSQLTablePrefix + "BusinessTrade]"); }
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
        
        
        public BusinessTradeEntity GetObj(global::System.Nullable<int> x_iMid)
        {
            return GetObj(n_oDB, x_iMid);
        }
        
        
        public static BusinessTradeEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            if (x_oDB==null) { return null; }
            BusinessTrade _BusinessTrade = (BusinessTrade)BusinessTradeRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_BusinessTrade.Load(x_iMid)) { return null; }
            return _BusinessTrade;
        }
        
        
        
        public static BusinessTradeEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<BusinessTradeEntity> _oBusinessTradeList = GetListObj(x_oDB,0, "mid", x_oArrayItemId);
            if(_oBusinessTradeList==null){ return null;}
            return _oBusinessTradeList.Count == 0 ? null : _oBusinessTradeList.ToArray();
        }
        
        public static List<BusinessTradeEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "mid", x_oArrayItemId);
        }
        
        
        public static BusinessTradeEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<BusinessTradeEntity> _oBusinessTradeList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oBusinessTradeList==null){ return null;}
            return _oBusinessTradeList.Count == 0 ? null : _oBusinessTradeList.ToArray();
        }
        
        
        public static BusinessTradeEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<BusinessTradeEntity> _oBusinessTradeList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oBusinessTradeList==null){ return null;}
            return _oBusinessTradeList.Count == 0 ? null : _oBusinessTradeList.ToArray();
        }
        
        public static List<BusinessTradeEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<BusinessTradeEntity> _oRow = new List<BusinessTradeEntity>();
            string _sQuery = "SELECT  "+_sTop+" [BusinessTrade].[mid] AS BUSINESSTRADE_MID,[BusinessTrade].[channel] AS BUSINESSTRADE_CHANNEL,[BusinessTrade].[cdate] AS BUSINESSTRADE_CDATE,[BusinessTrade].[bundle_name] AS BUSINESSTRADE_BUNDLE_NAME,[BusinessTrade].[hs_model_name] AS BUSINESSTRADE_HS_MODEL_NAME,[BusinessTrade].[trade_field] AS BUSINESSTRADE_TRADE_FIELD,[BusinessTrade].[did] AS BUSINESSTRADE_DID,[BusinessTrade].[premium_1] AS BUSINESSTRADE_PREMIUM_1,[BusinessTrade].[sdate] AS BUSINESSTRADE_SDATE,[BusinessTrade].[rebate] AS BUSINESSTRADE_REBATE,[BusinessTrade].[premium_2] AS BUSINESSTRADE_PREMIUM_2,[BusinessTrade].[po_date] AS BUSINESSTRADE_PO_DATE,[BusinessTrade].[retention_type] AS BUSINESSTRADE_RETENTION_TYPE,[BusinessTrade].[extra_offer] AS BUSINESSTRADE_EXTRA_OFFER,[BusinessTrade].[edate] AS BUSINESSTRADE_EDATE,[BusinessTrade].[program] AS BUSINESSTRADE_PROGRAM,[BusinessTrade].[ob_early] AS BUSINESSTRADE_OB_EARLY,[BusinessTrade].[con_per] AS BUSINESSTRADE_CON_PER,[BusinessTrade].[ddate] AS BUSINESSTRADE_DDATE,[BusinessTrade].[normal_rebate_type] AS BUSINESSTRADE_NORMAL_REBATE_TYPE,[BusinessTrade].[active] AS BUSINESSTRADE_ACTIVE,[BusinessTrade].[free_mon] AS BUSINESSTRADE_FREE_MON,[BusinessTrade].[cid] AS BUSINESSTRADE_CID,[BusinessTrade].[cancel_renew] AS BUSINESSTRADE_CANCEL_RENEW,[BusinessTrade].[rate_plan] AS BUSINESSTRADE_RATE_PLAN,[BusinessTrade].[normal_rebate] AS BUSINESSTRADE_NORMAL_REBATE,[BusinessTrade].[hs_model] AS BUSINESSTRADE_HS_MODEL,[BusinessTrade].[plan_fee] AS BUSINESSTRADE_PLAN_FEE,[BusinessTrade].[remarks] AS BUSINESSTRADE_REMARKS,[BusinessTrade].[issue_type] AS BUSINESSTRADE_ISSUE_TYPE  FROM  [BusinessTrade]";
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
                _sQuery += " WHERE [BusinessTrade].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessTrade]","["+ Configurator.MSSQLTablePrefix + "BusinessTrade]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        BusinessTrade _oBusinessTrade = BusinessTradeRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_MID"])) {_oBusinessTrade.mid = (global::System.Nullable<int>)_oData["BUSINESSTRADE_MID"]; }else{_oBusinessTrade.mid=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_CHANNEL"])) {_oBusinessTrade.channel = (string)_oData["BUSINESSTRADE_CHANNEL"]; }else{_oBusinessTrade.channel=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_CDATE"])) {_oBusinessTrade.cdate = (global::System.Nullable<DateTime>)_oData["BUSINESSTRADE_CDATE"]; }else{_oBusinessTrade.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_BUNDLE_NAME"])) {_oBusinessTrade.bundle_name = (string)_oData["BUSINESSTRADE_BUNDLE_NAME"]; }else{_oBusinessTrade.bundle_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_HS_MODEL_NAME"])) {_oBusinessTrade.hs_model_name = (string)_oData["BUSINESSTRADE_HS_MODEL_NAME"]; }else{_oBusinessTrade.hs_model_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_TRADE_FIELD"])) {_oBusinessTrade.trade_field = (string)_oData["BUSINESSTRADE_TRADE_FIELD"]; }else{_oBusinessTrade.trade_field=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_DID"])) {_oBusinessTrade.did = (string)_oData["BUSINESSTRADE_DID"]; }else{_oBusinessTrade.did=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_PREMIUM_1"])) {_oBusinessTrade.premium_1 = (string)_oData["BUSINESSTRADE_PREMIUM_1"]; }else{_oBusinessTrade.premium_1=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_SDATE"])) {_oBusinessTrade.sdate = (global::System.Nullable<DateTime>)_oData["BUSINESSTRADE_SDATE"]; }else{_oBusinessTrade.sdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_REBATE"])) {_oBusinessTrade.rebate = (string)_oData["BUSINESSTRADE_REBATE"]; }else{_oBusinessTrade.rebate=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_PREMIUM_2"])) {_oBusinessTrade.premium_2 = (string)_oData["BUSINESSTRADE_PREMIUM_2"]; }else{_oBusinessTrade.premium_2=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_RETENTION_TYPE"])) {_oBusinessTrade.retention_type = (string)_oData["BUSINESSTRADE_RETENTION_TYPE"]; }else{_oBusinessTrade.retention_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_EXTRA_OFFER"])) {_oBusinessTrade.extra_offer = (string)_oData["BUSINESSTRADE_EXTRA_OFFER"]; }else{_oBusinessTrade.extra_offer=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_EDATE"])) {_oBusinessTrade.edate = (global::System.Nullable<DateTime>)_oData["BUSINESSTRADE_EDATE"]; }else{_oBusinessTrade.edate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_PROGRAM"])) {_oBusinessTrade.program = (string)_oData["BUSINESSTRADE_PROGRAM"]; }else{_oBusinessTrade.program=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_CON_PER"])) {_oBusinessTrade.con_per = (string)_oData["BUSINESSTRADE_CON_PER"]; }else{_oBusinessTrade.con_per=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_RATE_PLAN"])) {_oBusinessTrade.rate_plan = (string)_oData["BUSINESSTRADE_RATE_PLAN"]; }else{_oBusinessTrade.rate_plan=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_DDATE"])) {_oBusinessTrade.ddate = (global::System.Nullable<DateTime>)_oData["BUSINESSTRADE_DDATE"]; }else{_oBusinessTrade.ddate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_NORMAL_REBATE_TYPE"])) {_oBusinessTrade.normal_rebate_type = (string)_oData["BUSINESSTRADE_NORMAL_REBATE_TYPE"]; }else{_oBusinessTrade.normal_rebate_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_ACTIVE"])) {_oBusinessTrade.active = (global::System.Nullable<bool>)_oData["BUSINESSTRADE_ACTIVE"]; }else{_oBusinessTrade.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_FREE_MON"])) {_oBusinessTrade.free_mon = (string)_oData["BUSINESSTRADE_FREE_MON"]; }else{_oBusinessTrade.free_mon=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_CID"])) {_oBusinessTrade.cid = (string)_oData["BUSINESSTRADE_CID"]; }else{_oBusinessTrade.cid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_CANCEL_RENEW"])) {_oBusinessTrade.cancel_renew = (global::System.Nullable<bool>)_oData["BUSINESSTRADE_CANCEL_RENEW"]; }else{_oBusinessTrade.cancel_renew=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_OB_EARLY"])) {_oBusinessTrade.ob_early = (string)_oData["BUSINESSTRADE_OB_EARLY"]; }else{_oBusinessTrade.ob_early=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_NORMAL_REBATE"])) {_oBusinessTrade.normal_rebate = (global::System.Nullable<bool>)_oData["BUSINESSTRADE_NORMAL_REBATE"]; }else{_oBusinessTrade.normal_rebate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_HS_MODEL"])) {_oBusinessTrade.hs_model = (string)_oData["BUSINESSTRADE_HS_MODEL"]; }else{_oBusinessTrade.hs_model=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_PLAN_FEE"])) {_oBusinessTrade.plan_fee = (string)_oData["BUSINESSTRADE_PLAN_FEE"]; }else{_oBusinessTrade.plan_fee=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_PO_DATE"])) {_oBusinessTrade.po_date = (global::System.Nullable<DateTime>)_oData["BUSINESSTRADE_PO_DATE"]; }else{_oBusinessTrade.po_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_REMARKS"])) {_oBusinessTrade.remarks = (string)_oData["BUSINESSTRADE_REMARKS"]; }else{_oBusinessTrade.remarks=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_ISSUE_TYPE"])) {_oBusinessTrade.issue_type = (string)_oData["BUSINESSTRADE_ISSUE_TYPE"]; }else{_oBusinessTrade.issue_type=global::System.String.Empty;}
                        _oBusinessTrade.SetDB(x_oDB);
                        _oBusinessTrade.GetFound();
                        _oRow.Add(_oBusinessTrade);
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
        
        
        public static BusinessTradeEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<BusinessTradeEntity> _oBusinessTradeList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oBusinessTradeList==null){ return null;}
            return _oBusinessTradeList.Count == 0 ? null : _oBusinessTradeList.ToArray();
        }
        
        
        public static BusinessTradeEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<BusinessTradeEntity> _oBusinessTradeList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oBusinessTradeList==null){ return null;}
            return _oBusinessTradeList.Count == 0 ? null : _oBusinessTradeList.ToArray();
        }
        
        public static List<BusinessTradeEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<BusinessTradeEntity> _oRow = new List<BusinessTradeEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[BusinessTrade].[mid] AS BUSINESSTRADE_MID,[BusinessTrade].[channel] AS BUSINESSTRADE_CHANNEL,[BusinessTrade].[cdate] AS BUSINESSTRADE_CDATE,[BusinessTrade].[bundle_name] AS BUSINESSTRADE_BUNDLE_NAME,[BusinessTrade].[hs_model_name] AS BUSINESSTRADE_HS_MODEL_NAME,[BusinessTrade].[trade_field] AS BUSINESSTRADE_TRADE_FIELD,[BusinessTrade].[did] AS BUSINESSTRADE_DID,[BusinessTrade].[premium_1] AS BUSINESSTRADE_PREMIUM_1,[BusinessTrade].[sdate] AS BUSINESSTRADE_SDATE,[BusinessTrade].[rebate] AS BUSINESSTRADE_REBATE,[BusinessTrade].[premium_2] AS BUSINESSTRADE_PREMIUM_2,[BusinessTrade].[po_date] AS BUSINESSTRADE_PO_DATE,[BusinessTrade].[retention_type] AS BUSINESSTRADE_RETENTION_TYPE,[BusinessTrade].[extra_offer] AS BUSINESSTRADE_EXTRA_OFFER,[BusinessTrade].[edate] AS BUSINESSTRADE_EDATE,[BusinessTrade].[program] AS BUSINESSTRADE_PROGRAM,[BusinessTrade].[ob_early] AS BUSINESSTRADE_OB_EARLY,[BusinessTrade].[con_per] AS BUSINESSTRADE_CON_PER,[BusinessTrade].[ddate] AS BUSINESSTRADE_DDATE,[BusinessTrade].[normal_rebate_type] AS BUSINESSTRADE_NORMAL_REBATE_TYPE,[BusinessTrade].[active] AS BUSINESSTRADE_ACTIVE,[BusinessTrade].[free_mon] AS BUSINESSTRADE_FREE_MON,[BusinessTrade].[cid] AS BUSINESSTRADE_CID,[BusinessTrade].[cancel_renew] AS BUSINESSTRADE_CANCEL_RENEW,[BusinessTrade].[rate_plan] AS BUSINESSTRADE_RATE_PLAN,[BusinessTrade].[normal_rebate] AS BUSINESSTRADE_NORMAL_REBATE,[BusinessTrade].[hs_model] AS BUSINESSTRADE_HS_MODEL,[BusinessTrade].[plan_fee] AS BUSINESSTRADE_PLAN_FEE,[BusinessTrade].[remarks] AS BUSINESSTRADE_REMARKS,[BusinessTrade].[issue_type] AS BUSINESSTRADE_ISSUE_TYPE";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[BusinessTrade]","["+ Configurator.MSSQLTablePrefix + "BusinessTrade]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = BusinessTradeRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                BusinessTradeEntity _oBusinessTrade = BusinessTradeRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_MID"])) {_oBusinessTrade.mid = (global::System.Nullable<int>)_oData["BUSINESSTRADE_MID"]; } else {_oBusinessTrade.mid=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_CHANNEL"])) {_oBusinessTrade.channel = (string)_oData["BUSINESSTRADE_CHANNEL"]; } else {_oBusinessTrade.channel=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_CDATE"])) {_oBusinessTrade.cdate = (global::System.Nullable<DateTime>)_oData["BUSINESSTRADE_CDATE"]; } else {_oBusinessTrade.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_BUNDLE_NAME"])) {_oBusinessTrade.bundle_name = (string)_oData["BUSINESSTRADE_BUNDLE_NAME"]; } else {_oBusinessTrade.bundle_name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_HS_MODEL_NAME"])) {_oBusinessTrade.hs_model_name = (string)_oData["BUSINESSTRADE_HS_MODEL_NAME"]; } else {_oBusinessTrade.hs_model_name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_TRADE_FIELD"])) {_oBusinessTrade.trade_field = (string)_oData["BUSINESSTRADE_TRADE_FIELD"]; } else {_oBusinessTrade.trade_field=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_DID"])) {_oBusinessTrade.did = (string)_oData["BUSINESSTRADE_DID"]; } else {_oBusinessTrade.did=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_PREMIUM_1"])) {_oBusinessTrade.premium_1 = (string)_oData["BUSINESSTRADE_PREMIUM_1"]; } else {_oBusinessTrade.premium_1=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_SDATE"])) {_oBusinessTrade.sdate = (global::System.Nullable<DateTime>)_oData["BUSINESSTRADE_SDATE"]; } else {_oBusinessTrade.sdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_REBATE"])) {_oBusinessTrade.rebate = (string)_oData["BUSINESSTRADE_REBATE"]; } else {_oBusinessTrade.rebate=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_PREMIUM_2"])) {_oBusinessTrade.premium_2 = (string)_oData["BUSINESSTRADE_PREMIUM_2"]; } else {_oBusinessTrade.premium_2=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_RETENTION_TYPE"])) {_oBusinessTrade.retention_type = (string)_oData["BUSINESSTRADE_RETENTION_TYPE"]; } else {_oBusinessTrade.retention_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_EXTRA_OFFER"])) {_oBusinessTrade.extra_offer = (string)_oData["BUSINESSTRADE_EXTRA_OFFER"]; } else {_oBusinessTrade.extra_offer=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_EDATE"])) {_oBusinessTrade.edate = (global::System.Nullable<DateTime>)_oData["BUSINESSTRADE_EDATE"]; } else {_oBusinessTrade.edate=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_PROGRAM"])) {_oBusinessTrade.program = (string)_oData["BUSINESSTRADE_PROGRAM"]; } else {_oBusinessTrade.program=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_CON_PER"])) {_oBusinessTrade.con_per = (string)_oData["BUSINESSTRADE_CON_PER"]; } else {_oBusinessTrade.con_per=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_RATE_PLAN"])) {_oBusinessTrade.rate_plan = (string)_oData["BUSINESSTRADE_RATE_PLAN"]; } else {_oBusinessTrade.rate_plan=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_DDATE"])) {_oBusinessTrade.ddate = (global::System.Nullable<DateTime>)_oData["BUSINESSTRADE_DDATE"]; } else {_oBusinessTrade.ddate=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_NORMAL_REBATE_TYPE"])) {_oBusinessTrade.normal_rebate_type = (string)_oData["BUSINESSTRADE_NORMAL_REBATE_TYPE"]; } else {_oBusinessTrade.normal_rebate_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_ACTIVE"])) {_oBusinessTrade.active = (global::System.Nullable<bool>)_oData["BUSINESSTRADE_ACTIVE"]; } else {_oBusinessTrade.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_FREE_MON"])) {_oBusinessTrade.free_mon = (string)_oData["BUSINESSTRADE_FREE_MON"]; } else {_oBusinessTrade.free_mon=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_CID"])) {_oBusinessTrade.cid = (string)_oData["BUSINESSTRADE_CID"]; } else {_oBusinessTrade.cid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_CANCEL_RENEW"])) {_oBusinessTrade.cancel_renew = (global::System.Nullable<bool>)_oData["BUSINESSTRADE_CANCEL_RENEW"]; } else {_oBusinessTrade.cancel_renew=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_OB_EARLY"])) {_oBusinessTrade.ob_early = (string)_oData["BUSINESSTRADE_OB_EARLY"]; } else {_oBusinessTrade.ob_early=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_NORMAL_REBATE"])) {_oBusinessTrade.normal_rebate = (global::System.Nullable<bool>)_oData["BUSINESSTRADE_NORMAL_REBATE"]; } else {_oBusinessTrade.normal_rebate=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_HS_MODEL"])) {_oBusinessTrade.hs_model = (string)_oData["BUSINESSTRADE_HS_MODEL"]; } else {_oBusinessTrade.hs_model=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_PLAN_FEE"])) {_oBusinessTrade.plan_fee = (string)_oData["BUSINESSTRADE_PLAN_FEE"]; } else {_oBusinessTrade.plan_fee=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_PO_DATE"])) {_oBusinessTrade.po_date = (global::System.Nullable<DateTime>)_oData["BUSINESSTRADE_PO_DATE"]; } else {_oBusinessTrade.po_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_REMARKS"])) {_oBusinessTrade.remarks = (string)_oData["BUSINESSTRADE_REMARKS"]; } else {_oBusinessTrade.remarks=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_ISSUE_TYPE"])) {_oBusinessTrade.issue_type = (string)_oData["BUSINESSTRADE_ISSUE_TYPE"]; } else {_oBusinessTrade.issue_type=global::System.String.Empty; }
                _oBusinessTrade.SetDB(x_oDB);
                _oBusinessTrade.GetFound();
                _oRow.Add(_oBusinessTrade);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( BusinessTrade.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,BusinessTrade.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(BusinessTrade.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(BusinessTrade.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [BusinessTrade].[mid] AS BUSINESSTRADE_MID,[BusinessTrade].[channel] AS BUSINESSTRADE_CHANNEL,[BusinessTrade].[cdate] AS BUSINESSTRADE_CDATE,[BusinessTrade].[bundle_name] AS BUSINESSTRADE_BUNDLE_NAME,[BusinessTrade].[hs_model_name] AS BUSINESSTRADE_HS_MODEL_NAME,[BusinessTrade].[trade_field] AS BUSINESSTRADE_TRADE_FIELD,[BusinessTrade].[did] AS BUSINESSTRADE_DID,[BusinessTrade].[premium_1] AS BUSINESSTRADE_PREMIUM_1,[BusinessTrade].[sdate] AS BUSINESSTRADE_SDATE,[BusinessTrade].[rebate] AS BUSINESSTRADE_REBATE,[BusinessTrade].[premium_2] AS BUSINESSTRADE_PREMIUM_2,[BusinessTrade].[po_date] AS BUSINESSTRADE_PO_DATE,[BusinessTrade].[retention_type] AS BUSINESSTRADE_RETENTION_TYPE,[BusinessTrade].[extra_offer] AS BUSINESSTRADE_EXTRA_OFFER,[BusinessTrade].[edate] AS BUSINESSTRADE_EDATE,[BusinessTrade].[program] AS BUSINESSTRADE_PROGRAM,[BusinessTrade].[ob_early] AS BUSINESSTRADE_OB_EARLY,[BusinessTrade].[con_per] AS BUSINESSTRADE_CON_PER,[BusinessTrade].[ddate] AS BUSINESSTRADE_DDATE,[BusinessTrade].[normal_rebate_type] AS BUSINESSTRADE_NORMAL_REBATE_TYPE,[BusinessTrade].[active] AS BUSINESSTRADE_ACTIVE,[BusinessTrade].[free_mon] AS BUSINESSTRADE_FREE_MON,[BusinessTrade].[cid] AS BUSINESSTRADE_CID,[BusinessTrade].[cancel_renew] AS BUSINESSTRADE_CANCEL_RENEW,[BusinessTrade].[rate_plan] AS BUSINESSTRADE_RATE_PLAN,[BusinessTrade].[normal_rebate] AS BUSINESSTRADE_NORMAL_REBATE,[BusinessTrade].[hs_model] AS BUSINESSTRADE_HS_MODEL,[BusinessTrade].[plan_fee] AS BUSINESSTRADE_PLAN_FEE,[BusinessTrade].[remarks] AS BUSINESSTRADE_REMARKS,[BusinessTrade].[issue_type] AS BUSINESSTRADE_ISSUE_TYPE  FROM  [BusinessTrade]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[BusinessTrade]","["+ Configurator.MSSQLTablePrefix + "BusinessTrade]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"BusinessTrade");
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
        
        public bool Insert(string x_sChannel,global::System.Nullable<DateTime> x_dCdate,string x_sBundle_name,string x_sHs_model_name,string x_sTrade_field,string x_sDid,string x_sPremium_1,global::System.Nullable<DateTime> x_dSdate,string x_sRebate,string x_sPremium_2,string x_sRetention_type,string x_sExtra_offer,global::System.Nullable<DateTime> x_dEdate,string x_sProgram,string x_sCon_per,string x_sRate_plan,global::System.Nullable<DateTime> x_dDdate,string x_sNormal_rebate_type,global::System.Nullable<bool> x_bActive,string x_sFree_mon,string x_sCid,global::System.Nullable<bool> x_bCancel_renew,string x_sOb_early,global::System.Nullable<bool> x_bNormal_rebate,string x_sHs_model,string x_sPlan_fee,global::System.Nullable<DateTime> x_dPo_date,string x_sRemarks,string x_sIssue_type)
        {
            BusinessTrade _oBusinessTrade=BusinessTradeRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oBusinessTrade.channel=x_sChannel;
            _oBusinessTrade.cdate=x_dCdate;
            _oBusinessTrade.bundle_name=x_sBundle_name;
            _oBusinessTrade.hs_model_name=x_sHs_model_name;
            _oBusinessTrade.trade_field=x_sTrade_field;
            _oBusinessTrade.did=x_sDid;
            _oBusinessTrade.premium_1=x_sPremium_1;
            _oBusinessTrade.sdate=x_dSdate;
            _oBusinessTrade.rebate=x_sRebate;
            _oBusinessTrade.premium_2=x_sPremium_2;
            _oBusinessTrade.retention_type=x_sRetention_type;
            _oBusinessTrade.extra_offer=x_sExtra_offer;
            _oBusinessTrade.edate=x_dEdate;
            _oBusinessTrade.program=x_sProgram;
            _oBusinessTrade.con_per=x_sCon_per;
            _oBusinessTrade.rate_plan=x_sRate_plan;
            _oBusinessTrade.ddate=x_dDdate;
            _oBusinessTrade.normal_rebate_type=x_sNormal_rebate_type;
            _oBusinessTrade.active=x_bActive;
            _oBusinessTrade.free_mon=x_sFree_mon;
            _oBusinessTrade.cid=x_sCid;
            _oBusinessTrade.cancel_renew=x_bCancel_renew;
            _oBusinessTrade.ob_early=x_sOb_early;
            _oBusinessTrade.normal_rebate=x_bNormal_rebate;
            _oBusinessTrade.hs_model=x_sHs_model;
            _oBusinessTrade.plan_fee=x_sPlan_fee;
            _oBusinessTrade.po_date=x_dPo_date;
            _oBusinessTrade.remarks=x_sRemarks;
            _oBusinessTrade.issue_type=x_sIssue_type;
            return InsertWithOutLastID(n_oDB, _oBusinessTrade);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sChannel,global::System.Nullable<DateTime> x_dCdate,string x_sBundle_name,string x_sHs_model_name,string x_sTrade_field,string x_sDid,string x_sPremium_1,global::System.Nullable<DateTime> x_dSdate,string x_sRebate,string x_sPremium_2,string x_sRetention_type,string x_sExtra_offer,global::System.Nullable<DateTime> x_dEdate,string x_sProgram,string x_sCon_per,string x_sRate_plan,global::System.Nullable<DateTime> x_dDdate,string x_sNormal_rebate_type,global::System.Nullable<bool> x_bActive,string x_sFree_mon,string x_sCid,global::System.Nullable<bool> x_bCancel_renew,string x_sOb_early,global::System.Nullable<bool> x_bNormal_rebate,string x_sHs_model,string x_sPlan_fee,global::System.Nullable<DateTime> x_dPo_date,string x_sRemarks,string x_sIssue_type)
        {
            BusinessTrade _oBusinessTrade=BusinessTradeRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oBusinessTrade.channel=x_sChannel;
            _oBusinessTrade.cdate=x_dCdate;
            _oBusinessTrade.bundle_name=x_sBundle_name;
            _oBusinessTrade.hs_model_name=x_sHs_model_name;
            _oBusinessTrade.trade_field=x_sTrade_field;
            _oBusinessTrade.did=x_sDid;
            _oBusinessTrade.premium_1=x_sPremium_1;
            _oBusinessTrade.sdate=x_dSdate;
            _oBusinessTrade.rebate=x_sRebate;
            _oBusinessTrade.premium_2=x_sPremium_2;
            _oBusinessTrade.retention_type=x_sRetention_type;
            _oBusinessTrade.extra_offer=x_sExtra_offer;
            _oBusinessTrade.edate=x_dEdate;
            _oBusinessTrade.program=x_sProgram;
            _oBusinessTrade.con_per=x_sCon_per;
            _oBusinessTrade.rate_plan=x_sRate_plan;
            _oBusinessTrade.ddate=x_dDdate;
            _oBusinessTrade.normal_rebate_type=x_sNormal_rebate_type;
            _oBusinessTrade.active=x_bActive;
            _oBusinessTrade.free_mon=x_sFree_mon;
            _oBusinessTrade.cid=x_sCid;
            _oBusinessTrade.cancel_renew=x_bCancel_renew;
            _oBusinessTrade.ob_early=x_sOb_early;
            _oBusinessTrade.normal_rebate=x_bNormal_rebate;
            _oBusinessTrade.hs_model=x_sHs_model;
            _oBusinessTrade.plan_fee=x_sPlan_fee;
            _oBusinessTrade.po_date=x_dPo_date;
            _oBusinessTrade.remarks=x_sRemarks;
            _oBusinessTrade.issue_type=x_sIssue_type;
            return InsertWithOutLastID(x_oDB, _oBusinessTrade);
        }
        
        
        public bool Insert(BusinessTrade x_oBusinessTrade)
        {
            return InsertWithOutLastID(n_oDB, x_oBusinessTrade);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is BusinessTrade)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (BusinessTrade)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,BusinessTrade x_oBusinessTrade)
        {
            return InsertWithOutLastID(x_oDB, x_oBusinessTrade);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,BusinessTrade x_oBusinessTrade)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [BusinessTrade]   ([channel],[cdate],[bundle_name],[hs_model_name],[trade_field],[did],[premium_1],[sdate],[rebate],[premium_2],[po_date],[retention_type],[extra_offer],[edate],[program],[ob_early],[con_per],[ddate],[normal_rebate_type],[active],[free_mon],[cid],[cancel_renew],[rate_plan],[normal_rebate],[hs_model],[plan_fee],[remarks],[issue_type])  VALUES  (@channel,@cdate,@bundle_name,@hs_model_name,@trade_field,@did,@premium_1,@sdate,@rebate,@premium_2,@po_date,@retention_type,@extra_offer,@edate,@program,@ob_early,@con_per,@ddate,@normal_rebate_type,@active,@free_mon,@cid,@cancel_renew,@rate_plan,@normal_rebate,@hs_model,@plan_fee,@remarks,@issue_type)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessTrade]","["+ Configurator.MSSQLTablePrefix + "BusinessTrade]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oBusinessTrade);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,BusinessTrade x_oBusinessTrade)
        {
            bool _bResult = false;
            if (!x_oBusinessTrade.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oBusinessTrade.channel==null){  x_oCmd.Parameters.Add("@channel", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@channel", global::System.Data.SqlDbType.Char,10).Value=x_oBusinessTrade.channel; }
                if(x_oBusinessTrade.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oBusinessTrade.cdate; }
                if(x_oBusinessTrade.bundle_name==null){  x_oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessTrade.bundle_name; }
                if(x_oBusinessTrade.hs_model_name==null){  x_oCmd.Parameters.Add("@hs_model_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hs_model_name", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessTrade.hs_model_name; }
                if(x_oBusinessTrade.trade_field==null){  x_oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessTrade.trade_field; }
                if(x_oBusinessTrade.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10).Value=x_oBusinessTrade.did; }
                if(x_oBusinessTrade.premium_1==null){  x_oCmd.Parameters.Add("@premium_1", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@premium_1", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessTrade.premium_1; }
                if(x_oBusinessTrade.sdate==null){  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value=x_oBusinessTrade.sdate; }
                if(x_oBusinessTrade.rebate==null){  x_oCmd.Parameters.Add("@rebate", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rebate", global::System.Data.SqlDbType.NVarChar,10).Value=x_oBusinessTrade.rebate; }
                if(x_oBusinessTrade.premium_2==null){  x_oCmd.Parameters.Add("@premium_2", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@premium_2", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessTrade.premium_2; }
                if(x_oBusinessTrade.po_date==null){  x_oCmd.Parameters.Add("@po_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@po_date", global::System.Data.SqlDbType.DateTime).Value=x_oBusinessTrade.po_date; }
                if(x_oBusinessTrade.retention_type==null){  x_oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessTrade.retention_type; }
                if(x_oBusinessTrade.extra_offer==null){  x_oCmd.Parameters.Add("@extra_offer", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@extra_offer", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessTrade.extra_offer; }
                if(x_oBusinessTrade.edate==null){  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=x_oBusinessTrade.edate; }
                if(x_oBusinessTrade.program==null){  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessTrade.program; }
                if(x_oBusinessTrade.ob_early==null){  x_oCmd.Parameters.Add("@ob_early", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ob_early", global::System.Data.SqlDbType.Char,10).Value=x_oBusinessTrade.ob_early; }
                if(x_oBusinessTrade.con_per==null){  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10).Value=x_oBusinessTrade.con_per; }
                if(x_oBusinessTrade.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oBusinessTrade.ddate; }
                if(x_oBusinessTrade.normal_rebate_type==null){  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value=x_oBusinessTrade.normal_rebate_type; }
                if(x_oBusinessTrade.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oBusinessTrade.active; }
                if(x_oBusinessTrade.free_mon==null){  x_oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessTrade.free_mon; }
                if(x_oBusinessTrade.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value=x_oBusinessTrade.cid; }
                if(x_oBusinessTrade.cancel_renew==null){  x_oCmd.Parameters.Add("@cancel_renew", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cancel_renew", global::System.Data.SqlDbType.Bit).Value=x_oBusinessTrade.cancel_renew; }
                if(x_oBusinessTrade.rate_plan==null){  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessTrade.rate_plan; }
                if(x_oBusinessTrade.normal_rebate==null){  x_oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit).Value=x_oBusinessTrade.normal_rebate; }
                if(x_oBusinessTrade.hs_model==null){  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessTrade.hs_model; }
                if(x_oBusinessTrade.plan_fee==null){  x_oCmd.Parameters.Add("@plan_fee", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@plan_fee", global::System.Data.SqlDbType.NVarChar,10).Value=x_oBusinessTrade.plan_fee; }
                if(x_oBusinessTrade.remarks==null){  x_oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.Text).Value=x_oBusinessTrade.remarks; }
                if(x_oBusinessTrade.issue_type==null){  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessTrade.issue_type; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,string x_sChannel,global::System.Nullable<DateTime> x_dCdate,string x_sBundle_name,string x_sHs_model_name,string x_sTrade_field,string x_sDid,string x_sPremium_1,global::System.Nullable<DateTime> x_dSdate,string x_sRebate,string x_sPremium_2,string x_sRetention_type,string x_sExtra_offer,global::System.Nullable<DateTime> x_dEdate,string x_sProgram,string x_sCon_per,string x_sRate_plan,global::System.Nullable<DateTime> x_dDdate,string x_sNormal_rebate_type,global::System.Nullable<bool> x_bActive,string x_sFree_mon,string x_sCid,global::System.Nullable<bool> x_bCancel_renew,string x_sOb_early,global::System.Nullable<bool> x_bNormal_rebate,string x_sHs_model,string x_sPlan_fee,global::System.Nullable<DateTime> x_dPo_date,string x_sRemarks,string x_sIssue_type)
        {
            int _oLastID;
            BusinessTrade _oBusinessTrade=BusinessTradeRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oBusinessTrade.channel=x_sChannel;
            _oBusinessTrade.cdate=x_dCdate;
            _oBusinessTrade.bundle_name=x_sBundle_name;
            _oBusinessTrade.hs_model_name=x_sHs_model_name;
            _oBusinessTrade.trade_field=x_sTrade_field;
            _oBusinessTrade.did=x_sDid;
            _oBusinessTrade.premium_1=x_sPremium_1;
            _oBusinessTrade.sdate=x_dSdate;
            _oBusinessTrade.rebate=x_sRebate;
            _oBusinessTrade.premium_2=x_sPremium_2;
            _oBusinessTrade.retention_type=x_sRetention_type;
            _oBusinessTrade.extra_offer=x_sExtra_offer;
            _oBusinessTrade.edate=x_dEdate;
            _oBusinessTrade.program=x_sProgram;
            _oBusinessTrade.con_per=x_sCon_per;
            _oBusinessTrade.rate_plan=x_sRate_plan;
            _oBusinessTrade.ddate=x_dDdate;
            _oBusinessTrade.normal_rebate_type=x_sNormal_rebate_type;
            _oBusinessTrade.active=x_bActive;
            _oBusinessTrade.free_mon=x_sFree_mon;
            _oBusinessTrade.cid=x_sCid;
            _oBusinessTrade.cancel_renew=x_bCancel_renew;
            _oBusinessTrade.ob_early=x_sOb_early;
            _oBusinessTrade.normal_rebate=x_bNormal_rebate;
            _oBusinessTrade.hs_model=x_sHs_model;
            _oBusinessTrade.plan_fee=x_sPlan_fee;
            _oBusinessTrade.po_date=x_dPo_date;
            _oBusinessTrade.remarks=x_sRemarks;
            _oBusinessTrade.issue_type=x_sIssue_type;
            if(InsertWithLastID(x_oDB, _oBusinessTrade,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(BusinessTrade x_oBusinessTrade)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oBusinessTrade, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, BusinessTrade x_oBusinessTrade)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oBusinessTrade, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is BusinessTrade)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (BusinessTrade)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,BusinessTrade x_oBusinessTrade, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [BusinessTrade]   ([channel],[cdate],[bundle_name],[hs_model_name],[trade_field],[did],[premium_1],[sdate],[rebate],[premium_2],[po_date],[retention_type],[extra_offer],[edate],[program],[ob_early],[con_per],[ddate],[normal_rebate_type],[active],[free_mon],[cid],[cancel_renew],[rate_plan],[normal_rebate],[hs_model],[plan_fee],[remarks],[issue_type])  VALUES  (@channel,@cdate,@bundle_name,@hs_model_name,@trade_field,@did,@premium_1,@sdate,@rebate,@premium_2,@po_date,@retention_type,@extra_offer,@edate,@program,@ob_early,@con_per,@ddate,@normal_rebate_type,@active,@free_mon,@cid,@cancel_renew,@rate_plan,@normal_rebate,@hs_model,@plan_fee,@remarks,@issue_type)"+" SELECT  @@IDENTITY AS BusinessTrade_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessTrade]","["+ Configurator.MSSQLTablePrefix + "BusinessTrade]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oBusinessTrade,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,BusinessTrade x_oBusinessTrade, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oBusinessTrade.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oBusinessTrade.channel==null){  x_oCmd.Parameters.Add("@channel", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@channel", global::System.Data.SqlDbType.Char,10).Value=x_oBusinessTrade.channel; }
                if(x_oBusinessTrade.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oBusinessTrade.cdate; }
                if(x_oBusinessTrade.bundle_name==null){  x_oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessTrade.bundle_name; }
                if(x_oBusinessTrade.hs_model_name==null){  x_oCmd.Parameters.Add("@hs_model_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hs_model_name", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessTrade.hs_model_name; }
                if(x_oBusinessTrade.trade_field==null){  x_oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessTrade.trade_field; }
                if(x_oBusinessTrade.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10).Value=x_oBusinessTrade.did; }
                if(x_oBusinessTrade.premium_1==null){  x_oCmd.Parameters.Add("@premium_1", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@premium_1", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessTrade.premium_1; }
                if(x_oBusinessTrade.sdate==null){  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value=x_oBusinessTrade.sdate; }
                if(x_oBusinessTrade.rebate==null){  x_oCmd.Parameters.Add("@rebate", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rebate", global::System.Data.SqlDbType.NVarChar,10).Value=x_oBusinessTrade.rebate; }
                if(x_oBusinessTrade.premium_2==null){  x_oCmd.Parameters.Add("@premium_2", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@premium_2", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessTrade.premium_2; }
                if(x_oBusinessTrade.po_date==null){  x_oCmd.Parameters.Add("@po_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@po_date", global::System.Data.SqlDbType.DateTime).Value=x_oBusinessTrade.po_date; }
                if(x_oBusinessTrade.retention_type==null){  x_oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessTrade.retention_type; }
                if(x_oBusinessTrade.extra_offer==null){  x_oCmd.Parameters.Add("@extra_offer", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@extra_offer", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessTrade.extra_offer; }
                if(x_oBusinessTrade.edate==null){  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=x_oBusinessTrade.edate; }
                if(x_oBusinessTrade.program==null){  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessTrade.program; }
                if(x_oBusinessTrade.ob_early==null){  x_oCmd.Parameters.Add("@ob_early", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ob_early", global::System.Data.SqlDbType.Char,10).Value=x_oBusinessTrade.ob_early; }
                if(x_oBusinessTrade.con_per==null){  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10).Value=x_oBusinessTrade.con_per; }
                if(x_oBusinessTrade.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oBusinessTrade.ddate; }
                if(x_oBusinessTrade.normal_rebate_type==null){  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value=x_oBusinessTrade.normal_rebate_type; }
                if(x_oBusinessTrade.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oBusinessTrade.active; }
                if(x_oBusinessTrade.free_mon==null){  x_oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessTrade.free_mon; }
                if(x_oBusinessTrade.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value=x_oBusinessTrade.cid; }
                if(x_oBusinessTrade.cancel_renew==null){  x_oCmd.Parameters.Add("@cancel_renew", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cancel_renew", global::System.Data.SqlDbType.Bit).Value=x_oBusinessTrade.cancel_renew; }
                if(x_oBusinessTrade.rate_plan==null){  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessTrade.rate_plan; }
                if(x_oBusinessTrade.normal_rebate==null){  x_oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit).Value=x_oBusinessTrade.normal_rebate; }
                if(x_oBusinessTrade.hs_model==null){  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessTrade.hs_model; }
                if(x_oBusinessTrade.plan_fee==null){  x_oCmd.Parameters.Add("@plan_fee", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@plan_fee", global::System.Data.SqlDbType.NVarChar,10).Value=x_oBusinessTrade.plan_fee; }
                if(x_oBusinessTrade.remarks==null){  x_oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.Text).Value=x_oBusinessTrade.remarks; }
                if(x_oBusinessTrade.issue_type==null){  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessTrade.issue_type; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["BusinessTrade_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["BusinessTrade_LASTID"].ToString()) && int.TryParse(_oData["BusinessTrade_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sChannel,global::System.Nullable<DateTime> x_dCdate,string x_sBundle_name,string x_sHs_model_name,string x_sTrade_field,string x_sDid,string x_sPremium_1,global::System.Nullable<DateTime> x_dSdate,string x_sRebate,string x_sPremium_2,string x_sRetention_type,string x_sExtra_offer,global::System.Nullable<DateTime> x_dEdate,string x_sProgram,string x_sCon_per,string x_sRate_plan,global::System.Nullable<DateTime> x_dDdate,string x_sNormal_rebate_type,global::System.Nullable<bool> x_bActive,string x_sFree_mon,string x_sCid,global::System.Nullable<bool> x_bCancel_renew,string x_sOb_early,global::System.Nullable<bool> x_bNormal_rebate,string x_sHs_model,string x_sPlan_fee,global::System.Nullable<DateTime> x_dPo_date,string x_sRemarks,string x_sIssue_type)
        {
            int _oLastID;
            BusinessTrade _oBusinessTrade=BusinessTradeRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oBusinessTrade.channel=x_sChannel;
            _oBusinessTrade.cdate=x_dCdate;
            _oBusinessTrade.bundle_name=x_sBundle_name;
            _oBusinessTrade.hs_model_name=x_sHs_model_name;
            _oBusinessTrade.trade_field=x_sTrade_field;
            _oBusinessTrade.did=x_sDid;
            _oBusinessTrade.premium_1=x_sPremium_1;
            _oBusinessTrade.sdate=x_dSdate;
            _oBusinessTrade.rebate=x_sRebate;
            _oBusinessTrade.premium_2=x_sPremium_2;
            _oBusinessTrade.retention_type=x_sRetention_type;
            _oBusinessTrade.extra_offer=x_sExtra_offer;
            _oBusinessTrade.edate=x_dEdate;
            _oBusinessTrade.program=x_sProgram;
            _oBusinessTrade.con_per=x_sCon_per;
            _oBusinessTrade.rate_plan=x_sRate_plan;
            _oBusinessTrade.ddate=x_dDdate;
            _oBusinessTrade.normal_rebate_type=x_sNormal_rebate_type;
            _oBusinessTrade.active=x_bActive;
            _oBusinessTrade.free_mon=x_sFree_mon;
            _oBusinessTrade.cid=x_sCid;
            _oBusinessTrade.cancel_renew=x_bCancel_renew;
            _oBusinessTrade.ob_early=x_sOb_early;
            _oBusinessTrade.normal_rebate=x_bNormal_rebate;
            _oBusinessTrade.hs_model=x_sHs_model;
            _oBusinessTrade.plan_fee=x_sPlan_fee;
            _oBusinessTrade.po_date=x_dPo_date;
            _oBusinessTrade.remarks=x_sRemarks;
            _oBusinessTrade.issue_type=x_sIssue_type;
            if(InsertWithLastID_SP(x_oDB, _oBusinessTrade,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(BusinessTrade x_oBusinessTrade)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oBusinessTrade, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, BusinessTrade x_oBusinessTrade)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oBusinessTrade, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is BusinessTrade)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (BusinessTrade)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,BusinessTrade x_oBusinessTrade, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "BUSINESSTRADE";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oBusinessTrade,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,BusinessTrade x_oBusinessTrade, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@channel", global::System.Data.SqlDbType.Char,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTrade.channel==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTrade.channel; }
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTrade.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oBusinessTrade.cdate; }
                _oPar=x_oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTrade.bundle_name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTrade.bundle_name; }
                _oPar=x_oCmd.Parameters.Add("@hs_model_name", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTrade.hs_model_name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTrade.hs_model_name; }
                _oPar=x_oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTrade.trade_field==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTrade.trade_field; }
                _oPar=x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTrade.did==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTrade.did; }
                _oPar=x_oCmd.Parameters.Add("@premium_1", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTrade.premium_1==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTrade.premium_1; }
                _oPar=x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTrade.sdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oBusinessTrade.sdate; }
                _oPar=x_oCmd.Parameters.Add("@rebate", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTrade.rebate==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTrade.rebate; }
                _oPar=x_oCmd.Parameters.Add("@premium_2", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTrade.premium_2==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTrade.premium_2; }
                _oPar=x_oCmd.Parameters.Add("@po_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTrade.po_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oBusinessTrade.po_date; }
                _oPar=x_oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTrade.retention_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTrade.retention_type; }
                _oPar=x_oCmd.Parameters.Add("@extra_offer", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTrade.extra_offer==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTrade.extra_offer; }
                _oPar=x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTrade.edate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oBusinessTrade.edate; }
                _oPar=x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTrade.program==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTrade.program; }
                _oPar=x_oCmd.Parameters.Add("@ob_early", global::System.Data.SqlDbType.Char,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTrade.ob_early==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTrade.ob_early; }
                _oPar=x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTrade.con_per==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTrade.con_per; }
                _oPar=x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTrade.ddate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oBusinessTrade.ddate; }
                _oPar=x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTrade.normal_rebate_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTrade.normal_rebate_type; }
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTrade.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTrade.active; }
                _oPar=x_oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTrade.free_mon==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTrade.free_mon; }
                _oPar=x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTrade.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTrade.cid; }
                _oPar=x_oCmd.Parameters.Add("@cancel_renew", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTrade.cancel_renew==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTrade.cancel_renew; }
                _oPar=x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTrade.rate_plan==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTrade.rate_plan; }
                _oPar=x_oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTrade.normal_rebate==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTrade.normal_rebate; }
                _oPar=x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTrade.hs_model==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTrade.hs_model; }
                _oPar=x_oCmd.Parameters.Add("@plan_fee", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTrade.plan_fee==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTrade.plan_fee; }
                _oPar=x_oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.Text);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTrade.remarks==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTrade.remarks; }
                _oPar=x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessTrade.issue_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessTrade.issue_type; }
                _oPar=x_oCmd.Parameters.Add("@RETURN_MID", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Output;
                x_oCmd.CommandType = CommandType.StoredProcedure;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                _bResult = Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
                x_oLAST_ID = Int32.Parse(x_oCmd.Parameters["@RETURN_MID"].Value.ToString());
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
        
        #region INSERT_BUSINESSTRADE Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2011-07-13>
        ///-- Description:	<Description,BUSINESSTRADE, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_BUSINESSTRADE Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_BUSINESSTRADE', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_BUSINESSTRADE;
        GO
        CREATE PROCEDURE INSERT_BUSINESSTRADE
        	-- Add the parameters for the stored procedure here
        @RETURN_MID int output,
        @channel char(10),
        @cdate datetime,
        @bundle_name nvarchar(50),
        @hs_model_name nvarchar(250),
        @trade_field nvarchar(50),
        @did nvarchar(10),
        @premium_1 nvarchar(250),
        @sdate datetime,
        @rebate nvarchar(10),
        @premium_2 nvarchar(250),
        @retention_type nvarchar(50),
        @extra_offer nvarchar(250),
        @edate datetime,
        @program nvarchar(50),
        @con_per nvarchar(10),
        @rate_plan nvarchar(50),
        @ddate datetime,
        @normal_rebate_type nvarchar(100),
        @active bit,
        @free_mon nvarchar(50),
        @cid nvarchar(10),
        @cancel_renew bit,
        @ob_early char(10),
        @normal_rebate bit,
        @hs_model nvarchar(250),
        @plan_fee nvarchar(10),
        @po_date datetime,
        @remarks text,
        @issue_type nvarchar(50)
        AS
        
        INSERT INTO  [BusinessTrade]   ([channel],[cdate],[bundle_name],[hs_model_name],[trade_field],[did],[premium_1],[sdate],[rebate],[premium_2],[po_date],[retention_type],[extra_offer],[edate],[program],[ob_early],[con_per],[ddate],[normal_rebate_type],[active],[free_mon],[cid],[cancel_renew],[rate_plan],[normal_rebate],[hs_model],[plan_fee],[remarks],[issue_type])  VALUES  (@channel,@cdate,@bundle_name,@hs_model_name,@trade_field,@did,@premium_1,@sdate,@rebate,@premium_2,@po_date,@retention_type,@extra_offer,@edate,@program,@ob_early,@con_per,@ddate,@normal_rebate_type,@active,@free_mon,@cid,@cancel_renew,@rate_plan,@normal_rebate,@hs_model,@plan_fee,@remarks,@issue_type)
        IF @@IDENTITY IS NOT NULL
        BEGIN
        SELECT @RETURN_MID=@@IDENTITY
        RETURN @RETURN_MID
        END
        ELSE
        BEGIN
        SET @RETURN_MID=-1
        RETURN @RETURN_MID
        END
        
        GO
        */
        #endregion
        
        #endregion
        
        #region Delete
        /// <summary>
        /// Summary description for management table deleting
        /// </summary>
        
        public bool Delete(global::System.Nullable<int> x_iMid)
        {
            return DeleteProc(n_oDB, x_iMid);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            return DeleteProc(x_oDB, x_iMid);
        }
        
        
        private static bool DeleteProc(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            if (x_iMid==null) { return false; }
            string _sQuery = "DELETE FROM  [BusinessTrade]  WHERE [BusinessTrade].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessTrade]","["+ Configurator.MSSQLTablePrefix + "BusinessTrade]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult=false;
                _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value = x_iMid;
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
            return BusinessTradeRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [BusinessTrade]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessTrade]","["+ Configurator.MSSQLTablePrefix + "BusinessTrade]"); }
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
            string _sQuery = "DELETE FROM [BusinessTrade]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessTrade]","["+ Configurator.MSSQLTablePrefix + "BusinessTrade]"); }
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


