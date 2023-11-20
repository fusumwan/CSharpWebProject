using System;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
///-- Create date: <Create Date 2009-02-03>
///-- Description:	<Description,Table :[EventMsgDetail],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE
{

    /// <summary>
    /// Summary description for table [EventMsgDetail] Object Base layer
    /// </summary>

    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix + "EventMsgDetail")]
    public class EventMsgDetailEntity : global::System.IDisposable, global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>
    {


        protected global::System.Nullable<DateTime> n_dCdate = null;
        #region cdate
        [System.Data.Linq.Mapping.Column(Name = "[cdate]", Storage = "n_dCdate")]
        public global::System.Nullable<DateTime> cdate
        {
            get
            {
                return this.n_dCdate;
            }
            set
            {
                this.n_dCdate = value;
            }
        }
        #endregion cdate


        protected global::System.Nullable<bool> n_bActive = null;
        #region active
        [System.Data.Linq.Mapping.Column(Name = "[active]", Storage = "n_bActive")]
        public global::System.Nullable<bool> active
        {
            get
            {
                return this.n_bActive;
            }
            set
            {
                this.n_bActive = value;
            }
        }
        #endregion active


        protected string n_sAccess_right = string.Empty;
        #region access_right
        [System.Data.Linq.Mapping.Column(Name = "[access_right]", Storage = "n_sAccess_right")]
        public string access_right
        {
            get
            {
                return this.n_sAccess_right;
            }
            set
            {
                this.n_sAccess_right = value;
            }
        }
        #endregion access_right


        protected string n_sCid = string.Empty;
        #region cid
        [System.Data.Linq.Mapping.Column(Name = "[cid]", Storage = "n_sCid")]
        public string cid
        {
            get
            {
                return this.n_sCid;
            }
            set
            {
                this.n_sCid = value;
            }
        }
        #endregion cid


        protected string n_sDid = string.Empty;
        #region did
        [System.Data.Linq.Mapping.Column(Name = "[did]", Storage = "n_sDid")]
        public string did
        {
            get
            {
                return this.n_sDid;
            }
            set
            {
                this.n_sDid = value;
            }
        }
        #endregion did


        protected string n_sMessage = string.Empty;
        #region message
        [System.Data.Linq.Mapping.Column(Name = "[message]", Storage = "n_sMessage")]
        public string message
        {
            get
            {
                return this.n_sMessage;
            }
            set
            {
                this.n_sMessage = value;
            }
        }
        #endregion message


        protected global::System.Nullable<DateTime> n_dEdate = null;
        #region edate
        [System.Data.Linq.Mapping.Column(Name = "[edate]", Storage = "n_dEdate")]
        public global::System.Nullable<DateTime> edate
        {
            get
            {
                return this.n_dEdate;
            }
            set
            {
                this.n_dEdate = value;
            }
        }
        #endregion edate


        protected string n_sSubject = string.Empty;
        #region subject
        [System.Data.Linq.Mapping.Column(Name = "[subject]", Storage = "n_sSubject")]
        public string subject
        {
            get
            {
                return this.n_sSubject;
            }
            set
            {
                this.n_sSubject = value;
            }
        }
        #endregion subject


        protected global::System.Nullable<DateTime> n_dDdate = null;
        #region ddate
        [System.Data.Linq.Mapping.Column(Name = "[ddate]", Storage = "n_dDdate")]
        public global::System.Nullable<DateTime> ddate
        {
            get
            {
                return this.n_dDdate;
            }
            set
            {
                this.n_dDdate = value;
            }
        }
        #endregion ddate


        protected global::System.Nullable<int> n_iMid = null;
        #region mid
        [System.Data.Linq.Mapping.Column(Name = "[mid]", Storage = "n_iMid")]
        public global::System.Nullable<int> mid
        {
            get
            {
                return this.n_iMid;
            }
            set
            {
                this.n_iMid = value;
            }
        }
        #endregion mid


        protected global::System.Nullable<DateTime> n_dSdate = null;
        #region sdate
        [System.Data.Linq.Mapping.Column(Name = "[sdate]", Storage = "n_dSdate")]
        public global::System.Nullable<DateTime> sdate
        {
            get
            {
                return this.n_dSdate;
            }
            set
            {
                this.n_dSdate = value;
            }
        }
        #endregion sdate

        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound = false;
        private global::System.Data.DataTable n_oTbl = null;
        private global::System.Data.DataRow n_oRow = null;
        private EventMsgDetailInfo n_oTableSet = new EventMsgDetailInfo();
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        #endregion

        #region Parameter String
        public class Para
        {
            public const string cdate = "cdate";
            public const string active = "active";
            public const string access_right = "access_right";
            public const string cid = "cid";
            public const string did = "did";
            public const string message = "message";
            public const string edate = "edate";
            public const string subject = "subject";
            public const string ddate = "ddate";
            public const string mid = "mid";
            public const string sdate = "sdate";
            public const string EventMsgDetail_table_name = Configurator.MSSQLTablePrefix + "EventMsgDetail";
            public static string TableName() { return EventMsgDetail_table_name; }
        }
        #endregion Parameter String

        #region Constructor
        public EventMsgDetailEntity()
        {
            Init();
        }
        public EventMsgDetailEntity(MSSQLConnect x_oDB)
        {
            n_oDB = x_oDB;
            Init();
        }

        public EventMsgDetailEntity(MSSQLConnect x_oDB, System.Nullable<int> x_iMid)
        {
            n_oDB = x_oDB;
            this.Load(x_iMid);
            Init();
        }

        ~EventMsgDetailEntity()
        {
            this.Release();
        }
        #endregion

        #region Load

        public bool Load(global::System.Nullable<int> x_iMid)
        {
            if (n_oDB == null) { return false; }
            if (x_iMid == null) { return false; }
            string _sQuery = "SELECT [EventMsgDetail].[cdate] AS EVENTMSGDETAIL_CDATE,[EventMsgDetail].[active] AS EVENTMSGDETAIL_ACTIVE,[EventMsgDetail].[access_right] AS EVENTMSGDETAIL_ACCESS_RIGHT,[EventMsgDetail].[cid] AS EVENTMSGDETAIL_CID,[EventMsgDetail].[did] AS EVENTMSGDETAIL_DID,[EventMsgDetail].[message] AS EVENTMSGDETAIL_MESSAGE,[EventMsgDetail].[edate] AS EVENTMSGDETAIL_EDATE,[EventMsgDetail].[subject] AS EVENTMSGDETAIL_SUBJECT,[EventMsgDetail].[ddate] AS EVENTMSGDETAIL_DDATE,[EventMsgDetail].[mid] AS EVENTMSGDETAIL_MID,[EventMsgDetail].[sdate] AS EVENTMSGDETAIL_SDATE  FROM  [EventMsgDetail]  WHERE  [EventMsgDetail].[mid] = \'" + x_iMid.ToString() + "\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[EventMsgDetail]", "[" + Configurator.MSSQLTablePrefix + "EventMsgDetail]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = n_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read())
                    {
                        n_bFound = true;
                        if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_CDATE"])) { n_dCdate = (global::System.Nullable<DateTime>)_oData["EVENTMSGDETAIL_CDATE"]; } else { n_dCdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_ACTIVE"])) { n_bActive = (global::System.Nullable<bool>)_oData["EVENTMSGDETAIL_ACTIVE"]; } else { n_bActive = null; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_ACCESS_RIGHT"])) { n_sAccess_right = (string)_oData["EVENTMSGDETAIL_ACCESS_RIGHT"]; } else { n_sAccess_right = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_CID"])) { n_sCid = (string)_oData["EVENTMSGDETAIL_CID"]; } else { n_sCid = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_DID"])) { n_sDid = (string)_oData["EVENTMSGDETAIL_DID"]; } else { n_sDid = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_MESSAGE"])) { n_sMessage = (string)_oData["EVENTMSGDETAIL_MESSAGE"]; } else { n_sMessage = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_EDATE"])) { n_dEdate = (global::System.Nullable<DateTime>)_oData["EVENTMSGDETAIL_EDATE"]; } else { n_dEdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_SUBJECT"])) { n_sSubject = (string)_oData["EVENTMSGDETAIL_SUBJECT"]; } else { n_sSubject = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_DDATE"])) { n_dDdate = (global::System.Nullable<DateTime>)_oData["EVENTMSGDETAIL_DDATE"]; } else { n_dDdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_MID"])) { n_iMid = (global::System.Nullable<int>)_oData["EVENTMSGDETAIL_MID"]; } else { n_iMid = null; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_SDATE"])) { n_dSdate = (global::System.Nullable<DateTime>)_oData["EVENTMSGDETAIL_SDATE"]; } else { n_dSdate = null; }
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
                return true;
            }
        }
        #endregion

        #region Init

        /// <summary>
        /// Summary description for Init Class
        /// </summary>

        public void Init()
        {

        }
        #endregion

        #region Vaild

        /// <summary>
        /// Summary description for Vaild Checking
        /// </summary>

        public bool Vaild(bool x_bInsert)
        {
            if (n_dCdate == null && !(n_oTableSet.Fields(Para.cdate).IsNullable)) return false;
            if (n_bActive == null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_sAccess_right == null && !(n_oTableSet.Fields(Para.access_right).IsNullable)) return false;
            if (n_sCid == null && !(n_oTableSet.Fields(Para.cid).IsNullable)) return false;
            if (n_sDid == null && !(n_oTableSet.Fields(Para.did).IsNullable)) return false;
            if (n_sMessage == null && !(n_oTableSet.Fields(Para.message).IsNullable)) return false;
            if (n_dEdate == null && !(n_oTableSet.Fields(Para.edate).IsNullable)) return false;
            if (n_sSubject == null && !(n_oTableSet.Fields(Para.subject).IsNullable)) return false;
            if (n_dDdate == null && !(n_oTableSet.Fields(Para.ddate).IsNullable)) return false;
            if (!x_bInsert)
            {
                if (n_iMid == null && !(n_oTableSet.Fields(Para.mid).IsNullable)) return false;
            }
            if (n_dSdate == null && !(n_oTableSet.Fields(Para.sdate).IsNullable)) return false;
            return true;
        }
        #endregion

        #region Get & Set

        /// <summary>
        /// Summary description for Get & Set this all class parameters
        /// </summary>


        public object GetRepositoryObject(object x_oObj)
        {
            if ((x_oObj is EventMsgDetail) || (x_oObj is EventMsgDetailEntity)) return EventMsgDetailRepository.Instance();
            return null;
        }


        #region GetFound
        public bool GetFound()
        {
            if (!this.n_bFound) { this.n_bFound = Vaild(false); }
            return this.n_bFound;
        }
        #endregion


        #region SetFound
        public void SetFound(bool value) { n_bFound = value; }
        #endregion SetFound


        #region GetTbl
        public global::System.Data.DataTable GetTbl() { return n_oTbl; }
        #endregion GetTbl


        #region SetTbl
        public void SetTbl(DataTable value) { n_oTbl = value; }
        #endregion SetTbl


        #region GetRow
        public global::System.Data.DataRow GetRow() { return n_oRow; }
        #endregion GetRow


        #region SetRow
        public void SetRow(global::System.Data.DataRow value) { n_oRow = value; }
        #endregion SetRow


        #region GetDB
        public MSSQLConnect GetDB()
        {
            return n_oDB;
        }
        #endregion GetDB

        #region SetDB
        public void SetDB(MSSQLConnect x_oDB)
        {
            n_oDB = x_oDB;
        }
        #endregion SetDB


        #region GetTableSet
        public EventMsgDetailInfo GetTableSet() { return n_oTableSet; }
        #endregion GetTableSet


        #region SetTableSet
        public void SetTableSet(EventMsgDetailInfo value) { n_oTableSet = value; }
        #endregion SetTableSet

        public global::System.Nullable<DateTime> GetCdate() { return this.cdate; }
        public global::System.Nullable<bool> GetActive() { return this.active; }
        public string GetAccess_right() { return this.access_right; }
        public string GetCid() { return this.cid; }
        public string GetDid() { return this.did; }
        public string GetMessage() { return this.message; }
        public global::System.Nullable<DateTime> GetEdate() { return this.edate; }
        public string GetSubject() { return this.subject; }
        public global::System.Nullable<DateTime> GetDdate() { return this.ddate; }
        public global::System.Nullable<int> GetMid() { return this.mid; }
        public global::System.Nullable<DateTime> GetSdate() { return this.sdate; }

        public bool SetCdate(global::System.Nullable<DateTime> value)
        {
            this.cdate = value;
            return true;
        }
        public bool SetActive(global::System.Nullable<bool> value)
        {
            this.active = value;
            return true;
        }
        public bool SetAccess_right(string value)
        {
            this.access_right = value;
            return true;
        }
        public bool SetCid(string value)
        {
            this.cid = value;
            return true;
        }
        public bool SetDid(string value)
        {
            this.did = value;
            return true;
        }
        public bool SetMessage(string value)
        {
            this.message = value;
            return true;
        }
        public bool SetEdate(global::System.Nullable<DateTime> value)
        {
            this.edate = value;
            return true;
        }
        public bool SetSubject(string value)
        {
            this.subject = value;
            return true;
        }
        public bool SetDdate(global::System.Nullable<DateTime> value)
        {
            this.ddate = value;
            return true;
        }
        public bool SetMid(global::System.Nullable<int> value)
        {
            this.mid = value;
            return true;
        }
        public bool SetSdate(global::System.Nullable<DateTime> value)
        {
            this.sdate = value;
            return true;
        }

        public Field GetCdateTable()
        {
            return n_oTableSet.Fields(Para.cdate);
        }
        public Field GetActiveTable()
        {
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetAccess_rightTable()
        {
            return n_oTableSet.Fields(Para.access_right);
        }
        public Field GetCidTable()
        {
            return n_oTableSet.Fields(Para.cid);
        }
        public Field GetDidTable()
        {
            return n_oTableSet.Fields(Para.did);
        }
        public Field GetMessageTable()
        {
            return n_oTableSet.Fields(Para.message);
        }
        public Field GetEdateTable()
        {
            return n_oTableSet.Fields(Para.edate);
        }
        public Field GetSubjectTable()
        {
            return n_oTableSet.Fields(Para.subject);
        }
        public Field GetDdateTable()
        {
            return n_oTableSet.Fields(Para.ddate);
        }
        public Field GetMidTable()
        {
            return n_oTableSet.Fields(Para.mid);
        }
        public Field GetSdateTable()
        {
            return n_oTableSet.Fields(Para.sdate);
        }
        #endregion

        #region Addtional Get & Set
        #endregion

        #region Add & Del
        #endregion

        #region CheckNullable

        /// <summary>
        /// Summary description for Nullable Columns
        /// </summary>

        public bool CheckNullable(string x_sColumnName)
        {
            if ("".Equals(x_sColumnName)) { return false; }
            return n_oTableSet.Fields(x_sColumnName).IsNullable;
        }
        #endregion

        #region Equal

        /// <summary>
        /// Summary description for Equal Check
        /// </summary>

        public bool EqualID(EventMsgDetail x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iMid.Equals(x_oObj.mid)) && isEquals;
            return isEquals;
        }

        public bool Equals(EventMsgDetail x_oObj)
        {
            if (x_oObj == null) return false;
            if (!this.n_dCdate.Equals(x_oObj.cdate)) { return false; }
            if (!this.n_bActive.Equals(x_oObj.active)) { return false; }
            if (!this.n_sAccess_right.Equals(x_oObj.access_right)) { return false; }
            if (!this.n_sCid.Equals(x_oObj.cid)) { return false; }
            if (!this.n_sDid.Equals(x_oObj.did)) { return false; }
            if (!this.n_sMessage.Equals(x_oObj.message)) { return false; }
            if (!this.n_dEdate.Equals(x_oObj.edate)) { return false; }
            if (!this.n_sSubject.Equals(x_oObj.subject)) { return false; }
            if (!this.n_dDdate.Equals(x_oObj.ddate)) { return false; }
            if (!this.n_iMid.Equals(x_oObj.mid)) { return false; }
            if (!this.n_dSdate.Equals(x_oObj.sdate)) { return false; }
            return true;
        }
        #endregion

        #region Retrieve

        /// <summary>
        /// Summary description for Retrieve
        /// </summary>

        public bool Retrieve()
        {
            if (n_oDB == null) { return false; }
            bool _bResult = false;
            if (!n_iMid.Equals(null))
            {
                _bResult = this.Load(n_iMid);
                if (_bResult) { return _bResult; }
            }
            return _bResult;
        }

        #endregion

        #region Save

        /// <summary>
        /// Summary description for Save
        /// </summary>

        public bool Save()
        {
            if (n_oDB == null) { return false; }
            if (n_iMid == null) { return false; }
            if (!Vaild(false)) { return false; }
            string _sQuery = "UPDATE  [EventMsgDetail]  SET  [cdate]=@cdate,[active]=@active,[access_right]=@access_right,[cid]=@cid,[did]=@did,[message]=@message,[edate]=@edate,[subject]=@subject,[ddate]=@ddate,[sdate]=@sdate  WHERE [EventMsgDetail].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[EventMsgDetail]", "[" + Configurator.MSSQLTablePrefix + "EventMsgDetail]"); }
            global::System.Data.SqlClient.SqlConnection _oConn = null;
            global::System.Data.SqlClient.SqlCommand _oCmd = null;
            if (n_oDB.bTransaction)
            {
                n_oDB.ISessionCmd.CommandText = _sQuery;
                n_oDB.ISessionCmd.Parameters.Clear();
                _oCmd = n_oDB.ISessionCmd;
                _oConn = n_oDB.ISessionConn;
            }
            else
            {
                _oConn = n_oDB.GetConnection();
                _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            }
            bool _bResult = false;
            if (n_dCdate == null) { _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = n_dCdate; }
            if (n_bActive == null) { _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = n_bActive; }
            if (n_sAccess_right == null) { _oCmd.Parameters.Add("@access_right", global::System.Data.SqlDbType.NVarChar, 100).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@access_right", global::System.Data.SqlDbType.NVarChar, 100).Value = n_sAccess_right; }
            if (n_sCid == null) { _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10).Value = n_sCid; }
            if (n_sDid == null) { _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10).Value = n_sDid; }
            if (n_sMessage == null) { _oCmd.Parameters.Add("@message", global::System.Data.SqlDbType.Text, 2147483647).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@message", global::System.Data.SqlDbType.Text, 2147483647).Value = n_sMessage; }
            if (n_dEdate == null) { _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = n_dEdate; }
            if (n_sSubject == null) { _oCmd.Parameters.Add("@subject", global::System.Data.SqlDbType.NVarChar, 250).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@subject", global::System.Data.SqlDbType.NVarChar, 250).Value = n_sSubject; }
            if (n_dDdate == null) { _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = n_dDdate; }
            if (n_iMid == null) { _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value = n_iMid; }
            if (n_dSdate == null) { _oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { _oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = n_dSdate; }
            try
            {
                if (!n_oDB.bTransaction && _oConn.State == ConnectionState.Closed) _oConn.Open();
                _bResult = global::System.Convert.ToBoolean(_oCmd.ExecuteNonQuery());
            }
            catch (Exception exp) { string _sError = exp.ToString(); }
            finally
            {
                if (!n_oDB.bTransaction)
                {
                    _oConn.Close();
                    _oCmd.Dispose();
                    _oConn.Dispose();
                }
            }
            return _bResult;
        }
        #endregion

        #region Delete

        /// <summary>
        /// Summary description for table [EventMsgDetail] Delete Record
        /// </summary>

        public bool Delete()
        {
            if (n_iMid == null) { return false; }
            string _sQuery = "DELETE FROM  [EventMsgDetail]  WHERE [EventMsgDetail].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[EventMsgDetail]", "[" + Configurator.MSSQLTablePrefix + "EventMsgDetail]"); }
            global::System.Data.SqlClient.SqlConnection _oConn = null;
            global::System.Data.SqlClient.SqlCommand _oCmd = null;
            if (n_oDB.bTransaction)
            {
                n_oDB.ISessionCmd.CommandText = _sQuery;
                n_oDB.ISessionCmd.Parameters.Clear();
                _oCmd = n_oDB.ISessionCmd;
                _oConn = n_oDB.ISessionConn;
            }
            else
            {
                _oConn = n_oDB.GetConnection();
                _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            }
            bool _bResult = false;
            _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value = n_iMid;
            try
            {
                if (!n_oDB.bTransaction && _oConn.State == ConnectionState.Closed) _oConn.Open();
                _bResult = global::System.Convert.ToBoolean(_oCmd.ExecuteNonQuery());
            }
            catch (Exception exp) { string _sError = exp.ToString(); }
            finally
            {
                if (!n_oDB.bTransaction)
                {
                    _oConn.Close();
                    _oCmd.Dispose();
                    _oConn.Dispose();
                }
            }
            return _bResult;
        }
        #endregion

        #region Dispose
        void global::System.IDisposable.Dispose()
        {
            this.Dispose();
        }
        public void Dispose()
        {
        }
        #endregion

        #region DeepClone

        /// <summary>
        /// Summary description for table [EventMsgDetail] Object Base Clone
        /// </summary>

        public EventMsgDetail DeepClone()
        {
            EventMsgDetail _oEventMsgDetail_Clone = new EventMsgDetail();
            _oEventMsgDetail_Clone.cdate = this.n_dCdate;
            _oEventMsgDetail_Clone.active = this.n_bActive;
            _oEventMsgDetail_Clone.access_right = this.n_sAccess_right;
            _oEventMsgDetail_Clone.cid = this.n_sCid;
            _oEventMsgDetail_Clone.did = this.n_sDid;
            _oEventMsgDetail_Clone.message = this.n_sMessage;
            _oEventMsgDetail_Clone.edate = this.n_dEdate;
            _oEventMsgDetail_Clone.subject = this.n_sSubject;
            _oEventMsgDetail_Clone.ddate = this.n_dDdate;
            _oEventMsgDetail_Clone.mid = this.n_iMid;
            _oEventMsgDetail_Clone.sdate = this.n_dSdate;
            _oEventMsgDetail_Clone.SetFound(this.n_bFound);
            _oEventMsgDetail_Clone.SetDB(this.n_oDB);
            _oEventMsgDetail_Clone.SetRow(this.n_oRow);
            _oEventMsgDetail_Clone.SetTbl(this.n_oTbl);
            _oEventMsgDetail_Clone.SetTableSet(this.n_oTableSet);

            return _oEventMsgDetail_Clone;
        }
        #endregion

        #region Release

        /// <summary>
        /// Summary description for Release
        /// </summary>

        public void Release()
        {
            n_dCdate = null;
            n_bActive = null;
            n_sAccess_right = string.Empty;
            n_sCid = string.Empty;
            n_sDid = string.Empty;
            n_sMessage = string.Empty;
            n_dEdate = null;
            n_sSubject = string.Empty;
            n_dDdate = null;
            n_iMid = null;
            n_dSdate = null;
            n_oDB = null;
            n_bFound = false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = new EventMsgDetailInfo();
        }
        #endregion
    }
}

