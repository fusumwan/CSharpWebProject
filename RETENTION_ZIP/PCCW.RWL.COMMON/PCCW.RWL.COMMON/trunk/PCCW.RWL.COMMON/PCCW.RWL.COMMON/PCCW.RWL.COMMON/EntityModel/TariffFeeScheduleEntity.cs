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
///-- Description:	<Description,Table :[TariffFeeSchedule],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE
{

    /// <summary>
    /// Summary description for table [TariffFeeSchedule] Object Base layer
    /// </summary>

    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix + "TariffFeeSchedule")]
    public class TariffFeeScheduleEntity : global::System.IDisposable, global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>
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


        protected string n_sProgram = string.Empty;
        #region program
        [System.Data.Linq.Mapping.Column(Name = "[program]", Storage = "n_sProgram")]
        public string program
        {
            get
            {
                return this.n_sProgram;
            }
            set
            {
                this.n_sProgram = value;
            }
        }
        #endregion program


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


        protected string n_sFee = string.Empty;
        #region fee
        [System.Data.Linq.Mapping.Column(Name = "[fee]", Storage = "n_sFee")]
        public string fee
        {
            get
            {
                return this.n_sFee;
            }
            set
            {
                this.n_sFee = value;
            }
        }
        #endregion fee


        protected global::System.Nullable<int> n_iOrg_fee = null;
        #region org_fee
        [System.Data.Linq.Mapping.Column(Name = "[org_fee]", Storage = "n_iOrg_fee")]
        public global::System.Nullable<int> org_fee
        {
            get
            {
                return this.n_iOrg_fee;
            }
            set
            {
                this.n_iOrg_fee = value;
            }
        }
        #endregion org_fee


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
        private TariffFeeScheduleInfo n_oTableSet = new TariffFeeScheduleInfo();
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        #endregion

        #region Parameter String
        public class Para
        {
            public const string id = "id";
            public const string cdate = "cdate";
            public const string cid = "cid";
            public const string active = "active";
            public const string program = "program";
            public const string ddate = "ddate";
            public const string org_fee = "org_fee";
            public const string did = "did";
            public const string fee = "fee";
            public const string TariffFeeSchedule_table_name = Configurator.MSSQLTablePrefix + "TariffFeeSchedule";
            public static string TableName() { return TariffFeeSchedule_table_name; }
        }
        #endregion Parameter String

        #region Constructor
        public TariffFeeScheduleEntity()
        {
            Init();
        }
        public TariffFeeScheduleEntity(MSSQLConnect x_oDB)
        {
            n_oDB = x_oDB;
            Init();
        }

        public TariffFeeScheduleEntity(MSSQLConnect x_oDB, System.Nullable<int> x_iId)
        {
            n_oDB = x_oDB;
            this.Load(x_iId);
            Init();
        }

        ~TariffFeeScheduleEntity()
        {
            this.Release();
        }
        #endregion

        #region Load

        public bool Load(global::System.Nullable<int> x_iId)
        {
            if (n_oDB == null) { return false; }
            if (x_iId == null) { return false; }
            string _sQuery = "SELECT [TariffFeeSchedule].[id] AS TARIFFFEESCHEDULE_ID,[TariffFeeSchedule].[cdate] AS TARIFFFEESCHEDULE_CDATE,[TariffFeeSchedule].[cid] AS TARIFFFEESCHEDULE_CID,[TariffFeeSchedule].[active] AS TARIFFFEESCHEDULE_ACTIVE,[TariffFeeSchedule].[program] AS TARIFFFEESCHEDULE_PROGRAM,[TariffFeeSchedule].[ddate] AS TARIFFFEESCHEDULE_DDATE,[TariffFeeSchedule].[fee] AS TARIFFFEESCHEDULE_FEE,[TariffFeeSchedule].[org_fee] AS TARIFFFEESCHEDULE_ORG_FEE,[TariffFeeSchedule].[did] AS TARIFFFEESCHEDULE_DID  FROM  [TariffFeeSchedule]  WHERE  [TariffFeeSchedule].[id] = \'" + x_iId.ToString() + "\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[TariffFeeSchedule]", "[" + Configurator.MSSQLTablePrefix + "TariffFeeSchedule]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_ID"])) { n_iId = (global::System.Nullable<int>)_oData["TARIFFFEESCHEDULE_ID"]; } else { n_iId = null; }
                        if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_CDATE"])) { n_dCdate = (global::System.Nullable<DateTime>)_oData["TARIFFFEESCHEDULE_CDATE"]; } else { n_dCdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_CID"])) { n_sCid = (string)_oData["TARIFFFEESCHEDULE_CID"]; } else { n_sCid = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_ACTIVE"])) { n_bActive = (global::System.Nullable<bool>)_oData["TARIFFFEESCHEDULE_ACTIVE"]; } else { n_bActive = null; }
                        if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_PROGRAM"])) { n_sProgram = (string)_oData["TARIFFFEESCHEDULE_PROGRAM"]; } else { n_sProgram = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_DDATE"])) { n_dDdate = (global::System.Nullable<DateTime>)_oData["TARIFFFEESCHEDULE_DDATE"]; } else { n_dDdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_FEE"])) { n_sFee = (string)_oData["TARIFFFEESCHEDULE_FEE"]; } else { n_sFee = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_ORG_FEE"])) { n_iOrg_fee = (global::System.Nullable<int>)_oData["TARIFFFEESCHEDULE_ORG_FEE"]; } else { n_iOrg_fee = null; }
                        if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_DID"])) { n_sDid = (string)_oData["TARIFFFEESCHEDULE_DID"]; } else { n_sDid = string.Empty; }
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
            if (n_bActive == null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_sProgram == null && !(n_oTableSet.Fields(Para.program).IsNullable)) return false;
            if (n_dDdate == null && !(n_oTableSet.Fields(Para.ddate).IsNullable)) return false;
            if (n_sFee == null && !(n_oTableSet.Fields(Para.fee).IsNullable)) return false;
            if (n_iOrg_fee == null && !(n_oTableSet.Fields(Para.org_fee).IsNullable)) return false;
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
            if ((x_oObj is TariffFeeSchedule) || (x_oObj is TariffFeeScheduleEntity)) return TariffFeeScheduleRepository.Instance();
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
        public TariffFeeScheduleInfo GetTableSet() { return n_oTableSet; }
        #endregion GetTableSet


        #region SetTableSet
        public void SetTableSet(TariffFeeScheduleInfo value) { n_oTableSet = value; }
        #endregion SetTableSet

        public global::System.Nullable<int> GetId() { return this.id; }
        public global::System.Nullable<DateTime> GetCdate() { return this.cdate; }
        public string GetCid() { return this.cid; }
        public global::System.Nullable<bool> GetActive() { return this.active; }
        public string GetProgram() { return this.program; }
        public global::System.Nullable<DateTime> GetDdate() { return this.ddate; }
        public global::System.Nullable<int> GetOrg_fee() { return this.org_fee; }
        public string GetDid() { return this.did; }
        public string GetFee() { return this.fee; }

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
        public bool SetProgram(string value)
        {
            this.program = value;
            return true;
        }
        public bool SetDdate(global::System.Nullable<DateTime> value)
        {
            this.ddate = value;
            return true;
        }
        public bool SetOrg_fee(global::System.Nullable<int> value)
        {
            this.org_fee = value;
            return true;
        }
        public bool SetDid(string value)
        {
            this.did = value;
            return true;
        }
        public bool SetFee(string value)
        {
            this.fee = value;
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
        public Field GetProgramTable()
        {
            return n_oTableSet.Fields(Para.program);
        }
        public Field GetDdateTable()
        {
            return n_oTableSet.Fields(Para.ddate);
        }
        public Field GetOrg_feeTable()
        {
            return n_oTableSet.Fields(Para.org_fee);
        }
        public Field GetDidTable()
        {
            return n_oTableSet.Fields(Para.did);
        }
        public Field GetFeeTable()
        {
            return n_oTableSet.Fields(Para.fee);
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

        public bool EqualID(TariffFeeSchedule x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }

        public bool Equals(TariffFeeSchedule x_oObj)
        {
            if (x_oObj == null) return false;
            if (!this.n_iId.Equals(x_oObj.id)) { return false; }
            if (!this.n_dCdate.Equals(x_oObj.cdate)) { return false; }
            if (!this.n_sCid.Equals(x_oObj.cid)) { return false; }
            if (!this.n_bActive.Equals(x_oObj.active)) { return false; }
            if (!this.n_sProgram.Equals(x_oObj.program)) { return false; }
            if (!this.n_dDdate.Equals(x_oObj.ddate)) { return false; }
            if (!this.n_sFee.Equals(x_oObj.fee)) { return false; }
            if (!this.n_iOrg_fee.Equals(x_oObj.org_fee)) { return false; }
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
            string _sQuery = "UPDATE  [TariffFeeSchedule]  SET  [cdate]=@cdate,[cid]=@cid,[active]=@active,[program]=@program,[ddate]=@ddate,[fee]=@fee,[org_fee]=@org_fee,[did]=@did  WHERE [TariffFeeSchedule].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[TariffFeeSchedule]", "[" + Configurator.MSSQLTablePrefix + "TariffFeeSchedule]"); }
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
            if (n_bActive == null) { _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = n_bActive; }
            if (n_sProgram == null) { _oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar, 50).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar, 50).Value = n_sProgram; }
            if (n_dDdate == null) { _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = n_dDdate; }
            if (n_sFee == null) { _oCmd.Parameters.Add("@fee", global::System.Data.SqlDbType.NVarChar, 50).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@fee", global::System.Data.SqlDbType.NVarChar, 50).Value = n_sFee; }
            if (n_iOrg_fee == null) { _oCmd.Parameters.Add("@org_fee", global::System.Data.SqlDbType.Int).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@org_fee", global::System.Data.SqlDbType.Int).Value = n_iOrg_fee; }
            if (n_sDid == null) { _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10).Value = n_sDid; }
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
        /// Summary description for table [TariffFeeSchedule] Delete Record
        /// </summary>

        public bool Delete()
        {
            if (n_iId == null) { return false; }
            string _sQuery = "DELETE FROM  [TariffFeeSchedule]  WHERE [TariffFeeSchedule].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[TariffFeeSchedule]", "[" + Configurator.MSSQLTablePrefix + "TariffFeeSchedule]"); }
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
        /// Summary description for table [TariffFeeSchedule] Object Base Clone
        /// </summary>

        public TariffFeeSchedule DeepClone()
        {
            TariffFeeSchedule _oTariffFeeSchedule_Clone = (TariffFeeSchedule)TariffFeeScheduleRepository.CreateEntityInstanceObject();
            _oTariffFeeSchedule_Clone.id = this.n_iId;
            _oTariffFeeSchedule_Clone.cdate = this.n_dCdate;
            _oTariffFeeSchedule_Clone.cid = this.n_sCid;
            _oTariffFeeSchedule_Clone.active = this.n_bActive;
            _oTariffFeeSchedule_Clone.program = this.n_sProgram;
            _oTariffFeeSchedule_Clone.ddate = this.n_dDdate;
            _oTariffFeeSchedule_Clone.fee = this.n_sFee;
            _oTariffFeeSchedule_Clone.org_fee = this.n_iOrg_fee;
            _oTariffFeeSchedule_Clone.did = this.n_sDid;
            _oTariffFeeSchedule_Clone.SetFound(this.n_bFound);
            _oTariffFeeSchedule_Clone.SetDB(this.n_oDB);
            _oTariffFeeSchedule_Clone.SetRow(this.n_oRow);
            _oTariffFeeSchedule_Clone.SetTbl(this.n_oTbl);
            _oTariffFeeSchedule_Clone.SetTableSet(this.n_oTableSet);

            return _oTariffFeeSchedule_Clone;
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
            n_bActive = null;
            n_sProgram = string.Empty;
            n_dDdate = null;
            n_sFee = string.Empty;
            n_iOrg_fee = null;
            n_sDid = string.Empty;
            n_oDB = null;
            n_bFound = false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = new TariffFeeScheduleInfo();
        }
        #endregion
    }
}

