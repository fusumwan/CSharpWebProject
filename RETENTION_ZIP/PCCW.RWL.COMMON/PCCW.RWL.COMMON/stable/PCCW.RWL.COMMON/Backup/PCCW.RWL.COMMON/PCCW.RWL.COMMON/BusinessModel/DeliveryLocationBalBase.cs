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
///-- Create date: <Create Date 2011-10-31>
///-- Description:	<Description,Table :[DeliveryLocation],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [DeliveryLocation] Business layer
    /// </summary>
    
    public abstract class DeliveryLocationBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public DeliveryLocationBalBase(){
        }
        ~DeliveryLocationBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(DeliveryLocation x_oDeliveryLocation)
        {
            return GetDataSet(x_oDeliveryLocation,null,DeliveryLocationInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(DeliveryLocation x_oDeliveryLocation,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oDeliveryLocation,x_oMergeDSet,DeliveryLocationInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(DeliveryLocation x_oDeliveryLocation,DeliveryLocationInfo x_oTableSet)
        {
            return GetDataSet(x_oDeliveryLocation,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(DeliveryLocation x_oDeliveryLocation,global::System.Data.DataSet x_oMergeDSet,DeliveryLocationInfo x_oTableSet)
        {
            return GetDataSet(x_oDeliveryLocation,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(DeliveryLocation x_oDeliveryLocation,global::System.Data.DataSet x_oMergeDSet,DeliveryLocationInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = DeliveryLocationInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(DeliveryLocation.Para.TableName());
            if (x_oTableSet.Fields(DeliveryLocation.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DeliveryLocation.Para.TableName()].Columns.Add(DeliveryLocation.Para.id); }
            if (x_oTableSet.Fields(DeliveryLocation.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DeliveryLocation.Para.TableName()].Columns.Add(DeliveryLocation.Para.cdate); }
            if (x_oTableSet.Fields(DeliveryLocation.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DeliveryLocation.Para.TableName()].Columns.Add(DeliveryLocation.Para.cid); }
            if (x_oTableSet.Fields(DeliveryLocation.Para.location).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DeliveryLocation.Para.TableName()].Columns.Add(DeliveryLocation.Para.location); }
            if (x_oTableSet.Fields(DeliveryLocation.Para.fee).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DeliveryLocation.Para.TableName()].Columns.Add(DeliveryLocation.Para.fee); }
            if (x_oTableSet.Fields(DeliveryLocation.Para.area).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DeliveryLocation.Para.TableName()].Columns.Add(DeliveryLocation.Para.area); }
            if (x_oTableSet.Fields(DeliveryLocation.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DeliveryLocation.Para.TableName()].Columns.Add(DeliveryLocation.Para.active); }
            if (x_oDeliveryLocation != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[DeliveryLocation.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(DeliveryLocation.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[DeliveryLocation.Para.id] = x_oDeliveryLocation.GetId(); }
                if (x_oTableSet.Fields(DeliveryLocation.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[DeliveryLocation.Para.cdate] = x_oDeliveryLocation.GetCdate(); }
                if (x_oTableSet.Fields(DeliveryLocation.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[DeliveryLocation.Para.cid] = x_oDeliveryLocation.GetCid(); }
                if (x_oTableSet.Fields(DeliveryLocation.Para.location).IsView || x_oTableSet.GetViewAll()) { _oDRow[DeliveryLocation.Para.location] = x_oDeliveryLocation.GetLocation(); }
                if (x_oTableSet.Fields(DeliveryLocation.Para.fee).IsView || x_oTableSet.GetViewAll()) { _oDRow[DeliveryLocation.Para.fee] = x_oDeliveryLocation.GetFee(); }
                if (x_oTableSet.Fields(DeliveryLocation.Para.area).IsView || x_oTableSet.GetViewAll()) { _oDRow[DeliveryLocation.Para.area] = x_oDeliveryLocation.GetArea(); }
                if (x_oTableSet.Fields(DeliveryLocation.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[DeliveryLocation.Para.active] = x_oDeliveryLocation.GetActive(); }
                _oDSet.Tables[DeliveryLocation.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(DeliveryLocationInfo x_oTableSet)
        {
            return DeliveryLocationBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return DeliveryLocationBal.ToEmptyDataSetProcess(DeliveryLocationInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(DeliveryLocationInfo x_oTableSet)
        {
            return DeliveryLocationBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(DeliveryLocation x_oDeliveryLocation, DeliveryLocationInfo x_oTableSet)
        {
            return DeliveryLocationBal.GetDataSet(null, null, x_oTableSet).Tables[DeliveryLocation.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(DeliveryLocation x_oDeliveryLocation)
        {
            return DeliveryLocationBal.GetDataSet(x_oDeliveryLocation, null, DeliveryLocationInfoDLL.CreateInfoInstanceObject()).Tables[DeliveryLocation.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return Row(x_oTable, x_oDB,x_iId,DeliveryLocationInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId, DeliveryLocationInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iId, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId,DeliveryLocationInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = DeliveryLocationInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [DeliveryLocation].[active] AS DELIVERYLOCATION_ACTIVE,[DeliveryLocation].[cdate] AS DELIVERYLOCATION_CDATE,[DeliveryLocation].[cid] AS DELIVERYLOCATION_CID,[DeliveryLocation].[location] AS DELIVERYLOCATION_LOCATION,[DeliveryLocation].[fee] AS DELIVERYLOCATION_FEE,[DeliveryLocation].[area] AS DELIVERYLOCATION_AREA,[DeliveryLocation].[id] AS DELIVERYLOCATION_ID  FROM  [DeliveryLocation]  WHERE  [DeliveryLocation].[id] = \'"+x_iId.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DeliveryLocation]","["+ Configurator.MSSQLTablePrefix + "DeliveryLocation]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(DeliveryLocation.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["DELIVERYLOCATION_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DeliveryLocation.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryLocation.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["DELIVERYLOCATION_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryLocation.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(DeliveryLocation.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["DELIVERYLOCATION_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DeliveryLocation.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryLocation.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["DELIVERYLOCATION_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryLocation.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(DeliveryLocation.Para.cid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["DELIVERYLOCATION_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DeliveryLocation.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryLocation.Para.cid).AliasName].ToString()] = (string)_oData["DELIVERYLOCATION_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryLocation.Para.cid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(DeliveryLocation.Para.location).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["DELIVERYLOCATION_LOCATION"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DeliveryLocation.Para.location).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryLocation.Para.location).AliasName].ToString()] = (string)_oData["DELIVERYLOCATION_LOCATION"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryLocation.Para.location).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(DeliveryLocation.Para.fee).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["DELIVERYLOCATION_FEE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DeliveryLocation.Para.fee).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryLocation.Para.fee).AliasName].ToString()] = (string)_oData["DELIVERYLOCATION_FEE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryLocation.Para.fee).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(DeliveryLocation.Para.area).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["DELIVERYLOCATION_AREA"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DeliveryLocation.Para.area).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryLocation.Para.area).AliasName].ToString()] = (string)_oData["DELIVERYLOCATION_AREA"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryLocation.Para.area).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(DeliveryLocation.Para.id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["DELIVERYLOCATION_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DeliveryLocation.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryLocation.Para.id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["DELIVERYLOCATION_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryLocation.Para.id).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,DeliveryLocation x_oDeliveryLocationRow)
        {
            return SetByDataSetRowProc(x_iROW, DeliveryLocation.Para.TableName(), x_oDataSet,x_oDeliveryLocationRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,DeliveryLocation x_oDeliveryLocationRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oDeliveryLocationRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,DeliveryLocation x_oDeliveryLocationRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                DeliveryLocationInfo _oTableSet=DeliveryLocationInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DeliveryLocation.Para.id).AliasName))
                    x_oDeliveryLocationRow.id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DeliveryLocation.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DeliveryLocation.Para.cdate).AliasName))
                    x_oDeliveryLocationRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DeliveryLocation.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DeliveryLocation.Para.cid).AliasName))
                    x_oDeliveryLocationRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DeliveryLocation.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DeliveryLocation.Para.location).AliasName))
                    x_oDeliveryLocationRow.location = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DeliveryLocation.Para.location).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DeliveryLocation.Para.fee).AliasName))
                    x_oDeliveryLocationRow.fee = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DeliveryLocation.Para.fee).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DeliveryLocation.Para.area).AliasName))
                    x_oDeliveryLocationRow.area = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DeliveryLocation.Para.area).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DeliveryLocation.Para.active).AliasName))
                    x_oDeliveryLocationRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DeliveryLocation.Para.active).AliasName];
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
            return DeliveryLocationRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static DeliveryLocationEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return DeliveryLocationRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static DeliveryLocationEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return DeliveryLocationRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return DeliveryLocationRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return DeliveryLocationRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return DeliveryLocationRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sLocation,string x_sFee,string x_sArea,global::System.Nullable<bool> x_bActive)
        {
            return DeliveryLocationRepository.Insert(x_oDB, x_dCdate,x_sCid,x_sLocation,x_sFee,x_sArea,x_bActive);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,DeliveryLocation x_oDeliveryLocation)
        {
            return DeliveryLocationRepository.InsertWithOutLastID(x_oDB,x_oDeliveryLocation);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sLocation,string x_sFee,string x_sArea,global::System.Nullable<bool> x_bActive)
        {
            return DeliveryLocationRepository.InsertReturnLastID_SP(x_oDB,x_dCdate,x_sCid,x_sLocation,x_sFee,x_sArea,x_bActive);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, DeliveryLocation x_oDeliveryLocation)
        {
            return DeliveryLocationRepository.InsertReturnLastID_SP(x_oDB,x_oDeliveryLocation);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return DeliveryLocationRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return DeliveryLocationRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return DeliveryLocationRepository.Delete(x_oDB, x_iId);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(DeliveryLocation x_oDeliveryLocationRow){
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


