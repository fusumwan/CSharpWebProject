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
///-- Description:	<Description,Table :[AutoSelectionProperty],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    /// <summary>
    /// Summary description for table [AutoSelectionProperty] Object Base layer
    /// </summary>

    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix + "AutoSelectionProperty")]
    public class AutoSelectionPropertyEntity : global::System.IDisposable, global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>
    {
        private BusinessTrade n_oBusinessTradeAutoSelectionProperty = null;
        #region BusinessTradeAutoSelectionProperty    Get Table By Primary Key
        public BusinessTrade BusinessTradeAutoSelectionProperty
        {
            get
            {
                if (n_oBusinessTradeAutoSelectionProperty == null)
                {
                    if (n_iTradefield_mid == null)
                    {
                        n_oBusinessTradeAutoSelectionProperty = (BusinessTrade)BusinessTradeRepository.CreateEntityInstanceObject();
                        return n_oBusinessTradeAutoSelectionProperty;
                    }
                    n_oBusinessTradeAutoSelectionProperty = (BusinessTrade)BusinessTradeRepository.GetObj(this.n_oDB, this.n_iTradefield_mid);
                    if (n_oBusinessTradeAutoSelectionProperty == null)
                    {
                        n_oBusinessTradeAutoSelectionProperty = new BusinessTrade(this.n_oDB);
                        n_oBusinessTradeAutoSelectionProperty.SetMid(this.n_iTradefield_mid);
                    }
                }
                else if (n_oBusinessTradeAutoSelectionProperty.mid != this.n_iTradefield_mid)
                {
                    n_oBusinessTradeAutoSelectionProperty = (BusinessTrade)BusinessTradeRepository.GetObj(this.n_oDB, this.n_iTradefield_mid);
                    if (n_oBusinessTradeAutoSelectionProperty == null)
                    {
                        n_oBusinessTradeAutoSelectionProperty = new BusinessTrade(this.n_oDB);
                        n_oBusinessTradeAutoSelectionProperty.SetMid(this.n_iTradefield_mid);
                    }
                }
                return n_oBusinessTradeAutoSelectionProperty;
            }
            set
            {
                if (value == null)
                {
                    n_oBusinessTradeAutoSelectionProperty = new BusinessTrade(this.n_oDB);
                }
                else
                {
                    this.n_oBusinessTradeAutoSelectionProperty = value;
                }
                n_oBusinessTradeAutoSelectionProperty.SetMid(this.n_iTradefield_mid);
            }
        }

        private global::System.Data.DataSet n_oBusinessTradeAutoSelectionPropertyDataSet = null;
        #region BusinessTradeAutoSelectionPropertyDataSet    Primary Key Table DataSet
        public global::System.Data.DataSet BusinessTradeAutoSelectionPropertyDataSet
        {
            get
            {
                BusinessTradeBal _oBusinessTradeBal = new BusinessTradeBal();
                bool _bGetDataSet = false;
                if (n_oBusinessTradeAutoSelectionPropertyDataSet == null)
                {
                    if (n_iTradefield_mid == null)
                    {
                        n_oBusinessTradeAutoSelectionPropertyDataSet = BusinessTradeBal.ToEmptyDataSet();
                        return n_oBusinessTradeAutoSelectionPropertyDataSet;
                    }
                    _bGetDataSet = true;
                }
                if (n_oBusinessTradeAutoSelectionPropertyDataSet != null)
                {
                    if (n_oBusinessTradeAutoSelectionPropertyDataSet.Tables.Contains(BusinessTrade.Para.TableName()))
                    {
                        if (n_oBusinessTradeAutoSelectionPropertyDataSet.Tables[BusinessTrade.Para.TableName()].Rows.Count == 0) { _bGetDataSet = true; }
                    }
                }
                if (_bGetDataSet)
                {
                    n_oBusinessTradeAutoSelectionPropertyDataSet = BusinessTradeRepository.GetDataSet(n_oDB, "tradefield_mid=" + n_iTradefield_mid);
                    if (n_oBusinessTradeAutoSelectionPropertyDataSet == null)
                    {
                        n_oBusinessTradeAutoSelectionPropertyDataSet = BusinessTradeBal.ToEmptyDataSet();
                    }
                }
                return n_oBusinessTradeAutoSelectionPropertyDataSet;
            }
            set
            {
                n_oBusinessTradeAutoSelectionPropertyDataSet = value;
            }
        }

        #endregion BusinessTradeAutoSelectionPropertyDataSet
        #endregion BusinessTradeAutoSelectionProperty

        protected string n_sRemarks = string.Empty;
        #region remarks
        [System.Data.Linq.Mapping.Column(Name = "[remarks]", Storage = "n_sRemarks")]
        public string remarks
        {
            get
            {
                return this.n_sRemarks;
            }
            set
            {
                this.n_sRemarks = value;
            }
        }
        #endregion remarks


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


        protected string n_sPeriod = string.Empty;
        #region period
        [System.Data.Linq.Mapping.Column(Name = "[period]", Storage = "n_sPeriod")]
        public string period
        {
            get
            {
                return this.n_sPeriod;
            }
            set
            {
                this.n_sPeriod = value;
            }
        }
        #endregion period


        protected global::System.Nullable<DateTime> n_dStart_date = null;
        #region start_date
        [System.Data.Linq.Mapping.Column(Name = "[start_date]", Storage = "n_dStart_date")]
        public global::System.Nullable<DateTime> start_date
        {
            get
            {
                return this.n_dStart_date;
            }
            set
            {
                this.n_dStart_date = value;
            }
        }
        #endregion start_date


        protected string n_sObprogram = string.Empty;
        #region obprogram
        [System.Data.Linq.Mapping.Column(Name = "[obprogram]", Storage = "n_sObprogram")]
        public string obprogram
        {
            get
            {
                return this.n_sObprogram;
            }
            set
            {
                this.n_sObprogram = value;
            }
        }
        #endregion obprogram


        protected string n_sChannel = string.Empty;
        #region channel
        [System.Data.Linq.Mapping.Column(Name = "[channel]", Storage = "n_sChannel")]
        public string channel
        {
            get
            {
                return this.n_sChannel;
            }
            set
            {
                this.n_sChannel = value;
            }
        }
        #endregion channel


        protected string n_sTier = string.Empty;
        #region tier
        [System.Data.Linq.Mapping.Column(Name = "[tier]", Storage = "n_sTier")]
        public string tier
        {
            get
            {
                return this.n_sTier;
            }
            set
            {
                this.n_sTier = value;
            }
        }
        #endregion tier


        protected global::System.Nullable<int> n_iTradefield_mid = null;
        #region tradefield_mid
        [System.Data.Linq.Mapping.Column(Name = "[tradefield_mid]", Storage = "n_iTradefield_mid")]
        public global::System.Nullable<int> tradefield_mid
        {
            get
            {
                return this.n_iTradefield_mid;
            }
            set
            {
                this.n_iTradefield_mid = value;
            }
        }
        #endregion tradefield_mid



        protected string n_sUid = string.Empty;
        #region uid
        [System.Data.Linq.Mapping.Column(Name = "[uid]", Storage = "n_sUid")]
        public string uid
        {
            get
            {
                return this.n_sUid;
            }
            set
            {
                this.n_sUid = value;
            }
        }
        #endregion uid


        protected string n_sPlan_fee = string.Empty;
        #region plan_fee
        [System.Data.Linq.Mapping.Column(Name = "[plan_fee]", Storage = "n_sPlan_fee")]
        public string plan_fee
        {
            get
            {
                return this.n_sPlan_fee;
            }
            set
            {
                this.n_sPlan_fee = value;
            }
        }
        #endregion plan_fee


        protected global::System.Nullable<DateTime> n_dEnd_date = null;
        #region end_date
        [System.Data.Linq.Mapping.Column(Name = "[end_date]", Storage = "n_dEnd_date")]
        public global::System.Nullable<DateTime> end_date
        {
            get
            {
                return this.n_dEnd_date;
            }
            set
            {
                this.n_dEnd_date = value;
            }
        }
        #endregion end_date


        protected global::System.Nullable<DateTime> n_dPo_date = null;
        #region po_date
        [System.Data.Linq.Mapping.Column(Name = "[po_date]", Storage = "n_dPo_date")]
        public global::System.Nullable<DateTime> po_date
        {
            get
            {
                return this.n_dPo_date;
            }
            set
            {
                this.n_dPo_date = value;
            }
        }
        #endregion po_date

        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound = false;
        private global::System.Data.DataTable n_oTbl = null;
        private global::System.Data.DataRow n_oRow = null;
        private AutoSelectionPropertyInfo n_oTableSet = new AutoSelectionPropertyInfo();
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        #endregion

        #region Parameter String
        public class Para
        {
            public const string id = "id";
            public const string period = "period";
            public const string start_date = "start_date";
            public const string obprogram = "obprogram";
            public const string channel = "channel";
            public const string tier = "tier";
            public const string tradefield_mid = "tradefield_mid";
            public const string uid = "uid";
            public const string end_date = "end_date";
            public const string plan_fee = "plan_fee";
            public const string remarks = "remarks";
            public const string po_date = "po_date";
            public const string AutoSelectionProperty_table_name = Configurator.MSSQLTablePrefix + "AutoSelectionProperty";
            public static string TableName() { return AutoSelectionProperty_table_name; }
        }
        #endregion Parameter String

        #region Constructor
        public AutoSelectionPropertyEntity(){
            Init();
        }
        public AutoSelectionPropertyEntity(MSSQLConnect x_oDB){
            n_oDB = x_oDB;
            Init();
        }

        public AutoSelectionPropertyEntity(MSSQLConnect x_oDB, System.Nullable<int> x_iId){
            n_oDB = x_oDB;
            this.Load(x_iId);
            Init();
        }

        ~AutoSelectionPropertyEntity(){
            this.Release();
        }
        #endregion

        #region Load

        public bool Load(global::System.Nullable<int> x_iId)
        {
            if (n_oDB == null) { return false; }
            if (x_iId == null) { return false; }
            string _sQuery = "SELECT [AutoSelectionProperty].[remarks] AS AUTOSELECTIONPROPERTY_REMARKS,[AutoSelectionProperty].[id] AS AUTOSELECTIONPROPERTY_ID,[AutoSelectionProperty].[period] AS AUTOSELECTIONPROPERTY_PERIOD,[AutoSelectionProperty].[start_date] AS AUTOSELECTIONPROPERTY_START_DATE,[AutoSelectionProperty].[obprogram] AS AUTOSELECTIONPROPERTY_OBPROGRAM,[AutoSelectionProperty].[channel] AS AUTOSELECTIONPROPERTY_CHANNEL,[AutoSelectionProperty].[tier] AS AUTOSELECTIONPROPERTY_TIER,[AutoSelectionProperty].[tradefield_mid] AS AUTOSELECTIONPROPERTY_TRADEFIELD_MID,[AutoSelectionProperty].[uid] AS AUTOSELECTIONPROPERTY_UID,[AutoSelectionProperty].[plan_fee] AS AUTOSELECTIONPROPERTY_PLAN_FEE,[AutoSelectionProperty].[end_date] AS AUTOSELECTIONPROPERTY_END_DATE,[AutoSelectionProperty].[po_date] AS AUTOSELECTIONPROPERTY_PO_DATE  FROM  [AutoSelectionProperty]  WHERE  [AutoSelectionProperty].[id] = \'" + x_iId.ToString() + "\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[AutoSelectionProperty]", "[" + Configurator.MSSQLTablePrefix + "AutoSelectionProperty]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_REMARKS"])) { n_sRemarks = (string)_oData["AUTOSELECTIONPROPERTY_REMARKS"]; } else { n_sRemarks = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_ID"])) { n_iId = (global::System.Nullable<int>)_oData["AUTOSELECTIONPROPERTY_ID"]; } else { n_iId = null; }
                        if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_PERIOD"])) { n_sPeriod = (string)_oData["AUTOSELECTIONPROPERTY_PERIOD"]; } else { n_sPeriod = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_START_DATE"])) { n_dStart_date = (global::System.Nullable<DateTime>)_oData["AUTOSELECTIONPROPERTY_START_DATE"]; } else { n_dStart_date = null; }
                        if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_OBPROGRAM"])) { n_sObprogram = (string)_oData["AUTOSELECTIONPROPERTY_OBPROGRAM"]; } else { n_sObprogram = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_CHANNEL"])) { n_sChannel = (string)_oData["AUTOSELECTIONPROPERTY_CHANNEL"]; } else { n_sChannel = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_TIER"])) { n_sTier = (string)_oData["AUTOSELECTIONPROPERTY_TIER"]; } else { n_sTier = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_TRADEFIELD_MID"])) { n_iTradefield_mid = (global::System.Nullable<int>)_oData["AUTOSELECTIONPROPERTY_TRADEFIELD_MID"]; } else { n_iTradefield_mid = null; }
                        if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_UID"])) { n_sUid = (string)_oData["AUTOSELECTIONPROPERTY_UID"]; } else { n_sUid = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_PLAN_FEE"])) { n_sPlan_fee = (string)_oData["AUTOSELECTIONPROPERTY_PLAN_FEE"]; } else { n_sPlan_fee = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_END_DATE"])) { n_dEnd_date = (global::System.Nullable<DateTime>)_oData["AUTOSELECTIONPROPERTY_END_DATE"]; } else { n_dEnd_date = null; }
                        if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_PO_DATE"])) { n_dPo_date = (global::System.Nullable<DateTime>)_oData["AUTOSELECTIONPROPERTY_PO_DATE"]; } else { n_dPo_date = null; }
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
            if (n_sRemarks == null && !(n_oTableSet.Fields(Para.remarks).IsNullable)) return false;
            if (!x_bInsert)
            {
                if (n_iId == null && !(n_oTableSet.Fields(Para.id).IsNullable)) return false;
            }
            if (n_sPeriod == null && !(n_oTableSet.Fields(Para.period).IsNullable)) return false;
            if (n_dStart_date == null && !(n_oTableSet.Fields(Para.start_date).IsNullable)) return false;
            if (n_sObprogram == null && !(n_oTableSet.Fields(Para.obprogram).IsNullable)) return false;
            if (n_sChannel == null && !(n_oTableSet.Fields(Para.channel).IsNullable)) return false;
            if (n_sTier == null && !(n_oTableSet.Fields(Para.tier).IsNullable)) return false;
            if (n_iTradefield_mid == null && !(n_oTableSet.Fields(Para.tradefield_mid).IsNullable)) return false;
            if (n_sUid == null && !(n_oTableSet.Fields(Para.uid).IsNullable)) return false;
            if (n_sPlan_fee == null && !(n_oTableSet.Fields(Para.plan_fee).IsNullable)) return false;
            if (n_dEnd_date == null && !(n_oTableSet.Fields(Para.end_date).IsNullable)) return false;
            if (n_dPo_date == null && !(n_oTableSet.Fields(Para.po_date).IsNullable)) return false;
            return true;
        }
        #endregion

        #region Get & Set

        /// <summary>
        /// Summary description for Get & Set this all class parameters
        /// </summary>


        public object GetRepositoryObject(object x_oObj)
        {
            if ((x_oObj is AutoSelectionProperty) || (x_oObj is AutoSelectionPropertyEntity)) return AutoSelectionPropertyRepository.Instance();
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
        public AutoSelectionPropertyInfo GetTableSet() { return n_oTableSet; }
        #endregion GetTableSet


        #region SetTableSet
        public void SetTableSet(AutoSelectionPropertyInfo value) { n_oTableSet = value; }
        #endregion SetTableSet

        public global::System.Nullable<int> GetId() { return this.id; }
        public string GetPeriod() { return this.period; }
        public global::System.Nullable<DateTime> GetStart_date() { return this.start_date; }
        public string GetObprogram() { return this.obprogram; }
        public string GetChannel() { return this.channel; }
        public string GetTier() { return this.tier; }
        public global::System.Nullable<int> GetTradefield_mid() { return this.tradefield_mid; }
        public string GetUid() { return this.uid; }
        public global::System.Nullable<DateTime> GetEnd_date() { return this.end_date; }
        public string GetPlan_fee() { return this.plan_fee; }
        public string GetRemarks() { return this.remarks; }
        public global::System.Nullable<DateTime> GetPo_date() { return this.po_date; }

        public bool SetId(global::System.Nullable<int> value)
        {
            this.id = value;
            return true;
        }
        public bool SetPeriod(string value)
        {
            this.period = value;
            return true;
        }
        public bool SetStart_date(global::System.Nullable<DateTime> value)
        {
            this.start_date = value;
            return true;
        }
        public bool SetObprogram(string value)
        {
            this.obprogram = value;
            return true;
        }
        public bool SetChannel(string value)
        {
            this.channel = value;
            return true;
        }
        public bool SetTier(string value)
        {
            this.tier = value;
            return true;
        }
        public bool SetTradefield_mid(global::System.Nullable<int> value)
        {
            this.tradefield_mid = value;
            return true;
        }
        public bool SetUid(string value)
        {
            this.uid = value;
            return true;
        }
        public bool SetEnd_date(global::System.Nullable<DateTime> value)
        {
            this.end_date = value;
            return true;
        }
        public bool SetPlan_fee(string value)
        {
            this.plan_fee = value;
            return true;
        }
        public bool SetRemarks(string value)
        {
            this.remarks = value;
            return true;
        }
        public bool SetPo_date(global::System.Nullable<DateTime> value)
        {
            this.po_date = value;
            return true;
        }

        public Field GetIdTable()
        {
            return n_oTableSet.Fields(Para.id);
        }
        public Field GetPeriodTable()
        {
            return n_oTableSet.Fields(Para.period);
        }
        public Field GetStart_dateTable()
        {
            return n_oTableSet.Fields(Para.start_date);
        }
        public Field GetObprogramTable()
        {
            return n_oTableSet.Fields(Para.obprogram);
        }
        public Field GetChannelTable()
        {
            return n_oTableSet.Fields(Para.channel);
        }
        public Field GetTierTable()
        {
            return n_oTableSet.Fields(Para.tier);
        }
        public Field GetTradefield_midTable()
        {
            return n_oTableSet.Fields(Para.tradefield_mid);
        }
        public Field GetUidTable()
        {
            return n_oTableSet.Fields(Para.uid);
        }
        public Field GetEnd_dateTable()
        {
            return n_oTableSet.Fields(Para.end_date);
        }
        public Field GetPlan_feeTable()
        {
            return n_oTableSet.Fields(Para.plan_fee);
        }
        public Field GetRemarksTable()
        {
            return n_oTableSet.Fields(Para.remarks);
        }
        public Field GetPo_dateTable()
        {
            return n_oTableSet.Fields(Para.po_date);
        }
        #endregion

        #region Addtional Get & Set
        public BusinessTrade GetBusinessTradeAutoSelectionProperty()
        {
            return BusinessTradeAutoSelectionProperty;
        }

        public bool SetBusinessTradeAutoSelectionProperty(BusinessTrade value)
        {
            BusinessTradeAutoSelectionProperty = value;
            return true;
        }

        public global::System.Data.DataSet GetBusinessTradeAutoSelectionPropertyDataSet()
        {
            return BusinessTradeAutoSelectionPropertyDataSet;
        }

        public bool SetBusinessTradeAutoSelectionPropertyDataSet(DataSet value)
        {
            BusinessTradeAutoSelectionPropertyDataSet = value;
            return true;
        }


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

        public bool EqualID(AutoSelectionProperty x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }

        public bool Equals(AutoSelectionProperty x_oObj)
        {
            if (x_oObj == null) return false;
            if (!this.n_sRemarks.Equals(x_oObj.remarks)) { return false; }
            if (!this.n_iId.Equals(x_oObj.id)) { return false; }
            if (!this.n_sPeriod.Equals(x_oObj.period)) { return false; }
            if (!this.n_dStart_date.Equals(x_oObj.start_date)) { return false; }
            if (!this.n_sObprogram.Equals(x_oObj.obprogram)) { return false; }
            if (!this.n_sChannel.Equals(x_oObj.channel)) { return false; }
            if (!this.n_sTier.Equals(x_oObj.tier)) { return false; }
            if (!this.n_iTradefield_mid.Equals(x_oObj.tradefield_mid)) { return false; }
            if (!this.n_sUid.Equals(x_oObj.uid)) { return false; }
            if (!this.n_sPlan_fee.Equals(x_oObj.plan_fee)) { return false; }
            if (!this.n_dEnd_date.Equals(x_oObj.end_date)) { return false; }
            if (!this.n_dPo_date.Equals(x_oObj.po_date)) { return false; }
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
            string _sQuery = "UPDATE  [AutoSelectionProperty]  SET  [remarks]=@remarks,[period]=@period,[start_date]=@start_date,[obprogram]=@obprogram,[channel]=@channel,[tier]=@tier,[tradefield_mid]=@tradefield_mid,[uid]=@uid,[plan_fee]=@plan_fee,[end_date]=@end_date,[po_date]=@po_date  WHERE [AutoSelectionProperty].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[AutoSelectionProperty]", "[" + Configurator.MSSQLTablePrefix + "AutoSelectionProperty]"); }
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
            if (n_sRemarks == null) { _oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.Text, 2147483647).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.Text, 2147483647).Value = n_sRemarks; }
            if (n_iId == null) { _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = n_iId; }
            if (n_sPeriod == null) { _oCmd.Parameters.Add("@period", global::System.Data.SqlDbType.NVarChar, 50).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@period", global::System.Data.SqlDbType.NVarChar, 50).Value = n_sPeriod; }
            if (n_dStart_date == null) { _oCmd.Parameters.Add("@start_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { _oCmd.Parameters.Add("@start_date", global::System.Data.SqlDbType.DateTime).Value = n_dStart_date; }
            if (n_sObprogram == null) { _oCmd.Parameters.Add("@obprogram", global::System.Data.SqlDbType.NVarChar, 250).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@obprogram", global::System.Data.SqlDbType.NVarChar, 250).Value = n_sObprogram; }
            if (n_sChannel == null) { _oCmd.Parameters.Add("@channel", global::System.Data.SqlDbType.NVarChar, 10).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@channel", global::System.Data.SqlDbType.NVarChar, 10).Value = n_sChannel; }
            if (n_sTier == null) { _oCmd.Parameters.Add("@tier", global::System.Data.SqlDbType.NVarChar, 50).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@tier", global::System.Data.SqlDbType.NVarChar, 50).Value = n_sTier; }
            if (n_iTradefield_mid == null) { _oCmd.Parameters.Add("@tradefield_mid", global::System.Data.SqlDbType.Int).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@tradefield_mid", global::System.Data.SqlDbType.Int).Value = n_iTradefield_mid; }
            if (n_sUid == null) { _oCmd.Parameters.Add("@uid", global::System.Data.SqlDbType.NVarChar, 50).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@uid", global::System.Data.SqlDbType.NVarChar, 50).Value = n_sUid; }
            if (n_sPlan_fee == null) { _oCmd.Parameters.Add("@plan_fee", global::System.Data.SqlDbType.NVarChar, 50).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@plan_fee", global::System.Data.SqlDbType.NVarChar, 50).Value = n_sPlan_fee; }
            if (n_dEnd_date == null) { _oCmd.Parameters.Add("@end_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { _oCmd.Parameters.Add("@end_date", global::System.Data.SqlDbType.DateTime).Value = n_dEnd_date; }
            if (n_dPo_date == null) { _oCmd.Parameters.Add("@po_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { _oCmd.Parameters.Add("@po_date", global::System.Data.SqlDbType.DateTime).Value = n_dPo_date; }
            try
            {
                if (!n_oDB.bTransaction && _oConn.State == ConnectionState.Closed) _oConn.Open();
                _bResult = global::System.Convert.ToBoolean(_oCmd.ExecuteNonQuery());
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
        /// Summary description for table [AutoSelectionProperty] Delete Record
        /// </summary>

        public bool Delete()
        {
            if (n_iId == null) { return false; }
            string _sQuery = "DELETE FROM  [AutoSelectionProperty]  WHERE [AutoSelectionProperty].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[AutoSelectionProperty]", "[" + Configurator.MSSQLTablePrefix + "AutoSelectionProperty]"); }
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
        /// Summary description for table [AutoSelectionProperty] Object Base Clone
        /// </summary>

        public AutoSelectionProperty DeepClone()
        {
            AutoSelectionProperty _oAutoSelectionProperty_Clone = (AutoSelectionProperty)AutoSelectionPropertyRepository.CreateEntityInstanceObject();
            _oAutoSelectionProperty_Clone.remarks = this.n_sRemarks;
            _oAutoSelectionProperty_Clone.id = this.n_iId;
            _oAutoSelectionProperty_Clone.period = this.n_sPeriod;
            _oAutoSelectionProperty_Clone.start_date = this.n_dStart_date;
            _oAutoSelectionProperty_Clone.obprogram = this.n_sObprogram;
            _oAutoSelectionProperty_Clone.channel = this.n_sChannel;
            _oAutoSelectionProperty_Clone.tier = this.n_sTier;
            _oAutoSelectionProperty_Clone.tradefield_mid = this.n_iTradefield_mid;
            _oAutoSelectionProperty_Clone.uid = this.n_sUid;
            _oAutoSelectionProperty_Clone.plan_fee = this.n_sPlan_fee;
            _oAutoSelectionProperty_Clone.end_date = this.n_dEnd_date;
            _oAutoSelectionProperty_Clone.po_date = this.n_dPo_date;
            _oAutoSelectionProperty_Clone.SetFound(this.n_bFound);
            _oAutoSelectionProperty_Clone.SetDB(this.n_oDB);
            _oAutoSelectionProperty_Clone.SetRow(this.n_oRow);
            _oAutoSelectionProperty_Clone.SetTbl(this.n_oTbl);
            _oAutoSelectionProperty_Clone.SetTableSet(this.n_oTableSet);
            BusinessTradeAutoSelectionProperty = null;
            _oAutoSelectionProperty_Clone.BusinessTradeAutoSelectionProperty = this.BusinessTradeAutoSelectionProperty.DeepClone();

            return _oAutoSelectionProperty_Clone;
        }
        #endregion

        #region Release

        /// <summary>
        /// Summary description for Release
        /// </summary>

        public void Release()
        {
            n_sRemarks = string.Empty;
            n_iId = null;
            n_sPeriod = string.Empty;
            n_dStart_date = null;
            n_sObprogram = string.Empty;
            n_sChannel = string.Empty;
            n_sTier = string.Empty;
            n_iTradefield_mid = null;
            n_sUid = string.Empty;
            n_sPlan_fee = string.Empty;
            n_dEnd_date = null;
            n_dPo_date = null;
            n_oDB = null;
            n_bFound = false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = new AutoSelectionPropertyInfo();
            n_oBusinessTradeAutoSelectionProperty = null;
        }
        #endregion
    }
}

