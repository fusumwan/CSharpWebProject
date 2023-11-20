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
///-- Description:	<Description,Table :[BusinessVasDescription],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [BusinessVasDescription] Insert / list / delete manager layer
    /// </summary>

    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name = Configurator.MSSQLTablePrefix + "BusinessVasDescription")]
    public class BusinessVasDescriptionRepositoryBase : global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable
    {

        #region Instance
        private static BusinessVasDescriptionRepositoryBase instance;
        public static BusinessVasDescriptionRepositoryBase Instance()
        {
            if (instance == null)
            {
                MSSQLConnect _oDB = new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new BusinessVasDescriptionRepositoryBase(_oDB);
            }
            return instance;
        }
        public static BusinessVasDescriptionRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if (instance == null)
                instance = new BusinessVasDescriptionRepositoryBase(x_oDB);
            return instance;
        }
        #endregion

        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<BusinessVasDescriptionEntity> BusinessVasDescriptions;
        #endregion

        #region Constructor
        public BusinessVasDescriptionRepositoryBase(MSSQLConnect x_oDB)
            : base(x_oDB.ConnectionStr)
        {
            n_oDB = x_oDB;
        }
        ~BusinessVasDescriptionRepositoryBase()
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
        public static BusinessVasDescription CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new BusinessVasDescription(_oDB);
        }

        public static BusinessVasDescription CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new BusinessVasDescription(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [BusinessVasDescription]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVasDescription]", "[" + Configurator.MSSQLTablePrefix + "BusinessVasDescription]"); }
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


        public BusinessVasDescriptionEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }


        public static BusinessVasDescriptionEntity GetObj(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            if (x_oDB == null) { return null; }
            BusinessVasDescription _BusinessVasDescription = (BusinessVasDescription)BusinessVasDescriptionRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_BusinessVasDescription.Load(x_iId)) { return null; }
            return _BusinessVasDescription;
        }



        public static BusinessVasDescriptionEntity[] GetArrayObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            List<BusinessVasDescriptionEntity> _oBusinessVasDescriptionList = GetListObj(x_oDB, 0, "id", x_oArrayItemId);
            return _oBusinessVasDescriptionList.Count == 0 ? null : _oBusinessVasDescriptionList.ToArray();
        }

        public static List<BusinessVasDescriptionEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB, 0, "id", x_oArrayItemId);
        }


        public static BusinessVasDescriptionEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<BusinessVasDescriptionEntity> _oBusinessVasDescriptionList = GetListObj(x_oDB, 0, x_oColumnName, x_oArrayItemId);
            return _oBusinessVasDescriptionList.Count == 0 ? null : _oBusinessVasDescriptionList.ToArray();
        }


        public static BusinessVasDescriptionEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<BusinessVasDescriptionEntity> _oBusinessVasDescriptionList = GetListObj(x_oDB, x_iTop, x_oColumnName, x_oArrayItemId);
            return _oBusinessVasDescriptionList.Count == 0 ? null : _oBusinessVasDescriptionList.ToArray();
        }

        public static List<BusinessVasDescriptionEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB == null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            List<BusinessVasDescriptionEntity> _oRow = new List<BusinessVasDescriptionEntity>();
            string _sQuery = "SELECT  " + _sTop + " [BusinessVasDescription].[active] AS BUSINESSVASDESCRIPTION_ACTIVE,[BusinessVasDescription].[vas_desc] AS BUSINESSVASDESCRIPTION_VAS_DESC,[BusinessVasDescription].[fee] AS BUSINESSVASDESCRIPTION_FEE,[BusinessVasDescription].[vas] AS BUSINESSVASDESCRIPTION_VAS,[BusinessVasDescription].[id] AS BUSINESSVASDESCRIPTION_ID  FROM  [BusinessVasDescription]";
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
                _sQuery += " WHERE [BusinessVasDescription].[" + x_oColumnName.ToString() + "]  in " + _oList;
            }

            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVasDescription]", "[" + Configurator.MSSQLTablePrefix + "BusinessVasDescription]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        BusinessVasDescription _oBusinessVasDescription = BusinessVasDescriptionRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDESCRIPTION_ID"])) { _oBusinessVasDescription.id = (global::System.Nullable<int>)_oData["BUSINESSVASDESCRIPTION_ID"]; } else { _oBusinessVasDescription.id = null; }
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDESCRIPTION_FEE"])) { _oBusinessVasDescription.fee = (string)_oData["BUSINESSVASDESCRIPTION_FEE"]; } else { _oBusinessVasDescription.fee = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDESCRIPTION_VAS_DESC"])) { _oBusinessVasDescription.vas_desc = (string)_oData["BUSINESSVASDESCRIPTION_VAS_DESC"]; } else { _oBusinessVasDescription.vas_desc = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDESCRIPTION_ACTIVE"])) { _oBusinessVasDescription.active = (global::System.Nullable<bool>)_oData["BUSINESSVASDESCRIPTION_ACTIVE"]; } else { _oBusinessVasDescription.active = null; }
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDESCRIPTION_VAS"])) { _oBusinessVasDescription.vas = (string)_oData["BUSINESSVASDESCRIPTION_VAS"]; } else { _oBusinessVasDescription.vas = global::System.String.Empty; }
                        _oBusinessVasDescription.SetDB(x_oDB);
                        _oBusinessVasDescription.GetFound();
                        _oRow.Add(_oBusinessVasDescription);
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


        public static BusinessVasDescriptionEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<BusinessVasDescriptionEntity> _oBusinessVasDescriptionList = GetListObj(x_oDB, 0, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oBusinessVasDescriptionList.Count == 0 ? null : _oBusinessVasDescriptionList.ToArray();
        }


        public static BusinessVasDescriptionEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<BusinessVasDescriptionEntity> _oBusinessVasDescriptionList = GetListObj(x_oDB, x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oBusinessVasDescriptionList.Count == 0 ? null : _oBusinessVasDescriptionList.ToArray();
        }

        public static List<BusinessVasDescriptionEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB == null) { return null; }
            List<BusinessVasDescriptionEntity> _oRow = new List<BusinessVasDescriptionEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            string _sFields = "[BusinessVasDescription].[active] AS BUSINESSVASDESCRIPTION_ACTIVE,[BusinessVasDescription].[vas_desc] AS BUSINESSVASDESCRIPTION_VAS_DESC,[BusinessVasDescription].[fee] AS BUSINESSVASDESCRIPTION_FEE,[BusinessVasDescription].[vas] AS BUSINESSVASDESCRIPTION_VAS,[BusinessVasDescription].[id] AS BUSINESSVASDESCRIPTION_ID";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[BusinessVasDescription]", "[" + Configurator.MSSQLTablePrefix + "BusinessVasDescription]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = BusinessVasDescriptionRepositoryBase.GetSearch(x_oDB, _sTop.ToString() + _sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                BusinessVasDescriptionEntity _oBusinessVasDescription = BusinessVasDescriptionRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDESCRIPTION_ID"])) { _oBusinessVasDescription.id = (global::System.Nullable<int>)_oData["BUSINESSVASDESCRIPTION_ID"]; } else { _oBusinessVasDescription.id = null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDESCRIPTION_FEE"])) { _oBusinessVasDescription.fee = (string)_oData["BUSINESSVASDESCRIPTION_FEE"]; } else { _oBusinessVasDescription.fee = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDESCRIPTION_VAS_DESC"])) { _oBusinessVasDescription.vas_desc = (string)_oData["BUSINESSVASDESCRIPTION_VAS_DESC"]; } else { _oBusinessVasDescription.vas_desc = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDESCRIPTION_ACTIVE"])) { _oBusinessVasDescription.active = (global::System.Nullable<bool>)_oData["BUSINESSVASDESCRIPTION_ACTIVE"]; } else { _oBusinessVasDescription.active = null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDESCRIPTION_VAS"])) { _oBusinessVasDescription.vas = (string)_oData["BUSINESSVASDESCRIPTION_VAS"]; } else { _oBusinessVasDescription.vas = global::System.String.Empty; }
                _oBusinessVasDescription.SetDB(x_oDB);
                _oBusinessVasDescription.GetFound();
                _oRow.Add(_oBusinessVasDescription);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet(BusinessVasDescription.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder, BusinessVasDescription.Para.TableName());
            return _oDset;
        }


        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB == null) { return null; }
            return x_oDB.GetSearch(BusinessVasDescription.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }


        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(BusinessVasDescription.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            if (x_oDB == null) { return null; }
            string _oQuery = "SELECT   [BusinessVasDescription].[active] AS BUSINESSVASDESCRIPTION_ACTIVE,[BusinessVasDescription].[vas_desc] AS BUSINESSVASDESCRIPTION_VAS_DESC,[BusinessVasDescription].[fee] AS BUSINESSVASDESCRIPTION_FEE,[BusinessVasDescription].[vas] AS BUSINESSVASDESCRIPTION_VAS,[BusinessVasDescription].[id] AS BUSINESSVASDESCRIPTION_ID  FROM  [BusinessVasDescription]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[BusinessVasDescription]", "[" + Configurator.MSSQLTablePrefix + "BusinessVasDescription]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery, _oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset, "BusinessVasDescription");
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

        public bool Insert(string x_sFee, string x_sVas_desc, global::System.Nullable<bool> x_bActive, string x_sVas)
        {
            BusinessVasDescription _oBusinessVasDescription = BusinessVasDescriptionRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oBusinessVasDescription.fee = x_sFee;
            _oBusinessVasDescription.vas_desc = x_sVas_desc;
            _oBusinessVasDescription.active = x_bActive;
            _oBusinessVasDescription.vas = x_sVas;
            return InsertWithOutLastID(n_oDB, _oBusinessVasDescription);
        }

        public static bool Insert(MSSQLConnect x_oDB, string x_sFee, string x_sVas_desc, global::System.Nullable<bool> x_bActive, string x_sVas)
        {
            BusinessVasDescription _oBusinessVasDescription = BusinessVasDescriptionRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oBusinessVasDescription.fee = x_sFee;
            _oBusinessVasDescription.vas_desc = x_sVas_desc;
            _oBusinessVasDescription.active = x_bActive;
            _oBusinessVasDescription.vas = x_sVas;
            return InsertWithOutLastID(x_oDB, _oBusinessVasDescription);
        }

        public bool Insert(BusinessVasDescription x_oBusinessVasDescription)
        {
            return InsertWithOutLastID(n_oDB, x_oBusinessVasDescription);
        }

        public bool InsertEntity(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is BusinessVasDescription)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (BusinessVasDescription)x_oObj);
        }


        public static bool Insert(MSSQLConnect x_oDB, BusinessVasDescription x_oBusinessVasDescription)
        {
            return InsertWithOutLastID(x_oDB, x_oBusinessVasDescription);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, BusinessVasDescription x_oBusinessVasDescription)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT INTO  [BusinessVasDescription]   ([active],[vas_desc],[fee],[vas])  VALUES  (@active,@vas_desc,@fee,@vas)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVasDescription]", "[" + Configurator.MSSQLTablePrefix + "BusinessVasDescription]"); }
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
            return InsertTransactionWithOutLastID(x_oDB, _oConn, _oCmd, x_oBusinessVasDescription);
        }

        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, BusinessVasDescription x_oBusinessVasDescription)
        {
            bool _bResult = false;
            if (!x_oBusinessVasDescription.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if (x_oBusinessVasDescription.active == null) { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = x_oBusinessVasDescription.active; }
                if (x_oBusinessVasDescription.vas_desc == null) { x_oCmd.Parameters.Add("@vas_desc", global::System.Data.SqlDbType.NVarChar, 50).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@vas_desc", global::System.Data.SqlDbType.NVarChar, 50).Value = x_oBusinessVasDescription.vas_desc; }
                if (x_oBusinessVasDescription.fee == null) { x_oCmd.Parameters.Add("@fee", global::System.Data.SqlDbType.NVarChar, 50).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@fee", global::System.Data.SqlDbType.NVarChar, 50).Value = x_oBusinessVasDescription.fee; }
                if (x_oBusinessVasDescription.vas == null) { x_oCmd.Parameters.Add("@vas", global::System.Data.SqlDbType.NVarChar, 50).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@vas", global::System.Data.SqlDbType.NVarChar, 50).Value = x_oBusinessVasDescription.vas; }
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


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, string x_sFee, string x_sVas_desc, global::System.Nullable<bool> x_bActive, string x_sVas)
        {
            int _oLastID;
            BusinessVasDescription _oBusinessVasDescription = BusinessVasDescriptionRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oBusinessVasDescription.fee = x_sFee;
            _oBusinessVasDescription.vas_desc = x_sVas_desc;
            _oBusinessVasDescription.active = x_bActive;
            _oBusinessVasDescription.vas = x_sVas;
            if (InsertWithLastID_SP(x_oDB, _oBusinessVasDescription, out _oLastID))
            {
                return _oLastID;
            }
            else
            {
                return -1;
            }
        }


        public int InsertReturnLastID_SP(BusinessVasDescription x_oBusinessVasDescription)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oBusinessVasDescription, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, BusinessVasDescription x_oBusinessVasDescription)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oBusinessVasDescription, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is BusinessVasDescription)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (BusinessVasDescription)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB, BusinessVasDescription x_oBusinessVasDescription, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "BUSINESSVASDESCRIPTION";
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
            return InsertTransactionWithLastID_SP(x_oDB, _oConn, _oCmd, x_oBusinessVasDescription, out x_oLAST_ID);
        }

        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, BusinessVasDescription x_oBusinessVasDescription, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar = x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oBusinessVasDescription.active == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oBusinessVasDescription.active; }
                _oPar = x_oCmd.Parameters.Add("@vas_desc", global::System.Data.SqlDbType.NVarChar, 50);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oBusinessVasDescription.vas_desc == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oBusinessVasDescription.vas_desc; }
                _oPar = x_oCmd.Parameters.Add("@fee", global::System.Data.SqlDbType.NVarChar, 50);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oBusinessVasDescription.fee == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oBusinessVasDescription.fee; }
                _oPar = x_oCmd.Parameters.Add("@vas", global::System.Data.SqlDbType.NVarChar, 50);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oBusinessVasDescription.vas == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oBusinessVasDescription.vas; }
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

        #region INSERT_BUSINESSVASDESCRIPTION Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2009-11-17>
        ///-- Description:	<Description,BUSINESSVASDESCRIPTION, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_BUSINESSVASDESCRIPTION Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_BUSINESSVASDESCRIPTION', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_BUSINESSVASDESCRIPTION;
        GO
        CREATE PROCEDURE INSERT_BUSINESSVASDESCRIPTION
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @fee nvarchar(50),
        @vas_desc nvarchar(50),
        @active bit,
        @vas nvarchar(50)
        AS
        
        INSERT INTO  [BusinessVasDescription]   ([active],[vas_desc],[fee],[vas])  VALUES  (@active,@vas_desc,@fee,@vas)
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
            string _sQuery = "DELETE FROM  [BusinessVasDescription]  WHERE [BusinessVasDescription].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVasDescription]", "[" + Configurator.MSSQLTablePrefix + "BusinessVasDescription]"); }
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
            return BusinessVasDescriptionRepositoryBase.DeleteAll(n_oDB);
        }

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "DELETE FROM  [BusinessVasDescription]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVasDescription]", "[" + Configurator.MSSQLTablePrefix + "BusinessVasDescription]"); }
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
            string _sQuery = "DELETE FROM [BusinessVasDescription]" + x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVasDescription]", "[" + Configurator.MSSQLTablePrefix + "BusinessVasDescription]"); }
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

