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
///-- Description:	<Description,Table :[MobileOrderMonthlyFee],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE
{

    /// <summary>
    /// Summary description for table [MobileOrderMonthlyFee] Object Base layer
    /// </summary>

    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix + "MobileOrderMonthlyFee")]
    public class MobileOrderMonthlyFeeEntity : global::System.IDisposable, global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>
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


        protected global::System.Nullable<int> n_iMon = null;
        #region mon
        [System.Data.Linq.Mapping.Column(Name = "[mon]", Storage = "n_iMon")]
        public global::System.Nullable<int> mon
        {
            get
            {
                return this.n_iMon;
            }
            set
            {
                this.n_iMon = value;
            }
        }
        #endregion mon


        protected global::System.Nullable<int> n_iFee = null;
        #region fee
        [System.Data.Linq.Mapping.Column(Name = "[fee]", Storage = "n_iFee")]
        public global::System.Nullable<int> fee
        {
            get
            {
                return this.n_iFee;
            }
            set
            {
                this.n_iFee = value;
            }
        }
        #endregion fee


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


        protected string n_sFree_mon = string.Empty;
        #region free_mon
        [System.Data.Linq.Mapping.Column(Name = "[free_mon]", Storage = "n_sFree_mon")]
        public string free_mon
        {
            get
            {
                return this.n_sFree_mon;
            }
            set
            {
                this.n_sFree_mon = value;
            }
        }
        #endregion free_mon

        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound = false;
        private global::System.Data.DataTable n_oTbl = null;
        private global::System.Data.DataRow n_oRow = null;
        private MobileOrderMonthlyFeeInfo n_oTableSet = new MobileOrderMonthlyFeeInfo();
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        #endregion

        #region Parameter String
        public class Para
        {
            public const string mid = "mid";
            public const string mon = "mon";
            public const string fee = "fee";
            public const string active = "active";
            public const string free_mon = "free_mon";
            public const string MobileOrderMonthlyFee_table_name = Configurator.MSSQLTablePrefix + "MobileOrderMonthlyFee";
            public static string TableName() { return MobileOrderMonthlyFee_table_name; }
        }
        #endregion Parameter String

        #region Constructor
        public MobileOrderMonthlyFeeEntity()
        {
            Init();
        }
        public MobileOrderMonthlyFeeEntity(MSSQLConnect x_oDB)
        {
            n_oDB = x_oDB;
            Init();
        }

        public MobileOrderMonthlyFeeEntity(MSSQLConnect x_oDB, System.Nullable<int> x_iMid)
        {
            n_oDB = x_oDB;
            this.Load(x_iMid);
            Init();
        }

        ~MobileOrderMonthlyFeeEntity()
        {
            this.Release();
        }
        #endregion

        #region Load

        public bool Load(global::System.Nullable<int> x_iMid)
        {
            if (n_oDB == null) { return false; }
            if (x_iMid == null) { return false; }
            string _sQuery = "SELECT [MobileOrderMonthlyFee].[active] AS MOBILEORDERMONTHLYFEE_ACTIVE,[MobileOrderMonthlyFee].[mon] AS MOBILEORDERMONTHLYFEE_MON,[MobileOrderMonthlyFee].[fee] AS MOBILEORDERMONTHLYFEE_FEE,[MobileOrderMonthlyFee].[mid] AS MOBILEORDERMONTHLYFEE_MID,[MobileOrderMonthlyFee].[free_mon] AS MOBILEORDERMONTHLYFEE_FREE_MON  FROM  [MobileOrderMonthlyFee]  WHERE  [MobileOrderMonthlyFee].[mid] = \'" + x_iMid.ToString() + "\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMonthlyFee]", "[" + Configurator.MSSQLTablePrefix + "MobileOrderMonthlyFee]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMONTHLYFEE_ACTIVE"])) { n_bActive = (global::System.Nullable<bool>)_oData["MOBILEORDERMONTHLYFEE_ACTIVE"]; } else { n_bActive = null; }
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMONTHLYFEE_MON"])) { n_iMon = (global::System.Nullable<int>)_oData["MOBILEORDERMONTHLYFEE_MON"]; } else { n_iMon = null; }
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMONTHLYFEE_FEE"])) { n_iFee = (global::System.Nullable<int>)_oData["MOBILEORDERMONTHLYFEE_FEE"]; } else { n_iFee = null; }
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMONTHLYFEE_MID"])) { n_iMid = (global::System.Nullable<int>)_oData["MOBILEORDERMONTHLYFEE_MID"]; } else { n_iMid = null; }
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMONTHLYFEE_FREE_MON"])) { n_sFree_mon = (string)_oData["MOBILEORDERMONTHLYFEE_FREE_MON"]; } else { n_sFree_mon = string.Empty; }
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
            if (n_iMon == null && !(n_oTableSet.Fields(Para.mon).IsNullable)) return false;
            if (n_iFee == null && !(n_oTableSet.Fields(Para.fee).IsNullable)) return false;
            if (!x_bInsert)
            {
                if (n_iMid == null && !(n_oTableSet.Fields(Para.mid).IsNullable)) return false;
            }
            if (n_sFree_mon == null && !(n_oTableSet.Fields(Para.free_mon).IsNullable)) return false;
            return true;
        }
        #endregion

        #region Get & Set

        /// <summary>
        /// Summary description for Get & Set this all class parameters
        /// </summary>


        public object GetRepositoryObject(object x_oObj)
        {
            if ((x_oObj is MobileOrderMonthlyFee) || (x_oObj is MobileOrderMonthlyFeeEntity)) return MobileOrderMonthlyFeeRepository.Instance();
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
        public MobileOrderMonthlyFeeInfo GetTableSet() { return n_oTableSet; }
        #endregion GetTableSet


        #region SetTableSet
        public void SetTableSet(MobileOrderMonthlyFeeInfo value) { n_oTableSet = value; }
        #endregion SetTableSet

        public global::System.Nullable<int> GetMid() { return this.mid; }
        public global::System.Nullable<int> GetMon() { return this.mon; }
        public global::System.Nullable<int> GetFee() { return this.fee; }
        public global::System.Nullable<bool> GetActive() { return this.active; }
        public string GetFree_mon() { return this.free_mon; }

        public bool SetMid(global::System.Nullable<int> value)
        {
            this.mid = value;
            return true;
        }
        public bool SetMon(global::System.Nullable<int> value)
        {
            this.mon = value;
            return true;
        }
        public bool SetFee(global::System.Nullable<int> value)
        {
            this.fee = value;
            return true;
        }
        public bool SetActive(global::System.Nullable<bool> value)
        {
            this.active = value;
            return true;
        }
        public bool SetFree_mon(string value)
        {
            this.free_mon = value;
            return true;
        }

        public Field GetMidTable()
        {
            return n_oTableSet.Fields(Para.mid);
        }
        public Field GetMonTable()
        {
            return n_oTableSet.Fields(Para.mon);
        }
        public Field GetFeeTable()
        {
            return n_oTableSet.Fields(Para.fee);
        }
        public Field GetActiveTable()
        {
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetFree_monTable()
        {
            return n_oTableSet.Fields(Para.free_mon);
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

        public bool EqualID(MobileOrderMonthlyFee x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iMid.Equals(x_oObj.mid)) && isEquals;
            return isEquals;
        }

        public bool Equals(MobileOrderMonthlyFee x_oObj)
        {
            if (x_oObj == null) return false;
            if (!this.n_bActive.Equals(x_oObj.active)) { return false; }
            if (!this.n_iMon.Equals(x_oObj.mon)) { return false; }
            if (!this.n_iFee.Equals(x_oObj.fee)) { return false; }
            if (!this.n_iMid.Equals(x_oObj.mid)) { return false; }
            if (!this.n_sFree_mon.Equals(x_oObj.free_mon)) { return false; }
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
            string _sQuery = "UPDATE  [MobileOrderMonthlyFee]  SET  [active]=@active,[mon]=@mon,[fee]=@fee,[free_mon]=@free_mon  WHERE [MobileOrderMonthlyFee].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMonthlyFee]", "[" + Configurator.MSSQLTablePrefix + "MobileOrderMonthlyFee]"); }
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
            if (n_iMon == null) { _oCmd.Parameters.Add("@mon", global::System.Data.SqlDbType.Int).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@mon", global::System.Data.SqlDbType.Int).Value = n_iMon; }
            if (n_iFee == null) { _oCmd.Parameters.Add("@fee", global::System.Data.SqlDbType.Int).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@fee", global::System.Data.SqlDbType.Int).Value = n_iFee; }
            if (n_iMid == null) { _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value = n_iMid; }
            if (n_sFree_mon == null) { _oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.Char, 10).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@free_mon", global::System.Data.SqlDbType.Char, 10).Value = n_sFree_mon; }
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
        /// Summary description for table [MobileOrderMonthlyFee] Delete Record
        /// </summary>

        public bool Delete()
        {
            if (n_iMid == null) { return false; }
            string _sQuery = "DELETE FROM  [MobileOrderMonthlyFee]  WHERE [MobileOrderMonthlyFee].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMonthlyFee]", "[" + Configurator.MSSQLTablePrefix + "MobileOrderMonthlyFee]"); }
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
        /// Summary description for table [MobileOrderMonthlyFee] Object Base Clone
        /// </summary>

        public MobileOrderMonthlyFee DeepClone()
        {
            MobileOrderMonthlyFee _oMobileOrderMonthlyFee_Clone = (MobileOrderMonthlyFee)MobileOrderMonthlyFeeRepository.CreateEntityInstanceObject();
            _oMobileOrderMonthlyFee_Clone.active = this.n_bActive;
            _oMobileOrderMonthlyFee_Clone.mon = this.n_iMon;
            _oMobileOrderMonthlyFee_Clone.fee = this.n_iFee;
            _oMobileOrderMonthlyFee_Clone.mid = this.n_iMid;
            _oMobileOrderMonthlyFee_Clone.free_mon = this.n_sFree_mon;
            _oMobileOrderMonthlyFee_Clone.SetFound(this.n_bFound);
            _oMobileOrderMonthlyFee_Clone.SetDB(this.n_oDB);
            _oMobileOrderMonthlyFee_Clone.SetRow(this.n_oRow);
            _oMobileOrderMonthlyFee_Clone.SetTbl(this.n_oTbl);
            _oMobileOrderMonthlyFee_Clone.SetTableSet(this.n_oTableSet);

            return _oMobileOrderMonthlyFee_Clone;
        }
        #endregion

        #region Release

        /// <summary>
        /// Summary description for Release
        /// </summary>

        public void Release()
        {
            n_bActive = null;
            n_iMon = null;
            n_iFee = null;
            n_iMid = null;
            n_sFree_mon = string.Empty;
            n_oDB = null;
            n_bFound = false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = new MobileOrderMonthlyFeeInfo();
        }
        #endregion
    }
}

