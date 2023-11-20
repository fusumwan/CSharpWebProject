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
///-- Description:	<Description,Table :[BundleMapping],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [BundleMapping] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"BundleMapping")]
    public class BundleMappingRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static BundleMappingRepositoryBase instance;
        public static BundleMappingRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new BundleMappingRepositoryBase(_oDB);
            }
            return instance;
        }
        public static BundleMappingRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new BundleMappingRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<BundleMappingEntity> BundleMappings;
        #endregion
        
        #region Constructor
        public BundleMappingRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~BundleMappingRepositoryBase() { 
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
        public static BundleMapping CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new BundleMapping(_oDB);
        }
        
        public static BundleMapping CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new BundleMapping(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [BundleMapping]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BundleMapping]","["+ Configurator.MSSQLTablePrefix + "BundleMapping]"); }
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
        
        
        public BundleMappingEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }
        
        
        public static BundleMappingEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            if (x_oDB==null) { return null; }
            BundleMapping _BundleMapping = (BundleMapping)BundleMappingRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_BundleMapping.Load(x_iId)) { return null; }
            return _BundleMapping;
        }
        
        
        
        public static BundleMappingEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<BundleMappingEntity> _oBundleMappingList = GetListObj(x_oDB,0, "id", x_oArrayItemId);
            if(_oBundleMappingList==null){ return null;}
            return _oBundleMappingList.Count == 0 ? null : _oBundleMappingList.ToArray();
        }
        
        public static List<BundleMappingEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "id", x_oArrayItemId);
        }
        
        
        public static BundleMappingEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<BundleMappingEntity> _oBundleMappingList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oBundleMappingList==null){ return null;}
            return _oBundleMappingList.Count == 0 ? null : _oBundleMappingList.ToArray();
        }
        
        
        public static BundleMappingEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<BundleMappingEntity> _oBundleMappingList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oBundleMappingList==null){ return null;}
            return _oBundleMappingList.Count == 0 ? null : _oBundleMappingList.ToArray();
        }
        
        public static List<BundleMappingEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<BundleMappingEntity> _oRow = new List<BundleMappingEntity>();
            string _sQuery = "SELECT  "+_sTop+" [BundleMapping].[program] AS BUNDLEMAPPING_PROGRAM,[BundleMapping].[cdate] AS BUNDLEMAPPING_CDATE,[BundleMapping].[bundle_name] AS BUNDLEMAPPING_BUNDLE_NAME,[BundleMapping].[cid] AS BUNDLEMAPPING_CID,[BundleMapping].[did] AS BUNDLEMAPPING_DID,[BundleMapping].[retention_rebate] AS BUNDLEMAPPING_RETENTION_REBATE,[BundleMapping].[edate] AS BUNDLEMAPPING_EDATE,[BundleMapping].[active] AS BUNDLEMAPPING_ACTIVE,[BundleMapping].[issue_type] AS BUNDLEMAPPING_ISSUE_TYPE,[BundleMapping].[ddate] AS BUNDLEMAPPING_DDATE,[BundleMapping].[normal_rebate_type] AS BUNDLEMAPPING_NORMAL_REBATE_TYPE,[BundleMapping].[id] AS BUNDLEMAPPING_ID,[BundleMapping].[rate_plan] AS BUNDLEMAPPING_RATE_PLAN,[BundleMapping].[normal_rebate] AS BUNDLEMAPPING_NORMAL_REBATE,[BundleMapping].[hs_model] AS BUNDLEMAPPING_HS_MODEL,[BundleMapping].[vas_field] AS BUNDLEMAPPING_VAS_FIELD,[BundleMapping].[sdate] AS BUNDLEMAPPING_SDATE  FROM  [BundleMapping]";
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
                _sQuery += " WHERE [BundleMapping].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BundleMapping]","["+ Configurator.MSSQLTablePrefix + "BundleMapping]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        BundleMapping _oBundleMapping = BundleMappingRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_PROGRAM"])) {_oBundleMapping.program = (string)_oData["BUNDLEMAPPING_PROGRAM"]; }else{_oBundleMapping.program=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_CDATE"])) {_oBundleMapping.cdate = (global::System.Nullable<DateTime>)_oData["BUNDLEMAPPING_CDATE"]; }else{_oBundleMapping.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_BUNDLE_NAME"])) {_oBundleMapping.bundle_name = (string)_oData["BUNDLEMAPPING_BUNDLE_NAME"]; }else{_oBundleMapping.bundle_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_CID"])) {_oBundleMapping.cid = (string)_oData["BUNDLEMAPPING_CID"]; }else{_oBundleMapping.cid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_DID"])) {_oBundleMapping.did = (string)_oData["BUNDLEMAPPING_DID"]; }else{_oBundleMapping.did=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_RETENTION_REBATE"])) {_oBundleMapping.retention_rebate = (global::System.Nullable<int>)_oData["BUNDLEMAPPING_RETENTION_REBATE"]; }else{_oBundleMapping.retention_rebate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_EDATE"])) {_oBundleMapping.edate = (global::System.Nullable<DateTime>)_oData["BUNDLEMAPPING_EDATE"]; }else{_oBundleMapping.edate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_ACTIVE"])) {_oBundleMapping.active = (global::System.Nullable<bool>)_oData["BUNDLEMAPPING_ACTIVE"]; }else{_oBundleMapping.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_NORMAL_REBATE"])) {_oBundleMapping.normal_rebate = (global::System.Nullable<int>)_oData["BUNDLEMAPPING_NORMAL_REBATE"]; }else{_oBundleMapping.normal_rebate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_DDATE"])) {_oBundleMapping.ddate = (global::System.Nullable<DateTime>)_oData["BUNDLEMAPPING_DDATE"]; }else{_oBundleMapping.ddate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_NORMAL_REBATE_TYPE"])) {_oBundleMapping.normal_rebate_type = (string)_oData["BUNDLEMAPPING_NORMAL_REBATE_TYPE"]; }else{_oBundleMapping.normal_rebate_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_ID"])) {_oBundleMapping.id = (global::System.Nullable<int>)_oData["BUNDLEMAPPING_ID"]; }else{_oBundleMapping.id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_SDATE"])) {_oBundleMapping.sdate = (global::System.Nullable<DateTime>)_oData["BUNDLEMAPPING_SDATE"]; }else{_oBundleMapping.sdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_RATE_PLAN"])) {_oBundleMapping.rate_plan = (string)_oData["BUNDLEMAPPING_RATE_PLAN"]; }else{_oBundleMapping.rate_plan=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_VAS_FIELD"])) {_oBundleMapping.vas_field = (string)_oData["BUNDLEMAPPING_VAS_FIELD"]; }else{_oBundleMapping.vas_field=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_HS_MODEL"])) {_oBundleMapping.hs_model = (string)_oData["BUNDLEMAPPING_HS_MODEL"]; }else{_oBundleMapping.hs_model=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_ISSUE_TYPE"])) {_oBundleMapping.issue_type = (string)_oData["BUNDLEMAPPING_ISSUE_TYPE"]; }else{_oBundleMapping.issue_type=global::System.String.Empty;}
                        _oBundleMapping.SetDB(x_oDB);
                        _oBundleMapping.GetFound();
                        _oRow.Add(_oBundleMapping);
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
        
        
        public static BundleMappingEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<BundleMappingEntity> _oBundleMappingList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oBundleMappingList==null){ return null;}
            return _oBundleMappingList.Count == 0 ? null : _oBundleMappingList.ToArray();
        }
        
        
        public static BundleMappingEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<BundleMappingEntity> _oBundleMappingList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oBundleMappingList==null){ return null;}
            return _oBundleMappingList.Count == 0 ? null : _oBundleMappingList.ToArray();
        }
        
        public static List<BundleMappingEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<BundleMappingEntity> _oRow = new List<BundleMappingEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[BundleMapping].[program] AS BUNDLEMAPPING_PROGRAM,[BundleMapping].[cdate] AS BUNDLEMAPPING_CDATE,[BundleMapping].[bundle_name] AS BUNDLEMAPPING_BUNDLE_NAME,[BundleMapping].[cid] AS BUNDLEMAPPING_CID,[BundleMapping].[did] AS BUNDLEMAPPING_DID,[BundleMapping].[retention_rebate] AS BUNDLEMAPPING_RETENTION_REBATE,[BundleMapping].[edate] AS BUNDLEMAPPING_EDATE,[BundleMapping].[active] AS BUNDLEMAPPING_ACTIVE,[BundleMapping].[issue_type] AS BUNDLEMAPPING_ISSUE_TYPE,[BundleMapping].[ddate] AS BUNDLEMAPPING_DDATE,[BundleMapping].[normal_rebate_type] AS BUNDLEMAPPING_NORMAL_REBATE_TYPE,[BundleMapping].[id] AS BUNDLEMAPPING_ID,[BundleMapping].[rate_plan] AS BUNDLEMAPPING_RATE_PLAN,[BundleMapping].[normal_rebate] AS BUNDLEMAPPING_NORMAL_REBATE,[BundleMapping].[hs_model] AS BUNDLEMAPPING_HS_MODEL,[BundleMapping].[vas_field] AS BUNDLEMAPPING_VAS_FIELD,[BundleMapping].[sdate] AS BUNDLEMAPPING_SDATE";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[BundleMapping]","["+ Configurator.MSSQLTablePrefix + "BundleMapping]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = BundleMappingRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                BundleMappingEntity _oBundleMapping = BundleMappingRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_PROGRAM"])) {_oBundleMapping.program = (string)_oData["BUNDLEMAPPING_PROGRAM"]; } else {_oBundleMapping.program=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_CDATE"])) {_oBundleMapping.cdate = (global::System.Nullable<DateTime>)_oData["BUNDLEMAPPING_CDATE"]; } else {_oBundleMapping.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_BUNDLE_NAME"])) {_oBundleMapping.bundle_name = (string)_oData["BUNDLEMAPPING_BUNDLE_NAME"]; } else {_oBundleMapping.bundle_name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_CID"])) {_oBundleMapping.cid = (string)_oData["BUNDLEMAPPING_CID"]; } else {_oBundleMapping.cid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_DID"])) {_oBundleMapping.did = (string)_oData["BUNDLEMAPPING_DID"]; } else {_oBundleMapping.did=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_RETENTION_REBATE"])) {_oBundleMapping.retention_rebate = (global::System.Nullable<int>)_oData["BUNDLEMAPPING_RETENTION_REBATE"]; } else {_oBundleMapping.retention_rebate=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_EDATE"])) {_oBundleMapping.edate = (global::System.Nullable<DateTime>)_oData["BUNDLEMAPPING_EDATE"]; } else {_oBundleMapping.edate=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_ACTIVE"])) {_oBundleMapping.active = (global::System.Nullable<bool>)_oData["BUNDLEMAPPING_ACTIVE"]; } else {_oBundleMapping.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_NORMAL_REBATE"])) {_oBundleMapping.normal_rebate = (global::System.Nullable<int>)_oData["BUNDLEMAPPING_NORMAL_REBATE"]; } else {_oBundleMapping.normal_rebate=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_DDATE"])) {_oBundleMapping.ddate = (global::System.Nullable<DateTime>)_oData["BUNDLEMAPPING_DDATE"]; } else {_oBundleMapping.ddate=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_NORMAL_REBATE_TYPE"])) {_oBundleMapping.normal_rebate_type = (string)_oData["BUNDLEMAPPING_NORMAL_REBATE_TYPE"]; } else {_oBundleMapping.normal_rebate_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_ID"])) {_oBundleMapping.id = (global::System.Nullable<int>)_oData["BUNDLEMAPPING_ID"]; } else {_oBundleMapping.id=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_SDATE"])) {_oBundleMapping.sdate = (global::System.Nullable<DateTime>)_oData["BUNDLEMAPPING_SDATE"]; } else {_oBundleMapping.sdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_RATE_PLAN"])) {_oBundleMapping.rate_plan = (string)_oData["BUNDLEMAPPING_RATE_PLAN"]; } else {_oBundleMapping.rate_plan=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_VAS_FIELD"])) {_oBundleMapping.vas_field = (string)_oData["BUNDLEMAPPING_VAS_FIELD"]; } else {_oBundleMapping.vas_field=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_HS_MODEL"])) {_oBundleMapping.hs_model = (string)_oData["BUNDLEMAPPING_HS_MODEL"]; } else {_oBundleMapping.hs_model=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_ISSUE_TYPE"])) {_oBundleMapping.issue_type = (string)_oData["BUNDLEMAPPING_ISSUE_TYPE"]; } else {_oBundleMapping.issue_type=global::System.String.Empty; }
                _oBundleMapping.SetDB(x_oDB);
                _oBundleMapping.GetFound();
                _oRow.Add(_oBundleMapping);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( BundleMapping.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,BundleMapping.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(BundleMapping.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(BundleMapping.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [BundleMapping].[program] AS BUNDLEMAPPING_PROGRAM,[BundleMapping].[cdate] AS BUNDLEMAPPING_CDATE,[BundleMapping].[bundle_name] AS BUNDLEMAPPING_BUNDLE_NAME,[BundleMapping].[cid] AS BUNDLEMAPPING_CID,[BundleMapping].[did] AS BUNDLEMAPPING_DID,[BundleMapping].[retention_rebate] AS BUNDLEMAPPING_RETENTION_REBATE,[BundleMapping].[edate] AS BUNDLEMAPPING_EDATE,[BundleMapping].[active] AS BUNDLEMAPPING_ACTIVE,[BundleMapping].[issue_type] AS BUNDLEMAPPING_ISSUE_TYPE,[BundleMapping].[ddate] AS BUNDLEMAPPING_DDATE,[BundleMapping].[normal_rebate_type] AS BUNDLEMAPPING_NORMAL_REBATE_TYPE,[BundleMapping].[id] AS BUNDLEMAPPING_ID,[BundleMapping].[rate_plan] AS BUNDLEMAPPING_RATE_PLAN,[BundleMapping].[normal_rebate] AS BUNDLEMAPPING_NORMAL_REBATE,[BundleMapping].[hs_model] AS BUNDLEMAPPING_HS_MODEL,[BundleMapping].[vas_field] AS BUNDLEMAPPING_VAS_FIELD,[BundleMapping].[sdate] AS BUNDLEMAPPING_SDATE  FROM  [BundleMapping]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[BundleMapping]","["+ Configurator.MSSQLTablePrefix + "BundleMapping]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"BundleMapping");
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
        
        public bool Insert(string x_sProgram,global::System.Nullable<DateTime> x_dCdate,string x_sBundle_name,string x_sCid,string x_sDid,global::System.Nullable<int> x_iRetention_rebate,global::System.Nullable<DateTime> x_dEdate,global::System.Nullable<bool> x_bActive,global::System.Nullable<int> x_iNormal_rebate,global::System.Nullable<DateTime> x_dDdate,string x_sNormal_rebate_type,global::System.Nullable<DateTime> x_dSdate,string x_sRate_plan,string x_sVas_field,string x_sHs_model,string x_sIssue_type)
        {
            BundleMapping _oBundleMapping=BundleMappingRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oBundleMapping.program=x_sProgram;
            _oBundleMapping.cdate=x_dCdate;
            _oBundleMapping.bundle_name=x_sBundle_name;
            _oBundleMapping.cid=x_sCid;
            _oBundleMapping.did=x_sDid;
            _oBundleMapping.retention_rebate=x_iRetention_rebate;
            _oBundleMapping.edate=x_dEdate;
            _oBundleMapping.active=x_bActive;
            _oBundleMapping.normal_rebate=x_iNormal_rebate;
            _oBundleMapping.ddate=x_dDdate;
            _oBundleMapping.normal_rebate_type=x_sNormal_rebate_type;
            _oBundleMapping.sdate=x_dSdate;
            _oBundleMapping.rate_plan=x_sRate_plan;
            _oBundleMapping.vas_field=x_sVas_field;
            _oBundleMapping.hs_model=x_sHs_model;
            _oBundleMapping.issue_type=x_sIssue_type;
            return InsertWithOutLastID(n_oDB, _oBundleMapping);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sProgram,global::System.Nullable<DateTime> x_dCdate,string x_sBundle_name,string x_sCid,string x_sDid,global::System.Nullable<int> x_iRetention_rebate,global::System.Nullable<DateTime> x_dEdate,global::System.Nullable<bool> x_bActive,global::System.Nullable<int> x_iNormal_rebate,global::System.Nullable<DateTime> x_dDdate,string x_sNormal_rebate_type,global::System.Nullable<DateTime> x_dSdate,string x_sRate_plan,string x_sVas_field,string x_sHs_model,string x_sIssue_type)
        {
            BundleMapping _oBundleMapping=BundleMappingRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oBundleMapping.program=x_sProgram;
            _oBundleMapping.cdate=x_dCdate;
            _oBundleMapping.bundle_name=x_sBundle_name;
            _oBundleMapping.cid=x_sCid;
            _oBundleMapping.did=x_sDid;
            _oBundleMapping.retention_rebate=x_iRetention_rebate;
            _oBundleMapping.edate=x_dEdate;
            _oBundleMapping.active=x_bActive;
            _oBundleMapping.normal_rebate=x_iNormal_rebate;
            _oBundleMapping.ddate=x_dDdate;
            _oBundleMapping.normal_rebate_type=x_sNormal_rebate_type;
            _oBundleMapping.sdate=x_dSdate;
            _oBundleMapping.rate_plan=x_sRate_plan;
            _oBundleMapping.vas_field=x_sVas_field;
            _oBundleMapping.hs_model=x_sHs_model;
            _oBundleMapping.issue_type=x_sIssue_type;
            return InsertWithOutLastID(x_oDB, _oBundleMapping);
        }
        
        
        public bool Insert(BundleMapping x_oBundleMapping)
        {
            return InsertWithOutLastID(n_oDB, x_oBundleMapping);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is BundleMapping)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (BundleMapping)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,BundleMapping x_oBundleMapping)
        {
            return InsertWithOutLastID(x_oDB, x_oBundleMapping);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,BundleMapping x_oBundleMapping)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [BundleMapping]   ([program],[cdate],[bundle_name],[cid],[did],[retention_rebate],[edate],[active],[issue_type],[ddate],[normal_rebate_type],[rate_plan],[normal_rebate],[hs_model],[vas_field],[sdate])  VALUES  (@program,@cdate,@bundle_name,@cid,@did,@retention_rebate,@edate,@active,@issue_type,@ddate,@normal_rebate_type,@rate_plan,@normal_rebate,@hs_model,@vas_field,@sdate)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BundleMapping]","["+ Configurator.MSSQLTablePrefix + "BundleMapping]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oBundleMapping);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,BundleMapping x_oBundleMapping)
        {
            bool _bResult = false;
            if (!x_oBundleMapping.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oBundleMapping.program==null){  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBundleMapping.program; }
                if(x_oBundleMapping.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oBundleMapping.cdate; }
                if(x_oBundleMapping.bundle_name==null){  x_oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,70).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,70).Value=x_oBundleMapping.bundle_name; }
                if(x_oBundleMapping.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,20).Value=x_oBundleMapping.cid; }
                if(x_oBundleMapping.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,20).Value=x_oBundleMapping.did; }
                if(x_oBundleMapping.retention_rebate==null){  x_oCmd.Parameters.Add("@retention_rebate", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retention_rebate", global::System.Data.SqlDbType.Int).Value=x_oBundleMapping.retention_rebate; }
                if(x_oBundleMapping.edate==null){  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=x_oBundleMapping.edate; }
                if(x_oBundleMapping.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oBundleMapping.active; }
                if(x_oBundleMapping.issue_type==null){  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBundleMapping.issue_type; }
                if(x_oBundleMapping.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oBundleMapping.ddate; }
                if(x_oBundleMapping.normal_rebate_type==null){  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value=x_oBundleMapping.normal_rebate_type; }
                if(x_oBundleMapping.rate_plan==null){  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,40).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,40).Value=x_oBundleMapping.rate_plan; }
                if(x_oBundleMapping.normal_rebate==null){  x_oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Int).Value=x_oBundleMapping.normal_rebate; }
                if(x_oBundleMapping.hs_model==null){  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBundleMapping.hs_model; }
                if(x_oBundleMapping.vas_field==null){  x_oCmd.Parameters.Add("@vas_field", global::System.Data.SqlDbType.NVarChar,40).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@vas_field", global::System.Data.SqlDbType.NVarChar,40).Value=x_oBundleMapping.vas_field; }
                if(x_oBundleMapping.sdate==null){  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value=x_oBundleMapping.sdate; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,string x_sProgram,global::System.Nullable<DateTime> x_dCdate,string x_sBundle_name,string x_sCid,string x_sDid,global::System.Nullable<int> x_iRetention_rebate,global::System.Nullable<DateTime> x_dEdate,global::System.Nullable<bool> x_bActive,global::System.Nullable<int> x_iNormal_rebate,global::System.Nullable<DateTime> x_dDdate,string x_sNormal_rebate_type,global::System.Nullable<DateTime> x_dSdate,string x_sRate_plan,string x_sVas_field,string x_sHs_model,string x_sIssue_type)
        {
            int _oLastID;
            BundleMapping _oBundleMapping=BundleMappingRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oBundleMapping.program=x_sProgram;
            _oBundleMapping.cdate=x_dCdate;
            _oBundleMapping.bundle_name=x_sBundle_name;
            _oBundleMapping.cid=x_sCid;
            _oBundleMapping.did=x_sDid;
            _oBundleMapping.retention_rebate=x_iRetention_rebate;
            _oBundleMapping.edate=x_dEdate;
            _oBundleMapping.active=x_bActive;
            _oBundleMapping.normal_rebate=x_iNormal_rebate;
            _oBundleMapping.ddate=x_dDdate;
            _oBundleMapping.normal_rebate_type=x_sNormal_rebate_type;
            _oBundleMapping.sdate=x_dSdate;
            _oBundleMapping.rate_plan=x_sRate_plan;
            _oBundleMapping.vas_field=x_sVas_field;
            _oBundleMapping.hs_model=x_sHs_model;
            _oBundleMapping.issue_type=x_sIssue_type;
            if(InsertWithLastID(x_oDB, _oBundleMapping,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(BundleMapping x_oBundleMapping)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oBundleMapping, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, BundleMapping x_oBundleMapping)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oBundleMapping, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is BundleMapping)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (BundleMapping)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,BundleMapping x_oBundleMapping, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [BundleMapping]   ([program],[cdate],[bundle_name],[cid],[did],[retention_rebate],[edate],[active],[issue_type],[ddate],[normal_rebate_type],[rate_plan],[normal_rebate],[hs_model],[vas_field],[sdate])  VALUES  (@program,@cdate,@bundle_name,@cid,@did,@retention_rebate,@edate,@active,@issue_type,@ddate,@normal_rebate_type,@rate_plan,@normal_rebate,@hs_model,@vas_field,@sdate)"+" SELECT  @@IDENTITY AS BundleMapping_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BundleMapping]","["+ Configurator.MSSQLTablePrefix + "BundleMapping]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oBundleMapping,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,BundleMapping x_oBundleMapping, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oBundleMapping.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oBundleMapping.program==null){  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBundleMapping.program; }
                if(x_oBundleMapping.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oBundleMapping.cdate; }
                if(x_oBundleMapping.bundle_name==null){  x_oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,70).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,70).Value=x_oBundleMapping.bundle_name; }
                if(x_oBundleMapping.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,20).Value=x_oBundleMapping.cid; }
                if(x_oBundleMapping.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,20).Value=x_oBundleMapping.did; }
                if(x_oBundleMapping.retention_rebate==null){  x_oCmd.Parameters.Add("@retention_rebate", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retention_rebate", global::System.Data.SqlDbType.Int).Value=x_oBundleMapping.retention_rebate; }
                if(x_oBundleMapping.edate==null){  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=x_oBundleMapping.edate; }
                if(x_oBundleMapping.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oBundleMapping.active; }
                if(x_oBundleMapping.issue_type==null){  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBundleMapping.issue_type; }
                if(x_oBundleMapping.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oBundleMapping.ddate; }
                if(x_oBundleMapping.normal_rebate_type==null){  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value=x_oBundleMapping.normal_rebate_type; }
                if(x_oBundleMapping.rate_plan==null){  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,40).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,40).Value=x_oBundleMapping.rate_plan; }
                if(x_oBundleMapping.normal_rebate==null){  x_oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Int).Value=x_oBundleMapping.normal_rebate; }
                if(x_oBundleMapping.hs_model==null){  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBundleMapping.hs_model; }
                if(x_oBundleMapping.vas_field==null){  x_oCmd.Parameters.Add("@vas_field", global::System.Data.SqlDbType.NVarChar,40).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@vas_field", global::System.Data.SqlDbType.NVarChar,40).Value=x_oBundleMapping.vas_field; }
                if(x_oBundleMapping.sdate==null){  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value=x_oBundleMapping.sdate; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["BundleMapping_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["BundleMapping_LASTID"].ToString()) && int.TryParse(_oData["BundleMapping_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sProgram,global::System.Nullable<DateTime> x_dCdate,string x_sBundle_name,string x_sCid,string x_sDid,global::System.Nullable<int> x_iRetention_rebate,global::System.Nullable<DateTime> x_dEdate,global::System.Nullable<bool> x_bActive,global::System.Nullable<int> x_iNormal_rebate,global::System.Nullable<DateTime> x_dDdate,string x_sNormal_rebate_type,global::System.Nullable<DateTime> x_dSdate,string x_sRate_plan,string x_sVas_field,string x_sHs_model,string x_sIssue_type)
        {
            int _oLastID;
            BundleMapping _oBundleMapping=BundleMappingRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oBundleMapping.program=x_sProgram;
            _oBundleMapping.cdate=x_dCdate;
            _oBundleMapping.bundle_name=x_sBundle_name;
            _oBundleMapping.cid=x_sCid;
            _oBundleMapping.did=x_sDid;
            _oBundleMapping.retention_rebate=x_iRetention_rebate;
            _oBundleMapping.edate=x_dEdate;
            _oBundleMapping.active=x_bActive;
            _oBundleMapping.normal_rebate=x_iNormal_rebate;
            _oBundleMapping.ddate=x_dDdate;
            _oBundleMapping.normal_rebate_type=x_sNormal_rebate_type;
            _oBundleMapping.sdate=x_dSdate;
            _oBundleMapping.rate_plan=x_sRate_plan;
            _oBundleMapping.vas_field=x_sVas_field;
            _oBundleMapping.hs_model=x_sHs_model;
            _oBundleMapping.issue_type=x_sIssue_type;
            if(InsertWithLastID_SP(x_oDB, _oBundleMapping,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(BundleMapping x_oBundleMapping)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oBundleMapping, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, BundleMapping x_oBundleMapping)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oBundleMapping, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is BundleMapping)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (BundleMapping)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,BundleMapping x_oBundleMapping, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "BUNDLEMAPPING";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oBundleMapping,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,BundleMapping x_oBundleMapping, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBundleMapping.program==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBundleMapping.program; }
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBundleMapping.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oBundleMapping.cdate; }
                _oPar=x_oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,70);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBundleMapping.bundle_name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBundleMapping.bundle_name; }
                _oPar=x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBundleMapping.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBundleMapping.cid; }
                _oPar=x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBundleMapping.did==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBundleMapping.did; }
                _oPar=x_oCmd.Parameters.Add("@retention_rebate", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBundleMapping.retention_rebate==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBundleMapping.retention_rebate; }
                _oPar=x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBundleMapping.edate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oBundleMapping.edate; }
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBundleMapping.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBundleMapping.active; }
                _oPar=x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBundleMapping.issue_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBundleMapping.issue_type; }
                _oPar=x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBundleMapping.ddate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oBundleMapping.ddate; }
                _oPar=x_oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBundleMapping.normal_rebate_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBundleMapping.normal_rebate_type; }
                _oPar=x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,40);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBundleMapping.rate_plan==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBundleMapping.rate_plan; }
                _oPar=x_oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBundleMapping.normal_rebate==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBundleMapping.normal_rebate; }
                _oPar=x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBundleMapping.hs_model==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBundleMapping.hs_model; }
                _oPar=x_oCmd.Parameters.Add("@vas_field", global::System.Data.SqlDbType.NVarChar,40);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBundleMapping.vas_field==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBundleMapping.vas_field; }
                _oPar=x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBundleMapping.sdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oBundleMapping.sdate; }
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
        
        #region INSERT_BUNDLEMAPPING Store Procedures
        ///-- =============================================
        ///-- Author:		<Author,Philip SW>
        ///-- Create date: <Create Date 2011-07-14>
        ///-- Description:	<Description,BUNDLEMAPPING, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_BUNDLEMAPPING Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_BUNDLEMAPPING', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_BUNDLEMAPPING;
        GO
        CREATE PROCEDURE INSERT_BUNDLEMAPPING
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @program nvarchar(50),
        @cdate datetime,
        @bundle_name nvarchar(70),
        @cid nvarchar(20),
        @did nvarchar(20),
        @retention_rebate int,
        @edate datetime,
        @active bit,
        @normal_rebate int,
        @ddate datetime,
        @normal_rebate_type nvarchar(100),
        @sdate datetime,
        @rate_plan nvarchar(40),
        @vas_field nvarchar(40),
        @hs_model nvarchar(250),
        @issue_type nvarchar(50)
        AS
        
        INSERT INTO  [BundleMapping]   ([program],[cdate],[bundle_name],[cid],[did],[retention_rebate],[edate],[active],[issue_type],[ddate],[normal_rebate_type],[rate_plan],[normal_rebate],[hs_model],[vas_field],[sdate])  VALUES  (@program,@cdate,@bundle_name,@cid,@did,@retention_rebate,@edate,@active,@issue_type,@ddate,@normal_rebate_type,@rate_plan,@normal_rebate,@hs_model,@vas_field,@sdate)
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
            string _sQuery = "DELETE FROM  [BundleMapping]  WHERE [BundleMapping].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BundleMapping]","["+ Configurator.MSSQLTablePrefix + "BundleMapping]"); }
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
            return BundleMappingRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [BundleMapping]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BundleMapping]","["+ Configurator.MSSQLTablePrefix + "BundleMapping]"); }
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
            string _sQuery = "DELETE FROM [BundleMapping]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BundleMapping]","["+ Configurator.MSSQLTablePrefix + "BundleMapping]"); }
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


