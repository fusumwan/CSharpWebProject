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
///-- Description:	<Description,Table :[BusinessVasDescription],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE
{

    /// <summary>
    /// Summary description for table [BusinessVasDescription] Object Base layer
    /// </summary>

    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix + "BusinessVasDescription")]
    public class BusinessVasDescriptionEntity : global::System.IDisposable, global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>
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


        protected string n_sVas_desc = string.Empty;
        #region vas_desc
        [System.Data.Linq.Mapping.Column(Name = "[vas_desc]", Storage = "n_sVas_desc")]
        public string vas_desc
        {
            get
            {
                return this.n_sVas_desc;
            }
            set
            {
                this.n_sVas_desc = value;
            }
        }
        #endregion vas_desc


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


        protected string n_sVas = string.Empty;
        #region vas
        [System.Data.Linq.Mapping.Column(Name = "[vas]", Storage = "n_sVas")]
        public string vas
        {
            get
            {
                return this.n_sVas;
            }
            set
            {
                this.n_sVas = value;
            }
        }
        #endregion vas


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

        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound = false;
        private global::System.Data.DataTable n_oTbl = null;
        private global::System.Data.DataRow n_oRow = null;
        private BusinessVasDescriptionInfo n_oTableSet = new BusinessVasDescriptionInfo();
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        #endregion

        #region Parameter String
        public class Para
        {
            public const string id = "id";
            public const string fee = "fee";
            public const string vas_desc = "vas_desc";
            public const string active = "active";
            public const string vas = "vas";
            public const string BusinessVasDescription_table_name = Configurator.MSSQLTablePrefix + "BusinessVasDescription";
            public static string TableName() { return BusinessVasDescription_table_name; }
        }
        #endregion Parameter String

        #region Constructor
        public BusinessVasDescriptionEntity()
        {
            Init();
        }
        public BusinessVasDescriptionEntity(MSSQLConnect x_oDB)
        {
            n_oDB = x_oDB;
            Init();
        }

        public BusinessVasDescriptionEntity(MSSQLConnect x_oDB, System.Nullable<int> x_iId)
        {
            n_oDB = x_oDB;
            this.Load(x_iId);
            Init();
        }

        ~BusinessVasDescriptionEntity()
        {
            this.Release();
        }
        #endregion

        #region Load

        public bool Load(global::System.Nullable<int> x_iId)
        {
            if (n_oDB == null) { return false; }
            if (x_iId == null) { return false; }
            string _sQuery = "SELECT [BusinessVasDescription].[active] AS BUSINESSVASDESCRIPTION_ACTIVE,[BusinessVasDescription].[vas_desc] AS BUSINESSVASDESCRIPTION_VAS_DESC,[BusinessVasDescription].[fee] AS BUSINESSVASDESCRIPTION_FEE,[BusinessVasDescription].[vas] AS BUSINESSVASDESCRIPTION_VAS,[BusinessVasDescription].[id] AS BUSINESSVASDESCRIPTION_ID  FROM  [BusinessVasDescription]  WHERE  [BusinessVasDescription].[id] = \'" + x_iId.ToString() + "\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVasDescription]", "[" + Configurator.MSSQLTablePrefix + "BusinessVasDescription]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDESCRIPTION_ACTIVE"])) { n_bActive = (global::System.Nullable<bool>)_oData["BUSINESSVASDESCRIPTION_ACTIVE"]; } else { n_bActive = null; }
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDESCRIPTION_VAS_DESC"])) { n_sVas_desc = (string)_oData["BUSINESSVASDESCRIPTION_VAS_DESC"]; } else { n_sVas_desc = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDESCRIPTION_FEE"])) { n_sFee = (string)_oData["BUSINESSVASDESCRIPTION_FEE"]; } else { n_sFee = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDESCRIPTION_VAS"])) { n_sVas = (string)_oData["BUSINESSVASDESCRIPTION_VAS"]; } else { n_sVas = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDESCRIPTION_ID"])) { n_iId = (global::System.Nullable<int>)_oData["BUSINESSVASDESCRIPTION_ID"]; } else { n_iId = null; }
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
            if (n_sVas_desc == null && !(n_oTableSet.Fields(Para.vas_desc).IsNullable)) return false;
            if (n_sFee == null && !(n_oTableSet.Fields(Para.fee).IsNullable)) return false;
            if (n_sVas == null && !(n_oTableSet.Fields(Para.vas).IsNullable)) return false;
            if (!x_bInsert)
            {
                if (n_iId == null && !(n_oTableSet.Fields(Para.id).IsNullable)) return false;
            }
            return true;
        }
        #endregion

        #region Get & Set

        /// <summary>
        /// Summary description for Get & Set this all class parameters
        /// </summary>


        public object GetRepositoryObject(object x_oObj)
        {
            if ((x_oObj is BusinessVasDescription) || (x_oObj is BusinessVasDescriptionEntity)) return BusinessVasDescriptionRepository.Instance();
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
        public BusinessVasDescriptionInfo GetTableSet() { return n_oTableSet; }
        #endregion GetTableSet


        #region SetTableSet
        public void SetTableSet(BusinessVasDescriptionInfo value) { n_oTableSet = value; }
        #endregion SetTableSet

        public global::System.Nullable<int> GetId() { return this.id; }
        public string GetFee() { return this.fee; }
        public string GetVas_desc() { return this.vas_desc; }
        public global::System.Nullable<bool> GetActive() { return this.active; }
        public string GetVas() { return this.vas; }

        public bool SetId(global::System.Nullable<int> value)
        {
            this.id = value;
            return true;
        }
        public bool SetFee(string value)
        {
            this.fee = value;
            return true;
        }
        public bool SetVas_desc(string value)
        {
            this.vas_desc = value;
            return true;
        }
        public bool SetActive(global::System.Nullable<bool> value)
        {
            this.active = value;
            return true;
        }
        public bool SetVas(string value)
        {
            this.vas = value;
            return true;
        }

        public Field GetIdTable()
        {
            return n_oTableSet.Fields(Para.id);
        }
        public Field GetFeeTable()
        {
            return n_oTableSet.Fields(Para.fee);
        }
        public Field GetVas_descTable()
        {
            return n_oTableSet.Fields(Para.vas_desc);
        }
        public Field GetActiveTable()
        {
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetVasTable()
        {
            return n_oTableSet.Fields(Para.vas);
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

        public bool EqualID(BusinessVasDescription x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }

        public bool Equals(BusinessVasDescription x_oObj)
        {
            if (x_oObj == null) return false;
            if (!this.n_bActive.Equals(x_oObj.active)) { return false; }
            if (!this.n_sVas_desc.Equals(x_oObj.vas_desc)) { return false; }
            if (!this.n_sFee.Equals(x_oObj.fee)) { return false; }
            if (!this.n_sVas.Equals(x_oObj.vas)) { return false; }
            if (!this.n_iId.Equals(x_oObj.id)) { return false; }
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
            string _sQuery = "UPDATE  [BusinessVasDescription]  SET  [active]=@active,[vas_desc]=@vas_desc,[fee]=@fee,[vas]=@vas  WHERE [BusinessVasDescription].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVasDescription]", "[" + Configurator.MSSQLTablePrefix + "BusinessVasDescription]"); }
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
            if (n_sVas_desc == null) { _oCmd.Parameters.Add("@vas_desc", global::System.Data.SqlDbType.NVarChar, 50).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@vas_desc", global::System.Data.SqlDbType.NVarChar, 50).Value = n_sVas_desc; }
            if (n_sFee == null) { _oCmd.Parameters.Add("@fee", global::System.Data.SqlDbType.NVarChar, 50).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@fee", global::System.Data.SqlDbType.NVarChar, 50).Value = n_sFee; }
            if (n_sVas == null) { _oCmd.Parameters.Add("@vas", global::System.Data.SqlDbType.NVarChar, 50).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@vas", global::System.Data.SqlDbType.NVarChar, 50).Value = n_sVas; }
            if (n_iId == null) { _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = n_iId; }
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
        /// Summary description for table [BusinessVasDescription] Delete Record
        /// </summary>

        public bool Delete()
        {
            if (n_iId == null) { return false; }
            string _sQuery = "DELETE FROM  [BusinessVasDescription]  WHERE [BusinessVasDescription].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVasDescription]", "[" + Configurator.MSSQLTablePrefix + "BusinessVasDescription]"); }
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
        /// Summary description for table [BusinessVasDescription] Object Base Clone
        /// </summary>

        public BusinessVasDescription DeepClone()
        {
            BusinessVasDescription _oBusinessVasDescription_Clone = (BusinessVasDescription)BusinessVasDescriptionRepository.CreateEntityInstanceObject();
            _oBusinessVasDescription_Clone.active = this.n_bActive;
            _oBusinessVasDescription_Clone.vas_desc = this.n_sVas_desc;
            _oBusinessVasDescription_Clone.fee = this.n_sFee;
            _oBusinessVasDescription_Clone.vas = this.n_sVas;
            _oBusinessVasDescription_Clone.id = this.n_iId;
            _oBusinessVasDescription_Clone.SetFound(this.n_bFound);
            _oBusinessVasDescription_Clone.SetDB(this.n_oDB);
            _oBusinessVasDescription_Clone.SetRow(this.n_oRow);
            _oBusinessVasDescription_Clone.SetTbl(this.n_oTbl);
            _oBusinessVasDescription_Clone.SetTableSet(this.n_oTableSet);

            return _oBusinessVasDescription_Clone;
        }
        #endregion

        #region Release

        /// <summary>
        /// Summary description for Release
        /// </summary>

        public void Release()
        {
            n_bActive = null;
            n_sVas_desc = string.Empty;
            n_sFee = string.Empty;
            n_sVas = string.Empty;
            n_iId = null;
            n_oDB = null;
            n_bFound = false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = new BusinessVasDescriptionInfo();
        }
        #endregion
    }
}

