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
///-- Create date: <Create Date 2011-10-31>
///-- Description:	<Description,Table :[DeliveryTime],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [DeliveryTime] Business layer
    /// </summary>
    
    public abstract class DeliveryTimeBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public DeliveryTimeBalBase(){
        }
        ~DeliveryTimeBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(DeliveryTime x_oDeliveryTime)
        {
            return GetDataSet(x_oDeliveryTime,null,DeliveryTimeInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(DeliveryTime x_oDeliveryTime,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oDeliveryTime,x_oMergeDSet,DeliveryTimeInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(DeliveryTime x_oDeliveryTime,DeliveryTimeInfo x_oTableSet)
        {
            return GetDataSet(x_oDeliveryTime,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(DeliveryTime x_oDeliveryTime,global::System.Data.DataSet x_oMergeDSet,DeliveryTimeInfo x_oTableSet)
        {
            return GetDataSet(x_oDeliveryTime,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(DeliveryTime x_oDeliveryTime,global::System.Data.DataSet x_oMergeDSet,DeliveryTimeInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = DeliveryTimeInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(DeliveryTime.Para.TableName());
            if (x_oTableSet.Fields(DeliveryTime.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DeliveryTime.Para.TableName()].Columns.Add(DeliveryTime.Para.id); }
            if (x_oTableSet.Fields(DeliveryTime.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DeliveryTime.Para.TableName()].Columns.Add(DeliveryTime.Para.cdate); }
            if (x_oTableSet.Fields(DeliveryTime.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DeliveryTime.Para.TableName()].Columns.Add(DeliveryTime.Para.cid); }
            if (x_oTableSet.Fields(DeliveryTime.Para.location).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DeliveryTime.Para.TableName()].Columns.Add(DeliveryTime.Para.location); }
            if (x_oTableSet.Fields(DeliveryTime.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DeliveryTime.Para.TableName()].Columns.Add(DeliveryTime.Para.active); }
            if (x_oTableSet.Fields(DeliveryTime.Para.period).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DeliveryTime.Para.TableName()].Columns.Add(DeliveryTime.Para.period); }
            if (x_oDeliveryTime != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[DeliveryTime.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(DeliveryTime.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[DeliveryTime.Para.id] = x_oDeliveryTime.GetId(); }
                if (x_oTableSet.Fields(DeliveryTime.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[DeliveryTime.Para.cdate] = x_oDeliveryTime.GetCdate(); }
                if (x_oTableSet.Fields(DeliveryTime.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[DeliveryTime.Para.cid] = x_oDeliveryTime.GetCid(); }
                if (x_oTableSet.Fields(DeliveryTime.Para.location).IsView || x_oTableSet.GetViewAll()) { _oDRow[DeliveryTime.Para.location] = x_oDeliveryTime.GetLocation(); }
                if (x_oTableSet.Fields(DeliveryTime.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[DeliveryTime.Para.active] = x_oDeliveryTime.GetActive(); }
                if (x_oTableSet.Fields(DeliveryTime.Para.period).IsView || x_oTableSet.GetViewAll()) { _oDRow[DeliveryTime.Para.period] = x_oDeliveryTime.GetPeriod(); }
                _oDSet.Tables[DeliveryTime.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(DeliveryTimeInfo x_oTableSet)
        {
            return DeliveryTimeBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return DeliveryTimeBal.ToEmptyDataSetProcess(DeliveryTimeInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(DeliveryTimeInfo x_oTableSet)
        {
            return DeliveryTimeBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(DeliveryTime x_oDeliveryTime, DeliveryTimeInfo x_oTableSet)
        {
            return DeliveryTimeBal.GetDataSet(null, null, x_oTableSet).Tables[DeliveryTime.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(DeliveryTime x_oDeliveryTime)
        {
            return DeliveryTimeBal.GetDataSet(x_oDeliveryTime, null, DeliveryTimeInfoDLL.CreateInfoInstanceObject()).Tables[DeliveryTime.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return Row(x_oTable, x_oDB,x_iId,DeliveryTimeInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId, DeliveryTimeInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iId, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId,DeliveryTimeInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = DeliveryTimeInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [DeliveryTime].[active] AS DELIVERYTIME_ACTIVE,[DeliveryTime].[cdate] AS DELIVERYTIME_CDATE,[DeliveryTime].[cid] AS DELIVERYTIME_CID,[DeliveryTime].[location] AS DELIVERYTIME_LOCATION,[DeliveryTime].[id] AS DELIVERYTIME_ID,[DeliveryTime].[period] AS DELIVERYTIME_PERIOD  FROM  [DeliveryTime]  WHERE  [DeliveryTime].[id] = \'"+x_iId.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DeliveryTime]","["+ Configurator.MSSQLTablePrefix + "DeliveryTime]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(DeliveryTime.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIME_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DeliveryTime.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTime.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["DELIVERYTIME_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTime.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(DeliveryTime.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIME_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DeliveryTime.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTime.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["DELIVERYTIME_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTime.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(DeliveryTime.Para.cid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIME_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DeliveryTime.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTime.Para.cid).AliasName].ToString()] = (string)_oData["DELIVERYTIME_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTime.Para.cid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(DeliveryTime.Para.location).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIME_LOCATION"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DeliveryTime.Para.location).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTime.Para.location).AliasName].ToString()] = (string)_oData["DELIVERYTIME_LOCATION"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTime.Para.location).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(DeliveryTime.Para.id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIME_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DeliveryTime.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTime.Para.id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["DELIVERYTIME_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTime.Para.id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(DeliveryTime.Para.period).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIME_PERIOD"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DeliveryTime.Para.period).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTime.Para.period).AliasName].ToString()] = (string)_oData["DELIVERYTIME_PERIOD"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTime.Para.period).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,DeliveryTime x_oDeliveryTimeRow)
        {
            return SetByDataSetRowProc(x_iROW, DeliveryTime.Para.TableName(), x_oDataSet,x_oDeliveryTimeRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,DeliveryTime x_oDeliveryTimeRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oDeliveryTimeRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,DeliveryTime x_oDeliveryTimeRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                DeliveryTimeInfo _oTableSet=DeliveryTimeInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DeliveryTime.Para.id).AliasName))
                    x_oDeliveryTimeRow.id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DeliveryTime.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DeliveryTime.Para.cdate).AliasName))
                    x_oDeliveryTimeRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DeliveryTime.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DeliveryTime.Para.cid).AliasName))
                    x_oDeliveryTimeRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DeliveryTime.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DeliveryTime.Para.location).AliasName))
                    x_oDeliveryTimeRow.location = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DeliveryTime.Para.location).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DeliveryTime.Para.active).AliasName))
                    x_oDeliveryTimeRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DeliveryTime.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DeliveryTime.Para.period).AliasName))
                    x_oDeliveryTimeRow.period = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DeliveryTime.Para.period).AliasName];
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
            return DeliveryTimeRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static DeliveryTimeEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return DeliveryTimeRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static DeliveryTimeEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return DeliveryTimeRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return DeliveryTimeRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return DeliveryTimeRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return DeliveryTimeRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sLocation,global::System.Nullable<bool> x_bActive,string x_sPeriod)
        {
            return DeliveryTimeRepository.Insert(x_oDB, x_dCdate,x_sCid,x_sLocation,x_bActive,x_sPeriod);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,DeliveryTime x_oDeliveryTime)
        {
            return DeliveryTimeRepository.InsertWithOutLastID(x_oDB,x_oDeliveryTime);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sLocation,global::System.Nullable<bool> x_bActive,string x_sPeriod)
        {
            return DeliveryTimeRepository.InsertReturnLastID_SP(x_oDB,x_dCdate,x_sCid,x_sLocation,x_bActive,x_sPeriod);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, DeliveryTime x_oDeliveryTime)
        {
            return DeliveryTimeRepository.InsertReturnLastID_SP(x_oDB,x_oDeliveryTime);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return DeliveryTimeRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return DeliveryTimeRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return DeliveryTimeRepository.Delete(x_oDB, x_iId);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(DeliveryTime x_oDeliveryTimeRow){
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


