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
///-- Create date: <Create Date 2010-04-20>
///-- Description:	<Description,Table :[DOAProfileRecord],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [DOAProfileRecord] Business layer
    /// </summary>
    
    public abstract class DOAProfileRecordBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public DOAProfileRecordBalBase(){
        }
        ~DOAProfileRecordBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(DOAProfileRecord x_oDOAProfileRecord)
        {
            return GetDataSet(x_oDOAProfileRecord,null,DOAProfileRecordInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(DOAProfileRecord x_oDOAProfileRecord,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oDOAProfileRecord,x_oMergeDSet,DOAProfileRecordInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(DOAProfileRecord x_oDOAProfileRecord,DOAProfileRecordInfo x_oTableSet)
        {
            return GetDataSet(x_oDOAProfileRecord,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(DOAProfileRecord x_oDOAProfileRecord,global::System.Data.DataSet x_oMergeDSet,DOAProfileRecordInfo x_oTableSet)
        {
            return GetDataSet(x_oDOAProfileRecord,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(DOAProfileRecord x_oDOAProfileRecord,global::System.Data.DataSet x_oMergeDSet,DOAProfileRecordInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = DOAProfileRecordInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(DOAProfileRecord.Para.TableName());
            if (x_oTableSet.Fields(DOAProfileRecord.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DOAProfileRecord.Para.TableName()].Columns.Add(DOAProfileRecord.Para.id); }
            if (x_oTableSet.Fields(DOAProfileRecord.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DOAProfileRecord.Para.TableName()].Columns.Add(DOAProfileRecord.Para.cdate); }
            if (x_oTableSet.Fields(DOAProfileRecord.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DOAProfileRecord.Para.TableName()].Columns.Add(DOAProfileRecord.Para.cid); }
            if (x_oTableSet.Fields(DOAProfileRecord.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DOAProfileRecord.Para.TableName()].Columns.Add(DOAProfileRecord.Para.did); }
            if (x_oTableSet.Fields(DOAProfileRecord.Para.status).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DOAProfileRecord.Para.TableName()].Columns.Add(DOAProfileRecord.Para.status); }
            if (x_oTableSet.Fields(DOAProfileRecord.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DOAProfileRecord.Para.TableName()].Columns.Add(DOAProfileRecord.Para.active); }
            if (x_oTableSet.Fields(DOAProfileRecord.Para.imei_stock_remark).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DOAProfileRecord.Para.TableName()].Columns.Add(DOAProfileRecord.Para.imei_stock_remark); }
            if (x_oTableSet.Fields(DOAProfileRecord.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DOAProfileRecord.Para.TableName()].Columns.Add(DOAProfileRecord.Para.edate); }
            if (x_oTableSet.Fields(DOAProfileRecord.Para.edf_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DOAProfileRecord.Para.TableName()].Columns.Add(DOAProfileRecord.Para.edf_no); }
            if (x_oTableSet.Fields(DOAProfileRecord.Para.used).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DOAProfileRecord.Para.TableName()].Columns.Add(DOAProfileRecord.Para.used); }
            if (x_oTableSet.Fields(DOAProfileRecord.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DOAProfileRecord.Para.TableName()].Columns.Add(DOAProfileRecord.Para.order_id); }
            if (x_oTableSet.Fields(DOAProfileRecord.Para.order_dn_remark).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DOAProfileRecord.Para.TableName()].Columns.Add(DOAProfileRecord.Para.order_dn_remark); }
            if (x_oTableSet.Fields(DOAProfileRecord.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DOAProfileRecord.Para.TableName()].Columns.Add(DOAProfileRecord.Para.ddate); }
            if (x_oTableSet.Fields(DOAProfileRecord.Para.imei_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DOAProfileRecord.Para.TableName()].Columns.Add(DOAProfileRecord.Para.imei_no); }
            if (x_oTableSet.Fields(DOAProfileRecord.Para.order_remark).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DOAProfileRecord.Para.TableName()].Columns.Add(DOAProfileRecord.Para.order_remark); }
            if (x_oDOAProfileRecord != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[DOAProfileRecord.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(DOAProfileRecord.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[DOAProfileRecord.Para.id] = x_oDOAProfileRecord.GetId(); }
                if (x_oTableSet.Fields(DOAProfileRecord.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[DOAProfileRecord.Para.cdate] = x_oDOAProfileRecord.GetCdate(); }
                if (x_oTableSet.Fields(DOAProfileRecord.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[DOAProfileRecord.Para.cid] = x_oDOAProfileRecord.GetCid(); }
                if (x_oTableSet.Fields(DOAProfileRecord.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[DOAProfileRecord.Para.did] = x_oDOAProfileRecord.GetDid(); }
                if (x_oTableSet.Fields(DOAProfileRecord.Para.status).IsView || x_oTableSet.GetViewAll()) { _oDRow[DOAProfileRecord.Para.status] = x_oDOAProfileRecord.GetStatus(); }
                if (x_oTableSet.Fields(DOAProfileRecord.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[DOAProfileRecord.Para.active] = x_oDOAProfileRecord.GetActive(); }
                if (x_oTableSet.Fields(DOAProfileRecord.Para.imei_stock_remark).IsView || x_oTableSet.GetViewAll()) { _oDRow[DOAProfileRecord.Para.imei_stock_remark] = x_oDOAProfileRecord.GetImei_stock_remark(); }
                if (x_oTableSet.Fields(DOAProfileRecord.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDRow[DOAProfileRecord.Para.edate] = x_oDOAProfileRecord.GetEdate(); }
                if (x_oTableSet.Fields(DOAProfileRecord.Para.edf_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[DOAProfileRecord.Para.edf_no] = x_oDOAProfileRecord.GetEdf_no(); }
                if (x_oTableSet.Fields(DOAProfileRecord.Para.used).IsView || x_oTableSet.GetViewAll()) { _oDRow[DOAProfileRecord.Para.used] = x_oDOAProfileRecord.GetUsed(); }
                if (x_oTableSet.Fields(DOAProfileRecord.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[DOAProfileRecord.Para.order_id] = x_oDOAProfileRecord.GetOrder_id(); }
                if (x_oTableSet.Fields(DOAProfileRecord.Para.order_dn_remark).IsView || x_oTableSet.GetViewAll()) { _oDRow[DOAProfileRecord.Para.order_dn_remark] = x_oDOAProfileRecord.GetOrder_dn_remark(); }
                if (x_oTableSet.Fields(DOAProfileRecord.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[DOAProfileRecord.Para.ddate] = x_oDOAProfileRecord.GetDdate(); }
                if (x_oTableSet.Fields(DOAProfileRecord.Para.imei_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[DOAProfileRecord.Para.imei_no] = x_oDOAProfileRecord.GetImei_no(); }
                if (x_oTableSet.Fields(DOAProfileRecord.Para.order_remark).IsView || x_oTableSet.GetViewAll()) { _oDRow[DOAProfileRecord.Para.order_remark] = x_oDOAProfileRecord.GetOrder_remark(); }
                _oDSet.Tables[DOAProfileRecord.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(DOAProfileRecordInfo x_oTableSet)
        {
            return DOAProfileRecordBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return DOAProfileRecordBal.ToEmptyDataSetProcess(DOAProfileRecordInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(DOAProfileRecordInfo x_oTableSet)
        {
            return DOAProfileRecordBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(DOAProfileRecord x_oDOAProfileRecord, DOAProfileRecordInfo x_oTableSet)
        {
            return DOAProfileRecordBal.GetDataSet(null, null, x_oTableSet).Tables[DOAProfileRecord.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(DOAProfileRecord x_oDOAProfileRecord)
        {
            return DOAProfileRecordBal.GetDataSet(x_oDOAProfileRecord, null, DOAProfileRecordInfoDLL.CreateInfoInstanceObject()).Tables[DOAProfileRecord.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return Row(x_oTable, x_oDB,x_iId,DOAProfileRecordInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId, DOAProfileRecordInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iId, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId,DOAProfileRecordInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = DOAProfileRecordInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [DOAProfileRecord].[id] AS DOAPROFILERECORD_ID,[DOAProfileRecord].[cdate] AS DOAPROFILERECORD_CDATE,[DOAProfileRecord].[cid] AS DOAPROFILERECORD_CID,[DOAProfileRecord].[did] AS DOAPROFILERECORD_DID,[DOAProfileRecord].[status] AS DOAPROFILERECORD_STATUS,[DOAProfileRecord].[active] AS DOAPROFILERECORD_ACTIVE,[DOAProfileRecord].[order_remark] AS DOAPROFILERECORD_ORDER_REMARK,[DOAProfileRecord].[edate] AS DOAPROFILERECORD_EDATE,[DOAProfileRecord].[edf_no] AS DOAPROFILERECORD_EDF_NO,[DOAProfileRecord].[used] AS DOAPROFILERECORD_USED,[DOAProfileRecord].[order_id] AS DOAPROFILERECORD_ORDER_ID,[DOAProfileRecord].[order_dn_remark] AS DOAPROFILERECORD_ORDER_DN_REMARK,[DOAProfileRecord].[ddate] AS DOAPROFILERECORD_DDATE,[DOAProfileRecord].[imei_no] AS DOAPROFILERECORD_IMEI_NO,[DOAProfileRecord].[imei_stock_remark] AS DOAPROFILERECORD_IMEI_STOCK_REMARK  FROM  [DOAProfileRecord]  WHERE  [DOAProfileRecord].[id] = \'"+x_iId.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DOAProfileRecord]","["+ Configurator.MSSQLTablePrefix + "DOAProfileRecord]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(DOAProfileRecord.Para.id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DOAProfileRecord.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DOAProfileRecord.Para.id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["DOAPROFILERECORD_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DOAProfileRecord.Para.id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(DOAProfileRecord.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DOAProfileRecord.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DOAProfileRecord.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["DOAPROFILERECORD_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DOAProfileRecord.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(DOAProfileRecord.Para.cid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DOAProfileRecord.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DOAProfileRecord.Para.cid).AliasName].ToString()] = (string)_oData["DOAPROFILERECORD_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DOAProfileRecord.Para.cid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(DOAProfileRecord.Para.did).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DOAProfileRecord.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DOAProfileRecord.Para.did).AliasName].ToString()] = (string)_oData["DOAPROFILERECORD_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DOAProfileRecord.Para.did).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(DOAProfileRecord.Para.status).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_STATUS"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DOAProfileRecord.Para.status).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DOAProfileRecord.Para.status).AliasName].ToString()] = (string)_oData["DOAPROFILERECORD_STATUS"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DOAProfileRecord.Para.status).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(DOAProfileRecord.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DOAProfileRecord.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DOAProfileRecord.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["DOAPROFILERECORD_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DOAProfileRecord.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(DOAProfileRecord.Para.order_remark).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_ORDER_REMARK"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DOAProfileRecord.Para.order_remark).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DOAProfileRecord.Para.order_remark).AliasName].ToString()] = (string)_oData["DOAPROFILERECORD_ORDER_REMARK"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DOAProfileRecord.Para.order_remark).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(DOAProfileRecord.Para.edate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_EDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DOAProfileRecord.Para.edate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DOAProfileRecord.Para.edate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["DOAPROFILERECORD_EDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DOAProfileRecord.Para.edate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(DOAProfileRecord.Para.edf_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_EDF_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DOAProfileRecord.Para.edf_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DOAProfileRecord.Para.edf_no).AliasName].ToString()] = (string)_oData["DOAPROFILERECORD_EDF_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DOAProfileRecord.Para.edf_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(DOAProfileRecord.Para.used).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_USED"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DOAProfileRecord.Para.used).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DOAProfileRecord.Para.used).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["DOAPROFILERECORD_USED"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DOAProfileRecord.Para.used).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(DOAProfileRecord.Para.order_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_ORDER_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DOAProfileRecord.Para.order_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DOAProfileRecord.Para.order_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["DOAPROFILERECORD_ORDER_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DOAProfileRecord.Para.order_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(DOAProfileRecord.Para.order_dn_remark).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_ORDER_DN_REMARK"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DOAProfileRecord.Para.order_dn_remark).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DOAProfileRecord.Para.order_dn_remark).AliasName].ToString()] = (string)_oData["DOAPROFILERECORD_ORDER_DN_REMARK"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DOAProfileRecord.Para.order_dn_remark).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(DOAProfileRecord.Para.ddate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DOAProfileRecord.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DOAProfileRecord.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["DOAPROFILERECORD_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DOAProfileRecord.Para.ddate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(DOAProfileRecord.Para.imei_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_IMEI_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DOAProfileRecord.Para.imei_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DOAProfileRecord.Para.imei_no).AliasName].ToString()] = (string)_oData["DOAPROFILERECORD_IMEI_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DOAProfileRecord.Para.imei_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(DOAProfileRecord.Para.imei_stock_remark).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["DOAPROFILERECORD_IMEI_STOCK_REMARK"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DOAProfileRecord.Para.imei_stock_remark).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DOAProfileRecord.Para.imei_stock_remark).AliasName].ToString()] = (string)_oData["DOAPROFILERECORD_IMEI_STOCK_REMARK"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DOAProfileRecord.Para.imei_stock_remark).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,DOAProfileRecord x_oDOAProfileRecordRow)
        {
            return SetByDataSetRowProc(x_iROW, DOAProfileRecord.Para.TableName(), x_oDataSet,x_oDOAProfileRecordRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,DOAProfileRecord x_oDOAProfileRecordRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oDOAProfileRecordRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,DOAProfileRecord x_oDOAProfileRecordRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                DOAProfileRecordInfo _oTableSet=DOAProfileRecordInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DOAProfileRecord.Para.id).AliasName))
                    x_oDOAProfileRecordRow.id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DOAProfileRecord.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DOAProfileRecord.Para.cdate).AliasName))
                    x_oDOAProfileRecordRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DOAProfileRecord.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DOAProfileRecord.Para.cid).AliasName))
                    x_oDOAProfileRecordRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DOAProfileRecord.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DOAProfileRecord.Para.did).AliasName))
                    x_oDOAProfileRecordRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DOAProfileRecord.Para.did).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DOAProfileRecord.Para.status).AliasName))
                    x_oDOAProfileRecordRow.status = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DOAProfileRecord.Para.status).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DOAProfileRecord.Para.active).AliasName))
                    x_oDOAProfileRecordRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DOAProfileRecord.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DOAProfileRecord.Para.imei_stock_remark).AliasName))
                    x_oDOAProfileRecordRow.imei_stock_remark = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DOAProfileRecord.Para.imei_stock_remark).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DOAProfileRecord.Para.edate).AliasName))
                    x_oDOAProfileRecordRow.edate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DOAProfileRecord.Para.edate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DOAProfileRecord.Para.edf_no).AliasName))
                    x_oDOAProfileRecordRow.edf_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DOAProfileRecord.Para.edf_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DOAProfileRecord.Para.used).AliasName))
                    x_oDOAProfileRecordRow.used = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DOAProfileRecord.Para.used).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DOAProfileRecord.Para.order_id).AliasName))
                    x_oDOAProfileRecordRow.order_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DOAProfileRecord.Para.order_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DOAProfileRecord.Para.order_dn_remark).AliasName))
                    x_oDOAProfileRecordRow.order_dn_remark = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DOAProfileRecord.Para.order_dn_remark).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DOAProfileRecord.Para.ddate).AliasName))
                    x_oDOAProfileRecordRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DOAProfileRecord.Para.ddate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DOAProfileRecord.Para.imei_no).AliasName))
                    x_oDOAProfileRecordRow.imei_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DOAProfileRecord.Para.imei_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DOAProfileRecord.Para.order_remark).AliasName))
                    x_oDOAProfileRecordRow.order_remark = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DOAProfileRecord.Para.order_remark).AliasName];
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
            return DOAProfileRecordRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static DOAProfileRecordEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return DOAProfileRecordRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static DOAProfileRecordEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return DOAProfileRecordRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return DOAProfileRecordRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return DOAProfileRecordRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return DOAProfileRecordRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sStatus,global::System.Nullable<bool> x_bActive,string x_sImei_stock_remark,global::System.Nullable<DateTime> x_dEdate,string x_sEdf_no,global::System.Nullable<bool> x_bUsed,global::System.Nullable<int> x_iOrder_id,string x_sOrder_dn_remark,global::System.Nullable<DateTime> x_dDdate,string x_sImei_no,string x_sOrder_remark)
        {
            return DOAProfileRecordRepository.Insert(x_oDB, x_dCdate,x_sCid,x_sDid,x_sStatus,x_bActive,x_sImei_stock_remark,x_dEdate,x_sEdf_no,x_bUsed,x_iOrder_id,x_sOrder_dn_remark,x_dDdate,x_sImei_no,x_sOrder_remark);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,DOAProfileRecord x_oDOAProfileRecord)
        {
            return DOAProfileRecordRepository.InsertWithOutLastID(x_oDB,x_oDOAProfileRecord);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sStatus,global::System.Nullable<bool> x_bActive,string x_sImei_stock_remark,global::System.Nullable<DateTime> x_dEdate,string x_sEdf_no,global::System.Nullable<bool> x_bUsed,global::System.Nullable<int> x_iOrder_id,string x_sOrder_dn_remark,global::System.Nullable<DateTime> x_dDdate,string x_sImei_no,string x_sOrder_remark)
        {
            return DOAProfileRecordRepository.InsertReturnLastID_SP(x_oDB,x_dCdate,x_sCid,x_sDid,x_sStatus,x_bActive,x_sImei_stock_remark,x_dEdate,x_sEdf_no,x_bUsed,x_iOrder_id,x_sOrder_dn_remark,x_dDdate,x_sImei_no,x_sOrder_remark);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, DOAProfileRecord x_oDOAProfileRecord)
        {
            return DOAProfileRecordRepository.InsertReturnLastID_SP(x_oDB,x_oDOAProfileRecord);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return DOAProfileRecordRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return DOAProfileRecordRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return DOAProfileRecordRepository.Delete(x_oDB, x_iId);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(DOAProfileRecord x_oDOAProfileRecordRow){
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


