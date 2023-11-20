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
///-- Description:	<Description,Table :[CustomerAccount],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE
{

    /// <summary>
    /// Summary description for table [CustomerAccount] Object Base layer
    /// </summary>

    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix + "CustomerAccount")]
    public class CustomerAccountEntity : global::System.IDisposable, global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>
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


        protected string n_sMrt_no = string.Empty;
        #region mrt_no
        [System.Data.Linq.Mapping.Column(Name = "[mrt_no]", Storage = "n_sMrt_no")]
        public string mrt_no
        {
            get
            {
                return this.n_sMrt_no;
            }
            set
            {
                this.n_sMrt_no = value;
            }
        }
        #endregion mrt_no


        protected string n_sActive = string.Empty;
        #region active
        [System.Data.Linq.Mapping.Column(Name = "[active]", Storage = "n_sActive")]
        public string active
        {
            get
            {
                return this.n_sActive;
            }
            set
            {
                this.n_sActive = value;
            }
        }
        #endregion active


        protected string n_sAc_no = string.Empty;
        #region ac_no
        [System.Data.Linq.Mapping.Column(Name = "[ac_no]", Storage = "n_sAc_no")]
        public string ac_no
        {
            get
            {
                return this.n_sAc_no;
            }
            set
            {
                this.n_sAc_no = value;
            }
        }
        #endregion ac_no


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

        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound = false;
        private global::System.Data.DataTable n_oTbl = null;
        private global::System.Data.DataRow n_oRow = null;
        private CustomerAccountInfo n_oTableSet = new CustomerAccountInfo();
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        #endregion

        #region Parameter String
        public class Para
        {
            public const string remarks = "remarks";
            public const string id = "id";
            public const string cdate = "cdate";
            public const string cid = "cid";
            public const string mrt_no = "mrt_no";
            public const string active = "active";
            public const string ac_no = "ac_no";
            public const string order_id = "order_id";
            public const string ddate = "ddate";
            public const string did = "did";
            public const string CustomerAccount_table_name = Configurator.MSSQLTablePrefix + "CustomerAccount";
            public static string TableName() { return CustomerAccount_table_name; }
        }
        #endregion Parameter String

        #region Constructor
        public CustomerAccountEntity()
        {
            Init();
        }
        public CustomerAccountEntity(MSSQLConnect x_oDB)
        {
            n_oDB = x_oDB;
            Init();
        }

        public CustomerAccountEntity(MSSQLConnect x_oDB, System.Nullable<int> x_iId)
        {
            n_oDB = x_oDB;
            this.Load(x_iId);
            Init();
        }

        ~CustomerAccountEntity()
        {
            this.Release();
        }
        #endregion

        #region Load

        public bool Load(global::System.Nullable<int> x_iId)
        {
            if (n_oDB == null) { return false; }
            if (x_iId == null) { return false; }
            string _sQuery = "SELECT [CustomerAccount].[id] AS CUSTOMERACCOUNT_ID,[CustomerAccount].[cdate] AS CUSTOMERACCOUNT_CDATE,[CustomerAccount].[cid] AS CUSTOMERACCOUNT_CID,[CustomerAccount].[mrt_no] AS CUSTOMERACCOUNT_MRT_NO,[CustomerAccount].[active] AS CUSTOMERACCOUNT_ACTIVE,[CustomerAccount].[ac_no] AS CUSTOMERACCOUNT_AC_NO,[CustomerAccount].[order_id] AS CUSTOMERACCOUNT_ORDER_ID,[CustomerAccount].[did] AS CUSTOMERACCOUNT_DID,[CustomerAccount].[ddate] AS CUSTOMERACCOUNT_DDATE,[CustomerAccount].[remarks] AS CUSTOMERACCOUNT_REMARKS  FROM  [CustomerAccount]  WHERE  [CustomerAccount].[id] = \'" + x_iId.ToString() + "\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[CustomerAccount]", "[" + Configurator.MSSQLTablePrefix + "CustomerAccount]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_ID"])) { n_iId = (global::System.Nullable<int>)_oData["CUSTOMERACCOUNT_ID"]; } else { n_iId = null; }
                        if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_CDATE"])) { n_dCdate = (global::System.Nullable<DateTime>)_oData["CUSTOMERACCOUNT_CDATE"]; } else { n_dCdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_CID"])) { n_sCid = (string)_oData["CUSTOMERACCOUNT_CID"]; } else { n_sCid = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_MRT_NO"])) { n_sMrt_no = (string)_oData["CUSTOMERACCOUNT_MRT_NO"]; } else { n_sMrt_no = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_ACTIVE"])) { n_sActive = (string)_oData["CUSTOMERACCOUNT_ACTIVE"]; } else { n_sActive = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_AC_NO"])) { n_sAc_no = (string)_oData["CUSTOMERACCOUNT_AC_NO"]; } else { n_sAc_no = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_ORDER_ID"])) { n_iOrder_id = (global::System.Nullable<int>)_oData["CUSTOMERACCOUNT_ORDER_ID"]; } else { n_iOrder_id = null; }
                        if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_DID"])) { n_sDid = (string)_oData["CUSTOMERACCOUNT_DID"]; } else { n_sDid = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_DDATE"])) { n_dDdate = (global::System.Nullable<DateTime>)_oData["CUSTOMERACCOUNT_DDATE"]; } else { n_dDdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_REMARKS"])) { n_sRemarks = (string)_oData["CUSTOMERACCOUNT_REMARKS"]; } else { n_sRemarks = string.Empty; }
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
            if (n_sMrt_no == null && !(n_oTableSet.Fields(Para.mrt_no).IsNullable)) return false;
            if (n_sActive == null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_sAc_no == null && !(n_oTableSet.Fields(Para.ac_no).IsNullable)) return false;
            if (n_iOrder_id == null && !(n_oTableSet.Fields(Para.order_id).IsNullable)) return false;
            if (n_sDid == null && !(n_oTableSet.Fields(Para.did).IsNullable)) return false;
            if (n_dDdate == null && !(n_oTableSet.Fields(Para.ddate).IsNullable)) return false;
            if (n_sRemarks == null && !(n_oTableSet.Fields(Para.remarks).IsNullable)) return false;
            return true;
        }
        #endregion

        #region Get & Set

        /// <summary>
        /// Summary description for Get & Set this all class parameters
        /// </summary>


        public object GetRepositoryObject(object x_oObj)
        {
            if ((x_oObj is CustomerAccount) || (x_oObj is CustomerAccountEntity)) return CustomerAccountRepository.Instance();
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
        public CustomerAccountInfo GetTableSet() { return n_oTableSet; }
        #endregion GetTableSet


        #region SetTableSet
        public void SetTableSet(CustomerAccountInfo value) { n_oTableSet = value; }
        #endregion SetTableSet

        public string GetRemarks() { return this.remarks; }
        public global::System.Nullable<int> GetId() { return this.id; }
        public global::System.Nullable<DateTime> GetCdate() { return this.cdate; }
        public string GetCid() { return this.cid; }
        public string GetMrt_no() { return this.mrt_no; }
        public string GetActive() { return this.active; }
        public string GetAc_no() { return this.ac_no; }
        public global::System.Nullable<int> GetOrder_id() { return this.order_id; }
        public global::System.Nullable<DateTime> GetDdate() { return this.ddate; }
        public string GetDid() { return this.did; }

        public bool SetRemarks(string value)
        {
            this.remarks = value;
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
        public bool SetCid(string value)
        {
            this.cid = value;
            return true;
        }
        public bool SetMrt_no(string value)
        {
            this.mrt_no = value;
            return true;
        }
        public bool SetActive(string value)
        {
            this.active = value;
            return true;
        }
        public bool SetAc_no(string value)
        {
            this.ac_no = value;
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

        public Field GetRemarksTable()
        {
            return n_oTableSet.Fields(Para.remarks);
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
        public Field GetMrt_noTable()
        {
            return n_oTableSet.Fields(Para.mrt_no);
        }
        public Field GetActiveTable()
        {
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetAc_noTable()
        {
            return n_oTableSet.Fields(Para.ac_no);
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

        public bool EqualID(CustomerAccount x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }

        public bool Equals(CustomerAccount x_oObj)
        {
            if (x_oObj == null) return false;
            if (!this.n_iId.Equals(x_oObj.id)) { return false; }
            if (!this.n_dCdate.Equals(x_oObj.cdate)) { return false; }
            if (!this.n_sCid.Equals(x_oObj.cid)) { return false; }
            if (!this.n_sMrt_no.Equals(x_oObj.mrt_no)) { return false; }
            if (!this.n_sActive.Equals(x_oObj.active)) { return false; }
            if (!this.n_sAc_no.Equals(x_oObj.ac_no)) { return false; }
            if (!this.n_iOrder_id.Equals(x_oObj.order_id)) { return false; }
            if (!this.n_sDid.Equals(x_oObj.did)) { return false; }
            if (!this.n_dDdate.Equals(x_oObj.ddate)) { return false; }
            if (!this.n_sRemarks.Equals(x_oObj.remarks)) { return false; }
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
            string _sQuery = "UPDATE  [CustomerAccount]  SET  [cdate]=@cdate,[cid]=@cid,[mrt_no]=@mrt_no,[active]=@active,[ac_no]=@ac_no,[order_id]=@order_id,[did]=@did,[ddate]=@ddate,[remarks]=@remarks  WHERE [CustomerAccount].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[CustomerAccount]", "[" + Configurator.MSSQLTablePrefix + "CustomerAccount]"); }
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
            if (n_sMrt_no == null) { _oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.Char, 10).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.Char, 10).Value = n_sMrt_no; }
            if (n_sActive == null) { _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Char, 10).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Char, 10).Value = n_sActive; }
            if (n_sAc_no == null) { _oCmd.Parameters.Add("@ac_no", global::System.Data.SqlDbType.Char, 10).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@ac_no", global::System.Data.SqlDbType.Char, 10).Value = n_sAc_no; }
            if (n_iOrder_id == null) { _oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = n_iOrder_id; }
            if (n_sDid == null) { _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10).Value = n_sDid; }
            if (n_dDdate == null) { _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = n_dDdate; }
            if (n_sRemarks == null) { _oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.Text, 2147483647).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.Text, 2147483647).Value = n_sRemarks; }
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
        /// Summary description for table [CustomerAccount] Delete Record
        /// </summary>

        public bool Delete()
        {
            if (n_iId == null) { return false; }
            string _sQuery = "DELETE FROM  [CustomerAccount]  WHERE [CustomerAccount].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[CustomerAccount]", "[" + Configurator.MSSQLTablePrefix + "CustomerAccount]"); }
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
        /// Summary description for table [CustomerAccount] Object Base Clone
        /// </summary>

        public CustomerAccount DeepClone()
        {
            CustomerAccount _oCustomerAccount_Clone = (CustomerAccount)CustomerAccountRepository.CreateEntityInstanceObject();
            _oCustomerAccount_Clone.id = this.n_iId;
            _oCustomerAccount_Clone.cdate = this.n_dCdate;
            _oCustomerAccount_Clone.cid = this.n_sCid;
            _oCustomerAccount_Clone.mrt_no = this.n_sMrt_no;
            _oCustomerAccount_Clone.active = this.n_sActive;
            _oCustomerAccount_Clone.ac_no = this.n_sAc_no;
            _oCustomerAccount_Clone.order_id = this.n_iOrder_id;
            _oCustomerAccount_Clone.did = this.n_sDid;
            _oCustomerAccount_Clone.ddate = this.n_dDdate;
            _oCustomerAccount_Clone.remarks = this.n_sRemarks;
            _oCustomerAccount_Clone.SetFound(this.n_bFound);
            _oCustomerAccount_Clone.SetDB(this.n_oDB);
            _oCustomerAccount_Clone.SetRow(this.n_oRow);
            _oCustomerAccount_Clone.SetTbl(this.n_oTbl);
            _oCustomerAccount_Clone.SetTableSet(this.n_oTableSet);

            return _oCustomerAccount_Clone;
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
            n_sMrt_no = string.Empty;
            n_sActive = string.Empty;
            n_sAc_no = string.Empty;
            n_iOrder_id = null;
            n_sDid = string.Empty;
            n_dDdate = null;
            n_sRemarks = string.Empty;
            n_oDB = null;
            n_bFound = false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = new CustomerAccountInfo();
        }
        #endregion
    }
}

