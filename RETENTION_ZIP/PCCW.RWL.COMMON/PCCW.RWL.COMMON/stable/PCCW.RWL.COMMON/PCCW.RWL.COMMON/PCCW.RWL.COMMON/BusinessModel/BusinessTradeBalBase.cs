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
///-- Create date: <Create Date 2011-07-13>
///-- Description:	<Description,Table :[BusinessTrade],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [BusinessTrade] Business layer
    /// </summary>
    
    public abstract class BusinessTradeBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public BusinessTradeBalBase(){
        }
        ~BusinessTradeBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(BusinessTrade x_oBusinessTrade)
        {
            return GetDataSet(x_oBusinessTrade,null,BusinessTradeInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(BusinessTrade x_oBusinessTrade,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oBusinessTrade,x_oMergeDSet,BusinessTradeInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(BusinessTrade x_oBusinessTrade,BusinessTradeInfo x_oTableSet)
        {
            return GetDataSet(x_oBusinessTrade,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(BusinessTrade x_oBusinessTrade,global::System.Data.DataSet x_oMergeDSet,BusinessTradeInfo x_oTableSet)
        {
            return GetDataSet(x_oBusinessTrade,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(BusinessTrade x_oBusinessTrade,global::System.Data.DataSet x_oMergeDSet,BusinessTradeInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = BusinessTradeInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(BusinessTrade.Para.TableName());
            if (x_oTableSet.Fields(BusinessTrade.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTrade.Para.TableName()].Columns.Add(BusinessTrade.Para.mid); }
            if (x_oTableSet.Fields(BusinessTrade.Para.channel).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTrade.Para.TableName()].Columns.Add(BusinessTrade.Para.channel); }
            if (x_oTableSet.Fields(BusinessTrade.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTrade.Para.TableName()].Columns.Add(BusinessTrade.Para.cdate); }
            if (x_oTableSet.Fields(BusinessTrade.Para.bundle_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTrade.Para.TableName()].Columns.Add(BusinessTrade.Para.bundle_name); }
            if (x_oTableSet.Fields(BusinessTrade.Para.hs_model_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTrade.Para.TableName()].Columns.Add(BusinessTrade.Para.hs_model_name); }
            if (x_oTableSet.Fields(BusinessTrade.Para.trade_field).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTrade.Para.TableName()].Columns.Add(BusinessTrade.Para.trade_field); }
            if (x_oTableSet.Fields(BusinessTrade.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTrade.Para.TableName()].Columns.Add(BusinessTrade.Para.did); }
            if (x_oTableSet.Fields(BusinessTrade.Para.premium_1).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTrade.Para.TableName()].Columns.Add(BusinessTrade.Para.premium_1); }
            if (x_oTableSet.Fields(BusinessTrade.Para.sdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTrade.Para.TableName()].Columns.Add(BusinessTrade.Para.sdate); }
            if (x_oTableSet.Fields(BusinessTrade.Para.rebate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTrade.Para.TableName()].Columns.Add(BusinessTrade.Para.rebate); }
            if (x_oTableSet.Fields(BusinessTrade.Para.premium_2).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTrade.Para.TableName()].Columns.Add(BusinessTrade.Para.premium_2); }
            if (x_oTableSet.Fields(BusinessTrade.Para.retention_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTrade.Para.TableName()].Columns.Add(BusinessTrade.Para.retention_type); }
            if (x_oTableSet.Fields(BusinessTrade.Para.extra_offer).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTrade.Para.TableName()].Columns.Add(BusinessTrade.Para.extra_offer); }
            if (x_oTableSet.Fields(BusinessTrade.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTrade.Para.TableName()].Columns.Add(BusinessTrade.Para.edate); }
            if (x_oTableSet.Fields(BusinessTrade.Para.program).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTrade.Para.TableName()].Columns.Add(BusinessTrade.Para.program); }
            if (x_oTableSet.Fields(BusinessTrade.Para.con_per).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTrade.Para.TableName()].Columns.Add(BusinessTrade.Para.con_per); }
            if (x_oTableSet.Fields(BusinessTrade.Para.rate_plan).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTrade.Para.TableName()].Columns.Add(BusinessTrade.Para.rate_plan); }
            if (x_oTableSet.Fields(BusinessTrade.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTrade.Para.TableName()].Columns.Add(BusinessTrade.Para.ddate); }
            if (x_oTableSet.Fields(BusinessTrade.Para.normal_rebate_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTrade.Para.TableName()].Columns.Add(BusinessTrade.Para.normal_rebate_type); }
            if (x_oTableSet.Fields(BusinessTrade.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTrade.Para.TableName()].Columns.Add(BusinessTrade.Para.active); }
            if (x_oTableSet.Fields(BusinessTrade.Para.free_mon).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTrade.Para.TableName()].Columns.Add(BusinessTrade.Para.free_mon); }
            if (x_oTableSet.Fields(BusinessTrade.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTrade.Para.TableName()].Columns.Add(BusinessTrade.Para.cid); }
            if (x_oTableSet.Fields(BusinessTrade.Para.cancel_renew).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTrade.Para.TableName()].Columns.Add(BusinessTrade.Para.cancel_renew); }
            if (x_oTableSet.Fields(BusinessTrade.Para.ob_early).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTrade.Para.TableName()].Columns.Add(BusinessTrade.Para.ob_early); }
            if (x_oTableSet.Fields(BusinessTrade.Para.normal_rebate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTrade.Para.TableName()].Columns.Add(BusinessTrade.Para.normal_rebate); }
            if (x_oTableSet.Fields(BusinessTrade.Para.hs_model).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTrade.Para.TableName()].Columns.Add(BusinessTrade.Para.hs_model); }
            if (x_oTableSet.Fields(BusinessTrade.Para.plan_fee).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTrade.Para.TableName()].Columns.Add(BusinessTrade.Para.plan_fee); }
            if (x_oTableSet.Fields(BusinessTrade.Para.po_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTrade.Para.TableName()].Columns.Add(BusinessTrade.Para.po_date); }
            if (x_oTableSet.Fields(BusinessTrade.Para.remarks).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTrade.Para.TableName()].Columns.Add(BusinessTrade.Para.remarks); }
            if (x_oTableSet.Fields(BusinessTrade.Para.issue_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTrade.Para.TableName()].Columns.Add(BusinessTrade.Para.issue_type); }
            if (x_oBusinessTrade != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[BusinessTrade.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(BusinessTrade.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTrade.Para.mid] = x_oBusinessTrade.GetMid(); }
                if (x_oTableSet.Fields(BusinessTrade.Para.channel).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTrade.Para.channel] = x_oBusinessTrade.GetChannel(); }
                if (x_oTableSet.Fields(BusinessTrade.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTrade.Para.cdate] = x_oBusinessTrade.GetCdate(); }
                if (x_oTableSet.Fields(BusinessTrade.Para.bundle_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTrade.Para.bundle_name] = x_oBusinessTrade.GetBundle_name(); }
                if (x_oTableSet.Fields(BusinessTrade.Para.hs_model_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTrade.Para.hs_model_name] = x_oBusinessTrade.GetHs_model_name(); }
                if (x_oTableSet.Fields(BusinessTrade.Para.trade_field).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTrade.Para.trade_field] = x_oBusinessTrade.GetTrade_field(); }
                if (x_oTableSet.Fields(BusinessTrade.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTrade.Para.did] = x_oBusinessTrade.GetDid(); }
                if (x_oTableSet.Fields(BusinessTrade.Para.premium_1).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTrade.Para.premium_1] = x_oBusinessTrade.GetPremium_1(); }
                if (x_oTableSet.Fields(BusinessTrade.Para.sdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTrade.Para.sdate] = x_oBusinessTrade.GetSdate(); }
                if (x_oTableSet.Fields(BusinessTrade.Para.rebate).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTrade.Para.rebate] = x_oBusinessTrade.GetRebate(); }
                if (x_oTableSet.Fields(BusinessTrade.Para.premium_2).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTrade.Para.premium_2] = x_oBusinessTrade.GetPremium_2(); }
                if (x_oTableSet.Fields(BusinessTrade.Para.retention_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTrade.Para.retention_type] = x_oBusinessTrade.GetRetention_type(); }
                if (x_oTableSet.Fields(BusinessTrade.Para.extra_offer).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTrade.Para.extra_offer] = x_oBusinessTrade.GetExtra_offer(); }
                if (x_oTableSet.Fields(BusinessTrade.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTrade.Para.edate] = x_oBusinessTrade.GetEdate(); }
                if (x_oTableSet.Fields(BusinessTrade.Para.program).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTrade.Para.program] = x_oBusinessTrade.GetProgram(); }
                if (x_oTableSet.Fields(BusinessTrade.Para.con_per).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTrade.Para.con_per] = x_oBusinessTrade.GetCon_per(); }
                if (x_oTableSet.Fields(BusinessTrade.Para.rate_plan).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTrade.Para.rate_plan] = x_oBusinessTrade.GetRate_plan(); }
                if (x_oTableSet.Fields(BusinessTrade.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTrade.Para.ddate] = x_oBusinessTrade.GetDdate(); }
                if (x_oTableSet.Fields(BusinessTrade.Para.normal_rebate_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTrade.Para.normal_rebate_type] = x_oBusinessTrade.GetNormal_rebate_type(); }
                if (x_oTableSet.Fields(BusinessTrade.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTrade.Para.active] = x_oBusinessTrade.GetActive(); }
                if (x_oTableSet.Fields(BusinessTrade.Para.free_mon).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTrade.Para.free_mon] = x_oBusinessTrade.GetFree_mon(); }
                if (x_oTableSet.Fields(BusinessTrade.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTrade.Para.cid] = x_oBusinessTrade.GetCid(); }
                if (x_oTableSet.Fields(BusinessTrade.Para.cancel_renew).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTrade.Para.cancel_renew] = x_oBusinessTrade.GetCancel_renew(); }
                if (x_oTableSet.Fields(BusinessTrade.Para.ob_early).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTrade.Para.ob_early] = x_oBusinessTrade.GetOb_early(); }
                if (x_oTableSet.Fields(BusinessTrade.Para.normal_rebate).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTrade.Para.normal_rebate] = x_oBusinessTrade.GetNormal_rebate(); }
                if (x_oTableSet.Fields(BusinessTrade.Para.hs_model).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTrade.Para.hs_model] = x_oBusinessTrade.GetHs_model(); }
                if (x_oTableSet.Fields(BusinessTrade.Para.plan_fee).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTrade.Para.plan_fee] = x_oBusinessTrade.GetPlan_fee(); }
                if (x_oTableSet.Fields(BusinessTrade.Para.po_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTrade.Para.po_date] = x_oBusinessTrade.GetPo_date(); }
                if (x_oTableSet.Fields(BusinessTrade.Para.remarks).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTrade.Para.remarks] = x_oBusinessTrade.GetRemarks(); }
                if (x_oTableSet.Fields(BusinessTrade.Para.issue_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTrade.Para.issue_type] = x_oBusinessTrade.GetIssue_type(); }
                _oDSet.Tables[BusinessTrade.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(BusinessTradeInfo x_oTableSet)
        {
            return BusinessTradeBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return BusinessTradeBal.ToEmptyDataSetProcess(BusinessTradeInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(BusinessTradeInfo x_oTableSet)
        {
            return BusinessTradeBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(BusinessTrade x_oBusinessTrade, BusinessTradeInfo x_oTableSet)
        {
            return BusinessTradeBal.GetDataSet(null, null, x_oTableSet).Tables[BusinessTrade.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(BusinessTrade x_oBusinessTrade)
        {
            return BusinessTradeBal.GetDataSet(x_oBusinessTrade, null, BusinessTradeInfoDLL.CreateInfoInstanceObject()).Tables[BusinessTrade.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            return Row(x_oTable, x_oDB,x_iMid,BusinessTradeInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid, BusinessTradeInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iMid, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid,BusinessTradeInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = BusinessTradeInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [BusinessTrade].[mid] AS BUSINESSTRADE_MID,[BusinessTrade].[channel] AS BUSINESSTRADE_CHANNEL,[BusinessTrade].[cdate] AS BUSINESSTRADE_CDATE,[BusinessTrade].[bundle_name] AS BUSINESSTRADE_BUNDLE_NAME,[BusinessTrade].[hs_model_name] AS BUSINESSTRADE_HS_MODEL_NAME,[BusinessTrade].[trade_field] AS BUSINESSTRADE_TRADE_FIELD,[BusinessTrade].[did] AS BUSINESSTRADE_DID,[BusinessTrade].[premium_1] AS BUSINESSTRADE_PREMIUM_1,[BusinessTrade].[sdate] AS BUSINESSTRADE_SDATE,[BusinessTrade].[rebate] AS BUSINESSTRADE_REBATE,[BusinessTrade].[premium_2] AS BUSINESSTRADE_PREMIUM_2,[BusinessTrade].[po_date] AS BUSINESSTRADE_PO_DATE,[BusinessTrade].[retention_type] AS BUSINESSTRADE_RETENTION_TYPE,[BusinessTrade].[extra_offer] AS BUSINESSTRADE_EXTRA_OFFER,[BusinessTrade].[edate] AS BUSINESSTRADE_EDATE,[BusinessTrade].[program] AS BUSINESSTRADE_PROGRAM,[BusinessTrade].[ob_early] AS BUSINESSTRADE_OB_EARLY,[BusinessTrade].[con_per] AS BUSINESSTRADE_CON_PER,[BusinessTrade].[ddate] AS BUSINESSTRADE_DDATE,[BusinessTrade].[normal_rebate_type] AS BUSINESSTRADE_NORMAL_REBATE_TYPE,[BusinessTrade].[active] AS BUSINESSTRADE_ACTIVE,[BusinessTrade].[free_mon] AS BUSINESSTRADE_FREE_MON,[BusinessTrade].[cid] AS BUSINESSTRADE_CID,[BusinessTrade].[cancel_renew] AS BUSINESSTRADE_CANCEL_RENEW,[BusinessTrade].[rate_plan] AS BUSINESSTRADE_RATE_PLAN,[BusinessTrade].[normal_rebate] AS BUSINESSTRADE_NORMAL_REBATE,[BusinessTrade].[hs_model] AS BUSINESSTRADE_HS_MODEL,[BusinessTrade].[plan_fee] AS BUSINESSTRADE_PLAN_FEE,[BusinessTrade].[remarks] AS BUSINESSTRADE_REMARKS,[BusinessTrade].[issue_type] AS BUSINESSTRADE_ISSUE_TYPE  FROM  [BusinessTrade]  WHERE  [BusinessTrade].[mid] = \'"+x_iMid.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessTrade]","["+ Configurator.MSSQLTablePrefix + "BusinessTrade]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(BusinessTrade.Para.mid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_MID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTrade.Para.mid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.mid).AliasName].ToString()] = (global::System.Nullable<int>)_oData["BUSINESSTRADE_MID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.mid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTrade.Para.channel).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_CHANNEL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTrade.Para.channel).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.channel).AliasName].ToString()] = (string)_oData["BUSINESSTRADE_CHANNEL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.channel).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTrade.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTrade.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["BUSINESSTRADE_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTrade.Para.bundle_name).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_BUNDLE_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTrade.Para.bundle_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.bundle_name).AliasName].ToString()] = (string)_oData["BUSINESSTRADE_BUNDLE_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.bundle_name).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTrade.Para.hs_model_name).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_HS_MODEL_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTrade.Para.hs_model_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.hs_model_name).AliasName].ToString()] = (string)_oData["BUSINESSTRADE_HS_MODEL_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.hs_model_name).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTrade.Para.trade_field).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_TRADE_FIELD"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTrade.Para.trade_field).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.trade_field).AliasName].ToString()] = (string)_oData["BUSINESSTRADE_TRADE_FIELD"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.trade_field).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTrade.Para.did).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTrade.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.did).AliasName].ToString()] = (string)_oData["BUSINESSTRADE_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.did).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTrade.Para.premium_1).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_PREMIUM_1"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTrade.Para.premium_1).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.premium_1).AliasName].ToString()] = (string)_oData["BUSINESSTRADE_PREMIUM_1"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.premium_1).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTrade.Para.sdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_SDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTrade.Para.sdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.sdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["BUSINESSTRADE_SDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.sdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTrade.Para.rebate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_REBATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTrade.Para.rebate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.rebate).AliasName].ToString()] = (string)_oData["BUSINESSTRADE_REBATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.rebate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTrade.Para.premium_2).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_PREMIUM_2"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTrade.Para.premium_2).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.premium_2).AliasName].ToString()] = (string)_oData["BUSINESSTRADE_PREMIUM_2"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.premium_2).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTrade.Para.po_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_PO_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTrade.Para.po_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.po_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["BUSINESSTRADE_PO_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.po_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTrade.Para.retention_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_RETENTION_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTrade.Para.retention_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.retention_type).AliasName].ToString()] = (string)_oData["BUSINESSTRADE_RETENTION_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.retention_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTrade.Para.extra_offer).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_EXTRA_OFFER"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTrade.Para.extra_offer).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.extra_offer).AliasName].ToString()] = (string)_oData["BUSINESSTRADE_EXTRA_OFFER"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.extra_offer).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTrade.Para.edate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_EDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTrade.Para.edate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.edate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["BUSINESSTRADE_EDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.edate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTrade.Para.program).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_PROGRAM"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTrade.Para.program).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.program).AliasName].ToString()] = (string)_oData["BUSINESSTRADE_PROGRAM"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.program).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTrade.Para.ob_early).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_OB_EARLY"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTrade.Para.ob_early).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.ob_early).AliasName].ToString()] = (string)_oData["BUSINESSTRADE_OB_EARLY"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.ob_early).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTrade.Para.con_per).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_CON_PER"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTrade.Para.con_per).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.con_per).AliasName].ToString()] = (string)_oData["BUSINESSTRADE_CON_PER"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.con_per).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTrade.Para.ddate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTrade.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["BUSINESSTRADE_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.ddate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTrade.Para.normal_rebate_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_NORMAL_REBATE_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTrade.Para.normal_rebate_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.normal_rebate_type).AliasName].ToString()] = (string)_oData["BUSINESSTRADE_NORMAL_REBATE_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.normal_rebate_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTrade.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTrade.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["BUSINESSTRADE_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTrade.Para.free_mon).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_FREE_MON"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTrade.Para.free_mon).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.free_mon).AliasName].ToString()] = (string)_oData["BUSINESSTRADE_FREE_MON"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.free_mon).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTrade.Para.cid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTrade.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.cid).AliasName].ToString()] = (string)_oData["BUSINESSTRADE_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.cid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTrade.Para.cancel_renew).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_CANCEL_RENEW"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTrade.Para.cancel_renew).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.cancel_renew).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["BUSINESSTRADE_CANCEL_RENEW"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.cancel_renew).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTrade.Para.rate_plan).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_RATE_PLAN"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTrade.Para.rate_plan).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.rate_plan).AliasName].ToString()] = (string)_oData["BUSINESSTRADE_RATE_PLAN"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.rate_plan).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTrade.Para.normal_rebate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_NORMAL_REBATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTrade.Para.normal_rebate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.normal_rebate).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["BUSINESSTRADE_NORMAL_REBATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.normal_rebate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTrade.Para.hs_model).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_HS_MODEL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTrade.Para.hs_model).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.hs_model).AliasName].ToString()] = (string)_oData["BUSINESSTRADE_HS_MODEL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.hs_model).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTrade.Para.plan_fee).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_PLAN_FEE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTrade.Para.plan_fee).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.plan_fee).AliasName].ToString()] = (string)_oData["BUSINESSTRADE_PLAN_FEE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.plan_fee).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTrade.Para.remarks).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_REMARKS"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTrade.Para.remarks).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.remarks).AliasName].ToString()] = (string)_oData["BUSINESSTRADE_REMARKS"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.remarks).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTrade.Para.issue_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADE_ISSUE_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTrade.Para.issue_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.issue_type).AliasName].ToString()] = (string)_oData["BUSINESSTRADE_ISSUE_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTrade.Para.issue_type).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,BusinessTrade x_oBusinessTradeRow)
        {
            return SetByDataSetRowProc(x_iROW, BusinessTrade.Para.TableName(), x_oDataSet,x_oBusinessTradeRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,BusinessTrade x_oBusinessTradeRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oBusinessTradeRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,BusinessTrade x_oBusinessTradeRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                BusinessTradeInfo _oTableSet=BusinessTradeInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTrade.Para.mid).AliasName))
                    x_oBusinessTradeRow.mid = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTrade.Para.mid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTrade.Para.channel).AliasName))
                    x_oBusinessTradeRow.channel = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTrade.Para.channel).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTrade.Para.cdate).AliasName))
                    x_oBusinessTradeRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTrade.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTrade.Para.bundle_name).AliasName))
                    x_oBusinessTradeRow.bundle_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTrade.Para.bundle_name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTrade.Para.hs_model_name).AliasName))
                    x_oBusinessTradeRow.hs_model_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTrade.Para.hs_model_name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTrade.Para.trade_field).AliasName))
                    x_oBusinessTradeRow.trade_field = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTrade.Para.trade_field).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTrade.Para.did).AliasName))
                    x_oBusinessTradeRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTrade.Para.did).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTrade.Para.premium_1).AliasName))
                    x_oBusinessTradeRow.premium_1 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTrade.Para.premium_1).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTrade.Para.sdate).AliasName))
                    x_oBusinessTradeRow.sdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTrade.Para.sdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTrade.Para.rebate).AliasName))
                    x_oBusinessTradeRow.rebate = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTrade.Para.rebate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTrade.Para.premium_2).AliasName))
                    x_oBusinessTradeRow.premium_2 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTrade.Para.premium_2).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTrade.Para.retention_type).AliasName))
                    x_oBusinessTradeRow.retention_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTrade.Para.retention_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTrade.Para.extra_offer).AliasName))
                    x_oBusinessTradeRow.extra_offer = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTrade.Para.extra_offer).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTrade.Para.edate).AliasName))
                    x_oBusinessTradeRow.edate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTrade.Para.edate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTrade.Para.program).AliasName))
                    x_oBusinessTradeRow.program = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTrade.Para.program).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTrade.Para.con_per).AliasName))
                    x_oBusinessTradeRow.con_per = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTrade.Para.con_per).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTrade.Para.rate_plan).AliasName))
                    x_oBusinessTradeRow.rate_plan = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTrade.Para.rate_plan).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTrade.Para.ddate).AliasName))
                    x_oBusinessTradeRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTrade.Para.ddate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTrade.Para.normal_rebate_type).AliasName))
                    x_oBusinessTradeRow.normal_rebate_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTrade.Para.normal_rebate_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTrade.Para.active).AliasName))
                    x_oBusinessTradeRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTrade.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTrade.Para.free_mon).AliasName))
                    x_oBusinessTradeRow.free_mon = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTrade.Para.free_mon).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTrade.Para.cid).AliasName))
                    x_oBusinessTradeRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTrade.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTrade.Para.cancel_renew).AliasName))
                    x_oBusinessTradeRow.cancel_renew = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTrade.Para.cancel_renew).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTrade.Para.ob_early).AliasName))
                    x_oBusinessTradeRow.ob_early = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTrade.Para.ob_early).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTrade.Para.normal_rebate).AliasName))
                    x_oBusinessTradeRow.normal_rebate = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTrade.Para.normal_rebate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTrade.Para.hs_model).AliasName))
                    x_oBusinessTradeRow.hs_model = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTrade.Para.hs_model).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTrade.Para.plan_fee).AliasName))
                    x_oBusinessTradeRow.plan_fee = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTrade.Para.plan_fee).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTrade.Para.po_date).AliasName))
                    x_oBusinessTradeRow.po_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTrade.Para.po_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTrade.Para.remarks).AliasName))
                    x_oBusinessTradeRow.remarks = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTrade.Para.remarks).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTrade.Para.issue_type).AliasName))
                    x_oBusinessTradeRow.issue_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTrade.Para.issue_type).AliasName];
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
            return BusinessTradeRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static BusinessTradeEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return BusinessTradeRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static BusinessTradeEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return BusinessTradeRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return BusinessTradeRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return BusinessTradeRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return BusinessTradeRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sChannel,global::System.Nullable<DateTime> x_dCdate,string x_sBundle_name,string x_sHs_model_name,string x_sTrade_field,string x_sDid,string x_sPremium_1,global::System.Nullable<DateTime> x_dSdate,string x_sRebate,string x_sPremium_2,string x_sRetention_type,string x_sExtra_offer,global::System.Nullable<DateTime> x_dEdate,string x_sProgram,string x_sCon_per,string x_sRate_plan,global::System.Nullable<DateTime> x_dDdate,string x_sNormal_rebate_type,global::System.Nullable<bool> x_bActive,string x_sFree_mon,string x_sCid,global::System.Nullable<bool> x_bCancel_renew,string x_sOb_early,global::System.Nullable<bool> x_bNormal_rebate,string x_sHs_model,string x_sPlan_fee,global::System.Nullable<DateTime> x_dPo_date,string x_sRemarks,string x_sIssue_type)
        {
            return BusinessTradeRepository.Insert(x_oDB, x_sChannel,x_dCdate,x_sBundle_name,x_sHs_model_name,x_sTrade_field,x_sDid,x_sPremium_1,x_dSdate,x_sRebate,x_sPremium_2,x_sRetention_type,x_sExtra_offer,x_dEdate,x_sProgram,x_sCon_per,x_sRate_plan,x_dDdate,x_sNormal_rebate_type,x_bActive,x_sFree_mon,x_sCid,x_bCancel_renew,x_sOb_early,x_bNormal_rebate,x_sHs_model,x_sPlan_fee,x_dPo_date,x_sRemarks,x_sIssue_type);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,BusinessTrade x_oBusinessTrade)
        {
            return BusinessTradeRepository.InsertWithOutLastID(x_oDB,x_oBusinessTrade);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sChannel,global::System.Nullable<DateTime> x_dCdate,string x_sBundle_name,string x_sHs_model_name,string x_sTrade_field,string x_sDid,string x_sPremium_1,global::System.Nullable<DateTime> x_dSdate,string x_sRebate,string x_sPremium_2,string x_sRetention_type,string x_sExtra_offer,global::System.Nullable<DateTime> x_dEdate,string x_sProgram,string x_sCon_per,string x_sRate_plan,global::System.Nullable<DateTime> x_dDdate,string x_sNormal_rebate_type,global::System.Nullable<bool> x_bActive,string x_sFree_mon,string x_sCid,global::System.Nullable<bool> x_bCancel_renew,string x_sOb_early,global::System.Nullable<bool> x_bNormal_rebate,string x_sHs_model,string x_sPlan_fee,global::System.Nullable<DateTime> x_dPo_date,string x_sRemarks,string x_sIssue_type)
        {
            return BusinessTradeRepository.InsertReturnLastID_SP(x_oDB,x_sChannel,x_dCdate,x_sBundle_name,x_sHs_model_name,x_sTrade_field,x_sDid,x_sPremium_1,x_dSdate,x_sRebate,x_sPremium_2,x_sRetention_type,x_sExtra_offer,x_dEdate,x_sProgram,x_sCon_per,x_sRate_plan,x_dDdate,x_sNormal_rebate_type,x_bActive,x_sFree_mon,x_sCid,x_bCancel_renew,x_sOb_early,x_bNormal_rebate,x_sHs_model,x_sPlan_fee,x_dPo_date,x_sRemarks,x_sIssue_type);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, BusinessTrade x_oBusinessTrade)
        {
            return BusinessTradeRepository.InsertReturnLastID_SP(x_oDB,x_oBusinessTrade);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return BusinessTradeRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return BusinessTradeRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            return BusinessTradeRepository.Delete(x_oDB, x_iMid);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(BusinessTrade x_oBusinessTradeRow){
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


