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
///-- Description:	<Description,Table :[MobileOrderReport],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderReport] Business layer
    /// </summary>
    
    public abstract class MobileOrderReportBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public MobileOrderReportBalBase(){
        }
        ~MobileOrderReportBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderReport x_oMobileOrderReport)
        {
            return GetDataSet(x_oMobileOrderReport,null,MobileOrderReportInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderReport x_oMobileOrderReport,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oMobileOrderReport,x_oMergeDSet,MobileOrderReportInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderReport x_oMobileOrderReport,MobileOrderReportInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderReport,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderReport x_oMobileOrderReport,global::System.Data.DataSet x_oMergeDSet,MobileOrderReportInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderReport,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(MobileOrderReport x_oMobileOrderReport,global::System.Data.DataSet x_oMergeDSet,MobileOrderReportInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderReportInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(MobileOrderReport.Para.TableName());
            if (x_oTableSet.Fields(MobileOrderReport.Para.order_status).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReport.Para.TableName()].Columns.Add(MobileOrderReport.Para.order_status); }
            if (x_oTableSet.Fields(MobileOrderReport.Para.gw_retrieve_sn).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReport.Para.TableName()].Columns.Add(MobileOrderReport.Para.gw_retrieve_sn); }
            if (x_oTableSet.Fields(MobileOrderReport.Para.sent_again).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReport.Para.TableName()].Columns.Add(MobileOrderReport.Para.sent_again); }
            if (x_oTableSet.Fields(MobileOrderReport.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReport.Para.TableName()].Columns.Add(MobileOrderReport.Para.mid); }
            if (x_oTableSet.Fields(MobileOrderReport.Para.email_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReport.Para.TableName()].Columns.Add(MobileOrderReport.Para.email_date); }
            if (x_oTableSet.Fields(MobileOrderReport.Para.retrieve_cnt).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReport.Para.TableName()].Columns.Add(MobileOrderReport.Para.retrieve_cnt); }
            if (x_oTableSet.Fields(MobileOrderReport.Para.fs_sent_again_retrieve_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReport.Para.TableName()].Columns.Add(MobileOrderReport.Para.fs_sent_again_retrieve_date); }
            if (x_oTableSet.Fields(MobileOrderReport.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReport.Para.TableName()].Columns.Add(MobileOrderReport.Para.cdate); }
            if (x_oTableSet.Fields(MobileOrderReport.Para.retrieve_sn).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReport.Para.TableName()].Columns.Add(MobileOrderReport.Para.retrieve_sn); }
            if (x_oTableSet.Fields(MobileOrderReport.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReport.Para.TableName()].Columns.Add(MobileOrderReport.Para.cid); }
            if (x_oTableSet.Fields(MobileOrderReport.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReport.Para.TableName()].Columns.Add(MobileOrderReport.Para.did); }
            if (x_oTableSet.Fields(MobileOrderReport.Para.sent_again_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReport.Para.TableName()].Columns.Add(MobileOrderReport.Para.sent_again_date); }
            if (x_oTableSet.Fields(MobileOrderReport.Para.idd_vas).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReport.Para.TableName()].Columns.Add(MobileOrderReport.Para.idd_vas); }
            if (x_oTableSet.Fields(MobileOrderReport.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReport.Para.TableName()].Columns.Add(MobileOrderReport.Para.active); }
            if (x_oTableSet.Fields(MobileOrderReport.Para.fallout_reason).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReport.Para.TableName()].Columns.Add(MobileOrderReport.Para.fallout_reason); }
            if (x_oTableSet.Fields(MobileOrderReport.Para.fallout_remark).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReport.Para.TableName()].Columns.Add(MobileOrderReport.Para.fallout_remark); }
            if (x_oTableSet.Fields(MobileOrderReport.Para.fallout_main_category).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReport.Para.TableName()].Columns.Add(MobileOrderReport.Para.fallout_main_category); }
            if (x_oTableSet.Fields(MobileOrderReport.Para.report_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReport.Para.TableName()].Columns.Add(MobileOrderReport.Para.report_type); }
            if (x_oTableSet.Fields(MobileOrderReport.Para.fallout_reply).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReport.Para.TableName()].Columns.Add(MobileOrderReport.Para.fallout_reply); }
            if (x_oTableSet.Fields(MobileOrderReport.Para.reactive_sn).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReport.Para.TableName()].Columns.Add(MobileOrderReport.Para.reactive_sn); }
            if (x_oTableSet.Fields(MobileOrderReport.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReport.Para.TableName()].Columns.Add(MobileOrderReport.Para.ddate); }
            if (x_oTableSet.Fields(MobileOrderReport.Para.ext_place_tel).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReport.Para.TableName()].Columns.Add(MobileOrderReport.Para.ext_place_tel); }
            if (x_oTableSet.Fields(MobileOrderReport.Para.reactive_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReport.Para.TableName()].Columns.Add(MobileOrderReport.Para.reactive_date); }
            if (x_oTableSet.Fields(MobileOrderReport.Para.gw_retrieve_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReport.Para.TableName()].Columns.Add(MobileOrderReport.Para.gw_retrieve_date); }
            if (x_oTableSet.Fields(MobileOrderReport.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReport.Para.TableName()].Columns.Add(MobileOrderReport.Para.order_id); }
            if (x_oTableSet.Fields(MobileOrderReport.Para.py_sent_again_retrieve_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReport.Para.TableName()].Columns.Add(MobileOrderReport.Para.py_sent_again_retrieve_date); }
            if (x_oTableSet.Fields(MobileOrderReport.Para.retrieve_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReport.Para.TableName()].Columns.Add(MobileOrderReport.Para.retrieve_date); }
            if (x_oMobileOrderReport != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[MobileOrderReport.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(MobileOrderReport.Para.order_status).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReport.Para.order_status] = x_oMobileOrderReport.GetOrder_status(); }
                if (x_oTableSet.Fields(MobileOrderReport.Para.gw_retrieve_sn).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReport.Para.gw_retrieve_sn] = x_oMobileOrderReport.GetGw_retrieve_sn(); }
                if (x_oTableSet.Fields(MobileOrderReport.Para.sent_again).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReport.Para.sent_again] = x_oMobileOrderReport.GetSent_again(); }
                if (x_oTableSet.Fields(MobileOrderReport.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReport.Para.mid] = x_oMobileOrderReport.GetMid(); }
                if (x_oTableSet.Fields(MobileOrderReport.Para.email_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReport.Para.email_date] = x_oMobileOrderReport.GetEmail_date(); }
                if (x_oTableSet.Fields(MobileOrderReport.Para.retrieve_cnt).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReport.Para.retrieve_cnt] = x_oMobileOrderReport.GetRetrieve_cnt(); }
                if (x_oTableSet.Fields(MobileOrderReport.Para.fs_sent_again_retrieve_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReport.Para.fs_sent_again_retrieve_date] = x_oMobileOrderReport.GetFs_sent_again_retrieve_date(); }
                if (x_oTableSet.Fields(MobileOrderReport.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReport.Para.cdate] = x_oMobileOrderReport.GetCdate(); }
                if (x_oTableSet.Fields(MobileOrderReport.Para.retrieve_sn).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReport.Para.retrieve_sn] = x_oMobileOrderReport.GetRetrieve_sn(); }
                if (x_oTableSet.Fields(MobileOrderReport.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReport.Para.cid] = x_oMobileOrderReport.GetCid(); }
                if (x_oTableSet.Fields(MobileOrderReport.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReport.Para.did] = x_oMobileOrderReport.GetDid(); }
                if (x_oTableSet.Fields(MobileOrderReport.Para.sent_again_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReport.Para.sent_again_date] = x_oMobileOrderReport.GetSent_again_date(); }
                if (x_oTableSet.Fields(MobileOrderReport.Para.idd_vas).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReport.Para.idd_vas] = x_oMobileOrderReport.GetIdd_vas(); }
                if (x_oTableSet.Fields(MobileOrderReport.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReport.Para.active] = x_oMobileOrderReport.GetActive(); }
                if (x_oTableSet.Fields(MobileOrderReport.Para.fallout_reason).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReport.Para.fallout_reason] = x_oMobileOrderReport.GetFallout_reason(); }
                if (x_oTableSet.Fields(MobileOrderReport.Para.fallout_remark).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReport.Para.fallout_remark] = x_oMobileOrderReport.GetFallout_remark(); }
                if (x_oTableSet.Fields(MobileOrderReport.Para.fallout_main_category).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReport.Para.fallout_main_category] = x_oMobileOrderReport.GetFallout_main_category(); }
                if (x_oTableSet.Fields(MobileOrderReport.Para.report_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReport.Para.report_type] = x_oMobileOrderReport.GetReport_type(); }
                if (x_oTableSet.Fields(MobileOrderReport.Para.fallout_reply).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReport.Para.fallout_reply] = x_oMobileOrderReport.GetFallout_reply(); }
                if (x_oTableSet.Fields(MobileOrderReport.Para.reactive_sn).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReport.Para.reactive_sn] = x_oMobileOrderReport.GetReactive_sn(); }
                if (x_oTableSet.Fields(MobileOrderReport.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReport.Para.ddate] = x_oMobileOrderReport.GetDdate(); }
                if (x_oTableSet.Fields(MobileOrderReport.Para.ext_place_tel).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReport.Para.ext_place_tel] = x_oMobileOrderReport.GetExt_place_tel(); }
                if (x_oTableSet.Fields(MobileOrderReport.Para.reactive_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReport.Para.reactive_date] = x_oMobileOrderReport.GetReactive_date(); }
                if (x_oTableSet.Fields(MobileOrderReport.Para.gw_retrieve_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReport.Para.gw_retrieve_date] = x_oMobileOrderReport.GetGw_retrieve_date(); }
                if (x_oTableSet.Fields(MobileOrderReport.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReport.Para.order_id] = x_oMobileOrderReport.GetOrder_id(); }
                if (x_oTableSet.Fields(MobileOrderReport.Para.py_sent_again_retrieve_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReport.Para.py_sent_again_retrieve_date] = x_oMobileOrderReport.GetPy_sent_again_retrieve_date(); }
                if (x_oTableSet.Fields(MobileOrderReport.Para.retrieve_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReport.Para.retrieve_date] = x_oMobileOrderReport.GetRetrieve_date(); }
                _oDSet.Tables[MobileOrderReport.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(MobileOrderReportInfo x_oTableSet)
        {
            return MobileOrderReportBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return MobileOrderReportBal.ToEmptyDataSetProcess(MobileOrderReportInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(MobileOrderReportInfo x_oTableSet)
        {
            return MobileOrderReportBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(MobileOrderReport x_oMobileOrderReport, MobileOrderReportInfo x_oTableSet)
        {
            return MobileOrderReportBal.GetDataSet(null, null, x_oTableSet).Tables[MobileOrderReport.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(MobileOrderReport x_oMobileOrderReport)
        {
            return MobileOrderReportBal.GetDataSet(x_oMobileOrderReport, null, MobileOrderReportInfoDLL.CreateInfoInstanceObject()).Tables[MobileOrderReport.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            return Row(x_oTable, x_oDB,x_iMid,MobileOrderReportInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid, MobileOrderReportInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iMid, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid,MobileOrderReportInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderReportInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [MobileOrderReport].[order_status] AS MOBILEORDERREPORT_ORDER_STATUS,[MobileOrderReport].[gw_retrieve_sn] AS MOBILEORDERREPORT_GW_RETRIEVE_SN,[MobileOrderReport].[sent_again] AS MOBILEORDERREPORT_SENT_AGAIN,[MobileOrderReport].[mid] AS MOBILEORDERREPORT_MID,[MobileOrderReport].[email_date] AS MOBILEORDERREPORT_EMAIL_DATE,[MobileOrderReport].[retrieve_cnt] AS MOBILEORDERREPORT_RETRIEVE_CNT,[MobileOrderReport].[fs_sent_again_retrieve_date] AS MOBILEORDERREPORT_FS_SENT_AGAIN_RETRIEVE_DATE,[MobileOrderReport].[cdate] AS MOBILEORDERREPORT_CDATE,[MobileOrderReport].[retrieve_sn] AS MOBILEORDERREPORT_RETRIEVE_SN,[MobileOrderReport].[cid] AS MOBILEORDERREPORT_CID,[MobileOrderReport].[did] AS MOBILEORDERREPORT_DID,[MobileOrderReport].[sent_again_date] AS MOBILEORDERREPORT_SENT_AGAIN_DATE,[MobileOrderReport].[idd_vas] AS MOBILEORDERREPORT_IDD_VAS,[MobileOrderReport].[active] AS MOBILEORDERREPORT_ACTIVE,[MobileOrderReport].[fallout_reason] AS MOBILEORDERREPORT_FALLOUT_REASON,[MobileOrderReport].[fallout_remark] AS MOBILEORDERREPORT_FALLOUT_REMARK,[MobileOrderReport].[fallout_main_category] AS MOBILEORDERREPORT_FALLOUT_MAIN_CATEGORY,[MobileOrderReport].[gw_retrieve_date] AS MOBILEORDERREPORT_GW_RETRIEVE_DATE,[MobileOrderReport].[report_type] AS MOBILEORDERREPORT_REPORT_TYPE,[MobileOrderReport].[reactive_sn] AS MOBILEORDERREPORT_REACTIVE_SN,[MobileOrderReport].[ddate] AS MOBILEORDERREPORT_DDATE,[MobileOrderReport].[ext_place_tel] AS MOBILEORDERREPORT_EXT_PLACE_TEL,[MobileOrderReport].[reactive_date] AS MOBILEORDERREPORT_REACTIVE_DATE,[MobileOrderReport].[order_id] AS MOBILEORDERREPORT_ORDER_ID,[MobileOrderReport].[retrieve_date] AS MOBILEORDERREPORT_RETRIEVE_DATE,[MobileOrderReport].[py_sent_again_retrieve_date] AS MOBILEORDERREPORT_PY_SENT_AGAIN_RETRIEVE_DATE,[MobileOrderReport].[fallout_reply] AS MOBILEORDERREPORT_FALLOUT_REPLY  FROM  [MobileOrderReport]  WHERE  [MobileOrderReport].[mid] = \'"+x_iMid.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReport]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReport]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(MobileOrderReport.Para.order_status).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_ORDER_STATUS"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReport.Para.order_status).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.order_status).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORT_ORDER_STATUS"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.order_status).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReport.Para.gw_retrieve_sn).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_GW_RETRIEVE_SN"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReport.Para.gw_retrieve_sn).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.gw_retrieve_sn).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORT_GW_RETRIEVE_SN"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.gw_retrieve_sn).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReport.Para.sent_again).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_SENT_AGAIN"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReport.Para.sent_again).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.sent_again).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERREPORT_SENT_AGAIN"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.sent_again).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReport.Para.mid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_MID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReport.Para.mid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.mid).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERREPORT_MID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.mid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReport.Para.email_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_EMAIL_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReport.Para.email_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.email_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORT_EMAIL_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.email_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReport.Para.retrieve_cnt).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_RETRIEVE_CNT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReport.Para.retrieve_cnt).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.retrieve_cnt).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERREPORT_RETRIEVE_CNT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.retrieve_cnt).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReport.Para.fs_sent_again_retrieve_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_FS_SENT_AGAIN_RETRIEVE_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReport.Para.fs_sent_again_retrieve_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.fs_sent_again_retrieve_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORT_FS_SENT_AGAIN_RETRIEVE_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.fs_sent_again_retrieve_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReport.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReport.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORT_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReport.Para.retrieve_sn).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_RETRIEVE_SN"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReport.Para.retrieve_sn).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.retrieve_sn).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORT_RETRIEVE_SN"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.retrieve_sn).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReport.Para.cid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReport.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.cid).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORT_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.cid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReport.Para.did).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReport.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.did).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORT_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.did).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReport.Para.sent_again_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_SENT_AGAIN_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReport.Para.sent_again_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.sent_again_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORT_SENT_AGAIN_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.sent_again_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReport.Para.idd_vas).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_IDD_VAS"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReport.Para.idd_vas).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.idd_vas).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORT_IDD_VAS"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.idd_vas).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReport.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReport.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORT_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReport.Para.fallout_reason).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_FALLOUT_REASON"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReport.Para.fallout_reason).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.fallout_reason).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORT_FALLOUT_REASON"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.fallout_reason).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReport.Para.fallout_remark).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_FALLOUT_REMARK"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReport.Para.fallout_remark).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.fallout_remark).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORT_FALLOUT_REMARK"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.fallout_remark).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReport.Para.fallout_main_category).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_FALLOUT_MAIN_CATEGORY"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReport.Para.fallout_main_category).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.fallout_main_category).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORT_FALLOUT_MAIN_CATEGORY"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.fallout_main_category).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReport.Para.gw_retrieve_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_GW_RETRIEVE_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReport.Para.gw_retrieve_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.gw_retrieve_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORT_GW_RETRIEVE_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.gw_retrieve_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReport.Para.report_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_REPORT_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReport.Para.report_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.report_type).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORT_REPORT_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.report_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReport.Para.reactive_sn).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_REACTIVE_SN"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReport.Para.reactive_sn).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.reactive_sn).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORT_REACTIVE_SN"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.reactive_sn).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReport.Para.ddate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReport.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORT_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.ddate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReport.Para.ext_place_tel).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_EXT_PLACE_TEL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReport.Para.ext_place_tel).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.ext_place_tel).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORT_EXT_PLACE_TEL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.ext_place_tel).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReport.Para.reactive_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_REACTIVE_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReport.Para.reactive_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.reactive_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORT_REACTIVE_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.reactive_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReport.Para.order_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_ORDER_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReport.Para.order_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.order_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERREPORT_ORDER_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.order_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReport.Para.retrieve_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_RETRIEVE_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReport.Para.retrieve_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.retrieve_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORT_RETRIEVE_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.retrieve_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReport.Para.py_sent_again_retrieve_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_PY_SENT_AGAIN_RETRIEVE_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReport.Para.py_sent_again_retrieve_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.py_sent_again_retrieve_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORT_PY_SENT_AGAIN_RETRIEVE_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.py_sent_again_retrieve_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReport.Para.fallout_reply).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_FALLOUT_REPLY"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReport.Para.fallout_reply).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.fallout_reply).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORT_FALLOUT_REPLY"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReport.Para.fallout_reply).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,MobileOrderReport x_oMobileOrderReportRow)
        {
            return SetByDataSetRowProc(x_iROW, MobileOrderReport.Para.TableName(), x_oDataSet,x_oMobileOrderReportRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderReport x_oMobileOrderReportRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oMobileOrderReportRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderReport x_oMobileOrderReportRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                MobileOrderReportInfo _oTableSet=MobileOrderReportInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReport.Para.order_status).AliasName))
                    x_oMobileOrderReportRow.order_status = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReport.Para.order_status).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReport.Para.gw_retrieve_sn).AliasName))
                    x_oMobileOrderReportRow.gw_retrieve_sn = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReport.Para.gw_retrieve_sn).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReport.Para.sent_again).AliasName))
                    x_oMobileOrderReportRow.sent_again = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReport.Para.sent_again).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReport.Para.mid).AliasName))
                    x_oMobileOrderReportRow.mid = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReport.Para.mid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReport.Para.email_date).AliasName))
                    x_oMobileOrderReportRow.email_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReport.Para.email_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReport.Para.retrieve_cnt).AliasName))
                    x_oMobileOrderReportRow.retrieve_cnt = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReport.Para.retrieve_cnt).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReport.Para.fs_sent_again_retrieve_date).AliasName))
                    x_oMobileOrderReportRow.fs_sent_again_retrieve_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReport.Para.fs_sent_again_retrieve_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReport.Para.cdate).AliasName))
                    x_oMobileOrderReportRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReport.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReport.Para.retrieve_sn).AliasName))
                    x_oMobileOrderReportRow.retrieve_sn = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReport.Para.retrieve_sn).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReport.Para.cid).AliasName))
                    x_oMobileOrderReportRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReport.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReport.Para.did).AliasName))
                    x_oMobileOrderReportRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReport.Para.did).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReport.Para.sent_again_date).AliasName))
                    x_oMobileOrderReportRow.sent_again_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReport.Para.sent_again_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReport.Para.idd_vas).AliasName))
                    x_oMobileOrderReportRow.idd_vas = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReport.Para.idd_vas).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReport.Para.active).AliasName))
                    x_oMobileOrderReportRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReport.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReport.Para.fallout_reason).AliasName))
                    x_oMobileOrderReportRow.fallout_reason = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReport.Para.fallout_reason).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReport.Para.fallout_remark).AliasName))
                    x_oMobileOrderReportRow.fallout_remark = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReport.Para.fallout_remark).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReport.Para.fallout_main_category).AliasName))
                    x_oMobileOrderReportRow.fallout_main_category = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReport.Para.fallout_main_category).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReport.Para.report_type).AliasName))
                    x_oMobileOrderReportRow.report_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReport.Para.report_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReport.Para.fallout_reply).AliasName))
                    x_oMobileOrderReportRow.fallout_reply = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReport.Para.fallout_reply).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReport.Para.reactive_sn).AliasName))
                    x_oMobileOrderReportRow.reactive_sn = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReport.Para.reactive_sn).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReport.Para.ddate).AliasName))
                    x_oMobileOrderReportRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReport.Para.ddate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReport.Para.ext_place_tel).AliasName))
                    x_oMobileOrderReportRow.ext_place_tel = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReport.Para.ext_place_tel).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReport.Para.reactive_date).AliasName))
                    x_oMobileOrderReportRow.reactive_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReport.Para.reactive_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReport.Para.gw_retrieve_date).AliasName))
                    x_oMobileOrderReportRow.gw_retrieve_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReport.Para.gw_retrieve_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReport.Para.order_id).AliasName))
                    x_oMobileOrderReportRow.order_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReport.Para.order_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReport.Para.py_sent_again_retrieve_date).AliasName))
                    x_oMobileOrderReportRow.py_sent_again_retrieve_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReport.Para.py_sent_again_retrieve_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReport.Para.retrieve_date).AliasName))
                    x_oMobileOrderReportRow.retrieve_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReport.Para.retrieve_date).AliasName];
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
            return MobileOrderReportRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static MobileOrderReportEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return MobileOrderReportRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static MobileOrderReportEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return MobileOrderReportRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderReportRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderReportRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderReportRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sOrder_status,string x_sGw_retrieve_sn,global::System.Nullable<int> x_iSent_again,global::System.Nullable<DateTime> x_dEmail_date,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dFs_sent_again_retrieve_date,global::System.Nullable<DateTime> x_dCdate,string x_sRetrieve_sn,string x_sCid,string x_sDid,global::System.Nullable<DateTime> x_dSent_again_date,string x_sIdd_vas,global::System.Nullable<bool> x_bActive,string x_sFallout_reason,string x_sFallout_remark,string x_sFallout_main_category,string x_sReport_type,string x_sFallout_reply,string x_sReactive_sn,global::System.Nullable<DateTime> x_dDdate,string x_sExt_place_tel,global::System.Nullable<DateTime> x_dReactive_date,global::System.Nullable<DateTime> x_dGw_retrieve_date,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dPy_sent_again_retrieve_date,global::System.Nullable<DateTime> x_dRetrieve_date)
        {
            return MobileOrderReportRepository.Insert(x_oDB, x_sOrder_status,x_sGw_retrieve_sn,x_iSent_again,x_dEmail_date,x_iRetrieve_cnt,x_dFs_sent_again_retrieve_date,x_dCdate,x_sRetrieve_sn,x_sCid,x_sDid,x_dSent_again_date,x_sIdd_vas,x_bActive,x_sFallout_reason,x_sFallout_remark,x_sFallout_main_category,x_sReport_type,x_sFallout_reply,x_sReactive_sn,x_dDdate,x_sExt_place_tel,x_dReactive_date,x_dGw_retrieve_date,x_iOrder_id,x_dPy_sent_again_retrieve_date,x_dRetrieve_date);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderReport x_oMobileOrderReport)
        {
            return MobileOrderReportRepository.InsertWithOutLastID(x_oDB,x_oMobileOrderReport);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sOrder_status,string x_sGw_retrieve_sn,global::System.Nullable<int> x_iSent_again,global::System.Nullable<DateTime> x_dEmail_date,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dFs_sent_again_retrieve_date,global::System.Nullable<DateTime> x_dCdate,string x_sRetrieve_sn,string x_sCid,string x_sDid,global::System.Nullable<DateTime> x_dSent_again_date,string x_sIdd_vas,global::System.Nullable<bool> x_bActive,string x_sFallout_reason,string x_sFallout_remark,string x_sFallout_main_category,string x_sReport_type,string x_sFallout_reply,string x_sReactive_sn,global::System.Nullable<DateTime> x_dDdate,string x_sExt_place_tel,global::System.Nullable<DateTime> x_dReactive_date,global::System.Nullable<DateTime> x_dGw_retrieve_date,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dPy_sent_again_retrieve_date,global::System.Nullable<DateTime> x_dRetrieve_date)
        {
            return MobileOrderReportRepository.InsertReturnLastID_SP(x_oDB,x_sOrder_status,x_sGw_retrieve_sn,x_iSent_again,x_dEmail_date,x_iRetrieve_cnt,x_dFs_sent_again_retrieve_date,x_dCdate,x_sRetrieve_sn,x_sCid,x_sDid,x_dSent_again_date,x_sIdd_vas,x_bActive,x_sFallout_reason,x_sFallout_remark,x_sFallout_main_category,x_sReport_type,x_sFallout_reply,x_sReactive_sn,x_dDdate,x_sExt_place_tel,x_dReactive_date,x_dGw_retrieve_date,x_iOrder_id,x_dPy_sent_again_retrieve_date,x_dRetrieve_date);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderReport x_oMobileOrderReport)
        {
            return MobileOrderReportRepository.InsertReturnLastID_SP(x_oDB,x_oMobileOrderReport);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return MobileOrderReportRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderReportRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            return MobileOrderReportRepository.Delete(x_oDB, x_iMid);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(MobileOrderReport x_oMobileOrderReportRow){
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


