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
///-- Create date: <Create Date 2010-12-17>
///-- Description:	<Description,Table :[MobileOrderIssueRestriction],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderIssueRestriction] Business layer
    /// </summary>
    
    public abstract class MobileOrderIssueRestrictionBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public MobileOrderIssueRestrictionBalBase(){
        }
        ~MobileOrderIssueRestrictionBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderIssueRestriction x_oMobileOrderIssueRestriction)
        {
            return GetDataSet(x_oMobileOrderIssueRestriction,null,MobileOrderIssueRestrictionInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderIssueRestriction x_oMobileOrderIssueRestriction,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oMobileOrderIssueRestriction,x_oMergeDSet,MobileOrderIssueRestrictionInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderIssueRestriction x_oMobileOrderIssueRestriction,MobileOrderIssueRestrictionInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderIssueRestriction,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderIssueRestriction x_oMobileOrderIssueRestriction,global::System.Data.DataSet x_oMergeDSet,MobileOrderIssueRestrictionInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderIssueRestriction,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(MobileOrderIssueRestriction x_oMobileOrderIssueRestriction,global::System.Data.DataSet x_oMergeDSet,MobileOrderIssueRestrictionInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderIssueRestrictionInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(MobileOrderIssueRestriction.Para.TableName());
            if (x_oTableSet.Fields(MobileOrderIssueRestriction.Para.name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderIssueRestriction.Para.TableName()].Columns.Add(MobileOrderIssueRestriction.Para.name); }
            if (x_oTableSet.Fields(MobileOrderIssueRestriction.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderIssueRestriction.Para.TableName()].Columns.Add(MobileOrderIssueRestriction.Para.cdate); }
            if (x_oTableSet.Fields(MobileOrderIssueRestriction.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderIssueRestriction.Para.TableName()].Columns.Add(MobileOrderIssueRestriction.Para.cid); }
            if (x_oTableSet.Fields(MobileOrderIssueRestriction.Para.type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderIssueRestriction.Para.TableName()].Columns.Add(MobileOrderIssueRestriction.Para.type); }
            if (x_oTableSet.Fields(MobileOrderIssueRestriction.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderIssueRestriction.Para.TableName()].Columns.Add(MobileOrderIssueRestriction.Para.active); }
            if (x_oTableSet.Fields(MobileOrderIssueRestriction.Para.restriction_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderIssueRestriction.Para.TableName()].Columns.Add(MobileOrderIssueRestriction.Para.restriction_id); }
            if (x_oMobileOrderIssueRestriction != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[MobileOrderIssueRestriction.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(MobileOrderIssueRestriction.Para.name).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderIssueRestriction.Para.name] = x_oMobileOrderIssueRestriction.GetName(); }
                if (x_oTableSet.Fields(MobileOrderIssueRestriction.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderIssueRestriction.Para.cdate] = x_oMobileOrderIssueRestriction.GetCdate(); }
                if (x_oTableSet.Fields(MobileOrderIssueRestriction.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderIssueRestriction.Para.cid] = x_oMobileOrderIssueRestriction.GetCid(); }
                if (x_oTableSet.Fields(MobileOrderIssueRestriction.Para.type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderIssueRestriction.Para.type] = x_oMobileOrderIssueRestriction.GetType(); }
                if (x_oTableSet.Fields(MobileOrderIssueRestriction.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderIssueRestriction.Para.active] = x_oMobileOrderIssueRestriction.GetActive(); }
                if (x_oTableSet.Fields(MobileOrderIssueRestriction.Para.restriction_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderIssueRestriction.Para.restriction_id] = x_oMobileOrderIssueRestriction.GetRestriction_id(); }
                _oDSet.Tables[MobileOrderIssueRestriction.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(MobileOrderIssueRestrictionInfo x_oTableSet)
        {
            return MobileOrderIssueRestrictionBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return MobileOrderIssueRestrictionBal.ToEmptyDataSetProcess(MobileOrderIssueRestrictionInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(MobileOrderIssueRestrictionInfo x_oTableSet)
        {
            return MobileOrderIssueRestrictionBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(MobileOrderIssueRestriction x_oMobileOrderIssueRestriction, MobileOrderIssueRestrictionInfo x_oTableSet)
        {
            return MobileOrderIssueRestrictionBal.GetDataSet(null, null, x_oTableSet).Tables[MobileOrderIssueRestriction.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(MobileOrderIssueRestriction x_oMobileOrderIssueRestriction)
        {
            return MobileOrderIssueRestrictionBal.GetDataSet(x_oMobileOrderIssueRestriction, null, MobileOrderIssueRestrictionInfoDLL.CreateInfoInstanceObject()).Tables[MobileOrderIssueRestriction.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iRestriction_id)
        {
            return Row(x_oTable, x_oDB,x_iRestriction_id,MobileOrderIssueRestrictionInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iRestriction_id, MobileOrderIssueRestrictionInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iRestriction_id, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iRestriction_id,MobileOrderIssueRestrictionInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderIssueRestrictionInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [MobileOrderIssueRestriction].[name] AS MOBILEORDERISSUERESTRICTION_NAME,[MobileOrderIssueRestriction].[cdate] AS MOBILEORDERISSUERESTRICTION_CDATE,[MobileOrderIssueRestriction].[cid] AS MOBILEORDERISSUERESTRICTION_CID,[MobileOrderIssueRestriction].[type] AS MOBILEORDERISSUERESTRICTION_TYPE,[MobileOrderIssueRestriction].[active] AS MOBILEORDERISSUERESTRICTION_ACTIVE,[MobileOrderIssueRestriction].[restriction_id] AS MOBILEORDERISSUERESTRICTION_RESTRICTION_ID  FROM  [MobileOrderIssueRestriction]  WHERE  [MobileOrderIssueRestriction].[restriction_id] = \'"+x_iRestriction_id.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderIssueRestriction]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestriction]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(MobileOrderIssueRestriction.Para.name).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTION_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderIssueRestriction.Para.name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestriction.Para.name).AliasName].ToString()] = (string)_oData["MOBILEORDERISSUERESTRICTION_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestriction.Para.name).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderIssueRestriction.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTION_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderIssueRestriction.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestriction.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERISSUERESTRICTION_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestriction.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderIssueRestriction.Para.cid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTION_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderIssueRestriction.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestriction.Para.cid).AliasName].ToString()] = (string)_oData["MOBILEORDERISSUERESTRICTION_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestriction.Para.cid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderIssueRestriction.Para.type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTION_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderIssueRestriction.Para.type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestriction.Para.type).AliasName].ToString()] = (string)_oData["MOBILEORDERISSUERESTRICTION_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestriction.Para.type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderIssueRestriction.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTION_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderIssueRestriction.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestriction.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILEORDERISSUERESTRICTION_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestriction.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderIssueRestriction.Para.restriction_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTION_RESTRICTION_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderIssueRestriction.Para.restriction_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestriction.Para.restriction_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERISSUERESTRICTION_RESTRICTION_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestriction.Para.restriction_id).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,MobileOrderIssueRestriction x_oMobileOrderIssueRestrictionRow)
        {
            return SetByDataSetRowProc(x_iROW, MobileOrderIssueRestriction.Para.TableName(), x_oDataSet,x_oMobileOrderIssueRestrictionRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderIssueRestriction x_oMobileOrderIssueRestrictionRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oMobileOrderIssueRestrictionRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderIssueRestriction x_oMobileOrderIssueRestrictionRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                MobileOrderIssueRestrictionInfo _oTableSet=MobileOrderIssueRestrictionInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderIssueRestriction.Para.name).AliasName))
                    x_oMobileOrderIssueRestrictionRow.name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderIssueRestriction.Para.name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderIssueRestriction.Para.cdate).AliasName))
                    x_oMobileOrderIssueRestrictionRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderIssueRestriction.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderIssueRestriction.Para.cid).AliasName))
                    x_oMobileOrderIssueRestrictionRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderIssueRestriction.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderIssueRestriction.Para.type).AliasName))
                    x_oMobileOrderIssueRestrictionRow.type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderIssueRestriction.Para.type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderIssueRestriction.Para.active).AliasName))
                    x_oMobileOrderIssueRestrictionRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderIssueRestriction.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderIssueRestriction.Para.restriction_id).AliasName))
                    x_oMobileOrderIssueRestrictionRow.restriction_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderIssueRestriction.Para.restriction_id).AliasName];
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
            return MobileOrderIssueRestrictionRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static MobileOrderIssueRestrictionEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return MobileOrderIssueRestrictionRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static MobileOrderIssueRestrictionEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return MobileOrderIssueRestrictionRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderIssueRestrictionRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderIssueRestrictionRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderIssueRestrictionRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sName,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sType,global::System.Nullable<bool> x_bActive)
        {
            return MobileOrderIssueRestrictionRepository.Insert(x_oDB, x_sName,x_dCdate,x_sCid,x_sType,x_bActive);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderIssueRestriction x_oMobileOrderIssueRestriction)
        {
            return MobileOrderIssueRestrictionRepository.InsertWithOutLastID(x_oDB,x_oMobileOrderIssueRestriction);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sName,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sType,global::System.Nullable<bool> x_bActive)
        {
            return MobileOrderIssueRestrictionRepository.InsertReturnLastID_SP(x_oDB,x_sName,x_dCdate,x_sCid,x_sType,x_bActive);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderIssueRestriction x_oMobileOrderIssueRestriction)
        {
            return MobileOrderIssueRestrictionRepository.InsertReturnLastID_SP(x_oDB,x_oMobileOrderIssueRestriction);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return MobileOrderIssueRestrictionRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderIssueRestrictionRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iRestriction_id)
        {
            return MobileOrderIssueRestrictionRepository.Delete(x_oDB, x_iRestriction_id);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(MobileOrderIssueRestriction x_oMobileOrderIssueRestrictionRow){
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


