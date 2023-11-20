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
///-- Create date: <Create Date 2011-09-15>
///-- Description:	<Description,Table :[CallListUploadProfile],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [CallListUploadProfile] Business layer
    /// </summary>
    
    public abstract class CallListUploadProfileBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public CallListUploadProfileBalBase(){
        }
        ~CallListUploadProfileBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(CallListUploadProfile x_oCallListUploadProfile)
        {
            return GetDataSet(x_oCallListUploadProfile,null,CallListUploadProfileInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(CallListUploadProfile x_oCallListUploadProfile,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oCallListUploadProfile,x_oMergeDSet,CallListUploadProfileInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(CallListUploadProfile x_oCallListUploadProfile,CallListUploadProfileInfo x_oTableSet)
        {
            return GetDataSet(x_oCallListUploadProfile,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(CallListUploadProfile x_oCallListUploadProfile,global::System.Data.DataSet x_oMergeDSet,CallListUploadProfileInfo x_oTableSet)
        {
            return GetDataSet(x_oCallListUploadProfile,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(CallListUploadProfile x_oCallListUploadProfile,global::System.Data.DataSet x_oMergeDSet,CallListUploadProfileInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = CallListUploadProfileInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(CallListUploadProfile.Para.TableName());
            if (x_oTableSet.Fields(CallListUploadProfile.Para.sdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[CallListUploadProfile.Para.TableName()].Columns.Add(CallListUploadProfile.Para.sdate); }
            if (x_oTableSet.Fields(CallListUploadProfile.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[CallListUploadProfile.Para.TableName()].Columns.Add(CallListUploadProfile.Para.id); }
            if (x_oTableSet.Fields(CallListUploadProfile.Para.call_list_program_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[CallListUploadProfile.Para.TableName()].Columns.Add(CallListUploadProfile.Para.call_list_program_id); }
            if (x_oTableSet.Fields(CallListUploadProfile.Para.issue_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[CallListUploadProfile.Para.TableName()].Columns.Add(CallListUploadProfile.Para.issue_type); }
            if (x_oTableSet.Fields(CallListUploadProfile.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[CallListUploadProfile.Para.TableName()].Columns.Add(CallListUploadProfile.Para.active); }
            if (x_oTableSet.Fields(CallListUploadProfile.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[CallListUploadProfile.Para.TableName()].Columns.Add(CallListUploadProfile.Para.edate); }
            if (x_oCallListUploadProfile != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[CallListUploadProfile.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(CallListUploadProfile.Para.sdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[CallListUploadProfile.Para.sdate] = x_oCallListUploadProfile.GetSdate(); }
                if (x_oTableSet.Fields(CallListUploadProfile.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[CallListUploadProfile.Para.id] = x_oCallListUploadProfile.GetId(); }
                if (x_oTableSet.Fields(CallListUploadProfile.Para.call_list_program_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[CallListUploadProfile.Para.call_list_program_id] = x_oCallListUploadProfile.GetCall_list_program_id(); }
                if (x_oTableSet.Fields(CallListUploadProfile.Para.issue_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[CallListUploadProfile.Para.issue_type] = x_oCallListUploadProfile.GetIssue_type(); }
                if (x_oTableSet.Fields(CallListUploadProfile.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[CallListUploadProfile.Para.active] = x_oCallListUploadProfile.GetActive(); }
                if (x_oTableSet.Fields(CallListUploadProfile.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDRow[CallListUploadProfile.Para.edate] = x_oCallListUploadProfile.GetEdate(); }
                _oDSet.Tables[CallListUploadProfile.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(CallListUploadProfileInfo x_oTableSet)
        {
            return CallListUploadProfileBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return CallListUploadProfileBal.ToEmptyDataSetProcess(CallListUploadProfileInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(CallListUploadProfileInfo x_oTableSet)
        {
            return CallListUploadProfileBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(CallListUploadProfile x_oCallListUploadProfile, CallListUploadProfileInfo x_oTableSet)
        {
            return CallListUploadProfileBal.GetDataSet(null, null, x_oTableSet).Tables[CallListUploadProfile.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(CallListUploadProfile x_oCallListUploadProfile)
        {
            return CallListUploadProfileBal.GetDataSet(x_oCallListUploadProfile, null, CallListUploadProfileInfoDLL.CreateInfoInstanceObject()).Tables[CallListUploadProfile.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<long> x_lId)
        {
            return Row(x_oTable, x_oDB,x_lId,CallListUploadProfileInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<long> x_lId, CallListUploadProfileInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_lId, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<long> x_lId,CallListUploadProfileInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = CallListUploadProfileInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [CallListUploadProfile].[sdate] AS CALLLISTUPLOADPROFILE_SDATE,[CallListUploadProfile].[active] AS CALLLISTUPLOADPROFILE_ACTIVE,[CallListUploadProfile].[issue_type] AS CALLLISTUPLOADPROFILE_ISSUE_TYPE,[CallListUploadProfile].[call_list_program_id] AS CALLLISTUPLOADPROFILE_CALL_LIST_PROGRAM_ID,[CallListUploadProfile].[id] AS CALLLISTUPLOADPROFILE_ID,[CallListUploadProfile].[edate] AS CALLLISTUPLOADPROFILE_EDATE  FROM  [CallListUploadProfile]  WHERE  [CallListUploadProfile].[id] = \'"+x_lId.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[CallListUploadProfile]","["+ Configurator.MSSQLTablePrefix + "CallListUploadProfile]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(CallListUploadProfile.Para.sdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADPROFILE_SDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(CallListUploadProfile.Para.sdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CallListUploadProfile.Para.sdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["CALLLISTUPLOADPROFILE_SDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CallListUploadProfile.Para.sdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(CallListUploadProfile.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADPROFILE_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(CallListUploadProfile.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CallListUploadProfile.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["CALLLISTUPLOADPROFILE_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CallListUploadProfile.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(CallListUploadProfile.Para.issue_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADPROFILE_ISSUE_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(CallListUploadProfile.Para.issue_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CallListUploadProfile.Para.issue_type).AliasName].ToString()] = (string)_oData["CALLLISTUPLOADPROFILE_ISSUE_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CallListUploadProfile.Para.issue_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(CallListUploadProfile.Para.call_list_program_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADPROFILE_CALL_LIST_PROGRAM_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(CallListUploadProfile.Para.call_list_program_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CallListUploadProfile.Para.call_list_program_id).AliasName].ToString()] = (global::System.Nullable<long>)_oData["CALLLISTUPLOADPROFILE_CALL_LIST_PROGRAM_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CallListUploadProfile.Para.call_list_program_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(CallListUploadProfile.Para.id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADPROFILE_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(CallListUploadProfile.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CallListUploadProfile.Para.id).AliasName].ToString()] = (global::System.Nullable<long>)_oData["CALLLISTUPLOADPROFILE_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CallListUploadProfile.Para.id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(CallListUploadProfile.Para.edate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADPROFILE_EDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(CallListUploadProfile.Para.edate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CallListUploadProfile.Para.edate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["CALLLISTUPLOADPROFILE_EDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CallListUploadProfile.Para.edate).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,CallListUploadProfile x_oCallListUploadProfileRow)
        {
            return SetByDataSetRowProc(x_iROW, CallListUploadProfile.Para.TableName(), x_oDataSet,x_oCallListUploadProfileRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,CallListUploadProfile x_oCallListUploadProfileRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oCallListUploadProfileRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,CallListUploadProfile x_oCallListUploadProfileRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                CallListUploadProfileInfo _oTableSet=CallListUploadProfileInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(CallListUploadProfile.Para.sdate).AliasName))
                    x_oCallListUploadProfileRow.sdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(CallListUploadProfile.Para.sdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(CallListUploadProfile.Para.id).AliasName))
                    x_oCallListUploadProfileRow.id = (global::System.Nullable<long>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(CallListUploadProfile.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(CallListUploadProfile.Para.call_list_program_id).AliasName))
                    x_oCallListUploadProfileRow.call_list_program_id = (global::System.Nullable<long>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(CallListUploadProfile.Para.call_list_program_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(CallListUploadProfile.Para.issue_type).AliasName))
                    x_oCallListUploadProfileRow.issue_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(CallListUploadProfile.Para.issue_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(CallListUploadProfile.Para.active).AliasName))
                    x_oCallListUploadProfileRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(CallListUploadProfile.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(CallListUploadProfile.Para.edate).AliasName))
                    x_oCallListUploadProfileRow.edate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(CallListUploadProfile.Para.edate).AliasName];
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
            return CallListUploadProfileRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static CallListUploadProfileEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return CallListUploadProfileRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static CallListUploadProfileEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return CallListUploadProfileRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return CallListUploadProfileRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return CallListUploadProfileRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return CallListUploadProfileRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dSdate,global::System.Nullable<long> x_lCall_list_program_id,string x_sIssue_type,global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dEdate)
        {
            return CallListUploadProfileRepository.Insert(x_oDB, x_dSdate,x_lCall_list_program_id,x_sIssue_type,x_bActive,x_dEdate);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,CallListUploadProfile x_oCallListUploadProfile)
        {
            return CallListUploadProfileRepository.InsertWithOutLastID(x_oDB,x_oCallListUploadProfile);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dSdate,global::System.Nullable<long> x_lCall_list_program_id,string x_sIssue_type,global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dEdate)
        {
            return CallListUploadProfileRepository.InsertReturnLastID_SP(x_oDB,x_dSdate,x_lCall_list_program_id,x_sIssue_type,x_bActive,x_dEdate);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, CallListUploadProfile x_oCallListUploadProfile)
        {
            return CallListUploadProfileRepository.InsertReturnLastID_SP(x_oDB,x_oCallListUploadProfile);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return CallListUploadProfileRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return CallListUploadProfileRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<long> x_lId)
        {
            return CallListUploadProfileRepository.Delete(x_oDB, x_lId);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(CallListUploadProfile x_oCallListUploadProfileRow){
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


