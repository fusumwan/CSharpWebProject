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
///-- Create date: <Create Date 2009-11-17>
///-- Description:	<Description,Table :[RetentionPlan],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [RetentionPlan] Insert / list / delete manager layer
    /// </summary>

    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name = Configurator.MSSQLTablePrefix + "RetentionPlan")]
    public class RetentionPlanRepositoryBase : global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable
    {

        #region Instance
        private static RetentionPlanRepositoryBase instance;
        public static RetentionPlanRepositoryBase Instance()
        {
            if (instance == null)
            {
                MSSQLConnect _oDB = new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new RetentionPlanRepositoryBase(_oDB);
            }
            return instance;
        }
        public static RetentionPlanRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if (instance == null)
                instance = new RetentionPlanRepositoryBase(x_oDB);
            return instance;
        }
        #endregion

        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<RetentionPlanEntity> RetentionPlans;
        #endregion

        #region Constructor
        public RetentionPlanRepositoryBase(MSSQLConnect x_oDB)
            : base(x_oDB.ConnectionStr)
        {
            n_oDB = x_oDB;
        }
        ~RetentionPlanRepositoryBase()
        {
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
        public static RetentionPlan CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new RetentionPlan(_oDB);
        }

        public static RetentionPlan CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new RetentionPlan(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [RetentionPlan]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RetentionPlan]", "[" + Configurator.MSSQLTablePrefix + "RetentionPlan]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
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
                catch (Exception exp) { string _sError = exp.ToString(); }
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


        public RetentionPlanEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }


        public static RetentionPlanEntity GetObj(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            if (x_oDB == null) { return null; }
            RetentionPlan _RetentionPlan = (RetentionPlan)RetentionPlanRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_RetentionPlan.Load(x_iId)) { return null; }
            return _RetentionPlan;
        }



        public static RetentionPlanEntity[] GetArrayObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            List<RetentionPlanEntity> _oRetentionPlanList = GetListObj(x_oDB, 0, "id", x_oArrayItemId);
            return _oRetentionPlanList.Count == 0 ? null : _oRetentionPlanList.ToArray();
        }

        public static List<RetentionPlanEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB, 0, "id", x_oArrayItemId);
        }


        public static RetentionPlanEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<RetentionPlanEntity> _oRetentionPlanList = GetListObj(x_oDB, 0, x_oColumnName, x_oArrayItemId);
            return _oRetentionPlanList.Count == 0 ? null : _oRetentionPlanList.ToArray();
        }


        public static RetentionPlanEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<RetentionPlanEntity> _oRetentionPlanList = GetListObj(x_oDB, x_iTop, x_oColumnName, x_oArrayItemId);
            return _oRetentionPlanList.Count == 0 ? null : _oRetentionPlanList.ToArray();
        }

        public static List<RetentionPlanEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB == null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            List<RetentionPlanEntity> _oRow = new List<RetentionPlanEntity>();
            string _sQuery = "SELECT  " + _sTop + " [RetentionPlan].[id] AS RETENTIONPLAN_ID,[RetentionPlan].[cdate] AS RETENTIONPLAN_CDATE,[RetentionPlan].[cid] AS RETENTIONPLAN_CID,[RetentionPlan].[did] AS RETENTIONPLAN_DID,[RetentionPlan].[active] AS RETENTIONPLAN_ACTIVE,[RetentionPlan].[plan_code] AS RETENTIONPLAN_PLAN_CODE,[RetentionPlan].[plan_fee] AS RETENTIONPLAN_PLAN_FEE,[RetentionPlan].[ddate] AS RETENTIONPLAN_DDATE  FROM  [RetentionPlan]";
            if (x_oArrayItemId == null)
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
                _sQuery += " WHERE [RetentionPlan].[" + x_oColumnName.ToString() + "]  in " + _oList;
            }

            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RetentionPlan]", "[" + Configurator.MSSQLTablePrefix + "RetentionPlan]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        RetentionPlan _oRetentionPlan = RetentionPlanRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLAN_ID"])) { _oRetentionPlan.id = (global::System.Nullable<int>)_oData["RETENTIONPLAN_ID"]; } else { _oRetentionPlan.id = null; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLAN_CDATE"])) { _oRetentionPlan.cdate = (global::System.Nullable<DateTime>)_oData["RETENTIONPLAN_CDATE"]; } else { _oRetentionPlan.cdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLAN_CID"])) { _oRetentionPlan.cid = (string)_oData["RETENTIONPLAN_CID"]; } else { _oRetentionPlan.cid = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLAN_DID"])) { _oRetentionPlan.did = (string)_oData["RETENTIONPLAN_DID"]; } else { _oRetentionPlan.did = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLAN_ACTIVE"])) { _oRetentionPlan.active = (global::System.Nullable<bool>)_oData["RETENTIONPLAN_ACTIVE"]; } else { _oRetentionPlan.active = null; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLAN_PLAN_CODE"])) { _oRetentionPlan.plan_code = (string)_oData["RETENTIONPLAN_PLAN_CODE"]; } else { _oRetentionPlan.plan_code = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLAN_PLAN_FEE"])) { _oRetentionPlan.plan_fee = (global::System.Nullable<double>)_oData["RETENTIONPLAN_PLAN_FEE"]; } else { _oRetentionPlan.plan_fee = null; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLAN_DDATE"])) { _oRetentionPlan.ddate = (global::System.Nullable<DateTime>)_oData["RETENTIONPLAN_DDATE"]; } else { _oRetentionPlan.ddate = null; }
                        _oRetentionPlan.SetDB(x_oDB);
                        _oRetentionPlan.GetFound();
                        _oRow.Add(_oRetentionPlan);
                    }
                    _oData.Close();
                    _oData.Dispose();
                }
                catch (Exception exp) { string _sError = exp.ToString(); }
                finally
                {
                    _oConn.Close();
                    _oCmd.Dispose();
                    _oConn.Dispose();
                }
                return _oRow;
            }
        }


        public static RetentionPlanEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<RetentionPlanEntity> _oRetentionPlanList = GetListObj(x_oDB, 0, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oRetentionPlanList.Count == 0 ? null : _oRetentionPlanList.ToArray();
        }


        public static RetentionPlanEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<RetentionPlanEntity> _oRetentionPlanList = GetListObj(x_oDB, x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oRetentionPlanList.Count == 0 ? null : _oRetentionPlanList.ToArray();
        }

        public static List<RetentionPlanEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB == null) { return null; }
            List<RetentionPlanEntity> _oRow = new List<RetentionPlanEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            string _sFields = "[RetentionPlan].[id] AS RETENTIONPLAN_ID,[RetentionPlan].[cdate] AS RETENTIONPLAN_CDATE,[RetentionPlan].[cid] AS RETENTIONPLAN_CID,[RetentionPlan].[did] AS RETENTIONPLAN_DID,[RetentionPlan].[active] AS RETENTIONPLAN_ACTIVE,[RetentionPlan].[plan_code] AS RETENTIONPLAN_PLAN_CODE,[RetentionPlan].[plan_fee] AS RETENTIONPLAN_PLAN_FEE,[RetentionPlan].[ddate] AS RETENTIONPLAN_DDATE";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[RetentionPlan]", "[" + Configurator.MSSQLTablePrefix + "RetentionPlan]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = RetentionPlanRepositoryBase.GetSearch(x_oDB, _sTop.ToString() + _sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                RetentionPlanEntity _oRetentionPlan = RetentionPlanRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLAN_ID"])) { _oRetentionPlan.id = (global::System.Nullable<int>)_oData["RETENTIONPLAN_ID"]; } else { _oRetentionPlan.id = null; }
                if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLAN_CDATE"])) { _oRetentionPlan.cdate = (global::System.Nullable<DateTime>)_oData["RETENTIONPLAN_CDATE"]; } else { _oRetentionPlan.cdate = null; }
                if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLAN_CID"])) { _oRetentionPlan.cid = (string)_oData["RETENTIONPLAN_CID"]; } else { _oRetentionPlan.cid = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLAN_DID"])) { _oRetentionPlan.did = (string)_oData["RETENTIONPLAN_DID"]; } else { _oRetentionPlan.did = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLAN_ACTIVE"])) { _oRetentionPlan.active = (global::System.Nullable<bool>)_oData["RETENTIONPLAN_ACTIVE"]; } else { _oRetentionPlan.active = null; }
                if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLAN_PLAN_CODE"])) { _oRetentionPlan.plan_code = (string)_oData["RETENTIONPLAN_PLAN_CODE"]; } else { _oRetentionPlan.plan_code = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLAN_PLAN_FEE"])) { _oRetentionPlan.plan_fee = (global::System.Nullable<double>)_oData["RETENTIONPLAN_PLAN_FEE"]; } else { _oRetentionPlan.plan_fee = null; }
                if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLAN_DDATE"])) { _oRetentionPlan.ddate = (global::System.Nullable<DateTime>)_oData["RETENTIONPLAN_DDATE"]; } else { _oRetentionPlan.ddate = null; }
                _oRetentionPlan.SetDB(x_oDB);
                _oRetentionPlan.GetFound();
                _oRow.Add(_oRetentionPlan);
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
            return GetDataSet(n_oDB, "");
        }


        public global::System.Data.DataSet GetDataSet(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return GetDataSet(n_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }


        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB == null) { return null; }
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet(RetentionPlan.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder, RetentionPlan.Para.TableName());
            return _oDset;
        }


        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB == null) { return null; }
            return x_oDB.GetSearch(RetentionPlan.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }


        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(RetentionPlan.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            if (x_oDB == null) { return null; }
            string _oQuery = "SELECT   [RetentionPlan].[id] AS RETENTIONPLAN_ID,[RetentionPlan].[cdate] AS RETENTIONPLAN_CDATE,[RetentionPlan].[cid] AS RETENTIONPLAN_CID,[RetentionPlan].[did] AS RETENTIONPLAN_DID,[RetentionPlan].[active] AS RETENTIONPLAN_ACTIVE,[RetentionPlan].[plan_code] AS RETENTIONPLAN_PLAN_CODE,[RetentionPlan].[plan_fee] AS RETENTIONPLAN_PLAN_FEE,[RetentionPlan].[ddate] AS RETENTIONPLAN_DDATE  FROM  [RetentionPlan]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[RetentionPlan]", "[" + Configurator.MSSQLTablePrefix + "RetentionPlan]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery, _oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset, "RetentionPlan");
                }
                catch (Exception exp) { string _sError = exp.ToString(); }
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

        public bool Insert(global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sDid, global::System.Nullable<bool> x_bActive, string x_sPlan_code, global::System.Nullable<double> x_dPlan_fee, global::System.Nullable<DateTime> x_dDdate)
        {
            RetentionPlan _oRetentionPlan = RetentionPlanRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oRetentionPlan.cdate = x_dCdate;
            _oRetentionPlan.cid = x_sCid;
            _oRetentionPlan.did = x_sDid;
            _oRetentionPlan.active = x_bActive;
            _oRetentionPlan.plan_code = x_sPlan_code;
            _oRetentionPlan.plan_fee = x_dPlan_fee;
            _oRetentionPlan.ddate = x_dDdate;
            return InsertWithOutLastID(n_oDB, _oRetentionPlan);
        }


        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sDid, global::System.Nullable<bool> x_bActive, string x_sPlan_code, global::System.Nullable<double> x_dPlan_fee, global::System.Nullable<DateTime> x_dDdate)
        {
            RetentionPlan _oRetentionPlan = RetentionPlanRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oRetentionPlan.cdate = x_dCdate;
            _oRetentionPlan.cid = x_sCid;
            _oRetentionPlan.did = x_sDid;
            _oRetentionPlan.active = x_bActive;
            _oRetentionPlan.plan_code = x_sPlan_code;
            _oRetentionPlan.plan_fee = x_dPlan_fee;
            _oRetentionPlan.ddate = x_dDdate;
            return InsertWithOutLastID(x_oDB, _oRetentionPlan);
        }


        public bool Insert(RetentionPlan x_oRetentionPlan)
        {
            return InsertWithOutLastID(n_oDB, x_oRetentionPlan);
        }


        public bool InsertEntity(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is RetentionPlan)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (RetentionPlan)x_oObj);
        }


        public static bool Insert(MSSQLConnect x_oDB, RetentionPlan x_oRetentionPlan)
        {
            return InsertWithOutLastID(x_oDB, x_oRetentionPlan);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, RetentionPlan x_oRetentionPlan)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT INTO  [RetentionPlan]   ([cdate],[cid],[did],[active],[plan_code],[plan_fee],[ddate])  VALUES  (@cdate,@cid,@did,@active,@plan_code,@plan_fee,@ddate)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RetentionPlan]", "[" + Configurator.MSSQLTablePrefix + "RetentionPlan]"); }
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
            return InsertTransactionWithOutLastID(x_oDB, _oConn, _oCmd, x_oRetentionPlan);
        }

        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, RetentionPlan x_oRetentionPlan)
        {
            bool _bResult = false;
            if (!x_oRetentionPlan.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if (x_oRetentionPlan.cdate == null) { x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = x_oRetentionPlan.cdate; }
                if (x_oRetentionPlan.cid == null) { x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10).Value = x_oRetentionPlan.cid; }
                if (x_oRetentionPlan.did == null) { x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10).Value = x_oRetentionPlan.did; }
                if (x_oRetentionPlan.active == null) { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = x_oRetentionPlan.active; }
                if (x_oRetentionPlan.plan_code == null) { x_oCmd.Parameters.Add("@plan_code", global::System.Data.SqlDbType.NVarChar, 50).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@plan_code", global::System.Data.SqlDbType.NVarChar, 50).Value = x_oRetentionPlan.plan_code; }
                if (x_oRetentionPlan.plan_fee == null) { x_oCmd.Parameters.Add("@plan_fee", global::System.Data.SqlDbType.Float).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@plan_fee", global::System.Data.SqlDbType.Float).Value = x_oRetentionPlan.plan_fee; }
                if (x_oRetentionPlan.ddate == null) { x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = x_oRetentionPlan.ddate; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State == ConnectionState.Closed) x_oConn.Open();
                _bResult = Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
            }
            catch (Exception exp) { string _sError = exp.ToString(); }
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


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sDid, global::System.Nullable<bool> x_bActive, string x_sPlan_code, global::System.Nullable<double> x_dPlan_fee, global::System.Nullable<DateTime> x_dDdate)
        {
            int _oLastID;
            RetentionPlan _oRetentionPlan = RetentionPlanRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oRetentionPlan.cdate = x_dCdate;
            _oRetentionPlan.cid = x_sCid;
            _oRetentionPlan.did = x_sDid;
            _oRetentionPlan.active = x_bActive;
            _oRetentionPlan.plan_code = x_sPlan_code;
            _oRetentionPlan.plan_fee = x_dPlan_fee;
            _oRetentionPlan.ddate = x_dDdate;
            if (InsertWithLastID_SP(x_oDB, _oRetentionPlan, out _oLastID))
            {
                return _oLastID;
            }
            else
            {
                return -1;
            }
        }


        public int InsertReturnLastID_SP(RetentionPlan x_oRetentionPlan)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oRetentionPlan, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, RetentionPlan x_oRetentionPlan)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oRetentionPlan, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is RetentionPlan)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (RetentionPlan)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB, RetentionPlan x_oRetentionPlan, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "RETENTIONPLAN";
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
            return InsertTransactionWithLastID_SP(x_oDB, _oConn, _oCmd, x_oRetentionPlan, out x_oLAST_ID);
        }

        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, RetentionPlan x_oRetentionPlan, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar = x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oRetentionPlan.cdate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oRetentionPlan.cdate; }
                _oPar = x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oRetentionPlan.cid == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oRetentionPlan.cid; }
                _oPar = x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oRetentionPlan.did == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oRetentionPlan.did; }
                _oPar = x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oRetentionPlan.active == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oRetentionPlan.active; }
                _oPar = x_oCmd.Parameters.Add("@plan_code", global::System.Data.SqlDbType.NVarChar, 50);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oRetentionPlan.plan_code == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oRetentionPlan.plan_code; }
                _oPar = x_oCmd.Parameters.Add("@plan_fee", global::System.Data.SqlDbType.Float);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oRetentionPlan.plan_fee == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oRetentionPlan.plan_fee; }
                _oPar = x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oRetentionPlan.ddate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oRetentionPlan.ddate; }
                _oPar = x_oCmd.Parameters.Add("@RETURN_ID", global::System.Data.SqlDbType.Int);
                _oPar.Direction = ParameterDirection.Output;
                x_oCmd.CommandType = CommandType.StoredProcedure;
                if (!x_oDB.bTransaction && x_oConn.State == ConnectionState.Closed) x_oConn.Open();
                _bResult = Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
                x_oLAST_ID = Int32.Parse(x_oCmd.Parameters["@RETURN_ID"].Value.ToString());
            }
            catch (Exception exp) { string _sError = exp.ToString(); }
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

        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            return -1;
        }

        #region INSERT_RETENTIONPLAN Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2009-11-17>
        ///-- Description:	<Description,RETENTIONPLAN, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_RETENTIONPLAN Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_RETENTIONPLAN', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_RETENTIONPLAN;
        GO
        CREATE PROCEDURE INSERT_RETENTIONPLAN
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @cdate datetime,
        @cid char(10),
        @did char(10),
        @active bit,
        @plan_code nvarchar(50),
        @plan_fee float,
        @ddate datetime
        AS
        
        INSERT INTO  [RetentionPlan]   ([cdate],[cid],[did],[active],[plan_code],[plan_fee],[ddate])  VALUES  (@cdate,@cid,@did,@active,@plan_code,@plan_fee,@ddate)
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

        public static bool Delete(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            return DeleteProc(x_oDB, x_iId);
        }


        private static bool DeleteProc(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            if (x_iId == null) { return false; }
            string _sQuery = "DELETE FROM  [RetentionPlan]  WHERE [RetentionPlan].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RetentionPlan]", "[" + Configurator.MSSQLTablePrefix + "RetentionPlan]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult = false;
                _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = x_iId;
                try
                {
                    _oConn.Open();
                    _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
                }
                catch (Exception exp) { string _sError = exp.ToString(); }
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
            if (n_oDB == null) { return false; }
            return RetentionPlanRepositoryBase.DeleteAll(n_oDB);
        }

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "DELETE FROM  [RetentionPlan]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RetentionPlan]", "[" + Configurator.MSSQLTablePrefix + "RetentionPlan]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult = false;
                try
                {
                    _oConn.Open();
                    _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
                }
                catch (Exception exp) { string _sError = exp.ToString(); }
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
            return DeleteFilter(n_oDB, x_sFilter);
        }

        public static bool DeleteFilter(MSSQLConnect x_oDB, string x_sFilter)
        {
            if (x_oDB == null) { return false; }
            if (!"".Equals(x_sFilter)) { x_sFilter = " WHERE " + x_sFilter; }
            string _sQuery = "DELETE FROM [RetentionPlan]" + x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RetentionPlan]", "[" + Configurator.MSSQLTablePrefix + "RetentionPlan]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult = false;
                try
                {
                    _oConn.Open();
                    _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
                }
                catch (Exception exp) { string _sError = exp.ToString(); }
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

