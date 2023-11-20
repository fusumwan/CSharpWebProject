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
///-- Description:	<Description,Table :[RetentionProgramKey],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [RetentionProgramKey] Insert / list / delete manager layer
    /// </summary>

    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name = Configurator.MSSQLTablePrefix + "RetentionProgramKey")]
    public class RetentionProgramKeyRepositoryBase : global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable
    {

        #region Instance
        private static RetentionProgramKeyRepositoryBase instance;
        public static RetentionProgramKeyRepositoryBase Instance()
        {
            if (instance == null)
            {
                MSSQLConnect _oDB = new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new RetentionProgramKeyRepositoryBase(_oDB);
            }
            return instance;
        }
        public static RetentionProgramKeyRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if (instance == null)
                instance = new RetentionProgramKeyRepositoryBase(x_oDB);
            return instance;
        }
        #endregion

        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<RetentionProgramKeyEntity> RetentionProgramKeys;
        #endregion

        #region Constructor
        public RetentionProgramKeyRepositoryBase(MSSQLConnect x_oDB)
            : base(x_oDB.ConnectionStr)
        {
            n_oDB = x_oDB;
        }
        ~RetentionProgramKeyRepositoryBase()
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
        public static RetentionProgramKey CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new RetentionProgramKey(_oDB);
        }

        public static RetentionProgramKey CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new RetentionProgramKey(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [RetentionProgramKey]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RetentionProgramKey]", "[" + Configurator.MSSQLTablePrefix + "RetentionProgramKey]"); }
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


        public RetentionProgramKeyEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }


        public static RetentionProgramKeyEntity GetObj(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            if (x_oDB == null) { return null; }
            RetentionProgramKey _RetentionProgramKey = (RetentionProgramKey)RetentionProgramKeyRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_RetentionProgramKey.Load(x_iId)) { return null; }
            return _RetentionProgramKey;
        }



        public static RetentionProgramKeyEntity[] GetArrayObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            List<RetentionProgramKeyEntity> _oRetentionProgramKeyList = GetListObj(x_oDB, 0, "id", x_oArrayItemId);
            return _oRetentionProgramKeyList.Count == 0 ? null : _oRetentionProgramKeyList.ToArray();
        }

        public static List<RetentionProgramKeyEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB, 0, "id", x_oArrayItemId);
        }


        public static RetentionProgramKeyEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<RetentionProgramKeyEntity> _oRetentionProgramKeyList = GetListObj(x_oDB, 0, x_oColumnName, x_oArrayItemId);
            return _oRetentionProgramKeyList.Count == 0 ? null : _oRetentionProgramKeyList.ToArray();
        }


        public static RetentionProgramKeyEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<RetentionProgramKeyEntity> _oRetentionProgramKeyList = GetListObj(x_oDB, x_iTop, x_oColumnName, x_oArrayItemId);
            return _oRetentionProgramKeyList.Count == 0 ? null : _oRetentionProgramKeyList.ToArray();
        }

        public static List<RetentionProgramKeyEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB == null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            List<RetentionProgramKeyEntity> _oRow = new List<RetentionProgramKeyEntity>();
            string _sQuery = "SELECT  " + _sTop + " [RetentionProgramKey].[type] AS RETENTIONPROGRAMKEY_TYPE,[RetentionProgramKey].[call_list_type] AS RETENTIONPROGRAMKEY_CALL_LIST_TYPE,[RetentionProgramKey].[cdate] AS RETENTIONPROGRAMKEY_CDATE,[RetentionProgramKey].[cid] AS RETENTIONPROGRAMKEY_CID,[RetentionProgramKey].[did] AS RETENTIONPROGRAMKEY_DID,[RetentionProgramKey].[return_date] AS RETENTIONPROGRAMKEY_RETURN_DATE,[RetentionProgramKey].[edate] AS RETENTIONPROGRAMKEY_EDATE,[RetentionProgramKey].[active] AS RETENTIONPROGRAMKEY_ACTIVE,[RetentionProgramKey].[expiry_month] AS RETENTIONPROGRAMKEY_EXPIRY_MONTH,[RetentionProgramKey].[upload_date] AS RETENTIONPROGRAMKEY_UPLOAD_DATE,[RetentionProgramKey].[ddate] AS RETENTIONPROGRAMKEY_DDATE,[RetentionProgramKey].[call_list_size] AS RETENTIONPROGRAMKEY_CALL_LIST_SIZE,[RetentionProgramKey].[center] AS RETENTIONPROGRAMKEY_CENTER,[RetentionProgramKey].[id] AS RETENTIONPROGRAMKEY_ID,[RetentionProgramKey].[program_name] AS RETENTIONPROGRAMKEY_PROGRAM_NAME,[RetentionProgramKey].[program_id] AS RETENTIONPROGRAMKEY_PROGRAM_ID,[RetentionProgramKey].[remarks] AS RETENTIONPROGRAMKEY_REMARKS,[RetentionProgramKey].[sdate] AS RETENTIONPROGRAMKEY_SDATE  FROM  [RetentionProgramKey]";
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
                _sQuery += " WHERE [RetentionProgramKey].[" + x_oColumnName.ToString() + "]  in " + _oList;
            }

            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RetentionProgramKey]", "[" + Configurator.MSSQLTablePrefix + "RetentionProgramKey]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        RetentionProgramKey _oRetentionProgramKey = RetentionProgramKeyRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_TYPE"])) { _oRetentionProgramKey.type = (string)_oData["RETENTIONPROGRAMKEY_TYPE"]; } else { _oRetentionProgramKey.type = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_CALL_LIST_TYPE"])) { _oRetentionProgramKey.call_list_type = (string)_oData["RETENTIONPROGRAMKEY_CALL_LIST_TYPE"]; } else { _oRetentionProgramKey.call_list_type = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_CDATE"])) { _oRetentionProgramKey.cdate = (global::System.Nullable<DateTime>)_oData["RETENTIONPROGRAMKEY_CDATE"]; } else { _oRetentionProgramKey.cdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_CID"])) { _oRetentionProgramKey.cid = (string)_oData["RETENTIONPROGRAMKEY_CID"]; } else { _oRetentionProgramKey.cid = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_DID"])) { _oRetentionProgramKey.did = (string)_oData["RETENTIONPROGRAMKEY_DID"]; } else { _oRetentionProgramKey.did = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_RETURN_DATE"])) { _oRetentionProgramKey.return_date = (global::System.Nullable<DateTime>)_oData["RETENTIONPROGRAMKEY_RETURN_DATE"]; } else { _oRetentionProgramKey.return_date = null; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_EDATE"])) { _oRetentionProgramKey.edate = (global::System.Nullable<DateTime>)_oData["RETENTIONPROGRAMKEY_EDATE"]; } else { _oRetentionProgramKey.edate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_ACTIVE"])) { _oRetentionProgramKey.active = (global::System.Nullable<bool>)_oData["RETENTIONPROGRAMKEY_ACTIVE"]; } else { _oRetentionProgramKey.active = null; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_CENTER"])) { _oRetentionProgramKey.center = (string)_oData["RETENTIONPROGRAMKEY_CENTER"]; } else { _oRetentionProgramKey.center = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_EXPIRY_MONTH"])) { _oRetentionProgramKey.expiry_month = (string)_oData["RETENTIONPROGRAMKEY_EXPIRY_MONTH"]; } else { _oRetentionProgramKey.expiry_month = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_UPLOAD_DATE"])) { _oRetentionProgramKey.upload_date = (global::System.Nullable<DateTime>)_oData["RETENTIONPROGRAMKEY_UPLOAD_DATE"]; } else { _oRetentionProgramKey.upload_date = null; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_CALL_LIST_SIZE"])) { _oRetentionProgramKey.call_list_size = (string)_oData["RETENTIONPROGRAMKEY_CALL_LIST_SIZE"]; } else { _oRetentionProgramKey.call_list_size = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_DDATE"])) { _oRetentionProgramKey.ddate = (global::System.Nullable<DateTime>)_oData["RETENTIONPROGRAMKEY_DDATE"]; } else { _oRetentionProgramKey.ddate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_ID"])) { _oRetentionProgramKey.id = (global::System.Nullable<int>)_oData["RETENTIONPROGRAMKEY_ID"]; } else { _oRetentionProgramKey.id = null; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_PROGRAM_NAME"])) { _oRetentionProgramKey.program_name = (string)_oData["RETENTIONPROGRAMKEY_PROGRAM_NAME"]; } else { _oRetentionProgramKey.program_name = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_PROGRAM_ID"])) { _oRetentionProgramKey.program_id = (global::System.Nullable<int>)_oData["RETENTIONPROGRAMKEY_PROGRAM_ID"]; } else { _oRetentionProgramKey.program_id = null; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_REMARKS"])) { _oRetentionProgramKey.remarks = (string)_oData["RETENTIONPROGRAMKEY_REMARKS"]; } else { _oRetentionProgramKey.remarks = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_SDATE"])) { _oRetentionProgramKey.sdate = (global::System.Nullable<DateTime>)_oData["RETENTIONPROGRAMKEY_SDATE"]; } else { _oRetentionProgramKey.sdate = null; }
                        _oRetentionProgramKey.SetDB(x_oDB);
                        _oRetentionProgramKey.GetFound();
                        _oRow.Add(_oRetentionProgramKey);
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


        public static RetentionProgramKeyEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<RetentionProgramKeyEntity> _oRetentionProgramKeyList = GetListObj(x_oDB, 0, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oRetentionProgramKeyList.Count == 0 ? null : _oRetentionProgramKeyList.ToArray();
        }


        public static RetentionProgramKeyEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<RetentionProgramKeyEntity> _oRetentionProgramKeyList = GetListObj(x_oDB, x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oRetentionProgramKeyList.Count == 0 ? null : _oRetentionProgramKeyList.ToArray();
        }

        public static List<RetentionProgramKeyEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB == null) { return null; }
            List<RetentionProgramKeyEntity> _oRow = new List<RetentionProgramKeyEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            string _sFields = "[RetentionProgramKey].[type] AS RETENTIONPROGRAMKEY_TYPE,[RetentionProgramKey].[call_list_type] AS RETENTIONPROGRAMKEY_CALL_LIST_TYPE,[RetentionProgramKey].[cdate] AS RETENTIONPROGRAMKEY_CDATE,[RetentionProgramKey].[cid] AS RETENTIONPROGRAMKEY_CID,[RetentionProgramKey].[did] AS RETENTIONPROGRAMKEY_DID,[RetentionProgramKey].[return_date] AS RETENTIONPROGRAMKEY_RETURN_DATE,[RetentionProgramKey].[edate] AS RETENTIONPROGRAMKEY_EDATE,[RetentionProgramKey].[active] AS RETENTIONPROGRAMKEY_ACTIVE,[RetentionProgramKey].[expiry_month] AS RETENTIONPROGRAMKEY_EXPIRY_MONTH,[RetentionProgramKey].[upload_date] AS RETENTIONPROGRAMKEY_UPLOAD_DATE,[RetentionProgramKey].[ddate] AS RETENTIONPROGRAMKEY_DDATE,[RetentionProgramKey].[call_list_size] AS RETENTIONPROGRAMKEY_CALL_LIST_SIZE,[RetentionProgramKey].[center] AS RETENTIONPROGRAMKEY_CENTER,[RetentionProgramKey].[id] AS RETENTIONPROGRAMKEY_ID,[RetentionProgramKey].[program_name] AS RETENTIONPROGRAMKEY_PROGRAM_NAME,[RetentionProgramKey].[program_id] AS RETENTIONPROGRAMKEY_PROGRAM_ID,[RetentionProgramKey].[remarks] AS RETENTIONPROGRAMKEY_REMARKS,[RetentionProgramKey].[sdate] AS RETENTIONPROGRAMKEY_SDATE";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[RetentionProgramKey]", "[" + Configurator.MSSQLTablePrefix + "RetentionProgramKey]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = RetentionProgramKeyRepositoryBase.GetSearch(x_oDB, _sTop.ToString() + _sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                RetentionProgramKeyEntity _oRetentionProgramKey = RetentionProgramKeyRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_TYPE"])) { _oRetentionProgramKey.type = (string)_oData["RETENTIONPROGRAMKEY_TYPE"]; } else { _oRetentionProgramKey.type = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_CALL_LIST_TYPE"])) { _oRetentionProgramKey.call_list_type = (string)_oData["RETENTIONPROGRAMKEY_CALL_LIST_TYPE"]; } else { _oRetentionProgramKey.call_list_type = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_CDATE"])) { _oRetentionProgramKey.cdate = (global::System.Nullable<DateTime>)_oData["RETENTIONPROGRAMKEY_CDATE"]; } else { _oRetentionProgramKey.cdate = null; }
                if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_CID"])) { _oRetentionProgramKey.cid = (string)_oData["RETENTIONPROGRAMKEY_CID"]; } else { _oRetentionProgramKey.cid = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_DID"])) { _oRetentionProgramKey.did = (string)_oData["RETENTIONPROGRAMKEY_DID"]; } else { _oRetentionProgramKey.did = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_RETURN_DATE"])) { _oRetentionProgramKey.return_date = (global::System.Nullable<DateTime>)_oData["RETENTIONPROGRAMKEY_RETURN_DATE"]; } else { _oRetentionProgramKey.return_date = null; }
                if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_EDATE"])) { _oRetentionProgramKey.edate = (global::System.Nullable<DateTime>)_oData["RETENTIONPROGRAMKEY_EDATE"]; } else { _oRetentionProgramKey.edate = null; }
                if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_ACTIVE"])) { _oRetentionProgramKey.active = (global::System.Nullable<bool>)_oData["RETENTIONPROGRAMKEY_ACTIVE"]; } else { _oRetentionProgramKey.active = null; }
                if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_CENTER"])) { _oRetentionProgramKey.center = (string)_oData["RETENTIONPROGRAMKEY_CENTER"]; } else { _oRetentionProgramKey.center = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_EXPIRY_MONTH"])) { _oRetentionProgramKey.expiry_month = (string)_oData["RETENTIONPROGRAMKEY_EXPIRY_MONTH"]; } else { _oRetentionProgramKey.expiry_month = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_UPLOAD_DATE"])) { _oRetentionProgramKey.upload_date = (global::System.Nullable<DateTime>)_oData["RETENTIONPROGRAMKEY_UPLOAD_DATE"]; } else { _oRetentionProgramKey.upload_date = null; }
                if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_CALL_LIST_SIZE"])) { _oRetentionProgramKey.call_list_size = (string)_oData["RETENTIONPROGRAMKEY_CALL_LIST_SIZE"]; } else { _oRetentionProgramKey.call_list_size = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_DDATE"])) { _oRetentionProgramKey.ddate = (global::System.Nullable<DateTime>)_oData["RETENTIONPROGRAMKEY_DDATE"]; } else { _oRetentionProgramKey.ddate = null; }
                if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_ID"])) { _oRetentionProgramKey.id = (global::System.Nullable<int>)_oData["RETENTIONPROGRAMKEY_ID"]; } else { _oRetentionProgramKey.id = null; }
                if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_PROGRAM_NAME"])) { _oRetentionProgramKey.program_name = (string)_oData["RETENTIONPROGRAMKEY_PROGRAM_NAME"]; } else { _oRetentionProgramKey.program_name = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_PROGRAM_ID"])) { _oRetentionProgramKey.program_id = (global::System.Nullable<int>)_oData["RETENTIONPROGRAMKEY_PROGRAM_ID"]; } else { _oRetentionProgramKey.program_id = null; }
                if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_REMARKS"])) { _oRetentionProgramKey.remarks = (string)_oData["RETENTIONPROGRAMKEY_REMARKS"]; } else { _oRetentionProgramKey.remarks = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["RETENTIONPROGRAMKEY_SDATE"])) { _oRetentionProgramKey.sdate = (global::System.Nullable<DateTime>)_oData["RETENTIONPROGRAMKEY_SDATE"]; } else { _oRetentionProgramKey.sdate = null; }
                _oRetentionProgramKey.SetDB(x_oDB);
                _oRetentionProgramKey.GetFound();
                _oRow.Add(_oRetentionProgramKey);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet(RetentionProgramKey.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder, RetentionProgramKey.Para.TableName());
            return _oDset;
        }


        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB == null) { return null; }
            return x_oDB.GetSearch(RetentionProgramKey.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }


        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(RetentionProgramKey.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            if (x_oDB == null) { return null; }
            string _oQuery = "SELECT   [RetentionProgramKey].[type] AS RETENTIONPROGRAMKEY_TYPE,[RetentionProgramKey].[call_list_type] AS RETENTIONPROGRAMKEY_CALL_LIST_TYPE,[RetentionProgramKey].[cdate] AS RETENTIONPROGRAMKEY_CDATE,[RetentionProgramKey].[cid] AS RETENTIONPROGRAMKEY_CID,[RetentionProgramKey].[did] AS RETENTIONPROGRAMKEY_DID,[RetentionProgramKey].[return_date] AS RETENTIONPROGRAMKEY_RETURN_DATE,[RetentionProgramKey].[edate] AS RETENTIONPROGRAMKEY_EDATE,[RetentionProgramKey].[active] AS RETENTIONPROGRAMKEY_ACTIVE,[RetentionProgramKey].[expiry_month] AS RETENTIONPROGRAMKEY_EXPIRY_MONTH,[RetentionProgramKey].[upload_date] AS RETENTIONPROGRAMKEY_UPLOAD_DATE,[RetentionProgramKey].[ddate] AS RETENTIONPROGRAMKEY_DDATE,[RetentionProgramKey].[call_list_size] AS RETENTIONPROGRAMKEY_CALL_LIST_SIZE,[RetentionProgramKey].[center] AS RETENTIONPROGRAMKEY_CENTER,[RetentionProgramKey].[id] AS RETENTIONPROGRAMKEY_ID,[RetentionProgramKey].[program_name] AS RETENTIONPROGRAMKEY_PROGRAM_NAME,[RetentionProgramKey].[program_id] AS RETENTIONPROGRAMKEY_PROGRAM_ID,[RetentionProgramKey].[remarks] AS RETENTIONPROGRAMKEY_REMARKS,[RetentionProgramKey].[sdate] AS RETENTIONPROGRAMKEY_SDATE  FROM  [RetentionProgramKey]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[RetentionProgramKey]", "[" + Configurator.MSSQLTablePrefix + "RetentionProgramKey]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery, _oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset, "RetentionProgramKey");
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

        public bool Insert(string x_sType, string x_sCall_list_type, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sDid, global::System.Nullable<DateTime> x_dReturn_date, global::System.Nullable<DateTime> x_dEdate, global::System.Nullable<bool> x_bActive, string x_sCenter, string x_sExpiry_month, global::System.Nullable<DateTime> x_dUpload_date, string x_sCall_list_size, global::System.Nullable<DateTime> x_dDdate, string x_sProgram_name, global::System.Nullable<int> x_iProgram_id, string x_sRemarks, global::System.Nullable<DateTime> x_dSdate)
        {
            RetentionProgramKey _oRetentionProgramKey = RetentionProgramKeyRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oRetentionProgramKey.type = x_sType;
            _oRetentionProgramKey.call_list_type = x_sCall_list_type;
            _oRetentionProgramKey.cdate = x_dCdate;
            _oRetentionProgramKey.cid = x_sCid;
            _oRetentionProgramKey.did = x_sDid;
            _oRetentionProgramKey.return_date = x_dReturn_date;
            _oRetentionProgramKey.edate = x_dEdate;
            _oRetentionProgramKey.active = x_bActive;
            _oRetentionProgramKey.center = x_sCenter;
            _oRetentionProgramKey.expiry_month = x_sExpiry_month;
            _oRetentionProgramKey.upload_date = x_dUpload_date;
            _oRetentionProgramKey.call_list_size = x_sCall_list_size;
            _oRetentionProgramKey.ddate = x_dDdate;
            _oRetentionProgramKey.program_name = x_sProgram_name;
            _oRetentionProgramKey.program_id = x_iProgram_id;
            _oRetentionProgramKey.remarks = x_sRemarks;
            _oRetentionProgramKey.sdate = x_dSdate;
            return InsertWithOutLastID(n_oDB, _oRetentionProgramKey);
        }


        public static bool Insert(MSSQLConnect x_oDB, string x_sType, string x_sCall_list_type, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sDid, global::System.Nullable<DateTime> x_dReturn_date, global::System.Nullable<DateTime> x_dEdate, global::System.Nullable<bool> x_bActive, string x_sCenter, string x_sExpiry_month, global::System.Nullable<DateTime> x_dUpload_date, string x_sCall_list_size, global::System.Nullable<DateTime> x_dDdate, string x_sProgram_name, global::System.Nullable<int> x_iProgram_id, string x_sRemarks, global::System.Nullable<DateTime> x_dSdate)
        {
            RetentionProgramKey _oRetentionProgramKey = RetentionProgramKeyRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oRetentionProgramKey.type = x_sType;
            _oRetentionProgramKey.call_list_type = x_sCall_list_type;
            _oRetentionProgramKey.cdate = x_dCdate;
            _oRetentionProgramKey.cid = x_sCid;
            _oRetentionProgramKey.did = x_sDid;
            _oRetentionProgramKey.return_date = x_dReturn_date;
            _oRetentionProgramKey.edate = x_dEdate;
            _oRetentionProgramKey.active = x_bActive;
            _oRetentionProgramKey.center = x_sCenter;
            _oRetentionProgramKey.expiry_month = x_sExpiry_month;
            _oRetentionProgramKey.upload_date = x_dUpload_date;
            _oRetentionProgramKey.call_list_size = x_sCall_list_size;
            _oRetentionProgramKey.ddate = x_dDdate;
            _oRetentionProgramKey.program_name = x_sProgram_name;
            _oRetentionProgramKey.program_id = x_iProgram_id;
            _oRetentionProgramKey.remarks = x_sRemarks;
            _oRetentionProgramKey.sdate = x_dSdate;
            return InsertWithOutLastID(x_oDB, _oRetentionProgramKey);
        }


        public bool Insert(RetentionProgramKey x_oRetentionProgramKey)
        {
            return InsertWithOutLastID(n_oDB, x_oRetentionProgramKey);
        }


        public bool InsertEntity(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is RetentionProgramKey)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (RetentionProgramKey)x_oObj);
        }


        public static bool Insert(MSSQLConnect x_oDB, RetentionProgramKey x_oRetentionProgramKey)
        {
            return InsertWithOutLastID(x_oDB, x_oRetentionProgramKey);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, RetentionProgramKey x_oRetentionProgramKey)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT INTO  [RetentionProgramKey]   ([type],[call_list_type],[cdate],[cid],[did],[return_date],[edate],[active],[expiry_month],[upload_date],[ddate],[call_list_size],[center],[program_name],[program_id],[remarks],[sdate])  VALUES  (@type,@call_list_type,@cdate,@cid,@did,@return_date,@edate,@active,@expiry_month,@upload_date,@ddate,@call_list_size,@center,@program_name,@program_id,@remarks,@sdate)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RetentionProgramKey]", "[" + Configurator.MSSQLTablePrefix + "RetentionProgramKey]"); }
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
            return InsertTransactionWithOutLastID(x_oDB, _oConn, _oCmd, x_oRetentionProgramKey);
        }

        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, RetentionProgramKey x_oRetentionProgramKey)
        {
            bool _bResult = false;
            if (!x_oRetentionProgramKey.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if (x_oRetentionProgramKey.type == null) { x_oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar, 10).Value = x_oRetentionProgramKey.type; }
                if (x_oRetentionProgramKey.call_list_type == null) { x_oCmd.Parameters.Add("@call_list_type", global::System.Data.SqlDbType.NVarChar, 20).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@call_list_type", global::System.Data.SqlDbType.NVarChar, 20).Value = x_oRetentionProgramKey.call_list_type; }
                if (x_oRetentionProgramKey.cdate == null) { x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = x_oRetentionProgramKey.cdate; }
                if (x_oRetentionProgramKey.cid == null) { x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar, 50).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar, 50).Value = x_oRetentionProgramKey.cid; }
                if (x_oRetentionProgramKey.did == null) { x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar, 50).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar, 50).Value = x_oRetentionProgramKey.did; }
                if (x_oRetentionProgramKey.return_date == null) { x_oCmd.Parameters.Add("@return_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@return_date", global::System.Data.SqlDbType.DateTime).Value = x_oRetentionProgramKey.return_date; }
                if (x_oRetentionProgramKey.edate == null) { x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = x_oRetentionProgramKey.edate; }
                if (x_oRetentionProgramKey.active == null) { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = x_oRetentionProgramKey.active; }
                if (x_oRetentionProgramKey.expiry_month == null) { x_oCmd.Parameters.Add("@expiry_month", global::System.Data.SqlDbType.NVarChar, 20).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@expiry_month", global::System.Data.SqlDbType.NVarChar, 20).Value = x_oRetentionProgramKey.expiry_month; }
                if (x_oRetentionProgramKey.upload_date == null) { x_oCmd.Parameters.Add("@upload_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@upload_date", global::System.Data.SqlDbType.DateTime).Value = x_oRetentionProgramKey.upload_date; }
                if (x_oRetentionProgramKey.ddate == null) { x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = x_oRetentionProgramKey.ddate; }
                if (x_oRetentionProgramKey.call_list_size == null) { x_oCmd.Parameters.Add("@call_list_size", global::System.Data.SqlDbType.NVarChar, 20).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@call_list_size", global::System.Data.SqlDbType.NVarChar, 20).Value = x_oRetentionProgramKey.call_list_size; }
                if (x_oRetentionProgramKey.center == null) { x_oCmd.Parameters.Add("@center", global::System.Data.SqlDbType.NVarChar, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@center", global::System.Data.SqlDbType.NVarChar, 10).Value = x_oRetentionProgramKey.center; }
                if (x_oRetentionProgramKey.program_name == null) { x_oCmd.Parameters.Add("@program_name", global::System.Data.SqlDbType.NVarChar, 100).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@program_name", global::System.Data.SqlDbType.NVarChar, 100).Value = x_oRetentionProgramKey.program_name; }
                if (x_oRetentionProgramKey.program_id == null) { x_oCmd.Parameters.Add("@program_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@program_id", global::System.Data.SqlDbType.Int).Value = x_oRetentionProgramKey.program_id; }
                if (x_oRetentionProgramKey.remarks == null) { x_oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.NVarChar, 150).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.NVarChar, 150).Value = x_oRetentionProgramKey.remarks; }
                if (x_oRetentionProgramKey.sdate == null) { x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = x_oRetentionProgramKey.sdate; }
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


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, string x_sType, string x_sCall_list_type, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sDid, global::System.Nullable<DateTime> x_dReturn_date, global::System.Nullable<DateTime> x_dEdate, global::System.Nullable<bool> x_bActive, string x_sCenter, string x_sExpiry_month, global::System.Nullable<DateTime> x_dUpload_date, string x_sCall_list_size, global::System.Nullable<DateTime> x_dDdate, string x_sProgram_name, global::System.Nullable<int> x_iProgram_id, string x_sRemarks, global::System.Nullable<DateTime> x_dSdate)
        {
            int _oLastID;
            RetentionProgramKey _oRetentionProgramKey = RetentionProgramKeyRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oRetentionProgramKey.type = x_sType;
            _oRetentionProgramKey.call_list_type = x_sCall_list_type;
            _oRetentionProgramKey.cdate = x_dCdate;
            _oRetentionProgramKey.cid = x_sCid;
            _oRetentionProgramKey.did = x_sDid;
            _oRetentionProgramKey.return_date = x_dReturn_date;
            _oRetentionProgramKey.edate = x_dEdate;
            _oRetentionProgramKey.active = x_bActive;
            _oRetentionProgramKey.center = x_sCenter;
            _oRetentionProgramKey.expiry_month = x_sExpiry_month;
            _oRetentionProgramKey.upload_date = x_dUpload_date;
            _oRetentionProgramKey.call_list_size = x_sCall_list_size;
            _oRetentionProgramKey.ddate = x_dDdate;
            _oRetentionProgramKey.program_name = x_sProgram_name;
            _oRetentionProgramKey.program_id = x_iProgram_id;
            _oRetentionProgramKey.remarks = x_sRemarks;
            _oRetentionProgramKey.sdate = x_dSdate;
            if (InsertWithLastID_SP(x_oDB, _oRetentionProgramKey, out _oLastID))
            {
                return _oLastID;
            }
            else
            {
                return -1;
            }
        }


        public int InsertReturnLastID_SP(RetentionProgramKey x_oRetentionProgramKey)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oRetentionProgramKey, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, RetentionProgramKey x_oRetentionProgramKey)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oRetentionProgramKey, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is RetentionProgramKey)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (RetentionProgramKey)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB, RetentionProgramKey x_oRetentionProgramKey, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "RETENTIONPROGRAMKEY";
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
            return InsertTransactionWithLastID_SP(x_oDB, _oConn, _oCmd, x_oRetentionProgramKey, out x_oLAST_ID);
        }

        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, RetentionProgramKey x_oRetentionProgramKey, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar = x_oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oRetentionProgramKey.type == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oRetentionProgramKey.type; }
                _oPar = x_oCmd.Parameters.Add("@call_list_type", global::System.Data.SqlDbType.NVarChar, 20);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oRetentionProgramKey.call_list_type == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oRetentionProgramKey.call_list_type; }
                _oPar = x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oRetentionProgramKey.cdate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oRetentionProgramKey.cdate; }
                _oPar = x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar, 50);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oRetentionProgramKey.cid == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oRetentionProgramKey.cid; }
                _oPar = x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar, 50);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oRetentionProgramKey.did == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oRetentionProgramKey.did; }
                _oPar = x_oCmd.Parameters.Add("@return_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oRetentionProgramKey.return_date == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oRetentionProgramKey.return_date; }
                _oPar = x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oRetentionProgramKey.edate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oRetentionProgramKey.edate; }
                _oPar = x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oRetentionProgramKey.active == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oRetentionProgramKey.active; }
                _oPar = x_oCmd.Parameters.Add("@expiry_month", global::System.Data.SqlDbType.NVarChar, 20);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oRetentionProgramKey.expiry_month == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oRetentionProgramKey.expiry_month; }
                _oPar = x_oCmd.Parameters.Add("@upload_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oRetentionProgramKey.upload_date == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oRetentionProgramKey.upload_date; }
                _oPar = x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oRetentionProgramKey.ddate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oRetentionProgramKey.ddate; }
                _oPar = x_oCmd.Parameters.Add("@call_list_size", global::System.Data.SqlDbType.NVarChar, 20);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oRetentionProgramKey.call_list_size == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oRetentionProgramKey.call_list_size; }
                _oPar = x_oCmd.Parameters.Add("@center", global::System.Data.SqlDbType.NVarChar, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oRetentionProgramKey.center == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oRetentionProgramKey.center; }
                _oPar = x_oCmd.Parameters.Add("@program_name", global::System.Data.SqlDbType.NVarChar, 100);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oRetentionProgramKey.program_name == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oRetentionProgramKey.program_name; }
                _oPar = x_oCmd.Parameters.Add("@program_id", global::System.Data.SqlDbType.Int);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oRetentionProgramKey.program_id == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oRetentionProgramKey.program_id; }
                _oPar = x_oCmd.Parameters.Add("@remarks", global::System.Data.SqlDbType.NVarChar, 150);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oRetentionProgramKey.remarks == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oRetentionProgramKey.remarks; }
                _oPar = x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oRetentionProgramKey.sdate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oRetentionProgramKey.sdate; }
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

        #region INSERT_RETENTIONPROGRAMKEY Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2009-11-17>
        ///-- Description:	<Description,RETENTIONPROGRAMKEY, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_RETENTIONPROGRAMKEY Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_RETENTIONPROGRAMKEY', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_RETENTIONPROGRAMKEY;
        GO
        CREATE PROCEDURE INSERT_RETENTIONPROGRAMKEY
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @type nvarchar(10),
        @call_list_type nvarchar(20),
        @cdate datetime,
        @cid nvarchar(50),
        @did nvarchar(50),
        @return_date datetime,
        @edate datetime,
        @active bit,
        @center nvarchar(10),
        @expiry_month nvarchar(20),
        @upload_date datetime,
        @call_list_size nvarchar(20),
        @ddate datetime,
        @program_name nvarchar(100),
        @program_id int,
        @remarks nvarchar(150),
        @sdate datetime
        AS
        
        INSERT INTO  [RetentionProgramKey]   ([type],[call_list_type],[cdate],[cid],[did],[return_date],[edate],[active],[expiry_month],[upload_date],[ddate],[call_list_size],[center],[program_name],[program_id],[remarks],[sdate])  VALUES  (@type,@call_list_type,@cdate,@cid,@did,@return_date,@edate,@active,@expiry_month,@upload_date,@ddate,@call_list_size,@center,@program_name,@program_id,@remarks,@sdate)
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
            string _sQuery = "DELETE FROM  [RetentionProgramKey]  WHERE [RetentionProgramKey].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RetentionProgramKey]", "[" + Configurator.MSSQLTablePrefix + "RetentionProgramKey]"); }
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
            return RetentionProgramKeyRepositoryBase.DeleteAll(n_oDB);
        }

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "DELETE FROM  [RetentionProgramKey]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RetentionProgramKey]", "[" + Configurator.MSSQLTablePrefix + "RetentionProgramKey]"); }
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
            string _sQuery = "DELETE FROM [RetentionProgramKey]" + x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RetentionProgramKey]", "[" + Configurator.MSSQLTablePrefix + "RetentionProgramKey]"); }
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

