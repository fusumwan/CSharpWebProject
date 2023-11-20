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
///-- Description:	<Description,Table :[EventMsgDetail],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [EventMsgDetail] Insert / list / delete manager layer
    /// </summary>

    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name = Configurator.MSSQLTablePrefix + "EventMsgDetail")]
    public class EventMsgDetailRepositoryBase : global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable
    {

        #region Instance
        private static EventMsgDetailRepositoryBase instance;
        public static EventMsgDetailRepositoryBase Instance()
        {
            if (instance == null)
            {
                MSSQLConnect _oDB = new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new EventMsgDetailRepositoryBase(_oDB);
            }
            return instance;
        }
        public static EventMsgDetailRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if (instance == null)
                instance = new EventMsgDetailRepositoryBase(x_oDB);
            return instance;
        }
        #endregion

        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<EventMsgDetailEntity> EventMsgDetails;
        #endregion

        #region Constructor
        public EventMsgDetailRepositoryBase(MSSQLConnect x_oDB)
            : base(x_oDB.ConnectionStr)
        {
            n_oDB = x_oDB;
        }
        ~EventMsgDetailRepositoryBase()
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
        public static EventMsgDetail CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new EventMsgDetail(_oDB);
        }

        public static EventMsgDetail CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new EventMsgDetail(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [EventMsgDetail]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[EventMsgDetail]", "[" + Configurator.MSSQLTablePrefix + "EventMsgDetail]"); }
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


        public EventMsgDetailEntity GetObj(global::System.Nullable<int> x_iMid)
        {
            return GetObj(n_oDB, x_iMid);
        }


        public static EventMsgDetailEntity GetObj(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            if (x_oDB == null) { return null; }
            EventMsgDetail _EventMsgDetail = (EventMsgDetail)EventMsgDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_EventMsgDetail.Load(x_iMid)) { return null; }
            return _EventMsgDetail;
        }



        public static EventMsgDetailEntity[] GetArrayObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            List<EventMsgDetailEntity> _oEventMsgDetailList = GetListObj(x_oDB, 0, "mid", x_oArrayItemId);
            return _oEventMsgDetailList.Count == 0 ? null : _oEventMsgDetailList.ToArray();
        }

        public static List<EventMsgDetailEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB, 0, "mid", x_oArrayItemId);
        }


        public static EventMsgDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<EventMsgDetailEntity> _oEventMsgDetailList = GetListObj(x_oDB, 0, x_oColumnName, x_oArrayItemId);
            return _oEventMsgDetailList.Count == 0 ? null : _oEventMsgDetailList.ToArray();
        }


        public static EventMsgDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<EventMsgDetailEntity> _oEventMsgDetailList = GetListObj(x_oDB, x_iTop, x_oColumnName, x_oArrayItemId);
            return _oEventMsgDetailList.Count == 0 ? null : _oEventMsgDetailList.ToArray();
        }

        public static List<EventMsgDetailEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB == null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            List<EventMsgDetailEntity> _oRow = new List<EventMsgDetailEntity>();
            string _sQuery = "SELECT  " + _sTop + " [EventMsgDetail].[cdate] AS EVENTMSGDETAIL_CDATE,[EventMsgDetail].[active] AS EVENTMSGDETAIL_ACTIVE,[EventMsgDetail].[access_right] AS EVENTMSGDETAIL_ACCESS_RIGHT,[EventMsgDetail].[cid] AS EVENTMSGDETAIL_CID,[EventMsgDetail].[did] AS EVENTMSGDETAIL_DID,[EventMsgDetail].[message] AS EVENTMSGDETAIL_MESSAGE,[EventMsgDetail].[edate] AS EVENTMSGDETAIL_EDATE,[EventMsgDetail].[subject] AS EVENTMSGDETAIL_SUBJECT,[EventMsgDetail].[ddate] AS EVENTMSGDETAIL_DDATE,[EventMsgDetail].[mid] AS EVENTMSGDETAIL_MID,[EventMsgDetail].[sdate] AS EVENTMSGDETAIL_SDATE  FROM  [EventMsgDetail]";
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
                _sQuery += " WHERE [EventMsgDetail].[" + x_oColumnName.ToString() + "]  in " + _oList;
            }

            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[EventMsgDetail]", "[" + Configurator.MSSQLTablePrefix + "EventMsgDetail]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        EventMsgDetail _oEventMsgDetail = EventMsgDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_CDATE"])) { _oEventMsgDetail.cdate = (global::System.Nullable<DateTime>)_oData["EVENTMSGDETAIL_CDATE"]; } else { _oEventMsgDetail.cdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_ACTIVE"])) { _oEventMsgDetail.active = (global::System.Nullable<bool>)_oData["EVENTMSGDETAIL_ACTIVE"]; } else { _oEventMsgDetail.active = null; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_ACCESS_RIGHT"])) { _oEventMsgDetail.access_right = (string)_oData["EVENTMSGDETAIL_ACCESS_RIGHT"]; } else { _oEventMsgDetail.access_right = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_CID"])) { _oEventMsgDetail.cid = (string)_oData["EVENTMSGDETAIL_CID"]; } else { _oEventMsgDetail.cid = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_DID"])) { _oEventMsgDetail.did = (string)_oData["EVENTMSGDETAIL_DID"]; } else { _oEventMsgDetail.did = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_MESSAGE"])) { _oEventMsgDetail.message = (string)_oData["EVENTMSGDETAIL_MESSAGE"]; } else { _oEventMsgDetail.message = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_EDATE"])) { _oEventMsgDetail.edate = (global::System.Nullable<DateTime>)_oData["EVENTMSGDETAIL_EDATE"]; } else { _oEventMsgDetail.edate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_SUBJECT"])) { _oEventMsgDetail.subject = (string)_oData["EVENTMSGDETAIL_SUBJECT"]; } else { _oEventMsgDetail.subject = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_DDATE"])) { _oEventMsgDetail.ddate = (global::System.Nullable<DateTime>)_oData["EVENTMSGDETAIL_DDATE"]; } else { _oEventMsgDetail.ddate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_MID"])) { _oEventMsgDetail.mid = (global::System.Nullable<int>)_oData["EVENTMSGDETAIL_MID"]; } else { _oEventMsgDetail.mid = null; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_SDATE"])) { _oEventMsgDetail.sdate = (global::System.Nullable<DateTime>)_oData["EVENTMSGDETAIL_SDATE"]; } else { _oEventMsgDetail.sdate = null; }
                        _oEventMsgDetail.SetDB(x_oDB);
                        _oEventMsgDetail.GetFound();
                        _oRow.Add(_oEventMsgDetail);
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


        public static EventMsgDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<EventMsgDetailEntity> _oEventMsgDetailList = GetListObj(x_oDB, 0, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oEventMsgDetailList.Count == 0 ? null : _oEventMsgDetailList.ToArray();
        }


        public static EventMsgDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<EventMsgDetailEntity> _oEventMsgDetailList = GetListObj(x_oDB, x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oEventMsgDetailList.Count == 0 ? null : _oEventMsgDetailList.ToArray();
        }

        public static List<EventMsgDetailEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB == null) { return null; }
            List<EventMsgDetailEntity> _oRow = new List<EventMsgDetailEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            string _sFields = "[EventMsgDetail].[cdate] AS EVENTMSGDETAIL_CDATE,[EventMsgDetail].[active] AS EVENTMSGDETAIL_ACTIVE,[EventMsgDetail].[access_right] AS EVENTMSGDETAIL_ACCESS_RIGHT,[EventMsgDetail].[cid] AS EVENTMSGDETAIL_CID,[EventMsgDetail].[did] AS EVENTMSGDETAIL_DID,[EventMsgDetail].[message] AS EVENTMSGDETAIL_MESSAGE,[EventMsgDetail].[edate] AS EVENTMSGDETAIL_EDATE,[EventMsgDetail].[subject] AS EVENTMSGDETAIL_SUBJECT,[EventMsgDetail].[ddate] AS EVENTMSGDETAIL_DDATE,[EventMsgDetail].[mid] AS EVENTMSGDETAIL_MID,[EventMsgDetail].[sdate] AS EVENTMSGDETAIL_SDATE";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[EventMsgDetail]", "[" + Configurator.MSSQLTablePrefix + "EventMsgDetail]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = EventMsgDetailRepositoryBase.GetSearch(x_oDB, _sTop.ToString() + _sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                EventMsgDetailEntity _oEventMsgDetail = EventMsgDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_CDATE"])) { _oEventMsgDetail.cdate = (global::System.Nullable<DateTime>)_oData["EVENTMSGDETAIL_CDATE"]; } else { _oEventMsgDetail.cdate = null; }
                if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_ACTIVE"])) { _oEventMsgDetail.active = (global::System.Nullable<bool>)_oData["EVENTMSGDETAIL_ACTIVE"]; } else { _oEventMsgDetail.active = null; }
                if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_ACCESS_RIGHT"])) { _oEventMsgDetail.access_right = (string)_oData["EVENTMSGDETAIL_ACCESS_RIGHT"]; } else { _oEventMsgDetail.access_right = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_CID"])) { _oEventMsgDetail.cid = (string)_oData["EVENTMSGDETAIL_CID"]; } else { _oEventMsgDetail.cid = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_DID"])) { _oEventMsgDetail.did = (string)_oData["EVENTMSGDETAIL_DID"]; } else { _oEventMsgDetail.did = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_MESSAGE"])) { _oEventMsgDetail.message = (string)_oData["EVENTMSGDETAIL_MESSAGE"]; } else { _oEventMsgDetail.message = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_EDATE"])) { _oEventMsgDetail.edate = (global::System.Nullable<DateTime>)_oData["EVENTMSGDETAIL_EDATE"]; } else { _oEventMsgDetail.edate = null; }
                if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_SUBJECT"])) { _oEventMsgDetail.subject = (string)_oData["EVENTMSGDETAIL_SUBJECT"]; } else { _oEventMsgDetail.subject = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_DDATE"])) { _oEventMsgDetail.ddate = (global::System.Nullable<DateTime>)_oData["EVENTMSGDETAIL_DDATE"]; } else { _oEventMsgDetail.ddate = null; }
                if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_MID"])) { _oEventMsgDetail.mid = (global::System.Nullable<int>)_oData["EVENTMSGDETAIL_MID"]; } else { _oEventMsgDetail.mid = null; }
                if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_SDATE"])) { _oEventMsgDetail.sdate = (global::System.Nullable<DateTime>)_oData["EVENTMSGDETAIL_SDATE"]; } else { _oEventMsgDetail.sdate = null; }
                _oEventMsgDetail.SetDB(x_oDB);
                _oEventMsgDetail.GetFound();
                _oRow.Add(_oEventMsgDetail);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet(EventMsgDetail.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder, EventMsgDetail.Para.TableName());
            return _oDset;
        }


        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB == null) { return null; }
            return x_oDB.GetSearch(EventMsgDetail.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }


        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(EventMsgDetail.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            if (x_oDB == null) { return null; }
            string _oQuery = "SELECT   [EventMsgDetail].[cdate] AS EVENTMSGDETAIL_CDATE,[EventMsgDetail].[active] AS EVENTMSGDETAIL_ACTIVE,[EventMsgDetail].[access_right] AS EVENTMSGDETAIL_ACCESS_RIGHT,[EventMsgDetail].[cid] AS EVENTMSGDETAIL_CID,[EventMsgDetail].[did] AS EVENTMSGDETAIL_DID,[EventMsgDetail].[message] AS EVENTMSGDETAIL_MESSAGE,[EventMsgDetail].[edate] AS EVENTMSGDETAIL_EDATE,[EventMsgDetail].[subject] AS EVENTMSGDETAIL_SUBJECT,[EventMsgDetail].[ddate] AS EVENTMSGDETAIL_DDATE,[EventMsgDetail].[mid] AS EVENTMSGDETAIL_MID,[EventMsgDetail].[sdate] AS EVENTMSGDETAIL_SDATE  FROM  [EventMsgDetail]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[EventMsgDetail]", "[" + Configurator.MSSQLTablePrefix + "EventMsgDetail]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery, _oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset, "EventMsgDetail");
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

        public bool Insert(global::System.Nullable<DateTime> x_dCdate, global::System.Nullable<bool> x_bActive, string x_sAccess_right, string x_sCid, string x_sDid, string x_sMessage, global::System.Nullable<DateTime> x_dEdate, string x_sSubject, global::System.Nullable<DateTime> x_dDdate, global::System.Nullable<DateTime> x_dSdate)
        {
            EventMsgDetail _oEventMsgDetail = EventMsgDetailRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oEventMsgDetail.cdate = x_dCdate;
            _oEventMsgDetail.active = x_bActive;
            _oEventMsgDetail.access_right = x_sAccess_right;
            _oEventMsgDetail.cid = x_sCid;
            _oEventMsgDetail.did = x_sDid;
            _oEventMsgDetail.message = x_sMessage;
            _oEventMsgDetail.edate = x_dEdate;
            _oEventMsgDetail.subject = x_sSubject;
            _oEventMsgDetail.ddate = x_dDdate;
            _oEventMsgDetail.sdate = x_dSdate;
            return InsertWithOutLastID(n_oDB, _oEventMsgDetail);
        }


        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate, global::System.Nullable<bool> x_bActive, string x_sAccess_right, string x_sCid, string x_sDid, string x_sMessage, global::System.Nullable<DateTime> x_dEdate, string x_sSubject, global::System.Nullable<DateTime> x_dDdate, global::System.Nullable<DateTime> x_dSdate)
        {
            EventMsgDetail _oEventMsgDetail = EventMsgDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oEventMsgDetail.cdate = x_dCdate;
            _oEventMsgDetail.active = x_bActive;
            _oEventMsgDetail.access_right = x_sAccess_right;
            _oEventMsgDetail.cid = x_sCid;
            _oEventMsgDetail.did = x_sDid;
            _oEventMsgDetail.message = x_sMessage;
            _oEventMsgDetail.edate = x_dEdate;
            _oEventMsgDetail.subject = x_sSubject;
            _oEventMsgDetail.ddate = x_dDdate;
            _oEventMsgDetail.sdate = x_dSdate;
            return InsertWithOutLastID(x_oDB, _oEventMsgDetail);
        }


        public bool Insert(EventMsgDetail x_oEventMsgDetail)
        {
            return InsertWithOutLastID(n_oDB, x_oEventMsgDetail);
        }


        public bool InsertEntity(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is EventMsgDetail)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (EventMsgDetail)x_oObj);
        }


        public static bool Insert(MSSQLConnect x_oDB, EventMsgDetail x_oEventMsgDetail)
        {
            return InsertWithOutLastID(x_oDB, x_oEventMsgDetail);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, EventMsgDetail x_oEventMsgDetail)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT INTO  [EventMsgDetail]   ([cdate],[active],[access_right],[cid],[did],[message],[edate],[subject],[ddate],[sdate])  VALUES  (@cdate,@active,@access_right,@cid,@did,@message,@edate,@subject,@ddate,@sdate)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[EventMsgDetail]", "[" + Configurator.MSSQLTablePrefix + "EventMsgDetail]"); }
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
            return InsertTransactionWithOutLastID(x_oDB, _oConn, _oCmd, x_oEventMsgDetail);
        }

        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, EventMsgDetail x_oEventMsgDetail)
        {
            bool _bResult = false;
            if (!x_oEventMsgDetail.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if (x_oEventMsgDetail.cdate == null) { x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = x_oEventMsgDetail.cdate; }
                if (x_oEventMsgDetail.active == null) { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = x_oEventMsgDetail.active; }
                if (x_oEventMsgDetail.access_right == null) { x_oCmd.Parameters.Add("@access_right", global::System.Data.SqlDbType.NVarChar, 100).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@access_right", global::System.Data.SqlDbType.NVarChar, 100).Value = x_oEventMsgDetail.access_right; }
                if (x_oEventMsgDetail.cid == null) { x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10).Value = x_oEventMsgDetail.cid; }
                if (x_oEventMsgDetail.did == null) { x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10).Value = x_oEventMsgDetail.did; }
                if (x_oEventMsgDetail.message == null) { x_oCmd.Parameters.Add("@message", global::System.Data.SqlDbType.Text).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@message", global::System.Data.SqlDbType.Text).Value = x_oEventMsgDetail.message; }
                if (x_oEventMsgDetail.edate == null) { x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = x_oEventMsgDetail.edate; }
                if (x_oEventMsgDetail.subject == null) { x_oCmd.Parameters.Add("@subject", global::System.Data.SqlDbType.NVarChar, 250).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@subject", global::System.Data.SqlDbType.NVarChar, 250).Value = x_oEventMsgDetail.subject; }
                if (x_oEventMsgDetail.ddate == null) { x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = x_oEventMsgDetail.ddate; }
                if (x_oEventMsgDetail.sdate == null) { x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = x_oEventMsgDetail.sdate; }
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


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate, global::System.Nullable<bool> x_bActive, string x_sAccess_right, string x_sCid, string x_sDid, string x_sMessage, global::System.Nullable<DateTime> x_dEdate, string x_sSubject, global::System.Nullable<DateTime> x_dDdate, global::System.Nullable<DateTime> x_dSdate)
        {
            int _oLastID;
            EventMsgDetail _oEventMsgDetail = EventMsgDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oEventMsgDetail.cdate = x_dCdate;
            _oEventMsgDetail.active = x_bActive;
            _oEventMsgDetail.access_right = x_sAccess_right;
            _oEventMsgDetail.cid = x_sCid;
            _oEventMsgDetail.did = x_sDid;
            _oEventMsgDetail.message = x_sMessage;
            _oEventMsgDetail.edate = x_dEdate;
            _oEventMsgDetail.subject = x_sSubject;
            _oEventMsgDetail.ddate = x_dDdate;
            _oEventMsgDetail.sdate = x_dSdate;
            if (InsertWithLastID_SP(x_oDB, _oEventMsgDetail, out _oLastID))
            {
                return _oLastID;
            }
            else
            {
                return -1;
            }
        }


        public int InsertReturnLastID_SP(EventMsgDetail x_oEventMsgDetail)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oEventMsgDetail, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, EventMsgDetail x_oEventMsgDetail)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oEventMsgDetail, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is EventMsgDetail)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (EventMsgDetail)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB, EventMsgDetail x_oEventMsgDetail, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "EVENTMSGDETAIL";
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
            return InsertTransactionWithLastID_SP(x_oDB, _oConn, _oCmd, x_oEventMsgDetail, out x_oLAST_ID);
        }

        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, EventMsgDetail x_oEventMsgDetail, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar = x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oEventMsgDetail.cdate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oEventMsgDetail.cdate; }
                _oPar = x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oEventMsgDetail.active == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oEventMsgDetail.active; }
                _oPar = x_oCmd.Parameters.Add("@access_right", global::System.Data.SqlDbType.NVarChar, 100);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oEventMsgDetail.access_right == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oEventMsgDetail.access_right; }
                _oPar = x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oEventMsgDetail.cid == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oEventMsgDetail.cid; }
                _oPar = x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oEventMsgDetail.did == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oEventMsgDetail.did; }
                _oPar = x_oCmd.Parameters.Add("@message", global::System.Data.SqlDbType.Text);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oEventMsgDetail.message == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oEventMsgDetail.message; }
                _oPar = x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oEventMsgDetail.edate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oEventMsgDetail.edate; }
                _oPar = x_oCmd.Parameters.Add("@subject", global::System.Data.SqlDbType.NVarChar, 250);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oEventMsgDetail.subject == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oEventMsgDetail.subject; }
                _oPar = x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oEventMsgDetail.ddate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oEventMsgDetail.ddate; }
                _oPar = x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oEventMsgDetail.sdate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oEventMsgDetail.sdate; }
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

        #region INSERT_EVENTMSGDETAIL Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2009-11-17>
        ///-- Description:	<Description,EVENTMSGDETAIL, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_EVENTMSGDETAIL Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_EVENTMSGDETAIL', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_EVENTMSGDETAIL;
        GO
        CREATE PROCEDURE INSERT_EVENTMSGDETAIL
        	-- Add the parameters for the stored procedure here
        @RETURN_MID int output,
        @cdate datetime,
        @active bit,
        @access_right nvarchar(100),
        @cid char(10),
        @did char(10),
        @message text,
        @edate datetime,
        @subject nvarchar(250),
        @ddate datetime,
        @sdate datetime
        AS
        
        INSERT INTO  [EventMsgDetail]   ([cdate],[active],[access_right],[cid],[did],[message],[edate],[subject],[ddate],[sdate])  VALUES  (@cdate,@active,@access_right,@cid,@did,@message,@edate,@subject,@ddate,@sdate)
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
            string _sQuery = "DELETE FROM  [EventMsgDetail]  WHERE [EventMsgDetail].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[EventMsgDetail]", "[" + Configurator.MSSQLTablePrefix + "EventMsgDetail]"); }
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
            return EventMsgDetailRepositoryBase.DeleteAll(n_oDB);
        }

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "DELETE FROM  [EventMsgDetail]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[EventMsgDetail]", "[" + Configurator.MSSQLTablePrefix + "EventMsgDetail]"); }
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
            string _sQuery = "DELETE FROM [EventMsgDetail]" + x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[EventMsgDetail]", "[" + Configurator.MSSQLTablePrefix + "EventMsgDetail]"); }
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

