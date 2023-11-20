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
///-- Create date: <Create Date 2011-07-14>
///-- Description:	<Description,Table :[BundleMapping],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [BundleMapping] Business layer
    /// </summary>
    
    public abstract class BundleMappingBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public BundleMappingBalBase(){
        }
        ~BundleMappingBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(BundleMapping x_oBundleMapping)
        {
            return GetDataSet(x_oBundleMapping,null,BundleMappingInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(BundleMapping x_oBundleMapping,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oBundleMapping,x_oMergeDSet,BundleMappingInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(BundleMapping x_oBundleMapping,BundleMappingInfo x_oTableSet)
        {
            return GetDataSet(x_oBundleMapping,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(BundleMapping x_oBundleMapping,global::System.Data.DataSet x_oMergeDSet,BundleMappingInfo x_oTableSet)
        {
            return GetDataSet(x_oBundleMapping,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(BundleMapping x_oBundleMapping,global::System.Data.DataSet x_oMergeDSet,BundleMappingInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = BundleMappingInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(BundleMapping.Para.TableName());
            if (x_oTableSet.Fields(BundleMapping.Para.program).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BundleMapping.Para.TableName()].Columns.Add(BundleMapping.Para.program); }
            if (x_oTableSet.Fields(BundleMapping.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BundleMapping.Para.TableName()].Columns.Add(BundleMapping.Para.cdate); }
            if (x_oTableSet.Fields(BundleMapping.Para.bundle_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BundleMapping.Para.TableName()].Columns.Add(BundleMapping.Para.bundle_name); }
            if (x_oTableSet.Fields(BundleMapping.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BundleMapping.Para.TableName()].Columns.Add(BundleMapping.Para.cid); }
            if (x_oTableSet.Fields(BundleMapping.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BundleMapping.Para.TableName()].Columns.Add(BundleMapping.Para.did); }
            if (x_oTableSet.Fields(BundleMapping.Para.retention_rebate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BundleMapping.Para.TableName()].Columns.Add(BundleMapping.Para.retention_rebate); }
            if (x_oTableSet.Fields(BundleMapping.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BundleMapping.Para.TableName()].Columns.Add(BundleMapping.Para.edate); }
            if (x_oTableSet.Fields(BundleMapping.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BundleMapping.Para.TableName()].Columns.Add(BundleMapping.Para.active); }
            if (x_oTableSet.Fields(BundleMapping.Para.normal_rebate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BundleMapping.Para.TableName()].Columns.Add(BundleMapping.Para.normal_rebate); }
            if (x_oTableSet.Fields(BundleMapping.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BundleMapping.Para.TableName()].Columns.Add(BundleMapping.Para.ddate); }
            if (x_oTableSet.Fields(BundleMapping.Para.normal_rebate_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BundleMapping.Para.TableName()].Columns.Add(BundleMapping.Para.normal_rebate_type); }
            if (x_oTableSet.Fields(BundleMapping.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BundleMapping.Para.TableName()].Columns.Add(BundleMapping.Para.id); }
            if (x_oTableSet.Fields(BundleMapping.Para.sdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BundleMapping.Para.TableName()].Columns.Add(BundleMapping.Para.sdate); }
            if (x_oTableSet.Fields(BundleMapping.Para.rate_plan).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BundleMapping.Para.TableName()].Columns.Add(BundleMapping.Para.rate_plan); }
            if (x_oTableSet.Fields(BundleMapping.Para.vas_field).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BundleMapping.Para.TableName()].Columns.Add(BundleMapping.Para.vas_field); }
            if (x_oTableSet.Fields(BundleMapping.Para.hs_model).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BundleMapping.Para.TableName()].Columns.Add(BundleMapping.Para.hs_model); }
            if (x_oTableSet.Fields(BundleMapping.Para.issue_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BundleMapping.Para.TableName()].Columns.Add(BundleMapping.Para.issue_type); }
            if (x_oBundleMapping != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[BundleMapping.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(BundleMapping.Para.program).IsView || x_oTableSet.GetViewAll()) { _oDRow[BundleMapping.Para.program] = x_oBundleMapping.GetProgram(); }
                if (x_oTableSet.Fields(BundleMapping.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[BundleMapping.Para.cdate] = x_oBundleMapping.GetCdate(); }
                if (x_oTableSet.Fields(BundleMapping.Para.bundle_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[BundleMapping.Para.bundle_name] = x_oBundleMapping.GetBundle_name(); }
                if (x_oTableSet.Fields(BundleMapping.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[BundleMapping.Para.cid] = x_oBundleMapping.GetCid(); }
                if (x_oTableSet.Fields(BundleMapping.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[BundleMapping.Para.did] = x_oBundleMapping.GetDid(); }
                if (x_oTableSet.Fields(BundleMapping.Para.retention_rebate).IsView || x_oTableSet.GetViewAll()) { _oDRow[BundleMapping.Para.retention_rebate] = x_oBundleMapping.GetRetention_rebate(); }
                if (x_oTableSet.Fields(BundleMapping.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDRow[BundleMapping.Para.edate] = x_oBundleMapping.GetEdate(); }
                if (x_oTableSet.Fields(BundleMapping.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[BundleMapping.Para.active] = x_oBundleMapping.GetActive(); }
                if (x_oTableSet.Fields(BundleMapping.Para.normal_rebate).IsView || x_oTableSet.GetViewAll()) { _oDRow[BundleMapping.Para.normal_rebate] = x_oBundleMapping.GetNormal_rebate(); }
                if (x_oTableSet.Fields(BundleMapping.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[BundleMapping.Para.ddate] = x_oBundleMapping.GetDdate(); }
                if (x_oTableSet.Fields(BundleMapping.Para.normal_rebate_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[BundleMapping.Para.normal_rebate_type] = x_oBundleMapping.GetNormal_rebate_type(); }
                if (x_oTableSet.Fields(BundleMapping.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[BundleMapping.Para.id] = x_oBundleMapping.GetId(); }
                if (x_oTableSet.Fields(BundleMapping.Para.sdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[BundleMapping.Para.sdate] = x_oBundleMapping.GetSdate(); }
                if (x_oTableSet.Fields(BundleMapping.Para.rate_plan).IsView || x_oTableSet.GetViewAll()) { _oDRow[BundleMapping.Para.rate_plan] = x_oBundleMapping.GetRate_plan(); }
                if (x_oTableSet.Fields(BundleMapping.Para.vas_field).IsView || x_oTableSet.GetViewAll()) { _oDRow[BundleMapping.Para.vas_field] = x_oBundleMapping.GetVas_field(); }
                if (x_oTableSet.Fields(BundleMapping.Para.hs_model).IsView || x_oTableSet.GetViewAll()) { _oDRow[BundleMapping.Para.hs_model] = x_oBundleMapping.GetHs_model(); }
                if (x_oTableSet.Fields(BundleMapping.Para.issue_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[BundleMapping.Para.issue_type] = x_oBundleMapping.GetIssue_type(); }
                _oDSet.Tables[BundleMapping.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(BundleMappingInfo x_oTableSet)
        {
            return BundleMappingBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return BundleMappingBal.ToEmptyDataSetProcess(BundleMappingInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(BundleMappingInfo x_oTableSet)
        {
            return BundleMappingBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(BundleMapping x_oBundleMapping, BundleMappingInfo x_oTableSet)
        {
            return BundleMappingBal.GetDataSet(null, null, x_oTableSet).Tables[BundleMapping.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(BundleMapping x_oBundleMapping)
        {
            return BundleMappingBal.GetDataSet(x_oBundleMapping, null, BundleMappingInfoDLL.CreateInfoInstanceObject()).Tables[BundleMapping.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return Row(x_oTable, x_oDB,x_iId,BundleMappingInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId, BundleMappingInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iId, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId,BundleMappingInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = BundleMappingInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [BundleMapping].[program] AS BUNDLEMAPPING_PROGRAM,[BundleMapping].[cdate] AS BUNDLEMAPPING_CDATE,[BundleMapping].[bundle_name] AS BUNDLEMAPPING_BUNDLE_NAME,[BundleMapping].[cid] AS BUNDLEMAPPING_CID,[BundleMapping].[did] AS BUNDLEMAPPING_DID,[BundleMapping].[retention_rebate] AS BUNDLEMAPPING_RETENTION_REBATE,[BundleMapping].[edate] AS BUNDLEMAPPING_EDATE,[BundleMapping].[active] AS BUNDLEMAPPING_ACTIVE,[BundleMapping].[issue_type] AS BUNDLEMAPPING_ISSUE_TYPE,[BundleMapping].[ddate] AS BUNDLEMAPPING_DDATE,[BundleMapping].[normal_rebate_type] AS BUNDLEMAPPING_NORMAL_REBATE_TYPE,[BundleMapping].[id] AS BUNDLEMAPPING_ID,[BundleMapping].[rate_plan] AS BUNDLEMAPPING_RATE_PLAN,[BundleMapping].[normal_rebate] AS BUNDLEMAPPING_NORMAL_REBATE,[BundleMapping].[hs_model] AS BUNDLEMAPPING_HS_MODEL,[BundleMapping].[vas_field] AS BUNDLEMAPPING_VAS_FIELD,[BundleMapping].[sdate] AS BUNDLEMAPPING_SDATE  FROM  [BundleMapping]  WHERE  [BundleMapping].[id] = \'"+x_iId.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BundleMapping]","["+ Configurator.MSSQLTablePrefix + "BundleMapping]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(BundleMapping.Para.program).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_PROGRAM"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BundleMapping.Para.program).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BundleMapping.Para.program).AliasName].ToString()] = (string)_oData["BUNDLEMAPPING_PROGRAM"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BundleMapping.Para.program).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BundleMapping.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BundleMapping.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BundleMapping.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["BUNDLEMAPPING_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BundleMapping.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BundleMapping.Para.bundle_name).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_BUNDLE_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BundleMapping.Para.bundle_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BundleMapping.Para.bundle_name).AliasName].ToString()] = (string)_oData["BUNDLEMAPPING_BUNDLE_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BundleMapping.Para.bundle_name).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BundleMapping.Para.cid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BundleMapping.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BundleMapping.Para.cid).AliasName].ToString()] = (string)_oData["BUNDLEMAPPING_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BundleMapping.Para.cid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BundleMapping.Para.did).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BundleMapping.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BundleMapping.Para.did).AliasName].ToString()] = (string)_oData["BUNDLEMAPPING_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BundleMapping.Para.did).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BundleMapping.Para.retention_rebate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_RETENTION_REBATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BundleMapping.Para.retention_rebate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BundleMapping.Para.retention_rebate).AliasName].ToString()] = (global::System.Nullable<int>)_oData["BUNDLEMAPPING_RETENTION_REBATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BundleMapping.Para.retention_rebate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BundleMapping.Para.edate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_EDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BundleMapping.Para.edate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BundleMapping.Para.edate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["BUNDLEMAPPING_EDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BundleMapping.Para.edate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BundleMapping.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BundleMapping.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BundleMapping.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["BUNDLEMAPPING_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BundleMapping.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BundleMapping.Para.issue_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_ISSUE_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BundleMapping.Para.issue_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BundleMapping.Para.issue_type).AliasName].ToString()] = (string)_oData["BUNDLEMAPPING_ISSUE_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BundleMapping.Para.issue_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BundleMapping.Para.ddate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BundleMapping.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BundleMapping.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["BUNDLEMAPPING_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BundleMapping.Para.ddate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BundleMapping.Para.normal_rebate_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_NORMAL_REBATE_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BundleMapping.Para.normal_rebate_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BundleMapping.Para.normal_rebate_type).AliasName].ToString()] = (string)_oData["BUNDLEMAPPING_NORMAL_REBATE_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BundleMapping.Para.normal_rebate_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BundleMapping.Para.id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BundleMapping.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BundleMapping.Para.id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["BUNDLEMAPPING_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BundleMapping.Para.id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BundleMapping.Para.rate_plan).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_RATE_PLAN"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BundleMapping.Para.rate_plan).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BundleMapping.Para.rate_plan).AliasName].ToString()] = (string)_oData["BUNDLEMAPPING_RATE_PLAN"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BundleMapping.Para.rate_plan).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BundleMapping.Para.normal_rebate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_NORMAL_REBATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BundleMapping.Para.normal_rebate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BundleMapping.Para.normal_rebate).AliasName].ToString()] = (global::System.Nullable<int>)_oData["BUNDLEMAPPING_NORMAL_REBATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BundleMapping.Para.normal_rebate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BundleMapping.Para.hs_model).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_HS_MODEL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BundleMapping.Para.hs_model).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BundleMapping.Para.hs_model).AliasName].ToString()] = (string)_oData["BUNDLEMAPPING_HS_MODEL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BundleMapping.Para.hs_model).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BundleMapping.Para.vas_field).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_VAS_FIELD"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BundleMapping.Para.vas_field).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BundleMapping.Para.vas_field).AliasName].ToString()] = (string)_oData["BUNDLEMAPPING_VAS_FIELD"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BundleMapping.Para.vas_field).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BundleMapping.Para.sdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUNDLEMAPPING_SDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BundleMapping.Para.sdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BundleMapping.Para.sdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["BUNDLEMAPPING_SDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BundleMapping.Para.sdate).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,BundleMapping x_oBundleMappingRow)
        {
            return SetByDataSetRowProc(x_iROW, BundleMapping.Para.TableName(), x_oDataSet,x_oBundleMappingRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,BundleMapping x_oBundleMappingRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oBundleMappingRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,BundleMapping x_oBundleMappingRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                BundleMappingInfo _oTableSet=BundleMappingInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BundleMapping.Para.program).AliasName))
                    x_oBundleMappingRow.program = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BundleMapping.Para.program).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BundleMapping.Para.cdate).AliasName))
                    x_oBundleMappingRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BundleMapping.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BundleMapping.Para.bundle_name).AliasName))
                    x_oBundleMappingRow.bundle_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BundleMapping.Para.bundle_name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BundleMapping.Para.cid).AliasName))
                    x_oBundleMappingRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BundleMapping.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BundleMapping.Para.did).AliasName))
                    x_oBundleMappingRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BundleMapping.Para.did).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BundleMapping.Para.retention_rebate).AliasName))
                    x_oBundleMappingRow.retention_rebate = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BundleMapping.Para.retention_rebate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BundleMapping.Para.edate).AliasName))
                    x_oBundleMappingRow.edate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BundleMapping.Para.edate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BundleMapping.Para.active).AliasName))
                    x_oBundleMappingRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BundleMapping.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BundleMapping.Para.normal_rebate).AliasName))
                    x_oBundleMappingRow.normal_rebate = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BundleMapping.Para.normal_rebate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BundleMapping.Para.ddate).AliasName))
                    x_oBundleMappingRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BundleMapping.Para.ddate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BundleMapping.Para.normal_rebate_type).AliasName))
                    x_oBundleMappingRow.normal_rebate_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BundleMapping.Para.normal_rebate_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BundleMapping.Para.id).AliasName))
                    x_oBundleMappingRow.id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BundleMapping.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BundleMapping.Para.sdate).AliasName))
                    x_oBundleMappingRow.sdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BundleMapping.Para.sdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BundleMapping.Para.rate_plan).AliasName))
                    x_oBundleMappingRow.rate_plan = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BundleMapping.Para.rate_plan).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BundleMapping.Para.vas_field).AliasName))
                    x_oBundleMappingRow.vas_field = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BundleMapping.Para.vas_field).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BundleMapping.Para.hs_model).AliasName))
                    x_oBundleMappingRow.hs_model = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BundleMapping.Para.hs_model).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BundleMapping.Para.issue_type).AliasName))
                    x_oBundleMappingRow.issue_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BundleMapping.Para.issue_type).AliasName];
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
            return BundleMappingRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static BundleMappingEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return BundleMappingRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static BundleMappingEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return BundleMappingRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return BundleMappingRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return BundleMappingRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return BundleMappingRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sProgram,global::System.Nullable<DateTime> x_dCdate,string x_sBundle_name,string x_sCid,string x_sDid,global::System.Nullable<int> x_iRetention_rebate,global::System.Nullable<DateTime> x_dEdate,global::System.Nullable<bool> x_bActive,global::System.Nullable<int> x_iNormal_rebate,global::System.Nullable<DateTime> x_dDdate,string x_sNormal_rebate_type,global::System.Nullable<DateTime> x_dSdate,string x_sRate_plan,string x_sVas_field,string x_sHs_model,string x_sIssue_type)
        {
            return BundleMappingRepository.Insert(x_oDB, x_sProgram,x_dCdate,x_sBundle_name,x_sCid,x_sDid,x_iRetention_rebate,x_dEdate,x_bActive,x_iNormal_rebate,x_dDdate,x_sNormal_rebate_type,x_dSdate,x_sRate_plan,x_sVas_field,x_sHs_model,x_sIssue_type);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,BundleMapping x_oBundleMapping)
        {
            return BundleMappingRepository.InsertWithOutLastID(x_oDB,x_oBundleMapping);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sProgram,global::System.Nullable<DateTime> x_dCdate,string x_sBundle_name,string x_sCid,string x_sDid,global::System.Nullable<int> x_iRetention_rebate,global::System.Nullable<DateTime> x_dEdate,global::System.Nullable<bool> x_bActive,global::System.Nullable<int> x_iNormal_rebate,global::System.Nullable<DateTime> x_dDdate,string x_sNormal_rebate_type,global::System.Nullable<DateTime> x_dSdate,string x_sRate_plan,string x_sVas_field,string x_sHs_model,string x_sIssue_type)
        {
            return BundleMappingRepository.InsertReturnLastID_SP(x_oDB,x_sProgram,x_dCdate,x_sBundle_name,x_sCid,x_sDid,x_iRetention_rebate,x_dEdate,x_bActive,x_iNormal_rebate,x_dDdate,x_sNormal_rebate_type,x_dSdate,x_sRate_plan,x_sVas_field,x_sHs_model,x_sIssue_type);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, BundleMapping x_oBundleMapping)
        {
            return BundleMappingRepository.InsertReturnLastID_SP(x_oDB,x_oBundleMapping);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return BundleMappingRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return BundleMappingRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return BundleMappingRepository.Delete(x_oDB, x_iId);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(BundleMapping x_oBundleMappingRow){
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


