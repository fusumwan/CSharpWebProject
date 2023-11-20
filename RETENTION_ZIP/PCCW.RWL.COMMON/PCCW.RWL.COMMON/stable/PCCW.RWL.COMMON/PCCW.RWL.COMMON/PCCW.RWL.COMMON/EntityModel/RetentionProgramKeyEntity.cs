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
///-- Description:	<Description,Table :[RetentionProgramKey],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE
{

    /// <summary>
    /// Summary description for table [RetentionProgramKey] Object Base layer
    /// </summary>

    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix + "RetentionProgramKey")]
    public class RetentionProgramKeyEntity : global::System.IDisposable, global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>
    {


        protected string n_sType = string.Empty;
        #region type
        [System.Data.Linq.Mapping.Column(Name = "[type]", Storage = "n_sType")]
        public string type
        {
            get
            {
                return this.n_sType;
            }
            set
            {
                this.n_sType = value;
            }
        }
        #endregion type


        protected string n_sCall_list_type = string.Empty;
        #region call_list_type
        [System.Data.Linq.Mapping.Column(Name = "[call_list_type]", Storage = "n_sCall_list_type")]
        public string call_list_type
        {
            get
            {
                return this.n_sCall_list_type;
            }
            set
            {
                this.n_sCall_list_type = value;
            }
        }
        #endregion call_list_type


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


        protected global::System.Nullable<DateTime> n_dReturn_date = null;
        #region return_date
        [System.Data.Linq.Mapping.Column(Name = "[return_date]", Storage = "n_dReturn_date")]
        public global::System.Nullable<DateTime> return_date
        {
            get
            {
                return this.n_dReturn_date;
            }
            set
            {
                this.n_dReturn_date = value;
            }
        }
        #endregion return_date


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


        protected string n_sExpiry_month = string.Empty;
        #region expiry_month
        [System.Data.Linq.Mapping.Column(Name = "[expiry_month]", Storage = "n_sExpiry_month")]
        public string expiry_month
        {
            get
            {
                return this.n_sExpiry_month;
            }
            set
            {
                this.n_sExpiry_month = value;
            }
        }
        #endregion expiry_month


        protected global::System.Nullable<DateTime> n_dUpload_date = null;
        #region upload_date
        [System.Data.Linq.Mapping.Column(Name = "[upload_date]", Storage = "n_dUpload_date")]
        public global::System.Nullable<DateTime> upload_date
        {
            get
            {
                return this.n_dUpload_date;
            }
            set
            {
                this.n_dUpload_date = value;
            }
        }
        #endregion upload_date


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


        protected string n_sCall_list_size = string.Empty;
        #region call_list_size
        [System.Data.Linq.Mapping.Column(Name = "[call_list_size]", Storage = "n_sCall_list_size")]
        public string call_list_size
        {
            get
            {
                return this.n_sCall_list_size;
            }
            set
            {
                this.n_sCall_list_size = value;
            }
        }
        #endregion call_list_size


        protected string n_sCenter = string.Empty;
        #region center
        [System.Data.Linq.Mapping.Column(Name = "[center]", Storage = "n_sCenter")]
        public string center
        {
            get
            {
                return this.n_sCenter;
            }
            set
            {
                this.n_sCenter = value;
            }
        }
        #endregion center


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


        protected string n_sProgram_name = string.Empty;
        #region program_name
        [System.Data.Linq.Mapping.Column(Name = "[program_name]", Storage = "n_sProgram_name")]
        public string program_name
        {
            get
            {
                return this.n_sProgram_name;
            }
            set
            {
                this.n_sProgram_name = value;
            }
        }
        #endregion program_name


        protected global::System.Nullable<int> n_iProgram_id = null;
        #region program_id
        [System.Data.Linq.Mapping.Column(Name = "[program_id]", Storage = "n_iProgram_id")]
        public global::System.Nullable<int> program_id
        {
            get
            {
                return this.n_iProgram_id;
            }
            set
            {
                this.n_iProgram_id = value;
            }
        }
        #endregion program_id


        protected string n_sRemarks = string.Empty;
        #region remarks
        [System.Data.Linq.Mapping.Column(Name = "[remarks]", Storage = "n_sRemarks")]
        public string remarks
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
        #endregion remarks


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
        private RetentionProgramKeyInfo n_oTableSet = new RetentionProgramKeyInfo();
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        #endregion

        #region Parameter String
        public class Para
        {
            public const string type = "type";
            public const string call_list_type = "call_list_type";
            public const string cdate = "cdate";
            public const string cid = "cid";
            public const string did = "did";
            public const string return_date = "return_date";
            public const string edate = "edate";
            public const string active = "active";
            public const string center = "center";
            public const string expiry_month = "expiry_month";
            public const string upload_date = "upload_date";
            public const string call_list_size = "call_list_size";
            public const string ddate = "ddate";
            public const string id = "id";
            public const string program_name = "program_name";
            public const string program_id = "program_id";
            public const string remarks = "remarks";
            public const string sdate = "sdate";
            public const string RetentionProgramKey_table_name = Configurator.MSSQLTablePrefix + "RetentionProgramKey";
            public static string TableName() { return RetentionProgramKey_table_name; }
        }
        #endregion Parameter String

        #region Constructor
        public RetentionProgramKeyEntity()
        {
            Init();
        }
        public RetentionProgramKeyEntity(MSSQLConnect x_oDB)
        {
            n_oDB = x_oDB;
            Init();
        }

        public RetentionProgramKeyEntity(MSSQLConnect x_oDB, System.Nullable<int> x_iId)
        {
            n_oDB = x_oDB;
            this.Load(x_iId);
            Init();
        }

        ~RetentionProgramKeyEntity()
        {
            this.Release();
        }
        #endregion

        #region Load

        public bool Load(global::System.Nullable<int> x_iId)
        {
            if (n_oDB == null) { return false; }
            if (x_iId == null) { return false; }
            string _sQuery = "SELECT [RetentionProgramKey].[type] AS RETENTIONPROGRAMKEY_TYPE,[RetentionProgramKey].[call_list_type] AS RETENTIONPROGRAMKEY_CALL_LIST_TYPE,[RetentionProgramKey].[cdate] AS RETENTIONPROGRAMKEY_CDATE,[RetentionProgramKey].[cid] AS RETENTIONPROGRAMKEY_CID,[RetentionProgramKey].[did] AS RETENTIONPROGRAMKEY_DID,[RetentionProgramKey].[return_date] AS RETENTIONPROGRAMKEY_RETURN_DATE,[RetentionProgramKey].[edate] AS RETENTIONPROGRAMKEY_EDATE,[RetentionProgramKey].[active] AS RETENTIONPROGRAMKEY_ACTIVE,[RetentionProgramKey].[expiry_month] AS RETENTIONPROGRAMKEY_EXPIRY_MONTH,[RetentionProgramKey].[upload_date] AS RETENTIONPROGRAMKEY_UPLOAD_DATE,[RetentionProgramKey].[ddate] AS RETENTIONPROGRAMKEY_DDATE,[RetentionProgramKey].[call_list_size] AS RETENTIONPROGRAMKEY_CALL_LIST_SIZE,[RetentionProgramKey].[center] AS RETENTIONPROGRAMKEY_CENTER,[RetentionProgramKey].[id] AS RETENTIONPROGRAMKEY_ID,[RetentionProgramKey].[program_name] AS RETENTIONPROGRAMKEY_PROGRAM_NAME,[RetentionProgramKey].[program_id] AS RETENTIONPROGRAMKEY_PROGRAM_ID,[RetentionProgramKey].[remarks] AS RETENTIONPROGRAMKEY_REMARKS,[RetentionProgramKey].[sdate] AS RETENTIONPROGRAMKEY_SDATE  FROM  [RetentionProgramKey]  WHERE  [RetentionProgramKey].[id] = \'" + x_iId.ToString() + "\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RetentionProgramKey]", "[" + Configurator.MSSQLTablePrefix + "RetentionProgramKey]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_TYPE"])) { n_sType = (string)_oData["RETENTIONPROGRAMKEY_TYPE"]; } else { n_sType = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_CALL_LIST_TYPE"])) { n_sCall_list_type = (string)_oData["RETENTIONPROGRAMKEY_CALL_LIST_TYPE"]; } else { n_sCall_list_type = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_CDATE"])) { n_dCdate = (global::System.Nullable<DateTime>)_oData["RETENTIONPROGRAMKEY_CDATE"]; } else { n_dCdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_CID"])) { n_sCid = (string)_oData["RETENTIONPROGRAMKEY_CID"]; } else { n_sCid = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_DID"])) { n_sDid = (string)_oData["RETENTIONPROGRAMKEY_DID"]; } else { n_sDid = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_RETURN_DATE"])) { n_dReturn_date = (global::System.Nullable<DateTime>)_oData["RETENTIONPROGRAMKEY_RETURN_DATE"]; } else { n_dReturn_date = null; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_EDATE"])) { n_dEdate = (global::System.Nullable<DateTime>)_oData["RETENTIONPROGRAMKEY_EDATE"]; } else { n_dEdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_ACTIVE"])) { n_bActive = (global::System.Nullable<bool>)_oData["RETENTIONPROGRAMKEY_ACTIVE"]; } else { n_bActive = null; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_EXPIRY_MONTH"])) { n_sExpiry_month = (string)_oData["RETENTIONPROGRAMKEY_EXPIRY_MONTH"]; } else { n_sExpiry_month = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_UPLOAD_DATE"])) { n_dUpload_date = (global::System.Nullable<DateTime>)_oData["RETENTIONPROGRAMKEY_UPLOAD_DATE"]; } else { n_dUpload_date = null; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_DDATE"])) { n_dDdate = (global::System.Nullable<DateTime>)_oData["RETENTIONPROGRAMKEY_DDATE"]; } else { n_dDdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_CALL_LIST_SIZE"])) { n_sCall_list_size = (string)_oData["RETENTIONPROGRAMKEY_CALL_LIST_SIZE"]; } else { n_sCall_list_size = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_CENTER"])) { n_sCenter = (string)_oData["RETENTIONPROGRAMKEY_CENTER"]; } else { n_sCenter = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_ID"])) { n_iId = (global::System.Nullable<int>)_oData["RETENTIONPROGRAMKEY_ID"]; } else { n_iId = null; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_PROGRAM_NAME"])) { n_sProgram_name = (string)_oData["RETENTIONPROGRAMKEY_PROGRAM_NAME"]; } else { n_sProgram_name = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_PROGRAM_ID"])) { n_iProgram_id = (global::System.Nullable<int>)_oData["RETENTIONPROGRAMKEY_PROGRAM_ID"]; } else { n_iProgram_id = null; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_REMARKS"])) { n_sRemarks = (string)_oData["RETENTIONPROGRAMKEY_REMARKS"]; } else { n_sRemarks = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_SDATE"])) { n_dSdate = (global::System.Nullable<DateTime>)_oData["RETENTIONPROGRAMKEY_SDATE"]; } else { n_dSdate = null; }
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
            if (n_sType == null && !(n_oTableSet.Fields(Para.type).IsNullable)) return false;
            if (n_sCall_list_type == null && !(n_oTableSet.Fields(Para.call_list_type).IsNullable)) return false;
            if (n_dCdate == null && !(n_oTableSet.Fields(Para.cdate).IsNullable)) return false;
            if (n_sCid == null && !(n_oTableSet.Fields(Para.cid).IsNullable)) return false;
            if (n_sDid == null && !(n_oTableSet.Fields(Para.did).IsNullable)) return false;
            if (n_dReturn_date == null && !(n_oTableSet.Fields(Para.return_date).IsNullable)) return false;
            if (n_dEdate == null && !(n_oTableSet.Fields(Para.edate).IsNullable)) return false;
            if (n_bActive == null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_sExpiry_month == null && !(n_oTableSet.Fields(Para.expiry_month).IsNullable)) return false;
            if (n_dUpload_date == null && !(n_oTableSet.Fields(Para.upload_date).IsNullable)) return false;
            if (n_dDdate == null && !(n_oTableSet.Fields(Para.ddate).IsNullable)) return false;
            if (n_sCall_list_size == null && !(n_oTableSet.Fields(Para.call_list_size).IsNullable)) return false;
            if (n_sCenter == null && !(n_oTableSet.Fields(Para.center).IsNullable)) return false;
            if (!x_bInsert)
            {
                if (n_iId == null && !(n_oTableSet.Fields(Para.id).IsNullable)) return false;
            }
            if (n_sProgram_name == null && !(n_oTableSet.Fields(Para.program_name).IsNullable)) return false;
            if (n_iProgram_id == null && !(n_oTableSet.Fields(Para.program_id).IsNullable)) return false;
            if (n_sRemarks == null && !(n_oTableSet.Fields(Para.remarks).IsNullable)) return false;
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
            if ((x_oObj is RetentionProgramKey) || (x_oObj is RetentionProgramKeyEntity)) return RetentionProgramKeyRepository.Instance();
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
        public RetentionProgramKeyInfo GetTableSet() { return n_oTableSet; }
        #endregion GetTableSet


        #region SetTableSet
        public void SetTableSet(RetentionProgramKeyInfo value) { n_oTableSet = value; }
        #endregion SetTableSet

        public string GetType() { return this.type; }
        public string GetCall_list_type() { return this.call_list_type; }
        public global::System.Nullable<DateTime> GetCdate() { return this.cdate; }
        public string GetCid() { return this.cid; }
        public string GetDid() { return this.did; }
        public global::System.Nullable<DateTime> GetReturn_date() { return this.return_date; }
        public global::System.Nullable<DateTime> GetEdate() { return this.edate; }
        public global::System.Nullable<bool> GetActive() { return this.active; }
        public string GetCenter() { return this.center; }
        public string GetExpiry_month() { return this.expiry_month; }
        public global::System.Nullable<DateTime> GetUpload_date() { return this.upload_date; }
        public string GetCall_list_size() { return this.call_list_size; }
        public global::System.Nullable<DateTime> GetDdate() { return this.ddate; }
        public global::System.Nullable<int> GetId() { return this.id; }
        public string GetProgram_name() { return this.program_name; }
        public global::System.Nullable<int> GetProgram_id() { return this.program_id; }
        public string GetRemarks() { return this.remarks; }
        public global::System.Nullable<DateTime> GetSdate() { return this.sdate; }

        public bool SetType(string value)
        {
            this.type = value;
            return true;
        }
        public bool SetCall_list_type(string value)
        {
            this.call_list_type = value;
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
        public bool SetDid(string value)
        {
            this.did = value;
            return true;
        }
        public bool SetReturn_date(global::System.Nullable<DateTime> value)
        {
            this.return_date = value;
            return true;
        }
        public bool SetEdate(global::System.Nullable<DateTime> value)
        {
            this.edate = value;
            return true;
        }
        public bool SetActive(global::System.Nullable<bool> value)
        {
            this.active = value;
            return true;
        }
        public bool SetCenter(string value)
        {
            this.center = value;
            return true;
        }
        public bool SetExpiry_month(string value)
        {
            this.expiry_month = value;
            return true;
        }
        public bool SetUpload_date(global::System.Nullable<DateTime> value)
        {
            this.upload_date = value;
            return true;
        }
        public bool SetCall_list_size(string value)
        {
            this.call_list_size = value;
            return true;
        }
        public bool SetDdate(global::System.Nullable<DateTime> value)
        {
            this.ddate = value;
            return true;
        }
        public bool SetId(global::System.Nullable<int> value)
        {
            this.id = value;
            return true;
        }
        public bool SetProgram_name(string value)
        {
            this.program_name = value;
            return true;
        }
        public bool SetProgram_id(global::System.Nullable<int> value)
        {
            this.program_id = value;
            return true;
        }
        public bool SetRemarks(string value)
        {
            this.remarks = value;
            return true;
        }
        public bool SetSdate(global::System.Nullable<DateTime> value)
        {
            this.sdate = value;
            return true;
        }

        public Field GetTypeTable()
        {
            return n_oTableSet.Fields(Para.type);
        }
        public Field GetCall_list_typeTable()
        {
            return n_oTableSet.Fields(Para.call_list_type);
        }
        public Field GetCdateTable()
        {
            return n_oTableSet.Fields(Para.cdate);
        }
        public Field GetCidTable()
        {
            return n_oTableSet.Fields(Para.cid);
        }
        public Field GetDidTable()
        {
            return n_oTableSet.Fields(Para.did);
        }
        public Field GetReturn_dateTable()
        {
            return n_oTableSet.Fields(Para.return_date);
        }
        public Field GetEdateTable()
        {
            return n_oTableSet.Fields(Para.edate);
        }
        public Field GetActiveTable()
        {
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetCenterTable()
        {
            return n_oTableSet.Fields(Para.center);
        }
        public Field GetExpiry_monthTable()
        {
            return n_oTableSet.Fields(Para.expiry_month);
        }
        public Field GetUpload_dateTable()
        {
            return n_oTableSet.Fields(Para.upload_date);
        }
        public Field GetCall_list_sizeTable()
        {
            return n_oTableSet.Fields(Para.call_list_size);
        }
        public Field GetDdateTable()
        {
            return n_oTableSet.Fields(Para.ddate);
        }
        public Field GetIdTable()
        {
            return n_oTableSet.Fields(Para.id);
        }
        public Field GetProgram_nameTable()
        {
            return n_oTableSet.Fields(Para.program_name);
        }
        public Field GetProgram_idTable()
        {
            return n_oTableSet.Fields(Para.program_id);
        }
        public Field GetRemarksTable()
        {
            return n_oTableSet.Fields(Para.remarks);
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

        public bool EqualID(RetentionProgramKey x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }

        public bool Equals(RetentionProgramKey x_oObj)
        {
            if (x_oObj == null) return false;
            if (!this.n_sType.Equals(x_oObj.type)) { return false; }
            if (!this.n_sCall_list_type.Equals(x_oObj.call_list_type)) { return false; }
            if (!this.n_dCdate.Equals(x_oObj.cdate)) { return false; }
            if (!this.n_sCid.Equals(x_oObj.cid)) { return false; }
            if (!this.n_sDid.Equals(x_oObj.did)) { return false; }
            if (!this.n_dReturn_date.Equals(x_oObj.return_date)) { return false; }
            if (!this.n_dEdate.Equals(x_oObj.edate)) { return false; }
            if (!this.n_bActive.Equals(x_oObj.active)) { return false; }
            if (!this.n_sExpiry_month.Equals(x_oObj.expiry_month)) { return false; }
            if (!this.n_dUpload_date.Equals(x_oObj.upload_date)) { return false; }
            if (!this.n_dDdate.Equals(x_oObj.ddate)) { return false; }
            if (!this.n_sCall_list_size.Equals(x_oObj.call_list_size)) { return false; }
            if (!this.n_sCenter.Equals(x_oObj.center)) { return false; }
            if (!this.n_iId.Equals(x_oObj.id)) { return false; }
            if (!this.n_sProgram_name.Equals(x_oObj.program_name)) { return false; }
            if (!this.n_iProgram_id.Equals(x_oObj.program_id)) { return false; }
            if (!this.n_sRemarks.Equals(x_oObj.remarks)) { return false; }
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
            string _sQuery = "UPDATE  [RetentionProgramKey]  SET  [type]=@type,[call_list_type]=@call_list_type,[cdate]=@cdate,[cid]=@cid,[did]=@did,[return_date]=@return_date,[edate]=@edate,[active]=@active,[expiry_month]=@expiry_month,[upload_date]=@upload_date,[ddate]=@ddate,[call_list_size]=@call_list_size,[center]=@center,[program_name]=@program_name,[program_id]=@program_id,[remarks]=@remarks,[sdate]=@sdate  WHERE [RetentionProgramKey].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RetentionProgramKey]", "[" + Configurator.MSSQLTablePrefix + "RetentionProgramKey]"); }
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
            if (n_sType == null) { _oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar, 10).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar, 10).Value = n_sType; }
            if (n_sCall_list_type == null) { _oCmd.Parameters.Add("@call_list_type", global::System.Data.SqlDbType.NVarChar, 20).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@call_list_type", global::System.Data.SqlDbType.NVarChar, 20).Value = n_sCall_list_type; }
            if (n_dCdate == null) { _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = n_dCdate; }
            if (n_sCid == null) { _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar, 50).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar, 50).Value = n_sCid; }
            if (n_sDid == null) { _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar, 50).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar, 50).Value = n_sDid; }
            if (n_dReturn_date == null) { _oCmd.Parameters.Add("@return_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { _oCmd.Parameters.Add("@return_date", global::System.Data.SqlDbType.DateTime).Value = n_dReturn_date; }
            if (n_dEdate == null) { _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = n_dEdate; }
            if (n_bActive == null) { _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = n_bActive; }
            if (n_sExpiry_month == null) { _oCmd.Parameters.Add("@expiry_month", global::System.Data.SqlDbType.NVarChar, 20).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@expiry_month", global::System.Data.SqlDbType.NVarChar, 20).Value = n_sExpiry_month; }
            if (n_dUpload_date == null) { _oCmd.Parameters.Add("@upload_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { _oCmd.Parameters.Add("@upload_date", global::System.Data.SqlDbType.DateTime).Value = n_dUpload_date; }
            if (n_dDdate == null) { _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = n_dDdate; }
            if (n_sCall_list_size == null) { _oCmd.Parameters.Add("@call_list_size", global::System.Data.SqlDbType.NVarChar, 20).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@call_list_size", global::System.Data.SqlDbType.NVarChar, 20).Value = n_sCall_list_size; }
            if (n_sCenter == null) { _oCmd.Parameters.Add("@center", global::System.Data.SqlDbType.NVarChar, 10).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@center", global::System.Data.SqlDbType.NVarChar, 10).Value = n_sCenter; }
            if (n_iId == null) { _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = n_iId; }
            if (n_sProgram_name == null) { _oCmd.Parameters.Add("@program_name", global::System.Data.SqlDbType.NVarChar, 100).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@program_name", global::System.Data.SqlDbType.NVarChar, 100).Value = n_sProgram_name; }
            if (n_iProgram_id == null) { _oCmd.Parameters.Add("@program_id", global::System.Data.SqlDbType.Int).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@program_id", global::System.Data.SqlDbType.Int).Value = n_iProgram_id; }
            if (n_sRemarks == null) { _oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.NVarChar, 150).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.NVarChar, 150).Value = n_sRemarks; }
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
        /// Summary description for table [RetentionProgramKey] Delete Record
        /// </summary>

        public bool Delete()
        {
            if (n_iId == null) { return false; }
            string _sQuery = "DELETE FROM  [RetentionProgramKey]  WHERE [RetentionProgramKey].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RetentionProgramKey]", "[" + Configurator.MSSQLTablePrefix + "RetentionProgramKey]"); }
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
        /// Summary description for table [RetentionProgramKey] Object Base Clone
        /// </summary>

        public RetentionProgramKey DeepClone()
        {
            RetentionProgramKey _oRetentionProgramKey_Clone = (RetentionProgramKey)RetentionProgramKeyRepository.CreateEntityInstanceObject();
            _oRetentionProgramKey_Clone.type = this.n_sType;
            _oRetentionProgramKey_Clone.call_list_type = this.n_sCall_list_type;
            _oRetentionProgramKey_Clone.cdate = this.n_dCdate;
            _oRetentionProgramKey_Clone.cid = this.n_sCid;
            _oRetentionProgramKey_Clone.did = this.n_sDid;
            _oRetentionProgramKey_Clone.return_date = this.n_dReturn_date;
            _oRetentionProgramKey_Clone.edate = this.n_dEdate;
            _oRetentionProgramKey_Clone.active = this.n_bActive;
            _oRetentionProgramKey_Clone.expiry_month = this.n_sExpiry_month;
            _oRetentionProgramKey_Clone.upload_date = this.n_dUpload_date;
            _oRetentionProgramKey_Clone.ddate = this.n_dDdate;
            _oRetentionProgramKey_Clone.call_list_size = this.n_sCall_list_size;
            _oRetentionProgramKey_Clone.center = this.n_sCenter;
            _oRetentionProgramKey_Clone.id = this.n_iId;
            _oRetentionProgramKey_Clone.program_name = this.n_sProgram_name;
            _oRetentionProgramKey_Clone.program_id = this.n_iProgram_id;
            _oRetentionProgramKey_Clone.remarks = this.n_sRemarks;
            _oRetentionProgramKey_Clone.sdate = this.n_dSdate;
            _oRetentionProgramKey_Clone.SetFound(this.n_bFound);
            _oRetentionProgramKey_Clone.SetDB(this.n_oDB);
            _oRetentionProgramKey_Clone.SetRow(this.n_oRow);
            _oRetentionProgramKey_Clone.SetTbl(this.n_oTbl);
            _oRetentionProgramKey_Clone.SetTableSet(this.n_oTableSet);

            return _oRetentionProgramKey_Clone;
        }
        #endregion

        #region Release

        /// <summary>
        /// Summary description for Release
        /// </summary>

        public void Release()
        {
            n_sType = string.Empty;
            n_sCall_list_type = string.Empty;
            n_dCdate = null;
            n_sCid = string.Empty;
            n_sDid = string.Empty;
            n_dReturn_date = null;
            n_dEdate = null;
            n_bActive = null;
            n_sExpiry_month = string.Empty;
            n_dUpload_date = null;
            n_dDdate = null;
            n_sCall_list_size = string.Empty;
            n_sCenter = string.Empty;
            n_iId = null;
            n_sProgram_name = string.Empty;
            n_iProgram_id = null;
            n_sRemarks = string.Empty;
            n_dSdate = null;
            n_oDB = null;
            n_bFound = false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = new RetentionProgramKeyInfo();
        }
        #endregion
    }
}

