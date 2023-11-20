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
///-- Description:	<Description,Table :[ProfileTeamDetail],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE
{

    /// <summary>
    /// Summary description for table [ProfileTeamDetail] Object Base layer
    /// </summary>

    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix + "ProfileTeamDetail")]
    public class ProfileTeamDetailEntity : global::System.IDisposable, global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>
    {


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


        protected string n_sTeamcode = string.Empty;
        #region teamcode
        [System.Data.Linq.Mapping.Column(Name = "[teamcode]", Storage = "n_sTeamcode")]
        public string teamcode
        {
            get
            {
                return this.n_sTeamcode;
            }
            set
            {
                this.n_sTeamcode = value;
            }
        }
        #endregion teamcode


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


        protected string n_sSalesmancode = string.Empty;
        #region salesmancode
        [System.Data.Linq.Mapping.Column(Name = "[salesmancode]", Storage = "n_sSalesmancode")]
        public string salesmancode
        {
            get
            {
                return this.n_sSalesmancode;
            }
            set
            {
                this.n_sSalesmancode = value;
            }
        }
        #endregion salesmancode


        protected string n_sStaff_no = string.Empty;
        #region staff_no
        [System.Data.Linq.Mapping.Column(Name = "[staff_no]", Storage = "n_sStaff_no")]
        public string staff_no
        {
            get
            {
                return this.n_sStaff_no;
            }
            set
            {
                this.n_sStaff_no = value;
            }
        }
        #endregion staff_no

        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound = false;
        private global::System.Data.DataTable n_oTbl = null;
        private global::System.Data.DataRow n_oRow = null;
        private ProfileTeamDetailInfo n_oTableSet = new ProfileTeamDetailInfo();
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        #endregion

        #region Parameter String
        public class Para
        {
            public const string mid = "mid";
            public const string teamcode = "teamcode";
            public const string active = "active";
            public const string salesmancode = "salesmancode";
            public const string staff_no = "staff_no";
            public const string ProfileTeamDetail_table_name = Configurator.MSSQLTablePrefix + "ProfileTeamDetail";
            public static string TableName() { return ProfileTeamDetail_table_name; }
        }
        #endregion Parameter String

        #region Constructor
        public ProfileTeamDetailEntity()
        {
            Init();
        }
        public ProfileTeamDetailEntity(MSSQLConnect x_oDB)
        {
            n_oDB = x_oDB;
            Init();
        }

        public ProfileTeamDetailEntity(MSSQLConnect x_oDB, System.Nullable<int> x_iMid)
        {
            n_oDB = x_oDB;
            this.Load(x_iMid);
            Init();
        }

        ~ProfileTeamDetailEntity()
        {
            this.Release();
        }
        #endregion

        #region Load

        public bool Load(global::System.Nullable<int> x_iMid)
        {
            if (n_oDB == null) { return false; }
            if (x_iMid == null) { return false; }
            string _sQuery = "SELECT [ProfileTeamDetail].[active] AS PROFILETEAMDETAIL_ACTIVE,[ProfileTeamDetail].[teamcode] AS PROFILETEAMDETAIL_TEAMCODE,[ProfileTeamDetail].[mid] AS PROFILETEAMDETAIL_MID,[ProfileTeamDetail].[salesmancode] AS PROFILETEAMDETAIL_SALESMANCODE,[ProfileTeamDetail].[staff_no] AS PROFILETEAMDETAIL_STAFF_NO  FROM  [ProfileTeamDetail]  WHERE  [ProfileTeamDetail].[mid] = \'" + x_iMid.ToString() + "\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProfileTeamDetail]", "[" + Configurator.MSSQLTablePrefix + "ProfileTeamDetail]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMDETAIL_ACTIVE"])) { n_bActive = (global::System.Nullable<bool>)_oData["PROFILETEAMDETAIL_ACTIVE"]; } else { n_bActive = null; }
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMDETAIL_TEAMCODE"])) { n_sTeamcode = (string)_oData["PROFILETEAMDETAIL_TEAMCODE"]; } else { n_sTeamcode = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMDETAIL_MID"])) { n_iMid = (global::System.Nullable<int>)_oData["PROFILETEAMDETAIL_MID"]; } else { n_iMid = null; }
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMDETAIL_SALESMANCODE"])) { n_sSalesmancode = (string)_oData["PROFILETEAMDETAIL_SALESMANCODE"]; } else { n_sSalesmancode = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMDETAIL_STAFF_NO"])) { n_sStaff_no = (string)_oData["PROFILETEAMDETAIL_STAFF_NO"]; } else { n_sStaff_no = string.Empty; }
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
            if (n_bActive == null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_sTeamcode == null && !(n_oTableSet.Fields(Para.teamcode).IsNullable)) return false;
            if (!x_bInsert)
            {
                if (n_iMid == null && !(n_oTableSet.Fields(Para.mid).IsNullable)) return false;
            }
            if (n_sSalesmancode == null && !(n_oTableSet.Fields(Para.salesmancode).IsNullable)) return false;
            if (n_sStaff_no == null && !(n_oTableSet.Fields(Para.staff_no).IsNullable)) return false;
            return true;
        }
        #endregion

        #region Get & Set

        /// <summary>
        /// Summary description for Get & Set this all class parameters
        /// </summary>


        public object GetRepositoryObject(object x_oObj)
        {
            if ((x_oObj is ProfileTeamDetail) || (x_oObj is ProfileTeamDetailEntity)) return ProfileTeamDetailRepository.Instance();
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
        public ProfileTeamDetailInfo GetTableSet() { return n_oTableSet; }
        #endregion GetTableSet


        #region SetTableSet
        public void SetTableSet(ProfileTeamDetailInfo value) { n_oTableSet = value; }
        #endregion SetTableSet

        public global::System.Nullable<int> GetMid() { return this.mid; }
        public string GetTeamcode() { return this.teamcode; }
        public global::System.Nullable<bool> GetActive() { return this.active; }
        public string GetSalesmancode() { return this.salesmancode; }
        public string GetStaff_no() { return this.staff_no; }

        public bool SetMid(global::System.Nullable<int> value)
        {
            this.mid = value;
            return true;
        }
        public bool SetTeamcode(string value)
        {
            this.teamcode = value;
            return true;
        }
        public bool SetActive(global::System.Nullable<bool> value)
        {
            this.active = value;
            return true;
        }
        public bool SetSalesmancode(string value)
        {
            this.salesmancode = value;
            return true;
        }
        public bool SetStaff_no(string value)
        {
            this.staff_no = value;
            return true;
        }

        public Field GetMidTable()
        {
            return n_oTableSet.Fields(Para.mid);
        }
        public Field GetTeamcodeTable()
        {
            return n_oTableSet.Fields(Para.teamcode);
        }
        public Field GetActiveTable()
        {
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetSalesmancodeTable()
        {
            return n_oTableSet.Fields(Para.salesmancode);
        }
        public Field GetStaff_noTable()
        {
            return n_oTableSet.Fields(Para.staff_no);
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

        public bool EqualID(ProfileTeamDetail x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iMid.Equals(x_oObj.mid)) && isEquals;
            return isEquals;
        }

        public bool Equals(ProfileTeamDetail x_oObj)
        {
            if (x_oObj == null) return false;
            if (!this.n_bActive.Equals(x_oObj.active)) { return false; }
            if (!this.n_sTeamcode.Equals(x_oObj.teamcode)) { return false; }
            if (!this.n_iMid.Equals(x_oObj.mid)) { return false; }
            if (!this.n_sSalesmancode.Equals(x_oObj.salesmancode)) { return false; }
            if (!this.n_sStaff_no.Equals(x_oObj.staff_no)) { return false; }
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
            string _sQuery = "UPDATE  [ProfileTeamDetail]  SET  [active]=@active,[teamcode]=@teamcode,[salesmancode]=@salesmancode,[staff_no]=@staff_no  WHERE [ProfileTeamDetail].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProfileTeamDetail]", "[" + Configurator.MSSQLTablePrefix + "ProfileTeamDetail]"); }
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
            if (n_bActive == null) { _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = n_bActive; }
            if (n_sTeamcode == null) { _oCmd.Parameters.Add("@teamcode", global::System.Data.SqlDbType.Char, 10).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@teamcode", global::System.Data.SqlDbType.Char, 10).Value = n_sTeamcode; }
            if (n_iMid == null) { _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value = n_iMid; }
            if (n_sSalesmancode == null) { _oCmd.Parameters.Add("@salesmancode", global::System.Data.SqlDbType.Char, 5).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@salesmancode", global::System.Data.SqlDbType.Char, 5).Value = n_sSalesmancode; }
            if (n_sStaff_no == null) { _oCmd.Parameters.Add("@staff_no", global::System.Data.SqlDbType.Char, 10).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@staff_no", global::System.Data.SqlDbType.Char, 10).Value = n_sStaff_no; }
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
        /// Summary description for table [ProfileTeamDetail] Delete Record
        /// </summary>

        public bool Delete()
        {
            if (n_iMid == null) { return false; }
            string _sQuery = "DELETE FROM  [ProfileTeamDetail]  WHERE [ProfileTeamDetail].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProfileTeamDetail]", "[" + Configurator.MSSQLTablePrefix + "ProfileTeamDetail]"); }
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
        /// Summary description for table [ProfileTeamDetail] Object Base Clone
        /// </summary>

        public ProfileTeamDetail DeepClone()
        {
            ProfileTeamDetail _oProfileTeamDetail_Clone = (ProfileTeamDetail)ProfileTeamDetailRepository.CreateEntityInstanceObject();
            _oProfileTeamDetail_Clone.active = this.n_bActive;
            _oProfileTeamDetail_Clone.teamcode = this.n_sTeamcode;
            _oProfileTeamDetail_Clone.mid = this.n_iMid;
            _oProfileTeamDetail_Clone.salesmancode = this.n_sSalesmancode;
            _oProfileTeamDetail_Clone.staff_no = this.n_sStaff_no;
            _oProfileTeamDetail_Clone.SetFound(this.n_bFound);
            _oProfileTeamDetail_Clone.SetDB(this.n_oDB);
            _oProfileTeamDetail_Clone.SetRow(this.n_oRow);
            _oProfileTeamDetail_Clone.SetTbl(this.n_oTbl);
            _oProfileTeamDetail_Clone.SetTableSet(this.n_oTableSet);

            return _oProfileTeamDetail_Clone;
        }
        #endregion

        #region Release

        /// <summary>
        /// Summary description for Release
        /// </summary>

        public void Release()
        {
            n_bActive = null;
            n_sTeamcode = string.Empty;
            n_iMid = null;
            n_sSalesmancode = string.Empty;
            n_sStaff_no = string.Empty;
            n_oDB = null;
            n_bFound = false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = new ProfileTeamDetailInfo();
        }
        #endregion
    }
}

