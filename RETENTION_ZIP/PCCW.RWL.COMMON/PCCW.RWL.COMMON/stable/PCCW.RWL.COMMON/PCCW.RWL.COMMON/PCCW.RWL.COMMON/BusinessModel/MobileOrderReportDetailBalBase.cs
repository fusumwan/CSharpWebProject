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
///-- Description:	<Description,Table :[MobileOrderReportDetail],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderReportDetail] Business layer
    /// </summary>
    
    public abstract class MobileOrderReportDetailBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public MobileOrderReportDetailBalBase(){
        }
        ~MobileOrderReportDetailBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderReportDetail x_oMobileOrderReportDetail)
        {
            return GetDataSet(x_oMobileOrderReportDetail,null,MobileOrderReportDetailInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderReportDetail x_oMobileOrderReportDetail,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oMobileOrderReportDetail,x_oMergeDSet,MobileOrderReportDetailInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderReportDetail x_oMobileOrderReportDetail,MobileOrderReportDetailInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderReportDetail,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderReportDetail x_oMobileOrderReportDetail,global::System.Data.DataSet x_oMergeDSet,MobileOrderReportDetailInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderReportDetail,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(MobileOrderReportDetail x_oMobileOrderReportDetail,global::System.Data.DataSet x_oMergeDSet,MobileOrderReportDetailInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderReportDetailInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(MobileOrderReportDetail.Para.TableName());
            if (x_oTableSet.Fields(MobileOrderReportDetail.Para.order_status).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetail.Para.TableName()].Columns.Add(MobileOrderReportDetail.Para.order_status); }
            if (x_oTableSet.Fields(MobileOrderReportDetail.Para.fallout_reply).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetail.Para.TableName()].Columns.Add(MobileOrderReportDetail.Para.fallout_reply); }
            if (x_oTableSet.Fields(MobileOrderReportDetail.Para.mflag).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetail.Para.TableName()].Columns.Add(MobileOrderReportDetail.Para.mflag); }
            if (x_oTableSet.Fields(MobileOrderReportDetail.Para.email_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetail.Para.TableName()].Columns.Add(MobileOrderReportDetail.Para.email_date); }
            if (x_oTableSet.Fields(MobileOrderReportDetail.Para.retrieve_cnt).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetail.Para.TableName()].Columns.Add(MobileOrderReportDetail.Para.retrieve_cnt); }
            if (x_oTableSet.Fields(MobileOrderReportDetail.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetail.Para.TableName()].Columns.Add(MobileOrderReportDetail.Para.cdate); }
            if (x_oTableSet.Fields(MobileOrderReportDetail.Para.retrieve_sn).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetail.Para.TableName()].Columns.Add(MobileOrderReportDetail.Para.retrieve_sn); }
            if (x_oTableSet.Fields(MobileOrderReportDetail.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetail.Para.TableName()].Columns.Add(MobileOrderReportDetail.Para.cid); }
            if (x_oTableSet.Fields(MobileOrderReportDetail.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetail.Para.TableName()].Columns.Add(MobileOrderReportDetail.Para.did); }
            if (x_oTableSet.Fields(MobileOrderReportDetail.Para.eid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetail.Para.TableName()].Columns.Add(MobileOrderReportDetail.Para.eid); }
            if (x_oTableSet.Fields(MobileOrderReportDetail.Para.report_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetail.Para.TableName()].Columns.Add(MobileOrderReportDetail.Para.report_id); }
            if (x_oTableSet.Fields(MobileOrderReportDetail.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetail.Para.TableName()].Columns.Add(MobileOrderReportDetail.Para.active); }
            if (x_oTableSet.Fields(MobileOrderReportDetail.Para.fallout_reason).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetail.Para.TableName()].Columns.Add(MobileOrderReportDetail.Para.fallout_reason); }
            if (x_oTableSet.Fields(MobileOrderReportDetail.Para.fallout_remark).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetail.Para.TableName()].Columns.Add(MobileOrderReportDetail.Para.fallout_remark); }
            if (x_oTableSet.Fields(MobileOrderReportDetail.Para.fallout_main_category).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetail.Para.TableName()].Columns.Add(MobileOrderReportDetail.Para.fallout_main_category); }
            if (x_oTableSet.Fields(MobileOrderReportDetail.Para.report_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetail.Para.TableName()].Columns.Add(MobileOrderReportDetail.Para.report_type); }
            if (x_oTableSet.Fields(MobileOrderReportDetail.Para.reactive_sn).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetail.Para.TableName()].Columns.Add(MobileOrderReportDetail.Para.reactive_sn); }
            if (x_oTableSet.Fields(MobileOrderReportDetail.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetail.Para.TableName()].Columns.Add(MobileOrderReportDetail.Para.ddate); }
            if (x_oTableSet.Fields(MobileOrderReportDetail.Para.mdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetail.Para.TableName()].Columns.Add(MobileOrderReportDetail.Para.mdate); }
            if (x_oTableSet.Fields(MobileOrderReportDetail.Para.reactive_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetail.Para.TableName()].Columns.Add(MobileOrderReportDetail.Para.reactive_date); }
            if (x_oTableSet.Fields(MobileOrderReportDetail.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetail.Para.TableName()].Columns.Add(MobileOrderReportDetail.Para.order_id); }
            if (x_oTableSet.Fields(MobileOrderReportDetail.Para.retrieve_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportDetail.Para.TableName()].Columns.Add(MobileOrderReportDetail.Para.retrieve_date); }
            if (x_oMobileOrderReportDetail != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[MobileOrderReportDetail.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(MobileOrderReportDetail.Para.order_status).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetail.Para.order_status] = x_oMobileOrderReportDetail.GetOrder_status(); }
                if (x_oTableSet.Fields(MobileOrderReportDetail.Para.fallout_reply).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetail.Para.fallout_reply] = x_oMobileOrderReportDetail.GetFallout_reply(); }
                if (x_oTableSet.Fields(MobileOrderReportDetail.Para.mflag).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetail.Para.mflag] = x_oMobileOrderReportDetail.GetMflag(); }
                if (x_oTableSet.Fields(MobileOrderReportDetail.Para.email_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetail.Para.email_date] = x_oMobileOrderReportDetail.GetEmail_date(); }
                if (x_oTableSet.Fields(MobileOrderReportDetail.Para.retrieve_cnt).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetail.Para.retrieve_cnt] = x_oMobileOrderReportDetail.GetRetrieve_cnt(); }
                if (x_oTableSet.Fields(MobileOrderReportDetail.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetail.Para.cdate] = x_oMobileOrderReportDetail.GetCdate(); }
                if (x_oTableSet.Fields(MobileOrderReportDetail.Para.retrieve_sn).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetail.Para.retrieve_sn] = x_oMobileOrderReportDetail.GetRetrieve_sn(); }
                if (x_oTableSet.Fields(MobileOrderReportDetail.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetail.Para.cid] = x_oMobileOrderReportDetail.GetCid(); }
                if (x_oTableSet.Fields(MobileOrderReportDetail.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetail.Para.did] = x_oMobileOrderReportDetail.GetDid(); }
                if (x_oTableSet.Fields(MobileOrderReportDetail.Para.eid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetail.Para.eid] = x_oMobileOrderReportDetail.GetEid(); }
                if (x_oTableSet.Fields(MobileOrderReportDetail.Para.report_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetail.Para.report_id] = x_oMobileOrderReportDetail.GetReport_id(); }
                if (x_oTableSet.Fields(MobileOrderReportDetail.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetail.Para.active] = x_oMobileOrderReportDetail.GetActive(); }
                if (x_oTableSet.Fields(MobileOrderReportDetail.Para.fallout_reason).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetail.Para.fallout_reason] = x_oMobileOrderReportDetail.GetFallout_reason(); }
                if (x_oTableSet.Fields(MobileOrderReportDetail.Para.fallout_remark).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetail.Para.fallout_remark] = x_oMobileOrderReportDetail.GetFallout_remark(); }
                if (x_oTableSet.Fields(MobileOrderReportDetail.Para.fallout_main_category).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetail.Para.fallout_main_category] = x_oMobileOrderReportDetail.GetFallout_main_category(); }
                if (x_oTableSet.Fields(MobileOrderReportDetail.Para.report_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetail.Para.report_type] = x_oMobileOrderReportDetail.GetReport_type(); }
                if (x_oTableSet.Fields(MobileOrderReportDetail.Para.reactive_sn).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetail.Para.reactive_sn] = x_oMobileOrderReportDetail.GetReactive_sn(); }
                if (x_oTableSet.Fields(MobileOrderReportDetail.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetail.Para.ddate] = x_oMobileOrderReportDetail.GetDdate(); }
                if (x_oTableSet.Fields(MobileOrderReportDetail.Para.mdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetail.Para.mdate] = x_oMobileOrderReportDetail.GetMdate(); }
                if (x_oTableSet.Fields(MobileOrderReportDetail.Para.reactive_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetail.Para.reactive_date] = x_oMobileOrderReportDetail.GetReactive_date(); }
                if (x_oTableSet.Fields(MobileOrderReportDetail.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetail.Para.order_id] = x_oMobileOrderReportDetail.GetOrder_id(); }
                if (x_oTableSet.Fields(MobileOrderReportDetail.Para.retrieve_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportDetail.Para.retrieve_date] = x_oMobileOrderReportDetail.GetRetrieve_date(); }
                _oDSet.Tables[MobileOrderReportDetail.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(MobileOrderReportDetailInfo x_oTableSet)
        {
            return MobileOrderReportDetailBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return MobileOrderReportDetailBal.ToEmptyDataSetProcess(MobileOrderReportDetailInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(MobileOrderReportDetailInfo x_oTableSet)
        {
            return MobileOrderReportDetailBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(MobileOrderReportDetail x_oMobileOrderReportDetail, MobileOrderReportDetailInfo x_oTableSet)
        {
            return MobileOrderReportDetailBal.GetDataSet(null, null, x_oTableSet).Tables[MobileOrderReportDetail.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(MobileOrderReportDetail x_oMobileOrderReportDetail)
        {
            return MobileOrderReportDetailBal.GetDataSet(x_oMobileOrderReportDetail, null, MobileOrderReportDetailInfoDLL.CreateInfoInstanceObject()).Tables[MobileOrderReportDetail.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iReport_id)
        {
            return Row(x_oTable, x_oDB,x_iReport_id,MobileOrderReportDetailInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iReport_id, MobileOrderReportDetailInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iReport_id, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iReport_id,MobileOrderReportDetailInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderReportDetailInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [MobileOrderReportDetail].[order_status] AS MOBILEORDERREPORTDETAIL_ORDER_STATUS,[MobileOrderReportDetail].[mflag] AS MOBILEORDERREPORTDETAIL_MFLAG,[MobileOrderReportDetail].[email_date] AS MOBILEORDERREPORTDETAIL_EMAIL_DATE,[MobileOrderReportDetail].[retrieve_cnt] AS MOBILEORDERREPORTDETAIL_RETRIEVE_CNT,[MobileOrderReportDetail].[cdate] AS MOBILEORDERREPORTDETAIL_CDATE,[MobileOrderReportDetail].[retrieve_sn] AS MOBILEORDERREPORTDETAIL_RETRIEVE_SN,[MobileOrderReportDetail].[cid] AS MOBILEORDERREPORTDETAIL_CID,[MobileOrderReportDetail].[did] AS MOBILEORDERREPORTDETAIL_DID,[MobileOrderReportDetail].[eid] AS MOBILEORDERREPORTDETAIL_EID,[MobileOrderReportDetail].[report_id] AS MOBILEORDERREPORTDETAIL_REPORT_ID,[MobileOrderReportDetail].[active] AS MOBILEORDERREPORTDETAIL_ACTIVE,[MobileOrderReportDetail].[fallout_reason] AS MOBILEORDERREPORTDETAIL_FALLOUT_REASON,[MobileOrderReportDetail].[fallout_remark] AS MOBILEORDERREPORTDETAIL_FALLOUT_REMARK,[MobileOrderReportDetail].[fallout_main_category] AS MOBILEORDERREPORTDETAIL_FALLOUT_MAIN_CATEGORY,[MobileOrderReportDetail].[report_type] AS MOBILEORDERREPORTDETAIL_REPORT_TYPE,[MobileOrderReportDetail].[reactive_sn] AS MOBILEORDERREPORTDETAIL_REACTIVE_SN,[MobileOrderReportDetail].[ddate] AS MOBILEORDERREPORTDETAIL_DDATE,[MobileOrderReportDetail].[mdate] AS MOBILEORDERREPORTDETAIL_MDATE,[MobileOrderReportDetail].[reactive_date] AS MOBILEORDERREPORTDETAIL_REACTIVE_DATE,[MobileOrderReportDetail].[order_id] AS MOBILEORDERREPORTDETAIL_ORDER_ID,[MobileOrderReportDetail].[retrieve_date] AS MOBILEORDERREPORTDETAIL_RETRIEVE_DATE,[MobileOrderReportDetail].[fallout_reply] AS MOBILEORDERREPORTDETAIL_FALLOUT_REPLY  FROM  [MobileOrderReportDetail]  WHERE  [MobileOrderReportDetail].[report_id] = \'"+x_iReport_id.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportDetail]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(MobileOrderReportDetail.Para.order_status).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_ORDER_STATUS"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetail.Para.order_status).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.order_status).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTDETAIL_ORDER_STATUS"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.order_status).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetail.Para.mflag).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_MFLAG"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetail.Para.mflag).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.mflag).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTDETAIL_MFLAG"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.mflag).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetail.Para.email_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_EMAIL_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetail.Para.email_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.email_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAIL_EMAIL_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.email_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetail.Para.retrieve_cnt).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_RETRIEVE_CNT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetail.Para.retrieve_cnt).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.retrieve_cnt).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTDETAIL_RETRIEVE_CNT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.retrieve_cnt).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetail.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetail.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAIL_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetail.Para.retrieve_sn).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_RETRIEVE_SN"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetail.Para.retrieve_sn).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.retrieve_sn).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTDETAIL_RETRIEVE_SN"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.retrieve_sn).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetail.Para.cid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetail.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.cid).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTDETAIL_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.cid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetail.Para.did).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetail.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.did).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTDETAIL_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.did).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetail.Para.eid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_EID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetail.Para.eid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.eid).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTDETAIL_EID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.eid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetail.Para.report_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_REPORT_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetail.Para.report_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.report_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTDETAIL_REPORT_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.report_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetail.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetail.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTDETAIL_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetail.Para.fallout_reason).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_FALLOUT_REASON"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetail.Para.fallout_reason).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.fallout_reason).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTDETAIL_FALLOUT_REASON"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.fallout_reason).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetail.Para.fallout_remark).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_FALLOUT_REMARK"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetail.Para.fallout_remark).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.fallout_remark).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTDETAIL_FALLOUT_REMARK"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.fallout_remark).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetail.Para.fallout_main_category).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_FALLOUT_MAIN_CATEGORY"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetail.Para.fallout_main_category).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.fallout_main_category).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTDETAIL_FALLOUT_MAIN_CATEGORY"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.fallout_main_category).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetail.Para.report_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_REPORT_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetail.Para.report_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.report_type).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTDETAIL_REPORT_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.report_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetail.Para.reactive_sn).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_REACTIVE_SN"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetail.Para.reactive_sn).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.reactive_sn).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTDETAIL_REACTIVE_SN"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.reactive_sn).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetail.Para.ddate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetail.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAIL_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.ddate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetail.Para.mdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_MDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetail.Para.mdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.mdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAIL_MDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.mdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetail.Para.reactive_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_REACTIVE_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetail.Para.reactive_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.reactive_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAIL_REACTIVE_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.reactive_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetail.Para.order_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_ORDER_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetail.Para.order_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.order_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTDETAIL_ORDER_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.order_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetail.Para.retrieve_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_RETRIEVE_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetail.Para.retrieve_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.retrieve_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAIL_RETRIEVE_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.retrieve_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportDetail.Para.fallout_reply).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_FALLOUT_REPLY"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportDetail.Para.fallout_reply).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.fallout_reply).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTDETAIL_FALLOUT_REPLY"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportDetail.Para.fallout_reply).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,MobileOrderReportDetail x_oMobileOrderReportDetailRow)
        {
            return SetByDataSetRowProc(x_iROW, MobileOrderReportDetail.Para.TableName(), x_oDataSet,x_oMobileOrderReportDetailRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderReportDetail x_oMobileOrderReportDetailRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oMobileOrderReportDetailRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderReportDetail x_oMobileOrderReportDetailRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                MobileOrderReportDetailInfo _oTableSet=MobileOrderReportDetailInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetail.Para.order_status).AliasName))
                    x_oMobileOrderReportDetailRow.order_status = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetail.Para.order_status).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetail.Para.fallout_reply).AliasName))
                    x_oMobileOrderReportDetailRow.fallout_reply = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetail.Para.fallout_reply).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetail.Para.mflag).AliasName))
                    x_oMobileOrderReportDetailRow.mflag = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetail.Para.mflag).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetail.Para.email_date).AliasName))
                    x_oMobileOrderReportDetailRow.email_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetail.Para.email_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetail.Para.retrieve_cnt).AliasName))
                    x_oMobileOrderReportDetailRow.retrieve_cnt = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetail.Para.retrieve_cnt).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetail.Para.cdate).AliasName))
                    x_oMobileOrderReportDetailRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetail.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetail.Para.retrieve_sn).AliasName))
                    x_oMobileOrderReportDetailRow.retrieve_sn = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetail.Para.retrieve_sn).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetail.Para.cid).AliasName))
                    x_oMobileOrderReportDetailRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetail.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetail.Para.did).AliasName))
                    x_oMobileOrderReportDetailRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetail.Para.did).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetail.Para.eid).AliasName))
                    x_oMobileOrderReportDetailRow.eid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetail.Para.eid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetail.Para.report_id).AliasName))
                    x_oMobileOrderReportDetailRow.report_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetail.Para.report_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetail.Para.active).AliasName))
                    x_oMobileOrderReportDetailRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetail.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetail.Para.fallout_reason).AliasName))
                    x_oMobileOrderReportDetailRow.fallout_reason = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetail.Para.fallout_reason).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetail.Para.fallout_remark).AliasName))
                    x_oMobileOrderReportDetailRow.fallout_remark = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetail.Para.fallout_remark).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetail.Para.fallout_main_category).AliasName))
                    x_oMobileOrderReportDetailRow.fallout_main_category = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetail.Para.fallout_main_category).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetail.Para.report_type).AliasName))
                    x_oMobileOrderReportDetailRow.report_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetail.Para.report_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetail.Para.reactive_sn).AliasName))
                    x_oMobileOrderReportDetailRow.reactive_sn = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetail.Para.reactive_sn).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetail.Para.ddate).AliasName))
                    x_oMobileOrderReportDetailRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetail.Para.ddate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetail.Para.mdate).AliasName))
                    x_oMobileOrderReportDetailRow.mdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetail.Para.mdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetail.Para.reactive_date).AliasName))
                    x_oMobileOrderReportDetailRow.reactive_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetail.Para.reactive_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetail.Para.order_id).AliasName))
                    x_oMobileOrderReportDetailRow.order_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetail.Para.order_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportDetail.Para.retrieve_date).AliasName))
                    x_oMobileOrderReportDetailRow.retrieve_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportDetail.Para.retrieve_date).AliasName];
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
            return MobileOrderReportDetailRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static MobileOrderReportDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return MobileOrderReportDetailRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static MobileOrderReportDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return MobileOrderReportDetailRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderReportDetailRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderReportDetailRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderReportDetailRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sOrder_status,string x_sFallout_reply,global::System.Nullable<bool> x_bMflag,global::System.Nullable<DateTime> x_dEmail_date,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dCdate,string x_sRetrieve_sn,string x_sCid,string x_sDid,string x_sEid,global::System.Nullable<bool> x_bActive,string x_sFallout_reason,string x_sFallout_remark,string x_sFallout_main_category,string x_sReport_type,string x_sReactive_sn,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<DateTime> x_dMdate,global::System.Nullable<DateTime> x_dReactive_date,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dRetrieve_date)
        {
            return MobileOrderReportDetailRepository.Insert(x_oDB, x_sOrder_status,x_sFallout_reply,x_bMflag,x_dEmail_date,x_iRetrieve_cnt,x_dCdate,x_sRetrieve_sn,x_sCid,x_sDid,x_sEid,x_bActive,x_sFallout_reason,x_sFallout_remark,x_sFallout_main_category,x_sReport_type,x_sReactive_sn,x_dDdate,x_dMdate,x_dReactive_date,x_iOrder_id,x_dRetrieve_date);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderReportDetail x_oMobileOrderReportDetail)
        {
            return MobileOrderReportDetailRepository.InsertWithOutLastID(x_oDB,x_oMobileOrderReportDetail);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sOrder_status,string x_sFallout_reply,global::System.Nullable<bool> x_bMflag,global::System.Nullable<DateTime> x_dEmail_date,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dCdate,string x_sRetrieve_sn,string x_sCid,string x_sDid,string x_sEid,global::System.Nullable<bool> x_bActive,string x_sFallout_reason,string x_sFallout_remark,string x_sFallout_main_category,string x_sReport_type,string x_sReactive_sn,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<DateTime> x_dMdate,global::System.Nullable<DateTime> x_dReactive_date,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dRetrieve_date)
        {
            return MobileOrderReportDetailRepository.InsertReturnLastID_SP(x_oDB,x_sOrder_status,x_sFallout_reply,x_bMflag,x_dEmail_date,x_iRetrieve_cnt,x_dCdate,x_sRetrieve_sn,x_sCid,x_sDid,x_sEid,x_bActive,x_sFallout_reason,x_sFallout_remark,x_sFallout_main_category,x_sReport_type,x_sReactive_sn,x_dDdate,x_dMdate,x_dReactive_date,x_iOrder_id,x_dRetrieve_date);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderReportDetail x_oMobileOrderReportDetail)
        {
            return MobileOrderReportDetailRepository.InsertReturnLastID_SP(x_oDB,x_oMobileOrderReportDetail);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return MobileOrderReportDetailRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderReportDetailRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iReport_id)
        {
            return MobileOrderReportDetailRepository.Delete(x_oDB, x_iReport_id);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(MobileOrderReportDetail x_oMobileOrderReportDetailRow){
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


