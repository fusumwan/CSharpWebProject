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
///-- Create date: <Create Date 2009-02-03>
///-- Description:	<Description,Table :[AutoSelectionProperty],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [AutoSelectionProperty] Insert / list / delete manager layer
    /// </summary>

    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name = Configurator.MSSQLTablePrefix + "AutoSelectionProperty")]
    public class AutoSelectionPropertyRepositoryBase : global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable
    {
        #region Instance
        private static AutoSelectionPropertyRepositoryBase instance;
        public static AutoSelectionPropertyRepositoryBase Instance()
        {
            if (instance == null)
            {
                MSSQLConnect _oDB = new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new AutoSelectionPropertyRepositoryBase(_oDB);
            }
            return instance;
        }
        public static AutoSelectionPropertyRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if (instance == null)
                instance = new AutoSelectionPropertyRepositoryBase(x_oDB);
            return instance;
        }
        #endregion

        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<AutoSelectionPropertyEntity> AutoSelectionPropertys;
        #endregion

        #region Constructor
        public AutoSelectionPropertyRepositoryBase(MSSQLConnect x_oDB)
            : base(x_oDB.ConnectionStr)
        {
            n_oDB = x_oDB;
        }
        ~AutoSelectionPropertyRepositoryBase()
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
        public static AutoSelectionProperty CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new AutoSelectionProperty(_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [AutoSelectionProperty]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[AutoSelectionProperty]", "[" + Configurator.MSSQLTablePrefix + "AutoSelectionProperty]"); }
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
                catch { }
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

        #region Get

        /// <summary>
        /// Summary description for management get record from table
        /// </summary>


        public AutoSelectionPropertyEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }


        public static AutoSelectionPropertyEntity GetObj(MSSQLConnect x_oDB, System.Nullable<int> x_iId)
        {
            if (x_oDB == null) { return null; }
            AutoSelectionProperty _AutoSelectionProperty = new AutoSelectionProperty(x_oDB);
            if (!_AutoSelectionProperty.Load(x_iId)) { return null; }
            return _AutoSelectionProperty;
        }



        public static AutoSelectionPropertyEntity[] GetArrayObjByID(
            MSSQLConnect x_oDB, global::System.Collections.Generic.List<string> x_oArrayItemId)
        {
            return GetArrayObj(x_oDB, "id", x_oArrayItemId);
        }


        public static AutoSelectionPropertyEntity[] GetArrayObj(
            MSSQLConnect x_oDB, string x_oColumnName, global::System.Collections.Generic.List<string> x_oArrayItemId)
        {
            if (x_oDB == null) { return null; }
            global::System.Collections.Generic.List<AutoSelectionProperty> _oRow = new global::System.Collections.Generic.List<AutoSelectionProperty>();
            string _sQuery = "SELECT [AutoSelectionProperty].[remarks] AS AUTOSELECTIONPROPERTY_REMARKS,[AutoSelectionProperty].[id] AS AUTOSELECTIONPROPERTY_ID,[AutoSelectionProperty].[period] AS AUTOSELECTIONPROPERTY_PERIOD,[AutoSelectionProperty].[start_date] AS AUTOSELECTIONPROPERTY_START_DATE,[AutoSelectionProperty].[obprogram] AS AUTOSELECTIONPROPERTY_OBPROGRAM,[AutoSelectionProperty].[channel] AS AUTOSELECTIONPROPERTY_CHANNEL,[AutoSelectionProperty].[tier] AS AUTOSELECTIONPROPERTY_TIER,[AutoSelectionProperty].[tradefield_mid] AS AUTOSELECTIONPROPERTY_TRADEFIELD_MID,[AutoSelectionProperty].[uid] AS AUTOSELECTIONPROPERTY_UID,[AutoSelectionProperty].[plan_fee] AS AUTOSELECTIONPROPERTY_PLAN_FEE,[AutoSelectionProperty].[end_date] AS AUTOSELECTIONPROPERTY_END_DATE,[AutoSelectionProperty].[po_date] AS AUTOSELECTIONPROPERTY_PO_DATE  FROM  [AutoSelectionProperty]";
            if (x_oArrayItemId != null)
            {
                string _oList = "(";
                for (int i = 0; i < x_oArrayItemId.Count; i++)
                {
                    if (i < (x_oArrayItemId.Count - 1))
                        _oList += "'" + x_oArrayItemId[i].ToString() + "',";
                    else
                        _oList += "'" + x_oArrayItemId[i].ToString() + "'";
                }
                _oList += ")";
                _sQuery += " WHERE [AutoSelectionProperty].[" + x_oColumnName.ToString() + "]  in " + _oList;
            }

            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[AutoSelectionProperty]", "[" + Configurator.MSSQLTablePrefix + "AutoSelectionProperty]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        AutoSelectionProperty _oAutoSelectionProperty = (AutoSelectionProperty)AutoSelectionPropertyRepository.CreateEntityInstanceObject();
                        if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_ID"])) { _oAutoSelectionProperty.id = (global::System.Nullable<int>)_oData["AUTOSELECTIONPROPERTY_ID"]; } else { _oAutoSelectionProperty.id = null; }
                        if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_PERIOD"])) { _oAutoSelectionProperty.period = (string)_oData["AUTOSELECTIONPROPERTY_PERIOD"]; } else { _oAutoSelectionProperty.period = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_START_DATE"])) { _oAutoSelectionProperty.start_date = (global::System.Nullable<DateTime>)_oData["AUTOSELECTIONPROPERTY_START_DATE"]; } else { _oAutoSelectionProperty.start_date = null; }
                        if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_OBPROGRAM"])) { _oAutoSelectionProperty.obprogram = (string)_oData["AUTOSELECTIONPROPERTY_OBPROGRAM"]; } else { _oAutoSelectionProperty.obprogram = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_CHANNEL"])) { _oAutoSelectionProperty.channel = (string)_oData["AUTOSELECTIONPROPERTY_CHANNEL"]; } else { _oAutoSelectionProperty.channel = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_TIER"])) { _oAutoSelectionProperty.tier = (string)_oData["AUTOSELECTIONPROPERTY_TIER"]; } else { _oAutoSelectionProperty.tier = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_TRADEFIELD_MID"])) { _oAutoSelectionProperty.tradefield_mid = (global::System.Nullable<int>)_oData["AUTOSELECTIONPROPERTY_TRADEFIELD_MID"]; } else { _oAutoSelectionProperty.tradefield_mid = null; }
                        if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_UID"])) { _oAutoSelectionProperty.uid = (string)_oData["AUTOSELECTIONPROPERTY_UID"]; } else { _oAutoSelectionProperty.uid = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_END_DATE"])) { _oAutoSelectionProperty.end_date = (global::System.Nullable<DateTime>)_oData["AUTOSELECTIONPROPERTY_END_DATE"]; } else { _oAutoSelectionProperty.end_date = null; }
                        if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_PLAN_FEE"])) { _oAutoSelectionProperty.plan_fee = (string)_oData["AUTOSELECTIONPROPERTY_PLAN_FEE"]; } else { _oAutoSelectionProperty.plan_fee = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_REMARKS"])) { _oAutoSelectionProperty.remarks = (string)_oData["AUTOSELECTIONPROPERTY_REMARKS"]; } else { _oAutoSelectionProperty.remarks = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_PO_DATE"])) { _oAutoSelectionProperty.po_date = (global::System.Nullable<DateTime>)_oData["AUTOSELECTIONPROPERTY_PO_DATE"]; } else { _oAutoSelectionProperty.po_date = null; }
                        _oAutoSelectionProperty.SetDB(x_oDB);
                        _oAutoSelectionProperty.GetFound();
                        _oRow.Add(_oAutoSelectionProperty);
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
                return _oRow.Count == 0 ? null : _oRow.ToArray();
            }
        }

        public static AutoSelectionPropertyEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB == null) { return null; }
            global::System.Collections.Generic.List<AutoSelectionProperty> _oRow = new global::System.Collections.Generic.List<AutoSelectionProperty>();
            string _sFields = "[AutoSelectionProperty].[remarks] AS AUTOSELECTIONPROPERTY_REMARKS,[AutoSelectionProperty].[id] AS AUTOSELECTIONPROPERTY_ID,[AutoSelectionProperty].[period] AS AUTOSELECTIONPROPERTY_PERIOD,[AutoSelectionProperty].[start_date] AS AUTOSELECTIONPROPERTY_START_DATE,[AutoSelectionProperty].[obprogram] AS AUTOSELECTIONPROPERTY_OBPROGRAM,[AutoSelectionProperty].[channel] AS AUTOSELECTIONPROPERTY_CHANNEL,[AutoSelectionProperty].[tier] AS AUTOSELECTIONPROPERTY_TIER,[AutoSelectionProperty].[tradefield_mid] AS AUTOSELECTIONPROPERTY_TRADEFIELD_MID,[AutoSelectionProperty].[uid] AS AUTOSELECTIONPROPERTY_UID,[AutoSelectionProperty].[plan_fee] AS AUTOSELECTIONPROPERTY_PLAN_FEE,[AutoSelectionProperty].[end_date] AS AUTOSELECTIONPROPERTY_END_DATE,[AutoSelectionProperty].[po_date] AS AUTOSELECTIONPROPERTY_PO_DATE";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[AutoSelectionProperty]", "[" + Configurator.MSSQLTablePrefix + "AutoSelectionProperty]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = AutoSelectionPropertyRepositoryBase.GetSearch(x_oDB, _sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                AutoSelectionProperty _oAutoSelectionProperty = (AutoSelectionProperty)AutoSelectionPropertyRepository.CreateEntityInstanceObject();
                if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_ID"])) { _oAutoSelectionProperty.id = (global::System.Nullable<int>)_oData["AUTOSELECTIONPROPERTY_ID"]; } else { _oAutoSelectionProperty.id = null; }
                if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_PERIOD"])) { _oAutoSelectionProperty.period = (string)_oData["AUTOSELECTIONPROPERTY_PERIOD"]; } else { _oAutoSelectionProperty.period = string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_START_DATE"])) { _oAutoSelectionProperty.start_date = (global::System.Nullable<DateTime>)_oData["AUTOSELECTIONPROPERTY_START_DATE"]; } else { _oAutoSelectionProperty.start_date = null; }
                if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_OBPROGRAM"])) { _oAutoSelectionProperty.obprogram = (string)_oData["AUTOSELECTIONPROPERTY_OBPROGRAM"]; } else { _oAutoSelectionProperty.obprogram = string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_CHANNEL"])) { _oAutoSelectionProperty.channel = (string)_oData["AUTOSELECTIONPROPERTY_CHANNEL"]; } else { _oAutoSelectionProperty.channel = string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_TIER"])) { _oAutoSelectionProperty.tier = (string)_oData["AUTOSELECTIONPROPERTY_TIER"]; } else { _oAutoSelectionProperty.tier = string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_TRADEFIELD_MID"])) { _oAutoSelectionProperty.tradefield_mid = (global::System.Nullable<int>)_oData["AUTOSELECTIONPROPERTY_TRADEFIELD_MID"]; } else { _oAutoSelectionProperty.tradefield_mid = null; }
                if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_UID"])) { _oAutoSelectionProperty.uid = (string)_oData["AUTOSELECTIONPROPERTY_UID"]; } else { _oAutoSelectionProperty.uid = string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_END_DATE"])) { _oAutoSelectionProperty.end_date = (global::System.Nullable<DateTime>)_oData["AUTOSELECTIONPROPERTY_END_DATE"]; } else { _oAutoSelectionProperty.end_date = null; }
                if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_PLAN_FEE"])) { _oAutoSelectionProperty.plan_fee = (string)_oData["AUTOSELECTIONPROPERTY_PLAN_FEE"]; } else { _oAutoSelectionProperty.plan_fee = string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_REMARKS"])) { _oAutoSelectionProperty.remarks = (string)_oData["AUTOSELECTIONPROPERTY_REMARKS"]; } else { _oAutoSelectionProperty.remarks = string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_PO_DATE"])) { _oAutoSelectionProperty.po_date = (global::System.Nullable<DateTime>)_oData["AUTOSELECTIONPROPERTY_PO_DATE"]; } else { _oAutoSelectionProperty.po_date = null; }
                _oAutoSelectionProperty.SetDB(x_oDB);
                _oAutoSelectionProperty.GetFound();
                _oRow.Add(_oAutoSelectionProperty);
            }
            _oData.Close();
            _oData.Dispose();
            return _oRow.Count == 0 ? null : _oRow.ToArray();
        }
        #endregion

        #region List
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet(AutoSelectionProperty.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder, AutoSelectionProperty.Para.TableName());
            return _oDset;
        }


        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB == null) { return null; }
            return x_oDB.GetSearch(AutoSelectionProperty.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }


        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(AutoSelectionProperty.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            if (x_oDB == null) { return null; }
            string _oQuery = "SELECT [AutoSelectionProperty].[remarks] AS AUTOSELECTIONPROPERTY_REMARKS,[AutoSelectionProperty].[id] AS AUTOSELECTIONPROPERTY_ID,[AutoSelectionProperty].[period] AS AUTOSELECTIONPROPERTY_PERIOD,[AutoSelectionProperty].[start_date] AS AUTOSELECTIONPROPERTY_START_DATE,[AutoSelectionProperty].[obprogram] AS AUTOSELECTIONPROPERTY_OBPROGRAM,[AutoSelectionProperty].[channel] AS AUTOSELECTIONPROPERTY_CHANNEL,[AutoSelectionProperty].[tier] AS AUTOSELECTIONPROPERTY_TIER,[AutoSelectionProperty].[tradefield_mid] AS AUTOSELECTIONPROPERTY_TRADEFIELD_MID,[AutoSelectionProperty].[uid] AS AUTOSELECTIONPROPERTY_UID,[AutoSelectionProperty].[plan_fee] AS AUTOSELECTIONPROPERTY_PLAN_FEE,[AutoSelectionProperty].[end_date] AS AUTOSELECTIONPROPERTY_END_DATE,[AutoSelectionProperty].[po_date] AS AUTOSELECTIONPROPERTY_PO_DATE  FROM  [AutoSelectionProperty]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[AutoSelectionProperty]", "[" + Configurator.MSSQLTablePrefix + "AutoSelectionProperty]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery, _oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset, "AutoSelectionProperty");
                }
                catch { }
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

        public bool Insert(string x_sPeriod, System.Nullable<DateTime> x_dStart_date, string x_sObprogram, string x_sChannel, string x_sTier, System.Nullable<int> x_iTradefield_mid, string x_sUid, System.Nullable<DateTime> x_dEnd_date, string x_sPlan_fee, string x_sRemarks, System.Nullable<DateTime> x_dPo_date)
        {
            AutoSelectionProperty _oAutoSelectionProperty = (AutoSelectionProperty)AutoSelectionPropertyRepository.CreateEntityInstanceObject();
            _oAutoSelectionProperty.period = x_sPeriod;
            _oAutoSelectionProperty.start_date = x_dStart_date;
            _oAutoSelectionProperty.obprogram = x_sObprogram;
            _oAutoSelectionProperty.channel = x_sChannel;
            _oAutoSelectionProperty.tier = x_sTier;
            _oAutoSelectionProperty.tradefield_mid = x_iTradefield_mid;
            _oAutoSelectionProperty.uid = x_sUid;
            _oAutoSelectionProperty.end_date = x_dEnd_date;
            _oAutoSelectionProperty.plan_fee = x_sPlan_fee;
            _oAutoSelectionProperty.remarks = x_sRemarks;
            _oAutoSelectionProperty.po_date = x_dPo_date;
            return InsertWithOutLastID(n_oDB, _oAutoSelectionProperty);
        }


        public static bool Insert(MSSQLConnect x_oDB, string x_sPeriod, System.Nullable<DateTime> x_dStart_date, string x_sObprogram, string x_sChannel, string x_sTier, System.Nullable<int> x_iTradefield_mid, string x_sUid, System.Nullable<DateTime> x_dEnd_date, string x_sPlan_fee, string x_sRemarks, System.Nullable<DateTime> x_dPo_date)
        {
            AutoSelectionProperty _oAutoSelectionProperty = (AutoSelectionProperty)AutoSelectionPropertyRepository.CreateEntityInstanceObject();
            _oAutoSelectionProperty.period = x_sPeriod;
            _oAutoSelectionProperty.start_date = x_dStart_date;
            _oAutoSelectionProperty.obprogram = x_sObprogram;
            _oAutoSelectionProperty.channel = x_sChannel;
            _oAutoSelectionProperty.tier = x_sTier;
            _oAutoSelectionProperty.tradefield_mid = x_iTradefield_mid;
            _oAutoSelectionProperty.uid = x_sUid;
            _oAutoSelectionProperty.end_date = x_dEnd_date;
            _oAutoSelectionProperty.plan_fee = x_sPlan_fee;
            _oAutoSelectionProperty.remarks = x_sRemarks;
            _oAutoSelectionProperty.po_date = x_dPo_date;
            return InsertWithOutLastID(x_oDB, _oAutoSelectionProperty);
        }


        public bool Insert(AutoSelectionProperty x_oAutoSelectionProperty)
        {
            return InsertWithOutLastID(n_oDB, x_oAutoSelectionProperty);
        }


        public bool InsertEntity(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is AutoSelectionProperty)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (AutoSelectionProperty)x_oObj);
        }


        public static bool Insert(MSSQLConnect x_oDB, AutoSelectionProperty x_oAutoSelectionProperty)
        {
            return InsertWithOutLastID(x_oDB, x_oAutoSelectionProperty);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, AutoSelectionProperty x_oAutoSelectionProperty)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT INTO  [AutoSelectionProperty]   ([remarks],[period],[start_date],[obprogram],[channel],[tier],[tradefield_mid],[uid],[plan_fee],[end_date],[po_date])  VALUES  (@remarks,@period,@start_date,@obprogram,@channel,@tier,@tradefield_mid,@uid,@plan_fee,@end_date,@po_date)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[AutoSelectionProperty]", "[" + Configurator.MSSQLTablePrefix + "AutoSelectionProperty]"); }
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
            return InsertTransactionWithOutLastID(x_oDB, _oConn, _oCmd, x_oAutoSelectionProperty);
        }

        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, AutoSelectionProperty x_oAutoSelectionProperty)
        {
            bool _bResult = false;
            if (!x_oAutoSelectionProperty.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if (x_oAutoSelectionProperty.remarks == null) { x_oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.Text).Value = global::System.DBNull.Value; } else { x_oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.Text).Value = x_oAutoSelectionProperty.remarks; }
                if (x_oAutoSelectionProperty.period == null) { x_oCmd.Parameters.Add("@period", global::System.Data.SqlDbType.NVarChar, 50).Value = global::System.DBNull.Value; } else { x_oCmd.Parameters.Add("@period", global::System.Data.SqlDbType.NVarChar, 50).Value = x_oAutoSelectionProperty.period; }
                if (x_oAutoSelectionProperty.start_date == null) { x_oCmd.Parameters.Add("@start_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@start_date", global::System.Data.SqlDbType.DateTime).Value = x_oAutoSelectionProperty.start_date; }
                if (x_oAutoSelectionProperty.obprogram == null) { x_oCmd.Parameters.Add("@obprogram", global::System.Data.SqlDbType.NVarChar, 250).Value = global::System.DBNull.Value; } else { x_oCmd.Parameters.Add("@obprogram", global::System.Data.SqlDbType.NVarChar, 250).Value = x_oAutoSelectionProperty.obprogram; }
                if (x_oAutoSelectionProperty.channel == null) { x_oCmd.Parameters.Add("@channel", global::System.Data.SqlDbType.NVarChar, 10).Value = global::System.DBNull.Value; } else { x_oCmd.Parameters.Add("@channel", global::System.Data.SqlDbType.NVarChar, 10).Value = x_oAutoSelectionProperty.channel; }
                if (x_oAutoSelectionProperty.tier == null) { x_oCmd.Parameters.Add("@tier", global::System.Data.SqlDbType.NVarChar, 50).Value = global::System.DBNull.Value; } else { x_oCmd.Parameters.Add("@tier", global::System.Data.SqlDbType.NVarChar, 50).Value = x_oAutoSelectionProperty.tier; }
                if (x_oAutoSelectionProperty.tradefield_mid == null) { x_oCmd.Parameters.Add("@tradefield_mid", global::System.Data.SqlDbType.Int).Value = global::System.DBNull.Value; } else { x_oCmd.Parameters.Add("@tradefield_mid", global::System.Data.SqlDbType.Int).Value = x_oAutoSelectionProperty.tradefield_mid; }
                if (x_oAutoSelectionProperty.uid == null) { x_oCmd.Parameters.Add("@uid", global::System.Data.SqlDbType.NVarChar, 50).Value = global::System.DBNull.Value; } else { x_oCmd.Parameters.Add("@uid", global::System.Data.SqlDbType.NVarChar, 50).Value = x_oAutoSelectionProperty.uid; }
                if (x_oAutoSelectionProperty.plan_fee == null) { x_oCmd.Parameters.Add("@plan_fee", global::System.Data.SqlDbType.NVarChar, 50).Value = global::System.DBNull.Value; } else { x_oCmd.Parameters.Add("@plan_fee", global::System.Data.SqlDbType.NVarChar, 50).Value = x_oAutoSelectionProperty.plan_fee; }
                if (x_oAutoSelectionProperty.end_date == null) { x_oCmd.Parameters.Add("@end_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@end_date", global::System.Data.SqlDbType.DateTime).Value = x_oAutoSelectionProperty.end_date; }
                if (x_oAutoSelectionProperty.po_date == null) { x_oCmd.Parameters.Add("@po_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@po_date", global::System.Data.SqlDbType.DateTime).Value = x_oAutoSelectionProperty.po_date; }
                if (!x_oDB.bTransaction && x_oConn.State == ConnectionState.Closed) x_oConn.Open();
                _bResult = global::System.Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
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


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, string x_sPeriod, System.Nullable<DateTime> x_dStart_date, string x_sObprogram, string x_sChannel, string x_sTier, System.Nullable<int> x_iTradefield_mid, string x_sUid, System.Nullable<DateTime> x_dEnd_date, string x_sPlan_fee, string x_sRemarks, System.Nullable<DateTime> x_dPo_date)
        {
            int _oLastID;
            AutoSelectionProperty _oAutoSelectionProperty = (AutoSelectionProperty)AutoSelectionPropertyRepository.CreateEntityInstanceObject();
            _oAutoSelectionProperty.period = x_sPeriod;
            _oAutoSelectionProperty.start_date = x_dStart_date;
            _oAutoSelectionProperty.obprogram = x_sObprogram;
            _oAutoSelectionProperty.channel = x_sChannel;
            _oAutoSelectionProperty.tier = x_sTier;
            _oAutoSelectionProperty.tradefield_mid = x_iTradefield_mid;
            _oAutoSelectionProperty.uid = x_sUid;
            _oAutoSelectionProperty.end_date = x_dEnd_date;
            _oAutoSelectionProperty.plan_fee = x_sPlan_fee;
            _oAutoSelectionProperty.remarks = x_sRemarks;
            _oAutoSelectionProperty.po_date = x_dPo_date;
            if (InsertWithLastID_SP(x_oDB, _oAutoSelectionProperty, out _oLastID))
            {
                return _oLastID;
            }
            else
            {
                return -1;
            }
        }


        public int InsertReturnLastID_SP(AutoSelectionProperty x_oAutoSelectionProperty)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oAutoSelectionProperty, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, AutoSelectionProperty x_oAutoSelectionProperty)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oAutoSelectionProperty, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is AutoSelectionProperty)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (AutoSelectionProperty)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB, AutoSelectionProperty x_oAutoSelectionProperty, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "AUTOSELECTIONPROPERTY";
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
            return InsertTransactionWithLastID_SP(x_oDB, _oConn, _oCmd, x_oAutoSelectionProperty, out x_oLAST_ID);
        }

        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, AutoSelectionProperty x_oAutoSelectionProperty, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            global::System.Data.SqlClient.SqlParameter _oPar;
            try
            {
                _oPar = x_oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.Text);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (x_oAutoSelectionProperty.remarks == null) { _oPar.Value = global::System.DBNull.Value; } else { _oPar.Value = x_oAutoSelectionProperty.remarks; }
                _oPar = x_oCmd.Parameters.Add("@period", global::System.Data.SqlDbType.NVarChar, 50);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (x_oAutoSelectionProperty.period == null) { _oPar.Value = global::System.DBNull.Value; } else { _oPar.Value = x_oAutoSelectionProperty.period; }
                _oPar = x_oCmd.Parameters.Add("@start_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (x_oAutoSelectionProperty.start_date == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oAutoSelectionProperty.start_date; }
                _oPar = x_oCmd.Parameters.Add("@obprogram", global::System.Data.SqlDbType.NVarChar, 250);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (x_oAutoSelectionProperty.obprogram == null) { _oPar.Value = global::System.DBNull.Value; } else { _oPar.Value = x_oAutoSelectionProperty.obprogram; }
                _oPar = x_oCmd.Parameters.Add("@channel", global::System.Data.SqlDbType.NVarChar, 10);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (x_oAutoSelectionProperty.channel == null) { _oPar.Value = global::System.DBNull.Value; } else { _oPar.Value = x_oAutoSelectionProperty.channel; }
                _oPar = x_oCmd.Parameters.Add("@tier", global::System.Data.SqlDbType.NVarChar, 50);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (x_oAutoSelectionProperty.tier == null) { _oPar.Value = global::System.DBNull.Value; } else { _oPar.Value = x_oAutoSelectionProperty.tier; }
                _oPar = x_oCmd.Parameters.Add("@tradefield_mid", global::System.Data.SqlDbType.Int);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (x_oAutoSelectionProperty.tradefield_mid == null) { _oPar.Value = global::System.DBNull.Value; } else { _oPar.Value = x_oAutoSelectionProperty.tradefield_mid; }
                _oPar = x_oCmd.Parameters.Add("@uid", global::System.Data.SqlDbType.NVarChar, 50);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (x_oAutoSelectionProperty.uid == null) { _oPar.Value = global::System.DBNull.Value; } else { _oPar.Value = x_oAutoSelectionProperty.uid; }
                _oPar = x_oCmd.Parameters.Add("@plan_fee", global::System.Data.SqlDbType.NVarChar, 50);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (x_oAutoSelectionProperty.plan_fee == null) { _oPar.Value = global::System.DBNull.Value; } else { _oPar.Value = x_oAutoSelectionProperty.plan_fee; }
                _oPar = x_oCmd.Parameters.Add("@end_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (x_oAutoSelectionProperty.end_date == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oAutoSelectionProperty.end_date; }
                _oPar = x_oCmd.Parameters.Add("@po_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (x_oAutoSelectionProperty.po_date == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oAutoSelectionProperty.po_date; }
                _oPar = x_oCmd.Parameters.Add("@RETURN_ID", global::System.Data.SqlDbType.Int);
                _oPar.Direction = global::System.Data.ParameterDirection.Output;
                x_oCmd.CommandType = CommandType.StoredProcedure;
                if (!x_oDB.bTransaction && x_oConn.State == ConnectionState.Closed) x_oConn.Open();
                _bResult = global::System.Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
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

        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            return -1;
        }

        #region INSERT_AUTOSELECTIONPROPERTY Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2009-02-03>
        ///-- Description:	<Description,AUTOSELECTIONPROPERTY, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_AUTOSELECTIONPROPERTY Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_AUTOSELECTIONPROPERTY', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_AUTOSELECTIONPROPERTY;
        GO
        CREATE PROCEDURE INSERT_AUTOSELECTIONPROPERTY
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @period nvarchar(50),
        @start_date datetime,
        @obprogram nvarchar(250),
        @channel nvarchar(10),
        @tier nvarchar(50),
        @tradefield_mid int,
        @uid nvarchar(50),
        @end_date datetime,
        @plan_fee nvarchar(50),
        @remarks text,
        @po_date datetime
        AS
        
        INSERT INTO  [AutoSelectionProperty]   ([remarks],[period],[start_date],[obprogram],[channel],[tier],[tradefield_mid],[uid],[plan_fee],[end_date],[po_date])  VALUES  (@remarks,@period,@start_date,@obprogram,@channel,@tier,@tradefield_mid,@uid,@plan_fee,@end_date,@po_date)
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

        public static bool Delete(MSSQLConnect x_oDB, System.Nullable<int> x_iId)
        {
            return DeleteProc(x_oDB, x_iId);
        }


        private static bool DeleteProc(MSSQLConnect x_oDB, System.Nullable<int> x_iId)
        {
            if (x_iId == null) { return false; }
            string _sQuery = "DELETE FROM  [AutoSelectionProperty]  WHERE [AutoSelectionProperty].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[AutoSelectionProperty]", "[" + Configurator.MSSQLTablePrefix + "AutoSelectionProperty]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult = false;
                _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = x_iId;
                try
                {
                    _oConn.Open();
                    _bResult = global::System.Convert.ToBoolean(_oCmd.ExecuteNonQuery());
                }
                catch { }
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
            return AutoSelectionPropertyRepositoryBase.DeleteAll(n_oDB);
        }

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "DELETE FROM  [AutoSelectionProperty]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[AutoSelectionProperty]", "[" + Configurator.MSSQLTablePrefix + "AutoSelectionProperty]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult = false;
                try
                {
                    _oConn.Open();
                    _bResult = global::System.Convert.ToBoolean(_oCmd.ExecuteNonQuery());
                }
                catch { }
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
            string _sQuery = "DELETE FROM [AutoSelectionProperty]" + x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[AutoSelectionProperty]", "[" + Configurator.MSSQLTablePrefix + "AutoSelectionProperty]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult = false;
                try
                {
                    _oConn.Open();
                    _bResult = global::System.Convert.ToBoolean(_oCmd.ExecuteNonQuery());
                }
                catch { }
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

