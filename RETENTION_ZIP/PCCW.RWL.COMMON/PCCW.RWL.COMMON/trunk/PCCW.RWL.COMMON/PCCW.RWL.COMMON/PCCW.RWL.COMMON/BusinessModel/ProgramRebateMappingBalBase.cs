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
///-- Create date: <Create Date 2011-09-22>
///-- Description:	<Description,Table :[ProgramRebateMapping],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [ProgramRebateMapping] Business layer
    /// </summary>
    
    public abstract class ProgramRebateMappingBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public ProgramRebateMappingBalBase(){
        }
        ~ProgramRebateMappingBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(ProgramRebateMapping x_oProgramRebateMapping)
        {
            return GetDataSet(x_oProgramRebateMapping,null,ProgramRebateMappingInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(ProgramRebateMapping x_oProgramRebateMapping,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oProgramRebateMapping,x_oMergeDSet,ProgramRebateMappingInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(ProgramRebateMapping x_oProgramRebateMapping,ProgramRebateMappingInfo x_oTableSet)
        {
            return GetDataSet(x_oProgramRebateMapping,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(ProgramRebateMapping x_oProgramRebateMapping,global::System.Data.DataSet x_oMergeDSet,ProgramRebateMappingInfo x_oTableSet)
        {
            return GetDataSet(x_oProgramRebateMapping,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(ProgramRebateMapping x_oProgramRebateMapping,global::System.Data.DataSet x_oMergeDSet,ProgramRebateMappingInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = ProgramRebateMappingInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(ProgramRebateMapping.Para.TableName());
            if (x_oTableSet.Fields(ProgramRebateMapping.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProgramRebateMapping.Para.TableName()].Columns.Add(ProgramRebateMapping.Para.id); }
            if (x_oTableSet.Fields(ProgramRebateMapping.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProgramRebateMapping.Para.TableName()].Columns.Add(ProgramRebateMapping.Para.cdate); }
            if (x_oTableSet.Fields(ProgramRebateMapping.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProgramRebateMapping.Para.TableName()].Columns.Add(ProgramRebateMapping.Para.active); }
            if (x_oTableSet.Fields(ProgramRebateMapping.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProgramRebateMapping.Para.TableName()].Columns.Add(ProgramRebateMapping.Para.edate); }
            if (x_oTableSet.Fields(ProgramRebateMapping.Para.program).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProgramRebateMapping.Para.TableName()].Columns.Add(ProgramRebateMapping.Para.program); }
            if (x_oTableSet.Fields(ProgramRebateMapping.Para.issue_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProgramRebateMapping.Para.TableName()].Columns.Add(ProgramRebateMapping.Para.issue_type); }
            if (x_oTableSet.Fields(ProgramRebateMapping.Para.use_rebate_mapping).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProgramRebateMapping.Para.TableName()].Columns.Add(ProgramRebateMapping.Para.use_rebate_mapping); }
            if (x_oTableSet.Fields(ProgramRebateMapping.Para.sdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProgramRebateMapping.Para.TableName()].Columns.Add(ProgramRebateMapping.Para.sdate); }
            if (x_oProgramRebateMapping != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[ProgramRebateMapping.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(ProgramRebateMapping.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProgramRebateMapping.Para.id] = x_oProgramRebateMapping.GetId(); }
                if (x_oTableSet.Fields(ProgramRebateMapping.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProgramRebateMapping.Para.cdate] = x_oProgramRebateMapping.GetCdate(); }
                if (x_oTableSet.Fields(ProgramRebateMapping.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProgramRebateMapping.Para.active] = x_oProgramRebateMapping.GetActive(); }
                if (x_oTableSet.Fields(ProgramRebateMapping.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProgramRebateMapping.Para.edate] = x_oProgramRebateMapping.GetEdate(); }
                if (x_oTableSet.Fields(ProgramRebateMapping.Para.program).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProgramRebateMapping.Para.program] = x_oProgramRebateMapping.GetProgram(); }
                if (x_oTableSet.Fields(ProgramRebateMapping.Para.issue_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProgramRebateMapping.Para.issue_type] = x_oProgramRebateMapping.GetIssue_type(); }
                if (x_oTableSet.Fields(ProgramRebateMapping.Para.use_rebate_mapping).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProgramRebateMapping.Para.use_rebate_mapping] = x_oProgramRebateMapping.GetUse_rebate_mapping(); }
                if (x_oTableSet.Fields(ProgramRebateMapping.Para.sdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProgramRebateMapping.Para.sdate] = x_oProgramRebateMapping.GetSdate(); }
                _oDSet.Tables[ProgramRebateMapping.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(ProgramRebateMappingInfo x_oTableSet)
        {
            return ProgramRebateMappingBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return ProgramRebateMappingBal.ToEmptyDataSetProcess(ProgramRebateMappingInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(ProgramRebateMappingInfo x_oTableSet)
        {
            return ProgramRebateMappingBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(ProgramRebateMapping x_oProgramRebateMapping, ProgramRebateMappingInfo x_oTableSet)
        {
            return ProgramRebateMappingBal.GetDataSet(null, null, x_oTableSet).Tables[ProgramRebateMapping.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(ProgramRebateMapping x_oProgramRebateMapping)
        {
            return ProgramRebateMappingBal.GetDataSet(x_oProgramRebateMapping, null, ProgramRebateMappingInfoDLL.CreateInfoInstanceObject()).Tables[ProgramRebateMapping.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return Row(x_oTable, x_oDB,x_iId,ProgramRebateMappingInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId, ProgramRebateMappingInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iId, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId,ProgramRebateMappingInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = ProgramRebateMappingInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [ProgramRebateMapping].[id] AS PROGRAMREBATEMAPPING_ID,[ProgramRebateMapping].[cdate] AS PROGRAMREBATEMAPPING_CDATE,[ProgramRebateMapping].[active] AS PROGRAMREBATEMAPPING_ACTIVE,[ProgramRebateMapping].[edate] AS PROGRAMREBATEMAPPING_EDATE,[ProgramRebateMapping].[program] AS PROGRAMREBATEMAPPING_PROGRAM,[ProgramRebateMapping].[issue_type] AS PROGRAMREBATEMAPPING_ISSUE_TYPE,[ProgramRebateMapping].[use_rebate_mapping] AS PROGRAMREBATEMAPPING_USE_REBATE_MAPPING,[ProgramRebateMapping].[sdate] AS PROGRAMREBATEMAPPING_SDATE  FROM  [ProgramRebateMapping]  WHERE  [ProgramRebateMapping].[id] = \'"+x_iId.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProgramRebateMapping]","["+ Configurator.MSSQLTablePrefix + "ProgramRebateMapping]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(ProgramRebateMapping.Para.id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["PROGRAMREBATEMAPPING_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProgramRebateMapping.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProgramRebateMapping.Para.id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["PROGRAMREBATEMAPPING_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProgramRebateMapping.Para.id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(ProgramRebateMapping.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["PROGRAMREBATEMAPPING_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProgramRebateMapping.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProgramRebateMapping.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["PROGRAMREBATEMAPPING_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProgramRebateMapping.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(ProgramRebateMapping.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["PROGRAMREBATEMAPPING_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProgramRebateMapping.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProgramRebateMapping.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["PROGRAMREBATEMAPPING_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProgramRebateMapping.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(ProgramRebateMapping.Para.edate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["PROGRAMREBATEMAPPING_EDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProgramRebateMapping.Para.edate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProgramRebateMapping.Para.edate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["PROGRAMREBATEMAPPING_EDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProgramRebateMapping.Para.edate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(ProgramRebateMapping.Para.program).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["PROGRAMREBATEMAPPING_PROGRAM"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProgramRebateMapping.Para.program).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProgramRebateMapping.Para.program).AliasName].ToString()] = (string)_oData["PROGRAMREBATEMAPPING_PROGRAM"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProgramRebateMapping.Para.program).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(ProgramRebateMapping.Para.issue_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["PROGRAMREBATEMAPPING_ISSUE_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProgramRebateMapping.Para.issue_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProgramRebateMapping.Para.issue_type).AliasName].ToString()] = (string)_oData["PROGRAMREBATEMAPPING_ISSUE_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProgramRebateMapping.Para.issue_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(ProgramRebateMapping.Para.use_rebate_mapping).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["PROGRAMREBATEMAPPING_USE_REBATE_MAPPING"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProgramRebateMapping.Para.use_rebate_mapping).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProgramRebateMapping.Para.use_rebate_mapping).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["PROGRAMREBATEMAPPING_USE_REBATE_MAPPING"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProgramRebateMapping.Para.use_rebate_mapping).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(ProgramRebateMapping.Para.sdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["PROGRAMREBATEMAPPING_SDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProgramRebateMapping.Para.sdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProgramRebateMapping.Para.sdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["PROGRAMREBATEMAPPING_SDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProgramRebateMapping.Para.sdate).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,ProgramRebateMapping x_oProgramRebateMappingRow)
        {
            return SetByDataSetRowProc(x_iROW, ProgramRebateMapping.Para.TableName(), x_oDataSet,x_oProgramRebateMappingRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,ProgramRebateMapping x_oProgramRebateMappingRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oProgramRebateMappingRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,ProgramRebateMapping x_oProgramRebateMappingRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                ProgramRebateMappingInfo _oTableSet=ProgramRebateMappingInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProgramRebateMapping.Para.id).AliasName))
                    x_oProgramRebateMappingRow.id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProgramRebateMapping.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProgramRebateMapping.Para.cdate).AliasName))
                    x_oProgramRebateMappingRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProgramRebateMapping.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProgramRebateMapping.Para.active).AliasName))
                    x_oProgramRebateMappingRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProgramRebateMapping.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProgramRebateMapping.Para.edate).AliasName))
                    x_oProgramRebateMappingRow.edate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProgramRebateMapping.Para.edate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProgramRebateMapping.Para.program).AliasName))
                    x_oProgramRebateMappingRow.program = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProgramRebateMapping.Para.program).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProgramRebateMapping.Para.issue_type).AliasName))
                    x_oProgramRebateMappingRow.issue_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProgramRebateMapping.Para.issue_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProgramRebateMapping.Para.use_rebate_mapping).AliasName))
                    x_oProgramRebateMappingRow.use_rebate_mapping = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProgramRebateMapping.Para.use_rebate_mapping).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProgramRebateMapping.Para.sdate).AliasName))
                    x_oProgramRebateMappingRow.sdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProgramRebateMapping.Para.sdate).AliasName];
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
            return ProgramRebateMappingRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static ProgramRebateMappingEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return ProgramRebateMappingRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static ProgramRebateMappingEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return ProgramRebateMappingRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return ProgramRebateMappingRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return ProgramRebateMappingRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return ProgramRebateMappingRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate,global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dEdate,string x_sProgram,string x_sIssue_type,global::System.Nullable<bool> x_bUse_rebate_mapping,global::System.Nullable<DateTime> x_dSdate)
        {
            return ProgramRebateMappingRepository.Insert(x_oDB, x_dCdate,x_bActive,x_dEdate,x_sProgram,x_sIssue_type,x_bUse_rebate_mapping,x_dSdate);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,ProgramRebateMapping x_oProgramRebateMapping)
        {
            return ProgramRebateMappingRepository.InsertWithOutLastID(x_oDB,x_oProgramRebateMapping);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dEdate,string x_sProgram,string x_sIssue_type,global::System.Nullable<bool> x_bUse_rebate_mapping,global::System.Nullable<DateTime> x_dSdate)
        {
            return ProgramRebateMappingRepository.InsertReturnLastID_SP(x_oDB,x_dCdate,x_bActive,x_dEdate,x_sProgram,x_sIssue_type,x_bUse_rebate_mapping,x_dSdate);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, ProgramRebateMapping x_oProgramRebateMapping)
        {
            return ProgramRebateMappingRepository.InsertReturnLastID_SP(x_oDB,x_oProgramRebateMapping);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return ProgramRebateMappingRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return ProgramRebateMappingRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return ProgramRebateMappingRepository.Delete(x_oDB, x_iId);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(ProgramRebateMapping x_oProgramRebateMappingRow){
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


