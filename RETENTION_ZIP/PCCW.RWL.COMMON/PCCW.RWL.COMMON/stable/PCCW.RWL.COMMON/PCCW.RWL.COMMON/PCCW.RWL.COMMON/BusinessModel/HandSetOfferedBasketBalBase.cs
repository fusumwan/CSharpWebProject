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
///-- Description:	<Description,Table :[HandSetOfferedBasket],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [HandSetOfferedBasket] Business layer
    /// </summary>
    
    public abstract class HandSetOfferedBasketBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public HandSetOfferedBasketBalBase(){
        }
        ~HandSetOfferedBasketBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(HandSetOfferedBasket x_oHandSetOfferedBasket)
        {
            return GetDataSet(x_oHandSetOfferedBasket,null,HandSetOfferedBasketInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(HandSetOfferedBasket x_oHandSetOfferedBasket,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oHandSetOfferedBasket,x_oMergeDSet,HandSetOfferedBasketInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(HandSetOfferedBasket x_oHandSetOfferedBasket,HandSetOfferedBasketInfo x_oTableSet)
        {
            return GetDataSet(x_oHandSetOfferedBasket,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(HandSetOfferedBasket x_oHandSetOfferedBasket,global::System.Data.DataSet x_oMergeDSet,HandSetOfferedBasketInfo x_oTableSet)
        {
            return GetDataSet(x_oHandSetOfferedBasket,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(HandSetOfferedBasket x_oHandSetOfferedBasket,global::System.Data.DataSet x_oMergeDSet,HandSetOfferedBasketInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = HandSetOfferedBasketInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(HandSetOfferedBasket.Para.TableName());
            if (x_oTableSet.Fields(HandSetOfferedBasket.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferedBasket.Para.TableName()].Columns.Add(HandSetOfferedBasket.Para.mid); }
            if (x_oTableSet.Fields(HandSetOfferedBasket.Para.r_offer).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferedBasket.Para.TableName()].Columns.Add(HandSetOfferedBasket.Para.r_offer); }
            if (x_oTableSet.Fields(HandSetOfferedBasket.Para.extra_rebate_amount).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferedBasket.Para.TableName()].Columns.Add(HandSetOfferedBasket.Para.extra_rebate_amount); }
            if (x_oTableSet.Fields(HandSetOfferedBasket.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferedBasket.Para.TableName()].Columns.Add(HandSetOfferedBasket.Para.cdate); }
            if (x_oTableSet.Fields(HandSetOfferedBasket.Para.amount).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferedBasket.Para.TableName()].Columns.Add(HandSetOfferedBasket.Para.amount); }
            if (x_oTableSet.Fields(HandSetOfferedBasket.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferedBasket.Para.TableName()].Columns.Add(HandSetOfferedBasket.Para.cid); }
            if (x_oTableSet.Fields(HandSetOfferedBasket.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferedBasket.Para.TableName()].Columns.Add(HandSetOfferedBasket.Para.did); }
            if (x_oTableSet.Fields(HandSetOfferedBasket.Para.sdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferedBasket.Para.TableName()].Columns.Add(HandSetOfferedBasket.Para.sdate); }
            if (x_oTableSet.Fields(HandSetOfferedBasket.Para.payment).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferedBasket.Para.TableName()].Columns.Add(HandSetOfferedBasket.Para.payment); }
            if (x_oTableSet.Fields(HandSetOfferedBasket.Para.retention_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferedBasket.Para.TableName()].Columns.Add(HandSetOfferedBasket.Para.retention_type); }
            if (x_oTableSet.Fields(HandSetOfferedBasket.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferedBasket.Para.TableName()].Columns.Add(HandSetOfferedBasket.Para.edate); }
            if (x_oTableSet.Fields(HandSetOfferedBasket.Para.con_per).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferedBasket.Para.TableName()].Columns.Add(HandSetOfferedBasket.Para.con_per); }
            if (x_oTableSet.Fields(HandSetOfferedBasket.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferedBasket.Para.TableName()].Columns.Add(HandSetOfferedBasket.Para.ddate); }
            if (x_oTableSet.Fields(HandSetOfferedBasket.Para.normal_rebate_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferedBasket.Para.TableName()].Columns.Add(HandSetOfferedBasket.Para.normal_rebate_type); }
            if (x_oTableSet.Fields(HandSetOfferedBasket.Para.premium).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferedBasket.Para.TableName()].Columns.Add(HandSetOfferedBasket.Para.premium); }
            if (x_oTableSet.Fields(HandSetOfferedBasket.Para.extra_rebate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferedBasket.Para.TableName()].Columns.Add(HandSetOfferedBasket.Para.extra_rebate); }
            if (x_oTableSet.Fields(HandSetOfferedBasket.Para.rebate_gp).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferedBasket.Para.TableName()].Columns.Add(HandSetOfferedBasket.Para.rebate_gp); }
            if (x_oTableSet.Fields(HandSetOfferedBasket.Para.normal_rebate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferedBasket.Para.TableName()].Columns.Add(HandSetOfferedBasket.Para.normal_rebate); }
            if (x_oTableSet.Fields(HandSetOfferedBasket.Para.hs_model).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferedBasket.Para.TableName()].Columns.Add(HandSetOfferedBasket.Para.hs_model); }
            if (x_oTableSet.Fields(HandSetOfferedBasket.Para.offer_type_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferedBasket.Para.TableName()].Columns.Add(HandSetOfferedBasket.Para.offer_type_id); }
            if (x_oTableSet.Fields(HandSetOfferedBasket.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferedBasket.Para.TableName()].Columns.Add(HandSetOfferedBasket.Para.active); }
            if (x_oTableSet.Fields(HandSetOfferedBasket.Para.rebate_amount).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferedBasket.Para.TableName()].Columns.Add(HandSetOfferedBasket.Para.rebate_amount); }
            if (x_oTableSet.Fields(HandSetOfferedBasket.Para.plan_fee).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferedBasket.Para.TableName()].Columns.Add(HandSetOfferedBasket.Para.plan_fee); }
            if (x_oTableSet.Fields(HandSetOfferedBasket.Para.item_code).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferedBasket.Para.TableName()].Columns.Add(HandSetOfferedBasket.Para.item_code); }
            if (x_oTableSet.Fields(HandSetOfferedBasket.Para.issue_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferedBasket.Para.TableName()].Columns.Add(HandSetOfferedBasket.Para.issue_type); }
            if (x_oHandSetOfferedBasket != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[HandSetOfferedBasket.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(HandSetOfferedBasket.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferedBasket.Para.mid] = x_oHandSetOfferedBasket.GetMid(); }
                if (x_oTableSet.Fields(HandSetOfferedBasket.Para.r_offer).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferedBasket.Para.r_offer] = x_oHandSetOfferedBasket.GetR_offer(); }
                if (x_oTableSet.Fields(HandSetOfferedBasket.Para.extra_rebate_amount).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferedBasket.Para.extra_rebate_amount] = x_oHandSetOfferedBasket.GetExtra_rebate_amount(); }
                if (x_oTableSet.Fields(HandSetOfferedBasket.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferedBasket.Para.cdate] = x_oHandSetOfferedBasket.GetCdate(); }
                if (x_oTableSet.Fields(HandSetOfferedBasket.Para.amount).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferedBasket.Para.amount] = x_oHandSetOfferedBasket.GetAmount(); }
                if (x_oTableSet.Fields(HandSetOfferedBasket.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferedBasket.Para.cid] = x_oHandSetOfferedBasket.GetCid(); }
                if (x_oTableSet.Fields(HandSetOfferedBasket.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferedBasket.Para.did] = x_oHandSetOfferedBasket.GetDid(); }
                if (x_oTableSet.Fields(HandSetOfferedBasket.Para.sdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferedBasket.Para.sdate] = x_oHandSetOfferedBasket.GetSdate(); }
                if (x_oTableSet.Fields(HandSetOfferedBasket.Para.payment).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferedBasket.Para.payment] = x_oHandSetOfferedBasket.GetPayment(); }
                if (x_oTableSet.Fields(HandSetOfferedBasket.Para.retention_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferedBasket.Para.retention_type] = x_oHandSetOfferedBasket.GetRetention_type(); }
                if (x_oTableSet.Fields(HandSetOfferedBasket.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferedBasket.Para.edate] = x_oHandSetOfferedBasket.GetEdate(); }
                if (x_oTableSet.Fields(HandSetOfferedBasket.Para.con_per).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferedBasket.Para.con_per] = x_oHandSetOfferedBasket.GetCon_per(); }
                if (x_oTableSet.Fields(HandSetOfferedBasket.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferedBasket.Para.ddate] = x_oHandSetOfferedBasket.GetDdate(); }
                if (x_oTableSet.Fields(HandSetOfferedBasket.Para.normal_rebate_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferedBasket.Para.normal_rebate_type] = x_oHandSetOfferedBasket.GetNormal_rebate_type(); }
                if (x_oTableSet.Fields(HandSetOfferedBasket.Para.premium).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferedBasket.Para.premium] = x_oHandSetOfferedBasket.GetPremium(); }
                if (x_oTableSet.Fields(HandSetOfferedBasket.Para.extra_rebate).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferedBasket.Para.extra_rebate] = x_oHandSetOfferedBasket.GetExtra_rebate(); }
                if (x_oTableSet.Fields(HandSetOfferedBasket.Para.rebate_gp).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferedBasket.Para.rebate_gp] = x_oHandSetOfferedBasket.GetRebate_gp(); }
                if (x_oTableSet.Fields(HandSetOfferedBasket.Para.normal_rebate).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferedBasket.Para.normal_rebate] = x_oHandSetOfferedBasket.GetNormal_rebate(); }
                if (x_oTableSet.Fields(HandSetOfferedBasket.Para.hs_model).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferedBasket.Para.hs_model] = x_oHandSetOfferedBasket.GetHs_model(); }
                if (x_oTableSet.Fields(HandSetOfferedBasket.Para.offer_type_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferedBasket.Para.offer_type_id] = x_oHandSetOfferedBasket.GetOffer_type_id(); }
                if (x_oTableSet.Fields(HandSetOfferedBasket.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferedBasket.Para.active] = x_oHandSetOfferedBasket.GetActive(); }
                if (x_oTableSet.Fields(HandSetOfferedBasket.Para.rebate_amount).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferedBasket.Para.rebate_amount] = x_oHandSetOfferedBasket.GetRebate_amount(); }
                if (x_oTableSet.Fields(HandSetOfferedBasket.Para.plan_fee).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferedBasket.Para.plan_fee] = x_oHandSetOfferedBasket.GetPlan_fee(); }
                if (x_oTableSet.Fields(HandSetOfferedBasket.Para.item_code).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferedBasket.Para.item_code] = x_oHandSetOfferedBasket.GetItem_code(); }
                if (x_oTableSet.Fields(HandSetOfferedBasket.Para.issue_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferedBasket.Para.issue_type] = x_oHandSetOfferedBasket.GetIssue_type(); }
                _oDSet.Tables[HandSetOfferedBasket.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(HandSetOfferedBasketInfo x_oTableSet)
        {
            return HandSetOfferedBasketBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return HandSetOfferedBasketBal.ToEmptyDataSetProcess(HandSetOfferedBasketInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(HandSetOfferedBasketInfo x_oTableSet)
        {
            return HandSetOfferedBasketBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(HandSetOfferedBasket x_oHandSetOfferedBasket, HandSetOfferedBasketInfo x_oTableSet)
        {
            return HandSetOfferedBasketBal.GetDataSet(null, null, x_oTableSet).Tables[HandSetOfferedBasket.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(HandSetOfferedBasket x_oHandSetOfferedBasket)
        {
            return HandSetOfferedBasketBal.GetDataSet(x_oHandSetOfferedBasket, null, HandSetOfferedBasketInfoDLL.CreateInfoInstanceObject()).Tables[HandSetOfferedBasket.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            return Row(x_oTable, x_oDB,x_iMid,HandSetOfferedBasketInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid, HandSetOfferedBasketInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iMid, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid,HandSetOfferedBasketInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = HandSetOfferedBasketInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [HandSetOfferedBasket].[mid] AS HANDSETOFFEREDBASKET_MID,[HandSetOfferedBasket].[r_offer] AS HANDSETOFFEREDBASKET_R_OFFER,[HandSetOfferedBasket].[extra_rebate_amount] AS HANDSETOFFEREDBASKET_EXTRA_REBATE_AMOUNT,[HandSetOfferedBasket].[cdate] AS HANDSETOFFEREDBASKET_CDATE,[HandSetOfferedBasket].[amount] AS HANDSETOFFEREDBASKET_AMOUNT,[HandSetOfferedBasket].[cid] AS HANDSETOFFEREDBASKET_CID,[HandSetOfferedBasket].[did] AS HANDSETOFFEREDBASKET_DID,[HandSetOfferedBasket].[sdate] AS HANDSETOFFEREDBASKET_SDATE,[HandSetOfferedBasket].[payment] AS HANDSETOFFEREDBASKET_PAYMENT,[HandSetOfferedBasket].[retention_type] AS HANDSETOFFEREDBASKET_RETENTION_TYPE,[HandSetOfferedBasket].[edate] AS HANDSETOFFEREDBASKET_EDATE,[HandSetOfferedBasket].[con_per] AS HANDSETOFFEREDBASKET_CON_PER,[HandSetOfferedBasket].[ddate] AS HANDSETOFFEREDBASKET_DDATE,[HandSetOfferedBasket].[normal_rebate_type] AS HANDSETOFFEREDBASKET_NORMAL_REBATE_TYPE,[HandSetOfferedBasket].[premium] AS HANDSETOFFEREDBASKET_PREMIUM,[HandSetOfferedBasket].[extra_rebate] AS HANDSETOFFEREDBASKET_EXTRA_REBATE,[HandSetOfferedBasket].[rebate_gp] AS HANDSETOFFEREDBASKET_REBATE_GP,[HandSetOfferedBasket].[normal_rebate] AS HANDSETOFFEREDBASKET_NORMAL_REBATE,[HandSetOfferedBasket].[hs_model] AS HANDSETOFFEREDBASKET_HS_MODEL,[HandSetOfferedBasket].[offer_type_id] AS HANDSETOFFEREDBASKET_OFFER_TYPE_ID,[HandSetOfferedBasket].[active] AS HANDSETOFFEREDBASKET_ACTIVE,[HandSetOfferedBasket].[rebate_amount] AS HANDSETOFFEREDBASKET_REBATE_AMOUNT,[HandSetOfferedBasket].[plan_fee] AS HANDSETOFFEREDBASKET_PLAN_FEE,[HandSetOfferedBasket].[item_code] AS HANDSETOFFEREDBASKET_ITEM_CODE,[HandSetOfferedBasket].[issue_type] AS HANDSETOFFEREDBASKET_ISSUE_TYPE  FROM  [HandSetOfferedBasket]  WHERE  [HandSetOfferedBasket].[mid] = \'"+x_iMid.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[HandSetOfferedBasket]","["+ Configurator.MSSQLTablePrefix + "HandSetOfferedBasket]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(HandSetOfferedBasket.Para.mid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_MID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferedBasket.Para.mid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.mid).AliasName].ToString()] = (global::System.Nullable<int>)_oData["HANDSETOFFEREDBASKET_MID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.mid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferedBasket.Para.r_offer).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_R_OFFER"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferedBasket.Para.r_offer).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.r_offer).AliasName].ToString()] = (string)_oData["HANDSETOFFEREDBASKET_R_OFFER"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.r_offer).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferedBasket.Para.extra_rebate_amount).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_EXTRA_REBATE_AMOUNT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferedBasket.Para.extra_rebate_amount).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.extra_rebate_amount).AliasName].ToString()] = (string)_oData["HANDSETOFFEREDBASKET_EXTRA_REBATE_AMOUNT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.extra_rebate_amount).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferedBasket.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferedBasket.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["HANDSETOFFEREDBASKET_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferedBasket.Para.amount).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_AMOUNT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferedBasket.Para.amount).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.amount).AliasName].ToString()] = (string)_oData["HANDSETOFFEREDBASKET_AMOUNT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.amount).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferedBasket.Para.cid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferedBasket.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.cid).AliasName].ToString()] = (string)_oData["HANDSETOFFEREDBASKET_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.cid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferedBasket.Para.did).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferedBasket.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.did).AliasName].ToString()] = (string)_oData["HANDSETOFFEREDBASKET_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.did).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferedBasket.Para.sdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_SDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferedBasket.Para.sdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.sdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["HANDSETOFFEREDBASKET_SDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.sdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferedBasket.Para.payment).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_PAYMENT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferedBasket.Para.payment).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.payment).AliasName].ToString()] = (string)_oData["HANDSETOFFEREDBASKET_PAYMENT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.payment).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferedBasket.Para.retention_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_RETENTION_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferedBasket.Para.retention_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.retention_type).AliasName].ToString()] = (string)_oData["HANDSETOFFEREDBASKET_RETENTION_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.retention_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferedBasket.Para.edate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_EDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferedBasket.Para.edate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.edate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["HANDSETOFFEREDBASKET_EDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.edate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferedBasket.Para.con_per).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_CON_PER"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferedBasket.Para.con_per).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.con_per).AliasName].ToString()] = (string)_oData["HANDSETOFFEREDBASKET_CON_PER"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.con_per).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferedBasket.Para.ddate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferedBasket.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["HANDSETOFFEREDBASKET_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.ddate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferedBasket.Para.normal_rebate_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_NORMAL_REBATE_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferedBasket.Para.normal_rebate_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.normal_rebate_type).AliasName].ToString()] = (string)_oData["HANDSETOFFEREDBASKET_NORMAL_REBATE_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.normal_rebate_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferedBasket.Para.premium).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_PREMIUM"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferedBasket.Para.premium).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.premium).AliasName].ToString()] = (string)_oData["HANDSETOFFEREDBASKET_PREMIUM"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.premium).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferedBasket.Para.extra_rebate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_EXTRA_REBATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferedBasket.Para.extra_rebate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.extra_rebate).AliasName].ToString()] = (string)_oData["HANDSETOFFEREDBASKET_EXTRA_REBATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.extra_rebate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferedBasket.Para.rebate_gp).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_REBATE_GP"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferedBasket.Para.rebate_gp).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.rebate_gp).AliasName].ToString()] = (string)_oData["HANDSETOFFEREDBASKET_REBATE_GP"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.rebate_gp).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferedBasket.Para.normal_rebate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_NORMAL_REBATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferedBasket.Para.normal_rebate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.normal_rebate).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["HANDSETOFFEREDBASKET_NORMAL_REBATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.normal_rebate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferedBasket.Para.hs_model).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_HS_MODEL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferedBasket.Para.hs_model).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.hs_model).AliasName].ToString()] = (string)_oData["HANDSETOFFEREDBASKET_HS_MODEL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.hs_model).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferedBasket.Para.offer_type_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_OFFER_TYPE_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferedBasket.Para.offer_type_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.offer_type_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["HANDSETOFFEREDBASKET_OFFER_TYPE_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.offer_type_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferedBasket.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferedBasket.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["HANDSETOFFEREDBASKET_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferedBasket.Para.rebate_amount).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_REBATE_AMOUNT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferedBasket.Para.rebate_amount).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.rebate_amount).AliasName].ToString()] = (string)_oData["HANDSETOFFEREDBASKET_REBATE_AMOUNT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.rebate_amount).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferedBasket.Para.plan_fee).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_PLAN_FEE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferedBasket.Para.plan_fee).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.plan_fee).AliasName].ToString()] = (string)_oData["HANDSETOFFEREDBASKET_PLAN_FEE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.plan_fee).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferedBasket.Para.item_code).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_ITEM_CODE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferedBasket.Para.item_code).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.item_code).AliasName].ToString()] = (string)_oData["HANDSETOFFEREDBASKET_ITEM_CODE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.item_code).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferedBasket.Para.issue_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_ISSUE_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferedBasket.Para.issue_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.issue_type).AliasName].ToString()] = (string)_oData["HANDSETOFFEREDBASKET_ISSUE_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferedBasket.Para.issue_type).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,HandSetOfferedBasket x_oHandSetOfferedBasketRow)
        {
            return SetByDataSetRowProc(x_iROW, HandSetOfferedBasket.Para.TableName(), x_oDataSet,x_oHandSetOfferedBasketRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,HandSetOfferedBasket x_oHandSetOfferedBasketRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oHandSetOfferedBasketRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,HandSetOfferedBasket x_oHandSetOfferedBasketRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                HandSetOfferedBasketInfo _oTableSet=HandSetOfferedBasketInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferedBasket.Para.mid).AliasName))
                    x_oHandSetOfferedBasketRow.mid = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferedBasket.Para.mid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferedBasket.Para.r_offer).AliasName))
                    x_oHandSetOfferedBasketRow.r_offer = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferedBasket.Para.r_offer).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferedBasket.Para.extra_rebate_amount).AliasName))
                    x_oHandSetOfferedBasketRow.extra_rebate_amount = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferedBasket.Para.extra_rebate_amount).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferedBasket.Para.cdate).AliasName))
                    x_oHandSetOfferedBasketRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferedBasket.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferedBasket.Para.amount).AliasName))
                    x_oHandSetOfferedBasketRow.amount = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferedBasket.Para.amount).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferedBasket.Para.cid).AliasName))
                    x_oHandSetOfferedBasketRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferedBasket.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferedBasket.Para.did).AliasName))
                    x_oHandSetOfferedBasketRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferedBasket.Para.did).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferedBasket.Para.sdate).AliasName))
                    x_oHandSetOfferedBasketRow.sdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferedBasket.Para.sdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferedBasket.Para.payment).AliasName))
                    x_oHandSetOfferedBasketRow.payment = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferedBasket.Para.payment).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferedBasket.Para.retention_type).AliasName))
                    x_oHandSetOfferedBasketRow.retention_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferedBasket.Para.retention_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferedBasket.Para.edate).AliasName))
                    x_oHandSetOfferedBasketRow.edate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferedBasket.Para.edate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferedBasket.Para.con_per).AliasName))
                    x_oHandSetOfferedBasketRow.con_per = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferedBasket.Para.con_per).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferedBasket.Para.ddate).AliasName))
                    x_oHandSetOfferedBasketRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferedBasket.Para.ddate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferedBasket.Para.normal_rebate_type).AliasName))
                    x_oHandSetOfferedBasketRow.normal_rebate_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferedBasket.Para.normal_rebate_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferedBasket.Para.premium).AliasName))
                    x_oHandSetOfferedBasketRow.premium = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferedBasket.Para.premium).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferedBasket.Para.extra_rebate).AliasName))
                    x_oHandSetOfferedBasketRow.extra_rebate = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferedBasket.Para.extra_rebate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferedBasket.Para.rebate_gp).AliasName))
                    x_oHandSetOfferedBasketRow.rebate_gp = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferedBasket.Para.rebate_gp).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferedBasket.Para.normal_rebate).AliasName))
                    x_oHandSetOfferedBasketRow.normal_rebate = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferedBasket.Para.normal_rebate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferedBasket.Para.hs_model).AliasName))
                    x_oHandSetOfferedBasketRow.hs_model = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferedBasket.Para.hs_model).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferedBasket.Para.offer_type_id).AliasName))
                    x_oHandSetOfferedBasketRow.offer_type_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferedBasket.Para.offer_type_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferedBasket.Para.active).AliasName))
                    x_oHandSetOfferedBasketRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferedBasket.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferedBasket.Para.rebate_amount).AliasName))
                    x_oHandSetOfferedBasketRow.rebate_amount = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferedBasket.Para.rebate_amount).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferedBasket.Para.plan_fee).AliasName))
                    x_oHandSetOfferedBasketRow.plan_fee = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferedBasket.Para.plan_fee).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferedBasket.Para.item_code).AliasName))
                    x_oHandSetOfferedBasketRow.item_code = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferedBasket.Para.item_code).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferedBasket.Para.issue_type).AliasName))
                    x_oHandSetOfferedBasketRow.issue_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferedBasket.Para.issue_type).AliasName];
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
            return HandSetOfferedBasketRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static HandSetOfferedBasketEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return HandSetOfferedBasketRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static HandSetOfferedBasketEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return HandSetOfferedBasketRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return HandSetOfferedBasketRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return HandSetOfferedBasketRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return HandSetOfferedBasketRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sR_offer,string x_sExtra_rebate_amount,global::System.Nullable<DateTime> x_dCdate,string x_sAmount,string x_sCid,string x_sDid,global::System.Nullable<DateTime> x_dSdate,string x_sPayment,string x_sRetention_type,global::System.Nullable<DateTime> x_dEdate,string x_sCon_per,global::System.Nullable<DateTime> x_dDdate,string x_sNormal_rebate_type,string x_sPremium,string x_sExtra_rebate,string x_sRebate_gp,global::System.Nullable<bool> x_bNormal_rebate,string x_sHs_model,global::System.Nullable<int> x_iOffer_type_id,global::System.Nullable<bool> x_bActive,string x_sRebate_amount,string x_sPlan_fee,string x_sItem_code,string x_sIssue_type)
        {
            return HandSetOfferedBasketRepository.Insert(x_oDB, x_sR_offer,x_sExtra_rebate_amount,x_dCdate,x_sAmount,x_sCid,x_sDid,x_dSdate,x_sPayment,x_sRetention_type,x_dEdate,x_sCon_per,x_dDdate,x_sNormal_rebate_type,x_sPremium,x_sExtra_rebate,x_sRebate_gp,x_bNormal_rebate,x_sHs_model,x_iOffer_type_id,x_bActive,x_sRebate_amount,x_sPlan_fee,x_sItem_code,x_sIssue_type);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,HandSetOfferedBasket x_oHandSetOfferedBasket)
        {
            return HandSetOfferedBasketRepository.InsertWithOutLastID(x_oDB,x_oHandSetOfferedBasket);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sR_offer,string x_sExtra_rebate_amount,global::System.Nullable<DateTime> x_dCdate,string x_sAmount,string x_sCid,string x_sDid,global::System.Nullable<DateTime> x_dSdate,string x_sPayment,string x_sRetention_type,global::System.Nullable<DateTime> x_dEdate,string x_sCon_per,global::System.Nullable<DateTime> x_dDdate,string x_sNormal_rebate_type,string x_sPremium,string x_sExtra_rebate,string x_sRebate_gp,global::System.Nullable<bool> x_bNormal_rebate,string x_sHs_model,global::System.Nullable<int> x_iOffer_type_id,global::System.Nullable<bool> x_bActive,string x_sRebate_amount,string x_sPlan_fee,string x_sItem_code,string x_sIssue_type)
        {
            return HandSetOfferedBasketRepository.InsertReturnLastID_SP(x_oDB,x_sR_offer,x_sExtra_rebate_amount,x_dCdate,x_sAmount,x_sCid,x_sDid,x_dSdate,x_sPayment,x_sRetention_type,x_dEdate,x_sCon_per,x_dDdate,x_sNormal_rebate_type,x_sPremium,x_sExtra_rebate,x_sRebate_gp,x_bNormal_rebate,x_sHs_model,x_iOffer_type_id,x_bActive,x_sRebate_amount,x_sPlan_fee,x_sItem_code,x_sIssue_type);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, HandSetOfferedBasket x_oHandSetOfferedBasket)
        {
            return HandSetOfferedBasketRepository.InsertReturnLastID_SP(x_oDB,x_oHandSetOfferedBasket);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return HandSetOfferedBasketRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return HandSetOfferedBasketRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            return HandSetOfferedBasketRepository.Delete(x_oDB, x_iMid);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(HandSetOfferedBasket x_oHandSetOfferedBasketRow){
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


