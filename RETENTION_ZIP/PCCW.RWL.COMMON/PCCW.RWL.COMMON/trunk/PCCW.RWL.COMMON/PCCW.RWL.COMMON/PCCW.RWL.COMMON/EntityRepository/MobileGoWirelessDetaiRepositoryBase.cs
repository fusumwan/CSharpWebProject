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
///-- Description:	<Description,Table :[MobileGoWirelessDetail],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [MobileGoWirelessDetail] Insert / list / delete manager layer
    /// </summary>

    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name = Configurator.MSSQLTablePrefix + "MobileGoWirelessDetail")]
    public class MobileGoWirelessDetailRepositoryBase : global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable
    {

        #region Instance
        private static MobileGoWirelessDetailRepositoryBase instance;
        public static MobileGoWirelessDetailRepositoryBase Instance()
        {
            if (instance == null)
            {
                MSSQLConnect _oDB = new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new MobileGoWirelessDetailRepositoryBase(_oDB);
            }
            return instance;
        }
        public static MobileGoWirelessDetailRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if (instance == null)
                instance = new MobileGoWirelessDetailRepositoryBase(x_oDB);
            return instance;
        }
        #endregion

        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<MobileGoWirelessDetailEntity> MobileGoWirelessDetails;
        #endregion

        #region Constructor
        public MobileGoWirelessDetailRepositoryBase(MSSQLConnect x_oDB)
            : base(x_oDB.ConnectionStr)
        {
            n_oDB = x_oDB;
        }
        ~MobileGoWirelessDetailRepositoryBase()
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
        public static MobileGoWirelessDetail CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new MobileGoWirelessDetail(_oDB);
        }

        public static MobileGoWirelessDetail CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new MobileGoWirelessDetail(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [MobileGoWirelessDetail]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileGoWirelessDetail]", "[" + Configurator.MSSQLTablePrefix + "MobileGoWirelessDetail]"); }
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


        public MobileGoWirelessDetailEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }


        public static MobileGoWirelessDetailEntity GetObj(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            if (x_oDB == null) { return null; }
            MobileGoWirelessDetail _MobileGoWirelessDetail = (MobileGoWirelessDetail)MobileGoWirelessDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_MobileGoWirelessDetail.Load(x_iId)) { return null; }
            return _MobileGoWirelessDetail;
        }



        public static MobileGoWirelessDetailEntity[] GetArrayObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            List<MobileGoWirelessDetailEntity> _oMobileGoWirelessDetailList = GetListObj(x_oDB, 0, "id", x_oArrayItemId);
            return _oMobileGoWirelessDetailList.Count == 0 ? null : _oMobileGoWirelessDetailList.ToArray();
        }

        public static List<MobileGoWirelessDetailEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB, 0, "id", x_oArrayItemId);
        }


        public static MobileGoWirelessDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileGoWirelessDetailEntity> _oMobileGoWirelessDetailList = GetListObj(x_oDB, 0, x_oColumnName, x_oArrayItemId);
            return _oMobileGoWirelessDetailList.Count == 0 ? null : _oMobileGoWirelessDetailList.ToArray();
        }


        public static MobileGoWirelessDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileGoWirelessDetailEntity> _oMobileGoWirelessDetailList = GetListObj(x_oDB, x_iTop, x_oColumnName, x_oArrayItemId);
            return _oMobileGoWirelessDetailList.Count == 0 ? null : _oMobileGoWirelessDetailList.ToArray();
        }

        public static List<MobileGoWirelessDetailEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB == null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            List<MobileGoWirelessDetailEntity> _oRow = new List<MobileGoWirelessDetailEntity>();
            string _sQuery = "SELECT  " + _sTop + " [MobileGoWirelessDetail].[cid] AS MOBILEGOWIRELESSDETAIL_CID,[MobileGoWirelessDetail].[id] AS MOBILEGOWIRELESSDETAIL_ID,[MobileGoWirelessDetail].[cdate] AS MOBILEGOWIRELESSDETAIL_CDATE,[MobileGoWirelessDetail].[assign] AS MOBILEGOWIRELESSDETAIL_ASSIGN,[MobileGoWirelessDetail].[mrt_no] AS MOBILEGOWIRELESSDETAIL_MRT_NO,[MobileGoWirelessDetail].[active] AS MOBILEGOWIRELESSDETAIL_ACTIVE,[MobileGoWirelessDetail].[assign_staff] AS MOBILEGOWIRELESSDETAIL_ASSIGN_STAFF,[MobileGoWirelessDetail].[assign_date] AS MOBILEGOWIRELESSDETAIL_ASSIGN_DATE,[MobileGoWirelessDetail].[order_id] AS MOBILEGOWIRELESSDETAIL_ORDER_ID,[MobileGoWirelessDetail].[ddate] AS MOBILEGOWIRELESSDETAIL_DDATE,[MobileGoWirelessDetail].[did] AS MOBILEGOWIRELESSDETAIL_DID  FROM  [MobileGoWirelessDetail]";
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
                _sQuery += " WHERE [MobileGoWirelessDetail].[" + x_oColumnName.ToString() + "]  in " + _oList;
            }

            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileGoWirelessDetail]", "[" + Configurator.MSSQLTablePrefix + "MobileGoWirelessDetail]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        MobileGoWirelessDetail _oMobileGoWirelessDetail = MobileGoWirelessDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEGOWIRELESSDETAIL_CID"])) { _oMobileGoWirelessDetail.cid = (string)_oData["MOBILEGOWIRELESSDETAIL_CID"]; } else { _oMobileGoWirelessDetail.cid = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEGOWIRELESSDETAIL_ID"])) { _oMobileGoWirelessDetail.id = (global::System.Nullable<int>)_oData["MOBILEGOWIRELESSDETAIL_ID"]; } else { _oMobileGoWirelessDetail.id = null; }
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEGOWIRELESSDETAIL_CDATE"])) { _oMobileGoWirelessDetail.cdate = (global::System.Nullable<DateTime>)_oData["MOBILEGOWIRELESSDETAIL_CDATE"]; } else { _oMobileGoWirelessDetail.cdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEGOWIRELESSDETAIL_ASSIGN"])) { _oMobileGoWirelessDetail.assign = (global::System.Nullable<bool>)_oData["MOBILEGOWIRELESSDETAIL_ASSIGN"]; } else { _oMobileGoWirelessDetail.assign = null; }
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEGOWIRELESSDETAIL_MRT_NO"])) { _oMobileGoWirelessDetail.mrt_no = (global::System.Nullable<int>)_oData["MOBILEGOWIRELESSDETAIL_MRT_NO"]; } else { _oMobileGoWirelessDetail.mrt_no = null; }
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEGOWIRELESSDETAIL_ACTIVE"])) { _oMobileGoWirelessDetail.active = (global::System.Nullable<bool>)_oData["MOBILEGOWIRELESSDETAIL_ACTIVE"]; } else { _oMobileGoWirelessDetail.active = null; }
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEGOWIRELESSDETAIL_ASSIGN_STAFF"])) { _oMobileGoWirelessDetail.assign_staff = (string)_oData["MOBILEGOWIRELESSDETAIL_ASSIGN_STAFF"]; } else { _oMobileGoWirelessDetail.assign_staff = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEGOWIRELESSDETAIL_ASSIGN_DATE"])) { _oMobileGoWirelessDetail.assign_date = (global::System.Nullable<DateTime>)_oData["MOBILEGOWIRELESSDETAIL_ASSIGN_DATE"]; } else { _oMobileGoWirelessDetail.assign_date = null; }
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEGOWIRELESSDETAIL_ORDER_ID"])) { _oMobileGoWirelessDetail.order_id = (global::System.Nullable<int>)_oData["MOBILEGOWIRELESSDETAIL_ORDER_ID"]; } else { _oMobileGoWirelessDetail.order_id = null; }
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEGOWIRELESSDETAIL_DDATE"])) { _oMobileGoWirelessDetail.ddate = (global::System.Nullable<DateTime>)_oData["MOBILEGOWIRELESSDETAIL_DDATE"]; } else { _oMobileGoWirelessDetail.ddate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEGOWIRELESSDETAIL_DID"])) { _oMobileGoWirelessDetail.did = (string)_oData["MOBILEGOWIRELESSDETAIL_DID"]; } else { _oMobileGoWirelessDetail.did = global::System.String.Empty; }
                        _oMobileGoWirelessDetail.SetDB(x_oDB);
                        _oMobileGoWirelessDetail.GetFound();
                        _oRow.Add(_oMobileGoWirelessDetail);
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


        public static MobileGoWirelessDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileGoWirelessDetailEntity> _oMobileGoWirelessDetailList = GetListObj(x_oDB, 0, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oMobileGoWirelessDetailList.Count == 0 ? null : _oMobileGoWirelessDetailList.ToArray();
        }


        public static MobileGoWirelessDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileGoWirelessDetailEntity> _oMobileGoWirelessDetailList = GetListObj(x_oDB, x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oMobileGoWirelessDetailList.Count == 0 ? null : _oMobileGoWirelessDetailList.ToArray();
        }

        public static List<MobileGoWirelessDetailEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB == null) { return null; }
            List<MobileGoWirelessDetailEntity> _oRow = new List<MobileGoWirelessDetailEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            string _sFields = "[MobileGoWirelessDetail].[cid] AS MOBILEGOWIRELESSDETAIL_CID,[MobileGoWirelessDetail].[id] AS MOBILEGOWIRELESSDETAIL_ID,[MobileGoWirelessDetail].[cdate] AS MOBILEGOWIRELESSDETAIL_CDATE,[MobileGoWirelessDetail].[assign] AS MOBILEGOWIRELESSDETAIL_ASSIGN,[MobileGoWirelessDetail].[mrt_no] AS MOBILEGOWIRELESSDETAIL_MRT_NO,[MobileGoWirelessDetail].[active] AS MOBILEGOWIRELESSDETAIL_ACTIVE,[MobileGoWirelessDetail].[assign_staff] AS MOBILEGOWIRELESSDETAIL_ASSIGN_STAFF,[MobileGoWirelessDetail].[assign_date] AS MOBILEGOWIRELESSDETAIL_ASSIGN_DATE,[MobileGoWirelessDetail].[order_id] AS MOBILEGOWIRELESSDETAIL_ORDER_ID,[MobileGoWirelessDetail].[ddate] AS MOBILEGOWIRELESSDETAIL_DDATE,[MobileGoWirelessDetail].[did] AS MOBILEGOWIRELESSDETAIL_DID";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[MobileGoWirelessDetail]", "[" + Configurator.MSSQLTablePrefix + "MobileGoWirelessDetail]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = MobileGoWirelessDetailRepositoryBase.GetSearch(x_oDB, _sTop.ToString() + _sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                MobileGoWirelessDetailEntity _oMobileGoWirelessDetail = MobileGoWirelessDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["MOBILEGOWIRELESSDETAIL_CID"])) { _oMobileGoWirelessDetail.cid = (string)_oData["MOBILEGOWIRELESSDETAIL_CID"]; } else { _oMobileGoWirelessDetail.cid = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEGOWIRELESSDETAIL_ID"])) { _oMobileGoWirelessDetail.id = (global::System.Nullable<int>)_oData["MOBILEGOWIRELESSDETAIL_ID"]; } else { _oMobileGoWirelessDetail.id = null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEGOWIRELESSDETAIL_CDATE"])) { _oMobileGoWirelessDetail.cdate = (global::System.Nullable<DateTime>)_oData["MOBILEGOWIRELESSDETAIL_CDATE"]; } else { _oMobileGoWirelessDetail.cdate = null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEGOWIRELESSDETAIL_ASSIGN"])) { _oMobileGoWirelessDetail.assign = (global::System.Nullable<bool>)_oData["MOBILEGOWIRELESSDETAIL_ASSIGN"]; } else { _oMobileGoWirelessDetail.assign = null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEGOWIRELESSDETAIL_MRT_NO"])) { _oMobileGoWirelessDetail.mrt_no = (global::System.Nullable<int>)_oData["MOBILEGOWIRELESSDETAIL_MRT_NO"]; } else { _oMobileGoWirelessDetail.mrt_no = null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEGOWIRELESSDETAIL_ACTIVE"])) { _oMobileGoWirelessDetail.active = (global::System.Nullable<bool>)_oData["MOBILEGOWIRELESSDETAIL_ACTIVE"]; } else { _oMobileGoWirelessDetail.active = null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEGOWIRELESSDETAIL_ASSIGN_STAFF"])) { _oMobileGoWirelessDetail.assign_staff = (string)_oData["MOBILEGOWIRELESSDETAIL_ASSIGN_STAFF"]; } else { _oMobileGoWirelessDetail.assign_staff = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEGOWIRELESSDETAIL_ASSIGN_DATE"])) { _oMobileGoWirelessDetail.assign_date = (global::System.Nullable<DateTime>)_oData["MOBILEGOWIRELESSDETAIL_ASSIGN_DATE"]; } else { _oMobileGoWirelessDetail.assign_date = null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEGOWIRELESSDETAIL_ORDER_ID"])) { _oMobileGoWirelessDetail.order_id = (global::System.Nullable<int>)_oData["MOBILEGOWIRELESSDETAIL_ORDER_ID"]; } else { _oMobileGoWirelessDetail.order_id = null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEGOWIRELESSDETAIL_DDATE"])) { _oMobileGoWirelessDetail.ddate = (global::System.Nullable<DateTime>)_oData["MOBILEGOWIRELESSDETAIL_DDATE"]; } else { _oMobileGoWirelessDetail.ddate = null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEGOWIRELESSDETAIL_DID"])) { _oMobileGoWirelessDetail.did = (string)_oData["MOBILEGOWIRELESSDETAIL_DID"]; } else { _oMobileGoWirelessDetail.did = global::System.String.Empty; }
                _oMobileGoWirelessDetail.SetDB(x_oDB);
                _oMobileGoWirelessDetail.GetFound();
                _oRow.Add(_oMobileGoWirelessDetail);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet(MobileGoWirelessDetail.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder, MobileGoWirelessDetail.Para.TableName());
            return _oDset;
        }


        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB == null) { return null; }
            return x_oDB.GetSearch(MobileGoWirelessDetail.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }


        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(MobileGoWirelessDetail.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            if (x_oDB == null) { return null; }
            string _oQuery = "SELECT   [MobileGoWirelessDetail].[cid] AS MOBILEGOWIRELESSDETAIL_CID,[MobileGoWirelessDetail].[id] AS MOBILEGOWIRELESSDETAIL_ID,[MobileGoWirelessDetail].[cdate] AS MOBILEGOWIRELESSDETAIL_CDATE,[MobileGoWirelessDetail].[assign] AS MOBILEGOWIRELESSDETAIL_ASSIGN,[MobileGoWirelessDetail].[mrt_no] AS MOBILEGOWIRELESSDETAIL_MRT_NO,[MobileGoWirelessDetail].[active] AS MOBILEGOWIRELESSDETAIL_ACTIVE,[MobileGoWirelessDetail].[assign_staff] AS MOBILEGOWIRELESSDETAIL_ASSIGN_STAFF,[MobileGoWirelessDetail].[assign_date] AS MOBILEGOWIRELESSDETAIL_ASSIGN_DATE,[MobileGoWirelessDetail].[order_id] AS MOBILEGOWIRELESSDETAIL_ORDER_ID,[MobileGoWirelessDetail].[ddate] AS MOBILEGOWIRELESSDETAIL_DDATE,[MobileGoWirelessDetail].[did] AS MOBILEGOWIRELESSDETAIL_DID  FROM  [MobileGoWirelessDetail]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[MobileGoWirelessDetail]", "[" + Configurator.MSSQLTablePrefix + "MobileGoWirelessDetail]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery, _oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset, "MobileGoWirelessDetail");
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

        public bool Insert(string x_sCid, global::System.Nullable<DateTime> x_dCdate, global::System.Nullable<bool> x_bAssign, global::System.Nullable<int> x_iMrt_no, global::System.Nullable<bool> x_bActive, string x_sAssign_staff, global::System.Nullable<DateTime> x_dAssign_date, global::System.Nullable<int> x_iOrder_id, global::System.Nullable<DateTime> x_dDdate, string x_sDid)
        {
            MobileGoWirelessDetail _oMobileGoWirelessDetail = MobileGoWirelessDetailRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oMobileGoWirelessDetail.cid = x_sCid;
            _oMobileGoWirelessDetail.cdate = x_dCdate;
            _oMobileGoWirelessDetail.assign = x_bAssign;
            _oMobileGoWirelessDetail.mrt_no = x_iMrt_no;
            _oMobileGoWirelessDetail.active = x_bActive;
            _oMobileGoWirelessDetail.assign_staff = x_sAssign_staff;
            _oMobileGoWirelessDetail.assign_date = x_dAssign_date;
            _oMobileGoWirelessDetail.order_id = x_iOrder_id;
            _oMobileGoWirelessDetail.ddate = x_dDdate;
            _oMobileGoWirelessDetail.did = x_sDid;
            return InsertWithOutLastID(n_oDB, _oMobileGoWirelessDetail);
        }


        public static bool Insert(MSSQLConnect x_oDB, string x_sCid, global::System.Nullable<DateTime> x_dCdate, global::System.Nullable<bool> x_bAssign, global::System.Nullable<int> x_iMrt_no, global::System.Nullable<bool> x_bActive, string x_sAssign_staff, global::System.Nullable<DateTime> x_dAssign_date, global::System.Nullable<int> x_iOrder_id, global::System.Nullable<DateTime> x_dDdate, string x_sDid)
        {
            MobileGoWirelessDetail _oMobileGoWirelessDetail = MobileGoWirelessDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileGoWirelessDetail.cid = x_sCid;
            _oMobileGoWirelessDetail.cdate = x_dCdate;
            _oMobileGoWirelessDetail.assign = x_bAssign;
            _oMobileGoWirelessDetail.mrt_no = x_iMrt_no;
            _oMobileGoWirelessDetail.active = x_bActive;
            _oMobileGoWirelessDetail.assign_staff = x_sAssign_staff;
            _oMobileGoWirelessDetail.assign_date = x_dAssign_date;
            _oMobileGoWirelessDetail.order_id = x_iOrder_id;
            _oMobileGoWirelessDetail.ddate = x_dDdate;
            _oMobileGoWirelessDetail.did = x_sDid;
            return InsertWithOutLastID(x_oDB, _oMobileGoWirelessDetail);
        }


        public bool Insert(MobileGoWirelessDetail x_oMobileGoWirelessDetail)
        {
            return InsertWithOutLastID(n_oDB, x_oMobileGoWirelessDetail);
        }


        public bool InsertEntity(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is MobileGoWirelessDetail)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (MobileGoWirelessDetail)x_oObj);
        }


        public static bool Insert(MSSQLConnect x_oDB, MobileGoWirelessDetail x_oMobileGoWirelessDetail)
        {
            return InsertWithOutLastID(x_oDB, x_oMobileGoWirelessDetail);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, MobileGoWirelessDetail x_oMobileGoWirelessDetail)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT INTO  [MobileGoWirelessDetail]   ([cid],[cdate],[assign],[mrt_no],[active],[assign_staff],[assign_date],[order_id],[ddate],[did])  VALUES  (@cid,@cdate,@assign,@mrt_no,@active,@assign_staff,@assign_date,@order_id,@ddate,@did)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileGoWirelessDetail]", "[" + Configurator.MSSQLTablePrefix + "MobileGoWirelessDetail]"); }
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
            return InsertTransactionWithOutLastID(x_oDB, _oConn, _oCmd, x_oMobileGoWirelessDetail);
        }

        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, MobileGoWirelessDetail x_oMobileGoWirelessDetail)
        {
            bool _bResult = false;
            if (!x_oMobileGoWirelessDetail.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if (x_oMobileGoWirelessDetail.cid == null) { x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar, 50).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar, 50).Value = x_oMobileGoWirelessDetail.cid; }
                if (x_oMobileGoWirelessDetail.cdate == null) { x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = x_oMobileGoWirelessDetail.cdate; }
                if (x_oMobileGoWirelessDetail.assign == null) { x_oCmd.Parameters.Add("@assign", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@assign", global::System.Data.SqlDbType.Bit).Value = x_oMobileGoWirelessDetail.assign; }
                if (x_oMobileGoWirelessDetail.mrt_no == null) { x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.Int).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.Int).Value = x_oMobileGoWirelessDetail.mrt_no; }
                if (x_oMobileGoWirelessDetail.active == null) { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = x_oMobileGoWirelessDetail.active; }
                if (x_oMobileGoWirelessDetail.assign_staff == null) { x_oCmd.Parameters.Add("@assign_staff", global::System.Data.SqlDbType.NVarChar, 50).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@assign_staff", global::System.Data.SqlDbType.NVarChar, 50).Value = x_oMobileGoWirelessDetail.assign_staff; }
                if (x_oMobileGoWirelessDetail.assign_date == null) { x_oCmd.Parameters.Add("@assign_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@assign_date", global::System.Data.SqlDbType.DateTime).Value = x_oMobileGoWirelessDetail.assign_date; }
                if (x_oMobileGoWirelessDetail.order_id == null) { x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = x_oMobileGoWirelessDetail.order_id; }
                if (x_oMobileGoWirelessDetail.ddate == null) { x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = x_oMobileGoWirelessDetail.ddate; }
                if (x_oMobileGoWirelessDetail.did == null) { x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar, 50).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar, 50).Value = x_oMobileGoWirelessDetail.did; }
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


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, string x_sCid, global::System.Nullable<DateTime> x_dCdate, global::System.Nullable<bool> x_bAssign, global::System.Nullable<int> x_iMrt_no, global::System.Nullable<bool> x_bActive, string x_sAssign_staff, global::System.Nullable<DateTime> x_dAssign_date, global::System.Nullable<int> x_iOrder_id, global::System.Nullable<DateTime> x_dDdate, string x_sDid)
        {
            int _oLastID;
            MobileGoWirelessDetail _oMobileGoWirelessDetail = MobileGoWirelessDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileGoWirelessDetail.cid = x_sCid;
            _oMobileGoWirelessDetail.cdate = x_dCdate;
            _oMobileGoWirelessDetail.assign = x_bAssign;
            _oMobileGoWirelessDetail.mrt_no = x_iMrt_no;
            _oMobileGoWirelessDetail.active = x_bActive;
            _oMobileGoWirelessDetail.assign_staff = x_sAssign_staff;
            _oMobileGoWirelessDetail.assign_date = x_dAssign_date;
            _oMobileGoWirelessDetail.order_id = x_iOrder_id;
            _oMobileGoWirelessDetail.ddate = x_dDdate;
            _oMobileGoWirelessDetail.did = x_sDid;
            if (InsertWithLastID_SP(x_oDB, _oMobileGoWirelessDetail, out _oLastID))
            {
                return _oLastID;
            }
            else
            {
                return -1;
            }
        }


        public int InsertReturnLastID_SP(MobileGoWirelessDetail x_oMobileGoWirelessDetail)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oMobileGoWirelessDetail, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileGoWirelessDetail x_oMobileGoWirelessDetail)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oMobileGoWirelessDetail, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileGoWirelessDetail)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (MobileGoWirelessDetail)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB, MobileGoWirelessDetail x_oMobileGoWirelessDetail, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "MOBILEGOWIRELESSDETAIL";
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
            return InsertTransactionWithLastID_SP(x_oDB, _oConn, _oCmd, x_oMobileGoWirelessDetail, out x_oLAST_ID);
        }

        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, MobileGoWirelessDetail x_oMobileGoWirelessDetail, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar = x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar, 50);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oMobileGoWirelessDetail.cid == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oMobileGoWirelessDetail.cid; }
                _oPar = x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oMobileGoWirelessDetail.cdate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oMobileGoWirelessDetail.cdate; }
                _oPar = x_oCmd.Parameters.Add("@assign", global::System.Data.SqlDbType.Bit);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oMobileGoWirelessDetail.assign == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oMobileGoWirelessDetail.assign; }
                _oPar = x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.Int);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oMobileGoWirelessDetail.mrt_no == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oMobileGoWirelessDetail.mrt_no; }
                _oPar = x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oMobileGoWirelessDetail.active == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oMobileGoWirelessDetail.active; }
                _oPar = x_oCmd.Parameters.Add("@assign_staff", global::System.Data.SqlDbType.NVarChar, 50);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oMobileGoWirelessDetail.assign_staff == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oMobileGoWirelessDetail.assign_staff; }
                _oPar = x_oCmd.Parameters.Add("@assign_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oMobileGoWirelessDetail.assign_date == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oMobileGoWirelessDetail.assign_date; }
                _oPar = x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oMobileGoWirelessDetail.order_id == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oMobileGoWirelessDetail.order_id; }
                _oPar = x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oMobileGoWirelessDetail.ddate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oMobileGoWirelessDetail.ddate; }
                _oPar = x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar, 50);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oMobileGoWirelessDetail.did == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oMobileGoWirelessDetail.did; }
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

        #region INSERT_MOBILEGOWIRELESSDETAIL Store Procedures
        ///-- =============================================
        ///-- Author:		<Author,Philip SW>
        ///-- Create date: <Create Date 2009-11-17>
        ///-- Description:	<Description,MOBILEGOWIRELESSDETAIL, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_MOBILEGOWIRELESSDETAIL Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_MOBILEGOWIRELESSDETAIL', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_MOBILEGOWIRELESSDETAIL;
        GO
        CREATE PROCEDURE INSERT_MOBILEGOWIRELESSDETAIL
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @cid nvarchar(50),
        @cdate datetime,
        @assign bit,
        @mrt_no int,
        @active bit,
        @assign_staff nvarchar(50),
        @assign_date datetime,
        @order_id int,
        @ddate datetime,
        @did nvarchar(50)
        AS
        
        INSERT INTO  [MobileGoWirelessDetail]   ([cid],[cdate],[assign],[mrt_no],[active],[assign_staff],[assign_date],[order_id],[ddate],[did])  VALUES  (@cid,@cdate,@assign,@mrt_no,@active,@assign_staff,@assign_date,@order_id,@ddate,@did)
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
            string _sQuery = "DELETE FROM  [MobileGoWirelessDetail]  WHERE [MobileGoWirelessDetail].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileGoWirelessDetail]", "[" + Configurator.MSSQLTablePrefix + "MobileGoWirelessDetail]"); }
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
            return MobileGoWirelessDetailRepositoryBase.DeleteAll(n_oDB);
        }

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "DELETE FROM  [MobileGoWirelessDetail]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileGoWirelessDetail]", "[" + Configurator.MSSQLTablePrefix + "MobileGoWirelessDetail]"); }
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
            string _sQuery = "DELETE FROM [MobileGoWirelessDetail]" + x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileGoWirelessDetail]", "[" + Configurator.MSSQLTablePrefix + "MobileGoWirelessDetail]"); }
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

