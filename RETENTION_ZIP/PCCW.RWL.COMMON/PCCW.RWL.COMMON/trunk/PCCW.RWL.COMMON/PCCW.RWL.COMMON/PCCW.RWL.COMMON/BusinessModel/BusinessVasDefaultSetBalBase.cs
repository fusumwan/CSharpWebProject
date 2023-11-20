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
///-- Create date: <Create Date 2011-07-15>
///-- Description:	<Description,Table :[BusinessVasDefaultSet],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [BusinessVasDefaultSet] Business layer
    /// </summary>
    
    public abstract class BusinessVasDefaultSetBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public BusinessVasDefaultSetBalBase(){
        }
        ~BusinessVasDefaultSetBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(BusinessVasDefaultSet x_oBusinessVasDefaultSet)
        {
            return GetDataSet(x_oBusinessVasDefaultSet,null,BusinessVasDefaultSetInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(BusinessVasDefaultSet x_oBusinessVasDefaultSet,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oBusinessVasDefaultSet,x_oMergeDSet,BusinessVasDefaultSetInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(BusinessVasDefaultSet x_oBusinessVasDefaultSet,BusinessVasDefaultSetInfo x_oTableSet)
        {
            return GetDataSet(x_oBusinessVasDefaultSet,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(BusinessVasDefaultSet x_oBusinessVasDefaultSet,global::System.Data.DataSet x_oMergeDSet,BusinessVasDefaultSetInfo x_oTableSet)
        {
            return GetDataSet(x_oBusinessVasDefaultSet,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(BusinessVasDefaultSet x_oBusinessVasDefaultSet,global::System.Data.DataSet x_oMergeDSet,BusinessVasDefaultSetInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = BusinessVasDefaultSetInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(BusinessVasDefaultSet.Para.TableName());
            if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.display2).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVasDefaultSet.Para.TableName()].Columns.Add(BusinessVasDefaultSet.Para.display2); }
            if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVasDefaultSet.Para.TableName()].Columns.Add(BusinessVasDefaultSet.Para.mid); }
            if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVasDefaultSet.Para.TableName()].Columns.Add(BusinessVasDefaultSet.Para.cdate); }
            if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.bundle_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVasDefaultSet.Para.TableName()].Columns.Add(BusinessVasDefaultSet.Para.bundle_name); }
            if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.value2).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVasDefaultSet.Para.TableName()].Columns.Add(BusinessVasDefaultSet.Para.value2); }
            if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVasDefaultSet.Para.TableName()].Columns.Add(BusinessVasDefaultSet.Para.cid); }
            if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.value1).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVasDefaultSet.Para.TableName()].Columns.Add(BusinessVasDefaultSet.Para.value1); }
            if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.program).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVasDefaultSet.Para.TableName()].Columns.Add(BusinessVasDefaultSet.Para.program); }
            if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVasDefaultSet.Para.TableName()].Columns.Add(BusinessVasDefaultSet.Para.edate); }
            if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVasDefaultSet.Para.TableName()].Columns.Add(BusinessVasDefaultSet.Para.active); }
            if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.trade_field).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVasDefaultSet.Para.TableName()].Columns.Add(BusinessVasDefaultSet.Para.trade_field); }
            if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.con_per).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVasDefaultSet.Para.TableName()].Columns.Add(BusinessVasDefaultSet.Para.con_per); }
            if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.display1).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVasDefaultSet.Para.TableName()].Columns.Add(BusinessVasDefaultSet.Para.display1); }
            if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.enabled2).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVasDefaultSet.Para.TableName()].Columns.Add(BusinessVasDefaultSet.Para.enabled2); }
            if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.vas2).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVasDefaultSet.Para.TableName()].Columns.Add(BusinessVasDefaultSet.Para.vas2); }
            if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.rate_plan).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVasDefaultSet.Para.TableName()].Columns.Add(BusinessVasDefaultSet.Para.rate_plan); }
            if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.enabled1).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVasDefaultSet.Para.TableName()].Columns.Add(BusinessVasDefaultSet.Para.enabled1); }
            if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.hs_model).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVasDefaultSet.Para.TableName()].Columns.Add(BusinessVasDefaultSet.Para.hs_model); }
            if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.vas1).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVasDefaultSet.Para.TableName()].Columns.Add(BusinessVasDefaultSet.Para.vas1); }
            if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.issue_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVasDefaultSet.Para.TableName()].Columns.Add(BusinessVasDefaultSet.Para.issue_type); }
            if (x_oBusinessVasDefaultSet != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[BusinessVasDefaultSet.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.display2).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVasDefaultSet.Para.display2] = x_oBusinessVasDefaultSet.GetDisplay2(); }
                if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVasDefaultSet.Para.mid] = x_oBusinessVasDefaultSet.GetMid(); }
                if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVasDefaultSet.Para.cdate] = x_oBusinessVasDefaultSet.GetCdate(); }
                if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.bundle_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVasDefaultSet.Para.bundle_name] = x_oBusinessVasDefaultSet.GetBundle_name(); }
                if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.value2).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVasDefaultSet.Para.value2] = x_oBusinessVasDefaultSet.GetValue2(); }
                if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVasDefaultSet.Para.cid] = x_oBusinessVasDefaultSet.GetCid(); }
                if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.value1).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVasDefaultSet.Para.value1] = x_oBusinessVasDefaultSet.GetValue1(); }
                if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.program).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVasDefaultSet.Para.program] = x_oBusinessVasDefaultSet.GetProgram(); }
                if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVasDefaultSet.Para.edate] = x_oBusinessVasDefaultSet.GetEdate(); }
                if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVasDefaultSet.Para.active] = x_oBusinessVasDefaultSet.GetActive(); }
                if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.trade_field).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVasDefaultSet.Para.trade_field] = x_oBusinessVasDefaultSet.GetTrade_field(); }
                if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.con_per).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVasDefaultSet.Para.con_per] = x_oBusinessVasDefaultSet.GetCon_per(); }
                if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.display1).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVasDefaultSet.Para.display1] = x_oBusinessVasDefaultSet.GetDisplay1(); }
                if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.enabled2).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVasDefaultSet.Para.enabled2] = x_oBusinessVasDefaultSet.GetEnabled2(); }
                if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.vas2).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVasDefaultSet.Para.vas2] = x_oBusinessVasDefaultSet.GetVas2(); }
                if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.rate_plan).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVasDefaultSet.Para.rate_plan] = x_oBusinessVasDefaultSet.GetRate_plan(); }
                if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.enabled1).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVasDefaultSet.Para.enabled1] = x_oBusinessVasDefaultSet.GetEnabled1(); }
                if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.hs_model).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVasDefaultSet.Para.hs_model] = x_oBusinessVasDefaultSet.GetHs_model(); }
                if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.vas1).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVasDefaultSet.Para.vas1] = x_oBusinessVasDefaultSet.GetVas1(); }
                if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.issue_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVasDefaultSet.Para.issue_type] = x_oBusinessVasDefaultSet.GetIssue_type(); }
                _oDSet.Tables[BusinessVasDefaultSet.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(BusinessVasDefaultSetInfo x_oTableSet)
        {
            return BusinessVasDefaultSetBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return BusinessVasDefaultSetBal.ToEmptyDataSetProcess(BusinessVasDefaultSetInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(BusinessVasDefaultSetInfo x_oTableSet)
        {
            return BusinessVasDefaultSetBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(BusinessVasDefaultSet x_oBusinessVasDefaultSet, BusinessVasDefaultSetInfo x_oTableSet)
        {
            return BusinessVasDefaultSetBal.GetDataSet(null, null, x_oTableSet).Tables[BusinessVasDefaultSet.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(BusinessVasDefaultSet x_oBusinessVasDefaultSet)
        {
            return BusinessVasDefaultSetBal.GetDataSet(x_oBusinessVasDefaultSet, null, BusinessVasDefaultSetInfoDLL.CreateInfoInstanceObject()).Tables[BusinessVasDefaultSet.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            return Row(x_oTable, x_oDB,x_iMid,BusinessVasDefaultSetInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid, BusinessVasDefaultSetInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iMid, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid,BusinessVasDefaultSetInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = BusinessVasDefaultSetInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [BusinessVasDefaultSet].[display2] AS BUSINESSVASDEFAULTSET_DISPLAY2,[BusinessVasDefaultSet].[mid] AS BUSINESSVASDEFAULTSET_MID,[BusinessVasDefaultSet].[cdate] AS BUSINESSVASDEFAULTSET_CDATE,[BusinessVasDefaultSet].[cid] AS BUSINESSVASDEFAULTSET_CID,[BusinessVasDefaultSet].[bundle_name] AS BUSINESSVASDEFAULTSET_BUNDLE_NAME,[BusinessVasDefaultSet].[value2] AS BUSINESSVASDEFAULTSET_VALUE2,[BusinessVasDefaultSet].[trade_field] AS BUSINESSVASDEFAULTSET_TRADE_FIELD,[BusinessVasDefaultSet].[value1] AS BUSINESSVASDEFAULTSET_VALUE1,[BusinessVasDefaultSet].[program] AS BUSINESSVASDEFAULTSET_PROGRAM,[BusinessVasDefaultSet].[edate] AS BUSINESSVASDEFAULTSET_EDATE,[BusinessVasDefaultSet].[active] AS BUSINESSVASDEFAULTSET_ACTIVE,[BusinessVasDefaultSet].[con_per] AS BUSINESSVASDEFAULTSET_CON_PER,[BusinessVasDefaultSet].[display1] AS BUSINESSVASDEFAULTSET_DISPLAY1,[BusinessVasDefaultSet].[enabled2] AS BUSINESSVASDEFAULTSET_ENABLED2,[BusinessVasDefaultSet].[vas2] AS BUSINESSVASDEFAULTSET_VAS2,[BusinessVasDefaultSet].[rate_plan] AS BUSINESSVASDEFAULTSET_RATE_PLAN,[BusinessVasDefaultSet].[enabled1] AS BUSINESSVASDEFAULTSET_ENABLED1,[BusinessVasDefaultSet].[hs_model] AS BUSINESSVASDEFAULTSET_HS_MODEL,[BusinessVasDefaultSet].[vas1] AS BUSINESSVASDEFAULTSET_VAS1,[BusinessVasDefaultSet].[issue_type] AS BUSINESSVASDEFAULTSET_ISSUE_TYPE  FROM  [BusinessVasDefaultSet]  WHERE  [BusinessVasDefaultSet].[mid] = \'"+x_iMid.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVasDefaultSet]","["+ Configurator.MSSQLTablePrefix + "BusinessVasDefaultSet]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.display2).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_DISPLAY2"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVasDefaultSet.Para.display2).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.display2).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["BUSINESSVASDEFAULTSET_DISPLAY2"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.display2).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.mid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_MID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVasDefaultSet.Para.mid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.mid).AliasName].ToString()] = (global::System.Nullable<int>)_oData["BUSINESSVASDEFAULTSET_MID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.mid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVasDefaultSet.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["BUSINESSVASDEFAULTSET_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.cid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVasDefaultSet.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.cid).AliasName].ToString()] = (string)_oData["BUSINESSVASDEFAULTSET_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.cid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.bundle_name).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_BUNDLE_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVasDefaultSet.Para.bundle_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.bundle_name).AliasName].ToString()] = (string)_oData["BUSINESSVASDEFAULTSET_BUNDLE_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.bundle_name).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.value2).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_VALUE2"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVasDefaultSet.Para.value2).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.value2).AliasName].ToString()] = (string)_oData["BUSINESSVASDEFAULTSET_VALUE2"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.value2).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.trade_field).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_TRADE_FIELD"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVasDefaultSet.Para.trade_field).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.trade_field).AliasName].ToString()] = (string)_oData["BUSINESSVASDEFAULTSET_TRADE_FIELD"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.trade_field).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.value1).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_VALUE1"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVasDefaultSet.Para.value1).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.value1).AliasName].ToString()] = (string)_oData["BUSINESSVASDEFAULTSET_VALUE1"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.value1).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.program).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_PROGRAM"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVasDefaultSet.Para.program).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.program).AliasName].ToString()] = (string)_oData["BUSINESSVASDEFAULTSET_PROGRAM"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.program).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.edate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_EDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVasDefaultSet.Para.edate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.edate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["BUSINESSVASDEFAULTSET_EDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.edate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVasDefaultSet.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["BUSINESSVASDEFAULTSET_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.con_per).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_CON_PER"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVasDefaultSet.Para.con_per).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.con_per).AliasName].ToString()] = (string)_oData["BUSINESSVASDEFAULTSET_CON_PER"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.con_per).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.display1).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_DISPLAY1"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVasDefaultSet.Para.display1).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.display1).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["BUSINESSVASDEFAULTSET_DISPLAY1"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.display1).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.enabled2).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_ENABLED2"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVasDefaultSet.Para.enabled2).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.enabled2).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["BUSINESSVASDEFAULTSET_ENABLED2"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.enabled2).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.vas2).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_VAS2"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVasDefaultSet.Para.vas2).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.vas2).AliasName].ToString()] = (string)_oData["BUSINESSVASDEFAULTSET_VAS2"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.vas2).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.rate_plan).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_RATE_PLAN"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVasDefaultSet.Para.rate_plan).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.rate_plan).AliasName].ToString()] = (string)_oData["BUSINESSVASDEFAULTSET_RATE_PLAN"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.rate_plan).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.enabled1).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_ENABLED1"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVasDefaultSet.Para.enabled1).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.enabled1).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["BUSINESSVASDEFAULTSET_ENABLED1"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.enabled1).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.hs_model).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_HS_MODEL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVasDefaultSet.Para.hs_model).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.hs_model).AliasName].ToString()] = (string)_oData["BUSINESSVASDEFAULTSET_HS_MODEL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.hs_model).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.vas1).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_VAS1"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVasDefaultSet.Para.vas1).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.vas1).AliasName].ToString()] = (string)_oData["BUSINESSVASDEFAULTSET_VAS1"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.vas1).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessVasDefaultSet.Para.issue_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_ISSUE_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVasDefaultSet.Para.issue_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.issue_type).AliasName].ToString()] = (string)_oData["BUSINESSVASDEFAULTSET_ISSUE_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDefaultSet.Para.issue_type).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,BusinessVasDefaultSet x_oBusinessVasDefaultSetRow)
        {
            return SetByDataSetRowProc(x_iROW, BusinessVasDefaultSet.Para.TableName(), x_oDataSet,x_oBusinessVasDefaultSetRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,BusinessVasDefaultSet x_oBusinessVasDefaultSetRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oBusinessVasDefaultSetRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,BusinessVasDefaultSet x_oBusinessVasDefaultSetRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                BusinessVasDefaultSetInfo _oTableSet=BusinessVasDefaultSetInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVasDefaultSet.Para.display2).AliasName))
                    x_oBusinessVasDefaultSetRow.display2 = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVasDefaultSet.Para.display2).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVasDefaultSet.Para.mid).AliasName))
                    x_oBusinessVasDefaultSetRow.mid = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVasDefaultSet.Para.mid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVasDefaultSet.Para.cdate).AliasName))
                    x_oBusinessVasDefaultSetRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVasDefaultSet.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVasDefaultSet.Para.bundle_name).AliasName))
                    x_oBusinessVasDefaultSetRow.bundle_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVasDefaultSet.Para.bundle_name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVasDefaultSet.Para.value2).AliasName))
                    x_oBusinessVasDefaultSetRow.value2 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVasDefaultSet.Para.value2).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVasDefaultSet.Para.cid).AliasName))
                    x_oBusinessVasDefaultSetRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVasDefaultSet.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVasDefaultSet.Para.value1).AliasName))
                    x_oBusinessVasDefaultSetRow.value1 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVasDefaultSet.Para.value1).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVasDefaultSet.Para.program).AliasName))
                    x_oBusinessVasDefaultSetRow.program = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVasDefaultSet.Para.program).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVasDefaultSet.Para.edate).AliasName))
                    x_oBusinessVasDefaultSetRow.edate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVasDefaultSet.Para.edate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVasDefaultSet.Para.active).AliasName))
                    x_oBusinessVasDefaultSetRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVasDefaultSet.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVasDefaultSet.Para.trade_field).AliasName))
                    x_oBusinessVasDefaultSetRow.trade_field = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVasDefaultSet.Para.trade_field).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVasDefaultSet.Para.con_per).AliasName))
                    x_oBusinessVasDefaultSetRow.con_per = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVasDefaultSet.Para.con_per).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVasDefaultSet.Para.display1).AliasName))
                    x_oBusinessVasDefaultSetRow.display1 = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVasDefaultSet.Para.display1).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVasDefaultSet.Para.enabled2).AliasName))
                    x_oBusinessVasDefaultSetRow.enabled2 = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVasDefaultSet.Para.enabled2).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVasDefaultSet.Para.vas2).AliasName))
                    x_oBusinessVasDefaultSetRow.vas2 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVasDefaultSet.Para.vas2).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVasDefaultSet.Para.rate_plan).AliasName))
                    x_oBusinessVasDefaultSetRow.rate_plan = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVasDefaultSet.Para.rate_plan).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVasDefaultSet.Para.enabled1).AliasName))
                    x_oBusinessVasDefaultSetRow.enabled1 = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVasDefaultSet.Para.enabled1).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVasDefaultSet.Para.hs_model).AliasName))
                    x_oBusinessVasDefaultSetRow.hs_model = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVasDefaultSet.Para.hs_model).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVasDefaultSet.Para.vas1).AliasName))
                    x_oBusinessVasDefaultSetRow.vas1 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVasDefaultSet.Para.vas1).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVasDefaultSet.Para.issue_type).AliasName))
                    x_oBusinessVasDefaultSetRow.issue_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVasDefaultSet.Para.issue_type).AliasName];
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
            return BusinessVasDefaultSetRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static BusinessVasDefaultSetEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return BusinessVasDefaultSetRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static BusinessVasDefaultSetEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return BusinessVasDefaultSetRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return BusinessVasDefaultSetRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return BusinessVasDefaultSetRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return BusinessVasDefaultSetRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bDisplay2,global::System.Nullable<DateTime> x_dCdate,string x_sBundle_name,string x_sValue2,string x_sCid,string x_sValue1,string x_sProgram,global::System.Nullable<DateTime> x_dEdate,global::System.Nullable<bool> x_bActive,string x_sTrade_field,string x_sCon_per,global::System.Nullable<bool> x_bDisplay1,global::System.Nullable<bool> x_bEnabled2,string x_sVas2,string x_sRate_plan,global::System.Nullable<bool> x_bEnabled1,string x_sHs_model,string x_sVas1,string x_sIssue_type)
        {
            return BusinessVasDefaultSetRepository.Insert(x_oDB, x_bDisplay2,x_dCdate,x_sBundle_name,x_sValue2,x_sCid,x_sValue1,x_sProgram,x_dEdate,x_bActive,x_sTrade_field,x_sCon_per,x_bDisplay1,x_bEnabled2,x_sVas2,x_sRate_plan,x_bEnabled1,x_sHs_model,x_sVas1,x_sIssue_type);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,BusinessVasDefaultSet x_oBusinessVasDefaultSet)
        {
            return BusinessVasDefaultSetRepository.InsertWithOutLastID(x_oDB,x_oBusinessVasDefaultSet);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<bool> x_bDisplay2,global::System.Nullable<DateTime> x_dCdate,string x_sBundle_name,string x_sValue2,string x_sCid,string x_sValue1,string x_sProgram,global::System.Nullable<DateTime> x_dEdate,global::System.Nullable<bool> x_bActive,string x_sTrade_field,string x_sCon_per,global::System.Nullable<bool> x_bDisplay1,global::System.Nullable<bool> x_bEnabled2,string x_sVas2,string x_sRate_plan,global::System.Nullable<bool> x_bEnabled1,string x_sHs_model,string x_sVas1,string x_sIssue_type)
        {
            return BusinessVasDefaultSetRepository.InsertReturnLastID_SP(x_oDB,x_bDisplay2,x_dCdate,x_sBundle_name,x_sValue2,x_sCid,x_sValue1,x_sProgram,x_dEdate,x_bActive,x_sTrade_field,x_sCon_per,x_bDisplay1,x_bEnabled2,x_sVas2,x_sRate_plan,x_bEnabled1,x_sHs_model,x_sVas1,x_sIssue_type);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, BusinessVasDefaultSet x_oBusinessVasDefaultSet)
        {
            return BusinessVasDefaultSetRepository.InsertReturnLastID_SP(x_oDB,x_oBusinessVasDefaultSet);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return BusinessVasDefaultSetRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return BusinessVasDefaultSetRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            return BusinessVasDefaultSetRepository.Delete(x_oDB, x_iMid);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(BusinessVasDefaultSet x_oBusinessVasDefaultSetRow){
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


