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
///-- Create date: <Create Date 2010-08-20>
///-- Description:	<Description,Table :[MobileOrderMigrateRule],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderMigrateRule] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"MobileOrderMigrateRule")]
    public class MobileOrderMigrateRuleRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static MobileOrderMigrateRuleRepositoryBase instance;
        public static MobileOrderMigrateRuleRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new MobileOrderMigrateRuleRepositoryBase(_oDB);
            }
            return instance;
        }
        public static MobileOrderMigrateRuleRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new MobileOrderMigrateRuleRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<MobileOrderMigrateRuleEntity> MobileOrderMigrateRules;
        #endregion
        
        #region Constructor
        public MobileOrderMigrateRuleRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~MobileOrderMigrateRuleRepositoryBase() { 
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
        public static MobileOrderMigrateRule CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new MobileOrderMigrateRule(_oDB);
        }
        
        public static MobileOrderMigrateRule CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new MobileOrderMigrateRule(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [MobileOrderMigrateRule]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMigrateRule]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMigrateRule]"); }
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
        
        
        public MobileOrderMigrateRuleEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }
        
        
        public static MobileOrderMigrateRuleEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            if (x_oDB==null) { return null; }
            MobileOrderMigrateRule _MobileOrderMigrateRule = (MobileOrderMigrateRule)MobileOrderMigrateRuleRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_MobileOrderMigrateRule.Load(x_iId)) { return null; }
            return _MobileOrderMigrateRule;
        }
        
        
        
        public static MobileOrderMigrateRuleEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<MobileOrderMigrateRuleEntity> _oMobileOrderMigrateRuleList = GetListObj(x_oDB,0, "id", x_oArrayItemId);
            return _oMobileOrderMigrateRuleList.Count == 0 ? null : _oMobileOrderMigrateRuleList.ToArray();
        }
        
        public static List<MobileOrderMigrateRuleEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "id", x_oArrayItemId);
        }
        
        
        public static MobileOrderMigrateRuleEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderMigrateRuleEntity> _oMobileOrderMigrateRuleList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            return _oMobileOrderMigrateRuleList.Count == 0 ? null : _oMobileOrderMigrateRuleList.ToArray();
        }
        
        
        public static MobileOrderMigrateRuleEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderMigrateRuleEntity> _oMobileOrderMigrateRuleList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            return _oMobileOrderMigrateRuleList.Count == 0 ? null : _oMobileOrderMigrateRuleList.ToArray();
        }
        
        public static List<MobileOrderMigrateRuleEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<MobileOrderMigrateRuleEntity> _oRow = new List<MobileOrderMigrateRuleEntity>();
            string _sQuery = "SELECT  "+_sTop+" [MobileOrderMigrateRule].[id] AS MOBILEORDERMIGRATERULE_ID,[MobileOrderMigrateRule].[cdate] AS MOBILEORDERMIGRATERULE_CDATE,[MobileOrderMigrateRule].[cid] AS MOBILEORDERMIGRATERULE_CID,[MobileOrderMigrateRule].[did] AS MOBILEORDERMIGRATERULE_DID,[MobileOrderMigrateRule].[status] AS MOBILEORDERMIGRATERULE_STATUS,[MobileOrderMigrateRule].[type] AS MOBILEORDERMIGRATERULE_TYPE,[MobileOrderMigrateRule].[chk] AS MOBILEORDERMIGRATERULE_CHK,[MobileOrderMigrateRule].[active] AS MOBILEORDERMIGRATERULE_ACTIVE,[MobileOrderMigrateRule].[name] AS MOBILEORDERMIGRATERULE_NAME,[MobileOrderMigrateRule].[sku] AS MOBILEORDERMIGRATERULE_SKU,[MobileOrderMigrateRule].[ddate] AS MOBILEORDERMIGRATERULE_DDATE  FROM  [MobileOrderMigrateRule]";
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
                _sQuery += " WHERE [MobileOrderMigrateRule].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMigrateRule]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMigrateRule]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        MobileOrderMigrateRule _oMobileOrderMigrateRule = MobileOrderMigrateRuleRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_ID"])) {_oMobileOrderMigrateRule.id = (global::System.Nullable<int>)_oData["MOBILEORDERMIGRATERULE_ID"]; }else{_oMobileOrderMigrateRule.id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_CDATE"])) {_oMobileOrderMigrateRule.cdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERMIGRATERULE_CDATE"]; }else{_oMobileOrderMigrateRule.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_CID"])) {_oMobileOrderMigrateRule.cid = (string)_oData["MOBILEORDERMIGRATERULE_CID"]; }else{_oMobileOrderMigrateRule.cid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_DID"])) {_oMobileOrderMigrateRule.did = (string)_oData["MOBILEORDERMIGRATERULE_DID"]; }else{_oMobileOrderMigrateRule.did=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_STATUS"])) {_oMobileOrderMigrateRule.status = (string)_oData["MOBILEORDERMIGRATERULE_STATUS"]; }else{_oMobileOrderMigrateRule.status=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_TYPE"])) {_oMobileOrderMigrateRule.type = (string)_oData["MOBILEORDERMIGRATERULE_TYPE"]; }else{_oMobileOrderMigrateRule.type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_CHK"])) {_oMobileOrderMigrateRule.chk = (global::System.Nullable<bool>)_oData["MOBILEORDERMIGRATERULE_CHK"]; }else{_oMobileOrderMigrateRule.chk=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_ACTIVE"])) {_oMobileOrderMigrateRule.active = (global::System.Nullable<bool>)_oData["MOBILEORDERMIGRATERULE_ACTIVE"]; }else{_oMobileOrderMigrateRule.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_NAME"])) {_oMobileOrderMigrateRule.name = (string)_oData["MOBILEORDERMIGRATERULE_NAME"]; }else{_oMobileOrderMigrateRule.name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_SKU"])) {_oMobileOrderMigrateRule.sku = (string)_oData["MOBILEORDERMIGRATERULE_SKU"]; }else{_oMobileOrderMigrateRule.sku=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_DDATE"])) {_oMobileOrderMigrateRule.ddate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERMIGRATERULE_DDATE"]; }else{_oMobileOrderMigrateRule.ddate=null;}
                        _oMobileOrderMigrateRule.SetDB(x_oDB);
                        _oMobileOrderMigrateRule.GetFound();
                        _oRow.Add(_oMobileOrderMigrateRule);
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
        
        
        public static MobileOrderMigrateRuleEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderMigrateRuleEntity> _oMobileOrderMigrateRuleList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oMobileOrderMigrateRuleList.Count == 0 ? null : _oMobileOrderMigrateRuleList.ToArray();
        }
        
        
        public static MobileOrderMigrateRuleEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderMigrateRuleEntity> _oMobileOrderMigrateRuleList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oMobileOrderMigrateRuleList.Count == 0 ? null : _oMobileOrderMigrateRuleList.ToArray();
        }
        
        public static List<MobileOrderMigrateRuleEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<MobileOrderMigrateRuleEntity> _oRow = new List<MobileOrderMigrateRuleEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[MobileOrderMigrateRule].[id] AS MOBILEORDERMIGRATERULE_ID,[MobileOrderMigrateRule].[cdate] AS MOBILEORDERMIGRATERULE_CDATE,[MobileOrderMigrateRule].[cid] AS MOBILEORDERMIGRATERULE_CID,[MobileOrderMigrateRule].[did] AS MOBILEORDERMIGRATERULE_DID,[MobileOrderMigrateRule].[status] AS MOBILEORDERMIGRATERULE_STATUS,[MobileOrderMigrateRule].[type] AS MOBILEORDERMIGRATERULE_TYPE,[MobileOrderMigrateRule].[chk] AS MOBILEORDERMIGRATERULE_CHK,[MobileOrderMigrateRule].[active] AS MOBILEORDERMIGRATERULE_ACTIVE,[MobileOrderMigrateRule].[name] AS MOBILEORDERMIGRATERULE_NAME,[MobileOrderMigrateRule].[sku] AS MOBILEORDERMIGRATERULE_SKU,[MobileOrderMigrateRule].[ddate] AS MOBILEORDERMIGRATERULE_DDATE";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[MobileOrderMigrateRule]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMigrateRule]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = MobileOrderMigrateRuleRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                MobileOrderMigrateRuleEntity _oMobileOrderMigrateRule = MobileOrderMigrateRuleRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_ID"])) {_oMobileOrderMigrateRule.id = (global::System.Nullable<int>)_oData["MOBILEORDERMIGRATERULE_ID"]; } else {_oMobileOrderMigrateRule.id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_CDATE"])) {_oMobileOrderMigrateRule.cdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERMIGRATERULE_CDATE"]; } else {_oMobileOrderMigrateRule.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_CID"])) {_oMobileOrderMigrateRule.cid = (string)_oData["MOBILEORDERMIGRATERULE_CID"]; } else {_oMobileOrderMigrateRule.cid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_DID"])) {_oMobileOrderMigrateRule.did = (string)_oData["MOBILEORDERMIGRATERULE_DID"]; } else {_oMobileOrderMigrateRule.did=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_STATUS"])) {_oMobileOrderMigrateRule.status = (string)_oData["MOBILEORDERMIGRATERULE_STATUS"]; } else {_oMobileOrderMigrateRule.status=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_TYPE"])) {_oMobileOrderMigrateRule.type = (string)_oData["MOBILEORDERMIGRATERULE_TYPE"]; } else {_oMobileOrderMigrateRule.type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_CHK"])) {_oMobileOrderMigrateRule.chk = (global::System.Nullable<bool>)_oData["MOBILEORDERMIGRATERULE_CHK"]; } else {_oMobileOrderMigrateRule.chk=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_ACTIVE"])) {_oMobileOrderMigrateRule.active = (global::System.Nullable<bool>)_oData["MOBILEORDERMIGRATERULE_ACTIVE"]; } else {_oMobileOrderMigrateRule.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_NAME"])) {_oMobileOrderMigrateRule.name = (string)_oData["MOBILEORDERMIGRATERULE_NAME"]; } else {_oMobileOrderMigrateRule.name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_SKU"])) {_oMobileOrderMigrateRule.sku = (string)_oData["MOBILEORDERMIGRATERULE_SKU"]; } else {_oMobileOrderMigrateRule.sku=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_DDATE"])) {_oMobileOrderMigrateRule.ddate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERMIGRATERULE_DDATE"]; } else {_oMobileOrderMigrateRule.ddate=null; }
                _oMobileOrderMigrateRule.SetDB(x_oDB);
                _oMobileOrderMigrateRule.GetFound();
                _oRow.Add(_oMobileOrderMigrateRule);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( MobileOrderMigrateRule.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,MobileOrderMigrateRule.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(MobileOrderMigrateRule.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(MobileOrderMigrateRule.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [MobileOrderMigrateRule].[id] AS MOBILEORDERMIGRATERULE_ID,[MobileOrderMigrateRule].[cdate] AS MOBILEORDERMIGRATERULE_CDATE,[MobileOrderMigrateRule].[cid] AS MOBILEORDERMIGRATERULE_CID,[MobileOrderMigrateRule].[did] AS MOBILEORDERMIGRATERULE_DID,[MobileOrderMigrateRule].[status] AS MOBILEORDERMIGRATERULE_STATUS,[MobileOrderMigrateRule].[type] AS MOBILEORDERMIGRATERULE_TYPE,[MobileOrderMigrateRule].[chk] AS MOBILEORDERMIGRATERULE_CHK,[MobileOrderMigrateRule].[active] AS MOBILEORDERMIGRATERULE_ACTIVE,[MobileOrderMigrateRule].[name] AS MOBILEORDERMIGRATERULE_NAME,[MobileOrderMigrateRule].[sku] AS MOBILEORDERMIGRATERULE_SKU,[MobileOrderMigrateRule].[ddate] AS MOBILEORDERMIGRATERULE_DDATE  FROM  [MobileOrderMigrateRule]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[MobileOrderMigrateRule]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMigrateRule]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"MobileOrderMigrateRule");
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
        
        public bool Insert(global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sStatus,string x_sType,global::System.Nullable<bool> x_bChk,global::System.Nullable<bool> x_bActive,string x_sName,string x_sSku,global::System.Nullable<DateTime> x_dDdate)
        {
            MobileOrderMigrateRule _oMobileOrderMigrateRule=MobileOrderMigrateRuleRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oMobileOrderMigrateRule.cdate=x_dCdate;
            _oMobileOrderMigrateRule.cid=x_sCid;
            _oMobileOrderMigrateRule.did=x_sDid;
            _oMobileOrderMigrateRule.status=x_sStatus;
            _oMobileOrderMigrateRule.type=x_sType;
            _oMobileOrderMigrateRule.chk=x_bChk;
            _oMobileOrderMigrateRule.active=x_bActive;
            _oMobileOrderMigrateRule.name=x_sName;
            _oMobileOrderMigrateRule.sku=x_sSku;
            _oMobileOrderMigrateRule.ddate=x_dDdate;
            return InsertWithOutLastID(n_oDB, _oMobileOrderMigrateRule);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sStatus,string x_sType,global::System.Nullable<bool> x_bChk,global::System.Nullable<bool> x_bActive,string x_sName,string x_sSku,global::System.Nullable<DateTime> x_dDdate)
        {
            MobileOrderMigrateRule _oMobileOrderMigrateRule=MobileOrderMigrateRuleRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderMigrateRule.cdate=x_dCdate;
            _oMobileOrderMigrateRule.cid=x_sCid;
            _oMobileOrderMigrateRule.did=x_sDid;
            _oMobileOrderMigrateRule.status=x_sStatus;
            _oMobileOrderMigrateRule.type=x_sType;
            _oMobileOrderMigrateRule.chk=x_bChk;
            _oMobileOrderMigrateRule.active=x_bActive;
            _oMobileOrderMigrateRule.name=x_sName;
            _oMobileOrderMigrateRule.sku=x_sSku;
            _oMobileOrderMigrateRule.ddate=x_dDdate;
            return InsertWithOutLastID(x_oDB, _oMobileOrderMigrateRule);
        }
        
        
        public bool Insert(MobileOrderMigrateRule x_oMobileOrderMigrateRule)
        {
            return InsertWithOutLastID(n_oDB, x_oMobileOrderMigrateRule);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is MobileOrderMigrateRule)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (MobileOrderMigrateRule)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,MobileOrderMigrateRule x_oMobileOrderMigrateRule)
        {
            return InsertWithOutLastID(x_oDB, x_oMobileOrderMigrateRule);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderMigrateRule x_oMobileOrderMigrateRule)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderMigrateRule]   ([cdate],[cid],[did],[status],[type],[chk],[active],[name],[sku],[ddate])  VALUES  (@cdate,@cid,@did,@status,@type,@chk,@active,@name,@sku,@ddate)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMigrateRule]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMigrateRule]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderMigrateRule);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderMigrateRule x_oMobileOrderMigrateRule)
        {
            bool _bResult = false;
            if (!x_oMobileOrderMigrateRule.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderMigrateRule.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderMigrateRule.cdate; }
                if(x_oMobileOrderMigrateRule.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderMigrateRule.cid; }
                if(x_oMobileOrderMigrateRule.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderMigrateRule.did; }
                if(x_oMobileOrderMigrateRule.status==null){  x_oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderMigrateRule.status; }
                if(x_oMobileOrderMigrateRule.type==null){  x_oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderMigrateRule.type; }
                if(x_oMobileOrderMigrateRule.chk==null){  x_oCmd.Parameters.Add("@chk", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@chk", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderMigrateRule.chk; }
                if(x_oMobileOrderMigrateRule.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderMigrateRule.active; }
                if(x_oMobileOrderMigrateRule.name==null){  x_oCmd.Parameters.Add("@name", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@name", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderMigrateRule.name; }
                if(x_oMobileOrderMigrateRule.sku==null){  x_oCmd.Parameters.Add("@sku", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sku", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderMigrateRule.sku; }
                if(x_oMobileOrderMigrateRule.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderMigrateRule.ddate; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sStatus,string x_sType,global::System.Nullable<bool> x_bChk,global::System.Nullable<bool> x_bActive,string x_sName,string x_sSku,global::System.Nullable<DateTime> x_dDdate)
        {
            int _oLastID;
            MobileOrderMigrateRule _oMobileOrderMigrateRule=MobileOrderMigrateRuleRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderMigrateRule.cdate=x_dCdate;
            _oMobileOrderMigrateRule.cid=x_sCid;
            _oMobileOrderMigrateRule.did=x_sDid;
            _oMobileOrderMigrateRule.status=x_sStatus;
            _oMobileOrderMigrateRule.type=x_sType;
            _oMobileOrderMigrateRule.chk=x_bChk;
            _oMobileOrderMigrateRule.active=x_bActive;
            _oMobileOrderMigrateRule.name=x_sName;
            _oMobileOrderMigrateRule.sku=x_sSku;
            _oMobileOrderMigrateRule.ddate=x_dDdate;
            if(InsertWithLastID(x_oDB, _oMobileOrderMigrateRule,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(MobileOrderMigrateRule x_oMobileOrderMigrateRule)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oMobileOrderMigrateRule, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, MobileOrderMigrateRule x_oMobileOrderMigrateRule)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oMobileOrderMigrateRule, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderMigrateRule)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (MobileOrderMigrateRule)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,MobileOrderMigrateRule x_oMobileOrderMigrateRule, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderMigrateRule]   ([cdate],[cid],[did],[status],[type],[chk],[active],[name],[sku],[ddate])  VALUES  (@cdate,@cid,@did,@status,@type,@chk,@active,@name,@sku,@ddate)"+" SELECT  @@IDENTITY AS MobileOrderMigrateRule_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMigrateRule]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMigrateRule]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderMigrateRule,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderMigrateRule x_oMobileOrderMigrateRule, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oMobileOrderMigrateRule.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderMigrateRule.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderMigrateRule.cdate; }
                if(x_oMobileOrderMigrateRule.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderMigrateRule.cid; }
                if(x_oMobileOrderMigrateRule.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderMigrateRule.did; }
                if(x_oMobileOrderMigrateRule.status==null){  x_oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderMigrateRule.status; }
                if(x_oMobileOrderMigrateRule.type==null){  x_oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderMigrateRule.type; }
                if(x_oMobileOrderMigrateRule.chk==null){  x_oCmd.Parameters.Add("@chk", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@chk", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderMigrateRule.chk; }
                if(x_oMobileOrderMigrateRule.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderMigrateRule.active; }
                if(x_oMobileOrderMigrateRule.name==null){  x_oCmd.Parameters.Add("@name", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@name", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderMigrateRule.name; }
                if(x_oMobileOrderMigrateRule.sku==null){  x_oCmd.Parameters.Add("@sku", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sku", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderMigrateRule.sku; }
                if(x_oMobileOrderMigrateRule.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderMigrateRule.ddate; }
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["MobileOrderMigrateRule_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["MobileOrderMigrateRule_LASTID"].ToString()) && int.TryParse(_oData["MobileOrderMigrateRule_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sStatus,string x_sType,global::System.Nullable<bool> x_bChk,global::System.Nullable<bool> x_bActive,string x_sName,string x_sSku,global::System.Nullable<DateTime> x_dDdate)
        {
            int _oLastID;
            MobileOrderMigrateRule _oMobileOrderMigrateRule=MobileOrderMigrateRuleRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderMigrateRule.cdate=x_dCdate;
            _oMobileOrderMigrateRule.cid=x_sCid;
            _oMobileOrderMigrateRule.did=x_sDid;
            _oMobileOrderMigrateRule.status=x_sStatus;
            _oMobileOrderMigrateRule.type=x_sType;
            _oMobileOrderMigrateRule.chk=x_bChk;
            _oMobileOrderMigrateRule.active=x_bActive;
            _oMobileOrderMigrateRule.name=x_sName;
            _oMobileOrderMigrateRule.sku=x_sSku;
            _oMobileOrderMigrateRule.ddate=x_dDdate;
            if(InsertWithLastID_SP(x_oDB, _oMobileOrderMigrateRule,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(MobileOrderMigrateRule x_oMobileOrderMigrateRule)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oMobileOrderMigrateRule, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderMigrateRule x_oMobileOrderMigrateRule)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oMobileOrderMigrateRule, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderMigrateRule)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (MobileOrderMigrateRule)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,MobileOrderMigrateRule x_oMobileOrderMigrateRule, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "MOBILEORDERMIGRATERULE";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oMobileOrderMigrateRule,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderMigrateRule x_oMobileOrderMigrateRule, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMigrateRule.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderMigrateRule.cdate; }
                _oPar=x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMigrateRule.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderMigrateRule.cid; }
                _oPar=x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMigrateRule.did==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderMigrateRule.did; }
                _oPar=x_oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMigrateRule.status==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderMigrateRule.status; }
                _oPar=x_oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMigrateRule.type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderMigrateRule.type; }
                _oPar=x_oCmd.Parameters.Add("@chk", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMigrateRule.chk==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderMigrateRule.chk; }
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMigrateRule.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderMigrateRule.active; }
                _oPar=x_oCmd.Parameters.Add("@name", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMigrateRule.name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderMigrateRule.name; }
                _oPar=x_oCmd.Parameters.Add("@sku", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMigrateRule.sku==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderMigrateRule.sku; }
                _oPar=x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMigrateRule.ddate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderMigrateRule.ddate; }
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
        
        #region INSERT_MOBILEORDERMIGRATERULE Store Procedures
        ///-- =============================================
        ///-- Author:		<Author,Philip SW>
        ///-- Create date: <Create Date 2010-08-20>
        ///-- Description:	<Description,MOBILEORDERMIGRATERULE, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_MOBILEORDERMIGRATERULE Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_MOBILEORDERMIGRATERULE', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_MOBILEORDERMIGRATERULE;
        GO
        CREATE PROCEDURE INSERT_MOBILEORDERMIGRATERULE
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @cdate datetime,
        @cid nvarchar(50),
        @did nvarchar(50),
        @status nvarchar(50),
        @type nvarchar(50),
        @chk bit,
        @active bit,
        @name nvarchar(50),
        @sku nvarchar(50),
        @ddate datetime
        AS
        
        INSERT INTO  [MobileOrderMigrateRule]   ([cdate],[cid],[did],[status],[type],[chk],[active],[name],[sku],[ddate])  VALUES  (@cdate,@cid,@did,@status,@type,@chk,@active,@name,@sku,@ddate)
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
            string _sQuery = "DELETE FROM  [MobileOrderMigrateRule]  WHERE [MobileOrderMigrateRule].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMigrateRule]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMigrateRule]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult=false;
                _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = x_iId;
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
            return MobileOrderMigrateRuleRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileOrderMigrateRule]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMigrateRule]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMigrateRule]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
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
            string _sQuery = "DELETE FROM [MobileOrderMigrateRule]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMigrateRule]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMigrateRule]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
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


