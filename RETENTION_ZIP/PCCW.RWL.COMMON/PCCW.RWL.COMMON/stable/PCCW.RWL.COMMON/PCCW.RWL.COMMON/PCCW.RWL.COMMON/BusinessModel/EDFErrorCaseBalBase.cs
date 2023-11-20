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
///-- Create date: <Create Date 2010-05-31>
///-- Description:	<Description,Table :[EDFErrorCase],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [EDFErrorCase] Business layer
    /// </summary>
    
    public abstract class EDFErrorCaseBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public EDFErrorCaseBalBase(){
        }
        ~EDFErrorCaseBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(EDFErrorCase x_oEDFErrorCase)
        {
            return GetDataSet(x_oEDFErrorCase,null,EDFErrorCaseInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(EDFErrorCase x_oEDFErrorCase,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oEDFErrorCase,x_oMergeDSet,EDFErrorCaseInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(EDFErrorCase x_oEDFErrorCase,EDFErrorCaseInfo x_oTableSet)
        {
            return GetDataSet(x_oEDFErrorCase,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(EDFErrorCase x_oEDFErrorCase,global::System.Data.DataSet x_oMergeDSet,EDFErrorCaseInfo x_oTableSet)
        {
            return GetDataSet(x_oEDFErrorCase,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(EDFErrorCase x_oEDFErrorCase,global::System.Data.DataSet x_oMergeDSet,EDFErrorCaseInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = EDFErrorCaseInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(EDFErrorCase.Para.TableName());
            if (x_oTableSet.Fields(EDFErrorCase.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EDFErrorCase.Para.TableName()].Columns.Add(EDFErrorCase.Para.id); }
            if (x_oTableSet.Fields(EDFErrorCase.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EDFErrorCase.Para.TableName()].Columns.Add(EDFErrorCase.Para.cdate); }
            if (x_oTableSet.Fields(EDFErrorCase.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EDFErrorCase.Para.TableName()].Columns.Add(EDFErrorCase.Para.cid); }
            if (x_oTableSet.Fields(EDFErrorCase.Para.mrt_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EDFErrorCase.Para.TableName()].Columns.Add(EDFErrorCase.Para.mrt_no); }
            if (x_oTableSet.Fields(EDFErrorCase.Para.status).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EDFErrorCase.Para.TableName()].Columns.Add(EDFErrorCase.Para.status); }
            if (x_oTableSet.Fields(EDFErrorCase.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EDFErrorCase.Para.TableName()].Columns.Add(EDFErrorCase.Para.active); }
            if (x_oTableSet.Fields(EDFErrorCase.Para.remark).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EDFErrorCase.Para.TableName()].Columns.Add(EDFErrorCase.Para.remark); }
            if (x_oTableSet.Fields(EDFErrorCase.Para.imei_status).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EDFErrorCase.Para.TableName()].Columns.Add(EDFErrorCase.Para.imei_status); }
            if (x_oTableSet.Fields(EDFErrorCase.Para.imei_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EDFErrorCase.Para.TableName()].Columns.Add(EDFErrorCase.Para.imei_no); }
            if (x_oTableSet.Fields(EDFErrorCase.Para.imei_remark).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EDFErrorCase.Para.TableName()].Columns.Add(EDFErrorCase.Para.imei_remark); }
            if (x_oTableSet.Fields(EDFErrorCase.Para.edf_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EDFErrorCase.Para.TableName()].Columns.Add(EDFErrorCase.Para.edf_no); }
            if (x_oTableSet.Fields(EDFErrorCase.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EDFErrorCase.Para.TableName()].Columns.Add(EDFErrorCase.Para.order_id); }
            if (x_oTableSet.Fields(EDFErrorCase.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EDFErrorCase.Para.TableName()].Columns.Add(EDFErrorCase.Para.did); }
            if (x_oTableSet.Fields(EDFErrorCase.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EDFErrorCase.Para.TableName()].Columns.Add(EDFErrorCase.Para.ddate); }
            if (x_oTableSet.Fields(EDFErrorCase.Para.error_msg).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EDFErrorCase.Para.TableName()].Columns.Add(EDFErrorCase.Para.error_msg); }
            if (x_oEDFErrorCase != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[EDFErrorCase.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(EDFErrorCase.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[EDFErrorCase.Para.id] = x_oEDFErrorCase.GetId(); }
                if (x_oTableSet.Fields(EDFErrorCase.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[EDFErrorCase.Para.cdate] = x_oEDFErrorCase.GetCdate(); }
                if (x_oTableSet.Fields(EDFErrorCase.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[EDFErrorCase.Para.cid] = x_oEDFErrorCase.GetCid(); }
                if (x_oTableSet.Fields(EDFErrorCase.Para.mrt_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[EDFErrorCase.Para.mrt_no] = x_oEDFErrorCase.GetMrt_no(); }
                if (x_oTableSet.Fields(EDFErrorCase.Para.status).IsView || x_oTableSet.GetViewAll()) { _oDRow[EDFErrorCase.Para.status] = x_oEDFErrorCase.GetStatus(); }
                if (x_oTableSet.Fields(EDFErrorCase.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[EDFErrorCase.Para.active] = x_oEDFErrorCase.GetActive(); }
                if (x_oTableSet.Fields(EDFErrorCase.Para.remark).IsView || x_oTableSet.GetViewAll()) { _oDRow[EDFErrorCase.Para.remark] = x_oEDFErrorCase.GetRemark(); }
                if (x_oTableSet.Fields(EDFErrorCase.Para.imei_status).IsView || x_oTableSet.GetViewAll()) { _oDRow[EDFErrorCase.Para.imei_status] = x_oEDFErrorCase.GetImei_status(); }
                if (x_oTableSet.Fields(EDFErrorCase.Para.imei_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[EDFErrorCase.Para.imei_no] = x_oEDFErrorCase.GetImei_no(); }
                if (x_oTableSet.Fields(EDFErrorCase.Para.imei_remark).IsView || x_oTableSet.GetViewAll()) { _oDRow[EDFErrorCase.Para.imei_remark] = x_oEDFErrorCase.GetImei_remark(); }
                if (x_oTableSet.Fields(EDFErrorCase.Para.edf_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[EDFErrorCase.Para.edf_no] = x_oEDFErrorCase.GetEdf_no(); }
                if (x_oTableSet.Fields(EDFErrorCase.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[EDFErrorCase.Para.order_id] = x_oEDFErrorCase.GetOrder_id(); }
                if (x_oTableSet.Fields(EDFErrorCase.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[EDFErrorCase.Para.did] = x_oEDFErrorCase.GetDid(); }
                if (x_oTableSet.Fields(EDFErrorCase.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[EDFErrorCase.Para.ddate] = x_oEDFErrorCase.GetDdate(); }
                if (x_oTableSet.Fields(EDFErrorCase.Para.error_msg).IsView || x_oTableSet.GetViewAll()) { _oDRow[EDFErrorCase.Para.error_msg] = x_oEDFErrorCase.GetError_msg(); }
                _oDSet.Tables[EDFErrorCase.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(EDFErrorCaseInfo x_oTableSet)
        {
            return EDFErrorCaseBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return EDFErrorCaseBal.ToEmptyDataSetProcess(EDFErrorCaseInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(EDFErrorCaseInfo x_oTableSet)
        {
            return EDFErrorCaseBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(EDFErrorCase x_oEDFErrorCase, EDFErrorCaseInfo x_oTableSet)
        {
            return EDFErrorCaseBal.GetDataSet(null, null, x_oTableSet).Tables[EDFErrorCase.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(EDFErrorCase x_oEDFErrorCase)
        {
            return EDFErrorCaseBal.GetDataSet(x_oEDFErrorCase, null, EDFErrorCaseInfoDLL.CreateInfoInstanceObject()).Tables[EDFErrorCase.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return Row(x_oTable, x_oDB,x_iId,EDFErrorCaseInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId, EDFErrorCaseInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iId, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId,EDFErrorCaseInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = EDFErrorCaseInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [EDFErrorCase].[id] AS EDFERRORCASE_ID,[EDFErrorCase].[cdate] AS EDFERRORCASE_CDATE,[EDFErrorCase].[cid] AS EDFERRORCASE_CID,[EDFErrorCase].[mrt_no] AS EDFERRORCASE_MRT_NO,[EDFErrorCase].[status] AS EDFERRORCASE_STATUS,[EDFErrorCase].[active] AS EDFERRORCASE_ACTIVE,[EDFErrorCase].[remark] AS EDFERRORCASE_REMARK,[EDFErrorCase].[imei_status] AS EDFERRORCASE_IMEI_STATUS,[EDFErrorCase].[imei_remark] AS EDFERRORCASE_IMEI_REMARK,[EDFErrorCase].[edf_no] AS EDFERRORCASE_EDF_NO,[EDFErrorCase].[order_id] AS EDFERRORCASE_ORDER_ID,[EDFErrorCase].[error_msg] AS EDFERRORCASE_ERROR_MSG,[EDFErrorCase].[did] AS EDFERRORCASE_DID,[EDFErrorCase].[ddate] AS EDFERRORCASE_DDATE,[EDFErrorCase].[imei_no] AS EDFERRORCASE_IMEI_NO  FROM  [EDFErrorCase]  WHERE  [EDFErrorCase].[id] = \'"+x_iId.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[EDFErrorCase]","["+ Configurator.MSSQLTablePrefix + "EDFErrorCase]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(EDFErrorCase.Para.id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EDFErrorCase.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EDFErrorCase.Para.id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["EDFERRORCASE_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EDFErrorCase.Para.id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(EDFErrorCase.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EDFErrorCase.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EDFErrorCase.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["EDFERRORCASE_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EDFErrorCase.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(EDFErrorCase.Para.cid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EDFErrorCase.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EDFErrorCase.Para.cid).AliasName].ToString()] = (string)_oData["EDFERRORCASE_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EDFErrorCase.Para.cid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(EDFErrorCase.Para.mrt_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_MRT_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EDFErrorCase.Para.mrt_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EDFErrorCase.Para.mrt_no).AliasName].ToString()] = (string)_oData["EDFERRORCASE_MRT_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EDFErrorCase.Para.mrt_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(EDFErrorCase.Para.status).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_STATUS"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EDFErrorCase.Para.status).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EDFErrorCase.Para.status).AliasName].ToString()] = (string)_oData["EDFERRORCASE_STATUS"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EDFErrorCase.Para.status).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(EDFErrorCase.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EDFErrorCase.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EDFErrorCase.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["EDFERRORCASE_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EDFErrorCase.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(EDFErrorCase.Para.remark).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_REMARK"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EDFErrorCase.Para.remark).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EDFErrorCase.Para.remark).AliasName].ToString()] = (string)_oData["EDFERRORCASE_REMARK"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EDFErrorCase.Para.remark).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(EDFErrorCase.Para.imei_status).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_IMEI_STATUS"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EDFErrorCase.Para.imei_status).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EDFErrorCase.Para.imei_status).AliasName].ToString()] = (string)_oData["EDFERRORCASE_IMEI_STATUS"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EDFErrorCase.Para.imei_status).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(EDFErrorCase.Para.imei_remark).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_IMEI_REMARK"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EDFErrorCase.Para.imei_remark).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EDFErrorCase.Para.imei_remark).AliasName].ToString()] = (string)_oData["EDFERRORCASE_IMEI_REMARK"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EDFErrorCase.Para.imei_remark).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(EDFErrorCase.Para.edf_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_EDF_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EDFErrorCase.Para.edf_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EDFErrorCase.Para.edf_no).AliasName].ToString()] = (string)_oData["EDFERRORCASE_EDF_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EDFErrorCase.Para.edf_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(EDFErrorCase.Para.order_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_ORDER_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EDFErrorCase.Para.order_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EDFErrorCase.Para.order_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["EDFERRORCASE_ORDER_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EDFErrorCase.Para.order_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(EDFErrorCase.Para.error_msg).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_ERROR_MSG"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EDFErrorCase.Para.error_msg).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EDFErrorCase.Para.error_msg).AliasName].ToString()] = (string)_oData["EDFERRORCASE_ERROR_MSG"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EDFErrorCase.Para.error_msg).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(EDFErrorCase.Para.did).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EDFErrorCase.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EDFErrorCase.Para.did).AliasName].ToString()] = (string)_oData["EDFERRORCASE_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EDFErrorCase.Para.did).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(EDFErrorCase.Para.ddate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EDFErrorCase.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EDFErrorCase.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["EDFERRORCASE_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EDFErrorCase.Para.ddate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(EDFErrorCase.Para.imei_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["EDFERRORCASE_IMEI_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EDFErrorCase.Para.imei_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EDFErrorCase.Para.imei_no).AliasName].ToString()] = (string)_oData["EDFERRORCASE_IMEI_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EDFErrorCase.Para.imei_no).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,EDFErrorCase x_oEDFErrorCaseRow)
        {
            return SetByDataSetRowProc(x_iROW, EDFErrorCase.Para.TableName(), x_oDataSet,x_oEDFErrorCaseRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,EDFErrorCase x_oEDFErrorCaseRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oEDFErrorCaseRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,EDFErrorCase x_oEDFErrorCaseRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                EDFErrorCaseInfo _oTableSet=EDFErrorCaseInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EDFErrorCase.Para.id).AliasName))
                    x_oEDFErrorCaseRow.id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EDFErrorCase.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EDFErrorCase.Para.cdate).AliasName))
                    x_oEDFErrorCaseRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EDFErrorCase.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EDFErrorCase.Para.cid).AliasName))
                    x_oEDFErrorCaseRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EDFErrorCase.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EDFErrorCase.Para.mrt_no).AliasName))
                    x_oEDFErrorCaseRow.mrt_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EDFErrorCase.Para.mrt_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EDFErrorCase.Para.status).AliasName))
                    x_oEDFErrorCaseRow.status = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EDFErrorCase.Para.status).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EDFErrorCase.Para.active).AliasName))
                    x_oEDFErrorCaseRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EDFErrorCase.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EDFErrorCase.Para.remark).AliasName))
                    x_oEDFErrorCaseRow.remark = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EDFErrorCase.Para.remark).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EDFErrorCase.Para.imei_status).AliasName))
                    x_oEDFErrorCaseRow.imei_status = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EDFErrorCase.Para.imei_status).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EDFErrorCase.Para.imei_no).AliasName))
                    x_oEDFErrorCaseRow.imei_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EDFErrorCase.Para.imei_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EDFErrorCase.Para.imei_remark).AliasName))
                    x_oEDFErrorCaseRow.imei_remark = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EDFErrorCase.Para.imei_remark).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EDFErrorCase.Para.edf_no).AliasName))
                    x_oEDFErrorCaseRow.edf_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EDFErrorCase.Para.edf_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EDFErrorCase.Para.order_id).AliasName))
                    x_oEDFErrorCaseRow.order_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EDFErrorCase.Para.order_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EDFErrorCase.Para.did).AliasName))
                    x_oEDFErrorCaseRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EDFErrorCase.Para.did).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EDFErrorCase.Para.ddate).AliasName))
                    x_oEDFErrorCaseRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EDFErrorCase.Para.ddate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EDFErrorCase.Para.error_msg).AliasName))
                    x_oEDFErrorCaseRow.error_msg = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EDFErrorCase.Para.error_msg).AliasName];
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
            return EDFErrorCaseRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static EDFErrorCaseEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return EDFErrorCaseRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static EDFErrorCaseEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return EDFErrorCaseRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return EDFErrorCaseRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return EDFErrorCaseRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return EDFErrorCaseRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sMrt_no,string x_sStatus,global::System.Nullable<bool> x_bActive,string x_sRemark,string x_sImei_status,string x_sImei_no,string x_sImei_remark,string x_sEdf_no,global::System.Nullable<int> x_iOrder_id,string x_sDid,global::System.Nullable<DateTime> x_dDdate,string x_sError_msg)
        {
            return EDFErrorCaseRepository.Insert(x_oDB, x_dCdate,x_sCid,x_sMrt_no,x_sStatus,x_bActive,x_sRemark,x_sImei_status,x_sImei_no,x_sImei_remark,x_sEdf_no,x_iOrder_id,x_sDid,x_dDdate,x_sError_msg);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,EDFErrorCase x_oEDFErrorCase)
        {
            return EDFErrorCaseRepository.InsertWithOutLastID(x_oDB,x_oEDFErrorCase);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sMrt_no,string x_sStatus,global::System.Nullable<bool> x_bActive,string x_sRemark,string x_sImei_status,string x_sImei_no,string x_sImei_remark,string x_sEdf_no,global::System.Nullable<int> x_iOrder_id,string x_sDid,global::System.Nullable<DateTime> x_dDdate,string x_sError_msg)
        {
            return EDFErrorCaseRepository.InsertReturnLastID_SP(x_oDB,x_dCdate,x_sCid,x_sMrt_no,x_sStatus,x_bActive,x_sRemark,x_sImei_status,x_sImei_no,x_sImei_remark,x_sEdf_no,x_iOrder_id,x_sDid,x_dDdate,x_sError_msg);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, EDFErrorCase x_oEDFErrorCase)
        {
            return EDFErrorCaseRepository.InsertReturnLastID_SP(x_oDB,x_oEDFErrorCase);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return EDFErrorCaseRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return EDFErrorCaseRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return EDFErrorCaseRepository.Delete(x_oDB, x_iId);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(EDFErrorCase x_oEDFErrorCaseRow){
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


