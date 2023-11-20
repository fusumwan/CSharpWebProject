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
///-- Create date: <Create Date 2010-12-10>
///-- Description:	<Description,Table :[MobileOrderSyncSearch],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderSyncSearch] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"MobileOrderSyncSearch")]
    public class MobileOrderSyncSearchRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static MobileOrderSyncSearchRepositoryBase instance;
        public static MobileOrderSyncSearchRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new MobileOrderSyncSearchRepositoryBase(_oDB);
            }
            return instance;
        }
        public static MobileOrderSyncSearchRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new MobileOrderSyncSearchRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<MobileOrderSyncSearchEntity> MobileOrderSyncSearchs;
        #endregion
        
        #region Constructor
        public MobileOrderSyncSearchRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~MobileOrderSyncSearchRepositoryBase() { 
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
        public static MobileOrderSyncSearch CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new MobileOrderSyncSearch(_oDB);
        }
        
        public static MobileOrderSyncSearch CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new MobileOrderSyncSearch(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [MobileOrderSyncSearch]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderSyncSearch]","["+ Configurator.MSSQLTablePrefix + "MobileOrderSyncSearch]"); }
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
        
        
        public MobileOrderSyncSearchEntity GetObj(global::System.Nullable<int> x_iOrder_id)
        {
            return GetObj(n_oDB, x_iOrder_id);
        }
        
        
        public static MobileOrderSyncSearchEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iOrder_id)
        {
            if (x_oDB==null) { return null; }
            MobileOrderSyncSearch _MobileOrderSyncSearch = (MobileOrderSyncSearch)MobileOrderSyncSearchRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_MobileOrderSyncSearch.Load(x_iOrder_id)) { return null; }
            return _MobileOrderSyncSearch;
        }
        
        
        
        public static MobileOrderSyncSearchEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<MobileOrderSyncSearchEntity> _oMobileOrderSyncSearchList = GetListObj(x_oDB,0, "order_id", x_oArrayItemId);
            if(_oMobileOrderSyncSearchList==null){ return null;}
            return _oMobileOrderSyncSearchList.Count == 0 ? null : _oMobileOrderSyncSearchList.ToArray();
        }
        
        public static List<MobileOrderSyncSearchEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "order_id", x_oArrayItemId);
        }
        
        
        public static MobileOrderSyncSearchEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderSyncSearchEntity> _oMobileOrderSyncSearchList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderSyncSearchList==null){ return null;}
            return _oMobileOrderSyncSearchList.Count == 0 ? null : _oMobileOrderSyncSearchList.ToArray();
        }
        
        
        public static MobileOrderSyncSearchEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderSyncSearchEntity> _oMobileOrderSyncSearchList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderSyncSearchList==null){ return null;}
            return _oMobileOrderSyncSearchList.Count == 0 ? null : _oMobileOrderSyncSearchList.ToArray();
        }
        
        public static List<MobileOrderSyncSearchEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<MobileOrderSyncSearchEntity> _oRow = new List<MobileOrderSyncSearchEntity>();
            string _sQuery = "SELECT  "+_sTop+" [MobileOrderSyncSearch].[edf_no] AS MOBILEORDERSYNCSEARCH_EDF_NO,[MobileOrderSyncSearch].[active] AS MOBILEORDERSYNCSEARCH_ACTIVE,[MobileOrderSyncSearch].[sku] AS MOBILEORDERSYNCSEARCH_SKU,[MobileOrderSyncSearch].[sim_item_name] AS MOBILEORDERSYNCSEARCH_SIM_ITEM_NAME,[MobileOrderSyncSearch].[d_date] AS MOBILEORDERSYNCSEARCH_D_DATE,[MobileOrderSyncSearch].[program] AS MOBILEORDERSYNCSEARCH_PROGRAM,[MobileOrderSyncSearch].[order_id] AS MOBILEORDERSYNCSEARCH_ORDER_ID,[MobileOrderSyncSearch].[sim_item_code] AS MOBILEORDERSYNCSEARCH_SIM_ITEM_CODE,[MobileOrderSyncSearch].[imei_no] AS MOBILEORDERSYNCSEARCH_IMEI_NO  FROM  [MobileOrderSyncSearch]";
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
                _sQuery += " WHERE [MobileOrderSyncSearch].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderSyncSearch]","["+ Configurator.MSSQLTablePrefix + "MobileOrderSyncSearch]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        MobileOrderSyncSearch _oMobileOrderSyncSearch = MobileOrderSyncSearchRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_ACTIVE"])) {_oMobileOrderSyncSearch.active = (global::System.Nullable<bool>)_oData["MOBILEORDERSYNCSEARCH_ACTIVE"]; }else{_oMobileOrderSyncSearch.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_SKU"])) {_oMobileOrderSyncSearch.sku = (string)_oData["MOBILEORDERSYNCSEARCH_SKU"]; }else{_oMobileOrderSyncSearch.sku=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_PROGRAM"])) {_oMobileOrderSyncSearch.program = (string)_oData["MOBILEORDERSYNCSEARCH_PROGRAM"]; }else{_oMobileOrderSyncSearch.program=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_SIM_ITEM_NAME"])) {_oMobileOrderSyncSearch.sim_item_name = (string)_oData["MOBILEORDERSYNCSEARCH_SIM_ITEM_NAME"]; }else{_oMobileOrderSyncSearch.sim_item_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_D_DATE"])) {_oMobileOrderSyncSearch.d_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERSYNCSEARCH_D_DATE"]; }else{_oMobileOrderSyncSearch.d_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_EDF_NO"])) {_oMobileOrderSyncSearch.edf_no = (string)_oData["MOBILEORDERSYNCSEARCH_EDF_NO"]; }else{_oMobileOrderSyncSearch.edf_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_ORDER_ID"])) {_oMobileOrderSyncSearch.order_id = (global::System.Nullable<int>)_oData["MOBILEORDERSYNCSEARCH_ORDER_ID"]; }else{_oMobileOrderSyncSearch.order_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_SIM_ITEM_CODE"])) {_oMobileOrderSyncSearch.sim_item_code = (string)_oData["MOBILEORDERSYNCSEARCH_SIM_ITEM_CODE"]; }else{_oMobileOrderSyncSearch.sim_item_code=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_IMEI_NO"])) {_oMobileOrderSyncSearch.imei_no = (string)_oData["MOBILEORDERSYNCSEARCH_IMEI_NO"]; }else{_oMobileOrderSyncSearch.imei_no=global::System.String.Empty;}
                        _oMobileOrderSyncSearch.SetDB(x_oDB);
                        _oMobileOrderSyncSearch.GetFound();
                        _oRow.Add(_oMobileOrderSyncSearch);
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
        
        
        public static MobileOrderSyncSearchEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderSyncSearchEntity> _oMobileOrderSyncSearchList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderSyncSearchList==null){ return null;}
            return _oMobileOrderSyncSearchList.Count == 0 ? null : _oMobileOrderSyncSearchList.ToArray();
        }
        
        
        public static MobileOrderSyncSearchEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderSyncSearchEntity> _oMobileOrderSyncSearchList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderSyncSearchList==null){ return null;}
            return _oMobileOrderSyncSearchList.Count == 0 ? null : _oMobileOrderSyncSearchList.ToArray();
        }
        
        public static List<MobileOrderSyncSearchEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<MobileOrderSyncSearchEntity> _oRow = new List<MobileOrderSyncSearchEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[MobileOrderSyncSearch].[edf_no] AS MOBILEORDERSYNCSEARCH_EDF_NO,[MobileOrderSyncSearch].[active] AS MOBILEORDERSYNCSEARCH_ACTIVE,[MobileOrderSyncSearch].[sku] AS MOBILEORDERSYNCSEARCH_SKU,[MobileOrderSyncSearch].[sim_item_name] AS MOBILEORDERSYNCSEARCH_SIM_ITEM_NAME,[MobileOrderSyncSearch].[d_date] AS MOBILEORDERSYNCSEARCH_D_DATE,[MobileOrderSyncSearch].[program] AS MOBILEORDERSYNCSEARCH_PROGRAM,[MobileOrderSyncSearch].[order_id] AS MOBILEORDERSYNCSEARCH_ORDER_ID,[MobileOrderSyncSearch].[sim_item_code] AS MOBILEORDERSYNCSEARCH_SIM_ITEM_CODE,[MobileOrderSyncSearch].[imei_no] AS MOBILEORDERSYNCSEARCH_IMEI_NO";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[MobileOrderSyncSearch]","["+ Configurator.MSSQLTablePrefix + "MobileOrderSyncSearch]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = MobileOrderSyncSearchRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                MobileOrderSyncSearchEntity _oMobileOrderSyncSearch = MobileOrderSyncSearchRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_ACTIVE"])) {_oMobileOrderSyncSearch.active = (global::System.Nullable<bool>)_oData["MOBILEORDERSYNCSEARCH_ACTIVE"]; } else {_oMobileOrderSyncSearch.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_SKU"])) {_oMobileOrderSyncSearch.sku = (string)_oData["MOBILEORDERSYNCSEARCH_SKU"]; } else {_oMobileOrderSyncSearch.sku=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_PROGRAM"])) {_oMobileOrderSyncSearch.program = (string)_oData["MOBILEORDERSYNCSEARCH_PROGRAM"]; } else {_oMobileOrderSyncSearch.program=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_SIM_ITEM_NAME"])) {_oMobileOrderSyncSearch.sim_item_name = (string)_oData["MOBILEORDERSYNCSEARCH_SIM_ITEM_NAME"]; } else {_oMobileOrderSyncSearch.sim_item_name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_D_DATE"])) {_oMobileOrderSyncSearch.d_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERSYNCSEARCH_D_DATE"]; } else {_oMobileOrderSyncSearch.d_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_EDF_NO"])) {_oMobileOrderSyncSearch.edf_no = (string)_oData["MOBILEORDERSYNCSEARCH_EDF_NO"]; } else {_oMobileOrderSyncSearch.edf_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_ORDER_ID"])) {_oMobileOrderSyncSearch.order_id = (global::System.Nullable<int>)_oData["MOBILEORDERSYNCSEARCH_ORDER_ID"]; } else {_oMobileOrderSyncSearch.order_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_SIM_ITEM_CODE"])) {_oMobileOrderSyncSearch.sim_item_code = (string)_oData["MOBILEORDERSYNCSEARCH_SIM_ITEM_CODE"]; } else {_oMobileOrderSyncSearch.sim_item_code=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_IMEI_NO"])) {_oMobileOrderSyncSearch.imei_no = (string)_oData["MOBILEORDERSYNCSEARCH_IMEI_NO"]; } else {_oMobileOrderSyncSearch.imei_no=global::System.String.Empty; }
                _oMobileOrderSyncSearch.SetDB(x_oDB);
                _oMobileOrderSyncSearch.GetFound();
                _oRow.Add(_oMobileOrderSyncSearch);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( MobileOrderSyncSearch.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,MobileOrderSyncSearch.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(MobileOrderSyncSearch.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(MobileOrderSyncSearch.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [MobileOrderSyncSearch].[edf_no] AS MOBILEORDERSYNCSEARCH_EDF_NO,[MobileOrderSyncSearch].[active] AS MOBILEORDERSYNCSEARCH_ACTIVE,[MobileOrderSyncSearch].[sku] AS MOBILEORDERSYNCSEARCH_SKU,[MobileOrderSyncSearch].[sim_item_name] AS MOBILEORDERSYNCSEARCH_SIM_ITEM_NAME,[MobileOrderSyncSearch].[d_date] AS MOBILEORDERSYNCSEARCH_D_DATE,[MobileOrderSyncSearch].[program] AS MOBILEORDERSYNCSEARCH_PROGRAM,[MobileOrderSyncSearch].[order_id] AS MOBILEORDERSYNCSEARCH_ORDER_ID,[MobileOrderSyncSearch].[sim_item_code] AS MOBILEORDERSYNCSEARCH_SIM_ITEM_CODE,[MobileOrderSyncSearch].[imei_no] AS MOBILEORDERSYNCSEARCH_IMEI_NO  FROM  [MobileOrderSyncSearch]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[MobileOrderSyncSearch]","["+ Configurator.MSSQLTablePrefix + "MobileOrderSyncSearch]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"MobileOrderSyncSearch");
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
        
        public bool Insert(global::System.Nullable<bool> x_bActive,string x_sSku,string x_sProgram,string x_sSim_item_name,global::System.Nullable<DateTime> x_dD_date,string x_sEdf_no,string x_sSim_item_code,string x_sImei_no)
        {
            MobileOrderSyncSearch _oMobileOrderSyncSearch=MobileOrderSyncSearchRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oMobileOrderSyncSearch.active=x_bActive;
            _oMobileOrderSyncSearch.sku=x_sSku;
            _oMobileOrderSyncSearch.program=x_sProgram;
            _oMobileOrderSyncSearch.sim_item_name=x_sSim_item_name;
            _oMobileOrderSyncSearch.d_date=x_dD_date;
            _oMobileOrderSyncSearch.edf_no=x_sEdf_no;
            _oMobileOrderSyncSearch.sim_item_code=x_sSim_item_code;
            _oMobileOrderSyncSearch.imei_no=x_sImei_no;
            return InsertWithOutLastID(n_oDB, _oMobileOrderSyncSearch);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bActive,string x_sSku,string x_sProgram,string x_sSim_item_name,global::System.Nullable<DateTime> x_dD_date,string x_sEdf_no,string x_sSim_item_code,string x_sImei_no)
        {
            MobileOrderSyncSearch _oMobileOrderSyncSearch=MobileOrderSyncSearchRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderSyncSearch.active=x_bActive;
            _oMobileOrderSyncSearch.sku=x_sSku;
            _oMobileOrderSyncSearch.program=x_sProgram;
            _oMobileOrderSyncSearch.sim_item_name=x_sSim_item_name;
            _oMobileOrderSyncSearch.d_date=x_dD_date;
            _oMobileOrderSyncSearch.edf_no=x_sEdf_no;
            _oMobileOrderSyncSearch.sim_item_code=x_sSim_item_code;
            _oMobileOrderSyncSearch.imei_no=x_sImei_no;
            return InsertWithOutLastID(x_oDB, _oMobileOrderSyncSearch);
        }
        
        
        public bool Insert(MobileOrderSyncSearch x_oMobileOrderSyncSearch)
        {
            return InsertWithOutLastID(n_oDB, x_oMobileOrderSyncSearch);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is MobileOrderSyncSearch)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (MobileOrderSyncSearch)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,MobileOrderSyncSearch x_oMobileOrderSyncSearch)
        {
            return InsertWithOutLastID(x_oDB, x_oMobileOrderSyncSearch);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderSyncSearch x_oMobileOrderSyncSearch)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderSyncSearch]   ([edf_no],[active],[sku],[sim_item_name],[d_date],[program],[sim_item_code],[imei_no])  VALUES  (@edf_no,@active,@sku,@sim_item_name,@d_date,@program,@sim_item_code,@imei_no)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderSyncSearch]","["+ Configurator.MSSQLTablePrefix + "MobileOrderSyncSearch]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderSyncSearch);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderSyncSearch x_oMobileOrderSyncSearch)
        {
            bool _bResult = false;
            if (!x_oMobileOrderSyncSearch.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderSyncSearch.edf_no==null){  x_oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,15).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,15).Value=x_oMobileOrderSyncSearch.edf_no; }
                if(x_oMobileOrderSyncSearch.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderSyncSearch.active; }
                if(x_oMobileOrderSyncSearch.sku==null){  x_oCmd.Parameters.Add("@sku", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sku", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderSyncSearch.sku; }
                if(x_oMobileOrderSyncSearch.sim_item_name==null){  x_oCmd.Parameters.Add("@sim_item_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sim_item_name", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderSyncSearch.sim_item_name; }
                if(x_oMobileOrderSyncSearch.d_date==null){  x_oCmd.Parameters.Add("@d_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@d_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderSyncSearch.d_date; }
                if(x_oMobileOrderSyncSearch.program==null){  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderSyncSearch.program; }
                if(x_oMobileOrderSyncSearch.sim_item_code==null){  x_oCmd.Parameters.Add("@sim_item_code", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sim_item_code", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderSyncSearch.sim_item_code; }
                if(x_oMobileOrderSyncSearch.imei_no==null){  x_oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileOrderSyncSearch.imei_no; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,global::System.Nullable<bool> x_bActive,string x_sSku,string x_sProgram,string x_sSim_item_name,global::System.Nullable<DateTime> x_dD_date,string x_sEdf_no,string x_sSim_item_code,string x_sImei_no)
        {
            int _oLastID;
            MobileOrderSyncSearch _oMobileOrderSyncSearch=MobileOrderSyncSearchRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderSyncSearch.active=x_bActive;
            _oMobileOrderSyncSearch.sku=x_sSku;
            _oMobileOrderSyncSearch.program=x_sProgram;
            _oMobileOrderSyncSearch.sim_item_name=x_sSim_item_name;
            _oMobileOrderSyncSearch.d_date=x_dD_date;
            _oMobileOrderSyncSearch.edf_no=x_sEdf_no;
            _oMobileOrderSyncSearch.sim_item_code=x_sSim_item_code;
            _oMobileOrderSyncSearch.imei_no=x_sImei_no;
            if(InsertWithLastID(x_oDB, _oMobileOrderSyncSearch,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(MobileOrderSyncSearch x_oMobileOrderSyncSearch)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oMobileOrderSyncSearch, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, MobileOrderSyncSearch x_oMobileOrderSyncSearch)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oMobileOrderSyncSearch, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderSyncSearch)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (MobileOrderSyncSearch)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,MobileOrderSyncSearch x_oMobileOrderSyncSearch, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderSyncSearch]   ([edf_no],[active],[sku],[sim_item_name],[d_date],[program],[sim_item_code],[imei_no])  VALUES  (@edf_no,@active,@sku,@sim_item_name,@d_date,@program,@sim_item_code,@imei_no)"+" SELECT  @@IDENTITY AS MobileOrderSyncSearch_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderSyncSearch]","["+ Configurator.MSSQLTablePrefix + "MobileOrderSyncSearch]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderSyncSearch,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderSyncSearch x_oMobileOrderSyncSearch, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oMobileOrderSyncSearch.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderSyncSearch.edf_no==null){  x_oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,15).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,15).Value=x_oMobileOrderSyncSearch.edf_no; }
                if(x_oMobileOrderSyncSearch.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderSyncSearch.active; }
                if(x_oMobileOrderSyncSearch.sku==null){  x_oCmd.Parameters.Add("@sku", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sku", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderSyncSearch.sku; }
                if(x_oMobileOrderSyncSearch.sim_item_name==null){  x_oCmd.Parameters.Add("@sim_item_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sim_item_name", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderSyncSearch.sim_item_name; }
                if(x_oMobileOrderSyncSearch.d_date==null){  x_oCmd.Parameters.Add("@d_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@d_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderSyncSearch.d_date; }
                if(x_oMobileOrderSyncSearch.program==null){  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderSyncSearch.program; }
                if(x_oMobileOrderSyncSearch.sim_item_code==null){  x_oCmd.Parameters.Add("@sim_item_code", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sim_item_code", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderSyncSearch.sim_item_code; }
                if(x_oMobileOrderSyncSearch.imei_no==null){  x_oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileOrderSyncSearch.imei_no; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["MobileOrderSyncSearch_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["MobileOrderSyncSearch_LASTID"].ToString()) && int.TryParse(_oData["MobileOrderSyncSearch_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<bool> x_bActive,string x_sSku,string x_sProgram,string x_sSim_item_name,global::System.Nullable<DateTime> x_dD_date,string x_sEdf_no,string x_sSim_item_code,string x_sImei_no)
        {
            int _oLastID;
            MobileOrderSyncSearch _oMobileOrderSyncSearch=MobileOrderSyncSearchRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderSyncSearch.active=x_bActive;
            _oMobileOrderSyncSearch.sku=x_sSku;
            _oMobileOrderSyncSearch.program=x_sProgram;
            _oMobileOrderSyncSearch.sim_item_name=x_sSim_item_name;
            _oMobileOrderSyncSearch.d_date=x_dD_date;
            _oMobileOrderSyncSearch.edf_no=x_sEdf_no;
            _oMobileOrderSyncSearch.sim_item_code=x_sSim_item_code;
            _oMobileOrderSyncSearch.imei_no=x_sImei_no;
            if(InsertWithLastID_SP(x_oDB, _oMobileOrderSyncSearch,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(MobileOrderSyncSearch x_oMobileOrderSyncSearch)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oMobileOrderSyncSearch, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderSyncSearch x_oMobileOrderSyncSearch)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oMobileOrderSyncSearch, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderSyncSearch)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (MobileOrderSyncSearch)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,MobileOrderSyncSearch x_oMobileOrderSyncSearch, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "MOBILEORDERSYNCSEARCH";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oMobileOrderSyncSearch,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderSyncSearch x_oMobileOrderSyncSearch, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,15);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderSyncSearch.edf_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderSyncSearch.edf_no; }
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderSyncSearch.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderSyncSearch.active; }
                _oPar=x_oCmd.Parameters.Add("@sku", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderSyncSearch.sku==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderSyncSearch.sku; }
                _oPar=x_oCmd.Parameters.Add("@sim_item_name", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderSyncSearch.sim_item_name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderSyncSearch.sim_item_name; }
                _oPar=x_oCmd.Parameters.Add("@d_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderSyncSearch.d_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderSyncSearch.d_date; }
                _oPar=x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderSyncSearch.program==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderSyncSearch.program; }
                _oPar=x_oCmd.Parameters.Add("@sim_item_code", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderSyncSearch.sim_item_code==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderSyncSearch.sim_item_code; }
                _oPar=x_oCmd.Parameters.Add("@imei_no", global::System.Data.SqlDbType.NVarChar,30);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderSyncSearch.imei_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderSyncSearch.imei_no; }
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
        
        #region INSERT_MOBILEORDERSYNCSEARCH Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2010-12-10>
        ///-- Description:	<Description,MOBILEORDERSYNCSEARCH, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_MOBILEORDERSYNCSEARCH Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_MOBILEORDERSYNCSEARCH', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_MOBILEORDERSYNCSEARCH;
        GO
        CREATE PROCEDURE INSERT_MOBILEORDERSYNCSEARCH
        	-- Add the parameters for the stored procedure here
        @RETURN_ORDER_ID int output,
        @active bit,
        @sku nvarchar(50),
        @program nvarchar(50),
        @sim_item_name nvarchar(250),
        @d_date datetime,
        @edf_no nvarchar(15),
        @sim_item_code nvarchar(250),
        @imei_no nvarchar(30)
        AS
        
        INSERT INTO  [MobileOrderSyncSearch]   ([edf_no],[active],[sku],[sim_item_name],[d_date],[program],[sim_item_code],[imei_no])  VALUES  (@edf_no,@active,@sku,@sim_item_name,@d_date,@program,@sim_item_code,@imei_no)
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
            string _sQuery = "DELETE FROM  [MobileOrderSyncSearch]  WHERE [MobileOrderSyncSearch].[order_id]=@order_id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderSyncSearch]","["+ Configurator.MSSQLTablePrefix + "MobileOrderSyncSearch]"); }
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
            return MobileOrderSyncSearchRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileOrderSyncSearch]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderSyncSearch]","["+ Configurator.MSSQLTablePrefix + "MobileOrderSyncSearch]"); }
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
            string _sQuery = "DELETE FROM [MobileOrderSyncSearch]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderSyncSearch]","["+ Configurator.MSSQLTablePrefix + "MobileOrderSyncSearch]"); }
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


