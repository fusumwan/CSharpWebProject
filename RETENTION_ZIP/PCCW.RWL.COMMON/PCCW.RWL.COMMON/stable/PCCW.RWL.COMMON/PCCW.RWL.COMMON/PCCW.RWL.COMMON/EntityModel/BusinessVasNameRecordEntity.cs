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
///-- Description:	<Description,Table :[BusinessVasNameRecord],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE
{

    /// <summary>
    /// Summary description for table [BusinessVasNameRecord] Object Base layer
    /// </summary>

    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix + "BusinessVasNameRecord")]
    public class BusinessVasNameRecordEntity : global::System.IDisposable, global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>
    {


        protected string n_sVas_field = string.Empty;
        #region vas_field
        [System.Data.Linq.Mapping.Column(Name = "[vas_field]", Storage = "n_sVas_field")]
        public string vas_field
        {
            get
            {
                return this.n_sVas_field;
            }
            set
            {
                this.n_sVas_field = value;
            }
        }
        #endregion vas_field


        protected string n_sVas_name = string.Empty;
        #region vas_name
        [System.Data.Linq.Mapping.Column(Name = "[vas_name]", Storage = "n_sVas_name")]
        public string vas_name
        {
            get
            {
                return this.n_sVas_name;
            }
            set
            {
                this.n_sVas_name = value;
            }
        }
        #endregion vas_name


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


        protected string n_sVas_chi_name = string.Empty;
        #region vas_chi_name
        [System.Data.Linq.Mapping.Column(Name = "[vas_chi_name]", Storage = "n_sVas_chi_name")]
        public string vas_chi_name
        {
            get
            {
                return this.n_sVas_chi_name;
            }
            set
            {
                this.n_sVas_chi_name = value;
            }
        }
        #endregion vas_chi_name

        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound = false;
        private global::System.Data.DataTable n_oTbl = null;
        private global::System.Data.DataRow n_oRow = null;
        private BusinessVasNameRecordInfo n_oTableSet = new BusinessVasNameRecordInfo();
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        #endregion

        #region Parameter String
        public class Para
        {
            public const string vas_field = "vas_field";
            public const string vas_name = "vas_name";
            public const string id = "id";
            public const string active = "active";
            public const string vas_chi_name = "vas_chi_name";
            public const string BusinessVasNameRecord_table_name = Configurator.MSSQLTablePrefix + "BusinessVasNameRecord";
            public static string TableName() { return BusinessVasNameRecord_table_name; }
        }
        #endregion Parameter String

        #region Constructor
        public BusinessVasNameRecordEntity()
        {
            Init();
        }
        public BusinessVasNameRecordEntity(MSSQLConnect x_oDB)
        {
            n_oDB = x_oDB;
            Init();
        }

        public BusinessVasNameRecordEntity(MSSQLConnect x_oDB, System.Nullable<int> x_iId)
        {
            n_oDB = x_oDB;
            this.Load(x_iId);
            Init();
        }

        ~BusinessVasNameRecordEntity()
        {
            this.Release();
        }
        #endregion

        #region Load

        public bool Load(global::System.Nullable<int> x_iId)
        {
            if (n_oDB == null) { return false; }
            if (x_iId == null) { return false; }
            string _sQuery = "SELECT [BusinessVasNameRecord].[vas_field] AS BUSINESSVASNAMERECORD_VAS_FIELD,[BusinessVasNameRecord].[vas_name] AS BUSINESSVASNAMERECORD_VAS_NAME,[BusinessVasNameRecord].[active] AS BUSINESSVASNAMERECORD_ACTIVE,[BusinessVasNameRecord].[id] AS BUSINESSVASNAMERECORD_ID,[BusinessVasNameRecord].[vas_chi_name] AS BUSINESSVASNAMERECORD_VAS_CHI_NAME  FROM  [BusinessVasNameRecord]  WHERE  [BusinessVasNameRecord].[id] = \'" + x_iId.ToString() + "\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVasNameRecord]", "[" + Configurator.MSSQLTablePrefix + "BusinessVasNameRecord]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASNAMERECORD_VAS_FIELD"])) { n_sVas_field = (string)_oData["BUSINESSVASNAMERECORD_VAS_FIELD"]; } else { n_sVas_field = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASNAMERECORD_VAS_NAME"])) { n_sVas_name = (string)_oData["BUSINESSVASNAMERECORD_VAS_NAME"]; } else { n_sVas_name = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASNAMERECORD_ACTIVE"])) { n_bActive = (global::System.Nullable<bool>)_oData["BUSINESSVASNAMERECORD_ACTIVE"]; } else { n_bActive = null; }
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASNAMERECORD_ID"])) { n_iId = (global::System.Nullable<int>)_oData["BUSINESSVASNAMERECORD_ID"]; } else { n_iId = null; }
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASNAMERECORD_VAS_CHI_NAME"])) { n_sVas_chi_name = (string)_oData["BUSINESSVASNAMERECORD_VAS_CHI_NAME"]; } else { n_sVas_chi_name = string.Empty; }
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
            if (n_sVas_field == null && !(n_oTableSet.Fields(Para.vas_field).IsNullable)) return false;
            if (n_sVas_name == null && !(n_oTableSet.Fields(Para.vas_name).IsNullable)) return false;
            if (n_bActive == null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (!x_bInsert)
            {
                if (n_iId == null && !(n_oTableSet.Fields(Para.id).IsNullable)) return false;
            }
            if (n_sVas_chi_name == null && !(n_oTableSet.Fields(Para.vas_chi_name).IsNullable)) return false;
            return true;
        }
        #endregion

        #region Get & Set

        /// <summary>
        /// Summary description for Get & Set this all class parameters
        /// </summary>


        public object GetRepositoryObject(object x_oObj)
        {
            if ((x_oObj is BusinessVasNameRecord) || (x_oObj is BusinessVasNameRecordEntity)) return BusinessVasNameRecordRepository.Instance();
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
        public BusinessVasNameRecordInfo GetTableSet() { return n_oTableSet; }
        #endregion GetTableSet


        #region SetTableSet
        public void SetTableSet(BusinessVasNameRecordInfo value) { n_oTableSet = value; }
        #endregion SetTableSet

        public string GetVas_field() { return this.vas_field; }
        public string GetVas_name() { return this.vas_name; }
        public global::System.Nullable<int> GetId() { return this.id; }
        public global::System.Nullable<bool> GetActive() { return this.active; }
        public string GetVas_chi_name() { return this.vas_chi_name; }

        public bool SetVas_field(string value)
        {
            this.vas_field = value;
            return true;
        }
        public bool SetVas_name(string value)
        {
            this.vas_name = value;
            return true;
        }
        public bool SetId(global::System.Nullable<int> value)
        {
            this.id = value;
            return true;
        }
        public bool SetActive(global::System.Nullable<bool> value)
        {
            this.active = value;
            return true;
        }
        public bool SetVas_chi_name(string value)
        {
            this.vas_chi_name = value;
            return true;
        }

        public Field GetVas_fieldTable()
        {
            return n_oTableSet.Fields(Para.vas_field);
        }
        public Field GetVas_nameTable()
        {
            return n_oTableSet.Fields(Para.vas_name);
        }
        public Field GetIdTable()
        {
            return n_oTableSet.Fields(Para.id);
        }
        public Field GetActiveTable()
        {
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetVas_chi_nameTable()
        {
            return n_oTableSet.Fields(Para.vas_chi_name);
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

        public bool EqualID(BusinessVasNameRecord x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }

        public bool Equals(BusinessVasNameRecord x_oObj)
        {
            if (x_oObj == null) return false;
            if (!this.n_sVas_field.Equals(x_oObj.vas_field)) { return false; }
            if (!this.n_sVas_name.Equals(x_oObj.vas_name)) { return false; }
            if (!this.n_bActive.Equals(x_oObj.active)) { return false; }
            if (!this.n_iId.Equals(x_oObj.id)) { return false; }
            if (!this.n_sVas_chi_name.Equals(x_oObj.vas_chi_name)) { return false; }
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
            string _sQuery = "UPDATE  [BusinessVasNameRecord]  SET  [vas_field]=@vas_field,[vas_name]=@vas_name,[active]=@active,[vas_chi_name]=@vas_chi_name  WHERE [BusinessVasNameRecord].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVasNameRecord]", "[" + Configurator.MSSQLTablePrefix + "BusinessVasNameRecord]"); }
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
            if (n_sVas_field == null) { _oCmd.Parameters.Add("@vas_field", global::System.Data.SqlDbType.NVarChar, 50).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@vas_field", global::System.Data.SqlDbType.NVarChar, 50).Value = n_sVas_field; }
            if (n_sVas_name == null) { _oCmd.Parameters.Add("@vas_name", global::System.Data.SqlDbType.NVarChar, 50).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@vas_name", global::System.Data.SqlDbType.NVarChar, 50).Value = n_sVas_name; }
            if (n_bActive == null) { _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = n_bActive; }
            if (n_iId == null) { _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = n_iId; }
            if (n_sVas_chi_name == null) { _oCmd.Parameters.Add("@vas_chi_name", global::System.Data.SqlDbType.NVarChar, 50).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@vas_chi_name", global::System.Data.SqlDbType.NVarChar, 50).Value = n_sVas_chi_name; }
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
        /// Summary description for table [BusinessVasNameRecord] Delete Record
        /// </summary>

        public bool Delete()
        {
            if (n_iId == null) { return false; }
            string _sQuery = "DELETE FROM  [BusinessVasNameRecord]  WHERE [BusinessVasNameRecord].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVasNameRecord]", "[" + Configurator.MSSQLTablePrefix + "BusinessVasNameRecord]"); }
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
        /// Summary description for table [BusinessVasNameRecord] Object Base Clone
        /// </summary>

        public BusinessVasNameRecord DeepClone()
        {
            BusinessVasNameRecord _oBusinessVasNameRecord_Clone = (BusinessVasNameRecord)BusinessVasNameRecordRepository.CreateEntityInstanceObject();
            _oBusinessVasNameRecord_Clone.vas_field = this.n_sVas_field;
            _oBusinessVasNameRecord_Clone.vas_name = this.n_sVas_name;
            _oBusinessVasNameRecord_Clone.active = this.n_bActive;
            _oBusinessVasNameRecord_Clone.id = this.n_iId;
            _oBusinessVasNameRecord_Clone.vas_chi_name = this.n_sVas_chi_name;
            _oBusinessVasNameRecord_Clone.SetFound(this.n_bFound);
            _oBusinessVasNameRecord_Clone.SetDB(this.n_oDB);
            _oBusinessVasNameRecord_Clone.SetRow(this.n_oRow);
            _oBusinessVasNameRecord_Clone.SetTbl(this.n_oTbl);
            _oBusinessVasNameRecord_Clone.SetTableSet(this.n_oTableSet);

            return _oBusinessVasNameRecord_Clone;
        }
        #endregion

        #region Release

        /// <summary>
        /// Summary description for Release
        /// </summary>

        public void Release()
        {
            n_sVas_field = string.Empty;
            n_sVas_name = string.Empty;
            n_bActive = null;
            n_iId = null;
            n_sVas_chi_name = string.Empty;
            n_oDB = null;
            n_bFound = false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = new BusinessVasNameRecordInfo();
        }
        #endregion
    }
}

