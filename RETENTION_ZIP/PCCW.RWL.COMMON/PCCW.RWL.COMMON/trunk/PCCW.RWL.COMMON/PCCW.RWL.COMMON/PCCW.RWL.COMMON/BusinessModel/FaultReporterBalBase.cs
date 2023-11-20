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
///-- Description:	<Description,Table :[FaultReporter],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [FaultReporter] Business layer
    /// </summary>
    
    public abstract class FaultReporterBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public FaultReporterBalBase(){
        }
        ~FaultReporterBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(FaultReporter x_oFaultReporter)
        {
            return GetDataSet(x_oFaultReporter,null,FaultReporterInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(FaultReporter x_oFaultReporter,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oFaultReporter,x_oMergeDSet,FaultReporterInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(FaultReporter x_oFaultReporter,FaultReporterInfo x_oTableSet)
        {
            return GetDataSet(x_oFaultReporter,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(FaultReporter x_oFaultReporter,global::System.Data.DataSet x_oMergeDSet,FaultReporterInfo x_oTableSet)
        {
            return GetDataSet(x_oFaultReporter,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(FaultReporter x_oFaultReporter,global::System.Data.DataSet x_oMergeDSet,FaultReporterInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = FaultReporterInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(FaultReporter.Para.TableName());
            if (x_oTableSet.Fields(FaultReporter.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[FaultReporter.Para.TableName()].Columns.Add(FaultReporter.Para.id); }
            if (x_oTableSet.Fields(FaultReporter.Para.name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[FaultReporter.Para.TableName()].Columns.Add(FaultReporter.Para.name); }
            if (x_oTableSet.Fields(FaultReporter.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[FaultReporter.Para.TableName()].Columns.Add(FaultReporter.Para.cdate); }
            if (x_oTableSet.Fields(FaultReporter.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[FaultReporter.Para.TableName()].Columns.Add(FaultReporter.Para.cid); }
            if (x_oTableSet.Fields(FaultReporter.Para.email).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[FaultReporter.Para.TableName()].Columns.Add(FaultReporter.Para.email); }
            if (x_oTableSet.Fields(FaultReporter.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[FaultReporter.Para.TableName()].Columns.Add(FaultReporter.Para.active); }
            if (x_oTableSet.Fields(FaultReporter.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[FaultReporter.Para.TableName()].Columns.Add(FaultReporter.Para.edate); }
            if (x_oFaultReporter != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[FaultReporter.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(FaultReporter.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[FaultReporter.Para.id] = x_oFaultReporter.GetId(); }
                if (x_oTableSet.Fields(FaultReporter.Para.name).IsView || x_oTableSet.GetViewAll()) { _oDRow[FaultReporter.Para.name] = x_oFaultReporter.GetName(); }
                if (x_oTableSet.Fields(FaultReporter.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[FaultReporter.Para.cdate] = x_oFaultReporter.GetCdate(); }
                if (x_oTableSet.Fields(FaultReporter.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[FaultReporter.Para.cid] = x_oFaultReporter.GetCid(); }
                if (x_oTableSet.Fields(FaultReporter.Para.email).IsView || x_oTableSet.GetViewAll()) { _oDRow[FaultReporter.Para.email] = x_oFaultReporter.GetEmail(); }
                if (x_oTableSet.Fields(FaultReporter.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[FaultReporter.Para.active] = x_oFaultReporter.GetActive(); }
                if (x_oTableSet.Fields(FaultReporter.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDRow[FaultReporter.Para.edate] = x_oFaultReporter.GetEdate(); }
                _oDSet.Tables[FaultReporter.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(FaultReporterInfo x_oTableSet)
        {
            return FaultReporterBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return FaultReporterBal.ToEmptyDataSetProcess(FaultReporterInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(FaultReporterInfo x_oTableSet)
        {
            return FaultReporterBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(FaultReporter x_oFaultReporter, FaultReporterInfo x_oTableSet)
        {
            return FaultReporterBal.GetDataSet(null, null, x_oTableSet).Tables[FaultReporter.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(FaultReporter x_oFaultReporter)
        {
            return FaultReporterBal.GetDataSet(x_oFaultReporter, null, FaultReporterInfoDLL.CreateInfoInstanceObject()).Tables[FaultReporter.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return Row(x_oTable, x_oDB,x_iId,FaultReporterInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId, FaultReporterInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iId, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId,FaultReporterInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = FaultReporterInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [FaultReporter].[active] AS FAULTREPORTER_ACTIVE,[FaultReporter].[name] AS FAULTREPORTER_NAME,[FaultReporter].[cdate] AS FAULTREPORTER_CDATE,[FaultReporter].[cid] AS FAULTREPORTER_CID,[FaultReporter].[email] AS FAULTREPORTER_EMAIL,[FaultReporter].[id] AS FAULTREPORTER_ID,[FaultReporter].[edate] AS FAULTREPORTER_EDATE  FROM  [FaultReporter]  WHERE  [FaultReporter].[id] = \'"+x_iId.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[FaultReporter]","["+ Configurator.MSSQLTablePrefix + "FaultReporter]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(FaultReporter.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["FAULTREPORTER_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(FaultReporter.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(FaultReporter.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["FAULTREPORTER_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(FaultReporter.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(FaultReporter.Para.name).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["FAULTREPORTER_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(FaultReporter.Para.name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(FaultReporter.Para.name).AliasName].ToString()] = (string)_oData["FAULTREPORTER_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(FaultReporter.Para.name).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(FaultReporter.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["FAULTREPORTER_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(FaultReporter.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(FaultReporter.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["FAULTREPORTER_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(FaultReporter.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(FaultReporter.Para.cid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["FAULTREPORTER_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(FaultReporter.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(FaultReporter.Para.cid).AliasName].ToString()] = (string)_oData["FAULTREPORTER_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(FaultReporter.Para.cid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(FaultReporter.Para.email).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["FAULTREPORTER_EMAIL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(FaultReporter.Para.email).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(FaultReporter.Para.email).AliasName].ToString()] = (string)_oData["FAULTREPORTER_EMAIL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(FaultReporter.Para.email).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(FaultReporter.Para.id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["FAULTREPORTER_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(FaultReporter.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(FaultReporter.Para.id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["FAULTREPORTER_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(FaultReporter.Para.id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(FaultReporter.Para.edate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["FAULTREPORTER_EDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(FaultReporter.Para.edate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(FaultReporter.Para.edate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["FAULTREPORTER_EDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(FaultReporter.Para.edate).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,FaultReporter x_oFaultReporterRow)
        {
            return SetByDataSetRowProc(x_iROW, FaultReporter.Para.TableName(), x_oDataSet,x_oFaultReporterRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,FaultReporter x_oFaultReporterRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oFaultReporterRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,FaultReporter x_oFaultReporterRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                FaultReporterInfo _oTableSet=FaultReporterInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(FaultReporter.Para.id).AliasName))
                    x_oFaultReporterRow.id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(FaultReporter.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(FaultReporter.Para.name).AliasName))
                    x_oFaultReporterRow.name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(FaultReporter.Para.name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(FaultReporter.Para.cdate).AliasName))
                    x_oFaultReporterRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(FaultReporter.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(FaultReporter.Para.cid).AliasName))
                    x_oFaultReporterRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(FaultReporter.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(FaultReporter.Para.email).AliasName))
                    x_oFaultReporterRow.email = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(FaultReporter.Para.email).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(FaultReporter.Para.active).AliasName))
                    x_oFaultReporterRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(FaultReporter.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(FaultReporter.Para.edate).AliasName))
                    x_oFaultReporterRow.edate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(FaultReporter.Para.edate).AliasName];
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
            return FaultReporterRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static FaultReporterEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return FaultReporterRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static FaultReporterEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return FaultReporterRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return FaultReporterRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return FaultReporterRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return FaultReporterRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId,string x_sName,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sEmail,global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dEdate)
        {
            return FaultReporterRepository.Insert(x_oDB, x_iId,x_sName,x_dCdate,x_sCid,x_sEmail,x_bActive,x_dEdate);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,FaultReporter x_oFaultReporter)
        {
            return FaultReporterRepository.InsertWithOutLastID(x_oDB,x_oFaultReporter);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId,string x_sName,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sEmail,global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dEdate)
        {
            return FaultReporterRepository.InsertReturnLastID_SP(x_oDB,x_iId,x_sName,x_dCdate,x_sCid,x_sEmail,x_bActive,x_dEdate);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, FaultReporter x_oFaultReporter)
        {
            return FaultReporterRepository.InsertReturnLastID_SP(x_oDB,x_oFaultReporter);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return FaultReporterRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return FaultReporterRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return FaultReporterRepository.Delete(x_oDB, x_iId);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(FaultReporter x_oFaultReporterRow){
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


