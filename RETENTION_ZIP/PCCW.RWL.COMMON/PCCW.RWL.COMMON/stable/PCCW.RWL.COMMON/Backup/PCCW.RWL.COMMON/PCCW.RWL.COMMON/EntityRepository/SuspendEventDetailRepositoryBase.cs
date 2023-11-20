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
///-- Description:	<Description,Table :[SuspendEventDetail],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [SuspendEventDetail] Insert / list / delete manager layer
    /// </summary>

    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name = Configurator.MSSQLTablePrefix + "SuspendEventDetail")]
    public class SuspendEventDetailRepositoryBase : global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable
    {

        #region Instance
        private static SuspendEventDetailRepositoryBase instance;
        public static SuspendEventDetailRepositoryBase Instance()
        {
            if (instance == null)
            {
                MSSQLConnect _oDB = new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new SuspendEventDetailRepositoryBase(_oDB);
            }
            return instance;
        }
        public static SuspendEventDetailRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if (instance == null)
                instance = new SuspendEventDetailRepositoryBase(x_oDB);
            return instance;
        }
        #endregion

        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<SuspendEventDetailEntity> SuspendEventDetails;
        #endregion

        #region Constructor
        public SuspendEventDetailRepositoryBase(MSSQLConnect x_oDB)
            : base(x_oDB.ConnectionStr)
        {
            n_oDB = x_oDB;
        }
        ~SuspendEventDetailRepositoryBase()
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
        public static SuspendEventDetail CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new SuspendEventDetail(_oDB);
        }

        public static SuspendEventDetail CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new SuspendEventDetail(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [SuspendEventDetail]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[SuspendEventDetail]", "[" + Configurator.MSSQLTablePrefix + "SuspendEventDetail]"); }
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


        public SuspendEventDetailEntity GetObj(global::System.Nullable<int> x_iMid)
        {
            return GetObj(n_oDB, x_iMid);
        }


        public static SuspendEventDetailEntity GetObj(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            if (x_oDB == null) { return null; }
            SuspendEventDetail _SuspendEventDetail = (SuspendEventDetail)SuspendEventDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_SuspendEventDetail.Load(x_iMid)) { return null; }
            return _SuspendEventDetail;
        }



        public static SuspendEventDetailEntity[] GetArrayObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            List<SuspendEventDetailEntity> _oSuspendEventDetailList = GetListObj(x_oDB, 0, "mid", x_oArrayItemId);
            return _oSuspendEventDetailList.Count == 0 ? null : _oSuspendEventDetailList.ToArray();
        }

        public static List<SuspendEventDetailEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB, 0, "mid", x_oArrayItemId);
        }


        public static SuspendEventDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<SuspendEventDetailEntity> _oSuspendEventDetailList = GetListObj(x_oDB, 0, x_oColumnName, x_oArrayItemId);
            return _oSuspendEventDetailList.Count == 0 ? null : _oSuspendEventDetailList.ToArray();
        }


        public static SuspendEventDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<SuspendEventDetailEntity> _oSuspendEventDetailList = GetListObj(x_oDB, x_iTop, x_oColumnName, x_oArrayItemId);
            return _oSuspendEventDetailList.Count == 0 ? null : _oSuspendEventDetailList.ToArray();
        }

        public static List<SuspendEventDetailEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB == null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            List<SuspendEventDetailEntity> _oRow = new List<SuspendEventDetailEntity>();
            string _sQuery = "SELECT  " + _sTop + " [SuspendEventDetail].[active] AS SUSPENDEVENTDETAIL_ACTIVE,[SuspendEventDetail].[mid] AS SUSPENDEVENTDETAIL_MID,[SuspendEventDetail].[reasons] AS SUSPENDEVENTDETAIL_REASONS  FROM  [SuspendEventDetail]";
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
                _sQuery += " WHERE [SuspendEventDetail].[" + x_oColumnName.ToString() + "]  in " + _oList;
            }

            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[SuspendEventDetail]", "[" + Configurator.MSSQLTablePrefix + "SuspendEventDetail]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        SuspendEventDetail _oSuspendEventDetail = SuspendEventDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["SUSPENDEVENTDETAIL_MID"])) { _oSuspendEventDetail.mid = (global::System.Nullable<int>)_oData["SUSPENDEVENTDETAIL_MID"]; } else { _oSuspendEventDetail.mid = null; }
                        if (!global::System.Convert.IsDBNull(_oData["SUSPENDEVENTDETAIL_ACTIVE"])) { _oSuspendEventDetail.active = (global::System.Nullable<bool>)_oData["SUSPENDEVENTDETAIL_ACTIVE"]; } else { _oSuspendEventDetail.active = null; }
                        if (!global::System.Convert.IsDBNull(_oData["SUSPENDEVENTDETAIL_REASONS"])) { _oSuspendEventDetail.reasons = (string)_oData["SUSPENDEVENTDETAIL_REASONS"]; } else { _oSuspendEventDetail.reasons = global::System.String.Empty; }
                        _oSuspendEventDetail.SetDB(x_oDB);
                        _oSuspendEventDetail.GetFound();
                        _oRow.Add(_oSuspendEventDetail);
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


        public static SuspendEventDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<SuspendEventDetailEntity> _oSuspendEventDetailList = GetListObj(x_oDB, 0, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oSuspendEventDetailList.Count == 0 ? null : _oSuspendEventDetailList.ToArray();
        }


        public static SuspendEventDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<SuspendEventDetailEntity> _oSuspendEventDetailList = GetListObj(x_oDB, x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oSuspendEventDetailList.Count == 0 ? null : _oSuspendEventDetailList.ToArray();
        }

        public static List<SuspendEventDetailEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB == null) { return null; }
            List<SuspendEventDetailEntity> _oRow = new List<SuspendEventDetailEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            string _sFields = "[SuspendEventDetail].[active] AS SUSPENDEVENTDETAIL_ACTIVE,[SuspendEventDetail].[mid] AS SUSPENDEVENTDETAIL_MID,[SuspendEventDetail].[reasons] AS SUSPENDEVENTDETAIL_REASONS";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[SuspendEventDetail]", "[" + Configurator.MSSQLTablePrefix + "SuspendEventDetail]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = SuspendEventDetailRepositoryBase.GetSearch(x_oDB, _sTop.ToString() + _sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                SuspendEventDetailEntity _oSuspendEventDetail = SuspendEventDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["SUSPENDEVENTDETAIL_MID"])) { _oSuspendEventDetail.mid = (global::System.Nullable<int>)_oData["SUSPENDEVENTDETAIL_MID"]; } else { _oSuspendEventDetail.mid = null; }
                if (!global::System.Convert.IsDBNull(_oData["SUSPENDEVENTDETAIL_ACTIVE"])) { _oSuspendEventDetail.active = (global::System.Nullable<bool>)_oData["SUSPENDEVENTDETAIL_ACTIVE"]; } else { _oSuspendEventDetail.active = null; }
                if (!global::System.Convert.IsDBNull(_oData["SUSPENDEVENTDETAIL_REASONS"])) { _oSuspendEventDetail.reasons = (string)_oData["SUSPENDEVENTDETAIL_REASONS"]; } else { _oSuspendEventDetail.reasons = global::System.String.Empty; }
                _oSuspendEventDetail.SetDB(x_oDB);
                _oSuspendEventDetail.GetFound();
                _oRow.Add(_oSuspendEventDetail);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet(SuspendEventDetail.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder, SuspendEventDetail.Para.TableName());
            return _oDset;
        }


        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB == null) { return null; }
            return x_oDB.GetSearch(SuspendEventDetail.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }


        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(SuspendEventDetail.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            if (x_oDB == null) { return null; }
            string _oQuery = "SELECT   [SuspendEventDetail].[active] AS SUSPENDEVENTDETAIL_ACTIVE,[SuspendEventDetail].[mid] AS SUSPENDEVENTDETAIL_MID,[SuspendEventDetail].[reasons] AS SUSPENDEVENTDETAIL_REASONS  FROM  [SuspendEventDetail]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[SuspendEventDetail]", "[" + Configurator.MSSQLTablePrefix + "SuspendEventDetail]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery, _oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset, "SuspendEventDetail");
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

        public bool Insert(global::System.Nullable<bool> x_bActive, string x_sReasons)
        {
            SuspendEventDetail _oSuspendEventDetail = SuspendEventDetailRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oSuspendEventDetail.active = x_bActive;
            _oSuspendEventDetail.reasons = x_sReasons;
            return InsertWithOutLastID(n_oDB, _oSuspendEventDetail);
        }


        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bActive, string x_sReasons)
        {
            SuspendEventDetail _oSuspendEventDetail = SuspendEventDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oSuspendEventDetail.active = x_bActive;
            _oSuspendEventDetail.reasons = x_sReasons;
            return InsertWithOutLastID(x_oDB, _oSuspendEventDetail);
        }


        public bool Insert(SuspendEventDetail x_oSuspendEventDetail)
        {
            return InsertWithOutLastID(n_oDB, x_oSuspendEventDetail);
        }


        public bool InsertEntity(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is SuspendEventDetail)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (SuspendEventDetail)x_oObj);
        }


        public static bool Insert(MSSQLConnect x_oDB, SuspendEventDetail x_oSuspendEventDetail)
        {
            return InsertWithOutLastID(x_oDB, x_oSuspendEventDetail);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, SuspendEventDetail x_oSuspendEventDetail)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT INTO  [SuspendEventDetail]   ([active],[reasons])  VALUES  (@active,@reasons)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[SuspendEventDetail]", "[" + Configurator.MSSQLTablePrefix + "SuspendEventDetail]"); }
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
            return InsertTransactionWithOutLastID(x_oDB, _oConn, _oCmd, x_oSuspendEventDetail);
        }

        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, SuspendEventDetail x_oSuspendEventDetail)
        {
            bool _bResult = false;
            if (!x_oSuspendEventDetail.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if (x_oSuspendEventDetail.active == null) { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = x_oSuspendEventDetail.active; }
                if (x_oSuspendEventDetail.reasons == null) { x_oCmd.Parameters.Add("@reasons", global::System.Data.SqlDbType.NVarChar, 100).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@reasons", global::System.Data.SqlDbType.NVarChar, 100).Value = x_oSuspendEventDetail.reasons; }
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


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bActive, string x_sReasons)
        {
            int _oLastID;
            SuspendEventDetail _oSuspendEventDetail = SuspendEventDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oSuspendEventDetail.active = x_bActive;
            _oSuspendEventDetail.reasons = x_sReasons;
            if (InsertWithLastID_SP(x_oDB, _oSuspendEventDetail, out _oLastID))
            {
                return _oLastID;
            }
            else
            {
                return -1;
            }
        }


        public int InsertReturnLastID_SP(SuspendEventDetail x_oSuspendEventDetail)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oSuspendEventDetail, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, SuspendEventDetail x_oSuspendEventDetail)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oSuspendEventDetail, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is SuspendEventDetail)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (SuspendEventDetail)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB, SuspendEventDetail x_oSuspendEventDetail, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "SUSPENDEVENTDETAIL";
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
            return InsertTransactionWithLastID_SP(x_oDB, _oConn, _oCmd, x_oSuspendEventDetail, out x_oLAST_ID);
        }

        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, SuspendEventDetail x_oSuspendEventDetail, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar = x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oSuspendEventDetail.active == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oSuspendEventDetail.active; }
                _oPar = x_oCmd.Parameters.Add("@reasons", global::System.Data.SqlDbType.NVarChar, 100);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oSuspendEventDetail.reasons == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oSuspendEventDetail.reasons; }
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

        #region INSERT_SUSPENDEVENTDETAIL Store Procedures
        ///-- =============================================
        ///-- Author:		<Author,Philip SW>
        ///-- Create date: <Create Date 2009-11-17>
        ///-- Description:	<Description,SUSPENDEVENTDETAIL, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_SUSPENDEVENTDETAIL Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_SUSPENDEVENTDETAIL', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_SUSPENDEVENTDETAIL;
        GO
        CREATE PROCEDURE INSERT_SUSPENDEVENTDETAIL
        	-- Add the parameters for the stored procedure here
        @RETURN_MID int output,
        @active bit,
        @reasons nvarchar(100)
        AS
        
        INSERT INTO  [SuspendEventDetail]   ([active],[reasons])  VALUES  (@active,@reasons)
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
            string _sQuery = "DELETE FROM  [SuspendEventDetail]  WHERE [SuspendEventDetail].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[SuspendEventDetail]", "[" + Configurator.MSSQLTablePrefix + "SuspendEventDetail]"); }
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
            return SuspendEventDetailRepositoryBase.DeleteAll(n_oDB);
        }

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "DELETE FROM  [SuspendEventDetail]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[SuspendEventDetail]", "[" + Configurator.MSSQLTablePrefix + "SuspendEventDetail]"); }
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
            string _sQuery = "DELETE FROM [SuspendEventDetail]" + x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[SuspendEventDetail]", "[" + Configurator.MSSQLTablePrefix + "SuspendEventDetail]"); }
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

