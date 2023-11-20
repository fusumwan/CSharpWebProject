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
///-- Create date: <Create Date 2010-12-10>
///-- Description:	<Description,Table :[MobileOrderSyncSearch],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderSyncSearch] Business layer
    /// </summary>
    
    public abstract class MobileOrderSyncSearchBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public MobileOrderSyncSearchBalBase(){
        }
        ~MobileOrderSyncSearchBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderSyncSearch x_oMobileOrderSyncSearch)
        {
            return GetDataSet(x_oMobileOrderSyncSearch,null,MobileOrderSyncSearchInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderSyncSearch x_oMobileOrderSyncSearch,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oMobileOrderSyncSearch,x_oMergeDSet,MobileOrderSyncSearchInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderSyncSearch x_oMobileOrderSyncSearch,MobileOrderSyncSearchInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderSyncSearch,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderSyncSearch x_oMobileOrderSyncSearch,global::System.Data.DataSet x_oMergeDSet,MobileOrderSyncSearchInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderSyncSearch,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(MobileOrderSyncSearch x_oMobileOrderSyncSearch,global::System.Data.DataSet x_oMergeDSet,MobileOrderSyncSearchInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderSyncSearchInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(MobileOrderSyncSearch.Para.TableName());
            if (x_oTableSet.Fields(MobileOrderSyncSearch.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderSyncSearch.Para.TableName()].Columns.Add(MobileOrderSyncSearch.Para.active); }
            if (x_oTableSet.Fields(MobileOrderSyncSearch.Para.sku).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderSyncSearch.Para.TableName()].Columns.Add(MobileOrderSyncSearch.Para.sku); }
            if (x_oTableSet.Fields(MobileOrderSyncSearch.Para.program).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderSyncSearch.Para.TableName()].Columns.Add(MobileOrderSyncSearch.Para.program); }
            if (x_oTableSet.Fields(MobileOrderSyncSearch.Para.sim_item_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderSyncSearch.Para.TableName()].Columns.Add(MobileOrderSyncSearch.Para.sim_item_name); }
            if (x_oTableSet.Fields(MobileOrderSyncSearch.Para.d_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderSyncSearch.Para.TableName()].Columns.Add(MobileOrderSyncSearch.Para.d_date); }
            if (x_oTableSet.Fields(MobileOrderSyncSearch.Para.edf_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderSyncSearch.Para.TableName()].Columns.Add(MobileOrderSyncSearch.Para.edf_no); }
            if (x_oTableSet.Fields(MobileOrderSyncSearch.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderSyncSearch.Para.TableName()].Columns.Add(MobileOrderSyncSearch.Para.order_id); }
            if (x_oTableSet.Fields(MobileOrderSyncSearch.Para.sim_item_code).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderSyncSearch.Para.TableName()].Columns.Add(MobileOrderSyncSearch.Para.sim_item_code); }
            if (x_oTableSet.Fields(MobileOrderSyncSearch.Para.imei_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderSyncSearch.Para.TableName()].Columns.Add(MobileOrderSyncSearch.Para.imei_no); }
            if (x_oMobileOrderSyncSearch != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[MobileOrderSyncSearch.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(MobileOrderSyncSearch.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderSyncSearch.Para.active] = x_oMobileOrderSyncSearch.GetActive(); }
                if (x_oTableSet.Fields(MobileOrderSyncSearch.Para.sku).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderSyncSearch.Para.sku] = x_oMobileOrderSyncSearch.GetSku(); }
                if (x_oTableSet.Fields(MobileOrderSyncSearch.Para.program).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderSyncSearch.Para.program] = x_oMobileOrderSyncSearch.GetProgram(); }
                if (x_oTableSet.Fields(MobileOrderSyncSearch.Para.sim_item_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderSyncSearch.Para.sim_item_name] = x_oMobileOrderSyncSearch.GetSim_item_name(); }
                if (x_oTableSet.Fields(MobileOrderSyncSearch.Para.d_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderSyncSearch.Para.d_date] = x_oMobileOrderSyncSearch.GetD_date(); }
                if (x_oTableSet.Fields(MobileOrderSyncSearch.Para.edf_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderSyncSearch.Para.edf_no] = x_oMobileOrderSyncSearch.GetEdf_no(); }
                if (x_oTableSet.Fields(MobileOrderSyncSearch.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderSyncSearch.Para.order_id] = x_oMobileOrderSyncSearch.GetOrder_id(); }
                if (x_oTableSet.Fields(MobileOrderSyncSearch.Para.sim_item_code).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderSyncSearch.Para.sim_item_code] = x_oMobileOrderSyncSearch.GetSim_item_code(); }
                if (x_oTableSet.Fields(MobileOrderSyncSearch.Para.imei_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderSyncSearch.Para.imei_no] = x_oMobileOrderSyncSearch.GetImei_no(); }
                _oDSet.Tables[MobileOrderSyncSearch.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(MobileOrderSyncSearchInfo x_oTableSet)
        {
            return MobileOrderSyncSearchBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return MobileOrderSyncSearchBal.ToEmptyDataSetProcess(MobileOrderSyncSearchInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(MobileOrderSyncSearchInfo x_oTableSet)
        {
            return MobileOrderSyncSearchBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(MobileOrderSyncSearch x_oMobileOrderSyncSearch, MobileOrderSyncSearchInfo x_oTableSet)
        {
            return MobileOrderSyncSearchBal.GetDataSet(null, null, x_oTableSet).Tables[MobileOrderSyncSearch.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(MobileOrderSyncSearch x_oMobileOrderSyncSearch)
        {
            return MobileOrderSyncSearchBal.GetDataSet(x_oMobileOrderSyncSearch, null, MobileOrderSyncSearchInfoDLL.CreateInfoInstanceObject()).Tables[MobileOrderSyncSearch.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iOrder_id)
        {
            return Row(x_oTable, x_oDB,x_iOrder_id,MobileOrderSyncSearchInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iOrder_id, MobileOrderSyncSearchInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iOrder_id, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iOrder_id,MobileOrderSyncSearchInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderSyncSearchInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [MobileOrderSyncSearch].[edf_no] AS MOBILEORDERSYNCSEARCH_EDF_NO,[MobileOrderSyncSearch].[active] AS MOBILEORDERSYNCSEARCH_ACTIVE,[MobileOrderSyncSearch].[sku] AS MOBILEORDERSYNCSEARCH_SKU,[MobileOrderSyncSearch].[sim_item_name] AS MOBILEORDERSYNCSEARCH_SIM_ITEM_NAME,[MobileOrderSyncSearch].[d_date] AS MOBILEORDERSYNCSEARCH_D_DATE,[MobileOrderSyncSearch].[program] AS MOBILEORDERSYNCSEARCH_PROGRAM,[MobileOrderSyncSearch].[order_id] AS MOBILEORDERSYNCSEARCH_ORDER_ID,[MobileOrderSyncSearch].[sim_item_code] AS MOBILEORDERSYNCSEARCH_SIM_ITEM_CODE,[MobileOrderSyncSearch].[imei_no] AS MOBILEORDERSYNCSEARCH_IMEI_NO  FROM  [MobileOrderSyncSearch]  WHERE  [MobileOrderSyncSearch].[order_id] = \'"+x_iOrder_id.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderSyncSearch]","["+ Configurator.MSSQLTablePrefix + "MobileOrderSyncSearch]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(MobileOrderSyncSearch.Para.edf_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_EDF_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderSyncSearch.Para.edf_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderSyncSearch.Para.edf_no).AliasName].ToString()] = (string)_oData["MOBILEORDERSYNCSEARCH_EDF_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderSyncSearch.Para.edf_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderSyncSearch.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderSyncSearch.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderSyncSearch.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILEORDERSYNCSEARCH_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderSyncSearch.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderSyncSearch.Para.sku).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_SKU"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderSyncSearch.Para.sku).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderSyncSearch.Para.sku).AliasName].ToString()] = (string)_oData["MOBILEORDERSYNCSEARCH_SKU"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderSyncSearch.Para.sku).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderSyncSearch.Para.sim_item_name).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_SIM_ITEM_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderSyncSearch.Para.sim_item_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderSyncSearch.Para.sim_item_name).AliasName].ToString()] = (string)_oData["MOBILEORDERSYNCSEARCH_SIM_ITEM_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderSyncSearch.Para.sim_item_name).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderSyncSearch.Para.d_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_D_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderSyncSearch.Para.d_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderSyncSearch.Para.d_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERSYNCSEARCH_D_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderSyncSearch.Para.d_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderSyncSearch.Para.program).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_PROGRAM"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderSyncSearch.Para.program).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderSyncSearch.Para.program).AliasName].ToString()] = (string)_oData["MOBILEORDERSYNCSEARCH_PROGRAM"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderSyncSearch.Para.program).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderSyncSearch.Para.order_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_ORDER_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderSyncSearch.Para.order_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderSyncSearch.Para.order_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERSYNCSEARCH_ORDER_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderSyncSearch.Para.order_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderSyncSearch.Para.sim_item_code).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_SIM_ITEM_CODE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderSyncSearch.Para.sim_item_code).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderSyncSearch.Para.sim_item_code).AliasName].ToString()] = (string)_oData["MOBILEORDERSYNCSEARCH_SIM_ITEM_CODE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderSyncSearch.Para.sim_item_code).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderSyncSearch.Para.imei_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERSYNCSEARCH_IMEI_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderSyncSearch.Para.imei_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderSyncSearch.Para.imei_no).AliasName].ToString()] = (string)_oData["MOBILEORDERSYNCSEARCH_IMEI_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderSyncSearch.Para.imei_no).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,MobileOrderSyncSearch x_oMobileOrderSyncSearchRow)
        {
            return SetByDataSetRowProc(x_iROW, MobileOrderSyncSearch.Para.TableName(), x_oDataSet,x_oMobileOrderSyncSearchRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderSyncSearch x_oMobileOrderSyncSearchRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oMobileOrderSyncSearchRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderSyncSearch x_oMobileOrderSyncSearchRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                MobileOrderSyncSearchInfo _oTableSet=MobileOrderSyncSearchInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderSyncSearch.Para.active).AliasName))
                    x_oMobileOrderSyncSearchRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderSyncSearch.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderSyncSearch.Para.sku).AliasName))
                    x_oMobileOrderSyncSearchRow.sku = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderSyncSearch.Para.sku).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderSyncSearch.Para.program).AliasName))
                    x_oMobileOrderSyncSearchRow.program = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderSyncSearch.Para.program).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderSyncSearch.Para.sim_item_name).AliasName))
                    x_oMobileOrderSyncSearchRow.sim_item_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderSyncSearch.Para.sim_item_name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderSyncSearch.Para.d_date).AliasName))
                    x_oMobileOrderSyncSearchRow.d_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderSyncSearch.Para.d_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderSyncSearch.Para.edf_no).AliasName))
                    x_oMobileOrderSyncSearchRow.edf_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderSyncSearch.Para.edf_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderSyncSearch.Para.order_id).AliasName))
                    x_oMobileOrderSyncSearchRow.order_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderSyncSearch.Para.order_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderSyncSearch.Para.sim_item_code).AliasName))
                    x_oMobileOrderSyncSearchRow.sim_item_code = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderSyncSearch.Para.sim_item_code).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderSyncSearch.Para.imei_no).AliasName))
                    x_oMobileOrderSyncSearchRow.imei_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderSyncSearch.Para.imei_no).AliasName];
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
            return MobileOrderSyncSearchRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static MobileOrderSyncSearchEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return MobileOrderSyncSearchRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static MobileOrderSyncSearchEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return MobileOrderSyncSearchRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderSyncSearchRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderSyncSearchRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderSyncSearchRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bActive,string x_sSku,string x_sProgram,string x_sSim_item_name,global::System.Nullable<DateTime> x_dD_date,string x_sEdf_no,string x_sSim_item_code,string x_sImei_no)
        {
            return MobileOrderSyncSearchRepository.Insert(x_oDB, x_bActive,x_sSku,x_sProgram,x_sSim_item_name,x_dD_date,x_sEdf_no,x_sSim_item_code,x_sImei_no);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderSyncSearch x_oMobileOrderSyncSearch)
        {
            return MobileOrderSyncSearchRepository.InsertWithOutLastID(x_oDB,x_oMobileOrderSyncSearch);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<bool> x_bActive,string x_sSku,string x_sProgram,string x_sSim_item_name,global::System.Nullable<DateTime> x_dD_date,string x_sEdf_no,string x_sSim_item_code,string x_sImei_no)
        {
            return MobileOrderSyncSearchRepository.InsertReturnLastID_SP(x_oDB,x_bActive,x_sSku,x_sProgram,x_sSim_item_name,x_dD_date,x_sEdf_no,x_sSim_item_code,x_sImei_no);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderSyncSearch x_oMobileOrderSyncSearch)
        {
            return MobileOrderSyncSearchRepository.InsertReturnLastID_SP(x_oDB,x_oMobileOrderSyncSearch);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return MobileOrderSyncSearchRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderSyncSearchRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iOrder_id)
        {
            return MobileOrderSyncSearchRepository.Delete(x_oDB, x_iOrder_id);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(MobileOrderSyncSearch x_oMobileOrderSyncSearchRow){
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


