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
///-- Description:	<Description,Table :[RetentionPlan],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE
{

    /// <summary>
    /// Summary description for table [RetentionPlan] Object Base layer
    /// </summary>

    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix + "RetentionPlan")]
    public class RetentionPlanEntity : global::System.IDisposable, global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>
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


        protected string n_sPlan_code = string.Empty;
        #region plan_code
        [System.Data.Linq.Mapping.Column(Name = "[plan_code]", Storage = "n_sPlan_code")]
        public string plan_code
        {
            get
            {
                return this.n_sPlan_code;
            }
            set
            {
                this.n_sPlan_code = value;
            }
        }
        #endregion plan_code


        protected global::System.Nullable<double> n_dPlan_fee = null;
        #region plan_fee
        [System.Data.Linq.Mapping.Column(Name = "[plan_fee]", Storage = "n_dPlan_fee")]
        public global::System.Nullable<double> plan_fee
        {
            get
            {
                return this.n_dPlan_fee;
            }
            set
            {
                this.n_dPlan_fee = value;
            }
        }
        #endregion plan_fee


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

        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound = false;
        private global::System.Data.DataTable n_oTbl = null;
        private global::System.Data.DataRow n_oRow = null;
        private RetentionPlanInfo n_oTableSet = new RetentionPlanInfo();
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        #endregion

        #region Parameter String
        public class Para
        {
            public const string id = "id";
            public const string cdate = "cdate";
            public const string cid = "cid";
            public const string did = "did";
            public const string active = "active";
            public const string plan_code = "plan_code";
            public const string plan_fee = "plan_fee";
            public const string ddate = "ddate";
            public const string RetentionPlan_table_name = Configurator.MSSQLTablePrefix + "RetentionPlan";
            public static string TableName() { return RetentionPlan_table_name; }
        }
        #endregion Parameter String

        #region Constructor
        public RetentionPlanEntity()
        {
            Init();
        }
        public RetentionPlanEntity(MSSQLConnect x_oDB)
        {
            n_oDB = x_oDB;
            Init();
        }

        public RetentionPlanEntity(MSSQLConnect x_oDB, System.Nullable<int> x_iId)
        {
            n_oDB = x_oDB;
            this.Load(x_iId);
            Init();
        }

        ~RetentionPlanEntity()
        {
            this.Release();
        }
        #endregion

        #region Load

        public bool Load(global::System.Nullable<int> x_iId)
        {
            if (n_oDB == null) { return false; }
            if (x_iId == null) { return false; }
            string _sQuery = "SELECT [RetentionPlan].[id] AS RETENTIONPLAN_ID,[RetentionPlan].[cdate] AS RETENTIONPLAN_CDATE,[RetentionPlan].[cid] AS RETENTIONPLAN_CID,[RetentionPlan].[did] AS RETENTIONPLAN_DID,[RetentionPlan].[active] AS RETENTIONPLAN_ACTIVE,[RetentionPlan].[plan_code] AS RETENTIONPLAN_PLAN_CODE,[RetentionPlan].[plan_fee] AS RETENTIONPLAN_PLAN_FEE,[RetentionPlan].[ddate] AS RETENTIONPLAN_DDATE  FROM  [RetentionPlan]  WHERE  [RetentionPlan].[id] = \'" + x_iId.ToString() + "\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RetentionPlan]", "[" + Configurator.MSSQLTablePrefix + "RetentionPlan]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLAN_ID"])) { n_iId = (global::System.Nullable<int>)_oData["RETENTIONPLAN_ID"]; } else { n_iId = null; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLAN_CDATE"])) { n_dCdate = (global::System.Nullable<DateTime>)_oData["RETENTIONPLAN_CDATE"]; } else { n_dCdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLAN_CID"])) { n_sCid = (string)_oData["RETENTIONPLAN_CID"]; } else { n_sCid = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLAN_DID"])) { n_sDid = (string)_oData["RETENTIONPLAN_DID"]; } else { n_sDid = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLAN_ACTIVE"])) { n_bActive = (global::System.Nullable<bool>)_oData["RETENTIONPLAN_ACTIVE"]; } else { n_bActive = null; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLAN_PLAN_CODE"])) { n_sPlan_code = (string)_oData["RETENTIONPLAN_PLAN_CODE"]; } else { n_sPlan_code = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLAN_PLAN_FEE"])) { n_dPlan_fee = (global::System.Nullable<double>)_oData["RETENTIONPLAN_PLAN_FEE"]; } else { n_dPlan_fee = null; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLAN_DDATE"])) { n_dDdate = (global::System.Nullable<DateTime>)_oData["RETENTIONPLAN_DDATE"]; } else { n_dDdate = null; }
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
            if (n_sDid == null && !(n_oTableSet.Fields(Para.did).IsNullable)) return false;
            if (n_bActive == null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_sPlan_code == null && !(n_oTableSet.Fields(Para.plan_code).IsNullable)) return false;
            if (n_dPlan_fee == null && !(n_oTableSet.Fields(Para.plan_fee).IsNullable)) return false;
            if (n_dDdate == null && !(n_oTableSet.Fields(Para.ddate).IsNullable)) return false;
            return true;
        }
        #endregion

        #region Get & Set

        /// <summary>
        /// Summary description for Get & Set this all class parameters
        /// </summary>


        public object GetRepositoryObject(object x_oObj)
        {
            if ((x_oObj is RetentionPlan) || (x_oObj is RetentionPlanEntity)) return RetentionPlanRepository.Instance();
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
        public RetentionPlanInfo GetTableSet() { return n_oTableSet; }
        #endregion GetTableSet


        #region SetTableSet
        public void SetTableSet(RetentionPlanInfo value) { n_oTableSet = value; }
        #endregion SetTableSet

        public global::System.Nullable<int> GetId() { return this.id; }
        public global::System.Nullable<DateTime> GetCdate() { return this.cdate; }
        public string GetCid() { return this.cid; }
        public string GetDid() { return this.did; }
        public global::System.Nullable<bool> GetActive() { return this.active; }
        public string GetPlan_code() { return this.plan_code; }
        public global::System.Nullable<double> GetPlan_fee() { return this.plan_fee; }
        public global::System.Nullable<DateTime> GetDdate() { return this.ddate; }

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
        public bool SetDid(string value)
        {
            this.did = value;
            return true;
        }
        public bool SetActive(global::System.Nullable<bool> value)
        {
            this.active = value;
            return true;
        }
        public bool SetPlan_code(string value)
        {
            this.plan_code = value;
            return true;
        }
        public bool SetPlan_fee(global::System.Nullable<double> value)
        {
            this.plan_fee = value;
            return true;
        }
        public bool SetDdate(global::System.Nullable<DateTime> value)
        {
            this.ddate = value;
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
        public Field GetDidTable()
        {
            return n_oTableSet.Fields(Para.did);
        }
        public Field GetActiveTable()
        {
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetPlan_codeTable()
        {
            return n_oTableSet.Fields(Para.plan_code);
        }
        public Field GetPlan_feeTable()
        {
            return n_oTableSet.Fields(Para.plan_fee);
        }
        public Field GetDdateTable()
        {
            return n_oTableSet.Fields(Para.ddate);
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

        public bool EqualID(RetentionPlan x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }

        public bool Equals(RetentionPlan x_oObj)
        {
            if (x_oObj == null) return false;
            if (!this.n_iId.Equals(x_oObj.id)) { return false; }
            if (!this.n_dCdate.Equals(x_oObj.cdate)) { return false; }
            if (!this.n_sCid.Equals(x_oObj.cid)) { return false; }
            if (!this.n_sDid.Equals(x_oObj.did)) { return false; }
            if (!this.n_bActive.Equals(x_oObj.active)) { return false; }
            if (!this.n_sPlan_code.Equals(x_oObj.plan_code)) { return false; }
            if (!this.n_dPlan_fee.Equals(x_oObj.plan_fee)) { return false; }
            if (!this.n_dDdate.Equals(x_oObj.ddate)) { return false; }
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
            string _sQuery = "UPDATE  [RetentionPlan]  SET  [cdate]=@cdate,[cid]=@cid,[did]=@did,[active]=@active,[plan_code]=@plan_code,[plan_fee]=@plan_fee,[ddate]=@ddate  WHERE [RetentionPlan].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RetentionPlan]", "[" + Configurator.MSSQLTablePrefix + "RetentionPlan]"); }
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
            if (n_sDid == null) { _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10).Value = n_sDid; }
            if (n_bActive == null) { _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = n_bActive; }
            if (n_sPlan_code == null) { _oCmd.Parameters.Add("@plan_code", global::System.Data.SqlDbType.NVarChar, 50).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@plan_code", global::System.Data.SqlDbType.NVarChar, 50).Value = n_sPlan_code; }
            if (n_dPlan_fee == null) { _oCmd.Parameters.Add("@plan_fee", global::System.Data.SqlDbType.Float).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@plan_fee", global::System.Data.SqlDbType.Float).Value = n_dPlan_fee; }
            if (n_dDdate == null) { _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = n_dDdate; }
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
        /// Summary description for table [RetentionPlan] Delete Record
        /// </summary>

        public bool Delete()
        {
            if (n_iId == null) { return false; }
            string _sQuery = "DELETE FROM  [RetentionPlan]  WHERE [RetentionPlan].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RetentionPlan]", "[" + Configurator.MSSQLTablePrefix + "RetentionPlan]"); }
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
        /// Summary description for table [RetentionPlan] Object Base Clone
        /// </summary>

        public RetentionPlan DeepClone()
        {
            RetentionPlan _oRetentionPlan_Clone = (RetentionPlan)RetentionPlanRepository.CreateEntityInstanceObject();
            _oRetentionPlan_Clone.id = this.n_iId;
            _oRetentionPlan_Clone.cdate = this.n_dCdate;
            _oRetentionPlan_Clone.cid = this.n_sCid;
            _oRetentionPlan_Clone.did = this.n_sDid;
            _oRetentionPlan_Clone.active = this.n_bActive;
            _oRetentionPlan_Clone.plan_code = this.n_sPlan_code;
            _oRetentionPlan_Clone.plan_fee = this.n_dPlan_fee;
            _oRetentionPlan_Clone.ddate = this.n_dDdate;
            _oRetentionPlan_Clone.SetFound(this.n_bFound);
            _oRetentionPlan_Clone.SetDB(this.n_oDB);
            _oRetentionPlan_Clone.SetRow(this.n_oRow);
            _oRetentionPlan_Clone.SetTbl(this.n_oTbl);
            _oRetentionPlan_Clone.SetTableSet(this.n_oTableSet);

            return _oRetentionPlan_Clone;
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
            n_sDid = string.Empty;
            n_bActive = null;
            n_sPlan_code = string.Empty;
            n_dPlan_fee = null;
            n_dDdate = null;
            n_oDB = null;
            n_bFound = false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = new RetentionPlanInfo();
        }
        #endregion
    }
}

