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
///-- Create date: <Create Date 2010-10-29>
///-- Description:	<Description,Table :[BankCode],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [BankCode] Insert / list / delete manager layer
    /// </summary>

    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name = Configurator.MSSQLTablePrefix + "BankCode")]
    public class BankCodeRepositoryBase : global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable
    {

        #region Instance
        private static BankCodeRepositoryBase instance;
        public static BankCodeRepositoryBase Instance()
        {
            if (instance == null)
            {
                MSSQLConnect _oDB = new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new BankCodeRepositoryBase(_oDB);
            }
            return instance;
        }
        public static BankCodeRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if (instance == null)
                instance = new BankCodeRepositoryBase(x_oDB);
            return instance;
        }
        #endregion

        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<BankCodeEntity> BankCodes;
        #endregion

        #region Constructor
        public BankCodeRepositoryBase(MSSQLConnect x_oDB)
            : base(x_oDB.ConnectionStr)
        {
            n_oDB = x_oDB;
        }
        ~BankCodeRepositoryBase()
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
        public static BankCode CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new BankCode(_oDB);
        }

        public static BankCode CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new BankCode(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [BankCode]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BankCode]", "[" + Configurator.MSSQLTablePrefix + "BankCode]"); }
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

        #region Get Array & List

        /// <summary>
        /// Summary description for management get record from table
        /// </summary>


        public BankCodeEntity GetObj(global::System.Nullable<int> x_iMid)
        {
            return GetObj(n_oDB, x_iMid);
        }


        public static BankCodeEntity GetObj(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            if (x_oDB == null) { return null; }
            BankCode _BankCode = (BankCode)BankCodeRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_BankCode.Load(x_iMid)) { return null; }
            return _BankCode;
        }



        public static BankCodeEntity[] GetArrayObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            List<BankCodeEntity> _oBankCodeList = GetListObj(x_oDB, 0, "mid", x_oArrayItemId);
            if (_oBankCodeList == null) { return null; }
            return _oBankCodeList.Count == 0 ? null : _oBankCodeList.ToArray();
        }

        public static List<BankCodeEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB, 0, "mid", x_oArrayItemId);
        }


        public static BankCodeEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<BankCodeEntity> _oBankCodeList = GetListObj(x_oDB, 0, x_oColumnName, x_oArrayItemId);
            if (_oBankCodeList == null) { return null; }
            return _oBankCodeList.Count == 0 ? null : _oBankCodeList.ToArray();
        }


        public static BankCodeEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<BankCodeEntity> _oBankCodeList = GetListObj(x_oDB, x_iTop, x_oColumnName, x_oArrayItemId);
            if (_oBankCodeList == null) { return null; }
            return _oBankCodeList.Count == 0 ? null : _oBankCodeList.ToArray();
        }

        public static List<BankCodeEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB == null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            List<BankCodeEntity> _oRow = new List<BankCodeEntity>();
            string _sQuery = "SELECT  " + _sTop + " [BankCode].[active] AS BANKCODE_ACTIVE,[BankCode].[bank_code] AS BANKCODE_BANK_CODE,[BankCode].[bank_name] AS BANKCODE_BANK_NAME,[BankCode].[installment_period] AS BANKCODE_INSTALLMENT_PERIOD,[BankCode].[mid] AS BANKCODE_MID,[BankCode].[min_amount] AS BANKCODE_MIN_AMOUNT  FROM  [BankCode]";
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
                _sQuery += " WHERE [BankCode].[" + x_oColumnName.ToString() + "]  in " + _oList;
            }

            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BankCode]", "[" + Configurator.MSSQLTablePrefix + "BankCode]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        BankCode _oBankCode = BankCodeRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["BANKCODE_BANK_CODE"])) { _oBankCode.bank_code = (string)_oData["BANKCODE_BANK_CODE"]; } else { _oBankCode.bank_code = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["BANKCODE_BANK_NAME"])) { _oBankCode.bank_name = (string)_oData["BANKCODE_BANK_NAME"]; } else { _oBankCode.bank_name = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["BANKCODE_MID"])) { _oBankCode.mid = (global::System.Nullable<int>)_oData["BANKCODE_MID"]; } else { _oBankCode.mid = null; }
                        if (!global::System.Convert.IsDBNull(_oData["BANKCODE_INSTALLMENT_PERIOD"])) { _oBankCode.installment_period = (string)_oData["BANKCODE_INSTALLMENT_PERIOD"]; } else { _oBankCode.installment_period = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["BANKCODE_ACTIVE"])) { _oBankCode.active = (global::System.Nullable<bool>)_oData["BANKCODE_ACTIVE"]; } else { _oBankCode.active = null; }
                        if (!global::System.Convert.IsDBNull(_oData["BANKCODE_MIN_AMOUNT"])) { _oBankCode.min_amount = (string)_oData["BANKCODE_MIN_AMOUNT"]; } else { _oBankCode.min_amount = global::System.String.Empty; }
                        _oBankCode.SetDB(x_oDB);
                        _oBankCode.GetFound();
                        _oRow.Add(_oBankCode);
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


        public static BankCodeEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<BankCodeEntity> _oBankCodeList = GetListObj(x_oDB, 0, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if (_oBankCodeList == null) { return null; }
            return _oBankCodeList.Count == 0 ? null : _oBankCodeList.ToArray();
        }


        public static BankCodeEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<BankCodeEntity> _oBankCodeList = GetListObj(x_oDB, x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if (_oBankCodeList == null) { return null; }
            return _oBankCodeList.Count == 0 ? null : _oBankCodeList.ToArray();
        }

        public static List<BankCodeEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB == null) { return null; }
            List<BankCodeEntity> _oRow = new List<BankCodeEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            string _sFields = "[BankCode].[active] AS BANKCODE_ACTIVE,[BankCode].[bank_code] AS BANKCODE_BANK_CODE,[BankCode].[bank_name] AS BANKCODE_BANK_NAME,[BankCode].[installment_period] AS BANKCODE_INSTALLMENT_PERIOD,[BankCode].[mid] AS BANKCODE_MID,[BankCode].[min_amount] AS BANKCODE_MIN_AMOUNT";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[BankCode]", "[" + Configurator.MSSQLTablePrefix + "BankCode]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = BankCodeRepositoryBase.GetSearch(x_oDB, _sTop.ToString() + _sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                BankCodeEntity _oBankCode = BankCodeRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["BANKCODE_BANK_CODE"])) { _oBankCode.bank_code = (string)_oData["BANKCODE_BANK_CODE"]; } else { _oBankCode.bank_code = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BANKCODE_BANK_NAME"])) { _oBankCode.bank_name = (string)_oData["BANKCODE_BANK_NAME"]; } else { _oBankCode.bank_name = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BANKCODE_MID"])) { _oBankCode.mid = (global::System.Nullable<int>)_oData["BANKCODE_MID"]; } else { _oBankCode.mid = null; }
                if (!global::System.Convert.IsDBNull(_oData["BANKCODE_INSTALLMENT_PERIOD"])) { _oBankCode.installment_period = (string)_oData["BANKCODE_INSTALLMENT_PERIOD"]; } else { _oBankCode.installment_period = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BANKCODE_ACTIVE"])) { _oBankCode.active = (global::System.Nullable<bool>)_oData["BANKCODE_ACTIVE"]; } else { _oBankCode.active = null; }
                if (!global::System.Convert.IsDBNull(_oData["BANKCODE_MIN_AMOUNT"])) { _oBankCode.min_amount = (string)_oData["BANKCODE_MIN_AMOUNT"]; } else { _oBankCode.min_amount = global::System.String.Empty; }
                _oBankCode.SetDB(x_oDB);
                _oBankCode.GetFound();
                _oRow.Add(_oBankCode);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet(BankCode.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder, BankCode.Para.TableName());
            return _oDset;
        }


        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB == null) { return null; }
            return x_oDB.GetSearch(BankCode.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }


        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(BankCode.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            if (x_oDB == null) { return null; }
            string _oQuery = "SELECT   [BankCode].[active] AS BANKCODE_ACTIVE,[BankCode].[bank_code] AS BANKCODE_BANK_CODE,[BankCode].[bank_name] AS BANKCODE_BANK_NAME,[BankCode].[installment_period] AS BANKCODE_INSTALLMENT_PERIOD,[BankCode].[mid] AS BANKCODE_MID,[BankCode].[min_amount] AS BANKCODE_MIN_AMOUNT  FROM  [BankCode]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[BankCode]", "[" + Configurator.MSSQLTablePrefix + "BankCode]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery, _oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset, "BankCode");
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

        public bool Insert(string x_sBank_code, string x_sBank_name, string x_sInstallment_period, global::System.Nullable<bool> x_bActive, string x_sMin_amount)
        {
            BankCode _oBankCode = BankCodeRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oBankCode.bank_code = x_sBank_code;
            _oBankCode.bank_name = x_sBank_name;
            _oBankCode.installment_period = x_sInstallment_period;
            _oBankCode.active = x_bActive;
            _oBankCode.min_amount = x_sMin_amount;
            return InsertWithOutLastID(n_oDB, _oBankCode);
        }


        public static bool Insert(MSSQLConnect x_oDB, string x_sBank_code, string x_sBank_name, string x_sInstallment_period, global::System.Nullable<bool> x_bActive, string x_sMin_amount)
        {
            BankCode _oBankCode = BankCodeRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oBankCode.bank_code = x_sBank_code;
            _oBankCode.bank_name = x_sBank_name;
            _oBankCode.installment_period = x_sInstallment_period;
            _oBankCode.active = x_bActive;
            _oBankCode.min_amount = x_sMin_amount;
            return InsertWithOutLastID(x_oDB, _oBankCode);
        }


        public bool Insert(BankCode x_oBankCode)
        {
            return InsertWithOutLastID(n_oDB, x_oBankCode);
        }


        public bool InsertEntity(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is BankCode)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (BankCode)x_oObj);
        }


        public static bool Insert(MSSQLConnect x_oDB, BankCode x_oBankCode)
        {
            return InsertWithOutLastID(x_oDB, x_oBankCode);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, BankCode x_oBankCode)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT INTO  [BankCode]   ([active],[bank_code],[bank_name],[installment_period],[min_amount])  VALUES  (@active,@bank_code,@bank_name,@installment_period,@min_amount)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BankCode]", "[" + Configurator.MSSQLTablePrefix + "BankCode]"); }
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
            return InsertTransactionWithOutLastID(x_oDB, _oConn, _oCmd, x_oBankCode);
        }

        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, BankCode x_oBankCode)
        {
            bool _bResult = false;
            if (!x_oBankCode.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if (x_oBankCode.active == null) { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = x_oBankCode.active; }
                if (x_oBankCode.bank_code == null) { x_oCmd.Parameters.Add("@bank_code", global::System.Data.SqlDbType.VarChar, 200).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@bank_code", global::System.Data.SqlDbType.VarChar, 200).Value = x_oBankCode.bank_code; }
                if (x_oBankCode.bank_name == null) { x_oCmd.Parameters.Add("@bank_name", global::System.Data.SqlDbType.VarChar, 200).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@bank_name", global::System.Data.SqlDbType.VarChar, 200).Value = x_oBankCode.bank_name; }
                if (x_oBankCode.installment_period == null) { x_oCmd.Parameters.Add("@installment_period", global::System.Data.SqlDbType.NVarChar, 250).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@installment_period", global::System.Data.SqlDbType.NVarChar, 250).Value = x_oBankCode.installment_period; }
                if (x_oBankCode.min_amount == null) { x_oCmd.Parameters.Add("@min_amount", global::System.Data.SqlDbType.NVarChar, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@min_amount", global::System.Data.SqlDbType.NVarChar, 10).Value = x_oBankCode.min_amount; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State == ConnectionState.Closed) x_oConn.Open();
                _bResult = Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
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


        public static int InsertReturnLastID(MSSQLConnect x_oDB, string x_sBank_code, string x_sBank_name, string x_sInstallment_period, global::System.Nullable<bool> x_bActive, string x_sMin_amount)
        {
            int _oLastID;
            BankCode _oBankCode = BankCodeRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oBankCode.bank_code = x_sBank_code;
            _oBankCode.bank_name = x_sBank_name;
            _oBankCode.installment_period = x_sInstallment_period;
            _oBankCode.active = x_bActive;
            _oBankCode.min_amount = x_sMin_amount;
            if (InsertWithLastID(x_oDB, _oBankCode, out _oLastID))
            {
                return _oLastID;
            }
            else
            {
                return -1;
            }
        }


        public int InsertReturnLastID(BankCode x_oBankCode)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oBankCode, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }


        public static int InsertReturnLastID(MSSQLConnect x_oDB, BankCode x_oBankCode)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oBankCode, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is BankCode)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (BankCode)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }

        public static bool InsertWithLastID(MSSQLConnect x_oDB, BankCode x_oBankCode, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT INTO  [BankCode]   ([active],[bank_code],[bank_name],[installment_period],[min_amount])  VALUES  (@active,@bank_code,@bank_name,@installment_period,@min_amount)" + " SELECT  @@IDENTITY AS BankCode_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BankCode]", "[" + Configurator.MSSQLTablePrefix + "BankCode]"); }
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
            return InsertTransactionLastID(x_oDB, _oConn, _oCmd, x_oBankCode, out x_iLAST_ID);
        }

        public static bool InsertTransactionLastID(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, BankCode x_oBankCode, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oBankCode.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if (x_oBankCode.active == null) { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = x_oBankCode.active; }
                if (x_oBankCode.bank_code == null) { x_oCmd.Parameters.Add("@bank_code", global::System.Data.SqlDbType.VarChar, 200).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@bank_code", global::System.Data.SqlDbType.VarChar, 200).Value = x_oBankCode.bank_code; }
                if (x_oBankCode.bank_name == null) { x_oCmd.Parameters.Add("@bank_name", global::System.Data.SqlDbType.VarChar, 200).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@bank_name", global::System.Data.SqlDbType.VarChar, 200).Value = x_oBankCode.bank_name; }
                if (x_oBankCode.installment_period == null) { x_oCmd.Parameters.Add("@installment_period", global::System.Data.SqlDbType.NVarChar, 250).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@installment_period", global::System.Data.SqlDbType.NVarChar, 250).Value = x_oBankCode.installment_period; }
                if (x_oBankCode.min_amount == null) { x_oCmd.Parameters.Add("@min_amount", global::System.Data.SqlDbType.NVarChar, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@min_amount", global::System.Data.SqlDbType.NVarChar, 10).Value = x_oBankCode.min_amount; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State == ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["BankCode_LASTID"]))
                    {
                        if (string.IsNullOrEmpty(_oData["BankCode_LASTID"].ToString()) && int.TryParse(_oData["BankCode_LASTID"].ToString(), out x_iLAST_ID))
                        {
                            _bResult = true;
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

        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, string x_sBank_code, string x_sBank_name, string x_sInstallment_period, global::System.Nullable<bool> x_bActive, string x_sMin_amount)
        {
            int _oLastID;
            BankCode _oBankCode = BankCodeRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oBankCode.bank_code = x_sBank_code;
            _oBankCode.bank_name = x_sBank_name;
            _oBankCode.installment_period = x_sInstallment_period;
            _oBankCode.active = x_bActive;
            _oBankCode.min_amount = x_sMin_amount;
            if (InsertWithLastID_SP(x_oDB, _oBankCode, out _oLastID))
            {
                return _oLastID;
            }
            else
            {
                return -1;
            }
        }


        public int InsertReturnLastID_SP(BankCode x_oBankCode)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oBankCode, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, BankCode x_oBankCode)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oBankCode, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is BankCode)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (BankCode)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB, BankCode x_oBankCode, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "BANKCODE";
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
            return InsertTransactionWithLastID_SP(x_oDB, _oConn, _oCmd, x_oBankCode, out x_oLAST_ID);
        }

        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, BankCode x_oBankCode, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar = x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oBankCode.active == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oBankCode.active; }
                _oPar = x_oCmd.Parameters.Add("@bank_code", global::System.Data.SqlDbType.VarChar, 200);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oBankCode.bank_code == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oBankCode.bank_code; }
                _oPar = x_oCmd.Parameters.Add("@bank_name", global::System.Data.SqlDbType.VarChar, 200);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oBankCode.bank_name == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oBankCode.bank_name; }
                _oPar = x_oCmd.Parameters.Add("@installment_period", global::System.Data.SqlDbType.NVarChar, 250);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oBankCode.installment_period == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oBankCode.installment_period; }
                _oPar = x_oCmd.Parameters.Add("@min_amount", global::System.Data.SqlDbType.NVarChar, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oBankCode.min_amount == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oBankCode.min_amount; }
                _oPar = x_oCmd.Parameters.Add("@RETURN_MID", global::System.Data.SqlDbType.Int);
                _oPar.Direction = ParameterDirection.Output;
                x_oCmd.CommandType = CommandType.StoredProcedure;
                if (!x_oDB.bTransaction && x_oConn.State == ConnectionState.Closed) x_oConn.Open();
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

        #region INSERT_BANKCODE Store Procedures
        ///-- =============================================
        ///-- Author:		<Author,Philip SW>
        ///-- Create date: <Create Date 2010-10-29>
        ///-- Description:	<Description,BANKCODE, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_BANKCODE Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_BANKCODE', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_BANKCODE;
        GO
        CREATE PROCEDURE INSERT_BANKCODE
        	-- Add the parameters for the stored procedure here
        @RETURN_MID int output,
        @bank_code varchar(200),
        @bank_name varchar(200),
        @installment_period nvarchar(250),
        @active bit,
        @min_amount nvarchar(10)
        AS
        
        INSERT INTO  [BankCode]   ([active],[bank_code],[bank_name],[installment_period],[min_amount])  VALUES  (@active,@bank_code,@bank_name,@installment_period,@min_amount)
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
            string _sQuery = "DELETE FROM  [BankCode]  WHERE [BankCode].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BankCode]", "[" + Configurator.MSSQLTablePrefix + "BankCode]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult = false;
                _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value = x_iMid;
                _oCmd.CommandType = CommandType.Text;
                try
                {
                    _oConn.Open();
                    _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
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
            return BankCodeRepositoryBase.DeleteAll(n_oDB);
        }

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "DELETE FROM  [BankCode]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BankCode]", "[" + Configurator.MSSQLTablePrefix + "BankCode]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oCmd.CommandType = CommandType.Text;
                bool _bResult = false;
                try
                {
                    _oConn.Open();
                    _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
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
            string _sQuery = "DELETE FROM [BankCode]" + x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BankCode]", "[" + Configurator.MSSQLTablePrefix + "BankCode]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult = false;
                _oCmd.CommandType = CommandType.Text;
                try
                {
                    _oConn.Open();
                    _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
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

