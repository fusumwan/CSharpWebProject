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
///-- Create date: <Create Date 2009-11-17>
///-- Description:	<Description,Table :[SpecialPremium],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [SpecialPremium] Insert / list / delete manager layer
    /// </summary>

    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name = Configurator.MSSQLTablePrefix + "SpecialPremium")]
    public class SpecialPremiumRepositoryBase : global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable
    {

        #region Instance
        private static SpecialPremiumRepositoryBase instance;
        public static SpecialPremiumRepositoryBase Instance()
        {
            if (instance == null)
            {
                MSSQLConnect _oDB = new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new SpecialPremiumRepositoryBase(_oDB);
            }
            return instance;
        }
        public static SpecialPremiumRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if (instance == null)
                instance = new SpecialPremiumRepositoryBase(x_oDB);
            return instance;
        }
        #endregion

        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<SpecialPremiumEntity> SpecialPremiums;
        #endregion

        #region Constructor
        public SpecialPremiumRepositoryBase(MSSQLConnect x_oDB)
            : base(x_oDB.ConnectionStr)
        {
            n_oDB = x_oDB;
        }
        ~SpecialPremiumRepositoryBase()
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
        public static SpecialPremium CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new SpecialPremium(_oDB);
        }

        public static SpecialPremium CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new SpecialPremium(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [SpecialPremium]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[SpecialPremium]", "[" + Configurator.MSSQLTablePrefix + "SpecialPremium]"); }
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


        public SpecialPremiumEntity GetObj(global::System.Nullable<int> x_iMid)
        {
            return GetObj(n_oDB, x_iMid);
        }


        public static SpecialPremiumEntity GetObj(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            if (x_oDB == null) { return null; }
            SpecialPremium _SpecialPremium = (SpecialPremium)SpecialPremiumRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_SpecialPremium.Load(x_iMid)) { return null; }
            return _SpecialPremium;
        }



        public static SpecialPremiumEntity[] GetArrayObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            List<SpecialPremiumEntity> _oSpecialPremiumList = GetListObj(x_oDB, 0, "mid", x_oArrayItemId);
            return _oSpecialPremiumList.Count == 0 ? null : _oSpecialPremiumList.ToArray();
        }

        public static List<SpecialPremiumEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB, 0, "mid", x_oArrayItemId);
        }


        public static SpecialPremiumEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<SpecialPremiumEntity> _oSpecialPremiumList = GetListObj(x_oDB, 0, x_oColumnName, x_oArrayItemId);
            return _oSpecialPremiumList.Count == 0 ? null : _oSpecialPremiumList.ToArray();
        }


        public static SpecialPremiumEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<SpecialPremiumEntity> _oSpecialPremiumList = GetListObj(x_oDB, x_iTop, x_oColumnName, x_oArrayItemId);
            return _oSpecialPremiumList.Count == 0 ? null : _oSpecialPremiumList.ToArray();
        }

        public static List<SpecialPremiumEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB == null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            List<SpecialPremiumEntity> _oRow = new List<SpecialPremiumEntity>();
            string _sQuery = "SELECT  " + _sTop + " [SpecialPremium].[rate_plan] AS SPECIALPREMIUM_RATE_PLAN,[SpecialPremium].[cdate] AS SPECIALPREMIUM_CDATE,[SpecialPremium].[cid] AS SPECIALPREMIUM_CID,[SpecialPremium].[active] AS SPECIALPREMIUM_ACTIVE,[SpecialPremium].[ddate] AS SPECIALPREMIUM_DDATE,[SpecialPremium].[did] AS SPECIALPREMIUM_DID,[SpecialPremium].[con_per] AS SPECIALPREMIUM_CON_PER,[SpecialPremium].[mid] AS SPECIALPREMIUM_MID,[SpecialPremium].[s_premium] AS SPECIALPREMIUM_S_PREMIUM  FROM  [SpecialPremium]";
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
                _sQuery += " WHERE [SpecialPremium].[" + x_oColumnName.ToString() + "]  in " + _oList;
            }

            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[SpecialPremium]", "[" + Configurator.MSSQLTablePrefix + "SpecialPremium]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        SpecialPremium _oSpecialPremium = SpecialPremiumRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_ACTIVE"])) { _oSpecialPremium.active = (global::System.Nullable<bool>)_oData["SPECIALPREMIUM_ACTIVE"]; } else { _oSpecialPremium.active = null; }
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_CDATE"])) { _oSpecialPremium.cdate = (global::System.Nullable<DateTime>)_oData["SPECIALPREMIUM_CDATE"]; } else { _oSpecialPremium.cdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_CID"])) { _oSpecialPremium.cid = (string)_oData["SPECIALPREMIUM_CID"]; } else { _oSpecialPremium.cid = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_DID"])) { _oSpecialPremium.did = (string)_oData["SPECIALPREMIUM_DID"]; } else { _oSpecialPremium.did = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_CON_PER"])) { _oSpecialPremium.con_per = (string)_oData["SPECIALPREMIUM_CON_PER"]; } else { _oSpecialPremium.con_per = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_RATE_PLAN"])) { _oSpecialPremium.rate_plan = (string)_oData["SPECIALPREMIUM_RATE_PLAN"]; } else { _oSpecialPremium.rate_plan = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_DDATE"])) { _oSpecialPremium.ddate = (global::System.Nullable<DateTime>)_oData["SPECIALPREMIUM_DDATE"]; } else { _oSpecialPremium.ddate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_MID"])) { _oSpecialPremium.mid = (global::System.Nullable<int>)_oData["SPECIALPREMIUM_MID"]; } else { _oSpecialPremium.mid = null; }
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_S_PREMIUM"])) { _oSpecialPremium.s_premium = (string)_oData["SPECIALPREMIUM_S_PREMIUM"]; } else { _oSpecialPremium.s_premium = global::System.String.Empty; }
                        _oSpecialPremium.SetDB(x_oDB);
                        _oSpecialPremium.GetFound();
                        _oRow.Add(_oSpecialPremium);
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


        public static SpecialPremiumEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<SpecialPremiumEntity> _oSpecialPremiumList = GetListObj(x_oDB, 0, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oSpecialPremiumList.Count == 0 ? null : _oSpecialPremiumList.ToArray();
        }


        public static SpecialPremiumEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<SpecialPremiumEntity> _oSpecialPremiumList = GetListObj(x_oDB, x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oSpecialPremiumList.Count == 0 ? null : _oSpecialPremiumList.ToArray();
        }

        public static List<SpecialPremiumEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB == null) { return null; }
            List<SpecialPremiumEntity> _oRow = new List<SpecialPremiumEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            string _sFields = "[SpecialPremium].[rate_plan] AS SPECIALPREMIUM_RATE_PLAN,[SpecialPremium].[cdate] AS SPECIALPREMIUM_CDATE,[SpecialPremium].[cid] AS SPECIALPREMIUM_CID,[SpecialPremium].[active] AS SPECIALPREMIUM_ACTIVE,[SpecialPremium].[ddate] AS SPECIALPREMIUM_DDATE,[SpecialPremium].[did] AS SPECIALPREMIUM_DID,[SpecialPremium].[con_per] AS SPECIALPREMIUM_CON_PER,[SpecialPremium].[mid] AS SPECIALPREMIUM_MID,[SpecialPremium].[s_premium] AS SPECIALPREMIUM_S_PREMIUM";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[SpecialPremium]", "[" + Configurator.MSSQLTablePrefix + "SpecialPremium]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = SpecialPremiumRepositoryBase.GetSearch(x_oDB, _sTop.ToString() + _sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                SpecialPremiumEntity _oSpecialPremium = SpecialPremiumRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_ACTIVE"])) { _oSpecialPremium.active = (global::System.Nullable<bool>)_oData["SPECIALPREMIUM_ACTIVE"]; } else { _oSpecialPremium.active = null; }
                if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_CDATE"])) { _oSpecialPremium.cdate = (global::System.Nullable<DateTime>)_oData["SPECIALPREMIUM_CDATE"]; } else { _oSpecialPremium.cdate = null; }
                if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_CID"])) { _oSpecialPremium.cid = (string)_oData["SPECIALPREMIUM_CID"]; } else { _oSpecialPremium.cid = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_DID"])) { _oSpecialPremium.did = (string)_oData["SPECIALPREMIUM_DID"]; } else { _oSpecialPremium.did = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_CON_PER"])) { _oSpecialPremium.con_per = (string)_oData["SPECIALPREMIUM_CON_PER"]; } else { _oSpecialPremium.con_per = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_RATE_PLAN"])) { _oSpecialPremium.rate_plan = (string)_oData["SPECIALPREMIUM_RATE_PLAN"]; } else { _oSpecialPremium.rate_plan = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_DDATE"])) { _oSpecialPremium.ddate = (global::System.Nullable<DateTime>)_oData["SPECIALPREMIUM_DDATE"]; } else { _oSpecialPremium.ddate = null; }
                if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_MID"])) { _oSpecialPremium.mid = (global::System.Nullable<int>)_oData["SPECIALPREMIUM_MID"]; } else { _oSpecialPremium.mid = null; }
                if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_S_PREMIUM"])) { _oSpecialPremium.s_premium = (string)_oData["SPECIALPREMIUM_S_PREMIUM"]; } else { _oSpecialPremium.s_premium = global::System.String.Empty; }
                _oSpecialPremium.SetDB(x_oDB);
                _oSpecialPremium.GetFound();
                _oRow.Add(_oSpecialPremium);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet(SpecialPremium.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder, SpecialPremium.Para.TableName());
            return _oDset;
        }


        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB == null) { return null; }
            return x_oDB.GetSearch(SpecialPremium.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }


        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(SpecialPremium.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            if (x_oDB == null) { return null; }
            string _oQuery = "SELECT   [SpecialPremium].[rate_plan] AS SPECIALPREMIUM_RATE_PLAN,[SpecialPremium].[cdate] AS SPECIALPREMIUM_CDATE,[SpecialPremium].[cid] AS SPECIALPREMIUM_CID,[SpecialPremium].[active] AS SPECIALPREMIUM_ACTIVE,[SpecialPremium].[ddate] AS SPECIALPREMIUM_DDATE,[SpecialPremium].[did] AS SPECIALPREMIUM_DID,[SpecialPremium].[con_per] AS SPECIALPREMIUM_CON_PER,[SpecialPremium].[mid] AS SPECIALPREMIUM_MID,[SpecialPremium].[s_premium] AS SPECIALPREMIUM_S_PREMIUM  FROM  [SpecialPremium]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[SpecialPremium]", "[" + Configurator.MSSQLTablePrefix + "SpecialPremium]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery, _oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset, "SpecialPremium");
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

        public bool Insert(global::System.Nullable<bool> x_bActive, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sDid, string x_sCon_per, string x_sRate_plan, global::System.Nullable<DateTime> x_dDdate, string x_sS_premium)
        {
            SpecialPremium _oSpecialPremium = SpecialPremiumRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oSpecialPremium.active = x_bActive;
            _oSpecialPremium.cdate = x_dCdate;
            _oSpecialPremium.cid = x_sCid;
            _oSpecialPremium.did = x_sDid;
            _oSpecialPremium.con_per = x_sCon_per;
            _oSpecialPremium.rate_plan = x_sRate_plan;
            _oSpecialPremium.ddate = x_dDdate;
            _oSpecialPremium.s_premium = x_sS_premium;
            return InsertWithOutLastID(n_oDB, _oSpecialPremium);
        }


        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bActive, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sDid, string x_sCon_per, string x_sRate_plan, global::System.Nullable<DateTime> x_dDdate, string x_sS_premium)
        {
            SpecialPremium _oSpecialPremium = SpecialPremiumRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oSpecialPremium.active = x_bActive;
            _oSpecialPremium.cdate = x_dCdate;
            _oSpecialPremium.cid = x_sCid;
            _oSpecialPremium.did = x_sDid;
            _oSpecialPremium.con_per = x_sCon_per;
            _oSpecialPremium.rate_plan = x_sRate_plan;
            _oSpecialPremium.ddate = x_dDdate;
            _oSpecialPremium.s_premium = x_sS_premium;
            return InsertWithOutLastID(x_oDB, _oSpecialPremium);
        }


        public bool Insert(SpecialPremium x_oSpecialPremium)
        {
            return InsertWithOutLastID(n_oDB, x_oSpecialPremium);
        }


        public bool InsertEntity(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is SpecialPremium)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (SpecialPremium)x_oObj);
        }


        public static bool Insert(MSSQLConnect x_oDB, SpecialPremium x_oSpecialPremium)
        {
            return InsertWithOutLastID(x_oDB, x_oSpecialPremium);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, SpecialPremium x_oSpecialPremium)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT INTO  [SpecialPremium]   ([rate_plan],[cdate],[cid],[active],[ddate],[did],[con_per],[s_premium])  VALUES  (@rate_plan,@cdate,@cid,@active,@ddate,@did,@con_per,@s_premium)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[SpecialPremium]", "[" + Configurator.MSSQLTablePrefix + "SpecialPremium]"); }
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
            return InsertTransactionWithOutLastID(x_oDB, _oConn, _oCmd, x_oSpecialPremium);
        }

        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, SpecialPremium x_oSpecialPremium)
        {
            bool _bResult = false;
            if (!x_oSpecialPremium.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if (x_oSpecialPremium.rate_plan == null) { x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar, 50).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar, 50).Value = x_oSpecialPremium.rate_plan; }
                if (x_oSpecialPremium.cdate == null) { x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = x_oSpecialPremium.cdate; }
                if (x_oSpecialPremium.cid == null) { x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10).Value = x_oSpecialPremium.cid; }
                if (x_oSpecialPremium.active == null) { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = x_oSpecialPremium.active; }
                if (x_oSpecialPremium.ddate == null) { x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = x_oSpecialPremium.ddate; }
                if (x_oSpecialPremium.did == null) { x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10).Value = x_oSpecialPremium.did; }
                if (x_oSpecialPremium.con_per == null) { x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar, 10).Value = x_oSpecialPremium.con_per; }
                if (x_oSpecialPremium.s_premium == null) { x_oCmd.Parameters.Add("@s_premium", global::System.Data.SqlDbType.NVarChar, 50).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@s_premium", global::System.Data.SqlDbType.NVarChar, 50).Value = x_oSpecialPremium.s_premium; }
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


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bActive, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sDid, string x_sCon_per, string x_sRate_plan, global::System.Nullable<DateTime> x_dDdate, string x_sS_premium)
        {
            int _oLastID;
            SpecialPremium _oSpecialPremium = SpecialPremiumRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oSpecialPremium.active = x_bActive;
            _oSpecialPremium.cdate = x_dCdate;
            _oSpecialPremium.cid = x_sCid;
            _oSpecialPremium.did = x_sDid;
            _oSpecialPremium.con_per = x_sCon_per;
            _oSpecialPremium.rate_plan = x_sRate_plan;
            _oSpecialPremium.ddate = x_dDdate;
            _oSpecialPremium.s_premium = x_sS_premium;
            if (InsertWithLastID_SP(x_oDB, _oSpecialPremium, out _oLastID))
            {
                return _oLastID;
            }
            else
            {
                return -1;
            }
        }


        public int InsertReturnLastID_SP(SpecialPremium x_oSpecialPremium)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oSpecialPremium, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, SpecialPremium x_oSpecialPremium)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oSpecialPremium, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is SpecialPremium)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (SpecialPremium)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB, SpecialPremium x_oSpecialPremium, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "SPECIALPREMIUM";
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
            return InsertTransactionWithLastID_SP(x_oDB, _oConn, _oCmd, x_oSpecialPremium, out x_oLAST_ID);
        }

        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, SpecialPremium x_oSpecialPremium, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar = x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar, 50);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oSpecialPremium.rate_plan == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oSpecialPremium.rate_plan; }
                _oPar = x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oSpecialPremium.cdate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oSpecialPremium.cdate; }
                _oPar = x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oSpecialPremium.cid == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oSpecialPremium.cid; }
                _oPar = x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oSpecialPremium.active == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oSpecialPremium.active; }
                _oPar = x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oSpecialPremium.ddate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oSpecialPremium.ddate; }
                _oPar = x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oSpecialPremium.did == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oSpecialPremium.did; }
                _oPar = x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oSpecialPremium.con_per == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oSpecialPremium.con_per; }
                _oPar = x_oCmd.Parameters.Add("@s_premium", global::System.Data.SqlDbType.NVarChar, 50);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oSpecialPremium.s_premium == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oSpecialPremium.s_premium; }
                _oPar = x_oCmd.Parameters.Add("@RETURN_MID", global::System.Data.SqlDbType.Int);
                _oPar.Direction = ParameterDirection.Output;
                x_oCmd.CommandType = CommandType.StoredProcedure;
                if (!x_oDB.bTransaction && x_oConn.State == ConnectionState.Closed) x_oConn.Open();
                _bResult = Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
                x_oLAST_ID = Int32.Parse(x_oCmd.Parameters["@RETURN_MID"].Value.ToString());
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

        #region INSERT_SPECIALPREMIUM Store Procedures
        ///-- =============================================
        ///-- Author:		<Author,Philip SW>
        ///-- Create date: <Create Date 2009-11-17>
        ///-- Description:	<Description,SPECIALPREMIUM, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_SPECIALPREMIUM Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_SPECIALPREMIUM', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_SPECIALPREMIUM;
        GO
        CREATE PROCEDURE INSERT_SPECIALPREMIUM
        	-- Add the parameters for the stored procedure here
        @RETURN_MID int output,
        @active bit,
        @cdate datetime,
        @cid char(10),
        @did char(10),
        @con_per nvarchar(10),
        @rate_plan nvarchar(50),
        @ddate datetime,
        @s_premium nvarchar(50)
        AS
        
        INSERT INTO  [SpecialPremium]   ([rate_plan],[cdate],[cid],[active],[ddate],[did],[con_per],[s_premium])  VALUES  (@rate_plan,@cdate,@cid,@active,@ddate,@did,@con_per,@s_premium)
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

        public static bool Delete(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            return DeleteProc(x_oDB, x_iMid);
        }


        private static bool DeleteProc(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            if (x_iMid == null) { return false; }
            string _sQuery = "DELETE FROM  [SpecialPremium]  WHERE [SpecialPremium].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[SpecialPremium]", "[" + Configurator.MSSQLTablePrefix + "SpecialPremium]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult = false;
                _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value = x_iMid;
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
            return SpecialPremiumRepositoryBase.DeleteAll(n_oDB);
        }

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "DELETE FROM  [SpecialPremium]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[SpecialPremium]", "[" + Configurator.MSSQLTablePrefix + "SpecialPremium]"); }
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
            string _sQuery = "DELETE FROM [SpecialPremium]" + x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[SpecialPremium]", "[" + Configurator.MSSQLTablePrefix + "SpecialPremium]"); }
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

