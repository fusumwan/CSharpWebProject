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
///-- Description:	<Description,Table :[BusinessVas],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [BusinessVas] Insert / list / delete manager layer
    /// </summary>

    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name = Configurator.MSSQLTablePrefix + "BusinessVas")]
    public class BusinessVasRepositoryBase : global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable
    {

        #region Instance
        private static BusinessVasRepositoryBase instance;
        public static BusinessVasRepositoryBase Instance()
        {
            if (instance == null)
            {
                MSSQLConnect _oDB = new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new BusinessVasRepositoryBase(_oDB);
            }
            return instance;
        }
        public static BusinessVasRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if (instance == null)
                instance = new BusinessVasRepositoryBase(x_oDB);
            return instance;
        }
        #endregion

        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<BusinessVasEntity> BusinessVass;
        #endregion

        #region Constructor
        public BusinessVasRepositoryBase(MSSQLConnect x_oDB)
            : base(x_oDB.ConnectionStr)
        {
            n_oDB = x_oDB;
        }
        ~BusinessVasRepositoryBase()
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
        public static BusinessVas CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new BusinessVas(_oDB);
        }

        public static BusinessVas CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new BusinessVas(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [BusinessVas]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVas]", "[" + Configurator.MSSQLTablePrefix + "BusinessVas]"); }
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


        public BusinessVasEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }


        public static BusinessVasEntity GetObj(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            if (x_oDB == null) { return null; }
            BusinessVas _BusinessVas = (BusinessVas)BusinessVasRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_BusinessVas.Load(x_iId)) { return null; }
            return _BusinessVas;
        }



        public static BusinessVasEntity[] GetArrayObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            List<BusinessVasEntity> _oBusinessVasList = GetListObj(x_oDB, 0, "id", x_oArrayItemId);
            return _oBusinessVasList.Count == 0 ? null : _oBusinessVasList.ToArray();
        }

        public static List<BusinessVasEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB, 0, "id", x_oArrayItemId);
        }


        public static BusinessVasEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<BusinessVasEntity> _oBusinessVasList = GetListObj(x_oDB, 0, x_oColumnName, x_oArrayItemId);
            return _oBusinessVasList.Count == 0 ? null : _oBusinessVasList.ToArray();
        }


        public static BusinessVasEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<BusinessVasEntity> _oBusinessVasList = GetListObj(x_oDB, x_iTop, x_oColumnName, x_oArrayItemId);
            return _oBusinessVasList.Count == 0 ? null : _oBusinessVasList.ToArray();
        }

        public static List<BusinessVasEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB == null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            List<BusinessVasEntity> _oRow = new List<BusinessVasEntity>();
            string _sQuery = "SELECT  " + _sTop + " [BusinessVas].[vas_field] AS BUSINESSVAS_VAS_FIELD,[BusinessVas].[multi] AS BUSINESSVAS_MULTI,[BusinessVas].[vas_name] AS BUSINESSVAS_VAS_NAME,[BusinessVas].[active] AS BUSINESSVAS_ACTIVE,[BusinessVas].[vas_value] AS BUSINESSVAS_VAS_VALUE,[BusinessVas].[id] AS BUSINESSVAS_ID,[BusinessVas].[vas_chi_name] AS BUSINESSVAS_VAS_CHI_NAME  FROM  [BusinessVas]";
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
                _sQuery += " WHERE [BusinessVas].[" + x_oColumnName.ToString() + "]  in " + _oList;
            }

            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVas]", "[" + Configurator.MSSQLTablePrefix + "BusinessVas]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        BusinessVas _oBusinessVas = BusinessVasRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVAS_VAS_FIELD"])) { _oBusinessVas.vas_field = (string)_oData["BUSINESSVAS_VAS_FIELD"]; } else { _oBusinessVas.vas_field = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVAS_VAS_NAME"])) { _oBusinessVas.vas_name = (string)_oData["BUSINESSVAS_VAS_NAME"]; } else { _oBusinessVas.vas_name = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVAS_ACTIVE"])) { _oBusinessVas.active = (global::System.Nullable<bool>)_oData["BUSINESSVAS_ACTIVE"]; } else { _oBusinessVas.active = null; }
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVAS_VAS_VALUE"])) { _oBusinessVas.vas_value = (string)_oData["BUSINESSVAS_VAS_VALUE"]; } else { _oBusinessVas.vas_value = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVAS_MULTI"])) { _oBusinessVas.multi = (global::System.Nullable<bool>)_oData["BUSINESSVAS_MULTI"]; } else { _oBusinessVas.multi = null; }
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVAS_ID"])) { _oBusinessVas.id = (global::System.Nullable<int>)_oData["BUSINESSVAS_ID"]; } else { _oBusinessVas.id = null; }
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVAS_VAS_CHI_NAME"])) { _oBusinessVas.vas_chi_name = (string)_oData["BUSINESSVAS_VAS_CHI_NAME"]; } else { _oBusinessVas.vas_chi_name = global::System.String.Empty; }
                        _oBusinessVas.SetDB(x_oDB);
                        _oBusinessVas.GetFound();
                        _oRow.Add(_oBusinessVas);
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


        public static BusinessVasEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<BusinessVasEntity> _oBusinessVasList = GetListObj(x_oDB, 0, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oBusinessVasList.Count == 0 ? null : _oBusinessVasList.ToArray();
        }


        public static BusinessVasEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<BusinessVasEntity> _oBusinessVasList = GetListObj(x_oDB, x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oBusinessVasList.Count == 0 ? null : _oBusinessVasList.ToArray();
        }

        public static List<BusinessVasEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB == null) { return null; }
            List<BusinessVasEntity> _oRow = new List<BusinessVasEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            string _sFields = "[BusinessVas].[vas_field] AS BUSINESSVAS_VAS_FIELD,[BusinessVas].[multi] AS BUSINESSVAS_MULTI,[BusinessVas].[vas_name] AS BUSINESSVAS_VAS_NAME,[BusinessVas].[active] AS BUSINESSVAS_ACTIVE,[BusinessVas].[vas_value] AS BUSINESSVAS_VAS_VALUE,[BusinessVas].[id] AS BUSINESSVAS_ID,[BusinessVas].[vas_chi_name] AS BUSINESSVAS_VAS_CHI_NAME";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[BusinessVas]", "[" + Configurator.MSSQLTablePrefix + "BusinessVas]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = BusinessVasRepositoryBase.GetSearch(x_oDB, _sTop.ToString() + _sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                BusinessVasEntity _oBusinessVas = BusinessVasRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVAS_VAS_FIELD"])) { _oBusinessVas.vas_field = (string)_oData["BUSINESSVAS_VAS_FIELD"]; } else { _oBusinessVas.vas_field = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVAS_VAS_NAME"])) { _oBusinessVas.vas_name = (string)_oData["BUSINESSVAS_VAS_NAME"]; } else { _oBusinessVas.vas_name = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVAS_ACTIVE"])) { _oBusinessVas.active = (global::System.Nullable<bool>)_oData["BUSINESSVAS_ACTIVE"]; } else { _oBusinessVas.active = null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVAS_VAS_VALUE"])) { _oBusinessVas.vas_value = (string)_oData["BUSINESSVAS_VAS_VALUE"]; } else { _oBusinessVas.vas_value = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVAS_MULTI"])) { _oBusinessVas.multi = (global::System.Nullable<bool>)_oData["BUSINESSVAS_MULTI"]; } else { _oBusinessVas.multi = null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVAS_ID"])) { _oBusinessVas.id = (global::System.Nullable<int>)_oData["BUSINESSVAS_ID"]; } else { _oBusinessVas.id = null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVAS_VAS_CHI_NAME"])) { _oBusinessVas.vas_chi_name = (string)_oData["BUSINESSVAS_VAS_CHI_NAME"]; } else { _oBusinessVas.vas_chi_name = global::System.String.Empty; }
                _oBusinessVas.SetDB(x_oDB);
                _oBusinessVas.GetFound();
                _oRow.Add(_oBusinessVas);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet(BusinessVas.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder, BusinessVas.Para.TableName());
            return _oDset;
        }


        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB == null) { return null; }
            return x_oDB.GetSearch(BusinessVas.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }


        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(BusinessVas.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            if (x_oDB == null) { return null; }
            string _oQuery = "SELECT   [BusinessVas].[vas_field] AS BUSINESSVAS_VAS_FIELD,[BusinessVas].[multi] AS BUSINESSVAS_MULTI,[BusinessVas].[vas_name] AS BUSINESSVAS_VAS_NAME,[BusinessVas].[active] AS BUSINESSVAS_ACTIVE,[BusinessVas].[vas_value] AS BUSINESSVAS_VAS_VALUE,[BusinessVas].[id] AS BUSINESSVAS_ID,[BusinessVas].[vas_chi_name] AS BUSINESSVAS_VAS_CHI_NAME  FROM  [BusinessVas]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[BusinessVas]", "[" + Configurator.MSSQLTablePrefix + "BusinessVas]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery, _oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset, "BusinessVas");
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

        public bool Insert(string x_sVas_field, string x_sVas_name, global::System.Nullable<bool> x_bActive, string x_sVas_value, global::System.Nullable<bool> x_bMulti, string x_sVas_chi_name)
        {
            BusinessVas _oBusinessVas = BusinessVasRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oBusinessVas.vas_field = x_sVas_field;
            _oBusinessVas.vas_name = x_sVas_name;
            _oBusinessVas.active = x_bActive;
            _oBusinessVas.vas_value = x_sVas_value;
            _oBusinessVas.multi = x_bMulti;
            _oBusinessVas.vas_chi_name = x_sVas_chi_name;
            return InsertWithOutLastID(n_oDB, _oBusinessVas);
        }


        public static bool Insert(MSSQLConnect x_oDB, string x_sVas_field, string x_sVas_name, global::System.Nullable<bool> x_bActive, string x_sVas_value, global::System.Nullable<bool> x_bMulti, string x_sVas_chi_name)
        {
            BusinessVas _oBusinessVas = BusinessVasRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oBusinessVas.vas_field = x_sVas_field;
            _oBusinessVas.vas_name = x_sVas_name;
            _oBusinessVas.active = x_bActive;
            _oBusinessVas.vas_value = x_sVas_value;
            _oBusinessVas.multi = x_bMulti;
            _oBusinessVas.vas_chi_name = x_sVas_chi_name;
            return InsertWithOutLastID(x_oDB, _oBusinessVas);
        }


        public bool Insert(BusinessVas x_oBusinessVas)
        {
            return InsertWithOutLastID(n_oDB, x_oBusinessVas);
        }


        public bool InsertEntity(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is BusinessVas)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (BusinessVas)x_oObj);
        }


        public static bool Insert(MSSQLConnect x_oDB, BusinessVas x_oBusinessVas)
        {
            return InsertWithOutLastID(x_oDB, x_oBusinessVas);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, BusinessVas x_oBusinessVas)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT INTO  [BusinessVas]   ([vas_field],[multi],[vas_name],[active],[vas_value],[vas_chi_name])  VALUES  (@vas_field,@multi,@vas_name,@active,@vas_value,@vas_chi_name)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVas]", "[" + Configurator.MSSQLTablePrefix + "BusinessVas]"); }
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
            return InsertTransactionWithOutLastID(x_oDB, _oConn, _oCmd, x_oBusinessVas);
        }

        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, BusinessVas x_oBusinessVas)
        {
            bool _bResult = false;
            if (!x_oBusinessVas.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if (x_oBusinessVas.vas_field == null) { x_oCmd.Parameters.Add("@vas_field", global::System.Data.SqlDbType.NVarChar, 50).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@vas_field", global::System.Data.SqlDbType.NVarChar, 50).Value = x_oBusinessVas.vas_field; }
                if (x_oBusinessVas.multi == null) { x_oCmd.Parameters.Add("@multi", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@multi", global::System.Data.SqlDbType.Bit).Value = x_oBusinessVas.multi; }
                if (x_oBusinessVas.vas_name == null) { x_oCmd.Parameters.Add("@vas_name", global::System.Data.SqlDbType.NVarChar, 50).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@vas_name", global::System.Data.SqlDbType.NVarChar, 50).Value = x_oBusinessVas.vas_name; }
                if (x_oBusinessVas.active == null) { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = x_oBusinessVas.active; }
                if (x_oBusinessVas.vas_value == null) { x_oCmd.Parameters.Add("@vas_value", global::System.Data.SqlDbType.NVarChar, 50).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@vas_value", global::System.Data.SqlDbType.NVarChar, 50).Value = x_oBusinessVas.vas_value; }
                if (x_oBusinessVas.vas_chi_name == null) { x_oCmd.Parameters.Add("@vas_chi_name", global::System.Data.SqlDbType.NVarChar, 50).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@vas_chi_name", global::System.Data.SqlDbType.NVarChar, 50).Value = x_oBusinessVas.vas_chi_name; }
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


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, string x_sVas_field, string x_sVas_name, global::System.Nullable<bool> x_bActive, string x_sVas_value, global::System.Nullable<bool> x_bMulti, string x_sVas_chi_name)
        {
            int _oLastID;
            BusinessVas _oBusinessVas = BusinessVasRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oBusinessVas.vas_field = x_sVas_field;
            _oBusinessVas.vas_name = x_sVas_name;
            _oBusinessVas.active = x_bActive;
            _oBusinessVas.vas_value = x_sVas_value;
            _oBusinessVas.multi = x_bMulti;
            _oBusinessVas.vas_chi_name = x_sVas_chi_name;
            if (InsertWithLastID_SP(x_oDB, _oBusinessVas, out _oLastID))
            {
                return _oLastID;
            }
            else
            {
                return -1;
            }
        }


        public int InsertReturnLastID_SP(BusinessVas x_oBusinessVas)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oBusinessVas, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, BusinessVas x_oBusinessVas)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oBusinessVas, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is BusinessVas)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (BusinessVas)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB, BusinessVas x_oBusinessVas, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "BUSINESSVAS";
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
            return InsertTransactionWithLastID_SP(x_oDB, _oConn, _oCmd, x_oBusinessVas, out x_oLAST_ID);
        }

        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, BusinessVas x_oBusinessVas, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar = x_oCmd.Parameters.Add("@vas_field", global::System.Data.SqlDbType.NVarChar, 50);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oBusinessVas.vas_field == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oBusinessVas.vas_field; }
                _oPar = x_oCmd.Parameters.Add("@multi", global::System.Data.SqlDbType.Bit);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oBusinessVas.multi == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oBusinessVas.multi; }
                _oPar = x_oCmd.Parameters.Add("@vas_name", global::System.Data.SqlDbType.NVarChar, 50);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oBusinessVas.vas_name == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oBusinessVas.vas_name; }
                _oPar = x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oBusinessVas.active == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oBusinessVas.active; }
                _oPar = x_oCmd.Parameters.Add("@vas_value", global::System.Data.SqlDbType.NVarChar, 50);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oBusinessVas.vas_value == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oBusinessVas.vas_value; }
                _oPar = x_oCmd.Parameters.Add("@vas_chi_name", global::System.Data.SqlDbType.NVarChar, 50);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oBusinessVas.vas_chi_name == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oBusinessVas.vas_chi_name; }
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

        #region INSERT_BUSINESSVAS Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2009-11-17>
        ///-- Description:	<Description,BUSINESSVAS, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_BUSINESSVAS Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_BUSINESSVAS', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_BUSINESSVAS;
        GO
        CREATE PROCEDURE INSERT_BUSINESSVAS
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @vas_field nvarchar(50),
        @vas_name nvarchar(50),
        @active bit,
        @vas_value nvarchar(50),
        @multi bit,
        @vas_chi_name nvarchar(50)
        AS
        
        INSERT INTO  [BusinessVas]   ([vas_field],[multi],[vas_name],[active],[vas_value],[vas_chi_name])  VALUES  (@vas_field,@multi,@vas_name,@active,@vas_value,@vas_chi_name)
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
            string _sQuery = "DELETE FROM  [BusinessVas]  WHERE [BusinessVas].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVas]", "[" + Configurator.MSSQLTablePrefix + "BusinessVas]"); }
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
            return BusinessVasRepositoryBase.DeleteAll(n_oDB);
        }

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "DELETE FROM  [BusinessVas]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVas]", "[" + Configurator.MSSQLTablePrefix + "BusinessVas]"); }
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
            string _sQuery = "DELETE FROM [BusinessVas]" + x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVas]", "[" + Configurator.MSSQLTablePrefix + "BusinessVas]"); }
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

