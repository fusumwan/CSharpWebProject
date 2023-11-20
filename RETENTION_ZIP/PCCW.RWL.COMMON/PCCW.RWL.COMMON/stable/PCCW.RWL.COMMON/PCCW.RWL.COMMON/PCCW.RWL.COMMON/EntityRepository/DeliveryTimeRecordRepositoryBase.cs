using System;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
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
///-- Create date: <Create Date 2009-12-21>
///-- Description:	<Description,Table :[DeliveryTimeRecord],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [DeliveryTimeRecord] Insert / list / delete manager layer
    /// </summary>

    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name = Configurator.MSSQLTablePrefix + "DeliveryTimeRecord")]
    public class DeliveryTimeRecordRepositoryBase : global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable
    {

        #region Instance
        private static DeliveryTimeRecordRepositoryBase instance;
        public static DeliveryTimeRecordRepositoryBase Instance()
        {
            if (instance == null)
            {
                MSSQLConnect _oDB = new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new DeliveryTimeRecordRepositoryBase(_oDB);
            }
            return instance;
        }
        public static DeliveryTimeRecordRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if (instance == null)
                instance = new DeliveryTimeRecordRepositoryBase(x_oDB);
            return instance;
        }
        #endregion

        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<DeliveryTimeRecordEntity> DeliveryTimeRecords;
        #endregion

        #region Constructor
        public DeliveryTimeRecordRepositoryBase(MSSQLConnect x_oDB)
            : base(x_oDB.ConnectionStr)
        {
            n_oDB = x_oDB;
        }
        ~DeliveryTimeRecordRepositoryBase()
        {
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (disposing)
            {
            }
        }
        #endregion
        #region Create Instance Object
        /// <summary>
        /// Summary description for Create Instance Object
        /// </summary>
        public static DeliveryTimeRecord CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new DeliveryTimeRecord(_oDB);
        }

        public static DeliveryTimeRecord CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new DeliveryTimeRecord(x_oDB);
        }
        #endregion

        #region Count

        /// <summary>
        /// Summary description for Counting
        /// </summary>

        public int GetCount()
        {
            return GetCount(n_oDB);
        }
        public static int GetCount(MSSQLConnect x_oDB)
        {
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [DeliveryTimeRecord]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DeliveryTimeRecord]", "[" + Configurator.MSSQLTablePrefix + "DeliveryTimeRecord]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                int _iTotalCount = 0;
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    if (_oData.Read())
                    {
                        _iTotalCount = (int)_oData["TotalCount"];
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
                return _iTotalCount;
            }
        }
        #endregion

        #region Get Array & List

        /// <summary>
        /// Summary description for management get record from table
        /// </summary>


        public DeliveryTimeRecordEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }


        public static DeliveryTimeRecordEntity GetObj(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            if (x_oDB == null) { return null; }
            DeliveryTimeRecord _DeliveryTimeRecord = (DeliveryTimeRecord)DeliveryTimeRecordRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_DeliveryTimeRecord.Load(x_iId)) { return null; }
            return _DeliveryTimeRecord;
        }



        public static DeliveryTimeRecordEntity[] GetArrayObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            List<DeliveryTimeRecordEntity> _oDeliveryTimeRecordList = GetListObj(x_oDB, 0, "id", x_oArrayItemId);
            return _oDeliveryTimeRecordList.Count == 0 ? null : _oDeliveryTimeRecordList.ToArray();
        }

        public static List<DeliveryTimeRecordEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB, 0, "id", x_oArrayItemId);
        }


        public static DeliveryTimeRecordEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<DeliveryTimeRecordEntity> _oDeliveryTimeRecordList = GetListObj(x_oDB, 0, x_oColumnName, x_oArrayItemId);
            return _oDeliveryTimeRecordList.Count == 0 ? null : _oDeliveryTimeRecordList.ToArray();
        }


        public static DeliveryTimeRecordEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<DeliveryTimeRecordEntity> _oDeliveryTimeRecordList = GetListObj(x_oDB, x_iTop, x_oColumnName, x_oArrayItemId);
            return _oDeliveryTimeRecordList.Count == 0 ? null : _oDeliveryTimeRecordList.ToArray();
        }

        public static List<DeliveryTimeRecordEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB == null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            List<DeliveryTimeRecordEntity> _oRow = new List<DeliveryTimeRecordEntity>();
            string _sQuery = "SELECT  " + _sTop + " [DeliveryTimeRecord].[id] AS DELIVERYTIMERECORD_ID,[DeliveryTimeRecord].[cdate] AS DELIVERYTIMERECORD_CDATE,[DeliveryTimeRecord].[cid] AS DELIVERYTIMERECORD_CID,[DeliveryTimeRecord].[active] AS DELIVERYTIMERECORD_ACTIVE,[DeliveryTimeRecord].[pm8_10] AS DELIVERYTIMERECORD_PM8_10,[DeliveryTimeRecord].[location] AS DELIVERYTIMERECORD_LOCATION,[DeliveryTimeRecord].[pm7_9] AS DELIVERYTIMERECORD_PM7_9,[DeliveryTimeRecord].[area] AS DELIVERYTIMERECORD_AREA,[DeliveryTimeRecord].[pm6_8] AS DELIVERYTIMERECORD_PM6_8,[DeliveryTimeRecord].[am] AS DELIVERYTIMERECORD_AM,[DeliveryTimeRecord].[did] AS DELIVERYTIMERECORD_DID,[DeliveryTimeRecord].[ddate] AS DELIVERYTIMERECORD_DDATE,[DeliveryTimeRecord].[pm] AS DELIVERYTIMERECORD_PM,[DeliveryTimeRecord].[delivery_fee] AS DELIVERYTIMERECORD_DELIVERY_FEE  FROM  [DeliveryTimeRecord]";
            if (x_oArrayItemId == null)
            {
                string _oList = "(";
                for (int i = 0; i < x_oArrayItemId.Count; i++)
                {
                    if (i < (x_oArrayItemId.Count - 1))
                    {
                        _oList += "'" + x_oArrayItemId[i].ToString() + "',";
                    }
                    else
                    {
                        _oList += "'" + x_oArrayItemId[i].ToString() + "'";
                    }
                }
                _oList += ")";
                _sQuery += " WHERE [DeliveryTimeRecord].[" + x_oColumnName.ToString() + "]  in " + _oList;
            }

            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DeliveryTimeRecord]", "[" + Configurator.MSSQLTablePrefix + "DeliveryTimeRecord]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        DeliveryTimeRecord _oDeliveryTimeRecord = DeliveryTimeRecordRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_ID"])) { _oDeliveryTimeRecord.id = (global::System.Nullable<int>)_oData["DELIVERYTIMERECORD_ID"]; } else { _oDeliveryTimeRecord.id = null; }
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_CDATE"])) { _oDeliveryTimeRecord.cdate = (global::System.Nullable<DateTime>)_oData["DELIVERYTIMERECORD_CDATE"]; } else { _oDeliveryTimeRecord.cdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_CID"])) { _oDeliveryTimeRecord.cid = (string)_oData["DELIVERYTIMERECORD_CID"]; } else { _oDeliveryTimeRecord.cid = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_ACTIVE"])) { _oDeliveryTimeRecord.active = (global::System.Nullable<bool>)_oData["DELIVERYTIMERECORD_ACTIVE"]; } else { _oDeliveryTimeRecord.active = null; }
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_PM8_10"])) { _oDeliveryTimeRecord.pm8_10 = (global::System.Nullable<bool>)_oData["DELIVERYTIMERECORD_PM8_10"]; } else { _oDeliveryTimeRecord.pm8_10 = null; }
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_LOCATION"])) { _oDeliveryTimeRecord.location = (string)_oData["DELIVERYTIMERECORD_LOCATION"]; } else { _oDeliveryTimeRecord.location = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_PM7_9"])) { _oDeliveryTimeRecord.pm7_9 = (global::System.Nullable<bool>)_oData["DELIVERYTIMERECORD_PM7_9"]; } else { _oDeliveryTimeRecord.pm7_9 = null; }
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_AREA"])) { _oDeliveryTimeRecord.area = (string)_oData["DELIVERYTIMERECORD_AREA"]; } else { _oDeliveryTimeRecord.area = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_PM6_8"])) { _oDeliveryTimeRecord.pm6_8 = (global::System.Nullable<bool>)_oData["DELIVERYTIMERECORD_PM6_8"]; } else { _oDeliveryTimeRecord.pm6_8 = null; }
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_PM"])) { _oDeliveryTimeRecord.pm = (global::System.Nullable<bool>)_oData["DELIVERYTIMERECORD_PM"]; } else { _oDeliveryTimeRecord.pm = null; }
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_AM"])) { _oDeliveryTimeRecord.am = (global::System.Nullable<bool>)_oData["DELIVERYTIMERECORD_AM"]; } else { _oDeliveryTimeRecord.am = null; }
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_DDATE"])) { _oDeliveryTimeRecord.ddate = (global::System.Nullable<DateTime>)_oData["DELIVERYTIMERECORD_DDATE"]; } else { _oDeliveryTimeRecord.ddate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_DID"])) { _oDeliveryTimeRecord.did = (string)_oData["DELIVERYTIMERECORD_DID"]; } else { _oDeliveryTimeRecord.did = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_DELIVERY_FEE"])) { _oDeliveryTimeRecord.delivery_fee = (global::System.Nullable<int>)_oData["DELIVERYTIMERECORD_DELIVERY_FEE"]; } else { _oDeliveryTimeRecord.delivery_fee = null; }
                        _oDeliveryTimeRecord.SetDB(x_oDB);
                        _oDeliveryTimeRecord.GetFound();
                        _oRow.Add(_oDeliveryTimeRecord);
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
                return _oRow;
            }
        }


        public static DeliveryTimeRecordEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<DeliveryTimeRecordEntity> _oDeliveryTimeRecordList = GetListObj(x_oDB, 0, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oDeliveryTimeRecordList.Count == 0 ? null : _oDeliveryTimeRecordList.ToArray();
        }


        public static DeliveryTimeRecordEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<DeliveryTimeRecordEntity> _oDeliveryTimeRecordList = GetListObj(x_oDB, x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oDeliveryTimeRecordList.Count == 0 ? null : _oDeliveryTimeRecordList.ToArray();
        }

        public static List<DeliveryTimeRecordEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB == null) { return null; }
            List<DeliveryTimeRecordEntity> _oRow = new List<DeliveryTimeRecordEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            string _sFields = "[DeliveryTimeRecord].[id] AS DELIVERYTIMERECORD_ID,[DeliveryTimeRecord].[cdate] AS DELIVERYTIMERECORD_CDATE,[DeliveryTimeRecord].[cid] AS DELIVERYTIMERECORD_CID,[DeliveryTimeRecord].[active] AS DELIVERYTIMERECORD_ACTIVE,[DeliveryTimeRecord].[pm8_10] AS DELIVERYTIMERECORD_PM8_10,[DeliveryTimeRecord].[location] AS DELIVERYTIMERECORD_LOCATION,[DeliveryTimeRecord].[pm7_9] AS DELIVERYTIMERECORD_PM7_9,[DeliveryTimeRecord].[area] AS DELIVERYTIMERECORD_AREA,[DeliveryTimeRecord].[pm6_8] AS DELIVERYTIMERECORD_PM6_8,[DeliveryTimeRecord].[am] AS DELIVERYTIMERECORD_AM,[DeliveryTimeRecord].[did] AS DELIVERYTIMERECORD_DID,[DeliveryTimeRecord].[ddate] AS DELIVERYTIMERECORD_DDATE,[DeliveryTimeRecord].[pm] AS DELIVERYTIMERECORD_PM,[DeliveryTimeRecord].[delivery_fee] AS DELIVERYTIMERECORD_DELIVERY_FEE";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[DeliveryTimeRecord]", "[" + Configurator.MSSQLTablePrefix + "DeliveryTimeRecord]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = DeliveryTimeRecordRepositoryBase.GetSearch(x_oDB, _sTop.ToString() + _sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                DeliveryTimeRecordEntity _oDeliveryTimeRecord = DeliveryTimeRecordRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_ID"])) { _oDeliveryTimeRecord.id = (global::System.Nullable<int>)_oData["DELIVERYTIMERECORD_ID"]; } else { _oDeliveryTimeRecord.id = null; }
                if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_CDATE"])) { _oDeliveryTimeRecord.cdate = (global::System.Nullable<DateTime>)_oData["DELIVERYTIMERECORD_CDATE"]; } else { _oDeliveryTimeRecord.cdate = null; }
                if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_CID"])) { _oDeliveryTimeRecord.cid = (string)_oData["DELIVERYTIMERECORD_CID"]; } else { _oDeliveryTimeRecord.cid = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_ACTIVE"])) { _oDeliveryTimeRecord.active = (global::System.Nullable<bool>)_oData["DELIVERYTIMERECORD_ACTIVE"]; } else { _oDeliveryTimeRecord.active = null; }
                if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_PM8_10"])) { _oDeliveryTimeRecord.pm8_10 = (global::System.Nullable<bool>)_oData["DELIVERYTIMERECORD_PM8_10"]; } else { _oDeliveryTimeRecord.pm8_10 = null; }
                if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_LOCATION"])) { _oDeliveryTimeRecord.location = (string)_oData["DELIVERYTIMERECORD_LOCATION"]; } else { _oDeliveryTimeRecord.location = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_PM7_9"])) { _oDeliveryTimeRecord.pm7_9 = (global::System.Nullable<bool>)_oData["DELIVERYTIMERECORD_PM7_9"]; } else { _oDeliveryTimeRecord.pm7_9 = null; }
                if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_AREA"])) { _oDeliveryTimeRecord.area = (string)_oData["DELIVERYTIMERECORD_AREA"]; } else { _oDeliveryTimeRecord.area = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_PM6_8"])) { _oDeliveryTimeRecord.pm6_8 = (global::System.Nullable<bool>)_oData["DELIVERYTIMERECORD_PM6_8"]; } else { _oDeliveryTimeRecord.pm6_8 = null; }
                if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_PM"])) { _oDeliveryTimeRecord.pm = (global::System.Nullable<bool>)_oData["DELIVERYTIMERECORD_PM"]; } else { _oDeliveryTimeRecord.pm = null; }
                if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_AM"])) { _oDeliveryTimeRecord.am = (global::System.Nullable<bool>)_oData["DELIVERYTIMERECORD_AM"]; } else { _oDeliveryTimeRecord.am = null; }
                if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_DDATE"])) { _oDeliveryTimeRecord.ddate = (global::System.Nullable<DateTime>)_oData["DELIVERYTIMERECORD_DDATE"]; } else { _oDeliveryTimeRecord.ddate = null; }
                if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_DID"])) { _oDeliveryTimeRecord.did = (string)_oData["DELIVERYTIMERECORD_DID"]; } else { _oDeliveryTimeRecord.did = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_DELIVERY_FEE"])) { _oDeliveryTimeRecord.delivery_fee = (global::System.Nullable<int>)_oData["DELIVERYTIMERECORD_DELIVERY_FEE"]; } else { _oDeliveryTimeRecord.delivery_fee = null; }
                _oDeliveryTimeRecord.SetDB(x_oDB);
                _oDeliveryTimeRecord.GetFound();
                _oRow.Add(_oDeliveryTimeRecord);
            }
            _oData.Close();
            _oData.Dispose();
            return _oRow;
        }
        #endregion

        #region DataSet
        /// <summary>
        /// Summary description for get table from records with DataSet
        /// </summary>

        public global::System.Data.DataSet GetDataSet()
        {
            return GetDataSet(n_oDB, "");
        }


        public global::System.Data.DataSet GetDataSet(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return GetDataSet(n_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }


        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB == null) { return null; }
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet(DeliveryTimeRecord.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder, DeliveryTimeRecord.Para.TableName());
            return _oDset;
        }


        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB == null) { return null; }
            return x_oDB.GetSearch(DeliveryTimeRecord.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }


        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(DeliveryTimeRecord.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            if (x_oDB == null) { return null; }
            string _oQuery = "SELECT   [DeliveryTimeRecord].[id] AS DELIVERYTIMERECORD_ID,[DeliveryTimeRecord].[cdate] AS DELIVERYTIMERECORD_CDATE,[DeliveryTimeRecord].[cid] AS DELIVERYTIMERECORD_CID,[DeliveryTimeRecord].[active] AS DELIVERYTIMERECORD_ACTIVE,[DeliveryTimeRecord].[pm8_10] AS DELIVERYTIMERECORD_PM8_10,[DeliveryTimeRecord].[location] AS DELIVERYTIMERECORD_LOCATION,[DeliveryTimeRecord].[pm7_9] AS DELIVERYTIMERECORD_PM7_9,[DeliveryTimeRecord].[area] AS DELIVERYTIMERECORD_AREA,[DeliveryTimeRecord].[pm6_8] AS DELIVERYTIMERECORD_PM6_8,[DeliveryTimeRecord].[am] AS DELIVERYTIMERECORD_AM,[DeliveryTimeRecord].[did] AS DELIVERYTIMERECORD_DID,[DeliveryTimeRecord].[ddate] AS DELIVERYTIMERECORD_DDATE,[DeliveryTimeRecord].[pm] AS DELIVERYTIMERECORD_PM,[DeliveryTimeRecord].[delivery_fee] AS DELIVERYTIMERECORD_DELIVERY_FEE  FROM  [DeliveryTimeRecord]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[DeliveryTimeRecord]", "[" + Configurator.MSSQLTablePrefix + "DeliveryTimeRecord]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery, _oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset, "DeliveryTimeRecord");
                }
                catch (Exception exp) { string _sError = exp.ToString(); }
                finally
                {
                    _oConn.Close();
                    _oAdp.Dispose();
                    _oConn.Dispose();
                }
                return _oDset;
            }
        }
        #endregion
        #region Insert


        /// <summary>
        /// Summary description for management Insert
        /// </summary>

        public bool Insert(global::System.Nullable<DateTime> x_dCdate, string x_sCid, global::System.Nullable<bool> x_bActive, global::System.Nullable<bool> x_bPm8_10, string x_sLocation, global::System.Nullable<bool> x_bPm7_9, string x_sArea, global::System.Nullable<bool> x_bPm6_8, global::System.Nullable<bool> x_bPm, global::System.Nullable<bool> x_bAm, global::System.Nullable<DateTime> x_dDdate, string x_sDid, global::System.Nullable<int> x_iDelivery_fee)
        {
            DeliveryTimeRecord _oDeliveryTimeRecord = DeliveryTimeRecordRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oDeliveryTimeRecord.cdate = x_dCdate;
            _oDeliveryTimeRecord.cid = x_sCid;
            _oDeliveryTimeRecord.active = x_bActive;
            _oDeliveryTimeRecord.pm8_10 = x_bPm8_10;
            _oDeliveryTimeRecord.location = x_sLocation;
            _oDeliveryTimeRecord.pm7_9 = x_bPm7_9;
            _oDeliveryTimeRecord.area = x_sArea;
            _oDeliveryTimeRecord.pm6_8 = x_bPm6_8;
            _oDeliveryTimeRecord.pm = x_bPm;
            _oDeliveryTimeRecord.am = x_bAm;
            _oDeliveryTimeRecord.ddate = x_dDdate;
            _oDeliveryTimeRecord.did = x_sDid;
            _oDeliveryTimeRecord.delivery_fee = x_iDelivery_fee;
            return InsertWithOutLastID(n_oDB, _oDeliveryTimeRecord);
        }


        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate, string x_sCid, global::System.Nullable<bool> x_bActive, global::System.Nullable<bool> x_bPm8_10, string x_sLocation, global::System.Nullable<bool> x_bPm7_9, string x_sArea, global::System.Nullable<bool> x_bPm6_8, global::System.Nullable<bool> x_bPm, global::System.Nullable<bool> x_bAm, global::System.Nullable<DateTime> x_dDdate, string x_sDid, global::System.Nullable<int> x_iDelivery_fee)
        {
            DeliveryTimeRecord _oDeliveryTimeRecord = DeliveryTimeRecordRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oDeliveryTimeRecord.cdate = x_dCdate;
            _oDeliveryTimeRecord.cid = x_sCid;
            _oDeliveryTimeRecord.active = x_bActive;
            _oDeliveryTimeRecord.pm8_10 = x_bPm8_10;
            _oDeliveryTimeRecord.location = x_sLocation;
            _oDeliveryTimeRecord.pm7_9 = x_bPm7_9;
            _oDeliveryTimeRecord.area = x_sArea;
            _oDeliveryTimeRecord.pm6_8 = x_bPm6_8;
            _oDeliveryTimeRecord.pm = x_bPm;
            _oDeliveryTimeRecord.am = x_bAm;
            _oDeliveryTimeRecord.ddate = x_dDdate;
            _oDeliveryTimeRecord.did = x_sDid;
            _oDeliveryTimeRecord.delivery_fee = x_iDelivery_fee;
            return InsertWithOutLastID(x_oDB, _oDeliveryTimeRecord);
        }


        public bool Insert(DeliveryTimeRecord x_oDeliveryTimeRecord)
        {
            return InsertWithOutLastID(n_oDB, x_oDeliveryTimeRecord);
        }


        public bool InsertEntity(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is DeliveryTimeRecord)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (DeliveryTimeRecord)x_oObj);
        }


        public static bool Insert(MSSQLConnect x_oDB, DeliveryTimeRecord x_oDeliveryTimeRecord)
        {
            return InsertWithOutLastID(x_oDB, x_oDeliveryTimeRecord);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, DeliveryTimeRecord x_oDeliveryTimeRecord)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT INTO  [DeliveryTimeRecord]   ([cdate],[cid],[active],[pm8_10],[location],[pm7_9],[area],[pm6_8],[am],[did],[ddate],[pm],[delivery_fee])  VALUES  (@cdate,@cid,@active,@pm8_10,@location,@pm7_9,@area,@pm6_8,@am,@did,@ddate,@pm,@delivery_fee)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DeliveryTimeRecord]", "[" + Configurator.MSSQLTablePrefix + "DeliveryTimeRecord]"); }
            global::System.Data.SqlClient.SqlConnection _oConn = null;
            global::System.Data.SqlClient.SqlCommand _oCmd = null;
            if (x_oDB.bTransaction)
            {
                x_oDB.ISessionCmd.CommandText = _sQuery;
                x_oDB.ISessionCmd.Parameters.Clear();
                _oCmd = x_oDB.ISessionCmd;
                _oConn = x_oDB.ISessionConn;
            }
            else
            {
                _oConn = x_oDB.GetConnection();
                _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            }
            return InsertTransactionWithOutLastID(x_oDB, _oConn, _oCmd, x_oDeliveryTimeRecord);
        }

        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, DeliveryTimeRecord x_oDeliveryTimeRecord)
        {
            bool _bResult = false;
            if (!x_oDeliveryTimeRecord.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if (x_oDeliveryTimeRecord.cdate == null) { x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = x_oDeliveryTimeRecord.cdate; }
                if (x_oDeliveryTimeRecord.cid == null) { x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar, 50).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar, 50).Value = x_oDeliveryTimeRecord.cid; }
                if (x_oDeliveryTimeRecord.active == null) { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = x_oDeliveryTimeRecord.active; }
                if (x_oDeliveryTimeRecord.pm8_10 == null) { x_oCmd.Parameters.Add("@pm8_10", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@pm8_10", global::System.Data.SqlDbType.Bit).Value = x_oDeliveryTimeRecord.pm8_10; }
                if (x_oDeliveryTimeRecord.location == null) { x_oCmd.Parameters.Add("@location", global::System.Data.SqlDbType.NVarChar, 100).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@location", global::System.Data.SqlDbType.NVarChar, 100).Value = x_oDeliveryTimeRecord.location; }
                if (x_oDeliveryTimeRecord.pm7_9 == null) { x_oCmd.Parameters.Add("@pm7_9", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@pm7_9", global::System.Data.SqlDbType.Bit).Value = x_oDeliveryTimeRecord.pm7_9; }
                if (x_oDeliveryTimeRecord.area == null) { x_oCmd.Parameters.Add("@area", global::System.Data.SqlDbType.NVarChar, 100).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@area", global::System.Data.SqlDbType.NVarChar, 100).Value = x_oDeliveryTimeRecord.area; }
                if (x_oDeliveryTimeRecord.pm6_8 == null) { x_oCmd.Parameters.Add("@pm6_8", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@pm6_8", global::System.Data.SqlDbType.Bit).Value = x_oDeliveryTimeRecord.pm6_8; }
                if (x_oDeliveryTimeRecord.am == null) { x_oCmd.Parameters.Add("@am", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@am", global::System.Data.SqlDbType.Bit).Value = x_oDeliveryTimeRecord.am; }
                if (x_oDeliveryTimeRecord.did == null) { x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar, 50).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar, 50).Value = x_oDeliveryTimeRecord.did; }
                if (x_oDeliveryTimeRecord.ddate == null) { x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = x_oDeliveryTimeRecord.ddate; }
                if (x_oDeliveryTimeRecord.pm == null) { x_oCmd.Parameters.Add("@pm", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@pm", global::System.Data.SqlDbType.Bit).Value = x_oDeliveryTimeRecord.pm; }
                if (x_oDeliveryTimeRecord.delivery_fee == null) { x_oCmd.Parameters.Add("@delivery_fee", global::System.Data.SqlDbType.Int).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@delivery_fee", global::System.Data.SqlDbType.Int).Value = x_oDeliveryTimeRecord.delivery_fee; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State == ConnectionState.Closed) x_oConn.Open();
                _bResult = Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
            }
            catch (Exception exp) { string _sError = exp.ToString(); }
            finally
            {
                if (!x_oDB.bTransaction)
                {
                    x_oConn.Close();
                    x_oCmd.Dispose();
                    x_oConn.Dispose();
                }
            }
            return _bResult;
        }


        public static int InsertReturnLastID(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate, string x_sCid, global::System.Nullable<bool> x_bActive, global::System.Nullable<bool> x_bPm8_10, string x_sLocation, global::System.Nullable<bool> x_bPm7_9, string x_sArea, global::System.Nullable<bool> x_bPm6_8, global::System.Nullable<bool> x_bPm, global::System.Nullable<bool> x_bAm, global::System.Nullable<DateTime> x_dDdate, string x_sDid, global::System.Nullable<int> x_iDelivery_fee)
        {
            int _oLastID;
            DeliveryTimeRecord _oDeliveryTimeRecord = DeliveryTimeRecordRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oDeliveryTimeRecord.cdate = x_dCdate;
            _oDeliveryTimeRecord.cid = x_sCid;
            _oDeliveryTimeRecord.active = x_bActive;
            _oDeliveryTimeRecord.pm8_10 = x_bPm8_10;
            _oDeliveryTimeRecord.location = x_sLocation;
            _oDeliveryTimeRecord.pm7_9 = x_bPm7_9;
            _oDeliveryTimeRecord.area = x_sArea;
            _oDeliveryTimeRecord.pm6_8 = x_bPm6_8;
            _oDeliveryTimeRecord.pm = x_bPm;
            _oDeliveryTimeRecord.am = x_bAm;
            _oDeliveryTimeRecord.ddate = x_dDdate;
            _oDeliveryTimeRecord.did = x_sDid;
            _oDeliveryTimeRecord.delivery_fee = x_iDelivery_fee;
            if (InsertWithLastID(x_oDB, _oDeliveryTimeRecord, out _oLastID))
            {
                return _oLastID;
            }
            else
            {
                return -1;
            }
        }


        public int InsertReturnLastID(DeliveryTimeRecord x_oDeliveryTimeRecord)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oDeliveryTimeRecord, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }


        public static int InsertReturnLastID(MSSQLConnect x_oDB, DeliveryTimeRecord x_oDeliveryTimeRecord)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oDeliveryTimeRecord, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is DeliveryTimeRecord)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (DeliveryTimeRecord)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }

        public static bool InsertWithLastID(MSSQLConnect x_oDB, DeliveryTimeRecord x_oDeliveryTimeRecord, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT INTO  [DeliveryTimeRecord]   ([cdate],[cid],[active],[pm8_10],[location],[pm7_9],[area],[pm6_8],[am],[did],[ddate],[pm],[delivery_fee])  VALUES  (@cdate,@cid,@active,@pm8_10,@location,@pm7_9,@area,@pm6_8,@am,@did,@ddate,@pm,@delivery_fee)" + " SELECT  @@IDENTITY AS DeliveryTimeRecord_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DeliveryTimeRecord]", "[" + Configurator.MSSQLTablePrefix + "DeliveryTimeRecord]"); }
            global::System.Data.SqlClient.SqlConnection _oConn = null;
            global::System.Data.SqlClient.SqlCommand _oCmd = null;
            if (x_oDB.bTransaction)
            {
                x_oDB.ISessionCmd.CommandText = _sQuery;
                x_oDB.ISessionCmd.Parameters.Clear();
                _oCmd = x_oDB.ISessionCmd;
                _oConn = x_oDB.ISessionConn;
            }
            else
            {
                _oConn = x_oDB.GetConnection();
                _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            }
            return InsertTransactionLastID(x_oDB, _oConn, _oCmd, x_oDeliveryTimeRecord, out x_iLAST_ID);
        }

        public static bool InsertTransactionLastID(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, DeliveryTimeRecord x_oDeliveryTimeRecord, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oDeliveryTimeRecord.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if (x_oDeliveryTimeRecord.cdate == null) { x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = x_oDeliveryTimeRecord.cdate; }
                if (x_oDeliveryTimeRecord.cid == null) { x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar, 50).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar, 50).Value = x_oDeliveryTimeRecord.cid; }
                if (x_oDeliveryTimeRecord.active == null) { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = x_oDeliveryTimeRecord.active; }
                if (x_oDeliveryTimeRecord.pm8_10 == null) { x_oCmd.Parameters.Add("@pm8_10", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@pm8_10", global::System.Data.SqlDbType.Bit).Value = x_oDeliveryTimeRecord.pm8_10; }
                if (x_oDeliveryTimeRecord.location == null) { x_oCmd.Parameters.Add("@location", global::System.Data.SqlDbType.NVarChar, 100).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@location", global::System.Data.SqlDbType.NVarChar, 100).Value = x_oDeliveryTimeRecord.location; }
                if (x_oDeliveryTimeRecord.pm7_9 == null) { x_oCmd.Parameters.Add("@pm7_9", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@pm7_9", global::System.Data.SqlDbType.Bit).Value = x_oDeliveryTimeRecord.pm7_9; }
                if (x_oDeliveryTimeRecord.area == null) { x_oCmd.Parameters.Add("@area", global::System.Data.SqlDbType.NVarChar, 100).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@area", global::System.Data.SqlDbType.NVarChar, 100).Value = x_oDeliveryTimeRecord.area; }
                if (x_oDeliveryTimeRecord.pm6_8 == null) { x_oCmd.Parameters.Add("@pm6_8", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@pm6_8", global::System.Data.SqlDbType.Bit).Value = x_oDeliveryTimeRecord.pm6_8; }
                if (x_oDeliveryTimeRecord.am == null) { x_oCmd.Parameters.Add("@am", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@am", global::System.Data.SqlDbType.Bit).Value = x_oDeliveryTimeRecord.am; }
                if (x_oDeliveryTimeRecord.did == null) { x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar, 50).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar, 50).Value = x_oDeliveryTimeRecord.did; }
                if (x_oDeliveryTimeRecord.ddate == null) { x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = x_oDeliveryTimeRecord.ddate; }
                if (x_oDeliveryTimeRecord.pm == null) { x_oCmd.Parameters.Add("@pm", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@pm", global::System.Data.SqlDbType.Bit).Value = x_oDeliveryTimeRecord.pm; }
                if (x_oDeliveryTimeRecord.delivery_fee == null) { x_oCmd.Parameters.Add("@delivery_fee", global::System.Data.SqlDbType.Int).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@delivery_fee", global::System.Data.SqlDbType.Int).Value = x_oDeliveryTimeRecord.delivery_fee; }
                if (!x_oDB.bTransaction && x_oConn.State == ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["DeliveryTimeRecord_LASTID"]))
                    {
                        if (string.IsNullOrEmpty(_oData["DeliveryTimeRecord_LASTID"].ToString()) && int.TryParse(_oData["DeliveryTimeRecord_LASTID"].ToString(), out x_iLAST_ID))
                        {
                            _bResult = true;
                        }
                        else
                        {
                            x_iLAST_ID = -1;
                        }
                    }
                }
                _oData.Close();
                _oData.Dispose();
            }
            catch (Exception exp) { string _sError = exp.ToString(); }
            finally
            {
                if (!x_oDB.bTransaction)
                {
                    x_oConn.Close();
                    x_oCmd.Dispose();
                    x_oConn.Dispose();
                }
            }
            return _bResult;
        }

        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate, string x_sCid, global::System.Nullable<bool> x_bActive, global::System.Nullable<bool> x_bPm8_10, string x_sLocation, global::System.Nullable<bool> x_bPm7_9, string x_sArea, global::System.Nullable<bool> x_bPm6_8, global::System.Nullable<bool> x_bPm, global::System.Nullable<bool> x_bAm, global::System.Nullable<DateTime> x_dDdate, string x_sDid, global::System.Nullable<int> x_iDelivery_fee)
        {
            int _oLastID;
            DeliveryTimeRecord _oDeliveryTimeRecord = DeliveryTimeRecordRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oDeliveryTimeRecord.cdate = x_dCdate;
            _oDeliveryTimeRecord.cid = x_sCid;
            _oDeliveryTimeRecord.active = x_bActive;
            _oDeliveryTimeRecord.pm8_10 = x_bPm8_10;
            _oDeliveryTimeRecord.location = x_sLocation;
            _oDeliveryTimeRecord.pm7_9 = x_bPm7_9;
            _oDeliveryTimeRecord.area = x_sArea;
            _oDeliveryTimeRecord.pm6_8 = x_bPm6_8;
            _oDeliveryTimeRecord.pm = x_bPm;
            _oDeliveryTimeRecord.am = x_bAm;
            _oDeliveryTimeRecord.ddate = x_dDdate;
            _oDeliveryTimeRecord.did = x_sDid;
            _oDeliveryTimeRecord.delivery_fee = x_iDelivery_fee;
            if (InsertWithLastID_SP(x_oDB, _oDeliveryTimeRecord, out _oLastID))
            {
                return _oLastID;
            }
            else
            {
                return -1;
            }
        }


        public int InsertReturnLastID_SP(DeliveryTimeRecord x_oDeliveryTimeRecord)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oDeliveryTimeRecord, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, DeliveryTimeRecord x_oDeliveryTimeRecord)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oDeliveryTimeRecord, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is DeliveryTimeRecord)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (DeliveryTimeRecord)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB, DeliveryTimeRecord x_oDeliveryTimeRecord, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "DELIVERYTIMERECORD";
            global::System.Data.SqlClient.SqlConnection _oConn = null;
            global::System.Data.SqlClient.SqlCommand _oCmd = null;
            if (x_oDB.bTransaction)
            {
                x_oDB.ISessionCmd.CommandText = _sQuery;
                x_oDB.ISessionCmd.Parameters.Clear();
                _oCmd = x_oDB.ISessionCmd;
                _oConn = x_oDB.ISessionConn;
            }
            else
            {
                _oConn = x_oDB.GetConnection();
                _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            }
            return InsertTransactionWithLastID_SP(x_oDB, _oConn, _oCmd, x_oDeliveryTimeRecord, out x_oLAST_ID);
        }

        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, DeliveryTimeRecord x_oDeliveryTimeRecord, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar = x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oDeliveryTimeRecord.cdate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oDeliveryTimeRecord.cdate; }
                _oPar = x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar, 50);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oDeliveryTimeRecord.cid == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oDeliveryTimeRecord.cid; }
                _oPar = x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oDeliveryTimeRecord.active == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oDeliveryTimeRecord.active; }
                _oPar = x_oCmd.Parameters.Add("@pm8_10", global::System.Data.SqlDbType.Bit);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oDeliveryTimeRecord.pm8_10 == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oDeliveryTimeRecord.pm8_10; }
                _oPar = x_oCmd.Parameters.Add("@location", global::System.Data.SqlDbType.NVarChar, 100);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oDeliveryTimeRecord.location == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oDeliveryTimeRecord.location; }
                _oPar = x_oCmd.Parameters.Add("@pm7_9", global::System.Data.SqlDbType.Bit);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oDeliveryTimeRecord.pm7_9 == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oDeliveryTimeRecord.pm7_9; }
                _oPar = x_oCmd.Parameters.Add("@area", global::System.Data.SqlDbType.NVarChar, 100);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oDeliveryTimeRecord.area == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oDeliveryTimeRecord.area; }
                _oPar = x_oCmd.Parameters.Add("@pm6_8", global::System.Data.SqlDbType.Bit);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oDeliveryTimeRecord.pm6_8 == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oDeliveryTimeRecord.pm6_8; }
                _oPar = x_oCmd.Parameters.Add("@am", global::System.Data.SqlDbType.Bit);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oDeliveryTimeRecord.am == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oDeliveryTimeRecord.am; }
                _oPar = x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar, 50);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oDeliveryTimeRecord.did == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oDeliveryTimeRecord.did; }
                _oPar = x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oDeliveryTimeRecord.ddate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oDeliveryTimeRecord.ddate; }
                _oPar = x_oCmd.Parameters.Add("@pm", global::System.Data.SqlDbType.Bit);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oDeliveryTimeRecord.pm == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oDeliveryTimeRecord.pm; }
                _oPar = x_oCmd.Parameters.Add("@delivery_fee", global::System.Data.SqlDbType.Int);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oDeliveryTimeRecord.delivery_fee == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oDeliveryTimeRecord.delivery_fee; }
                _oPar = x_oCmd.Parameters.Add("@RETURN_ID", global::System.Data.SqlDbType.Int);
                _oPar.Direction = ParameterDirection.Output;
                x_oCmd.CommandType = CommandType.StoredProcedure;
                if (!x_oDB.bTransaction && x_oConn.State == ConnectionState.Closed) x_oConn.Open();
                _bResult = Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
                x_oLAST_ID = Int32.Parse(x_oCmd.Parameters["@RETURN_ID"].Value.ToString());
            }
            catch (Exception exp) { string _sError = exp.ToString(); }
            finally
            {
                if (!x_oDB.bTransaction)
                {
                    x_oConn.Close();
                    x_oCmd.Dispose();
                    x_oConn.Dispose();
                }
            }
            return _bResult;
        }

        #region INSERT_DELIVERYTIMERECORD Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2009-12-21>
        ///-- Description:	<Description,DELIVERYTIMERECORD, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_DELIVERYTIMERECORD Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_DELIVERYTIMERECORD', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_DELIVERYTIMERECORD;
        GO
        CREATE PROCEDURE INSERT_DELIVERYTIMERECORD
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @cdate datetime,
        @cid nvarchar(50),
        @active bit,
        @pm8_10 bit,
        @location nvarchar(100),
        @pm7_9 bit,
        @area nvarchar(100),
        @pm6_8 bit,
        @pm bit,
        @am bit,
        @ddate datetime,
        @did nvarchar(50),
        @delivery_fee int
        AS
        
        INSERT INTO  [DeliveryTimeRecord]   ([cdate],[cid],[active],[pm8_10],[location],[pm7_9],[area],[pm6_8],[am],[did],[ddate],[pm],[delivery_fee])  VALUES  (@cdate,@cid,@active,@pm8_10,@location,@pm7_9,@area,@pm6_8,@am,@did,@ddate,@pm,@delivery_fee)
        IF @@IDENTITY IS NOT NULL
        BEGIN
        SELECT @RETURN_ID=@@IDENTITY
        RETURN @RETURN_ID
        END
        ELSE
        BEGIN
        SET @RETURN_ID=-1
        RETURN @RETURN_ID
        END
        
        GO
        */
        #endregion

        #endregion

        #region Delete
        /// <summary>
        /// Summary description for management table deleting
        /// </summary>

        public bool Delete(global::System.Nullable<int> x_iId)
        {
            return DeleteProc(n_oDB, x_iId);
        }

        public static bool Delete(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            return DeleteProc(x_oDB, x_iId);
        }


        private static bool DeleteProc(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            if (x_iId == null) { return false; }
            string _sQuery = "DELETE FROM  [DeliveryTimeRecord]  WHERE [DeliveryTimeRecord].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DeliveryTimeRecord]", "[" + Configurator.MSSQLTablePrefix + "DeliveryTimeRecord]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult = false;
                _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = x_iId;
                try
                {
                    _oConn.Open();
                    _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
                }
                catch (Exception exp) { string _sError = exp.ToString(); }
                finally
                {
                    _oConn.Close();
                    _oCmd.Dispose();
                    _oConn.Dispose();
                }
                return _bResult;
            }
        }


        public bool DeleteAll()
        {
            if (n_oDB == null) { return false; }
            return DeliveryTimeRecordRepositoryBase.DeleteAll(n_oDB);
        }

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "DELETE FROM  [DeliveryTimeRecord]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DeliveryTimeRecord]", "[" + Configurator.MSSQLTablePrefix + "DeliveryTimeRecord]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult = false;
                try
                {
                    _oConn.Open();
                    _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
                }
                catch (Exception exp) { string _sError = exp.ToString(); }
                finally
                {
                    _oConn.Close();
                    _oCmd.Dispose();
                    _oConn.Dispose();
                }
                return _bResult;
            }
        }


        public bool DeleteFilter(string x_sFilter)
        {
            return DeleteFilter(n_oDB, x_sFilter);
        }

        public static bool DeleteFilter(MSSQLConnect x_oDB, string x_sFilter)
        {
            if (x_oDB == null) { return false; }
            if (!"".Equals(x_sFilter)) { x_sFilter = " WHERE " + x_sFilter; }
            string _sQuery = "DELETE FROM [DeliveryTimeRecord]" + x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DeliveryTimeRecord]", "[" + Configurator.MSSQLTablePrefix + "DeliveryTimeRecord]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult = false;
                try
                {
                    _oConn.Open();
                    _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
                }
                catch (Exception exp) { string _sError = exp.ToString(); }
                finally
                {
                    _oConn.Close();
                    _oCmd.Dispose();
                    _oConn.Dispose();
                }
                return _bResult;
            }
        }
        #endregion

        void global::System.IDisposable.Dispose()
        {
            this.Dispose();
        }
        public void Dispose()
        {
        }

    }
}

