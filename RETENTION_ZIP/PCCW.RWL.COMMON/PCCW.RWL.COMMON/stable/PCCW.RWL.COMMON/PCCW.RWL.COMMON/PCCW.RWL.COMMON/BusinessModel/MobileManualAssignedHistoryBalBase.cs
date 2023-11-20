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
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2010-06-09>
///-- Description:	<Description,Table :[MobileManualAssignedHistory],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileManualAssignedHistory] Business layer
    /// </summary>
    
    public abstract class MobileManualAssignedHistoryBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public MobileManualAssignedHistoryBalBase(){
        }
        ~MobileManualAssignedHistoryBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(MobileManualAssignedHistory x_oMobileManualAssignedHistory)
        {
            return GetDataSet(x_oMobileManualAssignedHistory,null,MobileManualAssignedHistoryInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileManualAssignedHistory x_oMobileManualAssignedHistory,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oMobileManualAssignedHistory,x_oMergeDSet,MobileManualAssignedHistoryInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileManualAssignedHistory x_oMobileManualAssignedHistory,MobileManualAssignedHistoryInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileManualAssignedHistory,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileManualAssignedHistory x_oMobileManualAssignedHistory,global::System.Data.DataSet x_oMergeDSet,MobileManualAssignedHistoryInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileManualAssignedHistory,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(MobileManualAssignedHistory x_oMobileManualAssignedHistory,global::System.Data.DataSet x_oMergeDSet,MobileManualAssignedHistoryInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileManualAssignedHistoryInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(MobileManualAssignedHistory.Para.TableName());
            if (x_oTableSet.Fields(MobileManualAssignedHistory.Para.sku).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileManualAssignedHistory.Para.TableName()].Columns.Add(MobileManualAssignedHistory.Para.sku); }
            if (x_oTableSet.Fields(MobileManualAssignedHistory.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileManualAssignedHistory.Para.TableName()].Columns.Add(MobileManualAssignedHistory.Para.order_id); }
            if (x_oTableSet.Fields(MobileManualAssignedHistory.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileManualAssignedHistory.Para.TableName()].Columns.Add(MobileManualAssignedHistory.Para.cdate); }
            if (x_oTableSet.Fields(MobileManualAssignedHistory.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileManualAssignedHistory.Para.TableName()].Columns.Add(MobileManualAssignedHistory.Para.cid); }
            if (x_oTableSet.Fields(MobileManualAssignedHistory.Para.imei_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileManualAssignedHistory.Para.TableName()].Columns.Add(MobileManualAssignedHistory.Para.imei_no); }
            if (x_oTableSet.Fields(MobileManualAssignedHistory.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileManualAssignedHistory.Para.TableName()].Columns.Add(MobileManualAssignedHistory.Para.id); }
            if (x_oMobileManualAssignedHistory != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[MobileManualAssignedHistory.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(MobileManualAssignedHistory.Para.sku).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileManualAssignedHistory.Para.sku] = x_oMobileManualAssignedHistory.GetSku(); }
                if (x_oTableSet.Fields(MobileManualAssignedHistory.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileManualAssignedHistory.Para.order_id] = x_oMobileManualAssignedHistory.GetOrder_id(); }
                if (x_oTableSet.Fields(MobileManualAssignedHistory.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileManualAssignedHistory.Para.cdate] = x_oMobileManualAssignedHistory.GetCdate(); }
                if (x_oTableSet.Fields(MobileManualAssignedHistory.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileManualAssignedHistory.Para.cid] = x_oMobileManualAssignedHistory.GetCid(); }
                if (x_oTableSet.Fields(MobileManualAssignedHistory.Para.imei_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileManualAssignedHistory.Para.imei_no] = x_oMobileManualAssignedHistory.GetImei_no(); }
                if (x_oTableSet.Fields(MobileManualAssignedHistory.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileManualAssignedHistory.Para.id] = x_oMobileManualAssignedHistory.GetId(); }
                _oDSet.Tables[MobileManualAssignedHistory.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(MobileManualAssignedHistoryInfo x_oTableSet)
        {
            return MobileManualAssignedHistoryBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return MobileManualAssignedHistoryBal.ToEmptyDataSetProcess(MobileManualAssignedHistoryInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(MobileManualAssignedHistoryInfo x_oTableSet)
        {
            return MobileManualAssignedHistoryBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(MobileManualAssignedHistory x_oMobileManualAssignedHistory, MobileManualAssignedHistoryInfo x_oTableSet)
        {
            return MobileManualAssignedHistoryBal.GetDataSet(null, null, x_oTableSet).Tables[MobileManualAssignedHistory.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(MobileManualAssignedHistory x_oMobileManualAssignedHistory)
        {
            return MobileManualAssignedHistoryBal.GetDataSet(x_oMobileManualAssignedHistory, null, MobileManualAssignedHistoryInfoDLL.CreateInfoInstanceObject()).Tables[MobileManualAssignedHistory.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return Row(x_oTable, x_oDB,x_iId,MobileManualAssignedHistoryInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId, MobileManualAssignedHistoryInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iId, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId,MobileManualAssignedHistoryInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileManualAssignedHistoryInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [MobileManualAssignedHistory].[sku] AS MOBILEMANUALASSIGNEDHISTORY_SKU,[MobileManualAssignedHistory].[order_id] AS MOBILEMANUALASSIGNEDHISTORY_ORDER_ID,[MobileManualAssignedHistory].[cdate] AS MOBILEMANUALASSIGNEDHISTORY_CDATE,[MobileManualAssignedHistory].[cid] AS MOBILEMANUALASSIGNEDHISTORY_CID,[MobileManualAssignedHistory].[imei_no] AS MOBILEMANUALASSIGNEDHISTORY_IMEI_NO,[MobileManualAssignedHistory].[id] AS MOBILEMANUALASSIGNEDHISTORY_ID  FROM  [MobileManualAssignedHistory]  WHERE  [MobileManualAssignedHistory].[id] = \'"+x_iId.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileManualAssignedHistory]","["+ Configurator.MSSQLTablePrefix + "MobileManualAssignedHistory]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(MobileManualAssignedHistory.Para.sku).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEMANUALASSIGNEDHISTORY_SKU"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileManualAssignedHistory.Para.sku).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileManualAssignedHistory.Para.sku).AliasName].ToString()] = (string)_oData["MOBILEMANUALASSIGNEDHISTORY_SKU"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileManualAssignedHistory.Para.sku).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileManualAssignedHistory.Para.order_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEMANUALASSIGNEDHISTORY_ORDER_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileManualAssignedHistory.Para.order_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileManualAssignedHistory.Para.order_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEMANUALASSIGNEDHISTORY_ORDER_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileManualAssignedHistory.Para.order_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileManualAssignedHistory.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEMANUALASSIGNEDHISTORY_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileManualAssignedHistory.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileManualAssignedHistory.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEMANUALASSIGNEDHISTORY_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileManualAssignedHistory.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileManualAssignedHistory.Para.cid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEMANUALASSIGNEDHISTORY_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileManualAssignedHistory.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileManualAssignedHistory.Para.cid).AliasName].ToString()] = (string)_oData["MOBILEMANUALASSIGNEDHISTORY_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileManualAssignedHistory.Para.cid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileManualAssignedHistory.Para.imei_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEMANUALASSIGNEDHISTORY_IMEI_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileManualAssignedHistory.Para.imei_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileManualAssignedHistory.Para.imei_no).AliasName].ToString()] = (string)_oData["MOBILEMANUALASSIGNEDHISTORY_IMEI_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileManualAssignedHistory.Para.imei_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileManualAssignedHistory.Para.id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEMANUALASSIGNEDHISTORY_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileManualAssignedHistory.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileManualAssignedHistory.Para.id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEMANUALASSIGNEDHISTORY_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileManualAssignedHistory.Para.id).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,MobileManualAssignedHistory x_oMobileManualAssignedHistoryRow)
        {
            return SetByDataSetRowProc(x_iROW, MobileManualAssignedHistory.Para.TableName(), x_oDataSet,x_oMobileManualAssignedHistoryRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileManualAssignedHistory x_oMobileManualAssignedHistoryRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oMobileManualAssignedHistoryRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileManualAssignedHistory x_oMobileManualAssignedHistoryRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                MobileManualAssignedHistoryInfo _oTableSet=MobileManualAssignedHistoryInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileManualAssignedHistory.Para.sku).AliasName))
                    x_oMobileManualAssignedHistoryRow.sku = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileManualAssignedHistory.Para.sku).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileManualAssignedHistory.Para.order_id).AliasName))
                    x_oMobileManualAssignedHistoryRow.order_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileManualAssignedHistory.Para.order_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileManualAssignedHistory.Para.cdate).AliasName))
                    x_oMobileManualAssignedHistoryRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileManualAssignedHistory.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileManualAssignedHistory.Para.cid).AliasName))
                    x_oMobileManualAssignedHistoryRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileManualAssignedHistory.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileManualAssignedHistory.Para.imei_no).AliasName))
                    x_oMobileManualAssignedHistoryRow.imei_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileManualAssignedHistory.Para.imei_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileManualAssignedHistory.Para.id).AliasName))
                    x_oMobileManualAssignedHistoryRow.id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileManualAssignedHistory.Para.id).AliasName];
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
            return MobileManualAssignedHistoryRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static MobileManualAssignedHistoryEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return MobileManualAssignedHistoryRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static MobileManualAssignedHistoryEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return MobileManualAssignedHistoryRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileManualAssignedHistoryRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileManualAssignedHistoryRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return MobileManualAssignedHistoryRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sSku,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sImei_no)
        {
            return MobileManualAssignedHistoryRepository.Insert(x_oDB, x_sSku,x_iOrder_id,x_dCdate,x_sCid,x_sImei_no);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileManualAssignedHistory x_oMobileManualAssignedHistory)
        {
            return MobileManualAssignedHistoryRepository.InsertWithOutLastID(x_oDB,x_oMobileManualAssignedHistory);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sSku,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sImei_no)
        {
            return MobileManualAssignedHistoryRepository.InsertReturnLastID_SP(x_oDB,x_sSku,x_iOrder_id,x_dCdate,x_sCid,x_sImei_no);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileManualAssignedHistory x_oMobileManualAssignedHistory)
        {
            return MobileManualAssignedHistoryRepository.InsertReturnLastID_SP(x_oDB,x_oMobileManualAssignedHistory);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return MobileManualAssignedHistoryRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return MobileManualAssignedHistoryRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return MobileManualAssignedHistoryRepository.Delete(x_oDB, x_iId);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(MobileManualAssignedHistory x_oMobileManualAssignedHistoryRow){
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


