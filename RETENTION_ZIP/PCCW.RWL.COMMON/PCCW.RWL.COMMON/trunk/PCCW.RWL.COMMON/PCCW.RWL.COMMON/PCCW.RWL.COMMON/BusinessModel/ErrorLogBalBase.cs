using System;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
///-- Create date: <Create Date 2010-07-29>
///-- Description:	<Description,Table :[ErrorLog],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [ErrorLog] Business layer
    /// </summary>
    
    public abstract class ErrorLogBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public ErrorLogBalBase(){
        }
        ~ErrorLogBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(ErrorLog x_oErrorLog)
        {
            return GetDataSet(x_oErrorLog,null,ErrorLogInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(ErrorLog x_oErrorLog,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oErrorLog,x_oMergeDSet,ErrorLogInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(ErrorLog x_oErrorLog,ErrorLogInfo x_oTableSet)
        {
            return GetDataSet(x_oErrorLog,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(ErrorLog x_oErrorLog,global::System.Data.DataSet x_oMergeDSet,ErrorLogInfo x_oTableSet)
        {
            return GetDataSet(x_oErrorLog,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(ErrorLog x_oErrorLog,global::System.Data.DataSet x_oMergeDSet,ErrorLogInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = ErrorLogInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(ErrorLog.Para.TableName());
            if (x_oTableSet.Fields(ErrorLog.Para.uid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ErrorLog.Para.TableName()].Columns.Add(ErrorLog.Para.uid); }
            if (x_oTableSet.Fields(ErrorLog.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ErrorLog.Para.TableName()].Columns.Add(ErrorLog.Para.id); }
            if (x_oTableSet.Fields(ErrorLog.Para.ip).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ErrorLog.Para.TableName()].Columns.Add(ErrorLog.Para.ip); }
            if (x_oTableSet.Fields(ErrorLog.Para.page).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ErrorLog.Para.TableName()].Columns.Add(ErrorLog.Para.page); }
            if (x_oTableSet.Fields(ErrorLog.Para.stack_trace).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ErrorLog.Para.TableName()].Columns.Add(ErrorLog.Para.stack_trace); }
            if (x_oTableSet.Fields(ErrorLog.Para.log_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ErrorLog.Para.TableName()].Columns.Add(ErrorLog.Para.log_date); }
            if (x_oTableSet.Fields(ErrorLog.Para.err_msg).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ErrorLog.Para.TableName()].Columns.Add(ErrorLog.Para.err_msg); }
            if (x_oErrorLog != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[ErrorLog.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(ErrorLog.Para.uid).IsView || x_oTableSet.GetViewAll()) { _oDRow[ErrorLog.Para.uid] = x_oErrorLog.GetUid(); }
                if (x_oTableSet.Fields(ErrorLog.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[ErrorLog.Para.id] = x_oErrorLog.GetId(); }
                if (x_oTableSet.Fields(ErrorLog.Para.ip).IsView || x_oTableSet.GetViewAll()) { _oDRow[ErrorLog.Para.ip] = x_oErrorLog.GetIp(); }
                if (x_oTableSet.Fields(ErrorLog.Para.page).IsView || x_oTableSet.GetViewAll()) { _oDRow[ErrorLog.Para.page] = x_oErrorLog.GetPage(); }
                if (x_oTableSet.Fields(ErrorLog.Para.stack_trace).IsView || x_oTableSet.GetViewAll()) { _oDRow[ErrorLog.Para.stack_trace] = x_oErrorLog.GetStack_trace(); }
                if (x_oTableSet.Fields(ErrorLog.Para.log_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[ErrorLog.Para.log_date] = x_oErrorLog.GetLog_date(); }
                if (x_oTableSet.Fields(ErrorLog.Para.err_msg).IsView || x_oTableSet.GetViewAll()) { _oDRow[ErrorLog.Para.err_msg] = x_oErrorLog.GetErr_msg(); }
                _oDSet.Tables[ErrorLog.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(ErrorLogInfo x_oTableSet)
        {
            return ErrorLogBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return ErrorLogBal.ToEmptyDataSetProcess(ErrorLogInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(ErrorLogInfo x_oTableSet)
        {
            return ErrorLogBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(ErrorLog x_oErrorLog, ErrorLogInfo x_oTableSet)
        {
            return ErrorLogBal.GetDataSet(null, null, x_oTableSet).Tables[ErrorLog.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(ErrorLog x_oErrorLog)
        {
            return ErrorLogBal.GetDataSet(x_oErrorLog, null, ErrorLogInfoDLL.CreateInfoInstanceObject()).Tables[ErrorLog.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return Row(x_oTable, x_oDB,x_iId,ErrorLogInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId, ErrorLogInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iId, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId,ErrorLogInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = ErrorLogInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [ErrorLog].[uid] AS ERRORLOG_UID,[ErrorLog].[ip] AS ERRORLOG_IP,[ErrorLog].[page] AS ERRORLOG_PAGE,[ErrorLog].[stack_trace] AS ERRORLOG_STACK_TRACE,[ErrorLog].[id] AS ERRORLOG_ID,[ErrorLog].[log_date] AS ERRORLOG_LOG_DATE,[ErrorLog].[err_msg] AS ERRORLOG_ERR_MSG  FROM  [ErrorLog]  WHERE  [ErrorLog].[id] = \'"+x_iId.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ErrorLog]","["+ Configurator.MSSQLTablePrefix + "ErrorLog]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(ErrorLog.Para.uid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["ERRORLOG_UID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ErrorLog.Para.uid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ErrorLog.Para.uid).AliasName].ToString()] = (string)_oData["ERRORLOG_UID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ErrorLog.Para.uid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(ErrorLog.Para.ip).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["ERRORLOG_IP"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ErrorLog.Para.ip).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ErrorLog.Para.ip).AliasName].ToString()] = (string)_oData["ERRORLOG_IP"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ErrorLog.Para.ip).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(ErrorLog.Para.page).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["ERRORLOG_PAGE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ErrorLog.Para.page).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ErrorLog.Para.page).AliasName].ToString()] = (string)_oData["ERRORLOG_PAGE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ErrorLog.Para.page).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(ErrorLog.Para.stack_trace).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["ERRORLOG_STACK_TRACE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ErrorLog.Para.stack_trace).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ErrorLog.Para.stack_trace).AliasName].ToString()] = (string)_oData["ERRORLOG_STACK_TRACE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ErrorLog.Para.stack_trace).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(ErrorLog.Para.id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["ERRORLOG_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ErrorLog.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ErrorLog.Para.id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["ERRORLOG_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ErrorLog.Para.id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(ErrorLog.Para.log_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["ERRORLOG_LOG_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ErrorLog.Para.log_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ErrorLog.Para.log_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["ERRORLOG_LOG_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ErrorLog.Para.log_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(ErrorLog.Para.err_msg).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["ERRORLOG_ERR_MSG"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ErrorLog.Para.err_msg).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ErrorLog.Para.err_msg).AliasName].ToString()] = (string)_oData["ERRORLOG_ERR_MSG"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ErrorLog.Para.err_msg).AliasName].ToString()] =string.Empty;
                        }
                    }
                    _oData.Close();
                    _oData.Dispose();
                }
                catch {  }
                finally
                {
                    _oConn.Close();
                    _oCmd.Dispose();
                    _oConn.Dispose();
                }
                return _oRw;
            }
        }
        #endregion
        
        
        #region SetDataSetRow
        
        
        // ******************************
        // *  Handler for Convert To DataSet Row
        // ******************************
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,ErrorLog x_oErrorLogRow)
        {
            return SetByDataSetRowProc(x_iROW, ErrorLog.Para.TableName(), x_oDataSet,x_oErrorLogRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,ErrorLog x_oErrorLogRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oErrorLogRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,ErrorLog x_oErrorLogRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                ErrorLogInfo _oTableSet=ErrorLogInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ErrorLog.Para.uid).AliasName))
                    x_oErrorLogRow.uid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ErrorLog.Para.uid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ErrorLog.Para.id).AliasName))
                    x_oErrorLogRow.id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ErrorLog.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ErrorLog.Para.ip).AliasName))
                    x_oErrorLogRow.ip = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ErrorLog.Para.ip).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ErrorLog.Para.page).AliasName))
                    x_oErrorLogRow.page = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ErrorLog.Para.page).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ErrorLog.Para.stack_trace).AliasName))
                    x_oErrorLogRow.stack_trace = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ErrorLog.Para.stack_trace).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ErrorLog.Para.log_date).AliasName))
                    x_oErrorLogRow.log_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ErrorLog.Para.log_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ErrorLog.Para.err_msg).AliasName))
                    x_oErrorLogRow.err_msg = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ErrorLog.Para.err_msg).AliasName];
                return true;
            }
            return false;
        }
        
        #endregion SetByDataSet
        
        
        #region Count
        
        // ******************************
        // *  Handler for Data Counting
        // ******************************
        
        public static int GetCount(MSSQLConnect x_oDB){
            return ErrorLogRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static ErrorLogEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return ErrorLogRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static ErrorLogEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return ErrorLogRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return ErrorLogRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return ErrorLogRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return ErrorLogRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sUid,string x_sIp,string x_sPage,string x_sStack_trace,global::System.Nullable<DateTime> x_dLog_date,string x_sErr_msg)
        {
            return ErrorLogRepository.Insert(x_oDB, x_sUid,x_sIp,x_sPage,x_sStack_trace,x_dLog_date,x_sErr_msg);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,ErrorLog x_oErrorLog)
        {
            return ErrorLogRepository.InsertWithOutLastID(x_oDB,x_oErrorLog);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sUid,string x_sIp,string x_sPage,string x_sStack_trace,global::System.Nullable<DateTime> x_dLog_date,string x_sErr_msg)
        {
            return ErrorLogRepository.InsertReturnLastID_SP(x_oDB,x_sUid,x_sIp,x_sPage,x_sStack_trace,x_dLog_date,x_sErr_msg);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, ErrorLog x_oErrorLog)
        {
            return ErrorLogRepository.InsertReturnLastID_SP(x_oDB,x_oErrorLog);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return ErrorLogRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return ErrorLogRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return ErrorLogRepository.Delete(x_oDB, x_iId);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(ErrorLog x_oErrorLogRow){
            String sFile = String.Empty;
        }
        
        #endregion
        
        #region Release
        
        // ******************************
        // *  Handler for Release Memory
        // ******************************
        
        public void Release(){}
        #endregion
    }
}


