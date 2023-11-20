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
///-- Create date: <Create Date 2011-07-13>
///-- Description:	<Description,Table :[HandSetOfferBasketHistory],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [HandSetOfferBasketHistory] Business layer
    /// </summary>
    
    public abstract class HandSetOfferBasketHistoryBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public HandSetOfferBasketHistoryBalBase(){
        }
        ~HandSetOfferBasketHistoryBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(HandSetOfferBasketHistory x_oHandSetOfferBasketHistory)
        {
            return GetDataSet(x_oHandSetOfferBasketHistory,null,HandSetOfferBasketHistoryInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(HandSetOfferBasketHistory x_oHandSetOfferBasketHistory,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oHandSetOfferBasketHistory,x_oMergeDSet,HandSetOfferBasketHistoryInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(HandSetOfferBasketHistory x_oHandSetOfferBasketHistory,HandSetOfferBasketHistoryInfo x_oTableSet)
        {
            return GetDataSet(x_oHandSetOfferBasketHistory,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(HandSetOfferBasketHistory x_oHandSetOfferBasketHistory,global::System.Data.DataSet x_oMergeDSet,HandSetOfferBasketHistoryInfo x_oTableSet)
        {
            return GetDataSet(x_oHandSetOfferBasketHistory,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(HandSetOfferBasketHistory x_oHandSetOfferBasketHistory,global::System.Data.DataSet x_oMergeDSet,HandSetOfferBasketHistoryInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = HandSetOfferBasketHistoryInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(HandSetOfferBasketHistory.Para.TableName());
            if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.rec_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferBasketHistory.Para.TableName()].Columns.Add(HandSetOfferBasketHistory.Para.rec_no); }
            if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferBasketHistory.Para.TableName()].Columns.Add(HandSetOfferBasketHistory.Para.mid); }
            if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.r_offer).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferBasketHistory.Para.TableName()].Columns.Add(HandSetOfferBasketHistory.Para.r_offer); }
            if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.extra_rebate_amount).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferBasketHistory.Para.TableName()].Columns.Add(HandSetOfferBasketHistory.Para.extra_rebate_amount); }
            if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferBasketHistory.Para.TableName()].Columns.Add(HandSetOfferBasketHistory.Para.cdate); }
            if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.amount).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferBasketHistory.Para.TableName()].Columns.Add(HandSetOfferBasketHistory.Para.amount); }
            if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferBasketHistory.Para.TableName()].Columns.Add(HandSetOfferBasketHistory.Para.cid); }
            if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferBasketHistory.Para.TableName()].Columns.Add(HandSetOfferBasketHistory.Para.did); }
            if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.sdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferBasketHistory.Para.TableName()].Columns.Add(HandSetOfferBasketHistory.Para.sdate); }
            if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.payment).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferBasketHistory.Para.TableName()].Columns.Add(HandSetOfferBasketHistory.Para.payment); }
            if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.retention_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferBasketHistory.Para.TableName()].Columns.Add(HandSetOfferBasketHistory.Para.retention_type); }
            if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferBasketHistory.Para.TableName()].Columns.Add(HandSetOfferBasketHistory.Para.edate); }
            if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.con_per).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferBasketHistory.Para.TableName()].Columns.Add(HandSetOfferBasketHistory.Para.con_per); }
            if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferBasketHistory.Para.TableName()].Columns.Add(HandSetOfferBasketHistory.Para.ddate); }
            if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.normal_rebate_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferBasketHistory.Para.TableName()].Columns.Add(HandSetOfferBasketHistory.Para.normal_rebate_type); }
            if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.premium).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferBasketHistory.Para.TableName()].Columns.Add(HandSetOfferBasketHistory.Para.premium); }
            if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.extra_rebate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferBasketHistory.Para.TableName()].Columns.Add(HandSetOfferBasketHistory.Para.extra_rebate); }
            if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.rebate_gp).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferBasketHistory.Para.TableName()].Columns.Add(HandSetOfferBasketHistory.Para.rebate_gp); }
            if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.normal_rebate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferBasketHistory.Para.TableName()].Columns.Add(HandSetOfferBasketHistory.Para.normal_rebate); }
            if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.hs_model).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferBasketHistory.Para.TableName()].Columns.Add(HandSetOfferBasketHistory.Para.hs_model); }
            if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.offer_type_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferBasketHistory.Para.TableName()].Columns.Add(HandSetOfferBasketHistory.Para.offer_type_id); }
            if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferBasketHistory.Para.TableName()].Columns.Add(HandSetOfferBasketHistory.Para.active); }
            if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.rebate_amount).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferBasketHistory.Para.TableName()].Columns.Add(HandSetOfferBasketHistory.Para.rebate_amount); }
            if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.plan_fee).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferBasketHistory.Para.TableName()].Columns.Add(HandSetOfferBasketHistory.Para.plan_fee); }
            if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.item_code).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferBasketHistory.Para.TableName()].Columns.Add(HandSetOfferBasketHistory.Para.item_code); }
            if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.issue_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferBasketHistory.Para.TableName()].Columns.Add(HandSetOfferBasketHistory.Para.issue_type); }
            if (x_oHandSetOfferBasketHistory != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[HandSetOfferBasketHistory.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.rec_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferBasketHistory.Para.rec_no] = x_oHandSetOfferBasketHistory.GetRec_no(); }
                if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferBasketHistory.Para.mid] = x_oHandSetOfferBasketHistory.GetMid(); }
                if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.r_offer).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferBasketHistory.Para.r_offer] = x_oHandSetOfferBasketHistory.GetR_offer(); }
                if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.extra_rebate_amount).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferBasketHistory.Para.extra_rebate_amount] = x_oHandSetOfferBasketHistory.GetExtra_rebate_amount(); }
                if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferBasketHistory.Para.cdate] = x_oHandSetOfferBasketHistory.GetCdate(); }
                if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.amount).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferBasketHistory.Para.amount] = x_oHandSetOfferBasketHistory.GetAmount(); }
                if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferBasketHistory.Para.cid] = x_oHandSetOfferBasketHistory.GetCid(); }
                if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferBasketHistory.Para.did] = x_oHandSetOfferBasketHistory.GetDid(); }
                if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.sdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferBasketHistory.Para.sdate] = x_oHandSetOfferBasketHistory.GetSdate(); }
                if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.payment).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferBasketHistory.Para.payment] = x_oHandSetOfferBasketHistory.GetPayment(); }
                if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.retention_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferBasketHistory.Para.retention_type] = x_oHandSetOfferBasketHistory.GetRetention_type(); }
                if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferBasketHistory.Para.edate] = x_oHandSetOfferBasketHistory.GetEdate(); }
                if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.con_per).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferBasketHistory.Para.con_per] = x_oHandSetOfferBasketHistory.GetCon_per(); }
                if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferBasketHistory.Para.ddate] = x_oHandSetOfferBasketHistory.GetDdate(); }
                if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.normal_rebate_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferBasketHistory.Para.normal_rebate_type] = x_oHandSetOfferBasketHistory.GetNormal_rebate_type(); }
                if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.premium).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferBasketHistory.Para.premium] = x_oHandSetOfferBasketHistory.GetPremium(); }
                if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.extra_rebate).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferBasketHistory.Para.extra_rebate] = x_oHandSetOfferBasketHistory.GetExtra_rebate(); }
                if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.rebate_gp).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferBasketHistory.Para.rebate_gp] = x_oHandSetOfferBasketHistory.GetRebate_gp(); }
                if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.normal_rebate).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferBasketHistory.Para.normal_rebate] = x_oHandSetOfferBasketHistory.GetNormal_rebate(); }
                if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.hs_model).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferBasketHistory.Para.hs_model] = x_oHandSetOfferBasketHistory.GetHs_model(); }
                if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.offer_type_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferBasketHistory.Para.offer_type_id] = x_oHandSetOfferBasketHistory.GetOffer_type_id(); }
                if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferBasketHistory.Para.active] = x_oHandSetOfferBasketHistory.GetActive(); }
                if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.rebate_amount).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferBasketHistory.Para.rebate_amount] = x_oHandSetOfferBasketHistory.GetRebate_amount(); }
                if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.plan_fee).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferBasketHistory.Para.plan_fee] = x_oHandSetOfferBasketHistory.GetPlan_fee(); }
                if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.item_code).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferBasketHistory.Para.item_code] = x_oHandSetOfferBasketHistory.GetItem_code(); }
                if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.issue_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferBasketHistory.Para.issue_type] = x_oHandSetOfferBasketHistory.GetIssue_type(); }
                _oDSet.Tables[HandSetOfferBasketHistory.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(HandSetOfferBasketHistoryInfo x_oTableSet)
        {
            return HandSetOfferBasketHistoryBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return HandSetOfferBasketHistoryBal.ToEmptyDataSetProcess(HandSetOfferBasketHistoryInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(HandSetOfferBasketHistoryInfo x_oTableSet)
        {
            return HandSetOfferBasketHistoryBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(HandSetOfferBasketHistory x_oHandSetOfferBasketHistory, HandSetOfferBasketHistoryInfo x_oTableSet)
        {
            return HandSetOfferBasketHistoryBal.GetDataSet(null, null, x_oTableSet).Tables[HandSetOfferBasketHistory.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(HandSetOfferBasketHistory x_oHandSetOfferBasketHistory)
        {
            return HandSetOfferBasketHistoryBal.GetDataSet(x_oHandSetOfferBasketHistory, null, HandSetOfferBasketHistoryInfoDLL.CreateInfoInstanceObject()).Tables[HandSetOfferBasketHistory.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            return Row(x_oTable, x_oDB,x_iMid,HandSetOfferBasketHistoryInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid, HandSetOfferBasketHistoryInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iMid, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid,HandSetOfferBasketHistoryInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = HandSetOfferBasketHistoryInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [HandSetOfferBasketHistory].[rec_no] AS HANDSETOFFERBASKETHISTORY_REC_NO,[HandSetOfferBasketHistory].[mid] AS HANDSETOFFERBASKETHISTORY_MID,[HandSetOfferBasketHistory].[r_offer] AS HANDSETOFFERBASKETHISTORY_R_OFFER,[HandSetOfferBasketHistory].[extra_rebate_amount] AS HANDSETOFFERBASKETHISTORY_EXTRA_REBATE_AMOUNT,[HandSetOfferBasketHistory].[cdate] AS HANDSETOFFERBASKETHISTORY_CDATE,[HandSetOfferBasketHistory].[amount] AS HANDSETOFFERBASKETHISTORY_AMOUNT,[HandSetOfferBasketHistory].[cid] AS HANDSETOFFERBASKETHISTORY_CID,[HandSetOfferBasketHistory].[did] AS HANDSETOFFERBASKETHISTORY_DID,[HandSetOfferBasketHistory].[sdate] AS HANDSETOFFERBASKETHISTORY_SDATE,[HandSetOfferBasketHistory].[payment] AS HANDSETOFFERBASKETHISTORY_PAYMENT,[HandSetOfferBasketHistory].[retention_type] AS HANDSETOFFERBASKETHISTORY_RETENTION_TYPE,[HandSetOfferBasketHistory].[edate] AS HANDSETOFFERBASKETHISTORY_EDATE,[HandSetOfferBasketHistory].[con_per] AS HANDSETOFFERBASKETHISTORY_CON_PER,[HandSetOfferBasketHistory].[ddate] AS HANDSETOFFERBASKETHISTORY_DDATE,[HandSetOfferBasketHistory].[normal_rebate_type] AS HANDSETOFFERBASKETHISTORY_NORMAL_REBATE_TYPE,[HandSetOfferBasketHistory].[premium] AS HANDSETOFFERBASKETHISTORY_PREMIUM,[HandSetOfferBasketHistory].[extra_rebate] AS HANDSETOFFERBASKETHISTORY_EXTRA_REBATE,[HandSetOfferBasketHistory].[rebate_gp] AS HANDSETOFFERBASKETHISTORY_REBATE_GP,[HandSetOfferBasketHistory].[normal_rebate] AS HANDSETOFFERBASKETHISTORY_NORMAL_REBATE,[HandSetOfferBasketHistory].[hs_model] AS HANDSETOFFERBASKETHISTORY_HS_MODEL,[HandSetOfferBasketHistory].[offer_type_id] AS HANDSETOFFERBASKETHISTORY_OFFER_TYPE_ID,[HandSetOfferBasketHistory].[active] AS HANDSETOFFERBASKETHISTORY_ACTIVE,[HandSetOfferBasketHistory].[rebate_amount] AS HANDSETOFFERBASKETHISTORY_REBATE_AMOUNT,[HandSetOfferBasketHistory].[plan_fee] AS HANDSETOFFERBASKETHISTORY_PLAN_FEE,[HandSetOfferBasketHistory].[item_code] AS HANDSETOFFERBASKETHISTORY_ITEM_CODE,[HandSetOfferBasketHistory].[issue_type] AS HANDSETOFFERBASKETHISTORY_ISSUE_TYPE  FROM  [HandSetOfferBasketHistory]  WHERE  [HandSetOfferBasketHistory].[mid] = \'"+x_iMid.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[HandSetOfferBasketHistory]","["+ Configurator.MSSQLTablePrefix + "HandSetOfferBasketHistory]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.rec_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_REC_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferBasketHistory.Para.rec_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.rec_no).AliasName].ToString()] = (global::System.Nullable<int>)_oData["HANDSETOFFERBASKETHISTORY_REC_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.rec_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.mid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_MID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferBasketHistory.Para.mid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.mid).AliasName].ToString()] = (global::System.Nullable<int>)_oData["HANDSETOFFERBASKETHISTORY_MID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.mid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.r_offer).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_R_OFFER"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferBasketHistory.Para.r_offer).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.r_offer).AliasName].ToString()] = (string)_oData["HANDSETOFFERBASKETHISTORY_R_OFFER"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.r_offer).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.extra_rebate_amount).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_EXTRA_REBATE_AMOUNT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferBasketHistory.Para.extra_rebate_amount).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.extra_rebate_amount).AliasName].ToString()] = (string)_oData["HANDSETOFFERBASKETHISTORY_EXTRA_REBATE_AMOUNT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.extra_rebate_amount).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferBasketHistory.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["HANDSETOFFERBASKETHISTORY_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.amount).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_AMOUNT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferBasketHistory.Para.amount).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.amount).AliasName].ToString()] = (string)_oData["HANDSETOFFERBASKETHISTORY_AMOUNT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.amount).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.cid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferBasketHistory.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.cid).AliasName].ToString()] = (string)_oData["HANDSETOFFERBASKETHISTORY_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.cid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.did).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferBasketHistory.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.did).AliasName].ToString()] = (string)_oData["HANDSETOFFERBASKETHISTORY_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.did).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.sdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_SDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferBasketHistory.Para.sdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.sdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["HANDSETOFFERBASKETHISTORY_SDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.sdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.payment).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_PAYMENT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferBasketHistory.Para.payment).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.payment).AliasName].ToString()] = (string)_oData["HANDSETOFFERBASKETHISTORY_PAYMENT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.payment).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.retention_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_RETENTION_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferBasketHistory.Para.retention_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.retention_type).AliasName].ToString()] = (string)_oData["HANDSETOFFERBASKETHISTORY_RETENTION_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.retention_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.edate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_EDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferBasketHistory.Para.edate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.edate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["HANDSETOFFERBASKETHISTORY_EDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.edate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.con_per).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_CON_PER"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferBasketHistory.Para.con_per).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.con_per).AliasName].ToString()] = (string)_oData["HANDSETOFFERBASKETHISTORY_CON_PER"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.con_per).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.ddate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferBasketHistory.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["HANDSETOFFERBASKETHISTORY_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.ddate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.normal_rebate_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_NORMAL_REBATE_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferBasketHistory.Para.normal_rebate_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.normal_rebate_type).AliasName].ToString()] = (string)_oData["HANDSETOFFERBASKETHISTORY_NORMAL_REBATE_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.normal_rebate_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.premium).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_PREMIUM"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferBasketHistory.Para.premium).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.premium).AliasName].ToString()] = (string)_oData["HANDSETOFFERBASKETHISTORY_PREMIUM"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.premium).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.extra_rebate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_EXTRA_REBATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferBasketHistory.Para.extra_rebate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.extra_rebate).AliasName].ToString()] = (string)_oData["HANDSETOFFERBASKETHISTORY_EXTRA_REBATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.extra_rebate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.rebate_gp).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_REBATE_GP"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferBasketHistory.Para.rebate_gp).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.rebate_gp).AliasName].ToString()] = (string)_oData["HANDSETOFFERBASKETHISTORY_REBATE_GP"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.rebate_gp).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.normal_rebate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_NORMAL_REBATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferBasketHistory.Para.normal_rebate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.normal_rebate).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["HANDSETOFFERBASKETHISTORY_NORMAL_REBATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.normal_rebate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.hs_model).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_HS_MODEL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferBasketHistory.Para.hs_model).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.hs_model).AliasName].ToString()] = (string)_oData["HANDSETOFFERBASKETHISTORY_HS_MODEL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.hs_model).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.offer_type_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_OFFER_TYPE_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferBasketHistory.Para.offer_type_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.offer_type_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["HANDSETOFFERBASKETHISTORY_OFFER_TYPE_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.offer_type_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferBasketHistory.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["HANDSETOFFERBASKETHISTORY_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.rebate_amount).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_REBATE_AMOUNT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferBasketHistory.Para.rebate_amount).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.rebate_amount).AliasName].ToString()] = (string)_oData["HANDSETOFFERBASKETHISTORY_REBATE_AMOUNT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.rebate_amount).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.plan_fee).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_PLAN_FEE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferBasketHistory.Para.plan_fee).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.plan_fee).AliasName].ToString()] = (string)_oData["HANDSETOFFERBASKETHISTORY_PLAN_FEE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.plan_fee).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.item_code).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_ITEM_CODE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferBasketHistory.Para.item_code).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.item_code).AliasName].ToString()] = (string)_oData["HANDSETOFFERBASKETHISTORY_ITEM_CODE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.item_code).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferBasketHistory.Para.issue_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERBASKETHISTORY_ISSUE_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferBasketHistory.Para.issue_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.issue_type).AliasName].ToString()] = (string)_oData["HANDSETOFFERBASKETHISTORY_ISSUE_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferBasketHistory.Para.issue_type).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,HandSetOfferBasketHistory x_oHandSetOfferBasketHistoryRow)
        {
            return SetByDataSetRowProc(x_iROW, HandSetOfferBasketHistory.Para.TableName(), x_oDataSet,x_oHandSetOfferBasketHistoryRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,HandSetOfferBasketHistory x_oHandSetOfferBasketHistoryRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oHandSetOfferBasketHistoryRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,HandSetOfferBasketHistory x_oHandSetOfferBasketHistoryRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                HandSetOfferBasketHistoryInfo _oTableSet=HandSetOfferBasketHistoryInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferBasketHistory.Para.rec_no).AliasName))
                    x_oHandSetOfferBasketHistoryRow.rec_no = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferBasketHistory.Para.rec_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferBasketHistory.Para.mid).AliasName))
                    x_oHandSetOfferBasketHistoryRow.mid = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferBasketHistory.Para.mid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferBasketHistory.Para.r_offer).AliasName))
                    x_oHandSetOfferBasketHistoryRow.r_offer = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferBasketHistory.Para.r_offer).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferBasketHistory.Para.extra_rebate_amount).AliasName))
                    x_oHandSetOfferBasketHistoryRow.extra_rebate_amount = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferBasketHistory.Para.extra_rebate_amount).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferBasketHistory.Para.cdate).AliasName))
                    x_oHandSetOfferBasketHistoryRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferBasketHistory.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferBasketHistory.Para.amount).AliasName))
                    x_oHandSetOfferBasketHistoryRow.amount = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferBasketHistory.Para.amount).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferBasketHistory.Para.cid).AliasName))
                    x_oHandSetOfferBasketHistoryRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferBasketHistory.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferBasketHistory.Para.did).AliasName))
                    x_oHandSetOfferBasketHistoryRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferBasketHistory.Para.did).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferBasketHistory.Para.sdate).AliasName))
                    x_oHandSetOfferBasketHistoryRow.sdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferBasketHistory.Para.sdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferBasketHistory.Para.payment).AliasName))
                    x_oHandSetOfferBasketHistoryRow.payment = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferBasketHistory.Para.payment).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferBasketHistory.Para.retention_type).AliasName))
                    x_oHandSetOfferBasketHistoryRow.retention_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferBasketHistory.Para.retention_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferBasketHistory.Para.edate).AliasName))
                    x_oHandSetOfferBasketHistoryRow.edate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferBasketHistory.Para.edate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferBasketHistory.Para.con_per).AliasName))
                    x_oHandSetOfferBasketHistoryRow.con_per = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferBasketHistory.Para.con_per).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferBasketHistory.Para.ddate).AliasName))
                    x_oHandSetOfferBasketHistoryRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferBasketHistory.Para.ddate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferBasketHistory.Para.normal_rebate_type).AliasName))
                    x_oHandSetOfferBasketHistoryRow.normal_rebate_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferBasketHistory.Para.normal_rebate_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferBasketHistory.Para.premium).AliasName))
                    x_oHandSetOfferBasketHistoryRow.premium = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferBasketHistory.Para.premium).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferBasketHistory.Para.extra_rebate).AliasName))
                    x_oHandSetOfferBasketHistoryRow.extra_rebate = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferBasketHistory.Para.extra_rebate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferBasketHistory.Para.rebate_gp).AliasName))
                    x_oHandSetOfferBasketHistoryRow.rebate_gp = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferBasketHistory.Para.rebate_gp).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferBasketHistory.Para.normal_rebate).AliasName))
                    x_oHandSetOfferBasketHistoryRow.normal_rebate = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferBasketHistory.Para.normal_rebate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferBasketHistory.Para.hs_model).AliasName))
                    x_oHandSetOfferBasketHistoryRow.hs_model = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferBasketHistory.Para.hs_model).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferBasketHistory.Para.offer_type_id).AliasName))
                    x_oHandSetOfferBasketHistoryRow.offer_type_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferBasketHistory.Para.offer_type_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferBasketHistory.Para.active).AliasName))
                    x_oHandSetOfferBasketHistoryRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferBasketHistory.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferBasketHistory.Para.rebate_amount).AliasName))
                    x_oHandSetOfferBasketHistoryRow.rebate_amount = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferBasketHistory.Para.rebate_amount).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferBasketHistory.Para.plan_fee).AliasName))
                    x_oHandSetOfferBasketHistoryRow.plan_fee = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferBasketHistory.Para.plan_fee).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferBasketHistory.Para.item_code).AliasName))
                    x_oHandSetOfferBasketHistoryRow.item_code = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferBasketHistory.Para.item_code).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferBasketHistory.Para.issue_type).AliasName))
                    x_oHandSetOfferBasketHistoryRow.issue_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferBasketHistory.Para.issue_type).AliasName];
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
            return HandSetOfferBasketHistoryRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static HandSetOfferBasketHistoryEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return HandSetOfferBasketHistoryRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static HandSetOfferBasketHistoryEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return HandSetOfferBasketHistoryRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return HandSetOfferBasketHistoryRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return HandSetOfferBasketHistoryRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return HandSetOfferBasketHistoryRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<int> x_iRec_no,string x_sR_offer,string x_sExtra_rebate_amount,global::System.Nullable<DateTime> x_dCdate,string x_sAmount,string x_sCid,string x_sDid,global::System.Nullable<DateTime> x_dSdate,string x_sPayment,string x_sRetention_type,global::System.Nullable<DateTime> x_dEdate,string x_sCon_per,global::System.Nullable<DateTime> x_dDdate,string x_sNormal_rebate_type,string x_sPremium,string x_sExtra_rebate,string x_sRebate_gp,global::System.Nullable<bool> x_bNormal_rebate,string x_sHs_model,global::System.Nullable<int> x_iOffer_type_id,global::System.Nullable<bool> x_bActive,string x_sRebate_amount,string x_sPlan_fee,string x_sItem_code,string x_sIssue_type)
        {
            return HandSetOfferBasketHistoryRepository.Insert(x_oDB, x_iRec_no,x_sR_offer,x_sExtra_rebate_amount,x_dCdate,x_sAmount,x_sCid,x_sDid,x_dSdate,x_sPayment,x_sRetention_type,x_dEdate,x_sCon_per,x_dDdate,x_sNormal_rebate_type,x_sPremium,x_sExtra_rebate,x_sRebate_gp,x_bNormal_rebate,x_sHs_model,x_iOffer_type_id,x_bActive,x_sRebate_amount,x_sPlan_fee,x_sItem_code,x_sIssue_type);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,HandSetOfferBasketHistory x_oHandSetOfferBasketHistory)
        {
            return HandSetOfferBasketHistoryRepository.InsertWithOutLastID(x_oDB,x_oHandSetOfferBasketHistory);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<int> x_iRec_no,string x_sR_offer,string x_sExtra_rebate_amount,global::System.Nullable<DateTime> x_dCdate,string x_sAmount,string x_sCid,string x_sDid,global::System.Nullable<DateTime> x_dSdate,string x_sPayment,string x_sRetention_type,global::System.Nullable<DateTime> x_dEdate,string x_sCon_per,global::System.Nullable<DateTime> x_dDdate,string x_sNormal_rebate_type,string x_sPremium,string x_sExtra_rebate,string x_sRebate_gp,global::System.Nullable<bool> x_bNormal_rebate,string x_sHs_model,global::System.Nullable<int> x_iOffer_type_id,global::System.Nullable<bool> x_bActive,string x_sRebate_amount,string x_sPlan_fee,string x_sItem_code,string x_sIssue_type)
        {
            return HandSetOfferBasketHistoryRepository.InsertReturnLastID_SP(x_oDB,x_iRec_no,x_sR_offer,x_sExtra_rebate_amount,x_dCdate,x_sAmount,x_sCid,x_sDid,x_dSdate,x_sPayment,x_sRetention_type,x_dEdate,x_sCon_per,x_dDdate,x_sNormal_rebate_type,x_sPremium,x_sExtra_rebate,x_sRebate_gp,x_bNormal_rebate,x_sHs_model,x_iOffer_type_id,x_bActive,x_sRebate_amount,x_sPlan_fee,x_sItem_code,x_sIssue_type);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, HandSetOfferBasketHistory x_oHandSetOfferBasketHistory)
        {
            return HandSetOfferBasketHistoryRepository.InsertReturnLastID_SP(x_oDB,x_oHandSetOfferBasketHistory);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return HandSetOfferBasketHistoryRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return HandSetOfferBasketHistoryRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            return HandSetOfferBasketHistoryRepository.Delete(x_oDB, x_iMid);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(HandSetOfferBasketHistory x_oHandSetOfferBasketHistoryRow){
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


