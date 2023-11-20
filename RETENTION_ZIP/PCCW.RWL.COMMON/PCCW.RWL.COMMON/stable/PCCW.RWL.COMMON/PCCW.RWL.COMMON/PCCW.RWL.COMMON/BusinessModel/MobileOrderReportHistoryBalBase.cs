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
///-- Create date: <Create Date 2011-12-07>
///-- Description:	<Description,Table :[MobileOrderReportHistory],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderReportHistory] Business layer
    /// </summary>
    
    public abstract class MobileOrderReportHistoryBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public MobileOrderReportHistoryBalBase(){
        }
        ~MobileOrderReportHistoryBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderReportHistory x_oMobileOrderReportHistory)
        {
            return GetDataSet(x_oMobileOrderReportHistory,null,MobileOrderReportHistoryInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderReportHistory x_oMobileOrderReportHistory,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oMobileOrderReportHistory,x_oMergeDSet,MobileOrderReportHistoryInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderReportHistory x_oMobileOrderReportHistory,MobileOrderReportHistoryInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderReportHistory,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderReportHistory x_oMobileOrderReportHistory,global::System.Data.DataSet x_oMergeDSet,MobileOrderReportHistoryInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderReportHistory,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(MobileOrderReportHistory x_oMobileOrderReportHistory,global::System.Data.DataSet x_oMergeDSet,MobileOrderReportHistoryInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderReportHistoryInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(MobileOrderReportHistory.Para.TableName());
            if (x_oTableSet.Fields(MobileOrderReportHistory.Para.order_status).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportHistory.Para.TableName()].Columns.Add(MobileOrderReportHistory.Para.order_status); }
            if (x_oTableSet.Fields(MobileOrderReportHistory.Para.gw_retrieve_sn).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportHistory.Para.TableName()].Columns.Add(MobileOrderReportHistory.Para.gw_retrieve_sn); }
            if (x_oTableSet.Fields(MobileOrderReportHistory.Para.sent_again).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportHistory.Para.TableName()].Columns.Add(MobileOrderReportHistory.Para.sent_again); }
            if (x_oTableSet.Fields(MobileOrderReportHistory.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportHistory.Para.TableName()].Columns.Add(MobileOrderReportHistory.Para.mid); }
            if (x_oTableSet.Fields(MobileOrderReportHistory.Para.email_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportHistory.Para.TableName()].Columns.Add(MobileOrderReportHistory.Para.email_date); }
            if (x_oTableSet.Fields(MobileOrderReportHistory.Para.retrieve_cnt).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportHistory.Para.TableName()].Columns.Add(MobileOrderReportHistory.Para.retrieve_cnt); }
            if (x_oTableSet.Fields(MobileOrderReportHistory.Para.fs_sent_again_retrieve_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportHistory.Para.TableName()].Columns.Add(MobileOrderReportHistory.Para.fs_sent_again_retrieve_date); }
            if (x_oTableSet.Fields(MobileOrderReportHistory.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportHistory.Para.TableName()].Columns.Add(MobileOrderReportHistory.Para.cdate); }
            if (x_oTableSet.Fields(MobileOrderReportHistory.Para.retrieve_sn).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportHistory.Para.TableName()].Columns.Add(MobileOrderReportHistory.Para.retrieve_sn); }
            if (x_oTableSet.Fields(MobileOrderReportHistory.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportHistory.Para.TableName()].Columns.Add(MobileOrderReportHistory.Para.cid); }
            if (x_oTableSet.Fields(MobileOrderReportHistory.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportHistory.Para.TableName()].Columns.Add(MobileOrderReportHistory.Para.did); }
            if (x_oTableSet.Fields(MobileOrderReportHistory.Para.sent_again_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportHistory.Para.TableName()].Columns.Add(MobileOrderReportHistory.Para.sent_again_date); }
            if (x_oTableSet.Fields(MobileOrderReportHistory.Para.idd_vas).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportHistory.Para.TableName()].Columns.Add(MobileOrderReportHistory.Para.idd_vas); }
            if (x_oTableSet.Fields(MobileOrderReportHistory.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportHistory.Para.TableName()].Columns.Add(MobileOrderReportHistory.Para.active); }
            if (x_oTableSet.Fields(MobileOrderReportHistory.Para.fallout_reason).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportHistory.Para.TableName()].Columns.Add(MobileOrderReportHistory.Para.fallout_reason); }
            if (x_oTableSet.Fields(MobileOrderReportHistory.Para.fallout_remark).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportHistory.Para.TableName()].Columns.Add(MobileOrderReportHistory.Para.fallout_remark); }
            if (x_oTableSet.Fields(MobileOrderReportHistory.Para.fallout_main_category).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportHistory.Para.TableName()].Columns.Add(MobileOrderReportHistory.Para.fallout_main_category); }
            if (x_oTableSet.Fields(MobileOrderReportHistory.Para.report_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportHistory.Para.TableName()].Columns.Add(MobileOrderReportHistory.Para.report_type); }
            if (x_oTableSet.Fields(MobileOrderReportHistory.Para.fallout_reply).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportHistory.Para.TableName()].Columns.Add(MobileOrderReportHistory.Para.fallout_reply); }
            if (x_oTableSet.Fields(MobileOrderReportHistory.Para.reactive_sn).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportHistory.Para.TableName()].Columns.Add(MobileOrderReportHistory.Para.reactive_sn); }
            if (x_oTableSet.Fields(MobileOrderReportHistory.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportHistory.Para.TableName()].Columns.Add(MobileOrderReportHistory.Para.ddate); }
            if (x_oTableSet.Fields(MobileOrderReportHistory.Para.ext_place_tel).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportHistory.Para.TableName()].Columns.Add(MobileOrderReportHistory.Para.ext_place_tel); }
            if (x_oTableSet.Fields(MobileOrderReportHistory.Para.reactive_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportHistory.Para.TableName()].Columns.Add(MobileOrderReportHistory.Para.reactive_date); }
            if (x_oTableSet.Fields(MobileOrderReportHistory.Para.gw_retrieve_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportHistory.Para.TableName()].Columns.Add(MobileOrderReportHistory.Para.gw_retrieve_date); }
            if (x_oTableSet.Fields(MobileOrderReportHistory.Para.rec_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportHistory.Para.TableName()].Columns.Add(MobileOrderReportHistory.Para.rec_no); }
            if (x_oTableSet.Fields(MobileOrderReportHistory.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportHistory.Para.TableName()].Columns.Add(MobileOrderReportHistory.Para.order_id); }
            if (x_oTableSet.Fields(MobileOrderReportHistory.Para.py_sent_again_retrieve_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportHistory.Para.TableName()].Columns.Add(MobileOrderReportHistory.Para.py_sent_again_retrieve_date); }
            if (x_oTableSet.Fields(MobileOrderReportHistory.Para.retrieve_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportHistory.Para.TableName()].Columns.Add(MobileOrderReportHistory.Para.retrieve_date); }
            if (x_oMobileOrderReportHistory != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[MobileOrderReportHistory.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(MobileOrderReportHistory.Para.order_status).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportHistory.Para.order_status] = x_oMobileOrderReportHistory.GetOrder_status(); }
                if (x_oTableSet.Fields(MobileOrderReportHistory.Para.gw_retrieve_sn).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportHistory.Para.gw_retrieve_sn] = x_oMobileOrderReportHistory.GetGw_retrieve_sn(); }
                if (x_oTableSet.Fields(MobileOrderReportHistory.Para.sent_again).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportHistory.Para.sent_again] = x_oMobileOrderReportHistory.GetSent_again(); }
                if (x_oTableSet.Fields(MobileOrderReportHistory.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportHistory.Para.mid] = x_oMobileOrderReportHistory.GetMid(); }
                if (x_oTableSet.Fields(MobileOrderReportHistory.Para.email_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportHistory.Para.email_date] = x_oMobileOrderReportHistory.GetEmail_date(); }
                if (x_oTableSet.Fields(MobileOrderReportHistory.Para.retrieve_cnt).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportHistory.Para.retrieve_cnt] = x_oMobileOrderReportHistory.GetRetrieve_cnt(); }
                if (x_oTableSet.Fields(MobileOrderReportHistory.Para.fs_sent_again_retrieve_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportHistory.Para.fs_sent_again_retrieve_date] = x_oMobileOrderReportHistory.GetFs_sent_again_retrieve_date(); }
                if (x_oTableSet.Fields(MobileOrderReportHistory.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportHistory.Para.cdate] = x_oMobileOrderReportHistory.GetCdate(); }
                if (x_oTableSet.Fields(MobileOrderReportHistory.Para.retrieve_sn).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportHistory.Para.retrieve_sn] = x_oMobileOrderReportHistory.GetRetrieve_sn(); }
                if (x_oTableSet.Fields(MobileOrderReportHistory.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportHistory.Para.cid] = x_oMobileOrderReportHistory.GetCid(); }
                if (x_oTableSet.Fields(MobileOrderReportHistory.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportHistory.Para.did] = x_oMobileOrderReportHistory.GetDid(); }
                if (x_oTableSet.Fields(MobileOrderReportHistory.Para.sent_again_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportHistory.Para.sent_again_date] = x_oMobileOrderReportHistory.GetSent_again_date(); }
                if (x_oTableSet.Fields(MobileOrderReportHistory.Para.idd_vas).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportHistory.Para.idd_vas] = x_oMobileOrderReportHistory.GetIdd_vas(); }
                if (x_oTableSet.Fields(MobileOrderReportHistory.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportHistory.Para.active] = x_oMobileOrderReportHistory.GetActive(); }
                if (x_oTableSet.Fields(MobileOrderReportHistory.Para.fallout_reason).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportHistory.Para.fallout_reason] = x_oMobileOrderReportHistory.GetFallout_reason(); }
                if (x_oTableSet.Fields(MobileOrderReportHistory.Para.fallout_remark).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportHistory.Para.fallout_remark] = x_oMobileOrderReportHistory.GetFallout_remark(); }
                if (x_oTableSet.Fields(MobileOrderReportHistory.Para.fallout_main_category).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportHistory.Para.fallout_main_category] = x_oMobileOrderReportHistory.GetFallout_main_category(); }
                if (x_oTableSet.Fields(MobileOrderReportHistory.Para.report_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportHistory.Para.report_type] = x_oMobileOrderReportHistory.GetReport_type(); }
                if (x_oTableSet.Fields(MobileOrderReportHistory.Para.fallout_reply).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportHistory.Para.fallout_reply] = x_oMobileOrderReportHistory.GetFallout_reply(); }
                if (x_oTableSet.Fields(MobileOrderReportHistory.Para.reactive_sn).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportHistory.Para.reactive_sn] = x_oMobileOrderReportHistory.GetReactive_sn(); }
                if (x_oTableSet.Fields(MobileOrderReportHistory.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportHistory.Para.ddate] = x_oMobileOrderReportHistory.GetDdate(); }
                if (x_oTableSet.Fields(MobileOrderReportHistory.Para.ext_place_tel).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportHistory.Para.ext_place_tel] = x_oMobileOrderReportHistory.GetExt_place_tel(); }
                if (x_oTableSet.Fields(MobileOrderReportHistory.Para.reactive_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportHistory.Para.reactive_date] = x_oMobileOrderReportHistory.GetReactive_date(); }
                if (x_oTableSet.Fields(MobileOrderReportHistory.Para.gw_retrieve_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportHistory.Para.gw_retrieve_date] = x_oMobileOrderReportHistory.GetGw_retrieve_date(); }
                if (x_oTableSet.Fields(MobileOrderReportHistory.Para.rec_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportHistory.Para.rec_no] = x_oMobileOrderReportHistory.GetRec_no(); }
                if (x_oTableSet.Fields(MobileOrderReportHistory.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportHistory.Para.order_id] = x_oMobileOrderReportHistory.GetOrder_id(); }
                if (x_oTableSet.Fields(MobileOrderReportHistory.Para.py_sent_again_retrieve_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportHistory.Para.py_sent_again_retrieve_date] = x_oMobileOrderReportHistory.GetPy_sent_again_retrieve_date(); }
                if (x_oTableSet.Fields(MobileOrderReportHistory.Para.retrieve_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportHistory.Para.retrieve_date] = x_oMobileOrderReportHistory.GetRetrieve_date(); }
                _oDSet.Tables[MobileOrderReportHistory.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(MobileOrderReportHistoryInfo x_oTableSet)
        {
            return MobileOrderReportHistoryBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return MobileOrderReportHistoryBal.ToEmptyDataSetProcess(MobileOrderReportHistoryInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(MobileOrderReportHistoryInfo x_oTableSet)
        {
            return MobileOrderReportHistoryBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(MobileOrderReportHistory x_oMobileOrderReportHistory, MobileOrderReportHistoryInfo x_oTableSet)
        {
            return MobileOrderReportHistoryBal.GetDataSet(null, null, x_oTableSet).Tables[MobileOrderReportHistory.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(MobileOrderReportHistory x_oMobileOrderReportHistory)
        {
            return MobileOrderReportHistoryBal.GetDataSet(x_oMobileOrderReportHistory, null, MobileOrderReportHistoryInfoDLL.CreateInfoInstanceObject()).Tables[MobileOrderReportHistory.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            return Row(x_oTable, x_oDB,x_iMid,MobileOrderReportHistoryInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid, MobileOrderReportHistoryInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iMid, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid,MobileOrderReportHistoryInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderReportHistoryInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [MobileOrderReportHistory].[order_status] AS MOBILEORDERREPORTHISTORY_ORDER_STATUS,[MobileOrderReportHistory].[gw_retrieve_sn] AS MOBILEORDERREPORTHISTORY_GW_RETRIEVE_SN,[MobileOrderReportHistory].[sent_again] AS MOBILEORDERREPORTHISTORY_SENT_AGAIN,[MobileOrderReportHistory].[mid] AS MOBILEORDERREPORTHISTORY_MID,[MobileOrderReportHistory].[email_date] AS MOBILEORDERREPORTHISTORY_EMAIL_DATE,[MobileOrderReportHistory].[retrieve_cnt] AS MOBILEORDERREPORTHISTORY_RETRIEVE_CNT,[MobileOrderReportHistory].[fs_sent_again_retrieve_date] AS MOBILEORDERREPORTHISTORY_FS_SENT_AGAIN_RETRIEVE_DATE,[MobileOrderReportHistory].[cdate] AS MOBILEORDERREPORTHISTORY_CDATE,[MobileOrderReportHistory].[retrieve_sn] AS MOBILEORDERREPORTHISTORY_RETRIEVE_SN,[MobileOrderReportHistory].[cid] AS MOBILEORDERREPORTHISTORY_CID,[MobileOrderReportHistory].[did] AS MOBILEORDERREPORTHISTORY_DID,[MobileOrderReportHistory].[sent_again_date] AS MOBILEORDERREPORTHISTORY_SENT_AGAIN_DATE,[MobileOrderReportHistory].[idd_vas] AS MOBILEORDERREPORTHISTORY_IDD_VAS,[MobileOrderReportHistory].[active] AS MOBILEORDERREPORTHISTORY_ACTIVE,[MobileOrderReportHistory].[fallout_reason] AS MOBILEORDERREPORTHISTORY_FALLOUT_REASON,[MobileOrderReportHistory].[fallout_remark] AS MOBILEORDERREPORTHISTORY_FALLOUT_REMARK,[MobileOrderReportHistory].[fallout_main_category] AS MOBILEORDERREPORTHISTORY_FALLOUT_MAIN_CATEGORY,[MobileOrderReportHistory].[gw_retrieve_date] AS MOBILEORDERREPORTHISTORY_GW_RETRIEVE_DATE,[MobileOrderReportHistory].[report_type] AS MOBILEORDERREPORTHISTORY_REPORT_TYPE,[MobileOrderReportHistory].[reactive_sn] AS MOBILEORDERREPORTHISTORY_REACTIVE_SN,[MobileOrderReportHistory].[ddate] AS MOBILEORDERREPORTHISTORY_DDATE,[MobileOrderReportHistory].[ext_place_tel] AS MOBILEORDERREPORTHISTORY_EXT_PLACE_TEL,[MobileOrderReportHistory].[reactive_date] AS MOBILEORDERREPORTHISTORY_REACTIVE_DATE,[MobileOrderReportHistory].[order_id] AS MOBILEORDERREPORTHISTORY_ORDER_ID,[MobileOrderReportHistory].[rec_no] AS MOBILEORDERREPORTHISTORY_REC_NO,[MobileOrderReportHistory].[retrieve_date] AS MOBILEORDERREPORTHISTORY_RETRIEVE_DATE,[MobileOrderReportHistory].[py_sent_again_retrieve_date] AS MOBILEORDERREPORTHISTORY_PY_SENT_AGAIN_RETRIEVE_DATE,[MobileOrderReportHistory].[fallout_reply] AS MOBILEORDERREPORTHISTORY_FALLOUT_REPLY  FROM  [MobileOrderReportHistory]  WHERE  [MobileOrderReportHistory].[mid] = \'"+x_iMid.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportHistory]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportHistory]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(MobileOrderReportHistory.Para.order_status).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_ORDER_STATUS"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportHistory.Para.order_status).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.order_status).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTHISTORY_ORDER_STATUS"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.order_status).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportHistory.Para.gw_retrieve_sn).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_GW_RETRIEVE_SN"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportHistory.Para.gw_retrieve_sn).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.gw_retrieve_sn).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTHISTORY_GW_RETRIEVE_SN"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.gw_retrieve_sn).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportHistory.Para.sent_again).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_SENT_AGAIN"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportHistory.Para.sent_again).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.sent_again).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTHISTORY_SENT_AGAIN"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.sent_again).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportHistory.Para.mid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_MID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportHistory.Para.mid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.mid).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTHISTORY_MID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.mid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportHistory.Para.email_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_EMAIL_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportHistory.Para.email_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.email_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_EMAIL_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.email_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportHistory.Para.retrieve_cnt).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_RETRIEVE_CNT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportHistory.Para.retrieve_cnt).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.retrieve_cnt).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTHISTORY_RETRIEVE_CNT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.retrieve_cnt).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportHistory.Para.fs_sent_again_retrieve_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_FS_SENT_AGAIN_RETRIEVE_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportHistory.Para.fs_sent_again_retrieve_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.fs_sent_again_retrieve_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_FS_SENT_AGAIN_RETRIEVE_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.fs_sent_again_retrieve_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportHistory.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportHistory.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportHistory.Para.retrieve_sn).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_RETRIEVE_SN"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportHistory.Para.retrieve_sn).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.retrieve_sn).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTHISTORY_RETRIEVE_SN"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.retrieve_sn).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportHistory.Para.cid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportHistory.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.cid).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTHISTORY_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.cid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportHistory.Para.did).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportHistory.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.did).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTHISTORY_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.did).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportHistory.Para.sent_again_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_SENT_AGAIN_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportHistory.Para.sent_again_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.sent_again_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_SENT_AGAIN_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.sent_again_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportHistory.Para.idd_vas).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_IDD_VAS"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportHistory.Para.idd_vas).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.idd_vas).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTHISTORY_IDD_VAS"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.idd_vas).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportHistory.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportHistory.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTHISTORY_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportHistory.Para.fallout_reason).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_FALLOUT_REASON"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportHistory.Para.fallout_reason).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.fallout_reason).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTHISTORY_FALLOUT_REASON"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.fallout_reason).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportHistory.Para.fallout_remark).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_FALLOUT_REMARK"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportHistory.Para.fallout_remark).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.fallout_remark).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTHISTORY_FALLOUT_REMARK"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.fallout_remark).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportHistory.Para.fallout_main_category).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_FALLOUT_MAIN_CATEGORY"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportHistory.Para.fallout_main_category).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.fallout_main_category).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTHISTORY_FALLOUT_MAIN_CATEGORY"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.fallout_main_category).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportHistory.Para.gw_retrieve_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_GW_RETRIEVE_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportHistory.Para.gw_retrieve_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.gw_retrieve_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_GW_RETRIEVE_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.gw_retrieve_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportHistory.Para.report_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_REPORT_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportHistory.Para.report_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.report_type).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTHISTORY_REPORT_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.report_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportHistory.Para.reactive_sn).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_REACTIVE_SN"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportHistory.Para.reactive_sn).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.reactive_sn).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTHISTORY_REACTIVE_SN"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.reactive_sn).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportHistory.Para.ddate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportHistory.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.ddate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportHistory.Para.ext_place_tel).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_EXT_PLACE_TEL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportHistory.Para.ext_place_tel).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.ext_place_tel).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTHISTORY_EXT_PLACE_TEL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.ext_place_tel).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportHistory.Para.reactive_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_REACTIVE_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportHistory.Para.reactive_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.reactive_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_REACTIVE_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.reactive_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportHistory.Para.order_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_ORDER_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportHistory.Para.order_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.order_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTHISTORY_ORDER_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.order_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportHistory.Para.rec_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_REC_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportHistory.Para.rec_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.rec_no).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTHISTORY_REC_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.rec_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportHistory.Para.retrieve_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_RETRIEVE_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportHistory.Para.retrieve_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.retrieve_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_RETRIEVE_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.retrieve_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportHistory.Para.py_sent_again_retrieve_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_PY_SENT_AGAIN_RETRIEVE_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportHistory.Para.py_sent_again_retrieve_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.py_sent_again_retrieve_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_PY_SENT_AGAIN_RETRIEVE_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.py_sent_again_retrieve_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportHistory.Para.fallout_reply).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_FALLOUT_REPLY"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportHistory.Para.fallout_reply).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.fallout_reply).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTHISTORY_FALLOUT_REPLY"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportHistory.Para.fallout_reply).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,MobileOrderReportHistory x_oMobileOrderReportHistoryRow)
        {
            return SetByDataSetRowProc(x_iROW, MobileOrderReportHistory.Para.TableName(), x_oDataSet,x_oMobileOrderReportHistoryRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderReportHistory x_oMobileOrderReportHistoryRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oMobileOrderReportHistoryRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderReportHistory x_oMobileOrderReportHistoryRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                MobileOrderReportHistoryInfo _oTableSet=MobileOrderReportHistoryInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportHistory.Para.order_status).AliasName))
                    x_oMobileOrderReportHistoryRow.order_status = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportHistory.Para.order_status).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportHistory.Para.gw_retrieve_sn).AliasName))
                    x_oMobileOrderReportHistoryRow.gw_retrieve_sn = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportHistory.Para.gw_retrieve_sn).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportHistory.Para.sent_again).AliasName))
                    x_oMobileOrderReportHistoryRow.sent_again = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportHistory.Para.sent_again).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportHistory.Para.mid).AliasName))
                    x_oMobileOrderReportHistoryRow.mid = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportHistory.Para.mid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportHistory.Para.email_date).AliasName))
                    x_oMobileOrderReportHistoryRow.email_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportHistory.Para.email_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportHistory.Para.retrieve_cnt).AliasName))
                    x_oMobileOrderReportHistoryRow.retrieve_cnt = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportHistory.Para.retrieve_cnt).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportHistory.Para.fs_sent_again_retrieve_date).AliasName))
                    x_oMobileOrderReportHistoryRow.fs_sent_again_retrieve_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportHistory.Para.fs_sent_again_retrieve_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportHistory.Para.cdate).AliasName))
                    x_oMobileOrderReportHistoryRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportHistory.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportHistory.Para.retrieve_sn).AliasName))
                    x_oMobileOrderReportHistoryRow.retrieve_sn = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportHistory.Para.retrieve_sn).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportHistory.Para.cid).AliasName))
                    x_oMobileOrderReportHistoryRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportHistory.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportHistory.Para.did).AliasName))
                    x_oMobileOrderReportHistoryRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportHistory.Para.did).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportHistory.Para.sent_again_date).AliasName))
                    x_oMobileOrderReportHistoryRow.sent_again_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportHistory.Para.sent_again_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportHistory.Para.idd_vas).AliasName))
                    x_oMobileOrderReportHistoryRow.idd_vas = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportHistory.Para.idd_vas).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportHistory.Para.active).AliasName))
                    x_oMobileOrderReportHistoryRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportHistory.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportHistory.Para.fallout_reason).AliasName))
                    x_oMobileOrderReportHistoryRow.fallout_reason = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportHistory.Para.fallout_reason).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportHistory.Para.fallout_remark).AliasName))
                    x_oMobileOrderReportHistoryRow.fallout_remark = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportHistory.Para.fallout_remark).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportHistory.Para.fallout_main_category).AliasName))
                    x_oMobileOrderReportHistoryRow.fallout_main_category = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportHistory.Para.fallout_main_category).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportHistory.Para.report_type).AliasName))
                    x_oMobileOrderReportHistoryRow.report_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportHistory.Para.report_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportHistory.Para.fallout_reply).AliasName))
                    x_oMobileOrderReportHistoryRow.fallout_reply = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportHistory.Para.fallout_reply).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportHistory.Para.reactive_sn).AliasName))
                    x_oMobileOrderReportHistoryRow.reactive_sn = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportHistory.Para.reactive_sn).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportHistory.Para.ddate).AliasName))
                    x_oMobileOrderReportHistoryRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportHistory.Para.ddate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportHistory.Para.ext_place_tel).AliasName))
                    x_oMobileOrderReportHistoryRow.ext_place_tel = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportHistory.Para.ext_place_tel).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportHistory.Para.reactive_date).AliasName))
                    x_oMobileOrderReportHistoryRow.reactive_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportHistory.Para.reactive_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportHistory.Para.gw_retrieve_date).AliasName))
                    x_oMobileOrderReportHistoryRow.gw_retrieve_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportHistory.Para.gw_retrieve_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportHistory.Para.rec_no).AliasName))
                    x_oMobileOrderReportHistoryRow.rec_no = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportHistory.Para.rec_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportHistory.Para.order_id).AliasName))
                    x_oMobileOrderReportHistoryRow.order_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportHistory.Para.order_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportHistory.Para.py_sent_again_retrieve_date).AliasName))
                    x_oMobileOrderReportHistoryRow.py_sent_again_retrieve_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportHistory.Para.py_sent_again_retrieve_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportHistory.Para.retrieve_date).AliasName))
                    x_oMobileOrderReportHistoryRow.retrieve_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportHistory.Para.retrieve_date).AliasName];
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
            return MobileOrderReportHistoryRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static MobileOrderReportHistoryEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return MobileOrderReportHistoryRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static MobileOrderReportHistoryEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return MobileOrderReportHistoryRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderReportHistoryRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderReportHistoryRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderReportHistoryRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sOrder_status,string x_sGw_retrieve_sn,global::System.Nullable<int> x_iSent_again,global::System.Nullable<DateTime> x_dEmail_date,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dFs_sent_again_retrieve_date,global::System.Nullable<DateTime> x_dCdate,string x_sRetrieve_sn,string x_sCid,string x_sDid,global::System.Nullable<DateTime> x_dSent_again_date,string x_sIdd_vas,global::System.Nullable<bool> x_bActive,string x_sFallout_reason,string x_sFallout_remark,string x_sFallout_main_category,string x_sReport_type,string x_sFallout_reply,string x_sReactive_sn,global::System.Nullable<DateTime> x_dDdate,string x_sExt_place_tel,global::System.Nullable<DateTime> x_dReactive_date,global::System.Nullable<DateTime> x_dGw_retrieve_date,global::System.Nullable<int> x_iRec_no,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dPy_sent_again_retrieve_date,global::System.Nullable<DateTime> x_dRetrieve_date)
        {
            return MobileOrderReportHistoryRepository.Insert(x_oDB, x_sOrder_status,x_sGw_retrieve_sn,x_iSent_again,x_dEmail_date,x_iRetrieve_cnt,x_dFs_sent_again_retrieve_date,x_dCdate,x_sRetrieve_sn,x_sCid,x_sDid,x_dSent_again_date,x_sIdd_vas,x_bActive,x_sFallout_reason,x_sFallout_remark,x_sFallout_main_category,x_sReport_type,x_sFallout_reply,x_sReactive_sn,x_dDdate,x_sExt_place_tel,x_dReactive_date,x_dGw_retrieve_date,x_iRec_no,x_iOrder_id,x_dPy_sent_again_retrieve_date,x_dRetrieve_date);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderReportHistory x_oMobileOrderReportHistory)
        {
            return MobileOrderReportHistoryRepository.InsertWithOutLastID(x_oDB,x_oMobileOrderReportHistory);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sOrder_status,string x_sGw_retrieve_sn,global::System.Nullable<int> x_iSent_again,global::System.Nullable<DateTime> x_dEmail_date,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dFs_sent_again_retrieve_date,global::System.Nullable<DateTime> x_dCdate,string x_sRetrieve_sn,string x_sCid,string x_sDid,global::System.Nullable<DateTime> x_dSent_again_date,string x_sIdd_vas,global::System.Nullable<bool> x_bActive,string x_sFallout_reason,string x_sFallout_remark,string x_sFallout_main_category,string x_sReport_type,string x_sFallout_reply,string x_sReactive_sn,global::System.Nullable<DateTime> x_dDdate,string x_sExt_place_tel,global::System.Nullable<DateTime> x_dReactive_date,global::System.Nullable<DateTime> x_dGw_retrieve_date,global::System.Nullable<int> x_iRec_no,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dPy_sent_again_retrieve_date,global::System.Nullable<DateTime> x_dRetrieve_date)
        {
            return MobileOrderReportHistoryRepository.InsertReturnLastID_SP(x_oDB,x_sOrder_status,x_sGw_retrieve_sn,x_iSent_again,x_dEmail_date,x_iRetrieve_cnt,x_dFs_sent_again_retrieve_date,x_dCdate,x_sRetrieve_sn,x_sCid,x_sDid,x_dSent_again_date,x_sIdd_vas,x_bActive,x_sFallout_reason,x_sFallout_remark,x_sFallout_main_category,x_sReport_type,x_sFallout_reply,x_sReactive_sn,x_dDdate,x_sExt_place_tel,x_dReactive_date,x_dGw_retrieve_date,x_iRec_no,x_iOrder_id,x_dPy_sent_again_retrieve_date,x_dRetrieve_date);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderReportHistory x_oMobileOrderReportHistory)
        {
            return MobileOrderReportHistoryRepository.InsertReturnLastID_SP(x_oDB,x_oMobileOrderReportHistory);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return MobileOrderReportHistoryRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderReportHistoryRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            return MobileOrderReportHistoryRepository.Delete(x_oDB, x_iMid);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(MobileOrderReportHistory x_oMobileOrderReportHistoryRow){
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


