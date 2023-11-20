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
///-- Create date: <Create Date 2011-07-13>
///-- Description:	<Description,Table :[HandSetOfferBasketHistory],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [HandSetOfferBasketHistory] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"HandSetOfferBasketHistory")]
    public class HandSetOfferBasketHistoryRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static HandSetOfferBasketHistoryRepositoryBase instance;
        public static HandSetOfferBasketHistoryRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new HandSetOfferBasketHistoryRepositoryBase(_oDB);
            }
            return instance;
        }
        public static HandSetOfferBasketHistoryRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new HandSetOfferBasketHistoryRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<HandSetOfferBasketHistoryEntity> HandSetOfferBasketHistorys;
        #endregion
        
        #region Constructor
        public HandSetOfferBasketHistoryRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~HandSetOfferBasketHistoryRepositoryBase() { 
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
        public static HandSetOfferBasketHistory CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new HandSetOfferBasketHistory(_oDB);
        }
        
        public static HandSetOfferBasketHistory CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new HandSetOfferBasketHistory(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [HandSetOfferBasketHistory]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[HandSetOfferBasketHistory]","["+ Configurator.MSSQLTablePrefix + "HandSetOfferBasketHistory]"); }
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
        
        
        public HandSetOfferBasketHistoryEntity GetObj(global::System.Nullable<int> x_iMid)
        {
            return GetObj(n_oDB, x_iMid);
        }
        
        
        public static HandSetOfferBasketHistoryEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            if (x_oDB==null) { return null; }
            HandSetOfferBasketHistory _HandSetOfferBasketHistory = (HandSetOfferBasketHistory)HandSetOfferBasketHistoryRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_HandSetOfferBasketHistory.Load(x_iMid)) { return null; }
            return _HandSetOfferBasketHistory;
        }
        
        
        
        public static HandSetOfferBasketHistoryEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<HandSetOfferBasketHistoryEntity> _oHandSetOfferBasketHistoryList = GetListObj(x_oDB,0, "mid", x_oArrayItemId);
            if(_oHandSetOfferBasketHistoryList==null){ return null;}
            return _oHandSetOfferBasketHistoryList.Count == 0 ? null : _oHandSetOfferBasketHistoryList.ToArray();
        }
        
        public static List<HandSetOfferBasketHistoryEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "mid", x_oArrayItemId);
        }
        
        
        public static HandSetOfferBasketHistoryEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<HandSetOfferBasketHistoryEntity> _oHandSetOfferBasketHistoryList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oHandSetOfferBasketHistoryList==null){ return null;}
            return _oHandSetOfferBasketHistoryList.Count == 0 ? null : _oHandSetOfferBasketHistoryList.ToArray();
        }
        
        
        public static HandSetOfferBasketHistoryEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<HandSetOfferBasketHistoryEntity> _oHandSetOfferBasketHistoryList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oHandSetOfferBasketHistoryList==null){ return null;}
            return _oHandSetOfferBasketHistoryList.Count == 0 ? null : _oHandSetOfferBasketHistoryList.ToArray();
        }
        
        public static List<HandSetOfferBasketHistoryEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<HandSetOfferBasketHistoryEntity> _oRow = new List<HandSetOfferBasketHistoryEntity>();
            string _sQuery = "SELECT  "+_sTop+" [HandSetOfferBasketHistory].[rec_no] AS HANDSETOFFERBASKETHISTORY_REC_NO,[HandSetOfferBasketHistory].[mid] AS HANDSETOFFERBASKETHISTORY_MID,[HandSetOfferBasketHistory].[r_offer] AS HANDSETOFFERBASKETHISTORY_R_OFFER,[HandSetOfferBasketHistory].[extra_rebate_amount] AS HANDSETOFFERBASKETHISTORY_EXTRA_REBATE_AMOUNT,[HandSetOfferBasketHistory].[cdate] AS HANDSETOFFERBASKETHISTORY_CDATE,[HandSetOfferBasketHistory].[amount] AS HANDSETOFFERBASKETHISTORY_AMOUNT,[HandSetOfferBasketHistory].[cid] AS HANDSETOFFERBASKETHISTORY_CID,[HandSetOfferBasketHistory].[did] AS HANDSETOFFERBASKETHISTORY_DID,[HandSetOfferBasketHistory].[sdate] AS HANDSETOFFERBASKETHISTORY_SDATE,[HandSetOfferBasketHistory].[payment] AS HANDSETOFFERBASKETHISTORY_PAYMENT,[HandSetOfferBasketHistory].[retention_type] AS HANDSETOFFERBASKETHISTORY_RETENTION_TYPE,[HandSetOfferBasketHistory].[edate] AS HANDSETOFFERBASKETHISTORY_EDATE,[HandSetOfferBasketHistory].[con_per] AS HANDSETOFFERBASKETHISTORY_CON_PER,[HandSetOfferBasketHistory].[ddate] AS HANDSETOFFERBASKETHISTORY_DDATE,[HandSetOfferBasketHistory].[normal_rebate_type] AS HANDSETOFFERBASKETHISTORY_NORMAL_REBATE_TYPE,[HandSetOfferBasketHistory].[premium] AS HANDSETOFFERBASKETHISTORY_PREMIUM,[HandSetOfferBasketHistory].[extra_rebate] AS HANDSETOFFERBASKETHISTORY_EXTRA_REBATE,[HandSetOfferBasketHistory].[rebate_gp] AS HANDSETOFFERBASKETHISTORY_REBATE_GP,[HandSetOfferBasketHistory].[normal_rebate] AS HANDSETOFFERBASKETHISTORY_NORMAL_REBATE,[HandSetOfferBasketHistory].[hs_model] AS HANDSETOFFERBASKETHISTORY_HS_MODEL,[HandSetOfferBasketHistory].[offer_type_id] AS HANDSETOFFERBASKETHISTORY_OFFER_TYPE_ID,[HandSetOfferBasketHistory].[active] AS HANDSETOFFERBASKETHISTORY_ACTIVE,[HandSetOfferBasketHistory].[rebate_amount] AS HANDSETOFFERBASKETHISTORY_REBATE_AMOUNT,[HandSetOfferBasketHistory].[plan_fee] AS HANDSETOFFERBASKETHISTORY_PLAN_FEE,[HandSetOfferBasketHistory].[item_code] AS HANDSETOFFERBASKETHISTORY_ITEM_CODE,[HandSetOfferBasketHistory].[issue_type] AS HANDSETOFFERBASKETHISTORY_ISSUE_TYPE  FROM  [HandSetOfferBasketHistory]";
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
                _sQuery += " WHERE [HandSetOfferBasketHistory].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[HandSetOfferBasketHistory]","["+ Configurator.MSSQLTablePrefix + "HandSetOfferBasketHistory]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        HandSetOfferBasketHistory _oHandSetOfferBasketHistory = HandSetOfferBasketHistoryRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_REC_NO"])) {_oHandSetOfferBasketHistory.rec_no = (global::System.Nullable<int>)_oData["HANDSETOFFERBASKETHISTORY_REC_NO"]; }else{_oHandSetOfferBasketHistory.rec_no=null;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_MID"])) {_oHandSetOfferBasketHistory.mid = (global::System.Nullable<int>)_oData["HANDSETOFFERBASKETHISTORY_MID"]; }else{_oHandSetOfferBasketHistory.mid=null;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_R_OFFER"])) {_oHandSetOfferBasketHistory.r_offer = (string)_oData["HANDSETOFFERBASKETHISTORY_R_OFFER"]; }else{_oHandSetOfferBasketHistory.r_offer=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_EXTRA_REBATE_AMOUNT"])) {_oHandSetOfferBasketHistory.extra_rebate_amount = (string)_oData["HANDSETOFFERBASKETHISTORY_EXTRA_REBATE_AMOUNT"]; }else{_oHandSetOfferBasketHistory.extra_rebate_amount=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_CDATE"])) {_oHandSetOfferBasketHistory.cdate = (global::System.Nullable<DateTime>)_oData["HANDSETOFFERBASKETHISTORY_CDATE"]; }else{_oHandSetOfferBasketHistory.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_AMOUNT"])) {_oHandSetOfferBasketHistory.amount = (string)_oData["HANDSETOFFERBASKETHISTORY_AMOUNT"]; }else{_oHandSetOfferBasketHistory.amount=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_CID"])) {_oHandSetOfferBasketHistory.cid = (string)_oData["HANDSETOFFERBASKETHISTORY_CID"]; }else{_oHandSetOfferBasketHistory.cid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_DID"])) {_oHandSetOfferBasketHistory.did = (string)_oData["HANDSETOFFERBASKETHISTORY_DID"]; }else{_oHandSetOfferBasketHistory.did=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_SDATE"])) {_oHandSetOfferBasketHistory.sdate = (global::System.Nullable<DateTime>)_oData["HANDSETOFFERBASKETHISTORY_SDATE"]; }else{_oHandSetOfferBasketHistory.sdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_PAYMENT"])) {_oHandSetOfferBasketHistory.payment = (string)_oData["HANDSETOFFERBASKETHISTORY_PAYMENT"]; }else{_oHandSetOfferBasketHistory.payment=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_RETENTION_TYPE"])) {_oHandSetOfferBasketHistory.retention_type = (string)_oData["HANDSETOFFERBASKETHISTORY_RETENTION_TYPE"]; }else{_oHandSetOfferBasketHistory.retention_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_EDATE"])) {_oHandSetOfferBasketHistory.edate = (global::System.Nullable<DateTime>)_oData["HANDSETOFFERBASKETHISTORY_EDATE"]; }else{_oHandSetOfferBasketHistory.edate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_CON_PER"])) {_oHandSetOfferBasketHistory.con_per = (string)_oData["HANDSETOFFERBASKETHISTORY_CON_PER"]; }else{_oHandSetOfferBasketHistory.con_per=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_DDATE"])) {_oHandSetOfferBasketHistory.ddate = (global::System.Nullable<DateTime>)_oData["HANDSETOFFERBASKETHISTORY_DDATE"]; }else{_oHandSetOfferBasketHistory.ddate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_NORMAL_REBATE_TYPE"])) {_oHandSetOfferBasketHistory.normal_rebate_type = (string)_oData["HANDSETOFFERBASKETHISTORY_NORMAL_REBATE_TYPE"]; }else{_oHandSetOfferBasketHistory.normal_rebate_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_PREMIUM"])) {_oHandSetOfferBasketHistory.premium = (string)_oData["HANDSETOFFERBASKETHISTORY_PREMIUM"]; }else{_oHandSetOfferBasketHistory.premium=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_EXTRA_REBATE"])) {_oHandSetOfferBasketHistory.extra_rebate = (string)_oData["HANDSETOFFERBASKETHISTORY_EXTRA_REBATE"]; }else{_oHandSetOfferBasketHistory.extra_rebate=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_REBATE_GP"])) {_oHandSetOfferBasketHistory.rebate_gp = (string)_oData["HANDSETOFFERBASKETHISTORY_REBATE_GP"]; }else{_oHandSetOfferBasketHistory.rebate_gp=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_NORMAL_REBATE"])) {_oHandSetOfferBasketHistory.normal_rebate = (global::System.Nullable<bool>)_oData["HANDSETOFFERBASKETHISTORY_NORMAL_REBATE"]; }else{_oHandSetOfferBasketHistory.normal_rebate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_HS_MODEL"])) {_oHandSetOfferBasketHistory.hs_model = (string)_oData["HANDSETOFFERBASKETHISTORY_HS_MODEL"]; }else{_oHandSetOfferBasketHistory.hs_model=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_OFFER_TYPE_ID"])) {_oHandSetOfferBasketHistory.offer_type_id = (global::System.Nullable<int>)_oData["HANDSETOFFERBASKETHISTORY_OFFER_TYPE_ID"]; }else{_oHandSetOfferBasketHistory.offer_type_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_ACTIVE"])) {_oHandSetOfferBasketHistory.active = (global::System.Nullable<bool>)_oData["HANDSETOFFERBASKETHISTORY_ACTIVE"]; }else{_oHandSetOfferBasketHistory.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_REBATE_AMOUNT"])) {_oHandSetOfferBasketHistory.rebate_amount = (string)_oData["HANDSETOFFERBASKETHISTORY_REBATE_AMOUNT"]; }else{_oHandSetOfferBasketHistory.rebate_amount=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_PLAN_FEE"])) {_oHandSetOfferBasketHistory.plan_fee = (string)_oData["HANDSETOFFERBASKETHISTORY_PLAN_FEE"]; }else{_oHandSetOfferBasketHistory.plan_fee=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_ITEM_CODE"])) {_oHandSetOfferBasketHistory.item_code = (string)_oData["HANDSETOFFERBASKETHISTORY_ITEM_CODE"]; }else{_oHandSetOfferBasketHistory.item_code=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_ISSUE_TYPE"])) {_oHandSetOfferBasketHistory.issue_type = (string)_oData["HANDSETOFFERBASKETHISTORY_ISSUE_TYPE"]; }else{_oHandSetOfferBasketHistory.issue_type=global::System.String.Empty;}
                        _oHandSetOfferBasketHistory.SetDB(x_oDB);
                        _oHandSetOfferBasketHistory.GetFound();
                        _oRow.Add(_oHandSetOfferBasketHistory);
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
        
        
        public static HandSetOfferBasketHistoryEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<HandSetOfferBasketHistoryEntity> _oHandSetOfferBasketHistoryList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oHandSetOfferBasketHistoryList==null){ return null;}
            return _oHandSetOfferBasketHistoryList.Count == 0 ? null : _oHandSetOfferBasketHistoryList.ToArray();
        }
        
        
        public static HandSetOfferBasketHistoryEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<HandSetOfferBasketHistoryEntity> _oHandSetOfferBasketHistoryList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oHandSetOfferBasketHistoryList==null){ return null;}
            return _oHandSetOfferBasketHistoryList.Count == 0 ? null : _oHandSetOfferBasketHistoryList.ToArray();
        }
        
        public static List<HandSetOfferBasketHistoryEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<HandSetOfferBasketHistoryEntity> _oRow = new List<HandSetOfferBasketHistoryEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[HandSetOfferBasketHistory].[rec_no] AS HANDSETOFFERBASKETHISTORY_REC_NO,[HandSetOfferBasketHistory].[mid] AS HANDSETOFFERBASKETHISTORY_MID,[HandSetOfferBasketHistory].[r_offer] AS HANDSETOFFERBASKETHISTORY_R_OFFER,[HandSetOfferBasketHistory].[extra_rebate_amount] AS HANDSETOFFERBASKETHISTORY_EXTRA_REBATE_AMOUNT,[HandSetOfferBasketHistory].[cdate] AS HANDSETOFFERBASKETHISTORY_CDATE,[HandSetOfferBasketHistory].[amount] AS HANDSETOFFERBASKETHISTORY_AMOUNT,[HandSetOfferBasketHistory].[cid] AS HANDSETOFFERBASKETHISTORY_CID,[HandSetOfferBasketHistory].[did] AS HANDSETOFFERBASKETHISTORY_DID,[HandSetOfferBasketHistory].[sdate] AS HANDSETOFFERBASKETHISTORY_SDATE,[HandSetOfferBasketHistory].[payment] AS HANDSETOFFERBASKETHISTORY_PAYMENT,[HandSetOfferBasketHistory].[retention_type] AS HANDSETOFFERBASKETHISTORY_RETENTION_TYPE,[HandSetOfferBasketHistory].[edate] AS HANDSETOFFERBASKETHISTORY_EDATE,[HandSetOfferBasketHistory].[con_per] AS HANDSETOFFERBASKETHISTORY_CON_PER,[HandSetOfferBasketHistory].[ddate] AS HANDSETOFFERBASKETHISTORY_DDATE,[HandSetOfferBasketHistory].[normal_rebate_type] AS HANDSETOFFERBASKETHISTORY_NORMAL_REBATE_TYPE,[HandSetOfferBasketHistory].[premium] AS HANDSETOFFERBASKETHISTORY_PREMIUM,[HandSetOfferBasketHistory].[extra_rebate] AS HANDSETOFFERBASKETHISTORY_EXTRA_REBATE,[HandSetOfferBasketHistory].[rebate_gp] AS HANDSETOFFERBASKETHISTORY_REBATE_GP,[HandSetOfferBasketHistory].[normal_rebate] AS HANDSETOFFERBASKETHISTORY_NORMAL_REBATE,[HandSetOfferBasketHistory].[hs_model] AS HANDSETOFFERBASKETHISTORY_HS_MODEL,[HandSetOfferBasketHistory].[offer_type_id] AS HANDSETOFFERBASKETHISTORY_OFFER_TYPE_ID,[HandSetOfferBasketHistory].[active] AS HANDSETOFFERBASKETHISTORY_ACTIVE,[HandSetOfferBasketHistory].[rebate_amount] AS HANDSETOFFERBASKETHISTORY_REBATE_AMOUNT,[HandSetOfferBasketHistory].[plan_fee] AS HANDSETOFFERBASKETHISTORY_PLAN_FEE,[HandSetOfferBasketHistory].[item_code] AS HANDSETOFFERBASKETHISTORY_ITEM_CODE,[HandSetOfferBasketHistory].[issue_type] AS HANDSETOFFERBASKETHISTORY_ISSUE_TYPE";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[HandSetOfferBasketHistory]","["+ Configurator.MSSQLTablePrefix + "HandSetOfferBasketHistory]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = HandSetOfferBasketHistoryRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                HandSetOfferBasketHistoryEntity _oHandSetOfferBasketHistory = HandSetOfferBasketHistoryRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_REC_NO"])) {_oHandSetOfferBasketHistory.rec_no = (global::System.Nullable<int>)_oData["HANDSETOFFERBASKETHISTORY_REC_NO"]; } else {_oHandSetOfferBasketHistory.rec_no=null; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_MID"])) {_oHandSetOfferBasketHistory.mid = (global::System.Nullable<int>)_oData["HANDSETOFFERBASKETHISTORY_MID"]; } else {_oHandSetOfferBasketHistory.mid=null; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_R_OFFER"])) {_oHandSetOfferBasketHistory.r_offer = (string)_oData["HANDSETOFFERBASKETHISTORY_R_OFFER"]; } else {_oHandSetOfferBasketHistory.r_offer=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_EXTRA_REBATE_AMOUNT"])) {_oHandSetOfferBasketHistory.extra_rebate_amount = (string)_oData["HANDSETOFFERBASKETHISTORY_EXTRA_REBATE_AMOUNT"]; } else {_oHandSetOfferBasketHistory.extra_rebate_amount=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_CDATE"])) {_oHandSetOfferBasketHistory.cdate = (global::System.Nullable<DateTime>)_oData["HANDSETOFFERBASKETHISTORY_CDATE"]; } else {_oHandSetOfferBasketHistory.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_AMOUNT"])) {_oHandSetOfferBasketHistory.amount = (string)_oData["HANDSETOFFERBASKETHISTORY_AMOUNT"]; } else {_oHandSetOfferBasketHistory.amount=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_CID"])) {_oHandSetOfferBasketHistory.cid = (string)_oData["HANDSETOFFERBASKETHISTORY_CID"]; } else {_oHandSetOfferBasketHistory.cid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_DID"])) {_oHandSetOfferBasketHistory.did = (string)_oData["HANDSETOFFERBASKETHISTORY_DID"]; } else {_oHandSetOfferBasketHistory.did=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_SDATE"])) {_oHandSetOfferBasketHistory.sdate = (global::System.Nullable<DateTime>)_oData["HANDSETOFFERBASKETHISTORY_SDATE"]; } else {_oHandSetOfferBasketHistory.sdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_PAYMENT"])) {_oHandSetOfferBasketHistory.payment = (string)_oData["HANDSETOFFERBASKETHISTORY_PAYMENT"]; } else {_oHandSetOfferBasketHistory.payment=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_RETENTION_TYPE"])) {_oHandSetOfferBasketHistory.retention_type = (string)_oData["HANDSETOFFERBASKETHISTORY_RETENTION_TYPE"]; } else {_oHandSetOfferBasketHistory.retention_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_EDATE"])) {_oHandSetOfferBasketHistory.edate = (global::System.Nullable<DateTime>)_oData["HANDSETOFFERBASKETHISTORY_EDATE"]; } else {_oHandSetOfferBasketHistory.edate=null; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_CON_PER"])) {_oHandSetOfferBasketHistory.con_per = (string)_oData["HANDSETOFFERBASKETHISTORY_CON_PER"]; } else {_oHandSetOfferBasketHistory.con_per=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_DDATE"])) {_oHandSetOfferBasketHistory.ddate = (global::System.Nullable<DateTime>)_oData["HANDSETOFFERBASKETHISTORY_DDATE"]; } else {_oHandSetOfferBasketHistory.ddate=null; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_NORMAL_REBATE_TYPE"])) {_oHandSetOfferBasketHistory.normal_rebate_type = (string)_oData["HANDSETOFFERBASKETHISTORY_NORMAL_REBATE_TYPE"]; } else {_oHandSetOfferBasketHistory.normal_rebate_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_PREMIUM"])) {_oHandSetOfferBasketHistory.premium = (string)_oData["HANDSETOFFERBASKETHISTORY_PREMIUM"]; } else {_oHandSetOfferBasketHistory.premium=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_EXTRA_REBATE"])) {_oHandSetOfferBasketHistory.extra_rebate = (string)_oData["HANDSETOFFERBASKETHISTORY_EXTRA_REBATE"]; } else {_oHandSetOfferBasketHistory.extra_rebate=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_REBATE_GP"])) {_oHandSetOfferBasketHistory.rebate_gp = (string)_oData["HANDSETOFFERBASKETHISTORY_REBATE_GP"]; } else {_oHandSetOfferBasketHistory.rebate_gp=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_NORMAL_REBATE"])) {_oHandSetOfferBasketHistory.normal_rebate = (global::System.Nullable<bool>)_oData["HANDSETOFFERBASKETHISTORY_NORMAL_REBATE"]; } else {_oHandSetOfferBasketHistory.normal_rebate=null; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_HS_MODEL"])) {_oHandSetOfferBasketHistory.hs_model = (string)_oData["HANDSETOFFERBASKETHISTORY_HS_MODEL"]; } else {_oHandSetOfferBasketHistory.hs_model=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_OFFER_TYPE_ID"])) {_oHandSetOfferBasketHistory.offer_type_id = (global::System.Nullable<int>)_oData["HANDSETOFFERBASKETHISTORY_OFFER_TYPE_ID"]; } else {_oHandSetOfferBasketHistory.offer_type_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_ACTIVE"])) {_oHandSetOfferBasketHistory.active = (global::System.Nullable<bool>)_oData["HANDSETOFFERBASKETHISTORY_ACTIVE"]; } else {_oHandSetOfferBasketHistory.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_REBATE_AMOUNT"])) {_oHandSetOfferBasketHistory.rebate_amount = (string)_oData["HANDSETOFFERBASKETHISTORY_REBATE_AMOUNT"]; } else {_oHandSetOfferBasketHistory.rebate_amount=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_PLAN_FEE"])) {_oHandSetOfferBasketHistory.plan_fee = (string)_oData["HANDSETOFFERBASKETHISTORY_PLAN_FEE"]; } else {_oHandSetOfferBasketHistory.plan_fee=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_ITEM_CODE"])) {_oHandSetOfferBasketHistory.item_code = (string)_oData["HANDSETOFFERBASKETHISTORY_ITEM_CODE"]; } else {_oHandSetOfferBasketHistory.item_code=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_ISSUE_TYPE"])) {_oHandSetOfferBasketHistory.issue_type = (string)_oData["HANDSETOFFERBASKETHISTORY_ISSUE_TYPE"]; } else {_oHandSetOfferBasketHistory.issue_type=global::System.String.Empty; }
                _oHandSetOfferBasketHistory.SetDB(x_oDB);
                _oHandSetOfferBasketHistory.GetFound();
                _oRow.Add(_oHandSetOfferBasketHistory);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( HandSetOfferBasketHistory.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,HandSetOfferBasketHistory.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(HandSetOfferBasketHistory.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(HandSetOfferBasketHistory.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [HandSetOfferBasketHistory].[rec_no] AS HANDSETOFFERBASKETHISTORY_REC_NO,[HandSetOfferBasketHistory].[mid] AS HANDSETOFFERBASKETHISTORY_MID,[HandSetOfferBasketHistory].[r_offer] AS HANDSETOFFERBASKETHISTORY_R_OFFER,[HandSetOfferBasketHistory].[extra_rebate_amount] AS HANDSETOFFERBASKETHISTORY_EXTRA_REBATE_AMOUNT,[HandSetOfferBasketHistory].[cdate] AS HANDSETOFFERBASKETHISTORY_CDATE,[HandSetOfferBasketHistory].[amount] AS HANDSETOFFERBASKETHISTORY_AMOUNT,[HandSetOfferBasketHistory].[cid] AS HANDSETOFFERBASKETHISTORY_CID,[HandSetOfferBasketHistory].[did] AS HANDSETOFFERBASKETHISTORY_DID,[HandSetOfferBasketHistory].[sdate] AS HANDSETOFFERBASKETHISTORY_SDATE,[HandSetOfferBasketHistory].[payment] AS HANDSETOFFERBASKETHISTORY_PAYMENT,[HandSetOfferBasketHistory].[retention_type] AS HANDSETOFFERBASKETHISTORY_RETENTION_TYPE,[HandSetOfferBasketHistory].[edate] AS HANDSETOFFERBASKETHISTORY_EDATE,[HandSetOfferBasketHistory].[con_per] AS HANDSETOFFERBASKETHISTORY_CON_PER,[HandSetOfferBasketHistory].[ddate] AS HANDSETOFFERBASKETHISTORY_DDATE,[HandSetOfferBasketHistory].[normal_rebate_type] AS HANDSETOFFERBASKETHISTORY_NORMAL_REBATE_TYPE,[HandSetOfferBasketHistory].[premium] AS HANDSETOFFERBASKETHISTORY_PREMIUM,[HandSetOfferBasketHistory].[extra_rebate] AS HANDSETOFFERBASKETHISTORY_EXTRA_REBATE,[HandSetOfferBasketHistory].[rebate_gp] AS HANDSETOFFERBASKETHISTORY_REBATE_GP,[HandSetOfferBasketHistory].[normal_rebate] AS HANDSETOFFERBASKETHISTORY_NORMAL_REBATE,[HandSetOfferBasketHistory].[hs_model] AS HANDSETOFFERBASKETHISTORY_HS_MODEL,[HandSetOfferBasketHistory].[offer_type_id] AS HANDSETOFFERBASKETHISTORY_OFFER_TYPE_ID,[HandSetOfferBasketHistory].[active] AS HANDSETOFFERBASKETHISTORY_ACTIVE,[HandSetOfferBasketHistory].[rebate_amount] AS HANDSETOFFERBASKETHISTORY_REBATE_AMOUNT,[HandSetOfferBasketHistory].[plan_fee] AS HANDSETOFFERBASKETHISTORY_PLAN_FEE,[HandSetOfferBasketHistory].[item_code] AS HANDSETOFFERBASKETHISTORY_ITEM_CODE,[HandSetOfferBasketHistory].[issue_type] AS HANDSETOFFERBASKETHISTORY_ISSUE_TYPE  FROM  [HandSetOfferBasketHistory]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[HandSetOfferBasketHistory]","["+ Configurator.MSSQLTablePrefix + "HandSetOfferBasketHistory]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"HandSetOfferBasketHistory");
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
        
        public bool Insert(global::System.Nullable<int> x_iRec_no,string x_sR_offer,string x_sExtra_rebate_amount,global::System.Nullable<DateTime> x_dCdate,string x_sAmount,string x_sCid,string x_sDid,global::System.Nullable<DateTime> x_dSdate,string x_sPayment,string x_sRetention_type,global::System.Nullable<DateTime> x_dEdate,string x_sCon_per,global::System.Nullable<DateTime> x_dDdate,string x_sNormal_rebate_type,string x_sPremium,string x_sExtra_rebate,string x_sRebate_gp,global::System.Nullable<bool> x_bNormal_rebate,string x_sHs_model,global::System.Nullable<int> x_iOffer_type_id,global::System.Nullable<bool> x_bActive,string x_sRebate_amount,string x_sPlan_fee,string x_sItem_code,string x_sIssue_type)
        {
            HandSetOfferBasketHistory _oHandSetOfferBasketHistory=HandSetOfferBasketHistoryRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oHandSetOfferBasketHistory.rec_no=x_iRec_no;
            _oHandSetOfferBasketHistory.r_offer=x_sR_offer;
            _oHandSetOfferBasketHistory.extra_rebate_amount=x_sExtra_rebate_amount;
            _oHandSetOfferBasketHistory.cdate=x_dCdate;
            _oHandSetOfferBasketHistory.amount=x_sAmount;
            _oHandSetOfferBasketHistory.cid=x_sCid;
            _oHandSetOfferBasketHistory.did=x_sDid;
            _oHandSetOfferBasketHistory.sdate=x_dSdate;
            _oHandSetOfferBasketHistory.payment=x_sPayment;
            _oHandSetOfferBasketHistory.retention_type=x_sRetention_type;
            _oHandSetOfferBasketHistory.edate=x_dEdate;
            _oHandSetOfferBasketHistory.con_per=x_sCon_per;
            _oHandSetOfferBasketHistory.ddate=x_dDdate;
            _oHandSetOfferBasketHistory.normal_rebate_type=x_sNormal_rebate_type;
            _oHandSetOfferBasketHistory.premium=x_sPremium;
            _oHandSetOfferBasketHistory.extra_rebate=x_sExtra_rebate;
            _oHandSetOfferBasketHistory.rebate_gp=x_sRebate_gp;
            _oHandSetOfferBasketHistory.normal_rebate=x_bNormal_rebate;
            _oHandSetOfferBasketHistory.hs_model=x_sHs_model;
            _oHandSetOfferBasketHistory.offer_type_id=x_iOffer_type_id;
            _oHandSetOfferBasketHistory.active=x_bActive;
            _oHandSetOfferBasketHistory.rebate_amount=x_sRebate_amount;
            _oHandSetOfferBasketHistory.plan_fee=x_sPlan_fee;
            _oHandSetOfferBasketHistory.item_code=x_sItem_code;
            _oHandSetOfferBasketHistory.issue_type=x_sIssue_type;
            return InsertWithOutLastID(n_oDB, _oHandSetOfferBasketHistory);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<int> x_iRec_no,string x_sR_offer,string x_sExtra_rebate_amount,global::System.Nullable<DateTime> x_dCdate,string x_sAmount,string x_sCid,string x_sDid,global::System.Nullable<DateTime> x_dSdate,string x_sPayment,string x_sRetention_type,global::System.Nullable<DateTime> x_dEdate,string x_sCon_per,global::System.Nullable<DateTime> x_dDdate,string x_sNormal_rebate_type,string x_sPremium,string x_sExtra_rebate,string x_sRebate_gp,global::System.Nullable<bool> x_bNormal_rebate,string x_sHs_model,global::System.Nullable<int> x_iOffer_type_id,global::System.Nullable<bool> x_bActive,string x_sRebate_amount,string x_sPlan_fee,string x_sItem_code,string x_sIssue_type)
        {
            HandSetOfferBasketHistory _oHandSetOfferBasketHistory=HandSetOfferBasketHistoryRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oHandSetOfferBasketHistory.rec_no=x_iRec_no;
            _oHandSetOfferBasketHistory.r_offer=x_sR_offer;
            _oHandSetOfferBasketHistory.extra_rebate_amount=x_sExtra_rebate_amount;
            _oHandSetOfferBasketHistory.cdate=x_dCdate;
            _oHandSetOfferBasketHistory.amount=x_sAmount;
            _oHandSetOfferBasketHistory.cid=x_sCid;
            _oHandSetOfferBasketHistory.did=x_sDid;
            _oHandSetOfferBasketHistory.sdate=x_dSdate;
            _oHandSetOfferBasketHistory.payment=x_sPayment;
            _oHandSetOfferBasketHistory.retention_type=x_sRetention_type;
            _oHandSetOfferBasketHistory.edate=x_dEdate;
            _oHandSetOfferBasketHistory.con_per=x_sCon_per;
            _oHandSetOfferBasketHistory.ddate=x_dDdate;
            _oHandSetOfferBasketHistory.normal_rebate_type=x_sNormal_rebate_type;
            _oHandSetOfferBasketHistory.premium=x_sPremium;
            _oHandSetOfferBasketHistory.extra_rebate=x_sExtra_rebate;
            _oHandSetOfferBasketHistory.rebate_gp=x_sRebate_gp;
            _oHandSetOfferBasketHistory.normal_rebate=x_bNormal_rebate;
            _oHandSetOfferBasketHistory.hs_model=x_sHs_model;
            _oHandSetOfferBasketHistory.offer_type_id=x_iOffer_type_id;
            _oHandSetOfferBasketHistory.active=x_bActive;
            _oHandSetOfferBasketHistory.rebate_amount=x_sRebate_amount;
            _oHandSetOfferBasketHistory.plan_fee=x_sPlan_fee;
            _oHandSetOfferBasketHistory.item_code=x_sItem_code;
            _oHandSetOfferBasketHistory.issue_type=x_sIssue_type;
            return InsertWithOutLastID(x_oDB, _oHandSetOfferBasketHistory);
        }
        
        
        public bool Insert(HandSetOfferBasketHistory x_oHandSetOfferBasketHistory)
        {
            return InsertWithOutLastID(n_oDB, x_oHandSetOfferBasketHistory);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is HandSetOfferBasketHistory)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (HandSetOfferBasketHistory)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,HandSetOfferBasketHistory x_oHandSetOfferBasketHistory)
        {
            return InsertWithOutLastID(x_oDB, x_oHandSetOfferBasketHistory);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,HandSetOfferBasketHistory x_oHandSetOfferBasketHistory)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [HandSetOfferBasketHistory]   ([rec_no],[r_offer],[extra_rebate_amount],[cdate],[amount],[cid],[did],[sdate],[payment],[retention_type],[edate],[con_per],[ddate],[normal_rebate_type],[premium],[extra_rebate],[rebate_gp],[normal_rebate],[hs_model],[offer_type_id],[active],[rebate_amount],[plan_fee],[item_code],[issue_type])  VALUES  (@rec_no,@r_offer,@extra_rebate_amount,@cdate,@amount,@cid,@did,@sdate,@payment,@retention_type,@edate,@con_per,@ddate,@normal_rebate_type,@premium,@extra_rebate,@rebate_gp,@normal_rebate,@hs_model,@offer_type_id,@active,@rebate_amount,@plan_fee,@item_code,@issue_type)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[HandSetOfferBasketHistory]","["+ Configurator.MSSQLTablePrefix + "HandSetOfferBasketHistory]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oHandSetOfferBasketHistory);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,HandSetOfferBasketHistory x_oHandSetOfferBasketHistory)
        {
            bool _bResult = false;
            if (!x_oHandSetOfferBasketHistory.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oHandSetOfferBasketHistory.rec_no==null){  x_oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int).Value=x_oHandSetOfferBasketHistory.rec_no; }
                if(x_oHandSetOfferBasketHistory.r_offer==null){  x_oCmd.Parameters.Add("@r_offer", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@r_offer", global::System.Data.SqlDbType.NVarChar,50).Value=x_oHandSetOfferBasketHistory.r_offer; }
                if(x_oHandSetOfferBasketHistory.extra_rebate_amount==null){  x_oCmd.Parameters.Add("@extra_rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@extra_rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value=x_oHandSetOfferBasketHistory.extra_rebate_amount; }
                if(x_oHandSetOfferBasketHistory.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oHandSetOfferBasketHistory.cdate; }
                if(x_oHandSetOfferBasketHistory.amount==null){  x_oCmd.Parameters.Add("@amount", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@amount", global::System.Data.SqlDbType.NVarChar,10).Value=x_oHandSetOfferBasketHistory.amount; }
                if(x_oHandSetOfferBasketHistory.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value=x_oHandSetOfferBasketHistory.cid; }
                if(x_oHandSetOfferBasketHistory.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value=x_oHandSetOfferBasketHistory.did; }
                if(x_oHandSetOfferBasketHistory.sdate==null){  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value=x_oHandSetOfferBasketHistory.sdate; }
                if(x_oHandSetOfferBasketHistory.payment==null){  x_oCmd.Parameters.Add("@payment", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@payment", global::System.Data.SqlDbType.NVarChar,20).Value=x_oHandSetOfferBasketHistory.payment; }
                if(x_oHandSetOfferBasketHistory.retention_type==null){  x_oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.NChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.NChar,10).Value=x_oHandSetOfferBasketHistory.retention_type; }
                if(x_oHandSetOfferBasketHistory.edate==null){  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=x_oHandSetOfferBasketHistory.edate; }
                if(x_oHandSetOfferBasketHistory.con_per==null){  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10).Value=x_oHandSetOfferBasketHistory.con_per; }
                if(x_oHandSetOfferBasketHistory.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oHandSetOfferBasketHistory.ddate; }
                if(x_oHandSetOfferBasketHistory.normal_rebate_type==null){  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value=x_oHandSetOfferBasketHistory.normal_rebate_type; }
                if(x_oHandSetOfferBasketHistory.premium==null){  x_oCmd.Parameters.Add("@premium", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@premium", global::System.Data.SqlDbType.NVarChar,250).Value=x_oHandSetOfferBasketHistory.premium; }
                if(x_oHandSetOfferBasketHistory.extra_rebate==null){  x_oCmd.Parameters.Add("@extra_rebate", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@extra_rebate", global::System.Data.SqlDbType.NVarChar,10).Value=x_oHandSetOfferBasketHistory.extra_rebate; }
                if(x_oHandSetOfferBasketHistory.rebate_gp==null){  x_oCmd.Parameters.Add("@rebate_gp", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rebate_gp", global::System.Data.SqlDbType.NVarChar,20).Value=x_oHandSetOfferBasketHistory.rebate_gp; }
                if(x_oHandSetOfferBasketHistory.normal_rebate==null){  x_oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit).Value=x_oHandSetOfferBasketHistory.normal_rebate; }
                if(x_oHandSetOfferBasketHistory.hs_model==null){  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value=x_oHandSetOfferBasketHistory.hs_model; }
                if(x_oHandSetOfferBasketHistory.offer_type_id==null){  x_oCmd.Parameters.Add("@offer_type_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@offer_type_id", global::System.Data.SqlDbType.Int).Value=x_oHandSetOfferBasketHistory.offer_type_id; }
                if(x_oHandSetOfferBasketHistory.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oHandSetOfferBasketHistory.active; }
                if(x_oHandSetOfferBasketHistory.rebate_amount==null){  x_oCmd.Parameters.Add("@rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value=x_oHandSetOfferBasketHistory.rebate_amount; }
                if(x_oHandSetOfferBasketHistory.plan_fee==null){  x_oCmd.Parameters.Add("@plan_fee", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@plan_fee", global::System.Data.SqlDbType.NVarChar,10).Value=x_oHandSetOfferBasketHistory.plan_fee; }
                if(x_oHandSetOfferBasketHistory.item_code==null){  x_oCmd.Parameters.Add("@item_code", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@item_code", global::System.Data.SqlDbType.NVarChar,10).Value=x_oHandSetOfferBasketHistory.item_code; }
                if(x_oHandSetOfferBasketHistory.issue_type==null){  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oHandSetOfferBasketHistory.issue_type; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,global::System.Nullable<int> x_iRec_no,string x_sR_offer,string x_sExtra_rebate_amount,global::System.Nullable<DateTime> x_dCdate,string x_sAmount,string x_sCid,string x_sDid,global::System.Nullable<DateTime> x_dSdate,string x_sPayment,string x_sRetention_type,global::System.Nullable<DateTime> x_dEdate,string x_sCon_per,global::System.Nullable<DateTime> x_dDdate,string x_sNormal_rebate_type,string x_sPremium,string x_sExtra_rebate,string x_sRebate_gp,global::System.Nullable<bool> x_bNormal_rebate,string x_sHs_model,global::System.Nullable<int> x_iOffer_type_id,global::System.Nullable<bool> x_bActive,string x_sRebate_amount,string x_sPlan_fee,string x_sItem_code,string x_sIssue_type)
        {
            int _oLastID;
            HandSetOfferBasketHistory _oHandSetOfferBasketHistory=HandSetOfferBasketHistoryRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oHandSetOfferBasketHistory.rec_no=x_iRec_no;
            _oHandSetOfferBasketHistory.r_offer=x_sR_offer;
            _oHandSetOfferBasketHistory.extra_rebate_amount=x_sExtra_rebate_amount;
            _oHandSetOfferBasketHistory.cdate=x_dCdate;
            _oHandSetOfferBasketHistory.amount=x_sAmount;
            _oHandSetOfferBasketHistory.cid=x_sCid;
            _oHandSetOfferBasketHistory.did=x_sDid;
            _oHandSetOfferBasketHistory.sdate=x_dSdate;
            _oHandSetOfferBasketHistory.payment=x_sPayment;
            _oHandSetOfferBasketHistory.retention_type=x_sRetention_type;
            _oHandSetOfferBasketHistory.edate=x_dEdate;
            _oHandSetOfferBasketHistory.con_per=x_sCon_per;
            _oHandSetOfferBasketHistory.ddate=x_dDdate;
            _oHandSetOfferBasketHistory.normal_rebate_type=x_sNormal_rebate_type;
            _oHandSetOfferBasketHistory.premium=x_sPremium;
            _oHandSetOfferBasketHistory.extra_rebate=x_sExtra_rebate;
            _oHandSetOfferBasketHistory.rebate_gp=x_sRebate_gp;
            _oHandSetOfferBasketHistory.normal_rebate=x_bNormal_rebate;
            _oHandSetOfferBasketHistory.hs_model=x_sHs_model;
            _oHandSetOfferBasketHistory.offer_type_id=x_iOffer_type_id;
            _oHandSetOfferBasketHistory.active=x_bActive;
            _oHandSetOfferBasketHistory.rebate_amount=x_sRebate_amount;
            _oHandSetOfferBasketHistory.plan_fee=x_sPlan_fee;
            _oHandSetOfferBasketHistory.item_code=x_sItem_code;
            _oHandSetOfferBasketHistory.issue_type=x_sIssue_type;
            if(InsertWithLastID(x_oDB, _oHandSetOfferBasketHistory,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(HandSetOfferBasketHistory x_oHandSetOfferBasketHistory)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oHandSetOfferBasketHistory, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, HandSetOfferBasketHistory x_oHandSetOfferBasketHistory)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oHandSetOfferBasketHistory, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is HandSetOfferBasketHistory)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (HandSetOfferBasketHistory)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,HandSetOfferBasketHistory x_oHandSetOfferBasketHistory, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [HandSetOfferBasketHistory]   ([rec_no],[r_offer],[extra_rebate_amount],[cdate],[amount],[cid],[did],[sdate],[payment],[retention_type],[edate],[con_per],[ddate],[normal_rebate_type],[premium],[extra_rebate],[rebate_gp],[normal_rebate],[hs_model],[offer_type_id],[active],[rebate_amount],[plan_fee],[item_code],[issue_type])  VALUES  (@rec_no,@r_offer,@extra_rebate_amount,@cdate,@amount,@cid,@did,@sdate,@payment,@retention_type,@edate,@con_per,@ddate,@normal_rebate_type,@premium,@extra_rebate,@rebate_gp,@normal_rebate,@hs_model,@offer_type_id,@active,@rebate_amount,@plan_fee,@item_code,@issue_type)"+" SELECT  @@IDENTITY AS HandSetOfferBasketHistory_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[HandSetOfferBasketHistory]","["+ Configurator.MSSQLTablePrefix + "HandSetOfferBasketHistory]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oHandSetOfferBasketHistory,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,HandSetOfferBasketHistory x_oHandSetOfferBasketHistory, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oHandSetOfferBasketHistory.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oHandSetOfferBasketHistory.rec_no==null){  x_oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int).Value=x_oHandSetOfferBasketHistory.rec_no; }
                if(x_oHandSetOfferBasketHistory.r_offer==null){  x_oCmd.Parameters.Add("@r_offer", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@r_offer", global::System.Data.SqlDbType.NVarChar,50).Value=x_oHandSetOfferBasketHistory.r_offer; }
                if(x_oHandSetOfferBasketHistory.extra_rebate_amount==null){  x_oCmd.Parameters.Add("@extra_rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@extra_rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value=x_oHandSetOfferBasketHistory.extra_rebate_amount; }
                if(x_oHandSetOfferBasketHistory.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oHandSetOfferBasketHistory.cdate; }
                if(x_oHandSetOfferBasketHistory.amount==null){  x_oCmd.Parameters.Add("@amount", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@amount", global::System.Data.SqlDbType.NVarChar,10).Value=x_oHandSetOfferBasketHistory.amount; }
                if(x_oHandSetOfferBasketHistory.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value=x_oHandSetOfferBasketHistory.cid; }
                if(x_oHandSetOfferBasketHistory.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value=x_oHandSetOfferBasketHistory.did; }
                if(x_oHandSetOfferBasketHistory.sdate==null){  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value=x_oHandSetOfferBasketHistory.sdate; }
                if(x_oHandSetOfferBasketHistory.payment==null){  x_oCmd.Parameters.Add("@payment", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@payment", global::System.Data.SqlDbType.NVarChar,20).Value=x_oHandSetOfferBasketHistory.payment; }
                if(x_oHandSetOfferBasketHistory.retention_type==null){  x_oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.NChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.NChar,10).Value=x_oHandSetOfferBasketHistory.retention_type; }
                if(x_oHandSetOfferBasketHistory.edate==null){  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=x_oHandSetOfferBasketHistory.edate; }
                if(x_oHandSetOfferBasketHistory.con_per==null){  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10).Value=x_oHandSetOfferBasketHistory.con_per; }
                if(x_oHandSetOfferBasketHistory.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oHandSetOfferBasketHistory.ddate; }
                if(x_oHandSetOfferBasketHistory.normal_rebate_type==null){  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value=x_oHandSetOfferBasketHistory.normal_rebate_type; }
                if(x_oHandSetOfferBasketHistory.premium==null){  x_oCmd.Parameters.Add("@premium", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@premium", global::System.Data.SqlDbType.NVarChar,250).Value=x_oHandSetOfferBasketHistory.premium; }
                if(x_oHandSetOfferBasketHistory.extra_rebate==null){  x_oCmd.Parameters.Add("@extra_rebate", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@extra_rebate", global::System.Data.SqlDbType.NVarChar,10).Value=x_oHandSetOfferBasketHistory.extra_rebate; }
                if(x_oHandSetOfferBasketHistory.rebate_gp==null){  x_oCmd.Parameters.Add("@rebate_gp", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rebate_gp", global::System.Data.SqlDbType.NVarChar,20).Value=x_oHandSetOfferBasketHistory.rebate_gp; }
                if(x_oHandSetOfferBasketHistory.normal_rebate==null){  x_oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit).Value=x_oHandSetOfferBasketHistory.normal_rebate; }
                if(x_oHandSetOfferBasketHistory.hs_model==null){  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value=x_oHandSetOfferBasketHistory.hs_model; }
                if(x_oHandSetOfferBasketHistory.offer_type_id==null){  x_oCmd.Parameters.Add("@offer_type_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@offer_type_id", global::System.Data.SqlDbType.Int).Value=x_oHandSetOfferBasketHistory.offer_type_id; }
                if(x_oHandSetOfferBasketHistory.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oHandSetOfferBasketHistory.active; }
                if(x_oHandSetOfferBasketHistory.rebate_amount==null){  x_oCmd.Parameters.Add("@rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value=x_oHandSetOfferBasketHistory.rebate_amount; }
                if(x_oHandSetOfferBasketHistory.plan_fee==null){  x_oCmd.Parameters.Add("@plan_fee", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@plan_fee", global::System.Data.SqlDbType.NVarChar,10).Value=x_oHandSetOfferBasketHistory.plan_fee; }
                if(x_oHandSetOfferBasketHistory.item_code==null){  x_oCmd.Parameters.Add("@item_code", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@item_code", global::System.Data.SqlDbType.NVarChar,10).Value=x_oHandSetOfferBasketHistory.item_code; }
                if(x_oHandSetOfferBasketHistory.issue_type==null){  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oHandSetOfferBasketHistory.issue_type; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["HandSetOfferBasketHistory_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["HandSetOfferBasketHistory_LASTID"].ToString()) && int.TryParse(_oData["HandSetOfferBasketHistory_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<int> x_iRec_no,string x_sR_offer,string x_sExtra_rebate_amount,global::System.Nullable<DateTime> x_dCdate,string x_sAmount,string x_sCid,string x_sDid,global::System.Nullable<DateTime> x_dSdate,string x_sPayment,string x_sRetention_type,global::System.Nullable<DateTime> x_dEdate,string x_sCon_per,global::System.Nullable<DateTime> x_dDdate,string x_sNormal_rebate_type,string x_sPremium,string x_sExtra_rebate,string x_sRebate_gp,global::System.Nullable<bool> x_bNormal_rebate,string x_sHs_model,global::System.Nullable<int> x_iOffer_type_id,global::System.Nullable<bool> x_bActive,string x_sRebate_amount,string x_sPlan_fee,string x_sItem_code,string x_sIssue_type)
        {
            int _oLastID;
            HandSetOfferBasketHistory _oHandSetOfferBasketHistory=HandSetOfferBasketHistoryRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oHandSetOfferBasketHistory.rec_no=x_iRec_no;
            _oHandSetOfferBasketHistory.r_offer=x_sR_offer;
            _oHandSetOfferBasketHistory.extra_rebate_amount=x_sExtra_rebate_amount;
            _oHandSetOfferBasketHistory.cdate=x_dCdate;
            _oHandSetOfferBasketHistory.amount=x_sAmount;
            _oHandSetOfferBasketHistory.cid=x_sCid;
            _oHandSetOfferBasketHistory.did=x_sDid;
            _oHandSetOfferBasketHistory.sdate=x_dSdate;
            _oHandSetOfferBasketHistory.payment=x_sPayment;
            _oHandSetOfferBasketHistory.retention_type=x_sRetention_type;
            _oHandSetOfferBasketHistory.edate=x_dEdate;
            _oHandSetOfferBasketHistory.con_per=x_sCon_per;
            _oHandSetOfferBasketHistory.ddate=x_dDdate;
            _oHandSetOfferBasketHistory.normal_rebate_type=x_sNormal_rebate_type;
            _oHandSetOfferBasketHistory.premium=x_sPremium;
            _oHandSetOfferBasketHistory.extra_rebate=x_sExtra_rebate;
            _oHandSetOfferBasketHistory.rebate_gp=x_sRebate_gp;
            _oHandSetOfferBasketHistory.normal_rebate=x_bNormal_rebate;
            _oHandSetOfferBasketHistory.hs_model=x_sHs_model;
            _oHandSetOfferBasketHistory.offer_type_id=x_iOffer_type_id;
            _oHandSetOfferBasketHistory.active=x_bActive;
            _oHandSetOfferBasketHistory.rebate_amount=x_sRebate_amount;
            _oHandSetOfferBasketHistory.plan_fee=x_sPlan_fee;
            _oHandSetOfferBasketHistory.item_code=x_sItem_code;
            _oHandSetOfferBasketHistory.issue_type=x_sIssue_type;
            if(InsertWithLastID_SP(x_oDB, _oHandSetOfferBasketHistory,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(HandSetOfferBasketHistory x_oHandSetOfferBasketHistory)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oHandSetOfferBasketHistory, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, HandSetOfferBasketHistory x_oHandSetOfferBasketHistory)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oHandSetOfferBasketHistory, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is HandSetOfferBasketHistory)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (HandSetOfferBasketHistory)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,HandSetOfferBasketHistory x_oHandSetOfferBasketHistory, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "HANDSETOFFERBASKETHISTORY";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oHandSetOfferBasketHistory,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,HandSetOfferBasketHistory x_oHandSetOfferBasketHistory, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferBasketHistory.rec_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferBasketHistory.rec_no; }
                _oPar=x_oCmd.Parameters.Add("@r_offer", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferBasketHistory.r_offer==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferBasketHistory.r_offer; }
                _oPar=x_oCmd.Parameters.Add("@extra_rebate_amount", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferBasketHistory.extra_rebate_amount==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferBasketHistory.extra_rebate_amount; }
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferBasketHistory.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oHandSetOfferBasketHistory.cdate; }
                _oPar=x_oCmd.Parameters.Add("@amount", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferBasketHistory.amount==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferBasketHistory.amount; }
                _oPar=x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferBasketHistory.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferBasketHistory.cid; }
                _oPar=x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferBasketHistory.did==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferBasketHistory.did; }
                _oPar=x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferBasketHistory.sdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oHandSetOfferBasketHistory.sdate; }
                _oPar=x_oCmd.Parameters.Add("@payment", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferBasketHistory.payment==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferBasketHistory.payment; }
                _oPar=x_oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.NChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferBasketHistory.retention_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferBasketHistory.retention_type; }
                _oPar=x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferBasketHistory.edate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oHandSetOfferBasketHistory.edate; }
                _oPar=x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferBasketHistory.con_per==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferBasketHistory.con_per; }
                _oPar=x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferBasketHistory.ddate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oHandSetOfferBasketHistory.ddate; }
                _oPar=x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferBasketHistory.normal_rebate_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferBasketHistory.normal_rebate_type; }
                _oPar=x_oCmd.Parameters.Add("@premium", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferBasketHistory.premium==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferBasketHistory.premium; }
                _oPar=x_oCmd.Parameters.Add("@extra_rebate", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferBasketHistory.extra_rebate==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferBasketHistory.extra_rebate; }
                _oPar=x_oCmd.Parameters.Add("@rebate_gp", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferBasketHistory.rebate_gp==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferBasketHistory.rebate_gp; }
                _oPar=x_oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferBasketHistory.normal_rebate==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferBasketHistory.normal_rebate; }
                _oPar=x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferBasketHistory.hs_model==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferBasketHistory.hs_model; }
                _oPar=x_oCmd.Parameters.Add("@offer_type_id", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferBasketHistory.offer_type_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferBasketHistory.offer_type_id; }
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferBasketHistory.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferBasketHistory.active; }
                _oPar=x_oCmd.Parameters.Add("@rebate_amount", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferBasketHistory.rebate_amount==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferBasketHistory.rebate_amount; }
                _oPar=x_oCmd.Parameters.Add("@plan_fee", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferBasketHistory.plan_fee==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferBasketHistory.plan_fee; }
                _oPar=x_oCmd.Parameters.Add("@item_code", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferBasketHistory.item_code==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferBasketHistory.item_code; }
                _oPar=x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferBasketHistory.issue_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferBasketHistory.issue_type; }
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
        
        #region INSERT_HANDSETOFFERBASKETHISTORY Store Procedures
        ///-- =============================================
        ///-- Author:		<Author,Philip SW>
        ///-- Create date: <Create Date 2011-07-13>
        ///-- Description:	<Description,HANDSETOFFERBASKETHISTORY, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_HANDSETOFFERBASKETHISTORY Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_HANDSETOFFERBASKETHISTORY', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_HANDSETOFFERBASKETHISTORY;
        GO
        CREATE PROCEDURE INSERT_HANDSETOFFERBASKETHISTORY
        	-- Add the parameters for the stored procedure here
        @RETURN_MID int output,
        @rec_no int,
        @r_offer nvarchar(50),
        @extra_rebate_amount nvarchar(50),
        @cdate datetime,
        @amount nvarchar(10),
        @cid char(10),
        @did char(10),
        @sdate datetime,
        @payment nvarchar(20),
        @retention_type nchar(10),
        @edate datetime,
        @con_per nvarchar(10),
        @ddate datetime,
        @normal_rebate_type nvarchar(100),
        @premium nvarchar(250),
        @extra_rebate nvarchar(10),
        @rebate_gp nvarchar(20),
        @normal_rebate bit,
        @hs_model nvarchar(250),
        @offer_type_id int,
        @active bit,
        @rebate_amount nvarchar(50),
        @plan_fee nvarchar(10),
        @item_code nvarchar(10),
        @issue_type nvarchar(50)
        AS
        
        INSERT INTO  [HandSetOfferBasketHistory]   ([rec_no],[r_offer],[extra_rebate_amount],[cdate],[amount],[cid],[did],[sdate],[payment],[retention_type],[edate],[con_per],[ddate],[normal_rebate_type],[premium],[extra_rebate],[rebate_gp],[normal_rebate],[hs_model],[offer_type_id],[active],[rebate_amount],[plan_fee],[item_code],[issue_type])  VALUES  (@rec_no,@r_offer,@extra_rebate_amount,@cdate,@amount,@cid,@did,@sdate,@payment,@retention_type,@edate,@con_per,@ddate,@normal_rebate_type,@premium,@extra_rebate,@rebate_gp,@normal_rebate,@hs_model,@offer_type_id,@active,@rebate_amount,@plan_fee,@item_code,@issue_type)
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
            string _sQuery = "DELETE FROM  [HandSetOfferBasketHistory]  WHERE [HandSetOfferBasketHistory].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[HandSetOfferBasketHistory]","["+ Configurator.MSSQLTablePrefix + "HandSetOfferBasketHistory]"); }
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
            return HandSetOfferBasketHistoryRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [HandSetOfferBasketHistory]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[HandSetOfferBasketHistory]","["+ Configurator.MSSQLTablePrefix + "HandSetOfferBasketHistory]"); }
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
            string _sQuery = "DELETE FROM [HandSetOfferBasketHistory]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[HandSetOfferBasketHistory]","["+ Configurator.MSSQLTablePrefix + "HandSetOfferBasketHistory]"); }
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


