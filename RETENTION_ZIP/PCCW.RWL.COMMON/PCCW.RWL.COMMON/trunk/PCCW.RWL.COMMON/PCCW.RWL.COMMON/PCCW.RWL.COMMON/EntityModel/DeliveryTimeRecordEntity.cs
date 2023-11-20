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
///-- Create date: <Create Date 2009-12-21>
///-- Description:	<Description,Table :[DeliveryTimeRecord],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE
{

    /// <summary>
    /// Summary description for table [DeliveryTimeRecord] Object Base layer
    /// </summary>

    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix + "DeliveryTimeRecord")]
    public class DeliveryTimeRecordEntity : global::System.IDisposable, global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>
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


        protected global::System.Nullable<bool> n_bPm8_10 = null;
        #region pm8_10
        [System.Data.Linq.Mapping.Column(Name = "[pm8_10]", Storage = "n_bPm8_10")]
        public global::System.Nullable<bool> pm8_10
        {
            get
            {
                return this.n_bPm8_10;
            }
            set
            {
                this.n_bPm8_10 = value;
            }
        }
        #endregion pm8_10


        protected string n_sLocation = global::System.String.Empty;
        #region location
        [System.Data.Linq.Mapping.Column(Name = "[location]", Storage = "n_sLocation")]
        public string location
        {
            get
            {
                return this.n_sLocation;
            }
            set
            {
                this.n_sLocation = value;
            }
        }
        #endregion location


        protected global::System.Nullable<bool> n_bPm7_9 = null;
        #region pm7_9
        [System.Data.Linq.Mapping.Column(Name = "[pm7_9]", Storage = "n_bPm7_9")]
        public global::System.Nullable<bool> pm7_9
        {
            get
            {
                return this.n_bPm7_9;
            }
            set
            {
                this.n_bPm7_9 = value;
            }
        }
        #endregion pm7_9


        protected string n_sArea = global::System.String.Empty;
        #region area
        [System.Data.Linq.Mapping.Column(Name = "[area]", Storage = "n_sArea")]
        public string area
        {
            get
            {
                return this.n_sArea;
            }
            set
            {
                this.n_sArea = value;
            }
        }
        #endregion area


        protected global::System.Nullable<bool> n_bPm6_8 = null;
        #region pm6_8
        [System.Data.Linq.Mapping.Column(Name = "[pm6_8]", Storage = "n_bPm6_8")]
        public global::System.Nullable<bool> pm6_8
        {
            get
            {
                return this.n_bPm6_8;
            }
            set
            {
                this.n_bPm6_8 = value;
            }
        }
        #endregion pm6_8


        protected global::System.Nullable<bool> n_bAm = null;
        #region am
        [System.Data.Linq.Mapping.Column(Name = "[am]", Storage = "n_bAm")]
        public global::System.Nullable<bool> am
        {
            get
            {
                return this.n_bAm;
            }
            set
            {
                this.n_bAm = value;
            }
        }
        #endregion am


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


        protected global::System.Nullable<bool> n_bPm = null;
        #region pm
        [System.Data.Linq.Mapping.Column(Name = "[pm]", Storage = "n_bPm")]
        public global::System.Nullable<bool> pm
        {
            get
            {
                return this.n_bPm;
            }
            set
            {
                this.n_bPm = value;
            }
        }
        #endregion pm


        protected global::System.Nullable<int> n_iDelivery_fee = null;
        #region delivery_fee
        [System.Data.Linq.Mapping.Column(Name = "[delivery_fee]", Storage = "n_iDelivery_fee")]
        public global::System.Nullable<int> delivery_fee
        {
            get
            {
                return this.n_iDelivery_fee;
            }
            set
            {
                this.n_iDelivery_fee = value;
            }
        }
        #endregion delivery_fee

        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound = false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private DeliveryTimeRecordInfo n_oTableSet = DeliveryTimeRecordInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        #endregion

        #region Parameter String
        public class Para
        {
            public const string id = "id";
            public const string cdate = "cdate";
            public const string cid = "cid";
            public const string active = "active";
            public const string pm8_10 = "pm8_10";
            public const string location = "location";
            public const string pm7_9 = "pm7_9";
            public const string area = "area";
            public const string pm6_8 = "pm6_8";
            public const string pm = "pm";
            public const string am = "am";
            public const string ddate = "ddate";
            public const string did = "did";
            public const string delivery_fee = "delivery_fee";
            public const string DeliveryTimeRecord_table_name = "DeliveryTimeRecord";
            public static string TableName() { return DeliveryTimeRecord_table_name; }
        }
        #endregion Parameter String

        #region Constructor
        public DeliveryTimeRecordEntity()
        {
            Init();
        }
        public DeliveryTimeRecordEntity(MSSQLConnect x_oDB)
        {
            n_oDB = x_oDB;
            Init();
        }

        public DeliveryTimeRecordEntity(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            n_oDB = x_oDB;
            this.Load(x_iId);
            Init();
        }

        ~DeliveryTimeRecordEntity()
        {
            this.Release();
        }
        #endregion

        #region Load

        public bool Load(global::System.Nullable<int> x_iId)
        {
            if (n_oDB == null) { return false; }
            if (x_iId == null) { return false; }
            string _sQuery = "SELECT   [DeliveryTimeRecord].[id] AS DELIVERYTIMERECORD_ID,[DeliveryTimeRecord].[cdate] AS DELIVERYTIMERECORD_CDATE,[DeliveryTimeRecord].[cid] AS DELIVERYTIMERECORD_CID,[DeliveryTimeRecord].[active] AS DELIVERYTIMERECORD_ACTIVE,[DeliveryTimeRecord].[pm8_10] AS DELIVERYTIMERECORD_PM8_10,[DeliveryTimeRecord].[location] AS DELIVERYTIMERECORD_LOCATION,[DeliveryTimeRecord].[pm7_9] AS DELIVERYTIMERECORD_PM7_9,[DeliveryTimeRecord].[area] AS DELIVERYTIMERECORD_AREA,[DeliveryTimeRecord].[pm6_8] AS DELIVERYTIMERECORD_PM6_8,[DeliveryTimeRecord].[am] AS DELIVERYTIMERECORD_AM,[DeliveryTimeRecord].[did] AS DELIVERYTIMERECORD_DID,[DeliveryTimeRecord].[ddate] AS DELIVERYTIMERECORD_DDATE,[DeliveryTimeRecord].[pm] AS DELIVERYTIMERECORD_PM,[DeliveryTimeRecord].[delivery_fee] AS DELIVERYTIMERECORD_DELIVERY_FEE  FROM  [DeliveryTimeRecord]  WHERE  [DeliveryTimeRecord].[id] = \'" + x_iId.ToString() + "\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DeliveryTimeRecord]", "[" + Configurator.MSSQLTablePrefix + "DeliveryTimeRecord]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_ID"])) { n_iId = (global::System.Nullable<int>)_oData["DELIVERYTIMERECORD_ID"]; } else { n_iId = null; }
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_CDATE"])) { n_dCdate = (global::System.Nullable<DateTime>)_oData["DELIVERYTIMERECORD_CDATE"]; } else { n_dCdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_CID"])) { n_sCid = (string)_oData["DELIVERYTIMERECORD_CID"]; } else { n_sCid = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_ACTIVE"])) { n_bActive = (global::System.Nullable<bool>)_oData["DELIVERYTIMERECORD_ACTIVE"]; } else { n_bActive = null; }
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_PM8_10"])) { n_bPm8_10 = (global::System.Nullable<bool>)_oData["DELIVERYTIMERECORD_PM8_10"]; } else { n_bPm8_10 = null; }
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_LOCATION"])) { n_sLocation = (string)_oData["DELIVERYTIMERECORD_LOCATION"]; } else { n_sLocation = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_PM7_9"])) { n_bPm7_9 = (global::System.Nullable<bool>)_oData["DELIVERYTIMERECORD_PM7_9"]; } else { n_bPm7_9 = null; }
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_AREA"])) { n_sArea = (string)_oData["DELIVERYTIMERECORD_AREA"]; } else { n_sArea = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_PM6_8"])) { n_bPm6_8 = (global::System.Nullable<bool>)_oData["DELIVERYTIMERECORD_PM6_8"]; } else { n_bPm6_8 = null; }
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_AM"])) { n_bAm = (global::System.Nullable<bool>)_oData["DELIVERYTIMERECORD_AM"]; } else { n_bAm = null; }
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_DID"])) { n_sDid = (string)_oData["DELIVERYTIMERECORD_DID"]; } else { n_sDid = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_DDATE"])) { n_dDdate = (global::System.Nullable<DateTime>)_oData["DELIVERYTIMERECORD_DDATE"]; } else { n_dDdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_PM"])) { n_bPm = (global::System.Nullable<bool>)_oData["DELIVERYTIMERECORD_PM"]; } else { n_bPm = null; }
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_DELIVERY_FEE"])) { n_iDelivery_fee = (global::System.Nullable<int>)_oData["DELIVERYTIMERECORD_DELIVERY_FEE"]; } else { n_iDelivery_fee = null; }
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
            if (n_bPm8_10 == null && !(n_oTableSet.Fields(Para.pm8_10).IsNullable)) return false;
            if (n_sLocation == null && !(n_oTableSet.Fields(Para.location).IsNullable)) return false;
            if (n_bPm7_9 == null && !(n_oTableSet.Fields(Para.pm7_9).IsNullable)) return false;
            if (n_sArea == null && !(n_oTableSet.Fields(Para.area).IsNullable)) return false;
            if (n_bPm6_8 == null && !(n_oTableSet.Fields(Para.pm6_8).IsNullable)) return false;
            if (n_bAm == null && !(n_oTableSet.Fields(Para.am).IsNullable)) return false;
            if (n_sDid == null && !(n_oTableSet.Fields(Para.did).IsNullable)) return false;
            if (n_dDdate == null && !(n_oTableSet.Fields(Para.ddate).IsNullable)) return false;
            if (n_bPm == null && !(n_oTableSet.Fields(Para.pm).IsNullable)) return false;
            if (n_iDelivery_fee == null && !(n_oTableSet.Fields(Para.delivery_fee).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(DeliveryTimeRecordEntity)) || (x_oObj is DeliveryTimeRecordEntity)) return DeliveryTimeRecordRepository.Instance();
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
        public DeliveryTimeRecordInfo GetTableSet() { return n_oTableSet; }
        #endregion GetTableSet


        #region SetTableSet
        public void SetTableSet(DeliveryTimeRecordInfo value) { n_oTableSet = value; }
        #endregion SetTableSet

        public global::System.Nullable<int> GetId() { return this.id; }
        public global::System.Nullable<DateTime> GetCdate() { return this.cdate; }
        public string GetCid() { return this.cid; }
        public global::System.Nullable<bool> GetActive() { return this.active; }
        public global::System.Nullable<bool> GetPm8_10() { return this.pm8_10; }
        public string GetLocation() { return this.location; }
        public global::System.Nullable<bool> GetPm7_9() { return this.pm7_9; }
        public string GetArea() { return this.area; }
        public global::System.Nullable<bool> GetPm6_8() { return this.pm6_8; }
        public global::System.Nullable<bool> GetPm() { return this.pm; }
        public global::System.Nullable<bool> GetAm() { return this.am; }
        public global::System.Nullable<DateTime> GetDdate() { return this.ddate; }
        public string GetDid() { return this.did; }
        public global::System.Nullable<int> GetDelivery_fee() { return this.delivery_fee; }

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
        public bool SetPm8_10(global::System.Nullable<bool> value)
        {
            this.pm8_10 = value;
            return true;
        }
        public bool SetLocation(string value)
        {
            this.location = value;
            return true;
        }
        public bool SetPm7_9(global::System.Nullable<bool> value)
        {
            this.pm7_9 = value;
            return true;
        }
        public bool SetArea(string value)
        {
            this.area = value;
            return true;
        }
        public bool SetPm6_8(global::System.Nullable<bool> value)
        {
            this.pm6_8 = value;
            return true;
        }
        public bool SetPm(global::System.Nullable<bool> value)
        {
            this.pm = value;
            return true;
        }
        public bool SetAm(global::System.Nullable<bool> value)
        {
            this.am = value;
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
        public bool SetDelivery_fee(global::System.Nullable<int> value)
        {
            this.delivery_fee = value;
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
        public Field GetPm8_10Table()
        {
            return n_oTableSet.Fields(Para.pm8_10);
        }
        public Field GetLocationTable()
        {
            return n_oTableSet.Fields(Para.location);
        }
        public Field GetPm7_9Table()
        {
            return n_oTableSet.Fields(Para.pm7_9);
        }
        public Field GetAreaTable()
        {
            return n_oTableSet.Fields(Para.area);
        }
        public Field GetPm6_8Table()
        {
            return n_oTableSet.Fields(Para.pm6_8);
        }
        public Field GetPmTable()
        {
            return n_oTableSet.Fields(Para.pm);
        }
        public Field GetAmTable()
        {
            return n_oTableSet.Fields(Para.am);
        }
        public Field GetDdateTable()
        {
            return n_oTableSet.Fields(Para.ddate);
        }
        public Field GetDidTable()
        {
            return n_oTableSet.Fields(Para.did);
        }
        public Field GetDelivery_feeTable()
        {
            return n_oTableSet.Fields(Para.delivery_fee);
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

        public bool EqualID(DeliveryTimeRecord x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }

        public bool Equals(DeliveryTimeRecord x_oObj)
        {
            if (x_oObj == null) return false;
            if (!this.n_iId.Equals(x_oObj.id)) { return false; }
            if (!this.n_dCdate.Equals(x_oObj.cdate)) { return false; }
            if (!this.n_sCid.Equals(x_oObj.cid)) { return false; }
            if (!this.n_bActive.Equals(x_oObj.active)) { return false; }
            if (!this.n_bPm8_10.Equals(x_oObj.pm8_10)) { return false; }
            if (!this.n_sLocation.Equals(x_oObj.location)) { return false; }
            if (!this.n_bPm7_9.Equals(x_oObj.pm7_9)) { return false; }
            if (!this.n_sArea.Equals(x_oObj.area)) { return false; }
            if (!this.n_bPm6_8.Equals(x_oObj.pm6_8)) { return false; }
            if (!this.n_bAm.Equals(x_oObj.am)) { return false; }
            if (!this.n_sDid.Equals(x_oObj.did)) { return false; }
            if (!this.n_dDdate.Equals(x_oObj.ddate)) { return false; }
            if (!this.n_bPm.Equals(x_oObj.pm)) { return false; }
            if (!this.n_iDelivery_fee.Equals(x_oObj.delivery_fee)) { return false; }
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
            string _sQuery = "UPDATE  [DeliveryTimeRecord]  SET  [cdate]=@cdate,[cid]=@cid,[active]=@active,[pm8_10]=@pm8_10,[location]=@location,[pm7_9]=@pm7_9,[area]=@area,[pm6_8]=@pm6_8,[am]=@am,[did]=@did,[ddate]=@ddate,[pm]=@pm,[delivery_fee]=@delivery_fee  WHERE [DeliveryTimeRecord].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DeliveryTimeRecord]", "[" + Configurator.MSSQLTablePrefix + "DeliveryTimeRecord]"); }
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
            if (n_bActive == null) { _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = n_bActive; }
            if (n_bPm8_10 == null) { _oCmd.Parameters.Add("@pm8_10", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { _oCmd.Parameters.Add("@pm8_10", global::System.Data.SqlDbType.Bit).Value = n_bPm8_10; }
            if (n_sLocation == null) { _oCmd.Parameters.Add("@location", global::System.Data.SqlDbType.NVarChar, 100).Value = DBNull.Value; } else { _oCmd.Parameters.Add("@location", global::System.Data.SqlDbType.NVarChar, 100).Value = n_sLocation; }
            if (n_bPm7_9 == null) { _oCmd.Parameters.Add("@pm7_9", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { _oCmd.Parameters.Add("@pm7_9", global::System.Data.SqlDbType.Bit).Value = n_bPm7_9; }
            if (n_sArea == null) { _oCmd.Parameters.Add("@area", global::System.Data.SqlDbType.NVarChar, 100).Value = DBNull.Value; } else { _oCmd.Parameters.Add("@area", global::System.Data.SqlDbType.NVarChar, 100).Value = n_sArea; }
            if (n_bPm6_8 == null) { _oCmd.Parameters.Add("@pm6_8", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { _oCmd.Parameters.Add("@pm6_8", global::System.Data.SqlDbType.Bit).Value = n_bPm6_8; }
            if (n_bAm == null) { _oCmd.Parameters.Add("@am", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { _oCmd.Parameters.Add("@am", global::System.Data.SqlDbType.Bit).Value = n_bAm; }
            if (n_sDid == null) { _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar, 50).Value = DBNull.Value; } else { _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar, 50).Value = n_sDid; }
            if (n_dDdate == null) { _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = n_dDdate; }
            if (n_bPm == null) { _oCmd.Parameters.Add("@pm", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { _oCmd.Parameters.Add("@pm", global::System.Data.SqlDbType.Bit).Value = n_bPm; }
            if (n_iDelivery_fee == null) { _oCmd.Parameters.Add("@delivery_fee", global::System.Data.SqlDbType.Int).Value = DBNull.Value; } else { _oCmd.Parameters.Add("@delivery_fee", global::System.Data.SqlDbType.Int).Value = n_iDelivery_fee; }
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
        /// Summary description for table [DeliveryTimeRecord] Delete Record
        /// </summary>

        public bool Delete()
        {
            if (n_iId == null) { return false; }
            string _sQuery = "DELETE FROM  [DeliveryTimeRecord]  WHERE [DeliveryTimeRecord].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DeliveryTimeRecord]", "[" + Configurator.MSSQLTablePrefix + "DeliveryTimeRecord]"); }
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
        /// Summary description for table [DeliveryTimeRecord] Object Base Clone
        /// </summary>

        public DeliveryTimeRecord DeepClone()
        {
            DeliveryTimeRecord _oDeliveryTimeRecord_Clone = new DeliveryTimeRecord();
            _oDeliveryTimeRecord_Clone.id = this.n_iId;
            _oDeliveryTimeRecord_Clone.cdate = this.n_dCdate;
            _oDeliveryTimeRecord_Clone.cid = this.n_sCid;
            _oDeliveryTimeRecord_Clone.active = this.n_bActive;
            _oDeliveryTimeRecord_Clone.pm8_10 = this.n_bPm8_10;
            _oDeliveryTimeRecord_Clone.location = this.n_sLocation;
            _oDeliveryTimeRecord_Clone.pm7_9 = this.n_bPm7_9;
            _oDeliveryTimeRecord_Clone.area = this.n_sArea;
            _oDeliveryTimeRecord_Clone.pm6_8 = this.n_bPm6_8;
            _oDeliveryTimeRecord_Clone.am = this.n_bAm;
            _oDeliveryTimeRecord_Clone.did = this.n_sDid;
            _oDeliveryTimeRecord_Clone.ddate = this.n_dDdate;
            _oDeliveryTimeRecord_Clone.pm = this.n_bPm;
            _oDeliveryTimeRecord_Clone.delivery_fee = this.n_iDelivery_fee;
            _oDeliveryTimeRecord_Clone.SetFound(this.n_bFound);
            _oDeliveryTimeRecord_Clone.SetDB(this.n_oDB);
            _oDeliveryTimeRecord_Clone.SetRow(this.n_oRow);
            _oDeliveryTimeRecord_Clone.SetTbl(this.n_oTbl);
            _oDeliveryTimeRecord_Clone.SetTableSet(this.n_oTableSet);

            return _oDeliveryTimeRecord_Clone;
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
            n_bActive = null;
            n_bPm8_10 = null;
            n_sLocation = global::System.String.Empty;
            n_bPm7_9 = null;
            n_sArea = global::System.String.Empty;
            n_bPm6_8 = null;
            n_bAm = null;
            n_sDid = global::System.String.Empty;
            n_dDdate = null;
            n_bPm = null;
            n_iDelivery_fee = null;
            n_oDB = null;
            n_bFound = false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = DeliveryTimeRecordInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}

