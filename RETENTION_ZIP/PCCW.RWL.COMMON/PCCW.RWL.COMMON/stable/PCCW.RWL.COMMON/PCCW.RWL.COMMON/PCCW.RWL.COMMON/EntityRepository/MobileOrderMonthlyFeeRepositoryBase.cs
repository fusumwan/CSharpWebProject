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
///-- Description:	<Description,Table :[MobileOrderMonthlyFee],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [MobileOrderMonthlyFee] Insert / list / delete manager layer
    /// </summary>

    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name = Configurator.MSSQLTablePrefix + "MobileOrderMonthlyFee")]
    public class MobileOrderMonthlyFeeRepositoryBase : global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable
    {

        #region Instance
        private static MobileOrderMonthlyFeeRepositoryBase instance;
        public static MobileOrderMonthlyFeeRepositoryBase Instance()
        {
            if (instance == null)
            {
                MSSQLConnect _oDB = new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new MobileOrderMonthlyFeeRepositoryBase(_oDB);
            }
            return instance;
        }
        public static MobileOrderMonthlyFeeRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if (instance == null)
                instance = new MobileOrderMonthlyFeeRepositoryBase(x_oDB);
            return instance;
        }
        #endregion

        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<MobileOrderMonthlyFeeEntity> MobileOrderMonthlyFees;
        #endregion

        #region Constructor
        public MobileOrderMonthlyFeeRepositoryBase(MSSQLConnect x_oDB)
            : base(x_oDB.ConnectionStr)
        {
            n_oDB = x_oDB;
        }
        ~MobileOrderMonthlyFeeRepositoryBase()
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
        public static MobileOrderMonthlyFee CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new MobileOrderMonthlyFee(_oDB);
        }

        public static MobileOrderMonthlyFee CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new MobileOrderMonthlyFee(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [MobileOrderMonthlyFee]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMonthlyFee]", "[" + Configurator.MSSQLTablePrefix + "MobileOrderMonthlyFee]"); }
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


        public MobileOrderMonthlyFeeEntity GetObj(global::System.Nullable<int> x_iMid)
        {
            return GetObj(n_oDB, x_iMid);
        }


        public static MobileOrderMonthlyFeeEntity GetObj(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            if (x_oDB == null) { return null; }
            MobileOrderMonthlyFee _MobileOrderMonthlyFee = (MobileOrderMonthlyFee)MobileOrderMonthlyFeeRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_MobileOrderMonthlyFee.Load(x_iMid)) { return null; }
            return _MobileOrderMonthlyFee;
        }



        public static MobileOrderMonthlyFeeEntity[] GetArrayObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            List<MobileOrderMonthlyFeeEntity> _oMobileOrderMonthlyFeeList = GetListObj(x_oDB, 0, "mid", x_oArrayItemId);
            return _oMobileOrderMonthlyFeeList.Count == 0 ? null : _oMobileOrderMonthlyFeeList.ToArray();
        }

        public static List<MobileOrderMonthlyFeeEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB, 0, "mid", x_oArrayItemId);
        }


        public static MobileOrderMonthlyFeeEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderMonthlyFeeEntity> _oMobileOrderMonthlyFeeList = GetListObj(x_oDB, 0, x_oColumnName, x_oArrayItemId);
            return _oMobileOrderMonthlyFeeList.Count == 0 ? null : _oMobileOrderMonthlyFeeList.ToArray();
        }


        public static MobileOrderMonthlyFeeEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderMonthlyFeeEntity> _oMobileOrderMonthlyFeeList = GetListObj(x_oDB, x_iTop, x_oColumnName, x_oArrayItemId);
            return _oMobileOrderMonthlyFeeList.Count == 0 ? null : _oMobileOrderMonthlyFeeList.ToArray();
        }

        public static List<MobileOrderMonthlyFeeEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB == null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            List<MobileOrderMonthlyFeeEntity> _oRow = new List<MobileOrderMonthlyFeeEntity>();
            string _sQuery = "SELECT  " + _sTop + " [MobileOrderMonthlyFee].[active] AS MOBILEORDERMONTHLYFEE_ACTIVE,[MobileOrderMonthlyFee].[mon] AS MOBILEORDERMONTHLYFEE_MON,[MobileOrderMonthlyFee].[fee] AS MOBILEORDERMONTHLYFEE_FEE,[MobileOrderMonthlyFee].[mid] AS MOBILEORDERMONTHLYFEE_MID,[MobileOrderMonthlyFee].[free_mon] AS MOBILEORDERMONTHLYFEE_FREE_MON  FROM  [MobileOrderMonthlyFee]";
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
                _sQuery += " WHERE [MobileOrderMonthlyFee].[" + x_oColumnName.ToString() + "]  in " + _oList;
            }

            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMonthlyFee]", "[" + Configurator.MSSQLTablePrefix + "MobileOrderMonthlyFee]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        MobileOrderMonthlyFee _oMobileOrderMonthlyFee = MobileOrderMonthlyFeeRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMONTHLYFEE_MID"])) { _oMobileOrderMonthlyFee.mid = (global::System.Nullable<int>)_oData["MOBILEORDERMONTHLYFEE_MID"]; } else { _oMobileOrderMonthlyFee.mid = null; }
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMONTHLYFEE_MON"])) { _oMobileOrderMonthlyFee.mon = (global::System.Nullable<int>)_oData["MOBILEORDERMONTHLYFEE_MON"]; } else { _oMobileOrderMonthlyFee.mon = null; }
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMONTHLYFEE_FEE"])) { _oMobileOrderMonthlyFee.fee = (global::System.Nullable<int>)_oData["MOBILEORDERMONTHLYFEE_FEE"]; } else { _oMobileOrderMonthlyFee.fee = null; }
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMONTHLYFEE_ACTIVE"])) { _oMobileOrderMonthlyFee.active = (global::System.Nullable<bool>)_oData["MOBILEORDERMONTHLYFEE_ACTIVE"]; } else { _oMobileOrderMonthlyFee.active = null; }
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMONTHLYFEE_FREE_MON"])) { _oMobileOrderMonthlyFee.free_mon = (string)_oData["MOBILEORDERMONTHLYFEE_FREE_MON"]; } else { _oMobileOrderMonthlyFee.free_mon = global::System.String.Empty; }
                        _oMobileOrderMonthlyFee.SetDB(x_oDB);
                        _oMobileOrderMonthlyFee.GetFound();
                        _oRow.Add(_oMobileOrderMonthlyFee);
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


        public static MobileOrderMonthlyFeeEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderMonthlyFeeEntity> _oMobileOrderMonthlyFeeList = GetListObj(x_oDB, 0, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oMobileOrderMonthlyFeeList.Count == 0 ? null : _oMobileOrderMonthlyFeeList.ToArray();
        }


        public static MobileOrderMonthlyFeeEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderMonthlyFeeEntity> _oMobileOrderMonthlyFeeList = GetListObj(x_oDB, x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oMobileOrderMonthlyFeeList.Count == 0 ? null : _oMobileOrderMonthlyFeeList.ToArray();
        }

        public static List<MobileOrderMonthlyFeeEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB == null) { return null; }
            List<MobileOrderMonthlyFeeEntity> _oRow = new List<MobileOrderMonthlyFeeEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            string _sFields = "[MobileOrderMonthlyFee].[active] AS MOBILEORDERMONTHLYFEE_ACTIVE,[MobileOrderMonthlyFee].[mon] AS MOBILEORDERMONTHLYFEE_MON,[MobileOrderMonthlyFee].[fee] AS MOBILEORDERMONTHLYFEE_FEE,[MobileOrderMonthlyFee].[mid] AS MOBILEORDERMONTHLYFEE_MID,[MobileOrderMonthlyFee].[free_mon] AS MOBILEORDERMONTHLYFEE_FREE_MON";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[MobileOrderMonthlyFee]", "[" + Configurator.MSSQLTablePrefix + "MobileOrderMonthlyFee]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = MobileOrderMonthlyFeeRepositoryBase.GetSearch(x_oDB, _sTop.ToString() + _sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                MobileOrderMonthlyFeeEntity _oMobileOrderMonthlyFee = MobileOrderMonthlyFeeRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMONTHLYFEE_MID"])) { _oMobileOrderMonthlyFee.mid = (global::System.Nullable<int>)_oData["MOBILEORDERMONTHLYFEE_MID"]; } else { _oMobileOrderMonthlyFee.mid = null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMONTHLYFEE_MON"])) { _oMobileOrderMonthlyFee.mon = (global::System.Nullable<int>)_oData["MOBILEORDERMONTHLYFEE_MON"]; } else { _oMobileOrderMonthlyFee.mon = null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMONTHLYFEE_FEE"])) { _oMobileOrderMonthlyFee.fee = (global::System.Nullable<int>)_oData["MOBILEORDERMONTHLYFEE_FEE"]; } else { _oMobileOrderMonthlyFee.fee = null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMONTHLYFEE_ACTIVE"])) { _oMobileOrderMonthlyFee.active = (global::System.Nullable<bool>)_oData["MOBILEORDERMONTHLYFEE_ACTIVE"]; } else { _oMobileOrderMonthlyFee.active = null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMONTHLYFEE_FREE_MON"])) { _oMobileOrderMonthlyFee.free_mon = (string)_oData["MOBILEORDERMONTHLYFEE_FREE_MON"]; } else { _oMobileOrderMonthlyFee.free_mon = global::System.String.Empty; }
                _oMobileOrderMonthlyFee.SetDB(x_oDB);
                _oMobileOrderMonthlyFee.GetFound();
                _oRow.Add(_oMobileOrderMonthlyFee);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet(MobileOrderMonthlyFee.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder, MobileOrderMonthlyFee.Para.TableName());
            return _oDset;
        }


        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB == null) { return null; }
            return x_oDB.GetSearch(MobileOrderMonthlyFee.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }


        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(MobileOrderMonthlyFee.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            if (x_oDB == null) { return null; }
            string _oQuery = "SELECT   [MobileOrderMonthlyFee].[active] AS MOBILEORDERMONTHLYFEE_ACTIVE,[MobileOrderMonthlyFee].[mon] AS MOBILEORDERMONTHLYFEE_MON,[MobileOrderMonthlyFee].[fee] AS MOBILEORDERMONTHLYFEE_FEE,[MobileOrderMonthlyFee].[mid] AS MOBILEORDERMONTHLYFEE_MID,[MobileOrderMonthlyFee].[free_mon] AS MOBILEORDERMONTHLYFEE_FREE_MON  FROM  [MobileOrderMonthlyFee]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[MobileOrderMonthlyFee]", "[" + Configurator.MSSQLTablePrefix + "MobileOrderMonthlyFee]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery, _oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset, "MobileOrderMonthlyFee");
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

        public bool Insert(global::System.Nullable<int> x_iMon, global::System.Nullable<int> x_iFee, global::System.Nullable<bool> x_bActive, string x_sFree_mon)
        {
            MobileOrderMonthlyFee _oMobileOrderMonthlyFee = MobileOrderMonthlyFeeRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oMobileOrderMonthlyFee.mon = x_iMon;
            _oMobileOrderMonthlyFee.fee = x_iFee;
            _oMobileOrderMonthlyFee.active = x_bActive;
            _oMobileOrderMonthlyFee.free_mon = x_sFree_mon;
            return InsertWithOutLastID(n_oDB, _oMobileOrderMonthlyFee);
        }


        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMon, global::System.Nullable<int> x_iFee, global::System.Nullable<bool> x_bActive, string x_sFree_mon)
        {
            MobileOrderMonthlyFee _oMobileOrderMonthlyFee = MobileOrderMonthlyFeeRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderMonthlyFee.mon = x_iMon;
            _oMobileOrderMonthlyFee.fee = x_iFee;
            _oMobileOrderMonthlyFee.active = x_bActive;
            _oMobileOrderMonthlyFee.free_mon = x_sFree_mon;
            return InsertWithOutLastID(x_oDB, _oMobileOrderMonthlyFee);
        }


        public bool Insert(MobileOrderMonthlyFee x_oMobileOrderMonthlyFee)
        {
            return InsertWithOutLastID(n_oDB, x_oMobileOrderMonthlyFee);
        }


        public bool InsertEntity(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is MobileOrderMonthlyFee)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (MobileOrderMonthlyFee)x_oObj);
        }


        public static bool Insert(MSSQLConnect x_oDB, MobileOrderMonthlyFee x_oMobileOrderMonthlyFee)
        {
            return InsertWithOutLastID(x_oDB, x_oMobileOrderMonthlyFee);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, MobileOrderMonthlyFee x_oMobileOrderMonthlyFee)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderMonthlyFee]   ([active],[mon],[fee],[free_mon])  VALUES  (@active,@mon,@fee,@free_mon)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMonthlyFee]", "[" + Configurator.MSSQLTablePrefix + "MobileOrderMonthlyFee]"); }
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
            return InsertTransactionWithOutLastID(x_oDB, _oConn, _oCmd, x_oMobileOrderMonthlyFee);
        }

        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, MobileOrderMonthlyFee x_oMobileOrderMonthlyFee)
        {
            bool _bResult = false;
            if (!x_oMobileOrderMonthlyFee.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if (x_oMobileOrderMonthlyFee.active == null) { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = x_oMobileOrderMonthlyFee.active; }
                if (x_oMobileOrderMonthlyFee.mon == null) { x_oCmd.Parameters.Add("@mon", global::System.Data.SqlDbType.Int).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@mon", global::System.Data.SqlDbType.Int).Value = x_oMobileOrderMonthlyFee.mon; }
                if (x_oMobileOrderMonthlyFee.fee == null) { x_oCmd.Parameters.Add("@fee", global::System.Data.SqlDbType.Int).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@fee", global::System.Data.SqlDbType.Int).Value = x_oMobileOrderMonthlyFee.fee; }
                if (x_oMobileOrderMonthlyFee.free_mon == null) { x_oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.Char, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.Char, 10).Value = x_oMobileOrderMonthlyFee.free_mon; }
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


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMon, global::System.Nullable<int> x_iFee, global::System.Nullable<bool> x_bActive, string x_sFree_mon)
        {
            int _oLastID;
            MobileOrderMonthlyFee _oMobileOrderMonthlyFee = MobileOrderMonthlyFeeRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderMonthlyFee.mon = x_iMon;
            _oMobileOrderMonthlyFee.fee = x_iFee;
            _oMobileOrderMonthlyFee.active = x_bActive;
            _oMobileOrderMonthlyFee.free_mon = x_sFree_mon;
            if (InsertWithLastID_SP(x_oDB, _oMobileOrderMonthlyFee, out _oLastID))
            {
                return _oLastID;
            }
            else
            {
                return -1;
            }
        }


        public int InsertReturnLastID_SP(MobileOrderMonthlyFee x_oMobileOrderMonthlyFee)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oMobileOrderMonthlyFee, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderMonthlyFee x_oMobileOrderMonthlyFee)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oMobileOrderMonthlyFee, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderMonthlyFee)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (MobileOrderMonthlyFee)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB, MobileOrderMonthlyFee x_oMobileOrderMonthlyFee, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "MOBILEORDERMONTHLYFEE";
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
            return InsertTransactionWithLastID_SP(x_oDB, _oConn, _oCmd, x_oMobileOrderMonthlyFee, out x_oLAST_ID);
        }

        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, MobileOrderMonthlyFee x_oMobileOrderMonthlyFee, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar = x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oMobileOrderMonthlyFee.active == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oMobileOrderMonthlyFee.active; }
                _oPar = x_oCmd.Parameters.Add("@mon", global::System.Data.SqlDbType.Int);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oMobileOrderMonthlyFee.mon == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oMobileOrderMonthlyFee.mon; }
                _oPar = x_oCmd.Parameters.Add("@fee", global::System.Data.SqlDbType.Int);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oMobileOrderMonthlyFee.fee == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oMobileOrderMonthlyFee.fee; }
                _oPar = x_oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.Char, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oMobileOrderMonthlyFee.free_mon == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oMobileOrderMonthlyFee.free_mon; }
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

        #region INSERT_MOBILEORDERMONTHLYFEE Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2009-11-17>
        ///-- Description:	<Description,MOBILEORDERMONTHLYFEE, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_MOBILEORDERMONTHLYFEE Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_MOBILEORDERMONTHLYFEE', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_MOBILEORDERMONTHLYFEE;
        GO
        CREATE PROCEDURE INSERT_MOBILEORDERMONTHLYFEE
        	-- Add the parameters for the stored procedure here
        @RETURN_MID int output,
        @mon int,
        @fee int,
        @active bit,
        @free_mon char(10)
        AS
        
        INSERT INTO  [MobileOrderMonthlyFee]   ([active],[mon],[fee],[free_mon])  VALUES  (@active,@mon,@fee,@free_mon)
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
            string _sQuery = "DELETE FROM  [MobileOrderMonthlyFee]  WHERE [MobileOrderMonthlyFee].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMonthlyFee]", "[" + Configurator.MSSQLTablePrefix + "MobileOrderMonthlyFee]"); }
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
            return MobileOrderMonthlyFeeRepositoryBase.DeleteAll(n_oDB);
        }

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "DELETE FROM  [MobileOrderMonthlyFee]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMonthlyFee]", "[" + Configurator.MSSQLTablePrefix + "MobileOrderMonthlyFee]"); }
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
            string _sQuery = "DELETE FROM [MobileOrderMonthlyFee]" + x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMonthlyFee]", "[" + Configurator.MSSQLTablePrefix + "MobileOrderMonthlyFee]"); }
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

