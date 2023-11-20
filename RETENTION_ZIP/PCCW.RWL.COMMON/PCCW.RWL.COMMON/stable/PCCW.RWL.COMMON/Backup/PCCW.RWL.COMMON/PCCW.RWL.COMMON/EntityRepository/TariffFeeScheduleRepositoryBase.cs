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
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-11-17>
///-- Description:	<Description,Table :[TariffFeeSchedule],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [TariffFeeSchedule] Insert / list / delete manager layer
    /// </summary>

    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name = Configurator.MSSQLTablePrefix + "TariffFeeSchedule")]
    public class TariffFeeScheduleRepositoryBase : global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable
    {

        #region Instance
        private static TariffFeeScheduleRepositoryBase instance;
        public static TariffFeeScheduleRepositoryBase Instance()
        {
            if (instance == null)
            {
                MSSQLConnect _oDB = new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new TariffFeeScheduleRepositoryBase(_oDB);
            }
            return instance;
        }
        public static TariffFeeScheduleRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if (instance == null)
                instance = new TariffFeeScheduleRepositoryBase(x_oDB);
            return instance;
        }
        #endregion

        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<TariffFeeScheduleEntity> TariffFeeSchedules;
        #endregion

        #region Constructor
        public TariffFeeScheduleRepositoryBase(MSSQLConnect x_oDB)
            : base(x_oDB.ConnectionStr)
        {
            n_oDB = x_oDB;
        }
        ~TariffFeeScheduleRepositoryBase()
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
        public static TariffFeeSchedule CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new TariffFeeSchedule(_oDB);
        }

        public static TariffFeeSchedule CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new TariffFeeSchedule(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [TariffFeeSchedule]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[TariffFeeSchedule]", "[" + Configurator.MSSQLTablePrefix + "TariffFeeSchedule]"); }
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


        public TariffFeeScheduleEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }


        public static TariffFeeScheduleEntity GetObj(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            if (x_oDB == null) { return null; }
            TariffFeeSchedule _TariffFeeSchedule = (TariffFeeSchedule)TariffFeeScheduleRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_TariffFeeSchedule.Load(x_iId)) { return null; }
            return _TariffFeeSchedule;
        }



        public static TariffFeeScheduleEntity[] GetArrayObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            List<TariffFeeScheduleEntity> _oTariffFeeScheduleList = GetListObj(x_oDB, 0, "id", x_oArrayItemId);
            return _oTariffFeeScheduleList.Count == 0 ? null : _oTariffFeeScheduleList.ToArray();
        }

        public static List<TariffFeeScheduleEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB, 0, "id", x_oArrayItemId);
        }


        public static TariffFeeScheduleEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<TariffFeeScheduleEntity> _oTariffFeeScheduleList = GetListObj(x_oDB, 0, x_oColumnName, x_oArrayItemId);
            return _oTariffFeeScheduleList.Count == 0 ? null : _oTariffFeeScheduleList.ToArray();
        }


        public static TariffFeeScheduleEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<TariffFeeScheduleEntity> _oTariffFeeScheduleList = GetListObj(x_oDB, x_iTop, x_oColumnName, x_oArrayItemId);
            return _oTariffFeeScheduleList.Count == 0 ? null : _oTariffFeeScheduleList.ToArray();
        }

        public static List<TariffFeeScheduleEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB == null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            List<TariffFeeScheduleEntity> _oRow = new List<TariffFeeScheduleEntity>();
            string _sQuery = "SELECT  " + _sTop + " [TariffFeeSchedule].[id] AS TARIFFFEESCHEDULE_ID,[TariffFeeSchedule].[cdate] AS TARIFFFEESCHEDULE_CDATE,[TariffFeeSchedule].[cid] AS TARIFFFEESCHEDULE_CID,[TariffFeeSchedule].[active] AS TARIFFFEESCHEDULE_ACTIVE,[TariffFeeSchedule].[program] AS TARIFFFEESCHEDULE_PROGRAM,[TariffFeeSchedule].[ddate] AS TARIFFFEESCHEDULE_DDATE,[TariffFeeSchedule].[fee] AS TARIFFFEESCHEDULE_FEE,[TariffFeeSchedule].[org_fee] AS TARIFFFEESCHEDULE_ORG_FEE,[TariffFeeSchedule].[did] AS TARIFFFEESCHEDULE_DID  FROM  [TariffFeeSchedule]";
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
                _sQuery += " WHERE [TariffFeeSchedule].[" + x_oColumnName.ToString() + "]  in " + _oList;
            }

            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[TariffFeeSchedule]", "[" + Configurator.MSSQLTablePrefix + "TariffFeeSchedule]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        TariffFeeSchedule _oTariffFeeSchedule = TariffFeeScheduleRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_ID"])) { _oTariffFeeSchedule.id = (global::System.Nullable<int>)_oData["TARIFFFEESCHEDULE_ID"]; } else { _oTariffFeeSchedule.id = null; }
                        if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_CDATE"])) { _oTariffFeeSchedule.cdate = (global::System.Nullable<DateTime>)_oData["TARIFFFEESCHEDULE_CDATE"]; } else { _oTariffFeeSchedule.cdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_CID"])) { _oTariffFeeSchedule.cid = (string)_oData["TARIFFFEESCHEDULE_CID"]; } else { _oTariffFeeSchedule.cid = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_ACTIVE"])) { _oTariffFeeSchedule.active = (global::System.Nullable<bool>)_oData["TARIFFFEESCHEDULE_ACTIVE"]; } else { _oTariffFeeSchedule.active = null; }
                        if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_PROGRAM"])) { _oTariffFeeSchedule.program = (string)_oData["TARIFFFEESCHEDULE_PROGRAM"]; } else { _oTariffFeeSchedule.program = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_DDATE"])) { _oTariffFeeSchedule.ddate = (global::System.Nullable<DateTime>)_oData["TARIFFFEESCHEDULE_DDATE"]; } else { _oTariffFeeSchedule.ddate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_ORG_FEE"])) { _oTariffFeeSchedule.org_fee = (global::System.Nullable<int>)_oData["TARIFFFEESCHEDULE_ORG_FEE"]; } else { _oTariffFeeSchedule.org_fee = null; }
                        if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_DID"])) { _oTariffFeeSchedule.did = (string)_oData["TARIFFFEESCHEDULE_DID"]; } else { _oTariffFeeSchedule.did = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_FEE"])) { _oTariffFeeSchedule.fee = (string)_oData["TARIFFFEESCHEDULE_FEE"]; } else { _oTariffFeeSchedule.fee = global::System.String.Empty; }
                        _oTariffFeeSchedule.SetDB(x_oDB);
                        _oTariffFeeSchedule.GetFound();
                        _oRow.Add(_oTariffFeeSchedule);
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


        public static TariffFeeScheduleEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<TariffFeeScheduleEntity> _oTariffFeeScheduleList = GetListObj(x_oDB, 0, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oTariffFeeScheduleList.Count == 0 ? null : _oTariffFeeScheduleList.ToArray();
        }


        public static TariffFeeScheduleEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<TariffFeeScheduleEntity> _oTariffFeeScheduleList = GetListObj(x_oDB, x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oTariffFeeScheduleList.Count == 0 ? null : _oTariffFeeScheduleList.ToArray();
        }

        public static List<TariffFeeScheduleEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB == null) { return null; }
            List<TariffFeeScheduleEntity> _oRow = new List<TariffFeeScheduleEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            string _sFields = "[TariffFeeSchedule].[id] AS TARIFFFEESCHEDULE_ID,[TariffFeeSchedule].[cdate] AS TARIFFFEESCHEDULE_CDATE,[TariffFeeSchedule].[cid] AS TARIFFFEESCHEDULE_CID,[TariffFeeSchedule].[active] AS TARIFFFEESCHEDULE_ACTIVE,[TariffFeeSchedule].[program] AS TARIFFFEESCHEDULE_PROGRAM,[TariffFeeSchedule].[ddate] AS TARIFFFEESCHEDULE_DDATE,[TariffFeeSchedule].[fee] AS TARIFFFEESCHEDULE_FEE,[TariffFeeSchedule].[org_fee] AS TARIFFFEESCHEDULE_ORG_FEE,[TariffFeeSchedule].[did] AS TARIFFFEESCHEDULE_DID";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[TariffFeeSchedule]", "[" + Configurator.MSSQLTablePrefix + "TariffFeeSchedule]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = TariffFeeScheduleRepositoryBase.GetSearch(x_oDB, _sTop.ToString() + _sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                TariffFeeScheduleEntity _oTariffFeeSchedule = TariffFeeScheduleRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_ID"])) { _oTariffFeeSchedule.id = (global::System.Nullable<int>)_oData["TARIFFFEESCHEDULE_ID"]; } else { _oTariffFeeSchedule.id = null; }
                if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_CDATE"])) { _oTariffFeeSchedule.cdate = (global::System.Nullable<DateTime>)_oData["TARIFFFEESCHEDULE_CDATE"]; } else { _oTariffFeeSchedule.cdate = null; }
                if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_CID"])) { _oTariffFeeSchedule.cid = (string)_oData["TARIFFFEESCHEDULE_CID"]; } else { _oTariffFeeSchedule.cid = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_ACTIVE"])) { _oTariffFeeSchedule.active = (global::System.Nullable<bool>)_oData["TARIFFFEESCHEDULE_ACTIVE"]; } else { _oTariffFeeSchedule.active = null; }
                if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_PROGRAM"])) { _oTariffFeeSchedule.program = (string)_oData["TARIFFFEESCHEDULE_PROGRAM"]; } else { _oTariffFeeSchedule.program = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_DDATE"])) { _oTariffFeeSchedule.ddate = (global::System.Nullable<DateTime>)_oData["TARIFFFEESCHEDULE_DDATE"]; } else { _oTariffFeeSchedule.ddate = null; }
                if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_ORG_FEE"])) { _oTariffFeeSchedule.org_fee = (global::System.Nullable<int>)_oData["TARIFFFEESCHEDULE_ORG_FEE"]; } else { _oTariffFeeSchedule.org_fee = null; }
                if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_DID"])) { _oTariffFeeSchedule.did = (string)_oData["TARIFFFEESCHEDULE_DID"]; } else { _oTariffFeeSchedule.did = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_FEE"])) { _oTariffFeeSchedule.fee = (string)_oData["TARIFFFEESCHEDULE_FEE"]; } else { _oTariffFeeSchedule.fee = global::System.String.Empty; }
                _oTariffFeeSchedule.SetDB(x_oDB);
                _oTariffFeeSchedule.GetFound();
                _oRow.Add(_oTariffFeeSchedule);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet(TariffFeeSchedule.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder, TariffFeeSchedule.Para.TableName());
            return _oDset;
        }


        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB == null) { return null; }
            return x_oDB.GetSearch(TariffFeeSchedule.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }


        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(TariffFeeSchedule.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            if (x_oDB == null) { return null; }
            string _oQuery = "SELECT   [TariffFeeSchedule].[id] AS TARIFFFEESCHEDULE_ID,[TariffFeeSchedule].[cdate] AS TARIFFFEESCHEDULE_CDATE,[TariffFeeSchedule].[cid] AS TARIFFFEESCHEDULE_CID,[TariffFeeSchedule].[active] AS TARIFFFEESCHEDULE_ACTIVE,[TariffFeeSchedule].[program] AS TARIFFFEESCHEDULE_PROGRAM,[TariffFeeSchedule].[ddate] AS TARIFFFEESCHEDULE_DDATE,[TariffFeeSchedule].[fee] AS TARIFFFEESCHEDULE_FEE,[TariffFeeSchedule].[org_fee] AS TARIFFFEESCHEDULE_ORG_FEE,[TariffFeeSchedule].[did] AS TARIFFFEESCHEDULE_DID  FROM  [TariffFeeSchedule]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[TariffFeeSchedule]", "[" + Configurator.MSSQLTablePrefix + "TariffFeeSchedule]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery, _oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset, "TariffFeeSchedule");
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

        public bool Insert(global::System.Nullable<DateTime> x_dCdate, string x_sCid, global::System.Nullable<bool> x_bActive, string x_sProgram, global::System.Nullable<DateTime> x_dDdate, global::System.Nullable<int> x_iOrg_fee, string x_sDid, string x_sFee)
        {
            TariffFeeSchedule _oTariffFeeSchedule = TariffFeeScheduleRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oTariffFeeSchedule.cdate = x_dCdate;
            _oTariffFeeSchedule.cid = x_sCid;
            _oTariffFeeSchedule.active = x_bActive;
            _oTariffFeeSchedule.program = x_sProgram;
            _oTariffFeeSchedule.ddate = x_dDdate;
            _oTariffFeeSchedule.org_fee = x_iOrg_fee;
            _oTariffFeeSchedule.did = x_sDid;
            _oTariffFeeSchedule.fee = x_sFee;
            return InsertWithOutLastID(n_oDB, _oTariffFeeSchedule);
        }


        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate, string x_sCid, global::System.Nullable<bool> x_bActive, string x_sProgram, global::System.Nullable<DateTime> x_dDdate, global::System.Nullable<int> x_iOrg_fee, string x_sDid, string x_sFee)
        {
            TariffFeeSchedule _oTariffFeeSchedule = TariffFeeScheduleRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oTariffFeeSchedule.cdate = x_dCdate;
            _oTariffFeeSchedule.cid = x_sCid;
            _oTariffFeeSchedule.active = x_bActive;
            _oTariffFeeSchedule.program = x_sProgram;
            _oTariffFeeSchedule.ddate = x_dDdate;
            _oTariffFeeSchedule.org_fee = x_iOrg_fee;
            _oTariffFeeSchedule.did = x_sDid;
            _oTariffFeeSchedule.fee = x_sFee;
            return InsertWithOutLastID(x_oDB, _oTariffFeeSchedule);
        }


        public bool Insert(TariffFeeSchedule x_oTariffFeeSchedule)
        {
            return InsertWithOutLastID(n_oDB, x_oTariffFeeSchedule);
        }


        public bool InsertEntity(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is TariffFeeSchedule)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (TariffFeeSchedule)x_oObj);
        }


        public static bool Insert(MSSQLConnect x_oDB, TariffFeeSchedule x_oTariffFeeSchedule)
        {
            return InsertWithOutLastID(x_oDB, x_oTariffFeeSchedule);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, TariffFeeSchedule x_oTariffFeeSchedule)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT INTO  [TariffFeeSchedule]   ([cdate],[cid],[active],[program],[ddate],[fee],[org_fee],[did])  VALUES  (@cdate,@cid,@active,@program,@ddate,@fee,@org_fee,@did)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[TariffFeeSchedule]", "[" + Configurator.MSSQLTablePrefix + "TariffFeeSchedule]"); }
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
            return InsertTransactionWithOutLastID(x_oDB, _oConn, _oCmd, x_oTariffFeeSchedule);
        }

        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, TariffFeeSchedule x_oTariffFeeSchedule)
        {
            bool _bResult = false;
            if (!x_oTariffFeeSchedule.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if (x_oTariffFeeSchedule.cdate == null) { x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = x_oTariffFeeSchedule.cdate; }
                if (x_oTariffFeeSchedule.cid == null) { x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10).Value = x_oTariffFeeSchedule.cid; }
                if (x_oTariffFeeSchedule.active == null) { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = x_oTariffFeeSchedule.active; }
                if (x_oTariffFeeSchedule.program == null) { x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar, 50).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar, 50).Value = x_oTariffFeeSchedule.program; }
                if (x_oTariffFeeSchedule.ddate == null) { x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = x_oTariffFeeSchedule.ddate; }
                if (x_oTariffFeeSchedule.fee == null) { x_oCmd.Parameters.Add("@fee", global::System.Data.SqlDbType.NVarChar, 50).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@fee", global::System.Data.SqlDbType.NVarChar, 50).Value = x_oTariffFeeSchedule.fee; }
                if (x_oTariffFeeSchedule.org_fee == null) { x_oCmd.Parameters.Add("@org_fee", global::System.Data.SqlDbType.Int).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@org_fee", global::System.Data.SqlDbType.Int).Value = x_oTariffFeeSchedule.org_fee; }
                if (x_oTariffFeeSchedule.did == null) { x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10).Value = x_oTariffFeeSchedule.did; }
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


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate, string x_sCid, global::System.Nullable<bool> x_bActive, string x_sProgram, global::System.Nullable<DateTime> x_dDdate, global::System.Nullable<int> x_iOrg_fee, string x_sDid, string x_sFee)
        {
            int _oLastID;
            TariffFeeSchedule _oTariffFeeSchedule = TariffFeeScheduleRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oTariffFeeSchedule.cdate = x_dCdate;
            _oTariffFeeSchedule.cid = x_sCid;
            _oTariffFeeSchedule.active = x_bActive;
            _oTariffFeeSchedule.program = x_sProgram;
            _oTariffFeeSchedule.ddate = x_dDdate;
            _oTariffFeeSchedule.org_fee = x_iOrg_fee;
            _oTariffFeeSchedule.did = x_sDid;
            _oTariffFeeSchedule.fee = x_sFee;
            if (InsertWithLastID_SP(x_oDB, _oTariffFeeSchedule, out _oLastID))
            {
                return _oLastID;
            }
            else
            {
                return -1;
            }
        }


        public int InsertReturnLastID_SP(TariffFeeSchedule x_oTariffFeeSchedule)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oTariffFeeSchedule, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, TariffFeeSchedule x_oTariffFeeSchedule)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oTariffFeeSchedule, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is TariffFeeSchedule)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (TariffFeeSchedule)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB, TariffFeeSchedule x_oTariffFeeSchedule, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "TARIFFFEESCHEDULE";
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
            return InsertTransactionWithLastID_SP(x_oDB, _oConn, _oCmd, x_oTariffFeeSchedule, out x_oLAST_ID);
        }

        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, TariffFeeSchedule x_oTariffFeeSchedule, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar = x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oTariffFeeSchedule.cdate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oTariffFeeSchedule.cdate; }
                _oPar = x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oTariffFeeSchedule.cid == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oTariffFeeSchedule.cid; }
                _oPar = x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oTariffFeeSchedule.active == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oTariffFeeSchedule.active; }
                _oPar = x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar, 50);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oTariffFeeSchedule.program == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oTariffFeeSchedule.program; }
                _oPar = x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oTariffFeeSchedule.ddate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oTariffFeeSchedule.ddate; }
                _oPar = x_oCmd.Parameters.Add("@fee", global::System.Data.SqlDbType.NVarChar, 50);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oTariffFeeSchedule.fee == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oTariffFeeSchedule.fee; }
                _oPar = x_oCmd.Parameters.Add("@org_fee", global::System.Data.SqlDbType.Int);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oTariffFeeSchedule.org_fee == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oTariffFeeSchedule.org_fee; }
                _oPar = x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oTariffFeeSchedule.did == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oTariffFeeSchedule.did; }
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

        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            return -1;
        }

        #region INSERT_TARIFFFEESCHEDULE Store Procedures
        ///-- =============================================
        ///-- Author:		<Author,Philip SW>
        ///-- Create date: <Create Date 2009-11-17>
        ///-- Description:	<Description,TARIFFFEESCHEDULE, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_TARIFFFEESCHEDULE Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_TARIFFFEESCHEDULE', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_TARIFFFEESCHEDULE;
        GO
        CREATE PROCEDURE INSERT_TARIFFFEESCHEDULE
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @cdate datetime,
        @cid char(10),
        @active bit,
        @program nvarchar(50),
        @ddate datetime,
        @org_fee int,
        @did char(10),
        @fee nvarchar(50)
        AS
        
        INSERT INTO  [TariffFeeSchedule]   ([cdate],[cid],[active],[program],[ddate],[fee],[org_fee],[did])  VALUES  (@cdate,@cid,@active,@program,@ddate,@fee,@org_fee,@did)
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
            string _sQuery = "DELETE FROM  [TariffFeeSchedule]  WHERE [TariffFeeSchedule].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[TariffFeeSchedule]", "[" + Configurator.MSSQLTablePrefix + "TariffFeeSchedule]"); }
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
            return TariffFeeScheduleRepositoryBase.DeleteAll(n_oDB);
        }

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "DELETE FROM  [TariffFeeSchedule]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[TariffFeeSchedule]", "[" + Configurator.MSSQLTablePrefix + "TariffFeeSchedule]"); }
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
            string _sQuery = "DELETE FROM [TariffFeeSchedule]" + x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[TariffFeeSchedule]", "[" + Configurator.MSSQLTablePrefix + "TariffFeeSchedule]"); }
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

