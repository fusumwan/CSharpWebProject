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
///-- Description:	<Description,Table :[ProductItemCode],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE
{

    /// <summary>
    /// Summary description for table [ProductItemCode] Object Base layer
    /// </summary>

    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix + "ProductItemCode")]
    public class ProductItemCodeEntity : global::System.IDisposable, global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>
    {


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


        protected string n_sHs_model = string.Empty;
        #region hs_model
        [System.Data.Linq.Mapping.Column(Name = "[hs_model]", Storage = "n_sHs_model")]
        public string hs_model
        {
            get
            {
                return this.n_sHs_model;
            }
            set
            {
                this.n_sHs_model = value;
            }
        }
        #endregion hs_model


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


        protected string n_sType = string.Empty;
        #region type
        [System.Data.Linq.Mapping.Column(Name = "[type]", Storage = "n_sType")]
        public string type
        {
            get
            {
                return this.n_sType;
            }
            set
            {
                this.n_sType = value;
            }
        }
        #endregion type


        protected global::System.Nullable<bool> n_bLast_stock = null;
        #region last_stock
        [System.Data.Linq.Mapping.Column(Name = "[last_stock]", Storage = "n_bLast_stock")]
        public global::System.Nullable<bool> last_stock
        {
            get
            {
                return this.n_bLast_stock;
            }
            set
            {
                this.n_bLast_stock = value;
            }
        }
        #endregion last_stock


        protected string n_sItem_code = string.Empty;
        #region item_code
        [System.Data.Linq.Mapping.Column(Name = "[item_code]", Storage = "n_sItem_code")]
        public string item_code
        {
            get
            {
                return this.n_sItem_code;
            }
            set
            {
                this.n_sItem_code = value;
            }
        }
        #endregion item_code


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


        protected string n_sQuota = string.Empty;
        #region quota
        [System.Data.Linq.Mapping.Column(Name = "[quota]", Storage = "n_sQuota")]
        public string quota
        {
            get
            {
                return this.n_sQuota;
            }
            set
            {
                this.n_sQuota = value;
            }
        }
        #endregion quota

        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound = false;
        private global::System.Data.DataTable n_oTbl = null;
        private global::System.Data.DataRow n_oRow = null;
        private ProductItemCodeInfo n_oTableSet = new ProductItemCodeInfo();
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        #endregion

        #region Parameter String
        public class Para
        {
            public const string active = "active";
            public const string cdate = "cdate";
            public const string cid = "cid";
            public const string did = "did";
            public const string type = "type";
            public const string hs_model = "hs_model";
            public const string last_stock = "last_stock";
            public const string item_code = "item_code";
            public const string edate = "edate";
            public const string ddate = "ddate";
            public const string mid = "mid";
            public const string sdate = "sdate";
            public const string quota = "quota";
            public const string ProductItemCode_table_name = Configurator.MSSQLTablePrefix + "ProductItemCode";
            public static string TableName() { return ProductItemCode_table_name; }
        }
        #endregion Parameter String

        #region Constructor
        public ProductItemCodeEntity()
        {
            Init();
        }
        public ProductItemCodeEntity(MSSQLConnect x_oDB)
        {
            n_oDB = x_oDB;
            Init();
        }

        public ProductItemCodeEntity(MSSQLConnect x_oDB, System.Nullable<int> x_iMid)
        {
            n_oDB = x_oDB;
            this.Load(x_iMid);
            Init();
        }

        ~ProductItemCodeEntity()
        {
            this.Release();
        }
        #endregion

        #region Load

        public bool Load(global::System.Nullable<int> x_iMid)
        {
            if (n_oDB == null) { return false; }
            if (x_iMid == null) { return false; }
            string _sQuery = "SELECT [ProductItemCode].[cid] AS PRODUCTITEMCODE_CID,[ProductItemCode].[active] AS PRODUCTITEMCODE_ACTIVE,[ProductItemCode].[cdate] AS PRODUCTITEMCODE_CDATE,[ProductItemCode].[hs_model] AS PRODUCTITEMCODE_HS_MODEL,[ProductItemCode].[did] AS PRODUCTITEMCODE_DID,[ProductItemCode].[type] AS PRODUCTITEMCODE_TYPE,[ProductItemCode].[last_stock] AS PRODUCTITEMCODE_LAST_STOCK,[ProductItemCode].[item_code] AS PRODUCTITEMCODE_ITEM_CODE,[ProductItemCode].[edate] AS PRODUCTITEMCODE_EDATE,[ProductItemCode].[ddate] AS PRODUCTITEMCODE_DDATE,[ProductItemCode].[mid] AS PRODUCTITEMCODE_MID,[ProductItemCode].[sdate] AS PRODUCTITEMCODE_SDATE,[ProductItemCode].[quota] AS PRODUCTITEMCODE_QUOTA  FROM  [ProductItemCode]  WHERE  [ProductItemCode].[mid] = \'" + x_iMid.ToString() + "\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProductItemCode]", "[" + Configurator.MSSQLTablePrefix + "ProductItemCode]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_CID"])) { n_sCid = (string)_oData["PRODUCTITEMCODE_CID"]; } else { n_sCid = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_ACTIVE"])) { n_bActive = (global::System.Nullable<bool>)_oData["PRODUCTITEMCODE_ACTIVE"]; } else { n_bActive = null; }
                        if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_CDATE"])) { n_dCdate = (global::System.Nullable<DateTime>)_oData["PRODUCTITEMCODE_CDATE"]; } else { n_dCdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_HS_MODEL"])) { n_sHs_model = (string)_oData["PRODUCTITEMCODE_HS_MODEL"]; } else { n_sHs_model = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_DID"])) { n_sDid = (string)_oData["PRODUCTITEMCODE_DID"]; } else { n_sDid = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_TYPE"])) { n_sType = (string)_oData["PRODUCTITEMCODE_TYPE"]; } else { n_sType = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_LAST_STOCK"])) { n_bLast_stock = (global::System.Nullable<bool>)_oData["PRODUCTITEMCODE_LAST_STOCK"]; } else { n_bLast_stock = null; }
                        if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_ITEM_CODE"])) { n_sItem_code = (string)_oData["PRODUCTITEMCODE_ITEM_CODE"]; } else { n_sItem_code = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_EDATE"])) { n_dEdate = (global::System.Nullable<DateTime>)_oData["PRODUCTITEMCODE_EDATE"]; } else { n_dEdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_DDATE"])) { n_dDdate = (global::System.Nullable<DateTime>)_oData["PRODUCTITEMCODE_DDATE"]; } else { n_dDdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_MID"])) { n_iMid = (global::System.Nullable<int>)_oData["PRODUCTITEMCODE_MID"]; } else { n_iMid = null; }
                        if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_SDATE"])) { n_dSdate = (global::System.Nullable<DateTime>)_oData["PRODUCTITEMCODE_SDATE"]; } else { n_dSdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_QUOTA"])) { n_sQuota = (string)_oData["PRODUCTITEMCODE_QUOTA"]; } else { n_sQuota = string.Empty; }
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
            if (n_sCid == null && !(n_oTableSet.Fields(Para.cid).IsNullable)) return false;
            if (n_bActive == null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_dCdate == null && !(n_oTableSet.Fields(Para.cdate).IsNullable)) return false;
            if (n_sHs_model == null && !(n_oTableSet.Fields(Para.hs_model).IsNullable)) return false;
            if (n_sDid == null && !(n_oTableSet.Fields(Para.did).IsNullable)) return false;
            if (n_sType == null && !(n_oTableSet.Fields(Para.type).IsNullable)) return false;
            if (n_bLast_stock == null && !(n_oTableSet.Fields(Para.last_stock).IsNullable)) return false;
            if (n_sItem_code == null && !(n_oTableSet.Fields(Para.item_code).IsNullable)) return false;
            if (n_dEdate == null && !(n_oTableSet.Fields(Para.edate).IsNullable)) return false;
            if (n_dDdate == null && !(n_oTableSet.Fields(Para.ddate).IsNullable)) return false;
            if (!x_bInsert)
            {
                if (n_iMid == null && !(n_oTableSet.Fields(Para.mid).IsNullable)) return false;
            }
            if (n_dSdate == null && !(n_oTableSet.Fields(Para.sdate).IsNullable)) return false;
            if (n_sQuota == null && !(n_oTableSet.Fields(Para.quota).IsNullable)) return false;
            return true;
        }
        #endregion

        #region Get & Set

        /// <summary>
        /// Summary description for Get & Set this all class parameters
        /// </summary>


        public object GetRepositoryObject(object x_oObj)
        {
            if ((x_oObj is ProductItemCode) || (x_oObj is ProductItemCodeEntity)) return ProductItemCodeRepository.Instance();
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
        public ProductItemCodeInfo GetTableSet() { return n_oTableSet; }
        #endregion GetTableSet


        #region SetTableSet
        public void SetTableSet(ProductItemCodeInfo value) { n_oTableSet = value; }
        #endregion SetTableSet

        public global::System.Nullable<bool> GetActive() { return this.active; }
        public global::System.Nullable<DateTime> GetCdate() { return this.cdate; }
        public string GetCid() { return this.cid; }
        public string GetDid() { return this.did; }
        public string GetType() { return this.type; }
        public string GetHs_model() { return this.hs_model; }
        public global::System.Nullable<bool> GetLast_stock() { return this.last_stock; }
        public string GetItem_code() { return this.item_code; }
        public global::System.Nullable<DateTime> GetEdate() { return this.edate; }
        public global::System.Nullable<DateTime> GetDdate() { return this.ddate; }
        public global::System.Nullable<int> GetMid() { return this.mid; }
        public global::System.Nullable<DateTime> GetSdate() { return this.sdate; }
        public string GetQuota() { return this.quota; }

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
        public bool SetType(string value)
        {
            this.type = value;
            return true;
        }
        public bool SetHs_model(string value)
        {
            this.hs_model = value;
            return true;
        }
        public bool SetLast_stock(global::System.Nullable<bool> value)
        {
            this.last_stock = value;
            return true;
        }
        public bool SetItem_code(string value)
        {
            this.item_code = value;
            return true;
        }
        public bool SetEdate(global::System.Nullable<DateTime> value)
        {
            this.edate = value;
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
        public bool SetSdate(global::System.Nullable<DateTime> value)
        {
            this.sdate = value;
            return true;
        }
        public bool SetQuota(string value)
        {
            this.quota = value;
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
        public Field GetTypeTable()
        {
            return n_oTableSet.Fields(Para.type);
        }
        public Field GetHs_modelTable()
        {
            return n_oTableSet.Fields(Para.hs_model);
        }
        public Field GetLast_stockTable()
        {
            return n_oTableSet.Fields(Para.last_stock);
        }
        public Field GetItem_codeTable()
        {
            return n_oTableSet.Fields(Para.item_code);
        }
        public Field GetEdateTable()
        {
            return n_oTableSet.Fields(Para.edate);
        }
        public Field GetDdateTable()
        {
            return n_oTableSet.Fields(Para.ddate);
        }
        public Field GetMidTable()
        {
            return n_oTableSet.Fields(Para.mid);
        }
        public Field GetSdateTable()
        {
            return n_oTableSet.Fields(Para.sdate);
        }
        public Field GetQuotaTable()
        {
            return n_oTableSet.Fields(Para.quota);
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

        public bool EqualID(ProductItemCode x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iMid.Equals(x_oObj.mid)) && isEquals;
            return isEquals;
        }

        public bool Equals(ProductItemCode x_oObj)
        {
            if (x_oObj == null) return false;
            if (!this.n_sCid.Equals(x_oObj.cid)) { return false; }
            if (!this.n_bActive.Equals(x_oObj.active)) { return false; }
            if (!this.n_dCdate.Equals(x_oObj.cdate)) { return false; }
            if (!this.n_sHs_model.Equals(x_oObj.hs_model)) { return false; }
            if (!this.n_sDid.Equals(x_oObj.did)) { return false; }
            if (!this.n_sType.Equals(x_oObj.type)) { return false; }
            if (!this.n_bLast_stock.Equals(x_oObj.last_stock)) { return false; }
            if (!this.n_sItem_code.Equals(x_oObj.item_code)) { return false; }
            if (!this.n_dEdate.Equals(x_oObj.edate)) { return false; }
            if (!this.n_dDdate.Equals(x_oObj.ddate)) { return false; }
            if (!this.n_iMid.Equals(x_oObj.mid)) { return false; }
            if (!this.n_dSdate.Equals(x_oObj.sdate)) { return false; }
            if (!this.n_sQuota.Equals(x_oObj.quota)) { return false; }
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
            string _sQuery = "UPDATE  [ProductItemCode]  SET  [cid]=@cid,[active]=@active,[cdate]=@cdate,[hs_model]=@hs_model,[did]=@did,[type]=@type,[last_stock]=@last_stock,[item_code]=@item_code,[edate]=@edate,[ddate]=@ddate,[sdate]=@sdate,[quota]=@quota  WHERE [ProductItemCode].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProductItemCode]", "[" + Configurator.MSSQLTablePrefix + "ProductItemCode]"); }
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
            if (n_sCid == null) { _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10).Value = n_sCid; }
            if (n_bActive == null) { _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = n_bActive; }
            if (n_dCdate == null) { _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = n_dCdate; }
            if (n_sHs_model == null) { _oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar, 100).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar, 100).Value = n_sHs_model; }
            if (n_sDid == null) { _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10).Value = n_sDid; }
            if (n_sType == null) { _oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar, 10).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar, 10).Value = n_sType; }
            if (n_bLast_stock == null) { _oCmd.Parameters.Add("@last_stock", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@last_stock", global::System.Data.SqlDbType.Bit).Value = n_bLast_stock; }
            if (n_sItem_code == null) { _oCmd.Parameters.Add("@item_code", global::System.Data.SqlDbType.NVarChar, 10).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@item_code", global::System.Data.SqlDbType.NVarChar, 10).Value = n_sItem_code; }
            if (n_dEdate == null) { _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = n_dEdate; }
            if (n_dDdate == null) { _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = n_dDdate; }
            if (n_iMid == null) { _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value = n_iMid; }
            if (n_dSdate == null) { _oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { _oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = n_dSdate; }
            if (n_sQuota == null) { _oCmd.Parameters.Add("@quota", global::System.Data.SqlDbType.Char, 10).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@quota", global::System.Data.SqlDbType.Char, 10).Value = n_sQuota; }
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
        /// Summary description for table [ProductItemCode] Delete Record
        /// </summary>

        public bool Delete()
        {
            if (n_iMid == null) { return false; }
            string _sQuery = "DELETE FROM  [ProductItemCode]  WHERE [ProductItemCode].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProductItemCode]", "[" + Configurator.MSSQLTablePrefix + "ProductItemCode]"); }
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
        /// Summary description for table [ProductItemCode] Object Base Clone
        /// </summary>

        public ProductItemCode DeepClone()
        {
            ProductItemCode _oProductItemCode_Clone = (ProductItemCode)ProductItemCodeRepository.CreateEntityInstanceObject();
            _oProductItemCode_Clone.cid = this.n_sCid;
            _oProductItemCode_Clone.active = this.n_bActive;
            _oProductItemCode_Clone.cdate = this.n_dCdate;
            _oProductItemCode_Clone.hs_model = this.n_sHs_model;
            _oProductItemCode_Clone.did = this.n_sDid;
            _oProductItemCode_Clone.type = this.n_sType;
            _oProductItemCode_Clone.last_stock = this.n_bLast_stock;
            _oProductItemCode_Clone.item_code = this.n_sItem_code;
            _oProductItemCode_Clone.edate = this.n_dEdate;
            _oProductItemCode_Clone.ddate = this.n_dDdate;
            _oProductItemCode_Clone.mid = this.n_iMid;
            _oProductItemCode_Clone.sdate = this.n_dSdate;
            _oProductItemCode_Clone.quota = this.n_sQuota;
            _oProductItemCode_Clone.SetFound(this.n_bFound);
            _oProductItemCode_Clone.SetDB(this.n_oDB);
            _oProductItemCode_Clone.SetRow(this.n_oRow);
            _oProductItemCode_Clone.SetTbl(this.n_oTbl);
            _oProductItemCode_Clone.SetTableSet(this.n_oTableSet);

            return _oProductItemCode_Clone;
        }
        #endregion

        #region Release

        /// <summary>
        /// Summary description for Release
        /// </summary>

        public void Release()
        {
            n_sCid = string.Empty;
            n_bActive = null;
            n_dCdate = null;
            n_sHs_model = string.Empty;
            n_sDid = string.Empty;
            n_sType = string.Empty;
            n_bLast_stock = null;
            n_sItem_code = string.Empty;
            n_dEdate = null;
            n_dDdate = null;
            n_iMid = null;
            n_dSdate = null;
            n_sQuota = string.Empty;
            n_oDB = null;
            n_bFound = false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = new ProductItemCodeInfo();
        }
        #endregion
    }
}

