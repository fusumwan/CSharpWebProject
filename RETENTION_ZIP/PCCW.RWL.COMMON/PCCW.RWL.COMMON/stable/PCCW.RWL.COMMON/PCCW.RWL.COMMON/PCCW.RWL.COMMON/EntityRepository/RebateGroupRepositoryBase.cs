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
///-- Create date: <Create Date 2009-11-17>
///-- Description:	<Description,Table :[RebateGroup],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [RebateGroup] Insert / list / delete manager layer
    /// </summary>

    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name = Configurator.MSSQLTablePrefix + "RebateGroup")]
    public class RebateGroupRepositoryBase : global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable
    {

        #region Instance
        private static RebateGroupRepositoryBase instance;
        public static RebateGroupRepositoryBase Instance()
        {
            if (instance == null)
            {
                MSSQLConnect _oDB = new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new RebateGroupRepositoryBase(_oDB);
            }
            return instance;
        }
        public static RebateGroupRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if (instance == null)
                instance = new RebateGroupRepositoryBase(x_oDB);
            return instance;
        }
        #endregion

        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<RebateGroupEntity> RebateGroups;
        #endregion

        #region Constructor
        public RebateGroupRepositoryBase(MSSQLConnect x_oDB)
            : base(x_oDB.ConnectionStr)
        {
            n_oDB = x_oDB;
        }
        ~RebateGroupRepositoryBase()
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
        public static RebateGroup CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new RebateGroup(_oDB);
        }

        public static RebateGroup CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new RebateGroup(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [RebateGroup]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RebateGroup]", "[" + Configurator.MSSQLTablePrefix + "RebateGroup]"); }
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


        public RebateGroupEntity GetObj(global::System.Nullable<int> x_iMid)
        {
            return GetObj(n_oDB, x_iMid);
        }


        public static RebateGroupEntity GetObj(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            if (x_oDB == null) { return null; }
            RebateGroup _RebateGroup = (RebateGroup)RebateGroupRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_RebateGroup.Load(x_iMid)) { return null; }
            return _RebateGroup;
        }



        public static RebateGroupEntity[] GetArrayObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            List<RebateGroupEntity> _oRebateGroupList = GetListObj(x_oDB, 0, "mid", x_oArrayItemId);
            return _oRebateGroupList.Count == 0 ? null : _oRebateGroupList.ToArray();
        }

        public static List<RebateGroupEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB, 0, "mid", x_oArrayItemId);
        }


        public static RebateGroupEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<RebateGroupEntity> _oRebateGroupList = GetListObj(x_oDB, 0, x_oColumnName, x_oArrayItemId);
            return _oRebateGroupList.Count == 0 ? null : _oRebateGroupList.ToArray();
        }


        public static RebateGroupEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<RebateGroupEntity> _oRebateGroupList = GetListObj(x_oDB, x_iTop, x_oColumnName, x_oArrayItemId);
            return _oRebateGroupList.Count == 0 ? null : _oRebateGroupList.ToArray();
        }

        public static List<RebateGroupEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB == null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            List<RebateGroupEntity> _oRow = new List<RebateGroupEntity>();
            string _sQuery = "SELECT  " + _sTop + " [RebateGroup].[active] AS REBATEGROUP_ACTIVE,[RebateGroup].[cdate] AS REBATEGROUP_CDATE,[RebateGroup].[cid] AS REBATEGROUP_CID,[RebateGroup].[did] AS REBATEGROUP_DID,[RebateGroup].[program] AS REBATEGROUP_PROGRAM,[RebateGroup].[ddate] AS REBATEGROUP_DDATE,[RebateGroup].[gp] AS REBATEGROUP_GP,[RebateGroup].[mid] AS REBATEGROUP_MID  FROM  [RebateGroup]";
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
                _sQuery += " WHERE [RebateGroup].[" + x_oColumnName.ToString() + "]  in " + _oList;
            }

            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RebateGroup]", "[" + Configurator.MSSQLTablePrefix + "RebateGroup]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        RebateGroup _oRebateGroup = RebateGroupRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["REBATEGROUP_ACTIVE"])) { _oRebateGroup.active = (global::System.Nullable<bool>)_oData["REBATEGROUP_ACTIVE"]; } else { _oRebateGroup.active = null; }
                        if (!global::System.Convert.IsDBNull(_oData["REBATEGROUP_CDATE"])) { _oRebateGroup.cdate = (global::System.Nullable<DateTime>)_oData["REBATEGROUP_CDATE"]; } else { _oRebateGroup.cdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["REBATEGROUP_CID"])) { _oRebateGroup.cid = (string)_oData["REBATEGROUP_CID"]; } else { _oRebateGroup.cid = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["REBATEGROUP_DID"])) { _oRebateGroup.did = (string)_oData["REBATEGROUP_DID"]; } else { _oRebateGroup.did = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["REBATEGROUP_GP"])) { _oRebateGroup.gp = (string)_oData["REBATEGROUP_GP"]; } else { _oRebateGroup.gp = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["REBATEGROUP_PROGRAM"])) { _oRebateGroup.program = (string)_oData["REBATEGROUP_PROGRAM"]; } else { _oRebateGroup.program = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["REBATEGROUP_DDATE"])) { _oRebateGroup.ddate = (global::System.Nullable<DateTime>)_oData["REBATEGROUP_DDATE"]; } else { _oRebateGroup.ddate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["REBATEGROUP_MID"])) { _oRebateGroup.mid = (global::System.Nullable<int>)_oData["REBATEGROUP_MID"]; } else { _oRebateGroup.mid = null; }
                        _oRebateGroup.SetDB(x_oDB);
                        _oRebateGroup.GetFound();
                        _oRow.Add(_oRebateGroup);
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


        public static RebateGroupEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<RebateGroupEntity> _oRebateGroupList = GetListObj(x_oDB, 0, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oRebateGroupList.Count == 0 ? null : _oRebateGroupList.ToArray();
        }


        public static RebateGroupEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<RebateGroupEntity> _oRebateGroupList = GetListObj(x_oDB, x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oRebateGroupList.Count == 0 ? null : _oRebateGroupList.ToArray();
        }

        public static List<RebateGroupEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB == null) { return null; }
            List<RebateGroupEntity> _oRow = new List<RebateGroupEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            string _sFields = "[RebateGroup].[active] AS REBATEGROUP_ACTIVE,[RebateGroup].[cdate] AS REBATEGROUP_CDATE,[RebateGroup].[cid] AS REBATEGROUP_CID,[RebateGroup].[did] AS REBATEGROUP_DID,[RebateGroup].[program] AS REBATEGROUP_PROGRAM,[RebateGroup].[ddate] AS REBATEGROUP_DDATE,[RebateGroup].[gp] AS REBATEGROUP_GP,[RebateGroup].[mid] AS REBATEGROUP_MID";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[RebateGroup]", "[" + Configurator.MSSQLTablePrefix + "RebateGroup]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = RebateGroupRepositoryBase.GetSearch(x_oDB, _sTop.ToString() + _sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                RebateGroupEntity _oRebateGroup = RebateGroupRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["REBATEGROUP_ACTIVE"])) { _oRebateGroup.active = (global::System.Nullable<bool>)_oData["REBATEGROUP_ACTIVE"]; } else { _oRebateGroup.active = null; }
                if (!global::System.Convert.IsDBNull(_oData["REBATEGROUP_CDATE"])) { _oRebateGroup.cdate = (global::System.Nullable<DateTime>)_oData["REBATEGROUP_CDATE"]; } else { _oRebateGroup.cdate = null; }
                if (!global::System.Convert.IsDBNull(_oData["REBATEGROUP_CID"])) { _oRebateGroup.cid = (string)_oData["REBATEGROUP_CID"]; } else { _oRebateGroup.cid = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["REBATEGROUP_DID"])) { _oRebateGroup.did = (string)_oData["REBATEGROUP_DID"]; } else { _oRebateGroup.did = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["REBATEGROUP_GP"])) { _oRebateGroup.gp = (string)_oData["REBATEGROUP_GP"]; } else { _oRebateGroup.gp = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["REBATEGROUP_PROGRAM"])) { _oRebateGroup.program = (string)_oData["REBATEGROUP_PROGRAM"]; } else { _oRebateGroup.program = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["REBATEGROUP_DDATE"])) { _oRebateGroup.ddate = (global::System.Nullable<DateTime>)_oData["REBATEGROUP_DDATE"]; } else { _oRebateGroup.ddate = null; }
                if (!global::System.Convert.IsDBNull(_oData["REBATEGROUP_MID"])) { _oRebateGroup.mid = (global::System.Nullable<int>)_oData["REBATEGROUP_MID"]; } else { _oRebateGroup.mid = null; }
                _oRebateGroup.SetDB(x_oDB);
                _oRebateGroup.GetFound();
                _oRow.Add(_oRebateGroup);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet(RebateGroup.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder, RebateGroup.Para.TableName());
            return _oDset;
        }


        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB == null) { return null; }
            return x_oDB.GetSearch(RebateGroup.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }


        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(RebateGroup.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            if (x_oDB == null) { return null; }
            string _oQuery = "SELECT   [RebateGroup].[active] AS REBATEGROUP_ACTIVE,[RebateGroup].[cdate] AS REBATEGROUP_CDATE,[RebateGroup].[cid] AS REBATEGROUP_CID,[RebateGroup].[did] AS REBATEGROUP_DID,[RebateGroup].[program] AS REBATEGROUP_PROGRAM,[RebateGroup].[ddate] AS REBATEGROUP_DDATE,[RebateGroup].[gp] AS REBATEGROUP_GP,[RebateGroup].[mid] AS REBATEGROUP_MID  FROM  [RebateGroup]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[RebateGroup]", "[" + Configurator.MSSQLTablePrefix + "RebateGroup]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery, _oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset, "RebateGroup");
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

        public bool Insert(global::System.Nullable<bool> x_bActive, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sDid, string x_sGp, string x_sProgram, global::System.Nullable<DateTime> x_dDdate)
        {
            RebateGroup _oRebateGroup = RebateGroupRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oRebateGroup.active = x_bActive;
            _oRebateGroup.cdate = x_dCdate;
            _oRebateGroup.cid = x_sCid;
            _oRebateGroup.did = x_sDid;
            _oRebateGroup.gp = x_sGp;
            _oRebateGroup.program = x_sProgram;
            _oRebateGroup.ddate = x_dDdate;
            return InsertWithOutLastID(n_oDB, _oRebateGroup);
        }


        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bActive, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sDid, string x_sGp, string x_sProgram, global::System.Nullable<DateTime> x_dDdate)
        {
            RebateGroup _oRebateGroup = RebateGroupRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oRebateGroup.active = x_bActive;
            _oRebateGroup.cdate = x_dCdate;
            _oRebateGroup.cid = x_sCid;
            _oRebateGroup.did = x_sDid;
            _oRebateGroup.gp = x_sGp;
            _oRebateGroup.program = x_sProgram;
            _oRebateGroup.ddate = x_dDdate;
            return InsertWithOutLastID(x_oDB, _oRebateGroup);
        }


        public bool Insert(RebateGroup x_oRebateGroup)
        {
            return InsertWithOutLastID(n_oDB, x_oRebateGroup);
        }


        public bool InsertEntity(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is RebateGroup)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (RebateGroup)x_oObj);
        }


        public static bool Insert(MSSQLConnect x_oDB, RebateGroup x_oRebateGroup)
        {
            return InsertWithOutLastID(x_oDB, x_oRebateGroup);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, RebateGroup x_oRebateGroup)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT INTO  [RebateGroup]   ([active],[cdate],[cid],[did],[program],[ddate],[gp])  VALUES  (@active,@cdate,@cid,@did,@program,@ddate,@gp)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RebateGroup]", "[" + Configurator.MSSQLTablePrefix + "RebateGroup]"); }
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
            return InsertTransactionWithOutLastID(x_oDB, _oConn, _oCmd, x_oRebateGroup);
        }

        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, RebateGroup x_oRebateGroup)
        {
            bool _bResult = false;
            if (!x_oRebateGroup.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if (x_oRebateGroup.active == null) { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = x_oRebateGroup.active; }
                if (x_oRebateGroup.cdate == null) { x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = x_oRebateGroup.cdate; }
                if (x_oRebateGroup.cid == null) { x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10).Value = x_oRebateGroup.cid; }
                if (x_oRebateGroup.did == null) { x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10).Value = x_oRebateGroup.did; }
                if (x_oRebateGroup.program == null) { x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar, 100).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar, 100).Value = x_oRebateGroup.program; }
                if (x_oRebateGroup.ddate == null) { x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = x_oRebateGroup.ddate; }
                if (x_oRebateGroup.gp == null) { x_oCmd.Parameters.Add("@gp", global::System.Data.SqlDbType.NVarChar, 20).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@gp", global::System.Data.SqlDbType.NVarChar, 20).Value = x_oRebateGroup.gp; }
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


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bActive, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sDid, string x_sGp, string x_sProgram, global::System.Nullable<DateTime> x_dDdate)
        {
            int _oLastID;
            RebateGroup _oRebateGroup = RebateGroupRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oRebateGroup.active = x_bActive;
            _oRebateGroup.cdate = x_dCdate;
            _oRebateGroup.cid = x_sCid;
            _oRebateGroup.did = x_sDid;
            _oRebateGroup.gp = x_sGp;
            _oRebateGroup.program = x_sProgram;
            _oRebateGroup.ddate = x_dDdate;
            if (InsertWithLastID_SP(x_oDB, _oRebateGroup, out _oLastID))
            {
                return _oLastID;
            }
            else
            {
                return -1;
            }
        }


        public int InsertReturnLastID_SP(RebateGroup x_oRebateGroup)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oRebateGroup, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, RebateGroup x_oRebateGroup)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oRebateGroup, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is RebateGroup)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (RebateGroup)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB, RebateGroup x_oRebateGroup, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "REBATEGROUP";
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
            return InsertTransactionWithLastID_SP(x_oDB, _oConn, _oCmd, x_oRebateGroup, out x_oLAST_ID);
        }

        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, RebateGroup x_oRebateGroup, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar = x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oRebateGroup.active == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oRebateGroup.active; }
                _oPar = x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oRebateGroup.cdate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oRebateGroup.cdate; }
                _oPar = x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oRebateGroup.cid == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oRebateGroup.cid; }
                _oPar = x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oRebateGroup.did == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oRebateGroup.did; }
                _oPar = x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar, 100);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oRebateGroup.program == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oRebateGroup.program; }
                _oPar = x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oRebateGroup.ddate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oRebateGroup.ddate; }
                _oPar = x_oCmd.Parameters.Add("@gp", global::System.Data.SqlDbType.NVarChar, 20);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oRebateGroup.gp == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oRebateGroup.gp; }
                _oPar = x_oCmd.Parameters.Add("@RETURN_MID", global::System.Data.SqlDbType.Int);
                _oPar.Direction = ParameterDirection.Output;
                x_oCmd.CommandType = CommandType.StoredProcedure;
                if (!x_oDB.bTransaction && x_oConn.State == ConnectionState.Closed) x_oConn.Open();
                _bResult = Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
                x_oLAST_ID = Int32.Parse(x_oCmd.Parameters["@RETURN_MID"].Value.ToString());
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

        #region INSERT_REBATEGROUP Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2009-11-17>
        ///-- Description:	<Description,REBATEGROUP, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_REBATEGROUP Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_REBATEGROUP', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_REBATEGROUP;
        GO
        CREATE PROCEDURE INSERT_REBATEGROUP
        	-- Add the parameters for the stored procedure here
        @RETURN_MID int output,
        @active bit,
        @cdate datetime,
        @cid char(10),
        @did char(10),
        @gp nvarchar(20),
        @program nvarchar(100),
        @ddate datetime
        AS
        
        INSERT INTO  [RebateGroup]   ([active],[cdate],[cid],[did],[program],[ddate],[gp])  VALUES  (@active,@cdate,@cid,@did,@program,@ddate,@gp)
        IF @@IDENTITY IS NOT NULL
        BEGIN
        SELECT @RETURN_MID=@@IDENTITY
        RETURN @RETURN_MID
        END
        ELSE
        BEGIN
        SET @RETURN_MID=-1
        RETURN @RETURN_MID
        END
        
        GO
        */
        #endregion

        #endregion

        #region Delete
        /// <summary>
        /// Summary description for management table deleting
        /// </summary>

        public bool Delete(global::System.Nullable<int> x_iMid)
        {
            return DeleteProc(n_oDB, x_iMid);
        }

        public static bool Delete(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            return DeleteProc(x_oDB, x_iMid);
        }


        private static bool DeleteProc(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            if (x_iMid == null) { return false; }
            string _sQuery = "DELETE FROM  [RebateGroup]  WHERE [RebateGroup].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RebateGroup]", "[" + Configurator.MSSQLTablePrefix + "RebateGroup]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult = false;
                _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value = x_iMid;
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
            return RebateGroupRepositoryBase.DeleteAll(n_oDB);
        }

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "DELETE FROM  [RebateGroup]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RebateGroup]", "[" + Configurator.MSSQLTablePrefix + "RebateGroup]"); }
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
            string _sQuery = "DELETE FROM [RebateGroup]" + x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RebateGroup]", "[" + Configurator.MSSQLTablePrefix + "RebateGroup]"); }
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

