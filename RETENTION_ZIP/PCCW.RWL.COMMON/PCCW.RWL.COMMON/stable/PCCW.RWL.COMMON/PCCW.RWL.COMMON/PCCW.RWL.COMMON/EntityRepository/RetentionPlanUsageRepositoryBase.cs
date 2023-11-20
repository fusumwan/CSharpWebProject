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
///-- Create date: <Create Date 2011-10-04>
///-- Description:	<Description,Table :[RetentionPlanUsage],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [RetentionPlanUsage] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"RetentionPlanUsage")]
    public class RetentionPlanUsageRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static RetentionPlanUsageRepositoryBase instance;
        public static RetentionPlanUsageRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new RetentionPlanUsageRepositoryBase(_oDB);
            }
            return instance;
        }
        public static RetentionPlanUsageRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new RetentionPlanUsageRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<RetentionPlanUsageEntity> RetentionPlanUsages;
        #endregion
        
        #region Constructor
        public RetentionPlanUsageRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~RetentionPlanUsageRepositoryBase() { 
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
        public static RetentionPlanUsage CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new RetentionPlanUsage(_oDB);
        }
        
        public static RetentionPlanUsage CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new RetentionPlanUsage(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [RetentionPlanUsage]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RetentionPlanUsage]","["+ Configurator.MSSQLTablePrefix + "RetentionPlanUsage]"); }
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
        
        
        public RetentionPlanUsageEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }
        
        
        public static RetentionPlanUsageEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            if (x_oDB==null) { return null; }
            RetentionPlanUsage _RetentionPlanUsage = (RetentionPlanUsage)RetentionPlanUsageRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_RetentionPlanUsage.Load(x_iId)) { return null; }
            return _RetentionPlanUsage;
        }
        
        
        
        public static RetentionPlanUsageEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<RetentionPlanUsageEntity> _oRetentionPlanUsageList = GetListObj(x_oDB,0, "id", x_oArrayItemId);
            if(_oRetentionPlanUsageList==null){ return null;}
            return _oRetentionPlanUsageList.Count == 0 ? null : _oRetentionPlanUsageList.ToArray();
        }
        
        public static List<RetentionPlanUsageEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "id", x_oArrayItemId);
        }
        
        
        public static RetentionPlanUsageEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<RetentionPlanUsageEntity> _oRetentionPlanUsageList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oRetentionPlanUsageList==null){ return null;}
            return _oRetentionPlanUsageList.Count == 0 ? null : _oRetentionPlanUsageList.ToArray();
        }
        
        
        public static RetentionPlanUsageEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<RetentionPlanUsageEntity> _oRetentionPlanUsageList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oRetentionPlanUsageList==null){ return null;}
            return _oRetentionPlanUsageList.Count == 0 ? null : _oRetentionPlanUsageList.ToArray();
        }
        
        public static List<RetentionPlanUsageEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<RetentionPlanUsageEntity> _oRow = new List<RetentionPlanUsageEntity>();
            string _sQuery = "SELECT  "+_sTop+" [RetentionPlanUsage].[active] AS RETENTIONPLANUSAGE_ACTIVE,[RetentionPlanUsage].[cdate] AS RETENTIONPLANUSAGE_CDATE,[RetentionPlanUsage].[cid] AS RETENTIONPLANUSAGE_CID,[RetentionPlanUsage].[rate_plan] AS RETENTIONPLANUSAGE_RATE_PLAN,[RetentionPlanUsage].[id] AS RETENTIONPLANUSAGE_ID,[RetentionPlanUsage].[rate_plan_vas_value] AS RETENTIONPLANUSAGE_RATE_PLAN_VAS_VALUE,[RetentionPlanUsage].[rate_plan_vas] AS RETENTIONPLANUSAGE_RATE_PLAN_VAS  FROM  [RetentionPlanUsage]";
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
                _sQuery += " WHERE [RetentionPlanUsage].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RetentionPlanUsage]","["+ Configurator.MSSQLTablePrefix + "RetentionPlanUsage]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        RetentionPlanUsage _oRetentionPlanUsage = RetentionPlanUsageRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLANUSAGE_ID"])) {_oRetentionPlanUsage.id = (global::System.Nullable<int>)_oData["RETENTIONPLANUSAGE_ID"]; }else{_oRetentionPlanUsage.id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLANUSAGE_CDATE"])) {_oRetentionPlanUsage.cdate = (global::System.Nullable<DateTime>)_oData["RETENTIONPLANUSAGE_CDATE"]; }else{_oRetentionPlanUsage.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLANUSAGE_CID"])) {_oRetentionPlanUsage.cid = (string)_oData["RETENTIONPLANUSAGE_CID"]; }else{_oRetentionPlanUsage.cid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLANUSAGE_RATE_PLAN"])) {_oRetentionPlanUsage.rate_plan = (string)_oData["RETENTIONPLANUSAGE_RATE_PLAN"]; }else{_oRetentionPlanUsage.rate_plan=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLANUSAGE_ACTIVE"])) {_oRetentionPlanUsage.active = (global::System.Nullable<bool>)_oData["RETENTIONPLANUSAGE_ACTIVE"]; }else{_oRetentionPlanUsage.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLANUSAGE_RATE_PLAN_VAS_VALUE"])) {_oRetentionPlanUsage.rate_plan_vas_value = (string)_oData["RETENTIONPLANUSAGE_RATE_PLAN_VAS_VALUE"]; }else{_oRetentionPlanUsage.rate_plan_vas_value=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLANUSAGE_RATE_PLAN_VAS"])) {_oRetentionPlanUsage.rate_plan_vas = (string)_oData["RETENTIONPLANUSAGE_RATE_PLAN_VAS"]; }else{_oRetentionPlanUsage.rate_plan_vas=global::System.String.Empty;}
                        _oRetentionPlanUsage.SetDB(x_oDB);
                        _oRetentionPlanUsage.GetFound();
                        _oRow.Add(_oRetentionPlanUsage);
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
        
        
        public static RetentionPlanUsageEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<RetentionPlanUsageEntity> _oRetentionPlanUsageList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oRetentionPlanUsageList==null){ return null;}
            return _oRetentionPlanUsageList.Count == 0 ? null : _oRetentionPlanUsageList.ToArray();
        }
        
        
        public static RetentionPlanUsageEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<RetentionPlanUsageEntity> _oRetentionPlanUsageList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oRetentionPlanUsageList==null){ return null;}
            return _oRetentionPlanUsageList.Count == 0 ? null : _oRetentionPlanUsageList.ToArray();
        }
        
        public static List<RetentionPlanUsageEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<RetentionPlanUsageEntity> _oRow = new List<RetentionPlanUsageEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[RetentionPlanUsage].[active] AS RETENTIONPLANUSAGE_ACTIVE,[RetentionPlanUsage].[cdate] AS RETENTIONPLANUSAGE_CDATE,[RetentionPlanUsage].[cid] AS RETENTIONPLANUSAGE_CID,[RetentionPlanUsage].[rate_plan] AS RETENTIONPLANUSAGE_RATE_PLAN,[RetentionPlanUsage].[id] AS RETENTIONPLANUSAGE_ID,[RetentionPlanUsage].[rate_plan_vas_value] AS RETENTIONPLANUSAGE_RATE_PLAN_VAS_VALUE,[RetentionPlanUsage].[rate_plan_vas] AS RETENTIONPLANUSAGE_RATE_PLAN_VAS";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[RetentionPlanUsage]","["+ Configurator.MSSQLTablePrefix + "RetentionPlanUsage]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = RetentionPlanUsageRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                RetentionPlanUsageEntity _oRetentionPlanUsage = RetentionPlanUsageRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLANUSAGE_ID"])) {_oRetentionPlanUsage.id = (global::System.Nullable<int>)_oData["RETENTIONPLANUSAGE_ID"]; } else {_oRetentionPlanUsage.id=null; }
                if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLANUSAGE_CDATE"])) {_oRetentionPlanUsage.cdate = (global::System.Nullable<DateTime>)_oData["RETENTIONPLANUSAGE_CDATE"]; } else {_oRetentionPlanUsage.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLANUSAGE_CID"])) {_oRetentionPlanUsage.cid = (string)_oData["RETENTIONPLANUSAGE_CID"]; } else {_oRetentionPlanUsage.cid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLANUSAGE_RATE_PLAN"])) {_oRetentionPlanUsage.rate_plan = (string)_oData["RETENTIONPLANUSAGE_RATE_PLAN"]; } else {_oRetentionPlanUsage.rate_plan=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLANUSAGE_ACTIVE"])) {_oRetentionPlanUsage.active = (global::System.Nullable<bool>)_oData["RETENTIONPLANUSAGE_ACTIVE"]; } else {_oRetentionPlanUsage.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLANUSAGE_RATE_PLAN_VAS_VALUE"])) {_oRetentionPlanUsage.rate_plan_vas_value = (string)_oData["RETENTIONPLANUSAGE_RATE_PLAN_VAS_VALUE"]; } else {_oRetentionPlanUsage.rate_plan_vas_value=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLANUSAGE_RATE_PLAN_VAS"])) {_oRetentionPlanUsage.rate_plan_vas = (string)_oData["RETENTIONPLANUSAGE_RATE_PLAN_VAS"]; } else {_oRetentionPlanUsage.rate_plan_vas=global::System.String.Empty; }
                _oRetentionPlanUsage.SetDB(x_oDB);
                _oRetentionPlanUsage.GetFound();
                _oRow.Add(_oRetentionPlanUsage);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( RetentionPlanUsage.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,RetentionPlanUsage.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(RetentionPlanUsage.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(RetentionPlanUsage.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [RetentionPlanUsage].[active] AS RETENTIONPLANUSAGE_ACTIVE,[RetentionPlanUsage].[cdate] AS RETENTIONPLANUSAGE_CDATE,[RetentionPlanUsage].[cid] AS RETENTIONPLANUSAGE_CID,[RetentionPlanUsage].[rate_plan] AS RETENTIONPLANUSAGE_RATE_PLAN,[RetentionPlanUsage].[id] AS RETENTIONPLANUSAGE_ID,[RetentionPlanUsage].[rate_plan_vas_value] AS RETENTIONPLANUSAGE_RATE_PLAN_VAS_VALUE,[RetentionPlanUsage].[rate_plan_vas] AS RETENTIONPLANUSAGE_RATE_PLAN_VAS  FROM  [RetentionPlanUsage]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[RetentionPlanUsage]","["+ Configurator.MSSQLTablePrefix + "RetentionPlanUsage]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"RetentionPlanUsage");
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
        
        public bool Insert(global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sRate_plan,global::System.Nullable<bool> x_bActive,string x_sRate_plan_vas_value,string x_sRate_plan_vas)
        {
            RetentionPlanUsage _oRetentionPlanUsage=RetentionPlanUsageRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oRetentionPlanUsage.cdate=x_dCdate;
            _oRetentionPlanUsage.cid=x_sCid;
            _oRetentionPlanUsage.rate_plan=x_sRate_plan;
            _oRetentionPlanUsage.active=x_bActive;
            _oRetentionPlanUsage.rate_plan_vas_value=x_sRate_plan_vas_value;
            _oRetentionPlanUsage.rate_plan_vas=x_sRate_plan_vas;
            return InsertWithOutLastID(n_oDB, _oRetentionPlanUsage);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sRate_plan,global::System.Nullable<bool> x_bActive,string x_sRate_plan_vas_value,string x_sRate_plan_vas)
        {
            RetentionPlanUsage _oRetentionPlanUsage=RetentionPlanUsageRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oRetentionPlanUsage.cdate=x_dCdate;
            _oRetentionPlanUsage.cid=x_sCid;
            _oRetentionPlanUsage.rate_plan=x_sRate_plan;
            _oRetentionPlanUsage.active=x_bActive;
            _oRetentionPlanUsage.rate_plan_vas_value=x_sRate_plan_vas_value;
            _oRetentionPlanUsage.rate_plan_vas=x_sRate_plan_vas;
            return InsertWithOutLastID(x_oDB, _oRetentionPlanUsage);
        }
        
        
        public bool Insert(RetentionPlanUsage x_oRetentionPlanUsage)
        {
            return InsertWithOutLastID(n_oDB, x_oRetentionPlanUsage);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is RetentionPlanUsage)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (RetentionPlanUsage)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,RetentionPlanUsage x_oRetentionPlanUsage)
        {
            return InsertWithOutLastID(x_oDB, x_oRetentionPlanUsage);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,RetentionPlanUsage x_oRetentionPlanUsage)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [RetentionPlanUsage]   ([active],[cdate],[cid],[rate_plan],[rate_plan_vas_value],[rate_plan_vas])  VALUES  (@active,@cdate,@cid,@rate_plan,@rate_plan_vas_value,@rate_plan_vas)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RetentionPlanUsage]","["+ Configurator.MSSQLTablePrefix + "RetentionPlanUsage]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oRetentionPlanUsage);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,RetentionPlanUsage x_oRetentionPlanUsage)
        {
            bool _bResult = false;
            if (!x_oRetentionPlanUsage.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oRetentionPlanUsage.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oRetentionPlanUsage.active; }
                if(x_oRetentionPlanUsage.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oRetentionPlanUsage.cdate; }
                if(x_oRetentionPlanUsage.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oRetentionPlanUsage.cid; }
                if(x_oRetentionPlanUsage.rate_plan==null){  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50).Value=x_oRetentionPlanUsage.rate_plan; }
                if(x_oRetentionPlanUsage.rate_plan_vas_value==null){  x_oCmd.Parameters.Add("@rate_plan_vas_value", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rate_plan_vas_value", global::System.Data.SqlDbType.NVarChar,250).Value=x_oRetentionPlanUsage.rate_plan_vas_value; }
                if(x_oRetentionPlanUsage.rate_plan_vas==null){  x_oCmd.Parameters.Add("@rate_plan_vas", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rate_plan_vas", global::System.Data.SqlDbType.NVarChar,250).Value=x_oRetentionPlanUsage.rate_plan_vas; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sRate_plan,global::System.Nullable<bool> x_bActive,string x_sRate_plan_vas_value,string x_sRate_plan_vas)
        {
            int _oLastID;
            RetentionPlanUsage _oRetentionPlanUsage=RetentionPlanUsageRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oRetentionPlanUsage.cdate=x_dCdate;
            _oRetentionPlanUsage.cid=x_sCid;
            _oRetentionPlanUsage.rate_plan=x_sRate_plan;
            _oRetentionPlanUsage.active=x_bActive;
            _oRetentionPlanUsage.rate_plan_vas_value=x_sRate_plan_vas_value;
            _oRetentionPlanUsage.rate_plan_vas=x_sRate_plan_vas;
            if(InsertWithLastID(x_oDB, _oRetentionPlanUsage,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(RetentionPlanUsage x_oRetentionPlanUsage)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oRetentionPlanUsage, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, RetentionPlanUsage x_oRetentionPlanUsage)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oRetentionPlanUsage, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is RetentionPlanUsage)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (RetentionPlanUsage)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,RetentionPlanUsage x_oRetentionPlanUsage, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [RetentionPlanUsage]   ([active],[cdate],[cid],[rate_plan],[rate_plan_vas_value],[rate_plan_vas])  VALUES  (@active,@cdate,@cid,@rate_plan,@rate_plan_vas_value,@rate_plan_vas)"+" SELECT  @@IDENTITY AS RetentionPlanUsage_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RetentionPlanUsage]","["+ Configurator.MSSQLTablePrefix + "RetentionPlanUsage]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oRetentionPlanUsage,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,RetentionPlanUsage x_oRetentionPlanUsage, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oRetentionPlanUsage.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oRetentionPlanUsage.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oRetentionPlanUsage.active; }
                if(x_oRetentionPlanUsage.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oRetentionPlanUsage.cdate; }
                if(x_oRetentionPlanUsage.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oRetentionPlanUsage.cid; }
                if(x_oRetentionPlanUsage.rate_plan==null){  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50).Value=x_oRetentionPlanUsage.rate_plan; }
                if(x_oRetentionPlanUsage.rate_plan_vas_value==null){  x_oCmd.Parameters.Add("@rate_plan_vas_value", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rate_plan_vas_value", global::System.Data.SqlDbType.NVarChar,250).Value=x_oRetentionPlanUsage.rate_plan_vas_value; }
                if(x_oRetentionPlanUsage.rate_plan_vas==null){  x_oCmd.Parameters.Add("@rate_plan_vas", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rate_plan_vas", global::System.Data.SqlDbType.NVarChar,250).Value=x_oRetentionPlanUsage.rate_plan_vas; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["RetentionPlanUsage_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["RetentionPlanUsage_LASTID"].ToString()) && int.TryParse(_oData["RetentionPlanUsage_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sRate_plan,global::System.Nullable<bool> x_bActive,string x_sRate_plan_vas_value,string x_sRate_plan_vas)
        {
            int _oLastID;
            RetentionPlanUsage _oRetentionPlanUsage=RetentionPlanUsageRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oRetentionPlanUsage.cdate=x_dCdate;
            _oRetentionPlanUsage.cid=x_sCid;
            _oRetentionPlanUsage.rate_plan=x_sRate_plan;
            _oRetentionPlanUsage.active=x_bActive;
            _oRetentionPlanUsage.rate_plan_vas_value=x_sRate_plan_vas_value;
            _oRetentionPlanUsage.rate_plan_vas=x_sRate_plan_vas;
            if(InsertWithLastID_SP(x_oDB, _oRetentionPlanUsage,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(RetentionPlanUsage x_oRetentionPlanUsage)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oRetentionPlanUsage, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, RetentionPlanUsage x_oRetentionPlanUsage)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oRetentionPlanUsage, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is RetentionPlanUsage)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (RetentionPlanUsage)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,RetentionPlanUsage x_oRetentionPlanUsage, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "RETENTIONPLANUSAGE";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oRetentionPlanUsage,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,RetentionPlanUsage x_oRetentionPlanUsage, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oRetentionPlanUsage.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oRetentionPlanUsage.active; }
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oRetentionPlanUsage.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oRetentionPlanUsage.cdate; }
                _oPar=x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oRetentionPlanUsage.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oRetentionPlanUsage.cid; }
                _oPar=x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oRetentionPlanUsage.rate_plan==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oRetentionPlanUsage.rate_plan; }
                _oPar=x_oCmd.Parameters.Add("@rate_plan_vas_value", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oRetentionPlanUsage.rate_plan_vas_value==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oRetentionPlanUsage.rate_plan_vas_value; }
                _oPar=x_oCmd.Parameters.Add("@rate_plan_vas", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oRetentionPlanUsage.rate_plan_vas==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oRetentionPlanUsage.rate_plan_vas; }
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
        
        #region INSERT_RETENTIONPLANUSAGE Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2011-10-04>
        ///-- Description:	<Description,RETENTIONPLANUSAGE, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_RETENTIONPLANUSAGE Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_RETENTIONPLANUSAGE', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_RETENTIONPLANUSAGE;
        GO
        CREATE PROCEDURE INSERT_RETENTIONPLANUSAGE
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @cdate datetime,
        @cid nvarchar(50),
        @rate_plan nvarchar(50),
        @active bit,
        @rate_plan_vas_value nvarchar(250),
        @rate_plan_vas nvarchar(250)
        AS
        
        INSERT INTO  [RetentionPlanUsage]   ([active],[cdate],[cid],[rate_plan],[rate_plan_vas_value],[rate_plan_vas])  VALUES  (@active,@cdate,@cid,@rate_plan,@rate_plan_vas_value,@rate_plan_vas)
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
            string _sQuery = "DELETE FROM  [RetentionPlanUsage]  WHERE [RetentionPlanUsage].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RetentionPlanUsage]","["+ Configurator.MSSQLTablePrefix + "RetentionPlanUsage]"); }
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
            return RetentionPlanUsageRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [RetentionPlanUsage]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RetentionPlanUsage]","["+ Configurator.MSSQLTablePrefix + "RetentionPlanUsage]"); }
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
            string _sQuery = "DELETE FROM [RetentionPlanUsage]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RetentionPlanUsage]","["+ Configurator.MSSQLTablePrefix + "RetentionPlanUsage]"); }
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


