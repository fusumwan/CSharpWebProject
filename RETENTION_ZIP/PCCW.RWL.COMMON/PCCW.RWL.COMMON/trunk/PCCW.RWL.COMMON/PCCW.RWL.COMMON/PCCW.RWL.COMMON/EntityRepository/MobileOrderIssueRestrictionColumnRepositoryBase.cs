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
///-- Create date: <Create Date 2010-12-17>
///-- Description:	<Description,Table :[MobileOrderIssueRestrictionColumn],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderIssueRestrictionColumn] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"MobileOrderIssueRestrictionColumn")]
    public class MobileOrderIssueRestrictionColumnRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static MobileOrderIssueRestrictionColumnRepositoryBase instance;
        public static MobileOrderIssueRestrictionColumnRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new MobileOrderIssueRestrictionColumnRepositoryBase(_oDB);
            }
            return instance;
        }
        public static MobileOrderIssueRestrictionColumnRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new MobileOrderIssueRestrictionColumnRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<MobileOrderIssueRestrictionColumnEntity> MobileOrderIssueRestrictionColumns;
        #endregion
        
        #region Constructor
        public MobileOrderIssueRestrictionColumnRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~MobileOrderIssueRestrictionColumnRepositoryBase() { 
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
        public static MobileOrderIssueRestrictionColumn CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new MobileOrderIssueRestrictionColumn(_oDB);
        }
        
        public static MobileOrderIssueRestrictionColumn CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new MobileOrderIssueRestrictionColumn(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [MobileOrderIssueRestrictionColumn]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderIssueRestrictionColumn]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestrictionColumn]"); }
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
        
        
        public MobileOrderIssueRestrictionColumnEntity GetObj(global::System.Nullable<int> x_iMid)
        {
            return GetObj(n_oDB, x_iMid);
        }
        
        
        public static MobileOrderIssueRestrictionColumnEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            if (x_oDB==null) { return null; }
            MobileOrderIssueRestrictionColumn _MobileOrderIssueRestrictionColumn = (MobileOrderIssueRestrictionColumn)MobileOrderIssueRestrictionColumnRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_MobileOrderIssueRestrictionColumn.Load(x_iMid)) { return null; }
            return _MobileOrderIssueRestrictionColumn;
        }
        
        
        
        public static MobileOrderIssueRestrictionColumnEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<MobileOrderIssueRestrictionColumnEntity> _oMobileOrderIssueRestrictionColumnList = GetListObj(x_oDB,0, "mid", x_oArrayItemId);
            if(_oMobileOrderIssueRestrictionColumnList==null){ return null;}
            return _oMobileOrderIssueRestrictionColumnList.Count == 0 ? null : _oMobileOrderIssueRestrictionColumnList.ToArray();
        }
        
        public static List<MobileOrderIssueRestrictionColumnEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "mid", x_oArrayItemId);
        }
        
        
        public static MobileOrderIssueRestrictionColumnEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderIssueRestrictionColumnEntity> _oMobileOrderIssueRestrictionColumnList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderIssueRestrictionColumnList==null){ return null;}
            return _oMobileOrderIssueRestrictionColumnList.Count == 0 ? null : _oMobileOrderIssueRestrictionColumnList.ToArray();
        }
        
        
        public static MobileOrderIssueRestrictionColumnEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderIssueRestrictionColumnEntity> _oMobileOrderIssueRestrictionColumnList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderIssueRestrictionColumnList==null){ return null;}
            return _oMobileOrderIssueRestrictionColumnList.Count == 0 ? null : _oMobileOrderIssueRestrictionColumnList.ToArray();
        }
        
        public static List<MobileOrderIssueRestrictionColumnEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<MobileOrderIssueRestrictionColumnEntity> _oRow = new List<MobileOrderIssueRestrictionColumnEntity>();
            string _sQuery = "SELECT  "+_sTop+" [MobileOrderIssueRestrictionColumn].[action_type] AS MOBILEORDERISSUERESTRICTIONCOLUMN_ACTION_TYPE,[MobileOrderIssueRestrictionColumn].[cdate] AS MOBILEORDERISSUERESTRICTIONCOLUMN_CDATE,[MobileOrderIssueRestrictionColumn].[cid] AS MOBILEORDERISSUERESTRICTIONCOLUMN_CID,[MobileOrderIssueRestrictionColumn].[active] AS MOBILEORDERISSUERESTRICTIONCOLUMN_ACTIVE,[MobileOrderIssueRestrictionColumn].[restriction_id] AS MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_ID,[MobileOrderIssueRestrictionColumn].[restriction_column] AS MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_COLUMN,[MobileOrderIssueRestrictionColumn].[restriction_value] AS MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_VALUE,[MobileOrderIssueRestrictionColumn].[restriction_table] AS MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_TABLE,[MobileOrderIssueRestrictionColumn].[mid] AS MOBILEORDERISSUERESTRICTIONCOLUMN_MID  FROM  [MobileOrderIssueRestrictionColumn]";
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
                _sQuery += " WHERE [MobileOrderIssueRestrictionColumn].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderIssueRestrictionColumn]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestrictionColumn]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        MobileOrderIssueRestrictionColumn _oMobileOrderIssueRestrictionColumn = MobileOrderIssueRestrictionColumnRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_ACTIVE"])) {_oMobileOrderIssueRestrictionColumn.active = (global::System.Nullable<bool>)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_ACTIVE"]; }else{_oMobileOrderIssueRestrictionColumn.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_CDATE"])) {_oMobileOrderIssueRestrictionColumn.cdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_CDATE"]; }else{_oMobileOrderIssueRestrictionColumn.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_CID"])) {_oMobileOrderIssueRestrictionColumn.cid = (string)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_CID"]; }else{_oMobileOrderIssueRestrictionColumn.cid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_ID"])) {_oMobileOrderIssueRestrictionColumn.restriction_id = (global::System.Nullable<int>)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_ID"]; }else{_oMobileOrderIssueRestrictionColumn.restriction_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_COLUMN"])) {_oMobileOrderIssueRestrictionColumn.restriction_column = (string)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_COLUMN"]; }else{_oMobileOrderIssueRestrictionColumn.restriction_column=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_VALUE"])) {_oMobileOrderIssueRestrictionColumn.restriction_value = (string)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_VALUE"]; }else{_oMobileOrderIssueRestrictionColumn.restriction_value=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_TABLE"])) {_oMobileOrderIssueRestrictionColumn.restriction_table = (string)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_TABLE"]; }else{_oMobileOrderIssueRestrictionColumn.restriction_table=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_ACTION_TYPE"])) {_oMobileOrderIssueRestrictionColumn.action_type = (string)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_ACTION_TYPE"]; }else{_oMobileOrderIssueRestrictionColumn.action_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_MID"])) {_oMobileOrderIssueRestrictionColumn.mid = (global::System.Nullable<int>)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_MID"]; }else{_oMobileOrderIssueRestrictionColumn.mid=null;}
                        _oMobileOrderIssueRestrictionColumn.SetDB(x_oDB);
                        _oMobileOrderIssueRestrictionColumn.GetFound();
                        _oRow.Add(_oMobileOrderIssueRestrictionColumn);
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
        
        
        public static MobileOrderIssueRestrictionColumnEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderIssueRestrictionColumnEntity> _oMobileOrderIssueRestrictionColumnList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderIssueRestrictionColumnList==null){ return null;}
            return _oMobileOrderIssueRestrictionColumnList.Count == 0 ? null : _oMobileOrderIssueRestrictionColumnList.ToArray();
        }
        
        
        public static MobileOrderIssueRestrictionColumnEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderIssueRestrictionColumnEntity> _oMobileOrderIssueRestrictionColumnList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderIssueRestrictionColumnList==null){ return null;}
            return _oMobileOrderIssueRestrictionColumnList.Count == 0 ? null : _oMobileOrderIssueRestrictionColumnList.ToArray();
        }
        
        public static List<MobileOrderIssueRestrictionColumnEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<MobileOrderIssueRestrictionColumnEntity> _oRow = new List<MobileOrderIssueRestrictionColumnEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[MobileOrderIssueRestrictionColumn].[action_type] AS MOBILEORDERISSUERESTRICTIONCOLUMN_ACTION_TYPE,[MobileOrderIssueRestrictionColumn].[cdate] AS MOBILEORDERISSUERESTRICTIONCOLUMN_CDATE,[MobileOrderIssueRestrictionColumn].[cid] AS MOBILEORDERISSUERESTRICTIONCOLUMN_CID,[MobileOrderIssueRestrictionColumn].[active] AS MOBILEORDERISSUERESTRICTIONCOLUMN_ACTIVE,[MobileOrderIssueRestrictionColumn].[restriction_id] AS MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_ID,[MobileOrderIssueRestrictionColumn].[restriction_column] AS MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_COLUMN,[MobileOrderIssueRestrictionColumn].[restriction_value] AS MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_VALUE,[MobileOrderIssueRestrictionColumn].[restriction_table] AS MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_TABLE,[MobileOrderIssueRestrictionColumn].[mid] AS MOBILEORDERISSUERESTRICTIONCOLUMN_MID";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[MobileOrderIssueRestrictionColumn]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestrictionColumn]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = MobileOrderIssueRestrictionColumnRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                MobileOrderIssueRestrictionColumnEntity _oMobileOrderIssueRestrictionColumn = MobileOrderIssueRestrictionColumnRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_ACTIVE"])) {_oMobileOrderIssueRestrictionColumn.active = (global::System.Nullable<bool>)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_ACTIVE"]; } else {_oMobileOrderIssueRestrictionColumn.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_CDATE"])) {_oMobileOrderIssueRestrictionColumn.cdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_CDATE"]; } else {_oMobileOrderIssueRestrictionColumn.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_CID"])) {_oMobileOrderIssueRestrictionColumn.cid = (string)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_CID"]; } else {_oMobileOrderIssueRestrictionColumn.cid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_ID"])) {_oMobileOrderIssueRestrictionColumn.restriction_id = (global::System.Nullable<int>)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_ID"]; } else {_oMobileOrderIssueRestrictionColumn.restriction_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_COLUMN"])) {_oMobileOrderIssueRestrictionColumn.restriction_column = (string)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_COLUMN"]; } else {_oMobileOrderIssueRestrictionColumn.restriction_column=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_VALUE"])) {_oMobileOrderIssueRestrictionColumn.restriction_value = (string)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_VALUE"]; } else {_oMobileOrderIssueRestrictionColumn.restriction_value=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_TABLE"])) {_oMobileOrderIssueRestrictionColumn.restriction_table = (string)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_TABLE"]; } else {_oMobileOrderIssueRestrictionColumn.restriction_table=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_ACTION_TYPE"])) {_oMobileOrderIssueRestrictionColumn.action_type = (string)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_ACTION_TYPE"]; } else {_oMobileOrderIssueRestrictionColumn.action_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_MID"])) {_oMobileOrderIssueRestrictionColumn.mid = (global::System.Nullable<int>)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_MID"]; } else {_oMobileOrderIssueRestrictionColumn.mid=null; }
                _oMobileOrderIssueRestrictionColumn.SetDB(x_oDB);
                _oMobileOrderIssueRestrictionColumn.GetFound();
                _oRow.Add(_oMobileOrderIssueRestrictionColumn);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( MobileOrderIssueRestrictionColumn.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,MobileOrderIssueRestrictionColumn.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(MobileOrderIssueRestrictionColumn.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(MobileOrderIssueRestrictionColumn.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [MobileOrderIssueRestrictionColumn].[action_type] AS MOBILEORDERISSUERESTRICTIONCOLUMN_ACTION_TYPE,[MobileOrderIssueRestrictionColumn].[cdate] AS MOBILEORDERISSUERESTRICTIONCOLUMN_CDATE,[MobileOrderIssueRestrictionColumn].[cid] AS MOBILEORDERISSUERESTRICTIONCOLUMN_CID,[MobileOrderIssueRestrictionColumn].[active] AS MOBILEORDERISSUERESTRICTIONCOLUMN_ACTIVE,[MobileOrderIssueRestrictionColumn].[restriction_id] AS MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_ID,[MobileOrderIssueRestrictionColumn].[restriction_column] AS MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_COLUMN,[MobileOrderIssueRestrictionColumn].[restriction_value] AS MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_VALUE,[MobileOrderIssueRestrictionColumn].[restriction_table] AS MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_TABLE,[MobileOrderIssueRestrictionColumn].[mid] AS MOBILEORDERISSUERESTRICTIONCOLUMN_MID  FROM  [MobileOrderIssueRestrictionColumn]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[MobileOrderIssueRestrictionColumn]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestrictionColumn]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"MobileOrderIssueRestrictionColumn");
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
        
        public bool Insert(global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dCdate,string x_sCid,global::System.Nullable<int> x_iRestriction_id,string x_sRestriction_column,string x_sRestriction_value,string x_sRestriction_table,string x_sAction_type)
        {
            MobileOrderIssueRestrictionColumn _oMobileOrderIssueRestrictionColumn=MobileOrderIssueRestrictionColumnRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oMobileOrderIssueRestrictionColumn.active=x_bActive;
            _oMobileOrderIssueRestrictionColumn.cdate=x_dCdate;
            _oMobileOrderIssueRestrictionColumn.cid=x_sCid;
            _oMobileOrderIssueRestrictionColumn.restriction_id=x_iRestriction_id;
            _oMobileOrderIssueRestrictionColumn.restriction_column=x_sRestriction_column;
            _oMobileOrderIssueRestrictionColumn.restriction_value=x_sRestriction_value;
            _oMobileOrderIssueRestrictionColumn.restriction_table=x_sRestriction_table;
            _oMobileOrderIssueRestrictionColumn.action_type=x_sAction_type;
            return InsertWithOutLastID(n_oDB, _oMobileOrderIssueRestrictionColumn);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dCdate,string x_sCid,global::System.Nullable<int> x_iRestriction_id,string x_sRestriction_column,string x_sRestriction_value,string x_sRestriction_table,string x_sAction_type)
        {
            MobileOrderIssueRestrictionColumn _oMobileOrderIssueRestrictionColumn=MobileOrderIssueRestrictionColumnRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderIssueRestrictionColumn.active=x_bActive;
            _oMobileOrderIssueRestrictionColumn.cdate=x_dCdate;
            _oMobileOrderIssueRestrictionColumn.cid=x_sCid;
            _oMobileOrderIssueRestrictionColumn.restriction_id=x_iRestriction_id;
            _oMobileOrderIssueRestrictionColumn.restriction_column=x_sRestriction_column;
            _oMobileOrderIssueRestrictionColumn.restriction_value=x_sRestriction_value;
            _oMobileOrderIssueRestrictionColumn.restriction_table=x_sRestriction_table;
            _oMobileOrderIssueRestrictionColumn.action_type=x_sAction_type;
            return InsertWithOutLastID(x_oDB, _oMobileOrderIssueRestrictionColumn);
        }
        
        
        public bool Insert(MobileOrderIssueRestrictionColumn x_oMobileOrderIssueRestrictionColumn)
        {
            return InsertWithOutLastID(n_oDB, x_oMobileOrderIssueRestrictionColumn);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is MobileOrderIssueRestrictionColumn)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (MobileOrderIssueRestrictionColumn)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,MobileOrderIssueRestrictionColumn x_oMobileOrderIssueRestrictionColumn)
        {
            return InsertWithOutLastID(x_oDB, x_oMobileOrderIssueRestrictionColumn);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderIssueRestrictionColumn x_oMobileOrderIssueRestrictionColumn)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderIssueRestrictionColumn]   ([action_type],[cdate],[cid],[active],[restriction_id],[restriction_column],[restriction_value],[restriction_table])  VALUES  (@action_type,@cdate,@cid,@active,@restriction_id,@restriction_column,@restriction_value,@restriction_table)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderIssueRestrictionColumn]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestrictionColumn]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderIssueRestrictionColumn);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderIssueRestrictionColumn x_oMobileOrderIssueRestrictionColumn)
        {
            bool _bResult = false;
            if (!x_oMobileOrderIssueRestrictionColumn.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderIssueRestrictionColumn.action_type==null){  x_oCmd.Parameters.Add("@action_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@action_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderIssueRestrictionColumn.action_type; }
                if(x_oMobileOrderIssueRestrictionColumn.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderIssueRestrictionColumn.cdate; }
                if(x_oMobileOrderIssueRestrictionColumn.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderIssueRestrictionColumn.cid; }
                if(x_oMobileOrderIssueRestrictionColumn.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderIssueRestrictionColumn.active; }
                if(x_oMobileOrderIssueRestrictionColumn.restriction_id==null){  x_oCmd.Parameters.Add("@restriction_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@restriction_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderIssueRestrictionColumn.restriction_id; }
                if(x_oMobileOrderIssueRestrictionColumn.restriction_column==null){  x_oCmd.Parameters.Add("@restriction_column", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@restriction_column", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderIssueRestrictionColumn.restriction_column; }
                if(x_oMobileOrderIssueRestrictionColumn.restriction_value==null){  x_oCmd.Parameters.Add("@restriction_value", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@restriction_value", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderIssueRestrictionColumn.restriction_value; }
                if(x_oMobileOrderIssueRestrictionColumn.restriction_table==null){  x_oCmd.Parameters.Add("@restriction_table", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@restriction_table", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderIssueRestrictionColumn.restriction_table; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dCdate,string x_sCid,global::System.Nullable<int> x_iRestriction_id,string x_sRestriction_column,string x_sRestriction_value,string x_sRestriction_table,string x_sAction_type)
        {
            int _oLastID;
            MobileOrderIssueRestrictionColumn _oMobileOrderIssueRestrictionColumn=MobileOrderIssueRestrictionColumnRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderIssueRestrictionColumn.active=x_bActive;
            _oMobileOrderIssueRestrictionColumn.cdate=x_dCdate;
            _oMobileOrderIssueRestrictionColumn.cid=x_sCid;
            _oMobileOrderIssueRestrictionColumn.restriction_id=x_iRestriction_id;
            _oMobileOrderIssueRestrictionColumn.restriction_column=x_sRestriction_column;
            _oMobileOrderIssueRestrictionColumn.restriction_value=x_sRestriction_value;
            _oMobileOrderIssueRestrictionColumn.restriction_table=x_sRestriction_table;
            _oMobileOrderIssueRestrictionColumn.action_type=x_sAction_type;
            if(InsertWithLastID(x_oDB, _oMobileOrderIssueRestrictionColumn,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(MobileOrderIssueRestrictionColumn x_oMobileOrderIssueRestrictionColumn)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oMobileOrderIssueRestrictionColumn, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, MobileOrderIssueRestrictionColumn x_oMobileOrderIssueRestrictionColumn)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oMobileOrderIssueRestrictionColumn, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderIssueRestrictionColumn)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (MobileOrderIssueRestrictionColumn)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,MobileOrderIssueRestrictionColumn x_oMobileOrderIssueRestrictionColumn, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderIssueRestrictionColumn]   ([action_type],[cdate],[cid],[active],[restriction_id],[restriction_column],[restriction_value],[restriction_table])  VALUES  (@action_type,@cdate,@cid,@active,@restriction_id,@restriction_column,@restriction_value,@restriction_table)"+" SELECT  @@IDENTITY AS MobileOrderIssueRestrictionColumn_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderIssueRestrictionColumn]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestrictionColumn]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderIssueRestrictionColumn,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderIssueRestrictionColumn x_oMobileOrderIssueRestrictionColumn, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oMobileOrderIssueRestrictionColumn.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderIssueRestrictionColumn.action_type==null){  x_oCmd.Parameters.Add("@action_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@action_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderIssueRestrictionColumn.action_type; }
                if(x_oMobileOrderIssueRestrictionColumn.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderIssueRestrictionColumn.cdate; }
                if(x_oMobileOrderIssueRestrictionColumn.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderIssueRestrictionColumn.cid; }
                if(x_oMobileOrderIssueRestrictionColumn.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderIssueRestrictionColumn.active; }
                if(x_oMobileOrderIssueRestrictionColumn.restriction_id==null){  x_oCmd.Parameters.Add("@restriction_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@restriction_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderIssueRestrictionColumn.restriction_id; }
                if(x_oMobileOrderIssueRestrictionColumn.restriction_column==null){  x_oCmd.Parameters.Add("@restriction_column", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@restriction_column", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderIssueRestrictionColumn.restriction_column; }
                if(x_oMobileOrderIssueRestrictionColumn.restriction_value==null){  x_oCmd.Parameters.Add("@restriction_value", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@restriction_value", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderIssueRestrictionColumn.restriction_value; }
                if(x_oMobileOrderIssueRestrictionColumn.restriction_table==null){  x_oCmd.Parameters.Add("@restriction_table", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@restriction_table", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderIssueRestrictionColumn.restriction_table; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["MobileOrderIssueRestrictionColumn_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["MobileOrderIssueRestrictionColumn_LASTID"].ToString()) && int.TryParse(_oData["MobileOrderIssueRestrictionColumn_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dCdate,string x_sCid,global::System.Nullable<int> x_iRestriction_id,string x_sRestriction_column,string x_sRestriction_value,string x_sRestriction_table,string x_sAction_type)
        {
            int _oLastID;
            MobileOrderIssueRestrictionColumn _oMobileOrderIssueRestrictionColumn=MobileOrderIssueRestrictionColumnRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderIssueRestrictionColumn.active=x_bActive;
            _oMobileOrderIssueRestrictionColumn.cdate=x_dCdate;
            _oMobileOrderIssueRestrictionColumn.cid=x_sCid;
            _oMobileOrderIssueRestrictionColumn.restriction_id=x_iRestriction_id;
            _oMobileOrderIssueRestrictionColumn.restriction_column=x_sRestriction_column;
            _oMobileOrderIssueRestrictionColumn.restriction_value=x_sRestriction_value;
            _oMobileOrderIssueRestrictionColumn.restriction_table=x_sRestriction_table;
            _oMobileOrderIssueRestrictionColumn.action_type=x_sAction_type;
            if(InsertWithLastID_SP(x_oDB, _oMobileOrderIssueRestrictionColumn,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(MobileOrderIssueRestrictionColumn x_oMobileOrderIssueRestrictionColumn)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oMobileOrderIssueRestrictionColumn, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderIssueRestrictionColumn x_oMobileOrderIssueRestrictionColumn)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oMobileOrderIssueRestrictionColumn, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderIssueRestrictionColumn)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (MobileOrderIssueRestrictionColumn)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,MobileOrderIssueRestrictionColumn x_oMobileOrderIssueRestrictionColumn, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "MOBILEORDERISSUERESTRICTIONCOLUMN";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oMobileOrderIssueRestrictionColumn,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderIssueRestrictionColumn x_oMobileOrderIssueRestrictionColumn, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@action_type", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderIssueRestrictionColumn.action_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderIssueRestrictionColumn.action_type; }
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderIssueRestrictionColumn.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderIssueRestrictionColumn.cdate; }
                _oPar=x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderIssueRestrictionColumn.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderIssueRestrictionColumn.cid; }
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderIssueRestrictionColumn.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderIssueRestrictionColumn.active; }
                _oPar=x_oCmd.Parameters.Add("@restriction_id", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderIssueRestrictionColumn.restriction_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderIssueRestrictionColumn.restriction_id; }
                _oPar=x_oCmd.Parameters.Add("@restriction_column", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderIssueRestrictionColumn.restriction_column==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderIssueRestrictionColumn.restriction_column; }
                _oPar=x_oCmd.Parameters.Add("@restriction_value", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderIssueRestrictionColumn.restriction_value==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderIssueRestrictionColumn.restriction_value; }
                _oPar=x_oCmd.Parameters.Add("@restriction_table", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderIssueRestrictionColumn.restriction_table==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderIssueRestrictionColumn.restriction_table; }
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
        
        #region INSERT_MOBILEORDERISSUERESTRICTIONCOLUMN Store Procedures
        ///-- =============================================
        ///-- Author:		<Author,Philip SW>
        ///-- Create date: <Create Date 2010-12-17>
        ///-- Description:	<Description,MOBILEORDERISSUERESTRICTIONCOLUMN, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_MOBILEORDERISSUERESTRICTIONCOLUMN Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_MOBILEORDERISSUERESTRICTIONCOLUMN', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_MOBILEORDERISSUERESTRICTIONCOLUMN;
        GO
        CREATE PROCEDURE INSERT_MOBILEORDERISSUERESTRICTIONCOLUMN
        	-- Add the parameters for the stored procedure here
        @RETURN_MID int output,
        @active bit,
        @cdate datetime,
        @cid nvarchar(50),
        @restriction_id int,
        @restriction_column nvarchar(250),
        @restriction_value nvarchar(250),
        @restriction_table nvarchar(250),
        @action_type nvarchar(50)
        AS
        
        INSERT INTO  [MobileOrderIssueRestrictionColumn]   ([action_type],[cdate],[cid],[active],[restriction_id],[restriction_column],[restriction_value],[restriction_table])  VALUES  (@action_type,@cdate,@cid,@active,@restriction_id,@restriction_column,@restriction_value,@restriction_table)
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
            string _sQuery = "DELETE FROM  [MobileOrderIssueRestrictionColumn]  WHERE [MobileOrderIssueRestrictionColumn].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderIssueRestrictionColumn]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestrictionColumn]"); }
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
            return MobileOrderIssueRestrictionColumnRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileOrderIssueRestrictionColumn]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderIssueRestrictionColumn]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestrictionColumn]"); }
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
            string _sQuery = "DELETE FROM [MobileOrderIssueRestrictionColumn]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderIssueRestrictionColumn]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestrictionColumn]"); }
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


