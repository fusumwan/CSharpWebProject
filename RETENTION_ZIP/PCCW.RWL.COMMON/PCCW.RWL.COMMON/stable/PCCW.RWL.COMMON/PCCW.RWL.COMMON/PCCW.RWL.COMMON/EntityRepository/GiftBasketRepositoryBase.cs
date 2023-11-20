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
///-- Description:	<Description,Table :[GiftBasket],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [GiftBasket] Insert / list / delete manager layer
    /// </summary>

    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name = Configurator.MSSQLTablePrefix + "GiftBasket")]
    public class GiftBasketRepositoryBase : global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable
    {

        #region Instance
        private static GiftBasketRepositoryBase instance;
        public static GiftBasketRepositoryBase Instance()
        {
            if (instance == null)
            {
                MSSQLConnect _oDB = new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new GiftBasketRepositoryBase(_oDB);
            }
            return instance;
        }
        public static GiftBasketRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if (instance == null)
                instance = new GiftBasketRepositoryBase(x_oDB);
            return instance;
        }
        #endregion

        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<GiftBasketEntity> GiftBaskets;
        #endregion

        #region Constructor
        public GiftBasketRepositoryBase(MSSQLConnect x_oDB)
            : base(x_oDB.ConnectionStr)
        {
            n_oDB = x_oDB;
        }
        ~GiftBasketRepositoryBase()
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
        public static GiftBasket CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new GiftBasket(_oDB);
        }

        public static GiftBasket CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new GiftBasket(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [GiftBasket]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[GiftBasket]", "[" + Configurator.MSSQLTablePrefix + "GiftBasket]"); }
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


        public GiftBasketEntity GetObj(global::System.Nullable<int> x_iMid)
        {
            return GetObj(n_oDB, x_iMid);
        }


        public static GiftBasketEntity GetObj(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            if (x_oDB == null) { return null; }
            GiftBasket _GiftBasket = (GiftBasket)GiftBasketRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_GiftBasket.Load(x_iMid)) { return null; }
            return _GiftBasket;
        }



        public static GiftBasketEntity[] GetArrayObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            List<GiftBasketEntity> _oGiftBasketList = GetListObj(x_oDB, 0, "mid", x_oArrayItemId);
            return _oGiftBasketList.Count == 0 ? null : _oGiftBasketList.ToArray();
        }

        public static List<GiftBasketEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB, 0, "mid", x_oArrayItemId);
        }


        public static GiftBasketEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<GiftBasketEntity> _oGiftBasketList = GetListObj(x_oDB, 0, x_oColumnName, x_oArrayItemId);
            return _oGiftBasketList.Count == 0 ? null : _oGiftBasketList.ToArray();
        }


        public static GiftBasketEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<GiftBasketEntity> _oGiftBasketList = GetListObj(x_oDB, x_iTop, x_oColumnName, x_oArrayItemId);
            return _oGiftBasketList.Count == 0 ? null : _oGiftBasketList.ToArray();
        }

        public static List<GiftBasketEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB == null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            List<GiftBasketEntity> _oRow = new List<GiftBasketEntity>();
            string _sQuery = "SELECT  " + _sTop + " [GiftBasket].[gift_code] AS GIFTBASKET_GIFT_CODE,[GiftBasket].[cdate] AS GIFTBASKET_CDATE,[GiftBasket].[cid] AS GIFTBASKET_CID,[GiftBasket].[active] AS GIFTBASKET_ACTIVE,[GiftBasket].[last_stock] AS GIFTBASKET_LAST_STOCK,[GiftBasket].[edate] AS GIFTBASKET_EDATE,[GiftBasket].[did] AS GIFTBASKET_DID,[GiftBasket].[gift_desc] AS GIFTBASKET_GIFT_DESC,[GiftBasket].[gift_gp] AS GIFTBASKET_GIFT_GP,[GiftBasket].[ddate] AS GIFTBASKET_DDATE,[GiftBasket].[mid] AS GIFTBASKET_MID,[GiftBasket].[sdate] AS GIFTBASKET_SDATE,[GiftBasket].[quota] AS GIFTBASKET_QUOTA  FROM  [GiftBasket]";
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
                _sQuery += " WHERE [GiftBasket].[" + x_oColumnName.ToString() + "]  in " + _oList;
            }

            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[GiftBasket]", "[" + Configurator.MSSQLTablePrefix + "GiftBasket]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        GiftBasket _oGiftBasket = GiftBasketRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_ACTIVE"])) { _oGiftBasket.active = (global::System.Nullable<bool>)_oData["GIFTBASKET_ACTIVE"]; } else { _oGiftBasket.active = null; }
                        if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_CDATE"])) { _oGiftBasket.cdate = (global::System.Nullable<DateTime>)_oData["GIFTBASKET_CDATE"]; } else { _oGiftBasket.cdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_CID"])) { _oGiftBasket.cid = (string)_oData["GIFTBASKET_CID"]; } else { _oGiftBasket.cid = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_GIFT_CODE"])) { _oGiftBasket.gift_code = (string)_oData["GIFTBASKET_GIFT_CODE"]; } else { _oGiftBasket.gift_code = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_SDATE"])) { _oGiftBasket.sdate = (global::System.Nullable<DateTime>)_oData["GIFTBASKET_SDATE"]; } else { _oGiftBasket.sdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_LAST_STOCK"])) { _oGiftBasket.last_stock = (global::System.Nullable<bool>)_oData["GIFTBASKET_LAST_STOCK"]; } else { _oGiftBasket.last_stock = null; }
                        if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_EDATE"])) { _oGiftBasket.edate = (global::System.Nullable<DateTime>)_oData["GIFTBASKET_EDATE"]; } else { _oGiftBasket.edate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_GIFT_DESC"])) { _oGiftBasket.gift_desc = (string)_oData["GIFTBASKET_GIFT_DESC"]; } else { _oGiftBasket.gift_desc = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_GIFT_GP"])) { _oGiftBasket.gift_gp = (string)_oData["GIFTBASKET_GIFT_GP"]; } else { _oGiftBasket.gift_gp = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_DDATE"])) { _oGiftBasket.ddate = (global::System.Nullable<DateTime>)_oData["GIFTBASKET_DDATE"]; } else { _oGiftBasket.ddate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_MID"])) { _oGiftBasket.mid = (global::System.Nullable<int>)_oData["GIFTBASKET_MID"]; } else { _oGiftBasket.mid = null; }
                        if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_DID"])) { _oGiftBasket.did = (string)_oData["GIFTBASKET_DID"]; } else { _oGiftBasket.did = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_QUOTA"])) { _oGiftBasket.quota = (string)_oData["GIFTBASKET_QUOTA"]; } else { _oGiftBasket.quota = global::System.String.Empty; }
                        _oGiftBasket.SetDB(x_oDB);
                        _oGiftBasket.GetFound();
                        _oRow.Add(_oGiftBasket);
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


        public static GiftBasketEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<GiftBasketEntity> _oGiftBasketList = GetListObj(x_oDB, 0, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oGiftBasketList.Count == 0 ? null : _oGiftBasketList.ToArray();
        }


        public static GiftBasketEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<GiftBasketEntity> _oGiftBasketList = GetListObj(x_oDB, x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oGiftBasketList.Count == 0 ? null : _oGiftBasketList.ToArray();
        }

        public static List<GiftBasketEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB == null) { return null; }
            List<GiftBasketEntity> _oRow = new List<GiftBasketEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            string _sFields = "[GiftBasket].[gift_code] AS GIFTBASKET_GIFT_CODE,[GiftBasket].[cdate] AS GIFTBASKET_CDATE,[GiftBasket].[cid] AS GIFTBASKET_CID,[GiftBasket].[active] AS GIFTBASKET_ACTIVE,[GiftBasket].[last_stock] AS GIFTBASKET_LAST_STOCK,[GiftBasket].[edate] AS GIFTBASKET_EDATE,[GiftBasket].[did] AS GIFTBASKET_DID,[GiftBasket].[gift_desc] AS GIFTBASKET_GIFT_DESC,[GiftBasket].[gift_gp] AS GIFTBASKET_GIFT_GP,[GiftBasket].[ddate] AS GIFTBASKET_DDATE,[GiftBasket].[mid] AS GIFTBASKET_MID,[GiftBasket].[sdate] AS GIFTBASKET_SDATE,[GiftBasket].[quota] AS GIFTBASKET_QUOTA";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[GiftBasket]", "[" + Configurator.MSSQLTablePrefix + "GiftBasket]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = GiftBasketRepositoryBase.GetSearch(x_oDB, _sTop.ToString() + _sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                GiftBasketEntity _oGiftBasket = GiftBasketRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_ACTIVE"])) { _oGiftBasket.active = (global::System.Nullable<bool>)_oData["GIFTBASKET_ACTIVE"]; } else { _oGiftBasket.active = null; }
                if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_CDATE"])) { _oGiftBasket.cdate = (global::System.Nullable<DateTime>)_oData["GIFTBASKET_CDATE"]; } else { _oGiftBasket.cdate = null; }
                if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_CID"])) { _oGiftBasket.cid = (string)_oData["GIFTBASKET_CID"]; } else { _oGiftBasket.cid = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_GIFT_CODE"])) { _oGiftBasket.gift_code = (string)_oData["GIFTBASKET_GIFT_CODE"]; } else { _oGiftBasket.gift_code = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_SDATE"])) { _oGiftBasket.sdate = (global::System.Nullable<DateTime>)_oData["GIFTBASKET_SDATE"]; } else { _oGiftBasket.sdate = null; }
                if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_LAST_STOCK"])) { _oGiftBasket.last_stock = (global::System.Nullable<bool>)_oData["GIFTBASKET_LAST_STOCK"]; } else { _oGiftBasket.last_stock = null; }
                if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_EDATE"])) { _oGiftBasket.edate = (global::System.Nullable<DateTime>)_oData["GIFTBASKET_EDATE"]; } else { _oGiftBasket.edate = null; }
                if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_GIFT_DESC"])) { _oGiftBasket.gift_desc = (string)_oData["GIFTBASKET_GIFT_DESC"]; } else { _oGiftBasket.gift_desc = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_GIFT_GP"])) { _oGiftBasket.gift_gp = (string)_oData["GIFTBASKET_GIFT_GP"]; } else { _oGiftBasket.gift_gp = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_DDATE"])) { _oGiftBasket.ddate = (global::System.Nullable<DateTime>)_oData["GIFTBASKET_DDATE"]; } else { _oGiftBasket.ddate = null; }
                if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_MID"])) { _oGiftBasket.mid = (global::System.Nullable<int>)_oData["GIFTBASKET_MID"]; } else { _oGiftBasket.mid = null; }
                if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_DID"])) { _oGiftBasket.did = (string)_oData["GIFTBASKET_DID"]; } else { _oGiftBasket.did = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_QUOTA"])) { _oGiftBasket.quota = (string)_oData["GIFTBASKET_QUOTA"]; } else { _oGiftBasket.quota = global::System.String.Empty; }
                _oGiftBasket.SetDB(x_oDB);
                _oGiftBasket.GetFound();
                _oRow.Add(_oGiftBasket);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet(GiftBasket.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder, GiftBasket.Para.TableName());
            return _oDset;
        }


        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB == null) { return null; }
            return x_oDB.GetSearch(GiftBasket.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }


        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(GiftBasket.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            if (x_oDB == null) { return null; }
            string _oQuery = "SELECT   [GiftBasket].[gift_code] AS GIFTBASKET_GIFT_CODE,[GiftBasket].[cdate] AS GIFTBASKET_CDATE,[GiftBasket].[cid] AS GIFTBASKET_CID,[GiftBasket].[active] AS GIFTBASKET_ACTIVE,[GiftBasket].[last_stock] AS GIFTBASKET_LAST_STOCK,[GiftBasket].[edate] AS GIFTBASKET_EDATE,[GiftBasket].[did] AS GIFTBASKET_DID,[GiftBasket].[gift_desc] AS GIFTBASKET_GIFT_DESC,[GiftBasket].[gift_gp] AS GIFTBASKET_GIFT_GP,[GiftBasket].[ddate] AS GIFTBASKET_DDATE,[GiftBasket].[mid] AS GIFTBASKET_MID,[GiftBasket].[sdate] AS GIFTBASKET_SDATE,[GiftBasket].[quota] AS GIFTBASKET_QUOTA  FROM  [GiftBasket]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[GiftBasket]", "[" + Configurator.MSSQLTablePrefix + "GiftBasket]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery, _oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset, "GiftBasket");
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

        public bool Insert(global::System.Nullable<bool> x_bActive, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sGift_code, global::System.Nullable<DateTime> x_dSdate, global::System.Nullable<bool> x_bLast_stock, global::System.Nullable<DateTime> x_dEdate, string x_sGift_desc, string x_sGift_gp, global::System.Nullable<DateTime> x_dDdate, string x_sDid, string x_sQuota)
        {
            GiftBasket _oGiftBasket = GiftBasketRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oGiftBasket.active = x_bActive;
            _oGiftBasket.cdate = x_dCdate;
            _oGiftBasket.cid = x_sCid;
            _oGiftBasket.gift_code = x_sGift_code;
            _oGiftBasket.sdate = x_dSdate;
            _oGiftBasket.last_stock = x_bLast_stock;
            _oGiftBasket.edate = x_dEdate;
            _oGiftBasket.gift_desc = x_sGift_desc;
            _oGiftBasket.gift_gp = x_sGift_gp;
            _oGiftBasket.ddate = x_dDdate;
            _oGiftBasket.did = x_sDid;
            _oGiftBasket.quota = x_sQuota;
            return InsertWithOutLastID(n_oDB, _oGiftBasket);
        }


        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bActive, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sGift_code, global::System.Nullable<DateTime> x_dSdate, global::System.Nullable<bool> x_bLast_stock, global::System.Nullable<DateTime> x_dEdate, string x_sGift_desc, string x_sGift_gp, global::System.Nullable<DateTime> x_dDdate, string x_sDid, string x_sQuota)
        {
            GiftBasket _oGiftBasket = GiftBasketRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oGiftBasket.active = x_bActive;
            _oGiftBasket.cdate = x_dCdate;
            _oGiftBasket.cid = x_sCid;
            _oGiftBasket.gift_code = x_sGift_code;
            _oGiftBasket.sdate = x_dSdate;
            _oGiftBasket.last_stock = x_bLast_stock;
            _oGiftBasket.edate = x_dEdate;
            _oGiftBasket.gift_desc = x_sGift_desc;
            _oGiftBasket.gift_gp = x_sGift_gp;
            _oGiftBasket.ddate = x_dDdate;
            _oGiftBasket.did = x_sDid;
            _oGiftBasket.quota = x_sQuota;
            return InsertWithOutLastID(x_oDB, _oGiftBasket);
        }


        public bool Insert(GiftBasket x_oGiftBasket)
        {
            return InsertWithOutLastID(n_oDB, x_oGiftBasket);
        }


        public bool InsertEntity(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is GiftBasket)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (GiftBasket)x_oObj);
        }


        public static bool Insert(MSSQLConnect x_oDB, GiftBasket x_oGiftBasket)
        {
            return InsertWithOutLastID(x_oDB, x_oGiftBasket);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, GiftBasket x_oGiftBasket)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT INTO  [GiftBasket]   ([gift_code],[cdate],[cid],[active],[last_stock],[edate],[did],[gift_desc],[gift_gp],[ddate],[sdate],[quota])  VALUES  (@gift_code,@cdate,@cid,@active,@last_stock,@edate,@did,@gift_desc,@gift_gp,@ddate,@sdate,@quota)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[GiftBasket]", "[" + Configurator.MSSQLTablePrefix + "GiftBasket]"); }
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
            return InsertTransactionWithOutLastID(x_oDB, _oConn, _oCmd, x_oGiftBasket);
        }

        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, GiftBasket x_oGiftBasket)
        {
            bool _bResult = false;
            if (!x_oGiftBasket.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if (x_oGiftBasket.gift_code == null) { x_oCmd.Parameters.Add("@gift_code", global::System.Data.SqlDbType.NVarChar, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@gift_code", global::System.Data.SqlDbType.NVarChar, 10).Value = x_oGiftBasket.gift_code; }
                if (x_oGiftBasket.cdate == null) { x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = x_oGiftBasket.cdate; }
                if (x_oGiftBasket.cid == null) { x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10).Value = x_oGiftBasket.cid; }
                if (x_oGiftBasket.active == null) { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = x_oGiftBasket.active; }
                if (x_oGiftBasket.last_stock == null) { x_oCmd.Parameters.Add("@last_stock", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@last_stock", global::System.Data.SqlDbType.Bit).Value = x_oGiftBasket.last_stock; }
                if (x_oGiftBasket.edate == null) { x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = x_oGiftBasket.edate; }
                if (x_oGiftBasket.did == null) { x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10).Value = x_oGiftBasket.did; }
                if (x_oGiftBasket.gift_desc == null) { x_oCmd.Parameters.Add("@gift_desc", global::System.Data.SqlDbType.NVarChar, 50).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@gift_desc", global::System.Data.SqlDbType.NVarChar, 50).Value = x_oGiftBasket.gift_desc; }
                if (x_oGiftBasket.gift_gp == null) { x_oCmd.Parameters.Add("@gift_gp", global::System.Data.SqlDbType.NVarChar, 20).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@gift_gp", global::System.Data.SqlDbType.NVarChar, 20).Value = x_oGiftBasket.gift_gp; }
                if (x_oGiftBasket.ddate == null) { x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = x_oGiftBasket.ddate; }
                if (x_oGiftBasket.sdate == null) { x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = x_oGiftBasket.sdate; }
                if (x_oGiftBasket.quota == null) { x_oCmd.Parameters.Add("@quota", global::System.Data.SqlDbType.Char, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@quota", global::System.Data.SqlDbType.Char, 10).Value = x_oGiftBasket.quota; }
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


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bActive, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sGift_code, global::System.Nullable<DateTime> x_dSdate, global::System.Nullable<bool> x_bLast_stock, global::System.Nullable<DateTime> x_dEdate, string x_sGift_desc, string x_sGift_gp, global::System.Nullable<DateTime> x_dDdate, string x_sDid, string x_sQuota)
        {
            int _oLastID;
            GiftBasket _oGiftBasket = GiftBasketRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oGiftBasket.active = x_bActive;
            _oGiftBasket.cdate = x_dCdate;
            _oGiftBasket.cid = x_sCid;
            _oGiftBasket.gift_code = x_sGift_code;
            _oGiftBasket.sdate = x_dSdate;
            _oGiftBasket.last_stock = x_bLast_stock;
            _oGiftBasket.edate = x_dEdate;
            _oGiftBasket.gift_desc = x_sGift_desc;
            _oGiftBasket.gift_gp = x_sGift_gp;
            _oGiftBasket.ddate = x_dDdate;
            _oGiftBasket.did = x_sDid;
            _oGiftBasket.quota = x_sQuota;
            if (InsertWithLastID_SP(x_oDB, _oGiftBasket, out _oLastID))
            {
                return _oLastID;
            }
            else
            {
                return -1;
            }
        }


        public int InsertReturnLastID_SP(GiftBasket x_oGiftBasket)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oGiftBasket, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, GiftBasket x_oGiftBasket)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oGiftBasket, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is GiftBasket)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (GiftBasket)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB, GiftBasket x_oGiftBasket, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "GIFTBASKET";
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
            return InsertTransactionWithLastID_SP(x_oDB, _oConn, _oCmd, x_oGiftBasket, out x_oLAST_ID);
        }

        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, GiftBasket x_oGiftBasket, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar = x_oCmd.Parameters.Add("@gift_code", global::System.Data.SqlDbType.NVarChar, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oGiftBasket.gift_code == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oGiftBasket.gift_code; }
                _oPar = x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oGiftBasket.cdate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oGiftBasket.cdate; }
                _oPar = x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oGiftBasket.cid == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oGiftBasket.cid; }
                _oPar = x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oGiftBasket.active == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oGiftBasket.active; }
                _oPar = x_oCmd.Parameters.Add("@last_stock", global::System.Data.SqlDbType.Bit);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oGiftBasket.last_stock == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oGiftBasket.last_stock; }
                _oPar = x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oGiftBasket.edate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oGiftBasket.edate; }
                _oPar = x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oGiftBasket.did == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oGiftBasket.did; }
                _oPar = x_oCmd.Parameters.Add("@gift_desc", global::System.Data.SqlDbType.NVarChar, 50);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oGiftBasket.gift_desc == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oGiftBasket.gift_desc; }
                _oPar = x_oCmd.Parameters.Add("@gift_gp", global::System.Data.SqlDbType.NVarChar, 20);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oGiftBasket.gift_gp == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oGiftBasket.gift_gp; }
                _oPar = x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oGiftBasket.ddate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oGiftBasket.ddate; }
                _oPar = x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oGiftBasket.sdate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oGiftBasket.sdate; }
                _oPar = x_oCmd.Parameters.Add("@quota", global::System.Data.SqlDbType.Char, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oGiftBasket.quota == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oGiftBasket.quota; }
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

        #region INSERT_GIFTBASKET Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2009-11-17>
        ///-- Description:	<Description,GIFTBASKET, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_GIFTBASKET Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_GIFTBASKET', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_GIFTBASKET;
        GO
        CREATE PROCEDURE INSERT_GIFTBASKET
        	-- Add the parameters for the stored procedure here
        @RETURN_MID int output,
        @active bit,
        @cdate datetime,
        @cid char(10),
        @gift_code nvarchar(10),
        @sdate datetime,
        @last_stock bit,
        @edate datetime,
        @gift_desc nvarchar(50),
        @gift_gp nvarchar(20),
        @ddate datetime,
        @did char(10),
        @quota char(10)
        AS
        
        INSERT INTO  [GiftBasket]   ([gift_code],[cdate],[cid],[active],[last_stock],[edate],[did],[gift_desc],[gift_gp],[ddate],[sdate],[quota])  VALUES  (@gift_code,@cdate,@cid,@active,@last_stock,@edate,@did,@gift_desc,@gift_gp,@ddate,@sdate,@quota)
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
            string _sQuery = "DELETE FROM  [GiftBasket]  WHERE [GiftBasket].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[GiftBasket]", "[" + Configurator.MSSQLTablePrefix + "GiftBasket]"); }
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
            return GiftBasketRepositoryBase.DeleteAll(n_oDB);
        }

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "DELETE FROM  [GiftBasket]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[GiftBasket]", "[" + Configurator.MSSQLTablePrefix + "GiftBasket]"); }
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
            string _sQuery = "DELETE FROM [GiftBasket]" + x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[GiftBasket]", "[" + Configurator.MSSQLTablePrefix + "GiftBasket]"); }
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

