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
///-- Description:	<Description,Table :[MobileGoWirelessDetail],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE
{

    /// <summary>
    /// Summary description for table [MobileGoWirelessDetail] Object Base layer
    /// </summary>

    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix + "MobileGoWirelessDetail")]
    public class MobileGoWirelessDetailEntity : global::System.IDisposable, global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>
    {


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


        protected global::System.Nullable<bool> n_bAssign = null;
        #region assign
        [System.Data.Linq.Mapping.Column(Name = "[assign]", Storage = "n_bAssign")]
        public global::System.Nullable<bool> assign
        {
            get
            {
                return this.n_bAssign;
            }
            set
            {
                this.n_bAssign = value;
            }
        }
        #endregion assign


        protected global::System.Nullable<int> n_iMrt_no = null;
        #region mrt_no
        [System.Data.Linq.Mapping.Column(Name = "[mrt_no]", Storage = "n_iMrt_no")]
        public global::System.Nullable<int> mrt_no
        {
            get
            {
                return this.n_iMrt_no;
            }
            set
            {
                this.n_iMrt_no = value;
            }
        }
        #endregion mrt_no


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


        protected string n_sAssign_staff = string.Empty;
        #region assign_staff
        [System.Data.Linq.Mapping.Column(Name = "[assign_staff]", Storage = "n_sAssign_staff")]
        public string assign_staff
        {
            get
            {
                return this.n_sAssign_staff;
            }
            set
            {
                this.n_sAssign_staff = value;
            }
        }
        #endregion assign_staff


        protected global::System.Nullable<DateTime> n_dAssign_date = null;
        #region assign_date
        [System.Data.Linq.Mapping.Column(Name = "[assign_date]", Storage = "n_dAssign_date")]
        public global::System.Nullable<DateTime> assign_date
        {
            get
            {
                return this.n_dAssign_date;
            }
            set
            {
                this.n_dAssign_date = value;
            }
        }
        #endregion assign_date


        protected global::System.Nullable<int> n_iOrder_id = null;
        #region order_id
        [System.Data.Linq.Mapping.Column(Name = "[order_id]", Storage = "n_iOrder_id")]
        public global::System.Nullable<int> order_id
        {
            get
            {
                return this.n_iOrder_id;
            }
            set
            {
                this.n_iOrder_id = value;
            }
        }
        #endregion order_id


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

        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound = false;
        private global::System.Data.DataTable n_oTbl = null;
        private global::System.Data.DataRow n_oRow = null;
        private MobileGoWirelessDetailInfo n_oTableSet = new MobileGoWirelessDetailInfo();
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        #endregion

        #region Parameter String
        public class Para
        {
            public const string cid = "cid";
            public const string id = "id";
            public const string cdate = "cdate";
            public const string assign = "assign";
            public const string mrt_no = "mrt_no";
            public const string active = "active";
            public const string assign_staff = "assign_staff";
            public const string assign_date = "assign_date";
            public const string order_id = "order_id";
            public const string ddate = "ddate";
            public const string did = "did";
            public const string MobileGoWirelessDetail_table_name = Configurator.MSSQLTablePrefix + "MobileGoWirelessDetail";
            public static string TableName() { return MobileGoWirelessDetail_table_name; }
        }
        #endregion Parameter String

        #region Constructor
        public MobileGoWirelessDetailEntity()
        {
            Init();
        }
        public MobileGoWirelessDetailEntity(MSSQLConnect x_oDB)
        {
            n_oDB = x_oDB;
            Init();
        }

        public MobileGoWirelessDetailEntity(MSSQLConnect x_oDB, System.Nullable<int> x_iId)
        {
            n_oDB = x_oDB;
            this.Load(x_iId);
            Init();
        }

        ~MobileGoWirelessDetailEntity()
        {
            this.Release();
        }
        #endregion

        #region Load

        public bool Load(global::System.Nullable<int> x_iId)
        {
            if (n_oDB == null) { return false; }
            if (x_iId == null) { return false; }
            string _sQuery = "SELECT [MobileGoWirelessDetail].[cid] AS MobileGoWirelessDetail_CID,[MobileGoWirelessDetail].[id] AS MobileGoWirelessDetail_ID,[MobileGoWirelessDetail].[cdate] AS MobileGoWirelessDetail_CDATE,[MobileGoWirelessDetail].[assign] AS MobileGoWirelessDetail_ASSIGN,[MobileGoWirelessDetail].[mrt_no] AS MobileGoWirelessDetail_MRT_NO,[MobileGoWirelessDetail].[active] AS MobileGoWirelessDetail_ACTIVE,[MobileGoWirelessDetail].[assign_staff] AS MobileGoWirelessDetail_ASSIGN_STAFF,[MobileGoWirelessDetail].[assign_date] AS MobileGoWirelessDetail_ASSIGN_DATE,[MobileGoWirelessDetail].[order_id] AS MobileGoWirelessDetail_ORDER_ID,[MobileGoWirelessDetail].[ddate] AS MobileGoWirelessDetail_DDATE,[MobileGoWirelessDetail].[did] AS MobileGoWirelessDetail_DID  FROM  [MobileGoWirelessDetail]  WHERE  [MobileGoWirelessDetail].[id] = \'" + x_iId.ToString() + "\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileGoWirelessDetail]", "[" + Configurator.MSSQLTablePrefix + "MobileGoWirelessDetail]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["MobileGoWirelessDetail_CID"])) { n_sCid = (string)_oData["MobileGoWirelessDetail_CID"]; } else { n_sCid = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["MobileGoWirelessDetail_ID"])) { n_iId = (global::System.Nullable<int>)_oData["MobileGoWirelessDetail_ID"]; } else { n_iId = null; }
                        if (!global::System.Convert.IsDBNull(_oData["MobileGoWirelessDetail_CDATE"])) { n_dCdate = (global::System.Nullable<DateTime>)_oData["MobileGoWirelessDetail_CDATE"]; } else { n_dCdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["MobileGoWirelessDetail_ASSIGN"])) { n_bAssign = (global::System.Nullable<bool>)_oData["MobileGoWirelessDetail_ASSIGN"]; } else { n_bAssign = null; }
                        if (!global::System.Convert.IsDBNull(_oData["MobileGoWirelessDetail_MRT_NO"])) { n_iMrt_no = (global::System.Nullable<int>)_oData["MobileGoWirelessDetail_MRT_NO"]; } else { n_iMrt_no = null; }
                        if (!global::System.Convert.IsDBNull(_oData["MobileGoWirelessDetail_ACTIVE"])) { n_bActive = (global::System.Nullable<bool>)_oData["MobileGoWirelessDetail_ACTIVE"]; } else { n_bActive = null; }
                        if (!global::System.Convert.IsDBNull(_oData["MobileGoWirelessDetail_ASSIGN_STAFF"])) { n_sAssign_staff = (string)_oData["MobileGoWirelessDetail_ASSIGN_STAFF"]; } else { n_sAssign_staff = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["MobileGoWirelessDetail_ASSIGN_DATE"])) { n_dAssign_date = (global::System.Nullable<DateTime>)_oData["MobileGoWirelessDetail_ASSIGN_DATE"]; } else { n_dAssign_date = null; }
                        if (!global::System.Convert.IsDBNull(_oData["MobileGoWirelessDetail_ORDER_ID"])) { n_iOrder_id = (global::System.Nullable<int>)_oData["MobileGoWirelessDetail_ORDER_ID"]; } else { n_iOrder_id = null; }
                        if (!global::System.Convert.IsDBNull(_oData["MobileGoWirelessDetail_DDATE"])) { n_dDdate = (global::System.Nullable<DateTime>)_oData["MobileGoWirelessDetail_DDATE"]; } else { n_dDdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["MobileGoWirelessDetail_DID"])) { n_sDid = (string)_oData["MobileGoWirelessDetail_DID"]; } else { n_sDid = string.Empty; }
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
            if (n_sCid == null && !(n_oTableSet.Fields(Para.cid).IsNullable)) return false;
            if (!x_bInsert)
            {
                if (n_iId == null && !(n_oTableSet.Fields(Para.id).IsNullable)) return false;
            }
            if (n_dCdate == null && !(n_oTableSet.Fields(Para.cdate).IsNullable)) return false;
            if (n_bAssign == null && !(n_oTableSet.Fields(Para.assign).IsNullable)) return false;
            if (n_iMrt_no == null && !(n_oTableSet.Fields(Para.mrt_no).IsNullable)) return false;
            if (n_bActive == null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_sAssign_staff == null && !(n_oTableSet.Fields(Para.assign_staff).IsNullable)) return false;
            if (n_dAssign_date == null && !(n_oTableSet.Fields(Para.assign_date).IsNullable)) return false;
            if (n_iOrder_id == null && !(n_oTableSet.Fields(Para.order_id).IsNullable)) return false;
            if (n_dDdate == null && !(n_oTableSet.Fields(Para.ddate).IsNullable)) return false;
            if (n_sDid == null && !(n_oTableSet.Fields(Para.did).IsNullable)) return false;
            return true;
        }
        #endregion

        #region Get & Set

        /// <summary>
        /// Summary description for Get & Set this all class parameters
        /// </summary>


        public object GetRepositoryObject(object x_oObj)
        {
            if ((x_oObj is MobileGoWirelessDetail) || (x_oObj is MobileGoWirelessDetail )) return MobileGoWirelessDetailRepository.Instance();
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
        public MobileGoWirelessDetailInfo GetTableSet() { return n_oTableSet; }
        #endregion GetTableSet


        #region SetTableSet
        public void SetTableSet(MobileGoWirelessDetailInfo value) { n_oTableSet = value; }
        #endregion SetTableSet

        public string GetCid() { return this.cid; }
        public global::System.Nullable<int> GetId() { return this.id; }
        public global::System.Nullable<DateTime> GetCdate() { return this.cdate; }
        public global::System.Nullable<bool> GetAssign() { return this.assign; }
        public global::System.Nullable<int> GetMrt_no() { return this.mrt_no; }
        public global::System.Nullable<bool> GetActive() { return this.active; }
        public string GetAssign_staff() { return this.assign_staff; }
        public global::System.Nullable<DateTime> GetAssign_date() { return this.assign_date; }
        public global::System.Nullable<int> GetOrder_id() { return this.order_id; }
        public global::System.Nullable<DateTime> GetDdate() { return this.ddate; }
        public string GetDid() { return this.did; }

        public bool SetCid(string value)
        {
            this.cid = value;
            return true;
        }
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
        public bool SetAssign(global::System.Nullable<bool> value)
        {
            this.assign = value;
            return true;
        }
        public bool SetMrt_no(global::System.Nullable<int> value)
        {
            this.mrt_no = value;
            return true;
        }
        public bool SetActive(global::System.Nullable<bool> value)
        {
            this.active = value;
            return true;
        }
        public bool SetAssign_staff(string value)
        {
            this.assign_staff = value;
            return true;
        }
        public bool SetAssign_date(global::System.Nullable<DateTime> value)
        {
            this.assign_date = value;
            return true;
        }
        public bool SetOrder_id(global::System.Nullable<int> value)
        {
            this.order_id = value;
            return true;
        }
        public bool SetDdate(global::System.Nullable<DateTime> value)
        {
            this.ddate = value;
            return true;
        }
        public bool SetDid(string value)
        {
            this.did = value;
            return true;
        }

        public Field GetCidTable()
        {
            return n_oTableSet.Fields(Para.cid);
        }
        public Field GetIdTable()
        {
            return n_oTableSet.Fields(Para.id);
        }
        public Field GetCdateTable()
        {
            return n_oTableSet.Fields(Para.cdate);
        }
        public Field GetAssignTable()
        {
            return n_oTableSet.Fields(Para.assign);
        }
        public Field GetMrt_noTable()
        {
            return n_oTableSet.Fields(Para.mrt_no);
        }
        public Field GetActiveTable()
        {
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetAssign_staffTable()
        {
            return n_oTableSet.Fields(Para.assign_staff);
        }
        public Field GetAssign_dateTable()
        {
            return n_oTableSet.Fields(Para.assign_date);
        }
        public Field GetOrder_idTable()
        {
            return n_oTableSet.Fields(Para.order_id);
        }
        public Field GetDdateTable()
        {
            return n_oTableSet.Fields(Para.ddate);
        }
        public Field GetDidTable()
        {
            return n_oTableSet.Fields(Para.did);
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

        public bool EqualID(MobileGoWirelessDetail x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }

        public bool Equals(MobileGoWirelessDetail x_oObj)
        {
            if (x_oObj == null) return false;
            if (!this.n_sCid.Equals(x_oObj.cid)) { return false; }
            if (!this.n_iId.Equals(x_oObj.id)) { return false; }
            if (!this.n_dCdate.Equals(x_oObj.cdate)) { return false; }
            if (!this.n_bAssign.Equals(x_oObj.assign)) { return false; }
            if (!this.n_iMrt_no.Equals(x_oObj.mrt_no)) { return false; }
            if (!this.n_bActive.Equals(x_oObj.active)) { return false; }
            if (!this.n_sAssign_staff.Equals(x_oObj.assign_staff)) { return false; }
            if (!this.n_dAssign_date.Equals(x_oObj.assign_date)) { return false; }
            if (!this.n_iOrder_id.Equals(x_oObj.order_id)) { return false; }
            if (!this.n_dDdate.Equals(x_oObj.ddate)) { return false; }
            if (!this.n_sDid.Equals(x_oObj.did)) { return false; }
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
            string _sQuery = "UPDATE  [MobileGoWirelessDetail]  SET  [cid]=@cid,[cdate]=@cdate,[assign]=@assign,[mrt_no]=@mrt_no,[active]=@active,[assign_staff]=@assign_staff,[assign_date]=@assign_date,[order_id]=@order_id,[ddate]=@ddate,[did]=@did  WHERE [MobileGoWirelessDetail].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileGoWirelessDetail]", "[" + Configurator.MSSQLTablePrefix + "MobileGoWirelessDetail]"); }
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
            if (n_sCid == null) { _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar, 50).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar, 50).Value = n_sCid; }
            if (n_iId == null) { _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = n_iId; }
            if (n_dCdate == null) { _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = n_dCdate; }
            if (n_bAssign == null) { _oCmd.Parameters.Add("@assign", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@assign", global::System.Data.SqlDbType.Bit).Value = n_bAssign; }
            if (n_iMrt_no == null) { _oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.Int).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.Int).Value = n_iMrt_no; }
            if (n_bActive == null) { _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = n_bActive; }
            if (n_sAssign_staff == null) { _oCmd.Parameters.Add("@assign_staff", global::System.Data.SqlDbType.NVarChar, 50).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@assign_staff", global::System.Data.SqlDbType.NVarChar, 50).Value = n_sAssign_staff; }
            if (n_dAssign_date == null) { _oCmd.Parameters.Add("@assign_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { _oCmd.Parameters.Add("@assign_date", global::System.Data.SqlDbType.DateTime).Value = n_dAssign_date; }
            if (n_iOrder_id == null) { _oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = n_iOrder_id; }
            if (n_dDdate == null) { _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = n_dDdate; }
            if (n_sDid == null) { _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar, 50).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar, 50).Value = n_sDid; }
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
        /// Summary description for table [MobileGoWirelessDetail] Delete Record
        /// </summary>

        public bool Delete()
        {
            if (n_iId == null) { return false; }
            string _sQuery = "DELETE FROM  [MobileGoWirelessDetail]  WHERE [MobileGoWirelessDetail].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileGoWirelessDetail]", "[" + Configurator.MSSQLTablePrefix + "MobileGoWirelessDetail]"); }
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
        /// Summary description for table [MobileGoWirelessDetail] Object Base Clone
        /// </summary>

        public MobileGoWirelessDetail DeepClone()
        {
            MobileGoWirelessDetail _oMobileGoWirelessDetail_Clone = (MobileGoWirelessDetail)MobileGoWirelessDetailRepository.CreateEntityInstanceObject();
            _oMobileGoWirelessDetail_Clone.cid = this.n_sCid;
            _oMobileGoWirelessDetail_Clone.id = this.n_iId;
            _oMobileGoWirelessDetail_Clone.cdate = this.n_dCdate;
            _oMobileGoWirelessDetail_Clone.assign = this.n_bAssign;
            _oMobileGoWirelessDetail_Clone.mrt_no = this.n_iMrt_no;
            _oMobileGoWirelessDetail_Clone.active = this.n_bActive;
            _oMobileGoWirelessDetail_Clone.assign_staff = this.n_sAssign_staff;
            _oMobileGoWirelessDetail_Clone.assign_date = this.n_dAssign_date;
            _oMobileGoWirelessDetail_Clone.order_id = this.n_iOrder_id;
            _oMobileGoWirelessDetail_Clone.ddate = this.n_dDdate;
            _oMobileGoWirelessDetail_Clone.did = this.n_sDid;
            _oMobileGoWirelessDetail_Clone.SetFound(this.n_bFound);
            _oMobileGoWirelessDetail_Clone.SetDB(this.n_oDB);
            _oMobileGoWirelessDetail_Clone.SetRow(this.n_oRow);
            _oMobileGoWirelessDetail_Clone.SetTbl(this.n_oTbl);
            _oMobileGoWirelessDetail_Clone.SetTableSet(this.n_oTableSet);

            return _oMobileGoWirelessDetail_Clone;
        }
        #endregion

        #region Release

        /// <summary>
        /// Summary description for Release
        /// </summary>

        public void Release()
        {
            n_sCid = string.Empty;
            n_iId = null;
            n_dCdate = null;
            n_bAssign = null;
            n_iMrt_no = null;
            n_bActive = null;
            n_sAssign_staff = string.Empty;
            n_dAssign_date = null;
            n_iOrder_id = null;
            n_dDdate = null;
            n_sDid = string.Empty;
            n_oDB = null;
            n_bFound = false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = new MobileGoWirelessDetailInfo();
        }
        #endregion
    }
}

