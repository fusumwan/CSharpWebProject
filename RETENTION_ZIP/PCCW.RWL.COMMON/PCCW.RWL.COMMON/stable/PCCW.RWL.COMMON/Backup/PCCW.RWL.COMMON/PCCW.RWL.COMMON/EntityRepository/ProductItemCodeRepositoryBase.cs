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
///-- Description:	<Description,Table :[ProductItemCode],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [ProductItemCode] Insert / list / delete manager layer
    /// </summary>

    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name = Configurator.MSSQLTablePrefix + "ProductItemCode")]
    public class ProductItemCodeRepositoryBase : global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable
    {

        #region Instance
        private static ProductItemCodeRepositoryBase instance;
        public static ProductItemCodeRepositoryBase Instance()
        {
            if (instance == null)
            {
                MSSQLConnect _oDB = new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new ProductItemCodeRepositoryBase(_oDB);
            }
            return instance;
        }
        public static ProductItemCodeRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if (instance == null)
                instance = new ProductItemCodeRepositoryBase(x_oDB);
            return instance;
        }
        #endregion

        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<ProductItemCodeEntity> ProductItemCodes;
        #endregion

        #region Constructor
        public ProductItemCodeRepositoryBase(MSSQLConnect x_oDB)
            : base(x_oDB.ConnectionStr)
        {
            n_oDB = x_oDB;
        }
        ~ProductItemCodeRepositoryBase()
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
        public static ProductItemCode CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new ProductItemCode(_oDB);
        }

        public static ProductItemCode CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new ProductItemCode(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [ProductItemCode]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProductItemCode]", "[" + Configurator.MSSQLTablePrefix + "ProductItemCode]"); }
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


        public ProductItemCodeEntity GetObj(global::System.Nullable<int> x_iMid)
        {
            return GetObj(n_oDB, x_iMid);
        }


        public static ProductItemCodeEntity GetObj(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            if (x_oDB == null) { return null; }
            ProductItemCode _ProductItemCode = (ProductItemCode)ProductItemCodeRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_ProductItemCode.Load(x_iMid)) { return null; }
            return _ProductItemCode;
        }



        public static ProductItemCodeEntity[] GetArrayObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            List<ProductItemCodeEntity> _oProductItemCodeList = GetListObj(x_oDB, 0, "mid", x_oArrayItemId);
            return _oProductItemCodeList.Count == 0 ? null : _oProductItemCodeList.ToArray();
        }

        public static List<ProductItemCodeEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB, 0, "mid", x_oArrayItemId);
        }


        public static ProductItemCodeEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<ProductItemCodeEntity> _oProductItemCodeList = GetListObj(x_oDB, 0, x_oColumnName, x_oArrayItemId);
            return _oProductItemCodeList.Count == 0 ? null : _oProductItemCodeList.ToArray();
        }


        public static ProductItemCodeEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<ProductItemCodeEntity> _oProductItemCodeList = GetListObj(x_oDB, x_iTop, x_oColumnName, x_oArrayItemId);
            return _oProductItemCodeList.Count == 0 ? null : _oProductItemCodeList.ToArray();
        }

        public static List<ProductItemCodeEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB == null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            List<ProductItemCodeEntity> _oRow = new List<ProductItemCodeEntity>();
            string _sQuery = "SELECT  " + _sTop + " [ProductItemCode].[cid] AS PRODUCTITEMCODE_CID,[ProductItemCode].[active] AS PRODUCTITEMCODE_ACTIVE,[ProductItemCode].[cdate] AS PRODUCTITEMCODE_CDATE,[ProductItemCode].[hs_model] AS PRODUCTITEMCODE_HS_MODEL,[ProductItemCode].[did] AS PRODUCTITEMCODE_DID,[ProductItemCode].[type] AS PRODUCTITEMCODE_TYPE,[ProductItemCode].[last_stock] AS PRODUCTITEMCODE_LAST_STOCK,[ProductItemCode].[item_code] AS PRODUCTITEMCODE_ITEM_CODE,[ProductItemCode].[edate] AS PRODUCTITEMCODE_EDATE,[ProductItemCode].[ddate] AS PRODUCTITEMCODE_DDATE,[ProductItemCode].[mid] AS PRODUCTITEMCODE_MID,[ProductItemCode].[sdate] AS PRODUCTITEMCODE_SDATE,[ProductItemCode].[quota] AS PRODUCTITEMCODE_QUOTA  FROM  [ProductItemCode]";
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
                _sQuery += " WHERE [ProductItemCode].[" + x_oColumnName.ToString() + "]  in " + _oList;
            }

            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProductItemCode]", "[" + Configurator.MSSQLTablePrefix + "ProductItemCode]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        ProductItemCode _oProductItemCode = ProductItemCodeRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_ACTIVE"])) { _oProductItemCode.active = (global::System.Nullable<bool>)_oData["PRODUCTITEMCODE_ACTIVE"]; } else { _oProductItemCode.active = null; }
                        if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_CDATE"])) { _oProductItemCode.cdate = (global::System.Nullable<DateTime>)_oData["PRODUCTITEMCODE_CDATE"]; } else { _oProductItemCode.cdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_CID"])) { _oProductItemCode.cid = (string)_oData["PRODUCTITEMCODE_CID"]; } else { _oProductItemCode.cid = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_DID"])) { _oProductItemCode.did = (string)_oData["PRODUCTITEMCODE_DID"]; } else { _oProductItemCode.did = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_TYPE"])) { _oProductItemCode.type = (string)_oData["PRODUCTITEMCODE_TYPE"]; } else { _oProductItemCode.type = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_HS_MODEL"])) { _oProductItemCode.hs_model = (string)_oData["PRODUCTITEMCODE_HS_MODEL"]; } else { _oProductItemCode.hs_model = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_LAST_STOCK"])) { _oProductItemCode.last_stock = (global::System.Nullable<bool>)_oData["PRODUCTITEMCODE_LAST_STOCK"]; } else { _oProductItemCode.last_stock = null; }
                        if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_ITEM_CODE"])) { _oProductItemCode.item_code = (string)_oData["PRODUCTITEMCODE_ITEM_CODE"]; } else { _oProductItemCode.item_code = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_EDATE"])) { _oProductItemCode.edate = (global::System.Nullable<DateTime>)_oData["PRODUCTITEMCODE_EDATE"]; } else { _oProductItemCode.edate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_DDATE"])) { _oProductItemCode.ddate = (global::System.Nullable<DateTime>)_oData["PRODUCTITEMCODE_DDATE"]; } else { _oProductItemCode.ddate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_MID"])) { _oProductItemCode.mid = (global::System.Nullable<int>)_oData["PRODUCTITEMCODE_MID"]; } else { _oProductItemCode.mid = null; }
                        if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_SDATE"])) { _oProductItemCode.sdate = (global::System.Nullable<DateTime>)_oData["PRODUCTITEMCODE_SDATE"]; } else { _oProductItemCode.sdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_QUOTA"])) { _oProductItemCode.quota = (string)_oData["PRODUCTITEMCODE_QUOTA"]; } else { _oProductItemCode.quota = global::System.String.Empty; }
                        _oProductItemCode.SetDB(x_oDB);
                        _oProductItemCode.GetFound();
                        _oRow.Add(_oProductItemCode);
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


        public static ProductItemCodeEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<ProductItemCodeEntity> _oProductItemCodeList = GetListObj(x_oDB, 0, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oProductItemCodeList.Count == 0 ? null : _oProductItemCodeList.ToArray();
        }


        public static ProductItemCodeEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<ProductItemCodeEntity> _oProductItemCodeList = GetListObj(x_oDB, x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oProductItemCodeList.Count == 0 ? null : _oProductItemCodeList.ToArray();
        }

        public static List<ProductItemCodeEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB == null) { return null; }
            List<ProductItemCodeEntity> _oRow = new List<ProductItemCodeEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            string _sFields = "[ProductItemCode].[cid] AS PRODUCTITEMCODE_CID,[ProductItemCode].[active] AS PRODUCTITEMCODE_ACTIVE,[ProductItemCode].[cdate] AS PRODUCTITEMCODE_CDATE,[ProductItemCode].[hs_model] AS PRODUCTITEMCODE_HS_MODEL,[ProductItemCode].[did] AS PRODUCTITEMCODE_DID,[ProductItemCode].[type] AS PRODUCTITEMCODE_TYPE,[ProductItemCode].[last_stock] AS PRODUCTITEMCODE_LAST_STOCK,[ProductItemCode].[item_code] AS PRODUCTITEMCODE_ITEM_CODE,[ProductItemCode].[edate] AS PRODUCTITEMCODE_EDATE,[ProductItemCode].[ddate] AS PRODUCTITEMCODE_DDATE,[ProductItemCode].[mid] AS PRODUCTITEMCODE_MID,[ProductItemCode].[sdate] AS PRODUCTITEMCODE_SDATE,[ProductItemCode].[quota] AS PRODUCTITEMCODE_QUOTA";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[ProductItemCode]", "[" + Configurator.MSSQLTablePrefix + "ProductItemCode]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = ProductItemCodeRepositoryBase.GetSearch(x_oDB, _sTop.ToString() + _sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                ProductItemCodeEntity _oProductItemCode = ProductItemCodeRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_ACTIVE"])) { _oProductItemCode.active = (global::System.Nullable<bool>)_oData["PRODUCTITEMCODE_ACTIVE"]; } else { _oProductItemCode.active = null; }
                if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_CDATE"])) { _oProductItemCode.cdate = (global::System.Nullable<DateTime>)_oData["PRODUCTITEMCODE_CDATE"]; } else { _oProductItemCode.cdate = null; }
                if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_CID"])) { _oProductItemCode.cid = (string)_oData["PRODUCTITEMCODE_CID"]; } else { _oProductItemCode.cid = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_DID"])) { _oProductItemCode.did = (string)_oData["PRODUCTITEMCODE_DID"]; } else { _oProductItemCode.did = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_TYPE"])) { _oProductItemCode.type = (string)_oData["PRODUCTITEMCODE_TYPE"]; } else { _oProductItemCode.type = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_HS_MODEL"])) { _oProductItemCode.hs_model = (string)_oData["PRODUCTITEMCODE_HS_MODEL"]; } else { _oProductItemCode.hs_model = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_LAST_STOCK"])) { _oProductItemCode.last_stock = (global::System.Nullable<bool>)_oData["PRODUCTITEMCODE_LAST_STOCK"]; } else { _oProductItemCode.last_stock = null; }
                if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_ITEM_CODE"])) { _oProductItemCode.item_code = (string)_oData["PRODUCTITEMCODE_ITEM_CODE"]; } else { _oProductItemCode.item_code = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_EDATE"])) { _oProductItemCode.edate = (global::System.Nullable<DateTime>)_oData["PRODUCTITEMCODE_EDATE"]; } else { _oProductItemCode.edate = null; }
                if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_DDATE"])) { _oProductItemCode.ddate = (global::System.Nullable<DateTime>)_oData["PRODUCTITEMCODE_DDATE"]; } else { _oProductItemCode.ddate = null; }
                if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_MID"])) { _oProductItemCode.mid = (global::System.Nullable<int>)_oData["PRODUCTITEMCODE_MID"]; } else { _oProductItemCode.mid = null; }
                if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_SDATE"])) { _oProductItemCode.sdate = (global::System.Nullable<DateTime>)_oData["PRODUCTITEMCODE_SDATE"]; } else { _oProductItemCode.sdate = null; }
                if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_QUOTA"])) { _oProductItemCode.quota = (string)_oData["PRODUCTITEMCODE_QUOTA"]; } else { _oProductItemCode.quota = global::System.String.Empty; }
                _oProductItemCode.SetDB(x_oDB);
                _oProductItemCode.GetFound();
                _oRow.Add(_oProductItemCode);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet(ProductItemCode.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder, ProductItemCode.Para.TableName());
            return _oDset;
        }


        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB == null) { return null; }
            return x_oDB.GetSearch(ProductItemCode.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }


        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(ProductItemCode.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            if (x_oDB == null) { return null; }
            string _oQuery = "SELECT   [ProductItemCode].[cid] AS PRODUCTITEMCODE_CID,[ProductItemCode].[active] AS PRODUCTITEMCODE_ACTIVE,[ProductItemCode].[cdate] AS PRODUCTITEMCODE_CDATE,[ProductItemCode].[hs_model] AS PRODUCTITEMCODE_HS_MODEL,[ProductItemCode].[did] AS PRODUCTITEMCODE_DID,[ProductItemCode].[type] AS PRODUCTITEMCODE_TYPE,[ProductItemCode].[last_stock] AS PRODUCTITEMCODE_LAST_STOCK,[ProductItemCode].[item_code] AS PRODUCTITEMCODE_ITEM_CODE,[ProductItemCode].[edate] AS PRODUCTITEMCODE_EDATE,[ProductItemCode].[ddate] AS PRODUCTITEMCODE_DDATE,[ProductItemCode].[mid] AS PRODUCTITEMCODE_MID,[ProductItemCode].[sdate] AS PRODUCTITEMCODE_SDATE,[ProductItemCode].[quota] AS PRODUCTITEMCODE_QUOTA  FROM  [ProductItemCode]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[ProductItemCode]", "[" + Configurator.MSSQLTablePrefix + "ProductItemCode]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery, _oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset, "ProductItemCode");
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

        public bool Insert(global::System.Nullable<bool> x_bActive, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sDid, string x_sType, string x_sHs_model, global::System.Nullable<bool> x_bLast_stock, string x_sItem_code, global::System.Nullable<DateTime> x_dEdate, global::System.Nullable<DateTime> x_dDdate, global::System.Nullable<DateTime> x_dSdate, string x_sQuota)
        {
            ProductItemCode _oProductItemCode = ProductItemCodeRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oProductItemCode.active = x_bActive;
            _oProductItemCode.cdate = x_dCdate;
            _oProductItemCode.cid = x_sCid;
            _oProductItemCode.did = x_sDid;
            _oProductItemCode.type = x_sType;
            _oProductItemCode.hs_model = x_sHs_model;
            _oProductItemCode.last_stock = x_bLast_stock;
            _oProductItemCode.item_code = x_sItem_code;
            _oProductItemCode.edate = x_dEdate;
            _oProductItemCode.ddate = x_dDdate;
            _oProductItemCode.sdate = x_dSdate;
            _oProductItemCode.quota = x_sQuota;
            return InsertWithOutLastID(n_oDB, _oProductItemCode);
        }


        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bActive, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sDid, string x_sType, string x_sHs_model, global::System.Nullable<bool> x_bLast_stock, string x_sItem_code, global::System.Nullable<DateTime> x_dEdate, global::System.Nullable<DateTime> x_dDdate, global::System.Nullable<DateTime> x_dSdate, string x_sQuota)
        {
            ProductItemCode _oProductItemCode = ProductItemCodeRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oProductItemCode.active = x_bActive;
            _oProductItemCode.cdate = x_dCdate;
            _oProductItemCode.cid = x_sCid;
            _oProductItemCode.did = x_sDid;
            _oProductItemCode.type = x_sType;
            _oProductItemCode.hs_model = x_sHs_model;
            _oProductItemCode.last_stock = x_bLast_stock;
            _oProductItemCode.item_code = x_sItem_code;
            _oProductItemCode.edate = x_dEdate;
            _oProductItemCode.ddate = x_dDdate;
            _oProductItemCode.sdate = x_dSdate;
            _oProductItemCode.quota = x_sQuota;
            return InsertWithOutLastID(x_oDB, _oProductItemCode);
        }


        public bool Insert(ProductItemCode x_oProductItemCode)
        {
            return InsertWithOutLastID(n_oDB, x_oProductItemCode);
        }


        public bool InsertEntity(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is ProductItemCode)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (ProductItemCode)x_oObj);
        }


        public static bool Insert(MSSQLConnect x_oDB, ProductItemCode x_oProductItemCode)
        {
            return InsertWithOutLastID(x_oDB, x_oProductItemCode);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, ProductItemCode x_oProductItemCode)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT INTO  [ProductItemCode]   ([cid],[active],[cdate],[hs_model],[did],[type],[last_stock],[item_code],[edate],[ddate],[sdate],[quota])  VALUES  (@cid,@active,@cdate,@hs_model,@did,@type,@last_stock,@item_code,@edate,@ddate,@sdate,@quota)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProductItemCode]", "[" + Configurator.MSSQLTablePrefix + "ProductItemCode]"); }
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
            return InsertTransactionWithOutLastID(x_oDB, _oConn, _oCmd, x_oProductItemCode);
        }

        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, ProductItemCode x_oProductItemCode)
        {
            bool _bResult = false;
            if (!x_oProductItemCode.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if (x_oProductItemCode.cid == null) { x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10).Value = x_oProductItemCode.cid; }
                if (x_oProductItemCode.active == null) { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = x_oProductItemCode.active; }
                if (x_oProductItemCode.cdate == null) { x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = x_oProductItemCode.cdate; }
                if (x_oProductItemCode.hs_model == null) { x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar, 100).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar, 100).Value = x_oProductItemCode.hs_model; }
                if (x_oProductItemCode.did == null) { x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10).Value = x_oProductItemCode.did; }
                if (x_oProductItemCode.type == null) { x_oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar, 10).Value = x_oProductItemCode.type; }
                if (x_oProductItemCode.last_stock == null) { x_oCmd.Parameters.Add("@last_stock", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@last_stock", global::System.Data.SqlDbType.Bit).Value = x_oProductItemCode.last_stock; }
                if (x_oProductItemCode.item_code == null) { x_oCmd.Parameters.Add("@item_code", global::System.Data.SqlDbType.NVarChar, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@item_code", global::System.Data.SqlDbType.NVarChar, 10).Value = x_oProductItemCode.item_code; }
                if (x_oProductItemCode.edate == null) { x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = x_oProductItemCode.edate; }
                if (x_oProductItemCode.ddate == null) { x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = x_oProductItemCode.ddate; }
                if (x_oProductItemCode.sdate == null) { x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = x_oProductItemCode.sdate; }
                if (x_oProductItemCode.quota == null) { x_oCmd.Parameters.Add("@quota", global::System.Data.SqlDbType.Char, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@quota", global::System.Data.SqlDbType.Char, 10).Value = x_oProductItemCode.quota; }
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


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bActive, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sDid, string x_sType, string x_sHs_model, global::System.Nullable<bool> x_bLast_stock, string x_sItem_code, global::System.Nullable<DateTime> x_dEdate, global::System.Nullable<DateTime> x_dDdate, global::System.Nullable<DateTime> x_dSdate, string x_sQuota)
        {
            int _oLastID;
            ProductItemCode _oProductItemCode = ProductItemCodeRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oProductItemCode.active = x_bActive;
            _oProductItemCode.cdate = x_dCdate;
            _oProductItemCode.cid = x_sCid;
            _oProductItemCode.did = x_sDid;
            _oProductItemCode.type = x_sType;
            _oProductItemCode.hs_model = x_sHs_model;
            _oProductItemCode.last_stock = x_bLast_stock;
            _oProductItemCode.item_code = x_sItem_code;
            _oProductItemCode.edate = x_dEdate;
            _oProductItemCode.ddate = x_dDdate;
            _oProductItemCode.sdate = x_dSdate;
            _oProductItemCode.quota = x_sQuota;
            if (InsertWithLastID_SP(x_oDB, _oProductItemCode, out _oLastID))
            {
                return _oLastID;
            }
            else
            {
                return -1;
            }
        }


        public int InsertReturnLastID_SP(ProductItemCode x_oProductItemCode)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oProductItemCode, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, ProductItemCode x_oProductItemCode)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oProductItemCode, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is ProductItemCode)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (ProductItemCode)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB, ProductItemCode x_oProductItemCode, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "PRODUCTITEMCODE";
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
            return InsertTransactionWithLastID_SP(x_oDB, _oConn, _oCmd, x_oProductItemCode, out x_oLAST_ID);
        }

        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, ProductItemCode x_oProductItemCode, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar = x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oProductItemCode.cid == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oProductItemCode.cid; }
                _oPar = x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oProductItemCode.active == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oProductItemCode.active; }
                _oPar = x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oProductItemCode.cdate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oProductItemCode.cdate; }
                _oPar = x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar, 100);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oProductItemCode.hs_model == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oProductItemCode.hs_model; }
                _oPar = x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oProductItemCode.did == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oProductItemCode.did; }
                _oPar = x_oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oProductItemCode.type == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oProductItemCode.type; }
                _oPar = x_oCmd.Parameters.Add("@last_stock", global::System.Data.SqlDbType.Bit);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oProductItemCode.last_stock == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oProductItemCode.last_stock; }
                _oPar = x_oCmd.Parameters.Add("@item_code", global::System.Data.SqlDbType.NVarChar, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oProductItemCode.item_code == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oProductItemCode.item_code; }
                _oPar = x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oProductItemCode.edate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oProductItemCode.edate; }
                _oPar = x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oProductItemCode.ddate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oProductItemCode.ddate; }
                _oPar = x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oProductItemCode.sdate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oProductItemCode.sdate; }
                _oPar = x_oCmd.Parameters.Add("@quota", global::System.Data.SqlDbType.Char, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oProductItemCode.quota == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oProductItemCode.quota; }
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

        #region INSERT_PRODUCTITEMCODE Store Procedures
        ///-- =============================================
        ///-- Author:		<Author,Philip SW>
        ///-- Create date: <Create Date 2009-11-17>
        ///-- Description:	<Description,PRODUCTITEMCODE, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_PRODUCTITEMCODE Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_PRODUCTITEMCODE', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_PRODUCTITEMCODE;
        GO
        CREATE PROCEDURE INSERT_PRODUCTITEMCODE
        	-- Add the parameters for the stored procedure here
        @RETURN_MID int output,
        @active bit,
        @cdate datetime,
        @cid char(10),
        @did char(10),
        @type nvarchar(10),
        @hs_model nvarchar(100),
        @last_stock bit,
        @item_code nvarchar(10),
        @edate datetime,
        @ddate datetime,
        @sdate datetime,
        @quota char(10)
        AS
        
        INSERT INTO  [ProductItemCode]   ([cid],[active],[cdate],[hs_model],[did],[type],[last_stock],[item_code],[edate],[ddate],[sdate],[quota])  VALUES  (@cid,@active,@cdate,@hs_model,@did,@type,@last_stock,@item_code,@edate,@ddate,@sdate,@quota)
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
            string _sQuery = "DELETE FROM  [ProductItemCode]  WHERE [ProductItemCode].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProductItemCode]", "[" + Configurator.MSSQLTablePrefix + "ProductItemCode]"); }
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
            return ProductItemCodeRepositoryBase.DeleteAll(n_oDB);
        }

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "DELETE FROM  [ProductItemCode]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProductItemCode]", "[" + Configurator.MSSQLTablePrefix + "ProductItemCode]"); }
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
            string _sQuery = "DELETE FROM [ProductItemCode]" + x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProductItemCode]", "[" + Configurator.MSSQLTablePrefix + "ProductItemCode]"); }
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

