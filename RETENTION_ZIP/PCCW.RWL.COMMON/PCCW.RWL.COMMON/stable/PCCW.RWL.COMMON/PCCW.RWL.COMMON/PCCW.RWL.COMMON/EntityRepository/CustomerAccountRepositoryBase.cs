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
///-- Description:	<Description,Table :[CustomerAccount],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE
{
    /// <summary>
    /// Summary description for table [CustomerAccount] Insert / list / delete manager layer
    /// </summary>

    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name = Configurator.MSSQLTablePrefix + "CustomerAccount")]
    public class CustomerAccountRepositoryBase : global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable
    {

        #region Instance
        private static CustomerAccountRepositoryBase instance;
        public static CustomerAccountRepositoryBase Instance()
        {
            if (instance == null)
            {
                MSSQLConnect _oDB = new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new CustomerAccountRepositoryBase(_oDB);
            }
            return instance;
        }
        public static CustomerAccountRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if (instance == null)
                instance = new CustomerAccountRepositoryBase(x_oDB);
            return instance;
        }
        #endregion

        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<CustomerAccountEntity> CustomerAccounts;
        #endregion

        #region Constructor
        public CustomerAccountRepositoryBase(MSSQLConnect x_oDB)
            : base(x_oDB.ConnectionStr)
        {
            n_oDB = x_oDB;
        }
        ~CustomerAccountRepositoryBase()
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
        public static CustomerAccount CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new CustomerAccount(_oDB);
        }

        public static CustomerAccount CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new CustomerAccount(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [CustomerAccount]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[CustomerAccount]", "[" + Configurator.MSSQLTablePrefix + "CustomerAccount]"); }
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


        public CustomerAccountEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }


        public static CustomerAccountEntity GetObj(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            if (x_oDB == null) { return null; }
            CustomerAccount _CustomerAccount = (CustomerAccount)CustomerAccountRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_CustomerAccount.Load(x_iId)) { return null; }
            return _CustomerAccount;
        }



        public static CustomerAccountEntity[] GetArrayObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            List<CustomerAccountEntity> _oCustomerAccountList = GetListObj(x_oDB, 0, "id", x_oArrayItemId);
            return _oCustomerAccountList.Count == 0 ? null : _oCustomerAccountList.ToArray();
        }

        public static List<CustomerAccountEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB, 0, "id", x_oArrayItemId);
        }


        public static CustomerAccountEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<CustomerAccountEntity> _oCustomerAccountList = GetListObj(x_oDB, 0, x_oColumnName, x_oArrayItemId);
            return _oCustomerAccountList.Count == 0 ? null : _oCustomerAccountList.ToArray();
        }


        public static CustomerAccountEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<CustomerAccountEntity> _oCustomerAccountList = GetListObj(x_oDB, x_iTop, x_oColumnName, x_oArrayItemId);
            return _oCustomerAccountList.Count == 0 ? null : _oCustomerAccountList.ToArray();
        }

        public static List<CustomerAccountEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB == null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            List<CustomerAccountEntity> _oRow = new List<CustomerAccountEntity>();
            string _sQuery = "SELECT  " + _sTop + " [CustomerAccount].[id] AS CUSTOMERACCOUNT_ID,[CustomerAccount].[cdate] AS CUSTOMERACCOUNT_CDATE,[CustomerAccount].[cid] AS CUSTOMERACCOUNT_CID,[CustomerAccount].[mrt_no] AS CUSTOMERACCOUNT_MRT_NO,[CustomerAccount].[active] AS CUSTOMERACCOUNT_ACTIVE,[CustomerAccount].[ac_no] AS CUSTOMERACCOUNT_AC_NO,[CustomerAccount].[order_id] AS CUSTOMERACCOUNT_ORDER_ID,[CustomerAccount].[did] AS CUSTOMERACCOUNT_DID,[CustomerAccount].[ddate] AS CUSTOMERACCOUNT_DDATE,[CustomerAccount].[remarks] AS CUSTOMERACCOUNT_REMARKS  FROM  [CustomerAccount]";
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
                _sQuery += " WHERE [CustomerAccount].[" + x_oColumnName.ToString() + "]  in " + _oList;
            }

            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[CustomerAccount]", "[" + Configurator.MSSQLTablePrefix + "CustomerAccount]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        CustomerAccount _oCustomerAccount = CustomerAccountRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_REMARKS"])) { _oCustomerAccount.remarks = (string)_oData["CUSTOMERACCOUNT_REMARKS"]; } else { _oCustomerAccount.remarks = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_ID"])) { _oCustomerAccount.id = (global::System.Nullable<int>)_oData["CUSTOMERACCOUNT_ID"]; } else { _oCustomerAccount.id = null; }
                        if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_CDATE"])) { _oCustomerAccount.cdate = (global::System.Nullable<DateTime>)_oData["CUSTOMERACCOUNT_CDATE"]; } else { _oCustomerAccount.cdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_CID"])) { _oCustomerAccount.cid = (string)_oData["CUSTOMERACCOUNT_CID"]; } else { _oCustomerAccount.cid = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_MRT_NO"])) { _oCustomerAccount.mrt_no = (string)_oData["CUSTOMERACCOUNT_MRT_NO"]; } else { _oCustomerAccount.mrt_no = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_ACTIVE"])) { _oCustomerAccount.active = (string)_oData["CUSTOMERACCOUNT_ACTIVE"]; } else { _oCustomerAccount.active = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_AC_NO"])) { _oCustomerAccount.ac_no = (string)_oData["CUSTOMERACCOUNT_AC_NO"]; } else { _oCustomerAccount.ac_no = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_ORDER_ID"])) { _oCustomerAccount.order_id = (global::System.Nullable<int>)_oData["CUSTOMERACCOUNT_ORDER_ID"]; } else { _oCustomerAccount.order_id = null; }
                        if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_DDATE"])) { _oCustomerAccount.ddate = (global::System.Nullable<DateTime>)_oData["CUSTOMERACCOUNT_DDATE"]; } else { _oCustomerAccount.ddate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_DID"])) { _oCustomerAccount.did = (string)_oData["CUSTOMERACCOUNT_DID"]; } else { _oCustomerAccount.did = global::System.String.Empty; }
                        _oCustomerAccount.SetDB(x_oDB);
                        _oCustomerAccount.GetFound();
                        _oRow.Add(_oCustomerAccount);
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


        public static CustomerAccountEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<CustomerAccountEntity> _oCustomerAccountList = GetListObj(x_oDB, 0, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oCustomerAccountList.Count == 0 ? null : _oCustomerAccountList.ToArray();
        }


        public static CustomerAccountEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<CustomerAccountEntity> _oCustomerAccountList = GetListObj(x_oDB, x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oCustomerAccountList.Count == 0 ? null : _oCustomerAccountList.ToArray();
        }

        public static List<CustomerAccountEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB == null) { return null; }
            List<CustomerAccountEntity> _oRow = new List<CustomerAccountEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            string _sFields = "[CustomerAccount].[id] AS CUSTOMERACCOUNT_ID,[CustomerAccount].[cdate] AS CUSTOMERACCOUNT_CDATE,[CustomerAccount].[cid] AS CUSTOMERACCOUNT_CID,[CustomerAccount].[mrt_no] AS CUSTOMERACCOUNT_MRT_NO,[CustomerAccount].[active] AS CUSTOMERACCOUNT_ACTIVE,[CustomerAccount].[ac_no] AS CUSTOMERACCOUNT_AC_NO,[CustomerAccount].[order_id] AS CUSTOMERACCOUNT_ORDER_ID,[CustomerAccount].[did] AS CUSTOMERACCOUNT_DID,[CustomerAccount].[ddate] AS CUSTOMERACCOUNT_DDATE,[CustomerAccount].[remarks] AS CUSTOMERACCOUNT_REMARKS";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[CustomerAccount]", "[" + Configurator.MSSQLTablePrefix + "CustomerAccount]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = CustomerAccountRepositoryBase.GetSearch(x_oDB, _sTop.ToString() + _sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                CustomerAccountEntity _oCustomerAccount = CustomerAccountRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_REMARKS"])) { _oCustomerAccount.remarks = (string)_oData["CUSTOMERACCOUNT_REMARKS"]; } else { _oCustomerAccount.remarks = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_ID"])) { _oCustomerAccount.id = (global::System.Nullable<int>)_oData["CUSTOMERACCOUNT_ID"]; } else { _oCustomerAccount.id = null; }
                if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_CDATE"])) { _oCustomerAccount.cdate = (global::System.Nullable<DateTime>)_oData["CUSTOMERACCOUNT_CDATE"]; } else { _oCustomerAccount.cdate = null; }
                if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_CID"])) { _oCustomerAccount.cid = (string)_oData["CUSTOMERACCOUNT_CID"]; } else { _oCustomerAccount.cid = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_MRT_NO"])) { _oCustomerAccount.mrt_no = (string)_oData["CUSTOMERACCOUNT_MRT_NO"]; } else { _oCustomerAccount.mrt_no = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_ACTIVE"])) { _oCustomerAccount.active = (string)_oData["CUSTOMERACCOUNT_ACTIVE"]; } else { _oCustomerAccount.active = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_AC_NO"])) { _oCustomerAccount.ac_no = (string)_oData["CUSTOMERACCOUNT_AC_NO"]; } else { _oCustomerAccount.ac_no = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_ORDER_ID"])) { _oCustomerAccount.order_id = (global::System.Nullable<int>)_oData["CUSTOMERACCOUNT_ORDER_ID"]; } else { _oCustomerAccount.order_id = null; }
                if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_DDATE"])) { _oCustomerAccount.ddate = (global::System.Nullable<DateTime>)_oData["CUSTOMERACCOUNT_DDATE"]; } else { _oCustomerAccount.ddate = null; }
                if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_DID"])) { _oCustomerAccount.did = (string)_oData["CUSTOMERACCOUNT_DID"]; } else { _oCustomerAccount.did = global::System.String.Empty; }
                _oCustomerAccount.SetDB(x_oDB);
                _oCustomerAccount.GetFound();
                _oRow.Add(_oCustomerAccount);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet(CustomerAccount.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder, CustomerAccount.Para.TableName());
            return _oDset;
        }


        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB == null) { return null; }
            return x_oDB.GetSearch(CustomerAccount.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }


        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(CustomerAccount.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            if (x_oDB == null) { return null; }
            string _oQuery = "SELECT   [CustomerAccount].[id] AS CUSTOMERACCOUNT_ID,[CustomerAccount].[cdate] AS CUSTOMERACCOUNT_CDATE,[CustomerAccount].[cid] AS CUSTOMERACCOUNT_CID,[CustomerAccount].[mrt_no] AS CUSTOMERACCOUNT_MRT_NO,[CustomerAccount].[active] AS CUSTOMERACCOUNT_ACTIVE,[CustomerAccount].[ac_no] AS CUSTOMERACCOUNT_AC_NO,[CustomerAccount].[order_id] AS CUSTOMERACCOUNT_ORDER_ID,[CustomerAccount].[did] AS CUSTOMERACCOUNT_DID,[CustomerAccount].[ddate] AS CUSTOMERACCOUNT_DDATE,[CustomerAccount].[remarks] AS CUSTOMERACCOUNT_REMARKS  FROM  [CustomerAccount]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[CustomerAccount]", "[" + Configurator.MSSQLTablePrefix + "CustomerAccount]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery, _oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset, "CustomerAccount");
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

        public bool Insert(string x_sRemarks, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sMrt_no, string x_sActive, string x_sAc_no, global::System.Nullable<int> x_iOrder_id, global::System.Nullable<DateTime> x_dDdate, string x_sDid)
        {
            CustomerAccount _oCustomerAccount = CustomerAccountRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oCustomerAccount.remarks = x_sRemarks;
            _oCustomerAccount.cdate = x_dCdate;
            _oCustomerAccount.cid = x_sCid;
            _oCustomerAccount.mrt_no = x_sMrt_no;
            _oCustomerAccount.active = x_sActive;
            _oCustomerAccount.ac_no = x_sAc_no;
            _oCustomerAccount.order_id = x_iOrder_id;
            _oCustomerAccount.ddate = x_dDdate;
            _oCustomerAccount.did = x_sDid;
            return InsertWithOutLastID(n_oDB, _oCustomerAccount);
        }


        public static bool Insert(MSSQLConnect x_oDB, string x_sRemarks, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sMrt_no, string x_sActive, string x_sAc_no, global::System.Nullable<int> x_iOrder_id, global::System.Nullable<DateTime> x_dDdate, string x_sDid)
        {
            CustomerAccount _oCustomerAccount = CustomerAccountRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oCustomerAccount.remarks = x_sRemarks;
            _oCustomerAccount.cdate = x_dCdate;
            _oCustomerAccount.cid = x_sCid;
            _oCustomerAccount.mrt_no = x_sMrt_no;
            _oCustomerAccount.active = x_sActive;
            _oCustomerAccount.ac_no = x_sAc_no;
            _oCustomerAccount.order_id = x_iOrder_id;
            _oCustomerAccount.ddate = x_dDdate;
            _oCustomerAccount.did = x_sDid;
            return InsertWithOutLastID(x_oDB, _oCustomerAccount);
        }


        public bool Insert(CustomerAccount x_oCustomerAccount)
        {
            return InsertWithOutLastID(n_oDB, x_oCustomerAccount);
        }


        public bool InsertEntity(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is CustomerAccount)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (CustomerAccount)x_oObj);
        }


        public static bool Insert(MSSQLConnect x_oDB, CustomerAccount x_oCustomerAccount)
        {
            return InsertWithOutLastID(x_oDB, x_oCustomerAccount);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, CustomerAccount x_oCustomerAccount)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT INTO  [CustomerAccount]   ([cdate],[cid],[mrt_no],[active],[ac_no],[order_id],[did],[ddate],[remarks])  VALUES  (@cdate,@cid,@mrt_no,@active,@ac_no,@order_id,@did,@ddate,@remarks)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[CustomerAccount]", "[" + Configurator.MSSQLTablePrefix + "CustomerAccount]"); }
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
            return InsertTransactionWithOutLastID(x_oDB, _oConn, _oCmd, x_oCustomerAccount);
        }

        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, CustomerAccount x_oCustomerAccount)
        {
            bool _bResult = false;
            if (!x_oCustomerAccount.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if (x_oCustomerAccount.cdate == null) { x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = x_oCustomerAccount.cdate; }
                if (x_oCustomerAccount.cid == null) { x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10).Value = x_oCustomerAccount.cid; }
                if (x_oCustomerAccount.mrt_no == null) { x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.Char, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.Char, 10).Value = x_oCustomerAccount.mrt_no; }
                if (x_oCustomerAccount.active == null) { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Char, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Char, 10).Value = x_oCustomerAccount.active; }
                if (x_oCustomerAccount.ac_no == null) { x_oCmd.Parameters.Add("@ac_no", global::System.Data.SqlDbType.Char, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@ac_no", global::System.Data.SqlDbType.Char, 10).Value = x_oCustomerAccount.ac_no; }
                if (x_oCustomerAccount.order_id == null) { x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = x_oCustomerAccount.order_id; }
                if (x_oCustomerAccount.did == null) { x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10).Value = x_oCustomerAccount.did; }
                if (x_oCustomerAccount.ddate == null) { x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = x_oCustomerAccount.ddate; }
                if (x_oCustomerAccount.remarks == null) { x_oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.Text).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.Text).Value = x_oCustomerAccount.remarks; }
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


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, string x_sRemarks, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sMrt_no, string x_sActive, string x_sAc_no, global::System.Nullable<int> x_iOrder_id, global::System.Nullable<DateTime> x_dDdate, string x_sDid)
        {
            int _oLastID;
            CustomerAccount _oCustomerAccount = CustomerAccountRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oCustomerAccount.remarks = x_sRemarks;
            _oCustomerAccount.cdate = x_dCdate;
            _oCustomerAccount.cid = x_sCid;
            _oCustomerAccount.mrt_no = x_sMrt_no;
            _oCustomerAccount.active = x_sActive;
            _oCustomerAccount.ac_no = x_sAc_no;
            _oCustomerAccount.order_id = x_iOrder_id;
            _oCustomerAccount.ddate = x_dDdate;
            _oCustomerAccount.did = x_sDid;
            if (InsertWithLastID_SP(x_oDB, _oCustomerAccount, out _oLastID))
            {
                return _oLastID;
            }
            else
            {
                return -1;
            }
        }


        public int InsertReturnLastID_SP(CustomerAccount x_oCustomerAccount)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oCustomerAccount, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, CustomerAccount x_oCustomerAccount)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oCustomerAccount, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is CustomerAccount)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (CustomerAccount)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB, CustomerAccount x_oCustomerAccount, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "CUSTOMERACCOUNT";
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
            return InsertTransactionWithLastID_SP(x_oDB, _oConn, _oCmd, x_oCustomerAccount, out x_oLAST_ID);
        }

        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, CustomerAccount x_oCustomerAccount, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar = x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oCustomerAccount.cdate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oCustomerAccount.cdate; }
                _oPar = x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oCustomerAccount.cid == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oCustomerAccount.cid; }
                _oPar = x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.Char, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oCustomerAccount.mrt_no == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oCustomerAccount.mrt_no; }
                _oPar = x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Char, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oCustomerAccount.active == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oCustomerAccount.active; }
                _oPar = x_oCmd.Parameters.Add("@ac_no", global::System.Data.SqlDbType.Char, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oCustomerAccount.ac_no == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oCustomerAccount.ac_no; }
                _oPar = x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oCustomerAccount.order_id == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oCustomerAccount.order_id; }
                _oPar = x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oCustomerAccount.did == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oCustomerAccount.did; }
                _oPar = x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oCustomerAccount.ddate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oCustomerAccount.ddate; }
                _oPar = x_oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.Text);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oCustomerAccount.remarks == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oCustomerAccount.remarks; }
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

        #region INSERT_CUSTOMERACCOUNT Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2009-11-17>
        ///-- Description:	<Description,CUSTOMERACCOUNT, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_CUSTOMERACCOUNT Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_CUSTOMERACCOUNT', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_CUSTOMERACCOUNT;
        GO
        CREATE PROCEDURE INSERT_CUSTOMERACCOUNT
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @remarks text,
        @cdate datetime,
        @cid char(10),
        @mrt_no char(10),
        @active char(10),
        @ac_no char(10),
        @order_id int,
        @ddate datetime,
        @did char(10)
        AS
        
        INSERT INTO  [CustomerAccount]   ([cdate],[cid],[mrt_no],[active],[ac_no],[order_id],[did],[ddate],[remarks])  VALUES  (@cdate,@cid,@mrt_no,@active,@ac_no,@order_id,@did,@ddate,@remarks)
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
            string _sQuery = "DELETE FROM  [CustomerAccount]  WHERE [CustomerAccount].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[CustomerAccount]", "[" + Configurator.MSSQLTablePrefix + "CustomerAccount]"); }
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
            return CustomerAccountRepositoryBase.DeleteAll(n_oDB);
        }

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "DELETE FROM  [CustomerAccount]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[CustomerAccount]", "[" + Configurator.MSSQLTablePrefix + "CustomerAccount]"); }
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
            string _sQuery = "DELETE FROM [CustomerAccount]" + x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[CustomerAccount]", "[" + Configurator.MSSQLTablePrefix + "CustomerAccount]"); }
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

