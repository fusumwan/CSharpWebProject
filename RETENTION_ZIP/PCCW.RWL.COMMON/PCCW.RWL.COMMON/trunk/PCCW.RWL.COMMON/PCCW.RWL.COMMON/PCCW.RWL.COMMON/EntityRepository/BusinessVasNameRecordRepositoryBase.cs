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
///-- Create date: <Create Date 2009-11-20>
///-- Description:	<Description,Table :[BusinessVasNameRecord],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE
{
    /// <summary>
    /// Summary description for table [BusinessVasNameRecord] Insert / list / delete manager layer
    /// </summary>

    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name = Configurator.MSSQLTablePrefix + "BusinessVasNameRecord")]
    public class BusinessVasNameRecordRepositoryBase : global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable
    {

        #region Instance
        private static BusinessVasNameRecordRepositoryBase instance;
        public static BusinessVasNameRecordRepositoryBase Instance()
        {
            if (instance == null)
            {
                MSSQLConnect _oDB = new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new BusinessVasNameRecordRepositoryBase(_oDB);
            }
            return instance;
        }
        public static BusinessVasNameRecordRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if (instance == null)
                instance = new BusinessVasNameRecordRepositoryBase(x_oDB);
            return instance;
        }
        #endregion

        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<BusinessVasNameRecordEntity> BusinessVasNameRecords;
        #endregion

        #region Constructor
        public BusinessVasNameRecordRepositoryBase(MSSQLConnect x_oDB)
            : base(x_oDB.ConnectionStr)
        {
            n_oDB = x_oDB;
        }
        ~BusinessVasNameRecordRepositoryBase()
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
        public static BusinessVasNameRecord CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new BusinessVasNameRecord(_oDB);
        }

        public static BusinessVasNameRecord CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new BusinessVasNameRecord(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [BusinessVasNameRecord]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVasNameRecord]", "[" + Configurator.MSSQLTablePrefix + "BusinessVasNameRecord]"); }
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


        public BusinessVasNameRecordEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }


        public static BusinessVasNameRecordEntity GetObj(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            if (x_oDB == null) { return null; }
            BusinessVasNameRecord _BusinessVasNameRecord = (BusinessVasNameRecord)BusinessVasNameRecordRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_BusinessVasNameRecord.Load(x_iId)) { return null; }
            return _BusinessVasNameRecord;
        }



        public static BusinessVasNameRecordEntity[] GetArrayObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            List<BusinessVasNameRecordEntity> _oBusinessVasNameRecordList = GetListObj(x_oDB, 0, "id", x_oArrayItemId);
            return _oBusinessVasNameRecordList.Count == 0 ? null : _oBusinessVasNameRecordList.ToArray();
        }

        public static List<BusinessVasNameRecordEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB, 0, "id", x_oArrayItemId);
        }


        public static BusinessVasNameRecordEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<BusinessVasNameRecordEntity> _oBusinessVasNameRecordList = GetListObj(x_oDB, 0, x_oColumnName, x_oArrayItemId);
            return _oBusinessVasNameRecordList.Count == 0 ? null : _oBusinessVasNameRecordList.ToArray();
        }


        public static BusinessVasNameRecordEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<BusinessVasNameRecordEntity> _oBusinessVasNameRecordList = GetListObj(x_oDB, x_iTop, x_oColumnName, x_oArrayItemId);
            return _oBusinessVasNameRecordList.Count == 0 ? null : _oBusinessVasNameRecordList.ToArray();
        }

        public static List<BusinessVasNameRecordEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB == null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            List<BusinessVasNameRecordEntity> _oRow = new List<BusinessVasNameRecordEntity>();
            string _sQuery = "SELECT  " + _sTop + " [BusinessVasNameRecord].[vas_field] AS BUSINESSVASNAMERECORD_VAS_FIELD,[BusinessVasNameRecord].[vas_name] AS BUSINESSVASNAMERECORD_VAS_NAME,[BusinessVasNameRecord].[active] AS BUSINESSVASNAMERECORD_ACTIVE,[BusinessVasNameRecord].[id] AS BUSINESSVASNAMERECORD_ID,[BusinessVasNameRecord].[vas_chi_name] AS BUSINESSVASNAMERECORD_VAS_CHI_NAME  FROM  [BusinessVasNameRecord]";
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
                _sQuery += " WHERE [BusinessVasNameRecord].[" + x_oColumnName.ToString() + "]  in " + _oList;
            }

            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVasNameRecord]", "[" + Configurator.MSSQLTablePrefix + "BusinessVasNameRecord]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        BusinessVasNameRecord _oBusinessVasNameRecord = BusinessVasNameRecordRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASNAMERECORD_VAS_FIELD"])) { _oBusinessVasNameRecord.vas_field = (string)_oData["BUSINESSVASNAMERECORD_VAS_FIELD"]; } else { _oBusinessVasNameRecord.vas_field = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASNAMERECORD_VAS_NAME"])) { _oBusinessVasNameRecord.vas_name = (string)_oData["BUSINESSVASNAMERECORD_VAS_NAME"]; } else { _oBusinessVasNameRecord.vas_name = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASNAMERECORD_ID"])) { _oBusinessVasNameRecord.id = (global::System.Nullable<int>)_oData["BUSINESSVASNAMERECORD_ID"]; } else { _oBusinessVasNameRecord.id = null; }
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASNAMERECORD_ACTIVE"])) { _oBusinessVasNameRecord.active = (global::System.Nullable<bool>)_oData["BUSINESSVASNAMERECORD_ACTIVE"]; } else { _oBusinessVasNameRecord.active = null; }
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASNAMERECORD_VAS_CHI_NAME"])) { _oBusinessVasNameRecord.vas_chi_name = (string)_oData["BUSINESSVASNAMERECORD_VAS_CHI_NAME"]; } else { _oBusinessVasNameRecord.vas_chi_name = global::System.String.Empty; }
                        _oBusinessVasNameRecord.SetDB(x_oDB);
                        _oBusinessVasNameRecord.GetFound();
                        _oRow.Add(_oBusinessVasNameRecord);
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


        public static BusinessVasNameRecordEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<BusinessVasNameRecordEntity> _oBusinessVasNameRecordList = GetListObj(x_oDB, 0, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oBusinessVasNameRecordList.Count == 0 ? null : _oBusinessVasNameRecordList.ToArray();
        }


        public static BusinessVasNameRecordEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<BusinessVasNameRecordEntity> _oBusinessVasNameRecordList = GetListObj(x_oDB, x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oBusinessVasNameRecordList.Count == 0 ? null : _oBusinessVasNameRecordList.ToArray();
        }

        public static List<BusinessVasNameRecordEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB == null) { return null; }
            List<BusinessVasNameRecordEntity> _oRow = new List<BusinessVasNameRecordEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            string _sFields = "[BusinessVasNameRecord].[vas_field] AS BUSINESSVASNAMERECORD_VAS_FIELD,[BusinessVasNameRecord].[vas_name] AS BUSINESSVASNAMERECORD_VAS_NAME,[BusinessVasNameRecord].[active] AS BUSINESSVASNAMERECORD_ACTIVE,[BusinessVasNameRecord].[id] AS BUSINESSVASNAMERECORD_ID,[BusinessVasNameRecord].[vas_chi_name] AS BUSINESSVASNAMERECORD_VAS_CHI_NAME";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[BusinessVasNameRecord]", "[" + Configurator.MSSQLTablePrefix + "BusinessVasNameRecord]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = BusinessVasNameRecordRepositoryBase.GetSearch(x_oDB, _sTop.ToString() + _sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                BusinessVasNameRecordEntity _oBusinessVasNameRecord = BusinessVasNameRecordRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASNAMERECORD_VAS_FIELD"])) { _oBusinessVasNameRecord.vas_field = (string)_oData["BUSINESSVASNAMERECORD_VAS_FIELD"]; } else { _oBusinessVasNameRecord.vas_field = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASNAMERECORD_VAS_NAME"])) { _oBusinessVasNameRecord.vas_name = (string)_oData["BUSINESSVASNAMERECORD_VAS_NAME"]; } else { _oBusinessVasNameRecord.vas_name = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASNAMERECORD_ID"])) { _oBusinessVasNameRecord.id = (global::System.Nullable<int>)_oData["BUSINESSVASNAMERECORD_ID"]; } else { _oBusinessVasNameRecord.id = null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASNAMERECORD_ACTIVE"])) { _oBusinessVasNameRecord.active = (global::System.Nullable<bool>)_oData["BUSINESSVASNAMERECORD_ACTIVE"]; } else { _oBusinessVasNameRecord.active = null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASNAMERECORD_VAS_CHI_NAME"])) { _oBusinessVasNameRecord.vas_chi_name = (string)_oData["BUSINESSVASNAMERECORD_VAS_CHI_NAME"]; } else { _oBusinessVasNameRecord.vas_chi_name = global::System.String.Empty; }
                _oBusinessVasNameRecord.SetDB(x_oDB);
                _oBusinessVasNameRecord.GetFound();
                _oRow.Add(_oBusinessVasNameRecord);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet(BusinessVasNameRecord.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder, BusinessVasNameRecord.Para.TableName());
            return _oDset;
        }


        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB == null) { return null; }
            return x_oDB.GetSearch(BusinessVasNameRecord.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }


        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(BusinessVasNameRecord.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            if (x_oDB == null) { return null; }
            string _oQuery = "SELECT   [BusinessVasNameRecord].[vas_field] AS BUSINESSVASNAMERECORD_VAS_FIELD,[BusinessVasNameRecord].[vas_name] AS BUSINESSVASNAMERECORD_VAS_NAME,[BusinessVasNameRecord].[active] AS BUSINESSVASNAMERECORD_ACTIVE,[BusinessVasNameRecord].[id] AS BUSINESSVASNAMERECORD_ID,[BusinessVasNameRecord].[vas_chi_name] AS BUSINESSVASNAMERECORD_VAS_CHI_NAME  FROM  [BusinessVasNameRecord]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[BusinessVasNameRecord]", "[" + Configurator.MSSQLTablePrefix + "BusinessVasNameRecord]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery, _oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset, "BusinessVasNameRecord");
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

        public bool Insert(string x_sVas_field, string x_sVas_name, global::System.Nullable<bool> x_bActive, string x_sVas_chi_name)
        {
            BusinessVasNameRecord _oBusinessVasNameRecord = BusinessVasNameRecordRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oBusinessVasNameRecord.vas_field = x_sVas_field;
            _oBusinessVasNameRecord.vas_name = x_sVas_name;
            _oBusinessVasNameRecord.active = x_bActive;
            _oBusinessVasNameRecord.vas_chi_name = x_sVas_chi_name;
            return InsertWithOutLastID(n_oDB, _oBusinessVasNameRecord);
        }


        public static bool Insert(MSSQLConnect x_oDB, string x_sVas_field, string x_sVas_name, global::System.Nullable<bool> x_bActive, string x_sVas_chi_name)
        {
            BusinessVasNameRecord _oBusinessVasNameRecord = BusinessVasNameRecordRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oBusinessVasNameRecord.vas_field = x_sVas_field;
            _oBusinessVasNameRecord.vas_name = x_sVas_name;
            _oBusinessVasNameRecord.active = x_bActive;
            _oBusinessVasNameRecord.vas_chi_name = x_sVas_chi_name;
            return InsertWithOutLastID(x_oDB, _oBusinessVasNameRecord);
        }


        public bool Insert(BusinessVasNameRecord x_oBusinessVasNameRecord)
        {
            return InsertWithOutLastID(n_oDB, x_oBusinessVasNameRecord);
        }


        public bool InsertEntity(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is BusinessVasNameRecord)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (BusinessVasNameRecord)x_oObj);
        }


        public static bool Insert(MSSQLConnect x_oDB, BusinessVasNameRecord x_oBusinessVasNameRecord)
        {
            return InsertWithOutLastID(x_oDB, x_oBusinessVasNameRecord);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, BusinessVasNameRecord x_oBusinessVasNameRecord)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT INTO  [BusinessVasNameRecord]   ([vas_field],[vas_name],[active],[vas_chi_name])  VALUES  (@vas_field,@vas_name,@active,@vas_chi_name)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVasNameRecord]", "[" + Configurator.MSSQLTablePrefix + "BusinessVasNameRecord]"); }
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
            return InsertTransactionWithOutLastID(x_oDB, _oConn, _oCmd, x_oBusinessVasNameRecord);
        }

        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, BusinessVasNameRecord x_oBusinessVasNameRecord)
        {
            bool _bResult = false;
            if (!x_oBusinessVasNameRecord.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if (x_oBusinessVasNameRecord.vas_field == null) { x_oCmd.Parameters.Add("@vas_field", global::System.Data.SqlDbType.NVarChar, 50).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@vas_field", global::System.Data.SqlDbType.NVarChar, 50).Value = x_oBusinessVasNameRecord.vas_field; }
                if (x_oBusinessVasNameRecord.vas_name == null) { x_oCmd.Parameters.Add("@vas_name", global::System.Data.SqlDbType.NVarChar, 50).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@vas_name", global::System.Data.SqlDbType.NVarChar, 50).Value = x_oBusinessVasNameRecord.vas_name; }
                if (x_oBusinessVasNameRecord.active == null) { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = x_oBusinessVasNameRecord.active; }
                if (x_oBusinessVasNameRecord.vas_chi_name == null) { x_oCmd.Parameters.Add("@vas_chi_name", global::System.Data.SqlDbType.NVarChar, 50).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@vas_chi_name", global::System.Data.SqlDbType.NVarChar, 50).Value = x_oBusinessVasNameRecord.vas_chi_name; }
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


        public static int InsertReturnLastID(MSSQLConnect x_oDB, string x_sVas_field, string x_sVas_name, global::System.Nullable<bool> x_bActive, string x_sVas_chi_name)
        {
            int _oLastID;
            BusinessVasNameRecord _oBusinessVasNameRecord = BusinessVasNameRecordRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oBusinessVasNameRecord.vas_field = x_sVas_field;
            _oBusinessVasNameRecord.vas_name = x_sVas_name;
            _oBusinessVasNameRecord.active = x_bActive;
            _oBusinessVasNameRecord.vas_chi_name = x_sVas_chi_name;
            if (InsertWithLastID(x_oDB, _oBusinessVasNameRecord, out _oLastID))
            {
                return _oLastID;
            }
            else
            {
                return -1;
            }
        }


        public int InsertReturnLastID(BusinessVasNameRecord x_oBusinessVasNameRecord)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oBusinessVasNameRecord, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }


        public static int InsertReturnLastID(MSSQLConnect x_oDB, BusinessVasNameRecord x_oBusinessVasNameRecord)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oBusinessVasNameRecord, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is BusinessVasNameRecord)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (BusinessVasNameRecord)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }

        public static bool InsertWithLastID(MSSQLConnect x_oDB, BusinessVasNameRecord x_oBusinessVasNameRecord, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT INTO  [BusinessVasNameRecord]   ([vas_field],[vas_name],[active],[vas_chi_name])  VALUES  (@vas_field,@vas_name,@active,@vas_chi_name)" + " SELECT  @@IDENTITY AS BusinessVasNameRecord_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVasNameRecord]", "[" + Configurator.MSSQLTablePrefix + "BusinessVasNameRecord]"); }
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
            return InsertTransactionLastID(x_oDB, _oConn, _oCmd, x_oBusinessVasNameRecord, out x_iLAST_ID);
        }

        public static bool InsertTransactionLastID(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, BusinessVasNameRecord x_oBusinessVasNameRecord, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oBusinessVasNameRecord.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if (x_oBusinessVasNameRecord.vas_field == null) { x_oCmd.Parameters.Add("@vas_field", global::System.Data.SqlDbType.NVarChar, 50).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@vas_field", global::System.Data.SqlDbType.NVarChar, 50).Value = x_oBusinessVasNameRecord.vas_field; }
                if (x_oBusinessVasNameRecord.vas_name == null) { x_oCmd.Parameters.Add("@vas_name", global::System.Data.SqlDbType.NVarChar, 50).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@vas_name", global::System.Data.SqlDbType.NVarChar, 50).Value = x_oBusinessVasNameRecord.vas_name; }
                if (x_oBusinessVasNameRecord.active == null) { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = x_oBusinessVasNameRecord.active; }
                if (x_oBusinessVasNameRecord.vas_chi_name == null) { x_oCmd.Parameters.Add("@vas_chi_name", global::System.Data.SqlDbType.NVarChar, 50).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@vas_chi_name", global::System.Data.SqlDbType.NVarChar, 50).Value = x_oBusinessVasNameRecord.vas_chi_name; }
                if (!x_oDB.bTransaction && x_oConn.State == ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["BusinessVasNameRecord_LASTID"]))
                    {
                        if (string.IsNullOrEmpty(_oData["BusinessVasNameRecord_LASTID"].ToString()) && int.TryParse(_oData["BusinessVasNameRecord_LASTID"].ToString(), out x_iLAST_ID))
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

        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, string x_sVas_field, string x_sVas_name, global::System.Nullable<bool> x_bActive, string x_sVas_chi_name)
        {
            int _oLastID;
            BusinessVasNameRecord _oBusinessVasNameRecord = BusinessVasNameRecordRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oBusinessVasNameRecord.vas_field = x_sVas_field;
            _oBusinessVasNameRecord.vas_name = x_sVas_name;
            _oBusinessVasNameRecord.active = x_bActive;
            _oBusinessVasNameRecord.vas_chi_name = x_sVas_chi_name;
            if (InsertWithLastID_SP(x_oDB, _oBusinessVasNameRecord, out _oLastID))
            {
                return _oLastID;
            }
            else
            {
                return -1;
            }
        }


        public int InsertReturnLastID_SP(BusinessVasNameRecord x_oBusinessVasNameRecord)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oBusinessVasNameRecord, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, BusinessVasNameRecord x_oBusinessVasNameRecord)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oBusinessVasNameRecord, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is BusinessVasNameRecord)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (BusinessVasNameRecord)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB, BusinessVasNameRecord x_oBusinessVasNameRecord, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "BUSINESSVASNAMERECORD";
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
            return InsertTransactionWithLastID_SP(x_oDB, _oConn, _oCmd, x_oBusinessVasNameRecord, out x_oLAST_ID);
        }

        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, BusinessVasNameRecord x_oBusinessVasNameRecord, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar = x_oCmd.Parameters.Add("@vas_field", global::System.Data.SqlDbType.NVarChar, 50);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oBusinessVasNameRecord.vas_field == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oBusinessVasNameRecord.vas_field; }
                _oPar = x_oCmd.Parameters.Add("@vas_name", global::System.Data.SqlDbType.NVarChar, 50);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oBusinessVasNameRecord.vas_name == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oBusinessVasNameRecord.vas_name; }
                _oPar = x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oBusinessVasNameRecord.active == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oBusinessVasNameRecord.active; }
                _oPar = x_oCmd.Parameters.Add("@vas_chi_name", global::System.Data.SqlDbType.NVarChar, 50);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oBusinessVasNameRecord.vas_chi_name == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oBusinessVasNameRecord.vas_chi_name; }
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

        #region INSERT_BUSINESSVASNAMERECORD Store Procedures
        ///-- =============================================
        ///-- Author:		<Author,Philip SW>
        ///-- Create date: <Create Date 2009-11-20>
        ///-- Description:	<Description,BUSINESSVASNAMERECORD, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_BUSINESSVASNAMERECORD Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_BUSINESSVASNAMERECORD', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_BUSINESSVASNAMERECORD;
        GO
        CREATE PROCEDURE INSERT_BUSINESSVASNAMERECORD
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @vas_field nvarchar(50),
        @vas_name nvarchar(50),
        @active bit,
        @vas_chi_name nvarchar(50)
        AS
        
        INSERT INTO  [BusinessVasNameRecord]   ([vas_field],[vas_name],[active],[vas_chi_name])  VALUES  (@vas_field,@vas_name,@active,@vas_chi_name)
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
            string _sQuery = "DELETE FROM  [BusinessVasNameRecord]  WHERE [BusinessVasNameRecord].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVasNameRecord]", "[" + Configurator.MSSQLTablePrefix + "BusinessVasNameRecord]"); }
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
            return BusinessVasNameRecordRepositoryBase.DeleteAll(n_oDB);
        }

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "DELETE FROM  [BusinessVasNameRecord]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVasNameRecord]", "[" + Configurator.MSSQLTablePrefix + "BusinessVasNameRecord]"); }
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
            string _sQuery = "DELETE FROM [BusinessVasNameRecord]" + x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVasNameRecord]", "[" + Configurator.MSSQLTablePrefix + "BusinessVasNameRecord]"); }
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

