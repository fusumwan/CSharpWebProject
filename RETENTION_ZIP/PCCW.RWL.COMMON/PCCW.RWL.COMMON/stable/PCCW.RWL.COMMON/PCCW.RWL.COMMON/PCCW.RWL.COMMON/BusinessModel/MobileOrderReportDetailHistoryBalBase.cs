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
///-- Description:	<Description,Table :[MobileOrderReportDetailHistory],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderReportDetailHistory] Business layer
    /// </summary>
    
    public abstract class MobileOrderReportDetailHistoryBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public MobileOrderReportDetailHistoryBalBase(){
        }
        ~MobileOrderReportDetailHistoryBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderReportDetailHistory x_oMobileOrderReportDetailHistory)
        {
            return GetDataSet(x_oMobileOrderReportDetailHistory,null,MobileOrderReportDetailHistoryInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderReportDetailHistory x_oMobileOrderReportDetailHistory,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oMobileOrderReportDetailHistory,x_oMergeDSet,MobileOrderReportDetailHistoryInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderReportDetailHistory x_oMobileOrderReportDetailHistory,MobileOrderReportDetailHistoryInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderReportDetailHistory,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderReportDetailHistory x_oMobileOrderReportDetailHistory,global::System.Data.DataSet x_oMergeDSet,MobileOrderReportDetailHistoryInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderReportDetailHistory,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(MobileOrderReportDetailHistory x_oMobileOrderReportDetailHistory,global::System.Data.DataSet x_oMergeDSet,MobileOrderReportDetailHistoryInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderReportDetailHistoryInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(MobileOrderReportDetailHistory.Para.TableName());
            if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.order_status).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetailHistory.Para.TableName()].Columns.Add(MobileOrderReportDetailHistory.Para.order_status); }
            if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.fallout_reply).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetailHistory.Para.TableName()].Columns.Add(MobileOrderReportDetailHistory.Para.fallout_reply); }
            if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.mflag).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetailHistory.Para.TableName()].Columns.Add(MobileOrderReportDetailHistory.Para.mflag); }
            if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.email_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetailHistory.Para.TableName()].Columns.Add(MobileOrderReportDetailHistory.Para.email_date); }
            if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.retrieve_cnt).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetailHistory.Para.TableName()].Columns.Add(MobileOrderReportDetailHistory.Para.retrieve_cnt); }
            if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetailHistory.Para.TableName()].Columns.Add(MobileOrderReportDetailHistory.Para.cdate); }
            if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.retrieve_sn).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetailHistory.Para.TableName()].Columns.Add(MobileOrderReportDetailHistory.Para.retrieve_sn); }
            if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetailHistory.Para.TableName()].Columns.Add(MobileOrderReportDetailHistory.Para.cid); }
            if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetailHistory.Para.TableName()].Columns.Add(MobileOrderReportDetailHistory.Para.did); }
            if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.eid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetailHistory.Para.TableName()].Columns.Add(MobileOrderReportDetailHistory.Para.eid); }
            if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetailHistory.Para.TableName()].Columns.Add(MobileOrderReportDetailHistory.Para.active); }
            if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.fallout_reason).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetailHistory.Para.TableName()].Columns.Add(MobileOrderReportDetailHistory.Para.fallout_reason); }
            if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.fallout_remark).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetailHistory.Para.TableName()].Columns.Add(MobileOrderReportDetailHistory.Para.fallout_remark); }
            if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.fallout_main_category).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetailHistory.Para.TableName()].Columns.Add(MobileOrderReportDetailHistory.Para.fallout_main_category); }
            if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.report_his_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetailHistory.Para.TableName()].Columns.Add(MobileOrderReportDetailHistory.Para.report_his_id); }
            if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.report_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetailHistory.Para.TableName()].Columns.Add(MobileOrderReportDetailHistory.Para.report_type); }
            if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.reactive_sn).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetailHistory.Para.TableName()].Columns.Add(MobileOrderReportDetailHistory.Para.reactive_sn); }
            if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetailHistory.Para.TableName()].Columns.Add(MobileOrderReportDetailHistory.Para.ddate); }
            if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.mdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetailHistory.Para.TableName()].Columns.Add(MobileOrderReportDetailHistory.Para.mdate); }
            if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.reactive_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetailHistory.Para.TableName()].Columns.Add(MobileOrderReportDetailHistory.Para.reactive_date); }
            if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetailHistory.Para.TableName()].Columns.Add(MobileOrderReportDetailHistory.Para.order_id); }
            if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.rec_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetailHistory.Para.TableName()].Columns.Add(MobileOrderReportDetailHistory.Para.rec_no); }
            if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.retrieve_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetailHistory.Para.TableName()].Columns.Add(MobileOrderReportDetailHistory.Para.retrieve_date); }
            if (x_oMobileOrderReportDetailHistory != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[MobileOrderReportDetailHistory.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.order_status).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetailHistory.Para.order_status] = x_oMobileOrderReportDetailHistory.GetOrder_status(); }
                if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.fallout_reply).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetailHistory.Para.fallout_reply] = x_oMobileOrderReportDetailHistory.GetFallout_reply(); }
                if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.mflag).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetailHistory.Para.mflag] = x_oMobileOrderReportDetailHistory.GetMflag(); }
                if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.email_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetailHistory.Para.email_date] = x_oMobileOrderReportDetailHistory.GetEmail_date(); }
                if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.retrieve_cnt).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetailHistory.Para.retrieve_cnt] = x_oMobileOrderReportDetailHistory.GetRetrieve_cnt(); }
                if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetailHistory.Para.cdate] = x_oMobileOrderReportDetailHistory.GetCdate(); }
                if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.retrieve_sn).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetailHistory.Para.retrieve_sn] = x_oMobileOrderReportDetailHistory.GetRetrieve_sn(); }
                if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetailHistory.Para.cid] = x_oMobileOrderReportDetailHistory.GetCid(); }
                if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetailHistory.Para.did] = x_oMobileOrderReportDetailHistory.GetDid(); }
                if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.eid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetailHistory.Para.eid] = x_oMobileOrderReportDetailHistory.GetEid(); }
                if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetailHistory.Para.active] = x_oMobileOrderReportDetailHistory.GetActive(); }
                if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.fallout_reason).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetailHistory.Para.fallout_reason] = x_oMobileOrderReportDetailHistory.GetFallout_reason(); }
                if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.fallout_remark).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetailHistory.Para.fallout_remark] = x_oMobileOrderReportDetailHistory.GetFallout_remark(); }
                if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.fallout_main_category).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetailHistory.Para.fallout_main_category] = x_oMobileOrderReportDetailHistory.GetFallout_main_category(); }
                if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.report_his_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetailHistory.Para.report_his_id] = x_oMobileOrderReportDetailHistory.GetReport_his_id(); }
                if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.report_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetailHistory.Para.report_type] = x_oMobileOrderReportDetailHistory.GetReport_type(); }
                if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.reactive_sn).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetailHistory.Para.reactive_sn] = x_oMobileOrderReportDetailHistory.GetReactive_sn(); }
                if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetailHistory.Para.ddate] = x_oMobileOrderReportDetailHistory.GetDdate(); }
                if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.mdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetailHistory.Para.mdate] = x_oMobileOrderReportDetailHistory.GetMdate(); }
                if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.reactive_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetailHistory.Para.reactive_date] = x_oMobileOrderReportDetailHistory.GetReactive_date(); }
                if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetailHistory.Para.order_id] = x_oMobileOrderReportDetailHistory.GetOrder_id(); }
                if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.rec_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetailHistory.Para.rec_no] = x_oMobileOrderReportDetailHistory.GetRec_no(); }
                if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.retrieve_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetailHistory.Para.retrieve_date] = x_oMobileOrderReportDetailHistory.GetRetrieve_date(); }
                _oDSet.Tables[MobileOrderReportDetailHistory.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(MobileOrderReportDetailHistoryInfo x_oTableSet)
        {
            return MobileOrderReportDetailHistoryBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return MobileOrderReportDetailHistoryBal.ToEmptyDataSetProcess(MobileOrderReportDetailHistoryInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(MobileOrderReportDetailHistoryInfo x_oTableSet)
        {
            return MobileOrderReportDetailHistoryBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(MobileOrderReportDetailHistory x_oMobileOrderReportDetailHistory, MobileOrderReportDetailHistoryInfo x_oTableSet)
        {
            return MobileOrderReportDetailHistoryBal.GetDataSet(null, null, x_oTableSet).Tables[MobileOrderReportDetailHistory.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(MobileOrderReportDetailHistory x_oMobileOrderReportDetailHistory)
        {
            return MobileOrderReportDetailHistoryBal.GetDataSet(x_oMobileOrderReportDetailHistory, null, MobileOrderReportDetailHistoryInfoDLL.CreateInfoInstanceObject()).Tables[MobileOrderReportDetailHistory.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iReport_his_id)
        {
            return Row(x_oTable, x_oDB,x_iReport_his_id,MobileOrderReportDetailHistoryInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iReport_his_id, MobileOrderReportDetailHistoryInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iReport_his_id, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iReport_his_id,MobileOrderReportDetailHistoryInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderReportDetailHistoryInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [MobileOrderReportDetailHistory].[order_status] AS MOBILEORDERREPORTDETAILHISTORY_ORDER_STATUS,[MobileOrderReportDetailHistory].[mflag] AS MOBILEORDERREPORTDETAILHISTORY_MFLAG,[MobileOrderReportDetailHistory].[email_date] AS MOBILEORDERREPORTDETAILHISTORY_EMAIL_DATE,[MobileOrderReportDetailHistory].[retrieve_cnt] AS MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_CNT,[MobileOrderReportDetailHistory].[cdate] AS MOBILEORDERREPORTDETAILHISTORY_CDATE,[MobileOrderReportDetailHistory].[retrieve_sn] AS MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_SN,[MobileOrderReportDetailHistory].[cid] AS MOBILEORDERREPORTDETAILHISTORY_CID,[MobileOrderReportDetailHistory].[did] AS MOBILEORDERREPORTDETAILHISTORY_DID,[MobileOrderReportDetailHistory].[eid] AS MOBILEORDERREPORTDETAILHISTORY_EID,[MobileOrderReportDetailHistory].[active] AS MOBILEORDERREPORTDETAILHISTORY_ACTIVE,[MobileOrderReportDetailHistory].[fallout_reason] AS MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REASON,[MobileOrderReportDetailHistory].[fallout_remark] AS MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REMARK,[MobileOrderReportDetailHistory].[fallout_main_category] AS MOBILEORDERREPORTDETAILHISTORY_FALLOUT_MAIN_CATEGORY,[MobileOrderReportDetailHistory].[report_his_id] AS MOBILEORDERREPORTDETAILHISTORY_REPORT_HIS_ID,[MobileOrderReportDetailHistory].[report_type] AS MOBILEORDERREPORTDETAILHISTORY_REPORT_TYPE,[MobileOrderReportDetailHistory].[reactive_sn] AS MOBILEORDERREPORTDETAILHISTORY_REACTIVE_SN,[MobileOrderReportDetailHistory].[ddate] AS MOBILEORDERREPORTDETAILHISTORY_DDATE,[MobileOrderReportDetailHistory].[mdate] AS MOBILEORDERREPORTDETAILHISTORY_MDATE,[MobileOrderReportDetailHistory].[reactive_date] AS MOBILEORDERREPORTDETAILHISTORY_REACTIVE_DATE,[MobileOrderReportDetailHistory].[order_id] AS MOBILEORDERREPORTDETAILHISTORY_ORDER_ID,[MobileOrderReportDetailHistory].[rec_no] AS MOBILEORDERREPORTDETAILHISTORY_REC_NO,[MobileOrderReportDetailHistory].[retrieve_date] AS MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_DATE,[MobileOrderReportDetailHistory].[fallout_reply] AS MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REPLY  FROM  [MobileOrderReportDetailHistory]  WHERE  [MobileOrderReportDetailHistory].[report_his_id] = \'"+x_iReport_his_id.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportDetailHistory]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportDetailHistory]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.order_status).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_ORDER_STATUS"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.order_status).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.order_status).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_ORDER_STATUS"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.order_status).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.mflag).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_MFLAG"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.mflag).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.mflag).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTDETAILHISTORY_MFLAG"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.mflag).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.email_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_EMAIL_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.email_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.email_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAILHISTORY_EMAIL_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.email_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.retrieve_cnt).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_CNT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.retrieve_cnt).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.retrieve_cnt).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_CNT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.retrieve_cnt).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAILHISTORY_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.retrieve_sn).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_SN"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.retrieve_sn).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.retrieve_sn).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_SN"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.retrieve_sn).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.cid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.cid).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.cid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.did).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.did).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.did).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.eid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_EID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.eid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.eid).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_EID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.eid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTDETAILHISTORY_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.fallout_reason).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REASON"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.fallout_reason).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.fallout_reason).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REASON"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.fallout_reason).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.fallout_remark).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REMARK"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.fallout_remark).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.fallout_remark).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REMARK"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.fallout_remark).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.fallout_main_category).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_FALLOUT_MAIN_CATEGORY"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.fallout_main_category).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.fallout_main_category).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_FALLOUT_MAIN_CATEGORY"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.fallout_main_category).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.report_his_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_REPORT_HIS_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.report_his_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.report_his_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTDETAILHISTORY_REPORT_HIS_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.report_his_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.report_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_REPORT_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.report_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.report_type).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_REPORT_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.report_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.reactive_sn).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_REACTIVE_SN"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.reactive_sn).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.reactive_sn).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_REACTIVE_SN"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.reactive_sn).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.ddate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAILHISTORY_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.ddate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.mdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_MDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.mdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.mdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAILHISTORY_MDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.mdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.reactive_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_REACTIVE_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.reactive_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.reactive_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAILHISTORY_REACTIVE_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.reactive_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.order_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_ORDER_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.order_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.order_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTDETAILHISTORY_ORDER_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.order_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.rec_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_REC_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.rec_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.rec_no).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTDETAILHISTORY_REC_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.rec_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.retrieve_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.retrieve_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.retrieve_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.retrieve_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.fallout_reply).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REPLY"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.fallout_reply).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.fallout_reply).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REPLY"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetailHistory.Para.fallout_reply).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,MobileOrderReportDetailHistory x_oMobileOrderReportDetailHistoryRow)
        {
            return SetByDataSetRowProc(x_iROW, MobileOrderReportDetailHistory.Para.TableName(), x_oDataSet,x_oMobileOrderReportDetailHistoryRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderReportDetailHistory x_oMobileOrderReportDetailHistoryRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oMobileOrderReportDetailHistoryRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderReportDetailHistory x_oMobileOrderReportDetailHistoryRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                MobileOrderReportDetailHistoryInfo _oTableSet=MobileOrderReportDetailHistoryInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetailHistory.Para.order_status).AliasName))
                    x_oMobileOrderReportDetailHistoryRow.order_status = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetailHistory.Para.order_status).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetailHistory.Para.fallout_reply).AliasName))
                    x_oMobileOrderReportDetailHistoryRow.fallout_reply = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetailHistory.Para.fallout_reply).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetailHistory.Para.mflag).AliasName))
                    x_oMobileOrderReportDetailHistoryRow.mflag = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetailHistory.Para.mflag).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetailHistory.Para.email_date).AliasName))
                    x_oMobileOrderReportDetailHistoryRow.email_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetailHistory.Para.email_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetailHistory.Para.retrieve_cnt).AliasName))
                    x_oMobileOrderReportDetailHistoryRow.retrieve_cnt = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetailHistory.Para.retrieve_cnt).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetailHistory.Para.cdate).AliasName))
                    x_oMobileOrderReportDetailHistoryRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetailHistory.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetailHistory.Para.retrieve_sn).AliasName))
                    x_oMobileOrderReportDetailHistoryRow.retrieve_sn = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetailHistory.Para.retrieve_sn).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetailHistory.Para.cid).AliasName))
                    x_oMobileOrderReportDetailHistoryRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetailHistory.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetailHistory.Para.did).AliasName))
                    x_oMobileOrderReportDetailHistoryRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetailHistory.Para.did).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetailHistory.Para.eid).AliasName))
                    x_oMobileOrderReportDetailHistoryRow.eid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetailHistory.Para.eid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetailHistory.Para.active).AliasName))
                    x_oMobileOrderReportDetailHistoryRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetailHistory.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetailHistory.Para.fallout_reason).AliasName))
                    x_oMobileOrderReportDetailHistoryRow.fallout_reason = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetailHistory.Para.fallout_reason).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetailHistory.Para.fallout_remark).AliasName))
                    x_oMobileOrderReportDetailHistoryRow.fallout_remark = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetailHistory.Para.fallout_remark).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetailHistory.Para.fallout_main_category).AliasName))
                    x_oMobileOrderReportDetailHistoryRow.fallout_main_category = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetailHistory.Para.fallout_main_category).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetailHistory.Para.report_his_id).AliasName))
                    x_oMobileOrderReportDetailHistoryRow.report_his_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetailHistory.Para.report_his_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetailHistory.Para.report_type).AliasName))
                    x_oMobileOrderReportDetailHistoryRow.report_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetailHistory.Para.report_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetailHistory.Para.reactive_sn).AliasName))
                    x_oMobileOrderReportDetailHistoryRow.reactive_sn = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetailHistory.Para.reactive_sn).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetailHistory.Para.ddate).AliasName))
                    x_oMobileOrderReportDetailHistoryRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetailHistory.Para.ddate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetailHistory.Para.mdate).AliasName))
                    x_oMobileOrderReportDetailHistoryRow.mdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetailHistory.Para.mdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetailHistory.Para.reactive_date).AliasName))
                    x_oMobileOrderReportDetailHistoryRow.reactive_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetailHistory.Para.reactive_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetailHistory.Para.order_id).AliasName))
                    x_oMobileOrderReportDetailHistoryRow.order_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetailHistory.Para.order_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetailHistory.Para.rec_no).AliasName))
                    x_oMobileOrderReportDetailHistoryRow.rec_no = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetailHistory.Para.rec_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetailHistory.Para.retrieve_date).AliasName))
                    x_oMobileOrderReportDetailHistoryRow.retrieve_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetailHistory.Para.retrieve_date).AliasName];
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
            return MobileOrderReportDetailHistoryRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static MobileOrderReportDetailHistoryEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return MobileOrderReportDetailHistoryRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static MobileOrderReportDetailHistoryEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return MobileOrderReportDetailHistoryRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderReportDetailHistoryRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderReportDetailHistoryRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderReportDetailHistoryRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sOrder_status,string x_sFallout_reply,global::System.Nullable<bool> x_bMflag,global::System.Nullable<DateTime> x_dEmail_date,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dCdate,string x_sRetrieve_sn,string x_sCid,string x_sDid,string x_sEid,global::System.Nullable<bool> x_bActive,string x_sFallout_reason,string x_sFallout_remark,string x_sFallout_main_category,string x_sReport_type,string x_sReactive_sn,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<DateTime> x_dMdate,global::System.Nullable<DateTime> x_dReactive_date,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<int> x_iRec_no,global::System.Nullable<DateTime> x_dRetrieve_date)
        {
            return MobileOrderReportDetailHistoryRepository.Insert(x_oDB, x_sOrder_status,x_sFallout_reply,x_bMflag,x_dEmail_date,x_iRetrieve_cnt,x_dCdate,x_sRetrieve_sn,x_sCid,x_sDid,x_sEid,x_bActive,x_sFallout_reason,x_sFallout_remark,x_sFallout_main_category,x_sReport_type,x_sReactive_sn,x_dDdate,x_dMdate,x_dReactive_date,x_iOrder_id,x_iRec_no,x_dRetrieve_date);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderReportDetailHistory x_oMobileOrderReportDetailHistory)
        {
            return MobileOrderReportDetailHistoryRepository.InsertWithOutLastID(x_oDB,x_oMobileOrderReportDetailHistory);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sOrder_status,string x_sFallout_reply,global::System.Nullable<bool> x_bMflag,global::System.Nullable<DateTime> x_dEmail_date,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dCdate,string x_sRetrieve_sn,string x_sCid,string x_sDid,string x_sEid,global::System.Nullable<bool> x_bActive,string x_sFallout_reason,string x_sFallout_remark,string x_sFallout_main_category,string x_sReport_type,string x_sReactive_sn,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<DateTime> x_dMdate,global::System.Nullable<DateTime> x_dReactive_date,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<int> x_iRec_no,global::System.Nullable<DateTime> x_dRetrieve_date)
        {
            return MobileOrderReportDetailHistoryRepository.InsertReturnLastID_SP(x_oDB,x_sOrder_status,x_sFallout_reply,x_bMflag,x_dEmail_date,x_iRetrieve_cnt,x_dCdate,x_sRetrieve_sn,x_sCid,x_sDid,x_sEid,x_bActive,x_sFallout_reason,x_sFallout_remark,x_sFallout_main_category,x_sReport_type,x_sReactive_sn,x_dDdate,x_dMdate,x_dReactive_date,x_iOrder_id,x_iRec_no,x_dRetrieve_date);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderReportDetailHistory x_oMobileOrderReportDetailHistory)
        {
            return MobileOrderReportDetailHistoryRepository.InsertReturnLastID_SP(x_oDB,x_oMobileOrderReportDetailHistory);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return MobileOrderReportDetailHistoryRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderReportDetailHistoryRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iReport_his_id)
        {
            return MobileOrderReportDetailHistoryRepository.Delete(x_oDB, x_iReport_his_id);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(MobileOrderReportDetailHistory x_oMobileOrderReportDetailHistoryRow){
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


