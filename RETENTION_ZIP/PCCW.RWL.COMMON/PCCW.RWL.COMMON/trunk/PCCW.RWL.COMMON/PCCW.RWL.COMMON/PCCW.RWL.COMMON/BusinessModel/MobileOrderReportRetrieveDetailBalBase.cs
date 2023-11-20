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
///-- Create date: <Create Date 2010-10-29>
///-- Description:	<Description,Table :[MobileOrderReportRetrieveDetail],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderReportRetrieveDetail] Business layer
    /// </summary>
    
    public abstract class MobileOrderReportRetrieveDetailBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public MobileOrderReportRetrieveDetailBalBase(){
        }
        ~MobileOrderReportRetrieveDetailBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderReportRetrieveDetail x_oMobileOrderReportRetrieveDetail)
        {
            return GetDataSet(x_oMobileOrderReportRetrieveDetail,null,MobileOrderReportRetrieveDetailInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderReportRetrieveDetail x_oMobileOrderReportRetrieveDetail,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oMobileOrderReportRetrieveDetail,x_oMergeDSet,MobileOrderReportRetrieveDetailInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderReportRetrieveDetail x_oMobileOrderReportRetrieveDetail,MobileOrderReportRetrieveDetailInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderReportRetrieveDetail,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderReportRetrieveDetail x_oMobileOrderReportRetrieveDetail,global::System.Data.DataSet x_oMergeDSet,MobileOrderReportRetrieveDetailInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderReportRetrieveDetail,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(MobileOrderReportRetrieveDetail x_oMobileOrderReportRetrieveDetail,global::System.Data.DataSet x_oMergeDSet,MobileOrderReportRetrieveDetailInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderReportRetrieveDetailInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(MobileOrderReportRetrieveDetail.Para.TableName());
            if (x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportRetrieveDetail.Para.TableName()].Columns.Add(MobileOrderReportRetrieveDetail.Para.id); }
            if (x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportRetrieveDetail.Para.TableName()].Columns.Add(MobileOrderReportRetrieveDetail.Para.did); }
            if (x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportRetrieveDetail.Para.TableName()].Columns.Add(MobileOrderReportRetrieveDetail.Para.active); }
            if (x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.guid_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportRetrieveDetail.Para.TableName()].Columns.Add(MobileOrderReportRetrieveDetail.Para.guid_id); }
            if (x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.retrieve_group).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportRetrieveDetail.Para.TableName()].Columns.Add(MobileOrderReportRetrieveDetail.Para.retrieve_group); }
            if (x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.retrieve_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportRetrieveDetail.Para.TableName()].Columns.Add(MobileOrderReportRetrieveDetail.Para.retrieve_date); }
            if (x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportRetrieveDetail.Para.TableName()].Columns.Add(MobileOrderReportRetrieveDetail.Para.ddate); }
            if (x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.retrieve_sn).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportRetrieveDetail.Para.TableName()].Columns.Add(MobileOrderReportRetrieveDetail.Para.retrieve_sn); }
            if (x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.report_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportRetrieveDetail.Para.TableName()].Columns.Add(MobileOrderReportRetrieveDetail.Para.report_type); }
            if (x_oMobileOrderReportRetrieveDetail != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[MobileOrderReportRetrieveDetail.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportRetrieveDetail.Para.id] = x_oMobileOrderReportRetrieveDetail.GetId(); }
                if (x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportRetrieveDetail.Para.did] = x_oMobileOrderReportRetrieveDetail.GetDid(); }
                if (x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportRetrieveDetail.Para.active] = x_oMobileOrderReportRetrieveDetail.GetActive(); }
                if (x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.guid_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportRetrieveDetail.Para.guid_id] = x_oMobileOrderReportRetrieveDetail.GetGuid_id(); }
                if (x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.retrieve_group).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportRetrieveDetail.Para.retrieve_group] = x_oMobileOrderReportRetrieveDetail.GetRetrieve_group(); }
                if (x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.retrieve_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportRetrieveDetail.Para.retrieve_date] = x_oMobileOrderReportRetrieveDetail.GetRetrieve_date(); }
                if (x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportRetrieveDetail.Para.ddate] = x_oMobileOrderReportRetrieveDetail.GetDdate(); }
                if (x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.retrieve_sn).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportRetrieveDetail.Para.retrieve_sn] = x_oMobileOrderReportRetrieveDetail.GetRetrieve_sn(); }
                if (x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.report_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportRetrieveDetail.Para.report_type] = x_oMobileOrderReportRetrieveDetail.GetReport_type(); }
                _oDSet.Tables[MobileOrderReportRetrieveDetail.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(MobileOrderReportRetrieveDetailInfo x_oTableSet)
        {
            return MobileOrderReportRetrieveDetailBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return MobileOrderReportRetrieveDetailBal.ToEmptyDataSetProcess(MobileOrderReportRetrieveDetailInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(MobileOrderReportRetrieveDetailInfo x_oTableSet)
        {
            return MobileOrderReportRetrieveDetailBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(MobileOrderReportRetrieveDetail x_oMobileOrderReportRetrieveDetail, MobileOrderReportRetrieveDetailInfo x_oTableSet)
        {
            return MobileOrderReportRetrieveDetailBal.GetDataSet(null, null, x_oTableSet).Tables[MobileOrderReportRetrieveDetail.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(MobileOrderReportRetrieveDetail x_oMobileOrderReportRetrieveDetail)
        {
            return MobileOrderReportRetrieveDetailBal.GetDataSet(x_oMobileOrderReportRetrieveDetail, null, MobileOrderReportRetrieveDetailInfoDLL.CreateInfoInstanceObject()).Tables[MobileOrderReportRetrieveDetail.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<Guid> x_gGuid_id)
        {
            return Row(x_oTable, x_oDB,x_gGuid_id,MobileOrderReportRetrieveDetailInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<Guid> x_gGuid_id, MobileOrderReportRetrieveDetailInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_gGuid_id, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<Guid> x_gGuid_id,MobileOrderReportRetrieveDetailInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderReportRetrieveDetailInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [MobileOrderReportRetrieveDetail].[id] AS MOBILEORDERREPORTRETRIEVEDETAIL_ID,[MobileOrderReportRetrieveDetail].[active] AS MOBILEORDERREPORTRETRIEVEDETAIL_ACTIVE,[MobileOrderReportRetrieveDetail].[did] AS MOBILEORDERREPORTRETRIEVEDETAIL_DID,[MobileOrderReportRetrieveDetail].[guid_id] AS MOBILEORDERREPORTRETRIEVEDETAIL_GUID_ID,[MobileOrderReportRetrieveDetail].[retrieve_group] AS MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_GROUP,[MobileOrderReportRetrieveDetail].[retrieve_date] AS MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_DATE,[MobileOrderReportRetrieveDetail].[ddate] AS MOBILEORDERREPORTRETRIEVEDETAIL_DDATE,[MobileOrderReportRetrieveDetail].[retrieve_sn] AS MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_SN,[MobileOrderReportRetrieveDetail].[report_type] AS MOBILEORDERREPORTRETRIEVEDETAIL_REPORT_TYPE  FROM  [MobileOrderReportRetrieveDetail]  WHERE  [MobileOrderReportRetrieveDetail].[guid_id] = \'"+x_gGuid_id.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportRetrieveDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportRetrieveDetail]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.did).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.did).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.did).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.guid_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_GUID_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.guid_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.guid_id).AliasName].ToString()] = (global::System.Nullable<Guid>)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_GUID_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.guid_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.retrieve_group).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_GROUP"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.retrieve_group).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.retrieve_group).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_GROUP"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.retrieve_group).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.retrieve_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.retrieve_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.retrieve_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.retrieve_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.ddate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.ddate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.retrieve_sn).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_SN"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.retrieve_sn).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.retrieve_sn).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_SN"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.retrieve_sn).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.report_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_REPORT_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.report_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.report_type).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_REPORT_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.report_type).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,MobileOrderReportRetrieveDetail x_oMobileOrderReportRetrieveDetailRow)
        {
            return SetByDataSetRowProc(x_iROW, MobileOrderReportRetrieveDetail.Para.TableName(), x_oDataSet,x_oMobileOrderReportRetrieveDetailRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderReportRetrieveDetail x_oMobileOrderReportRetrieveDetailRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oMobileOrderReportRetrieveDetailRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderReportRetrieveDetail x_oMobileOrderReportRetrieveDetailRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                MobileOrderReportRetrieveDetailInfo _oTableSet=MobileOrderReportRetrieveDetailInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.id).AliasName))
                    x_oMobileOrderReportRetrieveDetailRow.id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.did).AliasName))
                    x_oMobileOrderReportRetrieveDetailRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.did).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.active).AliasName))
                    x_oMobileOrderReportRetrieveDetailRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.guid_id).AliasName))
                    x_oMobileOrderReportRetrieveDetailRow.guid_id = (global::System.Nullable<Guid>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.guid_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.retrieve_group).AliasName))
                    x_oMobileOrderReportRetrieveDetailRow.retrieve_group = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.retrieve_group).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.retrieve_date).AliasName))
                    x_oMobileOrderReportRetrieveDetailRow.retrieve_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.retrieve_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.ddate).AliasName))
                    x_oMobileOrderReportRetrieveDetailRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.ddate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.retrieve_sn).AliasName))
                    x_oMobileOrderReportRetrieveDetailRow.retrieve_sn = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.retrieve_sn).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.report_type).AliasName))
                    x_oMobileOrderReportRetrieveDetailRow.report_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportRetrieveDetail.Para.report_type).AliasName];
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
            return MobileOrderReportRetrieveDetailRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static MobileOrderReportRetrieveDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return MobileOrderReportRetrieveDetailRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static MobileOrderReportRetrieveDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return MobileOrderReportRetrieveDetailRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderReportRetrieveDetailRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderReportRetrieveDetailRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderReportRetrieveDetailRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sDid,global::System.Nullable<bool> x_bActive,global::System.Nullable<Guid> x_gGuid_id,string x_sRetrieve_group,global::System.Nullable<DateTime> x_dRetrieve_date,global::System.Nullable<DateTime> x_dDdate,string x_sRetrieve_sn,string x_sReport_type)
        {
            return MobileOrderReportRetrieveDetailRepository.Insert(x_oDB, x_sDid,x_bActive,x_gGuid_id,x_sRetrieve_group,x_dRetrieve_date,x_dDdate,x_sRetrieve_sn,x_sReport_type);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderReportRetrieveDetail x_oMobileOrderReportRetrieveDetail)
        {
            return MobileOrderReportRetrieveDetailRepository.InsertWithOutLastID(x_oDB,x_oMobileOrderReportRetrieveDetail);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sDid,global::System.Nullable<bool> x_bActive,global::System.Nullable<Guid> x_gGuid_id,string x_sRetrieve_group,global::System.Nullable<DateTime> x_dRetrieve_date,global::System.Nullable<DateTime> x_dDdate,string x_sRetrieve_sn,string x_sReport_type)
        {
            return MobileOrderReportRetrieveDetailRepository.InsertReturnLastID_SP(x_oDB,x_sDid,x_bActive,x_gGuid_id,x_sRetrieve_group,x_dRetrieve_date,x_dDdate,x_sRetrieve_sn,x_sReport_type);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderReportRetrieveDetail x_oMobileOrderReportRetrieveDetail)
        {
            return MobileOrderReportRetrieveDetailRepository.InsertReturnLastID_SP(x_oDB,x_oMobileOrderReportRetrieveDetail);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return MobileOrderReportRetrieveDetailRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderReportRetrieveDetailRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<Guid> x_gGuid_id,global::System.Nullable<bool> x_bActive)
        {
            return MobileOrderReportRetrieveDetailRepository.Delete(x_oDB, x_gGuid_id,x_bActive);
        }
        
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return MobileOrderReportRetrieveDetailRepository.Delete(x_oDB, x_iId);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(MobileOrderReportRetrieveDetail x_oMobileOrderReportRetrieveDetailRow){
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


