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
///-- Description:	<Description,Table :[BusinessTradeExperience],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [BusinessTradeExperience] Business layer
    /// </summary>
    
    public abstract class BusinessTradeExperienceBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public BusinessTradeExperienceBalBase(){
        }
        ~BusinessTradeExperienceBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(BusinessTradeExperience x_oBusinessTradeExperience)
        {
            return GetDataSet(x_oBusinessTradeExperience,null,BusinessTradeExperienceInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(BusinessTradeExperience x_oBusinessTradeExperience,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oBusinessTradeExperience,x_oMergeDSet,BusinessTradeExperienceInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(BusinessTradeExperience x_oBusinessTradeExperience,BusinessTradeExperienceInfo x_oTableSet)
        {
            return GetDataSet(x_oBusinessTradeExperience,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(BusinessTradeExperience x_oBusinessTradeExperience,global::System.Data.DataSet x_oMergeDSet,BusinessTradeExperienceInfo x_oTableSet)
        {
            return GetDataSet(x_oBusinessTradeExperience,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(BusinessTradeExperience x_oBusinessTradeExperience,global::System.Data.DataSet x_oMergeDSet,BusinessTradeExperienceInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = BusinessTradeExperienceInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(BusinessTradeExperience.Para.TableName());
            if (x_oTableSet.Fields(BusinessTradeExperience.Para.rec_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTradeExperience.Para.TableName()].Columns.Add(BusinessTradeExperience.Para.rec_no); }
            if (x_oTableSet.Fields(BusinessTradeExperience.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTradeExperience.Para.TableName()].Columns.Add(BusinessTradeExperience.Para.mid); }
            if (x_oTableSet.Fields(BusinessTradeExperience.Para.channel).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTradeExperience.Para.TableName()].Columns.Add(BusinessTradeExperience.Para.channel); }
            if (x_oTableSet.Fields(BusinessTradeExperience.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTradeExperience.Para.TableName()].Columns.Add(BusinessTradeExperience.Para.cdate); }
            if (x_oTableSet.Fields(BusinessTradeExperience.Para.bundle_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTradeExperience.Para.TableName()].Columns.Add(BusinessTradeExperience.Para.bundle_name); }
            if (x_oTableSet.Fields(BusinessTradeExperience.Para.hs_model_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTradeExperience.Para.TableName()].Columns.Add(BusinessTradeExperience.Para.hs_model_name); }
            if (x_oTableSet.Fields(BusinessTradeExperience.Para.trade_field).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTradeExperience.Para.TableName()].Columns.Add(BusinessTradeExperience.Para.trade_field); }
            if (x_oTableSet.Fields(BusinessTradeExperience.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTradeExperience.Para.TableName()].Columns.Add(BusinessTradeExperience.Para.did); }
            if (x_oTableSet.Fields(BusinessTradeExperience.Para.premium_1).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTradeExperience.Para.TableName()].Columns.Add(BusinessTradeExperience.Para.premium_1); }
            if (x_oTableSet.Fields(BusinessTradeExperience.Para.sdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTradeExperience.Para.TableName()].Columns.Add(BusinessTradeExperience.Para.sdate); }
            if (x_oTableSet.Fields(BusinessTradeExperience.Para.rebate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTradeExperience.Para.TableName()].Columns.Add(BusinessTradeExperience.Para.rebate); }
            if (x_oTableSet.Fields(BusinessTradeExperience.Para.premium_2).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTradeExperience.Para.TableName()].Columns.Add(BusinessTradeExperience.Para.premium_2); }
            if (x_oTableSet.Fields(BusinessTradeExperience.Para.retention_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTradeExperience.Para.TableName()].Columns.Add(BusinessTradeExperience.Para.retention_type); }
            if (x_oTableSet.Fields(BusinessTradeExperience.Para.extra_offer).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTradeExperience.Para.TableName()].Columns.Add(BusinessTradeExperience.Para.extra_offer); }
            if (x_oTableSet.Fields(BusinessTradeExperience.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTradeExperience.Para.TableName()].Columns.Add(BusinessTradeExperience.Para.edate); }
            if (x_oTableSet.Fields(BusinessTradeExperience.Para.program).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTradeExperience.Para.TableName()].Columns.Add(BusinessTradeExperience.Para.program); }
            if (x_oTableSet.Fields(BusinessTradeExperience.Para.con_per).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTradeExperience.Para.TableName()].Columns.Add(BusinessTradeExperience.Para.con_per); }
            if (x_oTableSet.Fields(BusinessTradeExperience.Para.rate_plan).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTradeExperience.Para.TableName()].Columns.Add(BusinessTradeExperience.Para.rate_plan); }
            if (x_oTableSet.Fields(BusinessTradeExperience.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTradeExperience.Para.TableName()].Columns.Add(BusinessTradeExperience.Para.ddate); }
            if (x_oTableSet.Fields(BusinessTradeExperience.Para.normal_rebate_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTradeExperience.Para.TableName()].Columns.Add(BusinessTradeExperience.Para.normal_rebate_type); }
            if (x_oTableSet.Fields(BusinessTradeExperience.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTradeExperience.Para.TableName()].Columns.Add(BusinessTradeExperience.Para.active); }
            if (x_oTableSet.Fields(BusinessTradeExperience.Para.free_mon).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTradeExperience.Para.TableName()].Columns.Add(BusinessTradeExperience.Para.free_mon); }
            if (x_oTableSet.Fields(BusinessTradeExperience.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTradeExperience.Para.TableName()].Columns.Add(BusinessTradeExperience.Para.cid); }
            if (x_oTableSet.Fields(BusinessTradeExperience.Para.cancel_renew).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTradeExperience.Para.TableName()].Columns.Add(BusinessTradeExperience.Para.cancel_renew); }
            if (x_oTableSet.Fields(BusinessTradeExperience.Para.ob_early).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTradeExperience.Para.TableName()].Columns.Add(BusinessTradeExperience.Para.ob_early); }
            if (x_oTableSet.Fields(BusinessTradeExperience.Para.normal_rebate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTradeExperience.Para.TableName()].Columns.Add(BusinessTradeExperience.Para.normal_rebate); }
            if (x_oTableSet.Fields(BusinessTradeExperience.Para.hs_model).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTradeExperience.Para.TableName()].Columns.Add(BusinessTradeExperience.Para.hs_model); }
            if (x_oTableSet.Fields(BusinessTradeExperience.Para.plan_fee).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTradeExperience.Para.TableName()].Columns.Add(BusinessTradeExperience.Para.plan_fee); }
            if (x_oTableSet.Fields(BusinessTradeExperience.Para.po_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTradeExperience.Para.TableName()].Columns.Add(BusinessTradeExperience.Para.po_date); }
            if (x_oTableSet.Fields(BusinessTradeExperience.Para.remarks).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTradeExperience.Para.TableName()].Columns.Add(BusinessTradeExperience.Para.remarks); }
            if (x_oTableSet.Fields(BusinessTradeExperience.Para.issue_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessTradeExperience.Para.TableName()].Columns.Add(BusinessTradeExperience.Para.issue_type); }
            if (x_oBusinessTradeExperience != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[BusinessTradeExperience.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(BusinessTradeExperience.Para.rec_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTradeExperience.Para.rec_no] = x_oBusinessTradeExperience.GetRec_no(); }
                if (x_oTableSet.Fields(BusinessTradeExperience.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTradeExperience.Para.mid] = x_oBusinessTradeExperience.GetMid(); }
                if (x_oTableSet.Fields(BusinessTradeExperience.Para.channel).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTradeExperience.Para.channel] = x_oBusinessTradeExperience.GetChannel(); }
                if (x_oTableSet.Fields(BusinessTradeExperience.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTradeExperience.Para.cdate] = x_oBusinessTradeExperience.GetCdate(); }
                if (x_oTableSet.Fields(BusinessTradeExperience.Para.bundle_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTradeExperience.Para.bundle_name] = x_oBusinessTradeExperience.GetBundle_name(); }
                if (x_oTableSet.Fields(BusinessTradeExperience.Para.hs_model_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTradeExperience.Para.hs_model_name] = x_oBusinessTradeExperience.GetHs_model_name(); }
                if (x_oTableSet.Fields(BusinessTradeExperience.Para.trade_field).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTradeExperience.Para.trade_field] = x_oBusinessTradeExperience.GetTrade_field(); }
                if (x_oTableSet.Fields(BusinessTradeExperience.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTradeExperience.Para.did] = x_oBusinessTradeExperience.GetDid(); }
                if (x_oTableSet.Fields(BusinessTradeExperience.Para.premium_1).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTradeExperience.Para.premium_1] = x_oBusinessTradeExperience.GetPremium_1(); }
                if (x_oTableSet.Fields(BusinessTradeExperience.Para.sdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTradeExperience.Para.sdate] = x_oBusinessTradeExperience.GetSdate(); }
                if (x_oTableSet.Fields(BusinessTradeExperience.Para.rebate).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTradeExperience.Para.rebate] = x_oBusinessTradeExperience.GetRebate(); }
                if (x_oTableSet.Fields(BusinessTradeExperience.Para.premium_2).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTradeExperience.Para.premium_2] = x_oBusinessTradeExperience.GetPremium_2(); }
                if (x_oTableSet.Fields(BusinessTradeExperience.Para.retention_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTradeExperience.Para.retention_type] = x_oBusinessTradeExperience.GetRetention_type(); }
                if (x_oTableSet.Fields(BusinessTradeExperience.Para.extra_offer).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTradeExperience.Para.extra_offer] = x_oBusinessTradeExperience.GetExtra_offer(); }
                if (x_oTableSet.Fields(BusinessTradeExperience.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTradeExperience.Para.edate] = x_oBusinessTradeExperience.GetEdate(); }
                if (x_oTableSet.Fields(BusinessTradeExperience.Para.program).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTradeExperience.Para.program] = x_oBusinessTradeExperience.GetProgram(); }
                if (x_oTableSet.Fields(BusinessTradeExperience.Para.con_per).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTradeExperience.Para.con_per] = x_oBusinessTradeExperience.GetCon_per(); }
                if (x_oTableSet.Fields(BusinessTradeExperience.Para.rate_plan).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTradeExperience.Para.rate_plan] = x_oBusinessTradeExperience.GetRate_plan(); }
                if (x_oTableSet.Fields(BusinessTradeExperience.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTradeExperience.Para.ddate] = x_oBusinessTradeExperience.GetDdate(); }
                if (x_oTableSet.Fields(BusinessTradeExperience.Para.normal_rebate_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTradeExperience.Para.normal_rebate_type] = x_oBusinessTradeExperience.GetNormal_rebate_type(); }
                if (x_oTableSet.Fields(BusinessTradeExperience.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTradeExperience.Para.active] = x_oBusinessTradeExperience.GetActive(); }
                if (x_oTableSet.Fields(BusinessTradeExperience.Para.free_mon).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTradeExperience.Para.free_mon] = x_oBusinessTradeExperience.GetFree_mon(); }
                if (x_oTableSet.Fields(BusinessTradeExperience.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTradeExperience.Para.cid] = x_oBusinessTradeExperience.GetCid(); }
                if (x_oTableSet.Fields(BusinessTradeExperience.Para.cancel_renew).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTradeExperience.Para.cancel_renew] = x_oBusinessTradeExperience.GetCancel_renew(); }
                if (x_oTableSet.Fields(BusinessTradeExperience.Para.ob_early).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTradeExperience.Para.ob_early] = x_oBusinessTradeExperience.GetOb_early(); }
                if (x_oTableSet.Fields(BusinessTradeExperience.Para.normal_rebate).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTradeExperience.Para.normal_rebate] = x_oBusinessTradeExperience.GetNormal_rebate(); }
                if (x_oTableSet.Fields(BusinessTradeExperience.Para.hs_model).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTradeExperience.Para.hs_model] = x_oBusinessTradeExperience.GetHs_model(); }
                if (x_oTableSet.Fields(BusinessTradeExperience.Para.plan_fee).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTradeExperience.Para.plan_fee] = x_oBusinessTradeExperience.GetPlan_fee(); }
                if (x_oTableSet.Fields(BusinessTradeExperience.Para.po_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTradeExperience.Para.po_date] = x_oBusinessTradeExperience.GetPo_date(); }
                if (x_oTableSet.Fields(BusinessTradeExperience.Para.remarks).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTradeExperience.Para.remarks] = x_oBusinessTradeExperience.GetRemarks(); }
                if (x_oTableSet.Fields(BusinessTradeExperience.Para.issue_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessTradeExperience.Para.issue_type] = x_oBusinessTradeExperience.GetIssue_type(); }
                _oDSet.Tables[BusinessTradeExperience.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(BusinessTradeExperienceInfo x_oTableSet)
        {
            return BusinessTradeExperienceBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return BusinessTradeExperienceBal.ToEmptyDataSetProcess(BusinessTradeExperienceInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(BusinessTradeExperienceInfo x_oTableSet)
        {
            return BusinessTradeExperienceBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(BusinessTradeExperience x_oBusinessTradeExperience, BusinessTradeExperienceInfo x_oTableSet)
        {
            return BusinessTradeExperienceBal.GetDataSet(null, null, x_oTableSet).Tables[BusinessTradeExperience.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(BusinessTradeExperience x_oBusinessTradeExperience)
        {
            return BusinessTradeExperienceBal.GetDataSet(x_oBusinessTradeExperience, null, BusinessTradeExperienceInfoDLL.CreateInfoInstanceObject()).Tables[BusinessTradeExperience.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            return Row(x_oTable, x_oDB,x_iMid,BusinessTradeExperienceInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid, BusinessTradeExperienceInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iMid, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid,BusinessTradeExperienceInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = BusinessTradeExperienceInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [BusinessTradeExperience].[rec_no] AS BUSINESSTRADEEXPERIENCE_REC_NO,[BusinessTradeExperience].[mid] AS BUSINESSTRADEEXPERIENCE_MID,[BusinessTradeExperience].[channel] AS BUSINESSTRADEEXPERIENCE_CHANNEL,[BusinessTradeExperience].[cdate] AS BUSINESSTRADEEXPERIENCE_CDATE,[BusinessTradeExperience].[bundle_name] AS BUSINESSTRADEEXPERIENCE_BUNDLE_NAME,[BusinessTradeExperience].[hs_model_name] AS BUSINESSTRADEEXPERIENCE_HS_MODEL_NAME,[BusinessTradeExperience].[trade_field] AS BUSINESSTRADEEXPERIENCE_TRADE_FIELD,[BusinessTradeExperience].[did] AS BUSINESSTRADEEXPERIENCE_DID,[BusinessTradeExperience].[premium_1] AS BUSINESSTRADEEXPERIENCE_PREMIUM_1,[BusinessTradeExperience].[sdate] AS BUSINESSTRADEEXPERIENCE_SDATE,[BusinessTradeExperience].[rebate] AS BUSINESSTRADEEXPERIENCE_REBATE,[BusinessTradeExperience].[premium_2] AS BUSINESSTRADEEXPERIENCE_PREMIUM_2,[BusinessTradeExperience].[po_date] AS BUSINESSTRADEEXPERIENCE_PO_DATE,[BusinessTradeExperience].[retention_type] AS BUSINESSTRADEEXPERIENCE_RETENTION_TYPE,[BusinessTradeExperience].[extra_offer] AS BUSINESSTRADEEXPERIENCE_EXTRA_OFFER,[BusinessTradeExperience].[edate] AS BUSINESSTRADEEXPERIENCE_EDATE,[BusinessTradeExperience].[program] AS BUSINESSTRADEEXPERIENCE_PROGRAM,[BusinessTradeExperience].[ob_early] AS BUSINESSTRADEEXPERIENCE_OB_EARLY,[BusinessTradeExperience].[con_per] AS BUSINESSTRADEEXPERIENCE_CON_PER,[BusinessTradeExperience].[ddate] AS BUSINESSTRADEEXPERIENCE_DDATE,[BusinessTradeExperience].[normal_rebate_type] AS BUSINESSTRADEEXPERIENCE_NORMAL_REBATE_TYPE,[BusinessTradeExperience].[active] AS BUSINESSTRADEEXPERIENCE_ACTIVE,[BusinessTradeExperience].[free_mon] AS BUSINESSTRADEEXPERIENCE_FREE_MON,[BusinessTradeExperience].[cid] AS BUSINESSTRADEEXPERIENCE_CID,[BusinessTradeExperience].[cancel_renew] AS BUSINESSTRADEEXPERIENCE_CANCEL_RENEW,[BusinessTradeExperience].[rate_plan] AS BUSINESSTRADEEXPERIENCE_RATE_PLAN,[BusinessTradeExperience].[normal_rebate] AS BUSINESSTRADEEXPERIENCE_NORMAL_REBATE,[BusinessTradeExperience].[hs_model] AS BUSINESSTRADEEXPERIENCE_HS_MODEL,[BusinessTradeExperience].[plan_fee] AS BUSINESSTRADEEXPERIENCE_PLAN_FEE,[BusinessTradeExperience].[remarks] AS BUSINESSTRADEEXPERIENCE_REMARKS,[BusinessTradeExperience].[issue_type] AS BUSINESSTRADEEXPERIENCE_ISSUE_TYPE  FROM  [BusinessTradeExperience]  WHERE  [BusinessTradeExperience].[mid] = \'"+x_iMid.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessTradeExperience]","["+ Configurator.MSSQLTablePrefix + "BusinessTradeExperience]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(BusinessTradeExperience.Para.rec_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_REC_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTradeExperience.Para.rec_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.rec_no).AliasName].ToString()] = (global::System.Nullable<int>)_oData["BUSINESSTRADEEXPERIENCE_REC_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.rec_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTradeExperience.Para.mid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_MID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTradeExperience.Para.mid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.mid).AliasName].ToString()] = (global::System.Nullable<int>)_oData["BUSINESSTRADEEXPERIENCE_MID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.mid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTradeExperience.Para.channel).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_CHANNEL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTradeExperience.Para.channel).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.channel).AliasName].ToString()] = (string)_oData["BUSINESSTRADEEXPERIENCE_CHANNEL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.channel).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTradeExperience.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTradeExperience.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["BUSINESSTRADEEXPERIENCE_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTradeExperience.Para.bundle_name).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_BUNDLE_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTradeExperience.Para.bundle_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.bundle_name).AliasName].ToString()] = (string)_oData["BUSINESSTRADEEXPERIENCE_BUNDLE_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.bundle_name).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTradeExperience.Para.hs_model_name).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_HS_MODEL_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTradeExperience.Para.hs_model_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.hs_model_name).AliasName].ToString()] = (string)_oData["BUSINESSTRADEEXPERIENCE_HS_MODEL_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.hs_model_name).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTradeExperience.Para.trade_field).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_TRADE_FIELD"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTradeExperience.Para.trade_field).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.trade_field).AliasName].ToString()] = (string)_oData["BUSINESSTRADEEXPERIENCE_TRADE_FIELD"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.trade_field).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTradeExperience.Para.did).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTradeExperience.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.did).AliasName].ToString()] = (string)_oData["BUSINESSTRADEEXPERIENCE_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.did).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTradeExperience.Para.premium_1).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_PREMIUM_1"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTradeExperience.Para.premium_1).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.premium_1).AliasName].ToString()] = (string)_oData["BUSINESSTRADEEXPERIENCE_PREMIUM_1"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.premium_1).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTradeExperience.Para.sdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_SDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTradeExperience.Para.sdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.sdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["BUSINESSTRADEEXPERIENCE_SDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.sdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTradeExperience.Para.rebate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_REBATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTradeExperience.Para.rebate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.rebate).AliasName].ToString()] = (string)_oData["BUSINESSTRADEEXPERIENCE_REBATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.rebate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTradeExperience.Para.premium_2).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_PREMIUM_2"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTradeExperience.Para.premium_2).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.premium_2).AliasName].ToString()] = (string)_oData["BUSINESSTRADEEXPERIENCE_PREMIUM_2"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.premium_2).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTradeExperience.Para.po_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_PO_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTradeExperience.Para.po_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.po_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["BUSINESSTRADEEXPERIENCE_PO_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.po_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTradeExperience.Para.retention_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_RETENTION_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTradeExperience.Para.retention_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.retention_type).AliasName].ToString()] = (string)_oData["BUSINESSTRADEEXPERIENCE_RETENTION_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.retention_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTradeExperience.Para.extra_offer).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_EXTRA_OFFER"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTradeExperience.Para.extra_offer).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.extra_offer).AliasName].ToString()] = (string)_oData["BUSINESSTRADEEXPERIENCE_EXTRA_OFFER"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.extra_offer).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTradeExperience.Para.edate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_EDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTradeExperience.Para.edate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.edate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["BUSINESSTRADEEXPERIENCE_EDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.edate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTradeExperience.Para.program).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_PROGRAM"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTradeExperience.Para.program).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.program).AliasName].ToString()] = (string)_oData["BUSINESSTRADEEXPERIENCE_PROGRAM"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.program).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTradeExperience.Para.ob_early).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_OB_EARLY"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTradeExperience.Para.ob_early).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.ob_early).AliasName].ToString()] = (string)_oData["BUSINESSTRADEEXPERIENCE_OB_EARLY"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.ob_early).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTradeExperience.Para.con_per).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_CON_PER"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTradeExperience.Para.con_per).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.con_per).AliasName].ToString()] = (string)_oData["BUSINESSTRADEEXPERIENCE_CON_PER"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.con_per).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTradeExperience.Para.ddate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTradeExperience.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["BUSINESSTRADEEXPERIENCE_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.ddate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTradeExperience.Para.normal_rebate_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_NORMAL_REBATE_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTradeExperience.Para.normal_rebate_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.normal_rebate_type).AliasName].ToString()] = (string)_oData["BUSINESSTRADEEXPERIENCE_NORMAL_REBATE_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.normal_rebate_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTradeExperience.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTradeExperience.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["BUSINESSTRADEEXPERIENCE_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTradeExperience.Para.free_mon).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_FREE_MON"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTradeExperience.Para.free_mon).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.free_mon).AliasName].ToString()] = (string)_oData["BUSINESSTRADEEXPERIENCE_FREE_MON"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.free_mon).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTradeExperience.Para.cid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTradeExperience.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.cid).AliasName].ToString()] = (string)_oData["BUSINESSTRADEEXPERIENCE_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.cid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTradeExperience.Para.cancel_renew).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_CANCEL_RENEW"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTradeExperience.Para.cancel_renew).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.cancel_renew).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["BUSINESSTRADEEXPERIENCE_CANCEL_RENEW"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.cancel_renew).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTradeExperience.Para.rate_plan).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_RATE_PLAN"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTradeExperience.Para.rate_plan).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.rate_plan).AliasName].ToString()] = (string)_oData["BUSINESSTRADEEXPERIENCE_RATE_PLAN"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.rate_plan).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTradeExperience.Para.normal_rebate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_NORMAL_REBATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTradeExperience.Para.normal_rebate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.normal_rebate).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["BUSINESSTRADEEXPERIENCE_NORMAL_REBATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.normal_rebate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTradeExperience.Para.hs_model).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_HS_MODEL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTradeExperience.Para.hs_model).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.hs_model).AliasName].ToString()] = (string)_oData["BUSINESSTRADEEXPERIENCE_HS_MODEL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.hs_model).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTradeExperience.Para.plan_fee).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_PLAN_FEE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTradeExperience.Para.plan_fee).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.plan_fee).AliasName].ToString()] = (string)_oData["BUSINESSTRADEEXPERIENCE_PLAN_FEE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.plan_fee).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTradeExperience.Para.remarks).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_REMARKS"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTradeExperience.Para.remarks).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.remarks).AliasName].ToString()] = (string)_oData["BUSINESSTRADEEXPERIENCE_REMARKS"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.remarks).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessTradeExperience.Para.issue_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSTRADEEXPERIENCE_ISSUE_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessTradeExperience.Para.issue_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.issue_type).AliasName].ToString()] = (string)_oData["BUSINESSTRADEEXPERIENCE_ISSUE_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessTradeExperience.Para.issue_type).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,BusinessTradeExperience x_oBusinessTradeExperienceRow)
        {
            return SetByDataSetRowProc(x_iROW, BusinessTradeExperience.Para.TableName(), x_oDataSet,x_oBusinessTradeExperienceRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,BusinessTradeExperience x_oBusinessTradeExperienceRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oBusinessTradeExperienceRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,BusinessTradeExperience x_oBusinessTradeExperienceRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                BusinessTradeExperienceInfo _oTableSet=BusinessTradeExperienceInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTradeExperience.Para.rec_no).AliasName))
                    x_oBusinessTradeExperienceRow.rec_no = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTradeExperience.Para.rec_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTradeExperience.Para.mid).AliasName))
                    x_oBusinessTradeExperienceRow.mid = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTradeExperience.Para.mid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTradeExperience.Para.channel).AliasName))
                    x_oBusinessTradeExperienceRow.channel = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTradeExperience.Para.channel).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTradeExperience.Para.cdate).AliasName))
                    x_oBusinessTradeExperienceRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTradeExperience.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTradeExperience.Para.bundle_name).AliasName))
                    x_oBusinessTradeExperienceRow.bundle_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTradeExperience.Para.bundle_name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTradeExperience.Para.hs_model_name).AliasName))
                    x_oBusinessTradeExperienceRow.hs_model_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTradeExperience.Para.hs_model_name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTradeExperience.Para.trade_field).AliasName))
                    x_oBusinessTradeExperienceRow.trade_field = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTradeExperience.Para.trade_field).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTradeExperience.Para.did).AliasName))
                    x_oBusinessTradeExperienceRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTradeExperience.Para.did).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTradeExperience.Para.premium_1).AliasName))
                    x_oBusinessTradeExperienceRow.premium_1 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTradeExperience.Para.premium_1).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTradeExperience.Para.sdate).AliasName))
                    x_oBusinessTradeExperienceRow.sdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTradeExperience.Para.sdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTradeExperience.Para.rebate).AliasName))
                    x_oBusinessTradeExperienceRow.rebate = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTradeExperience.Para.rebate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTradeExperience.Para.premium_2).AliasName))
                    x_oBusinessTradeExperienceRow.premium_2 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTradeExperience.Para.premium_2).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTradeExperience.Para.retention_type).AliasName))
                    x_oBusinessTradeExperienceRow.retention_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTradeExperience.Para.retention_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTradeExperience.Para.extra_offer).AliasName))
                    x_oBusinessTradeExperienceRow.extra_offer = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTradeExperience.Para.extra_offer).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTradeExperience.Para.edate).AliasName))
                    x_oBusinessTradeExperienceRow.edate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTradeExperience.Para.edate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTradeExperience.Para.program).AliasName))
                    x_oBusinessTradeExperienceRow.program = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTradeExperience.Para.program).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTradeExperience.Para.con_per).AliasName))
                    x_oBusinessTradeExperienceRow.con_per = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTradeExperience.Para.con_per).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTradeExperience.Para.rate_plan).AliasName))
                    x_oBusinessTradeExperienceRow.rate_plan = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTradeExperience.Para.rate_plan).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTradeExperience.Para.ddate).AliasName))
                    x_oBusinessTradeExperienceRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTradeExperience.Para.ddate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTradeExperience.Para.normal_rebate_type).AliasName))
                    x_oBusinessTradeExperienceRow.normal_rebate_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTradeExperience.Para.normal_rebate_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTradeExperience.Para.active).AliasName))
                    x_oBusinessTradeExperienceRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTradeExperience.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTradeExperience.Para.free_mon).AliasName))
                    x_oBusinessTradeExperienceRow.free_mon = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTradeExperience.Para.free_mon).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTradeExperience.Para.cid).AliasName))
                    x_oBusinessTradeExperienceRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTradeExperience.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTradeExperience.Para.cancel_renew).AliasName))
                    x_oBusinessTradeExperienceRow.cancel_renew = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTradeExperience.Para.cancel_renew).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTradeExperience.Para.ob_early).AliasName))
                    x_oBusinessTradeExperienceRow.ob_early = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTradeExperience.Para.ob_early).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTradeExperience.Para.normal_rebate).AliasName))
                    x_oBusinessTradeExperienceRow.normal_rebate = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTradeExperience.Para.normal_rebate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTradeExperience.Para.hs_model).AliasName))
                    x_oBusinessTradeExperienceRow.hs_model = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTradeExperience.Para.hs_model).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTradeExperience.Para.plan_fee).AliasName))
                    x_oBusinessTradeExperienceRow.plan_fee = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTradeExperience.Para.plan_fee).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTradeExperience.Para.po_date).AliasName))
                    x_oBusinessTradeExperienceRow.po_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTradeExperience.Para.po_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTradeExperience.Para.remarks).AliasName))
                    x_oBusinessTradeExperienceRow.remarks = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTradeExperience.Para.remarks).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessTradeExperience.Para.issue_type).AliasName))
                    x_oBusinessTradeExperienceRow.issue_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessTradeExperience.Para.issue_type).AliasName];
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
            return BusinessTradeExperienceRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static BusinessTradeExperienceEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return BusinessTradeExperienceRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static BusinessTradeExperienceEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return BusinessTradeExperienceRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return BusinessTradeExperienceRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return BusinessTradeExperienceRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return BusinessTradeExperienceRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<int> x_iRec_no,string x_sChannel,global::System.Nullable<DateTime> x_dCdate,string x_sBundle_name,string x_sHs_model_name,string x_sTrade_field,string x_sDid,string x_sPremium_1,global::System.Nullable<DateTime> x_dSdate,string x_sRebate,string x_sPremium_2,string x_sRetention_type,string x_sExtra_offer,global::System.Nullable<DateTime> x_dEdate,string x_sProgram,string x_sCon_per,string x_sRate_plan,global::System.Nullable<DateTime> x_dDdate,string x_sNormal_rebate_type,global::System.Nullable<bool> x_bActive,string x_sFree_mon,string x_sCid,global::System.Nullable<bool> x_bCancel_renew,string x_sOb_early,global::System.Nullable<bool> x_bNormal_rebate,string x_sHs_model,string x_sPlan_fee,global::System.Nullable<DateTime> x_dPo_date,string x_sRemarks,string x_sIssue_type)
        {
            return BusinessTradeExperienceRepository.Insert(x_oDB, x_iRec_no,x_sChannel,x_dCdate,x_sBundle_name,x_sHs_model_name,x_sTrade_field,x_sDid,x_sPremium_1,x_dSdate,x_sRebate,x_sPremium_2,x_sRetention_type,x_sExtra_offer,x_dEdate,x_sProgram,x_sCon_per,x_sRate_plan,x_dDdate,x_sNormal_rebate_type,x_bActive,x_sFree_mon,x_sCid,x_bCancel_renew,x_sOb_early,x_bNormal_rebate,x_sHs_model,x_sPlan_fee,x_dPo_date,x_sRemarks,x_sIssue_type);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,BusinessTradeExperience x_oBusinessTradeExperience)
        {
            return BusinessTradeExperienceRepository.InsertWithOutLastID(x_oDB,x_oBusinessTradeExperience);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<int> x_iRec_no,string x_sChannel,global::System.Nullable<DateTime> x_dCdate,string x_sBundle_name,string x_sHs_model_name,string x_sTrade_field,string x_sDid,string x_sPremium_1,global::System.Nullable<DateTime> x_dSdate,string x_sRebate,string x_sPremium_2,string x_sRetention_type,string x_sExtra_offer,global::System.Nullable<DateTime> x_dEdate,string x_sProgram,string x_sCon_per,string x_sRate_plan,global::System.Nullable<DateTime> x_dDdate,string x_sNormal_rebate_type,global::System.Nullable<bool> x_bActive,string x_sFree_mon,string x_sCid,global::System.Nullable<bool> x_bCancel_renew,string x_sOb_early,global::System.Nullable<bool> x_bNormal_rebate,string x_sHs_model,string x_sPlan_fee,global::System.Nullable<DateTime> x_dPo_date,string x_sRemarks,string x_sIssue_type)
        {
            return BusinessTradeExperienceRepository.InsertReturnLastID_SP(x_oDB,x_iRec_no,x_sChannel,x_dCdate,x_sBundle_name,x_sHs_model_name,x_sTrade_field,x_sDid,x_sPremium_1,x_dSdate,x_sRebate,x_sPremium_2,x_sRetention_type,x_sExtra_offer,x_dEdate,x_sProgram,x_sCon_per,x_sRate_plan,x_dDdate,x_sNormal_rebate_type,x_bActive,x_sFree_mon,x_sCid,x_bCancel_renew,x_sOb_early,x_bNormal_rebate,x_sHs_model,x_sPlan_fee,x_dPo_date,x_sRemarks,x_sIssue_type);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, BusinessTradeExperience x_oBusinessTradeExperience)
        {
            return BusinessTradeExperienceRepository.InsertReturnLastID_SP(x_oDB,x_oBusinessTradeExperience);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return BusinessTradeExperienceRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return BusinessTradeExperienceRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            return BusinessTradeExperienceRepository.Delete(x_oDB, x_iMid);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(BusinessTradeExperience x_oBusinessTradeExperienceRow){
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


