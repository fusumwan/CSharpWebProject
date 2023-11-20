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
///-- Create date: <Create Date 2011-02-16>
///-- Description:	<Description,Table :[MobileRetentionOrderDeliveryExchange],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileRetentionOrderDeliveryExchange] Business layer
    /// </summary>
    
    public abstract class MobileRetentionOrderDeliveryExchangeBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public MobileRetentionOrderDeliveryExchangeBalBase(){
        }
        ~MobileRetentionOrderDeliveryExchangeBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(MobileRetentionOrderDeliveryExchange x_oMobileRetentionOrderDeliveryExchange)
        {
            return GetDataSet(x_oMobileRetentionOrderDeliveryExchange,null,MobileRetentionOrderDeliveryExchangeInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileRetentionOrderDeliveryExchange x_oMobileRetentionOrderDeliveryExchange,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oMobileRetentionOrderDeliveryExchange,x_oMergeDSet,MobileRetentionOrderDeliveryExchangeInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileRetentionOrderDeliveryExchange x_oMobileRetentionOrderDeliveryExchange,MobileRetentionOrderDeliveryExchangeInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileRetentionOrderDeliveryExchange,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileRetentionOrderDeliveryExchange x_oMobileRetentionOrderDeliveryExchange,global::System.Data.DataSet x_oMergeDSet,MobileRetentionOrderDeliveryExchangeInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileRetentionOrderDeliveryExchange,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(MobileRetentionOrderDeliveryExchange x_oMobileRetentionOrderDeliveryExchange,global::System.Data.DataSet x_oMergeDSet,MobileRetentionOrderDeliveryExchangeInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileRetentionOrderDeliveryExchangeInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(MobileRetentionOrderDeliveryExchange.Para.TableName());
            if (x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.rate_plan).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrderDeliveryExchange.Para.TableName()].Columns.Add(MobileRetentionOrderDeliveryExchange.Para.rate_plan); }
            if (x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrderDeliveryExchange.Para.TableName()].Columns.Add(MobileRetentionOrderDeliveryExchange.Para.cdate); }
            if (x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrderDeliveryExchange.Para.TableName()].Columns.Add(MobileRetentionOrderDeliveryExchange.Para.cid); }
            if (x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrderDeliveryExchange.Para.TableName()].Columns.Add(MobileRetentionOrderDeliveryExchange.Para.did); }
            if (x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.con_per).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrderDeliveryExchange.Para.TableName()].Columns.Add(MobileRetentionOrderDeliveryExchange.Para.con_per); }
            if (x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrderDeliveryExchange.Para.TableName()].Columns.Add(MobileRetentionOrderDeliveryExchange.Para.id); }
            if (x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrderDeliveryExchange.Para.TableName()].Columns.Add(MobileRetentionOrderDeliveryExchange.Para.active); }
            if (x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.hs_model).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrderDeliveryExchange.Para.TableName()].Columns.Add(MobileRetentionOrderDeliveryExchange.Para.hs_model); }
            if (x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.program).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrderDeliveryExchange.Para.TableName()].Columns.Add(MobileRetentionOrderDeliveryExchange.Para.program); }
            if (x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.normal_rebate_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrderDeliveryExchange.Para.TableName()].Columns.Add(MobileRetentionOrderDeliveryExchange.Para.normal_rebate_type); }
            if (x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrderDeliveryExchange.Para.TableName()].Columns.Add(MobileRetentionOrderDeliveryExchange.Para.ddate); }
            if (x_oMobileRetentionOrderDeliveryExchange != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[MobileRetentionOrderDeliveryExchange.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.rate_plan).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrderDeliveryExchange.Para.rate_plan] = x_oMobileRetentionOrderDeliveryExchange.GetRate_plan(); }
                if (x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrderDeliveryExchange.Para.cdate] = x_oMobileRetentionOrderDeliveryExchange.GetCdate(); }
                if (x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrderDeliveryExchange.Para.cid] = x_oMobileRetentionOrderDeliveryExchange.GetCid(); }
                if (x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrderDeliveryExchange.Para.did] = x_oMobileRetentionOrderDeliveryExchange.GetDid(); }
                if (x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.con_per).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrderDeliveryExchange.Para.con_per] = x_oMobileRetentionOrderDeliveryExchange.GetCon_per(); }
                if (x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrderDeliveryExchange.Para.id] = x_oMobileRetentionOrderDeliveryExchange.GetId(); }
                if (x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrderDeliveryExchange.Para.active] = x_oMobileRetentionOrderDeliveryExchange.GetActive(); }
                if (x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.hs_model).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrderDeliveryExchange.Para.hs_model] = x_oMobileRetentionOrderDeliveryExchange.GetHs_model(); }
                if (x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.program).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrderDeliveryExchange.Para.program] = x_oMobileRetentionOrderDeliveryExchange.GetProgram(); }
                if (x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.normal_rebate_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrderDeliveryExchange.Para.normal_rebate_type] = x_oMobileRetentionOrderDeliveryExchange.GetNormal_rebate_type(); }
                if (x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrderDeliveryExchange.Para.ddate] = x_oMobileRetentionOrderDeliveryExchange.GetDdate(); }
                _oDSet.Tables[MobileRetentionOrderDeliveryExchange.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(MobileRetentionOrderDeliveryExchangeInfo x_oTableSet)
        {
            return MobileRetentionOrderDeliveryExchangeBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return MobileRetentionOrderDeliveryExchangeBal.ToEmptyDataSetProcess(MobileRetentionOrderDeliveryExchangeInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(MobileRetentionOrderDeliveryExchangeInfo x_oTableSet)
        {
            return MobileRetentionOrderDeliveryExchangeBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(MobileRetentionOrderDeliveryExchange x_oMobileRetentionOrderDeliveryExchange, MobileRetentionOrderDeliveryExchangeInfo x_oTableSet)
        {
            return MobileRetentionOrderDeliveryExchangeBal.GetDataSet(null, null, x_oTableSet).Tables[MobileRetentionOrderDeliveryExchange.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(MobileRetentionOrderDeliveryExchange x_oMobileRetentionOrderDeliveryExchange)
        {
            return MobileRetentionOrderDeliveryExchangeBal.GetDataSet(x_oMobileRetentionOrderDeliveryExchange, null, MobileRetentionOrderDeliveryExchangeInfoDLL.CreateInfoInstanceObject()).Tables[MobileRetentionOrderDeliveryExchange.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return Row(x_oTable, x_oDB,x_iId,MobileRetentionOrderDeliveryExchangeInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId, MobileRetentionOrderDeliveryExchangeInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iId, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId,MobileRetentionOrderDeliveryExchangeInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileRetentionOrderDeliveryExchangeInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [MobileRetentionOrderDeliveryExchange].[id] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_ID,[MobileRetentionOrderDeliveryExchange].[cdate] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_CDATE,[MobileRetentionOrderDeliveryExchange].[cid] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_CID,[MobileRetentionOrderDeliveryExchange].[did] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_DID,[MobileRetentionOrderDeliveryExchange].[active] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_ACTIVE,[MobileRetentionOrderDeliveryExchange].[rate_plan] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_RATE_PLAN,[MobileRetentionOrderDeliveryExchange].[program] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_PROGRAM,[MobileRetentionOrderDeliveryExchange].[hs_model] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_HS_MODEL,[MobileRetentionOrderDeliveryExchange].[normal_rebate_type] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_NORMAL_REBATE_TYPE,[MobileRetentionOrderDeliveryExchange].[ddate] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_DDATE,[MobileRetentionOrderDeliveryExchange].[con_per] AS MOBILERETENTIONORDERDELIVERYEXCHANGE_CON_PER  FROM  [MobileRetentionOrderDeliveryExchange]  WHERE  [MobileRetentionOrderDeliveryExchange].[id] = \'"+x_iId.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionOrderDeliveryExchange]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrderDeliveryExchange]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.cid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.cid).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.cid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.did).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.did).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.did).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.rate_plan).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_RATE_PLAN"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.rate_plan).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.rate_plan).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_RATE_PLAN"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.rate_plan).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.program).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_PROGRAM"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.program).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.program).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_PROGRAM"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.program).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.hs_model).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_HS_MODEL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.hs_model).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.hs_model).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_HS_MODEL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.hs_model).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.normal_rebate_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_NORMAL_REBATE_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.normal_rebate_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.normal_rebate_type).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_NORMAL_REBATE_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.normal_rebate_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.ddate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.ddate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.con_per).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_CON_PER"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.con_per).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.con_per).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDERDELIVERYEXCHANGE_CON_PER"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.con_per).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,MobileRetentionOrderDeliveryExchange x_oMobileRetentionOrderDeliveryExchangeRow)
        {
            return SetByDataSetRowProc(x_iROW, MobileRetentionOrderDeliveryExchange.Para.TableName(), x_oDataSet,x_oMobileRetentionOrderDeliveryExchangeRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileRetentionOrderDeliveryExchange x_oMobileRetentionOrderDeliveryExchangeRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oMobileRetentionOrderDeliveryExchangeRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileRetentionOrderDeliveryExchange x_oMobileRetentionOrderDeliveryExchangeRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                MobileRetentionOrderDeliveryExchangeInfo _oTableSet=MobileRetentionOrderDeliveryExchangeInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.rate_plan).AliasName))
                    x_oMobileRetentionOrderDeliveryExchangeRow.rate_plan = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.rate_plan).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.cdate).AliasName))
                    x_oMobileRetentionOrderDeliveryExchangeRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.cid).AliasName))
                    x_oMobileRetentionOrderDeliveryExchangeRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.did).AliasName))
                    x_oMobileRetentionOrderDeliveryExchangeRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.did).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.con_per).AliasName))
                    x_oMobileRetentionOrderDeliveryExchangeRow.con_per = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.con_per).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.id).AliasName))
                    x_oMobileRetentionOrderDeliveryExchangeRow.id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.active).AliasName))
                    x_oMobileRetentionOrderDeliveryExchangeRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.hs_model).AliasName))
                    x_oMobileRetentionOrderDeliveryExchangeRow.hs_model = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.hs_model).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.program).AliasName))
                    x_oMobileRetentionOrderDeliveryExchangeRow.program = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.program).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.normal_rebate_type).AliasName))
                    x_oMobileRetentionOrderDeliveryExchangeRow.normal_rebate_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.normal_rebate_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.ddate).AliasName))
                    x_oMobileRetentionOrderDeliveryExchangeRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrderDeliveryExchange.Para.ddate).AliasName];
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
            return MobileRetentionOrderDeliveryExchangeRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static MobileRetentionOrderDeliveryExchangeEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return MobileRetentionOrderDeliveryExchangeRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static MobileRetentionOrderDeliveryExchangeEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return MobileRetentionOrderDeliveryExchangeRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileRetentionOrderDeliveryExchangeRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileRetentionOrderDeliveryExchangeRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return MobileRetentionOrderDeliveryExchangeRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sRate_plan,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sCon_per,global::System.Nullable<bool> x_bActive,string x_sHs_model,string x_sProgram,string x_sNormal_rebate_type,global::System.Nullable<DateTime> x_dDdate)
        {
            return MobileRetentionOrderDeliveryExchangeRepository.Insert(x_oDB, x_sRate_plan,x_dCdate,x_sCid,x_sDid,x_sCon_per,x_bActive,x_sHs_model,x_sProgram,x_sNormal_rebate_type,x_dDdate);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileRetentionOrderDeliveryExchange x_oMobileRetentionOrderDeliveryExchange)
        {
            return MobileRetentionOrderDeliveryExchangeRepository.InsertWithOutLastID(x_oDB,x_oMobileRetentionOrderDeliveryExchange);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sRate_plan,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sCon_per,global::System.Nullable<bool> x_bActive,string x_sHs_model,string x_sProgram,string x_sNormal_rebate_type,global::System.Nullable<DateTime> x_dDdate)
        {
            return MobileRetentionOrderDeliveryExchangeRepository.InsertReturnLastID_SP(x_oDB,x_sRate_plan,x_dCdate,x_sCid,x_sDid,x_sCon_per,x_bActive,x_sHs_model,x_sProgram,x_sNormal_rebate_type,x_dDdate);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileRetentionOrderDeliveryExchange x_oMobileRetentionOrderDeliveryExchange)
        {
            return MobileRetentionOrderDeliveryExchangeRepository.InsertReturnLastID_SP(x_oDB,x_oMobileRetentionOrderDeliveryExchange);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return MobileRetentionOrderDeliveryExchangeRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return MobileRetentionOrderDeliveryExchangeRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return MobileRetentionOrderDeliveryExchangeRepository.Delete(x_oDB, x_iId);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(MobileRetentionOrderDeliveryExchange x_oMobileRetentionOrderDeliveryExchangeRow){
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


