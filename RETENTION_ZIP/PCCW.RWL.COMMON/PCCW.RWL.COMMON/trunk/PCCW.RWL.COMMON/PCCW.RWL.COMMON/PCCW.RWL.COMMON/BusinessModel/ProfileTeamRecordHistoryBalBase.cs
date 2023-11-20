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
///-- Create date: <Create Date 2011-01-14>
///-- Description:	<Description,Table :[ProfileTeamRecordHistory],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [ProfileTeamRecordHistory] Business layer
    /// </summary>
    
    public abstract class ProfileTeamRecordHistoryBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public ProfileTeamRecordHistoryBalBase(){
        }
        ~ProfileTeamRecordHistoryBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(ProfileTeamRecordHistory x_oProfileTeamRecordHistory)
        {
            return GetDataSet(x_oProfileTeamRecordHistory,null,ProfileTeamRecordHistoryInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(ProfileTeamRecordHistory x_oProfileTeamRecordHistory,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oProfileTeamRecordHistory,x_oMergeDSet,ProfileTeamRecordHistoryInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(ProfileTeamRecordHistory x_oProfileTeamRecordHistory,ProfileTeamRecordHistoryInfo x_oTableSet)
        {
            return GetDataSet(x_oProfileTeamRecordHistory,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(ProfileTeamRecordHistory x_oProfileTeamRecordHistory,global::System.Data.DataSet x_oMergeDSet,ProfileTeamRecordHistoryInfo x_oTableSet)
        {
            return GetDataSet(x_oProfileTeamRecordHistory,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(ProfileTeamRecordHistory x_oProfileTeamRecordHistory,global::System.Data.DataSet x_oMergeDSet,ProfileTeamRecordHistoryInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = ProfileTeamRecordHistoryInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(ProfileTeamRecordHistory.Para.TableName());
            if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProfileTeamRecordHistory.Para.TableName()].Columns.Add(ProfileTeamRecordHistory.Para.active); }
            if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProfileTeamRecordHistory.Para.TableName()].Columns.Add(ProfileTeamRecordHistory.Para.cdate); }
            if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProfileTeamRecordHistory.Para.TableName()].Columns.Add(ProfileTeamRecordHistory.Para.cid); }
            if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProfileTeamRecordHistory.Para.TableName()].Columns.Add(ProfileTeamRecordHistory.Para.did); }
            if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.action_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProfileTeamRecordHistory.Para.TableName()].Columns.Add(ProfileTeamRecordHistory.Para.action_type); }
            if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProfileTeamRecordHistory.Para.TableName()].Columns.Add(ProfileTeamRecordHistory.Para.edate); }
            if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.rec_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProfileTeamRecordHistory.Para.TableName()].Columns.Add(ProfileTeamRecordHistory.Para.rec_no); }
            if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.salesman_code).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProfileTeamRecordHistory.Para.TableName()].Columns.Add(ProfileTeamRecordHistory.Para.salesman_code); }
            if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.his_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProfileTeamRecordHistory.Para.TableName()].Columns.Add(ProfileTeamRecordHistory.Para.his_id); }
            if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.staff_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProfileTeamRecordHistory.Para.TableName()].Columns.Add(ProfileTeamRecordHistory.Para.staff_no); }
            if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProfileTeamRecordHistory.Para.TableName()].Columns.Add(ProfileTeamRecordHistory.Para.ddate); }
            if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.sdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProfileTeamRecordHistory.Para.TableName()].Columns.Add(ProfileTeamRecordHistory.Para.sdate); }
            if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.remark).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProfileTeamRecordHistory.Para.TableName()].Columns.Add(ProfileTeamRecordHistory.Para.remark); }
            if (x_oProfileTeamRecordHistory != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[ProfileTeamRecordHistory.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProfileTeamRecordHistory.Para.active] = x_oProfileTeamRecordHistory.GetActive(); }
                if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProfileTeamRecordHistory.Para.cdate] = x_oProfileTeamRecordHistory.GetCdate(); }
                if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProfileTeamRecordHistory.Para.cid] = x_oProfileTeamRecordHistory.GetCid(); }
                if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProfileTeamRecordHistory.Para.did] = x_oProfileTeamRecordHistory.GetDid(); }
                if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.action_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProfileTeamRecordHistory.Para.action_type] = x_oProfileTeamRecordHistory.GetAction_type(); }
                if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProfileTeamRecordHistory.Para.edate] = x_oProfileTeamRecordHistory.GetEdate(); }
                if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.rec_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProfileTeamRecordHistory.Para.rec_no] = x_oProfileTeamRecordHistory.GetRec_no(); }
                if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.salesman_code).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProfileTeamRecordHistory.Para.salesman_code] = x_oProfileTeamRecordHistory.GetSalesman_code(); }
                if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.his_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProfileTeamRecordHistory.Para.his_id] = x_oProfileTeamRecordHistory.GetHis_id(); }
                if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.staff_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProfileTeamRecordHistory.Para.staff_no] = x_oProfileTeamRecordHistory.GetStaff_no(); }
                if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProfileTeamRecordHistory.Para.ddate] = x_oProfileTeamRecordHistory.GetDdate(); }
                if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.sdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProfileTeamRecordHistory.Para.sdate] = x_oProfileTeamRecordHistory.GetSdate(); }
                if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.remark).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProfileTeamRecordHistory.Para.remark] = x_oProfileTeamRecordHistory.GetRemark(); }
                _oDSet.Tables[ProfileTeamRecordHistory.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(ProfileTeamRecordHistoryInfo x_oTableSet)
        {
            return ProfileTeamRecordHistoryBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return ProfileTeamRecordHistoryBal.ToEmptyDataSetProcess(ProfileTeamRecordHistoryInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(ProfileTeamRecordHistoryInfo x_oTableSet)
        {
            return ProfileTeamRecordHistoryBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(ProfileTeamRecordHistory x_oProfileTeamRecordHistory, ProfileTeamRecordHistoryInfo x_oTableSet)
        {
            return ProfileTeamRecordHistoryBal.GetDataSet(null, null, x_oTableSet).Tables[ProfileTeamRecordHistory.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(ProfileTeamRecordHistory x_oProfileTeamRecordHistory)
        {
            return ProfileTeamRecordHistoryBal.GetDataSet(x_oProfileTeamRecordHistory, null, ProfileTeamRecordHistoryInfoDLL.CreateInfoInstanceObject()).Tables[ProfileTeamRecordHistory.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<long> x_lHis_id)
        {
            return Row(x_oTable, x_oDB,x_lHis_id,ProfileTeamRecordHistoryInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<long> x_lHis_id, ProfileTeamRecordHistoryInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_lHis_id, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<long> x_lHis_id,ProfileTeamRecordHistoryInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = ProfileTeamRecordHistoryInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [ProfileTeamRecordHistory].[active] AS PROFILETEAMRECORDHISTORY_ACTIVE,[ProfileTeamRecordHistory].[cdate] AS PROFILETEAMRECORDHISTORY_CDATE,[ProfileTeamRecordHistory].[cid] AS PROFILETEAMRECORDHISTORY_CID,[ProfileTeamRecordHistory].[did] AS PROFILETEAMRECORDHISTORY_DID,[ProfileTeamRecordHistory].[sdate] AS PROFILETEAMRECORDHISTORY_SDATE,[ProfileTeamRecordHistory].[action_type] AS PROFILETEAMRECORDHISTORY_ACTION_TYPE,[ProfileTeamRecordHistory].[edate] AS PROFILETEAMRECORDHISTORY_EDATE,[ProfileTeamRecordHistory].[salesman_code] AS PROFILETEAMRECORDHISTORY_SALESMAN_CODE,[ProfileTeamRecordHistory].[his_id] AS PROFILETEAMRECORDHISTORY_HIS_ID,[ProfileTeamRecordHistory].[staff_no] AS PROFILETEAMRECORDHISTORY_STAFF_NO,[ProfileTeamRecordHistory].[ddate] AS PROFILETEAMRECORDHISTORY_DDATE,[ProfileTeamRecordHistory].[rec_no] AS PROFILETEAMRECORDHISTORY_REC_NO,[ProfileTeamRecordHistory].[remark] AS PROFILETEAMRECORDHISTORY_REMARK  FROM  [ProfileTeamRecordHistory]  WHERE  [ProfileTeamRecordHistory].[his_id] = \'"+x_lHis_id.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProfileTeamRecordHistory]","["+ Configurator.MSSQLTablePrefix + "ProfileTeamRecordHistory]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProfileTeamRecordHistory.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecordHistory.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["PROFILETEAMRECORDHISTORY_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecordHistory.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProfileTeamRecordHistory.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecordHistory.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["PROFILETEAMRECORDHISTORY_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecordHistory.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.cid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProfileTeamRecordHistory.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecordHistory.Para.cid).AliasName].ToString()] = (string)_oData["PROFILETEAMRECORDHISTORY_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecordHistory.Para.cid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.did).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProfileTeamRecordHistory.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecordHistory.Para.did).AliasName].ToString()] = (string)_oData["PROFILETEAMRECORDHISTORY_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecordHistory.Para.did).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.sdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_SDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProfileTeamRecordHistory.Para.sdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecordHistory.Para.sdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["PROFILETEAMRECORDHISTORY_SDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecordHistory.Para.sdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.action_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_ACTION_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProfileTeamRecordHistory.Para.action_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecordHistory.Para.action_type).AliasName].ToString()] = (string)_oData["PROFILETEAMRECORDHISTORY_ACTION_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecordHistory.Para.action_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.edate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_EDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProfileTeamRecordHistory.Para.edate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecordHistory.Para.edate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["PROFILETEAMRECORDHISTORY_EDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecordHistory.Para.edate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.salesman_code).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_SALESMAN_CODE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProfileTeamRecordHistory.Para.salesman_code).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecordHistory.Para.salesman_code).AliasName].ToString()] = (string)_oData["PROFILETEAMRECORDHISTORY_SALESMAN_CODE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecordHistory.Para.salesman_code).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.his_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_HIS_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProfileTeamRecordHistory.Para.his_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecordHistory.Para.his_id).AliasName].ToString()] = (global::System.Nullable<long>)_oData["PROFILETEAMRECORDHISTORY_HIS_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecordHistory.Para.his_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.staff_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_STAFF_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProfileTeamRecordHistory.Para.staff_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecordHistory.Para.staff_no).AliasName].ToString()] = (string)_oData["PROFILETEAMRECORDHISTORY_STAFF_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecordHistory.Para.staff_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.ddate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProfileTeamRecordHistory.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecordHistory.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["PROFILETEAMRECORDHISTORY_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecordHistory.Para.ddate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.rec_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_REC_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProfileTeamRecordHistory.Para.rec_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecordHistory.Para.rec_no).AliasName].ToString()] = (global::System.Nullable<int>)_oData["PROFILETEAMRECORDHISTORY_REC_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecordHistory.Para.rec_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(ProfileTeamRecordHistory.Para.remark).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORDHISTORY_REMARK"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProfileTeamRecordHistory.Para.remark).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecordHistory.Para.remark).AliasName].ToString()] = (string)_oData["PROFILETEAMRECORDHISTORY_REMARK"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecordHistory.Para.remark).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,ProfileTeamRecordHistory x_oProfileTeamRecordHistoryRow)
        {
            return SetByDataSetRowProc(x_iROW, ProfileTeamRecordHistory.Para.TableName(), x_oDataSet,x_oProfileTeamRecordHistoryRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,ProfileTeamRecordHistory x_oProfileTeamRecordHistoryRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oProfileTeamRecordHistoryRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,ProfileTeamRecordHistory x_oProfileTeamRecordHistoryRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                ProfileTeamRecordHistoryInfo _oTableSet=ProfileTeamRecordHistoryInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProfileTeamRecordHistory.Para.active).AliasName))
                    x_oProfileTeamRecordHistoryRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProfileTeamRecordHistory.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProfileTeamRecordHistory.Para.cdate).AliasName))
                    x_oProfileTeamRecordHistoryRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProfileTeamRecordHistory.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProfileTeamRecordHistory.Para.cid).AliasName))
                    x_oProfileTeamRecordHistoryRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProfileTeamRecordHistory.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProfileTeamRecordHistory.Para.did).AliasName))
                    x_oProfileTeamRecordHistoryRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProfileTeamRecordHistory.Para.did).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProfileTeamRecordHistory.Para.action_type).AliasName))
                    x_oProfileTeamRecordHistoryRow.action_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProfileTeamRecordHistory.Para.action_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProfileTeamRecordHistory.Para.edate).AliasName))
                    x_oProfileTeamRecordHistoryRow.edate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProfileTeamRecordHistory.Para.edate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProfileTeamRecordHistory.Para.rec_no).AliasName))
                    x_oProfileTeamRecordHistoryRow.rec_no = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProfileTeamRecordHistory.Para.rec_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProfileTeamRecordHistory.Para.salesman_code).AliasName))
                    x_oProfileTeamRecordHistoryRow.salesman_code = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProfileTeamRecordHistory.Para.salesman_code).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProfileTeamRecordHistory.Para.his_id).AliasName))
                    x_oProfileTeamRecordHistoryRow.his_id = (global::System.Nullable<long>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProfileTeamRecordHistory.Para.his_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProfileTeamRecordHistory.Para.staff_no).AliasName))
                    x_oProfileTeamRecordHistoryRow.staff_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProfileTeamRecordHistory.Para.staff_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProfileTeamRecordHistory.Para.ddate).AliasName))
                    x_oProfileTeamRecordHistoryRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProfileTeamRecordHistory.Para.ddate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProfileTeamRecordHistory.Para.sdate).AliasName))
                    x_oProfileTeamRecordHistoryRow.sdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProfileTeamRecordHistory.Para.sdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProfileTeamRecordHistory.Para.remark).AliasName))
                    x_oProfileTeamRecordHistoryRow.remark = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProfileTeamRecordHistory.Para.remark).AliasName];
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
            return ProfileTeamRecordHistoryRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static ProfileTeamRecordHistoryEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return ProfileTeamRecordHistoryRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static ProfileTeamRecordHistoryEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return ProfileTeamRecordHistoryRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return ProfileTeamRecordHistoryRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return ProfileTeamRecordHistoryRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return ProfileTeamRecordHistoryRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sAction_type,global::System.Nullable<DateTime> x_dEdate,global::System.Nullable<int> x_iRec_no,string x_sSalesman_code,string x_sStaff_no,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<DateTime> x_dSdate,string x_sRemark)
        {
            return ProfileTeamRecordHistoryRepository.Insert(x_oDB, x_bActive,x_dCdate,x_sCid,x_sDid,x_sAction_type,x_dEdate,x_iRec_no,x_sSalesman_code,x_sStaff_no,x_dDdate,x_dSdate,x_sRemark);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,ProfileTeamRecordHistory x_oProfileTeamRecordHistory)
        {
            return ProfileTeamRecordHistoryRepository.InsertWithOutLastID(x_oDB,x_oProfileTeamRecordHistory);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sAction_type,global::System.Nullable<DateTime> x_dEdate,global::System.Nullable<int> x_iRec_no,string x_sSalesman_code,string x_sStaff_no,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<DateTime> x_dSdate,string x_sRemark)
        {
            return ProfileTeamRecordHistoryRepository.InsertReturnLastID_SP(x_oDB,x_bActive,x_dCdate,x_sCid,x_sDid,x_sAction_type,x_dEdate,x_iRec_no,x_sSalesman_code,x_sStaff_no,x_dDdate,x_dSdate,x_sRemark);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, ProfileTeamRecordHistory x_oProfileTeamRecordHistory)
        {
            return ProfileTeamRecordHistoryRepository.InsertReturnLastID_SP(x_oDB,x_oProfileTeamRecordHistory);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return ProfileTeamRecordHistoryRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return ProfileTeamRecordHistoryRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<long> x_lHis_id)
        {
            return ProfileTeamRecordHistoryRepository.Delete(x_oDB, x_lHis_id);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(ProfileTeamRecordHistory x_oProfileTeamRecordHistoryRow){
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


