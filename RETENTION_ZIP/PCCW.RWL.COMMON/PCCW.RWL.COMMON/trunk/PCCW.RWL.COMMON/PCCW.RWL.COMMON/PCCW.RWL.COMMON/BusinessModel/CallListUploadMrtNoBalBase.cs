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
///-- Create date: <Create Date 2011-09-15>
///-- Description:	<Description,Table :[CallListUploadMrtNo],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [CallListUploadMrtNo] Business layer
    /// </summary>
    
    public abstract class CallListUploadMrtNoBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public CallListUploadMrtNoBalBase(){
        }
        ~CallListUploadMrtNoBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(CallListUploadMrtNo x_oCallListUploadMrtNo)
        {
            return GetDataSet(x_oCallListUploadMrtNo,null,CallListUploadMrtNoInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(CallListUploadMrtNo x_oCallListUploadMrtNo,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oCallListUploadMrtNo,x_oMergeDSet,CallListUploadMrtNoInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(CallListUploadMrtNo x_oCallListUploadMrtNo,CallListUploadMrtNoInfo x_oTableSet)
        {
            return GetDataSet(x_oCallListUploadMrtNo,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(CallListUploadMrtNo x_oCallListUploadMrtNo,global::System.Data.DataSet x_oMergeDSet,CallListUploadMrtNoInfo x_oTableSet)
        {
            return GetDataSet(x_oCallListUploadMrtNo,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(CallListUploadMrtNo x_oCallListUploadMrtNo,global::System.Data.DataSet x_oMergeDSet,CallListUploadMrtNoInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = CallListUploadMrtNoInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(CallListUploadMrtNo.Para.TableName());
            if (x_oTableSet.Fields(CallListUploadMrtNo.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[CallListUploadMrtNo.Para.TableName()].Columns.Add(CallListUploadMrtNo.Para.cdate); }
            if (x_oTableSet.Fields(CallListUploadMrtNo.Para.mrt_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[CallListUploadMrtNo.Para.TableName()].Columns.Add(CallListUploadMrtNo.Para.mrt_no); }
            if (x_oTableSet.Fields(CallListUploadMrtNo.Para.call_list_program_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[CallListUploadMrtNo.Para.TableName()].Columns.Add(CallListUploadMrtNo.Para.call_list_program_id); }
            if (x_oTableSet.Fields(CallListUploadMrtNo.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[CallListUploadMrtNo.Para.TableName()].Columns.Add(CallListUploadMrtNo.Para.id); }
            if (x_oCallListUploadMrtNo != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[CallListUploadMrtNo.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(CallListUploadMrtNo.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[CallListUploadMrtNo.Para.cdate] = x_oCallListUploadMrtNo.GetCdate(); }
                if (x_oTableSet.Fields(CallListUploadMrtNo.Para.mrt_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[CallListUploadMrtNo.Para.mrt_no] = x_oCallListUploadMrtNo.GetMrt_no(); }
                if (x_oTableSet.Fields(CallListUploadMrtNo.Para.call_list_program_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[CallListUploadMrtNo.Para.call_list_program_id] = x_oCallListUploadMrtNo.GetCall_list_program_id(); }
                if (x_oTableSet.Fields(CallListUploadMrtNo.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[CallListUploadMrtNo.Para.id] = x_oCallListUploadMrtNo.GetId(); }
                _oDSet.Tables[CallListUploadMrtNo.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(CallListUploadMrtNoInfo x_oTableSet)
        {
            return CallListUploadMrtNoBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return CallListUploadMrtNoBal.ToEmptyDataSetProcess(CallListUploadMrtNoInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(CallListUploadMrtNoInfo x_oTableSet)
        {
            return CallListUploadMrtNoBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(CallListUploadMrtNo x_oCallListUploadMrtNo, CallListUploadMrtNoInfo x_oTableSet)
        {
            return CallListUploadMrtNoBal.GetDataSet(null, null, x_oTableSet).Tables[CallListUploadMrtNo.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(CallListUploadMrtNo x_oCallListUploadMrtNo)
        {
            return CallListUploadMrtNoBal.GetDataSet(x_oCallListUploadMrtNo, null, CallListUploadMrtNoInfoDLL.CreateInfoInstanceObject()).Tables[CallListUploadMrtNo.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<long> x_lId)
        {
            return Row(x_oTable, x_oDB,x_lId,CallListUploadMrtNoInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<long> x_lId, CallListUploadMrtNoInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_lId, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<long> x_lId,CallListUploadMrtNoInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = CallListUploadMrtNoInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [CallListUploadMrtNo].[cdate] AS CALLLISTUPLOADMRTNO_CDATE,[CallListUploadMrtNo].[mrt_no] AS CALLLISTUPLOADMRTNO_MRT_NO,[CallListUploadMrtNo].[call_list_program_id] AS CALLLISTUPLOADMRTNO_CALL_LIST_PROGRAM_ID,[CallListUploadMrtNo].[id] AS CALLLISTUPLOADMRTNO_ID  FROM  [CallListUploadMrtNo]  WHERE  [CallListUploadMrtNo].[id] = \'"+x_lId.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[CallListUploadMrtNo]","["+ Configurator.MSSQLTablePrefix + "CallListUploadMrtNo]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(CallListUploadMrtNo.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADMRTNO_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(CallListUploadMrtNo.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CallListUploadMrtNo.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["CALLLISTUPLOADMRTNO_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CallListUploadMrtNo.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(CallListUploadMrtNo.Para.mrt_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADMRTNO_MRT_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(CallListUploadMrtNo.Para.mrt_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CallListUploadMrtNo.Para.mrt_no).AliasName].ToString()] = (string)_oData["CALLLISTUPLOADMRTNO_MRT_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CallListUploadMrtNo.Para.mrt_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(CallListUploadMrtNo.Para.call_list_program_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADMRTNO_CALL_LIST_PROGRAM_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(CallListUploadMrtNo.Para.call_list_program_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CallListUploadMrtNo.Para.call_list_program_id).AliasName].ToString()] = (global::System.Nullable<long>)_oData["CALLLISTUPLOADMRTNO_CALL_LIST_PROGRAM_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CallListUploadMrtNo.Para.call_list_program_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(CallListUploadMrtNo.Para.id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADMRTNO_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(CallListUploadMrtNo.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CallListUploadMrtNo.Para.id).AliasName].ToString()] = (global::System.Nullable<long>)_oData["CALLLISTUPLOADMRTNO_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CallListUploadMrtNo.Para.id).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,CallListUploadMrtNo x_oCallListUploadMrtNoRow)
        {
            return SetByDataSetRowProc(x_iROW, CallListUploadMrtNo.Para.TableName(), x_oDataSet,x_oCallListUploadMrtNoRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,CallListUploadMrtNo x_oCallListUploadMrtNoRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oCallListUploadMrtNoRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,CallListUploadMrtNo x_oCallListUploadMrtNoRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                CallListUploadMrtNoInfo _oTableSet=CallListUploadMrtNoInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(CallListUploadMrtNo.Para.cdate).AliasName))
                    x_oCallListUploadMrtNoRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(CallListUploadMrtNo.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(CallListUploadMrtNo.Para.mrt_no).AliasName))
                    x_oCallListUploadMrtNoRow.mrt_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(CallListUploadMrtNo.Para.mrt_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(CallListUploadMrtNo.Para.call_list_program_id).AliasName))
                    x_oCallListUploadMrtNoRow.call_list_program_id = (global::System.Nullable<long>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(CallListUploadMrtNo.Para.call_list_program_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(CallListUploadMrtNo.Para.id).AliasName))
                    x_oCallListUploadMrtNoRow.id = (global::System.Nullable<long>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(CallListUploadMrtNo.Para.id).AliasName];
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
            return CallListUploadMrtNoRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static CallListUploadMrtNoEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return CallListUploadMrtNoRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static CallListUploadMrtNoEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return CallListUploadMrtNoRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return CallListUploadMrtNoRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return CallListUploadMrtNoRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return CallListUploadMrtNoRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate,string x_sMrt_no,global::System.Nullable<long> x_lCall_list_program_id)
        {
            return CallListUploadMrtNoRepository.Insert(x_oDB, x_dCdate,x_sMrt_no,x_lCall_list_program_id);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,CallListUploadMrtNo x_oCallListUploadMrtNo)
        {
            return CallListUploadMrtNoRepository.InsertWithOutLastID(x_oDB,x_oCallListUploadMrtNo);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sMrt_no,global::System.Nullable<long> x_lCall_list_program_id)
        {
            return CallListUploadMrtNoRepository.InsertReturnLastID_SP(x_oDB,x_dCdate,x_sMrt_no,x_lCall_list_program_id);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, CallListUploadMrtNo x_oCallListUploadMrtNo)
        {
            return CallListUploadMrtNoRepository.InsertReturnLastID_SP(x_oDB,x_oCallListUploadMrtNo);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return CallListUploadMrtNoRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return CallListUploadMrtNoRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<long> x_lId)
        {
            return CallListUploadMrtNoRepository.Delete(x_oDB, x_lId);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(CallListUploadMrtNo x_oCallListUploadMrtNoRow){
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


