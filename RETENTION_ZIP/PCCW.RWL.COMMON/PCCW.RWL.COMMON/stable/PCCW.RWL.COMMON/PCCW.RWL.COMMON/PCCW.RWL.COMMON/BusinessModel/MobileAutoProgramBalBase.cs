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
///-- Create date: <Create Date 2010-06-11>
///-- Description:	<Description,Table :[MobileAutoProgram],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileAutoProgram] Business layer
    /// </summary>
    
    public abstract class MobileAutoProgramBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public MobileAutoProgramBalBase(){
        }
        ~MobileAutoProgramBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(MobileAutoProgram x_oMobileAutoProgram)
        {
            return GetDataSet(x_oMobileAutoProgram,null,MobileAutoProgramInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileAutoProgram x_oMobileAutoProgram,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oMobileAutoProgram,x_oMergeDSet,MobileAutoProgramInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileAutoProgram x_oMobileAutoProgram,MobileAutoProgramInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileAutoProgram,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileAutoProgram x_oMobileAutoProgram,global::System.Data.DataSet x_oMergeDSet,MobileAutoProgramInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileAutoProgram,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(MobileAutoProgram x_oMobileAutoProgram,global::System.Data.DataSet x_oMergeDSet,MobileAutoProgramInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileAutoProgramInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(MobileAutoProgram.Para.TableName());
            if (x_oTableSet.Fields(MobileAutoProgram.Para.rdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileAutoProgram.Para.TableName()].Columns.Add(MobileAutoProgram.Para.rdate); }
            if (x_oTableSet.Fields(MobileAutoProgram.Para.auto_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileAutoProgram.Para.TableName()].Columns.Add(MobileAutoProgram.Para.auto_name); }
            if (x_oTableSet.Fields(MobileAutoProgram.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileAutoProgram.Para.TableName()].Columns.Add(MobileAutoProgram.Para.id); }
            if (x_oTableSet.Fields(MobileAutoProgram.Para.guid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileAutoProgram.Para.TableName()].Columns.Add(MobileAutoProgram.Para.guid); }
            if (x_oTableSet.Fields(MobileAutoProgram.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileAutoProgram.Para.TableName()].Columns.Add(MobileAutoProgram.Para.active); }
            if (x_oMobileAutoProgram != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[MobileAutoProgram.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(MobileAutoProgram.Para.rdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileAutoProgram.Para.rdate] = x_oMobileAutoProgram.GetRdate(); }
                if (x_oTableSet.Fields(MobileAutoProgram.Para.auto_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileAutoProgram.Para.auto_name] = x_oMobileAutoProgram.GetAuto_name(); }
                if (x_oTableSet.Fields(MobileAutoProgram.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileAutoProgram.Para.id] = x_oMobileAutoProgram.GetId(); }
                if (x_oTableSet.Fields(MobileAutoProgram.Para.guid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileAutoProgram.Para.guid] = x_oMobileAutoProgram.GetGuid(); }
                if (x_oTableSet.Fields(MobileAutoProgram.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileAutoProgram.Para.active] = x_oMobileAutoProgram.GetActive(); }
                _oDSet.Tables[MobileAutoProgram.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(MobileAutoProgramInfo x_oTableSet)
        {
            return MobileAutoProgramBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return MobileAutoProgramBal.ToEmptyDataSetProcess(MobileAutoProgramInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(MobileAutoProgramInfo x_oTableSet)
        {
            return MobileAutoProgramBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(MobileAutoProgram x_oMobileAutoProgram, MobileAutoProgramInfo x_oTableSet)
        {
            return MobileAutoProgramBal.GetDataSet(null, null, x_oTableSet).Tables[MobileAutoProgram.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(MobileAutoProgram x_oMobileAutoProgram)
        {
            return MobileAutoProgramBal.GetDataSet(x_oMobileAutoProgram, null, MobileAutoProgramInfoDLL.CreateInfoInstanceObject()).Tables[MobileAutoProgram.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return Row(x_oTable, x_oDB,x_iId,MobileAutoProgramInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId, MobileAutoProgramInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iId, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId,MobileAutoProgramInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileAutoProgramInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [MobileAutoProgram].[rdate] AS MOBILEAUTOPROGRAM_RDATE,[MobileAutoProgram].[auto_name] AS MOBILEAUTOPROGRAM_AUTO_NAME,[MobileAutoProgram].[active] AS MOBILEAUTOPROGRAM_ACTIVE,[MobileAutoProgram].[guid] AS MOBILEAUTOPROGRAM_GUID,[MobileAutoProgram].[id] AS MOBILEAUTOPROGRAM_ID  FROM  [MobileAutoProgram]  WHERE  [MobileAutoProgram].[id] = \'"+x_iId.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileAutoProgram]","["+ Configurator.MSSQLTablePrefix + "MobileAutoProgram]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(MobileAutoProgram.Para.rdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEAUTOPROGRAM_RDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileAutoProgram.Para.rdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileAutoProgram.Para.rdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEAUTOPROGRAM_RDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileAutoProgram.Para.rdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileAutoProgram.Para.auto_name).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEAUTOPROGRAM_AUTO_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileAutoProgram.Para.auto_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileAutoProgram.Para.auto_name).AliasName].ToString()] = (string)_oData["MOBILEAUTOPROGRAM_AUTO_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileAutoProgram.Para.auto_name).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileAutoProgram.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEAUTOPROGRAM_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileAutoProgram.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileAutoProgram.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILEAUTOPROGRAM_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileAutoProgram.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileAutoProgram.Para.guid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEAUTOPROGRAM_GUID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileAutoProgram.Para.guid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileAutoProgram.Para.guid).AliasName].ToString()] = (global::System.Nullable<Guid>)_oData["MOBILEAUTOPROGRAM_GUID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileAutoProgram.Para.guid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileAutoProgram.Para.id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEAUTOPROGRAM_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileAutoProgram.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileAutoProgram.Para.id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEAUTOPROGRAM_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileAutoProgram.Para.id).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,MobileAutoProgram x_oMobileAutoProgramRow)
        {
            return SetByDataSetRowProc(x_iROW, MobileAutoProgram.Para.TableName(), x_oDataSet,x_oMobileAutoProgramRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileAutoProgram x_oMobileAutoProgramRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oMobileAutoProgramRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileAutoProgram x_oMobileAutoProgramRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                MobileAutoProgramInfo _oTableSet=MobileAutoProgramInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileAutoProgram.Para.rdate).AliasName))
                    x_oMobileAutoProgramRow.rdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileAutoProgram.Para.rdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileAutoProgram.Para.auto_name).AliasName))
                    x_oMobileAutoProgramRow.auto_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileAutoProgram.Para.auto_name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileAutoProgram.Para.id).AliasName))
                    x_oMobileAutoProgramRow.id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileAutoProgram.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileAutoProgram.Para.guid).AliasName))
                    x_oMobileAutoProgramRow.guid = (global::System.Nullable<Guid>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileAutoProgram.Para.guid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileAutoProgram.Para.active).AliasName))
                    x_oMobileAutoProgramRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileAutoProgram.Para.active).AliasName];
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
            return MobileAutoProgramRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static MobileAutoProgramEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return MobileAutoProgramRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static MobileAutoProgramEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return MobileAutoProgramRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileAutoProgramRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileAutoProgramRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return MobileAutoProgramRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dRdate,string x_sAuto_name,global::System.Nullable<Guid> x_gGuid,global::System.Nullable<bool> x_bActive)
        {
            return MobileAutoProgramRepository.Insert(x_oDB, x_dRdate,x_sAuto_name,x_gGuid,x_bActive);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileAutoProgram x_oMobileAutoProgram)
        {
            return MobileAutoProgramRepository.InsertWithOutLastID(x_oDB,x_oMobileAutoProgram);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dRdate,string x_sAuto_name,global::System.Nullable<Guid> x_gGuid,global::System.Nullable<bool> x_bActive)
        {
            return MobileAutoProgramRepository.InsertReturnLastID_SP(x_oDB,x_dRdate,x_sAuto_name,x_gGuid,x_bActive);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileAutoProgram x_oMobileAutoProgram)
        {
            return MobileAutoProgramRepository.InsertReturnLastID_SP(x_oDB,x_oMobileAutoProgram);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return MobileAutoProgramRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return MobileAutoProgramRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return MobileAutoProgramRepository.Delete(x_oDB, x_iId);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(MobileAutoProgram x_oMobileAutoProgramRow){
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


