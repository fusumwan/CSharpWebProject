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
///-- Create date: <Create Date 2010-08-20>
///-- Description:	<Description,Table :[MobileOrderMigrateRule],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderMigrateRule] Business layer
    /// </summary>
    
    public abstract class MobileOrderMigrateRuleBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public MobileOrderMigrateRuleBalBase(){
        }
        ~MobileOrderMigrateRuleBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderMigrateRule x_oMobileOrderMigrateRule)
        {
            return GetDataSet(x_oMobileOrderMigrateRule,null,MobileOrderMigrateRuleInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderMigrateRule x_oMobileOrderMigrateRule,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oMobileOrderMigrateRule,x_oMergeDSet,MobileOrderMigrateRuleInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderMigrateRule x_oMobileOrderMigrateRule,MobileOrderMigrateRuleInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderMigrateRule,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderMigrateRule x_oMobileOrderMigrateRule,global::System.Data.DataSet x_oMergeDSet,MobileOrderMigrateRuleInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderMigrateRule,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(MobileOrderMigrateRule x_oMobileOrderMigrateRule,global::System.Data.DataSet x_oMergeDSet,MobileOrderMigrateRuleInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderMigrateRuleInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(MobileOrderMigrateRule.Para.TableName());
            if (x_oTableSet.Fields(MobileOrderMigrateRule.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMigrateRule.Para.TableName()].Columns.Add(MobileOrderMigrateRule.Para.id); }
            if (x_oTableSet.Fields(MobileOrderMigrateRule.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMigrateRule.Para.TableName()].Columns.Add(MobileOrderMigrateRule.Para.cdate); }
            if (x_oTableSet.Fields(MobileOrderMigrateRule.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMigrateRule.Para.TableName()].Columns.Add(MobileOrderMigrateRule.Para.cid); }
            if (x_oTableSet.Fields(MobileOrderMigrateRule.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMigrateRule.Para.TableName()].Columns.Add(MobileOrderMigrateRule.Para.did); }
            if (x_oTableSet.Fields(MobileOrderMigrateRule.Para.status).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMigrateRule.Para.TableName()].Columns.Add(MobileOrderMigrateRule.Para.status); }
            if (x_oTableSet.Fields(MobileOrderMigrateRule.Para.type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMigrateRule.Para.TableName()].Columns.Add(MobileOrderMigrateRule.Para.type); }
            if (x_oTableSet.Fields(MobileOrderMigrateRule.Para.chk).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMigrateRule.Para.TableName()].Columns.Add(MobileOrderMigrateRule.Para.chk); }
            if (x_oTableSet.Fields(MobileOrderMigrateRule.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMigrateRule.Para.TableName()].Columns.Add(MobileOrderMigrateRule.Para.active); }
            if (x_oTableSet.Fields(MobileOrderMigrateRule.Para.name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMigrateRule.Para.TableName()].Columns.Add(MobileOrderMigrateRule.Para.name); }
            if (x_oTableSet.Fields(MobileOrderMigrateRule.Para.sku).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMigrateRule.Para.TableName()].Columns.Add(MobileOrderMigrateRule.Para.sku); }
            if (x_oTableSet.Fields(MobileOrderMigrateRule.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMigrateRule.Para.TableName()].Columns.Add(MobileOrderMigrateRule.Para.ddate); }
            if (x_oMobileOrderMigrateRule != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[MobileOrderMigrateRule.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(MobileOrderMigrateRule.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMigrateRule.Para.id] = x_oMobileOrderMigrateRule.GetId(); }
                if (x_oTableSet.Fields(MobileOrderMigrateRule.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMigrateRule.Para.cdate] = x_oMobileOrderMigrateRule.GetCdate(); }
                if (x_oTableSet.Fields(MobileOrderMigrateRule.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMigrateRule.Para.cid] = x_oMobileOrderMigrateRule.GetCid(); }
                if (x_oTableSet.Fields(MobileOrderMigrateRule.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMigrateRule.Para.did] = x_oMobileOrderMigrateRule.GetDid(); }
                if (x_oTableSet.Fields(MobileOrderMigrateRule.Para.status).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMigrateRule.Para.status] = x_oMobileOrderMigrateRule.GetStatus(); }
                if (x_oTableSet.Fields(MobileOrderMigrateRule.Para.type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMigrateRule.Para.type] = x_oMobileOrderMigrateRule.GetType(); }
                if (x_oTableSet.Fields(MobileOrderMigrateRule.Para.chk).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMigrateRule.Para.chk] = x_oMobileOrderMigrateRule.GetChk(); }
                if (x_oTableSet.Fields(MobileOrderMigrateRule.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMigrateRule.Para.active] = x_oMobileOrderMigrateRule.GetActive(); }
                if (x_oTableSet.Fields(MobileOrderMigrateRule.Para.name).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMigrateRule.Para.name] = x_oMobileOrderMigrateRule.GetName(); }
                if (x_oTableSet.Fields(MobileOrderMigrateRule.Para.sku).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMigrateRule.Para.sku] = x_oMobileOrderMigrateRule.GetSku(); }
                if (x_oTableSet.Fields(MobileOrderMigrateRule.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMigrateRule.Para.ddate] = x_oMobileOrderMigrateRule.GetDdate(); }
                _oDSet.Tables[MobileOrderMigrateRule.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(MobileOrderMigrateRuleInfo x_oTableSet)
        {
            return MobileOrderMigrateRuleBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return MobileOrderMigrateRuleBal.ToEmptyDataSetProcess(MobileOrderMigrateRuleInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(MobileOrderMigrateRuleInfo x_oTableSet)
        {
            return MobileOrderMigrateRuleBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(MobileOrderMigrateRule x_oMobileOrderMigrateRule, MobileOrderMigrateRuleInfo x_oTableSet)
        {
            return MobileOrderMigrateRuleBal.GetDataSet(null, null, x_oTableSet).Tables[MobileOrderMigrateRule.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(MobileOrderMigrateRule x_oMobileOrderMigrateRule)
        {
            return MobileOrderMigrateRuleBal.GetDataSet(x_oMobileOrderMigrateRule, null, MobileOrderMigrateRuleInfoDLL.CreateInfoInstanceObject()).Tables[MobileOrderMigrateRule.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return Row(x_oTable, x_oDB,x_iId,MobileOrderMigrateRuleInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId, MobileOrderMigrateRuleInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iId, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId,MobileOrderMigrateRuleInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderMigrateRuleInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [MobileOrderMigrateRule].[id] AS MOBILEORDERMIGRATERULE_ID,[MobileOrderMigrateRule].[cdate] AS MOBILEORDERMIGRATERULE_CDATE,[MobileOrderMigrateRule].[cid] AS MOBILEORDERMIGRATERULE_CID,[MobileOrderMigrateRule].[did] AS MOBILEORDERMIGRATERULE_DID,[MobileOrderMigrateRule].[status] AS MOBILEORDERMIGRATERULE_STATUS,[MobileOrderMigrateRule].[type] AS MOBILEORDERMIGRATERULE_TYPE,[MobileOrderMigrateRule].[chk] AS MOBILEORDERMIGRATERULE_CHK,[MobileOrderMigrateRule].[active] AS MOBILEORDERMIGRATERULE_ACTIVE,[MobileOrderMigrateRule].[name] AS MOBILEORDERMIGRATERULE_NAME,[MobileOrderMigrateRule].[sku] AS MOBILEORDERMIGRATERULE_SKU,[MobileOrderMigrateRule].[ddate] AS MOBILEORDERMIGRATERULE_DDATE  FROM  [MobileOrderMigrateRule]  WHERE  [MobileOrderMigrateRule].[id] = \'"+x_iId.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMigrateRule]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMigrateRule]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(MobileOrderMigrateRule.Para.id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMigrateRule.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMigrateRule.Para.id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERMIGRATERULE_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMigrateRule.Para.id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMigrateRule.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMigrateRule.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMigrateRule.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERMIGRATERULE_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMigrateRule.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMigrateRule.Para.cid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMigrateRule.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMigrateRule.Para.cid).AliasName].ToString()] = (string)_oData["MOBILEORDERMIGRATERULE_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMigrateRule.Para.cid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMigrateRule.Para.did).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMigrateRule.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMigrateRule.Para.did).AliasName].ToString()] = (string)_oData["MOBILEORDERMIGRATERULE_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMigrateRule.Para.did).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMigrateRule.Para.status).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_STATUS"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMigrateRule.Para.status).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMigrateRule.Para.status).AliasName].ToString()] = (string)_oData["MOBILEORDERMIGRATERULE_STATUS"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMigrateRule.Para.status).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMigrateRule.Para.type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMigrateRule.Para.type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMigrateRule.Para.type).AliasName].ToString()] = (string)_oData["MOBILEORDERMIGRATERULE_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMigrateRule.Para.type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMigrateRule.Para.chk).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_CHK"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMigrateRule.Para.chk).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMigrateRule.Para.chk).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILEORDERMIGRATERULE_CHK"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMigrateRule.Para.chk).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMigrateRule.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMigrateRule.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMigrateRule.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILEORDERMIGRATERULE_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMigrateRule.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMigrateRule.Para.name).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMigrateRule.Para.name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMigrateRule.Para.name).AliasName].ToString()] = (string)_oData["MOBILEORDERMIGRATERULE_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMigrateRule.Para.name).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMigrateRule.Para.sku).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_SKU"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMigrateRule.Para.sku).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMigrateRule.Para.sku).AliasName].ToString()] = (string)_oData["MOBILEORDERMIGRATERULE_SKU"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMigrateRule.Para.sku).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMigrateRule.Para.ddate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMIGRATERULE_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMigrateRule.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMigrateRule.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERMIGRATERULE_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMigrateRule.Para.ddate).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,MobileOrderMigrateRule x_oMobileOrderMigrateRuleRow)
        {
            return SetByDataSetRowProc(x_iROW, MobileOrderMigrateRule.Para.TableName(), x_oDataSet,x_oMobileOrderMigrateRuleRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderMigrateRule x_oMobileOrderMigrateRuleRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oMobileOrderMigrateRuleRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderMigrateRule x_oMobileOrderMigrateRuleRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                MobileOrderMigrateRuleInfo _oTableSet=MobileOrderMigrateRuleInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMigrateRule.Para.id).AliasName))
                    x_oMobileOrderMigrateRuleRow.id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMigrateRule.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMigrateRule.Para.cdate).AliasName))
                    x_oMobileOrderMigrateRuleRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMigrateRule.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMigrateRule.Para.cid).AliasName))
                    x_oMobileOrderMigrateRuleRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMigrateRule.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMigrateRule.Para.did).AliasName))
                    x_oMobileOrderMigrateRuleRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMigrateRule.Para.did).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMigrateRule.Para.status).AliasName))
                    x_oMobileOrderMigrateRuleRow.status = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMigrateRule.Para.status).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMigrateRule.Para.type).AliasName))
                    x_oMobileOrderMigrateRuleRow.type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMigrateRule.Para.type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMigrateRule.Para.chk).AliasName))
                    x_oMobileOrderMigrateRuleRow.chk = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMigrateRule.Para.chk).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMigrateRule.Para.active).AliasName))
                    x_oMobileOrderMigrateRuleRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMigrateRule.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMigrateRule.Para.name).AliasName))
                    x_oMobileOrderMigrateRuleRow.name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMigrateRule.Para.name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMigrateRule.Para.sku).AliasName))
                    x_oMobileOrderMigrateRuleRow.sku = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMigrateRule.Para.sku).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMigrateRule.Para.ddate).AliasName))
                    x_oMobileOrderMigrateRuleRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMigrateRule.Para.ddate).AliasName];
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
            return MobileOrderMigrateRuleRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static MobileOrderMigrateRuleEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return MobileOrderMigrateRuleRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static MobileOrderMigrateRuleEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return MobileOrderMigrateRuleRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderMigrateRuleRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderMigrateRuleRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderMigrateRuleRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sStatus,string x_sType,global::System.Nullable<bool> x_bChk,global::System.Nullable<bool> x_bActive,string x_sName,string x_sSku,global::System.Nullable<DateTime> x_dDdate)
        {
            return MobileOrderMigrateRuleRepository.Insert(x_oDB, x_dCdate,x_sCid,x_sDid,x_sStatus,x_sType,x_bChk,x_bActive,x_sName,x_sSku,x_dDdate);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderMigrateRule x_oMobileOrderMigrateRule)
        {
            return MobileOrderMigrateRuleRepository.InsertWithOutLastID(x_oDB,x_oMobileOrderMigrateRule);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sStatus,string x_sType,global::System.Nullable<bool> x_bChk,global::System.Nullable<bool> x_bActive,string x_sName,string x_sSku,global::System.Nullable<DateTime> x_dDdate)
        {
            return MobileOrderMigrateRuleRepository.InsertReturnLastID_SP(x_oDB,x_dCdate,x_sCid,x_sDid,x_sStatus,x_sType,x_bChk,x_bActive,x_sName,x_sSku,x_dDdate);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderMigrateRule x_oMobileOrderMigrateRule)
        {
            return MobileOrderMigrateRuleRepository.InsertReturnLastID_SP(x_oDB,x_oMobileOrderMigrateRule);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return MobileOrderMigrateRuleRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderMigrateRuleRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return MobileOrderMigrateRuleRepository.Delete(x_oDB, x_iId);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(MobileOrderMigrateRule x_oMobileOrderMigrateRuleRow){
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


