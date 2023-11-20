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
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-02-03>
///-- Description:	<Description,Table :[EventLetterDetail],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE
{

    /// <summary>
    /// Summary description for table [EventLetterDetail] Object Base layer
    /// </summary>

    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix + "EventLetterDetail")]
    public class EventLetterDetailEntity : global::System.IDisposable, global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>
    {


        protected global::System.Nullable<int> n_iId = null;
        #region id
        [System.Data.Linq.Mapping.Column(Name = "[id]", Storage = "n_iId")]
        public global::System.Nullable<int> id
        {
            get
            {
                return this.n_iId;
            }
            set
            {
                this.n_iId = value;
            }
        }
        #endregion id


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


        protected string n_sAccnt_cd = string.Empty;
        #region accnt_cd
        [System.Data.Linq.Mapping.Column(Name = "[accnt_cd]", Storage = "n_sAccnt_cd")]
        public string accnt_cd
        {
            get
            {
                return this.n_sAccnt_cd;
            }
            set
            {
                this.n_sAccnt_cd = value;
            }
        }
        #endregion accnt_cd


        protected string n_sMob_num = string.Empty;
        #region mob_num
        [System.Data.Linq.Mapping.Column(Name = "[mob_num]", Storage = "n_sMob_num")]
        public string mob_num
        {
            get
            {
                return this.n_sMob_num;
            }
            set
            {
                this.n_sMob_num = value;
            }
        }
        #endregion mob_num


        protected string n_sDoc_id = string.Empty;
        #region doc_id
        [System.Data.Linq.Mapping.Column(Name = "[doc_id]", Storage = "n_sDoc_id")]
        public string doc_id
        {
            get
            {
                return this.n_sDoc_id;
            }
            set
            {
                this.n_sDoc_id = value;
            }
        }
        #endregion doc_id


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


        protected string n_sName = string.Empty;
        #region name
        [System.Data.Linq.Mapping.Column(Name = "[name]", Storage = "n_sName")]
        public string name
        {
            get
            {
                return this.n_sName;
            }
            set
            {
                this.n_sName = value;
            }
        }
        #endregion name


        protected string n_sRemarks = string.Empty;
        #region Remarks
        [System.Data.Linq.Mapping.Column(Name = "[Remarks]", Storage = "n_sRemarks")]
        public string Remarks
        {
            get
            {
                return this.n_sRemarks;
            }
            set
            {
                this.n_sRemarks = value;
            }
        }
        #endregion Remarks


        protected string n_sPrem_desc = string.Empty;
        #region prem_desc
        [System.Data.Linq.Mapping.Column(Name = "[prem_desc]", Storage = "n_sPrem_desc")]
        public string prem_desc
        {
            get
            {
                return this.n_sPrem_desc;
            }
            set
            {
                this.n_sPrem_desc = value;
            }
        }
        #endregion prem_desc


        protected string n_sLett_sent_date = string.Empty;
        #region lett_sent_date
        [System.Data.Linq.Mapping.Column(Name = "[lett_sent_date]", Storage = "n_sLett_sent_date")]
        public string lett_sent_date
        {
            get
            {
                return this.n_sLett_sent_date;
            }
            set
            {
                this.n_sLett_sent_date = value;
            }
        }
        #endregion lett_sent_date

        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound = false;
        private global::System.Data.DataTable n_oTbl = null;
        private global::System.Data.DataRow n_oRow = null;
        private EventLetterDetailInfo n_oTableSet = new EventLetterDetailInfo();
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        #endregion

        #region Parameter String
        public class Para
        {
            public const string id = "id";
            public const string cdate = "cdate";
            public const string cid = "cid";
            public const string active = "active";
            public const string mob_num = "mob_num";
            public const string doc_id = "doc_id";
            public const string name = "name";
            public const string prem_desc = "prem_desc";
            public const string Remarks = "Remarks";
            public const string accnt_cd = "accnt_cd";
            public const string lett_sent_date = "lett_sent_date";
            public const string EventLetterDetail_table_name = Configurator.MSSQLTablePrefix + "EventLetterDetail";
            public static string TableName() { return EventLetterDetail_table_name; }
        }
        #endregion Parameter String

        #region Constructor
        public EventLetterDetailEntity()
        {
            Init();
        }
        public EventLetterDetailEntity(MSSQLConnect x_oDB)
        {
            n_oDB = x_oDB;
            Init();
        }

        public EventLetterDetailEntity(MSSQLConnect x_oDB, System.Nullable<int> x_iId)
        {
            n_oDB = x_oDB;
            this.Load(x_iId);
            Init();
        }

        ~EventLetterDetailEntity()
        {
            this.Release();
        }
        #endregion

        #region Load

        public bool Load(global::System.Nullable<int> x_iId)
        {
            if (n_oDB == null) { return false; }
            if (x_iId == null) { return false; }
            string _sQuery = "SELECT [EventLetterDetail].[id] AS EVENTLETTERDETAIL_ID,[EventLetterDetail].[cdate] AS EVENTLETTERDETAIL_CDATE,[EventLetterDetail].[cid] AS EVENTLETTERDETAIL_CID,[EventLetterDetail].[accnt_cd] AS EVENTLETTERDETAIL_ACCNT_CD,[EventLetterDetail].[mob_num] AS EVENTLETTERDETAIL_MOB_NUM,[EventLetterDetail].[doc_id] AS EVENTLETTERDETAIL_DOC_ID,[EventLetterDetail].[active] AS EVENTLETTERDETAIL_ACTIVE,[EventLetterDetail].[name] AS EVENTLETTERDETAIL_NAME,[EventLetterDetail].[Remarks] AS EVENTLETTERDETAIL_REMARKS,[EventLetterDetail].[prem_desc] AS EVENTLETTERDETAIL_PREM_DESC,[EventLetterDetail].[lett_sent_date] AS EVENTLETTERDETAIL_LETT_SENT_DATE  FROM  [EventLetterDetail]  WHERE  [EventLetterDetail].[id] = \'" + x_iId.ToString() + "\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[EventLetterDetail]", "[" + Configurator.MSSQLTablePrefix + "EventLetterDetail]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_ID"])) { n_iId = (global::System.Nullable<int>)_oData["EVENTLETTERDETAIL_ID"]; } else { n_iId = null; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_CDATE"])) { n_dCdate = (global::System.Nullable<DateTime>)_oData["EVENTLETTERDETAIL_CDATE"]; } else { n_dCdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_CID"])) { n_sCid = (string)_oData["EVENTLETTERDETAIL_CID"]; } else { n_sCid = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_ACCNT_CD"])) { n_sAccnt_cd = (string)_oData["EVENTLETTERDETAIL_ACCNT_CD"]; } else { n_sAccnt_cd = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_MOB_NUM"])) { n_sMob_num = (string)_oData["EVENTLETTERDETAIL_MOB_NUM"]; } else { n_sMob_num = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_DOC_ID"])) { n_sDoc_id = (string)_oData["EVENTLETTERDETAIL_DOC_ID"]; } else { n_sDoc_id = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_ACTIVE"])) { n_bActive = (global::System.Nullable<bool>)_oData["EVENTLETTERDETAIL_ACTIVE"]; } else { n_bActive = null; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_NAME"])) { n_sName = (string)_oData["EVENTLETTERDETAIL_NAME"]; } else { n_sName = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_REMARKS"])) { n_sRemarks = (string)_oData["EVENTLETTERDETAIL_REMARKS"]; } else { n_sRemarks = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_PREM_DESC"])) { n_sPrem_desc = (string)_oData["EVENTLETTERDETAIL_PREM_DESC"]; } else { n_sPrem_desc = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_LETT_SENT_DATE"])) { n_sLett_sent_date = (string)_oData["EVENTLETTERDETAIL_LETT_SENT_DATE"]; } else { n_sLett_sent_date = string.Empty; }
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
            if (!x_bInsert)
            {
                if (n_iId == null && !(n_oTableSet.Fields(Para.id).IsNullable)) return false;
            }
            if (n_dCdate == null && !(n_oTableSet.Fields(Para.cdate).IsNullable)) return false;
            if (n_sCid == null && !(n_oTableSet.Fields(Para.cid).IsNullable)) return false;
            if (n_sAccnt_cd == null && !(n_oTableSet.Fields(Para.accnt_cd).IsNullable)) return false;
            if (n_sMob_num == null && !(n_oTableSet.Fields(Para.mob_num).IsNullable)) return false;
            if (n_sDoc_id == null && !(n_oTableSet.Fields(Para.doc_id).IsNullable)) return false;
            if (n_bActive == null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_sName == null && !(n_oTableSet.Fields(Para.name).IsNullable)) return false;
            if (n_sRemarks == null && !(n_oTableSet.Fields(Para.Remarks).IsNullable)) return false;
            if (n_sPrem_desc == null && !(n_oTableSet.Fields(Para.prem_desc).IsNullable)) return false;
            if (n_sLett_sent_date == null && !(n_oTableSet.Fields(Para.lett_sent_date).IsNullable)) return false;
            return true;
        }
        #endregion

        #region Get & Set

        /// <summary>
        /// Summary description for Get & Set this all class parameters
        /// </summary>


        public object GetRepositoryObject(object x_oObj)
        {
            if ((x_oObj is EventLetterDetail) || (x_oObj is EventLetterDetailEntity)) return EventLetterDetailRepository.Instance();
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
        public EventLetterDetailInfo GetTableSet() { return n_oTableSet; }
        #endregion GetTableSet


        #region SetTableSet
        public void SetTableSet(EventLetterDetailInfo value) { n_oTableSet = value; }
        #endregion SetTableSet

        public global::System.Nullable<int> GetId() { return this.id; }
        public global::System.Nullable<DateTime> GetCdate() { return this.cdate; }
        public string GetCid() { return this.cid; }
        public global::System.Nullable<bool> GetActive() { return this.active; }
        public string GetMob_num() { return this.mob_num; }
        public string GetDoc_id() { return this.doc_id; }
        public string GetName() { return this.name; }
        public string GetPrem_desc() { return this.prem_desc; }
        public string GetRemarks() { return this.Remarks; }
        public string GetAccnt_cd() { return this.accnt_cd; }
        public string GetLett_sent_date() { return this.lett_sent_date; }

        public bool SetId(global::System.Nullable<int> value)
        {
            this.id = value;
            return true;
        }
        public bool SetCdate(global::System.Nullable<DateTime> value)
        {
            this.cdate = value;
            return true;
        }
        public bool SetCid(string value)
        {
            this.cid = value;
            return true;
        }
        public bool SetActive(global::System.Nullable<bool> value)
        {
            this.active = value;
            return true;
        }
        public bool SetMob_num(string value)
        {
            this.mob_num = value;
            return true;
        }
        public bool SetDoc_id(string value)
        {
            this.doc_id = value;
            return true;
        }
        public bool SetName(string value)
        {
            this.name = value;
            return true;
        }
        public bool SetPrem_desc(string value)
        {
            this.prem_desc = value;
            return true;
        }
        public bool SetRemarks(string value)
        {
            this.Remarks = value;
            return true;
        }
        public bool SetAccnt_cd(string value)
        {
            this.accnt_cd = value;
            return true;
        }
        public bool SetLett_sent_date(string value)
        {
            this.lett_sent_date = value;
            return true;
        }

        public Field GetIdTable()
        {
            return n_oTableSet.Fields(Para.id);
        }
        public Field GetCdateTable()
        {
            return n_oTableSet.Fields(Para.cdate);
        }
        public Field GetCidTable()
        {
            return n_oTableSet.Fields(Para.cid);
        }
        public Field GetActiveTable()
        {
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetMob_numTable()
        {
            return n_oTableSet.Fields(Para.mob_num);
        }
        public Field GetDoc_idTable()
        {
            return n_oTableSet.Fields(Para.doc_id);
        }
        public Field GetNameTable()
        {
            return n_oTableSet.Fields(Para.name);
        }
        public Field GetPrem_descTable()
        {
            return n_oTableSet.Fields(Para.prem_desc);
        }
        public Field GetRemarksTable()
        {
            return n_oTableSet.Fields(Para.Remarks);
        }
        public Field GetAccnt_cdTable()
        {
            return n_oTableSet.Fields(Para.accnt_cd);
        }
        public Field GetLett_sent_dateTable()
        {
            return n_oTableSet.Fields(Para.lett_sent_date);
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

        public bool EqualID(EventLetterDetail x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }

        public bool Equals(EventLetterDetail x_oObj)
        {
            if (x_oObj == null) return false;
            if (!this.n_iId.Equals(x_oObj.id)) { return false; }
            if (!this.n_dCdate.Equals(x_oObj.cdate)) { return false; }
            if (!this.n_sCid.Equals(x_oObj.cid)) { return false; }
            if (!this.n_sAccnt_cd.Equals(x_oObj.accnt_cd)) { return false; }
            if (!this.n_sMob_num.Equals(x_oObj.mob_num)) { return false; }
            if (!this.n_sDoc_id.Equals(x_oObj.doc_id)) { return false; }
            if (!this.n_bActive.Equals(x_oObj.active)) { return false; }
            if (!this.n_sName.Equals(x_oObj.name)) { return false; }
            if (!this.n_sRemarks.Equals(x_oObj.Remarks)) { return false; }
            if (!this.n_sPrem_desc.Equals(x_oObj.prem_desc)) { return false; }
            if (!this.n_sLett_sent_date.Equals(x_oObj.lett_sent_date)) { return false; }
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
            if (!n_iId.Equals(null))
            {
                _bResult = this.Load(n_iId);
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
            if (n_iId == null) { return false; }
            if (!Vaild(false)) { return false; }
            string _sQuery = "UPDATE  [EventLetterDetail]  SET  [cdate]=@cdate,[cid]=@cid,[accnt_cd]=@accnt_cd,[mob_num]=@mob_num,[doc_id]=@doc_id,[active]=@active,[name]=@name,[Remarks]=@Remarks,[prem_desc]=@prem_desc,[lett_sent_date]=@lett_sent_date  WHERE [EventLetterDetail].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[EventLetterDetail]", "[" + Configurator.MSSQLTablePrefix + "EventLetterDetail]"); }
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
            if (n_iId == null) { _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = n_iId; }
            if (n_dCdate == null) { _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = n_dCdate; }
            if (n_sCid == null) { _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10).Value = n_sCid; }
            if (n_sAccnt_cd == null) { _oCmd.Parameters.Add("@accnt_cd", global::System.Data.SqlDbType.NVarChar, 10).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@accnt_cd", global::System.Data.SqlDbType.NVarChar, 10).Value = n_sAccnt_cd; }
            if (n_sMob_num == null) { _oCmd.Parameters.Add("@mob_num", global::System.Data.SqlDbType.Char, 10).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@mob_num", global::System.Data.SqlDbType.Char, 10).Value = n_sMob_num; }
            if (n_sDoc_id == null) { _oCmd.Parameters.Add("@doc_id", global::System.Data.SqlDbType.Char, 10).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@doc_id", global::System.Data.SqlDbType.Char, 10).Value = n_sDoc_id; }
            if (n_bActive == null) { _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = n_bActive; }
            if (n_sName == null) { _oCmd.Parameters.Add("@name", global::System.Data.SqlDbType.NVarChar, 250).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@name", global::System.Data.SqlDbType.NVarChar, 250).Value = n_sName; }
            if (n_sRemarks == null) { _oCmd.Parameters.Add("@Remarks", global::System.Data.SqlDbType.NVarChar, 250).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@Remarks", global::System.Data.SqlDbType.NVarChar, 250).Value = n_sRemarks; }
            if (n_sPrem_desc == null) { _oCmd.Parameters.Add("@prem_desc", global::System.Data.SqlDbType.NVarChar, 250).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@prem_desc", global::System.Data.SqlDbType.NVarChar, 250).Value = n_sPrem_desc; }
            if (n_sLett_sent_date == null) { _oCmd.Parameters.Add("@lett_sent_date", global::System.Data.SqlDbType.NVarChar, 20).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@lett_sent_date", global::System.Data.SqlDbType.NVarChar, 20).Value = n_sLett_sent_date; }
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
        /// Summary description for table [EventLetterDetail] Delete Record
        /// </summary>

        public bool Delete()
        {
            if (n_iId == null) { return false; }
            string _sQuery = "DELETE FROM  [EventLetterDetail]  WHERE [EventLetterDetail].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[EventLetterDetail]", "[" + Configurator.MSSQLTablePrefix + "EventLetterDetail]"); }
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
            _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = n_iId;
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
        /// Summary description for table [EventLetterDetail] Object Base Clone
        /// </summary>

        public EventLetterDetail DeepClone()
        {
            EventLetterDetail _oEventLetterDetail_Clone = (EventLetterDetail)EventLetterDetailRepository.CreateEntityInstanceObject();
            _oEventLetterDetail_Clone.id = this.n_iId;
            _oEventLetterDetail_Clone.cdate = this.n_dCdate;
            _oEventLetterDetail_Clone.cid = this.n_sCid;
            _oEventLetterDetail_Clone.accnt_cd = this.n_sAccnt_cd;
            _oEventLetterDetail_Clone.mob_num = this.n_sMob_num;
            _oEventLetterDetail_Clone.doc_id = this.n_sDoc_id;
            _oEventLetterDetail_Clone.active = this.n_bActive;
            _oEventLetterDetail_Clone.name = this.n_sName;
            _oEventLetterDetail_Clone.Remarks = this.n_sRemarks;
            _oEventLetterDetail_Clone.prem_desc = this.n_sPrem_desc;
            _oEventLetterDetail_Clone.lett_sent_date = this.n_sLett_sent_date;
            _oEventLetterDetail_Clone.SetFound(this.n_bFound);
            _oEventLetterDetail_Clone.SetDB(this.n_oDB);
            _oEventLetterDetail_Clone.SetRow(this.n_oRow);
            _oEventLetterDetail_Clone.SetTbl(this.n_oTbl);
            _oEventLetterDetail_Clone.SetTableSet(this.n_oTableSet);

            return _oEventLetterDetail_Clone;
        }
        #endregion

        #region Release

        /// <summary>
        /// Summary description for Release
        /// </summary>

        public void Release()
        {
            n_iId = null;
            n_dCdate = null;
            n_sCid = string.Empty;
            n_sAccnt_cd = string.Empty;
            n_sMob_num = string.Empty;
            n_sDoc_id = string.Empty;
            n_bActive = null;
            n_sName = string.Empty;
            n_sRemarks = string.Empty;
            n_sPrem_desc = string.Empty;
            n_sLett_sent_date = string.Empty;
            n_oDB = null;
            n_bFound = false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = new EventLetterDetailInfo();
        }
        #endregion
    }
}

