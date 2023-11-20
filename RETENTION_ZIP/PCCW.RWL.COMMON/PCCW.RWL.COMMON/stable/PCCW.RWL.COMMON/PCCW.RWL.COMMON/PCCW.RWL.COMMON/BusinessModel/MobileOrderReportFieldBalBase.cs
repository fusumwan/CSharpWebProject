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
///-- Create date: <Create Date 2010-10-29>
///-- Description:	<Description,Table :[MobileOrderReportField],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderReportField] Business layer
    /// </summary>
    
    public abstract class MobileOrderReportFieldBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public MobileOrderReportFieldBalBase(){
        }
        ~MobileOrderReportFieldBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderReportField x_oMobileOrderReportField)
        {
            return GetDataSet(x_oMobileOrderReportField,null,MobileOrderReportFieldInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderReportField x_oMobileOrderReportField,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oMobileOrderReportField,x_oMergeDSet,MobileOrderReportFieldInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderReportField x_oMobileOrderReportField,MobileOrderReportFieldInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderReportField,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderReportField x_oMobileOrderReportField,global::System.Data.DataSet x_oMergeDSet,MobileOrderReportFieldInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderReportField,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(MobileOrderReportField x_oMobileOrderReportField,global::System.Data.DataSet x_oMergeDSet,MobileOrderReportFieldInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderReportFieldInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(MobileOrderReportField.Para.TableName());
            if (x_oTableSet.Fields(MobileOrderReportField.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportField.Para.TableName()].Columns.Add(MobileOrderReportField.Para.id); }
            if (x_oTableSet.Fields(MobileOrderReportField.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportField.Para.TableName()].Columns.Add(MobileOrderReportField.Para.cdate); }
            if (x_oTableSet.Fields(MobileOrderReportField.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportField.Para.TableName()].Columns.Add(MobileOrderReportField.Para.cid); }
            if (x_oTableSet.Fields(MobileOrderReportField.Para.field_title).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportField.Para.TableName()].Columns.Add(MobileOrderReportField.Para.field_title); }
            if (x_oTableSet.Fields(MobileOrderReportField.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportField.Para.TableName()].Columns.Add(MobileOrderReportField.Para.active); }
            if (x_oTableSet.Fields(MobileOrderReportField.Para.report_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportField.Para.TableName()].Columns.Add(MobileOrderReportField.Para.report_id); }
            if (x_oTableSet.Fields(MobileOrderReportField.Para.field_content_order).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportField.Para.TableName()].Columns.Add(MobileOrderReportField.Para.field_content_order); }
            if (x_oTableSet.Fields(MobileOrderReportField.Para.field_content).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportField.Para.TableName()].Columns.Add(MobileOrderReportField.Para.field_content); }
            if (x_oTableSet.Fields(MobileOrderReportField.Para.field_content_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportField.Para.TableName()].Columns.Add(MobileOrderReportField.Para.field_content_name); }
            if (x_oTableSet.Fields(MobileOrderReportField.Para.field_order).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportField.Para.TableName()].Columns.Add(MobileOrderReportField.Para.field_order); }
            if (x_oMobileOrderReportField != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[MobileOrderReportField.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(MobileOrderReportField.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportField.Para.id] = x_oMobileOrderReportField.GetId(); }
                if (x_oTableSet.Fields(MobileOrderReportField.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportField.Para.cdate] = x_oMobileOrderReportField.GetCdate(); }
                if (x_oTableSet.Fields(MobileOrderReportField.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportField.Para.cid] = x_oMobileOrderReportField.GetCid(); }
                if (x_oTableSet.Fields(MobileOrderReportField.Para.field_title).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportField.Para.field_title] = x_oMobileOrderReportField.GetField_title(); }
                if (x_oTableSet.Fields(MobileOrderReportField.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportField.Para.active] = x_oMobileOrderReportField.GetActive(); }
                if (x_oTableSet.Fields(MobileOrderReportField.Para.report_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportField.Para.report_id] = x_oMobileOrderReportField.GetReport_id(); }
                if (x_oTableSet.Fields(MobileOrderReportField.Para.field_content_order).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportField.Para.field_content_order] = x_oMobileOrderReportField.GetField_content_order(); }
                if (x_oTableSet.Fields(MobileOrderReportField.Para.field_content).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportField.Para.field_content] = x_oMobileOrderReportField.GetField_content(); }
                if (x_oTableSet.Fields(MobileOrderReportField.Para.field_content_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportField.Para.field_content_name] = x_oMobileOrderReportField.GetField_content_name(); }
                if (x_oTableSet.Fields(MobileOrderReportField.Para.field_order).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportField.Para.field_order] = x_oMobileOrderReportField.GetField_order(); }
                _oDSet.Tables[MobileOrderReportField.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(MobileOrderReportFieldInfo x_oTableSet)
        {
            return MobileOrderReportFieldBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return MobileOrderReportFieldBal.ToEmptyDataSetProcess(MobileOrderReportFieldInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(MobileOrderReportFieldInfo x_oTableSet)
        {
            return MobileOrderReportFieldBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(MobileOrderReportField x_oMobileOrderReportField, MobileOrderReportFieldInfo x_oTableSet)
        {
            return MobileOrderReportFieldBal.GetDataSet(null, null, x_oTableSet).Tables[MobileOrderReportField.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(MobileOrderReportField x_oMobileOrderReportField)
        {
            return MobileOrderReportFieldBal.GetDataSet(x_oMobileOrderReportField, null, MobileOrderReportFieldInfoDLL.CreateInfoInstanceObject()).Tables[MobileOrderReportField.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return Row(x_oTable, x_oDB,x_iId,MobileOrderReportFieldInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId, MobileOrderReportFieldInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iId, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId,MobileOrderReportFieldInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderReportFieldInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [MobileOrderReportField].[id] AS MOBILEORDERREPORTFIELD_ID,[MobileOrderReportField].[cdate] AS MOBILEORDERREPORTFIELD_CDATE,[MobileOrderReportField].[cid] AS MOBILEORDERREPORTFIELD_CID,[MobileOrderReportField].[field_title] AS MOBILEORDERREPORTFIELD_FIELD_TITLE,[MobileOrderReportField].[active] AS MOBILEORDERREPORTFIELD_ACTIVE,[MobileOrderReportField].[report_id] AS MOBILEORDERREPORTFIELD_REPORT_ID,[MobileOrderReportField].[field_content_order] AS MOBILEORDERREPORTFIELD_FIELD_CONTENT_ORDER,[MobileOrderReportField].[field_content] AS MOBILEORDERREPORTFIELD_FIELD_CONTENT,[MobileOrderReportField].[field_content_name] AS MOBILEORDERREPORTFIELD_FIELD_CONTENT_NAME,[MobileOrderReportField].[field_order] AS MOBILEORDERREPORTFIELD_FIELD_ORDER  FROM  [MobileOrderReportField]  WHERE  [MobileOrderReportField].[id] = \'"+x_iId.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportField]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportField]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(MobileOrderReportField.Para.id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportField.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportField.Para.id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTFIELD_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportField.Para.id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportField.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportField.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportField.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTFIELD_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportField.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportField.Para.cid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportField.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportField.Para.cid).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTFIELD_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportField.Para.cid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportField.Para.field_title).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_FIELD_TITLE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportField.Para.field_title).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportField.Para.field_title).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTFIELD_FIELD_TITLE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportField.Para.field_title).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportField.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportField.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportField.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTFIELD_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportField.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportField.Para.report_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_REPORT_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportField.Para.report_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportField.Para.report_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTFIELD_REPORT_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportField.Para.report_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportField.Para.field_content_order).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_FIELD_CONTENT_ORDER"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportField.Para.field_content_order).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportField.Para.field_content_order).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTFIELD_FIELD_CONTENT_ORDER"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportField.Para.field_content_order).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportField.Para.field_content).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_FIELD_CONTENT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportField.Para.field_content).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportField.Para.field_content).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTFIELD_FIELD_CONTENT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportField.Para.field_content).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportField.Para.field_content_name).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_FIELD_CONTENT_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportField.Para.field_content_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportField.Para.field_content_name).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTFIELD_FIELD_CONTENT_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportField.Para.field_content_name).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportField.Para.field_order).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTFIELD_FIELD_ORDER"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportField.Para.field_order).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportField.Para.field_order).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTFIELD_FIELD_ORDER"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportField.Para.field_order).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,MobileOrderReportField x_oMobileOrderReportFieldRow)
        {
            return SetByDataSetRowProc(x_iROW, MobileOrderReportField.Para.TableName(), x_oDataSet,x_oMobileOrderReportFieldRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderReportField x_oMobileOrderReportFieldRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oMobileOrderReportFieldRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderReportField x_oMobileOrderReportFieldRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                MobileOrderReportFieldInfo _oTableSet=MobileOrderReportFieldInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportField.Para.id).AliasName))
                    x_oMobileOrderReportFieldRow.id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportField.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportField.Para.cdate).AliasName))
                    x_oMobileOrderReportFieldRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportField.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportField.Para.cid).AliasName))
                    x_oMobileOrderReportFieldRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportField.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportField.Para.field_title).AliasName))
                    x_oMobileOrderReportFieldRow.field_title = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportField.Para.field_title).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportField.Para.active).AliasName))
                    x_oMobileOrderReportFieldRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportField.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportField.Para.report_id).AliasName))
                    x_oMobileOrderReportFieldRow.report_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportField.Para.report_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportField.Para.field_content_order).AliasName))
                    x_oMobileOrderReportFieldRow.field_content_order = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportField.Para.field_content_order).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportField.Para.field_content).AliasName))
                    x_oMobileOrderReportFieldRow.field_content = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportField.Para.field_content).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportField.Para.field_content_name).AliasName))
                    x_oMobileOrderReportFieldRow.field_content_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportField.Para.field_content_name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportField.Para.field_order).AliasName))
                    x_oMobileOrderReportFieldRow.field_order = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportField.Para.field_order).AliasName];
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
            return MobileOrderReportFieldRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static MobileOrderReportFieldEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return MobileOrderReportFieldRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static MobileOrderReportFieldEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return MobileOrderReportFieldRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderReportFieldRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderReportFieldRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderReportFieldRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sField_title,global::System.Nullable<bool> x_bActive,global::System.Nullable<int> x_iReport_id,global::System.Nullable<int> x_iField_content_order,string x_sField_content,string x_sField_content_name,global::System.Nullable<int> x_iField_order)
        {
            return MobileOrderReportFieldRepository.Insert(x_oDB, x_dCdate,x_sCid,x_sField_title,x_bActive,x_iReport_id,x_iField_content_order,x_sField_content,x_sField_content_name,x_iField_order);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderReportField x_oMobileOrderReportField)
        {
            return MobileOrderReportFieldRepository.InsertWithOutLastID(x_oDB,x_oMobileOrderReportField);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sField_title,global::System.Nullable<bool> x_bActive,global::System.Nullable<int> x_iReport_id,global::System.Nullable<int> x_iField_content_order,string x_sField_content,string x_sField_content_name,global::System.Nullable<int> x_iField_order)
        {
            return MobileOrderReportFieldRepository.InsertReturnLastID_SP(x_oDB,x_dCdate,x_sCid,x_sField_title,x_bActive,x_iReport_id,x_iField_content_order,x_sField_content,x_sField_content_name,x_iField_order);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderReportField x_oMobileOrderReportField)
        {
            return MobileOrderReportFieldRepository.InsertReturnLastID_SP(x_oDB,x_oMobileOrderReportField);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return MobileOrderReportFieldRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderReportFieldRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return MobileOrderReportFieldRepository.Delete(x_oDB, x_iId);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(MobileOrderReportField x_oMobileOrderReportFieldRow){
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


