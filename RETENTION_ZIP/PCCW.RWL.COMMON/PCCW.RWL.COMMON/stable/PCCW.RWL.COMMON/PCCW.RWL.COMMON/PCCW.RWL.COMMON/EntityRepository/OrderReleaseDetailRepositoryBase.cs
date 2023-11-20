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
///-- Description:	<Description,Table :[OrderReleaseDetail],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [OrderReleaseDetail] Insert / list / delete manager layer
    /// </summary>

    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name = Configurator.MSSQLTablePrefix + "OrderReleaseDetail")]
    public class OrderReleaseDetailRepositoryBase : global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable
    {

        #region Instance
        private static OrderReleaseDetailRepositoryBase instance;
        public static OrderReleaseDetailRepositoryBase Instance()
        {
            if (instance == null)
            {
                MSSQLConnect _oDB = new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new OrderReleaseDetailRepositoryBase(_oDB);
            }
            return instance;
        }
        public static OrderReleaseDetailRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if (instance == null)
                instance = new OrderReleaseDetailRepositoryBase(x_oDB);
            return instance;
        }
        #endregion

        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<OrderReleaseDetailEntity> OrderReleaseDetails;
        #endregion

        #region Constructor
        public OrderReleaseDetailRepositoryBase(MSSQLConnect x_oDB)
            : base(x_oDB.ConnectionStr)
        {
            n_oDB = x_oDB;
        }
        ~OrderReleaseDetailRepositoryBase()
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
        public static OrderReleaseDetail CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new OrderReleaseDetail(_oDB);
        }

        public static OrderReleaseDetail CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new OrderReleaseDetail(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [OrderReleaseDetail]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[OrderReleaseDetail]", "[" + Configurator.MSSQLTablePrefix + "OrderReleaseDetail]"); }
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


        public OrderReleaseDetailEntity GetObj(global::System.Nullable<int> x_iMid)
        {
            return GetObj(n_oDB, x_iMid);
        }


        public static OrderReleaseDetailEntity GetObj(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            if (x_oDB == null) { return null; }
            OrderReleaseDetail _OrderReleaseDetail = (OrderReleaseDetail)OrderReleaseDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_OrderReleaseDetail.Load(x_iMid)) { return null; }
            return _OrderReleaseDetail;
        }



        public static OrderReleaseDetailEntity[] GetArrayObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            List<OrderReleaseDetailEntity> _oOrderReleaseDetailList = GetListObj(x_oDB, 0, "mid", x_oArrayItemId);
            return _oOrderReleaseDetailList.Count == 0 ? null : _oOrderReleaseDetailList.ToArray();
        }

        public static List<OrderReleaseDetailEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB, 0, "mid", x_oArrayItemId);
        }


        public static OrderReleaseDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<OrderReleaseDetailEntity> _oOrderReleaseDetailList = GetListObj(x_oDB, 0, x_oColumnName, x_oArrayItemId);
            return _oOrderReleaseDetailList.Count == 0 ? null : _oOrderReleaseDetailList.ToArray();
        }


        public static OrderReleaseDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<OrderReleaseDetailEntity> _oOrderReleaseDetailList = GetListObj(x_oDB, x_iTop, x_oColumnName, x_oArrayItemId);
            return _oOrderReleaseDetailList.Count == 0 ? null : _oOrderReleaseDetailList.ToArray();
        }

        public static List<OrderReleaseDetailEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB == null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            List<OrderReleaseDetailEntity> _oRow = new List<OrderReleaseDetailEntity>();
            string _sQuery = "SELECT  " + _sTop + " [OrderReleaseDetail].[active] AS ORDERRELEASEDETAIL_ACTIVE,[OrderReleaseDetail].[order_id] AS ORDERRELEASEDETAIL_ORDER_ID,[OrderReleaseDetail].[cdate] AS ORDERRELEASEDETAIL_CDATE,[OrderReleaseDetail].[cid] AS ORDERRELEASEDETAIL_CID,[OrderReleaseDetail].[did] AS ORDERRELEASEDETAIL_DID,[OrderReleaseDetail].[ddate] AS ORDERRELEASEDETAIL_DDATE,[OrderReleaseDetail].[mid] AS ORDERRELEASEDETAIL_MID  FROM  [OrderReleaseDetail]";
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
                _sQuery += " WHERE [OrderReleaseDetail].[" + x_oColumnName.ToString() + "]  in " + _oList;
            }

            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[OrderReleaseDetail]", "[" + Configurator.MSSQLTablePrefix + "OrderReleaseDetail]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        OrderReleaseDetail _oOrderReleaseDetail = OrderReleaseDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["ORDERRELEASEDETAIL_ORDER_ID"])) { _oOrderReleaseDetail.order_id = (global::System.Nullable<int>)_oData["ORDERRELEASEDETAIL_ORDER_ID"]; } else { _oOrderReleaseDetail.order_id = null; }
                        if (!global::System.Convert.IsDBNull(_oData["ORDERRELEASEDETAIL_CDATE"])) { _oOrderReleaseDetail.cdate = (global::System.Nullable<DateTime>)_oData["ORDERRELEASEDETAIL_CDATE"]; } else { _oOrderReleaseDetail.cdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["ORDERRELEASEDETAIL_CID"])) { _oOrderReleaseDetail.cid = (string)_oData["ORDERRELEASEDETAIL_CID"]; } else { _oOrderReleaseDetail.cid = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["ORDERRELEASEDETAIL_DID"])) { _oOrderReleaseDetail.did = (string)_oData["ORDERRELEASEDETAIL_DID"]; } else { _oOrderReleaseDetail.did = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["ORDERRELEASEDETAIL_MID"])) { _oOrderReleaseDetail.mid = (global::System.Nullable<int>)_oData["ORDERRELEASEDETAIL_MID"]; } else { _oOrderReleaseDetail.mid = null; }
                        if (!global::System.Convert.IsDBNull(_oData["ORDERRELEASEDETAIL_DDATE"])) { _oOrderReleaseDetail.ddate = (global::System.Nullable<DateTime>)_oData["ORDERRELEASEDETAIL_DDATE"]; } else { _oOrderReleaseDetail.ddate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["ORDERRELEASEDETAIL_ACTIVE"])) { _oOrderReleaseDetail.active = (global::System.Nullable<bool>)_oData["ORDERRELEASEDETAIL_ACTIVE"]; } else { _oOrderReleaseDetail.active = null; }
                        _oOrderReleaseDetail.SetDB(x_oDB);
                        _oOrderReleaseDetail.GetFound();
                        _oRow.Add(_oOrderReleaseDetail);
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


        public static OrderReleaseDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<OrderReleaseDetailEntity> _oOrderReleaseDetailList = GetListObj(x_oDB, 0, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oOrderReleaseDetailList.Count == 0 ? null : _oOrderReleaseDetailList.ToArray();
        }


        public static OrderReleaseDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<OrderReleaseDetailEntity> _oOrderReleaseDetailList = GetListObj(x_oDB, x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oOrderReleaseDetailList.Count == 0 ? null : _oOrderReleaseDetailList.ToArray();
        }

        public static List<OrderReleaseDetailEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB == null) { return null; }
            List<OrderReleaseDetailEntity> _oRow = new List<OrderReleaseDetailEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            string _sFields = "[OrderReleaseDetail].[active] AS ORDERRELEASEDETAIL_ACTIVE,[OrderReleaseDetail].[order_id] AS ORDERRELEASEDETAIL_ORDER_ID,[OrderReleaseDetail].[cdate] AS ORDERRELEASEDETAIL_CDATE,[OrderReleaseDetail].[cid] AS ORDERRELEASEDETAIL_CID,[OrderReleaseDetail].[did] AS ORDERRELEASEDETAIL_DID,[OrderReleaseDetail].[ddate] AS ORDERRELEASEDETAIL_DDATE,[OrderReleaseDetail].[mid] AS ORDERRELEASEDETAIL_MID";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[OrderReleaseDetail]", "[" + Configurator.MSSQLTablePrefix + "OrderReleaseDetail]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = OrderReleaseDetailRepositoryBase.GetSearch(x_oDB, _sTop.ToString() + _sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                OrderReleaseDetailEntity _oOrderReleaseDetail = OrderReleaseDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["ORDERRELEASEDETAIL_ORDER_ID"])) { _oOrderReleaseDetail.order_id = (global::System.Nullable<int>)_oData["ORDERRELEASEDETAIL_ORDER_ID"]; } else { _oOrderReleaseDetail.order_id = null; }
                if (!global::System.Convert.IsDBNull(_oData["ORDERRELEASEDETAIL_CDATE"])) { _oOrderReleaseDetail.cdate = (global::System.Nullable<DateTime>)_oData["ORDERRELEASEDETAIL_CDATE"]; } else { _oOrderReleaseDetail.cdate = null; }
                if (!global::System.Convert.IsDBNull(_oData["ORDERRELEASEDETAIL_CID"])) { _oOrderReleaseDetail.cid = (string)_oData["ORDERRELEASEDETAIL_CID"]; } else { _oOrderReleaseDetail.cid = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["ORDERRELEASEDETAIL_DID"])) { _oOrderReleaseDetail.did = (string)_oData["ORDERRELEASEDETAIL_DID"]; } else { _oOrderReleaseDetail.did = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["ORDERRELEASEDETAIL_MID"])) { _oOrderReleaseDetail.mid = (global::System.Nullable<int>)_oData["ORDERRELEASEDETAIL_MID"]; } else { _oOrderReleaseDetail.mid = null; }
                if (!global::System.Convert.IsDBNull(_oData["ORDERRELEASEDETAIL_DDATE"])) { _oOrderReleaseDetail.ddate = (global::System.Nullable<DateTime>)_oData["ORDERRELEASEDETAIL_DDATE"]; } else { _oOrderReleaseDetail.ddate = null; }
                if (!global::System.Convert.IsDBNull(_oData["ORDERRELEASEDETAIL_ACTIVE"])) { _oOrderReleaseDetail.active = (global::System.Nullable<bool>)_oData["ORDERRELEASEDETAIL_ACTIVE"]; } else { _oOrderReleaseDetail.active = null; }
                _oOrderReleaseDetail.SetDB(x_oDB);
                _oOrderReleaseDetail.GetFound();
                _oRow.Add(_oOrderReleaseDetail);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet(OrderReleaseDetail.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder, OrderReleaseDetail.Para.TableName());
            return _oDset;
        }


        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB == null) { return null; }
            return x_oDB.GetSearch(OrderReleaseDetail.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }


        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(OrderReleaseDetail.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            if (x_oDB == null) { return null; }
            string _oQuery = "SELECT   [OrderReleaseDetail].[active] AS ORDERRELEASEDETAIL_ACTIVE,[OrderReleaseDetail].[order_id] AS ORDERRELEASEDETAIL_ORDER_ID,[OrderReleaseDetail].[cdate] AS ORDERRELEASEDETAIL_CDATE,[OrderReleaseDetail].[cid] AS ORDERRELEASEDETAIL_CID,[OrderReleaseDetail].[did] AS ORDERRELEASEDETAIL_DID,[OrderReleaseDetail].[ddate] AS ORDERRELEASEDETAIL_DDATE,[OrderReleaseDetail].[mid] AS ORDERRELEASEDETAIL_MID  FROM  [OrderReleaseDetail]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[OrderReleaseDetail]", "[" + Configurator.MSSQLTablePrefix + "OrderReleaseDetail]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery, _oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset, "OrderReleaseDetail");
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

        public bool Insert(global::System.Nullable<int> x_iOrder_id, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sDid, global::System.Nullable<DateTime> x_dDdate, global::System.Nullable<bool> x_bActive)
        {
            OrderReleaseDetail _oOrderReleaseDetail = OrderReleaseDetailRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oOrderReleaseDetail.order_id = x_iOrder_id;
            _oOrderReleaseDetail.cdate = x_dCdate;
            _oOrderReleaseDetail.cid = x_sCid;
            _oOrderReleaseDetail.did = x_sDid;
            _oOrderReleaseDetail.ddate = x_dDdate;
            _oOrderReleaseDetail.active = x_bActive;
            return InsertWithOutLastID(n_oDB, _oOrderReleaseDetail);
        }


        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<int> x_iOrder_id, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sDid, global::System.Nullable<DateTime> x_dDdate, global::System.Nullable<bool> x_bActive)
        {
            OrderReleaseDetail _oOrderReleaseDetail = OrderReleaseDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oOrderReleaseDetail.order_id = x_iOrder_id;
            _oOrderReleaseDetail.cdate = x_dCdate;
            _oOrderReleaseDetail.cid = x_sCid;
            _oOrderReleaseDetail.did = x_sDid;
            _oOrderReleaseDetail.ddate = x_dDdate;
            _oOrderReleaseDetail.active = x_bActive;
            return InsertWithOutLastID(x_oDB, _oOrderReleaseDetail);
        }


        public bool Insert(OrderReleaseDetail x_oOrderReleaseDetail)
        {
            return InsertWithOutLastID(n_oDB, x_oOrderReleaseDetail);
        }


        public bool InsertEntity(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is OrderReleaseDetail)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (OrderReleaseDetail)x_oObj);
        }


        public static bool Insert(MSSQLConnect x_oDB, OrderReleaseDetail x_oOrderReleaseDetail)
        {
            return InsertWithOutLastID(x_oDB, x_oOrderReleaseDetail);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, OrderReleaseDetail x_oOrderReleaseDetail)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT INTO  [OrderReleaseDetail]   ([active],[order_id],[cdate],[cid],[did],[ddate])  VALUES  (@active,@order_id,@cdate,@cid,@did,@ddate)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[OrderReleaseDetail]", "[" + Configurator.MSSQLTablePrefix + "OrderReleaseDetail]"); }
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
            return InsertTransactionWithOutLastID(x_oDB, _oConn, _oCmd, x_oOrderReleaseDetail);
        }

        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, OrderReleaseDetail x_oOrderReleaseDetail)
        {
            bool _bResult = false;
            if (!x_oOrderReleaseDetail.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if (x_oOrderReleaseDetail.active == null) { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = x_oOrderReleaseDetail.active; }
                if (x_oOrderReleaseDetail.order_id == null) { x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = x_oOrderReleaseDetail.order_id; }
                if (x_oOrderReleaseDetail.cdate == null) { x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = x_oOrderReleaseDetail.cdate; }
                if (x_oOrderReleaseDetail.cid == null) { x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar, 10).Value = x_oOrderReleaseDetail.cid; }
                if (x_oOrderReleaseDetail.did == null) { x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar, 10).Value = x_oOrderReleaseDetail.did; }
                if (x_oOrderReleaseDetail.ddate == null) { x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = x_oOrderReleaseDetail.ddate; }
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


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, global::System.Nullable<int> x_iOrder_id, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sDid, global::System.Nullable<DateTime> x_dDdate, global::System.Nullable<bool> x_bActive)
        {
            int _oLastID;
            OrderReleaseDetail _oOrderReleaseDetail = OrderReleaseDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oOrderReleaseDetail.order_id = x_iOrder_id;
            _oOrderReleaseDetail.cdate = x_dCdate;
            _oOrderReleaseDetail.cid = x_sCid;
            _oOrderReleaseDetail.did = x_sDid;
            _oOrderReleaseDetail.ddate = x_dDdate;
            _oOrderReleaseDetail.active = x_bActive;
            if (InsertWithLastID_SP(x_oDB, _oOrderReleaseDetail, out _oLastID))
            {
                return _oLastID;
            }
            else
            {
                return -1;
            }
        }


        public int InsertReturnLastID_SP(OrderReleaseDetail x_oOrderReleaseDetail)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oOrderReleaseDetail, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, OrderReleaseDetail x_oOrderReleaseDetail)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oOrderReleaseDetail, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is OrderReleaseDetail)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (OrderReleaseDetail)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB, OrderReleaseDetail x_oOrderReleaseDetail, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "ORDERRELEASEDETAIL";
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
            return InsertTransactionWithLastID_SP(x_oDB, _oConn, _oCmd, x_oOrderReleaseDetail, out x_oLAST_ID);
        }

        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, OrderReleaseDetail x_oOrderReleaseDetail, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar = x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oOrderReleaseDetail.active == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oOrderReleaseDetail.active; }
                _oPar = x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oOrderReleaseDetail.order_id == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oOrderReleaseDetail.order_id; }
                _oPar = x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oOrderReleaseDetail.cdate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oOrderReleaseDetail.cdate; }
                _oPar = x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oOrderReleaseDetail.cid == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oOrderReleaseDetail.cid; }
                _oPar = x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oOrderReleaseDetail.did == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oOrderReleaseDetail.did; }
                _oPar = x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oOrderReleaseDetail.ddate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oOrderReleaseDetail.ddate; }
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

        #region INSERT_ORDERRELEASEDETAIL Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2009-11-17>
        ///-- Description:	<Description,ORDERRELEASEDETAIL, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_ORDERRELEASEDETAIL Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_ORDERRELEASEDETAIL', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_ORDERRELEASEDETAIL;
        GO
        CREATE PROCEDURE INSERT_ORDERRELEASEDETAIL
        	-- Add the parameters for the stored procedure here
        @RETURN_MID int output,
        @order_id int,
        @cdate datetime,
        @cid nvarchar(10),
        @did nvarchar(10),
        @ddate datetime,
        @active bit
        AS
        
        INSERT INTO  [OrderReleaseDetail]   ([active],[order_id],[cdate],[cid],[did],[ddate])  VALUES  (@active,@order_id,@cdate,@cid,@did,@ddate)
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
            string _sQuery = "DELETE FROM  [OrderReleaseDetail]  WHERE [OrderReleaseDetail].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[OrderReleaseDetail]", "[" + Configurator.MSSQLTablePrefix + "OrderReleaseDetail]"); }
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
            return OrderReleaseDetailRepositoryBase.DeleteAll(n_oDB);
        }

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "DELETE FROM  [OrderReleaseDetail]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[OrderReleaseDetail]", "[" + Configurator.MSSQLTablePrefix + "OrderReleaseDetail]"); }
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
            string _sQuery = "DELETE FROM [OrderReleaseDetail]" + x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[OrderReleaseDetail]", "[" + Configurator.MSSQLTablePrefix + "OrderReleaseDetail]"); }
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

