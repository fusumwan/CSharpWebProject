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
///-- Description:	<Description,Table :[HandSetOfferedBasket],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [HandSetOfferedBasket] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"HandSetOfferedBasket")]
    public class HandSetOfferedBasketRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static HandSetOfferedBasketRepositoryBase instance;
        public static HandSetOfferedBasketRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new HandSetOfferedBasketRepositoryBase(_oDB);
            }
            return instance;
        }
        public static HandSetOfferedBasketRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new HandSetOfferedBasketRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<HandSetOfferedBasketEntity> HandSetOfferedBaskets;
        #endregion
        
        #region Constructor
        public HandSetOfferedBasketRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~HandSetOfferedBasketRepositoryBase() { 
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
        public static HandSetOfferedBasket CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new HandSetOfferedBasket(_oDB);
        }
        
        public static HandSetOfferedBasket CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new HandSetOfferedBasket(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [HandSetOfferedBasket]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[HandSetOfferedBasket]","["+ Configurator.MSSQLTablePrefix + "HandSetOfferedBasket]"); }
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
        
        
        public HandSetOfferedBasketEntity GetObj(global::System.Nullable<int> x_iMid)
        {
            return GetObj(n_oDB, x_iMid);
        }
        
        
        public static HandSetOfferedBasketEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            if (x_oDB==null) { return null; }
            HandSetOfferedBasket _HandSetOfferedBasket = (HandSetOfferedBasket)HandSetOfferedBasketRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_HandSetOfferedBasket.Load(x_iMid)) { return null; }
            return _HandSetOfferedBasket;
        }
        
        
        
        public static HandSetOfferedBasketEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<HandSetOfferedBasketEntity> _oHandSetOfferedBasketList = GetListObj(x_oDB,0, "mid", x_oArrayItemId);
            if(_oHandSetOfferedBasketList==null){ return null;}
            return _oHandSetOfferedBasketList.Count == 0 ? null : _oHandSetOfferedBasketList.ToArray();
        }
        
        public static List<HandSetOfferedBasketEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "mid", x_oArrayItemId);
        }
        
        
        public static HandSetOfferedBasketEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<HandSetOfferedBasketEntity> _oHandSetOfferedBasketList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oHandSetOfferedBasketList==null){ return null;}
            return _oHandSetOfferedBasketList.Count == 0 ? null : _oHandSetOfferedBasketList.ToArray();
        }
        
        
        public static HandSetOfferedBasketEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<HandSetOfferedBasketEntity> _oHandSetOfferedBasketList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oHandSetOfferedBasketList==null){ return null;}
            return _oHandSetOfferedBasketList.Count == 0 ? null : _oHandSetOfferedBasketList.ToArray();
        }
        
        public static List<HandSetOfferedBasketEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<HandSetOfferedBasketEntity> _oRow = new List<HandSetOfferedBasketEntity>();
            string _sQuery = "SELECT  "+_sTop+" [HandSetOfferedBasket].[mid] AS HANDSETOFFEREDBASKET_MID,[HandSetOfferedBasket].[r_offer] AS HANDSETOFFEREDBASKET_R_OFFER,[HandSetOfferedBasket].[extra_rebate_amount] AS HANDSETOFFEREDBASKET_EXTRA_REBATE_AMOUNT,[HandSetOfferedBasket].[cdate] AS HANDSETOFFEREDBASKET_CDATE,[HandSetOfferedBasket].[amount] AS HANDSETOFFEREDBASKET_AMOUNT,[HandSetOfferedBasket].[cid] AS HANDSETOFFEREDBASKET_CID,[HandSetOfferedBasket].[did] AS HANDSETOFFEREDBASKET_DID,[HandSetOfferedBasket].[sdate] AS HANDSETOFFEREDBASKET_SDATE,[HandSetOfferedBasket].[payment] AS HANDSETOFFEREDBASKET_PAYMENT,[HandSetOfferedBasket].[retention_type] AS HANDSETOFFEREDBASKET_RETENTION_TYPE,[HandSetOfferedBasket].[edate] AS HANDSETOFFEREDBASKET_EDATE,[HandSetOfferedBasket].[con_per] AS HANDSETOFFEREDBASKET_CON_PER,[HandSetOfferedBasket].[ddate] AS HANDSETOFFEREDBASKET_DDATE,[HandSetOfferedBasket].[normal_rebate_type] AS HANDSETOFFEREDBASKET_NORMAL_REBATE_TYPE,[HandSetOfferedBasket].[premium] AS HANDSETOFFEREDBASKET_PREMIUM,[HandSetOfferedBasket].[extra_rebate] AS HANDSETOFFEREDBASKET_EXTRA_REBATE,[HandSetOfferedBasket].[rebate_gp] AS HANDSETOFFEREDBASKET_REBATE_GP,[HandSetOfferedBasket].[normal_rebate] AS HANDSETOFFEREDBASKET_NORMAL_REBATE,[HandSetOfferedBasket].[hs_model] AS HANDSETOFFEREDBASKET_HS_MODEL,[HandSetOfferedBasket].[offer_type_id] AS HANDSETOFFEREDBASKET_OFFER_TYPE_ID,[HandSetOfferedBasket].[active] AS HANDSETOFFEREDBASKET_ACTIVE,[HandSetOfferedBasket].[rebate_amount] AS HANDSETOFFEREDBASKET_REBATE_AMOUNT,[HandSetOfferedBasket].[plan_fee] AS HANDSETOFFEREDBASKET_PLAN_FEE,[HandSetOfferedBasket].[item_code] AS HANDSETOFFEREDBASKET_ITEM_CODE,[HandSetOfferedBasket].[issue_type] AS HANDSETOFFEREDBASKET_ISSUE_TYPE  FROM  [HandSetOfferedBasket]";
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
                _sQuery += " WHERE [HandSetOfferedBasket].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[HandSetOfferedBasket]","["+ Configurator.MSSQLTablePrefix + "HandSetOfferedBasket]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        HandSetOfferedBasket _oHandSetOfferedBasket = HandSetOfferedBasketRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_MID"])) {_oHandSetOfferedBasket.mid = (global::System.Nullable<int>)_oData["HANDSETOFFEREDBASKET_MID"]; }else{_oHandSetOfferedBasket.mid=null;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_R_OFFER"])) {_oHandSetOfferedBasket.r_offer = (string)_oData["HANDSETOFFEREDBASKET_R_OFFER"]; }else{_oHandSetOfferedBasket.r_offer=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_EXTRA_REBATE_AMOUNT"])) {_oHandSetOfferedBasket.extra_rebate_amount = (string)_oData["HANDSETOFFEREDBASKET_EXTRA_REBATE_AMOUNT"]; }else{_oHandSetOfferedBasket.extra_rebate_amount=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_CDATE"])) {_oHandSetOfferedBasket.cdate = (global::System.Nullable<DateTime>)_oData["HANDSETOFFEREDBASKET_CDATE"]; }else{_oHandSetOfferedBasket.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_AMOUNT"])) {_oHandSetOfferedBasket.amount = (string)_oData["HANDSETOFFEREDBASKET_AMOUNT"]; }else{_oHandSetOfferedBasket.amount=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_CID"])) {_oHandSetOfferedBasket.cid = (string)_oData["HANDSETOFFEREDBASKET_CID"]; }else{_oHandSetOfferedBasket.cid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_DID"])) {_oHandSetOfferedBasket.did = (string)_oData["HANDSETOFFEREDBASKET_DID"]; }else{_oHandSetOfferedBasket.did=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_SDATE"])) {_oHandSetOfferedBasket.sdate = (global::System.Nullable<DateTime>)_oData["HANDSETOFFEREDBASKET_SDATE"]; }else{_oHandSetOfferedBasket.sdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_PAYMENT"])) {_oHandSetOfferedBasket.payment = (string)_oData["HANDSETOFFEREDBASKET_PAYMENT"]; }else{_oHandSetOfferedBasket.payment=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_RETENTION_TYPE"])) {_oHandSetOfferedBasket.retention_type = (string)_oData["HANDSETOFFEREDBASKET_RETENTION_TYPE"]; }else{_oHandSetOfferedBasket.retention_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_EDATE"])) {_oHandSetOfferedBasket.edate = (global::System.Nullable<DateTime>)_oData["HANDSETOFFEREDBASKET_EDATE"]; }else{_oHandSetOfferedBasket.edate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_CON_PER"])) {_oHandSetOfferedBasket.con_per = (string)_oData["HANDSETOFFEREDBASKET_CON_PER"]; }else{_oHandSetOfferedBasket.con_per=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_DDATE"])) {_oHandSetOfferedBasket.ddate = (global::System.Nullable<DateTime>)_oData["HANDSETOFFEREDBASKET_DDATE"]; }else{_oHandSetOfferedBasket.ddate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_NORMAL_REBATE_TYPE"])) {_oHandSetOfferedBasket.normal_rebate_type = (string)_oData["HANDSETOFFEREDBASKET_NORMAL_REBATE_TYPE"]; }else{_oHandSetOfferedBasket.normal_rebate_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_PREMIUM"])) {_oHandSetOfferedBasket.premium = (string)_oData["HANDSETOFFEREDBASKET_PREMIUM"]; }else{_oHandSetOfferedBasket.premium=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_EXTRA_REBATE"])) {_oHandSetOfferedBasket.extra_rebate = (string)_oData["HANDSETOFFEREDBASKET_EXTRA_REBATE"]; }else{_oHandSetOfferedBasket.extra_rebate=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_REBATE_GP"])) {_oHandSetOfferedBasket.rebate_gp = (string)_oData["HANDSETOFFEREDBASKET_REBATE_GP"]; }else{_oHandSetOfferedBasket.rebate_gp=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_NORMAL_REBATE"])) {_oHandSetOfferedBasket.normal_rebate = (global::System.Nullable<bool>)_oData["HANDSETOFFEREDBASKET_NORMAL_REBATE"]; }else{_oHandSetOfferedBasket.normal_rebate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_HS_MODEL"])) {_oHandSetOfferedBasket.hs_model = (string)_oData["HANDSETOFFEREDBASKET_HS_MODEL"]; }else{_oHandSetOfferedBasket.hs_model=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_OFFER_TYPE_ID"])) {_oHandSetOfferedBasket.offer_type_id = (global::System.Nullable<int>)_oData["HANDSETOFFEREDBASKET_OFFER_TYPE_ID"]; }else{_oHandSetOfferedBasket.offer_type_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_ACTIVE"])) {_oHandSetOfferedBasket.active = (global::System.Nullable<bool>)_oData["HANDSETOFFEREDBASKET_ACTIVE"]; }else{_oHandSetOfferedBasket.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_REBATE_AMOUNT"])) {_oHandSetOfferedBasket.rebate_amount = (string)_oData["HANDSETOFFEREDBASKET_REBATE_AMOUNT"]; }else{_oHandSetOfferedBasket.rebate_amount=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_PLAN_FEE"])) {_oHandSetOfferedBasket.plan_fee = (string)_oData["HANDSETOFFEREDBASKET_PLAN_FEE"]; }else{_oHandSetOfferedBasket.plan_fee=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_ITEM_CODE"])) {_oHandSetOfferedBasket.item_code = (string)_oData["HANDSETOFFEREDBASKET_ITEM_CODE"]; }else{_oHandSetOfferedBasket.item_code=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_ISSUE_TYPE"])) {_oHandSetOfferedBasket.issue_type = (string)_oData["HANDSETOFFEREDBASKET_ISSUE_TYPE"]; }else{_oHandSetOfferedBasket.issue_type=global::System.String.Empty;}
                        _oHandSetOfferedBasket.SetDB(x_oDB);
                        _oHandSetOfferedBasket.GetFound();
                        _oRow.Add(_oHandSetOfferedBasket);
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
        
        
        public static HandSetOfferedBasketEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<HandSetOfferedBasketEntity> _oHandSetOfferedBasketList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oHandSetOfferedBasketList==null){ return null;}
            return _oHandSetOfferedBasketList.Count == 0 ? null : _oHandSetOfferedBasketList.ToArray();
        }
        
        
        public static HandSetOfferedBasketEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<HandSetOfferedBasketEntity> _oHandSetOfferedBasketList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oHandSetOfferedBasketList==null){ return null;}
            return _oHandSetOfferedBasketList.Count == 0 ? null : _oHandSetOfferedBasketList.ToArray();
        }
        
        public static List<HandSetOfferedBasketEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<HandSetOfferedBasketEntity> _oRow = new List<HandSetOfferedBasketEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[HandSetOfferedBasket].[mid] AS HANDSETOFFEREDBASKET_MID,[HandSetOfferedBasket].[r_offer] AS HANDSETOFFEREDBASKET_R_OFFER,[HandSetOfferedBasket].[extra_rebate_amount] AS HANDSETOFFEREDBASKET_EXTRA_REBATE_AMOUNT,[HandSetOfferedBasket].[cdate] AS HANDSETOFFEREDBASKET_CDATE,[HandSetOfferedBasket].[amount] AS HANDSETOFFEREDBASKET_AMOUNT,[HandSetOfferedBasket].[cid] AS HANDSETOFFEREDBASKET_CID,[HandSetOfferedBasket].[did] AS HANDSETOFFEREDBASKET_DID,[HandSetOfferedBasket].[sdate] AS HANDSETOFFEREDBASKET_SDATE,[HandSetOfferedBasket].[payment] AS HANDSETOFFEREDBASKET_PAYMENT,[HandSetOfferedBasket].[retention_type] AS HANDSETOFFEREDBASKET_RETENTION_TYPE,[HandSetOfferedBasket].[edate] AS HANDSETOFFEREDBASKET_EDATE,[HandSetOfferedBasket].[con_per] AS HANDSETOFFEREDBASKET_CON_PER,[HandSetOfferedBasket].[ddate] AS HANDSETOFFEREDBASKET_DDATE,[HandSetOfferedBasket].[normal_rebate_type] AS HANDSETOFFEREDBASKET_NORMAL_REBATE_TYPE,[HandSetOfferedBasket].[premium] AS HANDSETOFFEREDBASKET_PREMIUM,[HandSetOfferedBasket].[extra_rebate] AS HANDSETOFFEREDBASKET_EXTRA_REBATE,[HandSetOfferedBasket].[rebate_gp] AS HANDSETOFFEREDBASKET_REBATE_GP,[HandSetOfferedBasket].[normal_rebate] AS HANDSETOFFEREDBASKET_NORMAL_REBATE,[HandSetOfferedBasket].[hs_model] AS HANDSETOFFEREDBASKET_HS_MODEL,[HandSetOfferedBasket].[offer_type_id] AS HANDSETOFFEREDBASKET_OFFER_TYPE_ID,[HandSetOfferedBasket].[active] AS HANDSETOFFEREDBASKET_ACTIVE,[HandSetOfferedBasket].[rebate_amount] AS HANDSETOFFEREDBASKET_REBATE_AMOUNT,[HandSetOfferedBasket].[plan_fee] AS HANDSETOFFEREDBASKET_PLAN_FEE,[HandSetOfferedBasket].[item_code] AS HANDSETOFFEREDBASKET_ITEM_CODE,[HandSetOfferedBasket].[issue_type] AS HANDSETOFFEREDBASKET_ISSUE_TYPE";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[HandSetOfferedBasket]","["+ Configurator.MSSQLTablePrefix + "HandSetOfferedBasket]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = HandSetOfferedBasketRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                HandSetOfferedBasketEntity _oHandSetOfferedBasket = HandSetOfferedBasketRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_MID"])) {_oHandSetOfferedBasket.mid = (global::System.Nullable<int>)_oData["HANDSETOFFEREDBASKET_MID"]; } else {_oHandSetOfferedBasket.mid=null; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_R_OFFER"])) {_oHandSetOfferedBasket.r_offer = (string)_oData["HANDSETOFFEREDBASKET_R_OFFER"]; } else {_oHandSetOfferedBasket.r_offer=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_EXTRA_REBATE_AMOUNT"])) {_oHandSetOfferedBasket.extra_rebate_amount = (string)_oData["HANDSETOFFEREDBASKET_EXTRA_REBATE_AMOUNT"]; } else {_oHandSetOfferedBasket.extra_rebate_amount=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_CDATE"])) {_oHandSetOfferedBasket.cdate = (global::System.Nullable<DateTime>)_oData["HANDSETOFFEREDBASKET_CDATE"]; } else {_oHandSetOfferedBasket.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_AMOUNT"])) {_oHandSetOfferedBasket.amount = (string)_oData["HANDSETOFFEREDBASKET_AMOUNT"]; } else {_oHandSetOfferedBasket.amount=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_CID"])) {_oHandSetOfferedBasket.cid = (string)_oData["HANDSETOFFEREDBASKET_CID"]; } else {_oHandSetOfferedBasket.cid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_DID"])) {_oHandSetOfferedBasket.did = (string)_oData["HANDSETOFFEREDBASKET_DID"]; } else {_oHandSetOfferedBasket.did=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_SDATE"])) {_oHandSetOfferedBasket.sdate = (global::System.Nullable<DateTime>)_oData["HANDSETOFFEREDBASKET_SDATE"]; } else {_oHandSetOfferedBasket.sdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_PAYMENT"])) {_oHandSetOfferedBasket.payment = (string)_oData["HANDSETOFFEREDBASKET_PAYMENT"]; } else {_oHandSetOfferedBasket.payment=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_RETENTION_TYPE"])) {_oHandSetOfferedBasket.retention_type = (string)_oData["HANDSETOFFEREDBASKET_RETENTION_TYPE"]; } else {_oHandSetOfferedBasket.retention_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_EDATE"])) {_oHandSetOfferedBasket.edate = (global::System.Nullable<DateTime>)_oData["HANDSETOFFEREDBASKET_EDATE"]; } else {_oHandSetOfferedBasket.edate=null; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_CON_PER"])) {_oHandSetOfferedBasket.con_per = (string)_oData["HANDSETOFFEREDBASKET_CON_PER"]; } else {_oHandSetOfferedBasket.con_per=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_DDATE"])) {_oHandSetOfferedBasket.ddate = (global::System.Nullable<DateTime>)_oData["HANDSETOFFEREDBASKET_DDATE"]; } else {_oHandSetOfferedBasket.ddate=null; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_NORMAL_REBATE_TYPE"])) {_oHandSetOfferedBasket.normal_rebate_type = (string)_oData["HANDSETOFFEREDBASKET_NORMAL_REBATE_TYPE"]; } else {_oHandSetOfferedBasket.normal_rebate_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_PREMIUM"])) {_oHandSetOfferedBasket.premium = (string)_oData["HANDSETOFFEREDBASKET_PREMIUM"]; } else {_oHandSetOfferedBasket.premium=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_EXTRA_REBATE"])) {_oHandSetOfferedBasket.extra_rebate = (string)_oData["HANDSETOFFEREDBASKET_EXTRA_REBATE"]; } else {_oHandSetOfferedBasket.extra_rebate=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_REBATE_GP"])) {_oHandSetOfferedBasket.rebate_gp = (string)_oData["HANDSETOFFEREDBASKET_REBATE_GP"]; } else {_oHandSetOfferedBasket.rebate_gp=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_NORMAL_REBATE"])) {_oHandSetOfferedBasket.normal_rebate = (global::System.Nullable<bool>)_oData["HANDSETOFFEREDBASKET_NORMAL_REBATE"]; } else {_oHandSetOfferedBasket.normal_rebate=null; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_HS_MODEL"])) {_oHandSetOfferedBasket.hs_model = (string)_oData["HANDSETOFFEREDBASKET_HS_MODEL"]; } else {_oHandSetOfferedBasket.hs_model=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_OFFER_TYPE_ID"])) {_oHandSetOfferedBasket.offer_type_id = (global::System.Nullable<int>)_oData["HANDSETOFFEREDBASKET_OFFER_TYPE_ID"]; } else {_oHandSetOfferedBasket.offer_type_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_ACTIVE"])) {_oHandSetOfferedBasket.active = (global::System.Nullable<bool>)_oData["HANDSETOFFEREDBASKET_ACTIVE"]; } else {_oHandSetOfferedBasket.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_REBATE_AMOUNT"])) {_oHandSetOfferedBasket.rebate_amount = (string)_oData["HANDSETOFFEREDBASKET_REBATE_AMOUNT"]; } else {_oHandSetOfferedBasket.rebate_amount=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_PLAN_FEE"])) {_oHandSetOfferedBasket.plan_fee = (string)_oData["HANDSETOFFEREDBASKET_PLAN_FEE"]; } else {_oHandSetOfferedBasket.plan_fee=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_ITEM_CODE"])) {_oHandSetOfferedBasket.item_code = (string)_oData["HANDSETOFFEREDBASKET_ITEM_CODE"]; } else {_oHandSetOfferedBasket.item_code=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_ISSUE_TYPE"])) {_oHandSetOfferedBasket.issue_type = (string)_oData["HANDSETOFFEREDBASKET_ISSUE_TYPE"]; } else {_oHandSetOfferedBasket.issue_type=global::System.String.Empty; }
                _oHandSetOfferedBasket.SetDB(x_oDB);
                _oHandSetOfferedBasket.GetFound();
                _oRow.Add(_oHandSetOfferedBasket);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( HandSetOfferedBasket.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,HandSetOfferedBasket.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(HandSetOfferedBasket.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(HandSetOfferedBasket.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [HandSetOfferedBasket].[mid] AS HANDSETOFFEREDBASKET_MID,[HandSetOfferedBasket].[r_offer] AS HANDSETOFFEREDBASKET_R_OFFER,[HandSetOfferedBasket].[extra_rebate_amount] AS HANDSETOFFEREDBASKET_EXTRA_REBATE_AMOUNT,[HandSetOfferedBasket].[cdate] AS HANDSETOFFEREDBASKET_CDATE,[HandSetOfferedBasket].[amount] AS HANDSETOFFEREDBASKET_AMOUNT,[HandSetOfferedBasket].[cid] AS HANDSETOFFEREDBASKET_CID,[HandSetOfferedBasket].[did] AS HANDSETOFFEREDBASKET_DID,[HandSetOfferedBasket].[sdate] AS HANDSETOFFEREDBASKET_SDATE,[HandSetOfferedBasket].[payment] AS HANDSETOFFEREDBASKET_PAYMENT,[HandSetOfferedBasket].[retention_type] AS HANDSETOFFEREDBASKET_RETENTION_TYPE,[HandSetOfferedBasket].[edate] AS HANDSETOFFEREDBASKET_EDATE,[HandSetOfferedBasket].[con_per] AS HANDSETOFFEREDBASKET_CON_PER,[HandSetOfferedBasket].[ddate] AS HANDSETOFFEREDBASKET_DDATE,[HandSetOfferedBasket].[normal_rebate_type] AS HANDSETOFFEREDBASKET_NORMAL_REBATE_TYPE,[HandSetOfferedBasket].[premium] AS HANDSETOFFEREDBASKET_PREMIUM,[HandSetOfferedBasket].[extra_rebate] AS HANDSETOFFEREDBASKET_EXTRA_REBATE,[HandSetOfferedBasket].[rebate_gp] AS HANDSETOFFEREDBASKET_REBATE_GP,[HandSetOfferedBasket].[normal_rebate] AS HANDSETOFFEREDBASKET_NORMAL_REBATE,[HandSetOfferedBasket].[hs_model] AS HANDSETOFFEREDBASKET_HS_MODEL,[HandSetOfferedBasket].[offer_type_id] AS HANDSETOFFEREDBASKET_OFFER_TYPE_ID,[HandSetOfferedBasket].[active] AS HANDSETOFFEREDBASKET_ACTIVE,[HandSetOfferedBasket].[rebate_amount] AS HANDSETOFFEREDBASKET_REBATE_AMOUNT,[HandSetOfferedBasket].[plan_fee] AS HANDSETOFFEREDBASKET_PLAN_FEE,[HandSetOfferedBasket].[item_code] AS HANDSETOFFEREDBASKET_ITEM_CODE,[HandSetOfferedBasket].[issue_type] AS HANDSETOFFEREDBASKET_ISSUE_TYPE  FROM  [HandSetOfferedBasket]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[HandSetOfferedBasket]","["+ Configurator.MSSQLTablePrefix + "HandSetOfferedBasket]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"HandSetOfferedBasket");
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
        
        public bool Insert(string x_sR_offer,string x_sExtra_rebate_amount,global::System.Nullable<DateTime> x_dCdate,string x_sAmount,string x_sCid,string x_sDid,global::System.Nullable<DateTime> x_dSdate,string x_sPayment,string x_sRetention_type,global::System.Nullable<DateTime> x_dEdate,string x_sCon_per,global::System.Nullable<DateTime> x_dDdate,string x_sNormal_rebate_type,string x_sPremium,string x_sExtra_rebate,string x_sRebate_gp,global::System.Nullable<bool> x_bNormal_rebate,string x_sHs_model,global::System.Nullable<int> x_iOffer_type_id,global::System.Nullable<bool> x_bActive,string x_sRebate_amount,string x_sPlan_fee,string x_sItem_code,string x_sIssue_type)
        {
            HandSetOfferedBasket _oHandSetOfferedBasket=HandSetOfferedBasketRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oHandSetOfferedBasket.r_offer=x_sR_offer;
            _oHandSetOfferedBasket.extra_rebate_amount=x_sExtra_rebate_amount;
            _oHandSetOfferedBasket.cdate=x_dCdate;
            _oHandSetOfferedBasket.amount=x_sAmount;
            _oHandSetOfferedBasket.cid=x_sCid;
            _oHandSetOfferedBasket.did=x_sDid;
            _oHandSetOfferedBasket.sdate=x_dSdate;
            _oHandSetOfferedBasket.payment=x_sPayment;
            _oHandSetOfferedBasket.retention_type=x_sRetention_type;
            _oHandSetOfferedBasket.edate=x_dEdate;
            _oHandSetOfferedBasket.con_per=x_sCon_per;
            _oHandSetOfferedBasket.ddate=x_dDdate;
            _oHandSetOfferedBasket.normal_rebate_type=x_sNormal_rebate_type;
            _oHandSetOfferedBasket.premium=x_sPremium;
            _oHandSetOfferedBasket.extra_rebate=x_sExtra_rebate;
            _oHandSetOfferedBasket.rebate_gp=x_sRebate_gp;
            _oHandSetOfferedBasket.normal_rebate=x_bNormal_rebate;
            _oHandSetOfferedBasket.hs_model=x_sHs_model;
            _oHandSetOfferedBasket.offer_type_id=x_iOffer_type_id;
            _oHandSetOfferedBasket.active=x_bActive;
            _oHandSetOfferedBasket.rebate_amount=x_sRebate_amount;
            _oHandSetOfferedBasket.plan_fee=x_sPlan_fee;
            _oHandSetOfferedBasket.item_code=x_sItem_code;
            _oHandSetOfferedBasket.issue_type=x_sIssue_type;
            return InsertWithOutLastID(n_oDB, _oHandSetOfferedBasket);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sR_offer,string x_sExtra_rebate_amount,global::System.Nullable<DateTime> x_dCdate,string x_sAmount,string x_sCid,string x_sDid,global::System.Nullable<DateTime> x_dSdate,string x_sPayment,string x_sRetention_type,global::System.Nullable<DateTime> x_dEdate,string x_sCon_per,global::System.Nullable<DateTime> x_dDdate,string x_sNormal_rebate_type,string x_sPremium,string x_sExtra_rebate,string x_sRebate_gp,global::System.Nullable<bool> x_bNormal_rebate,string x_sHs_model,global::System.Nullable<int> x_iOffer_type_id,global::System.Nullable<bool> x_bActive,string x_sRebate_amount,string x_sPlan_fee,string x_sItem_code,string x_sIssue_type)
        {
            HandSetOfferedBasket _oHandSetOfferedBasket=HandSetOfferedBasketRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oHandSetOfferedBasket.r_offer=x_sR_offer;
            _oHandSetOfferedBasket.extra_rebate_amount=x_sExtra_rebate_amount;
            _oHandSetOfferedBasket.cdate=x_dCdate;
            _oHandSetOfferedBasket.amount=x_sAmount;
            _oHandSetOfferedBasket.cid=x_sCid;
            _oHandSetOfferedBasket.did=x_sDid;
            _oHandSetOfferedBasket.sdate=x_dSdate;
            _oHandSetOfferedBasket.payment=x_sPayment;
            _oHandSetOfferedBasket.retention_type=x_sRetention_type;
            _oHandSetOfferedBasket.edate=x_dEdate;
            _oHandSetOfferedBasket.con_per=x_sCon_per;
            _oHandSetOfferedBasket.ddate=x_dDdate;
            _oHandSetOfferedBasket.normal_rebate_type=x_sNormal_rebate_type;
            _oHandSetOfferedBasket.premium=x_sPremium;
            _oHandSetOfferedBasket.extra_rebate=x_sExtra_rebate;
            _oHandSetOfferedBasket.rebate_gp=x_sRebate_gp;
            _oHandSetOfferedBasket.normal_rebate=x_bNormal_rebate;
            _oHandSetOfferedBasket.hs_model=x_sHs_model;
            _oHandSetOfferedBasket.offer_type_id=x_iOffer_type_id;
            _oHandSetOfferedBasket.active=x_bActive;
            _oHandSetOfferedBasket.rebate_amount=x_sRebate_amount;
            _oHandSetOfferedBasket.plan_fee=x_sPlan_fee;
            _oHandSetOfferedBasket.item_code=x_sItem_code;
            _oHandSetOfferedBasket.issue_type=x_sIssue_type;
            return InsertWithOutLastID(x_oDB, _oHandSetOfferedBasket);
        }
        
        
        public bool Insert(HandSetOfferedBasket x_oHandSetOfferedBasket)
        {
            return InsertWithOutLastID(n_oDB, x_oHandSetOfferedBasket);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is HandSetOfferedBasket)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (HandSetOfferedBasket)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,HandSetOfferedBasket x_oHandSetOfferedBasket)
        {
            return InsertWithOutLastID(x_oDB, x_oHandSetOfferedBasket);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,HandSetOfferedBasket x_oHandSetOfferedBasket)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [HandSetOfferedBasket]   ([r_offer],[extra_rebate_amount],[cdate],[amount],[cid],[did],[sdate],[payment],[retention_type],[edate],[con_per],[ddate],[normal_rebate_type],[premium],[extra_rebate],[rebate_gp],[normal_rebate],[hs_model],[offer_type_id],[active],[rebate_amount],[plan_fee],[item_code],[issue_type])  VALUES  (@r_offer,@extra_rebate_amount,@cdate,@amount,@cid,@did,@sdate,@payment,@retention_type,@edate,@con_per,@ddate,@normal_rebate_type,@premium,@extra_rebate,@rebate_gp,@normal_rebate,@hs_model,@offer_type_id,@active,@rebate_amount,@plan_fee,@item_code,@issue_type)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[HandSetOfferedBasket]","["+ Configurator.MSSQLTablePrefix + "HandSetOfferedBasket]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oHandSetOfferedBasket);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,HandSetOfferedBasket x_oHandSetOfferedBasket)
        {
            bool _bResult = false;
            if (!x_oHandSetOfferedBasket.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oHandSetOfferedBasket.r_offer==null){  x_oCmd.Parameters.Add("@r_offer", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@r_offer", global::System.Data.SqlDbType.NVarChar,50).Value=x_oHandSetOfferedBasket.r_offer; }
                if(x_oHandSetOfferedBasket.extra_rebate_amount==null){  x_oCmd.Parameters.Add("@extra_rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@extra_rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value=x_oHandSetOfferedBasket.extra_rebate_amount; }
                if(x_oHandSetOfferedBasket.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oHandSetOfferedBasket.cdate; }
                if(x_oHandSetOfferedBasket.amount==null){  x_oCmd.Parameters.Add("@amount", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@amount", global::System.Data.SqlDbType.NVarChar,10).Value=x_oHandSetOfferedBasket.amount; }
                if(x_oHandSetOfferedBasket.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value=x_oHandSetOfferedBasket.cid; }
                if(x_oHandSetOfferedBasket.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value=x_oHandSetOfferedBasket.did; }
                if(x_oHandSetOfferedBasket.sdate==null){  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value=x_oHandSetOfferedBasket.sdate; }
                if(x_oHandSetOfferedBasket.payment==null){  x_oCmd.Parameters.Add("@payment", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@payment", global::System.Data.SqlDbType.NVarChar,20).Value=x_oHandSetOfferedBasket.payment; }
                if(x_oHandSetOfferedBasket.retention_type==null){  x_oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oHandSetOfferedBasket.retention_type; }
                if(x_oHandSetOfferedBasket.edate==null){  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=x_oHandSetOfferedBasket.edate; }
                if(x_oHandSetOfferedBasket.con_per==null){  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10).Value=x_oHandSetOfferedBasket.con_per; }
                if(x_oHandSetOfferedBasket.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oHandSetOfferedBasket.ddate; }
                if(x_oHandSetOfferedBasket.normal_rebate_type==null){  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value=x_oHandSetOfferedBasket.normal_rebate_type; }
                if(x_oHandSetOfferedBasket.premium==null){  x_oCmd.Parameters.Add("@premium", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@premium", global::System.Data.SqlDbType.NVarChar,100).Value=x_oHandSetOfferedBasket.premium; }
                if(x_oHandSetOfferedBasket.extra_rebate==null){  x_oCmd.Parameters.Add("@extra_rebate", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@extra_rebate", global::System.Data.SqlDbType.NVarChar,10).Value=x_oHandSetOfferedBasket.extra_rebate; }
                if(x_oHandSetOfferedBasket.rebate_gp==null){  x_oCmd.Parameters.Add("@rebate_gp", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rebate_gp", global::System.Data.SqlDbType.NVarChar,20).Value=x_oHandSetOfferedBasket.rebate_gp; }
                if(x_oHandSetOfferedBasket.normal_rebate==null){  x_oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit).Value=x_oHandSetOfferedBasket.normal_rebate; }
                if(x_oHandSetOfferedBasket.hs_model==null){  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,100).Value=x_oHandSetOfferedBasket.hs_model; }
                if(x_oHandSetOfferedBasket.offer_type_id==null){  x_oCmd.Parameters.Add("@offer_type_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@offer_type_id", global::System.Data.SqlDbType.Int).Value=x_oHandSetOfferedBasket.offer_type_id; }
                if(x_oHandSetOfferedBasket.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oHandSetOfferedBasket.active; }
                if(x_oHandSetOfferedBasket.rebate_amount==null){  x_oCmd.Parameters.Add("@rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value=x_oHandSetOfferedBasket.rebate_amount; }
                if(x_oHandSetOfferedBasket.plan_fee==null){  x_oCmd.Parameters.Add("@plan_fee", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@plan_fee", global::System.Data.SqlDbType.NVarChar,10).Value=x_oHandSetOfferedBasket.plan_fee; }
                if(x_oHandSetOfferedBasket.item_code==null){  x_oCmd.Parameters.Add("@item_code", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@item_code", global::System.Data.SqlDbType.NVarChar,10).Value=x_oHandSetOfferedBasket.item_code; }
                if(x_oHandSetOfferedBasket.issue_type==null){  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oHandSetOfferedBasket.issue_type; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,string x_sR_offer,string x_sExtra_rebate_amount,global::System.Nullable<DateTime> x_dCdate,string x_sAmount,string x_sCid,string x_sDid,global::System.Nullable<DateTime> x_dSdate,string x_sPayment,string x_sRetention_type,global::System.Nullable<DateTime> x_dEdate,string x_sCon_per,global::System.Nullable<DateTime> x_dDdate,string x_sNormal_rebate_type,string x_sPremium,string x_sExtra_rebate,string x_sRebate_gp,global::System.Nullable<bool> x_bNormal_rebate,string x_sHs_model,global::System.Nullable<int> x_iOffer_type_id,global::System.Nullable<bool> x_bActive,string x_sRebate_amount,string x_sPlan_fee,string x_sItem_code,string x_sIssue_type)
        {
            int _oLastID;
            HandSetOfferedBasket _oHandSetOfferedBasket=HandSetOfferedBasketRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oHandSetOfferedBasket.r_offer=x_sR_offer;
            _oHandSetOfferedBasket.extra_rebate_amount=x_sExtra_rebate_amount;
            _oHandSetOfferedBasket.cdate=x_dCdate;
            _oHandSetOfferedBasket.amount=x_sAmount;
            _oHandSetOfferedBasket.cid=x_sCid;
            _oHandSetOfferedBasket.did=x_sDid;
            _oHandSetOfferedBasket.sdate=x_dSdate;
            _oHandSetOfferedBasket.payment=x_sPayment;
            _oHandSetOfferedBasket.retention_type=x_sRetention_type;
            _oHandSetOfferedBasket.edate=x_dEdate;
            _oHandSetOfferedBasket.con_per=x_sCon_per;
            _oHandSetOfferedBasket.ddate=x_dDdate;
            _oHandSetOfferedBasket.normal_rebate_type=x_sNormal_rebate_type;
            _oHandSetOfferedBasket.premium=x_sPremium;
            _oHandSetOfferedBasket.extra_rebate=x_sExtra_rebate;
            _oHandSetOfferedBasket.rebate_gp=x_sRebate_gp;
            _oHandSetOfferedBasket.normal_rebate=x_bNormal_rebate;
            _oHandSetOfferedBasket.hs_model=x_sHs_model;
            _oHandSetOfferedBasket.offer_type_id=x_iOffer_type_id;
            _oHandSetOfferedBasket.active=x_bActive;
            _oHandSetOfferedBasket.rebate_amount=x_sRebate_amount;
            _oHandSetOfferedBasket.plan_fee=x_sPlan_fee;
            _oHandSetOfferedBasket.item_code=x_sItem_code;
            _oHandSetOfferedBasket.issue_type=x_sIssue_type;
            if(InsertWithLastID(x_oDB, _oHandSetOfferedBasket,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(HandSetOfferedBasket x_oHandSetOfferedBasket)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oHandSetOfferedBasket, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, HandSetOfferedBasket x_oHandSetOfferedBasket)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oHandSetOfferedBasket, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is HandSetOfferedBasket)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (HandSetOfferedBasket)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,HandSetOfferedBasket x_oHandSetOfferedBasket, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [HandSetOfferedBasket]   ([r_offer],[extra_rebate_amount],[cdate],[amount],[cid],[did],[sdate],[payment],[retention_type],[edate],[con_per],[ddate],[normal_rebate_type],[premium],[extra_rebate],[rebate_gp],[normal_rebate],[hs_model],[offer_type_id],[active],[rebate_amount],[plan_fee],[item_code],[issue_type])  VALUES  (@r_offer,@extra_rebate_amount,@cdate,@amount,@cid,@did,@sdate,@payment,@retention_type,@edate,@con_per,@ddate,@normal_rebate_type,@premium,@extra_rebate,@rebate_gp,@normal_rebate,@hs_model,@offer_type_id,@active,@rebate_amount,@plan_fee,@item_code,@issue_type)"+" SELECT  @@IDENTITY AS HandSetOfferedBasket_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[HandSetOfferedBasket]","["+ Configurator.MSSQLTablePrefix + "HandSetOfferedBasket]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oHandSetOfferedBasket,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,HandSetOfferedBasket x_oHandSetOfferedBasket, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oHandSetOfferedBasket.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oHandSetOfferedBasket.r_offer==null){  x_oCmd.Parameters.Add("@r_offer", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@r_offer", global::System.Data.SqlDbType.NVarChar,50).Value=x_oHandSetOfferedBasket.r_offer; }
                if(x_oHandSetOfferedBasket.extra_rebate_amount==null){  x_oCmd.Parameters.Add("@extra_rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@extra_rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value=x_oHandSetOfferedBasket.extra_rebate_amount; }
                if(x_oHandSetOfferedBasket.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oHandSetOfferedBasket.cdate; }
                if(x_oHandSetOfferedBasket.amount==null){  x_oCmd.Parameters.Add("@amount", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@amount", global::System.Data.SqlDbType.NVarChar,10).Value=x_oHandSetOfferedBasket.amount; }
                if(x_oHandSetOfferedBasket.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value=x_oHandSetOfferedBasket.cid; }
                if(x_oHandSetOfferedBasket.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value=x_oHandSetOfferedBasket.did; }
                if(x_oHandSetOfferedBasket.sdate==null){  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value=x_oHandSetOfferedBasket.sdate; }
                if(x_oHandSetOfferedBasket.payment==null){  x_oCmd.Parameters.Add("@payment", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@payment", global::System.Data.SqlDbType.NVarChar,20).Value=x_oHandSetOfferedBasket.payment; }
                if(x_oHandSetOfferedBasket.retention_type==null){  x_oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oHandSetOfferedBasket.retention_type; }
                if(x_oHandSetOfferedBasket.edate==null){  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=x_oHandSetOfferedBasket.edate; }
                if(x_oHandSetOfferedBasket.con_per==null){  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10).Value=x_oHandSetOfferedBasket.con_per; }
                if(x_oHandSetOfferedBasket.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oHandSetOfferedBasket.ddate; }
                if(x_oHandSetOfferedBasket.normal_rebate_type==null){  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value=x_oHandSetOfferedBasket.normal_rebate_type; }
                if(x_oHandSetOfferedBasket.premium==null){  x_oCmd.Parameters.Add("@premium", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@premium", global::System.Data.SqlDbType.NVarChar,100).Value=x_oHandSetOfferedBasket.premium; }
                if(x_oHandSetOfferedBasket.extra_rebate==null){  x_oCmd.Parameters.Add("@extra_rebate", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@extra_rebate", global::System.Data.SqlDbType.NVarChar,10).Value=x_oHandSetOfferedBasket.extra_rebate; }
                if(x_oHandSetOfferedBasket.rebate_gp==null){  x_oCmd.Parameters.Add("@rebate_gp", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rebate_gp", global::System.Data.SqlDbType.NVarChar,20).Value=x_oHandSetOfferedBasket.rebate_gp; }
                if(x_oHandSetOfferedBasket.normal_rebate==null){  x_oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit).Value=x_oHandSetOfferedBasket.normal_rebate; }
                if(x_oHandSetOfferedBasket.hs_model==null){  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,100).Value=x_oHandSetOfferedBasket.hs_model; }
                if(x_oHandSetOfferedBasket.offer_type_id==null){  x_oCmd.Parameters.Add("@offer_type_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@offer_type_id", global::System.Data.SqlDbType.Int).Value=x_oHandSetOfferedBasket.offer_type_id; }
                if(x_oHandSetOfferedBasket.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oHandSetOfferedBasket.active; }
                if(x_oHandSetOfferedBasket.rebate_amount==null){  x_oCmd.Parameters.Add("@rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value=x_oHandSetOfferedBasket.rebate_amount; }
                if(x_oHandSetOfferedBasket.plan_fee==null){  x_oCmd.Parameters.Add("@plan_fee", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@plan_fee", global::System.Data.SqlDbType.NVarChar,10).Value=x_oHandSetOfferedBasket.plan_fee; }
                if(x_oHandSetOfferedBasket.item_code==null){  x_oCmd.Parameters.Add("@item_code", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@item_code", global::System.Data.SqlDbType.NVarChar,10).Value=x_oHandSetOfferedBasket.item_code; }
                if(x_oHandSetOfferedBasket.issue_type==null){  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oHandSetOfferedBasket.issue_type; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["HandSetOfferedBasket_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["HandSetOfferedBasket_LASTID"].ToString()) && int.TryParse(_oData["HandSetOfferedBasket_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sR_offer,string x_sExtra_rebate_amount,global::System.Nullable<DateTime> x_dCdate,string x_sAmount,string x_sCid,string x_sDid,global::System.Nullable<DateTime> x_dSdate,string x_sPayment,string x_sRetention_type,global::System.Nullable<DateTime> x_dEdate,string x_sCon_per,global::System.Nullable<DateTime> x_dDdate,string x_sNormal_rebate_type,string x_sPremium,string x_sExtra_rebate,string x_sRebate_gp,global::System.Nullable<bool> x_bNormal_rebate,string x_sHs_model,global::System.Nullable<int> x_iOffer_type_id,global::System.Nullable<bool> x_bActive,string x_sRebate_amount,string x_sPlan_fee,string x_sItem_code,string x_sIssue_type)
        {
            int _oLastID;
            HandSetOfferedBasket _oHandSetOfferedBasket=HandSetOfferedBasketRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oHandSetOfferedBasket.r_offer=x_sR_offer;
            _oHandSetOfferedBasket.extra_rebate_amount=x_sExtra_rebate_amount;
            _oHandSetOfferedBasket.cdate=x_dCdate;
            _oHandSetOfferedBasket.amount=x_sAmount;
            _oHandSetOfferedBasket.cid=x_sCid;
            _oHandSetOfferedBasket.did=x_sDid;
            _oHandSetOfferedBasket.sdate=x_dSdate;
            _oHandSetOfferedBasket.payment=x_sPayment;
            _oHandSetOfferedBasket.retention_type=x_sRetention_type;
            _oHandSetOfferedBasket.edate=x_dEdate;
            _oHandSetOfferedBasket.con_per=x_sCon_per;
            _oHandSetOfferedBasket.ddate=x_dDdate;
            _oHandSetOfferedBasket.normal_rebate_type=x_sNormal_rebate_type;
            _oHandSetOfferedBasket.premium=x_sPremium;
            _oHandSetOfferedBasket.extra_rebate=x_sExtra_rebate;
            _oHandSetOfferedBasket.rebate_gp=x_sRebate_gp;
            _oHandSetOfferedBasket.normal_rebate=x_bNormal_rebate;
            _oHandSetOfferedBasket.hs_model=x_sHs_model;
            _oHandSetOfferedBasket.offer_type_id=x_iOffer_type_id;
            _oHandSetOfferedBasket.active=x_bActive;
            _oHandSetOfferedBasket.rebate_amount=x_sRebate_amount;
            _oHandSetOfferedBasket.plan_fee=x_sPlan_fee;
            _oHandSetOfferedBasket.item_code=x_sItem_code;
            _oHandSetOfferedBasket.issue_type=x_sIssue_type;
            if(InsertWithLastID_SP(x_oDB, _oHandSetOfferedBasket,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(HandSetOfferedBasket x_oHandSetOfferedBasket)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oHandSetOfferedBasket, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, HandSetOfferedBasket x_oHandSetOfferedBasket)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oHandSetOfferedBasket, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is HandSetOfferedBasket)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (HandSetOfferedBasket)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,HandSetOfferedBasket x_oHandSetOfferedBasket, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "HANDSETOFFEREDBASKET";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oHandSetOfferedBasket,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,HandSetOfferedBasket x_oHandSetOfferedBasket, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@r_offer", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferedBasket.r_offer==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferedBasket.r_offer; }
                _oPar=x_oCmd.Parameters.Add("@extra_rebate_amount", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferedBasket.extra_rebate_amount==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferedBasket.extra_rebate_amount; }
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferedBasket.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oHandSetOfferedBasket.cdate; }
                _oPar=x_oCmd.Parameters.Add("@amount", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferedBasket.amount==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferedBasket.amount; }
                _oPar=x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferedBasket.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferedBasket.cid; }
                _oPar=x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferedBasket.did==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferedBasket.did; }
                _oPar=x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferedBasket.sdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oHandSetOfferedBasket.sdate; }
                _oPar=x_oCmd.Parameters.Add("@payment", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferedBasket.payment==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferedBasket.payment; }
                _oPar=x_oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferedBasket.retention_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferedBasket.retention_type; }
                _oPar=x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferedBasket.edate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oHandSetOfferedBasket.edate; }
                _oPar=x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferedBasket.con_per==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferedBasket.con_per; }
                _oPar=x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferedBasket.ddate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oHandSetOfferedBasket.ddate; }
                _oPar=x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferedBasket.normal_rebate_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferedBasket.normal_rebate_type; }
                _oPar=x_oCmd.Parameters.Add("@premium", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferedBasket.premium==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferedBasket.premium; }
                _oPar=x_oCmd.Parameters.Add("@extra_rebate", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferedBasket.extra_rebate==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferedBasket.extra_rebate; }
                _oPar=x_oCmd.Parameters.Add("@rebate_gp", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferedBasket.rebate_gp==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferedBasket.rebate_gp; }
                _oPar=x_oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferedBasket.normal_rebate==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferedBasket.normal_rebate; }
                _oPar=x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferedBasket.hs_model==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferedBasket.hs_model; }
                _oPar=x_oCmd.Parameters.Add("@offer_type_id", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferedBasket.offer_type_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferedBasket.offer_type_id; }
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferedBasket.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferedBasket.active; }
                _oPar=x_oCmd.Parameters.Add("@rebate_amount", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferedBasket.rebate_amount==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferedBasket.rebate_amount; }
                _oPar=x_oCmd.Parameters.Add("@plan_fee", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferedBasket.plan_fee==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferedBasket.plan_fee; }
                _oPar=x_oCmd.Parameters.Add("@item_code", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferedBasket.item_code==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferedBasket.item_code; }
                _oPar=x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oHandSetOfferedBasket.issue_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oHandSetOfferedBasket.issue_type; }
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
        
        #region INSERT_HANDSETOFFEREDBASKET Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2011-07-13>
        ///-- Description:	<Description,HANDSETOFFEREDBASKET, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_HANDSETOFFEREDBASKET Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_HANDSETOFFEREDBASKET', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_HANDSETOFFEREDBASKET;
        GO
        CREATE PROCEDURE INSERT_HANDSETOFFEREDBASKET
        	-- Add the parameters for the stored procedure here
        @RETURN_MID int output,
        @r_offer nvarchar(50),
        @extra_rebate_amount nvarchar(50),
        @cdate datetime,
        @amount nvarchar(10),
        @cid char(10),
        @did char(10),
        @sdate datetime,
        @payment nvarchar(20),
        @retention_type nvarchar(50),
        @edate datetime,
        @con_per nvarchar(10),
        @ddate datetime,
        @normal_rebate_type nvarchar(100),
        @premium nvarchar(100),
        @extra_rebate nvarchar(10),
        @rebate_gp nvarchar(20),
        @normal_rebate bit,
        @hs_model nvarchar(100),
        @offer_type_id int,
        @active bit,
        @rebate_amount nvarchar(50),
        @plan_fee nvarchar(10),
        @item_code nvarchar(10),
        @issue_type nvarchar(50)
        AS
        
        INSERT INTO  [HandSetOfferedBasket]   ([r_offer],[extra_rebate_amount],[cdate],[amount],[cid],[did],[sdate],[payment],[retention_type],[edate],[con_per],[ddate],[normal_rebate_type],[premium],[extra_rebate],[rebate_gp],[normal_rebate],[hs_model],[offer_type_id],[active],[rebate_amount],[plan_fee],[item_code],[issue_type])  VALUES  (@r_offer,@extra_rebate_amount,@cdate,@amount,@cid,@did,@sdate,@payment,@retention_type,@edate,@con_per,@ddate,@normal_rebate_type,@premium,@extra_rebate,@rebate_gp,@normal_rebate,@hs_model,@offer_type_id,@active,@rebate_amount,@plan_fee,@item_code,@issue_type)
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
            string _sQuery = "DELETE FROM  [HandSetOfferedBasket]  WHERE [HandSetOfferedBasket].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[HandSetOfferedBasket]","["+ Configurator.MSSQLTablePrefix + "HandSetOfferedBasket]"); }
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
            return HandSetOfferedBasketRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [HandSetOfferedBasket]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[HandSetOfferedBasket]","["+ Configurator.MSSQLTablePrefix + "HandSetOfferedBasket]"); }
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
            string _sQuery = "DELETE FROM [HandSetOfferedBasket]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[HandSetOfferedBasket]","["+ Configurator.MSSQLTablePrefix + "HandSetOfferedBasket]"); }
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


