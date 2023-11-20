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
///-- Create date: <Create Date 2010-12-17>
///-- Description:	<Description,Table :[MobileOrderIssueRestriction],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderIssueRestriction] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"MobileOrderIssueRestriction")]
    public class MobileOrderIssueRestrictionRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static MobileOrderIssueRestrictionRepositoryBase instance;
        public static MobileOrderIssueRestrictionRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new MobileOrderIssueRestrictionRepositoryBase(_oDB);
            }
            return instance;
        }
        public static MobileOrderIssueRestrictionRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new MobileOrderIssueRestrictionRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<MobileOrderIssueRestrictionEntity> MobileOrderIssueRestrictions;
        #endregion
        
        #region Constructor
        public MobileOrderIssueRestrictionRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~MobileOrderIssueRestrictionRepositoryBase() { 
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
        public static MobileOrderIssueRestriction CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new MobileOrderIssueRestriction(_oDB);
        }
        
        public static MobileOrderIssueRestriction CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new MobileOrderIssueRestriction(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [MobileOrderIssueRestriction]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderIssueRestriction]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestriction]"); }
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
        
        
        public MobileOrderIssueRestrictionEntity GetObj(global::System.Nullable<int> x_iRestriction_id)
        {
            return GetObj(n_oDB, x_iRestriction_id);
        }
        
        
        public static MobileOrderIssueRestrictionEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iRestriction_id)
        {
            if (x_oDB==null) { return null; }
            MobileOrderIssueRestriction _MobileOrderIssueRestriction = (MobileOrderIssueRestriction)MobileOrderIssueRestrictionRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_MobileOrderIssueRestriction.Load(x_iRestriction_id)) { return null; }
            return _MobileOrderIssueRestriction;
        }
        
        
        
        public static MobileOrderIssueRestrictionEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<MobileOrderIssueRestrictionEntity> _oMobileOrderIssueRestrictionList = GetListObj(x_oDB,0, "restriction_id", x_oArrayItemId);
            if(_oMobileOrderIssueRestrictionList==null){ return null;}
            return _oMobileOrderIssueRestrictionList.Count == 0 ? null : _oMobileOrderIssueRestrictionList.ToArray();
        }
        
        public static List<MobileOrderIssueRestrictionEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "restriction_id", x_oArrayItemId);
        }
        
        
        public static MobileOrderIssueRestrictionEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderIssueRestrictionEntity> _oMobileOrderIssueRestrictionList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderIssueRestrictionList==null){ return null;}
            return _oMobileOrderIssueRestrictionList.Count == 0 ? null : _oMobileOrderIssueRestrictionList.ToArray();
        }
        
        
        public static MobileOrderIssueRestrictionEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderIssueRestrictionEntity> _oMobileOrderIssueRestrictionList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderIssueRestrictionList==null){ return null;}
            return _oMobileOrderIssueRestrictionList.Count == 0 ? null : _oMobileOrderIssueRestrictionList.ToArray();
        }
        
        public static List<MobileOrderIssueRestrictionEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<MobileOrderIssueRestrictionEntity> _oRow = new List<MobileOrderIssueRestrictionEntity>();
            string _sQuery = "SELECT  "+_sTop+" [MobileOrderIssueRestriction].[name] AS MOBILEORDERISSUERESTRICTION_NAME,[MobileOrderIssueRestriction].[cdate] AS MOBILEORDERISSUERESTRICTION_CDATE,[MobileOrderIssueRestriction].[cid] AS MOBILEORDERISSUERESTRICTION_CID,[MobileOrderIssueRestriction].[type] AS MOBILEORDERISSUERESTRICTION_TYPE,[MobileOrderIssueRestriction].[active] AS MOBILEORDERISSUERESTRICTION_ACTIVE,[MobileOrderIssueRestriction].[restriction_id] AS MOBILEORDERISSUERESTRICTION_RESTRICTION_ID  FROM  [MobileOrderIssueRestriction]";
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
                _sQuery += " WHERE [MobileOrderIssueRestriction].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderIssueRestriction]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestriction]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        MobileOrderIssueRestriction _oMobileOrderIssueRestriction = MobileOrderIssueRestrictionRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTION_NAME"])) {_oMobileOrderIssueRestriction.name = (string)_oData["MOBILEORDERISSUERESTRICTION_NAME"]; }else{_oMobileOrderIssueRestriction.name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTION_CDATE"])) {_oMobileOrderIssueRestriction.cdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERISSUERESTRICTION_CDATE"]; }else{_oMobileOrderIssueRestriction.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTION_CID"])) {_oMobileOrderIssueRestriction.cid = (string)_oData["MOBILEORDERISSUERESTRICTION_CID"]; }else{_oMobileOrderIssueRestriction.cid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTION_TYPE"])) {_oMobileOrderIssueRestriction.type = (string)_oData["MOBILEORDERISSUERESTRICTION_TYPE"]; }else{_oMobileOrderIssueRestriction.type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTION_ACTIVE"])) {_oMobileOrderIssueRestriction.active = (global::System.Nullable<bool>)_oData["MOBILEORDERISSUERESTRICTION_ACTIVE"]; }else{_oMobileOrderIssueRestriction.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTION_RESTRICTION_ID"])) {_oMobileOrderIssueRestriction.restriction_id = (global::System.Nullable<int>)_oData["MOBILEORDERISSUERESTRICTION_RESTRICTION_ID"]; }else{_oMobileOrderIssueRestriction.restriction_id=null;}
                        _oMobileOrderIssueRestriction.SetDB(x_oDB);
                        _oMobileOrderIssueRestriction.GetFound();
                        _oRow.Add(_oMobileOrderIssueRestriction);
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
        
        
        public static MobileOrderIssueRestrictionEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderIssueRestrictionEntity> _oMobileOrderIssueRestrictionList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderIssueRestrictionList==null){ return null;}
            return _oMobileOrderIssueRestrictionList.Count == 0 ? null : _oMobileOrderIssueRestrictionList.ToArray();
        }
        
        
        public static MobileOrderIssueRestrictionEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderIssueRestrictionEntity> _oMobileOrderIssueRestrictionList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderIssueRestrictionList==null){ return null;}
            return _oMobileOrderIssueRestrictionList.Count == 0 ? null : _oMobileOrderIssueRestrictionList.ToArray();
        }
        
        public static List<MobileOrderIssueRestrictionEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<MobileOrderIssueRestrictionEntity> _oRow = new List<MobileOrderIssueRestrictionEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[MobileOrderIssueRestriction].[name] AS MOBILEORDERISSUERESTRICTION_NAME,[MobileOrderIssueRestriction].[cdate] AS MOBILEORDERISSUERESTRICTION_CDATE,[MobileOrderIssueRestriction].[cid] AS MOBILEORDERISSUERESTRICTION_CID,[MobileOrderIssueRestriction].[type] AS MOBILEORDERISSUERESTRICTION_TYPE,[MobileOrderIssueRestriction].[active] AS MOBILEORDERISSUERESTRICTION_ACTIVE,[MobileOrderIssueRestriction].[restriction_id] AS MOBILEORDERISSUERESTRICTION_RESTRICTION_ID";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[MobileOrderIssueRestriction]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestriction]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = MobileOrderIssueRestrictionRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                MobileOrderIssueRestrictionEntity _oMobileOrderIssueRestriction = MobileOrderIssueRestrictionRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTION_NAME"])) {_oMobileOrderIssueRestriction.name = (string)_oData["MOBILEORDERISSUERESTRICTION_NAME"]; } else {_oMobileOrderIssueRestriction.name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTION_CDATE"])) {_oMobileOrderIssueRestriction.cdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERISSUERESTRICTION_CDATE"]; } else {_oMobileOrderIssueRestriction.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTION_CID"])) {_oMobileOrderIssueRestriction.cid = (string)_oData["MOBILEORDERISSUERESTRICTION_CID"]; } else {_oMobileOrderIssueRestriction.cid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTION_TYPE"])) {_oMobileOrderIssueRestriction.type = (string)_oData["MOBILEORDERISSUERESTRICTION_TYPE"]; } else {_oMobileOrderIssueRestriction.type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTION_ACTIVE"])) {_oMobileOrderIssueRestriction.active = (global::System.Nullable<bool>)_oData["MOBILEORDERISSUERESTRICTION_ACTIVE"]; } else {_oMobileOrderIssueRestriction.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTION_RESTRICTION_ID"])) {_oMobileOrderIssueRestriction.restriction_id = (global::System.Nullable<int>)_oData["MOBILEORDERISSUERESTRICTION_RESTRICTION_ID"]; } else {_oMobileOrderIssueRestriction.restriction_id=null; }
                _oMobileOrderIssueRestriction.SetDB(x_oDB);
                _oMobileOrderIssueRestriction.GetFound();
                _oRow.Add(_oMobileOrderIssueRestriction);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( MobileOrderIssueRestriction.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,MobileOrderIssueRestriction.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(MobileOrderIssueRestriction.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(MobileOrderIssueRestriction.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [MobileOrderIssueRestriction].[name] AS MOBILEORDERISSUERESTRICTION_NAME,[MobileOrderIssueRestriction].[cdate] AS MOBILEORDERISSUERESTRICTION_CDATE,[MobileOrderIssueRestriction].[cid] AS MOBILEORDERISSUERESTRICTION_CID,[MobileOrderIssueRestriction].[type] AS MOBILEORDERISSUERESTRICTION_TYPE,[MobileOrderIssueRestriction].[active] AS MOBILEORDERISSUERESTRICTION_ACTIVE,[MobileOrderIssueRestriction].[restriction_id] AS MOBILEORDERISSUERESTRICTION_RESTRICTION_ID  FROM  [MobileOrderIssueRestriction]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[MobileOrderIssueRestriction]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestriction]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"MobileOrderIssueRestriction");
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
        
        public bool Insert(string x_sName,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sType,global::System.Nullable<bool> x_bActive)
        {
            MobileOrderIssueRestriction _oMobileOrderIssueRestriction=MobileOrderIssueRestrictionRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oMobileOrderIssueRestriction.name=x_sName;
            _oMobileOrderIssueRestriction.cdate=x_dCdate;
            _oMobileOrderIssueRestriction.cid=x_sCid;
            _oMobileOrderIssueRestriction.type=x_sType;
            _oMobileOrderIssueRestriction.active=x_bActive;
            return InsertWithOutLastID(n_oDB, _oMobileOrderIssueRestriction);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sName,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sType,global::System.Nullable<bool> x_bActive)
        {
            MobileOrderIssueRestriction _oMobileOrderIssueRestriction=MobileOrderIssueRestrictionRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderIssueRestriction.name=x_sName;
            _oMobileOrderIssueRestriction.cdate=x_dCdate;
            _oMobileOrderIssueRestriction.cid=x_sCid;
            _oMobileOrderIssueRestriction.type=x_sType;
            _oMobileOrderIssueRestriction.active=x_bActive;
            return InsertWithOutLastID(x_oDB, _oMobileOrderIssueRestriction);
        }
        
        
        public bool Insert(MobileOrderIssueRestriction x_oMobileOrderIssueRestriction)
        {
            return InsertWithOutLastID(n_oDB, x_oMobileOrderIssueRestriction);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is MobileOrderIssueRestriction)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (MobileOrderIssueRestriction)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,MobileOrderIssueRestriction x_oMobileOrderIssueRestriction)
        {
            return InsertWithOutLastID(x_oDB, x_oMobileOrderIssueRestriction);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderIssueRestriction x_oMobileOrderIssueRestriction)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderIssueRestriction]   ([name],[cdate],[cid],[type],[active])  VALUES  (@name,@cdate,@cid,@type,@active)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderIssueRestriction]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestriction]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderIssueRestriction);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderIssueRestriction x_oMobileOrderIssueRestriction)
        {
            bool _bResult = false;
            if (!x_oMobileOrderIssueRestriction.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderIssueRestriction.name==null){  x_oCmd.Parameters.Add("@name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@name", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderIssueRestriction.name; }
                if(x_oMobileOrderIssueRestriction.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderIssueRestriction.cdate; }
                if(x_oMobileOrderIssueRestriction.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderIssueRestriction.cid; }
                if(x_oMobileOrderIssueRestriction.type==null){  x_oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderIssueRestriction.type; }
                if(x_oMobileOrderIssueRestriction.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderIssueRestriction.active; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,string x_sName,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sType,global::System.Nullable<bool> x_bActive)
        {
            int _oLastID;
            MobileOrderIssueRestriction _oMobileOrderIssueRestriction=MobileOrderIssueRestrictionRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderIssueRestriction.name=x_sName;
            _oMobileOrderIssueRestriction.cdate=x_dCdate;
            _oMobileOrderIssueRestriction.cid=x_sCid;
            _oMobileOrderIssueRestriction.type=x_sType;
            _oMobileOrderIssueRestriction.active=x_bActive;
            if(InsertWithLastID(x_oDB, _oMobileOrderIssueRestriction,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(MobileOrderIssueRestriction x_oMobileOrderIssueRestriction)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oMobileOrderIssueRestriction, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, MobileOrderIssueRestriction x_oMobileOrderIssueRestriction)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oMobileOrderIssueRestriction, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderIssueRestriction)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (MobileOrderIssueRestriction)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,MobileOrderIssueRestriction x_oMobileOrderIssueRestriction, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderIssueRestriction]   ([name],[cdate],[cid],[type],[active])  VALUES  (@name,@cdate,@cid,@type,@active)"+" SELECT  @@IDENTITY AS MobileOrderIssueRestriction_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderIssueRestriction]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestriction]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderIssueRestriction,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderIssueRestriction x_oMobileOrderIssueRestriction, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oMobileOrderIssueRestriction.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderIssueRestriction.name==null){  x_oCmd.Parameters.Add("@name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@name", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderIssueRestriction.name; }
                if(x_oMobileOrderIssueRestriction.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderIssueRestriction.cdate; }
                if(x_oMobileOrderIssueRestriction.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderIssueRestriction.cid; }
                if(x_oMobileOrderIssueRestriction.type==null){  x_oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderIssueRestriction.type; }
                if(x_oMobileOrderIssueRestriction.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderIssueRestriction.active; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["MobileOrderIssueRestriction_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["MobileOrderIssueRestriction_LASTID"].ToString()) && int.TryParse(_oData["MobileOrderIssueRestriction_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sName,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sType,global::System.Nullable<bool> x_bActive)
        {
            int _oLastID;
            MobileOrderIssueRestriction _oMobileOrderIssueRestriction=MobileOrderIssueRestrictionRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderIssueRestriction.name=x_sName;
            _oMobileOrderIssueRestriction.cdate=x_dCdate;
            _oMobileOrderIssueRestriction.cid=x_sCid;
            _oMobileOrderIssueRestriction.type=x_sType;
            _oMobileOrderIssueRestriction.active=x_bActive;
            if(InsertWithLastID_SP(x_oDB, _oMobileOrderIssueRestriction,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(MobileOrderIssueRestriction x_oMobileOrderIssueRestriction)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oMobileOrderIssueRestriction, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderIssueRestriction x_oMobileOrderIssueRestriction)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oMobileOrderIssueRestriction, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderIssueRestriction)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (MobileOrderIssueRestriction)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,MobileOrderIssueRestriction x_oMobileOrderIssueRestriction, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "MOBILEORDERISSUERESTRICTION";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oMobileOrderIssueRestriction,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderIssueRestriction x_oMobileOrderIssueRestriction, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@name", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderIssueRestriction.name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderIssueRestriction.name; }
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderIssueRestriction.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderIssueRestriction.cdate; }
                _oPar=x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderIssueRestriction.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderIssueRestriction.cid; }
                _oPar=x_oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderIssueRestriction.type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderIssueRestriction.type; }
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderIssueRestriction.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderIssueRestriction.active; }
                _oPar=x_oCmd.Parameters.Add("@RETURN_RESTRICTION_ID", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Output;
                x_oCmd.CommandType = CommandType.StoredProcedure;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                _bResult = Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
                x_oLAST_ID = Int32.Parse(x_oCmd.Parameters["@RETURN_RESTRICTION_ID"].Value.ToString());
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
        
        #region INSERT_MOBILEORDERISSUERESTRICTION Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2010-12-17>
        ///-- Description:	<Description,MOBILEORDERISSUERESTRICTION, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_MOBILEORDERISSUERESTRICTION Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_MOBILEORDERISSUERESTRICTION', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_MOBILEORDERISSUERESTRICTION;
        GO
        CREATE PROCEDURE INSERT_MOBILEORDERISSUERESTRICTION
        	-- Add the parameters for the stored procedure here
        @RETURN_RESTRICTION_ID int output,
        @name nvarchar(250),
        @cdate datetime,
        @cid nvarchar(50),
        @type nvarchar(50),
        @active bit
        AS
        
        INSERT INTO  [MobileOrderIssueRestriction]   ([name],[cdate],[cid],[type],[active])  VALUES  (@name,@cdate,@cid,@type,@active)
        IF @@IDENTITY IS NOT NULL
        BEGIN
        SELECT @RETURN_RESTRICTION_ID=@@IDENTITY
        RETURN @RETURN_RESTRICTION_ID
        END
        ELSE
        BEGIN
        SET @RETURN_RESTRICTION_ID=-1
        RETURN @RETURN_RESTRICTION_ID
        END
        
        GO
        */
        #endregion
        
        #endregion
        
        #region Delete
        /// <summary>
        /// Summary description for management table deleting
        /// </summary>
        
        public bool Delete(global::System.Nullable<int> x_iRestriction_id)
        {
            return DeleteProc(n_oDB, x_iRestriction_id);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iRestriction_id)
        {
            return DeleteProc(x_oDB, x_iRestriction_id);
        }
        
        
        private static bool DeleteProc(MSSQLConnect x_oDB, global::System.Nullable<int> x_iRestriction_id)
        {
            if (x_iRestriction_id==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileOrderIssueRestriction]  WHERE [MobileOrderIssueRestriction].[restriction_id]=@restriction_id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderIssueRestriction]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestriction]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult=false;
                _oCmd.Parameters.Add("@restriction_id", global::System.Data.SqlDbType.Int).Value = x_iRestriction_id;
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
            return MobileOrderIssueRestrictionRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileOrderIssueRestriction]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderIssueRestriction]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestriction]"); }
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
            string _sQuery = "DELETE FROM [MobileOrderIssueRestriction]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderIssueRestriction]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestriction]"); }
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


