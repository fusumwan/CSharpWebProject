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
///-- Create date: <Create Date 2011-07-14>
///-- Description:	<Description,Table :[BusinessActionDefaultSet],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [BusinessActionDefaultSet] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"BusinessActionDefaultSet")]
    public class BusinessActionDefaultSetRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static BusinessActionDefaultSetRepositoryBase instance;
        public static BusinessActionDefaultSetRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new BusinessActionDefaultSetRepositoryBase(_oDB);
            }
            return instance;
        }
        public static BusinessActionDefaultSetRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new BusinessActionDefaultSetRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<BusinessActionDefaultSetEntity> BusinessActionDefaultSets;
        #endregion
        
        #region Constructor
        public BusinessActionDefaultSetRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~BusinessActionDefaultSetRepositoryBase() { 
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
        public static BusinessActionDefaultSet CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new BusinessActionDefaultSet(_oDB);
        }
        
        public static BusinessActionDefaultSet CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new BusinessActionDefaultSet(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [BusinessActionDefaultSet]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessActionDefaultSet]","["+ Configurator.MSSQLTablePrefix + "BusinessActionDefaultSet]"); }
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
        
        
        public BusinessActionDefaultSetEntity GetObj(global::System.Nullable<int> x_iMid)
        {
            return GetObj(n_oDB, x_iMid);
        }
        
        
        public static BusinessActionDefaultSetEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            if (x_oDB==null) { return null; }
            BusinessActionDefaultSet _BusinessActionDefaultSet = (BusinessActionDefaultSet)BusinessActionDefaultSetRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_BusinessActionDefaultSet.Load(x_iMid)) { return null; }
            return _BusinessActionDefaultSet;
        }
        
        
        
        public static BusinessActionDefaultSetEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<BusinessActionDefaultSetEntity> _oBusinessActionDefaultSetList = GetListObj(x_oDB,0, "mid", x_oArrayItemId);
            if(_oBusinessActionDefaultSetList==null){ return null;}
            return _oBusinessActionDefaultSetList.Count == 0 ? null : _oBusinessActionDefaultSetList.ToArray();
        }
        
        public static List<BusinessActionDefaultSetEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "mid", x_oArrayItemId);
        }
        
        
        public static BusinessActionDefaultSetEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<BusinessActionDefaultSetEntity> _oBusinessActionDefaultSetList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oBusinessActionDefaultSetList==null){ return null;}
            return _oBusinessActionDefaultSetList.Count == 0 ? null : _oBusinessActionDefaultSetList.ToArray();
        }
        
        
        public static BusinessActionDefaultSetEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<BusinessActionDefaultSetEntity> _oBusinessActionDefaultSetList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oBusinessActionDefaultSetList==null){ return null;}
            return _oBusinessActionDefaultSetList.Count == 0 ? null : _oBusinessActionDefaultSetList.ToArray();
        }
        
        public static List<BusinessActionDefaultSetEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<BusinessActionDefaultSetEntity> _oRow = new List<BusinessActionDefaultSetEntity>();
            string _sQuery = "SELECT  "+_sTop+" [BusinessActionDefaultSet].[lob] AS BUSINESSACTIONDEFAULTSET_LOB,[BusinessActionDefaultSet].[display2] AS BUSINESSACTIONDEFAULTSET_DISPLAY2,[BusinessActionDefaultSet].[mid] AS BUSINESSACTIONDEFAULTSET_MID,[BusinessActionDefaultSet].[display1] AS BUSINESSACTIONDEFAULTSET_DISPLAY1,[BusinessActionDefaultSet].[cdate] AS BUSINESSACTIONDEFAULTSET_CDATE,[BusinessActionDefaultSet].[bundle_name] AS BUSINESSACTIONDEFAULTSET_BUNDLE_NAME,[BusinessActionDefaultSet].[trade_field] AS BUSINESSACTIONDEFAULTSET_TRADE_FIELD,[BusinessActionDefaultSet].[s_premium] AS BUSINESSACTIONDEFAULTSET_S_PREMIUM,[BusinessActionDefaultSet].[program] AS BUSINESSACTIONDEFAULTSET_PROGRAM,[BusinessActionDefaultSet].[edate] AS BUSINESSACTIONDEFAULTSET_EDATE,[BusinessActionDefaultSet].[rebate] AS BUSINESSACTIONDEFAULTSET_REBATE,[BusinessActionDefaultSet].[active] AS BUSINESSACTIONDEFAULTSET_ACTIVE,[BusinessActionDefaultSet].[business_action_value_2] AS BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_VALUE_2,[BusinessActionDefaultSet].[con_per] AS BUSINESSACTIONDEFAULTSET_CON_PER,[BusinessActionDefaultSet].[normal_rebate_type] AS BUSINESSACTIONDEFAULTSET_NORMAL_REBATE_TYPE,[BusinessActionDefaultSet].[premium] AS BUSINESSACTIONDEFAULTSET_PREMIUM,[BusinessActionDefaultSet].[free_mon] AS BUSINESSACTIONDEFAULTSET_FREE_MON,[BusinessActionDefaultSet].[enabled2] AS BUSINESSACTIONDEFAULTSET_ENABLED2,[BusinessActionDefaultSet].[cid] AS BUSINESSACTIONDEFAULTSET_CID,[BusinessActionDefaultSet].[business_action_2] AS BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_2,[BusinessActionDefaultSet].[business_action_1] AS BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_1,[BusinessActionDefaultSet].[rate_plan] AS BUSINESSACTIONDEFAULTSET_RATE_PLAN,[BusinessActionDefaultSet].[business_action_value_1] AS BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_VALUE_1,[BusinessActionDefaultSet].[enabled1] AS BUSINESSACTIONDEFAULTSET_ENABLED1,[BusinessActionDefaultSet].[hs_model] AS BUSINESSACTIONDEFAULTSET_HS_MODEL,[BusinessActionDefaultSet].[s_premium2] AS BUSINESSACTIONDEFAULTSET_S_PREMIUM2,[BusinessActionDefaultSet].[issue_type] AS BUSINESSACTIONDEFAULTSET_ISSUE_TYPE  FROM  [BusinessActionDefaultSet]";
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
                _sQuery += " WHERE [BusinessActionDefaultSet].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessActionDefaultSet]","["+ Configurator.MSSQLTablePrefix + "BusinessActionDefaultSet]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        BusinessActionDefaultSet _oBusinessActionDefaultSet = BusinessActionDefaultSetRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_LOB"])) {_oBusinessActionDefaultSet.lob = (string)_oData["BUSINESSACTIONDEFAULTSET_LOB"]; }else{_oBusinessActionDefaultSet.lob=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_S_PREMIUM2"])) {_oBusinessActionDefaultSet.s_premium2 = (string)_oData["BUSINESSACTIONDEFAULTSET_S_PREMIUM2"]; }else{_oBusinessActionDefaultSet.s_premium2=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_DISPLAY2"])) {_oBusinessActionDefaultSet.display2 = (global::System.Nullable<bool>)_oData["BUSINESSACTIONDEFAULTSET_DISPLAY2"]; }else{_oBusinessActionDefaultSet.display2=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_MID"])) {_oBusinessActionDefaultSet.mid = (global::System.Nullable<int>)_oData["BUSINESSACTIONDEFAULTSET_MID"]; }else{_oBusinessActionDefaultSet.mid=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_DISPLAY1"])) {_oBusinessActionDefaultSet.display1 = (global::System.Nullable<bool>)_oData["BUSINESSACTIONDEFAULTSET_DISPLAY1"]; }else{_oBusinessActionDefaultSet.display1=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_CDATE"])) {_oBusinessActionDefaultSet.cdate = (global::System.Nullable<DateTime>)_oData["BUSINESSACTIONDEFAULTSET_CDATE"]; }else{_oBusinessActionDefaultSet.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_BUNDLE_NAME"])) {_oBusinessActionDefaultSet.bundle_name = (string)_oData["BUSINESSACTIONDEFAULTSET_BUNDLE_NAME"]; }else{_oBusinessActionDefaultSet.bundle_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_VALUE_1"])) {_oBusinessActionDefaultSet.business_action_value_1 = (string)_oData["BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_VALUE_1"]; }else{_oBusinessActionDefaultSet.business_action_value_1=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_TRADE_FIELD"])) {_oBusinessActionDefaultSet.trade_field = (string)_oData["BUSINESSACTIONDEFAULTSET_TRADE_FIELD"]; }else{_oBusinessActionDefaultSet.trade_field=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_S_PREMIUM"])) {_oBusinessActionDefaultSet.s_premium = (string)_oData["BUSINESSACTIONDEFAULTSET_S_PREMIUM"]; }else{_oBusinessActionDefaultSet.s_premium=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_PROGRAM"])) {_oBusinessActionDefaultSet.program = (string)_oData["BUSINESSACTIONDEFAULTSET_PROGRAM"]; }else{_oBusinessActionDefaultSet.program=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_EDATE"])) {_oBusinessActionDefaultSet.edate = (global::System.Nullable<DateTime>)_oData["BUSINESSACTIONDEFAULTSET_EDATE"]; }else{_oBusinessActionDefaultSet.edate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_REBATE"])) {_oBusinessActionDefaultSet.rebate = (string)_oData["BUSINESSACTIONDEFAULTSET_REBATE"]; }else{_oBusinessActionDefaultSet.rebate=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_CON_PER"])) {_oBusinessActionDefaultSet.con_per = (string)_oData["BUSINESSACTIONDEFAULTSET_CON_PER"]; }else{_oBusinessActionDefaultSet.con_per=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_NORMAL_REBATE_TYPE"])) {_oBusinessActionDefaultSet.normal_rebate_type = (string)_oData["BUSINESSACTIONDEFAULTSET_NORMAL_REBATE_TYPE"]; }else{_oBusinessActionDefaultSet.normal_rebate_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_PREMIUM"])) {_oBusinessActionDefaultSet.premium = (string)_oData["BUSINESSACTIONDEFAULTSET_PREMIUM"]; }else{_oBusinessActionDefaultSet.premium=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_VALUE_2"])) {_oBusinessActionDefaultSet.business_action_value_2 = (string)_oData["BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_VALUE_2"]; }else{_oBusinessActionDefaultSet.business_action_value_2=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_ENABLED2"])) {_oBusinessActionDefaultSet.enabled2 = (global::System.Nullable<bool>)_oData["BUSINESSACTIONDEFAULTSET_ENABLED2"]; }else{_oBusinessActionDefaultSet.enabled2=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_CID"])) {_oBusinessActionDefaultSet.cid = (string)_oData["BUSINESSACTIONDEFAULTSET_CID"]; }else{_oBusinessActionDefaultSet.cid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_2"])) {_oBusinessActionDefaultSet.business_action_2 = (string)_oData["BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_2"]; }else{_oBusinessActionDefaultSet.business_action_2=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_1"])) {_oBusinessActionDefaultSet.business_action_1 = (string)_oData["BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_1"]; }else{_oBusinessActionDefaultSet.business_action_1=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_RATE_PLAN"])) {_oBusinessActionDefaultSet.rate_plan = (string)_oData["BUSINESSACTIONDEFAULTSET_RATE_PLAN"]; }else{_oBusinessActionDefaultSet.rate_plan=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_FREE_MON"])) {_oBusinessActionDefaultSet.free_mon = (string)_oData["BUSINESSACTIONDEFAULTSET_FREE_MON"]; }else{_oBusinessActionDefaultSet.free_mon=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_ENABLED1"])) {_oBusinessActionDefaultSet.enabled1 = (global::System.Nullable<bool>)_oData["BUSINESSACTIONDEFAULTSET_ENABLED1"]; }else{_oBusinessActionDefaultSet.enabled1=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_HS_MODEL"])) {_oBusinessActionDefaultSet.hs_model = (string)_oData["BUSINESSACTIONDEFAULTSET_HS_MODEL"]; }else{_oBusinessActionDefaultSet.hs_model=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_ACTIVE"])) {_oBusinessActionDefaultSet.active = (global::System.Nullable<bool>)_oData["BUSINESSACTIONDEFAULTSET_ACTIVE"]; }else{_oBusinessActionDefaultSet.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_ISSUE_TYPE"])) {_oBusinessActionDefaultSet.issue_type = (string)_oData["BUSINESSACTIONDEFAULTSET_ISSUE_TYPE"]; }else{_oBusinessActionDefaultSet.issue_type=global::System.String.Empty;}
                        _oBusinessActionDefaultSet.SetDB(x_oDB);
                        _oBusinessActionDefaultSet.GetFound();
                        _oRow.Add(_oBusinessActionDefaultSet);
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
        
        
        public static BusinessActionDefaultSetEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<BusinessActionDefaultSetEntity> _oBusinessActionDefaultSetList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oBusinessActionDefaultSetList==null){ return null;}
            return _oBusinessActionDefaultSetList.Count == 0 ? null : _oBusinessActionDefaultSetList.ToArray();
        }
        
        
        public static BusinessActionDefaultSetEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<BusinessActionDefaultSetEntity> _oBusinessActionDefaultSetList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oBusinessActionDefaultSetList==null){ return null;}
            return _oBusinessActionDefaultSetList.Count == 0 ? null : _oBusinessActionDefaultSetList.ToArray();
        }
        
        public static List<BusinessActionDefaultSetEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<BusinessActionDefaultSetEntity> _oRow = new List<BusinessActionDefaultSetEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[BusinessActionDefaultSet].[lob] AS BUSINESSACTIONDEFAULTSET_LOB,[BusinessActionDefaultSet].[display2] AS BUSINESSACTIONDEFAULTSET_DISPLAY2,[BusinessActionDefaultSet].[mid] AS BUSINESSACTIONDEFAULTSET_MID,[BusinessActionDefaultSet].[display1] AS BUSINESSACTIONDEFAULTSET_DISPLAY1,[BusinessActionDefaultSet].[cdate] AS BUSINESSACTIONDEFAULTSET_CDATE,[BusinessActionDefaultSet].[bundle_name] AS BUSINESSACTIONDEFAULTSET_BUNDLE_NAME,[BusinessActionDefaultSet].[trade_field] AS BUSINESSACTIONDEFAULTSET_TRADE_FIELD,[BusinessActionDefaultSet].[s_premium] AS BUSINESSACTIONDEFAULTSET_S_PREMIUM,[BusinessActionDefaultSet].[program] AS BUSINESSACTIONDEFAULTSET_PROGRAM,[BusinessActionDefaultSet].[edate] AS BUSINESSACTIONDEFAULTSET_EDATE,[BusinessActionDefaultSet].[rebate] AS BUSINESSACTIONDEFAULTSET_REBATE,[BusinessActionDefaultSet].[active] AS BUSINESSACTIONDEFAULTSET_ACTIVE,[BusinessActionDefaultSet].[business_action_value_2] AS BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_VALUE_2,[BusinessActionDefaultSet].[con_per] AS BUSINESSACTIONDEFAULTSET_CON_PER,[BusinessActionDefaultSet].[normal_rebate_type] AS BUSINESSACTIONDEFAULTSET_NORMAL_REBATE_TYPE,[BusinessActionDefaultSet].[premium] AS BUSINESSACTIONDEFAULTSET_PREMIUM,[BusinessActionDefaultSet].[free_mon] AS BUSINESSACTIONDEFAULTSET_FREE_MON,[BusinessActionDefaultSet].[enabled2] AS BUSINESSACTIONDEFAULTSET_ENABLED2,[BusinessActionDefaultSet].[cid] AS BUSINESSACTIONDEFAULTSET_CID,[BusinessActionDefaultSet].[business_action_2] AS BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_2,[BusinessActionDefaultSet].[business_action_1] AS BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_1,[BusinessActionDefaultSet].[rate_plan] AS BUSINESSACTIONDEFAULTSET_RATE_PLAN,[BusinessActionDefaultSet].[business_action_value_1] AS BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_VALUE_1,[BusinessActionDefaultSet].[enabled1] AS BUSINESSACTIONDEFAULTSET_ENABLED1,[BusinessActionDefaultSet].[hs_model] AS BUSINESSACTIONDEFAULTSET_HS_MODEL,[BusinessActionDefaultSet].[s_premium2] AS BUSINESSACTIONDEFAULTSET_S_PREMIUM2,[BusinessActionDefaultSet].[issue_type] AS BUSINESSACTIONDEFAULTSET_ISSUE_TYPE";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[BusinessActionDefaultSet]","["+ Configurator.MSSQLTablePrefix + "BusinessActionDefaultSet]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = BusinessActionDefaultSetRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                BusinessActionDefaultSetEntity _oBusinessActionDefaultSet = BusinessActionDefaultSetRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_LOB"])) {_oBusinessActionDefaultSet.lob = (string)_oData["BUSINESSACTIONDEFAULTSET_LOB"]; } else {_oBusinessActionDefaultSet.lob=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_S_PREMIUM2"])) {_oBusinessActionDefaultSet.s_premium2 = (string)_oData["BUSINESSACTIONDEFAULTSET_S_PREMIUM2"]; } else {_oBusinessActionDefaultSet.s_premium2=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_DISPLAY2"])) {_oBusinessActionDefaultSet.display2 = (global::System.Nullable<bool>)_oData["BUSINESSACTIONDEFAULTSET_DISPLAY2"]; } else {_oBusinessActionDefaultSet.display2=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_MID"])) {_oBusinessActionDefaultSet.mid = (global::System.Nullable<int>)_oData["BUSINESSACTIONDEFAULTSET_MID"]; } else {_oBusinessActionDefaultSet.mid=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_DISPLAY1"])) {_oBusinessActionDefaultSet.display1 = (global::System.Nullable<bool>)_oData["BUSINESSACTIONDEFAULTSET_DISPLAY1"]; } else {_oBusinessActionDefaultSet.display1=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_CDATE"])) {_oBusinessActionDefaultSet.cdate = (global::System.Nullable<DateTime>)_oData["BUSINESSACTIONDEFAULTSET_CDATE"]; } else {_oBusinessActionDefaultSet.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_BUNDLE_NAME"])) {_oBusinessActionDefaultSet.bundle_name = (string)_oData["BUSINESSACTIONDEFAULTSET_BUNDLE_NAME"]; } else {_oBusinessActionDefaultSet.bundle_name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_VALUE_1"])) {_oBusinessActionDefaultSet.business_action_value_1 = (string)_oData["BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_VALUE_1"]; } else {_oBusinessActionDefaultSet.business_action_value_1=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_TRADE_FIELD"])) {_oBusinessActionDefaultSet.trade_field = (string)_oData["BUSINESSACTIONDEFAULTSET_TRADE_FIELD"]; } else {_oBusinessActionDefaultSet.trade_field=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_S_PREMIUM"])) {_oBusinessActionDefaultSet.s_premium = (string)_oData["BUSINESSACTIONDEFAULTSET_S_PREMIUM"]; } else {_oBusinessActionDefaultSet.s_premium=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_PROGRAM"])) {_oBusinessActionDefaultSet.program = (string)_oData["BUSINESSACTIONDEFAULTSET_PROGRAM"]; } else {_oBusinessActionDefaultSet.program=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_EDATE"])) {_oBusinessActionDefaultSet.edate = (global::System.Nullable<DateTime>)_oData["BUSINESSACTIONDEFAULTSET_EDATE"]; } else {_oBusinessActionDefaultSet.edate=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_REBATE"])) {_oBusinessActionDefaultSet.rebate = (string)_oData["BUSINESSACTIONDEFAULTSET_REBATE"]; } else {_oBusinessActionDefaultSet.rebate=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_CON_PER"])) {_oBusinessActionDefaultSet.con_per = (string)_oData["BUSINESSACTIONDEFAULTSET_CON_PER"]; } else {_oBusinessActionDefaultSet.con_per=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_NORMAL_REBATE_TYPE"])) {_oBusinessActionDefaultSet.normal_rebate_type = (string)_oData["BUSINESSACTIONDEFAULTSET_NORMAL_REBATE_TYPE"]; } else {_oBusinessActionDefaultSet.normal_rebate_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_PREMIUM"])) {_oBusinessActionDefaultSet.premium = (string)_oData["BUSINESSACTIONDEFAULTSET_PREMIUM"]; } else {_oBusinessActionDefaultSet.premium=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_VALUE_2"])) {_oBusinessActionDefaultSet.business_action_value_2 = (string)_oData["BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_VALUE_2"]; } else {_oBusinessActionDefaultSet.business_action_value_2=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_ENABLED2"])) {_oBusinessActionDefaultSet.enabled2 = (global::System.Nullable<bool>)_oData["BUSINESSACTIONDEFAULTSET_ENABLED2"]; } else {_oBusinessActionDefaultSet.enabled2=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_CID"])) {_oBusinessActionDefaultSet.cid = (string)_oData["BUSINESSACTIONDEFAULTSET_CID"]; } else {_oBusinessActionDefaultSet.cid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_2"])) {_oBusinessActionDefaultSet.business_action_2 = (string)_oData["BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_2"]; } else {_oBusinessActionDefaultSet.business_action_2=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_1"])) {_oBusinessActionDefaultSet.business_action_1 = (string)_oData["BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_1"]; } else {_oBusinessActionDefaultSet.business_action_1=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_RATE_PLAN"])) {_oBusinessActionDefaultSet.rate_plan = (string)_oData["BUSINESSACTIONDEFAULTSET_RATE_PLAN"]; } else {_oBusinessActionDefaultSet.rate_plan=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_FREE_MON"])) {_oBusinessActionDefaultSet.free_mon = (string)_oData["BUSINESSACTIONDEFAULTSET_FREE_MON"]; } else {_oBusinessActionDefaultSet.free_mon=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_ENABLED1"])) {_oBusinessActionDefaultSet.enabled1 = (global::System.Nullable<bool>)_oData["BUSINESSACTIONDEFAULTSET_ENABLED1"]; } else {_oBusinessActionDefaultSet.enabled1=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_HS_MODEL"])) {_oBusinessActionDefaultSet.hs_model = (string)_oData["BUSINESSACTIONDEFAULTSET_HS_MODEL"]; } else {_oBusinessActionDefaultSet.hs_model=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_ACTIVE"])) {_oBusinessActionDefaultSet.active = (global::System.Nullable<bool>)_oData["BUSINESSACTIONDEFAULTSET_ACTIVE"]; } else {_oBusinessActionDefaultSet.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSACTIONDEFAULTSET_ISSUE_TYPE"])) {_oBusinessActionDefaultSet.issue_type = (string)_oData["BUSINESSACTIONDEFAULTSET_ISSUE_TYPE"]; } else {_oBusinessActionDefaultSet.issue_type=global::System.String.Empty; }
                _oBusinessActionDefaultSet.SetDB(x_oDB);
                _oBusinessActionDefaultSet.GetFound();
                _oRow.Add(_oBusinessActionDefaultSet);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( BusinessActionDefaultSet.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,BusinessActionDefaultSet.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(BusinessActionDefaultSet.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(BusinessActionDefaultSet.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [BusinessActionDefaultSet].[lob] AS BUSINESSACTIONDEFAULTSET_LOB,[BusinessActionDefaultSet].[display2] AS BUSINESSACTIONDEFAULTSET_DISPLAY2,[BusinessActionDefaultSet].[mid] AS BUSINESSACTIONDEFAULTSET_MID,[BusinessActionDefaultSet].[display1] AS BUSINESSACTIONDEFAULTSET_DISPLAY1,[BusinessActionDefaultSet].[cdate] AS BUSINESSACTIONDEFAULTSET_CDATE,[BusinessActionDefaultSet].[bundle_name] AS BUSINESSACTIONDEFAULTSET_BUNDLE_NAME,[BusinessActionDefaultSet].[trade_field] AS BUSINESSACTIONDEFAULTSET_TRADE_FIELD,[BusinessActionDefaultSet].[s_premium] AS BUSINESSACTIONDEFAULTSET_S_PREMIUM,[BusinessActionDefaultSet].[program] AS BUSINESSACTIONDEFAULTSET_PROGRAM,[BusinessActionDefaultSet].[edate] AS BUSINESSACTIONDEFAULTSET_EDATE,[BusinessActionDefaultSet].[rebate] AS BUSINESSACTIONDEFAULTSET_REBATE,[BusinessActionDefaultSet].[active] AS BUSINESSACTIONDEFAULTSET_ACTIVE,[BusinessActionDefaultSet].[business_action_value_2] AS BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_VALUE_2,[BusinessActionDefaultSet].[con_per] AS BUSINESSACTIONDEFAULTSET_CON_PER,[BusinessActionDefaultSet].[normal_rebate_type] AS BUSINESSACTIONDEFAULTSET_NORMAL_REBATE_TYPE,[BusinessActionDefaultSet].[premium] AS BUSINESSACTIONDEFAULTSET_PREMIUM,[BusinessActionDefaultSet].[free_mon] AS BUSINESSACTIONDEFAULTSET_FREE_MON,[BusinessActionDefaultSet].[enabled2] AS BUSINESSACTIONDEFAULTSET_ENABLED2,[BusinessActionDefaultSet].[cid] AS BUSINESSACTIONDEFAULTSET_CID,[BusinessActionDefaultSet].[business_action_2] AS BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_2,[BusinessActionDefaultSet].[business_action_1] AS BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_1,[BusinessActionDefaultSet].[rate_plan] AS BUSINESSACTIONDEFAULTSET_RATE_PLAN,[BusinessActionDefaultSet].[business_action_value_1] AS BUSINESSACTIONDEFAULTSET_BUSINESS_ACTION_VALUE_1,[BusinessActionDefaultSet].[enabled1] AS BUSINESSACTIONDEFAULTSET_ENABLED1,[BusinessActionDefaultSet].[hs_model] AS BUSINESSACTIONDEFAULTSET_HS_MODEL,[BusinessActionDefaultSet].[s_premium2] AS BUSINESSACTIONDEFAULTSET_S_PREMIUM2,[BusinessActionDefaultSet].[issue_type] AS BUSINESSACTIONDEFAULTSET_ISSUE_TYPE  FROM  [BusinessActionDefaultSet]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[BusinessActionDefaultSet]","["+ Configurator.MSSQLTablePrefix + "BusinessActionDefaultSet]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"BusinessActionDefaultSet");
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
        
        public bool Insert(string x_sLob,string x_sS_premium2,global::System.Nullable<bool> x_bDisplay2,global::System.Nullable<bool> x_bDisplay1,global::System.Nullable<DateTime> x_dCdate,string x_sBundle_name,string x_sBusiness_action_value_1,string x_sTrade_field,string x_sS_premium,string x_sProgram,global::System.Nullable<DateTime> x_dEdate,string x_sRebate,string x_sCon_per,string x_sNormal_rebate_type,string x_sPremium,string x_sBusiness_action_value_2,global::System.Nullable<bool> x_bEnabled2,string x_sCid,string x_sBusiness_action_2,string x_sBusiness_action_1,string x_sRate_plan,string x_sFree_mon,global::System.Nullable<bool> x_bEnabled1,string x_sHs_model,global::System.Nullable<bool> x_bActive,string x_sIssue_type)
        {
            BusinessActionDefaultSet _oBusinessActionDefaultSet=BusinessActionDefaultSetRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oBusinessActionDefaultSet.lob=x_sLob;
            _oBusinessActionDefaultSet.s_premium2=x_sS_premium2;
            _oBusinessActionDefaultSet.display2=x_bDisplay2;
            _oBusinessActionDefaultSet.display1=x_bDisplay1;
            _oBusinessActionDefaultSet.cdate=x_dCdate;
            _oBusinessActionDefaultSet.bundle_name=x_sBundle_name;
            _oBusinessActionDefaultSet.business_action_value_1=x_sBusiness_action_value_1;
            _oBusinessActionDefaultSet.trade_field=x_sTrade_field;
            _oBusinessActionDefaultSet.s_premium=x_sS_premium;
            _oBusinessActionDefaultSet.program=x_sProgram;
            _oBusinessActionDefaultSet.edate=x_dEdate;
            _oBusinessActionDefaultSet.rebate=x_sRebate;
            _oBusinessActionDefaultSet.con_per=x_sCon_per;
            _oBusinessActionDefaultSet.normal_rebate_type=x_sNormal_rebate_type;
            _oBusinessActionDefaultSet.premium=x_sPremium;
            _oBusinessActionDefaultSet.business_action_value_2=x_sBusiness_action_value_2;
            _oBusinessActionDefaultSet.enabled2=x_bEnabled2;
            _oBusinessActionDefaultSet.cid=x_sCid;
            _oBusinessActionDefaultSet.business_action_2=x_sBusiness_action_2;
            _oBusinessActionDefaultSet.business_action_1=x_sBusiness_action_1;
            _oBusinessActionDefaultSet.rate_plan=x_sRate_plan;
            _oBusinessActionDefaultSet.free_mon=x_sFree_mon;
            _oBusinessActionDefaultSet.enabled1=x_bEnabled1;
            _oBusinessActionDefaultSet.hs_model=x_sHs_model;
            _oBusinessActionDefaultSet.active=x_bActive;
            _oBusinessActionDefaultSet.issue_type=x_sIssue_type;
            return InsertWithOutLastID(n_oDB, _oBusinessActionDefaultSet);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sLob,string x_sS_premium2,global::System.Nullable<bool> x_bDisplay2,global::System.Nullable<bool> x_bDisplay1,global::System.Nullable<DateTime> x_dCdate,string x_sBundle_name,string x_sBusiness_action_value_1,string x_sTrade_field,string x_sS_premium,string x_sProgram,global::System.Nullable<DateTime> x_dEdate,string x_sRebate,string x_sCon_per,string x_sNormal_rebate_type,string x_sPremium,string x_sBusiness_action_value_2,global::System.Nullable<bool> x_bEnabled2,string x_sCid,string x_sBusiness_action_2,string x_sBusiness_action_1,string x_sRate_plan,string x_sFree_mon,global::System.Nullable<bool> x_bEnabled1,string x_sHs_model,global::System.Nullable<bool> x_bActive,string x_sIssue_type)
        {
            BusinessActionDefaultSet _oBusinessActionDefaultSet=BusinessActionDefaultSetRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oBusinessActionDefaultSet.lob=x_sLob;
            _oBusinessActionDefaultSet.s_premium2=x_sS_premium2;
            _oBusinessActionDefaultSet.display2=x_bDisplay2;
            _oBusinessActionDefaultSet.display1=x_bDisplay1;
            _oBusinessActionDefaultSet.cdate=x_dCdate;
            _oBusinessActionDefaultSet.bundle_name=x_sBundle_name;
            _oBusinessActionDefaultSet.business_action_value_1=x_sBusiness_action_value_1;
            _oBusinessActionDefaultSet.trade_field=x_sTrade_field;
            _oBusinessActionDefaultSet.s_premium=x_sS_premium;
            _oBusinessActionDefaultSet.program=x_sProgram;
            _oBusinessActionDefaultSet.edate=x_dEdate;
            _oBusinessActionDefaultSet.rebate=x_sRebate;
            _oBusinessActionDefaultSet.con_per=x_sCon_per;
            _oBusinessActionDefaultSet.normal_rebate_type=x_sNormal_rebate_type;
            _oBusinessActionDefaultSet.premium=x_sPremium;
            _oBusinessActionDefaultSet.business_action_value_2=x_sBusiness_action_value_2;
            _oBusinessActionDefaultSet.enabled2=x_bEnabled2;
            _oBusinessActionDefaultSet.cid=x_sCid;
            _oBusinessActionDefaultSet.business_action_2=x_sBusiness_action_2;
            _oBusinessActionDefaultSet.business_action_1=x_sBusiness_action_1;
            _oBusinessActionDefaultSet.rate_plan=x_sRate_plan;
            _oBusinessActionDefaultSet.free_mon=x_sFree_mon;
            _oBusinessActionDefaultSet.enabled1=x_bEnabled1;
            _oBusinessActionDefaultSet.hs_model=x_sHs_model;
            _oBusinessActionDefaultSet.active=x_bActive;
            _oBusinessActionDefaultSet.issue_type=x_sIssue_type;
            return InsertWithOutLastID(x_oDB, _oBusinessActionDefaultSet);
        }
        
        
        public bool Insert(BusinessActionDefaultSet x_oBusinessActionDefaultSet)
        {
            return InsertWithOutLastID(n_oDB, x_oBusinessActionDefaultSet);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is BusinessActionDefaultSet)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (BusinessActionDefaultSet)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,BusinessActionDefaultSet x_oBusinessActionDefaultSet)
        {
            return InsertWithOutLastID(x_oDB, x_oBusinessActionDefaultSet);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,BusinessActionDefaultSet x_oBusinessActionDefaultSet)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [BusinessActionDefaultSet]   ([lob],[display2],[display1],[cdate],[bundle_name],[trade_field],[s_premium],[program],[edate],[rebate],[active],[business_action_value_2],[con_per],[normal_rebate_type],[premium],[free_mon],[enabled2],[cid],[business_action_2],[business_action_1],[rate_plan],[business_action_value_1],[enabled1],[hs_model],[s_premium2],[issue_type])  VALUES  (@lob,@display2,@display1,@cdate,@bundle_name,@trade_field,@s_premium,@program,@edate,@rebate,@active,@business_action_value_2,@con_per,@normal_rebate_type,@premium,@free_mon,@enabled2,@cid,@business_action_2,@business_action_1,@rate_plan,@business_action_value_1,@enabled1,@hs_model,@s_premium2,@issue_type)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessActionDefaultSet]","["+ Configurator.MSSQLTablePrefix + "BusinessActionDefaultSet]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oBusinessActionDefaultSet);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,BusinessActionDefaultSet x_oBusinessActionDefaultSet)
        {
            bool _bResult = false;
            if (!x_oBusinessActionDefaultSet.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oBusinessActionDefaultSet.lob==null){  x_oCmd.Parameters.Add("@lob", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@lob", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessActionDefaultSet.lob; }
                if(x_oBusinessActionDefaultSet.display2==null){  x_oCmd.Parameters.Add("@display2", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@display2", global::System.Data.SqlDbType.Bit).Value=x_oBusinessActionDefaultSet.display2; }
                if(x_oBusinessActionDefaultSet.display1==null){  x_oCmd.Parameters.Add("@display1", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@display1", global::System.Data.SqlDbType.Bit).Value=x_oBusinessActionDefaultSet.display1; }
                if(x_oBusinessActionDefaultSet.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oBusinessActionDefaultSet.cdate; }
                if(x_oBusinessActionDefaultSet.bundle_name==null){  x_oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessActionDefaultSet.bundle_name; }
                if(x_oBusinessActionDefaultSet.trade_field==null){  x_oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessActionDefaultSet.trade_field; }
                if(x_oBusinessActionDefaultSet.s_premium==null){  x_oCmd.Parameters.Add("@s_premium", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@s_premium", global::System.Data.SqlDbType.NVarChar,100).Value=x_oBusinessActionDefaultSet.s_premium; }
                if(x_oBusinessActionDefaultSet.program==null){  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessActionDefaultSet.program; }
                if(x_oBusinessActionDefaultSet.edate==null){  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=x_oBusinessActionDefaultSet.edate; }
                if(x_oBusinessActionDefaultSet.rebate==null){  x_oCmd.Parameters.Add("@rebate", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rebate", global::System.Data.SqlDbType.NVarChar,20).Value=x_oBusinessActionDefaultSet.rebate; }
                if(x_oBusinessActionDefaultSet.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oBusinessActionDefaultSet.active; }
                if(x_oBusinessActionDefaultSet.business_action_value_2==null){  x_oCmd.Parameters.Add("@business_action_value_2", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@business_action_value_2", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessActionDefaultSet.business_action_value_2; }
                if(x_oBusinessActionDefaultSet.con_per==null){  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessActionDefaultSet.con_per; }
                if(x_oBusinessActionDefaultSet.normal_rebate_type==null){  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value=x_oBusinessActionDefaultSet.normal_rebate_type; }
                if(x_oBusinessActionDefaultSet.premium==null){  x_oCmd.Parameters.Add("@premium", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@premium", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessActionDefaultSet.premium; }
                if(x_oBusinessActionDefaultSet.free_mon==null){  x_oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.NVarChar,30).Value=x_oBusinessActionDefaultSet.free_mon; }
                if(x_oBusinessActionDefaultSet.enabled2==null){  x_oCmd.Parameters.Add("@enabled2", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@enabled2", global::System.Data.SqlDbType.Bit).Value=x_oBusinessActionDefaultSet.enabled2; }
                if(x_oBusinessActionDefaultSet.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessActionDefaultSet.cid; }
                if(x_oBusinessActionDefaultSet.business_action_2==null){  x_oCmd.Parameters.Add("@business_action_2", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@business_action_2", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessActionDefaultSet.business_action_2; }
                if(x_oBusinessActionDefaultSet.business_action_1==null){  x_oCmd.Parameters.Add("@business_action_1", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@business_action_1", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessActionDefaultSet.business_action_1; }
                if(x_oBusinessActionDefaultSet.rate_plan==null){  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessActionDefaultSet.rate_plan; }
                if(x_oBusinessActionDefaultSet.business_action_value_1==null){  x_oCmd.Parameters.Add("@business_action_value_1", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@business_action_value_1", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessActionDefaultSet.business_action_value_1; }
                if(x_oBusinessActionDefaultSet.enabled1==null){  x_oCmd.Parameters.Add("@enabled1", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@enabled1", global::System.Data.SqlDbType.Bit).Value=x_oBusinessActionDefaultSet.enabled1; }
                if(x_oBusinessActionDefaultSet.hs_model==null){  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessActionDefaultSet.hs_model; }
                if(x_oBusinessActionDefaultSet.s_premium2==null){  x_oCmd.Parameters.Add("@s_premium2", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@s_premium2", global::System.Data.SqlDbType.NVarChar,100).Value=x_oBusinessActionDefaultSet.s_premium2; }
                if(x_oBusinessActionDefaultSet.issue_type==null){  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessActionDefaultSet.issue_type; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,string x_sLob,string x_sS_premium2,global::System.Nullable<bool> x_bDisplay2,global::System.Nullable<bool> x_bDisplay1,global::System.Nullable<DateTime> x_dCdate,string x_sBundle_name,string x_sBusiness_action_value_1,string x_sTrade_field,string x_sS_premium,string x_sProgram,global::System.Nullable<DateTime> x_dEdate,string x_sRebate,string x_sCon_per,string x_sNormal_rebate_type,string x_sPremium,string x_sBusiness_action_value_2,global::System.Nullable<bool> x_bEnabled2,string x_sCid,string x_sBusiness_action_2,string x_sBusiness_action_1,string x_sRate_plan,string x_sFree_mon,global::System.Nullable<bool> x_bEnabled1,string x_sHs_model,global::System.Nullable<bool> x_bActive,string x_sIssue_type)
        {
            int _oLastID;
            BusinessActionDefaultSet _oBusinessActionDefaultSet=BusinessActionDefaultSetRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oBusinessActionDefaultSet.lob=x_sLob;
            _oBusinessActionDefaultSet.s_premium2=x_sS_premium2;
            _oBusinessActionDefaultSet.display2=x_bDisplay2;
            _oBusinessActionDefaultSet.display1=x_bDisplay1;
            _oBusinessActionDefaultSet.cdate=x_dCdate;
            _oBusinessActionDefaultSet.bundle_name=x_sBundle_name;
            _oBusinessActionDefaultSet.business_action_value_1=x_sBusiness_action_value_1;
            _oBusinessActionDefaultSet.trade_field=x_sTrade_field;
            _oBusinessActionDefaultSet.s_premium=x_sS_premium;
            _oBusinessActionDefaultSet.program=x_sProgram;
            _oBusinessActionDefaultSet.edate=x_dEdate;
            _oBusinessActionDefaultSet.rebate=x_sRebate;
            _oBusinessActionDefaultSet.con_per=x_sCon_per;
            _oBusinessActionDefaultSet.normal_rebate_type=x_sNormal_rebate_type;
            _oBusinessActionDefaultSet.premium=x_sPremium;
            _oBusinessActionDefaultSet.business_action_value_2=x_sBusiness_action_value_2;
            _oBusinessActionDefaultSet.enabled2=x_bEnabled2;
            _oBusinessActionDefaultSet.cid=x_sCid;
            _oBusinessActionDefaultSet.business_action_2=x_sBusiness_action_2;
            _oBusinessActionDefaultSet.business_action_1=x_sBusiness_action_1;
            _oBusinessActionDefaultSet.rate_plan=x_sRate_plan;
            _oBusinessActionDefaultSet.free_mon=x_sFree_mon;
            _oBusinessActionDefaultSet.enabled1=x_bEnabled1;
            _oBusinessActionDefaultSet.hs_model=x_sHs_model;
            _oBusinessActionDefaultSet.active=x_bActive;
            _oBusinessActionDefaultSet.issue_type=x_sIssue_type;
            if(InsertWithLastID(x_oDB, _oBusinessActionDefaultSet,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(BusinessActionDefaultSet x_oBusinessActionDefaultSet)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oBusinessActionDefaultSet, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, BusinessActionDefaultSet x_oBusinessActionDefaultSet)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oBusinessActionDefaultSet, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is BusinessActionDefaultSet)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (BusinessActionDefaultSet)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,BusinessActionDefaultSet x_oBusinessActionDefaultSet, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [BusinessActionDefaultSet]   ([lob],[display2],[display1],[cdate],[bundle_name],[trade_field],[s_premium],[program],[edate],[rebate],[active],[business_action_value_2],[con_per],[normal_rebate_type],[premium],[free_mon],[enabled2],[cid],[business_action_2],[business_action_1],[rate_plan],[business_action_value_1],[enabled1],[hs_model],[s_premium2],[issue_type])  VALUES  (@lob,@display2,@display1,@cdate,@bundle_name,@trade_field,@s_premium,@program,@edate,@rebate,@active,@business_action_value_2,@con_per,@normal_rebate_type,@premium,@free_mon,@enabled2,@cid,@business_action_2,@business_action_1,@rate_plan,@business_action_value_1,@enabled1,@hs_model,@s_premium2,@issue_type)"+" SELECT  @@IDENTITY AS BusinessActionDefaultSet_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessActionDefaultSet]","["+ Configurator.MSSQLTablePrefix + "BusinessActionDefaultSet]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oBusinessActionDefaultSet,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,BusinessActionDefaultSet x_oBusinessActionDefaultSet, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oBusinessActionDefaultSet.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oBusinessActionDefaultSet.lob==null){  x_oCmd.Parameters.Add("@lob", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@lob", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessActionDefaultSet.lob; }
                if(x_oBusinessActionDefaultSet.display2==null){  x_oCmd.Parameters.Add("@display2", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@display2", global::System.Data.SqlDbType.Bit).Value=x_oBusinessActionDefaultSet.display2; }
                if(x_oBusinessActionDefaultSet.display1==null){  x_oCmd.Parameters.Add("@display1", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@display1", global::System.Data.SqlDbType.Bit).Value=x_oBusinessActionDefaultSet.display1; }
                if(x_oBusinessActionDefaultSet.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oBusinessActionDefaultSet.cdate; }
                if(x_oBusinessActionDefaultSet.bundle_name==null){  x_oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessActionDefaultSet.bundle_name; }
                if(x_oBusinessActionDefaultSet.trade_field==null){  x_oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessActionDefaultSet.trade_field; }
                if(x_oBusinessActionDefaultSet.s_premium==null){  x_oCmd.Parameters.Add("@s_premium", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@s_premium", global::System.Data.SqlDbType.NVarChar,100).Value=x_oBusinessActionDefaultSet.s_premium; }
                if(x_oBusinessActionDefaultSet.program==null){  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessActionDefaultSet.program; }
                if(x_oBusinessActionDefaultSet.edate==null){  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=x_oBusinessActionDefaultSet.edate; }
                if(x_oBusinessActionDefaultSet.rebate==null){  x_oCmd.Parameters.Add("@rebate", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rebate", global::System.Data.SqlDbType.NVarChar,20).Value=x_oBusinessActionDefaultSet.rebate; }
                if(x_oBusinessActionDefaultSet.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oBusinessActionDefaultSet.active; }
                if(x_oBusinessActionDefaultSet.business_action_value_2==null){  x_oCmd.Parameters.Add("@business_action_value_2", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@business_action_value_2", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessActionDefaultSet.business_action_value_2; }
                if(x_oBusinessActionDefaultSet.con_per==null){  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessActionDefaultSet.con_per; }
                if(x_oBusinessActionDefaultSet.normal_rebate_type==null){  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value=x_oBusinessActionDefaultSet.normal_rebate_type; }
                if(x_oBusinessActionDefaultSet.premium==null){  x_oCmd.Parameters.Add("@premium", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@premium", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessActionDefaultSet.premium; }
                if(x_oBusinessActionDefaultSet.free_mon==null){  x_oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.NVarChar,30).Value=x_oBusinessActionDefaultSet.free_mon; }
                if(x_oBusinessActionDefaultSet.enabled2==null){  x_oCmd.Parameters.Add("@enabled2", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@enabled2", global::System.Data.SqlDbType.Bit).Value=x_oBusinessActionDefaultSet.enabled2; }
                if(x_oBusinessActionDefaultSet.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessActionDefaultSet.cid; }
                if(x_oBusinessActionDefaultSet.business_action_2==null){  x_oCmd.Parameters.Add("@business_action_2", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@business_action_2", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessActionDefaultSet.business_action_2; }
                if(x_oBusinessActionDefaultSet.business_action_1==null){  x_oCmd.Parameters.Add("@business_action_1", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@business_action_1", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessActionDefaultSet.business_action_1; }
                if(x_oBusinessActionDefaultSet.rate_plan==null){  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessActionDefaultSet.rate_plan; }
                if(x_oBusinessActionDefaultSet.business_action_value_1==null){  x_oCmd.Parameters.Add("@business_action_value_1", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@business_action_value_1", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessActionDefaultSet.business_action_value_1; }
                if(x_oBusinessActionDefaultSet.enabled1==null){  x_oCmd.Parameters.Add("@enabled1", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@enabled1", global::System.Data.SqlDbType.Bit).Value=x_oBusinessActionDefaultSet.enabled1; }
                if(x_oBusinessActionDefaultSet.hs_model==null){  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessActionDefaultSet.hs_model; }
                if(x_oBusinessActionDefaultSet.s_premium2==null){  x_oCmd.Parameters.Add("@s_premium2", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@s_premium2", global::System.Data.SqlDbType.NVarChar,100).Value=x_oBusinessActionDefaultSet.s_premium2; }
                if(x_oBusinessActionDefaultSet.issue_type==null){  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessActionDefaultSet.issue_type; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["BusinessActionDefaultSet_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["BusinessActionDefaultSet_LASTID"].ToString()) && int.TryParse(_oData["BusinessActionDefaultSet_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sLob,string x_sS_premium2,global::System.Nullable<bool> x_bDisplay2,global::System.Nullable<bool> x_bDisplay1,global::System.Nullable<DateTime> x_dCdate,string x_sBundle_name,string x_sBusiness_action_value_1,string x_sTrade_field,string x_sS_premium,string x_sProgram,global::System.Nullable<DateTime> x_dEdate,string x_sRebate,string x_sCon_per,string x_sNormal_rebate_type,string x_sPremium,string x_sBusiness_action_value_2,global::System.Nullable<bool> x_bEnabled2,string x_sCid,string x_sBusiness_action_2,string x_sBusiness_action_1,string x_sRate_plan,string x_sFree_mon,global::System.Nullable<bool> x_bEnabled1,string x_sHs_model,global::System.Nullable<bool> x_bActive,string x_sIssue_type)
        {
            int _oLastID;
            BusinessActionDefaultSet _oBusinessActionDefaultSet=BusinessActionDefaultSetRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oBusinessActionDefaultSet.lob=x_sLob;
            _oBusinessActionDefaultSet.s_premium2=x_sS_premium2;
            _oBusinessActionDefaultSet.display2=x_bDisplay2;
            _oBusinessActionDefaultSet.display1=x_bDisplay1;
            _oBusinessActionDefaultSet.cdate=x_dCdate;
            _oBusinessActionDefaultSet.bundle_name=x_sBundle_name;
            _oBusinessActionDefaultSet.business_action_value_1=x_sBusiness_action_value_1;
            _oBusinessActionDefaultSet.trade_field=x_sTrade_field;
            _oBusinessActionDefaultSet.s_premium=x_sS_premium;
            _oBusinessActionDefaultSet.program=x_sProgram;
            _oBusinessActionDefaultSet.edate=x_dEdate;
            _oBusinessActionDefaultSet.rebate=x_sRebate;
            _oBusinessActionDefaultSet.con_per=x_sCon_per;
            _oBusinessActionDefaultSet.normal_rebate_type=x_sNormal_rebate_type;
            _oBusinessActionDefaultSet.premium=x_sPremium;
            _oBusinessActionDefaultSet.business_action_value_2=x_sBusiness_action_value_2;
            _oBusinessActionDefaultSet.enabled2=x_bEnabled2;
            _oBusinessActionDefaultSet.cid=x_sCid;
            _oBusinessActionDefaultSet.business_action_2=x_sBusiness_action_2;
            _oBusinessActionDefaultSet.business_action_1=x_sBusiness_action_1;
            _oBusinessActionDefaultSet.rate_plan=x_sRate_plan;
            _oBusinessActionDefaultSet.free_mon=x_sFree_mon;
            _oBusinessActionDefaultSet.enabled1=x_bEnabled1;
            _oBusinessActionDefaultSet.hs_model=x_sHs_model;
            _oBusinessActionDefaultSet.active=x_bActive;
            _oBusinessActionDefaultSet.issue_type=x_sIssue_type;
            if(InsertWithLastID_SP(x_oDB, _oBusinessActionDefaultSet,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(BusinessActionDefaultSet x_oBusinessActionDefaultSet)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oBusinessActionDefaultSet, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, BusinessActionDefaultSet x_oBusinessActionDefaultSet)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oBusinessActionDefaultSet, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is BusinessActionDefaultSet)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (BusinessActionDefaultSet)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,BusinessActionDefaultSet x_oBusinessActionDefaultSet, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "BUSINESSACTIONDEFAULTSET";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oBusinessActionDefaultSet,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,BusinessActionDefaultSet x_oBusinessActionDefaultSet, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@lob", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessActionDefaultSet.lob==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessActionDefaultSet.lob; }
                _oPar=x_oCmd.Parameters.Add("@display2", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessActionDefaultSet.display2==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessActionDefaultSet.display2; }
                _oPar=x_oCmd.Parameters.Add("@display1", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessActionDefaultSet.display1==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessActionDefaultSet.display1; }
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessActionDefaultSet.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oBusinessActionDefaultSet.cdate; }
                _oPar=x_oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessActionDefaultSet.bundle_name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessActionDefaultSet.bundle_name; }
                _oPar=x_oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessActionDefaultSet.trade_field==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessActionDefaultSet.trade_field; }
                _oPar=x_oCmd.Parameters.Add("@s_premium", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessActionDefaultSet.s_premium==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessActionDefaultSet.s_premium; }
                _oPar=x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessActionDefaultSet.program==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessActionDefaultSet.program; }
                _oPar=x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessActionDefaultSet.edate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oBusinessActionDefaultSet.edate; }
                _oPar=x_oCmd.Parameters.Add("@rebate", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessActionDefaultSet.rebate==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessActionDefaultSet.rebate; }
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessActionDefaultSet.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessActionDefaultSet.active; }
                _oPar=x_oCmd.Parameters.Add("@business_action_value_2", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessActionDefaultSet.business_action_value_2==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessActionDefaultSet.business_action_value_2; }
                _oPar=x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessActionDefaultSet.con_per==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessActionDefaultSet.con_per; }
                _oPar=x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessActionDefaultSet.normal_rebate_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessActionDefaultSet.normal_rebate_type; }
                _oPar=x_oCmd.Parameters.Add("@premium", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessActionDefaultSet.premium==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessActionDefaultSet.premium; }
                _oPar=x_oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.NVarChar,30);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessActionDefaultSet.free_mon==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessActionDefaultSet.free_mon; }
                _oPar=x_oCmd.Parameters.Add("@enabled2", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessActionDefaultSet.enabled2==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessActionDefaultSet.enabled2; }
                _oPar=x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessActionDefaultSet.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessActionDefaultSet.cid; }
                _oPar=x_oCmd.Parameters.Add("@business_action_2", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessActionDefaultSet.business_action_2==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessActionDefaultSet.business_action_2; }
                _oPar=x_oCmd.Parameters.Add("@business_action_1", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessActionDefaultSet.business_action_1==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessActionDefaultSet.business_action_1; }
                _oPar=x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessActionDefaultSet.rate_plan==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessActionDefaultSet.rate_plan; }
                _oPar=x_oCmd.Parameters.Add("@business_action_value_1", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessActionDefaultSet.business_action_value_1==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessActionDefaultSet.business_action_value_1; }
                _oPar=x_oCmd.Parameters.Add("@enabled1", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessActionDefaultSet.enabled1==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessActionDefaultSet.enabled1; }
                _oPar=x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessActionDefaultSet.hs_model==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessActionDefaultSet.hs_model; }
                _oPar=x_oCmd.Parameters.Add("@s_premium2", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessActionDefaultSet.s_premium2==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessActionDefaultSet.s_premium2; }
                _oPar=x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessActionDefaultSet.issue_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessActionDefaultSet.issue_type; }
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
        
        #region INSERT_BUSINESSACTIONDEFAULTSET Store Procedures
        ///-- =============================================
        ///-- Author:		<Author,Philip SW>
        ///-- Create date: <Create Date 2011-07-14>
        ///-- Description:	<Description,BUSINESSACTIONDEFAULTSET, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_BUSINESSACTIONDEFAULTSET Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_BUSINESSACTIONDEFAULTSET', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_BUSINESSACTIONDEFAULTSET;
        GO
        CREATE PROCEDURE INSERT_BUSINESSACTIONDEFAULTSET
        	-- Add the parameters for the stored procedure here
        @RETURN_MID int output,
        @lob nvarchar(50),
        @s_premium2 nvarchar(100),
        @display2 bit,
        @display1 bit,
        @cdate datetime,
        @bundle_name nvarchar(50),
        @business_action_value_1 nvarchar(250),
        @trade_field nvarchar(50),
        @s_premium nvarchar(100),
        @program nvarchar(250),
        @edate datetime,
        @rebate nvarchar(20),
        @con_per nvarchar(50),
        @normal_rebate_type nvarchar(100),
        @premium nvarchar(250),
        @business_action_value_2 nvarchar(250),
        @enabled2 bit,
        @cid nvarchar(50),
        @business_action_2 nvarchar(250),
        @business_action_1 nvarchar(250),
        @rate_plan nvarchar(250),
        @free_mon nvarchar(30),
        @enabled1 bit,
        @hs_model nvarchar(250),
        @active bit,
        @issue_type nvarchar(50)
        AS
        
        INSERT INTO  [BusinessActionDefaultSet]   ([lob],[display2],[display1],[cdate],[bundle_name],[trade_field],[s_premium],[program],[edate],[rebate],[active],[business_action_value_2],[con_per],[normal_rebate_type],[premium],[free_mon],[enabled2],[cid],[business_action_2],[business_action_1],[rate_plan],[business_action_value_1],[enabled1],[hs_model],[s_premium2],[issue_type])  VALUES  (@lob,@display2,@display1,@cdate,@bundle_name,@trade_field,@s_premium,@program,@edate,@rebate,@active,@business_action_value_2,@con_per,@normal_rebate_type,@premium,@free_mon,@enabled2,@cid,@business_action_2,@business_action_1,@rate_plan,@business_action_value_1,@enabled1,@hs_model,@s_premium2,@issue_type)
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
            string _sQuery = "DELETE FROM  [BusinessActionDefaultSet]  WHERE [BusinessActionDefaultSet].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessActionDefaultSet]","["+ Configurator.MSSQLTablePrefix + "BusinessActionDefaultSet]"); }
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
            return BusinessActionDefaultSetRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [BusinessActionDefaultSet]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessActionDefaultSet]","["+ Configurator.MSSQLTablePrefix + "BusinessActionDefaultSet]"); }
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
            string _sQuery = "DELETE FROM [BusinessActionDefaultSet]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessActionDefaultSet]","["+ Configurator.MSSQLTablePrefix + "BusinessActionDefaultSet]"); }
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


