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
///-- Create date: <Create Date 2010-05-17>
///-- Description:	<Description,Table :[BankCode],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE
{

    /// <summary>
    /// Summary description for table [BankCode] Object Base layer
    /// </summary>

    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix + "BankCode")]
    public class BankCodeEntity : global::System.IDisposable, global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>
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


        protected string n_sBank_code = global::System.String.Empty;
        #region bank_code
        [System.Data.Linq.Mapping.Column(Name = "[bank_code]", Storage = "n_sBank_code")]
        public string bank_code
        {
            get
            {
                return this.n_sBank_code;
            }
            set
            {
                this.n_sBank_code = value;
            }
        }
        #endregion bank_code


        protected string n_sBank_name = global::System.String.Empty;
        #region bank_name
        [System.Data.Linq.Mapping.Column(Name = "[bank_name]", Storage = "n_sBank_name")]
        public string bank_name
        {
            get
            {
                return this.n_sBank_name;
            }
            set
            {
                this.n_sBank_name = value;
            }
        }
        #endregion bank_name


        protected string n_sInstallment_period = global::System.String.Empty;
        #region installment_period
        [System.Data.Linq.Mapping.Column(Name = "[installment_period]", Storage = "n_sInstallment_period")]
        public string installment_period
        {
            get
            {
                return this.n_sInstallment_period;
            }
            set
            {
                this.n_sInstallment_period = value;
            }
        }
        #endregion installment_period


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


        protected string n_sMin_amount = global::System.String.Empty;
        #region min_amount
        [System.Data.Linq.Mapping.Column(Name = "[min_amount]", Storage = "n_sMin_amount")]
        public string min_amount
        {
            get
            {
                return this.n_sMin_amount;
            }
            set
            {
                this.n_sMin_amount = value;
            }
        }
        #endregion min_amount

        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound = false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private BankCodeInfo n_oTableSet = BankCodeInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        #endregion

        #region Parameter String
        public class Para
        {
            public const string bank_code = "bank_code";
            public const string bank_name = "bank_name";
            public const string mid = "mid";
            public const string installment_period = "installment_period";
            public const string active = "active";
            public const string min_amount = "min_amount";
            public const string BankCode_table_name = "BankCode";
            public static string TableName() { return BankCode_table_name; }
        }
        #endregion Parameter String

        #region Constructor
        public BankCodeEntity()
        {
            Init();
        }
        public BankCodeEntity(MSSQLConnect x_oDB)
        {
            n_oDB = x_oDB;
            Init();
        }

        public BankCodeEntity(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            n_oDB = x_oDB;
            this.Load(x_iMid);
            Init();
        }

        ~BankCodeEntity()
        {
            this.Release();
        }
        #endregion

        #region Load

        public bool Load(global::System.Nullable<int> x_iMid)
        {
            if (n_oDB == null) { return false; }
            if (x_iMid == null) { return false; }
            string _sQuery = "SELECT   [BankCode].[active] AS BANKCODE_ACTIVE,[BankCode].[bank_code] AS BANKCODE_BANK_CODE,[BankCode].[bank_name] AS BANKCODE_BANK_NAME,[BankCode].[installment_period] AS BANKCODE_INSTALLMENT_PERIOD,[BankCode].[mid] AS BANKCODE_MID,[BankCode].[min_amount] AS BANKCODE_MIN_AMOUNT  FROM  [BankCode]  WHERE  [BankCode].[mid] = \'" + x_iMid.ToString() + "\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BankCode]", "[" + Configurator.MSSQLTablePrefix + "BankCode]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["BANKCODE_ACTIVE"])) { n_bActive = (global::System.Nullable<bool>)_oData["BANKCODE_ACTIVE"]; } else { n_bActive = null; }
                        if (!global::System.Convert.IsDBNull(_oData["BANKCODE_BANK_CODE"])) { n_sBank_code = (string)_oData["BANKCODE_BANK_CODE"]; } else { n_sBank_code = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["BANKCODE_BANK_NAME"])) { n_sBank_name = (string)_oData["BANKCODE_BANK_NAME"]; } else { n_sBank_name = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["BANKCODE_INSTALLMENT_PERIOD"])) { n_sInstallment_period = (string)_oData["BANKCODE_INSTALLMENT_PERIOD"]; } else { n_sInstallment_period = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["BANKCODE_MID"])) { n_iMid = (global::System.Nullable<int>)_oData["BANKCODE_MID"]; } else { n_iMid = null; }
                        if (!global::System.Convert.IsDBNull(_oData["BANKCODE_MIN_AMOUNT"])) { n_sMin_amount = (string)_oData["BANKCODE_MIN_AMOUNT"]; } else { n_sMin_amount = global::System.String.Empty; }
                    }
                    _oData.Close();
                    _oData.Dispose();
                }
                catch { }
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
            if (n_sBank_code == null && !(n_oTableSet.Fields(Para.bank_code).IsNullable)) return false;
            if (n_sBank_name == null && !(n_oTableSet.Fields(Para.bank_name).IsNullable)) return false;
            if (n_sInstallment_period == null && !(n_oTableSet.Fields(Para.installment_period).IsNullable)) return false;
            if (!x_bInsert)
            {
                if (n_iMid == null && !(n_oTableSet.Fields(Para.mid).IsNullable)) return false;
            }
            if (n_sMin_amount == null && !(n_oTableSet.Fields(Para.min_amount).IsNullable)) return false;
            return true;
        }
        #endregion

        #region Get & Set

        /// <summary>
        /// Summary description for Get & Set this all class parameters
        /// </summary>


        public object GetRepositoryObject(object x_oObj)
        {
            if (x_oObj == null) return null;
            if (x_oObj.GetType().IsSubclassOf(typeof(BankCodeEntity)) || (x_oObj is BankCodeEntity)) return BankCodeRepository.Instance();
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
        public BankCodeInfo GetTableSet() { return n_oTableSet; }
        #endregion GetTableSet


        #region SetTableSet
        public void SetTableSet(BankCodeInfo value) { n_oTableSet = value; }
        #endregion SetTableSet

        public string GetBank_code() { return this.bank_code; }
        public string GetBank_name() { return this.bank_name; }
        public global::System.Nullable<int> GetMid() { return this.mid; }
        public string GetInstallment_period() { return this.installment_period; }
        public global::System.Nullable<bool> GetActive() { return this.active; }
        public string GetMin_amount() { return this.min_amount; }

        public bool SetBank_code(string value)
        {
            this.bank_code = value;
            return true;
        }
        public bool SetBank_name(string value)
        {
            this.bank_name = value;
            return true;
        }
        public bool SetMid(global::System.Nullable<int> value)
        {
            this.mid = value;
            return true;
        }
        public bool SetInstallment_period(string value)
        {
            this.installment_period = value;
            return true;
        }
        public bool SetActive(global::System.Nullable<bool> value)
        {
            this.active = value;
            return true;
        }
        public bool SetMin_amount(string value)
        {
            this.min_amount = value;
            return true;
        }

        public Field GetBank_codeTable()
        {
            return n_oTableSet.Fields(Para.bank_code);
        }
        public Field GetBank_nameTable()
        {
            return n_oTableSet.Fields(Para.bank_name);
        }
        public Field GetMidTable()
        {
            return n_oTableSet.Fields(Para.mid);
        }
        public Field GetInstallment_periodTable()
        {
            return n_oTableSet.Fields(Para.installment_period);
        }
        public Field GetActiveTable()
        {
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetMin_amountTable()
        {
            return n_oTableSet.Fields(Para.min_amount);
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

        public bool EqualID(BankCode x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iMid.Equals(x_oObj.mid)) && isEquals;
            return isEquals;
        }

        public bool Equals(BankCode x_oObj)
        {
            if (x_oObj == null) return false;
            if (!this.n_bActive.Equals(x_oObj.active)) { return false; }
            if (!this.n_sBank_code.Equals(x_oObj.bank_code)) { return false; }
            if (!this.n_sBank_name.Equals(x_oObj.bank_name)) { return false; }
            if (!this.n_sInstallment_period.Equals(x_oObj.installment_period)) { return false; }
            if (!this.n_iMid.Equals(x_oObj.mid)) { return false; }
            if (!this.n_sMin_amount.Equals(x_oObj.min_amount)) { return false; }
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
            string _sQuery = "UPDATE  [BankCode]  SET  [active]=@active,[bank_code]=@bank_code,[bank_name]=@bank_name,[installment_period]=@installment_period,[min_amount]=@min_amount  WHERE [BankCode].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BankCode]", "[" + Configurator.MSSQLTablePrefix + "BankCode]"); }
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
            if (n_bActive == null) { _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = n_bActive; }
            if (n_sBank_code == null) { _oCmd.Parameters.Add("@bank_code", global::System.Data.SqlDbType.VarChar, 200).Value = DBNull.Value; } else { _oCmd.Parameters.Add("@bank_code", global::System.Data.SqlDbType.VarChar, 200).Value = n_sBank_code; }
            if (n_sBank_name == null) { _oCmd.Parameters.Add("@bank_name", global::System.Data.SqlDbType.VarChar, 200).Value = DBNull.Value; } else { _oCmd.Parameters.Add("@bank_name", global::System.Data.SqlDbType.VarChar, 200).Value = n_sBank_name; }
            if (n_sInstallment_period == null) { _oCmd.Parameters.Add("@installment_period", global::System.Data.SqlDbType.NVarChar, 250).Value = DBNull.Value; } else { _oCmd.Parameters.Add("@installment_period", global::System.Data.SqlDbType.NVarChar, 250).Value = n_sInstallment_period; }
            if (n_iMid == null) { _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value = DBNull.Value; } else { _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value = n_iMid; }
            if (n_sMin_amount == null) { _oCmd.Parameters.Add("@min_amount", global::System.Data.SqlDbType.NVarChar, 10).Value = DBNull.Value; } else { _oCmd.Parameters.Add("@min_amount", global::System.Data.SqlDbType.NVarChar, 10).Value = n_sMin_amount; }
            try
            {
                if (!n_oDB.bTransaction && _oConn.State == ConnectionState.Closed) _oConn.Open();
                _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
            }
            catch { }
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
        /// Summary description for table [BankCode] Delete Record
        /// </summary>

        public bool Delete()
        {
            if (n_iMid == null) { return false; }
            string _sQuery = "DELETE FROM  [BankCode]  WHERE [BankCode].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BankCode]", "[" + Configurator.MSSQLTablePrefix + "BankCode]"); }
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
                _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
            }
            catch { }
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
        /// Summary description for table [BankCode] Object Base Clone
        /// </summary>

        public BankCode DeepClone()
        {
            BankCode _oBankCode_Clone = new BankCode();
            _oBankCode_Clone.active = this.n_bActive;
            _oBankCode_Clone.bank_code = this.n_sBank_code;
            _oBankCode_Clone.bank_name = this.n_sBank_name;
            _oBankCode_Clone.installment_period = this.n_sInstallment_period;
            _oBankCode_Clone.mid = this.n_iMid;
            _oBankCode_Clone.min_amount = this.n_sMin_amount;
            _oBankCode_Clone.SetFound(this.n_bFound);
            _oBankCode_Clone.SetDB(this.n_oDB);
            _oBankCode_Clone.SetRow(this.n_oRow);
            _oBankCode_Clone.SetTbl(this.n_oTbl);
            _oBankCode_Clone.SetTableSet(this.n_oTableSet);

            return _oBankCode_Clone;
        }
        #endregion

        #region Release

        /// <summary>
        /// Summary description for Release
        /// </summary>

        public void Release()
        {
            n_bActive = null;
            n_sBank_code = global::System.String.Empty;
            n_sBank_name = global::System.String.Empty;
            n_sInstallment_period = global::System.String.Empty;
            n_iMid = null;
            n_sMin_amount = global::System.String.Empty;
            n_oDB = null;
            n_bFound = false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = BankCodeInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}

