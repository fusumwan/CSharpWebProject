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
///-- Create date: <Create Date 2009-10-21>
///-- Description:	<Description,Table :[PublicHousingOffer],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE
{

    /// <summary>
    /// Summary description for table [PublicHousingOffer] Object Base layer
    /// </summary>

    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix + "PublicHousingOffer")]
    public class PublicHousingOfferEntity : global::System.IDisposable, global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>
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


        protected string n_sCid = global::System.String.Empty;
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


        protected string n_sDid = global::System.String.Empty;
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


        protected string n_sProgram = global::System.String.Empty;
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


        protected string n_sS_premium2 = global::System.String.Empty;
        #region s_premium2
        [System.Data.Linq.Mapping.Column(Name = "[s_premium2]", Storage = "n_sS_premium2")]
        public string s_premium2
        {
            get
            {
                return this.n_sS_premium2;
            }
            set
            {
                this.n_sS_premium2 = value;
            }
        }
        #endregion s_premium2

        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound = false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private PublicHousingOfferInfo n_oTableSet = PublicHousingOfferInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        #endregion

        #region Parameter String
        public class Para
        {
            public const string id = "id";
            public const string cdate = "cdate";
            public const string cid = "cid";
            public const string active = "active";
            public const string sdate = "sdate";
            public const string s_premium2 = "s_premium2";
            public const string edate = "edate";
            public const string program = "program";
            public const string ddate = "ddate";
            public const string did = "did";
            public const string PublicHousingOffer_table_name = "PublicHousingOffer";
            public static string TableName() { return PublicHousingOffer_table_name; }
        }
        #endregion Parameter String

        #region Constructor
        public PublicHousingOfferEntity()
        {
            Init();
        }
        public PublicHousingOfferEntity(MSSQLConnect x_oDB)
        {
            n_oDB = x_oDB;
            Init();
        }

        public PublicHousingOfferEntity(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            n_oDB = x_oDB;
            this.Load(x_iId);
            Init();
        }

        ~PublicHousingOfferEntity()
        {
            this.Release();
        }
        #endregion

        #region Load

        public bool Load(global::System.Nullable<int> x_iId)
        {
            if (n_oDB == null) { return false; }
            if (x_iId == null) { return false; }
            string _sQuery = "SELECT [PublicHousingOffer].[id] AS PUBLICHOUSINGOFFER_ID,[PublicHousingOffer].[cdate] AS PUBLICHOUSINGOFFER_CDATE,[PublicHousingOffer].[cid] AS PUBLICHOUSINGOFFER_CID,[PublicHousingOffer].[did] AS PUBLICHOUSINGOFFER_DID,[PublicHousingOffer].[sdate] AS PUBLICHOUSINGOFFER_SDATE,[PublicHousingOffer].[active] AS PUBLICHOUSINGOFFER_ACTIVE,[PublicHousingOffer].[edate] AS PUBLICHOUSINGOFFER_EDATE,[PublicHousingOffer].[program] AS PUBLICHOUSINGOFFER_PROGRAM,[PublicHousingOffer].[ddate] AS PUBLICHOUSINGOFFER_DDATE,[PublicHousingOffer].[s_premium2] AS PUBLICHOUSINGOFFER_S_PREMIUM2  FROM  [PublicHousingOffer]  WHERE  [PublicHousingOffer].[id] = \'" + x_iId.ToString() + "\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[PublicHousingOffer]", "[" + Configurator.MSSQLTablePrefix + "PublicHousingOffer]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_ID"])) { n_iId = (global::System.Nullable<int>)_oData["PUBLICHOUSINGOFFER_ID"]; } else { n_iId = null; }
                        if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_CDATE"])) { n_dCdate = (global::System.Nullable<DateTime>)_oData["PUBLICHOUSINGOFFER_CDATE"]; } else { n_dCdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_CID"])) { n_sCid = (string)_oData["PUBLICHOUSINGOFFER_CID"]; } else { n_sCid = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_DID"])) { n_sDid = (string)_oData["PUBLICHOUSINGOFFER_DID"]; } else { n_sDid = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_SDATE"])) { n_dSdate = (global::System.Nullable<DateTime>)_oData["PUBLICHOUSINGOFFER_SDATE"]; } else { n_dSdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_ACTIVE"])) { n_bActive = (global::System.Nullable<bool>)_oData["PUBLICHOUSINGOFFER_ACTIVE"]; } else { n_bActive = null; }
                        if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_EDATE"])) { n_dEdate = (global::System.Nullable<DateTime>)_oData["PUBLICHOUSINGOFFER_EDATE"]; } else { n_dEdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_PROGRAM"])) { n_sProgram = (string)_oData["PUBLICHOUSINGOFFER_PROGRAM"]; } else { n_sProgram = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_DDATE"])) { n_dDdate = (global::System.Nullable<DateTime>)_oData["PUBLICHOUSINGOFFER_DDATE"]; } else { n_dDdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_S_PREMIUM2"])) { n_sS_premium2 = (string)_oData["PUBLICHOUSINGOFFER_S_PREMIUM2"]; } else { n_sS_premium2 = global::System.String.Empty; }
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
            if (n_dSdate == null && !(n_oTableSet.Fields(Para.sdate).IsNullable)) return false;
            if (n_bActive == null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_dEdate == null && !(n_oTableSet.Fields(Para.edate).IsNullable)) return false;
            if (n_sProgram == null && !(n_oTableSet.Fields(Para.program).IsNullable)) return false;
            if (n_dDdate == null && !(n_oTableSet.Fields(Para.ddate).IsNullable)) return false;
            if (n_sS_premium2 == null && !(n_oTableSet.Fields(Para.s_premium2).IsNullable)) return false;
            return true;
        }
        #endregion

        #region Get & Set

        /// <summary>
        /// Summary description for Get & Set this all class parameters
        /// </summary>


        public object GetRepositoryObject(object x_oObj)
        {
            if ((x_oObj is PublicHousingOffer) || (x_oObj is PublicHousingOfferEntity)) return PublicHousingOfferRepository.Instance();
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
        public DataTable GetTbl() { return n_oTbl; }
        #endregion GetTbl


        #region SetTbl
        public void SetTbl(DataTable value) { n_oTbl = value; }
        #endregion SetTbl


        #region GetRow
        public DataRow GetRow() { return n_oRow; }
        #endregion GetRow


        #region SetRow
        public void SetRow(DataRow value) { n_oRow = value; }
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
        public PublicHousingOfferInfo GetTableSet() { return n_oTableSet; }
        #endregion GetTableSet


        #region SetTableSet
        public void SetTableSet(PublicHousingOfferInfo value) { n_oTableSet = value; }
        #endregion SetTableSet

        public global::System.Nullable<int> GetId() { return this.id; }
        public global::System.Nullable<DateTime> GetCdate() { return this.cdate; }
        public string GetCid() { return this.cid; }
        public global::System.Nullable<bool> GetActive() { return this.active; }
        public global::System.Nullable<DateTime> GetSdate() { return this.sdate; }
        public string GetS_premium2() { return this.s_premium2; }
        public global::System.Nullable<DateTime> GetEdate() { return this.edate; }
        public string GetProgram() { return this.program; }
        public global::System.Nullable<DateTime> GetDdate() { return this.ddate; }
        public string GetDid() { return this.did; }

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
        public bool SetSdate(global::System.Nullable<DateTime> value)
        {
            this.sdate = value;
            return true;
        }
        public bool SetS_premium2(string value)
        {
            this.s_premium2 = value;
            return true;
        }
        public bool SetEdate(global::System.Nullable<DateTime> value)
        {
            this.edate = value;
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
        public bool SetDid(string value)
        {
            this.did = value;
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
        public Field GetSdateTable()
        {
            return n_oTableSet.Fields(Para.sdate);
        }
        public Field GetS_premium2Table()
        {
            return n_oTableSet.Fields(Para.s_premium2);
        }
        public Field GetEdateTable()
        {
            return n_oTableSet.Fields(Para.edate);
        }
        public Field GetProgramTable()
        {
            return n_oTableSet.Fields(Para.program);
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

        public bool EqualID(PublicHousingOffer x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }

        public bool Equals(PublicHousingOffer x_oObj)
        {
            if (x_oObj == null) return false;
            if (!this.n_iId.Equals(x_oObj.id)) { return false; }
            if (!this.n_dCdate.Equals(x_oObj.cdate)) { return false; }
            if (!this.n_sCid.Equals(x_oObj.cid)) { return false; }
            if (!this.n_sDid.Equals(x_oObj.did)) { return false; }
            if (!this.n_dSdate.Equals(x_oObj.sdate)) { return false; }
            if (!this.n_bActive.Equals(x_oObj.active)) { return false; }
            if (!this.n_dEdate.Equals(x_oObj.edate)) { return false; }
            if (!this.n_sProgram.Equals(x_oObj.program)) { return false; }
            if (!this.n_dDdate.Equals(x_oObj.ddate)) { return false; }
            if (!this.n_sS_premium2.Equals(x_oObj.s_premium2)) { return false; }
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
            string _sQuery = "UPDATE  [PublicHousingOffer]  SET  [cdate]=@cdate,[cid]=@cid,[did]=@did,[sdate]=@sdate,[active]=@active,[edate]=@edate,[program]=@program,[ddate]=@ddate,[s_premium2]=@s_premium2  WHERE [PublicHousingOffer].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[PublicHousingOffer]", "[" + Configurator.MSSQLTablePrefix + "PublicHousingOffer]"); }
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
            if (n_iId == null) { _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; } else { _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = n_iId; }
            if (n_dCdate == null) { _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = n_dCdate; }
            if (n_sCid == null) { _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar, 50).Value = DBNull.Value; } else { _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar, 50).Value = n_sCid; }
            if (n_sDid == null) { _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar, 50).Value = DBNull.Value; } else { _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar, 50).Value = n_sDid; }
            if (n_dSdate == null) { _oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { _oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = n_dSdate; }
            if (n_bActive == null) { _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = n_bActive; }
            if (n_dEdate == null) { _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = n_dEdate; }
            if (n_sProgram == null) { _oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar, 250).Value = DBNull.Value; } else { _oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar, 250).Value = n_sProgram; }
            if (n_dDdate == null) { _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = n_dDdate; }
            if (n_sS_premium2 == null) { _oCmd.Parameters.Add("@s_premium2", global::System.Data.SqlDbType.NVarChar, 250).Value = DBNull.Value; } else { _oCmd.Parameters.Add("@s_premium2", global::System.Data.SqlDbType.NVarChar, 250).Value = n_sS_premium2; }
            try
            {
                if (!n_oDB.bTransaction && _oConn.State == ConnectionState.Closed) _oConn.Open();
                _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
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
        /// Summary description for table [PublicHousingOffer] Delete Record
        /// </summary>

        public bool Delete()
        {
            if (n_iId == null) { return false; }
            string _sQuery = "DELETE FROM  [PublicHousingOffer]  WHERE [PublicHousingOffer].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[PublicHousingOffer]", "[" + Configurator.MSSQLTablePrefix + "PublicHousingOffer]"); }
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
                _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
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
        /// Summary description for table [PublicHousingOffer] Object Base Clone
        /// </summary>

        public PublicHousingOffer DeepClone()
        {
            PublicHousingOffer _oPublicHousingOffer_Clone = new PublicHousingOffer();
            _oPublicHousingOffer_Clone.id = this.n_iId;
            _oPublicHousingOffer_Clone.cdate = this.n_dCdate;
            _oPublicHousingOffer_Clone.cid = this.n_sCid;
            _oPublicHousingOffer_Clone.did = this.n_sDid;
            _oPublicHousingOffer_Clone.sdate = this.n_dSdate;
            _oPublicHousingOffer_Clone.active = this.n_bActive;
            _oPublicHousingOffer_Clone.edate = this.n_dEdate;
            _oPublicHousingOffer_Clone.program = this.n_sProgram;
            _oPublicHousingOffer_Clone.ddate = this.n_dDdate;
            _oPublicHousingOffer_Clone.s_premium2 = this.n_sS_premium2;
            _oPublicHousingOffer_Clone.SetFound(this.n_bFound);
            _oPublicHousingOffer_Clone.SetDB(this.n_oDB);
            _oPublicHousingOffer_Clone.SetRow(this.n_oRow);
            _oPublicHousingOffer_Clone.SetTbl(this.n_oTbl);
            _oPublicHousingOffer_Clone.SetTableSet(this.n_oTableSet);

            return _oPublicHousingOffer_Clone;
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
            n_sCid = global::System.String.Empty;
            n_sDid = global::System.String.Empty;
            n_dSdate = null;
            n_bActive = null;
            n_dEdate = null;
            n_sProgram = global::System.String.Empty;
            n_dDdate = null;
            n_sS_premium2 = global::System.String.Empty;
            n_oDB = null;
            n_bFound = false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = PublicHousingOfferInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}

