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
///-- Create date: <Create Date 2010-12-17>
///-- Description:	<Description,Table :[MobileOrderIssueRestrictionProfile],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderIssueRestrictionProfile] Business layer
    /// </summary>
    
    public abstract class MobileOrderIssueRestrictionProfileBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public MobileOrderIssueRestrictionProfileBalBase(){
        }
        ~MobileOrderIssueRestrictionProfileBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderIssueRestrictionProfile x_oMobileOrderIssueRestrictionProfile)
        {
            return GetDataSet(x_oMobileOrderIssueRestrictionProfile,null,MobileOrderIssueRestrictionProfileInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderIssueRestrictionProfile x_oMobileOrderIssueRestrictionProfile,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oMobileOrderIssueRestrictionProfile,x_oMergeDSet,MobileOrderIssueRestrictionProfileInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderIssueRestrictionProfile x_oMobileOrderIssueRestrictionProfile,MobileOrderIssueRestrictionProfileInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderIssueRestrictionProfile,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderIssueRestrictionProfile x_oMobileOrderIssueRestrictionProfile,global::System.Data.DataSet x_oMergeDSet,MobileOrderIssueRestrictionProfileInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderIssueRestrictionProfile,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(MobileOrderIssueRestrictionProfile x_oMobileOrderIssueRestrictionProfile,global::System.Data.DataSet x_oMergeDSet,MobileOrderIssueRestrictionProfileInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderIssueRestrictionProfileInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(MobileOrderIssueRestrictionProfile.Para.TableName());
            if (x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderIssueRestrictionProfile.Para.TableName()].Columns.Add(MobileOrderIssueRestrictionProfile.Para.mid); }
            if (x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderIssueRestrictionProfile.Para.TableName()].Columns.Add(MobileOrderIssueRestrictionProfile.Para.cdate); }
            if (x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.mrt_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderIssueRestrictionProfile.Para.TableName()].Columns.Add(MobileOrderIssueRestrictionProfile.Para.mrt_no); }
            if (x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderIssueRestrictionProfile.Para.TableName()].Columns.Add(MobileOrderIssueRestrictionProfile.Para.cid); }
            if (x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderIssueRestrictionProfile.Para.TableName()].Columns.Add(MobileOrderIssueRestrictionProfile.Para.active); }
            if (x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.restriction_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderIssueRestrictionProfile.Para.TableName()].Columns.Add(MobileOrderIssueRestrictionProfile.Para.restriction_id); }
            if (x_oMobileOrderIssueRestrictionProfile != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[MobileOrderIssueRestrictionProfile.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderIssueRestrictionProfile.Para.mid] = x_oMobileOrderIssueRestrictionProfile.GetMid(); }
                if (x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderIssueRestrictionProfile.Para.cdate] = x_oMobileOrderIssueRestrictionProfile.GetCdate(); }
                if (x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.mrt_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderIssueRestrictionProfile.Para.mrt_no] = x_oMobileOrderIssueRestrictionProfile.GetMrt_no(); }
                if (x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderIssueRestrictionProfile.Para.cid] = x_oMobileOrderIssueRestrictionProfile.GetCid(); }
                if (x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderIssueRestrictionProfile.Para.active] = x_oMobileOrderIssueRestrictionProfile.GetActive(); }
                if (x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.restriction_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderIssueRestrictionProfile.Para.restriction_id] = x_oMobileOrderIssueRestrictionProfile.GetRestriction_id(); }
                _oDSet.Tables[MobileOrderIssueRestrictionProfile.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(MobileOrderIssueRestrictionProfileInfo x_oTableSet)
        {
            return MobileOrderIssueRestrictionProfileBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return MobileOrderIssueRestrictionProfileBal.ToEmptyDataSetProcess(MobileOrderIssueRestrictionProfileInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(MobileOrderIssueRestrictionProfileInfo x_oTableSet)
        {
            return MobileOrderIssueRestrictionProfileBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(MobileOrderIssueRestrictionProfile x_oMobileOrderIssueRestrictionProfile, MobileOrderIssueRestrictionProfileInfo x_oTableSet)
        {
            return MobileOrderIssueRestrictionProfileBal.GetDataSet(null, null, x_oTableSet).Tables[MobileOrderIssueRestrictionProfile.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(MobileOrderIssueRestrictionProfile x_oMobileOrderIssueRestrictionProfile)
        {
            return MobileOrderIssueRestrictionProfileBal.GetDataSet(x_oMobileOrderIssueRestrictionProfile, null, MobileOrderIssueRestrictionProfileInfoDLL.CreateInfoInstanceObject()).Tables[MobileOrderIssueRestrictionProfile.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            return Row(x_oTable, x_oDB,x_iMid,MobileOrderIssueRestrictionProfileInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid, MobileOrderIssueRestrictionProfileInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iMid, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid,MobileOrderIssueRestrictionProfileInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderIssueRestrictionProfileInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [MobileOrderIssueRestrictionProfile].[active] AS MOBILEORDERISSUERESTRICTIONPROFILE_ACTIVE,[MobileOrderIssueRestrictionProfile].[cdate] AS MOBILEORDERISSUERESTRICTIONPROFILE_CDATE,[MobileOrderIssueRestrictionProfile].[mrt_no] AS MOBILEORDERISSUERESTRICTIONPROFILE_MRT_NO,[MobileOrderIssueRestrictionProfile].[cid] AS MOBILEORDERISSUERESTRICTIONPROFILE_CID,[MobileOrderIssueRestrictionProfile].[mid] AS MOBILEORDERISSUERESTRICTIONPROFILE_MID,[MobileOrderIssueRestrictionProfile].[restriction_id] AS MOBILEORDERISSUERESTRICTIONPROFILE_RESTRICTION_ID  FROM  [MobileOrderIssueRestrictionProfile]  WHERE  [MobileOrderIssueRestrictionProfile].[mid] = \'"+x_iMid.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderIssueRestrictionProfile]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestrictionProfile]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONPROFILE_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILEORDERISSUERESTRICTIONPROFILE_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONPROFILE_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERISSUERESTRICTIONPROFILE_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.mrt_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONPROFILE_MRT_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.mrt_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.mrt_no).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERISSUERESTRICTIONPROFILE_MRT_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.mrt_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.cid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONPROFILE_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.cid).AliasName].ToString()] = (string)_oData["MOBILEORDERISSUERESTRICTIONPROFILE_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.cid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.mid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONPROFILE_MID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.mid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.mid).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERISSUERESTRICTIONPROFILE_MID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.mid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.restriction_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONPROFILE_RESTRICTION_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.restriction_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.restriction_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERISSUERESTRICTIONPROFILE_RESTRICTION_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.restriction_id).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,MobileOrderIssueRestrictionProfile x_oMobileOrderIssueRestrictionProfileRow)
        {
            return SetByDataSetRowProc(x_iROW, MobileOrderIssueRestrictionProfile.Para.TableName(), x_oDataSet,x_oMobileOrderIssueRestrictionProfileRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderIssueRestrictionProfile x_oMobileOrderIssueRestrictionProfileRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oMobileOrderIssueRestrictionProfileRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderIssueRestrictionProfile x_oMobileOrderIssueRestrictionProfileRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                MobileOrderIssueRestrictionProfileInfo _oTableSet=MobileOrderIssueRestrictionProfileInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.mid).AliasName))
                    x_oMobileOrderIssueRestrictionProfileRow.mid = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.mid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.cdate).AliasName))
                    x_oMobileOrderIssueRestrictionProfileRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.mrt_no).AliasName))
                    x_oMobileOrderIssueRestrictionProfileRow.mrt_no = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.mrt_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.cid).AliasName))
                    x_oMobileOrderIssueRestrictionProfileRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.active).AliasName))
                    x_oMobileOrderIssueRestrictionProfileRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.restriction_id).AliasName))
                    x_oMobileOrderIssueRestrictionProfileRow.restriction_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderIssueRestrictionProfile.Para.restriction_id).AliasName];
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
            return MobileOrderIssueRestrictionProfileRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static MobileOrderIssueRestrictionProfileEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return MobileOrderIssueRestrictionProfileRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static MobileOrderIssueRestrictionProfileEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return MobileOrderIssueRestrictionProfileRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderIssueRestrictionProfileRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderIssueRestrictionProfileRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderIssueRestrictionProfileRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate,global::System.Nullable<int> x_iMrt_no,string x_sCid,global::System.Nullable<bool> x_bActive,global::System.Nullable<int> x_iRestriction_id)
        {
            return MobileOrderIssueRestrictionProfileRepository.Insert(x_oDB, x_dCdate,x_iMrt_no,x_sCid,x_bActive,x_iRestriction_id);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderIssueRestrictionProfile x_oMobileOrderIssueRestrictionProfile)
        {
            return MobileOrderIssueRestrictionProfileRepository.InsertWithOutLastID(x_oDB,x_oMobileOrderIssueRestrictionProfile);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,global::System.Nullable<int> x_iMrt_no,string x_sCid,global::System.Nullable<bool> x_bActive,global::System.Nullable<int> x_iRestriction_id)
        {
            return MobileOrderIssueRestrictionProfileRepository.InsertReturnLastID_SP(x_oDB,x_dCdate,x_iMrt_no,x_sCid,x_bActive,x_iRestriction_id);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderIssueRestrictionProfile x_oMobileOrderIssueRestrictionProfile)
        {
            return MobileOrderIssueRestrictionProfileRepository.InsertReturnLastID_SP(x_oDB,x_oMobileOrderIssueRestrictionProfile);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return MobileOrderIssueRestrictionProfileRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderIssueRestrictionProfileRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            return MobileOrderIssueRestrictionProfileRepository.Delete(x_oDB, x_iMid);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(MobileOrderIssueRestrictionProfile x_oMobileOrderIssueRestrictionProfileRow){
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


