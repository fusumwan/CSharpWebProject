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
///-- Description:	<Description,Table :[MobileOrderIssueRestrictionColumn],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderIssueRestrictionColumn] Business layer
    /// </summary>
    
    public abstract class MobileOrderIssueRestrictionColumnBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public MobileOrderIssueRestrictionColumnBalBase(){
        }
        ~MobileOrderIssueRestrictionColumnBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderIssueRestrictionColumn x_oMobileOrderIssueRestrictionColumn)
        {
            return GetDataSet(x_oMobileOrderIssueRestrictionColumn,null,MobileOrderIssueRestrictionColumnInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderIssueRestrictionColumn x_oMobileOrderIssueRestrictionColumn,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oMobileOrderIssueRestrictionColumn,x_oMergeDSet,MobileOrderIssueRestrictionColumnInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderIssueRestrictionColumn x_oMobileOrderIssueRestrictionColumn,MobileOrderIssueRestrictionColumnInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderIssueRestrictionColumn,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderIssueRestrictionColumn x_oMobileOrderIssueRestrictionColumn,global::System.Data.DataSet x_oMergeDSet,MobileOrderIssueRestrictionColumnInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderIssueRestrictionColumn,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(MobileOrderIssueRestrictionColumn x_oMobileOrderIssueRestrictionColumn,global::System.Data.DataSet x_oMergeDSet,MobileOrderIssueRestrictionColumnInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderIssueRestrictionColumnInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(MobileOrderIssueRestrictionColumn.Para.TableName());
            if (x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderIssueRestrictionColumn.Para.TableName()].Columns.Add(MobileOrderIssueRestrictionColumn.Para.active); }
            if (x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderIssueRestrictionColumn.Para.TableName()].Columns.Add(MobileOrderIssueRestrictionColumn.Para.cdate); }
            if (x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderIssueRestrictionColumn.Para.TableName()].Columns.Add(MobileOrderIssueRestrictionColumn.Para.cid); }
            if (x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.restriction_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderIssueRestrictionColumn.Para.TableName()].Columns.Add(MobileOrderIssueRestrictionColumn.Para.restriction_id); }
            if (x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.restriction_column).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderIssueRestrictionColumn.Para.TableName()].Columns.Add(MobileOrderIssueRestrictionColumn.Para.restriction_column); }
            if (x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.restriction_value).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderIssueRestrictionColumn.Para.TableName()].Columns.Add(MobileOrderIssueRestrictionColumn.Para.restriction_value); }
            if (x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.restriction_table).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderIssueRestrictionColumn.Para.TableName()].Columns.Add(MobileOrderIssueRestrictionColumn.Para.restriction_table); }
            if (x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.action_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderIssueRestrictionColumn.Para.TableName()].Columns.Add(MobileOrderIssueRestrictionColumn.Para.action_type); }
            if (x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderIssueRestrictionColumn.Para.TableName()].Columns.Add(MobileOrderIssueRestrictionColumn.Para.mid); }
            if (x_oMobileOrderIssueRestrictionColumn != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[MobileOrderIssueRestrictionColumn.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderIssueRestrictionColumn.Para.active] = x_oMobileOrderIssueRestrictionColumn.GetActive(); }
                if (x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderIssueRestrictionColumn.Para.cdate] = x_oMobileOrderIssueRestrictionColumn.GetCdate(); }
                if (x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderIssueRestrictionColumn.Para.cid] = x_oMobileOrderIssueRestrictionColumn.GetCid(); }
                if (x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.restriction_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderIssueRestrictionColumn.Para.restriction_id] = x_oMobileOrderIssueRestrictionColumn.GetRestriction_id(); }
                if (x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.restriction_column).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderIssueRestrictionColumn.Para.restriction_column] = x_oMobileOrderIssueRestrictionColumn.GetRestriction_column(); }
                if (x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.restriction_value).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderIssueRestrictionColumn.Para.restriction_value] = x_oMobileOrderIssueRestrictionColumn.GetRestriction_value(); }
                if (x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.restriction_table).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderIssueRestrictionColumn.Para.restriction_table] = x_oMobileOrderIssueRestrictionColumn.GetRestriction_table(); }
                if (x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.action_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderIssueRestrictionColumn.Para.action_type] = x_oMobileOrderIssueRestrictionColumn.GetAction_type(); }
                if (x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderIssueRestrictionColumn.Para.mid] = x_oMobileOrderIssueRestrictionColumn.GetMid(); }
                _oDSet.Tables[MobileOrderIssueRestrictionColumn.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(MobileOrderIssueRestrictionColumnInfo x_oTableSet)
        {
            return MobileOrderIssueRestrictionColumnBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return MobileOrderIssueRestrictionColumnBal.ToEmptyDataSetProcess(MobileOrderIssueRestrictionColumnInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(MobileOrderIssueRestrictionColumnInfo x_oTableSet)
        {
            return MobileOrderIssueRestrictionColumnBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(MobileOrderIssueRestrictionColumn x_oMobileOrderIssueRestrictionColumn, MobileOrderIssueRestrictionColumnInfo x_oTableSet)
        {
            return MobileOrderIssueRestrictionColumnBal.GetDataSet(null, null, x_oTableSet).Tables[MobileOrderIssueRestrictionColumn.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(MobileOrderIssueRestrictionColumn x_oMobileOrderIssueRestrictionColumn)
        {
            return MobileOrderIssueRestrictionColumnBal.GetDataSet(x_oMobileOrderIssueRestrictionColumn, null, MobileOrderIssueRestrictionColumnInfoDLL.CreateInfoInstanceObject()).Tables[MobileOrderIssueRestrictionColumn.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            return Row(x_oTable, x_oDB,x_iMid,MobileOrderIssueRestrictionColumnInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid, MobileOrderIssueRestrictionColumnInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iMid, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid,MobileOrderIssueRestrictionColumnInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderIssueRestrictionColumnInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [MobileOrderIssueRestrictionColumn].[action_type] AS MOBILEORDERISSUERESTRICTIONCOLUMN_ACTION_TYPE,[MobileOrderIssueRestrictionColumn].[cdate] AS MOBILEORDERISSUERESTRICTIONCOLUMN_CDATE,[MobileOrderIssueRestrictionColumn].[cid] AS MOBILEORDERISSUERESTRICTIONCOLUMN_CID,[MobileOrderIssueRestrictionColumn].[active] AS MOBILEORDERISSUERESTRICTIONCOLUMN_ACTIVE,[MobileOrderIssueRestrictionColumn].[restriction_id] AS MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_ID,[MobileOrderIssueRestrictionColumn].[restriction_column] AS MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_COLUMN,[MobileOrderIssueRestrictionColumn].[restriction_value] AS MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_VALUE,[MobileOrderIssueRestrictionColumn].[restriction_table] AS MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_TABLE,[MobileOrderIssueRestrictionColumn].[mid] AS MOBILEORDERISSUERESTRICTIONCOLUMN_MID  FROM  [MobileOrderIssueRestrictionColumn]  WHERE  [MobileOrderIssueRestrictionColumn].[mid] = \'"+x_iMid.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderIssueRestrictionColumn]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestrictionColumn]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.action_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_ACTION_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.action_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.action_type).AliasName].ToString()] = (string)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_ACTION_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.action_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.cid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.cid).AliasName].ToString()] = (string)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.cid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.restriction_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.restriction_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.restriction_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.restriction_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.restriction_column).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_COLUMN"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.restriction_column).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.restriction_column).AliasName].ToString()] = (string)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_COLUMN"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.restriction_column).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.restriction_value).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_VALUE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.restriction_value).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.restriction_value).AliasName].ToString()] = (string)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_VALUE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.restriction_value).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.restriction_table).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_TABLE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.restriction_table).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.restriction_table).AliasName].ToString()] = (string)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_RESTRICTION_TABLE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.restriction_table).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.mid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_MID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.mid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.mid).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERISSUERESTRICTIONCOLUMN_MID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.mid).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,MobileOrderIssueRestrictionColumn x_oMobileOrderIssueRestrictionColumnRow)
        {
            return SetByDataSetRowProc(x_iROW, MobileOrderIssueRestrictionColumn.Para.TableName(), x_oDataSet,x_oMobileOrderIssueRestrictionColumnRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderIssueRestrictionColumn x_oMobileOrderIssueRestrictionColumnRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oMobileOrderIssueRestrictionColumnRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderIssueRestrictionColumn x_oMobileOrderIssueRestrictionColumnRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                MobileOrderIssueRestrictionColumnInfo _oTableSet=MobileOrderIssueRestrictionColumnInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.active).AliasName))
                    x_oMobileOrderIssueRestrictionColumnRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.cdate).AliasName))
                    x_oMobileOrderIssueRestrictionColumnRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.cid).AliasName))
                    x_oMobileOrderIssueRestrictionColumnRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.restriction_id).AliasName))
                    x_oMobileOrderIssueRestrictionColumnRow.restriction_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.restriction_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.restriction_column).AliasName))
                    x_oMobileOrderIssueRestrictionColumnRow.restriction_column = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.restriction_column).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.restriction_value).AliasName))
                    x_oMobileOrderIssueRestrictionColumnRow.restriction_value = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.restriction_value).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.restriction_table).AliasName))
                    x_oMobileOrderIssueRestrictionColumnRow.restriction_table = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.restriction_table).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.action_type).AliasName))
                    x_oMobileOrderIssueRestrictionColumnRow.action_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.action_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.mid).AliasName))
                    x_oMobileOrderIssueRestrictionColumnRow.mid = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderIssueRestrictionColumn.Para.mid).AliasName];
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
            return MobileOrderIssueRestrictionColumnRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static MobileOrderIssueRestrictionColumnEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return MobileOrderIssueRestrictionColumnRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static MobileOrderIssueRestrictionColumnEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return MobileOrderIssueRestrictionColumnRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderIssueRestrictionColumnRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderIssueRestrictionColumnRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderIssueRestrictionColumnRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dCdate,string x_sCid,global::System.Nullable<int> x_iRestriction_id,string x_sRestriction_column,string x_sRestriction_value,string x_sRestriction_table,string x_sAction_type)
        {
            return MobileOrderIssueRestrictionColumnRepository.Insert(x_oDB, x_bActive,x_dCdate,x_sCid,x_iRestriction_id,x_sRestriction_column,x_sRestriction_value,x_sRestriction_table,x_sAction_type);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderIssueRestrictionColumn x_oMobileOrderIssueRestrictionColumn)
        {
            return MobileOrderIssueRestrictionColumnRepository.InsertWithOutLastID(x_oDB,x_oMobileOrderIssueRestrictionColumn);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dCdate,string x_sCid,global::System.Nullable<int> x_iRestriction_id,string x_sRestriction_column,string x_sRestriction_value,string x_sRestriction_table,string x_sAction_type)
        {
            return MobileOrderIssueRestrictionColumnRepository.InsertReturnLastID_SP(x_oDB,x_bActive,x_dCdate,x_sCid,x_iRestriction_id,x_sRestriction_column,x_sRestriction_value,x_sRestriction_table,x_sAction_type);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderIssueRestrictionColumn x_oMobileOrderIssueRestrictionColumn)
        {
            return MobileOrderIssueRestrictionColumnRepository.InsertReturnLastID_SP(x_oDB,x_oMobileOrderIssueRestrictionColumn);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return MobileOrderIssueRestrictionColumnRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderIssueRestrictionColumnRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            return MobileOrderIssueRestrictionColumnRepository.Delete(x_oDB, x_iMid);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(MobileOrderIssueRestrictionColumn x_oMobileOrderIssueRestrictionColumnRow){
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


