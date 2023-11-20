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
///-- Description:	<Description,Table :[MobileOrderReportType],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderReportType] Business layer
    /// </summary>
    
    public abstract class MobileOrderReportTypeBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public MobileOrderReportTypeBalBase(){
        }
        ~MobileOrderReportTypeBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderReportType x_oMobileOrderReportType)
        {
            return GetDataSet(x_oMobileOrderReportType,null,MobileOrderReportTypeInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderReportType x_oMobileOrderReportType,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oMobileOrderReportType,x_oMergeDSet,MobileOrderReportTypeInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderReportType x_oMobileOrderReportType,MobileOrderReportTypeInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderReportType,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderReportType x_oMobileOrderReportType,global::System.Data.DataSet x_oMergeDSet,MobileOrderReportTypeInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderReportType,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(MobileOrderReportType x_oMobileOrderReportType,global::System.Data.DataSet x_oMergeDSet,MobileOrderReportTypeInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderReportTypeInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(MobileOrderReportType.Para.TableName());
            if (x_oTableSet.Fields(MobileOrderReportType.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportType.Para.TableName()].Columns.Add(MobileOrderReportType.Para.active); }
            if (x_oTableSet.Fields(MobileOrderReportType.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportType.Para.TableName()].Columns.Add(MobileOrderReportType.Para.cdate); }
            if (x_oTableSet.Fields(MobileOrderReportType.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportType.Para.TableName()].Columns.Add(MobileOrderReportType.Para.cid); }
            if (x_oTableSet.Fields(MobileOrderReportType.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportType.Para.TableName()].Columns.Add(MobileOrderReportType.Para.did); }
            if (x_oTableSet.Fields(MobileOrderReportType.Para.report_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportType.Para.TableName()].Columns.Add(MobileOrderReportType.Para.report_name); }
            if (x_oTableSet.Fields(MobileOrderReportType.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportType.Para.TableName()].Columns.Add(MobileOrderReportType.Para.id); }
            if (x_oTableSet.Fields(MobileOrderReportType.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportType.Para.TableName()].Columns.Add(MobileOrderReportType.Para.ddate); }
            if (x_oTableSet.Fields(MobileOrderReportType.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportType.Para.TableName()].Columns.Add(MobileOrderReportType.Para.mid); }
            if (x_oTableSet.Fields(MobileOrderReportType.Para.report_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderReportType.Para.TableName()].Columns.Add(MobileOrderReportType.Para.report_type); }
            if (x_oMobileOrderReportType != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[MobileOrderReportType.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(MobileOrderReportType.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportType.Para.active] = x_oMobileOrderReportType.GetActive(); }
                if (x_oTableSet.Fields(MobileOrderReportType.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportType.Para.cdate] = x_oMobileOrderReportType.GetCdate(); }
                if (x_oTableSet.Fields(MobileOrderReportType.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportType.Para.cid] = x_oMobileOrderReportType.GetCid(); }
                if (x_oTableSet.Fields(MobileOrderReportType.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportType.Para.did] = x_oMobileOrderReportType.GetDid(); }
                if (x_oTableSet.Fields(MobileOrderReportType.Para.report_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportType.Para.report_name] = x_oMobileOrderReportType.GetReport_name(); }
                if (x_oTableSet.Fields(MobileOrderReportType.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportType.Para.id] = x_oMobileOrderReportType.GetId(); }
                if (x_oTableSet.Fields(MobileOrderReportType.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportType.Para.ddate] = x_oMobileOrderReportType.GetDdate(); }
                if (x_oTableSet.Fields(MobileOrderReportType.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportType.Para.mid] = x_oMobileOrderReportType.GetMid(); }
                if (x_oTableSet.Fields(MobileOrderReportType.Para.report_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderReportType.Para.report_type] = x_oMobileOrderReportType.GetReport_type(); }
                _oDSet.Tables[MobileOrderReportType.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(MobileOrderReportTypeInfo x_oTableSet)
        {
            return MobileOrderReportTypeBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return MobileOrderReportTypeBal.ToEmptyDataSetProcess(MobileOrderReportTypeInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(MobileOrderReportTypeInfo x_oTableSet)
        {
            return MobileOrderReportTypeBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(MobileOrderReportType x_oMobileOrderReportType, MobileOrderReportTypeInfo x_oTableSet)
        {
            return MobileOrderReportTypeBal.GetDataSet(null, null, x_oTableSet).Tables[MobileOrderReportType.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(MobileOrderReportType x_oMobileOrderReportType)
        {
            return MobileOrderReportTypeBal.GetDataSet(x_oMobileOrderReportType, null, MobileOrderReportTypeInfoDLL.CreateInfoInstanceObject()).Tables[MobileOrderReportType.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<Guid> x_gId)
        {
            return Row(x_oTable, x_oDB,x_gId,MobileOrderReportTypeInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<Guid> x_gId, MobileOrderReportTypeInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_gId, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<Guid> x_gId,MobileOrderReportTypeInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderReportTypeInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [MobileOrderReportType].[active] AS MOBILEORDERREPORTTYPE_ACTIVE,[MobileOrderReportType].[cdate] AS MOBILEORDERREPORTTYPE_CDATE,[MobileOrderReportType].[cid] AS MOBILEORDERREPORTTYPE_CID,[MobileOrderReportType].[did] AS MOBILEORDERREPORTTYPE_DID,[MobileOrderReportType].[report_name] AS MOBILEORDERREPORTTYPE_REPORT_NAME,[MobileOrderReportType].[id] AS MOBILEORDERREPORTTYPE_ID,[MobileOrderReportType].[ddate] AS MOBILEORDERREPORTTYPE_DDATE,[MobileOrderReportType].[mid] AS MOBILEORDERREPORTTYPE_MID,[MobileOrderReportType].[report_type] AS MOBILEORDERREPORTTYPE_REPORT_TYPE  FROM  [MobileOrderReportType]  WHERE  [MobileOrderReportType].[id] = \'"+x_gId.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportType]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportType]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(MobileOrderReportType.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportType.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportType.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTTYPE_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportType.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportType.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportType.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportType.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTTYPE_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportType.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportType.Para.cid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportType.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportType.Para.cid).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTTYPE_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportType.Para.cid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportType.Para.did).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportType.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportType.Para.did).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTTYPE_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportType.Para.did).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportType.Para.report_name).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_REPORT_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportType.Para.report_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportType.Para.report_name).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTTYPE_REPORT_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportType.Para.report_name).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportType.Para.id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportType.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportType.Para.id).AliasName].ToString()] = (global::System.Nullable<Guid>)_oData["MOBILEORDERREPORTTYPE_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportType.Para.id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportType.Para.ddate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportType.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportType.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTTYPE_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportType.Para.ddate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportType.Para.mid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_MID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportType.Para.mid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportType.Para.mid).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTTYPE_MID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportType.Para.mid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderReportType.Para.report_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTTYPE_REPORT_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderReportType.Para.report_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportType.Para.report_type).AliasName].ToString()] = (string)_oData["MOBILEORDERREPORTTYPE_REPORT_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderReportType.Para.report_type).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,MobileOrderReportType x_oMobileOrderReportTypeRow)
        {
            return SetByDataSetRowProc(x_iROW, MobileOrderReportType.Para.TableName(), x_oDataSet,x_oMobileOrderReportTypeRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderReportType x_oMobileOrderReportTypeRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oMobileOrderReportTypeRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderReportType x_oMobileOrderReportTypeRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                MobileOrderReportTypeInfo _oTableSet=MobileOrderReportTypeInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportType.Para.active).AliasName))
                    x_oMobileOrderReportTypeRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportType.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportType.Para.cdate).AliasName))
                    x_oMobileOrderReportTypeRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportType.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportType.Para.cid).AliasName))
                    x_oMobileOrderReportTypeRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportType.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportType.Para.did).AliasName))
                    x_oMobileOrderReportTypeRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportType.Para.did).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportType.Para.report_name).AliasName))
                    x_oMobileOrderReportTypeRow.report_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportType.Para.report_name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportType.Para.id).AliasName))
                    x_oMobileOrderReportTypeRow.id = (global::System.Nullable<Guid>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportType.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportType.Para.ddate).AliasName))
                    x_oMobileOrderReportTypeRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportType.Para.ddate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportType.Para.mid).AliasName))
                    x_oMobileOrderReportTypeRow.mid = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportType.Para.mid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderReportType.Para.report_type).AliasName))
                    x_oMobileOrderReportTypeRow.report_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderReportType.Para.report_type).AliasName];
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
            return MobileOrderReportTypeRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static MobileOrderReportTypeEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return MobileOrderReportTypeRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static MobileOrderReportTypeEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return MobileOrderReportTypeRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderReportTypeRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderReportTypeRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderReportTypeRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sReport_name,global::System.Nullable<Guid> x_gId,global::System.Nullable<DateTime> x_dDdate,string x_sReport_type)
        {
            return MobileOrderReportTypeRepository.Insert(x_oDB, x_bActive,x_dCdate,x_sCid,x_sDid,x_sReport_name,x_gId,x_dDdate,x_sReport_type);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderReportType x_oMobileOrderReportType)
        {
            return MobileOrderReportTypeRepository.InsertWithOutLastID(x_oDB,x_oMobileOrderReportType);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sReport_name,global::System.Nullable<Guid> x_gId,global::System.Nullable<DateTime> x_dDdate,string x_sReport_type)
        {
            return MobileOrderReportTypeRepository.InsertReturnLastID_SP(x_oDB,x_bActive,x_dCdate,x_sCid,x_sDid,x_sReport_name,x_gId,x_dDdate,x_sReport_type);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderReportType x_oMobileOrderReportType)
        {
            return MobileOrderReportTypeRepository.InsertReturnLastID_SP(x_oDB,x_oMobileOrderReportType);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return MobileOrderReportTypeRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderReportTypeRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            return MobileOrderReportTypeRepository.Delete(x_oDB, x_iMid);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(MobileOrderReportType x_oMobileOrderReportTypeRow){
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


