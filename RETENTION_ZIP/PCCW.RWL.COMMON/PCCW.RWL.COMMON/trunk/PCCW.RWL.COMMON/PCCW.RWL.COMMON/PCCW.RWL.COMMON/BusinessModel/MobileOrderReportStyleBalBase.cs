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
///-- Description:	<Description,Table :[MobileOrderReportStyle],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderReportStyle] Business layer
    /// </summary>
    
    public abstract class MobileOrderReportStyleBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public MobileOrderReportStyleBalBase(){
        }
        ~MobileOrderReportStyleBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderReportStyle x_oMobileOrderReportStyle)
        {
            return GetDataSet(x_oMobileOrderReportStyle,null,MobileOrderReportStyleInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderReportStyle x_oMobileOrderReportStyle,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oMobileOrderReportStyle,x_oMergeDSet,MobileOrderReportStyleInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderReportStyle x_oMobileOrderReportStyle,MobileOrderReportStyleInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderReportStyle,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderReportStyle x_oMobileOrderReportStyle,global::System.Data.DataSet x_oMergeDSet,MobileOrderReportStyleInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderReportStyle,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(MobileOrderReportStyle x_oMobileOrderReportStyle,global::System.Data.DataSet x_oMergeDSet,MobileOrderReportStyleInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderReportStyleInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(MobileOrderReportStyle.Para.TableName());
            if (x_oTableSet.Fields(MobileOrderReportStyle.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportStyle.Para.TableName()].Columns.Add(MobileOrderReportStyle.Para.id); }
            if (x_oTableSet.Fields(MobileOrderReportStyle.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportStyle.Para.TableName()].Columns.Add(MobileOrderReportStyle.Para.cdate); }
            if (x_oTableSet.Fields(MobileOrderReportStyle.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportStyle.Para.TableName()].Columns.Add(MobileOrderReportStyle.Para.cid); }
            if (x_oTableSet.Fields(MobileOrderReportStyle.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportStyle.Para.TableName()].Columns.Add(MobileOrderReportStyle.Para.active); }
            if (x_oTableSet.Fields(MobileOrderReportStyle.Para.status).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportStyle.Para.TableName()].Columns.Add(MobileOrderReportStyle.Para.status); }
            if (x_oTableSet.Fields(MobileOrderReportStyle.Para.type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportStyle.Para.TableName()].Columns.Add(MobileOrderReportStyle.Para.type); }
            if (x_oTableSet.Fields(MobileOrderReportStyle.Para.report_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportStyle.Para.TableName()].Columns.Add(MobileOrderReportStyle.Para.report_id); }
            if (x_oTableSet.Fields(MobileOrderReportStyle.Para.format).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportStyle.Para.TableName()].Columns.Add(MobileOrderReportStyle.Para.format); }
            if (x_oTableSet.Fields(MobileOrderReportStyle.Para.vas_show).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportStyle.Para.TableName()].Columns.Add(MobileOrderReportStyle.Para.vas_show); }
            if (x_oMobileOrderReportStyle != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[MobileOrderReportStyle.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(MobileOrderReportStyle.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportStyle.Para.id] = x_oMobileOrderReportStyle.GetId(); }
                if (x_oTableSet.Fields(MobileOrderReportStyle.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportStyle.Para.cdate] = x_oMobileOrderReportStyle.GetCdate(); }
                if (x_oTableSet.Fields(MobileOrderReportStyle.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportStyle.Para.cid] = x_oMobileOrderReportStyle.GetCid(); }
                if (x_oTableSet.Fields(MobileOrderReportStyle.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportStyle.Para.active] = x_oMobileOrderReportStyle.GetActive(); }
                if (x_oTableSet.Fields(MobileOrderReportStyle.Para.status).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportStyle.Para.status] = x_oMobileOrderReportStyle.GetStatus(); }
                if (x_oTableSet.Fields(MobileOrderReportStyle.Para.type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportStyle.Para.type] = x_oMobileOrderReportStyle.GetType(); }
                if (x_oTableSet.Fields(MobileOrderReportStyle.Para.report_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportStyle.Para.report_id] = x_oMobileOrderReportStyle.GetReport_id(); }
                if (x_oTableSet.Fields(MobileOrderReportStyle.Para.format).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportStyle.Para.format] = x_oMobileOrderReportStyle.GetFormat(); }
                if (x_oTableSet.Fields(MobileOrderReportStyle.Para.vas_show).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportStyle.Para.vas_show] = x_oMobileOrderReportStyle.GetVas_show(); }
                _oDSet.Tables[MobileOrderReportStyle.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(MobileOrderReportStyleInfo x_oTableSet)
        {
            return MobileOrderReportStyleBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return MobileOrderReportStyleBal.ToEmptyDataSetProcess(MobileOrderReportStyleInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(MobileOrderReportStyleInfo x_oTableSet)
        {
            return MobileOrderReportStyleBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(MobileOrderReportStyle x_oMobileOrderReportStyle, MobileOrderReportStyleInfo x_oTableSet)
        {
            return MobileOrderReportStyleBal.GetDataSet(null, null, x_oTableSet).Tables[MobileOrderReportStyle.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(MobileOrderReportStyle x_oMobileOrderReportStyle)
        {
            return MobileOrderReportStyleBal.GetDataSet(x_oMobileOrderReportStyle, null, MobileOrderReportStyleInfoDLL.CreateInfoInstanceObject()).Tables[MobileOrderReportStyle.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return Row(x_oTable, x_oDB,x_iId,MobileOrderReportStyleInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId, MobileOrderReportStyleInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iId, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId,MobileOrderReportStyleInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderReportStyleInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [MobileOrderReportStyle].[id] AS MOBILEORDERREPORTSTYLE_ID,[MobileOrderReportStyle].[cdate] AS MOBILEORDERREPORTSTYLE_CDATE,[MobileOrderReportStyle].[cid] AS MOBILEORDERREPORTSTYLE_CID,[MobileOrderReportStyle].[active] AS MOBILEORDERREPORTSTYLE_ACTIVE,[MobileOrderReportStyle].[status] AS MOBILEORDERREPORTSTYLE_STATUS,[MobileOrderReportStyle].[type] AS MOBILEORDERREPORTSTYLE_TYPE,[MobileOrderReportStyle].[report_id] AS MOBILEORDERREPORTSTYLE_REPORT_ID,[MobileOrderReportStyle].[vas_show] AS MOBILEORDERREPORTSTYLE_VAS_SHOW,[MobileOrderReportStyle].[format] AS MOBILEORDERREPORTSTYLE_FORMAT  FROM  [MobileOrderReportStyle]  WHERE  [MobileOrderReportStyle].[id] = \'"+x_iId.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportStyle]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportStyle]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(MobileOrderReportStyle.Para.id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportStyle.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportStyle.Para.id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTSTYLE_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportStyle.Para.id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportStyle.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportStyle.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportStyle.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTSTYLE_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportStyle.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportStyle.Para.cid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportStyle.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportStyle.Para.cid).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTSTYLE_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportStyle.Para.cid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportStyle.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportStyle.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportStyle.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTSTYLE_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportStyle.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportStyle.Para.status).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_STATUS"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportStyle.Para.status).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportStyle.Para.status).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTSTYLE_STATUS"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportStyle.Para.status).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportStyle.Para.type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportStyle.Para.type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportStyle.Para.type).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTSTYLE_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportStyle.Para.type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportStyle.Para.report_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_REPORT_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportStyle.Para.report_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportStyle.Para.report_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTSTYLE_REPORT_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportStyle.Para.report_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportStyle.Para.vas_show).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_VAS_SHOW"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportStyle.Para.vas_show).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportStyle.Para.vas_show).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTSTYLE_VAS_SHOW"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportStyle.Para.vas_show).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportStyle.Para.format).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_FORMAT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportStyle.Para.format).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportStyle.Para.format).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTSTYLE_FORMAT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportStyle.Para.format).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,MobileOrderReportStyle x_oMobileOrderReportStyleRow)
        {
            return SetByDataSetRowProc(x_iROW, MobileOrderReportStyle.Para.TableName(), x_oDataSet,x_oMobileOrderReportStyleRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderReportStyle x_oMobileOrderReportStyleRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oMobileOrderReportStyleRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderReportStyle x_oMobileOrderReportStyleRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                MobileOrderReportStyleInfo _oTableSet=MobileOrderReportStyleInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportStyle.Para.id).AliasName))
                    x_oMobileOrderReportStyleRow.id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportStyle.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportStyle.Para.cdate).AliasName))
                    x_oMobileOrderReportStyleRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportStyle.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportStyle.Para.cid).AliasName))
                    x_oMobileOrderReportStyleRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportStyle.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportStyle.Para.active).AliasName))
                    x_oMobileOrderReportStyleRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportStyle.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportStyle.Para.status).AliasName))
                    x_oMobileOrderReportStyleRow.status = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportStyle.Para.status).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportStyle.Para.type).AliasName))
                    x_oMobileOrderReportStyleRow.type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportStyle.Para.type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportStyle.Para.report_id).AliasName))
                    x_oMobileOrderReportStyleRow.report_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportStyle.Para.report_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportStyle.Para.format).AliasName))
                    x_oMobileOrderReportStyleRow.format = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportStyle.Para.format).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportStyle.Para.vas_show).AliasName))
                    x_oMobileOrderReportStyleRow.vas_show = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportStyle.Para.vas_show).AliasName];
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
            return MobileOrderReportStyleRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static MobileOrderReportStyleEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return MobileOrderReportStyleRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static MobileOrderReportStyleEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return MobileOrderReportStyleRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderReportStyleRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderReportStyleRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderReportStyleRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate,string x_sCid,global::System.Nullable<bool> x_bActive,string x_sStatus,string x_sType,global::System.Nullable<int> x_iReport_id,string x_sFormat,global::System.Nullable<bool> x_bVas_show)
        {
            return MobileOrderReportStyleRepository.Insert(x_oDB, x_dCdate,x_sCid,x_bActive,x_sStatus,x_sType,x_iReport_id,x_sFormat,x_bVas_show);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderReportStyle x_oMobileOrderReportStyle)
        {
            return MobileOrderReportStyleRepository.InsertWithOutLastID(x_oDB,x_oMobileOrderReportStyle);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sCid,global::System.Nullable<bool> x_bActive,string x_sStatus,string x_sType,global::System.Nullable<int> x_iReport_id,string x_sFormat,global::System.Nullable<bool> x_bVas_show)
        {
            return MobileOrderReportStyleRepository.InsertReturnLastID_SP(x_oDB,x_dCdate,x_sCid,x_bActive,x_sStatus,x_sType,x_iReport_id,x_sFormat,x_bVas_show);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderReportStyle x_oMobileOrderReportStyle)
        {
            return MobileOrderReportStyleRepository.InsertReturnLastID_SP(x_oDB,x_oMobileOrderReportStyle);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return MobileOrderReportStyleRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderReportStyleRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return MobileOrderReportStyleRepository.Delete(x_oDB, x_iId);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(MobileOrderReportStyle x_oMobileOrderReportStyleRow){
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


