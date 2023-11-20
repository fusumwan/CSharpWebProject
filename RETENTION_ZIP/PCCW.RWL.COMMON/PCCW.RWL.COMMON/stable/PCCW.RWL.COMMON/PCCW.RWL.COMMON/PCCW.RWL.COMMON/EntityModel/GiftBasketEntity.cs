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
///-- Description:	<Description,Table :[GiftBasket],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE
{

    /// <summary>
    /// Summary description for table [GiftBasket] Object Base layer
    /// </summary>

    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix + "GiftBasket")]
    public class GiftBasketEntity : global::System.IDisposable, global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>
    {


        protected string n_sGift_code = string.Empty;
        #region gift_code
        [System.Data.Linq.Mapping.Column(Name = "[gift_code]", Storage = "n_sGift_code")]
        public string gift_code
        {
            get
            {
                return this.n_sGift_code;
            }
            set
            {
                this.n_sGift_code = value;
            }
        }
        #endregion gift_code


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


        protected string n_sGift_desc = string.Empty;
        #region gift_desc
        [System.Data.Linq.Mapping.Column(Name = "[gift_desc]", Storage = "n_sGift_desc")]
        public string gift_desc
        {
            get
            {
                return this.n_sGift_desc;
            }
            set
            {
                this.n_sGift_desc = value;
            }
        }
        #endregion gift_desc


        protected string n_sGift_gp = string.Empty;
        #region gift_gp
        [System.Data.Linq.Mapping.Column(Name = "[gift_gp]", Storage = "n_sGift_gp")]
        public string gift_gp
        {
            get
            {
                return this.n_sGift_gp;
            }
            set
            {
                this.n_sGift_gp = value;
            }
        }
        #endregion gift_gp


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
        private GiftBasketInfo n_oTableSet = new GiftBasketInfo();
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        #endregion

        #region Parameter String
        public class Para
        {
            public const string active = "active";
            public const string cdate = "cdate";
            public const string cid = "cid";
            public const string gift_code = "gift_code";
            public const string sdate = "sdate";
            public const string last_stock = "last_stock";
            public const string edate = "edate";
            public const string gift_desc = "gift_desc";
            public const string gift_gp = "gift_gp";
            public const string ddate = "ddate";
            public const string mid = "mid";
            public const string did = "did";
            public const string quota = "quota";
            public const string GiftBasket_table_name = Configurator.MSSQLTablePrefix + "GiftBasket";
            public static string TableName() { return GiftBasket_table_name; }
        }
        #endregion Parameter String

        #region Constructor
        public GiftBasketEntity()
        {
            Init();
        }
        public GiftBasketEntity(MSSQLConnect x_oDB)
        {
            n_oDB = x_oDB;
            Init();
        }

        public GiftBasketEntity(MSSQLConnect x_oDB, System.Nullable<int> x_iMid)
        {
            n_oDB = x_oDB;
            this.Load(x_iMid);
            Init();
        }

        ~GiftBasketEntity()
        {
            this.Release();
        }
        #endregion

        #region Load

        public bool Load(global::System.Nullable<int> x_iMid)
        {
            if (n_oDB == null) { return false; }
            if (x_iMid == null) { return false; }
            string _sQuery = "SELECT [GiftBasket].[gift_code] AS GIFTBASKET_GIFT_CODE,[GiftBasket].[cdate] AS GIFTBASKET_CDATE,[GiftBasket].[cid] AS GIFTBASKET_CID,[GiftBasket].[active] AS GIFTBASKET_ACTIVE,[GiftBasket].[last_stock] AS GIFTBASKET_LAST_STOCK,[GiftBasket].[edate] AS GIFTBASKET_EDATE,[GiftBasket].[did] AS GIFTBASKET_DID,[GiftBasket].[gift_desc] AS GIFTBASKET_GIFT_DESC,[GiftBasket].[gift_gp] AS GIFTBASKET_GIFT_GP,[GiftBasket].[ddate] AS GIFTBASKET_DDATE,[GiftBasket].[mid] AS GIFTBASKET_MID,[GiftBasket].[sdate] AS GIFTBASKET_SDATE,[GiftBasket].[quota] AS GIFTBASKET_QUOTA  FROM  [GiftBasket]  WHERE  [GiftBasket].[mid] = \'" + x_iMid.ToString() + "\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[GiftBasket]", "[" + Configurator.MSSQLTablePrefix + "GiftBasket]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_GIFT_CODE"])) { n_sGift_code = (string)_oData["GIFTBASKET_GIFT_CODE"]; } else { n_sGift_code = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_CDATE"])) { n_dCdate = (global::System.Nullable<DateTime>)_oData["GIFTBASKET_CDATE"]; } else { n_dCdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_CID"])) { n_sCid = (string)_oData["GIFTBASKET_CID"]; } else { n_sCid = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_ACTIVE"])) { n_bActive = (global::System.Nullable<bool>)_oData["GIFTBASKET_ACTIVE"]; } else { n_bActive = null; }
                        if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_LAST_STOCK"])) { n_bLast_stock = (global::System.Nullable<bool>)_oData["GIFTBASKET_LAST_STOCK"]; } else { n_bLast_stock = null; }
                        if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_EDATE"])) { n_dEdate = (global::System.Nullable<DateTime>)_oData["GIFTBASKET_EDATE"]; } else { n_dEdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_DID"])) { n_sDid = (string)_oData["GIFTBASKET_DID"]; } else { n_sDid = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_GIFT_DESC"])) { n_sGift_desc = (string)_oData["GIFTBASKET_GIFT_DESC"]; } else { n_sGift_desc = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_GIFT_GP"])) { n_sGift_gp = (string)_oData["GIFTBASKET_GIFT_GP"]; } else { n_sGift_gp = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_DDATE"])) { n_dDdate = (global::System.Nullable<DateTime>)_oData["GIFTBASKET_DDATE"]; } else { n_dDdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_MID"])) { n_iMid = (global::System.Nullable<int>)_oData["GIFTBASKET_MID"]; } else { n_iMid = null; }
                        if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_SDATE"])) { n_dSdate = (global::System.Nullable<DateTime>)_oData["GIFTBASKET_SDATE"]; } else { n_dSdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_QUOTA"])) { n_sQuota = (string)_oData["GIFTBASKET_QUOTA"]; } else { n_sQuota = string.Empty; }
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
            if (n_sGift_code == null && !(n_oTableSet.Fields(Para.gift_code).IsNullable)) return false;
            if (n_dCdate == null && !(n_oTableSet.Fields(Para.cdate).IsNullable)) return false;
            if (n_sCid == null && !(n_oTableSet.Fields(Para.cid).IsNullable)) return false;
            if (n_bActive == null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_bLast_stock == null && !(n_oTableSet.Fields(Para.last_stock).IsNullable)) return false;
            if (n_dEdate == null && !(n_oTableSet.Fields(Para.edate).IsNullable)) return false;
            if (n_sDid == null && !(n_oTableSet.Fields(Para.did).IsNullable)) return false;
            if (n_sGift_desc == null && !(n_oTableSet.Fields(Para.gift_desc).IsNullable)) return false;
            if (n_sGift_gp == null && !(n_oTableSet.Fields(Para.gift_gp).IsNullable)) return false;
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
            if ((x_oObj is GiftBasket) || (x_oObj is GiftBasketEntity)) return GiftBasketRepository.Instance();
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
        public GiftBasketInfo GetTableSet() { return n_oTableSet; }
        #endregion GetTableSet


        #region SetTableSet
        public void SetTableSet(GiftBasketInfo value) { n_oTableSet = value; }
        #endregion SetTableSet

        public global::System.Nullable<bool> GetActive() { return this.active; }
        public global::System.Nullable<DateTime> GetCdate() { return this.cdate; }
        public string GetCid() { return this.cid; }
        public string GetGift_code() { return this.gift_code; }
        public global::System.Nullable<DateTime> GetSdate() { return this.sdate; }
        public global::System.Nullable<bool> GetLast_stock() { return this.last_stock; }
        public global::System.Nullable<DateTime> GetEdate() { return this.edate; }
        public string GetGift_desc() { return this.gift_desc; }
        public string GetGift_gp() { return this.gift_gp; }
        public global::System.Nullable<DateTime> GetDdate() { return this.ddate; }
        public global::System.Nullable<int> GetMid() { return this.mid; }
        public string GetDid() { return this.did; }
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
        public bool SetGift_code(string value)
        {
            this.gift_code = value;
            return true;
        }
        public bool SetSdate(global::System.Nullable<DateTime> value)
        {
            this.sdate = value;
            return true;
        }
        public bool SetLast_stock(global::System.Nullable<bool> value)
        {
            this.last_stock = value;
            return true;
        }
        public bool SetEdate(global::System.Nullable<DateTime> value)
        {
            this.edate = value;
            return true;
        }
        public bool SetGift_desc(string value)
        {
            this.gift_desc = value;
            return true;
        }
        public bool SetGift_gp(string value)
        {
            this.gift_gp = value;
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
        public bool SetDid(string value)
        {
            this.did = value;
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
        public Field GetGift_codeTable()
        {
            return n_oTableSet.Fields(Para.gift_code);
        }
        public Field GetSdateTable()
        {
            return n_oTableSet.Fields(Para.sdate);
        }
        public Field GetLast_stockTable()
        {
            return n_oTableSet.Fields(Para.last_stock);
        }
        public Field GetEdateTable()
        {
            return n_oTableSet.Fields(Para.edate);
        }
        public Field GetGift_descTable()
        {
            return n_oTableSet.Fields(Para.gift_desc);
        }
        public Field GetGift_gpTable()
        {
            return n_oTableSet.Fields(Para.gift_gp);
        }
        public Field GetDdateTable()
        {
            return n_oTableSet.Fields(Para.ddate);
        }
        public Field GetMidTable()
        {
            return n_oTableSet.Fields(Para.mid);
        }
        public Field GetDidTable()
        {
            return n_oTableSet.Fields(Para.did);
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

        public bool EqualID(GiftBasket x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iMid.Equals(x_oObj.mid)) && isEquals;
            return isEquals;
        }

        public bool Equals(GiftBasket x_oObj)
        {
            if (x_oObj == null) return false;
            if (!this.n_sGift_code.Equals(x_oObj.gift_code)) { return false; }
            if (!this.n_dCdate.Equals(x_oObj.cdate)) { return false; }
            if (!this.n_sCid.Equals(x_oObj.cid)) { return false; }
            if (!this.n_bActive.Equals(x_oObj.active)) { return false; }
            if (!this.n_bLast_stock.Equals(x_oObj.last_stock)) { return false; }
            if (!this.n_dEdate.Equals(x_oObj.edate)) { return false; }
            if (!this.n_sDid.Equals(x_oObj.did)) { return false; }
            if (!this.n_sGift_desc.Equals(x_oObj.gift_desc)) { return false; }
            if (!this.n_sGift_gp.Equals(x_oObj.gift_gp)) { return false; }
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
            string _sQuery = "UPDATE  [GiftBasket]  SET  [gift_code]=@gift_code,[cdate]=@cdate,[cid]=@cid,[active]=@active,[last_stock]=@last_stock,[edate]=@edate,[did]=@did,[gift_desc]=@gift_desc,[gift_gp]=@gift_gp,[ddate]=@ddate,[sdate]=@sdate,[quota]=@quota  WHERE [GiftBasket].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[GiftBasket]", "[" + Configurator.MSSQLTablePrefix + "GiftBasket]"); }
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
            if (n_sGift_code == null) { _oCmd.Parameters.Add("@gift_code", global::System.Data.SqlDbType.NVarChar, 10).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@gift_code", global::System.Data.SqlDbType.NVarChar, 10).Value = n_sGift_code; }
            if (n_dCdate == null) { _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = n_dCdate; }
            if (n_sCid == null) { _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10).Value = n_sCid; }
            if (n_bActive == null) { _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = n_bActive; }
            if (n_bLast_stock == null) { _oCmd.Parameters.Add("@last_stock", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@last_stock", global::System.Data.SqlDbType.Bit).Value = n_bLast_stock; }
            if (n_dEdate == null) { _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = n_dEdate; }
            if (n_sDid == null) { _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10).Value = n_sDid; }
            if (n_sGift_desc == null) { _oCmd.Parameters.Add("@gift_desc", global::System.Data.SqlDbType.NVarChar, 50).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@gift_desc", global::System.Data.SqlDbType.NVarChar, 50).Value = n_sGift_desc; }
            if (n_sGift_gp == null) { _oCmd.Parameters.Add("@gift_gp", global::System.Data.SqlDbType.NVarChar, 20).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@gift_gp", global::System.Data.SqlDbType.NVarChar, 20).Value = n_sGift_gp; }
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
        /// Summary description for table [GiftBasket] Delete Record
        /// </summary>

        public bool Delete()
        {
            if (n_iMid == null) { return false; }
            string _sQuery = "DELETE FROM  [GiftBasket]  WHERE [GiftBasket].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[GiftBasket]", "[" + Configurator.MSSQLTablePrefix + "GiftBasket]"); }
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
        /// Summary description for table [GiftBasket] Object Base Clone
        /// </summary>

        public GiftBasket DeepClone()
        {
            GiftBasket _oGiftBasket_Clone = (GiftBasket)GiftBasketRepository.CreateEntityInstanceObject();
            _oGiftBasket_Clone.gift_code = this.n_sGift_code;
            _oGiftBasket_Clone.cdate = this.n_dCdate;
            _oGiftBasket_Clone.cid = this.n_sCid;
            _oGiftBasket_Clone.active = this.n_bActive;
            _oGiftBasket_Clone.last_stock = this.n_bLast_stock;
            _oGiftBasket_Clone.edate = this.n_dEdate;
            _oGiftBasket_Clone.did = this.n_sDid;
            _oGiftBasket_Clone.gift_desc = this.n_sGift_desc;
            _oGiftBasket_Clone.gift_gp = this.n_sGift_gp;
            _oGiftBasket_Clone.ddate = this.n_dDdate;
            _oGiftBasket_Clone.mid = this.n_iMid;
            _oGiftBasket_Clone.sdate = this.n_dSdate;
            _oGiftBasket_Clone.quota = this.n_sQuota;
            _oGiftBasket_Clone.SetFound(this.n_bFound);
            _oGiftBasket_Clone.SetDB(this.n_oDB);
            _oGiftBasket_Clone.SetRow(this.n_oRow);
            _oGiftBasket_Clone.SetTbl(this.n_oTbl);
            _oGiftBasket_Clone.SetTableSet(this.n_oTableSet);

            return _oGiftBasket_Clone;
        }
        #endregion

        #region Release

        /// <summary>
        /// Summary description for Release
        /// </summary>

        public void Release()
        {
            n_sGift_code = string.Empty;
            n_dCdate = null;
            n_sCid = string.Empty;
            n_bActive = null;
            n_bLast_stock = null;
            n_dEdate = null;
            n_sDid = string.Empty;
            n_sGift_desc = string.Empty;
            n_sGift_gp = string.Empty;
            n_dDdate = null;
            n_iMid = null;
            n_dSdate = null;
            n_sQuota = string.Empty;
            n_oDB = null;
            n_bFound = false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = new GiftBasketInfo();
        }
        #endregion
    }
}

