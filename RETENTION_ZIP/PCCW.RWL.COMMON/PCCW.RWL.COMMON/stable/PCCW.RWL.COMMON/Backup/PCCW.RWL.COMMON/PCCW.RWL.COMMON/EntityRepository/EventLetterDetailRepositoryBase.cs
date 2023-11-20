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
///-- Description:	<Description,Table :[EventLetterDetail],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [EventLetterDetail] Insert / list / delete manager layer
    /// </summary>

    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name = Configurator.MSSQLTablePrefix + "EventLetterDetail")]
    public class EventLetterDetailRepositoryBase : global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable
    {

        #region Instance
        private static EventLetterDetailRepositoryBase instance;
        public static EventLetterDetailRepositoryBase Instance()
        {
            if (instance == null)
            {
                MSSQLConnect _oDB = new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new EventLetterDetailRepositoryBase(_oDB);
            }
            return instance;
        }
        public static EventLetterDetailRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if (instance == null)
                instance = new EventLetterDetailRepositoryBase(x_oDB);
            return instance;
        }
        #endregion

        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<EventLetterDetailEntity> EventLetterDetails;
        #endregion

        #region Constructor
        public EventLetterDetailRepositoryBase(MSSQLConnect x_oDB)
            : base(x_oDB.ConnectionStr)
        {
            n_oDB = x_oDB;
        }
        ~EventLetterDetailRepositoryBase()
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
        public static EventLetterDetail CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new EventLetterDetail(_oDB);
        }

        public static EventLetterDetail CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new EventLetterDetail(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [EventLetterDetail]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[EventLetterDetail]", "[" + Configurator.MSSQLTablePrefix + "EventLetterDetail]"); }
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


        public EventLetterDetailEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }


        public static EventLetterDetailEntity GetObj(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            if (x_oDB == null) { return null; }
            EventLetterDetail _EventLetterDetail = (EventLetterDetail)EventLetterDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_EventLetterDetail.Load(x_iId)) { return null; }
            return _EventLetterDetail;
        }



        public static EventLetterDetailEntity[] GetArrayObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            List<EventLetterDetailEntity> _oEventLetterDetailList = GetListObj(x_oDB, 0, "id", x_oArrayItemId);
            return _oEventLetterDetailList.Count == 0 ? null : _oEventLetterDetailList.ToArray();
        }

        public static List<EventLetterDetailEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB, 0, "id", x_oArrayItemId);
        }


        public static EventLetterDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<EventLetterDetailEntity> _oEventLetterDetailList = GetListObj(x_oDB, 0, x_oColumnName, x_oArrayItemId);
            return _oEventLetterDetailList.Count == 0 ? null : _oEventLetterDetailList.ToArray();
        }


        public static EventLetterDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<EventLetterDetailEntity> _oEventLetterDetailList = GetListObj(x_oDB, x_iTop, x_oColumnName, x_oArrayItemId);
            return _oEventLetterDetailList.Count == 0 ? null : _oEventLetterDetailList.ToArray();
        }

        public static List<EventLetterDetailEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB == null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            List<EventLetterDetailEntity> _oRow = new List<EventLetterDetailEntity>();
            string _sQuery = "SELECT  " + _sTop + " [EventLetterDetail].[id] AS EVENTLETTERDETAIL_ID,[EventLetterDetail].[cdate] AS EVENTLETTERDETAIL_CDATE,[EventLetterDetail].[cid] AS EVENTLETTERDETAIL_CID,[EventLetterDetail].[accnt_cd] AS EVENTLETTERDETAIL_ACCNT_CD,[EventLetterDetail].[mob_num] AS EVENTLETTERDETAIL_MOB_NUM,[EventLetterDetail].[doc_id] AS EVENTLETTERDETAIL_DOC_ID,[EventLetterDetail].[active] AS EVENTLETTERDETAIL_ACTIVE,[EventLetterDetail].[name] AS EVENTLETTERDETAIL_NAME,[EventLetterDetail].[Remarks] AS EVENTLETTERDETAIL_REMARKS,[EventLetterDetail].[prem_desc] AS EVENTLETTERDETAIL_PREM_DESC,[EventLetterDetail].[lett_sent_date] AS EVENTLETTERDETAIL_LETT_SENT_DATE  FROM  [EventLetterDetail]";
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
                _sQuery += " WHERE [EventLetterDetail].[" + x_oColumnName.ToString() + "]  in " + _oList;
            }

            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[EventLetterDetail]", "[" + Configurator.MSSQLTablePrefix + "EventLetterDetail]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        EventLetterDetail _oEventLetterDetail = EventLetterDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_ID"])) { _oEventLetterDetail.id = (global::System.Nullable<int>)_oData["EVENTLETTERDETAIL_ID"]; } else { _oEventLetterDetail.id = null; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_CDATE"])) { _oEventLetterDetail.cdate = (global::System.Nullable<DateTime>)_oData["EVENTLETTERDETAIL_CDATE"]; } else { _oEventLetterDetail.cdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_CID"])) { _oEventLetterDetail.cid = (string)_oData["EVENTLETTERDETAIL_CID"]; } else { _oEventLetterDetail.cid = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_ACTIVE"])) { _oEventLetterDetail.active = (global::System.Nullable<bool>)_oData["EVENTLETTERDETAIL_ACTIVE"]; } else { _oEventLetterDetail.active = null; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_MOB_NUM"])) { _oEventLetterDetail.mob_num = (string)_oData["EVENTLETTERDETAIL_MOB_NUM"]; } else { _oEventLetterDetail.mob_num = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_DOC_ID"])) { _oEventLetterDetail.doc_id = (string)_oData["EVENTLETTERDETAIL_DOC_ID"]; } else { _oEventLetterDetail.doc_id = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_NAME"])) { _oEventLetterDetail.name = (string)_oData["EVENTLETTERDETAIL_NAME"]; } else { _oEventLetterDetail.name = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_PREM_DESC"])) { _oEventLetterDetail.prem_desc = (string)_oData["EVENTLETTERDETAIL_PREM_DESC"]; } else { _oEventLetterDetail.prem_desc = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_REMARKS"])) { _oEventLetterDetail.Remarks = (string)_oData["EVENTLETTERDETAIL_REMARKS"]; } else { _oEventLetterDetail.Remarks = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_ACCNT_CD"])) { _oEventLetterDetail.accnt_cd = (string)_oData["EVENTLETTERDETAIL_ACCNT_CD"]; } else { _oEventLetterDetail.accnt_cd = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_LETT_SENT_DATE"])) { _oEventLetterDetail.lett_sent_date = (string)_oData["EVENTLETTERDETAIL_LETT_SENT_DATE"]; } else { _oEventLetterDetail.lett_sent_date = global::System.String.Empty; }
                        _oEventLetterDetail.SetDB(x_oDB);
                        _oEventLetterDetail.GetFound();
                        _oRow.Add(_oEventLetterDetail);
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


        public static EventLetterDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<EventLetterDetailEntity> _oEventLetterDetailList = GetListObj(x_oDB, 0, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oEventLetterDetailList.Count == 0 ? null : _oEventLetterDetailList.ToArray();
        }


        public static EventLetterDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<EventLetterDetailEntity> _oEventLetterDetailList = GetListObj(x_oDB, x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oEventLetterDetailList.Count == 0 ? null : _oEventLetterDetailList.ToArray();
        }

        public static List<EventLetterDetailEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB == null) { return null; }
            List<EventLetterDetailEntity> _oRow = new List<EventLetterDetailEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            string _sFields = "[EventLetterDetail].[id] AS EVENTLETTERDETAIL_ID,[EventLetterDetail].[cdate] AS EVENTLETTERDETAIL_CDATE,[EventLetterDetail].[cid] AS EVENTLETTERDETAIL_CID,[EventLetterDetail].[accnt_cd] AS EVENTLETTERDETAIL_ACCNT_CD,[EventLetterDetail].[mob_num] AS EVENTLETTERDETAIL_MOB_NUM,[EventLetterDetail].[doc_id] AS EVENTLETTERDETAIL_DOC_ID,[EventLetterDetail].[active] AS EVENTLETTERDETAIL_ACTIVE,[EventLetterDetail].[name] AS EVENTLETTERDETAIL_NAME,[EventLetterDetail].[Remarks] AS EVENTLETTERDETAIL_REMARKS,[EventLetterDetail].[prem_desc] AS EVENTLETTERDETAIL_PREM_DESC,[EventLetterDetail].[lett_sent_date] AS EVENTLETTERDETAIL_LETT_SENT_DATE";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[EventLetterDetail]", "[" + Configurator.MSSQLTablePrefix + "EventLetterDetail]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = EventLetterDetailRepositoryBase.GetSearch(x_oDB, _sTop.ToString() + _sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                EventLetterDetailEntity _oEventLetterDetail = EventLetterDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_ID"])) { _oEventLetterDetail.id = (global::System.Nullable<int>)_oData["EVENTLETTERDETAIL_ID"]; } else { _oEventLetterDetail.id = null; }
                if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_CDATE"])) { _oEventLetterDetail.cdate = (global::System.Nullable<DateTime>)_oData["EVENTLETTERDETAIL_CDATE"]; } else { _oEventLetterDetail.cdate = null; }
                if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_CID"])) { _oEventLetterDetail.cid = (string)_oData["EVENTLETTERDETAIL_CID"]; } else { _oEventLetterDetail.cid = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_ACTIVE"])) { _oEventLetterDetail.active = (global::System.Nullable<bool>)_oData["EVENTLETTERDETAIL_ACTIVE"]; } else { _oEventLetterDetail.active = null; }
                if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_MOB_NUM"])) { _oEventLetterDetail.mob_num = (string)_oData["EVENTLETTERDETAIL_MOB_NUM"]; } else { _oEventLetterDetail.mob_num = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_DOC_ID"])) { _oEventLetterDetail.doc_id = (string)_oData["EVENTLETTERDETAIL_DOC_ID"]; } else { _oEventLetterDetail.doc_id = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_NAME"])) { _oEventLetterDetail.name = (string)_oData["EVENTLETTERDETAIL_NAME"]; } else { _oEventLetterDetail.name = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_PREM_DESC"])) { _oEventLetterDetail.prem_desc = (string)_oData["EVENTLETTERDETAIL_PREM_DESC"]; } else { _oEventLetterDetail.prem_desc = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_REMARKS"])) { _oEventLetterDetail.Remarks = (string)_oData["EVENTLETTERDETAIL_REMARKS"]; } else { _oEventLetterDetail.Remarks = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_ACCNT_CD"])) { _oEventLetterDetail.accnt_cd = (string)_oData["EVENTLETTERDETAIL_ACCNT_CD"]; } else { _oEventLetterDetail.accnt_cd = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_LETT_SENT_DATE"])) { _oEventLetterDetail.lett_sent_date = (string)_oData["EVENTLETTERDETAIL_LETT_SENT_DATE"]; } else { _oEventLetterDetail.lett_sent_date = global::System.String.Empty; }
                _oEventLetterDetail.SetDB(x_oDB);
                _oEventLetterDetail.GetFound();
                _oRow.Add(_oEventLetterDetail);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet(EventLetterDetail.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder, EventLetterDetail.Para.TableName());
            return _oDset;
        }


        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB == null) { return null; }
            return x_oDB.GetSearch(EventLetterDetail.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }


        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(EventLetterDetail.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            if (x_oDB == null) { return null; }
            string _oQuery = "SELECT   [EventLetterDetail].[id] AS EVENTLETTERDETAIL_ID,[EventLetterDetail].[cdate] AS EVENTLETTERDETAIL_CDATE,[EventLetterDetail].[cid] AS EVENTLETTERDETAIL_CID,[EventLetterDetail].[accnt_cd] AS EVENTLETTERDETAIL_ACCNT_CD,[EventLetterDetail].[mob_num] AS EVENTLETTERDETAIL_MOB_NUM,[EventLetterDetail].[doc_id] AS EVENTLETTERDETAIL_DOC_ID,[EventLetterDetail].[active] AS EVENTLETTERDETAIL_ACTIVE,[EventLetterDetail].[name] AS EVENTLETTERDETAIL_NAME,[EventLetterDetail].[Remarks] AS EVENTLETTERDETAIL_REMARKS,[EventLetterDetail].[prem_desc] AS EVENTLETTERDETAIL_PREM_DESC,[EventLetterDetail].[lett_sent_date] AS EVENTLETTERDETAIL_LETT_SENT_DATE  FROM  [EventLetterDetail]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[EventLetterDetail]", "[" + Configurator.MSSQLTablePrefix + "EventLetterDetail]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery, _oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset, "EventLetterDetail");
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

        public bool Insert(global::System.Nullable<DateTime> x_dCdate, string x_sCid, global::System.Nullable<bool> x_bActive, string x_sMob_num, string x_sDoc_id, string x_sName, string x_sPrem_desc, string x_sRemarks, string x_sAccnt_cd, string x_sLett_sent_date)
        {
            EventLetterDetail _oEventLetterDetail = EventLetterDetailRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oEventLetterDetail.cdate = x_dCdate;
            _oEventLetterDetail.cid = x_sCid;
            _oEventLetterDetail.active = x_bActive;
            _oEventLetterDetail.mob_num = x_sMob_num;
            _oEventLetterDetail.doc_id = x_sDoc_id;
            _oEventLetterDetail.name = x_sName;
            _oEventLetterDetail.prem_desc = x_sPrem_desc;
            _oEventLetterDetail.Remarks = x_sRemarks;
            _oEventLetterDetail.accnt_cd = x_sAccnt_cd;
            _oEventLetterDetail.lett_sent_date = x_sLett_sent_date;
            return InsertWithOutLastID(n_oDB, _oEventLetterDetail);
        }


        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate, string x_sCid, global::System.Nullable<bool> x_bActive, string x_sMob_num, string x_sDoc_id, string x_sName, string x_sPrem_desc, string x_sRemarks, string x_sAccnt_cd, string x_sLett_sent_date)
        {
            EventLetterDetail _oEventLetterDetail = EventLetterDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oEventLetterDetail.cdate = x_dCdate;
            _oEventLetterDetail.cid = x_sCid;
            _oEventLetterDetail.active = x_bActive;
            _oEventLetterDetail.mob_num = x_sMob_num;
            _oEventLetterDetail.doc_id = x_sDoc_id;
            _oEventLetterDetail.name = x_sName;
            _oEventLetterDetail.prem_desc = x_sPrem_desc;
            _oEventLetterDetail.Remarks = x_sRemarks;
            _oEventLetterDetail.accnt_cd = x_sAccnt_cd;
            _oEventLetterDetail.lett_sent_date = x_sLett_sent_date;
            return InsertWithOutLastID(x_oDB, _oEventLetterDetail);
        }


        public bool Insert(EventLetterDetail x_oEventLetterDetail)
        {
            return InsertWithOutLastID(n_oDB, x_oEventLetterDetail);
        }


        public bool InsertEntity(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is EventLetterDetail)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (EventLetterDetail)x_oObj);
        }


        public static bool Insert(MSSQLConnect x_oDB, EventLetterDetail x_oEventLetterDetail)
        {
            return InsertWithOutLastID(x_oDB, x_oEventLetterDetail);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, EventLetterDetail x_oEventLetterDetail)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT INTO  [EventLetterDetail]   ([cdate],[cid],[accnt_cd],[mob_num],[doc_id],[active],[name],[Remarks],[prem_desc],[lett_sent_date])  VALUES  (@cdate,@cid,@accnt_cd,@mob_num,@doc_id,@active,@name,@Remarks,@prem_desc,@lett_sent_date)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[EventLetterDetail]", "[" + Configurator.MSSQLTablePrefix + "EventLetterDetail]"); }
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
            return InsertTransactionWithOutLastID(x_oDB, _oConn, _oCmd, x_oEventLetterDetail);
        }

        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, EventLetterDetail x_oEventLetterDetail)
        {
            bool _bResult = false;
            if (!x_oEventLetterDetail.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if (x_oEventLetterDetail.cdate == null) { x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = x_oEventLetterDetail.cdate; }
                if (x_oEventLetterDetail.cid == null) { x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10).Value = x_oEventLetterDetail.cid; }
                if (x_oEventLetterDetail.accnt_cd == null) { x_oCmd.Parameters.Add("@accnt_cd", global::System.Data.SqlDbType.NVarChar, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@accnt_cd", global::System.Data.SqlDbType.NVarChar, 10).Value = x_oEventLetterDetail.accnt_cd; }
                if (x_oEventLetterDetail.mob_num == null) { x_oCmd.Parameters.Add("@mob_num", global::System.Data.SqlDbType.Char, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@mob_num", global::System.Data.SqlDbType.Char, 10).Value = x_oEventLetterDetail.mob_num; }
                if (x_oEventLetterDetail.doc_id == null) { x_oCmd.Parameters.Add("@doc_id", global::System.Data.SqlDbType.Char, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@doc_id", global::System.Data.SqlDbType.Char, 10).Value = x_oEventLetterDetail.doc_id; }
                if (x_oEventLetterDetail.active == null) { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = x_oEventLetterDetail.active; }
                if (x_oEventLetterDetail.name == null) { x_oCmd.Parameters.Add("@name", global::System.Data.SqlDbType.NVarChar, 250).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@name", global::System.Data.SqlDbType.NVarChar, 250).Value = x_oEventLetterDetail.name; }
                if (x_oEventLetterDetail.Remarks == null) { x_oCmd.Parameters.Add("@Remarks", global::System.Data.SqlDbType.NVarChar, 250).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@Remarks", global::System.Data.SqlDbType.NVarChar, 250).Value = x_oEventLetterDetail.Remarks; }
                if (x_oEventLetterDetail.prem_desc == null) { x_oCmd.Parameters.Add("@prem_desc", global::System.Data.SqlDbType.NVarChar, 250).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@prem_desc", global::System.Data.SqlDbType.NVarChar, 250).Value = x_oEventLetterDetail.prem_desc; }
                if (x_oEventLetterDetail.lett_sent_date == null) { x_oCmd.Parameters.Add("@lett_sent_date", global::System.Data.SqlDbType.NVarChar, 20).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@lett_sent_date", global::System.Data.SqlDbType.NVarChar, 20).Value = x_oEventLetterDetail.lett_sent_date; }
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


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate, string x_sCid, global::System.Nullable<bool> x_bActive, string x_sMob_num, string x_sDoc_id, string x_sName, string x_sPrem_desc, string x_sRemarks, string x_sAccnt_cd, string x_sLett_sent_date)
        {
            int _oLastID;
            EventLetterDetail _oEventLetterDetail = EventLetterDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oEventLetterDetail.cdate = x_dCdate;
            _oEventLetterDetail.cid = x_sCid;
            _oEventLetterDetail.active = x_bActive;
            _oEventLetterDetail.mob_num = x_sMob_num;
            _oEventLetterDetail.doc_id = x_sDoc_id;
            _oEventLetterDetail.name = x_sName;
            _oEventLetterDetail.prem_desc = x_sPrem_desc;
            _oEventLetterDetail.Remarks = x_sRemarks;
            _oEventLetterDetail.accnt_cd = x_sAccnt_cd;
            _oEventLetterDetail.lett_sent_date = x_sLett_sent_date;
            if (InsertWithLastID_SP(x_oDB, _oEventLetterDetail, out _oLastID))
            {
                return _oLastID;
            }
            else
            {
                return -1;
            }
        }


        public int InsertReturnLastID_SP(EventLetterDetail x_oEventLetterDetail)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oEventLetterDetail, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, EventLetterDetail x_oEventLetterDetail)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oEventLetterDetail, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is EventLetterDetail)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (EventLetterDetail)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB, EventLetterDetail x_oEventLetterDetail, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "EVENTLETTERDETAIL";
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
            return InsertTransactionWithLastID_SP(x_oDB, _oConn, _oCmd, x_oEventLetterDetail, out x_oLAST_ID);
        }

        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, EventLetterDetail x_oEventLetterDetail, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar = x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oEventLetterDetail.cdate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oEventLetterDetail.cdate; }
                _oPar = x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oEventLetterDetail.cid == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oEventLetterDetail.cid; }
                _oPar = x_oCmd.Parameters.Add("@accnt_cd", global::System.Data.SqlDbType.NVarChar, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oEventLetterDetail.accnt_cd == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oEventLetterDetail.accnt_cd; }
                _oPar = x_oCmd.Parameters.Add("@mob_num", global::System.Data.SqlDbType.Char, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oEventLetterDetail.mob_num == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oEventLetterDetail.mob_num; }
                _oPar = x_oCmd.Parameters.Add("@doc_id", global::System.Data.SqlDbType.Char, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oEventLetterDetail.doc_id == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oEventLetterDetail.doc_id; }
                _oPar = x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oEventLetterDetail.active == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oEventLetterDetail.active; }
                _oPar = x_oCmd.Parameters.Add("@name", global::System.Data.SqlDbType.NVarChar, 250);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oEventLetterDetail.name == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oEventLetterDetail.name; }
                _oPar = x_oCmd.Parameters.Add("@Remarks", global::System.Data.SqlDbType.NVarChar, 250);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oEventLetterDetail.Remarks == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oEventLetterDetail.Remarks; }
                _oPar = x_oCmd.Parameters.Add("@prem_desc", global::System.Data.SqlDbType.NVarChar, 250);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oEventLetterDetail.prem_desc == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oEventLetterDetail.prem_desc; }
                _oPar = x_oCmd.Parameters.Add("@lett_sent_date", global::System.Data.SqlDbType.NVarChar, 20);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oEventLetterDetail.lett_sent_date == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oEventLetterDetail.lett_sent_date; }
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

        #region INSERT_EVENTLETTERDETAIL Store Procedures
        ///-- =============================================
        ///-- Author:		<Author,Philip SW>
        ///-- Create date: <Create Date 2009-11-17>
        ///-- Description:	<Description,EVENTLETTERDETAIL, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_EVENTLETTERDETAIL Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_EVENTLETTERDETAIL', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_EVENTLETTERDETAIL;
        GO
        CREATE PROCEDURE INSERT_EVENTLETTERDETAIL
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @cdate datetime,
        @cid char(10),
        @active bit,
        @mob_num char(10),
        @doc_id char(10),
        @name nvarchar(250),
        @prem_desc nvarchar(250),
        @Remarks nvarchar(250),
        @accnt_cd nvarchar(10),
        @lett_sent_date nvarchar(20)
        AS
        
        INSERT INTO  [EventLetterDetail]   ([cdate],[cid],[accnt_cd],[mob_num],[doc_id],[active],[name],[Remarks],[prem_desc],[lett_sent_date])  VALUES  (@cdate,@cid,@accnt_cd,@mob_num,@doc_id,@active,@name,@Remarks,@prem_desc,@lett_sent_date)
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
            string _sQuery = "DELETE FROM  [EventLetterDetail]  WHERE [EventLetterDetail].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[EventLetterDetail]", "[" + Configurator.MSSQLTablePrefix + "EventLetterDetail]"); }
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
            return EventLetterDetailRepositoryBase.DeleteAll(n_oDB);
        }

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "DELETE FROM  [EventLetterDetail]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[EventLetterDetail]", "[" + Configurator.MSSQLTablePrefix + "EventLetterDetail]"); }
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
            string _sQuery = "DELETE FROM [EventLetterDetail]" + x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[EventLetterDetail]", "[" + Configurator.MSSQLTablePrefix + "EventLetterDetail]"); }
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

