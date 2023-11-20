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
///-- Create date: <Create Date 2010-07-29>
///-- Description:	<Description,Table :[ErrorLog],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [ErrorLog] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"ErrorLog")]
    public class ErrorLogRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static ErrorLogRepositoryBase instance;
        public static ErrorLogRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new ErrorLogRepositoryBase(_oDB);
            }
            return instance;
        }
        public static ErrorLogRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new ErrorLogRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<ErrorLogEntity> ErrorLogs;
        #endregion
        
        #region Constructor
        public ErrorLogRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~ErrorLogRepositoryBase() { 
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
        public static ErrorLog CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new ErrorLog(_oDB);
        }
        
        public static ErrorLog CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new ErrorLog(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [ErrorLog]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ErrorLog]","["+ Configurator.MSSQLTablePrefix + "ErrorLog]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn=x_oDB.GetConnection()){
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
                catch{}
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
        
        
        public ErrorLogEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }
        
        
        public static ErrorLogEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            if (x_oDB==null) { return null; }
            ErrorLog _ErrorLog = (ErrorLog)ErrorLogRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_ErrorLog.Load(x_iId)) { return null; }
            return _ErrorLog;
        }
        
        
        
        public static ErrorLogEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<ErrorLogEntity> _oErrorLogList = GetListObj(x_oDB,0, "id", x_oArrayItemId);
            return _oErrorLogList.Count == 0 ? null : _oErrorLogList.ToArray();
        }
        
        public static List<ErrorLogEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "id", x_oArrayItemId);
        }
        
        
        public static ErrorLogEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<ErrorLogEntity> _oErrorLogList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            return _oErrorLogList.Count == 0 ? null : _oErrorLogList.ToArray();
        }
        
        
        public static ErrorLogEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<ErrorLogEntity> _oErrorLogList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            return _oErrorLogList.Count == 0 ? null : _oErrorLogList.ToArray();
        }
        
        public static List<ErrorLogEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<ErrorLogEntity> _oRow = new List<ErrorLogEntity>();
            string _sQuery = "SELECT  "+_sTop+" [ErrorLog].[uid] AS ERRORLOG_UID,[ErrorLog].[ip] AS ERRORLOG_IP,[ErrorLog].[page] AS ERRORLOG_PAGE,[ErrorLog].[stack_trace] AS ERRORLOG_STACK_TRACE,[ErrorLog].[id] AS ERRORLOG_ID,[ErrorLog].[log_date] AS ERRORLOG_LOG_DATE,[ErrorLog].[err_msg] AS ERRORLOG_ERR_MSG  FROM  [ErrorLog]";
            if (x_oArrayItemId==null)
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
                _sQuery += " WHERE [ErrorLog].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ErrorLog]","["+ Configurator.MSSQLTablePrefix + "ErrorLog]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        ErrorLog _oErrorLog = ErrorLogRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["ERRORLOG_UID"])) {_oErrorLog.uid = (string)_oData["ERRORLOG_UID"]; }else{_oErrorLog.uid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["ERRORLOG_ID"])) {_oErrorLog.id = (global::System.Nullable<int>)_oData["ERRORLOG_ID"]; }else{_oErrorLog.id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["ERRORLOG_IP"])) {_oErrorLog.ip = (string)_oData["ERRORLOG_IP"]; }else{_oErrorLog.ip=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["ERRORLOG_PAGE"])) {_oErrorLog.page = (string)_oData["ERRORLOG_PAGE"]; }else{_oErrorLog.page=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["ERRORLOG_STACK_TRACE"])) {_oErrorLog.stack_trace = (string)_oData["ERRORLOG_STACK_TRACE"]; }else{_oErrorLog.stack_trace=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["ERRORLOG_LOG_DATE"])) {_oErrorLog.log_date = (global::System.Nullable<DateTime>)_oData["ERRORLOG_LOG_DATE"]; }else{_oErrorLog.log_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["ERRORLOG_ERR_MSG"])) {_oErrorLog.err_msg = (string)_oData["ERRORLOG_ERR_MSG"]; }else{_oErrorLog.err_msg=global::System.String.Empty;}
                        _oErrorLog.SetDB(x_oDB);
                        _oErrorLog.GetFound();
                        _oRow.Add(_oErrorLog);
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
                return _oRow;
            }
        }
        
        
        public static ErrorLogEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<ErrorLogEntity> _oErrorLogList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oErrorLogList.Count == 0 ? null : _oErrorLogList.ToArray();
        }
        
        
        public static ErrorLogEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<ErrorLogEntity> _oErrorLogList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oErrorLogList.Count == 0 ? null : _oErrorLogList.ToArray();
        }
        
        public static List<ErrorLogEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<ErrorLogEntity> _oRow = new List<ErrorLogEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[ErrorLog].[uid] AS ERRORLOG_UID,[ErrorLog].[ip] AS ERRORLOG_IP,[ErrorLog].[page] AS ERRORLOG_PAGE,[ErrorLog].[stack_trace] AS ERRORLOG_STACK_TRACE,[ErrorLog].[id] AS ERRORLOG_ID,[ErrorLog].[log_date] AS ERRORLOG_LOG_DATE,[ErrorLog].[err_msg] AS ERRORLOG_ERR_MSG";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[ErrorLog]","["+ Configurator.MSSQLTablePrefix + "ErrorLog]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = ErrorLogRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                ErrorLogEntity _oErrorLog = ErrorLogRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["ERRORLOG_UID"])) {_oErrorLog.uid = (string)_oData["ERRORLOG_UID"]; } else {_oErrorLog.uid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["ERRORLOG_ID"])) {_oErrorLog.id = (global::System.Nullable<int>)_oData["ERRORLOG_ID"]; } else {_oErrorLog.id=null; }
                if (!global::System.Convert.IsDBNull(_oData["ERRORLOG_IP"])) {_oErrorLog.ip = (string)_oData["ERRORLOG_IP"]; } else {_oErrorLog.ip=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["ERRORLOG_PAGE"])) {_oErrorLog.page = (string)_oData["ERRORLOG_PAGE"]; } else {_oErrorLog.page=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["ERRORLOG_STACK_TRACE"])) {_oErrorLog.stack_trace = (string)_oData["ERRORLOG_STACK_TRACE"]; } else {_oErrorLog.stack_trace=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["ERRORLOG_LOG_DATE"])) {_oErrorLog.log_date = (global::System.Nullable<DateTime>)_oData["ERRORLOG_LOG_DATE"]; } else {_oErrorLog.log_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["ERRORLOG_ERR_MSG"])) {_oErrorLog.err_msg = (string)_oData["ERRORLOG_ERR_MSG"]; } else {_oErrorLog.err_msg=global::System.String.Empty; }
                _oErrorLog.SetDB(x_oDB);
                _oErrorLog.GetFound();
                _oRow.Add(_oErrorLog);
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
            return GetDataSet(n_oDB,"");
        }
        
        
        public global::System.Data.DataSet GetDataSet(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return GetDataSet(n_oDB,x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( ErrorLog.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,ErrorLog.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(ErrorLog.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(ErrorLog.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [ErrorLog].[uid] AS ERRORLOG_UID,[ErrorLog].[ip] AS ERRORLOG_IP,[ErrorLog].[page] AS ERRORLOG_PAGE,[ErrorLog].[stack_trace] AS ERRORLOG_STACK_TRACE,[ErrorLog].[id] AS ERRORLOG_ID,[ErrorLog].[log_date] AS ERRORLOG_LOG_DATE,[ErrorLog].[err_msg] AS ERRORLOG_ERR_MSG  FROM  [ErrorLog]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[ErrorLog]","["+ Configurator.MSSQLTablePrefix + "ErrorLog]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"ErrorLog");
                }
                catch {  }
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
        
        public bool Insert(string x_sUid,string x_sIp,string x_sPage,string x_sStack_trace,global::System.Nullable<DateTime> x_dLog_date,string x_sErr_msg)
        {
            ErrorLog _oErrorLog=ErrorLogRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oErrorLog.uid=x_sUid;
            _oErrorLog.ip=x_sIp;
            _oErrorLog.page=x_sPage;
            _oErrorLog.stack_trace=x_sStack_trace;
            _oErrorLog.log_date=x_dLog_date;
            _oErrorLog.err_msg=x_sErr_msg;
            return InsertWithOutLastID(n_oDB, _oErrorLog);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sUid,string x_sIp,string x_sPage,string x_sStack_trace,global::System.Nullable<DateTime> x_dLog_date,string x_sErr_msg)
        {
            ErrorLog _oErrorLog=ErrorLogRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oErrorLog.uid=x_sUid;
            _oErrorLog.ip=x_sIp;
            _oErrorLog.page=x_sPage;
            _oErrorLog.stack_trace=x_sStack_trace;
            _oErrorLog.log_date=x_dLog_date;
            _oErrorLog.err_msg=x_sErr_msg;
            return InsertWithOutLastID(x_oDB, _oErrorLog);
        }
        
        
        public bool Insert(ErrorLog x_oErrorLog)
        {
            return InsertWithOutLastID(n_oDB, x_oErrorLog);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is ErrorLog)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (ErrorLog)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,ErrorLog x_oErrorLog)
        {
            return InsertWithOutLastID(x_oDB, x_oErrorLog);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,ErrorLog x_oErrorLog)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [ErrorLog]   ([uid],[ip],[page],[stack_trace],[log_date],[err_msg])  VALUES  (@uid,@ip,@page,@stack_trace,@log_date,@err_msg)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ErrorLog]","["+ Configurator.MSSQLTablePrefix + "ErrorLog]"); }
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
                _oConn =x_oDB.GetConnection();
                _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            }
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oErrorLog);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,ErrorLog x_oErrorLog)
        {
            bool _bResult = false;
            if (!x_oErrorLog.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oErrorLog.uid==null){  x_oCmd.Parameters.Add("@uid", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@uid", global::System.Data.SqlDbType.NVarChar,250).Value=x_oErrorLog.uid; }
                if(x_oErrorLog.ip==null){  x_oCmd.Parameters.Add("@ip", global::System.Data.SqlDbType.VarChar,15).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ip", global::System.Data.SqlDbType.VarChar,15).Value=x_oErrorLog.ip; }
                if(x_oErrorLog.page==null){  x_oCmd.Parameters.Add("@page", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@page", global::System.Data.SqlDbType.NVarChar,250).Value=x_oErrorLog.page; }
                if(x_oErrorLog.stack_trace==null){  x_oCmd.Parameters.Add("@stack_trace", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@stack_trace", global::System.Data.SqlDbType.Text).Value=x_oErrorLog.stack_trace; }
                if(x_oErrorLog.log_date==null){  x_oCmd.Parameters.Add("@log_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@log_date", global::System.Data.SqlDbType.DateTime).Value=x_oErrorLog.log_date; }
                if(x_oErrorLog.err_msg==null){  x_oCmd.Parameters.Add("@err_msg", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@err_msg", global::System.Data.SqlDbType.Text).Value=x_oErrorLog.err_msg; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                _bResult = Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
            }
            catch {  }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,string x_sUid,string x_sIp,string x_sPage,string x_sStack_trace,global::System.Nullable<DateTime> x_dLog_date,string x_sErr_msg)
        {
            int _oLastID;
            ErrorLog _oErrorLog=ErrorLogRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oErrorLog.uid=x_sUid;
            _oErrorLog.ip=x_sIp;
            _oErrorLog.page=x_sPage;
            _oErrorLog.stack_trace=x_sStack_trace;
            _oErrorLog.log_date=x_dLog_date;
            _oErrorLog.err_msg=x_sErr_msg;
            if(InsertWithLastID(x_oDB, _oErrorLog,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(ErrorLog x_oErrorLog)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oErrorLog, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, ErrorLog x_oErrorLog)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oErrorLog, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is ErrorLog)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (ErrorLog)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,ErrorLog x_oErrorLog, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [ErrorLog]   ([uid],[ip],[page],[stack_trace],[log_date],[err_msg])  VALUES  (@uid,@ip,@page,@stack_trace,@log_date,@err_msg)"+" SELECT  @@IDENTITY AS ErrorLog_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ErrorLog]","["+ Configurator.MSSQLTablePrefix + "ErrorLog]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oErrorLog,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,ErrorLog x_oErrorLog, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oErrorLog.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oErrorLog.uid==null){  x_oCmd.Parameters.Add("@uid", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@uid", global::System.Data.SqlDbType.NVarChar,250).Value=x_oErrorLog.uid; }
                if(x_oErrorLog.ip==null){  x_oCmd.Parameters.Add("@ip", global::System.Data.SqlDbType.VarChar,15).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ip", global::System.Data.SqlDbType.VarChar,15).Value=x_oErrorLog.ip; }
                if(x_oErrorLog.page==null){  x_oCmd.Parameters.Add("@page", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@page", global::System.Data.SqlDbType.NVarChar,250).Value=x_oErrorLog.page; }
                if(x_oErrorLog.stack_trace==null){  x_oCmd.Parameters.Add("@stack_trace", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@stack_trace", global::System.Data.SqlDbType.Text).Value=x_oErrorLog.stack_trace; }
                if(x_oErrorLog.log_date==null){  x_oCmd.Parameters.Add("@log_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@log_date", global::System.Data.SqlDbType.DateTime).Value=x_oErrorLog.log_date; }
                if(x_oErrorLog.err_msg==null){  x_oCmd.Parameters.Add("@err_msg", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@err_msg", global::System.Data.SqlDbType.Text).Value=x_oErrorLog.err_msg; }
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["ErrorLog_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["ErrorLog_LASTID"].ToString()) && int.TryParse(_oData["ErrorLog_LASTID"].ToString(),out x_iLAST_ID)){
                            _bResult=true;
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
            catch {  }
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sUid,string x_sIp,string x_sPage,string x_sStack_trace,global::System.Nullable<DateTime> x_dLog_date,string x_sErr_msg)
        {
            int _oLastID;
            ErrorLog _oErrorLog=ErrorLogRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oErrorLog.uid=x_sUid;
            _oErrorLog.ip=x_sIp;
            _oErrorLog.page=x_sPage;
            _oErrorLog.stack_trace=x_sStack_trace;
            _oErrorLog.log_date=x_dLog_date;
            _oErrorLog.err_msg=x_sErr_msg;
            if(InsertWithLastID_SP(x_oDB, _oErrorLog,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(ErrorLog x_oErrorLog)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oErrorLog, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, ErrorLog x_oErrorLog)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oErrorLog, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is ErrorLog)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (ErrorLog)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,ErrorLog x_oErrorLog, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "ERRORLOG";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oErrorLog,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,ErrorLog x_oErrorLog, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@uid", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oErrorLog.uid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oErrorLog.uid; }
                _oPar=x_oCmd.Parameters.Add("@ip", global::System.Data.SqlDbType.VarChar,15);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oErrorLog.ip==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oErrorLog.ip; }
                _oPar=x_oCmd.Parameters.Add("@page", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oErrorLog.page==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oErrorLog.page; }
                _oPar=x_oCmd.Parameters.Add("@stack_trace", global::System.Data.SqlDbType.Text);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oErrorLog.stack_trace==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oErrorLog.stack_trace; }
                _oPar=x_oCmd.Parameters.Add("@log_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oErrorLog.log_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oErrorLog.log_date; }
                _oPar=x_oCmd.Parameters.Add("@err_msg", global::System.Data.SqlDbType.Text);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oErrorLog.err_msg==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oErrorLog.err_msg; }
                _oPar=x_oCmd.Parameters.Add("@RETURN_ID", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Output;
                x_oCmd.CommandType = CommandType.StoredProcedure;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                _bResult = Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
                x_oLAST_ID = Int32.Parse(x_oCmd.Parameters["@RETURN_ID"].Value.ToString());
            }
            catch { }
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
        
        #region INSERT_ERRORLOG Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2010-07-29>
        ///-- Description:	<Description,ERRORLOG, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_ERRORLOG Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_ERRORLOG', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_ERRORLOG;
        GO
        CREATE PROCEDURE INSERT_ERRORLOG
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @uid nvarchar(250),
        @ip varchar(15),
        @page nvarchar(250),
        @stack_trace text,
        @log_date datetime,
        @err_msg text
        AS
        
        INSERT INTO  [ErrorLog]   ([uid],[ip],[page],[stack_trace],[log_date],[err_msg])  VALUES  (@uid,@ip,@page,@stack_trace,@log_date,@err_msg)
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
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return DeleteProc(x_oDB, x_iId);
        }
        
        
        private static bool DeleteProc(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            if (x_iId==null) { return false; }
            string _sQuery = "DELETE FROM  [ErrorLog]  WHERE [ErrorLog].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ErrorLog]","["+ Configurator.MSSQLTablePrefix + "ErrorLog]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult=false;
                _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = x_iId;
                try
                {
                    _oConn.Open();
                    _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
                }
                catch {  }
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
            if (n_oDB==null) { return false; }
            return ErrorLogRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [ErrorLog]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ErrorLog]","["+ Configurator.MSSQLTablePrefix + "ErrorLog]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult = false;
                try
                {
                    _oConn.Open();
                    _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
                }
                catch {  }
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
            return DeleteFilter(n_oDB,x_sFilter);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return false; }
            if (!"".Equals(x_sFilter)){x_sFilter=" WHERE "+x_sFilter;}
            string _sQuery = "DELETE FROM [ErrorLog]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ErrorLog]","["+ Configurator.MSSQLTablePrefix + "ErrorLog]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult = false;
                try
                {
                    _oConn.Open();
                    _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
                }
                catch {  }
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


