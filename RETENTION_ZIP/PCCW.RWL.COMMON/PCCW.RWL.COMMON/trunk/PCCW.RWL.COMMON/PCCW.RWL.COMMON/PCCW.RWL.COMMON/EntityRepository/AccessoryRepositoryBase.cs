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
///-- Description:	<Description,Table :[Accessory],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [Accessory] Insert / list / delete manager layer
    /// </summary>

    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name = Configurator.MSSQLTablePrefix + "Accessory")]
    public class AccessoryRepositoryBase : global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable
    {

        #region Instance
        private static AccessoryRepositoryBase instance;
        public static AccessoryRepositoryBase Instance()
        {
            if (instance == null)
            {
                MSSQLConnect _oDB = new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new AccessoryRepositoryBase(_oDB);
            }
            return instance;
        }
        public static AccessoryRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if (instance == null)
                instance = new AccessoryRepositoryBase(x_oDB);
            return instance;
        }
        #endregion

        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<AccessoryEntity> Accessorys;
        #endregion

        #region Constructor
        public AccessoryRepositoryBase(MSSQLConnect x_oDB)
            : base(x_oDB.ConnectionStr)
        {
            n_oDB = x_oDB;
        }
        ~AccessoryRepositoryBase()
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
        public static Accessory CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new Accessory(_oDB);
        }

        public static Accessory CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new Accessory(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [Accessory]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[Accessory]", "[" + Configurator.MSSQLTablePrefix + "Accessory]"); }
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


        public AccessoryEntity GetObj(global::System.Nullable<int> x_iMid)
        {
            return GetObj(n_oDB, x_iMid);
        }


        public static AccessoryEntity GetObj(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            if (x_oDB == null) { return null; }
            Accessory _Accessory = (Accessory)AccessoryRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_Accessory.Load(x_iMid)) { return null; }
            return _Accessory;
        }



        public static AccessoryEntity[] GetArrayObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            List<AccessoryEntity> _oAccessoryList = GetListObj(x_oDB, 0, "mid", x_oArrayItemId);
            return _oAccessoryList.Count == 0 ? null : _oAccessoryList.ToArray();
        }

        public static List<AccessoryEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB, 0, "mid", x_oArrayItemId);
        }


        public static AccessoryEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<AccessoryEntity> _oAccessoryList = GetListObj(x_oDB, 0, x_oColumnName, x_oArrayItemId);
            return _oAccessoryList.Count == 0 ? null : _oAccessoryList.ToArray();
        }


        public static AccessoryEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<AccessoryEntity> _oAccessoryList = GetListObj(x_oDB, x_iTop, x_oColumnName, x_oArrayItemId);
            return _oAccessoryList.Count == 0 ? null : _oAccessoryList.ToArray();
        }

        public static List<AccessoryEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB == null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            List<AccessoryEntity> _oRow = new List<AccessoryEntity>();
            string _sQuery = "SELECT  " + _sTop + " [Accessory].[active] AS ACCESSORY_ACTIVE,[Accessory].[cdate] AS ACCESSORY_CDATE,[Accessory].[cid] AS ACCESSORY_CID,[Accessory].[accessory_price] AS ACCESSORY_ACCESSORY_PRICE,[Accessory].[accessory_desc] AS ACCESSORY_ACCESSORY_DESC,[Accessory].[last_stock] AS ACCESSORY_LAST_STOCK,[Accessory].[edate] AS ACCESSORY_EDATE,[Accessory].[accessory_code] AS ACCESSORY_ACCESSORY_CODE,[Accessory].[did] AS ACCESSORY_DID,[Accessory].[ddate] AS ACCESSORY_DDATE,[Accessory].[mid] AS ACCESSORY_MID,[Accessory].[sdate] AS ACCESSORY_SDATE,[Accessory].[quota] AS ACCESSORY_QUOTA  FROM  [Accessory]";
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
                _sQuery += " WHERE [Accessory].[" + x_oColumnName.ToString() + "]  in " + _oList;
            }

            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[Accessory]", "[" + Configurator.MSSQLTablePrefix + "Accessory]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        Accessory _oAccessory = AccessoryRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_ACTIVE"])) { _oAccessory.active = (global::System.Nullable<bool>)_oData["ACCESSORY_ACTIVE"]; } else { _oAccessory.active = null; }
                        if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_CDATE"])) { _oAccessory.cdate = (global::System.Nullable<DateTime>)_oData["ACCESSORY_CDATE"]; } else { _oAccessory.cdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_CID"])) { _oAccessory.cid = (string)_oData["ACCESSORY_CID"]; } else { _oAccessory.cid = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_ACCESSORY_PRICE"])) { _oAccessory.accessory_price = (string)_oData["ACCESSORY_ACCESSORY_PRICE"]; } else { _oAccessory.accessory_price = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_SDATE"])) { _oAccessory.sdate = (global::System.Nullable<DateTime>)_oData["ACCESSORY_SDATE"]; } else { _oAccessory.sdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_ACCESSORY_DESC"])) { _oAccessory.accessory_desc = (string)_oData["ACCESSORY_ACCESSORY_DESC"]; } else { _oAccessory.accessory_desc = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_LAST_STOCK"])) { _oAccessory.last_stock = (global::System.Nullable<bool>)_oData["ACCESSORY_LAST_STOCK"]; } else { _oAccessory.last_stock = null; }
                        if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_EDATE"])) { _oAccessory.edate = (global::System.Nullable<DateTime>)_oData["ACCESSORY_EDATE"]; } else { _oAccessory.edate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_ACCESSORY_CODE"])) { _oAccessory.accessory_code = (string)_oData["ACCESSORY_ACCESSORY_CODE"]; } else { _oAccessory.accessory_code = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_DDATE"])) { _oAccessory.ddate = (global::System.Nullable<DateTime>)_oData["ACCESSORY_DDATE"]; } else { _oAccessory.ddate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_MID"])) { _oAccessory.mid = (global::System.Nullable<int>)_oData["ACCESSORY_MID"]; } else { _oAccessory.mid = null; }
                        if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_DID"])) { _oAccessory.did = (string)_oData["ACCESSORY_DID"]; } else { _oAccessory.did = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_QUOTA"])) { _oAccessory.quota = (string)_oData["ACCESSORY_QUOTA"]; } else { _oAccessory.quota = global::System.String.Empty; }
                        _oAccessory.SetDB(x_oDB);
                        _oAccessory.GetFound();
                        _oRow.Add(_oAccessory);
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


        public static AccessoryEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<AccessoryEntity> _oAccessoryList = GetListObj(x_oDB, 0, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oAccessoryList.Count == 0 ? null : _oAccessoryList.ToArray();
        }


        public static AccessoryEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<AccessoryEntity> _oAccessoryList = GetListObj(x_oDB, x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oAccessoryList.Count == 0 ? null : _oAccessoryList.ToArray();
        }

        public static List<AccessoryEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB == null) { return null; }
            List<AccessoryEntity> _oRow = new List<AccessoryEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            string _sFields = "[Accessory].[active] AS ACCESSORY_ACTIVE,[Accessory].[cdate] AS ACCESSORY_CDATE,[Accessory].[cid] AS ACCESSORY_CID,[Accessory].[accessory_price] AS ACCESSORY_ACCESSORY_PRICE,[Accessory].[accessory_desc] AS ACCESSORY_ACCESSORY_DESC,[Accessory].[last_stock] AS ACCESSORY_LAST_STOCK,[Accessory].[edate] AS ACCESSORY_EDATE,[Accessory].[accessory_code] AS ACCESSORY_ACCESSORY_CODE,[Accessory].[did] AS ACCESSORY_DID,[Accessory].[ddate] AS ACCESSORY_DDATE,[Accessory].[mid] AS ACCESSORY_MID,[Accessory].[sdate] AS ACCESSORY_SDATE,[Accessory].[quota] AS ACCESSORY_QUOTA";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[Accessory]", "[" + Configurator.MSSQLTablePrefix + "Accessory]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = AccessoryRepositoryBase.GetSearch(x_oDB, _sTop.ToString() + _sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                AccessoryEntity _oAccessory = AccessoryRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_ACTIVE"])) { _oAccessory.active = (global::System.Nullable<bool>)_oData["ACCESSORY_ACTIVE"]; } else { _oAccessory.active = null; }
                if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_CDATE"])) { _oAccessory.cdate = (global::System.Nullable<DateTime>)_oData["ACCESSORY_CDATE"]; } else { _oAccessory.cdate = null; }
                if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_CID"])) { _oAccessory.cid = (string)_oData["ACCESSORY_CID"]; } else { _oAccessory.cid = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_ACCESSORY_PRICE"])) { _oAccessory.accessory_price = (string)_oData["ACCESSORY_ACCESSORY_PRICE"]; } else { _oAccessory.accessory_price = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_SDATE"])) { _oAccessory.sdate = (global::System.Nullable<DateTime>)_oData["ACCESSORY_SDATE"]; } else { _oAccessory.sdate = null; }
                if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_ACCESSORY_DESC"])) { _oAccessory.accessory_desc = (string)_oData["ACCESSORY_ACCESSORY_DESC"]; } else { _oAccessory.accessory_desc = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_LAST_STOCK"])) { _oAccessory.last_stock = (global::System.Nullable<bool>)_oData["ACCESSORY_LAST_STOCK"]; } else { _oAccessory.last_stock = null; }
                if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_EDATE"])) { _oAccessory.edate = (global::System.Nullable<DateTime>)_oData["ACCESSORY_EDATE"]; } else { _oAccessory.edate = null; }
                if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_ACCESSORY_CODE"])) { _oAccessory.accessory_code = (string)_oData["ACCESSORY_ACCESSORY_CODE"]; } else { _oAccessory.accessory_code = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_DDATE"])) { _oAccessory.ddate = (global::System.Nullable<DateTime>)_oData["ACCESSORY_DDATE"]; } else { _oAccessory.ddate = null; }
                if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_MID"])) { _oAccessory.mid = (global::System.Nullable<int>)_oData["ACCESSORY_MID"]; } else { _oAccessory.mid = null; }
                if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_DID"])) { _oAccessory.did = (string)_oData["ACCESSORY_DID"]; } else { _oAccessory.did = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_QUOTA"])) { _oAccessory.quota = (string)_oData["ACCESSORY_QUOTA"]; } else { _oAccessory.quota = global::System.String.Empty; }
                _oAccessory.SetDB(x_oDB);
                _oAccessory.GetFound();
                _oRow.Add(_oAccessory);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet(Accessory.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder, Accessory.Para.TableName());
            return _oDset;
        }


        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB == null) { return null; }
            return x_oDB.GetSearch(Accessory.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }


        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(Accessory.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            if (x_oDB == null) { return null; }
            string _oQuery = "SELECT   [Accessory].[active] AS ACCESSORY_ACTIVE,[Accessory].[cdate] AS ACCESSORY_CDATE,[Accessory].[cid] AS ACCESSORY_CID,[Accessory].[accessory_price] AS ACCESSORY_ACCESSORY_PRICE,[Accessory].[accessory_desc] AS ACCESSORY_ACCESSORY_DESC,[Accessory].[last_stock] AS ACCESSORY_LAST_STOCK,[Accessory].[edate] AS ACCESSORY_EDATE,[Accessory].[accessory_code] AS ACCESSORY_ACCESSORY_CODE,[Accessory].[did] AS ACCESSORY_DID,[Accessory].[ddate] AS ACCESSORY_DDATE,[Accessory].[mid] AS ACCESSORY_MID,[Accessory].[sdate] AS ACCESSORY_SDATE,[Accessory].[quota] AS ACCESSORY_QUOTA  FROM  [Accessory]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[Accessory]", "[" + Configurator.MSSQLTablePrefix + "Accessory]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery, _oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset, "Accessory");
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

        public bool Insert(global::System.Nullable<bool> x_bActive, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sAccessory_price, global::System.Nullable<DateTime> x_dSdate, string x_sAccessory_desc, global::System.Nullable<bool> x_bLast_stock, global::System.Nullable<DateTime> x_dEdate, string x_sAccessory_code, global::System.Nullable<DateTime> x_dDdate, string x_sDid, string x_sQuota)
        {
            Accessory _oAccessory = AccessoryRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oAccessory.active = x_bActive;
            _oAccessory.cdate = x_dCdate;
            _oAccessory.cid = x_sCid;
            _oAccessory.accessory_price = x_sAccessory_price;
            _oAccessory.sdate = x_dSdate;
            _oAccessory.accessory_desc = x_sAccessory_desc;
            _oAccessory.last_stock = x_bLast_stock;
            _oAccessory.edate = x_dEdate;
            _oAccessory.accessory_code = x_sAccessory_code;
            _oAccessory.ddate = x_dDdate;
            _oAccessory.did = x_sDid;
            _oAccessory.quota = x_sQuota;
            return InsertWithOutLastID(n_oDB, _oAccessory);
        }


        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bActive, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sAccessory_price, global::System.Nullable<DateTime> x_dSdate, string x_sAccessory_desc, global::System.Nullable<bool> x_bLast_stock, global::System.Nullable<DateTime> x_dEdate, string x_sAccessory_code, global::System.Nullable<DateTime> x_dDdate, string x_sDid, string x_sQuota)
        {
            Accessory _oAccessory = AccessoryRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oAccessory.active = x_bActive;
            _oAccessory.cdate = x_dCdate;
            _oAccessory.cid = x_sCid;
            _oAccessory.accessory_price = x_sAccessory_price;
            _oAccessory.sdate = x_dSdate;
            _oAccessory.accessory_desc = x_sAccessory_desc;
            _oAccessory.last_stock = x_bLast_stock;
            _oAccessory.edate = x_dEdate;
            _oAccessory.accessory_code = x_sAccessory_code;
            _oAccessory.ddate = x_dDdate;
            _oAccessory.did = x_sDid;
            _oAccessory.quota = x_sQuota;
            return InsertWithOutLastID(x_oDB, _oAccessory);
        }


        public bool Insert(Accessory x_oAccessory)
        {
            return InsertWithOutLastID(n_oDB, x_oAccessory);
        }


        public bool InsertEntity(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is Accessory)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (Accessory)x_oObj);
        }


        public static bool Insert(MSSQLConnect x_oDB, Accessory x_oAccessory)
        {
            return InsertWithOutLastID(x_oDB, x_oAccessory);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, Accessory x_oAccessory)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT INTO  [Accessory]   ([active],[cdate],[cid],[accessory_price],[accessory_desc],[last_stock],[edate],[accessory_code],[did],[ddate],[sdate],[quota])  VALUES  (@active,@cdate,@cid,@accessory_price,@accessory_desc,@last_stock,@edate,@accessory_code,@did,@ddate,@sdate,@quota)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[Accessory]", "[" + Configurator.MSSQLTablePrefix + "Accessory]"); }
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
            return InsertTransactionWithOutLastID(x_oDB, _oConn, _oCmd, x_oAccessory);
        }

        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, Accessory x_oAccessory)
        {
            bool _bResult = false;
            if (!x_oAccessory.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if (x_oAccessory.active == null) { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = x_oAccessory.active; }
                if (x_oAccessory.cdate == null) { x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = x_oAccessory.cdate; }
                if (x_oAccessory.cid == null) { x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10).Value = x_oAccessory.cid; }
                if (x_oAccessory.accessory_price == null) { x_oCmd.Parameters.Add("@accessory_price", global::System.Data.SqlDbType.NVarChar, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@accessory_price", global::System.Data.SqlDbType.NVarChar, 10).Value = x_oAccessory.accessory_price; }
                if (x_oAccessory.accessory_desc == null) { x_oCmd.Parameters.Add("@accessory_desc", global::System.Data.SqlDbType.NVarChar, 70).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@accessory_desc", global::System.Data.SqlDbType.NVarChar, 70).Value = x_oAccessory.accessory_desc; }
                if (x_oAccessory.last_stock == null) { x_oCmd.Parameters.Add("@last_stock", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@last_stock", global::System.Data.SqlDbType.Bit).Value = x_oAccessory.last_stock; }
                if (x_oAccessory.edate == null) { x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = x_oAccessory.edate; }
                if (x_oAccessory.accessory_code == null) { x_oCmd.Parameters.Add("@accessory_code", global::System.Data.SqlDbType.NVarChar, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@accessory_code", global::System.Data.SqlDbType.NVarChar, 10).Value = x_oAccessory.accessory_code; }
                if (x_oAccessory.did == null) { x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10).Value = x_oAccessory.did; }
                if (x_oAccessory.ddate == null) { x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = x_oAccessory.ddate; }
                if (x_oAccessory.sdate == null) { x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = x_oAccessory.sdate; }
                if (x_oAccessory.quota == null) { x_oCmd.Parameters.Add("@quota", global::System.Data.SqlDbType.Char, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@quota", global::System.Data.SqlDbType.Char, 10).Value = x_oAccessory.quota; }
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


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bActive, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sAccessory_price, global::System.Nullable<DateTime> x_dSdate, string x_sAccessory_desc, global::System.Nullable<bool> x_bLast_stock, global::System.Nullable<DateTime> x_dEdate, string x_sAccessory_code, global::System.Nullable<DateTime> x_dDdate, string x_sDid, string x_sQuota)
        {
            int _oLastID;
            Accessory _oAccessory = AccessoryRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oAccessory.active = x_bActive;
            _oAccessory.cdate = x_dCdate;
            _oAccessory.cid = x_sCid;
            _oAccessory.accessory_price = x_sAccessory_price;
            _oAccessory.sdate = x_dSdate;
            _oAccessory.accessory_desc = x_sAccessory_desc;
            _oAccessory.last_stock = x_bLast_stock;
            _oAccessory.edate = x_dEdate;
            _oAccessory.accessory_code = x_sAccessory_code;
            _oAccessory.ddate = x_dDdate;
            _oAccessory.did = x_sDid;
            _oAccessory.quota = x_sQuota;
            if (InsertWithLastID_SP(x_oDB, _oAccessory, out _oLastID))
            {
                return _oLastID;
            }
            else
            {
                return -1;
            }
        }


        public int InsertReturnLastID_SP(Accessory x_oAccessory)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oAccessory, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, Accessory x_oAccessory)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oAccessory, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is Accessory)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (Accessory)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB, Accessory x_oAccessory, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "ACCESSORY";
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
            return InsertTransactionWithLastID_SP(x_oDB, _oConn, _oCmd, x_oAccessory, out x_oLAST_ID);
        }

        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, Accessory x_oAccessory, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar = x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oAccessory.active == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oAccessory.active; }
                _oPar = x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oAccessory.cdate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oAccessory.cdate; }
                _oPar = x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oAccessory.cid == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oAccessory.cid; }
                _oPar = x_oCmd.Parameters.Add("@accessory_price", global::System.Data.SqlDbType.NVarChar, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oAccessory.accessory_price == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oAccessory.accessory_price; }
                _oPar = x_oCmd.Parameters.Add("@accessory_desc", global::System.Data.SqlDbType.NVarChar, 70);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oAccessory.accessory_desc == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oAccessory.accessory_desc; }
                _oPar = x_oCmd.Parameters.Add("@last_stock", global::System.Data.SqlDbType.Bit);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oAccessory.last_stock == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oAccessory.last_stock; }
                _oPar = x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oAccessory.edate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oAccessory.edate; }
                _oPar = x_oCmd.Parameters.Add("@accessory_code", global::System.Data.SqlDbType.NVarChar, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oAccessory.accessory_code == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oAccessory.accessory_code; }
                _oPar = x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oAccessory.did == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oAccessory.did; }
                _oPar = x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oAccessory.ddate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oAccessory.ddate; }
                _oPar = x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oAccessory.sdate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oAccessory.sdate; }
                _oPar = x_oCmd.Parameters.Add("@quota", global::System.Data.SqlDbType.Char, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oAccessory.quota == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oAccessory.quota; }
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

        #region INSERT_ACCESSORY Store Procedures
        ///-- =============================================
        ///-- Author:		<Author,Philip SW>
        ///-- Create date: <Create Date 2009-11-17>
        ///-- Description:	<Description,ACCESSORY, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_ACCESSORY Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_ACCESSORY', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_ACCESSORY;
        GO
        CREATE PROCEDURE INSERT_ACCESSORY
        	-- Add the parameters for the stored procedure here
        @RETURN_MID int output,
        @active bit,
        @cdate datetime,
        @cid char(10),
        @accessory_price nvarchar(10),
        @sdate datetime,
        @accessory_desc nvarchar(70),
        @last_stock bit,
        @edate datetime,
        @accessory_code nvarchar(10),
        @ddate datetime,
        @did char(10),
        @quota char(10)
        AS
        
        INSERT INTO  [Accessory]   ([active],[cdate],[cid],[accessory_price],[accessory_desc],[last_stock],[edate],[accessory_code],[did],[ddate],[sdate],[quota])  VALUES  (@active,@cdate,@cid,@accessory_price,@accessory_desc,@last_stock,@edate,@accessory_code,@did,@ddate,@sdate,@quota)
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
            string _sQuery = "DELETE FROM  [Accessory]  WHERE [Accessory].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[Accessory]", "[" + Configurator.MSSQLTablePrefix + "Accessory]"); }
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
            return AccessoryRepositoryBase.DeleteAll(n_oDB);
        }

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "DELETE FROM  [Accessory]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[Accessory]", "[" + Configurator.MSSQLTablePrefix + "Accessory]"); }
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
            string _sQuery = "DELETE FROM [Accessory]" + x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[Accessory]", "[" + Configurator.MSSQLTablePrefix + "Accessory]"); }
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