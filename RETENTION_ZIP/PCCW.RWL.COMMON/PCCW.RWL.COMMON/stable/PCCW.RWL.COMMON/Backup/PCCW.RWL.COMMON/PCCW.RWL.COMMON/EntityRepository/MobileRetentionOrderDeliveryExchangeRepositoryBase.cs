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
///-- Create date: <Create Date 2011-02-16>
///-- Description:	<Description,Table :[MobileRetentionOrderDeliveryExchange],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileRetentionOrderDeliveryExchange] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"MobileRetentionOrderDeliveryExchange")]
    public class MobileRetentionOrderDeliveryExchangeRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static MobileRetentionOrderDeliveryExchangeRepositoryBase instance;
        public static MobileRetentionOrderDeliveryExchangeRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new MobileRetentionOrderDeliveryExchangeRepositoryBase(_oDB);
            }
            return instance;
        }
        public static MobileRetentionOrderDeliveryExchangeRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new MobileRetentionOrderDeliveryExchangeRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<MobileRetentionOrderDeliveryExchangeEntity> MobileRetentionOrderDeliveryExchanges;
        #endregion
        
        #region Constructor
        public MobileRetentionOrderDeliveryExchangeRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~MobileRetentionOrderDeliveryExchangeRepositoryBase() { 
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
        public static MobileRetentionOrderDeliveryExchange CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new MobileRetentionOrderDeliveryExchange(_oDB);
        }
        
        public static MobileRetentionOrderDeliveryExchange CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new MobileRetentionOrderDeliveryExchange(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [MobileRetentionOrderDeliveryExchange]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionOrderDeliveryExchange]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrderDeliveryExchange]"); }
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
        
        
        public MobileRetentionOrderDeliveryExchangeEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }
        
        
        public static MobileRetentionOrderDeliveryExchangeEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            if (x_oDB==null) { return null; }
            MobileRetentionOrderDeliveryExchange _MobileRetentionOrderDeliveryExchange = (MobileRetentionOrderDeliveryExchange)MobileRetentionOrderDeliveryExchangeRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_MobileRetentionOrderDeliveryExchange.Load(x_iId)) { return null; }
            return _MobileRetentionOrderDeliveryExchange;
        }
        
        
        
        public static MobileRetentionOrderDeliveryExchangeEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<MobileRetentionOrderDeliveryExchangeEntity> _oMobileRetentionOrderDeliveryExchangeList = GetListObj(x_oDB,0, "id", x_oArrayItemId);
            if(_oMobileRetentionOrderDeliveryExchangeList==null){ return null;}
            return _oMobileRetentionOrderDeliveryExchangeList.Count == 0 ? null : _oMobileRetentionOrderDeliveryExchangeList.ToArray();
        }
        
        public static List<MobileRetentionOrderDeliveryExchangeEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "id", x_oArrayItemId);
        }
        
        
        public static MobileRetentionOrderDeliveryExchangeEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileRetentionOrderDeliveryExchangeEntity> _oMobileRetentionOrderDeliveryExchangeList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oMobileRetentionOrderDeliveryExchangeList==null){ return null;}
            return _oMobileRetentionOrderDeliveryExchangeList.Count == 0 ? null : _oMobileRetentionOrderDeliveryExchangeList.ToArray();
        }
        
        
        public static MobileRetentionOrderDeliveryExchangeEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileRetentionOrderDeliveryExchangeEntity> _oMobileRetentionOrderDeliveryExchangeList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oMobileRetentionOrderDeliveryExchangeList==null){ return null;}
            return _oMobileRetentionOrderDeliveryExchangeList.Count == 0 ? null : _oMobileRetentionOrderDeliveryExchangeList.ToArray();
        }
        
        public static List<MobileRetentionOrderDeliveryExchangeEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<MobileRetentionOrderDeliveryExchangeEntity> _oRow = new List<MobileRetentionOrderDeliveryExchangeEntity>();
            string _sQuery = "SELECT  "+_sTop+" [MobileRetentionOrderDeliveryExchange].[id] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_ID,[MobileRetentionOrderDeliveryExchange].[cdate] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_CDATE,[MobileRetentionOrderDeliveryExchange].[cid] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_CID,[MobileRetentionOrderDeliveryExchange].[did] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_DID,[MobileRetentionOrderDeliveryExchange].[active] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_ACTIVE,[MobileRetentionOrderDeliveryExchange].[rate_plan] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_RATE_PLAN,[MobileRetentionOrderDeliveryExchange].[program] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_PROGRAM,[MobileRetentionOrderDeliveryExchange].[hs_model] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_HS_MODEL,[MobileRetentionOrderDeliveryExchange].[normal_rebate_type] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_NORMAL_REBATE_TYPE,[MobileRetentionOrderDeliveryExchange].[ddate] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_DDATE,[MobileRetentionOrderDeliveryExchange].[con_per] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_CON_PER  FROM  [MobileRetentionOrderDeliveryExchange]";
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
                _sQuery += " WHERE [MobileRetentionOrderDeliveryExchange].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionOrderDeliveryExchange]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrderDeliveryExchange]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        MobileRetentionOrderDeliveryExchange _oMobileRetentionOrderDeliveryExchange = MobileRetentionOrderDeliveryExchangeRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_RATE_PLAN"])) {_oMobileRetentionOrderDeliveryExchange.rate_plan = (string)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_RATE_PLAN"]; }else{_oMobileRetentionOrderDeliveryExchange.rate_plan=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_CDATE"])) {_oMobileRetentionOrderDeliveryExchange.cdate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_CDATE"]; }else{_oMobileRetentionOrderDeliveryExchange.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_CID"])) {_oMobileRetentionOrderDeliveryExchange.cid = (string)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_CID"]; }else{_oMobileRetentionOrderDeliveryExchange.cid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_DID"])) {_oMobileRetentionOrderDeliveryExchange.did = (string)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_DID"]; }else{_oMobileRetentionOrderDeliveryExchange.did=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_CON_PER"])) {_oMobileRetentionOrderDeliveryExchange.con_per = (string)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_CON_PER"]; }else{_oMobileRetentionOrderDeliveryExchange.con_per=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_ID"])) {_oMobileRetentionOrderDeliveryExchange.id = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_ID"]; }else{_oMobileRetentionOrderDeliveryExchange.id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_ACTIVE"])) {_oMobileRetentionOrderDeliveryExchange.active = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_ACTIVE"]; }else{_oMobileRetentionOrderDeliveryExchange.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_HS_MODEL"])) {_oMobileRetentionOrderDeliveryExchange.hs_model = (string)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_HS_MODEL"]; }else{_oMobileRetentionOrderDeliveryExchange.hs_model=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_PROGRAM"])) {_oMobileRetentionOrderDeliveryExchange.program = (string)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_PROGRAM"]; }else{_oMobileRetentionOrderDeliveryExchange.program=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_NORMAL_REBATE_TYPE"])) {_oMobileRetentionOrderDeliveryExchange.normal_rebate_type = (string)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_NORMAL_REBATE_TYPE"]; }else{_oMobileRetentionOrderDeliveryExchange.normal_rebate_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_DDATE"])) {_oMobileRetentionOrderDeliveryExchange.ddate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_DDATE"]; }else{_oMobileRetentionOrderDeliveryExchange.ddate=null;}
                        _oMobileRetentionOrderDeliveryExchange.SetDB(x_oDB);
                        _oMobileRetentionOrderDeliveryExchange.GetFound();
                        _oRow.Add(_oMobileRetentionOrderDeliveryExchange);
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
        
        
        public static MobileRetentionOrderDeliveryExchangeEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileRetentionOrderDeliveryExchangeEntity> _oMobileRetentionOrderDeliveryExchangeList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileRetentionOrderDeliveryExchangeList==null){ return null;}
            return _oMobileRetentionOrderDeliveryExchangeList.Count == 0 ? null : _oMobileRetentionOrderDeliveryExchangeList.ToArray();
        }
        
        
        public static MobileRetentionOrderDeliveryExchangeEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileRetentionOrderDeliveryExchangeEntity> _oMobileRetentionOrderDeliveryExchangeList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileRetentionOrderDeliveryExchangeList==null){ return null;}
            return _oMobileRetentionOrderDeliveryExchangeList.Count == 0 ? null : _oMobileRetentionOrderDeliveryExchangeList.ToArray();
        }
        
        public static List<MobileRetentionOrderDeliveryExchangeEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<MobileRetentionOrderDeliveryExchangeEntity> _oRow = new List<MobileRetentionOrderDeliveryExchangeEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[MobileRetentionOrderDeliveryExchange].[id] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_ID,[MobileRetentionOrderDeliveryExchange].[cdate] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_CDATE,[MobileRetentionOrderDeliveryExchange].[cid] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_CID,[MobileRetentionOrderDeliveryExchange].[did] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_DID,[MobileRetentionOrderDeliveryExchange].[active] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_ACTIVE,[MobileRetentionOrderDeliveryExchange].[rate_plan] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_RATE_PLAN,[MobileRetentionOrderDeliveryExchange].[program] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_PROGRAM,[MobileRetentionOrderDeliveryExchange].[hs_model] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_HS_MODEL,[MobileRetentionOrderDeliveryExchange].[normal_rebate_type] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_NORMAL_REBATE_TYPE,[MobileRetentionOrderDeliveryExchange].[ddate] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_DDATE,[MobileRetentionOrderDeliveryExchange].[con_per] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_CON_PER";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[MobileRetentionOrderDeliveryExchange]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrderDeliveryExchange]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = MobileRetentionOrderDeliveryExchangeRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                MobileRetentionOrderDeliveryExchangeEntity _oMobileRetentionOrderDeliveryExchange = MobileRetentionOrderDeliveryExchangeRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_RATE_PLAN"])) {_oMobileRetentionOrderDeliveryExchange.rate_plan = (string)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_RATE_PLAN"]; } else {_oMobileRetentionOrderDeliveryExchange.rate_plan=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_CDATE"])) {_oMobileRetentionOrderDeliveryExchange.cdate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_CDATE"]; } else {_oMobileRetentionOrderDeliveryExchange.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_CID"])) {_oMobileRetentionOrderDeliveryExchange.cid = (string)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_CID"]; } else {_oMobileRetentionOrderDeliveryExchange.cid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_DID"])) {_oMobileRetentionOrderDeliveryExchange.did = (string)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_DID"]; } else {_oMobileRetentionOrderDeliveryExchange.did=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_CON_PER"])) {_oMobileRetentionOrderDeliveryExchange.con_per = (string)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_CON_PER"]; } else {_oMobileRetentionOrderDeliveryExchange.con_per=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_ID"])) {_oMobileRetentionOrderDeliveryExchange.id = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_ID"]; } else {_oMobileRetentionOrderDeliveryExchange.id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_ACTIVE"])) {_oMobileRetentionOrderDeliveryExchange.active = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_ACTIVE"]; } else {_oMobileRetentionOrderDeliveryExchange.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_HS_MODEL"])) {_oMobileRetentionOrderDeliveryExchange.hs_model = (string)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_HS_MODEL"]; } else {_oMobileRetentionOrderDeliveryExchange.hs_model=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_PROGRAM"])) {_oMobileRetentionOrderDeliveryExchange.program = (string)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_PROGRAM"]; } else {_oMobileRetentionOrderDeliveryExchange.program=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_NORMAL_REBATE_TYPE"])) {_oMobileRetentionOrderDeliveryExchange.normal_rebate_type = (string)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_NORMAL_REBATE_TYPE"]; } else {_oMobileRetentionOrderDeliveryExchange.normal_rebate_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_DDATE"])) {_oMobileRetentionOrderDeliveryExchange.ddate = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_DDATE"]; } else {_oMobileRetentionOrderDeliveryExchange.ddate=null; }
                _oMobileRetentionOrderDeliveryExchange.SetDB(x_oDB);
                _oMobileRetentionOrderDeliveryExchange.GetFound();
                _oRow.Add(_oMobileRetentionOrderDeliveryExchange);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( MobileRetentionOrderDeliveryExchange.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,MobileRetentionOrderDeliveryExchange.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(MobileRetentionOrderDeliveryExchange.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(MobileRetentionOrderDeliveryExchange.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [MobileRetentionOrderDeliveryExchange].[id] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_ID,[MobileRetentionOrderDeliveryExchange].[cdate] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_CDATE,[MobileRetentionOrderDeliveryExchange].[cid] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_CID,[MobileRetentionOrderDeliveryExchange].[did] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_DID,[MobileRetentionOrderDeliveryExchange].[active] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_ACTIVE,[MobileRetentionOrderDeliveryExchange].[rate_plan] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_RATE_PLAN,[MobileRetentionOrderDeliveryExchange].[program] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_PROGRAM,[MobileRetentionOrderDeliveryExchange].[hs_model] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_HS_MODEL,[MobileRetentionOrderDeliveryExchange].[normal_rebate_type] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_NORMAL_REBATE_TYPE,[MobileRetentionOrderDeliveryExchange].[ddate] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_DDATE,[MobileRetentionOrderDeliveryExchange].[con_per] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_CON_PER  FROM  [MobileRetentionOrderDeliveryExchange]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[MobileRetentionOrderDeliveryExchange]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrderDeliveryExchange]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"MobileRetentionOrderDeliveryExchange");
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
        
        public bool Insert(string x_sRate_plan,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sCon_per,global::System.Nullable<bool> x_bActive,string x_sHs_model,string x_sProgram,string x_sNormal_rebate_type,global::System.Nullable<DateTime> x_dDdate)
        {
            MobileRetentionOrderDeliveryExchange _oMobileRetentionOrderDeliveryExchange=MobileRetentionOrderDeliveryExchangeRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oMobileRetentionOrderDeliveryExchange.rate_plan=x_sRate_plan;
            _oMobileRetentionOrderDeliveryExchange.cdate=x_dCdate;
            _oMobileRetentionOrderDeliveryExchange.cid=x_sCid;
            _oMobileRetentionOrderDeliveryExchange.did=x_sDid;
            _oMobileRetentionOrderDeliveryExchange.con_per=x_sCon_per;
            _oMobileRetentionOrderDeliveryExchange.active=x_bActive;
            _oMobileRetentionOrderDeliveryExchange.hs_model=x_sHs_model;
            _oMobileRetentionOrderDeliveryExchange.program=x_sProgram;
            _oMobileRetentionOrderDeliveryExchange.normal_rebate_type=x_sNormal_rebate_type;
            _oMobileRetentionOrderDeliveryExchange.ddate=x_dDdate;
            return InsertWithOutLastID(n_oDB, _oMobileRetentionOrderDeliveryExchange);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sRate_plan,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sCon_per,global::System.Nullable<bool> x_bActive,string x_sHs_model,string x_sProgram,string x_sNormal_rebate_type,global::System.Nullable<DateTime> x_dDdate)
        {
            MobileRetentionOrderDeliveryExchange _oMobileRetentionOrderDeliveryExchange=MobileRetentionOrderDeliveryExchangeRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileRetentionOrderDeliveryExchange.rate_plan=x_sRate_plan;
            _oMobileRetentionOrderDeliveryExchange.cdate=x_dCdate;
            _oMobileRetentionOrderDeliveryExchange.cid=x_sCid;
            _oMobileRetentionOrderDeliveryExchange.did=x_sDid;
            _oMobileRetentionOrderDeliveryExchange.con_per=x_sCon_per;
            _oMobileRetentionOrderDeliveryExchange.active=x_bActive;
            _oMobileRetentionOrderDeliveryExchange.hs_model=x_sHs_model;
            _oMobileRetentionOrderDeliveryExchange.program=x_sProgram;
            _oMobileRetentionOrderDeliveryExchange.normal_rebate_type=x_sNormal_rebate_type;
            _oMobileRetentionOrderDeliveryExchange.ddate=x_dDdate;
            return InsertWithOutLastID(x_oDB, _oMobileRetentionOrderDeliveryExchange);
        }
        
        
        public bool Insert(MobileRetentionOrderDeliveryExchange x_oMobileRetentionOrderDeliveryExchange)
        {
            return InsertWithOutLastID(n_oDB, x_oMobileRetentionOrderDeliveryExchange);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is MobileRetentionOrderDeliveryExchange)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (MobileRetentionOrderDeliveryExchange)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,MobileRetentionOrderDeliveryExchange x_oMobileRetentionOrderDeliveryExchange)
        {
            return InsertWithOutLastID(x_oDB, x_oMobileRetentionOrderDeliveryExchange);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileRetentionOrderDeliveryExchange x_oMobileRetentionOrderDeliveryExchange)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileRetentionOrderDeliveryExchange]   ([cdate],[cid],[did],[active],[rate_plan],[program],[hs_model],[normal_rebate_type],[ddate],[con_per])  VALUES  (@cdate,@cid,@did,@active,@rate_plan,@program,@hs_model,@normal_rebate_type,@ddate,@con_per)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionOrderDeliveryExchange]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrderDeliveryExchange]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oMobileRetentionOrderDeliveryExchange);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileRetentionOrderDeliveryExchange x_oMobileRetentionOrderDeliveryExchange)
        {
            bool _bResult = false;
            if (!x_oMobileRetentionOrderDeliveryExchange.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileRetentionOrderDeliveryExchange.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrderDeliveryExchange.cdate; }
                if(x_oMobileRetentionOrderDeliveryExchange.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrderDeliveryExchange.cid; }
                if(x_oMobileRetentionOrderDeliveryExchange.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrderDeliveryExchange.did; }
                if(x_oMobileRetentionOrderDeliveryExchange.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionOrderDeliveryExchange.active; }
                if(x_oMobileRetentionOrderDeliveryExchange.rate_plan==null){  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrderDeliveryExchange.rate_plan; }
                if(x_oMobileRetentionOrderDeliveryExchange.program==null){  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrderDeliveryExchange.program; }
                if(x_oMobileRetentionOrderDeliveryExchange.hs_model==null){  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrderDeliveryExchange.hs_model; }
                if(x_oMobileRetentionOrderDeliveryExchange.normal_rebate_type==null){  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrderDeliveryExchange.normal_rebate_type; }
                if(x_oMobileRetentionOrderDeliveryExchange.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrderDeliveryExchange.ddate; }
                if(x_oMobileRetentionOrderDeliveryExchange.con_per==null){  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrderDeliveryExchange.con_per; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,string x_sRate_plan,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sCon_per,global::System.Nullable<bool> x_bActive,string x_sHs_model,string x_sProgram,string x_sNormal_rebate_type,global::System.Nullable<DateTime> x_dDdate)
        {
            int _oLastID;
            MobileRetentionOrderDeliveryExchange _oMobileRetentionOrderDeliveryExchange=MobileRetentionOrderDeliveryExchangeRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileRetentionOrderDeliveryExchange.rate_plan=x_sRate_plan;
            _oMobileRetentionOrderDeliveryExchange.cdate=x_dCdate;
            _oMobileRetentionOrderDeliveryExchange.cid=x_sCid;
            _oMobileRetentionOrderDeliveryExchange.did=x_sDid;
            _oMobileRetentionOrderDeliveryExchange.con_per=x_sCon_per;
            _oMobileRetentionOrderDeliveryExchange.active=x_bActive;
            _oMobileRetentionOrderDeliveryExchange.hs_model=x_sHs_model;
            _oMobileRetentionOrderDeliveryExchange.program=x_sProgram;
            _oMobileRetentionOrderDeliveryExchange.normal_rebate_type=x_sNormal_rebate_type;
            _oMobileRetentionOrderDeliveryExchange.ddate=x_dDdate;
            if(InsertWithLastID(x_oDB, _oMobileRetentionOrderDeliveryExchange,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(MobileRetentionOrderDeliveryExchange x_oMobileRetentionOrderDeliveryExchange)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oMobileRetentionOrderDeliveryExchange, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, MobileRetentionOrderDeliveryExchange x_oMobileRetentionOrderDeliveryExchange)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oMobileRetentionOrderDeliveryExchange, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileRetentionOrderDeliveryExchange)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (MobileRetentionOrderDeliveryExchange)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,MobileRetentionOrderDeliveryExchange x_oMobileRetentionOrderDeliveryExchange, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileRetentionOrderDeliveryExchange]   ([cdate],[cid],[did],[active],[rate_plan],[program],[hs_model],[normal_rebate_type],[ddate],[con_per])  VALUES  (@cdate,@cid,@did,@active,@rate_plan,@program,@hs_model,@normal_rebate_type,@ddate,@con_per)"+" SELECT  @@IDENTITY AS MobileRetentionOrderDeliveryExchange_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionOrderDeliveryExchange]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrderDeliveryExchange]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oMobileRetentionOrderDeliveryExchange,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileRetentionOrderDeliveryExchange x_oMobileRetentionOrderDeliveryExchange, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oMobileRetentionOrderDeliveryExchange.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileRetentionOrderDeliveryExchange.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrderDeliveryExchange.cdate; }
                if(x_oMobileRetentionOrderDeliveryExchange.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrderDeliveryExchange.cid; }
                if(x_oMobileRetentionOrderDeliveryExchange.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrderDeliveryExchange.did; }
                if(x_oMobileRetentionOrderDeliveryExchange.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileRetentionOrderDeliveryExchange.active; }
                if(x_oMobileRetentionOrderDeliveryExchange.rate_plan==null){  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrderDeliveryExchange.rate_plan; }
                if(x_oMobileRetentionOrderDeliveryExchange.program==null){  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrderDeliveryExchange.program; }
                if(x_oMobileRetentionOrderDeliveryExchange.hs_model==null){  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileRetentionOrderDeliveryExchange.hs_model; }
                if(x_oMobileRetentionOrderDeliveryExchange.normal_rebate_type==null){  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrderDeliveryExchange.normal_rebate_type; }
                if(x_oMobileRetentionOrderDeliveryExchange.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileRetentionOrderDeliveryExchange.ddate; }
                if(x_oMobileRetentionOrderDeliveryExchange.con_per==null){  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileRetentionOrderDeliveryExchange.con_per; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["MobileRetentionOrderDeliveryExchange_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["MobileRetentionOrderDeliveryExchange_LASTID"].ToString()) && int.TryParse(_oData["MobileRetentionOrderDeliveryExchange_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sRate_plan,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sCon_per,global::System.Nullable<bool> x_bActive,string x_sHs_model,string x_sProgram,string x_sNormal_rebate_type,global::System.Nullable<DateTime> x_dDdate)
        {
            int _oLastID;
            MobileRetentionOrderDeliveryExchange _oMobileRetentionOrderDeliveryExchange=MobileRetentionOrderDeliveryExchangeRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileRetentionOrderDeliveryExchange.rate_plan=x_sRate_plan;
            _oMobileRetentionOrderDeliveryExchange.cdate=x_dCdate;
            _oMobileRetentionOrderDeliveryExchange.cid=x_sCid;
            _oMobileRetentionOrderDeliveryExchange.did=x_sDid;
            _oMobileRetentionOrderDeliveryExchange.con_per=x_sCon_per;
            _oMobileRetentionOrderDeliveryExchange.active=x_bActive;
            _oMobileRetentionOrderDeliveryExchange.hs_model=x_sHs_model;
            _oMobileRetentionOrderDeliveryExchange.program=x_sProgram;
            _oMobileRetentionOrderDeliveryExchange.normal_rebate_type=x_sNormal_rebate_type;
            _oMobileRetentionOrderDeliveryExchange.ddate=x_dDdate;
            if(InsertWithLastID_SP(x_oDB, _oMobileRetentionOrderDeliveryExchange,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(MobileRetentionOrderDeliveryExchange x_oMobileRetentionOrderDeliveryExchange)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oMobileRetentionOrderDeliveryExchange, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileRetentionOrderDeliveryExchange x_oMobileRetentionOrderDeliveryExchange)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oMobileRetentionOrderDeliveryExchange, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileRetentionOrderDeliveryExchange)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (MobileRetentionOrderDeliveryExchange)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,MobileRetentionOrderDeliveryExchange x_oMobileRetentionOrderDeliveryExchange, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "MOBILERETENTIONORDERDELIVERYEXCHANGE";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oMobileRetentionOrderDeliveryExchange,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileRetentionOrderDeliveryExchange x_oMobileRetentionOrderDeliveryExchange, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrderDeliveryExchange.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionOrderDeliveryExchange.cdate; }
                _oPar=x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrderDeliveryExchange.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrderDeliveryExchange.cid; }
                _oPar=x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrderDeliveryExchange.did==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrderDeliveryExchange.did; }
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrderDeliveryExchange.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrderDeliveryExchange.active; }
                _oPar=x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrderDeliveryExchange.rate_plan==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrderDeliveryExchange.rate_plan; }
                _oPar=x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrderDeliveryExchange.program==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrderDeliveryExchange.program; }
                _oPar=x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrderDeliveryExchange.hs_model==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrderDeliveryExchange.hs_model; }
                _oPar=x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrderDeliveryExchange.normal_rebate_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrderDeliveryExchange.normal_rebate_type; }
                _oPar=x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrderDeliveryExchange.ddate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileRetentionOrderDeliveryExchange.ddate; }
                _oPar=x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileRetentionOrderDeliveryExchange.con_per==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileRetentionOrderDeliveryExchange.con_per; }
                _oPar=x_oCmd.Parameters.Add("@RETURN_ID", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Output;
                x_oCmd.CommandType = CommandType.StoredProcedure;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                _bResult = Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
                x_oLAST_ID = Int32.Parse(x_oCmd.Parameters["@RETURN_ID"].Value.ToString());
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
        
        #region INSERT_MOBILERETENTIONORDERDELIVERYEXCHANGE Store Procedures
        ///-- =============================================
        ///-- Author:		<Author,Philip SW>
        ///-- Create date: <Create Date 2011-02-16>
        ///-- Description:	<Description,MOBILERETENTIONORDERDELIVERYEXCHANGE, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_MOBILERETENTIONORDERDELIVERYEXCHANGE Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_MOBILERETENTIONORDERDELIVERYEXCHANGE', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_MOBILERETENTIONORDERDELIVERYEXCHANGE;
        GO
        CREATE PROCEDURE INSERT_MOBILERETENTIONORDERDELIVERYEXCHANGE
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @rate_plan nvarchar(50),
        @cdate datetime,
        @cid nvarchar(50),
        @did nvarchar(50),
        @con_per nvarchar(50),
        @active bit,
        @hs_model nvarchar(250),
        @program nvarchar(50),
        @normal_rebate_type nvarchar(50),
        @ddate datetime
        AS
        
        INSERT INTO  [MobileRetentionOrderDeliveryExchange]   ([cdate],[cid],[did],[active],[rate_plan],[program],[hs_model],[normal_rebate_type],[ddate],[con_per])  VALUES  (@cdate,@cid,@did,@active,@rate_plan,@program,@hs_model,@normal_rebate_type,@ddate,@con_per)
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
        
        public bool Delete(global::System.Nullable<int> x_iId)
        {
            return DeleteProc(n_oDB, x_iId);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return DeleteProc(x_oDB, x_iId);
        }
        
        
        private static bool DeleteProc(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            if (x_iId==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileRetentionOrderDeliveryExchange]  WHERE [MobileRetentionOrderDeliveryExchange].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionOrderDeliveryExchange]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrderDeliveryExchange]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult=false;
                _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = x_iId;
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
            return MobileRetentionOrderDeliveryExchangeRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileRetentionOrderDeliveryExchange]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionOrderDeliveryExchange]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrderDeliveryExchange]"); }
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
            string _sQuery = "DELETE FROM [MobileRetentionOrderDeliveryExchange]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionOrderDeliveryExchange]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrderDeliveryExchange]"); }
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


