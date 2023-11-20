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
///-- Description:	<Description,Table :[SpecialPremium],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE
{

    /// <summary>
    /// Summary description for table [SpecialPremium] Object Base layer
    /// </summary>

    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix + "SpecialPremium")]
    public class SpecialPremiumEntity : global::System.IDisposable, global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>
    {


        protected string n_sRate_plan = string.Empty;
        #region rate_plan
        [System.Data.Linq.Mapping.Column(Name = "[rate_plan]", Storage = "n_sRate_plan")]
        public string rate_plan
        {
            get
            {
                return this.n_sRate_plan;
            }
            set
            {
                this.n_sRate_plan = value;
            }
        }
        #endregion rate_plan


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


        protected string n_sCon_per = string.Empty;
        #region con_per
        [System.Data.Linq.Mapping.Column(Name = "[con_per]", Storage = "n_sCon_per")]
        public string con_per
        {
            get
            {
                return this.n_sCon_per;
            }
            set
            {
                this.n_sCon_per = value;
            }
        }
        #endregion con_per


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


        protected string n_sS_premium = string.Empty;
        #region s_premium
        [System.Data.Linq.Mapping.Column(Name = "[s_premium]", Storage = "n_sS_premium")]
        public string s_premium
        {
            get
            {
                return this.n_sS_premium;
            }
            set
            {
                this.n_sS_premium = value;
            }
        }
        #endregion s_premium

        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound = false;
        private global::System.Data.DataTable n_oTbl = null;
        private global::System.Data.DataRow n_oRow = null;
        private SpecialPremiumInfo n_oTableSet = new SpecialPremiumInfo();
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        #endregion

        #region Parameter String
        public class Para
        {
            public const string active = "active";
            public const string cdate = "cdate";
            public const string cid = "cid";
            public const string did = "did";
            public const string con_per = "con_per";
            public const string rate_plan = "rate_plan";
            public const string ddate = "ddate";
            public const string mid = "mid";
            public const string s_premium = "s_premium";
            public const string SpecialPremium_table_name = Configurator.MSSQLTablePrefix + "SpecialPremium";
            public static string TableName() { return SpecialPremium_table_name; }
        }
        #endregion Parameter String

        #region Constructor
        public SpecialPremiumEntity()
        {
            Init();
        }
        public SpecialPremiumEntity(MSSQLConnect x_oDB)
        {
            n_oDB = x_oDB;
            Init();
        }

        public SpecialPremiumEntity(MSSQLConnect x_oDB, System.Nullable<int> x_iMid)
        {
            n_oDB = x_oDB;
            this.Load(x_iMid);
            Init();
        }

        ~SpecialPremiumEntity()
        {
            this.Release();
        }
        #endregion

        #region Load

        public bool Load(global::System.Nullable<int> x_iMid)
        {
            if (n_oDB == null) { return false; }
            if (x_iMid == null) { return false; }
            string _sQuery = "SELECT [SpecialPremium].[rate_plan] AS SPECIALPREMIUM_RATE_PLAN,[SpecialPremium].[cdate] AS SPECIALPREMIUM_CDATE,[SpecialPremium].[cid] AS SPECIALPREMIUM_CID,[SpecialPremium].[active] AS SPECIALPREMIUM_ACTIVE,[SpecialPremium].[ddate] AS SPECIALPREMIUM_DDATE,[SpecialPremium].[did] AS SPECIALPREMIUM_DID,[SpecialPremium].[con_per] AS SPECIALPREMIUM_CON_PER,[SpecialPremium].[mid] AS SPECIALPREMIUM_MID,[SpecialPremium].[s_premium] AS SPECIALPREMIUM_S_PREMIUM  FROM  [SpecialPremium]  WHERE  [SpecialPremium].[mid] = \'" + x_iMid.ToString() + "\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[SpecialPremium]", "[" + Configurator.MSSQLTablePrefix + "SpecialPremium]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_RATE_PLAN"])) { n_sRate_plan = (string)_oData["SPECIALPREMIUM_RATE_PLAN"]; } else { n_sRate_plan = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_CDATE"])) { n_dCdate = (global::System.Nullable<DateTime>)_oData["SPECIALPREMIUM_CDATE"]; } else { n_dCdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_CID"])) { n_sCid = (string)_oData["SPECIALPREMIUM_CID"]; } else { n_sCid = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_ACTIVE"])) { n_bActive = (global::System.Nullable<bool>)_oData["SPECIALPREMIUM_ACTIVE"]; } else { n_bActive = null; }
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_DDATE"])) { n_dDdate = (global::System.Nullable<DateTime>)_oData["SPECIALPREMIUM_DDATE"]; } else { n_dDdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_DID"])) { n_sDid = (string)_oData["SPECIALPREMIUM_DID"]; } else { n_sDid = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_CON_PER"])) { n_sCon_per = (string)_oData["SPECIALPREMIUM_CON_PER"]; } else { n_sCon_per = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_MID"])) { n_iMid = (global::System.Nullable<int>)_oData["SPECIALPREMIUM_MID"]; } else { n_iMid = null; }
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_S_PREMIUM"])) { n_sS_premium = (string)_oData["SPECIALPREMIUM_S_PREMIUM"]; } else { n_sS_premium = string.Empty; }
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
            if (n_sRate_plan == null && !(n_oTableSet.Fields(Para.rate_plan).IsNullable)) return false;
            if (n_dCdate == null && !(n_oTableSet.Fields(Para.cdate).IsNullable)) return false;
            if (n_sCid == null && !(n_oTableSet.Fields(Para.cid).IsNullable)) return false;
            if (n_bActive == null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_dDdate == null && !(n_oTableSet.Fields(Para.ddate).IsNullable)) return false;
            if (n_sDid == null && !(n_oTableSet.Fields(Para.did).IsNullable)) return false;
            if (n_sCon_per == null && !(n_oTableSet.Fields(Para.con_per).IsNullable)) return false;
            if (!x_bInsert)
            {
                if (n_iMid == null && !(n_oTableSet.Fields(Para.mid).IsNullable)) return false;
            }
            if (n_sS_premium == null && !(n_oTableSet.Fields(Para.s_premium).IsNullable)) return false;
            return true;
        }
        #endregion

        #region Get & Set

        /// <summary>
        /// Summary description for Get & Set this all class parameters
        /// </summary>


        public object GetRepositoryObject(object x_oObj)
        {
            if ((x_oObj is SpecialPremium) || (x_oObj is SpecialPremiumEntity)) return SpecialPremiumRepository.Instance();
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
        public SpecialPremiumInfo GetTableSet() { return n_oTableSet; }
        #endregion GetTableSet


        #region SetTableSet
        public void SetTableSet(SpecialPremiumInfo value) { n_oTableSet = value; }
        #endregion SetTableSet

        public global::System.Nullable<bool> GetActive() { return this.active; }
        public global::System.Nullable<DateTime> GetCdate() { return this.cdate; }
        public string GetCid() { return this.cid; }
        public string GetDid() { return this.did; }
        public string GetCon_per() { return this.con_per; }
        public string GetRate_plan() { return this.rate_plan; }
        public global::System.Nullable<DateTime> GetDdate() { return this.ddate; }
        public global::System.Nullable<int> GetMid() { return this.mid; }
        public string GetS_premium() { return this.s_premium; }

        public bool SetActive(global::System.Nullable<bool> value)
        {
            this.active = value;
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
        public bool SetCon_per(string value)
        {
            this.con_per = value;
            return true;
        }
        public bool SetRate_plan(string value)
        {
            this.rate_plan = value;
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
        public bool SetS_premium(string value)
        {
            this.s_premium = value;
            return true;
        }

        public Field GetActiveTable()
        {
            return n_oTableSet.Fields(Para.active);
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
        public Field GetCon_perTable()
        {
            return n_oTableSet.Fields(Para.con_per);
        }
        public Field GetRate_planTable()
        {
            return n_oTableSet.Fields(Para.rate_plan);
        }
        public Field GetDdateTable()
        {
            return n_oTableSet.Fields(Para.ddate);
        }
        public Field GetMidTable()
        {
            return n_oTableSet.Fields(Para.mid);
        }
        public Field GetS_premiumTable()
        {
            return n_oTableSet.Fields(Para.s_premium);
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

        public bool EqualID(SpecialPremium x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iMid.Equals(x_oObj.mid)) && isEquals;
            return isEquals;
        }

        public bool Equals(SpecialPremium x_oObj)
        {
            if (x_oObj == null) return false;
            if (!this.n_sRate_plan.Equals(x_oObj.rate_plan)) { return false; }
            if (!this.n_dCdate.Equals(x_oObj.cdate)) { return false; }
            if (!this.n_sCid.Equals(x_oObj.cid)) { return false; }
            if (!this.n_bActive.Equals(x_oObj.active)) { return false; }
            if (!this.n_dDdate.Equals(x_oObj.ddate)) { return false; }
            if (!this.n_sDid.Equals(x_oObj.did)) { return false; }
            if (!this.n_sCon_per.Equals(x_oObj.con_per)) { return false; }
            if (!this.n_iMid.Equals(x_oObj.mid)) { return false; }
            if (!this.n_sS_premium.Equals(x_oObj.s_premium)) { return false; }
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
            string _sQuery = "UPDATE  [SpecialPremium]  SET  [rate_plan]=@rate_plan,[cdate]=@cdate,[cid]=@cid,[active]=@active,[ddate]=@ddate,[did]=@did,[con_per]=@con_per,[s_premium]=@s_premium  WHERE [SpecialPremium].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[SpecialPremium]", "[" + Configurator.MSSQLTablePrefix + "SpecialPremium]"); }
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
            if (n_sRate_plan == null) { _oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar, 50).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar, 50).Value = n_sRate_plan; }
            if (n_dCdate == null) { _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = n_dCdate; }
            if (n_sCid == null) { _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10).Value = n_sCid; }
            if (n_bActive == null) { _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = n_bActive; }
            if (n_dDdate == null) { _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = n_dDdate; }
            if (n_sDid == null) { _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10).Value = n_sDid; }
            if (n_sCon_per == null) { _oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar, 10).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar, 10).Value = n_sCon_per; }
            if (n_iMid == null) { _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value = n_iMid; }
            if (n_sS_premium == null) { _oCmd.Parameters.Add("@s_premium", global::System.Data.SqlDbType.NVarChar, 50).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@s_premium", global::System.Data.SqlDbType.NVarChar, 50).Value = n_sS_premium; }
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
        /// Summary description for table [SpecialPremium] Delete Record
        /// </summary>

        public bool Delete()
        {
            if (n_iMid == null) { return false; }
            string _sQuery = "DELETE FROM  [SpecialPremium]  WHERE [SpecialPremium].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[SpecialPremium]", "[" + Configurator.MSSQLTablePrefix + "SpecialPremium]"); }
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
        /// Summary description for table [SpecialPremium] Object Base Clone
        /// </summary>

        public SpecialPremium DeepClone()
        {
            SpecialPremium _oSpecialPremium_Clone = (SpecialPremium)SpecialPremiumRepository.CreateEntityInstanceObject();
            _oSpecialPremium_Clone.rate_plan = this.n_sRate_plan;
            _oSpecialPremium_Clone.cdate = this.n_dCdate;
            _oSpecialPremium_Clone.cid = this.n_sCid;
            _oSpecialPremium_Clone.active = this.n_bActive;
            _oSpecialPremium_Clone.ddate = this.n_dDdate;
            _oSpecialPremium_Clone.did = this.n_sDid;
            _oSpecialPremium_Clone.con_per = this.n_sCon_per;
            _oSpecialPremium_Clone.mid = this.n_iMid;
            _oSpecialPremium_Clone.s_premium = this.n_sS_premium;
            _oSpecialPremium_Clone.SetFound(this.n_bFound);
            _oSpecialPremium_Clone.SetDB(this.n_oDB);
            _oSpecialPremium_Clone.SetRow(this.n_oRow);
            _oSpecialPremium_Clone.SetTbl(this.n_oTbl);
            _oSpecialPremium_Clone.SetTableSet(this.n_oTableSet);

            return _oSpecialPremium_Clone;
        }
        #endregion

        #region Release

        /// <summary>
        /// Summary description for Release
        /// </summary>

        public void Release()
        {
            n_sRate_plan = string.Empty;
            n_dCdate = null;
            n_sCid = string.Empty;
            n_bActive = null;
            n_dDdate = null;
            n_sDid = string.Empty;
            n_sCon_per = string.Empty;
            n_iMid = null;
            n_sS_premium = string.Empty;
            n_oDB = null;
            n_bFound = false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = new SpecialPremiumInfo();
        }
        #endregion
    }
}

